using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
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
	// Token: 0x0200005B RID: 91
	public partial class frmSystemParaEdit : BaseDialogForm
	{
		// Token: 0x0600045F RID: 1119 RVA: 0x0006EAA8 File Offset: 0x0006CCA8
		public frmSystemParaEdit(string text, BaseForm.FormActtion act, int id, string dir)
		{
			this.InitializeComponent();
			this.SetText(this);
			this.Text = text;
			this._Act = act;
			this._CurrentId = id;
			this._Direct = dir;
		}

		// Token: 0x06000460 RID: 1120 RVA: 0x0006EAFC File Offset: 0x0006CCFC
		private void frmSystemParaEdit_Load(object sender, EventArgs e)
		{
			this.InitControl();
			this.LoadData();
		}

		// Token: 0x06000461 RID: 1121 RVA: 0x00003040 File Offset: 0x00001240
		private void InitControl()
		{
		}

		// Token: 0x06000462 RID: 1122 RVA: 0x0006EB10 File Offset: 0x0006CD10
		protected override void LoadData()
		{
			bool flag = BaseForm.FormActtion.Modify == this._Act;
			if (flag)
			{
				this._mod = DalCfg_setting.Instance.GetModel(this._CurrentId);
				bool flag2 = this._mod == null;
				if (flag2)
				{
					base.ShowMsg(Messages.ObjNonExist, "", "");
					base.Close();
				}
				else
				{
					this.tbxKeyCode.ReadOnly = true;
					this.tbxRemark.ReadOnly = true;
					this.tbxKeyCode.Text = this._mod.Item;
					this.tbxKeyValue.Text = this._mod.Value;
					this.tbxRemark.Text = ShowWords.ReplaceText(this._mod.Remark);
				}
			}
		}

		// Token: 0x06000463 RID: 1123 RVA: 0x0006EBDC File Offset: 0x0006CDDC
		private void btnSave_Click(object sender, EventArgs e)
		{
			bool flag = !this.TextCheck();
			if (!flag)
			{
				bool flag2 = false;
				bool flag3 = BaseForm.FormActtion.Modify == this._Act;
				if (flag3)
				{
					flag2 = this.Modify();
				}
				bool flag4 = flag2;
				if (flag4)
				{
					base.DialogResult = DialogResult.Yes;
				}
			}
		}

		// Token: 0x06000464 RID: 1124 RVA: 0x0006EC24 File Offset: 0x0006CE24
		private bool Modify()
		{
			ModCfg_setting old = this._mod.Clone() as ModCfg_setting;
			this._mod.Value = this.tbxKeyValue.Text.Trim();
			bool flag = !DalCfg_setting.Instance.Update(this._mod);
			bool result;
			if (flag)
			{
				this.OnOperateFail(this._mod, false);
				base.ShowMsg(Messages.ModifyFalse, "", "");
				result = false;
			}
			else
			{
				this.OnOperateSuccess(new
				{
					New = this._mod,
					Old = old
				}, true);
				result = true;
			}
			return result;
		}

		// Token: 0x06000465 RID: 1125 RVA: 0x0006ECC4 File Offset: 0x0006CEC4
		private bool TextCheck()
		{
			bool flag = string.IsNullOrWhiteSpace(this.tbxKeyCode.Text);
			bool result;
			if (flag)
			{
				base.ShowMsg(Messages.KeyCodeNull, "", "");
				result = false;
			}
			else
			{
				result = true;
			}
			return result;
		}

		// Token: 0x04000794 RID: 1940
		private ModCfg_setting _mod = new ModCfg_setting();
	}
}
