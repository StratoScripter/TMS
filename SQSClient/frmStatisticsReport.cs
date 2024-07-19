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
using SQSClient.Properties;

namespace SQSClient
{
	// Token: 0x0200007B RID: 123
	public partial class frmStatisticsReport : BaseDialogForm
	{
		// Token: 0x060006C2 RID: 1730 RVA: 0x000A6A54 File Offset: 0x000A4C54
		public frmStatisticsReport()
		{
			this.InitializeComponent();
			this.SetText(this);
			this._Controls.Clear();
			this._Controls.Add(this.bar);
			this._Controls.Add(this.dgvData);
		}

		// Token: 0x060006C3 RID: 1731 RVA: 0x000A6AB6 File Offset: 0x000A4CB6
		private void frmStatisticsReport_Load(object sender, EventArgs e)
		{
			base.InitBurron();
			this.InitControl();
		}

		// Token: 0x060006C4 RID: 1732 RVA: 0x000A6AC8 File Offset: 0x000A4CC8
		private void InitControl()
		{
			this.cmbReportType.Items.Add(ShowWords.ReplaceText("DailyReport"));
			this.cmbReportType.Items.Add(ShowWords.ReplaceText("MonthlyReport"));
			this.rdoProduct.Checked = true;
			this.cmbReportType.SelectedIndex = 0;
			this.dtpStartTime.Value = DateTime.Now;
			this.DayStart = DalCfg_setting.Instance.GetModel("Item", "DayStart").Value;
			this.lblStatisticsInfo.Text = string.Empty;
			this.dgvData.MultiSelect = true;
		}

		// Token: 0x060006C5 RID: 1733 RVA: 0x000A6B74 File Offset: 0x000A4D74
		private void cobReportType_SelectedIndexChanged(object sender, EventArgs e)
		{
			int selectedIndex = this.cmbReportType.SelectedIndex;
			int num = selectedIndex;
			if (num != 0)
			{
				if (num == 1)
				{
					this.dtpStartTime.Format = eDateTimePickerFormat.Custom;
					this.dtpStartTime.CustomFormat = "yyyy-MM-dd";
				}
			}
			else
			{
				this.dtpStartTime.Format = eDateTimePickerFormat.Custom;
				this.dtpStartTime.CustomFormat = "yyyy-MM-dd";
			}
		}

