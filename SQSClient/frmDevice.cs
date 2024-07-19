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
	// Token: 0x0200007F RID: 127
	public partial class frmDevice : BaseDialogForm
	{
		// Token: 0x060006EC RID: 1772 RVA: 0x000AB3BC File Offset: 0x000A95BC
		public frmDevice()
		{
			this.InitializeComponent();
			this.SetText(this);
			this._Controls.Clear();
			this._Controls.Add(this.bar);
			this._Controls.Add(this.dgvData);
			base.SetGridUI(this.dgvData);
		}

		// Token: 0x060006ED RID: 1773 RVA: 0x000AB42F File Offset: 0x000A962F
		private void frmDevice_Load(object sender, EventArgs e)
		{
			BaseDialogForm._operateArgs.Category = this.Text;
			base.InitBurron();
			this.InitControl();
			this.LoadData("");
		}

		// Token: 0x060006EE RID: 1774 RVA: 0x00003040 File Offset: 0x00001240
		private void InitControl()
		{
		}

		// Token: 0x060006EF RID: 1775 RVA: 0x000AB460 File Offset: 0x000A9660
		protected override void LoadData(string Name)
		{
			this.dgvData.Rows.Clear();
			List<ModCfg_device> list = new List<ModCfg_device>();
			bool flag = Name == "";
			if (flag)
			{
				list = DAL.Base.SQSConfig.DalCfg_device.Instance.GetAllList();
			}
			else
			{
				list = DAL.Base.SQSConfig.DalCfg_device.Instance.GetAllList(Name);
			}
			foreach (ModCfg_device modCfg_device in list)
			{
				int num = 0;
				object[] array = new object[this.dgvData.ColumnCount];
				array[num++] = modCfg_device.Id;
				array[num++] = modCfg_device.Name;
				array[num++] = modCfg_device.DevAddr;
				array[num++] = modCfg_device.Code;
				array[num++] = modCfg_device.Ways;
				array[num++] = DAL.Base.SQSConfig.DalCfg_pc.Instance.GetModel("Id", modCfg_device.PCId).Name;
				array[num++] = modCfg_device.ProtocolType;
				array[num++] = modCfg_device.MediaType;
				array[num++] = modCfg_device.MediaPara;
				array[num++] = modCfg_device.State;
				array[num++] = modCfg_device.Remark;
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

		// Token: 0x060006F0 RID: 1776 RVA: 0x000AB64C File Offset: 0x000A984C
		private void btnAdd_Click(object sender, EventArgs e)
		{
			this.OpenForm(typeof(frmDeviceEdit), ((ButtonItem)sender).Text, BaseForm.FormActtion.Add, this._FrmName);
		}

		// Token: 0x060006F1 RID: 1777 RVA: 0x000AB672 File Offset: 0x000A9872
		private void btnModify_Click(object sender, EventArgs e)
		{
			this.OpenForm(typeof(frmDeviceEdit), ((ButtonItem)sender).Text, BaseForm.FormActtion.Modify, this._FrmName);
		}

		// Token: 0x060006F2 RID: 1778 RVA: 0x000AB698 File Offset: 0x000A9898
		private void btnDelete_Click(object sender, EventArgs e)
		{
			BaseDialogForm._operateArgs.OperateType = ((ButtonItem)sender).Text;
			bool flag = !base.ShowChoise(Messages.DeleteSure, "", "");
			if (!flag)
			{
				ModCfg_device model = this._Dal.GetModel(this._CurrentId);
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

		// Token: 0x060006F3 RID: 1779 RVA: 0x000AB749 File Offset: 0x000A9949
		private void btnSearch_Click(object sender, EventArgs e)
		{
			this.LoadData(this.txtName.Text.Trim());
		}

		// Token: 0x060006F4 RID: 1780 RVA: 0x000AB764 File Offset: 0x000A9964
		private void txtName_KeyPress(object sender, KeyPressEventArgs e)
		{
			bool flag = e.KeyChar == '\r';
			if (flag)
			{
				this.LoadData(this.txtName.Text.Trim());
			}
		}

		// Token: 0x060006F5 RID: 1781 RVA: 0x000AB79C File Offset: 0x000A999C
		private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			bool flag = e.RowIndex >= 0;
			if (flag)
			{
				this.GetCurrentItem(e.RowIndex);
			}
		}

		// Token: 0x060006F6 RID: 1782 RVA: 0x000AB7CC File Offset: 0x000A99CC
		private void dgvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			bool flag = e.RowIndex >= 0;
			if (flag)
			{
				this.OpenForm(typeof(frmDeviceEdit), this.btnModify.Text, BaseForm.FormActtion.Modify, this._FrmName);
			}
		}

		// Token: 0x060006F7 RID: 1783 RVA: 0x000AB810 File Offset: 0x000A9A10
		private void GetCurrentItem(int rowindex)
		{
			this._CurrentId = int.Parse(this.dgvData.Rows[rowindex].Cells[0].Value.ToString());
			this._CurrentItemName = this.dgvData.Rows[rowindex].Cells["C_DeviceName"].Value.ToString();
			this.btnModify.Enabled = true;
			this.btnDelete.Enabled = true;
		}

		// Token: 0x04000BD0 RID: 3024
		private DAL.SQLServer.SQSConfig.DalCfg_device _Dal = DAL.Base.SQSConfig.DalCfg_device.Instance;
	}
}
