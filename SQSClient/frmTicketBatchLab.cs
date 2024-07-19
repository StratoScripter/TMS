using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Speech.Synthesis;
using System.Windows.Forms;
using Assistant;
using Base;
using DAL.Base.SQSConfig;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using DevComponents.Editors;
using Model;
using Model.SQSConfig;
using SQSClient.Properties;

namespace SQSClient
{
	// Token: 0x02000069 RID: 105
	public partial class frmTicketBatchLab : BaseDialogForm
	{
		// Token: 0x06000545 RID: 1349 RVA: 0x000856C0 File Offset: 0x000838C0
		public frmTicketBatchLab()
		{
			this.InitializeComponent();
			this.SetText(this);
			this._Controls.Clear();
			this._Controls.Add(this.bar);
			this._Controls.Add(this.dgvData);
			this._Controls.Add(this.dgvDataPlan);
		}

		// Token: 0x06000546 RID: 1350 RVA: 0x0008574A File Offset: 0x0008394A
		private void frmTicketBatchLab_Load(object sender, EventArgs e)
		{
			BaseDialogForm._operateArgs.Category = this.Text;
			base.InitBurron();
			this.InitControl();
			this.timer.Start();
		}

		// Token: 0x06000547 RID: 1351 RVA: 0x00003040 File Offset: 0x00001240
		private void InitControl()
		{
		}

		// Token: 0x06000548 RID: 1352 RVA: 0x00085778 File Offset: 0x00083978
		private void timer_Tick(object sender, EventArgs e)
		{
			DalT_ticketbatch.Instance.UpdateLoadingLab();
			DalT_ticketbatch.Instance.UpdateUnLoadingLab();
			this.UpdatedgvData();
			this.UpdatedgvDataPlan();
			bool flag = false;
			bool loadLabRemind = DalT_ticketbatch.Instance.GetLoadLabRemind(ref flag);
			if (loadLabRemind)
			{
				this.labMessage.Text = "";
				bool flag2 = flag;
				if (flag2)
				{
					string text = ShowWords.ReplaceText(Messages.LabRemind);
					LabelItem labelItem = this.labMessage;
					labelItem.Text += text;
					this.SpVoice.SpeakAsync(text);
				}
			}
			bool unLoadLabRemind = DalT_ticketbatch.Instance.GetUnLoadLabRemind(ref flag);
			if (unLoadLabRemind)
			{
				this.labMessage.Text = "";
				bool flag3 = flag;
				if (flag3)
				{
					string text2 = ShowWords.ReplaceText(Messages.SampleRemind);
					LabelItem labelItem2 = this.labMessage;
					labelItem2.Text += text2;
					this.SpVoice.SpeakAsync(text2);
				}
			}
			this.timer.Interval = 7000;
		}

		// Token: 0x06000549 RID: 1353 RVA: 0x00085878 File Offset: 0x00083A78
		private void UpdatedgvData()
		{
			List<string> list = new List<string>();
			list.Add("batchLabStatus >= " + 1.ToString());
			list.Add("batchLabStatus < " + 5.ToString());
			List<ViewT_ticketbatch> listViewBatch = DalT_ticketbatch.Instance.GetListViewBatch(list);
			this.dgvData.Rows.Clear();
			foreach (ViewT_ticketbatch viewT_ticketbatch in listViewBatch)
			{
				object[] array = new object[this.dgvData.ColumnCount];
				int num = 0;
				array[num++] = viewT_ticketbatch.Id;
				array[num++] = viewT_ticketbatch.DanHao;
				array[num++] = viewT_ticketbatch.ContractNum;
				array[num++] = ShowWords.ReplaceText(EnumHelper.GetDescription<BusinessType>((BusinessType)viewT_ticketbatch.BusinessType));
				array[num++] = viewT_ticketbatch.ClientPart;
				array[num++] = viewT_ticketbatch.Lisence;
				array[num++] = viewT_ticketbatch.UnitName;
				array[num++] = viewT_ticketbatch.ProductName;
				array[num++] = viewT_ticketbatch.JiHuaLiang;
				array[num++] = viewT_ticketbatch.ShiJiLiang;
				array[num++] = viewT_ticketbatch.FirstWeight;
				array[num++] = viewT_ticketbatch.SecondWeight;
				array[num++] = viewT_ticketbatch.DifferWeight;
				array[num++] = viewT_ticketbatch.DanWei;
				array[num++] = ShowWords.ReplaceText(EnumHelper.GetDescription<TicketStatus>((TicketStatus)viewT_ticketbatch.Status));
				array[num++] = viewT_ticketbatch.BatchCode;
				array[num++] = viewT_ticketbatch.QuantityBatch;
				array[num++] = ShowWords.ReplaceText(((LabStatus)viewT_ticketbatch.BatchLabStatus).ToString());
				array[num++] = ShowWords.ReplaceText(((CheckResult)viewT_ticketbatch.BatchLabResult).ToString());
				array[num++] = viewT_ticketbatch.BatchLabMan;
				array[num++] = viewT_ticketbatch.BatchLabTime;
				array[num++] = viewT_ticketbatch.BatchLabCount;
				array[num++] = viewT_ticketbatch.ZhiDanRen;
				array[num++] = viewT_ticketbatch.ZhiDanTime.ToString("yyyy-MM-dd HH:mm:ss");
				array[num++] = viewT_ticketbatch.Remark;
				this.dgvData.Rows.Add(array);
			}
			this.gPanelToSample.Text = ShowWords.ReplaceText("ToSample") + "(" + this.dgvData.RowCount.ToString() + ")";
			bool flag = this.dgvData.Rows.Count > 0;
			if (flag)
			{
				this.mSelectIndex = ((this.mSelectIndex > this.dgvData.Rows.Count - 1) ? 0 : this.mSelectIndex);
				this.dgvData.Rows[this.mSelectIndex].Selected = true;
				this.GetCurrentItem(this.mSelectIndex);
			}
		}

