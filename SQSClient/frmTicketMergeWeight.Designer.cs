namespace SQSClient
{
	// Token: 0x02000019 RID: 25
	public partial class frmTicketMergeWeight : global::SQSClient.BaseDialogForm
	{
		// Token: 0x06000134 RID: 308 RVA: 0x00026778 File Offset: 0x00024978
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000135 RID: 309 RVA: 0x000267B0 File Offset: 0x000249B0
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::SQSClient.frmTicketMergeWeight));
			this.menuBar = new global::DevComponents.DotNetBar.Bar();
			this.btnSave = new global::DevComponents.DotNetBar.ButtonItem();
			this.laySunHao = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layAdd = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.splitContainer1 = new global::System.Windows.Forms.SplitContainer();
			this.layoutControl2 = new global::DevComponents.DotNetBar.Layout.LayoutControl();
			this.tbxInvCode = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.tbxInvName = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.tbxDanHao = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.btnAdd = new global::DevComponents.DotNetBar.ButtonX();
			this.dInputJiHuaLiang = new global::DevComponents.Editors.DoubleInput();
			this.cmbUnit = new global::Base.AutoComboBox();
			this.labHeWeiCount = new global::DevComponents.DotNetBar.LabelX();
			this.tbxLisence = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.tbxClientPart = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.cmbLoadMode = new global::Base.AutoComboBox();
			this.layoutControlItem1 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem3 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem7 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem9 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem8 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem10 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem4 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem5 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem2 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem11 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControl1 = new global::DevComponents.DotNetBar.Layout.LayoutControl();
			this.layoutControlItem6 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			((global::System.ComponentModel.ISupportInitialize)this.menuBar).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.splitContainer1).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.layoutControl2.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dInputJiHuaLiang).BeginInit();
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
			this.splitContainer1.SplitterDistance = 96;
			this.splitContainer1.TabIndex = 20;
			this.layoutControl2.Controls.Add(this.tbxInvCode);
			this.layoutControl2.Controls.Add(this.tbxInvName);
			this.layoutControl2.Controls.Add(this.tbxDanHao);
			this.layoutControl2.Controls.Add(this.btnAdd);
			this.layoutControl2.Controls.Add(this.dInputJiHuaLiang);
			this.layoutControl2.Controls.Add(this.cmbUnit);
			this.layoutControl2.Controls.Add(this.labHeWeiCount);
			this.layoutControl2.Controls.Add(this.tbxLisence);
			this.layoutControl2.Controls.Add(this.tbxClientPart);
			this.layoutControl2.Controls.Add(this.cmbLoadMode);
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
				this.layoutControlItem10,
				this.layoutControlItem4,
				this.layoutControlItem11,
				this.layoutControlItem2,
				this.layoutControlItem5
			});
			this.layoutControl2.Size = new global::System.Drawing.Size(783, 96);
			this.layoutControl2.TabIndex = 22;
			this.tbxInvCode.Border.Class = "TextBoxBorder";
			this.tbxInvCode.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.tbxInvCode.Location = new global::System.Drawing.Point(463, 4);
			this.tbxInvCode.Margin = new global::System.Windows.Forms.Padding(0);
			this.tbxInvCode.Name = "tbxInvCode";
			this.tbxInvCode.PreventEnterBeep = true;
			this.tbxInvCode.Size = new global::System.Drawing.Size(118, 21);
			this.tbxInvCode.TabIndex = 2;
			this.tbxInvName.Border.Class = "TextBoxBorder";
			this.tbxInvName.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.tbxInvName.Location = new global::System.Drawing.Point(73, 33);
			this.tbxInvName.Margin = new global::System.Windows.Forms.Padding(0);
			this.tbxInvName.MaxLength = 200;
			this.tbxInvName.Name = "tbxInvName";
			this.tbxInvName.PreventEnterBeep = true;
			this.tbxInvName.Size = new global::System.Drawing.Size(118, 21);
			this.tbxInvName.TabIndex = 4;
			this.tbxDanHao.Border.Class = "TextBoxBorder";
			this.tbxDanHao.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.tbxDanHao.Location = new global::System.Drawing.Point(73, 4);
			this.tbxDanHao.Margin = new global::System.Windows.Forms.Padding(0);
			this.tbxDanHao.MaxLength = 20;
			this.tbxDanHao.Name = "tbxDanHao";
			this.tbxDanHao.PreventEnterBeep = true;
			this.tbxDanHao.Size = new global::System.Drawing.Size(118, 21);
			this.tbxDanHao.TabIndex = 0;
			this.btnAdd.AccessibleRole = global::System.Windows.Forms.AccessibleRole.PushButton;
			this.btnAdd.ColorTable = global::DevComponents.DotNetBar.eButtonColor.Orange;
			this.btnAdd.Image = global::SQSClient.Properties.Resources.add16;
			this.btnAdd.Location = new global::System.Drawing.Point(4, 63);
			this.btnAdd.Margin = new global::System.Windows.Forms.Padding(0);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new global::System.Drawing.Size(92, 23);
			this.btnAdd.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.btnAdd.TabIndex = 8;
			this.btnAdd.Text = "New";
			this.btnAdd.TextAlignment = global::DevComponents.DotNetBar.eButtonTextAlignment.Left;
			this.btnAdd.Tooltip = "增加物料";
			this.btnAdd.Click += new global::System.EventHandler(this.btnAdd_Click);
			this.dInputJiHuaLiang.BackgroundStyle.Class = "DateTimeInputBackground";
			this.dInputJiHuaLiang.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.dInputJiHuaLiang.ButtonFreeText.Shortcut = global::DevComponents.DotNetBar.eShortcut.F2;
			this.dInputJiHuaLiang.DisplayFormat = "0.0";
			this.dInputJiHuaLiang.Increment = 1.0;
			this.dInputJiHuaLiang.InputHorizontalAlignment = global::DevComponents.Editors.eHorizontalAlignment.Left;
			this.dInputJiHuaLiang.Location = new global::System.Drawing.Point(268, 4);
			this.dInputJiHuaLiang.Margin = new global::System.Windows.Forms.Padding(0);
			this.dInputJiHuaLiang.MaxValue = 100000.0;
			this.dInputJiHuaLiang.MinValue = 0.0;
			this.dInputJiHuaLiang.Name = "dInputJiHuaLiang";
			this.dInputJiHuaLiang.ShowUpDown = true;
			this.dInputJiHuaLiang.Size = new global::System.Drawing.Size(118, 21);
			this.dInputJiHuaLiang.TabIndex = 1;
			this.cmbUnit.DataSource = null;
			this.cmbUnit.DisplayMember = null;
			this.cmbUnit.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cmbUnit.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbUnit.FormattingEnabled = true;
			this.cmbUnit.ItemHeight = 16;
			this.cmbUnit.Location = new global::System.Drawing.Point(463, 33);
			this.cmbUnit.Margin = new global::System.Windows.Forms.Padding(0);
			this.cmbUnit.MaxDropDownItems = 20;
			this.cmbUnit.Name = "cmbUnit";
			this.cmbUnit.SelectMember = null;
			this.cmbUnit.Size = new global::System.Drawing.Size(118, 22);
			this.cmbUnit.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.cmbUnit.TabIndex = 6;
			this.cmbUnit.ValueMember = null;
			this.cmbUnit.SelectedValueChanged += new global::System.EventHandler(this.cmbUnit_SelectedValueChanged);
			this.labHeWeiCount.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.labHeWeiCount.Location = new global::System.Drawing.Point(104, 63);
			this.labHeWeiCount.Margin = new global::System.Windows.Forms.Padding(0);
			this.labHeWeiCount.Name = "labHeWeiCount";
			this.labHeWeiCount.Size = new global::System.Drawing.Size(162, 23);
			this.labHeWeiCount.TabIndex = 9;
			this.tbxLisence.Border.Class = "TextBoxBorder";
			this.tbxLisence.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.tbxLisence.Location = new global::System.Drawing.Point(658, 4);
			this.tbxLisence.Margin = new global::System.Windows.Forms.Padding(0);
			this.tbxLisence.Name = "tbxLisence";
			this.tbxLisence.PreventEnterBeep = true;
			this.tbxLisence.ReadOnly = true;
			this.tbxLisence.Size = new global::System.Drawing.Size(121, 21);
			this.tbxLisence.TabIndex = 3;
			this.tbxClientPart.Border.Class = "TextBoxBorder";
			this.tbxClientPart.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.tbxClientPart.Location = new global::System.Drawing.Point(268, 33);
			this.tbxClientPart.Margin = new global::System.Windows.Forms.Padding(0);
			this.tbxClientPart.MaxLength = 200;
			this.tbxClientPart.Name = "tbxClientPart";
			this.tbxClientPart.PreventEnterBeep = true;
			this.tbxClientPart.ReadOnly = true;
			this.tbxClientPart.Size = new global::System.Drawing.Size(118, 21);
			this.tbxClientPart.TabIndex = 5;
			this.cmbLoadMode.DataSource = null;
			this.cmbLoadMode.DisplayMember = null;
			this.cmbLoadMode.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cmbLoadMode.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbLoadMode.FormattingEnabled = true;
			this.cmbLoadMode.ItemHeight = 16;
			this.cmbLoadMode.Location = new global::System.Drawing.Point(658, 33);
			this.cmbLoadMode.Margin = new global::System.Windows.Forms.Padding(0);
			this.cmbLoadMode.MaxDropDownItems = 20;
			this.cmbLoadMode.Name = "cmbLoadMode";
			this.cmbLoadMode.SelectMember = null;
			this.cmbLoadMode.Size = new global::System.Drawing.Size(121, 22);
			this.cmbLoadMode.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.cmbLoadMode.TabIndex = 7;
			this.cmbLoadMode.ValueMember = null;
			this.layoutControlItem1.Control = this.tbxDanHao;
			this.layoutControlItem1.Height = 29;
			this.layoutControlItem1.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Text = "DanHao";
			this.layoutControlItem1.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem1.Width = 25;
			this.layoutControlItem1.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem3.Control = this.dInputJiHuaLiang;
			this.layoutControlItem3.Height = 29;
			this.layoutControlItem3.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem3.Name = "layoutControlItem3";
			this.layoutControlItem3.Text = "JiHuaLiang";
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
			this.layoutControlItem10.Control = this.tbxClientPart;
			this.layoutControlItem10.Height = 29;
			this.layoutControlItem10.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem10.Name = "layoutControlItem10";
			this.layoutControlItem10.Text = "ClientPart";
			this.layoutControlItem10.Width = 25;
			this.layoutControlItem10.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem4.Control = this.cmbUnit;
			this.layoutControlItem4.Height = 29;
			this.layoutControlItem4.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem4.Name = "layoutControlItem4";
			this.layoutControlItem4.Text = "UnitName";
			this.layoutControlItem4.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem4.Width = 25;
			this.layoutControlItem4.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem5.Control = this.labHeWeiCount;
			this.layoutControlItem5.Height = 29;
			this.layoutControlItem5.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem5.Name = "layoutControlItem5";
			this.layoutControlItem5.Width = 25;
			this.layoutControlItem5.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem2.Control = this.btnAdd;
			this.layoutControlItem2.Height = 31;
			this.layoutControlItem2.MinSize = new global::System.Drawing.Size(32, 20);
			this.layoutControlItem2.Name = "layoutControlItem2";
			this.layoutControlItem2.Width = 100;
			this.layoutControlItem11.Control = this.cmbLoadMode;
			this.layoutControlItem11.Height = 30;
			this.layoutControlItem11.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem11.Name = "layoutControlItem11";
			this.layoutControlItem11.Text = "LoadMode";
			this.layoutControlItem11.Width = 25;
			this.layoutControlItem11.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControl1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.layoutControl1.Location = new global::System.Drawing.Point(0, 0);
			this.layoutControl1.Name = "layoutControl1";
			this.layoutControl1.Size = new global::System.Drawing.Size(783, 342);
			this.layoutControl1.TabIndex = 21;
			this.layoutControlItem6.Control = this.tbxLisence;
			this.layoutControlItem6.Height = 29;
			this.layoutControlItem6.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem6.Name = "layoutControlItem6";
			this.layoutControlItem6.Text = "InvCode";
			this.layoutControlItem6.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem6.Width = 25;
			this.layoutControlItem6.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			base.ClientSize = new global::System.Drawing.Size(783, 468);
			base.Controls.Add(this.splitContainer1);
			base.Controls.Add(this.menuBar);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "frmTicketMergeWeight";
			this.Text = "frmTicketMergeWeight";
			base.Load += new global::System.EventHandler(this.frmTicketMergeWeight_Load);
			((global::System.ComponentModel.ISupportInitialize)this.menuBar).EndInit();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.splitContainer1).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.layoutControl2.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.dInputJiHuaLiang).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000236 RID: 566
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000237 RID: 567
		private global::DevComponents.DotNetBar.Bar menuBar;

		// Token: 0x04000238 RID: 568
		private global::DevComponents.DotNetBar.ButtonItem btnSave;

		// Token: 0x04000239 RID: 569
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem laySunHao;

		// Token: 0x0400023A RID: 570
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layAdd;

		// Token: 0x0400023B RID: 571
		private global::System.Windows.Forms.SplitContainer splitContainer1;

		// Token: 0x0400023C RID: 572
		private global::DevComponents.DotNetBar.Layout.LayoutControl layoutControl2;

		// Token: 0x0400023D RID: 573
		private global::DevComponents.DotNetBar.Controls.TextBoxX tbxInvCode;

		// Token: 0x0400023E RID: 574
		private global::DevComponents.DotNetBar.Controls.TextBoxX tbxInvName;

		// Token: 0x0400023F RID: 575
		private global::DevComponents.DotNetBar.Controls.TextBoxX tbxDanHao;

		// Token: 0x04000240 RID: 576
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem1;

		// Token: 0x04000241 RID: 577
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem7;

		// Token: 0x04000242 RID: 578
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem8;

		// Token: 0x04000243 RID: 579
		private global::DevComponents.DotNetBar.ButtonX btnAdd;

		// Token: 0x04000244 RID: 580
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem2;

		// Token: 0x04000245 RID: 581
		private global::DevComponents.DotNetBar.Layout.LayoutControl layoutControl1;

		// Token: 0x04000246 RID: 582
		private global::DevComponents.Editors.DoubleInput dInputJiHuaLiang;

		// Token: 0x04000247 RID: 583
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem3;

		// Token: 0x04000248 RID: 584
		private global::Base.AutoComboBox cmbUnit;

		// Token: 0x04000249 RID: 585
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem4;

		// Token: 0x0400024A RID: 586
		private global::DevComponents.DotNetBar.LabelX labHeWeiCount;

		// Token: 0x0400024B RID: 587
		private global::DevComponents.DotNetBar.Controls.TextBoxX tbxLisence;

		// Token: 0x0400024C RID: 588
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem9;

		// Token: 0x0400024D RID: 589
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem5;

		// Token: 0x0400024E RID: 590
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem6;

		// Token: 0x0400024F RID: 591
		private global::DevComponents.DotNetBar.Controls.TextBoxX tbxClientPart;

		// Token: 0x04000250 RID: 592
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem10;

		// Token: 0x04000251 RID: 593
		private global::Base.AutoComboBox cmbLoadMode;

		// Token: 0x04000252 RID: 594
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem11;
	}
}
