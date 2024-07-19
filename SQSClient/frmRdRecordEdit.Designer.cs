namespace SQSClient
{
	// Token: 0x02000048 RID: 72
	public partial class frmRdRecordEdit : global::SQSClient.BaseDialogForm
	{
		// Token: 0x06000361 RID: 865 RVA: 0x000535C0 File Offset: 0x000517C0
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000362 RID: 866 RVA: 0x000535F8 File Offset: 0x000517F8
		private void InitializeComponent()
		{
			this.menuBar = new global::DevComponents.DotNetBar.Bar();
			this.btnSave = new global::DevComponents.DotNetBar.ButtonItem();
			this.layoutControl1 = new global::DevComponents.DotNetBar.Layout.LayoutControl();
			this.tInputChkDate = new global::DevComponents.Editors.DateTimeAdv.DateTimeInput();
			this.txtShipAddress = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.cmbWhName = new global::Base.AutoComboBox();
			this.txtRdCode = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.rtbMemo = new global::DevComponents.DotNetBar.Controls.RichTextBoxEx();
			this.txtVouchType = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.txtSource = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.txtDepName = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.cmbRdFlag = new global::DevComponents.DotNetBar.Controls.ComboBoxEx();
			this.cmbRdStatus = new global::DevComponents.DotNetBar.Controls.ComboBoxEx();
			this.tInputARVDate = new global::DevComponents.Editors.DateTimeAdv.DateTimeInput();
			this.txtRdPerson = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.txtMaker = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.txtHandler = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.txtAccounter = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.cmbBusType = new global::DevComponents.DotNetBar.Controls.ComboBoxEx();
			this.layoutControlItem1 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem15 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem3 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem17 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem20 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem22 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem8 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem19 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem11 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem10 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem4 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem25 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem27 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem29 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem23 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem6 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem14 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem16 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem18 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem5 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem21 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem2 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem7 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem24 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem26 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem28 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			((global::System.ComponentModel.ISupportInitialize)this.menuBar).BeginInit();
			this.layoutControl1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.tInputChkDate).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.tInputARVDate).BeginInit();
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
			this.menuBar.Size = new global::System.Drawing.Size(513, 26);
			this.menuBar.Stretch = true;
			this.menuBar.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.menuBar.TabIndex = 19;
			this.menuBar.TabStop = false;
			this.menuBar.Text = "Main Menu";
			this.btnSave.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.btnSave.Image = global::SQSClient.Properties.Resources.save16;
			this.btnSave.Name = "btnSave";
			this.btnSave.Text = "Save";
			this.btnSave.Click += new global::System.EventHandler(this.btnSave_Click);
			this.layoutControl1.Controls.Add(this.tInputChkDate);
			this.layoutControl1.Controls.Add(this.txtShipAddress);
			this.layoutControl1.Controls.Add(this.cmbWhName);
			this.layoutControl1.Controls.Add(this.txtRdCode);
			this.layoutControl1.Controls.Add(this.rtbMemo);
			this.layoutControl1.Controls.Add(this.txtVouchType);
			this.layoutControl1.Controls.Add(this.txtSource);
			this.layoutControl1.Controls.Add(this.txtDepName);
			this.layoutControl1.Controls.Add(this.cmbRdFlag);
			this.layoutControl1.Controls.Add(this.cmbRdStatus);
			this.layoutControl1.Controls.Add(this.tInputARVDate);
			this.layoutControl1.Controls.Add(this.txtRdPerson);
			this.layoutControl1.Controls.Add(this.txtMaker);
			this.layoutControl1.Controls.Add(this.txtHandler);
			this.layoutControl1.Controls.Add(this.txtAccounter);
			this.layoutControl1.Controls.Add(this.cmbBusType);
			this.layoutControl1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.layoutControl1.Location = new global::System.Drawing.Point(0, 26);
			this.layoutControl1.Name = "layoutControl1";
			this.layoutControl1.RootGroup.Items.AddRange(new global::DevComponents.DotNetBar.Layout.LayoutItemBase[]
			{
				this.layoutControlItem1,
				this.layoutControlItem15,
				this.layoutControlItem3,
				this.layoutControlItem17,
				this.layoutControlItem20,
				this.layoutControlItem22,
				this.layoutControlItem8,
				this.layoutControlItem19,
				this.layoutControlItem11,
				this.layoutControlItem10,
				this.layoutControlItem4,
				this.layoutControlItem25,
				this.layoutControlItem27,
				this.layoutControlItem29,
				this.layoutControlItem23,
				this.layoutControlItem6
			});
			this.layoutControl1.Size = new global::System.Drawing.Size(513, 415);
			this.layoutControl1.TabIndex = 22;
			this.tInputChkDate.BackgroundStyle.Class = "DateTimeInputBackground";
			this.tInputChkDate.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.tInputChkDate.ButtonDropDown.Shortcut = global::DevComponents.DotNetBar.eShortcut.AltDown;
			this.tInputChkDate.ButtonDropDown.Visible = true;
			this.tInputChkDate.IsPopupCalendarOpen = false;
			this.tInputChkDate.Location = new global::System.Drawing.Point(336, 148);
			this.tInputChkDate.Margin = new global::System.Windows.Forms.Padding(0);
			this.tInputChkDate.MonthCalendar.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.tInputChkDate.MonthCalendar.CalendarDimensions = new global::System.Drawing.Size(1, 1);
			this.tInputChkDate.MonthCalendar.ClearButtonVisible = true;
			this.tInputChkDate.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = global::DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
			this.tInputChkDate.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
			this.tInputChkDate.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.BarBackground;
			this.tInputChkDate.MonthCalendar.CommandsBackgroundStyle.BorderTop = global::DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.tInputChkDate.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
			this.tInputChkDate.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
			this.tInputChkDate.MonthCalendar.CommandsBackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.tInputChkDate.MonthCalendar.DisplayMonth = new global::System.DateTime(2018, 12, 1, 0, 0, 0, 0);
			this.tInputChkDate.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
			this.tInputChkDate.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
			this.tInputChkDate.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
			this.tInputChkDate.MonthCalendar.NavigationBackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.tInputChkDate.MonthCalendar.TodayButtonVisible = true;
			this.tInputChkDate.Name = "tInputChkDate";
			this.tInputChkDate.Size = new global::System.Drawing.Size(173, 21);
			this.tInputChkDate.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.tInputChkDate.TabIndex = 9;
			this.txtShipAddress.Border.Class = "TextBoxBorder";
			this.txtShipAddress.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtShipAddress.Location = new global::System.Drawing.Point(80, 177);
			this.txtShipAddress.Margin = new global::System.Windows.Forms.Padding(0);
			this.txtShipAddress.Name = "txtShipAddress";
			this.txtShipAddress.PreventEnterBeep = true;
			this.txtShipAddress.Size = new global::System.Drawing.Size(429, 21);
			this.txtShipAddress.TabIndex = 10;
			this.cmbWhName.DataSource = null;
			this.cmbWhName.DisplayMember = null;
			this.cmbWhName.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cmbWhName.FormattingEnabled = true;
			this.cmbWhName.ItemHeight = 15;
			this.cmbWhName.Location = new global::System.Drawing.Point(80, 91);
			this.cmbWhName.Margin = new global::System.Windows.Forms.Padding(0);
			this.cmbWhName.MaxDropDownItems = 20;
			this.cmbWhName.Name = "cmbWhName";
			this.cmbWhName.SelectMember = null;
			this.cmbWhName.Size = new global::System.Drawing.Size(429, 21);
			this.cmbWhName.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.cmbWhName.TabIndex = 6;
			this.cmbWhName.ValueMember = null;
			this.txtRdCode.Border.Class = "TextBoxBorder";
			this.txtRdCode.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtRdCode.Location = new global::System.Drawing.Point(80, 4);
			this.txtRdCode.Margin = new global::System.Windows.Forms.Padding(0);
			this.txtRdCode.Name = "txtRdCode";
			this.txtRdCode.PreventEnterBeep = true;
			this.txtRdCode.Size = new global::System.Drawing.Size(172, 21);
			this.txtRdCode.TabIndex = 0;
			this.rtbMemo.BackgroundStyle.Class = "RichTextBoxBorder";
			this.rtbMemo.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.rtbMemo.Location = new global::System.Drawing.Point(80, 264);
			this.rtbMemo.Margin = new global::System.Windows.Forms.Padding(0);
			this.rtbMemo.MaxLength = 200;
			this.rtbMemo.Name = "rtbMemo";
			this.rtbMemo.Rtf = "{\\rtf1\\ansi\\ansicpg936\\deff0\\nouicompat\\deflang1033\\deflangfe2052{\\fonttbl{\\f0\\fnil\\fcharset134 \\'cb\\'ce\\'cc\\'e5;}}\r\n{\\*\\generator Riched20 10.0.18362}\\viewkind4\\uc1 \r\n\\pard\\f0\\fs18\\lang2052\\par\r\n}\r\n";
			this.rtbMemo.Size = new global::System.Drawing.Size(429, 52);
			this.rtbMemo.TabIndex = 15;
			this.txtVouchType.Border.Class = "TextBoxBorder";
			this.txtVouchType.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtVouchType.Location = new global::System.Drawing.Point(336, 4);
			this.txtVouchType.Margin = new global::System.Windows.Forms.Padding(0);
			this.txtVouchType.Name = "txtVouchType";
			this.txtVouchType.PreventEnterBeep = true;
			this.txtVouchType.Size = new global::System.Drawing.Size(173, 21);
			this.txtVouchType.TabIndex = 1;
			this.txtSource.Border.Class = "TextBoxBorder";
			this.txtSource.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtSource.Location = new global::System.Drawing.Point(336, 33);
			this.txtSource.Margin = new global::System.Windows.Forms.Padding(0);
			this.txtSource.Name = "txtSource";
			this.txtSource.PreventEnterBeep = true;
			this.txtSource.Size = new global::System.Drawing.Size(173, 21);
			this.txtSource.TabIndex = 3;
			this.txtDepName.Border.Class = "TextBoxBorder";
			this.txtDepName.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtDepName.Location = new global::System.Drawing.Point(80, 119);
			this.txtDepName.Margin = new global::System.Windows.Forms.Padding(0);
			this.txtDepName.Name = "txtDepName";
			this.txtDepName.PreventEnterBeep = true;
			this.txtDepName.Size = new global::System.Drawing.Size(429, 21);
			this.txtDepName.TabIndex = 7;
			this.cmbRdFlag.DisplayMember = "Text";
			this.cmbRdFlag.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cmbRdFlag.FormattingEnabled = true;
			this.cmbRdFlag.ItemHeight = 15;
			this.cmbRdFlag.Location = new global::System.Drawing.Point(80, 62);
			this.cmbRdFlag.Margin = new global::System.Windows.Forms.Padding(0);
			this.cmbRdFlag.Name = "cmbRdFlag";
			this.cmbRdFlag.Size = new global::System.Drawing.Size(172, 21);
			this.cmbRdFlag.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.cmbRdFlag.TabIndex = 4;
			this.cmbRdStatus.DisplayMember = "Text";
			this.cmbRdStatus.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cmbRdStatus.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbRdStatus.FormattingEnabled = true;
			this.cmbRdStatus.ItemHeight = 15;
			this.cmbRdStatus.Location = new global::System.Drawing.Point(336, 62);
			this.cmbRdStatus.Margin = new global::System.Windows.Forms.Padding(0);
			this.cmbRdStatus.Name = "cmbRdStatus";
			this.cmbRdStatus.Size = new global::System.Drawing.Size(173, 21);
			this.cmbRdStatus.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.cmbRdStatus.TabIndex = 5;
			this.tInputARVDate.BackgroundStyle.Class = "DateTimeInputBackground";
			this.tInputARVDate.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.tInputARVDate.ButtonDropDown.Shortcut = global::DevComponents.DotNetBar.eShortcut.AltDown;
			this.tInputARVDate.ButtonDropDown.Visible = true;
			this.tInputARVDate.IsPopupCalendarOpen = false;
			this.tInputARVDate.Location = new global::System.Drawing.Point(80, 148);
			this.tInputARVDate.Margin = new global::System.Windows.Forms.Padding(0);
			this.tInputARVDate.MonthCalendar.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.tInputARVDate.MonthCalendar.CalendarDimensions = new global::System.Drawing.Size(1, 1);
			this.tInputARVDate.MonthCalendar.ClearButtonVisible = true;
			this.tInputARVDate.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = global::DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
			this.tInputARVDate.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
			this.tInputARVDate.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.BarBackground;
			this.tInputARVDate.MonthCalendar.CommandsBackgroundStyle.BorderTop = global::DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.tInputARVDate.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
			this.tInputARVDate.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
			this.tInputARVDate.MonthCalendar.CommandsBackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.tInputARVDate.MonthCalendar.DisplayMonth = new global::System.DateTime(2018, 12, 1, 0, 0, 0, 0);
			this.tInputARVDate.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
			this.tInputARVDate.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
			this.tInputARVDate.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
			this.tInputARVDate.MonthCalendar.NavigationBackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.tInputARVDate.MonthCalendar.TodayButtonVisible = true;
			this.tInputARVDate.Name = "tInputARVDate";
			this.tInputARVDate.Size = new global::System.Drawing.Size(172, 21);
			this.tInputARVDate.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.tInputARVDate.TabIndex = 8;
			this.txtRdPerson.Border.Class = "TextBoxBorder";
			this.txtRdPerson.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtRdPerson.Location = new global::System.Drawing.Point(336, 235);
			this.txtRdPerson.Margin = new global::System.Windows.Forms.Padding(0);
			this.txtRdPerson.Name = "txtRdPerson";
			this.txtRdPerson.PreventEnterBeep = true;
			this.txtRdPerson.Size = new global::System.Drawing.Size(173, 21);
			this.txtRdPerson.TabIndex = 14;
			this.txtMaker.Border.Class = "TextBoxBorder";
			this.txtMaker.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtMaker.Location = new global::System.Drawing.Point(80, 206);
			this.txtMaker.Margin = new global::System.Windows.Forms.Padding(0);
			this.txtMaker.Name = "txtMaker";
			this.txtMaker.PreventEnterBeep = true;
			this.txtMaker.Size = new global::System.Drawing.Size(172, 21);
			this.txtMaker.TabIndex = 11;
			this.txtHandler.Border.Class = "TextBoxBorder";
			this.txtHandler.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtHandler.Location = new global::System.Drawing.Point(336, 206);
			this.txtHandler.Margin = new global::System.Windows.Forms.Padding(0);
			this.txtHandler.Name = "txtHandler";
			this.txtHandler.PreventEnterBeep = true;
			this.txtHandler.Size = new global::System.Drawing.Size(173, 21);
			this.txtHandler.TabIndex = 12;
			this.txtAccounter.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtAccounter.Location = new global::System.Drawing.Point(80, 235);
			this.txtAccounter.Margin = new global::System.Windows.Forms.Padding(0);
			this.txtAccounter.Name = "txtAccounter";
			this.txtAccounter.PreventEnterBeep = true;
			this.txtAccounter.Size = new global::System.Drawing.Size(172, 15);
			this.txtAccounter.TabIndex = 13;
			this.cmbBusType.DisplayMember = "Text";
			this.cmbBusType.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cmbBusType.FormattingEnabled = true;
			this.cmbBusType.ItemHeight = 15;
			this.cmbBusType.Location = new global::System.Drawing.Point(80, 33);
			this.cmbBusType.Margin = new global::System.Windows.Forms.Padding(0);
			this.cmbBusType.Name = "cmbBusType";
			this.cmbBusType.Size = new global::System.Drawing.Size(172, 21);
			this.cmbBusType.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.cmbBusType.TabIndex = 2;
			this.layoutControlItem1.Control = this.txtRdCode;
			this.layoutControlItem1.Height = 29;
			this.layoutControlItem1.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Text = "*RdCode";
			this.layoutControlItem1.Width = 50;
			this.layoutControlItem1.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem15.Control = this.txtVouchType;
			this.layoutControlItem15.Height = 29;
			this.layoutControlItem15.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem15.Name = "layoutControlItem15";
			this.layoutControlItem15.Text = "VouchType";
			this.layoutControlItem15.Width = 50;
			this.layoutControlItem15.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem3.Control = this.cmbBusType;
			this.layoutControlItem3.Height = 29;
			this.layoutControlItem3.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem3.Name = "layoutControlItem3";
			this.layoutControlItem3.Text = "BusType";
			this.layoutControlItem3.Width = 50;
			this.layoutControlItem3.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem17.Control = this.txtSource;
			this.layoutControlItem17.Height = 29;
			this.layoutControlItem17.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem17.Name = "layoutControlItem17";
			this.layoutControlItem17.Text = "Source";
			this.layoutControlItem17.Width = 50;
			this.layoutControlItem17.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem20.Control = this.cmbRdFlag;
			this.layoutControlItem20.Height = 29;
			this.layoutControlItem20.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem20.Name = "layoutControlItem20";
			this.layoutControlItem20.Text = "RdFlag";
			this.layoutControlItem20.Width = 50;
			this.layoutControlItem20.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem22.Control = this.cmbRdStatus;
			this.layoutControlItem22.Height = 29;
			this.layoutControlItem22.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem22.Name = "layoutControlItem22";
			this.layoutControlItem22.Text = "RdStatus";
			this.layoutControlItem22.Width = 50;
			this.layoutControlItem22.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem8.Control = this.cmbWhName;
			this.layoutControlItem8.Height = 28;
			this.layoutControlItem8.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem8.Name = "layoutControlItem8";
			this.layoutControlItem8.Text = "WhName";
			this.layoutControlItem8.Width = 100;
			this.layoutControlItem8.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem19.Control = this.txtDepName;
			this.layoutControlItem19.Height = 29;
			this.layoutControlItem19.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem19.Name = "layoutControlItem19";
			this.layoutControlItem19.Text = "DepName";
			this.layoutControlItem19.Width = 100;
			this.layoutControlItem19.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem11.Control = this.tInputARVDate;
			this.layoutControlItem11.Height = 29;
			this.layoutControlItem11.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem11.Name = "layoutControlItem11";
			this.layoutControlItem11.Text = "ARVDate";
			this.layoutControlItem11.Width = 50;
			this.layoutControlItem11.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem10.Control = this.tInputChkDate;
			this.layoutControlItem10.Height = 29;
			this.layoutControlItem10.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem10.Name = "layoutControlItem10";
			this.layoutControlItem10.Text = "ChkDate";
			this.layoutControlItem10.Width = 50;
			this.layoutControlItem10.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem4.Control = this.txtShipAddress;
			this.layoutControlItem4.Height = 29;
			this.layoutControlItem4.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem4.Name = "layoutControlItem4";
			this.layoutControlItem4.Text = "ShipAddress";
			this.layoutControlItem4.Width = 100;
			this.layoutControlItem4.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem25.Control = this.txtMaker;
			this.layoutControlItem25.Height = 29;
			this.layoutControlItem25.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem25.Name = "layoutControlItem25";
			this.layoutControlItem25.Text = "Maker";
			this.layoutControlItem25.Width = 50;
			this.layoutControlItem25.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem27.Control = this.txtHandler;
			this.layoutControlItem27.Height = 29;
			this.layoutControlItem27.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem27.Name = "layoutControlItem27";
			this.layoutControlItem27.Text = "Handler";
			this.layoutControlItem27.Width = 50;
			this.layoutControlItem27.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem29.Control = this.txtAccounter;
			this.layoutControlItem29.Height = 29;
			this.layoutControlItem29.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem29.Name = "layoutControlItem29";
			this.layoutControlItem29.Text = "Accounter";
			this.layoutControlItem29.Width = 50;
			this.layoutControlItem29.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem23.Control = this.txtRdPerson;
			this.layoutControlItem23.Height = 29;
			this.layoutControlItem23.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem23.Name = "layoutControlItem23";
			this.layoutControlItem23.Text = "RdPerson";
			this.layoutControlItem23.Width = 50;
			this.layoutControlItem23.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem6.Control = this.rtbMemo;
			this.layoutControlItem6.Height = 60;
			this.layoutControlItem6.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem6.Name = "layoutControlItem6";
			this.layoutControlItem6.Text = "Memo";
			this.layoutControlItem6.Width = 100;
			this.layoutControlItem6.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem14.Control = this.txtVouchType;
			this.layoutControlItem14.Height = 29;
			this.layoutControlItem14.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem14.Name = "layoutControlItem14";
			this.layoutControlItem14.Text = "Signer";
			this.layoutControlItem14.Width = 100;
			this.layoutControlItem14.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem16.Control = this.txtSource;
			this.layoutControlItem16.Height = 29;
			this.layoutControlItem16.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem16.Name = "layoutControlItem16";
			this.layoutControlItem16.Text = "VouchType";
			this.layoutControlItem16.Width = 50;
			this.layoutControlItem16.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem18.Control = this.txtDepName;
			this.layoutControlItem18.Height = 29;
			this.layoutControlItem18.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem18.Name = "layoutControlItem18";
			this.layoutControlItem18.Text = "Signer";
			this.layoutControlItem18.Width = 100;
			this.layoutControlItem18.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem5.Control = this.cmbRdFlag;
			this.layoutControlItem5.Height = 29;
			this.layoutControlItem5.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem5.Name = "layoutControlItem5";
			this.layoutControlItem5.Text = "RdFlag";
			this.layoutControlItem5.Width = 20;
			this.layoutControlItem5.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem21.Control = this.cmbRdStatus;
			this.layoutControlItem21.Height = 29;
			this.layoutControlItem21.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem21.Name = "layoutControlItem21";
			this.layoutControlItem21.Text = "RdStatus";
			this.layoutControlItem21.Width = 20;
			this.layoutControlItem21.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem2.Control = this.tInputARVDate;
			this.layoutControlItem2.Height = 29;
			this.layoutControlItem2.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem2.Name = "layoutControlItem2";
			this.layoutControlItem2.Text = "*CreateDate";
			this.layoutControlItem2.Width = 100;
			this.layoutControlItem2.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem7.Control = this.txtRdPerson;
			this.layoutControlItem7.Height = 29;
			this.layoutControlItem7.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem7.Name = "layoutControlItem7";
			this.layoutControlItem7.Text = "DepName";
			this.layoutControlItem7.Width = 100;
			this.layoutControlItem7.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem24.Control = this.txtMaker;
			this.layoutControlItem24.Height = 29;
			this.layoutControlItem24.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem24.Name = "layoutControlItem24";
			this.layoutControlItem24.Text = "RdPerson";
			this.layoutControlItem24.Width = 50;
			this.layoutControlItem24.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem26.Control = this.txtHandler;
			this.layoutControlItem26.Height = 29;
			this.layoutControlItem26.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem26.Name = "layoutControlItem26";
			this.layoutControlItem26.Text = "RdPerson";
			this.layoutControlItem26.Width = 50;
			this.layoutControlItem26.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem28.Control = this.txtAccounter;
			this.layoutControlItem28.Height = 29;
			this.layoutControlItem28.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem28.Name = "layoutControlItem28";
			this.layoutControlItem28.Text = "Maker";
			this.layoutControlItem28.Width = 50;
			this.layoutControlItem28.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			base.ClientSize = new global::System.Drawing.Size(513, 441);
			base.Controls.Add(this.layoutControl1);
			base.Controls.Add(this.menuBar);
			base.Name = "frmRdRecordEdit";
			this.Text = "frmRdRecordEdit";
			base.Load += new global::System.EventHandler(this.frmRdRecordEdit_Load);
			((global::System.ComponentModel.ISupportInitialize)this.menuBar).EndInit();
			this.layoutControl1.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.tInputChkDate).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.tInputARVDate).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000560 RID: 1376
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000561 RID: 1377
		private global::DevComponents.DotNetBar.Bar menuBar;

		// Token: 0x04000562 RID: 1378
		private global::DevComponents.DotNetBar.ButtonItem btnSave;

		// Token: 0x04000563 RID: 1379
		private global::DevComponents.DotNetBar.Layout.LayoutControl layoutControl1;

		// Token: 0x04000564 RID: 1380
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtRdCode;

		// Token: 0x04000565 RID: 1381
		private global::DevComponents.DotNetBar.Controls.RichTextBoxEx rtbMemo;

		// Token: 0x04000566 RID: 1382
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem1;

		// Token: 0x04000567 RID: 1383
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem6;

		// Token: 0x04000568 RID: 1384
		private global::DevComponents.Editors.DateTimeAdv.DateTimeInput tInputChkDate;

		// Token: 0x04000569 RID: 1385
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtShipAddress;

		// Token: 0x0400056A RID: 1386
		private global::Base.AutoComboBox cmbWhName;

		// Token: 0x0400056B RID: 1387
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem8;

		// Token: 0x0400056C RID: 1388
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem4;

		// Token: 0x0400056D RID: 1389
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem10;

		// Token: 0x0400056E RID: 1390
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtVouchType;

		// Token: 0x0400056F RID: 1391
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem15;

		// Token: 0x04000570 RID: 1392
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem14;

		// Token: 0x04000571 RID: 1393
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtSource;

		// Token: 0x04000572 RID: 1394
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem17;

		// Token: 0x04000573 RID: 1395
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem16;

		// Token: 0x04000574 RID: 1396
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtDepName;

		// Token: 0x04000575 RID: 1397
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem19;

		// Token: 0x04000576 RID: 1398
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem18;

		// Token: 0x04000577 RID: 1399
		private global::DevComponents.DotNetBar.Controls.ComboBoxEx cmbRdFlag;

		// Token: 0x04000578 RID: 1400
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem20;

		// Token: 0x04000579 RID: 1401
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem5;

		// Token: 0x0400057A RID: 1402
		private global::DevComponents.DotNetBar.Controls.ComboBoxEx cmbRdStatus;

		// Token: 0x0400057B RID: 1403
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem22;

		// Token: 0x0400057C RID: 1404
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem21;

		// Token: 0x0400057D RID: 1405
		private global::DevComponents.Editors.DateTimeAdv.DateTimeInput tInputARVDate;

		// Token: 0x0400057E RID: 1406
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtRdPerson;

		// Token: 0x0400057F RID: 1407
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtMaker;

		// Token: 0x04000580 RID: 1408
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtHandler;

		// Token: 0x04000581 RID: 1409
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtAccounter;

		// Token: 0x04000582 RID: 1410
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem11;

		// Token: 0x04000583 RID: 1411
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem23;

		// Token: 0x04000584 RID: 1412
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem25;

		// Token: 0x04000585 RID: 1413
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem27;

		// Token: 0x04000586 RID: 1414
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem29;

		// Token: 0x04000587 RID: 1415
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem2;

		// Token: 0x04000588 RID: 1416
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem7;

		// Token: 0x04000589 RID: 1417
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem24;

		// Token: 0x0400058A RID: 1418
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem26;

		// Token: 0x0400058B RID: 1419
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem28;

		// Token: 0x0400058C RID: 1420
		private global::DevComponents.DotNetBar.Controls.ComboBoxEx cmbBusType;

		// Token: 0x0400058D RID: 1421
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem3;
	}
}
