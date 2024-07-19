using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Assistant;
using Base;
using DAL.Base.SQSConfig;
using DAL.SQLServer.SQSConfig;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using DevComponents.Editors;
using Model;
using Model.SQSConfig;
using SQSClient.Properties;

namespace SQSClient
{
	// Token: 0x02000020 RID: 32
	public partial class frmContract : BaseDialogForm
	{
		// Token: 0x0600017D RID: 381 RVA: 0x0002E5B8 File Offset: 0x0002C7B8
		public frmContract()
		{
			this.InitializeComponent();
			this.SetText(this);
			this._Controls.Clear();
			this._Controls.Add(this.bar);
			this._Controls.Add(this.dgvData);
			base.SetGridUI(this.dgvData);
		}

		// Token: 0x0600017E RID: 382 RVA: 0x0002E62B File Offset: 0x0002C82B
		private void frmContract_Load(object sender, EventArgs e)
		{
			BaseDialogForm._operateArgs.Category = this.Text;
			base.InitBurron();
			this.InitControl();
			this.LoadData("");
		}

		// Token: 0x0600017F RID: 383 RVA: 0x00003040 File Offset: 0x00001240
		private void InitControl()
		{
		}

		// Token: 0x06000180 RID: 384 RVA: 0x0002E65C File Offset: 0x0002C85C
		protected override void LoadData(string Name)
		{
			this.dgvData.Rows.Clear();
			List<ModT_contract> list = new List<ModT_contract>();
			bool flag = Name == "";
			if (flag)
			{
				list = this._Dal.GetAllList();
			}
			else
			{
				list = this._Dal.GetAllList(Name);
			}
			foreach (ModT_contract modT_contract in list)
			{
				int num = 0;
				object[] array = new object[this.dgvData.ColumnCount];
				array[num++] = modT_contract.Id.ToString();
				array[num++] = modT_contract.ContractNum;
				array[num++] = modT_contract.PartyA;
				array[num++] = modT_contract.PartyB;
				array[num++] = ShowWords.ReplaceText(EnumHelper.GetDescription<BusinessType>((BusinessType)modT_contract.BusinessType));
				array[num++] = DAL.Base.SQSConfig.DalT_product.Instance.GetModel("InvCode", modT_contract.InvCode).InvName;
				array[num++] = modT_contract.PlanAmount;
				array[num++] = modT_contract.DanWei;
				array[num++] = modT_contract.StartTime;
				array[num++] = modT_contract.EndTime;
				array[num++] = modT_contract.LiablePerson;
				array[num++] = modT_contract.LiableTime;
				array[num++] = modT_contract.Remark;
				this.dgvData.Rows.Add(array);
			}
			bool flag2 = this.dgvData.Rows.Count > 0;
			if (flag2)
			{
				this.GetCurrentItem(this.dgvData.SelectedRows[0].Index);
			}
			else
			{
				this.btnModify.Enabled = false;
				this.btnDelete.Enabled = false;
			}
		}

		// Token: 0x06000181 RID: 385 RVA: 0x0002E888 File Offset: 0x0002CA88
		private void btnAdd_Click(object sender, EventArgs e)
		{
			this.OpenForm(typeof(frmContractEdit), ((ButtonItem)sender).Text, BaseForm.FormActtion.Add, this._FrmName);
		}

		// Token: 0x06000182 RID: 386 RVA: 0x0002E8AE File Offset: 0x0002CAAE
		private void btnModify_Click(object sender, EventArgs e)
		{
			this.OpenForm(typeof(frmContractEdit), ((ButtonItem)sender).Text, BaseForm.FormActtion.Modify, this._FrmName);
		}

		// Token: 0x06000183 RID: 387 RVA: 0x0002E8D4 File Offset: 0x0002CAD4
		private void btnDelete_Click(object sender, EventArgs e)
		{
			BaseDialogForm._operateArgs.OperateType = ((ButtonItem)sender).Text;
			ModT_contract model = this._Dal.GetModel(this._CurrentId);
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

		// Token: 0x06000184 RID: 388 RVA: 0x0002E985 File Offset: 0x0002CB85
		private void btnSearch_Click(object sender, EventArgs e)
		{
			this.LoadData(this.txtName.Text.Trim());
		}

		// Token: 0x06000185 RID: 389 RVA: 0x0002E9A0 File Offset: 0x0002CBA0
		private void txtName_KeyPress(object sender, KeyPressEventArgs e)
		{
			bool flag = e.KeyChar == '\r';
			if (flag)
			{
				this.LoadData(this.txtName.Text.Trim());
			}
		}

		// Token: 0x06000186 RID: 390 RVA: 0x0002E9D8 File Offset: 0x0002CBD8
		private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			bool flag = e.RowIndex >= 0;
			if (flag)
			{
				this.GetCurrentItem(e.RowIndex);
			}
		}

		// Token: 0x06000187 RID: 391 RVA: 0x0002EA08 File Offset: 0x0002CC08
		private void dgvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			bool flag = e.RowIndex >= 0;
			if (flag)
			{
				this.OpenForm(typeof(frmContractEdit), this.btnModify.Text, BaseForm.FormActtion.Modify, this._FrmName);
			}
		}

		// Token: 0x06000188 RID: 392 RVA: 0x0002EA4C File Offset: 0x0002CC4C
		private void GetCurrentItem(int rowindex)
		{
			this._CurrentId = int.Parse(this.dgvData.Rows[rowindex].Cells[0].Value.ToString());
			this._CurrentItemName = this.dgvData.Rows[rowindex].Cells["C_ContractID"].Value.ToString();
			this.btnModify.Enabled = true;
			this.btnDelete.Enabled = true;
		}

		// Token: 0x040002B5 RID: 693
		private DAL.SQLServer.SQSConfig.DalT_contract _Dal = DAL.Base.SQSConfig.DalT_contract.Instance;
	}
}
