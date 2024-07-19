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
	// Token: 0x0200003C RID: 60
	public partial class frmOperator : BaseDialogForm
	{
		// Token: 0x060002BC RID: 700 RVA: 0x00048188 File Offset: 0x00046388
		public frmOperator()
		{
			this.InitializeComponent();
			this.SetText(this);
			this._Controls.Clear();
			this._Controls.Add(this.bar);
			this._Controls.Add(this.dgvData);
			base.SetGridUI(this.dgvData);
		}

		// Token: 0x060002BD RID: 701 RVA: 0x000481FB File Offset: 0x000463FB
		private void frmOperator_Load(object sender, EventArgs e)
		{
			base.InitBurron();
			this.InitControl();
			this.LoadData("");
		}

		// Token: 0x060002BE RID: 702 RVA: 0x00003040 File Offset: 0x00001240
		private void InitControl()
		{
		}

		// Token: 0x060002BF RID: 703 RVA: 0x00048218 File Offset: 0x00046418
		protected override void LoadData(string Name)
		{
			this.dgvData.Rows.Clear();
			List<ModT_operator> list = new List<ModT_operator>();
			bool flag = Name == "";
			if (flag)
			{
				list = this._Dal.GetAllList();
			}
			else
			{
				list = this._Dal.GetAllList(Name);
			}
			foreach (ModT_operator modT_operator in list)
			{
				int num = 0;
				object[] array = new object[this.dgvData.ColumnCount];
				array[num++] = modT_operator.Id.ToString();
				array[num++] = modT_operator.OperatorName;
				array[num++] = modT_operator.OperatorNum;
				array[num++] = modT_operator.Password;
				array[num++] = modT_operator.CardNum;
				array[num++] = modT_operator.State.ToString();
				array[num++] = modT_operator.Remark;
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

		// Token: 0x060002C0 RID: 704 RVA: 0x0004839C File Offset: 0x0004659C
		private void GetCurrentItem(int rowindex)
		{
			this._CurrentId = int.Parse(this.dgvData.Rows[rowindex].Cells[0].Value.ToString());
			this.btnModify.Enabled = true;
			this.btnDelete.Enabled = true;
		}

		// Token: 0x060002C1 RID: 705 RVA: 0x000483F8 File Offset: 0x000465F8
		private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			bool flag = e.RowIndex >= 0;
			if (flag)
			{
				this.GetCurrentItem(e.RowIndex);
			}
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x00048428 File Offset: 0x00046628
		private void dgvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			bool flag = e.RowIndex >= 0;
			if (flag)
			{
				this.OpenForm(typeof(frmOperatorEdit), this.btnModify.Text, BaseForm.FormActtion.Modify);
			}
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x00048465 File Offset: 0x00046665
		private void btnAdd_Click(object sender, EventArgs e)
		{
			this.OpenForm(typeof(frmOperatorEdit), ((ButtonItem)sender).Text, BaseForm.FormActtion.Add);
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x00048485 File Offset: 0x00046685
		private void btnModify_Click(object sender, EventArgs e)
		{
			this.OpenForm(typeof(frmOperatorEdit), ((ButtonItem)sender).Text, BaseForm.FormActtion.Modify);
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x000484A8 File Offset: 0x000466A8
		private void btnDelete_Click(object sender, EventArgs e)
		{
			bool flag = !base.ShowChoise(Messages.DeleteSure, "", "");
			if (!flag)
			{
				bool flag2 = !this._Dal.Delete(this._CurrentId);
				if (flag2)
				{
					base.ShowMsg(Messages.DeleteFalse, "", "");
				}
				else
				{
					this.LoadData("");
				}
			}
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x00048515 File Offset: 0x00046715
		private void btnSearch_Click(object sender, EventArgs e)
		{
			this.LoadData(this.txtName.Text.Trim());
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x00048530 File Offset: 0x00046730
		private void txtName_KeyPress(object sender, KeyPressEventArgs e)
		{
			bool flag = e.KeyChar == '\r';
			if (flag)
			{
				this.LoadData(this.txtName.Text.Trim());
			}
		}

		// Token: 0x0400047A RID: 1146
		private DAL.SQLServer.SQSConfig.DalT_operator _Dal = DAL.Base.SQSConfig.DalT_operator.Instance;
	}
}
