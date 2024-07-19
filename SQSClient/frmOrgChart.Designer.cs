namespace SQSClient
{
	// Token: 0x02000030 RID: 48
	public partial class frmOrgChart : global::SQSClient.BaseDialogForm
	{
		// Token: 0x06000246 RID: 582 RVA: 0x00040B48 File Offset: 0x0003ED48
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000247 RID: 583 RVA: 0x00040B80 File Offset: 0x0003ED80
		private void InitializeComponent()
		{
			this.label_now = new global::System.Windows.Forms.Label();
			this.label_pre = new global::System.Windows.Forms.Label();
			this.label_next = new global::System.Windows.Forms.Label();
			base.SuspendLayout();
			this.label_now.AutoSize = true;
			this.label_now.Location = new global::System.Drawing.Point(274, 36);
			this.label_now.Name = "label_now";
			this.label_now.Size = new global::System.Drawing.Size(56, 17);
			this.label_now.TabIndex = 0;
			this.label_now.Text = "当前步骤";
			this.label_pre.AutoSize = true;
			this.label_pre.Location = new global::System.Drawing.Point(91, 36);
			this.label_pre.Name = "label_pre";
			this.label_pre.Size = new global::System.Drawing.Size(56, 17);
			this.label_pre.TabIndex = 1;
			this.label_pre.Text = "前一步骤";
			this.label_next.AutoSize = true;
			this.label_next.Location = new global::System.Drawing.Point(465, 36);
			this.label_next.Name = "label_next";
			this.label_next.Size = new global::System.Drawing.Size(56, 17);
			this.label_next.TabIndex = 2;
			this.label_next.Text = "后一步骤";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(7f, 17f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.SystemColors.GradientInactiveCaption;
			base.ClientSize = new global::System.Drawing.Size(619, 282);
			base.Controls.Add(this.label_next);
			base.Controls.Add(this.label_pre);
			base.Controls.Add(this.label_now);
			this.Cursor = global::System.Windows.Forms.Cursors.Default;
			this.Font = new global::System.Drawing.Font("微软雅黑", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 134);
			this.ForeColor = global::System.Drawing.SystemColors.ControlText;
			base.Margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			base.MaximizeBox = false;
			base.Name = "frmOrgChart";
			base.ShowIcon = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "流程信息";
			base.Load += new global::System.EventHandler(this.FormOrgChart_Load);
			base.Paint += new global::System.Windows.Forms.PaintEventHandler(this.FormOrgChart_Paint);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000408 RID: 1032
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000409 RID: 1033
		private global::System.Windows.Forms.Label label_now;

		// Token: 0x0400040A RID: 1034
		private global::System.Windows.Forms.Label label_pre;

		// Token: 0x0400040B RID: 1035
		private global::System.Windows.Forms.Label label_next;
	}
}
