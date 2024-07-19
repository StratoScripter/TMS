namespace SQSClient
{
	// Token: 0x02000031 RID: 49
	public partial class frmPricePolicyEdit : global::SQSClient.BaseDialogForm
	{
		// Token: 0x06000257 RID: 599 RVA: 0x00041774 File Offset: 0x0003F974
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000258 RID: 600 RVA: 0x000417AC File Offset: 0x0003F9AC
		private void InitializeComponent()
		{
			this.menuBar = new global::DevComponents.DotNetBar.Bar();
			this.btnSave = new global::DevComponents.DotNetBar.ButtonItem();
			this.layoutControlItem2 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem4 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem7 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem9 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem11 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem3 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem8 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem12 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem14 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem5 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem18 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.splitContainer1 = new global::System.Windows.Forms.SplitContainer();
			this.layoutControl1 = new global::DevComponents.DotNetBar.Layout.LayoutControl();
			this.dtRunTime = new global::DevComponents.Editors.DateTimeAdv.DateTimeInput();
			this.rtbRemark = new global::DevComponents.DotNetBar.Controls.RichTextBoxEx();
			this.txtKeyCode = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.txtPriceType = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.btnAdd = new global::DevComponents.DotNetBar.ButtonX();
			this.layoutControlItem6 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem10 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem15 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem16 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem1 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.lytPriceControl = new global::DevComponents.DotNetBar.Layout.LayoutControl();
			((global::System.ComponentModel.ISupportInitialize)this.menuBar).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.splitContainer1).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.layoutControl1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dtRunTime).BeginInit();
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
			this.menuBar.Size = new global::System.Drawing.Size(469, 26);
			this.menuBar.Stretch = true;
			this.menuBar.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.menuBar.TabIndex = 20;
			this.menuBar.TabStop = false;
			this.menuBar.Text = "Main Menu";
			this.btnSave.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.btnSave.Image = global::SQSClient.Properties.Resources.save16;
			this.btnSave.Name = "btnSave";
			this.btnSave.Text = "Save";
			this.btnSave.Click += new global::System.EventHandler(this.btnSave_Click);
			this.layoutControlItem2.Height = 29;
			this.layoutControlItem2.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem2.Name = "layoutControlItem2";
			this.layoutControlItem2.Text = "Label:";
			this.layoutControlItem2.Width = 100;
			this.layoutControlItem2.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem4.Height = 29;
			this.layoutControlItem4.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem4.Name = "layoutControlItem4";
			this.layoutControlItem4.Text = "Label:";
			this.layoutControlItem4.Width = 100;
			this.layoutControlItem4.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem7.Height = 29;
			this.layoutControlItem7.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem7.Name = "layoutControlItem7";
			this.layoutControlItem7.Width = 40;
			this.layoutControlItem7.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem9.Height = 29;
			this.layoutControlItem9.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem9.Name = "layoutControlItem9";
			this.layoutControlItem9.Text = "Label:";
			this.layoutControlItem9.Width = 100;
			this.layoutControlItem9.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem11.Height = 29;
			this.layoutControlItem11.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem11.Name = "layoutControlItem11";
			this.layoutControlItem11.Text = "Label:";
			this.layoutControlItem11.Width = 100;
			this.layoutControlItem11.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem3.Height = 29;
			this.layoutControlItem3.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem3.Name = "layoutControlItem3";
			this.layoutControlItem3.Text = "Label:";
			this.layoutControlItem3.Width = 100;
			this.layoutControlItem3.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem8.Height = 29;
			this.layoutControlItem8.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem8.Name = "layoutControlItem8";
			this.layoutControlItem8.Text = "Label:";
			this.layoutControlItem8.Width = 100;
			this.layoutControlItem8.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem12.Height = 29;
			this.layoutControlItem12.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem12.Name = "layoutControlItem12";
			this.layoutControlItem12.Text = "Label:";
			this.layoutControlItem12.Width = 100;
			this.layoutControlItem12.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem14.Height = 29;
			this.layoutControlItem14.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem14.Name = "layoutControlItem14";
			this.layoutControlItem14.Text = "Label:";
			this.layoutControlItem14.Width = 100;
			this.layoutControlItem14.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem5.Height = 29;
			this.layoutControlItem5.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem5.Name = "layoutControlItem5";
			this.layoutControlItem5.Text = "阀值:";
			this.layoutControlItem5.Width = 100;
			this.layoutControlItem5.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem18.Height = 20;
			this.layoutControlItem18.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem18.Name = "layoutControlItem18";
			this.layoutControlItem18.Text = "Explain";
			this.layoutControlItem18.Width = 40;
			this.layoutControlItem18.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.splitContainer1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new global::System.Drawing.Point(0, 26);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = global::System.Windows.Forms.Orientation.Horizontal;
			this.splitContainer1.Panel1.Controls.Add(this.layoutControl1);
			this.splitContainer1.Panel2.Controls.Add(this.lytPriceControl);
			this.splitContainer1.Size = new global::System.Drawing.Size(469, 511);
			this.splitContainer1.SplitterDistance = 201;
			this.splitContainer1.TabIndex = 21;
			this.layoutControl1.Controls.Add(this.dtRunTime);
			this.layoutControl1.Controls.Add(this.rtbRemark);
			this.layoutControl1.Controls.Add(this.txtKeyCode);
			this.layoutControl1.Controls.Add(this.txtPriceType);
			this.layoutControl1.Controls.Add(this.btnAdd);
			this.layoutControl1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.layoutControl1.Location = new global::System.Drawing.Point(0, 0);
			this.layoutControl1.Name = "layoutControl1";
			this.layoutControl1.RootGroup.Items.AddRange(new global::DevComponents.DotNetBar.Layout.LayoutItemBase[]
			{
				this.layoutControlItem6,
				this.layoutControlItem10,
				this.layoutControlItem15,
				this.layoutControlItem16,
				this.layoutControlItem1
			});
			this.layoutControl1.Size = new global::System.Drawing.Size(469, 201);
			this.layoutControl1.TabIndex = 22;
			this.dtRunTime.BackgroundStyle.Class = "DateTimeInputBackground";
			this.dtRunTime.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.dtRunTime.ButtonDropDown.Shortcut = global::DevComponents.DotNetBar.eShortcut.AltDown;
			this.dtRunTime.ButtonDropDown.Visible = true;
			this.dtRunTime.CustomFormat = "yyyy-MM-dd HH:mm";
			this.dtRunTime.Format = global::DevComponents.Editors.eDateTimePickerFormat.Custom;
			this.dtRunTime.IsPopupCalendarOpen = false;
			this.dtRunTime.Location = new global::System.Drawing.Point(67, 33);
			this.dtRunTime.Margin = new global::System.Windows.Forms.Padding(0);
			this.dtRunTime.MonthCalendar.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.dtRunTime.MonthCalendar.CalendarDimensions = new global::System.Drawing.Size(1, 1);
			this.dtRunTime.MonthCalendar.ClearButtonVisible = true;
			this.dtRunTime.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = global::DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
			this.dtRunTime.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
			this.dtRunTime.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.BarBackground;
			this.dtRunTime.MonthCalendar.CommandsBackgroundStyle.BorderTop = global::DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.dtRunTime.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
			this.dtRunTime.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
			this.dtRunTime.MonthCalendar.CommandsBackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.dtRunTime.MonthCalendar.DisplayMonth = new global::System.DateTime(2021, 6, 1, 0, 0, 0, 0);
			this.dtRunTime.MonthCalendar.FirstDayOfWeek = global::System.DayOfWeek.Monday;
			this.dtRunTime.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
			this.dtRunTime.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
			this.dtRunTime.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
			this.dtRunTime.MonthCalendar.NavigationBackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.dtRunTime.MonthCalendar.TodayButtonVisible = true;
			this.dtRunTime.Name = "dtRunTime";
			this.dtRunTime.Size = new global::System.Drawing.Size(398, 21);
			this.dtRunTime.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.dtRunTime.TabIndex = 2;
			this.rtbRemark.BackgroundStyle.Class = "RichTextBoxBorder";
			this.rtbRemark.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.rtbRemark.Location = new global::System.Drawing.Point(67, 62);
			this.rtbRemark.Margin = new global::System.Windows.Forms.Padding(0);
			this.rtbRemark.Name = "rtbRemark";
			this.rtbRemark.Rtf = "{\\rtf1\\ansi\\ansicpg936\\deff0\\nouicompat\\deflang1033\\deflangfe2052{\\fonttbl{\\f0\\fnil\\fcharset134 \\'cb\\'ce\\'cc\\'e5;}}\r\n{\\*\\generator Riched20 10.0.18362}\\viewkind4\\uc1 \r\n\\pard\\f0\\fs18\\lang2052\\par\r\n}\r\n";
			this.rtbRemark.Size = new global::System.Drawing.Size(398, 100);
			this.rtbRemark.TabIndex = 3;
			this.txtKeyCode.Border.Class = "TextBoxBorder";
			this.txtKeyCode.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtKeyCode.Location = new global::System.Drawing.Point(67, 4);
			this.txtKeyCode.Margin = new global::System.Windows.Forms.Padding(0);
			this.txtKeyCode.Name = "txtKeyCode";
			this.txtKeyCode.PreventEnterBeep = true;
			this.txtKeyCode.ReadOnly = true;
			this.txtKeyCode.Size = new global::System.Drawing.Size(163, 21);
			this.txtKeyCode.TabIndex = 0;
			this.txtPriceType.Border.Class = "TextBoxBorder";
			this.txtPriceType.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtPriceType.Location = new global::System.Drawing.Point(301, 4);
			this.txtPriceType.Margin = new global::System.Windows.Forms.Padding(0);
			this.txtPriceType.Name = "txtPriceType";
			this.txtPriceType.PreventEnterBeep = true;
			this.txtPriceType.ReadOnly = true;
			this.txtPriceType.Size = new global::System.Drawing.Size(164, 21);
			this.txtPriceType.TabIndex = 1;
			this.btnAdd.AccessibleRole = global::System.Windows.Forms.AccessibleRole.PushButton;
			this.btnAdd.ColorTable = global::DevComponents.DotNetBar.eButtonColor.Orange;
			this.btnAdd.Image = global::SQSClient.Properties.Resources.add16;
			this.btnAdd.Location = new global::System.Drawing.Point(4, 170);
			this.btnAdd.Margin = new global::System.Windows.Forms.Padding(0);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new global::System.Drawing.Size(70, 23);
			this.btnAdd.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.btnAdd.TabIndex = 4;
			this.btnAdd.Text = "New";
			this.btnAdd.TextAlignment = global::DevComponents.DotNetBar.eButtonTextAlignment.Left;
			this.btnAdd.Tooltip = "增加物料";
			this.btnAdd.Click += new global::System.EventHandler(this.btnAdd_Click);
			this.layoutControlItem6.Control = this.txtKeyCode;
			this.layoutControlItem6.Height = 29;
			this.layoutControlItem6.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem6.Name = "layoutControlItem6";
			this.layoutControlItem6.Text = "KeyCode";
			this.layoutControlItem6.Width = 50;
			this.layoutControlItem6.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem10.Control = this.txtPriceType;
			this.layoutControlItem10.Height = 29;
			this.layoutControlItem10.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem10.Name = "layoutControlItem10";
			this.layoutControlItem10.Text = "PriceType";
			this.layoutControlItem10.Width = 50;
			this.layoutControlItem10.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem15.Control = this.dtRunTime;
			this.layoutControlItem15.Height = 29;
			this.layoutControlItem15.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem15.Name = "layoutControlItem15";
			this.layoutControlItem15.Text = "RunTime";
			this.layoutControlItem15.Width = 100;
			this.layoutControlItem15.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem16.Control = this.rtbRemark;
			this.layoutControlItem16.Height = 108;
			this.layoutControlItem16.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem16.Name = "layoutControlItem16";
			this.layoutControlItem16.Text = "Remark";
			this.layoutControlItem16.Width = 100;
			this.layoutControlItem16.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem1.Control = this.btnAdd;
			this.layoutControlItem1.Height = 31;
			this.layoutControlItem1.MinSize = new global::System.Drawing.Size(32, 20);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Width = 78;
			this.lytPriceControl.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.lytPriceControl.Location = new global::System.Drawing.Point(0, 0);
			this.lytPriceControl.Name = "lytPriceControl";
			this.lytPriceControl.Size = new global::System.Drawing.Size(469, 306);
			this.lytPriceControl.TabIndex = 23;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 12f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(469, 537);
			base.Controls.Add(this.splitContainer1);
			base.Controls.Add(this.menuBar);
			base.Name = "frmPricePolicyEdit";
			this.Text = "frmPricePolicyEdit";
			base.Load += new global::System.EventHandler(this.frmPricePolicyEdit_Load);
			((global::System.ComponentModel.ISupportInitialize)this.menuBar).EndInit();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.splitContainer1).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.layoutControl1.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.dtRunTime).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000410 RID: 1040
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000411 RID: 1041
		private global::DevComponents.DotNetBar.Bar menuBar;

		// Token: 0x04000412 RID: 1042
		private global::DevComponents.DotNetBar.ButtonItem btnSave;

		// Token: 0x04000413 RID: 1043
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem2;

		// Token: 0x04000414 RID: 1044
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem4;

		// Token: 0x04000415 RID: 1045
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem7;

		// Token: 0x04000416 RID: 1046
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem9;

		// Token: 0x04000417 RID: 1047
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem11;

		// Token: 0x04000418 RID: 1048
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem3;

		// Token: 0x04000419 RID: 1049
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem8;

		// Token: 0x0400041A RID: 1050
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem12;

		// Token: 0x0400041B RID: 1051
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem14;

		// Token: 0x0400041C RID: 1052
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem5;

		// Token: 0x0400041D RID: 1053
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem18;

		// Token: 0x0400041E RID: 1054
		private global::System.Windows.Forms.SplitContainer splitContainer1;

		// Token: 0x0400041F RID: 1055
		private global::DevComponents.DotNetBar.Layout.LayoutControl layoutControl1;

		// Token: 0x04000420 RID: 1056
		private global::DevComponents.Editors.DateTimeAdv.DateTimeInput dtRunTime;

		// Token: 0x04000421 RID: 1057
		private global::DevComponents.DotNetBar.Controls.RichTextBoxEx rtbRemark;

		// Token: 0x04000422 RID: 1058
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtKeyCode;

		// Token: 0x04000423 RID: 1059
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtPriceType;

		// Token: 0x04000424 RID: 1060
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem6;

		// Token: 0x04000425 RID: 1061
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem10;

		// Token: 0x04000426 RID: 1062
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem15;

		// Token: 0x04000427 RID: 1063
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem16;

		// Token: 0x04000428 RID: 1064
		private global::DevComponents.DotNetBar.ButtonX btnAdd;

		// Token: 0x04000429 RID: 1065
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem1;

		// Token: 0x0400042A RID: 1066
		private global::DevComponents.DotNetBar.Layout.LayoutControl lytPriceControl;
	}
}
