namespace SQSClient
{
	// Token: 0x0200003F RID: 63
	public partial class frmItemChoose : global::SQSClient.BaseDialogForm
	{
		// Token: 0x060002E0 RID: 736 RVA: 0x0004A928 File Offset: 0x00048B28
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060002E1 RID: 737 RVA: 0x0004A960 File Offset: 0x00048B60
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			this.menuBar = new global::DevComponents.DotNetBar.Bar();
			this.btnSave = new global::DevComponents.DotNetBar.ButtonItem();
			this.lbxMenu = new global::DevComponents.DotNetBar.ListBoxAdv();
			this.contextMenuStrip = new global::System.Windows.Forms.ContextMenuStrip(this.components);
			this.toolReadOnly = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolwritable = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolbackColor = new global::System.Windows.Forms.ToolStripMenuItem();
			((global::System.ComponentModel.ISupportInitialize)this.menuBar).BeginInit();
			this.contextMenuStrip.SuspendLayout();
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
			this.menuBar.TabIndex = 20;
			this.menuBar.TabStop = false;
			this.menuBar.Text = "Main Menu";
			this.btnSave.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.btnSave.Image = global::SQSClient.Properties.Resources.save16;
			this.btnSave.Name = "btnSave";
			this.btnSave.Text = "Save";
			this.btnSave.Click += new global::System.EventHandler(this.btnSave_Click);
			this.lbxMenu.AutoScroll = true;
			this.lbxMenu.BackgroundStyle.Class = "ListBoxAdv";
			this.lbxMenu.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.lbxMenu.CheckBoxesVisible = true;
			this.lbxMenu.CheckStateMember = null;
			this.lbxMenu.ContainerControlProcessDialogKey = true;
			this.lbxMenu.ContextMenuStrip = this.contextMenuStrip;
			this.lbxMenu.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.lbxMenu.DragDropSupport = true;
			this.lbxMenu.EnableDragDrop = true;
			this.lbxMenu.Location = new global::System.Drawing.Point(0, 26);
			this.lbxMenu.Name = "lbxMenu";
			this.lbxMenu.Size = new global::System.Drawing.Size(354, 546);
			this.lbxMenu.TabIndex = 22;
			this.lbxMenu.ItemCheck += new global::DevComponents.DotNetBar.ListBoxAdvItemCheckEventHandler(this.lbxMenu_ItemCheck);
			this.lbxMenu.ItemDoubleClick += new global::System.Windows.Forms.MouseEventHandler(this.lbxMenu_ItemDoubleClick);
			this.lbxMenu.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.lbxMenu_MouseDown);
			this.contextMenuStrip.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.toolReadOnly,
				this.toolwritable,
				this.toolbackColor
			});
			this.contextMenuStrip.Name = "contextMenuStrip";
			this.contextMenuStrip.Size = new global::System.Drawing.Size(137, 70);
			this.toolReadOnly.CheckOnClick = true;
			this.toolReadOnly.Name = "toolReadOnly";
			this.toolReadOnly.Size = new global::System.Drawing.Size(136, 22);
			this.toolReadOnly.Text = "ReadOnly";
			this.toolReadOnly.Visible = false;
			this.toolReadOnly.Click += new global::System.EventHandler(this.toolReadOnly_Click);
			this.toolwritable.Name = "toolwritable";
			this.toolwritable.Size = new global::System.Drawing.Size(136, 22);
			this.toolwritable.Text = "Writable";
			this.toolwritable.Visible = false;
			this.toolwritable.Click += new global::System.EventHandler(this.toolwritable_Click);
			this.toolbackColor.Name = "toolbackColor";
			this.toolbackColor.Size = new global::System.Drawing.Size(136, 22);
			this.toolbackColor.Text = "BackColor";
			this.toolbackColor.Visible = false;
			this.toolbackColor.Click += new global::System.EventHandler(this.toolbackColor_Click);
			base.ClientSize = new global::System.Drawing.Size(354, 572);
			base.Controls.Add(this.lbxMenu);
			base.Controls.Add(this.menuBar);
			base.Name = "frmItemChoose";
			this.Text = "frmItemChoise";
			base.Load += new global::System.EventHandler(this.frmItemChoise_Load);
			((global::System.ComponentModel.ISupportInitialize)this.menuBar).EndInit();
			this.contextMenuStrip.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x040004AA RID: 1194
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x040004AB RID: 1195
		private global::DevComponents.DotNetBar.Bar menuBar;

		// Token: 0x040004AC RID: 1196
		private global::DevComponents.DotNetBar.ButtonItem btnSave;

		// Token: 0x040004AD RID: 1197
		private global::DevComponents.DotNetBar.ListBoxAdv lbxMenu;

		// Token: 0x040004AE RID: 1198
		private global::System.Windows.Forms.ContextMenuStrip contextMenuStrip;

		// Token: 0x040004AF RID: 1199
		private global::System.Windows.Forms.ToolStripMenuItem toolReadOnly;

		// Token: 0x040004B0 RID: 1200
		private global::System.Windows.Forms.ToolStripMenuItem toolwritable;

		// Token: 0x040004B1 RID: 1201
		private global::System.Windows.Forms.ToolStripMenuItem toolbackColor;
	}
}
