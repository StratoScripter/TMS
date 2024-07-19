using System;
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
	// Token: 0x0200004D RID: 77
	public partial class frmInvModelEdit : BaseDialogForm
	{
		// Token: 0x060003B6 RID: 950 RVA: 0x0005E6A0 File Offset: 0x0005C8A0
		public frmInvModelEdit(string text, BaseForm.FormActtion act, int id, string dir)
		{
			this.InitializeComponent();
			this.SetText(this);
			this._Act = act;
			this._CurrentId = id;
			this.Text = text;
			this._Direct = dir;
		}

		// Token: 0x060003B7 RID: 951 RVA: 0x0005E70F File Offset: 0x0005C90F
		private void frmInvModelEdit_Load(object sender, EventArgs e)
		{
			this.InitControl();
			this.LoadData();
		}

		// Token: 0x060003B8 RID: 952 RVA: 0x0005E720 File Offset: 0x0005C920
		private void InitControl()
		{
			this.menuSave.Shortcuts.Add(eShortcut.CtrlEnter);
			FormHelp.SetConfigPanelUI(this.lcMain);
		}

		// Token: 0x060003B9 RID: 953 RVA: 0x0005E748 File Offset: 0x0005C948
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
					this.txtName.Text = this._mod.ModelName;
					this.chkEnable.Checked = this._mod.Enable;
					this.txtRemark.Text = this._mod.ModelDesc;
				}
			}
		}

		// Token: 0x060003BA RID: 954 RVA: 0x0005E7F4 File Offset: 0x0005C9F4
		private void menuSave_Click(object sender, EventArgs e)
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

		// Token: 0x060003BB RID: 955 RVA: 0x0005E844 File Offset: 0x0005CA44
		private bool TextCheck()
		{
			bool flag = string.IsNullOrWhiteSpace(this.txtName.Text.Trim());
			bool result;
			if (flag)
			{
				base.ShowToast(this, this.mKeyName + ShowWords.ReplaceText("SrmNameNull"), "", "");
				result = false;
			}
			else
			{
				result = true;
			}
			return result;
		}

		// Token: 0x060003BC RID: 956 RVA: 0x0005E89C File Offset: 0x0005CA9C
		private bool Add()
		{
			this._mod.ModelName = this.txtName.Text.Trim();
			this._mod.Creater = GlobalKey.UserName;
			this._mod.CreateTime = DateTime.Now;
			this._mod.Modifier = GlobalKey.UserName;
			this._mod.ModifyTime = DateTime.Now;
			this._mod.PinYinMa = this._mod.ModelName.GetFirstPinyin();
			this._mod.Enable = this.chkEnable.Checked;
			this._mod.ModelDesc = this.txtRemark.Text;
			bool flag = base.IsExist("srm_invmodel", "ModelName", this._mod.ModelName, SqlDbType.NVarChar);
			bool result;
			if (flag)
			{
				base.ShowMsg(this.mKeyName + ShowWords.ReplaceText("NameCannotRepeated"), "", "");
				this.txtName.Focus();
				result = false;
			}
			else
			{
				bool flag2 = !this._Dal.AddNoReturn(this._mod);
				if (flag2)
				{
					this.OnOperateFail(this._mod, false);
					base.ShowToast(this, ShowWords.ReplaceText("AddFalse"), "", "");
					result = false;
				}
				else
				{
					this.OnOperateSuccess(this._mod, true);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x060003BD RID: 957 RVA: 0x0005EA10 File Offset: 0x0005CC10
		private bool Modify()
		{
			ModSrm_invmodel oldValue = this._mod.Clone() as ModSrm_invmodel;
			this._mod.ModelName = this.txtName.Text.Trim();
			this._mod.Modifier = GlobalKey.UserName;
			this._mod.ModifyTime = DateTime.Now;
			this._mod.PinYinMa = this._mod.ModelName.GetFirstPinyin();
			this._mod.Enable = this.chkEnable.Checked;
			this._mod.ModelDesc = this.txtRemark.Text;
			bool flag = base.IsExistOutSelf("srm_invmodel", "ModelName", this._mod.ModelName, SqlDbType.NVarChar, this._CurrentId);
			bool result;
			if (flag)
			{
				base.ShowMsg(this.mKeyName + ShowWords.ReplaceText("NameCannotRepeated"), "", "");
				this.txtName.Focus();
				result = false;
			}
			else
			{
				bool flag2 = !this._Dal.Update(this._mod);
				if (flag2)
				{
					this.OnOperateFail(this._mod, false);
					base.ShowToast(this, ShowWords.ReplaceText("ModifyFalse"), "", "");
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

		// Token: 0x04000646 RID: 1606
		protected DAL.SQLServer.SQSConfig.DalSrm_invmodel _Dal = DAL.Base.SQSConfig.DalSrm_invmodel.Instance;

		// Token: 0x04000647 RID: 1607
		protected ModSrm_invmodel _mod = new ModSrm_invmodel();

		// Token: 0x04000648 RID: 1608
		public string mKeyName = ShowWords.ReplaceText("SrmInvModel");
	}
}
