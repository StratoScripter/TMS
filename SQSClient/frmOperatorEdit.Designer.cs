namespace SQSClient
{
	// Token: 0x0200003D RID: 61
	public partial class frmOperatorEdit : global::SQSClient.BaseDialogForm
	{
		// Token: 0x060002D2 RID: 722 RVA: 0x000494C8 File Offset: 0x000476C8
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x00049500 File Offset: 0x00047700
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::SQSClient.frmOperatorEdit));
			this.layoutControlItem7 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.menuBar = new global::DevComponents.DotNetBar.Bar();
			this.btnSave = new global::DevComponents.DotNetBar.ButtonItem();
			this.layoutControl1 = new global::DevComponents.DotNetBar.Layout.LayoutControl();
			this.cobICKard = new global::Base.AutoComboBox();
			this.chkState = new global::DevComponents.DotNetBar.Controls.CheckBoxX();
			this.rtbRemark = new global::DevComponents.DotNetBar.Controls.RichTextBoxEx();
			this.tbxPwd = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.tbxNum = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.tbxName = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.layoutControlItem1 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem2 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem3 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem9 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem4 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem5 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			((global::System.ComponentModel.ISupportInitialize)this.menuBar).BeginInit();
			this.layoutControl1.SuspendLayout();
			base.SuspendLayout();
			this.layoutControlItem7.Height = 29;
			this.layoutControlItem7.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem7.Name = "layoutControlItem7";
			this.layoutControlItem7.Text = "*工号：";
			this.layoutControlItem7.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem7.Width = 100;
			this.layoutControlItem7.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
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
			this.layoutControl1.Controls.Add(this.cobICKard);
			this.layoutControl1.Controls.Add(this.chkState);
			this.layoutControl1.Controls.Add(this.rtbRemark);
			this.layoutControl1.Controls.Add(this.tbxPwd);
			this.layoutControl1.Controls.Add(this.tbxNum);
			this.layoutControl1.Controls.Add(this.tbxName);
			this.layoutControl1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.layoutControl1.Location = new global::System.Drawing.Point(0, 26);
			this.layoutControl1.Name = "layoutControl1";
			this.layoutControl1.RootGroup.Items.AddRange(new global::DevComponents.DotNetBar.Layout.LayoutItemBase[]
			{
				this.layoutControlItem1,
				this.layoutControlItem2,
				this.layoutControlItem3,
				this.layoutControlItem9,
				this.layoutControlItem4,
				this.layoutControlItem5
			});
			this.layoutControl1.Size = new global::System.Drawing.Size(354, 298);
			this.layoutControl1.TabIndex = 21;
			this.cobICKard.DataSource = null;
			this.cobICKard.DisplayMember = null;
			this.cobICKard.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cobICKard.FormattingEnabled = true;
			this.cobICKard.ItemHeight = 15;
			this.cobICKard.Location = new global::System.Drawing.Point(104, 91);
			this.cobICKard.Margin = new global::System.Windows.Forms.Padding(0);
			this.cobICKard.MaxDropDownItems = 20;
			this.cobICKard.Name = "cobICKard";
			this.cobICKard.SelectMember = null;
			this.cobICKard.Size = new global::System.Drawing.Size(246, 21);
			this.cobICKard.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.cobICKard.TabIndex = 3;
			this.cobICKard.ValueMember = null;
			this.chkState.AutoSize = true;
			this.chkState.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.chkState.Checked = true;
			this.chkState.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.chkState.CheckValue = "Y";
			this.chkState.Location = new global::System.Drawing.Point(104, 219);
			this.chkState.Margin = new global::System.Windows.Forms.Padding(0);
			this.chkState.Name = "chkState";
			this.chkState.Size = new global::System.Drawing.Size(64, 16);
			this.chkState.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.chkState.TabIndex = 5;
			this.chkState.Text = "Enable";
			this.rtbRemark.BackgroundStyle.Class = "RichTextBoxBorder";
			this.rtbRemark.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.rtbRemark.Location = new global::System.Drawing.Point(104, 119);
			this.rtbRemark.Margin = new global::System.Windows.Forms.Padding(0);
			this.rtbRemark.MaxLength = 200;
			this.rtbRemark.Name = "rtbRemark";
			this.rtbRemark.Rtf = "{\\rtf1\\ansi\\ansicpg936\\deff0\\deflang1033\\deflangfe2052{\\fonttbl{\\f0\\fnil\\fcharset134 \\'cb\\'ce\\'cc\\'e5;}}\r\n\\viewkind4\\uc1\\pard\\lang2052\\f0\\fs18\\par\r\n}\r\n";
			this.rtbRemark.Size = new global::System.Drawing.Size(246, 92);
			this.rtbRemark.TabIndex = 4;
			this.tbxPwd.Border.Class = "TextBoxBorder";
			this.tbxPwd.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.tbxPwd.Location = new global::System.Drawing.Point(104, 62);
			this.tbxPwd.Margin = new global::System.Windows.Forms.Padding(0);
			this.tbxPwd.MaxLength = 10;
			this.tbxPwd.Name = "tbxPwd";
			this.tbxPwd.PreventEnterBeep = true;
			this.tbxPwd.Size = new global::System.Drawing.Size(246, 21);
			this.tbxPwd.TabIndex = 2;
			this.tbxNum.Border.Class = "TextBoxBorder";
			this.tbxNum.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.tbxNum.Location = new global::System.Drawing.Point(104, 33);
			this.tbxNum.Margin = new global::System.Windows.Forms.Padding(0);
			this.tbxNum.MaxLength = 10;
			this.tbxNum.Name = "tbxNum";
			this.tbxNum.PreventEnterBeep = true;
			this.tbxNum.Size = new global::System.Drawing.Size(246, 21);
			this.tbxNum.TabIndex = 1;
			this.tbxName.Border.Class = "TextBoxBorder";
			this.tbxName.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.tbxName.Location = new global::System.Drawing.Point(104, 4);
			this.tbxName.Margin = new global::System.Windows.Forms.Padding(0);
			this.tbxName.MaxLength = 20;
			this.tbxName.Name = "tbxName";
			this.tbxName.PreventEnterBeep = true;
			this.tbxName.Size = new global::System.Drawing.Size(246, 21);
			this.tbxName.TabIndex = 0;
			this.layoutControlItem1.Control = this.tbxName;
			this.layoutControlItem1.Height = 29;
			this.layoutControlItem1.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Text = "*Operator";
			this.layoutControlItem1.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem1.Width = 100;
			this.layoutControlItem1.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem2.Control = this.tbxNum;
			this.layoutControlItem2.Height = 29;
			this.layoutControlItem2.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem2.Name = "layoutControlItem2";
			this.layoutControlItem2.Text = "*EmployeeNumber";
			this.layoutControlItem2.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem2.Width = 100;
			this.layoutControlItem2.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem3.Control = this.tbxPwd;
			this.layoutControlItem3.Height = 29;
			this.layoutControlItem3.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem3.Name = "layoutControlItem3";
			this.layoutControlItem3.Text = "*OPassword";
			this.layoutControlItem3.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem3.Width = 100;
			this.layoutControlItem3.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem9.Control = this.cobICKard;
			this.layoutControlItem9.Height = 28;
			this.layoutControlItem9.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem9.Name = "layoutControlItem9";
			this.layoutControlItem9.Text = "ICCard";
			this.layoutControlItem9.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem9.Width = 100;
			this.layoutControlItem9.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem4.Control = this.rtbRemark;
			this.layoutControlItem4.Height = 100;
			this.layoutControlItem4.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem4.Name = "layoutControlItem4";
			this.layoutControlItem4.Text = "Remark";
			this.layoutControlItem4.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem4.Width = 100;
			this.layoutControlItem4.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem5.Control = this.chkState;
			this.layoutControlItem5.Height = 31;
			this.layoutControlItem5.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem5.Name = "layoutControlItem5";
			this.layoutControlItem5.Text = " ";
			this.layoutControlItem5.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem5.Width = 100;
			this.layoutControlItem5.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			base.ClientSize = new global::System.Drawing.Size(354, 324);
			base.Controls.Add(this.layoutControl1);
			base.Controls.Add(this.menuBar);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "frmOperatorEdit";
			this.Text = "frmOperatorEdit";
			base.Load += new global::System.EventHandler(this.frmOperatorEdit_Load);
			((global::System.ComponentModel.ISupportInitialize)this.menuBar).EndInit();
			this.layoutControl1.ResumeLayout(false);
			this.layoutControl1.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x04000491 RID: 1169
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000492 RID: 1170
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem7;

		// Token: 0x04000493 RID: 1171
		private global::DevComponents.DotNetBar.Bar menuBar;

		// Token: 0x04000494 RID: 1172
		private global::DevComponents.DotNetBar.ButtonItem btnSave;

		// Token: 0x04000495 RID: 1173
		private global::DevComponents.DotNetBar.Layout.LayoutControl layoutControl1;

		// Token: 0x04000496 RID: 1174
		private global::Base.AutoComboBox cobICKard;

		// Token: 0x04000497 RID: 1175
		private global::DevComponents.DotNetBar.Controls.CheckBoxX chkState;

		// Token: 0x04000498 RID: 1176
		private global::DevComponents.DotNetBar.Controls.RichTextBoxEx rtbRemark;

		// Token: 0x04000499 RID: 1177
		private global::DevComponents.DotNetBar.Controls.TextBoxX tbxPwd;

		// Token: 0x0400049A RID: 1178
		private global::DevComponents.DotNetBar.Controls.TextBoxX tbxNum;

		// Token: 0x0400049B RID: 1179
		private global::DevComponents.DotNetBar.Controls.TextBoxX tbxName;

		// Token: 0x0400049C RID: 1180
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem1;

		// Token: 0x0400049D RID: 1181
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem2;

		// Token: 0x0400049E RID: 1182
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem3;

		// Token: 0x0400049F RID: 1183
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem9;

		// Token: 0x040004A0 RID: 1184
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem4;

		// Token: 0x040004A1 RID: 1185
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem5;
	}
}
