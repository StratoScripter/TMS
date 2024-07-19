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
using Model.SQSConfig;
using SQSClient.Properties;

namespace SQSClient
{
	// Token: 0x0200006E RID: 110
	public partial class frmDevItems : BaseDialogForm
	{
		// Token: 0x0600058C RID: 1420 RVA: 0x0008EA30 File Offset: 0x0008CC30
		public frmDevItems()
		{
			this.InitializeComponent();
			this.SetText(this);
			this._Controls.Clear();
			this._Controls.Add(this.bar);
			this._Controls.Add(this.dgvData);
			base.SetGridUI(this.dgvData);
		}

		// Token: 0x0600058D RID: 1421 RVA: 0x0008EAA3 File Offset: 0x0008CCA3
		private void frmDevItems_Load(object sender, EventArgs e)
		{
			BaseDialogForm._operateArgs.Category = this.Text;
			base.InitBurron();
			this.InitControl();
			this.LoadData("");
		}

		// Token: 0x0600058E RID: 1422 RVA: 0x00003040 File Offset: 0x00001240
		private void InitControl()
		{
		}

		// Token: 0x0600058F RID: 1423 RVA: 0x0008EAD4 File Offset: 0x0008CCD4
		protected override void LoadData(string Name)
		{
			this.dgvData.Rows.Clear();
			List<ModCfg_devitem> allList = this._Dal.GetAllList();
			foreach (ModCfg_devitem modCfg_devitem in allList)
			{
				int num = 0;
				object[] array = new object[this.dgvData.ColumnCount];
				array[num++] = modCfg_devitem.Id.ToString();
				array[num++] = modCfg_devitem.ItemDesc;
				array[num++] = modCfg_devitem.ItemCode;
				array[num++] = modCfg_devitem.Para;
				array[num++] = modCfg_devitem.LuHao;
				array[num++] = modCfg_devitem.DataStyle;
				array[num++] = modCfg_devitem.WriteR;
				array[num++] = modCfg_devitem.LinkAddr;
				array[num++] = ShowWords.ReplaceText(modCfg_devitem.Remark);
				this.dgvData.Rows.Add(array);
			}
			bool flag = this.dgvData.Rows.Count > 0;
			if (flag)
			{
				this.GetCurrentItem(0);
			}
		}

		// Token: 0x06000590 RID: 1424 RVA: 0x0008EC20 File Offset: 0x0008CE20
		private void btnAdd_Click(object sender, EventArgs e)
		{
			this.OpenForm(typeof(frmItemDevEdit), ((ButtonItem)sender).Text, BaseForm.FormActtion.Add, this._FrmName);
		}

		// Token: 0x06000591 RID: 1425 RVA: 0x0008EC46 File Offset: 0x0008CE46
		private void btnModify_Click(object sender, EventArgs e)
		{
			this.OpenForm(typeof(frmItemDevEdit), ((ButtonItem)sender).Text, BaseForm.FormActtion.Modify, this._FrmName);
		}

		// Token: 0x06000592 RID: 1426 RVA: 0x0008EC6C File Offset: 0x0008CE6C
		private void btnExport_Click(object sender, EventArgs e)
		{
			base.DataGridViewToExcel(this.dgvData);
		}

		// Token: 0x06000593 RID: 1427 RVA: 0x0008EC7C File Offset: 0x0008CE7C
		private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			bool flag = e.RowIndex >= 0;
			if (flag)
			{
				this.GetCurrentItem(e.RowIndex);
			}
		}

		// Token: 0x06000594 RID: 1428 RVA: 0x0008ECAC File Offset: 0x0008CEAC
		private void dgvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			bool flag = e.RowIndex >= 0;
			if (flag)
			{
				this.OpenForm(typeof(frmItemDevEdit), this.btnModify.Text, BaseForm.FormActtion.Modify, this._FrmName);
			}
		}

		// Token: 0x06000595 RID: 1429 RVA: 0x0008ECF0 File Offset: 0x0008CEF0
		private void GetCurrentItem(int rowindex)
		{
			this._CurrentId = int.Parse(this.dgvData.Rows[rowindex].Cells[0].Value.ToString());
			this._CurrentItemName = this.dgvData.Rows[rowindex].Cells["C_PointName"].Value.ToString();
		}

		// Token: 0x040009CE RID: 2510
		private DAL.SQLServer.SQSConfig.DalCfg_devitem _Dal = DAL.Base.SQSConfig.DalCfg_devitem.Instance;
	}
}
