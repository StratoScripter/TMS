using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Assistant;
using Base;
using DAL.Base.SQSConfig;
using DevComponents.AdvTree;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using Model;
using Model.SQSConfig;
using SQSClient.Properties;

namespace SQSClient
{
	// Token: 0x02000086 RID: 134
	public partial class frmUnit : BaseDialogForm
	{
		// Token: 0x0600073D RID: 1853 RVA: 0x000B40A8 File Offset: 0x000B22A8
		public frmUnit()
		{
			this.InitializeComponent();
			this.SetText(this);
			this._Controls.Clear();
			this._Controls.Add(this.contextMenuGroup);
			this._Controls.Add(this.barGroup);
			this._Controls.Add(this.bar);
			this._Controls.Add(this.dgvData);
			base.SetGridUI(this.dgvData);
		}

		// Token: 0x0600073E RID: 1854 RVA: 0x000B415F File Offset: 0x000B235F
		private void frmUnit_Load(object sender, EventArgs e)
		{
			BaseDialogForm._operateArgs.Category = this.Text;
			base.InitBurron();
			this.InitControl();
			this.LoadGroupData();
			this.LoadData("");
		}

		// Token: 0x0600073F RID: 1855 RVA: 0x00003040 File Offset: 0x00001240
		private void InitControl()
		{
		}

		// Token: 0x06000740 RID: 1856 RVA: 0x000B4194 File Offset: 0x000B2394
		protected void LoadGroupData()
		{
			this.treeData = DalCfg_unitgroup.Instance.GetAllData("ParentId");
			bool flag = this.treeData == null;
			if (!flag)
			{
				this.treeGroup.Nodes.Clear();
				DataRow[] array = this.treeData.Select("ParentId=0");
				foreach (DataRow dataRow in array)
				{
					Node node = new Node();
					node.Tag = dataRow;
					node.BindingIndex = int.Parse(dataRow["Id"].ToString());
					node.Text = dataRow["Name"].ToString();
					this.treeGroup.Nodes.Add(node);
					this.BindChildAreas(node);
				}
				this.treeGroup.ExpandAll();
			}
		}

		// Token: 0x06000741 RID: 1857 RVA: 0x000B4274 File Offset: 0x000B2474
		private void BindChildAreas(Node fNode)
		{
			DataRow dataRow = (DataRow)fNode.Tag;
			int num = (int)dataRow["Id"];
			DataRow[] array = this.treeData.Select("ParentId=" + num.ToString());
			bool flag = array.Length == 0;
			if (!flag)
			{
				foreach (DataRow dataRow2 in array)
				{
					Node node = new Node();
					node.Tag = dataRow2;
					node.BindingIndex = int.Parse(dataRow2["Id"].ToString());
					node.Text = dataRow2["Name"].ToString();
					fNode.Nodes.Add(node);
					this.BindChildAreas(node);
				}
			}
		}

		// Token: 0x06000742 RID: 1858 RVA: 0x000B4348 File Offset: 0x000B2548
		protected override void LoadData(string Name)
		{
			this.dgvData.Rows.Clear();
			List<ModCfg_unit> list = new List<ModCfg_unit>();
			bool flag = Name == "";
			if (flag)
			{
				list = DalCfg_unit.Instance.GetAllList();
			}
			else
			{
				list = DalCfg_unit.Instance.GetAllList(Name);
			}
			foreach (ModCfg_unit modCfg_unit in list)
			{
				int num = 0;
				object[] array = new object[this.dgvData.ColumnCount];
				array[num++] = modCfg_unit.Id;
				array[num++] = modCfg_unit.Name;
				array[num++] = modCfg_unit.Code;
				array[num++] = modCfg_unit.GroupName;
				array[num++] = ShowWords.ReplaceText(EnumHelper.GetDescription<BusinessType>((BusinessType)modCfg_unit.BusinessType));
				array[num++] = modCfg_unit.UnitIndex;
				array[num++] = modCfg_unit.DeviceName;
				array[num++] = modCfg_unit.LuHao;
				array[num++] = modCfg_unit.CurProductName;
				array[num++] = modCfg_unit.CurDanWei;
				array[num++] = Resources.edit16;
				array[num++] = Resources.edit16;
				array[num++] = modCfg_unit.State;
				array[num++] = modCfg_unit.Remark;
				this.dgvData.Rows.Add(array);
			}
			bool flag2 = this.dgvData.Rows.Count > 0;
			if (flag2)
			{
				this.GetCurrentItem(0);
			}
			else
			{
				this.btnModifyUnit.Enabled = false;
				this.btnDeleteUnit.Enabled = false;
			}
		}

