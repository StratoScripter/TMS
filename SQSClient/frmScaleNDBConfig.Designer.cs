namespace SQSClient
{
	// Token: 0x02000014 RID: 20
	public partial class frmScaleNDBConfig : global::SQSClient.BaseDialogForm
	{
		// Token: 0x060000C6 RID: 198 RVA: 0x000177CC File Offset: 0x000159CC
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00017804 File Offset: 0x00015A04
		private void InitializeComponent()
		{
			this.menuBar = new global::DevComponents.DotNetBar.Bar();
			this.btnSave = new global::DevComponents.DotNetBar.ButtonItem();
			this.layoutControl1 = new global::DevComponents.DotNetBar.Layout.LayoutControl();
			this.rtxtScaleConfigConn = new global::DevComponents.DotNetBar.Controls.RichTextBoxEx();
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
				this.btnSave
			});
			this.menuBar.Location = new global::System.Drawing.Point(0, 0);
			this.menuBar.MenuBar = true;
			this.menuBar.Name = "menuBar";
			this.menuBar.Size = new global::System.Drawing.Size(354, 26);
			this.menuBar.Stretch = true;
			this.menuBar.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.menuBar.TabIndex = 21;
			this.menuBar.TabStop = false;
			this.menuBar.Text = "Main Menu";
			this.btnSave.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.btnSave.Image = global::SQSClient.Properties.Resources.save16;
			this.btnSave.Name = "btnSave";
			this.btnSave.Text = "Save";
			this.btnSave.Click += new global::System.EventHandler(this.btnSave_Click);
			this.layoutControl1.Controls.Add(this.rtxtScaleConfigConn);
			this.layoutControl1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.layoutControl1.Location = new global::System.Drawing.Point(0, 26);
			this.layoutControl1.Name = "layoutControl1";
			this.layoutControl1.RootGroup.Items.AddRange(new global::DevComponents.DotNetBar.Layout.LayoutItemBase[]
			{
				this.layoutControlItem1
			});
			this.layoutControl1.Size = new global::System.Drawing.Size(354, 236);
			this.layoutControl1.TabIndex = 22;
			this.rtxtScaleConfigConn.BackgroundStyle.Class = "RichTextBoxBorder";
			this.rtxtScaleConfigConn.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.rtxtScaleConfigConn.Location = new global::System.Drawing.Point(80, 4);
			this.rtxtScaleConfigConn.Margin = new global::System.Windows.Forms.Padding(0);
			this.rtxtScaleConfigConn.Name = "rtxtScaleConfigConn";
			this.rtxtScaleConfigConn.Rtf = "{\\rtf1\\ansi\\ansicpg936\\deff0\\nouicompat\\deflang1033\\deflangfe2052{\\fonttbl{\\f0\\fnil\\fcharset134 \\'cb\\'ce\\'cc\\'e5;}}\r\n{\\*\\generator Riched20 10.0.18362}\\viewkind4\\uc1 \r\n\\pard\\f0\\fs18\\lang2052\\par\r\n}\r\n";
			this.rtxtScaleConfigConn.Size = new global::System.Drawing.Size(270, 100);
			this.rtxtScaleConfigConn.TabIndex = 0;
			this.layoutControlItem1.Control = this.rtxtScaleConfigConn;
			this.layoutControlItem1.Height = 108;
			this.layoutControlItem1.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Text = "ScaleDBConn";
			this.layoutControlItem1.Width = 108;
			this.layoutControlItem1.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			base.ClientSize = new global::System.Drawing.Size(354, 262);
			base.Controls.Add(this.layoutControl1);
			base.Controls.Add(this.menuBar);
			base.Name = "frmScaleNDBConfig";
			this.Text = "frmScaleNDBConfig";
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.frmScaleNDBConfig_FormClosing);
			base.Load += new global::System.EventHandler(this.frmScaleNDBConfig_Load);
			((global::System.ComponentModel.ISupportInitialize)this.menuBar).EndInit();
			this.layoutControl1.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x04000183 RID: 387
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000184 RID: 388
		private global::DevComponents.DotNetBar.Bar menuBar;

		// Token: 0x04000185 RID: 389
		private global::DevComponents.DotNetBar.ButtonItem btnSave;

		// Token: 0x04000186 RID: 390
		private global::DevComponents.DotNetBar.Layout.LayoutControl layoutControl1;

		// Token: 0x04000187 RID: 391
		private global::DevComponents.DotNetBar.Controls.RichTextBoxEx rtxtScaleConfigConn;

		// Token: 0x04000188 RID: 392
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem1;
	}
}
