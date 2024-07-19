namespace SQSClient
{
	// Token: 0x0200002E RID: 46
	public partial class frmPdaSettingEdit : global::SQSClient.BaseDialogForm
	{
		// Token: 0x0600023F RID: 575 RVA: 0x0003FD40 File Offset: 0x0003DF40
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000240 RID: 576 RVA: 0x0003FD78 File Offset: 0x0003DF78
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::SQSClient.frmPdaSettingEdit));
			this.menuBar = new global::DevComponents.DotNetBar.Bar();
			this.btnSave = new global::DevComponents.DotNetBar.ButtonItem();
			this.lcMain = new global::DevComponents.DotNetBar.Layout.LayoutControl();
			this.tbxKeyCode = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.tbxKeyValue = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.tbxRemark = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.tbxKeyName = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.layKeyword = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layValue = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem2 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.lciRemark = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem1 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
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
			this.lcMain.Controls.Add(this.tbxKeyName);
			this.lcMain.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.lcMain.Location = new global::System.Drawing.Point(0, 26);
			this.lcMain.Name = "lcMain";
			this.lcMain.RootGroup.Items.AddRange(new global::DevComponents.DotNetBar.Layout.LayoutItemBase[]
			{
				this.layKeyword,
				this.layValue,
				this.layoutControlItem2,
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
			this.tbxRemark.Location = new global::System.Drawing.Point(4, 76);
			this.tbxRemark.Margin = new global::System.Windows.Forms.Padding(0);
			this.tbxRemark.Multiline = true;
			this.tbxRemark.Name = "tbxRemark";
			this.tbxRemark.PreventEnterBeep = true;
			this.tbxRemark.Size = new global::System.Drawing.Size(456, 120);
			this.tbxRemark.TabIndex = 3;
			this.tbxKeyName.Border.Class = "TextBoxBorder";
			this.tbxKeyName.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.tbxKeyName.DisabledBackColor = global::System.Drawing.Color.White;
			this.tbxKeyName.Location = new global::System.Drawing.Point(55, 30);
			this.tbxKeyName.Margin = new global::System.Windows.Forms.Padding(0);
			this.tbxKeyName.Name = "tbxKeyName";
			this.tbxKeyName.PreventEnterBeep = true;
			this.tbxKeyName.Size = new global::System.Drawing.Size(405, 21);
			this.tbxKeyName.TabIndex = 2;
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
			this.layoutControlItem2.Control = this.tbxKeyName;
			this.layoutControlItem2.Height = 29;
			this.layoutControlItem2.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem2.Name = "layoutControlItem2";
			this.layoutControlItem2.Text = "Name";
			this.layoutControlItem2.Width = 100;
			this.layoutControlItem2.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.lciRemark.Control = this.tbxRemark;
			this.lciRemark.Height = 100;
			this.lciRemark.HeightType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.lciRemark.MinSize = new global::System.Drawing.Size(120, 0);
			this.lciRemark.Name = "lciRemark";
			this.lciRemark.Text = "Remark";
			this.lciRemark.TextPosition = global::DevComponents.DotNetBar.Layout.eLayoutPosition.Top;
			this.lciRemark.Width = 100;
			this.lciRemark.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem1.Control = this.tbxKeyName;
			this.layoutControlItem1.Height = 26;
			this.layoutControlItem1.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Text = "Value";
			this.layoutControlItem1.Width = 50;
			this.layoutControlItem1.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			base.ClientSize = new global::System.Drawing.Size(464, 226);
			base.Controls.Add(this.lcMain);
			base.Controls.Add(this.menuBar);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "frmPdaSettingEdit";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "frmSystemParaEdit";
			base.Load += new global::System.EventHandler(this.frmPdaSettingEdit_Load);
			((global::System.ComponentModel.ISupportInitialize)this.menuBar).EndInit();
			this.lcMain.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x040003F6 RID: 1014
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x040003F7 RID: 1015
		private global::DevComponents.DotNetBar.Bar menuBar;

		// Token: 0x040003F8 RID: 1016
		private global::DevComponents.DotNetBar.ButtonItem btnSave;

		// Token: 0x040003F9 RID: 1017
		private global::DevComponents.DotNetBar.Layout.LayoutControl lcMain;

		// Token: 0x040003FA RID: 1018
		private global::DevComponents.DotNetBar.Controls.TextBoxX tbxKeyCode;

		// Token: 0x040003FB RID: 1019
		private global::DevComponents.DotNetBar.Controls.TextBoxX tbxKeyValue;

		// Token: 0x040003FC RID: 1020
		private global::DevComponents.DotNetBar.Controls.TextBoxX tbxRemark;

		// Token: 0x040003FD RID: 1021
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layKeyword;

		// Token: 0x040003FE RID: 1022
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layValue;

		// Token: 0x040003FF RID: 1023
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem lciRemark;

		// Token: 0x04000400 RID: 1024
		private global::DevComponents.DotNetBar.Controls.TextBoxX tbxKeyName;

		// Token: 0x04000401 RID: 1025
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem2;

		// Token: 0x04000402 RID: 1026
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem1;
	}
}
