using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Assistant;
using Base;
using DAL.Base.SQSConfig;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using DevComponents.DotNetBar.Layout;
using Model;
using Model.SQSConfig;
using SQSClient.Properties;

namespace SQSClient
{
	// Token: 0x0200007D RID: 125
	public partial class frmPassword : BaseDialogForm
	{
		// Token: 0x060006DB RID: 1755 RVA: 0x000A9174 File Offset: 0x000A7374
		public frmPassword(string text, BaseForm.FormActtion act, int id)
		{
			this.InitializeComponent();
			this.SetText(this);
			this.Text = text;
			this._Act = act;
			this._CurrentId = id;
		}

		// Token: 0x060006DC RID: 1756 RVA: 0x00003040 File Offset: 0x00001240
		private void frmPassword_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x060006DD RID: 1757 RVA: 0x000A91AC File Offset: 0x000A73AC
		private void btnSave_Click(object sender, EventArgs e)
		{
			bool flag = GlobalKey.GroupId > 0 && GlobalKey.UserName.Length > 0;
			if (flag)
			{
				bool flag2 = !this.TextCheck();
				if (!flag2)
				{
					ModSys_user model = DalSys_user.Instance.GetModel("UserName", GlobalKey.UserName);
					bool flag3 = !CodeHelper.GetMD5(this.tbxOldPwd.Text.Trim()).Equals(model.Password);
					if (flag3)
					{
						base.ShowMsg(Messages.PwdError, "", "");
						this.tbxOldPwd.Text = string.Empty;
						this.tbxOldPwd.Focus();
					}
					else
					{
						model.Password = CodeHelper.GetMD5(this.tbxNewPwd.Text.Trim());
						bool flag4 = DalSys_user.Instance.Update(model);
						if (flag4)
						{
							base.Close();
						}
						else
						{
							base.ShowMsg(Messages.ModifyFalse, "", "");
						}
					}
				}
			}
			else
			{
				base.ShowMsg(Messages.PwdModifyFalse, "", "");
			}
		}

		// Token: 0x060006DE RID: 1758 RVA: 0x000A92CC File Offset: 0x000A74CC
		private bool TextCheck()
		{
			bool flag = string.IsNullOrWhiteSpace(this.tbxOldPwd.Text);
			bool result;
			if (flag)
			{
				base.ShowMsg(Messages.PwdNull, "", "");
				result = false;
			}
			else
			{
				bool flag2 = !RegexHelper.IsNumAndEnCh(this.tbxNewPwd.Text);
				if (flag2)
				{
					base.ShowMsg(Messages.PwdCheck, "", "");
					result = false;
				}
				else
				{
					bool flag3 = !this.tbxNewPwd.Text.Equals(this.tbxNewPwd2.Text);
					if (flag3)
					{
						base.ShowMsg(Messages.PwdEqual, "", "");
						this.tbxNewPwd.Text = string.Empty;
						this.tbxNewPwd2.Text = string.Empty;
						this.tbxNewPwd.Focus();
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
	}
}
