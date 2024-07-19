namespace SQSClient
{
	// Token: 0x0200008E RID: 142
	public partial class frmProUnitCheck : global::SQSClient.BaseDialogForm
	{
		// Token: 0x060007CE RID: 1998 RVA: 0x000C2DB0 File Offset: 0x000C0FB0
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060007CF RID: 1999 RVA: 0x000C2DE8 File Offset: 0x000C0FE8
		private void InitializeComponent()
		{
			this.menuBar = new global::DevComponents.DotNetBar.Bar();
			this.btnAll = new global::DevComponents.DotNetBar.ButtonItem();
			this.btnOther = new global::DevComponents.DotNetBar.ButtonItem();
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
				this.btnAll,
				this.btnOther,
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
			this.btnAll.Name = "btnAll";
			this.btnAll.Text = "SelectAll";
			this.btnAll.Click += new global::System.EventHandler(this.btnAll_Click);
			this.btnOther.Name = "btnOther";
			this.btnOther.Text = "SelectInvert";
			this.btnOther.Click += new global::System.EventHandler(this.btnOther_Click);
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
			base.Name = "frmProUnitCheck";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "frmProUnitCheck";
			base.Load += new global::System.EventHandler(this.frmProUnitCheck_Load);
			((global::System.ComponentModel.ISupportInitialize)this.menuBar).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000D72 RID: 3442
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000D73 RID: 3443
		private global::DevComponents.DotNetBar.Bar menuBar;

		// Token: 0x04000D74 RID: 3444
		private global::DevComponents.DotNetBar.ButtonItem btnSave;

		// Token: 0x04000D75 RID: 3445
		private global::DevComponents.DotNetBar.ButtonItem btnAll;

		// Token: 0x04000D76 RID: 3446
		private global::DevComponents.DotNetBar.ButtonItem btnOther;

		// Token: 0x04000D77 RID: 3447
		private global::DevComponents.DotNetBar.ListBoxAdv lbxUnit;
	}
}
