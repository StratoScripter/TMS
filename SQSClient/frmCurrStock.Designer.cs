namespace SQSClient
{
	// Token: 0x02000046 RID: 70
	public partial class frmCurrStock : global::SQSClient.BaseDialogForm
	{
		// Token: 0x06000325 RID: 805 RVA: 0x0004D99C File Offset: 0x0004BB9C
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000326 RID: 806 RVA: 0x0004D9D4 File Offset: 0x0004BBD4
		private void InitializeComponent()
		{
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::SQSClient.frmCurrStock));
			this.bar = new global::DevComponents.DotNetBar.Bar();
			this.line2 = new global::DevComponents.DotNetBar.Controls.Line();
			this.btnAdd = new global::DevComponents.DotNetBar.ButtonItem();
			this.btnModify = new global::DevComponents.DotNetBar.ButtonItem();
			this.btnDelete = new global::DevComponents.DotNetBar.ButtonItem();
			this.rdoStockDetails = new global::DevComponents.DotNetBar.CheckBoxItem();
			this.rdoBatchMerging = new global::DevComponents.DotNetBar.CheckBoxItem();
			this.controlContainerItem1 = new global::DevComponents.DotNetBar.ControlContainerItem();
			this.labProductInfo = new global::DevComponents.DotNetBar.LabelItem();
			this.txtProInfo = new global::DevComponents.DotNetBar.TextBoxItem();
			this.lblBatchInfo = new global::DevComponents.DotNetBar.LabelItem();
			this.txtBatchInfo = new global::DevComponents.DotNetBar.TextBoxItem();
			this.btnSearch = new global::DevComponents.DotNetBar.ButtonItem();
			this.btnExport = new global::DevComponents.DotNetBar.ButtonItem();
			this.dgvData = new global::DevComponents.DotNetBar.Controls.DataGridViewX();
			this.C_Id = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_WhCode = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_InvCode = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_ProductName = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_ProductCode = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_BatchNum = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_Quantity = new global::DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn();
			this.C_StopFlag = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_SpecsDanWei = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_MassDay = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			((global::System.ComponentModel.ISupportInitialize)this.bar).BeginInit();
			this.bar.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvData).BeginInit();
			base.SuspendLayout();
			this.bar.AntiAlias = true;
			this.bar.Controls.Add(this.line2);
			this.bar.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.bar.Font = new global::System.Drawing.Font("微软雅黑", 9f);
			this.bar.IsMaximized = false;
			this.bar.Items.AddRange(new global::DevComponents.DotNetBar.BaseItem[]
			{
				this.btnAdd,
				this.btnModify,
				this.btnDelete,
				this.rdoStockDetails,
				this.rdoBatchMerging,
				this.controlContainerItem1,
				this.labProductInfo,
				this.txtProInfo,
				this.lblBatchInfo,
				this.txtBatchInfo,
				this.btnSearch,
				this.btnExport
			});
			this.bar.Location = new global::System.Drawing.Point(0, 0);
			this.bar.Name = "bar";
			this.bar.Size = new global::System.Drawing.Size(1177, 27);
			this.bar.Stretch = true;
			this.bar.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.bar.TabIndex = 1;
			this.bar.TabStop = false;
			this.bar.Text = "bar1";
			this.line2.ForeColor = global::System.Drawing.SystemColors.ActiveCaption;
			this.line2.Location = new global::System.Drawing.Point(401, 3);
			this.line2.Name = "line2";
			this.line2.Size = new global::System.Drawing.Size(1, 20);
			this.line2.TabIndex = 17;
			this.line2.Text = "line2";
			this.line2.VerticalLine = true;
			this.btnAdd.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.btnAdd.Image = global::SQSClient.Properties.Resources.add16;
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Text = "Add";
			this.btnAdd.Visible = false;
			this.btnAdd.Click += new global::System.EventHandler(this.btnAdd_Click);
			this.btnModify.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.btnModify.Image = global::SQSClient.Properties.Resources.modify16;
			this.btnModify.Name = "btnModify";
			this.btnModify.Text = "Modify";
			this.btnModify.Visible = false;
			this.btnModify.Click += new global::System.EventHandler(this.btnModify_Click);
			this.btnDelete.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.btnDelete.Image = global::SQSClient.Properties.Resources.delete16;
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Text = "Delete";
			this.btnDelete.Visible = false;
			this.btnDelete.Click += new global::System.EventHandler(this.btnDelete_Click);
			this.rdoStockDetails.CheckBoxStyle = global::DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
			this.rdoStockDetails.Checked = true;
			this.rdoStockDetails.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.rdoStockDetails.Name = "rdoStockDetails";
			this.rdoStockDetails.Text = "StockDetails";
			this.rdoBatchMerging.CheckBoxStyle = global::DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
			this.rdoBatchMerging.Name = "rdoBatchMerging";
			this.rdoBatchMerging.Text = "BatchMerging";
			this.controlContainerItem1.AllowItemResize = false;
			this.controlContainerItem1.Control = this.line2;
			this.controlContainerItem1.MenuVisibility = global::DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
			this.controlContainerItem1.Name = "controlContainerItem1";
			this.labProductInfo.Name = "labProductInfo";
			this.labProductInfo.Text = "ProductInfo";
			this.txtProInfo.MaxLength = 20;
			this.txtProInfo.Name = "txtProInfo";
			this.txtProInfo.TextBoxWidth = 180;
			this.txtProInfo.WatermarkColor = global::System.Drawing.SystemColors.GrayText;
			this.txtProInfo.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
			this.lblBatchInfo.Name = "lblBatchInfo";
			this.lblBatchInfo.Text = "BatchInfo";
			this.txtBatchInfo.MaxLength = 20;
			this.txtBatchInfo.Name = "txtBatchInfo";
			this.txtBatchInfo.TextBoxWidth = 180;
			this.txtBatchInfo.WatermarkColor = global::System.Drawing.SystemColors.GrayText;
			this.txtBatchInfo.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.txtBatchInfo_KeyPress);
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
			this.dgvData.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvData.Columns.AddRange(new global::System.Windows.Forms.DataGridViewColumn[]
			{
				this.C_Id,
				this.C_WhCode,
				this.C_InvCode,
				this.C_ProductName,
				this.C_ProductCode,
				this.C_BatchNum,
				this.C_Quantity,
				this.C_StopFlag,
				this.C_SpecsDanWei,
				this.C_MassDay
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
			this.dgvData.Location = new global::System.Drawing.Point(0, 27);
			this.dgvData.Name = "dgvData";
			this.dgvData.ReadOnly = true;
			this.dgvData.RowHeadersVisible = false;
			this.dgvData.RowTemplate.Height = 23;
			this.dgvData.Size = new global::System.Drawing.Size(1177, 455);
			this.dgvData.TabIndex = 4;
			this.dgvData.CellClick += new global::System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellClick);
			this.dgvData.CellContentClick += new global::System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellContentClick);
			this.dgvData.CellDoubleClick += new global::System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellDoubleClick);
			this.C_Id.HeaderText = "ID";
			this.C_Id.Name = "C_Id";
			this.C_Id.ReadOnly = true;
			this.C_Id.Visible = false;
			this.C_WhCode.HeaderText = "WhCode";
			this.C_WhCode.Name = "C_WhCode";
			this.C_WhCode.ReadOnly = true;
			this.C_InvCode.HeaderText = "InvCode";
			this.C_InvCode.Name = "C_InvCode";
			this.C_InvCode.ReadOnly = true;
			this.C_ProductName.HeaderText = "ProductName";
			this.C_ProductName.Name = "C_ProductName";
			this.C_ProductName.ReadOnly = true;
			this.C_ProductCode.HeaderText = "ProductCode";
			this.C_ProductCode.Name = "C_ProductCode";
			this.C_ProductCode.ReadOnly = true;
			this.C_BatchNum.HeaderText = "BatchNum";
			this.C_BatchNum.Name = "C_BatchNum";
			this.C_BatchNum.ReadOnly = true;
			this.C_Quantity.BackgroundStyle.Class = "DataGridViewNumericBorder";
			this.C_Quantity.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.C_Quantity.HeaderText = "Quantity";
			this.C_Quantity.Increment = 1.0;
			this.C_Quantity.Name = "C_Quantity";
			this.C_Quantity.ReadOnly = true;
			this.C_StopFlag.HeaderText = "StopFlag";
			this.C_StopFlag.Name = "C_StopFlag";
			this.C_StopFlag.ReadOnly = true;
			this.C_SpecsDanWei.HeaderText = "SpecsDanWei";
			this.C_SpecsDanWei.Name = "C_SpecsDanWei";
			this.C_SpecsDanWei.ReadOnly = true;
			this.C_MassDay.HeaderText = "MassDay";
			this.C_MassDay.Name = "C_MassDay";
			this.C_MassDay.ReadOnly = true;
			base.ClientSize = new global::System.Drawing.Size(1177, 482);
			base.Controls.Add(this.dgvData);
			base.Controls.Add(this.bar);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "frmCurrStock";
			this.Text = "Product";
			base.Load += new global::System.EventHandler(this.frmCurrStock_Load);
			((global::System.ComponentModel.ISupportInitialize)this.bar).EndInit();
			this.bar.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.dgvData).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x040004E9 RID: 1257
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x040004EA RID: 1258
		private global::DevComponents.DotNetBar.Bar bar;

		// Token: 0x040004EB RID: 1259
		private global::DevComponents.DotNetBar.ButtonItem btnAdd;

		// Token: 0x040004EC RID: 1260
		private global::DevComponents.DotNetBar.ButtonItem btnModify;

		// Token: 0x040004ED RID: 1261
		private global::DevComponents.DotNetBar.ButtonItem btnDelete;

		// Token: 0x040004EE RID: 1262
		private global::DevComponents.DotNetBar.LabelItem labProductInfo;

		// Token: 0x040004EF RID: 1263
		private global::DevComponents.DotNetBar.TextBoxItem txtProInfo;

		// Token: 0x040004F0 RID: 1264
		private global::DevComponents.DotNetBar.ButtonItem btnSearch;

		// Token: 0x040004F1 RID: 1265
		private global::DevComponents.DotNetBar.Controls.Line line2;

		// Token: 0x040004F2 RID: 1266
		private global::DevComponents.DotNetBar.ControlContainerItem controlContainerItem1;

		// Token: 0x040004F3 RID: 1267
		private global::DevComponents.DotNetBar.Controls.DataGridViewX dgvData;

		// Token: 0x040004F4 RID: 1268
		private global::DevComponents.DotNetBar.LabelItem lblBatchInfo;

		// Token: 0x040004F5 RID: 1269
		private global::DevComponents.DotNetBar.TextBoxItem txtBatchInfo;

		// Token: 0x040004F6 RID: 1270
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_Id;

		// Token: 0x040004F7 RID: 1271
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_WhCode;

		// Token: 0x040004F8 RID: 1272
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_InvCode;

		// Token: 0x040004F9 RID: 1273
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_ProductName;

		// Token: 0x040004FA RID: 1274
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_ProductCode;

		// Token: 0x040004FB RID: 1275
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_BatchNum;

		// Token: 0x040004FC RID: 1276
		private global::DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn C_Quantity;

		// Token: 0x040004FD RID: 1277
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_StopFlag;

		// Token: 0x040004FE RID: 1278
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_SpecsDanWei;

		// Token: 0x040004FF RID: 1279
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_MassDay;

		// Token: 0x04000500 RID: 1280
		private global::DevComponents.DotNetBar.ButtonItem btnExport;

		// Token: 0x04000501 RID: 1281
		private global::DevComponents.DotNetBar.CheckBoxItem rdoStockDetails;

		// Token: 0x04000502 RID: 1282
		private global::DevComponents.DotNetBar.CheckBoxItem rdoBatchMerging;
	}
}
