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
using InterHandle;
using Model;
using Model.SQSConfig;
using SQSClient.Properties;

namespace SQSClient
{
	// Token: 0x0200001A RID: 26
	public partial class frmTicketReference : BaseDialogForm
	{
		// Token: 0x06000136 RID: 310 RVA: 0x00027B80 File Offset: 0x00025D80
		public frmTicketReference(string text, BaseForm.FormActtion act, int id, string dir)
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

		// Token: 0x06000137 RID: 311 RVA: 0x00027C50 File Offset: 0x00025E50
		private void frmReviseInfo_Load(object sender, EventArgs e)
		{
			base.InitBurron();
			this.InitControl();
			base.CreateDgv(this.dgvData, "c_t_ticket_" + base.Name);
			base.CreateDgv(this.dgvDataNew, "c_t_ticket_" + base.Name);
			this.LoadData();
		}

		// Token: 0x06000138 RID: 312 RVA: 0x00027CB0 File Offset: 0x00025EB0
		private bool InitControl()
		{
			return true;
		}

		// Token: 0x06000139 RID: 313 RVA: 0x00027CC4 File Offset: 0x00025EC4
		protected override void LoadData()
		{
			this._mod = DalT_ticket.Instance.GetModel("Id", this._CurrentId);
			bool flag = this._mod == null;
			if (flag)
			{
				base.ShowMsg(Messages.ObjNonExist, "", "");
				base.Close();
			}
			else
			{
				bool flag2 = this._Act == BaseForm.FormActtion.Modify;
				if (flag2)
				{
					this._list = DalT_ticket.Instance.GetListRequire("BatchNum='" + this._mod.BatchNum.ToString() + "'", null, null);
				}
				else
				{
					this._list.Clear();
					this._list.Add(this._mod);
				}
				this.dgvData.Rows.Clear();
				this.dgvData.Rows.Add();
				for (int i = 0; i < this.dgvData.ColumnCount; i++)
				{
					this.dgvData.Rows[0].Cells[i].Value = base.GetValueMod<ModT_ticket>(this._mod, this.dgvData.Columns[i].DataPropertyName);
				}
				this.dgvData.AllowUserToDeleteRows = false;
				this.dgvData.AllowUserToAddRows = false;
				List<string> list = new List<string>();
				bool flag3 = this._mod.State == 0;
				if (flag3)
				{
					list.Add("BusinessType='1'");
				}
				list.Add("DanHao<>'" + this._mod.DanHao + "'");
				list.Add("Lisence='" + this._mod.Lisence + "'");
				list.Add("InvCode='" + this._mod.InvCode + "'");
				list.Add("Status='0'");
				List<ModT_ticket> listRequire = DalT_ticket.Instance.GetListRequire(list, null, null);
				this.dgvDataNew.Rows.Clear();
				int num = 0;
				foreach (ModT_ticket modT_ticket in listRequire)
				{
					object[] array = new object[this.dgvData.ColumnCount];
					int num2 = 0;
					array[num2++] = modT_ticket.Id;
					this.dgvDataNew.Rows.Add(array);
					for (int j = 1; j < this.dgvDataNew.ColumnCount; j++)
					{
						this.dgvDataNew.Rows[num].Cells[j].Value = base.GetValueMod<ModT_ticket>(modT_ticket, this.dgvDataNew.Columns[j].DataPropertyName);
					}
					num++;
				}
				this.dgvDataNew.AllowUserToDeleteRows = false;
				this.dgvDataNew.AllowUserToAddRows = false;
				bool flag4 = this.dgvDataNew.Rows.Count > 0;
				if (flag4)
				{
					this.GetCurrentItem(0);
				}
			}
		}

		// Token: 0x0600013A RID: 314 RVA: 0x00028018 File Offset: 0x00026218
		private void btnSave_Click(object sender, EventArgs e)
		{
			bool flag = !this.TextCheck();
			if (!flag)
			{
				bool flag2 = this.Modify();
				bool flag3 = flag2;
				if (flag3)
				{
					base.DialogResult = DialogResult.Yes;
				}
			}
		}

