using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Windows.Forms;
using Assistant;
using Base;
using DAL.Base.SQSConfig;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using DevComponents.Editors;
using DevComponents.Editors.DateTimeAdv;
using Model;
using Model.SQSConfig;
using SQSClient.Monitor;
using SQSClient.Properties;

namespace SQSClient
{
	// Token: 0x0200008B RID: 139
	public partial class frmLogQuery : BaseDialogForm
	{
		// Token: 0x06000787 RID: 1927 RVA: 0x000BB390 File Offset: 0x000B9590
		public frmLogQuery()
		{
			this.InitializeComponent();
			this.SetText(this);
			this._Controls.Clear();
			this._Controls.Add(this.bar);
			this._Controls.Add(this.dgvData);
			base.SetGridUI(this.dgvData);
			this.pagination1.PagingChangedEventHandler += this.Pagination1_PagingChangedEventHandler;
		}

		// Token: 0x06000788 RID: 1928 RVA: 0x000BB44C File Offset: 0x000B964C
		private void Pagination1_PagingChangedEventHandler(object sender, PagingEventArgs e)
		{
			List<ModSys_operatelog> list = this.list.Skip(e.NumOfPage * (e.CurrentPage - 1)).Take(e.NumOfPage).ToList<ModSys_operatelog>();
			this.InitDgv(list);
		}

		// Token: 0x06000789 RID: 1929 RVA: 0x000BB48D File Offset: 0x000B968D
		private void frmLogQuery_Load(object sender, EventArgs e)
		{
			base.InitBurron();
			this.InitControl();
			this.btnSearch_Click(null, null);
		}

		// Token: 0x0600078A RID: 1930 RVA: 0x000BB4A7 File Offset: 0x000B96A7
		private void InitControl()
		{
			this.dtpStartTime.Value = DateTimeAction.DayStartD(DateTime.Now);
			this.dtpEndTime.Value = DateTimeAction.DayEndD(DateTime.Now);
		}

		// Token: 0x0600078B RID: 1931 RVA: 0x000BB4D8 File Offset: 0x000B96D8
		private void btnSearch_Click(object sender, EventArgs e)
		{
			bool flag = !base.TimeCheck(this.dtpStartTime.Value, this.dtpEndTime.Value);
			if (!flag)
			{
				List<string> list = new List<string>();
				list.Add("EditDate>='" + this.dtpStartTime.Value.ToString() + "'");
				list.Add("EditDate<='" + this.dtpEndTime.Value.ToString() + "'");
				bool manageself = GlobalKey.Manageself;
				if (manageself)
				{
					list.Add("UserName='" + GlobalKey.UserName + "'");
				}
				this.list = DalSys_operatelog.Instance.GetListRequire(list, new List<string>
				{
					"Id"
				}, null);
				this.pagination1.Total = this.list.Count;
			}
		}

		// Token: 0x0600078C RID: 1932 RVA: 0x000BB5C8 File Offset: 0x000B97C8
		private void InitDgv(List<ModSys_operatelog> list)
		{
			this.dgvData.Rows.Clear();
			foreach (ModSys_operatelog modSys_operatelog in list)
			{
				int num = 0;
				object[] array = new object[this.dgvData.ColumnCount];
				array[num++] = modSys_operatelog.Id;
				array[num++] = modSys_operatelog.PCName;
				array[num++] = modSys_operatelog.UserName;
				array[num++] = modSys_operatelog.Category;
				array[num++] = modSys_operatelog.OperateType;
				array[num++] = ((modSys_operatelog.OperateStatus == 1) ? this.success : this.fail);
				array[num++] = modSys_operatelog.EditDate;
				array[num++] = this.detail;
				this.dgvData.Rows.Add(array);
			}
		}

		// Token: 0x0600078D RID: 1933 RVA: 0x000BB6D4 File Offset: 0x000B98D4
		private void btnExport_Click(object sender, EventArgs e)
		{
			base.ExportExcel(this.dgvData);
		}

		// Token: 0x0600078E RID: 1934 RVA: 0x000BA236 File Offset: 0x000B8436
		private void tsbtnClose_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x0600078F RID: 1935 RVA: 0x000BB6E4 File Offset: 0x000B98E4
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
			this.headerText = this.Text;
			bool flag2 = this.dgvData.Rows.Count > 0;
			if (flag2)
			{
				frmPrintView frmPrintView = new frmPrintView(this.dgvData, this.headerText, this.time);
				frmPrintView.Print();
			}
			else
			{
				base.ShowMsg(Messages.NoData, "", "");
			}
		}

		// Token: 0x06000790 RID: 1936 RVA: 0x000BB7AC File Offset: 0x000B99AC
		private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			bool flag = this.dgvData.Columns[e.ColumnIndex].Name == "C_btnDetail";
			if (flag)
			{
				int id = Convert.ToInt32(this.dgvData.Rows[e.RowIndex].Cells[0].Value);
				ModSys_operatelog model = DalSys_operatelog.Instance.GetModel(id);
				this.OpenForm(typeof(frmLogDetail), Convert.ToString(this.dgvData.Rows[e.RowIndex].Cells[e.ColumnIndex].Value), new object[]
				{
					model
				});
			}
		}

		// Token: 0x04000CDD RID: 3293
		private string headerText;

		// Token: 0x04000CDE RID: 3294
		private string time;

		// Token: 0x04000CDF RID: 3295
		private List<ModSys_operatelog> list = new List<ModSys_operatelog>();

		// Token: 0x04000CE0 RID: 3296
		private string success = ShowWords.ReplaceText("Success");

		// Token: 0x04000CE1 RID: 3297
		private string fail = ShowWords.ReplaceText("Fail");

		// Token: 0x04000CE2 RID: 3298
		private string detail = ShowWords.ReplaceText("Detail");
	}
}
