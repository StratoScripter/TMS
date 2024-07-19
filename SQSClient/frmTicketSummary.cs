using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Assistant;
using Base;
using DAL.Base.SQSConfig;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using DevComponents.DotNetBar.Layout;
using DevComponents.Editors;
using DevComponents.Editors.DateTimeAdv;
using Model;
using Model.SQSConfig;
using SQSClient.Properties;

namespace SQSClient
{
	// Token: 0x0200001B RID: 27
	public partial class frmTicketSummary : BaseDialogForm
	{
		// Token: 0x06000157 RID: 343 RVA: 0x0002A920 File Offset: 0x00028B20
		public frmTicketSummary(string text, BaseForm.FormActtion act, List<ModT_ticket> list, string dir)
		{
			this.InitializeComponent();
			this.SetText(this);
			this.Text = text;
			this._Controls.Clear();
			this._Controls.Add(this.bar);
			this._Controls.Add(this.dgvData);
			base.SetGridUI(this.dgvData);
			this.InitControl();
			this._Act = act;
			this._list = list;
			this._Direct = dir;
		}

		// Token: 0x06000158 RID: 344 RVA: 0x0002A9C8 File Offset: 0x00028BC8
		private void InitControl()
		{
			this.btnSummary.Enabled = false;
			this.dtpStartTime.Format = eDateTimePickerFormat.Custom;
			this.dtpStartTime.CustomFormat = "yyyy-MM-dd";
			this.dtpEndTime.Format = eDateTimePickerFormat.Custom;
			this.dtpEndTime.CustomFormat = "yyyy-MM-dd";
			this.dtpStartTime.Value = DateTime.Now.AddMonths(-1);
			this.dtpEndTime.Value = DateTime.Now;
		}

		// Token: 0x06000159 RID: 345 RVA: 0x0002AA4A File Offset: 0x00028C4A
		private void frmTicketSummary_Load(object sender, EventArgs e)
		{
			this.RunSummary();
		}

		// Token: 0x0600015A RID: 346 RVA: 0x0002AA54 File Offset: 0x00028C54
		private void RunSummary()
		{
			decimal d = 0m;
			decimal d2 = 0m;
			decimal d3 = 0m;
			this.ticketnum = this._list.Count;
			int jslDecimal = Settings.Instance.JieSuanLiangDecimal;
			int index = 1;
			Func<ModT_ticket, decimal> <>9__6;
			this._listnew = (from x in this._list
			group x by new
			{
				x.InvCode,
				x.BusinessType
			} into x
			orderby x.Key.InvCode
			select x).Select(delegate(group)
			{
				frmTicketSummary.TicketSummary ticketSummary = new frmTicketSummary.TicketSummary();
				int index = index;
				index++;
				ticketSummary.Id = index;
				ticketSummary.InvCode = group.Key.InvCode;
				ticketSummary.ProductName = group.First<ModT_ticket>().ProductName;
				ticketSummary.BusinessName = ShowWords.ReplaceText(EnumHelper.GetDescription<BusinessType>((BusinessType)group.Key.BusinessType));
				ticketSummary.TicketCount = group.Count<ModT_ticket>();
				ticketSummary.DifferWeight = group.Sum((ModT_ticket p) => p.DifferWeight);
				Func<ModT_ticket, decimal> selector;
				if ((selector = <>9__6) == null)
				{
					selector = (<>9__6 = ((ModT_ticket p) => (jslDecimal > -1) ? Math.Round(p.JieSuanLiang, jslDecimal, MidpointRounding.AwayFromZero) : p.JieSuanLiang));
				}
				ticketSummary.JieSuanLiang = group.Sum(selector);
				return ticketSummary;
			}).ToList<frmTicketSummary.TicketSummary>();
			this.dgvData.DataSource = this._listnew;
			foreach (ModT_ticket modT_ticket in this._list)
			{
				d += modT_ticket.DifferWeight;
				d3 = ((jslDecimal > -1) ? Math.Round(modT_ticket.JieSuanLiang, jslDecimal, MidpointRounding.AwayFromZero) : modT_ticket.JieSuanLiang);
				d2 += d3;
			}
			this.txtOrders.Text = this.ticketnum.ToString();
			this.txtDifferWeight.Text = d.ToString();
			this.txtJieSuanLiang.Text = d2.ToString();
			string invInfo = string.Empty;
			(from x in this._listnew
			group x by x.InvCode).ToList<IGrouping<string, frmTicketSummary.TicketSummary>>().ForEach(delegate(IGrouping<string, frmTicketSummary.TicketSummary> t)
			{
				bool flag = t.Count<frmTicketSummary.TicketSummary>() > 1;
				if (flag)
				{
					invInfo = string.Concat(new string[]
					{
						invInfo,
						t.First<frmTicketSummary.TicketSummary>().ProductName,
						"(",
						t.Key,
						");"
					});
				}
			});
			this.rtbRemark.Text = invInfo.Trim(new char[]
			{
				';'
			}) + ShowWords.ReplaceText("ConfirmBusinessType");
		}

