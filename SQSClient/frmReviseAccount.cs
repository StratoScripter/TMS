using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Assistant;
using Base;
using DAL.Access;
using DAL.Base.SQSConfig;
using DAL.MySQL;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using DevComponents.DotNetBar.Layout;
using DevComponents.Editors;
using ICHandle;
using InterHandle;
using Model;
using Model.DiBang;
using Model.SQSConfig;
using SQSClient.Properties;

namespace SQSClient
{
	// Token: 0x02000012 RID: 18
	public partial class frmReviseAccount : BaseDialogForm
	{
		// Token: 0x06000094 RID: 148 RVA: 0x00010B0C File Offset: 0x0000ED0C
		public frmReviseAccount(string text, BaseForm.FormActtion act, int id, string dir)
		{
			this.InitializeComponent();
			base.Width = Screen.PrimaryScreen.Bounds.Width;
			this.SetText(this);
			this._Controls.Clear();
			this._Controls.Add(this.bar);
			this.Text = text;
			this._Act = act;
			this._CurrentId = id;
			this._Direct = dir;
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00010BAC File Offset: 0x0000EDAC
		private void frmReviseAccount_Load(object sender, EventArgs e)
		{
			base.InitBurron();
			this.InitControl();
			this._StaticColumnCount = this.dgvData.Columns.Count;
			base.CreateDgv(this.dgvData, "c_t_ticket_" + base.Name);
			this.LoadData();
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00010C04 File Offset: 0x0000EE04
		private bool InitControl()
		{
			DataGridViewComboBoxExColumn dataGridViewComboBoxExColumn = (DataGridViewComboBoxExColumn)this.dgvData.Columns["C_Loadometer"];
			dataGridViewComboBoxExColumn.DropDownStyle = ComboBoxStyle.DropDownList;
			dataGridViewComboBoxExColumn.DisplayMember = "Name";
			dataGridViewComboBoxExColumn.ValueMember = "Name";
			dataGridViewComboBoxExColumn.DataSource = DalCfg_weighbridge.Instance.GetAllList();
			this.cmbClientpart.BindDataSouce(DalT_client.Instance.GetAllList(), "Name", "PinYinMa", "Id");
			this.cmbSettlepart.BindDataSouce(DalT_settlepart.Instance.GetAllList(), "Name", "PinYinMa", "Id");
			this.cmbBusinessType.BindDataSouce(BaseForm.GetEnumModelList<BusinessType>(), "Description", "Description", "Value");
			this.cmbAccountType.BindDataSouce(BaseForm.GetEnumModelList<AccountType>(), "Description", "Description", "Value");
			bool flag = DalCfg_setting.Instance.GetModel("Item", "AccountHandEnable").Value == "0";
			if (flag)
			{
				this.cmbAccountType.Items.Remove(ShowWords.ReplaceText(AccountType.Hand.ToString()));
			}
			this.MaxFWDifferSetting = DalCfg_setting.Instance.GetModel("Item", "MaxFWDiffer");
			return true;
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00010D58 File Offset: 0x0000EF58
		protected override void LoadData()
		{
			bool flag = this._Act == BaseForm.FormActtion.Modify;
			if (flag)
			{
				this._mod = DalT_ticket.Instance.GetModel("Id", this._CurrentId);
				bool flag2 = this._mod == null;
				if (flag2)
				{
					base.ShowMsg(Messages.ObjNonExist, "", "");
					base.DialogResult = DialogResult.No;
				}
				else
				{
					this.txtContractNum.Text = this._mod.ContractNum;
					this.cmbBusinessType.SelectedValue = this._mod.BusinessType;
					this.cmbClientpart.Text = this._mod.ClientPart;
					this.cmbSettlepart.Text = this._mod.SettlePart;
					this.txtCardNum.Text = this._mod.CardNum;
					this.cmbAccountType.SelectedValue = this._mod.AccountType;
					this._list = DalT_ticket.Instance.GetList("BatchNum", this._mod.BatchNum);
					this.dgvData.Rows.Clear();
					int num = 0;
					foreach (ModT_ticket modT_ticket in this._list)
					{
						this.dgvData.Rows.Add();
						this.dgvData.Rows[num].Cells["C_DanHao"].Value = modT_ticket.DanHao;
						this.dgvData.Rows[num].Cells["C_CheNum"].Value = modT_ticket.Lisence;
						this.dgvData.Rows[num].Cells["C_CangNum"].Value = modT_ticket.CangNum;
						this.dgvData.Rows[num].Cells["C_Product"].Value = modT_ticket.ProductName;
						this.dgvData.Rows[num].Cells["C_UnitName"].Value = modT_ticket.UnitName;
						this.dgvData.Rows[num].Cells["C_DanWei"].Value = modT_ticket.DanWei;
						this.dgvData.Rows[num].Cells["C_JiHuaLiang"].Value = modT_ticket.JiHuaLiang;
						this.dgvData.Rows[num].Cells["C_ShiJiLiang"].Value = modT_ticket.ShiJiLiang + modT_ticket.XianQianLiang;
						this.dgvData.Rows[num].Cells["C_FirstWeight"].Value = modT_ticket.FirstWeight;
						this.dgvData.Rows[num].Cells["C_SecondWeight"].Value = modT_ticket.SecondWeight;
						this.dgvData.Rows[num].Cells["C_DifferWeight"].Value = modT_ticket.DifferWeight;
						this.dgvData.Rows[num].Cells["C_FWDiffer"].Value = modT_ticket.FWDiffer;
						bool flag3 = Math.Abs(decimal.Parse(this.dgvData.Rows[num].Cells["C_FWDiffer"].Value.ToString())) > decimal.Parse(this.MaxFWDifferSetting.Value);
						if (flag3)
						{
							this.dgvData.Rows[num].Cells["C_FWDiffer"].Style.BackColor = Color.Red;
						}
						this.dgvData.Rows[num].Cells["C_FirstTime"].Value = modT_ticket.FirstTime;
						this.dgvData.Rows[num].Cells["C_SecondTime"].Value = modT_ticket.SecondTime;
						this.dgvData.Rows[num].Cells["C_Loadometer"].Value = modT_ticket.Loader;
						this.dgvData.Rows[num].Cells["C_JieSuanLiang"].Value = modT_ticket.JieSuanLiang;
						this.dgvData.Rows[num].Cells["C_Status"].Value = ShowWords.ReplaceText(EnumHelper.GetDescription<TicketStatus>((TicketStatus)modT_ticket.Status));
						for (int i = this._StaticColumnCount; i < this.dgvData.ColumnCount; i++)
						{
							this.dgvData.Rows[num].Cells[i].Value = base.GetValueMod<ModT_ticket>(modT_ticket, this.dgvData.Columns[i].DataPropertyName);
						}
						num++;
					}
					this.gPanelContract.Enabled = false;
					bool flag4 = this._mod.State == 2;
					if (flag4)
					{
						base.ShowToast(this, Messages.TicketDumped, "", "");
						this._IsFile = true;
						this.btnSave.Enabled = (this.btnCancelAccount.Enabled = !this._IsFile);
						this.cmbSettlepart.Enabled = !this._IsFile;
					}
				}
			}
		}

		// Token: 0x06000098 RID: 152 RVA: 0x000113A4 File Offset: 0x0000F5A4
		private void btnCard_Click(object sender, EventArgs e)
		{
			try
			{
				this.txtCardNum.Text = ICTicket.ReadCardNum();
			}
			catch
			{
				base.ShowToast(this, Messages.ReadCardFalse, "", "");
			}
		}

		// Token: 0x06000099 RID: 153 RVA: 0x000113F4 File Offset: 0x0000F5F4
		private void btnSave_Click(object sender, EventArgs e)
		{
			this.txtCardNum.Focus();
			bool flag = !this.TextCheck();
			if (!flag)
			{
				bool flag2 = !this.CheckStatus();
				if (!flag2)
				{
					bool flag3 = !this.Save();
					if (!flag3)
					{
						base.DialogResult = DialogResult.Yes;
					}
				}
			}
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00011448 File Offset: 0x0000F648
		private bool ExtraCheck()
		{
			try
			{
				string text = ConfigurationManager.AppSettings["ExtraCheckReturn"];
				bool flag = text.Trim().Length == 0;
				if (flag)
				{
					return true;
				}
				IManager.SOAPHandleCheckReturn.URL = text;
				Dictionary<string, object> dictionary = new Dictionary<string, object>();
				dictionary.Add("key", this._mod.CardNum);
				IManager.SOAPHandleCheckReturn.MethodName = "ExtraCheckReturn2";
				IManager.SOAPHandleCheckReturn.Paras = dictionary;
				Dictionary<string, object> dictionary2 = IManager.SOAPHandleCheckReturn.Activity().ChangeD();
				bool flag2 = dictionary2["Code"].ToString() != "1";
				if (flag2)
				{
					base.ShowMsg(this.ShowArrearsList(dictionary2), "", "");
					return false;
				}
			}
			catch
			{
				base.ShowMsg("ConfigError", "", "");
				return false;
			}
			return true;
		}

		// Token: 0x0600009B RID: 155 RVA: 0x0001154C File Offset: 0x0000F74C
		private bool CheckStatus()
		{
			bool flag = (from o in this._list
			where o.Status != 2
			select o).ToList<ModT_ticket>().Count > 0;
			if (flag)
			{
				bool flag2 = !base.ShowChoise("TicketStateButStatusNotFinish", "", "");
				if (flag2)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x0600009C RID: 156 RVA: 0x000115C0 File Offset: 0x0000F7C0
		private string ShowArrearsList(Dictionary<string, object> eresult)
		{
			string text = string.Empty;
			try
			{
				Dictionary<string, object> dictionary = eresult["Data"].ChangeD();
				bool flag = dictionary == null;
				if (flag)
				{
					text = "eresult[Data]" + ShowWords.ReplaceText("ObjNonError");
					return text;
				}
				object obj = dictionary.First();
				List<object> list = obj.ChangeDs();
				foreach (object obj2 in list)
				{
					Dictionary<string, object> dictionary2 = (Dictionary<string, object>)obj2;
					text = string.Concat(new string[]
					{
						text,
						dictionary2["DanHao"].ToString(),
						":",
						dictionary2["Remark"].ToString(),
						";"
					});
				}
				text = ShowWords.ReplaceText("CreditInsufficient") + " " + text;
			}
			catch (Exception ex)
			{
				text = ShowWords.ReplaceText("InterfaceReturnError");
			}
			return text;
		}

		// Token: 0x0600009D RID: 157 RVA: 0x000116E8 File Offset: 0x0000F8E8
		private string ShowArrearsInfo(Dictionary<string, object> eresult)
		{
			string arrearsInfo = string.Empty;
			Dictionary<string, object> dictionary = eresult["Data"].ChangeD();
			bool flag = dictionary == null;
			if (flag)
			{
				arrearsInfo = "eresult[Data]对象为空，请检查";
			}
			object obj = dictionary.First();
			List<object> source = obj.ChangeDs();
			(from d in source
			group d by d.ChangeD()["DanHao"]).ToList<IGrouping<object, object>>().ForEach(delegate(IGrouping<object, object> l)
			{
				foreach (object obj2 in l)
				{
					Dictionary<string, object> dictionary2 = (Dictionary<string, object>)obj2;
					arrearsInfo = string.Concat(new string[]
					{
						arrearsInfo,
						dictionary2["DanHao"].ToString(),
						":",
						dictionary2["Remark"].ToString(),
						";"
					});
				}
			});
			return arrearsInfo;
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00011788 File Offset: 0x0000F988
		private bool TextCheck()
		{
			bool flag = DalCfg_setting.Instance.GetModel("Item", "PaidAddLabResult").Value == "1";
			if (flag)
			{
				bool flag2 = this._list.FindAll((ModT_ticket l) => l.LabStatus != 5 || l.LabResult != 1).Count > 0;
				if (flag2)
				{
					base.ShowMsg(Messages.LabPaidFalse, "", "");
					return false;
				}
			}
			return true;
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00011818 File Offset: 0x0000FA18
		private bool Save()
		{
			int num = 0;
			foreach (ModT_ticket modT_ticket in this._list)
			{
				Dictionary<string, object> dictionary = new Dictionary<string, object>();
				dictionary.Add("Status", 2);
				dictionary.Add("State", 1);
				dictionary.Add("IsCard", false);
				dictionary.Add("JieSuanRen", GlobalKey.UserName);
				dictionary.Add("JieSuanTime", DateTime.Now);
				dictionary.Add("XianQianLiang", 0);
				dictionary.Add("ShiJiLiang", decimal.Parse(this.dgvData.Rows[num].Cells["C_ShiJiLiang"].EditedFormattedValue.ToString()));
				dictionary.Add("FirstWeight", decimal.Parse(this.dgvData.Rows[num].Cells["C_FirstWeight"].EditedFormattedValue.ToString()));
				dictionary.Add("SecondWeight", decimal.Parse(this.dgvData.Rows[num].Cells["C_SecondWeight"].EditedFormattedValue.ToString()));
				dictionary.Add("DifferWeight", decimal.Parse(this.dgvData.Rows[num].Cells["C_DifferWeight"].EditedFormattedValue.ToString()));
				dictionary.Add("FWDiffer", decimal.Parse(this.dgvData.Rows[num].Cells["C_FWDiffer"].EditedFormattedValue.ToString()));
				dictionary.Add("FirstTime", this.dgvData.Rows[num].Cells["C_FirstTime"].EditedFormattedValue.ToString());
				dictionary.Add("SecondTime", this.dgvData.Rows[num].Cells["C_SecondTime"].EditedFormattedValue.ToString());
				dictionary.Add("Loader", this.dgvData.Rows[num].Cells["C_Loadometer"].EditedFormattedValue.ToString());
				for (int i = this._StaticColumnCount; i < this.dgvData.ColumnCount; i++)
				{
					bool flag = !this.dgvData.Columns[i].ReadOnly;
					if (flag)
					{
						dictionary.Add(this.dgvData.Columns[i].DataPropertyName, this.dgvData.Rows[num].Cells[i].EditedFormattedValue);
					}
				}
				dictionary.Add("AccountType", (int)this.cmbAccountType.SelectedValue);
				dictionary.Add("JieSuanLiang", 0);
				bool flag2 = int.Parse(dictionary["AccountType"].ToString()) == 0;
				if (flag2)
				{
					dictionary["JieSuanLiang"] = dictionary["ShiJiLiang"];
				}
				bool flag3 = int.Parse(dictionary["AccountType"].ToString()) == 1;
				if (flag3)
				{
					bool flag4 = decimal.Parse(dictionary["SecondWeight"].ToString()) < 0m;
					if (flag4)
					{
						base.ShowToast(this, Messages.SettleFalse, "", "");
						return false;
					}
					dictionary["JieSuanLiang"] = decimal.Parse(dictionary["DifferWeight"].ToString()) - modT_ticket.PackWeightExt - modT_ticket.ImpurityAmount - modT_ticket.DeductWeight;
				}
				bool flag5 = int.Parse(dictionary["AccountType"].ToString()) == 2;
				if (flag5)
				{
					dictionary["JieSuanLiang"] = decimal.Parse(this.dgvData.Rows[num].Cells["C_JieSuanLiang"].EditedFormattedValue.ToString());
				}
				bool flag6 = int.Parse(dictionary["AccountType"].ToString()) == 3;
				if (flag6)
				{
					dictionary["JieSuanLiang"] = modT_ticket.AssistActualAccount * modT_ticket.SpecsAmount;
				}
				num++;
				bool flag7 = !DalT_ticket.Instance.Update(dictionary, modT_ticket.Id);
				if (flag7)
				{
					this.OnOperateFail(dictionary, false);
					base.ShowToast(this, Messages.SettleFalse, "", "");
					return false;
				}
				this.OnOperateSuccess(dictionary, modT_ticket, true);
			}
			return true;
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00011D78 File Offset: 0x0000FF78
		private void btnPrint_Click(object sender, EventArgs e)
		{
			bool flag = !this._IsFile;
			if (flag)
			{
				bool flag2 = !this.Save();
				if (flag2)
				{
					return;
				}
			}
			this._list = DalT_ticket.Instance.GetList("BatchNum", this._mod.BatchNum);
			frmPrintChoise frmPrintChoise = new frmPrintChoise(((ButtonItem)sender).Text, this._mod, this._list);
			bool flag3 = frmPrintChoise.ShowDialog() == DialogResult.Yes;
			if (flag3)
			{
				base.DialogResult = DialogResult.Yes;
			}
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00011E00 File Offset: 0x00010000
		private void btnCancelAccount_Click(object sender, EventArgs e)
		{
			bool flag = !this.CancelAccount();
			if (!flag)
			{
				base.DialogResult = DialogResult.Yes;
			}
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00011E28 File Offset: 0x00010028
		private bool CancelAccount()
		{
			foreach (ModT_ticket modT_ticket in this._list)
			{
				ModT_ticket modT_ticket2 = this._mod.Clone() as ModT_ticket;
				modT_ticket.State = 0;
				modT_ticket.JieSuanRen = "";
				List<string> list = new List<string>();
				List<object> list2 = new List<object>();
				list.Add("State");
				list2.Add(modT_ticket.State);
				list.Add("JieSuanRen");
				list2.Add(modT_ticket.JieSuanRen);
				bool flag = !DalT_ticket.Instance.Update(list, list2, modT_ticket.Id);
				if (flag)
				{
					this.OnOperateFail(this._mod, false);
					base.ShowToast(this, Messages.SettleCancelFalse, "", "");
					return false;
				}
				this.OnOperateSuccess(this._mod, true);
			}
			return true;
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00011F50 File Offset: 0x00010150
		private void txtContractNum_TextChanged(object sender, EventArgs e)
		{
			ModT_contract model = DalT_contract.Instance.GetModel("ContractNum", this.txtContractNum.Text);
			bool flag = model != null;
			if (flag)
			{
				this.cmbBusinessType.SelectedValue = model.BusinessType;
				this.cmbClientpart.Text = model.PartyB;
				this.cmbSettlepart.Text = model.PartyA;
				this.txtProduct.Text = model.ProductName;
			}
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00011FD0 File Offset: 0x000101D0
		private void btnDiBangValue_Click(object sender, EventArgs e)
		{
			string starttime = this._mod.EndTime.ToString("yyyy-MM-dd HH:mm:ss");
			string endtime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
			foreach (object obj in ((IEnumerable)this.dgvData.Rows))
			{
				DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
				bool flag = dataGridViewRow.Cells["C_Loadometer"].EditedFormattedValue.ToString() != "" && dataGridViewRow.Cells["C_CheNum"].Value.ToString() != "";
				if (flag)
				{
					ModCfg_weighbridge model = DalCfg_weighbridge.Instance.GetModel("Name", dataGridViewRow.Cells["C_Loadometer"].EditedFormattedValue.ToString());
					bool flag2 = model.ModeType == ModeType.SQL.ToString();
					ModT_Trade diBangValue;
					if (flag2)
					{
						diBangValue = DalTrade.Instance.GetDiBangValue(model, dataGridViewRow.Cells["C_CheNum"].Value.ToString(), starttime, endtime);
					}
					else
					{
						bool flag3 = model.ModeType == ModeType.MySQL.ToString();
						if (flag3)
						{
							diBangValue = DAL.MySQL.DalDiBangRecord.Instance.GetDiBangValue(model, dataGridViewRow.Cells["C_CheNum"].Value.ToString(), starttime, endtime, 2);
						}
						else
						{
							diBangValue = DAL.Access.DalDiBangRecord.Instance.GetDiBangValue(model, dataGridViewRow.Cells["C_CheNum"].Value.ToString(), starttime, endtime);
						}
					}
					bool flag4 = diBangValue != null;
					if (flag4)
					{
						dataGridViewRow.Cells["C_FirstWeight"].Value = diBangValue.FirstWeight;
						dataGridViewRow.Cells["C_SecondWeight"].Value = diBangValue.SecondWeight;
						dataGridViewRow.Cells["C_DifferWeight"].Value = diBangValue.SecondWeight - diBangValue.FirstWeight;
						dataGridViewRow.Cells["C_FWDiffer"].Value = decimal.Parse(dataGridViewRow.Cells["C_ShiJiLiang"].EditedFormattedValue.ToString()) - decimal.Parse(dataGridViewRow.Cells["C_DifferWeight"].EditedFormattedValue.ToString());
						bool flag5 = Math.Abs(decimal.Parse(dataGridViewRow.Cells["C_FWDiffer"].EditedFormattedValue.ToString())) > decimal.Parse(this.MaxFWDifferSetting.Value);
						if (flag5)
						{
							dataGridViewRow.Cells["C_FWDiffer"].Style.BackColor = Color.Red;
						}
						dataGridViewRow.Cells["C_FirstTime"].Value = diBangValue.FirstTime;
						dataGridViewRow.Cells["C_SecondTime"].Value = diBangValue.SecondTime;
					}
					else
					{
						base.ShowToast(this, Messages.NoWeighbridgeData, "", "");
					}
				}
			}
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00012374 File Offset: 0x00010574
		private void dgvData_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
		{
			Rectangle bounds = new Rectangle(e.RowBounds.Location.X, e.RowBounds.Location.Y, this.dgvData.RowHeadersWidth - 4, e.RowBounds.Height);
			TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(), this.dgvData.RowHeadersDefaultCellStyle.Font, bounds, this.dgvData.RowHeadersDefaultCellStyle.ForeColor, TextFormatFlags.Right | TextFormatFlags.VerticalCenter);
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00012410 File Offset: 0x00010610
		private void cmbAccountType_TextChanged(object sender, EventArgs e)
		{
			bool flag = (int)this.cmbAccountType.SelectedValue == 2;
			if (flag)
			{
				this.dgvData.Columns["C_JieSuanLiang"].ReadOnly = false;
			}
			else
			{
				this.dgvData.Columns["C_JieSuanLiang"].ReadOnly = true;
			}
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00012473 File Offset: 0x00010673
		private void btnItemC_Click(object sender, EventArgs e)
		{
			this.OpenForm(typeof(frmItemChoose), ((ButtonItem)sender).Text, new object[]
			{
				"t_ticket",
				base.Name
			});
		}

		// Token: 0x0400011D RID: 285
		private ModT_ticket _mod = new ModT_ticket();

		// Token: 0x0400011E RID: 286
		private List<ModT_ticket> _list = new List<ModT_ticket>();

		// Token: 0x0400011F RID: 287
		private ModCfg_setting MaxFWDifferSetting;

		// Token: 0x04000120 RID: 288
		private bool _IsFile = false;

		// Token: 0x04000121 RID: 289
		private int _StaticColumnCount;
	}
}
