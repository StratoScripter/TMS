namespace SQSClient
{
	// Token: 0x02000034 RID: 52
	public partial class frmWordEdit : global::SQSClient.BaseDialogForm
	{
		// Token: 0x06000273 RID: 627 RVA: 0x000439F4 File Offset: 0x00041BF4
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000274 RID: 628 RVA: 0x00043A2C File Offset: 0x00041C2C
		private void InitializeComponent()
		{
			this.menuBar = new global::DevComponents.DotNetBar.Bar();
			this.btnSure = new global::DevComponents.DotNetBar.ButtonItem();
			this.layoutControl1 = new global::DevComponents.DotNetBar.Layout.LayoutControl();
			this.txtKey = new global::DevComponents.DotNetBar.Controls.TextBoxX();
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
				this.btnSure
			});
			this.menuBar.Location = new global::System.Drawing.Point(0, 0);
			this.menuBar.MenuBar = true;
			this.menuBar.Name = "menuBar";
			this.menuBar.Size = new global::System.Drawing.Size(418, 26);
			this.menuBar.Stretch = true;
			this.menuBar.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.menuBar.TabIndex = 20;
			this.menuBar.TabStop = false;
			this.menuBar.Text = "Main Menu";
			this.btnSure.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.btnSure.Image = global::SQSClient.Properties.Resources.save16;
			this.btnSure.Name = "btnSure";
			this.btnSure.Text = "Sure";
			this.btnSure.Click += new global::System.EventHandler(this.btnSure_Click);
			this.layoutControl1.Controls.Add(this.txtKey);
			this.layoutControl1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.layoutControl1.Location = new global::System.Drawing.Point(0, 26);
			this.layoutControl1.Name = "layoutControl1";
			this.layoutControl1.RootGroup.Items.AddRange(new global::DevComponents.DotNetBar.Layout.LayoutItemBase[]
			{
				this.layoutControlItem1
			});
			this.layoutControl1.Size = new global::System.Drawing.Size(418, 65);
			this.layoutControl1.TabIndex = 21;
			this.txtKey.Border.Class = "TextBoxBorder";
			this.txtKey.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtKey.Location = new global::System.Drawing.Point(36, 4);
			this.txtKey.Margin = new global::System.Windows.Forms.Padding(0);
			this.txtKey.MaxLength = 20;
			this.txtKey.Name = "txtKey";
			this.txtKey.PreventEnterBeep = true;
			this.txtKey.Size = new global::System.Drawing.Size(378, 21);
			this.txtKey.TabIndex = 0;
			this.layoutControlItem1.Control = this.txtKey;
			this.layoutControlItem1.Height = 29;
			this.layoutControlItem1.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Text = "*Key";
			this.layoutControlItem1.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem1.Width = 100;
			this.layoutControlItem1.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			base.ClientSize = new global::System.Drawing.Size(418, 91);
			base.Controls.Add(this.layoutControl1);
			base.Controls.Add(this.menuBar);
			base.Name = "frmWordEdit";
			this.Text = "frmWord";
			base.Load += new global::System.EventHandler(this.frmWordEdit_Load);
			((global::System.ComponentModel.ISupportInitialize)this.menuBar).EndInit();
			this.layoutControl1.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x04000442 RID: 1090
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000443 RID: 1091
		private global::DevComponents.DotNetBar.Bar menuBar;

		// Token: 0x04000444 RID: 1092
		private global::DevComponents.DotNetBar.ButtonItem btnSure;

		// Token: 0x04000445 RID: 1093
		private global::DevComponents.DotNetBar.Layout.LayoutControl layoutControl1;

		// Token: 0x04000446 RID: 1094
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtKey;

		// Token: 0x04000447 RID: 1095
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem1;
	}
}
