namespace SQSClient
{
	// Token: 0x02000025 RID: 37
	public partial class frmLabEdit : global::SQSClient.BaseDialogForm
	{
		// Token: 0x060001D9 RID: 473 RVA: 0x00036CA0 File Offset: 0x00034EA0
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060001DA RID: 474 RVA: 0x00036CD8 File Offset: 0x00034ED8
		private void InitializeComponent()
		{
			this.menuBar = new global::DevComponents.DotNetBar.Bar();
			this.btnSave = new global::DevComponents.DotNetBar.ButtonItem();
			this.btnCapture = new global::DevComponents.DotNetBar.ButtonItem();
			this.btnUpload = new global::DevComponents.DotNetBar.ButtonItem();
			this.layoutControl1 = new global::DevComponents.DotNetBar.Layout.LayoutControl();
			this.labDanWei = new global::DevComponents.DotNetBar.LabelX();
			this.labelX1 = new global::DevComponents.DotNetBar.LabelX();
			this.txtJieSuanLiang = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.txtDifferWeight = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.txtCheNum = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.txtBusinessType = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.rtxtRemark = new global::DevComponents.DotNetBar.Controls.RichTextBoxEx();
			this.txtProduct = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.txtDanHao = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.cmbLabResult = new global::DevComponents.DotNetBar.Controls.ComboBoxEx();
			this.layoutControlItem2 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem5 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem3 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem6 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem7 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem9 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem8 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem10 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem4 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem1 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			((global::System.ComponentModel.ISupportInitialize)this.menuBar).BeginInit();
			this.layoutControl1.SuspendLayout();
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
				this.btnCapture,
				this.btnUpload
			});
			this.menuBar.Location = new global::System.Drawing.Point(0, 0);
			this.menuBar.MenuBar = true;
			this.menuBar.Name = "menuBar";
			this.menuBar.Size = new global::System.Drawing.Size(448, 26);
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
			this.btnUpload.Name = "btnUpload";
			this.btnUpload.Text = "Upload";
			this.btnUpload.Click += new global::System.EventHandler(this.btnUpload_Click);
			this.layoutControl1.Controls.Add(this.labDanWei);
			this.layoutControl1.Controls.Add(this.labelX1);
			this.layoutControl1.Controls.Add(this.txtJieSuanLiang);
			this.layoutControl1.Controls.Add(this.txtDifferWeight);
			this.layoutControl1.Controls.Add(this.txtCheNum);
			this.layoutControl1.Controls.Add(this.txtBusinessType);
			this.layoutControl1.Controls.Add(this.rtxtRemark);
			this.layoutControl1.Controls.Add(this.txtProduct);
			this.layoutControl1.Controls.Add(this.txtDanHao);
			this.layoutControl1.Controls.Add(this.cmbLabResult);
			this.layoutControl1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.layoutControl1.Location = new global::System.Drawing.Point(0, 26);
			this.layoutControl1.Name = "layoutControl1";
			this.layoutControl1.RootGroup.Items.AddRange(new global::DevComponents.DotNetBar.Layout.LayoutItemBase[]
			{
				this.layoutControlItem2,
				this.layoutControlItem5,
				this.layoutControlItem3,
				this.layoutControlItem6,
				this.layoutControlItem7,
				this.layoutControlItem9,
				this.layoutControlItem8,
				this.layoutControlItem10,
				this.layoutControlItem4,
				this.layoutControlItem1
			});
			this.layoutControl1.Size = new global::System.Drawing.Size(448, 378);
			this.layoutControl1.TabIndex = 23;
			this.labDanWei.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.labDanWei.Location = new global::System.Drawing.Point(407, 151);
			this.labDanWei.Margin = new global::System.Windows.Forms.Padding(0);
			this.labDanWei.Name = "labDanWei";
			this.labDanWei.Size = new global::System.Drawing.Size(37, 23);
			this.labDanWei.TabIndex = 7;
			this.labDanWei.Text = "bbl";
			this.labelX1.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.labelX1.Location = new global::System.Drawing.Point(407, 120);
			this.labelX1.Margin = new global::System.Windows.Forms.Padding(0);
			this.labelX1.Name = "labelX1";
			this.labelX1.Size = new global::System.Drawing.Size(37, 23);
			this.labelX1.TabIndex = 5;
			this.labelX1.Text = "kg";
			this.txtJieSuanLiang.Border.Class = "TextBoxBorder";
			this.txtJieSuanLiang.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtJieSuanLiang.Enabled = false;
			this.txtJieSuanLiang.Location = new global::System.Drawing.Point(86, 151);
			this.txtJieSuanLiang.Margin = new global::System.Windows.Forms.Padding(0);
			this.txtJieSuanLiang.Name = "txtJieSuanLiang";
			this.txtJieSuanLiang.PreventEnterBeep = true;
			this.txtJieSuanLiang.Size = new global::System.Drawing.Size(313, 21);
			this.txtJieSuanLiang.TabIndex = 6;
			this.txtDifferWeight.Border.Class = "TextBoxBorder";
			this.txtDifferWeight.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtDifferWeight.Enabled = false;
			this.txtDifferWeight.Location = new global::System.Drawing.Point(86, 120);
			this.txtDifferWeight.Margin = new global::System.Windows.Forms.Padding(0);
			this.txtDifferWeight.Name = "txtDifferWeight";
			this.txtDifferWeight.PreventEnterBeep = true;
			this.txtDifferWeight.Size = new global::System.Drawing.Size(313, 21);
			this.txtDifferWeight.TabIndex = 4;
			this.txtCheNum.Border.Class = "TextBoxBorder";
			this.txtCheNum.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtCheNum.Enabled = false;
			this.txtCheNum.Location = new global::System.Drawing.Point(86, 91);
			this.txtCheNum.Margin = new global::System.Windows.Forms.Padding(0);
			this.txtCheNum.Name = "txtCheNum";
			this.txtCheNum.PreventEnterBeep = true;
			this.txtCheNum.Size = new global::System.Drawing.Size(358, 21);
			this.txtCheNum.TabIndex = 3;
			this.txtBusinessType.Border.Class = "TextBoxBorder";
			this.txtBusinessType.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtBusinessType.Enabled = false;
			this.txtBusinessType.Location = new global::System.Drawing.Point(86, 33);
			this.txtBusinessType.Margin = new global::System.Windows.Forms.Padding(0);
			this.txtBusinessType.Name = "txtBusinessType";
			this.txtBusinessType.PreventEnterBeep = true;
			this.txtBusinessType.Size = new global::System.Drawing.Size(358, 21);
			this.txtBusinessType.TabIndex = 1;
			this.rtxtRemark.BackgroundStyle.Class = "RichTextBoxBorder";
			this.rtxtRemark.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.rtxtRemark.Location = new global::System.Drawing.Point(86, 182);
			this.rtxtRemark.Margin = new global::System.Windows.Forms.Padding(0);
			this.rtxtRemark.Name = "rtxtRemark";
			this.rtxtRemark.Rtf = "{\\rtf1\\ansi\\ansicpg936\\deff0\\nouicompat\\deflang1033\\deflangfe2052{\\fonttbl{\\f0\\fnil\\fcharset134 \\'cb\\'ce\\'cc\\'e5;}}\r\n{\\*\\generator Riched20 10.0.18362}\\viewkind4\\uc1 \r\n\\pard\\f0\\fs18\\lang2052\\par\r\n}\r\n";
			this.rtxtRemark.Size = new global::System.Drawing.Size(358, 56);
			this.rtxtRemark.TabIndex = 8;
			this.txtProduct.Border.Class = "TextBoxBorder";
			this.txtProduct.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtProduct.Enabled = false;
			this.txtProduct.Location = new global::System.Drawing.Point(86, 62);
			this.txtProduct.Margin = new global::System.Windows.Forms.Padding(0);
			this.txtProduct.Name = "txtProduct";
			this.txtProduct.PreventEnterBeep = true;
			this.txtProduct.Size = new global::System.Drawing.Size(358, 21);
			this.txtProduct.TabIndex = 2;
			this.txtDanHao.Border.Class = "TextBoxBorder";
			this.txtDanHao.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtDanHao.Enabled = false;
			this.txtDanHao.Location = new global::System.Drawing.Point(86, 4);
			this.txtDanHao.Margin = new global::System.Windows.Forms.Padding(0);
			this.txtDanHao.Name = "txtDanHao";
			this.txtDanHao.PreventEnterBeep = true;
			this.txtDanHao.Size = new global::System.Drawing.Size(358, 21);
			this.txtDanHao.TabIndex = 0;
			this.cmbLabResult.DisplayMember = "Text";
			this.cmbLabResult.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cmbLabResult.FormattingEnabled = true;
			this.cmbLabResult.ItemHeight = 15;
			this.cmbLabResult.Location = new global::System.Drawing.Point(86, 246);
			this.cmbLabResult.Margin = new global::System.Windows.Forms.Padding(0);
			this.cmbLabResult.Name = "cmbLabResult";
			this.cmbLabResult.Size = new global::System.Drawing.Size(358, 21);
			this.cmbLabResult.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.cmbLabResult.TabIndex = 9;
			this.layoutControlItem2.Control = this.txtDanHao;
			this.layoutControlItem2.Height = 29;
			this.layoutControlItem2.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem2.Name = "layoutControlItem2";
			this.layoutControlItem2.Text = "DanHao";
			this.layoutControlItem2.Width = 100;
			this.layoutControlItem2.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem5.Control = this.txtBusinessType;
			this.layoutControlItem5.Height = 29;
			this.layoutControlItem5.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem5.Name = "layoutControlItem5";
			this.layoutControlItem5.Text = "BusinessType";
			this.layoutControlItem5.Width = 100;
			this.layoutControlItem5.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem3.Control = this.txtProduct;
			this.layoutControlItem3.Height = 29;
			this.layoutControlItem3.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem3.Name = "layoutControlItem3";
			this.layoutControlItem3.Text = "Product";
			this.layoutControlItem3.Width = 100;
			this.layoutControlItem3.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem6.Control = this.txtCheNum;
			this.layoutControlItem6.Height = 29;
			this.layoutControlItem6.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem6.Name = "layoutControlItem6";
			this.layoutControlItem6.Text = "CheNum";
			this.layoutControlItem6.Width = 100;
			this.layoutControlItem6.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem7.Control = this.txtDifferWeight;
			this.layoutControlItem7.Height = 29;
			this.layoutControlItem7.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem7.Name = "layoutControlItem7";
			this.layoutControlItem7.Text = "DifferWeight";
			this.layoutControlItem7.Width = 90;
			this.layoutControlItem7.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem9.Control = this.labelX1;
			this.layoutControlItem9.Height = 31;
			this.layoutControlItem9.MinSize = new global::System.Drawing.Size(20, 18);
			this.layoutControlItem9.Name = "layoutControlItem9";
			this.layoutControlItem9.Width = 10;
			this.layoutControlItem9.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem8.Control = this.txtJieSuanLiang;
			this.layoutControlItem8.Height = 29;
			this.layoutControlItem8.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem8.Name = "layoutControlItem8";
			this.layoutControlItem8.Text = "JieSuanLiang";
			this.layoutControlItem8.Width = 90;
			this.layoutControlItem8.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem10.Control = this.labDanWei;
			this.layoutControlItem10.Height = 31;
			this.layoutControlItem10.MinSize = new global::System.Drawing.Size(20, 18);
			this.layoutControlItem10.Name = "layoutControlItem10";
			this.layoutControlItem10.Width = 10;
			this.layoutControlItem10.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem4.Control = this.rtxtRemark;
			this.layoutControlItem4.Height = 64;
			this.layoutControlItem4.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem4.Name = "layoutControlItem4";
			this.layoutControlItem4.Text = "Remark";
			this.layoutControlItem4.Width = 100;
			this.layoutControlItem4.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem1.Control = this.cmbLabResult;
			this.layoutControlItem1.Height = 29;
			this.layoutControlItem1.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Text = "LabResult";
			this.layoutControlItem1.Width = 100;
			this.layoutControlItem1.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			base.ClientSize = new global::System.Drawing.Size(448, 404);
			base.Controls.Add(this.layoutControl1);
			base.Controls.Add(this.menuBar);
			base.Name = "frmLabEdit";
			this.Text = "frmLabEdit";
			base.Load += new global::System.EventHandler(this.frmLabEdit_Load);
			((global::System.ComponentModel.ISupportInitialize)this.menuBar).EndInit();
			this.layoutControl1.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x04000347 RID: 839
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000348 RID: 840
		private global::DevComponents.DotNetBar.Bar menuBar;

