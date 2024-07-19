using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Base;
using DAL.Base.SQSConfig;
using DAL.SQLServer.SQSConfig;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using Model.SQSConfig;
using SQSClient.Properties;

namespace SQSClient
{
	// Token: 0x0200004E RID: 78
	public partial class frmInvModelN : BaseDialogForm
	{
		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060003C0 RID: 960 RVA: 0x0005F64C File Offset: 0x0005D84C
		public int mSelectInvModelId
		{
			get
			{
				return this._CurrentId;
			}
		}

		// Token: 0x060003C1 RID: 961 RVA: 0x0005F664 File Offset: 0x0005D864
		public frmInvModelN(string text, BaseForm.FormActtion act, int id, string dir)
		{
			this.InitializeComponent();
			base.Width = Screen.PrimaryScreen.Bounds.Width;
			this.SetText(this);
			this._Act = act;
		}

		// Token: 0x060003C2 RID: 962 RVA: 0x0005F6D8 File Offset: 0x0005D8D8
		public frmInvModelN(int selfId)
		{
			this.InitializeComponent();
			this.SetText(this);
			this.mSelfInvModelId = selfId;
			base.Width = Screen.PrimaryScreen.Bounds.Width - 200;
		}

		// Token: 0x060003C3 RID: 963 RVA: 0x0005F752 File Offset: 0x0005D952
		private void frmInvModelN_Load(object sender, EventArgs e)
		{
			base.SetGridUI(this.dgvData);
			this.dgvData.MultiSelect = false;
			this.LoadData("");
		}

		// Token: 0x060003C4 RID: 964 RVA: 0x0005F77C File Offset: 0x0005D97C
		protected override void LoadData(string Name)
		{
			int num = this.mSelectRowIndex;
			this.dgvData.Rows.Clear();
			List<ModSrm_invmodel> allListOrderIndex = this._dalInvModel.GetAllListOrderIndex("Desc");
			List<ModSrm_invmodel> list = (from o in allListOrderIndex
			where o.Id != this.mSelfInvModelId
			select o).ToList<ModSrm_invmodel>();
			foreach (ModSrm_invmodel modSrm_invmodel in list)
			{
				int num2 = 0;
				object[] array = new object[this.dgvData.ColumnCount];
				array[num2++] = modSrm_invmodel.Id.ToString();
				array[num2++] = modSrm_invmodel.ModelName;
				array[num2++] = modSrm_invmodel.ModelCode;
				array[num2++] = modSrm_invmodel.ModelIndex.ToString();
				array[num2++] = modSrm_invmodel.Creater;
				array[num2++] = modSrm_invmodel.CreateTime.ToString("yyyy-MM-dd HH:mm:ss");
				array[num2++] = modSrm_invmodel.Modifier;
				array[num2++] = modSrm_invmodel.ModifyTime.ToString("yyyy-MM-dd HH:mm:ss");
				array[num2++] = modSrm_invmodel.StepCount.ToString();
				array[num2++] = modSrm_invmodel.ResetNum.ToString();
				array[num2++] = modSrm_invmodel.ModelDesc;
				array[num2++] = modSrm_invmodel.Enable;
				array[num2++] = modSrm_invmodel.PinYinMa;
				this.dgvData.Rows.Add(array);
			}
			bool flag = this.dgvData.Rows.Count > num;
			if (flag)
			{
				this.dgvData.Rows[num].Selected = true;
			}
		}

		// Token: 0x060003C5 RID: 965 RVA: 0x0005F99C File Offset: 0x0005DB9C
		private void GetCurrentItem(int rowindex)
		{
			this.mSelectRowIndex = rowindex;
			this._CurrentId = int.Parse(this.dgvData.Rows[rowindex].Cells[0].Value.ToString());
		}

		// Token: 0x060003C6 RID: 966 RVA: 0x0005F9D8 File Offset: 0x0005DBD8
		private void dgvData_SelectionChanged(object sender, EventArgs e)
		{
			bool flag = this.dgvData.SelectedRows.Count > 0;
			if (flag)
			{
				this.GetCurrentItem(this.dgvData.SelectedRows[0].Index);
			}
		}

		// Token: 0x060003C7 RID: 967 RVA: 0x0005FA1C File Offset: 0x0005DC1C
		private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			bool flag = e.RowIndex >= 0;
			if (flag)
			{
				this.GetCurrentItem(e.RowIndex);
			}
		}

		// Token: 0x060003C8 RID: 968 RVA: 0x0005FA4C File Offset: 0x0005DC4C
		private void btnImport_Click(object sender, EventArgs e)
		{
			bool flag = base.ShowChoise("ImportInvModelSure", "", "");
			if (flag)
			{
				base.DialogResult = DialogResult.Yes;
			}
		}

		// Token: 0x0400065B RID: 1627
		protected int mSelectRowIndex = 0;

		// Token: 0x0400065C RID: 1628
		protected DAL.SQLServer.SQSConfig.DalSrm_invmodel _dalInvModel = DAL.Base.SQSConfig.DalSrm_invmodel.Instance;

		// Token: 0x0400065D RID: 1629
		protected string mKeyName = ShowWords.ReplaceText("SrmInvModel");

		// Token: 0x0400065E RID: 1630
		private int mSelfInvModelId = 0;
	}
}
