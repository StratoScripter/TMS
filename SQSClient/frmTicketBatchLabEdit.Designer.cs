namespace SQSClient
{
	// Token: 0x0200006A RID: 106
	public partial class frmTicketBatchLabEdit : global::SQSClient.BaseDialogForm
	{
		// Token: 0x06000560 RID: 1376 RVA: 0x00088418 File Offset: 0x00086618
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000561 RID: 1377 RVA: 0x00088450 File Offset: 0x00086650
		private void InitializeComponent()
		{
			this.menuBar = new global::DevComponents.DotNetBar.Bar();
			this.btnSave = new global::DevComponents.DotNetBar.ButtonItem();
			this.btnCapture = new global::DevComponents.DotNetBar.ButtonItem();
			this.layoutControl1 = new global::DevComponents.DotNetBar.Layout.LayoutControl();
			this.rtxtRemark = new global::DevComponents.DotNetBar.Controls.RichTextBoxEx();
			this.txtProduct = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.txtDanHao = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.cmbBatchLabResult = new global::DevComponents.DotNetBar.Controls.ComboBoxEx();
			this.layoutControlItem2 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem3 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem4 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem1 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.txtBatchCode = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.layoutControlItem5 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
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
			this.layoutControl1.Controls.Add(this.rtxtRemark);
			this.layoutControl1.Controls.Add(this.txtProduct);
			this.layoutControl1.Controls.Add(this.txtDanHao);
			this.layoutControl1.Controls.Add(this.cmbBatchLabResult);
			this.layoutControl1.Controls.Add(this.txtBatchCode);
			this.layoutControl1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.layoutControl1.Location = new global::System.Drawing.Point(0, 26);
			this.layoutControl1.Name = "layoutControl1";
			this.layoutControl1.RootGroup.Items.AddRange(new global::DevComponents.DotNetBar.Layout.LayoutItemBase[]
			{
				this.layoutControlItem2,
				this.layoutControlItem5,
				this.layoutControlItem3,
				this.layoutControlItem4,
				this.layoutControlItem1
			});
			this.layoutControl1.Size = new global::System.Drawing.Size(354, 378);
			this.layoutControl1.TabIndex = 23;
			this.rtxtRemark.BackgroundStyle.Class = "RichTextBoxBorder";
			this.rtxtRemark.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.rtxtRemark.Enabled = false;
			this.rtxtRemark.Location = new global::System.Drawing.Point(67, 91);
			this.rtxtRemark.Margin = new global::System.Windows.Forms.Padding(0);
			this.rtxtRemark.Name = "rtxtRemark";
			this.rtxtRemark.Rtf = "{\\rtf1\\ansi\\ansicpg936\\deff0\\nouicompat\\deflang1033\\deflangfe2052{\\fonttbl{\\f0\\fnil\\fcharset134 \\'cb\\'ce\\'cc\\'e5;}}\r\n{\\*\\generator Riched20 10.0.18362}\\viewkind4\\uc1 \r\n\\pard\\f0\\fs18\\lang2052\\par\r\n}\r\n";
			this.rtxtRemark.Size = new global::System.Drawing.Size(283, 56);
			this.rtxtRemark.TabIndex = 3;
			this.txtProduct.Border.Class = "TextBoxBorder";
			this.txtProduct.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtProduct.Enabled = false;
			this.txtProduct.Location = new global::System.Drawing.Point(67, 62);
			this.txtProduct.Margin = new global::System.Windows.Forms.Padding(0);
			this.txtProduct.Name = "txtProduct";
			this.txtProduct.PreventEnterBeep = true;
			this.txtProduct.Size = new global::System.Drawing.Size(283, 21);
			this.txtProduct.TabIndex = 2;
			this.txtDanHao.Border.Class = "TextBoxBorder";
			this.txtDanHao.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtDanHao.Enabled = false;
			this.txtDanHao.Location = new global::System.Drawing.Point(67, 4);
			this.txtDanHao.Margin = new global::System.Windows.Forms.Padding(0);
			this.txtDanHao.Name = "txtDanHao";
			this.txtDanHao.PreventEnterBeep = true;
			this.txtDanHao.Size = new global::System.Drawing.Size(283, 21);
			this.txtDanHao.TabIndex = 0;
			this.cmbBatchLabResult.DisplayMember = "Text";
			this.cmbBatchLabResult.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cmbBatchLabResult.FormattingEnabled = true;
			this.cmbBatchLabResult.ItemHeight = 15;
			this.cmbBatchLabResult.Location = new global::System.Drawing.Point(67, 155);
			this.cmbBatchLabResult.Margin = new global::System.Windows.Forms.Padding(0);
			this.cmbBatchLabResult.Name = "cmbBatchLabResult";
			this.cmbBatchLabResult.Size = new global::System.Drawing.Size(283, 21);
			this.cmbBatchLabResult.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.cmbBatchLabResult.TabIndex = 4;
			this.layoutControlItem2.Control = this.txtDanHao;
			this.layoutControlItem2.Height = 29;
			this.layoutControlItem2.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem2.Name = "layoutControlItem2";
			this.layoutControlItem2.Text = "DanHao";
			this.layoutControlItem2.Width = 100;
			this.layoutControlItem2.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem3.Control = this.txtProduct;
			this.layoutControlItem3.Height = 29;
			this.layoutControlItem3.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem3.Name = "layoutControlItem3";
			this.layoutControlItem3.Text = "Product";
			this.layoutControlItem3.Width = 100;
			this.layoutControlItem3.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem4.Control = this.rtxtRemark;
			this.layoutControlItem4.Height = 64;
			this.layoutControlItem4.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem4.Name = "layoutControlItem4";
			this.layoutControlItem4.Text = "Remark";
			this.layoutControlItem4.Width = 100;
			this.layoutControlItem4.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem1.Control = this.cmbBatchLabResult;
			this.layoutControlItem1.Height = 29;
			this.layoutControlItem1.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Text = "LabResult";
			this.layoutControlItem1.Width = 100;
			this.layoutControlItem1.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.txtBatchCode.Border.Class = "TextBoxBorder";
			this.txtBatchCode.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtBatchCode.Enabled = false;
			this.txtBatchCode.Location = new global::System.Drawing.Point(67, 33);
			this.txtBatchCode.Margin = new global::System.Windows.Forms.Padding(0);
			this.txtBatchCode.Name = "txtBatchCode";
			this.txtBatchCode.PreventEnterBeep = true;
			this.txtBatchCode.Size = new global::System.Drawing.Size(283, 21);
			this.txtBatchCode.TabIndex = 1;
			this.layoutControlItem5.Control = this.txtBatchCode;
			this.layoutControlItem5.Height = 29;
			this.layoutControlItem5.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem5.Name = "layoutControlItem5";
			this.layoutControlItem5.Text = "BatchCode";
			this.layoutControlItem5.Width = 100;
			this.layoutControlItem5.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			base.ClientSize = new global::System.Drawing.Size(354, 404);
			base.Controls.Add(this.layoutControl1);
			base.Controls.Add(this.menuBar);
			base.Name = "frmTicketBatchLabEdit";
			this.Text = "frmTicketBatchLabEdit";
			base.Load += new global::System.EventHandler(this.frmTicketBatchLabEdit_Load);
			((global::System.ComponentModel.ISupportInitialize)this.menuBar).EndInit();
			this.layoutControl1.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x04000964 RID: 2404
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000965 RID: 2405
		private global::DevComponents.DotNetBar.Bar menuBar;

		// Token: 0x04000966 RID: 2406
		private global::DevComponents.DotNetBar.ButtonItem btnSave;

		// Token: 0x04000967 RID: 2407
		private global::DevComponents.DotNetBar.Layout.LayoutControl layoutControl1;

		// Token: 0x04000968 RID: 2408
		private global::DevComponents.DotNetBar.Controls.ComboBoxEx cmbBatchLabResult;

		// Token: 0x04000969 RID: 2409
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem1;

		// Token: 0x0400096A RID: 2410
		private global::DevComponents.DotNetBar.ButtonItem btnCapture;

		// Token: 0x0400096B RID: 2411
		private global::DevComponents.DotNetBar.Controls.RichTextBoxEx rtxtRemark;

		// Token: 0x0400096C RID: 2412
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtProduct;

		// Token: 0x0400096D RID: 2413
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtDanHao;

		// Token: 0x0400096E RID: 2414
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem2;

		// Token: 0x0400096F RID: 2415
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem3;

		// Token: 0x04000970 RID: 2416
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem4;

		// Token: 0x04000971 RID: 2417
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtBatchCode;

		// Token: 0x04000972 RID: 2418
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem5;
	}
}
