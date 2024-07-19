namespace SQSClient
{
	// Token: 0x0200003B RID: 59
	public partial class frmICCardWR : global::SQSClient.BaseDialogForm
	{
		// Token: 0x060002BA RID: 698 RVA: 0x0004635C File Offset: 0x0004455C
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060002BB RID: 699 RVA: 0x00046394 File Offset: 0x00044594
		private void InitializeComponent()
		{
			this.panelEx1 = new global::DevComponents.DotNetBar.PanelEx();
			this.groupPanel2 = new global::DevComponents.DotNetBar.Controls.GroupPanel();
			this.rdoPart = new global::DevComponents.DotNetBar.Controls.CheckBoxX();
			this.rdoAll = new global::DevComponents.DotNetBar.Controls.CheckBoxX();
			this.labelX1 = new global::DevComponents.DotNetBar.LabelX();
			this.txtCardNum = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.txtUser = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.labelX2 = new global::DevComponents.DotNetBar.LabelX();
			this.chkLifeDate = new global::DevComponents.DotNetBar.Controls.CheckBoxX();
			this.intUseCount = new global::DevComponents.Editors.IntegerInput();
			this.datLifeDate = new global::DevComponents.Editors.DateTimeAdv.DateTimeInput();
			this.chkUseCount = new global::DevComponents.DotNetBar.Controls.CheckBoxX();
			this.groupProduct = new global::DevComponents.DotNetBar.Controls.GroupPanel();
			this.labelX5 = new global::DevComponents.DotNetBar.LabelX();
			this.labelX4 = new global::DevComponents.DotNetBar.LabelX();
			this.labelX3 = new global::DevComponents.DotNetBar.LabelX();
			this.labelX6 = new global::DevComponents.DotNetBar.LabelX();
			this.labelX7 = new global::DevComponents.DotNetBar.LabelX();
			this.btnWriteCard = new global::DevComponents.DotNetBar.ButtonX();
			this.btnReadCard = new global::DevComponents.DotNetBar.ButtonX();
			this.groupUnits = new global::DevComponents.DotNetBar.Controls.GroupPanel();
			this.listViewEx = new global::DevComponents.DotNetBar.Controls.ListViewEx();
			this.columnHeader1 = new global::System.Windows.Forms.ColumnHeader();
			this.panelEx2 = new global::DevComponents.DotNetBar.PanelEx();
			this.btnNoAll = new global::DevComponents.DotNetBar.ButtonX();
			this.btnAll = new global::DevComponents.DotNetBar.ButtonX();
			this.cmbProduct5 = new global::Base.AutoComboBox();
			this.cmbProduct4 = new global::Base.AutoComboBox();
			this.cmbProduct3 = new global::Base.AutoComboBox();
			this.cmbProduct2 = new global::Base.AutoComboBox();
			this.cmbProduct1 = new global::Base.AutoComboBox();
			this.panelEx1.SuspendLayout();
			this.groupPanel2.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.intUseCount).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.datLifeDate).BeginInit();
			this.groupProduct.SuspendLayout();
			this.groupUnits.SuspendLayout();
			this.panelEx2.SuspendLayout();
			base.SuspendLayout();
			this.panelEx1.CanvasColor = global::System.Drawing.SystemColors.Control;
			this.panelEx1.ColorSchemeStyle = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.panelEx1.Controls.Add(this.groupPanel2);
			this.panelEx1.Controls.Add(this.groupProduct);
			this.panelEx1.Controls.Add(this.btnWriteCard);
			this.panelEx1.Controls.Add(this.btnReadCard);
			this.panelEx1.DisabledBackColor = global::System.Drawing.Color.Empty;
			this.panelEx1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.panelEx1.Location = new global::System.Drawing.Point(0, 0);
			this.panelEx1.Name = "panelEx1";
			this.panelEx1.Size = new global::System.Drawing.Size(854, 173);
			this.panelEx1.Style.Alignment = global::System.Drawing.StringAlignment.Center;
			this.panelEx1.Style.BackColor1.Color = global::System.Drawing.Color.FromArgb(220, 231, 245);
			this.panelEx1.Style.BackColor2.ColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
			this.panelEx1.Style.Border = global::DevComponents.DotNetBar.eBorderType.SingleLine;
			this.panelEx1.Style.BorderColor.ColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
			this.panelEx1.Style.ForeColor.ColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelText;
			this.panelEx1.Style.GradientAngle = 90;
			this.panelEx1.TabIndex = 1;
			this.groupPanel2.BackColor = global::System.Drawing.Color.Transparent;
			this.groupPanel2.CanvasColor = global::System.Drawing.SystemColors.Control;
			this.groupPanel2.ColorSchemeStyle = global::DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
			this.groupPanel2.Controls.Add(this.rdoPart);
			this.groupPanel2.Controls.Add(this.rdoAll);
			this.groupPanel2.Controls.Add(this.labelX1);
			this.groupPanel2.Controls.Add(this.txtCardNum);
			this.groupPanel2.Controls.Add(this.txtUser);
			this.groupPanel2.Controls.Add(this.labelX2);
			this.groupPanel2.Controls.Add(this.chkLifeDate);
			this.groupPanel2.Controls.Add(this.intUseCount);
			this.groupPanel2.Controls.Add(this.datLifeDate);
			this.groupPanel2.Controls.Add(this.chkUseCount);
			this.groupPanel2.DisabledBackColor = global::System.Drawing.Color.Empty;
			this.groupPanel2.DrawTitleBox = false;
			this.groupPanel2.Location = new global::System.Drawing.Point(10, 6);
			this.groupPanel2.Name = "groupPanel2";
			this.groupPanel2.Size = new global::System.Drawing.Size(274, 158);
			this.groupPanel2.Style.BackColor = global::System.Drawing.Color.Transparent;
			this.groupPanel2.Style.BackColor2 = global::System.Drawing.Color.Transparent;
			this.groupPanel2.Style.BackColorGradientAngle = 90;
			this.groupPanel2.Style.BorderBottom = global::DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.groupPanel2.Style.BorderBottomWidth = 1;
			this.groupPanel2.Style.BorderColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
			this.groupPanel2.Style.BorderLeft = global::DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.groupPanel2.Style.BorderLeftWidth = 1;
			this.groupPanel2.Style.BorderRight = global::DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.groupPanel2.Style.BorderRightWidth = 1;
			this.groupPanel2.Style.BorderTop = global::DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.groupPanel2.Style.BorderTopWidth = 1;
			this.groupPanel2.Style.CornerDiameter = 4;
			this.groupPanel2.Style.CornerType = global::DevComponents.DotNetBar.eCornerType.Rounded;
			this.groupPanel2.Style.TextAlignment = global::DevComponents.DotNetBar.eStyleTextAlignment.Center;
			this.groupPanel2.Style.TextColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelText;
			this.groupPanel2.StyleMouseDown.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.groupPanel2.StyleMouseOver.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.groupPanel2.TabIndex = 60;
			this.groupPanel2.Text = "卡信息";
			this.rdoPart.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.rdoPart.CheckBoxStyle = global::DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
			this.rdoPart.Location = new global::System.Drawing.Point(162, 111);
			this.rdoPart.Name = "rdoPart";
			this.rdoPart.Size = new global::System.Drawing.Size(75, 23);
			this.rdoPart.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.rdoPart.TabIndex = 14;
			this.rdoPart.Text = "部分鹤位";
			this.rdoPart.CheckedChanged += new global::System.EventHandler(this.rdoPart_CheckedChanged);
			this.rdoAll.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.rdoAll.CheckBoxStyle = global::DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
			this.rdoAll.Location = new global::System.Drawing.Point(81, 111);
			this.rdoAll.Name = "rdoAll";
			this.rdoAll.Size = new global::System.Drawing.Size(75, 23);
			this.rdoAll.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.rdoAll.TabIndex = 13;
			this.rdoAll.Text = "所有鹤位";
			this.rdoAll.CheckedChanged += new global::System.EventHandler(this.rdoAll_CheckedChanged);
			this.labelX1.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.labelX1.Location = new global::System.Drawing.Point(16, 2);
			this.labelX1.Name = "labelX1";
			this.labelX1.Size = new global::System.Drawing.Size(59, 23);
			this.labelX1.TabIndex = 1;
			this.labelX1.Text = "卡    号";
			this.txtCardNum.Border.Class = "TextBoxBorder";
			this.txtCardNum.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtCardNum.Enabled = false;
			this.txtCardNum.Location = new global::System.Drawing.Point(81, 3);
			this.txtCardNum.Name = "txtCardNum";
			this.txtCardNum.PreventEnterBeep = true;
			this.txtCardNum.Size = new global::System.Drawing.Size(185, 21);
			this.txtCardNum.TabIndex = 0;
			this.txtUser.Border.Class = "TextBoxBorder";
			this.txtUser.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtUser.Location = new global::System.Drawing.Point(81, 31);
			this.txtUser.MaxLength = 5;
			this.txtUser.Name = "txtUser";
			this.txtUser.PreventEnterBeep = true;
			this.txtUser.Size = new global::System.Drawing.Size(185, 21);
			this.txtUser.TabIndex = 2;
			this.labelX2.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.labelX2.Location = new global::System.Drawing.Point(16, 29);
			this.labelX2.Name = "labelX2";
			this.labelX2.Size = new global::System.Drawing.Size(59, 23);
			this.labelX2.TabIndex = 3;
			this.labelX2.Text = "使 用 人";
			this.chkLifeDate.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.chkLifeDate.Location = new global::System.Drawing.Point(0, 83);
			this.chkLifeDate.Name = "chkLifeDate";
			this.chkLifeDate.Size = new global::System.Drawing.Size(75, 23);
			this.chkLifeDate.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.chkLifeDate.TabIndex = 12;
			this.chkLifeDate.Text = "有 效 期";
			this.chkLifeDate.CheckedChanged += new global::System.EventHandler(this.chkLifeDate_CheckedChanged);
			this.intUseCount.BackgroundStyle.Class = "DateTimeInputBackground";
			this.intUseCount.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.intUseCount.ButtonFreeText.Shortcut = global::DevComponents.DotNetBar.eShortcut.F2;
			this.intUseCount.Enabled = false;
			this.intUseCount.InputHorizontalAlignment = global::DevComponents.Editors.eHorizontalAlignment.Left;
			this.intUseCount.Location = new global::System.Drawing.Point(81, 57);
			this.intUseCount.MinValue = 0;
			this.intUseCount.Name = "intUseCount";
			this.intUseCount.ShowUpDown = true;
			this.intUseCount.Size = new global::System.Drawing.Size(185, 21);
			this.intUseCount.TabIndex = 4;
			this.datLifeDate.BackgroundStyle.Class = "DateTimeInputBackground";
			this.datLifeDate.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.datLifeDate.ButtonDropDown.Shortcut = global::DevComponents.DotNetBar.eShortcut.AltDown;
			this.datLifeDate.ButtonDropDown.Visible = true;
			this.datLifeDate.Enabled = false;
			this.datLifeDate.IsPopupCalendarOpen = false;
			this.datLifeDate.Location = new global::System.Drawing.Point(81, 84);
			this.datLifeDate.MonthCalendar.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.datLifeDate.MonthCalendar.CalendarDimensions = new global::System.Drawing.Size(1, 1);
			this.datLifeDate.MonthCalendar.ClearButtonVisible = true;
			this.datLifeDate.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = global::DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
			this.datLifeDate.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
			this.datLifeDate.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.BarBackground;
			this.datLifeDate.MonthCalendar.CommandsBackgroundStyle.BorderTop = global::DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.datLifeDate.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
			this.datLifeDate.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
			this.datLifeDate.MonthCalendar.CommandsBackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.datLifeDate.MonthCalendar.DisplayMonth = new global::System.DateTime(2018, 4, 1, 0, 0, 0, 0);
			this.datLifeDate.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
			this.datLifeDate.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
			this.datLifeDate.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
			this.datLifeDate.MonthCalendar.NavigationBackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.datLifeDate.MonthCalendar.TodayButtonVisible = true;
			this.datLifeDate.Name = "datLifeDate";
			this.datLifeDate.Size = new global::System.Drawing.Size(185, 21);
			this.datLifeDate.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.datLifeDate.TabIndex = 11;
			this.chkUseCount.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.chkUseCount.Location = new global::System.Drawing.Point(0, 56);
			this.chkUseCount.Name = "chkUseCount";
			this.chkUseCount.Size = new global::System.Drawing.Size(75, 23);
			this.chkUseCount.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.chkUseCount.TabIndex = 6;
			this.chkUseCount.Text = "有效次数";
			this.chkUseCount.CheckedChanged += new global::System.EventHandler(this.chkUseCount_CheckedChanged);
			this.groupProduct.BackColor = global::System.Drawing.Color.Transparent;
			this.groupProduct.CanvasColor = global::System.Drawing.SystemColors.Control;
			this.groupProduct.ColorSchemeStyle = global::DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
			this.groupProduct.Controls.Add(this.cmbProduct5);
			this.groupProduct.Controls.Add(this.cmbProduct4);
			this.groupProduct.Controls.Add(this.cmbProduct3);
			this.groupProduct.Controls.Add(this.cmbProduct2);
			this.groupProduct.Controls.Add(this.cmbProduct1);
			this.groupProduct.Controls.Add(this.labelX5);
			this.groupProduct.Controls.Add(this.labelX4);
			this.groupProduct.Controls.Add(this.labelX3);
			this.groupProduct.Controls.Add(this.labelX6);
			this.groupProduct.Controls.Add(this.labelX7);
			this.groupProduct.DisabledBackColor = global::System.Drawing.Color.Empty;
			this.groupProduct.DrawTitleBox = false;
			this.groupProduct.Location = new global::System.Drawing.Point(290, 6);
			this.groupProduct.Name = "groupProduct";
			this.groupProduct.Size = new global::System.Drawing.Size(274, 158);
			this.groupProduct.Style.BackColor = global::System.Drawing.Color.Transparent;
			this.groupProduct.Style.BackColor2 = global::System.Drawing.Color.Transparent;
			this.groupProduct.Style.BackColorGradientAngle = 90;
			this.groupProduct.Style.BorderBottom = global::DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.groupProduct.Style.BorderBottomWidth = 1;
			this.groupProduct.Style.BorderColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
			this.groupProduct.Style.BorderLeft = global::DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.groupProduct.Style.BorderLeftWidth = 1;
			this.groupProduct.Style.BorderRight = global::DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.groupProduct.Style.BorderRightWidth = 1;
			this.groupProduct.Style.BorderTop = global::DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.groupProduct.Style.BorderTopWidth = 1;
			this.groupProduct.Style.CornerDiameter = 4;
			this.groupProduct.Style.CornerType = global::DevComponents.DotNetBar.eCornerType.Rounded;
			this.groupProduct.Style.TextAlignment = global::DevComponents.DotNetBar.eStyleTextAlignment.Center;
			this.groupProduct.Style.TextColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelText;
			this.groupProduct.StyleMouseDown.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.groupProduct.StyleMouseOver.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.groupProduct.TabIndex = 59;
			this.groupProduct.Text = "物料表";
			this.labelX5.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.labelX5.Location = new global::System.Drawing.Point(18, 111);
			this.labelX5.Name = "labelX5";
			this.labelX5.Size = new global::System.Drawing.Size(60, 23);
			this.labelX5.TabIndex = 10;
			this.labelX5.Text = "序号5：";
			this.labelX4.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.labelX4.Location = new global::System.Drawing.Point(18, 84);
			this.labelX4.Name = "labelX4";
			this.labelX4.Size = new global::System.Drawing.Size(60, 23);
			this.labelX4.TabIndex = 8;
			this.labelX4.Text = "序号4：";
			this.labelX3.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.labelX3.Location = new global::System.Drawing.Point(18, 57);
			this.labelX3.Name = "labelX3";
			this.labelX3.Size = new global::System.Drawing.Size(60, 23);
			this.labelX3.TabIndex = 6;
			this.labelX3.Text = "序号3：";
			this.labelX6.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.labelX6.Location = new global::System.Drawing.Point(18, 30);
			this.labelX6.Name = "labelX6";
			this.labelX6.Size = new global::System.Drawing.Size(60, 23);
			this.labelX6.TabIndex = 4;
			this.labelX6.Text = "序号2：";
			this.labelX7.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.labelX7.Location = new global::System.Drawing.Point(18, 3);
			this.labelX7.Name = "labelX7";
			this.labelX7.Size = new global::System.Drawing.Size(60, 23);
			this.labelX7.TabIndex = 2;
			this.labelX7.Text = "序号1：";
			this.btnWriteCard.AccessibleRole = global::System.Windows.Forms.AccessibleRole.PushButton;
			this.btnWriteCard.ColorTable = global::DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.btnWriteCard.Location = new global::System.Drawing.Point(601, 110);
			this.btnWriteCard.Name = "btnWriteCard";
			this.btnWriteCard.Size = new global::System.Drawing.Size(75, 23);
			this.btnWriteCard.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.btnWriteCard.TabIndex = 14;
			this.btnWriteCard.Text = "写卡";
			this.btnWriteCard.Click += new global::System.EventHandler(this.btnWriteCard_Click);
			this.btnReadCard.AccessibleRole = global::System.Windows.Forms.AccessibleRole.PushButton;
			this.btnReadCard.ColorTable = global::DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.btnReadCard.Location = new global::System.Drawing.Point(601, 30);
			this.btnReadCard.Name = "btnReadCard";
			this.btnReadCard.Size = new global::System.Drawing.Size(75, 23);
			this.btnReadCard.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.btnReadCard.TabIndex = 13;
			this.btnReadCard.Text = "读卡";
			this.btnReadCard.Click += new global::System.EventHandler(this.btnReadCard_Click);
			this.groupUnits.BackColor = global::System.Drawing.Color.Transparent;
			this.groupUnits.CanvasColor = global::System.Drawing.SystemColors.Control;
			this.groupUnits.ColorSchemeStyle = global::DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
			this.groupUnits.Controls.Add(this.listViewEx);
			this.groupUnits.Controls.Add(this.panelEx2);
			this.groupUnits.DisabledBackColor = global::System.Drawing.Color.Empty;
			this.groupUnits.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.groupUnits.DrawTitleBox = false;
			this.groupUnits.Location = new global::System.Drawing.Point(0, 173);
			this.groupUnits.Name = "groupUnits";
			this.groupUnits.Size = new global::System.Drawing.Size(854, 433);
			this.groupUnits.Style.BackColor = global::System.Drawing.Color.Transparent;
			this.groupUnits.Style.BackColor2 = global::System.Drawing.Color.Transparent;
			this.groupUnits.Style.BackColorGradientAngle = 90;
			this.groupUnits.Style.BorderBottom = global::DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.groupUnits.Style.BorderBottomWidth = 1;
			this.groupUnits.Style.BorderColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
			this.groupUnits.Style.BorderLeft = global::DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.groupUnits.Style.BorderLeftWidth = 1;
			this.groupUnits.Style.BorderRight = global::DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.groupUnits.Style.BorderRightWidth = 1;
			this.groupUnits.Style.BorderTop = global::DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.groupUnits.Style.BorderTopWidth = 1;
			this.groupUnits.Style.CornerDiameter = 4;
			this.groupUnits.Style.CornerType = global::DevComponents.DotNetBar.eCornerType.Rounded;
			this.groupUnits.Style.TextAlignment = global::DevComponents.DotNetBar.eStyleTextAlignment.Center;
			this.groupUnits.Style.TextColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelText;
			this.groupUnits.StyleMouseDown.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.groupUnits.StyleMouseOver.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.groupUnits.TabIndex = 6;
			this.groupUnits.Text = "授权鹤位选择";
			this.listViewEx.Border.Class = "ListViewBorder";
			this.listViewEx.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.listViewEx.CheckBoxes = true;
			this.listViewEx.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.columnHeader1
			});
			this.listViewEx.DisabledBackColor = global::System.Drawing.Color.Empty;
			this.listViewEx.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.listViewEx.LabelWrap = false;
			this.listViewEx.Location = new global::System.Drawing.Point(0, 36);
			this.listViewEx.Name = "listViewEx";
			this.listViewEx.Size = new global::System.Drawing.Size(848, 373);
			this.listViewEx.TabIndex = 17;
			this.listViewEx.UseCompatibleStateImageBehavior = false;
			this.listViewEx.View = global::System.Windows.Forms.View.SmallIcon;
			this.panelEx2.CanvasColor = global::System.Drawing.SystemColors.Control;
			this.panelEx2.ColorSchemeStyle = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.panelEx2.Controls.Add(this.btnNoAll);
			this.panelEx2.Controls.Add(this.btnAll);
			this.panelEx2.DisabledBackColor = global::System.Drawing.Color.Empty;
			this.panelEx2.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.panelEx2.Location = new global::System.Drawing.Point(0, 0);
			this.panelEx2.Name = "panelEx2";
			this.panelEx2.Size = new global::System.Drawing.Size(848, 36);
			this.panelEx2.Style.Alignment = global::System.Drawing.StringAlignment.Center;
			this.panelEx2.Style.BackColor1.Color = global::System.Drawing.Color.Transparent;
			this.panelEx2.Style.BackColor2.Color = global::System.Drawing.Color.Transparent;
			this.panelEx2.Style.BorderColor.ColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
			this.panelEx2.Style.ForeColor.ColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelText;
			this.panelEx2.Style.GradientAngle = 90;
			this.panelEx2.TabIndex = 13;
			this.btnNoAll.AccessibleRole = global::System.Windows.Forms.AccessibleRole.PushButton;
			this.btnNoAll.ColorTable = global::DevComponents.DotNetBar.eButtonColor.Orange;
			this.btnNoAll.Location = new global::System.Drawing.Point(60, 7);
			this.btnNoAll.Name = "btnNoAll";
			this.btnNoAll.Size = new global::System.Drawing.Size(50, 23);
			this.btnNoAll.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.btnNoAll.TabIndex = 9;
			this.btnNoAll.Text = "全不选";
			this.btnNoAll.Click += new global::System.EventHandler(this.btnNoAll_Click);
			this.btnAll.AccessibleRole = global::System.Windows.Forms.AccessibleRole.PushButton;
			this.btnAll.ColorTable = global::DevComponents.DotNetBar.eButtonColor.Orange;
			this.btnAll.Location = new global::System.Drawing.Point(10, 7);
			this.btnAll.Name = "btnAll";
			this.btnAll.Size = new global::System.Drawing.Size(50, 23);
			this.btnAll.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.btnAll.TabIndex = 8;
			this.btnAll.Text = "全选";
			this.btnAll.Click += new global::System.EventHandler(this.btnAll_Click);
			this.cmbProduct5.DataSource = null;
			this.cmbProduct5.DisplayMember = null;
			this.cmbProduct5.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cmbProduct5.FormattingEnabled = true;
			this.cmbProduct5.ItemHeight = 15;
			this.cmbProduct5.Location = new global::System.Drawing.Point(74, 111);
			this.cmbProduct5.Name = "cmbProduct5";
			this.cmbProduct5.SelectedValue = "";
			this.cmbProduct5.SelectMember = null;
			this.cmbProduct5.Size = new global::System.Drawing.Size(185, 21);
			this.cmbProduct5.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.cmbProduct5.TabIndex = 15;
			this.cmbProduct5.ValueMember = null;
			this.cmbProduct4.DataSource = null;
			this.cmbProduct4.DisplayMember = null;
			this.cmbProduct4.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cmbProduct4.FormattingEnabled = true;
			this.cmbProduct4.ItemHeight = 15;
			this.cmbProduct4.Location = new global::System.Drawing.Point(74, 84);
			this.cmbProduct4.Name = "cmbProduct4";
			this.cmbProduct4.SelectedValue = "";
			this.cmbProduct4.SelectMember = null;
			this.cmbProduct4.Size = new global::System.Drawing.Size(185, 21);
			this.cmbProduct4.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.cmbProduct4.TabIndex = 14;
			this.cmbProduct4.ValueMember = null;
			this.cmbProduct3.DataSource = null;
			this.cmbProduct3.DisplayMember = null;
			this.cmbProduct3.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cmbProduct3.FormattingEnabled = true;
			this.cmbProduct3.ItemHeight = 15;
			this.cmbProduct3.Location = new global::System.Drawing.Point(74, 57);
			this.cmbProduct3.Name = "cmbProduct3";
			this.cmbProduct3.SelectedValue = "";
			this.cmbProduct3.SelectMember = null;
			this.cmbProduct3.Size = new global::System.Drawing.Size(185, 21);
			this.cmbProduct3.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.cmbProduct3.TabIndex = 13;
			this.cmbProduct3.ValueMember = null;
			this.cmbProduct2.DataSource = null;
			this.cmbProduct2.DisplayMember = null;
			this.cmbProduct2.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cmbProduct2.FormattingEnabled = true;
			this.cmbProduct2.ItemHeight = 15;
			this.cmbProduct2.Location = new global::System.Drawing.Point(74, 30);
			this.cmbProduct2.Name = "cmbProduct2";
			this.cmbProduct2.SelectedValue = "";
			this.cmbProduct2.SelectMember = null;
			this.cmbProduct2.Size = new global::System.Drawing.Size(185, 21);
			this.cmbProduct2.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.cmbProduct2.TabIndex = 12;
			this.cmbProduct2.ValueMember = null;
			this.cmbProduct1.DataSource = null;
			this.cmbProduct1.DisplayMember = null;
			this.cmbProduct1.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cmbProduct1.FormattingEnabled = true;
			this.cmbProduct1.ItemHeight = 15;
			this.cmbProduct1.Location = new global::System.Drawing.Point(74, 3);
			this.cmbProduct1.Name = "cmbProduct1";
			this.cmbProduct1.SelectedValue = "";
			this.cmbProduct1.SelectMember = null;
			this.cmbProduct1.Size = new global::System.Drawing.Size(185, 21);
			this.cmbProduct1.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.cmbProduct1.TabIndex = 11;
			this.cmbProduct1.ValueMember = null;
			base.ClientSize = new global::System.Drawing.Size(854, 606);
			base.Controls.Add(this.groupUnits);
			base.Controls.Add(this.panelEx1);
			this.DoubleBuffered = true;
			base.Name = "frmICCard";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "IC卡制卡";
			base.Load += new global::System.EventHandler(this.frmICCard_Load);
			this.panelEx1.ResumeLayout(false);
			this.groupPanel2.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.intUseCount).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.datLifeDate).EndInit();
			this.groupProduct.ResumeLayout(false);
			this.groupUnits.ResumeLayout(false);
			this.panelEx2.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x0400045A RID: 1114
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400045B RID: 1115
		private global::DevComponents.DotNetBar.PanelEx panelEx1;

		// Token: 0x0400045C RID: 1116
		private global::DevComponents.DotNetBar.Controls.CheckBoxX chkLifeDate;

		// Token: 0x0400045D RID: 1117
		private global::DevComponents.Editors.DateTimeAdv.DateTimeInput datLifeDate;

		// Token: 0x0400045E RID: 1118
		private global::DevComponents.DotNetBar.Controls.CheckBoxX chkUseCount;

		// Token: 0x0400045F RID: 1119
		private global::DevComponents.Editors.IntegerInput intUseCount;

		// Token: 0x04000460 RID: 1120
		private global::DevComponents.DotNetBar.LabelX labelX2;

		// Token: 0x04000461 RID: 1121
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtUser;

		// Token: 0x04000462 RID: 1122
		private global::DevComponents.DotNetBar.LabelX labelX1;

		// Token: 0x04000463 RID: 1123
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtCardNum;

		// Token: 0x04000464 RID: 1124
		private global::DevComponents.DotNetBar.Controls.GroupPanel groupUnits;

		// Token: 0x04000465 RID: 1125
		private global::DevComponents.DotNetBar.PanelEx panelEx2;

		// Token: 0x04000466 RID: 1126
		private global::DevComponents.DotNetBar.Controls.ListViewEx listViewEx;

		// Token: 0x04000467 RID: 1127
		private global::System.Windows.Forms.ColumnHeader columnHeader1;

		// Token: 0x04000468 RID: 1128
		private global::DevComponents.DotNetBar.ButtonX btnWriteCard;

		// Token: 0x04000469 RID: 1129
		private global::DevComponents.DotNetBar.ButtonX btnReadCard;

		// Token: 0x0400046A RID: 1130
		private global::DevComponents.DotNetBar.Controls.GroupPanel groupProduct;

		// Token: 0x0400046B RID: 1131
		private global::DevComponents.DotNetBar.LabelX labelX5;

		// Token: 0x0400046C RID: 1132
		private global::DevComponents.DotNetBar.LabelX labelX4;

		// Token: 0x0400046D RID: 1133
		private global::DevComponents.DotNetBar.LabelX labelX3;

		// Token: 0x0400046E RID: 1134
		private global::DevComponents.DotNetBar.LabelX labelX6;

		// Token: 0x0400046F RID: 1135
		private global::DevComponents.DotNetBar.LabelX labelX7;

		// Token: 0x04000470 RID: 1136
		private global::Base.AutoComboBox cmbProduct5;

		// Token: 0x04000471 RID: 1137
		private global::Base.AutoComboBox cmbProduct4;

		// Token: 0x04000472 RID: 1138
		private global::Base.AutoComboBox cmbProduct3;

		// Token: 0x04000473 RID: 1139
		private global::Base.AutoComboBox cmbProduct2;

		// Token: 0x04000474 RID: 1140
		private global::Base.AutoComboBox cmbProduct1;

		// Token: 0x04000475 RID: 1141
		private global::DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;

		// Token: 0x04000476 RID: 1142
		private global::DevComponents.DotNetBar.ButtonX btnAll;

		// Token: 0x04000477 RID: 1143
		private global::DevComponents.DotNetBar.ButtonX btnNoAll;

		// Token: 0x04000478 RID: 1144
		private global::DevComponents.DotNetBar.Controls.CheckBoxX rdoPart;

		// Token: 0x04000479 RID: 1145
		private global::DevComponents.DotNetBar.Controls.CheckBoxX rdoAll;
	}
}