		// Token: 0x060006C6 RID: 1734 RVA: 0x000A6BE0 File Offset: 0x000A4DE0
		private void btnSearch_Click(object sender, EventArgs e)
		{
			this.mSearching = true;
			DateTime dateTime = this.dtpStartTime.Value;
			DateTime dateTime2 = this.dtpStartTime.Value;
			int selectedIndex = this.cmbReportType.SelectedIndex;
			int num = selectedIndex;
			if (num != 0)
			{
				if (num == 1)
				{
					this.time = this.dtpStartTime.Value.ToString("yyyy-MM-dd");
					dateTime = DateTime.Parse(this.dtpStartTime.Value.ToString("yyyy-MM-dd") + " " + this.DayStart);
					dateTime2 = DateTime.Parse(this.dtpStartTime.Value.AddMonths(1).ToString("yyyy-MM-dd") + " " + this.DayStart);
				}
			}
			else
			{
				this.time = this.dtpStartTime.Value.ToString("yyyy-MM-dd");
				dateTime = DateTime.Parse(this.dtpStartTime.Value.ToString("yyyy-MM-dd") + " " + this.DayStart);
				dateTime2 = DateTime.Parse(this.dtpStartTime.Value.AddDays(1.0).ToString("yyyy-MM-dd") + " " + this.DayStart);
			}
			List<string> list = new List<string>();
			list.Add("State>=1");
			list.Add("JieSuanTime>='" + dateTime.ToString() + "'");
			list.Add("JieSuanTime<='" + dateTime2.ToString() + "'");
			bool manageself = GlobalKey.Manageself;
			if (manageself)
			{
				list.Add("ZhiDanRen='" + GlobalKey.UserName + "'");
			}
			List<ModT_ticket> listRequire = DalT_ticket.Instance.GetListRequire(list, new List<string>
			{
				"Id"
			}, null);
			int jslDecimal = Settings.Instance.JieSuanLiangDecimal;
			bool @checked = this.rdoProduct.Checked;
			if (@checked)
			{
				int RowIndex = 0;
				this.dgvData.Rows.Clear();
				Func<ModT_ticket, decimal> <>9__4;
				(from x in listRequire
				group x by new
				{
					x.InvCode,
					x.BusinessType
				} into x
				orderby x.Key.InvCode
				select x).ToList().ForEach(delegate(group)
				{
					int num2 = 0;
					this.dgvData.Rows.Add();
					this.dgvData.Rows[RowIndex].Cells[num2++].Value = group.Key.InvCode;
					this.dgvData.Rows[RowIndex].Cells[num2++].Value = group.First<ModT_ticket>().ProductName;
					this.dgvData.Rows[RowIndex].Cells[num2++].Value = ShowWords.ReplaceText(EnumHelper.GetDescription<BusinessType>((BusinessType)group.Key.BusinessType));
					this.dgvData.Rows[RowIndex].Cells[num2++].Value = group.Count<ModT_ticket>();
					this.dgvData.Rows[RowIndex].Cells[num2++].Value = group.Sum((ModT_ticket p) => p.DifferWeight);
					DataGridViewCell dataGridViewCell = this.dgvData.Rows[RowIndex].Cells[num2++];
					Func<ModT_ticket, decimal> selector;
					if ((selector = <>9__4) == null)
					{
						selector = (<>9__4 = ((ModT_ticket p) => (jslDecimal > -1) ? Math.Round(p.JieSuanLiang, jslDecimal, MidpointRounding.AwayFromZero) : p.JieSuanLiang));
					}
					dataGridViewCell.Value = group.Sum(selector);
					int rowIndex = RowIndex;
					RowIndex = rowIndex + 1;
				});
				this.headerText = ShowWords.ReplaceText("Product") + " " + this.cmbReportType.Text;
			}
			else
			{
				bool checked2 = this.rdoUser.Checked;
				if (checked2)
				{
					int RowIndex = 0;
					this.dgvData.Rows.Clear();
					Func<ModT_ticket, decimal> <>9__11;
					(from x in listRequire
					group x by new
					{
						x.InvCode,
						x.BusinessType
					} into x
					orderby x.Key.InvCode
					select x).ToList().ForEach(delegate(group)
					{
						(from o in @group
						group o by o.ClientPart).ToList<IGrouping<string, ModT_ticket>>().ForEach(delegate(IGrouping<string, ModT_ticket> o)
						{
							int num2 = 0;
							this.dgvData.Rows.Add();
							this.dgvData.Rows[RowIndex].Cells[num2++].Value = o.Key;
							this.dgvData.Rows[RowIndex].Cells[num2++].Value = group.Key.InvCode;
							this.dgvData.Rows[RowIndex].Cells[num2++].Value = group.First<ModT_ticket>().ProductName;
							this.dgvData.Rows[RowIndex].Cells[num2++].Value = ShowWords.ReplaceText(EnumHelper.GetDescription<BusinessType>((BusinessType)group.Key.BusinessType));
							this.dgvData.Rows[RowIndex].Cells[num2++].Value = o.Count<ModT_ticket>();
							this.dgvData.Rows[RowIndex].Cells[num2++].Value = o.Sum((ModT_ticket p) => p.DifferWeight);
							DataGridViewCell dataGridViewCell = this.dgvData.Rows[RowIndex].Cells[num2++];
							Func<ModT_ticket, decimal> selector;
							if ((selector = <>9__11) == null)
							{
								selector = (<>9__11 = ((ModT_ticket p) => (jslDecimal > -1) ? Math.Round(p.JieSuanLiang, jslDecimal, MidpointRounding.AwayFromZero) : p.JieSuanLiang));
							}
							dataGridViewCell.Value = o.Sum(selector);
							int rowIndex = RowIndex;
							RowIndex = rowIndex + 1;
						});
					});
					this.headerText = ShowWords.ReplaceText("Customer") + " " + this.cmbReportType.Text;
				}
			}
			this.mSearching = false;
		}

		// Token: 0x060006C7 RID: 1735 RVA: 0x000A6F98 File Offset: 0x000A5198
		private void ShowFormInPanel(Form frm)
		{
			foreach (object obj in this.panelExReport.Controls)
			{
				Control control = (Control)obj;
				bool flag = control is Form;
				if (flag)
				{
					((Form)control).Close();
				}
			}
			this.panelExReport.Controls.Clear();
			frm.FormBorderStyle = FormBorderStyle.None;
			frm.TopLevel = false;
			frm.Size = this.panelExReport.Size;
			frm.Show();
			this.panelExReport.Controls.Add(frm);
		}

		// Token: 0x060006C8 RID: 1736 RVA: 0x000A705C File Offset: 0x000A525C
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

		// Token: 0x060006C9 RID: 1737 RVA: 0x000A7118 File Offset: 0x000A5318
		private void btnExport_Click(object sender, EventArgs e)
		{
			base.ExportExcel(this.dgvData);
		}

		// Token: 0x060006CA RID: 1738 RVA: 0x000A7128 File Offset: 0x000A5328
		private void rdoUser_CheckedChanged(object sender, CheckBoxChangeEventArgs e)
		{
			this.dgvData.Columns.Clear();
			DataGridViewColumn dataGridViewColumn = new DataGridViewCheckBoxColumn();
			dataGridViewColumn = new DataGridViewTextBoxColumn();
			dataGridViewColumn.Name = "UserName";
			dataGridViewColumn.HeaderText = ShowWords.ReplaceText("Customer");
			dataGridViewColumn.Width = 150;
			this.dgvData.Columns.Add(dataGridViewColumn);
			this.AddGgvDataColumns();
			base.SetGridUI(this.dgvData);
			this.lblStatisticsInfo.Text = string.Empty;
			this.dgvData.MultiSelect = true;
		}

