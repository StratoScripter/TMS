﻿namespace SQSClient
{
	// Token: 0x02000082 RID: 130
	public partial class frmKeyCodeEdit : global::SQSClient.BaseDialogForm
	{
		// Token: 0x06000719 RID: 1817 RVA: 0x000B10E0 File Offset: 0x000AF2E0
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600071A RID: 1818 RVA: 0x000B1118 File Offset: 0x000AF318
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::SQSClient.frmKeyCodeEdit));
			this.menuBar = new global::DevComponents.DotNetBar.Bar();
			this.btnSave = new global::DevComponents.DotNetBar.ButtonItem();
			this.lcMain = new global::DevComponents.DotNetBar.Layout.LayoutControl();
			this.tbxKeyCode = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.tbxKeyValue = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.tbxRemark = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.layKeyword = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layValue = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.lciRemark = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
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
			this.menuBar.Size = new global::System.Drawing.Size(464, 26);
			this.menuBar.Stretch = true;
			this.menuBar.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.menuBar.TabIndex = 6;
			this.menuBar.TabStop = false;
			this.menuBar.Text = "Main Menu";
			this.btnSave.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.btnSave.Image = global::SQSClient.Properties.Resources.save16;
			this.btnSave.Name = "btnSave";
			this.btnSave.Text = "Save";
			this.btnSave.Click += new global::System.EventHandler(this.btnSave_Click);
			this.lcMain.Controls.Add(this.tbxKeyCode);
			this.lcMain.Controls.Add(this.tbxKeyValue);
			this.lcMain.Controls.Add(this.tbxRemark);
			this.lcMain.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.lcMain.Location = new global::System.Drawing.Point(0, 26);
			this.lcMain.Name = "lcMain";
			this.lcMain.RootGroup.Items.AddRange(new global::DevComponents.DotNetBar.Layout.LayoutItemBase[]
			{
				this.layKeyword,
				this.layValue,
				this.lciRemark
			});
			this.lcMain.Size = new global::System.Drawing.Size(464, 200);
			this.lcMain.TabIndex = 0;
			this.tbxKeyCode.Border.Class = "TextBoxBorder";
			this.tbxKeyCode.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.tbxKeyCode.DisabledBackColor = global::System.Drawing.Color.White;
			this.tbxKeyCode.Location = new global::System.Drawing.Point(55, 4);
			this.tbxKeyCode.Margin = new global::System.Windows.Forms.Padding(0);
			this.tbxKeyCode.Name = "tbxKeyCode";
			this.tbxKeyCode.PreventEnterBeep = true;
			this.tbxKeyCode.Size = new global::System.Drawing.Size(173, 21);
			this.tbxKeyCode.TabIndex = 0;
			this.tbxKeyValue.Border.Class = "TextBoxBorder";
			this.tbxKeyValue.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.tbxKeyValue.DisabledBackColor = global::System.Drawing.Color.White;
			this.tbxKeyValue.Location = new global::System.Drawing.Point(287, 4);
			this.tbxKeyValue.Margin = new global::System.Windows.Forms.Padding(0);
			this.tbxKeyValue.Name = "tbxKeyValue";
			this.tbxKeyValue.PreventEnterBeep = true;
			this.tbxKeyValue.Size = new global::System.Drawing.Size(173, 21);
			this.tbxKeyValue.TabIndex = 1;
			this.tbxRemark.Border.Class = "TextBoxBorder";
			this.tbxRemark.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.tbxRemark.DisabledBackColor = global::System.Drawing.Color.White;
			this.tbxRemark.Location = new global::System.Drawing.Point(4, 47);
			this.tbxRemark.Margin = new global::System.Windows.Forms.Padding(0);
			this.tbxRemark.Multiline = true;
			this.tbxRemark.Name = "tbxRemark";
			this.tbxRemark.PreventEnterBeep = true;
			this.tbxRemark.Size = new global::System.Drawing.Size(456, 149);
			this.tbxRemark.TabIndex = 2;
			this.layKeyword.Control = this.tbxKeyCode;
			this.layKeyword.Height = 26;
			this.layKeyword.MinSize = new global::System.Drawing.Size(120, 0);
			this.layKeyword.Name = "layKeyword";
			this.layKeyword.Text = "Keyword";
			this.layKeyword.Width = 50;
			this.layKeyword.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layValue.Control = this.tbxKeyValue;
			this.layValue.Height = 26;
			this.layValue.MinSize = new global::System.Drawing.Size(120, 0);
			this.layValue.Name = "layValue";
			this.layValue.Text = "Value";
			this.layValue.Width = 50;
			this.layValue.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.lciRemark.Control = this.tbxRemark;
			this.lciRemark.Height = 100;
			this.lciRemark.HeightType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.lciRemark.MinSize = new global::System.Drawing.Size(120, 0);
			this.lciRemark.Name = "lciRemark";
			this.lciRemark.Text = "Remark";
			this.lciRemark.TextPosition = global::DevComponents.DotNetBar.Layout.eLayoutPosition.Top;
			this.lciRemark.Width = 100;
			this.lciRemark.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			base.ClientSize = new global::System.Drawing.Size(464, 226);
			base.Controls.Add(this.lcMain);
			base.Controls.Add(this.menuBar);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "frmKeyCodeEdit";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "KeyCodeEdit";
			base.Load += new global::System.EventHandler(this.frmKeyCodeEdit_Load);
			((global::System.ComponentModel.ISupportInitialize)this.menuBar).EndInit();
			this.lcMain.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x04000C26 RID: 3110
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000C27 RID: 3111
		private global::DevComponents.DotNetBar.Bar menuBar;

		// Token: 0x04000C28 RID: 3112
		private global::DevComponents.DotNetBar.ButtonItem btnSave;

		// Token: 0x04000C29 RID: 3113
		private global::DevComponents.DotNetBar.Layout.LayoutControl lcMain;

		// Token: 0x04000C2A RID: 3114
		private global::DevComponents.DotNetBar.Controls.TextBoxX tbxKeyCode;

		// Token: 0x04000C2B RID: 3115
		private global::DevComponents.DotNetBar.Controls.TextBoxX tbxKeyValue;

		// Token: 0x04000C2C RID: 3116
		private global::DevComponents.DotNetBar.Controls.TextBoxX tbxRemark;

		// Token: 0x04000C2D RID: 3117
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layKeyword;

		// Token: 0x04000C2E RID: 3118
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layValue;

		// Token: 0x04000C2F RID: 3119
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem lciRemark;
	}
}
