using System;
using System.Collections.Generic;
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
	// Token: 0x02000028 RID: 40
	public partial class frmSpecialClassEdit : BaseDialogForm
	{
		// Token: 0x060001ED RID: 493 RVA: 0x00039DBC File Offset: 0x00037FBC
		public frmSpecialClassEdit(string text, BaseForm.FormActtion act, int id, string dir)
		{
			this.InitializeComponent();
			this.SetText(this);
			this._Act = act;
			this._CurrentId = id;
			this.Text = text;
			this._Direct = dir;
		}

		// Token: 0x060001EE RID: 494 RVA: 0x00039E2B File Offset: 0x0003802B
		private void frmInvModelEdit_Load(object sender, EventArgs e)
		{
			this.InitControl();
			this.LoadData();
		}

		// Token: 0x060001EF RID: 495 RVA: 0x00039E3C File Offset: 0x0003803C
		private void InitControl()
		{
			this.menuSave.Shortcuts.Add(eShortcut.CtrlEnter);
			FormHelp.SetConfigPanelUI(this.lcMain);
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x00039E64 File Offset: 0x00038064
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
					this.txtName.Text = this._mod.ClassName;
					this.txtRemark.Text = this._mod.Remark;
				}
			}
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x00039EF8 File Offset: 0x000380F8
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

		// Token: 0x060001F2 RID: 498 RVA: 0x00039F48 File Offset: 0x00038148
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

		// Token: 0x060001F3 RID: 499 RVA: 0x00039FA0 File Offset: 0x000381A0
		private bool Add()
		{
			this._mod.ClassName = this.txtName.Text.Trim();
			this._mod.CreateTime = DateTime.Now;
			this._mod.ModifyTime = DateTime.Now;
			this._mod.Remark = this.txtRemark.Text;
			bool flag = base.IsExist("srm_specialstepclass", "ClassName", this._mod.ClassName, SqlDbType.NVarChar);
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

		// Token: 0x060001F4 RID: 500 RVA: 0x0003A0C0 File Offset: 0x000382C0
		private bool Modify()
		{
			ModSrm_specialstepclass modSrm_specialstepclass = this._mod.Clone() as ModSrm_specialstepclass;
			string className = modSrm_specialstepclass.ClassName;
			this._mod.ClassName = this.txtName.Text.Trim();
			this._mod.ModifyTime = DateTime.Now;
			this._mod.Remark = this.txtRemark.Text;
			bool flag = base.IsExistOutSelf("srm_specialstepclass", "ClassName", this._mod.ClassName, SqlDbType.NVarChar, this._CurrentId);
			bool result;
			if (flag)
			{
				base.ShowMsg(this.mKeyName + ShowWords.ReplaceText("NameCannotRepeated"), "", "");
				this.txtName.Focus();
				result = false;
			}
			else
			{
				bool flag2 = !this._Dal.Update(new List<string>
				{
					"ClassName"
				}, new List<object>
				{
					this._mod.ClassName
				}, new List<string>
				{
					"ClassName = '" + className + "'"
				}) && !this._Dal.Update(this._mod);
				if (flag2)
				{
					this.OnOperateFail(this._mod, false);
					base.ShowToast(this, ShowWords.ReplaceText("ModifyFalse"), "", "");
					result = false;
				}
				else
				{
					this.OnOperateSuccess(this._mod, modSrm_specialstepclass, true);
					DAL.Base.SQSConfig.DalT_truck.Instance.Update(new List<string>
					{
						"SpecialStepType"
					}, new List<object>
					{
						this._mod.ClassName
					}, new List<string>
					{
						"SpecialStepType = '" + className + "'"
					});
					result = true;
				}
			}
			return result;
		}

		// Token: 0x04000387 RID: 903
		protected DAL.SQLServer.SQSConfig.DalSrm_specialstepclass _Dal = DAL.Base.SQSConfig.DalSrm_specialstepclass.Instance;

		// Token: 0x04000388 RID: 904
		protected ModSrm_specialstepclass _mod = new ModSrm_specialstepclass();

		// Token: 0x04000389 RID: 905
		public string mKeyName = ShowWords.ReplaceText("SrmSpecialClass");
	}
}
