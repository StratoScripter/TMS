namespace SQSClient
{
	// Token: 0x0200004C RID: 76
	public partial class frmEquipClassEdit : global::SQSClient.BaseDialogForm
	{
		// Token: 0x060003B4 RID: 948 RVA: 0x0005D638 File Offset: 0x0005B838
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060003B5 RID: 949 RVA: 0x0005D670 File Offset: 0x0005B870
		private void InitializeComponent()
		{
			this.bar1 = new global::DevComponents.DotNetBar.Bar();
			this.menuSave = new global::DevComponents.DotNetBar.ButtonItem();
			this.lcMain = new global::DevComponents.DotNetBar.Layout.LayoutControl();
			this.tbxName = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.tbxRemark = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.nudIndex = new global::DevComponents.Editors.IntegerInput();
			this.tbxStepCode = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.cmbState = new global::Base.AutoComboBox();
			this.cmbPurpose = new global::Base.AutoComboBox();
			this.layoutControlItem1 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.GDIndex = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem3 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem6 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem7 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem4 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.lciName = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.lciCheDao = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem8 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.lciRemark = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.lciIndex = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem5 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem2 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem11 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem10 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem9 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			((global::System.ComponentModel.ISupportInitialize)this.bar1).BeginInit();
			this.lcMain.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.nudIndex).BeginInit();
			base.SuspendLayout();
			this.bar1.AntiAlias = true;
			this.bar1.BackColor = global::System.Drawing.Color.Transparent;
			this.bar1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.bar1.Font = new global::System.Drawing.Font("Microsoft YaHei UI", 9f);
			this.bar1.IsMaximized = false;
			this.bar1.Items.AddRange(new global::DevComponents.DotNetBar.BaseItem[]
			{
				this.menuSave
			});
			this.bar1.Location = new global::System.Drawing.Point(0, 0);
			this.bar1.Name = "bar1";
			this.bar1.Size = new global::System.Drawing.Size(542, 26);
			this.bar1.Stretch = true;
			this.bar1.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.bar1.TabIndex = 0;
			this.bar1.TabStop = false;
			this.bar1.Text = "bar1";
			this.menuSave.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.menuSave.Image = global::SQSClient.Properties.Resources.save16;
			this.menuSave.Name = "menuSave";
			this.menuSave.Text = "Save";
			this.menuSave.Click += new global::System.EventHandler(this.menuSave_Click);
			this.lcMain.Controls.Add(this.tbxName);
			this.lcMain.Controls.Add(this.tbxRemark);
			this.lcMain.Controls.Add(this.nudIndex);
			this.lcMain.Controls.Add(this.tbxStepCode);
			this.lcMain.Controls.Add(this.cmbState);
			this.lcMain.Controls.Add(this.cmbPurpose);
			this.lcMain.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.lcMain.Location = new global::System.Drawing.Point(0, 26);
			this.lcMain.Name = "lcMain";
			this.lcMain.RootGroup.Items.AddRange(new global::DevComponents.DotNetBar.Layout.LayoutItemBase[]
			{
				this.layoutControlItem1,
				this.GDIndex,
				this.layoutControlItem3,
				this.layoutControlItem6,
				this.layoutControlItem7,
				this.layoutControlItem4
			});
			this.lcMain.Size = new global::System.Drawing.Size(542, 239);
			this.lcMain.TabIndex = 1;
			this.tbxName.Border.Class = "TextBoxBorder";
			this.tbxName.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.tbxName.Location = new global::System.Drawing.Point(73, 4);
			this.tbxName.Margin = new global::System.Windows.Forms.Padding(0);
			this.tbxName.Name = "tbxName";
			this.tbxName.PreventEnterBeep = true;
			this.tbxName.Size = new global::System.Drawing.Size(194, 21);
			this.tbxName.TabIndex = 0;
			this.tbxRemark.BackColor = global::System.Drawing.Color.White;
			this.tbxRemark.Border.Class = "TextBoxBorder";
			this.tbxRemark.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.tbxRemark.DisabledBackColor = global::System.Drawing.Color.White;
			this.tbxRemark.ForeColor = global::System.Drawing.Color.Black;
			this.tbxRemark.Location = new global::System.Drawing.Point(4, 108);
			this.tbxRemark.Margin = new global::System.Windows.Forms.Padding(0);
			this.tbxRemark.Multiline = true;
			this.tbxRemark.Name = "tbxRemark";
			this.tbxRemark.PreventEnterBeep = true;
			this.tbxRemark.ScrollBars = global::System.Windows.Forms.ScrollBars.Vertical;
			this.tbxRemark.Size = new global::System.Drawing.Size(534, 127);
			this.tbxRemark.TabIndex = 5;
			this.nudIndex.BackgroundStyle.Class = "DateTimeInputBackground";
			this.nudIndex.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.nudIndex.ButtonFreeText.Shortcut = global::DevComponents.DotNetBar.eShortcut.F2;
			this.nudIndex.Location = new global::System.Drawing.Point(344, 4);
			this.nudIndex.Margin = new global::System.Windows.Forms.Padding(0);
			this.nudIndex.MaxValue = 999;
			this.nudIndex.MinValue = 1;
			this.nudIndex.Name = "nudIndex";
			this.nudIndex.ShowUpDown = true;
			this.nudIndex.Size = new global::System.Drawing.Size(194, 21);
			this.nudIndex.TabIndex = 1;
			this.nudIndex.Value = 1;
			this.tbxStepCode.Border.Class = "TextBoxBorder";
			this.tbxStepCode.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.tbxStepCode.Location = new global::System.Drawing.Point(73, 33);
			this.tbxStepCode.Margin = new global::System.Windows.Forms.Padding(0);
			this.tbxStepCode.Name = "tbxStepCode";
			this.tbxStepCode.PreventEnterBeep = true;
			this.tbxStepCode.Size = new global::System.Drawing.Size(194, 21);
			this.tbxStepCode.TabIndex = 2;
			this.cmbState.DataSource = null;
			this.cmbState.DisplayMember = null;
			this.cmbState.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cmbState.FormattingEnabled = true;
			this.cmbState.ItemHeight = 15;
			this.cmbState.Location = new global::System.Drawing.Point(344, 33);
			this.cmbState.Margin = new global::System.Windows.Forms.Padding(0);
			this.cmbState.MaxDropDownItems = 20;
			this.cmbState.Name = "cmbState";
			this.cmbState.SelectMember = null;
			this.cmbState.Size = new global::System.Drawing.Size(194, 21);
			this.cmbState.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.cmbState.TabIndex = 3;
			this.cmbState.ValueMember = null;
			this.cmbPurpose.DataSource = null;
			this.cmbPurpose.DisplayMember = null;
			this.cmbPurpose.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cmbPurpose.ForeColor = global::System.Drawing.Color.Black;
			this.cmbPurpose.FormattingEnabled = true;
			this.cmbPurpose.ItemHeight = 15;
			this.cmbPurpose.Location = new global::System.Drawing.Point(73, 62);
			this.cmbPurpose.Margin = new global::System.Windows.Forms.Padding(0);
			this.cmbPurpose.MaxDropDownItems = 20;
			this.cmbPurpose.Name = "cmbPurpose";
			this.cmbPurpose.SelectMember = null;
			this.cmbPurpose.Size = new global::System.Drawing.Size(465, 21);
			this.cmbPurpose.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.cmbPurpose.TabIndex = 4;
			this.cmbPurpose.ValueMember = null;
			this.layoutControlItem1.Control = this.tbxName;
			this.layoutControlItem1.Height = 29;
			this.layoutControlItem1.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Text = "SrmName";
			this.layoutControlItem1.Width = 50;
			this.layoutControlItem1.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.GDIndex.Control = this.nudIndex;
			this.GDIndex.Height = 29;
			this.GDIndex.MinSize = new global::System.Drawing.Size(64, 18);
			this.GDIndex.Name = "GDIndex";
			this.GDIndex.Text = "SrmIndex";
			this.GDIndex.Width = 50;
			this.GDIndex.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem3.Control = this.tbxStepCode;
			this.layoutControlItem3.Height = 29;
			this.layoutControlItem3.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem3.Name = "layoutControlItem3";
			this.layoutControlItem3.Text = "SrmCode";
			this.layoutControlItem3.Width = 50;
			this.layoutControlItem3.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem6.Control = this.cmbState;
			this.layoutControlItem6.Height = 29;
			this.layoutControlItem6.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem6.Name = "layoutControlItem6";
			this.layoutControlItem6.Text = "SrmState";
			this.layoutControlItem6.Width = 50;
			this.layoutControlItem6.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem7.Control = this.cmbPurpose;
			this.layoutControlItem7.Height = 29;
			this.layoutControlItem7.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem7.Name = "layoutControlItem7";
			this.layoutControlItem7.Text = "SrmPurpose";
			this.layoutControlItem7.Width = 100;
			this.layoutControlItem7.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem4.Control = this.tbxRemark;
			this.layoutControlItem4.Height = 100;
			this.layoutControlItem4.HeightType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem4.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem4.Name = "layoutControlItem4";
			this.layoutControlItem4.Text = "Memo";
			this.layoutControlItem4.TextPosition = global::DevComponents.DotNetBar.Layout.eLayoutPosition.Top;
			this.layoutControlItem4.Width = 100;
			this.layoutControlItem4.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.lciName.Control = this.tbxName;
			this.lciName.Height = 29;
			this.lciName.MinSize = new global::System.Drawing.Size(120, 0);
			this.lciName.Name = "lciName";
			this.lciName.Text = "名称";
			this.lciName.Width = 90;
			this.lciName.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.lciCheDao.Height = 29;
			this.lciCheDao.MinSize = new global::System.Drawing.Size(120, 0);
			this.lciCheDao.Name = "lciCheDao";
			this.lciCheDao.Text = "鹤位";
			this.lciCheDao.Width = 90;
			this.lciCheDao.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem8.Height = 29;
			this.layoutControlItem8.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem8.Name = "layoutControlItem8";
			this.layoutControlItem8.Text = "物料";
			this.layoutControlItem8.Width = 90;
			this.layoutControlItem8.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.lciRemark.Control = this.tbxRemark;
			this.lciRemark.Height = 100;
			this.lciRemark.HeightType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.lciRemark.MinSize = new global::System.Drawing.Size(120, 0);
			this.lciRemark.Name = "lciRemark";
			this.lciRemark.Text = "备注";
			this.lciRemark.TextPosition = global::DevComponents.DotNetBar.Layout.eLayoutPosition.Top;
			this.lciRemark.Width = 100;
			this.lciRemark.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.lciIndex.Height = 26;
			this.lciIndex.MinSize = new global::System.Drawing.Size(64, 18);
			this.lciIndex.Name = "lciIndex";
			this.lciIndex.Text = "鹤位序号";
			this.lciIndex.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.lciIndex.TextLineAlignment = global::DevComponents.DotNetBar.Layout.eTextLineAlignment.Middle;
			this.lciIndex.Width = 50;
			this.lciIndex.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem5.Control = this.nudIndex;
			this.layoutControlItem5.Height = 26;
			this.layoutControlItem5.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem5.Name = "layoutControlItem5";
			this.layoutControlItem5.Text = "鹤位序号";
			this.layoutControlItem5.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem5.TextLineAlignment = global::DevComponents.DotNetBar.Layout.eTextLineAlignment.Middle;
			this.layoutControlItem5.Width = 50;
			this.layoutControlItem5.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem2.Control = this.tbxStepCode;
			this.layoutControlItem2.Height = 29;
			this.layoutControlItem2.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem2.Name = "layoutControlItem2";
			this.layoutControlItem2.Text = "股道名称";
			this.layoutControlItem2.Width = 50;
			this.layoutControlItem2.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem11.Control = this.cmbState;
			this.layoutControlItem11.Height = 29;
			this.layoutControlItem11.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem11.Name = "layoutControlItem11";
			this.layoutControlItem11.Text = "计量类型";
			this.layoutControlItem11.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem11.Width = 50;
			this.layoutControlItem11.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem10.Height = 29;
			this.layoutControlItem10.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem10.Name = "layoutControlItem10";
			this.layoutControlItem10.Text = "客户单位:";
			this.layoutControlItem10.Width = 94;
			this.layoutControlItem10.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem9.Height = 29;
			this.layoutControlItem9.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem9.Name = "layoutControlItem9";
			this.layoutControlItem9.Text = "Label:";
			this.layoutControlItem9.Width = 50;
			this.layoutControlItem9.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			base.ClientSize = new global::System.Drawing.Size(542, 265);
			base.Controls.Add(this.lcMain);
			base.Controls.Add(this.bar1);
			base.Name = "frmEquipClassEdit";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "SrmEquipClass";
			base.Load += new global::System.EventHandler(this.frmEquipClassEdit_Load);
			((global::System.ComponentModel.ISupportInitialize)this.bar1).EndInit();
			this.lcMain.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.nudIndex).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x0400062C RID: 1580
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400062D RID: 1581
		private global::DevComponents.DotNetBar.Bar bar1;

		// Token: 0x0400062E RID: 1582
		private global::DevComponents.DotNetBar.ButtonItem menuSave;

		// Token: 0x0400062F RID: 1583
		private global::DevComponents.DotNetBar.Layout.LayoutControl lcMain;

		// Token: 0x04000630 RID: 1584
		private global::DevComponents.DotNetBar.Controls.TextBoxX tbxName;

		// Token: 0x04000631 RID: 1585
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem1;

		// Token: 0x04000632 RID: 1586
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem lciName;

		// Token: 0x04000633 RID: 1587
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem lciCheDao;

		// Token: 0x04000634 RID: 1588
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem8;

		// Token: 0x04000635 RID: 1589
		private global::DevComponents.DotNetBar.Controls.TextBoxX tbxRemark;

		// Token: 0x04000636 RID: 1590
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem4;

		// Token: 0x04000637 RID: 1591
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem lciRemark;

		// Token: 0x04000638 RID: 1592
		private global::DevComponents.Editors.IntegerInput nudIndex;

		// Token: 0x04000639 RID: 1593
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem GDIndex;

		// Token: 0x0400063A RID: 1594
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem lciIndex;

		// Token: 0x0400063B RID: 1595
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem5;

		// Token: 0x0400063C RID: 1596
		private global::DevComponents.DotNetBar.Controls.TextBoxX tbxStepCode;

		// Token: 0x0400063D RID: 1597
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem3;

		// Token: 0x0400063E RID: 1598
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem2;

		// Token: 0x0400063F RID: 1599
		private global::Base.AutoComboBox cmbState;

		// Token: 0x04000640 RID: 1600
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem6;

		// Token: 0x04000641 RID: 1601
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem11;

		// Token: 0x04000642 RID: 1602
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem10;

		// Token: 0x04000643 RID: 1603
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem9;

		// Token: 0x04000644 RID: 1604
		private global::Base.AutoComboBox cmbPurpose;

		// Token: 0x04000645 RID: 1605
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem7;
	}
}
