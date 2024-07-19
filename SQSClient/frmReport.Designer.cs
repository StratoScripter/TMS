namespace SQSClient
{
	// Token: 0x0200007A RID: 122
	public partial class frmReport : global::SQSClient.BaseDialogForm
	{
		// Token: 0x060006C0 RID: 1728 RVA: 0x000A50D8 File Offset: 0x000A32D8
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060006C1 RID: 1729 RVA: 0x000A5110 File Offset: 0x000A3310
		private void InitializeComponent()
		{
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new global::System.Windows.Forms.DataGridViewCellStyle();
			this.controlContainerItem3 = new global::DevComponents.DotNetBar.ControlContainerItem();
			this.controlContainerItem4 = new global::DevComponents.DotNetBar.ControlContainerItem();
			this.bar = new global::DevComponents.DotNetBar.Bar();
			this.btnSearch = new global::DevComponents.DotNetBar.ButtonItem();
			this.btnExport = new global::DevComponents.DotNetBar.ButtonItem();
			this.btnPrint = new global::DevComponents.DotNetBar.ButtonItem();
			this.btnItemC = new global::DevComponents.DotNetBar.ButtonItem();
			this.cmbAccountType = new global::DevComponents.DotNetBar.Controls.ComboBoxEx();
			this.cmbBusinessType = new global::DevComponents.DotNetBar.Controls.ComboBoxEx();
			this.cmbUnit = new global::Base.AutoComboBox();
			this.cmbProduct = new global::Base.AutoComboBox();
			this.cmbClient = new global::Base.AutoComboBox();
			this.txtCheNum = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.txtJieSuanRen = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.dtpStartTime = new global::DevComponents.Editors.DateTimeAdv.DateTimeInput();
			this.dtpEndTime = new global::DevComponents.Editors.DateTimeAdv.DateTimeInput();
			this.controlContainerItem9 = new global::DevComponents.DotNetBar.ControlContainerItem();
			this.controlContainerItem8 = new global::DevComponents.DotNetBar.ControlContainerItem();
			this.controlContainerItem12 = new global::DevComponents.DotNetBar.ControlContainerItem();
			this.dgvData = new global::DevComponents.DotNetBar.Controls.DataGridViewX();
			this.C_Id = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.pnlConfig = new global::DevComponents.DotNetBar.Controls.GroupPanel();
			this.layoutControl1 = new global::DevComponents.DotNetBar.Layout.LayoutControl();
			this.layoutControlItem1 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem2 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem8 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem9 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem3 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem4 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem5 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem6 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem7 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			((global::System.ComponentModel.ISupportInitialize)this.bar).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.dtpStartTime).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.dtpEndTime).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.dgvData).BeginInit();
			this.pnlConfig.SuspendLayout();
			this.layoutControl1.SuspendLayout();
			base.SuspendLayout();
			this.controlContainerItem3.AllowItemResize = false;
			this.controlContainerItem3.MenuVisibility = global::DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
			this.controlContainerItem3.Name = "controlContainerItem3";
			this.controlContainerItem4.AllowItemResize = false;
			this.controlContainerItem4.MenuVisibility = global::DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
			this.controlContainerItem4.Name = "controlContainerItem4";
			this.bar.AntiAlias = true;
			this.bar.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.bar.Font = new global::System.Drawing.Font("微软雅黑", 9f);
			this.bar.IsMaximized = false;
			this.bar.Items.AddRange(new global::DevComponents.DotNetBar.BaseItem[]
			{
				this.btnSearch,
				this.btnExport,
				this.btnPrint,
				this.btnItemC
			});
			this.bar.Location = new global::System.Drawing.Point(0, 0);
			this.bar.Name = "bar";
			this.bar.Size = new global::System.Drawing.Size(1787, 27);
			this.bar.Stretch = true;
			this.bar.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.bar.TabIndex = 0;
			this.bar.TabStop = false;
			this.bar.Text = "bar1";
			this.btnSearch.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.btnSearch.Image = global::SQSClient.Properties.Resources.search16;
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Text = "Search";
			this.btnSearch.Click += new global::System.EventHandler(this.btnSearch_Click);
			this.btnExport.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.btnExport.Image = global::SQSClient.Properties.Resources.export16;
			this.btnExport.Name = "btnExport";
			this.btnExport.Text = "Export";
			this.btnExport.Click += new global::System.EventHandler(this.btnExport_Click);
			this.btnPrint.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.btnPrint.Image = global::SQSClient.Properties.Resources.print16;
			this.btnPrint.Name = "btnPrint";
			this.btnPrint.Text = "Print";
			this.btnPrint.Click += new global::System.EventHandler(this.btnPrint_Click);
			this.btnItemC.ItemAlignment = global::DevComponents.DotNetBar.eItemAlignment.Far;
			this.btnItemC.Name = "btnItemC";
			this.btnItemC.Text = "ItemC";
			this.btnItemC.Click += new global::System.EventHandler(this.btnItemC_Click);
			this.cmbAccountType.DisplayMember = "Text";
			this.cmbAccountType.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cmbAccountType.FormattingEnabled = true;
			this.cmbAccountType.ItemHeight = 18;
			this.cmbAccountType.Location = new global::System.Drawing.Point(86, 4);
			this.cmbAccountType.Margin = new global::System.Windows.Forms.Padding(0);
			this.cmbAccountType.Name = "cmbAccountType";
			this.cmbAccountType.Size = new global::System.Drawing.Size(141, 24);
			this.cmbAccountType.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.cmbAccountType.TabIndex = 0;
			this.cmbBusinessType.DisplayMember = "Text";
			this.cmbBusinessType.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cmbBusinessType.FormattingEnabled = true;
			this.cmbBusinessType.ItemHeight = 18;
			this.cmbBusinessType.Location = new global::System.Drawing.Point(317, 4);
			this.cmbBusinessType.Margin = new global::System.Windows.Forms.Padding(0);
			this.cmbBusinessType.Name = "cmbBusinessType";
			this.cmbBusinessType.Size = new global::System.Drawing.Size(141, 24);
			this.cmbBusinessType.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.cmbBusinessType.TabIndex = 1;
			this.cmbUnit.DataSource = null;
			this.cmbUnit.DisplayMember = null;
			this.cmbUnit.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cmbUnit.FormattingEnabled = true;
			this.cmbUnit.ItemHeight = 18;
			this.cmbUnit.Location = new global::System.Drawing.Point(86, 36);
			this.cmbUnit.Margin = new global::System.Windows.Forms.Padding(0);
			this.cmbUnit.MaxDropDownItems = 20;
			this.cmbUnit.Name = "cmbUnit";
			this.cmbUnit.SelectMember = null;
			this.cmbUnit.Size = new global::System.Drawing.Size(141, 24);
			this.cmbUnit.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.cmbUnit.TabIndex = 4;
			this.cmbUnit.ValueMember = "Id";
			this.cmbProduct.DataSource = null;
			this.cmbProduct.DisplayMember = null;
			this.cmbProduct.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cmbProduct.FormattingEnabled = true;
			this.cmbProduct.ItemHeight = 18;
			this.cmbProduct.Location = new global::System.Drawing.Point(317, 36);
			this.cmbProduct.Margin = new global::System.Windows.Forms.Padding(0);
			this.cmbProduct.MaxDropDownItems = 20;
			this.cmbProduct.Name = "cmbProduct";
			this.cmbProduct.SelectMember = null;
			this.cmbProduct.Size = new global::System.Drawing.Size(141, 24);
			this.cmbProduct.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.cmbProduct.TabIndex = 5;
			this.cmbProduct.ValueMember = null;
			this.cmbClient.DataSource = null;
			this.cmbClient.DisplayMember = null;
			this.cmbClient.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cmbClient.FormattingEnabled = true;
			this.cmbClient.ItemHeight = 18;
			this.cmbClient.Location = new global::System.Drawing.Point(548, 36);
			this.cmbClient.Margin = new global::System.Windows.Forms.Padding(0);
			this.cmbClient.MaxDropDownItems = 20;
			this.cmbClient.Name = "cmbClient";
			this.cmbClient.SelectMember = null;
			this.cmbClient.Size = new global::System.Drawing.Size(141, 24);
			this.cmbClient.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.cmbClient.TabIndex = 6;
			this.cmbClient.ValueMember = null;
			this.txtCheNum.Border.Class = "TextBoxBorder";
			this.txtCheNum.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtCheNum.Location = new global::System.Drawing.Point(779, 36);
			this.txtCheNum.Margin = new global::System.Windows.Forms.Padding(0);
			this.txtCheNum.Name = "txtCheNum";
			this.txtCheNum.PreventEnterBeep = true;
			this.txtCheNum.Size = new global::System.Drawing.Size(141, 21);
			this.txtCheNum.TabIndex = 7;
			this.txtJieSuanRen.Border.Class = "TextBoxBorder";
			this.txtJieSuanRen.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtJieSuanRen.Location = new global::System.Drawing.Point(1010, 36);
			this.txtJieSuanRen.Margin = new global::System.Windows.Forms.Padding(0);
			this.txtJieSuanRen.Name = "txtJieSuanRen";
			this.txtJieSuanRen.PreventEnterBeep = true;
			this.txtJieSuanRen.Size = new global::System.Drawing.Size(142, 21);
			this.txtJieSuanRen.TabIndex = 8;
			this.dtpStartTime.BackgroundStyle.Class = "DateTimeInputBackground";
			this.dtpStartTime.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.dtpStartTime.ButtonDropDown.Shortcut = global::DevComponents.DotNetBar.eShortcut.AltDown;
			this.dtpStartTime.ButtonDropDown.Visible = true;
			this.dtpStartTime.CustomFormat = "yyyy/MM/dd HH:mm:ss";
			this.dtpStartTime.DateTimeSelectorVisibility = global::DevComponents.Editors.DateTimeAdv.eDateTimeSelectorVisibility.Both;
			this.dtpStartTime.Format = global::DevComponents.Editors.eDateTimePickerFormat.Custom;
			this.dtpStartTime.IsPopupCalendarOpen = false;
			this.dtpStartTime.Location = new global::System.Drawing.Point(548, 4);
			this.dtpStartTime.Margin = new global::System.Windows.Forms.Padding(0);
			this.dtpStartTime.MonthCalendar.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.dtpStartTime.MonthCalendar.CalendarDimensions = new global::System.Drawing.Size(1, 1);
			this.dtpStartTime.MonthCalendar.ClearButtonVisible = true;
			this.dtpStartTime.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = global::DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
			this.dtpStartTime.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
			this.dtpStartTime.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.BarBackground;
			this.dtpStartTime.MonthCalendar.CommandsBackgroundStyle.BorderTop = global::DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.dtpStartTime.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
			this.dtpStartTime.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
			this.dtpStartTime.MonthCalendar.CommandsBackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.dtpStartTime.MonthCalendar.DayClickAutoClosePopup = false;
			this.dtpStartTime.MonthCalendar.DisplayMonth = new global::System.DateTime(2016, 8, 1, 0, 0, 0, 0);
			this.dtpStartTime.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
			this.dtpStartTime.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
			this.dtpStartTime.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
			this.dtpStartTime.MonthCalendar.NavigationBackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.dtpStartTime.MonthCalendar.TodayButtonVisible = true;
			this.dtpStartTime.Name = "dtpStartTime";
			this.dtpStartTime.Size = new global::System.Drawing.Size(256, 21);
			this.dtpStartTime.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.dtpStartTime.TabIndex = 2;
			this.dtpEndTime.BackgroundStyle.Class = "DateTimeInputBackground";
			this.dtpEndTime.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.dtpEndTime.ButtonDropDown.Shortcut = global::DevComponents.DotNetBar.eShortcut.AltDown;
			this.dtpEndTime.ButtonDropDown.Visible = true;
			this.dtpEndTime.CustomFormat = "yyyy/MM/dd HH:mm:ss";
			this.dtpEndTime.DateTimeSelectorVisibility = global::DevComponents.Editors.DateTimeAdv.eDateTimeSelectorVisibility.Both;
			this.dtpEndTime.Format = global::DevComponents.Editors.eDateTimePickerFormat.Custom;
			this.dtpEndTime.IsPopupCalendarOpen = false;
			this.dtpEndTime.Location = new global::System.Drawing.Point(894, 4);
			this.dtpEndTime.Margin = new global::System.Windows.Forms.Padding(0);
			this.dtpEndTime.MonthCalendar.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.dtpEndTime.MonthCalendar.CalendarDimensions = new global::System.Drawing.Size(1, 1);
			this.dtpEndTime.MonthCalendar.ClearButtonVisible = true;
			this.dtpEndTime.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = global::DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
			this.dtpEndTime.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
			this.dtpEndTime.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.BarBackground;
			this.dtpEndTime.MonthCalendar.CommandsBackgroundStyle.BorderTop = global::DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.dtpEndTime.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
			this.dtpEndTime.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
			this.dtpEndTime.MonthCalendar.CommandsBackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.dtpEndTime.MonthCalendar.DayClickAutoClosePopup = false;
			this.dtpEndTime.MonthCalendar.DisplayMonth = new global::System.DateTime(2016, 8, 1, 0, 0, 0, 0);
			this.dtpEndTime.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
			this.dtpEndTime.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
			this.dtpEndTime.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
			this.dtpEndTime.MonthCalendar.NavigationBackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.dtpEndTime.MonthCalendar.TodayButtonVisible = true;
			this.dtpEndTime.Name = "dtpEndTime";
			this.dtpEndTime.Size = new global::System.Drawing.Size(258, 21);
			this.dtpEndTime.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.dtpEndTime.TabIndex = 3;
			this.controlContainerItem9.AllowItemResize = false;
			this.controlContainerItem9.MenuVisibility = global::DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
			this.controlContainerItem9.Name = "controlContainerItem9";
			this.controlContainerItem8.AllowItemResize = false;
			this.controlContainerItem8.MenuVisibility = global::DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
			this.controlContainerItem8.Name = "controlContainerItem8";
			this.controlContainerItem12.AllowItemResize = false;
			this.controlContainerItem12.MenuVisibility = global::DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
			this.controlContainerItem12.Name = "controlContainerItem12";
			this.dgvData.AllowUserToAddRows = false;
			this.dgvData.AllowUserToDeleteRows = false;
			this.dgvData.AutoSizeColumnsMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvData.AutoSizeRowsMode = global::System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dgvData.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvData.Columns.AddRange(new global::System.Windows.Forms.DataGridViewColumn[]
			{
				this.C_Id
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
			this.dgvData.Location = new global::System.Drawing.Point(0, 97);
			this.dgvData.Name = "dgvData";
			this.dgvData.ReadOnly = true;
			this.dgvData.RowHeadersVisible = false;
			this.dgvData.RowTemplate.Height = 23;
			this.dgvData.SelectionMode = global::System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvData.Size = new global::System.Drawing.Size(1787, 320);
			this.dgvData.TabIndex = 13;
			this.dgvData.CellContentClick += new global::System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellContentClick);
			this.C_Id.DataPropertyName = "Id";
			this.C_Id.HeaderText = "ID";
			this.C_Id.Name = "C_Id";
			this.C_Id.ReadOnly = true;
			this.C_Id.SortMode = global::System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.C_Id.Visible = false;
			this.pnlConfig.CanvasColor = global::System.Drawing.SystemColors.Control;
			this.pnlConfig.ColorSchemeStyle = global::DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
			this.pnlConfig.Controls.Add(this.layoutControl1);
			this.pnlConfig.DisabledBackColor = global::System.Drawing.Color.Empty;
			this.pnlConfig.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.pnlConfig.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.pnlConfig.Location = new global::System.Drawing.Point(0, 27);
			this.pnlConfig.Name = "pnlConfig";
			this.pnlConfig.Size = new global::System.Drawing.Size(1787, 70);
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
			this.pnlConfig.TabIndex = 14;
			this.layoutControl1.BackColor = global::System.Drawing.Color.Transparent;
			this.layoutControl1.Controls.Add(this.cmbAccountType);
			this.layoutControl1.Controls.Add(this.cmbBusinessType);
			this.layoutControl1.Controls.Add(this.cmbUnit);
			this.layoutControl1.Controls.Add(this.cmbProduct);
			this.layoutControl1.Controls.Add(this.cmbClient);
			this.layoutControl1.Controls.Add(this.txtCheNum);
			this.layoutControl1.Controls.Add(this.txtJieSuanRen);
			this.layoutControl1.Controls.Add(this.dtpStartTime);
			this.layoutControl1.Controls.Add(this.dtpEndTime);
			this.layoutControl1.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.layoutControl1.Location = new global::System.Drawing.Point(0, 0);
			this.layoutControl1.Name = "layoutControl1";
			this.layoutControl1.RootGroup.Items.AddRange(new global::DevComponents.DotNetBar.Layout.LayoutItemBase[]
			{
				this.layoutControlItem1,
				this.layoutControlItem2,
				this.layoutControlItem8,
				this.layoutControlItem9,
				this.layoutControlItem3,
				this.layoutControlItem4,
				this.layoutControlItem5,
				this.layoutControlItem6,
				this.layoutControlItem7
			});
			this.layoutControl1.Size = new global::System.Drawing.Size(1156, 64);
			this.layoutControl1.TabIndex = 51;
			this.layoutControlItem1.Control = this.cmbAccountType;
			this.layoutControlItem1.Height = 32;
			this.layoutControlItem1.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Text = "PaymentType";
			this.layoutControlItem1.Width = 20;
			this.layoutControlItem1.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem2.Control = this.cmbBusinessType;
			this.layoutControlItem2.Height = 32;
			this.layoutControlItem2.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem2.Name = "layoutControlItem2";
			this.layoutControlItem2.Text = "BusinessType";
			this.layoutControlItem2.Width = 20;
			this.layoutControlItem2.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem8.Control = this.dtpStartTime;
			this.layoutControlItem8.Height = 29;
			this.layoutControlItem8.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem8.Name = "layoutControlItem8";
			this.layoutControlItem8.Text = "StartTime";
			this.layoutControlItem8.Width = 30;
			this.layoutControlItem8.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem9.Control = this.dtpEndTime;
			this.layoutControlItem9.Height = 29;
			this.layoutControlItem9.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem9.Name = "layoutControlItem9";
			this.layoutControlItem9.Text = "EndTime";
			this.layoutControlItem9.Width = 30;
			this.layoutControlItem9.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem3.Control = this.cmbUnit;
			this.layoutControlItem3.Height = 32;
			this.layoutControlItem3.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem3.Name = "layoutControlItem3";
			this.layoutControlItem3.Text = "Unit";
			this.layoutControlItem3.Width = 20;
			this.layoutControlItem3.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem4.Control = this.cmbProduct;
			this.layoutControlItem4.Height = 32;
			this.layoutControlItem4.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem4.Name = "layoutControlItem4";
			this.layoutControlItem4.Text = "Product";
			this.layoutControlItem4.Width = 20;
			this.layoutControlItem4.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem5.Control = this.cmbClient;
			this.layoutControlItem5.Height = 32;
			this.layoutControlItem5.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem5.Name = "layoutControlItem5";
			this.layoutControlItem5.Text = "Customer";
			this.layoutControlItem5.Width = 20;
			this.layoutControlItem5.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem6.Control = this.txtCheNum;
			this.layoutControlItem6.Height = 31;
			this.layoutControlItem6.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem6.Name = "layoutControlItem6";
			this.layoutControlItem6.Text = "CheNum";
			this.layoutControlItem6.Width = 20;
			this.layoutControlItem6.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem7.Control = this.txtJieSuanRen;
			this.layoutControlItem7.Height = 31;
			this.layoutControlItem7.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem7.Name = "layoutControlItem7";
			this.layoutControlItem7.Text = "JieSuanRen";
			this.layoutControlItem7.Width = 20;
			this.layoutControlItem7.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			base.ClientSize = new global::System.Drawing.Size(1787, 417);
			base.Controls.Add(this.dgvData);
			base.Controls.Add(this.pnlConfig);
			base.Controls.Add(this.bar);
			base.Name = "frmReport";
			this.Text = "HistoricalData";
			base.Load += new global::System.EventHandler(this.frmReport_Load);
			((global::System.ComponentModel.ISupportInitialize)this.bar).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.dtpStartTime).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.dtpEndTime).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.dgvData).EndInit();
			this.pnlConfig.ResumeLayout(false);
			this.layoutControl1.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x04000B6A RID: 2922
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000B6B RID: 2923
		private global::DevComponents.DotNetBar.Bar bar;

		// Token: 0x04000B6C RID: 2924
		private global::DevComponents.DotNetBar.ButtonItem btnSearch;

		// Token: 0x04000B6D RID: 2925
		private global::DevComponents.DotNetBar.ButtonItem btnExport;

		// Token: 0x04000B6E RID: 2926
		private global::DevComponents.Editors.DateTimeAdv.DateTimeInput dtpStartTime;

		// Token: 0x04000B6F RID: 2927
		private global::DevComponents.Editors.DateTimeAdv.DateTimeInput dtpEndTime;

		// Token: 0x04000B70 RID: 2928
		private global::DevComponents.DotNetBar.ControlContainerItem controlContainerItem3;

		// Token: 0x04000B71 RID: 2929
		private global::Base.AutoComboBox cmbUnit;

		// Token: 0x04000B72 RID: 2930
		private global::Base.AutoComboBox cmbProduct;

		// Token: 0x04000B73 RID: 2931
		private global::DevComponents.DotNetBar.ControlContainerItem controlContainerItem4;

		// Token: 0x04000B74 RID: 2932
		private global::Base.AutoComboBox cmbClient;

		// Token: 0x04000B75 RID: 2933
		private global::DevComponents.DotNetBar.ControlContainerItem controlContainerItem8;

		// Token: 0x04000B76 RID: 2934
		private global::DevComponents.DotNetBar.ControlContainerItem controlContainerItem9;

		// Token: 0x04000B77 RID: 2935
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtCheNum;

		// Token: 0x04000B78 RID: 2936
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtJieSuanRen;

		// Token: 0x04000B79 RID: 2937
		private global::DevComponents.DotNetBar.ButtonItem btnItemC;

		// Token: 0x04000B7A RID: 2938
		private global::DevComponents.DotNetBar.ControlContainerItem controlContainerItem12;

		// Token: 0x04000B7B RID: 2939
		private global::DevComponents.DotNetBar.Controls.ComboBoxEx cmbBusinessType;

		// Token: 0x04000B7C RID: 2940
		private global::DevComponents.DotNetBar.Controls.ComboBoxEx cmbAccountType;

		// Token: 0x04000B7D RID: 2941
		private global::DevComponents.DotNetBar.Controls.DataGridViewX dgvData;

		// Token: 0x04000B7E RID: 2942
		private global::DevComponents.DotNetBar.Controls.GroupPanel pnlConfig;

		// Token: 0x04000B7F RID: 2943
		private global::DevComponents.DotNetBar.Layout.LayoutControl layoutControl1;

		// Token: 0x04000B80 RID: 2944
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem1;

		// Token: 0x04000B81 RID: 2945
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem2;

		// Token: 0x04000B82 RID: 2946
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem3;

		// Token: 0x04000B83 RID: 2947
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem4;

		// Token: 0x04000B84 RID: 2948
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem5;

		// Token: 0x04000B85 RID: 2949
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem6;

		// Token: 0x04000B86 RID: 2950
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem7;

		// Token: 0x04000B87 RID: 2951
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem8;

		// Token: 0x04000B88 RID: 2952
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem9;

		// Token: 0x04000B89 RID: 2953
		private global::DevComponents.DotNetBar.ButtonItem btnPrint;

		// Token: 0x04000B8A RID: 2954
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_Id;
	}
}
