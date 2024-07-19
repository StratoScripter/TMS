using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Assistant;
using AutocompleteMenuNS;
using Base;
using DAL.Base.SQSConfig;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using DevComponents.DotNetBar.Layout;
using DevComponents.Editors;
using DevComponents.Editors.DateTimeAdv;
using ICHandle;
using InterHandle;
using LTDesign;
using Model;
using Model.SQSConfig;
using SQSClient.Properties;

namespace SQSClient
{
	// Token: 0x02000070 RID: 112
	public partial class frmTicket : BaseDialogForm
	{
		// Token: 0x060005ED RID: 1517 RVA: 0x00093454 File Offset: 0x00091654
		public frmTicket(string text, BaseForm.FormActtion act, int id, string dir)
		{
			this.InitializeComponent();
			base.Width = Screen.PrimaryScreen.Bounds.Width;
			this.SetText(this);
			this._Act = act;
			this.ControlsCheck();
		}

		// Token: 0x060005EE RID: 1518 RVA: 0x00093518 File Offset: 0x00091718
		public frmTicket()
		{
			this.InitializeComponent();
			this.SetText(this);
			this.ControlsCheck();
		}

		// Token: 0x060005EF RID: 1519 RVA: 0x000935BC File Offset: 0x000917BC
		private void ControlsCheck()
		{
			this._Controls.Clear();
			this._Controls.Add(this.bar);
			this._Controls.Add(this.dgvData);
			this._Controls.Add(this.contextMenuStrip);
			this.CheckLblAdvancedQuery();
		}

		// Token: 0x060005F0 RID: 1520 RVA: 0x00093614 File Offset: 0x00091814
		private void frmTicket_Load(object sender, EventArgs e)
		{
			BaseDialogForm._operateArgs.Category = this.Text;
			base.InitBurron();
			this.InitControl();
			this._StaticColumnCount = this.dgvData.Columns.Count;
			base.CreateDgv(this.dgvData, "c_t_ticket_" + base.Name);
			this.mDictStep = DalSrm_step.Instance.GetDicStepName();
			this.mDictStep.Add("", "");
			this.mDictStep.Add("end", ShowWords.ReplaceText("Ending"));
			this.mLocalTicketType = Settings.Instance.LocalTicketType;
			this.LoadData(0);
			this._Timer_Tick(null, null);
			this._Timer.Start();
			ModCfg_setting model = DalCfg_setting.Instance.GetModel("Item", "DumpDays");
			bool flag = model != null && model.Value != "0";
			if (flag)
			{
				string time = DateTime.Now.AddDays((double)(-(double)int.Parse(model.Value))).ToString("yyyy-MM-dd 00:00:00");
				DalT_ticket.Instance.UpdateData(time);
			}
		}

		// Token: 0x060005F1 RID: 1521 RVA: 0x00093748 File Offset: 0x00091948
		private void InitControl()
		{
			this.dtpDate.Value = DateTime.Now;
			BaseForm.EnumModel enumModel = new BaseForm.EnumModel();
			enumModel.Name = "All";
			enumModel.Description = ShowWords.ReplaceText("All");
			enumModel.Value = -1;
			List<BaseForm.EnumModel> list = new List<BaseForm.EnumModel>();
			list.Add(enumModel);
			list.AddRange(BaseForm.GetEnumModelList<TicketState>());
			list.AddRange(BaseForm.GetEnumModelList<TicketStatus>());
			BaseForm.BindDataSouce(this.cmbModifyStatus, list, "Description", "Value");
			List<BaseForm.EnumModel> list2 = new List<BaseForm.EnumModel>();
			list2.Add(enumModel);
			list2.AddRange(BaseForm.GetEnumModelList<BusinessType>());
			BaseForm.BindDataSouce(this.cmbBusinessType, list2, "Description", "Value");
			this.cmbUnit.BindDataSouce(DalCfg_unit.Instance.GetAllList(), "Name", "PinYinMa", "Id");
			this.cmbProduct.BindDataSouce(DalT_product.Instance.GetListByState(1, Settings.Instance.ProductShowType), "InvName", "PinYinMa", "InvCode");
			this.cmbStep.BindDataSouce(DalSrm_step.Instance.GetAllList(), "StepName", "PinYinMa", "StepCode");
			this.cmbWareHouse.BindDataSouce(DalCs_warehouse.Instance.GetAllList(), "WhName", "PinYinMa", "WhCode");
			this.cmbWareHouse.SelectedIndex = -1;
			List<AutocompleteItem> list3 = new List<AutocompleteItem>();
			List<ModT_truck> allList = DalT_truck.Instance.GetAllList();
			foreach (ModT_truck modT_truck in allList)
			{
				list3.Add(new MulticolumnAutocompleteItem(new string[]
				{
					modT_truck.Lisence,
					modT_truck.CoachNum
				}, modT_truck.Lisence, true, true));
			}
			AutocompleteMenu autocompleteMenu = new AutocompleteMenu();
			autocompleteMenu.MaximumSize = new Size(300, 200);
			autocompleteMenu.MinFragmentLength = 1;
			autocompleteMenu.SetAutocompleteItems(list3);
			autocompleteMenu.SetAutocompleteMenu(this.txtGuanNum, autocompleteMenu);
			this.MaxFWDifferSetting = DalCfg_setting.Instance.GetModel("Item", "MaxFWDiffer");
			bool accountRemindEnable = Settings.Instance.AccountRemindEnable;
			if (accountRemindEnable)
			{
				this._TimerM.Interval = 2000;
				this._TimerM.Tick += this._TimerM_Tick;
				this._TimerM.Start();
			}
			bool flag = this._Timer != null;
			if (!flag)
			{
				object obj = frmTicket.lockobj;
				lock (obj)
				{
					try
					{
						this._Timer = new Timer();
						this._Timer.Interval = 2000;
						this._Timer.Tick += this._Timer_Tick;
					}
					catch
					{
						base.ShowMsg(Messages.CardReadError, "", "");
					}
				}
			}
		}

