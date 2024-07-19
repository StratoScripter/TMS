namespace SQSClient
{
	// Token: 0x0200001F RID: 31
	public partial class frmAbout : global::SQSClient.BaseDialogForm
	{
		// Token: 0x0600017B RID: 379 RVA: 0x0002DDD8 File Offset: 0x0002BFD8
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600017C RID: 380 RVA: 0x0002DE10 File Offset: 0x0002C010
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::SQSClient.frmAbout));
			this.labelCompanyName = new global::System.Windows.Forms.LinkLabel();
			this.labelCopyright = new global::System.Windows.Forms.Label();
			this.okButton = new global::System.Windows.Forms.Button();
			this.textBoxDescription = new global::System.Windows.Forms.TextBox();
			this.labelVersion = new global::System.Windows.Forms.Label();
			this.labelProductName = new global::System.Windows.Forms.Label();
			this.logoPictureBox = new global::System.Windows.Forms.PictureBox();
			this.tableLayoutPanel = new global::System.Windows.Forms.TableLayoutPanel();
			((global::System.ComponentModel.ISupportInitialize)this.logoPictureBox).BeginInit();
			this.tableLayoutPanel.SuspendLayout();
			base.SuspendLayout();
			this.labelCompanyName.AutoSize = true;
			this.labelCompanyName.Location = new global::System.Drawing.Point(174, 72);
			this.labelCompanyName.Name = "labelCompanyName";
			this.labelCompanyName.Size = new global::System.Drawing.Size(71, 12);
			this.labelCompanyName.TabIndex = 25;
			this.labelCompanyName.TabStop = true;
			this.labelCompanyName.Tag = "http://www.supcontech.com";
			this.labelCompanyName.Text = "CompanyName";
			this.labelCompanyName.LinkClicked += new global::System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.labelCompanyName_LinkClicked);
			this.labelCopyright.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.labelCopyright.Location = new global::System.Drawing.Point(177, 48);
			this.labelCopyright.Margin = new global::System.Windows.Forms.Padding(6, 0, 3, 0);
			this.labelCopyright.MaximumSize = new global::System.Drawing.Size(0, 16);
			this.labelCopyright.Name = "labelCopyright";
			this.labelCopyright.Size = new global::System.Drawing.Size(340, 16);
			this.labelCopyright.TabIndex = 21;
			this.labelCopyright.Text = "Copyright";
			this.labelCopyright.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.okButton.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.okButton.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.okButton.Location = new global::System.Drawing.Point(442, 222);
			this.okButton.Name = "okButton";
			this.okButton.Size = new global::System.Drawing.Size(75, 21);
			this.okButton.TabIndex = 24;
			this.okButton.Text = "Sure(&O)";
			this.textBoxDescription.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.textBoxDescription.Location = new global::System.Drawing.Point(177, 99);
			this.textBoxDescription.Margin = new global::System.Windows.Forms.Padding(6, 3, 3, 3);
			this.textBoxDescription.Multiline = true;
			this.textBoxDescription.Name = "textBoxDescription";
			this.textBoxDescription.ReadOnly = true;
			this.textBoxDescription.ScrollBars = global::System.Windows.Forms.ScrollBars.Both;
			this.textBoxDescription.Size = new global::System.Drawing.Size(340, 117);
			this.textBoxDescription.TabIndex = 23;
			this.textBoxDescription.TabStop = false;
			this.labelVersion.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.labelVersion.Location = new global::System.Drawing.Point(177, 24);
			this.labelVersion.Margin = new global::System.Windows.Forms.Padding(6, 0, 3, 0);
			this.labelVersion.MaximumSize = new global::System.Drawing.Size(0, 16);
			this.labelVersion.Name = "labelVersion";
			this.labelVersion.Size = new global::System.Drawing.Size(340, 16);
			this.labelVersion.TabIndex = 0;
			this.labelVersion.Text = "Version";
			this.labelVersion.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.labelProductName.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.labelProductName.Location = new global::System.Drawing.Point(177, 0);
			this.labelProductName.Margin = new global::System.Windows.Forms.Padding(6, 0, 3, 0);
			this.labelProductName.MaximumSize = new global::System.Drawing.Size(0, 16);
			this.labelProductName.Name = "labelProductName";
			this.labelProductName.Size = new global::System.Drawing.Size(340, 16);
			this.labelProductName.TabIndex = 19;
			this.labelProductName.Text = "SQSName";
			this.labelProductName.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.logoPictureBox.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.logoPictureBox.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("logoPictureBox.Image");
			this.logoPictureBox.Location = new global::System.Drawing.Point(3, 3);
			this.logoPictureBox.Name = "logoPictureBox";
			this.tableLayoutPanel.SetRowSpan(this.logoPictureBox, 6);
			this.logoPictureBox.Size = new global::System.Drawing.Size(165, 240);
			this.logoPictureBox.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.logoPictureBox.TabIndex = 12;
			this.logoPictureBox.TabStop = false;
			this.tableLayoutPanel.ColumnCount = 2;
			this.tableLayoutPanel.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 33f));
			this.tableLayoutPanel.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 67f));
			this.tableLayoutPanel.Controls.Add(this.logoPictureBox, 0, 0);
			this.tableLayoutPanel.Controls.Add(this.labelProductName, 1, 0);
			this.tableLayoutPanel.Controls.Add(this.labelVersion, 1, 1);
			this.tableLayoutPanel.Controls.Add(this.textBoxDescription, 1, 4);
			this.tableLayoutPanel.Controls.Add(this.okButton, 1, 5);
			this.tableLayoutPanel.Controls.Add(this.labelCopyright, 1, 2);
			this.tableLayoutPanel.Controls.Add(this.labelCompanyName, 1, 3);
			this.tableLayoutPanel.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel.Location = new global::System.Drawing.Point(0, 0);
			this.tableLayoutPanel.Name = "tableLayoutPanel";
			this.tableLayoutPanel.RowCount = 7;
			this.tableLayoutPanel.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 11.11111f));
			this.tableLayoutPanel.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 11.11111f));
			this.tableLayoutPanel.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 11.11111f));
			this.tableLayoutPanel.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 11.11111f));
			this.tableLayoutPanel.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 55.55556f));
			this.tableLayoutPanel.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Absolute, 27f));
			this.tableLayoutPanel.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Absolute, 10f));
			this.tableLayoutPanel.Size = new global::System.Drawing.Size(520, 260);
			this.tableLayoutPanel.TabIndex = 1;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 12f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(520, 260);
			base.Controls.Add(this.tableLayoutPanel);
			base.Name = "frmAbout";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "frmAbout";
			base.Load += new global::System.EventHandler(this.frmAbout_Load);
			((global::System.ComponentModel.ISupportInitialize)this.logoPictureBox).EndInit();
			this.tableLayoutPanel.ResumeLayout(false);
			this.tableLayoutPanel.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x040002AC RID: 684
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x040002AD RID: 685
		private global::System.Windows.Forms.LinkLabel labelCompanyName;

		// Token: 0x040002AE RID: 686
		private global::System.Windows.Forms.Label labelCopyright;

		// Token: 0x040002AF RID: 687
		private global::System.Windows.Forms.Button okButton;

		// Token: 0x040002B0 RID: 688
		private global::System.Windows.Forms.TextBox textBoxDescription;

		// Token: 0x040002B1 RID: 689
		private global::System.Windows.Forms.Label labelVersion;

		// Token: 0x040002B2 RID: 690
		private global::System.Windows.Forms.Label labelProductName;

		// Token: 0x040002B3 RID: 691
		private global::System.Windows.Forms.PictureBox logoPictureBox;

		// Token: 0x040002B4 RID: 692
		private global::System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
	}
}
