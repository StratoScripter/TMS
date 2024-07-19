using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Base;
using DAL.Base.SQSConfig;
using DAL.SQLServer.SQSConfig;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using DevComponents.DotNetBar.Layout;
using DevComponents.Editors;
using Model;
using Model.SQSConfig;
using SQSClient.Properties;

namespace SQSClient
{
	// Token: 0x02000016 RID: 22
	public partial class frmTicketBatchSubHouse : BaseDialogForm
	{
		// Token: 0x060000CF RID: 207 RVA: 0x00019884 File Offset: 0x00017A84
		public frmTicketBatchSubHouse(string text, BaseForm.FormActtion act, int id, string dir)
		{
			this.InitializeComponent();
			this.SetText(this);
			this.Text = text;
			this._Act = act;
			this._CurrentId = id;
			this._Direct = dir;
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x000198F5 File Offset: 0x00017AF5
		private void frmTicketBatchSubHouse_Load(object sender, EventArgs e)
		{
			this.LoadData();
			this.InitControl();
			this.InitUnitByProduct(this._mod.InvCode);
			this.InitLoadMode(this._mod.BusinessType, this._mod.LoadMode);
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00019938 File Offset: 0x00017B38
		public void InitControl()
		{
			this.tbxDanHao.ReadOnly = true;
			this.tbxInvCode.ReadOnly = true;
			this.tbxInvName.ReadOnly = true;
			this.mIsSubHouseEdit = (this._mod.Spare10.Equals("0") || this._mod.Spare10.Equals(""));
			this.btnAdd.Enabled = this.mIsSubHouseEdit;
			this.cmbUnit.Enabled = this.mIsSubHouseEdit;
			this.layoutControl1.RootGroup.Items.Clear();
			this.layoutControl1.Controls.Clear();
			this._layItemList.Clear();
			List<ModT_ticketbatch> listByTicketId = DAL.Base.SQSConfig.DalT_ticketbatch.Instance.GetListByTicketId(this._mod.Id);
			foreach (ModT_ticketbatch value in listByTicketId)
			{
				this.AddTicketBatchControl(value);
			}
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00019A58 File Offset: 0x00017C58
		protected override void LoadData()
		{
			bool flag = BaseForm.FormActtion.Import == this._Act;
			if (flag)
			{
				this._mod = this._Dal.GetModel(this._CurrentId);
				bool flag2 = this._mod == null;
				if (flag2)
				{
					base.ShowMsg(Messages.ObjNonExist, "", "");
					base.Close();
				}
				else
				{
					this.tbxDanHao.Text = this._mod.DanHao;
					this.tbxInvCode.Text = this._mod.InvCode;
					this.tbxInvName.Text = this._mod.ProductName;
					this.tbxLisence.Text = this._mod.Lisence;
					this.tbxClientPart.Text = this._mod.ClientPart;
					this.dInputJiHuaLiang.Value = (double)this._mod.JiHuaLiang;
				}
			}
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00019B54 File Offset: 0x00017D54
		private void btnSave_Click(object sender, EventArgs e)
		{
			bool flag = !this.InfoBaseCheck();
			if (!flag)
			{
				bool flag2 = false;
				bool flag3 = BaseForm.FormActtion.Import == this._Act;
				if (flag3)
				{
					this.TicketBatchModify();
					bool flag4 = !this.CheckTicketBatchValue();
					if (flag4)
					{
						return;
					}
					flag2 = this.UpdateTicket();
				}
				bool flag5 = flag2;
				if (flag5)
				{
					base.DialogResult = DialogResult.Yes;
				}
			}
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00019BB4 File Offset: 0x00017DB4
		private bool CheckTicketBatchValue()
		{
			List<ModT_ticketbatch> listByTicketId = DAL.Base.SQSConfig.DalT_ticketbatch.Instance.GetListByTicketId(this._mod.Id);
			decimal value = listByTicketId.Sum((ModT_ticketbatch o) => o.QuantityBatch);
			bool flag = !this._mod.JiHuaLiang.Equals(value);
			bool result;
			if (flag)
			{
				base.ShowMsg("TicketHouseAccord", "", "");
				result = false;
			}
			else
			{
				result = true;
			}
			return result;
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00019C3C File Offset: 0x00017E3C
		private bool UpdateTicket()
		{
			List<string> list = new List<string>();
			List<object> list2 = new List<object>();
			list.Add("UnitName");
			list2.Add(this.cmbUnit.Text);
			list.Add("Remark");
			list2.Add(this.GetSubHouseInfo());
			list.Add("Spare10");
			list2.Add(1);
			list.Add("ClientPartId");
			list2.Add(this.GetClientCode(this._mod.ClientPart));
			list.Add("LoadMode");
			list2.Add(this.cmbLoadMode.Text.Trim());
			return DAL.Base.SQSConfig.DalT_ticket.Instance.Update(list, list2, this._mod.Id);
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00019D10 File Offset: 0x00017F10
		private int GetClientCode(string name)
		{
			ModT_client modelByName = DAL.Base.SQSConfig.DalT_client.Instance.GetModelByName(name);
			bool flag = modelByName == null;
			int result;
			if (flag)
			{
				result = 0;
			}
			else
			{
				try
				{
					result = Convert.ToInt32(modelByName.Code);
				}
				catch
				{
					result = 0;
				}
			}
			return result;
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x00019D60 File Offset: 0x00017F60
		private bool TicketBatchModify()
		{
			foreach (LayoutItemBase layoutItemBase in this._layItemList)
			{
				LayoutControlItem layoutControlItem = (LayoutControlItem)layoutItemBase;
				((TicketHouseControl)layoutControlItem.Control).SaveValue();
			}
			this.OnOperateSuccess(this._mod.DanHao, true);
			return true;
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00019DE4 File Offset: 0x00017FE4
		private bool Modify()
		{
			ModT_ticket oldValue = this._mod.Clone() as ModT_ticket;
			bool flag = base.IsExistOutSelf("t_client", "Name", this._mod.DanHao, SqlDbType.NVarChar, this._CurrentId);
			bool result;
			if (flag)
			{
				base.ShowMsg(Messages.ClientpartHaved, "", "");
				result = false;
			}
			else
			{
				bool flag2 = !this._Dal.Update(this._mod);
				if (flag2)
				{
					this.OnOperateFail(this._mod, false);
					base.ShowMsg(Messages.ModifyFalse, "", "");
					result = false;
				}
				else
				{
					this.OnOperateSuccess(this._mod, oldValue, true);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00019EA4 File Offset: 0x000180A4
		private bool InfoBaseCheck()
		{
			this._mod = this._Dal.GetModel(this._mod.Id);
			bool flag = this._mod.CardNum.Trim().Length != 8;
			bool result;
			if (flag)
			{
				base.ShowMsg("ICCardSure", "", "");
				result = false;
			}
			else
			{
				bool flag2 = !this._mod.IsCard && this._mod.StepProcess != "end";
				if (flag2)
				{
					base.ShowMsg("ICCardSure", "", "");
					result = false;
				}
				else
				{
					bool flag3 = string.IsNullOrWhiteSpace(this.cmbUnit.Text.Trim()) && string.IsNullOrWhiteSpace(this.cmbLoadMode.Text.Trim());
					if (flag3)
					{
						base.ShowMsg("UnitNameOrLoadModeSure", "", "");
						this.cmbUnit.Focus();
						result = false;
					}
					else
					{
						result = true;
					}
				}
			}
			return result;
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00019FB0 File Offset: 0x000181B0
		private void btnAdd_Click(object sender, EventArgs e)
		{
			bool flag = this._mod.InvCode.Length == 0;
			if (flag)
			{
				base.ShowMsg(Messages.InvCodeSaveCheck, "", "");
				this.btnSave.Focus();
			}
			else
			{
				ModT_ticketbatch modT_ticketbatch = new ModT_ticketbatch();
				modT_ticketbatch.TicketId = this._mod.Id;
				modT_ticketbatch.BatchCode = this.GetNewBatchCode(this._mod.InvCode);
				modT_ticketbatch.QuantityBatch = 0m;
				modT_ticketbatch.NumBatch = 0m;
				modT_ticketbatch.ExtBatchCode = "";
				modT_ticketbatch.BatchStatus = 0;
				DAL.Base.SQSConfig.DalT_ticketbatch.Instance.AddNoReturn(modT_ticketbatch);
				this.RegularTicketBatchValue();
				this.InitControl();
			}
		}

		// Token: 0x060000DB RID: 219 RVA: 0x0001A070 File Offset: 0x00018270
		private string GetNewBatchCode(string invCode)
		{
			DateTime now = DateTime.Now;
			int maxIndex = DanHaoHelper.Instance().GetMaxIndex("BC", now);
			return string.Concat(new string[]
			{
				invCode,
				"-",
				now.ToString("yyMMdd"),
				"-",
				maxIndex.ToString()
			});
		}

		// Token: 0x060000DC RID: 220 RVA: 0x0001A0D4 File Offset: 0x000182D4
		private void AddTicketBatchControl(ModT_ticketbatch value)
		{
			TicketHouseControl ticketHouseControl = new TicketHouseControl();
			ticketHouseControl.Margin = new System.Windows.Forms.Padding(0);
			ticketHouseControl.Name = "ticketBatchPart" + (this._layItemList.Count + 1).ToString();
			ticketHouseControl.Size = new Size(230, 23);
			ticketHouseControl.TicketBatch = value;
			ticketHouseControl.IsEdit = this.mIsSubHouseEdit;
			ticketHouseControl.DeleteEvent += this.ticketBatchPart_DeleteEvent;
			ticketHouseControl.LoadData();
			LayoutControlItem layoutControlItem = new LayoutControlItem();
			layoutControlItem.Control = ticketHouseControl;
			layoutControlItem.Height = 38;
			layoutControlItem.Name = "layTicketBatch" + (this._layItemList.Count + 1).ToString();
			layoutControlItem.Text = ShowWords.ReplaceText("SubHouse") + " " + (this._layItemList.Count + 1).ToString();
			layoutControlItem.TextAlignment = DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			layoutControlItem.TextLineAlignment = eTextLineAlignment.Bottom;
			layoutControlItem.Width = 290;
			layoutControlItem.WidthType = eLayoutSizeType.Percent;
			this.layoutControl1.RootGroup.Items.Add(layoutControlItem);
			this.layoutControl1.Controls.Add(ticketHouseControl);
			this._layItemList.Add(layoutControlItem);
		}

		// Token: 0x060000DD RID: 221 RVA: 0x0001A224 File Offset: 0x00018424
		private void ticketBatchPart_DeleteEvent(object sender, EventArgs e)
		{
			this.RegularTicketBatchValue();
			this.InitControl();
		}

		// Token: 0x060000DE RID: 222 RVA: 0x0001A238 File Offset: 0x00018438
		private LayoutItemBase FindLayItem(Control col)
		{
			LayoutItemBase result = null;
			foreach (object obj in this.layoutControl1.RootGroup.Items)
			{
				LayoutControlItem layoutControlItem = (LayoutControlItem)obj;
				bool flag = layoutControlItem.Control == col;
				if (flag)
				{
					result = layoutControlItem;
					break;
				}
			}
			return result;
		}

		// Token: 0x060000DF RID: 223 RVA: 0x0001A2B8 File Offset: 0x000184B8
		private void RegularTicketBatchValue()
		{
			List<ModT_ticketbatch> listByTicketId = DAL.Base.SQSConfig.DalT_ticketbatch.Instance.GetListByTicketId(this._mod.Id);
			bool flag = listByTicketId.Count == 0;
			if (!flag)
			{
				decimal num = Convert.ToDecimal((this._mod.JiHuaLiang / listByTicketId.Count).ToString("F0"));
				int num2 = 0;
				decimal num3 = 0m;
				foreach (ModT_ticketbatch modT_ticketbatch in listByTicketId)
				{
					bool flag2 = num2 == listByTicketId.Count - 1;
					if (flag2)
					{
						modT_ticketbatch.QuantityBatch = this._mod.JiHuaLiang - num3;
					}
					else
					{
						modT_ticketbatch.QuantityBatch = num;
						num3 += num;
					}
					num2++;
					modT_ticketbatch.BatchCode = this._mod.DanHao + "-" + num2.ToString();
					DAL.Base.SQSConfig.DalT_ticketbatch.Instance.Update(modT_ticketbatch);
				}
			}
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x0001A3E8 File Offset: 0x000185E8
		private void InitUnitByProduct(string invcode)
		{
			frmTicketBatchSubHouse.<>c__DisplayClass21_0 CS$<>8__locals1 = new frmTicketBatchSubHouse.<>c__DisplayClass21_0();
			frmTicketBatchSubHouse.<>c__DisplayClass21_0 CS$<>8__locals2 = CS$<>8__locals1;
			ModT_product model = DAL.Base.SQSConfig.DalT_product.Instance.GetModel("InvCode", invcode);
			CS$<>8__locals2.productcode = ((model != null) ? model.Code.ToString() : null);
			List<ModCfg_unit> list = DAL.Base.SQSConfig.DalCfg_unit.Instance.GetList("State", true);
			List<ModCfg_unit> list2 = list.FindAll(delegate(ModCfg_unit t)
			{
				List<string> list3 = new List<string>();
				list3.AddRange(t.CurProductCodeList.Split(new char[]
				{
					','
				}));
				return list3.Contains(CS$<>8__locals1.productcode);
			});
			this.cmbUnit.BindDataSouce(list2, "Name", "PinYinMa", "Id");
			this.cmbUnit.Text = this._mod.UnitName;
			this.CheckUnitQueue();
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x0001A48C File Offset: 0x0001868C
		private void InitLoadMode(int businessType, string loadModeName)
		{
			string value = string.Empty;
			bool flag = businessType == 1;
			if (flag)
			{
				value = "LoadMode";
			}
			else
			{
				value = "UnloadMode";
			}
			List<ModCfg_pdasetting> list = DAL.Base.SQSConfig.DalCfg_pdasetting.Instance.GetList("Type", value);
			this.cmbLoadMode.BindDataSouce(list, "Name", "Name", "Id");
			this.cmbLoadMode.Text = loadModeName;
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x0001A4F4 File Offset: 0x000186F4
		private string GetSubHouseInfo()
		{
			string text = string.Empty;
			List<ModT_ticketbatch> listByTicketId = DAL.Base.SQSConfig.DalT_ticketbatch.Instance.GetListByTicketId(this._mod.Id);
			foreach (ModT_ticketbatch modT_ticketbatch in listByTicketId)
			{
				text = text + (modT_ticketbatch.QuantityBatch / 1000m).ToString() + ShowWords.ReplaceText("TonUnit") + ";";
			}
			return text.Trim(new char[]
			{
				';'
			});
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x0001A5AC File Offset: 0x000187AC
		private void CheckUnitQueue()
		{
			bool flag = this.cmbUnit.Text.Trim().Length > 0;
			if (flag)
			{
				this.labHeWeiCount.Text = ShowWords.ReplaceText("Queue") + DAL.Base.SQSConfig.DalT_ticket.Instance.GetCountByUnit(this.cmbUnit.Text, 0).ToString();
				LabelX labelX = this.labHeWeiCount;
				labelX.Text = labelX.Text + "  " + ShowWords.ReplaceText("SurplusJiHuaLiang") + DAL.Base.SQSConfig.DalT_ticket.Instance.GetSumValueByUnit(this.cmbUnit.Text, 0, "JiHuaLiang").ToString("F0");
			}
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x0001A662 File Offset: 0x00018862
		private void cmbUnit_SelectedValueChanged(object sender, EventArgs e)
		{
			this.CheckUnitQueue();
		}

		// Token: 0x0400019E RID: 414
		private ModT_ticket _mod = new ModT_ticket();

		// Token: 0x0400019F RID: 415
		private DAL.SQLServer.SQSConfig.DalT_ticket _Dal = DAL.Base.SQSConfig.DalT_ticket.Instance;

		// Token: 0x040001A0 RID: 416
		private bool mIsSubHouseEdit = true;

		// Token: 0x040001A1 RID: 417
		protected List<LayoutItemBase> _layItemList = new List<LayoutItemBase>();
	}
}
