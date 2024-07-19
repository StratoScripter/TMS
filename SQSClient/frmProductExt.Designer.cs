namespace SQSClient
{
	// Token: 0x02000065 RID: 101
	public partial class frmProductExt : global::SQSClient.BaseDialogForm
	{
		// Token: 0x0600050D RID: 1293 RVA: 0x0007FC10 File Offset: 0x0007DE10
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600050E RID: 1294 RVA: 0x0007FC48 File Offset: 0x0007DE48
		private void InitializeComponent()
		{
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::SQSClient.frmProductExt));
			this.panelEx1 = new global::DevComponents.DotNetBar.PanelEx();
			this.splitContainer1 = new global::System.Windows.Forms.SplitContainer();
			this.layoutControl1 = new global::DevComponents.DotNetBar.Layout.LayoutControl();
			this.cmbProductFree = new global::Base.AutoComboBox();
			this.txtProExtInfo = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.dInputFree1Value = new global::DevComponents.Editors.DoubleInput();
			this.dInputFree2Value = new global::DevComponents.Editors.DoubleInput();
			this.btnModifyInvFree = new global::DevComponents.DotNetBar.ButtonX();
			this.btnQueueSure = new global::DevComponents.DotNetBar.ButtonX();
			this.cmbQueue = new global::Base.AutoComboBox();
			this.layoutControlItem1 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem2 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem3 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.lclFree1Value = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.lclFree2Value = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem6 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem5 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlFree = new global::DevComponents.DotNetBar.Layout.LayoutControl();
			this.barGroup = new global::DevComponents.DotNetBar.Bar();
			this.btnAdd = new global::DevComponents.DotNetBar.ButtonItem();
			this.btnModify = new global::DevComponents.DotNetBar.ButtonItem();
			this.lblEditStatus = new global::DevComponents.DotNetBar.LabelItem();
			this.btnFreeInit = new global::DevComponents.DotNetBar.ButtonItem();
			this.controlContainerItem1 = new global::DevComponents.DotNetBar.ControlContainerItem();
			this.panelEx2 = new global::DevComponents.DotNetBar.PanelEx();
			this.dgvData = new global::DevComponents.DotNetBar.Controls.DataGridViewX();
			this.C_ID = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_InvCode = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_ProExtType = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_FreeModel = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_PackageWeight = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_AccuUpperLimit = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_AccuLowerLimit = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_ExtState = new global::System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.C_ProExtInfo = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_FreeSort = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bar = new global::DevComponents.DotNetBar.Bar();
			this.btnDelete = new global::DevComponents.DotNetBar.ButtonItem();
			this.btnExport = new global::DevComponents.DotNetBar.ButtonItem();
			this.btnBatchSetting = new global::DevComponents.DotNetBar.ButtonItem();
			this.expandableSplitter1 = new global::DevComponents.DotNetBar.ExpandableSplitter();
			this.btnSearch = new global::DevComponents.DotNetBar.ButtonItem();
			this.layoutControlItem4 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.panelEx1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.splitContainer1).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.layoutControl1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dInputFree1Value).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.dInputFree2Value).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.barGroup).BeginInit();
			this.panelEx2.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvData).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.bar).BeginInit();
			base.SuspendLayout();
			this.panelEx1.CanvasColor = global::System.Drawing.SystemColors.Control;
			this.panelEx1.ColorSchemeStyle = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.panelEx1.Controls.Add(this.splitContainer1);
			this.panelEx1.Controls.Add(this.barGroup);
			this.panelEx1.DisabledBackColor = global::System.Drawing.Color.Empty;
			this.panelEx1.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.panelEx1.Location = new global::System.Drawing.Point(0, 0);
			this.panelEx1.Name = "panelEx1";
			this.panelEx1.Size = new global::System.Drawing.Size(346, 499);
			this.panelEx1.Style.Alignment = global::System.Drawing.StringAlignment.Center;
			this.panelEx1.Style.BackColor1.ColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
			this.panelEx1.Style.BackColor2.ColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
			this.panelEx1.Style.Border = global::DevComponents.DotNetBar.eBorderType.SingleLine;
			this.panelEx1.Style.BorderColor.ColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
			this.panelEx1.Style.ForeColor.ColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelText;
			this.panelEx1.Style.GradientAngle = 90;
			this.panelEx1.TabIndex = 5;
			this.panelEx1.Text = "panelEx1";
			this.splitContainer1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new global::System.Drawing.Point(0, 27);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = global::System.Windows.Forms.Orientation.Horizontal;
			this.splitContainer1.Panel1.Controls.Add(this.layoutControl1);
			this.splitContainer1.Panel2.Controls.Add(this.layoutControlFree);
			this.splitContainer1.Size = new global::System.Drawing.Size(346, 472);
			this.splitContainer1.SplitterDistance = 122;
			this.splitContainer1.TabIndex = 5;
			this.layoutControl1.Controls.Add(this.cmbProductFree);
			this.layoutControl1.Controls.Add(this.txtProExtInfo);
			this.layoutControl1.Controls.Add(this.dInputFree1Value);
			this.layoutControl1.Controls.Add(this.dInputFree2Value);
			this.layoutControl1.Controls.Add(this.btnModifyInvFree);
			this.layoutControl1.Controls.Add(this.btnQueueSure);
			this.layoutControl1.Controls.Add(this.cmbQueue);
			this.layoutControl1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.layoutControl1.Location = new global::System.Drawing.Point(0, 0);
			this.layoutControl1.Name = "layoutControl1";
			this.layoutControl1.RootGroup.Items.AddRange(new global::DevComponents.DotNetBar.Layout.LayoutItemBase[]
			{
				this.layoutControlItem1,
				this.layoutControlItem2,
				this.layoutControlItem3,
				this.lclFree1Value,
				this.lclFree2Value,
				this.layoutControlItem6,
				this.layoutControlItem5
			});
			this.layoutControl1.Size = new global::System.Drawing.Size(346, 122);
			this.layoutControl1.TabIndex = 22;
			this.cmbProductFree.DataSource = null;
			this.cmbProductFree.DisplayMember = null;
			this.cmbProductFree.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cmbProductFree.FormattingEnabled = true;
			this.cmbProductFree.ItemHeight = 15;
			this.cmbProductFree.Location = new global::System.Drawing.Point(80, 4);
			this.cmbProductFree.Margin = new global::System.Windows.Forms.Padding(0);
			this.cmbProductFree.MaxDropDownItems = 20;
			this.cmbProductFree.Name = "cmbProductFree";
			this.cmbProductFree.SelectMember = null;
			this.cmbProductFree.Size = new global::System.Drawing.Size(227, 21);
			this.cmbProductFree.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.cmbProductFree.TabIndex = 0;
			this.cmbProductFree.ValueMember = null;
			this.cmbProductFree.SelectedIndexChanged += new global::System.EventHandler(this.cmbProductFree_SelectedIndexChanged);
			this.txtProExtInfo.Border.Class = "TextBoxBorder";
			this.txtProExtInfo.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtProExtInfo.Location = new global::System.Drawing.Point(80, 35);
			this.txtProExtInfo.Margin = new global::System.Windows.Forms.Padding(0);
			this.txtProExtInfo.MaxLength = 20;
			this.txtProExtInfo.Name = "txtProExtInfo";
			this.txtProExtInfo.PreventEnterBeep = true;
			this.txtProExtInfo.Size = new global::System.Drawing.Size(262, 21);
			this.txtProExtInfo.TabIndex = 2;
			this.dInputFree1Value.BackgroundStyle.Class = "DateTimeInputBackground";
			this.dInputFree1Value.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.dInputFree1Value.ButtonFreeText.Shortcut = global::DevComponents.DotNetBar.eShortcut.F2;
			this.dInputFree1Value.DisplayFormat = "0.000";
			this.dInputFree1Value.Increment = 0.1;
			this.dInputFree1Value.InputHorizontalAlignment = global::DevComponents.Editors.eHorizontalAlignment.Left;
			this.dInputFree1Value.Location = new global::System.Drawing.Point(80, 64);
			this.dInputFree1Value.Margin = new global::System.Windows.Forms.Padding(0);
			this.dInputFree1Value.MaxValue = 999999.0;
			this.dInputFree1Value.MinValue = 0.0;
			this.dInputFree1Value.MouseWheelValueChangeEnabled = false;
			this.dInputFree1Value.Name = "dInputFree1Value";
			this.dInputFree1Value.ShowUpDown = true;
			this.dInputFree1Value.Size = new global::System.Drawing.Size(89, 21);
			this.dInputFree1Value.TabIndex = 3;
			this.dInputFree2Value.BackgroundStyle.Class = "DateTimeInputBackground";
			this.dInputFree2Value.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.dInputFree2Value.ButtonFreeText.Shortcut = global::DevComponents.DotNetBar.eShortcut.F2;
			this.dInputFree2Value.DisplayFormat = "0.000";
			this.dInputFree2Value.Increment = 0.1;
			this.dInputFree2Value.InputHorizontalAlignment = global::DevComponents.Editors.eHorizontalAlignment.Left;
			this.dInputFree2Value.Location = new global::System.Drawing.Point(253, 64);
			this.dInputFree2Value.Margin = new global::System.Windows.Forms.Padding(0);
			this.dInputFree2Value.MaxValue = 999999.0;
			this.dInputFree2Value.MinValue = -999999.0;
			this.dInputFree2Value.MouseWheelValueChangeEnabled = false;
			this.dInputFree2Value.Name = "dInputFree2Value";
			this.dInputFree2Value.ShowUpDown = true;
			this.dInputFree2Value.Size = new global::System.Drawing.Size(89, 21);
			this.dInputFree2Value.TabIndex = 4;
			this.btnModifyInvFree.AccessibleRole = global::System.Windows.Forms.AccessibleRole.PushButton;
			this.btnModifyInvFree.ColorTable = global::DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.btnModifyInvFree.Image = global::SQSClient.Properties.Resources.modify16;
			this.btnModifyInvFree.Location = new global::System.Drawing.Point(315, 4);
			this.btnModifyInvFree.Margin = new global::System.Windows.Forms.Padding(0);
			this.btnModifyInvFree.Name = "btnModifyInvFree";
			this.btnModifyInvFree.Size = new global::System.Drawing.Size(24, 23);
			this.btnModifyInvFree.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.btnModifyInvFree.TabIndex = 1;
			this.btnModifyInvFree.Click += new global::System.EventHandler(this.btnModifyInvFree_Click);
			this.btnQueueSure.AccessibleRole = global::System.Windows.Forms.AccessibleRole.PushButton;
			this.btnQueueSure.ColorTable = global::DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.btnQueueSure.Location = new global::System.Drawing.Point(246, 93);
			this.btnQueueSure.Margin = new global::System.Windows.Forms.Padding(0);
			this.btnQueueSure.Name = "btnQueueSure";
			this.btnQueueSure.Size = new global::System.Drawing.Size(96, 23);
			this.btnQueueSure.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.btnQueueSure.TabIndex = 6;
			this.btnQueueSure.Text = "Sure";
			this.btnQueueSure.Click += new global::System.EventHandler(this.btnQueueSure_Click);
			this.cmbQueue.DataSource = null;
			this.cmbQueue.DisplayMember = null;
			this.cmbQueue.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cmbQueue.FormattingEnabled = true;
			this.cmbQueue.ItemHeight = 15;
			this.cmbQueue.Location = new global::System.Drawing.Point(80, 93);
			this.cmbQueue.Margin = new global::System.Windows.Forms.Padding(0);
			this.cmbQueue.MaxDropDownItems = 20;
			this.cmbQueue.Name = "cmbQueue";
			this.cmbQueue.SelectMember = null;
			this.cmbQueue.Size = new global::System.Drawing.Size(158, 21);
			this.cmbQueue.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.cmbQueue.TabIndex = 5;
			this.cmbQueue.ValueMember = null;
			this.layoutControlItem1.Control = this.cmbProductFree;
			this.layoutControlItem1.Height = 29;
			this.layoutControlItem1.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Text = "ProductFree";
			this.layoutControlItem1.Width = 90;
			this.layoutControlItem1.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem2.Control = this.btnModifyInvFree;
			this.layoutControlItem2.Height = 31;
			this.layoutControlItem2.MinSize = new global::System.Drawing.Size(32, 20);
			this.layoutControlItem2.Name = "layoutControlItem2";
			this.layoutControlItem2.Width = 5;
			this.layoutControlItem2.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem3.Control = this.txtProExtInfo;
			this.layoutControlItem3.Height = 29;
			this.layoutControlItem3.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem3.Name = "layoutControlItem3";
			this.layoutControlItem3.Text = "ProExtInfo";
			this.layoutControlItem3.Width = 100;
			this.layoutControlItem3.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.lclFree1Value.Control = this.dInputFree1Value;
			this.lclFree1Value.Height = 29;
			this.lclFree1Value.MinSize = new global::System.Drawing.Size(64, 18);
			this.lclFree1Value.Name = "lclFree1Value";
			this.lclFree1Value.Text = "Free1Value";
			this.lclFree1Value.Width = 50;
			this.lclFree1Value.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.lclFree2Value.Control = this.dInputFree2Value;
			this.lclFree2Value.Height = 29;
			this.lclFree2Value.MinSize = new global::System.Drawing.Size(64, 18);
			this.lclFree2Value.Name = "lclFree2Value";
			this.lclFree2Value.Text = "Free2Value";
			this.lclFree2Value.Width = 50;
			this.lclFree2Value.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem6.Control = this.cmbQueue;
			this.layoutControlItem6.Height = 29;
			this.layoutControlItem6.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem6.Name = "layoutControlItem6";
			this.layoutControlItem6.Text = "Queue";
			this.layoutControlItem6.Width = 70;
			this.layoutControlItem6.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem5.Control = this.btnQueueSure;
			this.layoutControlItem5.Height = 31;
			this.layoutControlItem5.MinSize = new global::System.Drawing.Size(32, 20);
			this.layoutControlItem5.Name = "layoutControlItem5";
			this.layoutControlItem5.Width = 30;
			this.layoutControlItem5.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlFree.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.layoutControlFree.Location = new global::System.Drawing.Point(0, 0);
			this.layoutControlFree.Name = "layoutControlFree";
			this.layoutControlFree.Size = new global::System.Drawing.Size(346, 346);
			this.layoutControlFree.TabIndex = 22;
			this.barGroup.AntiAlias = true;
			this.barGroup.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.barGroup.DockSide = global::DevComponents.DotNetBar.eDockSide.Left;
			this.barGroup.Font = new global::System.Drawing.Font("微软雅黑", 9f);
			this.barGroup.IsMaximized = false;
			this.barGroup.Items.AddRange(new global::DevComponents.DotNetBar.BaseItem[]
			{
				this.btnAdd,
				this.btnModify,
				this.lblEditStatus,
				this.btnFreeInit
			});
			this.barGroup.Location = new global::System.Drawing.Point(0, 0);
			this.barGroup.Name = "barGroup";
			this.barGroup.Size = new global::System.Drawing.Size(346, 27);
			this.barGroup.Stretch = true;
			this.barGroup.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.barGroup.TabIndex = 4;
			this.barGroup.TabStop = false;
			this.barGroup.Text = "bar2";
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
			this.lblEditStatus.ItemAlignment = global::DevComponents.DotNetBar.eItemAlignment.Far;
			this.lblEditStatus.Name = "lblEditStatus";
			this.lblEditStatus.Text = "EditStatus";
			this.lblEditStatus.Visible = false;
			this.lblEditStatus.Click += new global::System.EventHandler(this.lblEditStatus_Click);
			this.btnFreeInit.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.btnFreeInit.Image = global::SQSClient.Properties.Resources.modify16;
			this.btnFreeInit.ItemAlignment = global::DevComponents.DotNetBar.eItemAlignment.Far;
			this.btnFreeInit.Name = "btnFreeInit";
			this.btnFreeInit.Text = "FreeInit";
			this.btnFreeInit.Visible = false;
			this.btnFreeInit.Click += new global::System.EventHandler(this.btnFreeInit_Click);
			this.controlContainerItem1.AllowItemResize = false;
			this.controlContainerItem1.MenuVisibility = global::DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
			this.controlContainerItem1.Name = "controlContainerItem1";
			this.panelEx2.CanvasColor = global::System.Drawing.SystemColors.Control;
			this.panelEx2.ColorSchemeStyle = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.panelEx2.Controls.Add(this.dgvData);
			this.panelEx2.Controls.Add(this.bar);
			this.panelEx2.DisabledBackColor = global::System.Drawing.Color.Empty;
			this.panelEx2.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.panelEx2.Location = new global::System.Drawing.Point(349, 0);
			this.panelEx2.Name = "panelEx2";
			this.panelEx2.Size = new global::System.Drawing.Size(1005, 499);
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
				this.C_InvCode,
				this.C_ProExtType,
				this.C_FreeModel,
				this.C_PackageWeight,
				this.C_AccuUpperLimit,
				this.C_AccuLowerLimit,
				this.C_ExtState,
				this.C_ProExtInfo,
				this.C_FreeSort
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
			this.dgvData.Size = new global::System.Drawing.Size(1005, 473);
			this.dgvData.TabIndex = 2;
			this.dgvData.CellClick += new global::System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUnit_CellClick);
			this.dgvData.CellDoubleClick += new global::System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUnit_CellDoubleClick);
			this.dgvData.SelectionChanged += new global::System.EventHandler(this.dgvData_SelectionChanged);
			this.C_ID.HeaderText = "ID";
			this.C_ID.Name = "C_ID";
			this.C_ID.ReadOnly = true;
			this.C_ID.Visible = false;
			this.C_InvCode.FillWeight = 25.02266f;
			this.C_InvCode.HeaderText = "InvCode";
			this.C_InvCode.Name = "C_InvCode";
			this.C_InvCode.ReadOnly = true;
			this.C_ProExtType.FillWeight = 17.86582f;
			this.C_ProExtType.HeaderText = "ProExtType";
			this.C_ProExtType.Name = "C_ProExtType";
			this.C_ProExtType.ReadOnly = true;
			this.C_FreeModel.FillWeight = 25.88474f;
			this.C_FreeModel.HeaderText = "FreeModel";
			this.C_FreeModel.Name = "C_FreeModel";
			this.C_FreeModel.ReadOnly = true;
			this.C_PackageWeight.FillWeight = 22.02021f;
			this.C_PackageWeight.HeaderText = "PackageWeight";
			this.C_PackageWeight.Name = "C_PackageWeight";
			this.C_PackageWeight.ReadOnly = true;
			this.C_AccuUpperLimit.FillWeight = 22f;
			this.C_AccuUpperLimit.HeaderText = "AccuUpperLimit";
			this.C_AccuUpperLimit.Name = "C_AccuUpperLimit";
			this.C_AccuUpperLimit.ReadOnly = true;
			this.C_AccuLowerLimit.FillWeight = 22.02021f;
			this.C_AccuLowerLimit.HeaderText = "AccuLowerLimit";
			this.C_AccuLowerLimit.Name = "C_AccuLowerLimit";
			this.C_AccuLowerLimit.ReadOnly = true;
			this.C_ExtState.FillWeight = 22.02021f;
			this.C_ExtState.HeaderText = "ExtState";
			this.C_ExtState.Name = "C_ExtState";
			this.C_ExtState.ReadOnly = true;
			this.C_ExtState.Resizable = global::System.Windows.Forms.DataGridViewTriState.True;
			this.C_ExtState.SortMode = global::System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.C_ProExtInfo.FillWeight = 17.86582f;
			this.C_ProExtInfo.HeaderText = "ProExtInfo";
			this.C_ProExtInfo.Name = "C_ProExtInfo";
			this.C_ProExtInfo.ReadOnly = true;
			this.C_FreeSort.FillWeight = 17f;
			this.C_FreeSort.HeaderText = "FreeSort";
			this.C_FreeSort.Name = "C_FreeSort";
			this.C_FreeSort.ReadOnly = true;
			this.bar.AntiAlias = true;
			this.bar.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.bar.DockSide = global::DevComponents.DotNetBar.eDockSide.Document;
			this.bar.Font = new global::System.Drawing.Font("Microsoft YaHei UI", 9f);
			this.bar.IsMaximized = false;
			this.bar.Items.AddRange(new global::DevComponents.DotNetBar.BaseItem[]
			{
				this.btnDelete,
				this.btnExport,
				this.btnBatchSetting
			});
			this.bar.Location = new global::System.Drawing.Point(0, 0);
			this.bar.Name = "bar";
			this.bar.Size = new global::System.Drawing.Size(1005, 26);
			this.bar.Stretch = true;
			this.bar.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.bar.TabIndex = 1;
			this.bar.TabStop = false;
			this.bar.Text = "bar1";
			this.btnDelete.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.btnDelete.Image = global::SQSClient.Properties.Resources.delete16;
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Text = "BatchDelete";
			this.btnDelete.Click += new global::System.EventHandler(this.btnDelete_Click);
			this.btnExport.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.btnExport.Image = global::SQSClient.Properties.Resources.print16;
			this.btnExport.Name = "btnExport";
			this.btnExport.Text = "Export";
			this.btnExport.Click += new global::System.EventHandler(this.btnExport_Click);
			this.btnBatchSetting.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.btnBatchSetting.Image = global::SQSClient.Properties.Resources.modify16;
			this.btnBatchSetting.ItemAlignment = global::DevComponents.DotNetBar.eItemAlignment.Far;
			this.btnBatchSetting.Name = "btnBatchSetting";
			this.btnBatchSetting.Text = "BatchSetting";
			this.btnBatchSetting.Click += new global::System.EventHandler(this.btnBatchSetting_Click);
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
			this.expandableSplitter1.Location = new global::System.Drawing.Point(346, 0);
			this.expandableSplitter1.Name = "expandableSplitter1";
			this.expandableSplitter1.Size = new global::System.Drawing.Size(3, 499);
			this.expandableSplitter1.Style = global::DevComponents.DotNetBar.eSplitterStyle.Office2007;
			this.expandableSplitter1.TabIndex = 26;
			this.expandableSplitter1.TabStop = false;
			this.btnSearch.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.btnSearch.Image = global::SQSClient.Properties.Resources.search16;
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Text = "Search";
			this.layoutControlItem4.Control = this.cmbQueue;
			this.layoutControlItem4.Height = 29;
			this.layoutControlItem4.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem4.Name = "layoutControlItem4";
			this.layoutControlItem4.Text = "ProductFree";
			this.layoutControlItem4.Width = 90;
			this.layoutControlItem4.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			base.ClientSize = new global::System.Drawing.Size(1354, 499);
			base.Controls.Add(this.panelEx2);
			base.Controls.Add(this.expandableSplitter1);
			base.Controls.Add(this.panelEx1);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "frmProductExt";
			this.Text = "frmProductExt";
			base.Load += new global::System.EventHandler(this.frmUnit_Load);
			this.panelEx1.ResumeLayout(false);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.splitContainer1).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.layoutControl1.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.dInputFree1Value).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.dInputFree2Value).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.barGroup).EndInit();
			this.panelEx2.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.dgvData).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.bar).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x0400089C RID: 2204
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400089D RID: 2205
		private global::DevComponents.DotNetBar.PanelEx panelEx1;

		// Token: 0x0400089E RID: 2206
		private global::DevComponents.DotNetBar.Bar barGroup;

		// Token: 0x0400089F RID: 2207
		private global::DevComponents.DotNetBar.ControlContainerItem controlContainerItem1;

		// Token: 0x040008A0 RID: 2208
		private global::DevComponents.DotNetBar.PanelEx panelEx2;

		// Token: 0x040008A1 RID: 2209
		private global::DevComponents.DotNetBar.Bar bar;

		// Token: 0x040008A2 RID: 2210
		private global::DevComponents.DotNetBar.ButtonItem btnDelete;

		// Token: 0x040008A3 RID: 2211
		private global::DevComponents.DotNetBar.ButtonItem btnExport;

		// Token: 0x040008A4 RID: 2212
		private global::DevComponents.DotNetBar.Controls.DataGridViewX dgvData;

		// Token: 0x040008A5 RID: 2213
		private global::DevComponents.DotNetBar.ExpandableSplitter expandableSplitter1;

		// Token: 0x040008A6 RID: 2214
		private global::System.Windows.Forms.SplitContainer splitContainer1;

		// Token: 0x040008A7 RID: 2215
		private global::DevComponents.DotNetBar.Layout.LayoutControl layoutControl1;

		// Token: 0x040008A8 RID: 2216
		private global::Base.AutoComboBox cmbProductFree;

		// Token: 0x040008A9 RID: 2217
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem1;

		// Token: 0x040008AA RID: 2218
		private global::DevComponents.DotNetBar.Layout.LayoutControl layoutControlFree;

		// Token: 0x040008AB RID: 2219
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtProExtInfo;

		// Token: 0x040008AC RID: 2220
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem3;

		// Token: 0x040008AD RID: 2221
		private global::DevComponents.Editors.DoubleInput dInputFree1Value;

		// Token: 0x040008AE RID: 2222
		private global::DevComponents.Editors.DoubleInput dInputFree2Value;

		// Token: 0x040008AF RID: 2223
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem lclFree1Value;

		// Token: 0x040008B0 RID: 2224
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem lclFree2Value;

		// Token: 0x040008B1 RID: 2225
		private global::DevComponents.DotNetBar.LabelItem lblEditStatus;

		// Token: 0x040008B2 RID: 2226
		private global::DevComponents.DotNetBar.ButtonItem btnAdd;

		// Token: 0x040008B3 RID: 2227
		private global::DevComponents.DotNetBar.ButtonItem btnModify;

		// Token: 0x040008B4 RID: 2228
		public global::DevComponents.DotNetBar.ButtonX btnModifyInvFree;

		// Token: 0x040008B5 RID: 2229
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem2;

		// Token: 0x040008B6 RID: 2230
		private global::DevComponents.DotNetBar.ButtonItem btnBatchSetting;

		// Token: 0x040008B7 RID: 2231
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_ID;

		// Token: 0x040008B8 RID: 2232
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_InvCode;

		// Token: 0x040008B9 RID: 2233
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_ProExtType;

		// Token: 0x040008BA RID: 2234
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_FreeModel;

		// Token: 0x040008BB RID: 2235
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_PackageWeight;

		// Token: 0x040008BC RID: 2236
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_AccuUpperLimit;

		// Token: 0x040008BD RID: 2237
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_AccuLowerLimit;

		// Token: 0x040008BE RID: 2238
		private global::System.Windows.Forms.DataGridViewCheckBoxColumn C_ExtState;

		// Token: 0x040008BF RID: 2239
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_ProExtInfo;

		// Token: 0x040008C0 RID: 2240
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_FreeSort;

		// Token: 0x040008C1 RID: 2241
		private global::DevComponents.DotNetBar.ButtonItem btnFreeInit;

		// Token: 0x040008C2 RID: 2242
		private global::DevComponents.DotNetBar.ButtonItem btnSearch;

		// Token: 0x040008C3 RID: 2243
		private global::DevComponents.DotNetBar.ButtonX btnQueueSure;

		// Token: 0x040008C4 RID: 2244
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem5;

		// Token: 0x040008C5 RID: 2245
		private global::Base.AutoComboBox cmbQueue;

		// Token: 0x040008C6 RID: 2246
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem6;

		// Token: 0x040008C7 RID: 2247
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem4;
	}
}
