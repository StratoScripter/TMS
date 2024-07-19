namespace SQSClient
{
	// Token: 0x0200007B RID: 123
	public partial class frmStatisticsReport : global::SQSClient.BaseDialogForm
	{
		// Token: 0x060006CE RID: 1742 RVA: 0x000A75B8 File Offset: 0x000A57B8
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060006CF RID: 1743 RVA: 0x000A75F0 File Offset: 0x000A57F0
		private void InitializeComponent()
		{
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new global::System.Windows.Forms.DataGridViewCellStyle();
			this.bar = new global::DevComponents.DotNetBar.Bar();
			this.line2 = new global::DevComponents.DotNetBar.Controls.Line();
			this.cmbReportType = new global::DevComponents.DotNetBar.Controls.ComboBoxEx();
			this.dtpStartTime = new global::DevComponents.Editors.DateTimeAdv.DateTimeInput();
			this.rdoProduct = new global::DevComponents.DotNetBar.CheckBoxItem();
			this.rdoUser = new global::DevComponents.DotNetBar.CheckBoxItem();
			this.controlContainerItem1 = new global::DevComponents.DotNetBar.ControlContainerItem();
			this.labReportType = new global::DevComponents.DotNetBar.LabelItem();
			this.controlContainerItem4 = new global::DevComponents.DotNetBar.ControlContainerItem();
			this.controlContainerItem3 = new global::DevComponents.DotNetBar.ControlContainerItem();
			this.btnSearch = new global::DevComponents.DotNetBar.ButtonItem();
			this.btnPrint = new global::DevComponents.DotNetBar.ButtonItem();
			this.btnExport = new global::DevComponents.DotNetBar.ButtonItem();
			this.panelExReport = new global::DevComponents.DotNetBar.PanelEx();
			this.dgvData = new global::DevComponents.DotNetBar.Controls.DataGridViewX();
			this.lblStatisticsInfo = new global::DevComponents.DotNetBar.LabelItem();
			((global::System.ComponentModel.ISupportInitialize)this.bar).BeginInit();
			this.bar.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dtpStartTime).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.dgvData).BeginInit();
			base.SuspendLayout();
			this.bar.AntiAlias = true;
			this.bar.Controls.Add(this.line2);
			this.bar.Controls.Add(this.cmbReportType);
			this.bar.Controls.Add(this.dtpStartTime);
			this.bar.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.bar.Font = new global::System.Drawing.Font("微软雅黑", 9f);
			this.bar.IsMaximized = false;
			this.bar.Items.AddRange(new global::DevComponents.DotNetBar.BaseItem[]
			{
				this.rdoProduct,
				this.rdoUser,
				this.controlContainerItem1,
				this.labReportType,
				this.controlContainerItem4,
				this.controlContainerItem3,
				this.btnSearch,
				this.btnPrint,
				this.btnExport,
				this.lblStatisticsInfo
			});
			this.bar.Location = new global::System.Drawing.Point(0, 0);
			this.bar.Name = "bar";
			this.bar.Size = new global::System.Drawing.Size(1129, 29);
			this.bar.Stretch = true;
			this.bar.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.bar.TabIndex = 0;
			this.bar.TabStop = false;
			this.bar.Text = "bar1";
			this.line2.ForeColor = global::System.Drawing.SystemColors.ActiveCaption;
			this.line2.Location = new global::System.Drawing.Point(156, 4);
			this.line2.Name = "line2";
			this.line2.Size = new global::System.Drawing.Size(1, 20);
			this.line2.TabIndex = 16;
			this.line2.Text = "line2";
			this.line2.VerticalLine = true;
			this.cmbReportType.DisplayMember = "Text";
			this.cmbReportType.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cmbReportType.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbReportType.FormattingEnabled = true;
			this.cmbReportType.ItemHeight = 18;
			this.cmbReportType.Location = new global::System.Drawing.Point(236, 2);
			this.cmbReportType.Name = "cmbReportType";
			this.cmbReportType.Size = new global::System.Drawing.Size(121, 24);
			this.cmbReportType.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.cmbReportType.TabIndex = 0;
			this.cmbReportType.SelectedIndexChanged += new global::System.EventHandler(this.cobReportType_SelectedIndexChanged);
			this.dtpStartTime.BackgroundStyle.Class = "DateTimeInputBackground";
			this.dtpStartTime.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.dtpStartTime.ButtonDropDown.Shortcut = global::DevComponents.DotNetBar.eShortcut.AltDown;
			this.dtpStartTime.ButtonDropDown.Visible = true;
			this.dtpStartTime.IsPopupCalendarOpen = false;
			this.dtpStartTime.Location = new global::System.Drawing.Point(361, 3);
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
			this.dtpStartTime.Size = new global::System.Drawing.Size(200, 23);
			this.dtpStartTime.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.dtpStartTime.TabIndex = 6;
			this.rdoProduct.CheckBoxStyle = global::DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
			this.rdoProduct.Name = "rdoProduct";
			this.rdoProduct.Text = "Product";
			this.rdoProduct.CheckedChanged += new global::DevComponents.DotNetBar.CheckBoxChangeEventHandler(this.rdoProduct_CheckedChanged);
			this.rdoUser.CheckBoxStyle = global::DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
			this.rdoUser.Name = "rdoUser";
			this.rdoUser.Text = "Customer";
			this.rdoUser.CheckedChanged += new global::DevComponents.DotNetBar.CheckBoxChangeEventHandler(this.rdoUser_CheckedChanged);
			this.controlContainerItem1.AllowItemResize = false;
			this.controlContainerItem1.Control = this.line2;
			this.controlContainerItem1.MenuVisibility = global::DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
			this.controlContainerItem1.Name = "controlContainerItem1";
			this.labReportType.Name = "labReportType";
			this.labReportType.Text = "ReportType";
			this.controlContainerItem4.AllowItemResize = false;
			this.controlContainerItem4.Control = this.cmbReportType;
			this.controlContainerItem4.MenuVisibility = global::DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
			this.controlContainerItem4.Name = "controlContainerItem4";
			this.controlContainerItem3.AllowItemResize = false;
			this.controlContainerItem3.Control = this.dtpStartTime;
			this.controlContainerItem3.MenuVisibility = global::DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
			this.controlContainerItem3.Name = "controlContainerItem3";
			this.btnSearch.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.btnSearch.Image = global::SQSClient.Properties.Resources.search16;
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Text = "Search";
			this.btnSearch.Click += new global::System.EventHandler(this.btnSearch_Click);
			this.btnPrint.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.btnPrint.Image = global::SQSClient.Properties.Resources.print16;
			this.btnPrint.Name = "btnPrint";
			this.btnPrint.Text = "Print";
			this.btnPrint.Click += new global::System.EventHandler(this.btnPrint_Click);
			this.btnExport.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.btnExport.Image = global::SQSClient.Properties.Resources.export16;
			this.btnExport.Name = "btnExport";
			this.btnExport.Text = "Export";
			this.btnExport.Click += new global::System.EventHandler(this.btnExport_Click);
			this.panelExReport.CanvasColor = global::System.Drawing.SystemColors.Control;
			this.panelExReport.ColorSchemeStyle = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.panelExReport.DisabledBackColor = global::System.Drawing.Color.Empty;
			this.panelExReport.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.panelExReport.Location = new global::System.Drawing.Point(0, 501);
			this.panelExReport.Name = "panelExReport";
			this.panelExReport.Size = new global::System.Drawing.Size(1129, 17);
			this.panelExReport.Style.Alignment = global::System.Drawing.StringAlignment.Center;
			this.panelExReport.Style.BackColor1.ColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
			this.panelExReport.Style.BackColor2.ColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
			this.panelExReport.Style.Border = global::DevComponents.DotNetBar.eBorderType.SingleLine;
			this.panelExReport.Style.BorderColor.ColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
			this.panelExReport.Style.ForeColor.ColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelText;
			this.panelExReport.Style.GradientAngle = 90;
			this.panelExReport.TabIndex = 5;
			this.dgvData.AllowUserToAddRows = false;
			this.dgvData.AllowUserToDeleteRows = false;
			this.dgvData.AllowUserToOrderColumns = true;
			this.dgvData.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle.BackColor = global::System.Drawing.SystemColors.Window;
			dataGridViewCellStyle.Font = new global::System.Drawing.Font("宋体", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 134);
			dataGridViewCellStyle.ForeColor = global::System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle.SelectionBackColor = global::System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle.SelectionForeColor = global::System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle.WrapMode = global::System.Windows.Forms.DataGridViewTriState.False;
			this.dgvData.DefaultCellStyle = dataGridViewCellStyle;
			this.dgvData.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.dgvData.GridColor = global::System.Drawing.Color.FromArgb(208, 215, 229);
			this.dgvData.Location = new global::System.Drawing.Point(0, 29);
			this.dgvData.Name = "dgvData";
			this.dgvData.ReadOnly = true;
			this.dgvData.RowTemplate.Height = 23;
			this.dgvData.Size = new global::System.Drawing.Size(1129, 472);
			this.dgvData.TabIndex = 9;
			this.dgvData.SelectionChanged += new global::System.EventHandler(this.dgvData_SelectionChanged);
			this.lblStatisticsInfo.ItemAlignment = global::DevComponents.DotNetBar.eItemAlignment.Far;
			this.lblStatisticsInfo.Name = "lblStatisticsInfo";
			this.lblStatisticsInfo.Text = "StatisticsInfo";
			base.ClientSize = new global::System.Drawing.Size(1129, 518);
			base.Controls.Add(this.dgvData);
			base.Controls.Add(this.panelExReport);
			base.Controls.Add(this.bar);
			base.Name = "frmStatisticsReport";
			this.Text = "StatisticsReport";
			base.Load += new global::System.EventHandler(this.frmStatisticsReport_Load);
			((global::System.ComponentModel.ISupportInitialize)this.bar).EndInit();
			this.bar.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.dtpStartTime).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.dgvData).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000B8F RID: 2959
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000B90 RID: 2960
		private global::DevComponents.DotNetBar.Bar bar;

		// Token: 0x04000B91 RID: 2961
		private global::DevComponents.DotNetBar.CheckBoxItem rdoProduct;

		// Token: 0x04000B92 RID: 2962
		private global::DevComponents.DotNetBar.CheckBoxItem rdoUser;

		// Token: 0x04000B93 RID: 2963
		private global::DevComponents.DotNetBar.LabelItem labReportType;

		// Token: 0x04000B94 RID: 2964
		private global::DevComponents.DotNetBar.Controls.Line line2;

		// Token: 0x04000B95 RID: 2965
		private global::DevComponents.DotNetBar.ControlContainerItem controlContainerItem1;

		// Token: 0x04000B96 RID: 2966
		private global::DevComponents.DotNetBar.ButtonItem btnSearch;

		// Token: 0x04000B97 RID: 2967
		private global::DevComponents.Editors.DateTimeAdv.DateTimeInput dtpStartTime;

		// Token: 0x04000B98 RID: 2968
		private global::DevComponents.DotNetBar.ControlContainerItem controlContainerItem3;

		// Token: 0x04000B99 RID: 2969
		private global::DevComponents.DotNetBar.PanelEx panelExReport;

		// Token: 0x04000B9A RID: 2970
		private global::DevComponents.DotNetBar.ButtonItem btnPrint;

		// Token: 0x04000B9B RID: 2971
		private global::DevComponents.DotNetBar.Controls.ComboBoxEx cmbReportType;

		// Token: 0x04000B9C RID: 2972
		private global::DevComponents.DotNetBar.ControlContainerItem controlContainerItem4;

		// Token: 0x04000B9D RID: 2973
		private global::DevComponents.DotNetBar.ButtonItem btnExport;

		// Token: 0x04000B9E RID: 2974
		private global::DevComponents.DotNetBar.Controls.DataGridViewX dgvData;

		// Token: 0x04000B9F RID: 2975
		private global::DevComponents.DotNetBar.LabelItem lblStatisticsInfo;
	}
}
