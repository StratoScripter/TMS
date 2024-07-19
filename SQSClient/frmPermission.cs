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
using Model;
using Model.SQSConfig;
using SQSClient.Properties;

namespace SQSClient
{
	// Token: 0x02000061 RID: 97
	public partial class frmPermission : BaseDialogForm
	{
		// Token: 0x0600049E RID: 1182 RVA: 0x000748DC File Offset: 0x00072ADC
		public frmPermission()
		{
			this.InitializeComponent();
			this.SetText(this);
			this._Controls.Clear();
			this._Controls.Add(this.contextMenuGroup);
			this._Controls.Add(this.barGroup);
			this._Controls.Add(this.barUser);
			this._Controls.Add(this.dgvData);
			base.SetGridUI(this.dgvData);
		}

		// Token: 0x0600049F RID: 1183 RVA: 0x0007498C File Offset: 0x00072B8C
		private void frmPermission_Load(object sender, EventArgs e)
		{
			base.InitBurron();
			this.InitControl();
			this.LoadGroupData();
			this.LoadUserData(DAL.Base.SQSConfig.DalSys_user.Instance.GetAllList().FindAll((ModSys_user u) => u.Role >= GlobalKey.Role));
			BaseDialogForm._operateArgs.Category = this.Text;
		}

		// Token: 0x060004A0 RID: 1184 RVA: 0x000749F5 File Offset: 0x00072BF5
		private void InitControl()
		{
			this.btnPermissionChoose.Enabled = false;
			this.toolModifyGroup.Enabled = false;
			this.toolDeleteGroup.Enabled = false;
		}

		// Token: 0x060004A1 RID: 1185 RVA: 0x00074A20 File Offset: 0x00072C20
		private void LoadGroupData()
		{
			this.itemGroup.Items.Clear();
			List<ModSys_group> list = DAL.Base.SQSConfig.DalSys_group.Instance.GetAllList().FindAll((ModSys_group g) => g.Department >= GlobalKey.Department);
			foreach (ModSys_group modSys_group in list)
			{
				ButtonItem buttonItem = new ButtonItem();
				buttonItem.Name = modSys_group.Id.ToString();
				buttonItem.Text = modSys_group.GroupName;
				buttonItem.Click += this.buttonItem_Click;
				this.itemGroup.Items.Add(buttonItem);
			}
			this.Refresh();
		}

		// Token: 0x060004A2 RID: 1186 RVA: 0x00074B04 File Offset: 0x00072D04
		private void LoadUserData(List<ModSys_user> list)
		{
			this.dgvData.Rows.Clear();
			foreach (ModSys_user modSys_user in list)
			{
				int num = 0;
				object[] array = new object[this.dgvData.ColumnCount];
				array[num++] = modSys_user.Id.ToString();
				array[num++] = modSys_user.UserName;
				array[num++] = modSys_user.GroupId;
				array[num++] = modSys_user.PhoneNum;
				array[num++] = modSys_user.State;
				array[num++] = modSys_user.Remark;
				this.dgvData.Rows.Add(array);
			}
			bool flag = this.dgvData.SelectedRows.Count > 0;
			if (flag)
			{
				this.GetSelectItem(this.dgvData.SelectedRows[0].Index);
			}
			else
			{
				this.btnModifyUser.Enabled = false;
				this.btnDeleteUser.Enabled = false;
			}
		}

		// Token: 0x060004A3 RID: 1187 RVA: 0x00074C44 File Offset: 0x00072E44
		private void btnAddUser_Click(object sender, EventArgs e)
		{
			BaseDialogForm baseDialogForm = base.CreateInstance<BaseDialogForm>(typeof(frmUserEdit), ((ButtonItem)sender).Text, BaseForm.FormActtion.Add, this._FrmName);
			bool flag = baseDialogForm.ShowDialog() == DialogResult.Yes;
			if (flag)
			{
				this.LoadUserData(DAL.Base.SQSConfig.DalSys_user.Instance.GetAllList().FindAll((ModSys_user u) => u.Role >= GlobalKey.Role));
			}
		}

		// Token: 0x060004A4 RID: 1188 RVA: 0x00074CBC File Offset: 0x00072EBC
		private void btnModifyUser_Click(object sender, EventArgs e)
		{
			BaseDialogForm baseDialogForm = base.CreateInstance<BaseDialogForm>(typeof(frmUserEdit), ((ButtonItem)sender).Text, BaseForm.FormActtion.Modify, this._FrmName);
			bool flag = baseDialogForm.ShowDialog() == DialogResult.Yes;
			if (flag)
			{
				this.LoadUserData(DAL.Base.SQSConfig.DalSys_user.Instance.GetAllList().FindAll((ModSys_user u) => u.Role >= GlobalKey.Role));
			}
		}