		// Token: 0x060005F2 RID: 1522 RVA: 0x00093A78 File Offset: 0x00091C78
		private void LoadData(int selectindex)
		{
			this.dgvData.Rows.Clear();
			this.GetList();
			bool flag = this._list.Count > Settings.Instance.ShowTicketMaxCount;
			if (flag)
			{
				base.ShowToast(this, string.Format(ShowWords.ReplaceText("ShowTicketTooMax"), Settings.Instance.ShowTicketMaxCount), "", "");
			}
			else
			{
				int jieSuanLiangDecimal = Settings.Instance.JieSuanLiangDecimal;
				int num = 0;
				foreach (ModT_ticket modT_ticket in this._list)
				{
					object[] array = new object[this.dgvData.ColumnCount];
					int num2 = 0;
					array[num2++] = modT_ticket.Id;
					array[num2++] = modT_ticket.DanHao;
					array[num2++] = modT_ticket.CardNum;
					array[num2++] = modT_ticket.ContractNum;
					array[num2++] = ShowWords.ReplaceText(EnumHelper.GetDescription<BusinessType>((BusinessType)modT_ticket.BusinessType));
					array[num2++] = modT_ticket.ClientPart;
					array[num2++] = modT_ticket.SettlePart;
					array[num2++] = modT_ticket.Lisence;
					array[num2++] = modT_ticket.CangNum;
					array[num2++] = modT_ticket.UnitName;
					object[] array2 = array;
					int num3 = num2++;
					ModT_tank model = DalT_tank.Instance.GetModel("Code", modT_ticket.TankCode);
					array2[num3] = ((model != null) ? model.Name : null);
					array[num2++] = modT_ticket.InvCode;
					array[num2++] = modT_ticket.ProductName;
					array[num2++] = modT_ticket.JiHuaLiang;
					array[num2++] = modT_ticket.ShiJiLiang;
					array[num2++] = modT_ticket.FirstWeight;
					array[num2++] = modT_ticket.SecondWeight;
					array[num2++] = modT_ticket.DifferWeight;
					array[num2++] = modT_ticket.FWDiffer;
					array[num2++] = ((jieSuanLiangDecimal > -1) ? Math.Round(modT_ticket.JieSuanLiang, jieSuanLiangDecimal, MidpointRounding.AwayFromZero) : modT_ticket.JieSuanLiang);
					array[num2++] = modT_ticket.DanWei;
					array[num2++] = ShowWords.ReplaceText(EnumHelper.GetDescription<TicketStatus>((TicketStatus)modT_ticket.Status));
					array[num2++] = ShowWords.ReplaceText(EnumHelper.GetDescription<TicketState>((TicketState)modT_ticket.State));
					array[num2++] = ShowWords.ReplaceText(EnumHelper.GetDescription<AccountType>((AccountType)modT_ticket.AccountType));
					array[num2++] = ((modT_ticket.StepProcess != null) ? this.mDictStep[modT_ticket.StepProcess] : "");
					array[num2++] = modT_ticket.ZhiDanRen;
					array[num2++] = modT_ticket.ZhiDanTime.ToString("yyyy-MM-dd HH:mm:ss");
					bool flag2 = modT_ticket.Status >= 2;
					if (flag2)
					{
						array[num2++] = modT_ticket.StartTime.ToString("yyyy-MM-dd HH:mm:ss");
						array[num2++] = modT_ticket.EndTime.ToString("yyyy-MM-dd HH:mm:ss");
					}
					else
					{
						bool flag3 = modT_ticket.Status >= 1;
						if (flag3)
						{
							array[num2++] = modT_ticket.StartTime.ToString("yyyy-MM-dd HH:mm:ss");
							array[num2++] = "";
						}
						else
						{
							array[num2++] = "";
							array[num2++] = "";
						}
					}
					bool flag4 = modT_ticket.State >= 1;
					if (flag4)
					{
						array[num2++] = modT_ticket.JieSuanTime.ToString("yyyy-MM-dd HH:mm:ss");
						array[num2++] = modT_ticket.JieSuanRen;
					}
					else
					{
						array[num2++] = "";
						array[num2++] = "";
					}
					for (int i = this._StaticColumnCount; i < this.dgvData.ColumnCount; i++)
					{
						array[i] = base.GetValueMod<ModT_ticket>(modT_ticket, this.dgvData.Columns[i].DataPropertyName);
					}
					this.dgvData.Rows.Add(array);
					bool flag5 = Math.Abs(modT_ticket.FWDiffer) > decimal.Parse(this.MaxFWDifferSetting.Value);
					if (flag5)
					{
						this.dgvData.Rows[num].Cells["C_FWDiffer"].Style.BackColor = Color.Red;
					}
					num++;
				}
				bool flag6 = this.dgvData.Rows.Count > 0;
				if (flag6)
				{
					this.mSelectIndex = ((selectindex > this.dgvData.Rows.Count - 1) ? 0 : selectindex);
					this.dgvData.Rows[this.mSelectIndex].Selected = true;
					this.GetCurrentItem(this.mSelectIndex);
				}
				else
				{
					this.btnAdjust.Enabled = false;
					this.btnModify.Enabled = false;
					this.btnDelete.Enabled = false;
					this.btnPrint.Enabled = false;
					this.btnSettle.Enabled = false;
				}
				this.labCount.Text = ShowWords.ReplaceText("Orders") + " " + this.dgvData.RowCount.ToString();
			}
		}

