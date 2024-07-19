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
	// Token: 0x02000051 RID: 81
	public partial class frmSrmEquipsEdit : BaseDialogForm
	{
		// Token: 0x060003E5 RID: 997 RVA: 0x00062B3C File Offset: 0x00060D3C
		public frmSrmEquipsEdit(string text, BaseForm.FormActtion act, int id, string dir)
		{
			this.InitializeComponent();
			this.SetText(this);
			this._Act = act;
			this._CurrentId = id;
			this.Text = text;
			this._Direct = dir;
		}

		// Token: 0x060003E6 RID: 998 RVA: 0x00062BAC File Offset: 0x00060DAC
		private void frmSrmEquipsEdit_Load(object sender, EventArgs e)
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

		// Token: 0x060003E7 RID: 999 RVA: 0x00062C58 File Offset: 0x00060E58
		private new void LoadData()
		{
			bool flag = BaseForm.FormActtion.Modify == this._Act;
			if (flag)
			{
				this._Mod = this._dalequips.GetModel(this._CurrentId);
				ModSrm_equips mod = this._Mod;
				bool flag2 = mod == null;
				if (flag2)
				{
					base.ShowToast(this, ShowWords.ReplaceText("ObjNonExist"), "", "");
					base.Close();
				}
				else
				{
					this.tbxName.Text = mod.EquipName;
					this.nudIndex.Value = mod.EquipIndex;
					this.tbxStepCode.Text = mod.EquipCode;
					this.tbxRemark.Text = mod.EquipDesc;
					this.nudIndex.Enabled = false;
					this.cmbState.Text = EnumHelper.GetDescription<SRMState>((SRMState)mod.State);
					this.cmbVen.SelectedValue = mod.VenCode;
				}
			}
			else
			{
				bool flag3 = this._Act == BaseForm.FormActtion.Add;
				if (flag3)
				{
					ModSrm_equips modelFromMaxIndex = this._dalequips.GetModelFromMaxIndex();
					bool flag4 = modelFromMaxIndex == null;
					if (flag4)
					{
						this.nudIndex.Value = 1;
					}
					else
					{
						this.nudIndex.Value = modelFromMaxIndex.EquipIndex + 1;
					}
					this.tbxStepCode.Text = this.nudIndex.Value.ToString().PadLeft(3, '0');
					this.tbxName.Text = this.mKeyName + this.nudIndex.Value.ToString();
				}
			}
		}

		// Token: 0x060003E8 RID: 1000 RVA: 0x00062DF4 File Offset: 0x00060FF4
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

		// Token: 0x060003E9 RID: 1001 RVA: 0x00062E44 File Offset: 0x00061044
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

		// Token: 0x060003EA RID: 1002 RVA: 0x00062E9C File Offset: 0x0006109C
		private bool Add()
		{
			ModSrm_equips modSrm_equips = new ModSrm_equips();
			modSrm_equips.EquipName = this.tbxName.Text.Trim();
			modSrm_equips.EquipIndex = this.nudIndex.Value;
			modSrm_equips.EquipCode = this.nudIndex.Value.ToString().PadLeft(3, '0');
			modSrm_equips.Creater = GlobalKey.UserName;
			modSrm_equips.CreateTime = DateTime.Now;
			modSrm_equips.Modifier = GlobalKey.UserName;
			modSrm_equips.ModifyTime = DateTime.Now;
			modSrm_equips.PinYinMa = modSrm_equips.EquipName.GetFirstPinyin();
			modSrm_equips.State = Convert.ToInt32(EnumHelper.GetValue<SRMState>(this.cmbState.Text));
			modSrm_equips.VenCode = this.cmbVen.SelectedValue.ToString();
			bool flag = true;
			bool flag2 = this._dalequips.IsExist("EquipName", modSrm_equips.EquipName, SqlDbType.NVarChar, ref flag);
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
					bool flag4 = this._dalequips.GetModel("EquipIndex", modSrm_equips.EquipIndex) != null;
					if (flag4)
					{
						base.ShowToast(this, this.mKeyName + ShowWords.ReplaceText("IndexCannotRepeated"), "", "");
						result = false;
					}
					else
					{
						bool flag5 = !this._dalequips.AddNoReturn(modSrm_equips);
						if (flag5)
						{
							this.OnOperateFail(modSrm_equips, false);
							base.ShowToast(this, ShowWords.ReplaceText("AddFalse"), "", "");
							result = false;
						}
						else
						{
							this.OnOperateSuccess(modSrm_equips, true);
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

		// Token: 0x060003EB RID: 1003 RVA: 0x000630A0 File Offset: 0x000612A0
		private bool Modify()
		{
			ModSrm_equips modSrm_equips = this._Mod.Clone() as ModSrm_equips;
			string equipName = modSrm_equips.EquipName;
			bool flag = modSrm_equips == null;
			bool result;
			if (flag)
			{
				base.ShowToast(this, ShowWords.ReplaceText("ModifyFalse"), "", "");
				result = false;
			}
			else
			{
				modSrm_equips.EquipName = this.tbxName.Text.Trim();
				modSrm_equips.Modifier = GlobalKey.UserName;
				modSrm_equips.ModifyTime = DateTime.Now;
				modSrm_equips.PinYinMa = modSrm_equips.EquipName.GetFirstPinyin();
				modSrm_equips.State = Convert.ToInt32(EnumHelper.GetValue<SRMState>(this.cmbState.Text));
				modSrm_equips.VenCode = this.cmbVen.SelectedValue.ToString();
				bool flag2 = true;
				bool flag3 = this._dalequips.IsExistOutSelf("EquipName", modSrm_equips.EquipName, SqlDbType.NVarChar, this._CurrentId, ref flag2);
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
						bool flag5 = this._dalequips.GetModelOutSelf("EquipIndex", modSrm_equips.EquipIndex, SqlDbType.Int, this._CurrentId) != null;
						if (flag5)
						{
							base.ShowToast(this, this.mKeyName + ShowWords.ReplaceText("IndexCannotRepeated"), "", "");
							result = false;
						}
						else
						{
							bool flag6 = !this._dalequips.Update(modSrm_equips);
							if (flag6)
							{
								this.OnOperateFail(modSrm_equips, false);
								base.ShowToast(this, ShowWords.ReplaceText("ModifyFalse"), "", "");
								result = false;
							}
							else
							{
								this.OnOperateSuccess(modSrm_equips, this._Mod, true);
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

		// Token: 0x040006A9 RID: 1705
		protected DAL.SQLServer.SQSConfig.DalSrm_equips _dalequips = DAL.Base.SQSConfig.DalSrm_equips.Instance;

		// Token: 0x040006AA RID: 1706
		protected new ModSrm_equips _Mod = new ModSrm_equips();

		// Token: 0x040006AB RID: 1707
		public string mKeyName = ShowWords.ReplaceText("SrmEquip");
	}
}
