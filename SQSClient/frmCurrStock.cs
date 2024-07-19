using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Base;
using DAL.Base.SQSConfig;
using DAL.SQLServer.SQSConfig;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using Model;
using Model.SQSConfig;
using SQSClient.Properties;

namespace SQSClient
{
	// Token: 0x02000046 RID: 70
	public partial class frmCurrStock : BaseDialogForm
	{
		// Token: 0x06000311 RID: 785 RVA: 0x0004D39C File Offset: 0x0004B59C
		public frmCurrStock()
		{
			this.InitializeComponent();
			this.SetText(this);
			this._Controls.Clear();
			this._Controls.Add(this.bar);
			this._Controls.Add(this.dgvData);
			base.SetGridUI(this.dgvData);
		}

		// Token: 0x06000312 RID: 786 RVA: 0x0004D43C File Offset: 0x0004B63C
		public frmCurrStock(string text, BaseForm.FormActtion act)
		{
			this.InitializeComponent();
			base.Width = Screen.PrimaryScreen.Bounds.Width;
			this.SetText(this);
			this._Controls.Clear();
			this._Controls.Add(this.bar);
			this._Controls.Add(this.dgvData);
			base.SetGridUI(this.dgvData);
			this._Act = act;
		}

		// Token: 0x06000313 RID: 787 RVA: 0x0004D4FA File Offset: 0x0004B6FA
		private void frmCurrStock_Load(object sender, EventArgs e)
		{
			BaseDialogForm._operateArgs.Category = this.Text;
			base.InitBurron();
			this._StaticColumnCount = this.dgvData.Columns.Count;
			this.InitControl();
		}

		// Token: 0x06000314 RID: 788 RVA: 0x0004D532 File Offset: 0x0004B732
		private void InitControl()
		{
			this.rdoStockDetails.Checked = true;
		}

		// Token: 0x06000315 RID: 789 RVA: 0x0004D544 File Offset: 0x0004B744
		protected override void LoadData()
		{
			this._IsBatchMerging = !this.rdoStockDetails.Checked;
			this._ProInfo = this.txtProInfo.Text.Trim();
			this._BatchInfo = this.txtBatchInfo.Text.Trim();
			bool flag = !this._IsBatchMerging;
			if (flag)
			{
				this.LoadDataSch();
			}
			else
			{
				this.LoadDataGroup();
			}
		}

		// Token: 0x06000316 RID: 790 RVA: 0x0004D5B4 File Offset: 0x0004B7B4
		protected void LoadDataSch()
		{
			this.dgvData.Columns[5].Visible = true;
			this.dgvData.Columns[9].Visible = true;
			List<ViewCs_currstock> list = new List<ViewCs_currstock>();
			list = this._Dal.GetListByInfo(this._ProInfo, this._BatchInfo);
			this.BindDgvData(list);
		}

		// Token: 0x06000317 RID: 791 RVA: 0x0004D61C File Offset: 0x0004B81C
		protected void LoadDataGroup()
		{
			this.dgvData.Columns[5].Visible = false;
			this.dgvData.Columns[9].Visible = false;
			List<ViewCs_currstock> list = new List<ViewCs_currstock>();
			list = this._Dal.GetListByGroup(this._ProInfo);
			this.BindDgvData(list);
		}

		// Token: 0x06000318 RID: 792 RVA: 0x0004D67C File Offset: 0x0004B87C
		protected void BindDgvData(List<ViewCs_currstock> list)
		{
			this.dgvData.Rows.Clear();
			int num = 0;
			foreach (ViewCs_currstock viewCs_currstock in list)
			{
				int num2 = 0;
				object[] array = new object[this.dgvData.ColumnCount];
				array[num2++] = viewCs_currstock.Id.ToString();
				array[num2++] = viewCs_currstock.WhCode;
				array[num2++] = viewCs_currstock.InvCode;
				array[num2++] = viewCs_currstock.Name;
				array[num2++] = viewCs_currstock.Code;
				array[num2++] = viewCs_currstock.BatchNum;
				array[num2++] = viewCs_currstock.Quantity;
				array[num2++] = ShowWords.ReplaceText(((StopFlagType)viewCs_currstock.StopFlag).ToString());
				array[num2++] = viewCs_currstock.SpecsDanWei;
				array[num2++] = viewCs_currstock.MassDay;
				this.dgvData.Rows.Add(array);
				num++;
			}
			bool flag = this.dgvData.Rows.Count > 0;
			if (flag)
			{
				this.GetCurrentItem(0);
			}
		}

