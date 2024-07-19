namespace SQSClient
{
	// Token: 0x0200004A RID: 74
	public partial class frmRdRecordTicket : global::SQSClient.BaseDialogForm
	{
		// Token: 0x0600039C RID: 924 RVA: 0x00058C20 File Offset: 0x00056E20
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600039D RID: 925 RVA: 0x00058C58 File Offset: 0x00056E58
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
			this.C_DanHao = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_ContractID = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_BusinessType = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_Clientpart = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_CheNum = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_Unit = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_Product = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_JiHuaLiang = new global::DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn();
			this.C_ShiJiLiang = new global::DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn();
			this.C_FirstWeight = new global::DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn();
			this.C_SecondWeight = new global::DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn();
			this.C_DifferWeight = new global::DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn();
			this.C_DanWei = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_OrderStatus = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_LabStatus = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_LabResult = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_LabMan = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_LabTime = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_LabCount = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_BatchCode = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_QuantityBatch = new global::DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn();
			this.C_BatchState = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_Remark = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.barDetail = new global::DevComponents.DotNetBar.Bar();
			this.btnImportBill = new global::DevComponents.DotNetBar.ButtonItem();
			this.btnRemoveBill = new global::DevComponents.DotNetBar.ButtonItem();
			this.btnStockSettle = new global::DevComponents.DotNetBar.ButtonItem();
			this.btnPrint = new global::DevComponents.DotNetBar.ButtonItem();
			this.btnBatchAbnormal = new global::DevComponents.DotNetBar.ButtonItem();
			this.btnClearEBX = new global::DevComponents.DotNetBar.ButtonItem();
			this.btnTicketDelete = new global::DevComponents.DotNetBar.ButtonItem();
			this.buttonItem1 = new global::DevComponents.DotNetBar.ButtonItem();
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
			this.btnSettleStockRd.Visible = false;
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
				this.C_DanHao,
				this.C_ContractID,
				this.C_BusinessType,
				this.C_Clientpart,
				this.C_CheNum,
				this.C_Unit,
				this.C_Product,
				this.C_JiHuaLiang,
				this.C_ShiJiLiang,
				this.C_FirstWeight,
				this.C_SecondWeight,
				this.C_DifferWeight,
				this.C_DanWei,
				this.C_OrderStatus,
				this.C_LabStatus,
				this.C_LabResult,
				this.C_LabMan,
				this.C_LabTime,
				this.C_LabCount,
				this.C_BatchCode,
				this.C_QuantityBatch,
				this.C_BatchState,
				this.C_Remark
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
			this.C_DanHao.FillWeight = 82.8988f;
			this.C_DanHao.HeaderText = "DanHao";
			this.C_DanHao.Name = "C_DanHao";
			this.C_DanHao.ReadOnly = true;
			this.C_ContractID.HeaderText = "ContractID";
			this.C_ContractID.Name = "C_ContractID";
			this.C_ContractID.ReadOnly = true;
			this.C_BusinessType.HeaderText = "BusinessType";
			this.C_BusinessType.Name = "C_BusinessType";
			this.C_BusinessType.ReadOnly = true;
			this.C_Clientpart.HeaderText = "Clientpart";
			this.C_Clientpart.Name = "C_Clientpart";
			this.C_Clientpart.ReadOnly = true;
			this.C_CheNum.FillWeight = 82.8988f;
			this.C_CheNum.HeaderText = "CheNum";
			this.C_CheNum.Name = "C_CheNum";
			this.C_CheNum.ReadOnly = true;
			this.C_Unit.HeaderText = "Unit";
			this.C_Unit.Name = "C_Unit";
			this.C_Unit.ReadOnly = true;
			this.C_Product.HeaderText = "Product";
			this.C_Product.Name = "C_Product";
			this.C_Product.ReadOnly = true;
			this.C_JiHuaLiang.BackgroundStyle.Class = "DataGridViewNumericBorder";
			this.C_JiHuaLiang.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.C_JiHuaLiang.FillWeight = 82.8988f;
			this.C_JiHuaLiang.HeaderText = "JiHuaLiang";
			this.C_JiHuaLiang.Increment = 1.0;
			this.C_JiHuaLiang.InputHorizontalAlignment = global::DevComponents.Editors.eHorizontalAlignment.Left;
			this.C_JiHuaLiang.Name = "C_JiHuaLiang";
			this.C_JiHuaLiang.ReadOnly = true;
			this.C_JiHuaLiang.Resizable = global::System.Windows.Forms.DataGridViewTriState.True;
			this.C_ShiJiLiang.BackgroundStyle.Class = "DataGridViewNumericBorder";
			this.C_ShiJiLiang.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.C_ShiJiLiang.FillWeight = 82.8988f;
			this.C_ShiJiLiang.HeaderText = "ShiJiLiang";
			this.C_ShiJiLiang.Increment = 1.0;
			this.C_ShiJiLiang.InputHorizontalAlignment = global::DevComponents.Editors.eHorizontalAlignment.Left;
			this.C_ShiJiLiang.Name = "C_ShiJiLiang";
			this.C_ShiJiLiang.ReadOnly = true;
			this.C_ShiJiLiang.Resizable = global::System.Windows.Forms.DataGridViewTriState.True;
			this.C_FirstWeight.BackgroundStyle.Class = "DataGridViewNumericBorder";
			this.C_FirstWeight.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.C_FirstWeight.HeaderText = "FirstWeight(kg)";
			this.C_FirstWeight.Increment = 1.0;
			this.C_FirstWeight.Name = "C_FirstWeight";
			this.C_FirstWeight.ReadOnly = true;
			this.C_SecondWeight.BackgroundStyle.Class = "DataGridViewNumericBorder";
			this.C_SecondWeight.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.C_SecondWeight.HeaderText = "SecondWeight(kg)";
			this.C_SecondWeight.Increment = 1.0;
			this.C_SecondWeight.Name = "C_SecondWeight";
			this.C_SecondWeight.ReadOnly = true;
			this.C_DifferWeight.BackgroundStyle.Class = "DataGridViewNumericBorder";
			this.C_DifferWeight.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.C_DifferWeight.HeaderText = "DifferWeight(kg)";
			this.C_DifferWeight.Increment = 1.0;
			this.C_DifferWeight.InputHorizontalAlignment = global::DevComponents.Editors.eHorizontalAlignment.Left;
			this.C_DifferWeight.Name = "C_DifferWeight";
			this.C_DifferWeight.ReadOnly = true;
			this.C_DifferWeight.Resizable = global::System.Windows.Forms.DataGridViewTriState.True;
			this.C_DanWei.HeaderText = "DanWei";
			this.C_DanWei.Name = "C_DanWei";
			this.C_DanWei.ReadOnly = true;
			dataGridViewCellStyle6.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.C_OrderStatus.DefaultCellStyle = dataGridViewCellStyle6;
			this.C_OrderStatus.FillWeight = 82.8988f;
			this.C_OrderStatus.HeaderText = "OrderStatus";
			this.C_OrderStatus.Name = "C_OrderStatus";
			this.C_OrderStatus.ReadOnly = true;
			this.C_LabStatus.HeaderText = "LabStatus";
			this.C_LabStatus.Name = "C_LabStatus";
			this.C_LabStatus.ReadOnly = true;
			this.C_LabResult.HeaderText = "LabResult";
			this.C_LabResult.Name = "C_LabResult";
			this.C_LabResult.ReadOnly = true;
			this.C_LabMan.HeaderText = "LabMan";
			this.C_LabMan.Name = "C_LabMan";
			this.C_LabMan.ReadOnly = true;
			this.C_LabTime.HeaderText = "LabTime";
			this.C_LabTime.Name = "C_LabTime";
			this.C_LabTime.ReadOnly = true;
			this.C_LabCount.HeaderText = "LabCount";
			this.C_LabCount.Name = "C_LabCount";
			this.C_LabCount.ReadOnly = true;
			this.C_BatchCode.HeaderText = "BatchCode";
			this.C_BatchCode.Name = "C_BatchCode";
			this.C_BatchCode.ReadOnly = true;
			this.C_QuantityBatch.BackgroundStyle.Class = "DataGridViewNumericBorder";
			this.C_QuantityBatch.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.C_QuantityBatch.HeaderText = "QuantityBatch";
			this.C_QuantityBatch.Increment = 1.0;
			this.C_QuantityBatch.Name = "C_QuantityBatch";
			this.C_QuantityBatch.ReadOnly = true;
			this.C_BatchState.HeaderText = "BatchState";
			this.C_BatchState.Name = "C_BatchState";
			this.C_BatchState.ReadOnly = true;
			this.C_Remark.HeaderText = "Remark";
			this.C_Remark.Name = "C_Remark";
			this.C_Remark.ReadOnly = true;
			this.C_Remark.Visible = false;
			this.barDetail.AntiAlias = true;
			this.barDetail.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.barDetail.Font = new global::System.Drawing.Font("微软雅黑", 9f);
			this.barDetail.IsMaximized = false;
			this.barDetail.Items.AddRange(new global::DevComponents.DotNetBar.BaseItem[]
			{
				this.btnImportBill,
				this.btnRemoveBill,
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
			this.btnImportBill.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.btnImportBill.Image = global::SQSClient.Properties.Resources.add16;
			this.btnImportBill.Name = "btnImportBill";
			this.btnImportBill.Text = "ImportBill";
			this.btnImportBill.Click += new global::System.EventHandler(this.btnImportBill_Click);
			this.btnRemoveBill.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.btnRemoveBill.Image = global::SQSClient.Properties.Resources.delete16;
			this.btnRemoveBill.Name = "btnRemoveBill";
			this.btnRemoveBill.Text = "RemoveBill";
			this.btnRemoveBill.Click += new global::System.EventHandler(this.btnRemoveBill_Click);
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
			base.ClientSize = new global::System.Drawing.Size(1305, 576);
			base.Controls.Add(this.gPanelToRdRecords);
			base.Controls.Add(this.pnlConfig);
			base.Controls.Add(this.bar);
			base.Name = "frmRdRecordTicket";
			this.Text = "RdRecord";
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.frmRdRecordTicket_FormClosing);
			base.Load += new global::System.EventHandler(this.frmRdRecordTicket_Load);
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

		// Token: 0x040005BC RID: 1468
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x040005BD RID: 1469
		private global::DevComponents.DotNetBar.Bar bar;

		// Token: 0x040005BE RID: 1470
		private global::DevComponents.DotNetBar.ButtonItem btnAddRd;

		// Token: 0x040005BF RID: 1471
		private global::DevComponents.DotNetBar.ButtonItem btnModifyRd;

		// Token: 0x040005C0 RID: 1472
		private global::DevComponents.DotNetBar.ButtonItem btnDeleteRd;

		// Token: 0x040005C1 RID: 1473
		private global::DevComponents.DotNetBar.ButtonItem btnSettleStockRd;

		// Token: 0x040005C2 RID: 1474
		private global::DevComponents.DotNetBar.Controls.GroupPanel pnlConfig;

		// Token: 0x040005C3 RID: 1475
		private global::DevComponents.DotNetBar.Controls.ComboBoxEx cmbRdStatus;

		// Token: 0x040005C4 RID: 1476
		private global::DevComponents.DotNetBar.Controls.CheckBoxX chkIsUseDate;

		// Token: 0x040005C5 RID: 1477
		private global::DevComponents.DotNetBar.ButtonX btnQuery;

		// Token: 0x040005C6 RID: 1478
		private global::DevComponents.Editors.DateTimeAdv.DateTimeInput dtpDate;

		// Token: 0x040005C7 RID: 1479
		private global::DevComponents.DotNetBar.ButtonItem btnPrintRd;

		// Token: 0x040005C8 RID: 1480
		private global::Base.AutoComboBox cmbWhName;

		// Token: 0x040005C9 RID: 1481
		private global::DevComponents.DotNetBar.PanelEx panelEx1;

		// Token: 0x040005CA RID: 1482
		private global::DevComponents.DotNetBar.LabelX labCount;

		// Token: 0x040005CB RID: 1483
		private global::Base.AutoComboBox cmbProduct;

		// Token: 0x040005CC RID: 1484
		private global::DevComponents.DotNetBar.ButtonItem btnAdjustRd;

		// Token: 0x040005CD RID: 1485
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtRdCode;

		// Token: 0x040005CE RID: 1486
		private global::DevComponents.DotNetBar.Layout.LayoutControl layoutControl1;

		// Token: 0x040005CF RID: 1487
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem1;

		// Token: 0x040005D0 RID: 1488
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem2;

		// Token: 0x040005D1 RID: 1489
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem9;

		// Token: 0x040005D2 RID: 1490
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem5;

		// Token: 0x040005D3 RID: 1491
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem6;

		// Token: 0x040005D4 RID: 1492
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem7;

		// Token: 0x040005D5 RID: 1493
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem8;

		// Token: 0x040005D6 RID: 1494
		private global::System.Windows.Forms.ContextMenuStrip contextMenuStrip;

		// Token: 0x040005D7 RID: 1495
		private global::System.Windows.Forms.ToolStripMenuItem toolReceiptCapture;

		// Token: 0x040005D8 RID: 1496
		private global::DevComponents.DotNetBar.Controls.ComboBoxEx cmbRdFlag;

		// Token: 0x040005D9 RID: 1497
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem10;

		// Token: 0x040005DA RID: 1498
		private global::DevComponents.DotNetBar.ButtonItem btnItemCRd;

		// Token: 0x040005DB RID: 1499
		private global::DevComponents.DotNetBar.LabelX labMessage;

		// Token: 0x040005DC RID: 1500
		private global::System.Windows.Forms.ToolStripMenuItem toolCheckRequest;

		// Token: 0x040005DD RID: 1501
		private global::DevComponents.DotNetBar.Controls.GroupPanel gPanelToRdRecords;

		// Token: 0x040005DE RID: 1502
		private global::System.Windows.Forms.SplitContainer splitContainer1;

		// Token: 0x040005DF RID: 1503
		private global::DevComponents.DotNetBar.Controls.DataGridViewX dgvRecordMain;

		// Token: 0x040005E0 RID: 1504
		private global::DevComponents.DotNetBar.ButtonItem btnBatchAbnormal;

		// Token: 0x040005E1 RID: 1505
		private global::DevComponents.DotNetBar.ButtonItem btnClearEBX;

		// Token: 0x040005E2 RID: 1506
		private global::DevComponents.DotNetBar.ButtonItem btnTicketDelete;

		// Token: 0x040005E3 RID: 1507
		private global::DevComponents.DotNetBar.ButtonItem buttonItem1;

		// Token: 0x040005E4 RID: 1508
		private global::DevComponents.DotNetBar.Bar barDetail;

		// Token: 0x040005E5 RID: 1509
		private global::DevComponents.DotNetBar.ButtonItem btnImportBill;

		// Token: 0x040005E6 RID: 1510
		private global::DevComponents.DotNetBar.ButtonItem btnRemoveBill;

		// Token: 0x040005E7 RID: 1511
		private global::DevComponents.DotNetBar.ButtonItem btnPrint;

		// Token: 0x040005E8 RID: 1512
		private global::DevComponents.DotNetBar.ButtonItem btnStockSettle;

		// Token: 0x040005E9 RID: 1513
		private global::DevComponents.DotNetBar.Controls.ComboBoxEx cmbBusType;

		// Token: 0x040005EA RID: 1514
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem3;

		// Token: 0x040005EB RID: 1515
		private global::System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;

		// Token: 0x040005EC RID: 1516
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_RdIndex;

		// Token: 0x040005ED RID: 1517
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_RdCode;

		// Token: 0x040005EE RID: 1518
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_VouchType;

		// Token: 0x040005EF RID: 1519
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_BusType;

		// Token: 0x040005F0 RID: 1520
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_Source;

		// Token: 0x040005F1 RID: 1521
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_WhCode;

		// Token: 0x040005F2 RID: 1522
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_DepName;

		// Token: 0x040005F3 RID: 1523
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_RdPerson;

		// Token: 0x040005F4 RID: 1524
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_DLCode;

		// Token: 0x040005F5 RID: 1525
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_Maker;

		// Token: 0x040005F6 RID: 1526
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_Handler;

		// Token: 0x040005F7 RID: 1527
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_Accounter;

		// Token: 0x040005F8 RID: 1528
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_RdStatus;

		// Token: 0x040005F9 RID: 1529
		private global::DevComponents.DotNetBar.Controls.DataGridViewX dgvData;

		// Token: 0x040005FA RID: 1530
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_Id;

		// Token: 0x040005FB RID: 1531
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_DanHao;

		// Token: 0x040005FC RID: 1532
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_ContractID;

		// Token: 0x040005FD RID: 1533
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_BusinessType;

		// Token: 0x040005FE RID: 1534
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_Clientpart;

		// Token: 0x040005FF RID: 1535
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_CheNum;

		// Token: 0x04000600 RID: 1536
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_Unit;

		// Token: 0x04000601 RID: 1537
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_Product;

		// Token: 0x04000602 RID: 1538
		private global::DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn C_JiHuaLiang;

		// Token: 0x04000603 RID: 1539
		private global::DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn C_ShiJiLiang;

		// Token: 0x04000604 RID: 1540
		private global::DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn C_FirstWeight;

		// Token: 0x04000605 RID: 1541
		private global::DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn C_SecondWeight;

		// Token: 0x04000606 RID: 1542
		private global::DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn C_DifferWeight;

		// Token: 0x04000607 RID: 1543
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_DanWei;

		// Token: 0x04000608 RID: 1544
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_OrderStatus;

		// Token: 0x04000609 RID: 1545
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_LabStatus;

		// Token: 0x0400060A RID: 1546
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_LabResult;

		// Token: 0x0400060B RID: 1547
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_LabMan;

		// Token: 0x0400060C RID: 1548
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_LabTime;

		// Token: 0x0400060D RID: 1549
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_LabCount;

		// Token: 0x0400060E RID: 1550
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_BatchCode;

		// Token: 0x0400060F RID: 1551
		private global::DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn C_QuantityBatch;

		// Token: 0x04000610 RID: 1552
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_BatchState;

		// Token: 0x04000611 RID: 1553
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_Remark;
	}
}
