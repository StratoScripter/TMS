using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Base;
using DAL.Base.SQSConfig;
using DevComponents.AdvTree;
using DevComponents.DotNetBar;
using SQSClient.Properties;

namespace SQSClient
{
	// Token: 0x02000062 RID: 98
	public partial class frmPermissionChoose : BaseDialogForm
	{
		// Token: 0x060004B3 RID: 1203 RVA: 0x000767FC File Offset: 0x000749FC
		public frmPermissionChoose(string text, BaseForm.FormActtion act, int id)
		{
			this.InitializeComponent();
			this.SetText(this);
			this.Text = text;
			this._Act = act;
			this._CurrentId = id;
		}

		// Token: 0x060004B4 RID: 1204 RVA: 0x0004A128 File Offset: 0x00048328
		private void frmPermissionChoose_Load(object sender, EventArgs e)
		{
			this.LoadData();
		}

		// Token: 0x060004B5 RID: 1205 RVA: 0x00076848 File Offset: 0x00074A48
		protected override void LoadData()
		{
			this.treeData = DalSys_authority.Instance.GetAllData(this._CurrentId, true);
			this.treeMenu.Nodes.Clear();
			DataRow[] array = this.treeData.Select("ParentId=0");
			foreach (DataRow dataRow in array)
			{
				Node node = new Node();
				node.DragDropEnabled = false;
				node.CheckBoxVisible = true;
				bool flag = bool.Parse(dataRow["Force"].ToString());
				if (flag)
				{
					node.Enabled = false;
				}
				node.Tag = dataRow;
				node.BindingIndex = int.Parse(dataRow["MenuId"].ToString());
				node.Name = dataRow["MenuName"].ToString();
				node.Text = ShowWords.ReplaceText(dataRow["MenuTitle"].ToString());
				node.CheckState = (CheckState)byte.Parse(dataRow["Choosed"].ToString());
				this.treeMenu.Nodes.Add(node);
				this.BindChild(node);
			}
			this.treeMenu.ExpandAll();
		}

		// Token: 0x060004B6 RID: 1206 RVA: 0x0007698C File Offset: 0x00074B8C
		private void BindChild(Node node)
		{
			DataRow[] array = this.treeData.Select("ParentId=" + node.BindingIndex.ToString());
			bool flag = array.Length == 0;
			if (!flag)
			{
				foreach (DataRow dataRow in array)
				{
					Node node2 = new Node();
					node2.DragDropEnabled = false;
					node2.CheckBoxVisible = true;
					bool flag2 = bool.Parse(dataRow["Force"].ToString());
					if (flag2)
					{
						node2.Enabled = false;
					}
					node2.Tag = dataRow;
					node2.BindingIndex = int.Parse(dataRow["MenuId"].ToString());
					node2.Name = dataRow["MenuName"].ToString();
					node2.Text = ShowWords.ReplaceText(dataRow["MenuTitle"].ToString());
					node2.CheckState = (CheckState)byte.Parse(dataRow["Choosed"].ToString());
					node.Nodes.Add(node2);
					this.BindChild(node2);
				}
			}
		}

		// Token: 0x060004B7 RID: 1207 RVA: 0x00076AC4 File Offset: 0x00074CC4
		private void btnSave_Click(object sender, EventArgs e)
		{
			foreach (object obj in this.treeMenu.Nodes)
			{
				Node node = (Node)obj;
				((DataRow)node.Tag)["Choosed"] = node.CheckState;
				DalSys_authority.Instance.Update((DataRow)node.Tag);
				this.UpdateChild(node);
			}
			base.DialogResult = DialogResult.Yes;
		}

		// Token: 0x060004B8 RID: 1208 RVA: 0x00076B68 File Offset: 0x00074D68
		private void UpdateChild(Node node)
		{
			foreach (object obj in node.Nodes)
			{
				Node node2 = (Node)obj;
				((DataRow)node2.Tag)["Choosed"] = node2.CheckState;
				DalSys_authority.Instance.Update((DataRow)node2.Tag);
				this.UpdateChild(node2);
			}
		}

		// Token: 0x060004B9 RID: 1209 RVA: 0x00076C00 File Offset: 0x00074E00
		private void treeMenu_NodeClick(object sender, TreeNodeMouseEventArgs e)
		{
			bool flag = e.Node.CheckState == CheckState.Checked;
			if (flag)
			{
				this.ChangeChildState(e.Node, CheckState.Checked);
				bool flag2 = e.Node.Parent != null;
				if (flag2)
				{
					bool flag3 = e.Node.Name != "Show";
					if (flag3)
					{
						foreach (object obj in e.Node.Parent.Nodes)
						{
							Node node = (Node)obj;
							bool flag4 = node.Name == "Show";
							if (flag4)
							{
								node.CheckState = CheckState.Checked;
							}
						}
					}
				}
				this.ChangeParentState(e.Node, CheckState.Checked);
			}
			bool flag5 = e.Node.CheckState == CheckState.Unchecked;
			if (flag5)
			{
				this.ChangeChildState(e.Node, CheckState.Unchecked);
				bool flag6 = e.Node.Parent != null;
				if (flag6)
				{
					bool flag7 = e.Node.Name == "Show";
					if (flag7)
					{
						foreach (object obj2 in e.Node.Parent.Nodes)
						{
							Node node2 = (Node)obj2;
							node2.CheckState = CheckState.Unchecked;
						}
					}
				}
				this.ChangeParentState(e.Node, CheckState.Unchecked);
			}
		}

		// Token: 0x060004BA RID: 1210 RVA: 0x00076DB4 File Offset: 0x00074FB4
		private void ChangeChildState(Node node, CheckState state)
		{
			bool hasChildNodes = node.HasChildNodes;
			if (hasChildNodes)
			{
				foreach (object obj in node.Nodes)
				{
					Node node2 = (Node)obj;
					bool enabled = node2.Enabled;
					if (enabled)
					{
						node2.CheckState = state;
					}
					this.ChangeChildState(node2, state);
				}
			}
		}

		// Token: 0x060004BB RID: 1211 RVA: 0x00076E38 File Offset: 0x00075038
		private void ChangeSelfState(Node node)
		{
			bool flag = node.CheckState == CheckState.Unchecked;
			if (flag)
			{
				bool hasChildNodes = node.HasChildNodes;
				if (hasChildNodes)
				{
					foreach (object obj in node.Nodes)
					{
						Node node2 = (Node)obj;
						bool flag2 = node2.CheckState == CheckState.Checked;
						if (flag2)
						{
							node.CheckState = CheckState.Indeterminate;
						}
					}
				}
			}
		}

		// Token: 0x060004BC RID: 1212 RVA: 0x00076EC8 File Offset: 0x000750C8
		private void ChangeParentState(Node node, CheckState state)
		{
			bool flag = node.Parent != null;
			if (flag)
			{
				bool flag2 = state == CheckState.Indeterminate;
				if (flag2)
				{
					node.Parent.CheckState = state;
				}
				else
				{
					bool flag3 = true;
					foreach (object obj in node.Parent.Nodes)
					{
						Node node2 = (Node)obj;
						bool flag4 = node2.CheckState != state;
						if (flag4)
						{
							node.Parent.CheckState = CheckState.Indeterminate;
							state = CheckState.Indeterminate;
							flag3 = false;
							break;
						}
					}
					bool flag5 = flag3;
					if (flag5)
					{
						node.Parent.CheckState = state;
					}
				}
				this.ChangeParentState(node.Parent, state);
			}
		}

		// Token: 0x04000821 RID: 2081
		private DataTable treeData = new DataTable();
	}
}
