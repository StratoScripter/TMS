using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
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
using Model;
using Model.SQSConfig;
using SQSClient.Properties;

namespace SQSClient
{
	// Token: 0x0200004A RID: 74
	public partial class frmRdRecordTicket : BaseDialogForm
	{
		// Token: 0x06000371 RID: 881 RVA: 0x00057138 File Offset: 0x00055338
		public frmRdRecordTicket()
		{
			this.InitializeComponent();
			this.SetText(this);
			this._Controls.Clear();
			this._Controls.Add(this.bar);
			this._Controls.Add(this.dgvRecordMain);
			this._Controls.Add(this.barDetail);
			this._Controls.Add(this.dgvData);
			this._Controls.Add(this.contextMenuStrip);
		}

		// Token: 0x06000372 RID: 882 RVA: 0x0005722C File Offset: 0x0005542C
		private void frmRdRecordTicket_Load(object sender, EventArgs e)
		{
			BaseDialogForm._operateArgs.Category = this.Text;
			base.InitBurron();
			this.InitControl();
			this._StaticColumnCount = this.dgvRecordMain.Columns.Count;
			base.CreateDgv(this.dgvRecordMain, "c_cs_rdrecord_" + base.Name);
			this.LoadMain(0);
			ModCfg_setting model = DalCfg_setting.Instance.GetModel("Item", "DumpDays");
			bool flag = model != null && model.Value != "0";
			if (flag)
			{
				string time = DateTime.Now.AddDays((double)(-(double)int.Parse(model.Value))).ToString("yyyy-MM-dd 00:00:00");
				DalT_ticket.Instance.UpdateData(time);
			}
		}

		// Token: 0x06000373 RID: 883 RVA: 0x000572FC File Offset: 0x000554FC
		private void InitControl()
		{
			this.dtpDate.Value = DateTime.Now;
			BaseForm.EnumModel enumModel = new BaseForm.EnumModel();
			enumModel.Name = "All";
			enumModel.Description = ShowWords.ReplaceText("All");
			enumModel.Value = -1;
			List<BaseForm.EnumModel> list = new List<BaseForm.EnumModel>();
			list.Add(enumModel);
			list.AddRange(BaseForm.GetEnumModelList<RdRecordStatus>());
			BaseForm.BindDataSouce(this.cmbRdStatus, list, "Description", "Value");
			List<BaseForm.EnumModel> list2 = new List<BaseForm.EnumModel>();
			list2.Add(enumModel);
			list2.AddRange(BaseForm.GetEnumModelList<RdRecordFlag>());
			BaseForm.BindDataSouce(this.cmbRdFlag, list2, "Description", "Value");
			List<BaseForm.EnumModel> list3 = new List<BaseForm.EnumModel>();
			list3.Add(enumModel);
			list3.AddRange(BaseForm.GetEnumModelList<RdBusType>());
			BaseForm.BindDataSouce(this.cmbBusType, list3, "Description", "Value");
			this.cmbWhName.BindDataSouce(DalCs_warehouse.Instance.GetAllList(), "WhName", "PinYinMa", "WhCode");
			this.cmbProduct.BindDataSouce(DalT_product.Instance.GetListByState(1, 0), "Name", "PinYinMa", "Id");
			List<AutocompleteItem> list4 = new List<AutocompleteItem>();
			List<ModT_truck> allList = DalT_truck.Instance.GetAllList();
			foreach (ModT_truck modT_truck in allList)
			{
				list4.Add(new MulticolumnAutocompleteItem(new string[]
				{
					modT_truck.Lisence + ((modT_truck.CoachNum == "") ? "" : ("-" + modT_truck.CoachNum)),
					modT_truck.ProductName
				}, modT_truck.Lisence + ((modT_truck.CoachNum == "") ? "" : ("-" + modT_truck.CoachNum)), true, true));
			}
			AutocompleteMenu autocompleteMenu = new AutocompleteMenu();
			autocompleteMenu.MaximumSize = new Size(300, 200);
			autocompleteMenu.MinFragmentLength = 1;
			autocompleteMenu.SetAutocompleteItems(list4);
			autocompleteMenu.SetAutocompleteMenu(this.txtRdCode, autocompleteMenu);
			this.MaxFWDifferSetting = DalCfg_setting.Instance.GetModel("Item", "MaxFWDiffer");
		}

