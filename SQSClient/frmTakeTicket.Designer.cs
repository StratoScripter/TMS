namespace SQSClient
{
	// Token: 0x02000044 RID: 68
	public partial class frmTakeTicket : global::SQSClient.BaseDialogForm
	{
		// Token: 0x0600030D RID: 781 RVA: 0x0004CD84 File Offset: 0x0004AF84
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600030E RID: 782 RVA: 0x0004CDBC File Offset: 0x0004AFBC
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::SQSClient.frmTakeTicket));
			this.bar = new global::DevComponents.DotNetBar.Bar();
			this.line2 = new global::DevComponents.DotNetBar.Controls.Line();
			this.btnAdd = new global::DevComponents.DotNetBar.ButtonItem();
			this.controlContainerItem1 = new global::DevComponents.DotNetBar.ControlContainerItem();
			this.LabIDCard = new global::DevComponents.DotNetBar.LabelItem();
			this.txtIdCardNo = new global::DevComponents.DotNetBar.TextBoxItem();
			this.btnSearch = new global::DevComponents.DotNetBar.ButtonItem();
			this.LabICCard = new global::DevComponents.DotNetBar.LabelItem();
			this.txtCardNum = new global::DevComponents.DotNetBar.TextBoxItem();
			this.panelBody = new global::System.Windows.Forms.FlowLayoutPanel();
			this.btnReadCard = new global::DevComponents.DotNetBar.ButtonItem();
			((global::System.ComponentModel.ISupportInitialize)this.bar).BeginInit();
			this.bar.SuspendLayout();
			base.SuspendLayout();
			this.bar.AntiAlias = true;
			this.bar.Controls.Add(this.line2);
			this.bar.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.bar.Font = new global::System.Drawing.Font("微软雅黑", 9f);
			this.bar.IsMaximized = false;
			this.bar.Items.AddRange(new global::DevComponents.DotNetBar.BaseItem[]
			{
				this.btnAdd,
				this.controlContainerItem1,
				this.LabIDCard,
				this.txtIdCardNo,
				this.btnSearch,
				this.LabICCard,
				this.txtCardNum,
				this.btnReadCard
			});
			this.bar.Location = new global::System.Drawing.Point(0, 0);
			this.bar.Name = "bar";
			this.bar.Size = new global::System.Drawing.Size(1145, 27);
			this.bar.Stretch = true;
			this.bar.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.bar.TabIndex = 0;
			this.bar.TabStop = false;
			this.bar.Text = "bar1";
			this.line2.ForeColor = global::System.Drawing.SystemColors.ActiveCaption;
			this.line2.Location = new global::System.Drawing.Point(92, 3);
			this.line2.Name = "line2";
			this.line2.Size = new global::System.Drawing.Size(1, 20);
			this.line2.TabIndex = 17;
			this.line2.Text = "line2";
			this.line2.VerticalLine = true;
			this.btnAdd.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.btnAdd.Image = global::SQSClient.Properties.Resources.add16;
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Text = "AddTicket";
			this.btnAdd.Click += new global::System.EventHandler(this.btnAdd_Click);
			this.controlContainerItem1.AllowItemResize = false;
			this.controlContainerItem1.Control = this.line2;
			this.controlContainerItem1.MenuVisibility = global::DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
			this.controlContainerItem1.Name = "controlContainerItem1";
			this.LabIDCard.Name = "LabIDCard";
			this.LabIDCard.Text = "IDCard";
			this.txtIdCardNo.MaxLength = 50;
			this.txtIdCardNo.Name = "txtIdCardNo";
			this.txtIdCardNo.TextBoxWidth = 200;
			this.txtIdCardNo.WatermarkColor = global::System.Drawing.SystemColors.GrayText;
			this.txtIdCardNo.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
			this.btnSearch.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.btnSearch.Image = global::SQSClient.Properties.Resources.search16;
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Text = "Search";
			this.btnSearch.Click += new global::System.EventHandler(this.btnSearch_Click);
			this.LabICCard.Name = "LabICCard";
			this.LabICCard.Text = "IC";
			this.txtCardNum.Name = "txtCardNum";
			this.txtCardNum.TextBoxWidth = 120;
			this.txtCardNum.WatermarkColor = global::System.Drawing.SystemColors.GrayText;
			this.panelBody.AutoScroll = true;
			this.panelBody.BackColor = global::System.Drawing.Color.White;
			this.panelBody.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.panelBody.Location = new global::System.Drawing.Point(0, 27);
			this.panelBody.Name = "panelBody";
			this.panelBody.Size = new global::System.Drawing.Size(1145, 486);
			this.panelBody.TabIndex = 99;
			this.btnReadCard.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.btnReadCard.Image = global::SQSClient.Properties.Resources.search16;
			this.btnReadCard.Name = "btnReadCard";
			this.btnReadCard.Text = "ReadCard";
			this.btnReadCard.Click += new global::System.EventHandler(this.btnReadCard_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 12f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(1145, 513);
			base.Controls.Add(this.panelBody);
			base.Controls.Add(this.bar);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "frmTakeTicket";
			this.Text = "IDCard";
			base.Load += new global::System.EventHandler(this.frmTakeTicket_Load);
			((global::System.ComponentModel.ISupportInitialize)this.bar).EndInit();
			this.bar.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x040004D0 RID: 1232
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x040004D1 RID: 1233
		private global::DevComponents.DotNetBar.Bar bar;

		// Token: 0x040004D2 RID: 1234
		private global::DevComponents.DotNetBar.ButtonItem btnAdd;

		// Token: 0x040004D3 RID: 1235
		private global::DevComponents.DotNetBar.LabelItem LabIDCard;

		// Token: 0x040004D4 RID: 1236
		private global::DevComponents.DotNetBar.TextBoxItem txtIdCardNo;

		// Token: 0x040004D5 RID: 1237
		private global::DevComponents.DotNetBar.ButtonItem btnSearch;

		// Token: 0x040004D6 RID: 1238
		private global::DevComponents.DotNetBar.Controls.Line line2;

		// Token: 0x040004D7 RID: 1239
		private global::DevComponents.DotNetBar.ControlContainerItem controlContainerItem1;

		// Token: 0x040004D8 RID: 1240
		private global::System.Windows.Forms.FlowLayoutPanel panelBody;

		// Token: 0x040004D9 RID: 1241
		private global::DevComponents.DotNetBar.LabelItem LabICCard;

		// Token: 0x040004DA RID: 1242
		private global::DevComponents.DotNetBar.TextBoxItem txtCardNum;

		// Token: 0x040004DB RID: 1243
		private global::DevComponents.DotNetBar.ButtonItem btnReadCard;
	}
}