		// Token: 0x060005F3 RID: 1523 RVA: 0x000940A0 File Offset: 0x000922A0
		private void GetList()
		{
			int num = -1;
			int num2 = -1;
			bool flag = this.cmbModifyStatus.SelectedIndex > 3;
			if (flag)
			{
				num = (int)this.cmbModifyStatus.SelectedValue;
			}
			else
			{
				bool flag2 = this.cmbModifyStatus.SelectedIndex > 0;
				if (flag2)
				{
					num2 = (int)this.cmbModifyStatus.SelectedValue;
				}
			}
			List<string> list = new List<string>();
			bool flag3 = !string.IsNullOrWhiteSpace(this.cmbUnit.Text);
			if (flag3)
			{
				list.Add("UnitName='" + this.cmbUnit.Text + "'");
			}
			bool flag4 = !string.IsNullOrWhiteSpace(this.cmbProduct.Text);
			if (flag4)
			{
				List<string> list2 = list;
				string str = "InvCode='";
				object selectedValue = this.cmbProduct.SelectedValue;
				list2.Add(str + ((selectedValue != null) ? selectedValue.ToString() : null) + "'");
			}
			bool flag5 = !string.IsNullOrWhiteSpace(this.txtGuanNum.Text);
			if (flag5)
			{
				list.Add("Lisence='" + this.txtGuanNum.Text + "'");
			}
			bool flag6 = !string.IsNullOrWhiteSpace(this.txtCardNum.Text);
			if (flag6)
			{
				list.Add("CardNum='" + this.txtCardNum.Text + "'");
			}
			bool flag7 = !string.IsNullOrWhiteSpace(this.cmbStep.Text);
			if (flag7)
			{
				List<string> list3 = list;
				string str2 = "StepProcess='";
				object selectedValue2 = this.cmbStep.SelectedValue;
				list3.Add(str2 + ((selectedValue2 != null) ? selectedValue2.ToString() : null) + "'");
			}
			bool flag8 = !string.IsNullOrWhiteSpace(this.tbxDanHao.Text.Trim());
			if (flag8)
			{
				list.Add(string.Concat(new string[]
				{
					"(DanHao like '%",
					this.tbxDanHao.Text.Trim(),
					"%' or ContractNum like '%",
					this.tbxDanHao.Text.Trim(),
					"%')"
				}));
			}
			bool flag9 = num > -1;
			if (flag9)
			{
				list.Add("Status='" + num.ToString() + "'");
			}
			bool flag10 = num2 > -1;
			if (flag10)
			{
				list.Add("State='" + num2.ToString() + "'");
			}
			bool flag11 = (int)this.cmbBusinessType.SelectedValue > -1;
			if (flag11)
			{
				list.Add("BusinessType='" + ((int)this.cmbBusinessType.SelectedValue).ToString() + "'");
			}
			bool flag12 = this.cmbWareHouse.Text.Trim().Length > 0;
			if (flag12)
			{
				list.Add("StoreName='" + this.cmbWareHouse.Text.Trim() + "'");
			}
			bool flag13 = this.chkIsUseDate.Checked && this.mFormulas.Count == 0;
			if (flag13)
			{
				list.Add("EndTime>='" + this.dtpDate.Value.ToString("yyyy-MM-dd 00:00:00") + "'");
				list.Add("EndTime<='" + this.dtpDate.Value.AddDays(1.0).ToString("yyyy-MM-dd 00:00:00") + "'");
			}
			bool manageself = GlobalKey.Manageself;
			if (manageself)
			{
				list.Add("ZhiDanRen='" + GlobalKey.UserName + "'");
			}
			bool flag14 = !string.IsNullOrWhiteSpace(this._ExtCondition);
			if (flag14)
			{
				list.Add(this._ExtCondition);
			}
			bool flag15 = this.mLocalTicketType > 0;
			if (flag15)
			{
				list.Add("TicketType=" + this.mLocalTicketType.ToString());
			}
			bool flag16 = this.mFormulas.Count > 0;
			if (flag16)
			{
				list.AddRange(this.mFormulas);
			}
			bool flag17 = Settings.Instance.BusinessControlType > 0;
			if (flag17)
			{
				list.Add("BusinessType=" + Settings.Instance.BusinessControlType.ToString());
			}
			bool flag18 = Settings.Instance.CompanyGroup > 0;
			if (flag18)
			{
				list.Add("InvCode IN (select InvCode from t_product WHERE (CompanyGroup = 0 or CompanyGroup = " + Settings.Instance.CompanyGroup.ToString() + ") and State = 1)");
			}
			this._list = DalT_ticket.Instance.GetListRequire(list, new List<string>
			{
				"Id desc"
			}, null);
		}

