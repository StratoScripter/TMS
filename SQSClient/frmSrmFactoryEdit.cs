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
	// Token: 0x02000053 RID: 83
	public partial class frmSrmFactoryEdit : BaseDialogForm
	{
		// Token: 0x060003FC RID: 1020 RVA: 0x00065324 File Offset: 0x00063524
		public frmSrmFactoryEdit(string text, BaseForm.FormActtion act, int id, string dir)
		{
			this.InitializeComponent();
			this.SetText(this);
			this._Act = act;
			this._CurrentId = id;
			this.Text = text;
			this._Direct = dir;
		}

		// Token: 0x060003FD RID: 1021 RVA: 0x00065394 File Offset: 0x00063594
		private void frmSrmFactoryEdit_Load(object sender, EventArgs e)
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

		// Token: 0x060003FE RID: 1022 RVA: 0x00065440 File Offset: 0x00063640
		private new void LoadData()
		{
			bool flag = BaseForm.FormActtion.Modify == this._Act;
			if (flag)
			{
				this._Mod = this._dalfactory.GetModel(this._CurrentId);
				ModSrm_factory mod = this._Mod;
				bool flag2 = mod == null;
				if (flag2)
				{
					base.ShowToast(this, ShowWords.ReplaceText("ObjNonExist"), "", "");
					base.Close();
				}
				else
				{
					this.tbxName.Text = mod.FactoryName;
					this.nudIndex.Value = mod.FactoryIndex;
					this.tbxStepCode.Text = mod.FactoryCode;
					this.tbxRemark.Text = mod.FactoryDesc;
					this.nudIndex.Enabled = false;
					this.cmbState.Text = EnumHelper.GetDescription<SRMState>((SRMState)mod.State);
					this.tbxAreaName.Text = mod.AreaName;
					this.tbxAppSrvCode.Text = mod.AppSrvCode;
					this.tbxRealName.Text = mod.RealName;
				}
			}
			else
			{
				bool flag3 = this._Act == BaseForm.FormActtion.Add;
				if (flag3)
				{
					ModSrm_factory modelFromMaxIndex = this._dalfactory.GetModelFromMaxIndex();
					bool flag4 = modelFromMaxIndex == null;
					if (flag4)
					{
						this.nudIndex.Value = 1;
					}
					else
					{
						this.nudIndex.Value = modelFromMaxIndex.FactoryIndex + 1;
					}
					this.tbxStepCode.Text = this.nudIndex.Value.ToString().PadLeft(3, '0');
					this.tbxName.Text = this.mKeyName + this.nudIndex.Value.ToString();
				}
			}
		}

		// Token: 0x060003FF RID: 1023 RVA: 0x00065600 File Offset: 0x00063800
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

		// Token: 0x06000400 RID: 1024 RVA: 0x00065650 File Offset: 0x00063850
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

		// Token: 0x06000401 RID: 1025 RVA: 0x000656A8 File Offset: 0x000638A8
		private bool Add()
		{
			ModSrm_factory modSrm_factory = new ModSrm_factory();
			modSrm_factory.FactoryName = this.tbxName.Text.Trim();
			modSrm_factory.FactoryIndex = this.nudIndex.Value;
			modSrm_factory.FactoryCode = this.nudIndex.Value.ToString().PadLeft(3, '0');
			modSrm_factory.Creater = GlobalKey.UserName;
			modSrm_factory.CreateTime = DateTime.Now;
			modSrm_factory.Modifier = GlobalKey.UserName;
			modSrm_factory.ModifyTime = DateTime.Now;
			modSrm_factory.PinYinMa = modSrm_factory.FactoryName.GetFirstPinyin();
			modSrm_factory.State = Convert.ToInt32(EnumHelper.GetValue<SRMState>(this.cmbState.Text));
			modSrm_factory.AreaName = this.tbxAreaName.Text.Trim();
			modSrm_factory.AppSrvCode = this.tbxAppSrvCode.Text.Trim();
			modSrm_factory.RealName = this.tbxRealName.Text.Trim();
			bool flag = true;
			bool flag2 = this._dalfactory.IsExist("FactoryName", modSrm_factory.FactoryName, SqlDbType.NVarChar, ref flag);
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
					bool flag4 = this._dalfactory.GetModel("FactoryIndex", modSrm_factory.FactoryIndex) != null;
					if (flag4)
					{
						base.ShowToast(this, this.mKeyName + ShowWords.ReplaceText("IndexCannotRepeated"), "", "");
						result = false;
					}
					else
					{
						bool flag5 = !this._dalfactory.AddNoReturn(modSrm_factory);
						if (flag5)
						{
							this.OnOperateFail(modSrm_factory, false);
							base.ShowToast(this, ShowWords.ReplaceText("AddFalse"), "", "");
							result = false;
						}
						else
						{
							this.OnOperateSuccess(modSrm_factory, true);
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

		// Token: 0x06000402 RID: 1026 RVA: 0x000658DC File Offset: 0x00063ADC
		private bool Modify()
		{
			ModSrm_factory modSrm_factory = this._Mod.Clone() as ModSrm_factory;
			string factoryName = modSrm_factory.FactoryName;
			bool flag = modSrm_factory == null;
			bool result;
			if (flag)
			{
				base.ShowToast(this, ShowWords.ReplaceText("ModifyFalse"), "", "");
				result = false;
			}
			else
			{
				modSrm_factory.FactoryName = this.tbxName.Text.Trim();
				modSrm_factory.Modifier = GlobalKey.UserName;
				modSrm_factory.ModifyTime = DateTime.Now;
				modSrm_factory.PinYinMa = modSrm_factory.FactoryName.GetFirstPinyin();
				modSrm_factory.State = Convert.ToInt32(EnumHelper.GetValue<SRMState>(this.cmbState.Text));
				modSrm_factory.AreaName = this.tbxAreaName.Text.Trim();
				modSrm_factory.AppSrvCode = this.tbxAppSrvCode.Text.Trim();
				modSrm_factory.RealName = this.tbxRealName.Text.Trim();
				bool flag2 = true;
				bool flag3 = this._dalfactory.IsExistOutSelf("FactoryName", modSrm_factory.FactoryName, SqlDbType.NVarChar, this._CurrentId, ref flag2);
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
						bool flag5 = this._dalfactory.GetModelOutSelf("FactoryIndex", modSrm_factory.FactoryIndex, SqlDbType.Int, this._CurrentId) != null;
						if (flag5)
						{
							base.ShowToast(this, this.mKeyName + ShowWords.ReplaceText("IndexCannotRepeated"), "", "");
							result = false;
						}
						else
						{
							bool flag6 = !this._dalfactory.Update(modSrm_factory);
							if (flag6)
							{
								this.OnOperateFail(modSrm_factory, false);
								base.ShowToast(this, ShowWords.ReplaceText("ModifyFalse"), "", "");
								result = false;
							}
							else
							{
								this.OnOperateSuccess(modSrm_factory, this._Mod, true);
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

		// Token: 0x040006DE RID: 1758
		protected DAL.SQLServer.SQSConfig.DalSrm_factory _dalfactory = DAL.Base.SQSConfig.DalSrm_factory.Instance;

		// Token: 0x040006DF RID: 1759
		protected new ModSrm_factory _Mod = new ModSrm_factory();

		// Token: 0x040006E0 RID: 1760
		public string mKeyName = ShowWords.ReplaceText("SrmFactory");
	}
}
