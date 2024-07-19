namespace SQSClient
{
	// Token: 0x02000059 RID: 89
	public partial class frmUnitProducts : global::SQSClient.BaseDialogForm
	{
		// Token: 0x06000455 RID: 1109 RVA: 0x0006E0EC File Offset: 0x0006C2EC
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000456 RID: 1110 RVA: 0x0006E124 File Offset: 0x0006C324
		private void InitializeComponent()
		{
			this.menuBar = new global::DevComponents.DotNetBar.Bar();
			this.btnSave = new global::DevComponents.DotNetBar.ButtonItem();
			this.lbxProducts = new global::DevComponents.DotNetBar.ListBoxAdv();
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
			this.lbxProducts.AutoScroll = true;
			this.lbxProducts.BackgroundStyle.Class = "ListBoxAdv";
			this.lbxProducts.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.lbxProducts.CheckBoxesVisible = true;
			this.lbxProducts.CheckStateMember = null;
			this.lbxProducts.ContainerControlProcessDialogKey = true;
			this.lbxProducts.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.lbxProducts.DragDropSupport = true;
			this.lbxProducts.Location = new global::System.Drawing.Point(0, 26);
			this.lbxProducts.Name = "lbxProducts";
			this.lbxProducts.Size = new global::System.Drawing.Size(354, 360);
			this.lbxProducts.TabIndex = 10;
			this.lbxProducts.ItemDoubleClick += new global::System.Windows.Forms.MouseEventHandler(this.lbxUnit_ItemDoubleClick);
			base.ClientSize = new global::System.Drawing.Size(354, 386);
			base.Controls.Add(this.lbxProducts);
			base.Controls.Add(this.menuBar);
			base.Name = "frmUnitProducts";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "frmProUnitCheck";
			base.Load += new global::System.EventHandler(this.frmUnitProducts_Load);
			((global::System.ComponentModel.ISupportInitialize)this.menuBar).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x0400078A RID: 1930
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400078B RID: 1931
		private global::DevComponents.DotNetBar.Bar menuBar;

		// Token: 0x0400078C RID: 1932
		private global::DevComponents.DotNetBar.ButtonItem btnSave;

		// Token: 0x0400078D RID: 1933
		private global::DevComponents.DotNetBar.ListBoxAdv lbxProducts;
	}
}
