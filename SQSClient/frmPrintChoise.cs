using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Assistant;
using Base;
using DAL.Base.SQSConfig;
using DevComponents.DotNetBar;
using LTDesign;
using Model;
using Model.SQSConfig;

namespace SQSClient
{
	// Token: 0x02000071 RID: 113
	public partial class frmPrintChoise : BaseDialogForm
	{
		// Token: 0x06000620 RID: 1568 RVA: 0x0009917C File Offset: 0x0009737C
		public frmPrintChoise(string text, ModT_ticket modt, List<ModT_ticket> lists)
		{
			this.InitializeComponent();
			this.SetText(this);
			this.Text = text;
			this._selectMod = modt;
			this._listTicket = lists;
		}

		// Token: 0x06000621 RID: 1569 RVA: 0x000991E0 File Offset: 0x000973E0
		private void frmPrintChoise_Load(object sender, EventArgs e)
		{
			this.itemPanelFenCang.Items.Clear();
			for (int i = 0; i < this._listTicket.Count; i++)
			{
				CheckBoxItem checkBoxItem = new CheckBoxItem();
				checkBoxItem.Text = this._listTicket[i].Lisence + ((this._listTicket[i].CoachNum == "") ? "" : ("-" + this._listTicket[i].CoachNum)) + "-" + this._listTicket[i].CangNum.ToString();
				checkBoxItem.Checked = true;
				this.itemPanelFenCang.Items.Add(checkBoxItem);
			}
		}

		// Token: 0x06000622 RID: 1570 RVA: 0x000992BC File Offset: 0x000974BC
		private void btnPrintShow_Click(object sender, EventArgs e)
		{
			this.GetSelects();
			bool flag = new frmPrintShow(this.pri)
			{
				Icon = base.Icon,
				Text = this.btnPrintShow.Text
			}.ShowDialog() == DialogResult.Yes;
			if (flag)
			{
				this.UpdateIsPrintInfo();
			}
		}

		// Token: 0x06000623 RID: 1571 RVA: 0x00099314 File Offset: 0x00097514
		private void btnPrint_Click(object sender, EventArgs e)
		{
			bool flag = base.ShowChoise(Messages.PrintSure, "", "");
			if (flag)
			{
				this.GetSelects();
				this.pri.Print();
				this.UpdateIsPrintInfo();
				base.DialogResult = DialogResult.Yes;
			}
		}

		// Token: 0x06000624 RID: 1572 RVA: 0x00099360 File Offset: 0x00097560
		private void GetSelects()
		{
			int num = -1;
			List<Dictionary<string, object>> list = new List<Dictionary<string, object>>();
			for (int i = 0; i < this.itemPanelFenCang.Items.Count; i++)
			{
				bool @checked = ((CheckBoxItem)this.itemPanelFenCang.Items[i]).Checked;
				if (@checked)
				{
					list.Add(ModelHelper.ReturnDic<ModT_ticket>(this._listTicket[i], ""));
					bool flag = num == -1;
					if (flag)
					{
						num = i;
					}
				}
			}
			bool flag2 = list.Count == 0;
			if (flag2)
			{
				base.ShowMsg(Messages.NoData, "", "");
			}
			bool flag3 = this._listTicket[num].BusinessType == 1;
			string printername;
			string value;
			if (flag3)
			{
				printername = Settings.Instance.LoadPrinter;
				bool flag4 = this._listTicket[num].Status < 2;
				if (flag4)
				{
					value = DalCfg_setting.Instance.GetModel("Item", "LoadNoticeFile").Value;
				}
				else
				{
					value = DalCfg_setting.Instance.GetModel("Item", "LoadStatementFile").Value;
				}
			}
			else
			{
				printername = Settings.Instance.UnloadPrinter;
				bool flag5 = this._listTicket[num].Status < 2;
				if (flag5)
				{
					value = DalCfg_setting.Instance.GetModel("Item", "UnloadNoticeFile").Value;
				}
				else
				{
					value = DalCfg_setting.Instance.GetModel("Item", "UnloadStatementFile").Value;
				}
			}
			this.pri = new MyPrint(value, printername);
			this.pri.ClearDataSource();
			this.pri.AddDataSource("t_ticket", list);
			bool flag6 = this._listTicket[num].Status >= 2;
			if (flag6)
			{
				this.SetPrintTicketIds(list);
			}
		}

		// Token: 0x06000625 RID: 1573 RVA: 0x00099554 File Offset: 0x00097754
		private void SetPrintTicketIds(List<Dictionary<string, object>> DicList)
		{
			this._PrintTicketIds = string.Empty;
			foreach (Dictionary<string, object> dictionary in DicList)
			{
				this._PrintTicketIds = this._PrintTicketIds + dictionary["Id"].ToString() + ",";
			}
			this._PrintTicketIds = this._PrintTicketIds.Trim(new char[]
			{
				','
			});
		}

		// Token: 0x06000626 RID: 1574 RVA: 0x000995F0 File Offset: 0x000977F0
		private void UpdateIsPrintInfo()
		{
			bool flag = this._PrintTicketIds.Length == 0;
			if (!flag)
			{
				string[] array = this._PrintTicketIds.Split(new char[]
				{
					','
				});
				List<string> list = new List<string>();
				List<object> list2 = new List<object>();
				list.Add("Spare1");
				list2.Add(ShowWords.ReplaceText("ReprintInfo"));
				for (int i = 0; i < array.Length; i++)
				{
					DalT_ticket.Instance.Update(list, list2, Convert.ToInt32(array[i]));
				}
			}
		}

		// Token: 0x06000627 RID: 1575 RVA: 0x00099684 File Offset: 0x00097884
		private void NewMyPrint()
		{
			string filename = "";
			string printername = "";
			bool flag = this._selectMod.BusinessType == 1;
			if (flag)
			{
				printername = Settings.Instance.LoadPrinter;
				bool flag2 = this._selectMod.Status <= 1;
				if (flag2)
				{
					filename = DalCfg_setting.Instance.GetModel("Item", "LoadNoticeFile").Value;
				}
				else
				{
					bool flag3 = this._selectMod.Status == 2;
					if (flag3)
					{
						filename = DalCfg_setting.Instance.GetModel("Item", "LoadStatementFile").Value;
					}
				}
			}
			else
			{
				bool flag4 = this._selectMod.BusinessType == 2;
				if (flag4)
				{
					printername = Settings.Instance.UnloadPrinter;
					bool flag5 = this._selectMod.Status <= 1;
					if (flag5)
					{
						filename = DalCfg_setting.Instance.GetModel("Item", "UnloadNoticeFile").Value;
					}
					else
					{
						bool flag6 = this._selectMod.Status == 2;
						if (flag6)
						{
							filename = DalCfg_setting.Instance.GetModel("Item", "UnloadStatementFile").Value;
						}
					}
				}
			}
			this.pri = new MyPrint(filename, printername);
		}

		// Token: 0x06000628 RID: 1576 RVA: 0x000997B8 File Offset: 0x000979B8
		private void frmPrintChoise_FormClosing(object sender, FormClosingEventArgs e)
		{
			bool flag = this.pri != null;
			if (flag)
			{
				this.pri.Close();
			}
		}

		// Token: 0x04000A97 RID: 2711
		private MyPrint pri;

		// Token: 0x04000A98 RID: 2712
		private ModT_ticket _selectMod = new ModT_ticket();

		// Token: 0x04000A99 RID: 2713
		private List<ModT_ticket> _listTicket = new List<ModT_ticket>();

		// Token: 0x04000A9A RID: 2714
		private string _PrintTicketIds = string.Empty;
	}
}
