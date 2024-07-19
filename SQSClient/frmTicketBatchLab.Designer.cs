namespace SQSClient
{
	// Token: 0x02000069 RID: 105
	public partial class frmTicketBatchLab : global::SQSClient.BaseDialogForm
	{
		// Token: 0x06000555 RID: 1365 RVA: 0x00086244 File Offset: 0x00084444
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000556 RID: 1366 RVA: 0x0008627C File Offset: 0x0008447C
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new global::System.Windows.Forms.DataGridViewCellStyle();
			this.gPanelToSample = new global::DevComponents.DotNetBar.Controls.GroupPanel();
			this.dgvData = new global::DevComponents.DotNetBar.Controls.DataGridViewX();
			this.bar = new global::DevComponents.DotNetBar.Bar();
			this.labMessage = new global::DevComponents.DotNetBar.LabelItem();
			this.btnSampling = new global::DevComponents.DotNetBar.ButtonItem();
			this.btnAnalysis = new global::DevComponents.DotNetBar.ButtonItem();
			this.btnLab = new global::DevComponents.DotNetBar.ButtonItem();
			this.btnConfirm = new global::DevComponents.DotNetBar.ButtonItem();
			this.timer = new global::System.Windows.Forms.Timer(this.components);
			this.gPanelPlan = new global::DevComponents.DotNetBar.Controls.GroupPanel();
			this.dgvDataPlan = new global::DevComponents.DotNetBar.Controls.DataGridViewX();
			this.dataGridViewTextBoxColumn1 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn7 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn9 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn11 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewDoubleInputColumn1 = new global::DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn();
			this.dataGridViewDoubleInputColumn3 = new global::DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn();
			this.dataGridViewDoubleInputColumn4 = new global::DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn();
			this.dataGridViewDoubleInputColumn5 = new global::DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn();
			this.dataGridViewTextBoxColumn12 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn13 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_BatchCodeDls = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_QuantityBatchDls = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn14 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn15 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn16 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn17 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn18 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn19 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn20 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn22 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_Id = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_DanHao = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_ContractID = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_BusinessType = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_Clientpart = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_CheNum = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_Unit = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_Product = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_JiHuaLiang = new global::DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn();
			this.C_ShiJiLiang = new global::DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn();
			this.C_FirstWeight = new global::DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn();
			this.C_SecondWeight = new global::DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn();
			this.C_DifferWeight = new global::DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn();
			this.C_DanWei = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_OrderStatus = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_BatchCode = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_QuantityBatch = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_LabStatus = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_LabResult = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_LabMan = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_LabTime = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_LabCount = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_ZhiDanRen = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_ZhiDanTime = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_Remark = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.gPanelToSample.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvData).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.bar).BeginInit();
			this.gPanelPlan.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvDataPlan).BeginInit();
			base.SuspendLayout();
			this.gPanelToSample.CanvasColor = global::System.Drawing.SystemColors.Control;
			this.gPanelToSample.ColorSchemeStyle = global::DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
			this.gPanelToSample.Controls.Add(this.dgvData);
			this.gPanelToSample.Controls.Add(this.bar);
			this.gPanelToSample.DisabledBackColor = global::System.Drawing.Color.Empty;
			this.gPanelToSample.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.gPanelToSample.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.gPanelToSample.Location = new global::System.Drawing.Point(0, 0);
			this.gPanelToSample.Name = "gPanelToSample";
			this.gPanelToSample.Size = new global::System.Drawing.Size(1409, 349);
			this.gPanelToSample.Style.BackColor2SchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
			this.gPanelToSample.Style.BackColorGradientAngle = 90;
			this.gPanelToSample.Style.BackColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
			this.gPanelToSample.Style.BorderBottom = global::DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.gPanelToSample.Style.BorderBottomWidth = 1;
			this.gPanelToSample.Style.BorderColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
			this.gPanelToSample.Style.BorderLeft = global::DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.gPanelToSample.Style.BorderLeftWidth = 1;
			this.gPanelToSample.Style.BorderRight = global::DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.gPanelToSample.Style.BorderRightWidth = 1;
			this.gPanelToSample.Style.BorderTop = global::DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.gPanelToSample.Style.BorderTopWidth = 1;
			this.gPanelToSample.Style.CornerDiameter = 4;
			this.gPanelToSample.Style.CornerType = global::DevComponents.DotNetBar.eCornerType.Rounded;
			this.gPanelToSample.Style.TextAlignment = global::DevComponents.DotNetBar.eStyleTextAlignment.Center;
			this.gPanelToSample.Style.TextColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelText;
			this.gPanelToSample.Style.TextLineAlignment = global::DevComponents.DotNetBar.eStyleTextAlignment.Near;
			this.gPanelToSample.StyleMouseDown.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.gPanelToSample.StyleMouseOver.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.gPanelToSample.TabIndex = 6;
			this.gPanelToSample.Text = "ToSample";
			this.dgvData.AllowUserToAddRows = false;
			this.dgvData.AllowUserToDeleteRows = false;
			this.dgvData.AllowUserToResizeRows = false;
			this.dgvData.AutoSizeColumnsMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
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
				this.C_ContractID,
				this.C_BusinessType,
				this.C_Clientpart,
				this.C_CheNum,
				this.C_Unit,
				this.C_Product,
				this.C_JiHuaLiang,
				this.C_ShiJiLiang,
				this.C_FirstWeight,
				this.C_SecondWeight,
				this.C_DifferWeight,
				this.C_DanWei,
				this.C_OrderStatus,
				this.C_BatchCode,
				this.C_QuantityBatch,
				this.C_LabStatus,
				this.C_LabResult,
				this.C_LabMan,
				this.C_LabTime,
				this.C_LabCount,
				this.C_ZhiDanRen,
				this.C_ZhiDanTime,
				this.C_Remark
			});
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
			this.dgvData.Location = new global::System.Drawing.Point(0, 27);
			this.dgvData.MultiSelect = false;
			this.dgvData.Name = "dgvData";
			this.dgvData.ReadOnly = true;
			this.dgvData.RowHeadersVisible = false;
			this.dgvData.RowTemplate.Height = 23;
			this.dgvData.SelectionMode = global::System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvData.Size = new global::System.Drawing.Size(1403, 300);
			this.dgvData.TabIndex = 18;
			this.dgvData.CellClick += new global::System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellClick);
			this.dgvData.CellDoubleClick += new global::System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellDoubleClick);
			this.bar.AntiAlias = true;
			this.bar.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.bar.DockSide = global::DevComponents.DotNetBar.eDockSide.Top;
			this.bar.Font = new global::System.Drawing.Font("微软雅黑", 9f);
			this.bar.IsMaximized = false;
			this.bar.Items.AddRange(new global::DevComponents.DotNetBar.BaseItem[]
			{
				this.labMessage,
				this.btnSampling,
				this.btnAnalysis,
				this.btnLab,
				this.btnConfirm
			});
			this.bar.Location = new global::System.Drawing.Point(0, 0);
			this.bar.Name = "bar";
			this.bar.Size = new global::System.Drawing.Size(1403, 27);
			this.bar.Stretch = true;
			this.bar.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.bar.TabIndex = 19;
			this.bar.TabStop = false;
			this.bar.Text = "bar1";
			this.labMessage.ForeColor = global::System.Drawing.Color.Red;
			this.labMessage.ItemAlignment = global::DevComponents.DotNetBar.eItemAlignment.Far;
			this.labMessage.Name = "labMessage";
			this.labMessage.Text = "        ";
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
			this.timer.Interval = 3000;
			this.timer.Tick += new global::System.EventHandler(this.timer_Tick);
			this.gPanelPlan.CanvasColor = global::System.Drawing.SystemColors.Control;
			this.gPanelPlan.ColorSchemeStyle = global::DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
			this.gPanelPlan.Controls.Add(this.dgvDataPlan);
			this.gPanelPlan.DisabledBackColor = global::System.Drawing.Color.Empty;
			this.gPanelPlan.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.gPanelPlan.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.gPanelPlan.Location = new global::System.Drawing.Point(0, 349);
			this.gPanelPlan.Name = "gPanelPlan";
			this.gPanelPlan.Size = new global::System.Drawing.Size(1409, 318);
			this.gPanelPlan.Style.BackColor2SchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
			this.gPanelPlan.Style.BackColorGradientAngle = 90;
			this.gPanelPlan.Style.BackColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
			this.gPanelPlan.Style.BorderBottom = global::DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.gPanelPlan.Style.BorderBottomWidth = 1;
			this.gPanelPlan.Style.BorderColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
			this.gPanelPlan.Style.BorderLeft = global::DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.gPanelPlan.Style.BorderLeftWidth = 1;
			this.gPanelPlan.Style.BorderRight = global::DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.gPanelPlan.Style.BorderRightWidth = 1;
			this.gPanelPlan.Style.BorderTop = global::DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.gPanelPlan.Style.BorderTopWidth = 1;
			this.gPanelPlan.Style.CornerDiameter = 4;
			this.gPanelPlan.Style.CornerType = global::DevComponents.DotNetBar.eCornerType.Rounded;
			this.gPanelPlan.Style.TextAlignment = global::DevComponents.DotNetBar.eStyleTextAlignment.Center;
			this.gPanelPlan.Style.TextColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelText;
			this.gPanelPlan.Style.TextLineAlignment = global::DevComponents.DotNetBar.eStyleTextAlignment.Near;
			this.gPanelPlan.StyleMouseDown.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.gPanelPlan.StyleMouseOver.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.gPanelPlan.TabIndex = 19;
			this.gPanelPlan.Text = "Plan";
			this.dgvDataPlan.AllowUserToAddRows = false;
			this.dgvDataPlan.AllowUserToDeleteRows = false;
			this.dgvDataPlan.AllowUserToResizeRows = false;
			this.dgvDataPlan.AutoSizeColumnsMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			dataGridViewCellStyle3.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.BackColor = global::System.Drawing.SystemColors.Control;
			dataGridViewCellStyle3.Font = new global::System.Drawing.Font("宋体", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 134);
			dataGridViewCellStyle3.ForeColor = global::System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = global::System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = global::System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = global::System.Windows.Forms.DataGridViewTriState.True;
			this.dgvDataPlan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.dgvDataPlan.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dgvDataPlan.Columns.AddRange(new global::System.Windows.Forms.DataGridViewColumn[]
			{
				this.dataGridViewTextBoxColumn1,
				this.dataGridViewTextBoxColumn2,
				this.dataGridViewTextBoxColumn3,
				this.dataGridViewTextBoxColumn4,
				this.dataGridViewTextBoxColumn5,
				this.dataGridViewTextBoxColumn7,
				this.dataGridViewTextBoxColumn9,
				this.dataGridViewTextBoxColumn11,
				this.dataGridViewDoubleInputColumn1,
				this.dataGridViewDoubleInputColumn3,
				this.dataGridViewDoubleInputColumn4,
				this.dataGridViewDoubleInputColumn5,
				this.dataGridViewTextBoxColumn12,
				this.dataGridViewTextBoxColumn13,
				this.C_BatchCodeDls,
				this.C_QuantityBatchDls,
				this.dataGridViewTextBoxColumn14,
				this.dataGridViewTextBoxColumn15,
				this.dataGridViewTextBoxColumn16,
				this.dataGridViewTextBoxColumn17,
				this.dataGridViewTextBoxColumn18,
				this.dataGridViewTextBoxColumn19,
				this.dataGridViewTextBoxColumn20,
				this.dataGridViewTextBoxColumn22
			});
			dataGridViewCellStyle4.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle4.BackColor = global::System.Drawing.SystemColors.Window;
			dataGridViewCellStyle4.Font = new global::System.Drawing.Font("宋体", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 134);
			dataGridViewCellStyle4.ForeColor = global::System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle4.SelectionBackColor = global::System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = global::System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle4.WrapMode = global::System.Windows.Forms.DataGridViewTriState.False;
			this.dgvDataPlan.DefaultCellStyle = dataGridViewCellStyle4;
			this.dgvDataPlan.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.dgvDataPlan.EnableHeadersVisualStyles = false;
			this.dgvDataPlan.GridColor = global::System.Drawing.Color.FromArgb(208, 215, 229);
			this.dgvDataPlan.Location = new global::System.Drawing.Point(0, 0);
			this.dgvDataPlan.MultiSelect = false;
			this.dgvDataPlan.Name = "dgvDataPlan";
			this.dgvDataPlan.ReadOnly = true;
			this.dgvDataPlan.RowHeadersVisible = false;
			this.dgvDataPlan.RowTemplate.Height = 23;
			this.dgvDataPlan.SelectionMode = global::System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvDataPlan.Size = new global::System.Drawing.Size(1403, 296);
			this.dgvDataPlan.TabIndex = 19;
			this.dataGridViewTextBoxColumn1.FillWeight = 82.8988f;
			this.dataGridViewTextBoxColumn1.HeaderText = "ID";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			this.dataGridViewTextBoxColumn1.Visible = false;
			this.dataGridViewTextBoxColumn2.FillWeight = 82.8988f;
			this.dataGridViewTextBoxColumn2.HeaderText = "DanHao";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.ReadOnly = true;
			this.dataGridViewTextBoxColumn3.HeaderText = "ContractID";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.ReadOnly = true;
			this.dataGridViewTextBoxColumn3.Visible = false;
			this.dataGridViewTextBoxColumn4.HeaderText = "BusinessType";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn4.ReadOnly = true;
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
			this.dataGridViewTextBoxColumn11.HeaderText = "Product";
			this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
			this.dataGridViewTextBoxColumn11.ReadOnly = true;
			this.dataGridViewDoubleInputColumn1.BackgroundStyle.Class = "DataGridViewNumericBorder";
			this.dataGridViewDoubleInputColumn1.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.dataGridViewDoubleInputColumn1.FillWeight = 82.8988f;
			this.dataGridViewDoubleInputColumn1.HeaderText = "JiHuaLiang";
			this.dataGridViewDoubleInputColumn1.Increment = 1.0;
			this.dataGridViewDoubleInputColumn1.InputHorizontalAlignment = global::DevComponents.Editors.eHorizontalAlignment.Left;
			this.dataGridViewDoubleInputColumn1.Name = "dataGridViewDoubleInputColumn1";
			this.dataGridViewDoubleInputColumn1.ReadOnly = true;
			this.dataGridViewDoubleInputColumn1.Resizable = global::System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewDoubleInputColumn3.BackgroundStyle.Class = "DataGridViewNumericBorder";
			this.dataGridViewDoubleInputColumn3.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.dataGridViewDoubleInputColumn3.HeaderText = "FirstWeight(kg)";
			this.dataGridViewDoubleInputColumn3.Increment = 1.0;
			this.dataGridViewDoubleInputColumn3.Name = "dataGridViewDoubleInputColumn3";
			this.dataGridViewDoubleInputColumn3.ReadOnly = true;
			this.dataGridViewDoubleInputColumn4.BackgroundStyle.Class = "DataGridViewNumericBorder";
			this.dataGridViewDoubleInputColumn4.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.dataGridViewDoubleInputColumn4.HeaderText = "SecondWeight(kg)";
			this.dataGridViewDoubleInputColumn4.Increment = 1.0;
			this.dataGridViewDoubleInputColumn4.Name = "dataGridViewDoubleInputColumn4";
			this.dataGridViewDoubleInputColumn4.ReadOnly = true;
			this.dataGridViewDoubleInputColumn5.BackgroundStyle.Class = "DataGridViewNumericBorder";
			this.dataGridViewDoubleInputColumn5.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.dataGridViewDoubleInputColumn5.HeaderText = "DifferWeight(kg)";
			this.dataGridViewDoubleInputColumn5.Increment = 1.0;
			this.dataGridViewDoubleInputColumn5.InputHorizontalAlignment = global::DevComponents.Editors.eHorizontalAlignment.Left;
			this.dataGridViewDoubleInputColumn5.Name = "dataGridViewDoubleInputColumn5";
			this.dataGridViewDoubleInputColumn5.ReadOnly = true;
			this.dataGridViewDoubleInputColumn5.Resizable = global::System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn12.HeaderText = "DanWei";
			this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
			this.dataGridViewTextBoxColumn12.ReadOnly = true;
			dataGridViewCellStyle5.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.dataGridViewTextBoxColumn13.DefaultCellStyle = dataGridViewCellStyle5;
			this.dataGridViewTextBoxColumn13.FillWeight = 82.8988f;
			this.dataGridViewTextBoxColumn13.HeaderText = "OrderStatus";
			this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
			this.dataGridViewTextBoxColumn13.ReadOnly = true;
			this.C_BatchCodeDls.HeaderText = "BatchCode";
			this.C_BatchCodeDls.Name = "C_BatchCodeDls";
			this.C_BatchCodeDls.ReadOnly = true;
			this.C_QuantityBatchDls.HeaderText = "QuantityBatch";
			this.C_QuantityBatchDls.Name = "C_QuantityBatchDls";
			this.C_QuantityBatchDls.ReadOnly = true;
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
			this.dataGridViewTextBoxColumn19.HeaderText = "ZhiDanRen";
			this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
			this.dataGridViewTextBoxColumn19.ReadOnly = true;
			this.dataGridViewTextBoxColumn20.FillWeight = 140.0862f;
			this.dataGridViewTextBoxColumn20.HeaderText = "ZhiDanTime";
			this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
			this.dataGridViewTextBoxColumn20.ReadOnly = true;
			this.dataGridViewTextBoxColumn22.HeaderText = "Remark";
			this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
			this.dataGridViewTextBoxColumn22.ReadOnly = true;
			this.dataGridViewTextBoxColumn22.Visible = false;
			this.C_Id.FillWeight = 82.8988f;
			this.C_Id.HeaderText = "ID";
			this.C_Id.Name = "C_Id";
			this.C_Id.ReadOnly = true;
			this.C_Id.Visible = false;
			this.C_DanHao.FillWeight = 82.8988f;
			this.C_DanHao.HeaderText = "DanHao";
			this.C_DanHao.Name = "C_DanHao";
			this.C_DanHao.ReadOnly = true;
			this.C_ContractID.HeaderText = "ContractID";
			this.C_ContractID.Name = "C_ContractID";
			this.C_ContractID.ReadOnly = true;
			this.C_ContractID.Visible = false;
			this.C_BusinessType.HeaderText = "BusinessType";
			this.C_BusinessType.Name = "C_BusinessType";
			this.C_BusinessType.ReadOnly = true;
			this.C_Clientpart.HeaderText = "Clientpart";
			this.C_Clientpart.Name = "C_Clientpart";
			this.C_Clientpart.ReadOnly = true;
			this.C_CheNum.FillWeight = 82.8988f;
			this.C_CheNum.HeaderText = "CheNum";
			this.C_CheNum.Name = "C_CheNum";
			this.C_CheNum.ReadOnly = true;
			this.C_Unit.HeaderText = "Unit";
			this.C_Unit.Name = "C_Unit";
			this.C_Unit.ReadOnly = true;
			this.C_Product.HeaderText = "Product";
			this.C_Product.Name = "C_Product";
			this.C_Product.ReadOnly = true;
			this.C_JiHuaLiang.BackgroundStyle.Class = "DataGridViewNumericBorder";
			this.C_JiHuaLiang.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.C_JiHuaLiang.FillWeight = 82.8988f;
			this.C_JiHuaLiang.HeaderText = "JiHuaLiang";
			this.C_JiHuaLiang.Increment = 1.0;
			this.C_JiHuaLiang.InputHorizontalAlignment = global::DevComponents.Editors.eHorizontalAlignment.Left;
			this.C_JiHuaLiang.Name = "C_JiHuaLiang";
			this.C_JiHuaLiang.ReadOnly = true;
			this.C_JiHuaLiang.Resizable = global::System.Windows.Forms.DataGridViewTriState.True;
			this.C_ShiJiLiang.BackgroundStyle.Class = "DataGridViewNumericBorder";
			this.C_ShiJiLiang.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.C_ShiJiLiang.FillWeight = 82.8988f;
			this.C_ShiJiLiang.HeaderText = "ShiJiLiang";
			this.C_ShiJiLiang.Increment = 1.0;
			this.C_ShiJiLiang.InputHorizontalAlignment = global::DevComponents.Editors.eHorizontalAlignment.Left;
			this.C_ShiJiLiang.Name = "C_ShiJiLiang";
			this.C_ShiJiLiang.ReadOnly = true;
			this.C_ShiJiLiang.Resizable = global::System.Windows.Forms.DataGridViewTriState.True;
			this.C_FirstWeight.BackgroundStyle.Class = "DataGridViewNumericBorder";
			this.C_FirstWeight.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.C_FirstWeight.HeaderText = "FirstWeight(kg)";
			this.C_FirstWeight.Increment = 1.0;
			this.C_FirstWeight.Name = "C_FirstWeight";
			this.C_FirstWeight.ReadOnly = true;
			this.C_SecondWeight.BackgroundStyle.Class = "DataGridViewNumericBorder";
			this.C_SecondWeight.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.C_SecondWeight.HeaderText = "SecondWeight(kg)";
			this.C_SecondWeight.Increment = 1.0;
			this.C_SecondWeight.Name = "C_SecondWeight";
			this.C_SecondWeight.ReadOnly = true;
			this.C_DifferWeight.BackgroundStyle.Class = "DataGridViewNumericBorder";
			this.C_DifferWeight.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.C_DifferWeight.HeaderText = "DifferWeight(kg)";
			this.C_DifferWeight.Increment = 1.0;
			this.C_DifferWeight.InputHorizontalAlignment = global::DevComponents.Editors.eHorizontalAlignment.Left;
			this.C_DifferWeight.Name = "C_DifferWeight";
			this.C_DifferWeight.ReadOnly = true;
			this.C_DifferWeight.Resizable = global::System.Windows.Forms.DataGridViewTriState.True;
			this.C_DanWei.HeaderText = "DanWei";
			this.C_DanWei.Name = "C_DanWei";
			this.C_DanWei.ReadOnly = true;
			dataGridViewCellStyle6.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.C_OrderStatus.DefaultCellStyle = dataGridViewCellStyle6;
			this.C_OrderStatus.FillWeight = 82.8988f;
			this.C_OrderStatus.HeaderText = "OrderStatus";
			this.C_OrderStatus.Name = "C_OrderStatus";
			this.C_OrderStatus.ReadOnly = true;
			this.C_BatchCode.HeaderText = "BatchCode";
			this.C_BatchCode.Name = "C_BatchCode";
			this.C_BatchCode.ReadOnly = true;
			this.C_QuantityBatch.HeaderText = "QuantityBatch";
			this.C_QuantityBatch.Name = "C_QuantityBatch";
			this.C_QuantityBatch.ReadOnly = true;
			this.C_LabStatus.HeaderText = "LabStatus";
			this.C_LabStatus.Name = "C_LabStatus";
			this.C_LabStatus.ReadOnly = true;
			this.C_LabResult.HeaderText = "LabResult";
			this.C_LabResult.Name = "C_LabResult";
			this.C_LabResult.ReadOnly = true;
			this.C_LabMan.HeaderText = "LabMan";
			this.C_LabMan.Name = "C_LabMan";
			this.C_LabMan.ReadOnly = true;
			this.C_LabTime.HeaderText = "LabTime";
			this.C_LabTime.Name = "C_LabTime";
			this.C_LabTime.ReadOnly = true;
			this.C_LabCount.HeaderText = "LabCount";
			this.C_LabCount.Name = "C_LabCount";
			this.C_LabCount.ReadOnly = true;
			this.C_ZhiDanRen.HeaderText = "ZhiDanRen";
			this.C_ZhiDanRen.Name = "C_ZhiDanRen";
			this.C_ZhiDanRen.ReadOnly = true;
			this.C_ZhiDanTime.FillWeight = 140.0862f;
			this.C_ZhiDanTime.HeaderText = "ZhiDanTime";
			this.C_ZhiDanTime.Name = "C_ZhiDanTime";
			this.C_ZhiDanTime.ReadOnly = true;
			this.C_Remark.HeaderText = "Remark";
			this.C_Remark.Name = "C_Remark";
			this.C_Remark.ReadOnly = true;
			this.C_Remark.Visible = false;
			base.ClientSize = new global::System.Drawing.Size(1409, 667);
			base.Controls.Add(this.gPanelPlan);
			base.Controls.Add(this.gPanelToSample);
			base.Name = "frmTicketBatchLab";
			this.Text = "frmTicketBatchLab";
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.frmTicketBatchLab_FormClosing);
			base.Load += new global::System.EventHandler(this.frmTicketBatchLab_Load);
			this.gPanelToSample.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.dgvData).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.bar).EndInit();
			this.gPanelPlan.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.dgvDataPlan).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000926 RID: 2342
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000927 RID: 2343
		private global::DevComponents.DotNetBar.Controls.GroupPanel gPanelToSample;

		// Token: 0x04000928 RID: 2344
		private global::System.Windows.Forms.Timer timer;

		// Token: 0x04000929 RID: 2345
		private global::DevComponents.DotNetBar.Controls.GroupPanel gPanelPlan;

		// Token: 0x0400092A RID: 2346
		private global::DevComponents.DotNetBar.Controls.DataGridViewX dgvData;

		// Token: 0x0400092B RID: 2347
		private global::DevComponents.DotNetBar.Controls.DataGridViewX dgvDataPlan;

		// Token: 0x0400092C RID: 2348
		private global::DevComponents.DotNetBar.Bar bar;

		// Token: 0x0400092D RID: 2349
		private global::DevComponents.DotNetBar.ButtonItem btnLab;

		// Token: 0x0400092E RID: 2350
		private global::DevComponents.DotNetBar.LabelItem labMessage;

		// Token: 0x0400092F RID: 2351
		private global::DevComponents.DotNetBar.ButtonItem btnSampling;

		// Token: 0x04000930 RID: 2352
		private global::DevComponents.DotNetBar.ButtonItem btnAnalysis;

		// Token: 0x04000931 RID: 2353
		private global::DevComponents.DotNetBar.ButtonItem btnConfirm;

		// Token: 0x04000932 RID: 2354
		private global::System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;

		// Token: 0x04000933 RID: 2355
		private global::System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;

		// Token: 0x04000934 RID: 2356
		private global::System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;

		// Token: 0x04000935 RID: 2357
		private global::System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;

		// Token: 0x04000936 RID: 2358
		private global::System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;

		// Token: 0x04000937 RID: 2359
		private global::System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;

		// Token: 0x04000938 RID: 2360
		private global::System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;

		// Token: 0x04000939 RID: 2361
		private global::System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;

		// Token: 0x0400093A RID: 2362
		private global::DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn dataGridViewDoubleInputColumn1;

		// Token: 0x0400093B RID: 2363
		private global::DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn dataGridViewDoubleInputColumn3;

		// Token: 0x0400093C RID: 2364
		private global::DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn dataGridViewDoubleInputColumn4;

		// Token: 0x0400093D RID: 2365
		private global::DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn dataGridViewDoubleInputColumn5;

		// Token: 0x0400093E RID: 2366
		private global::System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;

		// Token: 0x0400093F RID: 2367
		private global::System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;

		// Token: 0x04000940 RID: 2368
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_BatchCodeDls;

		// Token: 0x04000941 RID: 2369
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_QuantityBatchDls;

		// Token: 0x04000942 RID: 2370
		private global::System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;

		// Token: 0x04000943 RID: 2371
		private global::System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;

		// Token: 0x04000944 RID: 2372
		private global::System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;

		// Token: 0x04000945 RID: 2373
		private global::System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;

		// Token: 0x04000946 RID: 2374
		private global::System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;

		// Token: 0x04000947 RID: 2375
		private global::System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;

		// Token: 0x04000948 RID: 2376
		private global::System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;

		// Token: 0x04000949 RID: 2377
		private global::System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;

		// Token: 0x0400094A RID: 2378
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_Id;

		// Token: 0x0400094B RID: 2379
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_DanHao;

		// Token: 0x0400094C RID: 2380
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_ContractID;

		// Token: 0x0400094D RID: 2381
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_BusinessType;

		// Token: 0x0400094E RID: 2382
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_Clientpart;

		// Token: 0x0400094F RID: 2383
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_CheNum;

		// Token: 0x04000950 RID: 2384
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_Unit;

		// Token: 0x04000951 RID: 2385
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_Product;

		// Token: 0x04000952 RID: 2386
		private global::DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn C_JiHuaLiang;

		// Token: 0x04000953 RID: 2387
		private global::DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn C_ShiJiLiang;

		// Token: 0x04000954 RID: 2388
		private global::DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn C_FirstWeight;

		// Token: 0x04000955 RID: 2389
		private global::DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn C_SecondWeight;

		// Token: 0x04000956 RID: 2390
		private global::DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn C_DifferWeight;

		// Token: 0x04000957 RID: 2391
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_DanWei;

		// Token: 0x04000958 RID: 2392
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_OrderStatus;

		// Token: 0x04000959 RID: 2393
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_BatchCode;

		// Token: 0x0400095A RID: 2394
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_QuantityBatch;

		// Token: 0x0400095B RID: 2395
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_LabStatus;

		// Token: 0x0400095C RID: 2396
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_LabResult;

		// Token: 0x0400095D RID: 2397
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_LabMan;

		// Token: 0x0400095E RID: 2398
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_LabTime;

		// Token: 0x0400095F RID: 2399
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_LabCount;

		// Token: 0x04000960 RID: 2400
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_ZhiDanRen;

		// Token: 0x04000961 RID: 2401
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_ZhiDanTime;

		// Token: 0x04000962 RID: 2402
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_Remark;
	}
}
