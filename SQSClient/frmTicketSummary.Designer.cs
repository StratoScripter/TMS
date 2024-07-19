namespace SQSClient
{
	// Token: 0x0200001B RID: 27
	public partial class frmTicketSummary : global::SQSClient.BaseDialogForm
	{
		// Token: 0x0600015F RID: 351 RVA: 0x0002ADD8 File Offset: 0x00028FD8
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000160 RID: 352 RVA: 0x0002AE10 File Offset: 0x00029010
		private void InitializeComponent()
		{
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new global::System.Windows.Forms.DataGridViewCellStyle();
			this.bar = new global::DevComponents.DotNetBar.Bar();
			this.line2 = new global::DevComponents.DotNetBar.Controls.Line();
			this.controlContainerItem1 = new global::DevComponents.DotNetBar.ControlContainerItem();
			this.btnExport = new global::DevComponents.DotNetBar.ButtonItem();
			this.splitContainer1 = new global::System.Windows.Forms.SplitContainer();
			this.dgvData = new global::DevComponents.DotNetBar.Controls.DataGridViewX();
			this.layoutControl1 = new global::DevComponents.DotNetBar.Layout.LayoutControl();
			this.txtOrders = new global::System.Windows.Forms.TextBox();
			this.txtJieSuanLiang = new global::System.Windows.Forms.TextBox();
			this.txtDifferWeight = new global::System.Windows.Forms.TextBox();
			this.rtbRemark = new global::DevComponents.DotNetBar.Controls.RichTextBoxEx();
			this.dtpStartTime = new global::DevComponents.Editors.DateTimeAdv.DateTimeInput();
			this.dtpEndTime = new global::DevComponents.Editors.DateTimeAdv.DateTimeInput();
			this.btnSummary = new global::DevComponents.DotNetBar.ButtonX();
			this.chkSummaryUsed = new global::DevComponents.DotNetBar.Controls.CheckBoxX();
			this.layoutControlItem3 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem1 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem2 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem5 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem4 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem6 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem7 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem8 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.btnSearch = new global::DevComponents.DotNetBar.ButtonItem();
			this.C_Id = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_InvCode = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_Product = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_BusinessName = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_TicketCount = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_DifferWeight = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_JieSuanLiang = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			((global::System.ComponentModel.ISupportInitialize)this.bar).BeginInit();
			this.bar.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.splitContainer1).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvData).BeginInit();
			this.layoutControl1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dtpStartTime).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.dtpEndTime).BeginInit();
			base.SuspendLayout();
			this.bar.AccessibleDescription = "bar1 (menu)";
			this.bar.AccessibleName = "bar1";
			this.bar.AccessibleRole = global::System.Windows.Forms.AccessibleRole.ToolBar;
			this.bar.Controls.Add(this.line2);
			this.bar.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.bar.Font = new global::System.Drawing.Font("微软雅黑", 9f);
			this.bar.IsMaximized = false;
			this.bar.Items.AddRange(new global::DevComponents.DotNetBar.BaseItem[]
			{
				this.controlContainerItem1,
				this.btnExport
			});
			this.bar.Location = new global::System.Drawing.Point(0, 0);
			this.bar.Name = "bar";
			this.bar.Size = new global::System.Drawing.Size(815, 27);
			this.bar.Stretch = true;
			this.bar.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.bar.TabIndex = 4;
			this.bar.TabStop = false;
			this.bar.Text = "bar1";
			this.line2.ForeColor = global::System.Drawing.SystemColors.ActiveCaption;
			this.line2.Location = new global::System.Drawing.Point(3, 3);
			this.line2.Name = "line2";
			this.line2.Size = new global::System.Drawing.Size(1, 20);
			this.line2.TabIndex = 17;
			this.line2.Text = "line2";
			this.line2.VerticalLine = true;
			this.controlContainerItem1.AllowItemResize = false;
			this.controlContainerItem1.Control = this.line2;
			this.controlContainerItem1.MenuVisibility = global::DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
			this.controlContainerItem1.Name = "controlContainerItem1";
			this.btnExport.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.btnExport.Image = global::SQSClient.Properties.Resources.export16;
			this.btnExport.Name = "btnExport";
			this.btnExport.Text = "Export";
			this.btnExport.Click += new global::System.EventHandler(this.btnExport_Click);
			this.splitContainer1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new global::System.Drawing.Point(0, 27);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = global::System.Windows.Forms.Orientation.Horizontal;
			this.splitContainer1.Panel1.Controls.Add(this.dgvData);
			this.splitContainer1.Panel2.Controls.Add(this.layoutControl1);
			this.splitContainer1.Size = new global::System.Drawing.Size(815, 440);
			this.splitContainer1.SplitterDistance = 311;
			this.splitContainer1.TabIndex = 5;
			this.dgvData.AllowUserToAddRows = false;
			this.dgvData.AllowUserToDeleteRows = false;
			this.dgvData.AllowUserToResizeRows = false;
			this.dgvData.AutoSizeColumnsMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dgvData.AutoSizeRowsMode = global::System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dgvData.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dgvData.Columns.AddRange(new global::System.Windows.Forms.DataGridViewColumn[]
			{
				this.C_Id,
				this.C_InvCode,
				this.C_Product,
				this.C_BusinessName,
				this.C_TicketCount,
				this.C_DifferWeight,
				this.C_JieSuanLiang
			});
			dataGridViewCellStyle.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle.BackColor = global::System.Drawing.SystemColors.Window;
			dataGridViewCellStyle.Font = new global::System.Drawing.Font("宋体", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 134);
			dataGridViewCellStyle.ForeColor = global::System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle.SelectionBackColor = global::System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle.SelectionForeColor = global::System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle.WrapMode = global::System.Windows.Forms.DataGridViewTriState.False;
			this.dgvData.DefaultCellStyle = dataGridViewCellStyle;
			this.dgvData.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.dgvData.EnableHeadersVisualStyles = false;
			this.dgvData.GridColor = global::System.Drawing.Color.FromArgb(208, 215, 229);
			this.dgvData.Location = new global::System.Drawing.Point(0, 0);
			this.dgvData.Margin = new global::System.Windows.Forms.Padding(0);
			this.dgvData.MultiSelect = false;
			this.dgvData.Name = "dgvData";
			this.dgvData.ReadOnly = true;
			this.dgvData.RowTemplate.Height = 23;
			this.dgvData.Size = new global::System.Drawing.Size(815, 311);
			this.dgvData.TabIndex = 4;
			this.layoutControl1.Controls.Add(this.txtOrders);
			this.layoutControl1.Controls.Add(this.txtJieSuanLiang);
			this.layoutControl1.Controls.Add(this.txtDifferWeight);
			this.layoutControl1.Controls.Add(this.rtbRemark);
			this.layoutControl1.Controls.Add(this.dtpStartTime);
			this.layoutControl1.Controls.Add(this.dtpEndTime);
			this.layoutControl1.Controls.Add(this.btnSummary);
			this.layoutControl1.Controls.Add(this.chkSummaryUsed);
			this.layoutControl1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.layoutControl1.Location = new global::System.Drawing.Point(0, 0);
			this.layoutControl1.Name = "layoutControl1";
			this.layoutControl1.RootGroup.Items.AddRange(new global::DevComponents.DotNetBar.Layout.LayoutItemBase[]
			{
				this.layoutControlItem3,
				this.layoutControlItem1,
				this.layoutControlItem2,
				this.layoutControlItem5,
				this.layoutControlItem8,
				this.layoutControlItem4,
				this.layoutControlItem6,
				this.layoutControlItem7
			});
			this.layoutControl1.Size = new global::System.Drawing.Size(815, 125);
			this.layoutControl1.TabIndex = 23;
			this.txtOrders.Location = new global::System.Drawing.Point(110, 4);
			this.txtOrders.Margin = new global::System.Windows.Forms.Padding(0);
			this.txtOrders.Name = "txtOrders";
			this.txtOrders.ReadOnly = true;
			this.txtOrders.Size = new global::System.Drawing.Size(130, 21);
			this.txtOrders.TabIndex = 0;
			this.txtJieSuanLiang.Location = new global::System.Drawing.Point(639, 4);
			this.txtJieSuanLiang.Margin = new global::System.Windows.Forms.Padding(0);
			this.txtJieSuanLiang.Name = "txtJieSuanLiang";
			this.txtJieSuanLiang.ReadOnly = true;
			this.txtJieSuanLiang.Size = new global::System.Drawing.Size(172, 21);
			this.txtJieSuanLiang.TabIndex = 2;
			this.txtDifferWeight.Location = new global::System.Drawing.Point(354, 4);
			this.txtDifferWeight.Margin = new global::System.Windows.Forms.Padding(0);
			this.txtDifferWeight.Name = "txtDifferWeight";
			this.txtDifferWeight.ReadOnly = true;
			this.txtDifferWeight.Size = new global::System.Drawing.Size(171, 21);
			this.txtDifferWeight.TabIndex = 1;
			this.rtbRemark.BackgroundStyle.Class = "RichTextBoxBorder";
			this.rtbRemark.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.rtbRemark.Location = new global::System.Drawing.Point(4, 33);
			this.rtbRemark.Margin = new global::System.Windows.Forms.Padding(0);
			this.rtbRemark.MaxLength = 200;
			this.rtbRemark.Name = "rtbRemark";
			this.rtbRemark.Rtf = "{\\rtf1\\ansi\\ansicpg936\\deff0\\nouicompat\\deflang1033\\deflangfe2052{\\fonttbl{\\f0\\fnil\\fcharset134 \\'cb\\'ce\\'cc\\'e5;}}\r\n{\\*\\generator Riched20 10.0.18362}\\viewkind4\\uc1 \r\n\\pard\\f0\\fs18\\lang2052\\par\r\n}\r\n";
			this.rtbRemark.Size = new global::System.Drawing.Size(807, 50);
			this.rtbRemark.TabIndex = 3;
			this.dtpStartTime.BackgroundStyle.Class = "DateTimeInputBackground";
			this.dtpStartTime.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.dtpStartTime.ButtonDropDown.Shortcut = global::DevComponents.DotNetBar.eShortcut.AltDown;
			this.dtpStartTime.ButtonDropDown.Visible = true;
			this.dtpStartTime.IsPopupCalendarOpen = false;
			this.dtpStartTime.Location = new global::System.Drawing.Point(232, 91);
			this.dtpStartTime.Margin = new global::System.Windows.Forms.Padding(0);
			this.dtpStartTime.MonthCalendar.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.dtpStartTime.MonthCalendar.CalendarDimensions = new global::System.Drawing.Size(1, 1);
			this.dtpStartTime.MonthCalendar.ClearButtonVisible = true;
			this.dtpStartTime.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = global::DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
			this.dtpStartTime.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
			this.dtpStartTime.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.BarBackground;
			this.dtpStartTime.MonthCalendar.CommandsBackgroundStyle.BorderTop = global::DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.dtpStartTime.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
			this.dtpStartTime.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
			this.dtpStartTime.MonthCalendar.CommandsBackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.dtpStartTime.MonthCalendar.DisplayMonth = new global::System.DateTime(2016, 8, 1, 0, 0, 0, 0);
			this.dtpStartTime.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
			this.dtpStartTime.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
			this.dtpStartTime.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
			this.dtpStartTime.MonthCalendar.NavigationBackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.dtpStartTime.MonthCalendar.TodayButtonVisible = true;
			this.dtpStartTime.Name = "dtpStartTime";
			this.dtpStartTime.ShowUpDown = true;
			this.dtpStartTime.Size = new global::System.Drawing.Size(171, 21);
			this.dtpStartTime.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.dtpStartTime.TabIndex = 5;
			this.dtpEndTime.BackgroundStyle.Class = "DateTimeInputBackground";
			this.dtpEndTime.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.dtpEndTime.ButtonDropDown.Shortcut = global::DevComponents.DotNetBar.eShortcut.AltDown;
			this.dtpEndTime.ButtonDropDown.Visible = true;
			this.dtpEndTime.IsPopupCalendarOpen = false;
			this.dtpEndTime.Location = new global::System.Drawing.Point(517, 91);
			this.dtpEndTime.Margin = new global::System.Windows.Forms.Padding(0);
			this.dtpEndTime.MonthCalendar.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.dtpEndTime.MonthCalendar.CalendarDimensions = new global::System.Drawing.Size(1, 1);
			this.dtpEndTime.MonthCalendar.ClearButtonVisible = true;
			this.dtpEndTime.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = global::DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
			this.dtpEndTime.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
			this.dtpEndTime.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.BarBackground;
			this.dtpEndTime.MonthCalendar.CommandsBackgroundStyle.BorderTop = global::DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.dtpEndTime.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
			this.dtpEndTime.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
			this.dtpEndTime.MonthCalendar.CommandsBackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.dtpEndTime.MonthCalendar.DisplayMonth = new global::System.DateTime(2016, 8, 1, 0, 0, 0, 0);
			this.dtpEndTime.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
			this.dtpEndTime.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
			this.dtpEndTime.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
			this.dtpEndTime.MonthCalendar.NavigationBackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.dtpEndTime.MonthCalendar.TodayButtonVisible = true;
			this.dtpEndTime.Name = "dtpEndTime";
			this.dtpEndTime.ShowUpDown = true;
			this.dtpEndTime.Size = new global::System.Drawing.Size(171, 21);
			this.dtpEndTime.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.dtpEndTime.TabIndex = 6;
			this.btnSummary.AccessibleRole = global::System.Windows.Forms.AccessibleRole.PushButton;
			this.btnSummary.ColorTable = global::DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.btnSummary.Location = new global::System.Drawing.Point(696, 91);
			this.btnSummary.Margin = new global::System.Windows.Forms.Padding(0);
			this.btnSummary.Name = "btnSummary";
			this.btnSummary.Size = new global::System.Drawing.Size(115, 23);
			this.btnSummary.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.btnSummary.TabIndex = 7;
			this.btnSummary.Text = "Summary";
			this.btnSummary.Click += new global::System.EventHandler(this.btnSummary_Click);
			this.chkSummaryUsed.AutoSize = true;
			this.chkSummaryUsed.BackColor = global::System.Drawing.Color.Transparent;
			this.chkSummaryUsed.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.chkSummaryUsed.Location = new global::System.Drawing.Point(4, 91);
			this.chkSummaryUsed.Margin = new global::System.Windows.Forms.Padding(0);
			this.chkSummaryUsed.Name = "chkSummaryUsed";
			this.chkSummaryUsed.Size = new global::System.Drawing.Size(119, 16);
			this.chkSummaryUsed.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.chkSummaryUsed.TabIndex = 4;
			this.chkSummaryUsed.Text = "JieSuanTimeStat";
			this.chkSummaryUsed.CheckedChanged += new global::System.EventHandler(this.chkSummaryUsed_CheckedChanged);
			this.layoutControlItem3.Control = this.txtOrders;
			this.layoutControlItem3.Height = 29;
			this.layoutControlItem3.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem3.Name = "layoutControlItem3";
			this.layoutControlItem3.Text = "Orders";
			this.layoutControlItem3.Width = 30;
			this.layoutControlItem3.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem1.Control = this.txtDifferWeight;
			this.layoutControlItem1.Height = 29;
			this.layoutControlItem1.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Text = "ProNetWeight(kg)";
			this.layoutControlItem1.Width = 35;
			this.layoutControlItem1.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem2.Control = this.txtJieSuanLiang;
			this.layoutControlItem2.Height = 29;
			this.layoutControlItem2.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem2.Name = "layoutControlItem2";
			this.layoutControlItem2.Text = "CheckoutQty(kg)";
			this.layoutControlItem2.Width = 35;
			this.layoutControlItem2.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem5.Control = this.rtbRemark;
			this.layoutControlItem5.Height = 58;
			this.layoutControlItem5.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem5.Name = "layoutControlItem5";
			this.layoutControlItem5.Width = 100;
			this.layoutControlItem5.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem4.Control = this.dtpStartTime;
			this.layoutControlItem4.Height = 29;
			this.layoutControlItem4.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem4.Name = "layoutControlItem4";
			this.layoutControlItem4.Text = "StartTime";
			this.layoutControlItem4.Width = 35;
			this.layoutControlItem4.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem6.Control = this.dtpEndTime;
			this.layoutControlItem6.Height = 29;
			this.layoutControlItem6.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem6.Name = "layoutControlItem6";
			this.layoutControlItem6.Text = "EndTime";
			this.layoutControlItem6.Width = 35;
			this.layoutControlItem6.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem7.Control = this.btnSummary;
			this.layoutControlItem7.Height = 31;
			this.layoutControlItem7.MinSize = new global::System.Drawing.Size(32, 20);
			this.layoutControlItem7.Name = "layoutControlItem7";
			this.layoutControlItem7.Width = 15;
			this.layoutControlItem7.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem8.Control = this.chkSummaryUsed;
			this.layoutControlItem8.Height = 24;
			this.layoutControlItem8.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem8.Name = "layoutControlItem8";
			this.layoutControlItem8.Width = 15;
			this.layoutControlItem8.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.btnSearch.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.btnSearch.Image = global::SQSClient.Properties.Resources.search16;
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Text = "Search";
			this.C_Id.DataPropertyName = "Id";
			this.C_Id.HeaderText = "Id";
			this.C_Id.Name = "C_Id";
			this.C_Id.ReadOnly = true;
			this.C_Id.Width = 42;
			this.C_InvCode.DataPropertyName = "InvCode";
			this.C_InvCode.HeaderText = "InvCode";
			this.C_InvCode.Name = "C_InvCode";
			this.C_InvCode.ReadOnly = true;
			this.C_InvCode.Width = 72;
			this.C_Product.DataPropertyName = "ProductName";
			this.C_Product.FillWeight = 200f;
			this.C_Product.HeaderText = "Product";
			this.C_Product.Name = "C_Product";
			this.C_Product.ReadOnly = true;
			this.C_Product.Width = 72;
			this.C_BusinessName.DataPropertyName = "BusinessName";
			this.C_BusinessName.HeaderText = "BusinessType";
			this.C_BusinessName.Name = "C_BusinessName";
			this.C_BusinessName.ReadOnly = true;
			this.C_BusinessName.Width = 102;
			this.C_TicketCount.DataPropertyName = "TicketCount";
			this.C_TicketCount.HeaderText = "TicketCount";
			this.C_TicketCount.Name = "C_TicketCount";
			this.C_TicketCount.ReadOnly = true;
			this.C_TicketCount.Width = 96;
			this.C_DifferWeight.DataPropertyName = "DifferWeight";
			this.C_DifferWeight.HeaderText = "DifferWeight(kg)";
			this.C_DifferWeight.Name = "C_DifferWeight";
			this.C_DifferWeight.ReadOnly = true;
			this.C_DifferWeight.Width = 126;
			this.C_JieSuanLiang.DataPropertyName = "JieSuanLiang";
			this.C_JieSuanLiang.HeaderText = "JieSuanLiang(kg)";
			this.C_JieSuanLiang.Name = "C_JieSuanLiang";
			this.C_JieSuanLiang.ReadOnly = true;
			this.C_JieSuanLiang.Width = 126;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 12f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(194, 217, 247);
			base.ClientSize = new global::System.Drawing.Size(815, 467);
			base.Controls.Add(this.splitContainer1);
			base.Controls.Add(this.bar);
			base.Name = "frmTicketSummary";
			this.Text = "frmTicketSummary";
			base.Load += new global::System.EventHandler(this.frmTicketSummary_Load);
			((global::System.ComponentModel.ISupportInitialize)this.bar).EndInit();
			this.bar.ResumeLayout(false);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.splitContainer1).EndInit();
			this.splitContainer1.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.dgvData).EndInit();
			this.layoutControl1.ResumeLayout(false);
			this.layoutControl1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dtpStartTime).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.dtpEndTime).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000274 RID: 628
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000275 RID: 629
		private global::DevComponents.DotNetBar.Bar bar;

		// Token: 0x04000276 RID: 630
		private global::DevComponents.DotNetBar.Controls.Line line2;

		// Token: 0x04000277 RID: 631
		private global::DevComponents.DotNetBar.ControlContainerItem controlContainerItem1;

		// Token: 0x04000278 RID: 632
		private global::System.Windows.Forms.SplitContainer splitContainer1;

		// Token: 0x04000279 RID: 633
		private global::DevComponents.DotNetBar.Controls.DataGridViewX dgvData;

		// Token: 0x0400027A RID: 634
		private global::DevComponents.DotNetBar.Layout.LayoutControl layoutControl1;

		// Token: 0x0400027B RID: 635
		private global::System.Windows.Forms.TextBox txtOrders;

		// Token: 0x0400027C RID: 636
		private global::System.Windows.Forms.TextBox txtJieSuanLiang;

		// Token: 0x0400027D RID: 637
		private global::System.Windows.Forms.TextBox txtDifferWeight;

		// Token: 0x0400027E RID: 638
		private global::DevComponents.DotNetBar.Controls.RichTextBoxEx rtbRemark;

		// Token: 0x0400027F RID: 639
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem3;

		// Token: 0x04000280 RID: 640
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem1;

		// Token: 0x04000281 RID: 641
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem2;

		// Token: 0x04000282 RID: 642
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem5;

		// Token: 0x04000283 RID: 643
		private global::DevComponents.DotNetBar.ButtonItem btnExport;

		// Token: 0x04000284 RID: 644
		private global::DevComponents.Editors.DateTimeAdv.DateTimeInput dtpStartTime;

		// Token: 0x04000285 RID: 645
		private global::DevComponents.Editors.DateTimeAdv.DateTimeInput dtpEndTime;

		// Token: 0x04000286 RID: 646
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem4;

		// Token: 0x04000287 RID: 647
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem6;

		// Token: 0x04000288 RID: 648
		private global::DevComponents.DotNetBar.ButtonItem btnSearch;

		// Token: 0x04000289 RID: 649
		private global::DevComponents.DotNetBar.ButtonX btnSummary;

		// Token: 0x0400028A RID: 650
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem7;

		// Token: 0x0400028B RID: 651
		private global::DevComponents.DotNetBar.Controls.CheckBoxX chkSummaryUsed;

		// Token: 0x0400028C RID: 652
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem8;

		// Token: 0x0400028D RID: 653
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_Id;

		// Token: 0x0400028E RID: 654
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_InvCode;

		// Token: 0x0400028F RID: 655
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_Product;

		// Token: 0x04000290 RID: 656
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_BusinessName;

		// Token: 0x04000291 RID: 657
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_TicketCount;

		// Token: 0x04000292 RID: 658
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_DifferWeight;

		// Token: 0x04000293 RID: 659
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_JieSuanLiang;
	}
}
