namespace SQSClient
{
	// Token: 0x0200005D RID: 93
	public partial class frmWeighbridgeEdit : global::SQSClient.BaseDialogForm
	{
		// Token: 0x0600047A RID: 1146 RVA: 0x00070CAC File Offset: 0x0006EEAC
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600047B RID: 1147 RVA: 0x00070CE4 File Offset: 0x0006EEE4
		private void InitializeComponent()
		{
			this.menuBar = new global::DevComponents.DotNetBar.Bar();
			this.btnSave = new global::DevComponents.DotNetBar.ButtonItem();
			this.layoutControl1 = new global::DevComponents.DotNetBar.Layout.LayoutControl();
			this.chkEnable = new global::DevComponents.DotNetBar.Controls.CheckBoxX();
			this.txtDBConn = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.rtxtRemark = new global::DevComponents.DotNetBar.Controls.RichTextBoxEx();
			this.txtName = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.iInputCode = new global::DevComponents.Editors.IntegerInput();
			this.layoutControlItem1 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem8 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem2 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem3 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem5 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.cmbModeType = new global::Base.AutoComboBox();
			this.layoutControlItem4 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.txtTableName = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.layoutControlItem6 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.txtTruckItem = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.layoutControlItem7 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.txtFirstTimeItem = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.layoutControlItem9 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.txtSecondTimeItem = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.layoutControlItem10 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.txtFirstWeightItem = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.layoutControlItem11 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.txtSecondWeightItem = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.layoutControlItem12 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			((global::System.ComponentModel.ISupportInitialize)this.menuBar).BeginInit();
			this.layoutControl1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.iInputCode).BeginInit();
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
			this.menuBar.TabIndex = 23;
			this.menuBar.TabStop = false;
			this.menuBar.Text = "Main Menu";
			this.btnSave.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.btnSave.Image = global::SQSClient.Properties.Resources.save16;
			this.btnSave.Name = "btnSave";
			this.btnSave.Text = "Save";
			this.btnSave.Click += new global::System.EventHandler(this.btnSave_Click);
			this.layoutControl1.Controls.Add(this.txtSecondWeightItem);
			this.layoutControl1.Controls.Add(this.txtFirstWeightItem);
			this.layoutControl1.Controls.Add(this.txtSecondTimeItem);
			this.layoutControl1.Controls.Add(this.txtFirstTimeItem);
			this.layoutControl1.Controls.Add(this.txtTruckItem);
			this.layoutControl1.Controls.Add(this.txtTableName);
			this.layoutControl1.Controls.Add(this.cmbModeType);
			this.layoutControl1.Controls.Add(this.chkEnable);
			this.layoutControl1.Controls.Add(this.txtDBConn);
			this.layoutControl1.Controls.Add(this.rtxtRemark);
			this.layoutControl1.Controls.Add(this.txtName);
			this.layoutControl1.Controls.Add(this.iInputCode);
			this.layoutControl1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.layoutControl1.Location = new global::System.Drawing.Point(0, 26);
			this.layoutControl1.Name = "layoutControl1";
			this.layoutControl1.RootGroup.Items.AddRange(new global::DevComponents.DotNetBar.Layout.LayoutItemBase[]
			{
				this.layoutControlItem1,
				this.layoutControlItem8,
				this.layoutControlItem4,
				this.layoutControlItem2,
				this.layoutControlItem6,
				this.layoutControlItem7,
				this.layoutControlItem9,
				this.layoutControlItem10,
				this.layoutControlItem11,
				this.layoutControlItem12,
				this.layoutControlItem3,
				this.layoutControlItem5
			});
			this.layoutControl1.Size = new global::System.Drawing.Size(354, 410);
			this.layoutControl1.TabIndex = 24;
			this.chkEnable.AutoSize = true;
			this.chkEnable.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.chkEnable.Checked = true;
			this.chkEnable.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.chkEnable.CheckValue = "Y";
			this.chkEnable.Location = new global::System.Drawing.Point(117, 322);
			this.chkEnable.Margin = new global::System.Windows.Forms.Padding(0);
			this.chkEnable.Name = "chkEnable";
			this.chkEnable.Size = new global::System.Drawing.Size(64, 16);
			this.chkEnable.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.chkEnable.TabIndex = 10;
			this.chkEnable.Text = "Enable";
			this.txtDBConn.Border.Class = "TextBoxBorder";
			this.txtDBConn.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtDBConn.Location = new global::System.Drawing.Point(117, 90);
			this.txtDBConn.Margin = new global::System.Windows.Forms.Padding(0);
			this.txtDBConn.Multiline = true;
			this.txtDBConn.Name = "txtDBConn";
			this.txtDBConn.PreventEnterBeep = true;
			this.txtDBConn.Size = new global::System.Drawing.Size(233, 50);
			this.txtDBConn.TabIndex = 3;
			this.rtxtRemark.BackgroundStyle.Class = "RichTextBoxBorder";
			this.rtxtRemark.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.rtxtRemark.Location = new global::System.Drawing.Point(117, 353);
			this.rtxtRemark.Margin = new global::System.Windows.Forms.Padding(0);
			this.rtxtRemark.MaxLength = 200;
			this.rtxtRemark.Name = "rtxtRemark";
			this.rtxtRemark.Rtf = "{\\rtf1\\ansi\\ansicpg936\\deff0\\deflang1033\\deflangfe2052{\\fonttbl{\\f0\\fnil\\fcharset134 \\'cb\\'ce\\'cc\\'e5;}}\r\n\\viewkind4\\uc1\\pard\\lang2052\\f0\\fs18\\par\r\n}\r\n";
			this.rtxtRemark.Size = new global::System.Drawing.Size(233, 50);
			this.rtxtRemark.TabIndex = 11;
			this.txtName.Border.Class = "TextBoxBorder";
			this.txtName.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtName.Location = new global::System.Drawing.Point(117, 4);
			this.txtName.Margin = new global::System.Windows.Forms.Padding(0);
			this.txtName.MaxLength = 20;
			this.txtName.Name = "txtName";
			this.txtName.PreventEnterBeep = true;
			this.txtName.Size = new global::System.Drawing.Size(233, 21);
			this.txtName.TabIndex = 0;
			this.iInputCode.BackgroundStyle.Class = "DateTimeInputBackground";
			this.iInputCode.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.iInputCode.ButtonFreeText.Shortcut = global::DevComponents.DotNetBar.eShortcut.F2;
			this.iInputCode.InputHorizontalAlignment = global::DevComponents.Editors.eHorizontalAlignment.Left;
			this.iInputCode.Location = new global::System.Drawing.Point(117, 33);
			this.iInputCode.Margin = new global::System.Windows.Forms.Padding(0);
			this.iInputCode.MaxValue = 999;
			this.iInputCode.MinValue = 1;
			this.iInputCode.Name = "iInputCode";
			this.iInputCode.ShowUpDown = true;
			this.iInputCode.Size = new global::System.Drawing.Size(233, 21);
			this.iInputCode.TabIndex = 1;
			this.iInputCode.Value = 1;
			this.layoutControlItem1.Control = this.txtName;
			this.layoutControlItem1.Height = 29;
			this.layoutControlItem1.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Text = "*WeighbridgeName";
			this.layoutControlItem1.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem1.Width = 100;
			this.layoutControlItem1.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem8.Control = this.iInputCode;
			this.layoutControlItem8.Height = 29;
			this.layoutControlItem8.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem8.Name = "layoutControlItem8";
			this.layoutControlItem8.Text = "*WeighbridgeCode";
			this.layoutControlItem8.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem8.Width = 100;
			this.layoutControlItem8.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem2.Control = this.txtDBConn;
			this.layoutControlItem2.Height = 58;
			this.layoutControlItem2.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem2.Name = "layoutControlItem2";
			this.layoutControlItem2.Text = "DBConn";
			this.layoutControlItem2.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem2.Width = 100;
			this.layoutControlItem2.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem3.Control = this.chkEnable;
			this.layoutControlItem3.Height = 31;
			this.layoutControlItem3.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem3.Name = "layoutControlItem3";
			this.layoutControlItem3.Text = " ";
			this.layoutControlItem3.Width = 83;
			this.layoutControlItem3.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem5.Control = this.rtxtRemark;
			this.layoutControlItem5.Height = 58;
			this.layoutControlItem5.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem5.Name = "layoutControlItem5";
			this.layoutControlItem5.Text = "Remark";
			this.layoutControlItem5.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem5.Width = 100;
			this.layoutControlItem5.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.cmbModeType.DataSource = null;
			this.cmbModeType.DisplayMember = null;
			this.cmbModeType.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cmbModeType.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbModeType.FormattingEnabled = true;
			this.cmbModeType.ItemHeight = 16;
			this.cmbModeType.Location = new global::System.Drawing.Point(117, 62);
			this.cmbModeType.Margin = new global::System.Windows.Forms.Padding(0, 0, 0, 0);
			this.cmbModeType.MaxDropDownItems = 20;
			this.cmbModeType.Name = "cmbModeType";
			this.cmbModeType.SelectMember = null;
			this.cmbModeType.Size = new global::System.Drawing.Size(233, 22);
			this.cmbModeType.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.cmbModeType.TabIndex = 2;
			this.cmbModeType.ValueMember = null;
			this.cmbModeType.TextChanged += new global::System.EventHandler(this.cmbModeType_TextChanged);
			this.layoutControlItem4.Control = this.cmbModeType;
			this.layoutControlItem4.Height = 28;
			this.layoutControlItem4.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem4.Name = "layoutControlItem4";
			this.layoutControlItem4.Text = "ModeType";
			this.layoutControlItem4.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem4.Width = 100;
			this.layoutControlItem4.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.txtTableName.Border.Class = "TextBoxBorder";
			this.txtTableName.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtTableName.Location = new global::System.Drawing.Point(117, 148);
			this.txtTableName.Margin = new global::System.Windows.Forms.Padding(0, 0, 0, 0);
			this.txtTableName.Name = "txtTableName";
			this.txtTableName.PreventEnterBeep = true;
			this.txtTableName.Size = new global::System.Drawing.Size(233, 21);
			this.txtTableName.TabIndex = 4;
			this.layoutControlItem6.Control = this.txtTableName;
			this.layoutControlItem6.Height = 29;
			this.layoutControlItem6.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem6.Name = "layoutControlItem6";
			this.layoutControlItem6.Text = "*TableName";
			this.layoutControlItem6.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem6.Width = 100;
			this.layoutControlItem6.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.txtTruckItem.Border.Class = "TextBoxBorder";
			this.txtTruckItem.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtTruckItem.Location = new global::System.Drawing.Point(117, 177);
			this.txtTruckItem.Margin = new global::System.Windows.Forms.Padding(0, 0, 0, 0);
			this.txtTruckItem.Name = "txtTruckItem";
			this.txtTruckItem.PreventEnterBeep = true;
			this.txtTruckItem.Size = new global::System.Drawing.Size(233, 21);
			this.txtTruckItem.TabIndex = 5;
			this.layoutControlItem7.Control = this.txtTruckItem;
			this.layoutControlItem7.Height = 29;
			this.layoutControlItem7.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem7.Name = "layoutControlItem7";
			this.layoutControlItem7.Text = "*TruckItem";
			this.layoutControlItem7.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem7.Width = 100;
			this.layoutControlItem7.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.txtFirstTimeItem.Border.Class = "TextBoxBorder";
			this.txtFirstTimeItem.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtFirstTimeItem.Location = new global::System.Drawing.Point(117, 206);
			this.txtFirstTimeItem.Margin = new global::System.Windows.Forms.Padding(0, 0, 0, 0);
			this.txtFirstTimeItem.Name = "txtFirstTimeItem";
			this.txtFirstTimeItem.PreventEnterBeep = true;
			this.txtFirstTimeItem.Size = new global::System.Drawing.Size(233, 21);
			this.txtFirstTimeItem.TabIndex = 6;
			this.layoutControlItem9.Control = this.txtFirstTimeItem;
			this.layoutControlItem9.Height = 29;
			this.layoutControlItem9.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem9.Name = "layoutControlItem9";
			this.layoutControlItem9.Text = "*FirstTimeItem";
			this.layoutControlItem9.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem9.Width = 100;
			this.layoutControlItem9.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.txtSecondTimeItem.Border.Class = "TextBoxBorder";
			this.txtSecondTimeItem.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtSecondTimeItem.Location = new global::System.Drawing.Point(117, 235);
			this.txtSecondTimeItem.Margin = new global::System.Windows.Forms.Padding(0, 0, 0, 0);
			this.txtSecondTimeItem.Name = "txtSecondTimeItem";
			this.txtSecondTimeItem.PreventEnterBeep = true;
			this.txtSecondTimeItem.Size = new global::System.Drawing.Size(233, 21);
			this.txtSecondTimeItem.TabIndex = 7;
			this.layoutControlItem10.Control = this.txtSecondTimeItem;
			this.layoutControlItem10.Height = 29;
			this.layoutControlItem10.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem10.Name = "layoutControlItem10";
			this.layoutControlItem10.Text = "*SecondTimeItem";
			this.layoutControlItem10.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem10.Width = 100;
			this.layoutControlItem10.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.txtFirstWeightItem.Border.Class = "TextBoxBorder";
			this.txtFirstWeightItem.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtFirstWeightItem.Location = new global::System.Drawing.Point(117, 264);
			this.txtFirstWeightItem.Margin = new global::System.Windows.Forms.Padding(0, 0, 0, 0);
			this.txtFirstWeightItem.Name = "txtFirstWeightItem";
			this.txtFirstWeightItem.PreventEnterBeep = true;
			this.txtFirstWeightItem.Size = new global::System.Drawing.Size(233, 21);
			this.txtFirstWeightItem.TabIndex = 8;
			this.layoutControlItem11.Control = this.txtFirstWeightItem;
			this.layoutControlItem11.Height = 29;
			this.layoutControlItem11.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem11.Name = "layoutControlItem11";
			this.layoutControlItem11.Text = "*FirstWeightItem";
			this.layoutControlItem11.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem11.Width = 100;
			this.layoutControlItem11.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.txtSecondWeightItem.Border.Class = "TextBoxBorder";
			this.txtSecondWeightItem.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtSecondWeightItem.Location = new global::System.Drawing.Point(117, 293);
			this.txtSecondWeightItem.Margin = new global::System.Windows.Forms.Padding(0, 0, 0, 0);
			this.txtSecondWeightItem.Name = "txtSecondWeightItem";
			this.txtSecondWeightItem.PreventEnterBeep = true;
			this.txtSecondWeightItem.Size = new global::System.Drawing.Size(233, 21);
			this.txtSecondWeightItem.TabIndex = 9;
			this.layoutControlItem12.Control = this.txtSecondWeightItem;
			this.layoutControlItem12.Height = 29;
			this.layoutControlItem12.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem12.Name = "layoutControlItem12";
			this.layoutControlItem12.Text = "*SecondWeightItem";
			this.layoutControlItem12.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem12.Width = 100;
			this.layoutControlItem12.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			base.ClientSize = new global::System.Drawing.Size(354, 436);
			base.Controls.Add(this.layoutControl1);
			base.Controls.Add(this.menuBar);
			base.Name = "frmWeighbridgeEdit";
			this.Text = "frmWeighbridgeEdit";
			base.Load += new global::System.EventHandler(this.frmWeighbridgeEdit_Load);
			((global::System.ComponentModel.ISupportInitialize)this.menuBar).EndInit();
			this.layoutControl1.ResumeLayout(false);
			this.layoutControl1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.iInputCode).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x040007B5 RID: 1973
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x040007B6 RID: 1974
		private global::DevComponents.DotNetBar.Bar menuBar;