		// Token: 0x04000349 RID: 841
		private global::DevComponents.DotNetBar.ButtonItem btnSave;

		// Token: 0x0400034A RID: 842
		private global::DevComponents.DotNetBar.Layout.LayoutControl layoutControl1;

		// Token: 0x0400034B RID: 843
		private global::DevComponents.DotNetBar.Controls.ComboBoxEx cmbLabResult;

		// Token: 0x0400034C RID: 844
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem1;

		// Token: 0x0400034D RID: 845
		private global::DevComponents.DotNetBar.ButtonItem btnCapture;

		// Token: 0x0400034E RID: 846
		private global::DevComponents.DotNetBar.Controls.RichTextBoxEx rtxtRemark;

		// Token: 0x0400034F RID: 847
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtProduct;

		// Token: 0x04000350 RID: 848
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtDanHao;

		// Token: 0x04000351 RID: 849
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem2;

		// Token: 0x04000352 RID: 850
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem3;

		// Token: 0x04000353 RID: 851
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem4;

		// Token: 0x04000354 RID: 852
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtBusinessType;

		// Token: 0x04000355 RID: 853
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem5;

		// Token: 0x04000356 RID: 854
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtCheNum;

		// Token: 0x04000357 RID: 855
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem6;

		// Token: 0x04000358 RID: 856
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtJieSuanLiang;

		// Token: 0x04000359 RID: 857
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtDifferWeight;

		// Token: 0x0400035A RID: 858
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem7;

		// Token: 0x0400035B RID: 859
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem8;

		// Token: 0x0400035C RID: 860
		private global::DevComponents.DotNetBar.LabelX labDanWei;

		// Token: 0x0400035D RID: 861
		private global::DevComponents.DotNetBar.LabelX labelX1;

		// Token: 0x0400035E RID: 862
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem9;

		// Token: 0x0400035F RID: 863
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem10;

		// Token: 0x04000360 RID: 864
		private global::DevComponents.DotNetBar.ButtonItem btnUpload;
	}
}