		// Token: 0x060005F4 RID: 1524 RVA: 0x00094568 File Offset: 0x00092768
		private void _Timer_Tick(object sender, EventArgs e)
		{
			try
			{
				string text = "";
				object obj = frmTicket.lockobj;
				lock (obj)
				{
					text = ICTicket.ReadCardNum();
				}
				bool flag2 = text == null;
				if (flag2)
				{
					this._Timer.Stop();
				}
				else
				{
					bool flag3 = this.cardNum == text;
					if (!flag3)
					{
						this.cardNum = text;
						bool flag4 = this.cardNum.Length == 0;
						if (!flag4)
						{
							bool flag5 = !this.isEditOpen;
							if (flag5)
							{
								List<ModT_ticket> ticketsByCardNum = DalT_ticket.Instance.GetTicketsByCardNum(this.cardNum, 0, this.mLocalTicketType);
								bool flag6 = ticketsByCardNum.Count > 0;
								if (flag6)
								{
									this.mSelectIndex = 0;
									this._CurrentId = ticketsByCardNum[0].Id;
									this.isEditOpen = true;
									this._Timer.Stop();
									BaseDialogForm baseDialogForm = base.CreateInstance<BaseDialogForm>(typeof(frmReviseAccount), this.btnSettle.Text, BaseForm.FormActtion.Modify, this._FrmName);
									bool flag7 = this._Mod != null;
									if (flag7)
									{
										baseDialogForm._ParentMenuId = this._Mod.MenuId;
									}
									baseDialogForm.Sender = this.btnSettle;
									bool flag8 = baseDialogForm.ShowDialog() == DialogResult.Yes;
									if (flag8)
									{
										this.LoadData(this.mSelectIndex);
									}
									this._Timer.Start();
									this.isEditOpen = false;
								}
							}
						}
					}
				}
			}
			catch (SerialPortException ex)
			{
				this._Timer.Stop();
			}
		}

		// Token: 0x060005F5 RID: 1525 RVA: 0x00094738 File Offset: 0x00092938
		private void _TimerM_Tick(object sender, EventArgs e)
		{
			List<string> list = new List<string>();
			list.Add("SecondWeight>'5000'");
			list.Add("SecondTime<'" + DateTime.Now.AddMinutes((double)(-(double)Settings.Instance.AccountTimeOut)).ToString("yyyy-MM-dd HH:mm:ss") + "'");
			list.Add("State='0'");
			List<ModT_ticket> listRequire = DalT_ticket.Instance.GetListRequire(list, new List<string>
			{
				"Id desc"
			}, null);
			bool flag = listRequire.Count > 0;
			if (flag)
			{
				this.labMessage.Text = ShowWords.ReplaceText(Messages.AccountRemind);
			}
			else
			{
				this.labMessage.Text = "";
			}
		}

		// Token: 0x060005F6 RID: 1526 RVA: 0x000947F8 File Offset: 0x000929F8
		private void btnAdd_Click(object sender, EventArgs e)
		{
			this.mSelectIndex = 0;
			this.OpenForm((ButtonItem)sender, BaseForm.FormActtion.Add, this._FrmName);
		}

		// Token: 0x060005F7 RID: 1527 RVA: 0x00094816 File Offset: 0x00092A16
		private void btnModify_Click(object sender, EventArgs e)
		{
			this.OpenForm((ButtonItem)sender, BaseForm.FormActtion.Modify, this._FrmName);
		}

		// Token: 0x060005F8 RID: 1528 RVA: 0x00094830 File Offset: 0x00092A30
		private void btnImport_Click(object sender, EventArgs e)
		{
			this.mSelectIds = "";
			for (int i = 0; i < this.dgvData.SelectedRows.Count; i++)
			{
				this.mSelectIds = this.mSelectIds + this.dgvData.Rows[this.dgvData.SelectedRows[i].Index].Cells[0].Value.ToString() + ",";
			}
			this.mSelectIds = this.mSelectIds.Trim(new char[]
			{
				','
			});
			base.DialogResult = DialogResult.Yes;
		}

		// Token: 0x060005F9 RID: 1529 RVA: 0x000948E0 File Offset: 0x00092AE0
		protected void OpenForm(ButtonItem sender, BaseForm.FormActtion action, string d)
		{
			bool flag = !this._canModify && action == BaseForm.FormActtion.Modify;
			if (!flag)
			{
				BaseDialogForm baseDialogForm = base.CreateInstance<BaseDialogForm>(typeof(frmTicketEdit), sender.Text, action, d);
				bool flag2 = this._Mod != null;
				if (flag2)
				{
					baseDialogForm._ParentMenuId = this._Mod.MenuId;
				}
				baseDialogForm.Sender = sender;
				this.isEditOpen = true;
				bool flag3 = baseDialogForm.ShowDialog() == DialogResult.Yes;
				if (flag3)
				{
					this.LoadData(this.mSelectIndex);
				}
				this.isEditOpen = false;
			}
		}

		// Token: 0x060005FA RID: 1530 RVA: 0x00094970 File Offset: 0x00092B70
		private void btnDelete_Click(object sender, EventArgs e)
		{
			BaseDialogForm._operateArgs.OperateType = ((ButtonItem)sender).Text;
			bool flag = !base.ShowChoise(Messages.DeleteSure, "", "");
			if (!flag)
			{
				int id = Convert.ToInt32(this.dgvData.SelectedRows[0].Cells["C_Id"].Value);
				ModT_ticket model = DalT_ticket.Instance.GetModel(id);
				bool flag2 = !DalT_ticket.Instance.Delete(id);
				if (flag2)
				{
					this.OnOperateFail(model, false);
					base.ShowMsg(Messages.DeleteFalse, "", "");
				}
				else
				{
					this.OnOperateSuccess(model, true);
					DalT_queue.Instance.DeleteQuereByTicket(model);
					this.mSelectIndex = 0;
					this.LoadData(0);
				}
			}
		}

