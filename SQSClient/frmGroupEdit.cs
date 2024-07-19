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
	// Token: 0x0200007C RID: 124
	public partial class frmGroupEdit : BaseDialogForm
	{
		// Token: 0x060006D0 RID: 1744 RVA: 0x000A8194 File Offset: 0x000A6394
		public frmGroupEdit(string text, BaseForm.FormActtion act, int id, string dir)
		{
			this.InitializeComponent();
			this.SetText(this);
			this.Text = text;
			this._Act = act;
			this._CurrentId = id;
			this._Direct = dir;
		}

		// Token: 0x060006D1 RID: 1745 RVA: 0x000A81E8 File Offset: 0x000A63E8
		private void frmGroupEdit_Load(object sender, EventArgs e)
		{
			this.InitControl();
			this.LoadData();
		}

		// Token: 0x060006D2 RID: 1746 RVA: 0x000A81F9 File Offset: 0x000A63F9
		private void InitControl()
		{
			this.iInputLevel.MinValue = GlobalKey.Department;
		}

		// Token: 0x060006D3 RID: 1747 RVA: 0x000A8210 File Offset: 0x000A6410
		protected override void LoadData()
		{
			bool flag = BaseForm.FormActtion.Modify == this._Act;
			if (flag)
			{
				this._mod = DalSys_group.Instance.GetModel(this._CurrentId);
				bool flag2 = this._mod == null;
				if (flag2)
				{
					base.ShowMsg(Messages.ObjNonExist, "", "");
					base.Close();
				}
				else
				{
					this.txtName.Text = this._mod.GroupName;
					this.txtName.Enabled = false;
					this.iInputLevel.Value = this._mod.Department;
					this.chkState.Checked = this._mod.State;
					this.rtbRemark.Text = this._mod.Remark;
				}
			}
			else
			{
				this.iInputLevel.Value = GlobalKey.Department + 1;
			}
		}

		// Token: 0x060006D4 RID: 1748 RVA: 0x000A82F8 File Offset: 0x000A64F8
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

		// Token: 0x060006D5 RID: 1749 RVA: 0x000A8348 File Offset: 0x000A6548
		private bool Add()
		{
			this._mod.GroupName = this.txtName.Text.Trim();
			this._mod.Department = this.iInputLevel.Value;
			this._mod.Type = 1;
			this._mod.State = this.chkState.Checked;
			this._mod.Remark = this.rtbRemark.Text.Trim();
			bool flag = base.IsExist("sys_group", "GroupName", this._mod.GroupName, SqlDbType.NVarChar);
			bool result;
			if (flag)
			{
				base.ShowMsg(Messages.GroupHaved, "", "");
				result = false;
			}
			else
			{
				int num = DalSys_group.Instance.Add(this._mod);
				bool flag2 = num < 1;
				if (flag2)
				{
					this.OnOperateFail(this._mod, false);
					base.ShowMsg(Messages.AddFalse, "", "");
					result = false;
				}
				else
				{
					List<ModSys_menu> allList = DalSys_menu.Instance.GetAllList();
					foreach (ModSys_menu modSys_menu in allList)
					{
						ModSys_authority modSys_authority = new ModSys_authority();
						modSys_authority.GroupId = num;
						modSys_authority.Choosed = 0;
						bool force = modSys_menu.Force;
						if (force)
						{
							modSys_authority.Choosed = 1;
						}
						modSys_authority.MenuId = modSys_menu.Id;
						modSys_authority.MenuTitle = modSys_menu.MenuTitle;
						modSys_authority.MenuName = modSys_menu.MenuName;
						modSys_authority.TreeLevel = modSys_menu.TreeLevel;
						modSys_authority.ParentId = modSys_menu.ParentId;
						modSys_authority.State = modSys_menu.State;
						modSys_authority.Force = modSys_menu.Force;
						modSys_authority.Remark = modSys_menu.Remark;
						DalSys_authority.Instance.Add(modSys_authority);
					}
					this.OnOperateSuccess(this._mod, true);
					List<ModSys_menu> list = allList.FindAll((ModSys_menu m) => m.Force);
					foreach (ModSys_menu modSys_menu2 in list)
					{
						this.UpdateParent(num, modSys_menu2.ParentId);
					}
					bool flag3 = base.ShowChoise(Messages.PermissionChooseSure, "", "");
					if (flag3)
					{
						frmPermissionChoose frmPermissionChoose = new frmPermissionChoose(ShowWords.ReplaceText("PermissionChoose"), BaseForm.FormActtion.Modify, num);
						bool flag4 = frmPermissionChoose.ShowDialog() == DialogResult.Yes;
						if (flag4)
						{
						}
					}
					result = true;
				}
			}
			return result;
		}

		// Token: 0x060006D6 RID: 1750 RVA: 0x000A862C File Offset: 0x000A682C
		private void UpdateParent(int groupid, int parentid)
		{
			ModSys_authority model = DalSys_authority.Instance.GetModel(new List<string>
			{
				"GroupId",
				"MenuId"
			}, new List<object>
			{
				groupid,
				parentid
			});
			bool flag = model != null;
			if (flag)
			{
				model.Choosed = 1;
				List<string> list = new List<string>();
				list.Add("GroupId='" + groupid.ToString() + "'");
				list.Add("ParentId='" + model.MenuId.ToString() + "'");
				List<ModSys_authority> listRequire = DalSys_authority.Instance.GetListRequire(list, null, null);
				for (int i = 0; i < listRequire.Count; i++)
				{
					bool flag2 = listRequire[i].Choosed != 1;
					if (flag2)
					{
						model.Choosed = 2;
						break;
					}
				}
				DalSys_authority.Instance.Update(model);
				this.UpdateParent(groupid, model.ParentId);
			}
		}

		// Token: 0x060006D7 RID: 1751 RVA: 0x000A8748 File Offset: 0x000A6948
		private bool Modify()
		{
			ModSys_group oldValue = this._mod.Clone() as ModSys_group;
			this._mod.GroupName = this.txtName.Text.Trim();
			this._mod.Department = this.iInputLevel.Value;
			this._mod.State = this.chkState.Checked;
			this._mod.Remark = this.rtbRemark.Text.Trim();
			bool flag = !DalSys_group.Instance.Update(this._mod);
			bool result;
			if (flag)
			{
				this.OnOperateFail(this._mod, false);
				base.ShowMsg(Messages.ModifyFalse, "", "");
				result = false;
			}
			else
			{
				List<ModSys_user> list = DalSys_user.Instance.GetList("GroupId", this._mod.Id);
				foreach (ModSys_user modSys_user in list)
				{
					modSys_user.Role = this._mod.Department;
					modSys_user.State = this._mod.State;
					DalSys_user.Instance.Update(modSys_user);
				}
				this.OnOperateSuccess(this._mod, oldValue, true);
				result = true;
			}
			return result;
		}

		// Token: 0x060006D8 RID: 1752 RVA: 0x000A88C4 File Offset: 0x000A6AC4
		private bool TextCheck()
		{
			bool flag = string.IsNullOrWhiteSpace(this.txtName.Text);
			bool result;
			if (flag)
			{
				base.ShowMsg(Messages.GroupNull, "", "");
				result = false;
			}
			else
			{
				result = true;
			}
			return result;
		}

		// Token: 0x04000BA0 RID: 2976
		private ModSys_group _mod = new ModSys_group();
	}
}
