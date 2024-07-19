namespace SQSClient
{
	// Token: 0x02000071 RID: 113
	public partial class frmPrintChoise : global::SQSClient.BaseDialogForm
	{
		// Token: 0x06000629 RID: 1577 RVA: 0x000997E4 File Offset: 0x000979E4
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600062A RID: 1578 RVA: 0x0009981C File Offset: 0x00097A1C
		private void InitializeComponent()
		{
			this.btnPrintShow = new global::DevComponents.DotNetBar.ButtonX();
			this.btnPrint = new global::DevComponents.DotNetBar.ButtonX();
			this.itemPanelFenCang = new global::DevComponents.DotNetBar.ItemPanel();
			base.SuspendLayout();
			this.btnPrintShow.AccessibleRole = global::System.Windows.Forms.AccessibleRole.PushButton;
			this.btnPrintShow.ColorTable = global::DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.btnPrintShow.Location = new global::System.Drawing.Point(206, 12);
			this.btnPrintShow.Name = "btnPrintShow";
			this.btnPrintShow.Size = new global::System.Drawing.Size(75, 23);
			this.btnPrintShow.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.btnPrintShow.TabIndex = 2;
			this.btnPrintShow.Text = "Preview";
			this.btnPrintShow.Click += new global::System.EventHandler(this.btnPrintShow_Click);
			this.btnPrint.AccessibleRole = global::System.Windows.Forms.AccessibleRole.PushButton;
			this.btnPrint.ColorTable = global::DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.btnPrint.Location = new global::System.Drawing.Point(206, 41);
			this.btnPrint.Name = "btnPrint";
			this.btnPrint.Size = new global::System.Drawing.Size(75, 23);
			this.btnPrint.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.btnPrint.TabIndex = 3;
			this.btnPrint.Text = "Print";
			this.btnPrint.Click += new global::System.EventHandler(this.btnPrint_Click);
			this.itemPanelFenCang.BackgroundStyle.Class = "ItemPanel";
			this.itemPanelFenCang.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.itemPanelFenCang.ContainerControlProcessDialogKey = true;
			this.itemPanelFenCang.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.itemPanelFenCang.DragDropSupport = true;
			this.itemPanelFenCang.LayoutOrientation = global::DevComponents.DotNetBar.eOrientation.Vertical;
			this.itemPanelFenCang.Location = new global::System.Drawing.Point(0, 0);
			this.itemPanelFenCang.Name = "itemPanelFenCang";
			this.itemPanelFenCang.Size = new global::System.Drawing.Size(200, 262);
			this.itemPanelFenCang.TabIndex = 4;
			this.itemPanelFenCang.Text = "itemPanel1";
			base.ClientSize = new global::System.Drawing.Size(284, 262);
			base.Controls.Add(this.itemPanelFenCang);
			base.Controls.Add(this.btnPrint);
			base.Controls.Add(this.btnPrintShow);
			base.Name = "frmPrintChoise";
			this.Text = "frmPrintChoise";
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.frmPrintChoise_FormClosing);
			base.Load += new global::System.EventHandler(this.frmPrintChoise_Load);
			base.ResumeLayout(false);
		}

		// Token: 0x04000A9B RID: 2715
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000A9C RID: 2716
		private global::DevComponents.DotNetBar.ButtonX btnPrintShow;

		// Token: 0x04000A9D RID: 2717
		private global::DevComponents.DotNetBar.ButtonX btnPrint;

		// Token: 0x04000A9E RID: 2718
		private global::DevComponents.DotNetBar.ItemPanel itemPanelFenCang;
	}
}
