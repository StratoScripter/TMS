namespace SQSClient
{
	// Token: 0x02000018 RID: 24
	public partial class frmTicketEdit : global::SQSClient.BaseDialogForm
	{
		// Token: 0x06000118 RID: 280 RVA: 0x00022078 File Offset: 0x00020278
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000119 RID: 281 RVA: 0x000220B0 File Offset: 0x000202B0
		private void InitializeComponent()
		{
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new global::System.Windows.Forms.DataGridViewCellStyle();
			this.splitContainer1 = new global::System.Windows.Forms.SplitContainer();
			this.gPanelOthers = new global::DevComponents.DotNetBar.Controls.GroupPanel();
			this.layoutControl2 = new global::DevComponents.DotNetBar.Layout.LayoutControl();
			this.cmbAccountType = new global::Base.AutoComboBox();
			this.tInputValiSecondTime = new global::DevComponents.Editors.DateTimeAdv.DateTimeInput();
			this.btnCard = new global::DevComponents.DotNetBar.ButtonX();
			this.txtCardNum = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.btnDiBangValue = new global::DevComponents.DotNetBar.ButtonX();
			this.tInputValiFirstTime = new global::DevComponents.Editors.DateTimeAdv.DateTimeInput();
			this.layoutControlItem20 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem13 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem15 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem17 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem18 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem19 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.gPanelBatchSetup = new global::DevComponents.DotNetBar.Controls.GroupPanel();
			this.layoutControl = new global::DevComponents.DotNetBar.Layout.LayoutControl();
			this.cmbDanWei = new global::Base.AutoComboBox();
			this.dInputVol = new global::DevComponents.Editors.DoubleInput();
			this.cmbProduct = new global::Base.AutoComboBox();
			this.btnSure = new global::DevComponents.DotNetBar.ButtonX();
			this.iInputCount = new global::DevComponents.Editors.IntegerInput();
			this.cmbTruckTypeName = new global::Base.AutoComboBox();
			this.dInputNetWeight = new global::DevComponents.Editors.DoubleInput();
			this.layoutControlItem1 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem5 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem12 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem25 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem14 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem3 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem4 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.gPanelContract = new global::DevComponents.DotNetBar.Controls.GroupPanel();
			this.layoutControl1 = new global::DevComponents.DotNetBar.Layout.LayoutControl();
			this.txtProduct = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.cmbBusinessType = new global::Base.AutoComboBox();
			this.txtContractNum = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.cmbClientpart = new global::Base.AutoComboBox();
			this.cmbSettlepart = new global::Base.AutoComboBox();
			this.layoutControlItem11 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem7 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem16 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem9 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem10 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.dgvData = new global::DevComponents.DotNetBar.Controls.DataGridViewX();
			this.bar = new global::DevComponents.DotNetBar.Bar();
			this.btnSave = new global::DevComponents.DotNetBar.ButtonItem();
			this.btnPrint = new global::DevComponents.DotNetBar.ButtonItem();
			this.btnItemC = new global::DevComponents.DotNetBar.ButtonItem();
			this.layoutControlItem8 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem2 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem6 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.C_Id = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_DanHao = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_CheNum = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_CangNum = new global::DevComponents.DotNetBar.Controls.DataGridViewIntegerInputColumn();
			this.C_Product = new global::DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn();
			this.C_UnitName = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_Tank = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_DanWei = new global::DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn();
			this.C_NetWeight = new global::DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn();
			this.C_JiHuaLiang = new global::DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn();
			this.C_ShiJiLiang = new global::DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn();
			this.C_FirstWeight = new global::DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn();
			this.C_SinglePrice = new global::DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn();
			this.C_TotalPrice = new global::DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn();
			this.C_FirstTime = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_Loadometer = new global::DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn();
			((global::System.ComponentModel.ISupportInitialize)this.splitContainer1).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.gPanelOthers.SuspendLayout();
			this.layoutControl2.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.tInputValiSecondTime).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.tInputValiFirstTime).BeginInit();
			this.gPanelBatchSetup.SuspendLayout();
			this.layoutControl.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dInputVol).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.iInputCount).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.dInputNetWeight).BeginInit();
			this.gPanelContract.SuspendLayout();
			this.layoutControl1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvData).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.bar).BeginInit();
			base.SuspendLayout();
			this.splitContainer1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new global::System.Drawing.Point(0, 26);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = global::System.Windows.Forms.Orientation.Horizontal;
			this.splitContainer1.Panel1.Controls.Add(this.gPanelOthers);
			this.splitContainer1.Panel1.Controls.Add(this.gPanelBatchSetup);
			this.splitContainer1.Panel1.Controls.Add(this.gPanelContract);
			this.splitContainer1.Panel2.Controls.Add(this.dgvData);
			this.splitContainer1.Size = new global::System.Drawing.Size(1192, 486);
			this.splitContainer1.SplitterDistance = 168;
			this.splitContainer1.TabIndex = 17;
			this.gPanelOthers.BackColor = global::System.Drawing.Color.Transparent;
			this.gPanelOthers.CanvasColor = global::System.Drawing.SystemColors.Control;
			this.gPanelOthers.ColorSchemeStyle = global::DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
			this.gPanelOthers.Controls.Add(this.layoutControl2);
			this.gPanelOthers.DisabledBackColor = global::System.Drawing.Color.Empty;
			this.gPanelOthers.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.gPanelOthers.DrawTitleBox = false;
			this.gPanelOthers.Location = new global::System.Drawing.Point(656, 0);
			this.gPanelOthers.Name = "gPanelOthers";
			this.gPanelOthers.Size = new global::System.Drawing.Size(328, 168);
			this.gPanelOthers.Style.BackColor = global::System.Drawing.Color.Transparent;
			this.gPanelOthers.Style.BackColor2 = global::System.Drawing.Color.Transparent;
			this.gPanelOthers.Style.BackColorGradientAngle = 90;
			this.gPanelOthers.Style.BorderBottom = global::DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.gPanelOthers.Style.BorderBottomWidth = 1;
			this.gPanelOthers.Style.BorderColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
			this.gPanelOthers.Style.BorderLeft = global::DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.gPanelOthers.Style.BorderLeftWidth = 1;
			this.gPanelOthers.Style.BorderRight = global::DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.gPanelOthers.Style.BorderRightWidth = 1;
			this.gPanelOthers.Style.BorderTop = global::DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.gPanelOthers.Style.BorderTopWidth = 1;
			this.gPanelOthers.Style.CornerDiameter = 4;
			this.gPanelOthers.Style.CornerType = global::DevComponents.DotNetBar.eCornerType.Rounded;
			this.gPanelOthers.Style.TextColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelText;
			this.gPanelOthers.Style.TextLineAlignment = global::DevComponents.DotNetBar.eStyleTextAlignment.Near;
			this.gPanelOthers.StyleMouseDown.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.gPanelOthers.StyleMouseOver.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.gPanelOthers.TabIndex = 24;
			this.gPanelOthers.Text = "Others";
			this.layoutControl2.Controls.Add(this.cmbAccountType);
			this.layoutControl2.Controls.Add(this.tInputValiSecondTime);
			this.layoutControl2.Controls.Add(this.btnCard);
			this.layoutControl2.Controls.Add(this.txtCardNum);
			this.layoutControl2.Controls.Add(this.btnDiBangValue);
			this.layoutControl2.Controls.Add(this.tInputValiFirstTime);
			this.layoutControl2.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.layoutControl2.Location = new global::System.Drawing.Point(0, 0);
			this.layoutControl2.Name = "layoutControl2";
			this.layoutControl2.RootGroup.Items.AddRange(new global::DevComponents.DotNetBar.Layout.LayoutItemBase[]
			{
				this.layoutControlItem20,
				this.layoutControlItem13,
				this.layoutControlItem15,
				this.layoutControlItem17,
				this.layoutControlItem18,
				this.layoutControlItem19
			});
			this.layoutControl2.Size = new global::System.Drawing.Size(322, 146);
			this.layoutControl2.TabIndex = 21;
			this.cmbAccountType.DataSource = null;
			this.cmbAccountType.DisplayMember = null;
			this.cmbAccountType.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cmbAccountType.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbAccountType.FormattingEnabled = true;
			this.cmbAccountType.ItemHeight = 16;
			this.cmbAccountType.Location = new global::System.Drawing.Point(98, 93);
			this.cmbAccountType.Margin = new global::System.Windows.Forms.Padding(0);
			this.cmbAccountType.MaxDropDownItems = 20;
			this.cmbAccountType.Name = "cmbAccountType";
			this.cmbAccountType.SelectMember = null;
			this.cmbAccountType.Size = new global::System.Drawing.Size(123, 22);
			this.cmbAccountType.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.cmbAccountType.TabIndex = 4;
			this.cmbAccountType.ValueMember = null;
			this.tInputValiSecondTime.BackgroundStyle.Class = "DateTimeInputBackground";
			this.tInputValiSecondTime.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.tInputValiSecondTime.ButtonDropDown.Shortcut = global::DevComponents.DotNetBar.eShortcut.AltDown;
			this.tInputValiSecondTime.ButtonDropDown.Visible = true;
			this.tInputValiSecondTime.CustomFormat = "yyyy/MM/dd HH:mm:ss";
			this.tInputValiSecondTime.DateTimeSelectorVisibility = global::DevComponents.Editors.DateTimeAdv.eDateTimeSelectorVisibility.Both;
			this.tInputValiSecondTime.Format = global::DevComponents.Editors.eDateTimePickerFormat.Custom;
			this.tInputValiSecondTime.IsPopupCalendarOpen = false;
			this.tInputValiSecondTime.Location = new global::System.Drawing.Point(98, 33);
			this.tInputValiSecondTime.Margin = new global::System.Windows.Forms.Padding(0);
			this.tInputValiSecondTime.MonthCalendar.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.tInputValiSecondTime.MonthCalendar.CalendarDimensions = new global::System.Drawing.Size(1, 1);
			this.tInputValiSecondTime.MonthCalendar.ClearButtonVisible = true;
			this.tInputValiSecondTime.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = global::DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
			this.tInputValiSecondTime.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
			this.tInputValiSecondTime.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.BarBackground;
			this.tInputValiSecondTime.MonthCalendar.CommandsBackgroundStyle.BorderTop = global::DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.tInputValiSecondTime.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
			this.tInputValiSecondTime.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
			this.tInputValiSecondTime.MonthCalendar.CommandsBackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.tInputValiSecondTime.MonthCalendar.DayClickAutoClosePopup = false;
			this.tInputValiSecondTime.MonthCalendar.DisplayMonth = new global::System.DateTime(2019, 2, 1, 0, 0, 0, 0);
			this.tInputValiSecondTime.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
			this.tInputValiSecondTime.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
			this.tInputValiSecondTime.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
			this.tInputValiSecondTime.MonthCalendar.NavigationBackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.tInputValiSecondTime.MonthCalendar.TodayButtonVisible = true;
			this.tInputValiSecondTime.Name = "tInputValiSecondTime";
			this.tInputValiSecondTime.Size = new global::System.Drawing.Size(220, 21);
			this.tInputValiSecondTime.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.tInputValiSecondTime.TabIndex = 1;
			this.btnCard.AccessibleRole = global::System.Windows.Forms.AccessibleRole.PushButton;
			this.btnCard.ColorTable = global::DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.btnCard.Location = new global::System.Drawing.Point(229, 62);
			this.btnCard.Margin = new global::System.Windows.Forms.Padding(0);
			this.btnCard.Name = "btnCard";
			this.btnCard.Size = new global::System.Drawing.Size(89, 23);
			this.btnCard.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.btnCard.TabIndex = 3;
			this.btnCard.Text = "ReadCard";
			this.btnCard.Click += new global::System.EventHandler(this.btnCard_Click);
			this.txtCardNum.Border.Class = "TextBoxBorder";
			this.txtCardNum.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtCardNum.Location = new global::System.Drawing.Point(98, 62);
			this.txtCardNum.Margin = new global::System.Windows.Forms.Padding(0);
			this.txtCardNum.Name = "txtCardNum";
			this.txtCardNum.PreventEnterBeep = true;
			this.txtCardNum.Size = new global::System.Drawing.Size(123, 21);
			this.txtCardNum.TabIndex = 2;
			this.btnDiBangValue.AccessibleRole = global::System.Windows.Forms.AccessibleRole.PushButton;
			this.btnDiBangValue.ColorTable = global::DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.btnDiBangValue.Location = new global::System.Drawing.Point(229, 93);
			this.btnDiBangValue.Margin = new global::System.Windows.Forms.Padding(0);
			this.btnDiBangValue.Name = "btnDiBangValue";
			this.btnDiBangValue.Size = new global::System.Drawing.Size(89, 23);
			this.btnDiBangValue.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.btnDiBangValue.TabIndex = 5;
			this.btnDiBangValue.Text = "GetWbData";
			this.btnDiBangValue.Click += new global::System.EventHandler(this.btnDiBangValue_Click);
			this.tInputValiFirstTime.BackgroundStyle.Class = "DateTimeInputBackground";
			this.tInputValiFirstTime.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.tInputValiFirstTime.ButtonDropDown.Shortcut = global::DevComponents.DotNetBar.eShortcut.AltDown;
			this.tInputValiFirstTime.ButtonDropDown.Visible = true;
			this.tInputValiFirstTime.CustomFormat = "yyyy/MM/dd HH:mm:ss";
			this.tInputValiFirstTime.DateTimeSelectorVisibility = global::DevComponents.Editors.DateTimeAdv.eDateTimeSelectorVisibility.Both;
			this.tInputValiFirstTime.Format = global::DevComponents.Editors.eDateTimePickerFormat.Custom;
			this.tInputValiFirstTime.IsPopupCalendarOpen = false;
			this.tInputValiFirstTime.Location = new global::System.Drawing.Point(98, 4);
			this.tInputValiFirstTime.Margin = new global::System.Windows.Forms.Padding(0);
			this.tInputValiFirstTime.MonthCalendar.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.tInputValiFirstTime.MonthCalendar.CalendarDimensions = new global::System.Drawing.Size(1, 1);
			this.tInputValiFirstTime.MonthCalendar.ClearButtonVisible = true;
			this.tInputValiFirstTime.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = global::DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
			this.tInputValiFirstTime.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
			this.tInputValiFirstTime.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.BarBackground;
			this.tInputValiFirstTime.MonthCalendar.CommandsBackgroundStyle.BorderTop = global::DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.tInputValiFirstTime.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
			this.tInputValiFirstTime.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
			this.tInputValiFirstTime.MonthCalendar.CommandsBackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.tInputValiFirstTime.MonthCalendar.DayClickAutoClosePopup = false;
			this.tInputValiFirstTime.MonthCalendar.DisplayMonth = new global::System.DateTime(2019, 2, 1, 0, 0, 0, 0);
			this.tInputValiFirstTime.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
			this.tInputValiFirstTime.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
			this.tInputValiFirstTime.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
			this.tInputValiFirstTime.MonthCalendar.NavigationBackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.tInputValiFirstTime.MonthCalendar.TodayButtonVisible = true;
			this.tInputValiFirstTime.Name = "tInputValiFirstTime";
			this.tInputValiFirstTime.Size = new global::System.Drawing.Size(220, 21);
			this.tInputValiFirstTime.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.tInputValiFirstTime.TabIndex = 0;
			this.layoutControlItem20.Control = this.tInputValiFirstTime;
			this.layoutControlItem20.Height = 29;
			this.layoutControlItem20.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem20.Name = "layoutControlItem20";
			this.layoutControlItem20.Text = "*PlanStartDate";
			this.layoutControlItem20.Width = 100;
			this.layoutControlItem20.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem13.Control = this.tInputValiSecondTime;
			this.layoutControlItem13.Height = 29;
			this.layoutControlItem13.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem13.Name = "layoutControlItem13";
			this.layoutControlItem13.Text = "*PlanEndDate";
			this.layoutControlItem13.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem13.Width = 100;
			this.layoutControlItem13.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem15.Control = this.txtCardNum;
			this.layoutControlItem15.Height = 29;
			this.layoutControlItem15.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem15.Name = "layoutControlItem15";
			this.layoutControlItem15.Text = "IC";
			this.layoutControlItem15.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem15.Width = 70;
			this.layoutControlItem15.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem17.Control = this.btnCard;
			this.layoutControlItem17.Height = 31;
			this.layoutControlItem17.MinSize = new global::System.Drawing.Size(32, 20);
			this.layoutControlItem17.Name = "layoutControlItem17";
			this.layoutControlItem17.Width = 30;
			this.layoutControlItem17.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem18.Control = this.cmbAccountType;
			this.layoutControlItem18.Height = 28;
			this.layoutControlItem18.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem18.Name = "layoutControlItem18";
			this.layoutControlItem18.Text = "AccountType";
			this.layoutControlItem18.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem18.Width = 70;
			this.layoutControlItem18.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem19.Control = this.btnDiBangValue;
			this.layoutControlItem19.Height = 31;
			this.layoutControlItem19.MinSize = new global::System.Drawing.Size(32, 20);
			this.layoutControlItem19.Name = "layoutControlItem19";
			this.layoutControlItem19.Width = 30;
			this.layoutControlItem19.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.gPanelBatchSetup.BackColor = global::System.Drawing.Color.Transparent;
			this.gPanelBatchSetup.CanvasColor = global::System.Drawing.SystemColors.Control;
			this.gPanelBatchSetup.ColorSchemeStyle = global::DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
			this.gPanelBatchSetup.Controls.Add(this.layoutControl);
			this.gPanelBatchSetup.DisabledBackColor = global::System.Drawing.Color.Empty;
			this.gPanelBatchSetup.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.gPanelBatchSetup.DrawTitleBox = false;
			this.gPanelBatchSetup.Location = new global::System.Drawing.Point(328, 0);
			this.gPanelBatchSetup.Name = "gPanelBatchSetup";
			this.gPanelBatchSetup.Size = new global::System.Drawing.Size(328, 168);
			this.gPanelBatchSetup.Style.BackColor = global::System.Drawing.Color.Transparent;
			this.gPanelBatchSetup.Style.BackColor2 = global::System.Drawing.Color.Transparent;
			this.gPanelBatchSetup.Style.BackColorGradientAngle = 90;
			this.gPanelBatchSetup.Style.BorderBottom = global::DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.gPanelBatchSetup.Style.BorderBottomWidth = 1;
			this.gPanelBatchSetup.Style.BorderColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
			this.gPanelBatchSetup.Style.BorderLeft = global::DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.gPanelBatchSetup.Style.BorderLeftWidth = 1;
			this.gPanelBatchSetup.Style.BorderRight = global::DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.gPanelBatchSetup.Style.BorderRightWidth = 1;
			this.gPanelBatchSetup.Style.BorderTop = global::DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.gPanelBatchSetup.Style.BorderTopWidth = 1;
			this.gPanelBatchSetup.Style.CornerDiameter = 4;
			this.gPanelBatchSetup.Style.CornerType = global::DevComponents.DotNetBar.eCornerType.Rounded;
			this.gPanelBatchSetup.Style.TextColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelText;
			this.gPanelBatchSetup.Style.TextLineAlignment = global::DevComponents.DotNetBar.eStyleTextAlignment.Near;
			this.gPanelBatchSetup.StyleMouseDown.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.gPanelBatchSetup.StyleMouseOver.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.gPanelBatchSetup.TabIndex = 23;
			this.gPanelBatchSetup.Text = "BatchSetup";
			this.layoutControl.Controls.Add(this.cmbDanWei);
			this.layoutControl.Controls.Add(this.dInputVol);
			this.layoutControl.Controls.Add(this.cmbProduct);
			this.layoutControl.Controls.Add(this.btnSure);
			this.layoutControl.Controls.Add(this.iInputCount);
			this.layoutControl.Controls.Add(this.cmbTruckTypeName);
			this.layoutControl.Controls.Add(this.dInputNetWeight);
			this.layoutControl.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.layoutControl.Location = new global::System.Drawing.Point(0, 0);
			this.layoutControl.Name = "layoutControl";
			this.layoutControl.RootGroup.Items.AddRange(new global::DevComponents.DotNetBar.Layout.LayoutItemBase[]
			{
				this.layoutControlItem1,
				this.layoutControlItem5,
				this.layoutControlItem12,
				this.layoutControlItem25,
				this.layoutControlItem14,
				this.layoutControlItem3,
				this.layoutControlItem4
			});
			this.layoutControl.Size = new global::System.Drawing.Size(322, 146);
			this.layoutControl.TabIndex = 21;
			this.cmbDanWei.DataSource = null;
			this.cmbDanWei.DisplayMember = null;
			this.cmbDanWei.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cmbDanWei.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbDanWei.FormattingEnabled = true;
			this.cmbDanWei.ItemHeight = 16;
			this.cmbDanWei.Location = new global::System.Drawing.Point(92, 89);
			this.cmbDanWei.Margin = new global::System.Windows.Forms.Padding(0);
			this.cmbDanWei.MaxDropDownItems = 20;
			this.cmbDanWei.Name = "cmbDanWei";
			this.cmbDanWei.SelectMember = null;
			this.cmbDanWei.Size = new global::System.Drawing.Size(226, 22);
			this.cmbDanWei.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.cmbDanWei.TabIndex = 4;
			this.cmbDanWei.ValueMember = null;
			this.dInputVol.BackgroundStyle.Class = "DateTimeInputBackground";
			this.dInputVol.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.dInputVol.ButtonFreeText.Shortcut = global::DevComponents.DotNetBar.eShortcut.F2;
			this.dInputVol.Increment = 1.0;
			this.dInputVol.InputHorizontalAlignment = global::DevComponents.Editors.eHorizontalAlignment.Left;
			this.dInputVol.Location = new global::System.Drawing.Point(92, 60);
			this.dInputVol.Margin = new global::System.Windows.Forms.Padding(0);
			this.dInputVol.Name = "dInputVol";
			this.dInputVol.Size = new global::System.Drawing.Size(65, 21);
			this.dInputVol.TabIndex = 2;
			this.cmbProduct.DataSource = null;
			this.cmbProduct.DisplayMember = null;
			this.cmbProduct.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cmbProduct.FormattingEnabled = true;
			this.cmbProduct.ItemHeight = 15;
			this.cmbProduct.Location = new global::System.Drawing.Point(92, 32);
			this.cmbProduct.Margin = new global::System.Windows.Forms.Padding(0);
			this.cmbProduct.MaxDropDownItems = 20;
			this.cmbProduct.Name = "cmbProduct";
			this.cmbProduct.SelectMember = null;
			this.cmbProduct.Size = new global::System.Drawing.Size(226, 21);
			this.cmbProduct.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.cmbProduct.TabIndex = 1;
			this.cmbProduct.ValueMember = null;
			this.btnSure.AccessibleRole = global::System.Windows.Forms.AccessibleRole.PushButton;
			this.btnSure.ColorTable = global::DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.btnSure.Location = new global::System.Drawing.Point(261, 117);
			this.btnSure.Margin = new global::System.Windows.Forms.Padding(0);
			this.btnSure.Name = "btnSure";
			this.btnSure.Size = new global::System.Drawing.Size(57, 23);
			this.btnSure.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.btnSure.TabIndex = 6;
			this.btnSure.Text = "Yes";
			this.btnSure.Click += new global::System.EventHandler(this.btnSure_Click);
			this.iInputCount.BackgroundStyle.Class = "DateTimeInputBackground";
			this.iInputCount.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.iInputCount.ButtonFreeText.Shortcut = global::DevComponents.DotNetBar.eShortcut.F2;
			this.iInputCount.InputHorizontalAlignment = global::DevComponents.Editors.eHorizontalAlignment.Left;
			this.iInputCount.Location = new global::System.Drawing.Point(92, 117);
			this.iInputCount.Margin = new global::System.Windows.Forms.Padding(0);
			this.iInputCount.MinValue = 1;
			this.iInputCount.Name = "iInputCount";
			this.iInputCount.ShowUpDown = true;
			this.iInputCount.Size = new global::System.Drawing.Size(161, 21);
			this.iInputCount.TabIndex = 5;
			this.iInputCount.Value = 1;
			this.cmbTruckTypeName.DataSource = null;
			this.cmbTruckTypeName.DisplayMember = null;
			this.cmbTruckTypeName.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cmbTruckTypeName.FormattingEnabled = true;
			this.cmbTruckTypeName.ItemHeight = 15;
			this.cmbTruckTypeName.Location = new global::System.Drawing.Point(92, 4);
			this.cmbTruckTypeName.Margin = new global::System.Windows.Forms.Padding(0);
			this.cmbTruckTypeName.MaxDropDownItems = 20;
			this.cmbTruckTypeName.Name = "cmbTruckTypeName";
			this.cmbTruckTypeName.SelectMember = null;
			this.cmbTruckTypeName.Size = new global::System.Drawing.Size(226, 21);
			this.cmbTruckTypeName.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.cmbTruckTypeName.TabIndex = 0;
			this.cmbTruckTypeName.ValueMember = null;
			this.cmbTruckTypeName.TextChanged += new global::System.EventHandler(this.cmbTruckTypeName_TextChanged);
			this.dInputNetWeight.BackgroundStyle.Class = "DateTimeInputBackground";
			this.dInputNetWeight.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.dInputNetWeight.ButtonFreeText.Shortcut = global::DevComponents.DotNetBar.eShortcut.F2;
			this.dInputNetWeight.Increment = 1.0;
			this.dInputNetWeight.InputHorizontalAlignment = global::DevComponents.Editors.eHorizontalAlignment.Left;
			this.dInputNetWeight.Location = new global::System.Drawing.Point(253, 60);
			this.dInputNetWeight.Margin = new global::System.Windows.Forms.Padding(0);
			this.dInputNetWeight.MinValue = 0.0;
			this.dInputNetWeight.Name = "dInputNetWeight";
			this.dInputNetWeight.Size = new global::System.Drawing.Size(65, 21);
			this.dInputNetWeight.TabIndex = 3;
			this.layoutControlItem1.Control = this.cmbTruckTypeName;
			this.layoutControlItem1.Height = 28;
			this.layoutControlItem1.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Text = "CoachType";
			this.layoutControlItem1.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem1.Width = 100;
			this.layoutControlItem1.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem5.Control = this.cmbProduct;
			this.layoutControlItem5.Height = 28;
			this.layoutControlItem5.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem5.Name = "layoutControlItem5";
			this.layoutControlItem5.Text = "Product";
			this.layoutControlItem5.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem5.Width = 100;
			this.layoutControlItem5.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem12.Control = this.dInputVol;
			this.layoutControlItem12.Height = 29;
			this.layoutControlItem12.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem12.Name = "layoutControlItem12";
			this.layoutControlItem12.Text = "Vol(m³)";
			this.layoutControlItem12.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem12.Width = 50;
			this.layoutControlItem12.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem25.Control = this.dInputNetWeight;
			this.layoutControlItem25.Height = 29;
			this.layoutControlItem25.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem25.Name = "layoutControlItem25";
			this.layoutControlItem25.Text = "NetWeight(kg)";
			this.layoutControlItem25.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem25.Width = 50;
			this.layoutControlItem25.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem14.Control = this.cmbDanWei;
			this.layoutControlItem14.Height = 28;
			this.layoutControlItem14.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem14.Name = "layoutControlItem14";
			this.layoutControlItem14.Text = "DanWei";
			this.layoutControlItem14.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem14.Width = 100;
			this.layoutControlItem14.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem3.Control = this.iInputCount;
			this.layoutControlItem3.Height = 29;
			this.layoutControlItem3.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem3.Name = "layoutControlItem3";
			this.layoutControlItem3.Text = "BatchCount";
			this.layoutControlItem3.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem3.Width = 80;
			this.layoutControlItem3.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem4.Control = this.btnSure;
			this.layoutControlItem4.Height = 31;
			this.layoutControlItem4.MinSize = new global::System.Drawing.Size(32, 20);
			this.layoutControlItem4.Name = "layoutControlItem4";
			this.layoutControlItem4.Width = 20;
			this.layoutControlItem4.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.gPanelContract.BackColor = global::System.Drawing.Color.Transparent;
			this.gPanelContract.CanvasColor = global::System.Drawing.SystemColors.Control;
			this.gPanelContract.ColorSchemeStyle = global::DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
			this.gPanelContract.Controls.Add(this.layoutControl1);
			this.gPanelContract.DisabledBackColor = global::System.Drawing.Color.Empty;
			this.gPanelContract.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.gPanelContract.DrawTitleBox = false;
			this.gPanelContract.Location = new global::System.Drawing.Point(0, 0);
			this.gPanelContract.Name = "gPanelContract";
			this.gPanelContract.Size = new global::System.Drawing.Size(328, 168);
			this.gPanelContract.Style.BackColor = global::System.Drawing.Color.Transparent;
			this.gPanelContract.Style.BackColor2 = global::System.Drawing.Color.Transparent;
			this.gPanelContract.Style.BackColorGradientAngle = 90;
			this.gPanelContract.Style.BorderBottom = global::DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.gPanelContract.Style.BorderBottomWidth = 1;
			this.gPanelContract.Style.BorderColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
			this.gPanelContract.Style.BorderLeft = global::DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.gPanelContract.Style.BorderLeftWidth = 1;
			this.gPanelContract.Style.BorderRight = global::DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.gPanelContract.Style.BorderRightWidth = 1;
			this.gPanelContract.Style.BorderTop = global::DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.gPanelContract.Style.BorderTopWidth = 1;
			this.gPanelContract.Style.CornerDiameter = 4;
			this.gPanelContract.Style.CornerType = global::DevComponents.DotNetBar.eCornerType.Rounded;
			this.gPanelContract.Style.TextColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelText;
			this.gPanelContract.Style.TextLineAlignment = global::DevComponents.DotNetBar.eStyleTextAlignment.Near;
			this.gPanelContract.StyleMouseDown.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.gPanelContract.StyleMouseOver.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.gPanelContract.TabIndex = 22;
			this.gPanelContract.Text = "Contract";
			this.layoutControl1.Controls.Add(this.txtProduct);
			this.layoutControl1.Controls.Add(this.cmbBusinessType);
			this.layoutControl1.Controls.Add(this.txtContractNum);
			this.layoutControl1.Controls.Add(this.cmbClientpart);
			this.layoutControl1.Controls.Add(this.cmbSettlepart);
			this.layoutControl1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.layoutControl1.Location = new global::System.Drawing.Point(0, 0);
			this.layoutControl1.Name = "layoutControl1";
			this.layoutControl1.RootGroup.Items.AddRange(new global::DevComponents.DotNetBar.Layout.LayoutItemBase[]
			{
				this.layoutControlItem11,
				this.layoutControlItem7,
				this.layoutControlItem16,
				this.layoutControlItem9,
				this.layoutControlItem10
			});
			this.layoutControl1.Size = new global::System.Drawing.Size(322, 146);
			this.layoutControl1.TabIndex = 0;
			this.txtProduct.Border.Class = "TextBoxBorder";
			this.txtProduct.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtProduct.Enabled = false;
			this.txtProduct.Location = new global::System.Drawing.Point(92, 120);
			this.txtProduct.Margin = new global::System.Windows.Forms.Padding(0);
			this.txtProduct.Name = "txtProduct";
			this.txtProduct.PreventEnterBeep = true;
			this.txtProduct.Size = new global::System.Drawing.Size(226, 21);
			this.txtProduct.TabIndex = 4;
			this.cmbBusinessType.DataSource = null;
			this.cmbBusinessType.DisplayMember = null;
			this.cmbBusinessType.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cmbBusinessType.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbBusinessType.FormattingEnabled = true;
			this.cmbBusinessType.ItemHeight = 16;
			this.cmbBusinessType.Location = new global::System.Drawing.Point(92, 33);
			this.cmbBusinessType.Margin = new global::System.Windows.Forms.Padding(0);
			this.cmbBusinessType.MaxDropDownItems = 20;
			this.cmbBusinessType.Name = "cmbBusinessType";
			this.cmbBusinessType.SelectMember = null;
			this.cmbBusinessType.Size = new global::System.Drawing.Size(226, 22);
			this.cmbBusinessType.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.cmbBusinessType.TabIndex = 1;
			this.cmbBusinessType.ValueMember = null;
			this.txtContractNum.Border.Class = "TextBoxBorder";
			this.txtContractNum.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtContractNum.Location = new global::System.Drawing.Point(92, 4);
			this.txtContractNum.Margin = new global::System.Windows.Forms.Padding(0);
			this.txtContractNum.Name = "txtContractNum";
			this.txtContractNum.PreventEnterBeep = true;
			this.txtContractNum.Size = new global::System.Drawing.Size(226, 21);
			this.txtContractNum.TabIndex = 0;
			this.txtContractNum.TextChanged += new global::System.EventHandler(this.txtContractNum_TextChanged);
			this.cmbClientpart.DataSource = null;
			this.cmbClientpart.DisplayMember = null;
			this.cmbClientpart.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cmbClientpart.FormattingEnabled = true;
			this.cmbClientpart.ItemHeight = 15;
			this.cmbClientpart.Location = new global::System.Drawing.Point(92, 62);
			this.cmbClientpart.Margin = new global::System.Windows.Forms.Padding(0);
			this.cmbClientpart.MaxDropDownItems = 20;
			this.cmbClientpart.Name = "cmbClientpart";
			this.cmbClientpart.SelectMember = null;
			this.cmbClientpart.Size = new global::System.Drawing.Size(226, 21);
			this.cmbClientpart.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.cmbClientpart.TabIndex = 2;
			this.cmbClientpart.ValueMember = null;
			this.cmbSettlepart.DataSource = null;
			this.cmbSettlepart.DisplayMember = null;
			this.cmbSettlepart.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cmbSettlepart.FormattingEnabled = true;
			this.cmbSettlepart.ItemHeight = 15;
			this.cmbSettlepart.Location = new global::System.Drawing.Point(92, 91);
			this.cmbSettlepart.Margin = new global::System.Windows.Forms.Padding(0);
			this.cmbSettlepart.MaxDropDownItems = 20;
			this.cmbSettlepart.Name = "cmbSettlepart";
			this.cmbSettlepart.SelectMember = null;
			this.cmbSettlepart.Size = new global::System.Drawing.Size(226, 21);
			this.cmbSettlepart.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.cmbSettlepart.TabIndex = 3;
			this.cmbSettlepart.ValueMember = null;
			this.layoutControlItem11.Control = this.txtContractNum;
			this.layoutControlItem11.Height = 29;
			this.layoutControlItem11.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem11.Name = "layoutControlItem11";
			this.layoutControlItem11.Text = "ContractID";
			this.layoutControlItem11.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem11.Width = 100;
			this.layoutControlItem11.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem7.Control = this.cmbBusinessType;
			this.layoutControlItem7.Height = 29;
			this.layoutControlItem7.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem7.Name = "layoutControlItem7";
			this.layoutControlItem7.Text = "*BusinessType";
			this.layoutControlItem7.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem7.Width = 100;
			this.layoutControlItem7.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem16.Control = this.cmbClientpart;
			this.layoutControlItem16.Height = 29;
			this.layoutControlItem16.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem16.Name = "layoutControlItem16";
			this.layoutControlItem16.Text = "*Clientpart";
			this.layoutControlItem16.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem16.Width = 100;
			this.layoutControlItem16.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem9.Control = this.cmbSettlepart;
			this.layoutControlItem9.Height = 29;
			this.layoutControlItem9.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem9.Name = "layoutControlItem9";
			this.layoutControlItem9.Text = "*Settlepart";
			this.layoutControlItem9.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem9.Width = 100;
			this.layoutControlItem9.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem10.Control = this.txtProduct;
			this.layoutControlItem10.Height = 29;
			this.layoutControlItem10.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem10.Name = "layoutControlItem10";
			this.layoutControlItem10.Text = "Product";
			this.layoutControlItem10.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem10.Width = 100;
			this.layoutControlItem10.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.dgvData.AutoSizeColumnsMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvData.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvData.Columns.AddRange(new global::System.Windows.Forms.DataGridViewColumn[]
			{
				this.C_Id,
				this.C_DanHao,
				this.C_CheNum,
				this.C_CangNum,
				this.C_Product,
				this.C_UnitName,
				this.C_Tank,
				this.C_DanWei,
				this.C_NetWeight,
				this.C_JiHuaLiang,
				this.C_ShiJiLiang,
				this.C_FirstWeight,
				this.C_SinglePrice,
				this.C_TotalPrice,
				this.C_FirstTime,
				this.C_Loadometer
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
			this.dgvData.Location = new global::System.Drawing.Point(0, 0);
			this.dgvData.Name = "dgvData";
			this.dgvData.RowTemplate.Height = 23;
			this.dgvData.Size = new global::System.Drawing.Size(1192, 314);
			this.dgvData.TabIndex = 3;
			this.dgvData.CellEndEdit += new global::System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellEndEdit);
			this.dgvData.CellLeave += new global::System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellLeave);
			this.dgvData.EditingControlShowing += new global::System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvData_EditingControlShowing);
			this.dgvData.RowPostPaint += new global::System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvData_RowPostPaint);
			this.dgvData.RowsAdded += new global::System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvData_RowsAdded);
			this.bar.AccessibleDescription = "DotNetBar Bar (bar)";
			this.bar.AccessibleName = "DotNetBar Bar";
			this.bar.AccessibleRole = global::System.Windows.Forms.AccessibleRole.MenuBar;
			this.bar.BackColor = global::System.Drawing.Color.Transparent;
			this.bar.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.bar.Font = new global::System.Drawing.Font("微软雅黑", 9f);
			this.bar.IsMaximized = false;
			this.bar.Items.AddRange(new global::DevComponents.DotNetBar.BaseItem[]
			{
				this.btnSave,
				this.btnPrint,
				this.btnItemC
			});
			this.bar.Location = new global::System.Drawing.Point(0, 0);
			this.bar.MenuBar = true;
			this.bar.Name = "bar";
			this.bar.Size = new global::System.Drawing.Size(1192, 26);
			this.bar.Stretch = true;
			this.bar.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.bar.TabIndex = 16;
			this.bar.TabStop = false;
			this.bar.Text = "Main Menu";
			this.btnSave.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.btnSave.Image = global::SQSClient.Properties.Resources.save16;
			this.btnSave.Name = "btnSave";
			this.btnSave.Text = "Save";
			this.btnSave.Click += new global::System.EventHandler(this.btnSave_Click);
			this.btnPrint.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.btnPrint.Image = global::SQSClient.Properties.Resources.print16;
			this.btnPrint.Name = "btnPrint";
			this.btnPrint.Text = "Print";
			this.btnPrint.Click += new global::System.EventHandler(this.btnPrint_Click);
			this.btnItemC.ItemAlignment = global::DevComponents.DotNetBar.eItemAlignment.Far;
			this.btnItemC.Name = "btnItemC";
			this.btnItemC.Text = "ItemC";
			this.btnItemC.Click += new global::System.EventHandler(this.btnItemC_Click);
			this.layoutControlItem8.Name = "layoutControlItem8";
			this.layoutControlItem2.Name = "layoutControlItem2";
			this.layoutControlItem6.Name = "layoutControlItem6";
			this.C_Id.HeaderText = "ID";
			this.C_Id.Name = "C_Id";
			this.C_Id.Visible = false;
			this.C_DanHao.DataPropertyName = "DanHao";
			dataGridViewCellStyle2.BackColor = global::System.Drawing.Color.FromArgb(128, 255, 128);
			this.C_DanHao.DefaultCellStyle = dataGridViewCellStyle2;
			this.C_DanHao.HeaderText = "DanHao";
			this.C_DanHao.Name = "C_DanHao";
			this.C_CheNum.DataPropertyName = "Lisence";
			dataGridViewCellStyle3.BackColor = global::System.Drawing.Color.FromArgb(128, 255, 128);
			this.C_CheNum.DefaultCellStyle = dataGridViewCellStyle3;
			this.C_CheNum.HeaderText = "CheNum";
			this.C_CheNum.Name = "C_CheNum";
			this.C_CangNum.BackgroundStyle.BackColor = global::System.Drawing.Color.FromArgb(128, 255, 128);
			this.C_CangNum.BackgroundStyle.Class = "DataGridViewNumericBorder";
			this.C_CangNum.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.C_CangNum.BackgroundStyle.TextColor = global::System.Drawing.SystemColors.ControlText;
			this.C_CangNum.DataPropertyName = "CangNum";
			dataGridViewCellStyle4.BackColor = global::System.Drawing.Color.FromArgb(128, 255, 128);
			this.C_CangNum.DefaultCellStyle = dataGridViewCellStyle4;
			this.C_CangNum.HeaderText = "CangNum";
			this.C_CangNum.InputHorizontalAlignment = global::DevComponents.Editors.eHorizontalAlignment.Left;
			this.C_CangNum.MinValue = 1;
			this.C_CangNum.Name = "C_CangNum";
			this.C_CangNum.Resizable = global::System.Windows.Forms.DataGridViewTriState.True;
			this.C_Product.DataPropertyName = "ProductName";
			dataGridViewCellStyle5.BackColor = global::System.Drawing.Color.FromArgb(128, 255, 128);
			this.C_Product.DefaultCellStyle = dataGridViewCellStyle5;
			this.C_Product.DisplayMember = "Text";
			this.C_Product.DropDownHeight = 106;
			this.C_Product.DropDownWidth = 121;
			this.C_Product.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.C_Product.HeaderText = "Product";
			this.C_Product.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.C_Product.IntegralHeight = false;
			this.C_Product.ItemHeight = 16;
			this.C_Product.Name = "C_Product";
			this.C_Product.Resizable = global::System.Windows.Forms.DataGridViewTriState.True;
			this.C_Product.RightToLeft = global::System.Windows.Forms.RightToLeft.No;
			this.C_UnitName.DataPropertyName = "UnitName";
			dataGridViewCellStyle6.BackColor = global::System.Drawing.Color.FromArgb(128, 255, 128);
			this.C_UnitName.DefaultCellStyle = dataGridViewCellStyle6;
			this.C_UnitName.HeaderText = "Unit";
			this.C_UnitName.Name = "C_UnitName";
			dataGridViewCellStyle7.BackColor = global::System.Drawing.Color.FromArgb(128, 255, 128);
			this.C_Tank.DefaultCellStyle = dataGridViewCellStyle7;
			this.C_Tank.HeaderText = "Tank";
			this.C_Tank.Name = "C_Tank";
			this.C_DanWei.DataPropertyName = "DanWei";
			dataGridViewCellStyle8.BackColor = global::System.Drawing.Color.FromArgb(128, 255, 128);
			this.C_DanWei.DefaultCellStyle = dataGridViewCellStyle8;
			this.C_DanWei.DisplayMember = "Text";
			this.C_DanWei.DropDownHeight = 106;
			this.C_DanWei.DropDownWidth = 121;
			this.C_DanWei.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.C_DanWei.HeaderText = "DanWei";
			this.C_DanWei.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.C_DanWei.IntegralHeight = false;
			this.C_DanWei.ItemHeight = 16;
			this.C_DanWei.Name = "C_DanWei";
			this.C_DanWei.RightToLeft = global::System.Windows.Forms.RightToLeft.No;
			this.C_DanWei.Text = "Kg";
			this.C_NetWeight.BackgroundStyle.BackColor = global::System.Drawing.SystemColors.Window;
			this.C_NetWeight.BackgroundStyle.Class = "DataGridViewNumericBorder";
			this.C_NetWeight.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.C_NetWeight.BackgroundStyle.TextColor = global::System.Drawing.SystemColors.ControlText;
			this.C_NetWeight.DataPropertyName = "NetWeight";
			this.C_NetWeight.HeaderText = "NetWeight";
			this.C_NetWeight.Increment = 1.0;
			this.C_NetWeight.InputHorizontalAlignment = global::DevComponents.Editors.eHorizontalAlignment.Left;
			this.C_NetWeight.MinValue = 0.0;
			this.C_NetWeight.Name = "C_NetWeight";
			this.C_NetWeight.ReadOnly = true;
			this.C_JiHuaLiang.BackgroundStyle.BackColor = global::System.Drawing.Color.FromArgb(128, 255, 128);
			this.C_JiHuaLiang.BackgroundStyle.Class = "DataGridViewNumericBorder";
			this.C_JiHuaLiang.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.C_JiHuaLiang.BackgroundStyle.TextColor = global::System.Drawing.SystemColors.ControlText;
			this.C_JiHuaLiang.DataPropertyName = "JiHuaLiang";
			dataGridViewCellStyle9.BackColor = global::System.Drawing.Color.FromArgb(128, 255, 128);
			this.C_JiHuaLiang.DefaultCellStyle = dataGridViewCellStyle9;
			this.C_JiHuaLiang.HeaderText = "JiHuaLiang";
			this.C_JiHuaLiang.Increment = 1.0;
			this.C_JiHuaLiang.InputHorizontalAlignment = global::DevComponents.Editors.eHorizontalAlignment.Left;
			this.C_JiHuaLiang.MinValue = 0.0;
			this.C_JiHuaLiang.Name = "C_JiHuaLiang";
			this.C_JiHuaLiang.Resizable = global::System.Windows.Forms.DataGridViewTriState.True;
			this.C_ShiJiLiang.BackgroundStyle.BackColor = global::System.Drawing.SystemColors.Window;
			this.C_ShiJiLiang.BackgroundStyle.Class = "DataGridViewNumericBorder";
			this.C_ShiJiLiang.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.C_ShiJiLiang.BackgroundStyle.TextColor = global::System.Drawing.SystemColors.ControlText;
			this.C_ShiJiLiang.HeaderText = "ShiJiLiang";
			this.C_ShiJiLiang.Increment = 1.0;
			this.C_ShiJiLiang.InputHorizontalAlignment = global::DevComponents.Editors.eHorizontalAlignment.Left;
			this.C_ShiJiLiang.Name = "C_ShiJiLiang";
			this.C_ShiJiLiang.ReadOnly = true;
			this.C_FirstWeight.BackgroundStyle.BackColor = global::System.Drawing.SystemColors.Window;
			this.C_FirstWeight.BackgroundStyle.Class = "DataGridViewNumericBorder";
			this.C_FirstWeight.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.C_FirstWeight.BackgroundStyle.TextColor = global::System.Drawing.SystemColors.ControlText;
			this.C_FirstWeight.DataPropertyName = "FirstWeight";
			this.C_FirstWeight.HeaderText = "FirstWeight(kg)";
			this.C_FirstWeight.Increment = 1.0;
			this.C_FirstWeight.InputHorizontalAlignment = global::DevComponents.Editors.eHorizontalAlignment.Left;
			this.C_FirstWeight.Name = "C_FirstWeight";
			this.C_FirstWeight.ReadOnly = true;
			this.C_SinglePrice.BackgroundStyle.BackColor = global::System.Drawing.Color.FromArgb(128, 255, 128);
			this.C_SinglePrice.BackgroundStyle.Class = "DataGridViewNumericBorder";
			this.C_SinglePrice.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.C_SinglePrice.BackgroundStyle.TextColor = global::System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle10.BackColor = global::System.Drawing.Color.FromArgb(128, 255, 128);
			this.C_SinglePrice.DefaultCellStyle = dataGridViewCellStyle10;
			this.C_SinglePrice.HeaderText = "SinglePrice";
			this.C_SinglePrice.Increment = 1.0;
			this.C_SinglePrice.InputHorizontalAlignment = global::DevComponents.Editors.eHorizontalAlignment.Left;
			this.C_SinglePrice.Name = "C_SinglePrice";
			this.C_TotalPrice.BackgroundStyle.BackColor = global::System.Drawing.SystemColors.Window;
			this.C_TotalPrice.BackgroundStyle.Class = "DataGridViewNumericBorder";
			this.C_TotalPrice.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.C_TotalPrice.BackgroundStyle.TextColor = global::System.Drawing.SystemColors.ControlText;
			this.C_TotalPrice.HeaderText = "TotalPrice";
			this.C_TotalPrice.Increment = 1.0;
			this.C_TotalPrice.InputHorizontalAlignment = global::DevComponents.Editors.eHorizontalAlignment.Left;
			this.C_TotalPrice.Name = "C_TotalPrice";
			this.C_TotalPrice.ReadOnly = true;
			this.C_FirstTime.DataPropertyName = "FirstTime";
			this.C_FirstTime.HeaderText = "FirstTime";
			this.C_FirstTime.Name = "C_FirstTime";
			this.C_FirstTime.ReadOnly = true;
			this.C_Loadometer.DataPropertyName = "Loader";
			dataGridViewCellStyle11.BackColor = global::System.Drawing.Color.FromArgb(128, 255, 128);
			this.C_Loadometer.DefaultCellStyle = dataGridViewCellStyle11;
			this.C_Loadometer.DisplayMember = "Text";
			this.C_Loadometer.DropDownHeight = 106;
			this.C_Loadometer.DropDownWidth = 121;
			this.C_Loadometer.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.C_Loadometer.HeaderText = "Loadometer";
			this.C_Loadometer.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.C_Loadometer.IntegralHeight = false;
			this.C_Loadometer.ItemHeight = 16;
			this.C_Loadometer.Name = "C_Loadometer";
			this.C_Loadometer.RightToLeft = global::System.Windows.Forms.RightToLeft.No;
			base.ClientSize = new global::System.Drawing.Size(1192, 512);
			base.Controls.Add(this.splitContainer1);
			base.Controls.Add(this.bar);
			base.Name = "frmTicketEdit";
			this.Text = "TicketEdit";
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.frmReviseInfo_FormClosing);
			base.Load += new global::System.EventHandler(this.frmReviseInfo_Load);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.splitContainer1).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.gPanelOthers.ResumeLayout(false);
			this.layoutControl2.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.tInputValiSecondTime).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.tInputValiFirstTime).EndInit();
			this.gPanelBatchSetup.ResumeLayout(false);
			this.layoutControl.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.dInputVol).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.iInputCount).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.dInputNetWeight).EndInit();
			this.gPanelContract.ResumeLayout(false);
			this.layoutControl1.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.dgvData).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.bar).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x040001EE RID: 494
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x040001EF RID: 495
		private global::DevComponents.DotNetBar.Bar bar;

		// Token: 0x040001F0 RID: 496
		private global::DevComponents.DotNetBar.ButtonItem btnSave;

		// Token: 0x040001F1 RID: 497
		private global::DevComponents.DotNetBar.ButtonItem btnPrint;

		// Token: 0x040001F2 RID: 498
		private global::System.Windows.Forms.SplitContainer splitContainer1;

		// Token: 0x040001F3 RID: 499
		private global::DevComponents.DotNetBar.Layout.LayoutControl layoutControl;

		// Token: 0x040001F4 RID: 500
		private global::Base.AutoComboBox cmbSettlepart;

		// Token: 0x040001F5 RID: 501
		private global::Base.AutoComboBox cmbClientpart;

		// Token: 0x040001F6 RID: 502
		private global::DevComponents.Editors.DoubleInput dInputNetWeight;

		// Token: 0x040001F7 RID: 503
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem16;

		// Token: 0x040001F8 RID: 504
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem25;

		// Token: 0x040001F9 RID: 505
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem8;

		// Token: 0x040001FA RID: 506
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem2;

		// Token: 0x040001FB RID: 507
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem6;

		// Token: 0x040001FC RID: 508
		private global::Base.AutoComboBox cmbBusinessType;

		// Token: 0x040001FD RID: 509
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtContractNum;

		// Token: 0x040001FE RID: 510
		private global::Base.AutoComboBox cmbTruckTypeName;

		// Token: 0x040001FF RID: 511
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem1;

		// Token: 0x04000200 RID: 512
		private global::DevComponents.Editors.IntegerInput iInputCount;

		// Token: 0x04000201 RID: 513
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem3;

		// Token: 0x04000202 RID: 514
		private global::DevComponents.DotNetBar.ButtonX btnSure;

		// Token: 0x04000203 RID: 515
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem4;

		// Token: 0x04000204 RID: 516
		private global::DevComponents.DotNetBar.Controls.DataGridViewX dgvData;

		// Token: 0x04000205 RID: 517
		private global::Base.AutoComboBox cmbProduct;

		// Token: 0x04000206 RID: 518
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem5;

		// Token: 0x04000207 RID: 519
		private global::DevComponents.DotNetBar.Controls.GroupPanel gPanelContract;

		// Token: 0x04000208 RID: 520
		private global::DevComponents.DotNetBar.Layout.LayoutControl layoutControl1;

		// Token: 0x04000209 RID: 521
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem11;

		// Token: 0x0400020A RID: 522
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem7;

		// Token: 0x0400020B RID: 523
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem9;

		// Token: 0x0400020C RID: 524
		private global::DevComponents.DotNetBar.Controls.GroupPanel gPanelBatchSetup;

		// Token: 0x0400020D RID: 525
		private global::DevComponents.DotNetBar.Controls.GroupPanel gPanelOthers;

		// Token: 0x0400020E RID: 526
		private global::DevComponents.DotNetBar.Layout.LayoutControl layoutControl2;

		// Token: 0x0400020F RID: 527
		private global::DevComponents.Editors.DateTimeAdv.DateTimeInput tInputValiSecondTime;

		// Token: 0x04000210 RID: 528
		private global::DevComponents.DotNetBar.ButtonX btnCard;

		// Token: 0x04000211 RID: 529
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtCardNum;

		// Token: 0x04000212 RID: 530
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem13;

		// Token: 0x04000213 RID: 531
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem15;

		// Token: 0x04000214 RID: 532
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem17;

		// Token: 0x04000215 RID: 533
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtProduct;

		// Token: 0x04000216 RID: 534
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem10;

		// Token: 0x04000217 RID: 535
		private global::DevComponents.Editors.DoubleInput dInputVol;

		// Token: 0x04000218 RID: 536
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem12;

		// Token: 0x04000219 RID: 537
		private global::Base.AutoComboBox cmbDanWei;

		// Token: 0x0400021A RID: 538
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem14;

		// Token: 0x0400021B RID: 539
		private global::Base.AutoComboBox cmbAccountType;

		// Token: 0x0400021C RID: 540
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem18;

		// Token: 0x0400021D RID: 541
		private global::DevComponents.DotNetBar.ButtonX btnDiBangValue;

		// Token: 0x0400021E RID: 542
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem19;

		// Token: 0x0400021F RID: 543
		private global::DevComponents.DotNetBar.ButtonItem btnItemC;

		// Token: 0x04000220 RID: 544
		private global::DevComponents.Editors.DateTimeAdv.DateTimeInput tInputValiFirstTime;

		// Token: 0x04000221 RID: 545
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem20;

		// Token: 0x04000222 RID: 546
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_Id;

		// Token: 0x04000223 RID: 547
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_DanHao;

		// Token: 0x04000224 RID: 548
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_CheNum;

		// Token: 0x04000225 RID: 549
		private global::DevComponents.DotNetBar.Controls.DataGridViewIntegerInputColumn C_CangNum;

		// Token: 0x04000226 RID: 550
		private global::DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn C_Product;

		// Token: 0x04000227 RID: 551
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_UnitName;

		// Token: 0x04000228 RID: 552
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_Tank;

		// Token: 0x04000229 RID: 553
		private global::DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn C_DanWei;

		// Token: 0x0400022A RID: 554
		private global::DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn C_NetWeight;

		// Token: 0x0400022B RID: 555
		private global::DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn C_JiHuaLiang;

		// Token: 0x0400022C RID: 556
		private global::DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn C_ShiJiLiang;

		// Token: 0x0400022D RID: 557
		private global::DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn C_FirstWeight;

		// Token: 0x0400022E RID: 558
		private global::DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn C_SinglePrice;

		// Token: 0x0400022F RID: 559
		private global::DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn C_TotalPrice;

		// Token: 0x04000230 RID: 560
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_FirstTime;

		// Token: 0x04000231 RID: 561
		private global::DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn C_Loadometer;
	}
}
