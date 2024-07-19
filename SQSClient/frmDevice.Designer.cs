namespace SQSClient
{
	// Token: 0x0200007F RID: 127
	public partial class frmDevice : global::SQSClient.BaseDialogForm
	{
		// Token: 0x060006F8 RID: 1784 RVA: 0x000AB89C File Offset: 0x000A9A9C
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060006F9 RID: 1785 RVA: 0x000AB8D4 File Offset: 0x000A9AD4
		private void InitializeComponent()
		{
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::SQSClient.frmDevice));
			this.bar = new global::DevComponents.DotNetBar.Bar();
			this.line2 = new global::DevComponents.DotNetBar.Controls.Line();
			this.btnAdd = new global::DevComponents.DotNetBar.ButtonItem();
			this.btnModify = new global::DevComponents.DotNetBar.ButtonItem();
			this.btnDelete = new global::DevComponents.DotNetBar.ButtonItem();
			this.controlContainerItem1 = new global::DevComponents.DotNetBar.ControlContainerItem();
			this.labelItem1 = new global::DevComponents.DotNetBar.LabelItem();
			this.txtName = new global::DevComponents.DotNetBar.TextBoxItem();
			this.btnSearch = new global::DevComponents.DotNetBar.ButtonItem();
			this.dgvData = new global::DevComponents.DotNetBar.Controls.DataGridViewX();
			this.C_Id = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_DeviceName = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_Addr = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_SerialNo = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_Ways = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_itemServer = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_CommType = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_CommProtocol = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_CommParameter = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CState = new global::System.Windows.Forms.DataGridViewCheckBoxColumn();
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
				this.labelItem1,
				this.txtName,
				this.btnSearch
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
			this.labelItem1.Name = "labelItem1";
			this.labelItem1.Text = "DeviceName";
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
				this.C_DeviceName,
				this.C_Addr,
				this.C_SerialNo,
				this.C_Ways,
				this.C_itemServer,
				this.C_CommType,
				this.C_CommProtocol,
				this.C_CommParameter,
				this.CState,
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
			this.C_DeviceName.FillWeight = 93.24873f;
			this.C_DeviceName.HeaderText = "DeviceName";
			this.C_DeviceName.Name = "C_DeviceName";
			this.C_DeviceName.ReadOnly = true;
			this.C_Addr.FillWeight = 93.24873f;
			this.C_Addr.HeaderText = "DeviceAddr";
			this.C_Addr.Name = "C_Addr";
			this.C_Addr.ReadOnly = true;
			this.C_SerialNo.FillWeight = 93.24873f;
			this.C_SerialNo.HeaderText = "DeviceNum";
			this.C_SerialNo.Name = "C_SerialNo";
			this.C_SerialNo.ReadOnly = true;
			this.C_Ways.FillWeight = 93.24873f;
			this.C_Ways.HeaderText = "Ways";
			this.C_Ways.Name = "C_Ways";
			this.C_Ways.ReadOnly = true;
			this.C_itemServer.FillWeight = 93.24873f;
			this.C_itemServer.HeaderText = "Server";
			this.C_itemServer.Name = "C_itemServer";
			this.C_itemServer.ReadOnly = true;
			this.C_CommType.FillWeight = 93.24873f;
			this.C_CommType.HeaderText = "CommType";
			this.C_CommType.Name = "C_CommType";
			this.C_CommType.ReadOnly = true;
			this.C_CommProtocol.FillWeight = 93.24873f;
			this.C_CommProtocol.HeaderText = "CommProtocol";
			this.C_CommProtocol.Name = "C_CommProtocol";
			this.C_CommProtocol.ReadOnly = true;
			this.C_CommParameter.FillWeight = 167.5127f;
			this.C_CommParameter.HeaderText = "CommParameter";
			this.C_CommParameter.Name = "C_CommParameter";
			this.C_CommParameter.ReadOnly = true;
			this.CState.FillWeight = 93.24873f;
			this.CState.HeaderText = "Enable";
			this.CState.Name = "CState";
			this.CState.ReadOnly = true;
			this.CState.Resizable = global::System.Windows.Forms.DataGridViewTriState.True;
			this.C_Remark.FillWeight = 93.24873f;
			this.C_Remark.HeaderText = "Remark";
			this.C_Remark.Name = "C_Remark";
			this.C_Remark.ReadOnly = true;
			base.ClientSize = new global::System.Drawing.Size(954, 372);
			base.Controls.Add(this.dgvData);
			base.Controls.Add(this.bar);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "frmDevice";
			this.Text = "Device";
			base.Load += new global::System.EventHandler(this.frmDevice_Load);
			((global::System.ComponentModel.ISupportInitialize)this.bar).EndInit();
			this.bar.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.dgvData).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000BD1 RID: 3025
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000BD2 RID: 3026
		private global::DevComponents.DotNetBar.Bar bar;

		// Token: 0x04000BD3 RID: 3027
		private global::DevComponents.DotNetBar.ButtonItem btnAdd;

		// Token: 0x04000BD4 RID: 3028
		private global::DevComponents.DotNetBar.ButtonItem btnModify;

		// Token: 0x04000BD5 RID: 3029
		private global::DevComponents.DotNetBar.ButtonItem btnDelete;

		// Token: 0x04000BD6 RID: 3030
		private global::DevComponents.DotNetBar.Controls.DataGridViewX dgvData;

		// Token: 0x04000BD7 RID: 3031
		private global::DevComponents.DotNetBar.TextBoxItem txtName;

		// Token: 0x04000BD8 RID: 3032
		private global::DevComponents.DotNetBar.ButtonItem btnSearch;

		// Token: 0x04000BD9 RID: 3033
		private global::DevComponents.DotNetBar.Controls.Line line2;

		// Token: 0x04000BDA RID: 3034
		private global::DevComponents.DotNetBar.ControlContainerItem controlContainerItem1;

		// Token: 0x04000BDB RID: 3035
		private global::DevComponents.DotNetBar.LabelItem labelItem1;

		// Token: 0x04000BDC RID: 3036
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_Id;

		// Token: 0x04000BDD RID: 3037
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_DeviceName;

		// Token: 0x04000BDE RID: 3038
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_Addr;

		// Token: 0x04000BDF RID: 3039
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_SerialNo;

		// Token: 0x04000BE0 RID: 3040
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_Ways;

		// Token: 0x04000BE1 RID: 3041
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_itemServer;

		// Token: 0x04000BE2 RID: 3042
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_CommType;

		// Token: 0x04000BE3 RID: 3043
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_CommProtocol;

		// Token: 0x04000BE4 RID: 3044
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_CommParameter;

		// Token: 0x04000BE5 RID: 3045
		private global::System.Windows.Forms.DataGridViewCheckBoxColumn CState;

		// Token: 0x04000BE6 RID: 3046
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_Remark;
	}
}
