using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Base;
using DAL.Base.SQSConfig;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using DevComponents.DotNetBar.Layout;
using DevComponents.Editors;
using Model;
using Model.SQSConfig;
using SQSClient.Properties;

namespace SQSClient
{
	// Token: 0x02000087 RID: 135
	public partial class frmUnitEdit : BaseDialogForm
	{
		// Token: 0x06000758 RID: 1880 RVA: 0x000B6210 File Offset: 0x000B4410
		public frmUnitEdit(string text, BaseForm.FormActtion act, int id, string dir)
		{
			this.InitializeComponent();
			this.SetText(this);
			this.Text = text;
			this._Act = act;
			this._CurrentId = id;
			this._Direct = dir;
		}

		// Token: 0x06000759 RID: 1881 RVA: 0x000B6264 File Offset: 0x000B4464
		private void frmUnitEdit_Load(object sender, EventArgs e)
		{
			this.InitControl();
			this.LoadData();
		}

		// Token: 0x0600075A RID: 1882 RVA: 0x000B6278 File Offset: 0x000B4478
		private void InitControl()
		{
			this.cmbType.BindDataSouce(BaseForm.GetEnumModelList<BusinessType>(), "Description", "Description", "Value");
			List<ModCfg_unitgroup> allList = DalCfg_unitgroup.Instance.GetAllList();
			this.cmbGroup.BindDataSouce(allList, "Name", "PinYinMa", "Id");
			List<ModCfg_device> allList2 = DalCfg_device.Instance.GetAllList();
			this.cmbDevice.BindDataSouce(allList2, "Name", "PinYinMa", "Id");
			this.cmbTank.BindDataSouce(DalT_tank.Instance.GetAllList(), "Name", "PinYinMa", "Code");
		}

		// Token: 0x0600075B RID: 1883 RVA: 0x000B631C File Offset: 0x000B451C
		protected override void LoadData()
		{
			bool flag = BaseForm.FormActtion.Modify == this._Act;
			if (flag)
			{
				this._mod = DalCfg_unit.Instance.GetModel(this._CurrentId);
				bool flag2 = this._mod == null;
				if (flag2)
				{
					base.ShowMsg(Messages.ObjNonExist, "", "");
					base.Close();
				}
				else
				{
					this.tbxName.Text = this._mod.Name;
					this.cmbGroup.Text = this._mod.GroupName;
					this.cmbType.SelectedValue = this._mod.BusinessType;
					this.cmbDevice.Text = this._mod.DeviceName;
					this.iInputCode.Value = this._mod.Code;
					this.nudUnitIndex.Value = this._mod.UnitIndex;
					this.nudLuHao.Value = this._mod.LuHao;
					this.cmbTank.SelectedValue = this._mod.TankCode;
					this.chkState.Checked = this._mod.State;
					this.rtbRemark.Text = this._mod.Remark;
				}
			}
			else
			{
				bool flag3 = this._Act == BaseForm.FormActtion.Add;
				if (flag3)
				{
					ModCfg_unit modelByColumnDesc = DalCfg_unit.Instance.GetModelByColumnDesc("Code");
					bool flag4 = modelByColumnDesc == null;
					if (flag4)
					{
						this.iInputCode.Value = 1;
					}
					else
					{
						this.iInputCode.Value = modelByColumnDesc.Code + 1;
					}
					this.tbxName.Text = ShowWords.ReplaceText("Unit") + this.iInputCode.Value.ToString();
				}
			}
		}

		// Token: 0x0600075C RID: 1884 RVA: 0x000B64F8 File Offset: 0x000B46F8
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

