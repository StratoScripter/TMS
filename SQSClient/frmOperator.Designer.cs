namespace SQSClient
{
	// Token: 0x0200003C RID: 60
	public partial class frmOperator : global::SQSClient.BaseDialogForm
	{
		// Token: 0x060002C8 RID: 712 RVA: 0x00048568 File Offset: 0x00046768
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x000485A0 File Offset: 0x000467A0
		private void InitializeComponent()
		{
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::SQSClient.frmOperator));
			this.bar = new global::DevComponents.DotNetBar.Bar();
			this.line2 = new global::DevComponents.DotNetBar.Controls.Line();
			this.btnAdd = new global::DevComponents.DotNetBar.ButtonItem();
			this.btnModify = new global::DevComponents.DotNetBar.ButtonItem();
			this.btnDelete = new global::DevComponents.DotNetBar.ButtonItem();
			this.controlContainerItem1 = new global::DevComponents.DotNetBar.ControlContainerItem();
			this.labOperator = new global::DevComponents.DotNetBar.LabelItem();
			this.txtName = new global::DevComponents.DotNetBar.TextBoxItem();
			this.btnSearch = new global::DevComponents.DotNetBar.ButtonItem();
			this.dgvData = new global::DevComponents.DotNetBar.Controls.DataGridViewX();
			this.C_Id = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_Operator = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_EmployeeNumber = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_OPassword = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_ICCard = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_State = new global::System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.C_Remark = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.line1 = new global::DevComponents.DotNetBar.Controls.Line();
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
				this.labOperator,
				this.txtName,
				this.btnSearch
			});
			this.bar.Location = new global::System.Drawing.Point(0, 0);
			this.bar.Name = "bar";
			this.bar.Size = new global::System.Drawing.Size(862, 27);
			this.bar.Stretch = true;
			this.bar.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.bar.TabIndex = 2;
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
			this.labOperator.Name = "labOperator";
			this.labOperator.Text = "Operator";
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
			this.dgvData.AllowUserToAddRows = false;
			this.dgvData.AllowUserToDeleteRows = false;
			this.dgvData.AutoSizeColumnsMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvData.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvData.Columns.AddRange(new global::System.Windows.Forms.DataGridViewColumn[]
			{
				this.C_Id,
				this.C_Operator,
				this.C_EmployeeNumber,
				this.C_OPassword,
				this.C_ICCard,
				this.C_State,
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
			this.dgvData.Size = new global::System.Drawing.Size(862, 346);
			this.dgvData.TabIndex = 3;
			this.dgvData.CellClick += new global::System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellClick);
			this.dgvData.CellDoubleClick += new global::System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellDoubleClick);
			this.C_Id.HeaderText = "ID";
			this.C_Id.Name = "C_Id";
			this.C_Id.ReadOnly = true;
			this.C_Operator.HeaderText = "Operator";
			this.C_Operator.Name = "C_Operator";
			this.C_Operator.ReadOnly = true;
			this.C_EmployeeNumber.HeaderText = "EmployeeNumber";
			this.C_EmployeeNumber.Name = "C_EmployeeNumber";
			this.C_EmployeeNumber.ReadOnly = true;
			this.C_OPassword.HeaderText = "OPassword";
			this.C_OPassword.Name = "C_OPassword";
			this.C_OPassword.ReadOnly = true;
			this.C_ICCard.HeaderText = "ICCard";
			this.C_ICCard.Name = "C_ICCard";
			this.C_ICCard.ReadOnly = true;
			this.C_State.HeaderText = "Enable";
			this.C_State.Name = "C_State";
			this.C_State.ReadOnly = true;
			this.C_State.Resizable = global::System.Windows.Forms.DataGridViewTriState.True;
			this.C_State.SortMode = global::System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.C_Remark.HeaderText = "Remark";
			this.C_Remark.Name = "C_Remark";
			this.C_Remark.ReadOnly = true;
			this.line1.ForeColor = global::System.Drawing.SystemColors.ActiveCaption;
			this.line1.Location = new global::System.Drawing.Point(165, 3);
			this.line1.Name = "line1";
			this.line1.Size = new global::System.Drawing.Size(1, 20);
			this.line1.TabIndex = 16;
			this.line1.Text = "line1";
			this.line1.VerticalLine = true;
			base.ClientSize = new global::System.Drawing.Size(862, 373);
			base.Controls.Add(this.dgvData);
			base.Controls.Add(this.bar);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "frmOperator";
			this.Text = "frmOperator";
			base.Load += new global::System.EventHandler(this.frmOperator_Load);
			((global::System.ComponentModel.ISupportInitialize)this.bar).EndInit();
			this.bar.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.dgvData).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x0400047B RID: 1147
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400047C RID: 1148
		private global::DevComponents.DotNetBar.Bar bar;

		// Token: 0x0400047D RID: 1149
		private global::DevComponents.DotNetBar.ButtonItem btnAdd;

		// Token: 0x0400047E RID: 1150
		private global::DevComponents.DotNetBar.ButtonItem btnModify;

		// Token: 0x0400047F RID: 1151
		private global::DevComponents.DotNetBar.ButtonItem btnDelete;

		// Token: 0x04000480 RID: 1152
		private global::DevComponents.DotNetBar.Controls.DataGridViewX dgvData;

		// Token: 0x04000481 RID: 1153
		private global::DevComponents.DotNetBar.LabelItem labOperator;

		// Token: 0x04000482 RID: 1154
		private global::DevComponents.DotNetBar.TextBoxItem txtName;

		// Token: 0x04000483 RID: 1155
		private global::DevComponents.DotNetBar.ButtonItem btnSearch;

		// Token: 0x04000484 RID: 1156
		private global::DevComponents.DotNetBar.Controls.Line line2;

		// Token: 0x04000485 RID: 1157
		private global::DevComponents.DotNetBar.ControlContainerItem controlContainerItem1;

		// Token: 0x04000486 RID: 1158
		private global::DevComponents.DotNetBar.Controls.Line line1;

		// Token: 0x04000487 RID: 1159
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_Id;

		// Token: 0x04000488 RID: 1160
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_Operator;

		// Token: 0x04000489 RID: 1161
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_EmployeeNumber;

		// Token: 0x0400048A RID: 1162
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_OPassword;

		// Token: 0x0400048B RID: 1163
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_ICCard;

		// Token: 0x0400048C RID: 1164
		private global::System.Windows.Forms.DataGridViewCheckBoxColumn C_State;

		// Token: 0x0400048D RID: 1165
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_Remark;
	}
}
