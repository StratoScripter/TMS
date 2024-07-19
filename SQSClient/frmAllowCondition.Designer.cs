namespace SQSClient
{
	// Token: 0x02000027 RID: 39
	public partial class frmAllowCondition : global::SQSClient.BaseDialogForm
	{
		// Token: 0x060001EA RID: 490 RVA: 0x00039360 File Offset: 0x00037560
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060001EB RID: 491 RVA: 0x00039398 File Offset: 0x00037598
		private void InitializeComponent()
		{
			this.bar1 = new global::DevComponents.DotNetBar.Bar();
			this.iItemCount = new global::DevComponents.Editors.IntegerInput();
			this.labelItem1 = new global::DevComponents.DotNetBar.LabelItem();
			this.btnConfirm = new global::DevComponents.DotNetBar.ButtonItem();
			this.menuSave = new global::DevComponents.DotNetBar.ButtonItem();
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
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.buttonItem1 = new global::DevComponents.DotNetBar.ButtonItem();
			((global::System.ComponentModel.ISupportInitialize)this.bar1).BeginInit();
			this.bar1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.iItemCount).BeginInit();
			base.SuspendLayout();
			this.bar1.AntiAlias = true;
			this.bar1.BackColor = global::System.Drawing.Color.Transparent;
			this.bar1.Controls.Add(this.iItemCount);
			this.bar1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.bar1.Font = new global::System.Drawing.Font("Microsoft YaHei UI", 9f);
			this.bar1.IsMaximized = false;
			this.bar1.Items.AddRange(new global::DevComponents.DotNetBar.BaseItem[]
			{
				this.labelItem1,
				this.btnConfirm,
				this.menuSave
			});
			this.bar1.Location = new global::System.Drawing.Point(0, 0);
			this.bar1.Name = "bar1";
			this.bar1.Size = new global::System.Drawing.Size(511, 26);
			this.bar1.Stretch = true;
			this.bar1.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.bar1.TabIndex = 0;
			this.bar1.TabStop = false;
			this.bar1.Text = "bar1";
			this.iItemCount.BackgroundStyle.Class = "DateTimeInputBackground";
			this.iItemCount.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.iItemCount.ButtonFreeText.Shortcut = global::DevComponents.DotNetBar.eShortcut.F2;
			this.iItemCount.InputHorizontalAlignment = global::DevComponents.Editors.eHorizontalAlignment.Left;
			this.iItemCount.Location = new global::System.Drawing.Point(36, 0);
			this.iItemCount.Margin = new global::System.Windows.Forms.Padding(0);
			this.iItemCount.MaxValue = 10;
			this.iItemCount.MinValue = 0;
			this.iItemCount.Name = "iItemCount";
			this.iItemCount.ShowUpDown = true;
			this.iItemCount.Size = new global::System.Drawing.Size(50, 23);
			this.iItemCount.TabIndex = 16;
			this.labelItem1.Name = "labelItem1";
			this.labelItem1.Text = "item             ";
			this.btnConfirm.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.btnConfirm.Image = global::SQSClient.Properties.Resources.adjust16;
			this.btnConfirm.Name = "btnConfirm";
			this.btnConfirm.Text = "Confirm";
			this.btnConfirm.Click += new global::System.EventHandler(this.btnConfirm_Click);
			this.menuSave.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.menuSave.Image = global::SQSClient.Properties.Resources.save16;
			this.menuSave.ItemAlignment = global::DevComponents.DotNetBar.eItemAlignment.Far;
			this.menuSave.Name = "menuSave";
			this.menuSave.Text = "Save";
			this.menuSave.Click += new global::System.EventHandler(this.menuSave_Click);
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
			this.layoutControlItem19.Height = 29;
			this.layoutControlItem19.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem19.Name = "layoutControlItem19";
			this.layoutControlItem19.Text = "SrmCode";
			this.layoutControlItem19.Width = 50;
			this.layoutControlItem19.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.panel1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.panel1.Location = new global::System.Drawing.Point(3, 26);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(508, 292);
			this.panel1.TabIndex = 1;
			this.buttonItem1.Name = "buttonItem1";
			base.ClientSize = new global::System.Drawing.Size(511, 330);
			base.Controls.Add(this.panel1);
			base.Controls.Add(this.bar1);
			base.Name = "frmAllowCondition";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "AllowCondition";
			base.Load += new global::System.EventHandler(this.frmAllowCondition_Load);
			((global::System.ComponentModel.ISupportInitialize)this.bar1).EndInit();
			this.bar1.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.iItemCount).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000372 RID: 882
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000373 RID: 883
		private global::DevComponents.DotNetBar.Bar bar1;

		// Token: 0x04000374 RID: 884
		private global::DevComponents.DotNetBar.ButtonItem menuSave;

		// Token: 0x04000375 RID: 885
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem lciName;

		// Token: 0x04000376 RID: 886
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem lciCheDao;

		// Token: 0x04000377 RID: 887
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem8;

		// Token: 0x04000378 RID: 888
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem lciRemark;

		// Token: 0x04000379 RID: 889
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem lciIndex;

		// Token: 0x0400037A RID: 890
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem5;

		// Token: 0x0400037B RID: 891
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem2;

		// Token: 0x0400037C RID: 892
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem11;

		// Token: 0x0400037D RID: 893
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem10;

		// Token: 0x0400037E RID: 894
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem9;

		// Token: 0x0400037F RID: 895
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem12;

		// Token: 0x04000380 RID: 896
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem17;

		// Token: 0x04000381 RID: 897
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem19;

		// Token: 0x04000382 RID: 898
		private global::DevComponents.DotNetBar.LabelItem labelItem1;

		// Token: 0x04000383 RID: 899
		private global::DevComponents.DotNetBar.ButtonItem btnConfirm;

		// Token: 0x04000384 RID: 900
		private global::DevComponents.Editors.IntegerInput iItemCount;

		// Token: 0x04000385 RID: 901
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x04000386 RID: 902
		private global::DevComponents.DotNetBar.ButtonItem buttonItem1;
	}
}
