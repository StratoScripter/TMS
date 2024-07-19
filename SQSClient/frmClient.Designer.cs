namespace SQSClient
{
	// Token: 0x02000088 RID: 136
	public partial class frmClient : global::SQSClient.BaseDialogForm
	{
		// Token: 0x06000770 RID: 1904 RVA: 0x000B8584 File Offset: 0x000B6784
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000771 RID: 1905 RVA: 0x000B85BC File Offset: 0x000B67BC
		private void InitializeComponent()
		{
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::SQSClient.frmClient));
			this.bar = new global::DevComponents.DotNetBar.Bar();
			this.line2 = new global::DevComponents.DotNetBar.Controls.Line();
			this.btnAdd = new global::DevComponents.DotNetBar.ButtonItem();
			this.btnModify = new global::DevComponents.DotNetBar.ButtonItem();
			this.btnDelete = new global::DevComponents.DotNetBar.ButtonItem();
			this.controlContainerItem1 = new global::DevComponents.DotNetBar.ControlContainerItem();
			this.labName = new global::DevComponents.DotNetBar.LabelItem();
			this.txtName = new global::DevComponents.DotNetBar.TextBoxItem();
			this.btnSearch = new global::DevComponents.DotNetBar.ButtonItem();
			this.dgvData = new global::DevComponents.DotNetBar.Controls.DataGridViewX();
			this.C_Id = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_Clientpart = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_Addr = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_Person = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ClientCode = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_PhoneNum = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_Remark = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
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
				this.labName,
				this.txtName,
				this.btnSearch
			});
			this.bar.Location = new global::System.Drawing.Point(0, 0);
			this.bar.Name = "bar";
			this.bar.Size = new global::System.Drawing.Size(954, 27);
			this.bar.Stretch = true;
			this.bar.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.bar.TabIndex = 0;
			this.bar.TabStop = false;
			this.bar.Text = "bar1";
			this.line2.ForeColor = global::System.Drawing.SystemColors.ActiveCaption;
			this.line2.Location = new global::System.Drawing.Point(196, 3);
			this.line2.Name = "line2";
			this.line2.Size = new global::System.Drawing.Size(1, 20);
			this.line2.TabIndex = 17;
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
			this.labName.Name = "labName";
			this.labName.Text = "Clientpart";
			this.txtName.MaxLength = 50;
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
				this.C_Clientpart,
				this.C_Addr,
				this.C_Person,
				this.ClientCode,
				this.C_PhoneNum,
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
			this.dgvData.TabIndex = 1;
			this.dgvData.CellClick += new global::System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellClick);
			this.dgvData.CellDoubleClick += new global::System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellDoubleClick);
			this.C_Id.HeaderText = "ID";
			this.C_Id.Name = "C_Id";
			this.C_Id.ReadOnly = true;
			this.C_Id.Visible = false;
			this.C_Clientpart.HeaderText = "Clientpart";
			this.C_Clientpart.Name = "C_Clientpart";
			this.C_Clientpart.ReadOnly = true;
			this.C_Addr.HeaderText = "Addr";
			this.C_Addr.Name = "C_Addr";
			this.C_Addr.ReadOnly = true;
			this.C_Person.HeaderText = "Contact";
			this.C_Person.Name = "C_Person";
			this.C_Person.ReadOnly = true;
			this.ClientCode.HeaderText = "ClientCode";
			this.ClientCode.Name = "ClientCode";
			this.ClientCode.ReadOnly = true;
			this.C_PhoneNum.HeaderText = "PhoneNum";
			this.C_PhoneNum.Name = "C_PhoneNum";
			this.C_PhoneNum.ReadOnly = true;
			this.C_Remark.HeaderText = "Remark";
			this.C_Remark.Name = "C_Remark";
			this.C_Remark.ReadOnly = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 12f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(954, 372);
			base.Controls.Add(this.dgvData);
			base.Controls.Add(this.bar);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "frmClient";
			this.Text = "Clientpart";
			base.Load += new global::System.EventHandler(this.frmClient_Load);
			((global::System.ComponentModel.ISupportInitialize)this.bar).EndInit();
			this.bar.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.dgvData).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000C9F RID: 3231
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000CA0 RID: 3232
		private global::DevComponents.DotNetBar.Bar bar;

		// Token: 0x04000CA1 RID: 3233
		private global::DevComponents.DotNetBar.ButtonItem btnAdd;

		// Token: 0x04000CA2 RID: 3234
		private global::DevComponents.DotNetBar.ButtonItem btnModify;

		// Token: 0x04000CA3 RID: 3235
		private global::DevComponents.DotNetBar.ButtonItem btnDelete;

		// Token: 0x04000CA4 RID: 3236
		private global::DevComponents.DotNetBar.Controls.DataGridViewX dgvData;

		// Token: 0x04000CA5 RID: 3237
		private global::DevComponents.DotNetBar.LabelItem labName;

		// Token: 0x04000CA6 RID: 3238
		private global::DevComponents.DotNetBar.TextBoxItem txtName;

		// Token: 0x04000CA7 RID: 3239
		private global::DevComponents.DotNetBar.ButtonItem btnSearch;

		// Token: 0x04000CA8 RID: 3240
		private global::DevComponents.DotNetBar.Controls.Line line2;

		// Token: 0x04000CA9 RID: 3241
		private global::DevComponents.DotNetBar.ControlContainerItem controlContainerItem1;

		// Token: 0x04000CAA RID: 3242
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_Id;

		// Token: 0x04000CAB RID: 3243
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_Clientpart;

		// Token: 0x04000CAC RID: 3244
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_Addr;

		// Token: 0x04000CAD RID: 3245
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_Person;

		// Token: 0x04000CAE RID: 3246
		private global::System.Windows.Forms.DataGridViewTextBoxColumn ClientCode;

		// Token: 0x04000CAF RID: 3247
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_PhoneNum;

		// Token: 0x04000CB0 RID: 3248
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_Remark;
	}
}
