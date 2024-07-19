namespace SQSClient
{
	// Token: 0x02000070 RID: 112
	public partial class frmTicket : global::SQSClient.BaseDialogForm
	{
		// Token: 0x0600061D RID: 1565 RVA: 0x0009594C File Offset: 0x00093B4C
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600061E RID: 1566 RVA: 0x00095984 File Offset: 0x00093B84
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new global::System.Windows.Forms.DataGridViewCellStyle();
			this.dgvData = new global::DevComponents.DotNetBar.Controls.DataGridViewX();
			this.C_Id = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_DanHao = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_IC = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_ContractID = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_BusinessType = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_Clientpart = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_Settlepart = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_CheNum = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_CangNum = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_Unit = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_Tank = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_InvCode = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_Product = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_JiHuaLiang = new global::DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn();
			this.C_ShiJiLiang = new global::DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn();
			this.C_FirstWeight = new global::DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn();
			this.C_SecondWeight = new global::DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn();
			this.C_DifferWeight = new global::DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn();
			this.C_FWDiffer = new global::DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn();
			this.C_JieSuanLiang = new global::DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn();
			this.C_DanWei = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_OrderStatus = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_CheckoutStatus = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_PaymentType = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_StepProcessName = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_ZhiDanRen = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_ZhiDanTime = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_StartTime = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_EndTime = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_JieSuanTime = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_JieSuanRen = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.contextMenuStrip = new global::System.Windows.Forms.ContextMenuStrip(this.components);
			this.toolReceiptCapture = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolCheckRequest = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolCuttingWeight = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolProcessBack = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolprocessSkip = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolOutDoorHand = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolPrintQuality = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolPhotoAround = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolWeightDetails = new global::System.Windows.Forms.ToolStripMenuItem();
			this.viewTicketProcessToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.pnlConfig = new global::DevComponents.DotNetBar.Controls.GroupPanel();
			this.panelExProcess = new global::DevComponents.DotNetBar.PanelEx();
			this.labMessage = new global::DevComponents.DotNetBar.LabelX();
			this.layoutControl1 = new global::DevComponents.DotNetBar.Layout.LayoutControl();
			this.dtpDate = new global::DevComponents.Editors.DateTimeAdv.DateTimeInput();
			this.cmbModifyStatus = new global::DevComponents.DotNetBar.Controls.ComboBoxEx();
			this.txtCardNum = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.btnCard = new global::DevComponents.DotNetBar.ButtonX();
			this.cmbUnit = new global::Base.AutoComboBox();
			this.cmbProduct = new global::Base.AutoComboBox();
			this.txtGuanNum = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.btnQuery = new global::DevComponents.DotNetBar.ButtonX();
			this.chkIsUseDate = new global::DevComponents.DotNetBar.Controls.CheckBoxX();
			this.cmbBusinessType = new global::DevComponents.DotNetBar.Controls.ComboBoxEx();
			this.cmbWareHouse = new global::Base.AutoComboBox();
			this.tbxDanHao = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.cmbStep = new global::Base.AutoComboBox();
			this.layoutControlItem1 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem9 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem2 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem13 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem10 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem3 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem4 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem6 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem12 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem7 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem5 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem11 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem8 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.panelEx1 = new global::DevComponents.DotNetBar.PanelEx();
			this.lblAdvancedQuery = new global::DevComponents.DotNetBar.LabelX();
			this.labCount = new global::DevComponents.DotNetBar.LabelX();
			this.bar = new global::DevComponents.DotNetBar.Bar();
			this.btnAdd = new global::DevComponents.DotNetBar.ButtonItem();
			this.btnModify = new global::DevComponents.DotNetBar.ButtonItem();
			this.btnDelete = new global::DevComponents.DotNetBar.ButtonItem();
			this.btnExport = new global::DevComponents.DotNetBar.ButtonItem();
			this.btnPrint = new global::DevComponents.DotNetBar.ButtonItem();
			this.btnSettle = new global::DevComponents.DotNetBar.ButtonItem();
			this.btnNoSettle = new global::DevComponents.DotNetBar.ButtonItem();
			this.btnAdvancedQuery = new global::DevComponents.DotNetBar.ButtonItem();
			this.btnAdjust = new global::DevComponents.DotNetBar.ButtonItem();
			this.btnAddFast = new global::DevComponents.DotNetBar.ButtonItem();
			this.btnItemC = new global::DevComponents.DotNetBar.ButtonItem();
			this.btnSearchVehicle = new global::DevComponents.DotNetBar.ButtonItem();
			((global::System.ComponentModel.ISupportInitialize)this.dgvData).BeginInit();
			this.contextMenuStrip.SuspendLayout();
			this.pnlConfig.SuspendLayout();
			this.layoutControl1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dtpDate).BeginInit();
			this.panelEx1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.bar).BeginInit();
			base.SuspendLayout();
			this.dgvData.AllowUserToAddRows = false;
			this.dgvData.AllowUserToDeleteRows = false;
			this.dgvData.AllowUserToResizeRows = false;
			this.dgvData.AutoSizeColumnsMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dgvData.AutoSizeRowsMode = global::System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			dataGridViewCellStyle.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle.BackColor = global::System.Drawing.SystemColors.Control;
			dataGridViewCellStyle.Font = new global::System.Drawing.Font("宋体", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 134);
			dataGridViewCellStyle.ForeColor = global::System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle.SelectionBackColor = global::System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle.SelectionForeColor = global::System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle.WrapMode = global::System.Windows.Forms.DataGridViewTriState.True;
			this.dgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
			this.dgvData.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dgvData.Columns.AddRange(new global::System.Windows.Forms.DataGridViewColumn[]
			{
				this.C_Id,
				this.C_DanHao,
				this.C_IC,
				this.C_ContractID,
				this.C_BusinessType,
				this.C_Clientpart,
				this.C_Settlepart,
				this.C_CheNum,
				this.C_CangNum,
				this.C_Unit,
				this.C_Tank,
				this.C_InvCode,
				this.C_Product,
				this.C_JiHuaLiang,
				this.C_ShiJiLiang,
				this.C_FirstWeight,
				this.C_SecondWeight,
				this.C_DifferWeight,
				this.C_FWDiffer,
				this.C_JieSuanLiang,
				this.C_DanWei,
				this.C_OrderStatus,
				this.C_CheckoutStatus,
				this.C_PaymentType,
				this.C_StepProcessName,
				this.C_ZhiDanRen,
				this.C_ZhiDanTime,
				this.C_StartTime,
				this.C_EndTime,
				this.C_JieSuanTime,
				this.C_JieSuanRen
			});
			this.dgvData.ContextMenuStrip = this.contextMenuStrip;
			dataGridViewCellStyle2.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = global::System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new global::System.Drawing.Font("宋体", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 134);
			dataGridViewCellStyle2.ForeColor = global::System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = global::System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = global::System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.WrapMode = global::System.Windows.Forms.DataGridViewTriState.False;
			this.dgvData.DefaultCellStyle = dataGridViewCellStyle2;
			this.dgvData.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.dgvData.EnableHeadersVisualStyles = false;
			this.dgvData.GridColor = global::System.Drawing.Color.FromArgb(208, 215, 229);
			this.dgvData.Location = new global::System.Drawing.Point(0, 97);
			this.dgvData.MultiSelect = false;
			this.dgvData.Name = "dgvData";
			this.dgvData.ReadOnly = true;
			this.dgvData.RowHeadersVisible = false;
			this.dgvData.RowTemplate.Height = 23;
			this.dgvData.SelectionMode = global::System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvData.Size = new global::System.Drawing.Size(1837, 479);
			this.dgvData.TabIndex = 16;
			this.dgvData.CellClick += new global::System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTiDan_CellClick);
			this.dgvData.CellDoubleClick += new global::System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTiDan_CellDoubleClick);
			this.dgvData.CellMouseDown += new global::System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvData_CellMouseDown);
			this.dgvData.SelectionChanged += new global::System.EventHandler(this.dgvTiDan_SelectionChanged);
			this.C_Id.DataPropertyName = "Id";
			this.C_Id.FillWeight = 82.8988f;
			this.C_Id.HeaderText = "ID";
			this.C_Id.Name = "C_Id";
			this.C_Id.ReadOnly = true;
			this.C_Id.Visible = false;
			this.C_Id.Width = 42;
			this.C_DanHao.DataPropertyName = "DanHao";
			this.C_DanHao.FillWeight = 82.8988f;
			this.C_DanHao.HeaderText = "DanHao";
			this.C_DanHao.Name = "C_DanHao";
			this.C_DanHao.ReadOnly = true;
			this.C_DanHao.Width = 66;
			this.C_IC.DataPropertyName = "CardNum";
			this.C_IC.FillWeight = 82.8988f;
			this.C_IC.HeaderText = "IC";
			this.C_IC.Name = "C_IC";
			this.C_IC.ReadOnly = true;
			this.C_IC.Width = 42;
			this.C_ContractID.DataPropertyName = "ContractNum";
			this.C_ContractID.HeaderText = "ContractID";
			this.C_ContractID.Name = "C_ContractID";
			this.C_ContractID.ReadOnly = true;
			this.C_ContractID.Width = 90;
			this.C_BusinessType.DataPropertyName = "BusinessType";
			this.C_BusinessType.HeaderText = "BusinessType";
			this.C_BusinessType.Name = "C_BusinessType";
			this.C_BusinessType.ReadOnly = true;
			this.C_BusinessType.Width = 102;
			this.C_Clientpart.DataPropertyName = "Clientpart";
			this.C_Clientpart.HeaderText = "Clientpart";
			this.C_Clientpart.Name = "C_Clientpart";
			this.C_Clientpart.ReadOnly = true;
			this.C_Clientpart.Width = 90;
			this.C_Settlepart.DataPropertyName = "Settlepart";
			this.C_Settlepart.HeaderText = "Settlepart";
			this.C_Settlepart.Name = "C_Settlepart";
			this.C_Settlepart.ReadOnly = true;
			this.C_Settlepart.Width = 90;
			this.C_CheNum.DataPropertyName = "Lisence";
			this.C_CheNum.FillWeight = 82.8988f;
			this.C_CheNum.HeaderText = "CheNum";
			this.C_CheNum.Name = "C_CheNum";
			this.C_CheNum.ReadOnly = true;
			this.C_CheNum.Width = 66;
			this.C_CangNum.DataPropertyName = "CangNum";
			this.C_CangNum.HeaderText = "CangNum";
			this.C_CangNum.Name = "C_CangNum";
			this.C_CangNum.ReadOnly = true;
			this.C_CangNum.Width = 72;
			this.C_Unit.DataPropertyName = "UnitName";
			this.C_Unit.HeaderText = "Unit";
			this.C_Unit.Name = "C_Unit";
			this.C_Unit.ReadOnly = true;
			this.C_Unit.Width = 54;
			this.C_Tank.HeaderText = "Tank";
			this.C_Tank.Name = "C_Tank";
			this.C_Tank.ReadOnly = true;
			this.C_Tank.Width = 54;
			this.C_InvCode.DataPropertyName = "InvCode";
			this.C_InvCode.HeaderText = "InvCode";
			this.C_InvCode.Name = "C_InvCode";
			this.C_InvCode.ReadOnly = true;
			this.C_InvCode.Width = 72;
			this.C_Product.DataPropertyName = "ProductName";
			this.C_Product.HeaderText = "Product";
			this.C_Product.Name = "C_Product";
			this.C_Product.ReadOnly = true;
			this.C_Product.Width = 72;
			this.C_JiHuaLiang.BackgroundStyle.Class = "DataGridViewNumericBorder";
			this.C_JiHuaLiang.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.C_JiHuaLiang.DataPropertyName = "JiHuaLiang";
			this.C_JiHuaLiang.FillWeight = 82.8988f;
			this.C_JiHuaLiang.HeaderText = "JiHuaLiang";
			this.C_JiHuaLiang.Increment = 0.0;
			this.C_JiHuaLiang.InputHorizontalAlignment = global::DevComponents.Editors.eHorizontalAlignment.Left;
			this.C_JiHuaLiang.Name = "C_JiHuaLiang";
			this.C_JiHuaLiang.ReadOnly = true;
			this.C_JiHuaLiang.Resizable = global::System.Windows.Forms.DataGridViewTriState.True;
			this.C_JiHuaLiang.Width = 90;
			this.C_ShiJiLiang.BackgroundStyle.Class = "DataGridViewNumericBorder";
			this.C_ShiJiLiang.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.C_ShiJiLiang.DataPropertyName = "ShiJiLiang";
			this.C_ShiJiLiang.FillWeight = 82.8988f;
			this.C_ShiJiLiang.HeaderText = "ShiJiLiang";
			this.C_ShiJiLiang.Increment = 1.0;
			this.C_ShiJiLiang.InputHorizontalAlignment = global::DevComponents.Editors.eHorizontalAlignment.Left;
			this.C_ShiJiLiang.Name = "C_ShiJiLiang";
			this.C_ShiJiLiang.ReadOnly = true;
			this.C_ShiJiLiang.Resizable = global::System.Windows.Forms.DataGridViewTriState.True;
			this.C_ShiJiLiang.Width = 90;
			this.C_FirstWeight.BackgroundStyle.Class = "DataGridViewNumericBorder";
			this.C_FirstWeight.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.C_FirstWeight.DataPropertyName = "FirstWeight";
			this.C_FirstWeight.HeaderText = "FirstWeight(kg)";
			this.C_FirstWeight.Increment = 1.0;
			this.C_FirstWeight.Name = "C_FirstWeight";
			this.C_FirstWeight.ReadOnly = true;
			this.C_FirstWeight.Width = 120;
			this.C_SecondWeight.BackgroundStyle.Class = "DataGridViewNumericBorder";
			this.C_SecondWeight.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.C_SecondWeight.DataPropertyName = "SecondWeight";
			this.C_SecondWeight.HeaderText = "SecondWeight(kg)";
			this.C_SecondWeight.Increment = 1.0;
			this.C_SecondWeight.Name = "C_SecondWeight";
			this.C_SecondWeight.ReadOnly = true;
			this.C_SecondWeight.Width = 126;
			this.C_DifferWeight.BackgroundStyle.Class = "DataGridViewNumericBorder";
			this.C_DifferWeight.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.C_DifferWeight.DataPropertyName = "DifferWeight";
			this.C_DifferWeight.HeaderText = "DifferWeight(kg)";
			this.C_DifferWeight.Increment = 1.0;
			this.C_DifferWeight.InputHorizontalAlignment = global::DevComponents.Editors.eHorizontalAlignment.Left;
			this.C_DifferWeight.Name = "C_DifferWeight";
			this.C_DifferWeight.ReadOnly = true;
			this.C_DifferWeight.Resizable = global::System.Windows.Forms.DataGridViewTriState.True;
			this.C_DifferWeight.Width = 126;
			this.C_FWDiffer.BackgroundStyle.Class = "DataGridViewNumericBorder";
			this.C_FWDiffer.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.C_FWDiffer.DataPropertyName = "FWDiffer";
			this.C_FWDiffer.HeaderText = "FWDiffer";
			this.C_FWDiffer.Increment = 1.0;
			this.C_FWDiffer.Name = "C_FWDiffer";
			this.C_FWDiffer.ReadOnly = true;
			this.C_FWDiffer.Width = 78;
			this.C_JieSuanLiang.BackgroundStyle.Class = "DataGridViewNumericBorder";
			this.C_JieSuanLiang.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.C_JieSuanLiang.DataPropertyName = "JieSuanLiang";
			dataGridViewCellStyle3.BackColor = global::System.Drawing.Color.FromArgb(192, 192, 255);
			dataGridViewCellStyle3.NullValue = null;
			this.C_JieSuanLiang.DefaultCellStyle = dataGridViewCellStyle3;
			this.C_JieSuanLiang.HeaderText = "JieSuanLiang";
			this.C_JieSuanLiang.Increment = 1.0;
			this.C_JieSuanLiang.Name = "C_JieSuanLiang";
			this.C_JieSuanLiang.ReadOnly = true;
			this.C_JieSuanLiang.Width = 102;
			this.C_DanWei.DataPropertyName = "DanWei";
			this.C_DanWei.HeaderText = "DanWei";
			this.C_DanWei.Name = "C_DanWei";
			this.C_DanWei.ReadOnly = true;
			this.C_DanWei.Width = 66;
			this.C_OrderStatus.DataPropertyName = "Status";
			dataGridViewCellStyle4.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.C_OrderStatus.DefaultCellStyle = dataGridViewCellStyle4;
			this.C_OrderStatus.FillWeight = 82.8988f;
			this.C_OrderStatus.HeaderText = "OrderStatus";
			this.C_OrderStatus.Name = "C_OrderStatus";
			this.C_OrderStatus.ReadOnly = true;
			this.C_OrderStatus.Width = 96;
			this.C_CheckoutStatus.DataPropertyName = "State";
			this.C_CheckoutStatus.FillWeight = 85.48f;
			this.C_CheckoutStatus.HeaderText = "CheckoutStatus";
			this.C_CheckoutStatus.Name = "C_CheckoutStatus";
			this.C_CheckoutStatus.ReadOnly = true;
			this.C_CheckoutStatus.Width = 114;
			this.C_PaymentType.DataPropertyName = "AccountType";
			this.C_PaymentType.HeaderText = "PaymentType";
			this.C_PaymentType.Name = "C_PaymentType";
			this.C_PaymentType.ReadOnly = true;
			this.C_PaymentType.Width = 96;
			this.C_StepProcessName.HeaderText = "StepProcessName";
			this.C_StepProcessName.Name = "C_StepProcessName";
			this.C_StepProcessName.ReadOnly = true;
			this.C_StepProcessName.Width = 120;
			this.C_ZhiDanRen.DataPropertyName = "ZhiDanRen";
			this.C_ZhiDanRen.HeaderText = "ZhiDanRen";
			this.C_ZhiDanRen.Name = "C_ZhiDanRen";
			this.C_ZhiDanRen.ReadOnly = true;
			this.C_ZhiDanRen.Width = 84;
			this.C_ZhiDanTime.DataPropertyName = "ZhiDanTime";
			this.C_ZhiDanTime.FillWeight = 140.0862f;
			this.C_ZhiDanTime.HeaderText = "ZhiDanTime";
			this.C_ZhiDanTime.Name = "C_ZhiDanTime";
			this.C_ZhiDanTime.ReadOnly = true;
			this.C_ZhiDanTime.Width = 90;
			this.C_StartTime.DataPropertyName = "StartTime";
			this.C_StartTime.HeaderText = "StartTime";
			this.C_StartTime.Name = "C_StartTime";
			this.C_StartTime.ReadOnly = true;
			this.C_StartTime.Width = 84;
			this.C_EndTime.DataPropertyName = "EndTime";
			this.C_EndTime.HeaderText = "EndTime";
			this.C_EndTime.Name = "C_EndTime";
			this.C_EndTime.ReadOnly = true;
			this.C_EndTime.Width = 72;
			this.C_JieSuanTime.DataPropertyName = "JieSuanTime";
			this.C_JieSuanTime.FillWeight = 148.8069f;
			this.C_JieSuanTime.HeaderText = "JieSuanTime";
			this.C_JieSuanTime.Name = "C_JieSuanTime";
			this.C_JieSuanTime.ReadOnly = true;
			this.C_JieSuanTime.Width = 96;
			this.C_JieSuanRen.DataPropertyName = "JieSuanRen";
			this.C_JieSuanRen.FillWeight = 82.53025f;
			this.C_JieSuanRen.HeaderText = "JieSuanRen";
			this.C_JieSuanRen.Name = "C_JieSuanRen";
			this.C_JieSuanRen.ReadOnly = true;
			this.C_JieSuanRen.Width = 90;
			this.contextMenuStrip.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.toolReceiptCapture,
				this.toolCheckRequest,
				this.toolCuttingWeight,
				this.toolProcessBack,
				this.toolprocessSkip,
				this.toolOutDoorHand,
				this.toolPrintQuality,
				this.toolPhotoAround,
				this.toolWeightDetails,
				this.viewTicketProcessToolStripMenuItem
			});
			this.contextMenuStrip.Name = "contextMenuStrip1";
			this.contextMenuStrip.Size = new global::System.Drawing.Size(183, 224);
			this.toolReceiptCapture.Name = "toolReceiptCapture";
			this.toolReceiptCapture.Size = new global::System.Drawing.Size(182, 22);
			this.toolReceiptCapture.Text = "ReceiptCapture";
			this.toolReceiptCapture.Click += new global::System.EventHandler(this.toolReceiptCapture_Click);
			this.toolCheckRequest.Name = "toolCheckRequest";
			this.toolCheckRequest.Size = new global::System.Drawing.Size(182, 22);
			this.toolCheckRequest.Text = "CheckRequest";
			this.toolCheckRequest.Click += new global::System.EventHandler(this.toolCheckRequest_Click);
			this.toolCuttingWeight.Name = "toolCuttingWeight";
			this.toolCuttingWeight.Size = new global::System.Drawing.Size(182, 22);
			this.toolCuttingWeight.Text = "CuttingWeight";
			this.toolCuttingWeight.Click += new global::System.EventHandler(this.toolCuttingWeight_Click);
			this.toolProcessBack.Name = "toolProcessBack";
			this.toolProcessBack.Size = new global::System.Drawing.Size(182, 22);
			this.toolProcessBack.Text = "ProcessBack";
			this.toolProcessBack.Click += new global::System.EventHandler(this.toolProcessBack_Click);
			this.toolprocessSkip.Name = "toolprocessSkip";
			this.toolprocessSkip.Size = new global::System.Drawing.Size(182, 22);
			this.toolprocessSkip.Text = "ProcessSkip";
			this.toolprocessSkip.Visible = false;
			this.toolprocessSkip.Click += new global::System.EventHandler(this.toolprocessSkip_Click);
			this.toolOutDoorHand.Name = "toolOutDoorHand";
			this.toolOutDoorHand.Size = new global::System.Drawing.Size(182, 22);
			this.toolOutDoorHand.Text = "OutDoorHand";
			this.toolOutDoorHand.Click += new global::System.EventHandler(this.toolOutDoorHand_Click);
			this.toolPrintQuality.Name = "toolPrintQuality";
			this.toolPrintQuality.Size = new global::System.Drawing.Size(182, 22);
			this.toolPrintQuality.Text = "PrintQuality";
			this.toolPrintQuality.Click += new global::System.EventHandler(this.toolPrintQuality_Click);
			this.toolPhotoAround.Name = "toolPhotoAround";
			this.toolPhotoAround.Size = new global::System.Drawing.Size(182, 22);
			this.toolPhotoAround.Text = "PhotoAround";
			this.toolPhotoAround.Click += new global::System.EventHandler(this.toolPhotoAround_Click);
			this.toolWeightDetails.Name = "toolWeightDetails";
			this.toolWeightDetails.Size = new global::System.Drawing.Size(182, 22);
			this.toolWeightDetails.Text = "WeightDetails";
			this.toolWeightDetails.Click += new global::System.EventHandler(this.toolWeightDetails_Click);
			this.viewTicketProcessToolStripMenuItem.Name = "viewTicketProcessToolStripMenuItem";
			this.viewTicketProcessToolStripMenuItem.Size = new global::System.Drawing.Size(182, 22);
			this.viewTicketProcessToolStripMenuItem.Text = "ViewTicketProcess";
			this.viewTicketProcessToolStripMenuItem.Click += new global::System.EventHandler(this.ViewTicketProcessToolStripMenuItem_Click);
			this.pnlConfig.CanvasColor = global::System.Drawing.SystemColors.Control;
			this.pnlConfig.ColorSchemeStyle = global::DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
			this.pnlConfig.Controls.Add(this.panelExProcess);
			this.pnlConfig.Controls.Add(this.labMessage);
			this.pnlConfig.Controls.Add(this.layoutControl1);
			this.pnlConfig.Controls.Add(this.panelEx1);
			this.pnlConfig.DisabledBackColor = global::System.Drawing.Color.Empty;
			this.pnlConfig.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.pnlConfig.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.pnlConfig.Location = new global::System.Drawing.Point(0, 27);
			this.pnlConfig.Name = "pnlConfig";
			this.pnlConfig.Size = new global::System.Drawing.Size(1837, 70);
			this.pnlConfig.Style.BackColor2SchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
			this.pnlConfig.Style.BackColorGradientAngle = 90;
			this.pnlConfig.Style.BackColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
			this.pnlConfig.Style.BorderBottom = global::DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.pnlConfig.Style.BorderBottomWidth = 1;
			this.pnlConfig.Style.BorderColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
			this.pnlConfig.Style.BorderLeft = global::DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.pnlConfig.Style.BorderLeftWidth = 1;
			this.pnlConfig.Style.BorderRight = global::DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.pnlConfig.Style.BorderRightWidth = 1;
			this.pnlConfig.Style.BorderTop = global::DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.pnlConfig.Style.BorderTopWidth = 1;
			this.pnlConfig.Style.CornerDiameter = 4;
			this.pnlConfig.Style.CornerType = global::DevComponents.DotNetBar.eCornerType.Rounded;
			this.pnlConfig.Style.TextAlignment = global::DevComponents.DotNetBar.eStyleTextAlignment.Center;
			this.pnlConfig.Style.TextColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelText;
			this.pnlConfig.Style.TextLineAlignment = global::DevComponents.DotNetBar.eStyleTextAlignment.Near;
			this.pnlConfig.StyleMouseDown.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.pnlConfig.StyleMouseOver.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.pnlConfig.TabIndex = 5;
			this.panelExProcess.CanvasColor = global::System.Drawing.SystemColors.Control;
			this.panelExProcess.ColorSchemeStyle = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.panelExProcess.DisabledBackColor = global::System.Drawing.Color.Empty;
			this.panelExProcess.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.panelExProcess.Location = new global::System.Drawing.Point(1629, 0);
			this.panelExProcess.Name = "panelExProcess";
			this.panelExProcess.Size = new global::System.Drawing.Size(101, 64);
			this.panelExProcess.Style.Alignment = global::System.Drawing.StringAlignment.Center;
			this.panelExProcess.Style.BackColor1.ColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
			this.panelExProcess.Style.BackColor2.ColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
			this.panelExProcess.Style.BorderColor.ColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
			this.panelExProcess.Style.ForeColor.ColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelText;
			this.panelExProcess.Style.GradientAngle = 90;
			this.panelExProcess.TabIndex = 58;
			this.panelExProcess.DoubleClick += new global::System.EventHandler(this.panelExProcess_DoubleClick);
			this.labMessage.BackColor = global::System.Drawing.Color.Transparent;
			this.labMessage.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.labMessage.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.labMessage.Font = new global::System.Drawing.Font("宋体", 14f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 134);
			this.labMessage.ForeColor = global::System.Drawing.Color.Red;
			this.labMessage.Location = new global::System.Drawing.Point(1190, 0);
			this.labMessage.Name = "labMessage";
			this.labMessage.Size = new global::System.Drawing.Size(540, 64);
			this.labMessage.TabIndex = 51;
			this.labMessage.TextAlignment = global::System.Drawing.StringAlignment.Center;
			this.labMessage.WordWrap = true;
			this.layoutControl1.BackColor = global::System.Drawing.Color.Transparent;
			this.layoutControl1.Controls.Add(this.dtpDate);
			this.layoutControl1.Controls.Add(this.cmbModifyStatus);
			this.layoutControl1.Controls.Add(this.txtCardNum);
			this.layoutControl1.Controls.Add(this.btnCard);
			this.layoutControl1.Controls.Add(this.cmbUnit);
			this.layoutControl1.Controls.Add(this.cmbProduct);
			this.layoutControl1.Controls.Add(this.txtGuanNum);
			this.layoutControl1.Controls.Add(this.btnQuery);
			this.layoutControl1.Controls.Add(this.chkIsUseDate);
			this.layoutControl1.Controls.Add(this.cmbBusinessType);
			this.layoutControl1.Controls.Add(this.cmbWareHouse);
			this.layoutControl1.Controls.Add(this.tbxDanHao);
			this.layoutControl1.Controls.Add(this.cmbStep);
			this.layoutControl1.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.layoutControl1.Location = new global::System.Drawing.Point(0, 0);
			this.layoutControl1.Name = "layoutControl1";
			this.layoutControl1.RootGroup.Items.AddRange(new global::DevComponents.DotNetBar.Layout.LayoutItemBase[]
			{
				this.layoutControlItem1,
				this.layoutControlItem9,
				this.layoutControlItem2,
				this.layoutControlItem13,
				this.layoutControlItem10,
				this.layoutControlItem3,
				this.layoutControlItem4,
				this.layoutControlItem6,
				this.layoutControlItem12,
				this.layoutControlItem7,
				this.layoutControlItem5,
				this.layoutControlItem11,
				this.layoutControlItem8
			});
			this.layoutControl1.Size = new global::System.Drawing.Size(1190, 64);
			this.layoutControl1.TabIndex = 47;
			this.dtpDate.BackgroundStyle.Class = "DateTimeInputBackground";
			this.dtpDate.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.dtpDate.ButtonDropDown.Shortcut = global::DevComponents.DotNetBar.eShortcut.AltDown;
			this.dtpDate.ButtonDropDown.Visible = true;
			this.dtpDate.CustomFormat = "yyyy-MM-dd";
			this.dtpDate.Format = global::DevComponents.Editors.eDateTimePickerFormat.Custom;
			this.dtpDate.IsPopupCalendarOpen = false;
			this.dtpDate.Location = new global::System.Drawing.Point(67, 4);
			this.dtpDate.Margin = new global::System.Windows.Forms.Padding(0);
			this.dtpDate.MonthCalendar.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.dtpDate.MonthCalendar.CalendarDimensions = new global::System.Drawing.Size(1, 1);
			this.dtpDate.MonthCalendar.ClearButtonVisible = true;
			this.dtpDate.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = global::DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
			this.dtpDate.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
			this.dtpDate.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.BarBackground;
			this.dtpDate.MonthCalendar.CommandsBackgroundStyle.BorderTop = global::DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.dtpDate.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
			this.dtpDate.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
			this.dtpDate.MonthCalendar.CommandsBackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.dtpDate.MonthCalendar.DisplayMonth = new global::System.DateTime(2016, 6, 1, 0, 0, 0, 0);
			this.dtpDate.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
			this.dtpDate.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
			this.dtpDate.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
			this.dtpDate.MonthCalendar.NavigationBackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.dtpDate.MonthCalendar.TodayButtonVisible = true;
			this.dtpDate.Name = "dtpDate";
			this.dtpDate.Size = new global::System.Drawing.Size(143, 21);
			this.dtpDate.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.dtpDate.TabIndex = 0;
			this.cmbModifyStatus.DisplayMember = "Text";
			this.cmbModifyStatus.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cmbModifyStatus.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbModifyStatus.FormattingEnabled = true;
			this.cmbModifyStatus.ItemHeight = 15;
			this.cmbModifyStatus.Location = new global::System.Drawing.Point(352, 4);
			this.cmbModifyStatus.Margin = new global::System.Windows.Forms.Padding(0);
			this.cmbModifyStatus.Name = "cmbModifyStatus";
			this.cmbModifyStatus.Size = new global::System.Drawing.Size(119, 21);
			this.cmbModifyStatus.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.cmbModifyStatus.TabIndex = 2;
			this.txtCardNum.BackColor = global::System.Drawing.Color.White;
			this.txtCardNum.Border.Class = "TextBoxBorder";
			this.txtCardNum.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtCardNum.DisabledBackColor = global::System.Drawing.Color.White;
			this.txtCardNum.ForeColor = global::System.Drawing.Color.Black;
			this.txtCardNum.Location = new global::System.Drawing.Point(922, 4);
			this.txtCardNum.Margin = new global::System.Windows.Forms.Padding(0);
			this.txtCardNum.Name = "txtCardNum";
			this.txtCardNum.PreventEnterBeep = true;
			this.txtCardNum.Size = new global::System.Drawing.Size(143, 21);
			this.txtCardNum.TabIndex = 5;
			this.btnCard.AccessibleRole = global::System.Windows.Forms.AccessibleRole.PushButton;
			this.btnCard.ColorTable = global::DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.btnCard.Location = new global::System.Drawing.Point(1073, 4);
			this.btnCard.Margin = new global::System.Windows.Forms.Padding(0);
			this.btnCard.Name = "btnCard";
			this.btnCard.Size = new global::System.Drawing.Size(113, 23);
			this.btnCard.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.btnCard.TabIndex = 6;
			this.btnCard.Text = "ReadCard";
			this.btnCard.Click += new global::System.EventHandler(this.btnCard_Click);
			this.cmbUnit.DataSource = null;
			this.cmbUnit.DisplayMember = null;
			this.cmbUnit.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cmbUnit.FormattingEnabled = true;
			this.cmbUnit.ItemHeight = 16;
			this.cmbUnit.Location = new global::System.Drawing.Point(732, 35);
			this.cmbUnit.Margin = new global::System.Windows.Forms.Padding(0);
			this.cmbUnit.MaxDropDownItems = 20;
			this.cmbUnit.Name = "cmbUnit";
			this.cmbUnit.SelectMember = null;
			this.cmbUnit.Size = new global::System.Drawing.Size(119, 22);
			this.cmbUnit.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.cmbUnit.TabIndex = 10;
			this.cmbUnit.ValueMember = null;
			this.cmbProduct.DataSource = null;
			this.cmbProduct.DisplayMember = null;
			this.cmbProduct.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cmbProduct.FormattingEnabled = true;
			this.cmbProduct.ItemHeight = 17;
			this.cmbProduct.Location = new global::System.Drawing.Point(67, 35);
			this.cmbProduct.Margin = new global::System.Windows.Forms.Padding(0);
			this.cmbProduct.MaxDropDownItems = 20;
			this.cmbProduct.Name = "cmbProduct";
			this.cmbProduct.SelectMember = null;
			this.cmbProduct.Size = new global::System.Drawing.Size(143, 23);
			this.cmbProduct.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.cmbProduct.TabIndex = 7;
			this.cmbProduct.ValueMember = null;
			this.txtGuanNum.Border.Class = "TextBoxBorder";
			this.txtGuanNum.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtGuanNum.Location = new global::System.Drawing.Point(542, 35);
			this.txtGuanNum.Margin = new global::System.Windows.Forms.Padding(0);
			this.txtGuanNum.Name = "txtGuanNum";
			this.txtGuanNum.PreventEnterBeep = true;
			this.txtGuanNum.Size = new global::System.Drawing.Size(119, 21);
			this.txtGuanNum.TabIndex = 9;
			this.btnQuery.AccessibleRole = global::System.Windows.Forms.AccessibleRole.PushButton;
			this.btnQuery.ColorTable = global::DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.btnQuery.Location = new global::System.Drawing.Point(1073, 35);
			this.btnQuery.Margin = new global::System.Windows.Forms.Padding(0);
			this.btnQuery.Name = "btnQuery";
			this.btnQuery.Size = new global::System.Drawing.Size(113, 23);
			this.btnQuery.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.btnQuery.TabIndex = 12;
			this.btnQuery.Text = "Search";
			this.btnQuery.Click += new global::System.EventHandler(this.btnQuery_Click);
			this.chkIsUseDate.AutoSize = true;
			this.chkIsUseDate.BackColor = global::System.Drawing.Color.Transparent;
			this.chkIsUseDate.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.chkIsUseDate.Checked = true;
			this.chkIsUseDate.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.chkIsUseDate.CheckValue = "Y";
			this.chkIsUseDate.Location = new global::System.Drawing.Point(218, 4);
			this.chkIsUseDate.Margin = new global::System.Windows.Forms.Padding(0);
			this.chkIsUseDate.Name = "chkIsUseDate";
			this.chkIsUseDate.Size = new global::System.Drawing.Size(64, 16);
			this.chkIsUseDate.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.chkIsUseDate.TabIndex = 1;
			this.chkIsUseDate.Text = "Enable";
			this.cmbBusinessType.DisplayMember = "Text";
			this.cmbBusinessType.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cmbBusinessType.FormattingEnabled = true;
			this.cmbBusinessType.ItemHeight = 15;
			this.cmbBusinessType.Location = new global::System.Drawing.Point(732, 4);
			this.cmbBusinessType.Margin = new global::System.Windows.Forms.Padding(0);
			this.cmbBusinessType.Name = "cmbBusinessType";
			this.cmbBusinessType.Size = new global::System.Drawing.Size(119, 21);
			this.cmbBusinessType.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.cmbBusinessType.TabIndex = 4;
			this.cmbWareHouse.DataSource = null;
			this.cmbWareHouse.DisplayMember = null;
			this.cmbWareHouse.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cmbWareHouse.FormattingEnabled = true;
			this.cmbWareHouse.ItemHeight = 15;
			this.cmbWareHouse.Location = new global::System.Drawing.Point(922, 35);
			this.cmbWareHouse.Margin = new global::System.Windows.Forms.Padding(0);
			this.cmbWareHouse.MaxDropDownItems = 20;
			this.cmbWareHouse.Name = "cmbWareHouse";
			this.cmbWareHouse.SelectMember = null;
			this.cmbWareHouse.Size = new global::System.Drawing.Size(143, 21);
			this.cmbWareHouse.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.cmbWareHouse.TabIndex = 11;
			this.cmbWareHouse.ValueMember = null;
			this.tbxDanHao.Border.Class = "TextBoxBorder";
			this.tbxDanHao.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.tbxDanHao.Location = new global::System.Drawing.Point(281, 35);
			this.tbxDanHao.Margin = new global::System.Windows.Forms.Padding(0);
			this.tbxDanHao.Name = "tbxDanHao";
			this.tbxDanHao.PreventEnterBeep = true;
			this.tbxDanHao.Size = new global::System.Drawing.Size(190, 21);
			this.tbxDanHao.TabIndex = 8;
			this.cmbStep.DataSource = null;
			this.cmbStep.DisplayMember = null;
			this.cmbStep.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cmbStep.FormattingEnabled = true;
			this.cmbStep.ItemHeight = 15;
			this.cmbStep.Location = new global::System.Drawing.Point(542, 4);
			this.cmbStep.Margin = new global::System.Windows.Forms.Padding(0);
			this.cmbStep.MaxDropDownItems = 20;
			this.cmbStep.Name = "cmbStep";
			this.cmbStep.SelectMember = null;
			this.cmbStep.Size = new global::System.Drawing.Size(119, 21);
			this.cmbStep.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.cmbStep.TabIndex = 3;
			this.cmbStep.ValueMember = null;
			this.layoutControlItem1.Control = this.dtpDate;
			this.layoutControlItem1.Height = 29;
			this.layoutControlItem1.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Text = "Date";
			this.layoutControlItem1.Width = 18;
			this.layoutControlItem1.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem9.Control = this.chkIsUseDate;
			this.layoutControlItem9.Height = 26;
			this.layoutControlItem9.MinSize = new global::System.Drawing.Size(50, 18);
			this.layoutControlItem9.Name = "layoutControlItem9";
			this.layoutControlItem9.Width = 6;
			this.layoutControlItem9.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem2.Control = this.cmbModifyStatus;
			this.layoutControlItem2.Height = 29;
			this.layoutControlItem2.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem2.Name = "layoutControlItem2";
			this.layoutControlItem2.Text = "Status";
			this.layoutControlItem2.Width = 16;
			this.layoutControlItem2.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem13.Control = this.cmbStep;
			this.layoutControlItem13.Height = 29;
			this.layoutControlItem13.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem13.Name = "layoutControlItem13";
			this.layoutControlItem13.Text = "ThisStep";
			this.layoutControlItem13.Width = 16;
			this.layoutControlItem13.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem10.Control = this.cmbBusinessType;
			this.layoutControlItem10.Height = 29;
			this.layoutControlItem10.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem10.Name = "layoutControlItem10";
			this.layoutControlItem10.Text = "Type";
			this.layoutControlItem10.Width = 16;
			this.layoutControlItem10.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem3.Control = this.txtCardNum;
			this.layoutControlItem3.Height = 29;
			this.layoutControlItem3.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem3.Name = "layoutControlItem3";
			this.layoutControlItem3.Text = "IC";
			this.layoutControlItem3.Width = 18;
			this.layoutControlItem3.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem4.Control = this.btnCard;
			this.layoutControlItem4.Height = 31;
			this.layoutControlItem4.MinSize = new global::System.Drawing.Size(32, 20);
			this.layoutControlItem4.Name = "layoutControlItem4";
			this.layoutControlItem4.Width = 10;
			this.layoutControlItem4.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem6.Control = this.cmbProduct;
			this.layoutControlItem6.Height = 31;
			this.layoutControlItem6.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem6.Name = "layoutControlItem6";
			this.layoutControlItem6.Text = "Product";
			this.layoutControlItem6.Width = 18;
			this.layoutControlItem6.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem12.Control = this.tbxDanHao;
			this.layoutControlItem12.Height = 29;
			this.layoutControlItem12.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem12.Name = "layoutControlItem12";
			this.layoutControlItem12.Text = "DanHao";
			this.layoutControlItem12.Width = 22;
			this.layoutControlItem12.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem7.Control = this.txtGuanNum;
			this.layoutControlItem7.Height = 29;
			this.layoutControlItem7.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem7.Name = "layoutControlItem7";
			this.layoutControlItem7.Text = "CheNum";
			this.layoutControlItem7.Width = 16;
			this.layoutControlItem7.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem5.Control = this.cmbUnit;
			this.layoutControlItem5.Height = 29;
			this.layoutControlItem5.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem5.Name = "layoutControlItem5";
			this.layoutControlItem5.Text = "Unit";
			this.layoutControlItem5.Width = 16;
			this.layoutControlItem5.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem11.Control = this.cmbWareHouse;
			this.layoutControlItem11.Height = 29;
			this.layoutControlItem11.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem11.Name = "layoutControlItem11";
			this.layoutControlItem11.Text = "WareHouse";
			this.layoutControlItem11.Width = 18;
			this.layoutControlItem11.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem8.Control = this.btnQuery;
			this.layoutControlItem8.Height = 31;
			this.layoutControlItem8.MinSize = new global::System.Drawing.Size(32, 20);
			this.layoutControlItem8.Name = "layoutControlItem8";
			this.layoutControlItem8.Width = 10;
			this.layoutControlItem8.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.panelEx1.CanvasColor = global::System.Drawing.SystemColors.Control;
			this.panelEx1.ColorSchemeStyle = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.panelEx1.Controls.Add(this.lblAdvancedQuery);
			this.panelEx1.Controls.Add(this.labCount);
			this.panelEx1.DisabledBackColor = global::System.Drawing.Color.Empty;
			this.panelEx1.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.panelEx1.Location = new global::System.Drawing.Point(1730, 0);
			this.panelEx1.Name = "panelEx1";
			this.panelEx1.Size = new global::System.Drawing.Size(101, 64);
			this.panelEx1.Style.Alignment = global::System.Drawing.StringAlignment.Center;
			this.panelEx1.Style.BackColor1.ColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
			this.panelEx1.Style.BackColor2.ColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
			this.panelEx1.Style.BorderColor.ColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
			this.panelEx1.Style.ForeColor.ColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelText;
			this.panelEx1.Style.GradientAngle = 90;
			this.panelEx1.TabIndex = 35;
			this.lblAdvancedQuery.BackColor = global::System.Drawing.Color.Transparent;
			this.lblAdvancedQuery.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.lblAdvancedQuery.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.lblAdvancedQuery.Location = new global::System.Drawing.Point(0, 28);
			this.lblAdvancedQuery.Name = "lblAdvancedQuery";
			this.lblAdvancedQuery.Size = new global::System.Drawing.Size(101, 18);
			this.lblAdvancedQuery.TabIndex = 36;
			this.lblAdvancedQuery.Text = "AdvancedQuery";
			this.lblAdvancedQuery.TextAlignment = global::System.Drawing.StringAlignment.Center;
			this.labCount.BackColor = global::System.Drawing.Color.Transparent;
			this.labCount.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.labCount.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.labCount.Location = new global::System.Drawing.Point(0, 46);
			this.labCount.Name = "labCount";
			this.labCount.Size = new global::System.Drawing.Size(101, 18);
			this.labCount.TabIndex = 35;
			this.labCount.Text = "Orders 0";
			this.labCount.TextAlignment = global::System.Drawing.StringAlignment.Center;
			this.bar.AntiAlias = true;
			this.bar.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.bar.Font = new global::System.Drawing.Font("微软雅黑", 9f);
			this.bar.IsMaximized = false;
			this.bar.Items.AddRange(new global::DevComponents.DotNetBar.BaseItem[]
			{
				this.btnAdd,
				this.btnModify,
				this.btnDelete,
				this.btnExport,
				this.btnPrint,
				this.btnSettle,
				this.btnNoSettle,
				this.btnAdvancedQuery,
				this.btnAdjust,
				this.btnAddFast,
				this.btnItemC,
				this.btnSearchVehicle
			});
			this.bar.Location = new global::System.Drawing.Point(0, 0);
			this.bar.Name = "bar";
			this.bar.Size = new global::System.Drawing.Size(1837, 27);
			this.bar.Stretch = true;
			this.bar.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.bar.TabIndex = 4;
			this.bar.TabStop = false;
			this.bar.Text = "bar1";
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
			this.btnExport.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.btnExport.Image = global::SQSClient.Properties.Resources.export16;
			this.btnExport.Name = "btnExport";
			this.btnExport.Text = "Export";
			this.btnExport.Click += new global::System.EventHandler(this.btnExport_Click);
			this.btnPrint.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.btnPrint.Image = global::SQSClient.Properties.Resources.print16;
			this.btnPrint.Name = "btnPrint";
			this.btnPrint.Text = "Print";
			this.btnPrint.Click += new global::System.EventHandler(this.btnPrint_Click);
			this.btnSettle.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.btnSettle.Image = global::SQSClient.Properties.Resources.settle16;
			this.btnSettle.Name = "btnSettle";
			this.btnSettle.Text = "Settle";
			this.btnSettle.Click += new global::System.EventHandler(this.btnSettle_Click);
			this.btnNoSettle.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.btnNoSettle.Image = global::SQSClient.Properties.Resources.settle16;
			this.btnNoSettle.Name = "btnNoSettle";
			this.btnNoSettle.Text = "NoSettle";
			this.btnNoSettle.Visible = false;
			this.btnNoSettle.Click += new global::System.EventHandler(this.btnNoSettle_Click);
			this.btnAdvancedQuery.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.btnAdvancedQuery.Image = global::SQSClient.Properties.Resources.search16;
			this.btnAdvancedQuery.Name = "btnAdvancedQuery";
			this.btnAdvancedQuery.Text = "AdvancedQuery";
			this.btnAdvancedQuery.Click += new global::System.EventHandler(this.btnAdvancedQuery_Click);
			this.btnAdjust.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.btnAdjust.Image = global::SQSClient.Properties.Resources.adjust16;
			this.btnAdjust.ItemAlignment = global::DevComponents.DotNetBar.eItemAlignment.Far;
			this.btnAdjust.Name = "btnAdjust";
			this.btnAdjust.Text = "Adjust";
			this.btnAdjust.Click += new global::System.EventHandler(this.btnAdjust_Click);
			this.btnAddFast.Name = "btnAddFast";
			this.btnAddFast.Text = "AddReference";
			this.btnAddFast.Click += new global::System.EventHandler(this.btnAddFast_Click);
			this.btnItemC.Name = "btnItemC";
			this.btnItemC.Text = "ItemC";
			this.btnItemC.Click += new global::System.EventHandler(this.btnItemC_Click);
			this.btnSearchVehicle.Name = "btnSearchVehicle";
			this.btnSearchVehicle.Text = "SearchVehicle";
			this.btnSearchVehicle.Click += new global::System.EventHandler(this.btnSearchVehicle_Click);
			base.ClientSize = new global::System.Drawing.Size(1837, 576);
			base.Controls.Add(this.dgvData);
			base.Controls.Add(this.pnlConfig);
			base.Controls.Add(this.bar);
			base.Name = "frmTicket";
			this.Text = "LoadingTouch";
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.frmTicket_FormClosing);
			base.Load += new global::System.EventHandler(this.frmTicket_Load);
			((global::System.ComponentModel.ISupportInitialize)this.dgvData).EndInit();
			this.contextMenuStrip.ResumeLayout(false);
			this.pnlConfig.ResumeLayout(false);
			this.layoutControl1.ResumeLayout(false);
			this.layoutControl1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dtpDate).EndInit();
			this.panelEx1.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.bar).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000A3D RID: 2621
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000A3E RID: 2622
		private global::DevComponents.DotNetBar.Bar bar;

		// Token: 0x04000A3F RID: 2623
		private global::DevComponents.DotNetBar.ButtonItem btnAdd;

		// Token: 0x04000A40 RID: 2624
		private global::DevComponents.DotNetBar.ButtonItem btnModify;

		// Token: 0x04000A41 RID: 2625
		private global::DevComponents.DotNetBar.ButtonItem btnDelete;

		// Token: 0x04000A42 RID: 2626
		private global::DevComponents.DotNetBar.ButtonItem btnSettle;

		// Token: 0x04000A43 RID: 2627
		private global::DevComponents.DotNetBar.Controls.GroupPanel pnlConfig;

		// Token: 0x04000A44 RID: 2628
		private global::DevComponents.DotNetBar.Controls.ComboBoxEx cmbModifyStatus;

		// Token: 0x04000A45 RID: 2629
		private global::DevComponents.DotNetBar.Controls.CheckBoxX chkIsUseDate;

		// Token: 0x04000A46 RID: 2630
		private global::DevComponents.DotNetBar.ButtonX btnCard;

		// Token: 0x04000A47 RID: 2631
		private global::DevComponents.DotNetBar.ButtonX btnQuery;

		// Token: 0x04000A48 RID: 2632
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtCardNum;

		// Token: 0x04000A49 RID: 2633
		private global::DevComponents.Editors.DateTimeAdv.DateTimeInput dtpDate;

		// Token: 0x04000A4A RID: 2634
		private global::DevComponents.DotNetBar.ButtonItem btnPrint;

		// Token: 0x04000A4B RID: 2635
		private global::Base.AutoComboBox cmbUnit;

		// Token: 0x04000A4C RID: 2636
		private global::DevComponents.DotNetBar.PanelEx panelEx1;

		// Token: 0x04000A4D RID: 2637
		private global::DevComponents.DotNetBar.LabelX labCount;

		// Token: 0x04000A4E RID: 2638
		private global::Base.AutoComboBox cmbProduct;

		// Token: 0x04000A4F RID: 2639
		private global::DevComponents.DotNetBar.ButtonItem btnAdjust;

		// Token: 0x04000A50 RID: 2640
		private global::DevComponents.DotNetBar.Controls.DataGridViewX dgvData;

		// Token: 0x04000A51 RID: 2641
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtGuanNum;

		// Token: 0x04000A52 RID: 2642
		private global::DevComponents.DotNetBar.Layout.LayoutControl layoutControl1;

		// Token: 0x04000A53 RID: 2643
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem1;

		// Token: 0x04000A54 RID: 2644
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem2;

		// Token: 0x04000A55 RID: 2645
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem9;

		// Token: 0x04000A56 RID: 2646
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem3;

		// Token: 0x04000A57 RID: 2647
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem4;

		// Token: 0x04000A58 RID: 2648
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem5;

		// Token: 0x04000A59 RID: 2649
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem6;

		// Token: 0x04000A5A RID: 2650
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem7;

		// Token: 0x04000A5B RID: 2651
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem8;

		// Token: 0x04000A5C RID: 2652
		private global::System.Windows.Forms.ContextMenuStrip contextMenuStrip;

		// Token: 0x04000A5D RID: 2653
		private global::System.Windows.Forms.ToolStripMenuItem toolReceiptCapture;

		// Token: 0x04000A5E RID: 2654
		private global::DevComponents.DotNetBar.Controls.ComboBoxEx cmbBusinessType;

		// Token: 0x04000A5F RID: 2655
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem10;

		// Token: 0x04000A60 RID: 2656
		private global::DevComponents.DotNetBar.ButtonItem btnItemC;

		// Token: 0x04000A61 RID: 2657
		private global::DevComponents.DotNetBar.LabelX labMessage;

		// Token: 0x04000A62 RID: 2658
		private global::System.Windows.Forms.ToolStripMenuItem toolCheckRequest;

		// Token: 0x04000A63 RID: 2659
		private global::System.Windows.Forms.ToolStripMenuItem toolProcessBack;

		// Token: 0x04000A64 RID: 2660
		private global::System.Windows.Forms.ToolStripMenuItem toolprocessSkip;

		// Token: 0x04000A65 RID: 2661
		private global::DevComponents.DotNetBar.PanelEx panelExProcess;

		// Token: 0x04000A66 RID: 2662
		private global::Base.AutoComboBox cmbWareHouse;

		// Token: 0x04000A67 RID: 2663
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem11;

		// Token: 0x04000A68 RID: 2664
		private global::DevComponents.DotNetBar.ButtonItem btnExport;

		// Token: 0x04000A69 RID: 2665
		private global::System.Windows.Forms.ToolStripMenuItem toolOutDoorHand;

		// Token: 0x04000A6A RID: 2666
		private global::DevComponents.DotNetBar.Controls.TextBoxX tbxDanHao;

		// Token: 0x04000A6B RID: 2667
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem12;

		// Token: 0x04000A6C RID: 2668
		private global::Base.AutoComboBox cmbStep;

		// Token: 0x04000A6D RID: 2669
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem13;

		// Token: 0x04000A6E RID: 2670
		private global::DevComponents.DotNetBar.ButtonItem btnAdvancedQuery;

		// Token: 0x04000A6F RID: 2671
		private global::DevComponents.DotNetBar.LabelX lblAdvancedQuery;

		// Token: 0x04000A70 RID: 2672
		private global::DevComponents.DotNetBar.ButtonItem btnNoSettle;

		// Token: 0x04000A71 RID: 2673
		private global::System.Windows.Forms.ToolStripMenuItem toolPrintQuality;

		// Token: 0x04000A72 RID: 2674
		private global::System.Windows.Forms.ToolStripMenuItem toolPhotoAround;

		// Token: 0x04000A73 RID: 2675
		private global::System.Windows.Forms.ToolStripMenuItem toolCuttingWeight;

		// Token: 0x04000A74 RID: 2676
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_Id;

		// Token: 0x04000A75 RID: 2677
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_DanHao;

		// Token: 0x04000A76 RID: 2678
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_IC;

		// Token: 0x04000A77 RID: 2679
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_ContractID;

		// Token: 0x04000A78 RID: 2680
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_BusinessType;

		// Token: 0x04000A79 RID: 2681
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_Clientpart;

		// Token: 0x04000A7A RID: 2682
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_Settlepart;

		// Token: 0x04000A7B RID: 2683
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_CheNum;

		// Token: 0x04000A7C RID: 2684
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_CangNum;

		// Token: 0x04000A7D RID: 2685
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_Unit;

		// Token: 0x04000A7E RID: 2686
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_Tank;

		// Token: 0x04000A7F RID: 2687
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_InvCode;

		// Token: 0x04000A80 RID: 2688
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_Product;

		// Token: 0x04000A81 RID: 2689
		private global::DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn C_JiHuaLiang;

		// Token: 0x04000A82 RID: 2690
		private global::DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn C_ShiJiLiang;

		// Token: 0x04000A83 RID: 2691
		private global::DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn C_FirstWeight;

		// Token: 0x04000A84 RID: 2692
		private global::DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn C_SecondWeight;

		// Token: 0x04000A85 RID: 2693
		private global::DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn C_DifferWeight;

		// Token: 0x04000A86 RID: 2694
		private global::DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn C_FWDiffer;

		// Token: 0x04000A87 RID: 2695
		private global::DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn C_JieSuanLiang;

		// Token: 0x04000A88 RID: 2696
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_DanWei;

		// Token: 0x04000A89 RID: 2697
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_OrderStatus;

		// Token: 0x04000A8A RID: 2698
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_CheckoutStatus;

		// Token: 0x04000A8B RID: 2699
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_PaymentType;

		// Token: 0x04000A8C RID: 2700
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_StepProcessName;

		// Token: 0x04000A8D RID: 2701
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_ZhiDanRen;

		// Token: 0x04000A8E RID: 2702
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_ZhiDanTime;

		// Token: 0x04000A8F RID: 2703
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_StartTime;

		// Token: 0x04000A90 RID: 2704
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_EndTime;

		// Token: 0x04000A91 RID: 2705
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_JieSuanTime;

		// Token: 0x04000A92 RID: 2706
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_JieSuanRen;

		// Token: 0x04000A93 RID: 2707
		private global::System.Windows.Forms.ToolStripMenuItem viewTicketProcessToolStripMenuItem;

		// Token: 0x04000A94 RID: 2708
		private global::System.Windows.Forms.ToolStripMenuItem toolWeightDetails;

		// Token: 0x04000A95 RID: 2709
		private global::DevComponents.DotNetBar.ButtonItem btnAddFast;

		// Token: 0x04000A96 RID: 2710
		private global::DevComponents.DotNetBar.ButtonItem btnSearchVehicle;
	}
}
