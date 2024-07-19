namespace SQSClient
{
	// Token: 0x02000056 RID: 86
	public partial class frmStepUnit : global::SQSClient.BaseDialogForm
	{
		// Token: 0x06000429 RID: 1065 RVA: 0x00069848 File Offset: 0x00067A48
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600042A RID: 1066 RVA: 0x00069880 File Offset: 0x00067A80
		private void InitializeComponent()
		{
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new global::System.Windows.Forms.DataGridViewCellStyle();
			this.bar1 = new global::DevComponents.DotNetBar.Bar();
			this.menuAdd = new global::DevComponents.DotNetBar.ButtonItem();
			this.menuModify = new global::DevComponents.DotNetBar.ButtonItem();
			this.menuDelete = new global::DevComponents.DotNetBar.ButtonItem();
			this.btnExport = new global::DevComponents.DotNetBar.ButtonItem();
			this.dgvData = new global::DevComponents.DotNetBar.Controls.DataGridViewX();
			this.C_ID = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_StepUnitName = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_StepUnitCode = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_StepUnitIndex = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_Creater = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_CreateTime = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_Modifier = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_ModifyTime = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_EquipIndex = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_StepIndex = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_StepDesc = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_State = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
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
				this.menuAdd,
				this.menuModify,
				this.menuDelete,
				this.btnExport
			});
			this.bar1.Location = new global::System.Drawing.Point(0, 0);
			this.bar1.Name = "bar1";
			this.bar1.Size = new global::System.Drawing.Size(1125, 26);
			this.bar1.Stretch = true;
			this.bar1.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.bar1.TabIndex = 0;
			this.bar1.TabStop = false;
			this.bar1.Text = "bar1";
			this.menuAdd.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.menuAdd.Image = global::SQSClient.Properties.Resources.add16;
			this.menuAdd.Name = "menuAdd";
			this.menuAdd.Text = "Add";
			this.menuAdd.Click += new global::System.EventHandler(this.menuAdd_Click);
			this.menuModify.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.menuModify.Image = global::SQSClient.Properties.Resources.modify16;
			this.menuModify.Name = "menuModify";
			this.menuModify.Text = "Modify";
			this.menuModify.Click += new global::System.EventHandler(this.menuModify_Click);
			this.menuDelete.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.menuDelete.Image = global::SQSClient.Properties.Resources.delete16;
			this.menuDelete.Name = "menuDelete";
			this.menuDelete.Text = "Delete";
			this.menuDelete.Click += new global::System.EventHandler(this.menuDelete_Click);
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
				this.C_StepUnitName,
				this.C_StepUnitCode,
				this.C_StepUnitIndex,
				this.C_Creater,
				this.C_CreateTime,
				this.C_Modifier,
				this.C_ModifyTime,
				this.C_EquipIndex,
				this.C_StepIndex,
				this.C_StepDesc,
				this.C_State,
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
			this.dgvData.CellDoubleClick += new global::System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellDoubleClick);
			this.dgvData.SelectionChanged += new global::System.EventHandler(this.dgvData_SelectionChanged);
			this.C_ID.HeaderText = "ID";
			this.C_ID.Name = "C_ID";
			this.C_ID.ReadOnly = true;
			this.C_ID.Visible = false;
			this.C_StepUnitName.FillWeight = 120f;
			this.C_StepUnitName.HeaderText = "SrmName";
			this.C_StepUnitName.Name = "C_StepUnitName";
			this.C_StepUnitName.ReadOnly = true;
			this.C_StepUnitCode.FillWeight = 81.13367f;
			this.C_StepUnitCode.HeaderText = "SrmCode";
			this.C_StepUnitCode.Name = "C_StepUnitCode";
			this.C_StepUnitCode.ReadOnly = true;
			this.C_StepUnitIndex.FillWeight = 81.13367f;
			this.C_StepUnitIndex.HeaderText = "SrmIndex";
			this.C_StepUnitIndex.Name = "C_StepUnitIndex";
			this.C_StepUnitIndex.ReadOnly = true;
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
			this.C_EquipIndex.HeaderText = "SrmEquipIndex";
			this.C_EquipIndex.Name = "C_EquipIndex";
			this.C_EquipIndex.ReadOnly = true;
			this.C_StepIndex.HeaderText = "SrmStepIndex";
			this.C_StepIndex.Name = "C_StepIndex";
			this.C_StepIndex.ReadOnly = true;
			this.C_StepDesc.HeaderText = "Memo";
			this.C_StepDesc.Name = "C_StepDesc";
			this.C_StepDesc.ReadOnly = true;
			this.C_State.HeaderText = "SrmState";
			this.C_State.Name = "C_State";
			this.C_State.ReadOnly = true;
			this.C_Pinyinma.FillWeight = 81.13367f;
			this.C_Pinyinma.HeaderText = "PinYinMa";
			this.C_Pinyinma.Name = "C_Pinyinma";
			this.C_Pinyinma.ReadOnly = true;
			base.ClientSize = new global::System.Drawing.Size(1125, 421);
			base.Controls.Add(this.dgvData);
			base.Controls.Add(this.bar1);
			base.Name = "frmStepUnit";
			this.Text = "SrmUnitStep";
			base.Load += new global::System.EventHandler(this.frmStepUnit_Load);
			((global::System.ComponentModel.ISupportInitialize)this.bar1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.dgvData).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000732 RID: 1842
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000733 RID: 1843
		private global::DevComponents.DotNetBar.Bar bar1;

		// Token: 0x04000734 RID: 1844
		private global::DevComponents.DotNetBar.ButtonItem menuAdd;

		// Token: 0x04000735 RID: 1845
		private global::DevComponents.DotNetBar.ButtonItem menuModify;

		// Token: 0x04000736 RID: 1846
		private global::DevComponents.DotNetBar.ButtonItem menuDelete;

		// Token: 0x04000737 RID: 1847
		private global::DevComponents.DotNetBar.ButtonItem btnExport;

		// Token: 0x04000738 RID: 1848
		private global::DevComponents.DotNetBar.Controls.DataGridViewX dgvData;

		// Token: 0x04000739 RID: 1849
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_ID;

		// Token: 0x0400073A RID: 1850
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_StepUnitName;

		// Token: 0x0400073B RID: 1851
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_StepUnitCode;

		// Token: 0x0400073C RID: 1852
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_StepUnitIndex;

		// Token: 0x0400073D RID: 1853
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_Creater;

		// Token: 0x0400073E RID: 1854
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_CreateTime;

		// Token: 0x0400073F RID: 1855
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_Modifier;

		// Token: 0x04000740 RID: 1856
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_ModifyTime;

		// Token: 0x04000741 RID: 1857
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_EquipIndex;

		// Token: 0x04000742 RID: 1858
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_StepIndex;

		// Token: 0x04000743 RID: 1859
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_StepDesc;

		// Token: 0x04000744 RID: 1860
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_State;

		// Token: 0x04000745 RID: 1861
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_Pinyinma;
	}
}
