namespace SQSClient
{
	// Token: 0x0200002A RID: 42
	public partial class frmPasswordSure : global::SQSClient.BaseDialogForm
	{
		// Token: 0x06000214 RID: 532 RVA: 0x0003D4B8 File Offset: 0x0003B6B8
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000215 RID: 533 RVA: 0x0003D4F0 File Offset: 0x0003B6F0
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::SQSClient.frmPasswordSure));
			this.layoutControl1 = new global::DevComponents.DotNetBar.Layout.LayoutControl();
			this.tbxNewPwd2 = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.layoutControlItem3 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.menuBar = new global::DevComponents.DotNetBar.Bar();
			this.btnSave = new global::DevComponents.DotNetBar.ButtonItem();
			this.layoutControl1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.menuBar).BeginInit();
			base.SuspendLayout();
			this.layoutControl1.Controls.Add(this.tbxNewPwd2);
			this.layoutControl1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.layoutControl1.Location = new global::System.Drawing.Point(0, 26);
			this.layoutControl1.Name = "layoutControl1";
			this.layoutControl1.RootGroup.Items.AddRange(new global::DevComponents.DotNetBar.Layout.LayoutItemBase[]
			{
				this.layoutControlItem3
			});
			this.layoutControl1.Size = new global::System.Drawing.Size(354, 106);
			this.layoutControl1.TabIndex = 0;
			this.tbxNewPwd2.Border.Class = "TextBoxBorder";
			this.tbxNewPwd2.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.tbxNewPwd2.Location = new global::System.Drawing.Point(110, 4);
			this.tbxNewPwd2.Margin = new global::System.Windows.Forms.Padding(0);
			this.tbxNewPwd2.MaxLength = 50;
			this.tbxNewPwd2.Name = "tbxNewPwd2";
			this.tbxNewPwd2.PreventEnterBeep = true;
			this.tbxNewPwd2.Size = new global::System.Drawing.Size(240, 21);
			this.tbxNewPwd2.TabIndex = 0;
			this.tbxNewPwd2.UseSystemPasswordChar = true;
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
			this.btnSave.Text = "Sure";
			this.btnSave.Click += new global::System.EventHandler(this.btnSave_Click);
			base.ClientSize = new global::System.Drawing.Size(354, 132);
			base.Controls.Add(this.layoutControl1);
			base.Controls.Add(this.menuBar);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "frmPasswordSure";
			this.Text = "itemPassword";
			base.Load += new global::System.EventHandler(this.frmPasswordSure_Load);
			this.layoutControl1.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.menuBar).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x040003C7 RID: 967
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x040003C8 RID: 968
		private global::DevComponents.DotNetBar.Layout.LayoutControl layoutControl1;

		// Token: 0x040003C9 RID: 969
		private global::DevComponents.DotNetBar.Controls.TextBoxX tbxNewPwd2;

		// Token: 0x040003CA RID: 970
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem3;

		// Token: 0x040003CB RID: 971
		private global::DevComponents.DotNetBar.Bar menuBar;

		// Token: 0x040003CC RID: 972
		private global::DevComponents.DotNetBar.ButtonItem btnSave;
	}
}
