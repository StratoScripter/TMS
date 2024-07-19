namespace SQSClient
{
	// Token: 0x02000023 RID: 35
	public partial class frmDictionaryEdit : global::SQSClient.BaseDialogForm
	{
		// Token: 0x060001AF RID: 431 RVA: 0x00032344 File Offset: 0x00030544
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x0003237C File Offset: 0x0003057C
		private void InitializeComponent()
		{
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new global::System.Windows.Forms.DataGridViewCellStyle();
			this.txtSearch = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.menuBar = new global::DevComponents.DotNetBar.Bar();
			this.btnSave = new global::DevComponents.DotNetBar.ButtonItem();
			this.dgvData = new global::DevComponents.DotNetBar.Controls.DataGridViewX();
			this.btnAdd = new global::DevComponents.DotNetBar.ButtonItem();
			((global::System.ComponentModel.ISupportInitialize)this.menuBar).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.dgvData).BeginInit();
			base.SuspendLayout();
			this.txtSearch.Border.Class = "TextBoxBorder";
			this.txtSearch.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtSearch.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.txtSearch.Location = new global::System.Drawing.Point(0, 26);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.PreventEnterBeep = true;
			this.txtSearch.Size = new global::System.Drawing.Size(822, 21);
			this.txtSearch.TabIndex = 1;
			this.txtSearch.WatermarkText = "Search";
			this.txtSearch.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
			this.menuBar.AccessibleDescription = "DotNetBar Bar (menuBar)";
			this.menuBar.AccessibleName = "DotNetBar Bar";
			this.menuBar.AccessibleRole = global::System.Windows.Forms.AccessibleRole.MenuBar;
			this.menuBar.BackColor = global::System.Drawing.Color.Transparent;
			this.menuBar.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.menuBar.Font = new global::System.Drawing.Font("微软雅黑", 9f);
			this.menuBar.IsMaximized = false;
			this.menuBar.Items.AddRange(new global::DevComponents.DotNetBar.BaseItem[]
			{
				this.btnSave,
				this.btnAdd
			});
			this.menuBar.Location = new global::System.Drawing.Point(0, 0);
			this.menuBar.MenuBar = true;
			this.menuBar.Name = "menuBar";
			this.menuBar.Size = new global::System.Drawing.Size(822, 26);
			this.menuBar.Stretch = true;
			this.menuBar.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.menuBar.TabIndex = 21;
			this.menuBar.TabStop = false;
			this.menuBar.Text = "Main Menu";
			this.btnSave.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.btnSave.Image = global::SQSClient.Properties.Resources.save16;
			this.btnSave.Name = "btnSave";
			this.btnSave.Text = "Save";
			this.btnSave.Click += new global::System.EventHandler(this.btnSave_Click);
			this.dgvData.AllowUserToAddRows = false;
			this.dgvData.AllowUserToDeleteRows = false;
			this.dgvData.AutoSizeColumnsMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvData.AutoSizeRowsMode = global::System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dgvData.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
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
			this.dgvData.Location = new global::System.Drawing.Point(0, 47);
			this.dgvData.Name = "dgvData";
			this.dgvData.RowHeadersVisible = false;
			this.dgvData.RowTemplate.Height = 23;
			this.dgvData.SelectionMode = global::System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvData.Size = new global::System.Drawing.Size(822, 531);
			this.dgvData.TabIndex = 22;
			this.dgvData.CellEndEdit += new global::System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellEndEdit);
			this.btnAdd.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.btnAdd.Image = global::SQSClient.Properties.Resources.add16;
			this.btnAdd.ItemAlignment = global::DevComponents.DotNetBar.eItemAlignment.Far;
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Text = "Add";
			this.btnAdd.Click += new global::System.EventHandler(this.btnAdd_Click);
			base.ClientSize = new global::System.Drawing.Size(822, 578);
			base.Controls.Add(this.dgvData);
			base.Controls.Add(this.txtSearch);
			base.Controls.Add(this.menuBar);
			base.Name = "frmDictionaryEdit";
			this.Text = "frmDictionaryEdit";
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.frmDictionaryEdit_FormClosing);
			base.Load += new global::System.EventHandler(this.frmDictionaryEdit_Load);
			((global::System.ComponentModel.ISupportInitialize)this.menuBar).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.dgvData).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x040002F5 RID: 757
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x040002F6 RID: 758
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtSearch;

		// Token: 0x040002F7 RID: 759
		private global::DevComponents.DotNetBar.Bar menuBar;

		// Token: 0x040002F8 RID: 760
		private global::DevComponents.DotNetBar.ButtonItem btnSave;

		// Token: 0x040002F9 RID: 761
		private global::DevComponents.DotNetBar.Controls.DataGridViewX dgvData;

		// Token: 0x040002FA RID: 762
		private global::DevComponents.DotNetBar.ButtonItem btnAdd;
	}
}
