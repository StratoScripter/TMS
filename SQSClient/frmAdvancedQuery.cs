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
using DevComponents.DotNetBar.Layout;
using DevComponents.Editors;
using DevComponents.Editors.DateTimeAdv;
using Model.SQSConfig;
using SQSClient.Properties;

namespace SQSClient
{
	// Token: 0x0200000D RID: 13
	public partial class frmAdvancedQuery : BaseDialogForm
	{
		// Token: 0x06000063 RID: 99 RVA: 0x00003E64 File Offset: 0x00002064
		public frmAdvancedQuery(string text)
		{
			this.InitializeComponent();
			this.SetText(this);
			this.Text = text;
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00003EB8 File Offset: 0x000020B8
		private void frmAdvancedQuery_Load(object sender, EventArgs e)
		{
			this.InitControl();
			this.LoadData();
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00003ECC File Offset: 0x000020CC
		private void InitControl()
		{
			DateTime value = Convert.ToDateTime(DateTime.Now.AddDays(-1.0).ToString("yyyy-MM-dd 08:00:00"));
			this.dtpStartZhiDanTime.Value = value;
			this.dtpEndZhiDanTime.Value = value.AddDays(1.0);
			this.dtpStartFirstTime.Value = value;
			this.dtpEndFirstTime.Value = value.AddDays(1.0);
			this.dtpStartSecondTime.Value = value;
			this.dtpEndSecondTime.Value = value.AddDays(1.0);
			this.dtpStartEnterTime.Value = value;
			this.dtpEndEnterTime.Value = value.AddDays(1.0);
			this.dtpStartLeaveTime.Value = value;
			this.dtpEndLeaveTime.Value = value.AddDays(1.0);
			this.dtpStartJieSuanTime.Value = value;
			this.dtpEndJieSuanTime.Value = value.AddDays(1.0);
			this.dtpStartTakeCardTime.Value = value;
			this.dtpEndTakeCardTime.Value = value.AddDays(1.0);
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00004024 File Offset: 0x00002224
		protected override void LoadData()
		{
			this.lbxMenu.Items.Clear();
			this.mListstep = DAL.Base.SQSConfig.DalSrm_step.Instance.GetAllList();
			foreach (ModSrm_step modSrm_step in this.mListstep)
			{
				ListBoxItem listBoxItem = new ListBoxItem();
				listBoxItem.Name = modSrm_step.StepCode;
				listBoxItem.Text = modSrm_step.StepName;
				this.lbxMenu.Items.Add(listBoxItem);
			}
			ListBoxItem listBoxItem2 = new ListBoxItem();
			listBoxItem2.Name = "end";
			listBoxItem2.Text = ShowWords.ReplaceText("Ending");
			this.lbxMenu.Items.Add(listBoxItem2);
			this.lbxLoader.Items.Clear();
			List<string> loaderList = DAL.Base.SQSConfig.DalT_ticket.Instance.GetLoaderList("Loader");
			foreach (string text in loaderList)
			{
				ListBoxItem listBoxItem3 = new ListBoxItem();
				listBoxItem3.Name = text;
				listBoxItem3.Text = text;
				this.lbxLoader.Items.Add(listBoxItem3);
			}
			this.lbxInvClass.Items.Clear();
			List<ModCfg_pdasetting> list = DAL.Base.SQSConfig.DalCfg_pdasetting.Instance.GetList("Type", "InvClass");
			foreach (ModCfg_pdasetting modCfg_pdasetting in list)
			{
				ListBoxItem listBoxItem4 = new ListBoxItem();
				listBoxItem4.Name = modCfg_pdasetting.Name;
				listBoxItem4.Text = modCfg_pdasetting.Remark;
				this.lbxInvClass.Items.Add(listBoxItem4);
			}
			this.lbxTruckSafeName.Items.Clear();
			List<string> loaderList2 = DAL.Base.SQSConfig.DalT_ticket.Instance.GetLoaderList("TruckSafeName");
			foreach (string text2 in loaderList2)
			{
				ListBoxItem listBoxItem5 = new ListBoxItem();
				listBoxItem5.Name = text2;
				listBoxItem5.Text = text2;
				this.lbxTruckSafeName.Items.Add(listBoxItem5);
			}
		}

		// Token: 0x06000067 RID: 103 RVA: 0x000042B8 File Offset: 0x000024B8
		private void btnQuery_Click(object sender, EventArgs e)
		{
			this.mFormulas.Clear();
			DateTime dtStart = default(DateTime);
			DateTime dtEnd = default(DateTime);
			string keyName = string.Empty;
			bool @checked = this.cbxZhiDanTime.Checked;
			if (@checked)
			{
				dtStart = this.dtpStartZhiDanTime.Value;
				dtEnd = this.dtpEndZhiDanTime.Value;
				keyName = "ZhiDanTime";
				this.mFormulas.Add(this.GetQueryField(dtStart, dtEnd, keyName));
			}
			bool checked2 = this.cbxOneWeighed.Checked;
			if (checked2)
			{
				dtStart = this.dtpStartFirstTime.Value;
				dtEnd = this.dtpEndFirstTime.Value;
				keyName = "FirstTime";
				this.mFormulas.Add(this.GetQueryField(dtStart, dtEnd, keyName));
			}
			bool checked3 = this.cbxTwoWeighed.Checked;
			if (checked3)
			{
				dtStart = this.dtpStartSecondTime.Value;
				dtEnd = this.dtpEndSecondTime.Value;
				keyName = "SecondTime";
				this.mFormulas.Add(this.GetQueryField(dtStart, dtEnd, keyName));
			}
			bool checked4 = this.cbxEnterTime.Checked;
			if (checked4)
			{
				dtStart = this.dtpStartEnterTime.Value;
				dtEnd = this.dtpEndEnterTime.Value;
				keyName = "EnterTime";
				this.mFormulas.Add(this.GetQueryField(dtStart, dtEnd, keyName));
			}
			bool checked5 = this.cbxLeaveTime.Checked;
			if (checked5)
			{
				dtStart = this.dtpStartLeaveTime.Value;
				dtEnd = this.dtpEndLeaveTime.Value;
				keyName = "LeaveTime";
				this.mFormulas.Add(this.GetQueryField(dtStart, dtEnd, keyName));
			}
			bool checked6 = this.cbxJieSuanTime.Checked;
			if (checked6)
			{
				dtStart = this.dtpStartJieSuanTime.Value;
				dtEnd = this.dtpEndJieSuanTime.Value;
				keyName = "JieSuanTime";
				this.mFormulas.Add(this.GetQueryField(dtStart, dtEnd, keyName));
			}
			bool checked7 = this.cbxTakeCardTime.Checked;
			if (checked7)
			{
				dtStart = this.dtpStartTakeCardTime.Value;
				dtEnd = this.dtpEndTakeCardTime.Value;
				keyName = "TakeCardTime";
				this.mFormulas.Add(this.GetQueryField(dtStart, dtEnd, keyName));
			}
			bool checked8 = this.cbxProductInfo.Checked;
			if (checked8)
			{
				this.mFormulas.Add(string.Concat(new string[]
				{
					"((InvCode like '%",
					this.tbxProductInfo.Text.Trim(),
					"%') or (ProductName like '%",
					this.tbxProductInfo.Text.Trim(),
					"%'))"
				}));
			}
			bool checked9 = this.cbxSpecsDescribe.Checked;
			if (checked9)
			{
				this.mFormulas.Add("(SpecsDescribe like '%" + this.tbxSpecsDescribe.Text.Trim() + "%')");
			}
			bool checked10 = this.cbxIDCard.Checked;
			if (checked10)
			{
				this.mFormulas.Add("(DriverID like '%" + this.tbxIDCard.Text.Trim() + "%')");
			}
			bool checked11 = this.cbxPersonName.Checked;
			if (checked11)
			{
				this.mFormulas.Add("(DriverName like '%" + this.cbxPersonName.Text.Trim() + "%')");
			}
			bool checked12 = this.cbxSettleNoReturn.Checked;
			if (checked12)
			{
				this.mFormulas.Add("(Status > 0 and DataReturn = 0)");
			}
			bool checked13 = this.cbxClientpart.Checked;
			if (checked13)
			{
				this.mFormulas.Add("Clientpart like '%" + this.tbxClientpart.Text.Trim() + "%'");
			}
			bool checked14 = this.cbxStep.Checked;
			if (checked14)
			{
				string text = "";
				foreach (ListBoxItem listBoxItem in this.lbxMenu.SelectedItems)
				{
					text = text + "'" + listBoxItem.Name + "',";
				}
				text = text.TrimEnd(new char[]
				{
					','
				});
				bool flag = text.Length > 0;
				if (flag)
				{
					this.mFormulas.Add("StepProcess in(" + text + ")");
				}
			}
			bool checked15 = this.cbxLoader.Checked;
			if (checked15)
			{
				string text2 = "";
				foreach (ListBoxItem listBoxItem2 in this.lbxLoader.SelectedItems)
				{
					text2 = text2 + "'" + listBoxItem2.Name + "',";
				}
				text2 = text2.TrimEnd(new char[]
				{
					','
				});
				bool flag2 = text2.Length > 0;
				if (flag2)
				{
					this.mFormulas.Add(string.Concat(new string[]
					{
						"(Loader in (",
						text2,
						") or Loader2 in (",
						text2,
						"))"
					}));
				}
			}
			bool checked16 = this.cbxInvClass.Checked;
			if (checked16)
			{
				string text3 = "";
				bool flag3 = this.lbxInvClass.SelectedItems.Count > 0;
				if (flag3)
				{
					text3 = "1 <> 1";
				}
				foreach (ListBoxItem listBoxItem3 in this.lbxInvClass.SelectedItems)
				{
					text3 = text3 + " or InvCode like '" + listBoxItem3.Name + "%'";
				}
				bool flag4 = text3.Length > 0;
				if (flag4)
				{
					this.mFormulas.Add("(" + text3 + ")");
				}
			}
			bool checked17 = this.cbxTruckSafeName.Checked;
			if (checked17)
			{
				string text4 = "";
				foreach (ListBoxItem listBoxItem4 in this.lbxTruckSafeName.SelectedItems)
				{
					text4 = text4 + "'" + listBoxItem4.Name + "',";
				}
				text4 = text4.TrimEnd(new char[]
				{
					','
				});
				bool flag5 = text4.Length > 0;
				if (flag5)
				{
					this.mFormulas.Add("TruckSafeName in (" + text4 + ")");
				}
			}
			base.DialogResult = DialogResult.Yes;
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00004984 File Offset: 0x00002B84
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

		// Token: 0x06000069 RID: 105 RVA: 0x00003040 File Offset: 0x00001240
		private void lbxMenu_ItemCheck(object sender, ListBoxAdvItemCheckEventArgs e)
		{
		}

		// Token: 0x04000022 RID: 34
		public List<string> mFormulas = new List<string>();

		// Token: 0x04000023 RID: 35
		private ModCfg_pc _mod = new ModCfg_pc();

		// Token: 0x04000024 RID: 36
		private DAL.SQLServer.SQSConfig.DalCfg_pc _Dal = DAL.Base.SQSConfig.DalCfg_pc.Instance;

		// Token: 0x04000025 RID: 37
		private List<ModSrm_step> mListstep;

		// Token: 0x04000026 RID: 38
		private List<ModSrm_step> mListChoose;
	}
}
