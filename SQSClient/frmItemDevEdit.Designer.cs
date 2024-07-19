namespace SQSClient
{
	// Token: 0x02000081 RID: 129
	public partial class frmItemDevEdit : global::SQSClient.BaseDialogForm
	{
		// Token: 0x06000710 RID: 1808 RVA: 0x000AF490 File Offset: 0x000AD690
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000711 RID: 1809 RVA: 0x000AF4C8 File Offset: 0x000AD6C8
		private void InitializeComponent()
		{
			this.menuBar = new global::DevComponents.DotNetBar.Bar();
			this.btnSave = new global::DevComponents.DotNetBar.ButtonItem();
			this.lcMain = new global::DevComponents.DotNetBar.Layout.LayoutControl();
			this.iInputLuHao = new global::DevComponents.Editors.IntegerInput();
			this.rtxtRemark = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.txtItemCode = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.txtPara = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.txtItemDesc = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.cmbDataStyle = new global::DevComponents.DotNetBar.Controls.ComboBoxEx();
			this.cmbWriteR = new global::DevComponents.DotNetBar.Controls.ComboBoxEx();
			this.txtLinkAddr = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.layoutControlItem2 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.lciName = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem9 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layPointCode = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem4 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem6 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem8 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.lciRemark = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem1 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem3 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem5 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem7 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			((global::System.ComponentModel.ISupportInitialize)this.menuBar).BeginInit();
			this.lcMain.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.iInputLuHao).BeginInit();
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
				this.btnSave
			});
			this.menuBar.Location = new global::System.Drawing.Point(0, 0);
			this.menuBar.MenuBar = true;
			this.menuBar.Name = "menuBar";
			this.menuBar.Size = new global::System.Drawing.Size(554, 26);
			this.menuBar.Stretch = true;
			this.menuBar.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.menuBar.TabIndex = 8;
			this.menuBar.TabStop = false;
			this.menuBar.Text = "Main Menu";
			this.btnSave.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.btnSave.Image = global::SQSClient.Properties.Resources.save16;
			this.btnSave.Name = "btnSave";
			this.btnSave.Text = "Save";
			this.btnSave.Click += new global::System.EventHandler(this.btnSave_Click);
			this.lcMain.Controls.Add(this.iInputLuHao);
			this.lcMain.Controls.Add(this.rtxtRemark);
			this.lcMain.Controls.Add(this.txtItemCode);
			this.lcMain.Controls.Add(this.txtPara);
			this.lcMain.Controls.Add(this.txtItemDesc);
			this.lcMain.Controls.Add(this.cmbDataStyle);
			this.lcMain.Controls.Add(this.cmbWriteR);
			this.lcMain.Controls.Add(this.txtLinkAddr);
			this.lcMain.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.lcMain.Location = new global::System.Drawing.Point(0, 26);
			this.lcMain.Name = "lcMain";
			this.lcMain.RootGroup.Items.AddRange(new global::DevComponents.DotNetBar.Layout.LayoutItemBase[]
			{
				this.layoutControlItem2,
				this.lciName,
				this.layoutControlItem9,
				this.layPointCode,
				this.layoutControlItem4,
				this.layoutControlItem6,
				this.layoutControlItem8,
				this.lciRemark
			});
			this.lcMain.Size = new global::System.Drawing.Size(554, 200);
			this.lcMain.TabIndex = 0;
			this.iInputLuHao.BackgroundStyle.Class = "DateTimeInputBackground";
			this.iInputLuHao.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.iInputLuHao.ButtonFreeText.Shortcut = global::DevComponents.DotNetBar.eShortcut.F2;
			this.iInputLuHao.InputHorizontalAlignment = global::DevComponents.Editors.eHorizontalAlignment.Left;
			this.iInputLuHao.Location = new global::System.Drawing.Point(431, 4);
			this.iInputLuHao.Margin = new global::System.Windows.Forms.Padding(0);
			this.iInputLuHao.MaxValue = 2;
			this.iInputLuHao.MinValue = 1;
			this.iInputLuHao.Name = "iInputLuHao";
			this.iInputLuHao.Size = new global::System.Drawing.Size(119, 21);
			this.iInputLuHao.TabIndex = 2;
			this.iInputLuHao.Value = 1;
			this.rtxtRemark.Border.Class = "TextBoxBorder";
			this.rtxtRemark.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.rtxtRemark.Location = new global::System.Drawing.Point(4, 108);
			this.rtxtRemark.Margin = new global::System.Windows.Forms.Padding(0);
			this.rtxtRemark.Multiline = true;
			this.rtxtRemark.Name = "rtxtRemark";
			this.rtxtRemark.PreventEnterBeep = true;
			this.rtxtRemark.Size = new global::System.Drawing.Size(546, 88);
			this.rtxtRemark.TabIndex = 7;
			this.txtItemCode.Border.Class = "TextBoxBorder";
			this.txtItemCode.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtItemCode.Location = new global::System.Drawing.Point(67, 33);
			this.txtItemCode.Margin = new global::System.Windows.Forms.Padding(0);
			this.txtItemCode.Name = "txtItemCode";
			this.txtItemCode.PreventEnterBeep = true;
			this.txtItemCode.Size = new global::System.Drawing.Size(483, 21);
			this.txtItemCode.TabIndex = 3;
			this.txtPara.Border.Class = "TextBoxBorder";
			this.txtPara.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtPara.Location = new global::System.Drawing.Point(249, 4);
			this.txtPara.Margin = new global::System.Windows.Forms.Padding(0);
			this.txtPara.Name = "txtPara";
			this.txtPara.PreventEnterBeep = true;
			this.txtPara.Size = new global::System.Drawing.Size(111, 21);
			this.txtPara.TabIndex = 1;
			this.txtItemDesc.Border.Class = "TextBoxBorder";
			this.txtItemDesc.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtItemDesc.Location = new global::System.Drawing.Point(67, 4);
			this.txtItemDesc.Margin = new global::System.Windows.Forms.Padding(0);
			this.txtItemDesc.Name = "txtItemDesc";
			this.txtItemDesc.PreventEnterBeep = true;
			this.txtItemDesc.Size = new global::System.Drawing.Size(111, 21);
			this.txtItemDesc.TabIndex = 0;
			this.cmbDataStyle.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbDataStyle.Location = new global::System.Drawing.Point(67, 62);
			this.cmbDataStyle.Margin = new global::System.Windows.Forms.Padding(0);
			this.cmbDataStyle.Name = "cmbDataStyle";
			this.cmbDataStyle.Size = new global::System.Drawing.Size(111, 20);
			this.cmbDataStyle.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.cmbDataStyle.TabIndex = 4;
			this.cmbWriteR.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbWriteR.Location = new global::System.Drawing.Point(249, 62);
			this.cmbWriteR.Margin = new global::System.Windows.Forms.Padding(0);
			this.cmbWriteR.Name = "cmbWriteR";
			this.cmbWriteR.Size = new global::System.Drawing.Size(111, 20);
			this.cmbWriteR.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.cmbWriteR.TabIndex = 5;
			this.txtLinkAddr.Border.Class = "TextBoxBorder";
			this.txtLinkAddr.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtLinkAddr.Location = new global::System.Drawing.Point(431, 62);
			this.txtLinkAddr.Margin = new global::System.Windows.Forms.Padding(0);
			this.txtLinkAddr.Name = "txtLinkAddr";
			this.txtLinkAddr.PreventEnterBeep = true;
			this.txtLinkAddr.Size = new global::System.Drawing.Size(119, 21);
			this.txtLinkAddr.TabIndex = 6;
			this.layoutControlItem2.Control = this.txtItemDesc;
			this.layoutControlItem2.Height = 29;
			this.layoutControlItem2.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem2.Name = "layoutControlItem2";
			this.layoutControlItem2.Text = "PointName";
			this.layoutControlItem2.Width = 33;
			this.layoutControlItem2.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.lciName.Control = this.txtPara;
			this.lciName.Height = 29;
			this.lciName.MinSize = new global::System.Drawing.Size(120, 0);
			this.lciName.Name = "lciName";
			this.lciName.Text = "Parameter";
			this.lciName.Width = 33;
			this.lciName.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem9.Control = this.iInputLuHao;
			this.layoutControlItem9.Height = 29;
			this.layoutControlItem9.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem9.Name = "layoutControlItem9";
			this.layoutControlItem9.Text = "Branch";
			this.layoutControlItem9.Width = 34;
			this.layoutControlItem9.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layPointCode.Control = this.txtItemCode;
			this.layPointCode.Height = 29;
			this.layPointCode.MinSize = new global::System.Drawing.Size(120, 0);
			this.layPointCode.Name = "layPointCode";
			this.layPointCode.Text = "PointCode";
			this.layPointCode.Width = 100;
			this.layPointCode.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem4.Control = this.cmbDataStyle;
			this.layoutControlItem4.Height = 28;
			this.layoutControlItem4.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem4.Name = "layoutControlItem4";
			this.layoutControlItem4.Text = "PointType";
			this.layoutControlItem4.Width = 33;
			this.layoutControlItem4.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem6.Control = this.cmbWriteR;
			this.layoutControlItem6.Height = 28;
			this.layoutControlItem6.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem6.Name = "layoutControlItem6";
			this.layoutControlItem6.Text = "RW";
			this.layoutControlItem6.Width = 33;
			this.layoutControlItem6.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem8.Control = this.txtLinkAddr;
			this.layoutControlItem8.Height = 29;
			this.layoutControlItem8.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem8.Name = "layoutControlItem8";
			this.layoutControlItem8.Text = "Addr";
			this.layoutControlItem8.Width = 34;
			this.layoutControlItem8.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.lciRemark.Control = this.rtxtRemark;
			this.lciRemark.Height = 100;
			this.lciRemark.HeightType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.lciRemark.MinSize = new global::System.Drawing.Size(120, 0);
			this.lciRemark.Name = "lciRemark";
			this.lciRemark.Text = "Remark";
			this.lciRemark.TextPosition = global::DevComponents.DotNetBar.Layout.eLayoutPosition.Top;
			this.lciRemark.Width = 100;
			this.lciRemark.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem1.Control = this.txtItemDesc;
			this.layoutControlItem1.Height = 26;
			this.layoutControlItem1.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Text = "编码";
			this.layoutControlItem1.Width = 33;
			this.layoutControlItem1.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem3.Control = this.cmbDataStyle;
			this.layoutControlItem3.Height = 26;
			this.layoutControlItem3.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem3.Name = "layoutControlItem3";
			this.layoutControlItem3.Text = "路号";
			this.layoutControlItem3.Width = 33;
			this.layoutControlItem3.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem5.Control = this.cmbWriteR;
			this.layoutControlItem5.Height = 28;
			this.layoutControlItem5.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem5.Name = "layoutControlItem5";
			this.layoutControlItem5.Text = "类型";
			this.layoutControlItem5.Width = 33;
			this.layoutControlItem5.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem7.Control = this.txtLinkAddr;
			this.layoutControlItem7.Height = 26;
			this.layoutControlItem7.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem7.Name = "layoutControlItem7";
			this.layoutControlItem7.Text = "参数";
			this.layoutControlItem7.Width = 33;
			this.layoutControlItem7.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			base.ClientSize = new global::System.Drawing.Size(554, 226);
			base.Controls.Add(this.lcMain);
			base.Controls.Add(this.menuBar);
			base.Name = "frmItemDevEdit";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "frmItemDevEdit";
			base.Load += new global::System.EventHandler(this.frmItemDevEdit_Load);
			((global::System.ComponentModel.ISupportInitialize)this.menuBar).EndInit();
			this.lcMain.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.iInputLuHao).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000C0D RID: 3085
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000C0E RID: 3086
		private global::DevComponents.DotNetBar.Bar menuBar;

		// Token: 0x04000C0F RID: 3087
		private global::DevComponents.DotNetBar.ButtonItem btnSave;

		// Token: 0x04000C10 RID: 3088
		private global::DevComponents.DotNetBar.Layout.LayoutControl lcMain;

		// Token: 0x04000C11 RID: 3089
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtItemCode;

		// Token: 0x04000C12 RID: 3090
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtPara;

		// Token: 0x04000C13 RID: 3091
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layPointCode;

		// Token: 0x04000C14 RID: 3092
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem lciName;

		// Token: 0x04000C15 RID: 3093
		private global::DevComponents.DotNetBar.Controls.TextBoxX rtxtRemark;

		// Token: 0x04000C16 RID: 3094
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem lciRemark;

		// Token: 0x04000C17 RID: 3095
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtItemDesc;

		// Token: 0x04000C18 RID: 3096
		private global::DevComponents.DotNetBar.Controls.ComboBoxEx cmbDataStyle;

		// Token: 0x04000C19 RID: 3097
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem2;

		// Token: 0x04000C1A RID: 3098
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem4;

		// Token: 0x04000C1B RID: 3099
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem1;

		// Token: 0x04000C1C RID: 3100
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem3;

		// Token: 0x04000C1D RID: 3101
		private global::DevComponents.DotNetBar.Controls.ComboBoxEx cmbWriteR;

		// Token: 0x04000C1E RID: 3102
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem6;

		// Token: 0x04000C1F RID: 3103
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem5;

		// Token: 0x04000C20 RID: 3104
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtLinkAddr;

		// Token: 0x04000C21 RID: 3105
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem8;

		// Token: 0x04000C22 RID: 3106
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem7;

		// Token: 0x04000C23 RID: 3107
		private global::DevComponents.Editors.IntegerInput iInputLuHao;

		// Token: 0x04000C24 RID: 3108
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem9;
	}
}