		// Token: 0x0600054A RID: 1354 RVA: 0x00085C18 File Offset: 0x00083E18
		private void UpdatedgvDataPlan()
		{
			List<string> list = new List<string>();
			list.Add("BatchIsLab='true'");
			list.Add("BatchLabStatus='0'");
			list.Add("State=0");
			List<ViewT_ticketbatch> listViewBatch = DalT_ticketbatch.Instance.GetListViewBatch(list);
			this.dgvDataPlan.Rows.Clear();
			foreach (ViewT_ticketbatch viewT_ticketbatch in listViewBatch)
			{
				object[] array = new object[this.dgvDataPlan.ColumnCount];
				int num = 0;
				array[num++] = viewT_ticketbatch.Id;
				array[num++] = viewT_ticketbatch.DanHao;
				array[num++] = viewT_ticketbatch.ContractNum;
				array[num++] = ShowWords.ReplaceText(EnumHelper.GetDescription<BusinessType>((BusinessType)viewT_ticketbatch.BusinessType));
				array[num++] = viewT_ticketbatch.ClientPart;
				array[num++] = viewT_ticketbatch.Lisence;
				array[num++] = viewT_ticketbatch.UnitName;
				array[num++] = viewT_ticketbatch.ProductName;
				array[num++] = viewT_ticketbatch.JiHuaLiang;
				array[num++] = viewT_ticketbatch.FirstWeight;
				array[num++] = viewT_ticketbatch.SecondWeight;
				array[num++] = viewT_ticketbatch.DifferWeight;
				array[num++] = viewT_ticketbatch.DanWei;
				array[num++] = ShowWords.ReplaceText(EnumHelper.GetDescription<TicketStatus>((TicketStatus)viewT_ticketbatch.Status));
				array[num++] = viewT_ticketbatch.BatchCode;
				array[num++] = viewT_ticketbatch.QuantityBatch;
				array[num++] = ShowWords.ReplaceText(((LabStatus)viewT_ticketbatch.BatchLabStatus).ToString());
				array[num++] = ShowWords.ReplaceText(((CheckResult)viewT_ticketbatch.BatchLabResult).ToString());
				array[num++] = viewT_ticketbatch.BatchLabMan;
				array[num++] = viewT_ticketbatch.BatchLabTime;
				array[num++] = viewT_ticketbatch.BatchLabCount;
				array[num++] = viewT_ticketbatch.ZhiDanRen;
				array[num++] = viewT_ticketbatch.ZhiDanTime.ToString("yyyy-MM-dd HH:mm:ss");
				array[num++] = viewT_ticketbatch.Remark;
				this.dgvDataPlan.Rows.Add(array);
			}
			this.gPanelPlan.Text = ShowWords.ReplaceText("Plan") + "(" + this.dgvDataPlan.RowCount.ToString() + ")";
		}

		// Token: 0x0600054B RID: 1355 RVA: 0x00085F0C File Offset: 0x0008410C
		private void frmTicketBatchLab_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.timer.Stop();
		}

