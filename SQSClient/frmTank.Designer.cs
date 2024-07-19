namespace SQSClient
{
	// Token: 0x0200008F RID: 143
	public partial class frmTank : global::SQSClient.BaseDialogForm
	{
		// Token: 0x060007DF RID: 2015 RVA: 0x000C37AC File Offset: 0x000C19AC
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060007E0 RID: 2016 RVA: 0x000C37E4 File Offset: 0x000C19E4
		private void InitializeComponent()
		{
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::SQSClient.frmTank));
			this.bar = new global::DevComponents.DotNetBar.Bar();
			this.line2 = new global::DevComponents.DotNetBar.Controls.Line();
			this.btnAdd = new global::DevComponents.DotNetBar.ButtonItem();
			this.btnModify = new global::DevComponents.DotNetBar.ButtonItem();
			this.btnDelete = new global::DevComponents.DotNetBar.ButtonItem();
			this.controlContainerItem1 = new global::DevComponents.DotNetBar.ControlContainerItem();
			this.labelItem1 = new global::DevComponents.DotNetBar.LabelItem();
			this.txtName = new global::DevComponents.DotNetBar.TextBoxItem();
			this.btnSearch = new global::DevComponents.DotNetBar.ButtonItem();
			this.dgvData = new global::DevComponents.DotNetBar.Controls.DataGridViewX();
			this.itemGroup = new global::DevComponents.DotNetBar.ItemPanel();
			this.expandableSplitter1 = new global::DevComponents.DotNetBar.ExpandableSplitter();
			this.C_Id = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_TankName = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_Code = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_Product = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_Vol = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_RealVol = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_DanWei = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_Remark = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
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
				this.controlContainerItem1,
				this.labelItem1,
				this.txtName,
				this.btnSearch
			});
			this.bar.Location = new global::System.Drawing.Point(0, 0);
			this.bar.Name = "bar";
			this.bar.Size = new global::System.Drawing.Size(954, 27);
			this.bar.Stretch = true;
			this.bar.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.bar.TabIndex = 1;
			this.bar.TabStop = false;
			this.bar.Text = "bar1";
			this.line2.ForeColor = global::System.Drawing.SystemColors.ActiveCaption;
			this.line2.Location = new global::System.Drawing.Point(196, 3);
			this.line2.Name = "line2";
			this.line2.Size = new global::System.Drawing.Size(1, 20);
			this.line2.TabIndex = 18;
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
			this.labelItem1.Name = "labelItem1";
			this.labelItem1.Text = "TankName";
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
			this.dgvData.AllowUserToAddRows = false;
			this.dgvData.AllowUserToDeleteRows = false;
			this.dgvData.AutoSizeColumnsMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvData.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvData.Columns.AddRange(new global::System.Windows.Forms.DataGridViewColumn[]
			{
				this.C_Id,
				this.C_TankName,
				this.C_Code,
				this.C_Product,
				this.C_Vol,
				this.C_RealVol,
				this.C_DanWei,
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
			this.dgvData.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.dgvData.GridColor = global::System.Drawing.Color.FromArgb(208, 215, 229);
			this.dgvData.Location = new global::System.Drawing.Point(203, 27);
			this.dgvData.Name = "dgvData";
			this.dgvData.ReadOnly = true;
			this.dgvData.RowHeadersVisible = false;
			this.dgvData.RowTemplate.Height = 23;
			this.dgvData.Size = new global::System.Drawing.Size(751, 345);
			this.dgvData.TabIndex = 2;
			this.dgvData.CellClick += new global::System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellClick);
			this.dgvData.CellDoubleClick += new global::System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellDoubleClick);
			this.itemGroup.BackgroundStyle.Class = "ItemPanel";
			this.itemGroup.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.itemGroup.ContainerControlProcessDialogKey = true;
			this.itemGroup.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.itemGroup.DragDropSupport = true;
			this.itemGroup.LayoutOrientation = global::DevComponents.DotNetBar.eOrientation.Vertical;
			this.itemGroup.Location = new global::System.Drawing.Point(0, 27);
			this.itemGroup.Name = "itemGroup";
			this.itemGroup.Size = new global::System.Drawing.Size(200, 345);
			this.itemGroup.TabIndex = 5;
			this.itemGroup.Text = "itemPanel1";
			this.itemGroup.Click += new global::System.EventHandler(this.itemGroup_Click);
			this.expandableSplitter1.BackColor2 = global::System.Drawing.Color.FromArgb(101, 147, 207);
			this.expandableSplitter1.BackColor2SchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
			this.expandableSplitter1.BackColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
			this.expandableSplitter1.ExpandFillColor = global::System.Drawing.Color.FromArgb(101, 147, 207);
			this.expandableSplitter1.ExpandFillColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
			this.expandableSplitter1.ExpandLineColor = global::System.Drawing.Color.FromArgb(0, 0, 0);
			this.expandableSplitter1.ExpandLineColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.ItemText;
			this.expandableSplitter1.GripDarkColor = global::System.Drawing.Color.FromArgb(0, 0, 0);
			this.expandableSplitter1.GripDarkColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.ItemText;
			this.expandableSplitter1.GripLightColor = global::System.Drawing.Color.FromArgb(227, 239, 255);
			this.expandableSplitter1.GripLightColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.BarBackground;
			this.expandableSplitter1.HotBackColor = global::System.Drawing.Color.FromArgb(252, 151, 61);
			this.expandableSplitter1.HotBackColor2 = global::System.Drawing.Color.FromArgb(255, 184, 94);
			this.expandableSplitter1.HotBackColor2SchemePart = global::DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground2;
			this.expandableSplitter1.HotBackColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground;
			this.expandableSplitter1.HotExpandFillColor = global::System.Drawing.Color.FromArgb(101, 147, 207);
			this.expandableSplitter1.HotExpandFillColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
			this.expandableSplitter1.HotExpandLineColor = global::System.Drawing.Color.FromArgb(0, 0, 0);
			this.expandableSplitter1.HotExpandLineColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.ItemText;
			this.expandableSplitter1.HotGripDarkColor = global::System.Drawing.Color.FromArgb(101, 147, 207);
			this.expandableSplitter1.HotGripDarkColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
			this.expandableSplitter1.HotGripLightColor = global::System.Drawing.Color.FromArgb(227, 239, 255);
			this.expandableSplitter1.HotGripLightColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.BarBackground;
			this.expandableSplitter1.Location = new global::System.Drawing.Point(200, 27);
			this.expandableSplitter1.Name = "expandableSplitter1";
			this.expandableSplitter1.Size = new global::System.Drawing.Size(3, 345);
			this.expandableSplitter1.Style = global::DevComponents.DotNetBar.eSplitterStyle.Office2007;
			this.expandableSplitter1.TabIndex = 26;
			this.expandableSplitter1.TabStop = false;
			this.C_Id.HeaderText = "ID";
			this.C_Id.Name = "C_Id";
			this.C_Id.ReadOnly = true;
			this.C_Id.Visible = false;
			this.C_TankName.HeaderText = "TankName";
			this.C_TankName.Name = "C_TankName";
			this.C_TankName.ReadOnly = true;
			this.C_Code.HeaderText = "TankCode";
			this.C_Code.Name = "C_Code";
			this.C_Code.ReadOnly = true;
			this.C_Product.HeaderText = "Product";
			this.C_Product.Name = "C_Product";
			this.C_Product.ReadOnly = true;
			this.C_Vol.HeaderText = "Vol";
			this.C_Vol.Name = "C_Vol";
			this.C_Vol.ReadOnly = true;
			this.C_RealVol.HeaderText = "RealVol";
			this.C_RealVol.Name = "C_RealVol";
			this.C_RealVol.ReadOnly = true;
			this.C_DanWei.HeaderText = "DanWei";
			this.C_DanWei.Name = "C_DanWei";
			this.C_DanWei.ReadOnly = true;
			this.C_Remark.HeaderText = "Remark";
			this.C_Remark.Name = "C_Remark";
			this.C_Remark.ReadOnly = true;
			base.ClientSize = new global::System.Drawing.Size(954, 372);
			base.Controls.Add(this.dgvData);
			base.Controls.Add(this.expandableSplitter1);
			base.Controls.Add(this.itemGroup);
			base.Controls.Add(this.bar);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "frmTank";
			this.Text = "Tank";
			base.Load += new global::System.EventHandler(this.frmTank_Load);
			((global::System.ComponentModel.ISupportInitialize)this.bar).EndInit();
			this.bar.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.dgvData).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000D79 RID: 3449
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000D7A RID: 3450
		private global::DevComponents.DotNetBar.Bar bar;

		// Token: 0x04000D7B RID: 3451
		private global::DevComponents.DotNetBar.ButtonItem btnAdd;

		// Token: 0x04000D7C RID: 3452
		private global::DevComponents.DotNetBar.ButtonItem btnModify;

		// Token: 0x04000D7D RID: 3453
		private global::DevComponents.DotNetBar.ButtonItem btnDelete;

		// Token: 0x04000D7E RID: 3454
		private global::DevComponents.DotNetBar.Controls.DataGridViewX dgvData;

		// Token: 0x04000D7F RID: 3455
		private global::DevComponents.DotNetBar.Controls.Line line2;

		// Token: 0x04000D80 RID: 3456
		private global::DevComponents.DotNetBar.ControlContainerItem controlContainerItem1;

		// Token: 0x04000D81 RID: 3457
		private global::DevComponents.DotNetBar.LabelItem labelItem1;

		// Token: 0x04000D82 RID: 3458
		private global::DevComponents.DotNetBar.TextBoxItem txtName;

		// Token: 0x04000D83 RID: 3459
		private global::DevComponents.DotNetBar.ButtonItem btnSearch;

		// Token: 0x04000D84 RID: 3460
		private global::DevComponents.DotNetBar.ItemPanel itemGroup;

		// Token: 0x04000D85 RID: 3461
		private global::DevComponents.DotNetBar.ExpandableSplitter expandableSplitter1;

		// Token: 0x04000D86 RID: 3462
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_Id;

		// Token: 0x04000D87 RID: 3463
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_TankName;

		// Token: 0x04000D88 RID: 3464
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_Code;

		// Token: 0x04000D89 RID: 3465
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_Product;

		// Token: 0x04000D8A RID: 3466
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_Vol;

		// Token: 0x04000D8B RID: 3467
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_RealVol;

		// Token: 0x04000D8C RID: 3468
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_DanWei;

		// Token: 0x04000D8D RID: 3469
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_Remark;
	}
}
