namespace SQSClient
{
	// Token: 0x0200008C RID: 140
	public partial class frmProduct : global::SQSClient.BaseDialogForm
	{
		// Token: 0x060007B5 RID: 1973 RVA: 0x000BD7A4 File Offset: 0x000BB9A4
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060007B6 RID: 1974 RVA: 0x000BD7DC File Offset: 0x000BB9DC
		private void InitializeComponent()
		{
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::SQSClient.frmProduct));
			this.bar = new global::DevComponents.DotNetBar.Bar();
			this.line2 = new global::DevComponents.DotNetBar.Controls.Line();
			this.btnAdd = new global::DevComponents.DotNetBar.ButtonItem();
			this.btnModify = new global::DevComponents.DotNetBar.ButtonItem();
			this.btnDelete = new global::DevComponents.DotNetBar.ButtonItem();
			this.btnImport = new global::DevComponents.DotNetBar.ButtonItem();
			this.controlContainerItem1 = new global::DevComponents.DotNetBar.ControlContainerItem();
			this.labProductInfo = new global::DevComponents.DotNetBar.LabelItem();
			this.txtName = new global::DevComponents.DotNetBar.TextBoxItem();
			this.btnSearch = new global::DevComponents.DotNetBar.ButtonItem();
			this.btnImportProduct = new global::DevComponents.DotNetBar.ButtonItem();
			this.btnImportInvModel = new global::DevComponents.DotNetBar.ButtonItem();
			this.btnItemC = new global::DevComponents.DotNetBar.ButtonItem();
			this.dgvData = new global::DevComponents.DotNetBar.Controls.DataGridViewX();
			this.C_Id = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_InvCode = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_InvName = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_ProName = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_Code = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_MainInvCCode = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_SpecsDescribe = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_SunHao = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_MiDu = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_Type = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_ = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_PostType = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_State = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_PeiPang = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_HeWeiConfig = new global::System.Windows.Forms.DataGridViewImageColumn();
			this.C_InvModelName = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_Remark = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bar1 = new global::DevComponents.DotNetBar.Bar();
			this.cmbPage = new global::System.Windows.Forms.ComboBox();
			this.txtNowPage = new global::System.Windows.Forms.TextBox();
			this.labPage = new global::DevComponents.DotNetBar.LabelItem();
			this.controlContainerItem2 = new global::DevComponents.DotNetBar.ControlContainerItem();
			this.labItem = new global::DevComponents.DotNetBar.LabelItem();
			this.btn_pageup = new global::DevComponents.DotNetBar.ButtonItem();
			this.controlContainerItem5 = new global::DevComponents.DotNetBar.ControlContainerItem();
			this.labelItem1 = new global::DevComponents.DotNetBar.LabelItem();
			this.labPageCounts = new global::DevComponents.DotNetBar.LabelItem();
			this.btn_pagedown = new global::DevComponents.DotNetBar.ButtonItem();
			((global::System.ComponentModel.ISupportInitialize)this.bar).BeginInit();
			this.bar.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvData).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.bar1).BeginInit();
			this.bar1.SuspendLayout();
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
				this.btnImport,
				this.controlContainerItem1,
				this.labProductInfo,
				this.txtName,
				this.btnSearch,
				this.btnImportProduct,
				this.btnImportInvModel,
				this.btnItemC
			});
			this.bar.Location = new global::System.Drawing.Point(0, 0);
			this.bar.Name = "bar";
			this.bar.Size = new global::System.Drawing.Size(1221, 27);
			this.bar.Stretch = true;
			this.bar.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.bar.TabIndex = 1;
			this.bar.TabStop = false;
			this.bar.Text = "bar1";
			this.line2.ForeColor = global::System.Drawing.SystemColors.ActiveCaption;
			this.line2.Location = new global::System.Drawing.Point(266, 3);
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
			this.btnImport.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.btnImport.Image = global::SQSClient.Properties.Resources.modify16;
			this.btnImport.Name = "btnImport";
			this.btnImport.Text = "Import";
			this.btnImport.Visible = false;
			this.btnImport.Click += new global::System.EventHandler(this.btnImport_Click);
			this.controlContainerItem1.AllowItemResize = false;
			this.controlContainerItem1.Control = this.line2;
			this.controlContainerItem1.MenuVisibility = global::DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
			this.controlContainerItem1.Name = "controlContainerItem1";
			this.labProductInfo.Name = "labProductInfo";
			this.labProductInfo.Text = "ProductInfo";
			this.txtName.MaxLength = 20;
			this.txtName.Name = "txtName";
			this.txtName.TextBoxWidth = 220;
			this.txtName.WatermarkColor = global::System.Drawing.SystemColors.GrayText;
			this.txtName.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
			this.btnSearch.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.btnSearch.Image = global::SQSClient.Properties.Resources.search16;
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Text = "Search";
			this.btnSearch.Click += new global::System.EventHandler(this.btnSearch_Click);
			this.btnImportProduct.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.btnImportProduct.Image = global::SQSClient.Properties.Resources.modify16;
			this.btnImportProduct.ItemAlignment = global::DevComponents.DotNetBar.eItemAlignment.Far;
			this.btnImportProduct.Name = "btnImportProduct";
			this.btnImportProduct.Text = "ImportProduct";
			this.btnImportProduct.Visible = false;
			this.btnImportProduct.Click += new global::System.EventHandler(this.btnImportProduct_Click);
			this.btnImportInvModel.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.btnImportInvModel.Image = global::SQSClient.Properties.Resources.modify16;
			this.btnImportInvModel.ItemAlignment = global::DevComponents.DotNetBar.eItemAlignment.Far;
			this.btnImportInvModel.Name = "btnImportInvModel";
			this.btnImportInvModel.Text = "ImportInvModel";
			this.btnImportInvModel.Click += new global::System.EventHandler(this.btnImportInvModel_Click);
			this.btnItemC.ItemAlignment = global::DevComponents.DotNetBar.eItemAlignment.Far;
			this.btnItemC.Name = "btnItemC";
			this.btnItemC.Text = "ItemC";
			this.btnItemC.Click += new global::System.EventHandler(this.btnItemC_Click);
			this.dgvData.AllowUserToAddRows = false;
			this.dgvData.AllowUserToDeleteRows = false;
			this.dgvData.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.dgvData.AutoSizeColumnsMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvData.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvData.Columns.AddRange(new global::System.Windows.Forms.DataGridViewColumn[]
			{
				this.C_Id,
				this.C_InvCode,
				this.C_InvName,
				this.C_ProName,
				this.C_Code,
				this.C_MainInvCCode,
				this.C_SpecsDescribe,
				this.C_SunHao,
				this.C_MiDu,
				this.C_Type,
				this.C_,
				this.C_PostType,
				this.C_State,
				this.C_PeiPang,
				this.C_HeWeiConfig,
				this.C_InvModelName,
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
			this.dgvData.Location = new global::System.Drawing.Point(0, 27);
			this.dgvData.Name = "dgvData";
			this.dgvData.ReadOnly = true;
			this.dgvData.RowHeadersVisible = false;
			this.dgvData.RowTemplate.Height = 23;
			this.dgvData.Size = new global::System.Drawing.Size(1221, 424);
			this.dgvData.TabIndex = 4;
			this.dgvData.CellClick += new global::System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellClick);
			this.dgvData.CellContentClick += new global::System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellContentClick);
			this.dgvData.CellDoubleClick += new global::System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellDoubleClick);
			this.dgvData.SelectionChanged += new global::System.EventHandler(this.dgvData_SelectionChanged);
			this.C_Id.HeaderText = "ID";
			this.C_Id.Name = "C_Id";
			this.C_Id.ReadOnly = true;
			this.C_Id.Visible = false;
			this.C_InvCode.HeaderText = "InvCode";
			this.C_InvCode.Name = "C_InvCode";
			this.C_InvCode.ReadOnly = true;
			this.C_InvName.HeaderText = "InvName";
			this.C_InvName.Name = "C_InvName";
			this.C_InvName.ReadOnly = true;
			this.C_ProName.HeaderText = "ProductName";
			this.C_ProName.Name = "C_ProName";
			this.C_ProName.ReadOnly = true;
			this.C_Code.HeaderText = "ProductCode";
			this.C_Code.Name = "C_Code";
			this.C_Code.ReadOnly = true;
			this.C_MainInvCCode.HeaderText = "InvCCode";
			this.C_MainInvCCode.Name = "C_MainInvCCode";
			this.C_MainInvCCode.ReadOnly = true;
			this.C_MainInvCCode.Visible = false;
			this.C_SpecsDescribe.HeaderText = "SpecsDescribe";
			this.C_SpecsDescribe.Name = "C_SpecsDescribe";
			this.C_SpecsDescribe.ReadOnly = true;
			this.C_SunHao.HeaderText = "SunHao";
			this.C_SunHao.Name = "C_SunHao";
			this.C_SunHao.ReadOnly = true;
			this.C_SunHao.Visible = false;
			this.C_MiDu.HeaderText = "MiDu(kg/m³)";
			this.C_MiDu.Name = "C_MiDu";
			this.C_MiDu.ReadOnly = true;
			this.C_Type.HeaderText = "Type";
			this.C_Type.Name = "C_Type";
			this.C_Type.ReadOnly = true;
			this.C_.HeaderText = "ValidCondition";
			this.C_.Name = "C_";
			this.C_.ReadOnly = true;
			this.C_PostType.HeaderText = "PostType";
			this.C_PostType.Name = "C_PostType";
			this.C_PostType.ReadOnly = true;
			this.C_State.HeaderText = "State";
			this.C_State.Name = "C_State";
			this.C_State.ReadOnly = true;
			this.C_PeiPang.HeaderText = "PeiPang";
			this.C_PeiPang.Name = "C_PeiPang";
			this.C_PeiPang.ReadOnly = true;
			this.C_HeWeiConfig.HeaderText = "HeWeiConfig";
			this.C_HeWeiConfig.Name = "C_HeWeiConfig";
			this.C_HeWeiConfig.ReadOnly = true;
			this.C_InvModelName.HeaderText = "SrmInvModel";
			this.C_InvModelName.Name = "C_InvModelName";
			this.C_InvModelName.ReadOnly = true;
			this.C_Remark.HeaderText = "Remark";
			this.C_Remark.Name = "C_Remark";
			this.C_Remark.ReadOnly = true;
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
			this.bar1.Location = new global::System.Drawing.Point(0, 452);
			this.bar1.Name = "bar1";
			this.bar1.Size = new global::System.Drawing.Size(1221, 30);
			this.bar1.Stretch = true;
			this.bar1.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.bar1.TabIndex = 5;
			this.bar1.TabStop = false;
			this.bar1.Text = "bar1";
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
			this.txtNowPage.Location = new global::System.Drawing.Point(1041, 3);
			this.txtNowPage.Name = "txtNowPage";
			this.txtNowPage.Size = new global::System.Drawing.Size(64, 23);
			this.txtNowPage.TabIndex = 21;
			this.txtNowPage.Text = "1";
			this.txtNowPage.TextChanged += new global::System.EventHandler(this.txtNowPage_TextChanged);
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
			base.ClientSize = new global::System.Drawing.Size(1221, 482);
			base.Controls.Add(this.bar1);
			base.Controls.Add(this.dgvData);
			base.Controls.Add(this.bar);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "frmProduct";
			this.Text = "Product";
			base.Load += new global::System.EventHandler(this.frmProduct_Load);
			((global::System.ComponentModel.ISupportInitialize)this.bar).EndInit();
			this.bar.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.dgvData).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.bar1).EndInit();
			this.bar1.ResumeLayout(false);
			this.bar1.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x04000D02 RID: 3330
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000D03 RID: 3331
		private global::DevComponents.DotNetBar.Bar bar;

		// Token: 0x04000D04 RID: 3332
		private global::DevComponents.DotNetBar.ButtonItem btnAdd;

		// Token: 0x04000D05 RID: 3333
		private global::DevComponents.DotNetBar.ButtonItem btnModify;

		// Token: 0x04000D06 RID: 3334
		private global::DevComponents.DotNetBar.ButtonItem btnDelete;

		// Token: 0x04000D07 RID: 3335
		private global::DevComponents.DotNetBar.LabelItem labProductInfo;

		// Token: 0x04000D08 RID: 3336
		private global::DevComponents.DotNetBar.TextBoxItem txtName;

		// Token: 0x04000D09 RID: 3337
		private global::DevComponents.DotNetBar.ButtonItem btnSearch;

		// Token: 0x04000D0A RID: 3338
		private global::DevComponents.DotNetBar.Controls.Line line2;

		// Token: 0x04000D0B RID: 3339
		private global::DevComponents.DotNetBar.ControlContainerItem controlContainerItem1;

		// Token: 0x04000D0C RID: 3340
		private global::DevComponents.DotNetBar.Controls.DataGridViewX dgvData;

		// Token: 0x04000D0D RID: 3341
		private global::DevComponents.DotNetBar.ButtonItem btnImport;

		// Token: 0x04000D0E RID: 3342
		private global::DevComponents.DotNetBar.ButtonItem btnItemC;

		// Token: 0x04000D0F RID: 3343
		private global::DevComponents.DotNetBar.ButtonItem btnImportProduct;

		// Token: 0x04000D10 RID: 3344
		private global::DevComponents.DotNetBar.ButtonItem btnImportInvModel;

		// Token: 0x04000D11 RID: 3345
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_Id;

		// Token: 0x04000D12 RID: 3346
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_InvCode;

		// Token: 0x04000D13 RID: 3347
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_InvName;

		// Token: 0x04000D14 RID: 3348
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_ProName;

		// Token: 0x04000D15 RID: 3349
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_Code;

		// Token: 0x04000D16 RID: 3350
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_MainInvCCode;

		// Token: 0x04000D17 RID: 3351
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_SpecsDescribe;

		// Token: 0x04000D18 RID: 3352
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_SunHao;

		// Token: 0x04000D19 RID: 3353
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_MiDu;

		// Token: 0x04000D1A RID: 3354
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_Type;

		// Token: 0x04000D1B RID: 3355
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_;

		// Token: 0x04000D1C RID: 3356
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_PostType;

		// Token: 0x04000D1D RID: 3357
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_State;

		// Token: 0x04000D1E RID: 3358
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_PeiPang;

		// Token: 0x04000D1F RID: 3359
		private global::System.Windows.Forms.DataGridViewImageColumn C_HeWeiConfig;

		// Token: 0x04000D20 RID: 3360
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_InvModelName;

		// Token: 0x04000D21 RID: 3361
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_Remark;

		// Token: 0x04000D22 RID: 3362
		private global::DevComponents.DotNetBar.Bar bar1;

		// Token: 0x04000D23 RID: 3363
		private global::System.Windows.Forms.ComboBox cmbPage;

		// Token: 0x04000D24 RID: 3364
		private global::System.Windows.Forms.TextBox txtNowPage;

		// Token: 0x04000D25 RID: 3365
		private global::DevComponents.DotNetBar.LabelItem labPage;

		// Token: 0x04000D26 RID: 3366
		private global::DevComponents.DotNetBar.ControlContainerItem controlContainerItem2;

		// Token: 0x04000D27 RID: 3367
		private global::DevComponents.DotNetBar.LabelItem labItem;

		// Token: 0x04000D28 RID: 3368
		private global::DevComponents.DotNetBar.ButtonItem btn_pageup;

		// Token: 0x04000D29 RID: 3369
		private global::DevComponents.DotNetBar.ControlContainerItem controlContainerItem5;

		// Token: 0x04000D2A RID: 3370
		private global::DevComponents.DotNetBar.LabelItem labelItem1;

		// Token: 0x04000D2B RID: 3371
		private global::DevComponents.DotNetBar.LabelItem labPageCounts;

		// Token: 0x04000D2C RID: 3372
		private global::DevComponents.DotNetBar.ButtonItem btn_pagedown;
	}
}
