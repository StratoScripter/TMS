using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Assistant;
using Base;
using DAL.Base.SQSConfig;
using DAL.SQLServer.SQSConfig;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using DevComponents.DotNetBar.Layout;
using DevComponents.Editors;
using Model;
using Model.SQSConfig;
using SQSClient.Properties;

namespace SQSClient
{
	// Token: 0x02000057 RID: 87
	public partial class frmStepUnitEdit : BaseDialogForm
	{
		// Token: 0x0600042B RID: 1067 RVA: 0x0006A25C File Offset: 0x0006845C
		public frmStepUnitEdit(string text, BaseForm.FormActtion act, int id, string dir)
		{
			this.InitializeComponent();
			this.SetText(this);
			this._Act = act;
			this._CurrentId = id;
			this.Text = text;
			this._Direct = dir;
		}

		// Token: 0x0600042C RID: 1068 RVA: 0x0006A2CC File Offset: 0x000684CC
		private void frmStepUnitEdit_Load(object sender, EventArgs e)
		{
			this.menuSave.Shortcuts.Add(eShortcut.CtrlEnter);
			FormHelp.SetConfigPanelUI(this.lcMain);
			this.tbxName.Text = this.mKeyName;
			BaseForm.EnumModel enumModel = new BaseForm.EnumModel();
			enumModel.Name = "All";
			enumModel.Description = ShowWords.ReplaceText("All");
			enumModel.Value = -1;
			List<BaseForm.EnumModel> list = new List<BaseForm.EnumModel>();
			list.Add(enumModel);
			list.AddRange(BaseForm.GetEnumModelList<SRMState>());
			BaseForm.BindDataSouce(this.cmbState, list, "Description", "Value");
			List<ModSrm_equips> allList = DAL.Base.SQSConfig.DalSrm_equips.Instance.GetAllList();
			FormHelp.cmbDataBind(this.cmbEquips, this, allList, "EquipName", "PinYinMa", "EquipIndex");
			List<ModSrm_step> allList2 = DAL.Base.SQSConfig.DalSrm_step.Instance.GetAllList();
			FormHelp.cmbDataBind(this.cmbStep, this, allList2, "StepName", "PinYinMa", "StepIndex");
			this.LoadData();
		}

		// Token: 0x0600042D RID: 1069 RVA: 0x0006A3C8 File Offset: 0x000685C8
		private new void LoadData()
		{
			bool flag = BaseForm.FormActtion.Modify == this._Act;
			if (flag)
			{
				ModSrm_stepunit model = this._dalstepunit.GetModel(this._CurrentId);
				bool flag2 = model == null;
				if (flag2)
				{
					base.ShowToast(this, ShowWords.ReplaceText("ObjNonExist"), "", "");
					base.Close();
				}
				else
				{
					this.tbxName.Text = model.SUnitName;
					this.nudIndex.Value = model.SUnitIndex;
					this.tbxStepCode.Text = model.SUnitCode;
					this.tbxRemark.Text = model.SUnitDesc;
					this.nudIndex.Enabled = false;
					this.cmbState.Text = EnumHelper.GetDescription<SRMState>((SRMState)model.State);
					this.cmbEquips.SelectedValue = model.EquipIndex.ToString();
					this.cmbState.SelectedValue = model.StepIndex.ToString();
				}
			}
			else
			{
				bool flag3 = this._Act == BaseForm.FormActtion.Add;
				if (flag3)
				{
					ModSrm_stepunit modelFromMaxIndex = this._dalstepunit.GetModelFromMaxIndex();
					bool flag4 = modelFromMaxIndex == null;
					if (flag4)
					{
						this.nudIndex.Value = 1;
					}
					else
					{
						this.nudIndex.Value = modelFromMaxIndex.SUnitIndex + 1;
					}
					this.tbxStepCode.Text = this.nudIndex.Value.ToString().PadLeft(3, '0');
					this.tbxName.Text = this.mKeyName + this.nudIndex.Value.ToString();
				}
			}
		}

		// Token: 0x0600042E RID: 1070 RVA: 0x0006A578 File Offset: 0x00068778
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

