namespace SQSClient
{
	// Token: 0x02000058 RID: 88
	public partial class frmInvStep : global::SQSClient.BaseDialogForm
	{
		// Token: 0x0600044F RID: 1103 RVA: 0x0006C8DC File Offset: 0x0006AADC
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000450 RID: 1104 RVA: 0x0006C914 File Offset: 0x0006AB14
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::SQSClient.frmInvStep));
			this.panelEx1 = new global::DevComponents.DotNetBar.PanelEx();
			this.itemGroup = new global::DevComponents.DotNetBar.ItemPanel();
			this.contextMenuGroup = new global::System.Windows.Forms.ContextMenuStrip(this.components);
			this.toolAddGroup = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolModifyGroup = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolDeleteGroup = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolLine = new global::System.Windows.Forms.ToolStripSeparator();
			this.toolAdd = new global::System.Windows.Forms.ToolStripMenuItem();
			this.barGroup = new global::DevComponents.DotNetBar.Bar();
			this.btnAddGroup = new global::DevComponents.DotNetBar.ButtonItem();
			this.btnRefer = new global::DevComponents.DotNetBar.ButtonItem();
			this.btnImport = new global::DevComponents.DotNetBar.ButtonItem();
			this.expandableSplitter1 = new global::DevComponents.DotNetBar.ExpandableSplitter();
			this.controlContainerItem1 = new global::DevComponents.DotNetBar.ControlContainerItem();
			this.panelEx2 = new global::DevComponents.DotNetBar.PanelEx();
			this.dgvData = new global::DevComponents.DotNetBar.Controls.DataGridViewX();
			this.C_ID = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_InvModelId = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_StepCode = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_LastStep = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_AllowCondition = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_Creater = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_CreateTime = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_Modifier = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_ModifyTime = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_Enable = new global::System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.C_StepDesc = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bar = new global::DevComponents.DotNetBar.Bar();
			this.btnAdd = new global::DevComponents.DotNetBar.ButtonItem();
			this.btnModify = new global::DevComponents.DotNetBar.ButtonItem();
			this.btnDelete = new global::DevComponents.DotNetBar.ButtonItem();
			this.btnExport = new global::DevComponents.DotNetBar.ButtonItem();
			this.panelEx1.SuspendLayout();
			this.contextMenuGroup.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.barGroup).BeginInit();
			this.panelEx2.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvData).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.bar).BeginInit();
			base.SuspendLayout();
			this.panelEx1.CanvasColor = global::System.Drawing.SystemColors.Control;
			this.panelEx1.ColorSchemeStyle = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.panelEx1.Controls.Add(this.itemGroup);
			this.panelEx1.Controls.Add(this.barGroup);
			this.panelEx1.DisabledBackColor = global::System.Drawing.Color.Empty;
			this.panelEx1.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.panelEx1.Location = new global::System.Drawing.Point(0, 0);
			this.panelEx1.Name = "panelEx1";
			this.panelEx1.Size = new global::System.Drawing.Size(248, 495);
			this.panelEx1.Style.Alignment = global::System.Drawing.StringAlignment.Center;
			this.panelEx1.Style.BackColor1.ColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
			this.panelEx1.Style.BackColor2.ColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
			this.panelEx1.Style.Border = global::DevComponents.DotNetBar.eBorderType.SingleLine;
			this.panelEx1.Style.BorderColor.ColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
			this.panelEx1.Style.ForeColor.ColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelText;
			this.panelEx1.Style.GradientAngle = 90;
			this.panelEx1.TabIndex = 5;
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
			this.itemGroup.Size = new global::System.Drawing.Size(248, 468);
			this.itemGroup.TabIndex = 5;
			this.itemGroup.Text = "itemPanel1";
			this.contextMenuGroup.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.toolAddGroup,
				this.toolModifyGroup,
				this.toolDeleteGroup,
				this.toolLine,
				this.toolAdd
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
			this.toolAdd.Name = "toolAdd";
			this.toolAdd.Size = new global::System.Drawing.Size(154, 22);
			this.toolAdd.Text = "AddUnit";
			this.toolAdd.Click += new global::System.EventHandler(this.toolAddUnit_Click);
			this.barGroup.AntiAlias = true;
			this.barGroup.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.barGroup.DockSide = global::DevComponents.DotNetBar.eDockSide.Left;
			this.barGroup.Font = new global::System.Drawing.Font("微软雅黑", 9f);
			this.barGroup.IsMaximized = false;
			this.barGroup.Items.AddRange(new global::DevComponents.DotNetBar.BaseItem[]
			{
				this.btnAddGroup,
				this.btnRefer,
				this.btnImport
			});
			this.barGroup.Location = new global::System.Drawing.Point(0, 0);
			this.barGroup.Name = "barGroup";
			this.barGroup.Size = new global::System.Drawing.Size(248, 27);
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
			this.btnRefer.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.btnRefer.Image = global::SQSClient.Properties.Resources.adjust16;
			this.btnRefer.Name = "btnRefer";
			this.btnRefer.Text = "Refer";
			this.btnRefer.Click += new global::System.EventHandler(this.btnRefer_Click);
			this.btnImport.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.btnImport.Image = global::SQSClient.Properties.Resources.modify16;
			this.btnImport.ItemAlignment = global::DevComponents.DotNetBar.eItemAlignment.Far;
			this.btnImport.Name = "btnImport";
			this.btnImport.Text = "Import";
			this.btnImport.Visible = false;
			this.btnImport.Click += new global::System.EventHandler(this.btnImport_Click);
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
			this.expandableSplitter1.Location = new global::System.Drawing.Point(248, 0);
			this.expandableSplitter1.Name = "expandableSplitter1";
			this.expandableSplitter1.Size = new global::System.Drawing.Size(3, 495);
			this.expandableSplitter1.Style = global::DevComponents.DotNetBar.eSplitterStyle.Office2007;
			this.expandableSplitter1.TabIndex = 26;
			this.expandableSplitter1.TabStop = false;
			this.controlContainerItem1.AllowItemResize = false;
			this.controlContainerItem1.MenuVisibility = global::DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
			this.controlContainerItem1.Name = "controlContainerItem1";
			this.panelEx2.CanvasColor = global::System.Drawing.SystemColors.Control;
			this.panelEx2.ColorSchemeStyle = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.panelEx2.Controls.Add(this.dgvData);
			this.panelEx2.Controls.Add(this.bar);
			this.panelEx2.DisabledBackColor = global::System.Drawing.Color.Empty;
			this.panelEx2.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.panelEx2.Location = new global::System.Drawing.Point(251, 0);
			this.panelEx2.Name = "panelEx2";
			this.panelEx2.Size = new global::System.Drawing.Size(1106, 495);
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
			this.dgvData.AutoSizeRowsMode = global::System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			dataGridViewCellStyle.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle.BackColor = global::System.Drawing.SystemColors.Control;
			dataGridViewCellStyle.Font = new global::System.Drawing.Font("宋体", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 134);
			dataGridViewCellStyle.ForeColor = global::System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle.SelectionBackColor = global::System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle.SelectionForeColor = global::System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle.WrapMode = global::System.Windows.Forms.DataGridViewTriState.True;
			this.dgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
			this.dgvData.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dgvData.Columns.AddRange(new global::System.Windows.Forms.DataGridViewColumn[]
			{
				this.C_ID,
				this.C_InvModelId,
				this.C_StepCode,
				this.C_LastStep,
				this.C_AllowCondition,
				this.C_Creater,
				this.C_CreateTime,
				this.C_Modifier,
				this.C_ModifyTime,
				this.C_Enable,
				this.C_StepDesc
			});
			dataGridViewCellStyle2.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = global::System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new global::System.Drawing.Font("宋体", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 134);
			dataGridViewCellStyle2.ForeColor = global::System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = global::System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = global::System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.WrapMode = global::System.Windows.Forms.DataGridViewTriState.False;
			this.dgvData.DefaultCellStyle = dataGridViewCellStyle2;
			this.dgvData.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.dgvData.EnableHeadersVisualStyles = false;
			this.dgvData.GridColor = global::System.Drawing.Color.FromArgb(208, 215, 229);
			this.dgvData.Location = new global::System.Drawing.Point(0, 26);
			this.dgvData.Name = "dgvData";
			this.dgvData.ReadOnly = true;
			dataGridViewCellStyle3.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = global::System.Drawing.SystemColors.Control;
			dataGridViewCellStyle3.Font = new global::System.Drawing.Font("宋体", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 134);
			dataGridViewCellStyle3.ForeColor = global::System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = global::System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = global::System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.WrapMode = global::System.Windows.Forms.DataGridViewTriState.True;
			this.dgvData.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.dgvData.RowHeadersVisible = false;
			this.dgvData.RowTemplate.Height = 27;
			this.dgvData.Size = new global::System.Drawing.Size(1106, 469);
			this.dgvData.TabIndex = 2;
			this.dgvData.CellClick += new global::System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUnit_CellClick);
			this.dgvData.CellDoubleClick += new global::System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUnit_CellDoubleClick);
			this.C_ID.HeaderText = "ID";
			this.C_ID.Name = "C_ID";
			this.C_ID.ReadOnly = true;
			this.C_ID.Visible = false;
			this.C_InvModelId.FillWeight = 19.53414f;
			this.C_InvModelId.HeaderText = "Process";
			this.C_InvModelId.Name = "C_InvModelId";
			this.C_InvModelId.ReadOnly = true;
			this.C_StepCode.FillWeight = 13.94709f;
			this.C_StepCode.HeaderText = "ThisStep";
			this.C_StepCode.Name = "C_StepCode";
			this.C_StepCode.ReadOnly = true;
			this.C_LastStep.FillWeight = 13.94709f;
			this.C_LastStep.HeaderText = "LastStep";
			this.C_LastStep.Name = "C_LastStep";
			this.C_LastStep.ReadOnly = true;
			this.C_AllowCondition.FillWeight = 17.19026f;
			this.C_AllowCondition.HeaderText = "AllowCondition";
			this.C_AllowCondition.Name = "C_AllowCondition";
			this.C_AllowCondition.ReadOnly = true;
			this.C_Creater.FillWeight = 17.19026f;
			this.C_Creater.HeaderText = "SrmCreater";
			this.C_Creater.Name = "C_Creater";
			this.C_Creater.ReadOnly = true;
			this.C_CreateTime.FillWeight = 13.94709f;
			this.C_CreateTime.HeaderText = "SrmCreateTime";
			this.C_CreateTime.Name = "C_CreateTime";
			this.C_CreateTime.ReadOnly = true;
			this.C_Modifier.FillWeight = 13.94709f;
			this.C_Modifier.HeaderText = "SrmModifier";
			this.C_Modifier.Name = "C_Modifier";
			this.C_Modifier.ReadOnly = true;
			this.C_ModifyTime.FillWeight = 17.19026f;
			this.C_ModifyTime.HeaderText = "SrmModifyTime";
			this.C_ModifyTime.Name = "C_ModifyTime";
			this.C_ModifyTime.ReadOnly = true;
			this.C_Enable.FillWeight = 17.19026f;
			this.C_Enable.HeaderText = "Enable";
			this.C_Enable.Name = "C_Enable";
			this.C_Enable.ReadOnly = true;
			this.C_Enable.Resizable = global::System.Windows.Forms.DataGridViewTriState.True;
			this.C_Enable.SortMode = global::System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.C_StepDesc.FillWeight = 17.19026f;
			this.C_StepDesc.HeaderText = "Memo";
			this.C_StepDesc.Name = "C_StepDesc";
			this.C_StepDesc.ReadOnly = true;
			this.bar.AntiAlias = true;
			this.bar.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.bar.DockSide = global::DevComponents.DotNetBar.eDockSide.Document;
			this.bar.Font = new global::System.Drawing.Font("Microsoft YaHei UI", 9f);
			this.bar.IsMaximized = false;
			this.bar.Items.AddRange(new global::DevComponents.DotNetBar.BaseItem[]
			{
				this.btnAdd,
				this.btnModify,
				this.btnDelete,
				this.btnExport
			});
			this.bar.Location = new global::System.Drawing.Point(0, 0);
			this.bar.Name = "bar";
			this.bar.Size = new global::System.Drawing.Size(1106, 26);
			this.bar.Stretch = true;
			this.bar.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.bar.TabIndex = 1;
			this.bar.TabStop = false;
			this.bar.Text = "bar1";
			this.btnAdd.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.btnAdd.Image = global::SQSClient.Properties.Resources.add16;
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Text = "Add";
			this.btnAdd.Click += new global::System.EventHandler(this.btnAdd_Click);
			this.btnModify.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.btnModify.Image = global::SQSClient.Properties.Resources.modify16;
			this.btnModify.Name = "btnModify";
			this.btnModify.Text = "Modify";
			this.btnModify.Click += new global::System.EventHandler(this.btnModify_Click);
			this.btnDelete.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.btnDelete.Image = global::SQSClient.Properties.Resources.delete16;
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Text = "Delete";
			this.btnDelete.Click += new global::System.EventHandler(this.btnDelete_Click);
			this.btnExport.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.btnExport.Image = global::SQSClient.Properties.Resources.print16;
			this.btnExport.Name = "btnExport";
			this.btnExport.Text = "Export";
			this.btnExport.Click += new global::System.EventHandler(this.btnExport_Click);
			base.ClientSize = new global::System.Drawing.Size(1357, 495);
			base.Controls.Add(this.panelEx2);
			base.Controls.Add(this.expandableSplitter1);
			base.Controls.Add(this.panelEx1);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "frmInvStep";
			this.Text = "frmInvStep";
			base.Load += new global::System.EventHandler(this.frmUnit_Load);
			this.panelEx1.ResumeLayout(false);
			this.contextMenuGroup.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.barGroup).EndInit();
			this.panelEx2.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.dgvData).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.bar).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000767 RID: 1895
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000768 RID: 1896
		private global::DevComponents.DotNetBar.PanelEx panelEx1;

		// Token: 0x04000769 RID: 1897
		private global::DevComponents.DotNetBar.Bar barGroup;

		// Token: 0x0400076A RID: 1898
		private global::DevComponents.DotNetBar.ButtonItem btnAddGroup;

		// Token: 0x0400076B RID: 1899
		private global::DevComponents.DotNetBar.ExpandableSplitter expandableSplitter1;

		// Token: 0x0400076C RID: 1900
		private global::DevComponents.DotNetBar.ControlContainerItem controlContainerItem1;

		// Token: 0x0400076D RID: 1901
		private global::DevComponents.DotNetBar.PanelEx panelEx2;

		// Token: 0x0400076E RID: 1902
		private global::System.Windows.Forms.ContextMenuStrip contextMenuGroup;

		// Token: 0x0400076F RID: 1903
		private global::System.Windows.Forms.ToolStripMenuItem toolAddGroup;

		// Token: 0x04000770 RID: 1904
		private global::System.Windows.Forms.ToolStripMenuItem toolModifyGroup;

		// Token: 0x04000771 RID: 1905
		private global::System.Windows.Forms.ToolStripMenuItem toolDeleteGroup;

		// Token: 0x04000772 RID: 1906
		private global::System.Windows.Forms.ToolStripSeparator toolLine;

		// Token: 0x04000773 RID: 1907
		private global::System.Windows.Forms.ToolStripMenuItem toolAdd;

		// Token: 0x04000774 RID: 1908
		private global::DevComponents.DotNetBar.Bar bar;

		// Token: 0x04000775 RID: 1909
		private global::DevComponents.DotNetBar.ButtonItem btnAdd;

		// Token: 0x04000776 RID: 1910
		private global::DevComponents.DotNetBar.ButtonItem btnModify;

		// Token: 0x04000777 RID: 1911
		private global::DevComponents.DotNetBar.ButtonItem btnDelete;

		// Token: 0x04000778 RID: 1912
		private global::DevComponents.DotNetBar.ButtonItem btnExport;

		// Token: 0x04000779 RID: 1913
		private global::DevComponents.DotNetBar.Controls.DataGridViewX dgvData;

		// Token: 0x0400077A RID: 1914
		private global::DevComponents.DotNetBar.ItemPanel itemGroup;

		// Token: 0x0400077B RID: 1915
		private global::DevComponents.DotNetBar.ButtonItem btnImport;

		// Token: 0x0400077C RID: 1916
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_ID;

		// Token: 0x0400077D RID: 1917
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_InvModelId;

		// Token: 0x0400077E RID: 1918
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_StepCode;

		// Token: 0x0400077F RID: 1919
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_LastStep;

		// Token: 0x04000780 RID: 1920
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_AllowCondition;

		// Token: 0x04000781 RID: 1921
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_Creater;

		// Token: 0x04000782 RID: 1922
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_CreateTime;

		// Token: 0x04000783 RID: 1923
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_Modifier;

		// Token: 0x04000784 RID: 1924
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_ModifyTime;

		// Token: 0x04000785 RID: 1925
		private global::System.Windows.Forms.DataGridViewCheckBoxColumn C_Enable;

		// Token: 0x04000786 RID: 1926
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_StepDesc;

		// Token: 0x04000787 RID: 1927
		private global::DevComponents.DotNetBar.ButtonItem btnRefer;
	}
}
