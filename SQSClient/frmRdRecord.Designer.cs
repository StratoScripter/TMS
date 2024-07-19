namespace SQSClient
{
	// Token: 0x02000047 RID: 71
	public partial class frmRdRecord : global::SQSClient.BaseDialogForm
	{
		// Token: 0x06000355 RID: 853 RVA: 0x0004FF2C File Offset: 0x0004E12C
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000356 RID: 854 RVA: 0x0004FF64 File Offset: 0x0004E164
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new global::System.Windows.Forms.DataGridViewCellStyle();
			this.contextMenuStrip = new global::System.Windows.Forms.ContextMenuStrip(this.components);
			this.toolReceiptCapture = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolCheckRequest = new global::System.Windows.Forms.ToolStripMenuItem();
			this.pnlConfig = new global::DevComponents.DotNetBar.Controls.GroupPanel();
			this.labMessage = new global::DevComponents.DotNetBar.LabelX();
			this.layoutControl1 = new global::DevComponents.DotNetBar.Layout.LayoutControl();
			this.dtpDate = new global::DevComponents.Editors.DateTimeAdv.DateTimeInput();
			this.cmbRdStatus = new global::DevComponents.DotNetBar.Controls.ComboBoxEx();
			this.cmbWhName = new global::Base.AutoComboBox();
			this.cmbProduct = new global::Base.AutoComboBox();
			this.txtRdCode = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.btnQuery = new global::DevComponents.DotNetBar.ButtonX();
			this.chkIsUseDate = new global::DevComponents.DotNetBar.Controls.CheckBoxX();
			this.cmbRdFlag = new global::DevComponents.DotNetBar.Controls.ComboBoxEx();
			this.cmbBusType = new global::DevComponents.DotNetBar.Controls.ComboBoxEx();
			this.layoutControlItem1 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem9 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem2 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem10 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem3 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem5 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem6 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem7 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem8 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.panelEx1 = new global::DevComponents.DotNetBar.PanelEx();
			this.labCount = new global::DevComponents.DotNetBar.LabelX();
			this.bar = new global::DevComponents.DotNetBar.Bar();
			this.btnAddRd = new global::DevComponents.DotNetBar.ButtonItem();
			this.btnModifyRd = new global::DevComponents.DotNetBar.ButtonItem();
			this.btnDeleteRd = new global::DevComponents.DotNetBar.ButtonItem();
			this.btnPrintRd = new global::DevComponents.DotNetBar.ButtonItem();
			this.btnSettleStockRd = new global::DevComponents.DotNetBar.ButtonItem();
			this.btnAdjustRd = new global::DevComponents.DotNetBar.ButtonItem();
			this.btnItemCRd = new global::DevComponents.DotNetBar.ButtonItem();
			this.gPanelToRdRecords = new global::DevComponents.DotNetBar.Controls.GroupPanel();
			this.splitContainer1 = new global::System.Windows.Forms.SplitContainer();
			this.dgvRecordMain = new global::DevComponents.DotNetBar.Controls.DataGridViewX();
			this.dataGridViewTextBoxColumn1 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_RdIndex = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_RdCode = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_VouchType = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_BusType = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_Source = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_WhCode = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_DepName = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_RdPerson = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_DLCode = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_Maker = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_Handler = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_Accounter = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_RdStatus = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgvData = new global::DevComponents.DotNetBar.Controls.DataGridViewX();
			this.C_Id = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_RecordIndex = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_BillSort = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_InvCode = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_ProductName = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_ProductCode = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_BatchNum = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_Quantity = new global::DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn();
			this.C_SpecsDanWei = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_PositionInfo = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_CreateDate = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_ExtBarCode = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_RdsStatus = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_RdsState = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.barDetail = new global::DevComponents.DotNetBar.Bar();
			this.btnStockSettle = new global::DevComponents.DotNetBar.ButtonItem();
			this.btnPrint = new global::DevComponents.DotNetBar.ButtonItem();
			this.btnBatchAbnormal = new global::DevComponents.DotNetBar.ButtonItem();
			this.btnClearEBX = new global::DevComponents.DotNetBar.ButtonItem();
			this.btnTicketDelete = new global::DevComponents.DotNetBar.ButtonItem();
			this.buttonItem1 = new global::DevComponents.DotNetBar.ButtonItem();
			this.btnAddRds = new global::DevComponents.DotNetBar.ButtonItem();
			this.btnModifyRds = new global::DevComponents.DotNetBar.ButtonItem();
			this.btnDeleteRds = new global::DevComponents.DotNetBar.ButtonItem();
			this.contextMenuStrip.SuspendLayout();
			this.pnlConfig.SuspendLayout();
			this.layoutControl1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dtpDate).BeginInit();
			this.panelEx1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.bar).BeginInit();
			this.gPanelToRdRecords.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.splitContainer1).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvRecordMain).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.dgvData).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.barDetail).BeginInit();
			base.SuspendLayout();
			this.contextMenuStrip.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.toolReceiptCapture,
				this.toolCheckRequest
			});
			this.contextMenuStrip.Name = "contextMenuStrip1";
			this.contextMenuStrip.Size = new global::System.Drawing.Size(166, 48);
			this.toolReceiptCapture.Name = "toolReceiptCapture";
			this.toolReceiptCapture.Size = new global::System.Drawing.Size(165, 22);
			this.toolReceiptCapture.Text = "ReceiptCapture";
			this.toolReceiptCapture.Click += new global::System.EventHandler(this.toolReceiptCapture_Click);
			this.toolCheckRequest.Name = "toolCheckRequest";
			this.toolCheckRequest.Size = new global::System.Drawing.Size(165, 22);
			this.toolCheckRequest.Text = "CheckRequest";
			this.toolCheckRequest.Click += new global::System.EventHandler(this.toolCheckRequest_Click);
			this.pnlConfig.CanvasColor = global::System.Drawing.SystemColors.Control;
			this.pnlConfig.ColorSchemeStyle = global::DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
			this.pnlConfig.Controls.Add(this.labMessage);
			this.pnlConfig.Controls.Add(this.layoutControl1);
			this.pnlConfig.Controls.Add(this.panelEx1);
			this.pnlConfig.DisabledBackColor = global::System.Drawing.Color.Empty;
			this.pnlConfig.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.pnlConfig.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.pnlConfig.Location = new global::System.Drawing.Point(0, 27);
			this.pnlConfig.Name = "pnlConfig";
			this.pnlConfig.Size = new global::System.Drawing.Size(1305, 70);
			this.pnlConfig.Style.BackColor2SchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
			this.pnlConfig.Style.BackColorGradientAngle = 90;
			this.pnlConfig.Style.BackColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
			this.pnlConfig.Style.BorderBottom = global::DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.pnlConfig.Style.BorderBottomWidth = 1;
			this.pnlConfig.Style.BorderColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
			this.pnlConfig.Style.BorderLeft = global::DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.pnlConfig.Style.BorderLeftWidth = 1;
			this.pnlConfig.Style.BorderRight = global::DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.pnlConfig.Style.BorderRightWidth = 1;
			this.pnlConfig.Style.BorderTop = global::DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.pnlConfig.Style.BorderTopWidth = 1;
			this.pnlConfig.Style.CornerDiameter = 4;
			this.pnlConfig.Style.CornerType = global::DevComponents.DotNetBar.eCornerType.Rounded;
			this.pnlConfig.Style.TextAlignment = global::DevComponents.DotNetBar.eStyleTextAlignment.Center;
			this.pnlConfig.Style.TextColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelText;
			this.pnlConfig.Style.TextLineAlignment = global::DevComponents.DotNetBar.eStyleTextAlignment.Near;
			this.pnlConfig.StyleMouseDown.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.pnlConfig.StyleMouseOver.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.pnlConfig.TabIndex = 5;
			this.labMessage.BackColor = global::System.Drawing.Color.Transparent;
			this.labMessage.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.labMessage.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.labMessage.Font = new global::System.Drawing.Font("宋体", 14f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 134);
			this.labMessage.ForeColor = global::System.Drawing.Color.Red;
			this.labMessage.Location = new global::System.Drawing.Point(941, 0);
			this.labMessage.Name = "labMessage";
			this.labMessage.Size = new global::System.Drawing.Size(257, 64);
			this.labMessage.TabIndex = 51;
			this.labMessage.TextAlignment = global::System.Drawing.StringAlignment.Center;
			this.labMessage.WordWrap = true;
			this.layoutControl1.BackColor = global::System.Drawing.Color.Transparent;
			this.layoutControl1.Controls.Add(this.dtpDate);
			this.layoutControl1.Controls.Add(this.cmbRdStatus);
			this.layoutControl1.Controls.Add(this.cmbWhName);
			this.layoutControl1.Controls.Add(this.cmbProduct);
			this.layoutControl1.Controls.Add(this.txtRdCode);
			this.layoutControl1.Controls.Add(this.btnQuery);
			this.layoutControl1.Controls.Add(this.chkIsUseDate);
			this.layoutControl1.Controls.Add(this.cmbRdFlag);
			this.layoutControl1.Controls.Add(this.cmbBusType);
			this.layoutControl1.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.layoutControl1.Location = new global::System.Drawing.Point(0, 0);
			this.layoutControl1.Name = "layoutControl1";
			this.layoutControl1.RootGroup.Items.AddRange(new global::DevComponents.DotNetBar.Layout.LayoutItemBase[]
			{
				this.layoutControlItem1,
				this.layoutControlItem9,
				this.layoutControlItem2,
				this.layoutControlItem10,
				this.layoutControlItem3,
				this.layoutControlItem5,
				this.layoutControlItem6,
				this.layoutControlItem7,
				this.layoutControlItem8
			});
			this.layoutControl1.Size = new global::System.Drawing.Size(941, 64);
			this.layoutControl1.TabIndex = 47;
			this.dtpDate.BackgroundStyle.Class = "DateTimeInputBackground";
			this.dtpDate.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.dtpDate.ButtonDropDown.Shortcut = global::DevComponents.DotNetBar.eShortcut.AltDown;
			this.dtpDate.ButtonDropDown.Visible = true;
			this.dtpDate.CustomFormat = "yyyy-MM-dd";
			this.dtpDate.Format = global::DevComponents.Editors.eDateTimePickerFormat.Custom;
			this.dtpDate.IsPopupCalendarOpen = false;
			this.dtpDate.Location = new global::System.Drawing.Point(61, 4);
			this.dtpDate.Margin = new global::System.Windows.Forms.Padding(0);
			this.dtpDate.MonthCalendar.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.dtpDate.MonthCalendar.CalendarDimensions = new global::System.Drawing.Size(1, 1);
			this.dtpDate.MonthCalendar.ClearButtonVisible = true;
			this.dtpDate.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = global::DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
			this.dtpDate.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
			this.dtpDate.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.BarBackground;
			this.dtpDate.MonthCalendar.CommandsBackgroundStyle.BorderTop = global::DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.dtpDate.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
			this.dtpDate.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
			this.dtpDate.MonthCalendar.CommandsBackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.dtpDate.MonthCalendar.DisplayMonth = new global::System.DateTime(2016, 6, 1, 0, 0, 0, 0);
			this.dtpDate.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
			this.dtpDate.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
			this.dtpDate.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
			this.dtpDate.MonthCalendar.NavigationBackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.dtpDate.MonthCalendar.TodayButtonVisible = true;
			this.dtpDate.Name = "dtpDate";
			this.dtpDate.Size = new global::System.Drawing.Size(142, 21);
			this.dtpDate.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.dtpDate.TabIndex = 0;
			this.cmbRdStatus.DisplayMember = "Text";
			this.cmbRdStatus.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cmbRdStatus.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbRdStatus.FormattingEnabled = true;
			this.cmbRdStatus.ItemHeight = 15;
			this.cmbRdStatus.Location = new global::System.Drawing.Point(343, 4);
			this.cmbRdStatus.Margin = new global::System.Windows.Forms.Padding(0);
			this.cmbRdStatus.Name = "cmbRdStatus";
			this.cmbRdStatus.Size = new global::System.Drawing.Size(123, 21);
			this.cmbRdStatus.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.cmbRdStatus.TabIndex = 2;
			this.cmbWhName.DataSource = null;
			this.cmbWhName.DisplayMember = null;
			this.cmbWhName.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cmbWhName.FormattingEnabled = true;
			this.cmbWhName.ItemHeight = 15;
			this.cmbWhName.Location = new global::System.Drawing.Point(61, 33);
			this.cmbWhName.Margin = new global::System.Windows.Forms.Padding(0);
			this.cmbWhName.MaxDropDownItems = 20;
			this.cmbWhName.Name = "cmbWhName";
			this.cmbWhName.SelectMember = null;
			this.cmbWhName.Size = new global::System.Drawing.Size(217, 21);
			this.cmbWhName.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.cmbWhName.TabIndex = 5;
			this.cmbWhName.ValueMember = null;
			this.cmbProduct.DataSource = null;
			this.cmbProduct.DisplayMember = null;
			this.cmbProduct.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cmbProduct.FormattingEnabled = true;
			this.cmbProduct.ItemHeight = 17;
			this.cmbProduct.Location = new global::System.Drawing.Point(343, 33);
			this.cmbProduct.Margin = new global::System.Windows.Forms.Padding(0);
			this.cmbProduct.MaxDropDownItems = 20;
			this.cmbProduct.Name = "cmbProduct";
			this.cmbProduct.SelectMember = null;
			this.cmbProduct.Size = new global::System.Drawing.Size(217, 23);
			this.cmbProduct.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.cmbProduct.TabIndex = 6;
			this.cmbProduct.ValueMember = null;
			this.txtRdCode.Border.Class = "TextBoxBorder";
			this.txtRdCode.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtRdCode.Location = new global::System.Drawing.Point(625, 33);
			this.txtRdCode.Margin = new global::System.Windows.Forms.Padding(0);
			this.txtRdCode.Name = "txtRdCode";
			this.txtRdCode.PreventEnterBeep = true;
			this.txtRdCode.Size = new global::System.Drawing.Size(217, 21);
			this.txtRdCode.TabIndex = 7;
			this.btnQuery.AccessibleRole = global::System.Windows.Forms.AccessibleRole.PushButton;
			this.btnQuery.ColorTable = global::DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.btnQuery.Location = new global::System.Drawing.Point(850, 33);
			this.btnQuery.Margin = new global::System.Windows.Forms.Padding(0);
			this.btnQuery.Name = "btnQuery";
			this.btnQuery.Size = new global::System.Drawing.Size(87, 23);
			this.btnQuery.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.btnQuery.TabIndex = 8;
			this.btnQuery.Text = "Search";
			this.btnQuery.Click += new global::System.EventHandler(this.btnQuery_Click);
			this.chkIsUseDate.AutoSize = true;
			this.chkIsUseDate.BackColor = global::System.Drawing.Color.Transparent;
			this.chkIsUseDate.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.chkIsUseDate.Checked = true;
			this.chkIsUseDate.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.chkIsUseDate.CheckValue = "Y";
			this.chkIsUseDate.Location = new global::System.Drawing.Point(211, 4);
			this.chkIsUseDate.Margin = new global::System.Windows.Forms.Padding(0);
			this.chkIsUseDate.Name = "chkIsUseDate";
			this.chkIsUseDate.Size = new global::System.Drawing.Size(64, 16);
			this.chkIsUseDate.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.chkIsUseDate.TabIndex = 1;
			this.chkIsUseDate.Text = "Enable";
			this.cmbRdFlag.DisplayMember = "Text";
			this.cmbRdFlag.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cmbRdFlag.FormattingEnabled = true;
			this.cmbRdFlag.ItemHeight = 15;
			this.cmbRdFlag.Location = new global::System.Drawing.Point(531, 4);
			this.cmbRdFlag.Margin = new global::System.Windows.Forms.Padding(0);
			this.cmbRdFlag.Name = "cmbRdFlag";
			this.cmbRdFlag.Size = new global::System.Drawing.Size(123, 21);
			this.cmbRdFlag.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.cmbRdFlag.TabIndex = 3;
			this.cmbBusType.DisplayMember = "Text";
			this.cmbBusType.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cmbBusType.FormattingEnabled = true;
			this.cmbBusType.ItemHeight = 15;
			this.cmbBusType.Location = new global::System.Drawing.Point(719, 4);
			this.cmbBusType.Margin = new global::System.Windows.Forms.Padding(0);
			this.cmbBusType.Name = "cmbBusType";
			this.cmbBusType.Size = new global::System.Drawing.Size(123, 21);
			this.cmbBusType.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.cmbBusType.TabIndex = 4;
			this.layoutControlItem1.Control = this.dtpDate;
			this.layoutControlItem1.Height = 29;
			this.layoutControlItem1.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Text = "Date";
			this.layoutControlItem1.Width = 22;
			this.layoutControlItem1.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem9.Control = this.chkIsUseDate;
			this.layoutControlItem9.Height = 26;
			this.layoutControlItem9.MinSize = new global::System.Drawing.Size(50, 18);
			this.layoutControlItem9.Name = "layoutControlItem9";
			this.layoutControlItem9.Width = 8;
			this.layoutControlItem9.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem2.Control = this.cmbRdStatus;
			this.layoutControlItem2.Height = 29;
			this.layoutControlItem2.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem2.Name = "layoutControlItem2";
			this.layoutControlItem2.Text = "RdStatus";
			this.layoutControlItem2.Width = 20;
			this.layoutControlItem2.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem10.Control = this.cmbRdFlag;
			this.layoutControlItem10.Height = 29;
			this.layoutControlItem10.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem10.Name = "layoutControlItem10";
			this.layoutControlItem10.Text = "RdFlag";
			this.layoutControlItem10.Width = 20;
			this.layoutControlItem10.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem3.Control = this.cmbBusType;
			this.layoutControlItem3.Height = 29;
			this.layoutControlItem3.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem3.Name = "layoutControlItem3";
			this.layoutControlItem3.Text = "BusType";
			this.layoutControlItem3.Width = 20;
			this.layoutControlItem3.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem5.Control = this.cmbWhName;
			this.layoutControlItem5.Height = 29;
			this.layoutControlItem5.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem5.Name = "layoutControlItem5";
			this.layoutControlItem5.Text = "WhName";
			this.layoutControlItem5.Width = 30;
			this.layoutControlItem5.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem6.Control = this.cmbProduct;
			this.layoutControlItem6.Height = 31;
			this.layoutControlItem6.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem6.Name = "layoutControlItem6";
			this.layoutControlItem6.Text = "Product";
			this.layoutControlItem6.Width = 30;
			this.layoutControlItem6.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem7.Control = this.txtRdCode;
			this.layoutControlItem7.Height = 29;
			this.layoutControlItem7.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem7.Name = "layoutControlItem7";
			this.layoutControlItem7.Text = "RdCode";
			this.layoutControlItem7.Width = 30;
			this.layoutControlItem7.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem8.Control = this.btnQuery;
			this.layoutControlItem8.Height = 31;
			this.layoutControlItem8.MinSize = new global::System.Drawing.Size(32, 20);
			this.layoutControlItem8.Name = "layoutControlItem8";
			this.layoutControlItem8.Width = 10;
			this.layoutControlItem8.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.panelEx1.CanvasColor = global::System.Drawing.SystemColors.Control;
			this.panelEx1.ColorSchemeStyle = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.panelEx1.Controls.Add(this.labCount);
			this.panelEx1.DisabledBackColor = global::System.Drawing.Color.Empty;
			this.panelEx1.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.panelEx1.Location = new global::System.Drawing.Point(1198, 0);
			this.panelEx1.Name = "panelEx1";
			this.panelEx1.Size = new global::System.Drawing.Size(101, 64);
			this.panelEx1.Style.Alignment = global::System.Drawing.StringAlignment.Center;
			this.panelEx1.Style.BackColor1.ColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
			this.panelEx1.Style.BackColor2.ColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
			this.panelEx1.Style.BorderColor.ColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
			this.panelEx1.Style.ForeColor.ColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelText;
			this.panelEx1.Style.GradientAngle = 90;
			this.panelEx1.TabIndex = 35;
			this.labCount.BackColor = global::System.Drawing.Color.Transparent;
			this.labCount.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.labCount.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.labCount.Location = new global::System.Drawing.Point(0, 46);
			this.labCount.Name = "labCount";
			this.labCount.Size = new global::System.Drawing.Size(101, 18);
			this.labCount.TabIndex = 35;
			this.labCount.Text = "Orders 0";
			this.labCount.TextAlignment = global::System.Drawing.StringAlignment.Center;
			this.bar.AntiAlias = true;
			this.bar.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.bar.Font = new global::System.Drawing.Font("微软雅黑", 9f);
			this.bar.IsMaximized = false;
			this.bar.Items.AddRange(new global::DevComponents.DotNetBar.BaseItem[]
			{
				this.btnAddRd,
				this.btnModifyRd,
				this.btnDeleteRd,
				this.btnPrintRd,
				this.btnSettleStockRd,
				this.btnAdjustRd,
				this.btnItemCRd
			});
			this.bar.Location = new global::System.Drawing.Point(0, 0);
			this.bar.Name = "bar";
			this.bar.Size = new global::System.Drawing.Size(1305, 27);
			this.bar.Stretch = true;
			this.bar.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.bar.TabIndex = 4;
			this.bar.TabStop = false;
			this.bar.Text = "bar1";
			this.btnAddRd.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.btnAddRd.Image = global::SQSClient.Properties.Resources.add16;
			this.btnAddRd.Name = "btnAddRd";
			this.btnAddRd.Text = "Add";
			this.btnAddRd.Click += new global::System.EventHandler(this.btnAddRd_Click);
			this.btnModifyRd.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.btnModifyRd.Image = global::SQSClient.Properties.Resources.modify16;
			this.btnModifyRd.Name = "btnModifyRd";
			this.btnModifyRd.Text = "Modify";
			this.btnModifyRd.Click += new global::System.EventHandler(this.btnModifyRd_Click);
			this.btnDeleteRd.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.btnDeleteRd.Image = global::SQSClient.Properties.Resources.delete16;
			this.btnDeleteRd.Name = "btnDeleteRd";
			this.btnDeleteRd.Text = "Delete";
			this.btnDeleteRd.Click += new global::System.EventHandler(this.btnDeleteRd_Click);
			this.btnPrintRd.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.btnPrintRd.Image = global::SQSClient.Properties.Resources.print16;
			this.btnPrintRd.Name = "btnPrintRd";
			this.btnPrintRd.Text = "Print";
			this.btnSettleStockRd.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.btnSettleStockRd.Image = global::SQSClient.Properties.Resources.settle16;
			this.btnSettleStockRd.Name = "btnSettleStockRd";
			this.btnSettleStockRd.Text = "SettleStock";
			this.btnSettleStockRd.Click += new global::System.EventHandler(this.btnSettleStockRd_Click);
			this.btnAdjustRd.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.btnAdjustRd.Image = global::SQSClient.Properties.Resources.adjust16;
			this.btnAdjustRd.ItemAlignment = global::DevComponents.DotNetBar.eItemAlignment.Far;
			this.btnAdjustRd.Name = "btnAdjustRd";
			this.btnAdjustRd.Text = "Adjust";
			this.btnItemCRd.Name = "btnItemCRd";
			this.btnItemCRd.Text = "ItemC";
			this.btnItemCRd.Click += new global::System.EventHandler(this.btnItemCRd_Click);
			this.gPanelToRdRecords.BackColor = global::System.Drawing.Color.Transparent;
			this.gPanelToRdRecords.CanvasColor = global::System.Drawing.SystemColors.Control;
			this.gPanelToRdRecords.ColorSchemeStyle = global::DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
			this.gPanelToRdRecords.Controls.Add(this.splitContainer1);
			this.gPanelToRdRecords.DisabledBackColor = global::System.Drawing.Color.Empty;
			this.gPanelToRdRecords.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.gPanelToRdRecords.Location = new global::System.Drawing.Point(0, 97);
			this.gPanelToRdRecords.Name = "gPanelToRdRecords";
			this.gPanelToRdRecords.Size = new global::System.Drawing.Size(1305, 479);
			this.gPanelToRdRecords.Style.BackColor2SchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
			this.gPanelToRdRecords.Style.BackColorGradientAngle = 90;
			this.gPanelToRdRecords.Style.BackColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
			this.gPanelToRdRecords.Style.BorderBottom = global::DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.gPanelToRdRecords.Style.BorderBottomWidth = 1;
			this.gPanelToRdRecords.Style.BorderColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
			this.gPanelToRdRecords.Style.BorderLeft = global::DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.gPanelToRdRecords.Style.BorderLeftWidth = 1;
			this.gPanelToRdRecords.Style.BorderRight = global::DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.gPanelToRdRecords.Style.BorderRightWidth = 1;
			this.gPanelToRdRecords.Style.BorderTop = global::DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.gPanelToRdRecords.Style.BorderTopWidth = 1;
			this.gPanelToRdRecords.Style.CornerDiameter = 4;
			this.gPanelToRdRecords.Style.CornerType = global::DevComponents.DotNetBar.eCornerType.Rounded;
			this.gPanelToRdRecords.Style.TextAlignment = global::DevComponents.DotNetBar.eStyleTextAlignment.Center;
			this.gPanelToRdRecords.Style.TextColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelText;
			this.gPanelToRdRecords.Style.TextLineAlignment = global::DevComponents.DotNetBar.eStyleTextAlignment.Near;
			this.gPanelToRdRecords.StyleMouseDown.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.gPanelToRdRecords.StyleMouseOver.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.gPanelToRdRecords.TabIndex = 6;
			this.gPanelToRdRecords.Text = "ToRdRecords";
			this.splitContainer1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new global::System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = global::System.Windows.Forms.Orientation.Horizontal;
			this.splitContainer1.Panel1.Controls.Add(this.dgvRecordMain);
			this.splitContainer1.Panel2.Controls.Add(this.dgvData);
			this.splitContainer1.Panel2.Controls.Add(this.barDetail);
			this.splitContainer1.Size = new global::System.Drawing.Size(1299, 457);
			this.splitContainer1.SplitterDistance = 213;
			this.splitContainer1.TabIndex = 0;
			this.dgvRecordMain.AllowUserToAddRows = false;
			this.dgvRecordMain.AllowUserToDeleteRows = false;
			this.dgvRecordMain.AutoSizeColumnsMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvRecordMain.AutoSizeRowsMode = global::System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			dataGridViewCellStyle.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle.BackColor = global::System.Drawing.SystemColors.Control;
			dataGridViewCellStyle.Font = new global::System.Drawing.Font("宋体", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 134);
			dataGridViewCellStyle.ForeColor = global::System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle.SelectionBackColor = global::System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle.SelectionForeColor = global::System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle.WrapMode = global::System.Windows.Forms.DataGridViewTriState.True;
			this.dgvRecordMain.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
			this.dgvRecordMain.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dgvRecordMain.Columns.AddRange(new global::System.Windows.Forms.DataGridViewColumn[]
			{
				this.dataGridViewTextBoxColumn1,
				this.C_RdIndex,
				this.C_RdCode,
				this.C_VouchType,
				this.C_BusType,
				this.C_Source,
				this.C_WhCode,
				this.C_DepName,
				this.C_RdPerson,
				this.C_DLCode,
				this.C_Maker,
				this.C_Handler,
				this.C_Accounter,
				this.C_RdStatus
			});
			dataGridViewCellStyle2.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = global::System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new global::System.Drawing.Font("宋体", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 134);
			dataGridViewCellStyle2.ForeColor = global::System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = global::System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = global::System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.WrapMode = global::System.Windows.Forms.DataGridViewTriState.False;
			this.dgvRecordMain.DefaultCellStyle = dataGridViewCellStyle2;
			this.dgvRecordMain.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.dgvRecordMain.EnableHeadersVisualStyles = false;
			this.dgvRecordMain.GridColor = global::System.Drawing.Color.FromArgb(208, 215, 229);
			this.dgvRecordMain.Location = new global::System.Drawing.Point(0, 0);
			this.dgvRecordMain.MultiSelect = false;
			this.dgvRecordMain.Name = "dgvRecordMain";
			this.dgvRecordMain.ReadOnly = true;
			dataGridViewCellStyle3.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = global::System.Drawing.SystemColors.Control;
			dataGridViewCellStyle3.Font = new global::System.Drawing.Font("宋体", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 134);
			dataGridViewCellStyle3.ForeColor = global::System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = global::System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = global::System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.WrapMode = global::System.Windows.Forms.DataGridViewTriState.True;
			this.dgvRecordMain.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.dgvRecordMain.RowHeadersVisible = false;
			this.dgvRecordMain.RowTemplate.Height = 23;
			this.dgvRecordMain.SelectionMode = global::System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvRecordMain.Size = new global::System.Drawing.Size(1299, 213);
			this.dgvRecordMain.TabIndex = 17;
			this.dgvRecordMain.CellClick += new global::System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRecordMain_CellClick);
			this.dgvRecordMain.CellDoubleClick += new global::System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRecordMain_CellDoubleClick);
			this.dgvRecordMain.SelectionChanged += new global::System.EventHandler(this.dgvRecordMain_SelectionChanged);
			this.dataGridViewTextBoxColumn1.FillWeight = 60f;
			this.dataGridViewTextBoxColumn1.HeaderText = "ID";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			this.dataGridViewTextBoxColumn1.Visible = false;
			this.C_RdIndex.FillWeight = 80f;
			this.C_RdIndex.HeaderText = "RdIndex";
			this.C_RdIndex.Name = "C_RdIndex";
			this.C_RdIndex.ReadOnly = true;
			this.C_RdIndex.Visible = false;
			this.C_RdCode.HeaderText = "RdCode";
			this.C_RdCode.Name = "C_RdCode";
			this.C_RdCode.ReadOnly = true;
			this.C_VouchType.HeaderText = "VouchType";
			this.C_VouchType.Name = "C_VouchType";
			this.C_VouchType.ReadOnly = true;
			this.C_BusType.HeaderText = "BusType";
			this.C_BusType.Name = "C_BusType";
			this.C_BusType.ReadOnly = true;
			this.C_Source.HeaderText = "Source";
			this.C_Source.Name = "C_Source";
			this.C_Source.ReadOnly = true;
			this.C_WhCode.HeaderText = "WhCode";
			this.C_WhCode.Name = "C_WhCode";
			this.C_WhCode.ReadOnly = true;
			this.C_DepName.HeaderText = "DepName";
			this.C_DepName.Name = "C_DepName";
			this.C_DepName.ReadOnly = true;
			this.C_RdPerson.HeaderText = "RdPerson";
			this.C_RdPerson.Name = "C_RdPerson";
			this.C_RdPerson.ReadOnly = true;
			this.C_DLCode.HeaderText = "DLCode";
			this.C_DLCode.Name = "C_DLCode";
			this.C_DLCode.ReadOnly = true;
			this.C_DLCode.Visible = false;
			this.C_Maker.HeaderText = "Maker";
			this.C_Maker.Name = "C_Maker";
			this.C_Maker.ReadOnly = true;
			this.C_Handler.HeaderText = "Handler";
			this.C_Handler.Name = "C_Handler";
			this.C_Handler.ReadOnly = true;
			this.C_Accounter.HeaderText = "Accounter";
			this.C_Accounter.Name = "C_Accounter";
			this.C_Accounter.ReadOnly = true;
			this.C_RdStatus.HeaderText = "RdStatus";
			this.C_RdStatus.Name = "C_RdStatus";
			this.C_RdStatus.ReadOnly = true;
			this.dgvData.AllowUserToAddRows = false;
			this.dgvData.AllowUserToDeleteRows = false;
			this.dgvData.AllowUserToResizeRows = false;
			this.dgvData.AutoSizeColumnsMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			dataGridViewCellStyle4.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle4.BackColor = global::System.Drawing.SystemColors.Control;
			dataGridViewCellStyle4.Font = new global::System.Drawing.Font("宋体", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 134);
			dataGridViewCellStyle4.ForeColor = global::System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle4.SelectionBackColor = global::System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = global::System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = global::System.Windows.Forms.DataGridViewTriState.True;
			this.dgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.dgvData.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dgvData.Columns.AddRange(new global::System.Windows.Forms.DataGridViewColumn[]
			{
				this.C_Id,
				this.C_RecordIndex,
				this.C_BillSort,
				this.C_InvCode,
				this.C_ProductName,
				this.C_ProductCode,
				this.C_BatchNum,
				this.C_Quantity,
				this.C_SpecsDanWei,
				this.C_PositionInfo,
				this.C_CreateDate,
				this.C_ExtBarCode,
				this.C_RdsStatus,
				this.C_RdsState
			});
			this.dgvData.ContextMenuStrip = this.contextMenuStrip;
			dataGridViewCellStyle5.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle5.BackColor = global::System.Drawing.SystemColors.Window;
			dataGridViewCellStyle5.Font = new global::System.Drawing.Font("宋体", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 134);
			dataGridViewCellStyle5.ForeColor = global::System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle5.SelectionBackColor = global::System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle5.SelectionForeColor = global::System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle5.WrapMode = global::System.Windows.Forms.DataGridViewTriState.False;
			this.dgvData.DefaultCellStyle = dataGridViewCellStyle5;
			this.dgvData.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.dgvData.EnableHeadersVisualStyles = false;
			this.dgvData.GridColor = global::System.Drawing.Color.FromArgb(208, 215, 229);
			this.dgvData.Location = new global::System.Drawing.Point(0, 27);
			this.dgvData.MultiSelect = false;
			this.dgvData.Name = "dgvData";
			this.dgvData.ReadOnly = true;
			this.dgvData.RowHeadersVisible = false;
			this.dgvData.RowTemplate.Height = 23;
			this.dgvData.SelectionMode = global::System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvData.Size = new global::System.Drawing.Size(1299, 213);
			this.dgvData.TabIndex = 19;
			this.dgvData.CellClick += new global::System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellClick);
			this.dgvData.CellDoubleClick += new global::System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellDoubleClick);
			this.dgvData.CellMouseDown += new global::System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvData_CellMouseDown);
			this.dgvData.SelectionChanged += new global::System.EventHandler(this.dgvData_SelectionChanged);
			this.C_Id.FillWeight = 82.8988f;
			this.C_Id.HeaderText = "ID";
			this.C_Id.Name = "C_Id";
			this.C_Id.ReadOnly = true;
			this.C_Id.Visible = false;
			this.C_RecordIndex.FillWeight = 82.8988f;
			this.C_RecordIndex.HeaderText = "RecordIndex";
			this.C_RecordIndex.Name = "C_RecordIndex";
			this.C_RecordIndex.ReadOnly = true;
			this.C_RecordIndex.Visible = false;
			this.C_BillSort.HeaderText = "BillSort";
			this.C_BillSort.Name = "C_BillSort";
			this.C_BillSort.ReadOnly = true;
			this.C_InvCode.HeaderText = "InvCode";
			this.C_InvCode.Name = "C_InvCode";
			this.C_InvCode.ReadOnly = true;
			this.C_ProductName.HeaderText = "ProductName";
			this.C_ProductName.Name = "C_ProductName";
			this.C_ProductName.ReadOnly = true;
			this.C_ProductCode.HeaderText = "ProductCode";
			this.C_ProductCode.Name = "C_ProductCode";
			this.C_ProductCode.ReadOnly = true;
			this.C_BatchNum.HeaderText = "BatchNum";
			this.C_BatchNum.Name = "C_BatchNum";
			this.C_BatchNum.ReadOnly = true;
			this.C_Quantity.BackgroundStyle.Class = "DataGridViewNumericBorder";
			this.C_Quantity.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.C_Quantity.FillWeight = 82.8988f;
			this.C_Quantity.HeaderText = "Quantity";
			this.C_Quantity.Increment = 1.0;
			this.C_Quantity.InputHorizontalAlignment = global::DevComponents.Editors.eHorizontalAlignment.Left;
			this.C_Quantity.Name = "C_Quantity";
			this.C_Quantity.ReadOnly = true;
			this.C_Quantity.Resizable = global::System.Windows.Forms.DataGridViewTriState.True;
			this.C_SpecsDanWei.HeaderText = "SpecsDanWei";
			this.C_SpecsDanWei.Name = "C_SpecsDanWei";
			this.C_SpecsDanWei.ReadOnly = true;
			this.C_PositionInfo.HeaderText = "PositionInfo";
			this.C_PositionInfo.Name = "C_PositionInfo";
			this.C_PositionInfo.ReadOnly = true;
			this.C_CreateDate.HeaderText = "CreateDate";
			this.C_CreateDate.Name = "C_CreateDate";
			this.C_CreateDate.ReadOnly = true;
			dataGridViewCellStyle6.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.C_ExtBarCode.DefaultCellStyle = dataGridViewCellStyle6;
			this.C_ExtBarCode.FillWeight = 82.8988f;
			this.C_ExtBarCode.HeaderText = "ExtBarCode";
			this.C_ExtBarCode.Name = "C_ExtBarCode";
			this.C_ExtBarCode.ReadOnly = true;
			this.C_RdsStatus.HeaderText = "RdsStatus";
			this.C_RdsStatus.Name = "C_RdsStatus";
			this.C_RdsStatus.ReadOnly = true;
			this.C_RdsState.HeaderText = "RdsState";
			this.C_RdsState.Name = "C_RdsState";
			this.C_RdsState.ReadOnly = true;
			this.barDetail.AntiAlias = true;
			this.barDetail.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.barDetail.Font = new global::System.Drawing.Font("微软雅黑", 9f);
			this.barDetail.IsMaximized = false;
			this.barDetail.Items.AddRange(new global::DevComponents.DotNetBar.BaseItem[]
			{
				this.btnAddRds,
				this.btnModifyRds,
				this.btnDeleteRds,
				this.btnStockSettle,
				this.btnPrint
			});
			this.barDetail.Location = new global::System.Drawing.Point(0, 0);
			this.barDetail.Name = "barDetail";
			this.barDetail.Size = new global::System.Drawing.Size(1299, 27);
			this.barDetail.Stretch = true;
			this.barDetail.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.barDetail.TabIndex = 5;
			this.barDetail.TabStop = false;
			this.barDetail.Text = "barDetail";
			this.btnStockSettle.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.btnStockSettle.Image = global::SQSClient.Properties.Resources.settle16;
			this.btnStockSettle.Name = "btnStockSettle";
			this.btnStockSettle.Text = "StockSettle";
			this.btnStockSettle.Click += new global::System.EventHandler(this.btnStockSettle_Click);
			this.btnPrint.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.btnPrint.Image = global::SQSClient.Properties.Resources.print16;
			this.btnPrint.Name = "btnPrint";
			this.btnPrint.Text = "Print";
			this.btnPrint.Visible = false;
			this.btnPrint.Click += new global::System.EventHandler(this.btnPrint_Click);
			this.btnBatchAbnormal.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.btnBatchAbnormal.Name = "btnBatchAbnormal";
			this.btnBatchAbnormal.Text = "载入批次异常单";
			this.btnClearEBX.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.btnClearEBX.Name = "btnClearEBX";
			this.btnClearEBX.Text = "鹤位清理";
			this.btnClearEBX.Tooltip = "按Shift键可批量选中装车记录";
			this.btnTicketDelete.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.btnTicketDelete.Name = "btnTicketDelete";
			this.btnTicketDelete.Text = "批量删除";
			this.btnTicketDelete.Tooltip = "按Shift键可批量选中装车记录";
			this.buttonItem1.ItemAlignment = global::DevComponents.DotNetBar.eItemAlignment.Far;
			this.buttonItem1.Name = "buttonItem1";
			this.buttonItem1.Text = "ItemC";
			this.btnAddRds.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.btnAddRds.Image = global::SQSClient.Properties.Resources.add16;
			this.btnAddRds.Name = "btnAddRds";
			this.btnAddRds.Text = "Add";
			this.btnAddRds.Click += new global::System.EventHandler(this.btnAddRds_Click);
			this.btnModifyRds.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.btnModifyRds.Image = global::SQSClient.Properties.Resources.modify16;
			this.btnModifyRds.Name = "btnModifyRds";
			this.btnModifyRds.Text = "Modify";
			this.btnModifyRds.Click += new global::System.EventHandler(this.btnModifyRds_Click);
			this.btnDeleteRds.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.btnDeleteRds.Image = global::SQSClient.Properties.Resources.delete16;
			this.btnDeleteRds.Name = "btnDeleteRds";
			this.btnDeleteRds.Text = "Delete";
			this.btnDeleteRds.Click += new global::System.EventHandler(this.btnDeleteRds_Click);
			base.ClientSize = new global::System.Drawing.Size(1305, 576);
			base.Controls.Add(this.gPanelToRdRecords);
			base.Controls.Add(this.pnlConfig);
			base.Controls.Add(this.bar);
			base.Name = "frmRdRecord";
			this.Text = "RdRecord";
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.frmRdRecord_FormClosing);
			base.Load += new global::System.EventHandler(this.frmRdRecord_Load);
			this.contextMenuStrip.ResumeLayout(false);
			this.pnlConfig.ResumeLayout(false);
			this.layoutControl1.ResumeLayout(false);
			this.layoutControl1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dtpDate).EndInit();
			this.panelEx1.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.bar).EndInit();
			this.gPanelToRdRecords.ResumeLayout(false);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.splitContainer1).EndInit();
			this.splitContainer1.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.dgvRecordMain).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.dgvData).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.barDetail).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000511 RID: 1297
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000512 RID: 1298
		private global::DevComponents.DotNetBar.Bar bar;

		// Token: 0x04000513 RID: 1299
		private global::DevComponents.DotNetBar.ButtonItem btnAddRd;

		// Token: 0x04000514 RID: 1300
		private global::DevComponents.DotNetBar.ButtonItem btnModifyRd;

		// Token: 0x04000515 RID: 1301
		private global::DevComponents.DotNetBar.ButtonItem btnDeleteRd;

		// Token: 0x04000516 RID: 1302
		private global::DevComponents.DotNetBar.ButtonItem btnSettleStockRd;

		// Token: 0x04000517 RID: 1303
		private global::DevComponents.DotNetBar.Controls.GroupPanel pnlConfig;

		// Token: 0x04000518 RID: 1304
		private global::DevComponents.DotNetBar.Controls.ComboBoxEx cmbRdStatus;

		// Token: 0x04000519 RID: 1305
		private global::DevComponents.DotNetBar.Controls.CheckBoxX chkIsUseDate;

		// Token: 0x0400051A RID: 1306
		private global::DevComponents.DotNetBar.ButtonX btnQuery;

		// Token: 0x0400051B RID: 1307
		private global::DevComponents.Editors.DateTimeAdv.DateTimeInput dtpDate;

		// Token: 0x0400051C RID: 1308
		private global::DevComponents.DotNetBar.ButtonItem btnPrintRd;

		// Token: 0x0400051D RID: 1309
		private global::Base.AutoComboBox cmbWhName;

		// Token: 0x0400051E RID: 1310
		private global::DevComponents.DotNetBar.PanelEx panelEx1;

		// Token: 0x0400051F RID: 1311
		private global::DevComponents.DotNetBar.LabelX labCount;

		// Token: 0x04000520 RID: 1312
		private global::Base.AutoComboBox cmbProduct;

		// Token: 0x04000521 RID: 1313
		private global::DevComponents.DotNetBar.ButtonItem btnAdjustRd;

		// Token: 0x04000522 RID: 1314
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtRdCode;

		// Token: 0x04000523 RID: 1315
		private global::DevComponents.DotNetBar.Layout.LayoutControl layoutControl1;

		// Token: 0x04000524 RID: 1316
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem1;

		// Token: 0x04000525 RID: 1317
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem2;

		// Token: 0x04000526 RID: 1318
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem9;

		// Token: 0x04000527 RID: 1319
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem5;

		// Token: 0x04000528 RID: 1320
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem6;

		// Token: 0x04000529 RID: 1321
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem7;

		// Token: 0x0400052A RID: 1322
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem8;

		// Token: 0x0400052B RID: 1323
		private global::System.Windows.Forms.ContextMenuStrip contextMenuStrip;

		// Token: 0x0400052C RID: 1324
		private global::System.Windows.Forms.ToolStripMenuItem toolReceiptCapture;

		// Token: 0x0400052D RID: 1325
		private global::DevComponents.DotNetBar.Controls.ComboBoxEx cmbRdFlag;

		// Token: 0x0400052E RID: 1326
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem10;

		// Token: 0x0400052F RID: 1327
		private global::DevComponents.DotNetBar.ButtonItem btnItemCRd;

		// Token: 0x04000530 RID: 1328
		private global::DevComponents.DotNetBar.LabelX labMessage;

		// Token: 0x04000531 RID: 1329
		private global::System.Windows.Forms.ToolStripMenuItem toolCheckRequest;

		// Token: 0x04000532 RID: 1330
		private global::DevComponents.DotNetBar.Controls.GroupPanel gPanelToRdRecords;

		// Token: 0x04000533 RID: 1331
		private global::System.Windows.Forms.SplitContainer splitContainer1;

		// Token: 0x04000534 RID: 1332
		private global::DevComponents.DotNetBar.Controls.DataGridViewX dgvRecordMain;

		// Token: 0x04000535 RID: 1333
		private global::DevComponents.DotNetBar.ButtonItem btnBatchAbnormal;

		// Token: 0x04000536 RID: 1334
		private global::DevComponents.DotNetBar.ButtonItem btnClearEBX;

		// Token: 0x04000537 RID: 1335
		private global::DevComponents.DotNetBar.ButtonItem btnTicketDelete;

		// Token: 0x04000538 RID: 1336
		private global::DevComponents.DotNetBar.ButtonItem buttonItem1;

		// Token: 0x04000539 RID: 1337
		private global::DevComponents.DotNetBar.Bar barDetail;

		// Token: 0x0400053A RID: 1338
		private global::DevComponents.DotNetBar.ButtonItem btnPrint;

		// Token: 0x0400053B RID: 1339
		private global::DevComponents.DotNetBar.ButtonItem btnStockSettle;

		// Token: 0x0400053C RID: 1340
		private global::DevComponents.DotNetBar.Controls.ComboBoxEx cmbBusType;

		// Token: 0x0400053D RID: 1341
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem3;

		// Token: 0x0400053E RID: 1342
		private global::System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;

		// Token: 0x0400053F RID: 1343
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_RdIndex;

		// Token: 0x04000540 RID: 1344
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_RdCode;

		// Token: 0x04000541 RID: 1345
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_VouchType;

		// Token: 0x04000542 RID: 1346
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_BusType;

		// Token: 0x04000543 RID: 1347
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_Source;

		// Token: 0x04000544 RID: 1348
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_WhCode;

		// Token: 0x04000545 RID: 1349
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_DepName;

		// Token: 0x04000546 RID: 1350
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_RdPerson;

		// Token: 0x04000547 RID: 1351
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_DLCode;

		// Token: 0x04000548 RID: 1352
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_Maker;

		// Token: 0x04000549 RID: 1353
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_Handler;

		// Token: 0x0400054A RID: 1354
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_Accounter;

		// Token: 0x0400054B RID: 1355
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_RdStatus;

		// Token: 0x0400054C RID: 1356
		private global::DevComponents.DotNetBar.Controls.DataGridViewX dgvData;

		// Token: 0x0400054D RID: 1357
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_Id;

		// Token: 0x0400054E RID: 1358
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_RecordIndex;

		// Token: 0x0400054F RID: 1359
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_BillSort;

		// Token: 0x04000550 RID: 1360
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_InvCode;

		// Token: 0x04000551 RID: 1361
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_ProductName;

		// Token: 0x04000552 RID: 1362
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_ProductCode;

		// Token: 0x04000553 RID: 1363
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_BatchNum;

		// Token: 0x04000554 RID: 1364
		private global::DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn C_Quantity;

		// Token: 0x04000555 RID: 1365
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_SpecsDanWei;

		// Token: 0x04000556 RID: 1366
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_PositionInfo;

		// Token: 0x04000557 RID: 1367
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_CreateDate;

		// Token: 0x04000558 RID: 1368
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_ExtBarCode;

		// Token: 0x04000559 RID: 1369
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_RdsStatus;

		// Token: 0x0400055A RID: 1370
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_RdsState;

		// Token: 0x0400055B RID: 1371
		private global::DevComponents.DotNetBar.ButtonItem btnAddRds;

		// Token: 0x0400055C RID: 1372
		private global::DevComponents.DotNetBar.ButtonItem btnModifyRds;

		// Token: 0x0400055D RID: 1373
		private global::DevComponents.DotNetBar.ButtonItem btnDeleteRds;
	}
}