		// Token: 0x060005FB RID: 1531 RVA: 0x00094A50 File Offset: 0x00092C50
		private void btnSettle_Click(object sender, EventArgs e)
		{
			BaseDialogForm baseDialogForm = base.CreateInstance<BaseDialogForm>(typeof(frmReviseAccount), ((ButtonItem)sender).Text, BaseForm.FormActtion.Modify, this._FrmName);
			bool flag = this._Mod != null;
			if (flag)
			{
				baseDialogForm._ParentMenuId = this._Mod.MenuId;
			}
			baseDialogForm.Sender = sender;
			this.isEditOpen = true;
			bool flag2 = baseDialogForm.ShowDialog() == DialogResult.Yes;
			if (flag2)
			{
				this.LoadData(this.mSelectIndex);
			}
			this.isEditOpen = false;
		}

		// Token: 0x060005FC RID: 1532 RVA: 0x00094AD4 File Offset: 0x00092CD4
		private void btnAdjust_Click(object sender, EventArgs e)
		{
			BaseDialogForm baseDialogForm = base.CreateInstance<BaseDialogForm>(typeof(frmReviseBuDan), ((ButtonItem)sender).Text, BaseForm.FormActtion.Modify, this._FrmName);
			bool flag = this._Mod != null;
			if (flag)
			{
				baseDialogForm._ParentMenuId = this._Mod.MenuId;
			}
			baseDialogForm.Sender = sender;
			this.isEditOpen = true;
			bool flag2 = baseDialogForm.ShowDialog() == DialogResult.Yes;
			if (flag2)
			{
				this.LoadData(this.mSelectIndex);
			}
			this.isEditOpen = false;
		}

		// Token: 0x060005FD RID: 1533 RVA: 0x00094B58 File Offset: 0x00092D58
		private void btnPrint_Click(object sender, EventArgs e)
		{
			this._list = DalT_ticket.Instance.GetList("BatchNum", this.selectMod.BatchNum);
			frmPrintChoise frmPrintChoise = new frmPrintChoise(((ButtonItem)sender).Text, this.selectMod, this._list);
			bool flag = frmPrintChoise.ShowDialog() == DialogResult.Yes;
			if (flag)
			{
			}
		}

		// Token: 0x060005FE RID: 1534 RVA: 0x00094BB8 File Offset: 0x00092DB8
		private void btnCard_Click(object sender, EventArgs e)
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

		// Token: 0x060005FF RID: 1535 RVA: 0x00094C08 File Offset: 0x00092E08
		private void btnQuery_Click(object sender, EventArgs e)
		{
			this.LoadData(this.mSelectIndex);
			this.mFormulas.Clear();
			this.CheckLblAdvancedQuery();
		}

		// Token: 0x06000600 RID: 1536 RVA: 0x00094C2C File Offset: 0x00092E2C
		private void dgvTiDan_SelectionChanged(object sender, EventArgs e)
		{
			bool flag = this.dgvData.SelectedRows.Count > 0;
			if (flag)
			{
				this._CurrentId = int.Parse(this.dgvData.SelectedRows[0].Cells[0].Value.ToString());
				this.selectMod = DalT_ticket.Instance.GetModel("Id", this._CurrentId);
				bool flag2 = this.selectMod.Status > 0;
				if (flag2)
				{
					this.btnModify.Enabled = true;
					this.btnDelete.Enabled = false;
					this.btnPrint.Enabled = true;
					this.btnSettle.Enabled = true;
				}
				else
				{
					this.btnModify.Enabled = true;
					this.btnDelete.Enabled = true;
					this.btnPrint.Enabled = true;
					this.btnSettle.Enabled = true;
				}
				bool flag3 = this.selectMod.State < 1;
				if (flag3)
				{
					this.btnAdjust.Enabled = true;
				}
				else
				{
					this.btnAdjust.Enabled = false;
				}
			}
		}

		// Token: 0x06000601 RID: 1537 RVA: 0x00094D5C File Offset: 0x00092F5C
		private void frmTicket_FormClosing(object sender, FormClosingEventArgs e)
		{
			bool flag = this._Timer != null;
			if (flag)
			{
				this._Timer.Stop();
				this._Timer.Dispose();
			}
			bool flag2 = this._TimerM != null;
			if (flag2)
			{
				this._TimerM.Stop();
				this._TimerM.Dispose();
			}
			base.Dispose();
		}

		// Token: 0x06000602 RID: 1538 RVA: 0x00094DC0 File Offset: 0x00092FC0
		private void dgvTiDan_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			bool flag = e.RowIndex >= 0;
			if (flag)
			{
				this.GetCurrentItem(e.RowIndex);
				this.mSelectIndex = e.RowIndex;
			}
		}

