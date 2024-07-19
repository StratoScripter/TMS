namespace SQSClient
{
	// Token: 0x02000055 RID: 85
	public partial class frmStepEdit : global::SQSClient.BaseDialogForm
	{
		// Token: 0x0600041B RID: 1051 RVA: 0x00068304 File Offset: 0x00066504
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600041C RID: 1052 RVA: 0x0006833C File Offset: 0x0006653C
		private void InitializeComponent()
		{
			this.bar1 = new global::DevComponents.DotNetBar.Bar();
			this.menuSave = new global::DevComponents.DotNetBar.ButtonItem();
			this.lcMain = new global::DevComponents.DotNetBar.Layout.LayoutControl();
			this.chkEnable = new global::DevComponents.DotNetBar.Controls.CheckBoxX();
			this.txtName = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.txtRemark = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.txtStepCode = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.txtReachBasis = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.layoutControlItem1 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem3 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem12 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem9 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem4 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.lciName = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.lciCheDao = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem8 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.lciRemark = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.lciIndex = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem5 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem2 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem11 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem7 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem10 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.txtResetBasis = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.layoutControlItem6 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
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
			this.menuSave.Click += new global::System.EventHandler(this.btnSave_Click);
			this.lcMain.Controls.Add(this.txtResetBasis);
			this.lcMain.Controls.Add(this.chkEnable);
			this.lcMain.Controls.Add(this.txtName);
			this.lcMain.Controls.Add(this.txtRemark);
			this.lcMain.Controls.Add(this.txtStepCode);
			this.lcMain.Controls.Add(this.txtReachBasis);
			this.lcMain.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.lcMain.Location = new global::System.Drawing.Point(0, 26);
			this.lcMain.Name = "lcMain";
			this.lcMain.RootGroup.Items.AddRange(new global::DevComponents.DotNetBar.Layout.LayoutItemBase[]
			{
				this.layoutControlItem1,
				this.layoutControlItem3,
				this.layoutControlItem12,
				this.layoutControlItem6,
				this.layoutControlItem9,
				this.layoutControlItem4
			});
			this.lcMain.Size = new global::System.Drawing.Size(542, 244);
			this.lcMain.TabIndex = 1;
			this.chkEnable.AutoSize = true;
			this.chkEnable.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.chkEnable.Checked = true;
			this.chkEnable.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.chkEnable.CheckValue = "Y";
			this.chkEnable.Location = new global::System.Drawing.Point(92, 120);
			this.chkEnable.Margin = new global::System.Windows.Forms.Padding(0);
			this.chkEnable.Name = "chkEnable";
			this.chkEnable.Size = new global::System.Drawing.Size(64, 16);
			this.chkEnable.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.chkEnable.TabIndex = 4;
			this.chkEnable.Text = "Enable";
			this.txtName.Border.Class = "TextBoxBorder";
			this.txtName.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtName.Location = new global::System.Drawing.Point(92, 4);
			this.txtName.Margin = new global::System.Windows.Forms.Padding(0);
			this.txtName.Name = "txtName";
			this.txtName.PreventEnterBeep = true;
			this.txtName.Size = new global::System.Drawing.Size(446, 21);
			this.txtName.TabIndex = 0;
			this.txtRemark.BackColor = global::System.Drawing.Color.White;
			this.txtRemark.Border.Class = "TextBoxBorder";
			this.txtRemark.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtRemark.DisabledBackColor = global::System.Drawing.Color.White;
			this.txtRemark.ForeColor = global::System.Drawing.Color.Black;
			this.txtRemark.Location = new global::System.Drawing.Point(4, 168);
			this.txtRemark.Margin = new global::System.Windows.Forms.Padding(0);
			this.txtRemark.Multiline = true;
			this.txtRemark.Name = "txtRemark";
			this.txtRemark.PreventEnterBeep = true;
			this.txtRemark.ScrollBars = global::System.Windows.Forms.ScrollBars.Vertical;
			this.txtRemark.Size = new global::System.Drawing.Size(534, 72);
			this.txtRemark.TabIndex = 5;
			this.txtStepCode.Border.Class = "TextBoxBorder";
			this.txtStepCode.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtStepCode.Location = new global::System.Drawing.Point(92, 33);
			this.txtStepCode.Margin = new global::System.Windows.Forms.Padding(0);
			this.txtStepCode.Name = "txtStepCode";
			this.txtStepCode.PreventEnterBeep = true;
			this.txtStepCode.Size = new global::System.Drawing.Size(446, 21);
			this.txtStepCode.TabIndex = 1;
			this.txtReachBasis.Border.Class = "TextBoxBorder";
			this.txtReachBasis.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtReachBasis.Location = new global::System.Drawing.Point(92, 62);
			this.txtReachBasis.Margin = new global::System.Windows.Forms.Padding(0);
			this.txtReachBasis.Name = "txtReachBasis";
			this.txtReachBasis.PreventEnterBeep = true;
			this.txtReachBasis.Size = new global::System.Drawing.Size(446, 21);
			this.txtReachBasis.TabIndex = 2;
			this.layoutControlItem1.Control = this.txtName;
			this.layoutControlItem1.Height = 29;
			this.layoutControlItem1.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Text = "SrmName";
			this.layoutControlItem1.Width = 100;
			this.layoutControlItem1.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem3.Control = this.txtStepCode;
			this.layoutControlItem3.Height = 29;
			this.layoutControlItem3.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem3.Name = "layoutControlItem3";
			this.layoutControlItem3.Text = "SrmCode";
			this.layoutControlItem3.Width = 50;
			this.layoutControlItem3.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem12.Control = this.txtReachBasis;
			this.layoutControlItem12.Height = 29;
			this.layoutControlItem12.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem12.Name = "layoutControlItem12";
			this.layoutControlItem12.Text = "SrmReachBasis";
			this.layoutControlItem12.Width = 100;
			this.layoutControlItem12.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem9.Control = this.chkEnable;
			this.layoutControlItem9.Height = 31;
			this.layoutControlItem9.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem9.Name = "layoutControlItem9";
			this.layoutControlItem9.Text = " ";
			this.layoutControlItem9.Width = 50;
			this.layoutControlItem9.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem4.Control = this.txtRemark;
			this.layoutControlItem4.Height = 100;
			this.layoutControlItem4.HeightType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem4.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem4.Name = "layoutControlItem4";
			this.layoutControlItem4.Text = "Memo";
			this.layoutControlItem4.TextPosition = global::DevComponents.DotNetBar.Layout.eLayoutPosition.Top;
			this.layoutControlItem4.Width = 100;
			this.layoutControlItem4.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.lciName.Control = this.txtName;
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
			this.layoutControlItem2.Control = this.txtStepCode;
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
			this.layoutControlItem7.Height = 29;
			this.layoutControlItem7.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem7.Name = "layoutControlItem7";
			this.layoutControlItem7.Text = "SrmCode";
			this.layoutControlItem7.Width = 50;
			this.layoutControlItem7.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem10.Control = this.txtReachBasis;
			this.layoutControlItem10.Height = 29;
			this.layoutControlItem10.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem10.Name = "layoutControlItem10";
			this.layoutControlItem10.Text = "SrmIdentifyCode";
			this.layoutControlItem10.Width = 50;
			this.layoutControlItem10.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.txtResetBasis.Border.Class = "TextBoxBorder";
			this.txtResetBasis.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtResetBasis.Location = new global::System.Drawing.Point(92, 91);
			this.txtResetBasis.Margin = new global::System.Windows.Forms.Padding(0, 0, 0, 0);
			this.txtResetBasis.Name = "txtResetBasis";
			this.txtResetBasis.PreventEnterBeep = true;
			this.txtResetBasis.Size = new global::System.Drawing.Size(446, 21);
			this.txtResetBasis.TabIndex = 3;
			this.layoutControlItem6.Control = this.txtResetBasis;
			this.layoutControlItem6.Height = 29;
			this.layoutControlItem6.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem6.Name = "layoutControlItem6";
			this.layoutControlItem6.Text = "SrmResetBasis";
			this.layoutControlItem6.Width = 100;
			this.layoutControlItem6.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			base.ClientSize = new global::System.Drawing.Size(542, 270);
			base.Controls.Add(this.lcMain);
			base.Controls.Add(this.bar1);
			base.Name = "frmStepEdit";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "SrmStep";
			base.Load += new global::System.EventHandler(this.frmStepEdit_Load);
			((global::System.ComponentModel.ISupportInitialize)this.bar1).EndInit();
			this.lcMain.ResumeLayout(false);
			this.lcMain.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x04000715 RID: 1813
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000716 RID: 1814
		private global::DevComponents.DotNetBar.Bar bar1;

		// Token: 0x04000717 RID: 1815
		private global::DevComponents.DotNetBar.ButtonItem menuSave;

		// Token: 0x04000718 RID: 1816
		private global::DevComponents.DotNetBar.Layout.LayoutControl lcMain;

		// Token: 0x04000719 RID: 1817
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtName;

		// Token: 0x0400071A RID: 1818
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem1;

		// Token: 0x0400071B RID: 1819
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem lciName;

		// Token: 0x0400071C RID: 1820
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem lciCheDao;

		// Token: 0x0400071D RID: 1821
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem8;

		// Token: 0x0400071E RID: 1822
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtRemark;

		// Token: 0x0400071F RID: 1823
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem4;

		// Token: 0x04000720 RID: 1824
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem lciRemark;

		// Token: 0x04000721 RID: 1825
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem lciIndex;

		// Token: 0x04000722 RID: 1826
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem5;

		// Token: 0x04000723 RID: 1827
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtStepCode;

		// Token: 0x04000724 RID: 1828
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem3;

		// Token: 0x04000725 RID: 1829
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem2;

		// Token: 0x04000726 RID: 1830
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem11;

		// Token: 0x04000727 RID: 1831
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtReachBasis;

		// Token: 0x04000728 RID: 1832
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem12;

		// Token: 0x04000729 RID: 1833
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem7;

		// Token: 0x0400072A RID: 1834
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem10;

		// Token: 0x0400072B RID: 1835
		private global::DevComponents.DotNetBar.Controls.CheckBoxX chkEnable;

		// Token: 0x0400072C RID: 1836
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem9;

		// Token: 0x0400072D RID: 1837
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtResetBasis;

		// Token: 0x0400072E RID: 1838
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem6;
	}
}