		// Token: 0x0600013B RID: 315 RVA: 0x00028050 File Offset: 0x00026250
		private bool Modify()
		{
			return true;
		}

		// Token: 0x0600013C RID: 316 RVA: 0x00028064 File Offset: 0x00026264
		private bool TextCheck()
		{
			return true;
		}

		// Token: 0x0600013D RID: 317 RVA: 0x00020760 File Offset: 0x0001E960
		private void frmReviseInfo_FormClosing(object sender, FormClosingEventArgs e)
		{
			base.DialogResult = DialogResult.Yes;
		}

		// Token: 0x0600013E RID: 318 RVA: 0x00028078 File Offset: 0x00026278
		private void dgvDataNew_SelectionChanged(object sender, EventArgs e)
		{
			bool flag = this.dgvDataNew.SelectedRows.Count > 0;
			if (flag)
			{
				this._CurrentId = int.Parse(this.dgvDataNew.SelectedRows[0].Cells[0].Value.ToString());
			}
		}

		// Token: 0x0600013F RID: 319 RVA: 0x000280D0 File Offset: 0x000262D0
		private void GetCurrentItem(int rowindex)
		{
			this._CurrentId = int.Parse(this.dgvDataNew.Rows[rowindex].Cells[0].Value.ToString());
			this.labelX2.Text = this.dgvDataNew.Rows[rowindex].Cells["C_DanHao"].Value.ToString();
		}

		// Token: 0x06000140 RID: 320 RVA: 0x00012473 File Offset: 0x00010673
		private void btnItemC_Click(object sender, EventArgs e)
		{
			this.OpenForm(typeof(frmItemChoose), ((ButtonItem)sender).Text, new object[]
			{
				"t_ticket",
				base.Name
			});
		}

		// Token: 0x06000141 RID: 321 RVA: 0x00028145 File Offset: 0x00026345
		private void rdoImportRefer_CheckedChanged(object sender, EventArgs e)
		{
			this.CheckReferRadio(false);
		}

		// Token: 0x06000142 RID: 322 RVA: 0x00028150 File Offset: 0x00026350
		private void CheckReferRadio(bool bCheck)
		{
			bool flag = !bCheck;
			if (flag)
			{
				this.btnSave.Enabled = false;
			}
			this._Act = BaseForm.FormActtion.Import;
		}

		// Token: 0x06000143 RID: 323 RVA: 0x0002817C File Offset: 0x0002637C
		private void btnRefImportRun_Click(object sender, EventArgs e)
		{
			bool @checked = this.rdoImportRefer.Checked;
			if (@checked)
			{
				bool flag = !base.ShowChoise("ImportTicWarning", "", "");
				if (flag)
				{
					return;
				}
				bool flag2 = !this.CheckImportRefer();
				if (flag2)
				{
					return;
				}
			}
			bool checked2 = this.rdoExReturn.Checked;
			if (checked2)
			{
				bool flag3 = !base.ShowChoise("ImportTicReturnWarning", "", "");
				if (flag3)
				{
					return;
				}
				this.UpdateExTicket(true);
			}
			bool checked3 = this.rdoExChange.Checked;
			if (checked3)
			{
				bool flag4 = !base.ShowChoise("ImportTicReturnWarning", "", "");
				if (flag4)
				{
					return;
				}
				this.UpdateExTicket(false);
			}
			base.ShowMsg("ImportTicSuccess", "", "");
		}

		// Token: 0x06000144 RID: 324 RVA: 0x0002825C File Offset: 0x0002645C
		private bool CheckImportRefer()
		{
			this.UpdateImportTicket();
			this.UpdateRefTicket();
			List<Dictionary<string, object>> refScaleList = this.GetRefScaleList(this._modRef.DanHao);
			bool flag = refScaleList.Count > 0;
			if (flag)
			{
				bool flag2 = !this.UpOrInImportScaleDB(refScaleList[0]);
				if (flag2)
				{
					base.ShowMsg("ImportTicketUpdateScaleError", "", "");
				}
				else
				{
					this.UpdateRefScaleDB(refScaleList[0]);
				}
			}
			this._CurrentId = this._mod.Id;
			this.LoadData();
			return true;
		}

