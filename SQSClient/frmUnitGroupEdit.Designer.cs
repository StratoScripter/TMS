namespace SQSClient
{
	// Token: 0x0200005F RID: 95
	public partial class frmUnitGroupEdit : global::SQSClient.BaseDialogForm
	{
		// Token: 0x06000492 RID: 1170 RVA: 0x00073384 File Offset: 0x00071584
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000493 RID: 1171 RVA: 0x000733BC File Offset: 0x000715BC
		private void InitializeComponent()
		{
			this.menuBar = new global::DevComponents.DotNetBar.Bar();
			this.btnSave = new global::DevComponents.DotNetBar.ButtonItem();
			this.layoutControl1 = new global::DevComponents.DotNetBar.Layout.LayoutControl();
			this.iInputMaxStartCount = new global::DevComponents.Editors.IntegerInput();
			this.iInputMinStartCount = new global::DevComponents.Editors.IntegerInput();
			this.iInputGroupIndex = new global::DevComponents.Editors.IntegerInput();
			this.txtGroupCode = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.rtxtRemark = new global::DevComponents.DotNetBar.Controls.RichTextBoxEx();
			this.chkState = new global::DevComponents.DotNetBar.Controls.CheckBoxX();
			this.cmbSpecialFunction = new global::DevComponents.DotNetBar.Controls.ComboBoxEx();
			this.txtGroupName = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.layName = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem1 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem2 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layState = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layDepartment = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem3 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem4 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layRemark = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			((global::System.ComponentModel.ISupportInitialize)this.menuBar).BeginInit();
			this.layoutControl1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.iInputMaxStartCount).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.iInputMinStartCount).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.iInputGroupIndex).BeginInit();
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
			this.layoutControl1.Controls.Add(this.iInputMaxStartCount);
			this.layoutControl1.Controls.Add(this.iInputMinStartCount);
			this.layoutControl1.Controls.Add(this.iInputGroupIndex);
			this.layoutControl1.Controls.Add(this.txtGroupCode);
			this.layoutControl1.Controls.Add(this.rtxtRemark);
			this.layoutControl1.Controls.Add(this.chkState);
			this.layoutControl1.Controls.Add(this.cmbSpecialFunction);
			this.layoutControl1.Controls.Add(this.txtGroupName);
			this.layoutControl1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.layoutControl1.Location = new global::System.Drawing.Point(0, 26);
			this.layoutControl1.Name = "layoutControl1";
			this.layoutControl1.RootGroup.Items.AddRange(new global::DevComponents.DotNetBar.Layout.LayoutItemBase[]
			{
				this.layName,
				this.layoutControlItem1,
				this.layoutControlItem2,
				this.layState,
				this.layDepartment,
				this.layoutControlItem3,
				this.layoutControlItem4,
				this.layRemark
			});
			this.layoutControl1.Size = new global::System.Drawing.Size(354, 346);
			this.layoutControl1.TabIndex = 21;
			this.iInputMaxStartCount.BackgroundStyle.Class = "DateTimeInputBackground";
			this.iInputMaxStartCount.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.iInputMaxStartCount.ButtonFreeText.Shortcut = global::DevComponents.DotNetBar.eShortcut.F2;
			this.iInputMaxStartCount.Enabled = false;
			this.iInputMaxStartCount.InputHorizontalAlignment = global::DevComponents.Editors.eHorizontalAlignment.Left;
			this.iInputMaxStartCount.Location = new global::System.Drawing.Point(104, 179);
			this.iInputMaxStartCount.Margin = new global::System.Windows.Forms.Padding(0);
			this.iInputMaxStartCount.Name = "iInputMaxStartCount";
			this.iInputMaxStartCount.ShowUpDown = true;
			this.iInputMaxStartCount.Size = new global::System.Drawing.Size(246, 21);
			this.iInputMaxStartCount.TabIndex = 6;
			this.iInputMaxStartCount.Value = 1;
			this.iInputMinStartCount.BackgroundStyle.Class = "DateTimeInputBackground";
			this.iInputMinStartCount.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.iInputMinStartCount.ButtonFreeText.Shortcut = global::DevComponents.DotNetBar.eShortcut.F2;
			this.iInputMinStartCount.Enabled = false;
			this.iInputMinStartCount.InputHorizontalAlignment = global::DevComponents.Editors.eHorizontalAlignment.Left;
			this.iInputMinStartCount.Location = new global::System.Drawing.Point(104, 150);
			this.iInputMinStartCount.Margin = new global::System.Windows.Forms.Padding(0);
			this.iInputMinStartCount.Name = "iInputMinStartCount";
			this.iInputMinStartCount.ShowUpDown = true;
			this.iInputMinStartCount.Size = new global::System.Drawing.Size(246, 21);
			this.iInputMinStartCount.TabIndex = 5;
			this.iInputMinStartCount.Value = 1;
			this.iInputGroupIndex.BackgroundStyle.Class = "DateTimeInputBackground";
			this.iInputGroupIndex.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.iInputGroupIndex.ButtonFreeText.Shortcut = global::DevComponents.DotNetBar.eShortcut.F2;
			this.iInputGroupIndex.InputHorizontalAlignment = global::DevComponents.Editors.eHorizontalAlignment.Left;
			this.iInputGroupIndex.Location = new global::System.Drawing.Point(104, 62);
			this.iInputGroupIndex.Margin = new global::System.Windows.Forms.Padding(0);
			this.iInputGroupIndex.Name = "iInputGroupIndex";
			this.iInputGroupIndex.ShowUpDown = true;
			this.iInputGroupIndex.Size = new global::System.Drawing.Size(246, 21);
			this.iInputGroupIndex.TabIndex = 2;
			this.iInputGroupIndex.Value = 1;
			this.txtGroupCode.Border.Class = "TextBoxBorder";
			this.txtGroupCode.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtGroupCode.Location = new global::System.Drawing.Point(104, 33);
			this.txtGroupCode.Margin = new global::System.Windows.Forms.Padding(0);
			this.txtGroupCode.Name = "txtGroupCode";
			this.txtGroupCode.PreventEnterBeep = true;
			this.txtGroupCode.Size = new global::System.Drawing.Size(246, 21);
			this.txtGroupCode.TabIndex = 1;
			this.rtxtRemark.BackgroundStyle.Class = "RichTextBoxBorder";
			this.rtxtRemark.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.rtxtRemark.Location = new global::System.Drawing.Point(104, 208);
			this.rtxtRemark.Margin = new global::System.Windows.Forms.Padding(0);
			this.rtxtRemark.Name = "rtxtRemark";
			this.rtxtRemark.Rtf = "{\\rtf1\\ansi\\ansicpg936\\deff0\\deflang1033\\deflangfe2052{\\fonttbl{\\f0\\fnil\\fcharset134 \\'cb\\'ce\\'cc\\'e5;}}\r\n\\viewkind4\\uc1\\pard\\lang2052\\f0\\fs18\\par\r\n}\r\n";
			this.rtxtRemark.Size = new global::System.Drawing.Size(246, 50);
			this.rtxtRemark.TabIndex = 7;
			this.chkState.AutoSize = true;
			this.chkState.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.chkState.Enabled = false;
			this.chkState.Location = new global::System.Drawing.Point(104, 91);
			this.chkState.Margin = new global::System.Windows.Forms.Padding(0);
			this.chkState.Name = "chkState";
			this.chkState.Size = new global::System.Drawing.Size(64, 16);
			this.chkState.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.chkState.TabIndex = 3;
			this.chkState.Text = "Enable";
			this.cmbSpecialFunction.DisplayMember = "Text";
			this.cmbSpecialFunction.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cmbSpecialFunction.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbSpecialFunction.Enabled = false;
			this.cmbSpecialFunction.FormattingEnabled = true;
			this.cmbSpecialFunction.ItemHeight = 15;
			this.cmbSpecialFunction.Location = new global::System.Drawing.Point(104, 122);
			this.cmbSpecialFunction.Margin = new global::System.Windows.Forms.Padding(0);
			this.cmbSpecialFunction.Name = "cmbSpecialFunction";
			this.cmbSpecialFunction.Size = new global::System.Drawing.Size(246, 21);
			this.cmbSpecialFunction.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.cmbSpecialFunction.TabIndex = 4;
			this.txtGroupName.Border.Class = "TextBoxBorder";
			this.txtGroupName.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtGroupName.Location = new global::System.Drawing.Point(104, 4);
			this.txtGroupName.Margin = new global::System.Windows.Forms.Padding(0);
			this.txtGroupName.Name = "txtGroupName";
			this.txtGroupName.PreventEnterBeep = true;
			this.txtGroupName.Size = new global::System.Drawing.Size(246, 21);
			this.txtGroupName.TabIndex = 0;
			this.layName.Control = this.txtGroupName;
			this.layName.Height = 29;
			this.layName.MinSize = new global::System.Drawing.Size(120, 0);
			this.layName.Name = "layName";
			this.layName.Text = "GroupName";
			this.layName.Width = 100;
			this.layName.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem1.Control = this.txtGroupCode;
			this.layoutControlItem1.Height = 29;
			this.layoutControlItem1.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Text = "GroupCode";
			this.layoutControlItem1.Width = 100;
			this.layoutControlItem1.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem2.Control = this.iInputGroupIndex;
			this.layoutControlItem2.Height = 29;
			this.layoutControlItem2.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem2.Name = "layoutControlItem2";
			this.layoutControlItem2.Text = "GroupIndex";
			this.layoutControlItem2.Width = 100;
			this.layoutControlItem2.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layState.Control = this.chkState;
			this.layState.Height = 31;
			this.layState.MinSize = new global::System.Drawing.Size(64, 18);
			this.layState.Name = "layState";
			this.layState.Text = "SpecialFunction";
			this.layState.Width = 83;
			this.layState.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layDepartment.Control = this.cmbSpecialFunction;
			this.layDepartment.Height = 28;
			this.layDepartment.MinSize = new global::System.Drawing.Size(64, 18);
			this.layDepartment.Name = "layDepartment";
			this.layDepartment.Text = "Function";
			this.layDepartment.Width = 129;
			this.layDepartment.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem3.Control = this.iInputMinStartCount;
			this.layoutControlItem3.Height = 29;
			this.layoutControlItem3.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem3.Name = "layoutControlItem3";
			this.layoutControlItem3.Text = "MinStartCount";
			this.layoutControlItem3.Width = 100;
			this.layoutControlItem3.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem4.Control = this.iInputMaxStartCount;
			this.layoutControlItem4.Height = 29;
			this.layoutControlItem4.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem4.Name = "layoutControlItem4";
			this.layoutControlItem4.Text = "MaxStartCount";
			this.layoutControlItem4.Width = 100;
			this.layoutControlItem4.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layRemark.Control = this.rtxtRemark;
			this.layRemark.Height = 58;
			this.layRemark.MinSize = new global::System.Drawing.Size(64, 18);
			this.layRemark.Name = "layRemark";
			this.layRemark.Text = "Remark";
			this.layRemark.Width = 108;
			this.layRemark.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			base.ClientSize = new global::System.Drawing.Size(354, 372);
			base.Controls.Add(this.layoutControl1);
			base.Controls.Add(this.menuBar);
			base.Name = "frmUnitGroupEdit";
			this.Text = "frmUnitGroupEdit";
			base.Load += new global::System.EventHandler(this.frmUnitGroupEdit_Load);
			((global::System.ComponentModel.ISupportInitialize)this.menuBar).EndInit();
			this.layoutControl1.ResumeLayout(false);
			this.layoutControl1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.iInputMaxStartCount).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.iInputMinStartCount).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.iInputGroupIndex).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x040007E8 RID: 2024
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x040007E9 RID: 2025
		private global::DevComponents.DotNetBar.Bar menuBar;

		// Token: 0x040007EA RID: 2026
		private global::DevComponents.DotNetBar.ButtonItem btnSave;

		// Token: 0x040007EB RID: 2027
		private global::DevComponents.DotNetBar.Layout.LayoutControl layoutControl1;

		// Token: 0x040007EC RID: 2028
		private global::DevComponents.DotNetBar.Controls.RichTextBoxEx rtxtRemark;

		// Token: 0x040007ED RID: 2029
		private global::DevComponents.DotNetBar.Controls.CheckBoxX chkState;

		// Token: 0x040007EE RID: 2030
		private global::DevComponents.DotNetBar.Controls.ComboBoxEx cmbSpecialFunction;

		// Token: 0x040007EF RID: 2031
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtGroupName;

		// Token: 0x040007F0 RID: 2032
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layName;

		// Token: 0x040007F1 RID: 2033
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layDepartment;

		// Token: 0x040007F2 RID: 2034
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layState;

		// Token: 0x040007F3 RID: 2035
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layRemark;

		// Token: 0x040007F4 RID: 2036
		private global::DevComponents.Editors.IntegerInput iInputMaxStartCount;

		// Token: 0x040007F5 RID: 2037
		private global::DevComponents.Editors.IntegerInput iInputMinStartCount;

		// Token: 0x040007F6 RID: 2038
		private global::DevComponents.Editors.IntegerInput iInputGroupIndex;

		// Token: 0x040007F7 RID: 2039
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtGroupCode;

		// Token: 0x040007F8 RID: 2040
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem1;

		// Token: 0x040007F9 RID: 2041
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem2;

		// Token: 0x040007FA RID: 2042
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem3;

		// Token: 0x040007FB RID: 2043
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem4;
	}
}
