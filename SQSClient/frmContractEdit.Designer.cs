namespace SQSClient
{
	// Token: 0x02000021 RID: 33
	public partial class frmContractEdit : global::SQSClient.BaseDialogForm
	{
		// Token: 0x06000196 RID: 406 RVA: 0x0002FECC File Offset: 0x0002E0CC
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000197 RID: 407 RVA: 0x0002FF04 File Offset: 0x0002E104
		private void InitializeComponent()
		{
			this.menuBar = new global::DevComponents.DotNetBar.Bar();
			this.btnSave = new global::DevComponents.DotNetBar.ButtonItem();
			this.layoutControl1 = new global::DevComponents.DotNetBar.Layout.LayoutControl();
			this.tInputEndTime = new global::DevComponents.Editors.DateTimeAdv.DateTimeInput();
			this.tInputStartTime = new global::DevComponents.Editors.DateTimeAdv.DateTimeInput();
			this.tInputLiableTime = new global::DevComponents.Editors.DateTimeAdv.DateTimeInput();
			this.txtLiablePerson = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.cmbPlanType = new global::Base.AutoComboBox();
			this.cmbPartyA = new global::Base.AutoComboBox();
			this.cmbPartyB = new global::Base.AutoComboBox();
			this.dInputPlanAmount = new global::DevComponents.Editors.DoubleInput();
			this.cmbProduct = new global::Base.AutoComboBox();
			this.txtContractNum = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.rtbRemark = new global::DevComponents.DotNetBar.Controls.RichTextBoxEx();
			this.cmbDanWei = new global::Base.AutoComboBox();
			this.layoutControlItem1 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem9 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem8 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem3 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem2 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem5 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem12 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem10 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem11 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem4 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem7 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem6 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			((global::System.ComponentModel.ISupportInitialize)this.menuBar).BeginInit();
			this.layoutControl1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.tInputEndTime).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.tInputStartTime).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.tInputLiableTime).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.dInputPlanAmount).BeginInit();
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
			this.menuBar.Size = new global::System.Drawing.Size(354, 26);
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
			this.layoutControl1.Controls.Add(this.tInputEndTime);
			this.layoutControl1.Controls.Add(this.tInputStartTime);
			this.layoutControl1.Controls.Add(this.tInputLiableTime);
			this.layoutControl1.Controls.Add(this.txtLiablePerson);
			this.layoutControl1.Controls.Add(this.cmbPlanType);
			this.layoutControl1.Controls.Add(this.cmbPartyA);
			this.layoutControl1.Controls.Add(this.cmbPartyB);
			this.layoutControl1.Controls.Add(this.dInputPlanAmount);
			this.layoutControl1.Controls.Add(this.cmbProduct);
			this.layoutControl1.Controls.Add(this.txtContractNum);
			this.layoutControl1.Controls.Add(this.rtbRemark);
			this.layoutControl1.Controls.Add(this.cmbDanWei);
			this.layoutControl1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.layoutControl1.Location = new global::System.Drawing.Point(0, 26);
			this.layoutControl1.Name = "layoutControl1";
			this.layoutControl1.RootGroup.Items.AddRange(new global::DevComponents.DotNetBar.Layout.LayoutItemBase[]
			{
				this.layoutControlItem1,
				this.layoutControlItem9,
				this.layoutControlItem8,
				this.layoutControlItem3,
				this.layoutControlItem2,
				this.layoutControlItem5,
				this.layoutControlItem12,
				this.layoutControlItem10,
				this.layoutControlItem11,
				this.layoutControlItem4,
				this.layoutControlItem7,
				this.layoutControlItem6
			});
			this.layoutControl1.Size = new global::System.Drawing.Size(354, 378);
			this.layoutControl1.TabIndex = 22;
			this.tInputEndTime.BackgroundStyle.Class = "DateTimeInputBackground";
			this.tInputEndTime.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.tInputEndTime.ButtonDropDown.Shortcut = global::DevComponents.DotNetBar.eShortcut.AltDown;
			this.tInputEndTime.ButtonDropDown.Visible = true;
			this.tInputEndTime.IsPopupCalendarOpen = false;
			this.tInputEndTime.Location = new global::System.Drawing.Point(92, 232);
			this.tInputEndTime.Margin = new global::System.Windows.Forms.Padding(0);
			this.tInputEndTime.MonthCalendar.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.tInputEndTime.MonthCalendar.CalendarDimensions = new global::System.Drawing.Size(1, 1);
			this.tInputEndTime.MonthCalendar.ClearButtonVisible = true;
			this.tInputEndTime.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = global::DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
			this.tInputEndTime.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
			this.tInputEndTime.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.BarBackground;
			this.tInputEndTime.MonthCalendar.CommandsBackgroundStyle.BorderTop = global::DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.tInputEndTime.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
			this.tInputEndTime.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
			this.tInputEndTime.MonthCalendar.CommandsBackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.tInputEndTime.MonthCalendar.DisplayMonth = new global::System.DateTime(2018, 12, 1, 0, 0, 0, 0);
			this.tInputEndTime.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
			this.tInputEndTime.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
			this.tInputEndTime.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
			this.tInputEndTime.MonthCalendar.NavigationBackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.tInputEndTime.MonthCalendar.TodayButtonVisible = true;
			this.tInputEndTime.Name = "tInputEndTime";
			this.tInputEndTime.Size = new global::System.Drawing.Size(258, 21);
			this.tInputEndTime.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.tInputEndTime.TabIndex = 8;
			this.tInputEndTime.ValueChanged += new global::System.EventHandler(this.tInputEndTime_ValueChanged);
			this.tInputStartTime.BackgroundStyle.Class = "DateTimeInputBackground";
			this.tInputStartTime.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.tInputStartTime.ButtonDropDown.Shortcut = global::DevComponents.DotNetBar.eShortcut.AltDown;
			this.tInputStartTime.ButtonDropDown.Visible = true;
			this.tInputStartTime.IsPopupCalendarOpen = false;
			this.tInputStartTime.Location = new global::System.Drawing.Point(92, 203);
			this.tInputStartTime.Margin = new global::System.Windows.Forms.Padding(0);
			this.tInputStartTime.MonthCalendar.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.tInputStartTime.MonthCalendar.CalendarDimensions = new global::System.Drawing.Size(1, 1);
			this.tInputStartTime.MonthCalendar.ClearButtonVisible = true;
			this.tInputStartTime.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = global::DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
			this.tInputStartTime.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
			this.tInputStartTime.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.BarBackground;
			this.tInputStartTime.MonthCalendar.CommandsBackgroundStyle.BorderTop = global::DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.tInputStartTime.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
			this.tInputStartTime.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
			this.tInputStartTime.MonthCalendar.CommandsBackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.tInputStartTime.MonthCalendar.DisplayMonth = new global::System.DateTime(2018, 12, 1, 0, 0, 0, 0);
			this.tInputStartTime.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
			this.tInputStartTime.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
			this.tInputStartTime.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
			this.tInputStartTime.MonthCalendar.NavigationBackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.tInputStartTime.MonthCalendar.TodayButtonVisible = true;
			this.tInputStartTime.Name = "tInputStartTime";
			this.tInputStartTime.Size = new global::System.Drawing.Size(258, 21);
			this.tInputStartTime.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.tInputStartTime.TabIndex = 7;
			this.tInputStartTime.ValueChanged += new global::System.EventHandler(this.tInputStartTime_ValueChanged);
			this.tInputLiableTime.BackgroundStyle.Class = "DateTimeInputBackground";
			this.tInputLiableTime.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.tInputLiableTime.ButtonDropDown.Shortcut = global::DevComponents.DotNetBar.eShortcut.AltDown;
			this.tInputLiableTime.ButtonDropDown.Visible = true;
			this.tInputLiableTime.IsPopupCalendarOpen = false;
			this.tInputLiableTime.Location = new global::System.Drawing.Point(92, 290);
			this.tInputLiableTime.Margin = new global::System.Windows.Forms.Padding(0);
			this.tInputLiableTime.MonthCalendar.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.tInputLiableTime.MonthCalendar.CalendarDimensions = new global::System.Drawing.Size(1, 1);
			this.tInputLiableTime.MonthCalendar.ClearButtonVisible = true;
			this.tInputLiableTime.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = global::DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
			this.tInputLiableTime.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
			this.tInputLiableTime.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.BarBackground;
			this.tInputLiableTime.MonthCalendar.CommandsBackgroundStyle.BorderTop = global::DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.tInputLiableTime.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
			this.tInputLiableTime.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
			this.tInputLiableTime.MonthCalendar.CommandsBackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.tInputLiableTime.MonthCalendar.DisplayMonth = new global::System.DateTime(2018, 12, 1, 0, 0, 0, 0);
			this.tInputLiableTime.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
			this.tInputLiableTime.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
			this.tInputLiableTime.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
			this.tInputLiableTime.MonthCalendar.NavigationBackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.tInputLiableTime.MonthCalendar.TodayButtonVisible = true;
			this.tInputLiableTime.Name = "tInputLiableTime";
			this.tInputLiableTime.Size = new global::System.Drawing.Size(258, 21);
			this.tInputLiableTime.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.tInputLiableTime.TabIndex = 10;
			this.txtLiablePerson.Border.Class = "TextBoxBorder";
			this.txtLiablePerson.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtLiablePerson.Location = new global::System.Drawing.Point(92, 261);
			this.txtLiablePerson.Margin = new global::System.Windows.Forms.Padding(0);
			this.txtLiablePerson.Name = "txtLiablePerson";
			this.txtLiablePerson.PreventEnterBeep = true;
			this.txtLiablePerson.Size = new global::System.Drawing.Size(258, 21);
			this.txtLiablePerson.TabIndex = 9;
			this.cmbPlanType.DataSource = null;
			this.cmbPlanType.DisplayMember = null;
			this.cmbPlanType.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cmbPlanType.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbPlanType.FormattingEnabled = true;
			this.cmbPlanType.ItemHeight = 16;
			this.cmbPlanType.Location = new global::System.Drawing.Point(92, 89);
			this.cmbPlanType.Margin = new global::System.Windows.Forms.Padding(0);
			this.cmbPlanType.MaxDropDownItems = 20;
			this.cmbPlanType.Name = "cmbPlanType";
			this.cmbPlanType.SelectMember = null;
			this.cmbPlanType.Size = new global::System.Drawing.Size(258, 22);
			this.cmbPlanType.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.cmbPlanType.TabIndex = 3;
			this.cmbPlanType.ValueMember = null;
			this.cmbPartyA.DataSource = null;
			this.cmbPartyA.DisplayMember = null;
			this.cmbPartyA.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cmbPartyA.FormattingEnabled = true;
			this.cmbPartyA.ItemHeight = 15;
			this.cmbPartyA.Location = new global::System.Drawing.Point(92, 33);
			this.cmbPartyA.Margin = new global::System.Windows.Forms.Padding(0);
			this.cmbPartyA.MaxDropDownItems = 20;
			this.cmbPartyA.Name = "cmbPartyA";
			this.cmbPartyA.SelectMember = null;
			this.cmbPartyA.Size = new global::System.Drawing.Size(258, 21);
			this.cmbPartyA.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.cmbPartyA.TabIndex = 1;
			this.cmbPartyA.ValueMember = null;
			this.cmbPartyB.DataSource = null;
			this.cmbPartyB.DisplayMember = null;
			this.cmbPartyB.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cmbPartyB.FormattingEnabled = true;
			this.cmbPartyB.ItemHeight = 15;
			this.cmbPartyB.Location = new global::System.Drawing.Point(92, 61);
			this.cmbPartyB.Margin = new global::System.Windows.Forms.Padding(0);
			this.cmbPartyB.MaxDropDownItems = 20;
			this.cmbPartyB.Name = "cmbPartyB";
			this.cmbPartyB.SelectMember = null;
			this.cmbPartyB.Size = new global::System.Drawing.Size(258, 21);
			this.cmbPartyB.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.cmbPartyB.TabIndex = 2;
			this.cmbPartyB.ValueMember = null;
			this.dInputPlanAmount.BackgroundStyle.Class = "DateTimeInputBackground";
			this.dInputPlanAmount.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.dInputPlanAmount.ButtonFreeText.Shortcut = global::DevComponents.DotNetBar.eShortcut.F2;
			this.dInputPlanAmount.Increment = 1.0;
			this.dInputPlanAmount.InputHorizontalAlignment = global::DevComponents.Editors.eHorizontalAlignment.Left;
			this.dInputPlanAmount.Location = new global::System.Drawing.Point(92, 145);
			this.dInputPlanAmount.Margin = new global::System.Windows.Forms.Padding(0);
			this.dInputPlanAmount.MinValue = 0.0;
			this.dInputPlanAmount.Name = "dInputPlanAmount";
			this.dInputPlanAmount.ShowUpDown = true;
			this.dInputPlanAmount.Size = new global::System.Drawing.Size(258, 21);
			this.dInputPlanAmount.TabIndex = 5;
			this.dInputPlanAmount.ValueChanged += new global::System.EventHandler(this.dInputPlanAmount_ValueChanged);
			this.cmbProduct.DataSource = null;
			this.cmbProduct.DisplayMember = null;
			this.cmbProduct.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cmbProduct.FormattingEnabled = true;
			this.cmbProduct.ItemHeight = 15;
			this.cmbProduct.Location = new global::System.Drawing.Point(92, 117);
			this.cmbProduct.Margin = new global::System.Windows.Forms.Padding(0);
			this.cmbProduct.MaxDropDownItems = 20;
			this.cmbProduct.Name = "cmbProduct";
			this.cmbProduct.SelectMember = null;
			this.cmbProduct.Size = new global::System.Drawing.Size(258, 21);
			this.cmbProduct.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.cmbProduct.TabIndex = 4;
			this.cmbProduct.ValueMember = null;
			this.txtContractNum.Border.Class = "TextBoxBorder";
			this.txtContractNum.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtContractNum.Location = new global::System.Drawing.Point(92, 4);
			this.txtContractNum.Margin = new global::System.Windows.Forms.Padding(0);
			this.txtContractNum.Name = "txtContractNum";
			this.txtContractNum.PreventEnterBeep = true;
			this.txtContractNum.Size = new global::System.Drawing.Size(258, 21);
			this.txtContractNum.TabIndex = 0;
			this.rtbRemark.BackgroundStyle.Class = "RichTextBoxBorder";
			this.rtbRemark.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.rtbRemark.Location = new global::System.Drawing.Point(92, 319);
			this.rtbRemark.Margin = new global::System.Windows.Forms.Padding(0);
			this.rtbRemark.MaxLength = 200;
			this.rtbRemark.Name = "rtbRemark";
			this.rtbRemark.Rtf = "{\\rtf1\\ansi\\ansicpg936\\deff0\\deflang1033\\deflangfe2052{\\fonttbl{\\f0\\fnil\\fcharset134 \\'cb\\'ce\\'cc\\'e5;}}\r\n\\viewkind4\\uc1\\pard\\lang2052\\f0\\fs18\\par\r\n}\r\n";
			this.rtbRemark.Size = new global::System.Drawing.Size(258, 52);
			this.rtbRemark.TabIndex = 11;
			this.cmbDanWei.DataSource = null;
			this.cmbDanWei.DisplayMember = null;
			this.cmbDanWei.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cmbDanWei.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbDanWei.FormattingEnabled = true;
			this.cmbDanWei.ItemHeight = 16;
			this.cmbDanWei.Location = new global::System.Drawing.Point(92, 174);
			this.cmbDanWei.Margin = new global::System.Windows.Forms.Padding(0);
			this.cmbDanWei.MaxDropDownItems = 20;
			this.cmbDanWei.Name = "cmbDanWei";
			this.cmbDanWei.SelectMember = null;
			this.cmbDanWei.Size = new global::System.Drawing.Size(258, 22);
			this.cmbDanWei.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.cmbDanWei.TabIndex = 6;
			this.cmbDanWei.ValueMember = null;
			this.layoutControlItem1.Control = this.txtContractNum;
			this.layoutControlItem1.Height = 29;
			this.layoutControlItem1.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Text = "*ContractID";
			this.layoutControlItem1.Width = 100;
			this.layoutControlItem1.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem9.Control = this.cmbPartyA;
			this.layoutControlItem9.Height = 28;
			this.layoutControlItem9.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem9.Name = "layoutControlItem9";
			this.layoutControlItem9.Text = "*PartyA";
			this.layoutControlItem9.Width = 100;
			this.layoutControlItem9.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem8.Control = this.cmbPartyB;
			this.layoutControlItem8.Height = 28;
			this.layoutControlItem8.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem8.Name = "layoutControlItem8";
			this.layoutControlItem8.Text = "*PartyB";
			this.layoutControlItem8.Width = 100;
			this.layoutControlItem8.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem3.Control = this.cmbPlanType;
			this.layoutControlItem3.Height = 28;
			this.layoutControlItem3.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem3.Name = "layoutControlItem3";
			this.layoutControlItem3.Text = "*BusinessType";
			this.layoutControlItem3.Width = 100;
			this.layoutControlItem3.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem2.Control = this.cmbProduct;
			this.layoutControlItem2.Height = 28;
			this.layoutControlItem2.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem2.Name = "layoutControlItem2";
			this.layoutControlItem2.Text = "*Product";
			this.layoutControlItem2.Width = 100;
			this.layoutControlItem2.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem5.Control = this.dInputPlanAmount;
			this.layoutControlItem5.Height = 29;
			this.layoutControlItem5.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem5.Name = "layoutControlItem5";
			this.layoutControlItem5.Text = "*JiHuaLiang";
			this.layoutControlItem5.Width = 100;
			this.layoutControlItem5.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem12.Control = this.cmbDanWei;
			this.layoutControlItem12.Height = 29;
			this.layoutControlItem12.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem12.Name = "layoutControlItem12";
			this.layoutControlItem12.Text = "*DanWei";
			this.layoutControlItem12.Width = 100;
			this.layoutControlItem12.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem10.Control = this.tInputStartTime;
			this.layoutControlItem10.Height = 29;
			this.layoutControlItem10.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem10.Name = "layoutControlItem10";
			this.layoutControlItem10.Text = "*StartTime";
			this.layoutControlItem10.Width = 100;
			this.layoutControlItem10.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem11.Control = this.tInputEndTime;
			this.layoutControlItem11.Height = 29;
			this.layoutControlItem11.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem11.Name = "layoutControlItem11";
			this.layoutControlItem11.Text = "*EndTime";
			this.layoutControlItem11.Width = 100;
			this.layoutControlItem11.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem4.Control = this.txtLiablePerson;
			this.layoutControlItem4.Height = 29;
			this.layoutControlItem4.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem4.Name = "layoutControlItem4";
			this.layoutControlItem4.Text = "Signer";
			this.layoutControlItem4.Width = 100;
			this.layoutControlItem4.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem7.Control = this.tInputLiableTime;
			this.layoutControlItem7.Height = 29;
			this.layoutControlItem7.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem7.Name = "layoutControlItem7";
			this.layoutControlItem7.Text = "*SignDate";
			this.layoutControlItem7.Width = 100;
			this.layoutControlItem7.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem6.Control = this.rtbRemark;
			this.layoutControlItem6.Height = 60;
			this.layoutControlItem6.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem6.Name = "layoutControlItem6";
			this.layoutControlItem6.Text = "Remark";
			this.layoutControlItem6.Width = 100;
			this.layoutControlItem6.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			base.ClientSize = new global::System.Drawing.Size(354, 404);
			base.Controls.Add(this.layoutControl1);
			base.Controls.Add(this.menuBar);
			base.Name = "frmContractEdit";
			this.Text = "frmContractEdit";
			base.Load += new global::System.EventHandler(this.frmContractEdit_Load);
			((global::System.ComponentModel.ISupportInitialize)this.menuBar).EndInit();
			this.layoutControl1.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.tInputEndTime).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.tInputStartTime).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.tInputLiableTime).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.dInputPlanAmount).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x040002CF RID: 719
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x040002D0 RID: 720
		private global::DevComponents.DotNetBar.Bar menuBar;

		// Token: 0x040002D1 RID: 721
		private global::DevComponents.DotNetBar.ButtonItem btnSave;

		// Token: 0x040002D2 RID: 722
		private global::DevComponents.DotNetBar.Layout.LayoutControl layoutControl1;

		// Token: 0x040002D3 RID: 723
		private global::DevComponents.Editors.DoubleInput dInputPlanAmount;

		// Token: 0x040002D4 RID: 724
		private global::Base.AutoComboBox cmbProduct;

		// Token: 0x040002D5 RID: 725
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtContractNum;

		// Token: 0x040002D6 RID: 726
		private global::DevComponents.DotNetBar.Controls.RichTextBoxEx rtbRemark;

		// Token: 0x040002D7 RID: 727
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem1;

		// Token: 0x040002D8 RID: 728
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem2;

		// Token: 0x040002D9 RID: 729
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem5;

		// Token: 0x040002DA RID: 730
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem6;

		// Token: 0x040002DB RID: 731
		private global::DevComponents.Editors.DateTimeAdv.DateTimeInput tInputEndTime;

		// Token: 0x040002DC RID: 732
		private global::DevComponents.Editors.DateTimeAdv.DateTimeInput tInputStartTime;

		// Token: 0x040002DD RID: 733
		private global::DevComponents.Editors.DateTimeAdv.DateTimeInput tInputLiableTime;

		// Token: 0x040002DE RID: 734
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtLiablePerson;

		// Token: 0x040002DF RID: 735
		private global::Base.AutoComboBox cmbPlanType;

		// Token: 0x040002E0 RID: 736
		private global::Base.AutoComboBox cmbPartyA;

		// Token: 0x040002E1 RID: 737
		private global::Base.AutoComboBox cmbPartyB;

		// Token: 0x040002E2 RID: 738
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem9;

		// Token: 0x040002E3 RID: 739
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem8;

		// Token: 0x040002E4 RID: 740
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem3;

		// Token: 0x040002E5 RID: 741
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem4;

		// Token: 0x040002E6 RID: 742
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem7;

		// Token: 0x040002E7 RID: 743
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem10;

		// Token: 0x040002E8 RID: 744
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem11;

		// Token: 0x040002E9 RID: 745
		private global::Base.AutoComboBox cmbDanWei;

		// Token: 0x040002EA RID: 746
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem12;
	}
}
