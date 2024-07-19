namespace SQSClient
{
	// Token: 0x02000078 RID: 120
	public partial class frmPrintView : global::DevComponents.DotNetBar.OfficeForm
	{
		// Token: 0x060006AE RID: 1710 RVA: 0x000A360C File Offset: 0x000A180C
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060006AF RID: 1711 RVA: 0x000A3644 File Offset: 0x000A1844
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::SQSClient.frmPrintView));
			this.bar1 = new global::DevComponents.DotNetBar.Bar();
			this.tsComboZoom = new global::DevComponents.DotNetBar.Controls.ComboBoxEx();
			this.comboItem1 = new global::DevComponents.Editors.ComboItem();
			this.comboItem2 = new global::DevComponents.Editors.ComboItem();
			this.comboItem3 = new global::DevComponents.Editors.ComboItem();
			this.comboItem4 = new global::DevComponents.Editors.ComboItem();
			this.comboItem5 = new global::DevComponents.Editors.ComboItem();
			this.comboItem6 = new global::DevComponents.Editors.ComboItem();
			this.comboItem7 = new global::DevComponents.Editors.ComboItem();
			this.comboItem8 = new global::DevComponents.Editors.ComboItem();
			this.comboItem9 = new global::DevComponents.Editors.ComboItem();
			this.comboItem10 = new global::DevComponents.Editors.ComboItem();
			this.comboItem11 = new global::DevComponents.Editors.ComboItem();
			this.tsTxtCurrentPage = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.tsBtnPrint = new global::DevComponents.DotNetBar.ButtonItem();
			this.tsBtnPrinterSettings = new global::DevComponents.DotNetBar.ButtonItem();
			this.tsBtnPageSettings = new global::DevComponents.DotNetBar.ButtonItem();
			this.tsDDownPages = new global::DevComponents.DotNetBar.ButtonItem();
			this.pages1 = new global::DevComponents.DotNetBar.ButtonItem();
			this.pages2 = new global::DevComponents.DotNetBar.ButtonItem();
			this.pages4 = new global::DevComponents.DotNetBar.ButtonItem();
			this.pages6 = new global::DevComponents.DotNetBar.ButtonItem();
			this.pages8 = new global::DevComponents.DotNetBar.ButtonItem();
			this.controlContainerItem1 = new global::DevComponents.DotNetBar.ControlContainerItem();
			this.tsBtnZoom = new global::DevComponents.DotNetBar.ButtonItem();
			this.labelItem1 = new global::DevComponents.DotNetBar.LabelItem();
			this.controlContainerItem4 = new global::DevComponents.DotNetBar.ControlContainerItem();
			this.tsLblTotalPages = new global::DevComponents.DotNetBar.LabelItem();
			this.tsBtnPrev = new global::DevComponents.DotNetBar.ButtonItem();
			this.tsBtnNext = new global::DevComponents.DotNetBar.ButtonItem();
			this.controlContainerItem3 = new global::DevComponents.DotNetBar.ControlContainerItem();
			this.controlContainerItem2 = new global::DevComponents.DotNetBar.ControlContainerItem();
			this.printPreviewControl = new global::System.Windows.Forms.PrintPreviewControl();
			((global::System.ComponentModel.ISupportInitialize)this.bar1).BeginInit();
			this.bar1.SuspendLayout();
			base.SuspendLayout();
			this.bar1.AntiAlias = true;
			this.bar1.Controls.Add(this.tsComboZoom);
			this.bar1.Controls.Add(this.tsTxtCurrentPage);
			this.bar1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.bar1.Font = new global::System.Drawing.Font("微软雅黑", 9f);
			this.bar1.IsMaximized = false;
			this.bar1.Items.AddRange(new global::DevComponents.DotNetBar.BaseItem[]
			{
				this.tsBtnPrint,
				this.tsBtnPrinterSettings,
				this.tsBtnPageSettings,
				this.tsDDownPages,
				this.controlContainerItem1,
				this.tsBtnZoom,
				this.labelItem1,
				this.controlContainerItem4,
				this.tsLblTotalPages,
				this.tsBtnPrev,
				this.tsBtnNext
			});
			this.bar1.Location = new global::System.Drawing.Point(0, 0);
			this.bar1.Name = "bar1";
			this.bar1.Size = new global::System.Drawing.Size(723, 29);
			this.bar1.Stretch = true;
			this.bar1.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.bar1.TabIndex = 0;
			this.bar1.TabStop = false;
			this.bar1.Text = "bar1";
			this.tsComboZoom.DisplayMember = "Text";
			this.tsComboZoom.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.tsComboZoom.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.tsComboZoom.FormattingEnabled = true;
			this.tsComboZoom.ItemHeight = 18;
			this.tsComboZoom.Items.AddRange(new object[]
			{
				this.comboItem1,
				this.comboItem2,
				this.comboItem3,
				this.comboItem4,
				this.comboItem5,
				this.comboItem6,
				this.comboItem7,
				this.comboItem8,
				this.comboItem9,
				this.comboItem10,
				this.comboItem11
			});
			this.tsComboZoom.Location = new global::System.Drawing.Point(112, 2);
			this.tsComboZoom.Name = "tsComboZoom";
			this.tsComboZoom.Size = new global::System.Drawing.Size(83, 24);
			this.tsComboZoom.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.tsComboZoom.TabIndex = 1;
			this.tsComboZoom.SelectedIndexChanged += new global::System.EventHandler(this.tsComboZoom_Leave);
			this.tsComboZoom.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.tsComboZoom_KeyPress);
			this.tsComboZoom.Leave += new global::System.EventHandler(this.tsComboZoom_Leave);
			this.comboItem1.Text = "Auto";
			this.comboItem2.Text = "10%";
			this.comboItem3.Text = "25%";
			this.comboItem4.Text = "50%";
			this.comboItem5.Text = "75%";
			this.comboItem6.Text = "100%";
			this.comboItem7.Text = "150%";
			this.comboItem8.Text = "200%";
			this.comboItem9.Text = "300%";
			this.comboItem10.Text = "400%";
			this.comboItem11.Text = "500%";
			this.tsTxtCurrentPage.Border.Class = "TextBoxBorder";
			this.tsTxtCurrentPage.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.tsTxtCurrentPage.Location = new global::System.Drawing.Point(609, 3);
			this.tsTxtCurrentPage.Name = "tsTxtCurrentPage";
			this.tsTxtCurrentPage.PreventEnterBeep = true;
			this.tsTxtCurrentPage.Size = new global::System.Drawing.Size(40, 23);
			this.tsTxtCurrentPage.TabIndex = 2;
			this.tsTxtCurrentPage.Text = "1";
			this.tsTxtCurrentPage.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Right;
			this.tsTxtCurrentPage.TextChanged += new global::System.EventHandler(this.tsTxtCurrentPage_TextChanged);
			this.tsBtnPrint.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("tsBtnPrint.Image");
			this.tsBtnPrint.Name = "tsBtnPrint";
			this.tsBtnPrint.Click += new global::System.EventHandler(this.tsBtnPrint_Click);
			this.tsBtnPrinterSettings.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("tsBtnPrinterSettings.Image");
			this.tsBtnPrinterSettings.Name = "tsBtnPrinterSettings";
			this.tsBtnPrinterSettings.Text = "buttonItem1";
			this.tsBtnPrinterSettings.Click += new global::System.EventHandler(this.tsBtnPrinterSettings_Click);
			this.tsBtnPageSettings.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("tsBtnPageSettings.Image");
			this.tsBtnPageSettings.Name = "tsBtnPageSettings";
			this.tsBtnPageSettings.Text = "buttonItem1";
			this.tsBtnPageSettings.Click += new global::System.EventHandler(this.tsBtnPageSettings_Click);
			this.tsDDownPages.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("tsDDownPages.Image");
			this.tsDDownPages.Name = "tsDDownPages";
			this.tsDDownPages.SubItems.AddRange(new global::DevComponents.DotNetBar.BaseItem[]
			{
				this.pages1,
				this.pages2,
				this.pages4,
				this.pages6,
				this.pages8
			});
			this.tsDDownPages.Text = "buttonItem2";
			this.pages1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pages1.Image");
			this.pages1.Name = "pages1";
			this.pages1.Tag = "1";
			this.pages1.Text = "一页";
			this.pages1.Click += new global::System.EventHandler(this.NumOfPages_Click);
			this.pages2.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pages2.Image");
			this.pages2.Name = "pages2";
			this.pages2.Tag = "2";
			this.pages2.Text = "两页";
			this.pages2.Click += new global::System.EventHandler(this.NumOfPages_Click);
			this.pages4.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pages4.Image");
			this.pages4.Name = "pages4";
			this.pages4.Tag = "4";
			this.pages4.Text = "四页";
			this.pages4.Click += new global::System.EventHandler(this.NumOfPages_Click);
			this.pages6.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pages6.Image");
			this.pages6.Name = "pages6";
			this.pages6.Tag = "6";
			this.pages6.Text = "六页";
			this.pages6.Click += new global::System.EventHandler(this.NumOfPages_Click);
			this.pages8.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pages8.Image");
			this.pages8.Name = "pages8";
			this.pages8.Tag = "8";
			this.pages8.Text = "八页";
			this.pages8.Click += new global::System.EventHandler(this.NumOfPages_Click);
			this.controlContainerItem1.AllowItemResize = false;
			this.controlContainerItem1.Control = this.tsComboZoom;
			this.controlContainerItem1.MenuVisibility = global::DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
			this.controlContainerItem1.Name = "controlContainerItem1";
			this.tsBtnZoom.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("tsBtnZoom.Image");
			this.tsBtnZoom.Name = "tsBtnZoom";
			this.tsBtnZoom.Text = "buttonItem3";
			this.tsBtnZoom.Click += new global::System.EventHandler(this.tsBtnZoom_Click);
			this.labelItem1.ItemAlignment = global::DevComponents.DotNetBar.eItemAlignment.Far;
			this.labelItem1.Name = "labelItem1";
			this.controlContainerItem4.AllowItemResize = false;
			this.controlContainerItem4.Control = this.tsTxtCurrentPage;
			this.controlContainerItem4.MenuVisibility = global::DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
			this.controlContainerItem4.Name = "controlContainerItem4";
			this.tsLblTotalPages.Name = "tsLblTotalPages";
			this.tsLblTotalPages.Text = "/ 0";
			this.tsBtnPrev.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("tsBtnPrev.Image");
			this.tsBtnPrev.Name = "tsBtnPrev";
			this.tsBtnPrev.Text = "buttonItem4";
			this.tsBtnPrev.Click += new global::System.EventHandler(this.Navigate_Click);
			this.tsBtnNext.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("tsBtnNext.Image");
			this.tsBtnNext.Name = "tsBtnNext";
			this.tsBtnNext.Text = "buttonItem5";
			this.tsBtnNext.Click += new global::System.EventHandler(this.Navigate_Click);
			this.controlContainerItem3.AllowItemResize = false;
			this.controlContainerItem3.MenuVisibility = global::DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
			this.controlContainerItem3.Name = "controlContainerItem3";
			this.controlContainerItem2.AllowItemResize = false;
			this.controlContainerItem2.MenuVisibility = global::DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
			this.controlContainerItem2.Name = "controlContainerItem2";
			this.printPreviewControl.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.printPreviewControl.Location = new global::System.Drawing.Point(0, 29);
			this.printPreviewControl.Name = "printPreviewControl";
			this.printPreviewControl.Size = new global::System.Drawing.Size(723, 430);
			this.printPreviewControl.TabIndex = 1;
			base.ClientSize = new global::System.Drawing.Size(723, 459);
			base.Controls.Add(this.printPreviewControl);
			base.Controls.Add(this.bar1);
			this.DoubleBuffered = true;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "frmPrintView";
			this.Text = "frmPrintView";
			((global::System.ComponentModel.ISupportInitialize)this.bar1).EndInit();
			this.bar1.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x04000B45 RID: 2885
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000B46 RID: 2886
		private global::DevComponents.DotNetBar.Bar bar1;

		// Token: 0x04000B47 RID: 2887
		private global::DevComponents.DotNetBar.ButtonItem tsBtnPrint;

		// Token: 0x04000B48 RID: 2888
		private global::DevComponents.DotNetBar.ButtonItem tsDDownPages;

		// Token: 0x04000B49 RID: 2889
		private global::DevComponents.DotNetBar.ButtonItem tsBtnZoom;

		// Token: 0x04000B4A RID: 2890
		private global::DevComponents.DotNetBar.Controls.ComboBoxEx tsComboZoom;

		// Token: 0x04000B4B RID: 2891
		private global::DevComponents.DotNetBar.LabelItem tsLblTotalPages;

		// Token: 0x04000B4C RID: 2892
		private global::DevComponents.DotNetBar.ControlContainerItem controlContainerItem2;

		// Token: 0x04000B4D RID: 2893
		private global::DevComponents.DotNetBar.ButtonItem tsBtnPrev;

		// Token: 0x04000B4E RID: 2894
		private global::DevComponents.DotNetBar.ButtonItem tsBtnNext;

		// Token: 0x04000B4F RID: 2895
		private global::DevComponents.DotNetBar.ButtonItem pages1;

		// Token: 0x04000B50 RID: 2896
		private global::DevComponents.DotNetBar.ButtonItem pages2;

		// Token: 0x04000B51 RID: 2897
		private global::DevComponents.DotNetBar.ButtonItem pages4;

		// Token: 0x04000B52 RID: 2898
		private global::DevComponents.DotNetBar.ButtonItem pages6;

		// Token: 0x04000B53 RID: 2899
		private global::DevComponents.DotNetBar.ButtonItem pages8;

		// Token: 0x04000B54 RID: 2900
		private global::DevComponents.Editors.ComboItem comboItem1;

		// Token: 0x04000B55 RID: 2901
		private global::DevComponents.Editors.ComboItem comboItem2;

		// Token: 0x04000B56 RID: 2902
		private global::DevComponents.Editors.ComboItem comboItem3;

		// Token: 0x04000B57 RID: 2903
		private global::DevComponents.Editors.ComboItem comboItem4;

		// Token: 0x04000B58 RID: 2904
		private global::DevComponents.Editors.ComboItem comboItem5;

		// Token: 0x04000B59 RID: 2905
		private global::DevComponents.Editors.ComboItem comboItem6;

		// Token: 0x04000B5A RID: 2906
		private global::DevComponents.Editors.ComboItem comboItem7;

		// Token: 0x04000B5B RID: 2907
		private global::DevComponents.Editors.ComboItem comboItem8;

		// Token: 0x04000B5C RID: 2908
		private global::DevComponents.Editors.ComboItem comboItem9;

		// Token: 0x04000B5D RID: 2909
		private global::DevComponents.Editors.ComboItem comboItem10;

		// Token: 0x04000B5E RID: 2910
		private global::DevComponents.Editors.ComboItem comboItem11;

		// Token: 0x04000B5F RID: 2911
		private global::System.Windows.Forms.PrintPreviewControl printPreviewControl;

		// Token: 0x04000B60 RID: 2912
		private global::DevComponents.DotNetBar.ButtonItem tsBtnPrinterSettings;

		// Token: 0x04000B61 RID: 2913
		private global::DevComponents.DotNetBar.ButtonItem tsBtnPageSettings;

		// Token: 0x04000B62 RID: 2914
		private global::DevComponents.DotNetBar.ControlContainerItem controlContainerItem3;

		// Token: 0x04000B63 RID: 2915
		private global::DevComponents.DotNetBar.ControlContainerItem controlContainerItem1;

		// Token: 0x04000B64 RID: 2916
		private global::DevComponents.DotNetBar.Controls.TextBoxX tsTxtCurrentPage;

		// Token: 0x04000B65 RID: 2917
		private global::DevComponents.DotNetBar.LabelItem labelItem1;

		// Token: 0x04000B66 RID: 2918
		private global::DevComponents.DotNetBar.ControlContainerItem controlContainerItem4;
	}
}
