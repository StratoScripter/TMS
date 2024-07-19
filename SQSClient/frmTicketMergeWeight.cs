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
	// Token: 0x02000019 RID: 25
	public partial class frmTicketMergeWeight : BaseDialogForm
	{
		// Token: 0x0600011E RID: 286 RVA: 0x00025990 File Offset: 0x00023B90
		public frmTicketMergeWeight(string text, BaseForm.FormActtion act, int id, string dir)
		{
			this.InitializeComponent();
			this.SetText(this);
			this.Text = text;
			this._Act = act;
			this._CurrentId = id;
			this._Direct = dir;
		}

		// Token: 0x0600011F RID: 287 RVA: 0x00025A01 File Offset: 0x00023C01
		private void frmTicketMergeWeight_Load(object sender, EventArgs e)
		{
			this.LoadData();
			this.InitControl();
			this.InitUnitByProduct(this._mod.InvCode);
			this.InitLoadMode(this._mod.BusinessType, this._mod.LoadMode);
		}

		// Token: 0x06000120 RID: 288 RVA: 0x00025A44 File Offset: 0x00023C44
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

		// Token: 0x06000121 RID: 289 RVA: 0x00025B64 File Offset: 0x00023D64
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

		// Token: 0x06000122 RID: 290 RVA: 0x00025C60 File Offset: 0x00023E60
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

		// Token: 0x06000123 RID: 291 RVA: 0x00025CC0 File Offset: 0x00023EC0
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

		// Token: 0x06000124 RID: 292 RVA: 0x00025D48 File Offset: 0x00023F48
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

		// Token: 0x06000125 RID: 293 RVA: 0x00025E1C File Offset: 0x0002401C
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

		// Token: 0x06000126 RID: 294 RVA: 0x00025E6C File Offset: 0x0002406C
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

		// Token: 0x06000127 RID: 295 RVA: 0x00025EF0 File Offset: 0x000240F0
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

		// Token: 0x06000128 RID: 296 RVA: 0x00025FB0 File Offset: 0x000241B0
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

		// Token: 0x06000129 RID: 297 RVA: 0x000260BC File Offset: 0x000242BC
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

		// Token: 0x0600012A RID: 298 RVA: 0x0002617C File Offset: 0x0002437C
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

		// Token: 0x0600012B RID: 299 RVA: 0x000261E0 File Offset: 0x000243E0
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

		// Token: 0x0600012C RID: 300 RVA: 0x00026330 File Offset: 0x00024530
		private void ticketBatchPart_DeleteEvent(object sender, EventArgs e)
		{
			this.RegularTicketBatchValue();
			this.InitControl();
		}

		// Token: 0x0600012D RID: 301 RVA: 0x00026344 File Offset: 0x00024544
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

		// Token: 0x0600012E RID: 302 RVA: 0x000263C4 File Offset: 0x000245C4
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

		// Token: 0x0600012F RID: 303 RVA: 0x000264F4 File Offset: 0x000246F4
		private void InitUnitByProduct(string invcode)
		{
			frmTicketMergeWeight.<>c__DisplayClass21_0 CS$<>8__locals1 = new frmTicketMergeWeight.<>c__DisplayClass21_0();
			frmTicketMergeWeight.<>c__DisplayClass21_0 CS$<>8__locals2 = CS$<>8__locals1;
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

		// Token: 0x06000130 RID: 304 RVA: 0x00026598 File Offset: 0x00024798
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

		// Token: 0x06000131 RID: 305 RVA: 0x00026600 File Offset: 0x00024800
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

		// Token: 0x06000132 RID: 306 RVA: 0x000266B8 File Offset: 0x000248B8
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

		// Token: 0x06000133 RID: 307 RVA: 0x0002676E File Offset: 0x0002496E
		private void cmbUnit_SelectedValueChanged(object sender, EventArgs e)
		{
			this.CheckUnitQueue();
		}

		// Token: 0x04000232 RID: 562
		private ModT_ticket _mod = new ModT_ticket();

		// Token: 0x04000233 RID: 563
		private DAL.SQLServer.SQSConfig.DalT_ticket _Dal = DAL.Base.SQSConfig.DalT_ticket.Instance;

		// Token: 0x04000234 RID: 564
		private bool mIsSubHouseEdit = true;

		// Token: 0x04000235 RID: 565
		protected List<LayoutItemBase> _layItemList = new List<LayoutItemBase>();
	}
}
