namespace SQSClient
{
	// Token: 0x0200004F RID: 79
	public partial class frmInvStepEdit : global::SQSClient.BaseDialogForm
	{
		// Token: 0x060003D5 RID: 981 RVA: 0x00060914 File Offset: 0x0005EB14
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060003D6 RID: 982 RVA: 0x0006094C File Offset: 0x0005EB4C
		private void InitializeComponent()
		{
			this.bar1 = new global::DevComponents.DotNetBar.Bar();
			this.menuSave = new global::DevComponents.DotNetBar.ButtonItem();
			this.lcMain = new global::DevComponents.DotNetBar.Layout.LayoutControl();
			this.btnAllowConditionSet = new global::System.Windows.Forms.Button();
			this.chkEnable = new global::DevComponents.DotNetBar.Controls.CheckBoxX();
			this.cmbLastStep = new global::Base.AutoComboBox();
			this.txtRemark = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.cmbStep = new global::Base.AutoComboBox();
			this.cmbInvModel = new global::Base.AutoComboBox();
			this.txtAllowCondition = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.layoutControlItem14 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem7 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem1 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem20 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem3 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem6 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
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
			this.layoutControlItem12 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem17 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem19 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			((global::System.ComponentModel.ISupportInitialize)this.bar1).BeginInit();
			this.lcMain.SuspendLayout();
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
			this.lcMain.Controls.Add(this.btnAllowConditionSet);
			this.lcMain.Controls.Add(this.chkEnable);
			this.lcMain.Controls.Add(this.cmbLastStep);
			this.lcMain.Controls.Add(this.txtRemark);
			this.lcMain.Controls.Add(this.cmbStep);
			this.lcMain.Controls.Add(this.cmbInvModel);
			this.lcMain.Controls.Add(this.txtAllowCondition);
			this.lcMain.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.lcMain.Location = new global::System.Drawing.Point(0, 26);
			this.lcMain.Name = "lcMain";
			this.lcMain.RootGroup.Items.AddRange(new global::DevComponents.DotNetBar.Layout.LayoutItemBase[]
			{
				this.layoutControlItem14,
				this.layoutControlItem7,
				this.layoutControlItem1,
				this.layoutControlItem20,
				this.layoutControlItem3,
				this.layoutControlItem6,
				this.layoutControlItem4
			});
			this.lcMain.Size = new global::System.Drawing.Size(542, 300);
			this.lcMain.TabIndex = 1;
			this.btnAllowConditionSet.Location = new global::System.Drawing.Point(463, 61);
			this.btnAllowConditionSet.Margin = new global::System.Windows.Forms.Padding(0);
			this.btnAllowConditionSet.Name = "btnAllowConditionSet";
			this.btnAllowConditionSet.Size = new global::System.Drawing.Size(75, 23);
			this.btnAllowConditionSet.TabIndex = 4;
			this.btnAllowConditionSet.Text = "Config";
			this.btnAllowConditionSet.UseVisualStyleBackColor = true;
			this.btnAllowConditionSet.Click += new global::System.EventHandler(this.btnAllowConditionSet_Click);
			this.chkEnable.AutoSize = true;
			this.chkEnable.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.chkEnable.Location = new global::System.Drawing.Point(98, 92);
			this.chkEnable.Margin = new global::System.Windows.Forms.Padding(0);
			this.chkEnable.Name = "chkEnable";
			this.chkEnable.Size = new global::System.Drawing.Size(64, 16);
			this.chkEnable.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.chkEnable.TabIndex = 5;
			this.chkEnable.Text = "Enable";
			this.cmbLastStep.DataSource = null;
			this.cmbLastStep.DisplayMember = null;
			this.cmbLastStep.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cmbLastStep.FormattingEnabled = true;
			this.cmbLastStep.ItemHeight = 15;
			this.cmbLastStep.Location = new global::System.Drawing.Point(98, 33);
			this.cmbLastStep.Margin = new global::System.Windows.Forms.Padding(0);
			this.cmbLastStep.MaxDropDownItems = 20;
			this.cmbLastStep.Name = "cmbLastStep";
			this.cmbLastStep.SelectMember = null;
			this.cmbLastStep.Size = new global::System.Drawing.Size(440, 21);
			this.cmbLastStep.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.cmbLastStep.TabIndex = 2;
			this.cmbLastStep.ValueMember = null;
			this.txtRemark.BackColor = global::System.Drawing.Color.White;
			this.txtRemark.Border.Class = "TextBoxBorder";
			this.txtRemark.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtRemark.DisabledBackColor = global::System.Drawing.Color.White;
			this.txtRemark.ForeColor = global::System.Drawing.Color.Black;
			this.txtRemark.Location = new global::System.Drawing.Point(4, 140);
			this.txtRemark.Margin = new global::System.Windows.Forms.Padding(0);
			this.txtRemark.MaxLength = 1000;
			this.txtRemark.Multiline = true;
			this.txtRemark.Name = "txtRemark";
			this.txtRemark.PreventEnterBeep = true;
			this.txtRemark.ScrollBars = global::System.Windows.Forms.ScrollBars.Vertical;
			this.txtRemark.Size = new global::System.Drawing.Size(534, 156);
			this.txtRemark.TabIndex = 6;
			this.cmbStep.DataSource = null;
			this.cmbStep.DisplayMember = null;
			this.cmbStep.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cmbStep.ForeColor = global::System.Drawing.Color.Black;
			this.cmbStep.FormattingEnabled = true;
			this.cmbStep.ItemHeight = 15;
			this.cmbStep.Location = new global::System.Drawing.Point(369, 4);
			this.cmbStep.Margin = new global::System.Windows.Forms.Padding(0);
			this.cmbStep.MaxDropDownItems = 20;
			this.cmbStep.Name = "cmbStep";
			this.cmbStep.SelectMember = null;
			this.cmbStep.Size = new global::System.Drawing.Size(169, 21);
			this.cmbStep.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.cmbStep.TabIndex = 1;
			this.cmbStep.ValueMember = null;
			this.cmbInvModel.DataSource = null;
			this.cmbInvModel.DisplayMember = null;
			this.cmbInvModel.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cmbInvModel.ForeColor = global::System.Drawing.Color.Black;
			this.cmbInvModel.FormattingEnabled = true;
			this.cmbInvModel.ItemHeight = 15;
			this.cmbInvModel.Location = new global::System.Drawing.Point(98, 4);
			this.cmbInvModel.Margin = new global::System.Windows.Forms.Padding(0);
			this.cmbInvModel.MaxDropDownItems = 20;
			this.cmbInvModel.Name = "cmbInvModel";
			this.cmbInvModel.SelectMember = null;
			this.cmbInvModel.Size = new global::System.Drawing.Size(169, 21);
			this.cmbInvModel.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.cmbInvModel.TabIndex = 0;
			this.cmbInvModel.ValueMember = null;
			this.txtAllowCondition.Border.Class = "TextBoxBorder";
			this.txtAllowCondition.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtAllowCondition.Location = new global::System.Drawing.Point(98, 61);
			this.txtAllowCondition.Margin = new global::System.Windows.Forms.Padding(0);
			this.txtAllowCondition.MaxLength = 1000;
			this.txtAllowCondition.Name = "txtAllowCondition";
			this.txtAllowCondition.PreventEnterBeep = true;
			this.txtAllowCondition.Size = new global::System.Drawing.Size(357, 21);
			this.txtAllowCondition.TabIndex = 3;
			this.layoutControlItem14.Control = this.cmbInvModel;
			this.layoutControlItem14.Height = 29;
			this.layoutControlItem14.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem14.Name = "layoutControlItem14";
			this.layoutControlItem14.Text = "Process";
			this.layoutControlItem14.Width = 50;
			this.layoutControlItem14.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem7.Control = this.cmbStep;
			this.layoutControlItem7.Height = 29;
			this.layoutControlItem7.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem7.Name = "layoutControlItem7";
			this.layoutControlItem7.Text = "ThisStep";
			this.layoutControlItem7.Width = 50;
			this.layoutControlItem7.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem1.Control = this.cmbLastStep;
			this.layoutControlItem1.Height = 28;
			this.layoutControlItem1.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Text = "LastStep";
			this.layoutControlItem1.Width = 50;
			this.layoutControlItem1.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem20.Control = this.txtAllowCondition;
			this.layoutControlItem20.Height = 29;
			this.layoutControlItem20.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem20.Name = "layoutControlItem20";
			this.layoutControlItem20.Text = "AllowCondition";
			this.layoutControlItem20.Width = 99;
			this.layoutControlItem20.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem3.Control = this.btnAllowConditionSet;
			this.layoutControlItem3.Height = 31;
			this.layoutControlItem3.MinSize = new global::System.Drawing.Size(32, 20);
			this.layoutControlItem3.Name = "layoutControlItem3";
			this.layoutControlItem3.Width = 83;
			this.layoutControlItem6.Control = this.chkEnable;
			this.layoutControlItem6.Height = 31;
			this.layoutControlItem6.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem6.Name = "layoutControlItem6";
			this.layoutControlItem6.Text = " ";
			this.layoutControlItem6.Width = 100;
			this.layoutControlItem6.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem4.Control = this.txtRemark;
			this.layoutControlItem4.Height = 100;
			this.layoutControlItem4.HeightType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem4.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem4.Name = "layoutControlItem4";
			this.layoutControlItem4.Text = "Memo";
			this.layoutControlItem4.TextPosition = global::DevComponents.DotNetBar.Layout.eLayoutPosition.Top;
			this.layoutControlItem4.Width = 100;
			this.layoutControlItem4.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
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
			this.lciRemark.Control = this.txtRemark;
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
			this.layoutControlItem5.Height = 26;
			this.layoutControlItem5.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem5.Name = "layoutControlItem5";
			this.layoutControlItem5.Text = "鹤位序号";
			this.layoutControlItem5.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem5.TextLineAlignment = global::DevComponents.DotNetBar.Layout.eTextLineAlignment.Middle;
			this.layoutControlItem5.Width = 50;
			this.layoutControlItem5.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem2.Height = 29;
			this.layoutControlItem2.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem2.Name = "layoutControlItem2";
			this.layoutControlItem2.Text = "股道名称";
			this.layoutControlItem2.Width = 50;
			this.layoutControlItem2.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
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
			this.layoutControlItem12.Height = 29;
			this.layoutControlItem12.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem12.Name = "layoutControlItem12";
			this.layoutControlItem12.Text = "物料步骤序号";
			this.layoutControlItem12.Width = 50;
			this.layoutControlItem12.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem17.Height = 29;
			this.layoutControlItem17.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem17.Name = "layoutControlItem17";
			this.layoutControlItem17.Text = "Label:";
			this.layoutControlItem17.Width = 50;
			this.layoutControlItem17.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem19.Control = this.txtAllowCondition;
			this.layoutControlItem19.Height = 29;
			this.layoutControlItem19.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem19.Name = "layoutControlItem19";
			this.layoutControlItem19.Text = "SrmCode";
			this.layoutControlItem19.Width = 50;
			this.layoutControlItem19.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			base.ClientSize = new global::System.Drawing.Size(542, 326);
			base.Controls.Add(this.lcMain);
			base.Controls.Add(this.bar1);
			base.Name = "frmInvStepEdit";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "SrmInvStep";
			base.Load += new global::System.EventHandler(this.frmInvStepEdit_Load);
			((global::System.ComponentModel.ISupportInitialize)this.bar1).EndInit();
			this.lcMain.ResumeLayout(false);
			this.lcMain.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x04000674 RID: 1652
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000675 RID: 1653
		private global::DevComponents.DotNetBar.Bar bar1;

		// Token: 0x04000676 RID: 1654
		private global::DevComponents.DotNetBar.ButtonItem menuSave;

		// Token: 0x04000677 RID: 1655
		private global::DevComponents.DotNetBar.Layout.LayoutControl lcMain;

		// Token: 0x04000678 RID: 1656
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem lciName;

		// Token: 0x04000679 RID: 1657
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem lciCheDao;

		// Token: 0x0400067A RID: 1658
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem8;

		// Token: 0x0400067B RID: 1659
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtRemark;

		// Token: 0x0400067C RID: 1660
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem4;

		// Token: 0x0400067D RID: 1661
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem lciRemark;

		// Token: 0x0400067E RID: 1662
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem lciIndex;

		// Token: 0x0400067F RID: 1663
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem5;

		// Token: 0x04000680 RID: 1664
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem2;

		// Token: 0x04000681 RID: 1665
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem11;

		// Token: 0x04000682 RID: 1666
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem10;

		// Token: 0x04000683 RID: 1667
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem9;

		// Token: 0x04000684 RID: 1668
		private global::Base.AutoComboBox cmbStep;

		// Token: 0x04000685 RID: 1669
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem7;

		// Token: 0x04000686 RID: 1670
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem12;

		// Token: 0x04000687 RID: 1671
		private global::Base.AutoComboBox cmbInvModel;

		// Token: 0x04000688 RID: 1672
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem14;

		// Token: 0x04000689 RID: 1673
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtAllowCondition;

		// Token: 0x0400068A RID: 1674
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem20;

		// Token: 0x0400068B RID: 1675
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem17;

		// Token: 0x0400068C RID: 1676
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem19;

		// Token: 0x0400068D RID: 1677
		private global::Base.AutoComboBox cmbLastStep;

		// Token: 0x0400068E RID: 1678
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem1;

		// Token: 0x0400068F RID: 1679
		private global::DevComponents.DotNetBar.Controls.CheckBoxX chkEnable;

		// Token: 0x04000690 RID: 1680
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem6;

		// Token: 0x04000691 RID: 1681
		private global::System.Windows.Forms.Button btnAllowConditionSet;

		// Token: 0x04000692 RID: 1682
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem3;
	}
}
