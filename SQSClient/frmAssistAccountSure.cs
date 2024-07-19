using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
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
	// Token: 0x0200000E RID: 14
	public partial class frmAssistAccountSure : BaseDialogForm
	{
		// Token: 0x0600006C RID: 108 RVA: 0x0000A3F4 File Offset: 0x000085F4
		public frmAssistAccountSure(string text, BaseForm.FormActtion act, int refId, int importId)
		{
			this.InitializeComponent();
			this.SetText(this);
			this.Text = text;
			this._Act = act;
			this._modRef = DalT_ticket.Instance.GetModel("Id", refId);
			this._modImport = DalT_ticket.Instance.GetModel("Id", importId);
		}

		// Token: 0x0600006D RID: 109 RVA: 0x0000A47B File Offset: 0x0000867B
		private void frmAssistAccountSure_Load(object sender, EventArgs e)
		{
			this.InitControl();
			this.LoadData();
		}

		// Token: 0x0600006E RID: 110 RVA: 0x0000A48C File Offset: 0x0000868C
		private void InitControl()
		{
			this.gbxImportTicket.Text = ShowWords.ReplaceText(this.gbxImportTicket.Text);
			this.gbxReferenceTicket.Text = ShowWords.ReplaceText(this.gbxReferenceTicket.Text);
			this.tbxReferenceDanHao.Text = this._modRef.DanHao;
			this.tbxRefInvName.Text = this._modRef.ProductName;
			this.iptRefAssistPlanAccount.Value = Convert.ToInt32(this._modRef.AssistPlanAccount);
			this.iptRefAssistActualAccount.Value = Convert.ToInt32(this._modRef.AssistActualAccount);
			this.tbxImportDanHao.Text = this._modImport.DanHao;
			this.tbxImportInvName.Text = this._modImport.ProductName;
			this.iptImportAssistPlanAccount.Value = Convert.ToInt32(this._modImport.AssistPlanAccount);
			this.iptImportAssistActualAccount.Value = Convert.ToInt32(this._modImport.AssistActualAccount);
			List<BaseForm.EnumModel> list = new List<BaseForm.EnumModel>();
			list.AddRange(BaseForm.GetEnumModelList<AccountType>());
			BaseForm.BindDataSouce(this.cmbImportPostType, list, "Description", "Value");
			List<BaseForm.EnumModel> list2 = new List<BaseForm.EnumModel>();
			list2.AddRange(BaseForm.GetEnumModelList<AccountType>());
			BaseForm.BindDataSouce(this.cmbRefPostType, list2, "Description", "Value");
			this.cmbImportPostType.SelectedValue = this._modImport.AccountType;
			this.cmbRefPostType.SelectedValue = this._modRef.AccountType;
		}

		// Token: 0x0600006F RID: 111 RVA: 0x0000A628 File Offset: 0x00008828
		protected override void LoadData()
		{
			bool flag = BaseForm.FormActtion.Import == this._Act;
			if (flag)
			{
			}
		}

		// Token: 0x06000070 RID: 112 RVA: 0x0000A648 File Offset: 0x00008848
		private bool Modify()
		{
			ModT_ticket oldValue = this._modImport.Clone() as ModT_ticket;
			this._modImport.AssistActualAccount = this.iptImportAssistActualAccount.Value;
			Dictionary<string, object> dictionary = new Dictionary<string, object>();
			dictionary.Add("AssistActualAccount", this._modImport.AssistActualAccount);
			bool flag = DalT_ticket.Instance.Update(dictionary, this._modImport.Id);
			bool result;
			if (flag)
			{
				this.OnOperateSuccess(this._modImport, oldValue, true);
				result = true;
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06000071 RID: 113 RVA: 0x0000A6E0 File Offset: 0x000088E0
		private bool TextCheck()
		{
			decimal d = this.iptImportAssistActualAccount.Value;
			bool flag = d > this._modImport.AssistPlanAccount;
			bool result;
			if (flag)
			{
				base.ShowMsg("AssistActualAccountError", "", "");
				result = false;
			}
			else
			{
				result = true;
			}
			return result;
		}

		// Token: 0x06000072 RID: 114 RVA: 0x0000A734 File Offset: 0x00008934
		private void btnSure_Click(object sender, EventArgs e)
		{
			bool flag = !this.TextCheck();
			if (!flag)
			{
				bool flag2 = false;
				bool flag3 = BaseForm.FormActtion.Import == this._Act;
				if (flag3)
				{
					flag2 = this.Modify();
				}
				bool flag4 = flag2;
				if (flag4)
				{
					base.DialogResult = DialogResult.Yes;
				}
				else
				{
					base.DialogResult = DialogResult.No;
				}
			}
		}

		// Token: 0x06000073 RID: 115 RVA: 0x0000A785 File Offset: 0x00008985
		private void btnCancel_Click(object sender, EventArgs e)
		{
			base.DialogResult = DialogResult.Cancel;
		}

		// Token: 0x0400008B RID: 139
		private ModT_ticket _modRef = new ModT_ticket();

		// Token: 0x0400008C RID: 140
		private ModT_ticket _modImport = new ModT_ticket();
	}
}
