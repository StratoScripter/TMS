namespace SQSClient
{
	// Token: 0x02000029 RID: 41
	public partial class frmSpecialStepClass : global::SQSClient.BaseDialogForm
	{
		// Token: 0x0600020E RID: 526 RVA: 0x0003BBAC File Offset: 0x00039DAC
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600020F RID: 527 RVA: 0x0003BBE4 File Offset: 0x00039DE4
		private void InitializeComponent()
		{
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::SQSClient.frmSpecialStepClass));
			this.panelEx1 = new global::DevComponents.DotNetBar.PanelEx();
			this.itemGroup = new global::DevComponents.DotNetBar.ItemPanel();
			this.barGroup = new global::DevComponents.DotNetBar.Bar();
			this.btnImport = new global::DevComponents.DotNetBar.ButtonItem();
			this.controlContainerItem1 = new global::DevComponents.DotNetBar.ControlContainerItem();
			this.panelEx2 = new global::DevComponents.DotNetBar.PanelEx();
			this.dgvData = new global::DevComponents.DotNetBar.Controls.DataGridViewX();
			this.C_ID = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_SkipEnable = new global::System.Windows.Forms.DataGridViewCheckBoxColumn();
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
			this.panelEx3 = new global::DevComponents.DotNetBar.PanelEx();
			this.itemClass = new global::DevComponents.DotNetBar.ItemPanel();
			this.bar1 = new global::DevComponents.DotNetBar.Bar();
			this.btnAddSpecailStepClass = new global::DevComponents.DotNetBar.ButtonItem();
			this.btnModifySpecialStepClass = new global::DevComponents.DotNetBar.ButtonItem();
			this.btnDeleteSpecialStepClass = new global::DevComponents.DotNetBar.ButtonItem();
			this.panelEx4 = new global::DevComponents.DotNetBar.PanelEx();
			this.itemLisenceCheck = new global::DevComponents.DotNetBar.ItemPanel();
			this.bar2 = new global::DevComponents.DotNetBar.Bar();
			this.labelItem1 = new global::DevComponents.DotNetBar.LabelItem();
			this.txtLisenceNo = new global::DevComponents.DotNetBar.TextBoxItem();
			this.btnLisenceSearch = new global::DevComponents.DotNetBar.ButtonItem();
			this.btnLisenceClassBound = new global::DevComponents.DotNetBar.ButtonItem();
			this.btnExport = new global::DevComponents.DotNetBar.ButtonItem();
			this.btnDelete = new global::DevComponents.DotNetBar.ButtonItem();
			this.btnAdd = new global::DevComponents.DotNetBar.ButtonItem();
			this.panelEx1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.barGroup).BeginInit();
			this.panelEx2.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvData).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.bar).BeginInit();
			this.panelEx3.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.bar1).BeginInit();
			this.panelEx4.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.bar2).BeginInit();
			base.SuspendLayout();
			this.panelEx1.CanvasColor = global::System.Drawing.SystemColors.Control;
			this.panelEx1.ColorSchemeStyle = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.panelEx1.Controls.Add(this.itemGroup);
			this.panelEx1.Controls.Add(this.barGroup);
			this.panelEx1.DisabledBackColor = global::System.Drawing.Color.Empty;
			this.panelEx1.Location = new global::System.Drawing.Point(146, 0);
			this.panelEx1.Name = "panelEx1";
			this.panelEx1.Size = new global::System.Drawing.Size(221, 522);
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
			this.itemGroup.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.itemGroup.DragDropSupport = true;
			this.itemGroup.LayoutOrientation = global::DevComponents.DotNetBar.eOrientation.Vertical;
			this.itemGroup.Location = new global::System.Drawing.Point(0, 25);
			this.itemGroup.Name = "itemGroup";
			this.itemGroup.Size = new global::System.Drawing.Size(221, 497);
			this.itemGroup.TabIndex = 5;
			this.itemGroup.Text = "itemPanel1";
			this.barGroup.AntiAlias = true;
			this.barGroup.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.barGroup.Font = new global::System.Drawing.Font("微软雅黑", 9f);
			this.barGroup.IsMaximized = false;
			this.barGroup.Location = new global::System.Drawing.Point(0, 0);
			this.barGroup.Name = "barGroup";
			this.barGroup.Size = new global::System.Drawing.Size(221, 25);
			this.barGroup.Stretch = true;
			this.barGroup.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.barGroup.TabIndex = 4;
			this.barGroup.TabStop = false;
			this.barGroup.Text = "bar2";
			this.btnImport.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.btnImport.Image = global::SQSClient.Properties.Resources.modify16;
			this.btnImport.ItemAlignment = global::DevComponents.DotNetBar.eItemAlignment.Far;
			this.btnImport.Name = "btnImport";
			this.btnImport.Text = "Import";
			this.btnImport.Visible = false;
			this.controlContainerItem1.AllowItemResize = false;
			this.controlContainerItem1.MenuVisibility = global::DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
			this.controlContainerItem1.Name = "controlContainerItem1";
			this.panelEx2.CanvasColor = global::System.Drawing.SystemColors.Control;
			this.panelEx2.ColorSchemeStyle = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.panelEx2.Controls.Add(this.dgvData);
			this.panelEx2.Controls.Add(this.bar);
			this.panelEx2.DisabledBackColor = global::System.Drawing.Color.Empty;
			this.panelEx2.Location = new global::System.Drawing.Point(373, 0);
			this.panelEx2.Name = "panelEx2";
			this.panelEx2.Size = new global::System.Drawing.Size(1110, 522);
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
				this.C_SkipEnable,
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
			this.dgvData.Location = new global::System.Drawing.Point(0, 25);
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
			this.dgvData.Size = new global::System.Drawing.Size(1110, 497);
			this.dgvData.TabIndex = 2;
			this.dgvData.CellClick += new global::System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUnit_CellClick);
			this.dgvData.CellMouseDown += new global::System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvData_CellMouseDown);
			this.C_ID.HeaderText = "ID";
			this.C_ID.Name = "C_ID";
			this.C_ID.ReadOnly = true;
			this.C_ID.Visible = false;
			this.C_SkipEnable.FillWeight = 16f;
			this.C_SkipEnable.HeaderText = "SkipEnable";
			this.C_SkipEnable.Name = "C_SkipEnable";
			this.C_SkipEnable.ReadOnly = true;
			this.C_InvModelId.FillWeight = 19.59264f;
			this.C_InvModelId.HeaderText = "Process";
			this.C_InvModelId.Name = "C_InvModelId";
			this.C_InvModelId.ReadOnly = true;
			this.C_InvModelId.Width = 134;
			this.C_StepCode.FillWeight = 14.02766f;
			this.C_StepCode.HeaderText = "ThisStep";
			this.C_StepCode.Name = "C_StepCode";
			this.C_StepCode.ReadOnly = true;
			this.C_StepCode.Width = 96;
			this.C_LastStep.FillWeight = 14.01795f;
			this.C_LastStep.HeaderText = "LastStep";
			this.C_LastStep.Name = "C_LastStep";
			this.C_LastStep.ReadOnly = true;
			this.C_LastStep.Width = 96;
			this.C_AllowCondition.FillWeight = 16.6358f;
			this.C_AllowCondition.HeaderText = "AllowCondition";
			this.C_AllowCondition.Name = "C_AllowCondition";
			this.C_AllowCondition.ReadOnly = true;
			this.C_AllowCondition.Width = 114;
			this.C_Creater.FillWeight = 17.27475f;
			this.C_Creater.HeaderText = "SrmCreater";
			this.C_Creater.Name = "C_Creater";
			this.C_Creater.ReadOnly = true;
			this.C_Creater.Width = 118;
			this.C_CreateTime.FillWeight = 13.75079f;
			this.C_CreateTime.HeaderText = "SrmCreateTime";
			this.C_CreateTime.Name = "C_CreateTime";
			this.C_CreateTime.ReadOnly = true;
			this.C_CreateTime.Width = 94;
			this.C_Modifier.FillWeight = 13.91132f;
			this.C_Modifier.HeaderText = "SrmModifier";
			this.C_Modifier.Name = "C_Modifier";
			this.C_Modifier.ReadOnly = true;
			this.C_Modifier.Width = 95;
			this.C_ModifyTime.FillWeight = 17.42628f;
			this.C_ModifyTime.HeaderText = "SrmModifyTime";
			this.C_ModifyTime.Name = "C_ModifyTime";
			this.C_ModifyTime.ReadOnly = true;
			this.C_ModifyTime.Width = 119;
			this.C_Enable.FillWeight = 17.25051f;
			this.C_Enable.HeaderText = "Enable";
			this.C_Enable.Name = "C_Enable";
			this.C_Enable.ReadOnly = true;
			this.C_Enable.Resizable = global::System.Windows.Forms.DataGridViewTriState.True;
			this.C_Enable.SortMode = global::System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.C_Enable.Width = 118;
			this.C_StepDesc.FillWeight = 17.38609f;
			this.C_StepDesc.HeaderText = "Memo";
			this.C_StepDesc.Name = "C_StepDesc";
			this.C_StepDesc.ReadOnly = true;
			this.C_StepDesc.Width = 119;
			this.bar.AntiAlias = true;
			this.bar.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.bar.Font = new global::System.Drawing.Font("Microsoft YaHei UI", 9f);
			this.bar.IsMaximized = false;
			this.bar.Location = new global::System.Drawing.Point(0, 0);
			this.bar.Name = "bar";
			this.bar.Size = new global::System.Drawing.Size(1110, 25);
			this.bar.Stretch = true;
			this.bar.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.bar.TabIndex = 1;
			this.bar.TabStop = false;
			this.bar.Text = "bar1";
			this.panelEx3.CanvasColor = global::System.Drawing.SystemColors.Control;
			this.panelEx3.ColorSchemeStyle = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.panelEx3.Controls.Add(this.itemClass);
			this.panelEx3.Controls.Add(this.bar1);
			this.panelEx3.DisabledBackColor = global::System.Drawing.Color.Empty;
			this.panelEx3.Location = new global::System.Drawing.Point(0, 0);
			this.panelEx3.Name = "panelEx3";
			this.panelEx3.Size = new global::System.Drawing.Size(140, 522);
			this.panelEx3.Style.Alignment = global::System.Drawing.StringAlignment.Center;
			this.panelEx3.Style.BackColor1.ColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
			this.panelEx3.Style.BackColor2.ColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
			this.panelEx3.Style.Border = global::DevComponents.DotNetBar.eBorderType.SingleLine;
			this.panelEx3.Style.BorderColor.ColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
			this.panelEx3.Style.ForeColor.ColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelText;
			this.panelEx3.Style.GradientAngle = 90;
			this.panelEx3.TabIndex = 40;
			this.panelEx3.Text = "panelEx3";
			this.itemClass.BackgroundStyle.Class = "ItemPanel";
			this.itemClass.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.itemClass.ContainerControlProcessDialogKey = true;
			this.itemClass.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.itemClass.DragDropSupport = true;
			this.itemClass.LayoutOrientation = global::DevComponents.DotNetBar.eOrientation.Vertical;
			this.itemClass.Location = new global::System.Drawing.Point(0, 27);
			this.itemClass.Name = "itemClass";
			this.itemClass.Size = new global::System.Drawing.Size(140, 495);
			this.itemClass.TabIndex = 5;
			this.itemClass.Text = "itemPanel1";
			this.bar1.AntiAlias = true;
			this.bar1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.bar1.Font = new global::System.Drawing.Font("微软雅黑", 9f);
			this.bar1.IsMaximized = false;
			this.bar1.Items.AddRange(new global::DevComponents.DotNetBar.BaseItem[]
			{
				this.btnAddSpecailStepClass,
				this.btnModifySpecialStepClass,
				this.btnDeleteSpecialStepClass
			});
			this.bar1.Location = new global::System.Drawing.Point(0, 0);
			this.bar1.Name = "bar1";
			this.bar1.Size = new global::System.Drawing.Size(140, 27);
			this.bar1.Stretch = true;
			this.bar1.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.bar1.TabIndex = 4;
			this.bar1.TabStop = false;
			this.bar1.Text = "bar2";
			this.btnAddSpecailStepClass.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.btnAddSpecailStepClass.Name = "btnAddSpecailStepClass";
			this.btnAddSpecailStepClass.Text = "Add";
			this.btnAddSpecailStepClass.Click += new global::System.EventHandler(this.btnAddSpecailStepClass_Click);
			this.btnModifySpecialStepClass.Name = "btnModifySpecialStepClass";
			this.btnModifySpecialStepClass.Text = "Modify";
			this.btnModifySpecialStepClass.Click += new global::System.EventHandler(this.btnModifySpecialStepClass_Click);
			this.btnDeleteSpecialStepClass.Name = "btnDeleteSpecialStepClass";
			this.btnDeleteSpecialStepClass.Text = "Delete";
			this.btnDeleteSpecialStepClass.Click += new global::System.EventHandler(this.btnDeleteSpecialStepClass_Click);
			this.panelEx4.CanvasColor = global::System.Drawing.SystemColors.Control;
			this.panelEx4.ColorSchemeStyle = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.panelEx4.Controls.Add(this.itemLisenceCheck);
			this.panelEx4.Controls.Add(this.bar2);
			this.panelEx4.DisabledBackColor = global::System.Drawing.Color.Empty;
			this.panelEx4.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.panelEx4.Location = new global::System.Drawing.Point(1489, 0);
			this.panelEx4.Name = "panelEx4";
			this.panelEx4.Size = new global::System.Drawing.Size(206, 522);
			this.panelEx4.Style.Alignment = global::System.Drawing.StringAlignment.Center;
			this.panelEx4.Style.BackColor1.ColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
			this.panelEx4.Style.BackColor2.ColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
			this.panelEx4.Style.Border = global::DevComponents.DotNetBar.eBorderType.SingleLine;
			this.panelEx4.Style.BorderColor.ColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
			this.panelEx4.Style.ForeColor.ColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelText;
			this.panelEx4.Style.GradientAngle = 90;
			this.panelEx4.TabIndex = 44;
			this.panelEx4.Text = "panelEx4";
			this.itemLisenceCheck.AutoScroll = true;
			this.itemLisenceCheck.BackgroundStyle.Class = "ItemPanel";
			this.itemLisenceCheck.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.itemLisenceCheck.ContainerControlProcessDialogKey = true;
			this.itemLisenceCheck.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.itemLisenceCheck.DragDropSupport = true;
			this.itemLisenceCheck.LayoutOrientation = global::DevComponents.DotNetBar.eOrientation.Vertical;
			this.itemLisenceCheck.Location = new global::System.Drawing.Point(0, 27);
			this.itemLisenceCheck.Name = "itemLisenceCheck";
			this.itemLisenceCheck.Size = new global::System.Drawing.Size(206, 495);
			this.itemLisenceCheck.TabIndex = 5;
			this.itemLisenceCheck.Text = "itemPanel2";
			this.bar2.AntiAlias = true;
			this.bar2.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.bar2.DockSide = global::DevComponents.DotNetBar.eDockSide.Right;
			this.bar2.Font = new global::System.Drawing.Font("微软雅黑", 9f);
			this.bar2.IsMaximized = false;
			this.bar2.Items.AddRange(new global::DevComponents.DotNetBar.BaseItem[]
			{
				this.labelItem1,
				this.txtLisenceNo,
				this.btnLisenceSearch,
				this.btnLisenceClassBound
			});
			this.bar2.Location = new global::System.Drawing.Point(0, 0);
			this.bar2.Name = "bar2";
			this.bar2.Size = new global::System.Drawing.Size(206, 27);
			this.bar2.Stretch = true;
			this.bar2.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.bar2.TabIndex = 4;
			this.bar2.TabStop = false;
			this.bar2.Text = "bar2";
			this.labelItem1.Name = "labelItem1";
			this.labelItem1.Text = "Car:";
			this.txtLisenceNo.Name = "txtLisenceNo";
			this.txtLisenceNo.WatermarkColor = global::System.Drawing.SystemColors.GrayText;
			this.btnLisenceSearch.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.btnLisenceSearch.Name = "btnLisenceSearch";
			this.btnLisenceSearch.Text = "Serach";
			this.btnLisenceSearch.Click += new global::System.EventHandler(this.btnLisenceSearch_Click);
			this.btnLisenceClassBound.ItemAlignment = global::DevComponents.DotNetBar.eItemAlignment.Far;
			this.btnLisenceClassBound.Name = "btnLisenceClassBound";
			this.btnLisenceClassBound.Text = "Bound";
			this.btnLisenceClassBound.Click += new global::System.EventHandler(this.btnLisenceClassBound_Click);
			this.btnExport.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.btnExport.Image = global::SQSClient.Properties.Resources.print16;
			this.btnExport.Name = "btnExport";
			this.btnExport.SubItems.AddRange(new global::DevComponents.DotNetBar.BaseItem[]
			{
				this.btnDelete
			});
			this.btnExport.Text = "Export";
			this.btnDelete.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.btnDelete.Image = global::SQSClient.Properties.Resources.delete16;
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.SubItems.AddRange(new global::DevComponents.DotNetBar.BaseItem[]
			{
				this.btnAdd
			});
			this.btnDelete.Text = "Delete";
			this.btnAdd.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.btnAdd.Image = global::SQSClient.Properties.Resources.add16;
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Text = "Add";
			base.ClientSize = new global::System.Drawing.Size(1695, 522);
			base.Controls.Add(this.panelEx4);
			base.Controls.Add(this.panelEx3);
			base.Controls.Add(this.panelEx2);
			base.Controls.Add(this.panelEx1);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "frmSpecialStepClass";
			this.Text = "frmInvStepClass";
			base.Load += new global::System.EventHandler(this.frmUnit_Load);
			this.panelEx1.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.barGroup).EndInit();
			this.panelEx2.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.dgvData).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.bar).EndInit();
			this.panelEx3.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.bar1).EndInit();
			this.panelEx4.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.bar2).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x040003A2 RID: 930
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x040003A3 RID: 931
		private global::DevComponents.DotNetBar.PanelEx panelEx1;

		// Token: 0x040003A4 RID: 932
		private global::DevComponents.DotNetBar.Bar barGroup;

		// Token: 0x040003A5 RID: 933
		private global::DevComponents.DotNetBar.ControlContainerItem controlContainerItem1;

		// Token: 0x040003A6 RID: 934
		private global::DevComponents.DotNetBar.PanelEx panelEx2;

		// Token: 0x040003A7 RID: 935
		private global::DevComponents.DotNetBar.Bar bar;

		// Token: 0x040003A8 RID: 936
		private global::DevComponents.DotNetBar.Controls.DataGridViewX dgvData;

		// Token: 0x040003A9 RID: 937
		private global::DevComponents.DotNetBar.ItemPanel itemGroup;

		// Token: 0x040003AA RID: 938
		private global::DevComponents.DotNetBar.ButtonItem btnImport;

		// Token: 0x040003AB RID: 939
		private global::DevComponents.DotNetBar.PanelEx panelEx3;

		// Token: 0x040003AC RID: 940
		private global::DevComponents.DotNetBar.ItemPanel itemClass;

		// Token: 0x040003AD RID: 941
		private global::DevComponents.DotNetBar.Bar bar1;

		// Token: 0x040003AE RID: 942
		private global::DevComponents.DotNetBar.ButtonItem btnAddSpecailStepClass;

		// Token: 0x040003AF RID: 943
		private global::DevComponents.DotNetBar.PanelEx panelEx4;

		// Token: 0x040003B0 RID: 944
		private global::DevComponents.DotNetBar.ItemPanel itemLisenceCheck;

		// Token: 0x040003B1 RID: 945
		private global::DevComponents.DotNetBar.Bar bar2;

		// Token: 0x040003B2 RID: 946
		private global::DevComponents.DotNetBar.ButtonItem btnLisenceSearch;

		// Token: 0x040003B3 RID: 947
		private global::DevComponents.DotNetBar.LabelItem labelItem1;

		// Token: 0x040003B4 RID: 948
		private global::DevComponents.DotNetBar.TextBoxItem txtLisenceNo;

		// Token: 0x040003B5 RID: 949
		private global::DevComponents.DotNetBar.ButtonItem btnLisenceClassBound;

		// Token: 0x040003B6 RID: 950
		private global::DevComponents.DotNetBar.ButtonItem btnExport;

		// Token: 0x040003B7 RID: 951
		private global::DevComponents.DotNetBar.ButtonItem btnDelete;

		// Token: 0x040003B8 RID: 952
		private global::DevComponents.DotNetBar.ButtonItem btnAdd;

		// Token: 0x040003B9 RID: 953
		private global::DevComponents.DotNetBar.ButtonItem btnDeleteSpecialStepClass;

		// Token: 0x040003BA RID: 954
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_ID;

		// Token: 0x040003BB RID: 955
		private global::System.Windows.Forms.DataGridViewCheckBoxColumn C_SkipEnable;

		// Token: 0x040003BC RID: 956
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_InvModelId;

		// Token: 0x040003BD RID: 957
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_StepCode;

		// Token: 0x040003BE RID: 958
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_LastStep;

		// Token: 0x040003BF RID: 959
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_AllowCondition;

		// Token: 0x040003C0 RID: 960
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_Creater;

		// Token: 0x040003C1 RID: 961
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_CreateTime;

		// Token: 0x040003C2 RID: 962
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_Modifier;

		// Token: 0x040003C3 RID: 963
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_ModifyTime;

		// Token: 0x040003C4 RID: 964
		private global::System.Windows.Forms.DataGridViewCheckBoxColumn C_Enable;

		// Token: 0x040003C5 RID: 965
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_StepDesc;

		// Token: 0x040003C6 RID: 966
		private global::DevComponents.DotNetBar.ButtonItem btnModifySpecialStepClass;
	}
}
