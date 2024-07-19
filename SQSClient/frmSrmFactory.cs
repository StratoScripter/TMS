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
	// Token: 0x02000052 RID: 82
	public partial class frmSrmFactory : BaseDialogForm
	{
		// Token: 0x060003EE RID: 1006 RVA: 0x00064318 File Offset: 0x00062518
		public frmSrmFactory()
		{
			this.InitializeComponent();
			this.SetText(this);
		}

		// Token: 0x060003EF RID: 1007 RVA: 0x00064368 File Offset: 0x00062568
		private void frmSrmFactory_Load(object sender, EventArgs e)
		{
			BaseDialogForm._operateArgs.Category = this.Text;
			this.menuAdd.Shortcuts.Add(eShortcut.CtrlIns);
			this.menuModify.Shortcuts.Add(eShortcut.CtrlEnter);
			this.menuDelete.Shortcuts.Add(eShortcut.CtrlDel);
			base.SetGridUI(this.dgvData);
			this.dgvData.MultiSelect = false;
			this.LoadData();
		}

		// Token: 0x060003F0 RID: 1008 RVA: 0x000643EA File Offset: 0x000625EA
		private void menuAdd_Click(object sender, EventArgs e)
		{
			this.OpenForm(typeof(frmSrmFactoryEdit), ((ButtonItem)sender).Text, BaseForm.FormActtion.Add, this._FrmName);
		}

		// Token: 0x060003F1 RID: 1009 RVA: 0x00064410 File Offset: 0x00062610
		private void menuModify_Click(object sender, EventArgs e)
		{
			this.OpenForm(typeof(frmSrmFactoryEdit), ((ButtonItem)sender).Text, BaseForm.FormActtion.Modify, this._FrmName);
		}

		// Token: 0x060003F2 RID: 1010 RVA: 0x00064438 File Offset: 0x00062638
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
							ModSrm_factory model = this._dalfactory.GetModel(this._CurrentId);
							bool flag5 = !this._dalfactory.Delete(this._CurrentId);
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

		// Token: 0x060003F3 RID: 1011 RVA: 0x00064580 File Offset: 0x00062780
		private bool CheckCanDelete()
		{
			ModSrm_factory model = this._dalfactory.GetModel(this._CurrentId);
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

		// Token: 0x060003F4 RID: 1012 RVA: 0x000645CE File Offset: 0x000627CE
		private void btnExport_Click(object sender, EventArgs e)
		{
			base.DataGridViewToExcel(this.dgvData);
		}

		// Token: 0x060003F5 RID: 1013 RVA: 0x000645E0 File Offset: 0x000627E0
		protected override void LoadData(string Name)
		{
			int num = this.mSelectRowIndex;
			this.dgvData.Rows.Clear();
			List<ModSrm_factory> allListOrderIndex = this._dalfactory.GetAllListOrderIndex("Desc");
			foreach (ModSrm_factory modSrm_factory in allListOrderIndex)
			{
				int num2 = 0;
				string[] array = new string[this.dgvData.ColumnCount];
				array[num2++] = modSrm_factory.Id.ToString();
				array[num2++] = modSrm_factory.FactoryName;
				array[num2++] = modSrm_factory.FactoryCode;
				array[num2++] = modSrm_factory.FactoryIndex.ToString();
				array[num2++] = modSrm_factory.Creater;
				array[num2++] = modSrm_factory.CreateTime.ToString("yyyy-MM-dd HH:mm:ss");
				array[num2++] = modSrm_factory.Modifier;
				array[num2++] = modSrm_factory.ModifyTime.ToString("yyyy-MM-dd HH:mm:ss");
				array[num2++] = modSrm_factory.AreaName;
				array[num2++] = modSrm_factory.RealName;
				array[num2++] = modSrm_factory.AppSrvCode;
				array[num2++] = EnumHelper.GetDescription<SRMState>((SRMState)modSrm_factory.State);
				array[num2++] = modSrm_factory.PinYinMa;
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

		// Token: 0x060003F6 RID: 1014 RVA: 0x000647CC File Offset: 0x000629CC
		private void GetCurrentItem(int rowindex)
		{
			this.mSelectRowIndex = rowindex;
			this._CurrentId = int.Parse(this.dgvData.Rows[rowindex].Cells[0].Value.ToString());
		}

		// Token: 0x060003F7 RID: 1015 RVA: 0x00064808 File Offset: 0x00062A08
		private void dgvData_SelectionChanged(object sender, EventArgs e)
		{
			bool flag = this.dgvData.SelectedRows.Count > 0;
			if (flag)
			{
				this.GetCurrentItem(this.dgvData.SelectedRows[0].Index);
			}
		}

		// Token: 0x060003F8 RID: 1016 RVA: 0x0006484C File Offset: 0x00062A4C
		private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			bool flag = e.RowIndex >= 0;
			if (flag)
			{
				this.GetCurrentItem(e.RowIndex);
			}
		}

		// Token: 0x060003F9 RID: 1017 RVA: 0x0006487C File Offset: 0x00062A7C
		private void dgvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			bool flag = e.RowIndex >= 0;
			if (flag)
			{
				this.GetCurrentItem(e.RowIndex);
				this.OpenForm(typeof(frmSrmFactoryEdit), ((ButtonItem)sender).Text, BaseForm.FormActtion.Modify, this._FrmName);
			}
		}

		// Token: 0x040006C6 RID: 1734
		protected int mSelectRowIndex = 0;

		// Token: 0x040006C7 RID: 1735
		protected DAL.SQLServer.SQSConfig.DalSrm_factory _dalfactory = DAL.Base.SQSConfig.DalSrm_factory.Instance;

		// Token: 0x040006C8 RID: 1736
		protected string mKeyName = ShowWords.ReplaceText("SrmFactory");
	}
}
