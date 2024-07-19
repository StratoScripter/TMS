using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Base;
using DAL.Base.SQSConfig;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using Model.SQSConfig;
using SQSClient.Properties;

namespace SQSClient
{
	// Token: 0x0200002D RID: 45
	public partial class frmPdaSetting : BaseDialogForm
	{
		// Token: 0x0600022C RID: 556 RVA: 0x0003F110 File Offset: 0x0003D310
		public frmPdaSetting()
		{
			this.InitializeComponent();
			this.SetText(this);
			this._Controls.Clear();
			this._Controls.Add(this.bar);
			this._Controls.Add(this.dgvData);
			base.SetGridUI(this.dgvData);
		}

		// Token: 0x0600022D RID: 557 RVA: 0x0003F178 File Offset: 0x0003D378
		private void frmPdaSetting_Load(object sender, EventArgs e)
		{
			base.InitBurron();
			this.InitControl();
			this.LoadData("");
			BaseDialogForm._operateArgs.Category = this.Text;
		}

		// Token: 0x0600022E RID: 558 RVA: 0x00003040 File Offset: 0x00001240
		private void InitControl()
		{
		}

		// Token: 0x0600022F RID: 559 RVA: 0x0003F1A8 File Offset: 0x0003D3A8
		protected override void LoadData(string Name)
		{
			this.dgvData.Rows.Clear();
			List<ModCfg_pdasetting> allList = DalCfg_pdasetting.Instance.GetAllList();
			foreach (ModCfg_pdasetting modCfg_pdasetting in allList)
			{
				int num = 0;
				object[] array = new object[this.dgvData.ColumnCount];
				array[num++] = modCfg_pdasetting.Id;
				array[num++] = modCfg_pdasetting.Type;
				array[num++] = modCfg_pdasetting.Name;
				array[num++] = modCfg_pdasetting.Value;
				array[num++] = ShowWords.ReplaceText(modCfg_pdasetting.Remark);
				this.dgvData.Rows.Add(array);
			}
			bool flag = this.dgvData.Rows.Count > 0;
			if (flag)
			{
				this.GetCurrentItem(0);
			}
		}

		// Token: 0x06000230 RID: 560 RVA: 0x0003F2B8 File Offset: 0x0003D4B8
		private void btnModify_Click(object sender, EventArgs e)
		{
			this.OpenForm(typeof(frmPdaSettingEdit), ((ButtonItem)sender).Text, BaseForm.FormActtion.Modify, this._FrmName);
		}

		// Token: 0x06000231 RID: 561 RVA: 0x0003F2E0 File Offset: 0x0003D4E0
		private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			bool flag = e.RowIndex >= 0;
			if (flag)
			{
				this.GetCurrentItem(e.RowIndex);
			}
		}

		// Token: 0x06000232 RID: 562 RVA: 0x0003F310 File Offset: 0x0003D510
		private void dgvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			bool flag = e.RowIndex >= 0;
			if (flag)
			{
				this.OpenForm(typeof(frmPdaSettingEdit), this.btnModify.Text, BaseForm.FormActtion.Modify, this._FrmName);
			}
		}

		// Token: 0x06000233 RID: 563 RVA: 0x0003F353 File Offset: 0x0003D553
		private void GetCurrentItem(int rowindex)
		{
			this._CurrentId = int.Parse(this.dgvData.Rows[rowindex].Cells[0].Value.ToString());
		}

		// Token: 0x06000234 RID: 564 RVA: 0x0003F387 File Offset: 0x0003D587
		private void btnAdd_Click(object sender, EventArgs e)
		{
			this.OpenForm(typeof(frmPdaSettingEdit), ((ButtonItem)sender).Text, BaseForm.FormActtion.Add, this._FrmName);
		}
	}
}
