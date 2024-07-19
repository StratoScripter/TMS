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
	// Token: 0x0200004B RID: 75
	public partial class frmEquipClass : BaseDialogForm
	{
		// Token: 0x0600039F RID: 927 RVA: 0x0005BF54 File Offset: 0x0005A154
		public frmEquipClass()
		{
			this.InitializeComponent();
			this.SetText(this);
		}

		// Token: 0x060003A0 RID: 928 RVA: 0x0005BFA4 File Offset: 0x0005A1A4
		private void frmEquipClass_Load(object sender, EventArgs e)
		{
			BaseDialogForm._operateArgs.Category = this.Text;
			this.menuAdd.Shortcuts.Add(eShortcut.CtrlIns);
			this.menuModify.Shortcuts.Add(eShortcut.CtrlEnter);
			this.menuDelete.Shortcuts.Add(eShortcut.CtrlDel);
			base.SetGridUI(this.dgvData);
			this.dgvData.MultiSelect = false;
			this.LoadData();
		}

		// Token: 0x060003A1 RID: 929 RVA: 0x0005C026 File Offset: 0x0005A226
		private void menuAdd_Click(object sender, EventArgs e)
		{
			this.OpenForm(typeof(frmEquipClassEdit), ((ButtonItem)sender).Text, BaseForm.FormActtion.Add, this._FrmName);
		}

		// Token: 0x060003A2 RID: 930 RVA: 0x0005C04C File Offset: 0x0005A24C
		private void menuModify_Click(object sender, EventArgs e)
		{
			this.OpenForm(typeof(frmEquipClassEdit), ((ButtonItem)sender).Text, BaseForm.FormActtion.Modify, this._FrmName);
		}

		// Token: 0x060003A3 RID: 931 RVA: 0x0005C074 File Offset: 0x0005A274
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
							ModSrm_equipclass model = this._dalequipclass.GetModel(this._CurrentId);
							bool flag5 = !this._dalequipclass.Delete(this._CurrentId);
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

		// Token: 0x060003A4 RID: 932 RVA: 0x0005C1BC File Offset: 0x0005A3BC
		private bool CheckCanDelete()
		{
			ModSrm_equipclass model = this._dalequipclass.GetModel(this._CurrentId);
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

		// Token: 0x060003A5 RID: 933 RVA: 0x0005C20A File Offset: 0x0005A40A
		private void btnExport_Click(object sender, EventArgs e)
		{
			base.DataGridViewToExcel(this.dgvData);
		}

		// Token: 0x060003A6 RID: 934 RVA: 0x0005C21C File Offset: 0x0005A41C
		protected override void LoadData(string Name)
		{
			int num = this.mSelectRowIndex;
			this.dgvData.Rows.Clear();
			List<ModSrm_equipclass> allListOrderIndex = this._dalequipclass.GetAllListOrderIndex("Desc");
			foreach (ModSrm_equipclass modSrm_equipclass in allListOrderIndex)
			{
				int num2 = 0;
				string[] array = new string[this.dgvData.ColumnCount];
				array[num2++] = modSrm_equipclass.Id.ToString();
				array[num2++] = modSrm_equipclass.ClassDevName;
				array[num2++] = modSrm_equipclass.ClassDevCode;
				array[num2++] = modSrm_equipclass.ClassDevIndex.ToString();
				array[num2++] = modSrm_equipclass.Creater;
				array[num2++] = modSrm_equipclass.CreateTime.ToString("yyyy-MM-dd HH:mm:ss");
				array[num2++] = modSrm_equipclass.Modifier;
				array[num2++] = modSrm_equipclass.ModifyTime.ToString("yyyy-MM-dd HH:mm:ss");
				array[num2++] = modSrm_equipclass.Purpose;
				array[num2++] = EnumHelper.GetDescription<SRMState>((SRMState)modSrm_equipclass.State);
				array[num2++] = modSrm_equipclass.PinYinMa;
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

		// Token: 0x060003A7 RID: 935 RVA: 0x0005C3E8 File Offset: 0x0005A5E8
		private void GetCurrentItem(int rowindex)
		{
			this.mSelectRowIndex = rowindex;
			this._CurrentId = int.Parse(this.dgvData.Rows[rowindex].Cells[0].Value.ToString());
		}

		// Token: 0x060003A8 RID: 936 RVA: 0x0005C424 File Offset: 0x0005A624
		private void dgvData_SelectionChanged(object sender, EventArgs e)
		{
			bool flag = this.dgvData.SelectedRows.Count > 0;
			if (flag)
			{
				this.GetCurrentItem(this.dgvData.SelectedRows[0].Index);
			}
		}

		// Token: 0x060003A9 RID: 937 RVA: 0x0005C468 File Offset: 0x0005A668
		private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			bool flag = e.RowIndex >= 0;
			if (flag)
			{
				this.GetCurrentItem(e.RowIndex);
			}
		}

		// Token: 0x060003AA RID: 938 RVA: 0x0005C498 File Offset: 0x0005A698
		private void dgvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			bool flag = e.RowIndex >= 0;
			if (flag)
			{
				this.GetCurrentItem(e.RowIndex);
				this.OpenForm(typeof(frmEquipClassEdit), ((ButtonItem)sender).Text, BaseForm.FormActtion.Modify, this._FrmName);
			}
		}

		// Token: 0x04000612 RID: 1554
		protected int mSelectRowIndex = 0;

		// Token: 0x04000613 RID: 1555
		protected DAL.SQLServer.SQSConfig.DalSrm_equipclass _dalequipclass = DAL.Base.SQSConfig.DalSrm_equipclass.Instance;

		// Token: 0x04000614 RID: 1556
		protected string mKeyName = ShowWords.ReplaceText("SrmEquipClass");
	}
}
