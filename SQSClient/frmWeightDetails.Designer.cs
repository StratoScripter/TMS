namespace SQSClient
{
	// Token: 0x0200001C RID: 28
	public partial class frmWeightDetails : global::SQSClient.BaseDialogForm
	{
		// Token: 0x06000169 RID: 361 RVA: 0x0002C740 File Offset: 0x0002A940
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600016A RID: 362 RVA: 0x0002C778 File Offset: 0x0002A978
		private void InitializeComponent()
		{
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::SQSClient.frmWeightDetails));
			this.bar = new global::DevComponents.DotNetBar.Bar();
			this.line2 = new global::DevComponents.DotNetBar.Controls.Line();
			this.btnSure = new global::DevComponents.DotNetBar.ButtonItem();
			this.controlContainerItem1 = new global::DevComponents.DotNetBar.ControlContainerItem();
			this.dgvData = new global::DevComponents.DotNetBar.Controls.DataGridViewX();
			this.C_Id = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_WeightValue = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_WeightTime = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_WeightClerk = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_WeightModel = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
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
				this.btnSure,
				this.controlContainerItem1
			});
			this.bar.Location = new global::System.Drawing.Point(0, 0);
			this.bar.Name = "bar";
			this.bar.Size = new global::System.Drawing.Size(786, 27);
			this.bar.Stretch = true;
			this.bar.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.bar.TabIndex = 0;
			this.bar.TabStop = false;
			this.bar.Text = "bar1";
			this.line2.ForeColor = global::System.Drawing.SystemColors.ActiveCaption;
			this.line2.Location = new global::System.Drawing.Point(59, 3);
			this.line2.Name = "line2";
			this.line2.Size = new global::System.Drawing.Size(1, 20);
			this.line2.TabIndex = 17;
			this.line2.Text = "line2";
			this.line2.VerticalLine = true;
			this.btnSure.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.btnSure.Image = global::SQSClient.Properties.Resources.add16;
			this.btnSure.Name = "btnSure";
			this.btnSure.Text = "Sure";
			this.btnSure.Click += new global::System.EventHandler(this.btnSure_Click);
			this.controlContainerItem1.AllowItemResize = false;
			this.controlContainerItem1.Control = this.line2;
			this.controlContainerItem1.MenuVisibility = global::DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
			this.controlContainerItem1.Name = "controlContainerItem1";
			this.dgvData.AllowUserToAddRows = false;
			this.dgvData.AllowUserToDeleteRows = false;
			this.dgvData.AutoSizeColumnsMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvData.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvData.Columns.AddRange(new global::System.Windows.Forms.DataGridViewColumn[]
			{
				this.C_Id,
				this.C_WeightValue,
				this.C_WeightTime,
				this.C_WeightClerk,
				this.C_WeightModel
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
			this.dgvData.Size = new global::System.Drawing.Size(786, 345);
			this.dgvData.TabIndex = 1;
			this.dgvData.CellClick += new global::System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellClick);
			this.dgvData.CellDoubleClick += new global::System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellDoubleClick);
			this.C_Id.HeaderText = "ID";
			this.C_Id.Name = "C_Id";
			this.C_Id.ReadOnly = true;
			this.C_Id.Visible = false;
			this.C_WeightValue.HeaderText = "WeightValue(Kg)";
			this.C_WeightValue.Name = "C_WeightValue";
			this.C_WeightValue.ReadOnly = true;
			this.C_WeightTime.HeaderText = "WeightTime";
			this.C_WeightTime.Name = "C_WeightTime";
			this.C_WeightTime.ReadOnly = true;
			this.C_WeightClerk.HeaderText = "WeightClerk";
			this.C_WeightClerk.Name = "C_WeightClerk";
			this.C_WeightClerk.ReadOnly = true;
			this.C_WeightModel.HeaderText = "WeightModel";
			this.C_WeightModel.Name = "C_WeightModel";
			this.C_WeightModel.ReadOnly = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 12f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(786, 372);
			base.Controls.Add(this.dgvData);
			base.Controls.Add(this.bar);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "frmWeightDetails";
			this.Text = "WeightDetails";
			base.Load += new global::System.EventHandler(this.frmWeightDetails_Load);
			((global::System.ComponentModel.ISupportInitialize)this.bar).EndInit();
			this.bar.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.dgvData).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000295 RID: 661
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000296 RID: 662
		private global::DevComponents.DotNetBar.Bar bar;

		// Token: 0x04000297 RID: 663
		private global::DevComponents.DotNetBar.ButtonItem btnSure;

		// Token: 0x04000298 RID: 664
		private global::DevComponents.DotNetBar.Controls.DataGridViewX dgvData;

		// Token: 0x04000299 RID: 665
		private global::DevComponents.DotNetBar.Controls.Line line2;

		// Token: 0x0400029A RID: 666
		private global::DevComponents.DotNetBar.ControlContainerItem controlContainerItem1;

		// Token: 0x0400029B RID: 667
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_Id;

		// Token: 0x0400029C RID: 668
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_WeightValue;

		// Token: 0x0400029D RID: 669
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_WeightTime;

		// Token: 0x0400029E RID: 670
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_WeightClerk;

		// Token: 0x0400029F RID: 671
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_WeightModel;
	}
}
