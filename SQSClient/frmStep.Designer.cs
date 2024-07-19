namespace SQSClient
{
	// Token: 0x02000054 RID: 84
	public partial class frmStep : global::SQSClient.BaseDialogForm
	{
		// Token: 0x06000411 RID: 1041 RVA: 0x00067374 File Offset: 0x00065574
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000412 RID: 1042 RVA: 0x000673AC File Offset: 0x000655AC
		private void InitializeComponent()
		{
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new global::System.Windows.Forms.DataGridViewCellStyle();
			this.bar = new global::DevComponents.DotNetBar.Bar();
			this.btnAdd = new global::DevComponents.DotNetBar.ButtonItem();
			this.btnModify = new global::DevComponents.DotNetBar.ButtonItem();
			this.btnDelete = new global::DevComponents.DotNetBar.ButtonItem();
			this.btnExport = new global::DevComponents.DotNetBar.ButtonItem();
			this.dgvData = new global::DevComponents.DotNetBar.Controls.DataGridViewX();
			this.C_ID = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_StepName = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_StepCode = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_ReachBasis = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_ResetBasis = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_Creater = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_CreateTime = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_Modifier = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_ModifyTime = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_State = new global::System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.C_StepDesc = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			((global::System.ComponentModel.ISupportInitialize)this.bar).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.dgvData).BeginInit();
			base.SuspendLayout();
			this.bar.AntiAlias = true;
			this.bar.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.bar.Font = new global::System.Drawing.Font("Microsoft YaHei UI", 9f);
			this.bar.IsMaximized = false;
			this.bar.Items.AddRange(new global::DevComponents.DotNetBar.BaseItem[]
			{
				this.btnAdd,
				this.btnModify,
				this.btnDelete,
				this.btnExport
			});
			this.bar.Location = new global::System.Drawing.Point(0, 0);
			this.bar.Name = "bar";
			this.bar.Size = new global::System.Drawing.Size(1125, 26);
			this.bar.Stretch = true;
			this.bar.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.bar.TabIndex = 0;
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
			this.btnExport.Image = global::SQSClient.Properties.Resources.print16;
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
				this.C_StepName,
				this.C_StepCode,
				this.C_ReachBasis,
				this.C_ResetBasis,
				this.C_Creater,
				this.C_CreateTime,
				this.C_Modifier,
				this.C_ModifyTime,
				this.C_State,
				this.C_StepDesc
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
			this.dgvData.Location = new global::System.Drawing.Point(0, 26);
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
			this.dgvData.RowTemplate.Height = 27;
			this.dgvData.Size = new global::System.Drawing.Size(1125, 395);
			this.dgvData.TabIndex = 1;
			this.dgvData.CellClick += new global::System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellClick);
			this.dgvData.CellDoubleClick += new global::System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellDoubleClick);
			this.dgvData.SelectionChanged += new global::System.EventHandler(this.dgvData_SelectionChanged);
			this.C_ID.HeaderText = "ID";
			this.C_ID.Name = "C_ID";
			this.C_ID.ReadOnly = true;
			this.C_ID.Visible = false;
			this.C_StepName.FillWeight = 120f;
			this.C_StepName.HeaderText = "SrmName";
			this.C_StepName.Name = "C_StepName";
			this.C_StepName.ReadOnly = true;
			this.C_StepCode.FillWeight = 81.13367f;
			this.C_StepCode.HeaderText = "SrmCode";
			this.C_StepCode.Name = "C_StepCode";
			this.C_StepCode.ReadOnly = true;
			this.C_ReachBasis.HeaderText = "SrmReachBasis";
			this.C_ReachBasis.Name = "C_ReachBasis";
			this.C_ReachBasis.ReadOnly = true;
			this.C_ResetBasis.HeaderText = "SrmResetBasis";
			this.C_ResetBasis.Name = "C_ResetBasis";
			this.C_ResetBasis.ReadOnly = true;
			this.C_Creater.HeaderText = "SrmCreater";
			this.C_Creater.Name = "C_Creater";
			this.C_Creater.ReadOnly = true;
			this.C_CreateTime.FillWeight = 81.13367f;
			this.C_CreateTime.HeaderText = "SrmCreateTime";
			this.C_CreateTime.Name = "C_CreateTime";
			this.C_CreateTime.ReadOnly = true;
			this.C_Modifier.FillWeight = 81.13367f;
			this.C_Modifier.HeaderText = "SrmModifier";
			this.C_Modifier.Name = "C_Modifier";
			this.C_Modifier.ReadOnly = true;
			this.C_ModifyTime.HeaderText = "SrmModifyTime";
			this.C_ModifyTime.Name = "C_ModifyTime";
			this.C_ModifyTime.ReadOnly = true;
			this.C_State.HeaderText = "SrmState";
			this.C_State.Name = "C_State";
			this.C_State.ReadOnly = true;
			this.C_State.Resizable = global::System.Windows.Forms.DataGridViewTriState.True;
			this.C_State.SortMode = global::System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.C_StepDesc.HeaderText = "Memo";
			this.C_StepDesc.Name = "C_StepDesc";
			this.C_StepDesc.ReadOnly = true;
			base.ClientSize = new global::System.Drawing.Size(1125, 421);
			base.Controls.Add(this.dgvData);
			base.Controls.Add(this.bar);
			base.Name = "frmStep";
			this.Text = "SrmStep";
			base.Load += new global::System.EventHandler(this.frmStep_Load);
			((global::System.ComponentModel.ISupportInitialize)this.bar).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.dgvData).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000701 RID: 1793
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000702 RID: 1794
		private global::DevComponents.DotNetBar.Bar bar;

		// Token: 0x04000703 RID: 1795
		private global::DevComponents.DotNetBar.ButtonItem btnAdd;

		// Token: 0x04000704 RID: 1796
		private global::DevComponents.DotNetBar.ButtonItem btnModify;

		// Token: 0x04000705 RID: 1797
		private global::DevComponents.DotNetBar.ButtonItem btnDelete;

		// Token: 0x04000706 RID: 1798
		private global::DevComponents.DotNetBar.ButtonItem btnExport;

		// Token: 0x04000707 RID: 1799
		private global::DevComponents.DotNetBar.Controls.DataGridViewX dgvData;

		// Token: 0x04000708 RID: 1800
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_ID;

		// Token: 0x04000709 RID: 1801
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_StepName;

		// Token: 0x0400070A RID: 1802
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_StepCode;

		// Token: 0x0400070B RID: 1803
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_ReachBasis;

		// Token: 0x0400070C RID: 1804
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_ResetBasis;

		// Token: 0x0400070D RID: 1805
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_Creater;

		// Token: 0x0400070E RID: 1806
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_CreateTime;

		// Token: 0x0400070F RID: 1807
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_Modifier;

		// Token: 0x04000710 RID: 1808
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_ModifyTime;

		// Token: 0x04000711 RID: 1809
		private global::System.Windows.Forms.DataGridViewCheckBoxColumn C_State;

		// Token: 0x04000712 RID: 1810
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_StepDesc;
	}
}
