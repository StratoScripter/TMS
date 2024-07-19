using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Assistant;
using Base;
using DAL.Base.SQSConfig;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using DevComponents.DotNetBar.Layout;
using DevComponents.Editors;
using Model;
using Model.SQSConfig;
using SQSClient.Properties;

namespace SQSClient
{
	// Token: 0x0200000F RID: 15
	public partial class frmCreditConfirm : BaseDialogForm
	{
		// Token: 0x06000076 RID: 118 RVA: 0x0000C03C File Offset: 0x0000A23C
		public frmCreditConfirm(ModT_ticket selectMod)
		{
			this.InitializeComponent();
			this.SetText(this);
			this.mModTicket = DalT_ticket.Instance.GetModel(selectMod.Id);
			this._CurrentId = this.mModTicket.Id;
		}

		// Token: 0x06000077 RID: 119 RVA: 0x0000C09C File Offset: 0x0000A29C
		private void frmCreditConfirm_Load(object sender, EventArgs e)
		{
			this.txtContractNum.Text = this.mModTicket.ContractNum;
			this.txtLisence.Text = this.mModTicket.Lisence;
			this.txtProduct.Text = this.mModTicket.ProductName;
			this.txtJieSuanLiang.Text = (this.mModTicket.JieSuanLiang / 1000m).ToString("F3");
			this.dInputSinglePrice.Value = Convert.ToDouble(this.mModTicket.SinglePrice);
			this.txtTotalPrice.Text = (Convert.ToDouble(this.txtJieSuanLiang.Text) * Convert.ToDouble(this.dInputSinglePrice.Value)).ToString("N2");
			this.btnSettle.Enabled = (this.mModTicket.State == 0);
			this.mIsEdit = (this.mModTicket.BdState == 0 && this.mModTicket.State > 0);
			this.btnSure.Enabled = this.mIsEdit;
			this.dInputSinglePrice.Enabled = this.mIsEdit;
		}

		// Token: 0x06000078 RID: 120 RVA: 0x0000C1DC File Offset: 0x0000A3DC
		private void btnSure_Click(object sender, EventArgs e)
		{
			decimal num = Convert.ToDecimal(this.txtTotalPrice.Text);
			decimal num2 = Convert.ToDecimal(this.dInputSinglePrice.Value);
			Dictionary<string, object> dic = new Dictionary<string, object>
			{
				{
					"BdState",
					-100
				},
				{
					"SinglePrice",
					num2
				},
				{
					"TotalPrice",
					num
				},
				{
					"Spare5",
					num
				}
			};
			bool flag = !DalT_ticket.Instance.Update(dic, this.mModTicket.Id);
			if (flag)
			{
				base.ShowMsg(Messages.UpdateFalse, "", "");
			}
			else
			{
				base.DialogResult = DialogResult.Yes;
				base.Close();
			}
		}

		// Token: 0x06000079 RID: 121 RVA: 0x0000C2A0 File Offset: 0x0000A4A0
		private void dInputSinglePrice_ValueChanged(object sender, EventArgs e)
		{
			decimal num = (decimal)(Convert.ToDouble(this.txtJieSuanLiang.Text) * Convert.ToDouble(this.dInputSinglePrice.Value));
			this.txtTotalPrice.Text = num.ToString("N2");
			this.txtTotalPriceDX.Text = Assistant.ChangeNum.ConvertCHM(num);
		}

		// Token: 0x0600007A RID: 122 RVA: 0x0000C300 File Offset: 0x0000A500
		private void btnSettle_Click(object sender, EventArgs e)
		{
			BaseDialogForm baseDialogForm = base.CreateInstance<BaseDialogForm>(typeof(frmReviseAccount), ((ButtonItem)sender).Text, BaseForm.FormActtion.Modify, this._FrmName);
			baseDialogForm.Sender = sender;
			bool flag = baseDialogForm.ShowDialog() == DialogResult.Yes;
			if (flag)
			{
				base.DialogResult = DialogResult.Yes;
				base.Close();
			}
		}

		// Token: 0x0600007B RID: 123 RVA: 0x0000C358 File Offset: 0x0000A558
		private bool SpecialDealWith()
		{
			bool flag = this.mModTicket.BdState == 0;
			bool result;
			if (flag)
			{
				base.ShowMsg("CreditCheckMsg", "", "");
				result = false;
			}
			else
			{
				result = true;
			}
			return result;
		}

		// Token: 0x040000AF RID: 175
		private ModT_ticket mModTicket = null;

		// Token: 0x040000B0 RID: 176
		private bool mIsEdit = true;
	}
}
