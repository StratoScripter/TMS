using System;
using System.Collections.Generic;
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
	// Token: 0x0200004F RID: 79
	public partial class frmInvStepEdit : BaseDialogForm
	{
		// Token: 0x060003CC RID: 972 RVA: 0x0006034C File Offset: 0x0005E54C
		public frmInvStepEdit(string text, BaseForm.FormActtion act, int id, string dir)
		{
			this.InitializeComponent();
			this.SetText(this);
			this._Act = act;
			this._CurrentId = id;
			this.Text = text;
			this._Direct = dir;
		}

		// Token: 0x060003CD RID: 973 RVA: 0x000603C2 File Offset: 0x0005E5C2
		private void frmInvStepEdit_Load(object sender, EventArgs e)
		{
			this.InitControl();
			this.LoadData();
		}

		// Token: 0x060003CE RID: 974 RVA: 0x000603D4 File Offset: 0x0005E5D4
		private void InitControl()
		{
			this.menuSave.Shortcuts.Add(eShortcut.CtrlEnter);
			FormHelp.SetConfigPanelUI(this.lcMain);
			List<ModSrm_step> allList = DAL.Base.SQSConfig.DalSrm_step.Instance.GetAllList();
			this.cmbStep.BindDataSouce(allList, "StepName", "PinYinMa", "StepCode");
			this.cmbLastStep.BindDataSouce(allList, "StepName", "PinYinMa", "StepCode");
			List<ModSrm_invmodel> allList2 = DAL.Base.SQSConfig.DalSrm_invmodel.Instance.GetAllList();
			this.cmbInvModel.BindDataSouce(allList2, "ModelName", "PinYinMa", "Id");
		}

		// Token: 0x060003CF RID: 975 RVA: 0x00060470 File Offset: 0x0005E670
		protected override void LoadData()
		{
			bool flag = BaseForm.FormActtion.Modify == this._Act;
			if (flag)
			{
				this._mod = this._Dal.GetModel(this._CurrentId);
				bool flag2 = this._mod == null;
				if (flag2)
				{
					base.ShowToast(this, ShowWords.ReplaceText("ObjNonExist"), "", "");
					base.Close();
				}
				else
				{
					this.cmbInvModel.SelectedValue = this._mod.InvModelId;
					this.cmbStep.SelectedValue = this._mod.StepCode;
					this.cmbLastStep.SelectedValue = this._mod.LastStep;
					this.txtAllowCondition.Text = this._mod.AllowCondition;
					this.chkEnable.Checked = this._mod.Enable;
					this.txtRemark.Text = this._mod.InvStepDesc;
				}
			}
		}

		// Token: 0x060003D0 RID: 976 RVA: 0x00060570 File Offset: 0x0005E770
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

		// Token: 0x060003D1 RID: 977 RVA: 0x000605C0 File Offset: 0x0005E7C0
		private bool TextCheck()
		{
			bool flag = string.IsNullOrWhiteSpace(this.cmbInvModel.Text);
			bool result;
			if (flag)
			{
				base.ShowMsg(Messages.GroupNull, "", "");
				this.cmbInvModel.Focus();
				result = false;
			}
			else
			{
				bool flag2 = string.IsNullOrWhiteSpace(this.cmbStep.Text);
				if (flag2)
				{
					this.cmbStep.Focus();
					result = false;
				}
				else
				{
					result = true;
				}
			}
			return result;
		}

		// Token: 0x060003D2 RID: 978 RVA: 0x00060634 File Offset: 0x0005E834
		private bool Add()
		{
			this._mod.InvModelId = Convert.ToInt32(this.cmbInvModel.SelectedValue);
			this._mod.StepCode = this.cmbStep.SelectedValue.ToString();
			ModSrm_invstep mod = this._mod;
			object selectedValue = this.cmbLastStep.SelectedValue;
			mod.LastStep = ((selectedValue != null) ? selectedValue.ToString() : null);
			this._mod.AllowCondition = this.txtAllowCondition.Text;
			this._mod.Creater = GlobalKey.UserName;
			this._mod.CreateTime = DateTime.Now;
			this._mod.Modifier = GlobalKey.UserName;
			this._mod.ModifyTime = DateTime.Now;
			this._mod.Enable = this.chkEnable.Checked;
			this._mod.InvStepDesc = this.txtRemark.Text;
			bool flag = !this._Dal.AddNoReturn(this._mod);
			bool result;
			if (flag)
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
			return result;
		}

		// Token: 0x060003D3 RID: 979 RVA: 0x0006078C File Offset: 0x0005E98C
		private bool Modify()
		{
			ModSrm_invstep oldValue = this._mod.Clone() as ModSrm_invstep;
			this._mod.InvModelId = Convert.ToInt32(this.cmbInvModel.SelectedValue);
			this._mod.StepCode = this.cmbStep.SelectedValue.ToString();
			ModSrm_invstep mod = this._mod;
			object selectedValue = this.cmbLastStep.SelectedValue;
			mod.LastStep = ((selectedValue != null) ? selectedValue.ToString() : null);
			this._mod.AllowCondition = this.txtAllowCondition.Text;
			this._mod.Modifier = GlobalKey.UserName;
			this._mod.ModifyTime = DateTime.Now;
			this._mod.Enable = this.chkEnable.Checked;
			this._mod.InvStepDesc = this.txtRemark.Text;
			bool flag = !this._Dal.Update(this._mod);
			bool result;
			if (flag)
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
			return result;
		}

		// Token: 0x060003D4 RID: 980 RVA: 0x000608D4 File Offset: 0x0005EAD4
		private void btnAllowConditionSet_Click(object sender, EventArgs e)
		{
			string text = this.txtAllowCondition.Text.Trim();
			frmAllowCondition frmAllowCondition = new frmAllowCondition(text);
			frmAllowCondition.ShowDialog();
			this.txtAllowCondition.Text = frmAllowCondition.condition;
		}

		// Token: 0x04000670 RID: 1648
		protected DAL.SQLServer.SQSConfig.DalSrm_invstep _Dal = DAL.Base.SQSConfig.DalSrm_invstep.Instance;

		// Token: 0x04000671 RID: 1649
		protected ModSrm_invstep _mod = new ModSrm_invstep();

		// Token: 0x04000672 RID: 1650
		protected int mInvModelIndex = 0;

		// Token: 0x04000673 RID: 1651
		public string mKeyName = ShowWords.ReplaceText("SrmInvStep");
	}
}
