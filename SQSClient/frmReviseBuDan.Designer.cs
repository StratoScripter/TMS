namespace SQSClient
{
	// Token: 0x02000013 RID: 19
	public partial class frmReviseBuDan : global::SQSClient.BaseDialogForm
	{
		// Token: 0x060000BA RID: 186 RVA: 0x0001583C File Offset: 0x00013A3C
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00015874 File Offset: 0x00013A74
		private void InitializeComponent()
		{
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new global::System.Windows.Forms.DataGridViewCellStyle();
			this.layoutControlItem5 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem19 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem22 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.splitContainer1 = new global::System.Windows.Forms.SplitContainer();
			this.groupPanel3 = new global::DevComponents.DotNetBar.Controls.GroupPanel();
			this.layoutControl1 = new global::DevComponents.DotNetBar.Layout.LayoutControl();
			this.btnCard = new global::DevComponents.DotNetBar.ButtonX();
			this.txtCardNum = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.layoutControlItem2 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem8 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.gPanelContract = new global::DevComponents.DotNetBar.Controls.GroupPanel();
			this.layoutControl2 = new global::DevComponents.DotNetBar.Layout.LayoutControl();
			this.txtProduct = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.cmbBusinessType = new global::Base.AutoComboBox();
			this.txtContractNum = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.cmbClientpart = new global::Base.AutoComboBox();
			this.cmbSettlepart = new global::Base.AutoComboBox();
			this.layoutControlItem11 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem1 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem16 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem3 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem10 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.dgvData = new global::DevComponents.DotNetBar.Controls.DataGridViewX();
			this.bar = new global::DevComponents.DotNetBar.Bar();
			this.btnSave = new global::DevComponents.DotNetBar.ButtonItem();
			this.btnItemC = new global::DevComponents.DotNetBar.ButtonItem();
			this.C_DanHao = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_CheNum = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_CangNum = new global::DevComponents.DotNetBar.Controls.DataGridViewIntegerInputColumn();
			this.C_Product = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_UnitName = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_DanWei = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_NetWeight = new global::DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn();
			this.C_JiHuaLiang = new global::DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn();
			this.C_ShiJiLiang = new global::DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn();
			this.C_XianQianLiang = new global::DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn();
			this.C_Status = new global::DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn();
			((global::System.ComponentModel.ISupportInitialize)this.splitContainer1).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.groupPanel3.SuspendLayout();
			this.layoutControl1.SuspendLayout();
			this.gPanelContract.SuspendLayout();
			this.layoutControl2.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvData).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.bar).BeginInit();
			base.SuspendLayout();
			this.layoutControlItem5.Height = 29;
			this.layoutControlItem5.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem5.Name = "layoutControlItem5";
			this.layoutControlItem5.Text = "总应发量：";
			this.layoutControlItem5.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem5.Width = 50;
			this.layoutControlItem5.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem19.Height = 29;
			this.layoutControlItem19.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem19.Name = "layoutControlItem19";
			this.layoutControlItem19.Text = "备注：";
			this.layoutControlItem19.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem19.Width = 100;
			this.layoutControlItem19.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem22.Height = 29;
			this.layoutControlItem22.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem22.Name = "layoutControlItem22";
			this.layoutControlItem22.Text = "本单舱数：";
			this.layoutControlItem22.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem22.Width = 37;
			this.layoutControlItem22.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.splitContainer1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new global::System.Drawing.Point(0, 26);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = global::System.Windows.Forms.Orientation.Horizontal;
			this.splitContainer1.Panel1.Controls.Add(this.groupPanel3);
			this.splitContainer1.Panel1.Controls.Add(this.gPanelContract);
			this.splitContainer1.Panel2.Controls.Add(this.dgvData);
			this.splitContainer1.Size = new global::System.Drawing.Size(974, 486);
			this.splitContainer1.SplitterDistance = 168;
			this.splitContainer1.TabIndex = 17;
			this.groupPanel3.BackColor = global::System.Drawing.Color.Transparent;
			this.groupPanel3.CanvasColor = global::System.Drawing.SystemColors.Control;
			this.groupPanel3.ColorSchemeStyle = global::DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
			this.groupPanel3.Controls.Add(this.layoutControl1);
			this.groupPanel3.DisabledBackColor = global::System.Drawing.Color.Empty;
			this.groupPanel3.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.groupPanel3.DrawTitleBox = false;
			this.groupPanel3.Location = new global::System.Drawing.Point(328, 0);
			this.groupPanel3.Name = "groupPanel3";
			this.groupPanel3.Size = new global::System.Drawing.Size(328, 168);
			this.groupPanel3.Style.BackColor = global::System.Drawing.Color.Transparent;
			this.groupPanel3.Style.BackColor2 = global::System.Drawing.Color.Transparent;
			this.groupPanel3.Style.BackColorGradientAngle = 90;
			this.groupPanel3.Style.BorderBottom = global::DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.groupPanel3.Style.BorderBottomWidth = 1;
			this.groupPanel3.Style.BorderColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
			this.groupPanel3.Style.BorderLeft = global::DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.groupPanel3.Style.BorderLeftWidth = 1;
			this.groupPanel3.Style.BorderRight = global::DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.groupPanel3.Style.BorderRightWidth = 1;
			this.groupPanel3.Style.BorderTop = global::DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.groupPanel3.Style.BorderTopWidth = 1;
			this.groupPanel3.Style.CornerDiameter = 4;
			this.groupPanel3.Style.CornerType = global::DevComponents.DotNetBar.eCornerType.Rounded;
			this.groupPanel3.Style.TextColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelText;
			this.groupPanel3.Style.TextLineAlignment = global::DevComponents.DotNetBar.eStyleTextAlignment.Near;
			this.groupPanel3.StyleMouseDown.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.groupPanel3.StyleMouseOver.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.groupPanel3.TabIndex = 26;
			this.groupPanel3.Text = "Others";
			this.layoutControl1.Controls.Add(this.btnCard);
			this.layoutControl1.Controls.Add(this.txtCardNum);
			this.layoutControl1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.layoutControl1.Location = new global::System.Drawing.Point(0, 0);
			this.layoutControl1.Name = "layoutControl1";
			this.layoutControl1.RootGroup.Items.AddRange(new global::DevComponents.DotNetBar.Layout.LayoutItemBase[]
			{
				this.layoutControlItem2,
				this.layoutControlItem8
			});
			this.layoutControl1.Size = new global::System.Drawing.Size(322, 146);
			this.layoutControl1.TabIndex = 24;
			this.btnCard.AccessibleRole = global::System.Windows.Forms.AccessibleRole.PushButton;
			this.btnCard.ColorTable = global::DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.btnCard.Location = new global::System.Drawing.Point(229, 4);
			this.btnCard.Margin = new global::System.Windows.Forms.Padding(0);
			this.btnCard.Name = "btnCard";
			this.btnCard.Size = new global::System.Drawing.Size(89, 23);
			this.btnCard.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.btnCard.TabIndex = 1;
			this.btnCard.Text = "ReadnSearch";
			this.btnCard.Click += new global::System.EventHandler(this.btnCard_Click);
			this.txtCardNum.Border.Class = "TextBoxBorder";
			this.txtCardNum.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtCardNum.Location = new global::System.Drawing.Point(24, 4);
			this.txtCardNum.Margin = new global::System.Windows.Forms.Padding(0);
			this.txtCardNum.Name = "txtCardNum";
			this.txtCardNum.PreventEnterBeep = true;
			this.txtCardNum.Size = new global::System.Drawing.Size(197, 21);
			this.txtCardNum.TabIndex = 0;
			this.layoutControlItem2.Control = this.txtCardNum;
			this.layoutControlItem2.Height = 29;
			this.layoutControlItem2.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem2.Name = "layoutControlItem2";
			this.layoutControlItem2.Text = "IC";
			this.layoutControlItem2.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem2.Width = 70;
			this.layoutControlItem2.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem8.Control = this.btnCard;
			this.layoutControlItem8.Height = 31;
			this.layoutControlItem8.MinSize = new global::System.Drawing.Size(32, 20);
			this.layoutControlItem8.Name = "layoutControlItem8";
			this.layoutControlItem8.Width = 30;
			this.layoutControlItem8.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.gPanelContract.BackColor = global::System.Drawing.Color.Transparent;
			this.gPanelContract.CanvasColor = global::System.Drawing.SystemColors.Control;
			this.gPanelContract.ColorSchemeStyle = global::DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
			this.gPanelContract.Controls.Add(this.layoutControl2);
			this.gPanelContract.DisabledBackColor = global::System.Drawing.Color.Empty;
			this.gPanelContract.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.gPanelContract.DrawTitleBox = false;
			this.gPanelContract.Location = new global::System.Drawing.Point(0, 0);
			this.gPanelContract.Name = "gPanelContract";
			this.gPanelContract.Size = new global::System.Drawing.Size(328, 168);
			this.gPanelContract.Style.BackColor = global::System.Drawing.Color.Transparent;
			this.gPanelContract.Style.BackColor2 = global::System.Drawing.Color.Transparent;
			this.gPanelContract.Style.BackColorGradientAngle = 90;
			this.gPanelContract.Style.BorderBottom = global::DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.gPanelContract.Style.BorderBottomWidth = 1;
			this.gPanelContract.Style.BorderColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
			this.gPanelContract.Style.BorderLeft = global::DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.gPanelContract.Style.BorderLeftWidth = 1;
			this.gPanelContract.Style.BorderRight = global::DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.gPanelContract.Style.BorderRightWidth = 1;
			this.gPanelContract.Style.BorderTop = global::DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.gPanelContract.Style.BorderTopWidth = 1;
			this.gPanelContract.Style.CornerDiameter = 4;
			this.gPanelContract.Style.CornerType = global::DevComponents.DotNetBar.eCornerType.Rounded;
			this.gPanelContract.Style.TextColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelText;
			this.gPanelContract.Style.TextLineAlignment = global::DevComponents.DotNetBar.eStyleTextAlignment.Near;
			this.gPanelContract.StyleMouseDown.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.gPanelContract.StyleMouseOver.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.gPanelContract.TabIndex = 25;
			this.gPanelContract.Text = "Contract";
			this.layoutControl2.Controls.Add(this.txtProduct);
			this.layoutControl2.Controls.Add(this.cmbBusinessType);
			this.layoutControl2.Controls.Add(this.txtContractNum);
			this.layoutControl2.Controls.Add(this.cmbClientpart);
			this.layoutControl2.Controls.Add(this.cmbSettlepart);
			this.layoutControl2.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.layoutControl2.Location = new global::System.Drawing.Point(0, 0);
			this.layoutControl2.Name = "layoutControl2";
			this.layoutControl2.RootGroup.Items.AddRange(new global::DevComponents.DotNetBar.Layout.LayoutItemBase[]
			{
				this.layoutControlItem11,
				this.layoutControlItem1,
				this.layoutControlItem16,
				this.layoutControlItem3,
				this.layoutControlItem10
			});
			this.layoutControl2.Size = new global::System.Drawing.Size(322, 146);
			this.layoutControl2.TabIndex = 0;
			this.txtProduct.Border.Class = "TextBoxBorder";
			this.txtProduct.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtProduct.Enabled = false;
			this.txtProduct.Location = new global::System.Drawing.Point(92, 120);
			this.txtProduct.Margin = new global::System.Windows.Forms.Padding(0);
			this.txtProduct.Name = "txtProduct";
			this.txtProduct.PreventEnterBeep = true;
			this.txtProduct.Size = new global::System.Drawing.Size(226, 21);
			this.txtProduct.TabIndex = 4;
			this.cmbBusinessType.DataSource = null;
			this.cmbBusinessType.DisplayMember = null;
			this.cmbBusinessType.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cmbBusinessType.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbBusinessType.FormattingEnabled = true;
			this.cmbBusinessType.ItemHeight = 16;
			this.cmbBusinessType.Location = new global::System.Drawing.Point(92, 33);
			this.cmbBusinessType.Margin = new global::System.Windows.Forms.Padding(0);
			this.cmbBusinessType.MaxDropDownItems = 20;
			this.cmbBusinessType.Name = "cmbBusinessType";
			this.cmbBusinessType.SelectMember = null;
			this.cmbBusinessType.Size = new global::System.Drawing.Size(226, 22);
			this.cmbBusinessType.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.cmbBusinessType.TabIndex = 1;
			this.cmbBusinessType.ValueMember = null;
			this.txtContractNum.Border.Class = "TextBoxBorder";
			this.txtContractNum.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtContractNum.Location = new global::System.Drawing.Point(92, 4);
			this.txtContractNum.Margin = new global::System.Windows.Forms.Padding(0);
			this.txtContractNum.Name = "txtContractNum";
			this.txtContractNum.PreventEnterBeep = true;
			this.txtContractNum.Size = new global::System.Drawing.Size(226, 21);
			this.txtContractNum.TabIndex = 0;
			this.txtContractNum.TextChanged += new global::System.EventHandler(this.txtContractNum_TextChanged);
			this.cmbClientpart.DataSource = null;
			this.cmbClientpart.DisplayMember = null;
			this.cmbClientpart.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cmbClientpart.FormattingEnabled = true;
			this.cmbClientpart.ItemHeight = 15;
			this.cmbClientpart.Location = new global::System.Drawing.Point(92, 62);
			this.cmbClientpart.Margin = new global::System.Windows.Forms.Padding(0);
			this.cmbClientpart.MaxDropDownItems = 20;
			this.cmbClientpart.Name = "cmbClientpart";
			this.cmbClientpart.SelectMember = null;
			this.cmbClientpart.Size = new global::System.Drawing.Size(226, 21);
			this.cmbClientpart.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.cmbClientpart.TabIndex = 2;
			this.cmbClientpart.ValueMember = null;
			this.cmbSettlepart.DataSource = null;
			this.cmbSettlepart.DisplayMember = null;
			this.cmbSettlepart.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cmbSettlepart.FormattingEnabled = true;
			this.cmbSettlepart.ItemHeight = 15;
			this.cmbSettlepart.Location = new global::System.Drawing.Point(92, 91);
			this.cmbSettlepart.Margin = new global::System.Windows.Forms.Padding(0);
			this.cmbSettlepart.MaxDropDownItems = 20;
			this.cmbSettlepart.Name = "cmbSettlepart";
			this.cmbSettlepart.SelectMember = null;
			this.cmbSettlepart.Size = new global::System.Drawing.Size(226, 21);
			this.cmbSettlepart.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.cmbSettlepart.TabIndex = 3;
			this.cmbSettlepart.ValueMember = null;
			this.layoutControlItem11.Control = this.txtContractNum;
			this.layoutControlItem11.Height = 29;
			this.layoutControlItem11.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem11.Name = "layoutControlItem11";
			this.layoutControlItem11.Text = "ContractID";
			this.layoutControlItem11.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem11.Width = 100;
			this.layoutControlItem11.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem1.Control = this.cmbBusinessType;
			this.layoutControlItem1.Height = 29;
			this.layoutControlItem1.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Text = "*BusinessType";
			this.layoutControlItem1.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem1.Width = 100;
			this.layoutControlItem1.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem16.Control = this.cmbClientpart;
			this.layoutControlItem16.Height = 29;
			this.layoutControlItem16.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem16.Name = "layoutControlItem16";
			this.layoutControlItem16.Text = "*Clientpart";
			this.layoutControlItem16.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem16.Width = 100;
			this.layoutControlItem16.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem3.Control = this.cmbSettlepart;
			this.layoutControlItem3.Height = 29;
			this.layoutControlItem3.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem3.Name = "layoutControlItem3";
			this.layoutControlItem3.Text = "*Settlepart";
			this.layoutControlItem3.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem3.Width = 100;
			this.layoutControlItem3.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem10.Control = this.txtProduct;
			this.layoutControlItem10.Height = 29;
			this.layoutControlItem10.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem10.Name = "layoutControlItem10";
			this.layoutControlItem10.Text = "Product";
			this.layoutControlItem10.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem10.Width = 100;
			this.layoutControlItem10.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.dgvData.AllowUserToAddRows = false;
			this.dgvData.AllowUserToDeleteRows = false;
			this.dgvData.AutoSizeColumnsMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvData.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvData.Columns.AddRange(new global::System.Windows.Forms.DataGridViewColumn[]
			{
				this.C_DanHao,
				this.C_CheNum,
				this.C_CangNum,
				this.C_Product,
				this.C_UnitName,
				this.C_DanWei,
				this.C_NetWeight,
				this.C_JiHuaLiang,
				this.C_ShiJiLiang,
				this.C_XianQianLiang,
				this.C_Status
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
			this.dgvData.GridColor = global::System.Drawing.Color.FromArgb(208, 215, 229);
			this.dgvData.Location = new global::System.Drawing.Point(0, 0);
			this.dgvData.Name = "dgvData";
			this.dgvData.RowTemplate.Height = 23;
			this.dgvData.Size = new global::System.Drawing.Size(974, 314);
			this.dgvData.TabIndex = 29;
			this.dgvData.CellEndEdit += new global::System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellEndEdit);
			this.dgvData.CellLeave += new global::System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellLeave);
			this.dgvData.EditingControlShowing += new global::System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvData_EditingControlShowing);
			this.dgvData.RowPostPaint += new global::System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvData_RowPostPaint);
			this.bar.AccessibleDescription = "DotNetBar Bar (bar)";
			this.bar.AccessibleName = "DotNetBar Bar";
			this.bar.AccessibleRole = global::System.Windows.Forms.AccessibleRole.MenuBar;
			this.bar.BackColor = global::System.Drawing.Color.Transparent;
			this.bar.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.bar.Font = new global::System.Drawing.Font("微软雅黑", 9f);
			this.bar.IsMaximized = false;
			this.bar.Items.AddRange(new global::DevComponents.DotNetBar.BaseItem[]
			{
				this.btnSave,
				this.btnItemC
			});
			this.bar.Location = new global::System.Drawing.Point(0, 0);
			this.bar.MenuBar = true;
			this.bar.Name = "bar";
			this.bar.Size = new global::System.Drawing.Size(974, 26);
			this.bar.Stretch = true;
			this.bar.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.bar.TabIndex = 16;
			this.bar.TabStop = false;
			this.bar.Text = "Main Menu";
			this.btnSave.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.btnSave.Image = global::SQSClient.Properties.Resources.save16;
			this.btnSave.Name = "btnSave";
			this.btnSave.Text = "Save";
			this.btnSave.Click += new global::System.EventHandler(this.btnSave_Click);
			this.btnItemC.ItemAlignment = global::DevComponents.DotNetBar.eItemAlignment.Far;
			this.btnItemC.Name = "btnItemC";
			this.btnItemC.Text = "ItemC";
			this.btnItemC.Click += new global::System.EventHandler(this.btnItemC_Click);
			this.C_DanHao.DataPropertyName = "DanHao";
			this.C_DanHao.HeaderText = "DanHao";
			this.C_DanHao.Name = "C_DanHao";
			this.C_DanHao.ReadOnly = true;
			this.C_CheNum.DataPropertyName = "Lisence";
			this.C_CheNum.HeaderText = "CheNum";
			this.C_CheNum.Name = "C_CheNum";
			this.C_CheNum.ReadOnly = true;
			this.C_CangNum.BackgroundStyle.BackColor = global::System.Drawing.SystemColors.Window;
			this.C_CangNum.BackgroundStyle.Class = "DataGridViewNumericBorder";
			this.C_CangNum.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.C_CangNum.BackgroundStyle.TextColor = global::System.Drawing.SystemColors.ControlText;
			this.C_CangNum.DataPropertyName = "CangNum";
			this.C_CangNum.HeaderText = "CangNum";
			this.C_CangNum.InputHorizontalAlignment = global::DevComponents.Editors.eHorizontalAlignment.Left;
			this.C_CangNum.MinValue = 1;
			this.C_CangNum.Name = "C_CangNum";
			this.C_CangNum.ReadOnly = true;
			this.C_CangNum.Resizable = global::System.Windows.Forms.DataGridViewTriState.True;
			this.C_Product.DataPropertyName = "ProductName";
			this.C_Product.HeaderText = "Product";
			this.C_Product.Name = "C_Product";
			this.C_Product.ReadOnly = true;
			this.C_UnitName.DataPropertyName = "UnitName";
			dataGridViewCellStyle2.BackColor = global::System.Drawing.Color.FromArgb(128, 255, 128);
			this.C_UnitName.DefaultCellStyle = dataGridViewCellStyle2;
			this.C_UnitName.HeaderText = "Unit";
			this.C_UnitName.Name = "C_UnitName";
			this.C_DanWei.DataPropertyName = "DanWei";
			this.C_DanWei.HeaderText = "DanWei";
			this.C_DanWei.Name = "C_DanWei";
			this.C_DanWei.ReadOnly = true;
			this.C_NetWeight.BackgroundStyle.BackColor = global::System.Drawing.SystemColors.Window;
			this.C_NetWeight.BackgroundStyle.Class = "DataGridViewNumericBorder";
			this.C_NetWeight.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.C_NetWeight.BackgroundStyle.TextColor = global::System.Drawing.SystemColors.ControlText;
			this.C_NetWeight.DataPropertyName = "NetWeight";
			this.C_NetWeight.HeaderText = "NetWeight";
			this.C_NetWeight.Increment = 1.0;
			this.C_NetWeight.InputHorizontalAlignment = global::DevComponents.Editors.eHorizontalAlignment.Left;
			this.C_NetWeight.MinValue = 0.0;
			this.C_NetWeight.Name = "C_NetWeight";
			this.C_NetWeight.ReadOnly = true;
			this.C_JiHuaLiang.BackgroundStyle.BackColor = global::System.Drawing.SystemColors.Window;
			this.C_JiHuaLiang.BackgroundStyle.Class = "DataGridViewNumericBorder";
			this.C_JiHuaLiang.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.C_JiHuaLiang.BackgroundStyle.TextColor = global::System.Drawing.SystemColors.ControlText;
			this.C_JiHuaLiang.DataPropertyName = "JiHuaLiang";
			this.C_JiHuaLiang.HeaderText = "JiHuaLiang";
			this.C_JiHuaLiang.Increment = 1.0;
			this.C_JiHuaLiang.InputHorizontalAlignment = global::DevComponents.Editors.eHorizontalAlignment.Left;
			this.C_JiHuaLiang.MinValue = 0.0;
			this.C_JiHuaLiang.Name = "C_JiHuaLiang";
			this.C_JiHuaLiang.ReadOnly = true;
			this.C_JiHuaLiang.Resizable = global::System.Windows.Forms.DataGridViewTriState.True;
			this.C_ShiJiLiang.BackgroundStyle.BackColor = global::System.Drawing.SystemColors.Window;
			this.C_ShiJiLiang.BackgroundStyle.Class = "DataGridViewNumericBorder";
			this.C_ShiJiLiang.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.C_ShiJiLiang.BackgroundStyle.TextColor = global::System.Drawing.SystemColors.ControlText;
			this.C_ShiJiLiang.DataPropertyName = "ShiJiLiang";
			dataGridViewCellStyle3.BackColor = global::System.Drawing.Color.FromArgb(128, 255, 128);
			this.C_ShiJiLiang.DefaultCellStyle = dataGridViewCellStyle3;
			this.C_ShiJiLiang.HeaderText = "ShiJiLiang";
			this.C_ShiJiLiang.Increment = 1.0;
			this.C_ShiJiLiang.InputHorizontalAlignment = global::DevComponents.Editors.eHorizontalAlignment.Left;
			this.C_ShiJiLiang.Name = "C_ShiJiLiang";
			this.C_XianQianLiang.BackgroundStyle.BackColor = global::System.Drawing.SystemColors.Window;
			this.C_XianQianLiang.BackgroundStyle.Class = "DataGridViewNumericBorder";
			this.C_XianQianLiang.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.C_XianQianLiang.BackgroundStyle.TextColor = global::System.Drawing.SystemColors.ControlText;
			this.C_XianQianLiang.DataPropertyName = "XianQianLiang";
			dataGridViewCellStyle4.BackColor = global::System.Drawing.Color.FromArgb(128, 255, 128);
			this.C_XianQianLiang.DefaultCellStyle = dataGridViewCellStyle4;
			this.C_XianQianLiang.HeaderText = "XianQianLiang";
			this.C_XianQianLiang.Increment = 1.0;
			this.C_XianQianLiang.InputHorizontalAlignment = global::DevComponents.Editors.eHorizontalAlignment.Left;
			this.C_XianQianLiang.Name = "C_XianQianLiang";
			this.C_Status.DataPropertyName = "Status";
			dataGridViewCellStyle5.BackColor = global::System.Drawing.Color.FromArgb(128, 255, 128);
			this.C_Status.DefaultCellStyle = dataGridViewCellStyle5;
			this.C_Status.DropDownHeight = 106;
			this.C_Status.DropDownWidth = 121;
			this.C_Status.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.C_Status.HeaderText = "OrderStatus";
			this.C_Status.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.C_Status.IntegralHeight = false;
			this.C_Status.ItemHeight = 16;
			this.C_Status.Name = "C_Status";
			this.C_Status.Resizable = global::System.Windows.Forms.DataGridViewTriState.True;
			this.C_Status.RightToLeft = global::System.Windows.Forms.RightToLeft.No;
			base.ClientSize = new global::System.Drawing.Size(974, 512);
			base.Controls.Add(this.splitContainer1);
			base.Controls.Add(this.bar);
			base.Name = "frmReviseBuDan";
			this.Text = "frmReviseBuDan";
			base.Load += new global::System.EventHandler(this.frmReviseBuDan_Load);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.splitContainer1).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.groupPanel3.ResumeLayout(false);
			this.layoutControl1.ResumeLayout(false);
			this.gPanelContract.ResumeLayout(false);
			this.layoutControl2.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.dgvData).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.bar).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x0400015C RID: 348
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400015D RID: 349
		private global::DevComponents.DotNetBar.Bar bar;

		// Token: 0x0400015E RID: 350
		private global::DevComponents.DotNetBar.ButtonItem btnSave;

		// Token: 0x0400015F RID: 351
		private global::System.Windows.Forms.SplitContainer splitContainer1;

		// Token: 0x04000160 RID: 352
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem5;

		// Token: 0x04000161 RID: 353
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem19;

		// Token: 0x04000162 RID: 354
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem22;

		// Token: 0x04000163 RID: 355
		private global::DevComponents.DotNetBar.Controls.DataGridViewX dgvData;

		// Token: 0x04000164 RID: 356
		private global::DevComponents.DotNetBar.Controls.GroupPanel gPanelContract;

		// Token: 0x04000165 RID: 357
		private global::DevComponents.DotNetBar.Layout.LayoutControl layoutControl2;

		// Token: 0x04000166 RID: 358
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtProduct;

		// Token: 0x04000167 RID: 359
		private global::Base.AutoComboBox cmbBusinessType;

		// Token: 0x04000168 RID: 360
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtContractNum;

		// Token: 0x04000169 RID: 361
		private global::Base.AutoComboBox cmbClientpart;

		// Token: 0x0400016A RID: 362
		private global::Base.AutoComboBox cmbSettlepart;

		// Token: 0x0400016B RID: 363
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem11;

		// Token: 0x0400016C RID: 364
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem1;

		// Token: 0x0400016D RID: 365
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem16;

		// Token: 0x0400016E RID: 366
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem3;

		// Token: 0x0400016F RID: 367
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem10;

		// Token: 0x04000170 RID: 368
		private global::DevComponents.DotNetBar.Controls.GroupPanel groupPanel3;

		// Token: 0x04000171 RID: 369
		private global::DevComponents.DotNetBar.Layout.LayoutControl layoutControl1;

		// Token: 0x04000172 RID: 370
		private global::DevComponents.DotNetBar.ButtonX btnCard;

		// Token: 0x04000173 RID: 371
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtCardNum;

		// Token: 0x04000174 RID: 372
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem2;

		// Token: 0x04000175 RID: 373
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem8;

		// Token: 0x04000176 RID: 374
		private global::DevComponents.DotNetBar.ButtonItem btnItemC;

		// Token: 0x04000177 RID: 375
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_DanHao;

		// Token: 0x04000178 RID: 376
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_CheNum;

		// Token: 0x04000179 RID: 377
		private global::DevComponents.DotNetBar.Controls.DataGridViewIntegerInputColumn C_CangNum;

		// Token: 0x0400017A RID: 378
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_Product;

		// Token: 0x0400017B RID: 379
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_UnitName;

		// Token: 0x0400017C RID: 380
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_DanWei;

		// Token: 0x0400017D RID: 381
		private global::DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn C_NetWeight;

		// Token: 0x0400017E RID: 382
		private global::DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn C_JiHuaLiang;

		// Token: 0x0400017F RID: 383
		private global::DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn C_ShiJiLiang;

		// Token: 0x04000180 RID: 384
		private global::DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn C_XianQianLiang;

		// Token: 0x04000181 RID: 385
		private global::DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn C_Status;
	}
}
