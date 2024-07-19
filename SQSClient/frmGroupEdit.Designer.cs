namespace SQSClient
{
	// Token: 0x0200007C RID: 124
	public partial class frmGroupEdit : global::SQSClient.BaseDialogForm
	{
		// Token: 0x060006D9 RID: 1753 RVA: 0x000A8908 File Offset: 0x000A6B08
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060006DA RID: 1754 RVA: 0x000A8940 File Offset: 0x000A6B40
		private void InitializeComponent()
		{
			this.menuBar = new global::DevComponents.DotNetBar.Bar();
			this.btnSave = new global::DevComponents.DotNetBar.ButtonItem();
			this.layoutControl1 = new global::DevComponents.DotNetBar.Layout.LayoutControl();
			this.iInputLevel = new global::DevComponents.Editors.IntegerInput();
			this.rtbRemark = new global::DevComponents.DotNetBar.Controls.RichTextBoxEx();
			this.chkState = new global::DevComponents.DotNetBar.Controls.CheckBoxX();
			this.txtName = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.layName = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem1 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layState = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layRemark = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			((global::System.ComponentModel.ISupportInitialize)this.menuBar).BeginInit();
			this.layoutControl1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.iInputLevel).BeginInit();
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
			this.menuBar.TabIndex = 19;
			this.menuBar.TabStop = false;
			this.menuBar.Text = "Main Menu";
			this.btnSave.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.btnSave.Image = global::SQSClient.Properties.Resources.save16;
			this.btnSave.Name = "btnSave";
			this.btnSave.Text = "Save";
			this.btnSave.Click += new global::System.EventHandler(this.btnSave_Click);
			this.layoutControl1.Controls.Add(this.iInputLevel);
			this.layoutControl1.Controls.Add(this.rtbRemark);
			this.layoutControl1.Controls.Add(this.chkState);
			this.layoutControl1.Controls.Add(this.txtName);
			this.layoutControl1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.layoutControl1.Location = new global::System.Drawing.Point(0, 26);
			this.layoutControl1.Name = "layoutControl1";
			this.layoutControl1.RootGroup.Items.AddRange(new global::DevComponents.DotNetBar.Layout.LayoutItemBase[]
			{
				this.layName,
				this.layoutControlItem1,
				this.layState,
				this.layRemark
			});
			this.layoutControl1.Size = new global::System.Drawing.Size(354, 346);
			this.layoutControl1.TabIndex = 20;
			this.iInputLevel.BackgroundStyle.Class = "DateTimeInputBackground";
			this.iInputLevel.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.iInputLevel.ButtonFreeText.Shortcut = global::DevComponents.DotNetBar.eShortcut.F2;
			this.iInputLevel.InputHorizontalAlignment = global::DevComponents.Editors.eHorizontalAlignment.Left;
			this.iInputLevel.Location = new global::System.Drawing.Point(67, 33);
			this.iInputLevel.Margin = new global::System.Windows.Forms.Padding(0);
			this.iInputLevel.MinValue = 0;
			this.iInputLevel.Name = "iInputLevel";
			this.iInputLevel.ShowUpDown = true;
			this.iInputLevel.Size = new global::System.Drawing.Size(283, 21);
			this.iInputLevel.TabIndex = 1;
			this.rtbRemark.BackgroundStyle.Class = "RichTextBoxBorder";
			this.rtbRemark.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.rtbRemark.Location = new global::System.Drawing.Point(67, 93);
			this.rtbRemark.Margin = new global::System.Windows.Forms.Padding(0);
			this.rtbRemark.Name = "rtbRemark";
			this.rtbRemark.Rtf = "{\\rtf1\\ansi\\ansicpg936\\deff0\\deflang1033\\deflangfe2052{\\fonttbl{\\f0\\fnil\\fcharset134 \\'cb\\'ce\\'cc\\'e5;}}\r\n\\viewkind4\\uc1\\pard\\lang2052\\f0\\fs18\\par\r\n}\r\n";
			this.rtbRemark.Size = new global::System.Drawing.Size(283, 50);
			this.rtbRemark.TabIndex = 3;
			this.chkState.AutoSize = true;
			this.chkState.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.chkState.Checked = true;
			this.chkState.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.chkState.CheckValue = "Y";
			this.chkState.Location = new global::System.Drawing.Point(67, 62);
			this.chkState.Margin = new global::System.Windows.Forms.Padding(0);
			this.chkState.Name = "chkState";
			this.chkState.Size = new global::System.Drawing.Size(64, 16);
			this.chkState.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.chkState.TabIndex = 2;
			this.chkState.Text = "Enable";
			this.txtName.Border.Class = "TextBoxBorder";
			this.txtName.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtName.Location = new global::System.Drawing.Point(67, 4);
			this.txtName.Margin = new global::System.Windows.Forms.Padding(0);
			this.txtName.Name = "txtName";
			this.txtName.PreventEnterBeep = true;
			this.txtName.Size = new global::System.Drawing.Size(283, 21);
			this.txtName.TabIndex = 0;
			this.layName.Control = this.txtName;
			this.layName.Height = 29;
			this.layName.MinSize = new global::System.Drawing.Size(120, 0);
			this.layName.Name = "layName";
			this.layName.Text = "GroupName";
			this.layName.Width = 100;
			this.layName.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem1.Control = this.iInputLevel;
			this.layoutControlItem1.Height = 29;
			this.layoutControlItem1.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Text = "Level";
			this.layoutControlItem1.Width = 100;
			this.layoutControlItem1.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layState.Control = this.chkState;
			this.layState.Height = 31;
			this.layState.MinSize = new global::System.Drawing.Size(64, 18);
			this.layState.Name = "layState";
			this.layState.Text = " ";
			this.layState.Width = 83;
			this.layState.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layRemark.Control = this.rtbRemark;
			this.layRemark.Height = 58;
			this.layRemark.MinSize = new global::System.Drawing.Size(64, 18);
			this.layRemark.Name = "layRemark";
			this.layRemark.Text = "Remark";
			this.layRemark.Width = 108;
			this.layRemark.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			base.ClientSize = new global::System.Drawing.Size(354, 372);
			base.Controls.Add(this.layoutControl1);
			base.Controls.Add(this.menuBar);
			base.Name = "frmGroupEdit";
			this.Text = "frmGroupEdit";
			base.Load += new global::System.EventHandler(this.frmGroupEdit_Load);
			((global::System.ComponentModel.ISupportInitialize)this.menuBar).EndInit();
			this.layoutControl1.ResumeLayout(false);
			this.layoutControl1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.iInputLevel).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000BA1 RID: 2977
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000BA2 RID: 2978
		private global::DevComponents.DotNetBar.Bar menuBar;

		// Token: 0x04000BA3 RID: 2979
		private global::DevComponents.DotNetBar.ButtonItem btnSave;

		// Token: 0x04000BA4 RID: 2980
		private global::DevComponents.DotNetBar.Layout.LayoutControl layoutControl1;

		// Token: 0x04000BA5 RID: 2981
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtName;

		// Token: 0x04000BA6 RID: 2982
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layName;

		// Token: 0x04000BA7 RID: 2983
		private global::DevComponents.DotNetBar.Controls.RichTextBoxEx rtbRemark;

		// Token: 0x04000BA8 RID: 2984
		private global::DevComponents.DotNetBar.Controls.CheckBoxX chkState;

		// Token: 0x04000BA9 RID: 2985
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layState;

		// Token: 0x04000BAA RID: 2986
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layRemark;

		// Token: 0x04000BAB RID: 2987
		private global::DevComponents.Editors.IntegerInput iInputLevel;

		// Token: 0x04000BAC RID: 2988
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem1;
	}
}
