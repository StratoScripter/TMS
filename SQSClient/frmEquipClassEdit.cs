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
	// Token: 0x0200004C RID: 76
	public partial class frmEquipClassEdit : BaseDialogForm
	{
		// Token: 0x060003AD RID: 941 RVA: 0x0005CEB8 File Offset: 0x0005B0B8
		public frmEquipClassEdit(string text, BaseForm.FormActtion act, int id, string dir)
		{
			this.InitializeComponent();
			this.SetText(this);
			this._Act = act;
			this.mCurrentId = id;
			this.Text = text;
			this._Direct = dir;
		}

		// Token: 0x060003AE RID: 942 RVA: 0x0005CF30 File Offset: 0x0005B130
		private void frmEquipClassEdit_Load(object sender, EventArgs e)
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
			this.LoadData();
		}

		// Token: 0x060003AF RID: 943 RVA: 0x0005CFDC File Offset: 0x0005B1DC
		private new void LoadData()
		{
			bool flag = BaseForm.FormActtion.Modify == this._Act;
			if (flag)
			{
				this._Mod = this._dalequipclass.GetModel(this.mCurrentId);
				ModSrm_equipclass mod = this._Mod;
				bool flag2 = this._Mod == null;
				if (flag2)
				{
					base.ShowToast(this, ShowWords.ReplaceText("ObjNonExist"), "", "");
					base.Close();
				}
				else
				{
					this.tbxName.Text = mod.ClassDevName;
					this.nudIndex.Value = mod.ClassDevIndex;
					this.tbxStepCode.Text = mod.ClassDevCode;
					this.tbxRemark.Text = mod.ClassDevDesc;
					this.nudIndex.Enabled = false;
					this.cmbState.Text = EnumHelper.GetDescription<SRMState>((SRMState)mod.State);
					this.cmbPurpose.SelectedValue = mod.Purpose;
				}
			}
			else
			{
				bool flag3 = this._Act == BaseForm.FormActtion.Add;
				if (flag3)
				{
					ModSrm_equipclass modelFromMaxIndex = this._dalequipclass.GetModelFromMaxIndex();
					bool flag4 = modelFromMaxIndex == null;
					if (flag4)
					{
						this.nudIndex.Value = 1;
					}
					else
					{
						this.nudIndex.Value = modelFromMaxIndex.ClassDevIndex + 1;
					}
					this.tbxStepCode.Text = this.nudIndex.Value.ToString().PadLeft(3, '0');
					this.tbxName.Text = this.mKeyName + this.nudIndex.Value.ToString();
				}
			}
		}

		// Token: 0x060003B0 RID: 944 RVA: 0x0005D17C File Offset: 0x0005B37C
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

		// Token: 0x060003B1 RID: 945 RVA: 0x0005D1CC File Offset: 0x0005B3CC
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
				result = true;
			}
			return result;
		}

		// Token: 0x060003B2 RID: 946 RVA: 0x0005D224 File Offset: 0x0005B424
		private bool Add()
		{
			ModSrm_equipclass modSrm_equipclass = new ModSrm_equipclass();
			modSrm_equipclass.ClassDevName = this.tbxName.Text.Trim();
			modSrm_equipclass.ClassDevIndex = this.nudIndex.Value;
			modSrm_equipclass.ClassDevCode = this.nudIndex.Value.ToString().PadLeft(3, '0');
			modSrm_equipclass.Creater = GlobalKey.UserName;
			modSrm_equipclass.CreateTime = DateTime.Now;
			modSrm_equipclass.Modifier = GlobalKey.UserName;
			modSrm_equipclass.ModifyTime = DateTime.Now;
			modSrm_equipclass.PinYinMa = modSrm_equipclass.ClassDevName.GetFirstPinyin();
			modSrm_equipclass.State = Convert.ToInt32(EnumHelper.GetValue<SRMState>(this.cmbState.Text));
			modSrm_equipclass.Purpose = this.cmbPurpose.SelectedValue.ToString();
			bool flag = true;
			bool flag2 = this._dalequipclass.IsExist("ClassDevName", modSrm_equipclass.ClassDevName, SqlDbType.NVarChar, ref flag);
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
					bool flag4 = this._dalequipclass.GetModel("ClassDevIndex", modSrm_equipclass.ClassDevIndex) != null;
					if (flag4)
					{
						base.ShowToast(this, this.mKeyName + ShowWords.ReplaceText("IndexCannotRepeated"), "", "");
						result = false;
					}
					else
					{
						bool flag5 = !this._dalequipclass.AddNoReturn(modSrm_equipclass);
						if (flag5)
						{
							this.OnOperateFail(modSrm_equipclass, false);
							base.ShowToast(this, ShowWords.ReplaceText("AddFalse"), "", "");
							result = false;
						}
						else
						{
							this.OnOperateSuccess(modSrm_equipclass, true);
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

		// Token: 0x060003B3 RID: 947 RVA: 0x0005D428 File Offset: 0x0005B628
		private bool Modify()
		{
			ModSrm_equipclass modSrm_equipclass = this._Mod.Clone() as ModSrm_equipclass;
			string classDevName = modSrm_equipclass.ClassDevName;
			bool flag = modSrm_equipclass == null;
			bool result;
			if (flag)
			{
				base.ShowToast(this, ShowWords.ReplaceText("ModifyFalse"), "", "");
				result = false;
			}
			else
			{
				modSrm_equipclass.ClassDevName = this.tbxName.Text.Trim();
				modSrm_equipclass.Modifier = GlobalKey.UserName;
				modSrm_equipclass.ModifyTime = DateTime.Now;
				modSrm_equipclass.PinYinMa = modSrm_equipclass.ClassDevName.GetFirstPinyin();
				modSrm_equipclass.State = Convert.ToInt32(EnumHelper.GetValue<SRMState>(this.cmbState.Text));
				modSrm_equipclass.Purpose = this.cmbPurpose.SelectedValue.ToString();
				bool flag2 = true;
				bool flag3 = this._dalequipclass.IsExistOutSelf("ClassDevName", modSrm_equipclass.ClassDevName, SqlDbType.NVarChar, this.mCurrentId, ref flag2);
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
						bool flag5 = this._dalequipclass.GetModelOutSelf("ClassDevIndex", modSrm_equipclass.ClassDevIndex, SqlDbType.Int, this.mCurrentId) != null;
						if (flag5)
						{
							base.ShowToast(this, this.mKeyName + ShowWords.ReplaceText("IndexCannotRepeated"), "", "");
							result = false;
						}
						else
						{
							bool flag6 = !this._dalequipclass.Update(modSrm_equipclass);
							if (flag6)
							{
								this.OnOperateFail(modSrm_equipclass, false);
								base.ShowToast(this, ShowWords.ReplaceText("ModifyFalse"), "", "");
								result = false;
							}
							else
							{
								this.OnOperateSuccess(modSrm_equipclass, this._Mod, true);
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

		// Token: 0x04000628 RID: 1576
		protected int mCurrentId = 0;

		// Token: 0x04000629 RID: 1577
		protected DAL.SQLServer.SQSConfig.DalSrm_equipclass _dalequipclass = DAL.Base.SQSConfig.DalSrm_equipclass.Instance;

		// Token: 0x0400062A RID: 1578
		protected new ModSrm_equipclass _Mod = new ModSrm_equipclass();

		// Token: 0x0400062B RID: 1579
		public string mKeyName = ShowWords.ReplaceText("SrmEquipClass");
	}
}
