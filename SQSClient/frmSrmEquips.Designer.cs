namespace SQSClient
{
	// Token: 0x02000050 RID: 80
	public partial class frmSrmEquips : global::SQSClient.BaseDialogForm
	{
		// Token: 0x060003E3 RID: 995 RVA: 0x0006216C File Offset: 0x0006036C
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060003E4 RID: 996 RVA: 0x000621A4 File Offset: 0x000603A4
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
			this.C_SrmEquipsName = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_SrmEquipsCode = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_SrmEquipsIndex = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_Creater = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_CreateTime = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_Modifier = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_ModifyTime = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_VenCode = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
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
				this.C_SrmEquipsName,
				this.C_SrmEquipsCode,
				this.C_SrmEquipsIndex,
				this.C_Creater,
				this.C_CreateTime,
				this.C_Modifier,
				this.C_ModifyTime,
				this.C_VenCode,
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
			this.C_SrmEquipsName.FillWeight = 120f;
			this.C_SrmEquipsName.HeaderText = "SrmName";
			this.C_SrmEquipsName.Name = "C_SrmEquipsName";
			this.C_SrmEquipsName.ReadOnly = true;
			this.C_SrmEquipsCode.FillWeight = 81.13367f;
			this.C_SrmEquipsCode.HeaderText = "SrmCode";
			this.C_SrmEquipsCode.Name = "C_SrmEquipsCode";
			this.C_SrmEquipsCode.ReadOnly = true;
			this.C_SrmEquipsIndex.FillWeight = 81.13367f;
			this.C_SrmEquipsIndex.HeaderText = "SrmIndex";
			this.C_SrmEquipsIndex.Name = "C_SrmEquipsIndex";
			this.C_SrmEquipsIndex.ReadOnly = true;
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
			this.C_VenCode.HeaderText = "SrmVenCode";
			this.C_VenCode.Name = "C_VenCode";
			this.C_VenCode.ReadOnly = true;
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
			base.Name = "frmSrmEquips";
			this.Text = "SrmEquip";
			base.Load += new global::System.EventHandler(this.frmSrmEquips_Load);
			((global::System.ComponentModel.ISupportInitialize)this.bar1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.dgvData).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000696 RID: 1686
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000697 RID: 1687
		private global::DevComponents.DotNetBar.Bar bar1;

		// Token: 0x04000698 RID: 1688
		private global::DevComponents.DotNetBar.ButtonItem menuAdd;

		// Token: 0x04000699 RID: 1689
		private global::DevComponents.DotNetBar.ButtonItem menuModify;

		// Token: 0x0400069A RID: 1690
		private global::DevComponents.DotNetBar.ButtonItem menuDelete;

		// Token: 0x0400069B RID: 1691
		private global::DevComponents.DotNetBar.ButtonItem btnExport;

		// Token: 0x0400069C RID: 1692
		private global::DevComponents.DotNetBar.Controls.DataGridViewX dgvData;

		// Token: 0x0400069D RID: 1693
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_ID;

		// Token: 0x0400069E RID: 1694
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_SrmEquipsName;

		// Token: 0x0400069F RID: 1695
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_SrmEquipsCode;

		// Token: 0x040006A0 RID: 1696
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_SrmEquipsIndex;

		// Token: 0x040006A1 RID: 1697
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_Creater;

		// Token: 0x040006A2 RID: 1698
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_CreateTime;

		// Token: 0x040006A3 RID: 1699
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_Modifier;

		// Token: 0x040006A4 RID: 1700
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_ModifyTime;

		// Token: 0x040006A5 RID: 1701
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_VenCode;

		// Token: 0x040006A6 RID: 1702
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_StepDesc;

		// Token: 0x040006A7 RID: 1703
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_State;

		// Token: 0x040006A8 RID: 1704
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_Pinyinma;
	}
}
