namespace SQSClient
{
	// Token: 0x0200000E RID: 14
	public partial class frmAssistAccountSure : global::SQSClient.BaseDialogForm
	{
		// Token: 0x06000074 RID: 116 RVA: 0x0000A790 File Offset: 0x00008990
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000075 RID: 117 RVA: 0x0000A7C8 File Offset: 0x000089C8
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::SQSClient.frmAssistAccountSure));
			this.layoutControlItem4 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.menuBar = new global::DevComponents.DotNetBar.Bar();
			this.btnSure = new global::DevComponents.DotNetBar.ButtonItem();
			this.btnCancel = new global::DevComponents.DotNetBar.ButtonItem();
			this.splitContainer1 = new global::System.Windows.Forms.SplitContainer();
			this.gbxImportTicket = new global::System.Windows.Forms.GroupBox();
			this.layoutControl1 = new global::DevComponents.DotNetBar.Layout.LayoutControl();
			this.tbxImportDanHao = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.iptImportAssistPlanAccount = new global::DevComponents.Editors.IntegerInput();
			this.iptImportAssistActualAccount = new global::DevComponents.Editors.IntegerInput();
			this.tbxImportInvName = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.cmbImportPostType = new global::DevComponents.DotNetBar.Controls.ComboBoxEx();
			this.layoutControlItem1 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem10 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem11 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem3 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem8 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.gbxReferenceTicket = new global::System.Windows.Forms.GroupBox();
			this.layoutControl2 = new global::DevComponents.DotNetBar.Layout.LayoutControl();
			this.tbxReferenceDanHao = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.iptRefAssistPlanAccount = new global::DevComponents.Editors.IntegerInput();
			this.iptRefAssistActualAccount = new global::DevComponents.Editors.IntegerInput();
			this.tbxRefInvName = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.cmbRefPostType = new global::DevComponents.DotNetBar.Controls.ComboBoxEx();
			this.layoutControlItem5 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem9 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem13 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem14 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem7 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem2 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem6 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem21 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem12 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			((global::System.ComponentModel.ISupportInitialize)this.menuBar).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.splitContainer1).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.gbxImportTicket.SuspendLayout();
			this.layoutControl1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.iptImportAssistPlanAccount).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.iptImportAssistActualAccount).BeginInit();
			this.gbxReferenceTicket.SuspendLayout();
			this.layoutControl2.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.iptRefAssistPlanAccount).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.iptRefAssistActualAccount).BeginInit();
			base.SuspendLayout();
			this.layoutControlItem4.Height = 29;
			this.layoutControlItem4.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem4.Name = "layoutControlItem4";
			this.layoutControlItem4.Text = "*路号：";
			this.layoutControlItem4.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem4.Width = 88;
			this.layoutControlItem4.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.menuBar.AccessibleDescription = "DotNetBar Bar (menuBar)";
			this.menuBar.AccessibleName = "DotNetBar Bar";
			this.menuBar.AccessibleRole = global::System.Windows.Forms.AccessibleRole.MenuBar;
			this.menuBar.BackColor = global::System.Drawing.Color.Transparent;
			this.menuBar.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.menuBar.Font = new global::System.Drawing.Font("微软雅黑", 9f);
			this.menuBar.IsMaximized = false;
			this.menuBar.Items.AddRange(new global::DevComponents.DotNetBar.BaseItem[]
			{
				this.btnSure,
				this.btnCancel
			});
			this.menuBar.Location = new global::System.Drawing.Point(0, 0);
			this.menuBar.MenuBar = true;
			this.menuBar.Name = "menuBar";
			this.menuBar.Size = new global::System.Drawing.Size(389, 26);
			this.menuBar.Stretch = true;
			this.menuBar.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.menuBar.TabIndex = 21;
			this.menuBar.TabStop = false;
			this.menuBar.Text = "Main Menu";
			this.btnSure.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.btnSure.Image = global::SQSClient.Properties.Resources.save16;
			this.btnSure.Name = "btnSure";
			this.btnSure.Text = "Sure";
			this.btnSure.Click += new global::System.EventHandler(this.btnSure_Click);
			this.btnCancel.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.btnCancel.Image = global::SQSClient.Properties.Resources.cancel16;
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Text = "Cancel";
			this.btnCancel.Click += new global::System.EventHandler(this.btnCancel_Click);
			this.splitContainer1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new global::System.Drawing.Point(0, 26);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = global::System.Windows.Forms.Orientation.Horizontal;
			this.splitContainer1.Panel1.Controls.Add(this.gbxImportTicket);
			this.splitContainer1.Panel2.Controls.Add(this.gbxReferenceTicket);
			this.splitContainer1.Size = new global::System.Drawing.Size(389, 397);
			this.splitContainer1.SplitterDistance = 176;
			this.splitContainer1.TabIndex = 22;
			this.gbxImportTicket.Controls.Add(this.layoutControl1);
			this.gbxImportTicket.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.gbxImportTicket.Location = new global::System.Drawing.Point(0, 0);
			this.gbxImportTicket.Margin = new global::System.Windows.Forms.Padding(0);
			this.gbxImportTicket.Name = "gbxImportTicket";
			this.gbxImportTicket.Size = new global::System.Drawing.Size(389, 176);
			this.gbxImportTicket.TabIndex = 25;
			this.gbxImportTicket.TabStop = false;
			this.gbxImportTicket.Text = "ImportTicket";
			this.layoutControl1.Controls.Add(this.tbxImportDanHao);
			this.layoutControl1.Controls.Add(this.iptImportAssistPlanAccount);
			this.layoutControl1.Controls.Add(this.iptImportAssistActualAccount);
			this.layoutControl1.Controls.Add(this.tbxImportInvName);
			this.layoutControl1.Controls.Add(this.cmbImportPostType);
			this.layoutControl1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.layoutControl1.Location = new global::System.Drawing.Point(3, 17);
			this.layoutControl1.Name = "layoutControl1";
			this.layoutControl1.RootGroup.Items.AddRange(new global::DevComponents.DotNetBar.Layout.LayoutItemBase[]
			{
				this.layoutControlItem1,
				this.layoutControlItem10,
				this.layoutControlItem11,
				this.layoutControlItem3,
				this.layoutControlItem8
			});
			this.layoutControl1.Size = new global::System.Drawing.Size(383, 156);
			this.layoutControl1.TabIndex = 23;
			this.tbxImportDanHao.Border.Class = "TextBoxBorder";
			this.tbxImportDanHao.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.tbxImportDanHao.Location = new global::System.Drawing.Point(129, 4);
			this.tbxImportDanHao.Margin = new global::System.Windows.Forms.Padding(0);
			this.tbxImportDanHao.MaxLength = 20;
			this.tbxImportDanHao.Name = "tbxImportDanHao";
			this.tbxImportDanHao.PreventEnterBeep = true;
			this.tbxImportDanHao.ReadOnly = true;
			this.tbxImportDanHao.Size = new global::System.Drawing.Size(250, 21);
			this.tbxImportDanHao.TabIndex = 0;
			this.iptImportAssistPlanAccount.BackgroundStyle.Class = "DateTimeInputBackground";
			this.iptImportAssistPlanAccount.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.iptImportAssistPlanAccount.ButtonFreeText.Shortcut = global::DevComponents.DotNetBar.eShortcut.F2;
			this.iptImportAssistPlanAccount.Enabled = false;
			this.iptImportAssistPlanAccount.InputHorizontalAlignment = global::DevComponents.Editors.eHorizontalAlignment.Left;
			this.iptImportAssistPlanAccount.Location = new global::System.Drawing.Point(129, 91);
			this.iptImportAssistPlanAccount.Margin = new global::System.Windows.Forms.Padding(0);
			this.iptImportAssistPlanAccount.MaxValue = 999999999;
			this.iptImportAssistPlanAccount.MinValue = 0;
			this.iptImportAssistPlanAccount.Name = "iptImportAssistPlanAccount";
			this.iptImportAssistPlanAccount.ShowUpDown = true;
			this.iptImportAssistPlanAccount.Size = new global::System.Drawing.Size(250, 21);
			this.iptImportAssistPlanAccount.TabIndex = 3;
			this.iptImportAssistPlanAccount.Value = 1;
			this.iptImportAssistActualAccount.BackgroundStyle.Class = "DateTimeInputBackground";
			this.iptImportAssistActualAccount.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.iptImportAssistActualAccount.ButtonFreeText.Shortcut = global::DevComponents.DotNetBar.eShortcut.F2;
			this.iptImportAssistActualAccount.InputHorizontalAlignment = global::DevComponents.Editors.eHorizontalAlignment.Left;
			this.iptImportAssistActualAccount.Location = new global::System.Drawing.Point(129, 120);
			this.iptImportAssistActualAccount.Margin = new global::System.Windows.Forms.Padding(0);
			this.iptImportAssistActualAccount.MaxValue = 999999999;
			this.iptImportAssistActualAccount.MinValue = 0;
			this.iptImportAssistActualAccount.Name = "iptImportAssistActualAccount";
			this.iptImportAssistActualAccount.ShowUpDown = true;
			this.iptImportAssistActualAccount.Size = new global::System.Drawing.Size(250, 21);
			this.iptImportAssistActualAccount.TabIndex = 4;
			this.iptImportAssistActualAccount.Value = 1;
			this.tbxImportInvName.Border.Class = "TextBoxBorder";
			this.tbxImportInvName.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.tbxImportInvName.Location = new global::System.Drawing.Point(129, 33);
			this.tbxImportInvName.Margin = new global::System.Windows.Forms.Padding(0);
			this.tbxImportInvName.MaxLength = 20;
			this.tbxImportInvName.Name = "tbxImportInvName";
			this.tbxImportInvName.PreventEnterBeep = true;
			this.tbxImportInvName.ReadOnly = true;
			this.tbxImportInvName.Size = new global::System.Drawing.Size(250, 21);
			this.tbxImportInvName.TabIndex = 1;
			this.cmbImportPostType.DisplayMember = "Text";
			this.cmbImportPostType.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cmbImportPostType.Enabled = false;
			this.cmbImportPostType.FormattingEnabled = true;
			this.cmbImportPostType.ItemHeight = 15;
			this.cmbImportPostType.Location = new global::System.Drawing.Point(129, 62);
			this.cmbImportPostType.Margin = new global::System.Windows.Forms.Padding(0);
			this.cmbImportPostType.Name = "cmbImportPostType";
			this.cmbImportPostType.Size = new global::System.Drawing.Size(250, 21);
			this.cmbImportPostType.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.cmbImportPostType.TabIndex = 2;
			this.layoutControlItem1.Control = this.tbxImportDanHao;
			this.layoutControlItem1.Height = 29;
			this.layoutControlItem1.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Text = "ImportDanHao";
			this.layoutControlItem1.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem1.Width = 100;
			this.layoutControlItem1.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem10.Control = this.tbxImportInvName;
			this.layoutControlItem10.Height = 29;
			this.layoutControlItem10.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem10.Name = "layoutControlItem10";
			this.layoutControlItem10.Text = "InvName";
			this.layoutControlItem10.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem10.Width = 100;
			this.layoutControlItem10.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem11.Control = this.cmbImportPostType;
			this.layoutControlItem11.Height = 29;
			this.layoutControlItem11.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem11.Name = "layoutControlItem11";
			this.layoutControlItem11.Text = "PostType";
			this.layoutControlItem11.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem11.Width = 100;
			this.layoutControlItem11.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem3.Control = this.iptImportAssistPlanAccount;
			this.layoutControlItem3.Height = 29;
			this.layoutControlItem3.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem3.Name = "layoutControlItem3";
			this.layoutControlItem3.Text = "AssistPlanAccount";
			this.layoutControlItem3.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem3.Width = 100;
			this.layoutControlItem3.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem8.Control = this.iptImportAssistActualAccount;
			this.layoutControlItem8.Height = 29;
			this.layoutControlItem8.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem8.Name = "layoutControlItem8";
			this.layoutControlItem8.Text = "AssistActualAccount";
			this.layoutControlItem8.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem8.Width = 100;
			this.layoutControlItem8.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.gbxReferenceTicket.Controls.Add(this.layoutControl2);
			this.gbxReferenceTicket.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.gbxReferenceTicket.Location = new global::System.Drawing.Point(0, 0);
			this.gbxReferenceTicket.Margin = new global::System.Windows.Forms.Padding(0);
			this.gbxReferenceTicket.Name = "gbxReferenceTicket";
			this.gbxReferenceTicket.Size = new global::System.Drawing.Size(389, 217);
			this.gbxReferenceTicket.TabIndex = 24;
			this.gbxReferenceTicket.TabStop = false;
			this.gbxReferenceTicket.Text = "ReferenceTicket";
			this.layoutControl2.Controls.Add(this.tbxReferenceDanHao);
			this.layoutControl2.Controls.Add(this.iptRefAssistPlanAccount);
			this.layoutControl2.Controls.Add(this.iptRefAssistActualAccount);
			this.layoutControl2.Controls.Add(this.tbxRefInvName);
			this.layoutControl2.Controls.Add(this.cmbRefPostType);
			this.layoutControl2.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.layoutControl2.Location = new global::System.Drawing.Point(3, 17);
			this.layoutControl2.Name = "layoutControl2";
			this.layoutControl2.RootGroup.Items.AddRange(new global::DevComponents.DotNetBar.Layout.LayoutItemBase[]
			{
				this.layoutControlItem5,
				this.layoutControlItem9,
				this.layoutControlItem13,
				this.layoutControlItem14,
				this.layoutControlItem7
			});
			this.layoutControl2.Size = new global::System.Drawing.Size(383, 197);
			this.layoutControl2.TabIndex = 23;
			this.tbxReferenceDanHao.Border.Class = "TextBoxBorder";
			this.tbxReferenceDanHao.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.tbxReferenceDanHao.Location = new global::System.Drawing.Point(129, 4);
			this.tbxReferenceDanHao.Margin = new global::System.Windows.Forms.Padding(0);
			this.tbxReferenceDanHao.MaxLength = 20;
			this.tbxReferenceDanHao.Name = "tbxReferenceDanHao";
			this.tbxReferenceDanHao.PreventEnterBeep = true;
			this.tbxReferenceDanHao.ReadOnly = true;
			this.tbxReferenceDanHao.Size = new global::System.Drawing.Size(250, 21);
			this.tbxReferenceDanHao.TabIndex = 0;
			this.iptRefAssistPlanAccount.BackgroundStyle.Class = "DateTimeInputBackground";
			this.iptRefAssistPlanAccount.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.iptRefAssistPlanAccount.ButtonFreeText.Shortcut = global::DevComponents.DotNetBar.eShortcut.F2;
			this.iptRefAssistPlanAccount.Enabled = false;
			this.iptRefAssistPlanAccount.InputHorizontalAlignment = global::DevComponents.Editors.eHorizontalAlignment.Left;
			this.iptRefAssistPlanAccount.Location = new global::System.Drawing.Point(129, 91);
			this.iptRefAssistPlanAccount.Margin = new global::System.Windows.Forms.Padding(0);
			this.iptRefAssistPlanAccount.MaxValue = 999999999;
			this.iptRefAssistPlanAccount.MinValue = 0;
			this.iptRefAssistPlanAccount.Name = "iptRefAssistPlanAccount";
			this.iptRefAssistPlanAccount.ShowUpDown = true;
			this.iptRefAssistPlanAccount.Size = new global::System.Drawing.Size(250, 21);
			this.iptRefAssistPlanAccount.TabIndex = 3;
			this.iptRefAssistPlanAccount.Value = 1;
			this.iptRefAssistActualAccount.BackgroundStyle.Class = "DateTimeInputBackground";
			this.iptRefAssistActualAccount.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.iptRefAssistActualAccount.ButtonFreeText.Shortcut = global::DevComponents.DotNetBar.eShortcut.F2;
			this.iptRefAssistActualAccount.Enabled = false;
			this.iptRefAssistActualAccount.InputHorizontalAlignment = global::DevComponents.Editors.eHorizontalAlignment.Left;
			this.iptRefAssistActualAccount.Location = new global::System.Drawing.Point(129, 120);
			this.iptRefAssistActualAccount.Margin = new global::System.Windows.Forms.Padding(0);
			this.iptRefAssistActualAccount.MaxValue = 999999999;
			this.iptRefAssistActualAccount.MinValue = 0;
			this.iptRefAssistActualAccount.Name = "iptRefAssistActualAccount";
			this.iptRefAssistActualAccount.ShowUpDown = true;
			this.iptRefAssistActualAccount.Size = new global::System.Drawing.Size(250, 21);
			this.iptRefAssistActualAccount.TabIndex = 4;
			this.iptRefAssistActualAccount.Value = 1;
			this.tbxRefInvName.Border.Class = "TextBoxBorder";
			this.tbxRefInvName.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.tbxRefInvName.Location = new global::System.Drawing.Point(129, 33);
			this.tbxRefInvName.Margin = new global::System.Windows.Forms.Padding(0);
			this.tbxRefInvName.MaxLength = 20;
			this.tbxRefInvName.Name = "tbxRefInvName";
			this.tbxRefInvName.PreventEnterBeep = true;
			this.tbxRefInvName.ReadOnly = true;
			this.tbxRefInvName.Size = new global::System.Drawing.Size(250, 21);
			this.tbxRefInvName.TabIndex = 1;
			this.cmbRefPostType.DisplayMember = "Text";
			this.cmbRefPostType.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cmbRefPostType.Enabled = false;
			this.cmbRefPostType.FormattingEnabled = true;
			this.cmbRefPostType.ItemHeight = 15;
			this.cmbRefPostType.Location = new global::System.Drawing.Point(129, 62);
			this.cmbRefPostType.Margin = new global::System.Windows.Forms.Padding(0);
			this.cmbRefPostType.Name = "cmbRefPostType";
			this.cmbRefPostType.Size = new global::System.Drawing.Size(250, 21);
			this.cmbRefPostType.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.cmbRefPostType.TabIndex = 2;
			this.layoutControlItem5.Control = this.tbxReferenceDanHao;
			this.layoutControlItem5.Height = 29;
			this.layoutControlItem5.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem5.Name = "layoutControlItem5";
			this.layoutControlItem5.Text = "ReferenceDanHao";
			this.layoutControlItem5.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem5.Width = 100;
			this.layoutControlItem5.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem9.Control = this.tbxRefInvName;
			this.layoutControlItem9.Height = 29;
			this.layoutControlItem9.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem9.Name = "layoutControlItem9";
			this.layoutControlItem9.Text = "InvName";
			this.layoutControlItem9.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem9.Width = 100;
			this.layoutControlItem9.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem13.Control = this.cmbRefPostType;
			this.layoutControlItem13.Height = 29;
			this.layoutControlItem13.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem13.Name = "layoutControlItem13";
			this.layoutControlItem13.Text = "PostType";
			this.layoutControlItem13.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem13.Width = 100;
			this.layoutControlItem13.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem14.Control = this.iptRefAssistPlanAccount;
			this.layoutControlItem14.Height = 29;
			this.layoutControlItem14.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem14.Name = "layoutControlItem14";
			this.layoutControlItem14.Text = "AssistPlanAccount";
			this.layoutControlItem14.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem14.Width = 100;
			this.layoutControlItem14.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem7.Control = this.iptRefAssistActualAccount;
			this.layoutControlItem7.Height = 29;
			this.layoutControlItem7.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem7.Name = "layoutControlItem7";
			this.layoutControlItem7.Text = "AssistActualAccount";
			this.layoutControlItem7.Width = 100;
			this.layoutControlItem7.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem2.Control = this.iptImportAssistPlanAccount;
			this.layoutControlItem2.Height = 29;
			this.layoutControlItem2.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem2.Name = "layoutControlItem2";
			this.layoutControlItem2.Text = "AssistPlanAccount";
			this.layoutControlItem2.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem2.Width = 100;
			this.layoutControlItem2.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem6.Control = this.iptImportAssistActualAccount;
			this.layoutControlItem6.Height = 29;
			this.layoutControlItem6.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem6.Name = "layoutControlItem6";
			this.layoutControlItem6.Text = "AssistActualAccount";
			this.layoutControlItem6.Width = 100;
			this.layoutControlItem6.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem21.Control = this.cmbImportPostType;
			this.layoutControlItem21.Height = 29;
			this.layoutControlItem21.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem21.Name = "layoutControlItem21";
			this.layoutControlItem21.Text = "PostType";
			this.layoutControlItem21.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem21.Width = 50;
			this.layoutControlItem21.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem12.Control = this.cmbRefPostType;
			this.layoutControlItem12.Height = 29;
			this.layoutControlItem12.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem12.Name = "layoutControlItem12";
			this.layoutControlItem12.Text = "PostType";
			this.layoutControlItem12.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem12.Width = 100;
			this.layoutControlItem12.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			base.ClientSize = new global::System.Drawing.Size(389, 423);
			base.Controls.Add(this.splitContainer1);
			base.Controls.Add(this.menuBar);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "frmAssistAccountSure";
			this.Text = "AssistAccount";
			base.Load += new global::System.EventHandler(this.frmAssistAccountSure_Load);
			((global::System.ComponentModel.ISupportInitialize)this.menuBar).EndInit();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.splitContainer1).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.gbxImportTicket.ResumeLayout(false);
			this.layoutControl1.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.iptImportAssistPlanAccount).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.iptImportAssistActualAccount).EndInit();
			this.gbxReferenceTicket.ResumeLayout(false);
			this.layoutControl2.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.iptRefAssistPlanAccount).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.iptRefAssistActualAccount).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x0400008D RID: 141
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400008E RID: 142
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem4;

		// Token: 0x0400008F RID: 143
		private global::DevComponents.DotNetBar.Bar menuBar;

		// Token: 0x04000090 RID: 144
		private global::DevComponents.DotNetBar.ButtonItem btnSure;

		// Token: 0x04000091 RID: 145
		private global::System.Windows.Forms.SplitContainer splitContainer1;

		// Token: 0x04000092 RID: 146
		private global::System.Windows.Forms.GroupBox gbxReferenceTicket;

		// Token: 0x04000093 RID: 147
		private global::DevComponents.DotNetBar.Layout.LayoutControl layoutControl2;

		// Token: 0x04000094 RID: 148
		private global::DevComponents.DotNetBar.Controls.TextBoxX tbxReferenceDanHao;

		// Token: 0x04000095 RID: 149
		private global::DevComponents.Editors.IntegerInput iptRefAssistPlanAccount;

		// Token: 0x04000096 RID: 150
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem5;

		// Token: 0x04000097 RID: 151
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem14;

		// Token: 0x04000098 RID: 152
		private global::System.Windows.Forms.GroupBox gbxImportTicket;

		// Token: 0x04000099 RID: 153
		private global::DevComponents.DotNetBar.Layout.LayoutControl layoutControl1;

		// Token: 0x0400009A RID: 154
		private global::DevComponents.DotNetBar.Controls.TextBoxX tbxImportDanHao;

		// Token: 0x0400009B RID: 155
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem1;

		// Token: 0x0400009C RID: 156
		private global::DevComponents.Editors.IntegerInput iptRefAssistActualAccount;

		// Token: 0x0400009D RID: 157
		private global::DevComponents.DotNetBar.Controls.TextBoxX tbxRefInvName;

		// Token: 0x0400009E RID: 158
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem9;

		// Token: 0x0400009F RID: 159
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem7;

		// Token: 0x040000A0 RID: 160
		private global::DevComponents.Editors.IntegerInput iptImportAssistPlanAccount;

		// Token: 0x040000A1 RID: 161
		private global::DevComponents.Editors.IntegerInput iptImportAssistActualAccount;

		// Token: 0x040000A2 RID: 162
		private global::DevComponents.DotNetBar.Controls.TextBoxX tbxImportInvName;

		// Token: 0x040000A3 RID: 163
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem10;

		// Token: 0x040000A4 RID: 164
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem3;

		// Token: 0x040000A5 RID: 165
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem8;

		// Token: 0x040000A6 RID: 166
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem2;

		// Token: 0x040000A7 RID: 167
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem6;

		// Token: 0x040000A8 RID: 168
		private global::DevComponents.DotNetBar.ButtonItem btnCancel;

		// Token: 0x040000A9 RID: 169
		private global::DevComponents.DotNetBar.Controls.ComboBoxEx cmbImportPostType;

		// Token: 0x040000AA RID: 170
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem11;

		// Token: 0x040000AB RID: 171
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem21;

		// Token: 0x040000AC RID: 172
		private global::DevComponents.DotNetBar.Controls.ComboBoxEx cmbRefPostType;

		// Token: 0x040000AD RID: 173
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem13;

		// Token: 0x040000AE RID: 174
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem12;
	}
}
