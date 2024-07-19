namespace SQSClient
{
	// Token: 0x0200005A RID: 90
	public partial class MutexCheck : global::SQSClient.BaseDialogForm
	{
		// Token: 0x0600045D RID: 1117 RVA: 0x0006E754 File Offset: 0x0006C954
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600045E RID: 1118 RVA: 0x0006E78C File Offset: 0x0006C98C
		private void InitializeComponent()
		{
			this.menuBar = new global::DevComponents.DotNetBar.Bar();
			this.btnSave = new global::DevComponents.DotNetBar.ButtonItem();
			this.lbxUnit = new global::DevComponents.DotNetBar.ListBoxAdv();
			((global::System.ComponentModel.ISupportInitialize)this.menuBar).BeginInit();
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
			this.menuBar.TabIndex = 8;
			this.menuBar.TabStop = false;
			this.menuBar.Text = "Main Menu";
			this.btnSave.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.btnSave.Image = global::SQSClient.Properties.Resources.save16;
			this.btnSave.ItemAlignment = global::DevComponents.DotNetBar.eItemAlignment.Far;
			this.btnSave.Name = "btnSave";
			this.btnSave.Text = "Save";
			this.btnSave.Click += new global::System.EventHandler(this.btnSave_Click);
			this.lbxUnit.AutoScroll = true;
			this.lbxUnit.BackgroundStyle.Class = "ListBoxAdv";
			this.lbxUnit.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.lbxUnit.CheckBoxesVisible = true;
			this.lbxUnit.ContainerControlProcessDialogKey = true;
			this.lbxUnit.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.lbxUnit.DragDropSupport = true;
			this.lbxUnit.Location = new global::System.Drawing.Point(0, 26);
			this.lbxUnit.Name = "lbxUnit";
			this.lbxUnit.Size = new global::System.Drawing.Size(354, 360);
			this.lbxUnit.TabIndex = 10;
			this.lbxUnit.ItemDoubleClick += new global::System.Windows.Forms.MouseEventHandler(this.lbxUnit_ItemDoubleClick);
			base.ClientSize = new global::System.Drawing.Size(354, 386);
			base.Controls.Add(this.lbxUnit);
			base.Controls.Add(this.menuBar);
			base.Name = "MutexCheck";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "frmProUnitCheck";
			base.Load += new global::System.EventHandler(this.MutexCheck_Load);
			((global::System.ComponentModel.ISupportInitialize)this.menuBar).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000790 RID: 1936
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000791 RID: 1937
		private global::DevComponents.DotNetBar.Bar menuBar;

		// Token: 0x04000792 RID: 1938
		private global::DevComponents.DotNetBar.ButtonItem btnSave;

		// Token: 0x04000793 RID: 1939
		private global::DevComponents.DotNetBar.ListBoxAdv lbxUnit;
	}
}