		// Token: 0x06000145 RID: 325 RVA: 0x000282F4 File Offset: 0x000264F4
		private bool UpdateRefTicket()
		{
			List<string> list = new List<string>();
			List<object> list2 = new List<object>();
			bool flag = this._modRef.Status != 2;
			if (flag)
			{
				list.Add("Status");
				list2.Add(2);
			}
			bool flag2 = this._modRef.WeightProcess < 2;
			if (flag2)
			{
				list.Add("WeightProcess");
				list2.Add(2);
				list.Add("Loader2");
				list2.Add(this._modRef.Loader);
				list.Add("SecondTime");
				list2.Add(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
			}
			list.Add("SecondWeight");
			list2.Add(this._modRef.FirstWeight);
			list.Add("AssistActualAccount");
			list2.Add(0);
			list.Add("DifferWeight");
			list2.Add(0);
			list.Add("JWDiffer");
			list2.Add(this._modRef.JiHuaLiang + this._modRef.XianQianLiang - 0m);
			list.Add("FWDiffer");
			list2.Add(this._modRef.ShiJiLiang + this._modRef.XianQianLiang - 0m);
			list.Add("Remark");
			list2.Add(string.Concat(new string[]
			{
				this._modRef.Remark,
				ShowWords.ReplaceText("OriTwoWeight"),
				":",
				this._modRef.SecondWeight.ToString(),
				"kg;"
			}));
			DalT_ticket.Instance.Update(list, list2, this._modRef.Id);
			return true;
		}

		// Token: 0x06000146 RID: 326 RVA: 0x00028500 File Offset: 0x00026700
		private List<Dictionary<string, object>> GetRefScaleList(string danHao)
		{
			List<Dictionary<string, object>> list = new List<Dictionary<string, object>>();
			List<string> list2 = new List<string>();
			list2.Add("1 = 1 and TicketNo = '" + this._modRef.DanHao + "'");
			this.sQLHandleSE.TableName = "t_trade";
			this.sQLHandleSE.ForW = list2;
			this.sQLHandleSE.SQLHelper.MyConnectionString = ConfigSettings.Instance.ScaleNGateConn;
			list = this.sQLHandleSE.Activity();
			bool flag = list.Count == 0;
			if (flag)
			{
				base.ShowMsg("RefTicketScaleError", "", "");
			}
			return list;
		}

		// Token: 0x06000147 RID: 327 RVA: 0x000285AC File Offset: 0x000267AC
		private bool UpOrInImportScaleDB(Dictionary<string, object> dicRefScale)
		{
			List<string> list = new List<string>();
			Dictionary<string, object> dictionary = new Dictionary<string, object>();
			list.Clear();
			list.Add("1 = 1 and TicketNo = '" + this._mod.DanHao + "'");
			this.sQLHandleSE.TableName = "t_trade";
			this.sQLHandleSE.ForW = list;
			List<Dictionary<string, object>> list2 = this.sQLHandleSE.Activity();
			int num = 0;
			bool flag = list2.Count == 0;
			if (flag)
			{
				dictionary = ModelHelper.ReturnDic(dicRefScale, "");
				dictionary["TicketNo"] = this._mod.DanHao;
				dictionary["ProcessState"] = 1;
				dictionary["SecondMan"] = "";
				dictionary["SecondScale"] = 0;
				dictionary["BatchNo"] = this.GetScaleBatchNo();
			}
			else
			{
				dictionary = ModelHelper.ReturnDic(list2[0], "");
				num = Convert.ToInt32(dictionary["Id"].ToString());
			}
			dictionary.Remove("Id");
			dictionary["CardNo"] = this._modRef.CardNum;
			dictionary["TruckNo"] = this._mod.Lisence;
			dictionary["Product"] = this._mod.ProductName;
			dictionary["Sender"] = this._mod.SettlePart;
			dictionary["Receiver"] = this._mod.ClientPart;
			dictionary["ContractNum"] = this._mod.ContractNum;
			dictionary["PlannedQty"] = this._mod.JiHuaLiang;
			dictionary["AcutalQty"] = 0;
			dictionary["Spare1"] = this._mod.LoadMode;
			dictionary["Spare2"] = this._mod.SpecsDescribe;
			dictionary["Spare3"] = Convert.ToInt32(this._mod.Spare8);
			bool flag2 = num > 0;
			bool result;
			if (flag2)
			{
				this.sQLHandleUP.SQLHelper.MyConnectionString = ConfigSettings.Instance.ScaleNGateConn;
				this.sQLHandleUP.TableName = "t_trade";
				List<string> list3 = new List<string>();
				list3.Add("[Id]=" + num.ToString());
				this.sQLHandleUP.DataD = dictionary;
				this.sQLHandleUP.ForW = list3;
				bool flag3 = this.sQLHandleUP.Activity();
				result = true;
			}
			else
			{
				this.sQLHandleIN.SQLHelper.MyConnectionString = ConfigSettings.Instance.ScaleNGateConn;
				this.sQLHandleIN.TableName = "t_trade";
				this.sQLHandleIN.DataD = dictionary;
				bool flag4 = this.sQLHandleIN.Activity();
				string strsql = this.sQLHandleIN.Strsql;
				result = flag4;
			}
			return result;
		}

		// Token: 0x06000148 RID: 328 RVA: 0x000288B4 File Offset: 0x00026AB4
		private bool UpdateRefScaleDB(Dictionary<string, object> dicRefScale)
		{
			int num = Convert.ToInt32(dicRefScale["Id"].ToString());
			dicRefScale.Remove("Id");
			dicRefScale["SecondWeight"] = dicRefScale["FirstWeight"];
			dicRefScale["DifferWeight"] = 0;
			dicRefScale["UpperCaseNum"] = "零点零零";
			bool flag = dicRefScale["ProcessState"].ToString() == "1";
			if (flag)
			{
				dicRefScale["SecondTime"] = dicRefScale["FirstTime"];
				dicRefScale["SecondBodyWeight"] = dicRefScale["FirstBodyWeight"];
				dicRefScale["SecondMan"] = dicRefScale["FirstMan"];
				dicRefScale["SecondLoader"] = dicRefScale["FirstLoader"];
				dicRefScale["LoadEndTime"] = dicRefScale["LoadStartTime"];
				dicRefScale["SecondScale"] = dicRefScale["FirstScale"];
				dicRefScale["ProcessState"] = 2;
			}
			this.sQLHandleUP.SQLHelper.MyConnectionString = ConfigSettings.Instance.ScaleNGateConn;
			this.sQLHandleUP.TableName = "t_trade";
			List<string> list = new List<string>();
			list.Add("[Id]=" + num.ToString());
			this.sQLHandleUP.DataD = dicRefScale;
			this.sQLHandleUP.ForW = list;
			bool flag2 = this.sQLHandleUP.Activity();
			return true;
		}

		// Token: 0x06000149 RID: 329 RVA: 0x00028A54 File Offset: 0x00026C54
		private string GetScaleBatchNo()
		{
			string text = this._mod.ZhiDanTime.ToString("yyyyMMdd") + this._mod.Lisence;
			string result = string.Empty;
			string sql = "select top 1 * from t_trade where BatchNo like '" + text + "%' order by BatchNo Desc";
			this.sQLHandleSE.SQLHelper.MyConnectionString = ConfigSettings.Instance.ScaleNGateConn;
			List<Dictionary<string, object>> list = this.sQLHandleSE.Activity(sql);
			bool flag = list.Count == 0;
			if (flag)
			{
				result = text + "001";
			}
			else
			{
				string text2 = list[0]["BatchNo"].ToString();
				result = text + (Convert.ToInt32(text2.Substring(text2.Length - 3, 3)) + 1).ToString().PadLeft(3, '0');
			}
			return result;
		}

		// Token: 0x0600014A RID: 330 RVA: 0x00028B3C File Offset: 0x00026D3C
		private bool UpdateExTicket(bool isReturn)
		{
			this.UpdateExReturnAndChange(isReturn);
			this._CurrentId = this._mod.Id;
			this.LoadData();
			return true;
		}

		// Token: 0x0600014B RID: 331 RVA: 0x00028B70 File Offset: 0x00026D70
		private bool UpdateExReturnAndChange(bool isReturn)
		{
			Dictionary<string, object> dicRefTic = ModelHelper.ReturnDic<ModT_ticket>(this._modRef, "");
			Dictionary<string, object> dictionary = new Dictionary<string, object>();
			this.ImportAllInvStep(dicRefTic, ref dictionary);
			this.AddEnterPara(dicRefTic, ref dictionary);
			this.AddOutPara(dicRefTic, ref dictionary);
			this.AddWeightPara(isReturn, dicRefTic, ref dictionary);
			dictionary.Add("LastStep", this.GetInvStepLastStep(this._mod.InvCode, "009"));
			dictionary.Add("StepProcess", "009");
			bool flag = dictionary.ContainsKey("State");
			if (flag)
			{
				dictionary.Remove("State");
			}
			DalT_ticket.Instance.Update(dictionary, this._mod.Id);
			return true;
		}

		// Token: 0x0600014C RID: 332 RVA: 0x00028C2C File Offset: 0x00026E2C
		private bool UpdateImportTicket()
		{
			Dictionary<string, object> dictionary = ModelHelper.ReturnDic<ModT_ticket>(this._modRef, "");
			Dictionary<string, object> dictionary2 = new Dictionary<string, object>();
			bool flag = this._modRef.WeightProcess == 1;
			if (flag)
			{
				this.RecursionInvStep("005", dictionary, ref dictionary2);
				dictionary2.Add("LastStep", this.GetInvStepLastStep(this._mod.InvCode, "005"));
				dictionary2.Add("StepProcess", "005");
				bool flag2 = !dictionary2.ContainsKey("FirstWeight");
				if (flag2)
				{
					dictionary2.Add("FirstWeight", dictionary["FirstWeight"]);
				}
			}
			else
			{
				bool flag3 = this._modRef.WeightProcess == 2;
				if (flag3)
				{
					this.RecursionInvStep("009", dictionary, ref dictionary2);
					dictionary2.Add("LastStep", this.GetInvStepLastStep(this._mod.InvCode, "009"));
					dictionary2.Add("StepProcess", "009");
					this.AddWeightPara(false, dictionary, ref dictionary2);
					bool flag4 = !dictionary2.ContainsKey("SecondTime");
					if (flag4)
					{
						dictionary2.Add("SecondTime", dictionary["SecondTime"]);
					}
					bool flag5 = !dictionary2.ContainsKey("Loader2");
					if (flag5)
					{
						dictionary2.Add("Loader2", dictionary["Loader2"]);
					}
					bool flag6 = !dictionary2.ContainsKey("Status");
					if (flag6)
					{
						dictionary2.Add("Status", 2);
					}
					else
					{
						dictionary2["Status"] = 2;
					}
				}
			}
			this.AddEnterPara(dictionary, ref dictionary2);
			bool flag7 = !dictionary2.ContainsKey("WeightProcess");
			if (flag7)
			{
				dictionary2.Add("WeightProcess", this._modRef.WeightProcess);
			}
			else
			{
				dictionary2["WeightProcess"] = this._modRef.WeightProcess;
			}
			bool flag8 = !dictionary2.ContainsKey("IsCard");
			if (flag8)
			{
				dictionary2.Add("IsCard", true);
			}
			else
			{
				dictionary2["IsCard"] = true;
			}
			dictionary2.Add("CardNum", this._modRef.CardNum);
			dictionary2.Add("BatchNum", this._modRef.BatchNum);
			List<ModT_ticket> listRequire = DalT_ticket.Instance.GetListRequire("BatchNum='" + this._modRef.BatchNum.ToString() + "'", null, null);
			dictionary2.Add("CangNum", listRequire.Max((ModT_ticket o) => o.CangNum) + 1);
			DalT_ticket.Instance.Update(dictionary2, this._mod.Id);
			return true;
		}

		// Token: 0x0600014D RID: 333 RVA: 0x00028F2C File Offset: 0x0002712C
		private string GetInvStepLastStep(string invCode, string stepCode)
		{
			ModT_product modelByInvCode = DalT_product.Instance.GetModelByInvCode(invCode);
			bool flag = modelByInvCode == null;
			string result;
			if (flag)
			{
				base.ShowToast(this, "ProductHavent", "", "");
				result = stepCode;
			}
			else
			{
				List<string> list = new List<string>();
				list.Add("InvModelId=" + modelByInvCode.InvModelId.ToString());
				list.Add("StepCode='" + stepCode + "'");
				ModSrm_invstep modelRequire = DalSrm_invstep.Instance.GetModelRequire(list);
				bool flag2 = modelRequire == null;
				if (flag2)
				{
					result = stepCode;
				}
				else
				{
					result = modelRequire.LastStep;
				}
			}
			return result;
		}

		// Token: 0x0600014E RID: 334 RVA: 0x00028FD0 File Offset: 0x000271D0
		private bool RecursionInvStep(string stepCode, Dictionary<string, object> dicRefTic, ref Dictionary<string, object> dicImportData)
		{
			List<ModSrm_step> allList = DalSrm_step.Instance.GetAllList();
			ModT_product modelByInvCode = DalT_product.Instance.GetModelByInvCode(this._mod.InvCode);
			bool flag = modelByInvCode == null;
			bool result;
			if (flag)
			{
				base.ShowToast(this, "ProductHavent", "", "");
				result = false;
			}
			else
			{
				while (stepCode.Length > 0)
				{
					List<string> list = new List<string>();
					list.Add("InvModelId=" + modelByInvCode.InvModelId.ToString());
					list.Add("StepCode='" + stepCode + "'");
					ModSrm_invstep modInitInvStep = DalSrm_invstep.Instance.GetModelRequire(list);
					string text = modInitInvStep.AllowCondition.Trim();
					bool flag2 = text.Length > 0;
					if (flag2)
					{
						string[] array = text.Split(new char[]
						{
							'='
						});
						bool flag3 = array.Count<string>() >= 2;
						if (flag3)
						{
							bool flag4 = !dicImportData.ContainsKey(array[0]);
							if (flag4)
							{
								dicImportData.Add(array[0], array[1]);
							}
						}
					}
					List<ModSrm_step> list2 = (from o in allList
					where o.StepCode == modInitInvStep.StepCode
					select o).ToList<ModSrm_step>();
					bool flag5 = list2.Count > 0 && modInitInvStep.StepCode != "005";
					if (flag5)
					{
						string[] array2 = list2[0].PassBasis.Split(new char[]
						{
							'='
						});
						bool flag6 = array2.Count<string>() > 0;
						if (flag6)
						{
							bool flag7 = !dicImportData.ContainsKey(array2[0]);
							if (flag7)
							{
								dicImportData.Add(array2[0], dicRefTic[array2[0]]);
							}
						}
					}
					stepCode = modInitInvStep.LastStep;
				}
				result = true;
			}
			return result;
		}

		// Token: 0x0600014F RID: 335 RVA: 0x000291C4 File Offset: 0x000273C4
		private bool ImportAllInvStep(Dictionary<string, object> dicRefTic, ref Dictionary<string, object> dicImportData)
		{
			List<ModSrm_step> allList = DalSrm_step.Instance.GetAllList();
			ModT_product modelByInvCode = DalT_product.Instance.GetModelByInvCode(this._mod.InvCode);
			bool flag = modelByInvCode == null;
			bool result;
			if (flag)
			{
				base.ShowToast(this, "ProductHavent", "", "");
				result = false;
			}
			else
			{
				List<string> list = new List<string>();
				list.Add("InvModelId=" + modelByInvCode.InvModelId.ToString());
				List<ModSrm_invstep> listRequire = DalSrm_invstep.Instance.GetListRequire(list, null, null);
				using (List<ModSrm_invstep>.Enumerator enumerator = listRequire.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						ModSrm_invstep modInvS = enumerator.Current;
						string text = modInvS.AllowCondition.Trim();
						bool flag2 = text.Length > 0;
						if (flag2)
						{
							string[] array = text.Split(new char[]
							{
								'='
							});
							bool flag3 = array.Count<string>() >= 2;
							if (flag3)
							{
								bool flag4 = !dicImportData.ContainsKey(array[0]);
								if (flag4)
								{
									dicImportData.Add(array[0], array[1]);
								}
							}
						}
						List<ModSrm_step> list2 = (from o in allList
						where o.StepCode == modInvS.StepCode
						select o).ToList<ModSrm_step>();
						bool flag5 = list2.Count > 0;
						if (flag5)
						{
							string[] array2 = list2[0].PassBasis.Split(new char[]
							{
								'='
							});
							bool flag6 = array2.Count<string>() > 0;
							if (flag6)
							{
								bool flag7 = !dicImportData.ContainsKey(array2[0]);
								if (flag7)
								{
									dicImportData.Add(array2[0], dicRefTic[array2[0]]);
								}
							}
						}
					}
				}
				result = true;
			}
			return result;
		}

