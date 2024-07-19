namespace SQSClient
{
	// Token: 0x02000017 RID: 23
	public partial class frmTicketBatchSubQuality : global::SQSClient.BaseDialogForm
	{
		// Token: 0x060000FA RID: 250 RVA: 0x0001C70C File Offset: 0x0001A90C
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060000FB RID: 251 RVA: 0x0001C744 File Offset: 0x0001A944
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::SQSClient.frmTicketBatchSubQuality));
			this.menuBar = new global::DevComponents.DotNetBar.Bar();
			this.btnSave = new global::DevComponents.DotNetBar.ButtonItem();
			this.laySunHao = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layAdd = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.splitContainer1 = new global::System.Windows.Forms.SplitContainer();
			this.layoutControl2 = new global::DevComponents.DotNetBar.Layout.LayoutControl();
			this.tbxInvCode = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.tbxInvName = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.tbxDanHao = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.btnWeightImport = new global::DevComponents.DotNetBar.ButtonX();
			this.dInputWeightDiff = new global::DevComponents.Editors.DoubleInput();
			this.tbxLisence = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.tbxClientPart = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.dInputNumBatchModify = new global::DevComponents.Editors.DoubleInput();
			this.layoutControlItem1 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem3 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem7 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem9 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem8 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem4 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem10 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem2 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControl1 = new global::DevComponents.DotNetBar.Layout.LayoutControl();
			this.layoutControlItem6 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.tbxWeightDetails = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.layoutControlItem5 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			((global::System.ComponentModel.ISupportInitialize)this.menuBar).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.splitContainer1).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.layoutControl2.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dInputWeightDiff).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.dInputNumBatchModify).BeginInit();
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
			this.menuBar.Size = new global::System.Drawing.Size(783, 26);
			this.menuBar.Stretch = true;
			this.menuBar.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.menuBar.TabIndex = 19;
			this.menuBar.TabStop = false;
			this.menuBar.Text = "Main Menu";
			this.btnSave.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.btnSave.Image = global::SQSClient.Properties.Resources.sure16;
			this.btnSave.Name = "btnSave";
			this.btnSave.Text = "Sure";
			this.btnSave.Click += new global::System.EventHandler(this.btnSave_Click);
			this.laySunHao.Height = 29;
			this.laySunHao.MinSize = new global::System.Drawing.Size(64, 18);
			this.laySunHao.Name = "laySunHao";
			this.laySunHao.Text = "SunHao";
			this.laySunHao.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.laySunHao.Width = 100;
			this.laySunHao.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layAdd.Height = 31;
			this.layAdd.MinSize = new global::System.Drawing.Size(32, 20);
			this.layAdd.Name = "layAdd";
			this.layAdd.Text = " ";
			this.layAdd.Width = 160;
			this.splitContainer1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new global::System.Drawing.Point(0, 26);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = global::System.Windows.Forms.Orientation.Horizontal;
			this.splitContainer1.Panel1.Controls.Add(this.layoutControl2);
			this.splitContainer1.Panel2.Controls.Add(this.layoutControl1);
			this.splitContainer1.Size = new global::System.Drawing.Size(783, 442);
			this.splitContainer1.SplitterDistance = 123;
			this.splitContainer1.TabIndex = 20;
			this.layoutControl2.Controls.Add(this.tbxInvCode);
			this.layoutControl2.Controls.Add(this.tbxInvName);
			this.layoutControl2.Controls.Add(this.tbxDanHao);
			this.layoutControl2.Controls.Add(this.btnWeightImport);
			this.layoutControl2.Controls.Add(this.dInputWeightDiff);
			this.layoutControl2.Controls.Add(this.tbxLisence);
			this.layoutControl2.Controls.Add(this.tbxClientPart);
			this.layoutControl2.Controls.Add(this.dInputNumBatchModify);
			this.layoutControl2.Controls.Add(this.tbxWeightDetails);
			this.layoutControl2.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.layoutControl2.Location = new global::System.Drawing.Point(0, 0);
			this.layoutControl2.Name = "layoutControl2";
			this.layoutControl2.RootGroup.Items.AddRange(new global::DevComponents.DotNetBar.Layout.LayoutItemBase[]
			{
				this.layoutControlItem1,
				this.layoutControlItem3,
				this.layoutControlItem7,
				this.layoutControlItem9,
				this.layoutControlItem8,
				this.layoutControlItem4,
				this.layoutControlItem10,
				this.layoutControlItem5,
				this.layoutControlItem2
			});
			this.layoutControl2.Size = new global::System.Drawing.Size(783, 123);
			this.layoutControl2.TabIndex = 22;
			this.tbxInvCode.Border.Class = "TextBoxBorder";
			this.tbxInvCode.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.tbxInvCode.Location = new global::System.Drawing.Point(488, 4);
			this.tbxInvCode.Margin = new global::System.Windows.Forms.Padding(0);
			this.tbxInvCode.Name = "tbxInvCode";
			this.tbxInvCode.PreventEnterBeep = true;
			this.tbxInvCode.Size = new global::System.Drawing.Size(93, 21);
			this.tbxInvCode.TabIndex = 2;
			this.tbxInvName.Border.Class = "TextBoxBorder";
			this.tbxInvName.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.tbxInvName.Location = new global::System.Drawing.Point(98, 33);
			this.tbxInvName.Margin = new global::System.Windows.Forms.Padding(0);
			this.tbxInvName.MaxLength = 200;
			this.tbxInvName.Name = "tbxInvName";
			this.tbxInvName.PreventEnterBeep = true;
			this.tbxInvName.Size = new global::System.Drawing.Size(93, 21);
			this.tbxInvName.TabIndex = 4;
			this.tbxDanHao.Border.Class = "TextBoxBorder";
			this.tbxDanHao.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.tbxDanHao.Location = new global::System.Drawing.Point(98, 4);
			this.tbxDanHao.Margin = new global::System.Windows.Forms.Padding(0);
			this.tbxDanHao.MaxLength = 20;
			this.tbxDanHao.Name = "tbxDanHao";
			this.tbxDanHao.PreventEnterBeep = true;
			this.tbxDanHao.Size = new global::System.Drawing.Size(93, 21);
			this.tbxDanHao.TabIndex = 0;
			this.btnWeightImport.AccessibleRole = global::System.Windows.Forms.AccessibleRole.PushButton;
			this.btnWeightImport.ColorTable = global::DevComponents.DotNetBar.eButtonColor.Orange;
			this.btnWeightImport.Image = global::SQSClient.Properties.Resources.add16;
			this.btnWeightImport.Location = new global::System.Drawing.Point(4, 91);
			this.btnWeightImport.Margin = new global::System.Windows.Forms.Padding(0);
			this.btnWeightImport.Name = "btnWeightImport";
			this.btnWeightImport.Size = new global::System.Drawing.Size(112, 23);
			this.btnWeightImport.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.btnWeightImport.TabIndex = 8;
			this.btnWeightImport.Text = "WeightImport";
			this.btnWeightImport.TextAlignment = global::DevComponents.DotNetBar.eButtonTextAlignment.Left;
			this.btnWeightImport.Tooltip = "增加物料";
			this.btnWeightImport.Click += new global::System.EventHandler(this.btnWeightImport_Click);
			this.dInputWeightDiff.BackgroundStyle.Class = "DateTimeInputBackground";
			this.dInputWeightDiff.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.dInputWeightDiff.ButtonFreeText.Shortcut = global::DevComponents.DotNetBar.eShortcut.F2;
			this.dInputWeightDiff.DisplayFormat = "0.0";
			this.dInputWeightDiff.Increment = 1.0;
			this.dInputWeightDiff.InputHorizontalAlignment = global::DevComponents.Editors.eHorizontalAlignment.Left;
			this.dInputWeightDiff.Location = new global::System.Drawing.Point(293, 4);
			this.dInputWeightDiff.Margin = new global::System.Windows.Forms.Padding(0);
			this.dInputWeightDiff.MaxValue = 100000.0;
			this.dInputWeightDiff.MinValue = 0.0;
			this.dInputWeightDiff.Name = "dInputWeightDiff";
			this.dInputWeightDiff.ShowUpDown = true;
			this.dInputWeightDiff.Size = new global::System.Drawing.Size(93, 21);
			this.dInputWeightDiff.TabIndex = 1;
			this.tbxLisence.Border.Class = "TextBoxBorder";
			this.tbxLisence.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.tbxLisence.Location = new global::System.Drawing.Point(683, 4);
			this.tbxLisence.Margin = new global::System.Windows.Forms.Padding(0);
			this.tbxLisence.Name = "tbxLisence";
			this.tbxLisence.PreventEnterBeep = true;
			this.tbxLisence.ReadOnly = true;
			this.tbxLisence.Size = new global::System.Drawing.Size(96, 21);
			this.tbxLisence.TabIndex = 3;
			this.tbxClientPart.Border.Class = "TextBoxBorder";
			this.tbxClientPart.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.tbxClientPart.Location = new global::System.Drawing.Point(488, 33);
			this.tbxClientPart.Margin = new global::System.Windows.Forms.Padding(0);
			this.tbxClientPart.MaxLength = 200;
			this.tbxClientPart.Name = "tbxClientPart";
			this.tbxClientPart.PreventEnterBeep = true;
			this.tbxClientPart.ReadOnly = true;
			this.tbxClientPart.Size = new global::System.Drawing.Size(291, 21);
			this.tbxClientPart.TabIndex = 6;
			this.dInputNumBatchModify.BackgroundStyle.Class = "DateTimeInputBackground";
			this.dInputNumBatchModify.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.dInputNumBatchModify.ButtonFreeText.Shortcut = global::DevComponents.DotNetBar.eShortcut.F2;
			this.dInputNumBatchModify.DisplayFormat = "0.0";
			this.dInputNumBatchModify.Increment = 1.0;
			this.dInputNumBatchModify.InputHorizontalAlignment = global::DevComponents.Editors.eHorizontalAlignment.Left;
			this.dInputNumBatchModify.Location = new global::System.Drawing.Point(293, 33);
			this.dInputNumBatchModify.Margin = new global::System.Windows.Forms.Padding(0);
			this.dInputNumBatchModify.MaxValue = 100000.0;
			this.dInputNumBatchModify.MinValue = 0.0;
			this.dInputNumBatchModify.Name = "dInputNumBatchModify";
			this.dInputNumBatchModify.ShowUpDown = true;
			this.dInputNumBatchModify.Size = new global::System.Drawing.Size(93, 21);
			this.dInputNumBatchModify.TabIndex = 5;
			this.layoutControlItem1.Control = this.tbxDanHao;
			this.layoutControlItem1.Height = 29;
			this.layoutControlItem1.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Text = "DanHao";
			this.layoutControlItem1.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem1.Width = 25;
			this.layoutControlItem1.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem3.Control = this.dInputWeightDiff;
			this.layoutControlItem3.Height = 29;
			this.layoutControlItem3.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem3.Name = "layoutControlItem3";
			this.layoutControlItem3.Text = "WeightDiff";
			this.layoutControlItem3.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem3.Width = 25;
			this.layoutControlItem3.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem7.Control = this.tbxInvCode;
			this.layoutControlItem7.Height = 29;
			this.layoutControlItem7.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem7.Name = "layoutControlItem7";
			this.layoutControlItem7.Text = "InvCode";
			this.layoutControlItem7.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem7.Width = 25;
			this.layoutControlItem7.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem9.Control = this.tbxLisence;
			this.layoutControlItem9.Height = 29;
			this.layoutControlItem9.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem9.Name = "layoutControlItem9";
			this.layoutControlItem9.Text = "Lisence";
			this.layoutControlItem9.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem9.Width = 25;
			this.layoutControlItem9.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem8.Control = this.tbxInvName;
			this.layoutControlItem8.Height = 29;
			this.layoutControlItem8.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem8.Name = "layoutControlItem8";
			this.layoutControlItem8.Text = "InvName";
			this.layoutControlItem8.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem8.Width = 25;
			this.layoutControlItem8.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem4.Control = this.dInputNumBatchModify;
			this.layoutControlItem4.Height = 29;
			this.layoutControlItem4.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem4.Name = "layoutControlItem4";
			this.layoutControlItem4.Text = "NumBatchModify";
			this.layoutControlItem4.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem4.Width = 25;
			this.layoutControlItem4.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem10.Control = this.tbxClientPart;
			this.layoutControlItem10.Height = 29;
			this.layoutControlItem10.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem10.Name = "layoutControlItem10";
			this.layoutControlItem10.Text = "ClientPart";
			this.layoutControlItem10.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem10.Width = 50;
			this.layoutControlItem10.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem2.Control = this.btnWeightImport;
			this.layoutControlItem2.Height = 31;
			this.layoutControlItem2.MinSize = new global::System.Drawing.Size(32, 20);
			this.layoutControlItem2.Name = "layoutControlItem2";
			this.layoutControlItem2.Width = 120;
			this.layoutControl1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.layoutControl1.Location = new global::System.Drawing.Point(0, 0);
			this.layoutControl1.Name = "layoutControl1";
			this.layoutControl1.Size = new global::System.Drawing.Size(783, 315);
			this.layoutControl1.TabIndex = 21;
			this.layoutControlItem6.Control = this.tbxLisence;
			this.layoutControlItem6.Height = 29;
			this.layoutControlItem6.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem6.Name = "layoutControlItem6";
			this.layoutControlItem6.Text = "InvCode";
			this.layoutControlItem6.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem6.Width = 25;
			this.layoutControlItem6.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.tbxWeightDetails.Border.Class = "TextBoxBorder";
			this.tbxWeightDetails.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.tbxWeightDetails.Location = new global::System.Drawing.Point(98, 62);
			this.tbxWeightDetails.Margin = new global::System.Windows.Forms.Padding(0);
			this.tbxWeightDetails.MaxLength = 200;
			this.tbxWeightDetails.Name = "tbxWeightDetails";
			this.tbxWeightDetails.PreventEnterBeep = true;
			this.tbxWeightDetails.ReadOnly = true;
			this.tbxWeightDetails.Size = new global::System.Drawing.Size(681, 21);
			this.tbxWeightDetails.TabIndex = 7;
			this.layoutControlItem5.Control = this.tbxWeightDetails;
			this.layoutControlItem5.Height = 29;
			this.layoutControlItem5.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem5.Name = "layoutControlItem5";
			this.layoutControlItem5.Text = "WeightDetails";
			this.layoutControlItem5.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem5.Width = 100;
			this.layoutControlItem5.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			base.ClientSize = new global::System.Drawing.Size(783, 468);
			base.Controls.Add(this.splitContainer1);
			base.Controls.Add(this.menuBar);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "frmTicketBatchSubQuality";
			this.Text = "frmTicketBatchSubQuality";
			base.Load += new global::System.EventHandler(this.frmTicketBatchSubQuality_Load);
			((global::System.ComponentModel.ISupportInitialize)this.menuBar).EndInit();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.splitContainer1).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.layoutControl2.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.dInputWeightDiff).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.dInputNumBatchModify).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x040001C5 RID: 453
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x040001C6 RID: 454
		private global::DevComponents.DotNetBar.Bar menuBar;

		// Token: 0x040001C7 RID: 455
		private global::DevComponents.DotNetBar.ButtonItem btnSave;

		// Token: 0x040001C8 RID: 456
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem laySunHao;

		// Token: 0x040001C9 RID: 457
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layAdd;

		// Token: 0x040001CA RID: 458
		private global::System.Windows.Forms.SplitContainer splitContainer1;

		// Token: 0x040001CB RID: 459
		private global::DevComponents.DotNetBar.Layout.LayoutControl layoutControl2;

		// Token: 0x040001CC RID: 460
		private global::DevComponents.DotNetBar.Controls.TextBoxX tbxInvCode;

		// Token: 0x040001CD RID: 461
		private global::DevComponents.DotNetBar.Controls.TextBoxX tbxInvName;

		// Token: 0x040001CE RID: 462
		private global::DevComponents.DotNetBar.Controls.TextBoxX tbxDanHao;

		// Token: 0x040001CF RID: 463
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem1;

		// Token: 0x040001D0 RID: 464
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem7;

		// Token: 0x040001D1 RID: 465
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem8;

		// Token: 0x040001D2 RID: 466
		private global::DevComponents.DotNetBar.ButtonX btnWeightImport;

		// Token: 0x040001D3 RID: 467
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem2;

		// Token: 0x040001D4 RID: 468
		private global::DevComponents.DotNetBar.Layout.LayoutControl layoutControl1;

		// Token: 0x040001D5 RID: 469
		private global::DevComponents.Editors.DoubleInput dInputWeightDiff;

		// Token: 0x040001D6 RID: 470
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem3;

		// Token: 0x040001D7 RID: 471
		private global::DevComponents.DotNetBar.Controls.TextBoxX tbxLisence;

		// Token: 0x040001D8 RID: 472
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem9;

		// Token: 0x040001D9 RID: 473
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem6;

		// Token: 0x040001DA RID: 474
		private global::DevComponents.DotNetBar.Controls.TextBoxX tbxClientPart;

		// Token: 0x040001DB RID: 475
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem10;

		// Token: 0x040001DC RID: 476
		private global::DevComponents.Editors.DoubleInput dInputNumBatchModify;

		// Token: 0x040001DD RID: 477
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem4;

		// Token: 0x040001DE RID: 478
		private global::DevComponents.DotNetBar.Controls.TextBoxX tbxWeightDetails;

		// Token: 0x040001DF RID: 479
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem5;
	}
}
