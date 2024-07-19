namespace SQSClient
{
	// Token: 0x02000064 RID: 100
	public partial class frmProductEditShow : global::SQSClient.BaseDialogForm
	{
		// Token: 0x060004DD RID: 1245 RVA: 0x0007B0A4 File Offset: 0x000792A4
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060004DE RID: 1246 RVA: 0x0007B0DC File Offset: 0x000792DC
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::SQSClient.frmProductEditShow));
			this.lciCheDao = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem10 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.menuBar = new global::DevComponents.DotNetBar.Bar();
			this.btnSave = new global::DevComponents.DotNetBar.ButtonItem();
			this.layoutControl1 = new global::DevComponents.DotNetBar.Layout.LayoutControl();
			this.cmbPackType = new global::DevComponents.DotNetBar.Controls.ComboBoxEx();
			this.cmbBusinessType = new global::DevComponents.DotNetBar.Controls.ComboBoxEx();
			this.dInputNagativePrecise = new global::DevComponents.Editors.DoubleInput();
			this.dInputCode = new global::DevComponents.Editors.DoubleInput();
			this.dInputSunHao = new global::DevComponents.Editors.DoubleInput();
			this.txtName = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.dInputMidu = new global::DevComponents.Editors.DoubleInput();
			this.rtbRemark = new global::DevComponents.DotNetBar.Controls.RichTextBoxEx();
			this.chkSingle = new global::DevComponents.DotNetBar.Controls.CheckBoxX();
			this.chkCombin = new global::DevComponents.DotNetBar.Controls.CheckBoxX();
			this.btnAdd = new global::DevComponents.DotNetBar.ButtonX();
			this.txtInvCode = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.txtInvName = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.dInputSpecsAmount = new global::DevComponents.Editors.DoubleInput();
			this.txtSpecsDescribe = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.dInputSpecsShell = new global::DevComponents.Editors.DoubleInput();
			this.dInputPositivePrecise = new global::DevComponents.Editors.DoubleInput();
			this.cmbValidCondition = new global::DevComponents.DotNetBar.Controls.ComboBoxEx();
			this.cmbPostType = new global::DevComponents.DotNetBar.Controls.ComboBoxEx();
			this.cmbState = new global::DevComponents.DotNetBar.Controls.ComboBoxEx();
			this.tInputEffectTime = new global::DevComponents.Editors.DateTimeAdv.DateTimeInput();
			this.layoutControlItem2 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem3 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layName = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layCode = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem4 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem11 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem8 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem16 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem15 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem19 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem25 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem20 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem21 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem22 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem24 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.laySunHao = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layDensity = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layRemark = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem6 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem14 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layAdd = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem5 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem13 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem1 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem7 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem9 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem12 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem18 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem23 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.cmbQueue = new global::Base.AutoComboBox();
			this.layoutControlItem17 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			((global::System.ComponentModel.ISupportInitialize)this.menuBar).BeginInit();
			this.layoutControl1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dInputNagativePrecise).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.dInputCode).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.dInputSunHao).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.dInputMidu).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.dInputSpecsAmount).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.dInputSpecsShell).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.dInputPositivePrecise).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.tInputEffectTime).BeginInit();
			base.SuspendLayout();
			this.lciCheDao.Height = 29;
			this.lciCheDao.MinSize = new global::System.Drawing.Size(120, 0);
			this.lciCheDao.Name = "lciCheDao";
			this.lciCheDao.Text = "车道";
			this.lciCheDao.Width = 390;
			this.layoutControlItem10.Height = 29;
			this.layoutControlItem10.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem10.Name = "layoutControlItem10";
			this.layoutControlItem10.Text = "损耗率";
			this.layoutControlItem10.Width = 390;
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
			this.menuBar.Size = new global::System.Drawing.Size(537, 26);
			this.menuBar.Stretch = true;
			this.menuBar.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.menuBar.TabIndex = 18;
			this.menuBar.TabStop = false;
			this.menuBar.Text = "Main Menu";
			this.btnSave.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.btnSave.Image = global::SQSClient.Properties.Resources.save16;
			this.btnSave.Name = "btnSave";
			this.btnSave.Text = "Save";
			this.btnSave.Click += new global::System.EventHandler(this.btnSave_Click);
			this.layoutControl1.Controls.Add(this.cmbPackType);
			this.layoutControl1.Controls.Add(this.cmbBusinessType);
			this.layoutControl1.Controls.Add(this.dInputNagativePrecise);
			this.layoutControl1.Controls.Add(this.dInputCode);
			this.layoutControl1.Controls.Add(this.dInputSunHao);
			this.layoutControl1.Controls.Add(this.txtName);
			this.layoutControl1.Controls.Add(this.dInputMidu);
			this.layoutControl1.Controls.Add(this.rtbRemark);
			this.layoutControl1.Controls.Add(this.chkSingle);
			this.layoutControl1.Controls.Add(this.chkCombin);
			this.layoutControl1.Controls.Add(this.btnAdd);
			this.layoutControl1.Controls.Add(this.txtInvCode);
			this.layoutControl1.Controls.Add(this.txtInvName);
			this.layoutControl1.Controls.Add(this.dInputSpecsAmount);
			this.layoutControl1.Controls.Add(this.txtSpecsDescribe);
			this.layoutControl1.Controls.Add(this.dInputSpecsShell);
			this.layoutControl1.Controls.Add(this.dInputPositivePrecise);
			this.layoutControl1.Controls.Add(this.cmbValidCondition);
			this.layoutControl1.Controls.Add(this.cmbPostType);
			this.layoutControl1.Controls.Add(this.cmbState);
			this.layoutControl1.Controls.Add(this.tInputEffectTime);
			this.layoutControl1.Controls.Add(this.cmbQueue);
			this.layoutControl1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.layoutControl1.Location = new global::System.Drawing.Point(0, 26);
			this.layoutControl1.Name = "layoutControl1";
			this.layoutControl1.RootGroup.Items.AddRange(new global::DevComponents.DotNetBar.Layout.LayoutItemBase[]
			{
				this.layoutControlItem2,
				this.layoutControlItem3,
				this.layName,
				this.layCode,
				this.layoutControlItem4,
				this.layoutControlItem11,
				this.layoutControlItem8,
				this.layoutControlItem16,
				this.layoutControlItem15,
				this.layoutControlItem17,
				this.layoutControlItem19,
				this.layoutControlItem25,
				this.layoutControlItem20,
				this.layoutControlItem21,
				this.layoutControlItem22,
				this.layoutControlItem24,
				this.laySunHao,
				this.layDensity,
				this.layRemark,
				this.layoutControlItem6,
				this.layoutControlItem14,
				this.layAdd
			});
			this.layoutControl1.Size = new global::System.Drawing.Size(537, 517);
			this.layoutControl1.TabIndex = 19;
			this.cmbPackType.DisplayMember = "Text";
			this.cmbPackType.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cmbPackType.FormattingEnabled = true;
			this.cmbPackType.ItemHeight = 15;
			this.cmbPackType.Location = new global::System.Drawing.Point(397, 91);
			this.cmbPackType.Margin = new global::System.Windows.Forms.Padding(0);
			this.cmbPackType.Name = "cmbPackType";
			this.cmbPackType.Size = new global::System.Drawing.Size(136, 21);
			this.cmbPackType.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.cmbPackType.TabIndex = 5;
			this.cmbBusinessType.DisplayMember = "Text";
			this.cmbBusinessType.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cmbBusinessType.FormattingEnabled = true;
			this.cmbBusinessType.ItemHeight = 15;
			this.cmbBusinessType.Location = new global::System.Drawing.Point(129, 91);
			this.cmbBusinessType.Margin = new global::System.Windows.Forms.Padding(0);
			this.cmbBusinessType.Name = "cmbBusinessType";
			this.cmbBusinessType.Size = new global::System.Drawing.Size(135, 21);
			this.cmbBusinessType.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.cmbBusinessType.TabIndex = 4;
			this.dInputNagativePrecise.BackgroundStyle.Class = "DateTimeInputBackground";
			this.dInputNagativePrecise.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.dInputNagativePrecise.ButtonFreeText.Shortcut = global::DevComponents.DotNetBar.eShortcut.F2;
			this.dInputNagativePrecise.DisplayFormat = "0.0000";
			this.dInputNagativePrecise.Increment = 1.0;
			this.dInputNagativePrecise.InputHorizontalAlignment = global::DevComponents.Editors.eHorizontalAlignment.Left;
			this.dInputNagativePrecise.Location = new global::System.Drawing.Point(397, 177);
			this.dInputNagativePrecise.Margin = new global::System.Windows.Forms.Padding(0);
			this.dInputNagativePrecise.MaxValue = 1000000.0;
			this.dInputNagativePrecise.MinValue = 0.0;
			this.dInputNagativePrecise.MouseWheelValueChangeEnabled = false;
			this.dInputNagativePrecise.Name = "dInputNagativePrecise";
			this.dInputNagativePrecise.ShowUpDown = true;
			this.dInputNagativePrecise.Size = new global::System.Drawing.Size(136, 21);
			this.dInputNagativePrecise.TabIndex = 11;
			this.dInputCode.BackgroundStyle.Class = "DateTimeInputBackground";
			this.dInputCode.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.dInputCode.ButtonFreeText.Shortcut = global::DevComponents.DotNetBar.eShortcut.F2;
			this.dInputCode.DisplayFormat = "0";
			this.dInputCode.Increment = 1.0;
			this.dInputCode.InputHorizontalAlignment = global::DevComponents.Editors.eHorizontalAlignment.Left;
			this.dInputCode.Location = new global::System.Drawing.Point(397, 62);
			this.dInputCode.Margin = new global::System.Windows.Forms.Padding(0);
			this.dInputCode.MaxValue = 255.0;
			this.dInputCode.MinValue = 0.0;
			this.dInputCode.Name = "dInputCode";
			this.dInputCode.ShowUpDown = true;
			this.dInputCode.Size = new global::System.Drawing.Size(136, 21);
			this.dInputCode.TabIndex = 3;
			this.dInputSunHao.BackgroundStyle.Class = "DateTimeInputBackground";
			this.dInputSunHao.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.dInputSunHao.ButtonFreeText.Shortcut = global::DevComponents.DotNetBar.eShortcut.F2;
			this.dInputSunHao.DisplayFormat = "0.0000";
			this.dInputSunHao.Increment = 0.1;
			this.dInputSunHao.InputHorizontalAlignment = global::DevComponents.Editors.eHorizontalAlignment.Left;
			this.dInputSunHao.Location = new global::System.Drawing.Point(129, 264);
			this.dInputSunHao.Margin = new global::System.Windows.Forms.Padding(0);
			this.dInputSunHao.MaxValue = 1.0;
			this.dInputSunHao.MinValue = 0.0;
			this.dInputSunHao.MouseWheelValueChangeEnabled = false;
			this.dInputSunHao.Name = "dInputSunHao";
			this.dInputSunHao.ShowUpDown = true;
			this.dInputSunHao.Size = new global::System.Drawing.Size(135, 21);
			this.dInputSunHao.TabIndex = 16;
			this.dInputSunHao.Value = 1.0;
			this.txtName.Border.Class = "TextBoxBorder";
			this.txtName.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtName.Location = new global::System.Drawing.Point(129, 62);
			this.txtName.Margin = new global::System.Windows.Forms.Padding(0);
			this.txtName.MaxLength = 20;
			this.txtName.Name = "txtName";
			this.txtName.PreventEnterBeep = true;
			this.txtName.Size = new global::System.Drawing.Size(135, 21);
			this.txtName.TabIndex = 2;
			this.dInputMidu.BackgroundStyle.Class = "DateTimeInputBackground";
			this.dInputMidu.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.dInputMidu.ButtonFreeText.Shortcut = global::DevComponents.DotNetBar.eShortcut.F2;
			this.dInputMidu.Increment = 1.0;
			this.dInputMidu.InputHorizontalAlignment = global::DevComponents.Editors.eHorizontalAlignment.Left;
			this.dInputMidu.Location = new global::System.Drawing.Point(397, 264);
			this.dInputMidu.Margin = new global::System.Windows.Forms.Padding(0);
			this.dInputMidu.MaxValue = 1000000.0;
			this.dInputMidu.MinValue = 0.0;
			this.dInputMidu.MouseWheelValueChangeEnabled = false;
			this.dInputMidu.Name = "dInputMidu";
			this.dInputMidu.ShowUpDown = true;
			this.dInputMidu.Size = new global::System.Drawing.Size(136, 21);
			this.dInputMidu.TabIndex = 17;
			this.rtbRemark.BackgroundStyle.Class = "RichTextBoxBorder";
			this.rtbRemark.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.rtbRemark.Location = new global::System.Drawing.Point(129, 293);
			this.rtbRemark.Margin = new global::System.Windows.Forms.Padding(0);
			this.rtbRemark.MaxLength = 200;
			this.rtbRemark.Name = "rtbRemark";
			this.rtbRemark.Rtf = "{\\rtf1\\ansi\\ansicpg936\\deff0\\nouicompat\\deflang1033\\deflangfe2052{\\fonttbl{\\f0\\fnil\\fcharset134 \\'cb\\'ce\\'cc\\'e5;}}\r\n{\\*\\generator Riched20 10.0.18362}\\viewkind4\\uc1 \r\n\\pard\\f0\\fs18\\lang2052\\par\r\n}\r\n";
			this.rtbRemark.Size = new global::System.Drawing.Size(404, 50);
			this.rtbRemark.TabIndex = 18;
			this.chkSingle.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.chkSingle.CheckBoxStyle = global::DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
			this.chkSingle.Location = new global::System.Drawing.Point(129, 351);
			this.chkSingle.Margin = new global::System.Windows.Forms.Padding(0);
			this.chkSingle.Name = "chkSingle";
			this.chkSingle.Size = new global::System.Drawing.Size(135, 23);
			this.chkSingle.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.chkSingle.TabIndex = 19;
			this.chkSingle.Text = "Single";
			this.chkSingle.CheckedChanged += new global::System.EventHandler(this.chkSingle_CheckedChanged);
			this.chkCombin.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.chkCombin.CheckBoxStyle = global::DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
			this.chkCombin.Location = new global::System.Drawing.Point(397, 351);
			this.chkCombin.Margin = new global::System.Windows.Forms.Padding(0);
			this.chkCombin.Name = "chkCombin";
			this.chkCombin.Size = new global::System.Drawing.Size(136, 23);
			this.chkCombin.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.chkCombin.TabIndex = 20;
			this.chkCombin.Text = "Combin";
			this.chkCombin.CheckedChanged += new global::System.EventHandler(this.chkCombin_CheckedChanged);
			this.btnAdd.AccessibleRole = global::System.Windows.Forms.AccessibleRole.PushButton;
			this.btnAdd.ColorTable = global::DevComponents.DotNetBar.eButtonColor.Orange;
			this.btnAdd.Image = global::SQSClient.Properties.Resources.add16;
			this.btnAdd.Location = new global::System.Drawing.Point(129, 382);
			this.btnAdd.Margin = new global::System.Windows.Forms.Padding(0);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new global::System.Drawing.Size(27, 23);
			this.btnAdd.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.btnAdd.TabIndex = 21;
			this.btnAdd.Text = "New";
			this.btnAdd.TextAlignment = global::DevComponents.DotNetBar.eButtonTextAlignment.Left;
			this.btnAdd.Tooltip = "增加物料";
			this.btnAdd.Click += new global::System.EventHandler(this.btnAdd_Click);
			this.txtInvCode.Border.Class = "TextBoxBorder";
			this.txtInvCode.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtInvCode.Location = new global::System.Drawing.Point(129, 4);
			this.txtInvCode.Margin = new global::System.Windows.Forms.Padding(0);
			this.txtInvCode.MaxLength = 50;
			this.txtInvCode.Name = "txtInvCode";
			this.txtInvCode.PreventEnterBeep = true;
			this.txtInvCode.Size = new global::System.Drawing.Size(404, 21);
			this.txtInvCode.TabIndex = 0;
			this.txtInvName.Border.Class = "TextBoxBorder";
			this.txtInvName.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtInvName.Location = new global::System.Drawing.Point(129, 33);
			this.txtInvName.Margin = new global::System.Windows.Forms.Padding(0);
			this.txtInvName.MaxLength = 100;
			this.txtInvName.Name = "txtInvName";
			this.txtInvName.PreventEnterBeep = true;
			this.txtInvName.Size = new global::System.Drawing.Size(404, 21);
			this.txtInvName.TabIndex = 1;
			this.dInputSpecsAmount.BackgroundStyle.Class = "DateTimeInputBackground";
			this.dInputSpecsAmount.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.dInputSpecsAmount.ButtonFreeText.Shortcut = global::DevComponents.DotNetBar.eShortcut.F2;
			this.dInputSpecsAmount.DisplayFormat = "0";
			this.dInputSpecsAmount.Increment = 1.0;
			this.dInputSpecsAmount.InputHorizontalAlignment = global::DevComponents.Editors.eHorizontalAlignment.Left;
			this.dInputSpecsAmount.Location = new global::System.Drawing.Point(129, 119);
			this.dInputSpecsAmount.Margin = new global::System.Windows.Forms.Padding(0);
			this.dInputSpecsAmount.MaxValue = 255.0;
			this.dInputSpecsAmount.MinValue = 1.0;
			this.dInputSpecsAmount.Name = "dInputSpecsAmount";
			this.dInputSpecsAmount.ShowUpDown = true;
			this.dInputSpecsAmount.Size = new global::System.Drawing.Size(135, 21);
			this.dInputSpecsAmount.TabIndex = 6;
			this.dInputSpecsAmount.Value = 1.0;
			this.txtSpecsDescribe.Border.Class = "TextBoxBorder";
			this.txtSpecsDescribe.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtSpecsDescribe.Location = new global::System.Drawing.Point(129, 148);
			this.txtSpecsDescribe.Margin = new global::System.Windows.Forms.Padding(0);
			this.txtSpecsDescribe.MaxLength = 20;
			this.txtSpecsDescribe.Name = "txtSpecsDescribe";
			this.txtSpecsDescribe.PreventEnterBeep = true;
			this.txtSpecsDescribe.Size = new global::System.Drawing.Size(135, 21);
			this.txtSpecsDescribe.TabIndex = 8;
			this.dInputSpecsShell.BackgroundStyle.Class = "DateTimeInputBackground";
			this.dInputSpecsShell.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.dInputSpecsShell.ButtonFreeText.Shortcut = global::DevComponents.DotNetBar.eShortcut.F2;
			this.dInputSpecsShell.DisplayFormat = "0.00";
			this.dInputSpecsShell.Increment = 0.1;
			this.dInputSpecsShell.InputHorizontalAlignment = global::DevComponents.Editors.eHorizontalAlignment.Left;
			this.dInputSpecsShell.Location = new global::System.Drawing.Point(397, 119);
			this.dInputSpecsShell.Margin = new global::System.Windows.Forms.Padding(0);
			this.dInputSpecsShell.MaxValue = 1.0;
			this.dInputSpecsShell.MinValue = 0.0;
			this.dInputSpecsShell.MouseWheelValueChangeEnabled = false;
			this.dInputSpecsShell.Name = "dInputSpecsShell";
			this.dInputSpecsShell.ShowUpDown = true;
			this.dInputSpecsShell.Size = new global::System.Drawing.Size(136, 21);
			this.dInputSpecsShell.TabIndex = 7;
			this.dInputSpecsShell.Value = 1.0;
			this.dInputPositivePrecise.BackgroundStyle.Class = "DateTimeInputBackground";
			this.dInputPositivePrecise.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.dInputPositivePrecise.ButtonFreeText.Shortcut = global::DevComponents.DotNetBar.eShortcut.F2;
			this.dInputPositivePrecise.DisplayFormat = "0.0000";
			this.dInputPositivePrecise.Increment = 1.0;
			this.dInputPositivePrecise.InputHorizontalAlignment = global::DevComponents.Editors.eHorizontalAlignment.Left;
			this.dInputPositivePrecise.Location = new global::System.Drawing.Point(129, 177);
			this.dInputPositivePrecise.Margin = new global::System.Windows.Forms.Padding(0);
			this.dInputPositivePrecise.MaxValue = 1000000.0;
			this.dInputPositivePrecise.MinValue = 0.0;
			this.dInputPositivePrecise.MouseWheelValueChangeEnabled = false;
			this.dInputPositivePrecise.Name = "dInputPositivePrecise";
			this.dInputPositivePrecise.ShowUpDown = true;
			this.dInputPositivePrecise.Size = new global::System.Drawing.Size(135, 21);
			this.dInputPositivePrecise.TabIndex = 10;
			this.cmbValidCondition.DisplayMember = "Text";
			this.cmbValidCondition.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cmbValidCondition.FormattingEnabled = true;
			this.cmbValidCondition.ItemHeight = 15;
			this.cmbValidCondition.Location = new global::System.Drawing.Point(129, 206);
			this.cmbValidCondition.Margin = new global::System.Windows.Forms.Padding(0);
			this.cmbValidCondition.Name = "cmbValidCondition";
			this.cmbValidCondition.Size = new global::System.Drawing.Size(135, 21);
			this.cmbValidCondition.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.cmbValidCondition.TabIndex = 12;
			this.cmbPostType.DisplayMember = "Text";
			this.cmbPostType.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cmbPostType.FormattingEnabled = true;
			this.cmbPostType.ItemHeight = 15;
			this.cmbPostType.Location = new global::System.Drawing.Point(397, 206);
			this.cmbPostType.Margin = new global::System.Windows.Forms.Padding(0);
			this.cmbPostType.Name = "cmbPostType";
			this.cmbPostType.Size = new global::System.Drawing.Size(136, 21);
			this.cmbPostType.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.cmbPostType.TabIndex = 13;
			this.cmbState.DisplayMember = "Text";
			this.cmbState.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cmbState.FormattingEnabled = true;
			this.cmbState.ItemHeight = 15;
			this.cmbState.Location = new global::System.Drawing.Point(129, 235);
			this.cmbState.Margin = new global::System.Windows.Forms.Padding(0);
			this.cmbState.Name = "cmbState";
			this.cmbState.Size = new global::System.Drawing.Size(135, 21);
			this.cmbState.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.cmbState.TabIndex = 14;
			this.tInputEffectTime.BackgroundStyle.Class = "DateTimeInputBackground";
			this.tInputEffectTime.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.tInputEffectTime.ButtonDropDown.Shortcut = global::DevComponents.DotNetBar.eShortcut.AltDown;
			this.tInputEffectTime.ButtonDropDown.Visible = true;
			this.tInputEffectTime.IsPopupCalendarOpen = false;
			this.tInputEffectTime.Location = new global::System.Drawing.Point(397, 235);
			this.tInputEffectTime.Margin = new global::System.Windows.Forms.Padding(0);
			this.tInputEffectTime.MonthCalendar.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.tInputEffectTime.MonthCalendar.CalendarDimensions = new global::System.Drawing.Size(1, 1);
			this.tInputEffectTime.MonthCalendar.ClearButtonVisible = true;
			this.tInputEffectTime.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = global::DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
			this.tInputEffectTime.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
			this.tInputEffectTime.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.BarBackground;
			this.tInputEffectTime.MonthCalendar.CommandsBackgroundStyle.BorderTop = global::DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.tInputEffectTime.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
			this.tInputEffectTime.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
			this.tInputEffectTime.MonthCalendar.CommandsBackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.tInputEffectTime.MonthCalendar.DisplayMonth = new global::System.DateTime(2018, 12, 1, 0, 0, 0, 0);
			this.tInputEffectTime.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
			this.tInputEffectTime.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
			this.tInputEffectTime.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
			this.tInputEffectTime.MonthCalendar.NavigationBackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.tInputEffectTime.MonthCalendar.TodayButtonVisible = true;
			this.tInputEffectTime.Name = "tInputEffectTime";
			this.tInputEffectTime.Size = new global::System.Drawing.Size(136, 21);
			this.tInputEffectTime.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.tInputEffectTime.TabIndex = 15;
			this.layoutControlItem2.Control = this.txtInvCode;
			this.layoutControlItem2.Height = 29;
			this.layoutControlItem2.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem2.Name = "layoutControlItem2";
			this.layoutControlItem2.Text = "*InvCode";
			this.layoutControlItem2.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem2.Width = 100;
			this.layoutControlItem2.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem3.Control = this.txtInvName;
			this.layoutControlItem3.Height = 29;
			this.layoutControlItem3.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem3.Name = "layoutControlItem3";
			this.layoutControlItem3.Text = "*InvName";
			this.layoutControlItem3.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem3.Width = 100;
			this.layoutControlItem3.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layName.Control = this.txtName;
			this.layName.Height = 29;
			this.layName.MinSize = new global::System.Drawing.Size(120, 0);
			this.layName.Name = "layName";
			this.layName.Text = "*ProductName";
			this.layName.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layName.Width = 50;
			this.layName.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layCode.Control = this.dInputCode;
			this.layCode.Height = 29;
			this.layCode.MinSize = new global::System.Drawing.Size(64, 18);
			this.layCode.Name = "layCode";
			this.layCode.Text = "ProductCode";
			this.layCode.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layCode.Width = 50;
			this.layCode.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem4.Control = this.cmbBusinessType;
			this.layoutControlItem4.Height = 28;
			this.layoutControlItem4.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem4.Name = "layoutControlItem4";
			this.layoutControlItem4.Text = "BusinessType";
			this.layoutControlItem4.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem4.Width = 50;
			this.layoutControlItem4.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem11.Control = this.cmbPackType;
			this.layoutControlItem11.Height = 28;
			this.layoutControlItem11.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem11.Name = "layoutControlItem11";
			this.layoutControlItem11.Text = "PackType";
			this.layoutControlItem11.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem11.Width = 50;
			this.layoutControlItem11.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem8.Control = this.dInputSpecsAmount;
			this.layoutControlItem8.Height = 29;
			this.layoutControlItem8.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem8.Name = "layoutControlItem8";
			this.layoutControlItem8.Text = "SpecsAmount(kg)";
			this.layoutControlItem8.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem8.Width = 50;
			this.layoutControlItem8.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem16.Control = this.dInputSpecsShell;
			this.layoutControlItem16.Height = 29;
			this.layoutControlItem16.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem16.Name = "layoutControlItem16";
			this.layoutControlItem16.Text = "SpecsShell(kg)";
			this.layoutControlItem16.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem16.Width = 50;
			this.layoutControlItem16.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem15.Control = this.txtSpecsDescribe;
			this.layoutControlItem15.Height = 29;
			this.layoutControlItem15.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem15.Name = "layoutControlItem15";
			this.layoutControlItem15.Text = "SpecsDescribe";
			this.layoutControlItem15.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem15.Width = 50;
			this.layoutControlItem15.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem19.Control = this.dInputPositivePrecise;
			this.layoutControlItem19.Height = 29;
			this.layoutControlItem19.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem19.Name = "layoutControlItem19";
			this.layoutControlItem19.Text = "PositivePrecise(kg)";
			this.layoutControlItem19.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem19.Width = 50;
			this.layoutControlItem19.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem25.Control = this.dInputNagativePrecise;
			this.layoutControlItem25.Height = 29;
			this.layoutControlItem25.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem25.Name = "layoutControlItem25";
			this.layoutControlItem25.Text = "NagativePrecise(kg)";
			this.layoutControlItem25.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem25.Width = 50;
			this.layoutControlItem25.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem20.Control = this.cmbValidCondition;
			this.layoutControlItem20.Height = 29;
			this.layoutControlItem20.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem20.Name = "layoutControlItem20";
			this.layoutControlItem20.Text = "ValidCondition";
			this.layoutControlItem20.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem20.Width = 50;
			this.layoutControlItem20.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem21.Control = this.cmbPostType;
			this.layoutControlItem21.Height = 29;
			this.layoutControlItem21.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem21.Name = "layoutControlItem21";
			this.layoutControlItem21.Text = "PostType";
			this.layoutControlItem21.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem21.Width = 50;
			this.layoutControlItem21.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem22.Control = this.cmbState;
			this.layoutControlItem22.Height = 29;
			this.layoutControlItem22.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem22.Name = "layoutControlItem22";
			this.layoutControlItem22.Text = "EffectState";
			this.layoutControlItem22.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem22.Width = 50;
			this.layoutControlItem22.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem24.Control = this.tInputEffectTime;
			this.layoutControlItem24.Height = 29;
			this.layoutControlItem24.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem24.Name = "layoutControlItem24";
			this.layoutControlItem24.Text = "EffectTime";
			this.layoutControlItem24.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem24.Width = 50;
			this.layoutControlItem24.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.laySunHao.Control = this.dInputSunHao;
			this.laySunHao.Height = 29;
			this.laySunHao.MinSize = new global::System.Drawing.Size(64, 18);
			this.laySunHao.Name = "laySunHao";
			this.laySunHao.Text = "SunHao";
			this.laySunHao.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.laySunHao.Width = 50;
			this.laySunHao.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layDensity.Control = this.dInputMidu;
			this.layDensity.Height = 29;
			this.layDensity.MinSize = new global::System.Drawing.Size(64, 18);
			this.layDensity.Name = "layDensity";
			this.layDensity.Text = "MiDu(kg/m³)";
			this.layDensity.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layDensity.Width = 50;
			this.layDensity.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layRemark.Control = this.rtbRemark;
			this.layRemark.Height = 58;
			this.layRemark.MinSize = new global::System.Drawing.Size(64, 18);
			this.layRemark.Name = "layRemark";
			this.layRemark.Text = "Remark";
			this.layRemark.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layRemark.Width = 100;
			this.layRemark.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem6.Control = this.chkSingle;
			this.layoutControlItem6.Height = 31;
			this.layoutControlItem6.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem6.Name = "layoutControlItem6";
			this.layoutControlItem6.Text = " ";
			this.layoutControlItem6.Width = 50;
			this.layoutControlItem6.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem14.Control = this.chkCombin;
			this.layoutControlItem14.Height = 31;
			this.layoutControlItem14.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem14.Name = "layoutControlItem14";
			this.layoutControlItem14.Text = " ";
			this.layoutControlItem14.Width = 50;
			this.layoutControlItem14.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layAdd.Control = this.btnAdd;
			this.layAdd.Height = 31;
			this.layAdd.MinSize = new global::System.Drawing.Size(32, 20);
			this.layAdd.Name = "layAdd";
			this.layAdd.Text = " ";
			this.layAdd.Width = 160;
			this.layoutControlItem5.Height = 31;
			this.layoutControlItem5.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem5.Name = "layoutControlItem5";
			this.layoutControlItem5.Text = " ";
			this.layoutControlItem5.Width = 50;
			this.layoutControlItem5.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem13.Height = 31;
			this.layoutControlItem13.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem13.Name = "layoutControlItem13";
			this.layoutControlItem13.Text = " ";
			this.layoutControlItem13.Width = 50;
			this.layoutControlItem13.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem1.Control = this.txtInvCode;
			this.layoutControlItem1.Height = 29;
			this.layoutControlItem1.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Text = "*ProductName";
			this.layoutControlItem1.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem1.Width = 50;
			this.layoutControlItem1.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem7.Control = this.dInputSpecsAmount;
			this.layoutControlItem7.Height = 29;
			this.layoutControlItem7.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem7.Name = "layoutControlItem7";
			this.layoutControlItem7.Text = "*ProductCode";
			this.layoutControlItem7.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem7.Width = 50;
			this.layoutControlItem7.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem9.Height = 28;
			this.layoutControlItem9.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem9.Name = "layoutControlItem9";
			this.layoutControlItem9.Text = "DanWei";
			this.layoutControlItem9.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem9.Width = 100;
			this.layoutControlItem9.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem12.Control = this.txtSpecsDescribe;
			this.layoutControlItem12.Height = 29;
			this.layoutControlItem12.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem12.Name = "layoutControlItem12";
			this.layoutControlItem12.Text = "SpecsName";
			this.layoutControlItem12.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem12.Width = 100;
			this.layoutControlItem12.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem18.Control = this.dInputPositivePrecise;
			this.layoutControlItem18.Height = 29;
			this.layoutControlItem18.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem18.Name = "layoutControlItem18";
			this.layoutControlItem18.Text = "MiDu(kg/m³)";
			this.layoutControlItem18.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem18.Width = 50;
			this.layoutControlItem18.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem23.Control = this.tInputEffectTime;
			this.layoutControlItem23.Height = 29;
			this.layoutControlItem23.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem23.Name = "layoutControlItem23";
			this.layoutControlItem23.Text = "ChkDate";
			this.layoutControlItem23.Width = 50;
			this.layoutControlItem23.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.cmbQueue.DataSource = null;
			this.cmbQueue.DisplayMember = null;
			this.cmbQueue.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cmbQueue.FormattingEnabled = true;
			this.cmbQueue.ItemHeight = 15;
			this.cmbQueue.Location = new global::System.Drawing.Point(397, 148);
			this.cmbQueue.Margin = new global::System.Windows.Forms.Padding(0);
			this.cmbQueue.MaxDropDownItems = 20;
			this.cmbQueue.Name = "cmbQueue";
			this.cmbQueue.SelectMember = null;
			this.cmbQueue.Size = new global::System.Drawing.Size(136, 21);
			this.cmbQueue.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.cmbQueue.TabIndex = 9;
			this.cmbQueue.ValueMember = null;
			this.layoutControlItem17.Control = this.cmbQueue;
			this.layoutControlItem17.Height = 29;
			this.layoutControlItem17.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem17.Name = "layoutControlItem17";
			this.layoutControlItem17.Text = "QuereWareHouse";
			this.layoutControlItem17.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem17.Width = 50;
			this.layoutControlItem17.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			base.ClientSize = new global::System.Drawing.Size(537, 543);
			base.Controls.Add(this.layoutControl1);
			base.Controls.Add(this.menuBar);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "frmProductEditShow";
			this.Text = "ProductEdit";
			base.Load += new global::System.EventHandler(this.frmProductEditShow_Load);
			((global::System.ComponentModel.ISupportInitialize)this.menuBar).EndInit();
			this.layoutControl1.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.dInputNagativePrecise).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.dInputCode).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.dInputSunHao).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.dInputMidu).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.dInputSpecsAmount).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.dInputSpecsShell).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.dInputPositivePrecise).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.tInputEffectTime).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000859 RID: 2137
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400085A RID: 2138
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem lciCheDao;

		// Token: 0x0400085B RID: 2139
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem10;

		// Token: 0x0400085C RID: 2140
		private global::DevComponents.DotNetBar.Bar menuBar;

		// Token: 0x0400085D RID: 2141
		private global::DevComponents.DotNetBar.ButtonItem btnSave;

		// Token: 0x0400085E RID: 2142
		private global::DevComponents.DotNetBar.Layout.LayoutControl layoutControl1;

		// Token: 0x0400085F RID: 2143
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtName;

		// Token: 0x04000860 RID: 2144
		private global::DevComponents.Editors.DoubleInput dInputMidu;

		// Token: 0x04000861 RID: 2145
		private global::DevComponents.DotNetBar.Controls.RichTextBoxEx rtbRemark;

		// Token: 0x04000862 RID: 2146
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layName;

		// Token: 0x04000863 RID: 2147
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layDensity;

		// Token: 0x04000864 RID: 2148
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layRemark;

		// Token: 0x04000865 RID: 2149
		private global::DevComponents.DotNetBar.Controls.CheckBoxX chkSingle;

		// Token: 0x04000866 RID: 2150
		private global::DevComponents.DotNetBar.Controls.CheckBoxX chkCombin;

		// Token: 0x04000867 RID: 2151
		private global::DevComponents.DotNetBar.ButtonX btnAdd;

		// Token: 0x04000868 RID: 2152
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem6;

		// Token: 0x04000869 RID: 2153
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem14;

		// Token: 0x0400086A RID: 2154
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layAdd;

		// Token: 0x0400086B RID: 2155
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem5;

		// Token: 0x0400086C RID: 2156
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem13;

		// Token: 0x0400086D RID: 2157
		private global::DevComponents.Editors.DoubleInput dInputCode;

		// Token: 0x0400086E RID: 2158
		private global::DevComponents.Editors.DoubleInput dInputSunHao;

		// Token: 0x0400086F RID: 2159
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layCode;

		// Token: 0x04000870 RID: 2160
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem laySunHao;

		// Token: 0x04000871 RID: 2161
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtInvCode;

		// Token: 0x04000872 RID: 2162
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem2;

		// Token: 0x04000873 RID: 2163
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem1;

		// Token: 0x04000874 RID: 2164
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtInvName;

		// Token: 0x04000875 RID: 2165
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem3;

		// Token: 0x04000876 RID: 2166
		private global::DevComponents.Editors.DoubleInput dInputSpecsAmount;

		// Token: 0x04000877 RID: 2167
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem8;

		// Token: 0x04000878 RID: 2168
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem7;

		// Token: 0x04000879 RID: 2169
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem9;

		// Token: 0x0400087A RID: 2170
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtSpecsDescribe;

		// Token: 0x0400087B RID: 2171
		private global::DevComponents.Editors.DoubleInput dInputSpecsShell;

		// Token: 0x0400087C RID: 2172
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem16;

		// Token: 0x0400087D RID: 2173
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem15;

		// Token: 0x0400087E RID: 2174
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem12;

		// Token: 0x0400087F RID: 2175
		private global::DevComponents.Editors.DoubleInput dInputPositivePrecise;

		// Token: 0x04000880 RID: 2176
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem19;

		// Token: 0x04000881 RID: 2177
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem18;

		// Token: 0x04000882 RID: 2178
		private global::DevComponents.DotNetBar.Controls.ComboBoxEx cmbValidCondition;

		// Token: 0x04000883 RID: 2179
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem20;

		// Token: 0x04000884 RID: 2180
		private global::DevComponents.DotNetBar.Controls.ComboBoxEx cmbPostType;

		// Token: 0x04000885 RID: 2181
		private global::DevComponents.DotNetBar.Controls.ComboBoxEx cmbState;

		// Token: 0x04000886 RID: 2182
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem21;

		// Token: 0x04000887 RID: 2183
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem22;

		// Token: 0x04000888 RID: 2184
		private global::DevComponents.Editors.DateTimeAdv.DateTimeInput tInputEffectTime;

		// Token: 0x04000889 RID: 2185
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem24;

		// Token: 0x0400088A RID: 2186
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem23;

		// Token: 0x0400088B RID: 2187
		private global::DevComponents.Editors.DoubleInput dInputNagativePrecise;

		// Token: 0x0400088C RID: 2188
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem25;

		// Token: 0x0400088D RID: 2189
		private global::DevComponents.DotNetBar.Controls.ComboBoxEx cmbPackType;

		// Token: 0x0400088E RID: 2190
		private global::DevComponents.DotNetBar.Controls.ComboBoxEx cmbBusinessType;

		// Token: 0x0400088F RID: 2191
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem4;

		// Token: 0x04000890 RID: 2192
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem11;

		// Token: 0x04000891 RID: 2193
		private global::Base.AutoComboBox cmbQueue;

		// Token: 0x04000892 RID: 2194
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem17;
	}
}
