namespace SQSClient
{
	// Token: 0x0200000B RID: 11
	public partial class BaseDialogForm : global::Base.BaseForm
	{
		// Token: 0x0600005F RID: 95 RVA: 0x00003D28 File Offset: 0x00001F28
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00003D60 File Offset: 0x00001F60
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::SQSClient.BaseDialogForm));
			this.toolTip = new global::System.Windows.Forms.ToolTip(this.components);
			base.SuspendLayout();
			this.toolTip.AutoPopDelay = 5000;
			this.toolTip.InitialDelay = 500;
			this.toolTip.ReshowDelay = 100;
			this.toolTip.Draw += new global::System.Windows.Forms.DrawToolTipEventHandler(this.toolTip_Draw);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Inherit;
			base.ClientSize = new global::System.Drawing.Size(378, 327);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "BaseDialogForm";
			base.Load += new global::System.EventHandler(this.BaseDialogForm_Load);
			base.ResumeLayout(false);
		}

		// Token: 0x0400001D RID: 29
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400001E RID: 30
		private global::System.Windows.Forms.ToolTip toolTip;
	}
}
