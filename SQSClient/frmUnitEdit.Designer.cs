namespace SQSClient
{
	// Token: 0x02000087 RID: 135
	public partial class frmUnitEdit : global::SQSClient.BaseDialogForm
	{
		// Token: 0x06000762 RID: 1890 RVA: 0x000B6DBC File Offset: 0x000B4FBC
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000763 RID: 1891 RVA: 0x000B6DF4 File Offset: 0x000B4FF4
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::SQSClient.frmUnitEdit));
			this.layoutControlItem4 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.menuBar = new global::DevComponents.DotNetBar.Bar();
			this.btnSave = new global::DevComponents.DotNetBar.ButtonItem();
			this.layoutControl1 = new global::DevComponents.DotNetBar.Layout.LayoutControl();
			this.iInputCode = new global::DevComponents.Editors.IntegerInput();
			this.cmbTank = new global::Base.AutoComboBox();
			this.cmbType = new global::Base.AutoComboBox();
			this.cmbGroup = new global::Base.AutoComboBox();
			this.cmbDevice = new global::Base.AutoComboBox();
			this.nudLuHao = new global::DevComponents.Editors.IntegerInput();
			this.rtbRemark = new global::DevComponents.DotNetBar.Controls.RichTextBoxEx();
			this.tbxName = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.nudUnitIndex = new global::DevComponents.Editors.IntegerInput();
			this.chkState = new global::DevComponents.DotNetBar.Controls.CheckBoxX();
			this.layoutControlItem1 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem11 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem8 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem9 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem6 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem3 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem7 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem10 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem5 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem12 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			((global::System.ComponentModel.ISupportInitialize)this.menuBar).BeginInit();
			this.layoutControl1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.iInputCode).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudLuHao).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudUnitIndex).BeginInit();
			base.SuspendLayout();
			this.layoutControlItem4.Height = 29;
			this.layoutControlItem4.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem4.Name = "layoutControlItem4";
			this.layoutControlItem4.Text = "*路号：";
			this.layoutControlItem4.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem4.Width = 88;
			this.layoutControlItem4.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
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
			this.menuBar.TabIndex = 21;
			this.menuBar.TabStop = false;
			this.menuBar.Text = "Main Menu";
			this.btnSave.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.btnSave.Image = global::SQSClient.Properties.Resources.save16;
			this.btnSave.Name = "btnSave";
			this.btnSave.Text = "Save";
			this.btnSave.Click += new global::System.EventHandler(this.btnSave_Click);
			this.layoutControl1.Controls.Add(this.iInputCode);
			this.layoutControl1.Controls.Add(this.cmbTank);
			this.layoutControl1.Controls.Add(this.cmbType);
			this.layoutControl1.Controls.Add(this.cmbGroup);
			this.layoutControl1.Controls.Add(this.cmbDevice);
			this.layoutControl1.Controls.Add(this.nudLuHao);
			this.layoutControl1.Controls.Add(this.rtbRemark);
			this.layoutControl1.Controls.Add(this.tbxName);
			this.layoutControl1.Controls.Add(this.nudUnitIndex);
			this.layoutControl1.Controls.Add(this.chkState);
			this.layoutControl1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.layoutControl1.Location = new global::System.Drawing.Point(0, 26);
			this.layoutControl1.Name = "layoutControl1";
			this.layoutControl1.RootGroup.Items.AddRange(new global::DevComponents.DotNetBar.Layout.LayoutItemBase[]
			{
				this.layoutControlItem1,
				this.layoutControlItem11,
				this.layoutControlItem8,
				this.layoutControlItem9,
				this.layoutControlItem6,
				this.layoutControlItem3,
				this.layoutControlItem7,
				this.layoutControlItem10,
				this.layoutControlItem5,
				this.layoutControlItem12
			});
			this.layoutControl1.Size = new global::System.Drawing.Size(354, 346);
			this.layoutControl1.TabIndex = 22;
			this.iInputCode.BackgroundStyle.Class = "DateTimeInputBackground";
			this.iInputCode.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.iInputCode.ButtonFreeText.Shortcut = global::DevComponents.DotNetBar.eShortcut.F2;
			this.iInputCode.InputHorizontalAlignment = global::DevComponents.Editors.eHorizontalAlignment.Left;
			this.iInputCode.Location = new global::System.Drawing.Point(92, 33);
			this.iInputCode.Margin = new global::System.Windows.Forms.Padding(0);
			this.iInputCode.MaxValue = 999;
			this.iInputCode.MinValue = 1;
			this.iInputCode.Name = "iInputCode";
			this.iInputCode.ShowUpDown = true;
			this.iInputCode.Size = new global::System.Drawing.Size(258, 21);
			this.iInputCode.TabIndex = 1;
			this.iInputCode.Value = 1;
			this.cmbTank.DataSource = null;
			this.cmbTank.DisplayMember = null;
			this.cmbTank.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cmbTank.FormattingEnabled = true;
			this.cmbTank.ItemHeight = 15;
			this.cmbTank.Location = new global::System.Drawing.Point(92, 204);
			this.cmbTank.Margin = new global::System.Windows.Forms.Padding(0);
			this.cmbTank.MaxDropDownItems = 20;
			this.cmbTank.Name = "cmbTank";
			this.cmbTank.SelectMember = null;
			this.cmbTank.Size = new global::System.Drawing.Size(258, 21);
			this.cmbTank.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.cmbTank.TabIndex = 7;
			this.cmbTank.ValueMember = null;
			this.cmbTank.TextChanged += new global::System.EventHandler(this.cmbTank_TextChanged);
			this.cmbType.DataSource = null;
			this.cmbType.DisplayMember = null;
			this.cmbType.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cmbType.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbType.FormattingEnabled = true;
			this.cmbType.ItemHeight = 16;
			this.cmbType.Location = new global::System.Drawing.Point(92, 119);
			this.cmbType.Margin = new global::System.Windows.Forms.Padding(0);
			this.cmbType.MaxDropDownItems = 20;
			this.cmbType.Name = "cmbType";
			this.cmbType.SelectMember = null;
			this.cmbType.Size = new global::System.Drawing.Size(258, 22);
			this.cmbType.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.cmbType.TabIndex = 4;
			this.cmbType.ValueMember = null;
			this.cmbGroup.DataSource = null;
			this.cmbGroup.DisplayMember = null;
			this.cmbGroup.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cmbGroup.FormattingEnabled = true;
			this.cmbGroup.ItemHeight = 15;
			this.cmbGroup.Location = new global::System.Drawing.Point(92, 91);
			this.cmbGroup.Margin = new global::System.Windows.Forms.Padding(0);
			this.cmbGroup.MaxDropDownItems = 20;
			this.cmbGroup.Name = "cmbGroup";
			this.cmbGroup.SelectMember = null;
			this.cmbGroup.Size = new global::System.Drawing.Size(258, 21);
			this.cmbGroup.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.cmbGroup.TabIndex = 3;
			this.cmbGroup.ValueMember = null;
			this.cmbDevice.DataSource = null;
			this.cmbDevice.DisplayMember = null;
			this.cmbDevice.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cmbDevice.FormattingEnabled = true;
			this.cmbDevice.ItemHeight = 15;
			this.cmbDevice.Location = new global::System.Drawing.Point(92, 147);
			this.cmbDevice.Margin = new global::System.Windows.Forms.Padding(0);
			this.cmbDevice.MaxDropDownItems = 20;
			this.cmbDevice.MaxLength = 50;
			this.cmbDevice.Name = "cmbDevice";
			this.cmbDevice.SelectMember = null;
			this.cmbDevice.Size = new global::System.Drawing.Size(258, 21);
			this.cmbDevice.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.cmbDevice.TabIndex = 5;
			this.cmbDevice.ValueMember = null;
			this.cmbDevice.TextChanged += new global::System.EventHandler(this.cmbDevice_TextChanged);
			this.nudLuHao.BackgroundStyle.Class = "DateTimeInputBackground";
			this.nudLuHao.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.nudLuHao.ButtonFreeText.Shortcut = global::DevComponents.DotNetBar.eShortcut.F2;
			this.nudLuHao.InputHorizontalAlignment = global::DevComponents.Editors.eHorizontalAlignment.Left;
			this.nudLuHao.Location = new global::System.Drawing.Point(92, 175);
			this.nudLuHao.Margin = new global::System.Windows.Forms.Padding(0);
			this.nudLuHao.MaxValue = 255;
			this.nudLuHao.MinValue = 1;
			this.nudLuHao.Name = "nudLuHao";
			this.nudLuHao.ShowUpDown = true;
			this.nudLuHao.Size = new global::System.Drawing.Size(258, 21);
			this.nudLuHao.TabIndex = 6;
			this.nudLuHao.Value = 1;
			this.rtbRemark.BackgroundStyle.Class = "RichTextBoxBorder";
			this.rtbRemark.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.rtbRemark.Location = new global::System.Drawing.Point(92, 232);
			this.rtbRemark.Margin = new global::System.Windows.Forms.Padding(0);
			this.rtbRemark.MaxLength = 200;
			this.rtbRemark.Name = "rtbRemark";
			this.rtbRemark.Rtf = "{\\rtf1\\ansi\\ansicpg936\\deff0\\nouicompat\\deflang1033\\deflangfe2052{\\fonttbl{\\f0\\fnil\\fcharset134 \\'cb\\'ce\\'cc\\'e5;}}\r\n{\\*\\generator Riched20 10.0.18362}\\viewkind4\\uc1 \r\n\\pard\\f0\\fs18\\lang2052\\par\r\n}\r\n";
			this.rtbRemark.Size = new global::System.Drawing.Size(258, 50);
			this.rtbRemark.TabIndex = 8;
			this.tbxName.Border.Class = "TextBoxBorder";
			this.tbxName.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.tbxName.Location = new global::System.Drawing.Point(92, 4);
			this.tbxName.Margin = new global::System.Windows.Forms.Padding(0);
			this.tbxName.MaxLength = 20;
			this.tbxName.Name = "tbxName";
			this.tbxName.PreventEnterBeep = true;
			this.tbxName.Size = new global::System.Drawing.Size(258, 21);
			this.tbxName.TabIndex = 0;
			this.nudUnitIndex.BackgroundStyle.Class = "DateTimeInputBackground";
			this.nudUnitIndex.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.nudUnitIndex.ButtonFreeText.Shortcut = global::DevComponents.DotNetBar.eShortcut.F2;
			this.nudUnitIndex.InputHorizontalAlignment = global::DevComponents.Editors.eHorizontalAlignment.Left;
			this.nudUnitIndex.Location = new global::System.Drawing.Point(92, 62);
			this.nudUnitIndex.Margin = new global::System.Windows.Forms.Padding(0);
			this.nudUnitIndex.MaxValue = 999;
			this.nudUnitIndex.MinValue = 1;
			this.nudUnitIndex.Name = "nudUnitIndex";
			this.nudUnitIndex.ShowUpDown = true;
			this.nudUnitIndex.Size = new global::System.Drawing.Size(258, 21);
			this.nudUnitIndex.TabIndex = 2;
			this.nudUnitIndex.Value = 1;
			this.chkState.AutoSize = true;
			this.chkState.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.chkState.Checked = true;
			this.chkState.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.chkState.CheckValue = "Y";
			this.chkState.Location = new global::System.Drawing.Point(92, 290);
			this.chkState.Margin = new global::System.Windows.Forms.Padding(0);
			this.chkState.Name = "chkState";
			this.chkState.Size = new global::System.Drawing.Size(64, 16);
			this.chkState.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.chkState.TabIndex = 9;
			this.chkState.Text = "Enable";
			this.layoutControlItem1.Control = this.tbxName;
			this.layoutControlItem1.Height = 29;
			this.layoutControlItem1.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Text = "*UnitName";
			this.layoutControlItem1.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem1.Width = 100;
			this.layoutControlItem1.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem11.Control = this.iInputCode;
			this.layoutControlItem11.Height = 29;
			this.layoutControlItem11.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem11.Name = "layoutControlItem11";
			this.layoutControlItem11.Text = "*UnitCode";
			this.layoutControlItem11.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem11.Width = 100;
			this.layoutControlItem11.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem8.Control = this.nudUnitIndex;
			this.layoutControlItem8.Height = 29;
			this.layoutControlItem8.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem8.Name = "layoutControlItem8";
			this.layoutControlItem8.Text = "*UnitIndex";
			this.layoutControlItem8.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem8.Width = 100;
			this.layoutControlItem8.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem9.Control = this.cmbGroup;
			this.layoutControlItem9.Height = 28;
			this.layoutControlItem9.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem9.Name = "layoutControlItem9";
			this.layoutControlItem9.Text = "*GroupZB";
			this.layoutControlItem9.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem9.Width = 100;
			this.layoutControlItem9.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem6.Control = this.cmbType;
			this.layoutControlItem6.Height = 28;
			this.layoutControlItem6.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem6.Name = "layoutControlItem6";
			this.layoutControlItem6.Text = "*BusinessType";
			this.layoutControlItem6.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem6.Width = 100;
			this.layoutControlItem6.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem3.Control = this.cmbDevice;
			this.layoutControlItem3.Height = 28;
			this.layoutControlItem3.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem3.Name = "layoutControlItem3";
			this.layoutControlItem3.Text = "*Device";
			this.layoutControlItem3.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem3.Width = 129;
			this.layoutControlItem3.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem7.Control = this.nudLuHao;
			this.layoutControlItem7.Height = 29;
			this.layoutControlItem7.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem7.Name = "layoutControlItem7";
			this.layoutControlItem7.Text = "*Branch";
			this.layoutControlItem7.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem7.Width = 88;
			this.layoutControlItem7.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem10.Control = this.cmbTank;
			this.layoutControlItem10.Height = 28;
			this.layoutControlItem10.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem10.Name = "layoutControlItem10";
			this.layoutControlItem10.Text = "Tank";
			this.layoutControlItem10.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem10.Width = 100;
			this.layoutControlItem10.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem5.Control = this.rtbRemark;
			this.layoutControlItem5.Height = 58;
			this.layoutControlItem5.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem5.Name = "layoutControlItem5";
			this.layoutControlItem5.Text = "Remark";
			this.layoutControlItem5.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem5.Width = 100;
			this.layoutControlItem5.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem12.Control = this.chkState;
			this.layoutControlItem12.Height = 24;
			this.layoutControlItem12.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem12.Name = "layoutControlItem12";
			this.layoutControlItem12.Text = " ";
			this.layoutControlItem12.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem12.Width = 100;
			this.layoutControlItem12.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			base.ClientSize = new global::System.Drawing.Size(354, 372);
			base.Controls.Add(this.layoutControl1);
			base.Controls.Add(this.menuBar);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "frmUnitEdit";
			this.Text = "UnitEdit";
			base.Load += new global::System.EventHandler(this.frmUnitEdit_Load);
			((global::System.ComponentModel.ISupportInitialize)this.menuBar).EndInit();
			this.layoutControl1.ResumeLayout(false);
			this.layoutControl1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.iInputCode).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudLuHao).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudUnitIndex).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000C85 RID: 3205
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000C86 RID: 3206
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem4;

		// Token: 0x04000C87 RID: 3207
		private global::DevComponents.DotNetBar.Bar menuBar;

		// Token: 0x04000C88 RID: 3208
		private global::DevComponents.DotNetBar.ButtonItem btnSave;

		// Token: 0x04000C89 RID: 3209
		private global::DevComponents.DotNetBar.Layout.LayoutControl layoutControl1;

		// Token: 0x04000C8A RID: 3210
		private global::Base.AutoComboBox cmbDevice;

		// Token: 0x04000C8B RID: 3211
		private global::DevComponents.Editors.IntegerInput nudLuHao;

		// Token: 0x04000C8C RID: 3212
		private global::DevComponents.DotNetBar.Controls.RichTextBoxEx rtbRemark;

		// Token: 0x04000C8D RID: 3213
		private global::DevComponents.DotNetBar.Controls.TextBoxX tbxName;

		// Token: 0x04000C8E RID: 3214
		private global::DevComponents.Editors.IntegerInput nudUnitIndex;

		// Token: 0x04000C8F RID: 3215
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem1;

		// Token: 0x04000C90 RID: 3216
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem8;

		// Token: 0x04000C91 RID: 3217
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem3;

		// Token: 0x04000C92 RID: 3218
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem7;

		// Token: 0x04000C93 RID: 3219
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem5;

		// Token: 0x04000C94 RID: 3220
		private global::Base.AutoComboBox cmbGroup;

		// Token: 0x04000C95 RID: 3221
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem9;

		// Token: 0x04000C96 RID: 3222
		private global::Base.AutoComboBox cmbType;

		// Token: 0x04000C97 RID: 3223
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem6;

		// Token: 0x04000C98 RID: 3224
		private global::Base.AutoComboBox cmbTank;

		// Token: 0x04000C99 RID: 3225
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem10;

		// Token: 0x04000C9A RID: 3226
		private global::DevComponents.Editors.IntegerInput iInputCode;

		// Token: 0x04000C9B RID: 3227
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem11;

		// Token: 0x04000C9C RID: 3228
		private global::DevComponents.DotNetBar.Controls.CheckBoxX chkState;

		// Token: 0x04000C9D RID: 3229
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem12;
	}
}
