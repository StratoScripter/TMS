namespace SQSClient
{
	// Token: 0x0200007D RID: 125
	public partial class frmPassword : global::SQSClient.BaseDialogForm
	{
		// Token: 0x060006DF RID: 1759 RVA: 0x000A93B0 File Offset: 0x000A75B0
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060006E0 RID: 1760 RVA: 0x000A93E8 File Offset: 0x000A75E8
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::SQSClient.frmPassword));
			this.layoutControl1 = new global::DevComponents.DotNetBar.Layout.LayoutControl();
			this.tbxNewPwd2 = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.tbxNewPwd = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.tbxOldPwd = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.layoutControlItem1 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem2 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem3 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.menuBar = new global::DevComponents.DotNetBar.Bar();
			this.btnSave = new global::DevComponents.DotNetBar.ButtonItem();
			this.layoutControl1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.menuBar).BeginInit();
			base.SuspendLayout();
			this.layoutControl1.Controls.Add(this.tbxNewPwd2);
			this.layoutControl1.Controls.Add(this.tbxNewPwd);
			this.layoutControl1.Controls.Add(this.tbxOldPwd);
			this.layoutControl1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.layoutControl1.Location = new global::System.Drawing.Point(0, 26);
			this.layoutControl1.Name = "layoutControl1";
			this.layoutControl1.RootGroup.Items.AddRange(new global::DevComponents.DotNetBar.Layout.LayoutItemBase[]
			{
				this.layoutControlItem1,
				this.layoutControlItem2,
				this.layoutControlItem3
			});
			this.layoutControl1.Size = new global::System.Drawing.Size(354, 106);
			this.layoutControl1.TabIndex = 0;
			this.tbxNewPwd2.Border.Class = "TextBoxBorder";
			this.tbxNewPwd2.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.tbxNewPwd2.Location = new global::System.Drawing.Point(110, 62);
			this.tbxNewPwd2.Margin = new global::System.Windows.Forms.Padding(0);
			this.tbxNewPwd2.MaxLength = 50;
			this.tbxNewPwd2.Name = "tbxNewPwd2";
			this.tbxNewPwd2.PreventEnterBeep = true;
			this.tbxNewPwd2.Size = new global::System.Drawing.Size(240, 21);
			this.tbxNewPwd2.TabIndex = 2;
			this.tbxNewPwd2.UseSystemPasswordChar = true;
			this.tbxNewPwd.Border.Class = "TextBoxBorder";
			this.tbxNewPwd.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.tbxNewPwd.Location = new global::System.Drawing.Point(110, 33);
			this.tbxNewPwd.Margin = new global::System.Windows.Forms.Padding(0);
			this.tbxNewPwd.MaxLength = 50;
			this.tbxNewPwd.Name = "tbxNewPwd";
			this.tbxNewPwd.PreventEnterBeep = true;
			this.tbxNewPwd.Size = new global::System.Drawing.Size(240, 21);
			this.tbxNewPwd.TabIndex = 1;
			this.tbxNewPwd.UseSystemPasswordChar = true;
			this.tbxOldPwd.Border.Class = "TextBoxBorder";
			this.tbxOldPwd.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.tbxOldPwd.Location = new global::System.Drawing.Point(110, 4);
			this.tbxOldPwd.Margin = new global::System.Windows.Forms.Padding(0);
			this.tbxOldPwd.MaxLength = 50;
			this.tbxOldPwd.Name = "tbxOldPwd";
			this.tbxOldPwd.PreventEnterBeep = true;
			this.tbxOldPwd.Size = new global::System.Drawing.Size(240, 21);
			this.tbxOldPwd.TabIndex = 0;
			this.tbxOldPwd.UseSystemPasswordChar = true;
			this.layoutControlItem1.Control = this.tbxOldPwd;
			this.layoutControlItem1.Height = 29;
			this.layoutControlItem1.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Text = "*OldPassword";
			this.layoutControlItem1.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem1.Width = 100;
			this.layoutControlItem1.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem2.Control = this.tbxNewPwd;
			this.layoutControlItem2.Height = 29;
			this.layoutControlItem2.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem2.Name = "layoutControlItem2";
			this.layoutControlItem2.Text = "*NewPassword";
			this.layoutControlItem2.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem2.Width = 100;
			this.layoutControlItem2.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem3.Control = this.tbxNewPwd2;
			this.layoutControlItem3.Height = 29;
			this.layoutControlItem3.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem3.Name = "layoutControlItem3";
			this.layoutControlItem3.Text = "*ConfirmPassword";
			this.layoutControlItem3.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem3.Width = 100;
			this.layoutControlItem3.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
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
			this.menuBar.Size = new global::System.Drawing.Size(354, 26);
			this.menuBar.Stretch = true;
			this.menuBar.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.menuBar.TabIndex = 19;
			this.menuBar.TabStop = false;
			this.menuBar.Text = "Main Menu";
			this.btnSave.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.btnSave.Image = global::SQSClient.Properties.Resources.save16;
			this.btnSave.Name = "btnSave";
			this.btnSave.Text = "Save";
			this.btnSave.Click += new global::System.EventHandler(this.btnSave_Click);
			base.ClientSize = new global::System.Drawing.Size(354, 132);
			base.Controls.Add(this.layoutControl1);
			base.Controls.Add(this.menuBar);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "frmPassword";
			this.Text = "itemPassword";
			base.Load += new global::System.EventHandler(this.frmPassword_Load);
			this.layoutControl1.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.menuBar).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000BAD RID: 2989
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000BAE RID: 2990
		private global::DevComponents.DotNetBar.Layout.LayoutControl layoutControl1;

		// Token: 0x04000BAF RID: 2991
		private global::DevComponents.DotNetBar.Controls.TextBoxX tbxNewPwd2;

		// Token: 0x04000BB0 RID: 2992
		private global::DevComponents.DotNetBar.Controls.TextBoxX tbxNewPwd;

		// Token: 0x04000BB1 RID: 2993
		private global::DevComponents.DotNetBar.Controls.TextBoxX tbxOldPwd;

		// Token: 0x04000BB2 RID: 2994
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem1;

		// Token: 0x04000BB3 RID: 2995
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem2;

		// Token: 0x04000BB4 RID: 2996
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem3;

		// Token: 0x04000BB5 RID: 2997
		private global::DevComponents.DotNetBar.Bar menuBar;

		// Token: 0x04000BB6 RID: 2998
		private global::DevComponents.DotNetBar.ButtonItem btnSave;
	}
}
