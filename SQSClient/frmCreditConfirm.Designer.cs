namespace SQSClient
{
	// Token: 0x0200000F RID: 15
	public partial class frmCreditConfirm : global::SQSClient.BaseDialogForm
	{
		// Token: 0x0600007C RID: 124 RVA: 0x0000C398 File Offset: 0x0000A598
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600007D RID: 125 RVA: 0x0000C3D0 File Offset: 0x0000A5D0
		private void InitializeComponent()
		{
			this.txtContractNum = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.layoutControlItem1 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControl1 = new global::DevComponents.DotNetBar.Layout.LayoutControl();
			this.txtJieSuanLiang = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.txtLisence = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.txtProduct = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.txtTotalPrice = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.dInputSinglePrice = new global::DevComponents.Editors.DoubleInput();
			this.txtTotalPriceDX = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.layoutControlItem10 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem14 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem7 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem16 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem15 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem17 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.btnSure = new global::DevComponents.DotNetBar.ButtonItem();
			this.menuBar = new global::DevComponents.DotNetBar.Bar();
			this.btnSettle = new global::DevComponents.DotNetBar.ButtonItem();
			this.layoutControlItem3 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem8 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem9 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem4 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem5 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem12 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem2 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem6 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem13 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem11 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControl1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dInputSinglePrice).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.menuBar).BeginInit();
			base.SuspendLayout();
			this.txtContractNum.Border.Class = "TextBoxBorder";
			this.txtContractNum.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtContractNum.Location = new global::System.Drawing.Point(154, 4);
			this.txtContractNum.Margin = new global::System.Windows.Forms.Padding(0);
			this.txtContractNum.Name = "txtContractNum";
			this.txtContractNum.PreventEnterBeep = true;
			this.txtContractNum.ReadOnly = true;
			this.txtContractNum.Size = new global::System.Drawing.Size(235, 21);
			this.txtContractNum.TabIndex = 0;
			this.layoutControlItem1.Control = this.txtContractNum;
			this.layoutControlItem1.Height = 29;
			this.layoutControlItem1.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Text = "ContractID";
			this.layoutControlItem1.Width = 100;
			this.layoutControlItem1.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControl1.Controls.Add(this.txtContractNum);
			this.layoutControl1.Controls.Add(this.txtJieSuanLiang);
			this.layoutControl1.Controls.Add(this.txtLisence);
			this.layoutControl1.Controls.Add(this.txtProduct);
			this.layoutControl1.Controls.Add(this.txtTotalPrice);
			this.layoutControl1.Controls.Add(this.dInputSinglePrice);
			this.layoutControl1.Controls.Add(this.txtTotalPriceDX);
			this.layoutControl1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.layoutControl1.Location = new global::System.Drawing.Point(0, 26);
			this.layoutControl1.Name = "layoutControl1";
			this.layoutControl1.RootGroup.Items.AddRange(new global::DevComponents.DotNetBar.Layout.LayoutItemBase[]
			{
				this.layoutControlItem1,
				this.layoutControlItem10,
				this.layoutControlItem14,
				this.layoutControlItem7,
				this.layoutControlItem16,
				this.layoutControlItem15,
				this.layoutControlItem17
			});
			this.layoutControl1.Size = new global::System.Drawing.Size(393, 304);
			this.layoutControl1.TabIndex = 24;
			this.txtJieSuanLiang.Border.Class = "TextBoxBorder";
			this.txtJieSuanLiang.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtJieSuanLiang.Location = new global::System.Drawing.Point(154, 91);
			this.txtJieSuanLiang.Margin = new global::System.Windows.Forms.Padding(0);
			this.txtJieSuanLiang.Name = "txtJieSuanLiang";
			this.txtJieSuanLiang.PreventEnterBeep = true;
			this.txtJieSuanLiang.ReadOnly = true;
			this.txtJieSuanLiang.Size = new global::System.Drawing.Size(235, 21);
			this.txtJieSuanLiang.TabIndex = 3;
			this.txtLisence.Border.Class = "TextBoxBorder";
			this.txtLisence.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtLisence.Location = new global::System.Drawing.Point(154, 33);
			this.txtLisence.Margin = new global::System.Windows.Forms.Padding(0);
			this.txtLisence.Name = "txtLisence";
			this.txtLisence.PreventEnterBeep = true;
			this.txtLisence.ReadOnly = true;
			this.txtLisence.Size = new global::System.Drawing.Size(235, 21);
			this.txtLisence.TabIndex = 1;
			this.txtProduct.Border.Class = "TextBoxBorder";
			this.txtProduct.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtProduct.Location = new global::System.Drawing.Point(154, 62);
			this.txtProduct.Margin = new global::System.Windows.Forms.Padding(0);
			this.txtProduct.Name = "txtProduct";
			this.txtProduct.PreventEnterBeep = true;
			this.txtProduct.ReadOnly = true;
			this.txtProduct.Size = new global::System.Drawing.Size(235, 21);
			this.txtProduct.TabIndex = 2;
			this.txtTotalPrice.Border.Class = "TextBoxBorder";
			this.txtTotalPrice.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtTotalPrice.Location = new global::System.Drawing.Point(154, 149);
			this.txtTotalPrice.Margin = new global::System.Windows.Forms.Padding(0);
			this.txtTotalPrice.Name = "txtTotalPrice";
			this.txtTotalPrice.PreventEnterBeep = true;
			this.txtTotalPrice.ReadOnly = true;
			this.txtTotalPrice.Size = new global::System.Drawing.Size(235, 21);
			this.txtTotalPrice.TabIndex = 5;
			this.dInputSinglePrice.BackgroundStyle.Class = "DateTimeInputBackground";
			this.dInputSinglePrice.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.dInputSinglePrice.ButtonFreeText.Shortcut = global::DevComponents.DotNetBar.eShortcut.F2;
			this.dInputSinglePrice.Increment = 1.0;
			this.dInputSinglePrice.InputHorizontalAlignment = global::DevComponents.Editors.eHorizontalAlignment.Left;
			this.dInputSinglePrice.Location = new global::System.Drawing.Point(154, 120);
			this.dInputSinglePrice.Margin = new global::System.Windows.Forms.Padding(0);
			this.dInputSinglePrice.MinValue = 0.0;
			this.dInputSinglePrice.Name = "dInputSinglePrice";
			this.dInputSinglePrice.ShowUpDown = true;
			this.dInputSinglePrice.Size = new global::System.Drawing.Size(235, 21);
			this.dInputSinglePrice.TabIndex = 4;
			this.dInputSinglePrice.ValueChanged += new global::System.EventHandler(this.dInputSinglePrice_ValueChanged);
			this.txtTotalPriceDX.Border.Class = "TextBoxBorder";
			this.txtTotalPriceDX.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtTotalPriceDX.Location = new global::System.Drawing.Point(154, 178);
			this.txtTotalPriceDX.Margin = new global::System.Windows.Forms.Padding(0);
			this.txtTotalPriceDX.Name = "txtTotalPriceDX";
			this.txtTotalPriceDX.PreventEnterBeep = true;
			this.txtTotalPriceDX.ReadOnly = true;
			this.txtTotalPriceDX.Size = new global::System.Drawing.Size(235, 21);
			this.txtTotalPriceDX.TabIndex = 6;
			this.layoutControlItem10.Control = this.txtLisence;
			this.layoutControlItem10.Height = 29;
			this.layoutControlItem10.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem10.Name = "layoutControlItem10";
			this.layoutControlItem10.Text = "Lisence";
			this.layoutControlItem10.Width = 100;
			this.layoutControlItem10.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem14.Control = this.txtProduct;
			this.layoutControlItem14.Height = 29;
			this.layoutControlItem14.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem14.Name = "layoutControlItem14";
			this.layoutControlItem14.Text = "Product";
			this.layoutControlItem14.Width = 100;
			this.layoutControlItem14.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem7.Control = this.txtJieSuanLiang;
			this.layoutControlItem7.Height = 29;
			this.layoutControlItem7.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem7.Name = "layoutControlItem7";
			this.layoutControlItem7.Text = "JieSuanLiang(TonUnit)";
			this.layoutControlItem7.Width = 90;
			this.layoutControlItem7.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem16.Control = this.dInputSinglePrice;
			this.layoutControlItem16.Height = 29;
			this.layoutControlItem16.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem16.Name = "layoutControlItem16";
			this.layoutControlItem16.Text = "SinglePrice(YuanPerTon)";
			this.layoutControlItem16.Width = 100;
			this.layoutControlItem16.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem15.Control = this.txtTotalPrice;
			this.layoutControlItem15.Height = 29;
			this.layoutControlItem15.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem15.Name = "layoutControlItem15";
			this.layoutControlItem15.Text = "TotalPrice(Yuan)";
			this.layoutControlItem15.Width = 100;
			this.layoutControlItem15.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem17.Control = this.txtTotalPriceDX;
			this.layoutControlItem17.Height = 29;
			this.layoutControlItem17.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem17.Name = "layoutControlItem17";
			this.layoutControlItem17.Text = "AmountMoney";
			this.layoutControlItem17.Width = 100;
			this.layoutControlItem17.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.btnSure.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.btnSure.Image = global::SQSClient.Properties.Resources.sure16;
			this.btnSure.Name = "btnSure";
			this.btnSure.Text = "Sure";
			this.btnSure.Click += new global::System.EventHandler(this.btnSure_Click);
			this.menuBar.AccessibleDescription = "DotNetBar Bar (menuBar)";
			this.menuBar.AccessibleName = "DotNetBar Bar";
			this.menuBar.AccessibleRole = global::System.Windows.Forms.AccessibleRole.MenuBar;
			this.menuBar.BackColor = global::System.Drawing.Color.Transparent;
			this.menuBar.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.menuBar.Font = new global::System.Drawing.Font("微软雅黑", 9f);
			this.menuBar.IsMaximized = false;
			this.menuBar.Items.AddRange(new global::DevComponents.DotNetBar.BaseItem[]
			{
				this.btnSettle,
				this.btnSure
			});
			this.menuBar.Location = new global::System.Drawing.Point(0, 0);
			this.menuBar.MenuBar = true;
			this.menuBar.Name = "menuBar";
			this.menuBar.Size = new global::System.Drawing.Size(393, 26);
			this.menuBar.Stretch = true;
			this.menuBar.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.menuBar.TabIndex = 23;
			this.menuBar.TabStop = false;
			this.menuBar.Text = "Main Menu";
			this.btnSettle.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.btnSettle.Image = global::SQSClient.Properties.Resources.settle16;
			this.btnSettle.Name = "btnSettle";
			this.btnSettle.Text = "Settle";
			this.btnSettle.Click += new global::System.EventHandler(this.btnSettle_Click);
			this.layoutControlItem3.Height = 28;
			this.layoutControlItem3.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem3.Name = "layoutControlItem3";
			this.layoutControlItem3.Text = "*BusinessType";
			this.layoutControlItem3.Width = 100;
			this.layoutControlItem3.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem8.Control = this.txtJieSuanLiang;
			this.layoutControlItem8.Height = 29;
			this.layoutControlItem8.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem8.Name = "layoutControlItem8";
			this.layoutControlItem8.Text = "JieSuanLiang";
			this.layoutControlItem8.Width = 90;
			this.layoutControlItem8.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem9.Control = this.txtLisence;
			this.layoutControlItem9.Height = 29;
			this.layoutControlItem9.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem9.Name = "layoutControlItem9";
			this.layoutControlItem9.Text = "*Lisence";
			this.layoutControlItem9.Width = 50;
			this.layoutControlItem9.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem4.Height = 31;
			this.layoutControlItem4.MinSize = new global::System.Drawing.Size(20, 18);
			this.layoutControlItem4.Name = "layoutControlItem4";
			this.layoutControlItem4.Width = 10;
			this.layoutControlItem4.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem5.Height = 29;
			this.layoutControlItem5.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem5.Name = "layoutControlItem5";
			this.layoutControlItem5.Text = "*JiHuaLiang";
			this.layoutControlItem5.Width = 100;
			this.layoutControlItem5.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem12.Height = 29;
			this.layoutControlItem12.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem12.Name = "layoutControlItem12";
			this.layoutControlItem12.Text = "SinglePrice";
			this.layoutControlItem12.Width = 100;
			this.layoutControlItem12.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem2.Control = this.txtProduct;
			this.layoutControlItem2.Height = 29;
			this.layoutControlItem2.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem2.Name = "layoutControlItem2";
			this.layoutControlItem2.Text = "*Lisence";
			this.layoutControlItem2.Width = 100;
			this.layoutControlItem2.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem6.Height = 29;
			this.layoutControlItem6.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem6.Name = "layoutControlItem6";
			this.layoutControlItem6.Text = "JieSuanLiang(t)";
			this.layoutControlItem6.Width = 90;
			this.layoutControlItem6.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem13.Control = this.txtTotalPrice;
			this.layoutControlItem13.Height = 29;
			this.layoutControlItem13.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem13.Name = "layoutControlItem13";
			this.layoutControlItem13.Text = "JieSuanLiang(t)";
			this.layoutControlItem13.Width = 90;
			this.layoutControlItem13.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem11.Control = this.dInputSinglePrice;
			this.layoutControlItem11.Height = 29;
			this.layoutControlItem11.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem11.Name = "layoutControlItem11";
			this.layoutControlItem11.Text = "*JiHuaLiang";
			this.layoutControlItem11.Width = 100;
			this.layoutControlItem11.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			base.ClientSize = new global::System.Drawing.Size(393, 330);
			base.Controls.Add(this.layoutControl1);
			base.Controls.Add(this.menuBar);
			base.Name = "frmCreditConfirm";
			this.Text = "frmCreditConfirm";
			base.Load += new global::System.EventHandler(this.frmCreditConfirm_Load);
			this.layoutControl1.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.dInputSinglePrice).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.menuBar).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x040000B1 RID: 177
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x040000B2 RID: 178
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtContractNum;

		// Token: 0x040000B3 RID: 179
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem1;

		// Token: 0x040000B4 RID: 180
		private global::DevComponents.DotNetBar.Layout.LayoutControl layoutControl1;

		// Token: 0x040000B5 RID: 181
		private global::DevComponents.DotNetBar.ButtonItem btnSure;

		// Token: 0x040000B6 RID: 182
		private global::DevComponents.DotNetBar.Bar menuBar;

		// Token: 0x040000B7 RID: 183
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem3;

		// Token: 0x040000B8 RID: 184
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtJieSuanLiang;

		// Token: 0x040000B9 RID: 185
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem7;

		// Token: 0x040000BA RID: 186
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem8;

		// Token: 0x040000BB RID: 187
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtLisence;

		// Token: 0x040000BC RID: 188
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem10;

		// Token: 0x040000BD RID: 189
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem9;

		// Token: 0x040000BE RID: 190
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem4;

		// Token: 0x040000BF RID: 191
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtProduct;

		// Token: 0x040000C0 RID: 192
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem14;

		// Token: 0x040000C1 RID: 193
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem5;

		// Token: 0x040000C2 RID: 194
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem12;

		// Token: 0x040000C3 RID: 195
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem2;

		// Token: 0x040000C4 RID: 196
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtTotalPrice;

		// Token: 0x040000C5 RID: 197
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem15;

		// Token: 0x040000C6 RID: 198
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem6;

		// Token: 0x040000C7 RID: 199
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem13;

		// Token: 0x040000C8 RID: 200
		private global::DevComponents.Editors.DoubleInput dInputSinglePrice;

		// Token: 0x040000C9 RID: 201
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem16;

		// Token: 0x040000CA RID: 202
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem11;

		// Token: 0x040000CB RID: 203
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtTotalPriceDX;

		// Token: 0x040000CC RID: 204
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem17;

		// Token: 0x040000CD RID: 205
		private global::DevComponents.DotNetBar.ButtonItem btnSettle;
	}
}
