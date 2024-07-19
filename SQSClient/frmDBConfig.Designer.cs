namespace SQSClient
{
	// Token: 0x02000022 RID: 34
	public partial class frmDBConfig : global::SQSClient.BaseDialogForm
	{
		// Token: 0x060001A1 RID: 417 RVA: 0x0003198C File Offset: 0x0002FB8C
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x000319C4 File Offset: 0x0002FBC4
		private void InitializeComponent()
		{
			this.menuBar = new global::DevComponents.DotNetBar.Bar();
			this.btnSave = new global::DevComponents.DotNetBar.ButtonItem();
			this.layoutControl1 = new global::DevComponents.DotNetBar.Layout.LayoutControl();
			this.rtxtConfigConn = new global::DevComponents.DotNetBar.Controls.RichTextBoxEx();
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
			this.layoutControl1.Controls.Add(this.rtxtConfigConn);
			this.layoutControl1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.layoutControl1.Location = new global::System.Drawing.Point(0, 26);
			this.layoutControl1.Name = "layoutControl1";
			this.layoutControl1.RootGroup.Items.AddRange(new global::DevComponents.DotNetBar.Layout.LayoutItemBase[]
			{
				this.layoutControlItem1
			});
			this.layoutControl1.Size = new global::System.Drawing.Size(354, 236);
			this.layoutControl1.TabIndex = 22;
			this.rtxtConfigConn.BackgroundStyle.Class = "RichTextBoxBorder";
			this.rtxtConfigConn.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.rtxtConfigConn.Location = new global::System.Drawing.Point(49, 4);
			this.rtxtConfigConn.Margin = new global::System.Windows.Forms.Padding(0);
			this.rtxtConfigConn.Name = "rtxtConfigConn";
			this.rtxtConfigConn.Rtf = "{\\rtf1\\ansi\\ansicpg936\\deff0\\deflang1033\\deflangfe2052{\\fonttbl{\\f0\\fnil\\fcharset134 \\'cb\\'ce\\'cc\\'e5;}}\r\n\\viewkind4\\uc1\\pard\\lang2052\\f0\\fs18\\par\r\n}\r\n";
			this.rtxtConfigConn.Size = new global::System.Drawing.Size(301, 100);
			this.rtxtConfigConn.TabIndex = 0;
			this.layoutControlItem1.Control = this.rtxtConfigConn;
			this.layoutControlItem1.Height = 108;
			this.layoutControlItem1.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Text = "DBConn";
			this.layoutControlItem1.Width = 108;
			this.layoutControlItem1.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			base.ClientSize = new global::System.Drawing.Size(354, 262);
			base.Controls.Add(this.layoutControl1);
			base.Controls.Add(this.menuBar);
			base.Name = "frmDBConfig";
			this.Text = "frmDBConfig";
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.frmDBConfig_FormClosing);
			base.Load += new global::System.EventHandler(this.frmDBConfig_Load);
			((global::System.ComponentModel.ISupportInitialize)this.menuBar).EndInit();
			this.layoutControl1.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x040002EC RID: 748
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x040002ED RID: 749
		private global::DevComponents.DotNetBar.Bar menuBar;

		// Token: 0x040002EE RID: 750
		private global::DevComponents.DotNetBar.ButtonItem btnSave;

		// Token: 0x040002EF RID: 751
		private global::DevComponents.DotNetBar.Layout.LayoutControl layoutControl1;

		// Token: 0x040002F0 RID: 752
		private global::DevComponents.DotNetBar.Controls.RichTextBoxEx rtxtConfigConn;

		// Token: 0x040002F1 RID: 753
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem1;
	}
}
