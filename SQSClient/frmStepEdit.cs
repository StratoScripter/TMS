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
	// Token: 0x02000055 RID: 85
	public partial class frmStepEdit : BaseDialogForm
	{
		// Token: 0x06000413 RID: 1043 RVA: 0x00067CF8 File Offset: 0x00065EF8
		public frmStepEdit(string text, BaseForm.FormActtion act, int id, string dir)
		{
			this.InitializeComponent();
			this.SetText(this);
			this._Act = act;
			this._CurrentId = id;
			this.Text = text;
			this._Direct = dir;
		}

		// Token: 0x06000414 RID: 1044 RVA: 0x00067D57 File Offset: 0x00065F57
		private void frmStepEdit_Load(object sender, EventArgs e)
		{
			this.InitControl();
			this.LoadData();
		}

		// Token: 0x06000415 RID: 1045 RVA: 0x00067D68 File Offset: 0x00065F68
		private void InitControl()
		{
			this.menuSave.Shortcuts.Add(eShortcut.CtrlEnter);
			FormHelp.SetConfigPanelUI(this.lcMain);
		}

		// Token: 0x06000416 RID: 1046 RVA: 0x00067D90 File Offset: 0x00065F90
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
					this.txtName.Text = this._mod.StepName;
					this.txtStepCode.Text = this._mod.StepCode;
					this.txtReachBasis.Text = this._mod.PassBasis;
					this.txtResetBasis.Text = this._mod.ResetBasis;
					this.chkEnable.Checked = this._mod.Enable;
					this.txtRemark.Text = this._mod.StepDesc;
				}
			}
		}

		// Token: 0x06000417 RID: 1047 RVA: 0x00067E84 File Offset: 0x00066084
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

		// Token: 0x06000418 RID: 1048 RVA: 0x00067ED4 File Offset: 0x000660D4
		private bool TextCheck()
		{
			bool flag = string.IsNullOrWhiteSpace(this.txtName.Text.Trim());
			bool result;
			if (flag)
			{
				base.ShowMsg(ShowWords.ReplaceText("SrmNameNull"), "", "");
				result = false;
			}
			else
			{
				result = true;
			}
			return result;
		}

		// Token: 0x06000419 RID: 1049 RVA: 0x00067F20 File Offset: 0x00066120
		private bool Add()
		{
			this._mod.StepName = this.txtName.Text.Trim();
			this._mod.StepCode = this.txtStepCode.Text;
			this._mod.Creater = GlobalKey.UserName;
			this._mod.CreateTime = DateTime.Now;
			this._mod.Modifier = GlobalKey.UserName;
			this._mod.ModifyTime = DateTime.Now;
			this._mod.PassBasis = this.txtReachBasis.Text.Trim();
			this._mod.ResetBasis = this.txtResetBasis.Text.Trim();
			this._mod.PinYinMa = this._mod.StepName.GetFirstPinyin();
			this._mod.Enable = this.chkEnable.Checked;
			this._mod.StepDesc = this.txtRemark.Text;
			bool flag = base.IsExist("srm_step", "StepName", this._mod.StepName, SqlDbType.NVarChar);
			bool result;
			if (flag)
			{
				base.ShowMsg(Messages.UnitHaved, "", "");
				this.txtName.Focus();
				result = false;
			}
			else
			{
				bool flag2 = base.IsExist("srm_step", "StepCode", this._mod.StepCode, SqlDbType.NVarChar);
				if (flag2)
				{
					base.ShowMsg(Messages.UnitHaved, "", "");
					this.txtStepCode.Focus();
					result = false;
				}
				else
				{
					bool flag3 = !this._Dal.AddNoReturn(this._mod);
					if (flag3)
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
			}
			return result;
		}

		// Token: 0x0600041A RID: 1050 RVA: 0x00068120 File Offset: 0x00066320
		private bool Modify()
		{
			ModSrm_step oldValue = this._mod.Clone() as ModSrm_step;
			this._mod.StepName = this.txtName.Text.Trim();
			this._mod.Modifier = GlobalKey.UserName;
			this._mod.ModifyTime = DateTime.Now;
			this._mod.PassBasis = this.txtReachBasis.Text.Trim();
			this._mod.ResetBasis = this.txtResetBasis.Text.Trim();
			this._mod.PinYinMa = this._mod.StepName.GetFirstPinyin();
			this._mod.Enable = this.chkEnable.Checked;
			this._mod.StepDesc = this.txtRemark.Text;
			bool flag = base.IsExistOutSelf("srm_step", "StepName", this._mod.StepName, SqlDbType.NVarChar, this._CurrentId);
			bool result;
			if (flag)
			{
				base.ShowMsg(Messages.UnitHaved, "", "");
				this.txtName.Focus();
				result = false;
			}
			else
			{
				bool flag2 = base.IsExistOutSelf("srm_step", "StepCode", this._mod.StepCode, SqlDbType.Int, this._CurrentId);
				if (flag2)
				{
					base.ShowMsg(Messages.UnitCodeHaved, "", "");
					this.txtStepCode.Focus();
					result = false;
				}
				else
				{
					bool flag3 = !this._Dal.Update(this._mod);
					if (flag3)
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
			}
			return result;
		}

		// Token: 0x04000713 RID: 1811
		protected DAL.SQLServer.SQSConfig.DalSrm_step _Dal = DAL.Base.SQSConfig.DalSrm_step.Instance;

		// Token: 0x04000714 RID: 1812
		protected ModSrm_step _mod = new ModSrm_step();
	}
}
