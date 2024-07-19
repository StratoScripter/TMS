namespace SQSClient
{
	// Token: 0x02000098 RID: 152
	public partial class frmUnionLabDealEdit : global::SQSClient.BaseDialogForm
	{
		// Token: 0x06000879 RID: 2169 RVA: 0x000D00C8 File Offset: 0x000CE2C8
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600087A RID: 2170 RVA: 0x000D0100 File Offset: 0x000CE300
		private void InitializeComponent()
		{
			this.menuBar = new global::DevComponents.DotNetBar.Bar();
			this.btnSave = new global::DevComponents.DotNetBar.ButtonItem();
			this.btnCapture = new global::DevComponents.DotNetBar.ButtonItem();
			this.layoutControl1 = new global::DevComponents.DotNetBar.Layout.LayoutControl();
			this.rtxtMemo = new global::DevComponents.DotNetBar.Controls.RichTextBoxEx();
			this.txtUnionLabCode = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.cmbUnionLabResult = new global::DevComponents.DotNetBar.Controls.ComboBoxEx();
			this.txtUnionLabName = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.iInputUnionLabIndex = new global::DevComponents.Editors.IntegerInput();
			this.layoutControlItem2 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem5 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem3 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem4 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem1 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem6 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem7 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.txtBusinessType = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.layoutControlItem8 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			((global::System.ComponentModel.ISupportInitialize)this.menuBar).BeginInit();
			this.layoutControl1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.iInputUnionLabIndex).BeginInit();
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
				this.btnSave,
				this.btnCapture
			});
			this.menuBar.Location = new global::System.Drawing.Point(0, 0);
			this.menuBar.MenuBar = true;
			this.menuBar.Name = "menuBar";
			this.menuBar.Size = new global::System.Drawing.Size(354, 26);
			this.menuBar.Stretch = true;
			this.menuBar.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.menuBar.TabIndex = 20;
			this.menuBar.TabStop = false;
			this.menuBar.Text = "Main Menu";
			this.btnSave.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.btnSave.Image = global::SQSClient.Properties.Resources.save16;
			this.btnSave.Name = "btnSave";
			this.btnSave.Text = "Save";
			this.btnSave.Click += new global::System.EventHandler(this.btnSave_Click);
			this.btnCapture.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.btnCapture.Image = global::SQSClient.Properties.Resources.capture16;
			this.btnCapture.ItemAlignment = global::DevComponents.DotNetBar.eItemAlignment.Far;
			this.btnCapture.Name = "btnCapture";
			this.btnCapture.Text = "Capture";
			this.btnCapture.Click += new global::System.EventHandler(this.btnCapture_Click);
			this.layoutControl1.Controls.Add(this.rtxtMemo);
			this.layoutControl1.Controls.Add(this.txtUnionLabCode);
			this.layoutControl1.Controls.Add(this.cmbUnionLabResult);
			this.layoutControl1.Controls.Add(this.txtUnionLabName);
			this.layoutControl1.Controls.Add(this.iInputUnionLabIndex);
			this.layoutControl1.Controls.Add(this.txtBusinessType);
			this.layoutControl1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.layoutControl1.Location = new global::System.Drawing.Point(0, 26);
			this.layoutControl1.Name = "layoutControl1";
			this.layoutControl1.RootGroup.Items.AddRange(new global::DevComponents.DotNetBar.Layout.LayoutItemBase[]
			{
				this.layoutControlItem2,
				this.layoutControlItem5,
				this.layoutControlItem8,
				this.layoutControlItem3,
				this.layoutControlItem4,
				this.layoutControlItem1
			});
			this.layoutControl1.Size = new global::System.Drawing.Size(354, 330);
			this.layoutControl1.TabIndex = 23;
			this.rtxtMemo.BackgroundStyle.Class = "RichTextBoxBorder";
			this.rtxtMemo.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.rtxtMemo.Enabled = false;
			this.rtxtMemo.Location = new global::System.Drawing.Point(86, 120);
			this.rtxtMemo.Margin = new global::System.Windows.Forms.Padding(0);
			this.rtxtMemo.Name = "rtxtMemo";
			this.rtxtMemo.Rtf = "{\\rtf1\\ansi\\ansicpg936\\deff0\\nouicompat\\deflang1033\\deflangfe2052{\\fonttbl{\\f0\\fnil\\fcharset134 \\'cb\\'ce\\'cc\\'e5;}}\r\n{\\*\\generator Riched20 10.0.18362}\\viewkind4\\uc1 \r\n\\pard\\f0\\fs18\\lang2052\\par\r\n}\r\n";
			this.rtxtMemo.Size = new global::System.Drawing.Size(264, 56);
			this.rtxtMemo.TabIndex = 4;
			this.txtUnionLabCode.Border.Class = "TextBoxBorder";
			this.txtUnionLabCode.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtUnionLabCode.Enabled = false;
			this.txtUnionLabCode.Location = new global::System.Drawing.Point(86, 4);
			this.txtUnionLabCode.Margin = new global::System.Windows.Forms.Padding(0);
			this.txtUnionLabCode.Name = "txtUnionLabCode";
			this.txtUnionLabCode.PreventEnterBeep = true;
			this.txtUnionLabCode.Size = new global::System.Drawing.Size(264, 21);
			this.txtUnionLabCode.TabIndex = 0;
			this.cmbUnionLabResult.DisplayMember = "Text";
			this.cmbUnionLabResult.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cmbUnionLabResult.FormattingEnabled = true;
			this.cmbUnionLabResult.ItemHeight = 15;
			this.cmbUnionLabResult.Location = new global::System.Drawing.Point(86, 184);
			this.cmbUnionLabResult.Margin = new global::System.Windows.Forms.Padding(0);
			this.cmbUnionLabResult.Name = "cmbUnionLabResult";
			this.cmbUnionLabResult.Size = new global::System.Drawing.Size(264, 21);
			this.cmbUnionLabResult.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.cmbUnionLabResult.TabIndex = 5;
			this.txtUnionLabName.Border.Class = "TextBoxBorder";
			this.txtUnionLabName.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtUnionLabName.Enabled = false;
			this.txtUnionLabName.Location = new global::System.Drawing.Point(86, 33);
			this.txtUnionLabName.Margin = new global::System.Windows.Forms.Padding(0);
			this.txtUnionLabName.Name = "txtUnionLabName";
			this.txtUnionLabName.PreventEnterBeep = true;
			this.txtUnionLabName.Size = new global::System.Drawing.Size(264, 21);
			this.txtUnionLabName.TabIndex = 1;
			this.iInputUnionLabIndex.BackgroundStyle.Class = "DateTimeInputBackground";
			this.iInputUnionLabIndex.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.iInputUnionLabIndex.ButtonFreeText.Shortcut = global::DevComponents.DotNetBar.eShortcut.F2;
			this.iInputUnionLabIndex.Enabled = false;
			this.iInputUnionLabIndex.InputHorizontalAlignment = global::DevComponents.Editors.eHorizontalAlignment.Left;
			this.iInputUnionLabIndex.Location = new global::System.Drawing.Point(86, 91);
			this.iInputUnionLabIndex.Margin = new global::System.Windows.Forms.Padding(0);
			this.iInputUnionLabIndex.Name = "iInputUnionLabIndex";
			this.iInputUnionLabIndex.ShowUpDown = true;
			this.iInputUnionLabIndex.Size = new global::System.Drawing.Size(264, 21);
			this.iInputUnionLabIndex.TabIndex = 3;
			this.iInputUnionLabIndex.Value = 1;
			this.layoutControlItem2.Control = this.txtUnionLabCode;
			this.layoutControlItem2.Height = 29;
			this.layoutControlItem2.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem2.Name = "layoutControlItem2";
			this.layoutControlItem2.Text = "UnionLabCode";
			this.layoutControlItem2.Width = 100;
			this.layoutControlItem2.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem5.Control = this.txtUnionLabName;
			this.layoutControlItem5.Height = 29;
			this.layoutControlItem5.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem5.Name = "layoutControlItem5";
			this.layoutControlItem5.Text = "UnionLab";
			this.layoutControlItem5.Width = 100;
			this.layoutControlItem5.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem3.Control = this.iInputUnionLabIndex;
			this.layoutControlItem3.Height = 29;
			this.layoutControlItem3.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem3.Name = "layoutControlItem3";
			this.layoutControlItem3.Text = "LabIndex";
			this.layoutControlItem3.Width = 100;
			this.layoutControlItem3.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem4.Control = this.rtxtMemo;
			this.layoutControlItem4.Height = 64;
			this.layoutControlItem4.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem4.Name = "layoutControlItem4";
			this.layoutControlItem4.Text = "Memo";
			this.layoutControlItem4.Width = 100;
			this.layoutControlItem4.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem1.Control = this.cmbUnionLabResult;
			this.layoutControlItem1.Height = 29;
			this.layoutControlItem1.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Text = "LabResult";
			this.layoutControlItem1.Width = 100;
			this.layoutControlItem1.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem6.Height = 29;
			this.layoutControlItem6.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem6.Name = "layoutControlItem6";
			this.layoutControlItem6.Text = "BusinessType";
			this.layoutControlItem6.Width = 100;
			this.layoutControlItem6.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem7.Control = this.txtBusinessType;
			this.layoutControlItem7.Height = 29;
			this.layoutControlItem7.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem7.Name = "layoutControlItem7";
			this.layoutControlItem7.Text = "BusinessType";
			this.layoutControlItem7.Width = 100;
			this.layoutControlItem7.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.txtBusinessType.Border.Class = "TextBoxBorder";
			this.txtBusinessType.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtBusinessType.Enabled = false;
			this.txtBusinessType.Location = new global::System.Drawing.Point(86, 62);
			this.txtBusinessType.Margin = new global::System.Windows.Forms.Padding(0);
			this.txtBusinessType.Name = "txtBusinessType";
			this.txtBusinessType.PreventEnterBeep = true;
			this.txtBusinessType.Size = new global::System.Drawing.Size(264, 21);
			this.txtBusinessType.TabIndex = 2;
			this.layoutControlItem8.Control = this.txtBusinessType;
			this.layoutControlItem8.Height = 29;
			this.layoutControlItem8.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem8.Name = "layoutControlItem8";
			this.layoutControlItem8.Text = "BusinessType";
			this.layoutControlItem8.Width = 100;
			this.layoutControlItem8.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			base.ClientSize = new global::System.Drawing.Size(354, 356);
			base.Controls.Add(this.layoutControl1);
			base.Controls.Add(this.menuBar);
			base.Name = "frmUnionLabDealEdit";
			this.Text = "frmUnionLabDealEdit";
			base.Load += new global::System.EventHandler(this.frmUnionLabDealEdit_Load);
			((global::System.ComponentModel.ISupportInitialize)this.menuBar).EndInit();
			this.layoutControl1.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.iInputUnionLabIndex).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000E62 RID: 3682
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000E63 RID: 3683
		private global::DevComponents.DotNetBar.Bar menuBar;

		// Token: 0x04000E64 RID: 3684
		private global::DevComponents.DotNetBar.ButtonItem btnSave;

		// Token: 0x04000E65 RID: 3685
		private global::DevComponents.DotNetBar.Layout.LayoutControl layoutControl1;

		// Token: 0x04000E66 RID: 3686
		private global::DevComponents.DotNetBar.Controls.ComboBoxEx cmbUnionLabResult;

		// Token: 0x04000E67 RID: 3687
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem1;

		// Token: 0x04000E68 RID: 3688
		private global::DevComponents.DotNetBar.ButtonItem btnCapture;

		// Token: 0x04000E69 RID: 3689
		private global::DevComponents.DotNetBar.Controls.RichTextBoxEx rtxtMemo;

		// Token: 0x04000E6A RID: 3690
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtUnionLabCode;

		// Token: 0x04000E6B RID: 3691
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem2;

		// Token: 0x04000E6C RID: 3692
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem4;

		// Token: 0x04000E6D RID: 3693
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtUnionLabName;

		// Token: 0x04000E6E RID: 3694
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem5;

		// Token: 0x04000E6F RID: 3695
		private global::DevComponents.Editors.IntegerInput iInputUnionLabIndex;

		// Token: 0x04000E70 RID: 3696
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem3;

		// Token: 0x04000E71 RID: 3697
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem6;

		// Token: 0x04000E72 RID: 3698
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtBusinessType;

		// Token: 0x04000E73 RID: 3699
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem8;

		// Token: 0x04000E74 RID: 3700
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem7;
	}
}