		// Token: 0x0600015B RID: 347 RVA: 0x0002AC60 File Offset: 0x00028E60
		private void btnExport_Click(object sender, EventArgs e)
		{
			base.ExportExcel(this.dgvData);
		}

		// Token: 0x0600015C RID: 348 RVA: 0x0002AC70 File Offset: 0x00028E70
		private void chkSummaryUsed_CheckedChanged(object sender, EventArgs e)
		{
			this.btnSummary.Enabled = this.chkSummaryUsed.Checked;
		}

		// Token: 0x0600015D RID: 349 RVA: 0x0002AC8C File Offset: 0x00028E8C
		private void btnSummary_Click(object sender, EventArgs e)
		{
			DateTime value = this.dtpStartTime.Value;
			DateTime value2 = this.dtpEndTime.Value;
			string keyName = "JieSuanTime";
			List<string> list = new List<string>();
			list.Add(this.GetQueryField(value, value2, keyName));
			list.Add("State > 0");
			this._list = DalT_ticket.Instance.GetListRequire(list, new List<string>
			{
				"Id desc"
			}, null);
			this.RunSummary();
		}

		// Token: 0x0600015E RID: 350 RVA: 0x0002AD04 File Offset: 0x00028F04
		private string GetQueryField(DateTime dtStart, DateTime dtEnd, string keyName)
		{
			string text = string.Empty;
			text = string.Concat(new string[]
			{
				"((",
				keyName,
				" >= '",
				dtStart.ToString("yyyy-MM-dd HH:mm:ss"),
				"' and ",
				keyName,
				" <='",
				dtEnd.ToString("yyyy-MM-dd HH:mm:ss"),
				"') or "
			});
			return string.Concat(new string[]
			{
				text,
				"(",
				keyName,
				" >= '",
				dtStart.ToString("yyyy/M/d H:m:s"),
				"' and ",
				keyName,
				" <='",
				dtEnd.ToString("yyyy/M/d H:m:s"),
				"'))"
			});
		}

		// Token: 0x04000271 RID: 625
		private List<ModT_ticket> _list = null;

		// Token: 0x04000272 RID: 626
		private List<frmTicketSummary.TicketSummary> _listnew = new List<frmTicketSummary.TicketSummary>();

		// Token: 0x04000273 RID: 627
		private int ticketnum = 0;

		// Token: 0x020000BD RID: 189
		public class TicketSummary
		{
			// Token: 0x170000AE RID: 174
			// (get) Token: 0x060009C3 RID: 2499 RVA: 0x000DEFA1 File Offset: 0x000DD1A1
			// (set) Token: 0x060009C4 RID: 2500 RVA: 0x000DEFA9 File Offset: 0x000DD1A9
			public int Id { get; set; }

			// Token: 0x170000AF RID: 175
			// (get) Token: 0x060009C5 RID: 2501 RVA: 0x000DEFB2 File Offset: 0x000DD1B2
			// (set) Token: 0x060009C6 RID: 2502 RVA: 0x000DEFBA File Offset: 0x000DD1BA
			public string InvCode { get; set; }

			// Token: 0x170000B0 RID: 176
			// (get) Token: 0x060009C7 RID: 2503 RVA: 0x000DEFC3 File Offset: 0x000DD1C3
			// (set) Token: 0x060009C8 RID: 2504 RVA: 0x000DEFCB File Offset: 0x000DD1CB
			public string ProductName { get; set; }

			// Token: 0x170000B1 RID: 177
			// (get) Token: 0x060009C9 RID: 2505 RVA: 0x000DEFD4 File Offset: 0x000DD1D4
			// (set) Token: 0x060009CA RID: 2506 RVA: 0x000DEFDC File Offset: 0x000DD1DC
			public string BusinessName { get; set; }

			// Token: 0x170000B2 RID: 178
			// (get) Token: 0x060009CB RID: 2507 RVA: 0x000DEFE5 File Offset: 0x000DD1E5
			// (set) Token: 0x060009CC RID: 2508 RVA: 0x000DEFED File Offset: 0x000DD1ED
			public int TicketCount { get; set; }

			// Token: 0x170000B3 RID: 179
			// (get) Token: 0x060009CD RID: 2509 RVA: 0x000DEFF6 File Offset: 0x000DD1F6
			// (set) Token: 0x060009CE RID: 2510 RVA: 0x000DEFFE File Offset: 0x000DD1FE
			public decimal DifferWeight { get; set; }

			// Token: 0x170000B4 RID: 180
			// (get) Token: 0x060009CF RID: 2511 RVA: 0x000DF007 File Offset: 0x000DD207
			// (set) Token: 0x060009D0 RID: 2512 RVA: 0x000DF00F File Offset: 0x000DD20F
			public decimal JieSuanLiang { get; set; }
		}
	}
}
