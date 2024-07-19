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
	// Token: 0x02000056 RID: 86
	public partial class frmStepUnit : BaseDialogForm
	{
		// Token: 0x0600041D RID: 1053 RVA: 0x000692A4 File Offset: 0x000674A4
		public frmStepUnit()
		{
			this.InitializeComponent();
			this.SetText(this);
		}

		// Token: 0x0600041E RID: 1054 RVA: 0x000692F4 File Offset: 0x000674F4
		private void frmStepUnit_Load(object sender, EventArgs e)
		{
			BaseDialogForm._operateArgs.Category = this.Text;
			this.menuAdd.Shortcuts.Add(eShortcut.CtrlIns);
			this.menuModify.Shortcuts.Add(eShortcut.CtrlEnter);
			this.menuDelete.Shortcuts.Add(eShortcut.CtrlDel);
			base.SetGridUI(this.dgvData);
			this.dgvData.MultiSelect = false;
			this.LoadData();
		}

		// Token: 0x0600041F RID: 1055 RVA: 0x00069376 File Offset: 0x00067576
		private void menuAdd_Click(object sender, EventArgs e)
		{
			this.OpenForm(typeof(frmStepUnitEdit), ((ButtonItem)sender).Text, BaseForm.FormActtion.Add, this._FrmName);
		}

		// Token: 0x06000420 RID: 1056 RVA: 0x0006939C File Offset: 0x0006759C
		private void menuModify_Click(object sender, EventArgs e)
		{
			this.OpenForm(typeof(frmStepUnitEdit), ((ButtonItem)sender).Text, BaseForm.FormActtion.Modify, this._FrmName);
		}

		// Token: 0x06000421 RID: 1057 RVA: 0x000693C4 File Offset: 0x000675C4
		private void menuDelete_Click(object sender, EventArgs e)
		{
			BaseDialogForm._operateArgs.OperateType = ((ButtonItem)sender).Text;
			bool flag = !base.ShowChoise(Messages.DeleteSure, "", "");
			if (!flag)
			{
				bool flag2 = this.dgvData.SelectedRows.Count == 0;
				if (flag2)
				{
					base.ShowToast(this, "请选中需要删除的记录", "", "");
				}
				else
				{
					bool flag3 = this.dgvData.SelectedRows.Count > 1;
					if (flag3)
					{
						base.ShowToast(this, "请选中（1条）需要删除的记录", "", "");
					}
					else
					{
						bool flag4 = !this.CheckCanDelete();
						if (!flag4)
						{
							ModSrm_stepunit model = this._dalstepunit.GetModel(this._CurrentId);
							bool flag5 = !this._dalstepunit.Delete(this._CurrentId);
							if (flag5)
							{
								this.OnOperateFail(model, false);
								base.ShowToast(this, "删除失败", "", "");
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

		// Token: 0x06000422 RID: 1058 RVA: 0x000694F0 File Offset: 0x000676F0
		private bool CheckCanDelete()
		{
			ModSrm_stepunit model = this._dalstepunit.GetModel(this._CurrentId);
			bool flag = model == null;
			bool result;
			if (flag)
			{
				base.ShowToast(this, "当前记录检查有误，无法删除", "", "");
				result = false;
			}
			else
			{
				result = true;
			}
			return result;
		}

		// Token: 0x06000423 RID: 1059 RVA: 0x00069539 File Offset: 0x00067739
		private void btnExport_Click(object sender, EventArgs e)
		{
			base.DataGridViewToExcel(this.dgvData);
		}

		// Token: 0x06000424 RID: 1060 RVA: 0x0006954C File Offset: 0x0006774C
		protected override void LoadData(string Name)
		{
			int num = this.mSelectRowIndex;
			this.dgvData.Rows.Clear();
			List<ModSrm_stepunit> allListOrderIndex = this._dalstepunit.GetAllListOrderIndex("Desc");
			foreach (ModSrm_stepunit modSrm_stepunit in allListOrderIndex)
			{
				int num2 = 0;
				string[] array = new string[this.dgvData.ColumnCount];
				array[num2++] = modSrm_stepunit.Id.ToString();
				array[num2++] = modSrm_stepunit.SUnitName;
				array[num2++] = modSrm_stepunit.SUnitCode;
				array[num2++] = modSrm_stepunit.SUnitIndex.ToString();
				array[num2++] = modSrm_stepunit.Creater;
				array[num2++] = modSrm_stepunit.CreateTime.ToString("yyyy-MM-dd HH:mm:ss");
				array[num2++] = modSrm_stepunit.Modifier;
				array[num2++] = modSrm_stepunit.ModifyTime.ToString("yyyy-MM-dd HH:mm:ss");
				array[num2++] = modSrm_stepunit.EquipIndex.ToString();
				array[num2++] = modSrm_stepunit.StepIndex.ToString();
				array[num2++] = modSrm_stepunit.SUnitDesc;
				array[num2++] = EnumHelper.GetDescription<SRMState>((SRMState)modSrm_stepunit.State);
				array[num2++] = modSrm_stepunit.PinYinMa;
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

		// Token: 0x06000425 RID: 1061 RVA: 0x00069748 File Offset: 0x00067948
		private void GetCurrentItem(int rowindex)
		{
			this.mSelectRowIndex = rowindex;
			this._CurrentId = int.Parse(this.dgvData.Rows[rowindex].Cells[0].Value.ToString());
		}

		// Token: 0x06000426 RID: 1062 RVA: 0x00069784 File Offset: 0x00067984
		private void dgvData_SelectionChanged(object sender, EventArgs e)
		{
			bool flag = this.dgvData.SelectedRows.Count > 0;
			if (flag)
			{
				this.GetCurrentItem(this.dgvData.SelectedRows[0].Index);
			}
		}

		// Token: 0x06000427 RID: 1063 RVA: 0x000697C8 File Offset: 0x000679C8
		private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			bool flag = e.RowIndex >= 0;
			if (flag)
			{
				this.GetCurrentItem(e.RowIndex);
			}
		}

		// Token: 0x06000428 RID: 1064 RVA: 0x000697F8 File Offset: 0x000679F8
		private void dgvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			bool flag = e.RowIndex >= 0;
			if (flag)
			{
				this.GetCurrentItem(e.RowIndex);
				this.OpenForm(typeof(frmStepUnitEdit), ((ButtonItem)sender).Text, BaseForm.FormActtion.Modify, this._FrmName);
			}
		}

		// Token: 0x0400072F RID: 1839
		protected int mSelectRowIndex = 0;

		// Token: 0x04000730 RID: 1840
		protected DAL.SQLServer.SQSConfig.DalSrm_stepunit _dalstepunit = DAL.Base.SQSConfig.DalSrm_stepunit.Instance;

		// Token: 0x04000731 RID: 1841
		protected string mKeyName = ShowWords.ReplaceText("stepunit");
	}
}