		// Token: 0x06000374 RID: 884 RVA: 0x00057570 File Offset: 0x00055770
		private void btnQuery_Click(object sender, EventArgs e)
		{
			this.LoadMain(this.mSelectRecordRowIndex);
		}

		// Token: 0x06000375 RID: 885 RVA: 0x00057580 File Offset: 0x00055780
		private void LoadMain(int selectRowIndex)
		{
			this.dgvRecordMain.Rows.Clear();
			this.GetList();
			int num = 0;
			foreach (ModCs_rdrecord modCs_rdrecord in this.mRecordList)
			{
				object[] array = new object[this.dgvRecordMain.ColumnCount];
				int num2 = 0;
				array[num2++] = modCs_rdrecord.Id;
				array[num2++] = modCs_rdrecord.RdIndex;
				array[num2++] = modCs_rdrecord.RdCode;
				array[num2++] = modCs_rdrecord.VouchType;
				array[num2++] = ShowWords.ReplaceText(EnumHelper.GetDescription<RdBusType>((RdBusType)Convert.ToInt32(modCs_rdrecord.BusType)));
				array[num2++] = modCs_rdrecord.Source;
				array[num2++] = modCs_rdrecord.WhCode;
				array[num2++] = modCs_rdrecord.DepName;
				array[num2++] = modCs_rdrecord.RdPerson;
				array[num2++] = modCs_rdrecord.DLCode;
				array[num2++] = modCs_rdrecord.Maker;
				array[num2++] = modCs_rdrecord.Handler;
				array[num2++] = modCs_rdrecord.Accounter;
				array[num2++] = ShowWords.ReplaceText(EnumHelper.GetDescription<RdRecordStatus>((RdRecordStatus)modCs_rdrecord.RdStatus));
				for (int i = this._StaticColumnCount; i < this.dgvRecordMain.ColumnCount; i++)
				{
					array[i] = base.GetValueMod<ModCs_rdrecord>(modCs_rdrecord, this.dgvRecordMain.Columns[i].DataPropertyName);
				}
				this.dgvRecordMain.Rows.Add(array);
				num++;
			}
			bool flag = this.dgvRecordMain.Rows.Count > 0;
			if (flag)
			{
				this.mSelectRecordRowIndex = ((selectRowIndex > this.dgvRecordMain.Rows.Count - 1) ? 0 : selectRowIndex);
				this.dgvRecordMain.Rows[this.mSelectRecordRowIndex].Selected = true;
				this.GetCurrentMainItem(this.mSelectRecordRowIndex);
				this.SetMainBtnEnabled(true);
			}
			else
			{
				this.SetMainBtnEnabled(false);
			}
			this.gPanelToRdRecords.Text = ShowWords.ReplaceText("ToRdRecords") + "(" + this.dgvRecordMain.RowCount.ToString() + ")";
			this.labCount.Text = ShowWords.ReplaceText("Orders") + " " + this.dgvRecordMain.RowCount.ToString();
		}

		// Token: 0x06000376 RID: 886 RVA: 0x00057850 File Offset: 0x00055A50
		private void SetMainBtnEnabled(bool enabled)
		{
			this.btnAdjustRd.Enabled = enabled;
			this.btnModifyRd.Enabled = enabled;
			this.btnDeleteRd.Enabled = enabled;
			this.btnPrintRd.Enabled = enabled;
			this.btnSettleStockRd.Enabled = enabled;
			this.btnImportBill.Enabled = enabled;
			this.btnRemoveBill.Enabled = enabled;
		}

