namespace SQSClient
{
	// Token: 0x0200005C RID: 92
	public partial class frmSerialEdit : global::SQSClient.BaseDialogForm
	{
		// Token: 0x0600046F RID: 1135 RVA: 0x0006F98C File Offset: 0x0006DB8C
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000470 RID: 1136 RVA: 0x0006F9C4 File Offset: 0x0006DBC4
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::SQSClient.frmSerialEdit));
			this.layoutControl1 = new global::DevComponents.DotNetBar.Layout.LayoutControl();
			this.cmbStopBits = new global::DevComponents.DotNetBar.Controls.ComboBoxEx();
			this.cmbParity = new global::DevComponents.DotNetBar.Controls.ComboBoxEx();
			this.cmbDataBits = new global::DevComponents.DotNetBar.Controls.ComboBoxEx();
			this.cmbBaudRate = new global::DevComponents.DotNetBar.Controls.ComboBoxEx();
			this.comboItem1 = new global::DevComponents.Editors.ComboItem();
			this.comboItem2 = new global::DevComponents.Editors.ComboItem();
			this.comboItem3 = new global::DevComponents.Editors.ComboItem();
			this.comboItem4 = new global::DevComponents.Editors.ComboItem();
			this.cmbPortName = new global::DevComponents.DotNetBar.Controls.ComboBoxEx();
			this.layoutControlItem1 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem2 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem3 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem4 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem5 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.menuBar = new global::DevComponents.DotNetBar.Bar();
			this.btnSave = new global::DevComponents.DotNetBar.ButtonItem();
			this.layoutControl1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.menuBar).BeginInit();
			base.SuspendLayout();
			this.layoutControl1.Controls.Add(this.cmbStopBits);
			this.layoutControl1.Controls.Add(this.cmbParity);
			this.layoutControl1.Controls.Add(this.cmbDataBits);
			this.layoutControl1.Controls.Add(this.cmbBaudRate);
			this.layoutControl1.Controls.Add(this.cmbPortName);
			this.layoutControl1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.layoutControl1.Location = new global::System.Drawing.Point(0, 26);
			this.layoutControl1.Name = "layoutControl1";
			this.layoutControl1.RootGroup.Items.AddRange(new global::DevComponents.DotNetBar.Layout.LayoutItemBase[]
			{
				this.layoutControlItem1,
				this.layoutControlItem2,
				this.layoutControlItem3,
				this.layoutControlItem4,
				this.layoutControlItem5
			});
			this.layoutControl1.Size = new global::System.Drawing.Size(354, 171);
			this.layoutControl1.TabIndex = 0;
			this.cmbStopBits.DisplayMember = "Text";
			this.cmbStopBits.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cmbStopBits.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbStopBits.FormattingEnabled = true;
			this.cmbStopBits.ItemHeight = 16;
			this.cmbStopBits.Location = new global::System.Drawing.Point(61, 116);
			this.cmbStopBits.Margin = new global::System.Windows.Forms.Padding(0);
			this.cmbStopBits.Name = "cmbStopBits";
			this.cmbStopBits.Size = new global::System.Drawing.Size(289, 22);
			this.cmbStopBits.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.cmbStopBits.TabIndex = 4;
			this.cmbParity.DisplayMember = "Text";
			this.cmbParity.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cmbParity.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbParity.FormattingEnabled = true;
			this.cmbParity.ItemHeight = 16;
			this.cmbParity.Location = new global::System.Drawing.Point(61, 88);
			this.cmbParity.Margin = new global::System.Windows.Forms.Padding(0);
			this.cmbParity.Name = "cmbParity";
			this.cmbParity.Size = new global::System.Drawing.Size(289, 22);
			this.cmbParity.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.cmbParity.TabIndex = 3;
			this.cmbDataBits.DisplayMember = "Text";
			this.cmbDataBits.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cmbDataBits.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbDataBits.FormattingEnabled = true;
			this.cmbDataBits.ItemHeight = 16;
			this.cmbDataBits.Location = new global::System.Drawing.Point(61, 60);
			this.cmbDataBits.Margin = new global::System.Windows.Forms.Padding(0);
			this.cmbDataBits.Name = "cmbDataBits";
			this.cmbDataBits.Size = new global::System.Drawing.Size(289, 22);
			this.cmbDataBits.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.cmbDataBits.TabIndex = 2;
			this.cmbBaudRate.DisplayMember = "Text";
			this.cmbBaudRate.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cmbBaudRate.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbBaudRate.FormattingEnabled = true;
			this.cmbBaudRate.ItemHeight = 15;
			this.cmbBaudRate.Items.AddRange(new object[]
			{
				this.comboItem1,
				this.comboItem2,
				this.comboItem3,
				this.comboItem4
			});
			this.cmbBaudRate.Location = new global::System.Drawing.Point(61, 32);
			this.cmbBaudRate.Margin = new global::System.Windows.Forms.Padding(0);
			this.cmbBaudRate.MaxLength = 20;
			this.cmbBaudRate.Name = "cmbBaudRate";
			this.cmbBaudRate.Size = new global::System.Drawing.Size(289, 21);
			this.cmbBaudRate.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.cmbBaudRate.TabIndex = 1;
			this.comboItem1.Text = "9600";
			this.comboItem2.Text = "19200";
			this.comboItem3.Text = "57600";
			this.comboItem4.Text = "115200";
			this.cmbPortName.DisplayMember = "Text";
			this.cmbPortName.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cmbPortName.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbPortName.FormattingEnabled = true;
			this.cmbPortName.ItemHeight = 15;
			this.cmbPortName.Location = new global::System.Drawing.Point(61, 4);
			this.cmbPortName.Margin = new global::System.Windows.Forms.Padding(0);
			this.cmbPortName.MaxLength = 20;
			this.cmbPortName.Name = "cmbPortName";
			this.cmbPortName.Size = new global::System.Drawing.Size(289, 21);
			this.cmbPortName.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.cmbPortName.TabIndex = 0;
			this.cmbPortName.SelectedIndexChanged += new global::System.EventHandler(this.cmbPortName_SelectedIndexChanged);
			this.layoutControlItem1.Control = this.cmbPortName;
			this.layoutControlItem1.Height = 28;
			this.layoutControlItem1.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Text = "COMName";
			this.layoutControlItem1.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem1.Width = 100;
			this.layoutControlItem1.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem2.Control = this.cmbBaudRate;
			this.layoutControlItem2.Height = 28;
			this.layoutControlItem2.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem2.Name = "layoutControlItem2";
			this.layoutControlItem2.Text = "Baudrate";
			this.layoutControlItem2.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem2.Width = 100;
			this.layoutControlItem2.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem3.Control = this.cmbDataBits;
			this.layoutControlItem3.Height = 28;
			this.layoutControlItem3.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem3.Name = "layoutControlItem3";
			this.layoutControlItem3.Text = "Databit";
			this.layoutControlItem3.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem3.Width = 100;
			this.layoutControlItem3.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem4.Control = this.cmbParity;
			this.layoutControlItem4.Height = 28;
			this.layoutControlItem4.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem4.Name = "layoutControlItem4";
			this.layoutControlItem4.Text = "Checkbit";
			this.layoutControlItem4.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem4.Width = 100;
			this.layoutControlItem4.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem5.Control = this.cmbStopBits;
			this.layoutControlItem5.Height = 28;
			this.layoutControlItem5.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem5.Name = "layoutControlItem5";
			this.layoutControlItem5.Text = "Stopbit";
			this.layoutControlItem5.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem5.Width = 100;
			this.layoutControlItem5.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
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
			base.ClientSize = new global::System.Drawing.Size(354, 197);
			base.Controls.Add(this.layoutControl1);
			base.Controls.Add(this.menuBar);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "frmSerialEdit";
			this.Text = "frmSerialEdit";
			base.Load += new global::System.EventHandler(this.frmSerialEdit_Load);
			this.layoutControl1.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.menuBar).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x040007A2 RID: 1954
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x040007A3 RID: 1955
		private global::DevComponents.DotNetBar.Layout.LayoutControl layoutControl1;

		// Token: 0x040007A4 RID: 1956
		private global::DevComponents.DotNetBar.Controls.ComboBoxEx cmbBaudRate;

		// Token: 0x040007A5 RID: 1957
		private global::DevComponents.DotNetBar.Controls.ComboBoxEx cmbPortName;

		// Token: 0x040007A6 RID: 1958
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem1;

		// Token: 0x040007A7 RID: 1959
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem2;

		// Token: 0x040007A8 RID: 1960
		private global::DevComponents.Editors.ComboItem comboItem1;

		// Token: 0x040007A9 RID: 1961
		private global::DevComponents.Editors.ComboItem comboItem2;

		// Token: 0x040007AA RID: 1962
		private global::DevComponents.Editors.ComboItem comboItem3;

		// Token: 0x040007AB RID: 1963
		private global::DevComponents.Editors.ComboItem comboItem4;

		// Token: 0x040007AC RID: 1964
		private global::DevComponents.DotNetBar.Bar menuBar;

		// Token: 0x040007AD RID: 1965
		private global::DevComponents.DotNetBar.ButtonItem btnSave;

		// Token: 0x040007AE RID: 1966
		private global::DevComponents.DotNetBar.Controls.ComboBoxEx cmbStopBits;

		// Token: 0x040007AF RID: 1967
		private global::DevComponents.DotNetBar.Controls.ComboBoxEx cmbParity;

		// Token: 0x040007B0 RID: 1968
		private global::DevComponents.DotNetBar.Controls.ComboBoxEx cmbDataBits;

		// Token: 0x040007B1 RID: 1969
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem3;

		// Token: 0x040007B2 RID: 1970
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem4;

		// Token: 0x040007B3 RID: 1971
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem5;
	}
}