		// Token: 0x0600054C RID: 1356 RVA: 0x00085F1C File Offset: 0x0008411C
		private void btnLab_Click(object sender, EventArgs e)
		{
			bool flag = this.dgvData.Rows.Count == 0;
			if (!flag)
			{
				this.OpenForm(((ButtonItem)sender).Text, BaseForm.FormActtion.Modify);
			}
		}

		// Token: 0x0600054D RID: 1357 RVA: 0x00085F58 File Offset: 0x00084158
		private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			bool flag = e.RowIndex >= 0;
			if (flag)
			{
				this.GetCurrentItem(e.RowIndex);
				this.mSelectIndex = e.RowIndex;
			}
		}

		// Token: 0x0600054E RID: 1358 RVA: 0x00085F94 File Offset: 0x00084194
		private void dgvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			bool flag = e.RowIndex >= 0;
			if (flag)
			{
				this.mSelectIndex = e.RowIndex;
				this.OpenForm(this.btnLab.Text, BaseForm.FormActtion.Modify);
			}
		}

		// Token: 0x0600054F RID: 1359 RVA: 0x00085FD4 File Offset: 0x000841D4
		private void GetCurrentItem(int rowindex)
		{
			this._CurrentId = int.Parse(this.dgvData.Rows[rowindex].Cells[0].Value.ToString());
			this._CurrentItemName = this.dgvData.Rows[rowindex].Cells["C_DanHao"].Value.ToString();
		}

		// Token: 0x06000550 RID: 1360 RVA: 0x00086044 File Offset: 0x00084244
		protected void OpenForm(string title, BaseForm.FormActtion action)
		{
			BaseDialogForm baseDialogForm = base.CreateInstance<BaseDialogForm>(typeof(frmTicketBatchLabEdit), title, action, this._FrmName);
			bool flag = baseDialogForm.ShowDialog() == DialogResult.Yes;
			if (flag)
			{
				base.ShowMsg(ShowWords.ReplaceText(Messages.SaveTrue), "", "");
			}
		}

		// Token: 0x06000551 RID: 1361 RVA: 0x00086098 File Offset: 0x00084298
		private void btnSampling_Click(object sender, EventArgs e)
		{
			BaseDialogForm._operateArgs.OperateType = ((ButtonItem)sender).Text;
			bool flag = this.dgvData.Rows.Count == 0;
			if (!flag)
			{
				bool flag2 = !base.ShowChoise(Messages.SamplingSure, "", "");
				if (!flag2)
				{
					this.LabStatusCheck(2);
				}
			}
		}

		// Token: 0x06000552 RID: 1362 RVA: 0x00086100 File Offset: 0x00084300
		private void btnAnalysis_Click(object sender, EventArgs e)
		{
			BaseDialogForm._operateArgs.OperateType = ((ButtonItem)sender).Text;
			bool flag = this.dgvData.Rows.Count == 0;
			if (!flag)
			{
				bool flag2 = !base.ShowChoise(Messages.AnalysisSure, "", "");
				if (!flag2)
				{
					this.LabStatusCheck(3);
				}
			}
		}

		// Token: 0x06000553 RID: 1363 RVA: 0x00086168 File Offset: 0x00084368
		private void btnConfirm_Click(object sender, EventArgs e)
		{
			BaseDialogForm._operateArgs.OperateType = ((ButtonItem)sender).Text;
			bool flag = this.dgvData.Rows.Count == 0;
			if (!flag)
			{
				bool flag2 = !base.ShowChoise(Messages.ConfirmSure, "", "");
				if (!flag2)
				{
					this.LabStatusCheck(5);
				}
			}
		}

		// Token: 0x06000554 RID: 1364 RVA: 0x000861D0 File Offset: 0x000843D0
		private void LabStatusCheck(int labStatus)
		{
			ModT_ticketbatch model = DalT_ticketbatch.Instance.GetModel(this._CurrentId);
			string text = this.mBatchLabHelper.UpdateTicketLabStatus(labStatus, model);
			bool flag = text.Length > 0;
			if (flag)
			{
				base.ShowMsg(ShowWords.ReplaceText(text), "", "");
			}
			this.OnOperateSuccess(new
			{
				BatchCode = model.BatchCode,
				OldLabStatus = model.BatchLabStatus,
				NewLabStatus = labStatus
			}, true);
		}

		// Token: 0x04000923 RID: 2339
		public SpeechSynthesizer SpVoice = new SpeechSynthesizer();

		// Token: 0x04000924 RID: 2340
		private int mSelectIndex = 0;

		// Token: 0x04000925 RID: 2341
		private BatchLabHelper mBatchLabHelper = new BatchLabHelper();
	}
}
