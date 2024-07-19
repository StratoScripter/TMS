namespace SQSClient
{
	// Token: 0x0200001E RID: 30
	public partial class frmDocCamView : global::SQSClient.BaseDialogForm
	{
		// Token: 0x06000175 RID: 373 RVA: 0x0002D7C0 File Offset: 0x0002B9C0
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000176 RID: 374 RVA: 0x0002D7F8 File Offset: 0x0002B9F8
		private void InitializeComponent()
		{
			this.btnCapture = new global::DevComponents.DotNetBar.ButtonX();
			this.lblTicket = new global::System.Windows.Forms.Label();
			this.pbxPreview = new global::System.Windows.Forms.PictureBox();
			this.pbReduceImage = new global::System.Windows.Forms.PictureBox();
			this.chkPrintChoise = new global::DevComponents.DotNetBar.Controls.CheckBoxX();
			((global::System.ComponentModel.ISupportInitialize)this.pbxPreview).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pbReduceImage).BeginInit();
			base.SuspendLayout();
			this.btnCapture.AccessibleRole = global::System.Windows.Forms.AccessibleRole.PushButton;
			this.btnCapture.ColorTable = global::DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.btnCapture.Font = new global::System.Drawing.Font("宋体", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 134);
			this.btnCapture.Location = new global::System.Drawing.Point(598, 493);
			this.btnCapture.Name = "btnCapture";
			this.btnCapture.Size = new global::System.Drawing.Size(208, 32);
			this.btnCapture.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.btnCapture.TabIndex = 7;
			this.btnCapture.Text = "Save";
			this.btnCapture.Click += new global::System.EventHandler(this.btnCapture_Click);
			this.lblTicket.AutoSize = true;
			this.lblTicket.Font = new global::System.Drawing.Font("宋体", 15.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 134);
			this.lblTicket.Location = new global::System.Drawing.Point(596, 205);
			this.lblTicket.Name = "lblTicket";
			this.lblTicket.Size = new global::System.Drawing.Size(154, 21);
			this.lblTicket.TabIndex = 1;
			this.lblTicket.Text = "SD-191101553";
			this.lblTicket.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.pbxPreview.BackColor = global::System.Drawing.Color.Black;
			this.pbxPreview.Location = new global::System.Drawing.Point(8, 5);
			this.pbxPreview.Name = "pbxPreview";
			this.pbxPreview.Size = new global::System.Drawing.Size(582, 528);
			this.pbxPreview.TabIndex = 0;
			this.pbxPreview.TabStop = false;
			this.pbReduceImage.Location = new global::System.Drawing.Point(598, 5);
			this.pbReduceImage.Name = "pbReduceImage";
			this.pbReduceImage.Size = new global::System.Drawing.Size(208, 160);
			this.pbReduceImage.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbReduceImage.TabIndex = 10;
			this.pbReduceImage.TabStop = false;
			this.pbReduceImage.Click += new global::System.EventHandler(this.pbReduceImage_Click);
			this.chkPrintChoise.AutoSize = true;
			this.chkPrintChoise.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.chkPrintChoise.Checked = true;
			this.chkPrintChoise.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.chkPrintChoise.CheckValue = "Y";
			this.chkPrintChoise.Font = new global::System.Drawing.Font("宋体", 15.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 134);
			this.chkPrintChoise.Location = new global::System.Drawing.Point(598, 447);
			this.chkPrintChoise.Name = "chkPrintChoise";
			this.chkPrintChoise.Size = new global::System.Drawing.Size(149, 26);
			this.chkPrintChoise.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.chkPrintChoise.TabIndex = 15;
			this.chkPrintChoise.Text = "PrintChoise";
			base.ClientSize = new global::System.Drawing.Size(818, 537);
			base.Controls.Add(this.chkPrintChoise);
			base.Controls.Add(this.pbReduceImage);
			base.Controls.Add(this.btnCapture);
			base.Controls.Add(this.lblTicket);
			base.Controls.Add(this.pbxPreview);
			base.Name = "frmDocCamView";
			this.Text = "Capture";
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.frmDocCamView_FormClosing);
			base.Load += new global::System.EventHandler(this.frmDocCamView_Load);
			((global::System.ComponentModel.ISupportInitialize)this.pbxPreview).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pbReduceImage).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x040002A6 RID: 678
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x040002A7 RID: 679
		private global::System.Windows.Forms.PictureBox pbxPreview;

		// Token: 0x040002A8 RID: 680
		private global::System.Windows.Forms.Label lblTicket;

		// Token: 0x040002A9 RID: 681
		private global::DevComponents.DotNetBar.ButtonX btnCapture;

		// Token: 0x040002AA RID: 682
		private global::System.Windows.Forms.PictureBox pbReduceImage;

		// Token: 0x040002AB RID: 683
		private global::DevComponents.DotNetBar.Controls.CheckBoxX chkPrintChoise;
	}
}
