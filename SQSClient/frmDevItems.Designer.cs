namespace SQSClient
{
	// Token: 0x0200006E RID: 110
	public partial class frmDevItems : global::SQSClient.BaseDialogForm
	{
		// Token: 0x06000596 RID: 1430 RVA: 0x0008ED60 File Offset: 0x0008CF60
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000597 RID: 1431 RVA: 0x0008ED98 File Offset: 0x0008CF98
		private void InitializeComponent()
		{
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new global::System.Windows.Forms.DataGridViewCellStyle();
			this.bar = new global::DevComponents.DotNetBar.Bar();
			this.btnModify = new global::DevComponents.DotNetBar.ButtonItem();
			this.btnExport = new global::DevComponents.DotNetBar.ButtonItem();
			this.dgvData = new global::DevComponents.DotNetBar.Controls.DataGridViewX();
			this.C_ID = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_PointName = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_PointCode = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_Parameter = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_Branch = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_PointType = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_RW = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_Addr = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_Remark = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			((global::System.ComponentModel.ISupportInitialize)this.bar).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.dgvData).BeginInit();
			base.SuspendLayout();
			this.bar.AccessibleDescription = "DotNetBar Bar (bar)";
			this.bar.AccessibleName = "DotNetBar Bar";
			this.bar.AccessibleRole = global::System.Windows.Forms.AccessibleRole.MenuBar;
			this.bar.BarType = global::DevComponents.DotNetBar.eBarType.MenuBar;
			this.bar.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.bar.Font = new global::System.Drawing.Font("宋体", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 134);
			this.bar.IsMaximized = false;
			this.bar.Items.AddRange(new global::DevComponents.DotNetBar.BaseItem[]
			{
				this.btnModify,
				this.btnExport
			});
			this.bar.Location = new global::System.Drawing.Point(0, 0);
			this.bar.MenuBar = true;
			this.bar.Name = "bar";
			this.bar.Size = new global::System.Drawing.Size(954, 24);
			this.bar.Stretch = true;
			this.bar.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.bar.TabIndex = 19;
			this.bar.TabStop = false;
			this.bar.Text = "MainMenu";
			this.btnModify.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.btnModify.Image = global::SQSClient.Properties.Resources.modify16;
			this.btnModify.Name = "btnModify";
			this.btnModify.Text = "Modify";
			this.btnModify.Click += new global::System.EventHandler(this.btnModify_Click);
			this.btnExport.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.btnExport.Image = global::SQSClient.Properties.Resources.export16;
			this.btnExport.Name = "btnExport";
			this.btnExport.Text = "Export";
			this.btnExport.Click += new global::System.EventHandler(this.btnExport_Click);
			this.dgvData.AllowUserToAddRows = false;
			this.dgvData.AllowUserToDeleteRows = false;
			this.dgvData.AutoSizeColumnsMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvData.AutoSizeRowsMode = global::System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			dataGridViewCellStyle.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle.BackColor = global::System.Drawing.SystemColors.Control;
			dataGridViewCellStyle.Font = new global::System.Drawing.Font("宋体", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 134);
			dataGridViewCellStyle.ForeColor = global::System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle.SelectionBackColor = global::System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle.SelectionForeColor = global::System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle.WrapMode = global::System.Windows.Forms.DataGridViewTriState.True;
			this.dgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
			this.dgvData.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dgvData.Columns.AddRange(new global::System.Windows.Forms.DataGridViewColumn[]
			{
				this.C_ID,
				this.C_PointName,
				this.C_PointCode,
				this.C_Parameter,
				this.C_Branch,
				this.C_PointType,
				this.C_RW,
				this.C_Addr,
				this.C_Remark
			});
			dataGridViewCellStyle2.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = global::System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new global::System.Drawing.Font("宋体", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 134);
			dataGridViewCellStyle2.ForeColor = global::System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = global::System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = global::System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.WrapMode = global::System.Windows.Forms.DataGridViewTriState.False;
			this.dgvData.DefaultCellStyle = dataGridViewCellStyle2;
			this.dgvData.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.dgvData.EnableHeadersVisualStyles = false;
			this.dgvData.GridColor = global::System.Drawing.Color.FromArgb(208, 215, 229);
			this.dgvData.Location = new global::System.Drawing.Point(0, 24);
			this.dgvData.Name = "dgvData";
			this.dgvData.ReadOnly = true;
			dataGridViewCellStyle3.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = global::System.Drawing.SystemColors.Control;
			dataGridViewCellStyle3.Font = new global::System.Drawing.Font("宋体", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 134);
			dataGridViewCellStyle3.ForeColor = global::System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = global::System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = global::System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.WrapMode = global::System.Windows.Forms.DataGridViewTriState.True;
			this.dgvData.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.dgvData.RowHeadersVisible = false;
			this.dgvData.RowTemplate.Height = 23;
			this.dgvData.Size = new global::System.Drawing.Size(954, 348);
			this.dgvData.TabIndex = 20;
			this.dgvData.CellClick += new global::System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellClick);
			this.dgvData.CellDoubleClick += new global::System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellDoubleClick);
			this.C_ID.HeaderText = "ID";
			this.C_ID.Name = "C_ID";
			this.C_ID.ReadOnly = true;
			this.C_ID.Visible = false;
			this.C_PointName.HeaderText = "PointName";
			this.C_PointName.Name = "C_PointName";
			this.C_PointName.ReadOnly = true;
			this.C_PointCode.HeaderText = "PointCode";
			this.C_PointCode.Name = "C_PointCode";
			this.C_PointCode.ReadOnly = true;
			this.C_Parameter.HeaderText = "Parameter";
			this.C_Parameter.Name = "C_Parameter";
			this.C_Parameter.ReadOnly = true;
			this.C_Branch.HeaderText = "Branch";
			this.C_Branch.Name = "C_Branch";
			this.C_Branch.ReadOnly = true;
			this.C_PointType.HeaderText = "PointType";
			this.C_PointType.Name = "C_PointType";
			this.C_PointType.ReadOnly = true;
			this.C_RW.HeaderText = "RW";
			this.C_RW.Name = "C_RW";
			this.C_RW.ReadOnly = true;
			this.C_Addr.HeaderText = "Addr";
			this.C_Addr.Name = "C_Addr";
			this.C_Addr.ReadOnly = true;
			this.C_Remark.HeaderText = "Remark";
			this.C_Remark.Name = "C_Remark";
			this.C_Remark.ReadOnly = true;
			base.ClientSize = new global::System.Drawing.Size(954, 372);
			base.Controls.Add(this.dgvData);
			base.Controls.Add(this.bar);
			base.Name = "frmDevItems";
			this.Text = "CommPoints";
			base.Load += new global::System.EventHandler(this.frmDevItems_Load);
			((global::System.ComponentModel.ISupportInitialize)this.bar).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.dgvData).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x040009CF RID: 2511
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x040009D0 RID: 2512
		private global::DevComponents.DotNetBar.Bar bar;

		// Token: 0x040009D1 RID: 2513
		private global::DevComponents.DotNetBar.ButtonItem btnModify;

		// Token: 0x040009D2 RID: 2514
		private global::DevComponents.DotNetBar.ButtonItem btnExport;

		// Token: 0x040009D3 RID: 2515
		private global::DevComponents.DotNetBar.Controls.DataGridViewX dgvData;

		// Token: 0x040009D4 RID: 2516
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_ID;

		// Token: 0x040009D5 RID: 2517
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_PointName;

		// Token: 0x040009D6 RID: 2518
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_PointCode;

		// Token: 0x040009D7 RID: 2519
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_Parameter;

		// Token: 0x040009D8 RID: 2520
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_Branch;

		// Token: 0x040009D9 RID: 2521
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_PointType;

		// Token: 0x040009DA RID: 2522
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_RW;

		// Token: 0x040009DB RID: 2523
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_Addr;

		// Token: 0x040009DC RID: 2524
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_Remark;
	}
}
