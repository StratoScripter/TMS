namespace SQSClient
{
	// Token: 0x02000092 RID: 146
	public partial class frmTruckEdit : global::SQSClient.BaseDialogForm
	{
		// Token: 0x06000815 RID: 2069 RVA: 0x000C899C File Offset: 0x000C6B9C
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000816 RID: 2070 RVA: 0x000C89D4 File Offset: 0x000C6BD4
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::SQSClient.frmTruckEdit));
			this.rtbRemark = new global::DevComponents.DotNetBar.Controls.RichTextBoxEx();
			this.bar1 = new global::DevComponents.DotNetBar.Bar();
			this.btnSave = new global::DevComponents.DotNetBar.ButtonItem();
			this.btnAddType = new global::DevComponents.DotNetBar.ButtonItem();
			this.btnAddPeople = new global::DevComponents.DotNetBar.ButtonItem();
			this.groupPanel4 = new global::DevComponents.DotNetBar.Controls.GroupPanel();
			this.layCoach = new global::DevComponents.DotNetBar.Layout.LayoutControl();
			this.txtCTransportCode = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.txtLTransportCode = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.dInputLoadWeight = new global::DevComponents.Editors.DoubleInput();
			this.cmbProduct = new global::Base.AutoComboBox();
			this.txtSubUnit = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.txtSupercargoID = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.txtDriverID = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.dInputWeight = new global::DevComponents.Editors.DoubleInput();
			this.txtLisence = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.txtCoachNum = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.dInputNetWeight = new global::DevComponents.Editors.DoubleInput();
			this.dInputFactor = new global::DevComponents.Editors.DoubleInput();
			this.cmbType = new global::Base.AutoComboBox();
			this.iInputCangShu = new global::DevComponents.Editors.IntegerInput();
			this.tInputValidDate = new global::DevComponents.Editors.DateTimeAdv.DateTimeInput();
			this.dInputVol = new global::DevComponents.Editors.DoubleInput();
			this.cmbCreditType = new global::Base.AutoComboBox();
			this.layoutControlItem5 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem18 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem4 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem8 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem1 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem19 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem30 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem12 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem32 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem33 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem13 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem34 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem39 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem15 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem27 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem38 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem2 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem14 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.groupPanel1 = new global::DevComponents.DotNetBar.Controls.GroupPanel();
			this.rImageDPhoto = new global::DevComponents.DotNetBar.Controls.ReflectionImage();
			this.layoutControl3 = new global::DevComponents.DotNetBar.Layout.LayoutControl();
			this.txtDAddress = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.txtDSex = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.chkDEnable = new global::DevComponents.DotNetBar.Controls.CheckBoxX();
			this.txtDPhoneNum = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.dInputDWeight = new global::DevComponents.Editors.DoubleInput();
			this.txtDName = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.txtDIDCard = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.layoutControlItem3 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem20 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem6 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem7 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem9 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem17 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem16 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.groupPanel2 = new global::DevComponents.DotNetBar.Controls.GroupPanel();
			this.layoutControl1 = new global::DevComponents.DotNetBar.Layout.LayoutControl();
			this.txtSAddress = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.txtSSex = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.chkSEnable = new global::DevComponents.DotNetBar.Controls.CheckBoxX();
			this.txtSPhoneNum = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.dInputSWeight = new global::DevComponents.Editors.DoubleInput();
			this.txtSName = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.txtSIDCard = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.layoutControlItem21 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem22 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem10 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem23 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem11 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem26 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem25 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.rImageSPhoto = new global::DevComponents.DotNetBar.Controls.ReflectionImage();
			this.layoutControlItem24 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem28 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.cmbSpecialStepType = new global::Base.AutoComboBox();
			this.layoutControlItem29 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			((global::System.ComponentModel.ISupportInitialize)this.bar1).BeginInit();
			this.groupPanel4.SuspendLayout();
			this.layCoach.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dInputLoadWeight).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.dInputWeight).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.dInputNetWeight).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.dInputFactor).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.iInputCangShu).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.tInputValidDate).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.dInputVol).BeginInit();
			this.groupPanel1.SuspendLayout();
			this.layoutControl3.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dInputDWeight).BeginInit();
			this.groupPanel2.SuspendLayout();
			this.layoutControl1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dInputSWeight).BeginInit();
			base.SuspendLayout();
			this.rtbRemark.BackgroundStyle.Class = "RichTextBoxBorder";
			this.rtbRemark.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.rtbRemark.Location = new global::System.Drawing.Point(104, 294);
			this.rtbRemark.Margin = new global::System.Windows.Forms.Padding(0);
			this.rtbRemark.MaxLength = 200;
			this.rtbRemark.Name = "rtbRemark";
			this.rtbRemark.Rtf = "{\\rtf1\\ansi\\ansicpg936\\deff0\\nouicompat\\deflang1033\\deflangfe2052{\\fonttbl{\\f0\\fnil\\fcharset134 \\'cb\\'ce\\'cc\\'e5;}}\r\n{\\*\\generator Riched20 10.0.22000}\\viewkind4\\uc1 \r\n\\pard\\f0\\fs18\\lang2052\\par\r\n}\r\n";
			this.rtbRemark.Size = new global::System.Drawing.Size(378, 36);
			this.rtbRemark.TabIndex = 18;
			this.bar1.AccessibleDescription = "DotNetBar Bar (bar1)";
			this.bar1.AccessibleName = "DotNetBar Bar";
			this.bar1.AccessibleRole = global::System.Windows.Forms.AccessibleRole.MenuBar;
			this.bar1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.bar1.Font = new global::System.Drawing.Font("微软雅黑", 9f);
			this.bar1.IsMaximized = false;
			this.bar1.Items.AddRange(new global::DevComponents.DotNetBar.BaseItem[]
			{
				this.btnSave,
				this.btnAddType,
				this.btnAddPeople
			});
			this.bar1.Location = new global::System.Drawing.Point(0, 0);
			this.bar1.MenuBar = true;
			this.bar1.Name = "bar1";
			this.bar1.Size = new global::System.Drawing.Size(492, 26);
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
			this.btnAddType.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.btnAddType.Image = global::SQSClient.Properties.Resources.add16;
			this.btnAddType.ItemAlignment = global::DevComponents.DotNetBar.eItemAlignment.Far;
			this.btnAddType.Name = "btnAddType";
			this.btnAddType.Text = "AddType";
			this.btnAddType.Click += new global::System.EventHandler(this.btnAddType_Click);
			this.btnAddPeople.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.btnAddPeople.Image = global::SQSClient.Properties.Resources.add16;
			this.btnAddPeople.Name = "btnAddPeople";
			this.btnAddPeople.Text = "AddPeople";
			this.btnAddPeople.Click += new global::System.EventHandler(this.btnAddPeople_Click);
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
			this.groupPanel4.Size = new global::System.Drawing.Size(492, 368);
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
			this.layCoach.Controls.Add(this.txtCTransportCode);
			this.layCoach.Controls.Add(this.txtLTransportCode);
			this.layCoach.Controls.Add(this.dInputLoadWeight);
			this.layCoach.Controls.Add(this.cmbProduct);
			this.layCoach.Controls.Add(this.txtSubUnit);
			this.layCoach.Controls.Add(this.txtSupercargoID);
			this.layCoach.Controls.Add(this.txtDriverID);
			this.layCoach.Controls.Add(this.dInputWeight);
			this.layCoach.Controls.Add(this.txtLisence);
			this.layCoach.Controls.Add(this.txtCoachNum);
			this.layCoach.Controls.Add(this.dInputNetWeight);
			this.layCoach.Controls.Add(this.dInputFactor);
			this.layCoach.Controls.Add(this.cmbType);
			this.layCoach.Controls.Add(this.iInputCangShu);
			this.layCoach.Controls.Add(this.tInputValidDate);
			this.layCoach.Controls.Add(this.dInputVol);
			this.layCoach.Controls.Add(this.rtbRemark);
			this.layCoach.Controls.Add(this.cmbCreditType);
			this.layCoach.Controls.Add(this.cmbSpecialStepType);
			this.layCoach.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.layCoach.Location = new global::System.Drawing.Point(0, 0);
			this.layCoach.Name = "layCoach";
			this.layCoach.RootGroup.Items.AddRange(new global::DevComponents.DotNetBar.Layout.LayoutItemBase[]
			{
				this.layoutControlItem5,
				this.layoutControlItem18,
				this.layoutControlItem4,
				this.layoutControlItem8,
				this.layoutControlItem1,
				this.layoutControlItem19,
				this.layoutControlItem30,
				this.layoutControlItem12,
				this.layoutControlItem32,
				this.layoutControlItem33,
				this.layoutControlItem13,
				this.layoutControlItem34,
				this.layoutControlItem39,
				this.layoutControlItem15,
				this.layoutControlItem27,
				this.layoutControlItem38,
				this.layoutControlItem2,
				this.layoutControlItem29,
				this.layoutControlItem14
			});
			this.layCoach.Size = new global::System.Drawing.Size(486, 346);
			this.layCoach.TabIndex = 0;
			this.txtCTransportCode.Border.Class = "TextBoxBorder";
			this.txtCTransportCode.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtCTransportCode.Location = new global::System.Drawing.Point(347, 62);
			this.txtCTransportCode.Margin = new global::System.Windows.Forms.Padding(0);
			this.txtCTransportCode.Name = "txtCTransportCode";
			this.txtCTransportCode.PreventEnterBeep = true;
			this.txtCTransportCode.Size = new global::System.Drawing.Size(135, 21);
			this.txtCTransportCode.TabIndex = 5;
			this.txtLTransportCode.Border.Class = "TextBoxBorder";
			this.txtLTransportCode.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtLTransportCode.Location = new global::System.Drawing.Point(347, 4);
			this.txtLTransportCode.Margin = new global::System.Windows.Forms.Padding(0);
			this.txtLTransportCode.Name = "txtLTransportCode";
			this.txtLTransportCode.PreventEnterBeep = true;
			this.txtLTransportCode.Size = new global::System.Drawing.Size(135, 21);
			this.txtLTransportCode.TabIndex = 1;
			this.dInputLoadWeight.BackgroundStyle.Class = "DateTimeInputBackground";
			this.dInputLoadWeight.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.dInputLoadWeight.ButtonFreeText.Shortcut = global::DevComponents.DotNetBar.eShortcut.F2;
			this.dInputLoadWeight.Increment = 1.0;
			this.dInputLoadWeight.InputHorizontalAlignment = global::DevComponents.Editors.eHorizontalAlignment.Left;
			this.dInputLoadWeight.Location = new global::System.Drawing.Point(347, 178);
			this.dInputLoadWeight.Margin = new global::System.Windows.Forms.Padding(0);
			this.dInputLoadWeight.Name = "dInputLoadWeight";
			this.dInputLoadWeight.ShowUpDown = true;
			this.dInputLoadWeight.Size = new global::System.Drawing.Size(135, 21);
			this.dInputLoadWeight.TabIndex = 13;
			this.dInputLoadWeight.ValueChanged += new global::System.EventHandler(this.dInputLoadWeight_ValueChanged);
			this.cmbProduct.DataSource = null;
			this.cmbProduct.DisplayMember = null;
			this.cmbProduct.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cmbProduct.FormattingEnabled = true;
			this.cmbProduct.ItemHeight = 15;
			this.cmbProduct.Location = new global::System.Drawing.Point(104, 149);
			this.cmbProduct.Margin = new global::System.Windows.Forms.Padding(0);
			this.cmbProduct.MaxDropDownItems = 20;
			this.cmbProduct.Name = "cmbProduct";
			this.cmbProduct.SelectMember = null;
			this.cmbProduct.Size = new global::System.Drawing.Size(135, 21);
			this.cmbProduct.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.cmbProduct.TabIndex = 10;
			this.cmbProduct.ValueMember = null;
			this.txtSubUnit.Border.Class = "TextBoxBorder";
			this.txtSubUnit.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtSubUnit.Location = new global::System.Drawing.Point(104, 236);
			this.txtSubUnit.Margin = new global::System.Windows.Forms.Padding(0);
			this.txtSubUnit.Name = "txtSubUnit";
			this.txtSubUnit.PreventEnterBeep = true;
			this.txtSubUnit.Size = new global::System.Drawing.Size(378, 21);
			this.txtSubUnit.TabIndex = 16;
			this.txtSupercargoID.Border.Class = "TextBoxBorder";
			this.txtSupercargoID.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtSupercargoID.Location = new global::System.Drawing.Point(347, 33);
			this.txtSupercargoID.Margin = new global::System.Windows.Forms.Padding(0);
			this.txtSupercargoID.Name = "txtSupercargoID";
			this.txtSupercargoID.PreventEnterBeep = true;
			this.txtSupercargoID.Size = new global::System.Drawing.Size(135, 21);
			this.txtSupercargoID.TabIndex = 3;
			this.txtSupercargoID.TextChanged += new global::System.EventHandler(this.txtSupercargoID_TextChanged);
			this.txtDriverID.Border.Class = "TextBoxBorder";
			this.txtDriverID.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtDriverID.Location = new global::System.Drawing.Point(104, 33);
			this.txtDriverID.Margin = new global::System.Windows.Forms.Padding(0);
			this.txtDriverID.Name = "txtDriverID";
			this.txtDriverID.PreventEnterBeep = true;
			this.txtDriverID.Size = new global::System.Drawing.Size(135, 21);
			this.txtDriverID.TabIndex = 2;
			this.txtDriverID.TextChanged += new global::System.EventHandler(this.txtDriverID_TextChanged);
			this.dInputWeight.BackgroundStyle.Class = "DateTimeInputBackground";
			this.dInputWeight.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.dInputWeight.ButtonFreeText.Shortcut = global::DevComponents.DotNetBar.eShortcut.F2;
			this.dInputWeight.Increment = 1.0;
			this.dInputWeight.InputHorizontalAlignment = global::DevComponents.Editors.eHorizontalAlignment.Left;
			this.dInputWeight.Location = new global::System.Drawing.Point(347, 91);
			this.dInputWeight.Margin = new global::System.Windows.Forms.Padding(0);
			this.dInputWeight.MaxValue = 65535.0;
			this.dInputWeight.MinValue = 0.0;
			this.dInputWeight.Name = "dInputWeight";
			this.dInputWeight.ShowUpDown = true;
			this.dInputWeight.Size = new global::System.Drawing.Size(135, 21);
			this.dInputWeight.TabIndex = 7;
			this.dInputWeight.ValueChanged += new global::System.EventHandler(this.dInputWeight_ValueChanged);
			this.txtLisence.Border.Class = "TextBoxBorder";
			this.txtLisence.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtLisence.Location = new global::System.Drawing.Point(104, 4);
			this.txtLisence.Margin = new global::System.Windows.Forms.Padding(0);
			this.txtLisence.Name = "txtLisence";
			this.txtLisence.PreventEnterBeep = true;
			this.txtLisence.Size = new global::System.Drawing.Size(135, 21);
			this.txtLisence.TabIndex = 0;
			this.txtCoachNum.Border.Class = "TextBoxBorder";
			this.txtCoachNum.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtCoachNum.Location = new global::System.Drawing.Point(104, 62);
			this.txtCoachNum.Margin = new global::System.Windows.Forms.Padding(0);
			this.txtCoachNum.Name = "txtCoachNum";
			this.txtCoachNum.PreventEnterBeep = true;
			this.txtCoachNum.Size = new global::System.Drawing.Size(135, 21);
			this.txtCoachNum.TabIndex = 4;
			this.dInputNetWeight.BackgroundStyle.Class = "DateTimeInputBackground";
			this.dInputNetWeight.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.dInputNetWeight.ButtonFreeText.Shortcut = global::DevComponents.DotNetBar.eShortcut.F2;
			this.dInputNetWeight.Increment = 1.0;
			this.dInputNetWeight.InputHorizontalAlignment = global::DevComponents.Editors.eHorizontalAlignment.Left;
			this.dInputNetWeight.Location = new global::System.Drawing.Point(347, 149);
			this.dInputNetWeight.Margin = new global::System.Windows.Forms.Padding(0);
			this.dInputNetWeight.MinValue = 0.0;
			this.dInputNetWeight.Name = "dInputNetWeight";
			this.dInputNetWeight.ShowUpDown = true;
			this.dInputNetWeight.Size = new global::System.Drawing.Size(135, 21);
			this.dInputNetWeight.TabIndex = 11;
			this.dInputNetWeight.ValueChanged += new global::System.EventHandler(this.dInputNetWeight_ValueChanged);
			this.dInputFactor.BackgroundStyle.Class = "DateTimeInputBackground";
			this.dInputFactor.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.dInputFactor.ButtonFreeText.Shortcut = global::DevComponents.DotNetBar.eShortcut.F2;
			this.dInputFactor.DisplayFormat = "0.0000";
			this.dInputFactor.Enabled = false;
			this.dInputFactor.Increment = 1.0;
			this.dInputFactor.InputHorizontalAlignment = global::DevComponents.Editors.eHorizontalAlignment.Left;
			this.dInputFactor.Location = new global::System.Drawing.Point(347, 120);
			this.dInputFactor.Margin = new global::System.Windows.Forms.Padding(0);
			this.dInputFactor.Name = "dInputFactor";
			this.dInputFactor.ShowUpDown = true;
			this.dInputFactor.Size = new global::System.Drawing.Size(135, 21);
			this.dInputFactor.TabIndex = 9;
			this.cmbType.DataSource = null;
			this.cmbType.DisplayMember = null;
			this.cmbType.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cmbType.FormattingEnabled = true;
			this.cmbType.ItemHeight = 15;
			this.cmbType.Location = new global::System.Drawing.Point(104, 91);
			this.cmbType.Margin = new global::System.Windows.Forms.Padding(0);
			this.cmbType.MaxDropDownItems = 20;
			this.cmbType.Name = "cmbType";
			this.cmbType.SelectMember = null;
			this.cmbType.Size = new global::System.Drawing.Size(135, 21);
			this.cmbType.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.cmbType.TabIndex = 6;
			this.cmbType.ValueMember = null;
			this.cmbType.TextChanged += new global::System.EventHandler(this.cmbType_TextChanged);
			this.iInputCangShu.BackgroundStyle.Class = "DateTimeInputBackground";
			this.iInputCangShu.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.iInputCangShu.ButtonFreeText.Shortcut = global::DevComponents.DotNetBar.eShortcut.F2;
			this.iInputCangShu.InputHorizontalAlignment = global::DevComponents.Editors.eHorizontalAlignment.Left;
			this.iInputCangShu.Location = new global::System.Drawing.Point(347, 207);
			this.iInputCangShu.Margin = new global::System.Windows.Forms.Padding(0);
			this.iInputCangShu.MaxValue = 10;
			this.iInputCangShu.MinValue = 1;
			this.iInputCangShu.Name = "iInputCangShu";
			this.iInputCangShu.ShowUpDown = true;
			this.iInputCangShu.Size = new global::System.Drawing.Size(135, 21);
			this.iInputCangShu.TabIndex = 15;
			this.iInputCangShu.Value = 1;
			this.tInputValidDate.BackgroundStyle.Class = "DateTimeInputBackground";
			this.tInputValidDate.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.tInputValidDate.ButtonDropDown.Shortcut = global::DevComponents.DotNetBar.eShortcut.AltDown;
			this.tInputValidDate.ButtonDropDown.Visible = true;
			this.tInputValidDate.IsPopupCalendarOpen = false;
			this.tInputValidDate.Location = new global::System.Drawing.Point(104, 178);
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
			this.tInputValidDate.Size = new global::System.Drawing.Size(135, 21);
			this.tInputValidDate.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.tInputValidDate.TabIndex = 12;
			this.dInputVol.BackgroundStyle.Class = "DateTimeInputBackground";
			this.dInputVol.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.dInputVol.ButtonFreeText.Shortcut = global::DevComponents.DotNetBar.eShortcut.F2;
			this.dInputVol.Increment = 1.0;
			this.dInputVol.InputHorizontalAlignment = global::DevComponents.Editors.eHorizontalAlignment.Left;
			this.dInputVol.Location = new global::System.Drawing.Point(104, 120);
			this.dInputVol.Margin = new global::System.Windows.Forms.Padding(0);
			this.dInputVol.MaxValue = 65535.0;
			this.dInputVol.MinValue = 0.0;
			this.dInputVol.Name = "dInputVol";
			this.dInputVol.ShowUpDown = true;
			this.dInputVol.Size = new global::System.Drawing.Size(135, 21);
			this.dInputVol.TabIndex = 8;
			this.cmbCreditType.DataSource = null;
			this.cmbCreditType.DisplayMember = null;
			this.cmbCreditType.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cmbCreditType.FormattingEnabled = true;
			this.cmbCreditType.ItemHeight = 15;
			this.cmbCreditType.Location = new global::System.Drawing.Point(104, 207);
			this.cmbCreditType.Margin = new global::System.Windows.Forms.Padding(0);
			this.cmbCreditType.MaxDropDownItems = 20;
			this.cmbCreditType.Name = "cmbCreditType";
			this.cmbCreditType.SelectMember = null;
			this.cmbCreditType.Size = new global::System.Drawing.Size(135, 21);
			this.cmbCreditType.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.cmbCreditType.TabIndex = 14;
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
			this.layoutControlItem4.Control = this.txtDriverID;
			this.layoutControlItem4.Height = 29;
			this.layoutControlItem4.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem4.Name = "layoutControlItem4";
			this.layoutControlItem4.Text = "Driver";
			this.layoutControlItem4.Width = 50;
			this.layoutControlItem4.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem8.Control = this.txtSupercargoID;
			this.layoutControlItem8.Height = 29;
			this.layoutControlItem8.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem8.Name = "layoutControlItem8";
			this.layoutControlItem8.Text = "Supercargo";
			this.layoutControlItem8.Width = 50;
			this.layoutControlItem8.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem1.Control = this.txtCoachNum;
			this.layoutControlItem1.Height = 29;
			this.layoutControlItem1.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Text = "CoachNum";
			this.layoutControlItem1.Width = 50;
			this.layoutControlItem1.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem19.Control = this.txtCTransportCode;
			this.layoutControlItem19.Height = 29;
			this.layoutControlItem19.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem19.Name = "layoutControlItem19";
			this.layoutControlItem19.Text = "CTransportCode";
			this.layoutControlItem19.Width = 50;
			this.layoutControlItem19.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem30.Control = this.cmbType;
			this.layoutControlItem30.Height = 28;
			this.layoutControlItem30.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem30.Name = "layoutControlItem30";
			this.layoutControlItem30.Text = "CoachType";
			this.layoutControlItem30.Width = 50;
			this.layoutControlItem30.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem12.Control = this.dInputWeight;
			this.layoutControlItem12.Height = 29;
			this.layoutControlItem12.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem12.Name = "layoutControlItem12";
			this.layoutControlItem12.Text = "*Weight(kg)";
			this.layoutControlItem12.Width = 50;
			this.layoutControlItem12.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem32.Control = this.dInputVol;
			this.layoutControlItem32.Height = 29;
			this.layoutControlItem32.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem32.Name = "layoutControlItem32";
			this.layoutControlItem32.Text = "Vol(m³)";
			this.layoutControlItem32.Width = 50;
			this.layoutControlItem32.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem33.Control = this.dInputFactor;
			this.layoutControlItem33.Height = 29;
			this.layoutControlItem33.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem33.Name = "layoutControlItem33";
			this.layoutControlItem33.Text = "Factor";
			this.layoutControlItem33.Width = 50;
			this.layoutControlItem33.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem13.Control = this.cmbProduct;
			this.layoutControlItem13.Height = 28;
			this.layoutControlItem13.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem13.Name = "layoutControlItem13";
			this.layoutControlItem13.Text = "Product";
			this.layoutControlItem13.Width = 50;
			this.layoutControlItem13.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem34.Control = this.dInputNetWeight;
			this.layoutControlItem34.Height = 29;
			this.layoutControlItem34.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem34.Name = "layoutControlItem34";
			this.layoutControlItem34.Text = "*NetWeight(kg)";
			this.layoutControlItem34.Width = 50;
			this.layoutControlItem34.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem39.Control = this.tInputValidDate;
			this.layoutControlItem39.Height = 29;
			this.layoutControlItem39.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem39.Name = "layoutControlItem39";
			this.layoutControlItem39.Text = "*ValidDate";
			this.layoutControlItem39.Width = 50;
			this.layoutControlItem39.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem15.Control = this.dInputLoadWeight;
			this.layoutControlItem15.Height = 29;
			this.layoutControlItem15.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem15.Name = "layoutControlItem15";
			this.layoutControlItem15.Text = "*LoadWeight(kg)";
			this.layoutControlItem15.Width = 50;
			this.layoutControlItem15.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem27.Control = this.cmbCreditType;
			this.layoutControlItem27.Height = 29;
			this.layoutControlItem27.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem27.Name = "layoutControlItem27";
			this.layoutControlItem27.Text = "CreditType";
			this.layoutControlItem27.Width = 50;
			this.layoutControlItem27.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem38.Control = this.iInputCangShu;
			this.layoutControlItem38.Height = 29;
			this.layoutControlItem38.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem38.Name = "layoutControlItem38";
			this.layoutControlItem38.Text = "CangShu";
			this.layoutControlItem38.Width = 50;
			this.layoutControlItem38.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem2.Control = this.txtSubUnit;
			this.layoutControlItem2.Height = 29;
			this.layoutControlItem2.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem2.Name = "layoutControlItem2";
			this.layoutControlItem2.Text = "SubUnit";
			this.layoutControlItem2.Width = 100;
			this.layoutControlItem2.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem14.Control = this.rtbRemark;
			this.layoutControlItem14.Height = 44;
			this.layoutControlItem14.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem14.Name = "layoutControlItem14";
			this.layoutControlItem14.Text = "Remark";
			this.layoutControlItem14.Width = 375;
			this.layoutControlItem14.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.groupPanel1.BackColor = global::System.Drawing.Color.Transparent;
			this.groupPanel1.CanvasColor = global::System.Drawing.SystemColors.Control;
			this.groupPanel1.ColorSchemeStyle = global::DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
			this.groupPanel1.Controls.Add(this.rImageDPhoto);
			this.groupPanel1.Controls.Add(this.layoutControl3);
			this.groupPanel1.DisabledBackColor = global::System.Drawing.Color.Empty;
			this.groupPanel1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.groupPanel1.DrawTitleBox = false;
			this.groupPanel1.Location = new global::System.Drawing.Point(0, 394);
			this.groupPanel1.Name = "groupPanel1";
			this.groupPanel1.Size = new global::System.Drawing.Size(492, 160);
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
			this.groupPanel1.TabIndex = 16;
			this.groupPanel1.Text = "Driver";
			this.rImageDPhoto.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.rImageDPhoto.BackgroundStyle.TextAlignment = global::DevComponents.DotNetBar.eStyleTextAlignment.Center;
			this.rImageDPhoto.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("rImageDPhoto.Image");
			this.rImageDPhoto.Location = new global::System.Drawing.Point(3, 0);
			this.rImageDPhoto.Name = "rImageDPhoto";
			this.rImageDPhoto.ReflectionEnabled = false;
			this.rImageDPhoto.Size = new global::System.Drawing.Size(109, 135);
			this.rImageDPhoto.TabIndex = 1;
			this.layoutControl3.Controls.Add(this.txtDAddress);
			this.layoutControl3.Controls.Add(this.txtDSex);
			this.layoutControl3.Controls.Add(this.chkDEnable);
			this.layoutControl3.Controls.Add(this.txtDPhoneNum);
			this.layoutControl3.Controls.Add(this.dInputDWeight);
			this.layoutControl3.Controls.Add(this.txtDName);
			this.layoutControl3.Controls.Add(this.txtDIDCard);
			this.layoutControl3.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.layoutControl3.Enabled = false;
			this.layoutControl3.Location = new global::System.Drawing.Point(120, 0);
			this.layoutControl3.Name = "layoutControl3";
			this.layoutControl3.RootGroup.Items.AddRange(new global::DevComponents.DotNetBar.Layout.LayoutItemBase[]
			{
				this.layoutControlItem3,
				this.layoutControlItem20,
				this.layoutControlItem6,
				this.layoutControlItem7,
				this.layoutControlItem9,
				this.layoutControlItem17,
				this.layoutControlItem16
			});
			this.layoutControl3.Size = new global::System.Drawing.Size(366, 138);
			this.layoutControl3.TabIndex = 0;
			this.txtDAddress.Border.Class = "TextBoxBorder";
			this.txtDAddress.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtDAddress.Location = new global::System.Drawing.Point(98, 64);
			this.txtDAddress.Margin = new global::System.Windows.Forms.Padding(0);
			this.txtDAddress.Name = "txtDAddress";
			this.txtDAddress.PreventEnterBeep = true;
			this.txtDAddress.Size = new global::System.Drawing.Size(264, 21);
			this.txtDAddress.TabIndex = 4;
			this.txtDSex.Border.Class = "TextBoxBorder";
			this.txtDSex.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtDSex.Location = new global::System.Drawing.Point(337, 4);
			this.txtDSex.Margin = new global::System.Windows.Forms.Padding(0);
			this.txtDSex.Name = "txtDSex";
			this.txtDSex.PreventEnterBeep = true;
			this.txtDSex.Size = new global::System.Drawing.Size(25, 21);
			this.txtDSex.TabIndex = 2;
			this.chkDEnable.AutoSize = true;
			this.chkDEnable.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.chkDEnable.Location = new global::System.Drawing.Point(187, 4);
			this.chkDEnable.Margin = new global::System.Windows.Forms.Padding(0);
			this.chkDEnable.Name = "chkDEnable";
			this.chkDEnable.Size = new global::System.Drawing.Size(57, 16);
			this.chkDEnable.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.chkDEnable.TabIndex = 1;
			this.chkDEnable.Text = "Valid";
			this.txtDPhoneNum.Border.Class = "TextBoxBorder";
			this.txtDPhoneNum.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtDPhoneNum.Location = new global::System.Drawing.Point(98, 93);
			this.txtDPhoneNum.Margin = new global::System.Windows.Forms.Padding(0);
			this.txtDPhoneNum.Name = "txtDPhoneNum";
			this.txtDPhoneNum.PreventEnterBeep = true;
			this.txtDPhoneNum.Size = new global::System.Drawing.Size(117, 21);
			this.txtDPhoneNum.TabIndex = 5;
			this.dInputDWeight.BackgroundStyle.Class = "DateTimeInputBackground";
			this.dInputDWeight.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.dInputDWeight.ButtonFreeText.Shortcut = global::DevComponents.DotNetBar.eShortcut.F2;
			this.dInputDWeight.Increment = 1.0;
			this.dInputDWeight.InputHorizontalAlignment = global::DevComponents.Editors.eHorizontalAlignment.Left;
			this.dInputDWeight.Location = new global::System.Drawing.Point(317, 93);
			this.dInputDWeight.Margin = new global::System.Windows.Forms.Padding(0);
			this.dInputDWeight.Name = "dInputDWeight";
			this.dInputDWeight.ShowUpDown = true;
			this.dInputDWeight.Size = new global::System.Drawing.Size(45, 21);
			this.dInputDWeight.TabIndex = 6;
			this.txtDName.Border.Class = "TextBoxBorder";
			this.txtDName.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtDName.Location = new global::System.Drawing.Point(98, 4);
			this.txtDName.Margin = new global::System.Windows.Forms.Padding(0);
			this.txtDName.Name = "txtDName";
			this.txtDName.PreventEnterBeep = true;
			this.txtDName.Size = new global::System.Drawing.Size(81, 21);
			this.txtDName.TabIndex = 0;
			this.txtDIDCard.Border.Class = "TextBoxBorder";
			this.txtDIDCard.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtDIDCard.Location = new global::System.Drawing.Point(98, 35);
			this.txtDIDCard.Margin = new global::System.Windows.Forms.Padding(0);
			this.txtDIDCard.Name = "txtDIDCard";
			this.txtDIDCard.PreventEnterBeep = true;
			this.txtDIDCard.Size = new global::System.Drawing.Size(264, 21);
			this.txtDIDCard.TabIndex = 3;
			this.layoutControlItem3.Control = this.txtDName;
			this.layoutControlItem3.Height = 29;
			this.layoutControlItem3.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem3.Name = "layoutControlItem3";
			this.layoutControlItem3.Text = "PersonName";
			this.layoutControlItem3.Width = 50;
			this.layoutControlItem3.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem20.Control = this.chkDEnable;
			this.layoutControlItem20.Height = 31;
			this.layoutControlItem20.MinSize = new global::System.Drawing.Size(56, 18);
			this.layoutControlItem20.Name = "layoutControlItem20";
			this.layoutControlItem20.Width = 10;
			this.layoutControlItem20.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem6.Control = this.txtDSex;
			this.layoutControlItem6.Height = 29;
			this.layoutControlItem6.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem6.Name = "layoutControlItem6";
			this.layoutControlItem6.Text = "Sex";
			this.layoutControlItem6.Width = 40;
			this.layoutControlItem6.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem7.Control = this.txtDIDCard;
			this.layoutControlItem7.Height = 29;
			this.layoutControlItem7.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem7.Name = "layoutControlItem7";
			this.layoutControlItem7.Text = "IDCard";
			this.layoutControlItem7.Width = 100;
			this.layoutControlItem7.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem9.Control = this.txtDAddress;
			this.layoutControlItem9.Height = 29;
			this.layoutControlItem9.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem9.Name = "layoutControlItem9";
			this.layoutControlItem9.Text = "LiveAddr";
			this.layoutControlItem9.Width = 100;
			this.layoutControlItem9.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem17.Control = this.txtDPhoneNum;
			this.layoutControlItem17.Height = 29;
			this.layoutControlItem17.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem17.Name = "layoutControlItem17";
			this.layoutControlItem17.Text = "PhoneNum";
			this.layoutControlItem17.Width = 60;
			this.layoutControlItem17.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem16.Control = this.dInputDWeight;
			this.layoutControlItem16.Height = 29;
			this.layoutControlItem16.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem16.Name = "layoutControlItem16";
			this.layoutControlItem16.Text = "BodyWeight(kg)";
			this.layoutControlItem16.Width = 40;
			this.layoutControlItem16.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.groupPanel2.BackColor = global::System.Drawing.Color.Transparent;
			this.groupPanel2.CanvasColor = global::System.Drawing.SystemColors.Control;
			this.groupPanel2.ColorSchemeStyle = global::DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
			this.groupPanel2.Controls.Add(this.layoutControl1);
			this.groupPanel2.Controls.Add(this.rImageSPhoto);
			this.groupPanel2.DisabledBackColor = global::System.Drawing.Color.Empty;
			this.groupPanel2.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.groupPanel2.DrawTitleBox = false;
			this.groupPanel2.Location = new global::System.Drawing.Point(0, 554);
			this.groupPanel2.Name = "groupPanel2";
			this.groupPanel2.Size = new global::System.Drawing.Size(492, 160);
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
			this.groupPanel2.TabIndex = 17;
			this.groupPanel2.Text = "Supercargo";
			this.layoutControl1.Controls.Add(this.txtSAddress);
			this.layoutControl1.Controls.Add(this.txtSSex);
			this.layoutControl1.Controls.Add(this.chkSEnable);
			this.layoutControl1.Controls.Add(this.txtSPhoneNum);
			this.layoutControl1.Controls.Add(this.dInputSWeight);
			this.layoutControl1.Controls.Add(this.txtSName);
			this.layoutControl1.Controls.Add(this.txtSIDCard);
			this.layoutControl1.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.layoutControl1.Enabled = false;
			this.layoutControl1.Location = new global::System.Drawing.Point(120, 0);
			this.layoutControl1.Name = "layoutControl1";
			this.layoutControl1.RootGroup.Items.AddRange(new global::DevComponents.DotNetBar.Layout.LayoutItemBase[]
			{
				this.layoutControlItem21,
				this.layoutControlItem22,
				this.layoutControlItem10,
				this.layoutControlItem23,
				this.layoutControlItem11,
				this.layoutControlItem26,
				this.layoutControlItem25
			});
			this.layoutControl1.Size = new global::System.Drawing.Size(366, 138);
			this.layoutControl1.TabIndex = 3;
			this.txtSAddress.Border.Class = "TextBoxBorder";
			this.txtSAddress.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtSAddress.Location = new global::System.Drawing.Point(98, 64);
			this.txtSAddress.Margin = new global::System.Windows.Forms.Padding(0);
			this.txtSAddress.Name = "txtSAddress";
			this.txtSAddress.PreventEnterBeep = true;
			this.txtSAddress.Size = new global::System.Drawing.Size(264, 21);
			this.txtSAddress.TabIndex = 4;
			this.txtSSex.Border.Class = "TextBoxBorder";
			this.txtSSex.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtSSex.Location = new global::System.Drawing.Point(337, 4);
			this.txtSSex.Margin = new global::System.Windows.Forms.Padding(0);
			this.txtSSex.Name = "txtSSex";
			this.txtSSex.PreventEnterBeep = true;
			this.txtSSex.Size = new global::System.Drawing.Size(25, 21);
			this.txtSSex.TabIndex = 2;
			this.chkSEnable.AutoSize = true;
			this.chkSEnable.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.chkSEnable.Location = new global::System.Drawing.Point(187, 4);
			this.chkSEnable.Margin = new global::System.Windows.Forms.Padding(0);
			this.chkSEnable.Name = "chkSEnable";
			this.chkSEnable.Size = new global::System.Drawing.Size(57, 16);
			this.chkSEnable.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.chkSEnable.TabIndex = 1;
			this.chkSEnable.Text = "Valid";
			this.txtSPhoneNum.Border.Class = "TextBoxBorder";
			this.txtSPhoneNum.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtSPhoneNum.Location = new global::System.Drawing.Point(98, 93);
			this.txtSPhoneNum.Margin = new global::System.Windows.Forms.Padding(0);
			this.txtSPhoneNum.Name = "txtSPhoneNum";
			this.txtSPhoneNum.PreventEnterBeep = true;
			this.txtSPhoneNum.Size = new global::System.Drawing.Size(117, 21);
			this.txtSPhoneNum.TabIndex = 5;
			this.dInputSWeight.BackgroundStyle.Class = "DateTimeInputBackground";
			this.dInputSWeight.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.dInputSWeight.ButtonFreeText.Shortcut = global::DevComponents.DotNetBar.eShortcut.F2;
			this.dInputSWeight.Increment = 1.0;
			this.dInputSWeight.InputHorizontalAlignment = global::DevComponents.Editors.eHorizontalAlignment.Left;
			this.dInputSWeight.Location = new global::System.Drawing.Point(317, 93);
			this.dInputSWeight.Margin = new global::System.Windows.Forms.Padding(0);
			this.dInputSWeight.Name = "dInputSWeight";
			this.dInputSWeight.ShowUpDown = true;
			this.dInputSWeight.Size = new global::System.Drawing.Size(45, 21);
			this.dInputSWeight.TabIndex = 6;
			this.txtSName.Border.Class = "TextBoxBorder";
			this.txtSName.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtSName.Location = new global::System.Drawing.Point(98, 4);
			this.txtSName.Margin = new global::System.Windows.Forms.Padding(0);
			this.txtSName.Name = "txtSName";
			this.txtSName.PreventEnterBeep = true;
			this.txtSName.Size = new global::System.Drawing.Size(81, 21);
			this.txtSName.TabIndex = 0;
			this.txtSIDCard.Border.Class = "TextBoxBorder";
			this.txtSIDCard.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtSIDCard.Location = new global::System.Drawing.Point(98, 35);
			this.txtSIDCard.Margin = new global::System.Windows.Forms.Padding(0);
			this.txtSIDCard.Name = "txtSIDCard";
			this.txtSIDCard.PreventEnterBeep = true;
			this.txtSIDCard.Size = new global::System.Drawing.Size(264, 21);
			this.txtSIDCard.TabIndex = 3;
			this.layoutControlItem21.Control = this.txtSName;
			this.layoutControlItem21.Height = 29;
			this.layoutControlItem21.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem21.Name = "layoutControlItem21";
			this.layoutControlItem21.Text = "PersonName";
			this.layoutControlItem21.Width = 50;
			this.layoutControlItem21.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem22.Control = this.chkSEnable;
			this.layoutControlItem22.Height = 31;
			this.layoutControlItem22.MinSize = new global::System.Drawing.Size(56, 18);
			this.layoutControlItem22.Name = "layoutControlItem22";
			this.layoutControlItem22.Width = 10;
			this.layoutControlItem22.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem10.Control = this.txtSSex;
			this.layoutControlItem10.Height = 29;
			this.layoutControlItem10.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem10.Name = "layoutControlItem10";
			this.layoutControlItem10.Text = "Sex";
			this.layoutControlItem10.Width = 40;
			this.layoutControlItem10.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem23.Control = this.txtSIDCard;
			this.layoutControlItem23.Height = 29;
			this.layoutControlItem23.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem23.Name = "layoutControlItem23";
			this.layoutControlItem23.Text = "IDCard";
			this.layoutControlItem23.Width = 100;
			this.layoutControlItem23.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem11.Control = this.txtSAddress;
			this.layoutControlItem11.Height = 29;
			this.layoutControlItem11.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem11.Name = "layoutControlItem11";
			this.layoutControlItem11.Text = "LiveAddr";
			this.layoutControlItem11.Width = 100;
			this.layoutControlItem11.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem26.Control = this.txtSPhoneNum;
			this.layoutControlItem26.Height = 29;
			this.layoutControlItem26.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem26.Name = "layoutControlItem26";
			this.layoutControlItem26.Text = "PhoneNum";
			this.layoutControlItem26.Width = 60;
			this.layoutControlItem26.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem25.Control = this.dInputSWeight;
			this.layoutControlItem25.Height = 29;
			this.layoutControlItem25.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem25.Name = "layoutControlItem25";
			this.layoutControlItem25.Text = "BodyWeight(kg)";
			this.layoutControlItem25.Width = 40;
			this.layoutControlItem25.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.rImageSPhoto.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.rImageSPhoto.BackgroundStyle.TextAlignment = global::DevComponents.DotNetBar.eStyleTextAlignment.Center;
			this.rImageSPhoto.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("rImageSPhoto.Image");
			this.rImageSPhoto.Location = new global::System.Drawing.Point(3, 0);
			this.rImageSPhoto.Name = "rImageSPhoto";
			this.rImageSPhoto.ReflectionEnabled = false;
			this.rImageSPhoto.Size = new global::System.Drawing.Size(109, 135);
			this.rImageSPhoto.TabIndex = 2;
			this.layoutControlItem24.Control = this.cmbCreditType;
			this.layoutControlItem24.Height = 28;
			this.layoutControlItem24.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem24.Name = "layoutControlItem24";
			this.layoutControlItem24.Text = "Product";
			this.layoutControlItem24.Width = 50;
			this.layoutControlItem24.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem28.Control = this.cmbSpecialStepType;
			this.layoutControlItem28.Height = 28;
			this.layoutControlItem28.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem28.Name = "layoutControlItem28";
			this.layoutControlItem28.Text = "CoachType";
			this.layoutControlItem28.Width = 50;
			this.layoutControlItem28.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.cmbSpecialStepType.DataSource = null;
			this.cmbSpecialStepType.DisplayMember = null;
			this.cmbSpecialStepType.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cmbSpecialStepType.FormattingEnabled = true;
			this.cmbSpecialStepType.ItemHeight = 15;
			this.cmbSpecialStepType.Location = new global::System.Drawing.Point(104, 265);
			this.cmbSpecialStepType.Margin = new global::System.Windows.Forms.Padding(0);
			this.cmbSpecialStepType.MaxDropDownItems = 20;
			this.cmbSpecialStepType.Name = "cmbSpecialStepType";
			this.cmbSpecialStepType.SelectMember = null;
			this.cmbSpecialStepType.Size = new global::System.Drawing.Size(378, 21);
			this.cmbSpecialStepType.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.cmbSpecialStepType.TabIndex = 17;
			this.cmbSpecialStepType.ValueMember = null;
			this.layoutControlItem29.Control = this.cmbSpecialStepType;
			this.layoutControlItem29.Height = 29;
			this.layoutControlItem29.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem29.Name = "layoutControlItem29";
			this.layoutControlItem29.Text = "SpecialStepType";
			this.layoutControlItem29.Width = 100;
			this.layoutControlItem29.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			base.ClientSize = new global::System.Drawing.Size(492, 725);
			base.Controls.Add(this.groupPanel2);
			base.Controls.Add(this.groupPanel1);
			base.Controls.Add(this.groupPanel4);
			base.Controls.Add(this.bar1);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "frmTruckEdit";
			this.Text = "frmTruckEdit";
			base.Load += new global::System.EventHandler(this.frmTruckEdit_Load);
			((global::System.ComponentModel.ISupportInitialize)this.bar1).EndInit();
			this.groupPanel4.ResumeLayout(false);
			this.layCoach.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.dInputLoadWeight).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.dInputWeight).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.dInputNetWeight).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.dInputFactor).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.iInputCangShu).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.tInputValidDate).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.dInputVol).EndInit();
			this.groupPanel1.ResumeLayout(false);
			this.layoutControl3.ResumeLayout(false);
			this.layoutControl3.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dInputDWeight).EndInit();
			this.groupPanel2.ResumeLayout(false);
			this.layoutControl1.ResumeLayout(false);
			this.layoutControl1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dInputSWeight).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000DD6 RID: 3542
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000DD7 RID: 3543
		private global::DevComponents.DotNetBar.Controls.RichTextBoxEx rtbRemark;

		// Token: 0x04000DD8 RID: 3544
		private global::DevComponents.DotNetBar.Bar bar1;

		// Token: 0x04000DD9 RID: 3545
		private global::DevComponents.DotNetBar.ButtonItem btnSave;

		// Token: 0x04000DDA RID: 3546
		private global::DevComponents.DotNetBar.Controls.GroupPanel groupPanel4;

		// Token: 0x04000DDB RID: 3547
		private global::DevComponents.DotNetBar.Layout.LayoutControl layCoach;

		// Token: 0x04000DDC RID: 3548
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtCoachNum;

		// Token: 0x04000DDD RID: 3549
		private global::DevComponents.Editors.DoubleInput dInputNetWeight;

		// Token: 0x04000DDE RID: 3550
		private global::DevComponents.Editors.DoubleInput dInputFactor;

		// Token: 0x04000DDF RID: 3551
		private global::Base.AutoComboBox cmbType;

		// Token: 0x04000DE0 RID: 3552
		private global::DevComponents.Editors.IntegerInput iInputCangShu;

		// Token: 0x04000DE1 RID: 3553
		private global::DevComponents.Editors.DateTimeAdv.DateTimeInput tInputValidDate;

		// Token: 0x04000DE2 RID: 3554
		private global::DevComponents.Editors.DoubleInput dInputVol;

		// Token: 0x04000DE3 RID: 3555
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem1;

		// Token: 0x04000DE4 RID: 3556
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem30;

		// Token: 0x04000DE5 RID: 3557
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem32;

		// Token: 0x04000DE6 RID: 3558
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem33;

		// Token: 0x04000DE7 RID: 3559
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem34;

		// Token: 0x04000DE8 RID: 3560
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem38;

		// Token: 0x04000DE9 RID: 3561
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem39;

		// Token: 0x04000DEA RID: 3562
		private global::DevComponents.Editors.DoubleInput dInputWeight;

		// Token: 0x04000DEB RID: 3563
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtLisence;

		// Token: 0x04000DEC RID: 3564
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem5;

		// Token: 0x04000DED RID: 3565
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem12;

		// Token: 0x04000DEE RID: 3566
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem14;

		// Token: 0x04000DEF RID: 3567
		private global::DevComponents.DotNetBar.ButtonItem btnAddType;

		// Token: 0x04000DF0 RID: 3568
		private global::DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;

		// Token: 0x04000DF1 RID: 3569
		private global::DevComponents.DotNetBar.Controls.ReflectionImage rImageDPhoto;

		// Token: 0x04000DF2 RID: 3570
		private global::DevComponents.DotNetBar.Layout.LayoutControl layoutControl3;

		// Token: 0x04000DF3 RID: 3571
		private global::DevComponents.DotNetBar.Controls.CheckBoxX chkDEnable;

		// Token: 0x04000DF4 RID: 3572
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtDPhoneNum;

		// Token: 0x04000DF5 RID: 3573
		private global::DevComponents.Editors.DoubleInput dInputDWeight;

		// Token: 0x04000DF6 RID: 3574
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtDName;

		// Token: 0x04000DF7 RID: 3575
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtDIDCard;

		// Token: 0x04000DF8 RID: 3576
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem3;

		// Token: 0x04000DF9 RID: 3577
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem20;

		// Token: 0x04000DFA RID: 3578
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem16;

		// Token: 0x04000DFB RID: 3579
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem7;

		// Token: 0x04000DFC RID: 3580
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem17;

		// Token: 0x04000DFD RID: 3581
		private global::DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;

		// Token: 0x04000DFE RID: 3582
		private global::DevComponents.DotNetBar.Layout.LayoutControl layoutControl1;

		// Token: 0x04000DFF RID: 3583
		private global::DevComponents.DotNetBar.Controls.CheckBoxX chkSEnable;

		// Token: 0x04000E00 RID: 3584
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtSPhoneNum;

		// Token: 0x04000E01 RID: 3585
		private global::DevComponents.Editors.DoubleInput dInputSWeight;

		// Token: 0x04000E02 RID: 3586
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtSName;

		// Token: 0x04000E03 RID: 3587
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtSIDCard;

		// Token: 0x04000E04 RID: 3588
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem21;

		// Token: 0x04000E05 RID: 3589
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem22;

		// Token: 0x04000E06 RID: 3590
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem25;

		// Token: 0x04000E07 RID: 3591
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem23;

		// Token: 0x04000E08 RID: 3592
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem26;

		// Token: 0x04000E09 RID: 3593
		private global::DevComponents.DotNetBar.Controls.ReflectionImage rImageSPhoto;

		// Token: 0x04000E0A RID: 3594
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtSupercargoID;

		// Token: 0x04000E0B RID: 3595
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtDriverID;

		// Token: 0x04000E0C RID: 3596
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem4;

		// Token: 0x04000E0D RID: 3597
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem8;

		// Token: 0x04000E0E RID: 3598
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtSubUnit;

		// Token: 0x04000E0F RID: 3599
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem2;

		// Token: 0x04000E10 RID: 3600
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtDAddress;

		// Token: 0x04000E11 RID: 3601
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtDSex;

		// Token: 0x04000E12 RID: 3602
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem6;

		// Token: 0x04000E13 RID: 3603
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem9;

		// Token: 0x04000E14 RID: 3604
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtSAddress;

		// Token: 0x04000E15 RID: 3605
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtSSex;

		// Token: 0x04000E16 RID: 3606
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem10;

		// Token: 0x04000E17 RID: 3607
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem11;

		// Token: 0x04000E18 RID: 3608
		private global::DevComponents.DotNetBar.ButtonItem btnAddPeople;

		// Token: 0x04000E19 RID: 3609
		private global::Base.AutoComboBox cmbProduct;

		// Token: 0x04000E1A RID: 3610
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem13;

		// Token: 0x04000E1B RID: 3611
		private global::DevComponents.Editors.DoubleInput dInputLoadWeight;

		// Token: 0x04000E1C RID: 3612
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem15;

		// Token: 0x04000E1D RID: 3613
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtCTransportCode;

		// Token: 0x04000E1E RID: 3614
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtLTransportCode;

		// Token: 0x04000E1F RID: 3615
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem18;

		// Token: 0x04000E20 RID: 3616
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem19;

		// Token: 0x04000E21 RID: 3617
		private global::Base.AutoComboBox cmbCreditType;

		// Token: 0x04000E22 RID: 3618
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem27;

		// Token: 0x04000E23 RID: 3619
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem24;

		// Token: 0x04000E24 RID: 3620
		private global::Base.AutoComboBox cmbSpecialStepType;

		// Token: 0x04000E25 RID: 3621
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem29;

		// Token: 0x04000E26 RID: 3622
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem28;
	}
}
