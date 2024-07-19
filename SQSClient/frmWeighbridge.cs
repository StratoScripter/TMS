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
	// Token: 0x0200005E RID: 94
	public partial class frmWeighbridge : BaseDialogForm
	{
		// Token: 0x0600047C RID: 1148 RVA: 0x00072058 File Offset: 0x00070258
		public frmWeighbridge()
		{
			this.InitializeComponent();
			this.SetText(this);
			this._Controls.Clear();
			this._Controls.Add(this.bar);
			this._Controls.Add(this.dgvData);
			base.SetGridUI(this.dgvData);
		}

		// Token: 0x0600047D RID: 1149 RVA: 0x000720CB File Offset: 0x000702CB
		private void frmWeighbridge_Load(object sender, EventArgs e)
		{
			BaseDialogForm._operateArgs.Category = this.Text;
			base.InitBurron();
			this.InitControl();
			this.LoadData("");
		}

		// Token: 0x0600047E RID: 1150 RVA: 0x00003040 File Offset: 0x00001240
		private void InitControl()
		{
		}

		// Token: 0x0600047F RID: 1151 RVA: 0x000720FC File Offset: 0x000702FC
		protected override void LoadData(string Name)
		{
			this.dgvData.Rows.Clear();
			List<ModCfg_weighbridge> list = new List<ModCfg_weighbridge>();
			bool flag = Name == "";
			if (flag)
			{
				list = DAL.Base.SQSConfig.DalCfg_weighbridge.Instance.GetAllList();
			}
			else
			{
				list = DAL.Base.SQSConfig.DalCfg_weighbridge.Instance.GetAllList(Name);
			}
			foreach (ModCfg_weighbridge modCfg_weighbridge in list)
			{
				int num = 0;
				object[] array = new object[this.dgvData.ColumnCount];
				array[num++] = modCfg_weighbridge.Id;
				array[num++] = modCfg_weighbridge.Name;
				array[num++] = modCfg_weighbridge.Code;
				array[num++] = modCfg_weighbridge.ModeType;
				array[num++] = modCfg_weighbridge.ConnString;
				array[num++] = modCfg_weighbridge.Value;
				array[num++] = modCfg_weighbridge.Time;
				array[num++] = modCfg_weighbridge.Enable;
				array[num++] = modCfg_weighbridge.Remark;
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

		// Token: 0x06000480 RID: 1152 RVA: 0x000722A4 File Offset: 0x000704A4
		private void btnAdd_Click(object sender, EventArgs e)
		{
			this.OpenForm(typeof(frmWeighbridgeEdit), ((ButtonItem)sender).Text, BaseForm.FormActtion.Add, this._FrmName);
		}

		// Token: 0x06000481 RID: 1153 RVA: 0x000722CA File Offset: 0x000704CA
		private void btnModify_Click(object sender, EventArgs e)
		{
			this.OpenForm(typeof(frmWeighbridgeEdit), ((ButtonItem)sender).Text, BaseForm.FormActtion.Modify, this._FrmName);
		}

		// Token: 0x06000482 RID: 1154 RVA: 0x000722F0 File Offset: 0x000704F0
		private void btnDelete_Click(object sender, EventArgs e)
		{
			BaseDialogForm._operateArgs.OperateType = ((ButtonItem)sender).Text;
			ModCfg_weighbridge model = this._Dal.GetModel(this._CurrentId);
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

		// Token: 0x06000483 RID: 1155 RVA: 0x000723A1 File Offset: 0x000705A1
		private void btnSearch_Click(object sender, EventArgs e)
		{
			this.LoadData(this.txtName.Text.Trim());
		}

		// Token: 0x06000484 RID: 1156 RVA: 0x000723BC File Offset: 0x000705BC
		private void txtName_KeyPress(object sender, KeyPressEventArgs e)
		{
			bool flag = e.KeyChar == '\r';
			if (flag)
			{
				this.LoadData(this.txtName.Text.Trim());
			}
		}

		// Token: 0x06000485 RID: 1157 RVA: 0x000723F4 File Offset: 0x000705F4
		private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			bool flag = e.RowIndex >= 0;
			if (flag)
			{
				this.GetCurrentItem(e.RowIndex);
			}
		}

		// Token: 0x06000486 RID: 1158 RVA: 0x00072424 File Offset: 0x00070624
		private void dgvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			bool flag = e.RowIndex >= 0;
			if (flag)
			{
				this.OpenForm(typeof(frmWeighbridgeEdit), this.btnModify.Text, BaseForm.FormActtion.Modify, this._FrmName);
			}
		}

		// Token: 0x06000487 RID: 1159 RVA: 0x00072468 File Offset: 0x00070668
		private void GetCurrentItem(int rowindex)
		{
			this._CurrentId = int.Parse(this.dgvData.Rows[rowindex].Cells[0].Value.ToString());
			this._CurrentItemName = this.dgvData.Rows[rowindex].Cells["C_WeighbridgeName"].Value.ToString();
			this.btnModify.Enabled = true;
			this.btnDelete.Enabled = true;
		}

		// Token: 0x040007D1 RID: 2001
		private DAL.SQLServer.SQSConfig.DalCfg_weighbridge _Dal = DAL.Base.SQSConfig.DalCfg_weighbridge.Instance;
	}
}
