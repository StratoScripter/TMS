namespace SQSClient
{
	// Token: 0x0200000D RID: 13
	public partial class frmAdvancedQuery : global::SQSClient.BaseDialogForm
	{
		// Token: 0x0600006A RID: 106 RVA: 0x00004A58 File Offset: 0x00002C58
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00004A90 File Offset: 0x00002C90
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::SQSClient.frmAdvancedQuery));
			this.menuBar = new global::DevComponents.DotNetBar.Bar();
			this.btnQuery = new global::DevComponents.DotNetBar.ButtonItem();
			this.layoutControl1 = new global::DevComponents.DotNetBar.Layout.LayoutControl();
			this.lbxMenu = new global::DevComponents.DotNetBar.ListBoxAdv();
			this.dtpStartZhiDanTime = new global::DevComponents.Editors.DateTimeAdv.DateTimeInput();
			this.cbxZhiDanTime = new global::DevComponents.DotNetBar.Controls.CheckBoxX();
			this.dtpEndZhiDanTime = new global::DevComponents.Editors.DateTimeAdv.DateTimeInput();
			this.dtpStartFirstTime = new global::DevComponents.Editors.DateTimeAdv.DateTimeInput();
			this.dtpEndFirstTime = new global::DevComponents.Editors.DateTimeAdv.DateTimeInput();
			this.cbxOneWeighed = new global::DevComponents.DotNetBar.Controls.CheckBoxX();
			this.cbxTwoWeighed = new global::DevComponents.DotNetBar.Controls.CheckBoxX();
			this.dtpStartSecondTime = new global::DevComponents.Editors.DateTimeAdv.DateTimeInput();
			this.dtpEndSecondTime = new global::DevComponents.Editors.DateTimeAdv.DateTimeInput();
			this.cbxEnterTime = new global::DevComponents.DotNetBar.Controls.CheckBoxX();
			this.dtpStartEnterTime = new global::DevComponents.Editors.DateTimeAdv.DateTimeInput();
			this.dtpEndEnterTime = new global::DevComponents.Editors.DateTimeAdv.DateTimeInput();
			this.cbxLeaveTime = new global::DevComponents.DotNetBar.Controls.CheckBoxX();
			this.dtpStartLeaveTime = new global::DevComponents.Editors.DateTimeAdv.DateTimeInput();
			this.dtpEndLeaveTime = new global::DevComponents.Editors.DateTimeAdv.DateTimeInput();
			this.cbxJieSuanTime = new global::DevComponents.DotNetBar.Controls.CheckBoxX();
			this.dtpStartJieSuanTime = new global::DevComponents.Editors.DateTimeAdv.DateTimeInput();
			this.dtpEndJieSuanTime = new global::DevComponents.Editors.DateTimeAdv.DateTimeInput();
			this.cbxTakeCardTime = new global::DevComponents.DotNetBar.Controls.CheckBoxX();
			this.dtpStartTakeCardTime = new global::DevComponents.Editors.DateTimeAdv.DateTimeInput();
			this.dtpEndTakeCardTime = new global::DevComponents.Editors.DateTimeAdv.DateTimeInput();
			this.cbxProductInfo = new global::DevComponents.DotNetBar.Controls.CheckBoxX();
			this.tbxProductInfo = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.cbxIDCard = new global::DevComponents.DotNetBar.Controls.CheckBoxX();
			this.tbxIDCard = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.cbxSpecsDescribe = new global::DevComponents.DotNetBar.Controls.CheckBoxX();
			this.tbxSpecsDescribe = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.cbxPersonName = new global::DevComponents.DotNetBar.Controls.CheckBoxX();
			this.tbxPersonName = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.cbxSettleNoReturn = new global::DevComponents.DotNetBar.Controls.CheckBoxX();
			this.tbxClientpart = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.cbxClientpart = new global::DevComponents.DotNetBar.Controls.CheckBoxX();
			this.cbxStep = new global::DevComponents.DotNetBar.Controls.CheckBoxX();
			this.cbxLoader = new global::DevComponents.DotNetBar.Controls.CheckBoxX();
			this.lbxLoader = new global::DevComponents.DotNetBar.ListBoxAdv();
			this.cbxInvClass = new global::DevComponents.DotNetBar.Controls.CheckBoxX();
			this.lbxInvClass = new global::DevComponents.DotNetBar.ListBoxAdv();
			this.layoutControlItem1 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem5 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem3 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem10 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem8 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem9 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem12 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem14 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem16 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem17 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem19 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem21 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem22 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem23 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem24 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem26 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem27 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem29 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem30 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem32 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem34 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem35 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem36 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem41 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem42 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem38 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem39 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem43 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem44 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem47 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem46 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem45 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem49 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem50 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem52 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem48 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem51 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem53 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem6 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem2 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem4 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem7 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem11 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem13 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem15 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem18 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem20 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem25 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem28 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem31 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem33 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem37 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem40 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem54 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.cbxTruckSafeName = new global::DevComponents.DotNetBar.Controls.CheckBoxX();
			this.layoutControlItem55 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.lbxTruckSafeName = new global::DevComponents.DotNetBar.ListBoxAdv();
			this.layoutControlItem56 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			((global::System.ComponentModel.ISupportInitialize)this.menuBar).BeginInit();
			this.layoutControl1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dtpStartZhiDanTime).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.dtpEndZhiDanTime).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.dtpStartFirstTime).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.dtpEndFirstTime).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.dtpStartSecondTime).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.dtpEndSecondTime).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.dtpStartEnterTime).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.dtpEndEnterTime).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.dtpStartLeaveTime).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.dtpEndLeaveTime).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.dtpStartJieSuanTime).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.dtpEndJieSuanTime).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.dtpStartTakeCardTime).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.dtpEndTakeCardTime).BeginInit();
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
				this.btnQuery
			});
			this.menuBar.Location = new global::System.Drawing.Point(0, 0);
			this.menuBar.MenuBar = true;
			this.menuBar.Name = "menuBar";
			this.menuBar.Size = new global::System.Drawing.Size(725, 26);
			this.menuBar.Stretch = true;
			this.menuBar.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.menuBar.TabIndex = 20;
			this.menuBar.TabStop = false;
			this.menuBar.Text = "Main Menu";
			this.btnQuery.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.btnQuery.Image = global::SQSClient.Properties.Resources.setting16;
			this.btnQuery.Name = "btnQuery";
			this.btnQuery.Text = "ConfigTool";
			this.btnQuery.Click += new global::System.EventHandler(this.btnQuery_Click);
			this.layoutControl1.Controls.Add(this.lbxMenu);
			this.layoutControl1.Controls.Add(this.dtpStartZhiDanTime);
			this.layoutControl1.Controls.Add(this.cbxZhiDanTime);
			this.layoutControl1.Controls.Add(this.dtpEndZhiDanTime);
			this.layoutControl1.Controls.Add(this.dtpStartFirstTime);
			this.layoutControl1.Controls.Add(this.dtpEndFirstTime);
			this.layoutControl1.Controls.Add(this.cbxOneWeighed);
			this.layoutControl1.Controls.Add(this.cbxTwoWeighed);
			this.layoutControl1.Controls.Add(this.dtpStartSecondTime);
			this.layoutControl1.Controls.Add(this.dtpEndSecondTime);
			this.layoutControl1.Controls.Add(this.cbxEnterTime);
			this.layoutControl1.Controls.Add(this.dtpStartEnterTime);
			this.layoutControl1.Controls.Add(this.dtpEndEnterTime);
			this.layoutControl1.Controls.Add(this.cbxLeaveTime);
			this.layoutControl1.Controls.Add(this.dtpStartLeaveTime);
			this.layoutControl1.Controls.Add(this.dtpEndLeaveTime);
			this.layoutControl1.Controls.Add(this.cbxJieSuanTime);
			this.layoutControl1.Controls.Add(this.dtpStartJieSuanTime);
			this.layoutControl1.Controls.Add(this.dtpEndJieSuanTime);
			this.layoutControl1.Controls.Add(this.cbxTakeCardTime);
			this.layoutControl1.Controls.Add(this.dtpStartTakeCardTime);
			this.layoutControl1.Controls.Add(this.dtpEndTakeCardTime);
			this.layoutControl1.Controls.Add(this.cbxProductInfo);
			this.layoutControl1.Controls.Add(this.tbxProductInfo);
			this.layoutControl1.Controls.Add(this.cbxIDCard);
			this.layoutControl1.Controls.Add(this.tbxIDCard);
			this.layoutControl1.Controls.Add(this.cbxSpecsDescribe);
			this.layoutControl1.Controls.Add(this.tbxSpecsDescribe);
			this.layoutControl1.Controls.Add(this.cbxPersonName);
			this.layoutControl1.Controls.Add(this.tbxPersonName);
			this.layoutControl1.Controls.Add(this.cbxSettleNoReturn);
			this.layoutControl1.Controls.Add(this.tbxClientpart);
			this.layoutControl1.Controls.Add(this.cbxClientpart);
			this.layoutControl1.Controls.Add(this.cbxStep);
			this.layoutControl1.Controls.Add(this.cbxLoader);
			this.layoutControl1.Controls.Add(this.lbxLoader);
			this.layoutControl1.Controls.Add(this.cbxInvClass);
			this.layoutControl1.Controls.Add(this.lbxInvClass);
			this.layoutControl1.Controls.Add(this.cbxTruckSafeName);
			this.layoutControl1.Controls.Add(this.lbxTruckSafeName);
			this.layoutControl1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.layoutControl1.Location = new global::System.Drawing.Point(0, 26);
			this.layoutControl1.Name = "layoutControl1";
			this.layoutControl1.RootGroup.Items.AddRange(new global::DevComponents.DotNetBar.Layout.LayoutItemBase[]
			{
				this.layoutControlItem1,
				this.layoutControlItem5,
				this.layoutControlItem3,
				this.layoutControlItem10,
				this.layoutControlItem8,
				this.layoutControlItem9,
				this.layoutControlItem12,
				this.layoutControlItem14,
				this.layoutControlItem16,
				this.layoutControlItem17,
				this.layoutControlItem19,
				this.layoutControlItem21,
				this.layoutControlItem22,
				this.layoutControlItem23,
				this.layoutControlItem24,
				this.layoutControlItem26,
				this.layoutControlItem27,
				this.layoutControlItem29,
				this.layoutControlItem30,
				this.layoutControlItem32,
				this.layoutControlItem34,
				this.layoutControlItem35,
				this.layoutControlItem36,
				this.layoutControlItem41,
				this.layoutControlItem42,
				this.layoutControlItem38,
				this.layoutControlItem39,
				this.layoutControlItem43,
				this.layoutControlItem44,
				this.layoutControlItem47,
				this.layoutControlItem46,
				this.layoutControlItem45,
				this.layoutControlItem49,
				this.layoutControlItem50,
				this.layoutControlItem52,
				this.layoutControlItem55,
				this.layoutControlItem48,
				this.layoutControlItem51,
				this.layoutControlItem53,
				this.layoutControlItem56
			});
			this.layoutControl1.Size = new global::System.Drawing.Size(725, 527);
			this.layoutControl1.TabIndex = 21;
			this.lbxMenu.AutoScroll = true;
			this.lbxMenu.BackgroundStyle.Class = "ListBoxAdv";
			this.lbxMenu.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.lbxMenu.CheckStateMember = null;
			this.lbxMenu.ContainerControlProcessDialogKey = true;
			this.lbxMenu.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.lbxMenu.DragDropSupport = true;
			this.lbxMenu.EnableDragDrop = true;
			this.lbxMenu.Location = new global::System.Drawing.Point(4, 318);
			this.lbxMenu.Margin = new global::System.Windows.Forms.Padding(0);
			this.lbxMenu.Name = "lbxMenu";
			this.lbxMenu.SelectionMode = global::DevComponents.DotNetBar.eSelectionMode.MultiSimple;
			this.lbxMenu.Size = new global::System.Drawing.Size(173, 200);
			this.lbxMenu.TabIndex = 36;
			this.lbxMenu.ItemCheck += new global::DevComponents.DotNetBar.ListBoxAdvItemCheckEventHandler(this.lbxMenu_ItemCheck);
			this.dtpStartZhiDanTime.BackgroundStyle.Class = "DateTimeInputBackground";
			this.dtpStartZhiDanTime.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.dtpStartZhiDanTime.ButtonDropDown.Shortcut = global::DevComponents.DotNetBar.eShortcut.AltDown;
			this.dtpStartZhiDanTime.ButtonDropDown.Visible = true;
			this.dtpStartZhiDanTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
			this.dtpStartZhiDanTime.DateTimeSelectorVisibility = global::DevComponents.Editors.DateTimeAdv.eDateTimeSelectorVisibility.Both;
			this.dtpStartZhiDanTime.Format = global::DevComponents.Editors.eDateTimePickerFormat.Custom;
			this.dtpStartZhiDanTime.IsPopupCalendarOpen = false;
			this.dtpStartZhiDanTime.Location = new global::System.Drawing.Point(183, 4);
			this.dtpStartZhiDanTime.Margin = new global::System.Windows.Forms.Padding(0);
			this.dtpStartZhiDanTime.MonthCalendar.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.dtpStartZhiDanTime.MonthCalendar.CalendarDimensions = new global::System.Drawing.Size(1, 1);
			this.dtpStartZhiDanTime.MonthCalendar.ClearButtonVisible = true;
			this.dtpStartZhiDanTime.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = global::DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
			this.dtpStartZhiDanTime.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
			this.dtpStartZhiDanTime.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.BarBackground;
			this.dtpStartZhiDanTime.MonthCalendar.CommandsBackgroundStyle.BorderTop = global::DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.dtpStartZhiDanTime.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
			this.dtpStartZhiDanTime.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
			this.dtpStartZhiDanTime.MonthCalendar.CommandsBackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.dtpStartZhiDanTime.MonthCalendar.DayClickAutoClosePopup = false;
			this.dtpStartZhiDanTime.MonthCalendar.DisplayMonth = new global::System.DateTime(2016, 8, 1, 0, 0, 0, 0);
			this.dtpStartZhiDanTime.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
			this.dtpStartZhiDanTime.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
			this.dtpStartZhiDanTime.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
			this.dtpStartZhiDanTime.MonthCalendar.NavigationBackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.dtpStartZhiDanTime.MonthCalendar.TodayButtonVisible = true;
			this.dtpStartZhiDanTime.Name = "dtpStartZhiDanTime";
			this.dtpStartZhiDanTime.Size = new global::System.Drawing.Size(233, 21);
			this.dtpStartZhiDanTime.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.dtpStartZhiDanTime.TabIndex = 1;
			this.cbxZhiDanTime.AutoSize = true;
			this.cbxZhiDanTime.BackColor = global::System.Drawing.Color.Transparent;
			this.cbxZhiDanTime.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.cbxZhiDanTime.Location = new global::System.Drawing.Point(4, 4);
			this.cbxZhiDanTime.Margin = new global::System.Windows.Forms.Padding(0);
			this.cbxZhiDanTime.Name = "cbxZhiDanTime";
			this.cbxZhiDanTime.Size = new global::System.Drawing.Size(88, 16);
			this.cbxZhiDanTime.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.cbxZhiDanTime.TabIndex = 0;
			this.cbxZhiDanTime.Text = "ZhiDanTime";
			this.dtpEndZhiDanTime.BackgroundStyle.Class = "DateTimeInputBackground";
			this.dtpEndZhiDanTime.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.dtpEndZhiDanTime.ButtonDropDown.Shortcut = global::DevComponents.DotNetBar.eShortcut.AltDown;
			this.dtpEndZhiDanTime.ButtonDropDown.Visible = true;
			this.dtpEndZhiDanTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
			this.dtpEndZhiDanTime.DateTimeSelectorVisibility = global::DevComponents.Editors.DateTimeAdv.eDateTimeSelectorVisibility.Both;
			this.dtpEndZhiDanTime.Format = global::DevComponents.Editors.eDateTimePickerFormat.Custom;
			this.dtpEndZhiDanTime.IsPopupCalendarOpen = false;
			this.dtpEndZhiDanTime.Location = new global::System.Drawing.Point(487, 4);
			this.dtpEndZhiDanTime.Margin = new global::System.Windows.Forms.Padding(0);
			this.dtpEndZhiDanTime.MonthCalendar.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.dtpEndZhiDanTime.MonthCalendar.CalendarDimensions = new global::System.Drawing.Size(1, 1);
			this.dtpEndZhiDanTime.MonthCalendar.ClearButtonVisible = true;
			this.dtpEndZhiDanTime.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = global::DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
			this.dtpEndZhiDanTime.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
			this.dtpEndZhiDanTime.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.BarBackground;
			this.dtpEndZhiDanTime.MonthCalendar.CommandsBackgroundStyle.BorderTop = global::DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.dtpEndZhiDanTime.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
			this.dtpEndZhiDanTime.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
			this.dtpEndZhiDanTime.MonthCalendar.CommandsBackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.dtpEndZhiDanTime.MonthCalendar.DayClickAutoClosePopup = false;
			this.dtpEndZhiDanTime.MonthCalendar.DisplayMonth = new global::System.DateTime(2016, 8, 1, 0, 0, 0, 0);
			this.dtpEndZhiDanTime.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
			this.dtpEndZhiDanTime.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
			this.dtpEndZhiDanTime.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
			this.dtpEndZhiDanTime.MonthCalendar.NavigationBackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.dtpEndZhiDanTime.MonthCalendar.TodayButtonVisible = true;
			this.dtpEndZhiDanTime.Name = "dtpEndZhiDanTime";
			this.dtpEndZhiDanTime.Size = new global::System.Drawing.Size(234, 21);
			this.dtpEndZhiDanTime.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.dtpEndZhiDanTime.TabIndex = 2;
			this.dtpStartFirstTime.BackgroundStyle.Class = "DateTimeInputBackground";
			this.dtpStartFirstTime.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.dtpStartFirstTime.ButtonDropDown.Shortcut = global::DevComponents.DotNetBar.eShortcut.AltDown;
			this.dtpStartFirstTime.ButtonDropDown.Visible = true;
			this.dtpStartFirstTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
			this.dtpStartFirstTime.DateTimeSelectorVisibility = global::DevComponents.Editors.DateTimeAdv.eDateTimeSelectorVisibility.Both;
			this.dtpStartFirstTime.Format = global::DevComponents.Editors.eDateTimePickerFormat.Custom;
			this.dtpStartFirstTime.IsPopupCalendarOpen = false;
			this.dtpStartFirstTime.Location = new global::System.Drawing.Point(183, 33);
			this.dtpStartFirstTime.Margin = new global::System.Windows.Forms.Padding(0);
			this.dtpStartFirstTime.MonthCalendar.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.dtpStartFirstTime.MonthCalendar.CalendarDimensions = new global::System.Drawing.Size(1, 1);
			this.dtpStartFirstTime.MonthCalendar.ClearButtonVisible = true;
			this.dtpStartFirstTime.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = global::DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
			this.dtpStartFirstTime.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
			this.dtpStartFirstTime.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.BarBackground;
			this.dtpStartFirstTime.MonthCalendar.CommandsBackgroundStyle.BorderTop = global::DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.dtpStartFirstTime.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
			this.dtpStartFirstTime.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
			this.dtpStartFirstTime.MonthCalendar.CommandsBackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.dtpStartFirstTime.MonthCalendar.DayClickAutoClosePopup = false;
			this.dtpStartFirstTime.MonthCalendar.DisplayMonth = new global::System.DateTime(2016, 8, 1, 0, 0, 0, 0);
			this.dtpStartFirstTime.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
			this.dtpStartFirstTime.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
			this.dtpStartFirstTime.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
			this.dtpStartFirstTime.MonthCalendar.NavigationBackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.dtpStartFirstTime.MonthCalendar.TodayButtonVisible = true;
			this.dtpStartFirstTime.Name = "dtpStartFirstTime";
			this.dtpStartFirstTime.Size = new global::System.Drawing.Size(233, 21);
			this.dtpStartFirstTime.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.dtpStartFirstTime.TabIndex = 4;
			this.dtpEndFirstTime.BackgroundStyle.Class = "DateTimeInputBackground";
			this.dtpEndFirstTime.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.dtpEndFirstTime.ButtonDropDown.Shortcut = global::DevComponents.DotNetBar.eShortcut.AltDown;
			this.dtpEndFirstTime.ButtonDropDown.Visible = true;
			this.dtpEndFirstTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
			this.dtpEndFirstTime.DateTimeSelectorVisibility = global::DevComponents.Editors.DateTimeAdv.eDateTimeSelectorVisibility.Both;
			this.dtpEndFirstTime.Format = global::DevComponents.Editors.eDateTimePickerFormat.Custom;
			this.dtpEndFirstTime.IsPopupCalendarOpen = false;
			this.dtpEndFirstTime.Location = new global::System.Drawing.Point(487, 33);
			this.dtpEndFirstTime.Margin = new global::System.Windows.Forms.Padding(0);
			this.dtpEndFirstTime.MonthCalendar.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.dtpEndFirstTime.MonthCalendar.CalendarDimensions = new global::System.Drawing.Size(1, 1);
			this.dtpEndFirstTime.MonthCalendar.ClearButtonVisible = true;
			this.dtpEndFirstTime.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = global::DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
			this.dtpEndFirstTime.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
			this.dtpEndFirstTime.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.BarBackground;
			this.dtpEndFirstTime.MonthCalendar.CommandsBackgroundStyle.BorderTop = global::DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.dtpEndFirstTime.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
			this.dtpEndFirstTime.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
			this.dtpEndFirstTime.MonthCalendar.CommandsBackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.dtpEndFirstTime.MonthCalendar.DayClickAutoClosePopup = false;
			this.dtpEndFirstTime.MonthCalendar.DisplayMonth = new global::System.DateTime(2016, 8, 1, 0, 0, 0, 0);
			this.dtpEndFirstTime.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
			this.dtpEndFirstTime.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
			this.dtpEndFirstTime.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
			this.dtpEndFirstTime.MonthCalendar.NavigationBackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.dtpEndFirstTime.MonthCalendar.TodayButtonVisible = true;
			this.dtpEndFirstTime.Name = "dtpEndFirstTime";
			this.dtpEndFirstTime.Size = new global::System.Drawing.Size(234, 21);
			this.dtpEndFirstTime.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.dtpEndFirstTime.TabIndex = 5;
			this.cbxOneWeighed.AutoSize = true;
			this.cbxOneWeighed.BackColor = global::System.Drawing.Color.Transparent;
			this.cbxOneWeighed.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.cbxOneWeighed.Location = new global::System.Drawing.Point(4, 33);
			this.cbxOneWeighed.Margin = new global::System.Windows.Forms.Padding(0);
			this.cbxOneWeighed.Name = "cbxOneWeighed";
			this.cbxOneWeighed.Size = new global::System.Drawing.Size(88, 16);
			this.cbxOneWeighed.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.cbxOneWeighed.TabIndex = 3;
			this.cbxOneWeighed.Text = "OneWeighed";
			this.cbxTwoWeighed.AutoSize = true;
			this.cbxTwoWeighed.BackColor = global::System.Drawing.Color.Transparent;
			this.cbxTwoWeighed.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.cbxTwoWeighed.Location = new global::System.Drawing.Point(4, 62);
			this.cbxTwoWeighed.Margin = new global::System.Windows.Forms.Padding(0);
			this.cbxTwoWeighed.Name = "cbxTwoWeighed";
			this.cbxTwoWeighed.Size = new global::System.Drawing.Size(88, 16);
			this.cbxTwoWeighed.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.cbxTwoWeighed.TabIndex = 6;
			this.cbxTwoWeighed.Text = "TwoWeighed";
			this.dtpStartSecondTime.BackgroundStyle.Class = "DateTimeInputBackground";
			this.dtpStartSecondTime.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.dtpStartSecondTime.ButtonDropDown.Shortcut = global::DevComponents.DotNetBar.eShortcut.AltDown;
			this.dtpStartSecondTime.ButtonDropDown.Visible = true;
			this.dtpStartSecondTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
			this.dtpStartSecondTime.DateTimeSelectorVisibility = global::DevComponents.Editors.DateTimeAdv.eDateTimeSelectorVisibility.Both;
			this.dtpStartSecondTime.Format = global::DevComponents.Editors.eDateTimePickerFormat.Custom;
			this.dtpStartSecondTime.IsPopupCalendarOpen = false;
			this.dtpStartSecondTime.Location = new global::System.Drawing.Point(183, 62);
			this.dtpStartSecondTime.Margin = new global::System.Windows.Forms.Padding(0);
			this.dtpStartSecondTime.MonthCalendar.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.dtpStartSecondTime.MonthCalendar.CalendarDimensions = new global::System.Drawing.Size(1, 1);
			this.dtpStartSecondTime.MonthCalendar.ClearButtonVisible = true;
			this.dtpStartSecondTime.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = global::DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
			this.dtpStartSecondTime.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
			this.dtpStartSecondTime.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.BarBackground;
			this.dtpStartSecondTime.MonthCalendar.CommandsBackgroundStyle.BorderTop = global::DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.dtpStartSecondTime.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
			this.dtpStartSecondTime.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
			this.dtpStartSecondTime.MonthCalendar.CommandsBackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.dtpStartSecondTime.MonthCalendar.DayClickAutoClosePopup = false;
			this.dtpStartSecondTime.MonthCalendar.DisplayMonth = new global::System.DateTime(2016, 8, 1, 0, 0, 0, 0);
			this.dtpStartSecondTime.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
			this.dtpStartSecondTime.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
			this.dtpStartSecondTime.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
			this.dtpStartSecondTime.MonthCalendar.NavigationBackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.dtpStartSecondTime.MonthCalendar.TodayButtonVisible = true;
			this.dtpStartSecondTime.Name = "dtpStartSecondTime";
			this.dtpStartSecondTime.Size = new global::System.Drawing.Size(233, 21);
			this.dtpStartSecondTime.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.dtpStartSecondTime.TabIndex = 7;
			this.dtpEndSecondTime.BackgroundStyle.Class = "DateTimeInputBackground";
			this.dtpEndSecondTime.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.dtpEndSecondTime.ButtonDropDown.Shortcut = global::DevComponents.DotNetBar.eShortcut.AltDown;
			this.dtpEndSecondTime.ButtonDropDown.Visible = true;
			this.dtpEndSecondTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
			this.dtpEndSecondTime.DateTimeSelectorVisibility = global::DevComponents.Editors.DateTimeAdv.eDateTimeSelectorVisibility.Both;
			this.dtpEndSecondTime.Format = global::DevComponents.Editors.eDateTimePickerFormat.Custom;
			this.dtpEndSecondTime.IsPopupCalendarOpen = false;
			this.dtpEndSecondTime.Location = new global::System.Drawing.Point(487, 62);
			this.dtpEndSecondTime.Margin = new global::System.Windows.Forms.Padding(0);
			this.dtpEndSecondTime.MonthCalendar.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.dtpEndSecondTime.MonthCalendar.CalendarDimensions = new global::System.Drawing.Size(1, 1);
			this.dtpEndSecondTime.MonthCalendar.ClearButtonVisible = true;
			this.dtpEndSecondTime.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = global::DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
			this.dtpEndSecondTime.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
			this.dtpEndSecondTime.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.BarBackground;
			this.dtpEndSecondTime.MonthCalendar.CommandsBackgroundStyle.BorderTop = global::DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.dtpEndSecondTime.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
			this.dtpEndSecondTime.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
			this.dtpEndSecondTime.MonthCalendar.CommandsBackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.dtpEndSecondTime.MonthCalendar.DayClickAutoClosePopup = false;
			this.dtpEndSecondTime.MonthCalendar.DisplayMonth = new global::System.DateTime(2016, 8, 1, 0, 0, 0, 0);
			this.dtpEndSecondTime.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
			this.dtpEndSecondTime.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
			this.dtpEndSecondTime.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
			this.dtpEndSecondTime.MonthCalendar.NavigationBackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.dtpEndSecondTime.MonthCalendar.TodayButtonVisible = true;
			this.dtpEndSecondTime.Name = "dtpEndSecondTime";
			this.dtpEndSecondTime.Size = new global::System.Drawing.Size(234, 21);
			this.dtpEndSecondTime.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.dtpEndSecondTime.TabIndex = 8;
			this.cbxEnterTime.AutoSize = true;
			this.cbxEnterTime.BackColor = global::System.Drawing.Color.Transparent;
			this.cbxEnterTime.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.cbxEnterTime.Location = new global::System.Drawing.Point(4, 91);
			this.cbxEnterTime.Margin = new global::System.Windows.Forms.Padding(0);
			this.cbxEnterTime.Name = "cbxEnterTime";
			this.cbxEnterTime.Size = new global::System.Drawing.Size(82, 16);
			this.cbxEnterTime.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.cbxEnterTime.TabIndex = 9;
			this.cbxEnterTime.Text = "EnterTime";
			this.dtpStartEnterTime.BackgroundStyle.Class = "DateTimeInputBackground";
			this.dtpStartEnterTime.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.dtpStartEnterTime.ButtonDropDown.Shortcut = global::DevComponents.DotNetBar.eShortcut.AltDown;
			this.dtpStartEnterTime.ButtonDropDown.Visible = true;
			this.dtpStartEnterTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
			this.dtpStartEnterTime.DateTimeSelectorVisibility = global::DevComponents.Editors.DateTimeAdv.eDateTimeSelectorVisibility.Both;
			this.dtpStartEnterTime.Format = global::DevComponents.Editors.eDateTimePickerFormat.Custom;
			this.dtpStartEnterTime.IsPopupCalendarOpen = false;
			this.dtpStartEnterTime.Location = new global::System.Drawing.Point(183, 91);
			this.dtpStartEnterTime.Margin = new global::System.Windows.Forms.Padding(0);
			this.dtpStartEnterTime.MonthCalendar.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.dtpStartEnterTime.MonthCalendar.CalendarDimensions = new global::System.Drawing.Size(1, 1);
			this.dtpStartEnterTime.MonthCalendar.ClearButtonVisible = true;
			this.dtpStartEnterTime.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = global::DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
			this.dtpStartEnterTime.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
			this.dtpStartEnterTime.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.BarBackground;
			this.dtpStartEnterTime.MonthCalendar.CommandsBackgroundStyle.BorderTop = global::DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.dtpStartEnterTime.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
			this.dtpStartEnterTime.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
			this.dtpStartEnterTime.MonthCalendar.CommandsBackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.dtpStartEnterTime.MonthCalendar.DayClickAutoClosePopup = false;
			this.dtpStartEnterTime.MonthCalendar.DisplayMonth = new global::System.DateTime(2016, 8, 1, 0, 0, 0, 0);
			this.dtpStartEnterTime.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
			this.dtpStartEnterTime.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
			this.dtpStartEnterTime.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
			this.dtpStartEnterTime.MonthCalendar.NavigationBackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.dtpStartEnterTime.MonthCalendar.TodayButtonVisible = true;
			this.dtpStartEnterTime.Name = "dtpStartEnterTime";
			this.dtpStartEnterTime.Size = new global::System.Drawing.Size(233, 21);
			this.dtpStartEnterTime.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.dtpStartEnterTime.TabIndex = 10;
			this.dtpEndEnterTime.BackgroundStyle.Class = "DateTimeInputBackground";
			this.dtpEndEnterTime.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.dtpEndEnterTime.ButtonDropDown.Shortcut = global::DevComponents.DotNetBar.eShortcut.AltDown;
			this.dtpEndEnterTime.ButtonDropDown.Visible = true;
			this.dtpEndEnterTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
			this.dtpEndEnterTime.DateTimeSelectorVisibility = global::DevComponents.Editors.DateTimeAdv.eDateTimeSelectorVisibility.Both;
			this.dtpEndEnterTime.Format = global::DevComponents.Editors.eDateTimePickerFormat.Custom;
			this.dtpEndEnterTime.IsPopupCalendarOpen = false;
			this.dtpEndEnterTime.Location = new global::System.Drawing.Point(487, 91);
			this.dtpEndEnterTime.Margin = new global::System.Windows.Forms.Padding(0);
			this.dtpEndEnterTime.MonthCalendar.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.dtpEndEnterTime.MonthCalendar.CalendarDimensions = new global::System.Drawing.Size(1, 1);
			this.dtpEndEnterTime.MonthCalendar.ClearButtonVisible = true;
			this.dtpEndEnterTime.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = global::DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
			this.dtpEndEnterTime.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
			this.dtpEndEnterTime.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.BarBackground;
			this.dtpEndEnterTime.MonthCalendar.CommandsBackgroundStyle.BorderTop = global::DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.dtpEndEnterTime.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
			this.dtpEndEnterTime.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
			this.dtpEndEnterTime.MonthCalendar.CommandsBackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.dtpEndEnterTime.MonthCalendar.DayClickAutoClosePopup = false;
			this.dtpEndEnterTime.MonthCalendar.DisplayMonth = new global::System.DateTime(2016, 8, 1, 0, 0, 0, 0);
			this.dtpEndEnterTime.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
			this.dtpEndEnterTime.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
			this.dtpEndEnterTime.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
			this.dtpEndEnterTime.MonthCalendar.NavigationBackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.dtpEndEnterTime.MonthCalendar.TodayButtonVisible = true;
			this.dtpEndEnterTime.Name = "dtpEndEnterTime";
			this.dtpEndEnterTime.Size = new global::System.Drawing.Size(234, 21);
			this.dtpEndEnterTime.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.dtpEndEnterTime.TabIndex = 11;
			this.cbxLeaveTime.AutoSize = true;
			this.cbxLeaveTime.BackColor = global::System.Drawing.Color.Transparent;
			this.cbxLeaveTime.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.cbxLeaveTime.Location = new global::System.Drawing.Point(4, 120);
			this.cbxLeaveTime.Margin = new global::System.Windows.Forms.Padding(0);
			this.cbxLeaveTime.Name = "cbxLeaveTime";
			this.cbxLeaveTime.Size = new global::System.Drawing.Size(82, 16);
			this.cbxLeaveTime.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.cbxLeaveTime.TabIndex = 12;
			this.cbxLeaveTime.Text = "LeaveTime";
			this.dtpStartLeaveTime.BackgroundStyle.Class = "DateTimeInputBackground";
			this.dtpStartLeaveTime.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.dtpStartLeaveTime.ButtonDropDown.Shortcut = global::DevComponents.DotNetBar.eShortcut.AltDown;
			this.dtpStartLeaveTime.ButtonDropDown.Visible = true;
			this.dtpStartLeaveTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
			this.dtpStartLeaveTime.DateTimeSelectorVisibility = global::DevComponents.Editors.DateTimeAdv.eDateTimeSelectorVisibility.Both;
			this.dtpStartLeaveTime.Format = global::DevComponents.Editors.eDateTimePickerFormat.Custom;
			this.dtpStartLeaveTime.IsPopupCalendarOpen = false;
			this.dtpStartLeaveTime.Location = new global::System.Drawing.Point(183, 120);
			this.dtpStartLeaveTime.Margin = new global::System.Windows.Forms.Padding(0);
			this.dtpStartLeaveTime.MonthCalendar.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.dtpStartLeaveTime.MonthCalendar.CalendarDimensions = new global::System.Drawing.Size(1, 1);
			this.dtpStartLeaveTime.MonthCalendar.ClearButtonVisible = true;
			this.dtpStartLeaveTime.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = global::DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
			this.dtpStartLeaveTime.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
			this.dtpStartLeaveTime.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.BarBackground;
			this.dtpStartLeaveTime.MonthCalendar.CommandsBackgroundStyle.BorderTop = global::DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.dtpStartLeaveTime.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
			this.dtpStartLeaveTime.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
			this.dtpStartLeaveTime.MonthCalendar.CommandsBackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.dtpStartLeaveTime.MonthCalendar.DayClickAutoClosePopup = false;
			this.dtpStartLeaveTime.MonthCalendar.DisplayMonth = new global::System.DateTime(2016, 8, 1, 0, 0, 0, 0);
			this.dtpStartLeaveTime.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
			this.dtpStartLeaveTime.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
			this.dtpStartLeaveTime.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
			this.dtpStartLeaveTime.MonthCalendar.NavigationBackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.dtpStartLeaveTime.MonthCalendar.TodayButtonVisible = true;
			this.dtpStartLeaveTime.Name = "dtpStartLeaveTime";
			this.dtpStartLeaveTime.Size = new global::System.Drawing.Size(233, 21);
			this.dtpStartLeaveTime.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.dtpStartLeaveTime.TabIndex = 13;
			this.dtpEndLeaveTime.BackgroundStyle.Class = "DateTimeInputBackground";
			this.dtpEndLeaveTime.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.dtpEndLeaveTime.ButtonDropDown.Shortcut = global::DevComponents.DotNetBar.eShortcut.AltDown;
			this.dtpEndLeaveTime.ButtonDropDown.Visible = true;
			this.dtpEndLeaveTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
			this.dtpEndLeaveTime.DateTimeSelectorVisibility = global::DevComponents.Editors.DateTimeAdv.eDateTimeSelectorVisibility.Both;
			this.dtpEndLeaveTime.Format = global::DevComponents.Editors.eDateTimePickerFormat.Custom;
			this.dtpEndLeaveTime.IsPopupCalendarOpen = false;
			this.dtpEndLeaveTime.Location = new global::System.Drawing.Point(487, 120);
			this.dtpEndLeaveTime.Margin = new global::System.Windows.Forms.Padding(0);
			this.dtpEndLeaveTime.MonthCalendar.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.dtpEndLeaveTime.MonthCalendar.CalendarDimensions = new global::System.Drawing.Size(1, 1);
			this.dtpEndLeaveTime.MonthCalendar.ClearButtonVisible = true;
			this.dtpEndLeaveTime.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = global::DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
			this.dtpEndLeaveTime.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
			this.dtpEndLeaveTime.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.BarBackground;
			this.dtpEndLeaveTime.MonthCalendar.CommandsBackgroundStyle.BorderTop = global::DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.dtpEndLeaveTime.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
			this.dtpEndLeaveTime.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
			this.dtpEndLeaveTime.MonthCalendar.CommandsBackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.dtpEndLeaveTime.MonthCalendar.DayClickAutoClosePopup = false;
			this.dtpEndLeaveTime.MonthCalendar.DisplayMonth = new global::System.DateTime(2016, 8, 1, 0, 0, 0, 0);
			this.dtpEndLeaveTime.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
			this.dtpEndLeaveTime.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
			this.dtpEndLeaveTime.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
			this.dtpEndLeaveTime.MonthCalendar.NavigationBackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.dtpEndLeaveTime.MonthCalendar.TodayButtonVisible = true;
			this.dtpEndLeaveTime.Name = "dtpEndLeaveTime";
			this.dtpEndLeaveTime.Size = new global::System.Drawing.Size(234, 21);
			this.dtpEndLeaveTime.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.dtpEndLeaveTime.TabIndex = 14;
			this.cbxJieSuanTime.AutoSize = true;
			this.cbxJieSuanTime.BackColor = global::System.Drawing.Color.Transparent;
			this.cbxJieSuanTime.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.cbxJieSuanTime.Location = new global::System.Drawing.Point(4, 149);
			this.cbxJieSuanTime.Margin = new global::System.Windows.Forms.Padding(0);
			this.cbxJieSuanTime.Name = "cbxJieSuanTime";
			this.cbxJieSuanTime.Size = new global::System.Drawing.Size(95, 16);
			this.cbxJieSuanTime.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.cbxJieSuanTime.TabIndex = 15;
			this.cbxJieSuanTime.Text = "JieSuanTime";
			this.dtpStartJieSuanTime.BackgroundStyle.Class = "DateTimeInputBackground";
			this.dtpStartJieSuanTime.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.dtpStartJieSuanTime.ButtonDropDown.Shortcut = global::DevComponents.DotNetBar.eShortcut.AltDown;
			this.dtpStartJieSuanTime.ButtonDropDown.Visible = true;
			this.dtpStartJieSuanTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
			this.dtpStartJieSuanTime.DateTimeSelectorVisibility = global::DevComponents.Editors.DateTimeAdv.eDateTimeSelectorVisibility.Both;
			this.dtpStartJieSuanTime.Format = global::DevComponents.Editors.eDateTimePickerFormat.Custom;
			this.dtpStartJieSuanTime.IsPopupCalendarOpen = false;
			this.dtpStartJieSuanTime.Location = new global::System.Drawing.Point(183, 149);
			this.dtpStartJieSuanTime.Margin = new global::System.Windows.Forms.Padding(0);
			this.dtpStartJieSuanTime.MonthCalendar.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.dtpStartJieSuanTime.MonthCalendar.CalendarDimensions = new global::System.Drawing.Size(1, 1);
			this.dtpStartJieSuanTime.MonthCalendar.ClearButtonVisible = true;
			this.dtpStartJieSuanTime.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = global::DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
			this.dtpStartJieSuanTime.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
			this.dtpStartJieSuanTime.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.BarBackground;
			this.dtpStartJieSuanTime.MonthCalendar.CommandsBackgroundStyle.BorderTop = global::DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.dtpStartJieSuanTime.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
			this.dtpStartJieSuanTime.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
			this.dtpStartJieSuanTime.MonthCalendar.CommandsBackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.dtpStartJieSuanTime.MonthCalendar.DayClickAutoClosePopup = false;
			this.dtpStartJieSuanTime.MonthCalendar.DisplayMonth = new global::System.DateTime(2016, 8, 1, 0, 0, 0, 0);
			this.dtpStartJieSuanTime.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
			this.dtpStartJieSuanTime.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
			this.dtpStartJieSuanTime.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
			this.dtpStartJieSuanTime.MonthCalendar.NavigationBackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.dtpStartJieSuanTime.MonthCalendar.TodayButtonVisible = true;
			this.dtpStartJieSuanTime.Name = "dtpStartJieSuanTime";
			this.dtpStartJieSuanTime.Size = new global::System.Drawing.Size(233, 21);
			this.dtpStartJieSuanTime.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.dtpStartJieSuanTime.TabIndex = 16;
			this.dtpEndJieSuanTime.BackgroundStyle.Class = "DateTimeInputBackground";
			this.dtpEndJieSuanTime.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.dtpEndJieSuanTime.ButtonDropDown.Shortcut = global::DevComponents.DotNetBar.eShortcut.AltDown;
			this.dtpEndJieSuanTime.ButtonDropDown.Visible = true;
			this.dtpEndJieSuanTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
			this.dtpEndJieSuanTime.DateTimeSelectorVisibility = global::DevComponents.Editors.DateTimeAdv.eDateTimeSelectorVisibility.Both;
			this.dtpEndJieSuanTime.Format = global::DevComponents.Editors.eDateTimePickerFormat.Custom;
			this.dtpEndJieSuanTime.IsPopupCalendarOpen = false;
			this.dtpEndJieSuanTime.Location = new global::System.Drawing.Point(487, 149);
			this.dtpEndJieSuanTime.Margin = new global::System.Windows.Forms.Padding(0);
			this.dtpEndJieSuanTime.MonthCalendar.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.dtpEndJieSuanTime.MonthCalendar.CalendarDimensions = new global::System.Drawing.Size(1, 1);
			this.dtpEndJieSuanTime.MonthCalendar.ClearButtonVisible = true;
			this.dtpEndJieSuanTime.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = global::DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
			this.dtpEndJieSuanTime.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
			this.dtpEndJieSuanTime.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.BarBackground;
			this.dtpEndJieSuanTime.MonthCalendar.CommandsBackgroundStyle.BorderTop = global::DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.dtpEndJieSuanTime.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
			this.dtpEndJieSuanTime.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
			this.dtpEndJieSuanTime.MonthCalendar.CommandsBackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.dtpEndJieSuanTime.MonthCalendar.DayClickAutoClosePopup = false;
			this.dtpEndJieSuanTime.MonthCalendar.DisplayMonth = new global::System.DateTime(2016, 8, 1, 0, 0, 0, 0);
			this.dtpEndJieSuanTime.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
			this.dtpEndJieSuanTime.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
			this.dtpEndJieSuanTime.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
			this.dtpEndJieSuanTime.MonthCalendar.NavigationBackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.dtpEndJieSuanTime.MonthCalendar.TodayButtonVisible = true;
			this.dtpEndJieSuanTime.Name = "dtpEndJieSuanTime";
			this.dtpEndJieSuanTime.Size = new global::System.Drawing.Size(234, 21);
			this.dtpEndJieSuanTime.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.dtpEndJieSuanTime.TabIndex = 17;
			this.cbxTakeCardTime.AutoSize = true;
			this.cbxTakeCardTime.BackColor = global::System.Drawing.Color.Transparent;
			this.cbxTakeCardTime.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.cbxTakeCardTime.Location = new global::System.Drawing.Point(4, 178);
			this.cbxTakeCardTime.Margin = new global::System.Windows.Forms.Padding(0);
			this.cbxTakeCardTime.Name = "cbxTakeCardTime";
			this.cbxTakeCardTime.Size = new global::System.Drawing.Size(101, 16);
			this.cbxTakeCardTime.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.cbxTakeCardTime.TabIndex = 18;
			this.cbxTakeCardTime.Text = "TakeCardTime";
			this.dtpStartTakeCardTime.BackgroundStyle.Class = "DateTimeInputBackground";
			this.dtpStartTakeCardTime.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.dtpStartTakeCardTime.ButtonDropDown.Shortcut = global::DevComponents.DotNetBar.eShortcut.AltDown;
			this.dtpStartTakeCardTime.ButtonDropDown.Visible = true;
			this.dtpStartTakeCardTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
			this.dtpStartTakeCardTime.DateTimeSelectorVisibility = global::DevComponents.Editors.DateTimeAdv.eDateTimeSelectorVisibility.Both;
			this.dtpStartTakeCardTime.Format = global::DevComponents.Editors.eDateTimePickerFormat.Custom;
			this.dtpStartTakeCardTime.IsPopupCalendarOpen = false;
			this.dtpStartTakeCardTime.Location = new global::System.Drawing.Point(183, 178);
			this.dtpStartTakeCardTime.Margin = new global::System.Windows.Forms.Padding(0);
			this.dtpStartTakeCardTime.MonthCalendar.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.dtpStartTakeCardTime.MonthCalendar.CalendarDimensions = new global::System.Drawing.Size(1, 1);
			this.dtpStartTakeCardTime.MonthCalendar.ClearButtonVisible = true;
			this.dtpStartTakeCardTime.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = global::DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
			this.dtpStartTakeCardTime.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
			this.dtpStartTakeCardTime.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.BarBackground;
			this.dtpStartTakeCardTime.MonthCalendar.CommandsBackgroundStyle.BorderTop = global::DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.dtpStartTakeCardTime.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
			this.dtpStartTakeCardTime.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
			this.dtpStartTakeCardTime.MonthCalendar.CommandsBackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.dtpStartTakeCardTime.MonthCalendar.DayClickAutoClosePopup = false;
			this.dtpStartTakeCardTime.MonthCalendar.DisplayMonth = new global::System.DateTime(2016, 8, 1, 0, 0, 0, 0);
			this.dtpStartTakeCardTime.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
			this.dtpStartTakeCardTime.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
			this.dtpStartTakeCardTime.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
			this.dtpStartTakeCardTime.MonthCalendar.NavigationBackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.dtpStartTakeCardTime.MonthCalendar.TodayButtonVisible = true;
			this.dtpStartTakeCardTime.Name = "dtpStartTakeCardTime";
			this.dtpStartTakeCardTime.Size = new global::System.Drawing.Size(233, 21);
			this.dtpStartTakeCardTime.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.dtpStartTakeCardTime.TabIndex = 19;
			this.dtpEndTakeCardTime.BackgroundStyle.Class = "DateTimeInputBackground";
			this.dtpEndTakeCardTime.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.dtpEndTakeCardTime.ButtonDropDown.Shortcut = global::DevComponents.DotNetBar.eShortcut.AltDown;
			this.dtpEndTakeCardTime.ButtonDropDown.Visible = true;
			this.dtpEndTakeCardTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
			this.dtpEndTakeCardTime.DateTimeSelectorVisibility = global::DevComponents.Editors.DateTimeAdv.eDateTimeSelectorVisibility.Both;
			this.dtpEndTakeCardTime.Format = global::DevComponents.Editors.eDateTimePickerFormat.Custom;
			this.dtpEndTakeCardTime.IsPopupCalendarOpen = false;
			this.dtpEndTakeCardTime.Location = new global::System.Drawing.Point(487, 178);
			this.dtpEndTakeCardTime.Margin = new global::System.Windows.Forms.Padding(0);
			this.dtpEndTakeCardTime.MonthCalendar.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.dtpEndTakeCardTime.MonthCalendar.CalendarDimensions = new global::System.Drawing.Size(1, 1);
			this.dtpEndTakeCardTime.MonthCalendar.ClearButtonVisible = true;
			this.dtpEndTakeCardTime.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = global::DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
			this.dtpEndTakeCardTime.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
			this.dtpEndTakeCardTime.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.BarBackground;
			this.dtpEndTakeCardTime.MonthCalendar.CommandsBackgroundStyle.BorderTop = global::DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.dtpEndTakeCardTime.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
			this.dtpEndTakeCardTime.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
			this.dtpEndTakeCardTime.MonthCalendar.CommandsBackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.dtpEndTakeCardTime.MonthCalendar.DayClickAutoClosePopup = false;
			this.dtpEndTakeCardTime.MonthCalendar.DisplayMonth = new global::System.DateTime(2016, 8, 1, 0, 0, 0, 0);
			this.dtpEndTakeCardTime.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
			this.dtpEndTakeCardTime.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
			this.dtpEndTakeCardTime.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
			this.dtpEndTakeCardTime.MonthCalendar.NavigationBackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.dtpEndTakeCardTime.MonthCalendar.TodayButtonVisible = true;
			this.dtpEndTakeCardTime.Name = "dtpEndTakeCardTime";
			this.dtpEndTakeCardTime.Size = new global::System.Drawing.Size(234, 21);
			this.dtpEndTakeCardTime.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.dtpEndTakeCardTime.TabIndex = 20;
			this.cbxProductInfo.AutoSize = true;
			this.cbxProductInfo.BackColor = global::System.Drawing.Color.Transparent;
			this.cbxProductInfo.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.cbxProductInfo.Location = new global::System.Drawing.Point(4, 207);
			this.cbxProductInfo.Margin = new global::System.Windows.Forms.Padding(0);
			this.cbxProductInfo.Name = "cbxProductInfo";
			this.cbxProductInfo.Size = new global::System.Drawing.Size(95, 16);
			this.cbxProductInfo.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.cbxProductInfo.TabIndex = 21;
			this.cbxProductInfo.Text = "ProductInfo";
			this.tbxProductInfo.Border.Class = "TextBoxBorder";
			this.tbxProductInfo.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.tbxProductInfo.Location = new global::System.Drawing.Point(120, 207);
			this.tbxProductInfo.Margin = new global::System.Windows.Forms.Padding(0);
			this.tbxProductInfo.Name = "tbxProductInfo";
			this.tbxProductInfo.PreventEnterBeep = true;
			this.tbxProductInfo.Size = new global::System.Drawing.Size(238, 21);
			this.tbxProductInfo.TabIndex = 22;
			this.cbxIDCard.AutoSize = true;
			this.cbxIDCard.BackColor = global::System.Drawing.Color.Transparent;
			this.cbxIDCard.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.cbxIDCard.Location = new global::System.Drawing.Point(4, 236);
			this.cbxIDCard.Margin = new global::System.Windows.Forms.Padding(0);
			this.cbxIDCard.Name = "cbxIDCard";
			this.cbxIDCard.Size = new global::System.Drawing.Size(64, 16);
			this.cbxIDCard.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.cbxIDCard.TabIndex = 25;
			this.cbxIDCard.Text = "IDCard";
			this.tbxIDCard.Border.Class = "TextBoxBorder";
			this.tbxIDCard.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.tbxIDCard.Location = new global::System.Drawing.Point(120, 236);
			this.tbxIDCard.Margin = new global::System.Windows.Forms.Padding(0);
			this.tbxIDCard.Name = "tbxIDCard";
			this.tbxIDCard.PreventEnterBeep = true;
			this.tbxIDCard.Size = new global::System.Drawing.Size(238, 21);
			this.tbxIDCard.TabIndex = 26;
			this.cbxSpecsDescribe.AutoSize = true;
			this.cbxSpecsDescribe.BackColor = global::System.Drawing.Color.Transparent;
			this.cbxSpecsDescribe.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.cbxSpecsDescribe.Location = new global::System.Drawing.Point(366, 207);
			this.cbxSpecsDescribe.Margin = new global::System.Windows.Forms.Padding(0);
			this.cbxSpecsDescribe.Name = "cbxSpecsDescribe";
			this.cbxSpecsDescribe.Size = new global::System.Drawing.Size(107, 16);
			this.cbxSpecsDescribe.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.cbxSpecsDescribe.TabIndex = 23;
			this.cbxSpecsDescribe.Text = "SpecsDescribe";
			this.tbxSpecsDescribe.Border.Class = "TextBoxBorder";
			this.tbxSpecsDescribe.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.tbxSpecsDescribe.Location = new global::System.Drawing.Point(482, 207);
			this.tbxSpecsDescribe.Margin = new global::System.Windows.Forms.Padding(0);
			this.tbxSpecsDescribe.Name = "tbxSpecsDescribe";
			this.tbxSpecsDescribe.PreventEnterBeep = true;
			this.tbxSpecsDescribe.Size = new global::System.Drawing.Size(239, 21);
			this.tbxSpecsDescribe.TabIndex = 24;
			this.cbxPersonName.AutoSize = true;
			this.cbxPersonName.BackColor = global::System.Drawing.Color.Transparent;
			this.cbxPersonName.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.cbxPersonName.Location = new global::System.Drawing.Point(366, 236);
			this.cbxPersonName.Margin = new global::System.Windows.Forms.Padding(0);
			this.cbxPersonName.Name = "cbxPersonName";
			this.cbxPersonName.Size = new global::System.Drawing.Size(88, 16);
			this.cbxPersonName.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.cbxPersonName.TabIndex = 27;
			this.cbxPersonName.Text = "PersonName";
			this.tbxPersonName.Border.Class = "TextBoxBorder";
			this.tbxPersonName.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.tbxPersonName.Location = new global::System.Drawing.Point(482, 236);
			this.tbxPersonName.Margin = new global::System.Windows.Forms.Padding(0);
			this.tbxPersonName.Name = "tbxPersonName";
			this.tbxPersonName.PreventEnterBeep = true;
			this.tbxPersonName.Size = new global::System.Drawing.Size(239, 21);
			this.tbxPersonName.TabIndex = 28;
			this.cbxSettleNoReturn.AutoSize = true;
			this.cbxSettleNoReturn.BackColor = global::System.Drawing.Color.Transparent;
			this.cbxSettleNoReturn.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.cbxSettleNoReturn.Location = new global::System.Drawing.Point(584, 265);
			this.cbxSettleNoReturn.Margin = new global::System.Windows.Forms.Padding(0);
			this.cbxSettleNoReturn.Name = "cbxSettleNoReturn";
			this.cbxSettleNoReturn.Size = new global::System.Drawing.Size(113, 16);
			this.cbxSettleNoReturn.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.cbxSettleNoReturn.TabIndex = 31;
			this.cbxSettleNoReturn.Text = "SettleNoReturn";
			this.tbxClientpart.Border.Class = "TextBoxBorder";
			this.tbxClientpart.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.tbxClientpart.Location = new global::System.Drawing.Point(120, 265);
			this.tbxClientpart.Margin = new global::System.Windows.Forms.Padding(0);
			this.tbxClientpart.Name = "tbxClientpart";
			this.tbxClientpart.PreventEnterBeep = true;
			this.tbxClientpart.Size = new global::System.Drawing.Size(456, 21);
			this.tbxClientpart.TabIndex = 30;
			this.cbxClientpart.AutoSize = true;
			this.cbxClientpart.BackColor = global::System.Drawing.Color.Transparent;
			this.cbxClientpart.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.cbxClientpart.Location = new global::System.Drawing.Point(4, 265);
			this.cbxClientpart.Margin = new global::System.Windows.Forms.Padding(0);
			this.cbxClientpart.Name = "cbxClientpart";
			this.cbxClientpart.Size = new global::System.Drawing.Size(88, 16);
			this.cbxClientpart.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.cbxClientpart.TabIndex = 29;
			this.cbxClientpart.Text = "Clientpart";
			this.cbxStep.AutoSize = true;
			this.cbxStep.BackColor = global::System.Drawing.Color.Transparent;
			this.cbxStep.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.cbxStep.Location = new global::System.Drawing.Point(4, 294);
			this.cbxStep.Margin = new global::System.Windows.Forms.Padding(0);
			this.cbxStep.Name = "cbxStep";
			this.cbxStep.Size = new global::System.Drawing.Size(76, 16);
			this.cbxStep.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.cbxStep.TabIndex = 32;
			this.cbxStep.Text = "ThisStep";
			this.cbxLoader.AutoSize = true;
			this.cbxLoader.BackColor = global::System.Drawing.Color.Transparent;
			this.cbxLoader.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.cbxLoader.Location = new global::System.Drawing.Point(185, 294);
			this.cbxLoader.Margin = new global::System.Windows.Forms.Padding(0);
			this.cbxLoader.Name = "cbxLoader";
			this.cbxLoader.Size = new global::System.Drawing.Size(88, 16);
			this.cbxLoader.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.cbxLoader.TabIndex = 33;
			this.cbxLoader.Text = "ThisLoader";
			this.lbxLoader.AutoScroll = true;
			this.lbxLoader.BackgroundStyle.Class = "ListBoxAdv";
			this.lbxLoader.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.lbxLoader.CheckStateMember = null;
			this.lbxLoader.ContainerControlProcessDialogKey = true;
			this.lbxLoader.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.lbxLoader.DragDropSupport = true;
			this.lbxLoader.EnableDragDrop = true;
			this.lbxLoader.Location = new global::System.Drawing.Point(185, 318);
			this.lbxLoader.Margin = new global::System.Windows.Forms.Padding(0);
			this.lbxLoader.Name = "lbxLoader";
			this.lbxLoader.SelectionMode = global::DevComponents.DotNetBar.eSelectionMode.MultiSimple;
			this.lbxLoader.Size = new global::System.Drawing.Size(173, 200);
			this.lbxLoader.TabIndex = 37;
			this.cbxInvClass.AutoSize = true;
			this.cbxInvClass.BackColor = global::System.Drawing.Color.Transparent;
			this.cbxInvClass.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.cbxInvClass.Location = new global::System.Drawing.Point(366, 294);
			this.cbxInvClass.Margin = new global::System.Windows.Forms.Padding(0);
			this.cbxInvClass.Name = "cbxInvClass";
			this.cbxInvClass.Size = new global::System.Drawing.Size(101, 16);
			this.cbxInvClass.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.cbxInvClass.TabIndex = 34;
			this.cbxInvClass.Text = "ThisInvClass";
			this.lbxInvClass.AutoScroll = true;
			this.lbxInvClass.BackgroundStyle.Class = "ListBoxAdv";
			this.lbxInvClass.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.lbxInvClass.ContainerControlProcessDialogKey = true;
			this.lbxInvClass.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.lbxInvClass.DragDropSupport = true;
			this.lbxInvClass.EnableDragDrop = true;
			this.lbxInvClass.Location = new global::System.Drawing.Point(366, 318);
			this.lbxInvClass.Margin = new global::System.Windows.Forms.Padding(0);
			this.lbxInvClass.Name = "lbxInvClass";
			this.lbxInvClass.SelectionMode = global::DevComponents.DotNetBar.eSelectionMode.MultiSimple;
			this.lbxInvClass.Size = new global::System.Drawing.Size(173, 200);
			this.lbxInvClass.TabIndex = 38;
			this.layoutControlItem1.Control = this.cbxZhiDanTime;
			this.layoutControlItem1.Height = 24;
			this.layoutControlItem1.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Width = 16;
			this.layoutControlItem1.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem5.Control = this.dtpStartZhiDanTime;
			this.layoutControlItem5.Height = 29;
			this.layoutControlItem5.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem5.Name = "layoutControlItem5";
			this.layoutControlItem5.Text = "StartTime";
			this.layoutControlItem5.Width = 42;
			this.layoutControlItem5.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem3.Control = this.dtpEndZhiDanTime;
			this.layoutControlItem3.Height = 29;
			this.layoutControlItem3.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem3.Name = "layoutControlItem3";
			this.layoutControlItem3.Text = "EndTime";
			this.layoutControlItem3.Width = 42;
			this.layoutControlItem3.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem10.Control = this.cbxOneWeighed;
			this.layoutControlItem10.Height = 24;
			this.layoutControlItem10.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem10.Name = "layoutControlItem10";
			this.layoutControlItem10.Width = 16;
			this.layoutControlItem10.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem8.Control = this.dtpStartFirstTime;
			this.layoutControlItem8.Height = 29;
			this.layoutControlItem8.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem8.Name = "layoutControlItem8";
			this.layoutControlItem8.Text = "StartTime";
			this.layoutControlItem8.Width = 42;
			this.layoutControlItem8.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem9.Control = this.dtpEndFirstTime;
			this.layoutControlItem9.Height = 29;
			this.layoutControlItem9.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem9.Name = "layoutControlItem9";
			this.layoutControlItem9.Text = "EndTime";
			this.layoutControlItem9.Width = 42;
			this.layoutControlItem9.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem12.Control = this.cbxTwoWeighed;
			this.layoutControlItem12.Height = 24;
			this.layoutControlItem12.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem12.Name = "layoutControlItem12";
			this.layoutControlItem12.Width = 16;
			this.layoutControlItem12.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem14.Control = this.dtpStartSecondTime;
			this.layoutControlItem14.Height = 29;
			this.layoutControlItem14.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem14.Name = "layoutControlItem14";
			this.layoutControlItem14.Text = "StartTime";
			this.layoutControlItem14.Width = 42;
			this.layoutControlItem14.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem16.Control = this.dtpEndSecondTime;
			this.layoutControlItem16.Height = 29;
			this.layoutControlItem16.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem16.Name = "layoutControlItem16";
			this.layoutControlItem16.Text = "EndTime";
			this.layoutControlItem16.Width = 42;
			this.layoutControlItem16.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem17.Control = this.cbxEnterTime;
			this.layoutControlItem17.Height = 24;
			this.layoutControlItem17.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem17.Name = "layoutControlItem17";
			this.layoutControlItem17.Width = 16;
			this.layoutControlItem17.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem19.Control = this.dtpStartEnterTime;
			this.layoutControlItem19.Height = 29;
			this.layoutControlItem19.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem19.Name = "layoutControlItem19";
			this.layoutControlItem19.Text = "StartTime";
			this.layoutControlItem19.Width = 42;
			this.layoutControlItem19.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem21.Control = this.dtpEndEnterTime;
			this.layoutControlItem21.Height = 29;
			this.layoutControlItem21.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem21.Name = "layoutControlItem21";
			this.layoutControlItem21.Text = "EndTime";
			this.layoutControlItem21.Width = 42;
			this.layoutControlItem21.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem22.Control = this.cbxLeaveTime;
			this.layoutControlItem22.Height = 24;
			this.layoutControlItem22.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem22.Name = "layoutControlItem22";
			this.layoutControlItem22.Width = 16;
			this.layoutControlItem22.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem23.Control = this.dtpStartLeaveTime;
			this.layoutControlItem23.Height = 29;
			this.layoutControlItem23.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem23.Name = "layoutControlItem23";
			this.layoutControlItem23.Text = "StartTime";
			this.layoutControlItem23.Width = 42;
			this.layoutControlItem23.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem24.Control = this.dtpEndLeaveTime;
			this.layoutControlItem24.Height = 29;
			this.layoutControlItem24.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem24.Name = "layoutControlItem24";
			this.layoutControlItem24.Text = "EndTime";
			this.layoutControlItem24.Width = 42;
			this.layoutControlItem24.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem26.Control = this.cbxJieSuanTime;
			this.layoutControlItem26.Height = 24;
			this.layoutControlItem26.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem26.Name = "layoutControlItem26";
			this.layoutControlItem26.Width = 16;
			this.layoutControlItem26.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem27.Control = this.dtpStartJieSuanTime;
			this.layoutControlItem27.Height = 29;
			this.layoutControlItem27.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem27.Name = "layoutControlItem27";
			this.layoutControlItem27.Text = "StartTime";
			this.layoutControlItem27.Width = 42;
			this.layoutControlItem27.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem29.Control = this.dtpEndJieSuanTime;
			this.layoutControlItem29.Height = 29;
			this.layoutControlItem29.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem29.Name = "layoutControlItem29";
			this.layoutControlItem29.Text = "EndTime";
			this.layoutControlItem29.Width = 42;
			this.layoutControlItem29.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem30.Control = this.cbxTakeCardTime;
			this.layoutControlItem30.Height = 24;
			this.layoutControlItem30.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem30.Name = "layoutControlItem30";
			this.layoutControlItem30.Width = 16;
			this.layoutControlItem30.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem32.Control = this.dtpStartTakeCardTime;
			this.layoutControlItem32.Height = 29;
			this.layoutControlItem32.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem32.Name = "layoutControlItem32";
			this.layoutControlItem32.Text = "StartTime";
			this.layoutControlItem32.Width = 42;
			this.layoutControlItem32.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem34.Control = this.dtpEndTakeCardTime;
			this.layoutControlItem34.Height = 29;
			this.layoutControlItem34.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem34.Name = "layoutControlItem34";
			this.layoutControlItem34.Text = "EndTime";
			this.layoutControlItem34.Width = 42;
			this.layoutControlItem34.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem35.Control = this.cbxProductInfo;
			this.layoutControlItem35.Height = 24;
			this.layoutControlItem35.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem35.Name = "layoutControlItem35";
			this.layoutControlItem35.Width = 16;
			this.layoutControlItem35.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem36.Control = this.tbxProductInfo;
			this.layoutControlItem36.Height = 29;
			this.layoutControlItem36.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem36.Name = "layoutControlItem36";
			this.layoutControlItem36.Width = 34;
			this.layoutControlItem36.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem41.Control = this.cbxSpecsDescribe;
			this.layoutControlItem41.Height = 24;
			this.layoutControlItem41.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem41.Name = "layoutControlItem41";
			this.layoutControlItem41.Width = 16;
			this.layoutControlItem41.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem42.Control = this.tbxSpecsDescribe;
			this.layoutControlItem42.Height = 29;
			this.layoutControlItem42.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem42.Name = "layoutControlItem42";
			this.layoutControlItem42.Width = 34;
			this.layoutControlItem42.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem38.Control = this.cbxIDCard;
			this.layoutControlItem38.Height = 24;
			this.layoutControlItem38.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem38.Name = "layoutControlItem38";
			this.layoutControlItem38.Width = 16;
			this.layoutControlItem38.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem39.Control = this.tbxIDCard;
			this.layoutControlItem39.Height = 29;
			this.layoutControlItem39.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem39.Name = "layoutControlItem39";
			this.layoutControlItem39.Width = 34;
			this.layoutControlItem39.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem43.Control = this.cbxPersonName;
			this.layoutControlItem43.Height = 24;
			this.layoutControlItem43.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem43.Name = "layoutControlItem43";
			this.layoutControlItem43.Width = 16;
			this.layoutControlItem43.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem44.Control = this.tbxPersonName;
			this.layoutControlItem44.Height = 29;
			this.layoutControlItem44.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem44.Name = "layoutControlItem44";
			this.layoutControlItem44.Width = 34;
			this.layoutControlItem44.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem47.Control = this.cbxClientpart;
			this.layoutControlItem47.Height = 24;
			this.layoutControlItem47.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem47.Name = "layoutControlItem47";
			this.layoutControlItem47.Width = 16;
			this.layoutControlItem47.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem46.Control = this.tbxClientpart;
			this.layoutControlItem46.Height = 29;
			this.layoutControlItem46.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem46.Name = "layoutControlItem46";
			this.layoutControlItem46.Width = 64;
			this.layoutControlItem46.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem45.Control = this.cbxSettleNoReturn;
			this.layoutControlItem45.Height = 24;
			this.layoutControlItem45.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem45.Name = "layoutControlItem45";
			this.layoutControlItem45.Width = 20;
			this.layoutControlItem45.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem49.Control = this.cbxStep;
			this.layoutControlItem49.Height = 24;
			this.layoutControlItem49.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem49.Name = "layoutControlItem49";
			this.layoutControlItem49.Width = 25;
			this.layoutControlItem49.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem50.Control = this.cbxLoader;
			this.layoutControlItem50.Height = 24;
			this.layoutControlItem50.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem50.Name = "layoutControlItem50";
			this.layoutControlItem50.Width = 25;
			this.layoutControlItem50.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem52.Control = this.cbxInvClass;
			this.layoutControlItem52.Height = 24;
			this.layoutControlItem52.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem52.Name = "layoutControlItem52";
			this.layoutControlItem52.Width = 25;
			this.layoutControlItem52.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem48.Control = this.lbxMenu;
			this.layoutControlItem48.Height = 208;
			this.layoutControlItem48.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem48.Name = "layoutControlItem48";
			this.layoutControlItem48.Width = 25;
			this.layoutControlItem48.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem51.Control = this.lbxLoader;
			this.layoutControlItem51.Height = 208;
			this.layoutControlItem51.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem51.Name = "layoutControlItem51";
			this.layoutControlItem51.Width = 25;
			this.layoutControlItem51.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem53.Control = this.lbxInvClass;
			this.layoutControlItem53.Height = 208;
			this.layoutControlItem53.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem53.Name = "layoutControlItem53";
			this.layoutControlItem53.Width = 25;
			this.layoutControlItem53.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem6.Control = this.cbxZhiDanTime;
			this.layoutControlItem6.Height = 24;
			this.layoutControlItem6.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem6.Name = "layoutControlItem6";
			this.layoutControlItem6.Text = "Label:";
			this.layoutControlItem6.Width = 10;
			this.layoutControlItem6.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem2.Control = this.dtpEndZhiDanTime;
			this.layoutControlItem2.Height = 29;
			this.layoutControlItem2.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem2.Name = "layoutControlItem2";
			this.layoutControlItem2.Text = "Label:";
			this.layoutControlItem2.Width = 50;
			this.layoutControlItem2.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem4.Control = this.dtpStartFirstTime;
			this.layoutControlItem4.Height = 29;
			this.layoutControlItem4.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem4.Name = "layoutControlItem4";
			this.layoutControlItem4.Text = "Label:";
			this.layoutControlItem4.Width = 50;
			this.layoutControlItem4.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem7.Control = this.dtpEndFirstTime;
			this.layoutControlItem7.Height = 29;
			this.layoutControlItem7.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem7.Name = "layoutControlItem7";
			this.layoutControlItem7.Text = "Label:";
			this.layoutControlItem7.Width = 50;
			this.layoutControlItem7.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem11.Control = this.cbxTwoWeighed;
			this.layoutControlItem11.Height = 24;
			this.layoutControlItem11.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem11.Name = "layoutControlItem11";
			this.layoutControlItem11.Width = 16;
			this.layoutControlItem11.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem13.Control = this.dtpStartSecondTime;
			this.layoutControlItem13.Height = 29;
			this.layoutControlItem13.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem13.Name = "layoutControlItem13";
			this.layoutControlItem13.Text = "StartTime";
			this.layoutControlItem13.Width = 42;
			this.layoutControlItem13.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem15.Control = this.dtpEndSecondTime;
			this.layoutControlItem15.Height = 29;
			this.layoutControlItem15.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem15.Name = "layoutControlItem15";
			this.layoutControlItem15.Text = "EndTime";
			this.layoutControlItem15.Width = 42;
			this.layoutControlItem15.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem18.Control = this.dtpStartEnterTime;
			this.layoutControlItem18.Height = 29;
			this.layoutControlItem18.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem18.Name = "layoutControlItem18";
			this.layoutControlItem18.Text = "StartTime";
			this.layoutControlItem18.Width = 42;
			this.layoutControlItem18.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem20.Control = this.dtpEndEnterTime;
			this.layoutControlItem20.Height = 29;
			this.layoutControlItem20.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem20.Name = "layoutControlItem20";
			this.layoutControlItem20.Text = "EndTime";
			this.layoutControlItem20.Width = 42;
			this.layoutControlItem20.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem25.Control = this.cbxJieSuanTime;
			this.layoutControlItem25.Height = 24;
			this.layoutControlItem25.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem25.Name = "layoutControlItem25";
			this.layoutControlItem25.Width = 16;
			this.layoutControlItem25.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem28.Control = this.dtpEndJieSuanTime;
			this.layoutControlItem28.Height = 29;
			this.layoutControlItem28.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem28.Name = "layoutControlItem28";
			this.layoutControlItem28.Text = "EndTime";
			this.layoutControlItem28.Width = 42;
			this.layoutControlItem28.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem31.Control = this.dtpStartTakeCardTime;
			this.layoutControlItem31.Height = 29;
			this.layoutControlItem31.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem31.Name = "layoutControlItem31";
			this.layoutControlItem31.Text = "StartTime";
			this.layoutControlItem31.Width = 42;
			this.layoutControlItem31.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem33.Control = this.dtpEndTakeCardTime;
			this.layoutControlItem33.Height = 29;
			this.layoutControlItem33.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem33.Name = "layoutControlItem33";
			this.layoutControlItem33.Text = "Label:";
			this.layoutControlItem33.Width = 42;
			this.layoutControlItem33.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem37.Control = this.cbxIDCard;
			this.layoutControlItem37.Height = 24;
			this.layoutControlItem37.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem37.Name = "layoutControlItem37";
			this.layoutControlItem37.Width = 16;
			this.layoutControlItem37.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem40.Control = this.cbxSpecsDescribe;
			this.layoutControlItem40.Height = 24;
			this.layoutControlItem40.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem40.Name = "layoutControlItem40";
			this.layoutControlItem40.Width = 16;
			this.layoutControlItem40.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem54.Control = this.cbxTruckSafeName;
			this.layoutControlItem54.Height = 24;
			this.layoutControlItem54.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem54.Name = "layoutControlItem54";
			this.layoutControlItem54.Width = 26;
			this.layoutControlItem54.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.cbxTruckSafeName.AutoSize = true;
			this.cbxTruckSafeName.BackColor = global::System.Drawing.Color.Transparent;
			this.cbxTruckSafeName.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.cbxTruckSafeName.Location = new global::System.Drawing.Point(547, 294);
			this.cbxTruckSafeName.Margin = new global::System.Windows.Forms.Padding(0);
			this.cbxTruckSafeName.Name = "cbxTruckSafeName";
			this.cbxTruckSafeName.Size = new global::System.Drawing.Size(107, 16);
			this.cbxTruckSafeName.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.cbxTruckSafeName.TabIndex = 35;
			this.cbxTruckSafeName.Text = "TruckSafeName";
			this.layoutControlItem55.Control = this.cbxTruckSafeName;
			this.layoutControlItem55.Height = 24;
			this.layoutControlItem55.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem55.Name = "layoutControlItem55";
			this.layoutControlItem55.Width = 25;
			this.layoutControlItem55.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.lbxTruckSafeName.AutoScroll = true;
			this.lbxTruckSafeName.BackgroundStyle.Class = "ListBoxAdv";
			this.lbxTruckSafeName.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.lbxTruckSafeName.ContainerControlProcessDialogKey = true;
			this.lbxTruckSafeName.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.lbxTruckSafeName.DragDropSupport = true;
			this.lbxTruckSafeName.EnableDragDrop = true;
			this.lbxTruckSafeName.Location = new global::System.Drawing.Point(547, 318);
			this.lbxTruckSafeName.Margin = new global::System.Windows.Forms.Padding(0);
			this.lbxTruckSafeName.Name = "lbxTruckSafeName";
			this.lbxTruckSafeName.SelectionMode = global::DevComponents.DotNetBar.eSelectionMode.MultiSimple;
			this.lbxTruckSafeName.Size = new global::System.Drawing.Size(174, 200);
			this.lbxTruckSafeName.TabIndex = 40;
			this.layoutControlItem56.Control = this.lbxTruckSafeName;
			this.layoutControlItem56.Height = 208;
			this.layoutControlItem56.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem56.Name = "layoutControlItem56";
			this.layoutControlItem56.Width = 25;
			this.layoutControlItem56.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			base.ClientSize = new global::System.Drawing.Size(725, 553);
			base.Controls.Add(this.layoutControl1);
			base.Controls.Add(this.menuBar);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "frmAdvancedQuery";
			this.Text = "frmAdvancedQuery";
			base.Load += new global::System.EventHandler(this.frmAdvancedQuery_Load);
			((global::System.ComponentModel.ISupportInitialize)this.menuBar).EndInit();
			this.layoutControl1.ResumeLayout(false);
			this.layoutControl1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dtpStartZhiDanTime).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.dtpEndZhiDanTime).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.dtpStartFirstTime).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.dtpEndFirstTime).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.dtpStartSecondTime).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.dtpEndSecondTime).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.dtpStartEnterTime).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.dtpEndEnterTime).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.dtpStartLeaveTime).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.dtpEndLeaveTime).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.dtpStartJieSuanTime).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.dtpEndJieSuanTime).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.dtpStartTakeCardTime).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.dtpEndTakeCardTime).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000027 RID: 39
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000028 RID: 40
		private global::DevComponents.DotNetBar.Bar menuBar;

		// Token: 0x04000029 RID: 41
		private global::DevComponents.DotNetBar.ButtonItem btnQuery;

		// Token: 0x0400002A RID: 42
		private global::DevComponents.DotNetBar.Layout.LayoutControl layoutControl1;

		// Token: 0x0400002B RID: 43
		private global::DevComponents.Editors.DateTimeAdv.DateTimeInput dtpStartZhiDanTime;

		// Token: 0x0400002C RID: 44
		private global::DevComponents.DotNetBar.Controls.CheckBoxX cbxZhiDanTime;

		// Token: 0x0400002D RID: 45
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem5;

		// Token: 0x0400002E RID: 46
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem1;

		// Token: 0x0400002F RID: 47
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem6;

		// Token: 0x04000030 RID: 48
		private global::DevComponents.Editors.DateTimeAdv.DateTimeInput dtpEndZhiDanTime;

		// Token: 0x04000031 RID: 49
		private global::DevComponents.Editors.DateTimeAdv.DateTimeInput dtpStartFirstTime;

		// Token: 0x04000032 RID: 50
		private global::DevComponents.Editors.DateTimeAdv.DateTimeInput dtpEndFirstTime;

		// Token: 0x04000033 RID: 51
		private global::DevComponents.DotNetBar.Controls.CheckBoxX cbxOneWeighed;

		// Token: 0x04000034 RID: 52
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem3;

		// Token: 0x04000035 RID: 53
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem10;

		// Token: 0x04000036 RID: 54
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem8;

		// Token: 0x04000037 RID: 55
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem9;

		// Token: 0x04000038 RID: 56
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem2;

		// Token: 0x04000039 RID: 57
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem4;

		// Token: 0x0400003A RID: 58
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem7;

		// Token: 0x0400003B RID: 59
		private global::DevComponents.DotNetBar.Controls.CheckBoxX cbxTwoWeighed;

		// Token: 0x0400003C RID: 60
		private global::DevComponents.Editors.DateTimeAdv.DateTimeInput dtpStartSecondTime;

		// Token: 0x0400003D RID: 61
		private global::DevComponents.Editors.DateTimeAdv.DateTimeInput dtpEndSecondTime;

		// Token: 0x0400003E RID: 62
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem12;

		// Token: 0x0400003F RID: 63
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem14;

		// Token: 0x04000040 RID: 64
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem16;

		// Token: 0x04000041 RID: 65
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem11;

		// Token: 0x04000042 RID: 66
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem13;

		// Token: 0x04000043 RID: 67
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem15;

		// Token: 0x04000044 RID: 68
		private global::DevComponents.DotNetBar.Controls.CheckBoxX cbxEnterTime;

		// Token: 0x04000045 RID: 69
		private global::DevComponents.Editors.DateTimeAdv.DateTimeInput dtpStartEnterTime;

		// Token: 0x04000046 RID: 70
		private global::DevComponents.Editors.DateTimeAdv.DateTimeInput dtpEndEnterTime;

		// Token: 0x04000047 RID: 71
		private global::DevComponents.DotNetBar.Controls.CheckBoxX cbxLeaveTime;

		// Token: 0x04000048 RID: 72
		private global::DevComponents.Editors.DateTimeAdv.DateTimeInput dtpStartLeaveTime;

		// Token: 0x04000049 RID: 73
		private global::DevComponents.Editors.DateTimeAdv.DateTimeInput dtpEndLeaveTime;

		// Token: 0x0400004A RID: 74
		private global::DevComponents.DotNetBar.Controls.CheckBoxX cbxJieSuanTime;

		// Token: 0x0400004B RID: 75
		private global::DevComponents.Editors.DateTimeAdv.DateTimeInput dtpStartJieSuanTime;

		// Token: 0x0400004C RID: 76
		private global::DevComponents.Editors.DateTimeAdv.DateTimeInput dtpEndJieSuanTime;

		// Token: 0x0400004D RID: 77
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem17;

		// Token: 0x0400004E RID: 78
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem19;

		// Token: 0x0400004F RID: 79
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem21;

		// Token: 0x04000050 RID: 80
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem22;

		// Token: 0x04000051 RID: 81
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem23;

		// Token: 0x04000052 RID: 82
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem24;

		// Token: 0x04000053 RID: 83
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem26;

		// Token: 0x04000054 RID: 84
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem27;

		// Token: 0x04000055 RID: 85
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem29;

		// Token: 0x04000056 RID: 86
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem18;

		// Token: 0x04000057 RID: 87
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem20;

		// Token: 0x04000058 RID: 88
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem25;

		// Token: 0x04000059 RID: 89
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem28;

		// Token: 0x0400005A RID: 90
		private global::DevComponents.DotNetBar.Controls.CheckBoxX cbxTakeCardTime;

		// Token: 0x0400005B RID: 91
		private global::DevComponents.Editors.DateTimeAdv.DateTimeInput dtpStartTakeCardTime;

		// Token: 0x0400005C RID: 92
		private global::DevComponents.Editors.DateTimeAdv.DateTimeInput dtpEndTakeCardTime;

		// Token: 0x0400005D RID: 93
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem30;

		// Token: 0x0400005E RID: 94
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem32;

		// Token: 0x0400005F RID: 95
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem34;

		// Token: 0x04000060 RID: 96
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem31;

		// Token: 0x04000061 RID: 97
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem33;

		// Token: 0x04000062 RID: 98
		private global::DevComponents.DotNetBar.Controls.CheckBoxX cbxProductInfo;

		// Token: 0x04000063 RID: 99
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem35;

		// Token: 0x04000064 RID: 100
		private global::DevComponents.DotNetBar.Controls.TextBoxX tbxProductInfo;

		// Token: 0x04000065 RID: 101
		private global::DevComponents.DotNetBar.Controls.CheckBoxX cbxIDCard;

		// Token: 0x04000066 RID: 102
		private global::DevComponents.DotNetBar.Controls.TextBoxX tbxIDCard;

		// Token: 0x04000067 RID: 103
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem36;

		// Token: 0x04000068 RID: 104
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem38;

		// Token: 0x04000069 RID: 105
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem39;

		// Token: 0x0400006A RID: 106
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem37;

		// Token: 0x0400006B RID: 107
		private global::DevComponents.DotNetBar.Controls.CheckBoxX cbxSpecsDescribe;

		// Token: 0x0400006C RID: 108
		private global::DevComponents.DotNetBar.Controls.TextBoxX tbxSpecsDescribe;

		// Token: 0x0400006D RID: 109
		private global::DevComponents.DotNetBar.Controls.CheckBoxX cbxPersonName;

		// Token: 0x0400006E RID: 110
		private global::DevComponents.DotNetBar.Controls.TextBoxX tbxPersonName;

		// Token: 0x0400006F RID: 111
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem41;

		// Token: 0x04000070 RID: 112
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem42;

		// Token: 0x04000071 RID: 113
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem43;

		// Token: 0x04000072 RID: 114
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem44;

		// Token: 0x04000073 RID: 115
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem40;

		// Token: 0x04000074 RID: 116
		private global::DevComponents.DotNetBar.Controls.CheckBoxX cbxSettleNoReturn;

		// Token: 0x04000075 RID: 117
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem45;

		// Token: 0x04000076 RID: 118
		private global::DevComponents.DotNetBar.Controls.TextBoxX tbxClientpart;

		// Token: 0x04000077 RID: 119
		private global::DevComponents.DotNetBar.Controls.CheckBoxX cbxClientpart;

		// Token: 0x04000078 RID: 120
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem47;

		// Token: 0x04000079 RID: 121
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem46;

		// Token: 0x0400007A RID: 122
		private global::DevComponents.DotNetBar.ListBoxAdv lbxMenu;

		// Token: 0x0400007B RID: 123
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem48;

		// Token: 0x0400007C RID: 124
		private global::DevComponents.DotNetBar.Controls.CheckBoxX cbxStep;

		// Token: 0x0400007D RID: 125
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem49;

		// Token: 0x0400007E RID: 126
		private global::DevComponents.DotNetBar.Controls.CheckBoxX cbxLoader;

		// Token: 0x0400007F RID: 127
		private global::DevComponents.DotNetBar.ListBoxAdv lbxLoader;

		// Token: 0x04000080 RID: 128
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem50;

		// Token: 0x04000081 RID: 129
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem51;

		// Token: 0x04000082 RID: 130
		private global::DevComponents.DotNetBar.Controls.CheckBoxX cbxInvClass;

		// Token: 0x04000083 RID: 131
		private global::DevComponents.DotNetBar.ListBoxAdv lbxInvClass;

		// Token: 0x04000084 RID: 132
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem52;

		// Token: 0x04000085 RID: 133
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem53;

		// Token: 0x04000086 RID: 134
		private global::DevComponents.DotNetBar.Controls.CheckBoxX cbxTruckSafeName;

		// Token: 0x04000087 RID: 135
		private global::DevComponents.DotNetBar.ListBoxAdv lbxTruckSafeName;

		// Token: 0x04000088 RID: 136
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem55;

		// Token: 0x04000089 RID: 137
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem56;

		// Token: 0x0400008A RID: 138
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem54;
	}
}
