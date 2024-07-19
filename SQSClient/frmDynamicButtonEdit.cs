using System;
using System.ComponentModel;
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
	// Token: 0x0200002B RID: 43
	public partial class frmDynamicButtonEdit : BaseDialogForm
	{
		// Token: 0x06000216 RID: 534 RVA: 0x0003D93C File Offset: 0x0003BB3C
		public frmDynamicButtonEdit(string text, BaseForm.FormActtion act, int id, string dir)
		{
			this.InitializeComponent();
			this.SetText(this);
			this.Text = text;
			this._Act = act;
			this._CurrentId = id;
			this._Direct = dir;
		}

		// Token: 0x06000217 RID: 535 RVA: 0x0003D99B File Offset: 0x0003BB9B
		private void frmDynamicButtonEdit_Load(object sender, EventArgs e)
		{
			this.InitControl();
			this.LoadData();
		}

		// Token: 0x06000218 RID: 536 RVA: 0x0003D9AC File Offset: 0x0003BBAC
		private void InitControl()
		{
			this.btnSave.Shortcuts.Add(eShortcut.CtrlEnter);
		}

		// Token: 0x06000219 RID: 537 RVA: 0x0003D9C8 File Offset: 0x0003BBC8
		protected override void LoadData()
		{
			bool flag = BaseForm.FormActtion.Modify == this._Act;
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
					this.txtButtonText.Text = this._mod.ButtonText;
					this.txtButtonName.Text = this._mod.ButtonName;
					this.txtScreenName.Text = this._mod.ScreenName;
					this.txtParentControl.Text = this._mod.ParentControl;
				}
			}
			else
			{
				bool flag3 = this._Act == BaseForm.FormActtion.Add;
				if (flag3)
				{
				}
			}
		}

		// Token: 0x0600021A RID: 538 RVA: 0x0003DA9C File Offset: 0x0003BC9C
		private void btnSave_Click(object sender, EventArgs e)
		{
			bool flag = !this.TextCheck();
			if (!flag)
			{
				bool flag2 = this._Act == BaseForm.FormActtion.Add;
				bool flag3;
				if (flag2)
				{
					flag3 = this.Add();
				}
				else
				{
					flag3 = this.Modify();
				}
				bool flag4 = flag3;
				if (flag4)
				{
					base.DialogResult = DialogResult.Yes;
				}
			}
		}

		// Token: 0x0600021B RID: 539 RVA: 0x0003DAEC File Offset: 0x0003BCEC
		private bool Add()
		{
			this._mod.ButtonText = this.txtButtonText.Text.Trim();
			this._mod.ButtonName = this.txtButtonName.Text.Trim();
			this._mod.ParentControl = this.txtParentControl.Text;
			this._mod.ScreenName = this.txtScreenName.Text;
			int num = this._Dal.Add(this._mod);
			bool flag = num <= 0;
			bool result;
			if (flag)
			{
				this.OnOperateFail(this._mod, false);
				base.ShowMsg(Messages.AddFalse, "", "");
				result = false;
			}
			else
			{
				this.OnOperateSuccess(this._mod, true);
				result = true;
			}
			return result;
		}

		// Token: 0x0600021C RID: 540 RVA: 0x0003DBC4 File Offset: 0x0003BDC4
		private bool Modify()
		{
			ModSys_dynamicbutton oldValue = this._mod.Clone() as ModSys_dynamicbutton;
			this._mod.ButtonText = this.txtButtonText.Text.Trim();
			this._mod.ButtonName = this.txtButtonName.Text.Trim();
			this._mod.ScreenName = this.txtScreenName.Text;
			this._mod.ParentControl = this.txtParentControl.Text;
			bool flag = !this._Dal.Update(this._mod);
			bool result;
			if (flag)
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
			return result;
		}

		// Token: 0x0600021D RID: 541 RVA: 0x0003DCAC File Offset: 0x0003BEAC
		private bool TextCheck()
		{
			bool flag = string.IsNullOrWhiteSpace(this.txtButtonText.Text);
			bool result;
			if (flag)
			{
				base.ShowMsg(Messages.ParaNull, "", "");
				result = false;
			}
			else
			{
				bool flag2 = string.IsNullOrWhiteSpace(this.txtButtonName.Text);
				if (flag2)
				{
					base.ShowMsg(Messages.ParaNull, "", "");
					result = false;
				}
				else
				{
					bool flag3 = string.IsNullOrWhiteSpace(this.txtScreenName.Text);
					if (flag3)
					{
						base.ShowMsg(Messages.ParaNull, "", "");
						result = false;
					}
					else
					{
						bool flag4 = string.IsNullOrWhiteSpace(this.txtParentControl.Text);
						if (flag4)
						{
							base.ShowMsg(Messages.ParaNull, "", "");
							result = false;
						}
						else
						{
							result = true;
						}
					}
				}
			}
			return result;
		}

		// Token: 0x040003CD RID: 973
		private ModSys_dynamicbutton _mod = new ModSys_dynamicbutton();

		// Token: 0x040003CE RID: 974
		protected DAL.SQLServer.SQSConfig.DalSys_dynamicbutton _Dal = DAL.Base.SQSConfig.DalSys_dynamicbutton.Instance;
	}
}
