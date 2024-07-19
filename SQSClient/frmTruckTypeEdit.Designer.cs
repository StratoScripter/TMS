namespace SQSClient
{
	// Token: 0x0200006D RID: 109
	public partial class frmTruckTypeEdit : global::SQSClient.BaseDialogForm
	{
		// Token: 0x06000589 RID: 1417 RVA: 0x0008DC08 File Offset: 0x0008BE08
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600058A RID: 1418 RVA: 0x0008DC40 File Offset: 0x0008BE40
		private void InitializeComponent()
		{
			this.menuBar = new global::DevComponents.DotNetBar.Bar();
			this.btnSave = new global::DevComponents.DotNetBar.ButtonItem();
			this.layoutControl1 = new global::DevComponents.DotNetBar.Layout.LayoutControl();
			this.dInputMidu = new global::DevComponents.Editors.DoubleInput();
			this.dInputNetWeight = new global::DevComponents.Editors.DoubleInput();
			this.dInputFactor = new global::DevComponents.Editors.DoubleInput();
			this.dInputVol = new global::DevComponents.Editors.DoubleInput();
			this.cmbProduct = new global::Base.AutoComboBox();
			this.txtName = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.rtbRemark = new global::DevComponents.DotNetBar.Controls.RichTextBoxEx();
			this.layoutControlItem1 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem2 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem7 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem3 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem4 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem5 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem6 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			((global::System.ComponentModel.ISupportInitialize)this.menuBar).BeginInit();
			this.layoutControl1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dInputMidu).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.dInputNetWeight).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.dInputFactor).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.dInputVol).BeginInit();
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
			this.layoutControl1.Controls.Add(this.dInputMidu);
			this.layoutControl1.Controls.Add(this.dInputNetWeight);
			this.layoutControl1.Controls.Add(this.dInputFactor);
			this.layoutControl1.Controls.Add(this.dInputVol);
			this.layoutControl1.Controls.Add(this.cmbProduct);
			this.layoutControl1.Controls.Add(this.txtName);
			this.layoutControl1.Controls.Add(this.rtbRemark);
			this.layoutControl1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.layoutControl1.Location = new global::System.Drawing.Point(0, 26);
			this.layoutControl1.Name = "layoutControl1";
			this.layoutControl1.RootGroup.Items.AddRange(new global::DevComponents.DotNetBar.Layout.LayoutItemBase[]
			{
				this.layoutControlItem1,
				this.layoutControlItem2,
				this.layoutControlItem7,
				this.layoutControlItem3,
				this.layoutControlItem4,
				this.layoutControlItem5,
				this.layoutControlItem6
			});
			this.layoutControl1.Size = new global::System.Drawing.Size(354, 257);
			this.layoutControl1.TabIndex = 21;
			this.dInputMidu.BackgroundStyle.Class = "DateTimeInputBackground";
			this.dInputMidu.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.dInputMidu.ButtonFreeText.Shortcut = global::DevComponents.DotNetBar.eShortcut.F2;
			this.dInputMidu.Enabled = false;
			this.dInputMidu.Increment = 1.0;
			this.dInputMidu.InputHorizontalAlignment = global::DevComponents.Editors.eHorizontalAlignment.Left;
			this.dInputMidu.Location = new global::System.Drawing.Point(92, 61);
			this.dInputMidu.Margin = new global::System.Windows.Forms.Padding(0);
			this.dInputMidu.Name = "dInputMidu";
			this.dInputMidu.ShowUpDown = true;
			this.dInputMidu.Size = new global::System.Drawing.Size(258, 21);
			this.dInputMidu.TabIndex = 2;
			this.dInputNetWeight.BackgroundStyle.Class = "DateTimeInputBackground";
			this.dInputNetWeight.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.dInputNetWeight.ButtonFreeText.Shortcut = global::DevComponents.DotNetBar.eShortcut.F2;
			this.dInputNetWeight.Enabled = false;
			this.dInputNetWeight.Increment = 1.0;
			this.dInputNetWeight.InputHorizontalAlignment = global::DevComponents.Editors.eHorizontalAlignment.Left;
			this.dInputNetWeight.Location = new global::System.Drawing.Point(92, 148);
			this.dInputNetWeight.Margin = new global::System.Windows.Forms.Padding(0);
			this.dInputNetWeight.MinValue = 0.0;
			this.dInputNetWeight.Name = "dInputNetWeight";
			this.dInputNetWeight.ShowUpDown = true;
			this.dInputNetWeight.Size = new global::System.Drawing.Size(258, 21);
			this.dInputNetWeight.TabIndex = 5;
			this.dInputFactor.BackgroundStyle.Class = "DateTimeInputBackground";
			this.dInputFactor.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.dInputFactor.ButtonFreeText.Shortcut = global::DevComponents.DotNetBar.eShortcut.F2;
			this.dInputFactor.DisplayFormat = "0.0000";
			this.dInputFactor.Increment = 0.1;
			this.dInputFactor.InputHorizontalAlignment = global::DevComponents.Editors.eHorizontalAlignment.Left;
			this.dInputFactor.Location = new global::System.Drawing.Point(92, 119);
			this.dInputFactor.Margin = new global::System.Windows.Forms.Padding(0);
			this.dInputFactor.MaxValue = 1.0;
			this.dInputFactor.MinValue = 0.0;
			this.dInputFactor.MouseWheelValueChangeEnabled = false;
			this.dInputFactor.Name = "dInputFactor";
			this.dInputFactor.ShowUpDown = true;
			this.dInputFactor.Size = new global::System.Drawing.Size(258, 21);
			this.dInputFactor.TabIndex = 4;
			this.dInputFactor.Value = 1.0;
			this.dInputFactor.ValueChanged += new global::System.EventHandler(this.dInputFactor_ValueChanged);
			this.dInputVol.BackgroundStyle.Class = "DateTimeInputBackground";
			this.dInputVol.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.dInputVol.ButtonFreeText.Shortcut = global::DevComponents.DotNetBar.eShortcut.F2;
			this.dInputVol.Increment = 1.0;
			this.dInputVol.InputHorizontalAlignment = global::DevComponents.Editors.eHorizontalAlignment.Left;
			this.dInputVol.Location = new global::System.Drawing.Point(92, 90);
			this.dInputVol.Margin = new global::System.Windows.Forms.Padding(0);
			this.dInputVol.MinValue = 0.0;
			this.dInputVol.Name = "dInputVol";
			this.dInputVol.ShowUpDown = true;
			this.dInputVol.Size = new global::System.Drawing.Size(258, 21);
			this.dInputVol.TabIndex = 3;
			this.dInputVol.ValueChanged += new global::System.EventHandler(this.dInputVol_ValueChanged);
			this.cmbProduct.DataSource = null;
			this.cmbProduct.DisplayMember = null;
			this.cmbProduct.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cmbProduct.FormattingEnabled = true;
			this.cmbProduct.ItemHeight = 15;
			this.cmbProduct.Location = new global::System.Drawing.Point(92, 33);
			this.cmbProduct.Margin = new global::System.Windows.Forms.Padding(0);
			this.cmbProduct.MaxDropDownItems = 20;
			this.cmbProduct.Name = "cmbProduct";
			this.cmbProduct.SelectMember = null;
			this.cmbProduct.Size = new global::System.Drawing.Size(258, 21);
			this.cmbProduct.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.cmbProduct.TabIndex = 1;
			this.cmbProduct.ValueMember = null;
			this.cmbProduct.TextChanged += new global::System.EventHandler(this.cmbProduct_TextChanged);
			this.txtName.Border.Class = "TextBoxBorder";
			this.txtName.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtName.Location = new global::System.Drawing.Point(92, 4);
			this.txtName.Margin = new global::System.Windows.Forms.Padding(0);
			this.txtName.Name = "txtName";
			this.txtName.PreventEnterBeep = true;
			this.txtName.Size = new global::System.Drawing.Size(258, 21);
			this.txtName.TabIndex = 0;
			this.rtbRemark.BackgroundStyle.Class = "RichTextBoxBorder";
			this.rtbRemark.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.rtbRemark.Location = new global::System.Drawing.Point(92, 177);
			this.rtbRemark.Margin = new global::System.Windows.Forms.Padding(0);
			this.rtbRemark.MaxLength = 200;
			this.rtbRemark.Name = "rtbRemark";
			this.rtbRemark.Rtf = "{\\rtf1\\ansi\\ansicpg936\\deff0\\deflang1033\\deflangfe2052{\\fonttbl{\\f0\\fnil\\fcharset134 \\'cb\\'ce\\'cc\\'e5;}}\r\n\\viewkind4\\uc1\\pard\\lang2052\\f0\\fs18\\par\r\n}\r\n";
			this.rtbRemark.Size = new global::System.Drawing.Size(258, 52);
			this.rtbRemark.TabIndex = 6;
			this.layoutControlItem1.Control = this.txtName;
			this.layoutControlItem1.Height = 29;
			this.layoutControlItem1.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Text = "*Name";
			this.layoutControlItem1.Width = 100;
			this.layoutControlItem1.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem2.Control = this.cmbProduct;
			this.layoutControlItem2.Height = 28;
			this.layoutControlItem2.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem2.Name = "layoutControlItem2";
			this.layoutControlItem2.Text = "*Product";
			this.layoutControlItem2.Width = 100;
			this.layoutControlItem2.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem7.Control = this.dInputMidu;
			this.layoutControlItem7.Height = 29;
			this.layoutControlItem7.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem7.Name = "layoutControlItem7";
			this.layoutControlItem7.Text = "MiDu(kg/m³)";
			this.layoutControlItem7.Width = 100;
			this.layoutControlItem7.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem3.Control = this.dInputVol;
			this.layoutControlItem3.Height = 29;
			this.layoutControlItem3.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem3.Name = "layoutControlItem3";
			this.layoutControlItem3.Text = "*Vol(m³)";
			this.layoutControlItem3.Width = 100;
			this.layoutControlItem3.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem4.Control = this.dInputFactor;
			this.layoutControlItem4.Height = 29;
			this.layoutControlItem4.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem4.Name = "layoutControlItem4";
			this.layoutControlItem4.Text = "*Factor";
			this.layoutControlItem4.Width = 100;
			this.layoutControlItem4.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem5.Control = this.dInputNetWeight;
			this.layoutControlItem5.Height = 29;
			this.layoutControlItem5.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem5.Name = "layoutControlItem5";
			this.layoutControlItem5.Text = "NetWeight(kg)";
			this.layoutControlItem5.Width = 100;
			this.layoutControlItem5.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem6.Control = this.rtbRemark;
			this.layoutControlItem6.Height = 60;
			this.layoutControlItem6.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem6.Name = "layoutControlItem6";
			this.layoutControlItem6.Text = "Remark";
			this.layoutControlItem6.Width = 100;
			this.layoutControlItem6.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			base.ClientSize = new global::System.Drawing.Size(354, 283);
			base.Controls.Add(this.layoutControl1);
			base.Controls.Add(this.menuBar);
			base.Name = "frmTruckTypeEdit";
			this.Text = "frmTruckTypeEdit";
			base.Load += new global::System.EventHandler(this.frmTruckTypeEdit_Load);
			((global::System.ComponentModel.ISupportInitialize)this.menuBar).EndInit();
			this.layoutControl1.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.dInputMidu).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.dInputNetWeight).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.dInputFactor).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.dInputVol).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x040009BC RID: 2492
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x040009BD RID: 2493
		private global::DevComponents.DotNetBar.Bar menuBar;

		// Token: 0x040009BE RID: 2494
		private global::DevComponents.DotNetBar.ButtonItem btnSave;

		// Token: 0x040009BF RID: 2495
		private global::DevComponents.DotNetBar.Layout.LayoutControl layoutControl1;

		// Token: 0x040009C0 RID: 2496
		private global::DevComponents.Editors.DoubleInput dInputNetWeight;

		// Token: 0x040009C1 RID: 2497
		private global::DevComponents.Editors.DoubleInput dInputFactor;

		// Token: 0x040009C2 RID: 2498
		private global::DevComponents.Editors.DoubleInput dInputVol;

		// Token: 0x040009C3 RID: 2499
		private global::Base.AutoComboBox cmbProduct;

		// Token: 0x040009C4 RID: 2500
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtName;

		// Token: 0x040009C5 RID: 2501
		private global::DevComponents.DotNetBar.Controls.RichTextBoxEx rtbRemark;

		// Token: 0x040009C6 RID: 2502
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem1;

		// Token: 0x040009C7 RID: 2503
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem2;

		// Token: 0x040009C8 RID: 2504
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem3;

		// Token: 0x040009C9 RID: 2505
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem4;

		// Token: 0x040009CA RID: 2506
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem5;

		// Token: 0x040009CB RID: 2507
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem6;

		// Token: 0x040009CC RID: 2508
		private global::DevComponents.Editors.DoubleInput dInputMidu;

		// Token: 0x040009CD RID: 2509
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem7;
	}
}
