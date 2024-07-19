using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Drawing;
using System.Windows.Forms;
using Assistant;
using Base;
using DAL.Base.SQSConfig;
using DAL.SQLServer.SQSConfig;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using ICHandle;
using InterHandle;
using Model;
using Model.SQSConfig;
using Newtonsoft.Json;
using SQSClient.Properties;

namespace SQSClient
{
	// Token: 0x02000044 RID: 68
	public partial class frmTakeTicket : BaseDialogForm
	{
		// Token: 0x06000300 RID: 768 RVA: 0x0004C404 File Offset: 0x0004A604
		public frmTakeTicket()
		{
			this.InitializeComponent();
			this.SetText(this);
			this._Controls.Clear();
			this._Controls.Add(this.bar);
		}

		// Token: 0x06000301 RID: 769 RVA: 0x0004C463 File Offset: 0x0004A663
		private void frmTakeTicket_Load(object sender, EventArgs e)
		{
			base.InitBurron();
			this.InitPara();
		}

		// Token: 0x06000302 RID: 770 RVA: 0x0004C474 File Offset: 0x0004A674
		private void InitPara()
		{
			try
			{
				IManager.AddressCode = ConfigurationManager.AppSettings["AddressCode"];
				bool flag = bool.Parse(ConfigurationManager.AppSettings["ProcessControl"]);
				if (flag)
				{
					IManager.TakeCardCode = ConfigurationManager.AppSettings["TakeCardCode"];
					IManager.SettleCode = ConfigurationManager.AppSettings["SettleCode"];
				}
				IManager.SOAPHandleTakeCard.URL = ConfigurationManager.AppSettings["TakeCardUrl"];
			}
			catch
			{
				base.Close();
			}
		}

		// Token: 0x06000303 RID: 771 RVA: 0x0004C514 File Offset: 0x0004A714
		private void btnAdd_Click(object sender, EventArgs e)
		{
			bool flag = this._SelectCheCangNum.Count == 0;
			if (flag)
			{
				base.ShowMsg(ShowWords.ReplaceText("NoSelectionRecord"), "", "");
			}
			else
			{
				bool flag2 = this.txtCardNum.Text.Trim().Length != 8;
				if (flag2)
				{
					base.ShowMsg(ShowWords.ReplaceText("ICNull"), "", "");
				}
				else
				{
					bool flag3 = !this.CheckICCard();
					if (!flag3)
					{
						bool flag4 = !this.CheckLisence();
						if (!flag4)
						{
							this.TakeCard();
						}
					}
				}
			}
		}

		// Token: 0x06000304 RID: 772 RVA: 0x0004C5B6 File Offset: 0x0004A7B6
		private void btnSearch_Click(object sender, EventArgs e)
		{
			this.LoadData(this.txtIdCardNo.Text.Trim());
		}

		// Token: 0x06000305 RID: 773 RVA: 0x0004C5D0 File Offset: 0x0004A7D0
		private void btnReadCard_Click(object sender, EventArgs e)
		{
			try
			{
				this.txtCardNum.Text = ICTicket.ReadCardNum();
			}
			catch
			{
				base.ShowMsg(Messages.ReadCardFalse, "", "");
			}
		}

		// Token: 0x06000306 RID: 774 RVA: 0x0004C620 File Offset: 0x0004A820
		private void txtName_KeyPress(object sender, KeyPressEventArgs e)
		{
			bool flag = e.KeyChar == '\r';
			if (flag)
			{
				this.LoadData(this.txtIdCardNo.Text.Trim());
			}
		}

		// Token: 0x06000307 RID: 775 RVA: 0x0004C658 File Offset: 0x0004A858
		protected override void LoadData(string IdCardNo)
		{
			Dictionary<string, object> dictionary = new Dictionary<string, object>();
			dictionary.Add("idcard", IdCardNo);
			dictionary.Add("addrcode", IManager.AddressCode);
			dictionary.Add("funcode", IManager.TakeCardCode);
			IManager.SOAPHandleTakeCard.MethodName = "GetTicketsNoCard";
			IManager.SOAPHandleTakeCard.Paras = dictionary;
			Dictionary<string, object> dictionary2 = IManager.SOAPHandleTakeCard.Activity() as Dictionary<string, object>;
			bool flag = dictionary2["Code"].ToString() != "1";
			if (flag)
			{
				base.ShowMsg(dictionary2["Info"].ToString(), "", "");
			}
			else
			{
				Dictionary<string, object> dic = dictionary2["Data"].ChangeD();
				object obj = dic.First();
				bool flag2 = obj == null;
				if (flag2)
				{
					base.ShowMsg(ShowWords.ReplaceText("TakeTicketNull"), "", "");
					base.DialogResult = DialogResult.Cancel;
				}
				else
				{
					List<object> list = obj.ChangeDs();
					this.panelBody.Controls.Clear();
					foreach (object obj2 in list)
					{
						Dictionary<string, object> model = (Dictionary<string, object>)obj2;
						ATicketControl aticketControl = new ATicketControl(model);
						aticketControl.TicketCheckedChangedEvent += this.ticket_TicketCheckedChangedEvent;
						this.panelBody.Controls.Add(aticketControl);
						aticketControl.Checked = true;
					}
				}
			}
		}

