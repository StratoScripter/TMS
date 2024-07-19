namespace SQSClient
{
	// Token: 0x0200007E RID: 126
	public partial class frmUserEdit : global::SQSClient.BaseDialogForm
	{
		// Token: 0x060006EA RID: 1770 RVA: 0x000AA2D4 File Offset: 0x000A84D4
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060006EB RID: 1771 RVA: 0x000AA30C File Offset: 0x000A850C
		private void InitializeComponent()
		{
			this.menuBar = new global::DevComponents.DotNetBar.Bar();
			this.btnSave = new global::DevComponents.DotNetBar.ButtonItem();
			this.layoutControl1 = new global::DevComponents.DotNetBar.Layout.LayoutControl();
			this.chkState = new global::DevComponents.DotNetBar.Controls.CheckBoxX();
			this.rtbRemark = new global::DevComponents.DotNetBar.Controls.RichTextBoxEx();
			this.tbxEmail = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.tbxPhone = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.cmbSex = new global::DevComponents.DotNetBar.Controls.ComboBoxEx();
			this.cmbGroup = new global::DevComponents.DotNetBar.Controls.ComboBoxEx();
			this.tbxPwd2 = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.tbxPwd = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.tbxName = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.layoutControlItem1 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem2 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem3 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem4 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem5 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem6 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem7 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem8 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem9 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.chkManageself = new global::DevComponents.DotNetBar.Controls.CheckBoxX();
			this.layoutControlItem10 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
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
			this.menuBar.TabIndex = 19;
			this.menuBar.TabStop = false;
			this.menuBar.Text = "Main Menu";
			this.btnSave.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.btnSave.Image = global::SQSClient.Properties.Resources.save16;
			this.btnSave.Name = "btnSave";
			this.btnSave.Text = "Save";
			this.btnSave.Click += new global::System.EventHandler(this.btnSave_Click);
			this.layoutControl1.Controls.Add(this.chkManageself);
			this.layoutControl1.Controls.Add(this.chkState);
			this.layoutControl1.Controls.Add(this.rtbRemark);
			this.layoutControl1.Controls.Add(this.tbxEmail);
			this.layoutControl1.Controls.Add(this.tbxPhone);
			this.layoutControl1.Controls.Add(this.cmbSex);
			this.layoutControl1.Controls.Add(this.cmbGroup);
			this.layoutControl1.Controls.Add(this.tbxPwd2);
			this.layoutControl1.Controls.Add(this.tbxPwd);
			this.layoutControl1.Controls.Add(this.tbxName);
			this.layoutControl1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.layoutControl1.Location = new global::System.Drawing.Point(0, 26);
			this.layoutControl1.Name = "layoutControl1";
			this.layoutControl1.RootGroup.Items.AddRange(new global::DevComponents.DotNetBar.Layout.LayoutItemBase[]
			{
				this.layoutControlItem1,
				this.layoutControlItem2,
				this.layoutControlItem3,
				this.layoutControlItem4,
				this.layoutControlItem5,
				this.layoutControlItem6,
				this.layoutControlItem7,
				this.layoutControlItem8,
				this.layoutControlItem9,
				this.layoutControlItem10
			});
			this.layoutControl1.Size = new global::System.Drawing.Size(354, 346);
			this.layoutControl1.TabIndex = 20;
			this.chkState.AutoSize = true;
			this.chkState.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.chkState.Checked = true;
			this.chkState.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.chkState.CheckValue = "Y";
			this.chkState.Location = new global::System.Drawing.Point(110, 265);
			this.chkState.Margin = new global::System.Windows.Forms.Padding(0);
			this.chkState.Name = "chkState";
			this.chkState.Size = new global::System.Drawing.Size(64, 16);
			this.chkState.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.chkState.TabIndex = 8;
			this.chkState.Text = "Enable";
			this.rtbRemark.BackgroundStyle.Class = "RichTextBoxBorder";
			this.rtbRemark.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.rtbRemark.Location = new global::System.Drawing.Point(110, 205);
			this.rtbRemark.Margin = new global::System.Windows.Forms.Padding(0);
			this.rtbRemark.MaxLength = 200;
			this.rtbRemark.Name = "rtbRemark";
			this.rtbRemark.Rtf = "{\\rtf1\\ansi\\ansicpg936\\deff0\\deflang1033\\deflangfe2052{\\fonttbl{\\f0\\fnil\\fcharset134 \\'cb\\'ce\\'cc\\'e5;}}\r\n\\viewkind4\\uc1\\pard\\lang2052\\f0\\fs18\\par\r\n}\r\n";
			this.rtbRemark.Size = new global::System.Drawing.Size(240, 52);
			this.rtbRemark.TabIndex = 7;
			this.tbxEmail.Border.Class = "TextBoxBorder";
			this.tbxEmail.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.tbxEmail.Location = new global::System.Drawing.Point(110, 176);
			this.tbxEmail.Margin = new global::System.Windows.Forms.Padding(0);
			this.tbxEmail.MaxLength = 200;
			this.tbxEmail.Name = "tbxEmail";
			this.tbxEmail.PreventEnterBeep = true;
			this.tbxEmail.Size = new global::System.Drawing.Size(240, 21);
			this.tbxEmail.TabIndex = 6;
			this.tbxPhone.Border.Class = "TextBoxBorder";
			this.tbxPhone.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.tbxPhone.Location = new global::System.Drawing.Point(110, 147);
			this.tbxPhone.Margin = new global::System.Windows.Forms.Padding(0);
			this.tbxPhone.MaxLength = 11;
			this.tbxPhone.Name = "tbxPhone";
			this.tbxPhone.PreventEnterBeep = true;
			this.tbxPhone.Size = new global::System.Drawing.Size(240, 21);
			this.tbxPhone.TabIndex = 5;
			this.cmbSex.DisplayMember = "Text";
			this.cmbSex.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cmbSex.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbSex.FormattingEnabled = true;
			this.cmbSex.ItemHeight = 15;
			this.cmbSex.Location = new global::System.Drawing.Point(110, 119);
			this.cmbSex.Margin = new global::System.Windows.Forms.Padding(0);
			this.cmbSex.MaxLength = 10;
			this.cmbSex.Name = "cmbSex";
			this.cmbSex.Size = new global::System.Drawing.Size(240, 21);
			this.cmbSex.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.cmbSex.TabIndex = 4;
			this.cmbGroup.DisplayMember = "Text";
			this.cmbGroup.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cmbGroup.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbGroup.FormattingEnabled = true;
			this.cmbGroup.ItemHeight = 15;
			this.cmbGroup.Location = new global::System.Drawing.Point(110, 91);
			this.cmbGroup.Margin = new global::System.Windows.Forms.Padding(0);
			this.cmbGroup.MaxLength = 20;
			this.cmbGroup.Name = "cmbGroup";
			this.cmbGroup.Size = new global::System.Drawing.Size(240, 21);
			this.cmbGroup.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.cmbGroup.TabIndex = 3;
			this.cmbGroup.TextChanged += new global::System.EventHandler(this.cmbGroup_TextChanged);
			this.tbxPwd2.Border.Class = "TextBoxBorder";
			this.tbxPwd2.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.tbxPwd2.Location = new global::System.Drawing.Point(110, 62);
			this.tbxPwd2.Margin = new global::System.Windows.Forms.Padding(0);
			this.tbxPwd2.MaxLength = 50;
			this.tbxPwd2.Name = "tbxPwd2";
			this.tbxPwd2.PreventEnterBeep = true;
			this.tbxPwd2.Size = new global::System.Drawing.Size(240, 21);
			this.tbxPwd2.TabIndex = 2;
			this.tbxPwd2.UseSystemPasswordChar = true;
			this.tbxPwd.Border.Class = "TextBoxBorder";
			this.tbxPwd.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.tbxPwd.Location = new global::System.Drawing.Point(110, 33);
			this.tbxPwd.Margin = new global::System.Windows.Forms.Padding(0);
			this.tbxPwd.MaxLength = 50;
			this.tbxPwd.Name = "tbxPwd";
			this.tbxPwd.PreventEnterBeep = true;
			this.tbxPwd.Size = new global::System.Drawing.Size(240, 21);
			this.tbxPwd.TabIndex = 1;
			this.tbxPwd.UseSystemPasswordChar = true;
			this.tbxName.Border.Class = "TextBoxBorder";
			this.tbxName.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.tbxName.Location = new global::System.Drawing.Point(110, 4);
			this.tbxName.Margin = new global::System.Windows.Forms.Padding(0);
			this.tbxName.MaxLength = 20;
			this.tbxName.Name = "tbxName";
			this.tbxName.PreventEnterBeep = true;
			this.tbxName.Size = new global::System.Drawing.Size(240, 21);
			this.tbxName.TabIndex = 0;
			this.layoutControlItem1.Control = this.tbxName;
			this.layoutControlItem1.Height = 29;
			this.layoutControlItem1.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Text = "*UserName";
			this.layoutControlItem1.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem1.Width = 100;
			this.layoutControlItem1.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem2.Control = this.tbxPwd;
			this.layoutControlItem2.Height = 29;
			this.layoutControlItem2.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem2.Name = "layoutControlItem2";
			this.layoutControlItem2.Text = "*Password";
			this.layoutControlItem2.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem2.Width = 100;
			this.layoutControlItem2.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem3.Control = this.tbxPwd2;
			this.layoutControlItem3.Height = 29;
			this.layoutControlItem3.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem3.Name = "layoutControlItem3";
			this.layoutControlItem3.Text = "*ConfirmPassword";
			this.layoutControlItem3.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem3.Width = 100;
			this.layoutControlItem3.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem4.Control = this.cmbGroup;
			this.layoutControlItem4.Height = 28;
			this.layoutControlItem4.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem4.Name = "layoutControlItem4";
			this.layoutControlItem4.Text = "*GroupZB";
			this.layoutControlItem4.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem4.Width = 100;
			this.layoutControlItem4.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem5.Control = this.cmbSex;
			this.layoutControlItem5.Height = 28;
			this.layoutControlItem5.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem5.Name = "layoutControlItem5";
			this.layoutControlItem5.Text = "Gender";
			this.layoutControlItem5.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem5.Width = 100;
			this.layoutControlItem5.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem6.Control = this.tbxPhone;
			this.layoutControlItem6.Height = 29;
			this.layoutControlItem6.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem6.Name = "layoutControlItem6";
			this.layoutControlItem6.Text = "PhoneNum";
			this.layoutControlItem6.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem6.Width = 100;
			this.layoutControlItem6.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem7.Control = this.tbxEmail;
			this.layoutControlItem7.Height = 29;
			this.layoutControlItem7.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem7.Name = "layoutControlItem7";
			this.layoutControlItem7.Text = "Email";
			this.layoutControlItem7.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem7.Width = 100;
			this.layoutControlItem7.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem8.Control = this.rtbRemark;
			this.layoutControlItem8.Height = 60;
			this.layoutControlItem8.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem8.Name = "layoutControlItem8";
			this.layoutControlItem8.Text = "Remark";
			this.layoutControlItem8.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem8.Width = 100;
			this.layoutControlItem8.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem9.Control = this.chkState;
			this.layoutControlItem9.Height = 31;
			this.layoutControlItem9.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem9.Name = "layoutControlItem9";
			this.layoutControlItem9.Text = " ";
			this.layoutControlItem9.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem9.Width = 60;
			this.layoutControlItem9.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.chkManageself.AutoSize = true;
			this.chkManageself.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.chkManageself.Location = new global::System.Drawing.Point(216, 265);
			this.chkManageself.Margin = new global::System.Windows.Forms.Padding(0, 0, 0, 0);
			this.chkManageself.Name = "chkManageself";
			this.chkManageself.Size = new global::System.Drawing.Size(88, 16);
			this.chkManageself.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.chkManageself.TabIndex = 9;
			this.chkManageself.Text = "Manageself";
			this.layoutControlItem10.Control = this.chkManageself;
			this.layoutControlItem10.Height = 31;
			this.layoutControlItem10.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem10.Name = "layoutControlItem10";
			this.layoutControlItem10.Width = 40;
			this.layoutControlItem10.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			base.ClientSize = new global::System.Drawing.Size(354, 372);
			base.Controls.Add(this.layoutControl1);
			base.Controls.Add(this.menuBar);
			base.Name = "frmUserEdit";
			this.Text = "frmUserEdit";
			base.Load += new global::System.EventHandler(this.frmUserEdit_Load);
			((global::System.ComponentModel.ISupportInitialize)this.menuBar).EndInit();
			this.layoutControl1.ResumeLayout(false);
			this.layoutControl1.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x04000BB8 RID: 3000
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000BB9 RID: 3001
		private global::DevComponents.DotNetBar.Bar menuBar;

		// Token: 0x04000BBA RID: 3002
		private global::DevComponents.DotNetBar.ButtonItem btnSave;

		// Token: 0x04000BBB RID: 3003
		private global::DevComponents.DotNetBar.Layout.LayoutControl layoutControl1;

		// Token: 0x04000BBC RID: 3004
		private global::DevComponents.DotNetBar.Controls.CheckBoxX chkState;

		// Token: 0x04000BBD RID: 3005
		private global::DevComponents.DotNetBar.Controls.RichTextBoxEx rtbRemark;

		// Token: 0x04000BBE RID: 3006
		private global::DevComponents.DotNetBar.Controls.TextBoxX tbxEmail;

		// Token: 0x04000BBF RID: 3007
		private global::DevComponents.DotNetBar.Controls.TextBoxX tbxPhone;

		// Token: 0x04000BC0 RID: 3008
		private global::DevComponents.DotNetBar.Controls.ComboBoxEx cmbSex;

		// Token: 0x04000BC1 RID: 3009
		private global::DevComponents.DotNetBar.Controls.ComboBoxEx cmbGroup;

		// Token: 0x04000BC2 RID: 3010
		private global::DevComponents.DotNetBar.Controls.TextBoxX tbxPwd2;

		// Token: 0x04000BC3 RID: 3011
		private global::DevComponents.DotNetBar.Controls.TextBoxX tbxPwd;

		// Token: 0x04000BC4 RID: 3012
		private global::DevComponents.DotNetBar.Controls.TextBoxX tbxName;

		// Token: 0x04000BC5 RID: 3013
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem1;

		// Token: 0x04000BC6 RID: 3014
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem2;

		// Token: 0x04000BC7 RID: 3015
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem3;

		// Token: 0x04000BC8 RID: 3016
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem4;

		// Token: 0x04000BC9 RID: 3017
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem5;

		// Token: 0x04000BCA RID: 3018
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem6;

		// Token: 0x04000BCB RID: 3019
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem7;

		// Token: 0x04000BCC RID: 3020
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem8;

		// Token: 0x04000BCD RID: 3021
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem9;

		// Token: 0x04000BCE RID: 3022
		private global::DevComponents.DotNetBar.Controls.CheckBoxX chkManageself;

		// Token: 0x04000BCF RID: 3023
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem10;
	}
}
