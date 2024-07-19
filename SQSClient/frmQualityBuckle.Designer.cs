namespace SQSClient
{
	// Token: 0x02000011 RID: 17
	public partial class frmQualityBuckle : global::SQSClient.BaseDialogForm
	{
		// Token: 0x06000092 RID: 146 RVA: 0x0000F020 File Offset: 0x0000D220
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000093 RID: 147 RVA: 0x0000F058 File Offset: 0x0000D258
		private void InitializeComponent()
		{
			this.txtContractNum = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.layoutControlItem1 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControl1 = new global::DevComponents.DotNetBar.Layout.LayoutControl();
			this.txtOneWeighed = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.txtLisence = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.txtProduct = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.txtDifferWeight = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.txtImpurityAmount = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.rtxtImpurityDetails = new global::DevComponents.DotNetBar.Controls.RichTextBoxEx();
			this.txtTwoWeighed = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.txtDeductWeight = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.txtInvCode = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.txtDanHao = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.layoutControlItem24 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem10 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem23 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem14 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem7 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem20 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem15 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem21 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem19 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem17 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.btnSure = new global::DevComponents.DotNetBar.ButtonItem();
			this.menuBar = new global::DevComponents.DotNetBar.Bar();
			this.btnStatusFinish = new global::DevComponents.DotNetBar.ButtonItem();
			this.btnSettle = new global::DevComponents.DotNetBar.ButtonItem();
			this.btnPhotoAround = new global::DevComponents.DotNetBar.ButtonItem();
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
			this.layoutControlItem18 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem16 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem22 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem25 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.btnModifyOwner = new global::DevComponents.DotNetBar.ButtonItem();
			this.layoutControlItem26 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.txtModifyOwner = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.layoutControlItem27 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControl1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.menuBar).BeginInit();
			base.SuspendLayout();
			this.txtContractNum.Border.Class = "TextBoxBorder";
			this.txtContractNum.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtContractNum.Location = new global::System.Drawing.Point(123, 33);
			this.txtContractNum.Margin = new global::System.Windows.Forms.Padding(0);
			this.txtContractNum.Name = "txtContractNum";
			this.txtContractNum.PreventEnterBeep = true;
			this.txtContractNum.ReadOnly = true;
			this.txtContractNum.Size = new global::System.Drawing.Size(364, 21);
			this.txtContractNum.TabIndex = 1;
			this.layoutControlItem1.Control = this.txtContractNum;
			this.layoutControlItem1.Height = 29;
			this.layoutControlItem1.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Text = "ContractID";
			this.layoutControlItem1.Width = 100;
			this.layoutControlItem1.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControl1.Controls.Add(this.txtContractNum);
			this.layoutControl1.Controls.Add(this.txtOneWeighed);
			this.layoutControl1.Controls.Add(this.txtLisence);
			this.layoutControl1.Controls.Add(this.txtProduct);
			this.layoutControl1.Controls.Add(this.txtDifferWeight);
			this.layoutControl1.Controls.Add(this.txtImpurityAmount);
			this.layoutControl1.Controls.Add(this.rtxtImpurityDetails);
			this.layoutControl1.Controls.Add(this.txtTwoWeighed);
			this.layoutControl1.Controls.Add(this.txtDeductWeight);
			this.layoutControl1.Controls.Add(this.txtInvCode);
			this.layoutControl1.Controls.Add(this.txtDanHao);
			this.layoutControl1.Controls.Add(this.txtModifyOwner);
			this.layoutControl1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.layoutControl1.Location = new global::System.Drawing.Point(0, 26);
			this.layoutControl1.Name = "layoutControl1";
			this.layoutControl1.RootGroup.Items.AddRange(new global::DevComponents.DotNetBar.Layout.LayoutItemBase[]
			{
				this.layoutControlItem24,
				this.layoutControlItem1,
				this.layoutControlItem10,
				this.layoutControlItem23,
				this.layoutControlItem14,
				this.layoutControlItem7,
				this.layoutControlItem20,
				this.layoutControlItem15,
				this.layoutControlItem21,
				this.layoutControlItem19,
				this.layoutControlItem17,
				this.layoutControlItem27
			});
			this.layoutControl1.Size = new global::System.Drawing.Size(491, 392);
			this.layoutControl1.TabIndex = 24;
			this.txtOneWeighed.Border.Class = "TextBoxBorder";
			this.txtOneWeighed.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtOneWeighed.Location = new global::System.Drawing.Point(123, 149);
			this.txtOneWeighed.Margin = new global::System.Windows.Forms.Padding(0);
			this.txtOneWeighed.Name = "txtOneWeighed";
			this.txtOneWeighed.PreventEnterBeep = true;
			this.txtOneWeighed.ReadOnly = true;
			this.txtOneWeighed.Size = new global::System.Drawing.Size(364, 21);
			this.txtOneWeighed.TabIndex = 5;
			this.txtLisence.Border.Class = "TextBoxBorder";
			this.txtLisence.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtLisence.Location = new global::System.Drawing.Point(123, 62);
			this.txtLisence.Margin = new global::System.Windows.Forms.Padding(0);
			this.txtLisence.Name = "txtLisence";
			this.txtLisence.PreventEnterBeep = true;
			this.txtLisence.ReadOnly = true;
			this.txtLisence.Size = new global::System.Drawing.Size(364, 21);
			this.txtLisence.TabIndex = 2;
			this.txtProduct.Border.Class = "TextBoxBorder";
			this.txtProduct.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtProduct.Location = new global::System.Drawing.Point(123, 120);
			this.txtProduct.Margin = new global::System.Windows.Forms.Padding(0);
			this.txtProduct.Name = "txtProduct";
			this.txtProduct.PreventEnterBeep = true;
			this.txtProduct.ReadOnly = true;
			this.txtProduct.Size = new global::System.Drawing.Size(364, 21);
			this.txtProduct.TabIndex = 4;
			this.txtDifferWeight.Border.Class = "TextBoxBorder";
			this.txtDifferWeight.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtDifferWeight.Location = new global::System.Drawing.Point(123, 207);
			this.txtDifferWeight.Margin = new global::System.Windows.Forms.Padding(0);
			this.txtDifferWeight.Name = "txtDifferWeight";
			this.txtDifferWeight.PreventEnterBeep = true;
			this.txtDifferWeight.ReadOnly = true;
			this.txtDifferWeight.Size = new global::System.Drawing.Size(364, 21);
			this.txtDifferWeight.TabIndex = 7;
			this.txtImpurityAmount.Border.Class = "TextBoxBorder";
			this.txtImpurityAmount.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtImpurityAmount.Location = new global::System.Drawing.Point(123, 329);
			this.txtImpurityAmount.Margin = new global::System.Windows.Forms.Padding(0);
			this.txtImpurityAmount.Name = "txtImpurityAmount";
			this.txtImpurityAmount.PreventEnterBeep = true;
			this.txtImpurityAmount.ReadOnly = true;
			this.txtImpurityAmount.Size = new global::System.Drawing.Size(364, 21);
			this.txtImpurityAmount.TabIndex = 10;
			this.rtxtImpurityDetails.BackgroundStyle.Class = "RichTextBoxBorder";
			this.rtxtImpurityDetails.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.rtxtImpurityDetails.Location = new global::System.Drawing.Point(123, 265);
			this.rtxtImpurityDetails.Margin = new global::System.Windows.Forms.Padding(0);
			this.rtxtImpurityDetails.Name = "rtxtImpurityDetails";
			this.rtxtImpurityDetails.ReadOnly = true;
			this.rtxtImpurityDetails.Rtf = "{\\rtf1\\ansi\\ansicpg936\\deff0\\nouicompat\\deflang1033\\deflangfe2052{\\fonttbl{\\f0\\fnil\\fcharset134 \\'cb\\'ce\\'cc\\'e5;}}\r\n{\\*\\generator Riched20 10.0.18362}\\viewkind4\\uc1 \r\n\\pard\\f0\\fs18\\lang2052\\par\r\n}\r\n";
			this.rtxtImpurityDetails.Size = new global::System.Drawing.Size(364, 56);
			this.rtxtImpurityDetails.TabIndex = 9;
			this.rtxtImpurityDetails.DoubleClick += new global::System.EventHandler(this.rtxtImpurityDetails_DoubleClick);
			this.txtTwoWeighed.Border.Class = "TextBoxBorder";
			this.txtTwoWeighed.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtTwoWeighed.Location = new global::System.Drawing.Point(123, 178);
			this.txtTwoWeighed.Margin = new global::System.Windows.Forms.Padding(0);
			this.txtTwoWeighed.Name = "txtTwoWeighed";
			this.txtTwoWeighed.PreventEnterBeep = true;
			this.txtTwoWeighed.ReadOnly = true;
			this.txtTwoWeighed.Size = new global::System.Drawing.Size(364, 21);
			this.txtTwoWeighed.TabIndex = 6;
			this.txtDeductWeight.Border.Class = "TextBoxBorder";
			this.txtDeductWeight.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtDeductWeight.Location = new global::System.Drawing.Point(123, 236);
			this.txtDeductWeight.Margin = new global::System.Windows.Forms.Padding(0);
			this.txtDeductWeight.Name = "txtDeductWeight";
			this.txtDeductWeight.PreventEnterBeep = true;
			this.txtDeductWeight.ReadOnly = true;
			this.txtDeductWeight.Size = new global::System.Drawing.Size(364, 21);
			this.txtDeductWeight.TabIndex = 8;
			this.txtInvCode.Border.Class = "TextBoxBorder";
			this.txtInvCode.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtInvCode.Location = new global::System.Drawing.Point(123, 91);
			this.txtInvCode.Margin = new global::System.Windows.Forms.Padding(0);
			this.txtInvCode.Name = "txtInvCode";
			this.txtInvCode.PreventEnterBeep = true;
			this.txtInvCode.ReadOnly = true;
			this.txtInvCode.Size = new global::System.Drawing.Size(364, 21);
			this.txtInvCode.TabIndex = 3;
			this.txtDanHao.Border.Class = "TextBoxBorder";
			this.txtDanHao.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtDanHao.Location = new global::System.Drawing.Point(123, 4);
			this.txtDanHao.Margin = new global::System.Windows.Forms.Padding(0);
			this.txtDanHao.Name = "txtDanHao";
			this.txtDanHao.PreventEnterBeep = true;
			this.txtDanHao.ReadOnly = true;
			this.txtDanHao.Size = new global::System.Drawing.Size(364, 21);
			this.txtDanHao.TabIndex = 0;
			this.layoutControlItem24.Control = this.txtDanHao;
			this.layoutControlItem24.Height = 29;
			this.layoutControlItem24.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem24.Name = "layoutControlItem24";
			this.layoutControlItem24.Text = "DanHao";
			this.layoutControlItem24.Width = 100;
			this.layoutControlItem24.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem10.Control = this.txtLisence;
			this.layoutControlItem10.Height = 29;
			this.layoutControlItem10.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem10.Name = "layoutControlItem10";
			this.layoutControlItem10.Text = "Lisence";
			this.layoutControlItem10.Width = 100;
			this.layoutControlItem10.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem23.Control = this.txtInvCode;
			this.layoutControlItem23.Height = 29;
			this.layoutControlItem23.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem23.Name = "layoutControlItem23";
			this.layoutControlItem23.Text = "InvCode";
			this.layoutControlItem23.Width = 100;
			this.layoutControlItem23.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem14.Control = this.txtProduct;
			this.layoutControlItem14.Height = 29;
			this.layoutControlItem14.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem14.Name = "layoutControlItem14";
			this.layoutControlItem14.Text = "Product";
			this.layoutControlItem14.Width = 100;
			this.layoutControlItem14.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem7.Control = this.txtOneWeighed;
			this.layoutControlItem7.Height = 29;
			this.layoutControlItem7.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem7.Name = "layoutControlItem7";
			this.layoutControlItem7.Text = "OneWeighed(Kg)";
			this.layoutControlItem7.Width = 90;
			this.layoutControlItem7.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem20.Control = this.txtTwoWeighed;
			this.layoutControlItem20.Height = 29;
			this.layoutControlItem20.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem20.Name = "layoutControlItem20";
			this.layoutControlItem20.Text = "TwoWeighed(Kg)";
			this.layoutControlItem20.Width = 100;
			this.layoutControlItem20.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem15.Control = this.txtDifferWeight;
			this.layoutControlItem15.Height = 29;
			this.layoutControlItem15.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem15.Name = "layoutControlItem15";
			this.layoutControlItem15.Text = "DifferWeight(Kg)";
			this.layoutControlItem15.Width = 100;
			this.layoutControlItem15.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem21.Control = this.txtDeductWeight;
			this.layoutControlItem21.Height = 29;
			this.layoutControlItem21.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem21.Name = "layoutControlItem21";
			this.layoutControlItem21.Text = "DeductWeight(Kg)";
			this.layoutControlItem21.Width = 100;
			this.layoutControlItem21.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem19.Control = this.rtxtImpurityDetails;
			this.layoutControlItem19.Height = 64;
			this.layoutControlItem19.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem19.Name = "layoutControlItem19";
			this.layoutControlItem19.Text = "ImpurityDetails";
			this.layoutControlItem19.Width = 100;
			this.layoutControlItem19.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem17.Control = this.txtImpurityAmount;
			this.layoutControlItem17.Height = 29;
			this.layoutControlItem17.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem17.Name = "layoutControlItem17";
			this.layoutControlItem17.Text = "ImpurityAmount(Kg)";
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
				this.btnSure,
				this.btnStatusFinish,
				this.btnSettle,
				this.btnPhotoAround,
				this.btnModifyOwner
			});
			this.menuBar.Location = new global::System.Drawing.Point(0, 0);
			this.menuBar.MenuBar = true;
			this.menuBar.Name = "menuBar";
			this.menuBar.Size = new global::System.Drawing.Size(491, 26);
			this.menuBar.Stretch = true;
			this.menuBar.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.menuBar.TabIndex = 23;
			this.menuBar.TabStop = false;
			this.menuBar.Text = "Main Menu";
			this.btnStatusFinish.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.btnStatusFinish.Image = global::SQSClient.Properties.Resources.save16;
			this.btnStatusFinish.Name = "btnStatusFinish";
			this.btnStatusFinish.Text = "StatusFinish";
			this.btnStatusFinish.Click += new global::System.EventHandler(this.btnStatusFinish_Click);
			this.btnSettle.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.btnSettle.Image = global::SQSClient.Properties.Resources.settle16;
			this.btnSettle.Name = "btnSettle";
			this.btnSettle.Text = "Settle";
			this.btnSettle.Click += new global::System.EventHandler(this.btnSettle_Click);
			this.btnPhotoAround.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.btnPhotoAround.Image = global::SQSClient.Properties.Resources.capture16;
			this.btnPhotoAround.ItemAlignment = global::DevComponents.DotNetBar.eItemAlignment.Far;
			this.btnPhotoAround.Name = "btnPhotoAround";
			this.btnPhotoAround.Text = "PhotoAround";
			this.btnPhotoAround.Click += new global::System.EventHandler(this.btnPhotoAround_Click);
			this.layoutControlItem3.Height = 28;
			this.layoutControlItem3.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem3.Name = "layoutControlItem3";
			this.layoutControlItem3.Text = "*BusinessType";
			this.layoutControlItem3.Width = 100;
			this.layoutControlItem3.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem8.Control = this.txtOneWeighed;
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
			this.layoutControlItem13.Control = this.txtDifferWeight;
			this.layoutControlItem13.Height = 29;
			this.layoutControlItem13.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem13.Name = "layoutControlItem13";
			this.layoutControlItem13.Text = "JieSuanLiang(t)";
			this.layoutControlItem13.Width = 90;
			this.layoutControlItem13.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem11.Height = 29;
			this.layoutControlItem11.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem11.Name = "layoutControlItem11";
			this.layoutControlItem11.Text = "*JiHuaLiang";
			this.layoutControlItem11.Width = 100;
			this.layoutControlItem11.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem18.Control = this.rtxtImpurityDetails;
			this.layoutControlItem18.Height = 64;
			this.layoutControlItem18.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem18.Name = "layoutControlItem18";
			this.layoutControlItem18.Text = "Remark";
			this.layoutControlItem18.Width = 100;
			this.layoutControlItem18.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem16.Control = this.txtTwoWeighed;
			this.layoutControlItem16.Height = 29;
			this.layoutControlItem16.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem16.Name = "layoutControlItem16";
			this.layoutControlItem16.Text = "OneWeighed";
			this.layoutControlItem16.Width = 90;
			this.layoutControlItem16.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem22.Control = this.txtInvCode;
			this.layoutControlItem22.Height = 29;
			this.layoutControlItem22.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem22.Name = "layoutControlItem22";
			this.layoutControlItem22.Text = "Product";
			this.layoutControlItem22.Width = 100;
			this.layoutControlItem22.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem25.Height = 64;
			this.layoutControlItem25.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem25.Name = "layoutControlItem25";
			this.layoutControlItem25.Text = "ImpurityDetails";
			this.layoutControlItem25.Width = 100;
			this.layoutControlItem25.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.btnModifyOwner.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.btnModifyOwner.Image = global::SQSClient.Properties.Resources.setting16;
			this.btnModifyOwner.Name = "btnModifyOwner";
			this.btnModifyOwner.Text = "ModifyOwner";
			this.btnModifyOwner.Click += new global::System.EventHandler(this.btnModifyOwner_Click);
			this.layoutControlItem26.Control = this.txtModifyOwner;
			this.layoutControlItem26.Height = 29;
			this.layoutControlItem26.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem26.Name = "layoutControlItem26";
			this.layoutControlItem26.Text = "InvCode";
			this.layoutControlItem26.Width = 100;
			this.layoutControlItem26.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.txtModifyOwner.Border.Class = "TextBoxBorder";
			this.txtModifyOwner.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtModifyOwner.Location = new global::System.Drawing.Point(123, 358);
			this.txtModifyOwner.Margin = new global::System.Windows.Forms.Padding(0);
			this.txtModifyOwner.Name = "txtModifyOwner";
			this.txtModifyOwner.PreventEnterBeep = true;
			this.txtModifyOwner.Size = new global::System.Drawing.Size(364, 21);
			this.txtModifyOwner.TabIndex = 12;
			this.layoutControlItem27.Control = this.txtModifyOwner;
			this.layoutControlItem27.Height = 29;
			this.layoutControlItem27.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem27.Name = "layoutControlItem27";
			this.layoutControlItem27.Text = "ModifyOwner";
			this.layoutControlItem27.Width = 100;
			this.layoutControlItem27.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			base.ClientSize = new global::System.Drawing.Size(491, 418);
			base.Controls.Add(this.layoutControl1);
			base.Controls.Add(this.menuBar);
			base.Name = "frmQualityBuckle";
			this.Text = "frmQualityBuckle";
			base.Load += new global::System.EventHandler(this.frmQualityBuckle_Load);
			this.layoutControl1.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.menuBar).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x040000EE RID: 238
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x040000EF RID: 239
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtContractNum;

		// Token: 0x040000F0 RID: 240
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem1;

		// Token: 0x040000F1 RID: 241
		private global::DevComponents.DotNetBar.Layout.LayoutControl layoutControl1;

		// Token: 0x040000F2 RID: 242
		private global::DevComponents.DotNetBar.ButtonItem btnSure;

		// Token: 0x040000F3 RID: 243
		private global::DevComponents.DotNetBar.Bar menuBar;

		// Token: 0x040000F4 RID: 244
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem3;

		// Token: 0x040000F5 RID: 245
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtOneWeighed;

		// Token: 0x040000F6 RID: 246
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem7;

		// Token: 0x040000F7 RID: 247
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem8;

		// Token: 0x040000F8 RID: 248
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtLisence;

		// Token: 0x040000F9 RID: 249
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem10;

		// Token: 0x040000FA RID: 250
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem9;

		// Token: 0x040000FB RID: 251
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem4;

		// Token: 0x040000FC RID: 252
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtProduct;

		// Token: 0x040000FD RID: 253
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem14;

		// Token: 0x040000FE RID: 254
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem5;

		// Token: 0x040000FF RID: 255
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem12;

		// Token: 0x04000100 RID: 256
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem2;

		// Token: 0x04000101 RID: 257
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtDifferWeight;

		// Token: 0x04000102 RID: 258
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem15;

		// Token: 0x04000103 RID: 259
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem6;

		// Token: 0x04000104 RID: 260
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem13;

		// Token: 0x04000105 RID: 261
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem11;

		// Token: 0x04000106 RID: 262
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtImpurityAmount;

		// Token: 0x04000107 RID: 263
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem17;

		// Token: 0x04000108 RID: 264
		private global::DevComponents.DotNetBar.Controls.RichTextBoxEx rtxtImpurityDetails;

		// Token: 0x04000109 RID: 265
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtTwoWeighed;

		// Token: 0x0400010A RID: 266
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem20;

		// Token: 0x0400010B RID: 267
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem19;

		// Token: 0x0400010C RID: 268
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem18;

		// Token: 0x0400010D RID: 269
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem16;

		// Token: 0x0400010E RID: 270
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtDeductWeight;

		// Token: 0x0400010F RID: 271
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem21;

		// Token: 0x04000110 RID: 272
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtInvCode;

		// Token: 0x04000111 RID: 273
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem23;

		// Token: 0x04000112 RID: 274
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem22;

		// Token: 0x04000113 RID: 275
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtDanHao;

		// Token: 0x04000114 RID: 276
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem24;

		// Token: 0x04000115 RID: 277
		private global::DevComponents.DotNetBar.ButtonItem btnPhotoAround;

		// Token: 0x04000116 RID: 278
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem25;

		// Token: 0x04000117 RID: 279
		private global::DevComponents.DotNetBar.ButtonItem btnSettle;

		// Token: 0x04000118 RID: 280
		private global::DevComponents.DotNetBar.ButtonItem btnStatusFinish;

		// Token: 0x04000119 RID: 281
		private global::DevComponents.DotNetBar.ButtonItem btnModifyOwner;

		// Token: 0x0400011A RID: 282
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtModifyOwner;

		// Token: 0x0400011B RID: 283
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem27;

		// Token: 0x0400011C RID: 284
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem26;
	}
}
