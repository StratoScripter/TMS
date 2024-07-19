namespace SQSClient
{
	// Token: 0x0200004D RID: 77
	public partial class frmInvModelEdit : global::SQSClient.BaseDialogForm
	{
		// Token: 0x060003BE RID: 958 RVA: 0x0005EB7C File Offset: 0x0005CD7C
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060003BF RID: 959 RVA: 0x0005EBB4 File Offset: 0x0005CDB4
		private void InitializeComponent()
		{
			this.bar1 = new global::DevComponents.DotNetBar.Bar();
			this.menuSave = new global::DevComponents.DotNetBar.ButtonItem();
			this.lcMain = new global::DevComponents.DotNetBar.Layout.LayoutControl();
			this.chkEnable = new global::DevComponents.DotNetBar.Controls.CheckBoxX();
			this.txtName = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.txtRemark = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.layoutControlItem1 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem3 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem4 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.lciName = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.lciCheDao = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem8 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.lciRemark = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.lciIndex = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem5 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem2 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem11 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
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
			this.lcMain.Controls.Add(this.chkEnable);
			this.lcMain.Controls.Add(this.txtName);
			this.lcMain.Controls.Add(this.txtRemark);
			this.lcMain.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.lcMain.Location = new global::System.Drawing.Point(0, 26);
			this.lcMain.Name = "lcMain";
			this.lcMain.RootGroup.Items.AddRange(new global::DevComponents.DotNetBar.Layout.LayoutItemBase[]
			{
				this.layoutControlItem1,
				this.layoutControlItem3,
				this.layoutControlItem4
			});
			this.lcMain.Size = new global::System.Drawing.Size(542, 217);
			this.lcMain.TabIndex = 1;
			this.chkEnable.AutoSize = true;
			this.chkEnable.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.chkEnable.Location = new global::System.Drawing.Point(55, 33);
			this.chkEnable.Margin = new global::System.Windows.Forms.Padding(0);
			this.chkEnable.Name = "chkEnable";
			this.chkEnable.Size = new global::System.Drawing.Size(64, 16);
			this.chkEnable.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.chkEnable.TabIndex = 1;
			this.chkEnable.Text = "Enable";
			this.txtName.Border.Class = "TextBoxBorder";
			this.txtName.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtName.Location = new global::System.Drawing.Point(55, 4);
			this.txtName.Margin = new global::System.Windows.Forms.Padding(0);
			this.txtName.Name = "txtName";
			this.txtName.PreventEnterBeep = true;
			this.txtName.Size = new global::System.Drawing.Size(483, 21);
			this.txtName.TabIndex = 0;
			this.txtRemark.BackColor = global::System.Drawing.Color.White;
			this.txtRemark.Border.Class = "TextBoxBorder";
			this.txtRemark.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtRemark.DisabledBackColor = global::System.Drawing.Color.White;
			this.txtRemark.ForeColor = global::System.Drawing.Color.Black;
			this.txtRemark.Location = new global::System.Drawing.Point(4, 81);
			this.txtRemark.Margin = new global::System.Windows.Forms.Padding(0);
			this.txtRemark.Multiline = true;
			this.txtRemark.Name = "txtRemark";
			this.txtRemark.PreventEnterBeep = true;
			this.txtRemark.ScrollBars = global::System.Windows.Forms.ScrollBars.Vertical;
			this.txtRemark.Size = new global::System.Drawing.Size(534, 132);
			this.txtRemark.TabIndex = 2;
			this.layoutControlItem1.Control = this.txtName;
			this.layoutControlItem1.Height = 29;
			this.layoutControlItem1.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Text = "SrmName";
			this.layoutControlItem1.Width = 100;
			this.layoutControlItem1.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem3.Control = this.chkEnable;
			this.layoutControlItem3.Height = 31;
			this.layoutControlItem3.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem3.Name = "layoutControlItem3";
			this.layoutControlItem3.Text = " ";
			this.layoutControlItem3.Width = 100;
			this.layoutControlItem3.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
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
			base.ClientSize = new global::System.Drawing.Size(542, 243);
			base.Controls.Add(this.lcMain);
			base.Controls.Add(this.bar1);
			base.Name = "frmInvModelEdit";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "SrmInvModel";
			base.Load += new global::System.EventHandler(this.frmInvModelEdit_Load);
			((global::System.ComponentModel.ISupportInitialize)this.bar1).EndInit();
			this.lcMain.ResumeLayout(false);
			this.lcMain.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x04000649 RID: 1609
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400064A RID: 1610
		private global::DevComponents.DotNetBar.Bar bar1;

		// Token: 0x0400064B RID: 1611
		private global::DevComponents.DotNetBar.ButtonItem menuSave;

		// Token: 0x0400064C RID: 1612
		private global::DevComponents.DotNetBar.Layout.LayoutControl lcMain;

		// Token: 0x0400064D RID: 1613
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtName;

		// Token: 0x0400064E RID: 1614
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem1;

		// Token: 0x0400064F RID: 1615
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem lciName;

		// Token: 0x04000650 RID: 1616
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem lciCheDao;

		// Token: 0x04000651 RID: 1617
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem8;

		// Token: 0x04000652 RID: 1618
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtRemark;

		// Token: 0x04000653 RID: 1619
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem4;

		// Token: 0x04000654 RID: 1620
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem lciRemark;

		// Token: 0x04000655 RID: 1621
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem lciIndex;

		// Token: 0x04000656 RID: 1622
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem5;

		// Token: 0x04000657 RID: 1623
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem2;

		// Token: 0x04000658 RID: 1624
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem11;

		// Token: 0x04000659 RID: 1625
		private global::DevComponents.DotNetBar.Controls.CheckBoxX chkEnable;

		// Token: 0x0400065A RID: 1626
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem3;
	}
}
