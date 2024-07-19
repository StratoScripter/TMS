namespace SQSClient
{
	// Token: 0x02000024 RID: 36
	public partial class frmLab : global::SQSClient.BaseDialogForm
	{
		// Token: 0x060001CC RID: 460 RVA: 0x00034014 File Offset: 0x00032214
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060001CD RID: 461 RVA: 0x0003404C File Offset: 0x0003224C
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new global::System.Windows.Forms.DataGridViewCellStyle();
			this.timer = new global::System.Windows.Forms.Timer(this.components);
			this.ePanelToSample = new global::DevComponents.DotNetBar.ExpandablePanel();
			this.dgvData1 = new global::DevComponents.DotNetBar.Controls.DataGridViewX();
			this.dataGridViewTextBoxColumn3 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn6 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn8 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn21 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn19 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn20 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column1 = new global::DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn();
			this.dataGridViewDoubleInputColumn6 = new global::DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn();
			this.dataGridViewDoubleInputColumn9 = new global::DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn();
			this.dataGridViewDoubleInputColumn2 = new global::DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn();
			this.dataGridViewTextBoxColumn23 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn24 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn25 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn26 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn27 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn28 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn29 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn30 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn31 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgvData = new global::DevComponents.DotNetBar.Controls.DataGridViewX();
			this.C_Id = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_DanHao = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_BusinessType = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_Product = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_CheNum = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_Unit = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_JiHuaLiang = new global::DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn();
			this.C_ShiJiLiang = new global::DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn();
			this.C_DifferWeight = new global::DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn();
			this.C_JieSuanLiang = new global::DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn();
			this.C_DanWei = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_OrderStatus = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_LabStatus = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_LabResult = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_LabMan = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_LabTime = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_LabCount = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_Remark = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_ClientPart = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bar = new global::DevComponents.DotNetBar.Bar();
			this.btnSampling = new global::DevComponents.DotNetBar.ButtonItem();
			this.btnAnalysis = new global::DevComponents.DotNetBar.ButtonItem();
			this.btnLab = new global::DevComponents.DotNetBar.ButtonItem();
			this.btnConfirm = new global::DevComponents.DotNetBar.ButtonItem();
			this.labMessage = new global::DevComponents.DotNetBar.LabelItem();
			this.btnRefresh = new global::DevComponents.DotNetBar.ButtonItem();
			this.lblTicketDanHao = new global::DevComponents.DotNetBar.LabelItem();
			this.cbxSpeech = new global::DevComponents.DotNetBar.CheckBoxItem();
			this.btnItemC = new global::DevComponents.DotNetBar.ButtonItem();
			this.ePanelPlan = new global::DevComponents.DotNetBar.ExpandablePanel();
			this.dgvDataPlan = new global::DevComponents.DotNetBar.Controls.DataGridViewX();
			this.dataGridViewTextBoxColumn1 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn11 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn7 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn9 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewDoubleInputColumn1 = new global::DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn();
			this.dataGridViewTextBoxColumn12 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn13 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn14 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn15 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn16 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn17 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn18 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn22 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ePanelToSample.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvData1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.dgvData).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.bar).BeginInit();
			this.ePanelPlan.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvDataPlan).BeginInit();
			base.SuspendLayout();
			this.timer.Interval = 3000;
			this.timer.Tick += new global::System.EventHandler(this.timer_Tick);
			this.ePanelToSample.CanvasColor = global::System.Drawing.SystemColors.Control;
			this.ePanelToSample.ColorSchemeStyle = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.ePanelToSample.Controls.Add(this.dgvData1);
			this.ePanelToSample.Controls.Add(this.dgvData);
			this.ePanelToSample.Controls.Add(this.bar);
			this.ePanelToSample.DisabledBackColor = global::System.Drawing.Color.Empty;
			this.ePanelToSample.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.ePanelToSample.HideControlsWhenCollapsed = true;
			this.ePanelToSample.Location = new global::System.Drawing.Point(0, 0);
			this.ePanelToSample.Name = "ePanelToSample";
			this.ePanelToSample.Size = new global::System.Drawing.Size(1416, 617);
			this.ePanelToSample.Style.Alignment = global::System.Drawing.StringAlignment.Center;
			this.ePanelToSample.Style.BackColor1.ColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
			this.ePanelToSample.Style.BackColor2.ColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
			this.ePanelToSample.Style.Border = global::DevComponents.DotNetBar.eBorderType.SingleLine;
			this.ePanelToSample.Style.BorderColor.ColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
			this.ePanelToSample.Style.ForeColor.ColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.ItemText;
			this.ePanelToSample.Style.GradientAngle = 90;
			this.ePanelToSample.TabIndex = 24;
			this.ePanelToSample.TitleStyle.Alignment = global::System.Drawing.StringAlignment.Center;
			this.ePanelToSample.TitleStyle.BackColor1.ColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
			this.ePanelToSample.TitleStyle.BackColor2.ColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
			this.ePanelToSample.TitleStyle.Border = global::DevComponents.DotNetBar.eBorderType.RaisedInner;
			this.ePanelToSample.TitleStyle.BorderColor.ColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
			this.ePanelToSample.TitleStyle.ForeColor.ColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelText;
			this.ePanelToSample.TitleStyle.GradientAngle = 90;
			this.ePanelToSample.TitleText = "ToSample";
			this.dgvData1.AllowUserToAddRows = false;
			this.dgvData1.AllowUserToDeleteRows = false;
			this.dgvData1.AllowUserToResizeRows = false;
			this.dgvData1.AutoSizeColumnsMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			dataGridViewCellStyle.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle.BackColor = global::System.Drawing.SystemColors.Control;
			dataGridViewCellStyle.Font = new global::System.Drawing.Font("宋体", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 134);
			dataGridViewCellStyle.ForeColor = global::System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle.SelectionBackColor = global::System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle.SelectionForeColor = global::System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle.WrapMode = global::System.Windows.Forms.DataGridViewTriState.True;
			this.dgvData1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
			this.dgvData1.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dgvData1.Columns.AddRange(new global::System.Windows.Forms.DataGridViewColumn[]
			{
				this.dataGridViewTextBoxColumn3,
				this.dataGridViewTextBoxColumn6,
				this.dataGridViewTextBoxColumn8,
				this.dataGridViewTextBoxColumn21,
				this.dataGridViewTextBoxColumn19,
				this.dataGridViewTextBoxColumn20,
				this.Column1,
				this.dataGridViewDoubleInputColumn6,
				this.dataGridViewDoubleInputColumn9,
				this.dataGridViewDoubleInputColumn2,
				this.dataGridViewTextBoxColumn23,
				this.dataGridViewTextBoxColumn24,
				this.dataGridViewTextBoxColumn25,
				this.dataGridViewTextBoxColumn26,
				this.dataGridViewTextBoxColumn27,
				this.dataGridViewTextBoxColumn28,
				this.dataGridViewTextBoxColumn29,
				this.dataGridViewTextBoxColumn30,
				this.dataGridViewTextBoxColumn31
			});
			dataGridViewCellStyle2.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = global::System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new global::System.Drawing.Font("宋体", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 134);
			dataGridViewCellStyle2.ForeColor = global::System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = global::System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = global::System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.WrapMode = global::System.Windows.Forms.DataGridViewTriState.False;
			this.dgvData1.DefaultCellStyle = dataGridViewCellStyle2;
			this.dgvData1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.dgvData1.EnableHeadersVisualStyles = false;
			this.dgvData1.GridColor = global::System.Drawing.Color.FromArgb(208, 215, 229);
			this.dgvData1.Location = new global::System.Drawing.Point(0, 226);
			this.dgvData1.Name = "dgvData1";
			this.dgvData1.ReadOnly = true;
			this.dgvData1.RowHeadersVisible = false;
			this.dgvData1.RowTemplate.Height = 23;
			this.dgvData1.SelectionMode = global::System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvData1.Size = new global::System.Drawing.Size(1416, 391);
			this.dgvData1.TabIndex = 22;
			this.dgvData1.CellClick += new global::System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellClick);
			this.dgvData1.CellDoubleClick += new global::System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellDoubleClick);
			this.dataGridViewTextBoxColumn3.FillWeight = 82.8988f;
			this.dataGridViewTextBoxColumn3.HeaderText = "ID";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.ReadOnly = true;
			this.dataGridViewTextBoxColumn3.Visible = false;
			this.dataGridViewTextBoxColumn6.DataPropertyName = "DanHao";
			this.dataGridViewTextBoxColumn6.FillWeight = 82.8988f;
			this.dataGridViewTextBoxColumn6.HeaderText = "DanHao";
			this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
			this.dataGridViewTextBoxColumn6.ReadOnly = true;
			this.dataGridViewTextBoxColumn8.DataPropertyName = "BusinessType";
			this.dataGridViewTextBoxColumn8.HeaderText = "BusinessType";
			this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
			this.dataGridViewTextBoxColumn8.ReadOnly = true;
			this.dataGridViewTextBoxColumn21.DataPropertyName = "ProductName";
			this.dataGridViewTextBoxColumn21.HeaderText = "Product";
			this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
			this.dataGridViewTextBoxColumn21.ReadOnly = true;
			this.dataGridViewTextBoxColumn19.DataPropertyName = "CheNum";
			this.dataGridViewTextBoxColumn19.FillWeight = 82.8988f;
			this.dataGridViewTextBoxColumn19.HeaderText = "CheNum";
			this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
			this.dataGridViewTextBoxColumn19.ReadOnly = true;
			this.dataGridViewTextBoxColumn20.DataPropertyName = "Unit";
			this.dataGridViewTextBoxColumn20.HeaderText = "Unit";
			this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
			this.dataGridViewTextBoxColumn20.ReadOnly = true;
			this.Column1.BackgroundStyle.Class = "DataGridViewNumericBorder";
			this.Column1.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.Column1.DataPropertyName = "JiHuaLiang";
			this.Column1.HeaderText = "JiHuaLiang";
			this.Column1.Increment = 1.0;
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			this.Column1.Resizable = global::System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewDoubleInputColumn6.BackgroundStyle.Class = "DataGridViewNumericBorder";
			this.dataGridViewDoubleInputColumn6.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.dataGridViewDoubleInputColumn6.DataPropertyName = "ShiJiLiang";
			this.dataGridViewDoubleInputColumn6.FillWeight = 82.8988f;
			this.dataGridViewDoubleInputColumn6.HeaderText = "ShiJiLiang";
			this.dataGridViewDoubleInputColumn6.Increment = 1.0;
			this.dataGridViewDoubleInputColumn6.InputHorizontalAlignment = global::DevComponents.Editors.eHorizontalAlignment.Left;
			this.dataGridViewDoubleInputColumn6.Name = "dataGridViewDoubleInputColumn6";
			this.dataGridViewDoubleInputColumn6.ReadOnly = true;
			this.dataGridViewDoubleInputColumn6.Resizable = global::System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewDoubleInputColumn9.BackgroundStyle.Class = "DataGridViewNumericBorder";
			this.dataGridViewDoubleInputColumn9.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.dataGridViewDoubleInputColumn9.DataPropertyName = "DifferWeight";
			this.dataGridViewDoubleInputColumn9.HeaderText = "DifferWeight(kg)";
			this.dataGridViewDoubleInputColumn9.Increment = 1.0;
			this.dataGridViewDoubleInputColumn9.InputHorizontalAlignment = global::DevComponents.Editors.eHorizontalAlignment.Left;
			this.dataGridViewDoubleInputColumn9.Name = "dataGridViewDoubleInputColumn9";
			this.dataGridViewDoubleInputColumn9.ReadOnly = true;
			this.dataGridViewDoubleInputColumn9.Resizable = global::System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewDoubleInputColumn2.BackgroundStyle.Class = "DataGridViewNumericBorder";
			this.dataGridViewDoubleInputColumn2.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.dataGridViewDoubleInputColumn2.DataPropertyName = "JieSuanLiang";
			this.dataGridViewDoubleInputColumn2.FillWeight = 82.8988f;
			this.dataGridViewDoubleInputColumn2.HeaderText = "JieSuanLiang";
			this.dataGridViewDoubleInputColumn2.Increment = 1.0;
			this.dataGridViewDoubleInputColumn2.InputHorizontalAlignment = global::DevComponents.Editors.eHorizontalAlignment.Left;
			this.dataGridViewDoubleInputColumn2.Name = "dataGridViewDoubleInputColumn2";
			this.dataGridViewDoubleInputColumn2.ReadOnly = true;
			this.dataGridViewDoubleInputColumn2.Resizable = global::System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn23.DataPropertyName = "DanWei";
			this.dataGridViewTextBoxColumn23.HeaderText = "DanWei";
			this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
			this.dataGridViewTextBoxColumn23.ReadOnly = true;
			this.dataGridViewTextBoxColumn24.DataPropertyName = "OrderStatus";
			dataGridViewCellStyle3.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.dataGridViewTextBoxColumn24.DefaultCellStyle = dataGridViewCellStyle3;
			this.dataGridViewTextBoxColumn24.FillWeight = 82.8988f;
			this.dataGridViewTextBoxColumn24.HeaderText = "OrderStatus";
			this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
			this.dataGridViewTextBoxColumn24.ReadOnly = true;
			this.dataGridViewTextBoxColumn25.DataPropertyName = "LabStatus";
			this.dataGridViewTextBoxColumn25.HeaderText = "LabStatus";
			this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
			this.dataGridViewTextBoxColumn25.ReadOnly = true;
			this.dataGridViewTextBoxColumn26.DataPropertyName = "LabResult";
			this.dataGridViewTextBoxColumn26.HeaderText = "LabResult";
			this.dataGridViewTextBoxColumn26.Name = "dataGridViewTextBoxColumn26";
			this.dataGridViewTextBoxColumn26.ReadOnly = true;
			this.dataGridViewTextBoxColumn27.DataPropertyName = "LabMan";
			this.dataGridViewTextBoxColumn27.HeaderText = "LabMan";
			this.dataGridViewTextBoxColumn27.Name = "dataGridViewTextBoxColumn27";
			this.dataGridViewTextBoxColumn27.ReadOnly = true;
			this.dataGridViewTextBoxColumn28.DataPropertyName = "LabTime";
			this.dataGridViewTextBoxColumn28.HeaderText = "LabTime";
			this.dataGridViewTextBoxColumn28.Name = "dataGridViewTextBoxColumn28";
			this.dataGridViewTextBoxColumn28.ReadOnly = true;
			this.dataGridViewTextBoxColumn29.DataPropertyName = "LabCount";
			this.dataGridViewTextBoxColumn29.HeaderText = "LabCount";
			this.dataGridViewTextBoxColumn29.Name = "dataGridViewTextBoxColumn29";
			this.dataGridViewTextBoxColumn29.ReadOnly = true;
			this.dataGridViewTextBoxColumn30.DataPropertyName = "Remark";
			this.dataGridViewTextBoxColumn30.HeaderText = "Remark";
			this.dataGridViewTextBoxColumn30.Name = "dataGridViewTextBoxColumn30";
			this.dataGridViewTextBoxColumn30.ReadOnly = true;
			this.dataGridViewTextBoxColumn31.DataPropertyName = "Clientpart";
			this.dataGridViewTextBoxColumn31.HeaderText = "Clientpart";
			this.dataGridViewTextBoxColumn31.Name = "dataGridViewTextBoxColumn31";
			this.dataGridViewTextBoxColumn31.ReadOnly = true;
			this.dgvData.AllowUserToAddRows = false;
			this.dgvData.AllowUserToDeleteRows = false;
			this.dgvData.AllowUserToResizeRows = false;
			this.dgvData.AutoSizeColumnsMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			dataGridViewCellStyle4.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle4.BackColor = global::System.Drawing.SystemColors.Control;
			dataGridViewCellStyle4.Font = new global::System.Drawing.Font("宋体", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 134);
			dataGridViewCellStyle4.ForeColor = global::System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle4.SelectionBackColor = global::System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = global::System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = global::System.Windows.Forms.DataGridViewTriState.True;
			this.dgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.dgvData.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dgvData.Columns.AddRange(new global::System.Windows.Forms.DataGridViewColumn[]
			{
				this.C_Id,
				this.C_DanHao,
				this.C_BusinessType,
				this.C_Product,
				this.C_CheNum,
				this.C_Unit,
				this.C_JiHuaLiang,
				this.C_ShiJiLiang,
				this.C_DifferWeight,
				this.C_JieSuanLiang,
				this.C_DanWei,
				this.C_OrderStatus,
				this.C_LabStatus,
				this.C_LabResult,
				this.C_LabMan,
				this.C_LabTime,
				this.C_LabCount,
				this.C_Remark,
				this.C_ClientPart
			});
			dataGridViewCellStyle5.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle5.BackColor = global::System.Drawing.SystemColors.Window;
			dataGridViewCellStyle5.Font = new global::System.Drawing.Font("宋体", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 134);
			dataGridViewCellStyle5.ForeColor = global::System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle5.SelectionBackColor = global::System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle5.SelectionForeColor = global::System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle5.WrapMode = global::System.Windows.Forms.DataGridViewTriState.False;
			this.dgvData.DefaultCellStyle = dataGridViewCellStyle5;
			this.dgvData.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.dgvData.EnableHeadersVisualStyles = false;
			this.dgvData.GridColor = global::System.Drawing.Color.FromArgb(208, 215, 229);
			this.dgvData.Location = new global::System.Drawing.Point(0, 53);
			this.dgvData.MultiSelect = false;
			this.dgvData.Name = "dgvData";
			this.dgvData.ReadOnly = true;
			this.dgvData.RowHeadersVisible = false;
			this.dgvData.RowTemplate.Height = 23;
			this.dgvData.SelectionMode = global::System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvData.Size = new global::System.Drawing.Size(1416, 173);
			this.dgvData.TabIndex = 21;
			this.dgvData.CellClick += new global::System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellClick);
			this.dgvData.CellDoubleClick += new global::System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellDoubleClick);
			this.C_Id.FillWeight = 82.8988f;
			this.C_Id.HeaderText = "ID";
			this.C_Id.Name = "C_Id";
			this.C_Id.ReadOnly = true;
			this.C_Id.Visible = false;
			this.C_DanHao.DataPropertyName = "DanHao";
			this.C_DanHao.FillWeight = 82.8988f;
			this.C_DanHao.HeaderText = "DanHao";
			this.C_DanHao.Name = "C_DanHao";
			this.C_DanHao.ReadOnly = true;
			this.C_BusinessType.DataPropertyName = "BusinessType";
			this.C_BusinessType.HeaderText = "BusinessType";
			this.C_BusinessType.Name = "C_BusinessType";
			this.C_BusinessType.ReadOnly = true;
			this.C_Product.DataPropertyName = "ProductName";
			this.C_Product.HeaderText = "Product";
			this.C_Product.Name = "C_Product";
			this.C_Product.ReadOnly = true;
			this.C_CheNum.DataPropertyName = "CheNum";
			this.C_CheNum.FillWeight = 82.8988f;
			this.C_CheNum.HeaderText = "CheNum";
			this.C_CheNum.Name = "C_CheNum";
			this.C_CheNum.ReadOnly = true;
			this.C_Unit.DataPropertyName = "Unit";
			this.C_Unit.HeaderText = "Unit";
			this.C_Unit.Name = "C_Unit";
			this.C_Unit.ReadOnly = true;
			this.C_JiHuaLiang.BackgroundStyle.Class = "DataGridViewNumericBorder";
			this.C_JiHuaLiang.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.C_JiHuaLiang.DataPropertyName = "JiHuaLiang";
			this.C_JiHuaLiang.HeaderText = "JiHuaLiang";
			this.C_JiHuaLiang.Increment = 1.0;
			this.C_JiHuaLiang.Name = "C_JiHuaLiang";
			this.C_JiHuaLiang.ReadOnly = true;
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
			this.C_DifferWeight.BackgroundStyle.Class = "DataGridViewNumericBorder";
			this.C_DifferWeight.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.C_DifferWeight.DataPropertyName = "DifferWeight";
			this.C_DifferWeight.HeaderText = "DifferWeight(kg)";
			this.C_DifferWeight.Increment = 1.0;
			this.C_DifferWeight.InputHorizontalAlignment = global::DevComponents.Editors.eHorizontalAlignment.Left;
			this.C_DifferWeight.Name = "C_DifferWeight";
			this.C_DifferWeight.ReadOnly = true;
			this.C_DifferWeight.Resizable = global::System.Windows.Forms.DataGridViewTriState.True;
			this.C_JieSuanLiang.BackgroundStyle.Class = "DataGridViewNumericBorder";
			this.C_JieSuanLiang.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.C_JieSuanLiang.DataPropertyName = "JieSuanLiang";
			this.C_JieSuanLiang.FillWeight = 82.8988f;
			this.C_JieSuanLiang.HeaderText = "JieSuanLiang";
			this.C_JieSuanLiang.Increment = 1.0;
			this.C_JieSuanLiang.InputHorizontalAlignment = global::DevComponents.Editors.eHorizontalAlignment.Left;
			this.C_JieSuanLiang.Name = "C_JieSuanLiang";
			this.C_JieSuanLiang.ReadOnly = true;
			this.C_JieSuanLiang.Resizable = global::System.Windows.Forms.DataGridViewTriState.True;
			this.C_DanWei.DataPropertyName = "DanWei";
			this.C_DanWei.HeaderText = "DanWei";
			this.C_DanWei.Name = "C_DanWei";
			this.C_DanWei.ReadOnly = true;
			this.C_OrderStatus.DataPropertyName = "OrderStatus";
			dataGridViewCellStyle6.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.C_OrderStatus.DefaultCellStyle = dataGridViewCellStyle6;
			this.C_OrderStatus.FillWeight = 82.8988f;
			this.C_OrderStatus.HeaderText = "OrderStatus";
			this.C_OrderStatus.Name = "C_OrderStatus";
			this.C_OrderStatus.ReadOnly = true;
			this.C_LabStatus.DataPropertyName = "LabStatus";
			this.C_LabStatus.HeaderText = "LabStatus";
			this.C_LabStatus.Name = "C_LabStatus";
			this.C_LabStatus.ReadOnly = true;
			this.C_LabResult.DataPropertyName = "LabResult";
			this.C_LabResult.HeaderText = "LabResult";
			this.C_LabResult.Name = "C_LabResult";
			this.C_LabResult.ReadOnly = true;
			this.C_LabMan.DataPropertyName = "LabMan";
			this.C_LabMan.HeaderText = "LabMan";
			this.C_LabMan.Name = "C_LabMan";
			this.C_LabMan.ReadOnly = true;
			this.C_LabTime.DataPropertyName = "LabTime";
			this.C_LabTime.HeaderText = "LabTime";
			this.C_LabTime.Name = "C_LabTime";
			this.C_LabTime.ReadOnly = true;
			this.C_LabCount.DataPropertyName = "LabCount";
			this.C_LabCount.HeaderText = "LabCount";
			this.C_LabCount.Name = "C_LabCount";
			this.C_LabCount.ReadOnly = true;
			this.C_Remark.DataPropertyName = "Remark";
			this.C_Remark.HeaderText = "Remark";
			this.C_Remark.Name = "C_Remark";
			this.C_Remark.ReadOnly = true;
			this.C_ClientPart.DataPropertyName = "Clientpart";
			this.C_ClientPart.HeaderText = "Clientpart";
			this.C_ClientPart.Name = "C_ClientPart";
			this.C_ClientPart.ReadOnly = true;
			this.bar.AntiAlias = true;
			this.bar.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.bar.DockSide = global::DevComponents.DotNetBar.eDockSide.Document;
			this.bar.Font = new global::System.Drawing.Font("微软雅黑", 9f);
			this.bar.IsMaximized = false;
			this.bar.Items.AddRange(new global::DevComponents.DotNetBar.BaseItem[]
			{
				this.btnSampling,
				this.btnAnalysis,
				this.btnLab,
				this.btnConfirm,
				this.labMessage,
				this.btnRefresh,
				this.lblTicketDanHao,
				this.cbxSpeech,
				this.btnItemC
			});
			this.bar.Location = new global::System.Drawing.Point(0, 26);
			this.bar.Name = "bar";
			this.bar.Size = new global::System.Drawing.Size(1416, 27);
			this.bar.Stretch = true;
			this.bar.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.bar.TabIndex = 20;
			this.bar.TabStop = false;
			this.bar.Text = "bar1";
			this.btnSampling.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.btnSampling.Image = global::SQSClient.Properties.Resources.modify16;
			this.btnSampling.Name = "btnSampling";
			this.btnSampling.Text = "Sampling";
			this.btnSampling.Click += new global::System.EventHandler(this.btnSampling_Click);
			this.btnAnalysis.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.btnAnalysis.Image = global::SQSClient.Properties.Resources.modify16;
			this.btnAnalysis.Name = "btnAnalysis";
			this.btnAnalysis.Text = "Analysis";
			this.btnAnalysis.Click += new global::System.EventHandler(this.btnAnalysis_Click);
			this.btnLab.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.btnLab.Image = global::SQSClient.Properties.Resources.modify16;
			this.btnLab.Name = "btnLab";
			this.btnLab.Text = "Lab";
			this.btnLab.Click += new global::System.EventHandler(this.btnLab_Click);
			this.btnConfirm.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.btnConfirm.Image = global::SQSClient.Properties.Resources.modify16;
			this.btnConfirm.Name = "btnConfirm";
			this.btnConfirm.Text = "Confirm";
			this.btnConfirm.Click += new global::System.EventHandler(this.btnConfirm_Click);
			this.labMessage.ForeColor = global::System.Drawing.Color.Red;
			this.labMessage.ItemAlignment = global::DevComponents.DotNetBar.eItemAlignment.Far;
			this.labMessage.Name = "labMessage";
			this.labMessage.Text = "        ";
			this.btnRefresh.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.btnRefresh.Image = global::SQSClient.Properties.Resources.update16;
			this.btnRefresh.ItemAlignment = global::DevComponents.DotNetBar.eItemAlignment.Far;
			this.btnRefresh.Name = "btnRefresh";
			this.btnRefresh.Text = "Refresh";
			this.btnRefresh.Click += new global::System.EventHandler(this.btnRefresh_Click);
			this.lblTicketDanHao.Name = "lblTicketDanHao";
			this.lblTicketDanHao.Text = "TicketDanHao";
			this.cbxSpeech.Name = "cbxSpeech";
			this.cbxSpeech.Text = "Speech";
			this.cbxSpeech.Click += new global::System.EventHandler(this.cbxSpeech_Click);
			this.btnItemC.Name = "btnItemC";
			this.btnItemC.Text = "ItemC";
			this.btnItemC.Click += new global::System.EventHandler(this.btnItemC_Click);
			this.ePanelPlan.CanvasColor = global::System.Drawing.SystemColors.Control;
			this.ePanelPlan.ColorSchemeStyle = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.ePanelPlan.Controls.Add(this.dgvDataPlan);
			this.ePanelPlan.DisabledBackColor = global::System.Drawing.Color.Empty;
			this.ePanelPlan.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.ePanelPlan.Expanded = false;
			this.ePanelPlan.ExpandedBounds = new global::System.Drawing.Rectangle(0, 402, 1175, 241);
			this.ePanelPlan.HideControlsWhenCollapsed = true;
			this.ePanelPlan.Location = new global::System.Drawing.Point(0, 617);
			this.ePanelPlan.Name = "ePanelPlan";
			this.ePanelPlan.Size = new global::System.Drawing.Size(1416, 26);
			this.ePanelPlan.Style.Alignment = global::System.Drawing.StringAlignment.Center;
			this.ePanelPlan.Style.BackColor1.ColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
			this.ePanelPlan.Style.BackColor2.ColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
			this.ePanelPlan.Style.Border = global::DevComponents.DotNetBar.eBorderType.SingleLine;
			this.ePanelPlan.Style.BorderColor.ColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
			this.ePanelPlan.Style.ForeColor.ColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.ItemText;
			this.ePanelPlan.Style.GradientAngle = 90;
			this.ePanelPlan.TabIndex = 20;
			this.ePanelPlan.TitleStyle.Alignment = global::System.Drawing.StringAlignment.Center;
			this.ePanelPlan.TitleStyle.BackColor1.ColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
			this.ePanelPlan.TitleStyle.BackColor2.ColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
			this.ePanelPlan.TitleStyle.Border = global::DevComponents.DotNetBar.eBorderType.RaisedInner;
			this.ePanelPlan.TitleStyle.BorderColor.ColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
			this.ePanelPlan.TitleStyle.ForeColor.ColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelText;
			this.ePanelPlan.TitleStyle.GradientAngle = 90;
			this.ePanelPlan.TitleText = "Plan";
			this.dgvDataPlan.AllowUserToAddRows = false;
			this.dgvDataPlan.AllowUserToDeleteRows = false;
			this.dgvDataPlan.AllowUserToResizeRows = false;
			this.dgvDataPlan.AutoSizeColumnsMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			dataGridViewCellStyle7.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle7.BackColor = global::System.Drawing.SystemColors.Control;
			dataGridViewCellStyle7.Font = new global::System.Drawing.Font("宋体", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 134);
			dataGridViewCellStyle7.ForeColor = global::System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle7.SelectionBackColor = global::System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle7.SelectionForeColor = global::System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle7.WrapMode = global::System.Windows.Forms.DataGridViewTriState.True;
			this.dgvDataPlan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
			this.dgvDataPlan.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dgvDataPlan.Columns.AddRange(new global::System.Windows.Forms.DataGridViewColumn[]
			{
				this.dataGridViewTextBoxColumn1,
				this.dataGridViewTextBoxColumn2,
				this.dataGridViewTextBoxColumn4,
				this.dataGridViewTextBoxColumn11,
				this.dataGridViewTextBoxColumn5,
				this.dataGridViewTextBoxColumn7,
				this.dataGridViewTextBoxColumn9,
				this.dataGridViewDoubleInputColumn1,
				this.dataGridViewTextBoxColumn12,
				this.dataGridViewTextBoxColumn13,
				this.dataGridViewTextBoxColumn14,
				this.dataGridViewTextBoxColumn15,
				this.dataGridViewTextBoxColumn16,
				this.dataGridViewTextBoxColumn17,
				this.dataGridViewTextBoxColumn18,
				this.dataGridViewTextBoxColumn22
			});
			dataGridViewCellStyle8.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle8.BackColor = global::System.Drawing.SystemColors.Window;
			dataGridViewCellStyle8.Font = new global::System.Drawing.Font("宋体", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 134);
			dataGridViewCellStyle8.ForeColor = global::System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle8.SelectionBackColor = global::System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle8.SelectionForeColor = global::System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle8.WrapMode = global::System.Windows.Forms.DataGridViewTriState.False;
			this.dgvDataPlan.DefaultCellStyle = dataGridViewCellStyle8;
			this.dgvDataPlan.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.dgvDataPlan.EnableHeadersVisualStyles = false;
			this.dgvDataPlan.GridColor = global::System.Drawing.Color.FromArgb(208, 215, 229);
			this.dgvDataPlan.Location = new global::System.Drawing.Point(0, 26);
			this.dgvDataPlan.MultiSelect = false;
			this.dgvDataPlan.Name = "dgvDataPlan";
			this.dgvDataPlan.ReadOnly = true;
			this.dgvDataPlan.RowHeadersVisible = false;
			this.dgvDataPlan.RowTemplate.Height = 23;
			this.dgvDataPlan.SelectionMode = global::System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvDataPlan.Size = new global::System.Drawing.Size(1416, 0);
			this.dgvDataPlan.TabIndex = 20;
			this.dataGridViewTextBoxColumn1.FillWeight = 82.8988f;
			this.dataGridViewTextBoxColumn1.HeaderText = "ID";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			this.dataGridViewTextBoxColumn1.Visible = false;
			this.dataGridViewTextBoxColumn2.FillWeight = 82.8988f;
			this.dataGridViewTextBoxColumn2.HeaderText = "DanHao";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.ReadOnly = true;
			this.dataGridViewTextBoxColumn4.HeaderText = "BusinessType";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn4.ReadOnly = true;
			this.dataGridViewTextBoxColumn11.HeaderText = "Product";
			this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
			this.dataGridViewTextBoxColumn11.ReadOnly = true;
			this.dataGridViewTextBoxColumn5.HeaderText = "Clientpart";
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			this.dataGridViewTextBoxColumn5.ReadOnly = true;
			this.dataGridViewTextBoxColumn7.FillWeight = 82.8988f;
			this.dataGridViewTextBoxColumn7.HeaderText = "CheNum";
			this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
			this.dataGridViewTextBoxColumn7.ReadOnly = true;
			this.dataGridViewTextBoxColumn9.HeaderText = "Unit";
			this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
			this.dataGridViewTextBoxColumn9.ReadOnly = true;
			this.dataGridViewDoubleInputColumn1.BackgroundStyle.Class = "DataGridViewNumericBorder";
			this.dataGridViewDoubleInputColumn1.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.dataGridViewDoubleInputColumn1.FillWeight = 82.8988f;
			this.dataGridViewDoubleInputColumn1.HeaderText = "JiHuaLiang";
			this.dataGridViewDoubleInputColumn1.Increment = 1.0;
			this.dataGridViewDoubleInputColumn1.InputHorizontalAlignment = global::DevComponents.Editors.eHorizontalAlignment.Left;
			this.dataGridViewDoubleInputColumn1.Name = "dataGridViewDoubleInputColumn1";
			this.dataGridViewDoubleInputColumn1.ReadOnly = true;
			this.dataGridViewDoubleInputColumn1.Resizable = global::System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn12.HeaderText = "DanWei";
			this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
			this.dataGridViewTextBoxColumn12.ReadOnly = true;
			dataGridViewCellStyle9.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.dataGridViewTextBoxColumn13.DefaultCellStyle = dataGridViewCellStyle9;
			this.dataGridViewTextBoxColumn13.FillWeight = 82.8988f;
			this.dataGridViewTextBoxColumn13.HeaderText = "OrderStatus";
			this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
			this.dataGridViewTextBoxColumn13.ReadOnly = true;
			this.dataGridViewTextBoxColumn14.HeaderText = "LabStatus";
			this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
			this.dataGridViewTextBoxColumn14.ReadOnly = true;
			this.dataGridViewTextBoxColumn15.HeaderText = "LabResult";
			this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
			this.dataGridViewTextBoxColumn15.ReadOnly = true;
			this.dataGridViewTextBoxColumn16.HeaderText = "LabMan";
			this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
			this.dataGridViewTextBoxColumn16.ReadOnly = true;
			this.dataGridViewTextBoxColumn17.HeaderText = "LabTime";
			this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
			this.dataGridViewTextBoxColumn17.ReadOnly = true;
			this.dataGridViewTextBoxColumn18.HeaderText = "LabCount";
			this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
			this.dataGridViewTextBoxColumn18.ReadOnly = true;
			this.dataGridViewTextBoxColumn22.HeaderText = "Remark";
			this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
			this.dataGridViewTextBoxColumn22.ReadOnly = true;
			base.ClientSize = new global::System.Drawing.Size(1416, 643);
			base.Controls.Add(this.ePanelToSample);
			base.Controls.Add(this.ePanelPlan);
			base.Name = "frmLab";
			this.Text = "frmLab";
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.frmLab_FormClosing);
			base.Load += new global::System.EventHandler(this.frmLab_Load);
			this.ePanelToSample.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.dgvData1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.dgvData).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.bar).EndInit();
			this.ePanelPlan.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.dgvDataPlan).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x040002FE RID: 766
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x040002FF RID: 767
		private global::System.Windows.Forms.Timer timer;

		// Token: 0x04000300 RID: 768
		private global::DevComponents.DotNetBar.ExpandablePanel ePanelPlan;

		// Token: 0x04000301 RID: 769
		private global::DevComponents.DotNetBar.Controls.DataGridViewX dgvDataPlan;

		// Token: 0x04000302 RID: 770
		private global::DevComponents.DotNetBar.ExpandablePanel ePanelToSample;

		// Token: 0x04000303 RID: 771
		private global::DevComponents.DotNetBar.Controls.DataGridViewX dgvData1;

		// Token: 0x04000304 RID: 772
		private global::DevComponents.DotNetBar.Controls.DataGridViewX dgvData;

		// Token: 0x04000305 RID: 773
		private global::DevComponents.DotNetBar.Bar bar;

		// Token: 0x04000306 RID: 774
		private global::DevComponents.DotNetBar.ButtonItem btnLab;

		// Token: 0x04000307 RID: 775
		private global::DevComponents.DotNetBar.LabelItem labMessage;

		// Token: 0x04000308 RID: 776
		private global::DevComponents.DotNetBar.ButtonItem btnSampling;

		// Token: 0x04000309 RID: 777
		private global::DevComponents.DotNetBar.ButtonItem btnAnalysis;

		// Token: 0x0400030A RID: 778
		private global::DevComponents.DotNetBar.ButtonItem btnConfirm;

		// Token: 0x0400030B RID: 779
		private global::System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;

		// Token: 0x0400030C RID: 780
		private global::System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;

		// Token: 0x0400030D RID: 781
		private global::System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;

		// Token: 0x0400030E RID: 782
		private global::System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;

		// Token: 0x0400030F RID: 783
		private global::System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;

		// Token: 0x04000310 RID: 784
		private global::System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;

		// Token: 0x04000311 RID: 785
		private global::System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;

		// Token: 0x04000312 RID: 786
		private global::DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn dataGridViewDoubleInputColumn1;

		// Token: 0x04000313 RID: 787
		private global::System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;

		// Token: 0x04000314 RID: 788
		private global::System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;

		// Token: 0x04000315 RID: 789
		private global::System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;

		// Token: 0x04000316 RID: 790
		private global::System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;

		// Token: 0x04000317 RID: 791
		private global::System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;

		// Token: 0x04000318 RID: 792
		private global::System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;

		// Token: 0x04000319 RID: 793
		private global::System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;

		// Token: 0x0400031A RID: 794
		private global::System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;

		// Token: 0x0400031B RID: 795
		private global::DevComponents.DotNetBar.LabelItem lblTicketDanHao;

		// Token: 0x0400031C RID: 796
		private global::DevComponents.DotNetBar.CheckBoxItem cbxSpeech;

		// Token: 0x0400031D RID: 797
		private global::DevComponents.DotNetBar.ButtonItem btnRefresh;

		// Token: 0x0400031E RID: 798
		private global::DevComponents.DotNetBar.ButtonItem btnItemC;

		// Token: 0x0400031F RID: 799
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_Id;

		// Token: 0x04000320 RID: 800
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_DanHao;

		// Token: 0x04000321 RID: 801
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_BusinessType;

		// Token: 0x04000322 RID: 802
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_Product;

		// Token: 0x04000323 RID: 803
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_CheNum;

		// Token: 0x04000324 RID: 804
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_Unit;

		// Token: 0x04000325 RID: 805
		private global::DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn C_JiHuaLiang;

		// Token: 0x04000326 RID: 806
		private global::DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn C_ShiJiLiang;

		// Token: 0x04000327 RID: 807
		private global::DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn C_DifferWeight;

		// Token: 0x04000328 RID: 808
		private global::DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn C_JieSuanLiang;

		// Token: 0x04000329 RID: 809
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_DanWei;

		// Token: 0x0400032A RID: 810
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_OrderStatus;

		// Token: 0x0400032B RID: 811
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_LabStatus;

		// Token: 0x0400032C RID: 812
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_LabResult;

		// Token: 0x0400032D RID: 813
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_LabMan;

		// Token: 0x0400032E RID: 814
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_LabTime;

		// Token: 0x0400032F RID: 815
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_LabCount;

		// Token: 0x04000330 RID: 816
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_Remark;

		// Token: 0x04000331 RID: 817
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_ClientPart;

		// Token: 0x04000332 RID: 818
		private global::System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;

		// Token: 0x04000333 RID: 819
		private global::System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;

		// Token: 0x04000334 RID: 820
		private global::System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;

		// Token: 0x04000335 RID: 821
		private global::System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;

		// Token: 0x04000336 RID: 822
		private global::System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;

		// Token: 0x04000337 RID: 823
		private global::System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;

		// Token: 0x04000338 RID: 824
		private global::DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn Column1;

		// Token: 0x04000339 RID: 825
		private global::DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn dataGridViewDoubleInputColumn6;

		// Token: 0x0400033A RID: 826
		private global::DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn dataGridViewDoubleInputColumn9;

		// Token: 0x0400033B RID: 827
		private global::DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn dataGridViewDoubleInputColumn2;

		// Token: 0x0400033C RID: 828
		private global::System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;

		// Token: 0x0400033D RID: 829
		private global::System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;

		// Token: 0x0400033E RID: 830
		private global::System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;

		// Token: 0x0400033F RID: 831
		private global::System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;

		// Token: 0x04000340 RID: 832
		private global::System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;

		// Token: 0x04000341 RID: 833
		private global::System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn28;

		// Token: 0x04000342 RID: 834
		private global::System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn29;

		// Token: 0x04000343 RID: 835
		private global::System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn30;

		// Token: 0x04000344 RID: 836
		private global::System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn31;
	}
}
