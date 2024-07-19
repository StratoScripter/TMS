namespace SQSClient
{
	// Token: 0x02000085 RID: 133
	public partial class frmKeyCode : global::SQSClient.BaseDialogForm
	{
		// Token: 0x0600073B RID: 1851 RVA: 0x000B3B98 File Offset: 0x000B1D98
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600073C RID: 1852 RVA: 0x000B3BD0 File Offset: 0x000B1DD0
		private void InitializeComponent()
		{
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::SQSClient.frmKeyCode));
			this.bar = new global::DevComponents.DotNetBar.Bar();
			this.btnModify = new global::DevComponents.DotNetBar.ButtonItem();
			this.dgvData = new global::DevComponents.DotNetBar.Controls.DataGridViewX();
			this.PortName = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_Keyword = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_Value = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_Remark = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			((global::System.ComponentModel.ISupportInitialize)this.bar).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.dgvData).BeginInit();
			base.SuspendLayout();
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
			this.bar.Size = new global::System.Drawing.Size(954, 27);
			this.bar.Stretch = true;
			this.bar.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.bar.TabIndex = 3;
			this.bar.TabStop = false;
			this.bar.Text = "bar1";
			this.btnModify.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.btnModify.Image = global::SQSClient.Properties.Resources.modify16;
			this.btnModify.Name = "btnModify";
			this.btnModify.Text = "Modify";
			this.btnModify.Click += new global::System.EventHandler(this.btnModify_Click);
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
			this.dgvData.Size = new global::System.Drawing.Size(954, 345);
			this.dgvData.TabIndex = 4;
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
			base.ClientSize = new global::System.Drawing.Size(954, 372);
			base.Controls.Add(this.dgvData);
			base.Controls.Add(this.bar);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "frmKeyCode";
			this.Text = "LocalPara";
			base.Load += new global::System.EventHandler(this.frmKeyCode_Load);
			((global::System.ComponentModel.ISupportInitialize)this.bar).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.dgvData).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000C4F RID: 3151
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000C50 RID: 3152
		private global::DevComponents.DotNetBar.Bar bar;

		// Token: 0x04000C51 RID: 3153
		private global::DevComponents.DotNetBar.ButtonItem btnModify;

		// Token: 0x04000C52 RID: 3154
		private global::DevComponents.DotNetBar.Controls.DataGridViewX dgvData;

		// Token: 0x04000C53 RID: 3155
		private global::System.Windows.Forms.DataGridViewTextBoxColumn PortName;

		// Token: 0x04000C54 RID: 3156
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_Keyword;

		// Token: 0x04000C55 RID: 3157
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_Value;

		// Token: 0x04000C56 RID: 3158
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_Remark;
	}
}