		// Token: 0x06000150 RID: 336 RVA: 0x000293B4 File Offset: 0x000275B4
		private void AddEnterPara(Dictionary<string, object> dicRefTic, ref Dictionary<string, object> dicImportData)
		{
			bool flag = !dicImportData.ContainsKey("FirstTime");
			if (flag)
			{
				dicImportData.Add("FirstTime", dicRefTic["FirstTime"]);
			}
			bool flag2 = !dicImportData.ContainsKey("EnterPosition");
			if (flag2)
			{
				dicImportData.Add("EnterPosition", dicRefTic["EnterPosition"]);
			}
			bool flag3 = !dicImportData.ContainsKey("EnterTime");
			if (flag3)
			{
				dicImportData.Add("EnterTime", dicRefTic["EnterTime"]);
			}
			bool flag4 = !dicImportData.ContainsKey("VehiclePicturePath");
			if (flag4)
			{
				dicImportData.Add("VehiclePicturePath", dicRefTic["VehiclePicturePath"]);
			}
			bool flag5 = !dicImportData.ContainsKey("VehicleMan");
			if (flag5)
			{
				dicImportData.Add("VehicleMan", dicRefTic["VehicleMan"]);
			}
			bool flag6 = !dicImportData.ContainsKey("VehicleTime");
			if (flag6)
			{
				dicImportData.Add("VehicleTime", dicRefTic["VehicleTime"]);
			}
			bool flag7 = !dicImportData.ContainsKey("IsVPicture");
			if (flag7)
			{
				dicImportData.Add("IsVPicture", dicRefTic["IsVPicture"]);
			}
			bool flag8 = !dicImportData.ContainsKey("VehicleResult");
			if (flag8)
			{
				dicImportData.Add("VehicleResult", dicRefTic["VehicleResult"]);
			}
			bool flag9 = !dicImportData.ContainsKey("VehicleCount");
			if (flag9)
			{
				dicImportData.Add("VehicleCount", dicRefTic["VehicleCount"]);
			}
			bool flag10 = !dicImportData.ContainsKey("Loader");
			if (flag10)
			{
				dicImportData.Add("Loader", dicRefTic["Loader"]);
			}
		}

