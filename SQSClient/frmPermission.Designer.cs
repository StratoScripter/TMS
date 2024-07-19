namespace SQSClient
{
	// Token: 0x02000061 RID: 97
	public partial class frmPermission : global::SQSClient.BaseDialogForm
	{
		// Token: 0x060004B1 RID: 1201 RVA: 0x00075644 File Offset: 0x00073844
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060004B2 RID: 1202 RVA: 0x0007567C File Offset: 0x0007387C
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new global::System.Windows.Forms.DataGridViewCellStyle();
			this.btnDeleteUser = new global::DevComponents.DotNetBar.ButtonItem();
			this.btnAddUser = new global::DevComponents.DotNetBar.ButtonItem();
			this.barUser = new global::DevComponents.DotNetBar.Bar();
			this.line2 = new global::DevComponents.DotNetBar.Controls.Line();
			this.btnModifyUser = new global::DevComponents.DotNetBar.ButtonItem();
			this.controlContainerItem1 = new global::DevComponents.DotNetBar.ControlContainerItem();
			this.panelEx2 = new global::DevComponents.DotNetBar.PanelEx();
			this.dgvData = new global::DevComponents.DotNetBar.Controls.DataGridViewX();
			this.C_ID = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_UserName = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_GroupZB = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_PhoneNum = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_Enable = new global::DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn();
			this.C_Remark = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.expandableSplitter1 = new global::DevComponents.DotNetBar.ExpandableSplitter();
			this.barGroup = new global::DevComponents.DotNetBar.Bar();
			this.btnPermissionChoose = new global::DevComponents.DotNetBar.ButtonItem();
			this.btnUpdatePermission = new global::DevComponents.DotNetBar.ButtonItem();
			this.panelEx1 = new global::DevComponents.DotNetBar.PanelEx();
			this.itemGroup = new global::DevComponents.DotNetBar.ItemPanel();
			this.contextMenuGroup = new global::System.Windows.Forms.ContextMenuStrip(this.components);
			this.toolAddGroup = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolModifyGroup = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolDeleteGroup = new global::System.Windows.Forms.ToolStripMenuItem();
			((global::System.ComponentModel.ISupportInitialize)this.barUser).BeginInit();
			this.barUser.SuspendLayout();
			this.panelEx2.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvData).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.barGroup).BeginInit();
			this.panelEx1.SuspendLayout();
			this.contextMenuGroup.SuspendLayout();
			base.SuspendLayout();
			this.btnDeleteUser.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.btnDeleteUser.Image = global::SQSClient.Properties.Resources.delete16;
			this.btnDeleteUser.Name = "btnDeleteUser";
			this.btnDeleteUser.Text = "DeleteUser";
			this.btnDeleteUser.Click += new global::System.EventHandler(this.btnDeleteUser_Click);
			this.btnAddUser.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.btnAddUser.Image = global::SQSClient.Properties.Resources.add16;
			this.btnAddUser.Name = "btnAddUser";
			this.btnAddUser.Text = "AddUser";
			this.btnAddUser.Click += new global::System.EventHandler(this.btnAddUser_Click);
			this.barUser.AntiAlias = true;
			this.barUser.Controls.Add(this.line2);
			this.barUser.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.barUser.DockSide = global::DevComponents.DotNetBar.eDockSide.Document;
			this.barUser.Font = new global::System.Drawing.Font("微软雅黑", 9f);
			this.barUser.IsMaximized = false;
			this.barUser.Items.AddRange(new global::DevComponents.DotNetBar.BaseItem[]
			{
				this.btnAddUser,
				this.btnModifyUser,
				this.btnDeleteUser,
				this.controlContainerItem1
			});
			this.barUser.Location = new global::System.Drawing.Point(0, 0);
			this.barUser.Name = "barUser";
			this.barUser.Size = new global::System.Drawing.Size(1048, 27);
			this.barUser.Stretch = true;
			this.barUser.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.barUser.TabIndex = 7;
			this.barUser.TabStop = false;
			this.barUser.Text = "bar3";
			this.line2.ForeColor = global::System.Drawing.SystemColors.ActiveCaption;
			this.line2.Location = new global::System.Drawing.Point(277, 3);
			this.line2.Name = "line2";
			this.line2.Size = new global::System.Drawing.Size(1, 20);
			this.line2.TabIndex = 33;
			this.line2.Text = "line2";
			this.line2.VerticalLine = true;
			this.btnModifyUser.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.btnModifyUser.Image = global::SQSClient.Properties.Resources.modify16;
			this.btnModifyUser.Name = "btnModifyUser";
			this.btnModifyUser.Text = "ModifyUser";
			this.btnModifyUser.Click += new global::System.EventHandler(this.btnModifyUser_Click);
			this.controlContainerItem1.AllowItemResize = false;
			this.controlContainerItem1.Control = this.line2;
			this.controlContainerItem1.MenuVisibility = global::DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
			this.controlContainerItem1.Name = "controlContainerItem1";
			this.panelEx2.CanvasColor = global::System.Drawing.SystemColors.Control;
			this.panelEx2.ColorSchemeStyle = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.panelEx2.Controls.Add(this.dgvData);
			this.panelEx2.Controls.Add(this.barUser);
			this.panelEx2.DisabledBackColor = global::System.Drawing.Color.Empty;
			this.panelEx2.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.panelEx2.Location = new global::System.Drawing.Point(203, 0);
			this.panelEx2.Name = "panelEx2";
			this.panelEx2.Size = new global::System.Drawing.Size(1048, 483);
			this.panelEx2.Style.Alignment = global::System.Drawing.StringAlignment.Center;
			this.panelEx2.Style.BackColor1.ColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
			this.panelEx2.Style.BackColor2.ColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
			this.panelEx2.Style.Border = global::DevComponents.DotNetBar.eBorderType.SingleLine;
			this.panelEx2.Style.BorderColor.ColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
			this.panelEx2.Style.ForeColor.ColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelText;
			this.panelEx2.Style.GradientAngle = 90;
			this.panelEx2.TabIndex = 26;
			this.panelEx2.Text = "panelEx2";
			this.dgvData.AllowUserToAddRows = false;
			this.dgvData.AllowUserToDeleteRows = false;
			this.dgvData.AutoSizeColumnsMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvData.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvData.Columns.AddRange(new global::System.Windows.Forms.DataGridViewColumn[]
			{
				this.C_ID,
				this.C_UserName,
				this.C_GroupZB,
				this.C_PhoneNum,
				this.C_Enable,
				this.C_Remark
			});
			dataGridViewCellStyle.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle.BackColor = global::System.Drawing.SystemColors.Window;
			dataGridViewCellStyle.Font = new global::System.Drawing.Font("宋体", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 134);
			dataGridViewCellStyle.ForeColor = global::System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle.SelectionBackColor = global::System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle.SelectionForeColor = global::System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle.WrapMode = global::System.Windows.Forms.DataGridViewTriState.False;
			this.dgvData.DefaultCellStyle = dataGridViewCellStyle;
			this.dgvData.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.dgvData.GridColor = global::System.Drawing.Color.FromArgb(208, 215, 229);
			this.dgvData.Location = new global::System.Drawing.Point(0, 27);
			this.dgvData.Name = "dgvData";
			this.dgvData.ReadOnly = true;
			this.dgvData.RowHeadersVisible = false;
			this.dgvData.RowTemplate.Height = 23;
			this.dgvData.Size = new global::System.Drawing.Size(1048, 456);
			this.dgvData.TabIndex = 8;
			this.dgvData.CellClick += new global::System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellClick);
			this.dgvData.CellDoubleClick += new global::System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellDoubleClick);
			this.C_ID.HeaderText = "ID";
			this.C_ID.Name = "C_ID";
			this.C_ID.ReadOnly = true;
			this.C_ID.Visible = false;
			this.C_UserName.HeaderText = "UserName";
			this.C_UserName.Name = "C_UserName";
			this.C_UserName.ReadOnly = true;
			this.C_GroupZB.HeaderText = "GroupZB";
			this.C_GroupZB.Name = "C_GroupZB";
			this.C_GroupZB.ReadOnly = true;
			this.C_PhoneNum.HeaderText = "PhoneNum";
			this.C_PhoneNum.Name = "C_PhoneNum";
			this.C_PhoneNum.ReadOnly = true;
			this.C_Enable.Checked = true;
			this.C_Enable.CheckState = global::System.Windows.Forms.CheckState.Indeterminate;
			this.C_Enable.CheckValue = "N";
			this.C_Enable.HeaderText = "Enable";
			this.C_Enable.Name = "C_Enable";
			this.C_Enable.ReadOnly = true;
			this.C_Enable.Resizable = global::System.Windows.Forms.DataGridViewTriState.True;
			this.C_Enable.SortMode = global::System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.C_Remark.HeaderText = "Remark";
			this.C_Remark.Name = "C_Remark";
			this.C_Remark.ReadOnly = true;
			this.expandableSplitter1.BackColor2 = global::System.Drawing.Color.FromArgb(101, 147, 207);
			this.expandableSplitter1.BackColor2SchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
			this.expandableSplitter1.BackColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
			this.expandableSplitter1.ExpandFillColor = global::System.Drawing.Color.FromArgb(101, 147, 207);
			this.expandableSplitter1.ExpandFillColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
			this.expandableSplitter1.ExpandLineColor = global::System.Drawing.Color.FromArgb(0, 0, 0);
			this.expandableSplitter1.ExpandLineColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.ItemText;
			this.expandableSplitter1.GripDarkColor = global::System.Drawing.Color.FromArgb(0, 0, 0);
			this.expandableSplitter1.GripDarkColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.ItemText;
			this.expandableSplitter1.GripLightColor = global::System.Drawing.Color.FromArgb(227, 239, 255);
			this.expandableSplitter1.GripLightColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.BarBackground;
			this.expandableSplitter1.HotBackColor = global::System.Drawing.Color.FromArgb(252, 151, 61);
			this.expandableSplitter1.HotBackColor2 = global::System.Drawing.Color.FromArgb(255, 184, 94);
			this.expandableSplitter1.HotBackColor2SchemePart = global::DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground2;
			this.expandableSplitter1.HotBackColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground;
			this.expandableSplitter1.HotExpandFillColor = global::System.Drawing.Color.FromArgb(101, 147, 207);
			this.expandableSplitter1.HotExpandFillColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
			this.expandableSplitter1.HotExpandLineColor = global::System.Drawing.Color.FromArgb(0, 0, 0);
			this.expandableSplitter1.HotExpandLineColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.ItemText;
			this.expandableSplitter1.HotGripDarkColor = global::System.Drawing.Color.FromArgb(101, 147, 207);
			this.expandableSplitter1.HotGripDarkColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
			this.expandableSplitter1.HotGripLightColor = global::System.Drawing.Color.FromArgb(227, 239, 255);
			this.expandableSplitter1.HotGripLightColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.BarBackground;
			this.expandableSplitter1.Location = new global::System.Drawing.Point(200, 0);
			this.expandableSplitter1.Name = "expandableSplitter1";
			this.expandableSplitter1.Size = new global::System.Drawing.Size(3, 483);
			this.expandableSplitter1.Style = global::DevComponents.DotNetBar.eSplitterStyle.Office2007;
			this.expandableSplitter1.TabIndex = 25;
			this.expandableSplitter1.TabStop = false;
			this.barGroup.AntiAlias = true;
			this.barGroup.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.barGroup.DockSide = global::DevComponents.DotNetBar.eDockSide.Left;
			this.barGroup.Font = new global::System.Drawing.Font("微软雅黑", 9f);
			this.barGroup.IsMaximized = false;
			this.barGroup.Items.AddRange(new global::DevComponents.DotNetBar.BaseItem[]
			{
				this.btnPermissionChoose,
				this.btnUpdatePermission
			});
			this.barGroup.Location = new global::System.Drawing.Point(0, 0);
			this.barGroup.Name = "barGroup";
			this.barGroup.Size = new global::System.Drawing.Size(200, 27);
			this.barGroup.Stretch = true;
			this.barGroup.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.barGroup.TabIndex = 3;
			this.barGroup.TabStop = false;
			this.barGroup.Text = "bar2";
			this.btnPermissionChoose.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.btnPermissionChoose.Image = global::SQSClient.Properties.Resources.edit16;
			this.btnPermissionChoose.Name = "btnPermissionChoose";
			this.btnPermissionChoose.Text = "PermissionChoose";
			this.btnPermissionChoose.Click += new global::System.EventHandler(this.btnPermissionChoose_Click);
			this.btnUpdatePermission.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.btnUpdatePermission.Image = global::SQSClient.Properties.Resources.update16;
			this.btnUpdatePermission.Name = "btnUpdatePermission";
			this.btnUpdatePermission.Text = "UpdatePermission";
			this.btnUpdatePermission.Click += new global::System.EventHandler(this.btnUpdatePermission_Click);
			this.panelEx1.CanvasColor = global::System.Drawing.SystemColors.Control;
			this.panelEx1.ColorSchemeStyle = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.panelEx1.Controls.Add(this.itemGroup);
			this.panelEx1.Controls.Add(this.barGroup);
			this.panelEx1.DisabledBackColor = global::System.Drawing.Color.Empty;
			this.panelEx1.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.panelEx1.Location = new global::System.Drawing.Point(0, 0);
			this.panelEx1.Name = "panelEx1";
			this.panelEx1.Size = new global::System.Drawing.Size(200, 483);
			this.panelEx1.Style.Alignment = global::System.Drawing.StringAlignment.Center;
			this.panelEx1.Style.BackColor1.ColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
			this.panelEx1.Style.BackColor2.ColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
			this.panelEx1.Style.Border = global::DevComponents.DotNetBar.eBorderType.SingleLine;
			this.panelEx1.Style.BorderColor.ColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
			this.panelEx1.Style.ForeColor.ColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelText;
			this.panelEx1.Style.GradientAngle = 90;
			this.panelEx1.TabIndex = 24;
			this.panelEx1.Text = "panelEx1";
			this.itemGroup.BackgroundStyle.Class = "ItemPanel";
			this.itemGroup.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.itemGroup.ContainerControlProcessDialogKey = true;
			this.itemGroup.ContextMenuStrip = this.contextMenuGroup;
			this.itemGroup.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.itemGroup.DragDropSupport = true;
			this.itemGroup.LayoutOrientation = global::DevComponents.DotNetBar.eOrientation.Vertical;
			this.itemGroup.Location = new global::System.Drawing.Point(0, 27);
			this.itemGroup.Name = "itemGroup";
			this.itemGroup.Size = new global::System.Drawing.Size(200, 456);
			this.itemGroup.TabIndex = 4;
			this.itemGroup.Text = "itemPanel1";
			this.itemGroup.Click += new global::System.EventHandler(this.itemGroup_Click);
			this.contextMenuGroup.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.toolAddGroup,
				this.toolModifyGroup,
				this.toolDeleteGroup
			});
			this.contextMenuGroup.Name = "contextMenuStrip1";
			this.contextMenuGroup.Size = new global::System.Drawing.Size(155, 70);
			this.toolAddGroup.Image = global::SQSClient.Properties.Resources.add16;
			this.toolAddGroup.Name = "toolAddGroup";
			this.toolAddGroup.Size = new global::System.Drawing.Size(154, 22);
			this.toolAddGroup.Text = "AddGroup";
			this.toolAddGroup.Click += new global::System.EventHandler(this.toolAddGroup_Click);
			this.toolModifyGroup.Image = global::SQSClient.Properties.Resources.modify16;
			this.toolModifyGroup.Name = "toolModifyGroup";
			this.toolModifyGroup.Size = new global::System.Drawing.Size(154, 22);
			this.toolModifyGroup.Text = "ModifyGroup";
			this.toolModifyGroup.Click += new global::System.EventHandler(this.toolModifyGroup_Click);
			this.toolDeleteGroup.Image = global::SQSClient.Properties.Resources.delete16;
			this.toolDeleteGroup.Name = "toolDeleteGroup";
			this.toolDeleteGroup.Size = new global::System.Drawing.Size(154, 22);
			this.toolDeleteGroup.Text = "DeleteGroup";
			this.toolDeleteGroup.Click += new global::System.EventHandler(this.toolDeleteGroup_Click);
			base.ClientSize = new global::System.Drawing.Size(1251, 483);
			base.Controls.Add(this.panelEx2);
			base.Controls.Add(this.expandableSplitter1);
			base.Controls.Add(this.panelEx1);
			base.Name = "frmPermission";
			this.Text = "Permission";
			base.Load += new global::System.EventHandler(this.frmPermission_Load);
			((global::System.ComponentModel.ISupportInitialize)this.barUser).EndInit();
			this.barUser.ResumeLayout(false);
			this.panelEx2.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.dgvData).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.barGroup).EndInit();
			this.panelEx1.ResumeLayout(false);
			this.contextMenuGroup.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x04000808 RID: 2056
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000809 RID: 2057
		private global::DevComponents.DotNetBar.ButtonItem btnDeleteUser;

		// Token: 0x0400080A RID: 2058
		private global::DevComponents.DotNetBar.ButtonItem btnAddUser;

		// Token: 0x0400080B RID: 2059
		private global::DevComponents.DotNetBar.Bar barUser;

		// Token: 0x0400080C RID: 2060
		private global::DevComponents.DotNetBar.ButtonItem btnModifyUser;

		// Token: 0x0400080D RID: 2061
		private global::DevComponents.DotNetBar.PanelEx panelEx2;

		// Token: 0x0400080E RID: 2062
		private global::DevComponents.DotNetBar.ExpandableSplitter expandableSplitter1;

		// Token: 0x0400080F RID: 2063
		private global::DevComponents.DotNetBar.Bar barGroup;

		// Token: 0x04000810 RID: 2064
		private global::DevComponents.DotNetBar.PanelEx panelEx1;

		// Token: 0x04000811 RID: 2065
		private global::System.Windows.Forms.ContextMenuStrip contextMenuGroup;

		// Token: 0x04000812 RID: 2066
		private global::DevComponents.DotNetBar.ItemPanel itemGroup;

		// Token: 0x04000813 RID: 2067
		private global::DevComponents.DotNetBar.Controls.DataGridViewX dgvData;

		// Token: 0x04000814 RID: 2068
		private global::System.Windows.Forms.ToolStripMenuItem toolAddGroup;

		// Token: 0x04000815 RID: 2069
		private global::System.Windows.Forms.ToolStripMenuItem toolModifyGroup;

		// Token: 0x04000816 RID: 2070
		private global::System.Windows.Forms.ToolStripMenuItem toolDeleteGroup;

		// Token: 0x04000817 RID: 2071
		private global::DevComponents.DotNetBar.ButtonItem btnPermissionChoose;

		// Token: 0x04000818 RID: 2072
		private global::DevComponents.DotNetBar.ButtonItem btnUpdatePermission;

		// Token: 0x04000819 RID: 2073
		private global::DevComponents.DotNetBar.Controls.Line line2;

		// Token: 0x0400081A RID: 2074
		private global::DevComponents.DotNetBar.ControlContainerItem controlContainerItem1;

		// Token: 0x0400081B RID: 2075
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_ID;

		// Token: 0x0400081C RID: 2076
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_UserName;

		// Token: 0x0400081D RID: 2077
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_GroupZB;

		// Token: 0x0400081E RID: 2078
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_PhoneNum;

		// Token: 0x0400081F RID: 2079
		private global::DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn C_Enable;

		// Token: 0x04000820 RID: 2080
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_Remark;
	}
}
