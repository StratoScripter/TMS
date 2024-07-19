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
using ICHandle;
using Model;
using Model.SQSConfig;
using SQSClient.Properties;

namespace SQSClient
{
	// Token: 0x02000073 RID: 115
	public partial class frmICCard : BaseDialogForm
	{
		// Token: 0x06000634 RID: 1588 RVA: 0x0009ACB4 File Offset: 0x00098EB4
		public frmICCard()
		{
			this.InitializeComponent();
			this.SetText(this);
			this._Controls.Clear();
			this._Controls.Add(this.bar);
			this._Controls.Add(this.dgvData);
			base.SetGridUI(this.dgvData);
		}

		// Token: 0x06000635 RID: 1589 RVA: 0x0009AD27 File Offset: 0x00098F27
		private void frmICCard_Load(object sender, EventArgs e)
		{
			BaseDialogForm._operateArgs.Category = this.Text;
			base.InitBurron();
			this.InitControl();
			this.LoadData("");
		}

		// Token: 0x06000636 RID: 1590 RVA: 0x00003040 File Offset: 0x00001240
		private void InitControl()
		{
		}

		// Token: 0x06000637 RID: 1591 RVA: 0x0009AD58 File Offset: 0x00098F58
		protected override void LoadData(string Name)
		{
			this.dgvData.Rows.Clear();
			List<ModT_iccard> list = new List<ModT_iccard>();
			bool flag = Name == "";
			if (flag)
			{
				list = this._Dal.GetAllList();
			}
			else
			{
				list = this._Dal.GetAllList(Name);
			}
			foreach (ModT_iccard modT_iccard in list)
			{
				int num = 0;
				object[] array = new object[this.dgvData.ColumnCount];
				array[num++] = modT_iccard.Id.ToString();
				array[num++] = modT_iccard.CardNum;
				array[num++] = modT_iccard.IDNum;
				array[num++] = modT_iccard.BlockValue;
				array[num++] = modT_iccard.State;
				array[num++] = modT_iccard.Remark;
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

		// Token: 0x06000638 RID: 1592 RVA: 0x0009AEC8 File Offset: 0x000990C8
		private void btnAdd_Click(object sender, EventArgs e)
		{
			this.OpenForm(typeof(frmICCardEdit), ((ButtonItem)sender).Text, BaseForm.FormActtion.Add, this._FrmName);
		}

		// Token: 0x06000639 RID: 1593 RVA: 0x0009AEEE File Offset: 0x000990EE
		private void btnModify_Click(object sender, EventArgs e)
		{
			this.OpenForm(typeof(frmICCardEdit), ((ButtonItem)sender).Text, BaseForm.FormActtion.Modify, this._FrmName);
		}

		// Token: 0x0600063A RID: 1594 RVA: 0x0009AF14 File Offset: 0x00099114
		private void btnDelete_Click(object sender, EventArgs e)
		{
			BaseDialogForm._operateArgs.OperateType = ((ButtonItem)sender).Text;
			ModT_iccard model = this._Dal.GetModel(this._CurrentId);
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

		// Token: 0x0600063B RID: 1595 RVA: 0x0009AFC5 File Offset: 0x000991C5
		private void btnSearch_Click(object sender, EventArgs e)
		{
			this.LoadData(this.txtName.Text.Trim());
		}

		// Token: 0x0600063C RID: 1596 RVA: 0x0009AFE0 File Offset: 0x000991E0
		private void txtName_KeyPress(object sender, KeyPressEventArgs e)
		{
			bool flag = e.KeyChar == '\r';
			if (flag)
			{
				this.LoadData(this.txtName.Text.Trim());
			}
		}

		// Token: 0x0600063D RID: 1597 RVA: 0x0009B018 File Offset: 0x00099218
		private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			bool flag = e.RowIndex >= 0;
			if (flag)
			{
				this.GetCurrentItem(e.RowIndex);
			}
		}

		// Token: 0x0600063E RID: 1598 RVA: 0x0009B048 File Offset: 0x00099248
		private void dgvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			bool flag = e.RowIndex >= 0;
			if (flag)
			{
				this.OpenForm(typeof(frmICCardEdit), this.btnModify.Text, BaseForm.FormActtion.Modify, this._FrmName);
			}
		}

		// Token: 0x0600063F RID: 1599 RVA: 0x0009B08C File Offset: 0x0009928C
		private void GetCurrentItem(int rowindex)
		{
			this._CurrentId = int.Parse(this.dgvData.Rows[rowindex].Cells[0].Value.ToString());
			this._CurrentItemName = this.dgvData.Rows[rowindex].Cells["C_IC"].Value.ToString();
			this.btnModify.Enabled = true;
			this.btnDelete.Enabled = true;
		}

		// Token: 0x06000640 RID: 1600 RVA: 0x0009B115 File Offset: 0x00099315
		private void btnICCardWR_Click(object sender, EventArgs e)
		{
			this.OpenForm(typeof(frmICCardWR), ((ButtonItem)sender).Text, BaseForm.FormActtion.Modify);
		}

		// Token: 0x06000641 RID: 1601 RVA: 0x0009B138 File Offset: 0x00099338
		private void btnReadCard_Click(object sender, EventArgs e)
		{
			try
			{
				this.txtName.Text = ICTicket.ReadCardNum();
			}
			catch
			{
				base.ShowMsg(Messages.ReadCardFalse, "", "");
			}
		}

		// Token: 0x04000AA7 RID: 2727
		private DAL.SQLServer.SQSConfig.DalT_iccard _Dal = DAL.Base.SQSConfig.DalT_iccard.Instance;
	}
}
