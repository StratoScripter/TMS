namespace SQSClient
{
	// Token: 0x0200005E RID: 94
	public partial class frmWeighbridge : global::SQSClient.BaseDialogForm
	{
		// Token: 0x06000488 RID: 1160 RVA: 0x000724F4 File Offset: 0x000706F4
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000489 RID: 1161 RVA: 0x0007252C File Offset: 0x0007072C
		private void InitializeComponent()
		{
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new global::System.Windows.Forms.DataGridViewCellStyle();
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
			this.C_Id = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_WeighbridgeName = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_Code = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_ModeType = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_DBConn = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_Value = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_Time = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_Enable = new global::System.Windows.Forms.DataGridViewCheckBoxColumn();
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
			this.bar.Size = new global::System.Drawing.Size(858, 27);
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
			this.labelItem1.Name = "labelItem1";
			this.labelItem1.Text = "WeighbridgeName";
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
				this.C_WeighbridgeName,
				this.C_Code,
				this.C_ModeType,
				this.C_DBConn,
				this.C_Value,
				this.C_Time,
				this.C_Enable,
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
			this.dgvData.Size = new global::System.Drawing.Size(858, 342);
			this.dgvData.TabIndex = 3;
			this.dgvData.CellClick += new global::System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellClick);
			this.dgvData.CellDoubleClick += new global::System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellDoubleClick);
			this.C_Id.HeaderText = "ID";
			this.C_Id.Name = "C_Id";
			this.C_Id.ReadOnly = true;
			this.C_Id.Visible = false;
			this.C_WeighbridgeName.FillWeight = 93.24873f;
			this.C_WeighbridgeName.HeaderText = "WeighbridgeName";
			this.C_WeighbridgeName.Name = "C_WeighbridgeName";
			this.C_WeighbridgeName.ReadOnly = true;
			this.C_Code.FillWeight = 93.24873f;
			this.C_Code.HeaderText = "WeighbridgeCode";
			this.C_Code.Name = "C_Code";
			this.C_Code.ReadOnly = true;
			this.C_ModeType.HeaderText = "ModeType";
			this.C_ModeType.Name = "C_ModeType";
			this.C_ModeType.ReadOnly = true;
			this.C_DBConn.FillWeight = 93.24873f;
			this.C_DBConn.HeaderText = "DBConn";
			this.C_DBConn.Name = "C_DBConn";
			this.C_DBConn.ReadOnly = true;
			this.C_Value.FillWeight = 93.24873f;
			this.C_Value.HeaderText = "Value";
			this.C_Value.Name = "C_Value";
			this.C_Value.ReadOnly = true;
			this.C_Time.FillWeight = 93.24873f;
			this.C_Time.HeaderText = "Time";
			this.C_Time.Name = "C_Time";
			this.C_Time.ReadOnly = true;
			this.C_Enable.FillWeight = 93.24873f;
			this.C_Enable.HeaderText = "Enable";
			this.C_Enable.Name = "C_Enable";
			this.C_Enable.ReadOnly = true;
			this.C_Enable.Resizable = global::System.Windows.Forms.DataGridViewTriState.True;
			this.C_Remark.FillWeight = 93.24873f;
			this.C_Remark.HeaderText = "Remark";
			this.C_Remark.Name = "C_Remark";
			this.C_Remark.ReadOnly = true;
			base.ClientSize = new global::System.Drawing.Size(858, 369);
			base.Controls.Add(this.dgvData);
			base.Controls.Add(this.bar);
			base.Name = "frmWeighbridge";
			this.Text = "Loadometer";
			base.Load += new global::System.EventHandler(this.frmWeighbridge_Load);
			((global::System.ComponentModel.ISupportInitialize)this.bar).EndInit();
			this.bar.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.dgvData).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x040007D2 RID: 2002
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x040007D3 RID: 2003
		private global::DevComponents.DotNetBar.Bar bar;

		// Token: 0x040007D4 RID: 2004
		private global::DevComponents.DotNetBar.Controls.Line line2;

		// Token: 0x040007D5 RID: 2005
		private global::DevComponents.DotNetBar.ButtonItem btnAdd;

		// Token: 0x040007D6 RID: 2006
		private global::DevComponents.DotNetBar.ButtonItem btnModify;

		// Token: 0x040007D7 RID: 2007
		private global::DevComponents.DotNetBar.ButtonItem btnDelete;

		// Token: 0x040007D8 RID: 2008
		private global::DevComponents.DotNetBar.ControlContainerItem controlContainerItem1;

		// Token: 0x040007D9 RID: 2009
		private global::DevComponents.DotNetBar.LabelItem labelItem1;

		// Token: 0x040007DA RID: 2010
		private global::DevComponents.DotNetBar.TextBoxItem txtName;

		// Token: 0x040007DB RID: 2011
		private global::DevComponents.DotNetBar.ButtonItem btnSearch;

		// Token: 0x040007DC RID: 2012
		private global::DevComponents.DotNetBar.Controls.DataGridViewX dgvData;

		// Token: 0x040007DD RID: 2013
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_Id;

		// Token: 0x040007DE RID: 2014
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_WeighbridgeName;

		// Token: 0x040007DF RID: 2015
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_Code;

		// Token: 0x040007E0 RID: 2016
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_ModeType;

		// Token: 0x040007E1 RID: 2017
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_DBConn;

		// Token: 0x040007E2 RID: 2018
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_Value;

		// Token: 0x040007E3 RID: 2019
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_Time;

		// Token: 0x040007E4 RID: 2020
		private global::System.Windows.Forms.DataGridViewCheckBoxColumn C_Enable;

		// Token: 0x040007E5 RID: 2021
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_Remark;
	}
}
