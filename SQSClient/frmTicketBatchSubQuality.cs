using System;
using System.Collections.Generic;
using System.ComponentModel;
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
	// Token: 0x02000017 RID: 23
	public partial class frmTicketBatchSubQuality : BaseDialogForm
	{
		// Token: 0x060000E7 RID: 231 RVA: 0x0001BA74 File Offset: 0x00019C74
		public frmTicketBatchSubQuality(string text, BaseForm.FormActtion act, int id, string dir)
		{
			this.InitializeComponent();
			this.SetText(this);
			this.Text = text;
			this._Act = act;
			this._CurrentId = id;
			this._Direct = dir;
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x0001BAF8 File Offset: 0x00019CF8
		private void frmTicketBatchSubQuality_Load(object sender, EventArgs e)
		{
			this.LoadData();
			this.InitControl();
			this.dInputWeightDiff.IsInputReadOnly = true;
			this.dInputNumBatchModify.IsInputReadOnly = true;
			this.dInputWeightDiff.MouseWheel += this.Num_DiscountAmount_MouseWheel;
			this.dInputNumBatchModify.MouseWheel += this.Num_DiscountAmount_MouseWheel;
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x0001BB60 File Offset: 0x00019D60
		private new void Num_DiscountAmount_MouseWheel(object sender, MouseEventArgs e)
		{
			HandledMouseEventArgs handledMouseEventArgs = e as HandledMouseEventArgs;
			bool flag = handledMouseEventArgs != null;
			if (flag)
			{
				handledMouseEventArgs.Handled = true;
			}
		}

		// Token: 0x060000EA RID: 234 RVA: 0x0001BB88 File Offset: 0x00019D88
		public void InitControl()
		{
			this.tbxDanHao.ReadOnly = true;
			this.tbxInvCode.ReadOnly = true;
			this.tbxInvName.ReadOnly = true;
			this.mIsSubHouseEdit = (this._mod.Spare10.Equals("0") || this._mod.Spare10.Equals(""));
			this.btnWeightImport.Enabled = this.mIsSubHouseEdit;
			this.layoutControl1.RootGroup.Items.Clear();
			this.layoutControl1.Controls.Clear();
			this._layItemList.Clear();
			this._ListTicketBatch = (from o in DAL.Base.SQSConfig.DalT_ticketbatch.Instance.GetListByTicketId(this._mod.Id)
			where o.BatchBusinessType == this.mBatchBusinessType
			select o).ToList<ModT_ticketbatch>();
			foreach (ModT_ticketbatch value in this._ListTicketBatch)
			{
				this.AddTicketBatchControl(value);
			}
		}

		// Token: 0x060000EB RID: 235 RVA: 0x0001BCB4 File Offset: 0x00019EB4
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
					bool flag3 = this._mod.BusinessType == 1;
					if (flag3)
					{
						this.btnWeightImport.Enabled = false;
					}
					this.tbxDanHao.Text = this._mod.DanHao;
					this.tbxInvCode.Text = this._mod.InvCode;
					this.tbxInvName.Text = this._mod.ProductName;
					this.tbxLisence.Text = this._mod.Lisence;
					this.tbxClientPart.Text = this._mod.ClientPart;
					this.tbxWeightDetails.Text = this._mod.Cause;
					bool flag4 = this._mod.WeightProcess >= 2;
					if (flag4)
					{
						this.dInputWeightDiff.Value = (double)Math.Abs(this._mod.SecondWeight - this._mod.FirstWeight);
					}
					else
					{
						this.dInputWeightDiff.Value = 0.0;
					}
				}
			}
		}

		// Token: 0x060000EC RID: 236 RVA: 0x0001BE2C File Offset: 0x0001A02C
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

		// Token: 0x060000ED RID: 237 RVA: 0x0001BE8C File Offset: 0x0001A08C
		private bool CheckTicketBatchValue()
		{
			List<ModT_ticketbatch> listByTicketId = DAL.Base.SQSConfig.DalT_ticketbatch.Instance.GetListByTicketId(this._mod.Id);
			double obj = Convert.ToDouble(listByTicketId.Sum((ModT_ticketbatch o) => o.QuantityBatch));
			bool flag = !this.dInputWeightDiff.Value.Equals(obj);
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

		// Token: 0x060000EE RID: 238 RVA: 0x0001BF1C File Offset: 0x0001A11C
		private bool UpdateTicket()
		{
			List<string> list = new List<string>();
			List<object> list2 = new List<object>();
			list.Add("Cause");
			list2.Add(this.tbxWeightDetails.Text);
			return DAL.Base.SQSConfig.DalT_ticket.Instance.Update(list, list2, this._mod.Id);
		}

		// Token: 0x060000EF RID: 239 RVA: 0x0001BF70 File Offset: 0x0001A170
		private bool TicketBatchModify()
		{
			foreach (LayoutItemBase layoutItemBase in this._layItemList)
			{
				LayoutControlItem layoutControlItem = (LayoutControlItem)layoutItemBase;
				((TicketSubQualityControl)layoutControlItem.Control).SaveValue();
			}
			this.OnOperateSuccess(this._mod.DanHao, true);
			return true;
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x0001BFF4 File Offset: 0x0001A1F4
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
					result = true;
				}
			}
			return result;
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x0001C0A4 File Offset: 0x0001A2A4
		private void AddTicketBatchControl(ModT_ticketbatch value)
		{
			TicketSubQualityControl ticketSubQualityControl = new TicketSubQualityControl();
			ticketSubQualityControl.Margin = new System.Windows.Forms.Padding(0);
			ticketSubQualityControl.Name = "ticketBatchPart" + (this._layItemList.Count + 1).ToString();
			ticketSubQualityControl.Size = new Size(230, 50);
			ticketSubQualityControl.TicketBatch = value;
			ticketSubQualityControl.IsEdit = this.mIsSubHouseEdit;
			ticketSubQualityControl.DeleteEvent += this.ticketBatchPart_DeleteEvent;
			ticketSubQualityControl.NumBatchEvent += this.ticketBatchPart_NumBatchEvent;
			ticketSubQualityControl.LoadData();
			LayoutControlItem layoutControlItem = new LayoutControlItem();
			layoutControlItem.Control = ticketSubQualityControl;
			layoutControlItem.Height = 76;
			layoutControlItem.Name = "layTicketBatch" + (this._layItemList.Count + 1).ToString();
			layoutControlItem.Text = ShowWords.ReplaceText("SubTicket") + " " + (this._layItemList.Count + 1).ToString();
			layoutControlItem.TextAlignment = DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			layoutControlItem.TextLineAlignment = eTextLineAlignment.Bottom;
			layoutControlItem.Width = 290;
			layoutControlItem.WidthType = eLayoutSizeType.Percent;
			this.layoutControl1.RootGroup.Items.Add(layoutControlItem);
			this.layoutControl1.Controls.Add(ticketSubQualityControl);
			this._layItemList.Add(layoutControlItem);
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x0001C207 File Offset: 0x0001A407
		private void ticketBatchPart_DeleteEvent(object sender, EventArgs e)
		{
			this.InitControl();
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x0001C211 File Offset: 0x0001A411
		private void ticketBatchPart_NumBatchEvent(object sender, EventArgs e)
		{
			this.dInputNumBatchModify.Value = Convert.ToDouble(this._ListTicketBatch.Sum((ModT_ticketbatch o) => o.NumBatch));
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x0001C250 File Offset: 0x0001A450
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

		// Token: 0x060000F5 RID: 245 RVA: 0x0001C2D0 File Offset: 0x0001A4D0
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

		// Token: 0x060000F6 RID: 246 RVA: 0x00003040 File Offset: 0x00001240
		private void CheckUnitQueue()
		{
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x0001C388 File Offset: 0x0001A588
		private void cmbUnit_SelectedValueChanged(object sender, EventArgs e)
		{
			this.CheckUnitQueue();
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x0001C394 File Offset: 0x0001A594
		private void btnWeightImport_Click(object sender, EventArgs e)
		{
			List<ModT_ticketbatch> listByTicketId = DAL.Base.SQSConfig.DalT_ticketbatch.Instance.GetListByTicketId(this._mod.Id);
			bool flag = listByTicketId.Count > 0;
			if (flag)
			{
				bool flag2 = !base.ShowChoise("ReImportSure", "", "");
				if (flag2)
				{
					return;
				}
			}
			this._mod = this._Dal.GetModel(this._CurrentId);
			bool flag3 = this._mod == null;
			if (flag3)
			{
				base.ShowMsg(Messages.ObjNonExist, "", "");
			}
			else
			{
				string[] array = this._mod.WeightDetails.Split(new char[]
				{
					','
				});
				bool flag4 = array.Length < 2;
				if (flag4)
				{
					base.ShowMsg("WeightIncomplete", "", "");
				}
				else
				{
					List<string> list = new List<string>();
					for (int i = 0; i < array.Length; i++)
					{
						list.Add(array[i].Replace("[", "").Replace("]", ""));
					}
					DAL.Base.SQSConfig.DalT_ticketbatch.Instance.DeleteRequire("TicketId = " + this._mod.Id.ToString());
					int num = list.Count - 1;
					for (int j = 0; j < num; j++)
					{
						ModT_ticketbatch modT_ticketbatch = new ModT_ticketbatch();
						modT_ticketbatch.TicketId = this._mod.Id;
						modT_ticketbatch.BatchCode = this._mod.DanHao + "-" + (j + 1).ToString();
						modT_ticketbatch.BatchSort = j + 1;
						modT_ticketbatch.ExtBatchCode = "";
						modT_ticketbatch.BatchStatus = 0;
						modT_ticketbatch.BatchBusinessType = this.mBatchBusinessType;
						string[] array2 = list[j].Split(new char[]
						{
							'&'
						});
						modT_ticketbatch.Free1 = array2[0];
						modT_ticketbatch.Free2 = array2[1];
						string[] array3 = list[j + 1].Split(new char[]
						{
							'&'
						});
						modT_ticketbatch.Free3 = array3[0];
						modT_ticketbatch.Free4 = array3[1];
						modT_ticketbatch.Memo = list[j] + "," + list[j + 1];
						modT_ticketbatch.QuantityBatch = Math.Abs(Convert.ToDecimal(modT_ticketbatch.Free1) - Convert.ToDecimal(modT_ticketbatch.Free3));
						modT_ticketbatch.NumBatch = modT_ticketbatch.QuantityBatch;
						modT_ticketbatch.BatchLabResult = 10000;
						DAL.Base.SQSConfig.DalT_ticketbatch.Instance.AddNoReturn(modT_ticketbatch);
					}
					this.InitControl();
					this.GetWeightDetails();
				}
			}
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x0001C66C File Offset: 0x0001A86C
		private void GetWeightDetails()
		{
			string text = string.Empty;
			int num = 1;
			foreach (LayoutItemBase layoutItemBase in this._layItemList)
			{
				LayoutControlItem layoutControlItem = (LayoutControlItem)layoutItemBase;
				text = text + string.Format(ShowWords.ReplaceText("WeightCount"), num++) + "：" + ((TicketSubQualityControl)layoutControlItem.Control).GetWeightDetails();
			}
			this.tbxWeightDetails.Text = text;
		}

		// Token: 0x040001BF RID: 447
		private ModT_ticket _mod = new ModT_ticket();

		// Token: 0x040001C0 RID: 448
		private DAL.SQLServer.SQSConfig.DalT_ticket _Dal = DAL.Base.SQSConfig.DalT_ticket.Instance;

		// Token: 0x040001C1 RID: 449
		private bool mIsSubHouseEdit = true;

		// Token: 0x040001C2 RID: 450
		private int mBatchBusinessType = 20;

		// Token: 0x040001C3 RID: 451
		protected List<LayoutItemBase> _layItemList = new List<LayoutItemBase>();

		// Token: 0x040001C4 RID: 452
		protected List<ModT_ticketbatch> _ListTicketBatch = new List<ModT_ticketbatch>();
	}
}
