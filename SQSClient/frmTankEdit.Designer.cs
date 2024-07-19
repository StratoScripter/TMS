namespace SQSClient
{
	// Token: 0x02000090 RID: 144
	public partial class frmTankEdit : global::SQSClient.BaseDialogForm
	{
		// Token: 0x060007E9 RID: 2025 RVA: 0x000C4B20 File Offset: 0x000C2D20
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060007EA RID: 2026 RVA: 0x000C4B58 File Offset: 0x000C2D58
		private void InitializeComponent()
		{
			this.menuBar = new global::DevComponents.DotNetBar.Bar();
			this.btnSave = new global::DevComponents.DotNetBar.ButtonItem();
			this.pnlConfig = new global::DevComponents.DotNetBar.Layout.LayoutControl();
			this.cmbProduct = new global::Base.AutoComboBox();
			this.iInputCode = new global::DevComponents.Editors.IntegerInput();
			this.nudRealVol = new global::DevComponents.Editors.DoubleInput();
			this.nudVol = new global::DevComponents.Editors.DoubleInput();
			this.rtbRemark = new global::DevComponents.DotNetBar.Controls.RichTextBoxEx();
			this.txtName = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.layoutControlItem5 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem8 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem6 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem2 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem1 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem4 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.cmbDanWei = new global::DevComponents.DotNetBar.Controls.ComboBoxEx();
			this.layoutControlItem3 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			((global::System.ComponentModel.ISupportInitialize)this.menuBar).BeginInit();
			this.pnlConfig.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.iInputCode).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudRealVol).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudVol).BeginInit();
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
			this.pnlConfig.Controls.Add(this.cmbDanWei);
			this.pnlConfig.Controls.Add(this.cmbProduct);
			this.pnlConfig.Controls.Add(this.iInputCode);
			this.pnlConfig.Controls.Add(this.nudRealVol);
			this.pnlConfig.Controls.Add(this.nudVol);
			this.pnlConfig.Controls.Add(this.rtbRemark);
			this.pnlConfig.Controls.Add(this.txtName);
			this.pnlConfig.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.pnlConfig.Location = new global::System.Drawing.Point(0, 26);
			this.pnlConfig.Name = "pnlConfig";
			this.pnlConfig.RootGroup.Items.AddRange(new global::DevComponents.DotNetBar.Layout.LayoutItemBase[]
			{
				this.layoutControlItem5,
				this.layoutControlItem8,
				this.layoutControlItem6,
				this.layoutControlItem2,
				this.layoutControlItem1,
				this.layoutControlItem3,
				this.layoutControlItem4
			});
			this.pnlConfig.Size = new global::System.Drawing.Size(354, 294);
			this.pnlConfig.TabIndex = 21;
			this.cmbProduct.DataSource = null;
			this.cmbProduct.DisplayMember = null;
			this.cmbProduct.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cmbProduct.FormattingEnabled = true;
			this.cmbProduct.ItemHeight = 15;
			this.cmbProduct.Location = new global::System.Drawing.Point(67, 62);
			this.cmbProduct.Margin = new global::System.Windows.Forms.Padding(0);
			this.cmbProduct.MaxDropDownItems = 20;
			this.cmbProduct.Name = "cmbProduct";
			this.cmbProduct.SelectMember = null;
			this.cmbProduct.Size = new global::System.Drawing.Size(283, 21);
			this.cmbProduct.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.cmbProduct.TabIndex = 2;
			this.cmbProduct.ValueMember = null;
			this.iInputCode.BackgroundStyle.Class = "DateTimeInputBackground";
			this.iInputCode.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.iInputCode.ButtonFreeText.Shortcut = global::DevComponents.DotNetBar.eShortcut.F2;
			this.iInputCode.InputHorizontalAlignment = global::DevComponents.Editors.eHorizontalAlignment.Left;
			this.iInputCode.Location = new global::System.Drawing.Point(67, 33);
			this.iInputCode.Margin = new global::System.Windows.Forms.Padding(0);
			this.iInputCode.Name = "iInputCode";
			this.iInputCode.ShowUpDown = true;
			this.iInputCode.Size = new global::System.Drawing.Size(283, 21);
			this.iInputCode.TabIndex = 1;
			this.iInputCode.Value = 1;
			this.nudRealVol.BackgroundStyle.Class = "DateTimeInputBackground";
			this.nudRealVol.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.nudRealVol.ButtonFreeText.Shortcut = global::DevComponents.DotNetBar.eShortcut.F2;
			this.nudRealVol.Increment = 1.0;
			this.nudRealVol.InputHorizontalAlignment = global::DevComponents.Editors.eHorizontalAlignment.Left;
			this.nudRealVol.Location = new global::System.Drawing.Point(67, 119);
			this.nudRealVol.Margin = new global::System.Windows.Forms.Padding(0);
			this.nudRealVol.MaxValue = 99999999.0;
			this.nudRealVol.MinValue = 0.0;
			this.nudRealVol.Name = "nudRealVol";
			this.nudRealVol.ShowUpDown = true;
			this.nudRealVol.Size = new global::System.Drawing.Size(283, 21);
			this.nudRealVol.TabIndex = 4;
			this.nudVol.BackgroundStyle.Class = "DateTimeInputBackground";
			this.nudVol.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.nudVol.ButtonFreeText.Shortcut = global::DevComponents.DotNetBar.eShortcut.F2;
			this.nudVol.Increment = 1.0;
			this.nudVol.InputHorizontalAlignment = global::DevComponents.Editors.eHorizontalAlignment.Left;
			this.nudVol.Location = new global::System.Drawing.Point(67, 90);
			this.nudVol.Margin = new global::System.Windows.Forms.Padding(0);
			this.nudVol.MaxValue = 99999999.0;
			this.nudVol.MinValue = 0.0;
			this.nudVol.Name = "nudVol";
			this.nudVol.ShowUpDown = true;
			this.nudVol.Size = new global::System.Drawing.Size(283, 21);
			this.nudVol.TabIndex = 3;
			this.rtbRemark.BackgroundStyle.Class = "RichTextBoxBorder";
			this.rtbRemark.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.rtbRemark.Location = new global::System.Drawing.Point(67, 176);
			this.rtbRemark.Margin = new global::System.Windows.Forms.Padding(0);
			this.rtbRemark.MaxLength = 200;
			this.rtbRemark.Name = "rtbRemark";
			this.rtbRemark.Rtf = "{\\rtf1\\ansi\\ansicpg936\\deff0\\deflang1033\\deflangfe2052{\\fonttbl{\\f0\\fnil\\fcharset134 \\'cb\\'ce\\'cc\\'e5;}}\r\n\\viewkind4\\uc1\\pard\\lang2052\\f0\\fs18\\par\r\n}\r\n";
			this.rtbRemark.Size = new global::System.Drawing.Size(283, 52);
			this.rtbRemark.TabIndex = 6;
			this.txtName.Border.Class = "TextBoxBorder";
			this.txtName.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtName.Location = new global::System.Drawing.Point(67, 4);
			this.txtName.Margin = new global::System.Windows.Forms.Padding(0);
			this.txtName.MaxLength = 20;
			this.txtName.Name = "txtName";
			this.txtName.PreventEnterBeep = true;
			this.txtName.Size = new global::System.Drawing.Size(283, 21);
			this.txtName.TabIndex = 0;
			this.layoutControlItem5.Control = this.txtName;
			this.layoutControlItem5.Height = 29;
			this.layoutControlItem5.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem5.Name = "layoutControlItem5";
			this.layoutControlItem5.Text = "*TankName";
			this.layoutControlItem5.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem5.Width = 100;
			this.layoutControlItem5.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem8.Control = this.iInputCode;
			this.layoutControlItem8.Height = 29;
			this.layoutControlItem8.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem8.Name = "layoutControlItem8";
			this.layoutControlItem8.Text = "*TankCode";
			this.layoutControlItem8.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem8.Width = 100;
			this.layoutControlItem8.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem6.Control = this.cmbProduct;
			this.layoutControlItem6.Height = 28;
			this.layoutControlItem6.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem6.Name = "layoutControlItem6";
			this.layoutControlItem6.Text = "*Product";
			this.layoutControlItem6.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem6.Width = 100;
			this.layoutControlItem6.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem2.Control = this.nudVol;
			this.layoutControlItem2.Height = 29;
			this.layoutControlItem2.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem2.Name = "layoutControlItem2";
			this.layoutControlItem2.Text = "Vol";
			this.layoutControlItem2.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem2.Width = 100;
			this.layoutControlItem2.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem1.Control = this.nudRealVol;
			this.layoutControlItem1.Height = 29;
			this.layoutControlItem1.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Text = "RealVol";
			this.layoutControlItem1.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem1.Width = 100;
			this.layoutControlItem1.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem4.Control = this.rtbRemark;
			this.layoutControlItem4.Height = 60;
			this.layoutControlItem4.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem4.Name = "layoutControlItem4";
			this.layoutControlItem4.Text = "Remark";
			this.layoutControlItem4.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem4.Width = 100;
			this.layoutControlItem4.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.cmbDanWei.DisplayMember = "Text";
			this.cmbDanWei.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cmbDanWei.FormattingEnabled = true;
			this.cmbDanWei.ItemHeight = 15;
			this.cmbDanWei.Location = new global::System.Drawing.Point(67, 148);
			this.cmbDanWei.Margin = new global::System.Windows.Forms.Padding(0, 0, 0, 0);
			this.cmbDanWei.Name = "cmbDanWei";
			this.cmbDanWei.Size = new global::System.Drawing.Size(283, 21);
			this.cmbDanWei.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.cmbDanWei.TabIndex = 5;
			this.layoutControlItem3.Control = this.cmbDanWei;
			this.layoutControlItem3.Height = 28;
			this.layoutControlItem3.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem3.Name = "layoutControlItem3";
			this.layoutControlItem3.Text = "DanWei";
			this.layoutControlItem3.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem3.Width = 100;
			this.layoutControlItem3.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			base.ClientSize = new global::System.Drawing.Size(354, 320);
			base.Controls.Add(this.pnlConfig);
			base.Controls.Add(this.menuBar);
			base.Name = "frmTankEdit";
			this.Text = "frmTankEdit";
			base.Load += new global::System.EventHandler(this.frmTankEdit_Load);
			((global::System.ComponentModel.ISupportInitialize)this.menuBar).EndInit();
			this.pnlConfig.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.iInputCode).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudRealVol).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudVol).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000D8F RID: 3471
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000D90 RID: 3472
		private global::DevComponents.DotNetBar.Bar menuBar;

		// Token: 0x04000D91 RID: 3473
		private global::DevComponents.DotNetBar.ButtonItem btnSave;

		// Token: 0x04000D92 RID: 3474
		private global::DevComponents.DotNetBar.Layout.LayoutControl pnlConfig;

		// Token: 0x04000D93 RID: 3475
		private global::DevComponents.Editors.IntegerInput iInputCode;

		// Token: 0x04000D94 RID: 3476
		private global::DevComponents.Editors.DoubleInput nudRealVol;

		// Token: 0x04000D95 RID: 3477
		private global::DevComponents.Editors.DoubleInput nudVol;

		// Token: 0x04000D96 RID: 3478
		private global::DevComponents.DotNetBar.Controls.RichTextBoxEx rtbRemark;

		// Token: 0x04000D97 RID: 3479
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtName;

		// Token: 0x04000D98 RID: 3480
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem5;

		// Token: 0x04000D99 RID: 3481
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem8;

		// Token: 0x04000D9A RID: 3482
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem2;

		// Token: 0x04000D9B RID: 3483
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem1;

		// Token: 0x04000D9C RID: 3484
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem4;

		// Token: 0x04000D9D RID: 3485
		private global::Base.AutoComboBox cmbProduct;

		// Token: 0x04000D9E RID: 3486
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem6;

		// Token: 0x04000D9F RID: 3487
		private global::DevComponents.DotNetBar.Controls.ComboBoxEx cmbDanWei;

		// Token: 0x04000DA0 RID: 3488
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem3;
	}
}