		// Token: 0x06000151 RID: 337 RVA: 0x00029590 File Offset: 0x00027790
		private void AddOutPara(Dictionary<string, object> dicRefTic, ref Dictionary<string, object> dicImportData)
		{
			bool flag = !dicImportData.ContainsKey("SecondTime");
			if (flag)
			{
				dicImportData.Add("SecondTime", dicRefTic["SecondTime"]);
			}
			bool flag2 = !dicImportData.ContainsKey("LeavePosition");
			if (flag2)
			{
				dicImportData.Add("LeavePosition", dicRefTic["LeavePosition"]);
			}
			bool flag3 = !dicImportData.ContainsKey("LeaveTime");
			if (flag3)
			{
				dicImportData.Add("LeaveTime", dicRefTic["LeaveTime"]);
			}
			bool flag4 = !dicImportData.ContainsKey("Loader2");
			if (flag4)
			{
				dicImportData.Add("Loader2", dicRefTic["Loader2"]);
			}
		}

		// Token: 0x06000152 RID: 338 RVA: 0x00029654 File Offset: 0x00027854
		private void AddWeightPara(bool isReturn, Dictionary<string, object> dicRefTic, ref Dictionary<string, object> dicImportData)
		{
			if (isReturn)
			{
				bool flag = !dicImportData.ContainsKey("FirstWeight");
				if (flag)
				{
					dicImportData.Add("FirstWeight", dicRefTic["SecondWeight"]);
				}
				bool flag2 = !dicImportData.ContainsKey("SecondWeight");
				if (flag2)
				{
					dicImportData.Add("SecondWeight", dicRefTic["FirstWeight"]);
				}
			}
			else
			{
				bool flag3 = !dicImportData.ContainsKey("FirstWeight");
				if (flag3)
				{
					dicImportData.Add("FirstWeight", dicRefTic["FirstWeight"]);
				}
				bool flag4 = !dicImportData.ContainsKey("SecondWeight");
				if (flag4)
				{
					dicImportData.Add("SecondWeight", dicRefTic["SecondWeight"]);
				}
			}
			bool flag5 = !dicImportData.ContainsKey("DifferWeight");
			if (flag5)
			{
				dicImportData.Add("DifferWeight", dicRefTic["DifferWeight"]);
			}
			bool flag6 = !dicImportData.ContainsKey("JWDiffer");
			if (flag6)
			{
				dicImportData.Add("JWDiffer", dicRefTic["JWDiffer"]);
			}
			bool flag7 = !dicImportData.ContainsKey("FWDiffer");
			if (flag7)
			{
				dicImportData.Add("FWDiffer", dicRefTic["FWDiffer"]);
			}
		}

