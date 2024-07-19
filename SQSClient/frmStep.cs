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
	// Token: 0x02000054 RID: 84
	public partial class frmStep : BaseDialogForm
	{
		// Token: 0x06000405 RID: 1029 RVA: 0x00066DA0 File Offset: 0x00064FA0
		public frmStep()
		{
			this.InitializeComponent();
			this.SetText(this);
			this._Controls.Clear();
			this._Controls.Add(this.bar);
			this._Controls.Add(this.dgvData);
			base.SetGridUI(this.dgvData);
		}

		// Token: 0x06000406 RID: 1030 RVA: 0x00066E1C File Offset: 0x0006501C
		private void frmStep_Load(object sender, EventArgs e)
		{
			BaseDialogForm._operateArgs.Category = this.Text;
			base.InitBurron();
			this.btnAdd.Shortcuts.Add(eShortcut.CtrlIns);
			this.btnModify.Shortcuts.Add(eShortcut.CtrlEnter);
			this.btnDelete.Shortcuts.Add(eShortcut.CtrlDel);
			this.dgvData.MultiSelect = false;
			this.LoadData("");
		}

		// Token: 0x06000407 RID: 1031 RVA: 0x00066E9D File Offset: 0x0006509D
		private void btnAdd_Click(object sender, EventArgs e)
		{
			this.OpenForm(typeof(frmStepEdit), ((ButtonItem)sender).Text, BaseForm.FormActtion.Add, this._FrmName);
		}

		// Token: 0x06000408 RID: 1032 RVA: 0x00066EC3 File Offset: 0x000650C3
		private void btnModify_Click(object sender, EventArgs e)
		{
			this.OpenForm(typeof(frmStepEdit), ((ButtonItem)sender).Text, BaseForm.FormActtion.Modify, this._FrmName);
		}

		// Token: 0x06000409 RID: 1033 RVA: 0x00066EEC File Offset: 0x000650EC
		private void btnDelete_Click(object sender, EventArgs e)
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
							ModSrm_step model = this._Dal.GetModel(this._CurrentId);
							bool flag5 = !this._Dal.Delete(this._CurrentId);
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

		// Token: 0x0600040A RID: 1034 RVA: 0x00067034 File Offset: 0x00065234
		private bool CheckCanDelete()
		{
			ModSrm_step model = this._Dal.GetModel(this._CurrentId);
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

		// Token: 0x0600040B RID: 1035 RVA: 0x00067082 File Offset: 0x00065282
		private void btnExport_Click(object sender, EventArgs e)
		{
			base.DataGridViewToExcel(this.dgvData);
		}

		// Token: 0x0600040C RID: 1036 RVA: 0x00067094 File Offset: 0x00065294
		protected override void LoadData(string Name)
		{
			int num = this.mSelectRowIndex;
			this.dgvData.Rows.Clear();
			List<ModSrm_step> list = new List<ModSrm_step>();
			bool flag = Name == "";
			if (flag)
			{
				list = this._Dal.GetAllList();
			}
			else
			{
				list = this._Dal.GetList("StepName", Name);
			}
			foreach (ModSrm_step modSrm_step in list)
			{
				int num2 = 0;
				object[] array = new object[this.dgvData.ColumnCount];
				array[num2++] = modSrm_step.Id.ToString();
				array[num2++] = modSrm_step.StepName;
				array[num2++] = modSrm_step.StepCode;
				array[num2++] = modSrm_step.PassBasis;
				array[num2++] = modSrm_step.ResetBasis;
				array[num2++] = modSrm_step.Creater;
				array[num2++] = modSrm_step.CreateTime;
				array[num2++] = modSrm_step.Modifier;
				array[num2++] = modSrm_step.ModifyTime;
				array[num2++] = modSrm_step.Enable;
				array[num2++] = modSrm_step.StepDesc;
				this.dgvData.Rows.Add(array);
			}
			bool flag2 = this.dgvData.Rows.Count > num;
			if (flag2)
			{
				this.dgvData.Rows[num].Selected = true;
			}
		}

		// Token: 0x0600040D RID: 1037 RVA: 0x00067274 File Offset: 0x00065474
		private void GetCurrentItem(int rowindex)
		{
			this.mSelectRowIndex = rowindex;
			this._CurrentId = int.Parse(this.dgvData.Rows[rowindex].Cells[0].Value.ToString());
		}

		// Token: 0x0600040E RID: 1038 RVA: 0x000672B0 File Offset: 0x000654B0
		private void dgvData_SelectionChanged(object sender, EventArgs e)
		{
			bool flag = this.dgvData.SelectedRows.Count > 0;
			if (flag)
			{
				this.GetCurrentItem(this.dgvData.SelectedRows[0].Index);
			}
		}

		// Token: 0x0600040F RID: 1039 RVA: 0x000672F4 File Offset: 0x000654F4
		private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			bool flag = e.RowIndex >= 0;
			if (flag)
			{
				this.GetCurrentItem(e.RowIndex);
			}
		}

		// Token: 0x06000410 RID: 1040 RVA: 0x00067324 File Offset: 0x00065524
		private void dgvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			bool flag = e.RowIndex >= 0;
			if (flag)
			{
				this.GetCurrentItem(e.RowIndex);
				this.OpenForm(typeof(frmStepEdit), this.btnModify.Text, BaseForm.FormActtion.Modify, this._FrmName);
			}
		}

		// Token: 0x040006FF RID: 1791
		protected int mSelectRowIndex = 0;

		// Token: 0x04000700 RID: 1792
		protected DAL.SQLServer.SQSConfig.DalSrm_step _Dal = DAL.Base.SQSConfig.DalSrm_step.Instance;
	}
}
