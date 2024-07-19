namespace SQSClient
{
	// Token: 0x0200002C RID: 44
	public partial class frmDynamicButton : global::SQSClient.BaseDialogForm
	{
		// Token: 0x0600022A RID: 554 RVA: 0x0003EAE4 File Offset: 0x0003CCE4
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600022B RID: 555 RVA: 0x0003EB1C File Offset: 0x0003CD1C
		private void InitializeComponent()
		{
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::SQSClient.frmDynamicButton));
			this.bar = new global::DevComponents.DotNetBar.Bar();
			this.btnAdd = new global::DevComponents.DotNetBar.ButtonItem();
			this.btnModify = new global::DevComponents.DotNetBar.ButtonItem();
			this.btnDelete = new global::DevComponents.DotNetBar.ButtonItem();
			this.dgvData = new global::DevComponents.DotNetBar.Controls.DataGridViewX();
			this.PortName = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_ScreenName = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_ButtonName = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_ButtonText = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_ParentControl = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			((global::System.ComponentModel.ISupportInitialize)this.bar).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.dgvData).BeginInit();
			base.SuspendLayout();
			this.bar.AntiAlias = true;
			this.bar.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.bar.Font = new global::System.Drawing.Font("微软雅黑", 9f);
			this.bar.IsMaximized = false;
			this.bar.Items.AddRange(new global::DevComponents.DotNetBar.BaseItem[]
			{
				this.btnAdd,
				this.btnModify,
				this.btnDelete
			});
			this.bar.Location = new global::System.Drawing.Point(0, 0);
			this.bar.Name = "bar";
			this.bar.Size = new global::System.Drawing.Size(954, 27);
			this.bar.Stretch = true;
			this.bar.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.bar.TabIndex = 3;
			this.bar.TabStop = false;
			this.bar.Text = "bar1";
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
			this.dgvData.AllowUserToAddRows = false;
			this.dgvData.AllowUserToDeleteRows = false;
			this.dgvData.AutoSizeColumnsMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvData.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvData.Columns.AddRange(new global::System.Windows.Forms.DataGridViewColumn[]
			{
				this.PortName,
				this.C_ScreenName,
				this.C_ButtonName,
				this.C_ButtonText,
				this.C_ParentControl
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
			this.C_ScreenName.HeaderText = "ScreenName";
			this.C_ScreenName.Name = "C_ScreenName";
			this.C_ScreenName.ReadOnly = true;
			this.C_ButtonName.HeaderText = "ButtonName";
			this.C_ButtonName.Name = "C_ButtonName";
			this.C_ButtonName.ReadOnly = true;
			this.C_ButtonText.HeaderText = "ButtonText";
			this.C_ButtonText.Name = "C_ButtonText";
			this.C_ButtonText.ReadOnly = true;
			this.C_ParentControl.HeaderText = "ParentControl";
			this.C_ParentControl.Name = "C_ParentControl";
			this.C_ParentControl.ReadOnly = true;
			base.ClientSize = new global::System.Drawing.Size(954, 372);
			base.Controls.Add(this.dgvData);
			base.Controls.Add(this.bar);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "frmDynamicButton";
			this.Text = "DynamicButton";
			base.Load += new global::System.EventHandler(this.frmKeyCode_Load);
			((global::System.ComponentModel.ISupportInitialize)this.bar).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.dgvData).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x040003E0 RID: 992
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x040003E1 RID: 993
		private global::DevComponents.DotNetBar.Bar bar;

		// Token: 0x040003E2 RID: 994
		private global::DevComponents.DotNetBar.ButtonItem btnModify;

		// Token: 0x040003E3 RID: 995
		private global::DevComponents.DotNetBar.Controls.DataGridViewX dgvData;

		// Token: 0x040003E4 RID: 996
		private global::System.Windows.Forms.DataGridViewTextBoxColumn PortName;

		// Token: 0x040003E5 RID: 997
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_ScreenName;

		// Token: 0x040003E6 RID: 998
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_ButtonName;

		// Token: 0x040003E7 RID: 999
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_ButtonText;

		// Token: 0x040003E8 RID: 1000
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_ParentControl;

		// Token: 0x040003E9 RID: 1001
		private global::DevComponents.DotNetBar.ButtonItem btnAdd;

		// Token: 0x040003EA RID: 1002
		private global::DevComponents.DotNetBar.ButtonItem btnDelete;
	}
}