		// Token: 0x06000603 RID: 1539 RVA: 0x00094DFC File Offset: 0x00092FFC
		private void dgvTiDan_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			bool flag = e.RowIndex >= 0;
			if (flag)
			{
				this.mSelectIndex = e.RowIndex;
				this.OpenForm(this.btnModify, BaseForm.FormActtion.Modify, this._FrmName);
			}
		}

		// Token: 0x06000604 RID: 1540 RVA: 0x00094E3C File Offset: 0x0009303C
		private void GetCurrentItem(int rowindex)
		{
			this._CurrentId = int.Parse(this.dgvData.Rows[rowindex].Cells[0].Value.ToString());
			this._CurrentItemName = this.dgvData.Rows[rowindex].Cells["C_DanHao"].Value.ToString();
		}

		// Token: 0x06000605 RID: 1541 RVA: 0x00094EAC File Offset: 0x000930AC
		private void dgvData_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			bool flag = e.RowIndex >= 0;
			if (flag)
			{
				this.GetCurrentItem(e.RowIndex);
				this.mSelectIndex = e.RowIndex;
			}
		}

		// Token: 0x06000606 RID: 1542 RVA: 0x00094EE8 File Offset: 0x000930E8
		private void dgvData_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
		{
			bool flag = e.RowIndex >= 0;
			if (flag)
			{
				this.GetCurrentItem(e.RowIndex);
				this.mSelectIndex = e.RowIndex;
				this.dgvData.ClearSelection();
				this.dgvData.Rows[e.RowIndex].Selected = true;
				this.dgvData.CurrentCell = this.dgvData.Rows[e.RowIndex].Cells[e.ColumnIndex];
				bool flag2 = e.Button == MouseButtons.Right;
				if (flag2)
				{
				}
			}
		}

		// Token: 0x06000607 RID: 1543 RVA: 0x00094F94 File Offset: 0x00093194
		private void ResetMenuStrips()
		{
			foreach (object obj in this.contextMenuStrip.Items)
			{
				ToolStripMenuItem toolStripMenuItem = (ToolStripMenuItem)obj;
				toolStripMenuItem.Enabled = false;
			}
		}

		// Token: 0x06000608 RID: 1544 RVA: 0x00094FF8 File Offset: 0x000931F8
		private void toolReceiptCapture_Click(object sender, EventArgs e)
		{
			bool flag = new frmDocCamView(((ToolStripMenuItem)sender).Text, BaseForm.FormActtion.Add, this._CurrentId)
			{
				DocType = DocType.Receipt
			}.ShowDialog() == DialogResult.OK;
			if (flag)
			{
				base.ShowMsg(Messages.SaveTrue, "", "");
			}
		}

		// Token: 0x06000609 RID: 1545 RVA: 0x0009504C File Offset: 0x0009324C
		private void toolCheckRequest_Click(object sender, EventArgs e)
		{
			Dictionary<string, object> dictionary = new Dictionary<string, object>();
			dictionary.Add("LabStatus", 1);
			dictionary.Add("LabTime", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
			DalT_ticket.Instance.Update(dictionary, this._CurrentId);
		}

		// Token: 0x0600060A RID: 1546 RVA: 0x00012473 File Offset: 0x00010673
		private void btnItemC_Click(object sender, EventArgs e)
		{
			this.OpenForm(typeof(frmItemChoose), ((ButtonItem)sender).Text, new object[]
			{
				"t_ticket",
				base.Name
			});
		}

		// Token: 0x0600060B RID: 1547 RVA: 0x000950A4 File Offset: 0x000932A4
		private void btnProBatch_Click(object sender, EventArgs e)
		{
			bool flag = this.dgvData.SelectedRows.Count == 0;
			if (!flag)
			{
				int id = int.Parse(this.dgvData.SelectedRows[0].Cells[0].Value.ToString());
				bool flag2 = this._TicketBatchModel == "TicketHouse";
				if (flag2)
				{
					frmTicketBatchSubHouse frmTicketBatchSubHouse = new frmTicketBatchSubHouse(ShowWords.ReplaceText(this._TicketBatchModel), BaseForm.FormActtion.Import, id, "");
					bool flag3 = frmTicketBatchSubHouse.ShowDialog() == DialogResult.OK;
					if (flag3)
					{
						base.ShowMsg(Messages.SaveTrue, "", "");
					}
				}
				else
				{
					bool flag4 = this._TicketBatchModel == "TicketBatch";
					if (flag4)
					{
						frmTicketBatchShow frmTicketBatchShow = new frmTicketBatchShow(ShowWords.ReplaceText(this._TicketBatchModel), BaseForm.FormActtion.Import, id, "");
						bool flag5 = frmTicketBatchShow.ShowDialog() == DialogResult.OK;
						if (flag5)
						{
							base.ShowMsg(Messages.SaveTrue, "", "");
						}
					}
					else
					{
						frmTicketBatchSubQuality frmTicketBatchSubQuality = new frmTicketBatchSubQuality(ShowWords.ReplaceText(this._TicketBatchModel), BaseForm.FormActtion.Import, id, "");
						bool flag6 = frmTicketBatchSubQuality.ShowDialog() == DialogResult.OK;
						if (flag6)
						{
							base.ShowMsg(Messages.SaveTrue, "", "");
						}
					}
				}
			}
		}

		// Token: 0x0600060C RID: 1548 RVA: 0x000951F4 File Offset: 0x000933F4
		private void toolProcessBack_Click(object sender, EventArgs e)
		{
			bool flag = !base.ShowChoise("ProcessBackSure", "", "");
			if (!flag)
			{
				bool flag2 = this.selectMod.State > 0;
				if (flag2)
				{
					base.ShowMsg("TicketSettlementNotBackProcess", "", "");
				}
				else
				{
					bool flag3 = this.selectMod.StepProcess != this.selectMod.LastStep;
					if (flag3)
					{
						ModSrm_step model = DalSrm_step.Instance.GetModel("StepCode", this.selectMod.StepProcess);
						Dictionary<string, object> dictionary = new Dictionary<string, object>();
						string[] array = model.ResetBasis.Split(new char[]
						{
							'='
						});
						bool flag4 = array.Length > 1;
						if (flag4)
						{
							dictionary.Add(array[0], array[1]);
							dictionary.Add("StepProcess", this.selectMod.LastStep);
							bool flag5 = DalT_ticket.Instance.Update(dictionary, this.selectMod.Id);
							if (flag5)
							{
								this.OnOperateSuccess(DalT_ticket.Instance.GetModel(this.selectMod.Id), true);
							}
							else
							{
								this.OnOperateFail(DalT_ticket.Instance.GetModel(this.selectMod.Id), false);
							}
						}
					}
					base.ShowMsg("ProcessBackSuccess", "", "");
				}
			}
		}

		// Token: 0x0600060D RID: 1549 RVA: 0x00003040 File Offset: 0x00001240
		private void toolprocessSkip_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600060E RID: 1550 RVA: 0x00095368 File Offset: 0x00093568
		private void panelExProcess_DoubleClick(object sender, EventArgs e)
		{
			try
			{
				string fileName = string.Empty;
				fileName = ConfigurationManager.AppSettings["ProcessStart"].ToString();
				Process.Start(fileName);
			}
			catch
			{
			}
		}

		// Token: 0x0600060F RID: 1551 RVA: 0x000953B4 File Offset: 0x000935B4
		private void btnExport_Click(object sender, EventArgs e)
		{
			base.ExportExcel(this.dgvData);
		}

		// Token: 0x06000610 RID: 1552 RVA: 0x000953C4 File Offset: 0x000935C4
		private void toolCuttingWeight_Click(object sender, EventArgs e)
		{
			bool flag = !base.ShowChoise("CuttingWeightSure", "", "");
			if (!flag)
			{
				bool flag2 = this.selectMod.Status < 2;
				if (flag2)
				{
					Dictionary<string, object> dictionary = new Dictionary<string, object>();
					dictionary.Add("Status", 3);
					DalT_ticket.Instance.Update(dictionary, this.selectMod.Id);
					base.ShowMsg("OutDoorHandSuccess", "", "");
				}
				else
				{
					base.ShowMsg("NotCuttingTicketFinish", "", "");
				}
			}
		}

		// Token: 0x06000611 RID: 1553 RVA: 0x00095468 File Offset: 0x00093668
		private void toolOutDoorHand_Click(object sender, EventArgs e)
		{
			bool flag = !base.ShowChoise("OutDoorHandSure", "", "");
			if (!flag)
			{
				bool flag2 = this.selectMod.State >= 1;
				if (flag2)
				{
					Dictionary<string, object> dictionary = new Dictionary<string, object>();
					dictionary.Add("LeavePosition", this.selectMod.EnterPosition);
					dictionary.Add("LeaveTime", this.selectMod.EnterTime);
					dictionary.Add("GateProcess", 2);
					DalT_ticket.Instance.Update(dictionary, this.selectMod.Id);
				}
				base.ShowMsg("OutDoorHandSuccess", "", "");
			}
		}

		// Token: 0x06000612 RID: 1554 RVA: 0x00095524 File Offset: 0x00093724
		private void btnAdvancedQuery_Click(object sender, EventArgs e)
		{
			this.mFormulas.Clear();
			frmAdvancedQuery frmAdvancedQuery = new frmAdvancedQuery(this.Text);
			bool flag = frmAdvancedQuery.ShowDialog() == DialogResult.Yes;
			if (flag)
			{
				this.mFormulas = frmAdvancedQuery.mFormulas;
			}
			this.CheckLblAdvancedQuery();
		}

		// Token: 0x06000613 RID: 1555 RVA: 0x0009556C File Offset: 0x0009376C
		private void CheckLblAdvancedQuery()
		{
			this.lblAdvancedQuery.Visible = (this.mFormulas.Count > 0);
		}

		// Token: 0x06000614 RID: 1556 RVA: 0x0009558C File Offset: 0x0009378C
		private void btnNoSettle_Click(object sender, EventArgs e)
		{
			List<string> list = new List<string>();
			List<object> list2 = new List<object>();
			list.Add("State");
			list.Add("DataReturn");
			list2.Add(0);
			list2.Add(0);
			DalT_ticket.Instance.Update(list, list2, this._CurrentId);
			base.ShowToast(this, "NoSettle", "", "");
		}

		// Token: 0x06000615 RID: 1557 RVA: 0x00095604 File Offset: 0x00093804
		private void toolPrintQuality_Click(object sender, EventArgs e)
		{
			Image image = this.PrintQuality(this.selectMod.QualityPicturePath);
			bool flag = image != null;
			if (flag)
			{
				List<Image> list = new List<Image>();
				list.Add(image);
				new Printer
				{
					List = list
				}.Print(Settings.Instance.LoadPrinter);
			}
		}

		// Token: 0x06000616 RID: 1558 RVA: 0x0009565C File Offset: 0x0009385C
		private Image PrintQuality(string path)
		{
			Image result;
			try
			{
				SOAPHandle soaphandle = new SOAPHandle();
				soaphandle.URL = ConfigurationManager.AppSettings["WebServiceUrl"];
				Dictionary<string, object> dictionary = new Dictionary<string, object>();
				dictionary.Add("path", path);
				soaphandle.MethodName = "GetFile";
				soaphandle.Paras = dictionary;
				object obj = soaphandle.Activity();
				Dictionary<string, object> dictionary2 = obj.ChangeD();
				bool flag = dictionary2["Code"].ToString() != "1";
				if (flag)
				{
					base.ShowMsg(dictionary2["Info"].ToString(), "", "");
					result = null;
				}
				else
				{
					byte[] array = Convert.FromBase64String(dictionary2["Data"].ToString());
					MemoryStream memoryStream = new MemoryStream();
					for (int i = 0; i < array.Length; i++)
					{
						memoryStream.WriteByte(array[i]);
					}
					Image b = Image.FromStream(memoryStream);
					result = ImageHandle.GetThumbnail(b, 1150, 820);
				}
			}
			catch
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06000617 RID: 1559 RVA: 0x00095780 File Offset: 0x00093980
		private void toolPhotoAround_Click(object sender, EventArgs e)
		{
			frmPhotoAround frmPhotoAround = new frmPhotoAround(this.selectMod.DanHao);
			frmPhotoAround.ShowDialog();
		}

		// Token: 0x06000618 RID: 1560 RVA: 0x000957A8 File Offset: 0x000939A8
		private void btnAddFast_Click(object sender, EventArgs e)
		{
			bool flag = this._CurrentId == 0;
			if (flag)
			{
				base.ShowToast(this, "NotSelected", "", "");
			}
			else
			{
				BaseDialogForm baseDialogForm = base.CreateInstance<BaseDialogForm>(typeof(frmTicketReference), ((ButtonItem)sender).Text, BaseForm.FormActtion.Add, this._FrmName);
				bool flag2 = this._Mod != null;
				if (flag2)
				{
					baseDialogForm._ParentMenuId = this._Mod.MenuId;
				}
				baseDialogForm.Sender = sender;
				this.isEditOpen = true;
				bool flag3 = baseDialogForm.ShowDialog() == DialogResult.Yes;
				if (flag3)
				{
					this.LoadData(this.mSelectIndex);
				}
				this.isEditOpen = false;
			}
		}

		// Token: 0x06000619 RID: 1561 RVA: 0x00095854 File Offset: 0x00093A54
		private void btnSummary_Click(object sender, EventArgs e)
		{
			bool flag = this._list.Count > 0;
			if (flag)
			{
				frmTicketSummary frmTicketSummary = new frmTicketSummary(ShowWords.ReplaceText("TicketSummary"), BaseForm.FormActtion.Import, this._list, "");
				bool flag2 = frmTicketSummary.ShowDialog() == DialogResult.OK;
				if (flag2)
				{
					base.ShowMsg(Messages.SaveTrue, "", "");
				}
			}
		}

		// Token: 0x0600061A RID: 1562 RVA: 0x000958BC File Offset: 0x00093ABC
		private void ViewTicketProcessToolStripMenuItem_Click(object sender, EventArgs e)
		{
			bool flag = this.selectMod == null;
			if (flag)
			{
				base.ShowToast(this, "NotSelected", "", "");
			}
			else
			{
				frmOrgChart frmOrgChart = new frmOrgChart(this.selectMod);
				frmOrgChart.ShowDialog();
			}
		}

		// Token: 0x0600061B RID: 1563 RVA: 0x00095904 File Offset: 0x00093B04
		private void toolWeightDetails_Click(object sender, EventArgs e)
		{
			frmWeightDetails frmWeightDetails = new frmWeightDetails(this._CurrentId);
			frmWeightDetails.ShowDialog();
		}

		// Token: 0x0600061C RID: 1564 RVA: 0x00095928 File Offset: 0x00093B28
		private void btnSearchVehicle_Click(object sender, EventArgs e)
		{
			frmSearchVehicle frmSearchVehicle = new frmSearchVehicle(this._CurrentId);
			frmSearchVehicle.ShowDialog();
		}

		// Token: 0x04000A2E RID: 2606
		private List<string> mFormulas = new List<string>();

		// Token: 0x04000A2F RID: 2607
		private List<ModT_ticket> _list = null;

		// Token: 0x04000A30 RID: 2608
		private ModT_ticket selectMod = new ModT_ticket();

		// Token: 0x04000A31 RID: 2609
		private ModCfg_setting MaxFWDifferSetting;

		// Token: 0x04000A32 RID: 2610
		protected string danhao = "";

		// Token: 0x04000A33 RID: 2611
		private string cardNum = string.Empty;

		// Token: 0x04000A34 RID: 2612
		private int mSelectIndex = 0;

		// Token: 0x04000A35 RID: 2613
		private bool isEditOpen = false;

		// Token: 0x04000A36 RID: 2614
		private int _StaticColumnCount;

		// Token: 0x04000A37 RID: 2615
		private Timer _Timer = null;

		// Token: 0x04000A38 RID: 2616
		public static object lockobj = new object();

		// Token: 0x04000A39 RID: 2617
		private Timer _TimerM = new Timer();

		// Token: 0x04000A3A RID: 2618
		private int mLocalTicketType = 0;

		// Token: 0x04000A3B RID: 2619
		private string _TicketBatchModel = "TicketHouse";

		// Token: 0x04000A3C RID: 2620
		private Dictionary<string, string> mDictStep = new Dictionary<string, string>();
	}
}
