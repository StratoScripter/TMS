namespace SQSClient
{
	// Token: 0x02000086 RID: 134
	public partial class frmUnit : global::SQSClient.BaseDialogForm
	{
		// Token: 0x06000756 RID: 1878 RVA: 0x000B4BC4 File Offset: 0x000B2DC4
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000757 RID: 1879 RVA: 0x000B4BFC File Offset: 0x000B2DFC
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::SQSClient.frmUnit));
			this.panelEx1 = new global::DevComponents.DotNetBar.PanelEx();
			this.treeGroup = new global::DevComponents.AdvTree.AdvTree();
			this.contextMenuGroup = new global::System.Windows.Forms.ContextMenuStrip(this.components);
			this.toolAddGroup = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolModifyGroup = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolDeleteGroup = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolLine = new global::System.Windows.Forms.ToolStripSeparator();
			this.toolAddUnit = new global::System.Windows.Forms.ToolStripMenuItem();
			this.nodeConnector1 = new global::DevComponents.AdvTree.NodeConnector();
			this.elementStyle1 = new global::DevComponents.DotNetBar.ElementStyle();
			this.barGroup = new global::DevComponents.DotNetBar.Bar();
			this.btnAddGroup = new global::DevComponents.DotNetBar.ButtonItem();
			this.expandableSplitter1 = new global::DevComponents.DotNetBar.ExpandableSplitter();
			this.controlContainerItem1 = new global::DevComponents.DotNetBar.ControlContainerItem();
			this.labUnit = new global::DevComponents.DotNetBar.LabelItem();
			this.txtName = new global::DevComponents.DotNetBar.TextBoxItem();
			this.btnSearch = new global::DevComponents.DotNetBar.ButtonItem();
			this.panelEx2 = new global::DevComponents.DotNetBar.PanelEx();
			this.dgvData = new global::DevComponents.DotNetBar.Controls.DataGridViewX();
			this.bar = new global::DevComponents.DotNetBar.Bar();
			this.line2 = new global::DevComponents.DotNetBar.Controls.Line();
			this.btnAddUnit = new global::DevComponents.DotNetBar.ButtonItem();
			this.btnModifyUnit = new global::DevComponents.DotNetBar.ButtonItem();
			this.btnDeleteUnit = new global::DevComponents.DotNetBar.ButtonItem();
			this.controlContainerItem2 = new global::DevComponents.DotNetBar.ControlContainerItem();
			this.C_Id = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_UnitName = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_Code = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column1 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_BusinessType = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_UnitIndex = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_Device = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_Branch = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_CurProduct = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_CurDanWei = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_MutexConfig = new global::System.Windows.Forms.DataGridViewImageColumn();
			this.C_CurProductCodeList = new global::System.Windows.Forms.DataGridViewImageColumn();
			this.C_State = new global::System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.C_Remark = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panelEx1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.treeGroup).BeginInit();
			this.contextMenuGroup.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.barGroup).BeginInit();
			this.panelEx2.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvData).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.bar).BeginInit();
			this.bar.SuspendLayout();
			base.SuspendLayout();
			this.panelEx1.CanvasColor = global::System.Drawing.SystemColors.Control;
			this.panelEx1.ColorSchemeStyle = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.panelEx1.Controls.Add(this.treeGroup);
			this.panelEx1.Controls.Add(this.barGroup);
			this.panelEx1.DisabledBackColor = global::System.Drawing.Color.Empty;
			this.panelEx1.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.panelEx1.Location = new global::System.Drawing.Point(0, 0);
			this.panelEx1.Name = "panelEx1";
			this.panelEx1.Size = new global::System.Drawing.Size(200, 372);
			this.panelEx1.Style.Alignment = global::System.Drawing.StringAlignment.Center;
			this.panelEx1.Style.BackColor1.ColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
			this.panelEx1.Style.BackColor2.ColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
			this.panelEx1.Style.Border = global::DevComponents.DotNetBar.eBorderType.SingleLine;
			this.panelEx1.Style.BorderColor.ColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
			this.panelEx1.Style.ForeColor.ColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelText;
			this.panelEx1.Style.GradientAngle = 90;
			this.panelEx1.TabIndex = 5;
			this.panelEx1.Text = "panelEx1";
			this.treeGroup.AccessibleRole = global::System.Windows.Forms.AccessibleRole.Outline;
			this.treeGroup.BackColor = global::System.Drawing.SystemColors.Window;
			this.treeGroup.BackgroundStyle.Class = "TreeBorderKey";
			this.treeGroup.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.treeGroup.ContextMenuStrip = this.contextMenuGroup;
			this.treeGroup.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.treeGroup.Location = new global::System.Drawing.Point(0, 27);
			this.treeGroup.Name = "treeGroup";
			this.treeGroup.NodesConnector = this.nodeConnector1;
			this.treeGroup.NodeStyle = this.elementStyle1;
			this.treeGroup.PathSeparator = ";";
			this.treeGroup.Size = new global::System.Drawing.Size(200, 345);
			this.treeGroup.Styles.Add(this.elementStyle1);
			this.treeGroup.TabIndex = 5;
			this.treeGroup.Text = "advTree1";
			this.treeGroup.AfterNodeDrop += new global::DevComponents.AdvTree.TreeDragDropEventHandler(this.treeGroup_AfterNodeDrop);
			this.treeGroup.NodeMouseDown += new global::DevComponents.AdvTree.TreeNodeMouseEventHandler(this.treeGroup_NodeMouseDown);
			this.treeGroup.NodeClick += new global::DevComponents.AdvTree.TreeNodeMouseEventHandler(this.treeGroup_NodeClick);
			this.treeGroup.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.treeGroup_MouseDown);
			this.contextMenuGroup.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.toolAddGroup,
				this.toolModifyGroup,
				this.toolDeleteGroup,
				this.toolLine,
				this.toolAddUnit
			});
			this.contextMenuGroup.Name = "contextMenuStrip1";
			this.contextMenuGroup.Size = new global::System.Drawing.Size(155, 98);
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
			this.toolLine.Name = "toolLine";
			this.toolLine.Size = new global::System.Drawing.Size(151, 6);
			this.toolAddUnit.Name = "toolAddUnit";
			this.toolAddUnit.Size = new global::System.Drawing.Size(154, 22);
			this.toolAddUnit.Text = "AddUnit";
			this.toolAddUnit.Click += new global::System.EventHandler(this.toolAddUnit_Click);
			this.nodeConnector1.LineColor = global::System.Drawing.SystemColors.ControlText;
			this.elementStyle1.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.elementStyle1.Name = "elementStyle1";
			this.elementStyle1.TextColor = global::System.Drawing.SystemColors.ControlText;
			this.barGroup.AntiAlias = true;
			this.barGroup.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.barGroup.DockSide = global::DevComponents.DotNetBar.eDockSide.Left;
			this.barGroup.Font = new global::System.Drawing.Font("微软雅黑", 9f);
			this.barGroup.IsMaximized = false;
			this.barGroup.Items.AddRange(new global::DevComponents.DotNetBar.BaseItem[]
			{
				this.btnAddGroup
			});
			this.barGroup.Location = new global::System.Drawing.Point(0, 0);
			this.barGroup.Name = "barGroup";
			this.barGroup.Size = new global::System.Drawing.Size(200, 27);
			this.barGroup.Stretch = true;
			this.barGroup.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.barGroup.TabIndex = 4;
			this.barGroup.TabStop = false;
			this.barGroup.Text = "bar2";
			this.btnAddGroup.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.btnAddGroup.Image = global::SQSClient.Properties.Resources.add16;
			this.btnAddGroup.Name = "btnAddGroup";
			this.btnAddGroup.Text = "AddGroup";
			this.btnAddGroup.Click += new global::System.EventHandler(this.btnAddGroup_Click);
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
			this.expandableSplitter1.Size = new global::System.Drawing.Size(3, 372);
			this.expandableSplitter1.Style = global::DevComponents.DotNetBar.eSplitterStyle.Office2007;
			this.expandableSplitter1.TabIndex = 26;
			this.expandableSplitter1.TabStop = false;
			this.controlContainerItem1.AllowItemResize = false;
			this.controlContainerItem1.MenuVisibility = global::DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
			this.controlContainerItem1.Name = "controlContainerItem1";
			this.labUnit.Name = "labUnit";
			this.labUnit.Text = "UnitName";
			this.txtName.MaxLength = 50;
			this.txtName.Name = "txtName";
			this.txtName.TextBoxWidth = 120;
			this.txtName.WatermarkColor = global::System.Drawing.SystemColors.GrayText;
			this.txtName.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
			this.btnSearch.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.btnSearch.Image = global::SQSClient.Properties.Resources.search16;
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Text = "Search";
			this.btnSearch.Click += new global::System.EventHandler(this.btnSearch_Click);
			this.panelEx2.CanvasColor = global::System.Drawing.SystemColors.Control;
			this.panelEx2.ColorSchemeStyle = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.panelEx2.Controls.Add(this.dgvData);
			this.panelEx2.Controls.Add(this.bar);
			this.panelEx2.DisabledBackColor = global::System.Drawing.Color.Empty;
			this.panelEx2.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.panelEx2.Location = new global::System.Drawing.Point(203, 0);
			this.panelEx2.Name = "panelEx2";
			this.panelEx2.Size = new global::System.Drawing.Size(751, 372);
			this.panelEx2.Style.Alignment = global::System.Drawing.StringAlignment.Center;
			this.panelEx2.Style.BackColor1.ColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
			this.panelEx2.Style.BackColor2.ColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
			this.panelEx2.Style.Border = global::DevComponents.DotNetBar.eBorderType.SingleLine;
			this.panelEx2.Style.BorderColor.ColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
			this.panelEx2.Style.ForeColor.ColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelText;
			this.panelEx2.Style.GradientAngle = 90;
			this.panelEx2.TabIndex = 30;
			this.panelEx2.Text = "panelEx2";
			this.dgvData.AllowUserToAddRows = false;
			this.dgvData.AllowUserToDeleteRows = false;
			this.dgvData.AutoSizeColumnsMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvData.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvData.Columns.AddRange(new global::System.Windows.Forms.DataGridViewColumn[]
			{
				this.C_Id,
				this.C_UnitName,
				this.C_Code,
				this.Column1,
				this.C_BusinessType,
				this.C_UnitIndex,
				this.C_Device,
				this.C_Branch,
				this.C_CurProduct,
				this.C_CurDanWei,
				this.C_MutexConfig,
				this.C_CurProductCodeList,
				this.C_State,
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
			this.dgvData.Size = new global::System.Drawing.Size(751, 345);
			this.dgvData.TabIndex = 7;
			this.dgvData.CellClick += new global::System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUnit_CellClick);
			this.dgvData.CellContentClick += new global::System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellContentClick);
			this.dgvData.CellDoubleClick += new global::System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUnit_CellDoubleClick);
			this.bar.AntiAlias = true;
			this.bar.Controls.Add(this.line2);
			this.bar.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.bar.DockSide = global::DevComponents.DotNetBar.eDockSide.Document;
			this.bar.Font = new global::System.Drawing.Font("微软雅黑", 9f);
			this.bar.IsMaximized = false;
			this.bar.Items.AddRange(new global::DevComponents.DotNetBar.BaseItem[]
			{
				this.btnAddUnit,
				this.btnModifyUnit,
				this.btnDeleteUnit,
				this.controlContainerItem2,
				this.labUnit,
				this.txtName,
				this.btnSearch
			});
			this.bar.Location = new global::System.Drawing.Point(0, 0);
			this.bar.Name = "bar";
			this.bar.Size = new global::System.Drawing.Size(751, 27);
			this.bar.Stretch = true;
			this.bar.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.bar.TabIndex = 6;
			this.bar.TabStop = false;
			this.bar.Text = "bar1";
			this.line2.ForeColor = global::System.Drawing.SystemColors.ActiveCaption;
			this.line2.Location = new global::System.Drawing.Point(271, 3);
			this.line2.Name = "line2";
			this.line2.Size = new global::System.Drawing.Size(1, 20);
			this.line2.TabIndex = 17;
			this.line2.Text = "line2";
			this.line2.VerticalLine = true;
			this.btnAddUnit.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.btnAddUnit.Image = global::SQSClient.Properties.Resources.add16;
			this.btnAddUnit.Name = "btnAddUnit";
			this.btnAddUnit.Text = "AddUnit";
			this.btnAddUnit.Click += new global::System.EventHandler(this.btnAdd_Click);
			this.btnModifyUnit.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.btnModifyUnit.Image = global::SQSClient.Properties.Resources.modify16;
			this.btnModifyUnit.Name = "btnModifyUnit";
			this.btnModifyUnit.Text = "ModifyUnit";
			this.btnModifyUnit.Click += new global::System.EventHandler(this.btnModify_Click);
			this.btnDeleteUnit.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.btnDeleteUnit.Image = global::SQSClient.Properties.Resources.delete16;
			this.btnDeleteUnit.Name = "btnDeleteUnit";
			this.btnDeleteUnit.Text = "DeleteUnit";
			this.btnDeleteUnit.Click += new global::System.EventHandler(this.btnDelete_Click);
			this.controlContainerItem2.AllowItemResize = false;
			this.controlContainerItem2.Control = this.line2;
			this.controlContainerItem2.MenuVisibility = global::DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
			this.controlContainerItem2.Name = "controlContainerItem2";
			this.C_Id.HeaderText = "ID";
			this.C_Id.Name = "C_Id";
			this.C_Id.ReadOnly = true;
			this.C_Id.Visible = false;
			this.C_UnitName.HeaderText = "UnitName";
			this.C_UnitName.Name = "C_UnitName";
			this.C_UnitName.ReadOnly = true;
			this.C_Code.HeaderText = "UnitCode";
			this.C_Code.Name = "C_Code";
			this.C_Code.ReadOnly = true;
			this.Column1.HeaderText = "GroupZB";
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			this.C_BusinessType.HeaderText = "BusinessType";
			this.C_BusinessType.Name = "C_BusinessType";
			this.C_BusinessType.ReadOnly = true;
			this.C_UnitIndex.HeaderText = "UnitIndex";
			this.C_UnitIndex.Name = "C_UnitIndex";
			this.C_UnitIndex.ReadOnly = true;
			this.C_Device.HeaderText = "Device";
			this.C_Device.Name = "C_Device";
			this.C_Device.ReadOnly = true;
			this.C_Branch.HeaderText = "Branch";
			this.C_Branch.Name = "C_Branch";
			this.C_Branch.ReadOnly = true;
			this.C_CurProduct.HeaderText = "CurProduct";
			this.C_CurProduct.Name = "C_CurProduct";
			this.C_CurProduct.ReadOnly = true;
			this.C_CurDanWei.HeaderText = "CurDanWei";
			this.C_CurDanWei.Name = "C_CurDanWei";
			this.C_CurDanWei.ReadOnly = true;
			this.C_MutexConfig.HeaderText = "MutexConfig";
			this.C_MutexConfig.Name = "C_MutexConfig";
			this.C_MutexConfig.ReadOnly = true;
			this.C_CurProductCodeList.HeaderText = "CurProductCodeList";
			this.C_CurProductCodeList.Name = "C_CurProductCodeList";
			this.C_CurProductCodeList.ReadOnly = true;
			this.C_CurProductCodeList.Resizable = global::System.Windows.Forms.DataGridViewTriState.True;
			this.C_State.HeaderText = "Enable";
			this.C_State.Name = "C_State";
			this.C_State.ReadOnly = true;
			this.C_Remark.HeaderText = "Remark";
			this.C_Remark.Name = "C_Remark";
			this.C_Remark.ReadOnly = true;
			base.ClientSize = new global::System.Drawing.Size(954, 372);
			base.Controls.Add(this.panelEx2);
			base.Controls.Add(this.expandableSplitter1);
			base.Controls.Add(this.panelEx1);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "frmUnit";
			this.Text = "Unit";
			base.Load += new global::System.EventHandler(this.frmUnit_Load);
			this.panelEx1.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.treeGroup).EndInit();
			this.contextMenuGroup.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.barGroup).EndInit();
			this.panelEx2.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.dgvData).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.bar).EndInit();
			this.bar.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x04000C5C RID: 3164
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000C5D RID: 3165
		private global::DevComponents.DotNetBar.PanelEx panelEx1;

		// Token: 0x04000C5E RID: 3166
		private global::DevComponents.DotNetBar.Bar barGroup;

		// Token: 0x04000C5F RID: 3167
		private global::DevComponents.DotNetBar.ButtonItem btnAddGroup;

		// Token: 0x04000C60 RID: 3168
		private global::DevComponents.DotNetBar.ExpandableSplitter expandableSplitter1;

		// Token: 0x04000C61 RID: 3169
		private global::DevComponents.DotNetBar.ControlContainerItem controlContainerItem1;

		// Token: 0x04000C62 RID: 3170
		private global::DevComponents.DotNetBar.LabelItem labUnit;

		// Token: 0x04000C63 RID: 3171
		private global::DevComponents.DotNetBar.TextBoxItem txtName;

		// Token: 0x04000C64 RID: 3172
		private global::DevComponents.DotNetBar.ButtonItem btnSearch;

		// Token: 0x04000C65 RID: 3173
		private global::DevComponents.DotNetBar.PanelEx panelEx2;

		// Token: 0x04000C66 RID: 3174
		private global::DevComponents.DotNetBar.Controls.DataGridViewX dgvData;

		// Token: 0x04000C67 RID: 3175
		private global::DevComponents.DotNetBar.Bar bar;

		// Token: 0x04000C68 RID: 3176
		private global::DevComponents.DotNetBar.Controls.Line line2;

		// Token: 0x04000C69 RID: 3177
		private global::DevComponents.DotNetBar.ButtonItem btnAddUnit;

		// Token: 0x04000C6A RID: 3178
		private global::DevComponents.DotNetBar.ButtonItem btnModifyUnit;

		// Token: 0x04000C6B RID: 3179
		private global::DevComponents.DotNetBar.ButtonItem btnDeleteUnit;

		// Token: 0x04000C6C RID: 3180
		private global::System.Windows.Forms.ContextMenuStrip contextMenuGroup;

		// Token: 0x04000C6D RID: 3181
		private global::System.Windows.Forms.ToolStripMenuItem toolAddGroup;

		// Token: 0x04000C6E RID: 3182
		private global::System.Windows.Forms.ToolStripMenuItem toolModifyGroup;

		// Token: 0x04000C6F RID: 3183
		private global::System.Windows.Forms.ToolStripMenuItem toolDeleteGroup;

		// Token: 0x04000C70 RID: 3184
		private global::DevComponents.AdvTree.AdvTree treeGroup;

		// Token: 0x04000C71 RID: 3185
		private global::DevComponents.AdvTree.NodeConnector nodeConnector1;

		// Token: 0x04000C72 RID: 3186
		private global::DevComponents.DotNetBar.ElementStyle elementStyle1;

		// Token: 0x04000C73 RID: 3187
		private global::System.Windows.Forms.ToolStripSeparator toolLine;

		// Token: 0x04000C74 RID: 3188
		private global::System.Windows.Forms.ToolStripMenuItem toolAddUnit;

		// Token: 0x04000C75 RID: 3189
		private global::DevComponents.DotNetBar.ControlContainerItem controlContainerItem2;

		// Token: 0x04000C76 RID: 3190
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_Id;

		// Token: 0x04000C77 RID: 3191
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_UnitName;

		// Token: 0x04000C78 RID: 3192
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_Code;

		// Token: 0x04000C79 RID: 3193
		private global::System.Windows.Forms.DataGridViewTextBoxColumn Column1;

		// Token: 0x04000C7A RID: 3194
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_BusinessType;

		// Token: 0x04000C7B RID: 3195
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_UnitIndex;

		// Token: 0x04000C7C RID: 3196
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_Device;

		// Token: 0x04000C7D RID: 3197
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_Branch;

		// Token: 0x04000C7E RID: 3198
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_CurProduct;

		// Token: 0x04000C7F RID: 3199
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_CurDanWei;

		// Token: 0x04000C80 RID: 3200
		private global::System.Windows.Forms.DataGridViewImageColumn C_MutexConfig;

		// Token: 0x04000C81 RID: 3201
		private global::System.Windows.Forms.DataGridViewImageColumn C_CurProductCodeList;

		// Token: 0x04000C82 RID: 3202
		private global::System.Windows.Forms.DataGridViewCheckBoxColumn C_State;

		// Token: 0x04000C83 RID: 3203
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_Remark;
	}
}