		// Token: 0x060004A5 RID: 1189 RVA: 0x00074D34 File Offset: 0x00072F34
		private void btnDeleteUser_Click(object sender, EventArgs e)
		{
			BaseDialogForm._operateArgs.OperateType = ((ButtonItem)sender).Text;
			bool flag = !base.ShowChoise(Messages.DeleteSure, "", "");
			if (!flag)
			{
				ModSys_user model = this._Dal.GetModel(this._CurrentId);
				bool flag2 = !this._Dal.Delete(this._CurrentId);
				if (flag2)
				{
					this.OnOperateFail(model, false);
					base.ShowMsg(Messages.DeleteFalse, "", "");
				}
				else
				{
					this.OnOperateSuccess(model, true);
					this.LoadUserData(DAL.Base.SQSConfig.DalSys_user.Instance.GetAllList().FindAll((ModSys_user u) => u.Role >= GlobalKey.Role));
					this.LoadData("");
				}
			}
		}

		// Token: 0x060004A6 RID: 1190 RVA: 0x00074E20 File Offset: 0x00073020
		private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			bool flag = e.RowIndex >= 0;
			if (flag)
			{
				this.GetSelectItem(e.RowIndex);
			}
		}

		// Token: 0x060004A7 RID: 1191 RVA: 0x00074E50 File Offset: 0x00073050
		private void dgvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			bool flag = e.RowIndex >= 0 && this._canModify;
			if (flag)
			{
				BaseDialogForm baseDialogForm = base.CreateInstance<BaseDialogForm>(typeof(frmUserEdit), this.btnModifyUser.Text, BaseForm.FormActtion.Modify, this._FrmName);
				bool flag2 = baseDialogForm.ShowDialog() == DialogResult.Yes;
				if (flag2)
				{
					this.LoadUserData(DAL.Base.SQSConfig.DalSys_user.Instance.GetAllList().FindAll((ModSys_user u) => u.Role >= GlobalKey.Role));
				}
			}
		}

		// Token: 0x060004A8 RID: 1192 RVA: 0x00074EE0 File Offset: 0x000730E0
		private void GetSelectItem(int rowindex)
		{
			this._CurrentId = int.Parse(this.dgvData.Rows[rowindex].Cells[0].Value.ToString());
			this._CurrentItemName = this.dgvData.Rows[rowindex].Cells["C_UserName"].Value.ToString();
			bool flag = DAL.Base.SQSConfig.DalSys_user.Instance.GetModel(this._CurrentId).Role >= GlobalKey.Role;
			if (flag)
			{
				this.btnModifyUser.Enabled = true;
				this.btnDeleteUser.Enabled = true;
			}
			else
			{
				this.btnModifyUser.Enabled = false;
				this.btnDeleteUser.Enabled = false;
			}
		}

		// Token: 0x060004A9 RID: 1193 RVA: 0x00074FAC File Offset: 0x000731AC
		private void toolAddGroup_Click(object sender, EventArgs e)
		{
			frmGroupEdit frmGroupEdit = new frmGroupEdit(((ToolStripMenuItem)sender).Text, BaseForm.FormActtion.Add, this._SelectGroupID, this._FrmName);
			bool flag = frmGroupEdit.ShowDialog() == DialogResult.Yes;
			if (flag)
			{
				this.LoadGroupData();
			}
		}

		// Token: 0x060004AA RID: 1194 RVA: 0x00074FF0 File Offset: 0x000731F0
		private void toolModifyGroup_Click(object sender, EventArgs e)
		{
			frmGroupEdit frmGroupEdit = new frmGroupEdit(((ToolStripMenuItem)sender).Text, BaseForm.FormActtion.Modify, this._SelectGroupID, this._FrmName);
			bool flag = frmGroupEdit.ShowDialog() == DialogResult.Yes;
			if (flag)
			{
				this.LoadGroupData();
				this.LoadUserData(DAL.Base.SQSConfig.DalSys_user.Instance.GetAllList().FindAll((ModSys_user u) => u.Role >= GlobalKey.Role));
			}
		}

		// Token: 0x060004AB RID: 1195 RVA: 0x00075068 File Offset: 0x00073268
		private void toolDeleteGroup_Click(object sender, EventArgs e)
		{
			BaseDialogForm._operateArgs.OperateType = ((ToolStripMenuItem)sender).Text;
			bool flag = !base.ShowChoise(Messages.DeleteSure, "", "");
			if (!flag)
			{
				ModSys_group model = this._Dalgroup.GetModel(this._SelectGroupID);
				bool flag2 = !this._Dalgroup.Delete(this._SelectGroupID);
				if (flag2)
				{
					this.OnOperateFail(model, false);
					base.ShowMsg(Messages.DeleteFalse, "", "");
				}
				else
				{
					this.OnOperateSuccess(model, true);
					this.LoadGroupData();
				}
			}
		}

		// Token: 0x060004AC RID: 1196 RVA: 0x00075114 File Offset: 0x00073314
		private void btnPermissionChoose_Click(object sender, EventArgs e)
		{
			frmPermissionChoose frmPermissionChoose = new frmPermissionChoose(((ButtonItem)sender).Text, BaseForm.FormActtion.Modify, this._SelectGroupID);
			bool flag = frmPermissionChoose.ShowDialog() == DialogResult.Yes;
			if (flag)
			{
				this.LoadGroupData();
			}
		}

		// Token: 0x060004AD RID: 1197 RVA: 0x00075150 File Offset: 0x00073350
		private void btnUpdatePermission_Click(object sender, EventArgs e)
		{
			List<ModSys_menu> allList = DAL.Base.SQSConfig.DalSys_menu.Instance.GetAllList();
			List<ModSys_group> allList2 = DAL.Base.SQSConfig.DalSys_group.Instance.GetAllList();
			foreach (ModSys_group modSys_group in allList2)
			{
				foreach (ModSys_menu modSys_menu in allList)
				{
					bool flag = false;
					ModSys_authority modSys_authority = DAL.Base.SQSConfig.DalSys_authority.Instance.GetModel(new List<string>
					{
						"GroupId",
						"MenuId"
					}, new List<object>
					{
						modSys_group.Id,
						modSys_menu.Id
					});
					bool flag2 = modSys_authority == null;
					if (flag2)
					{
						flag = true;
						modSys_authority = new ModSys_authority();
						modSys_authority.GroupId = modSys_group.Id;
						modSys_authority.Choosed = 0;
						modSys_authority.MenuId = modSys_menu.Id;
					}
					bool force = modSys_menu.Force;
					if (force)
					{
						modSys_authority.Choosed = 1;
					}
					modSys_authority.MenuTitle = modSys_menu.MenuTitle;
					modSys_authority.MenuName = modSys_menu.MenuName;
					modSys_authority.TreeLevel = modSys_menu.TreeLevel;
					modSys_authority.ParentId = modSys_menu.ParentId;
					modSys_authority.State = modSys_menu.State;
					modSys_authority.Force = modSys_menu.Force;
					modSys_authority.Remark = modSys_menu.Remark;
					bool flag3 = flag;
					if (flag3)
					{
						DAL.Base.SQSConfig.DalSys_authority.Instance.Add(modSys_authority);
					}
					else
					{
						DAL.Base.SQSConfig.DalSys_authority.Instance.Update(modSys_authority);
					}
				}
				List<ModSys_menu> list = allList.FindAll((ModSys_menu m) => m.Force);
				foreach (ModSys_menu modSys_menu2 in list)
				{
					this.UpdateParent(modSys_group.Id, modSys_menu2.ParentId);
				}
			}
			base.ShowMsg(Messages.UpdateTrue, "", "");
		}

		// Token: 0x060004AE RID: 1198 RVA: 0x000753E8 File Offset: 0x000735E8
		private void UpdateParent(int groupid, int parentid)
		{
			ModSys_authority model = DAL.Base.SQSConfig.DalSys_authority.Instance.GetModel(new List<string>
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
				List<ModSys_authority> listRequire = DAL.Base.SQSConfig.DalSys_authority.Instance.GetListRequire(list, null, null);
				for (int i = 0; i < listRequire.Count; i++)
				{
					bool flag2 = listRequire[i].Choosed != 1;
					if (flag2)
					{
						model.Choosed = 2;
						break;
					}
				}
				DAL.Base.SQSConfig.DalSys_authority.Instance.Update(model);
				this.UpdateParent(groupid, model.ParentId);
			}
		}

		// Token: 0x060004AF RID: 1199 RVA: 0x00075504 File Offset: 0x00073704
		private void itemGroup_Click(object sender, EventArgs e)
		{
			bool flag = this._SelectItem != null;
			if (flag)
			{
				this._SelectItem.ColorTable = eButtonColor.Orange;
			}
			this._SelectItem = null;
			this.btnPermissionChoose.Enabled = false;
			this.toolModifyGroup.Enabled = false;
			this.toolDeleteGroup.Enabled = false;
			this.LoadUserData(DAL.Base.SQSConfig.DalSys_user.Instance.GetAllList().FindAll((ModSys_user u) => u.Role >= GlobalKey.Role));
		}

		// Token: 0x060004B0 RID: 1200 RVA: 0x00075594 File Offset: 0x00073794
		private void buttonItem_Click(object sender, EventArgs e)
		{
			bool flag = this._SelectItem != null;
			if (flag)
			{
				this._SelectItem.ColorTable = eButtonColor.Orange;
			}
			this._SelectItem = (ButtonItem)sender;
			this._SelectItem.ColorTable = eButtonColor.OrangeWithBackground;
			this._SelectGroupID = int.Parse(this._SelectItem.Name);
			this.btnPermissionChoose.Enabled = true;
			this.toolModifyGroup.Enabled = true;
			List<ModSys_user> list = DAL.Base.SQSConfig.DalSys_user.Instance.GetList("GroupId", this._SelectGroupID);
			this.toolDeleteGroup.Enabled = (list.Count <= 0);
			this.LoadUserData(list);
		}

		// Token: 0x04000804 RID: 2052
		private DAL.SQLServer.SQSConfig.DalSys_user _Dal = DAL.Base.SQSConfig.DalSys_user.Instance;

		// Token: 0x04000805 RID: 2053
		private DAL.SQLServer.SQSConfig.DalSys_group _Dalgroup = DAL.Base.SQSConfig.DalSys_group.Instance;

		// Token: 0x04000806 RID: 2054
		private ButtonItem _SelectItem = null;

		// Token: 0x04000807 RID: 2055
		private int _SelectGroupID = 0;
	}
}
