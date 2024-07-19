namespace SQSClient.Monitor
{
	// Token: 0x020000A5 RID: 165
	public partial class frmLogDetail : global::SQSClient.BaseDialogForm
	{
		// Token: 0x06000977 RID: 2423 RVA: 0x000DDA48 File Offset: 0x000DBC48
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000978 RID: 2424 RVA: 0x000DDA80 File Offset: 0x000DBC80
		private void InitializeComponent()
		{
			this.layKeyword = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.tbxClassName = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.lcMain = new global::DevComponents.DotNetBar.Layout.LayoutControl();
			this.tbxMethod = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.tbxRemark = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.layValue = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.lciRemark = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.lcMain.SuspendLayout();
			base.SuspendLayout();
			this.layKeyword.Control = this.tbxClassName;
			this.layKeyword.Height = 26;
			this.layKeyword.MinSize = new global::System.Drawing.Size(120, 0);
			this.layKeyword.Name = "layKeyword";
			this.layKeyword.Text = "ClassName";
			this.layKeyword.Width = 50;
			this.layKeyword.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.tbxClassName.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.tbxClassName.Border.Class = "TextBoxBorder";
			this.tbxClassName.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.tbxClassName.DisabledBackColor = global::System.Drawing.Color.White;
			this.tbxClassName.Location = new global::System.Drawing.Point(67, 4);
			this.tbxClassName.Margin = new global::System.Windows.Forms.Padding(0);
			this.tbxClassName.Name = "tbxClassName";
			this.tbxClassName.PreventEnterBeep = true;
			this.tbxClassName.ReadOnly = true;
			this.tbxClassName.Size = new global::System.Drawing.Size(315, 21);
			this.tbxClassName.TabIndex = 0;
			this.lcMain.Controls.Add(this.tbxClassName);
			this.lcMain.Controls.Add(this.tbxMethod);
			this.lcMain.Controls.Add(this.tbxRemark);
			this.lcMain.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.lcMain.Location = new global::System.Drawing.Point(0, 0);
			this.lcMain.Name = "lcMain";
			this.lcMain.RootGroup.Items.AddRange(new global::DevComponents.DotNetBar.Layout.LayoutItemBase[]
			{
				this.layKeyword,
				this.layValue,
				this.lciRemark
			});
			this.lcMain.Size = new global::System.Drawing.Size(772, 469);
			this.lcMain.TabIndex = 7;
			this.tbxMethod.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.tbxMethod.Border.Class = "TextBoxBorder";
			this.tbxMethod.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.tbxMethod.DisabledBackColor = global::System.Drawing.Color.White;
			this.tbxMethod.Location = new global::System.Drawing.Point(453, 4);
			this.tbxMethod.Margin = new global::System.Windows.Forms.Padding(0);
			this.tbxMethod.Name = "tbxMethod";
			this.tbxMethod.PreventEnterBeep = true;
			this.tbxMethod.ReadOnly = true;
			this.tbxMethod.Size = new global::System.Drawing.Size(315, 21);
			this.tbxMethod.TabIndex = 1;
			this.tbxRemark.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.tbxRemark.Border.Class = "TextBoxBorder";
			this.tbxRemark.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.tbxRemark.DisabledBackColor = global::System.Drawing.Color.White;
			this.tbxRemark.Location = new global::System.Drawing.Point(4, 47);
			this.tbxRemark.Margin = new global::System.Windows.Forms.Padding(0);
			this.tbxRemark.Multiline = true;
			this.tbxRemark.Name = "tbxRemark";
			this.tbxRemark.PreventEnterBeep = true;
			this.tbxRemark.ReadOnly = true;
			this.tbxRemark.ScrollBars = global::System.Windows.Forms.ScrollBars.Both;
			this.tbxRemark.Size = new global::System.Drawing.Size(764, 418);
			this.tbxRemark.TabIndex = 2;
			this.layValue.Control = this.tbxMethod;
			this.layValue.Height = 26;
			this.layValue.MinSize = new global::System.Drawing.Size(120, 0);
			this.layValue.Name = "layValue";
			this.layValue.Text = "Method";
			this.layValue.Width = 50;
			this.layValue.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.lciRemark.Control = this.tbxRemark;
			this.lciRemark.Height = 100;
			this.lciRemark.HeightType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.lciRemark.MinSize = new global::System.Drawing.Size(120, 0);
			this.lciRemark.Name = "lciRemark";
			this.lciRemark.Text = "Detail";
			this.lciRemark.TextPosition = global::DevComponents.DotNetBar.Layout.eLayoutPosition.Top;
			this.lciRemark.Width = 100;
			this.lciRemark.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 12f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(772, 469);
			base.Controls.Add(this.lcMain);
			base.Name = "frmLogDetail";
			this.Text = "frmLogDetail";
			base.Load += new global::System.EventHandler(this.frmLogDetail_Load);
			this.lcMain.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x04000F70 RID: 3952
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000F71 RID: 3953
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layKeyword;

		// Token: 0x04000F72 RID: 3954
		private global::DevComponents.DotNetBar.Controls.TextBoxX tbxClassName;

		// Token: 0x04000F73 RID: 3955
		private global::DevComponents.DotNetBar.Layout.LayoutControl lcMain;

		// Token: 0x04000F74 RID: 3956
		private global::DevComponents.DotNetBar.Controls.TextBoxX tbxMethod;

		// Token: 0x04000F75 RID: 3957
		private global::DevComponents.DotNetBar.Controls.TextBoxX tbxRemark;

		// Token: 0x04000F76 RID: 3958
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layValue;

		// Token: 0x04000F77 RID: 3959
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem lciRemark;
	}
}
