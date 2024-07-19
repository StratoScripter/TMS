namespace SQSClient
{
	// Token: 0x02000091 RID: 145
	public partial class frmTruck : global::SQSClient.BaseDialogForm
	{
		// Token: 0x060007FE RID: 2046 RVA: 0x000C6288 File Offset: 0x000C4488
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060007FF RID: 2047 RVA: 0x000C62C0 File Offset: 0x000C44C0
		private void InitializeComponent()
		{
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::SQSClient.frmTruck));
			this.dgvData = new global::DevComponents.DotNetBar.Controls.DataGridViewX();
			this.C_Id = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_Lisence = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_Driver = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_Supercargo = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_CoachNum = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_CoachType = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_Vol = new global::DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn();
			this.C_Factor = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_NetWeight = new global::DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn();
			this.C_CangShu = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_ValidDate = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_Weight = new global::DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn();
			this.C_LoadWeight = new global::DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn();
			this.C_SubUnit = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_Remark = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bar = new global::DevComponents.DotNetBar.Bar();
			this.line2 = new global::DevComponents.DotNetBar.Controls.Line();
			this.btnAdd = new global::DevComponents.DotNetBar.ButtonItem();
			this.btnModify = new global::DevComponents.DotNetBar.ButtonItem();
			this.btnDelete = new global::DevComponents.DotNetBar.ButtonItem();
			this.controlContainerItem1 = new global::DevComponents.DotNetBar.ControlContainerItem();
			this.labNo = new global::DevComponents.DotNetBar.LabelItem();
			this.txtName = new global::DevComponents.DotNetBar.TextBoxItem();
			this.btnSearch = new global::DevComponents.DotNetBar.ButtonItem();
			this.btnSpecialStepClass = new global::DevComponents.DotNetBar.ButtonItem();
			this.txtNowPage = new global::System.Windows.Forms.TextBox();
			this.cmbPage = new global::System.Windows.Forms.ComboBox();
			this.bar1 = new global::DevComponents.DotNetBar.Bar();
			this.labPage = new global::DevComponents.DotNetBar.LabelItem();
			this.controlContainerItem2 = new global::DevComponents.DotNetBar.ControlContainerItem();
			this.labItem = new global::DevComponents.DotNetBar.LabelItem();
			this.btn_pageup = new global::DevComponents.DotNetBar.ButtonItem();
			this.controlContainerItem5 = new global::DevComponents.DotNetBar.ControlContainerItem();
			this.labelItem1 = new global::DevComponents.DotNetBar.LabelItem();
			this.labPageCounts = new global::DevComponents.DotNetBar.LabelItem();
			this.btn_pagedown = new global::DevComponents.DotNetBar.ButtonItem();
			this.controlContainerItem4 = new global::DevComponents.DotNetBar.ControlContainerItem();
			this.controlContainerItem3 = new global::DevComponents.DotNetBar.ControlContainerItem();
			this.controlContainerItem6 = new global::DevComponents.DotNetBar.ControlContainerItem();
			this.comboItem1 = new global::DevComponents.Editors.ComboItem();
			this.comboItem2 = new global::DevComponents.Editors.ComboItem();
			this.comboItem3 = new global::DevComponents.Editors.ComboItem();
			this.comboItem4 = new global::DevComponents.Editors.ComboItem();
			this.comboItem5 = new global::DevComponents.Editors.ComboItem();
			this.comboItem6 = new global::DevComponents.Editors.ComboItem();
			this.comboItem7 = new global::DevComponents.Editors.ComboItem();
			this.comboItem8 = new global::DevComponents.Editors.ComboItem();
			this.comboItem9 = new global::DevComponents.Editors.ComboItem();
			((global::System.ComponentModel.ISupportInitialize)this.dgvData).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.bar).BeginInit();
			this.bar.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.bar1).BeginInit();
			this.bar1.SuspendLayout();
			base.SuspendLayout();
			this.dgvData.AllowUserToAddRows = false;
			this.dgvData.AllowUserToDeleteRows = false;
			this.dgvData.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.dgvData.AutoSizeColumnsMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvData.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvData.Columns.AddRange(new global::System.Windows.Forms.DataGridViewColumn[]
			{
				this.C_Id,
				this.C_Lisence,
				this.C_Driver,
				this.C_Supercargo,
				this.C_CoachNum,
				this.C_CoachType,
				this.C_Vol,
				this.C_Factor,
				this.C_NetWeight,
				this.C_CangShu,
				this.C_ValidDate,
				this.C_Weight,
				this.C_LoadWeight,
				this.C_SubUnit,
				this.C_Remark
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
			this.dgvData.Location = new global::System.Drawing.Point(0, 30);
			this.dgvData.Name = "dgvData";
			this.dgvData.ReadOnly = true;
			this.dgvData.RowHeadersVisible = false;
			this.dgvData.RowTemplate.Height = 23;
			this.dgvData.Size = new global::System.Drawing.Size(1316, 582);
			this.dgvData.TabIndex = 3;
			this.dgvData.CellClick += new global::System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellClick);
			this.dgvData.CellDoubleClick += new global::System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellDoubleClick);
			this.C_Id.HeaderText = "ID";
			this.C_Id.Name = "C_Id";
			this.C_Id.ReadOnly = true;
			this.C_Id.Visible = false;
			this.C_Lisence.HeaderText = "Lisence";
			this.C_Lisence.Name = "C_Lisence";
			this.C_Lisence.ReadOnly = true;
			this.C_Driver.HeaderText = "Driver";
			this.C_Driver.Name = "C_Driver";
			this.C_Driver.ReadOnly = true;
			this.C_Supercargo.HeaderText = "Supercargo";
			this.C_Supercargo.Name = "C_Supercargo";
			this.C_Supercargo.ReadOnly = true;
			this.C_CoachNum.HeaderText = "CoachNum";
			this.C_CoachNum.Name = "C_CoachNum";
			this.C_CoachNum.ReadOnly = true;
			this.C_CoachType.HeaderText = "CoachType";
			this.C_CoachType.Name = "C_CoachType";
			this.C_CoachType.ReadOnly = true;
			this.C_Vol.BackgroundStyle.Class = "DataGridViewNumericBorder";
			this.C_Vol.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.C_Vol.HeaderText = "Vol(m³)";
			this.C_Vol.Increment = 1.0;
			this.C_Vol.InputHorizontalAlignment = global::DevComponents.Editors.eHorizontalAlignment.Left;
			this.C_Vol.Name = "C_Vol";
			this.C_Vol.ReadOnly = true;
			this.C_Vol.Resizable = global::System.Windows.Forms.DataGridViewTriState.True;
			this.C_Factor.HeaderText = "Factor";
			this.C_Factor.Name = "C_Factor";
			this.C_Factor.ReadOnly = true;
			this.C_NetWeight.BackgroundStyle.Class = "DataGridViewNumericBorder";
			this.C_NetWeight.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.C_NetWeight.HeaderText = "NetWeight(kg)";
			this.C_NetWeight.Increment = 1.0;
			this.C_NetWeight.InputHorizontalAlignment = global::DevComponents.Editors.eHorizontalAlignment.Left;
			this.C_NetWeight.Name = "C_NetWeight";
			this.C_NetWeight.ReadOnly = true;
			this.C_NetWeight.Resizable = global::System.Windows.Forms.DataGridViewTriState.True;
			this.C_CangShu.HeaderText = "CangShu";
			this.C_CangShu.Name = "C_CangShu";
			this.C_CangShu.ReadOnly = true;
			this.C_ValidDate.HeaderText = "ValidDate";
			this.C_ValidDate.Name = "C_ValidDate";
			this.C_ValidDate.ReadOnly = true;
			this.C_Weight.BackgroundStyle.Class = "DataGridViewNumericBorder";
			this.C_Weight.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.C_Weight.HeaderText = "Weight(kg)";
			this.C_Weight.Increment = 1.0;
			this.C_Weight.InputHorizontalAlignment = global::DevComponents.Editors.eHorizontalAlignment.Left;
			this.C_Weight.Name = "C_Weight";
			this.C_Weight.ReadOnly = true;
			this.C_Weight.Resizable = global::System.Windows.Forms.DataGridViewTriState.True;
			this.C_LoadWeight.BackgroundStyle.Class = "DataGridViewNumericBorder";
			this.C_LoadWeight.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.C_LoadWeight.HeaderText = "LoadWeight(kg)";
			this.C_LoadWeight.Increment = 1.0;
			this.C_LoadWeight.InputHorizontalAlignment = global::DevComponents.Editors.eHorizontalAlignment.Left;
			this.C_LoadWeight.Name = "C_LoadWeight";
			this.C_LoadWeight.ReadOnly = true;
			this.C_SubUnit.HeaderText = "SubUnit";
			this.C_SubUnit.Name = "C_SubUnit";
			this.C_SubUnit.ReadOnly = true;
			this.C_Remark.HeaderText = "Remark";
			this.C_Remark.Name = "C_Remark";
			this.C_Remark.ReadOnly = true;
			this.bar.AccessibleDescription = "bar1 (menu)";
			this.bar.AccessibleName = "bar1";
			this.bar.AccessibleRole = global::System.Windows.Forms.AccessibleRole.ToolBar;
			this.bar.Controls.Add(this.line2);
			this.bar.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.bar.Font = new global::System.Drawing.Font("微软雅黑", 9f);
			this.bar.IsMaximized = false;
			this.bar.Items.AddRange(new global::DevComponents.DotNetBar.BaseItem[]
			{
				this.btnAdd,
				this.btnModify,
				this.btnDelete,
				this.controlContainerItem1,
				this.labNo,
				this.txtName,
				this.btnSearch,
				this.btnSpecialStepClass
			});
			this.bar.Location = new global::System.Drawing.Point(0, 0);
			this.bar.Name = "bar";
			this.bar.Size = new global::System.Drawing.Size(1316, 27);
			this.bar.Stretch = true;
			this.bar.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.bar.TabIndex = 2;
			this.bar.TabStop = false;
			this.bar.Text = "bar1";
			this.line2.ForeColor = global::System.Drawing.SystemColors.ActiveCaption;
			this.line2.Location = new global::System.Drawing.Point(196, 3);
			this.line2.Name = "line2";
			this.line2.Size = new global::System.Drawing.Size(1, 20);
			this.line2.TabIndex = 17;
			this.line2.Text = "line2";
			this.line2.VerticalLine = true;
			this.btnAdd.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.btnAdd.Image = global::SQSClient.Properties.Resources.add16;
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Text = "Add";
			this.btnAdd.Click += new global::System.EventHandler(this.btnAdd_Click);
			this.btnModify.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.btnModify.Image = global::SQSClient.Properties.Resources.modify16;
			this.btnModify.Name = "btnModify";
			this.btnModify.Text = "Modify";
			this.btnModify.Click += new global::System.EventHandler(this.btnModify_Click);
			this.btnDelete.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.btnDelete.Image = global::SQSClient.Properties.Resources.delete16;
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Text = "Delete";
			this.btnDelete.Click += new global::System.EventHandler(this.btnDelete_Click);
			this.controlContainerItem1.AllowItemResize = false;
			this.controlContainerItem1.Control = this.line2;
			this.controlContainerItem1.MenuVisibility = global::DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
			this.controlContainerItem1.Name = "controlContainerItem1";
			this.labNo.Name = "labNo";
			this.labNo.Text = "CheNum";
			this.txtName.MaxLength = 50;
			this.txtName.Name = "txtName";
			this.txtName.TextBoxWidth = 120;
			this.txtName.WatermarkColor = global::System.Drawing.SystemColors.GrayText;
			this.txtName.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
			this.btnSearch.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.btnSearch.Image = global::SQSClient.Properties.Resources.search16;
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Text = "Search";
			this.btnSearch.Click += new global::System.EventHandler(this.btnSearch_Click);
			this.btnSpecialStepClass.ItemAlignment = global::DevComponents.DotNetBar.eItemAlignment.Far;
			this.btnSpecialStepClass.Name = "btnSpecialStepClass";
			this.btnSpecialStepClass.Text = "SpecialStepClass";
			this.btnSpecialStepClass.Click += new global::System.EventHandler(this.btnSpecialStepClass_Click);
			this.txtNowPage.Location = new global::System.Drawing.Point(1136, 3);
			this.txtNowPage.Name = "txtNowPage";
			this.txtNowPage.Size = new global::System.Drawing.Size(64, 23);
			this.txtNowPage.TabIndex = 21;
			this.txtNowPage.Text = "1";
			this.txtNowPage.TextChanged += new global::System.EventHandler(this.txtNowPageChanged);
			this.cmbPage.FormattingEnabled = true;
			this.cmbPage.Items.AddRange(new object[]
			{
				"30",
				"50",
				"100"
			});
			this.cmbPage.Location = new global::System.Drawing.Point(39, 2);
			this.cmbPage.Name = "cmbPage";
			this.cmbPage.Size = new global::System.Drawing.Size(64, 25);
			this.cmbPage.TabIndex = 19;
			this.cmbPage.Text = "30";
			this.cmbPage.SelectedIndexChanged += new global::System.EventHandler(this.cmbPage_SelectedIndexChanged);
			this.bar1.AccessibleDescription = "bar_Page";
			this.bar1.AccessibleName = "barPage";
			this.bar1.AccessibleRole = global::System.Windows.Forms.AccessibleRole.ToolBar;
			this.bar1.Controls.Add(this.cmbPage);
			this.bar1.Controls.Add(this.txtNowPage);
			this.bar1.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.bar1.Font = new global::System.Drawing.Font("微软雅黑", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 134);
			this.bar1.IsMaximized = false;
			this.bar1.Items.AddRange(new global::DevComponents.DotNetBar.BaseItem[]
			{
				this.labPage,
				this.controlContainerItem2,
				this.labItem,
				this.btn_pageup,
				this.controlContainerItem5,
				this.labelItem1,
				this.labPageCounts,
				this.btn_pagedown
			});
			this.bar1.Location = new global::System.Drawing.Point(0, 614);
			this.bar1.Name = "bar1";
			this.bar1.Size = new global::System.Drawing.Size(1316, 30);
			this.bar1.Stretch = true;
			this.bar1.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.bar1.TabIndex = 4;
			this.bar1.TabStop = false;
			this.bar1.Text = "bar1";
			this.labPage.Name = "labPage";
			this.labPage.Text = "Page";
			this.controlContainerItem2.AllowItemResize = false;
			this.controlContainerItem2.Control = this.cmbPage;
			this.controlContainerItem2.MenuVisibility = global::DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
			this.controlContainerItem2.Name = "controlContainerItem2";
			this.labItem.Name = "labItem";
			this.labItem.Text = "items";
			this.btn_pageup.ItemAlignment = global::DevComponents.DotNetBar.eItemAlignment.Far;
			this.btn_pageup.Name = "btn_pageup";
			this.btn_pageup.Text = "<<";
			this.btn_pageup.Tooltip = "上一页";
			this.btn_pageup.Click += new global::System.EventHandler(this.btn_pageup_Click);
			this.controlContainerItem5.AllowItemResize = false;
			this.controlContainerItem5.Control = this.txtNowPage;
			this.controlContainerItem5.MenuVisibility = global::DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
			this.controlContainerItem5.Name = "controlContainerItem5";
			this.labelItem1.ItemAlignment = global::DevComponents.DotNetBar.eItemAlignment.Far;
			this.labelItem1.Name = "labelItem1";
			this.labelItem1.Text = "/";
			this.labPageCounts.ItemAlignment = global::DevComponents.DotNetBar.eItemAlignment.Far;
			this.labPageCounts.Name = "labPageCounts";
			this.labPageCounts.Text = "PageCount";
			this.btn_pagedown.ItemAlignment = global::DevComponents.DotNetBar.eItemAlignment.Far;
			this.btn_pagedown.Name = "btn_pagedown";
			this.btn_pagedown.Text = ">>";
			this.btn_pagedown.Tooltip = "下一页";
			this.btn_pagedown.Click += new global::System.EventHandler(this.btn_pagedown_Click);
			this.controlContainerItem4.AllowItemResize = false;
			this.controlContainerItem4.MenuVisibility = global::DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
			this.controlContainerItem4.Name = "controlContainerItem4";
			this.controlContainerItem3.AllowItemResize = false;
			this.controlContainerItem3.MenuVisibility = global::DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
			this.controlContainerItem3.Name = "controlContainerItem3";
			this.controlContainerItem6.AllowItemResize = false;
			this.controlContainerItem6.MenuVisibility = global::DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
			this.controlContainerItem6.Name = "controlContainerItem6";
			this.comboItem1.Text = "30";
			this.comboItem2.Text = "50";
			this.comboItem3.Text = "100";
			this.comboItem4.Text = "30";
			this.comboItem5.Text = "50";
			this.comboItem6.Text = "100";
			this.comboItem7.Text = "30";
			this.comboItem8.Text = "50";
			this.comboItem9.Text = "100";
			base.ClientSize = new global::System.Drawing.Size(1316, 644);
			base.Controls.Add(this.bar1);
			base.Controls.Add(this.dgvData);
			base.Controls.Add(this.bar);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "frmTruck";
			this.Text = "Truck";
			base.Load += new global::System.EventHandler(this.frmTruck_Load);
			((global::System.ComponentModel.ISupportInitialize)this.dgvData).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.bar).EndInit();
			this.bar.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.bar1).EndInit();
			this.bar1.ResumeLayout(false);
			this.bar1.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x04000DA3 RID: 3491
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000DA4 RID: 3492
		private global::DevComponents.DotNetBar.Bar bar;

		// Token: 0x04000DA5 RID: 3493
		private global::DevComponents.DotNetBar.ButtonItem btnAdd;

		// Token: 0x04000DA6 RID: 3494
		private global::DevComponents.DotNetBar.ButtonItem btnModify;

		// Token: 0x04000DA7 RID: 3495
		private global::DevComponents.DotNetBar.ButtonItem btnDelete;

		// Token: 0x04000DA8 RID: 3496
		private global::DevComponents.DotNetBar.Controls.DataGridViewX dgvData;

		// Token: 0x04000DA9 RID: 3497
		private global::DevComponents.DotNetBar.LabelItem labNo;

		// Token: 0x04000DAA RID: 3498
		private global::DevComponents.DotNetBar.TextBoxItem txtName;

		// Token: 0x04000DAB RID: 3499
		private global::DevComponents.DotNetBar.ButtonItem btnSearch;

		// Token: 0x04000DAC RID: 3500
		private global::DevComponents.DotNetBar.Controls.Line line2;

		// Token: 0x04000DAD RID: 3501
		private global::DevComponents.DotNetBar.ControlContainerItem controlContainerItem1;

		// Token: 0x04000DAE RID: 3502
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_Id;

		// Token: 0x04000DAF RID: 3503
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_Lisence;

		// Token: 0x04000DB0 RID: 3504
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_Driver;

		// Token: 0x04000DB1 RID: 3505
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_Supercargo;

		// Token: 0x04000DB2 RID: 3506
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_CoachNum;

		// Token: 0x04000DB3 RID: 3507
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_CoachType;

		// Token: 0x04000DB4 RID: 3508
		private global::DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn C_Vol;

		// Token: 0x04000DB5 RID: 3509
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_Factor;

		// Token: 0x04000DB6 RID: 3510
		private global::DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn C_NetWeight;

		// Token: 0x04000DB7 RID: 3511
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_CangShu;

		// Token: 0x04000DB8 RID: 3512
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_ValidDate;

		// Token: 0x04000DB9 RID: 3513
		private global::DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn C_Weight;

		// Token: 0x04000DBA RID: 3514
		private global::DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn C_LoadWeight;

		// Token: 0x04000DBB RID: 3515
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_SubUnit;

		// Token: 0x04000DBC RID: 3516
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_Remark;

		// Token: 0x04000DBD RID: 3517
		private global::System.Windows.Forms.TextBox txtNowPage;

		// Token: 0x04000DBE RID: 3518
		private global::System.Windows.Forms.ComboBox cmbPage;

		// Token: 0x04000DBF RID: 3519
		private global::DevComponents.DotNetBar.Bar bar1;

		// Token: 0x04000DC0 RID: 3520
		private global::DevComponents.DotNetBar.ControlContainerItem controlContainerItem6;

		// Token: 0x04000DC1 RID: 3521
		private global::DevComponents.DotNetBar.ControlContainerItem controlContainerItem4;

		// Token: 0x04000DC2 RID: 3522
		private global::DevComponents.DotNetBar.ControlContainerItem controlContainerItem3;

		// Token: 0x04000DC3 RID: 3523
		private global::DevComponents.DotNetBar.ButtonItem btn_pagedown;

		// Token: 0x04000DC4 RID: 3524
		private global::DevComponents.DotNetBar.ButtonItem btn_pageup;

		// Token: 0x04000DC5 RID: 3525
		private global::DevComponents.Editors.ComboItem comboItem1;

		// Token: 0x04000DC6 RID: 3526
		private global::DevComponents.Editors.ComboItem comboItem2;

		// Token: 0x04000DC7 RID: 3527
		private global::DevComponents.Editors.ComboItem comboItem3;

		// Token: 0x04000DC8 RID: 3528
		private global::DevComponents.DotNetBar.ControlContainerItem controlContainerItem2;

		// Token: 0x04000DC9 RID: 3529
		private global::DevComponents.DotNetBar.LabelItem labPageCounts;

		// Token: 0x04000DCA RID: 3530
		private global::DevComponents.Editors.ComboItem comboItem4;

		// Token: 0x04000DCB RID: 3531
		private global::DevComponents.Editors.ComboItem comboItem5;

		// Token: 0x04000DCC RID: 3532
		private global::DevComponents.Editors.ComboItem comboItem6;

		// Token: 0x04000DCD RID: 3533
		private global::DevComponents.Editors.ComboItem comboItem7;

		// Token: 0x04000DCE RID: 3534
		private global::DevComponents.Editors.ComboItem comboItem8;

		// Token: 0x04000DCF RID: 3535
		private global::DevComponents.Editors.ComboItem comboItem9;

		// Token: 0x04000DD0 RID: 3536
		private global::DevComponents.DotNetBar.LabelItem labPage;

		// Token: 0x04000DD1 RID: 3537
		private global::DevComponents.DotNetBar.LabelItem labItem;

		// Token: 0x04000DD2 RID: 3538
		private global::DevComponents.DotNetBar.LabelItem labelItem1;

		// Token: 0x04000DD3 RID: 3539
		private global::DevComponents.DotNetBar.ControlContainerItem controlContainerItem5;

		// Token: 0x04000DD4 RID: 3540
		private global::DevComponents.DotNetBar.ButtonItem btnSpecialStepClass;
	}
}
