namespace SQSClient
{
	// Token: 0x02000099 RID: 153
	public partial class frmUnionlabEdit : global::SQSClient.BaseDialogForm
	{
		// Token: 0x06000884 RID: 2180 RVA: 0x000D1588 File Offset: 0x000CF788
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000885 RID: 2181 RVA: 0x000D15C0 File Offset: 0x000CF7C0
		private void InitializeComponent()
		{
			this.menuBar = new global::DevComponents.DotNetBar.Bar();
			this.btnSave = new global::DevComponents.DotNetBar.ButtonItem();
			this.layoutControl1 = new global::DevComponents.DotNetBar.Layout.LayoutControl();
			this.txtUnionChemist1 = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.txtUnionLabName = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.rtbMemo = new global::DevComponents.DotNetBar.Controls.RichTextBoxEx();
			this.txtDeductInfo = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.cmbLabStatus = new global::DevComponents.DotNetBar.Controls.ComboBoxEx();
			this.cmbUnionStatus = new global::DevComponents.DotNetBar.Controls.ComboBoxEx();
			this.cmbBusinessType = new global::DevComponents.DotNetBar.Controls.ComboBoxEx();
			this.iInputUnionLabIndex = new global::DevComponents.Editors.IntegerInput();
			this.txtLabMan = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.iInputLabCount = new global::DevComponents.Editors.IntegerInput();
			this.cmbLabResult = new global::DevComponents.DotNetBar.Controls.ComboBoxEx();
			this.txtUnionChemist2 = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.txtReviewer = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.txtSampler = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.tInputUnionLabTime = new global::DevComponents.Editors.DateTimeAdv.DateTimeInput();
			this.tInputEffectiveTime = new global::DevComponents.Editors.DateTimeAdv.DateTimeInput();
			this.layoutControlItem1 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem9 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem3 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem12 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem20 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem30 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem22 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem15 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem8 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem10 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem19 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem4 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem29 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem35 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem33 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
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
			this.layoutControlItem13 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem17 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem34 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem11 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.nudWaterDeduct = new global::DevComponents.Editors.DoubleInput();
			this.layoutControlItem25 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem27 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.nudImpurityDeduct = new global::DevComponents.Editors.DoubleInput();
			this.layoutControlItem31 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem32 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.nudOtherDeduct = new global::DevComponents.Editors.DoubleInput();
			this.layoutControlItem36 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.txtUnionLabCode = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.layoutControlItem23 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			((global::System.ComponentModel.ISupportInitialize)this.menuBar).BeginInit();
			this.layoutControl1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.iInputUnionLabIndex).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.iInputLabCount).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.tInputUnionLabTime).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.tInputEffectiveTime).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudWaterDeduct).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudImpurityDeduct).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudOtherDeduct).BeginInit();
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
			this.layoutControl1.Controls.Add(this.txtUnionChemist1);
			this.layoutControl1.Controls.Add(this.txtUnionLabName);
			this.layoutControl1.Controls.Add(this.rtbMemo);
			this.layoutControl1.Controls.Add(this.txtDeductInfo);
			this.layoutControl1.Controls.Add(this.cmbLabStatus);
			this.layoutControl1.Controls.Add(this.cmbUnionStatus);
			this.layoutControl1.Controls.Add(this.cmbBusinessType);
			this.layoutControl1.Controls.Add(this.iInputUnionLabIndex);
			this.layoutControl1.Controls.Add(this.txtLabMan);
			this.layoutControl1.Controls.Add(this.iInputLabCount);
			this.layoutControl1.Controls.Add(this.cmbLabResult);
			this.layoutControl1.Controls.Add(this.txtUnionChemist2);
			this.layoutControl1.Controls.Add(this.txtReviewer);
			this.layoutControl1.Controls.Add(this.txtSampler);
			this.layoutControl1.Controls.Add(this.tInputUnionLabTime);
			this.layoutControl1.Controls.Add(this.tInputEffectiveTime);
			this.layoutControl1.Controls.Add(this.nudWaterDeduct);
			this.layoutControl1.Controls.Add(this.nudImpurityDeduct);
			this.layoutControl1.Controls.Add(this.nudOtherDeduct);
			this.layoutControl1.Controls.Add(this.txtUnionLabCode);
			this.layoutControl1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.layoutControl1.Location = new global::System.Drawing.Point(0, 26);
			this.layoutControl1.Name = "layoutControl1";
			this.layoutControl1.RootGroup.Items.AddRange(new global::DevComponents.DotNetBar.Layout.LayoutItemBase[]
			{
				this.layoutControlItem23,
				this.layoutControlItem9,
				this.layoutControlItem1,
				this.layoutControlItem3,
				this.layoutControlItem12,
				this.layoutControlItem20,
				this.layoutControlItem30,
				this.layoutControlItem22,
				this.layoutControlItem15,
				this.layoutControlItem8,
				this.layoutControlItem10,
				this.layoutControlItem25,
				this.layoutControlItem31,
				this.layoutControlItem36,
				this.layoutControlItem19,
				this.layoutControlItem4,
				this.layoutControlItem29,
				this.layoutControlItem35,
				this.layoutControlItem33,
				this.layoutControlItem6
			});
			this.layoutControl1.Size = new global::System.Drawing.Size(513, 375);
			this.layoutControl1.TabIndex = 22;
			this.txtUnionChemist1.Border.Class = "TextBoxBorder";
			this.txtUnionChemist1.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtUnionChemist1.Location = new global::System.Drawing.Point(98, 236);
			this.txtUnionChemist1.Margin = new global::System.Windows.Forms.Padding(0);
			this.txtUnionChemist1.Name = "txtUnionChemist1";
			this.txtUnionChemist1.PreventEnterBeep = true;
			this.txtUnionChemist1.Size = new global::System.Drawing.Size(154, 21);
			this.txtUnionChemist1.TabIndex = 15;
			this.txtUnionLabName.Border.Class = "TextBoxBorder";
			this.txtUnionLabName.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtUnionLabName.Location = new global::System.Drawing.Point(98, 33);
			this.txtUnionLabName.Margin = new global::System.Windows.Forms.Padding(0);
			this.txtUnionLabName.Name = "txtUnionLabName";
			this.txtUnionLabName.PreventEnterBeep = true;
			this.txtUnionLabName.Size = new global::System.Drawing.Size(411, 21);
			this.txtUnionLabName.TabIndex = 2;
			this.rtbMemo.BackgroundStyle.Class = "RichTextBoxBorder";
			this.rtbMemo.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.rtbMemo.Location = new global::System.Drawing.Point(98, 294);
			this.rtbMemo.Margin = new global::System.Windows.Forms.Padding(0);
			this.rtbMemo.MaxLength = 200;
			this.rtbMemo.Name = "rtbMemo";
			this.rtbMemo.Rtf = "{\\rtf1\\ansi\\ansicpg936\\deff0\\nouicompat\\deflang1033\\deflangfe2052{\\fonttbl{\\f0\\fnil\\fcharset134 \\'cb\\'ce\\'cc\\'e5;}}\r\n{\\*\\generator Riched20 10.0.18362}\\viewkind4\\uc1 \r\n\\pard\\f0\\fs18\\lang2052\\par\r\n}\r\n";
			this.rtbMemo.Size = new global::System.Drawing.Size(411, 52);
			this.rtbMemo.TabIndex = 19;
			this.txtDeductInfo.Border.Class = "TextBoxBorder";
			this.txtDeductInfo.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtDeductInfo.Location = new global::System.Drawing.Point(354, 207);
			this.txtDeductInfo.Margin = new global::System.Windows.Forms.Padding(0);
			this.txtDeductInfo.Name = "txtDeductInfo";
			this.txtDeductInfo.PreventEnterBeep = true;
			this.txtDeductInfo.Size = new global::System.Drawing.Size(155, 21);
			this.txtDeductInfo.TabIndex = 14;
			this.cmbLabStatus.DisplayMember = "Text";
			this.cmbLabStatus.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cmbLabStatus.FormattingEnabled = true;
			this.cmbLabStatus.ItemHeight = 15;
			this.cmbLabStatus.Location = new global::System.Drawing.Point(98, 91);
			this.cmbLabStatus.Margin = new global::System.Windows.Forms.Padding(0);
			this.cmbLabStatus.Name = "cmbLabStatus";
			this.cmbLabStatus.Size = new global::System.Drawing.Size(154, 21);
			this.cmbLabStatus.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.cmbLabStatus.TabIndex = 5;
			this.cmbUnionStatus.DisplayMember = "Text";
			this.cmbUnionStatus.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cmbUnionStatus.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbUnionStatus.FormattingEnabled = true;
			this.cmbUnionStatus.ItemHeight = 15;
			this.cmbUnionStatus.Location = new global::System.Drawing.Point(98, 120);
			this.cmbUnionStatus.Margin = new global::System.Windows.Forms.Padding(0);
			this.cmbUnionStatus.Name = "cmbUnionStatus";
			this.cmbUnionStatus.Size = new global::System.Drawing.Size(154, 21);
			this.cmbUnionStatus.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.cmbUnionStatus.TabIndex = 7;
			this.cmbBusinessType.DisplayMember = "Text";
			this.cmbBusinessType.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cmbBusinessType.FormattingEnabled = true;
			this.cmbBusinessType.ItemHeight = 15;
			this.cmbBusinessType.Location = new global::System.Drawing.Point(98, 62);
			this.cmbBusinessType.Margin = new global::System.Windows.Forms.Padding(0);
			this.cmbBusinessType.Name = "cmbBusinessType";
			this.cmbBusinessType.Size = new global::System.Drawing.Size(154, 21);
			this.cmbBusinessType.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.cmbBusinessType.TabIndex = 3;
			this.iInputUnionLabIndex.BackgroundStyle.Class = "DateTimeInputBackground";
			this.iInputUnionLabIndex.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.iInputUnionLabIndex.ButtonFreeText.Shortcut = global::DevComponents.DotNetBar.eShortcut.F2;
			this.iInputUnionLabIndex.InputHorizontalAlignment = global::DevComponents.Editors.eHorizontalAlignment.Left;
			this.iInputUnionLabIndex.Location = new global::System.Drawing.Point(354, 4);
			this.iInputUnionLabIndex.Margin = new global::System.Windows.Forms.Padding(0);
			this.iInputUnionLabIndex.Name = "iInputUnionLabIndex";
			this.iInputUnionLabIndex.ShowUpDown = true;
			this.iInputUnionLabIndex.Size = new global::System.Drawing.Size(155, 21);
			this.iInputUnionLabIndex.TabIndex = 1;
			this.iInputUnionLabIndex.Value = 1;
			this.txtLabMan.Border.Class = "TextBoxBorder";
			this.txtLabMan.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtLabMan.Location = new global::System.Drawing.Point(354, 62);
			this.txtLabMan.Margin = new global::System.Windows.Forms.Padding(0);
			this.txtLabMan.Name = "txtLabMan";
			this.txtLabMan.PreventEnterBeep = true;
			this.txtLabMan.Size = new global::System.Drawing.Size(155, 21);
			this.txtLabMan.TabIndex = 4;
			this.iInputLabCount.BackgroundStyle.Class = "DateTimeInputBackground";
			this.iInputLabCount.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.iInputLabCount.ButtonFreeText.Shortcut = global::DevComponents.DotNetBar.eShortcut.F2;
			this.iInputLabCount.InputHorizontalAlignment = global::DevComponents.Editors.eHorizontalAlignment.Left;
			this.iInputLabCount.Location = new global::System.Drawing.Point(354, 120);
			this.iInputLabCount.Margin = new global::System.Windows.Forms.Padding(0);
			this.iInputLabCount.Name = "iInputLabCount";
			this.iInputLabCount.ShowUpDown = true;
			this.iInputLabCount.Size = new global::System.Drawing.Size(155, 21);
			this.iInputLabCount.TabIndex = 8;
			this.iInputLabCount.Value = 1;
			this.cmbLabResult.DisplayMember = "Text";
			this.cmbLabResult.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cmbLabResult.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbLabResult.FormattingEnabled = true;
			this.cmbLabResult.ItemHeight = 15;
			this.cmbLabResult.Location = new global::System.Drawing.Point(354, 91);
			this.cmbLabResult.Margin = new global::System.Windows.Forms.Padding(0);
			this.cmbLabResult.Name = "cmbLabResult";
			this.cmbLabResult.Size = new global::System.Drawing.Size(155, 21);
			this.cmbLabResult.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.cmbLabResult.TabIndex = 6;
			this.txtUnionChemist2.Border.Class = "TextBoxBorder";
			this.txtUnionChemist2.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtUnionChemist2.Location = new global::System.Drawing.Point(354, 236);
			this.txtUnionChemist2.Margin = new global::System.Windows.Forms.Padding(0);
			this.txtUnionChemist2.Name = "txtUnionChemist2";
			this.txtUnionChemist2.PreventEnterBeep = true;
			this.txtUnionChemist2.Size = new global::System.Drawing.Size(155, 21);
			this.txtUnionChemist2.TabIndex = 16;
			this.txtReviewer.Border.Class = "TextBoxBorder";
			this.txtReviewer.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtReviewer.Location = new global::System.Drawing.Point(354, 265);
			this.txtReviewer.Margin = new global::System.Windows.Forms.Padding(0);
			this.txtReviewer.Name = "txtReviewer";
			this.txtReviewer.PreventEnterBeep = true;
			this.txtReviewer.Size = new global::System.Drawing.Size(155, 21);
			this.txtReviewer.TabIndex = 18;
			this.txtSampler.Border.Class = "TextBoxBorder";
			this.txtSampler.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtSampler.Location = new global::System.Drawing.Point(98, 265);
			this.txtSampler.Margin = new global::System.Windows.Forms.Padding(0);
			this.txtSampler.Name = "txtSampler";
			this.txtSampler.PreventEnterBeep = true;
			this.txtSampler.Size = new global::System.Drawing.Size(154, 21);
			this.txtSampler.TabIndex = 17;
			this.tInputUnionLabTime.BackgroundStyle.Class = "DateTimeInputBackground";
			this.tInputUnionLabTime.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.tInputUnionLabTime.ButtonDropDown.Shortcut = global::DevComponents.DotNetBar.eShortcut.AltDown;
			this.tInputUnionLabTime.ButtonDropDown.Visible = true;
			this.tInputUnionLabTime.IsPopupCalendarOpen = false;
			this.tInputUnionLabTime.Location = new global::System.Drawing.Point(98, 149);
			this.tInputUnionLabTime.Margin = new global::System.Windows.Forms.Padding(0);
			this.tInputUnionLabTime.MonthCalendar.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.tInputUnionLabTime.MonthCalendar.CalendarDimensions = new global::System.Drawing.Size(1, 1);
			this.tInputUnionLabTime.MonthCalendar.ClearButtonVisible = true;
			this.tInputUnionLabTime.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = global::DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
			this.tInputUnionLabTime.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
			this.tInputUnionLabTime.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.BarBackground;
			this.tInputUnionLabTime.MonthCalendar.CommandsBackgroundStyle.BorderTop = global::DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.tInputUnionLabTime.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
			this.tInputUnionLabTime.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
			this.tInputUnionLabTime.MonthCalendar.CommandsBackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.tInputUnionLabTime.MonthCalendar.DisplayMonth = new global::System.DateTime(2018, 12, 1, 0, 0, 0, 0);
			this.tInputUnionLabTime.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
			this.tInputUnionLabTime.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
			this.tInputUnionLabTime.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
			this.tInputUnionLabTime.MonthCalendar.NavigationBackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.tInputUnionLabTime.MonthCalendar.TodayButtonVisible = true;
			this.tInputUnionLabTime.Name = "tInputUnionLabTime";
			this.tInputUnionLabTime.Size = new global::System.Drawing.Size(154, 21);
			this.tInputUnionLabTime.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.tInputUnionLabTime.TabIndex = 9;
			this.tInputEffectiveTime.BackgroundStyle.Class = "DateTimeInputBackground";
			this.tInputEffectiveTime.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.tInputEffectiveTime.ButtonDropDown.Shortcut = global::DevComponents.DotNetBar.eShortcut.AltDown;
			this.tInputEffectiveTime.ButtonDropDown.Visible = true;
			this.tInputEffectiveTime.IsPopupCalendarOpen = false;
			this.tInputEffectiveTime.Location = new global::System.Drawing.Point(354, 149);
			this.tInputEffectiveTime.Margin = new global::System.Windows.Forms.Padding(0);
			this.tInputEffectiveTime.MonthCalendar.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.tInputEffectiveTime.MonthCalendar.CalendarDimensions = new global::System.Drawing.Size(1, 1);
			this.tInputEffectiveTime.MonthCalendar.ClearButtonVisible = true;
			this.tInputEffectiveTime.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = global::DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
			this.tInputEffectiveTime.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
			this.tInputEffectiveTime.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.BarBackground;
			this.tInputEffectiveTime.MonthCalendar.CommandsBackgroundStyle.BorderTop = global::DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.tInputEffectiveTime.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
			this.tInputEffectiveTime.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
			this.tInputEffectiveTime.MonthCalendar.CommandsBackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.tInputEffectiveTime.MonthCalendar.DisplayMonth = new global::System.DateTime(2018, 12, 1, 0, 0, 0, 0);
			this.tInputEffectiveTime.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
			this.tInputEffectiveTime.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
			this.tInputEffectiveTime.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
			this.tInputEffectiveTime.MonthCalendar.NavigationBackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.tInputEffectiveTime.MonthCalendar.TodayButtonVisible = true;
			this.tInputEffectiveTime.Name = "tInputEffectiveTime";
			this.tInputEffectiveTime.Size = new global::System.Drawing.Size(155, 21);
			this.tInputEffectiveTime.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.tInputEffectiveTime.TabIndex = 10;
			this.layoutControlItem1.Control = this.txtUnionLabName;
			this.layoutControlItem1.Height = 29;
			this.layoutControlItem1.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Text = "UnionLab";
			this.layoutControlItem1.Width = 100;
			this.layoutControlItem1.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem9.Control = this.iInputUnionLabIndex;
			this.layoutControlItem9.Height = 29;
			this.layoutControlItem9.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem9.Name = "layoutControlItem9";
			this.layoutControlItem9.Text = "LabIndex";
			this.layoutControlItem9.Width = 50;
			this.layoutControlItem9.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem3.Control = this.cmbBusinessType;
			this.layoutControlItem3.Height = 29;
			this.layoutControlItem3.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem3.Name = "layoutControlItem3";
			this.layoutControlItem3.Text = "BusType";
			this.layoutControlItem3.Width = 50;
			this.layoutControlItem3.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem12.Control = this.txtLabMan;
			this.layoutControlItem12.Height = 29;
			this.layoutControlItem12.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem12.Name = "layoutControlItem12";
			this.layoutControlItem12.Text = "LabMan";
			this.layoutControlItem12.Width = 50;
			this.layoutControlItem12.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem20.Control = this.cmbLabStatus;
			this.layoutControlItem20.Height = 29;
			this.layoutControlItem20.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem20.Name = "layoutControlItem20";
			this.layoutControlItem20.Text = "LabStatus";
			this.layoutControlItem20.Width = 50;
			this.layoutControlItem20.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem30.Control = this.cmbLabResult;
			this.layoutControlItem30.Height = 29;
			this.layoutControlItem30.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem30.Name = "layoutControlItem30";
			this.layoutControlItem30.Text = "LabResult";
			this.layoutControlItem30.Width = 50;
			this.layoutControlItem30.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem22.Control = this.cmbUnionStatus;
			this.layoutControlItem22.Height = 29;
			this.layoutControlItem22.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem22.Name = "layoutControlItem22";
			this.layoutControlItem22.Text = "UnionStatus";
			this.layoutControlItem22.Width = 50;
			this.layoutControlItem22.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem15.Control = this.iInputLabCount;
			this.layoutControlItem15.Height = 29;
			this.layoutControlItem15.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem15.Name = "layoutControlItem15";
			this.layoutControlItem15.Text = "LabCount";
			this.layoutControlItem15.Width = 50;
			this.layoutControlItem15.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem8.Control = this.tInputUnionLabTime;
			this.layoutControlItem8.Height = 29;
			this.layoutControlItem8.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem8.Name = "layoutControlItem8";
			this.layoutControlItem8.Text = "UnionLabTime";
			this.layoutControlItem8.Width = 50;
			this.layoutControlItem8.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem10.Control = this.tInputEffectiveTime;
			this.layoutControlItem10.Height = 29;
			this.layoutControlItem10.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem10.Name = "layoutControlItem10";
			this.layoutControlItem10.Text = "EffectiveTime";
			this.layoutControlItem10.Width = 50;
			this.layoutControlItem10.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem19.Control = this.txtDeductInfo;
			this.layoutControlItem19.Height = 29;
			this.layoutControlItem19.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem19.Name = "layoutControlItem19";
			this.layoutControlItem19.Text = "DeductInfo";
			this.layoutControlItem19.Width = 50;
			this.layoutControlItem19.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem4.Control = this.txtUnionChemist1;
			this.layoutControlItem4.Height = 29;
			this.layoutControlItem4.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem4.Name = "layoutControlItem4";
			this.layoutControlItem4.Text = "UnionChemist1";
			this.layoutControlItem4.Width = 50;
			this.layoutControlItem4.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem29.Control = this.txtUnionChemist2;
			this.layoutControlItem29.Height = 29;
			this.layoutControlItem29.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem29.Name = "layoutControlItem29";
			this.layoutControlItem29.Text = "UnionChemist2";
			this.layoutControlItem29.Width = 50;
			this.layoutControlItem29.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem35.Control = this.txtSampler;
			this.layoutControlItem35.Height = 29;
			this.layoutControlItem35.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem35.Name = "layoutControlItem35";
			this.layoutControlItem35.Text = "Sampler";
			this.layoutControlItem35.Width = 50;
			this.layoutControlItem35.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem33.Control = this.txtReviewer;
			this.layoutControlItem33.Height = 29;
			this.layoutControlItem33.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem33.Name = "layoutControlItem33";
			this.layoutControlItem33.Text = "Reviewer";
			this.layoutControlItem33.Width = 50;
			this.layoutControlItem33.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem6.Control = this.rtbMemo;
			this.layoutControlItem6.Height = 60;
			this.layoutControlItem6.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem6.Name = "layoutControlItem6";
			this.layoutControlItem6.Text = "Memo";
			this.layoutControlItem6.Width = 100;
			this.layoutControlItem6.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem14.Height = 29;
			this.layoutControlItem14.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem14.Name = "layoutControlItem14";
			this.layoutControlItem14.Text = "Signer";
			this.layoutControlItem14.Width = 100;
			this.layoutControlItem14.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem16.Height = 29;
			this.layoutControlItem16.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem16.Name = "layoutControlItem16";
			this.layoutControlItem16.Text = "VouchType";
			this.layoutControlItem16.Width = 50;
			this.layoutControlItem16.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem18.Control = this.txtDeductInfo;
			this.layoutControlItem18.Height = 29;
			this.layoutControlItem18.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem18.Name = "layoutControlItem18";
			this.layoutControlItem18.Text = "Signer";
			this.layoutControlItem18.Width = 100;
			this.layoutControlItem18.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem5.Control = this.cmbLabStatus;
			this.layoutControlItem5.Height = 29;
			this.layoutControlItem5.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem5.Name = "layoutControlItem5";
			this.layoutControlItem5.Text = "RdFlag";
			this.layoutControlItem5.Width = 20;
			this.layoutControlItem5.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem21.Control = this.cmbUnionStatus;
			this.layoutControlItem21.Height = 29;
			this.layoutControlItem21.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem21.Name = "layoutControlItem21";
			this.layoutControlItem21.Text = "RdStatus";
			this.layoutControlItem21.Width = 20;
			this.layoutControlItem21.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem2.Height = 29;
			this.layoutControlItem2.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem2.Name = "layoutControlItem2";
			this.layoutControlItem2.Text = "*CreateDate";
			this.layoutControlItem2.Width = 100;
			this.layoutControlItem2.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem7.Height = 29;
			this.layoutControlItem7.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem7.Name = "layoutControlItem7";
			this.layoutControlItem7.Text = "DepName";
			this.layoutControlItem7.Width = 100;
			this.layoutControlItem7.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem24.Height = 29;
			this.layoutControlItem24.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem24.Name = "layoutControlItem24";
			this.layoutControlItem24.Text = "RdPerson";
			this.layoutControlItem24.Width = 50;
			this.layoutControlItem24.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem26.Height = 29;
			this.layoutControlItem26.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem26.Name = "layoutControlItem26";
			this.layoutControlItem26.Text = "RdPerson";
			this.layoutControlItem26.Width = 50;
			this.layoutControlItem26.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem28.Height = 29;
			this.layoutControlItem28.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem28.Name = "layoutControlItem28";
			this.layoutControlItem28.Text = "Maker";
			this.layoutControlItem28.Width = 50;
			this.layoutControlItem28.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem13.Control = this.iInputLabCount;
			this.layoutControlItem13.Height = 29;
			this.layoutControlItem13.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem13.Name = "layoutControlItem13";
			this.layoutControlItem13.Text = "LabIndex";
			this.layoutControlItem13.Width = 50;
			this.layoutControlItem13.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem17.Control = this.cmbLabResult;
			this.layoutControlItem17.Height = 29;
			this.layoutControlItem17.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem17.Name = "layoutControlItem17";
			this.layoutControlItem17.Text = "RdStatus";
			this.layoutControlItem17.Width = 50;
			this.layoutControlItem17.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem34.Control = this.txtSampler;
			this.layoutControlItem34.Height = 29;
			this.layoutControlItem34.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem34.Name = "layoutControlItem34";
			this.layoutControlItem34.Text = "Reviewer";
			this.layoutControlItem34.Width = 50;
			this.layoutControlItem34.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem11.Control = this.tInputUnionLabTime;
			this.layoutControlItem11.Height = 29;
			this.layoutControlItem11.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem11.Name = "layoutControlItem11";
			this.layoutControlItem11.Text = "ARVDate";
			this.layoutControlItem11.Width = 50;
			this.layoutControlItem11.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.nudWaterDeduct.BackgroundStyle.Class = "DateTimeInputBackground";
			this.nudWaterDeduct.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.nudWaterDeduct.ButtonFreeText.Shortcut = global::DevComponents.DotNetBar.eShortcut.F2;
			this.nudWaterDeduct.Increment = 1.0;
			this.nudWaterDeduct.InputHorizontalAlignment = global::DevComponents.Editors.eHorizontalAlignment.Left;
			this.nudWaterDeduct.Location = new global::System.Drawing.Point(98, 178);
			this.nudWaterDeduct.Margin = new global::System.Windows.Forms.Padding(0);
			this.nudWaterDeduct.MaxValue = 99999999.0;
			this.nudWaterDeduct.MinValue = 0.0;
			this.nudWaterDeduct.Name = "nudWaterDeduct";
			this.nudWaterDeduct.ShowUpDown = true;
			this.nudWaterDeduct.Size = new global::System.Drawing.Size(154, 21);
			this.nudWaterDeduct.TabIndex = 11;
			this.layoutControlItem25.Control = this.nudWaterDeduct;
			this.layoutControlItem25.Height = 29;
			this.layoutControlItem25.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem25.Name = "layoutControlItem25";
			this.layoutControlItem25.Text = "WaterDeduct";
			this.layoutControlItem25.Width = 50;
			this.layoutControlItem25.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem27.Control = this.nudImpurityDeduct;
			this.layoutControlItem27.Height = 29;
			this.layoutControlItem27.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem27.Name = "layoutControlItem27";
			this.layoutControlItem27.Text = "WaterDeduct";
			this.layoutControlItem27.Width = 291;
			this.nudImpurityDeduct.BackgroundStyle.Class = "DateTimeInputBackground";
			this.nudImpurityDeduct.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.nudImpurityDeduct.ButtonFreeText.Shortcut = global::DevComponents.DotNetBar.eShortcut.F2;
			this.nudImpurityDeduct.Increment = 1.0;
			this.nudImpurityDeduct.InputHorizontalAlignment = global::DevComponents.Editors.eHorizontalAlignment.Left;
			this.nudImpurityDeduct.Location = new global::System.Drawing.Point(354, 178);
			this.nudImpurityDeduct.Margin = new global::System.Windows.Forms.Padding(0);
			this.nudImpurityDeduct.MaxValue = 99999999.0;
			this.nudImpurityDeduct.MinValue = 0.0;
			this.nudImpurityDeduct.Name = "nudImpurityDeduct";
			this.nudImpurityDeduct.ShowUpDown = true;
			this.nudImpurityDeduct.Size = new global::System.Drawing.Size(155, 21);
			this.nudImpurityDeduct.TabIndex = 12;
			this.layoutControlItem31.Control = this.nudImpurityDeduct;
			this.layoutControlItem31.Height = 29;
			this.layoutControlItem31.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem31.Name = "layoutControlItem31";
			this.layoutControlItem31.Text = "ImpurityDeduct";
			this.layoutControlItem31.Width = 50;
			this.layoutControlItem31.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem32.Control = this.nudOtherDeduct;
			this.layoutControlItem32.Height = 29;
			this.layoutControlItem32.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem32.Name = "layoutControlItem32";
			this.layoutControlItem32.Text = "WaterDeduct";
			this.layoutControlItem32.Width = 50;
			this.layoutControlItem32.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.nudOtherDeduct.BackgroundStyle.Class = "DateTimeInputBackground";
			this.nudOtherDeduct.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.nudOtherDeduct.ButtonFreeText.Shortcut = global::DevComponents.DotNetBar.eShortcut.F2;
			this.nudOtherDeduct.Increment = 1.0;
			this.nudOtherDeduct.InputHorizontalAlignment = global::DevComponents.Editors.eHorizontalAlignment.Left;
			this.nudOtherDeduct.Location = new global::System.Drawing.Point(98, 207);
			this.nudOtherDeduct.Margin = new global::System.Windows.Forms.Padding(0);
			this.nudOtherDeduct.MaxValue = 99999999.0;
			this.nudOtherDeduct.MinValue = 0.0;
			this.nudOtherDeduct.Name = "nudOtherDeduct";
			this.nudOtherDeduct.ShowUpDown = true;
			this.nudOtherDeduct.Size = new global::System.Drawing.Size(154, 21);
			this.nudOtherDeduct.TabIndex = 13;
			this.layoutControlItem36.Control = this.nudOtherDeduct;
			this.layoutControlItem36.Height = 29;
			this.layoutControlItem36.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem36.Name = "layoutControlItem36";
			this.layoutControlItem36.Text = "OtherDeduct";
			this.layoutControlItem36.Width = 50;
			this.layoutControlItem36.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.txtUnionLabCode.Border.Class = "TextBoxBorder";
			this.txtUnionLabCode.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtUnionLabCode.Location = new global::System.Drawing.Point(98, 4);
			this.txtUnionLabCode.Margin = new global::System.Windows.Forms.Padding(0);
			this.txtUnionLabCode.Name = "txtUnionLabCode";
			this.txtUnionLabCode.PreventEnterBeep = true;
			this.txtUnionLabCode.Size = new global::System.Drawing.Size(154, 21);
			this.txtUnionLabCode.TabIndex = 0;
			this.layoutControlItem23.Control = this.txtUnionLabCode;
			this.layoutControlItem23.Height = 29;
			this.layoutControlItem23.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem23.Name = "layoutControlItem23";
			this.layoutControlItem23.Text = "UnionLabCode";
			this.layoutControlItem23.Width = 50;
			this.layoutControlItem23.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			base.ClientSize = new global::System.Drawing.Size(513, 401);
			base.Controls.Add(this.layoutControl1);
			base.Controls.Add(this.menuBar);
			base.Name = "frmUnionlabEdit";
			this.Text = "frmUnionlabEdit";
			base.Load += new global::System.EventHandler(this.frmUnionlabEdit_Load);
			((global::System.ComponentModel.ISupportInitialize)this.menuBar).EndInit();
			this.layoutControl1.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.iInputUnionLabIndex).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.iInputLabCount).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.tInputUnionLabTime).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.tInputEffectiveTime).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudWaterDeduct).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudImpurityDeduct).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudOtherDeduct).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000E76 RID: 3702
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000E77 RID: 3703
		private global::DevComponents.DotNetBar.Bar menuBar;

		// Token: 0x04000E78 RID: 3704
		private global::DevComponents.DotNetBar.ButtonItem btnSave;

		// Token: 0x04000E79 RID: 3705
		private global::DevComponents.DotNetBar.Layout.LayoutControl layoutControl1;

		// Token: 0x04000E7A RID: 3706
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtUnionLabName;

		// Token: 0x04000E7B RID: 3707
		private global::DevComponents.DotNetBar.Controls.RichTextBoxEx rtbMemo;

		// Token: 0x04000E7C RID: 3708
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem1;

		// Token: 0x04000E7D RID: 3709
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem6;

		// Token: 0x04000E7E RID: 3710
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtUnionChemist1;

		// Token: 0x04000E7F RID: 3711
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem4;

		// Token: 0x04000E80 RID: 3712
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem14;

		// Token: 0x04000E81 RID: 3713
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem16;

		// Token: 0x04000E82 RID: 3714
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtDeductInfo;

		// Token: 0x04000E83 RID: 3715
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem19;

		// Token: 0x04000E84 RID: 3716
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem18;

		// Token: 0x04000E85 RID: 3717
		private global::DevComponents.DotNetBar.Controls.ComboBoxEx cmbLabStatus;

		// Token: 0x04000E86 RID: 3718
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem20;

		// Token: 0x04000E87 RID: 3719
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem5;

		// Token: 0x04000E88 RID: 3720
		private global::DevComponents.DotNetBar.Controls.ComboBoxEx cmbUnionStatus;

		// Token: 0x04000E89 RID: 3721
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem22;

		// Token: 0x04000E8A RID: 3722
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem21;

		// Token: 0x04000E8B RID: 3723
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem2;

		// Token: 0x04000E8C RID: 3724
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem7;

		// Token: 0x04000E8D RID: 3725
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem24;

		// Token: 0x04000E8E RID: 3726
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem26;

		// Token: 0x04000E8F RID: 3727
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem28;

		// Token: 0x04000E90 RID: 3728
		private global::DevComponents.DotNetBar.Controls.ComboBoxEx cmbBusinessType;

		// Token: 0x04000E91 RID: 3729
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem3;

		// Token: 0x04000E92 RID: 3730
		private global::DevComponents.Editors.IntegerInput iInputUnionLabIndex;

		// Token: 0x04000E93 RID: 3731
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem9;

		// Token: 0x04000E94 RID: 3732
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtLabMan;

		// Token: 0x04000E95 RID: 3733
		private global::DevComponents.Editors.IntegerInput iInputLabCount;

		// Token: 0x04000E96 RID: 3734
		private global::DevComponents.DotNetBar.Controls.ComboBoxEx cmbLabResult;

		// Token: 0x04000E97 RID: 3735
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem15;

		// Token: 0x04000E98 RID: 3736
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem30;

		// Token: 0x04000E99 RID: 3737
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem12;

		// Token: 0x04000E9A RID: 3738
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem13;

		// Token: 0x04000E9B RID: 3739
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem17;

		// Token: 0x04000E9C RID: 3740
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtUnionChemist2;

		// Token: 0x04000E9D RID: 3741
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtReviewer;

		// Token: 0x04000E9E RID: 3742
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtSampler;

		// Token: 0x04000E9F RID: 3743
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem29;

		// Token: 0x04000EA0 RID: 3744
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem35;

		// Token: 0x04000EA1 RID: 3745
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem33;

		// Token: 0x04000EA2 RID: 3746
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem34;

		// Token: 0x04000EA3 RID: 3747
		private global::DevComponents.Editors.DateTimeAdv.DateTimeInput tInputUnionLabTime;

		// Token: 0x04000EA4 RID: 3748
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem8;

		// Token: 0x04000EA5 RID: 3749
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem11;

		// Token: 0x04000EA6 RID: 3750
		private global::DevComponents.Editors.DateTimeAdv.DateTimeInput tInputEffectiveTime;

		// Token: 0x04000EA7 RID: 3751
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem10;

		// Token: 0x04000EA8 RID: 3752
		private global::DevComponents.Editors.DoubleInput nudWaterDeduct;

		// Token: 0x04000EA9 RID: 3753
		private global::DevComponents.Editors.DoubleInput nudImpurityDeduct;

		// Token: 0x04000EAA RID: 3754
		private global::DevComponents.Editors.DoubleInput nudOtherDeduct;

		// Token: 0x04000EAB RID: 3755
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem25;

		// Token: 0x04000EAC RID: 3756
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem31;

		// Token: 0x04000EAD RID: 3757
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem36;

		// Token: 0x04000EAE RID: 3758
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem27;

		// Token: 0x04000EAF RID: 3759
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem32;

		// Token: 0x04000EB0 RID: 3760
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtUnionLabCode;

		// Token: 0x04000EB1 RID: 3761
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem23;
	}
}
