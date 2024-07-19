namespace SQSClient
{
	// Token: 0x02000063 RID: 99
	public partial class frmCheckIn : global::SQSClient.BaseDialogForm
	{
		// Token: 0x060004CC RID: 1228 RVA: 0x00078174 File Offset: 0x00076374
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060004CD RID: 1229 RVA: 0x000781AC File Offset: 0x000763AC
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::SQSClient.frmCheckIn));
			this.txtEmailAddr = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.txtWeChat = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.rdoRoleSupercargo = new global::DevComponents.DotNetBar.Controls.CheckBoxX();
			this.rdoRoleDriver = new global::DevComponents.DotNetBar.Controls.CheckBoxX();
			this.groupPanel1 = new global::DevComponents.DotNetBar.Controls.GroupPanel();
			this.rImagePhoto = new global::DevComponents.DotNetBar.Controls.ReflectionImage();
			this.layIdentity = new global::DevComponents.DotNetBar.Layout.LayoutControl();
			this.txtValidterm = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.txtNation = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.tInputBirthday = new global::DevComponents.Editors.DateTimeAdv.DateTimeInput();
			this.txtAddress = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.txtSex = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.txtName = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.txtIDCard = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.layoutControlItem3 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem6 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem2 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem1 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem7 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem9 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem16 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.chkEnable = new global::DevComponents.DotNetBar.Controls.CheckBoxX();
			this.txtPhoneNum = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.bar1 = new global::DevComponents.DotNetBar.Bar();
			this.btnSave = new global::DevComponents.DotNetBar.ButtonItem();
			this.btnRead = new global::DevComponents.DotNetBar.ButtonItem();
			this.groupPanel2 = new global::DevComponents.DotNetBar.Controls.GroupPanel();
			this.layoutControl1 = new global::DevComponents.DotNetBar.Layout.LayoutControl();
			this.txtQualifyCode = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.txtDriverCode = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.dInputWeight = new global::DevComponents.Editors.DoubleInput();
			this.layoutControlItem12 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem13 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem4 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem5 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem14 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem15 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem8 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem10 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem11 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.groupPanel1.SuspendLayout();
			this.layIdentity.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.tInputBirthday).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.bar1).BeginInit();
			this.groupPanel2.SuspendLayout();
			this.layoutControl1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dInputWeight).BeginInit();
			base.SuspendLayout();
			this.txtEmailAddr.Border.Class = "TextBoxBorder";
			this.txtEmailAddr.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtEmailAddr.Font = new global::System.Drawing.Font("宋体", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 134);
			this.txtEmailAddr.Location = new global::System.Drawing.Point(98, 91);
			this.txtEmailAddr.Margin = new global::System.Windows.Forms.Padding(0);
			this.txtEmailAddr.Name = "txtEmailAddr";
			this.txtEmailAddr.PreventEnterBeep = true;
			this.txtEmailAddr.Size = new global::System.Drawing.Size(445, 21);
			this.txtEmailAddr.TabIndex = 6;
			this.txtWeChat.Border.Class = "TextBoxBorder";
			this.txtWeChat.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtWeChat.Font = new global::System.Drawing.Font("宋体", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 134);
			this.txtWeChat.Location = new global::System.Drawing.Point(371, 62);
			this.txtWeChat.Margin = new global::System.Windows.Forms.Padding(0);
			this.txtWeChat.Name = "txtWeChat";
			this.txtWeChat.PreventEnterBeep = true;
			this.txtWeChat.Size = new global::System.Drawing.Size(172, 21);
			this.txtWeChat.TabIndex = 5;
			this.rdoRoleSupercargo.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.rdoRoleSupercargo.CheckBoxStyle = global::DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
			this.rdoRoleSupercargo.Font = new global::System.Drawing.Font("宋体", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 134);
			this.rdoRoleSupercargo.Location = new global::System.Drawing.Point(277, 120);
			this.rdoRoleSupercargo.Margin = new global::System.Windows.Forms.Padding(0);
			this.rdoRoleSupercargo.Name = "rdoRoleSupercargo";
			this.rdoRoleSupercargo.Size = new global::System.Drawing.Size(266, 23);
			this.rdoRoleSupercargo.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.rdoRoleSupercargo.TabIndex = 8;
			this.rdoRoleSupercargo.Text = "Supercargo";
			this.rdoRoleSupercargo.TextColor = global::System.Drawing.Color.Black;
			this.rdoRoleDriver.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.rdoRoleDriver.CheckBoxStyle = global::DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
			this.rdoRoleDriver.Checked = true;
			this.rdoRoleDriver.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.rdoRoleDriver.CheckValue = "Y";
			this.rdoRoleDriver.Font = new global::System.Drawing.Font("宋体", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 134);
			this.rdoRoleDriver.Location = new global::System.Drawing.Point(98, 120);
			this.rdoRoleDriver.Margin = new global::System.Windows.Forms.Padding(0);
			this.rdoRoleDriver.Name = "rdoRoleDriver";
			this.rdoRoleDriver.Size = new global::System.Drawing.Size(171, 23);
			this.rdoRoleDriver.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.rdoRoleDriver.TabIndex = 7;
			this.rdoRoleDriver.Text = "Driver";
			this.rdoRoleDriver.TextColor = global::System.Drawing.Color.Black;
			this.groupPanel1.BackColor = global::System.Drawing.Color.Transparent;
			this.groupPanel1.CanvasColor = global::System.Drawing.SystemColors.Control;
			this.groupPanel1.ColorSchemeStyle = global::DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
			this.groupPanel1.Controls.Add(this.rImagePhoto);
			this.groupPanel1.Controls.Add(this.layIdentity);
			this.groupPanel1.DisabledBackColor = global::System.Drawing.Color.Empty;
			this.groupPanel1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.groupPanel1.DrawTitleBox = false;
			this.groupPanel1.Location = new global::System.Drawing.Point(0, 26);
			this.groupPanel1.Name = "groupPanel1";
			this.groupPanel1.Size = new global::System.Drawing.Size(553, 198);
			this.groupPanel1.Style.BackColor = global::System.Drawing.Color.Transparent;
			this.groupPanel1.Style.BackColor2 = global::System.Drawing.Color.Transparent;
			this.groupPanel1.Style.BackColorGradientAngle = 90;
			this.groupPanel1.Style.BorderBottom = global::DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.groupPanel1.Style.BorderBottomWidth = 1;
			this.groupPanel1.Style.BorderColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
			this.groupPanel1.Style.BorderLeft = global::DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.groupPanel1.Style.BorderLeftWidth = 1;
			this.groupPanel1.Style.BorderRight = global::DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.groupPanel1.Style.BorderRightWidth = 1;
			this.groupPanel1.Style.BorderTop = global::DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.groupPanel1.Style.BorderTopWidth = 1;
			this.groupPanel1.Style.CornerDiameter = 4;
			this.groupPanel1.Style.CornerType = global::DevComponents.DotNetBar.eCornerType.Rounded;
			this.groupPanel1.Style.TextColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelText;
			this.groupPanel1.Style.TextLineAlignment = global::DevComponents.DotNetBar.eStyleTextAlignment.Near;
			this.groupPanel1.StyleMouseDown.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.groupPanel1.StyleMouseOver.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.groupPanel1.TabIndex = 29;
			this.groupPanel1.Text = "Identity";
			this.rImagePhoto.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.rImagePhoto.BackgroundStyle.TextAlignment = global::DevComponents.DotNetBar.eStyleTextAlignment.Center;
			this.rImagePhoto.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("rImagePhoto.Image");
			this.rImagePhoto.Location = new global::System.Drawing.Point(3, 1);
			this.rImagePhoto.Name = "rImagePhoto";
			this.rImagePhoto.ReflectionEnabled = false;
			this.rImagePhoto.Size = new global::System.Drawing.Size(109, 135);
			this.rImagePhoto.TabIndex = 1;
			this.layIdentity.Controls.Add(this.txtValidterm);
			this.layIdentity.Controls.Add(this.txtNation);
			this.layIdentity.Controls.Add(this.tInputBirthday);
			this.layIdentity.Controls.Add(this.txtAddress);
			this.layIdentity.Controls.Add(this.txtSex);
			this.layIdentity.Controls.Add(this.txtName);
			this.layIdentity.Controls.Add(this.txtIDCard);
			this.layIdentity.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.layIdentity.Location = new global::System.Drawing.Point(118, 0);
			this.layIdentity.Name = "layIdentity";
			this.layIdentity.RootGroup.Items.AddRange(new global::DevComponents.DotNetBar.Layout.LayoutItemBase[]
			{
				this.layoutControlItem3,
				this.layoutControlItem6,
				this.layoutControlItem2,
				this.layoutControlItem1,
				this.layoutControlItem7,
				this.layoutControlItem9,
				this.layoutControlItem16
			});
			this.layIdentity.Size = new global::System.Drawing.Size(429, 176);
			this.layIdentity.TabIndex = 0;
			this.txtValidterm.Border.Class = "TextBoxBorder";
			this.txtValidterm.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtValidterm.Location = new global::System.Drawing.Point(73, 149);
			this.txtValidterm.Margin = new global::System.Windows.Forms.Padding(0);
			this.txtValidterm.Name = "txtValidterm";
			this.txtValidterm.PreventEnterBeep = true;
			this.txtValidterm.Size = new global::System.Drawing.Size(352, 21);
			this.txtValidterm.TabIndex = 6;
			this.txtValidterm.WatermarkText = "yyyy/MM/dd-";
			this.txtNation.Border.Class = "TextBoxBorder";
			this.txtNation.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtNation.Location = new global::System.Drawing.Point(287, 33);
			this.txtNation.Margin = new global::System.Windows.Forms.Padding(0);
			this.txtNation.Name = "txtNation";
			this.txtNation.PreventEnterBeep = true;
			this.txtNation.Size = new global::System.Drawing.Size(138, 21);
			this.txtNation.TabIndex = 2;
			this.tInputBirthday.BackgroundStyle.Class = "DateTimeInputBackground";
			this.tInputBirthday.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.tInputBirthday.ButtonDropDown.Shortcut = global::DevComponents.DotNetBar.eShortcut.AltDown;
			this.tInputBirthday.ButtonDropDown.Visible = true;
			this.tInputBirthday.IsPopupCalendarOpen = false;
			this.tInputBirthday.Location = new global::System.Drawing.Point(73, 62);
			this.tInputBirthday.Margin = new global::System.Windows.Forms.Padding(0);
			this.tInputBirthday.MonthCalendar.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.tInputBirthday.MonthCalendar.CalendarDimensions = new global::System.Drawing.Size(1, 1);
			this.tInputBirthday.MonthCalendar.ClearButtonVisible = true;
			this.tInputBirthday.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = global::DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
			this.tInputBirthday.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
			this.tInputBirthday.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.BarBackground;
			this.tInputBirthday.MonthCalendar.CommandsBackgroundStyle.BorderTop = global::DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.tInputBirthday.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
			this.tInputBirthday.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
			this.tInputBirthday.MonthCalendar.CommandsBackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.tInputBirthday.MonthCalendar.DisplayMonth = new global::System.DateTime(2019, 6, 1, 0, 0, 0, 0);
			this.tInputBirthday.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
			this.tInputBirthday.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
			this.tInputBirthday.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
			this.tInputBirthday.MonthCalendar.NavigationBackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.tInputBirthday.MonthCalendar.TodayButtonVisible = true;
			this.tInputBirthday.Name = "tInputBirthday";
			this.tInputBirthday.Size = new global::System.Drawing.Size(352, 21);
			this.tInputBirthday.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.tInputBirthday.TabIndex = 3;
			this.txtAddress.Border.Class = "TextBoxBorder";
			this.txtAddress.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtAddress.Location = new global::System.Drawing.Point(73, 120);
			this.txtAddress.Margin = new global::System.Windows.Forms.Padding(0);
			this.txtAddress.Name = "txtAddress";
			this.txtAddress.PreventEnterBeep = true;
			this.txtAddress.Size = new global::System.Drawing.Size(352, 21);
			this.txtAddress.TabIndex = 5;
			this.txtSex.Border.Class = "TextBoxBorder";
			this.txtSex.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtSex.Location = new global::System.Drawing.Point(73, 33);
			this.txtSex.Margin = new global::System.Windows.Forms.Padding(0);
			this.txtSex.Name = "txtSex";
			this.txtSex.PreventEnterBeep = true;
			this.txtSex.Size = new global::System.Drawing.Size(137, 21);
			this.txtSex.TabIndex = 1;
			this.txtName.Border.Class = "TextBoxBorder";
			this.txtName.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtName.Location = new global::System.Drawing.Point(73, 4);
			this.txtName.Margin = new global::System.Windows.Forms.Padding(0);
			this.txtName.Name = "txtName";
			this.txtName.PreventEnterBeep = true;
			this.txtName.Size = new global::System.Drawing.Size(352, 21);
			this.txtName.TabIndex = 0;
			this.txtIDCard.Border.Class = "TextBoxBorder";
			this.txtIDCard.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtIDCard.Location = new global::System.Drawing.Point(73, 91);
			this.txtIDCard.Margin = new global::System.Windows.Forms.Padding(0);
			this.txtIDCard.Name = "txtIDCard";
			this.txtIDCard.PreventEnterBeep = true;
			this.txtIDCard.Size = new global::System.Drawing.Size(352, 21);
			this.txtIDCard.TabIndex = 4;
			this.txtIDCard.TextChanged += new global::System.EventHandler(this.txtIDCard_TextChanged);
			this.layoutControlItem3.Control = this.txtName;
			this.layoutControlItem3.Height = 29;
			this.layoutControlItem3.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem3.Name = "layoutControlItem3";
			this.layoutControlItem3.Text = "PersonName";
			this.layoutControlItem3.Width = 100;
			this.layoutControlItem3.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem6.Control = this.txtSex;
			this.layoutControlItem6.Height = 29;
			this.layoutControlItem6.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem6.Name = "layoutControlItem6";
			this.layoutControlItem6.Text = "Sex";
			this.layoutControlItem6.Width = 50;
			this.layoutControlItem6.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem2.Control = this.txtNation;
			this.layoutControlItem2.Height = 29;
			this.layoutControlItem2.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem2.Name = "layoutControlItem2";
			this.layoutControlItem2.Text = "Nation";
			this.layoutControlItem2.Width = 50;
			this.layoutControlItem2.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem1.Control = this.tInputBirthday;
			this.layoutControlItem1.Height = 29;
			this.layoutControlItem1.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Text = "Birth";
			this.layoutControlItem1.Width = 100;
			this.layoutControlItem1.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem7.Control = this.txtIDCard;
			this.layoutControlItem7.Height = 29;
			this.layoutControlItem7.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem7.Name = "layoutControlItem7";
			this.layoutControlItem7.Text = "IDCard";
			this.layoutControlItem7.Width = 100;
			this.layoutControlItem7.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem9.Control = this.txtAddress;
			this.layoutControlItem9.Height = 29;
			this.layoutControlItem9.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem9.Name = "layoutControlItem9";
			this.layoutControlItem9.Text = "LiveAddr";
			this.layoutControlItem9.Width = 100;
			this.layoutControlItem9.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem16.Control = this.txtValidterm;
			this.layoutControlItem16.Height = 29;
			this.layoutControlItem16.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem16.Name = "layoutControlItem16";
			this.layoutControlItem16.Text = "Validterm";
			this.layoutControlItem16.Width = 100;
			this.layoutControlItem16.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.chkEnable.AutoSize = true;
			this.chkEnable.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.chkEnable.Checked = true;
			this.chkEnable.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.chkEnable.CheckValue = "Y";
			this.chkEnable.Location = new global::System.Drawing.Point(277, 4);
			this.chkEnable.Margin = new global::System.Windows.Forms.Padding(0);
			this.chkEnable.Name = "chkEnable";
			this.chkEnable.Size = new global::System.Drawing.Size(57, 16);
			this.chkEnable.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.chkEnable.TabIndex = 1;
			this.chkEnable.Text = "Valid";
			this.txtPhoneNum.Border.Class = "TextBoxBorder";
			this.txtPhoneNum.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtPhoneNum.Location = new global::System.Drawing.Point(98, 62);
			this.txtPhoneNum.Margin = new global::System.Windows.Forms.Padding(0);
			this.txtPhoneNum.Name = "txtPhoneNum";
			this.txtPhoneNum.PreventEnterBeep = true;
			this.txtPhoneNum.Size = new global::System.Drawing.Size(171, 21);
			this.txtPhoneNum.TabIndex = 4;
			this.bar1.AccessibleDescription = "DotNetBar Bar (bar1)";
			this.bar1.AccessibleName = "DotNetBar Bar";
			this.bar1.AccessibleRole = global::System.Windows.Forms.AccessibleRole.MenuBar;
			this.bar1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.bar1.Font = new global::System.Drawing.Font("微软雅黑", 9f);
			this.bar1.IsMaximized = false;
			this.bar1.Items.AddRange(new global::DevComponents.DotNetBar.BaseItem[]
			{
				this.btnSave,
				this.btnRead
			});
			this.bar1.Location = new global::System.Drawing.Point(0, 0);
			this.bar1.MenuBar = true;
			this.bar1.Name = "bar1";
			this.bar1.Size = new global::System.Drawing.Size(553, 26);
			this.bar1.Stretch = true;
			this.bar1.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.Windows7;
			this.bar1.TabIndex = 30;
			this.bar1.TabStop = false;
			this.bar1.Text = "bar1";
			this.btnSave.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.btnSave.Image = global::SQSClient.Properties.Resources.save16;
			this.btnSave.Name = "btnSave";
			this.btnSave.Text = "Save";
			this.btnSave.Click += new global::System.EventHandler(this.btnSave_Click);
			this.btnRead.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.btnRead.Image = global::SQSClient.Properties.Resources.read16;
			this.btnRead.ItemAlignment = global::DevComponents.DotNetBar.eItemAlignment.Far;
			this.btnRead.Name = "btnRead";
			this.btnRead.Text = "Read";
			this.btnRead.Click += new global::System.EventHandler(this.btnRead_Click);
			this.groupPanel2.BackColor = global::System.Drawing.Color.Transparent;
			this.groupPanel2.CanvasColor = global::System.Drawing.SystemColors.Control;
			this.groupPanel2.ColorSchemeStyle = global::DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
			this.groupPanel2.Controls.Add(this.layoutControl1);
			this.groupPanel2.DisabledBackColor = global::System.Drawing.Color.Empty;
			this.groupPanel2.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.groupPanel2.DrawTitleBox = false;
			this.groupPanel2.Location = new global::System.Drawing.Point(0, 224);
			this.groupPanel2.Name = "groupPanel2";
			this.groupPanel2.Size = new global::System.Drawing.Size(553, 171);
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
			this.groupPanel2.Style.TextColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelText;
			this.groupPanel2.Style.TextLineAlignment = global::DevComponents.DotNetBar.eStyleTextAlignment.Near;
			this.groupPanel2.StyleMouseDown.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.groupPanel2.StyleMouseOver.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.groupPanel2.TabIndex = 31;
			this.groupPanel2.Text = "Others";
			this.layoutControl1.Controls.Add(this.txtQualifyCode);
			this.layoutControl1.Controls.Add(this.txtDriverCode);
			this.layoutControl1.Controls.Add(this.dInputWeight);
			this.layoutControl1.Controls.Add(this.chkEnable);
			this.layoutControl1.Controls.Add(this.txtPhoneNum);
			this.layoutControl1.Controls.Add(this.txtWeChat);
			this.layoutControl1.Controls.Add(this.txtEmailAddr);
			this.layoutControl1.Controls.Add(this.rdoRoleDriver);
			this.layoutControl1.Controls.Add(this.rdoRoleSupercargo);
			this.layoutControl1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.layoutControl1.Location = new global::System.Drawing.Point(0, 0);
			this.layoutControl1.Name = "layoutControl1";
			this.layoutControl1.RootGroup.Items.AddRange(new global::DevComponents.DotNetBar.Layout.LayoutItemBase[]
			{
				this.layoutControlItem12,
				this.layoutControlItem13,
				this.layoutControlItem4,
				this.layoutControlItem5,
				this.layoutControlItem14,
				this.layoutControlItem15,
				this.layoutControlItem8,
				this.layoutControlItem10,
				this.layoutControlItem11
			});
			this.layoutControl1.Size = new global::System.Drawing.Size(547, 149);
			this.layoutControl1.TabIndex = 0;
			this.txtQualifyCode.Border.Class = "TextBoxBorder";
			this.txtQualifyCode.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtQualifyCode.Location = new global::System.Drawing.Point(371, 33);
			this.txtQualifyCode.Margin = new global::System.Windows.Forms.Padding(0);
			this.txtQualifyCode.Name = "txtQualifyCode";
			this.txtQualifyCode.PreventEnterBeep = true;
			this.txtQualifyCode.Size = new global::System.Drawing.Size(172, 21);
			this.txtQualifyCode.TabIndex = 3;
			this.txtDriverCode.Border.Class = "TextBoxBorder";
			this.txtDriverCode.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtDriverCode.Location = new global::System.Drawing.Point(98, 33);
			this.txtDriverCode.Margin = new global::System.Windows.Forms.Padding(0);
			this.txtDriverCode.Name = "txtDriverCode";
			this.txtDriverCode.PreventEnterBeep = true;
			this.txtDriverCode.Size = new global::System.Drawing.Size(171, 21);
			this.txtDriverCode.TabIndex = 2;
			this.dInputWeight.BackgroundStyle.Class = "DateTimeInputBackground";
			this.dInputWeight.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.dInputWeight.ButtonFreeText.Shortcut = global::DevComponents.DotNetBar.eShortcut.F2;
			this.dInputWeight.Increment = 1.0;
			this.dInputWeight.Location = new global::System.Drawing.Point(98, 4);
			this.dInputWeight.Margin = new global::System.Windows.Forms.Padding(0);
			this.dInputWeight.Name = "dInputWeight";
			this.dInputWeight.ShowUpDown = true;
			this.dInputWeight.Size = new global::System.Drawing.Size(171, 21);
			this.dInputWeight.TabIndex = 0;
			this.layoutControlItem12.Control = this.dInputWeight;
			this.layoutControlItem12.Height = 29;
			this.layoutControlItem12.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem12.Name = "layoutControlItem12";
			this.layoutControlItem12.Text = "BodyWeight(kg)";
			this.layoutControlItem12.Width = 50;
			this.layoutControlItem12.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem13.Control = this.chkEnable;
			this.layoutControlItem13.Height = 24;
			this.layoutControlItem13.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem13.Name = "layoutControlItem13";
			this.layoutControlItem13.Width = 10;
			this.layoutControlItem13.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem4.Control = this.txtDriverCode;
			this.layoutControlItem4.Height = 29;
			this.layoutControlItem4.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem4.Name = "layoutControlItem4";
			this.layoutControlItem4.Text = "DriverCode";
			this.layoutControlItem4.Width = 50;
			this.layoutControlItem4.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem5.Control = this.txtQualifyCode;
			this.layoutControlItem5.Height = 29;
			this.layoutControlItem5.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem5.Name = "layoutControlItem5";
			this.layoutControlItem5.Text = "QualifyCode";
			this.layoutControlItem5.Width = 50;
			this.layoutControlItem5.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem14.Control = this.txtPhoneNum;
			this.layoutControlItem14.Height = 29;
			this.layoutControlItem14.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem14.Name = "layoutControlItem14";
			this.layoutControlItem14.Text = "PhoneNum";
			this.layoutControlItem14.Width = 50;
			this.layoutControlItem14.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem15.Control = this.txtWeChat;
			this.layoutControlItem15.Height = 29;
			this.layoutControlItem15.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem15.Name = "layoutControlItem15";
			this.layoutControlItem15.Text = "WeChat";
			this.layoutControlItem15.Width = 50;
			this.layoutControlItem15.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem8.Control = this.txtEmailAddr;
			this.layoutControlItem8.Height = 29;
			this.layoutControlItem8.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem8.Name = "layoutControlItem8";
			this.layoutControlItem8.Text = "Email";
			this.layoutControlItem8.Width = 100;
			this.layoutControlItem8.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem10.Control = this.rdoRoleDriver;
			this.layoutControlItem10.Height = 31;
			this.layoutControlItem10.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem10.Name = "layoutControlItem10";
			this.layoutControlItem10.Text = " ";
			this.layoutControlItem10.Width = 50;
			this.layoutControlItem10.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem11.Control = this.rdoRoleSupercargo;
			this.layoutControlItem11.Height = 31;
			this.layoutControlItem11.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem11.Name = "layoutControlItem11";
			this.layoutControlItem11.Width = 50;
			this.layoutControlItem11.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.BackColor = global::System.Drawing.Color.FromArgb(194, 217, 247);
			base.ClientSize = new global::System.Drawing.Size(553, 395);
			base.Controls.Add(this.groupPanel2);
			base.Controls.Add(this.groupPanel1);
			base.Controls.Add(this.bar1);
			base.Name = "frmCheckIn";
			this.Text = "frmCheckIn";
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.frmCheckIn_FormClosing);
			base.Load += new global::System.EventHandler(this.frmCheckIn_Load);
			this.groupPanel1.ResumeLayout(false);
			this.layIdentity.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.tInputBirthday).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.bar1).EndInit();
			this.groupPanel2.ResumeLayout(false);
			this.layoutControl1.ResumeLayout(false);
			this.layoutControl1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dInputWeight).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x0400082E RID: 2094
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400082F RID: 2095
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtEmailAddr;

		// Token: 0x04000830 RID: 2096
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtWeChat;

		// Token: 0x04000831 RID: 2097
		private global::DevComponents.DotNetBar.Controls.CheckBoxX rdoRoleSupercargo;

		// Token: 0x04000832 RID: 2098
		private global::DevComponents.DotNetBar.Controls.CheckBoxX rdoRoleDriver;

		// Token: 0x04000833 RID: 2099
		private global::DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;

		// Token: 0x04000834 RID: 2100
		private global::DevComponents.DotNetBar.Controls.ReflectionImage rImagePhoto;

		// Token: 0x04000835 RID: 2101
		private global::DevComponents.DotNetBar.Layout.LayoutControl layIdentity;

		// Token: 0x04000836 RID: 2102
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtAddress;

		// Token: 0x04000837 RID: 2103
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtSex;

		// Token: 0x04000838 RID: 2104
		private global::DevComponents.DotNetBar.Controls.CheckBoxX chkEnable;

		// Token: 0x04000839 RID: 2105
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtPhoneNum;

		// Token: 0x0400083A RID: 2106
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtName;

		// Token: 0x0400083B RID: 2107
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtIDCard;

		// Token: 0x0400083C RID: 2108
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem3;

		// Token: 0x0400083D RID: 2109
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem6;

		// Token: 0x0400083E RID: 2110
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem7;

		// Token: 0x0400083F RID: 2111
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem9;

		// Token: 0x04000840 RID: 2112
		private global::DevComponents.DotNetBar.Bar bar1;

		// Token: 0x04000841 RID: 2113
		private global::DevComponents.DotNetBar.ButtonItem btnSave;

		// Token: 0x04000842 RID: 2114
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtNation;

		// Token: 0x04000843 RID: 2115
		private global::DevComponents.Editors.DateTimeAdv.DateTimeInput tInputBirthday;

		// Token: 0x04000844 RID: 2116
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem1;

		// Token: 0x04000845 RID: 2117
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem2;

		// Token: 0x04000846 RID: 2118
		private global::DevComponents.DotNetBar.ButtonItem btnRead;

		// Token: 0x04000847 RID: 2119
		private global::DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;

		// Token: 0x04000848 RID: 2120
		private global::DevComponents.DotNetBar.Layout.LayoutControl layoutControl1;

		// Token: 0x04000849 RID: 2121
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem13;

		// Token: 0x0400084A RID: 2122
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem14;

		// Token: 0x0400084B RID: 2123
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem15;

		// Token: 0x0400084C RID: 2124
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem8;

		// Token: 0x0400084D RID: 2125
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem10;

		// Token: 0x0400084E RID: 2126
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem11;

		// Token: 0x0400084F RID: 2127
		private global::DevComponents.Editors.DoubleInput dInputWeight;

		// Token: 0x04000850 RID: 2128
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem12;

		// Token: 0x04000851 RID: 2129
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtValidterm;

		// Token: 0x04000852 RID: 2130
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem16;

		// Token: 0x04000853 RID: 2131
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtQualifyCode;

		// Token: 0x04000854 RID: 2132
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtDriverCode;

		// Token: 0x04000855 RID: 2133
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem4;

		// Token: 0x04000856 RID: 2134
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem5;
	}
}
