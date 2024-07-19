namespace SQSClient
{
	// Token: 0x02000076 RID: 118
	public partial class frmUnitCheck : global::SQSClient.BaseDialogForm
	{
		// Token: 0x06000672 RID: 1650 RVA: 0x0009EB84 File Offset: 0x0009CD84
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000673 RID: 1651 RVA: 0x0009EBBC File Offset: 0x0009CDBC
		private void InitializeComponent()
		{
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::SQSClient.frmUnitCheck));
			this.bar1 = new global::DevComponents.DotNetBar.Bar();
			this.tsbtnCheckAll = new global::DevComponents.DotNetBar.ButtonItem();
			this.tsbtnCheckNone = new global::DevComponents.DotNetBar.ButtonItem();
			this.tsbtnOther = new global::DevComponents.DotNetBar.ButtonItem();
			this.tsbtnSave = new global::DevComponents.DotNetBar.ButtonItem();
			this.dgvUnit = new global::DevComponents.DotNetBar.Controls.DataGridViewX();
			this.C_Check = new global::System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.C_ID = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_Name = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_Device = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_Index = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_Remark = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			((global::System.ComponentModel.ISupportInitialize)this.bar1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.dgvUnit).BeginInit();
			base.SuspendLayout();
			this.bar1.AntiAlias = true;
			this.bar1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.bar1.Font = new global::System.Drawing.Font("微软雅黑", 9f);
			this.bar1.IsMaximized = false;
			this.bar1.Items.AddRange(new global::DevComponents.DotNetBar.BaseItem[]
			{
				this.tsbtnCheckAll,
				this.tsbtnCheckNone,
				this.tsbtnOther,
				this.tsbtnSave
			});
			this.bar1.Location = new global::System.Drawing.Point(0, 0);
			this.bar1.Name = "bar1";
			this.bar1.Size = new global::System.Drawing.Size(636, 27);
			this.bar1.Stretch = true;
			this.bar1.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.bar1.TabIndex = 0;
			this.bar1.TabStop = false;
			this.bar1.Text = "bar1";
			this.tsbtnCheckAll.Name = "tsbtnCheckAll";
			this.tsbtnCheckAll.Text = "全选";
			this.tsbtnCheckAll.Click += new global::System.EventHandler(this.tsbtnCheckAll_Click);
			this.tsbtnCheckNone.Name = "tsbtnCheckNone";
			this.tsbtnCheckNone.Text = "全不选";
			this.tsbtnCheckNone.Click += new global::System.EventHandler(this.tsbtnCheckNone_Click);
			this.tsbtnOther.Name = "tsbtnOther";
			this.tsbtnOther.Text = "反选";
			this.tsbtnOther.Click += new global::System.EventHandler(this.tsbtnOther_Click);
			this.tsbtnSave.Name = "tsbtnSave";
			this.tsbtnSave.Text = "确定";
			this.tsbtnSave.Click += new global::System.EventHandler(this.tsbtnSave_Click);
			this.dgvUnit.AllowUserToAddRows = false;
			this.dgvUnit.AllowUserToDeleteRows = false;
			this.dgvUnit.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvUnit.Columns.AddRange(new global::System.Windows.Forms.DataGridViewColumn[]
			{
				this.C_Check,
				this.C_ID,
				this.C_Name,
				this.C_Device,
				this.C_Index,
				this.C_Remark
			});
			dataGridViewCellStyle.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle.BackColor = global::System.Drawing.SystemColors.Window;
			dataGridViewCellStyle.Font = new global::System.Drawing.Font("宋体", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 134);
			dataGridViewCellStyle.ForeColor = global::System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle.SelectionBackColor = global::System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle.SelectionForeColor = global::System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle.WrapMode = global::System.Windows.Forms.DataGridViewTriState.False;
			this.dgvUnit.DefaultCellStyle = dataGridViewCellStyle;
			this.dgvUnit.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.dgvUnit.GridColor = global::System.Drawing.Color.FromArgb(208, 215, 229);
			this.dgvUnit.Location = new global::System.Drawing.Point(0, 27);
			this.dgvUnit.Name = "dgvUnit";
			this.dgvUnit.ReadOnly = true;
			this.dgvUnit.RowTemplate.Height = 23;
			this.dgvUnit.Size = new global::System.Drawing.Size(636, 235);
			this.dgvUnit.TabIndex = 1;
			this.dgvUnit.CellClick += new global::System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUnit_CellClick);
			this.dgvUnit.CellDoubleClick += new global::System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUnit_CellDoubleClick);
			this.C_Check.HeaderText = "";
			this.C_Check.Name = "C_Check";
			this.C_Check.ReadOnly = true;
			this.C_ID.HeaderText = "ID";
			this.C_ID.Name = "C_ID";
			this.C_ID.ReadOnly = true;
			this.C_Name.HeaderText = "鹤位";
			this.C_Name.Name = "C_Name";
			this.C_Name.ReadOnly = true;
			this.C_Device.HeaderText = "控制器";
			this.C_Device.Name = "C_Device";
			this.C_Device.ReadOnly = true;
			this.C_Index.HeaderText = "路号";
			this.C_Index.Name = "C_Index";
			this.C_Index.ReadOnly = true;
			this.C_Remark.HeaderText = "备注";
			this.C_Remark.Name = "C_Remark";
			this.C_Remark.ReadOnly = true;
			base.ClientSize = new global::System.Drawing.Size(636, 262);
			base.Controls.Add(this.dgvUnit);
			base.Controls.Add(this.bar1);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "frmUnitCheck";
			this.Text = "鹤位筛选";
			base.Load += new global::System.EventHandler(this.frmUnitChoosing_Load);
			((global::System.ComponentModel.ISupportInitialize)this.bar1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.dgvUnit).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000AE5 RID: 2789
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000AE6 RID: 2790
		private global::DevComponents.DotNetBar.Bar bar1;

		// Token: 0x04000AE7 RID: 2791
		private global::DevComponents.DotNetBar.ButtonItem tsbtnCheckAll;

		// Token: 0x04000AE8 RID: 2792
		private global::DevComponents.DotNetBar.ButtonItem tsbtnCheckNone;

		// Token: 0x04000AE9 RID: 2793
		private global::DevComponents.DotNetBar.ButtonItem tsbtnOther;

		// Token: 0x04000AEA RID: 2794
		private global::DevComponents.DotNetBar.ButtonItem tsbtnSave;

		// Token: 0x04000AEB RID: 2795
		private global::DevComponents.DotNetBar.Controls.DataGridViewX dgvUnit;

		// Token: 0x04000AEC RID: 2796
		private global::System.Windows.Forms.DataGridViewCheckBoxColumn C_Check;

		// Token: 0x04000AED RID: 2797
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_ID;

		// Token: 0x04000AEE RID: 2798
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_Name;

		// Token: 0x04000AEF RID: 2799
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_Device;

		// Token: 0x04000AF0 RID: 2800
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_Index;

		// Token: 0x04000AF1 RID: 2801
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_Remark;
	}
}
