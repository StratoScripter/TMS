namespace SQSClient
{
	// Token: 0x02000068 RID: 104
	public partial class frmQRCodeShow : global::SQSClient.BaseDialogForm
	{
		// Token: 0x06000543 RID: 1347 RVA: 0x00084A9C File Offset: 0x00082C9C
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000544 RID: 1348 RVA: 0x00084AD4 File Offset: 0x00082CD4
		private void InitializeComponent()
		{
			this.picMatrix = new global::System.Windows.Forms.PictureBox();
			this.tbxContextParse = new global::System.Windows.Forms.TextBox();
			this.btnQRCode = new global::System.Windows.Forms.Button();
			this.lblVersion = new global::System.Windows.Forms.Label();
			this.dInputVersion = new global::DevComponents.Editors.DoubleInput();
			this.lblPixel = new global::System.Windows.Forms.Label();
			this.dInputPixel = new global::DevComponents.Editors.DoubleInput();
			this.lblBorder = new global::System.Windows.Forms.Label();
			this.dInputBorder = new global::DevComponents.Editors.DoubleInput();
			this.lblSize = new global::System.Windows.Forms.Label();
			this.dInputSize = new global::DevComponents.Editors.DoubleInput();
			this.btnPrint = new global::System.Windows.Forms.Button();
			this.picDrawBit = new global::System.Windows.Forms.PictureBox();
			this.btnDrawBit = new global::System.Windows.Forms.Button();
			this.tbxDrawBit = new global::System.Windows.Forms.TextBox();
			this.btnZebraPrint = new global::System.Windows.Forms.Button();
			((global::System.ComponentModel.ISupportInitialize)this.picMatrix).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.dInputVersion).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.dInputPixel).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.dInputBorder).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.dInputSize).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.picDrawBit).BeginInit();
			base.SuspendLayout();
			this.picMatrix.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.picMatrix.Location = new global::System.Drawing.Point(64, 12);
			this.picMatrix.Name = "picMatrix";
			this.picMatrix.Size = new global::System.Drawing.Size(264, 264);
			this.picMatrix.TabIndex = 14;
			this.picMatrix.TabStop = false;
			this.tbxContextParse.Location = new global::System.Drawing.Point(64, 282);
			this.tbxContextParse.Multiline = true;
			this.tbxContextParse.Name = "tbxContextParse";
			this.tbxContextParse.Size = new global::System.Drawing.Size(264, 46);
			this.tbxContextParse.TabIndex = 18;
			this.btnQRCode.Location = new global::System.Drawing.Point(95, 404);
			this.btnQRCode.Name = "btnQRCode";
			this.btnQRCode.Size = new global::System.Drawing.Size(75, 23);
			this.btnQRCode.TabIndex = 19;
			this.btnQRCode.Text = "QRCode";
			this.btnQRCode.UseVisualStyleBackColor = true;
			this.btnQRCode.Click += new global::System.EventHandler(this.btnQRCode_Click);
			this.lblVersion.AutoSize = true;
			this.lblVersion.Location = new global::System.Drawing.Point(62, 343);
			this.lblVersion.Name = "lblVersion";
			this.lblVersion.Size = new global::System.Drawing.Size(29, 12);
			this.lblVersion.TabIndex = 21;
			this.lblVersion.Text = "版本";
			this.dInputVersion.BackgroundStyle.Class = "DateTimeInputBackground";
			this.dInputVersion.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.dInputVersion.ButtonFreeText.Shortcut = global::DevComponents.DotNetBar.eShortcut.F2;
			this.dInputVersion.DisplayFormat = "0.0";
			this.dInputVersion.Increment = 0.0;
			this.dInputVersion.InputHorizontalAlignment = global::DevComponents.Editors.eHorizontalAlignment.Left;
			this.dInputVersion.Location = new global::System.Drawing.Point(98, 339);
			this.dInputVersion.MaxValue = 100.0;
			this.dInputVersion.MinValue = 0.0;
			this.dInputVersion.Name = "dInputVersion";
			this.dInputVersion.ShowUpDown = true;
			this.dInputVersion.Size = new global::System.Drawing.Size(72, 21);
			this.dInputVersion.TabIndex = 20;
			this.lblPixel.AutoSize = true;
			this.lblPixel.Location = new global::System.Drawing.Point(220, 343);
			this.lblPixel.Name = "lblPixel";
			this.lblPixel.Size = new global::System.Drawing.Size(29, 12);
			this.lblPixel.TabIndex = 23;
			this.lblPixel.Text = "像素";
			this.dInputPixel.BackgroundStyle.Class = "DateTimeInputBackground";
			this.dInputPixel.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.dInputPixel.ButtonFreeText.Shortcut = global::DevComponents.DotNetBar.eShortcut.F2;
			this.dInputPixel.DisplayFormat = "0.0";
			this.dInputPixel.Increment = 0.0;
			this.dInputPixel.InputHorizontalAlignment = global::DevComponents.Editors.eHorizontalAlignment.Left;
			this.dInputPixel.Location = new global::System.Drawing.Point(256, 339);
			this.dInputPixel.MaxValue = 100.0;
			this.dInputPixel.MinValue = 0.0;
			this.dInputPixel.Name = "dInputPixel";
			this.dInputPixel.ShowUpDown = true;
			this.dInputPixel.Size = new global::System.Drawing.Size(72, 21);
			this.dInputPixel.TabIndex = 22;
			this.lblBorder.AutoSize = true;
			this.lblBorder.Location = new global::System.Drawing.Point(221, 374);
			this.lblBorder.Name = "lblBorder";
			this.lblBorder.Size = new global::System.Drawing.Size(29, 12);
			this.lblBorder.TabIndex = 27;
			this.lblBorder.Text = "边线";
			this.dInputBorder.BackgroundStyle.Class = "DateTimeInputBackground";
			this.dInputBorder.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.dInputBorder.ButtonFreeText.Shortcut = global::DevComponents.DotNetBar.eShortcut.F2;
			this.dInputBorder.DisplayFormat = "0.0";
			this.dInputBorder.Increment = 0.0;
			this.dInputBorder.InputHorizontalAlignment = global::DevComponents.Editors.eHorizontalAlignment.Left;
			this.dInputBorder.Location = new global::System.Drawing.Point(257, 370);
			this.dInputBorder.MaxValue = 100.0;
			this.dInputBorder.MinValue = 0.0;
			this.dInputBorder.Name = "dInputBorder";
			this.dInputBorder.ShowUpDown = true;
			this.dInputBorder.Size = new global::System.Drawing.Size(72, 21);
			this.dInputBorder.TabIndex = 26;
			this.lblSize.AutoSize = true;
			this.lblSize.Location = new global::System.Drawing.Point(63, 374);
			this.lblSize.Name = "lblSize";
			this.lblSize.Size = new global::System.Drawing.Size(29, 12);
			this.lblSize.TabIndex = 25;
			this.lblSize.Text = "尺寸";
			this.dInputSize.BackgroundStyle.Class = "DateTimeInputBackground";
			this.dInputSize.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.dInputSize.ButtonFreeText.Shortcut = global::DevComponents.DotNetBar.eShortcut.F2;
			this.dInputSize.DisplayFormat = "0.0";
			this.dInputSize.Increment = 0.0;
			this.dInputSize.InputHorizontalAlignment = global::DevComponents.Editors.eHorizontalAlignment.Left;
			this.dInputSize.Location = new global::System.Drawing.Point(99, 370);
			this.dInputSize.MaxValue = 100.0;
			this.dInputSize.MinValue = 0.0;
			this.dInputSize.Name = "dInputSize";
			this.dInputSize.ShowUpDown = true;
			this.dInputSize.Size = new global::System.Drawing.Size(72, 21);
			this.dInputSize.TabIndex = 24;
			this.btnPrint.Location = new global::System.Drawing.Point(223, 404);
			this.btnPrint.Name = "btnPrint";
			this.btnPrint.Size = new global::System.Drawing.Size(75, 23);
			this.btnPrint.TabIndex = 28;
			this.btnPrint.Text = "QRPrint";
			this.btnPrint.UseVisualStyleBackColor = true;
			this.btnPrint.Click += new global::System.EventHandler(this.btnPrint_Click);
			this.picDrawBit.Location = new global::System.Drawing.Point(387, 12);
			this.picDrawBit.Name = "picDrawBit";
			this.picDrawBit.Size = new global::System.Drawing.Size(427, 299);
			this.picDrawBit.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.picDrawBit.TabIndex = 29;
			this.picDrawBit.TabStop = false;
			this.btnDrawBit.Location = new global::System.Drawing.Point(416, 404);
			this.btnDrawBit.Name = "btnDrawBit";
			this.btnDrawBit.Size = new global::System.Drawing.Size(75, 23);
			this.btnDrawBit.TabIndex = 30;
			this.btnDrawBit.Text = "DrawBit";
			this.btnDrawBit.UseVisualStyleBackColor = true;
			this.btnDrawBit.Click += new global::System.EventHandler(this.btnDrawBit_Click);
			this.tbxDrawBit.Location = new global::System.Drawing.Point(387, 327);
			this.tbxDrawBit.Multiline = true;
			this.tbxDrawBit.Name = "tbxDrawBit";
			this.tbxDrawBit.Size = new global::System.Drawing.Size(427, 64);
			this.tbxDrawBit.TabIndex = 31;
			this.btnZebraPrint.Location = new global::System.Drawing.Point(558, 404);
			this.btnZebraPrint.Name = "btnZebraPrint";
			this.btnZebraPrint.Size = new global::System.Drawing.Size(75, 23);
			this.btnZebraPrint.TabIndex = 32;
			this.btnZebraPrint.Text = "ZebraPrint";
			this.btnZebraPrint.UseVisualStyleBackColor = true;
			this.btnZebraPrint.Click += new global::System.EventHandler(this.btnZebraPrint_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 12f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(838, 431);
			base.Controls.Add(this.btnZebraPrint);
			base.Controls.Add(this.tbxDrawBit);
			base.Controls.Add(this.btnDrawBit);
			base.Controls.Add(this.picDrawBit);
			base.Controls.Add(this.btnPrint);
			base.Controls.Add(this.lblBorder);
			base.Controls.Add(this.dInputBorder);
			base.Controls.Add(this.lblSize);
			base.Controls.Add(this.dInputSize);
			base.Controls.Add(this.lblPixel);
			base.Controls.Add(this.dInputPixel);
			base.Controls.Add(this.lblVersion);
			base.Controls.Add(this.dInputVersion);
			base.Controls.Add(this.btnQRCode);
			base.Controls.Add(this.tbxContextParse);
			base.Controls.Add(this.picMatrix);
			base.Name = "frmQRCodeShow";
			this.Text = "frmQRCodeShow";
			((global::System.ComponentModel.ISupportInitialize)this.picMatrix).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.dInputVersion).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.dInputPixel).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.dInputBorder).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.dInputSize).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.picDrawBit).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000912 RID: 2322
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000913 RID: 2323
		private global::System.Windows.Forms.PictureBox picMatrix;

		// Token: 0x04000914 RID: 2324
		private global::System.Windows.Forms.TextBox tbxContextParse;

		// Token: 0x04000915 RID: 2325
		private global::System.Windows.Forms.Button btnQRCode;

		// Token: 0x04000916 RID: 2326
		private global::System.Windows.Forms.Label lblVersion;

		// Token: 0x04000917 RID: 2327
		private global::DevComponents.Editors.DoubleInput dInputVersion;

		// Token: 0x04000918 RID: 2328
		private global::System.Windows.Forms.Label lblPixel;

		// Token: 0x04000919 RID: 2329
		private global::DevComponents.Editors.DoubleInput dInputPixel;

		// Token: 0x0400091A RID: 2330
		private global::System.Windows.Forms.Label lblBorder;

		// Token: 0x0400091B RID: 2331
		private global::DevComponents.Editors.DoubleInput dInputBorder;

		// Token: 0x0400091C RID: 2332
		private global::System.Windows.Forms.Label lblSize;

		// Token: 0x0400091D RID: 2333
		private global::DevComponents.Editors.DoubleInput dInputSize;

		// Token: 0x0400091E RID: 2334
		private global::System.Windows.Forms.Button btnPrint;

		// Token: 0x0400091F RID: 2335
		private global::System.Windows.Forms.PictureBox picDrawBit;

		// Token: 0x04000920 RID: 2336
		private global::System.Windows.Forms.Button btnDrawBit;

		// Token: 0x04000921 RID: 2337
		private global::System.Windows.Forms.TextBox tbxDrawBit;

		// Token: 0x04000922 RID: 2338
		private global::System.Windows.Forms.Button btnZebraPrint;
	}
}
