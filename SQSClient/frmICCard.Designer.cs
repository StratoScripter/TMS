namespace SQSClient
{
	// Token: 0x02000073 RID: 115
	public partial class frmICCard : global::SQSClient.BaseDialogForm
	{
		// Token: 0x06000642 RID: 1602 RVA: 0x0009B188 File Offset: 0x00099388
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000643 RID: 1603 RVA: 0x0009B1C0 File Offset: 0x000993C0
		private void InitializeComponent()
		{
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::SQSClient.frmICCard));
			this.dgvData = new global::DevComponents.DotNetBar.Controls.DataGridViewX();
			this.C_Id = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_IC = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_IDNum = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_BlockValue = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_Status = new global::DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn();
			this.C_Remark = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bar = new global::DevComponents.DotNetBar.Bar();
			this.line2 = new global::DevComponents.DotNetBar.Controls.Line();
			this.btnAdd = new global::DevComponents.DotNetBar.ButtonItem();
			this.btnModify = new global::DevComponents.DotNetBar.ButtonItem();
			this.btnDelete = new global::DevComponents.DotNetBar.ButtonItem();
			this.controlContainerItem1 = new global::DevComponents.DotNetBar.ControlContainerItem();
			this.labIC = new global::DevComponents.DotNetBar.LabelItem();
			this.txtName = new global::DevComponents.DotNetBar.TextBoxItem();
			this.btnSearch = new global::DevComponents.DotNetBar.ButtonItem();
			this.btnICCardWR = new global::DevComponents.DotNetBar.ButtonItem();
			this.btnReadCard = new global::DevComponents.DotNetBar.ButtonItem();
			((global::System.ComponentModel.ISupportInitialize)this.dgvData).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.bar).BeginInit();
			this.bar.SuspendLayout();
			base.SuspendLayout();
			this.dgvData.AllowUserToAddRows = false;
			this.dgvData.AllowUserToDeleteRows = false;
			this.dgvData.AutoSizeColumnsMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvData.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvData.Columns.AddRange(new global::System.Windows.Forms.DataGridViewColumn[]
			{
				this.C_Id,
				this.C_IC,
				this.C_IDNum,
				this.C_BlockValue,
				this.C_Status,
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
			this.dgvData.TabIndex = 2;
			this.dgvData.CellClick += new global::System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellClick);
			this.dgvData.CellDoubleClick += new global::System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellDoubleClick);
			this.C_Id.HeaderText = "ID";
			this.C_Id.Name = "C_Id";
			this.C_Id.ReadOnly = true;
			this.C_Id.Visible = false;
			this.C_IC.HeaderText = "IC";
			this.C_IC.Name = "C_IC";
			this.C_IC.ReadOnly = true;
			this.C_IDNum.HeaderText = "IDNum";
			this.C_IDNum.Name = "C_IDNum";
			this.C_IDNum.ReadOnly = true;
			this.C_BlockValue.HeaderText = "BlockValue";
			this.C_BlockValue.Name = "C_BlockValue";
			this.C_BlockValue.ReadOnly = true;
			this.C_Status.Checked = true;
			this.C_Status.CheckState = global::System.Windows.Forms.CheckState.Indeterminate;
			this.C_Status.CheckValue = "N";
			this.C_Status.HeaderText = "Status";
			this.C_Status.Name = "C_Status";
			this.C_Status.ReadOnly = true;
			this.C_Status.Resizable = global::System.Windows.Forms.DataGridViewTriState.True;
			this.C_Status.SortMode = global::System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.C_Remark.HeaderText = "Remark";
			this.C_Remark.Name = "C_Remark";
			this.C_Remark.ReadOnly = true;
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
				this.labIC,
				this.txtName,
				this.btnReadCard,
				this.btnSearch,
				this.btnICCardWR
			});
			this.bar.Location = new global::System.Drawing.Point(0, 0);
			this.bar.Name = "bar";
			this.bar.Size = new global::System.Drawing.Size(954, 27);
			this.bar.Stretch = true;
			this.bar.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.bar.TabIndex = 1;
			this.bar.TabStop = false;
			this.bar.Text = "bar1";
			this.line2.ForeColor = global::System.Drawing.SystemColors.ActiveCaption;
			this.line2.Location = new global::System.Drawing.Point(196, 3);
			this.line2.Name = "line2";
			this.line2.Size = new global::System.Drawing.Size(1, 20);
			this.line2.TabIndex = 16;
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
			this.labIC.Name = "labIC";
			this.labIC.Text = "IC";
			this.txtName.MaxLength = 20;
			this.txtName.Name = "txtName";
			this.txtName.TextBoxWidth = 120;
			this.txtName.WatermarkColor = global::System.Drawing.SystemColors.GrayText;
			this.txtName.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
			this.btnSearch.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.btnSearch.Image = global::SQSClient.Properties.Resources.search16;
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Text = "Search";
			this.btnSearch.Click += new global::System.EventHandler(this.btnSearch_Click);
			this.btnICCardWR.ItemAlignment = global::DevComponents.DotNetBar.eItemAlignment.Far;
			this.btnICCardWR.Name = "btnICCardWR";
			this.btnICCardWR.Text = "ICCardWR";
			this.btnICCardWR.Click += new global::System.EventHandler(this.btnICCardWR_Click);
			this.btnReadCard.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.btnReadCard.Image = global::SQSClient.Properties.Resources.search16;
			this.btnReadCard.Name = "btnReadCard";
			this.btnReadCard.Text = "ReadCard";
			this.btnReadCard.Click += new global::System.EventHandler(this.btnReadCard_Click);
			base.ClientSize = new global::System.Drawing.Size(954, 372);
			base.Controls.Add(this.dgvData);
			base.Controls.Add(this.bar);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "frmICCard";
			this.Text = "ICCard";
			base.Load += new global::System.EventHandler(this.frmICCard_Load);
			((global::System.ComponentModel.ISupportInitialize)this.dgvData).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.bar).EndInit();
			this.bar.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x04000AA8 RID: 2728
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000AA9 RID: 2729
		private global::DevComponents.DotNetBar.Bar bar;

		// Token: 0x04000AAA RID: 2730
		private global::DevComponents.DotNetBar.ButtonItem btnAdd;

		// Token: 0x04000AAB RID: 2731
		private global::DevComponents.DotNetBar.ButtonItem btnModify;

		// Token: 0x04000AAC RID: 2732
		private global::DevComponents.DotNetBar.ButtonItem btnDelete;

		// Token: 0x04000AAD RID: 2733
		private global::DevComponents.DotNetBar.Controls.DataGridViewX dgvData;

		// Token: 0x04000AAE RID: 2734
		private global::DevComponents.DotNetBar.LabelItem labIC;

		// Token: 0x04000AAF RID: 2735
		private global::DevComponents.DotNetBar.TextBoxItem txtName;

		// Token: 0x04000AB0 RID: 2736
		private global::DevComponents.DotNetBar.ButtonItem btnSearch;

		// Token: 0x04000AB1 RID: 2737
		private global::DevComponents.DotNetBar.Controls.Line line2;

		// Token: 0x04000AB2 RID: 2738
		private global::DevComponents.DotNetBar.ControlContainerItem controlContainerItem1;

		// Token: 0x04000AB3 RID: 2739
		private global::DevComponents.DotNetBar.ButtonItem btnICCardWR;

		// Token: 0x04000AB4 RID: 2740
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_Id;

		// Token: 0x04000AB5 RID: 2741
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_IC;

		// Token: 0x04000AB6 RID: 2742
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_IDNum;

		// Token: 0x04000AB7 RID: 2743
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_BlockValue;

		// Token: 0x04000AB8 RID: 2744
		private global::DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn C_Status;

		// Token: 0x04000AB9 RID: 2745
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_Remark;

		// Token: 0x04000ABA RID: 2746
		private global::DevComponents.DotNetBar.ButtonItem btnReadCard;
	}
}
