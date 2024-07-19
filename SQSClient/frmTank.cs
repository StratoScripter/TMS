using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Base;
using DAL.Base.SQSConfig;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using Model;
using Model.SQSConfig;
using SQSClient.Properties;

namespace SQSClient
{
	// Token: 0x0200008F RID: 143
	public partial class frmTank : BaseDialogForm
	{
		// Token: 0x060007D0 RID: 2000 RVA: 0x000C31A0 File Offset: 0x000C13A0
		public frmTank()
		{
			this.InitializeComponent();
			this.SetText(this);
			this._Controls.Clear();
			this._Controls.Add(this.bar);
			this._Controls.Add(this.dgvData);
			base.SetGridUI(this.dgvData);
		}

		// Token: 0x060007D1 RID: 2001 RVA: 0x000C320F File Offset: 0x000C140F
		private void frmTank_Load(object sender, EventArgs e)
		{
			BaseDialogForm._operateArgs.Category = this.Text;
			base.InitBurron();
			this.InitControl();
			this.LoadGroupData();
			this.LoadData(DalT_tank.Instance.GetAllList());
		}

		// Token: 0x060007D2 RID: 2002 RVA: 0x00003040 File Offset: 0x00001240
		private void InitControl()
		{
		}

		// Token: 0x060007D3 RID: 2003 RVA: 0x000C324C File Offset: 0x000C144C
		private void LoadGroupData()
		{
			this.itemGroup.Items.Clear();
			List<ModT_product> listByState = DalT_product.Instance.GetListByState(1, 0);
			foreach (ModT_product modT_product in listByState)
			{
				ButtonItem buttonItem = new ButtonItem();
				buttonItem.Name = modT_product.Id.ToString();
				buttonItem.Text = modT_product.InvName;
				buttonItem.Click += this.buttonItem_Click;
				this.itemGroup.Items.Add(buttonItem);
			}
			this.Refresh();
		}

		// Token: 0x060007D4 RID: 2004 RVA: 0x000C330C File Offset: 0x000C150C
		protected void LoadData(List<ModT_tank> list)
		{
			this.dgvData.Rows.Clear();
			foreach (ModT_tank modT_tank in list)
			{
				int num = 0;
				object[] array = new object[this.dgvData.ColumnCount];
				array[num++] = modT_tank.Id;
				array[num++] = modT_tank.Name;
				array[num++] = modT_tank.Code;
				object[] array2 = array;
				int num2 = num++;
				ModT_product model = DalT_product.Instance.GetModel("InvCode", modT_tank.InvCode);
				array2[num2] = ((model != null) ? model.InvName : null);
				array[num++] = modT_tank.TotalVol;
				array[num++] = modT_tank.RealVol;
				array[num++] = modT_tank.DanWei;
				array[num++] = modT_tank.Remark;
				this.dgvData.Rows.Add(array);
			}
			bool flag = this.dgvData.Rows.Count > 0;
			if (flag)
			{
				this.GetCurrentItem(0);
			}
			else
			{
				this.btnModify.Enabled = false;
				this.btnDelete.Enabled = false;
			}
		}

		// Token: 0x060007D5 RID: 2005 RVA: 0x000C346C File Offset: 0x000C166C
		private void btnAdd_Click(object sender, EventArgs e)
		{
			this.OpenForm(typeof(frmTankEdit), ((ButtonItem)sender).Text, BaseForm.FormActtion.Add, this._FrmName);
			this.LoadData(DalT_tank.Instance.GetAllList());
		}

		// Token: 0x060007D6 RID: 2006 RVA: 0x000C34A3 File Offset: 0x000C16A3
		private void btnModify_Click(object sender, EventArgs e)
		{
			this.OpenForm(typeof(frmTankEdit), ((ButtonItem)sender).Text, BaseForm.FormActtion.Modify, this._FrmName);
			this.LoadData(DalT_tank.Instance.GetAllList());
		}

		// Token: 0x060007D7 RID: 2007 RVA: 0x000C34DC File Offset: 0x000C16DC
		private void btnDelete_Click(object sender, EventArgs e)
		{
			BaseDialogForm._operateArgs.OperateType = ((ButtonItem)sender).Text;
			ModT_tank model = DalT_tank.Instance.GetModel(this._CurrentId);
			bool flag = !base.ShowChoise(Messages.DeleteSure, "", "");
			if (!flag)
			{
				bool flag2 = !DalT_tank.Instance.Delete(this._CurrentId);
				if (flag2)
				{
					this.OnOperateFail(model, false);
					base.ShowMsg(Messages.DeleteFalse, "", "");
				}
				else
				{
					this.OnOperateSuccess(model, true);
					this.LoadData(DalT_tank.Instance.GetAllList());
				}
			}
		}

		// Token: 0x060007D8 RID: 2008 RVA: 0x000C3590 File Offset: 0x000C1790
		private void btnSearch_Click(object sender, EventArgs e)
		{
			this.LoadData(DalT_tank.Instance.GetAllList(this.txtName.Text.Trim()));
		}

		// Token: 0x060007D9 RID: 2009 RVA: 0x000C35B4 File Offset: 0x000C17B4
		private void txtName_KeyPress(object sender, KeyPressEventArgs e)
		{
			bool flag = e.KeyChar == '\r';
			if (flag)
			{
				this.LoadData(DalT_tank.Instance.GetAllList(this.txtName.Text.Trim()));
			}
		}

		// Token: 0x060007DA RID: 2010 RVA: 0x000C35F4 File Offset: 0x000C17F4
		private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			bool flag = e.RowIndex >= 0;
			if (flag)
			{
				this.GetCurrentItem(e.RowIndex);
			}
		}

		// Token: 0x060007DB RID: 2011 RVA: 0x000C3624 File Offset: 0x000C1824
		private void dgvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			bool flag = e.RowIndex >= 0;
			if (flag)
			{
				this.OpenForm(typeof(frmTankEdit), this.btnModify.Text, BaseForm.FormActtion.Modify, this._FrmName);
				this.LoadData(DalT_tank.Instance.GetAllList());
			}
		}

		// Token: 0x060007DC RID: 2012 RVA: 0x000C3678 File Offset: 0x000C1878
		private void GetCurrentItem(int rowindex)
		{
			this._CurrentId = int.Parse(this.dgvData.Rows[rowindex].Cells[0].Value.ToString());
			this._CurrentItemName = this.dgvData.Rows[rowindex].Cells["C_TankName"].Value.ToString();
			this.btnModify.Enabled = true;
			this.btnDelete.Enabled = true;
		}

		// Token: 0x060007DD RID: 2013 RVA: 0x000C3704 File Offset: 0x000C1904
		private void itemGroup_Click(object sender, EventArgs e)
		{
			bool flag = this._SelectItem != null;
			if (flag)
			{
				this._SelectItem.ColorTable = eButtonColor.Orange;
			}
			this._SelectItem = null;
			this.LoadData(DalT_tank.Instance.GetAllList());
		}

		// Token: 0x060007DE RID: 2014 RVA: 0x000C3748 File Offset: 0x000C1948
		private void buttonItem_Click(object sender, EventArgs e)
		{
			bool flag = this._SelectItem != null;
			if (flag)
			{
				this._SelectItem.ColorTable = eButtonColor.Orange;
			}
			this._SelectItem = (ButtonItem)sender;
			this._SelectItem.ColorTable = eButtonColor.OrangeWithBackground;
			this.LoadData(DalT_tank.Instance.GetList("ProductName", this._SelectItem.Text));
		}

		// Token: 0x04000D78 RID: 3448
		private ButtonItem _SelectItem = null;
	}
}
