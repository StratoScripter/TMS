namespace SQSClient
{
	// Token: 0x0200009A RID: 154
	public partial class frmUnionlabTicket : global::SQSClient.BaseDialogForm
	{
		// Token: 0x060008B2 RID: 2226 RVA: 0x000D54D8 File Offset: 0x000D36D8
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060008B3 RID: 2227 RVA: 0x000D5510 File Offset: 0x000D3710
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
			this.cmbUnionLabStatus = new global::DevComponents.DotNetBar.Controls.ComboBoxEx();
			this.cmbWhName = new global::Base.AutoComboBox();
			this.cmbProduct = new global::Base.AutoComboBox();
			this.txtUnionLabName = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.btnQuery = new global::DevComponents.DotNetBar.ButtonX();
			this.chkIsUseDate = new global::DevComponents.DotNetBar.Controls.CheckBoxX();
			this.cmbUnionLabResult = new global::DevComponents.DotNetBar.Controls.ComboBoxEx();
			this.cmbBusinessType = new global::DevComponents.DotNetBar.Controls.ComboBoxEx();
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
			this.btnSampling = new global::DevComponents.DotNetBar.ButtonItem();
			this.btnAnalysis = new global::DevComponents.DotNetBar.ButtonItem();
			this.btnLab = new global::DevComponents.DotNetBar.ButtonItem();
			this.btnConfirm = new global::DevComponents.DotNetBar.ButtonItem();
			this.btnAdjustRd = new global::DevComponents.DotNetBar.ButtonItem();
			this.btnItemCRd = new global::DevComponents.DotNetBar.ButtonItem();
			this.gPanelToRdRecords = new global::DevComponents.DotNetBar.Controls.GroupPanel();
			this.splitContainer1 = new global::System.Windows.Forms.SplitContainer();
			this.dgvUnionLabMain = new global::DevComponents.DotNetBar.Controls.DataGridViewX();
			this.dataGridViewTextBoxColumn1 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_UnionLabIndex = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_UnionLabCode = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_UnionLabName = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_BusinessType = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_UnionLabStatus = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_UnionLabResult = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_UnionLabMan = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_UnionLabTime = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_UnionLabCount = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_Creater = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_CreateTime = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_Modifier = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_ModifyTime = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_UnionStatus = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgvData = new global::DevComponents.DotNetBar.Controls.DataGridViewX();
			this.C_Id = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_DanHao = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_ContractID = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
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
			this.C_Remark = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.barDetail = new global::DevComponents.DotNetBar.Bar();
			this.btnImportBill = new global::DevComponents.DotNetBar.ButtonItem();
			this.btnRemoveBill = new global::DevComponents.DotNetBar.ButtonItem();
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
			((global::System.ComponentModel.ISupportInitialize)this.dgvUnionLabMain).BeginInit();
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
			this.toolReceiptCapture.Size = new global::System.Drawing.Size(180, 22);
			this.toolReceiptCapture.Text = "ReceiptCapture";
			this.toolReceiptCapture.Click += new global::System.EventHandler(this.toolReceiptCapture_Click);
			this.toolCheckRequest.Name = "toolCheckRequest";
			this.toolCheckRequest.Size = new global::System.Drawing.Size(180, 22);
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
			this.layoutControl1.Controls.Add(this.cmbUnionLabStatus);
			this.layoutControl1.Controls.Add(this.cmbWhName);
			this.layoutControl1.Controls.Add(this.cmbProduct);
			this.layoutControl1.Controls.Add(this.txtUnionLabName);
			this.layoutControl1.Controls.Add(this.btnQuery);
			this.layoutControl1.Controls.Add(this.chkIsUseDate);
			this.layoutControl1.Controls.Add(this.cmbUnionLabResult);
			this.layoutControl1.Controls.Add(this.cmbBusinessType);
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
			this.dtpDate.Location = new global::System.Drawing.Point(86, 4);
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
			this.dtpDate.Size = new global::System.Drawing.Size(117, 21);
			this.dtpDate.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.dtpDate.TabIndex = 0;
			this.cmbUnionLabStatus.DisplayMember = "Text";
			this.cmbUnionLabStatus.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cmbUnionLabStatus.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbUnionLabStatus.FormattingEnabled = true;
			this.cmbUnionLabStatus.ItemHeight = 15;
			this.cmbUnionLabStatus.Location = new global::System.Drawing.Point(368, 4);
			this.cmbUnionLabStatus.Margin = new global::System.Windows.Forms.Padding(0);
			this.cmbUnionLabStatus.Name = "cmbUnionLabStatus";
			this.cmbUnionLabStatus.Size = new global::System.Drawing.Size(98, 21);
			this.cmbUnionLabStatus.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.cmbUnionLabStatus.TabIndex = 2;
			this.cmbWhName.DataSource = null;
			this.cmbWhName.DisplayMember = null;
			this.cmbWhName.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cmbWhName.FormattingEnabled = true;
			this.cmbWhName.ItemHeight = 15;
			this.cmbWhName.Location = new global::System.Drawing.Point(86, 33);
			this.cmbWhName.Margin = new global::System.Windows.Forms.Padding(0);
			this.cmbWhName.MaxDropDownItems = 20;
			this.cmbWhName.Name = "cmbWhName";
			this.cmbWhName.SelectMember = null;
			this.cmbWhName.Size = new global::System.Drawing.Size(192, 21);
			this.cmbWhName.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.cmbWhName.TabIndex = 5;
			this.cmbWhName.ValueMember = null;
			this.cmbProduct.DataSource = null;
			this.cmbProduct.DisplayMember = null;
			this.cmbProduct.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cmbProduct.FormattingEnabled = true;
			this.cmbProduct.ItemHeight = 17;
			this.cmbProduct.Location = new global::System.Drawing.Point(368, 33);
			this.cmbProduct.Margin = new global::System.Windows.Forms.Padding(0);
			this.cmbProduct.MaxDropDownItems = 20;
			this.cmbProduct.Name = "cmbProduct";
			this.cmbProduct.SelectMember = null;
			this.cmbProduct.Size = new global::System.Drawing.Size(192, 23);
			this.cmbProduct.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.cmbProduct.TabIndex = 6;
			this.cmbProduct.ValueMember = null;
			this.txtUnionLabName.Border.Class = "TextBoxBorder";
			this.txtUnionLabName.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtUnionLabName.Location = new global::System.Drawing.Point(650, 33);
			this.txtUnionLabName.Margin = new global::System.Windows.Forms.Padding(0);
			this.txtUnionLabName.Name = "txtUnionLabName";
			this.txtUnionLabName.PreventEnterBeep = true;
			this.txtUnionLabName.Size = new global::System.Drawing.Size(192, 21);
			this.txtUnionLabName.TabIndex = 7;
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
			this.cmbUnionLabResult.DisplayMember = "Text";
			this.cmbUnionLabResult.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cmbUnionLabResult.FormattingEnabled = true;
			this.cmbUnionLabResult.ItemHeight = 15;
			this.cmbUnionLabResult.Location = new global::System.Drawing.Point(556, 4);
			this.cmbUnionLabResult.Margin = new global::System.Windows.Forms.Padding(0);
			this.cmbUnionLabResult.Name = "cmbUnionLabResult";
			this.cmbUnionLabResult.Size = new global::System.Drawing.Size(98, 21);
			this.cmbUnionLabResult.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.cmbUnionLabResult.TabIndex = 3;
			this.cmbBusinessType.DisplayMember = "Text";
			this.cmbBusinessType.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cmbBusinessType.FormattingEnabled = true;
			this.cmbBusinessType.ItemHeight = 15;
			this.cmbBusinessType.Location = new global::System.Drawing.Point(744, 4);
			this.cmbBusinessType.Margin = new global::System.Windows.Forms.Padding(0);
			this.cmbBusinessType.Name = "cmbBusinessType";
			this.cmbBusinessType.Size = new global::System.Drawing.Size(98, 21);
			this.cmbBusinessType.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.cmbBusinessType.TabIndex = 4;
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
			this.layoutControlItem2.Control = this.cmbUnionLabStatus;
			this.layoutControlItem2.Height = 29;
			this.layoutControlItem2.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem2.Name = "layoutControlItem2";
			this.layoutControlItem2.Text = "LabStatus";
			this.layoutControlItem2.Width = 20;
			this.layoutControlItem2.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem10.Control = this.cmbUnionLabResult;
			this.layoutControlItem10.Height = 29;
			this.layoutControlItem10.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem10.Name = "layoutControlItem10";
			this.layoutControlItem10.Text = "LabResult";
			this.layoutControlItem10.Width = 20;
			this.layoutControlItem10.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem3.Control = this.cmbBusinessType;
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
			this.layoutControlItem7.Control = this.txtUnionLabName;
			this.layoutControlItem7.Height = 29;
			this.layoutControlItem7.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem7.Name = "layoutControlItem7";
			this.layoutControlItem7.Text = "UnionLabName";
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
				this.btnSampling,
				this.btnAnalysis,
				this.btnLab,
				this.btnConfirm,
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
			this.btnSampling.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.btnSampling.Image = global::SQSClient.Properties.Resources.modify16;
			this.btnSampling.ItemAlignment = global::DevComponents.DotNetBar.eItemAlignment.Far;
			this.btnSampling.Name = "btnSampling";
			this.btnSampling.Text = "Sampling";
			this.btnSampling.Click += new global::System.EventHandler(this.btnSampling_Click);
			this.btnAnalysis.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.btnAnalysis.Image = global::SQSClient.Properties.Resources.modify16;
			this.btnAnalysis.Name = "btnAnalysis";
			this.btnAnalysis.Text = "Analysis";
			this.btnAnalysis.Click += new global::System.EventHandler(this.btnAnalysis_Click);
			this.btnLab.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.btnLab.Image = global::SQSClient.Properties.Resources.modify16;
			this.btnLab.Name = "btnLab";
			this.btnLab.Text = "Lab";
			this.btnLab.Click += new global::System.EventHandler(this.btnLab_Click);
			this.btnConfirm.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.btnConfirm.Image = global::SQSClient.Properties.Resources.modify16;
			this.btnConfirm.Name = "btnConfirm";
			this.btnConfirm.Text = "Confirm";
			this.btnConfirm.Click += new global::System.EventHandler(this.btnConfirm_Click);
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
			this.gPanelToRdRecords.Text = "ToUnionLabs";
			this.splitContainer1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new global::System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = global::System.Windows.Forms.Orientation.Horizontal;
			this.splitContainer1.Panel1.Controls.Add(this.dgvUnionLabMain);
			this.splitContainer1.Panel2.Controls.Add(this.dgvData);
			this.splitContainer1.Panel2.Controls.Add(this.barDetail);
			this.splitContainer1.Size = new global::System.Drawing.Size(1299, 457);
			this.splitContainer1.SplitterDistance = 213;
			this.splitContainer1.TabIndex = 0;
			this.dgvUnionLabMain.AllowUserToAddRows = false;
			this.dgvUnionLabMain.AllowUserToDeleteRows = false;
			this.dgvUnionLabMain.AutoSizeColumnsMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvUnionLabMain.AutoSizeRowsMode = global::System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			dataGridViewCellStyle.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle.BackColor = global::System.Drawing.SystemColors.Control;
			dataGridViewCellStyle.Font = new global::System.Drawing.Font("宋体", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 134);
			dataGridViewCellStyle.ForeColor = global::System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle.SelectionBackColor = global::System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle.SelectionForeColor = global::System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle.WrapMode = global::System.Windows.Forms.DataGridViewTriState.True;
			this.dgvUnionLabMain.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
			this.dgvUnionLabMain.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dgvUnionLabMain.Columns.AddRange(new global::System.Windows.Forms.DataGridViewColumn[]
			{
				this.dataGridViewTextBoxColumn1,
				this.C_UnionLabIndex,
				this.C_UnionLabCode,
				this.C_UnionLabName,
				this.C_BusinessType,
				this.C_UnionLabStatus,
				this.C_UnionLabResult,
				this.C_UnionLabMan,
				this.C_UnionLabTime,
				this.C_UnionLabCount,
				this.C_Creater,
				this.C_CreateTime,
				this.C_Modifier,
				this.C_ModifyTime,
				this.C_UnionStatus
			});
			this.dgvUnionLabMain.ContextMenuStrip = this.contextMenuStrip;
			dataGridViewCellStyle2.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = global::System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new global::System.Drawing.Font("宋体", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 134);
			dataGridViewCellStyle2.ForeColor = global::System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = global::System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = global::System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.WrapMode = global::System.Windows.Forms.DataGridViewTriState.False;
			this.dgvUnionLabMain.DefaultCellStyle = dataGridViewCellStyle2;
			this.dgvUnionLabMain.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.dgvUnionLabMain.EnableHeadersVisualStyles = false;
			this.dgvUnionLabMain.GridColor = global::System.Drawing.Color.FromArgb(208, 215, 229);
			this.dgvUnionLabMain.Location = new global::System.Drawing.Point(0, 0);
			this.dgvUnionLabMain.MultiSelect = false;
			this.dgvUnionLabMain.Name = "dgvUnionLabMain";
			this.dgvUnionLabMain.ReadOnly = true;
			dataGridViewCellStyle3.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = global::System.Drawing.SystemColors.Control;
			dataGridViewCellStyle3.Font = new global::System.Drawing.Font("宋体", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 134);
			dataGridViewCellStyle3.ForeColor = global::System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = global::System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = global::System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.WrapMode = global::System.Windows.Forms.DataGridViewTriState.True;
			this.dgvUnionLabMain.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.dgvUnionLabMain.RowHeadersVisible = false;
			this.dgvUnionLabMain.RowTemplate.Height = 23;
			this.dgvUnionLabMain.SelectionMode = global::System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvUnionLabMain.Size = new global::System.Drawing.Size(1299, 213);
			this.dgvUnionLabMain.TabIndex = 17;
			this.dgvUnionLabMain.CellClick += new global::System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUnionLabMain_CellClick);
			this.dgvUnionLabMain.CellDoubleClick += new global::System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUnionLabMain_CellDoubleClick);
			this.dgvUnionLabMain.SelectionChanged += new global::System.EventHandler(this.dgvUnionLabMain_SelectionChanged);
			this.dataGridViewTextBoxColumn1.FillWeight = 60f;
			this.dataGridViewTextBoxColumn1.HeaderText = "ID";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			this.dataGridViewTextBoxColumn1.Visible = false;
			this.C_UnionLabIndex.FillWeight = 80f;
			this.C_UnionLabIndex.HeaderText = "UnionLabIndex";
			this.C_UnionLabIndex.Name = "C_UnionLabIndex";
			this.C_UnionLabIndex.ReadOnly = true;
			this.C_UnionLabIndex.Visible = false;
			this.C_UnionLabCode.HeaderText = "UnionLabCode";
			this.C_UnionLabCode.Name = "C_UnionLabCode";
			this.C_UnionLabCode.ReadOnly = true;
			this.C_UnionLabName.HeaderText = "UnionLabName";
			this.C_UnionLabName.Name = "C_UnionLabName";
			this.C_UnionLabName.ReadOnly = true;
			this.C_BusinessType.HeaderText = "BusinessType";
			this.C_BusinessType.Name = "C_BusinessType";
			this.C_BusinessType.ReadOnly = true;
			this.C_UnionLabStatus.HeaderText = "LabStatus";
			this.C_UnionLabStatus.Name = "C_UnionLabStatus";
			this.C_UnionLabStatus.ReadOnly = true;
			this.C_UnionLabResult.HeaderText = "LabResult";
			this.C_UnionLabResult.Name = "C_UnionLabResult";
			this.C_UnionLabResult.ReadOnly = true;
			this.C_UnionLabMan.HeaderText = "LabMan";
			this.C_UnionLabMan.Name = "C_UnionLabMan";
			this.C_UnionLabMan.ReadOnly = true;
			this.C_UnionLabTime.HeaderText = "LabTime";
			this.C_UnionLabTime.Name = "C_UnionLabTime";
			this.C_UnionLabTime.ReadOnly = true;
			this.C_UnionLabCount.HeaderText = "LabCount";
			this.C_UnionLabCount.Name = "C_UnionLabCount";
			this.C_UnionLabCount.ReadOnly = true;
			this.C_Creater.HeaderText = "Creater";
			this.C_Creater.Name = "C_Creater";
			this.C_Creater.ReadOnly = true;
			this.C_CreateTime.HeaderText = "CreateTime";
			this.C_CreateTime.Name = "C_CreateTime";
			this.C_CreateTime.ReadOnly = true;
			this.C_Modifier.HeaderText = "Modifier";
			this.C_Modifier.Name = "C_Modifier";
			this.C_Modifier.ReadOnly = true;
			this.C_ModifyTime.HeaderText = "ModifyTime";
			this.C_ModifyTime.Name = "C_ModifyTime";
			this.C_ModifyTime.ReadOnly = true;
			this.C_UnionStatus.HeaderText = "Status";
			this.C_UnionStatus.Name = "C_UnionStatus";
			this.C_UnionStatus.ReadOnly = true;
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
			base.Name = "frmUnionlabTicket";
			this.Text = "UnionLab";
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.frmUnionlabTicket_FormClosing);
			base.Load += new global::System.EventHandler(this.frmUnionlabTicket_Load);
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
			((global::System.ComponentModel.ISupportInitialize)this.dgvUnionLabMain).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.dgvData).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.barDetail).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000EBF RID: 3775
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000EC0 RID: 3776
		private global::DevComponents.DotNetBar.Bar bar;

		// Token: 0x04000EC1 RID: 3777
		private global::DevComponents.DotNetBar.ButtonItem btnAddRd;

		// Token: 0x04000EC2 RID: 3778
		private global::DevComponents.DotNetBar.ButtonItem btnModifyRd;

		// Token: 0x04000EC3 RID: 3779
		private global::DevComponents.DotNetBar.ButtonItem btnDeleteRd;

		// Token: 0x04000EC4 RID: 3780
		private global::DevComponents.DotNetBar.ButtonItem btnSettleStockRd;

		// Token: 0x04000EC5 RID: 3781
		private global::DevComponents.DotNetBar.Controls.GroupPanel pnlConfig;

		// Token: 0x04000EC6 RID: 3782
		private global::DevComponents.DotNetBar.Controls.ComboBoxEx cmbUnionLabStatus;

		// Token: 0x04000EC7 RID: 3783
		private global::DevComponents.DotNetBar.Controls.CheckBoxX chkIsUseDate;

		// Token: 0x04000EC8 RID: 3784
		private global::DevComponents.DotNetBar.ButtonX btnQuery;

		// Token: 0x04000EC9 RID: 3785
		private global::DevComponents.Editors.DateTimeAdv.DateTimeInput dtpDate;

		// Token: 0x04000ECA RID: 3786
		private global::DevComponents.DotNetBar.ButtonItem btnPrintRd;

		// Token: 0x04000ECB RID: 3787
		private global::Base.AutoComboBox cmbWhName;

		// Token: 0x04000ECC RID: 3788
		private global::DevComponents.DotNetBar.PanelEx panelEx1;

		// Token: 0x04000ECD RID: 3789
		private global::DevComponents.DotNetBar.LabelX labCount;

		// Token: 0x04000ECE RID: 3790
		private global::Base.AutoComboBox cmbProduct;

		// Token: 0x04000ECF RID: 3791
		private global::DevComponents.DotNetBar.ButtonItem btnAdjustRd;

		// Token: 0x04000ED0 RID: 3792
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtUnionLabName;

		// Token: 0x04000ED1 RID: 3793
		private global::DevComponents.DotNetBar.Layout.LayoutControl layoutControl1;

		// Token: 0x04000ED2 RID: 3794
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem1;

		// Token: 0x04000ED3 RID: 3795
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem2;

		// Token: 0x04000ED4 RID: 3796
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem9;

		// Token: 0x04000ED5 RID: 3797
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem5;

		// Token: 0x04000ED6 RID: 3798
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem6;

		// Token: 0x04000ED7 RID: 3799
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem7;

		// Token: 0x04000ED8 RID: 3800
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem8;

		// Token: 0x04000ED9 RID: 3801
		private global::System.Windows.Forms.ContextMenuStrip contextMenuStrip;

		// Token: 0x04000EDA RID: 3802
		private global::System.Windows.Forms.ToolStripMenuItem toolReceiptCapture;

		// Token: 0x04000EDB RID: 3803
		private global::DevComponents.DotNetBar.Controls.ComboBoxEx cmbUnionLabResult;

		// Token: 0x04000EDC RID: 3804
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem10;

		// Token: 0x04000EDD RID: 3805
		private global::DevComponents.DotNetBar.ButtonItem btnItemCRd;

		// Token: 0x04000EDE RID: 3806
		private global::DevComponents.DotNetBar.LabelX labMessage;

		// Token: 0x04000EDF RID: 3807
		private global::System.Windows.Forms.ToolStripMenuItem toolCheckRequest;

		// Token: 0x04000EE0 RID: 3808
		private global::DevComponents.DotNetBar.Controls.GroupPanel gPanelToRdRecords;

		// Token: 0x04000EE1 RID: 3809
		private global::System.Windows.Forms.SplitContainer splitContainer1;

		// Token: 0x04000EE2 RID: 3810
		private global::DevComponents.DotNetBar.Controls.DataGridViewX dgvUnionLabMain;

		// Token: 0x04000EE3 RID: 3811
		private global::DevComponents.DotNetBar.ButtonItem btnBatchAbnormal;

		// Token: 0x04000EE4 RID: 3812
		private global::DevComponents.DotNetBar.ButtonItem btnClearEBX;

		// Token: 0x04000EE5 RID: 3813
		private global::DevComponents.DotNetBar.ButtonItem btnTicketDelete;

		// Token: 0x04000EE6 RID: 3814
		private global::DevComponents.DotNetBar.ButtonItem buttonItem1;

		// Token: 0x04000EE7 RID: 3815
		private global::DevComponents.DotNetBar.Bar barDetail;

		// Token: 0x04000EE8 RID: 3816
		private global::DevComponents.DotNetBar.ButtonItem btnImportBill;

		// Token: 0x04000EE9 RID: 3817
		private global::DevComponents.DotNetBar.ButtonItem btnRemoveBill;

		// Token: 0x04000EEA RID: 3818
		private global::DevComponents.DotNetBar.ButtonItem btnPrint;

		// Token: 0x04000EEB RID: 3819
		private global::DevComponents.DotNetBar.Controls.ComboBoxEx cmbBusinessType;

		// Token: 0x04000EEC RID: 3820
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem3;

		// Token: 0x04000EED RID: 3821
		private global::DevComponents.DotNetBar.Controls.DataGridViewX dgvData;

		// Token: 0x04000EEE RID: 3822
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_Id;

		// Token: 0x04000EEF RID: 3823
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_DanHao;

		// Token: 0x04000EF0 RID: 3824
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_ContractID;

		// Token: 0x04000EF1 RID: 3825
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_Clientpart;

		// Token: 0x04000EF2 RID: 3826
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_CheNum;

		// Token: 0x04000EF3 RID: 3827
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_Unit;

		// Token: 0x04000EF4 RID: 3828
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_Product;

		// Token: 0x04000EF5 RID: 3829
		private global::DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn C_JiHuaLiang;

		// Token: 0x04000EF6 RID: 3830
		private global::DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn C_ShiJiLiang;

		// Token: 0x04000EF7 RID: 3831
		private global::DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn C_FirstWeight;

		// Token: 0x04000EF8 RID: 3832
		private global::DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn C_SecondWeight;

		// Token: 0x04000EF9 RID: 3833
		private global::DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn C_DifferWeight;

		// Token: 0x04000EFA RID: 3834
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_DanWei;

		// Token: 0x04000EFB RID: 3835
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_OrderStatus;

		// Token: 0x04000EFC RID: 3836
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_LabStatus;

		// Token: 0x04000EFD RID: 3837
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_LabResult;

		// Token: 0x04000EFE RID: 3838
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_LabMan;

		// Token: 0x04000EFF RID: 3839
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_LabTime;

		// Token: 0x04000F00 RID: 3840
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_LabCount;

		// Token: 0x04000F01 RID: 3841
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_Remark;

		// Token: 0x04000F02 RID: 3842
		private global::DevComponents.DotNetBar.ButtonItem btnSampling;

		// Token: 0x04000F03 RID: 3843
		private global::DevComponents.DotNetBar.ButtonItem btnAnalysis;

		// Token: 0x04000F04 RID: 3844
		private global::DevComponents.DotNetBar.ButtonItem btnLab;

		// Token: 0x04000F05 RID: 3845
		private global::DevComponents.DotNetBar.ButtonItem btnConfirm;

		// Token: 0x04000F06 RID: 3846
		private global::System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;

		// Token: 0x04000F07 RID: 3847
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_UnionLabIndex;

		// Token: 0x04000F08 RID: 3848
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_UnionLabCode;

		// Token: 0x04000F09 RID: 3849
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_UnionLabName;

		// Token: 0x04000F0A RID: 3850
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_BusinessType;

		// Token: 0x04000F0B RID: 3851
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_UnionLabStatus;

		// Token: 0x04000F0C RID: 3852
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_UnionLabResult;

		// Token: 0x04000F0D RID: 3853
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_UnionLabMan;

		// Token: 0x04000F0E RID: 3854
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_UnionLabTime;

		// Token: 0x04000F0F RID: 3855
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_UnionLabCount;

		// Token: 0x04000F10 RID: 3856
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_Creater;

		// Token: 0x04000F11 RID: 3857
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_CreateTime;

		// Token: 0x04000F12 RID: 3858
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_Modifier;

		// Token: 0x04000F13 RID: 3859
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_ModifyTime;

		// Token: 0x04000F14 RID: 3860
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_UnionStatus;
	}
}