		// Token: 0x040007B7 RID: 1975
		private global::DevComponents.DotNetBar.ButtonItem btnSave;

		// Token: 0x040007B8 RID: 1976
		private global::DevComponents.DotNetBar.Layout.LayoutControl layoutControl1;

		// Token: 0x040007B9 RID: 1977
		private global::DevComponents.DotNetBar.Controls.RichTextBoxEx rtxtRemark;

		// Token: 0x040007BA RID: 1978
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtName;

		// Token: 0x040007BB RID: 1979
		private global::DevComponents.Editors.IntegerInput iInputCode;

		// Token: 0x040007BC RID: 1980
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem1;

		// Token: 0x040007BD RID: 1981
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem8;

		// Token: 0x040007BE RID: 1982
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem5;

		// Token: 0x040007BF RID: 1983
		private global::DevComponents.DotNetBar.Controls.CheckBoxX chkEnable;

		// Token: 0x040007C0 RID: 1984
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtDBConn;

		// Token: 0x040007C1 RID: 1985
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem2;

		// Token: 0x040007C2 RID: 1986
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem3;

		// Token: 0x040007C3 RID: 1987
		private global::Base.AutoComboBox cmbModeType;

		// Token: 0x040007C4 RID: 1988
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem4;

		// Token: 0x040007C5 RID: 1989
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtSecondWeightItem;

		// Token: 0x040007C6 RID: 1990
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtFirstWeightItem;

		// Token: 0x040007C7 RID: 1991
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtSecondTimeItem;

		// Token: 0x040007C8 RID: 1992
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtFirstTimeItem;

		// Token: 0x040007C9 RID: 1993
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtTruckItem;

		// Token: 0x040007CA RID: 1994
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtTableName;

		// Token: 0x040007CB RID: 1995
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem6;

		// Token: 0x040007CC RID: 1996
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem7;

		// Token: 0x040007CD RID: 1997
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem9;

		// Token: 0x040007CE RID: 1998
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem10;

		// Token: 0x040007CF RID: 1999
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem11;

		// Token: 0x040007D0 RID: 2000
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem12;
	}
}
