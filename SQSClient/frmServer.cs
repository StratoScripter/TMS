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
using Model;
using Model.SQSConfig;
using SQSClient.Properties;

namespace SQSClient
{
	// Token: 0x02000083 RID: 131
	public partial class frmServer : BaseDialogForm
	{
		// Token: 0x0600071B RID: 1819 RVA: 0x000B1818 File Offset: 0x000AFA18
		public frmServer()
		{
			this.InitializeComponent();
			this.SetText(this);
			this._Controls.Clear();
			this._Controls.Add(this.bar);
			this._Controls.Add(this.dgvData);
			base.SetGridUI(this.dgvData);
		}

		// Token: 0x0600071C RID: 1820 RVA: 0x000B188B File Offset: 0x000AFA8B
		private void frmPC_Load(object sender, EventArgs e)
		{
			BaseDialogForm._operateArgs.Category = this.Text;
			base.InitBurron();
			this.InitControl();
			this.LoadData("");
		}

		// Token: 0x0600071D RID: 1821 RVA: 0x00003040 File Offset: 0x00001240
		private void InitControl()
		{
		}

		// Token: 0x0600071E RID: 1822 RVA: 0x000B18BC File Offset: 0x000AFABC
		protected override void LoadData(string Name)
		{
			this.dgvData.Rows.Clear();
			List<ModCfg_pc> list = new List<ModCfg_pc>();
			bool flag = Name == "";
			if (flag)
			{
				list = this._Dal.GetAllList();
			}
			else
			{
				list = this._Dal.GetAllList(Name);
			}
			foreach (ModCfg_pc modCfg_pc in list)
			{
				int num = 0;
				object[] array = new object[this.dgvData.ColumnCount];
				array[num++] = modCfg_pc.Id.ToString();
				array[num++] = modCfg_pc.Name;
				array[num++] = modCfg_pc.IPAddr;
				array[num++] = ShowWords.ReplaceText(EnumHelper.GetDescription<PCType>((PCType)modCfg_pc.PCType));
				array[num++] = modCfg_pc.Remark;
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

		// Token: 0x0600071F RID: 1823 RVA: 0x000B1A20 File Offset: 0x000AFC20
		private void btnAdd_Click(object sender, EventArgs e)
		{
			this.OpenForm(typeof(frmPCEdit), ((ButtonItem)sender).Text, BaseForm.FormActtion.Add, this._FrmName);
		}

		// Token: 0x06000720 RID: 1824 RVA: 0x000B1A46 File Offset: 0x000AFC46
		private void btnModify_Click(object sender, EventArgs e)
		{
			this.OpenForm(typeof(frmPCEdit), ((ButtonItem)sender).Text, BaseForm.FormActtion.Modify, this._FrmName);
		}

		// Token: 0x06000721 RID: 1825 RVA: 0x000B1A6C File Offset: 0x000AFC6C
		private void btnDelete_Click(object sender, EventArgs e)
		{
			BaseDialogForm._operateArgs.OperateType = ((ButtonItem)sender).Text;
			List<ModCfg_device> list = DAL.Base.SQSConfig.DalCfg_device.Instance.GetList("PCId", this._CurrentId);
			bool flag = list.Count > 0;
			if (flag)
			{
				base.ShowMsg(Messages.PCBound, "", "");
			}
			else
			{
				ModCfg_pc model = this._Dal.GetModel(this._CurrentId);
				bool flag2 = !base.ShowChoise(Messages.DeleteSure, "", "");
				if (!flag2)
				{
					bool flag3 = !this._Dal.Delete(this._CurrentId);
					if (flag3)
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
		}

		// Token: 0x06000722 RID: 1826 RVA: 0x000B1B63 File Offset: 0x000AFD63
		private void btnSearch_Click(object sender, EventArgs e)
		{
			this.LoadData(this.txtName.Text.Trim());
		}

		// Token: 0x06000723 RID: 1827 RVA: 0x000B1B80 File Offset: 0x000AFD80
		private void txtName_KeyPress(object sender, KeyPressEventArgs e)
		{
			bool flag = e.KeyChar == '\r';
			if (flag)
			{
				this.LoadData(this.txtName.Text.Trim());
			}
		}

		// Token: 0x06000724 RID: 1828 RVA: 0x000B1BB8 File Offset: 0x000AFDB8
		private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			bool flag = e.RowIndex >= 0;
			if (flag)
			{
				this.GetCurrentItem(e.RowIndex);
			}
		}

		// Token: 0x06000725 RID: 1829 RVA: 0x000B1BE8 File Offset: 0x000AFDE8
		private void dgvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			bool flag = e.RowIndex >= 0;
			if (flag)
			{
				this.OpenForm(typeof(frmPCEdit), this.btnModify.Text, BaseForm.FormActtion.Modify, this._FrmName);
			}
		}

		// Token: 0x06000726 RID: 1830 RVA: 0x000B1C2C File Offset: 0x000AFE2C
		private void GetCurrentItem(int rowindex)
		{
			this._CurrentId = int.Parse(this.dgvData.Rows[rowindex].Cells[0].Value.ToString());
			this._CurrentItemName = this.dgvData.Rows[rowindex].Cells["C_ServerName"].Value.ToString();
			this.btnModify.Enabled = true;
			this.btnDelete.Enabled = true;
		}

		// Token: 0x04000C30 RID: 3120
		private DAL.SQLServer.SQSConfig.DalCfg_pc _Dal = DAL.Base.SQSConfig.DalCfg_pc.Instance;
	}
}
