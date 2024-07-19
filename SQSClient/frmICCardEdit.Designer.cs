namespace SQSClient
{
	// Token: 0x02000074 RID: 116
	public partial class frmICCardEdit : global::SQSClient.BaseDialogForm
	{
		// Token: 0x06000658 RID: 1624 RVA: 0x0009C754 File Offset: 0x0009A954
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000659 RID: 1625 RVA: 0x0009C78C File Offset: 0x0009A98C
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::SQSClient.frmICCardEdit));
			this.layoutControl1 = new global::DevComponents.DotNetBar.Layout.LayoutControl();
			this.btnInit = new global::DevComponents.DotNetBar.ButtonX();
			this.btnReadIDNum = new global::DevComponents.DotNetBar.ButtonX();
			this.txtIDNum = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.chkState = new global::DevComponents.DotNetBar.Controls.CheckBoxX();
			this.rtbRemark = new global::DevComponents.DotNetBar.Controls.RichTextBoxEx();
			this.btnRead = new global::DevComponents.DotNetBar.ButtonX();
			this.tbxNum = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.btnICBlockValue = new global::DevComponents.DotNetBar.ButtonX();
			this.txtICBlockValue = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.txtSetBlockValue = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.btnSetBlockValue = new global::DevComponents.DotNetBar.ButtonX();
			this.layoutControlItem1 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem2 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem6 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem4 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem7 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem3 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem10 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem9 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem11 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem12 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem5 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.menuBar = new global::DevComponents.DotNetBar.Bar();
			this.btnSave = new global::DevComponents.DotNetBar.ButtonItem();
			this.layoutControlItem8 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem13 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.cbxType = new global::DevComponents.DotNetBar.Controls.CheckBoxX();
			this.layoutControlItem14 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControl1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.menuBar).BeginInit();
			base.SuspendLayout();
			this.layoutControl1.Controls.Add(this.btnInit);
			this.layoutControl1.Controls.Add(this.btnReadIDNum);
			this.layoutControl1.Controls.Add(this.txtIDNum);
			this.layoutControl1.Controls.Add(this.chkState);
			this.layoutControl1.Controls.Add(this.rtbRemark);
			this.layoutControl1.Controls.Add(this.btnRead);
			this.layoutControl1.Controls.Add(this.tbxNum);
			this.layoutControl1.Controls.Add(this.btnICBlockValue);
			this.layoutControl1.Controls.Add(this.txtICBlockValue);
			this.layoutControl1.Controls.Add(this.txtSetBlockValue);
			this.layoutControl1.Controls.Add(this.btnSetBlockValue);
			this.layoutControl1.Controls.Add(this.cbxType);
			this.layoutControl1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.layoutControl1.Location = new global::System.Drawing.Point(0, 26);
			this.layoutControl1.Name = "layoutControl1";
			this.layoutControl1.RootGroup.Items.AddRange(new global::DevComponents.DotNetBar.Layout.LayoutItemBase[]
			{
				this.layoutControlItem1,
				this.layoutControlItem2,
				this.layoutControlItem6,
				this.layoutControlItem4,
				this.layoutControlItem7,
				this.layoutControlItem3,
				this.layoutControlItem10,
				this.layoutControlItem9,
				this.layoutControlItem11,
				this.layoutControlItem12,
				this.layoutControlItem5,
				this.layoutControlItem14
			});
			this.layoutControl1.Size = new global::System.Drawing.Size(354, 291);
			this.layoutControl1.TabIndex = 0;
			this.btnInit.AccessibleRole = global::System.Windows.Forms.AccessibleRole.PushButton;
			this.btnInit.ColorTable = global::DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.btnInit.Location = new global::System.Drawing.Point(286, 4);
			this.btnInit.Margin = new global::System.Windows.Forms.Padding(0);
			this.btnInit.Name = "btnInit";
			this.btnInit.Size = new global::System.Drawing.Size(64, 23);
			this.btnInit.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.btnInit.TabIndex = 2;
			this.btnInit.Text = "Init";
			this.btnInit.Click += new global::System.EventHandler(this.btnInit_Click);
			this.btnReadIDNum.AccessibleRole = global::System.Windows.Forms.AccessibleRole.PushButton;
			this.btnReadIDNum.ColorTable = global::DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.btnReadIDNum.Enabled = false;
			this.btnReadIDNum.Location = new global::System.Drawing.Point(287, 35);
			this.btnReadIDNum.Margin = new global::System.Windows.Forms.Padding(0);
			this.btnReadIDNum.Name = "btnReadIDNum";
			this.btnReadIDNum.Size = new global::System.Drawing.Size(63, 23);
			this.btnReadIDNum.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.btnReadIDNum.TabIndex = 4;
			this.btnReadIDNum.Text = "Read";
			this.btnReadIDNum.Click += new global::System.EventHandler(this.btnReadIDNum_Click);
			this.txtIDNum.Border.Class = "TextBoxBorder";
			this.txtIDNum.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtIDNum.Enabled = false;
			this.txtIDNum.Location = new global::System.Drawing.Point(92, 35);
			this.txtIDNum.Margin = new global::System.Windows.Forms.Padding(0);
			this.txtIDNum.Name = "txtIDNum";
			this.txtIDNum.PreventEnterBeep = true;
			this.txtIDNum.Size = new global::System.Drawing.Size(187, 21);
			this.txtIDNum.TabIndex = 3;
			this.chkState.AutoSize = true;
			this.chkState.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.chkState.Checked = true;
			this.chkState.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.chkState.CheckValue = "Y";
			this.chkState.Location = new global::System.Drawing.Point(92, 66);
			this.chkState.Margin = new global::System.Windows.Forms.Padding(0);
			this.chkState.Name = "chkState";
			this.chkState.Size = new global::System.Drawing.Size(64, 16);
			this.chkState.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.chkState.TabIndex = 5;
			this.chkState.Text = "Enable";
			this.rtbRemark.BackgroundStyle.Class = "RichTextBoxBorder";
			this.rtbRemark.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.rtbRemark.Location = new global::System.Drawing.Point(92, 159);
			this.rtbRemark.Margin = new global::System.Windows.Forms.Padding(0);
			this.rtbRemark.MaxLength = 200;
			this.rtbRemark.Name = "rtbRemark";
			this.rtbRemark.Rtf = "{\\rtf1\\ansi\\ansicpg936\\deff0\\nouicompat\\deflang1033\\deflangfe2052{\\fonttbl{\\f0\\fnil\\fcharset134 \\'cb\\'ce\\'cc\\'e5;}}\r\n{\\*\\generator Riched20 10.0.18362}\\viewkind4\\uc1 \r\n\\pard\\f0\\fs18\\lang2052\\par\r\n}\r\n";
			this.rtbRemark.Size = new global::System.Drawing.Size(258, 92);
			this.rtbRemark.TabIndex = 10;
			this.btnRead.AccessibleRole = global::System.Windows.Forms.AccessibleRole.PushButton;
			this.btnRead.ColorTable = global::DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.btnRead.Location = new global::System.Drawing.Point(216, 4);
			this.btnRead.Margin = new global::System.Windows.Forms.Padding(0);
			this.btnRead.Name = "btnRead";
			this.btnRead.Size = new global::System.Drawing.Size(62, 23);
			this.btnRead.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.btnRead.TabIndex = 1;
			this.btnRead.Text = "Read";
			this.btnRead.Click += new global::System.EventHandler(this.btnRead_Click);
			this.tbxNum.Border.Class = "TextBoxBorder";
			this.tbxNum.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.tbxNum.Location = new global::System.Drawing.Point(92, 4);
			this.tbxNum.Margin = new global::System.Windows.Forms.Padding(0);
			this.tbxNum.MaxLength = 12;
			this.tbxNum.Name = "tbxNum";
			this.tbxNum.PreventEnterBeep = true;
			this.tbxNum.Size = new global::System.Drawing.Size(116, 21);
			this.tbxNum.TabIndex = 0;
			this.btnICBlockValue.AccessibleRole = global::System.Windows.Forms.AccessibleRole.PushButton;
			this.btnICBlockValue.ColorTable = global::DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.btnICBlockValue.Location = new global::System.Drawing.Point(287, 97);
			this.btnICBlockValue.Margin = new global::System.Windows.Forms.Padding(0);
			this.btnICBlockValue.Name = "btnICBlockValue";
			this.btnICBlockValue.Size = new global::System.Drawing.Size(63, 23);
			this.btnICBlockValue.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.btnICBlockValue.TabIndex = 7;
			this.btnICBlockValue.Text = "Read";
			this.btnICBlockValue.Click += new global::System.EventHandler(this.btnICBlockValue_Click);
			this.txtICBlockValue.Border.Class = "TextBoxBorder";
			this.txtICBlockValue.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtICBlockValue.Location = new global::System.Drawing.Point(92, 97);
			this.txtICBlockValue.Margin = new global::System.Windows.Forms.Padding(0);
			this.txtICBlockValue.Name = "txtICBlockValue";
			this.txtICBlockValue.PreventEnterBeep = true;
			this.txtICBlockValue.ReadOnly = true;
			this.txtICBlockValue.Size = new global::System.Drawing.Size(187, 21);
			this.txtICBlockValue.TabIndex = 6;
			this.txtSetBlockValue.Border.Class = "TextBoxBorder";
			this.txtSetBlockValue.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtSetBlockValue.Location = new global::System.Drawing.Point(92, 128);
			this.txtSetBlockValue.Margin = new global::System.Windows.Forms.Padding(0);
			this.txtSetBlockValue.Name = "txtSetBlockValue";
			this.txtSetBlockValue.PreventEnterBeep = true;
			this.txtSetBlockValue.Size = new global::System.Drawing.Size(187, 21);
			this.txtSetBlockValue.TabIndex = 8;
			this.btnSetBlockValue.AccessibleRole = global::System.Windows.Forms.AccessibleRole.PushButton;
			this.btnSetBlockValue.ColorTable = global::DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.btnSetBlockValue.Location = new global::System.Drawing.Point(287, 128);
			this.btnSetBlockValue.Margin = new global::System.Windows.Forms.Padding(0);
			this.btnSetBlockValue.Name = "btnSetBlockValue";
			this.btnSetBlockValue.Size = new global::System.Drawing.Size(63, 23);
			this.btnSetBlockValue.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.btnSetBlockValue.TabIndex = 9;
			this.btnSetBlockValue.Text = "Write";
			this.btnSetBlockValue.Click += new global::System.EventHandler(this.btnSetBlockValue_Click);
			this.layoutControlItem1.Control = this.tbxNum;
			this.layoutControlItem1.Height = 29;
			this.layoutControlItem1.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Text = "*IC";
			this.layoutControlItem1.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem1.Width = 60;
			this.layoutControlItem1.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem2.Control = this.btnRead;
			this.layoutControlItem2.Height = 31;
			this.layoutControlItem2.MinSize = new global::System.Drawing.Size(32, 20);
			this.layoutControlItem2.Name = "layoutControlItem2";
			this.layoutControlItem2.Width = 20;
			this.layoutControlItem2.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem6.Control = this.btnInit;
			this.layoutControlItem6.Height = 31;
			this.layoutControlItem6.MinSize = new global::System.Drawing.Size(32, 20);
			this.layoutControlItem6.Name = "layoutControlItem6";
			this.layoutControlItem6.Width = 20;
			this.layoutControlItem6.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem4.Control = this.txtIDNum;
			this.layoutControlItem4.Height = 29;
			this.layoutControlItem4.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem4.Name = "layoutControlItem4";
			this.layoutControlItem4.Text = "IDNum";
			this.layoutControlItem4.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem4.Width = 80;
			this.layoutControlItem4.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem7.Control = this.btnReadIDNum;
			this.layoutControlItem7.Height = 31;
			this.layoutControlItem7.MinSize = new global::System.Drawing.Size(32, 20);
			this.layoutControlItem7.Name = "layoutControlItem7";
			this.layoutControlItem7.Width = 20;
			this.layoutControlItem7.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem3.Control = this.chkState;
			this.layoutControlItem3.Height = 31;
			this.layoutControlItem3.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem3.Name = "layoutControlItem3";
			this.layoutControlItem3.Text = " ";
			this.layoutControlItem3.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem3.Width = 83;
			this.layoutControlItem3.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem10.Control = this.txtICBlockValue;
			this.layoutControlItem10.Height = 29;
			this.layoutControlItem10.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem10.Name = "layoutControlItem10";
			this.layoutControlItem10.Text = "ICBlockValue";
			this.layoutControlItem10.Width = 80;
			this.layoutControlItem10.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem9.Control = this.btnICBlockValue;
			this.layoutControlItem9.Height = 31;
			this.layoutControlItem9.MinSize = new global::System.Drawing.Size(32, 20);
			this.layoutControlItem9.Name = "layoutControlItem9";
			this.layoutControlItem9.Width = 20;
			this.layoutControlItem9.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem11.Control = this.txtSetBlockValue;
			this.layoutControlItem11.Height = 29;
			this.layoutControlItem11.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem11.Name = "layoutControlItem11";
			this.layoutControlItem11.Text = "SetBlockValue";
			this.layoutControlItem11.Width = 80;
			this.layoutControlItem11.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem12.Control = this.btnSetBlockValue;
			this.layoutControlItem12.Height = 31;
			this.layoutControlItem12.MinSize = new global::System.Drawing.Size(32, 20);
			this.layoutControlItem12.Name = "layoutControlItem12";
			this.layoutControlItem12.Width = 20;
			this.layoutControlItem12.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem5.Control = this.rtbRemark;
			this.layoutControlItem5.Height = 100;
			this.layoutControlItem5.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem5.Name = "layoutControlItem5";
			this.layoutControlItem5.Text = "Remark";
			this.layoutControlItem5.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem5.Width = 108;
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
			this.menuBar.TabIndex = 21;
			this.menuBar.TabStop = false;
			this.menuBar.Text = "Main Menu";
			this.btnSave.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.btnSave.Image = global::SQSClient.Properties.Resources.save16;
			this.btnSave.Name = "btnSave";
			this.btnSave.Text = "Save";
			this.btnSave.Click += new global::System.EventHandler(this.btnSave_Click);
			this.layoutControlItem8.Control = this.txtICBlockValue;
			this.layoutControlItem8.Height = 29;
			this.layoutControlItem8.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem8.Name = "layoutControlItem8";
			this.layoutControlItem8.Text = "IDNum";
			this.layoutControlItem8.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem8.Width = 80;
			this.layoutControlItem8.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem13.Control = this.cbxType;
			this.layoutControlItem13.Height = 31;
			this.layoutControlItem13.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem13.Name = "layoutControlItem13";
			this.layoutControlItem13.Text = " ";
			this.layoutControlItem13.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem13.Width = 83;
			this.layoutControlItem13.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.cbxType.AutoSize = true;
			this.cbxType.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.cbxType.Location = new global::System.Drawing.Point(92, 259);
			this.cbxType.Margin = new global::System.Windows.Forms.Padding(0);
			this.cbxType.Name = "cbxType";
			this.cbxType.Size = new global::System.Drawing.Size(107, 16);
			this.cbxType.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.cbxType.TabIndex = 12;
			this.cbxType.Text = "SpecialICCard";
			this.layoutControlItem14.Control = this.cbxType;
			this.layoutControlItem14.Height = 24;
			this.layoutControlItem14.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem14.Name = "layoutControlItem14";
			this.layoutControlItem14.Text = " ";
			this.layoutControlItem14.Width = 72;
			base.ClientSize = new global::System.Drawing.Size(354, 317);
			base.Controls.Add(this.layoutControl1);
			base.Controls.Add(this.menuBar);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "frmICCardEdit";
			this.Text = "frmICCardEdit";
			base.Load += new global::System.EventHandler(this.frmICCardEdit_Load);
			this.layoutControl1.ResumeLayout(false);
			this.layoutControl1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.menuBar).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000ABD RID: 2749
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000ABE RID: 2750
		private global::DevComponents.DotNetBar.Layout.LayoutControl layoutControl1;

		// Token: 0x04000ABF RID: 2751
		private global::DevComponents.DotNetBar.ButtonX btnRead;

		// Token: 0x04000AC0 RID: 2752
		private global::DevComponents.DotNetBar.Controls.TextBoxX tbxNum;

		// Token: 0x04000AC1 RID: 2753
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem1;

		// Token: 0x04000AC2 RID: 2754
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem2;

		// Token: 0x04000AC3 RID: 2755
		private global::DevComponents.DotNetBar.Controls.RichTextBoxEx rtbRemark;

		// Token: 0x04000AC4 RID: 2756
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem5;

		// Token: 0x04000AC5 RID: 2757
		private global::DevComponents.DotNetBar.Controls.CheckBoxX chkState;

		// Token: 0x04000AC6 RID: 2758
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem3;

		// Token: 0x04000AC7 RID: 2759
		private global::DevComponents.DotNetBar.ButtonX btnReadIDNum;

		// Token: 0x04000AC8 RID: 2760
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtIDNum;

		// Token: 0x04000AC9 RID: 2761
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem4;

		// Token: 0x04000ACA RID: 2762
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem7;

		// Token: 0x04000ACB RID: 2763
		private global::DevComponents.DotNetBar.Bar menuBar;

		// Token: 0x04000ACC RID: 2764
		private global::DevComponents.DotNetBar.ButtonItem btnSave;

		// Token: 0x04000ACD RID: 2765
		private global::DevComponents.DotNetBar.ButtonX btnInit;

		// Token: 0x04000ACE RID: 2766
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem6;

		// Token: 0x04000ACF RID: 2767
		private global::DevComponents.DotNetBar.ButtonX btnICBlockValue;

		// Token: 0x04000AD0 RID: 2768
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtICBlockValue;

		// Token: 0x04000AD1 RID: 2769
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtSetBlockValue;

		// Token: 0x04000AD2 RID: 2770
		private global::DevComponents.DotNetBar.ButtonX btnSetBlockValue;

		// Token: 0x04000AD3 RID: 2771
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem10;

		// Token: 0x04000AD4 RID: 2772
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem9;

		// Token: 0x04000AD5 RID: 2773
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem11;

		// Token: 0x04000AD6 RID: 2774
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem12;

		// Token: 0x04000AD7 RID: 2775
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem8;

		// Token: 0x04000AD8 RID: 2776
		private global::DevComponents.DotNetBar.Controls.CheckBoxX cbxType;

		// Token: 0x04000AD9 RID: 2777
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem14;

		// Token: 0x04000ADA RID: 2778
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem13;
	}
}
