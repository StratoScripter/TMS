namespace SQSClient
{
	// Token: 0x02000066 RID: 102
	public partial class frmProductExtShow : global::SQSClient.BaseDialogForm
	{
		// Token: 0x0600052B RID: 1323 RVA: 0x00082910 File Offset: 0x00080B10
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600052C RID: 1324 RVA: 0x00082948 File Offset: 0x00080B48
		private void InitializeComponent()
		{
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::SQSClient.frmProductExtShow));
			this.dgvData = new global::DevComponents.DotNetBar.Controls.DataGridViewX();
			this.C_Id = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_InvCode = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_InvName = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_ProName = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_Code = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_MainInvCCode = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_SpecsDescribe = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_SunHao = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_MiDu = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_Type = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_ValidCondition = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_PostType = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_PackWeight = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_AccuUpperLimit = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_AccuLowerLimit = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_State = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_PeiPang = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_HeWeiConfig = new global::System.Windows.Forms.DataGridViewImageColumn();
			this.C_SrmInvModelId = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_InvModelName = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_Queue = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_Remark = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bar = new global::DevComponents.DotNetBar.Bar();
			this.line2 = new global::DevComponents.DotNetBar.Controls.Line();
			this.controlContainerItem1 = new global::DevComponents.DotNetBar.ControlContainerItem();
			this.btnExport = new global::DevComponents.DotNetBar.ButtonItem();
			this.labProductInfo = new global::DevComponents.DotNetBar.LabelItem();
			this.txtName = new global::DevComponents.DotNetBar.TextBoxItem();
			this.btnSearch = new global::DevComponents.DotNetBar.ButtonItem();
			this.btnItemC = new global::DevComponents.DotNetBar.ButtonItem();
			this.cbxIsNCC = new global::DevComponents.DotNetBar.CheckBoxItem();
			this.btnModify = new global::DevComponents.DotNetBar.ButtonItem();
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
				this.C_InvCode,
				this.C_InvName,
				this.C_ProName,
				this.C_Code,
				this.C_MainInvCCode,
				this.C_SpecsDescribe,
				this.C_SunHao,
				this.C_MiDu,
				this.C_Type,
				this.C_ValidCondition,
				this.C_PostType,
				this.C_PackWeight,
				this.C_AccuUpperLimit,
				this.C_AccuLowerLimit,
				this.C_State,
				this.C_PeiPang,
				this.C_HeWeiConfig,
				this.C_SrmInvModelId,
				this.C_InvModelName,
				this.C_Queue,
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
			this.dgvData.Size = new global::System.Drawing.Size(1221, 455);
			this.dgvData.TabIndex = 4;
			this.dgvData.CellClick += new global::System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellClick);
			this.dgvData.CellContentClick += new global::System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellContentClick);
			this.dgvData.CellDoubleClick += new global::System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellDoubleClick);
			this.dgvData.SelectionChanged += new global::System.EventHandler(this.dgvData_SelectionChanged);
			this.C_Id.HeaderText = "ID";
			this.C_Id.Name = "C_Id";
			this.C_Id.ReadOnly = true;
			this.C_Id.Visible = false;
			this.C_InvCode.HeaderText = "InvCode";
			this.C_InvCode.Name = "C_InvCode";
			this.C_InvCode.ReadOnly = true;
			this.C_InvName.HeaderText = "InvName";
			this.C_InvName.Name = "C_InvName";
			this.C_InvName.ReadOnly = true;
			this.C_ProName.HeaderText = "ProductName";
			this.C_ProName.Name = "C_ProName";
			this.C_ProName.ReadOnly = true;
			this.C_Code.HeaderText = "ProductCode";
			this.C_Code.Name = "C_Code";
			this.C_Code.ReadOnly = true;
			this.C_MainInvCCode.HeaderText = "InvCCode";
			this.C_MainInvCCode.Name = "C_MainInvCCode";
			this.C_MainInvCCode.ReadOnly = true;
			this.C_MainInvCCode.Visible = false;
			this.C_SpecsDescribe.HeaderText = "SpecsDescribe";
			this.C_SpecsDescribe.Name = "C_SpecsDescribe";
			this.C_SpecsDescribe.ReadOnly = true;
			this.C_SunHao.HeaderText = "SunHao";
			this.C_SunHao.Name = "C_SunHao";
			this.C_SunHao.ReadOnly = true;
			this.C_SunHao.Visible = false;
			this.C_MiDu.HeaderText = "MiDu(kg/m³)";
			this.C_MiDu.Name = "C_MiDu";
			this.C_MiDu.ReadOnly = true;
			this.C_MiDu.Visible = false;
			this.C_Type.HeaderText = "Type";
			this.C_Type.Name = "C_Type";
			this.C_Type.ReadOnly = true;
			this.C_Type.Visible = false;
			this.C_ValidCondition.HeaderText = "ValidCondition";
			this.C_ValidCondition.Name = "C_ValidCondition";
			this.C_ValidCondition.ReadOnly = true;
			this.C_PostType.HeaderText = "PostType";
			this.C_PostType.Name = "C_PostType";
			this.C_PostType.ReadOnly = true;
			this.C_PackWeight.HeaderText = "PackageWeight";
			this.C_PackWeight.Name = "C_PackWeight";
			this.C_PackWeight.ReadOnly = true;
			this.C_AccuUpperLimit.HeaderText = "AccuUpperLimit";
			this.C_AccuUpperLimit.Name = "C_AccuUpperLimit";
			this.C_AccuUpperLimit.ReadOnly = true;
			this.C_AccuLowerLimit.HeaderText = "AccuLowerLimit";
			this.C_AccuLowerLimit.Name = "C_AccuLowerLimit";
			this.C_AccuLowerLimit.ReadOnly = true;
			this.C_State.HeaderText = "State";
			this.C_State.Name = "C_State";
			this.C_State.ReadOnly = true;
			this.C_PeiPang.HeaderText = "PeiPang";
			this.C_PeiPang.Name = "C_PeiPang";
			this.C_PeiPang.ReadOnly = true;
			this.C_PeiPang.Visible = false;
			this.C_HeWeiConfig.HeaderText = "HeWeiConfig";
			this.C_HeWeiConfig.Name = "C_HeWeiConfig";
			this.C_HeWeiConfig.ReadOnly = true;
			this.C_HeWeiConfig.Visible = false;
			this.C_SrmInvModelId.HeaderText = "SrmInvModelId";
			this.C_SrmInvModelId.Name = "C_SrmInvModelId";
			this.C_SrmInvModelId.ReadOnly = true;
			this.C_InvModelName.HeaderText = "SrmInvModel";
			this.C_InvModelName.Name = "C_InvModelName";
			this.C_InvModelName.ReadOnly = true;
			this.C_Queue.HeaderText = "Queue";
			this.C_Queue.Name = "C_Queue";
			this.C_Queue.ReadOnly = true;
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
				this.controlContainerItem1,
				this.btnExport,
				this.btnModify,
				this.labProductInfo,
				this.txtName,
				this.btnSearch,
				this.btnItemC,
				this.cbxIsNCC
			});
			this.bar.Location = new global::System.Drawing.Point(0, 0);
			this.bar.Name = "bar";
			this.bar.Size = new global::System.Drawing.Size(1221, 27);
			this.bar.Stretch = true;
			this.bar.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.bar.TabIndex = 1;
			this.bar.TabStop = false;
			this.bar.Text = "bar1";
			this.line2.ForeColor = global::System.Drawing.SystemColors.ActiveCaption;
			this.line2.Location = new global::System.Drawing.Point(3, 3);
			this.line2.Name = "line2";
			this.line2.Size = new global::System.Drawing.Size(1, 20);
			this.line2.TabIndex = 17;
			this.line2.Text = "line2";
			this.line2.VerticalLine = true;
			this.controlContainerItem1.AllowItemResize = false;
			this.controlContainerItem1.Control = this.line2;
			this.controlContainerItem1.MenuVisibility = global::DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
			this.controlContainerItem1.Name = "controlContainerItem1";
			this.btnExport.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.btnExport.Image = global::SQSClient.Properties.Resources.print16;
			this.btnExport.Name = "btnExport";
			this.btnExport.Text = "Export";
			this.btnExport.Click += new global::System.EventHandler(this.btnExport_Click);
			this.labProductInfo.Name = "labProductInfo";
			this.labProductInfo.Text = "ProductInfo";
			this.txtName.MaxLength = 20;
			this.txtName.Name = "txtName";
			this.txtName.TextBoxWidth = 220;
			this.txtName.WatermarkColor = global::System.Drawing.SystemColors.GrayText;
			this.txtName.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
			this.btnSearch.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.btnSearch.Image = global::SQSClient.Properties.Resources.search16;
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Text = "Search";
			this.btnSearch.Click += new global::System.EventHandler(this.btnSearch_Click);
			this.btnItemC.ItemAlignment = global::DevComponents.DotNetBar.eItemAlignment.Far;
			this.btnItemC.Name = "btnItemC";
			this.btnItemC.Text = "ItemC";
			this.btnItemC.Visible = false;
			this.btnItemC.Click += new global::System.EventHandler(this.btnItemC_Click);
			this.cbxIsNCC.ItemAlignment = global::DevComponents.DotNetBar.eItemAlignment.Far;
			this.cbxIsNCC.Name = "cbxIsNCC";
			this.cbxIsNCC.Text = "NCCProduct";
			this.cbxIsNCC.Click += new global::System.EventHandler(this.cbxIsNCC_Click);
			this.btnModify.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.btnModify.Image = global::SQSClient.Properties.Resources.modify16;
			this.btnModify.Name = "btnModify";
			this.btnModify.Text = "Modify";
			this.btnModify.Click += new global::System.EventHandler(this.btnModify_Click);
			base.ClientSize = new global::System.Drawing.Size(1221, 482);
			base.Controls.Add(this.dgvData);
			base.Controls.Add(this.bar);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "frmProductExtShow";
			this.Text = "Product";
			base.Load += new global::System.EventHandler(this.frmProductExtShow_Load);
			((global::System.ComponentModel.ISupportInitialize)this.dgvData).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.bar).EndInit();
			this.bar.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x040008D4 RID: 2260
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x040008D5 RID: 2261
		private global::DevComponents.DotNetBar.Bar bar;

		// Token: 0x040008D6 RID: 2262
		private global::DevComponents.DotNetBar.LabelItem labProductInfo;

		// Token: 0x040008D7 RID: 2263
		private global::DevComponents.DotNetBar.TextBoxItem txtName;

		// Token: 0x040008D8 RID: 2264
		private global::DevComponents.DotNetBar.ButtonItem btnSearch;

		// Token: 0x040008D9 RID: 2265
		private global::DevComponents.DotNetBar.Controls.Line line2;

		// Token: 0x040008DA RID: 2266
		private global::DevComponents.DotNetBar.ControlContainerItem controlContainerItem1;

		// Token: 0x040008DB RID: 2267
		private global::DevComponents.DotNetBar.Controls.DataGridViewX dgvData;

		// Token: 0x040008DC RID: 2268
		private global::DevComponents.DotNetBar.ButtonItem btnItemC;

		// Token: 0x040008DD RID: 2269
		private global::DevComponents.DotNetBar.ButtonItem btnExport;

		// Token: 0x040008DE RID: 2270
		private global::DevComponents.DotNetBar.CheckBoxItem cbxIsNCC;

		// Token: 0x040008DF RID: 2271
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_Id;

		// Token: 0x040008E0 RID: 2272
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_InvCode;

		// Token: 0x040008E1 RID: 2273
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_InvName;

		// Token: 0x040008E2 RID: 2274
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_ProName;

		// Token: 0x040008E3 RID: 2275
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_Code;

		// Token: 0x040008E4 RID: 2276
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_MainInvCCode;

		// Token: 0x040008E5 RID: 2277
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_SpecsDescribe;

		// Token: 0x040008E6 RID: 2278
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_SunHao;

		// Token: 0x040008E7 RID: 2279
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_MiDu;

		// Token: 0x040008E8 RID: 2280
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_Type;

		// Token: 0x040008E9 RID: 2281
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_ValidCondition;

		// Token: 0x040008EA RID: 2282
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_PostType;

		// Token: 0x040008EB RID: 2283
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_PackWeight;

		// Token: 0x040008EC RID: 2284
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_AccuUpperLimit;

		// Token: 0x040008ED RID: 2285
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_AccuLowerLimit;

		// Token: 0x040008EE RID: 2286
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_State;

		// Token: 0x040008EF RID: 2287
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_PeiPang;

		// Token: 0x040008F0 RID: 2288
		private global::System.Windows.Forms.DataGridViewImageColumn C_HeWeiConfig;

		// Token: 0x040008F1 RID: 2289
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_SrmInvModelId;

		// Token: 0x040008F2 RID: 2290
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_InvModelName;

		// Token: 0x040008F3 RID: 2291
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_Queue;

		// Token: 0x040008F4 RID: 2292
		private global::System.Windows.Forms.DataGridViewTextBoxColumn C_Remark;

		// Token: 0x040008F5 RID: 2293
		private global::DevComponents.DotNetBar.ButtonItem btnModify;
	}
}