		// Token: 0x06000319 RID: 793 RVA: 0x00003040 File Offset: 0x00001240
		private void btnAdd_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600031A RID: 794 RVA: 0x00003040 File Offset: 0x00001240
		private void btnModify_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600031B RID: 795 RVA: 0x00003040 File Offset: 0x00001240
		private void btnDelete_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600031C RID: 796 RVA: 0x0004A128 File Offset: 0x00048328
		private void btnSearch_Click(object sender, EventArgs e)
		{
			this.LoadData();
		}

		// Token: 0x0600031D RID: 797 RVA: 0x0004D7F4 File Offset: 0x0004B9F4
		private void txtName_KeyPress(object sender, KeyPressEventArgs e)
		{
			bool flag = e.KeyChar == '\r';
			if (flag)
			{
				this.LoadData();
			}
		}

		// Token: 0x0600031E RID: 798 RVA: 0x0004D81C File Offset: 0x0004BA1C
		private void txtBatchInfo_KeyPress(object sender, KeyPressEventArgs e)
		{
			bool flag = e.KeyChar == '\r';
			if (flag)
			{
				this.LoadData();
			}
		}

		// Token: 0x0600031F RID: 799 RVA: 0x0004D844 File Offset: 0x0004BA44
		private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			bool flag = e.RowIndex >= 0;
			if (flag)
			{
				this.GetCurrentItem(e.RowIndex);
			}
		}

		// Token: 0x06000320 RID: 800 RVA: 0x0004D874 File Offset: 0x0004BA74
		private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			bool flag = ((DataGridViewX)sender).CurrentCell != null && ((DataGridViewX)sender).CurrentCell.OwningColumn.Name == "C_HeWeiConfig";
			if (flag)
			{
				this.OpenForm(typeof(frmProUnitCheck), ((DataGridViewX)sender).CurrentCell.OwningColumn.HeaderText, BaseForm.FormActtion.Modify);
			}
		}

		// Token: 0x06000321 RID: 801 RVA: 0x0004D8E0 File Offset: 0x0004BAE0
		private void dgvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			bool flag = e.RowIndex >= 0;
			if (flag)
			{
			}
		}

		// Token: 0x06000322 RID: 802 RVA: 0x0004D900 File Offset: 0x0004BB00
		private void GetCurrentItem(int rowindex)
		{
			this._CurrentId = int.Parse(this.dgvData.Rows[rowindex].Cells[0].Value.ToString());
			this._CurrentItemName = this.dgvData.Rows[rowindex].Cells["C_InvCode"].Value.ToString();
			this.btnModify.Enabled = true;
			this.btnDelete.Enabled = true;
		}

		// Token: 0x06000323 RID: 803 RVA: 0x00003040 File Offset: 0x00001240
		protected void OpenForm(ButtonItem sender, BaseForm.FormActtion action, string d)
		{
		}

		// Token: 0x06000324 RID: 804 RVA: 0x0004D989 File Offset: 0x0004BB89
		private void btnExport_Click(object sender, EventArgs e)
		{
			base.ExportExcel(this.dgvData);
		}

		// Token: 0x040004E2 RID: 1250
		private int _StaticColumnCount;

		// Token: 0x040004E3 RID: 1251
		private bool isEditOpen = false;

		// Token: 0x040004E4 RID: 1252
		private DAL.SQLServer.SQSConfig.DalCs_currstock _Dal = DAL.Base.SQSConfig.DalCs_currstock.Instance;

		// Token: 0x040004E5 RID: 1253
		private int _ProductState = 0;

		// Token: 0x040004E6 RID: 1254
		private bool _IsBatchMerging = false;

		// Token: 0x040004E7 RID: 1255
		private string _ProInfo = string.Empty;

		// Token: 0x040004E8 RID: 1256
		private string _BatchInfo = string.Empty;
	}
}