		// Token: 0x0600042F RID: 1071 RVA: 0x0006A5C8 File Offset: 0x000687C8
		private bool TextCheck()
		{
			bool flag = string.IsNullOrWhiteSpace(this.tbxName.Text.Trim());
			bool result;
			if (flag)
			{
				base.ShowToast(this, this.mKeyName + ShowWords.ReplaceText("SrmNameNull"), "", "");
				result = false;
			}
			else
			{
				bool flag2 = string.IsNullOrWhiteSpace(this.cmbEquips.Text.Trim());
				if (flag2)
				{
					base.ShowToast(this, ShowWords.ReplaceText("SrmSelectEquips"), "", "");
					result = false;
				}
				else
				{
					bool flag3 = string.IsNullOrWhiteSpace(this.cmbStep.Text.Trim());
					if (flag3)
					{
						base.ShowToast(this, ShowWords.ReplaceText("SrmSelectStep"), "", "");
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

		// Token: 0x06000430 RID: 1072 RVA: 0x0006A694 File Offset: 0x00068894
		private bool Add()
		{
			ModSrm_stepunit modSrm_stepunit = new ModSrm_stepunit();
			modSrm_stepunit.SUnitName = this.tbxName.Text.Trim();
			modSrm_stepunit.SUnitIndex = this.nudIndex.Value;
			modSrm_stepunit.SUnitCode = this.nudIndex.Value.ToString().PadLeft(3, '0');
			modSrm_stepunit.Creater = GlobalKey.UserName;
			modSrm_stepunit.CreateTime = DateTime.Now;
			modSrm_stepunit.Modifier = GlobalKey.UserName;
			modSrm_stepunit.ModifyTime = DateTime.Now;
			modSrm_stepunit.PinYinMa = modSrm_stepunit.SUnitName.GetFirstPinyin();
			modSrm_stepunit.State = Convert.ToInt32(EnumHelper.GetValue<SRMState>(this.cmbState.Text));
			modSrm_stepunit.EquipIndex = Convert.ToInt32(this.cmbEquips.SelectedValue);
			modSrm_stepunit.StepIndex = Convert.ToInt32(this.cmbState.SelectedValue);
			bool flag = true;
			bool flag2 = this._dalstepunit.IsExist("SUnitName", modSrm_stepunit.SUnitName, SqlDbType.NVarChar, ref flag);
			bool result;
			if (flag2)
			{
				bool flag3 = flag;
				if (flag3)
				{
					base.ShowToast(this, this.mKeyName + ShowWords.ReplaceText("NameCannotRepeated"), "", "");
					result = false;
				}
				else
				{
					bool flag4 = this._dalstepunit.GetModel("SUnitIndex", modSrm_stepunit.SUnitIndex) != null;
					if (flag4)
					{
						base.ShowToast(this, this.mKeyName + ShowWords.ReplaceText("IndexCannotRepeated"), "", "");
						result = false;
					}
					else
					{
						bool flag5 = !this._dalstepunit.AddNoReturn(modSrm_stepunit);
						if (flag5)
						{
							this.OnOperateFail(modSrm_stepunit, false);
							base.ShowToast(this, ShowWords.ReplaceText("AddFalse"), "", "");
							result = false;
						}
						else
						{
							this.OnOperateSuccess(modSrm_stepunit, true);
							result = true;
						}
					}
				}
			}
			else
			{
				base.ShowToast(this, ShowWords.ReplaceText("AddFalse"), "", "");
				result = false;
			}
			return result;
		}

		// Token: 0x06000431 RID: 1073 RVA: 0x0006A8B0 File Offset: 0x00068AB0
		private bool Modify()
		{
			ModSrm_stepunit modSrm_stepunit = this._Mod.Clone() as ModSrm_stepunit;
			string sunitName = modSrm_stepunit.SUnitName;
			bool flag = modSrm_stepunit == null;
			bool result;
			if (flag)
			{
				base.ShowToast(this, ShowWords.ReplaceText("ModifyFalse"), "", "");
				result = false;
			}
			else
			{
				modSrm_stepunit.SUnitName = this.tbxName.Text.Trim();
				modSrm_stepunit.Modifier = GlobalKey.UserName;
				modSrm_stepunit.ModifyTime = DateTime.Now;
				modSrm_stepunit.PinYinMa = modSrm_stepunit.SUnitName.GetFirstPinyin();
				modSrm_stepunit.State = Convert.ToInt32(EnumHelper.GetValue<SRMState>(this.cmbState.Text));
				modSrm_stepunit.EquipIndex = Convert.ToInt32(this.cmbEquips.SelectedValue);
				modSrm_stepunit.StepIndex = Convert.ToInt32(this.cmbState.SelectedValue);
				bool flag2 = true;
				bool flag3 = this._dalstepunit.IsExistOutSelf("SUnitName", modSrm_stepunit.SUnitName, SqlDbType.NVarChar, this._CurrentId, ref flag2);
				if (flag3)
				{
					bool flag4 = flag2;
					if (flag4)
					{
						base.ShowToast(this, this.mKeyName + ShowWords.ReplaceText("NameCannotRepeated"), "", "");
						result = false;
					}
					else
					{
						bool flag5 = this._dalstepunit.GetModelOutSelf("SUnitIndex", modSrm_stepunit.SUnitIndex, SqlDbType.Int, this._CurrentId) != null;
						if (flag5)
						{
							base.ShowToast(this, this.mKeyName + ShowWords.ReplaceText("IndexCannotRepeated"), "", "");
							result = false;
						}
						else
						{
							bool flag6 = !this._dalstepunit.Update(modSrm_stepunit);
							if (flag6)
							{
								this.OnOperateFail(modSrm_stepunit, false);
								base.ShowToast(this, ShowWords.ReplaceText("ModifyFalse"), "", "");
								result = false;
							}
							else
							{
								this.OnOperateSuccess(modSrm_stepunit, this._Mod, true);
								result = true;
							}
						}
					}
				}
				else
				{
					base.ShowToast(this, ShowWords.ReplaceText("ModifyFalse"), "", "");
					result = false;
				}
			}
			return result;
		}

		// Token: 0x04000746 RID: 1862
		protected DAL.SQLServer.SQSConfig.DalSrm_stepunit _dalstepunit = DAL.Base.SQSConfig.DalSrm_stepunit.Instance;

		// Token: 0x04000747 RID: 1863
		protected new ModSrm_stepunit _Mod = new ModSrm_stepunit();

		// Token: 0x04000748 RID: 1864
		public string mKeyName = ShowWords.ReplaceText("SrmUnitStep");
	}
}