		// Token: 0x06000377 RID: 887 RVA: 0x000578BC File Offset: 0x00055ABC
		private void GetList()
		{
			List<string> list = new List<string>();
			bool flag = !string.IsNullOrWhiteSpace(this.cmbRdStatus.Text);
			if (flag)
			{
				List<string> list2 = list;
				string str = "RdStatus=";
				object selectedValue = this.cmbRdStatus.SelectedValue;
				list2.Add(str + ((selectedValue != null) ? selectedValue.ToString() : null));
			}
			bool flag2 = (int)this.cmbRdFlag.SelectedValue > -1;
			if (flag2)
			{
				List<string> list3 = list;
				string str2 = "RdFlag=";
				object selectedValue2 = this.cmbRdFlag.SelectedValue;
				list3.Add(str2 + ((selectedValue2 != null) ? selectedValue2.ToString() : null));
			}
			bool flag3 = (int)this.cmbBusType.SelectedValue > -1;
			if (flag3)
			{
				List<string> list4 = list;
				string str3 = "BusType=";
				object selectedValue3 = this.cmbBusType.SelectedValue;
				list4.Add(str3 + ((selectedValue3 != null) ? selectedValue3.ToString() : null));
			}
			bool flag4 = !string.IsNullOrWhiteSpace(this.cmbWhName.Text);
			if (flag4)
			{
				List<string> list5 = list;
				string str4 = "WhCode=";
				object selectedValue4 = this.cmbWhName.SelectedValue;
				list5.Add(str4 + ((selectedValue4 != null) ? selectedValue4.ToString() : null));
			}
			bool flag5 = !string.IsNullOrWhiteSpace(this.txtRdCode.Text.Trim());
			if (flag5)
			{
				list.Add("RdCode like '" + this.txtRdCode.Text.Trim() + "'");
			}
			bool @checked = this.chkIsUseDate.Checked;
			if (@checked)
			{
				list.Add("CreateDate>='" + this.dtpDate.Value.ToString("yyyy-MM-dd 00:00:00") + "'");
				list.Add("CreateDate<='" + this.dtpDate.Value.AddDays(1.0).ToString("yyyy-MM-dd 00:00:00") + "'");
			}
			bool manageself = GlobalKey.Manageself;
			if (manageself)
			{
				list.Add("Maker='" + GlobalKey.UserName + "'");
			}
			list.Add("VouchType='" + this.mBillVouchType + "'");
			this.mRecordList = DalCs_rdrecord.Instance.GetListRequire(list, new List<string>
			{
				"Id desc"
			}, null);
		}

		// Token: 0x06000378 RID: 888 RVA: 0x0004EF3A File Offset: 0x0004D13A
		private void btnItemCRd_Click(object sender, EventArgs e)
		{
			this.OpenForm(typeof(frmItemChoose), ((ButtonItem)sender).Text, new object[]
			{
				"cs_rdrecord",
				base.Name
			});
		}

		// Token: 0x06000379 RID: 889 RVA: 0x00057B08 File Offset: 0x00055D08
		private void dgvRecordMain_SelectionChanged(object sender, EventArgs e)
		{
			bool flag = this.dgvRecordMain.SelectedRows.Count > 0;
			if (flag)
			{
				this.GetCurrentMainItem(this.dgvRecordMain.SelectedRows[0].Index);
			}
		}

		// Token: 0x0600037A RID: 890 RVA: 0x00057B4C File Offset: 0x00055D4C
		private void dgvRecordMain_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			bool flag = e.RowIndex >= 0;
			if (flag)
			{
				this.GetCurrentMainItem(e.RowIndex);
			}
		}

