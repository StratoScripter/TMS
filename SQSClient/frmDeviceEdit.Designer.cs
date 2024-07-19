namespace SQSClient
{
	// Token: 0x02000080 RID: 128
	public partial class frmDeviceEdit : global::SQSClient.BaseDialogForm
	{
		// Token: 0x06000706 RID: 1798 RVA: 0x000AD338 File Offset: 0x000AB538
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000707 RID: 1799 RVA: 0x000AD370 File Offset: 0x000AB570
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::SQSClient.frmDeviceEdit));
			this.layoutControlItem13 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.menuBar = new global::DevComponents.DotNetBar.Bar();
			this.btnSave = new global::DevComponents.DotNetBar.ButtonItem();
			this.layoutControl1 = new global::DevComponents.DotNetBar.Layout.LayoutControl();
			this.btnPara = new global::DevComponents.DotNetBar.ButtonX();
			this.chkINTC = new global::DevComponents.DotNetBar.Controls.CheckBoxX();
			this.chkCOMC = new global::DevComponents.DotNetBar.Controls.CheckBoxX();
			this.txtServerPort = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.cmbMediaType = new global::Base.AutoComboBox();
			this.cmbProtocolType = new global::Base.AutoComboBox();
			this.iInputWays = new global::DevComponents.Editors.IntegerInput();
			this.cmbPC = new global::Base.AutoComboBox();
			this.chkState = new global::DevComponents.DotNetBar.Controls.CheckBoxX();
			this.rtbRemark = new global::DevComponents.DotNetBar.Controls.RichTextBoxEx();
			this.nudAddr = new global::DevComponents.Editors.IntegerInput();
			this.txtIP = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.cmbCOM = new global::DevComponents.DotNetBar.Controls.ComboBoxEx();
			this.txtName = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.nudDevIndex = new global::DevComponents.Editors.IntegerInput();
			this.layoutControlItem1 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem2 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem8 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem16 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem12 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem11 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layItemCOMC = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layItemINTC = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layItemMediaType = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layItemCOM = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layItemPara = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layItemIP = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layItemServerPort = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem9 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem10 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			((global::System.ComponentModel.ISupportInitialize)this.menuBar).BeginInit();
			this.layoutControl1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.iInputWays).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudAddr).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudDevIndex).BeginInit();
			base.SuspendLayout();
			this.layoutControlItem13.Height = 29;
			this.layoutControlItem13.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem13.Name = "layoutControlItem13";
			this.layoutControlItem13.Text = "设备地址：";
			this.layoutControlItem13.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem13.Width = 100;
			this.layoutControlItem13.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
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
			this.menuBar.TabIndex = 22;
			this.menuBar.TabStop = false;
			this.menuBar.Text = "Main Menu";
			this.btnSave.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.btnSave.Image = global::SQSClient.Properties.Resources.save16;
			this.btnSave.Name = "btnSave";
			this.btnSave.Text = "Save";
			this.btnSave.Click += new global::System.EventHandler(this.btnSave_Click);
			this.layoutControl1.Controls.Add(this.btnPara);
			this.layoutControl1.Controls.Add(this.chkINTC);
			this.layoutControl1.Controls.Add(this.chkCOMC);
			this.layoutControl1.Controls.Add(this.txtServerPort);
			this.layoutControl1.Controls.Add(this.cmbMediaType);
			this.layoutControl1.Controls.Add(this.cmbProtocolType);
			this.layoutControl1.Controls.Add(this.iInputWays);
			this.layoutControl1.Controls.Add(this.cmbPC);
			this.layoutControl1.Controls.Add(this.chkState);
			this.layoutControl1.Controls.Add(this.rtbRemark);
			this.layoutControl1.Controls.Add(this.nudAddr);
			this.layoutControl1.Controls.Add(this.txtIP);
			this.layoutControl1.Controls.Add(this.cmbCOM);
			this.layoutControl1.Controls.Add(this.txtName);
			this.layoutControl1.Controls.Add(this.nudDevIndex);
			this.layoutControl1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.layoutControl1.Location = new global::System.Drawing.Point(0, 26);
			this.layoutControl1.Name = "layoutControl1";
			this.layoutControl1.RootGroup.Items.AddRange(new global::DevComponents.DotNetBar.Layout.LayoutItemBase[]
			{
				this.layoutControlItem1,
				this.layoutControlItem2,
				this.layoutControlItem8,
				this.layoutControlItem16,
				this.layoutControlItem12,
				this.layoutControlItem11,
				this.layItemCOMC,
				this.layItemINTC,
				this.layItemMediaType,
				this.layItemCOM,
				this.layItemPara,
				this.layItemIP,
				this.layItemServerPort,
				this.layoutControlItem9,
				this.layoutControlItem10
			});
			this.layoutControl1.Size = new global::System.Drawing.Size(354, 381);
			this.layoutControl1.TabIndex = 23;
			this.btnPara.AccessibleRole = global::System.Windows.Forms.AccessibleRole.PushButton;
			this.btnPara.ColorTable = global::DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.btnPara.Location = new global::System.Drawing.Point(239, 235);
			this.btnPara.Margin = new global::System.Windows.Forms.Padding(0);
			this.btnPara.Name = "btnPara";
			this.btnPara.Size = new global::System.Drawing.Size(94, 23);
			this.btnPara.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.btnPara.TabIndex = 10;
			this.btnPara.Text = "SerialPortSetting";
			this.btnPara.Click += new global::System.EventHandler(this.btnPara_Click);
			this.chkINTC.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.chkINTC.CheckBoxStyle = global::DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
			this.chkINTC.Location = new global::System.Drawing.Point(260, 176);
			this.chkINTC.Margin = new global::System.Windows.Forms.Padding(0);
			this.chkINTC.Name = "chkINTC";
			this.chkINTC.Size = new global::System.Drawing.Size(73, 23);
			this.chkINTC.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.chkINTC.TabIndex = 7;
			this.chkINTC.Text = "Ethernet";
			this.chkINTC.CheckedChanged += new global::System.EventHandler(this.chkINTC_CheckedChanged);
			this.chkCOMC.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.chkCOMC.CheckBoxStyle = global::DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
			this.chkCOMC.Location = new global::System.Drawing.Point(92, 176);
			this.chkCOMC.Margin = new global::System.Windows.Forms.Padding(0);
			this.chkCOMC.Name = "chkCOMC";
			this.chkCOMC.Size = new global::System.Drawing.Size(72, 23);
			this.chkCOMC.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.chkCOMC.TabIndex = 6;
			this.chkCOMC.Text = "COM";
			this.chkCOMC.CheckedChanged += new global::System.EventHandler(this.chkCOMC_CheckedChanged);
			this.txtServerPort.Border.Class = "TextBoxBorder";
			this.txtServerPort.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtServerPort.Location = new global::System.Drawing.Point(92, 295);
			this.txtServerPort.Margin = new global::System.Windows.Forms.Padding(0);
			this.txtServerPort.Name = "txtServerPort";
			this.txtServerPort.PreventEnterBeep = true;
			this.txtServerPort.Size = new global::System.Drawing.Size(241, 21);
			this.txtServerPort.TabIndex = 12;
			this.cmbMediaType.DataSource = null;
			this.cmbMediaType.DisplayMember = null;
			this.cmbMediaType.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cmbMediaType.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbMediaType.FormattingEnabled = true;
			this.cmbMediaType.ItemHeight = 16;
			this.cmbMediaType.Location = new global::System.Drawing.Point(92, 207);
			this.cmbMediaType.Margin = new global::System.Windows.Forms.Padding(0);
			this.cmbMediaType.MaxDropDownItems = 20;
			this.cmbMediaType.Name = "cmbMediaType";
			this.cmbMediaType.SelectMember = null;
			this.cmbMediaType.Size = new global::System.Drawing.Size(241, 22);
			this.cmbMediaType.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.cmbMediaType.TabIndex = 8;
			this.cmbMediaType.ValueMember = null;
			this.cmbProtocolType.DataSource = null;
			this.cmbProtocolType.DisplayMember = null;
			this.cmbProtocolType.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cmbProtocolType.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbProtocolType.FormattingEnabled = true;
			this.cmbProtocolType.ItemHeight = 16;
			this.cmbProtocolType.Location = new global::System.Drawing.Point(92, 148);
			this.cmbProtocolType.Margin = new global::System.Windows.Forms.Padding(0);
			this.cmbProtocolType.MaxDropDownItems = 20;
			this.cmbProtocolType.Name = "cmbProtocolType";
			this.cmbProtocolType.SelectMember = null;
			this.cmbProtocolType.Size = new global::System.Drawing.Size(241, 22);
			this.cmbProtocolType.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.cmbProtocolType.TabIndex = 5;
			this.cmbProtocolType.ValueMember = null;
			this.cmbProtocolType.TextChanged += new global::System.EventHandler(this.cmbProtocolType_TextChanged);
			this.iInputWays.BackgroundStyle.Class = "DateTimeInputBackground";
			this.iInputWays.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.iInputWays.ButtonFreeText.Shortcut = global::DevComponents.DotNetBar.eShortcut.F2;
			this.iInputWays.InputHorizontalAlignment = global::DevComponents.Editors.eHorizontalAlignment.Left;
			this.iInputWays.Location = new global::System.Drawing.Point(92, 91);
			this.iInputWays.Margin = new global::System.Windows.Forms.Padding(0);
			this.iInputWays.MaxValue = 4;
			this.iInputWays.MinValue = 1;
			this.iInputWays.Name = "iInputWays";
			this.iInputWays.ShowUpDown = true;
			this.iInputWays.Size = new global::System.Drawing.Size(241, 21);
			this.iInputWays.TabIndex = 3;
			this.iInputWays.Value = 1;
			this.cmbPC.DataSource = null;
			this.cmbPC.DisplayMember = null;
			this.cmbPC.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cmbPC.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbPC.FormattingEnabled = true;
			this.cmbPC.ItemHeight = 15;
			this.cmbPC.Location = new global::System.Drawing.Point(92, 120);
			this.cmbPC.Margin = new global::System.Windows.Forms.Padding(0);
			this.cmbPC.MaxDropDownItems = 20;
			this.cmbPC.Name = "cmbPC";
			this.cmbPC.SelectMember = null;
			this.cmbPC.Size = new global::System.Drawing.Size(241, 21);
			this.cmbPC.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.cmbPC.TabIndex = 4;
			this.cmbPC.ValueMember = null;
			this.chkState.AutoSize = true;
			this.chkState.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.chkState.Checked = true;
			this.chkState.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.chkState.CheckValue = "Y";
			this.chkState.Location = new global::System.Drawing.Point(92, 384);
			this.chkState.Margin = new global::System.Windows.Forms.Padding(0);
			this.chkState.Name = "chkState";
			this.chkState.Size = new global::System.Drawing.Size(64, 16);
			this.chkState.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.chkState.TabIndex = 14;
			this.chkState.Text = "Enable";
			this.rtbRemark.BackgroundStyle.Class = "RichTextBoxBorder";
			this.rtbRemark.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.rtbRemark.Location = new global::System.Drawing.Point(92, 324);
			this.rtbRemark.Margin = new global::System.Windows.Forms.Padding(0);
			this.rtbRemark.MaxLength = 200;
			this.rtbRemark.Name = "rtbRemark";
			this.rtbRemark.Rtf = "{\\rtf1\\ansi\\ansicpg936\\deff0\\deflang1033\\deflangfe2052{\\fonttbl{\\f0\\fnil\\fcharset134 \\'cb\\'ce\\'cc\\'e5;}}\r\n\\viewkind4\\uc1\\pard\\lang2052\\f0\\fs18\\par\r\n}\r\n";
			this.rtbRemark.Size = new global::System.Drawing.Size(241, 52);
			this.rtbRemark.TabIndex = 13;
			this.nudAddr.BackgroundStyle.Class = "DateTimeInputBackground";
			this.nudAddr.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.nudAddr.ButtonFreeText.Shortcut = global::DevComponents.DotNetBar.eShortcut.F2;
			this.nudAddr.InputHorizontalAlignment = global::DevComponents.Editors.eHorizontalAlignment.Left;
			this.nudAddr.Location = new global::System.Drawing.Point(92, 62);
			this.nudAddr.Margin = new global::System.Windows.Forms.Padding(0);
			this.nudAddr.MaxValue = 254;
			this.nudAddr.MinValue = 1;
			this.nudAddr.Name = "nudAddr";
			this.nudAddr.ShowUpDown = true;
			this.nudAddr.Size = new global::System.Drawing.Size(241, 21);
			this.nudAddr.TabIndex = 2;
			this.nudAddr.Value = 1;
			this.txtIP.Border.Class = "TextBoxBorder";
			this.txtIP.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtIP.Location = new global::System.Drawing.Point(92, 266);
			this.txtIP.Margin = new global::System.Windows.Forms.Padding(0);
			this.txtIP.MaxLength = 20;
			this.txtIP.Name = "txtIP";
			this.txtIP.PreventEnterBeep = true;
			this.txtIP.Size = new global::System.Drawing.Size(241, 21);
			this.txtIP.TabIndex = 11;
			this.cmbCOM.DisplayMember = "Text";
			this.cmbCOM.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cmbCOM.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbCOM.FormattingEnabled = true;
			this.cmbCOM.ItemHeight = 16;
			this.cmbCOM.Location = new global::System.Drawing.Point(92, 235);
			this.cmbCOM.Margin = new global::System.Windows.Forms.Padding(0);
			this.cmbCOM.Name = "cmbCOM";
			this.cmbCOM.Size = new global::System.Drawing.Size(139, 22);
			this.cmbCOM.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.cmbCOM.TabIndex = 9;
			this.txtName.Border.Class = "TextBoxBorder";
			this.txtName.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtName.Location = new global::System.Drawing.Point(92, 4);
			this.txtName.Margin = new global::System.Windows.Forms.Padding(0);
			this.txtName.MaxLength = 20;
			this.txtName.Name = "txtName";
			this.txtName.PreventEnterBeep = true;
			this.txtName.Size = new global::System.Drawing.Size(241, 21);
			this.txtName.TabIndex = 0;
			this.nudDevIndex.BackgroundStyle.Class = "DateTimeInputBackground";
			this.nudDevIndex.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.nudDevIndex.ButtonFreeText.Shortcut = global::DevComponents.DotNetBar.eShortcut.F2;
			this.nudDevIndex.InputHorizontalAlignment = global::DevComponents.Editors.eHorizontalAlignment.Left;
			this.nudDevIndex.Location = new global::System.Drawing.Point(92, 33);
			this.nudDevIndex.Margin = new global::System.Windows.Forms.Padding(0);
			this.nudDevIndex.MaxValue = 999;
			this.nudDevIndex.MinValue = 1;
			this.nudDevIndex.Name = "nudDevIndex";
			this.nudDevIndex.ShowUpDown = true;
			this.nudDevIndex.Size = new global::System.Drawing.Size(241, 21);
			this.nudDevIndex.TabIndex = 1;
			this.nudDevIndex.Value = 1;
			this.layoutControlItem1.Control = this.txtName;
			this.layoutControlItem1.Height = 29;
			this.layoutControlItem1.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Text = "*DeviceName";
			this.layoutControlItem1.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem1.Width = 100;
			this.layoutControlItem1.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem2.Control = this.nudDevIndex;
			this.layoutControlItem2.Height = 29;
			this.layoutControlItem2.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem2.Name = "layoutControlItem2";
			this.layoutControlItem2.Text = "*DeviceNum";
			this.layoutControlItem2.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem2.Width = 100;
			this.layoutControlItem2.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem8.Control = this.nudAddr;
			this.layoutControlItem8.Height = 29;
			this.layoutControlItem8.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem8.Name = "layoutControlItem8";
			this.layoutControlItem8.Text = "*DeviceAddr";
			this.layoutControlItem8.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem8.Width = 100;
			this.layoutControlItem8.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem16.Control = this.iInputWays;
			this.layoutControlItem16.Height = 29;
			this.layoutControlItem16.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem16.Name = "layoutControlItem16";
			this.layoutControlItem16.Text = "Ways";
			this.layoutControlItem16.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem16.Width = 100;
			this.layoutControlItem16.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem12.Control = this.cmbPC;
			this.layoutControlItem12.Height = 28;
			this.layoutControlItem12.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem12.Name = "layoutControlItem12";
			this.layoutControlItem12.Text = "*Server";
			this.layoutControlItem12.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem12.Width = 129;
			this.layoutControlItem12.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem11.Control = this.cmbProtocolType;
			this.layoutControlItem11.Height = 28;
			this.layoutControlItem11.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem11.Name = "layoutControlItem11";
			this.layoutControlItem11.Text = "*CommType";
			this.layoutControlItem11.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem11.Width = 100;
			this.layoutControlItem11.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layItemCOMC.Control = this.chkCOMC;
			this.layItemCOMC.Height = 31;
			this.layItemCOMC.MinSize = new global::System.Drawing.Size(64, 18);
			this.layItemCOMC.Name = "layItemCOMC";
			this.layItemCOMC.Text = " ";
			this.layItemCOMC.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layItemCOMC.Visible = false;
			this.layItemCOMC.Width = 50;
			this.layItemCOMC.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layItemINTC.Control = this.chkINTC;
			this.layItemINTC.Height = 31;
			this.layItemINTC.MinSize = new global::System.Drawing.Size(64, 18);
			this.layItemINTC.Name = "layItemINTC";
			this.layItemINTC.Text = " ";
			this.layItemINTC.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layItemINTC.Visible = false;
			this.layItemINTC.Width = 50;
			this.layItemINTC.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layItemMediaType.Control = this.cmbMediaType;
			this.layItemMediaType.Height = 28;
			this.layItemMediaType.MinSize = new global::System.Drawing.Size(64, 18);
			this.layItemMediaType.Name = "layItemMediaType";
			this.layItemMediaType.Text = "*CommProtocol";
			this.layItemMediaType.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layItemMediaType.Visible = false;
			this.layItemMediaType.Width = 100;
			this.layItemMediaType.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layItemCOM.Control = this.cmbCOM;
			this.layItemCOM.Height = 28;
			this.layItemCOM.MinSize = new global::System.Drawing.Size(64, 18);
			this.layItemCOM.Name = "layItemCOM";
			this.layItemCOM.Text = "*COMName";
			this.layItemCOM.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layItemCOM.Visible = false;
			this.layItemCOM.Width = 70;
			this.layItemCOM.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layItemPara.Control = this.btnPara;
			this.layItemPara.Height = 31;
			this.layItemPara.MinSize = new global::System.Drawing.Size(32, 20);
			this.layItemPara.Name = "layItemPara";
			this.layItemPara.Visible = false;
			this.layItemPara.Width = 30;
			this.layItemPara.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layItemIP.Control = this.txtIP;
			this.layItemIP.Height = 29;
			this.layItemIP.MinSize = new global::System.Drawing.Size(120, 0);
			this.layItemIP.Name = "layItemIP";
			this.layItemIP.Text = "*IP";
			this.layItemIP.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layItemIP.Visible = false;
			this.layItemIP.Width = 100;
			this.layItemIP.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layItemServerPort.Control = this.txtServerPort;
			this.layItemServerPort.Height = 29;
			this.layItemServerPort.MinSize = new global::System.Drawing.Size(120, 0);
			this.layItemServerPort.Name = "layItemServerPort";
			this.layItemServerPort.Text = "*ServerPort";
			this.layItemServerPort.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layItemServerPort.Visible = false;
			this.layItemServerPort.Width = 100;
			this.layItemServerPort.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem9.Control = this.rtbRemark;
			this.layoutControlItem9.Height = 60;
			this.layoutControlItem9.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem9.Name = "layoutControlItem9";
			this.layoutControlItem9.Text = "Remark";
			this.layoutControlItem9.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem9.Width = 100;
			this.layoutControlItem9.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem10.Control = this.chkState;
			this.layoutControlItem10.Height = 31;
			this.layoutControlItem10.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem10.Name = "layoutControlItem10";
			this.layoutControlItem10.Text = " ";
			this.layoutControlItem10.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem10.Width = 100;
			this.layoutControlItem10.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			base.ClientSize = new global::System.Drawing.Size(354, 407);
			base.Controls.Add(this.layoutControl1);
			base.Controls.Add(this.menuBar);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "frmDeviceEdit";
			this.Text = "frmDeviceEdit";
			base.Load += new global::System.EventHandler(this.frmDeviceEdit_Load);
			((global::System.ComponentModel.ISupportInitialize)this.menuBar).EndInit();
			this.layoutControl1.ResumeLayout(false);
			this.layoutControl1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.iInputWays).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudAddr).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudDevIndex).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000BE8 RID: 3048
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000BE9 RID: 3049
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem13;

		// Token: 0x04000BEA RID: 3050
		private global::DevComponents.DotNetBar.Bar menuBar;

		// Token: 0x04000BEB RID: 3051
		private global::DevComponents.DotNetBar.ButtonItem btnSave;

		// Token: 0x04000BEC RID: 3052
		private global::DevComponents.DotNetBar.Layout.LayoutControl layoutControl1;

		// Token: 0x04000BED RID: 3053
		private global::DevComponents.Editors.IntegerInput iInputWays;

		// Token: 0x04000BEE RID: 3054
		private global::Base.AutoComboBox cmbPC;

		// Token: 0x04000BEF RID: 3055
		private global::DevComponents.DotNetBar.Controls.CheckBoxX chkState;

		// Token: 0x04000BF0 RID: 3056
		private global::DevComponents.DotNetBar.Controls.RichTextBoxEx rtbRemark;

		// Token: 0x04000BF1 RID: 3057
		private global::DevComponents.Editors.IntegerInput nudAddr;

		// Token: 0x04000BF2 RID: 3058
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtIP;

		// Token: 0x04000BF3 RID: 3059
		private global::DevComponents.DotNetBar.Controls.ComboBoxEx cmbCOM;

		// Token: 0x04000BF4 RID: 3060
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtName;

		// Token: 0x04000BF5 RID: 3061
		private global::DevComponents.Editors.IntegerInput nudDevIndex;

		// Token: 0x04000BF6 RID: 3062
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem1;

		// Token: 0x04000BF7 RID: 3063
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem2;

		// Token: 0x04000BF8 RID: 3064
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem12;

		// Token: 0x04000BF9 RID: 3065
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem16;

		// Token: 0x04000BFA RID: 3066
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layItemCOM;

		// Token: 0x04000BFB RID: 3067
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layItemIP;

		// Token: 0x04000BFC RID: 3068
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem8;

		// Token: 0x04000BFD RID: 3069
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem9;

		// Token: 0x04000BFE RID: 3070
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem10;

		// Token: 0x04000BFF RID: 3071
		private global::Base.AutoComboBox cmbProtocolType;

		// Token: 0x04000C00 RID: 3072
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem11;

		// Token: 0x04000C01 RID: 3073
		private global::Base.AutoComboBox cmbMediaType;

		// Token: 0x04000C02 RID: 3074
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layItemMediaType;

		// Token: 0x04000C03 RID: 3075
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtServerPort;

		// Token: 0x04000C04 RID: 3076
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layItemServerPort;

		// Token: 0x04000C05 RID: 3077
		private global::DevComponents.DotNetBar.ButtonX btnPara;

		// Token: 0x04000C06 RID: 3078
		private global::DevComponents.DotNetBar.Controls.CheckBoxX chkINTC;

		// Token: 0x04000C07 RID: 3079
		private global::DevComponents.DotNetBar.Controls.CheckBoxX chkCOMC;

		// Token: 0x04000C08 RID: 3080
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layItemCOMC;

		// Token: 0x04000C09 RID: 3081
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layItemINTC;

		// Token: 0x04000C0A RID: 3082
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layItemPara;
	}
}
