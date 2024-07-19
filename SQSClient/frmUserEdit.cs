using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Assistant;
using Base;
using DAL.Base.SQSConfig;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using DevComponents.DotNetBar.Layout;
using Model;
using Model.SQSConfig;
using SQSClient.Properties;

namespace SQSClient
{
	// Token: 0x0200007E RID: 126
	public partial class frmUserEdit : BaseDialogForm
	{
		// Token: 0x060006E1 RID: 1761 RVA: 0x000A9AF8 File Offset: 0x000A7CF8
		public frmUserEdit(string text, BaseForm.FormActtion act, int id, string dir)
		{
			this.InitializeComponent();
			this.SetText(this);
			this.Text = text;
			this._Act = act;
			this._CurrentId = id;
			this._Direct = dir;
		}

		// Token: 0x060006E2 RID: 1762 RVA: 0x000A9B4C File Offset: 0x000A7D4C
		private void frmUserEdit_Load(object sender, EventArgs e)
		{
			this.InitControl();
			this.LoadData();
		}

		// Token: 0x060006E3 RID: 1763 RVA: 0x000A9B60 File Offset: 0x000A7D60
		private void InitControl()
		{
			List<ModSys_group> list = DalSys_group.Instance.GetAllList().FindAll((ModSys_group g) => g.Department >= GlobalKey.Department);
			BaseForm.BindDataSouce(this.cmbGroup, list, "GroupName", "Id");
			BaseForm.BindDataSouce(this.cmbSex, BaseForm.GetEnumModelList<UserSex>(), "Description", "Value");
		}

		// Token: 0x060006E4 RID: 1764 RVA: 0x000A9BD0 File Offset: 0x000A7DD0
		protected override void LoadData()
		{
			bool flag = BaseForm.FormActtion.Modify == this._Act;
			if (flag)
			{
				this._mod = DalSys_user.Instance.GetModel(this._CurrentId);
				bool flag2 = this._mod == null;
				if (flag2)
				{
					base.ShowMsg(Messages.ObjNonExist, "", "");
					base.Close();
				}
				else
				{
					this.tbxName.Text = this._mod.UserName;
					this.tbxName.Enabled = false;
					this.tbxPwd.Text = "123456";
					this.tbxPwd.Enabled = false;
					this.tbxPwd2.Text = "123456";
					this.tbxPwd2.Enabled = false;
					this.cmbGroup.SelectedValue = this._mod.GroupId;
					this.cmbSex.SelectedValue = this._mod.Sex;
					this.tbxPhone.Text = this._mod.PhoneNum;
					this.tbxEmail.Text = this._mod.EmailAddr;
					this.rtbRemark.Text = this._mod.Remark;
					this.chkState.Checked = this._mod.State;
					this.chkManageself.Checked = this._mod.Manageself;
				}
			}
		}

		// Token: 0x060006E5 RID: 1765 RVA: 0x000A9D44 File Offset: 0x000A7F44
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

		// Token: 0x060006E6 RID: 1766 RVA: 0x000A9D94 File Offset: 0x000A7F94
		private bool Add()
		{
			this._mod.UserName = this.tbxName.Text.Trim();
			this._mod.Password = CodeHelper.GetMD5(this.tbxPwd.Text.Trim());
			this._mod.GroupId = (int)this.cmbGroup.SelectedValue;
			this._mod.Sex = (int)this.cmbSex.SelectedValue;
			this._mod.PhoneNum = this.tbxPhone.Text.Trim();
			this._mod.EmailAddr = this.tbxEmail.Text.Trim();
			this._mod.Role = DalSys_group.Instance.GetModel(this._mod.GroupId).Department;
			this._mod.Type = 1;
			this._mod.State = this.chkState.Checked;
			this._mod.Manageself = this.chkManageself.Checked;
			this._mod.Remark = this.rtbRemark.Text.Trim();
			bool flag = base.IsExist("sys_user", "UserName", this._mod.UserName, SqlDbType.NVarChar);
			bool result;
			if (flag)
			{
				base.ShowMsg(Messages.UserHaved, "", "");
				result = false;
			}
			else
			{
				int num = DalSys_user.Instance.Add(this._mod);
				bool flag2 = num < 1;
				if (flag2)
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
			return result;
		}

		// Token: 0x060006E7 RID: 1767 RVA: 0x000A9F68 File Offset: 0x000A8168
		private bool Modify()
		{
			ModSys_user oldValue = this._mod.Clone() as ModSys_user;
			this._mod.GroupId = (int)this.cmbGroup.SelectedValue;
			this._mod.Sex = (int)this.cmbSex.SelectedValue;
			this._mod.PhoneNum = this.tbxPhone.Text.Trim();
			this._mod.EmailAddr = this.tbxEmail.Text.Trim();
			this._mod.Role = DalSys_group.Instance.GetModel(this._mod.GroupId).Department;
			this._mod.State = this.chkState.Checked;
			this._mod.Manageself = this.chkManageself.Checked;
			this._mod.Remark = this.rtbRemark.Text.Trim();
			bool flag = !DalSys_user.Instance.Update(this._mod);
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

		// Token: 0x060006E8 RID: 1768 RVA: 0x000AA0C8 File Offset: 0x000A82C8
		private bool TextCheck()
		{
			bool flag = string.IsNullOrWhiteSpace(this.tbxName.Text);
			bool result;
			if (flag)
			{
				base.ShowMsg(Messages.UserNull, "", "");
				result = false;
			}
			else
			{
				bool flag2 = !RegexHelper.IsNumAndEnCh(this.tbxPwd.Text);
				if (flag2)
				{
					base.ShowMsg(Messages.PwdCheck, "", "");
					result = false;
				}
				else
				{
					bool flag3 = !this.tbxPwd.Text.Equals(this.tbxPwd2.Text);
					if (flag3)
					{
						base.ShowMsg(Messages.PwdEqual, "", "");
						this.tbxPwd.Text = string.Empty;
						this.tbxPwd2.Text = string.Empty;
						this.tbxPwd.Focus();
						result = false;
					}
					else
					{
						bool flag4 = string.IsNullOrWhiteSpace(this.cmbGroup.Text);
						if (flag4)
						{
							base.ShowMsg(Messages.GroupNull, "", "");
							result = false;
						}
						else
						{
							bool flag5 = !string.IsNullOrEmpty(this.tbxEmail.Text) && !RegexHelper.IsEmail(this.tbxEmail.Text);
							if (flag5)
							{
								base.ShowMsg(Messages.EmailFormat, "", "");
								result = false;
							}
							else
							{
								bool flag6 = !string.IsNullOrEmpty(this.tbxPhone.Text) && !RegexHelper.IsMobilePhone(this.tbxPhone.Text);
								if (flag6)
								{
									base.ShowMsg(Messages.PhoneNumFormat, "", "");
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
			return result;
		}

		// Token: 0x060006E9 RID: 1769 RVA: 0x000AA278 File Offset: 0x000A8478
		private void cmbGroup_TextChanged(object sender, EventArgs e)
		{
			ModSys_group model = DalSys_group.Instance.GetModel("GroupName", this.cmbGroup.Text.Trim());
			bool flag = model != null;
			if (flag)
			{
				this.chkState.Checked = model.State;
				this.chkState.Enabled = model.State;
			}
		}

		// Token: 0x04000BB7 RID: 2999
		private ModSys_user _mod = new ModSys_user();
	}
}
