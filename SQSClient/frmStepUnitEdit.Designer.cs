namespace SQSClient
{
	// Token: 0x02000057 RID: 87
	public partial class frmStepUnitEdit : global::SQSClient.BaseDialogForm
	{
		// Token: 0x06000432 RID: 1074 RVA: 0x0006AAD8 File Offset: 0x00068CD8
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000433 RID: 1075 RVA: 0x0006AB10 File Offset: 0x00068D10
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
			this.cmbEquips = new global::Base.AutoComboBox();
			this.cmbStep = new global::Base.AutoComboBox();
			this.layoutControlItem1 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.GDIndex = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem3 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem6 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem7 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem12 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
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
			this.lcMain.Controls.Add(this.cmbEquips);
			this.lcMain.Controls.Add(this.cmbStep);
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
				this.layoutControlItem12,
				this.layoutControlItem4
			});
			this.lcMain.Size = new global::System.Drawing.Size(542, 217);
			this.lcMain.TabIndex = 1;
			this.tbxName.Border.Class = "TextBoxBorder";
			this.tbxName.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.tbxName.Location = new global::System.Drawing.Point(61, 4);
			this.tbxName.Margin = new global::System.Windows.Forms.Padding(0);
			this.tbxName.Name = "tbxName";
			this.tbxName.PreventEnterBeep = true;
			this.tbxName.Size = new global::System.Drawing.Size(206, 21);
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
			this.tbxRemark.Size = new global::System.Drawing.Size(534, 105);
			this.tbxRemark.TabIndex = 6;
			this.nudIndex.BackgroundStyle.Class = "DateTimeInputBackground";
			this.nudIndex.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.nudIndex.ButtonFreeText.Shortcut = global::DevComponents.DotNetBar.eShortcut.F2;
			this.nudIndex.Location = new global::System.Drawing.Point(332, 4);
			this.nudIndex.Margin = new global::System.Windows.Forms.Padding(0);
			this.nudIndex.MaxValue = 999;
			this.nudIndex.MinValue = 1;
			this.nudIndex.Name = "nudIndex";
			this.nudIndex.ShowUpDown = true;
			this.nudIndex.Size = new global::System.Drawing.Size(206, 21);
			this.nudIndex.TabIndex = 1;
			this.nudIndex.Value = 1;
			this.tbxStepCode.Border.Class = "TextBoxBorder";
			this.tbxStepCode.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.tbxStepCode.Location = new global::System.Drawing.Point(61, 33);
			this.tbxStepCode.Margin = new global::System.Windows.Forms.Padding(0);
			this.tbxStepCode.Name = "tbxStepCode";
			this.tbxStepCode.PreventEnterBeep = true;
			this.tbxStepCode.Size = new global::System.Drawing.Size(206, 21);
			this.tbxStepCode.TabIndex = 2;
			this.cmbState.DataSource = null;
			this.cmbState.DisplayMember = null;
			this.cmbState.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cmbState.FormattingEnabled = true;
			this.cmbState.ItemHeight = 15;
			this.cmbState.Location = new global::System.Drawing.Point(332, 33);
			this.cmbState.Margin = new global::System.Windows.Forms.Padding(0);
			this.cmbState.MaxDropDownItems = 20;
			this.cmbState.Name = "cmbState";
			this.cmbState.SelectMember = null;
			this.cmbState.Size = new global::System.Drawing.Size(206, 21);
			this.cmbState.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.cmbState.TabIndex = 3;
			this.cmbState.ValueMember = null;
			this.cmbEquips.DataSource = null;
			this.cmbEquips.DisplayMember = null;
			this.cmbEquips.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cmbEquips.ForeColor = global::System.Drawing.Color.Black;
			this.cmbEquips.FormattingEnabled = true;
			this.cmbEquips.ItemHeight = 15;
			this.cmbEquips.Location = new global::System.Drawing.Point(61, 62);
			this.cmbEquips.Margin = new global::System.Windows.Forms.Padding(0);
			this.cmbEquips.MaxDropDownItems = 20;
			this.cmbEquips.Name = "cmbEquips";
			this.cmbEquips.SelectMember = null;
			this.cmbEquips.Size = new global::System.Drawing.Size(206, 21);
			this.cmbEquips.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.cmbEquips.TabIndex = 4;
			this.cmbEquips.ValueMember = null;
			this.cmbStep.DataSource = null;
			this.cmbStep.DisplayMember = null;
			this.cmbStep.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cmbStep.ForeColor = global::System.Drawing.Color.Black;
			this.cmbStep.FormattingEnabled = true;
			this.cmbStep.ItemHeight = 15;
			this.cmbStep.Location = new global::System.Drawing.Point(332, 62);
			this.cmbStep.Margin = new global::System.Windows.Forms.Padding(0);
			this.cmbStep.MaxDropDownItems = 20;
			this.cmbStep.Name = "cmbStep";
			this.cmbStep.SelectMember = null;
			this.cmbStep.Size = new global::System.Drawing.Size(206, 21);
			this.cmbStep.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.cmbStep.TabIndex = 5;
			this.cmbStep.ValueMember = null;
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
			this.layoutControlItem6.Text = "SrmStep";
			this.layoutControlItem6.Width = 50;
			this.layoutControlItem6.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem7.Control = this.cmbEquips;
			this.layoutControlItem7.Height = 29;
			this.layoutControlItem7.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem7.Name = "layoutControlItem7";
			this.layoutControlItem7.Text = "SrmEquip";
			this.layoutControlItem7.Width = 50;
			this.layoutControlItem7.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem12.Control = this.cmbStep;
			this.layoutControlItem12.Height = 29;
			this.layoutControlItem12.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem12.Name = "layoutControlItem12";
			this.layoutControlItem12.Text = "SrmStep";
			this.layoutControlItem12.Width = 50;
			this.layoutControlItem12.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
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
			this.layoutControlItem10.Control = this.cmbEquips;
			this.layoutControlItem10.Height = 29;
			this.layoutControlItem10.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem10.Name = "layoutControlItem10";
			this.layoutControlItem10.Text = "客户单位:";
			this.layoutControlItem10.Width = 94;
			this.layoutControlItem10.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem9.Control = this.cmbStep;
			this.layoutControlItem9.Height = 29;
			this.layoutControlItem9.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem9.Name = "layoutControlItem9";
			this.layoutControlItem9.Text = "Label:";
			this.layoutControlItem9.Width = 50;
			this.layoutControlItem9.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			base.ClientSize = new global::System.Drawing.Size(542, 243);
			base.Controls.Add(this.lcMain);
			base.Controls.Add(this.bar1);
			base.Name = "frmStepUnitEdit";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "SrmUnitStep";
			base.Load += new global::System.EventHandler(this.frmStepUnitEdit_Load);
			((global::System.ComponentModel.ISupportInitialize)this.bar1).EndInit();
			this.lcMain.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.nudIndex).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000749 RID: 1865
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400074A RID: 1866
		private global::DevComponents.DotNetBar.Bar bar1;

		// Token: 0x0400074B RID: 1867
		private global::DevComponents.DotNetBar.ButtonItem menuSave;

		// Token: 0x0400074C RID: 1868
		private global::DevComponents.DotNetBar.Layout.LayoutControl lcMain;

		// Token: 0x0400074D RID: 1869
		private global::DevComponents.DotNetBar.Controls.TextBoxX tbxName;

		// Token: 0x0400074E RID: 1870
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem1;

		// Token: 0x0400074F RID: 1871
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem lciName;

		// Token: 0x04000750 RID: 1872
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem lciCheDao;

		// Token: 0x04000751 RID: 1873
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem8;

		// Token: 0x04000752 RID: 1874
		private global::DevComponents.DotNetBar.Controls.TextBoxX tbxRemark;

		// Token: 0x04000753 RID: 1875
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem4;

		// Token: 0x04000754 RID: 1876
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem lciRemark;

		// Token: 0x04000755 RID: 1877
		private global::DevComponents.Editors.IntegerInput nudIndex;

		// Token: 0x04000756 RID: 1878
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem GDIndex;

		// Token: 0x04000757 RID: 1879
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem lciIndex;

		// Token: 0x04000758 RID: 1880
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem5;

		// Token: 0x04000759 RID: 1881
		private global::DevComponents.DotNetBar.Controls.TextBoxX tbxStepCode;

		// Token: 0x0400075A RID: 1882
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem3;

		// Token: 0x0400075B RID: 1883
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem2;

		// Token: 0x0400075C RID: 1884
		private global::Base.AutoComboBox cmbState;

		// Token: 0x0400075D RID: 1885
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem6;

		// Token: 0x0400075E RID: 1886
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem11;

		// Token: 0x0400075F RID: 1887
		private global::Base.AutoComboBox cmbEquips;

		// Token: 0x04000760 RID: 1888
		private global::Base.AutoComboBox cmbStep;

		// Token: 0x04000761 RID: 1889
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem7;

		// Token: 0x04000762 RID: 1890
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem12;

		// Token: 0x04000763 RID: 1891
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem10;

		// Token: 0x04000764 RID: 1892
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem9;
	}
}