		// Token: 0x06000743 RID: 1859 RVA: 0x000B4554 File Offset: 0x000B2754
		private void treeGroup_NodeClick(object sender, TreeNodeMouseEventArgs e)
		{
			bool flag = !e.Node.HasChildNodes;
			if (flag)
			{
				this.dgvData.Rows.Clear();
				this.LoadData("");
			}
		}

		// Token: 0x06000744 RID: 1860 RVA: 0x000B4594 File Offset: 0x000B2794
		private void treeGroup_AfterNodeDrop(object sender, TreeDragDropEventArgs e)
		{
			bool flag = e.NewParentNode == null;
			if (flag)
			{
				this.selectedNodeMod.TreeLevel = 0;
				this.selectedNodeMod.ParentId = 0;
			}
			else
			{
				this.selectedNodeMod.TreeLevel = e.NewParentNode.Level + 1;
				this.selectedNodeMod.ParentId = e.NewParentNode.BindingIndex;
			}
			DalCfg_unitgroup.Instance.Update(this.selectedNodeMod);
		}

		// Token: 0x06000745 RID: 1861 RVA: 0x000B4610 File Offset: 0x000B2810
		private void treeGroup_NodeMouseDown(object sender, TreeNodeMouseEventArgs e)
		{
			this.selectedNode = e.Node;
			this.selectedNodeMod = DalCfg_unitgroup.Instance.GetModel(e.Node.BindingIndex);
			this._SelectGroupID = e.Node.BindingIndex;
			bool flag = e.Button == MouseButtons.Right;
			if (flag)
			{
				this.toolAddGroup.Visible = true;
				this.toolModifyGroup.Visible = true;
				this.toolDeleteGroup.Visible = true;
				bool hasChildNodes = e.Node.HasChildNodes;
				if (hasChildNodes)
				{
					this.toolDeleteGroup.Visible = false;
				}
				this.toolLine.Visible = true;
				this.toolAddUnit.Visible = true;
			}
		}

		// Token: 0x06000746 RID: 1862 RVA: 0x000B46C8 File Offset: 0x000B28C8
		private void treeGroup_MouseDown(object sender, MouseEventArgs e)
		{
			bool flag = e.Button == MouseButtons.Right;
			if (flag)
			{
				this.toolAddGroup.Visible = true;
				this.toolModifyGroup.Visible = false;
				this.toolDeleteGroup.Visible = false;
				this.toolLine.Visible = false;
				this.toolAddUnit.Visible = false;
			}
			bool flag2 = e.Button == MouseButtons.Left;
			if (flag2)
			{
				this.treeGroup.SelectedNode = null;
				this.selectedNodeMod = null;
				this._SelectGroupID = 0;
			}
		}

		// Token: 0x06000747 RID: 1863 RVA: 0x000B4758 File Offset: 0x000B2958
		private void btnAddGroup_Click(object sender, EventArgs e)
		{
			this.OpenGroupForm(((ButtonItem)sender).Text, BaseForm.FormActtion.Add);
		}

		// Token: 0x06000748 RID: 1864 RVA: 0x000B476E File Offset: 0x000B296E
		private void toolAddGroup_Click(object sender, EventArgs e)
		{
			this.OpenGroupForm(((ToolStripItem)sender).Text, BaseForm.FormActtion.Add);
		}

		// Token: 0x06000749 RID: 1865 RVA: 0x000B4784 File Offset: 0x000B2984
		private void toolModifyGroup_Click(object sender, EventArgs e)
		{
			this.OpenGroupForm(((ToolStripItem)sender).Text, BaseForm.FormActtion.Modify);
		}

