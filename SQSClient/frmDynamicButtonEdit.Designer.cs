namespace SQSClient
{
	// Token: 0x0200002B RID: 43
	public partial class frmDynamicButtonEdit : global::SQSClient.BaseDialogForm
	{
		// Token: 0x0600021E RID: 542 RVA: 0x0003DD80 File Offset: 0x0003BF80
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600021F RID: 543 RVA: 0x0003DDB8 File Offset: 0x0003BFB8
		private void InitializeComponent()
		{
			this.menuBar = new global::DevComponents.DotNetBar.Bar();
			this.btnSave = new global::DevComponents.DotNetBar.ButtonItem();
			this.lcMain = new global::DevComponents.DotNetBar.Layout.LayoutControl();
			this.txtButtonText = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.txtButtonName = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.txtScreenName = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.txtParentControl = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.layoutControlItem2 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.lciName = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layPointCode = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem8 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem1 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem3 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem5 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem7 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			((global::System.ComponentModel.ISupportInitialize)this.menuBar).BeginInit();
			this.lcMain.SuspendLayout();
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
			this.menuBar.Size = new global::System.Drawing.Size(554, 26);
			this.menuBar.Stretch = true;
			this.menuBar.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.menuBar.TabIndex = 8;
			this.menuBar.TabStop = false;
			this.menuBar.Text = "Main Menu";
			this.btnSave.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.btnSave.Image = global::SQSClient.Properties.Resources.save16;
			this.btnSave.Name = "btnSave";
			this.btnSave.Text = "Save";
			this.btnSave.Click += new global::System.EventHandler(this.btnSave_Click);
			this.lcMain.Controls.Add(this.txtButtonText);
			this.lcMain.Controls.Add(this.txtButtonName);
			this.lcMain.Controls.Add(this.txtScreenName);
			this.lcMain.Controls.Add(this.txtParentControl);
			this.lcMain.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.lcMain.Location = new global::System.Drawing.Point(0, 26);
			this.lcMain.Name = "lcMain";
			this.lcMain.RootGroup.Items.AddRange(new global::DevComponents.DotNetBar.Layout.LayoutItemBase[]
			{
				this.layoutControlItem2,
				this.lciName,
				this.layPointCode,
				this.layoutControlItem8
			});
			this.lcMain.Size = new global::System.Drawing.Size(554, 60);
			this.lcMain.TabIndex = 0;
			this.txtButtonText.Border.Class = "TextBoxBorder";
			this.txtButtonText.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtButtonText.Location = new global::System.Drawing.Point(92, 33);
			this.txtButtonText.Margin = new global::System.Windows.Forms.Padding(0);
			this.txtButtonText.Name = "txtButtonText";
			this.txtButtonText.PreventEnterBeep = true;
			this.txtButtonText.Size = new global::System.Drawing.Size(181, 21);
			this.txtButtonText.TabIndex = 2;
			this.txtButtonName.Border.Class = "TextBoxBorder";
			this.txtButtonName.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtButtonName.Location = new global::System.Drawing.Point(369, 4);
			this.txtButtonName.Margin = new global::System.Windows.Forms.Padding(0);
			this.txtButtonName.Name = "txtButtonName";
			this.txtButtonName.PreventEnterBeep = true;
			this.txtButtonName.Size = new global::System.Drawing.Size(181, 21);
			this.txtButtonName.TabIndex = 1;
			this.txtScreenName.Border.Class = "TextBoxBorder";
			this.txtScreenName.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtScreenName.Location = new global::System.Drawing.Point(92, 4);
			this.txtScreenName.Margin = new global::System.Windows.Forms.Padding(0);
			this.txtScreenName.Name = "txtScreenName";
			this.txtScreenName.PreventEnterBeep = true;
			this.txtScreenName.Size = new global::System.Drawing.Size(181, 21);
			this.txtScreenName.TabIndex = 0;
			this.txtParentControl.Border.Class = "TextBoxBorder";
			this.txtParentControl.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtParentControl.Location = new global::System.Drawing.Point(369, 33);
			this.txtParentControl.Margin = new global::System.Windows.Forms.Padding(0);
			this.txtParentControl.Name = "txtParentControl";
			this.txtParentControl.PreventEnterBeep = true;
			this.txtParentControl.Size = new global::System.Drawing.Size(181, 21);
			this.txtParentControl.TabIndex = 3;
			this.layoutControlItem2.Control = this.txtScreenName;
			this.layoutControlItem2.Height = 29;
			this.layoutControlItem2.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem2.Name = "layoutControlItem2";
			this.layoutControlItem2.Text = "ScreenName";
			this.layoutControlItem2.Width = 50;
			this.layoutControlItem2.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.lciName.Control = this.txtButtonName;
			this.lciName.Height = 29;
			this.lciName.MinSize = new global::System.Drawing.Size(120, 0);
			this.lciName.Name = "lciName";
			this.lciName.Text = "ButtonName";
			this.lciName.Width = 50;
			this.lciName.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layPointCode.Control = this.txtButtonText;
			this.layPointCode.Height = 29;
			this.layPointCode.MinSize = new global::System.Drawing.Size(120, 0);
			this.layPointCode.Name = "layPointCode";
			this.layPointCode.Text = "ButtonText";
			this.layPointCode.Width = 50;
			this.layPointCode.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem8.Control = this.txtParentControl;
			this.layoutControlItem8.Height = 29;
			this.layoutControlItem8.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem8.Name = "layoutControlItem8";
			this.layoutControlItem8.Text = "ParentControl";
			this.layoutControlItem8.Width = 50;
			this.layoutControlItem8.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem1.Control = this.txtScreenName;
			this.layoutControlItem1.Height = 26;
			this.layoutControlItem1.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Text = "编码";
			this.layoutControlItem1.Width = 33;
			this.layoutControlItem1.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem3.Height = 26;
			this.layoutControlItem3.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem3.Name = "layoutControlItem3";
			this.layoutControlItem3.Text = "路号";
			this.layoutControlItem3.Width = 33;
			this.layoutControlItem3.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem5.Height = 28;
			this.layoutControlItem5.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem5.Name = "layoutControlItem5";
			this.layoutControlItem5.Text = "类型";
			this.layoutControlItem5.Width = 33;
			this.layoutControlItem5.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem7.Control = this.txtParentControl;
			this.layoutControlItem7.Height = 26;
			this.layoutControlItem7.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem7.Name = "layoutControlItem7";
			this.layoutControlItem7.Text = "参数";
			this.layoutControlItem7.Width = 33;
			this.layoutControlItem7.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			base.ClientSize = new global::System.Drawing.Size(554, 86);
			base.Controls.Add(this.lcMain);
			base.Controls.Add(this.menuBar);
			base.Name = "frmDynamicButtonEdit";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "DynamicButtonEdit";
			base.Load += new global::System.EventHandler(this.frmDynamicButtonEdit_Load);
			((global::System.ComponentModel.ISupportInitialize)this.menuBar).EndInit();
			this.lcMain.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x040003CF RID: 975
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x040003D0 RID: 976
		private global::DevComponents.DotNetBar.Bar menuBar;

		// Token: 0x040003D1 RID: 977
		private global::DevComponents.DotNetBar.ButtonItem btnSave;

		// Token: 0x040003D2 RID: 978
		private global::DevComponents.DotNetBar.Layout.LayoutControl lcMain;

		// Token: 0x040003D3 RID: 979
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtButtonText;

		// Token: 0x040003D4 RID: 980
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtButtonName;

		// Token: 0x040003D5 RID: 981
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layPointCode;

		// Token: 0x040003D6 RID: 982
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem lciName;

		// Token: 0x040003D7 RID: 983
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtScreenName;

		// Token: 0x040003D8 RID: 984
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem2;

		// Token: 0x040003D9 RID: 985
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem1;

		// Token: 0x040003DA RID: 986
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem3;

		// Token: 0x040003DB RID: 987
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem5;

		// Token: 0x040003DC RID: 988
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtParentControl;

		// Token: 0x040003DD RID: 989
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem8;

		// Token: 0x040003DE RID: 990
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem7;
	}
}
