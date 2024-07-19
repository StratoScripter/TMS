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
	// Token: 0x02000060 RID: 96
	public partial class frmSystemPara : BaseDialogForm
	{
		// Token: 0x06000494 RID: 1172 RVA: 0x00074198 File Offset: 0x00072398
		public frmSystemPara()
		{
			this.InitializeComponent();
			this.SetText(this);
			this._Controls.Clear();
			this._Controls.Add(this.bar);
			this._Controls.Add(this.dgvData);
			base.SetGridUI(this.dgvData);
		}

		// Token: 0x06000495 RID: 1173 RVA: 0x00074200 File Offset: 0x00072400
		private void frmSystemPara_Load(object sender, EventArgs e)
		{
			base.InitBurron();
			this.InitControl();
			this.LoadData("");
			BaseDialogForm._operateArgs.Category = this.Text;
		}

		// Token: 0x06000496 RID: 1174 RVA: 0x00003040 File Offset: 0x00001240
		private void InitControl()
		{
		}

		// Token: 0x06000497 RID: 1175 RVA: 0x00074230 File Offset: 0x00072430
		protected override void LoadData(string Name)
		{
			this.dgvData.Rows.Clear();
			List<ModCfg_setting> allList = DalCfg_setting.Instance.GetAllList();
			foreach (ModCfg_setting modCfg_setting in allList)
			{
				int num = 0;
				object[] array = new object[this.dgvData.ColumnCount];
				array[num++] = modCfg_setting.Id;
				array[num++] = modCfg_setting.Item;
				array[num++] = modCfg_setting.Value;
				array[num++] = ShowWords.ReplaceText(modCfg_setting.Remark);
				this.dgvData.Rows.Add(array);
			}
			bool flag = this.dgvData.Rows.Count > 0;
			if (flag)
			{
				this.GetCurrentItem(0);
			}
		}

		// Token: 0x06000498 RID: 1176 RVA: 0x00074324 File Offset: 0x00072524
		private void btnModify_Click(object sender, EventArgs e)
		{
			this.OpenForm(typeof(frmSystemParaEdit), ((ButtonItem)sender).Text, BaseForm.FormActtion.Modify, this._FrmName);
		}

		// Token: 0x06000499 RID: 1177 RVA: 0x0007434C File Offset: 0x0007254C
		private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			bool flag = e.RowIndex >= 0;
			if (flag)
			{
				this.GetCurrentItem(e.RowIndex);
			}
		}

		// Token: 0x0600049A RID: 1178 RVA: 0x0007437C File Offset: 0x0007257C
		private void dgvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			bool flag = e.RowIndex >= 0;
			if (flag)
			{
				this.OpenForm(typeof(frmSystemParaEdit), this.btnModify.Text, BaseForm.FormActtion.Modify, this._FrmName);
			}
		}

		// Token: 0x0600049B RID: 1179 RVA: 0x000743BF File Offset: 0x000725BF
		private void GetCurrentItem(int rowindex)
		{
			this._CurrentId = int.Parse(this.dgvData.Rows[rowindex].Cells[0].Value.ToString());
		}
	}
}
