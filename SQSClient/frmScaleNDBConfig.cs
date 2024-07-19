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
	// Token: 0x02000014 RID: 20
	public partial class frmScaleNDBConfig : BaseDialogForm
	{
		// Token: 0x060000BD RID: 189 RVA: 0x00017652 File Offset: 0x00015852
		public frmScaleNDBConfig(string text, BaseForm.FormActtion act, int id)
		{
			this.InitializeComponent();
			this.SetText(this);
			this.Text = text;
			this._Act = act;
			this._CurrentId = id;
		}

		// Token: 0x060000BE RID: 190 RVA: 0x0001768F File Offset: 0x0001588F
		private void frmScaleNDBConfig_Load(object sender, EventArgs e)
		{
			this.InitControl();
			this.LoadData();
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00003040 File Offset: 0x00001240
		private void InitControl()
		{
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x000176A0 File Offset: 0x000158A0
		protected override void LoadData()
		{
			bool flag = BaseForm.FormActtion.Modify == this._Act;
			if (flag)
			{
				this.rtxtScaleConfigConn.Text = ConfigSettings.Instance.ScaleNGateConn;
			}
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x000176D4 File Offset: 0x000158D4
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

		// Token: 0x060000C2 RID: 194 RVA: 0x00017738 File Offset: 0x00015938
		private bool Add()
		{
			return true;
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x0001774C File Offset: 0x0001594C
		private bool Modify()
		{
			ConfigSettings.Instance.ScaleNGateConn = this.rtxtScaleConfigConn.Text.Trim();
			ConfigSettings.Instance.Save();
			base.ShowMsg(Messages.Restart, "", "");
			return true;
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x0001779C File Offset: 0x0001599C
		private bool TextCheck()
		{
			return true;
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x000177AF File Offset: 0x000159AF
		private void frmScaleNDBConfig_FormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = !this.res;
			this.res = true;
		}

		// Token: 0x04000182 RID: 386
		private bool res = true;
	}
}
