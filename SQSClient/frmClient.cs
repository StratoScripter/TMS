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
	// Token: 0x02000088 RID: 136
	public partial class frmClient : BaseDialogForm
	{
		// Token: 0x06000764 RID: 1892 RVA: 0x000B8114 File Offset: 0x000B6314
		public frmClient()
		{
			this.InitializeComponent();
			this.SetText(this);
			this._Controls.Clear();
			this._Controls.Add(this.bar);
			this._Controls.Add(this.dgvData);
			base.SetGridUI(this.dgvData);
		}

		// Token: 0x06000765 RID: 1893 RVA: 0x000B8187 File Offset: 0x000B6387
		private void frmClient_Load(object sender, EventArgs e)
		{
			BaseDialogForm._operateArgs.Category = this.Text;
			base.InitBurron();
			this.InitControl();
			this.LoadData("");
		}

		// Token: 0x06000766 RID: 1894 RVA: 0x00003040 File Offset: 0x00001240
		private void InitControl()
		{
		}

		// Token: 0x06000767 RID: 1895 RVA: 0x000B81B8 File Offset: 0x000B63B8
		protected override void LoadData(string Name)
		{
			this.dgvData.Rows.Clear();
			List<ModT_client> list = new List<ModT_client>();
			bool flag = Name == "";
			if (flag)
			{
				list = this._Dal.GetAllList();
			}
			else
			{
				list = this._Dal.GetAllList(Name);
			}
			foreach (ModT_client modT_client in list)
			{
				int num = 0;
				object[] array = new object[this.dgvData.ColumnCount];
				array[num++] = modT_client.Id.ToString();
				array[num++] = modT_client.Name;
				array[num++] = modT_client.Address;
				array[num++] = modT_client.Person;
				array[num++] = modT_client.Code;
				array[num++] = modT_client.PhoneNum;
				array[num++] = modT_client.Remark;
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

		// Token: 0x06000768 RID: 1896 RVA: 0x000B8334 File Offset: 0x000B6534
		private void btnAdd_Click(object sender, EventArgs e)
		{
			this.OpenForm(typeof(frmClientEdit), ((ButtonItem)sender).Text, BaseForm.FormActtion.Add, this._FrmName);
		}

		// Token: 0x06000769 RID: 1897 RVA: 0x000B835A File Offset: 0x000B655A
		private void btnModify_Click(object sender, EventArgs e)
		{
			this.OpenForm(typeof(frmClientEdit), ((ButtonItem)sender).Text, BaseForm.FormActtion.Modify, this._FrmName);
		}

		// Token: 0x0600076A RID: 1898 RVA: 0x000B8380 File Offset: 0x000B6580
		private void btnDelete_Click(object sender, EventArgs e)
		{
			BaseDialogForm._operateArgs.OperateType = ((ButtonItem)sender).Text;
			ModT_client model = this._Dal.GetModel(this._CurrentId);
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

		// Token: 0x0600076B RID: 1899 RVA: 0x000B8431 File Offset: 0x000B6631
		private void btnSearch_Click(object sender, EventArgs e)
		{
			this.LoadData(this.txtName.Text.Trim());
		}

		// Token: 0x0600076C RID: 1900 RVA: 0x000B844C File Offset: 0x000B664C
		private void txtName_KeyPress(object sender, KeyPressEventArgs e)
		{
			bool flag = e.KeyChar == '\r';
			if (flag)
			{
				this.LoadData(this.txtName.Text.Trim());
			}
		}

		// Token: 0x0600076D RID: 1901 RVA: 0x000B8484 File Offset: 0x000B6684
		private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			bool flag = e.RowIndex >= 0;
			if (flag)
			{
				this.GetCurrentItem(e.RowIndex);
			}
		}

		// Token: 0x0600076E RID: 1902 RVA: 0x000B84B4 File Offset: 0x000B66B4
		private void dgvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			bool flag = e.RowIndex >= 0;
			if (flag)
			{
				this.OpenForm(typeof(frmClientEdit), this.btnModify.Text, BaseForm.FormActtion.Modify, this._FrmName);
			}
		}

		// Token: 0x0600076F RID: 1903 RVA: 0x000B84F8 File Offset: 0x000B66F8
		private void GetCurrentItem(int rowindex)
		{
			this._CurrentId = int.Parse(this.dgvData.Rows[rowindex].Cells[0].Value.ToString());
			this._CurrentItemName = this.dgvData.Rows[rowindex].Cells["C_Clientpart"].Value.ToString();
			this.btnModify.Enabled = true;
			this.btnDelete.Enabled = true;
		}

		// Token: 0x04000C9E RID: 3230
		private DAL.SQLServer.SQSConfig.DalT_client _Dal = DAL.Base.SQSConfig.DalT_client.Instance;
	}
}
