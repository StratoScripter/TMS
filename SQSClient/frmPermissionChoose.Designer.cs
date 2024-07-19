namespace SQSClient
{
	// Token: 0x02000062 RID: 98
	public partial class frmPermissionChoose : global::SQSClient.BaseDialogForm
	{
		// Token: 0x060004BD RID: 1213 RVA: 0x00076FA8 File Offset: 0x000751A8
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060004BE RID: 1214 RVA: 0x00076FE0 File Offset: 0x000751E0
		private void InitializeComponent()
		{
			this.menuBar = new global::DevComponents.DotNetBar.Bar();
			this.btnSave = new global::DevComponents.DotNetBar.ButtonItem();
			this.treeMenu = new global::DevComponents.AdvTree.AdvTree();
			this.node1 = new global::DevComponents.AdvTree.Node();
			this.nodeConnector1 = new global::DevComponents.AdvTree.NodeConnector();
			this.elementStyle1 = new global::DevComponents.DotNetBar.ElementStyle();
			((global::System.ComponentModel.ISupportInitialize)this.menuBar).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.treeMenu).BeginInit();
			base.SuspendLayout();
			this.menuBar.AccessibleDescription = "DotNetBar Bar (menuBar)";
			this.menuBar.AccessibleName = "DotNetBar Bar";
			this.menuBar.AccessibleRole = global::System.Windows.Forms.AccessibleRole.MenuBar;
			this.menuBar.BackColor = global::System.Drawing.Color.Transparent;
			this.menuBar.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.menuBar.Font = new global::System.Drawing.Font("微软雅黑", 9f);
			this.menuBar.IsMaximized = false;
			this.menuBar.Items.AddRange(new global::DevComponents.DotNetBar.BaseItem[]
			{
				this.btnSave
			});
			this.menuBar.Location = new global::System.Drawing.Point(0, 0);
			this.menuBar.MenuBar = true;
			this.menuBar.Name = "menuBar";
			this.menuBar.Size = new global::System.Drawing.Size(354, 26);
			this.menuBar.Stretch = true;
			this.menuBar.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.menuBar.TabIndex = 18;
			this.menuBar.TabStop = false;
			this.menuBar.Text = "Main Menu";
			this.btnSave.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.btnSave.Image = global::SQSClient.Properties.Resources.save16;
			this.btnSave.Name = "btnSave";
			this.btnSave.Text = "Save";
			this.btnSave.Click += new global::System.EventHandler(this.btnSave_Click);
			this.treeMenu.AccessibleRole = global::System.Windows.Forms.AccessibleRole.Outline;
			this.treeMenu.BackColor = global::System.Drawing.SystemColors.Window;
			this.treeMenu.BackgroundStyle.Class = "TreeBorderKey";
			this.treeMenu.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.treeMenu.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.treeMenu.Location = new global::System.Drawing.Point(0, 26);
			this.treeMenu.Name = "treeMenu";
			this.treeMenu.Nodes.AddRange(new global::DevComponents.AdvTree.Node[]
			{
				this.node1
			});
			this.treeMenu.NodesConnector = this.nodeConnector1;
			this.treeMenu.NodeStyle = this.elementStyle1;
			this.treeMenu.PathSeparator = ";";
			this.treeMenu.Size = new global::System.Drawing.Size(354, 546);
			this.treeMenu.Styles.Add(this.elementStyle1);
			this.treeMenu.TabIndex = 19;
			this.treeMenu.Text = "advTree1";
			this.treeMenu.NodeClick += new global::DevComponents.AdvTree.TreeNodeMouseEventHandler(this.treeMenu_NodeClick);
			this.node1.CheckBoxThreeState = true;
			this.node1.CheckBoxVisible = true;
			this.node1.Expanded = true;
			this.node1.Name = "node1";
			this.node1.Text = "node1";
			this.nodeConnector1.LineColor = global::System.Drawing.SystemColors.ControlText;
			this.elementStyle1.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.elementStyle1.Name = "elementStyle1";
			this.elementStyle1.TextColor = global::System.Drawing.SystemColors.ControlText;
			base.ClientSize = new global::System.Drawing.Size(354, 572);
			base.Controls.Add(this.treeMenu);
			base.Controls.Add(this.menuBar);
			base.Name = "frmPermissionChoose";
			this.Text = "frmPermissionChoose";
			base.Load += new global::System.EventHandler(this.frmPermissionChoose_Load);
			((global::System.ComponentModel.ISupportInitialize)this.menuBar).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.treeMenu).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000822 RID: 2082
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000823 RID: 2083
		private global::DevComponents.DotNetBar.Bar menuBar;

		// Token: 0x04000824 RID: 2084
		private global::DevComponents.DotNetBar.ButtonItem btnSave;

		// Token: 0x04000825 RID: 2085
		private global::DevComponents.AdvTree.AdvTree treeMenu;

		// Token: 0x04000826 RID: 2086
		private global::DevComponents.AdvTree.Node node1;

		// Token: 0x04000827 RID: 2087
		private global::DevComponents.AdvTree.NodeConnector nodeConnector1;

		// Token: 0x04000828 RID: 2088
		private global::DevComponents.DotNetBar.ElementStyle elementStyle1;
	}
}
