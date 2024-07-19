namespace SQSClient
{
	// Token: 0x0200008A RID: 138
	public partial class frmAlarmQuery : global::SQSClient.BaseDialogForm
	{
		// Token: 0x06000785 RID: 1925 RVA: 0x000BA4A0 File Offset: 0x000B86A0
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000786 RID: 1926 RVA: 0x000BA4D8 File Offset: 0x000B86D8
		private void InitializeComponent()
		{
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new global::System.Windows.Forms.DataGridViewCellStyle();
			this.bar = new global::DevComponents.DotNetBar.Bar();
			this.cmbDevice = new global::Base.AutoComboBox();
			this.dtpStartTime = new global::DevComponents.Editors.DateTimeAdv.DateTimeInput();
			this.dtpEndTime = new global::DevComponents.Editors.DateTimeAdv.DateTimeInput();
			this.labelItem1 = new global::DevComponents.DotNetBar.LabelItem();
			this.controlContainerItem3 = new global::DevComponents.DotNetBar.ControlContainerItem();
			this.tslblStartTime = new global::DevComponents.DotNetBar.LabelItem();
			this.controlContainerItem1 = new global::DevComponents.DotNetBar.ControlContainerItem();
			this.tslblEndTime = new global::DevComponents.DotNetBar.LabelItem();
			this.controlContainerItem2 = new global::DevComponents.DotNetBar.ControlContainerItem();
			this.btnSearch = new global::DevComponents.DotNetBar.ButtonItem();
			this.btnExport = new global::DevComponents.DotNetBar.ButtonItem();
			this.dgvData = new global::DevComponents.DotNetBar.Controls.DataGridViewX();
			this.C_Id = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_ItemNo = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_Controller = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_LoadingArm = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_AlarmDesc = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_AlarmValue = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_AlarmTime = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnPrint = new global::DevComponents.DotNetBar.ButtonItem();
			((global::System.ComponentModel.ISupportInitialize)this.bar).BeginInit();
			this.bar.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dtpStartTime).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.dtpEndTime).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.dgvData).BeginInit();
			base.SuspendLayout();
			this.bar.AntiAlias = true;
			this.bar.Controls.Add(this.cmbDevice);
			this.bar.Controls.Add(this.dtpStartTime);
			this.bar.Controls.Add(this.dtpEndTime);
			this.bar.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.bar.Font = new global::System.Drawing.Font("微软雅黑", 9f);
			this.bar.IsMaximized = false;
			this.bar.Items.AddRange(new global::DevComponents.DotNetBar.BaseItem[]
			{
				this.labelItem1,
				this.controlContainerItem3,
				this.tslblStartTime,
				this.controlContainerItem1,
				this.tslblEndTime,
				this.controlContainerItem2,
				this.btnSearch,
				this.btnPrint,
				this.btnExport
			});
			this.bar.Location = new global::System.Drawing.Point(0, 0);
			this.bar.Name = "bar";
			this.bar.Size = new global::System.Drawing.Size(993, 29);
			this.bar.Stretch = true;
			this.bar.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.bar.TabIndex = 1;
			this.bar.TabStop = false;
			this.cmbDevice.DataSource = null;
			this.cmbDevice.DisplayMember = null;
			this.cmbDevice.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cmbDevice.FormattingEnabled = true;
			this.cmbDevice.ItemHeight = 18;
			this.cmbDevice.Location = new global::System.Drawing.Point(49, 2);
			this.cmbDevice.Margin = new global::System.Windows.Forms.Padding(0);
			this.cmbDevice.MaxDropDownItems = 20;
			this.cmbDevice.MaxLength = 50;
			this.cmbDevice.Name = "cmbDevice";
			this.cmbDevice.SelectMember = null;
			this.cmbDevice.Size = new global::System.Drawing.Size(158, 24);
			this.cmbDevice.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.cmbDevice.TabIndex = 4;
			this.cmbDevice.ValueMember = null;
			this.dtpStartTime.BackgroundStyle.Class = "DateTimeInputBackground";
			this.dtpStartTime.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.dtpStartTime.ButtonDropDown.Shortcut = global::DevComponents.DotNetBar.eShortcut.AltDown;
			this.dtpStartTime.ButtonDropDown.Visible = true;
			this.dtpStartTime.CustomFormat = "yyyy/MM/dd HH:mm:ss";
			this.dtpStartTime.DateTimeSelectorVisibility = global::DevComponents.Editors.DateTimeAdv.eDateTimeSelectorVisibility.Both;
			this.dtpStartTime.Format = global::DevComponents.Editors.eDateTimePickerFormat.Custom;
			this.dtpStartTime.IsPopupCalendarOpen = false;
			this.dtpStartTime.Location = new global::System.Drawing.Point(274, 3);
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
			this.dtpEndTime.Location = new global::System.Drawing.Point(536, 3);
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
			this.labelItem1.Name = "labelItem1";
			this.labelItem1.Text = "Device";
			this.controlContainerItem3.AllowItemResize = false;
			this.controlContainerItem3.Control = this.cmbDevice;
			this.controlContainerItem3.MenuVisibility = global::DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
			this.controlContainerItem3.Name = "controlContainerItem3";
			this.tslblStartTime.Name = "tslblStartTime";
			this.tslblStartTime.Text = "StartTime";
			this.controlContainerItem1.AllowItemResize = false;
			this.controlContainerItem1.Control = this.dtpStartTime;
			this.controlContainerItem1.MenuVisibility = global::DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
			this.controlContainerItem1.Name = "controlContainerItem1";
			this.tslblEndTime.Name = "tslblEndTime";
			this.tslblEndTime.Text = "EndTime";
			this.controlContainerItem2.AllowItemResize = false;
			this.controlContainerItem2.Control = this.dtpEndTime;
			this.controlContainerItem2.MenuVisibility = global::DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
			this.controlContainerItem2.Name = "controlContainerItem2";
			this.btnSearch.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.btnSearch.Image = global::SQSClient.Properties.Resources.search16;
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Text = "Search";
			this.btnSearch.Click += new global::System.EventHandler(this.btnSearch_Click);
			this.btnExport.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.btnExport.Image = global::SQSClient.Properties.Resources.export16;
			this.btnExport.Name = "btnExport";
			this.btnExport.Text = "Export";
			this.btnExport.Click += new global::System.EventHandler(this.btnExport_Click);
			this.dgvData.AllowUserToAddRows = false;
			this.dgvData.AllowUserToDeleteRows = false;
			this.dgvData.AutoSizeColumnsMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvData.AutoSizeRowsMode = global::System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dgvData.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dgvData.Columns.AddRange(new global::System.Windows.Forms.DataGridViewColumn[]
			{
				this.C_Id,
				this.C_ItemNo,
				this.C_Controller,
				this.C_LoadingArm,
				this.C_AlarmDesc,
				this.C_AlarmValue,
				this.C_AlarmTime
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
			this.dgvData.Location = new global::System.Drawing.Point(0, 29);
			this.dgvData.Name = "dgvData";
			this.dgvData.ReadOnly = true;
			this.dgvData.RowHeadersVisible = false;
			this.dgvData.RowTemplate.Height = 23;
			this.dgvData.Size = new global::System.Drawing.Size(993, 401);
			this.dgvData.TabIndex = 3;
			this.C_Id.FillWeight = 20f;
			this.C_Id.HeaderText = "ID";
			this.C_Id.Name = "C_Id";
			this.C_Id.ReadOnly = true;
			this.C_Id.Visible = false;
			this.C_ItemNo.FillWeight = 35.26286f;
			this.C_ItemNo.HeaderText = "ItemNo";
			this.C_ItemNo.Name = "C_ItemNo";
			this.C_ItemNo.ReadOnly = true;
			this.C_Controller.FillWeight = 52.89429f;
			this.C_Controller.HeaderText = "Controller";
			this.C_Controller.Name = "C_Controller";
			this.C_Controller.ReadOnly = true;
			this.C_LoadingArm.FillWeight = 20f;
			this.C_LoadingArm.HeaderText = "LoadingArm";
			this.C_LoadingArm.Name = "C_LoadingArm";
			this.C_LoadingArm.ReadOnly = true;
			this.C_LoadingArm.Visible = false;
			this.C_AlarmDesc.FillWeight = 176.3143f;
			this.C_AlarmDesc.HeaderText = "AlarmDesc";
			this.C_AlarmDesc.Name = "C_AlarmDesc";
			this.C_AlarmDesc.ReadOnly = true;
			this.C_AlarmValue.FillWeight = 40.64408f;
			this.C_AlarmValue.HeaderText = "AlarmValue";
			this.C_AlarmValue.Name = "C_AlarmValue";
			this.C_AlarmValue.ReadOnly = true;
			this.C_AlarmTime.FillWeight = 52.89429f;
			this.C_AlarmTime.HeaderText = "AlarmTime";
			this.C_AlarmTime.Name = "C_AlarmTime";
			this.C_AlarmTime.ReadOnly = true;
			this.btnPrint.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.btnPrint.Image = global::SQSClient.Properties.Resources.print16;
			this.btnPrint.Name = "btnPrint";
			this.btnPrint.Text = "Print";
			this.btnPrint.Click += new global::System.EventHandler(this.btnPrint_Click);
			base.ClientSize = new global::System.Drawing.Size(993, 430);
			base.Controls.Add(this.dgvData);
			base.Controls.Add(this.bar);
			base.Name = "frmAlarmQuery";
			this.Text = "HistoricalAlarm";
			base.Load += new global::System.EventHandler(this.frmAlarmQuery_Load);
			((global::System.ComponentModel.ISupportInitialize)this.bar).EndInit();
			this.bar.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.dtpStartTime).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.dtpEndTime).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.dgvData).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000CC7 RID: 3271
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000CC8 RID: 3272
		private global::DevComponents.DotNetBar.Bar bar;

		// Token: 0x04000CC9 RID: 3273
		private global::DevComponents.DotNetBar.LabelItem tslblStartTime;

		// Token: 0x04000CCA RID: 3274
		private global::DevComponents.DotNetBar.LabelItem tslblEndTime;

		// Token: 0x04000CCB RID: 3275
		private global::DevComponents.DotNetBar.ButtonItem btnSearch;

		// Token: 0x04000CCC RID: 3276
		private global::DevComponents.DotNetBar.ButtonItem btnExport;

		// Token: 0x04000CCD RID: 3277
		private global::DevComponents.DotNetBar.Controls.DataGridViewX dgvData;

		// Token: 0x04000CCE RID: 3278
		private global::DevComponents.Editors.DateTimeAdv.DateTimeInput dtpEndTime;

		// Token: 0x04000CCF RID: 3279
		private global::DevComponents.Editors.DateTimeAdv.DateTimeInput dtpStartTime;

		// Token: 0x04000CD0 RID: 3280
		private global::DevComponents.DotNetBar.ControlContainerItem controlContainerItem1;

		// Token: 0x04000CD1 RID: 3281
		private global::DevComponents.DotNetBar.ControlContainerItem controlContainerItem2;

		// Token: 0x04000CD2 RID: 3282
		private global::Base.AutoComboBox cmbDevice;

		// Token: 0x04000CD3 RID: 3283
		private global::DevComponents.DotNetBar.LabelItem labelItem1;

		// Token: 0x04000CD4 RID: 3284
		private global::DevComponents.DotNetBar.ControlContainerItem controlContainerItem3;

		// Token: 0x04000CD5 RID: 3285
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_Id;

		// Token: 0x04000CD6 RID: 3286
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_ItemNo;

		// Token: 0x04000CD7 RID: 3287
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_Controller;

		// Token: 0x04000CD8 RID: 3288
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_LoadingArm;

		// Token: 0x04000CD9 RID: 3289
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_AlarmDesc;

		// Token: 0x04000CDA RID: 3290
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_AlarmValue;

		// Token: 0x04000CDB RID: 3291
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_AlarmTime;

		// Token: 0x04000CDC RID: 3292
		private global::DevComponents.DotNetBar.ButtonItem btnPrint;
	}
}
