namespace SQSClient
{
	// Token: 0x02000033 RID: 51
	public partial class frmPricePolicy : global::SQSClient.BaseDialogForm
	{
		// Token: 0x0600026B RID: 619 RVA: 0x00042E70 File Offset: 0x00041070
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600026C RID: 620 RVA: 0x00042EA8 File Offset: 0x000410A8
		private void InitializeComponent()
		{
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new global::System.Windows.Forms.DataGridViewCellStyle();
			this.bar = new global::DevComponents.DotNetBar.Bar();
			this.line2 = new global::DevComponents.DotNetBar.Controls.Line();
			this.btnAdd = new global::DevComponents.DotNetBar.ButtonItem();
			this.btnModify = new global::DevComponents.DotNetBar.ButtonItem();
			this.btnDelete = new global::DevComponents.DotNetBar.ButtonItem();
			this.controlContainerItem1 = new global::DevComponents.DotNetBar.ControlContainerItem();
			this.btnCopy = new global::DevComponents.DotNetBar.ButtonItem();
			this.dgvPricePolicy = new global::DevComponents.DotNetBar.Controls.DataGridViewX();
			this.C_Id = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_KeyCode = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_Type = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_RunTime = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_ThresholdPriceInfo = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_ThresholdUnit = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_PriceUnit = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_Remark = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnPrint = new global::DevComponents.DotNetBar.ButtonItem();
			this.btnExport = new global::DevComponents.DotNetBar.ButtonItem();
			((global::System.ComponentModel.ISupportInitialize)this.bar).BeginInit();
			this.bar.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvPricePolicy).BeginInit();
			base.SuspendLayout();
			this.bar.AntiAlias = true;
			this.bar.Controls.Add(this.line2);
			this.bar.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.bar.Font = new global::System.Drawing.Font("微软雅黑", 9f);
			this.bar.IsMaximized = false;
			this.bar.Items.AddRange(new global::DevComponents.DotNetBar.BaseItem[]
			{
				this.btnAdd,
				this.btnCopy,
				this.btnModify,
				this.btnDelete,
				this.controlContainerItem1,
				this.btnPrint,
				this.btnExport
			});
			this.bar.Location = new global::System.Drawing.Point(0, 0);
			this.bar.Name = "bar";
			this.bar.Size = new global::System.Drawing.Size(1087, 27);
			this.bar.Stretch = true;
			this.bar.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.bar.TabIndex = 2;
			this.bar.TabStop = false;
			this.bar.Text = "bar1";
			this.line2.ForeColor = global::System.Drawing.SystemColors.ActiveCaption;
			this.line2.Location = new global::System.Drawing.Point(256, 3);
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
			this.btnCopy.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.btnCopy.Image = global::SQSClient.Properties.Resources.add16;
			this.btnCopy.Name = "btnCopy";
			this.btnCopy.Text = "Copy";
			this.btnCopy.Click += new global::System.EventHandler(this.btnCopy_Click);
			this.dgvPricePolicy.AllowUserToAddRows = false;
			this.dgvPricePolicy.AllowUserToDeleteRows = false;
			this.dgvPricePolicy.AutoSizeColumnsMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvPricePolicy.AutoSizeRowsMode = global::System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dgvPricePolicy.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dgvPricePolicy.Columns.AddRange(new global::System.Windows.Forms.DataGridViewColumn[]
			{
				this.C_Id,
				this.C_KeyCode,
				this.C_Type,
				this.C_RunTime,
				this.C_ThresholdPriceInfo,
				this.C_ThresholdUnit,
				this.C_PriceUnit,
				this.C_Remark
			});
			dataGridViewCellStyle.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle.BackColor = global::System.Drawing.SystemColors.Window;
			dataGridViewCellStyle.Font = new global::System.Drawing.Font("宋体", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 134);
			dataGridViewCellStyle.ForeColor = global::System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle.SelectionBackColor = global::System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle.SelectionForeColor = global::System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle.WrapMode = global::System.Windows.Forms.DataGridViewTriState.False;
			this.dgvPricePolicy.DefaultCellStyle = dataGridViewCellStyle;
			this.dgvPricePolicy.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.dgvPricePolicy.EnableHeadersVisualStyles = false;
			this.dgvPricePolicy.GridColor = global::System.Drawing.Color.FromArgb(208, 215, 229);
			this.dgvPricePolicy.Location = new global::System.Drawing.Point(0, 27);
			this.dgvPricePolicy.Name = "dgvPricePolicy";
			this.dgvPricePolicy.ReadOnly = true;
			this.dgvPricePolicy.RowHeadersVisible = false;
			this.dgvPricePolicy.RowTemplate.Height = 23;
			this.dgvPricePolicy.Size = new global::System.Drawing.Size(1087, 607);
			this.dgvPricePolicy.TabIndex = 7;
			this.dgvPricePolicy.CellClick += new global::System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPricePolicy_CellClick);
			this.dgvPricePolicy.CellDoubleClick += new global::System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPricePolicy_CellDoubleClick);
			this.C_Id.FillWeight = 60f;
			this.C_Id.HeaderText = "Id";
			this.C_Id.Name = "C_Id";
			this.C_Id.ReadOnly = true;
			this.C_KeyCode.FillWeight = 60f;
			this.C_KeyCode.HeaderText = "KeyCode";
			this.C_KeyCode.Name = "C_KeyCode";
			this.C_KeyCode.ReadOnly = true;
			this.C_Type.FillWeight = 80f;
			this.C_Type.HeaderText = "PriceType";
			this.C_Type.Name = "C_Type";
			this.C_Type.ReadOnly = true;
			this.C_RunTime.HeaderText = "RunTime";
			this.C_RunTime.Name = "C_RunTime";
			this.C_RunTime.ReadOnly = true;
			this.C_ThresholdPriceInfo.FillWeight = 250f;
			this.C_ThresholdPriceInfo.HeaderText = "ThresholdPriceInfo";
			this.C_ThresholdPriceInfo.Name = "C_ThresholdPriceInfo";
			this.C_ThresholdPriceInfo.ReadOnly = true;
			this.C_ThresholdUnit.FillWeight = 60f;
			this.C_ThresholdUnit.HeaderText = "ThresholdUnit";
			this.C_ThresholdUnit.Name = "C_ThresholdUnit";
			this.C_ThresholdUnit.ReadOnly = true;
			this.C_PriceUnit.FillWeight = 60f;
			this.C_PriceUnit.HeaderText = "PriceUnit";
			this.C_PriceUnit.Name = "C_PriceUnit";
			this.C_PriceUnit.ReadOnly = true;
			this.C_Remark.FillWeight = 150f;
			this.C_Remark.HeaderText = "Remark";
			this.C_Remark.Name = "C_Remark";
			this.C_Remark.ReadOnly = true;
			this.btnPrint.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.btnPrint.Image = global::SQSClient.Properties.Resources.print16;
			this.btnPrint.Name = "btnPrint";
			this.btnPrint.Text = "Print";
			this.btnPrint.Click += new global::System.EventHandler(this.btnPrint_Click);
			this.btnExport.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.btnExport.Image = global::SQSClient.Properties.Resources.export16;
			this.btnExport.Name = "btnExport";
			this.btnExport.Text = "Export";
			this.btnExport.Click += new global::System.EventHandler(this.btnExport_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 12f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(1087, 634);
			base.Controls.Add(this.dgvPricePolicy);
			base.Controls.Add(this.bar);
			base.Name = "frmPricePolicy";
			this.Text = "frmPricePolicy";
			base.Load += new global::System.EventHandler(this.frmPricePolicy_Load);
			((global::System.ComponentModel.ISupportInitialize)this.bar).EndInit();
			this.bar.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.dgvPricePolicy).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x0400042E RID: 1070
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400042F RID: 1071
		private global::DevComponents.DotNetBar.Bar bar;

		// Token: 0x04000430 RID: 1072
		private global::DevComponents.DotNetBar.Controls.Line line2;

		// Token: 0x04000431 RID: 1073
		private global::DevComponents.DotNetBar.ButtonItem btnAdd;

		// Token: 0x04000432 RID: 1074
		private global::DevComponents.DotNetBar.ButtonItem btnModify;

		// Token: 0x04000433 RID: 1075
		private global::DevComponents.DotNetBar.ButtonItem btnDelete;

		// Token: 0x04000434 RID: 1076
		private global::DevComponents.DotNetBar.ControlContainerItem controlContainerItem1;

		// Token: 0x04000435 RID: 1077
		private global::DevComponents.DotNetBar.ButtonItem btnCopy;

		// Token: 0x04000436 RID: 1078
		private global::DevComponents.DotNetBar.Controls.DataGridViewX dgvPricePolicy;

		// Token: 0x04000437 RID: 1079
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_Id;

		// Token: 0x04000438 RID: 1080
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_KeyCode;

		// Token: 0x04000439 RID: 1081
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_Type;

		// Token: 0x0400043A RID: 1082
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_RunTime;

		// Token: 0x0400043B RID: 1083
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_ThresholdPriceInfo;

		// Token: 0x0400043C RID: 1084
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_ThresholdUnit;

		// Token: 0x0400043D RID: 1085
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_PriceUnit;

		// Token: 0x0400043E RID: 1086
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_Remark;

		// Token: 0x0400043F RID: 1087
		private global::DevComponents.DotNetBar.ButtonItem btnPrint;

		// Token: 0x04000440 RID: 1088
		private global::DevComponents.DotNetBar.ButtonItem btnExport;
	}
}
