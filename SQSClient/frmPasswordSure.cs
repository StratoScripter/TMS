using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Assistant;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using DevComponents.DotNetBar.Layout;
using Model;
using SQSClient.Properties;

namespace SQSClient
{
	// Token: 0x0200002A RID: 42
	public partial class frmPasswordSure : BaseDialogForm
	{
		// Token: 0x06000210 RID: 528 RVA: 0x0003D3EB File Offset: 0x0003B5EB
		public frmPasswordSure(string text)
		{
			this.InitializeComponent();
			this.SetText(this);
			this.Text = text;
		}

		// Token: 0x06000211 RID: 529 RVA: 0x00003040 File Offset: 0x00001240
		private void frmPasswordSure_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x06000212 RID: 530 RVA: 0x0003D414 File Offset: 0x0003B614
		private void btnSave_Click(object sender, EventArgs e)
		{
			bool flag = !this.TextCheck();
			if (flag)
			{
				base.DialogResult = DialogResult.No;
			}
			bool flag2 = "9f2b6dec116ac522df7b40bc71d345f0" == CodeHelper.GetMD5(this.tbxNewPwd2.Text.Trim());
			if (flag2)
			{
				base.DialogResult = DialogResult.Yes;
			}
			else
			{
				base.DialogResult = DialogResult.No;
			}
		}

		// Token: 0x06000213 RID: 531 RVA: 0x0003D474 File Offset: 0x0003B674
		private bool TextCheck()
		{
			bool flag = string.IsNullOrWhiteSpace(this.tbxNewPwd2.Text);
			bool result;
			if (flag)
			{
				base.ShowMsg(Messages.PwdNull, "", "");
				result = false;
			}
			else
			{
				result = true;
			}
			return result;
		}
	}
}
