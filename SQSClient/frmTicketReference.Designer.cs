namespace SQSClient
{
	// Token: 0x0200001A RID: 26
	public partial class frmTicketReference : global::SQSClient.BaseDialogForm
	{
		// Token: 0x06000155 RID: 341 RVA: 0x000297B0 File Offset: 0x000279B0
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000156 RID: 342 RVA: 0x000297E8 File Offset: 0x000279E8
		private void InitializeComponent()
		{
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new global::System.Windows.Forms.DataGridViewCellStyle();
			this.splitContainer1 = new global::System.Windows.Forms.SplitContainer();
			this.dgvData = new global::DevComponents.DotNetBar.Controls.DataGridViewX();
			this.dataGridViewTextBoxColumn2 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgvDataNew = new global::DevComponents.DotNetBar.Controls.DataGridViewX();
			this.dataGridViewTextBoxColumn1 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.labelX2 = new global::DevComponents.DotNetBar.LabelX();
			this.labelX1 = new global::DevComponents.DotNetBar.LabelX();
			this.btnRefImportRun = new global::DevComponents.DotNetBar.ButtonX();
			this.rdoImportRefer = new global::DevComponents.DotNetBar.Controls.CheckBoxX();
			this.rdoExChange = new global::DevComponents.DotNetBar.Controls.CheckBoxX();
			this.rdoExReturn = new global::DevComponents.DotNetBar.Controls.CheckBoxX();
			this.bar = new global::DevComponents.DotNetBar.Bar();
			this.btnSave = new global::DevComponents.DotNetBar.ButtonItem();
			this.btnItemC = new global::DevComponents.DotNetBar.ButtonItem();
			this.layoutControlItem8 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem2 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem6 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem21 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem23 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem28 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem32 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem22 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			((global::System.ComponentModel.ISupportInitialize)this.splitContainer1).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvData).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.dgvDataNew).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.bar).BeginInit();
			base.SuspendLayout();
			this.splitContainer1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new global::System.Drawing.Point(0, 26);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = global::System.Windows.Forms.Orientation.Horizontal;
			this.splitContainer1.Panel1.Controls.Add(this.dgvData);
			this.splitContainer1.Panel2.Controls.Add(this.dgvDataNew);
			this.splitContainer1.Panel2.Controls.Add(this.labelX2);
			this.splitContainer1.Panel2.Controls.Add(this.labelX1);
			this.splitContainer1.Panel2.Controls.Add(this.btnRefImportRun);
			this.splitContainer1.Panel2.Controls.Add(this.rdoImportRefer);
			this.splitContainer1.Panel2.Controls.Add(this.rdoExChange);
			this.splitContainer1.Panel2.Controls.Add(this.rdoExReturn);
			this.splitContainer1.Size = new global::System.Drawing.Size(1406, 486);
			this.splitContainer1.SplitterDistance = 91;
			this.splitContainer1.TabIndex = 17;
			this.dgvData.AllowUserToAddRows = false;
			this.dgvData.AllowUserToDeleteRows = false;
			this.dgvData.AllowUserToResizeRows = false;
			this.dgvData.AutoSizeColumnsMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dgvData.AutoSizeRowsMode = global::System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			dataGridViewCellStyle.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle.BackColor = global::System.Drawing.SystemColors.Control;
			dataGridViewCellStyle.Font = new global::System.Drawing.Font("宋体", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 134);
			dataGridViewCellStyle.ForeColor = global::System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle.SelectionBackColor = global::System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle.SelectionForeColor = global::System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle.WrapMode = global::System.Windows.Forms.DataGridViewTriState.True;
			this.dgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
			this.dgvData.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dgvData.Columns.AddRange(new global::System.Windows.Forms.DataGridViewColumn[]
			{
				this.dataGridViewTextBoxColumn2
			});
			dataGridViewCellStyle2.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = global::System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new global::System.Drawing.Font("宋体", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 134);
			dataGridViewCellStyle2.ForeColor = global::System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = global::System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = global::System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.WrapMode = global::System.Windows.Forms.DataGridViewTriState.False;
			this.dgvData.DefaultCellStyle = dataGridViewCellStyle2;
			this.dgvData.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.dgvData.EnableHeadersVisualStyles = false;
			this.dgvData.GridColor = global::System.Drawing.Color.FromArgb(208, 215, 229);
			this.dgvData.Location = new global::System.Drawing.Point(0, 0);
			this.dgvData.MultiSelect = false;
			this.dgvData.Name = "dgvData";
			this.dgvData.ReadOnly = true;
			this.dgvData.RowHeadersVisible = false;
			this.dgvData.RowTemplate.Height = 23;
			this.dgvData.SelectionMode = global::System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvData.Size = new global::System.Drawing.Size(1406, 62);
			this.dgvData.TabIndex = 18;
			this.dataGridViewTextBoxColumn2.DataPropertyName = "Id";
			this.dataGridViewTextBoxColumn2.FillWeight = 82.8988f;
			this.dataGridViewTextBoxColumn2.HeaderText = "ID";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.ReadOnly = true;
			this.dataGridViewTextBoxColumn2.Visible = false;
			this.dataGridViewTextBoxColumn2.Width = 42;
			this.dgvDataNew.AllowUserToAddRows = false;
			this.dgvDataNew.AllowUserToDeleteRows = false;
			this.dgvDataNew.AllowUserToResizeRows = false;
			this.dgvDataNew.AutoSizeColumnsMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dgvDataNew.AutoSizeRowsMode = global::System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			dataGridViewCellStyle3.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.BackColor = global::System.Drawing.SystemColors.Control;
			dataGridViewCellStyle3.Font = new global::System.Drawing.Font("宋体", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 134);
			dataGridViewCellStyle3.ForeColor = global::System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = global::System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = global::System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = global::System.Windows.Forms.DataGridViewTriState.True;
			this.dgvDataNew.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.dgvDataNew.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dgvDataNew.Columns.AddRange(new global::System.Windows.Forms.DataGridViewColumn[]
			{
				this.dataGridViewTextBoxColumn1
			});
			dataGridViewCellStyle4.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle4.BackColor = global::System.Drawing.SystemColors.Window;
			dataGridViewCellStyle4.Font = new global::System.Drawing.Font("宋体", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 134);
			dataGridViewCellStyle4.ForeColor = global::System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle4.SelectionBackColor = global::System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = global::System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle4.WrapMode = global::System.Windows.Forms.DataGridViewTriState.False;
			this.dgvDataNew.DefaultCellStyle = dataGridViewCellStyle4;
			this.dgvDataNew.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.dgvDataNew.EnableHeadersVisualStyles = false;
			this.dgvDataNew.GridColor = global::System.Drawing.Color.FromArgb(208, 215, 229);
			this.dgvDataNew.Location = new global::System.Drawing.Point(0, 82);
			this.dgvDataNew.MultiSelect = false;
			this.dgvDataNew.Name = "dgvDataNew";
			this.dgvDataNew.ReadOnly = true;
			this.dgvDataNew.RowHeadersVisible = false;
			this.dgvDataNew.RowTemplate.Height = 23;
			this.dgvDataNew.SelectionMode = global::System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvDataNew.Size = new global::System.Drawing.Size(1406, 309);
			this.dgvDataNew.TabIndex = 17;
			this.dgvDataNew.SelectionChanged += new global::System.EventHandler(this.dgvDataNew_SelectionChanged);
			this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
			this.dataGridViewTextBoxColumn1.FillWeight = 82.8988f;
			this.dataGridViewTextBoxColumn1.HeaderText = "ID";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			this.dataGridViewTextBoxColumn1.Visible = false;
			this.dataGridViewTextBoxColumn1.Width = 42;
			this.labelX2.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.labelX2.Location = new global::System.Drawing.Point(169, 53);
			this.labelX2.Name = "labelX2";
			this.labelX2.Size = new global::System.Drawing.Size(75, 23);
			this.labelX2.TabIndex = 6;
			this.labelX2.Text = "labelX2";
			this.labelX1.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.labelX1.Location = new global::System.Drawing.Point(12, 53);
			this.labelX1.Name = "labelX1";
			this.labelX1.Size = new global::System.Drawing.Size(151, 23);
			this.labelX1.TabIndex = 5;
			this.labelX1.Text = "请选择新单据";
			this.btnRefImportRun.AccessibleRole = global::System.Windows.Forms.AccessibleRole.PushButton;
			this.btnRefImportRun.ColorTable = global::DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.btnRefImportRun.Location = new global::System.Drawing.Point(493, 15);
			this.btnRefImportRun.Margin = new global::System.Windows.Forms.Padding(0);
			this.btnRefImportRun.Name = "btnRefImportRun";
			this.btnRefImportRun.Size = new global::System.Drawing.Size(89, 23);
			this.btnRefImportRun.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.btnRefImportRun.TabIndex = 3;
			this.btnRefImportRun.Text = "RefImportRun";
			this.btnRefImportRun.Click += new global::System.EventHandler(this.btnRefImportRun_Click);
			this.rdoImportRefer.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.rdoImportRefer.CheckBoxStyle = global::DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
			this.rdoImportRefer.Checked = true;
			this.rdoImportRefer.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.rdoImportRefer.CheckValue = "Y";
			this.rdoImportRefer.Font = new global::System.Drawing.Font("宋体", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 134);
			this.rdoImportRefer.Location = new global::System.Drawing.Point(9, 15);
			this.rdoImportRefer.Margin = new global::System.Windows.Forms.Padding(0);
			this.rdoImportRefer.Name = "rdoImportRefer";
			this.rdoImportRefer.Size = new global::System.Drawing.Size(154, 23);
			this.rdoImportRefer.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.rdoImportRefer.TabIndex = 0;
			this.rdoImportRefer.Text = "ImportRefer";
			this.rdoImportRefer.TextColor = global::System.Drawing.Color.Black;
			this.rdoImportRefer.CheckedChanged += new global::System.EventHandler(this.rdoImportRefer_CheckedChanged);
			this.rdoExChange.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.rdoExChange.CheckBoxStyle = global::DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
			this.rdoExChange.Font = new global::System.Drawing.Font("宋体", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 134);
			this.rdoExChange.Location = new global::System.Drawing.Point(318, 15);
			this.rdoExChange.Margin = new global::System.Windows.Forms.Padding(0);
			this.rdoExChange.Name = "rdoExChange";
			this.rdoExChange.Size = new global::System.Drawing.Size(317, 23);
			this.rdoExChange.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.rdoExChange.TabIndex = 0;
			this.rdoExChange.Text = "ExChange";
			this.rdoExChange.TextColor = global::System.Drawing.Color.Black;
			this.rdoExChange.CheckedChanged += new global::System.EventHandler(this.rdoExChange_CheckedChanged);
			this.rdoExReturn.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.rdoExReturn.CheckBoxStyle = global::DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
			this.rdoExReturn.Font = new global::System.Drawing.Font("宋体", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 134);
			this.rdoExReturn.Location = new global::System.Drawing.Point(184, 15);
			this.rdoExReturn.Margin = new global::System.Windows.Forms.Padding(0);
			this.rdoExReturn.Name = "rdoExReturn";
			this.rdoExReturn.Size = new global::System.Drawing.Size(154, 23);
			this.rdoExReturn.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.rdoExReturn.TabIndex = 0;
			this.rdoExReturn.Text = "ExReturn";
			this.rdoExReturn.TextColor = global::System.Drawing.Color.Black;
			this.rdoExReturn.CheckedChanged += new global::System.EventHandler(this.rdoExReturn_CheckedChanged);
			this.bar.AccessibleDescription = "DotNetBar Bar (bar)";
			this.bar.AccessibleName = "DotNetBar Bar";
			this.bar.AccessibleRole = global::System.Windows.Forms.AccessibleRole.MenuBar;
			this.bar.BackColor = global::System.Drawing.Color.Transparent;
			this.bar.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.bar.Font = new global::System.Drawing.Font("微软雅黑", 9f);
			this.bar.IsMaximized = false;
			this.bar.Items.AddRange(new global::DevComponents.DotNetBar.BaseItem[]
			{
				this.btnSave,
				this.btnItemC
			});
			this.bar.Location = new global::System.Drawing.Point(0, 0);
			this.bar.MenuBar = true;
			this.bar.Name = "bar";
			this.bar.Size = new global::System.Drawing.Size(1406, 26);
			this.bar.Stretch = true;
			this.bar.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.bar.TabIndex = 16;
			this.bar.TabStop = false;
			this.bar.Text = "Main Menu";
			this.btnSave.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.btnSave.Image = global::SQSClient.Properties.Resources.save16;
			this.btnSave.Name = "btnSave";
			this.btnSave.Text = "Save";
			this.btnSave.Click += new global::System.EventHandler(this.btnSave_Click);
			this.btnItemC.ItemAlignment = global::DevComponents.DotNetBar.eItemAlignment.Far;
			this.btnItemC.Name = "btnItemC";
			this.btnItemC.Text = "ItemC";
			this.btnItemC.Click += new global::System.EventHandler(this.btnItemC_Click);
			this.layoutControlItem8.Name = "layoutControlItem8";
			this.layoutControlItem2.Name = "layoutControlItem2";
			this.layoutControlItem6.Name = "layoutControlItem6";
			this.layoutControlItem21.Height = 29;
			this.layoutControlItem21.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem21.Name = "layoutControlItem21";
			this.layoutControlItem21.Text = "ContractID";
			this.layoutControlItem21.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem21.Width = 100;
			this.layoutControlItem21.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem23.Height = 29;
			this.layoutControlItem23.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem23.Name = "layoutControlItem23";
			this.layoutControlItem23.Text = "Sex";
			this.layoutControlItem23.Width = 40;
			this.layoutControlItem23.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem28.Height = 29;
			this.layoutControlItem28.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem28.Name = "layoutControlItem28";
			this.layoutControlItem28.Text = "IC";
			this.layoutControlItem28.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem28.Width = 70;
			this.layoutControlItem28.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem32.Height = 29;
			this.layoutControlItem32.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem32.Name = "layoutControlItem32";
			this.layoutControlItem32.Text = "ImportDanHao";
			this.layoutControlItem32.Width = 65;
			this.layoutControlItem32.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem22.Height = 29;
			this.layoutControlItem22.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem22.Name = "layoutControlItem22";
			this.layoutControlItem22.Text = "ReferenceDanHao";
			this.layoutControlItem22.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem22.Width = 100;
			this.layoutControlItem22.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			base.ClientSize = new global::System.Drawing.Size(1406, 512);
			base.Controls.Add(this.splitContainer1);
			base.Controls.Add(this.bar);
			base.Name = "frmTicketReference";
			this.Text = "TicketEdit";
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.frmReviseInfo_FormClosing);
			base.Load += new global::System.EventHandler(this.frmReviseInfo_Load);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.splitContainer1).EndInit();
			this.splitContainer1.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.dgvData).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.dgvDataNew).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.bar).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x0400025A RID: 602
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400025B RID: 603
		private global::DevComponents.DotNetBar.Bar bar;

		// Token: 0x0400025C RID: 604
		private global::DevComponents.DotNetBar.ButtonItem btnSave;

		// Token: 0x0400025D RID: 605
		private global::System.Windows.Forms.SplitContainer splitContainer1;

		// Token: 0x0400025E RID: 606
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem8;

		// Token: 0x0400025F RID: 607
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem2;

		// Token: 0x04000260 RID: 608
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem6;

		// Token: 0x04000261 RID: 609
		private global::DevComponents.DotNetBar.ButtonItem btnItemC;

		// Token: 0x04000262 RID: 610
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem21;

		// Token: 0x04000263 RID: 611
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem23;

		// Token: 0x04000264 RID: 612
		private global::DevComponents.DotNetBar.Controls.CheckBoxX rdoImportRefer;

		// Token: 0x04000265 RID: 613
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem28;

		// Token: 0x04000266 RID: 614
		private global::DevComponents.DotNetBar.ButtonX btnRefImportRun;

		// Token: 0x04000267 RID: 615
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem32;

		// Token: 0x04000268 RID: 616
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem22;

		// Token: 0x04000269 RID: 617
		private global::DevComponents.DotNetBar.Controls.CheckBoxX rdoExReturn;

		// Token: 0x0400026A RID: 618
		private global::DevComponents.DotNetBar.Controls.CheckBoxX rdoExChange;

		// Token: 0x0400026B RID: 619
		private global::DevComponents.DotNetBar.LabelX labelX1;

		// Token: 0x0400026C RID: 620
		private global::DevComponents.DotNetBar.LabelX labelX2;

		// Token: 0x0400026D RID: 621
		private global::DevComponents.DotNetBar.Controls.DataGridViewX dgvDataNew;

		// Token: 0x0400026E RID: 622
		private global::System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;

		// Token: 0x0400026F RID: 623
		private global::DevComponents.DotNetBar.Controls.DataGridViewX dgvData;

		// Token: 0x04000270 RID: 624
		private global::System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
	}
}