		// Token: 0x0600037B RID: 891 RVA: 0x00057B7C File Offset: 0x00055D7C
		private void dgvRecordMain_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			bool flag = e.RowIndex >= 0;
			if (flag)
			{
				this.GetCurrentMainItem(e.RowIndex);
				this.OpenMainForm(this.Text, BaseForm.FormActtion.Modify, this._FrmName);
			}
		}

		// Token: 0x0600037C RID: 892 RVA: 0x00057BC0 File Offset: 0x00055DC0
		private void GetCurrentMainItem(int rowindex)
		{
			this.mCurrentRecordId = int.Parse(this.dgvRecordMain.Rows[rowindex].Cells[0].Value.ToString());
			this.mCurrentRecordIndex = int.Parse(this.dgvRecordMain.Rows[rowindex].Cells[1].Value.ToString());
			this.mSelectRecordRowIndex = rowindex;
			this.LoadDetail(this.mSelectIndex);
		}

		// Token: 0x0600037D RID: 893 RVA: 0x00057C44 File Offset: 0x00055E44
		protected void OpenMainForm(string text, BaseForm.FormActtion action, string d)
		{
			frmRdRecordEdit frmRdRecordEdit = new frmRdRecordEdit(text, action, this.mCurrentRecordId, d, this.mBillVouchType);
			bool flag = this._Mod != null;
			if (flag)
			{
				frmRdRecordEdit._ParentMenuId = this._Mod.MenuId;
			}
			this.isEditOpen = true;
			bool flag2 = frmRdRecordEdit.ShowDialog() == DialogResult.Yes;
			if (flag2)
			{
				this.LoadMain(this.mSelectRecordRowIndex);
			}
			this.isEditOpen = false;
		}

		// Token: 0x0600037E RID: 894 RVA: 0x00057CB1 File Offset: 0x00055EB1
		private void btnModifyRd_Click(object sender, EventArgs e)
		{
			this.OpenMainForm(((ButtonItem)sender).Text, BaseForm.FormActtion.Modify, this._FrmName);
		}

		// Token: 0x0600037F RID: 895 RVA: 0x00057CD0 File Offset: 0x00055ED0
		private void btnDeleteRd_Click(object sender, EventArgs e)
		{
			BaseDialogForm._operateArgs.OperateType = ((ButtonItem)sender).Text;
			bool flag = !base.ShowChoise(Messages.DeleteSure, "", "");
			if (!flag)
			{
				bool flag2 = DalT_ticket.Instance.GetCountByRdIndex(this.mCurrentRecordIndex) > 0;
				if (flag2)
				{
					base.ShowMsg(ShowWords.ReplaceText(Messages.TicketLimitDelete), "", "");
				}
				else
				{
					ModCs_rdrecord model = DalCs_rdrecord.Instance.GetModel("RdIndex", this.mCurrentRecordIndex);
					bool flag3 = DalCs_rdrecord.Instance.Delete("RdIndex", this.mCurrentRecordIndex);
					if (flag3)
					{
						this.OnOperateSuccess(model, true);
						this.mSelectRecordRowIndex = 0;
						this.LoadMain(this.mSelectRecordRowIndex);
					}
					else
					{
						this.OnOperateFail(model, false);
						base.ShowMsg(ShowWords.ReplaceText(Messages.DeleteFalse), "", "");
					}
				}
			}
		}

		// Token: 0x06000380 RID: 896 RVA: 0x00057DDA File Offset: 0x00055FDA
		private void btnAddRd_Click(object sender, EventArgs e)
		{
			this.OpenMainForm(((ButtonItem)sender).Text, BaseForm.FormActtion.Add, this._FrmName);
		}

		// Token: 0x06000381 RID: 897 RVA: 0x00057DF8 File Offset: 0x00055FF8
		private void btnSettleStockRd_Click(object sender, EventArgs e)
		{
			foreach (ModT_ticket modT_ticket in this._list)
			{
			}
		}

		// Token: 0x06000382 RID: 898 RVA: 0x00057E4C File Offset: 0x0005604C
		private void LoadDetail(int selectRowIndex)
		{
			this.dgvData.Rows.Clear();
			List<string> list = new List<string>();
			list.Add("RdRecordIndex = " + this.mCurrentRecordIndex.ToString());
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
				array[num++] = ShowWords.ReplaceText(((LabStatus)viewT_ticketbatch.BatchLabStatus).ToString());
				array[num++] = ShowWords.ReplaceText(((CheckResult)viewT_ticketbatch.BatchLabResult).ToString());
				array[num++] = viewT_ticketbatch.BatchLabMan;
				array[num++] = viewT_ticketbatch.BatchLabTime;
				array[num++] = viewT_ticketbatch.BatchLabCount;
				array[num++] = viewT_ticketbatch.BatchCode;
				array[num++] = viewT_ticketbatch.QuantityBatch;
				array[num++] = ShowWords.ReplaceText(EnumHelper.GetDescription<TicketState>((TicketState)viewT_ticketbatch.BatchState));
				array[num++] = viewT_ticketbatch.Remark;
				this.dgvData.Rows.Add(array);
			}
			bool flag = this.dgvData.Rows.Count > 0;
			if (flag)
			{
				this.mSelectIndex = ((selectRowIndex > this.dgvData.Rows.Count - 1) ? 0 : selectRowIndex);
				this.dgvData.Rows[this.mSelectIndex].Selected = true;
				this.GetCurrentItem(this.mSelectIndex);
				this.SetDetailBtnEnabled(true);
			}
			else
			{
				this.SetDetailBtnEnabled(false);
			}
		}

		// Token: 0x06000383 RID: 899 RVA: 0x0005818C File Offset: 0x0005638C
		private void SetDetailBtnEnabled(bool enabled)
		{
			this.btnRemoveBill.Enabled = enabled;
			this.btnPrint.Enabled = enabled;
			this.btnStockSettle.Enabled = enabled;
		}

		// Token: 0x06000384 RID: 900 RVA: 0x000581B8 File Offset: 0x000563B8
		private void btnImportBill_Click(object sender, EventArgs e)
		{
			this.mSelectIndex = 0;
			string text = this.OpenRelationForm((ButtonItem)sender, BaseForm.FormActtion.Import, this._FrmName, "RdRecordIndex = 0");
			bool flag = string.IsNullOrWhiteSpace(text);
			if (!flag)
			{
				bool flag2 = this.ImportTicketBySelectIds(text);
				if (flag2)
				{
					this.LoadDetail(this.mSelectIndex);
				}
				this.OnOperateSuccess(new
				{
					SelectTicketIds = text
				}, true);
			}
		}

		// Token: 0x06000385 RID: 901 RVA: 0x00058220 File Offset: 0x00056420
		private void btnRemoveBill_Click(object sender, EventArgs e)
		{
			bool flag = !base.ShowChoise(Messages.RemoveSure, "", "");
			if (!flag)
			{
				this.mSelectIndex = 0;
				string text = this.OpenRelationForm((ButtonItem)sender, BaseForm.FormActtion.Remove, this._FrmName, "RdRecordIndex = " + this.mCurrentRecordIndex.ToString());
				bool flag2 = this.RemoveTicketBySelectIds(text);
				if (flag2)
				{
					this.LoadDetail(this.mSelectIndex);
				}
				this.OnOperateSuccess(text, true);
			}
		}

		// Token: 0x06000386 RID: 902 RVA: 0x000582A8 File Offset: 0x000564A8
		protected string OpenRelationForm(ButtonItem sender, BaseForm.FormActtion action, string d, string condition = "")
		{
			string result = string.Empty;
			BaseDialogForm baseDialogForm = base.CreateInstance<BaseDialogForm>(typeof(frmTicket), sender.Text, action, d);
			bool flag = this._Mod != null;
			if (flag)
			{
				baseDialogForm._ParentMenuId = this._Mod.MenuId;
			}
			baseDialogForm.Sender = sender;
			baseDialogForm.SetExtCondition = condition;
			this.isEditOpen = true;
			bool flag2 = baseDialogForm.ShowDialog() == DialogResult.Yes;
			if (flag2)
			{
				result = baseDialogForm.GetSelectIds;
			}
			this.isEditOpen = false;
			return result;
		}

		// Token: 0x06000387 RID: 903 RVA: 0x00058334 File Offset: 0x00056534
		protected bool ImportTicketBySelectIds(string selectIds)
		{
			return DalT_ticket.Instance.UpdateRdRecordIndex(this.mCurrentRecordIndex, selectIds.Trim(new char[]
			{
				','
			}));
		}

		// Token: 0x06000388 RID: 904 RVA: 0x00058368 File Offset: 0x00056568
		protected bool RemoveTicketBySelectIds(string selectIds)
		{
			return DalT_ticket.Instance.UpdateRdRecordIndex(0, selectIds.Trim(new char[]
			{
				','
			}));
		}

		// Token: 0x06000389 RID: 905 RVA: 0x00003040 File Offset: 0x00001240
		private void btnDelete_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600038A RID: 906 RVA: 0x00058398 File Offset: 0x00056598
		private void btnStockSettle_Click(object sender, EventArgs e)
		{
			BaseDialogForm._operateArgs.OperateType = ((ButtonItem)sender).Text;
			List<ViewT_ticketbatch> ticketBatchList = this.GetTicketBatchList();
			bool flag = !this.CheckStockSettle(ticketBatchList);
			if (flag)
			{
				base.ShowMsg(ShowWords.ReplaceText(Messages.StockSettleSure), "", "");
			}
			else
			{
				this.RunStockOperation(ticketBatchList);
				int count = (from o in ticketBatchList
				where !o.IsStock
				select o).ToList<ViewT_ticketbatch>().Count;
				bool flag2 = count == 0;
				if (flag2)
				{
					this.OnOperateSuccess(ticketBatchList, true);
					base.ShowMsg(ShowWords.ReplaceText(Messages.StockSettleTrue), "", "");
				}
				else
				{
					string format = ShowWords.ReplaceText(Messages.StockSettleFalseCount);
					base.ShowMsg(string.Format(format, count), "", "");
				}
				this.LoadDetail(this.mSelectIndex);
			}
		}

		// Token: 0x0600038B RID: 907 RVA: 0x00058498 File Offset: 0x00056698
		private List<ViewT_ticketbatch> GetTicketBatchList()
		{
			string text = "";
			for (int i = 0; i < this.dgvData.SelectedRows.Count; i++)
			{
				text = text + this.dgvData.Rows[this.dgvData.SelectedRows[i].Index].Cells[0].Value.ToString() + ",";
			}
			text = text.Trim(new char[]
			{
				','
			});
			List<string> list = new List<string>();
			list.Add("batch.Id in (" + text + ")");
			return DalT_ticketbatch.Instance.GetListViewBatch(list);
		}

		// Token: 0x0600038C RID: 908 RVA: 0x00058558 File Offset: 0x00056758
		private bool CheckStockSettle(List<ViewT_ticketbatch> list)
		{
			foreach (ViewT_ticketbatch viewT_ticketbatch in list)
			{
				string format = ShowWords.ReplaceText(Messages.MsgTicketBatchCheck);
				string text = string.Empty;
				bool flag = viewT_ticketbatch.BatchLabStatus != 5;
				if (flag)
				{
					text = string.Format(format, viewT_ticketbatch.InvCode, viewT_ticketbatch.BatchCode, ShowWords.ReplaceText(EnumHelper.GetDescription<LabStatus>((LabStatus)viewT_ticketbatch.BatchLabStatus)));
					base.ShowMsg(ShowWords.ReplaceText(text), "", "");
					return false;
				}
				bool flag2 = viewT_ticketbatch.BatchState > 0;
				if (flag2)
				{
					text = string.Format(format, viewT_ticketbatch.InvCode, viewT_ticketbatch.BatchCode, ShowWords.ReplaceText(EnumHelper.GetDescription<TicketState>((TicketState)viewT_ticketbatch.BatchState)));
					base.ShowMsg(ShowWords.ReplaceText(text), "", "");
					return false;
				}
			}
			return true;
		}

		// Token: 0x0600038D RID: 909 RVA: 0x00058664 File Offset: 0x00056864
		private void RunStockOperation(List<ViewT_ticketbatch> list)
		{
			foreach (ViewT_ticketbatch viewT_ticketbatch in list)
			{
				bool flag = !this.ExecutionStockValue(viewT_ticketbatch);
				if (flag)
				{
					break;
				}
				bool flag2 = !DalT_ticketbatch.Instance.UpdateBatchState(1, viewT_ticketbatch.Id);
				if (flag2)
				{
					this.PushBackStockValue(viewT_ticketbatch);
					base.ShowMsg(ShowWords.ReplaceText(Messages.StockSettleFalse), "", "");
					break;
				}
				viewT_ticketbatch.IsStock = true;
			}
		}

		// Token: 0x0600038E RID: 910 RVA: 0x00058708 File Offset: 0x00056908
		private bool ExecutionStockValue(ViewT_ticketbatch view)
		{
			bool flag = view.BusinessType == 2;
			if (flag)
			{
				bool flag2 = !DalCs_currstock.Instance.AddStockValue("001", view.InvCode, view.BatchCode, view.QuantityBatch);
				if (flag2)
				{
					base.ShowMsg(ShowWords.ReplaceText(Messages.StockSettleFalse), "", "");
					return false;
				}
			}
			else
			{
				bool flag3 = view.BusinessType == 1;
				if (flag3)
				{
					bool flag4 = !DalCs_currstock.Instance.ReduceStockValue("001", view.InvCode, view.BatchCode, view.QuantityBatch);
					if (flag4)
					{
						base.ShowMsg(ShowWords.ReplaceText(Messages.StockSettleFalse), "", "");
						return false;
					}
				}
			}
			return true;
		}

		// Token: 0x0600038F RID: 911 RVA: 0x000587D0 File Offset: 0x000569D0
		private bool PushBackStockValue(ViewT_ticketbatch view)
		{
			bool flag = view.BusinessType == 2;
			if (flag)
			{
				bool flag2 = !DalCs_currstock.Instance.ReduceStockValue("001", view.InvCode, view.BatchCode, view.QuantityBatch);
				if (flag2)
				{
					base.ShowMsg(ShowWords.ReplaceText(Messages.StockSettleFalse), "", "");
					return false;
				}
			}
			else
			{
				bool flag3 = view.BusinessType == 1;
				if (flag3)
				{
					bool flag4 = !DalCs_currstock.Instance.AddStockValue("001", view.InvCode, view.BatchCode, view.QuantityBatch);
					if (flag4)
					{
						base.ShowMsg(ShowWords.ReplaceText(Messages.StockSettleFalse), "", "");
						return false;
					}
				}
			}
			return true;
		}

		// Token: 0x06000390 RID: 912 RVA: 0x00003040 File Offset: 0x00001240
		private void btnPrint_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000391 RID: 913 RVA: 0x0004FAD4 File Offset: 0x0004DCD4
		private void frmRdRecordTicket_FormClosing(object sender, FormClosingEventArgs e)
		{
			base.Dispose();
		}

		// Token: 0x06000392 RID: 914 RVA: 0x00058898 File Offset: 0x00056A98
		private void GetCurrentItem(int rowindex)
		{
			this._CurrentId = int.Parse(this.dgvData.Rows[rowindex].Cells[0].Value.ToString());
			this._CurrentItemName = this.dgvData.Rows[rowindex].Cells["C_DanHao"].Value.ToString();
		}

		// Token: 0x06000393 RID: 915 RVA: 0x00058908 File Offset: 0x00056B08
		private void dgvData_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			bool flag = e.RowIndex >= 0;
			if (flag)
			{
				this.GetCurrentItem(e.RowIndex);
				this.mSelectIndex = e.RowIndex;
			}
		}

		// Token: 0x06000394 RID: 916 RVA: 0x00058944 File Offset: 0x00056B44
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

		// Token: 0x06000395 RID: 917 RVA: 0x000589F0 File Offset: 0x00056BF0
		private void ResetMenuStrips()
		{
			foreach (object obj in this.contextMenuStrip.Items)
			{
				ToolStripMenuItem toolStripMenuItem = (ToolStripMenuItem)obj;
				toolStripMenuItem.Enabled = false;
			}
		}

		// Token: 0x06000396 RID: 918 RVA: 0x00058A54 File Offset: 0x00056C54
		private void toolReceiptCapture_Click(object sender, EventArgs e)
		{
			bool flag = new frmDocCamView(((ToolStripMenuItem)sender).Text, BaseForm.FormActtion.Add, this._CurrentId)
			{
				DocType = DocType.Receipt
			}.ShowDialog() == DialogResult.OK;
			if (flag)
			{
				base.ShowMsg(ShowWords.ReplaceText(Messages.SaveTrue), "", "");
			}
		}

		// Token: 0x06000397 RID: 919 RVA: 0x00058AAC File Offset: 0x00056CAC
		private void toolCheckRequest_Click(object sender, EventArgs e)
		{
			BaseDialogForm._operateArgs.OperateType = ((ToolStripMenuItem)sender).Text;
			this.LabStatusCheck(1);
		}

		// Token: 0x06000398 RID: 920 RVA: 0x00058AD0 File Offset: 0x00056CD0
		private void dgvData_SelectionChanged(object sender, EventArgs e)
		{
			bool flag = this.dgvData.SelectedRows.Count > 0;
			if (flag)
			{
				this._CurrentId = int.Parse(this.dgvData.SelectedRows[0].Cells[0].Value.ToString());
				ModT_ticketbatch model = DalT_ticketbatch.Instance.GetModel("Id", this._CurrentId);
				bool flag2 = model.BatchState < 1;
				if (flag2)
				{
					this.btnStockSettle.Enabled = true;
				}
				else
				{
					this.btnStockSettle.Enabled = false;
				}
			}
		}

		// Token: 0x06000399 RID: 921 RVA: 0x00058B70 File Offset: 0x00056D70
		private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			bool flag = e.RowIndex >= 0;
			if (flag)
			{
				this.GetCurrentItem(e.RowIndex);
				this.mSelectIndex = e.RowIndex;
			}
		}

		// Token: 0x0600039A RID: 922 RVA: 0x00003040 File Offset: 0x00001240
		private void dgvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
		}

		// Token: 0x0600039B RID: 923 RVA: 0x00058BAC File Offset: 0x00056DAC
		private void LabStatusCheck(int labStatus)
		{
			BatchLabHelper batchLabHelper = new BatchLabHelper();
			ModT_ticketbatch model = DalT_ticketbatch.Instance.GetModel(this._CurrentId);
			string text = batchLabHelper.UpdateTicketLabStatus(labStatus, model);
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

		// Token: 0x040005AE RID: 1454
		private List<ModCs_rdrecord> mRecordList = new List<ModCs_rdrecord>();

		// Token: 0x040005AF RID: 1455
		private List<ModT_ticket> _list = null;

		// Token: 0x040005B0 RID: 1456
		private ModT_ticket selectMod = new ModT_ticket();

		// Token: 0x040005B1 RID: 1457
		private ModCfg_setting MaxFWDifferSetting;

		// Token: 0x040005B2 RID: 1458
		private string cardNum = string.Empty;

		// Token: 0x040005B3 RID: 1459
		private bool isEditOpen = false;

		// Token: 0x040005B4 RID: 1460
		protected string danhao = "";

		// Token: 0x040005B5 RID: 1461
		private int mSelectIndex = 0;

		// Token: 0x040005B6 RID: 1462
		private int _StaticColumnCount;

		// Token: 0x040005B7 RID: 1463
		public static object lockobj = new object();

		// Token: 0x040005B8 RID: 1464
		private int mCurrentRecordId = 0;

		// Token: 0x040005B9 RID: 1465
		private int mCurrentRecordIndex = 0;

		// Token: 0x040005BA RID: 1466
		private int mSelectRecordRowIndex = 0;

		// Token: 0x040005BB RID: 1467
		private readonly string mBillVouchType = KeyVouchType.RdTicket;
	}
}