		// Token: 0x06000308 RID: 776 RVA: 0x0004C7F4 File Offset: 0x0004A9F4
		private void ticket_TicketCheckedChangedEvent(object sender, EventArgs e)
		{
			ATicketControl aticketControl = sender as ATicketControl;
			foreach (object obj in this.panelBody.Controls)
			{
				ATicketControl aticketControl2 = (ATicketControl)obj;
				bool flag = aticketControl2.Model["BatchNum"] == aticketControl.Model["BatchNum"];
				if (flag)
				{
					aticketControl2.Checked = aticketControl.Checked;
				}
			}
			bool @checked = aticketControl.Checked;
			if (@checked)
			{
				bool flag2 = this._SelectCheCangNum.Contains(aticketControl.CheCangNum);
				if (flag2)
				{
					base.ShowMsg(ShowWords.ReplaceText("CheCangNumRepeat"), "", "");
					this._SelectCheCangNum.Add(aticketControl.CheCangNum);
					aticketControl.Checked = false;
				}
				else
				{
					this._SelectCheCangNum.Add(aticketControl.CheCangNum);
				}
			}
			else
			{
				this._SelectCheCangNum.Remove(aticketControl.CheCangNum);
			}
		}

		// Token: 0x06000309 RID: 777 RVA: 0x0004C918 File Offset: 0x0004AB18
		protected bool CheckICCard()
		{
			List<string> list = new List<string>();
			list.Add("CardNum = '" + this.txtCardNum.Text.Trim() + "'");
			bool flag = bool.Parse(DAL.Base.SQSConfig.DalCfg_setting.Instance.GetModel("Item", "ICPaidReuse").Value);
			if (flag)
			{
				list.Add("State < '" + 1.ToString() + "'");
			}
			else
			{
				list.Add("Status < '" + 2.ToString() + "'");
			}
			List<ModT_ticket> listRequire = DAL.Base.SQSConfig.DalT_ticket.Instance.GetListRequire(list, null, null);
			bool flag2 = listRequire.Count > 0;
			bool result;
			if (flag2)
			{
				base.ShowMsg(Messages.ICUsed, "", "");
				result = false;
			}
			else
			{
				result = true;
			}
			return result;
		}

		// Token: 0x0600030A RID: 778 RVA: 0x0004C9F8 File Offset: 0x0004ABF8
		protected bool CheckLisence()
		{
			string lisence = this.GetLisence();
			bool flag = lisence.Length == 0;
			bool result;
			if (flag)
			{
				result = false;
			}
			else
			{
				List<string> list = new List<string>();
				list.Add("Lisence = '" + lisence + "'");
				list.Add("StepProcess != 'end'");
				List<ModT_ticket> listRequire = DAL.Base.SQSConfig.DalT_ticket.Instance.GetListRequire(list, null, null);
				bool flag2 = listRequire.Count > 0;
				if (flag2)
				{
					bool flag3 = !base.ShowChoise(string.Format(ShowWords.ReplaceText("LisenceInFactorySure"), lisence), "", "");
					if (flag3)
					{
						return false;
					}
				}
				result = true;
			}
			return result;
		}

		// Token: 0x0600030B RID: 779 RVA: 0x0004CAA0 File Offset: 0x0004ACA0
		protected string GetLisence()
		{
			foreach (object obj in this.panelBody.Controls)
			{
				ATicketControl aticketControl = (ATicketControl)obj;
				bool @checked = aticketControl.Checked;
				if (@checked)
				{
					return aticketControl.Model["Lisence"].ToString().Trim();
				}
			}
			return string.Empty;
		}

		// Token: 0x0600030C RID: 780 RVA: 0x0004CB38 File Offset: 0x0004AD38
		protected bool TakeCard()
		{
			try
			{
				string text = this.txtCardNum.Text.Trim();
				bool flag = text != null && text.Length == 8;
				if (!flag)
				{
					return false;
				}
				List<Dictionary<string, object>> list = new List<Dictionary<string, object>>();
				List<Dictionary<string, object>> list2 = new List<Dictionary<string, object>>();
				foreach (object obj in this.panelBody.Controls)
				{
					ATicketControl aticketControl = (ATicketControl)obj;
					bool @checked = aticketControl.Checked;
					if (@checked)
					{
						aticketControl.Model["CardNum"] = text;
						aticketControl.Model["IsCard"] = true;
						aticketControl.Model["TakeCardTime"] = DateTime.Now;
						list.Add(aticketControl.Model);
						list2.Add(ModelHelper.ReturnDic(aticketControl.Model, "t_ticket."));
					}
				}
				string value = JsonConvert.SerializeObject(list);
				Dictionary<string, object> dictionary = new Dictionary<string, object>();
				dictionary.Add("jsondata", value);
				dictionary.Add("iccard", text);
				dictionary.Add("time", DateTime.Now);
				IManager.SOAPHandleTakeCard.MethodName = "BoundICCard";
				IManager.SOAPHandleTakeCard.Paras = dictionary;
				object obj2 = IManager.SOAPHandleTakeCard.Activity();
				bool flag2 = obj2 == null;
				if (flag2)
				{
					base.ShowMsg(ShowWords.ReplaceText("TakeICCardOutTime"), "", "");
					return false;
				}
				Dictionary<string, object> dictionary2 = obj2.ChangeD();
				bool flag3 = dictionary2["Code"].ToString() != "1";
				if (flag3)
				{
					base.ShowMsg(dictionary2["Info"].ToString(), "", "");
					return false;
				}
			}
			catch (Exception ex)
			{
			}
			base.DialogResult = DialogResult.Yes;
			return true;
		}

		// Token: 0x040004CE RID: 1230
		private List<string> _SelectCheCangNum = new List<string>();

		// Token: 0x040004CF RID: 1231
		private DAL.SQLServer.SQSConfig.DalT_client _Dal = DAL.Base.SQSConfig.DalT_client.Instance;
	}
}
