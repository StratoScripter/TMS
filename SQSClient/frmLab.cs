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
	// Token: 0x02000024 RID: 36
	public partial class frmLab : BaseDialogForm
	{
		// Token: 0x060001B1 RID: 433 RVA: 0x000328A0 File Offset: 0x00030AA0
		public frmLab()
		{
			this.InitializeComponent();
			this.SetText(this);
			this.mListener.ScanerEvent += this.Listener_ScanerEvent;
			this._Controls.Clear();
			this._Controls.Add(this.bar);
			this._Controls.Add(this.dgvData);
			this._Controls.Add(this.dgvDataPlan);
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x0003293C File Offset: 0x00030B3C
		private void frmLab_Load(object sender, EventArgs e)
		{
			base.InitBurron();
			this.InitControl();
			this._StaticColumnCount = this.dgvData.Columns.Count;
			base.CreateDgv(this.dgvData, "c_t_ticket_" + base.Name);
			base.CreateDgv(this.dgvData1, "c_t_ticket_" + base.Name);
			base.CreateDgv(this.dgvDataPlan, "c_t_ticket_" + base.Name);
			bool isLabDynamicRefresh = Settings.Instance.IsLabDynamicRefresh;
			if (isLabDynamicRefresh)
			{
				this.timer.Start();
			}
			this.mListener.Start();
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x000329F0 File Offset: 0x00030BF0
		private void InitControl()
		{
			this.dgvData.Height = this.ePanelToSample.Height / 3;
			this.lblTicketDanHao.Text = string.Empty;
			this.cbxSpeech.Checked = Settings.Instance.IsLabSpeech;
			this.dgvData.MultiSelect = true;
			this.dgvData1.MultiSelect = true;
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x00032A58 File Offset: 0x00030C58
		private void timer_Tick(object sender, EventArgs e)
		{
			this.RefreshDataView();
			this.timer.Interval = 20000;
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x00032A74 File Offset: 0x00030C74
		private void AddCompanyGroupCondition(List<string> formulas)
		{
			bool flag = Settings.Instance.CompanyGroup > 0;
			if (flag)
			{
				formulas.Add("InvCode IN (select InvCode from t_product WHERE (CompanyGroup = 0 or CompanyGroup = " + Settings.Instance.CompanyGroup.ToString() + ") and State = 1)");
			}
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x00032AC0 File Offset: 0x00030CC0
		private void RefreshDataView()
		{
			this.UpdatedgvData();
			this.UpdatedgvDataPlan();
			List<string> list = new List<string>();
			list.Add("BusinessType=1");
			list.Add("SecondWeight>5000");
			list.Add("State=0");
			list.Add("IsLab='true'");
			list.Add("LabStatus<" + 5.ToString());
			this.AddCompanyGroupCondition(list);
			List<ModT_ticket> listRequire = DalT_ticket.Instance.GetListRequire(list, null, null);
			this.labMessage.Text = "";
			bool flag = listRequire.Count > 0 && this.cbxSpeech.Checked;
			if (flag)
			{
				string text = ShowWords.ReplaceText(Messages.LabRemind);
				LabelItem labelItem = this.labMessage;
				labelItem.Text += text;
				this.SpVoice.SpeakAsync(text);
			}
			List<string> list2 = new List<string>();
			list2.Add("State=0");
			list2.Add("LabStatus=" + 1.ToString());
			this.AddCompanyGroupCondition(list2);
			List<ModT_ticket> listRequire2 = DalT_ticket.Instance.GetListRequire(list2, null, null);
			bool flag2 = listRequire2.Count > 0 && this.cbxSpeech.Checked;
			if (flag2)
			{
				string text2 = ShowWords.ReplaceText(Messages.SampleRemind);
				LabelItem labelItem2 = this.labMessage;
				labelItem2.Text += text2;
				this.SpVoice.SpeakAsync(text2);
			}
			this.lblTicketDanHao.Text = "";
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x00032C4C File Offset: 0x00030E4C
		private void UpdatedgvData()
		{
			List<string> list = new List<string>();
			list.Add("LabStatus>=" + 1.ToString());
			list.Add("LabStatus<" + 5.ToString());
			this.AddCompanyGroupCondition(list);
			List<ModT_ticket> listRequire = DalT_ticket.Instance.GetListRequire(list, new List<string>
			{
				"LabStatus"
			}, null);
			List<ModT_ticket> list2 = listRequire.FindAll((ModT_ticket l) => l.BusinessType == 1);
			List<ModT_ticket> list3 = listRequire.FindAll((ModT_ticket l) => l.BusinessType == 2);
			this.ePanelToSample.TitleText = ShowWords.ReplaceText("ToSample") + "(" + listRequire.Count.ToString() + ")";
			this.dgvData.Rows.Clear();
			foreach (ModT_ticket modT_ticket in list2)
			{
				object[] array = new object[this.dgvData.ColumnCount];
				int num = 0;
				array[num++] = modT_ticket.Id;
				array[num++] = modT_ticket.DanHao;
				array[num++] = ShowWords.ReplaceText(EnumHelper.GetDescription<BusinessType>((BusinessType)modT_ticket.BusinessType));
				array[num++] = modT_ticket.ProductName;
				array[num++] = modT_ticket.Lisence;
				array[num++] = modT_ticket.UnitName;
				array[num++] = modT_ticket.JiHuaLiang;
				array[num++] = modT_ticket.ShiJiLiang;
				array[num++] = modT_ticket.DifferWeight;
				array[num++] = modT_ticket.JieSuanLiang;
				array[num++] = modT_ticket.DanWei;
				array[num++] = ShowWords.ReplaceText(EnumHelper.GetDescription<TicketStatus>((TicketStatus)modT_ticket.Status));
				array[num++] = ShowWords.ReplaceText(((LabStatus)modT_ticket.LabStatus).ToString());
				array[num++] = ShowWords.ReplaceText(((CheckResult)modT_ticket.LabResult).ToString());
				array[num++] = modT_ticket.LabMan;
				array[num++] = modT_ticket.LabTime;
				array[num++] = modT_ticket.LabCount;
				array[num++] = modT_ticket.Remark;
				array[num++] = modT_ticket.ClientPart;
				for (int i = this._StaticColumnCount; i < this.dgvData.ColumnCount; i++)
				{
					array[i] = base.GetValueMod<ModT_ticket>(modT_ticket, this.dgvData.Columns[i].DataPropertyName);
				}
				this.dgvData.Rows.Add(array);
				bool flag = modT_ticket.LabStatus < 2;
				if (flag)
				{
					this.dgvData.Rows[this.dgvData.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Yellow;
				}
				else
				{
					this.dgvData.Rows[this.dgvData.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Green;
				}
			}
			this.dgvData.ClearSelection();
			this.dgvData1.Rows.Clear();
			foreach (ModT_ticket modT_ticket2 in list3)
			{
				object[] array2 = new object[this.dgvData1.ColumnCount];
				int num2 = 0;
				array2[num2++] = modT_ticket2.Id;
				array2[num2++] = modT_ticket2.DanHao;
				array2[num2++] = ShowWords.ReplaceText(EnumHelper.GetDescription<BusinessType>((BusinessType)modT_ticket2.BusinessType));
				array2[num2++] = modT_ticket2.ProductName;
				array2[num2++] = modT_ticket2.Lisence;
				array2[num2++] = modT_ticket2.UnitName;
				array2[num2++] = modT_ticket2.JiHuaLiang;
				array2[num2++] = modT_ticket2.ShiJiLiang;
				array2[num2++] = modT_ticket2.DifferWeight;
				array2[num2++] = modT_ticket2.JieSuanLiang;
				array2[num2++] = modT_ticket2.DanWei;
				array2[num2++] = ShowWords.ReplaceText(EnumHelper.GetDescription<TicketStatus>((TicketStatus)modT_ticket2.Status));
				array2[num2++] = ShowWords.ReplaceText(((LabStatus)modT_ticket2.LabStatus).ToString());
				array2[num2++] = ShowWords.ReplaceText(((CheckResult)modT_ticket2.LabResult).ToString());
				array2[num2++] = modT_ticket2.LabMan;
				array2[num2++] = modT_ticket2.LabTime;
				array2[num2++] = modT_ticket2.LabCount;
				array2[num2++] = modT_ticket2.Remark;
				array2[num2++] = modT_ticket2.ClientPart;
				for (int j = this._StaticColumnCount; j < this.dgvData1.ColumnCount; j++)
				{
					array2[j] = base.GetValueMod<ModT_ticket>(modT_ticket2, this.dgvData1.Columns[j].DataPropertyName);
				}
				this.dgvData1.Rows.Add(array2);
				bool flag2 = modT_ticket2.LabStatus < 2;
				if (flag2)
				{
					this.dgvData1.Rows[this.dgvData1.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Yellow;
				}
				else
				{
					this.dgvData1.Rows[this.dgvData1.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Green;
				}
			}
			this.dgvData1.ClearSelection();
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x0003332C File Offset: 0x0003152C
		private void UpdatedgvDataPlan()
		{
			List<string> list = new List<string>();
			list.Add("IsLab='true'");
			list.Add("LabStatus='0'");
			list.Add("State=0");
			this.AddCompanyGroupCondition(list);
			List<ModT_ticket> listRequire = DalT_ticket.Instance.GetListRequire(list, null, null);
			this.dgvDataPlan.Rows.Clear();
			foreach (ModT_ticket modT_ticket in listRequire)
			{
				object[] array = new object[this.dgvDataPlan.ColumnCount];
				int num = 0;
				array[num++] = modT_ticket.Id;
				array[num++] = modT_ticket.DanHao;
				array[num++] = ShowWords.ReplaceText(EnumHelper.GetDescription<BusinessType>((BusinessType)modT_ticket.BusinessType));
				array[num++] = modT_ticket.ProductName;
				array[num++] = modT_ticket.ClientPart;
				array[num++] = modT_ticket.Lisence;
				array[num++] = modT_ticket.UnitName;
				array[num++] = modT_ticket.JiHuaLiang;
				array[num++] = modT_ticket.DanWei;
				array[num++] = ShowWords.ReplaceText(EnumHelper.GetDescription<TicketStatus>((TicketStatus)modT_ticket.Status));
				array[num++] = ShowWords.ReplaceText(((LabStatus)modT_ticket.LabStatus).ToString());
				array[num++] = ShowWords.ReplaceText(((CheckResult)modT_ticket.LabResult).ToString());
				array[num++] = modT_ticket.LabMan;
				array[num++] = modT_ticket.LabTime;
				array[num++] = modT_ticket.LabCount;
				array[num++] = modT_ticket.Remark;
				for (int i = this._StaticColumnCount; i < this.dgvDataPlan.ColumnCount; i++)
				{
					array[i] = base.GetValueMod<ModT_ticket>(modT_ticket, this.dgvDataPlan.Columns[i].DataPropertyName);
				}
				this.dgvDataPlan.Rows.Add(array);
			}
			this.ePanelPlan.TitleText = ShowWords.ReplaceText("Plan") + "(" + this.dgvDataPlan.RowCount.ToString() + ")";
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x000335D4 File Offset: 0x000317D4
		private void frmLab_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.timer.Stop();
			this.mListener.Stop();
		}

		// Token: 0x060001BA RID: 442 RVA: 0x000335EF File Offset: 0x000317EF
		private void btnLab_Click(object sender, EventArgs e)
		{
			this.OpenForm(((ButtonItem)sender).Text, BaseForm.FormActtion.Modify);
		}

		// Token: 0x060001BB RID: 443 RVA: 0x00033608 File Offset: 0x00031808
		private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			bool flag = e.RowIndex >= 0;
			if (flag)
			{
				DataGridViewX dataGridViewX = sender as DataGridViewX;
				bool flag2 = dataGridViewX.Name == "dgvData";
				if (flag2)
				{
					this.dgvData1.ClearSelection();
				}
				else
				{
					bool flag3 = dataGridViewX.Name == "dgvData1";
					if (flag3)
					{
						this.dgvData.ClearSelection();
					}
				}
				this._CurrentId = int.Parse(dataGridViewX.Rows[e.RowIndex].Cells[0].Value.ToString());
				this._CurrentItemName = dataGridViewX.Rows[e.RowIndex].Cells[1].Value.ToString();
				dataGridViewX.Rows[e.RowIndex].Selected = true;
				this.ShowCurrentDanHao();
			}
		}

		// Token: 0x060001BC RID: 444 RVA: 0x000336F4 File Offset: 0x000318F4
		private void dgvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			bool flag = e.RowIndex >= 0;
			if (flag)
			{
				this.OpenForm(this.btnLab.Text, BaseForm.FormActtion.Modify);
			}
		}

		// Token: 0x060001BD RID: 445 RVA: 0x00033727 File Offset: 0x00031927
		private void ShowCurrentDanHao()
		{
			this.lblTicketDanHao.Text = ShowWords.ReplaceText("CurrentDanHao") + this._CurrentItemName;
		}

		// Token: 0x060001BE RID: 446 RVA: 0x0003374C File Offset: 0x0003194C
		protected void OpenForm(string title, BaseForm.FormActtion action)
		{
			bool flag = this._CurrentId == 0;
			if (!flag)
			{
				BaseDialogForm baseDialogForm = base.CreateInstance<BaseDialogForm>(typeof(frmLabEdit), title, action, this._FrmName);
				bool flag2 = baseDialogForm.ShowDialog() == DialogResult.Yes;
				if (flag2)
				{
					base.ShowMsg(Messages.SaveTrue, "", "");
				}
			}
		}

		// Token: 0x060001BF RID: 447 RVA: 0x000337A8 File Offset: 0x000319A8
		private void btnSampling_Click(object sender, EventArgs e)
		{
			bool flag = !base.ShowChoise(Messages.SamplingSure, "", "");
			if (!flag)
			{
				this.mSelectIds = "";
				for (int i = 0; i < this.dgvData.SelectedRows.Count; i++)
				{
					this.mSelectIds = this.mSelectIds + this.dgvData.Rows[this.dgvData.SelectedRows[i].Index].Cells[0].Value.ToString() + ",";
				}
				for (int j = 0; j < this.dgvData1.SelectedRows.Count; j++)
				{
					this.mSelectIds = this.mSelectIds + this.dgvData1.Rows[this.dgvData1.SelectedRows[j].Index].Cells[0].Value.ToString() + ",";
				}
				this.mSelectIds = this.mSelectIds.TrimEnd(new char[]
				{
					','
				});
				this.UpdateTicketLabStatusALL(this.mSelectIds, 2);
			}
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x000338F4 File Offset: 0x00031AF4
		private void btnAnalysis_Click(object sender, EventArgs e)
		{
			bool flag = !base.ShowChoise(Messages.AnalysisSure, "", "");
			if (!flag)
			{
				this.mSelectIds = "";
				for (int i = 0; i < this.dgvData.SelectedRows.Count; i++)
				{
					this.mSelectIds = this.mSelectIds + this.dgvData.Rows[this.dgvData.SelectedRows[i].Index].Cells[0].Value.ToString() + ",";
				}
				for (int j = 0; j < this.dgvData1.SelectedRows.Count; j++)
				{
					this.mSelectIds = this.mSelectIds + this.dgvData1.Rows[this.dgvData1.SelectedRows[j].Index].Cells[0].Value.ToString() + ",";
				}
				this.mSelectIds = this.mSelectIds.TrimEnd(new char[]
				{
					','
				});
				this.UpdateTicketLabStatusALL(this.mSelectIds, 3);
			}
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x00033A40 File Offset: 0x00031C40
		private void btnConfirm_Click(object sender, EventArgs e)
		{
			bool flag = !base.ShowChoise(Messages.ConfirmSure, "", "");
			if (!flag)
			{
				this.mSelectIds = "";
				for (int i = 0; i < this.dgvData.SelectedRows.Count; i++)
				{
					this.mSelectIds = this.mSelectIds + this.dgvData.Rows[this.dgvData.SelectedRows[i].Index].Cells[0].Value.ToString() + ",";
				}
				for (int j = 0; j < this.dgvData1.SelectedRows.Count; j++)
				{
					this.mSelectIds = this.mSelectIds + this.dgvData1.Rows[this.dgvData1.SelectedRows[j].Index].Cells[0].Value.ToString() + ",";
				}
				this.mSelectIds = this.mSelectIds.TrimEnd(new char[]
				{
					','
				});
				this.UpdateTicketLabStatusALL(this.mSelectIds, 5);
			}
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x00033B8C File Offset: 0x00031D8C
		private void UpdateTicketLabStatus(int labStatus)
		{
			bool flag = this._CurrentId == 0;
			if (!flag)
			{
				ModT_ticket model = DalT_ticket.Instance.GetModel(this._CurrentId);
				bool flag2 = (Convert.ToInt32(Settings.Instance.LabStepControler) == 1) ? (labStatus - model.LabStatus == 1) : (labStatus - model.LabStatus >= 1);
				bool flag3 = !flag2;
				if (flag3)
				{
					base.ShowMsg(Messages.LabStatusWrong, "", "");
				}
				else
				{
					Dictionary<string, object> dictionary = new Dictionary<string, object>();
					dictionary.Add("LabStatus", labStatus);
					bool flag4 = DalT_ticket.Instance.Update(dictionary, this._CurrentId);
					if (flag4)
					{
						this.AddtTicketLab(labStatus);
						this.OnOperateSuccess(new
						{
							TicketDanHao = model.DanHao,
							OldLabStatus = model.LabStatus,
							NewLabStatus = labStatus
						}, true);
						base.ShowMsg(Messages.SaveTrue, "", "");
					}
					else
					{
						base.ShowMsg(Messages.ModifyFalse, "", "");
					}
				}
			}
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x00033C9C File Offset: 0x00031E9C
		private void AddtTicketLab(int labStatus)
		{
			ModT_ticketlab modT_ticketlab = new ModT_ticketlab();
			modT_ticketlab.BillId = this._CurrentId;
			modT_ticketlab.BillType = 2;
			modT_ticketlab.LabStatus = labStatus;
			modT_ticketlab.CheckMan = GlobalKey.UserName;
			modT_ticketlab.LabTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
			modT_ticketlab.LabInfo = "";
			modT_ticketlab.ModifyTime = DateTime.Now;
			modT_ticketlab.State = 1;
			DalT_ticketlab.Instance.AddNoReturn(modT_ticketlab);
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x00033D20 File Offset: 0x00031F20
		private void Listener_ScanerEvent(BardCodeHooK.ScanerCodes codes)
		{
			string result = codes.Result;
			List<string> list = new List<string>();
			list.Add("SampleCode='" + result + "'");
			this.AddCompanyGroupCondition(list);
			List<ModT_ticket> listRequire = DalT_ticket.Instance.GetListRequire(list, null, null);
			bool flag = listRequire.Count == 0;
			if (!flag)
			{
				ModT_ticket modT_ticket = listRequire[0];
				bool flag2 = modT_ticket.LabStatus == 3;
				if (flag2)
				{
					frmLabEdit frmLabEdit = new frmLabEdit(this.Text, BaseForm.FormActtion.Modify, modT_ticket.Id, "");
					bool flag3 = frmLabEdit.ShowDialog() == DialogResult.Yes;
					if (flag3)
					{
						base.ShowMsg(Messages.SaveTrue, "", "");
					}
				}
				else
				{
					frmLabTicketEdit frmLabTicketEdit = new frmLabTicketEdit(this.Text, BaseForm.FormActtion.Modify, modT_ticket.Id, "");
					bool flag4 = frmLabTicketEdit.ShowDialog() == DialogResult.Yes;
					if (flag4)
					{
						base.ShowMsg(Messages.SaveTrue, "", "");
					}
				}
			}
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x00003040 File Offset: 0x00001240
		private void BtnTSCPrint__Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x00033E1C File Offset: 0x0003201C
		private void tbxPrintNum_KeyPress(object sender, KeyPressEventArgs e)
		{
			bool flag = !char.IsNumber(e.KeyChar) && e.KeyChar != '\r' && e.KeyChar != '\b';
			if (flag)
			{
				e.Handled = true;
			}
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x00033E5E File Offset: 0x0003205E
		private void cbxSpeech_Click(object sender, EventArgs e)
		{
			Settings.Instance.IsLabSpeech = this.cbxSpeech.Checked;
			Settings.Instance.Save();
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x00033E82 File Offset: 0x00032082
		private void btnRefresh_Click(object sender, EventArgs e)
		{
			this.RefreshDataView();
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x00012473 File Offset: 0x00010673
		private void btnItemC_Click(object sender, EventArgs e)
		{
			this.OpenForm(typeof(frmItemChoose), ((ButtonItem)sender).Text, new object[]
			{
				"t_ticket",
				base.Name
			});
		}

		// Token: 0x060001CA RID: 458 RVA: 0x00003040 File Offset: 0x00001240
		private void btnUnionLab_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060001CB RID: 459 RVA: 0x00033E8C File Offset: 0x0003208C
		private void UpdateTicketLabStatusALL(string selectids, int labStatus)
		{
			bool flag = selectids.Length == 0;
			if (!flag)
			{
				string[] array = selectids.Split(new char[]
				{
					','
				});
				int num = 0;
				int i = 0;
				while (i < array.Length)
				{
					int id = int.Parse(array[i].ToString());
					ModT_ticket model = DalT_ticket.Instance.GetModel(id);
					bool flag2 = labStatus == 4;
					if (!flag2)
					{
						bool flag3 = (Convert.ToInt32(Settings.Instance.LabStepControler) == 1) ? (labStatus - model.LabStatus == 1) : (labStatus - model.LabStatus >= 1);
						bool flag4 = !flag3;
						if (flag4)
						{
							num++;
						}
						else
						{
							Dictionary<string, object> dictionary = new Dictionary<string, object>();
							dictionary.Add("LabStatus", labStatus);
							bool flag5 = DalT_ticket.Instance.Update(dictionary, id);
							if (flag5)
							{
								this.AddtTicketLab(labStatus);
								this.OnOperateSuccess(new
								{
									TicketDanHao = model.DanHao,
									OldLabStatus = model.LabStatus,
									NewLabStatus = labStatus
								}, true);
							}
						}
					}
					IL_FE:
					i++;
					continue;
					goto IL_FE;
				}
				bool flag6 = num == 0;
				if (flag6)
				{
					base.ShowMsg(Messages.SaveTrue, "", "");
				}
				else
				{
					int num2 = array.Length - num;
					string format = ShowWords.ReplaceText("LabError");
					base.ShowMsg(string.Format(format, array.Length, num2, num), "", "");
				}
			}
		}

		// Token: 0x040002FB RID: 763
		public SpeechSynthesizer SpVoice = new SpeechSynthesizer();

		// Token: 0x040002FC RID: 764
		private int _StaticColumnCount;

		// Token: 0x040002FD RID: 765
		private BardCodeHooK mListener = new BardCodeHooK();
	}
}
