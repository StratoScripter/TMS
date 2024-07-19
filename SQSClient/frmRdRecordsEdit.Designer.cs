namespace SQSClient
{
	// Token: 0x02000049 RID: 73
	public partial class frmRdRecordsEdit : global::SQSClient.BaseDialogForm
	{
		// Token: 0x0600036F RID: 879 RVA: 0x00055C90 File Offset: 0x00053E90
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000370 RID: 880 RVA: 0x00055CC8 File Offset: 0x00053EC8
		private void InitializeComponent()
		{
			this.menuBar = new global::DevComponents.DotNetBar.Bar();
			this.btnSave = new global::DevComponents.DotNetBar.ButtonItem();
			this.pnlConfig = new global::DevComponents.DotNetBar.Layout.LayoutControl();
			this.cmbProduct = new global::Base.AutoComboBox();
			this.iInputBillSort = new global::DevComponents.Editors.IntegerInput();
			this.nudQuantity = new global::DevComponents.Editors.DoubleInput();
			this.txtPositionInfo = new global::DevComponents.DotNetBar.Controls.RichTextBoxEx();
			this.cmbBatchCode = new global::Base.AutoComboBox();
			this.txtInvCode = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.cmbRdsStatus = new global::DevComponents.DotNetBar.Controls.ComboBoxEx();
			this.cmbRdsState = new global::DevComponents.DotNetBar.Controls.ComboBoxEx();
			this.txtInvName = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.txtCurrStockVol = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.txtExtBarCode = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.layoutControlItem8 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem6 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem5 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem13 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem7 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem9 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem15 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem1 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem3 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem11 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem4 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem22 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem12 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem14 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem2 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			((global::System.ComponentModel.ISupportInitialize)this.menuBar).BeginInit();
			this.pnlConfig.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.iInputBillSort).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudQuantity).BeginInit();
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
			this.menuBar.Size = new global::System.Drawing.Size(425, 26);
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
			this.pnlConfig.Controls.Add(this.cmbProduct);
			this.pnlConfig.Controls.Add(this.iInputBillSort);
			this.pnlConfig.Controls.Add(this.nudQuantity);
			this.pnlConfig.Controls.Add(this.txtPositionInfo);
			this.pnlConfig.Controls.Add(this.cmbBatchCode);
			this.pnlConfig.Controls.Add(this.txtInvCode);
			this.pnlConfig.Controls.Add(this.cmbRdsStatus);
			this.pnlConfig.Controls.Add(this.cmbRdsState);
			this.pnlConfig.Controls.Add(this.txtInvName);
			this.pnlConfig.Controls.Add(this.txtCurrStockVol);
			this.pnlConfig.Controls.Add(this.txtExtBarCode);
			this.pnlConfig.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.pnlConfig.Location = new global::System.Drawing.Point(0, 26);
			this.pnlConfig.Name = "pnlConfig";
			this.pnlConfig.RootGroup.Items.AddRange(new global::DevComponents.DotNetBar.Layout.LayoutItemBase[]
			{
				this.layoutControlItem8,
				this.layoutControlItem6,
				this.layoutControlItem5,
				this.layoutControlItem13,
				this.layoutControlItem7,
				this.layoutControlItem15,
				this.layoutControlItem1,
				this.layoutControlItem9,
				this.layoutControlItem3,
				this.layoutControlItem11,
				this.layoutControlItem4
			});
			this.pnlConfig.Size = new global::System.Drawing.Size(425, 306);
			this.pnlConfig.TabIndex = 21;
			this.cmbProduct.DataSource = null;
			this.cmbProduct.DisplayMember = null;
			this.cmbProduct.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cmbProduct.FormattingEnabled = true;
			this.cmbProduct.ItemHeight = 15;
			this.cmbProduct.Location = new global::System.Drawing.Point(86, 33);
			this.cmbProduct.Margin = new global::System.Windows.Forms.Padding(0);
			this.cmbProduct.MaxDropDownItems = 20;
			this.cmbProduct.Name = "cmbProduct";
			this.cmbProduct.SelectMember = null;
			this.cmbProduct.Size = new global::System.Drawing.Size(335, 21);
			this.cmbProduct.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.cmbProduct.TabIndex = 1;
			this.cmbProduct.ValueMember = null;
			this.cmbProduct.SelectedIndexChanged += new global::System.EventHandler(this.cmbProduct_SelectedIndexChanged);
			this.iInputBillSort.BackgroundStyle.Class = "DateTimeInputBackground";
			this.iInputBillSort.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.iInputBillSort.ButtonFreeText.Shortcut = global::DevComponents.DotNetBar.eShortcut.F2;
			this.iInputBillSort.InputHorizontalAlignment = global::DevComponents.Editors.eHorizontalAlignment.Left;
			this.iInputBillSort.Location = new global::System.Drawing.Point(86, 4);
			this.iInputBillSort.Margin = new global::System.Windows.Forms.Padding(0);
			this.iInputBillSort.Name = "iInputBillSort";
			this.iInputBillSort.ShowUpDown = true;
			this.iInputBillSort.Size = new global::System.Drawing.Size(335, 21);
			this.iInputBillSort.TabIndex = 0;
			this.iInputBillSort.Value = 1;
			this.nudQuantity.BackgroundStyle.Class = "DateTimeInputBackground";
			this.nudQuantity.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.nudQuantity.ButtonFreeText.Shortcut = global::DevComponents.DotNetBar.eShortcut.F2;
			this.nudQuantity.Increment = 1.0;
			this.nudQuantity.InputHorizontalAlignment = global::DevComponents.Editors.eHorizontalAlignment.Left;
			this.nudQuantity.Location = new global::System.Drawing.Point(298, 119);
			this.nudQuantity.Margin = new global::System.Windows.Forms.Padding(0);
			this.nudQuantity.MaxValue = 99999999.0;
			this.nudQuantity.MinValue = 0.0;
			this.nudQuantity.Name = "nudQuantity";
			this.nudQuantity.ShowUpDown = true;
			this.nudQuantity.Size = new global::System.Drawing.Size(123, 21);
			this.nudQuantity.TabIndex = 6;
			this.txtPositionInfo.BackgroundStyle.Class = "RichTextBoxBorder";
			this.txtPositionInfo.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtPositionInfo.Location = new global::System.Drawing.Point(86, 206);
			this.txtPositionInfo.Margin = new global::System.Windows.Forms.Padding(0);
			this.txtPositionInfo.MaxLength = 200;
			this.txtPositionInfo.Name = "txtPositionInfo";
			this.txtPositionInfo.Rtf = "{\\rtf1\\ansi\\ansicpg936\\deff0\\nouicompat\\deflang1033\\deflangfe2052{\\fonttbl{\\f0\\fnil\\fcharset134 \\'cb\\'ce\\'cc\\'e5;}}\r\n{\\*\\generator Riched20 10.0.18362}\\viewkind4\\uc1 \r\n\\pard\\f0\\fs18\\lang2052\\par\r\n}\r\n";
			this.txtPositionInfo.Size = new global::System.Drawing.Size(335, 52);
			this.txtPositionInfo.TabIndex = 10;
			this.cmbBatchCode.DataSource = null;
			this.cmbBatchCode.DisplayMember = null;
			this.cmbBatchCode.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cmbBatchCode.FormattingEnabled = true;
			this.cmbBatchCode.ItemHeight = 15;
			this.cmbBatchCode.Location = new global::System.Drawing.Point(86, 90);
			this.cmbBatchCode.Margin = new global::System.Windows.Forms.Padding(0);
			this.cmbBatchCode.MaxDropDownItems = 20;
			this.cmbBatchCode.Name = "cmbBatchCode";
			this.cmbBatchCode.SelectMember = null;
			this.cmbBatchCode.Size = new global::System.Drawing.Size(335, 21);
			this.cmbBatchCode.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.cmbBatchCode.TabIndex = 4;
			this.cmbBatchCode.ValueMember = null;
			this.cmbBatchCode.SelectedIndexChanged += new global::System.EventHandler(this.cmbBatchCode_SelectedIndexChanged);
			this.txtInvCode.Border.Class = "TextBoxBorder";
			this.txtInvCode.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtInvCode.Location = new global::System.Drawing.Point(86, 61);
			this.txtInvCode.Margin = new global::System.Windows.Forms.Padding(0);
			this.txtInvCode.Name = "txtInvCode";
			this.txtInvCode.PreventEnterBeep = true;
			this.txtInvCode.Size = new global::System.Drawing.Size(122, 21);
			this.txtInvCode.TabIndex = 2;
			this.cmbRdsStatus.DisplayMember = "Text";
			this.cmbRdsStatus.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cmbRdsStatus.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbRdsStatus.FormattingEnabled = true;
			this.cmbRdsStatus.ItemHeight = 15;
			this.cmbRdsStatus.Location = new global::System.Drawing.Point(86, 177);
			this.cmbRdsStatus.Margin = new global::System.Windows.Forms.Padding(0);
			this.cmbRdsStatus.Name = "cmbRdsStatus";
			this.cmbRdsStatus.Size = new global::System.Drawing.Size(122, 21);
			this.cmbRdsStatus.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.cmbRdsStatus.TabIndex = 8;
			this.cmbRdsState.DisplayMember = "Text";
			this.cmbRdsState.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cmbRdsState.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbRdsState.FormattingEnabled = true;
			this.cmbRdsState.ItemHeight = 15;
			this.cmbRdsState.Location = new global::System.Drawing.Point(298, 177);
			this.cmbRdsState.Margin = new global::System.Windows.Forms.Padding(0);
			this.cmbRdsState.Name = "cmbRdsState";
			this.cmbRdsState.Size = new global::System.Drawing.Size(123, 21);
			this.cmbRdsState.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.cmbRdsState.TabIndex = 9;
			this.txtInvName.Border.Class = "TextBoxBorder";
			this.txtInvName.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtInvName.Location = new global::System.Drawing.Point(298, 61);
			this.txtInvName.Margin = new global::System.Windows.Forms.Padding(0);
			this.txtInvName.Name = "txtInvName";
			this.txtInvName.PreventEnterBeep = true;
			this.txtInvName.Size = new global::System.Drawing.Size(123, 21);
			this.txtInvName.TabIndex = 3;
			this.txtCurrStockVol.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtCurrStockVol.Location = new global::System.Drawing.Point(86, 119);
			this.txtCurrStockVol.Margin = new global::System.Windows.Forms.Padding(0);
			this.txtCurrStockVol.Name = "txtCurrStockVol";
			this.txtCurrStockVol.PreventEnterBeep = true;
			this.txtCurrStockVol.Size = new global::System.Drawing.Size(122, 21);
			this.txtCurrStockVol.TabIndex = 5;
			this.txtExtBarCode.Border.Class = "TextBoxBorder";
			this.txtExtBarCode.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtExtBarCode.Location = new global::System.Drawing.Point(86, 148);
			this.txtExtBarCode.Margin = new global::System.Windows.Forms.Padding(0);
			this.txtExtBarCode.Name = "txtExtBarCode";
			this.txtExtBarCode.PreventEnterBeep = true;
			this.txtExtBarCode.Size = new global::System.Drawing.Size(335, 21);
			this.txtExtBarCode.TabIndex = 7;
			this.layoutControlItem8.Control = this.iInputBillSort;
			this.layoutControlItem8.Height = 29;
			this.layoutControlItem8.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem8.Name = "layoutControlItem8";
			this.layoutControlItem8.Text = "BillSort";
			this.layoutControlItem8.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem8.Width = 100;
			this.layoutControlItem8.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem6.Control = this.cmbProduct;
			this.layoutControlItem6.Height = 28;
			this.layoutControlItem6.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem6.Name = "layoutControlItem6";
			this.layoutControlItem6.Text = "Product";
			this.layoutControlItem6.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem6.Width = 100;
			this.layoutControlItem6.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem5.Control = this.txtInvCode;
			this.layoutControlItem5.Height = 29;
			this.layoutControlItem5.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem5.Name = "layoutControlItem5";
			this.layoutControlItem5.Text = "InvCode";
			this.layoutControlItem5.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem5.Width = 50;
			this.layoutControlItem5.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem13.Control = this.txtInvName;
			this.layoutControlItem13.Height = 29;
			this.layoutControlItem13.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem13.Name = "layoutControlItem13";
			this.layoutControlItem13.Text = "InvName";
			this.layoutControlItem13.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem13.Width = 50;
			this.layoutControlItem13.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem7.Control = this.cmbBatchCode;
			this.layoutControlItem7.Height = 29;
			this.layoutControlItem7.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem7.Name = "layoutControlItem7";
			this.layoutControlItem7.Text = "BatchCode";
			this.layoutControlItem7.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem7.Width = 100;
			this.layoutControlItem7.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem9.Control = this.txtExtBarCode;
			this.layoutControlItem9.Height = 29;
			this.layoutControlItem9.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem9.Name = "layoutControlItem9";
			this.layoutControlItem9.Text = "ExtBarCode";
			this.layoutControlItem9.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem9.Width = 100;
			this.layoutControlItem9.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem15.Control = this.txtCurrStockVol;
			this.layoutControlItem15.Height = 29;
			this.layoutControlItem15.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem15.Name = "layoutControlItem15";
			this.layoutControlItem15.Text = "CurrStockVol";
			this.layoutControlItem15.Width = 50;
			this.layoutControlItem15.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem1.Control = this.nudQuantity;
			this.layoutControlItem1.Height = 29;
			this.layoutControlItem1.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Text = "RealQuantity";
			this.layoutControlItem1.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem1.Width = 50;
			this.layoutControlItem1.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem3.Control = this.cmbRdsStatus;
			this.layoutControlItem3.Height = 29;
			this.layoutControlItem3.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem3.Name = "layoutControlItem3";
			this.layoutControlItem3.Text = "RdsStatus";
			this.layoutControlItem3.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem3.Width = 50;
			this.layoutControlItem3.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem11.Control = this.cmbRdsState;
			this.layoutControlItem11.Height = 29;
			this.layoutControlItem11.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem11.Name = "layoutControlItem11";
			this.layoutControlItem11.Text = "RdsState";
			this.layoutControlItem11.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem11.Width = 50;
			this.layoutControlItem11.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem4.Control = this.txtPositionInfo;
			this.layoutControlItem4.Height = 60;
			this.layoutControlItem4.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem4.Name = "layoutControlItem4";
			this.layoutControlItem4.Text = "PositionInfo";
			this.layoutControlItem4.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem4.Width = 100;
			this.layoutControlItem4.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem22.Control = this.cmbRdsStatus;
			this.layoutControlItem22.Height = 29;
			this.layoutControlItem22.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem22.Name = "layoutControlItem22";
			this.layoutControlItem22.Text = "RdStatus";
			this.layoutControlItem22.Width = 50;
			this.layoutControlItem22.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem12.Control = this.txtInvName;
			this.layoutControlItem12.Height = 29;
			this.layoutControlItem12.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem12.Name = "layoutControlItem12";
			this.layoutControlItem12.Text = "InvCode";
			this.layoutControlItem12.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem12.Width = 100;
			this.layoutControlItem12.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem14.Height = 29;
			this.layoutControlItem14.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem14.Name = "layoutControlItem14";
			this.layoutControlItem14.Text = "InvName";
			this.layoutControlItem14.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem14.Width = 50;
			this.layoutControlItem14.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem2.Height = 29;
			this.layoutControlItem2.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem2.Name = "layoutControlItem2";
			this.layoutControlItem2.Text = "PositionInfo";
			this.layoutControlItem2.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem2.Width = 100;
			this.layoutControlItem2.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			base.ClientSize = new global::System.Drawing.Size(425, 332);
			base.Controls.Add(this.pnlConfig);
			base.Controls.Add(this.menuBar);
			base.Name = "frmRdRecordsEdit";
			this.Text = "frmRdRecordsEdit";
			base.Load += new global::System.EventHandler(this.frmRdRecordsEdit_Load);
			((global::System.ComponentModel.ISupportInitialize)this.menuBar).EndInit();
			this.pnlConfig.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.iInputBillSort).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudQuantity).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000590 RID: 1424
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000591 RID: 1425
		private global::DevComponents.DotNetBar.Bar menuBar;

		// Token: 0x04000592 RID: 1426
		private global::DevComponents.DotNetBar.ButtonItem btnSave;

		// Token: 0x04000593 RID: 1427
		private global::DevComponents.DotNetBar.Layout.LayoutControl pnlConfig;

		// Token: 0x04000594 RID: 1428
		private global::DevComponents.Editors.IntegerInput iInputBillSort;

		// Token: 0x04000595 RID: 1429
		private global::DevComponents.Editors.DoubleInput nudQuantity;

		// Token: 0x04000596 RID: 1430
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem8;

		// Token: 0x04000597 RID: 1431
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem1;

		// Token: 0x04000598 RID: 1432
		private global::Base.AutoComboBox cmbProduct;

		// Token: 0x04000599 RID: 1433
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem6;

		// Token: 0x0400059A RID: 1434
		private global::Base.AutoComboBox cmbBatchCode;

		// Token: 0x0400059B RID: 1435
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem7;

		// Token: 0x0400059C RID: 1436
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtInvCode;

		// Token: 0x0400059D RID: 1437
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem5;

		// Token: 0x0400059E RID: 1438
		private global::DevComponents.DotNetBar.Controls.ComboBoxEx cmbRdsStatus;

		// Token: 0x0400059F RID: 1439
		private global::DevComponents.DotNetBar.Controls.ComboBoxEx cmbRdsState;

		// Token: 0x040005A0 RID: 1440
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem3;

		// Token: 0x040005A1 RID: 1441
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem11;

		// Token: 0x040005A2 RID: 1442
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem22;

		// Token: 0x040005A3 RID: 1443
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtInvName;

		// Token: 0x040005A4 RID: 1444
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem13;

		// Token: 0x040005A5 RID: 1445
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem12;

		// Token: 0x040005A6 RID: 1446
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem14;

		// Token: 0x040005A7 RID: 1447
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem2;

		// Token: 0x040005A8 RID: 1448
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtCurrStockVol;

		// Token: 0x040005A9 RID: 1449
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem15;

		// Token: 0x040005AA RID: 1450
		private global::DevComponents.DotNetBar.Controls.RichTextBoxEx txtPositionInfo;

		// Token: 0x040005AB RID: 1451
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem4;

		// Token: 0x040005AC RID: 1452
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtExtBarCode;

		// Token: 0x040005AD RID: 1453
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem9;
	}
}
