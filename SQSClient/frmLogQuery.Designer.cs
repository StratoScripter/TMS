namespace SQSClient
{
	// Token: 0x0200008B RID: 139
	public partial class frmLogQuery : global::SQSClient.BaseDialogForm
	{
		// Token: 0x06000791 RID: 1937 RVA: 0x000BB86C File Offset: 0x000B9A6C
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000792 RID: 1938 RVA: 0x000BB8A4 File Offset: 0x000B9AA4
		private void InitializeComponent()
		{
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new global::System.Windows.Forms.DataGridViewCellStyle();
			this.controlContainerItem1 = new global::DevComponents.DotNetBar.ControlContainerItem();
			this.timeSelector1 = new global::DevComponents.Editors.DateTimeAdv.TimeSelector();
			this.dgvData = new global::DevComponents.DotNetBar.Controls.DataGridViewX();
			this.C_ID = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_PCName = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_Operator = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_SysModule = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_OperateType = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_OperateStatus = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_OperateTime = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_btnDetail = new global::DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn();
			this.bar = new global::DevComponents.DotNetBar.Bar();
			this.dtpStartTime = new global::DevComponents.Editors.DateTimeAdv.DateTimeInput();
			this.dtpEndTime = new global::DevComponents.Editors.DateTimeAdv.DateTimeInput();
			this.tslblStartTime = new global::DevComponents.DotNetBar.LabelItem();
			this.controlContainerItem2 = new global::DevComponents.DotNetBar.ControlContainerItem();
			this.tslblEndTime = new global::DevComponents.DotNetBar.LabelItem();
			this.controlContainerItem3 = new global::DevComponents.DotNetBar.ControlContainerItem();
			this.btnSearch = new global::DevComponents.DotNetBar.ButtonItem();
			this.btnPrint = new global::DevComponents.DotNetBar.ButtonItem();
			this.btnExport = new global::DevComponents.DotNetBar.ButtonItem();
			this.pagination1 = new global::SQSClient.Monitor.Pagination();
			((global::System.ComponentModel.ISupportInitialize)this.dgvData).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.bar).BeginInit();
			this.bar.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dtpStartTime).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.dtpEndTime).BeginInit();
			base.SuspendLayout();
			this.controlContainerItem1.AllowItemResize = true;
			this.controlContainerItem1.MenuVisibility = global::DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
			this.controlContainerItem1.Name = "controlContainerItem1";
			this.timeSelector1.AutoSize = true;
			this.timeSelector1.BackgroundStyle.Class = "ItemPanel";
			this.timeSelector1.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.timeSelector1.ContainerControlProcessDialogKey = true;
			this.timeSelector1.Location = new global::System.Drawing.Point(71, 2);
			this.timeSelector1.Name = "timeSelector1";
			this.timeSelector1.Size = new global::System.Drawing.Size(269, 192);
			this.dgvData.AllowUserToAddRows = false;
			this.dgvData.AllowUserToDeleteRows = false;
			this.dgvData.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.dgvData.AutoSizeColumnsMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dgvData.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvData.Columns.AddRange(new global::System.Windows.Forms.DataGridViewColumn[]
			{
				this.C_ID,
				this.C_PCName,
				this.C_Operator,
				this.C_SysModule,
				this.C_OperateType,
				this.C_OperateStatus,
				this.C_OperateTime,
				this.C_btnDetail
			});
			dataGridViewCellStyle.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle.BackColor = global::System.Drawing.SystemColors.Window;
			dataGridViewCellStyle.Font = new global::System.Drawing.Font("宋体", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 134);
			dataGridViewCellStyle.ForeColor = global::System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle.SelectionBackColor = global::System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle.SelectionForeColor = global::System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle.WrapMode = global::System.Windows.Forms.DataGridViewTriState.False;
			this.dgvData.DefaultCellStyle = dataGridViewCellStyle;
			this.dgvData.GridColor = global::System.Drawing.Color.FromArgb(208, 215, 229);
			this.dgvData.Location = new global::System.Drawing.Point(0, 28);
			this.dgvData.Name = "dgvData";
			this.dgvData.ReadOnly = true;
			this.dgvData.RowHeadersVisible = false;
			this.dgvData.RowTemplate.Height = 23;
			this.dgvData.Size = new global::System.Drawing.Size(954, 316);
			this.dgvData.TabIndex = 3;
			this.dgvData.CellContentClick += new global::System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellContentClick);
			this.C_ID.HeaderText = "ID";
			this.C_ID.Name = "C_ID";
			this.C_ID.ReadOnly = true;
			this.C_ID.Visible = false;
			this.C_ID.Width = 23;
			this.C_PCName.AutoSizeMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.C_PCName.FillWeight = 63.13665f;
			this.C_PCName.HeaderText = "PCName";
			this.C_PCName.Name = "C_PCName";
			this.C_PCName.ReadOnly = true;
			this.C_Operator.AutoSizeMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.C_Operator.FillWeight = 50.50932f;
			this.C_Operator.HeaderText = "Operator";
			this.C_Operator.Name = "C_Operator";
			this.C_Operator.ReadOnly = true;
			this.C_SysModule.AutoSizeMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.C_SysModule.FillWeight = 63.13665f;
			this.C_SysModule.HeaderText = "SysModule";
			this.C_SysModule.Name = "C_SysModule";
			this.C_SysModule.ReadOnly = true;
			this.C_OperateType.AutoSizeMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.C_OperateType.FillWeight = 63.13665f;
			this.C_OperateType.HeaderText = "OperateType";
			this.C_OperateType.Name = "C_OperateType";
			this.C_OperateType.ReadOnly = true;
			this.C_OperateStatus.AutoSizeMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.C_OperateStatus.FillWeight = 37.88199f;
			this.C_OperateStatus.HeaderText = "OperateStatus";
			this.C_OperateStatus.Name = "C_OperateStatus";
			this.C_OperateStatus.ReadOnly = true;
			this.C_OperateTime.AutoSizeMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.C_OperateTime.FillWeight = 63.13665f;
			this.C_OperateTime.HeaderText = "OperateTime";
			this.C_OperateTime.Name = "C_OperateTime";
			this.C_OperateTime.ReadOnly = true;
			this.C_btnDetail.AutoSizeMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.C_btnDetail.FillWeight = 149.3159f;
			this.C_btnDetail.HeaderText = "Detail";
			this.C_btnDetail.Name = "C_btnDetail";
			this.C_btnDetail.ReadOnly = true;
			this.C_btnDetail.Text = null;
			this.bar.AntiAlias = true;
			this.bar.Controls.Add(this.dtpStartTime);
			this.bar.Controls.Add(this.dtpEndTime);
			this.bar.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.bar.Font = new global::System.Drawing.Font("微软雅黑", 9f);
			this.bar.IsMaximized = false;
			this.bar.Items.AddRange(new global::DevComponents.DotNetBar.BaseItem[]
			{
				this.tslblStartTime,
				this.controlContainerItem2,
				this.tslblEndTime,
				this.controlContainerItem3,
				this.btnSearch,
				this.btnPrint,
				this.btnExport
			});
			this.bar.Location = new global::System.Drawing.Point(0, 0);
			this.bar.Name = "bar";
			this.bar.Size = new global::System.Drawing.Size(954, 28);
			this.bar.Stretch = true;
			this.bar.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.bar.TabIndex = 0;
			this.bar.TabStop = false;
			this.dtpStartTime.BackgroundStyle.Class = "DateTimeInputBackground";
			this.dtpStartTime.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.dtpStartTime.ButtonDropDown.Shortcut = global::DevComponents.DotNetBar.eShortcut.AltDown;
			this.dtpStartTime.ButtonDropDown.Visible = true;
			this.dtpStartTime.CustomFormat = "yyyy/MM/dd HH:mm:ss";
			this.dtpStartTime.DateTimeSelectorVisibility = global::DevComponents.Editors.DateTimeAdv.eDateTimeSelectorVisibility.Both;
			this.dtpStartTime.Format = global::DevComponents.Editors.eDateTimePickerFormat.Custom;
			this.dtpStartTime.IsPopupCalendarOpen = false;
			this.dtpStartTime.Location = new global::System.Drawing.Point(66, 2);
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
			this.dtpStartTime.MonthCalendar.DayClickAutoClosePopup = false;
			this.dtpStartTime.MonthCalendar.DisplayMonth = new global::System.DateTime(2016, 8, 1, 0, 0, 0, 0);
			this.dtpStartTime.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
			this.dtpStartTime.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
			this.dtpStartTime.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
			this.dtpStartTime.MonthCalendar.NavigationBackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.dtpStartTime.MonthCalendar.TodayButtonVisible = true;
			this.dtpStartTime.Name = "dtpStartTime";
			this.dtpStartTime.Size = new global::System.Drawing.Size(200, 23);
			this.dtpStartTime.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.dtpStartTime.TabIndex = 1;
			this.dtpEndTime.BackgroundStyle.Class = "DateTimeInputBackground";
			this.dtpEndTime.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.dtpEndTime.ButtonDropDown.Shortcut = global::DevComponents.DotNetBar.eShortcut.AltDown;
			this.dtpEndTime.ButtonDropDown.Visible = true;
			this.dtpEndTime.CustomFormat = "yyyy/MM/dd HH:mm:ss";
			this.dtpEndTime.DateTimeSelectorVisibility = global::DevComponents.Editors.DateTimeAdv.eDateTimeSelectorVisibility.Both;
			this.dtpEndTime.Format = global::DevComponents.Editors.eDateTimePickerFormat.Custom;
			this.dtpEndTime.IsPopupCalendarOpen = false;
			this.dtpEndTime.Location = new global::System.Drawing.Point(328, 2);
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
			this.dtpEndTime.MonthCalendar.DayClickAutoClosePopup = false;
			this.dtpEndTime.MonthCalendar.DisplayMonth = new global::System.DateTime(2016, 8, 1, 0, 0, 0, 0);
			this.dtpEndTime.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
			this.dtpEndTime.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
			this.dtpEndTime.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
			this.dtpEndTime.MonthCalendar.NavigationBackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.dtpEndTime.MonthCalendar.TodayButtonVisible = true;
			this.dtpEndTime.Name = "dtpEndTime";
			this.dtpEndTime.Size = new global::System.Drawing.Size(200, 23);
			this.dtpEndTime.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.dtpEndTime.TabIndex = 2;
			this.tslblStartTime.Name = "tslblStartTime";
			this.tslblStartTime.Text = "StartTime";
			this.controlContainerItem2.AllowItemResize = false;
			this.controlContainerItem2.Control = this.dtpStartTime;
			this.controlContainerItem2.MenuVisibility = global::DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
			this.controlContainerItem2.Name = "controlContainerItem2";
			this.tslblEndTime.Name = "tslblEndTime";
			this.tslblEndTime.Text = "EndTime";
			this.controlContainerItem3.AllowItemResize = false;
			this.controlContainerItem3.Control = this.dtpEndTime;
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
			this.pagination1.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.pagination1.Location = new global::System.Drawing.Point(0, 342);
			this.pagination1.Name = "pagination1";
			this.pagination1.Size = new global::System.Drawing.Size(954, 32);
			this.pagination1.TabIndex = 4;
			this.pagination1.Total = 0;
			base.ClientSize = new global::System.Drawing.Size(954, 372);
			base.Controls.Add(this.pagination1);
			base.Controls.Add(this.dgvData);
			base.Controls.Add(this.bar);
			base.Name = "frmLogQuery";
			this.Text = "Log";
			base.Load += new global::System.EventHandler(this.frmLogQuery_Load);
			((global::System.ComponentModel.ISupportInitialize)this.dgvData).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.bar).EndInit();
			this.bar.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.dtpStartTime).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.dtpEndTime).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000CE3 RID: 3299
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000CE4 RID: 3300
		private global::DevComponents.DotNetBar.Bar bar;

		// Token: 0x04000CE5 RID: 3301
		private global::DevComponents.DotNetBar.LabelItem tslblStartTime;

		// Token: 0x04000CE6 RID: 3302
		private global::DevComponents.DotNetBar.LabelItem tslblEndTime;

		// Token: 0x04000CE7 RID: 3303
		private global::DevComponents.DotNetBar.ButtonItem btnSearch;

		// Token: 0x04000CE8 RID: 3304
		private global::DevComponents.DotNetBar.ButtonItem btnExport;

		// Token: 0x04000CE9 RID: 3305
		private global::DevComponents.DotNetBar.Controls.DataGridViewX dgvData;

		// Token: 0x04000CEA RID: 3306
		private global::DevComponents.DotNetBar.ControlContainerItem controlContainerItem1;

		// Token: 0x04000CEB RID: 3307
		private global::DevComponents.Editors.DateTimeAdv.TimeSelector timeSelector1;

		// Token: 0x04000CEC RID: 3308
		private global::DevComponents.Editors.DateTimeAdv.DateTimeInput dtpStartTime;

		// Token: 0x04000CED RID: 3309
		private global::DevComponents.DotNetBar.ControlContainerItem controlContainerItem2;

		// Token: 0x04000CEE RID: 3310
		private global::DevComponents.Editors.DateTimeAdv.DateTimeInput dtpEndTime;

		// Token: 0x04000CEF RID: 3311
		private global::DevComponents.DotNetBar.ControlContainerItem controlContainerItem3;

		// Token: 0x04000CF0 RID: 3312
		private global::DevComponents.DotNetBar.ButtonItem btnPrint;

		// Token: 0x04000CF1 RID: 3313
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_ID;

		// Token: 0x04000CF2 RID: 3314
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_PCName;

		// Token: 0x04000CF3 RID: 3315
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_Operator;

		// Token: 0x04000CF4 RID: 3316
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_SysModule;

		// Token: 0x04000CF5 RID: 3317
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_OperateType;

		// Token: 0x04000CF6 RID: 3318
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_OperateStatus;

		// Token: 0x04000CF7 RID: 3319
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_OperateTime;

		// Token: 0x04000CF8 RID: 3320
		private global::DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn C_btnDetail;

		// Token: 0x04000CF9 RID: 3321
		private global::SQSClient.Monitor.Pagination pagination1;
	}
}
