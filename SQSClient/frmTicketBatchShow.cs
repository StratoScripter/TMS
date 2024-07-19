using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Base;
using DAL.Base.SQSConfig;
using DAL.SQLServer.SQSConfig;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using DevComponents.DotNetBar.Layout;
using Model;
using Model.SQSConfig;
using SQSClient.Properties;

namespace SQSClient
{
	// Token: 0x0200006B RID: 107
	public partial class frmTicketBatchShow : BaseDialogForm
	{
		// Token: 0x06000562 RID: 1378 RVA: 0x00088DFC File Offset: 0x00086FFC
		public frmTicketBatchShow(string text, BaseForm.FormActtion act, int id, string dir)
		{
			this.InitializeComponent();
			this.SetText(this);
			this.Text = text;
			this._Act = act;
			this._CurrentId = id;
			this._Direct = dir;
		}

		// Token: 0x06000563 RID: 1379 RVA: 0x00088E66 File Offset: 0x00087066
		private void frmTicketBatchShow_Load(object sender, EventArgs e)
		{
			this.LoadData();
			this.InitControl();
		}

		// Token: 0x06000564 RID: 1380 RVA: 0x00088E78 File Offset: 0x00087078
		public void InitControl()
		{
			this.tbxDanHao.ReadOnly = true;
			this.layoutControl1.RootGroup.Items.Clear();
			this.layoutControl1.Controls.Clear();
			this._layItemList.Clear();
			List<ModT_ticketbatch> listByTicketId = DAL.Base.SQSConfig.DalT_ticketbatch.Instance.GetListByTicketId(this._mod.Id);
			foreach (ModT_ticketbatch value in listByTicketId)
			{
				this.AddTicketBatchControl(value);
			}
		}

		// Token: 0x06000565 RID: 1381 RVA: 0x00088F24 File Offset: 0x00087124
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
				}
			}
		}

		// Token: 0x06000566 RID: 1382 RVA: 0x00088FD0 File Offset: 0x000871D0
		private void btnSave_Click(object sender, EventArgs e)
		{
			bool flag = !this.TextCheck();
			if (!flag)
			{
				this.UpdateTicket();
				bool flag2 = false;
				bool flag3 = BaseForm.FormActtion.Import == this._Act;
				if (flag3)
				{
					flag2 = this.TicketBatchModify();
				}
				bool flag4 = flag2;
				if (flag4)
				{
					base.DialogResult = DialogResult.Yes;
				}
			}
		}

		// Token: 0x06000567 RID: 1383 RVA: 0x0008901C File Offset: 0x0008721C
		private void UpdateTicket()
		{
			bool flag = !this._mod.InvCode.Equals(this.tbxInvCode.Text.Trim());
			if (flag)
			{
				this._Dal.UpdateInvCode(this.tbxInvCode.Text.Trim(), this._mod.Id.ToString());
			}
		}

		// Token: 0x06000568 RID: 1384 RVA: 0x00089084 File Offset: 0x00087284
		private bool TicketBatchModify()
		{
			foreach (LayoutItemBase layoutItemBase in this._layItemList)
			{
				LayoutControlItem layoutControlItem = (LayoutControlItem)layoutItemBase;
				((TicketBatchControl)layoutControlItem.Control).SaveValue();
			}
			this.OnOperateSuccess(this._mod.DanHao, true);
			return true;
		}

		// Token: 0x06000569 RID: 1385 RVA: 0x00089108 File Offset: 0x00087308
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

		// Token: 0x0600056A RID: 1386 RVA: 0x000891C8 File Offset: 0x000873C8
		private bool TextCheck()
		{
			bool flag = string.IsNullOrWhiteSpace(this.tbxInvCode.Text.Trim());
			bool result;
			if (flag)
			{
				base.ShowMsg(Messages.InvCodeNull, "", "");
				this.tbxInvCode.Focus();
				result = false;
			}
			else
			{
				result = true;
			}
			return result;
		}

		// Token: 0x0600056B RID: 1387 RVA: 0x0008921C File Offset: 0x0008741C
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
				modT_ticketbatch.BatchStatus = 1;
				DAL.Base.SQSConfig.DalT_ticketbatch.Instance.AddNoReturn(modT_ticketbatch);
				this.InitControl();
			}
		}

		// Token: 0x0600056C RID: 1388 RVA: 0x000892D8 File Offset: 0x000874D8
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

		// Token: 0x0600056D RID: 1389 RVA: 0x0008933C File Offset: 0x0008753C
		private void AddTicketBatchControl(ModT_ticketbatch value)
		{
			TicketBatchControl ticketBatchControl = new TicketBatchControl();
			ticketBatchControl.Margin = new System.Windows.Forms.Padding(0);
			ticketBatchControl.Name = "ticketBatchPart" + (this._layItemList.Count + 1).ToString();
			ticketBatchControl.Size = new Size(230, 23);
			ticketBatchControl.TicketBatch = value;
			ticketBatchControl.DeleteEvent += this.ticketBatchPart_DeleteEvent;
			ticketBatchControl.LoadData();
			LayoutControlItem layoutControlItem = new LayoutControlItem();
			layoutControlItem.Control = ticketBatchControl;
			layoutControlItem.Height = 38;
			layoutControlItem.Name = "layTicketBatch" + (this._layItemList.Count + 1).ToString();
			layoutControlItem.Text = ShowWords.ReplaceText("layTicketBatch") + " " + (this._layItemList.Count + 1).ToString();
			layoutControlItem.TextAlignment = eTextAlignment.Right;
			layoutControlItem.TextLineAlignment = eTextLineAlignment.Bottom;
			layoutControlItem.Width = 290;
			layoutControlItem.WidthType = eLayoutSizeType.Percent;
			this.layoutControl1.RootGroup.Items.Add(layoutControlItem);
			this.layoutControl1.Controls.Add(ticketBatchControl);
			this._layItemList.Add(layoutControlItem);
		}

		// Token: 0x0600056E RID: 1390 RVA: 0x0008947F File Offset: 0x0008767F
		private void ticketBatchPart_DeleteEvent(object sender, EventArgs e)
		{
			this.InitControl();
		}

		// Token: 0x0600056F RID: 1391 RVA: 0x0008948C File Offset: 0x0008768C
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

		// Token: 0x04000973 RID: 2419
		private ModT_ticket _mod = new ModT_ticket();

		// Token: 0x04000974 RID: 2420
		private DAL.SQLServer.SQSConfig.DalT_ticket _Dal = DAL.Base.SQSConfig.DalT_ticket.Instance;

		// Token: 0x04000975 RID: 2421
		protected List<LayoutItemBase> _layItemList = new List<LayoutItemBase>();
	}
}
