namespace SQSClient
{
	// Token: 0x02000060 RID: 96
	public partial class frmSystemPara : global::SQSClient.BaseDialogForm
	{
		// Token: 0x0600049C RID: 1180 RVA: 0x000743F4 File Offset: 0x000725F4
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600049D RID: 1181 RVA: 0x0007442C File Offset: 0x0007262C
		private void InitializeComponent()
		{
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new global::System.Windows.Forms.DataGridViewCellStyle();
			this.dgvData = new global::DevComponents.DotNetBar.Controls.DataGridViewX();
			this.PortName = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_Keyword = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_Value = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_Remark = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bar = new global::DevComponents.DotNetBar.Bar();
			this.btnModify = new global::DevComponents.DotNetBar.ButtonItem();
			((global::System.ComponentModel.ISupportInitialize)this.dgvData).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.bar).BeginInit();
			base.SuspendLayout();
			this.dgvData.AllowUserToAddRows = false;
			this.dgvData.AllowUserToDeleteRows = false;
			this.dgvData.AutoSizeColumnsMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvData.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvData.Columns.AddRange(new global::System.Windows.Forms.DataGridViewColumn[]
			{
				this.PortName,
				this.C_Keyword,
				this.C_Value,
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
			this.dgvData.Size = new global::System.Drawing.Size(779, 390);
			this.dgvData.TabIndex = 6;
			this.dgvData.CellClick += new global::System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellClick);
			this.dgvData.CellDoubleClick += new global::System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellDoubleClick);
			this.PortName.HeaderText = "ID";
			this.PortName.Name = "PortName";
			this.PortName.ReadOnly = true;
			this.C_Keyword.HeaderText = "Keyword";
			this.C_Keyword.Name = "C_Keyword";
			this.C_Keyword.ReadOnly = true;
			this.C_Value.HeaderText = "Value";
			this.C_Value.Name = "C_Value";
			this.C_Value.ReadOnly = true;
			this.C_Remark.HeaderText = "Remark";
			this.C_Remark.Name = "C_Remark";
			this.C_Remark.ReadOnly = true;
			this.bar.AntiAlias = true;
			this.bar.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.bar.Font = new global::System.Drawing.Font("微软雅黑", 9f);
			this.bar.IsMaximized = false;
			this.bar.Items.AddRange(new global::DevComponents.DotNetBar.BaseItem[]
			{
				this.btnModify
			});
			this.bar.Location = new global::System.Drawing.Point(0, 0);
			this.bar.Name = "bar";
			this.bar.Size = new global::System.Drawing.Size(779, 27);
			this.bar.Stretch = true;
			this.bar.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.bar.TabIndex = 5;
			this.bar.TabStop = false;
			this.bar.Text = "bar1";
			this.btnModify.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.btnModify.Image = global::SQSClient.Properties.Resources.modify16;
			this.btnModify.Name = "btnModify";
			this.btnModify.Text = "Modify";
			this.btnModify.Click += new global::System.EventHandler(this.btnModify_Click);
			base.ClientSize = new global::System.Drawing.Size(779, 417);
			base.Controls.Add(this.dgvData);
			base.Controls.Add(this.bar);
			base.Name = "frmSystemPara";
			this.Text = "SystemPara";
			base.Load += new global::System.EventHandler(this.frmSystemPara_Load);
			((global::System.ComponentModel.ISupportInitialize)this.dgvData).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.bar).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x040007FC RID: 2044
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x040007FD RID: 2045
		private global::DevComponents.DotNetBar.Controls.DataGridViewX dgvData;

		// Token: 0x040007FE RID: 2046
		private global::DevComponents.DotNetBar.Bar bar;

		// Token: 0x040007FF RID: 2047
		private global::DevComponents.DotNetBar.ButtonItem btnModify;

		// Token: 0x04000800 RID: 2048
		private global::System.Windows.Forms.DataGridViewTextBoxColumn PortName;

		// Token: 0x04000801 RID: 2049
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_Keyword;

		// Token: 0x04000802 RID: 2050
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_Value;

		// Token: 0x04000803 RID: 2051
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_Remark;
	}
}