		// Token: 0x0600075D RID: 1885 RVA: 0x000B6548 File Offset: 0x000B4748
		private bool Add()
		{
			this._mod.Name = this.tbxName.Text.Trim();
			this._mod.GroupName = this.cmbGroup.Text;
			this._mod.DeviceName = this.cmbDevice.Text;
			this._mod.Code = this.iInputCode.Value;
			this._mod.UnitIndex = this.nudUnitIndex.Value;
			this._mod.BusinessType = (int)this.cmbType.SelectedValue;
			this._mod.LuHao = this.nudLuHao.Value;
			this._mod.TankCode = 0;
			bool flag = this.cmbTank.SelectedValue != null;
			if (flag)
			{
				this._mod.TankCode = (int)this.cmbTank.SelectedValue;
			}
			this._mod.State = this.chkState.Checked;
			this._mod.MutexNum = this._mod.Code;
			this._mod.Remark = this.rtbRemark.Text.Trim();
			this._mod.PinYinMa = this._mod.Name.GetFirstPinyin();
			this._mod.CommTime = DateTime.Now;
			bool flag2 = base.IsExist("cfg_unit", "Name", this._mod.Name, SqlDbType.NVarChar);
			bool result;
			if (flag2)
			{
				base.ShowMsg(Messages.UnitHaved, "", "");
				this.tbxName.Focus();
				result = false;
			}
			else
			{
				bool flag3 = base.IsExist("cfg_unit", "Code", this._mod.Code, SqlDbType.Int);
				if (flag3)
				{
					base.ShowMsg(Messages.UnitCodeHaved, "", "");
					this.iInputCode.Focus();
					result = false;
				}
				else
				{
					bool flag4 = false;
					bool flag5 = DalCfg_unit.Instance.CheckExistLuHao(this._mod, 0, ref flag4);
					if (flag5)
					{
						bool flag6 = flag4;
						if (flag6)
						{
							base.ShowMsg(Messages.LuHaoHaved, "", "");
							this.nudLuHao.Focus();
							return false;
						}
					}
					bool flag7 = !DalCfg_unit.Instance.AddNoReturn(this._mod);
					if (flag7)
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
				}
			}
			return result;
		}

		// Token: 0x0600075E RID: 1886 RVA: 0x000B67FC File Offset: 0x000B49FC
		private bool Modify()
		{
			ModCfg_unit oldValue = this._mod.Clone() as ModCfg_unit;
			this._mod.Name = this.tbxName.Text.Trim();
			this._mod.GroupName = this.cmbGroup.Text;
			this._mod.BusinessType = (int)this.cmbType.SelectedValue;
			this._mod.DeviceName = this.cmbDevice.Text;
			this._mod.Code = this.iInputCode.Value;
			this._mod.UnitIndex = this.nudUnitIndex.Value;
			this._mod.LuHao = this.nudLuHao.Value;
			this._mod.TankCode = 0;
			bool flag = this.cmbTank.SelectedValue != null;
			if (flag)
			{
				this._mod.TankCode = (int)this.cmbTank.SelectedValue;
			}
			this._mod.State = this.chkState.Checked;
			this._mod.Remark = this.rtbRemark.Text.Trim();
			this._mod.PinYinMa = this._mod.Name.GetFirstPinyin();
			bool flag2 = base.IsExistOutSelf("cfg_unit", "Name", this._mod.Name, SqlDbType.NVarChar, this._CurrentId);
			bool result;
			if (flag2)
			{
				base.ShowMsg(Messages.UnitHaved, "", "");
				this.tbxName.Focus();
				result = false;
			}
			else
			{
				bool flag3 = base.IsExistOutSelf("cfg_unit", "Code", this._mod.Code, SqlDbType.Int, this._CurrentId);
				if (flag3)
				{
					base.ShowMsg(Messages.UnitCodeHaved, "", "");
					this.iInputCode.Focus();
					result = false;
				}
				else
				{
					bool flag4 = false;
					bool flag5 = DalCfg_unit.Instance.CheckExistLuHao(this._mod, this._CurrentId, ref flag4);
					if (flag5)
					{
						bool flag6 = flag4;
						if (flag6)
						{
							base.ShowMsg(Messages.LuHaoHaved, "", "");
							this.nudLuHao.Focus();
							return false;
						}
					}
					bool flag7 = !DalCfg_unit.Instance.Update(this._mod);
					if (flag7)
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
				}
			}
			return result;
		}

