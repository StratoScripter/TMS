namespace SQSClient
{
	// Token: 0x0200006C RID: 108
	public partial class frmTicketNFastAdd : global::SQSClient.BaseDialogForm
	{
		// Token: 0x0600057B RID: 1403 RVA: 0x0008AF50 File Offset: 0x00089150
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600057C RID: 1404 RVA: 0x0008AF88 File Offset: 0x00089188
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::SQSClient.frmTicketNFastAdd));
			this.rtbRemark = new global::DevComponents.DotNetBar.Controls.RichTextBoxEx();
			this.bar1 = new global::DevComponents.DotNetBar.Bar();
			this.btnSave = new global::DevComponents.DotNetBar.ButtonItem();
			this.groupPanel4 = new global::DevComponents.DotNetBar.Controls.GroupPanel();
			this.layCoach = new global::DevComponents.DotNetBar.Layout.LayoutControl();
			this.txtLTransportCode = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.txtLisence = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.tInputValidDate = new global::DevComponents.Editors.DateTimeAdv.DateTimeInput();
			this.cmbCreditType = new global::Base.AutoComboBox();
			this.layoutControlItem5 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem18 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem39 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem27 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem14 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem24 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.gPanelContract = new global::DevComponents.DotNetBar.Controls.GroupPanel();
			this.layoutControl1 = new global::DevComponents.DotNetBar.Layout.LayoutControl();
			this.cmbBusinessType = new global::Base.AutoComboBox();
			this.txtContractNum = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.cmbClientpart = new global::Base.AutoComboBox();
			this.cmbSettlepart = new global::Base.AutoComboBox();
			this.cmbProduct = new global::Base.AutoComboBox();
			this.txtCardNum = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.btnCard = new global::DevComponents.DotNetBar.ButtonX();
			this.cmbAccountType = new global::Base.AutoComboBox();
			this.btnDiBangValue = new global::DevComponents.DotNetBar.ButtonX();
			this.dInputJiHuaLiang = new global::DevComponents.Editors.DoubleInput();
			this.layoutControlItem11 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem7 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem16 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem9 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem10 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem12 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem20 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem21 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem3 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem23 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem1 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem2 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem6 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem17 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem13 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem19 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem22 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem15 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.rdoCornCart = new global::DevComponents.DotNetBar.Controls.CheckBoxX();
			this.rdoCornTrolley = new global::DevComponents.DotNetBar.Controls.CheckBoxX();
			this.layoutControlItem4 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem8 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			((global::System.ComponentModel.ISupportInitialize)this.bar1).BeginInit();
			this.groupPanel4.SuspendLayout();
			this.layCoach.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.tInputValidDate).BeginInit();
			this.gPanelContract.SuspendLayout();
			this.layoutControl1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dInputJiHuaLiang).BeginInit();
			base.SuspendLayout();
			this.rtbRemark.BackgroundStyle.Class = "RichTextBoxBorder";
			this.rtbRemark.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.rtbRemark.Location = new global::System.Drawing.Point(98, 62);
			this.rtbRemark.Margin = new global::System.Windows.Forms.Padding(0);
			this.rtbRemark.MaxLength = 200;
			this.rtbRemark.Name = "rtbRemark";
			this.rtbRemark.Rtf = "{\\rtf1\\ansi\\ansicpg936\\deff0\\nouicompat\\deflang1033\\deflangfe2052{\\fonttbl{\\f0\\fnil\\fcharset134 \\'cb\\'ce\\'cc\\'e5;}}\r\n{\\*\\generator Riched20 10.0.18362}\\viewkind4\\uc1 \r\n\\pard\\f0\\fs18\\lang2052\\par\r\n}\r\n";
			this.rtbRemark.Size = new global::System.Drawing.Size(452, 36);
			this.rtbRemark.TabIndex = 4;
			this.bar1.AccessibleDescription = "DotNetBar Bar (bar1)";
			this.bar1.AccessibleName = "DotNetBar Bar";
			this.bar1.AccessibleRole = global::System.Windows.Forms.AccessibleRole.MenuBar;
			this.bar1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.bar1.Font = new global::System.Drawing.Font("微软雅黑", 9f);
			this.bar1.IsMaximized = false;
			this.bar1.Items.AddRange(new global::DevComponents.DotNetBar.BaseItem[]
			{
				this.btnSave
			});
			this.bar1.Location = new global::System.Drawing.Point(0, 0);
			this.bar1.MenuBar = true;
			this.bar1.Name = "bar1";
			this.bar1.Size = new global::System.Drawing.Size(560, 26);
			this.bar1.Stretch = true;
			this.bar1.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.Windows7;
			this.bar1.TabIndex = 15;
			this.bar1.TabStop = false;
			this.bar1.Text = "bar1";
			this.btnSave.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.btnSave.Image = global::SQSClient.Properties.Resources.save16;
			this.btnSave.Name = "btnSave";
			this.btnSave.Text = "Save";
			this.btnSave.Click += new global::System.EventHandler(this.btnSave_Click);
			this.groupPanel4.BackColor = global::System.Drawing.Color.Transparent;
			this.groupPanel4.CanvasColor = global::System.Drawing.SystemColors.Control;
			this.groupPanel4.ColorSchemeStyle = global::DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
			this.groupPanel4.Controls.Add(this.layCoach);
			this.groupPanel4.DisabledBackColor = global::System.Drawing.Color.Empty;
			this.groupPanel4.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.groupPanel4.DrawTitleBox = false;
			this.groupPanel4.Location = new global::System.Drawing.Point(0, 26);
			this.groupPanel4.Margin = new global::System.Windows.Forms.Padding(0);
			this.groupPanel4.Name = "groupPanel4";
			this.groupPanel4.Size = new global::System.Drawing.Size(560, 139);
			this.groupPanel4.Style.BackColor = global::System.Drawing.Color.Transparent;
			this.groupPanel4.Style.BackColor2 = global::System.Drawing.Color.Transparent;
			this.groupPanel4.Style.BackColorGradientAngle = 90;
			this.groupPanel4.Style.BorderBottom = global::DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.groupPanel4.Style.BorderBottomWidth = 1;
			this.groupPanel4.Style.BorderColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
			this.groupPanel4.Style.BorderLeft = global::DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.groupPanel4.Style.BorderLeftWidth = 1;
			this.groupPanel4.Style.BorderRight = global::DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.groupPanel4.Style.BorderRightWidth = 1;
			this.groupPanel4.Style.BorderTop = global::DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.groupPanel4.Style.BorderTopWidth = 1;
			this.groupPanel4.Style.CornerDiameter = 4;
			this.groupPanel4.Style.CornerType = global::DevComponents.DotNetBar.eCornerType.Rounded;
			this.groupPanel4.Style.TextColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelText;
			this.groupPanel4.Style.TextLineAlignment = global::DevComponents.DotNetBar.eStyleTextAlignment.Near;
			this.groupPanel4.StyleMouseDown.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.groupPanel4.StyleMouseOver.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.groupPanel4.TabIndex = 12;
			this.groupPanel4.Text = "Truck";
			this.layCoach.Controls.Add(this.txtLTransportCode);
			this.layCoach.Controls.Add(this.txtLisence);
			this.layCoach.Controls.Add(this.tInputValidDate);
			this.layCoach.Controls.Add(this.rtbRemark);
			this.layCoach.Controls.Add(this.cmbCreditType);
			this.layCoach.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.layCoach.Location = new global::System.Drawing.Point(0, 0);
			this.layCoach.Name = "layCoach";
			this.layCoach.RootGroup.Items.AddRange(new global::DevComponents.DotNetBar.Layout.LayoutItemBase[]
			{
				this.layoutControlItem5,
				this.layoutControlItem18,
				this.layoutControlItem39,
				this.layoutControlItem27,
				this.layoutControlItem14
			});
			this.layCoach.Size = new global::System.Drawing.Size(554, 117);
			this.layCoach.TabIndex = 0;
			this.txtLTransportCode.Border.Class = "TextBoxBorder";
			this.txtLTransportCode.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtLTransportCode.Location = new global::System.Drawing.Point(375, 4);
			this.txtLTransportCode.Margin = new global::System.Windows.Forms.Padding(0);
			this.txtLTransportCode.Name = "txtLTransportCode";
			this.txtLTransportCode.PreventEnterBeep = true;
			this.txtLTransportCode.Size = new global::System.Drawing.Size(175, 21);
			this.txtLTransportCode.TabIndex = 1;
			this.txtLisence.Border.Class = "TextBoxBorder";
			this.txtLisence.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtLisence.Location = new global::System.Drawing.Point(98, 4);
			this.txtLisence.Margin = new global::System.Windows.Forms.Padding(0);
			this.txtLisence.Name = "txtLisence";
			this.txtLisence.PreventEnterBeep = true;
			this.txtLisence.Size = new global::System.Drawing.Size(175, 21);
			this.txtLisence.TabIndex = 0;
			this.tInputValidDate.BackgroundStyle.Class = "DateTimeInputBackground";
			this.tInputValidDate.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.tInputValidDate.ButtonDropDown.Shortcut = global::DevComponents.DotNetBar.eShortcut.AltDown;
			this.tInputValidDate.ButtonDropDown.Visible = true;
			this.tInputValidDate.IsPopupCalendarOpen = false;
			this.tInputValidDate.Location = new global::System.Drawing.Point(98, 33);
			this.tInputValidDate.Margin = new global::System.Windows.Forms.Padding(0);
			this.tInputValidDate.MonthCalendar.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.tInputValidDate.MonthCalendar.CalendarDimensions = new global::System.Drawing.Size(1, 1);
			this.tInputValidDate.MonthCalendar.ClearButtonVisible = true;
			this.tInputValidDate.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = global::DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
			this.tInputValidDate.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
			this.tInputValidDate.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.BarBackground;
			this.tInputValidDate.MonthCalendar.CommandsBackgroundStyle.BorderTop = global::DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.tInputValidDate.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
			this.tInputValidDate.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
			this.tInputValidDate.MonthCalendar.CommandsBackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.tInputValidDate.MonthCalendar.DisplayMonth = new global::System.DateTime(2017, 6, 1, 0, 0, 0, 0);
			this.tInputValidDate.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
			this.tInputValidDate.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
			this.tInputValidDate.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
			this.tInputValidDate.MonthCalendar.NavigationBackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.tInputValidDate.MonthCalendar.TodayButtonVisible = true;
			this.tInputValidDate.Name = "tInputValidDate";
			this.tInputValidDate.Size = new global::System.Drawing.Size(175, 21);
			this.tInputValidDate.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.tInputValidDate.TabIndex = 2;
			this.cmbCreditType.DataSource = null;
			this.cmbCreditType.DisplayMember = null;
			this.cmbCreditType.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cmbCreditType.FormattingEnabled = true;
			this.cmbCreditType.ItemHeight = 15;
			this.cmbCreditType.Location = new global::System.Drawing.Point(375, 33);
			this.cmbCreditType.Margin = new global::System.Windows.Forms.Padding(0);
			this.cmbCreditType.MaxDropDownItems = 20;
			this.cmbCreditType.Name = "cmbCreditType";
			this.cmbCreditType.SelectMember = null;
			this.cmbCreditType.Size = new global::System.Drawing.Size(175, 21);
			this.cmbCreditType.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.cmbCreditType.TabIndex = 3;
			this.cmbCreditType.ValueMember = null;
			this.layoutControlItem5.Control = this.txtLisence;
			this.layoutControlItem5.Height = 29;
			this.layoutControlItem5.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem5.Name = "layoutControlItem5";
			this.layoutControlItem5.Text = "*Lisence";
			this.layoutControlItem5.Width = 50;
			this.layoutControlItem5.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem18.Control = this.txtLTransportCode;
			this.layoutControlItem18.Height = 29;
			this.layoutControlItem18.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem18.Name = "layoutControlItem18";
			this.layoutControlItem18.Text = "LTransportCode";
			this.layoutControlItem18.Width = 50;
			this.layoutControlItem18.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem39.Control = this.tInputValidDate;
			this.layoutControlItem39.Height = 29;
			this.layoutControlItem39.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem39.Name = "layoutControlItem39";
			this.layoutControlItem39.Text = "*ValidDate";
			this.layoutControlItem39.Width = 50;
			this.layoutControlItem39.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem27.Control = this.cmbCreditType;
			this.layoutControlItem27.Height = 29;
			this.layoutControlItem27.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem27.Name = "layoutControlItem27";
			this.layoutControlItem27.Text = "CreditType";
			this.layoutControlItem27.Width = 50;
			this.layoutControlItem27.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem14.Control = this.rtbRemark;
			this.layoutControlItem14.Height = 44;
			this.layoutControlItem14.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem14.Name = "layoutControlItem14";
			this.layoutControlItem14.Text = "Remark";
			this.layoutControlItem14.Width = 375;
			this.layoutControlItem14.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem24.Control = this.cmbCreditType;
			this.layoutControlItem24.Height = 28;
			this.layoutControlItem24.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem24.Name = "layoutControlItem24";
			this.layoutControlItem24.Text = "Product";
			this.layoutControlItem24.Width = 50;
			this.layoutControlItem24.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.gPanelContract.BackColor = global::System.Drawing.Color.Transparent;
			this.gPanelContract.CanvasColor = global::System.Drawing.SystemColors.Control;
			this.gPanelContract.ColorSchemeStyle = global::DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
			this.gPanelContract.Controls.Add(this.layoutControl1);
			this.gPanelContract.DisabledBackColor = global::System.Drawing.Color.Empty;
			this.gPanelContract.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.gPanelContract.DrawTitleBox = false;
			this.gPanelContract.Location = new global::System.Drawing.Point(0, 165);
			this.gPanelContract.Name = "gPanelContract";
			this.gPanelContract.Size = new global::System.Drawing.Size(560, 247);
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
			this.gPanelContract.TabIndex = 23;
			this.gPanelContract.Text = "Contract";
			this.layoutControl1.Controls.Add(this.cmbBusinessType);
			this.layoutControl1.Controls.Add(this.txtContractNum);
			this.layoutControl1.Controls.Add(this.cmbClientpart);
			this.layoutControl1.Controls.Add(this.cmbSettlepart);
			this.layoutControl1.Controls.Add(this.cmbProduct);
			this.layoutControl1.Controls.Add(this.txtCardNum);
			this.layoutControl1.Controls.Add(this.btnCard);
			this.layoutControl1.Controls.Add(this.cmbAccountType);
			this.layoutControl1.Controls.Add(this.btnDiBangValue);
			this.layoutControl1.Controls.Add(this.dInputJiHuaLiang);
			this.layoutControl1.Controls.Add(this.rdoCornCart);
			this.layoutControl1.Controls.Add(this.rdoCornTrolley);
			this.layoutControl1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.layoutControl1.Location = new global::System.Drawing.Point(0, 0);
			this.layoutControl1.Name = "layoutControl1";
			this.layoutControl1.RootGroup.Items.AddRange(new global::DevComponents.DotNetBar.Layout.LayoutItemBase[]
			{
				this.layoutControlItem11,
				this.layoutControlItem7,
				this.layoutControlItem16,
				this.layoutControlItem9,
				this.layoutControlItem10,
				this.layoutControlItem12,
				this.layoutControlItem20,
				this.layoutControlItem21,
				this.layoutControlItem3,
				this.layoutControlItem23,
				this.layoutControlItem4,
				this.layoutControlItem8
			});
			this.layoutControl1.Size = new global::System.Drawing.Size(554, 225);
			this.layoutControl1.TabIndex = 0;
			this.cmbBusinessType.DataSource = null;
			this.cmbBusinessType.DisplayMember = null;
			this.cmbBusinessType.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cmbBusinessType.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbBusinessType.FormattingEnabled = true;
			this.cmbBusinessType.ItemHeight = 16;
			this.cmbBusinessType.Location = new global::System.Drawing.Point(387, 4);
			this.cmbBusinessType.Margin = new global::System.Windows.Forms.Padding(0);
			this.cmbBusinessType.MaxDropDownItems = 20;
			this.cmbBusinessType.Name = "cmbBusinessType";
			this.cmbBusinessType.SelectMember = null;
			this.cmbBusinessType.Size = new global::System.Drawing.Size(163, 22);
			this.cmbBusinessType.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.cmbBusinessType.TabIndex = 1;
			this.cmbBusinessType.ValueMember = null;
			this.txtContractNum.Border.Class = "TextBoxBorder";
			this.txtContractNum.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtContractNum.Location = new global::System.Drawing.Point(110, 4);
			this.txtContractNum.Margin = new global::System.Windows.Forms.Padding(0);
			this.txtContractNum.Name = "txtContractNum";
			this.txtContractNum.PreventEnterBeep = true;
			this.txtContractNum.Size = new global::System.Drawing.Size(163, 21);
			this.txtContractNum.TabIndex = 0;
			this.cmbClientpart.DataSource = null;
			this.cmbClientpart.DisplayMember = null;
			this.cmbClientpart.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cmbClientpart.FormattingEnabled = true;
			this.cmbClientpart.ItemHeight = 15;
			this.cmbClientpart.Location = new global::System.Drawing.Point(110, 33);
			this.cmbClientpart.Margin = new global::System.Windows.Forms.Padding(0);
			this.cmbClientpart.MaxDropDownItems = 20;
			this.cmbClientpart.Name = "cmbClientpart";
			this.cmbClientpart.SelectMember = null;
			this.cmbClientpart.Size = new global::System.Drawing.Size(440, 21);
			this.cmbClientpart.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.cmbClientpart.TabIndex = 2;
			this.cmbClientpart.ValueMember = null;
			this.cmbSettlepart.DataSource = null;
			this.cmbSettlepart.DisplayMember = null;
			this.cmbSettlepart.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cmbSettlepart.FormattingEnabled = true;
			this.cmbSettlepart.ItemHeight = 15;
			this.cmbSettlepart.Location = new global::System.Drawing.Point(110, 62);
			this.cmbSettlepart.Margin = new global::System.Windows.Forms.Padding(0);
			this.cmbSettlepart.MaxDropDownItems = 20;
			this.cmbSettlepart.Name = "cmbSettlepart";
			this.cmbSettlepart.SelectMember = null;
			this.cmbSettlepart.Size = new global::System.Drawing.Size(440, 21);
			this.cmbSettlepart.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.cmbSettlepart.TabIndex = 3;
			this.cmbSettlepart.ValueMember = null;
			this.cmbProduct.DataSource = null;
			this.cmbProduct.DisplayMember = null;
			this.cmbProduct.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cmbProduct.FormattingEnabled = true;
			this.cmbProduct.ItemHeight = 15;
			this.cmbProduct.Location = new global::System.Drawing.Point(110, 122);
			this.cmbProduct.Margin = new global::System.Windows.Forms.Padding(0);
			this.cmbProduct.MaxDropDownItems = 20;
			this.cmbProduct.Name = "cmbProduct";
			this.cmbProduct.SelectMember = null;
			this.cmbProduct.Size = new global::System.Drawing.Size(163, 21);
			this.cmbProduct.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.cmbProduct.TabIndex = 8;
			this.cmbProduct.ValueMember = null;
			this.txtCardNum.Border.Class = "TextBoxBorder";
			this.txtCardNum.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtCardNum.Location = new global::System.Drawing.Point(110, 91);
			this.txtCardNum.Margin = new global::System.Windows.Forms.Padding(0);
			this.txtCardNum.Name = "txtCardNum";
			this.txtCardNum.PreventEnterBeep = true;
			this.txtCardNum.Size = new global::System.Drawing.Size(74, 21);
			this.txtCardNum.TabIndex = 4;
			this.btnCard.AccessibleRole = global::System.Windows.Forms.AccessibleRole.PushButton;
			this.btnCard.ColorTable = global::DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.btnCard.Location = new global::System.Drawing.Point(192, 91);
			this.btnCard.Margin = new global::System.Windows.Forms.Padding(0);
			this.btnCard.Name = "btnCard";
			this.btnCard.Size = new global::System.Drawing.Size(80, 23);
			this.btnCard.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.btnCard.TabIndex = 5;
			this.btnCard.Text = "ReadCard";
			this.btnCard.Click += new global::System.EventHandler(this.btnCard_Click);
			this.cmbAccountType.DataSource = null;
			this.cmbAccountType.DisplayMember = null;
			this.cmbAccountType.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cmbAccountType.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbAccountType.FormattingEnabled = true;
			this.cmbAccountType.ItemHeight = 16;
			this.cmbAccountType.Location = new global::System.Drawing.Point(386, 91);
			this.cmbAccountType.Margin = new global::System.Windows.Forms.Padding(0);
			this.cmbAccountType.MaxDropDownItems = 20;
			this.cmbAccountType.Name = "cmbAccountType";
			this.cmbAccountType.SelectMember = null;
			this.cmbAccountType.Size = new global::System.Drawing.Size(74, 22);
			this.cmbAccountType.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.cmbAccountType.TabIndex = 6;
			this.cmbAccountType.ValueMember = null;
			this.btnDiBangValue.AccessibleRole = global::System.Windows.Forms.AccessibleRole.PushButton;
			this.btnDiBangValue.ColorTable = global::DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.btnDiBangValue.Location = new global::System.Drawing.Point(468, 91);
			this.btnDiBangValue.Margin = new global::System.Windows.Forms.Padding(0);
			this.btnDiBangValue.Name = "btnDiBangValue";
			this.btnDiBangValue.Size = new global::System.Drawing.Size(82, 23);
			this.btnDiBangValue.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.btnDiBangValue.TabIndex = 7;
			this.btnDiBangValue.Text = "GetWbData";
			this.dInputJiHuaLiang.BackgroundStyle.Class = "DateTimeInputBackground";
			this.dInputJiHuaLiang.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.dInputJiHuaLiang.ButtonFreeText.Shortcut = global::DevComponents.DotNetBar.eShortcut.F2;
			this.dInputJiHuaLiang.Increment = 1.0;
			this.dInputJiHuaLiang.InputHorizontalAlignment = global::DevComponents.Editors.eHorizontalAlignment.Left;
			this.dInputJiHuaLiang.Location = new global::System.Drawing.Point(387, 122);
			this.dInputJiHuaLiang.Margin = new global::System.Windows.Forms.Padding(0);
			this.dInputJiHuaLiang.Name = "dInputJiHuaLiang";
			this.dInputJiHuaLiang.ShowUpDown = true;
			this.dInputJiHuaLiang.Size = new global::System.Drawing.Size(163, 21);
			this.dInputJiHuaLiang.TabIndex = 9;
			this.dInputJiHuaLiang.ValueChanged += new global::System.EventHandler(this.dInputJiHuaLiang_ValueChanged);
			this.layoutControlItem11.Control = this.txtContractNum;
			this.layoutControlItem11.Height = 29;
			this.layoutControlItem11.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem11.Name = "layoutControlItem11";
			this.layoutControlItem11.Text = "ContractID";
			this.layoutControlItem11.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem11.Width = 50;
			this.layoutControlItem11.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem7.Control = this.cmbBusinessType;
			this.layoutControlItem7.Height = 29;
			this.layoutControlItem7.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem7.Name = "layoutControlItem7";
			this.layoutControlItem7.Text = "*BusinessType";
			this.layoutControlItem7.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem7.Width = 50;
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
			this.layoutControlItem10.Control = this.txtCardNum;
			this.layoutControlItem10.Height = 29;
			this.layoutControlItem10.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem10.Name = "layoutControlItem10";
			this.layoutControlItem10.Text = "IC";
			this.layoutControlItem10.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem10.Width = 34;
			this.layoutControlItem10.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem12.Control = this.btnCard;
			this.layoutControlItem12.Height = 31;
			this.layoutControlItem12.MinSize = new global::System.Drawing.Size(32, 20);
			this.layoutControlItem12.Name = "layoutControlItem12";
			this.layoutControlItem12.Width = 16;
			this.layoutControlItem12.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem20.Control = this.cmbAccountType;
			this.layoutControlItem20.Height = 30;
			this.layoutControlItem20.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem20.Name = "layoutControlItem20";
			this.layoutControlItem20.Text = "AccountType";
			this.layoutControlItem20.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem20.Width = 34;
			this.layoutControlItem20.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem21.Control = this.btnDiBangValue;
			this.layoutControlItem21.Height = 31;
			this.layoutControlItem21.MinSize = new global::System.Drawing.Size(32, 20);
			this.layoutControlItem21.Name = "layoutControlItem21";
			this.layoutControlItem21.Width = 16;
			this.layoutControlItem21.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem3.Control = this.cmbProduct;
			this.layoutControlItem3.Height = 29;
			this.layoutControlItem3.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem3.Name = "layoutControlItem3";
			this.layoutControlItem3.Text = "Product";
			this.layoutControlItem3.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem3.Width = 50;
			this.layoutControlItem3.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem23.Control = this.dInputJiHuaLiang;
			this.layoutControlItem23.Height = 29;
			this.layoutControlItem23.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem23.Name = "layoutControlItem23";
			this.layoutControlItem23.Text = "JiHuaLiang";
			this.layoutControlItem23.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem23.Width = 50;
			this.layoutControlItem23.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem1.Height = 28;
			this.layoutControlItem1.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Text = "Product";
			this.layoutControlItem1.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem1.Width = 100;
			this.layoutControlItem1.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem2.Control = this.cmbProduct;
			this.layoutControlItem2.Height = 28;
			this.layoutControlItem2.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem2.Name = "layoutControlItem2";
			this.layoutControlItem2.Text = "Product";
			this.layoutControlItem2.Width = 50;
			this.layoutControlItem2.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem6.Control = this.txtCardNum;
			this.layoutControlItem6.Height = 29;
			this.layoutControlItem6.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem6.Name = "layoutControlItem6";
			this.layoutControlItem6.Text = "IC";
			this.layoutControlItem6.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem6.Width = 70;
			this.layoutControlItem6.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem17.Control = this.btnCard;
			this.layoutControlItem17.Height = 31;
			this.layoutControlItem17.MinSize = new global::System.Drawing.Size(32, 20);
			this.layoutControlItem17.Name = "layoutControlItem17";
			this.layoutControlItem17.Width = 30;
			this.layoutControlItem17.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem13.Control = this.cmbAccountType;
			this.layoutControlItem13.Height = 28;
			this.layoutControlItem13.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem13.Name = "layoutControlItem13";
			this.layoutControlItem13.Text = "AccountType";
			this.layoutControlItem13.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem13.Width = 70;
			this.layoutControlItem13.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem19.Control = this.btnDiBangValue;
			this.layoutControlItem19.Height = 31;
			this.layoutControlItem19.MinSize = new global::System.Drawing.Size(32, 20);
			this.layoutControlItem19.Name = "layoutControlItem19";
			this.layoutControlItem19.Width = 30;
			this.layoutControlItem19.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem22.Height = 29;
			this.layoutControlItem22.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem22.Name = "layoutControlItem22";
			this.layoutControlItem22.Text = "*Lisence";
			this.layoutControlItem22.Width = 50;
			this.layoutControlItem22.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem15.Control = this.dInputJiHuaLiang;
			this.layoutControlItem15.Height = 29;
			this.layoutControlItem15.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem15.Name = "layoutControlItem15";
			this.layoutControlItem15.Text = "*LoadWeight(kg)";
			this.layoutControlItem15.Width = 50;
			this.layoutControlItem15.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.rdoCornCart.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.rdoCornCart.CheckBoxStyle = global::DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
			this.rdoCornCart.Checked = true;
			this.rdoCornCart.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.rdoCornCart.CheckValue = "Y";
			this.rdoCornCart.Font = new global::System.Drawing.Font("宋体", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 134);
			this.rdoCornCart.Location = new global::System.Drawing.Point(110, 151);
			this.rdoCornCart.Margin = new global::System.Windows.Forms.Padding(0);
			this.rdoCornCart.Name = "rdoCornCart";
			this.rdoCornCart.Size = new global::System.Drawing.Size(79, 23);
			this.rdoCornCart.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.rdoCornCart.TabIndex = 12;
			this.rdoCornCart.Text = "CornCart";
			this.rdoCornCart.TextColor = global::System.Drawing.Color.Black;
			this.rdoCornTrolley.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.rdoCornTrolley.CheckBoxStyle = global::DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
			this.rdoCornTrolley.Font = new global::System.Drawing.Font("宋体", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 134);
			this.rdoCornTrolley.Location = new global::System.Drawing.Point(197, 151);
			this.rdoCornTrolley.Margin = new global::System.Windows.Forms.Padding(0);
			this.rdoCornTrolley.Name = "rdoCornTrolley";
			this.rdoCornTrolley.Size = new global::System.Drawing.Size(130, 23);
			this.rdoCornTrolley.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.rdoCornTrolley.TabIndex = 13;
			this.rdoCornTrolley.Text = "CornTrolley";
			this.rdoCornTrolley.TextColor = global::System.Drawing.Color.Black;
			this.layoutControlItem4.Control = this.rdoCornCart;
			this.layoutControlItem4.Height = 31;
			this.layoutControlItem4.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem4.Name = "layoutControlItem4";
			this.layoutControlItem4.Text = "SelCartOrTrolley";
			this.layoutControlItem4.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem4.Width = 35;
			this.layoutControlItem4.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem8.Control = this.rdoCornTrolley;
			this.layoutControlItem8.Height = 31;
			this.layoutControlItem8.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem8.Name = "layoutControlItem8";
			this.layoutControlItem8.Width = 25;
			this.layoutControlItem8.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			base.ClientSize = new global::System.Drawing.Size(560, 412);
			base.Controls.Add(this.gPanelContract);
			base.Controls.Add(this.groupPanel4);
			base.Controls.Add(this.bar1);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "frmTicketNFastAdd";
			this.Text = "frmTicketNFastAdd";
			base.Load += new global::System.EventHandler(this.frmTicketNFastAdd_Load);
			((global::System.ComponentModel.ISupportInitialize)this.bar1).EndInit();
			this.groupPanel4.ResumeLayout(false);
			this.layCoach.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.tInputValidDate).EndInit();
			this.gPanelContract.ResumeLayout(false);
			this.layoutControl1.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.dInputJiHuaLiang).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000988 RID: 2440
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000989 RID: 2441
		private global::DevComponents.DotNetBar.Controls.RichTextBoxEx rtbRemark;

		// Token: 0x0400098A RID: 2442
		private global::DevComponents.DotNetBar.Bar bar1;

		// Token: 0x0400098B RID: 2443
		private global::DevComponents.DotNetBar.ButtonItem btnSave;

		// Token: 0x0400098C RID: 2444
		private global::DevComponents.DotNetBar.Controls.GroupPanel groupPanel4;

		// Token: 0x0400098D RID: 2445
		private global::DevComponents.DotNetBar.Layout.LayoutControl layCoach;

		// Token: 0x0400098E RID: 2446
		private global::DevComponents.Editors.DateTimeAdv.DateTimeInput tInputValidDate;

		// Token: 0x0400098F RID: 2447
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem39;

		// Token: 0x04000990 RID: 2448
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtLisence;

		// Token: 0x04000991 RID: 2449
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem5;

		// Token: 0x04000992 RID: 2450
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem14;

		// Token: 0x04000993 RID: 2451
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtLTransportCode;

		// Token: 0x04000994 RID: 2452
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem18;

		// Token: 0x04000995 RID: 2453
		private global::Base.AutoComboBox cmbCreditType;

		// Token: 0x04000996 RID: 2454
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem27;

		// Token: 0x04000997 RID: 2455
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem24;

		// Token: 0x04000998 RID: 2456
		private global::DevComponents.DotNetBar.Controls.GroupPanel gPanelContract;

		// Token: 0x04000999 RID: 2457
		private global::DevComponents.DotNetBar.Layout.LayoutControl layoutControl1;

		// Token: 0x0400099A RID: 2458
		private global::Base.AutoComboBox cmbBusinessType;

		// Token: 0x0400099B RID: 2459
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtContractNum;

		// Token: 0x0400099C RID: 2460
		private global::Base.AutoComboBox cmbClientpart;

		// Token: 0x0400099D RID: 2461
		private global::Base.AutoComboBox cmbSettlepart;

		// Token: 0x0400099E RID: 2462
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem11;

		// Token: 0x0400099F RID: 2463
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem7;

		// Token: 0x040009A0 RID: 2464
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem16;

		// Token: 0x040009A1 RID: 2465
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem9;

		// Token: 0x040009A2 RID: 2466
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem1;

		// Token: 0x040009A3 RID: 2467
		private global::Base.AutoComboBox cmbProduct;

		// Token: 0x040009A4 RID: 2468
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem3;

		// Token: 0x040009A5 RID: 2469
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem2;

		// Token: 0x040009A6 RID: 2470
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtCardNum;

		// Token: 0x040009A7 RID: 2471
		private global::DevComponents.DotNetBar.ButtonX btnCard;

		// Token: 0x040009A8 RID: 2472
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem10;

		// Token: 0x040009A9 RID: 2473
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem12;

		// Token: 0x040009AA RID: 2474
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem6;

		// Token: 0x040009AB RID: 2475
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem17;

		// Token: 0x040009AC RID: 2476
		private global::Base.AutoComboBox cmbAccountType;

		// Token: 0x040009AD RID: 2477
		private global::DevComponents.DotNetBar.ButtonX btnDiBangValue;

		// Token: 0x040009AE RID: 2478
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem20;

		// Token: 0x040009AF RID: 2479
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem21;

		// Token: 0x040009B0 RID: 2480
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem13;

		// Token: 0x040009B1 RID: 2481
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem19;

		// Token: 0x040009B2 RID: 2482
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem22;

		// Token: 0x040009B3 RID: 2483
		private global::DevComponents.Editors.DoubleInput dInputJiHuaLiang;

		// Token: 0x040009B4 RID: 2484
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem23;

		// Token: 0x040009B5 RID: 2485
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem15;

		// Token: 0x040009B6 RID: 2486
		private global::DevComponents.DotNetBar.Controls.CheckBoxX rdoCornCart;

		// Token: 0x040009B7 RID: 2487
		private global::DevComponents.DotNetBar.Controls.CheckBoxX rdoCornTrolley;

		// Token: 0x040009B8 RID: 2488
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem4;

		// Token: 0x040009B9 RID: 2489
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem8;
	}
}
