using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Assistant;
using Base;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using DevComponents.DotNetBar.Layout;
using Model;
using SQSClient.Properties;

namespace SQSClient
{
	// Token: 0x02000022 RID: 34
	public partial class frmDBConfig : BaseDialogForm
	{
		// Token: 0x06000198 RID: 408 RVA: 0x00031811 File Offset: 0x0002FA11
		public frmDBConfig(string text, BaseForm.FormActtion act, int id)
		{
			this.InitializeComponent();
			this.SetText(this);
			this.Text = text;
			this._Act = act;
			this._CurrentId = id;
		}

		// Token: 0x06000199 RID: 409 RVA: 0x0003184E File Offset: 0x0002FA4E
		private void frmDBConfig_Load(object sender, EventArgs e)
		{
			this.InitControl();
			this.LoadData();
		}

		// Token: 0x0600019A RID: 410 RVA: 0x00003040 File Offset: 0x00001240
		private void InitControl()
		{
		}

		// Token: 0x0600019B RID: 411 RVA: 0x00031860 File Offset: 0x0002FA60
		protected override void LoadData()
		{
			bool flag = BaseForm.FormActtion.Modify == this._Act;
			if (flag)
			{
				this.rtxtConfigConn.Text = ConfigSettings.Instance.ConfigConn;
			}
		}

		// Token: 0x0600019C RID: 412 RVA: 0x00031894 File Offset: 0x0002FA94
		private void btnSave_Click(object sender, EventArgs e)
		{
			bool flag = !this.TextCheck();
			if (flag)
			{
				this.res = false;
			}
			else
			{
				bool flag2 = this._Act == BaseForm.FormActtion.Add;
				if (flag2)
				{
					this.res = this.Add();
				}
				else
				{
					this.res = this.Modify();
				}
				bool flag3 = this.res;
				if (flag3)
				{
					base.DialogResult = DialogResult.Yes;
				}
			}
		}

		// Token: 0x0600019D RID: 413 RVA: 0x000318F8 File Offset: 0x0002FAF8
		private bool Add()
		{
			return true;
		}

		// Token: 0x0600019E RID: 414 RVA: 0x0003190C File Offset: 0x0002FB0C
		private bool Modify()
		{
			ConfigSettings.Instance.ConfigConn = this.rtxtConfigConn.Text.Trim();
			ConfigSettings.Instance.Save();
			base.ShowMsg(Messages.Restart, "", "");
			return true;
		}

		// Token: 0x0600019F RID: 415 RVA: 0x0003195C File Offset: 0x0002FB5C
		private bool TextCheck()
		{
			return true;
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x0003196F File Offset: 0x0002FB6F
		private void frmDBConfig_FormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = !this.res;
			this.res = true;
		}

		// Token: 0x040002EB RID: 747
		private bool res = true;
	}
}
