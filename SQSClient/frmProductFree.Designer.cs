namespace SQSClient
{
	// Token: 0x02000067 RID: 103
	public partial class frmProductFree : global::SQSClient.BaseDialogForm
	{
		// Token: 0x06000538 RID: 1336 RVA: 0x00083C4C File Offset: 0x00081E4C
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000539 RID: 1337 RVA: 0x00083C84 File Offset: 0x00081E84
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::SQSClient.frmProductFree));
			this.menuBar = new global::DevComponents.DotNetBar.Bar();
			this.btnSave = new global::DevComponents.DotNetBar.ButtonItem();
			this.splitContainer1 = new global::System.Windows.Forms.SplitContainer();
			this.layoutControl1 = new global::DevComponents.DotNetBar.Layout.LayoutControl();
			this.txtProExtInfo = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.layoutControlItem3 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlFree = new global::DevComponents.DotNetBar.Layout.LayoutControl();
			this.layoutControlItem2 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.txtInvCode = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.layoutControlItem1 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem4 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.txtInvName = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.layoutControlItem5 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			((global::System.ComponentModel.ISupportInitialize)this.menuBar).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.splitContainer1).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
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
			this.menuBar.Size = new global::System.Drawing.Size(350, 26);
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
			this.splitContainer1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new global::System.Drawing.Point(0, 26);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = global::System.Windows.Forms.Orientation.Horizontal;
			this.splitContainer1.Panel1.Controls.Add(this.layoutControl1);
			this.splitContainer1.Panel2.Controls.Add(this.layoutControlFree);
			this.splitContainer1.Size = new global::System.Drawing.Size(350, 392);
			this.splitContainer1.SplitterDistance = 94;
			this.splitContainer1.TabIndex = 20;
			this.layoutControl1.Controls.Add(this.txtProExtInfo);
			this.layoutControl1.Controls.Add(this.txtInvCode);
			this.layoutControl1.Controls.Add(this.txtInvName);
			this.layoutControl1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.layoutControl1.Location = new global::System.Drawing.Point(0, 0);
			this.layoutControl1.Name = "layoutControl1";
			this.layoutControl1.RootGroup.Items.AddRange(new global::DevComponents.DotNetBar.Layout.LayoutItemBase[]
			{
				this.layoutControlItem1,
				this.layoutControlItem5,
				this.layoutControlItem3
			});
			this.layoutControl1.Size = new global::System.Drawing.Size(350, 94);
			this.layoutControl1.TabIndex = 22;
			this.txtProExtInfo.Border.Class = "TextBoxBorder";
			this.txtProExtInfo.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtProExtInfo.Location = new global::System.Drawing.Point(73, 62);
			this.txtProExtInfo.Margin = new global::System.Windows.Forms.Padding(0);
			this.txtProExtInfo.MaxLength = 20;
			this.txtProExtInfo.Name = "txtProExtInfo";
			this.txtProExtInfo.PreventEnterBeep = true;
			this.txtProExtInfo.Size = new global::System.Drawing.Size(273, 21);
			this.txtProExtInfo.TabIndex = 2;
			this.layoutControlItem3.Control = this.txtProExtInfo;
			this.layoutControlItem3.Height = 29;
			this.layoutControlItem3.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem3.Name = "layoutControlItem3";
			this.layoutControlItem3.Text = "ProExtInfo";
			this.layoutControlItem3.Width = 100;
			this.layoutControlItem3.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlFree.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.layoutControlFree.Location = new global::System.Drawing.Point(0, 0);
			this.layoutControlFree.Name = "layoutControlFree";
			this.layoutControlFree.Size = new global::System.Drawing.Size(350, 294);
			this.layoutControlFree.TabIndex = 22;
			this.layoutControlItem2.Control = this.txtInvCode;
			this.layoutControlItem2.Height = 29;
			this.layoutControlItem2.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem2.Name = "layoutControlItem2";
			this.layoutControlItem2.Text = "InvCode";
			this.layoutControlItem2.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem2.Width = 50;
			this.layoutControlItem2.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.txtInvCode.Border.Class = "TextBoxBorder";
			this.txtInvCode.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtInvCode.Location = new global::System.Drawing.Point(73, 4);
			this.txtInvCode.Margin = new global::System.Windows.Forms.Padding(0);
			this.txtInvCode.MaxLength = 20;
			this.txtInvCode.Name = "txtInvCode";
			this.txtInvCode.PreventEnterBeep = true;
			this.txtInvCode.Size = new global::System.Drawing.Size(273, 21);
			this.txtInvCode.TabIndex = 0;
			this.layoutControlItem1.Control = this.txtInvCode;
			this.layoutControlItem1.Height = 29;
			this.layoutControlItem1.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Text = "InvCode";
			this.layoutControlItem1.Width = 100;
			this.layoutControlItem1.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem4.Control = this.txtInvName;
			this.layoutControlItem4.Height = 29;
			this.layoutControlItem4.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem4.Name = "layoutControlItem4";
			this.layoutControlItem4.Text = "InvCode";
			this.layoutControlItem4.Width = 100;
			this.layoutControlItem4.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.txtInvName.Border.Class = "TextBoxBorder";
			this.txtInvName.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtInvName.Location = new global::System.Drawing.Point(73, 33);
			this.txtInvName.Margin = new global::System.Windows.Forms.Padding(0);
			this.txtInvName.MaxLength = 20;
			this.txtInvName.Name = "txtInvName";
			this.txtInvName.PreventEnterBeep = true;
			this.txtInvName.Size = new global::System.Drawing.Size(273, 21);
			this.txtInvName.TabIndex = 1;
			this.layoutControlItem5.Control = this.txtInvName;
			this.layoutControlItem5.Height = 29;
			this.layoutControlItem5.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem5.Name = "layoutControlItem5";
			this.layoutControlItem5.Text = "InvName";
			this.layoutControlItem5.Width = 100;
			this.layoutControlItem5.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			base.ClientSize = new global::System.Drawing.Size(350, 418);
			base.Controls.Add(this.splitContainer1);
			base.Controls.Add(this.menuBar);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "frmProductFree";
			this.Text = "frmProductFree";
			base.Load += new global::System.EventHandler(this.frmProductFree_Load);
			((global::System.ComponentModel.ISupportInitialize)this.menuBar).EndInit();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.splitContainer1).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.layoutControl1.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x040008FE RID: 2302
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x040008FF RID: 2303
		private global::DevComponents.DotNetBar.Bar menuBar;

		// Token: 0x04000900 RID: 2304
		private global::DevComponents.DotNetBar.ButtonItem btnSave;

		// Token: 0x04000901 RID: 2305
		private global::System.Windows.Forms.SplitContainer splitContainer1;

		// Token: 0x04000902 RID: 2306
		private global::DevComponents.DotNetBar.Layout.LayoutControl layoutControl1;

		// Token: 0x04000903 RID: 2307
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtProExtInfo;

		// Token: 0x04000904 RID: 2308
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem3;

		// Token: 0x04000905 RID: 2309
		private global::DevComponents.DotNetBar.Layout.LayoutControl layoutControlFree;

		// Token: 0x04000906 RID: 2310
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtInvCode;

		// Token: 0x04000907 RID: 2311
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtInvName;

		// Token: 0x04000908 RID: 2312
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem1;

		// Token: 0x04000909 RID: 2313
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem5;

		// Token: 0x0400090A RID: 2314
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem2;

		// Token: 0x0400090B RID: 2315
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem4;
	}
}