		// Token: 0x0600074A RID: 1866 RVA: 0x000B479C File Offset: 0x000B299C
		private void toolDeleteGroup_Click(object sender, EventArgs e)
		{
			BaseDialogForm._operateArgs.OperateType = ((ToolStripItem)sender).Text;
			bool flag = !base.ShowChoise(Messages.DeleteSure, "", "");
			if (!flag)
			{
				ModCfg_unitgroup model = DalCfg_unitgroup.Instance.GetModel(this._SelectGroupID);
				bool flag2 = !DalCfg_unitgroup.Instance.Delete(this._SelectGroupID);
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

		// Token: 0x0600074B RID: 1867 RVA: 0x000B4846 File Offset: 0x000B2A46
		private void toolAddUnit_Click(object sender, EventArgs e)
		{
			this.OpenForm(typeof(frmUnitEdit), ((ToolStripItem)sender).Text, BaseForm.FormActtion.Add, this._FrmName);
		}

		// Token: 0x0600074C RID: 1868 RVA: 0x000B486C File Offset: 0x000B2A6C
		private void btnAdd_Click(object sender, EventArgs e)
		{
			this.OpenForm(typeof(frmUnitEdit), ((ButtonItem)sender).Text, BaseForm.FormActtion.Add, this._FrmName);
		}

		// Token: 0x0600074D RID: 1869 RVA: 0x000B4892 File Offset: 0x000B2A92
		private void btnModify_Click(object sender, EventArgs e)
		{
			this.OpenForm(typeof(frmUnitEdit), ((ButtonItem)sender).Text, BaseForm.FormActtion.Modify, this._FrmName);
		}

		// Token: 0x0600074E RID: 1870 RVA: 0x000B48B8 File Offset: 0x000B2AB8
		private void btnDelete_Click(object sender, EventArgs e)
		{
			BaseDialogForm._operateArgs.OperateType = ((ButtonItem)sender).Text;
			ModCfg_unit model = DalCfg_unit.Instance.GetModel(this._CurrentId);
			bool flag = !base.ShowChoise(Messages.DeleteSure, "", "");
			if (!flag)
			{
				bool flag2 = !DalCfg_unit.Instance.Delete(this._CurrentId);
				if (flag2)
				{
					this.OnOperateFail(model, false);
					base.ShowMsg(Messages.DeleteFalse, "", "");
				}
				else
				{
					this.OnOperateSuccess(model, true);
					this.LoadData("");
				}
			}
		}

		// Token: 0x0600074F RID: 1871 RVA: 0x000B4967 File Offset: 0x000B2B67
		private void btnSearch_Click(object sender, EventArgs e)
		{
			this.LoadData(this.txtName.Text.Trim());
		}

		// Token: 0x06000750 RID: 1872 RVA: 0x000B4984 File Offset: 0x000B2B84
		private void txtName_KeyPress(object sender, KeyPressEventArgs e)
		{
			bool flag = e.KeyChar == '\r';
			if (flag)
			{
				this.LoadData(this.txtName.Text.Trim());
			}
		}

		// Token: 0x06000751 RID: 1873 RVA: 0x000B49BC File Offset: 0x000B2BBC
		private void dgvUnit_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			bool flag = e.RowIndex >= 0;
			if (flag)
			{
				this.GetCurrentItem(e.RowIndex);
			}
		}

		// Token: 0x06000752 RID: 1874 RVA: 0x000B49EC File Offset: 0x000B2BEC
		private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			bool flag = ((DataGridViewX)sender).CurrentCell != null && ((DataGridViewX)sender).CurrentCell.OwningColumn.Name == "C_MutexConfig";
			if (flag)
			{
				this.OpenForm(typeof(MutexCheck), ((DataGridViewX)sender).CurrentCell.OwningColumn.HeaderText, BaseForm.FormActtion.Modify);
			}
			bool flag2 = ((DataGridViewX)sender).CurrentCell != null && ((DataGridViewX)sender).CurrentCell.OwningColumn.Name == "C_CurProductCodeList";
			if (flag2)
			{
				this.OpenForm(typeof(frmUnitProducts), ((DataGridViewX)sender).CurrentCell.OwningColumn.HeaderText, BaseForm.FormActtion.Modify);
			}
		}

		// Token: 0x06000753 RID: 1875 RVA: 0x000B4AB4 File Offset: 0x000B2CB4
		private void dgvUnit_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			bool flag = e.RowIndex >= 0;
			if (flag)
			{
				this.OpenForm(typeof(frmUnitEdit), this.btnModifyUnit.Text, BaseForm.FormActtion.Modify, this._FrmName);
			}
		}

		// Token: 0x06000754 RID: 1876 RVA: 0x000B4AF8 File Offset: 0x000B2CF8
		private void GetCurrentItem(int rowindex)
		{
			this._CurrentId = int.Parse(this.dgvData.Rows[rowindex].Cells[0].Value.ToString());
			this._CurrentItemName = this.dgvData.Rows[rowindex].Cells["C_UnitName"].Value.ToString();
			this.btnModifyUnit.Enabled = true;
			this.btnDeleteUnit.Enabled = true;
		}

		// Token: 0x06000755 RID: 1877 RVA: 0x000B4B84 File Offset: 0x000B2D84
		protected void OpenGroupForm(string title, BaseForm.FormActtion action)
		{
			frmUnitGroupEdit frmUnitGroupEdit = new frmUnitGroupEdit(title, action, this._SelectGroupID, this.selectedNodeMod, this._FrmName);
			bool flag = frmUnitGroupEdit.ShowDialog() == DialogResult.Yes;
			if (flag)
			{
				this.LoadGroupData();
			}
		}

		// Token: 0x04000C57 RID: 3159
		private int _SelectGroupID = 0;

		// Token: 0x04000C58 RID: 3160
		private DataTable treeData = new DataTable();

		// Token: 0x04000C59 RID: 3161
		private bool isnew = false;

		// Token: 0x04000C5A RID: 3162
		private ModCfg_unitgroup selectedNodeMod = null;

		// Token: 0x04000C5B RID: 3163
		private Node selectedNode = new Node();
	}
}