		// Token: 0x0600075F RID: 1887 RVA: 0x000B6AB0 File Offset: 0x000B4CB0
		private bool TextCheck()
		{
			bool flag = string.IsNullOrWhiteSpace(this.tbxName.Text);
			bool result;
			if (flag)
			{
				base.ShowMsg(Messages.UnitNull, "", "");
				this.tbxName.Focus();
				result = false;
			}
			else
			{
				bool flag2 = string.IsNullOrWhiteSpace(this.iInputCode.Text);
				if (flag2)
				{
					base.ShowMsg(Messages.UnitCodeNull, "", "");
					this.iInputCode.Focus();
					result = false;
				}
				else
				{
					bool flag3 = string.IsNullOrWhiteSpace(this.nudUnitIndex.Text);
					if (flag3)
					{
						base.ShowMsg(Messages.UnitIndexNull, "", "");
						this.nudUnitIndex.Focus();
						result = false;
					}
					else
					{
						bool flag4 = string.IsNullOrWhiteSpace(this.cmbGroup.Text);
						if (flag4)
						{
							base.ShowMsg(Messages.GroupNull, "", "");
							this.cmbGroup.Focus();
							result = false;
						}
						else
						{
							bool flag5 = string.IsNullOrWhiteSpace(this.cmbType.Text);
							if (flag5)
							{
								base.ShowMsg(Messages.BusinessTypeNull, "", "");
								this.cmbType.Focus();
								result = false;
							}
							else
							{
								bool flag6 = string.IsNullOrWhiteSpace(this.cmbDevice.Text);
								if (flag6)
								{
									base.ShowMsg(Messages.DeviceNull, "", "");
									this.cmbDevice.Focus();
									result = false;
								}
								else
								{
									bool flag7 = string.IsNullOrWhiteSpace(this.nudLuHao.Text);
									if (flag7)
									{
										base.ShowMsg(Messages.LuHaoNull, "", "");
										this.nudLuHao.Focus();
										result = false;
									}
									else
									{
										bool flag8 = false;
										DalCfg_unitgroup.Instance.IsExist("Name", this.cmbGroup.Text.Trim(), SqlDbType.NVarChar, ref flag8);
										bool flag9 = !flag8;
										if (flag9)
										{
											base.ShowMsg(Messages.GroupHavent, "", "");
											result = false;
										}
										else
										{
											DalCfg_device.Instance.IsExist("Name", this.cmbDevice.Text.Trim(), SqlDbType.NVarChar, ref flag8);
											bool flag10 = !flag8;
											if (flag10)
											{
												base.ShowMsg(Messages.DeviceHavent, "", "");
												result = false;
											}
											else
											{
												result = true;
											}
										}
									}
								}
							}
						}
					}
				}
			}
			return result;
		}

		// Token: 0x06000760 RID: 1888 RVA: 0x000B6D14 File Offset: 0x000B4F14
		private void cmbDevice_TextChanged(object sender, EventArgs e)
		{
			ModCfg_device model = DalCfg_device.Instance.GetModel("Name", this.cmbDevice.Text.Trim());
			bool flag = model != null;
			if (flag)
			{
				this.nudLuHao.MaxValue = model.Ways;
				this.chkState.Checked = model.State;
				this.chkState.Enabled = model.State;
			}
		}

		// Token: 0x06000761 RID: 1889 RVA: 0x000B6D84 File Offset: 0x000B4F84
		private void cmbTank_TextChanged(object sender, EventArgs e)
		{
			ModT_tank model = DalT_tank.Instance.GetModel("Name", this.cmbTank.Text.Trim());
			bool flag = model != null;
			if (flag)
			{
			}
		}

		// Token: 0x04000C84 RID: 3204
		private ModCfg_unit _mod = new ModCfg_unit();
	}
}