		// Token: 0x060006CB RID: 1739 RVA: 0x000A71C0 File Offset: 0x000A53C0
		private void rdoProduct_CheckedChanged(object sender, CheckBoxChangeEventArgs e)
		{
			this.dgvData.Columns.Clear();
			this.AddGgvDataColumns();
			base.SetGridUI(this.dgvData);
			this.lblStatisticsInfo.Text = string.Empty;
			this.dgvData.MultiSelect = true;
		}

		// Token: 0x060006CC RID: 1740 RVA: 0x000A7214 File Offset: 0x000A5414
		private void AddGgvDataColumns()
		{
			DataGridViewColumn dataGridViewColumn = new DataGridViewCheckBoxColumn();
			dataGridViewColumn = new DataGridViewTextBoxColumn();
			dataGridViewColumn.Name = "InvCode";
			dataGridViewColumn.HeaderText = ShowWords.ReplaceText("InvCode");
			dataGridViewColumn.Width = 60;
			this.dgvData.Columns.Add(dataGridViewColumn);
			dataGridViewColumn = new DataGridViewTextBoxColumn();
			dataGridViewColumn.Name = "ProductName";
			dataGridViewColumn.HeaderText = ShowWords.ReplaceText("ProductName");
			dataGridViewColumn.Width = 100;
			this.dgvData.Columns.Add(dataGridViewColumn);
			dataGridViewColumn = new DataGridViewTextBoxColumn();
			dataGridViewColumn.Name = "BusinessType";
			dataGridViewColumn.HeaderText = ShowWords.ReplaceText("BusinessType");
			dataGridViewColumn.Width = 100;
			this.dgvData.Columns.Add(dataGridViewColumn);
			dataGridViewColumn = new DataGridViewTextBoxColumn();
			dataGridViewColumn.Name = "CangCount";
			dataGridViewColumn.HeaderText = ShowWords.ReplaceText("CangShu");
			dataGridViewColumn.Width = 150;
			this.dgvData.Columns.Add(dataGridViewColumn);
			dataGridViewColumn = new DataGridViewTextBoxColumn();
			dataGridViewColumn.Name = "DifferWeight";
			dataGridViewColumn.HeaderText = ShowWords.ReplaceText("DifferWeight(kg)");
			dataGridViewColumn.Width = 100;
			this.dgvData.Columns.Add(dataGridViewColumn);
			dataGridViewColumn = new DataGridViewTextBoxColumn();
			dataGridViewColumn.Name = "JieSuanLiang";
			dataGridViewColumn.HeaderText = ShowWords.ReplaceText("JieSuanLiang(kg)");
			dataGridViewColumn.Width = 100;
			this.dgvData.Columns.Add(dataGridViewColumn);
		}

		// Token: 0x060006CD RID: 1741 RVA: 0x000A73A0 File Offset: 0x000A55A0
		private void dgvData_SelectionChanged(object sender, EventArgs e)
		{
			bool flag = this.dgvData.SelectedRows.Count == 0 || this.mSearching;
			if (!flag)
			{
				int num = 0;
				bool @checked = this.rdoUser.Checked;
				if (@checked)
				{
					num = 1;
				}
				int num2 = 0;
				decimal d = 0m;
				decimal d2 = 0m;
				for (int i = 0; i < this.dgvData.SelectedRows.Count; i++)
				{
					num2 += Convert.ToInt32(this.dgvData.Rows[this.dgvData.SelectedRows[i].Index].Cells[num + 3].Value.ToString());
					d += Convert.ToDecimal(this.dgvData.Rows[this.dgvData.SelectedRows[i].Index].Cells[num + 4].Value.ToString());
					d2 += Convert.ToDecimal(this.dgvData.Rows[this.dgvData.SelectedRows[i].Index].Cells[num + 5].Value.ToString());
				}
				this.lblStatisticsInfo.Text = string.Concat(new string[]
				{
					this.dgvData.Columns[num + 3].HeaderText,
					"：",
					num2.ToString(),
					"；",
					this.dgvData.Columns[num + 4].HeaderText,
					"：",
					d.ToString(),
					"；",
					this.dgvData.Columns[num + 5].HeaderText,
					"：",
					d2.ToString()
				});
			}
		}

		// Token: 0x04000B8B RID: 2955
		private string headerText;

		// Token: 0x04000B8C RID: 2956
		private string time;

		// Token: 0x04000B8D RID: 2957
		private string DayStart;

		// Token: 0x04000B8E RID: 2958
		private bool mSearching = false;
	}
}
