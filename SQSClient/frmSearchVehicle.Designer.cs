namespace SQSClient
{
	// Token: 0x02000015 RID: 21
	public partial class frmSearchVehicle : global::SQSClient.BaseDialogForm
	{
		// Token: 0x060000CD RID: 205 RVA: 0x00018F58 File Offset: 0x00017158
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00018F90 File Offset: 0x00017190
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::SQSClient.frmSearchVehicle));
			this.bar = new global::DevComponents.DotNetBar.Bar();
			this.line2 = new global::DevComponents.DotNetBar.Controls.Line();
			this.rdoVehicle = new global::DevComponents.DotNetBar.CheckBoxItem();
			this.rdoVehicleOut = new global::DevComponents.DotNetBar.CheckBoxItem();
			this.rdoVehicleSt = new global::DevComponents.DotNetBar.CheckBoxItem();
			this.btnSearch = new global::DevComponents.DotNetBar.ButtonItem();
			this.lblVehicleResult = new global::DevComponents.DotNetBar.LabelItem();
			this.lblVehicleMan = new global::DevComponents.DotNetBar.LabelItem();
			this.lblVehicleTime = new global::DevComponents.DotNetBar.LabelItem();
			this.cmbReportType = new global::DevComponents.DotNetBar.Controls.ComboBoxEx();
			this.dtpStartTime = new global::DevComponents.Editors.DateTimeAdv.DateTimeInput();
			this.controlContainerItem1 = new global::DevComponents.DotNetBar.ControlContainerItem();
			this.labReportType = new global::DevComponents.DotNetBar.LabelItem();
			this.controlContainerItem4 = new global::DevComponents.DotNetBar.ControlContainerItem();
			this.controlContainerItem3 = new global::DevComponents.DotNetBar.ControlContainerItem();
			this.lblStatisticsInfo = new global::DevComponents.DotNetBar.LabelItem();
			this.flowLayoutPanel1 = new global::System.Windows.Forms.FlowLayoutPanel();
			((global::System.ComponentModel.ISupportInitialize)this.bar).BeginInit();
			this.bar.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dtpStartTime).BeginInit();
			base.SuspendLayout();
			this.bar.AntiAlias = true;
			this.bar.Controls.Add(this.line2);
			this.bar.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.bar.Font = new global::System.Drawing.Font("微软雅黑", 9f);
			this.bar.IsMaximized = false;
			this.bar.Items.AddRange(new global::DevComponents.DotNetBar.BaseItem[]
			{
				this.rdoVehicle,
				this.rdoVehicleOut,
				this.rdoVehicleSt,
				this.btnSearch,
				this.lblVehicleResult,
				this.lblVehicleMan,
				this.lblVehicleTime
			});
			this.bar.Location = new global::System.Drawing.Point(0, 0);
			this.bar.Name = "bar";
			this.bar.Size = new global::System.Drawing.Size(761, 27);
			this.bar.Stretch = true;
			this.bar.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.bar.TabIndex = 1;
			this.bar.TabStop = false;
			this.bar.Text = "bar1";
			this.line2.ForeColor = global::System.Drawing.SystemColors.ActiveCaption;
			this.line2.Location = new global::System.Drawing.Point(237, 3);
			this.line2.Name = "line2";
			this.line2.Size = new global::System.Drawing.Size(1, 20);
			this.line2.TabIndex = 16;
			this.line2.Text = "line2";
			this.line2.VerticalLine = true;
			this.rdoVehicle.CheckBoxStyle = global::DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
			this.rdoVehicle.Name = "rdoVehicle";
			this.rdoVehicle.Text = "Vehicle";
			this.rdoVehicleOut.CheckBoxStyle = global::DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
			this.rdoVehicleOut.Name = "rdoVehicleOut";
			this.rdoVehicleOut.Text = "VehicleOut";
			this.rdoVehicleSt.CheckBoxStyle = global::DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
			this.rdoVehicleSt.Name = "rdoVehicleSt";
			this.rdoVehicleSt.Text = "VehicleSt";
			this.btnSearch.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.btnSearch.Image = global::SQSClient.Properties.Resources.search16;
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Text = "Search";
			this.btnSearch.Click += new global::System.EventHandler(this.btnSearch_Click);
			this.lblVehicleResult.ItemAlignment = global::DevComponents.DotNetBar.eItemAlignment.Far;
			this.lblVehicleResult.Name = "lblVehicleResult";
			this.lblVehicleResult.Text = "VehicleResult";
			this.lblVehicleMan.ItemAlignment = global::DevComponents.DotNetBar.eItemAlignment.Far;
			this.lblVehicleMan.Name = "lblVehicleMan";
			this.lblVehicleMan.Text = "VehicleMan";
			this.lblVehicleTime.ItemAlignment = global::DevComponents.DotNetBar.eItemAlignment.Far;
			this.lblVehicleTime.Name = "lblVehicleTime";
			this.lblVehicleTime.Text = "VehicleTime";
			this.cmbReportType.DisplayMember = "Text";
			this.cmbReportType.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cmbReportType.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbReportType.FormattingEnabled = true;
			this.cmbReportType.ItemHeight = 18;
			this.cmbReportType.Location = new global::System.Drawing.Point(210, 2);
			this.cmbReportType.Name = "cmbReportType";
			this.cmbReportType.Size = new global::System.Drawing.Size(121, 24);
			this.cmbReportType.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.cmbReportType.TabIndex = 0;
			this.dtpStartTime.BackgroundStyle.Class = "DateTimeInputBackground";
			this.dtpStartTime.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.dtpStartTime.ButtonDropDown.Shortcut = global::DevComponents.DotNetBar.eShortcut.AltDown;
			this.dtpStartTime.ButtonDropDown.Visible = true;
			this.dtpStartTime.IsPopupCalendarOpen = false;
			this.dtpStartTime.Location = new global::System.Drawing.Point(205, 2);
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
			this.dtpStartTime.Size = new global::System.Drawing.Size(200, 21);
			this.dtpStartTime.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.dtpStartTime.TabIndex = 6;
			this.controlContainerItem1.AllowItemResize = true;
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
			this.lblStatisticsInfo.ItemAlignment = global::DevComponents.DotNetBar.eItemAlignment.Far;
			this.lblStatisticsInfo.Name = "lblStatisticsInfo";
			this.lblStatisticsInfo.Text = "StatisticsInfo";
			this.flowLayoutPanel1.AutoScroll = true;
			this.flowLayoutPanel1.Location = new global::System.Drawing.Point(0, 33);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new global::System.Drawing.Size(761, 728);
			this.flowLayoutPanel1.TabIndex = 4;
			base.ClientSize = new global::System.Drawing.Size(761, 761);
			base.Controls.Add(this.flowLayoutPanel1);
			base.Controls.Add(this.bar);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "frmSearchVehicle";
			this.Text = "SearchVehicle";
			base.Load += new global::System.EventHandler(this.frmSearchVehicle_Load);
			((global::System.ComponentModel.ISupportInitialize)this.bar).EndInit();
			this.bar.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.dtpStartTime).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x0400018C RID: 396
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400018D RID: 397
		private global::DevComponents.DotNetBar.Bar bar;

		// Token: 0x0400018E RID: 398
		private global::DevComponents.DotNetBar.Controls.ComboBoxEx cmbReportType;

		// Token: 0x0400018F RID: 399
		private global::DevComponents.Editors.DateTimeAdv.DateTimeInput dtpStartTime;

		// Token: 0x04000190 RID: 400
		private global::DevComponents.DotNetBar.CheckBoxItem rdoVehicle;

		// Token: 0x04000191 RID: 401
		private global::DevComponents.DotNetBar.CheckBoxItem rdoVehicleOut;

		// Token: 0x04000192 RID: 402
		private global::DevComponents.DotNetBar.CheckBoxItem rdoVehicleSt;

		// Token: 0x04000193 RID: 403
		private global::DevComponents.DotNetBar.ControlContainerItem controlContainerItem1;

		// Token: 0x04000194 RID: 404
		private global::DevComponents.DotNetBar.LabelItem labReportType;

		// Token: 0x04000195 RID: 405
		private global::DevComponents.DotNetBar.ControlContainerItem controlContainerItem4;

		// Token: 0x04000196 RID: 406
		private global::DevComponents.DotNetBar.ControlContainerItem controlContainerItem3;

		// Token: 0x04000197 RID: 407
		private global::DevComponents.DotNetBar.Controls.Line line2;

		// Token: 0x04000198 RID: 408
		private global::DevComponents.DotNetBar.LabelItem lblStatisticsInfo;

		// Token: 0x04000199 RID: 409
		private global::DevComponents.DotNetBar.ButtonItem btnSearch;

		// Token: 0x0400019A RID: 410
		private global::System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;

		// Token: 0x0400019B RID: 411
		private global::DevComponents.DotNetBar.LabelItem lblVehicleResult;

		// Token: 0x0400019C RID: 412
		private global::DevComponents.DotNetBar.LabelItem lblVehicleMan;

		// Token: 0x0400019D RID: 413
		private global::DevComponents.DotNetBar.LabelItem lblVehicleTime;
	}
}
