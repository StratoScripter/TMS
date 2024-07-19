namespace SQSClient
{
	// Token: 0x0200006B RID: 107
	public partial class frmTicketBatchShow : global::SQSClient.BaseDialogForm
	{
		// Token: 0x06000570 RID: 1392 RVA: 0x0008950C File Offset: 0x0008770C
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000571 RID: 1393 RVA: 0x00089544 File Offset: 0x00087744
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::SQSClient.frmTicketBatchShow));
			this.menuBar = new global::DevComponents.DotNetBar.Bar();
			this.btnSave = new global::DevComponents.DotNetBar.ButtonItem();
			this.laySunHao = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layAdd = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.splitContainer1 = new global::System.Windows.Forms.SplitContainer();
			this.layoutControl2 = new global::DevComponents.DotNetBar.Layout.LayoutControl();
			this.tbxInvCode = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.tbxInvName = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.tbxDanHao = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.btnAdd = new global::DevComponents.DotNetBar.ButtonX();
			this.layoutControlItem1 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem7 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem8 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem2 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControl1 = new global::DevComponents.DotNetBar.Layout.LayoutControl();
			((global::System.ComponentModel.ISupportInitialize)this.menuBar).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.splitContainer1).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.layoutControl2.SuspendLayout();
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
			this.menuBar.Size = new global::System.Drawing.Size(717, 26);
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
			this.laySunHao.Height = 29;
			this.laySunHao.MinSize = new global::System.Drawing.Size(64, 18);
			this.laySunHao.Name = "laySunHao";
			this.laySunHao.Text = "SunHao";
			this.laySunHao.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.laySunHao.Width = 100;
			this.laySunHao.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layAdd.Height = 31;
			this.layAdd.MinSize = new global::System.Drawing.Size(32, 20);
			this.layAdd.Name = "layAdd";
			this.layAdd.Text = " ";
			this.layAdd.Width = 160;
			this.splitContainer1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new global::System.Drawing.Point(0, 26);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = global::System.Windows.Forms.Orientation.Horizontal;
			this.splitContainer1.Panel1.Controls.Add(this.layoutControl2);
			this.splitContainer1.Panel2.Controls.Add(this.layoutControl1);
			this.splitContainer1.Size = new global::System.Drawing.Size(717, 442);
			this.splitContainer1.SplitterDistance = 96;
			this.splitContainer1.TabIndex = 20;
			this.layoutControl2.Controls.Add(this.tbxInvCode);
			this.layoutControl2.Controls.Add(this.tbxInvName);
			this.layoutControl2.Controls.Add(this.tbxDanHao);
			this.layoutControl2.Controls.Add(this.btnAdd);
			this.layoutControl2.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.layoutControl2.Location = new global::System.Drawing.Point(0, 0);
			this.layoutControl2.Name = "layoutControl2";
			this.layoutControl2.RootGroup.Items.AddRange(new global::DevComponents.DotNetBar.Layout.LayoutItemBase[]
			{
				this.layoutControlItem1,
				this.layoutControlItem7,
				this.layoutControlItem8,
				this.layoutControlItem2
			});
			this.layoutControl2.Size = new global::System.Drawing.Size(717, 96);
			this.layoutControl2.TabIndex = 22;
			this.tbxInvCode.Border.Class = "TextBoxBorder";
			this.tbxInvCode.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.tbxInvCode.Location = new global::System.Drawing.Point(55, 33);
			this.tbxInvCode.Margin = new global::System.Windows.Forms.Padding(0);
			this.tbxInvCode.Name = "tbxInvCode";
			this.tbxInvCode.PreventEnterBeep = true;
			this.tbxInvCode.Size = new global::System.Drawing.Size(299, 21);
			this.tbxInvCode.TabIndex = 1;
			this.tbxInvName.Border.Class = "TextBoxBorder";
			this.tbxInvName.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.tbxInvName.Location = new global::System.Drawing.Point(413, 33);
			this.tbxInvName.Margin = new global::System.Windows.Forms.Padding(0);
			this.tbxInvName.MaxLength = 200;
			this.tbxInvName.Name = "tbxInvName";
			this.tbxInvName.PreventEnterBeep = true;
			this.tbxInvName.Size = new global::System.Drawing.Size(300, 21);
			this.tbxInvName.TabIndex = 2;
			this.tbxDanHao.Border.Class = "TextBoxBorder";
			this.tbxDanHao.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.tbxDanHao.Location = new global::System.Drawing.Point(55, 4);
			this.tbxDanHao.Margin = new global::System.Windows.Forms.Padding(0);
			this.tbxDanHao.MaxLength = 20;
			this.tbxDanHao.Name = "tbxDanHao";
			this.tbxDanHao.PreventEnterBeep = true;
			this.tbxDanHao.Size = new global::System.Drawing.Size(658, 21);
			this.tbxDanHao.TabIndex = 0;
			this.btnAdd.AccessibleRole = global::System.Windows.Forms.AccessibleRole.PushButton;
			this.btnAdd.ColorTable = global::DevComponents.DotNetBar.eButtonColor.Orange;
			this.btnAdd.Image = global::SQSClient.Properties.Resources.add16;
			this.btnAdd.Location = new global::System.Drawing.Point(4, 62);
			this.btnAdd.Margin = new global::System.Windows.Forms.Padding(0);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new global::System.Drawing.Size(70, 23);
			this.btnAdd.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.btnAdd.TabIndex = 3;
			this.btnAdd.Text = "New";
			this.btnAdd.TextAlignment = global::DevComponents.DotNetBar.eButtonTextAlignment.Left;
			this.btnAdd.Tooltip = "增加物料";
			this.btnAdd.Click += new global::System.EventHandler(this.btnAdd_Click);
			this.layoutControlItem1.Control = this.tbxDanHao;
			this.layoutControlItem1.Height = 29;
			this.layoutControlItem1.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Text = "DanHao";
			this.layoutControlItem1.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem1.Width = 100;
			this.layoutControlItem1.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem7.Control = this.tbxInvCode;
			this.layoutControlItem7.Height = 29;
			this.layoutControlItem7.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem7.Name = "layoutControlItem7";
			this.layoutControlItem7.Text = "InvCode";
			this.layoutControlItem7.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem7.Width = 50;
			this.layoutControlItem7.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem8.Control = this.tbxInvName;
			this.layoutControlItem8.Height = 29;
			this.layoutControlItem8.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem8.Name = "layoutControlItem8";
			this.layoutControlItem8.Text = "InvName";
			this.layoutControlItem8.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem8.Width = 50;
			this.layoutControlItem8.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem2.Control = this.btnAdd;
			this.layoutControlItem2.Height = 31;
			this.layoutControlItem2.MinSize = new global::System.Drawing.Size(32, 20);
			this.layoutControlItem2.Name = "layoutControlItem2";
			this.layoutControlItem2.Width = 78;
			this.layoutControl1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.layoutControl1.Location = new global::System.Drawing.Point(0, 0);
			this.layoutControl1.Name = "layoutControl1";
			this.layoutControl1.Size = new global::System.Drawing.Size(717, 342);
			this.layoutControl1.TabIndex = 21;
			base.ClientSize = new global::System.Drawing.Size(717, 468);
			base.Controls.Add(this.splitContainer1);
			base.Controls.Add(this.menuBar);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "frmTicketBatchShow";
			this.Text = "frmTicketBatchShow";
			base.Load += new global::System.EventHandler(this.frmTicketBatchShow_Load);
			((global::System.ComponentModel.ISupportInitialize)this.menuBar).EndInit();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.splitContainer1).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.layoutControl2.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x04000976 RID: 2422
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000977 RID: 2423
		private global::DevComponents.DotNetBar.Bar menuBar;

		// Token: 0x04000978 RID: 2424
		private global::DevComponents.DotNetBar.ButtonItem btnSave;

		// Token: 0x04000979 RID: 2425
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem laySunHao;

		// Token: 0x0400097A RID: 2426
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layAdd;

		// Token: 0x0400097B RID: 2427
		private global::System.Windows.Forms.SplitContainer splitContainer1;

		// Token: 0x0400097C RID: 2428
		private global::DevComponents.DotNetBar.Layout.LayoutControl layoutControl2;

		// Token: 0x0400097D RID: 2429
		private global::DevComponents.DotNetBar.Controls.TextBoxX tbxInvCode;

		// Token: 0x0400097E RID: 2430
		private global::DevComponents.DotNetBar.Controls.TextBoxX tbxInvName;

		// Token: 0x0400097F RID: 2431
		private global::DevComponents.DotNetBar.Controls.TextBoxX tbxDanHao;

		// Token: 0x04000980 RID: 2432
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem1;

		// Token: 0x04000981 RID: 2433
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem7;

		// Token: 0x04000982 RID: 2434
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem8;

		// Token: 0x04000983 RID: 2435
		private global::DevComponents.DotNetBar.ButtonX btnAdd;

		// Token: 0x04000984 RID: 2436
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem2;

		// Token: 0x04000985 RID: 2437
		private global::DevComponents.DotNetBar.Layout.LayoutControl layoutControl1;
	}
}
