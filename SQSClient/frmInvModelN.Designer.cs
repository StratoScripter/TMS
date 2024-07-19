namespace SQSClient
{
	// Token: 0x0200004E RID: 78
	public partial class frmInvModelN : global::SQSClient.BaseDialogForm
	{
		// Token: 0x060003C9 RID: 969 RVA: 0x0005FA80 File Offset: 0x0005DC80
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060003CA RID: 970 RVA: 0x0005FAB8 File Offset: 0x0005DCB8
		private void InitializeComponent()
		{
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new global::System.Windows.Forms.DataGridViewCellStyle();
			this.bar1 = new global::DevComponents.DotNetBar.Bar();
			this.btnImport = new global::DevComponents.DotNetBar.ButtonItem();
			this.dgvData = new global::DevComponents.DotNetBar.Controls.DataGridViewX();
			this.C_ID = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_ModelName = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_ModelCode = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_ModelIndex = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_Creater = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_CreateTime = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_Modifier = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_ModifyTime = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_StepCount = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_ResetNum = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_StepDesc = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_Enable = new global::System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.C_Pinyinma = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			((global::System.ComponentModel.ISupportInitialize)this.bar1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.dgvData).BeginInit();
			base.SuspendLayout();
			this.bar1.AntiAlias = true;
			this.bar1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.bar1.Font = new global::System.Drawing.Font("Microsoft YaHei UI", 9f);
			this.bar1.IsMaximized = false;
			this.bar1.Items.AddRange(new global::DevComponents.DotNetBar.BaseItem[]
			{
				this.btnImport
			});
			this.bar1.Location = new global::System.Drawing.Point(0, 0);
			this.bar1.Name = "bar1";
			this.bar1.Size = new global::System.Drawing.Size(1125, 26);
			this.bar1.Stretch = true;
			this.bar1.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.bar1.TabIndex = 0;
			this.bar1.TabStop = false;
			this.bar1.Text = "bar1";
			this.btnImport.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.btnImport.Image = global::SQSClient.Properties.Resources.modify16;
			this.btnImport.Name = "btnImport";
			this.btnImport.Text = "Import";
			this.btnImport.Click += new global::System.EventHandler(this.btnImport_Click);
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
				this.C_ModelName,
				this.C_ModelCode,
				this.C_ModelIndex,
				this.C_Creater,
				this.C_CreateTime,
				this.C_Modifier,
				this.C_ModifyTime,
				this.C_StepCount,
				this.C_ResetNum,
				this.C_StepDesc,
				this.C_Enable,
				this.C_Pinyinma
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
			this.dgvData.SelectionChanged += new global::System.EventHandler(this.dgvData_SelectionChanged);
			this.C_ID.HeaderText = "ID";
			this.C_ID.Name = "C_ID";
			this.C_ID.ReadOnly = true;
			this.C_ID.Visible = false;
			this.C_ModelName.FillWeight = 120f;
			this.C_ModelName.HeaderText = "SrmName";
			this.C_ModelName.Name = "C_ModelName";
			this.C_ModelName.ReadOnly = true;
			this.C_ModelCode.FillWeight = 81.13367f;
			this.C_ModelCode.HeaderText = "SrmCode";
			this.C_ModelCode.Name = "C_ModelCode";
			this.C_ModelCode.ReadOnly = true;
			this.C_ModelIndex.FillWeight = 81.13367f;
			this.C_ModelIndex.HeaderText = "SrmIndex";
			this.C_ModelIndex.Name = "C_ModelIndex";
			this.C_ModelIndex.ReadOnly = true;
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
			this.C_StepCount.HeaderText = "SrmStepCount";
			this.C_StepCount.Name = "C_StepCount";
			this.C_StepCount.ReadOnly = true;
			this.C_ResetNum.HeaderText = "SrmResetNum";
			this.C_ResetNum.Name = "C_ResetNum";
			this.C_ResetNum.ReadOnly = true;
			this.C_StepDesc.HeaderText = "Memo";
			this.C_StepDesc.Name = "C_StepDesc";
			this.C_StepDesc.ReadOnly = true;
			this.C_Enable.HeaderText = "Enable";
			this.C_Enable.Name = "C_Enable";
			this.C_Enable.ReadOnly = true;
			this.C_Pinyinma.FillWeight = 81.13367f;
			this.C_Pinyinma.HeaderText = "PinYinMa";
			this.C_Pinyinma.Name = "C_Pinyinma";
			this.C_Pinyinma.ReadOnly = true;
			base.ClientSize = new global::System.Drawing.Size(1125, 421);
			base.Controls.Add(this.dgvData);
			base.Controls.Add(this.bar1);
			base.Name = "frmInvModelN";
			this.Text = "SrmInvModel";
			base.Load += new global::System.EventHandler(this.frmInvModelN_Load);
			((global::System.ComponentModel.ISupportInitialize)this.bar1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.dgvData).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x0400065F RID: 1631
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000660 RID: 1632
		private global::DevComponents.DotNetBar.Bar bar1;

		// Token: 0x04000661 RID: 1633
		private global::DevComponents.DotNetBar.Controls.DataGridViewX dgvData;

		// Token: 0x04000662 RID: 1634
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_ID;

		// Token: 0x04000663 RID: 1635
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_ModelName;

		// Token: 0x04000664 RID: 1636
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_ModelCode;

		// Token: 0x04000665 RID: 1637
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_ModelIndex;

		// Token: 0x04000666 RID: 1638
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_Creater;

		// Token: 0x04000667 RID: 1639
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_CreateTime;

		// Token: 0x04000668 RID: 1640
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_Modifier;

		// Token: 0x04000669 RID: 1641
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_ModifyTime;

		// Token: 0x0400066A RID: 1642
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_StepCount;

		// Token: 0x0400066B RID: 1643
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_ResetNum;

		// Token: 0x0400066C RID: 1644
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_StepDesc;

		// Token: 0x0400066D RID: 1645
		private global::System.Windows.Forms.DataGridViewCheckBoxColumn C_Enable;

		// Token: 0x0400066E RID: 1646
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_Pinyinma;

		// Token: 0x0400066F RID: 1647
		private global::DevComponents.DotNetBar.ButtonItem btnImport;
	}
}
