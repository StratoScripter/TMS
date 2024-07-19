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
	// Token: 0x02000096 RID: 150
	public partial class frmSettlepart : BaseDialogForm
	{
		// Token: 0x06000858 RID: 2136 RVA: 0x000CDF94 File Offset: 0x000CC194
		public frmSettlepart()
		{
			this.InitializeComponent();
			this.SetText(this);
			this._Controls.Clear();
			this._Controls.Add(this.bar);
			this._Controls.Add(this.dgvData);
			base.SetGridUI(this.dgvData);
		}

		// Token: 0x06000859 RID: 2137 RVA: 0x000CE007 File Offset: 0x000CC207
		private void frmSettlepart_Load(object sender, EventArgs e)
		{
			BaseDialogForm._operateArgs.Category = this.Text;
			base.InitBurron();
			this.InitControl();
			this.LoadData("");
		}

		// Token: 0x0600085A RID: 2138 RVA: 0x00003040 File Offset: 0x00001240
		private void InitControl()
		{
		}

		// Token: 0x0600085B RID: 2139 RVA: 0x000CE038 File Offset: 0x000CC238
		protected override void LoadData(string Name)
		{
			this.dgvData.Rows.Clear();
			List<ModT_settlepart> list = new List<ModT_settlepart>();
			bool flag = Name == "";
			if (flag)
			{
				list = this._Dal.GetAllList();
			}
			else
			{
				list = this._Dal.GetAllList(Name);
			}
			foreach (ModT_settlepart modT_settlepart in list)
			{
				int num = 0;
				object[] array = new object[this.dgvData.ColumnCount];
				array[num++] = modT_settlepart.Id.ToString();
				array[num++] = modT_settlepart.Name;
				array[num++] = modT_settlepart.Address;
				array[num++] = modT_settlepart.Person;
				array[num++] = modT_settlepart.PhoneNum;
				array[num++] = modT_settlepart.Remark;
				this.dgvData.Rows.Add(array);
			}
			bool flag2 = this.dgvData.Rows.Count > 0;
			if (flag2)
			{
				this.GetCurrentItem(0);
			}
			else
			{
				this.btnModify.Enabled = false;
				this.btnDelete.Enabled = false;
			}
		}

		// Token: 0x0600085C RID: 2140 RVA: 0x000CE1A4 File Offset: 0x000CC3A4
		private void btnAdd_Click(object sender, EventArgs e)
		{
			this.OpenForm(typeof(frmSettlepartEdit), ((ButtonItem)sender).Text, BaseForm.FormActtion.Add, this._FrmName);
		}

		// Token: 0x0600085D RID: 2141 RVA: 0x000CE1CA File Offset: 0x000CC3CA
		private void btnModify_Click(object sender, EventArgs e)
		{
			this.OpenForm(typeof(frmSettlepartEdit), ((ButtonItem)sender).Text, BaseForm.FormActtion.Modify, this._FrmName);
		}

		// Token: 0x0600085E RID: 2142 RVA: 0x000CE1F0 File Offset: 0x000CC3F0
		private void btnDelete_Click(object sender, EventArgs e)
		{
			BaseDialogForm._operateArgs.OperateType = ((ButtonItem)sender).Text;
			ModT_settlepart model = this._Dal.GetModel(this._CurrentId);
			bool flag = !base.ShowChoise(Messages.DeleteSure, "", "");
			if (!flag)
			{
				bool flag2 = !this._Dal.Delete(this._CurrentId);
				if (flag2)
				{
					this.OnOperateFail(model, false);
					base.ShowMsg(Messages.DeleteFalse, "", "");
				}
				else
				{
					this.OnOperateSuccess(model, true);
					this.LoadData("");
				}
			}
		}

		// Token: 0x0600085F RID: 2143 RVA: 0x000CE2A1 File Offset: 0x000CC4A1
		private void btnSearch_Click(object sender, EventArgs e)
		{
			this.LoadData(this.txtName.Text.Trim());
		}

		// Token: 0x06000860 RID: 2144 RVA: 0x000CE2BC File Offset: 0x000CC4BC
		private void txtName_KeyPress(object sender, KeyPressEventArgs e)
		{
			bool flag = e.KeyChar == '\r';
			if (flag)
			{
				this.LoadData(this.txtName.Text.Trim());
			}
		}

		// Token: 0x06000861 RID: 2145 RVA: 0x000CE2F4 File Offset: 0x000CC4F4
		private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			bool flag = e.RowIndex >= 0;
			if (flag)
			{
				this.GetCurrentItem(e.RowIndex);
			}
		}

		// Token: 0x06000862 RID: 2146 RVA: 0x000CE324 File Offset: 0x000CC524
		private void dgvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			bool flag = e.RowIndex >= 0;
			if (flag)
			{
				this.OpenForm(typeof(frmSettlepartEdit), this.btnModify.Text, BaseForm.FormActtion.Modify, this._FrmName);
			}
		}

		// Token: 0x06000863 RID: 2147 RVA: 0x000CE368 File Offset: 0x000CC568
		private void GetCurrentItem(int rowindex)
		{
			this._CurrentId = int.Parse(this.dgvData.Rows[rowindex].Cells[0].Value.ToString());
			this._CurrentItemName = this.dgvData.Rows[rowindex].Cells["C_Settlepart"].Value.ToString();
			this.btnModify.Enabled = true;
			this.btnDelete.Enabled = true;
		}

		// Token: 0x04000E3D RID: 3645
		private DAL.SQLServer.SQSConfig.DalT_settlepart _Dal = DAL.Base.SQSConfig.DalT_settlepart.Instance;
	}
}
