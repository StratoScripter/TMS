namespace SQSClient
{
	// Token: 0x02000020 RID: 32
	public partial class frmContract : global::SQSClient.BaseDialogForm
	{
		// Token: 0x06000189 RID: 393 RVA: 0x0002EAD8 File Offset: 0x0002CCD8
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600018A RID: 394 RVA: 0x0002EB10 File Offset: 0x0002CD10
		private void InitializeComponent()
		{
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new global::System.Windows.Forms.DataGridViewCellStyle();
			this.bar = new global::DevComponents.DotNetBar.Bar();
			this.line2 = new global::DevComponents.DotNetBar.Controls.Line();
			this.btnAdd = new global::DevComponents.DotNetBar.ButtonItem();
			this.btnModify = new global::DevComponents.DotNetBar.ButtonItem();
			this.btnDelete = new global::DevComponents.DotNetBar.ButtonItem();
			this.controlContainerItem1 = new global::DevComponents.DotNetBar.ControlContainerItem();
			this.labNo = new global::DevComponents.DotNetBar.LabelItem();
			this.txtName = new global::DevComponents.DotNetBar.TextBoxItem();
			this.btnSearch = new global::DevComponents.DotNetBar.ButtonItem();
			this.dgvData = new global::DevComponents.DotNetBar.Controls.DataGridViewX();
			this.C_Id = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_ContractID = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_PartyA = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_PartyB = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_BusinessType = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_Product = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_JiHuaLiang = new global::DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn();
			this.C_DanWei = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_StartTime = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_EndTime = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_Signer = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_SignDate = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_Remark = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			((global::System.ComponentModel.ISupportInitialize)this.bar).BeginInit();
			this.bar.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvData).BeginInit();
			base.SuspendLayout();
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
				this.btnSearch
			});
			this.bar.Location = new global::System.Drawing.Point(0, 0);
			this.bar.Name = "bar";
			this.bar.Size = new global::System.Drawing.Size(917, 27);
			this.bar.Stretch = true;
			this.bar.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.bar.TabIndex = 3;
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
			this.labNo.Text = "ContractID";
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
				this.C_ContractID,
				this.C_PartyA,
				this.C_PartyB,
				this.C_BusinessType,
				this.C_Product,
				this.C_JiHuaLiang,
				this.C_DanWei,
				this.C_StartTime,
				this.C_EndTime,
				this.C_Signer,
				this.C_SignDate,
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
			this.dgvData.Location = new global::System.Drawing.Point(0, 27);
			this.dgvData.Name = "dgvData";
			this.dgvData.ReadOnly = true;
			this.dgvData.RowHeadersVisible = false;
			this.dgvData.RowTemplate.Height = 23;
			this.dgvData.Size = new global::System.Drawing.Size(917, 376);
			this.dgvData.TabIndex = 4;
			this.dgvData.CellClick += new global::System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellClick);
			this.dgvData.CellDoubleClick += new global::System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellDoubleClick);
			this.C_Id.HeaderText = "ID";
			this.C_Id.Name = "C_Id";
			this.C_Id.ReadOnly = true;
			this.C_Id.Visible = false;
			this.C_ContractID.HeaderText = "ContractID";
			this.C_ContractID.Name = "C_ContractID";
			this.C_ContractID.ReadOnly = true;
			this.C_PartyA.HeaderText = "PartyA";
			this.C_PartyA.Name = "C_PartyA";
			this.C_PartyA.ReadOnly = true;
			this.C_PartyB.HeaderText = "PartyB";
			this.C_PartyB.Name = "C_PartyB";
			this.C_PartyB.ReadOnly = true;
			this.C_BusinessType.HeaderText = "BusinessType";
			this.C_BusinessType.Name = "C_BusinessType";
			this.C_BusinessType.ReadOnly = true;
			this.C_Product.HeaderText = "Product";
			this.C_Product.Name = "C_Product";
			this.C_Product.ReadOnly = true;
			this.C_JiHuaLiang.BackgroundStyle.Class = "DataGridViewNumericBorder";
			this.C_JiHuaLiang.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.C_JiHuaLiang.HeaderText = "JiHuaLiang";
			this.C_JiHuaLiang.Increment = 1.0;
			this.C_JiHuaLiang.InputHorizontalAlignment = global::DevComponents.Editors.eHorizontalAlignment.Left;
			this.C_JiHuaLiang.Name = "C_JiHuaLiang";
			this.C_JiHuaLiang.ReadOnly = true;
			this.C_JiHuaLiang.Resizable = global::System.Windows.Forms.DataGridViewTriState.True;
			this.C_DanWei.HeaderText = "DanWei";
			this.C_DanWei.Name = "C_DanWei";
			this.C_DanWei.ReadOnly = true;
			this.C_StartTime.HeaderText = "StartTime";
			this.C_StartTime.Name = "C_StartTime";
			this.C_StartTime.ReadOnly = true;
			this.C_EndTime.HeaderText = "EndTime";
			this.C_EndTime.Name = "C_EndTime";
			this.C_EndTime.ReadOnly = true;
			this.C_Signer.HeaderText = "Signer";
			this.C_Signer.Name = "C_Signer";
			this.C_Signer.ReadOnly = true;
			this.C_SignDate.HeaderText = "SignDate";
			this.C_SignDate.Name = "C_SignDate";
			this.C_SignDate.ReadOnly = true;
			this.C_Remark.HeaderText = "Remark";
			this.C_Remark.Name = "C_Remark";
			this.C_Remark.ReadOnly = true;
			base.ClientSize = new global::System.Drawing.Size(917, 403);
			base.Controls.Add(this.dgvData);
			base.Controls.Add(this.bar);
			base.Name = "frmContract";
			this.Text = "Contract";
			base.Load += new global::System.EventHandler(this.frmContract_Load);
			((global::System.ComponentModel.ISupportInitialize)this.bar).EndInit();
			this.bar.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.dgvData).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x040002B6 RID: 694
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x040002B7 RID: 695
		private global::DevComponents.DotNetBar.Bar bar;

		// Token: 0x040002B8 RID: 696
		private global::DevComponents.DotNetBar.Controls.Line line2;

		// Token: 0x040002B9 RID: 697
		private global::DevComponents.DotNetBar.ButtonItem btnAdd;

		// Token: 0x040002BA RID: 698
		private global::DevComponents.DotNetBar.ButtonItem btnModify;

		// Token: 0x040002BB RID: 699
		private global::DevComponents.DotNetBar.ButtonItem btnDelete;

		// Token: 0x040002BC RID: 700
		private global::DevComponents.DotNetBar.ControlContainerItem controlContainerItem1;

		// Token: 0x040002BD RID: 701
		private global::DevComponents.DotNetBar.LabelItem labNo;

		// Token: 0x040002BE RID: 702
		private global::DevComponents.DotNetBar.TextBoxItem txtName;

		// Token: 0x040002BF RID: 703
		private global::DevComponents.DotNetBar.ButtonItem btnSearch;

		// Token: 0x040002C0 RID: 704
		private global::DevComponents.DotNetBar.Controls.DataGridViewX dgvData;

		// Token: 0x040002C1 RID: 705
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_Id;

		// Token: 0x040002C2 RID: 706
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_ContractID;

		// Token: 0x040002C3 RID: 707
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_PartyA;

		// Token: 0x040002C4 RID: 708
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_PartyB;

		// Token: 0x040002C5 RID: 709
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_BusinessType;

		// Token: 0x040002C6 RID: 710
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_Product;

		// Token: 0x040002C7 RID: 711
		private global::DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn C_JiHuaLiang;

		// Token: 0x040002C8 RID: 712
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_DanWei;

		// Token: 0x040002C9 RID: 713
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_StartTime;

		// Token: 0x040002CA RID: 714
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_EndTime;

		// Token: 0x040002CB RID: 715
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_Signer;

		// Token: 0x040002CC RID: 716
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_SignDate;

		// Token: 0x040002CD RID: 717
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_Remark;
	}
}
