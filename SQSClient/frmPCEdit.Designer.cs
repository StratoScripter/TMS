namespace SQSClient
{
	// Token: 0x02000084 RID: 132
	public partial class frmPCEdit : global::SQSClient.BaseDialogForm
	{
		// Token: 0x06000731 RID: 1841 RVA: 0x000B29A4 File Offset: 0x000B0BA4
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000732 RID: 1842 RVA: 0x000B29DC File Offset: 0x000B0BDC
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::SQSClient.frmPCEdit));
			this.menuBar = new global::DevComponents.DotNetBar.Bar();
			this.btnSave = new global::DevComponents.DotNetBar.ButtonItem();
			this.layoutControl1 = new global::DevComponents.DotNetBar.Layout.LayoutControl();
			this.rtbRemark = new global::DevComponents.DotNetBar.Controls.RichTextBoxEx();
			this.cmbType = new global::DevComponents.DotNetBar.Controls.ComboBoxEx();
			this.tbxIP = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.tbxName = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.layoutControlItem1 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem2 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem3 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem4 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			((global::System.ComponentModel.ISupportInitialize)this.menuBar).BeginInit();
			this.layoutControl1.SuspendLayout();
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
			this.menuBar.TabIndex = 20;
			this.menuBar.TabStop = false;
			this.menuBar.Text = "Main Menu";
			this.btnSave.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.btnSave.Image = global::SQSClient.Properties.Resources.save16;
			this.btnSave.Name = "btnSave";
			this.btnSave.Text = "Save";
			this.btnSave.Click += new global::System.EventHandler(this.btnSave_Click);
			this.layoutControl1.Controls.Add(this.rtbRemark);
			this.layoutControl1.Controls.Add(this.cmbType);
			this.layoutControl1.Controls.Add(this.tbxIP);
			this.layoutControl1.Controls.Add(this.tbxName);
			this.layoutControl1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.layoutControl1.Location = new global::System.Drawing.Point(0, 26);
			this.layoutControl1.Name = "layoutControl1";
			this.layoutControl1.RootGroup.Items.AddRange(new global::DevComponents.DotNetBar.Layout.LayoutItemBase[]
			{
				this.layoutControlItem1,
				this.layoutControlItem2,
				this.layoutControlItem3,
				this.layoutControlItem4
			});
			this.layoutControl1.Size = new global::System.Drawing.Size(354, 244);
			this.layoutControl1.TabIndex = 21;
			this.rtbRemark.BackgroundStyle.Class = "RichTextBoxBorder";
			this.rtbRemark.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.rtbRemark.Location = new global::System.Drawing.Point(80, 90);
			this.rtbRemark.Margin = new global::System.Windows.Forms.Padding(0);
			this.rtbRemark.MaxLength = 200;
			this.rtbRemark.Name = "rtbRemark";
			this.rtbRemark.Rtf = "{\\rtf1\\ansi\\ansicpg936\\deff0\\deflang1033\\deflangfe2052{\\fonttbl{\\f0\\fnil\\fcharset134 \\'cb\\'ce\\'cc\\'e5;}}\r\n\\viewkind4\\uc1\\pard\\lang2052\\f0\\fs18\\par\r\n}\r\n";
			this.rtbRemark.Size = new global::System.Drawing.Size(270, 100);
			this.rtbRemark.TabIndex = 3;
			this.cmbType.DisplayMember = "Text";
			this.cmbType.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cmbType.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbType.FormattingEnabled = true;
			this.cmbType.ItemHeight = 15;
			this.cmbType.Location = new global::System.Drawing.Point(80, 62);
			this.cmbType.Margin = new global::System.Windows.Forms.Padding(0);
			this.cmbType.MaxLength = 20;
			this.cmbType.Name = "cmbType";
			this.cmbType.Size = new global::System.Drawing.Size(270, 21);
			this.cmbType.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.cmbType.TabIndex = 2;
			this.tbxIP.Border.Class = "TextBoxBorder";
			this.tbxIP.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.tbxIP.Location = new global::System.Drawing.Point(80, 33);
			this.tbxIP.Margin = new global::System.Windows.Forms.Padding(0);
			this.tbxIP.MaxLength = 20;
			this.tbxIP.Name = "tbxIP";
			this.tbxIP.PreventEnterBeep = true;
			this.tbxIP.Size = new global::System.Drawing.Size(270, 21);
			this.tbxIP.TabIndex = 1;
			this.tbxName.Border.Class = "TextBoxBorder";
			this.tbxName.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.tbxName.Location = new global::System.Drawing.Point(80, 4);
			this.tbxName.Margin = new global::System.Windows.Forms.Padding(0);
			this.tbxName.MaxLength = 20;
			this.tbxName.Name = "tbxName";
			this.tbxName.PreventEnterBeep = true;
			this.tbxName.Size = new global::System.Drawing.Size(270, 21);
			this.tbxName.TabIndex = 0;
			this.layoutControlItem1.Control = this.tbxName;
			this.layoutControlItem1.Height = 29;
			this.layoutControlItem1.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Text = "*ServerName";
			this.layoutControlItem1.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem1.Width = 100;
			this.layoutControlItem1.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem2.Control = this.tbxIP;
			this.layoutControlItem2.Height = 29;
			this.layoutControlItem2.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem2.Name = "layoutControlItem2";
			this.layoutControlItem2.Text = "*IP";
			this.layoutControlItem2.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem2.Width = 100;
			this.layoutControlItem2.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem3.Control = this.cmbType;
			this.layoutControlItem3.Height = 28;
			this.layoutControlItem3.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem3.Name = "layoutControlItem3";
			this.layoutControlItem3.Text = "Type";
			this.layoutControlItem3.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem3.Width = 100;
			this.layoutControlItem3.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem4.Control = this.rtbRemark;
			this.layoutControlItem4.Height = 108;
			this.layoutControlItem4.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem4.Name = "layoutControlItem4";
			this.layoutControlItem4.Text = "Remark";
			this.layoutControlItem4.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem4.Width = 100;
			this.layoutControlItem4.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			base.ClientSize = new global::System.Drawing.Size(354, 270);
			base.Controls.Add(this.layoutControl1);
			base.Controls.Add(this.menuBar);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "frmPCEdit";
			this.Text = "frmPCEdit";
			base.Load += new global::System.EventHandler(this.frmPCEdit_Load);
			((global::System.ComponentModel.ISupportInitialize)this.menuBar).EndInit();
			this.layoutControl1.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x04000C43 RID: 3139
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000C44 RID: 3140
		private global::DevComponents.DotNetBar.Bar menuBar;

		// Token: 0x04000C45 RID: 3141
		private global::DevComponents.DotNetBar.ButtonItem btnSave;

		// Token: 0x04000C46 RID: 3142
		private global::DevComponents.DotNetBar.Layout.LayoutControl layoutControl1;

		// Token: 0x04000C47 RID: 3143
		private global::DevComponents.DotNetBar.Controls.RichTextBoxEx rtbRemark;

		// Token: 0x04000C48 RID: 3144
		private global::DevComponents.DotNetBar.Controls.ComboBoxEx cmbType;

		// Token: 0x04000C49 RID: 3145
		private global::DevComponents.DotNetBar.Controls.TextBoxX tbxIP;

		// Token: 0x04000C4A RID: 3146
		private global::DevComponents.DotNetBar.Controls.TextBoxX tbxName;

		// Token: 0x04000C4B RID: 3147
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem1;

		// Token: 0x04000C4C RID: 3148
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem2;

		// Token: 0x04000C4D RID: 3149
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem3;

		// Token: 0x04000C4E RID: 3150
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem4;
	}
}