		// Token: 0x06000153 RID: 339 RVA: 0x00028145 File Offset: 0x00026345
		private void rdoExReturn_CheckedChanged(object sender, EventArgs e)
		{
			this.CheckReferRadio(false);
		}

		// Token: 0x06000154 RID: 340 RVA: 0x00028145 File Offset: 0x00026345
		private void rdoExChange_CheckedChanged(object sender, EventArgs e)
		{
			this.CheckReferRadio(false);
		}

		// Token: 0x04000253 RID: 595
		private ModT_ticket _modRef = new ModT_ticket();

		// Token: 0x04000254 RID: 596
		private List<ModT_ticket> _ListRefTicket = new List<ModT_ticket>();

		// Token: 0x04000255 RID: 597
		private ModT_ticket _mod = new ModT_ticket();

		// Token: 0x04000256 RID: 598
		private List<ModT_ticket> _list = new List<ModT_ticket>();

		// Token: 0x04000257 RID: 599
		private SQLHandleSE sQLHandleSE = new SQLHandleSE();

		// Token: 0x04000258 RID: 600
		private SQLHandleIN sQLHandleIN = new SQLHandleIN();

		// Token: 0x04000259 RID: 601
		private SQLHandleUP sQLHandleUP = new SQLHandleUP();
	}
}
