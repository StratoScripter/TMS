namespace SQSClient
{
	// Token: 0x02000094 RID: 148
	public partial class frmLogin : global::SQSClient.BaseDialogForm
	{
		// Token: 0x06000855 RID: 2133 RVA: 0x000CD1B4 File Offset: 0x000CB3B4
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000856 RID: 2134 RVA: 0x000CD1EC File Offset: 0x000CB3EC
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::SQSClient.frmLogin));
			this.pnlTitle = new global::System.Windows.Forms.Panel();
			this.picTitle = new global::System.Windows.Forms.PictureBox();
			this.pnlLogin = new global::System.Windows.Forms.Panel();
			this.layoutControl1 = new global::DevComponents.DotNetBar.Layout.LayoutControl();
			this.txtUser = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.txtPwd = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.layoutControlItem1 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem2 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.btnCancel = new global::DevComponents.DotNetBar.ButtonX();
			this.btnLogin = new global::DevComponents.DotNetBar.ButtonX();
			this.buttonX1 = new global::DevComponents.DotNetBar.ButtonX();
			this.buttonX2 = new global::DevComponents.DotNetBar.ButtonX();
			this.textBoxX1 = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.textBoxX2 = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.labelX1 = new global::DevComponents.DotNetBar.LabelX();
			this.labelX2 = new global::DevComponents.DotNetBar.LabelX();
			this.labelX3 = new global::DevComponents.DotNetBar.LabelX();
			this.pnlTitle.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.picTitle).BeginInit();
			this.pnlLogin.SuspendLayout();
			this.layoutControl1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			base.SuspendLayout();
			this.pnlTitle.Controls.Add(this.picTitle);
			this.pnlTitle.Location = new global::System.Drawing.Point(0, 0);
			this.pnlTitle.Name = "pnlTitle";
			this.pnlTitle.Size = new global::System.Drawing.Size(905, 215);
			this.pnlTitle.TabIndex = 1;
			this.picTitle.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("picTitle.Image");
			this.picTitle.Location = new global::System.Drawing.Point(0, 0);
			this.picTitle.Name = "picTitle";
			this.picTitle.Size = new global::System.Drawing.Size(905, 215);
			this.picTitle.TabIndex = 0;
			this.picTitle.TabStop = false;
			this.pnlLogin.BackColor = global::System.Drawing.SystemColors.Control;
			this.pnlLogin.Controls.Add(this.layoutControl1);
			this.pnlLogin.Controls.Add(this.pictureBox1);
			this.pnlLogin.Controls.Add(this.btnCancel);
			this.pnlLogin.Controls.Add(this.btnLogin);
			this.pnlLogin.Location = new global::System.Drawing.Point(0, 215);
			this.pnlLogin.Name = "pnlLogin";
			this.pnlLogin.Size = new global::System.Drawing.Size(905, 362);
			this.pnlLogin.TabIndex = 2;
			this.pnlLogin.Paint += new global::System.Windows.Forms.PaintEventHandler(this.pnlLogin_Paint);
			this.layoutControl1.BackColor = global::System.Drawing.Color.Transparent;
			this.layoutControl1.Controls.Add(this.txtUser);
			this.layoutControl1.Controls.Add(this.txtPwd);
			this.layoutControl1.Location = new global::System.Drawing.Point(300, 142);
			this.layoutControl1.Name = "layoutControl1";
			this.layoutControl1.RootGroup.Items.AddRange(new global::DevComponents.DotNetBar.Layout.LayoutItemBase[]
			{
				this.layoutControlItem1,
				this.layoutControlItem2
			});
			this.layoutControl1.Size = new global::System.Drawing.Size(298, 68);
			this.layoutControl1.TabIndex = 16;
			this.txtUser.Border.Class = "TextBoxBorder";
			this.txtUser.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtUser.Location = new global::System.Drawing.Point(73, 4);
			this.txtUser.Margin = new global::System.Windows.Forms.Padding(0);
			this.txtUser.Name = "txtUser";
			this.txtUser.PreventEnterBeep = true;
			this.txtUser.Size = new global::System.Drawing.Size(221, 21);
			this.txtUser.TabIndex = 0;
			this.txtPwd.Border.Class = "TextBoxBorder";
			this.txtPwd.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtPwd.Location = new global::System.Drawing.Point(73, 36);
			this.txtPwd.Margin = new global::System.Windows.Forms.Padding(0);
			this.txtPwd.MaxLength = 50;
			this.txtPwd.Name = "txtPwd";
			this.txtPwd.PreventEnterBeep = true;
			this.txtPwd.Size = new global::System.Drawing.Size(221, 21);
			this.txtPwd.TabIndex = 1;
			this.txtPwd.UseSystemPasswordChar = true;
			this.txtPwd.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.txtPwd_KeyPress);
			this.layoutControlItem1.Control = this.txtUser;
			this.layoutControlItem1.Height = 32;
			this.layoutControlItem1.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Style.Font = new global::System.Drawing.Font("宋体", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 134);
			this.layoutControlItem1.Style.TextColor = global::System.Drawing.Color.DarkBlue;
			this.layoutControlItem1.Text = "labUser";
			this.layoutControlItem1.Width = 100;
			this.layoutControlItem1.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem2.Control = this.txtPwd;
			this.layoutControlItem2.Height = 32;
			this.layoutControlItem2.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem2.Name = "layoutControlItem2";
			this.layoutControlItem2.Style.Font = new global::System.Drawing.Font("宋体", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 134);
			this.layoutControlItem2.Style.TextColor = global::System.Drawing.Color.DarkBlue;
			this.layoutControlItem2.Text = "labPwd";
			this.layoutControlItem2.Width = 100;
			this.layoutControlItem2.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.pictureBox1.BackColor = global::System.Drawing.Color.Transparent;
			this.pictureBox1.Location = new global::System.Drawing.Point(203, 47);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(499, 41);
			this.pictureBox1.TabIndex = 13;
			this.pictureBox1.TabStop = false;
			this.btnCancel.AccessibleRole = global::System.Windows.Forms.AccessibleRole.PushButton;
			this.btnCancel.BackColor = global::System.Drawing.Color.Transparent;
			this.btnCancel.ColorTable = global::DevComponents.DotNetBar.eButtonColor.Orange;
			this.btnCancel.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnCancel.Font = new global::System.Drawing.Font("宋体", 10.5f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 134);
			this.btnCancel.Image = global::SQSClient.Properties.Resources.cancel16;
			this.btnCancel.Location = new global::System.Drawing.Point(480, 223);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new global::System.Drawing.Size(90, 30);
			this.btnCancel.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.btnCancel.TabIndex = 4;
			this.btnCancel.Text = "btnCancel";
			this.btnCancel.TextColor = global::System.Drawing.Color.DarkBlue;
			this.btnCancel.Click += new global::System.EventHandler(this.btnQuit_Click);
			this.btnLogin.AccessibleRole = global::System.Windows.Forms.AccessibleRole.PushButton;
			this.btnLogin.BackColor = global::System.Drawing.Color.Transparent;
			this.btnLogin.ColorTable = global::DevComponents.DotNetBar.eButtonColor.Orange;
			this.btnLogin.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnLogin.Font = new global::System.Drawing.Font("宋体", 10.5f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 134);
			this.btnLogin.Image = global::SQSClient.Properties.Resources.login16;
			this.btnLogin.Location = new global::System.Drawing.Point(375, 223);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new global::System.Drawing.Size(90, 30);
			this.btnLogin.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.btnLogin.TabIndex = 3;
			this.btnLogin.Text = "btnLogin";
			this.btnLogin.TextColor = global::System.Drawing.Color.DarkBlue;
			this.btnLogin.Click += new global::System.EventHandler(this.btnLogin_Click);
			this.buttonX1.AccessibleRole = global::System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonX1.Location = new global::System.Drawing.Point(0, 0);
			this.buttonX1.Name = "buttonX1";
			this.buttonX1.Size = new global::System.Drawing.Size(0, 0);
			this.buttonX1.TabIndex = 0;
			this.buttonX2.AccessibleRole = global::System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonX2.Location = new global::System.Drawing.Point(0, 0);
			this.buttonX2.Name = "buttonX2";
			this.buttonX2.Size = new global::System.Drawing.Size(0, 0);
			this.buttonX2.TabIndex = 0;
			this.textBoxX1.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.textBoxX1.Location = new global::System.Drawing.Point(0, 0);
			this.textBoxX1.Name = "textBoxX1";
			this.textBoxX1.Size = new global::System.Drawing.Size(100, 21);
			this.textBoxX1.TabIndex = 0;
			this.textBoxX2.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.textBoxX2.Location = new global::System.Drawing.Point(0, 0);
			this.textBoxX2.Name = "textBoxX2";
			this.textBoxX2.Size = new global::System.Drawing.Size(100, 21);
			this.textBoxX2.TabIndex = 0;
			this.labelX1.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.labelX1.Location = new global::System.Drawing.Point(0, 0);
			this.labelX1.Name = "labelX1";
			this.labelX1.Size = new global::System.Drawing.Size(0, 0);
			this.labelX1.TabIndex = 0;
			this.labelX2.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.labelX2.Location = new global::System.Drawing.Point(0, 0);
			this.labelX2.Name = "labelX2";
			this.labelX2.Size = new global::System.Drawing.Size(0, 0);
			this.labelX2.TabIndex = 0;
			this.labelX3.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.labelX3.Location = new global::System.Drawing.Point(0, 0);
			this.labelX3.Name = "labelX3";
			this.labelX3.Size = new global::System.Drawing.Size(0, 0);
			this.labelX3.TabIndex = 0;
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = global::System.Drawing.Color.White;
			base.ClientSize = new global::System.Drawing.Size(905, 577);
			base.Controls.Add(this.pnlLogin);
			base.Controls.Add(this.pnlTitle);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "frmLogin";
			this.Text = "frmLogin";
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.frmLogin_FormClosing);
			base.Load += new global::System.EventHandler(this.frmLogin_Load);
			this.pnlTitle.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.picTitle).EndInit();
			this.pnlLogin.ResumeLayout(false);
			this.layoutControl1.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000E2A RID: 3626
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000E2B RID: 3627
		private global::System.Windows.Forms.PictureBox picTitle;

		// Token: 0x04000E2C RID: 3628
		private global::System.Windows.Forms.Panel pnlTitle;

		// Token: 0x04000E2D RID: 3629
		private global::System.Windows.Forms.Panel pnlLogin;

		// Token: 0x04000E2E RID: 3630
		private global::DevComponents.DotNetBar.ButtonX buttonX1;

		// Token: 0x04000E2F RID: 3631
		private global::DevComponents.DotNetBar.ButtonX buttonX2;

		// Token: 0x04000E30 RID: 3632
		private global::DevComponents.DotNetBar.Controls.TextBoxX textBoxX1;

		// Token: 0x04000E31 RID: 3633
		private global::DevComponents.DotNetBar.Controls.TextBoxX textBoxX2;

		// Token: 0x04000E32 RID: 3634
		private global::DevComponents.DotNetBar.LabelX labelX1;

		// Token: 0x04000E33 RID: 3635
		private global::DevComponents.DotNetBar.LabelX labelX2;

		// Token: 0x04000E34 RID: 3636
		private global::DevComponents.DotNetBar.LabelX labelX3;

		// Token: 0x04000E35 RID: 3637
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtPwd;

		// Token: 0x04000E36 RID: 3638
		private global::DevComponents.DotNetBar.ButtonX btnCancel;

		// Token: 0x04000E37 RID: 3639
		private global::DevComponents.DotNetBar.ButtonX btnLogin;

		// Token: 0x04000E38 RID: 3640
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000E39 RID: 3641
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtUser;

		// Token: 0x04000E3A RID: 3642
		private global::DevComponents.DotNetBar.Layout.LayoutControl layoutControl1;

		// Token: 0x04000E3B RID: 3643
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem1;

		// Token: 0x04000E3C RID: 3644
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem2;
	}
}
