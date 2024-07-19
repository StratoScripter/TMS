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
	// Token: 0x02000047 RID: 71
	public partial class frmRdRecord : BaseDialogForm
	{
		// Token: 0x06000327 RID: 807 RVA: 0x0004E568 File Offset: 0x0004C768
		public frmRdRecord()
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

		// Token: 0x06000328 RID: 808 RVA: 0x0004E65C File Offset: 0x0004C85C
		private void frmRdRecord_Load(object sender, EventArgs e)
		{
			BaseDialogForm._operateArgs.Category = this.Text;
			base.InitBurron();
			this.InitControl();
			this._StaticColumnCount = this.dgvRecordMain.Columns.Count;
			base.CreateDgv(this.dgvRecordMain, "c_cs_rdrecord_" + base.Name);
			this._StaticColumnCount = this.dgvData.Columns.Count;
			base.CreateDgv(this.dgvData, "c_t_ticket_" + base.Name);
			this.LoadMain(0);
			ModCfg_setting model = DalCfg_setting.Instance.GetModel("Item", "DumpDays");
			bool flag = model != null && model.Value != "0";
			if (flag)
			{
				string time = DateTime.Now.AddDays((double)(-(double)int.Parse(model.Value))).ToString("yyyy-MM-dd 00:00:00");
				DalT_ticket.Instance.UpdateData(time);
			}
		}

		// Token: 0x06000329 RID: 809 RVA: 0x0004E75C File Offset: 0x0004C95C
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

		// Token: 0x0600032A RID: 810 RVA: 0x0004E9D0 File Offset: 0x0004CBD0
		private void btnQuery_Click(object sender, EventArgs e)
		{
			this.LoadMain(this.mSelectRecordRowIndex);
		}

		// Token: 0x0600032B RID: 811 RVA: 0x0004E9E0 File Offset: 0x0004CBE0
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
			this.labCount.Text = ShowWords.ReplaceText("Orders") + " " + this.dgvRecordMain.RowCount.ToString();
		}

		// Token: 0x0600032C RID: 812 RVA: 0x0004EC78 File Offset: 0x0004CE78
		private void SetMainBtnEnabled(bool enabled)
		{
			this.btnAdjustRd.Enabled = enabled;
			this.btnModifyRd.Enabled = enabled;
			this.btnDeleteRd.Enabled = enabled;
			this.btnPrintRd.Enabled = enabled;
			this.btnSettleStockRd.Enabled = enabled;
			this.btnModifyRds.Enabled = enabled;
			this.btnDeleteRds.Enabled = enabled;
			this.btnStockSettle.Enabled = enabled;
		}

		// Token: 0x0600032D RID: 813 RVA: 0x0004ECF0 File Offset: 0x0004CEF0
		private void GetList()
		{
			List<string> list = new List<string>();
			bool flag = (int)this.cmbRdStatus.SelectedValue > -1;
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

		// Token: 0x0600032E RID: 814 RVA: 0x0004EF3A File Offset: 0x0004D13A
		private void btnItemCRd_Click(object sender, EventArgs e)
		{
			this.OpenForm(typeof(frmItemChoose), ((ButtonItem)sender).Text, new object[]
			{
				"cs_rdrecord",
				base.Name
			});
		}

		// Token: 0x0600032F RID: 815 RVA: 0x0004EF70 File Offset: 0x0004D170
		private void dgvRecordMain_SelectionChanged(object sender, EventArgs e)
		{
			bool flag = this.dgvRecordMain.SelectedRows.Count > 0;
			if (flag)
			{
				this.GetCurrentMainItem(this.dgvRecordMain.SelectedRows[0].Index);
			}
		}

		// Token: 0x06000330 RID: 816 RVA: 0x0004EFB4 File Offset: 0x0004D1B4
		private void dgvRecordMain_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			bool flag = e.RowIndex >= 0;
			if (flag)
			{
				this.GetCurrentMainItem(e.RowIndex);
			}
		}

		// Token: 0x06000331 RID: 817 RVA: 0x0004EFE4 File Offset: 0x0004D1E4
		private void dgvRecordMain_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			bool flag = e.RowIndex >= 0;
			if (flag)
			{
				this.GetCurrentMainItem(e.RowIndex);
				this.OpenMainForm(this.Text, BaseForm.FormActtion.Modify, this._FrmName);
			}
		}

		// Token: 0x06000332 RID: 818 RVA: 0x0004F028 File Offset: 0x0004D228
		private void GetCurrentMainItem(int rowindex)
		{
			this.mCurrentRecordId = int.Parse(this.dgvRecordMain.Rows[rowindex].Cells[0].Value.ToString());
			this.mCurrentRecordIndex = int.Parse(this.dgvRecordMain.Rows[rowindex].Cells[1].Value.ToString());
			this.mSelectRecordRowIndex = rowindex;
			this.LoadDetail(this.mSelectIndex);
		}

		// Token: 0x06000333 RID: 819 RVA: 0x0004F0AC File Offset: 0x0004D2AC
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

		// Token: 0x06000334 RID: 820 RVA: 0x0004F119 File Offset: 0x0004D319
		private void btnModifyRd_Click(object sender, EventArgs e)
		{
			this.OpenMainForm(((ButtonItem)sender).Text, BaseForm.FormActtion.Modify, this._FrmName);
		}

		// Token: 0x06000335 RID: 821 RVA: 0x0004F138 File Offset: 0x0004D338
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

		// Token: 0x06000336 RID: 822 RVA: 0x0004F242 File Offset: 0x0004D442
		private void btnAddRd_Click(object sender, EventArgs e)
		{
			this.OpenMainForm(((ButtonItem)sender).Text, BaseForm.FormActtion.Add, this._FrmName);
		}

		// Token: 0x06000337 RID: 823 RVA: 0x0004F260 File Offset: 0x0004D460
		private void btnSettleStockRd_Click(object sender, EventArgs e)
		{
			foreach (ModT_ticket modT_ticket in this._list)
			{
			}
		}

		// Token: 0x06000338 RID: 824 RVA: 0x0004F2B4 File Offset: 0x0004D4B4
		private void LoadDetail(int selectRowIndex)
		{
			this.dgvData.Rows.Clear();
			List<string> list = new List<string>();
			list.Add("RdRecordIndex = " + this.mCurrentRecordIndex.ToString());
			List<ViewCs_rdrecords> listByRecordIndex = DalCs_rdrecords.Instance.GetListByRecordIndex(this.mCurrentRecordIndex);
			this.dgvData.Rows.Clear();
			foreach (ViewCs_rdrecords viewCs_rdrecords in listByRecordIndex)
			{
				object[] array = new object[this.dgvData.ColumnCount];
				int num = 0;
				array[num++] = viewCs_rdrecords.Id;
				array[num++] = viewCs_rdrecords.RecordIndex;
				array[num++] = viewCs_rdrecords.BillSort;
				array[num++] = viewCs_rdrecords.InvCode;
				array[num++] = viewCs_rdrecords.Name;
				array[num++] = viewCs_rdrecords.Code;
				array[num++] = viewCs_rdrecords.BatchNum;
				array[num++] = viewCs_rdrecords.Quantity;
				array[num++] = viewCs_rdrecords.SpecsDanWei;
				array[num++] = viewCs_rdrecords.PositionInfo;
				array[num++] = viewCs_rdrecords.ExtBarCode;
				array[num++] = ShowWords.ReplaceText(EnumHelper.GetDescription<TicketStatus>((TicketStatus)viewCs_rdrecords.RdsStatus));
				array[num++] = ShowWords.ReplaceText(EnumHelper.GetDescription<TicketState>((TicketState)viewCs_rdrecords.RdsState));
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

		// Token: 0x06000339 RID: 825 RVA: 0x0004F508 File Offset: 0x0004D708
		private void SetDetailBtnEnabled(bool enabled)
		{
			this.btnDeleteRds.Enabled = enabled;
			this.btnPrint.Enabled = enabled;
			this.btnStockSettle.Enabled = enabled;
		}

		// Token: 0x0600033A RID: 826 RVA: 0x00003040 File Offset: 0x00001240
		private void btnRemoveBill_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600033B RID: 827 RVA: 0x0004F534 File Offset: 0x0004D734
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

		// Token: 0x0600033C RID: 828 RVA: 0x0004F5C0 File Offset: 0x0004D7C0
		protected bool ImportTicketBySelectIds(string selectIds)
		{
			return DalT_ticket.Instance.UpdateRdRecordIndex(this.mCurrentRecordIndex, selectIds.Trim(new char[]
			{
				','
			}));
		}

		// Token: 0x0600033D RID: 829 RVA: 0x0004F5F4 File Offset: 0x0004D7F4
		protected bool RemoveTicketBySelectIds(string selectIds)
		{
			return DalT_ticket.Instance.UpdateRdRecordIndex(0, selectIds.Trim(new char[]
			{
				','
			}));
		}

		// Token: 0x0600033E RID: 830 RVA: 0x00003040 File Offset: 0x00001240
		private void btnDelete_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600033F RID: 831 RVA: 0x0004F624 File Offset: 0x0004D824
		private void btnStockSettle_Click(object sender, EventArgs e)
		{
			BaseDialogForm._operateArgs.OperateType = ((ButtonItem)sender).Text;
			List<ViewCs_rdrecords> rdRecordsList = this.GetRdRecordsList();
			bool flag = !this.CheckStockSettle(rdRecordsList);
			if (flag)
			{
				base.ShowMsg(ShowWords.ReplaceText(Messages.StockSettleSure), "", "");
			}
			else
			{
				this.RunStockOperation(rdRecordsList);
				int count = (from o in rdRecordsList
				where !o.IsStock
				select o).ToList<ViewCs_rdrecords>().Count;
				bool flag2 = count == 0;
				if (flag2)
				{
					bool flag3 = rdRecordsList.Count > 0;
					if (flag3)
					{
						this.OnOperateSuccess(rdRecordsList, true);
					}
					base.ShowMsg(ShowWords.ReplaceText(Messages.StockSettleTrue), "", "");
				}
				else
				{
					string format = ShowWords.ReplaceText(Messages.StockSettleFalseCount);
					base.ShowMsg(string.Format(format, count), "", "");
				}
			}
		}

		// Token: 0x06000340 RID: 832 RVA: 0x0004F728 File Offset: 0x0004D928
		private List<ViewCs_rdrecords> GetRdRecordsList()
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
			return DalCs_rdrecords.Instance.GetListByRecordsIds(text);
		}

		// Token: 0x06000341 RID: 833 RVA: 0x0004F7CC File Offset: 0x0004D9CC
		private bool CheckStockSettle(List<ViewCs_rdrecords> list)
		{
			foreach (ViewCs_rdrecords viewCs_rdrecords in list)
			{
				string format = ShowWords.ReplaceText(Messages.MsgTicketBatchCheck);
				string text = string.Empty;
				bool flag = viewCs_rdrecords.RdsState > 0;
				if (flag)
				{
					text = string.Format(format, viewCs_rdrecords.InvCode, viewCs_rdrecords.BatchNum, ShowWords.ReplaceText(EnumHelper.GetDescription<TicketState>((TicketState)viewCs_rdrecords.RdsState)));
					base.ShowMsg(ShowWords.ReplaceText(text), "", "");
					return false;
				}
			}
			return true;
		}

		// Token: 0x06000342 RID: 834 RVA: 0x0004F880 File Offset: 0x0004DA80
		private void RunStockOperation(List<ViewCs_rdrecords> list)
		{
			foreach (ViewCs_rdrecords viewCs_rdrecords in list)
			{
				bool flag = !this.ExecutionStockValue(viewCs_rdrecords);
				if (flag)
				{
					break;
				}
				bool flag2 = !DalCs_rdrecords.Instance.UpdateRdsState(1, viewCs_rdrecords.Id);
				if (flag2)
				{
					this.PushBackStockValue(viewCs_rdrecords);
					base.ShowMsg(ShowWords.ReplaceText(Messages.StockSettleFalse), "", "");
					break;
				}
				viewCs_rdrecords.IsStock = true;
			}
		}

		// Token: 0x06000343 RID: 835 RVA: 0x0004F924 File Offset: 0x0004DB24
		private bool ExecutionStockValue(ViewCs_rdrecords view)
		{
			bool flag = Convert.ToInt32(view.BusType) == 3 || Convert.ToInt32(view.BusType) == 4;
			if (flag)
			{
				bool flag2 = !DalCs_currstock.Instance.ReduceStockValue(view.WhCode, view.InvCode, view.BatchNum, (decimal)view.Quantity);
				if (flag2)
				{
					base.ShowMsg(ShowWords.ReplaceText(Messages.StockSettleFalse), "", "");
					return false;
				}
			}
			else
			{
				bool flag3 = !DalCs_currstock.Instance.AddStockValue(view.WhCode, view.InvCode, view.BatchNum, (decimal)view.Quantity);
				if (flag3)
				{
					base.ShowMsg(ShowWords.ReplaceText(Messages.StockSettleFalse), "", "");
					return false;
				}
			}
			return true;
		}

		// Token: 0x06000344 RID: 836 RVA: 0x0004F9FC File Offset: 0x0004DBFC
		private bool PushBackStockValue(ViewCs_rdrecords view)
		{
			bool flag = Convert.ToInt32(view.BusType) == 3 || Convert.ToInt32(view.BusType) == 4;
			if (flag)
			{
				bool flag2 = !DalCs_currstock.Instance.AddStockValue(view.WhCode, view.InvCode, view.BatchNum, (decimal)view.Quantity);
				if (flag2)
				{
					base.ShowMsg(ShowWords.ReplaceText(Messages.StockSettleFalse), "", "");
					return false;
				}
			}
			else
			{
				bool flag3 = !DalCs_currstock.Instance.ReduceStockValue(view.WhCode, view.InvCode, view.BatchNum, (decimal)view.Quantity);
				if (flag3)
				{
					base.ShowMsg(ShowWords.ReplaceText(Messages.StockSettleFalse), "", "");
					return false;
				}
			}
			return true;
		}

		// Token: 0x06000345 RID: 837 RVA: 0x00003040 File Offset: 0x00001240
		private void btnPrint_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000346 RID: 838 RVA: 0x0004FAD4 File Offset: 0x0004DCD4
		private void frmRdRecord_FormClosing(object sender, FormClosingEventArgs e)
		{
			base.Dispose();
		}

		// Token: 0x06000347 RID: 839 RVA: 0x0004FAE0 File Offset: 0x0004DCE0
		private void GetCurrentItem(int rowindex)
		{
			this._CurrentId = int.Parse(this.dgvData.Rows[rowindex].Cells[0].Value.ToString());
			this._CurrentItemName = this.dgvData.Rows[rowindex].Cells["C_BillSort"].Value.ToString();
		}

		// Token: 0x06000348 RID: 840 RVA: 0x0004FB50 File Offset: 0x0004DD50
		private void dgvData_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			bool flag = e.RowIndex >= 0;
			if (flag)
			{
				this.GetCurrentItem(e.RowIndex);
				this.mSelectIndex = e.RowIndex;
			}
		}

		// Token: 0x06000349 RID: 841 RVA: 0x0004FB8C File Offset: 0x0004DD8C
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

		// Token: 0x0600034A RID: 842 RVA: 0x0004FC38 File Offset: 0x0004DE38
		private void ResetMenuStrips()
		{
			foreach (object obj in this.contextMenuStrip.Items)
			{
				ToolStripMenuItem toolStripMenuItem = (ToolStripMenuItem)obj;
				toolStripMenuItem.Enabled = false;
			}
		}

		// Token: 0x0600034B RID: 843 RVA: 0x0004FC9C File Offset: 0x0004DE9C
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

		// Token: 0x0600034C RID: 844 RVA: 0x0004FCF4 File Offset: 0x0004DEF4
		private void toolCheckRequest_Click(object sender, EventArgs e)
		{
			this.LabStatusCheck(1);
		}

		// Token: 0x0600034D RID: 845 RVA: 0x0004FD00 File Offset: 0x0004DF00
		private void dgvData_SelectionChanged(object sender, EventArgs e)
		{
			bool flag = this.dgvData.SelectedRows.Count > 0;
			if (flag)
			{
				this._CurrentId = int.Parse(this.dgvData.SelectedRows[0].Cells[0].Value.ToString());
				ModCs_rdrecords model = DalCs_rdrecords.Instance.GetModel("Id", this._CurrentId);
				bool flag2 = model.RdsState < 1;
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

		// Token: 0x0600034E RID: 846 RVA: 0x0004FDA0 File Offset: 0x0004DFA0
		private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			bool flag = e.RowIndex >= 0;
			if (flag)
			{
				this.GetCurrentItem(e.RowIndex);
				this.mSelectIndex = e.RowIndex;
			}
		}

		// Token: 0x0600034F RID: 847 RVA: 0x0004FDDC File Offset: 0x0004DFDC
		private void dgvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			bool flag = e.RowIndex >= 0;
			if (flag)
			{
				this.OpenDetailForm(this.Text, BaseForm.FormActtion.Modify, this._FrmName);
			}
		}

		// Token: 0x06000350 RID: 848 RVA: 0x0004FE10 File Offset: 0x0004E010
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
				f = model.BatchCode,
				OldLabStatus = model.BatchLabStatus,
				NewLabStatus = labStatus
			}, true);
		}

		// Token: 0x06000351 RID: 849 RVA: 0x0004FE83 File Offset: 0x0004E083
		private void btnAddRds_Click(object sender, EventArgs e)
		{
			this.OpenDetailForm(((ButtonItem)sender).Text, BaseForm.FormActtion.Add, this._FrmName);
		}

		// Token: 0x06000352 RID: 850 RVA: 0x0004FE9F File Offset: 0x0004E09F
		private void btnModifyRds_Click(object sender, EventArgs e)
		{
			this.OpenDetailForm(((ButtonItem)sender).Text, BaseForm.FormActtion.Modify, this._FrmName);
		}

		// Token: 0x06000353 RID: 851 RVA: 0x00003040 File Offset: 0x00001240
		private void btnDeleteRds_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000354 RID: 852 RVA: 0x0004FEBC File Offset: 0x0004E0BC
		protected void OpenDetailForm(string text, BaseForm.FormActtion action, string d)
		{
			frmRdRecordsEdit frmRdRecordsEdit = new frmRdRecordsEdit(text, action, this._CurrentId, d, this.mCurrentRecordIndex);
			bool flag = this._Mod != null;
			if (flag)
			{
				frmRdRecordsEdit._ParentMenuId = this._Mod.MenuId;
			}
			this.isEditOpen = true;
			bool flag2 = frmRdRecordsEdit.ShowDialog() == DialogResult.Yes;
			if (flag2)
			{
				this.LoadDetail(this.mSelectIndex);
			}
			this.isEditOpen = false;
		}

		// Token: 0x04000503 RID: 1283
		private List<ModCs_rdrecord> mRecordList = new List<ModCs_rdrecord>();

		// Token: 0x04000504 RID: 1284
		private List<ModT_ticket> _list = null;

		// Token: 0x04000505 RID: 1285
		private ModT_ticket selectMod = new ModT_ticket();

		// Token: 0x04000506 RID: 1286
		private ModCfg_setting MaxFWDifferSetting;

		// Token: 0x04000507 RID: 1287
		private string cardNum = string.Empty;

		// Token: 0x04000508 RID: 1288
		private bool isEditOpen = false;

		// Token: 0x04000509 RID: 1289
		protected string danhao = "";

		// Token: 0x0400050A RID: 1290
		private int mSelectIndex = 0;

		// Token: 0x0400050B RID: 1291
		private int _StaticColumnCount;

		// Token: 0x0400050C RID: 1292
		public static object lockobj = new object();

		// Token: 0x0400050D RID: 1293
		private int mCurrentRecordId = 0;

		// Token: 0x0400050E RID: 1294
		private int mCurrentRecordIndex = 0;

		// Token: 0x0400050F RID: 1295
		private int mSelectRecordRowIndex = 0;

		// Token: 0x04000510 RID: 1296
		private readonly string mBillVouchType = KeyVouchType.RdRecord;
	}
}
