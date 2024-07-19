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
	// Token: 0x02000050 RID: 80
	public partial class frmSrmEquips : BaseDialogForm
	{
		// Token: 0x060003D7 RID: 983 RVA: 0x00061BD8 File Offset: 0x0005FDD8
		public frmSrmEquips()
		{
			this.InitializeComponent();
			this.SetText(this);
		}

		// Token: 0x060003D8 RID: 984 RVA: 0x00061C28 File Offset: 0x0005FE28
		private void frmSrmEquips_Load(object sender, EventArgs e)
		{
			BaseDialogForm._operateArgs.Category = this.Text;
			this.menuAdd.Shortcuts.Add(eShortcut.CtrlIns);
			this.menuModify.Shortcuts.Add(eShortcut.CtrlEnter);
			this.menuDelete.Shortcuts.Add(eShortcut.CtrlDel);
			base.SetGridUI(this.dgvData);
			this.dgvData.MultiSelect = false;
			this.LoadData();
		}

		// Token: 0x060003D9 RID: 985 RVA: 0x00061CAA File Offset: 0x0005FEAA
		private void menuAdd_Click(object sender, EventArgs e)
		{
			this.OpenForm(typeof(frmSrmEquipsEdit), ((ButtonItem)sender).Text, BaseForm.FormActtion.Add, this._FrmName);
		}

		// Token: 0x060003DA RID: 986 RVA: 0x00061CD0 File Offset: 0x0005FED0
		private void menuModify_Click(object sender, EventArgs e)
		{
			this.OpenForm(typeof(frmSrmEquipsEdit), ((ButtonItem)sender).Text, BaseForm.FormActtion.Modify, this._FrmName);
		}

		// Token: 0x060003DB RID: 987 RVA: 0x00061CF8 File Offset: 0x0005FEF8
		private void menuDelete_Click(object sender, EventArgs e)
		{
			BaseDialogForm._operateArgs.OperateType = ((ButtonItem)sender).Text;
			bool flag = !base.ShowChoise(Messages.DeleteSure, "", "");
			if (!flag)
			{
				bool flag2 = this.dgvData.SelectedRows.Count == 0;
				if (flag2)
				{
					base.ShowToast(this, ShowWords.ReplaceText("DeleteSelect"), "", "");
				}
				else
				{
					bool flag3 = this.dgvData.SelectedRows.Count > 1;
					if (flag3)
					{
						base.ShowToast(this, string.Format(ShowWords.ReplaceText("DeleteSelectCount"), 1), "", "");
					}
					else
					{
						bool flag4 = !this.CheckCanDelete();
						if (!flag4)
						{
							ModSrm_equips model = this._dalequips.GetModel(this._CurrentId);
							bool flag5 = !this._dalequips.Delete(this._CurrentId);
							if (flag5)
							{
								this.OnOperateFail(model, false);
								base.ShowToast(this, ShowWords.ReplaceText("DeleteFalse"), "", "");
							}
							else
							{
								this.OnOperateSuccess(model, true);
								this.LoadData();
							}
						}
					}
				}
			}
		}

		// Token: 0x060003DC RID: 988 RVA: 0x00061E40 File Offset: 0x00060040
		private bool CheckCanDelete()
		{
			ModSrm_equips model = this._dalequips.GetModel(this._CurrentId);
			bool flag = model == null;
			bool result;
			if (flag)
			{
				base.ShowToast(this, ShowWords.ReplaceText("CheckNotDelete"), "", "");
				result = false;
			}
			else
			{
				result = true;
			}
			return result;
		}

		// Token: 0x060003DD RID: 989 RVA: 0x00061E8E File Offset: 0x0006008E
		private void btnExport_Click(object sender, EventArgs e)
		{
			base.DataGridViewToExcel(this.dgvData);
		}

		// Token: 0x060003DE RID: 990 RVA: 0x00061EA0 File Offset: 0x000600A0
		protected override void LoadData(string Name)
		{
			int num = this.mSelectRowIndex;
			this.dgvData.Rows.Clear();
			List<ModSrm_equips> allListOrderIndex = this._dalequips.GetAllListOrderIndex("Desc");
			foreach (ModSrm_equips modSrm_equips in allListOrderIndex)
			{
				int num2 = 0;
				string[] array = new string[this.dgvData.ColumnCount];
				array[num2++] = modSrm_equips.Id.ToString();
				array[num2++] = modSrm_equips.EquipName;
				array[num2++] = modSrm_equips.EquipCode;
				array[num2++] = modSrm_equips.EquipIndex.ToString();
				array[num2++] = modSrm_equips.Creater;
				array[num2++] = modSrm_equips.CreateTime.ToString("yyyy-MM-dd HH:mm:ss");
				array[num2++] = modSrm_equips.Modifier;
				array[num2++] = modSrm_equips.ModifyTime.ToString("yyyy-MM-dd HH:mm:ss");
				array[num2++] = modSrm_equips.VenCode;
				array[num2++] = EnumHelper.GetDescription<SRMState>((SRMState)modSrm_equips.State);
				array[num2++] = modSrm_equips.PinYinMa;
				DataGridViewRowCollection rows = this.dgvData.Rows;
				object[] values = array;
				rows.Add(values);
			}
			bool flag = this.dgvData.Rows.Count > num;
			if (flag)
			{
				this.dgvData.Rows[num].Selected = true;
			}
		}

		// Token: 0x060003DF RID: 991 RVA: 0x0006206C File Offset: 0x0006026C
		private void GetCurrentItem(int rowindex)
		{
			this.mSelectRowIndex = rowindex;
			this._CurrentId = int.Parse(this.dgvData.Rows[rowindex].Cells[0].Value.ToString());
		}

		// Token: 0x060003E0 RID: 992 RVA: 0x000620A8 File Offset: 0x000602A8
		private void dgvData_SelectionChanged(object sender, EventArgs e)
		{
			bool flag = this.dgvData.SelectedRows.Count > 0;
			if (flag)
			{
				this.GetCurrentItem(this.dgvData.SelectedRows[0].Index);
			}
		}

		// Token: 0x060003E1 RID: 993 RVA: 0x000620EC File Offset: 0x000602EC
		private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			bool flag = e.RowIndex >= 0;
			if (flag)
			{
				this.GetCurrentItem(e.RowIndex);
			}
		}

		// Token: 0x060003E2 RID: 994 RVA: 0x0006211C File Offset: 0x0006031C
		private void dgvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			bool flag = e.RowIndex >= 0;
			if (flag)
			{
				this.GetCurrentItem(e.RowIndex);
				this.OpenForm(typeof(frmSrmEquipsEdit), ((ButtonItem)sender).Text, BaseForm.FormActtion.Modify, this._FrmName);
			}
		}

		// Token: 0x04000693 RID: 1683
		protected int mSelectRowIndex = 0;

		// Token: 0x04000694 RID: 1684
		protected DAL.SQLServer.SQSConfig.DalSrm_equips _dalequips = DAL.Base.SQSConfig.DalSrm_equips.Instance;

		// Token: 0x04000695 RID: 1685
		protected string mKeyName = ShowWords.ReplaceText("SrmEquip");
	}
}
