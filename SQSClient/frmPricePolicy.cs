using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;
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
	// Token: 0x02000033 RID: 51
	public partial class frmPricePolicy : BaseDialogForm
	{
		// Token: 0x0600025F RID: 607 RVA: 0x00042964 File Offset: 0x00040B64
		public frmPricePolicy()
		{
			this.InitializeComponent();
			this.SetText(this);
			this._Controls.Clear();
			this._Controls.Add(this.bar);
			this._Controls.Add(this.dgvPricePolicy);
			base.SetGridUI(this.dgvPricePolicy);
		}

		// Token: 0x06000260 RID: 608 RVA: 0x000429D7 File Offset: 0x00040BD7
		private void frmPricePolicy_Load(object sender, EventArgs e)
		{
			base.InitBurron();
			this.LoadData("");
		}

		// Token: 0x06000261 RID: 609 RVA: 0x000429F0 File Offset: 0x00040BF0
		protected override void LoadData(string Name)
		{
			this.dgvPricePolicy.Rows.Clear();
			List<ModT_pricepolicy> list = new List<ModT_pricepolicy>();
			list = this._Dal.GetListRequire("1 = 1", new List<string>
			{
				"Id Desc"
			}, null);
			foreach (ModT_pricepolicy modT_pricepolicy in list)
			{
				int num = 0;
				object[] array = new object[this.dgvPricePolicy.ColumnCount];
				array[num++] = modT_pricepolicy.Id.ToString();
				array[num++] = modT_pricepolicy.KeyCode;
				array[num++] = modT_pricepolicy.Type;
				array[num++] = modT_pricepolicy.RunTime.ToString("yyyy-MM-dd HH:mm");
				array[num++] = modT_pricepolicy.ThresholdPriceInfo;
				array[num++] = modT_pricepolicy.ThresholdUnit;
				array[num++] = modT_pricepolicy.PriceUnit;
				array[num++] = modT_pricepolicy.Remark;
				this.dgvPricePolicy.Rows.Add(array);
			}
			bool flag = this.dgvPricePolicy.Rows.Count > 0;
			if (flag)
			{
				this.GetCurrentItem(0);
			}
			else
			{
				this.btnModify.Enabled = false;
				this.btnDelete.Enabled = false;
			}
		}

		// Token: 0x06000262 RID: 610 RVA: 0x00042B6C File Offset: 0x00040D6C
		private void GetCurrentItem(int rowindex)
		{
			this._CurrentId = int.Parse(this.dgvPricePolicy.Rows[rowindex].Cells[0].Value.ToString());
			this.btnModify.Enabled = true;
			this.btnDelete.Enabled = true;
		}

		// Token: 0x06000263 RID: 611 RVA: 0x00042BC5 File Offset: 0x00040DC5
		private void btnAdd_Click(object sender, EventArgs e)
		{
			this.OpenForm(typeof(frmPricePolicyEdit), ((ButtonItem)sender).Text, BaseForm.FormActtion.Add, this._FrmName);
		}

		// Token: 0x06000264 RID: 612 RVA: 0x00042BEB File Offset: 0x00040DEB
		private void btnModify_Click(object sender, EventArgs e)
		{
			this.OpenForm(typeof(frmPricePolicyEdit), ((ButtonItem)sender).Text, BaseForm.FormActtion.Modify, this._FrmName);
		}

		// Token: 0x06000265 RID: 613 RVA: 0x00042C14 File Offset: 0x00040E14
		private void btnDelete_Click(object sender, EventArgs e)
		{
			ModT_pricepolicy model = this._Dal.GetModel(this._CurrentId);
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

		// Token: 0x06000266 RID: 614 RVA: 0x00042CB0 File Offset: 0x00040EB0
		private void dgvPricePolicy_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			bool flag = e.RowIndex >= 0;
			if (flag)
			{
				this.GetCurrentItem(e.RowIndex);
			}
		}

		// Token: 0x06000267 RID: 615 RVA: 0x00042CE0 File Offset: 0x00040EE0
		private void dgvPricePolicy_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			bool flag = e.RowIndex >= 0;
			if (flag)
			{
				this.OpenForm(typeof(frmPricePolicyEdit), this.btnModify.Text, BaseForm.FormActtion.Modify, this._FrmName);
			}
		}

		// Token: 0x06000268 RID: 616 RVA: 0x00042D24 File Offset: 0x00040F24
		private void btnCopy_Click(object sender, EventArgs e)
		{
			bool flag = !base.ShowChoise("CopySure", "", "");
			if (!flag)
			{
				ModT_pricepolicy modelByOrder = DAL.Base.SQSConfig.DalT_pricepolicy.Instance.GetModelByOrder("Id", "Desc");
				modelByOrder.RunTime = DateTime.Now.AddHours(2.0);
				DAL.Base.SQSConfig.DalT_pricepolicy.Instance.Add(modelByOrder);
				this.LoadData("");
			}
		}

		// Token: 0x06000269 RID: 617 RVA: 0x00042D9C File Offset: 0x00040F9C
		private void btnPrint_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = PrinterSettings.InstalledPrinters.Count <= 0;
				if (flag)
				{
					base.ShowMsg(Messages.PrinterHavent, "", "");
					return;
				}
			}
			catch (Win32Exception ex)
			{
				base.ShowMsg(Messages.PrinterHavent, "", "");
				return;
			}
			string text = this.Text;
			string empty = string.Empty;
			bool flag2 = this.dgvPricePolicy.Rows.Count > 0;
			if (flag2)
			{
				frmPrintView frmPrintView = new frmPrintView(this.dgvPricePolicy, text, empty);
				frmPrintView.Print();
			}
			else
			{
				base.ShowMsg(Messages.NoData, "", "");
			}
		}

		// Token: 0x0600026A RID: 618 RVA: 0x00042E60 File Offset: 0x00041060
		private void btnExport_Click(object sender, EventArgs e)
		{
			base.ExportExcel(this.dgvPricePolicy);
		}

		// Token: 0x0400042D RID: 1069
		private DAL.SQLServer.SQSConfig.DalT_pricepolicy _Dal = DAL.Base.SQSConfig.DalT_pricepolicy.Instance;
	}
}
