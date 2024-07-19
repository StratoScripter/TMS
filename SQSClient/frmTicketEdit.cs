using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Assistant;
using AutocompleteMenuNS;
using Base;
using DAL.Access;
using DAL.Base.SQSConfig;
using DAL.MySQL;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using DevComponents.DotNetBar.Layout;
using DevComponents.Editors;
using DevComponents.Editors.DateTimeAdv;
using ICHandle;
using Model;
using Model.DiBang;
using Model.SQSConfig;
using SQSClient.Properties;

namespace SQSClient
{
	// Token: 0x02000018 RID: 24
	public partial class frmTicketEdit : BaseDialogForm
	{
		// Token: 0x060000FD RID: 253 RVA: 0x0001DA40 File Offset: 0x0001BC40
		public frmTicketEdit(string text, BaseForm.FormActtion act, int id, string dir)
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

		// Token: 0x060000FE RID: 254 RVA: 0x0001DB30 File Offset: 0x0001BD30
		private void frmReviseInfo_Load(object sender, EventArgs e)
		{
			base.InitBurron();
			this.InitControl();
			this._StaticColumnCount = this.dgvData.Columns.Count;
			base.CreateDgv(this.dgvData, "c_t_ticket_" + base.Name);
			this.LoadData();
		}

		// Token: 0x060000FF RID: 255 RVA: 0x0001DB88 File Offset: 0x0001BD88
		private bool InitControl()
		{
			this.dgvData.ShowCellToolTips = false;
			DataGridViewComboBoxExColumn dataGridViewComboBoxExColumn = (DataGridViewComboBoxExColumn)this.dgvData.Columns["C_DanWei"];
			dataGridViewComboBoxExColumn.DropDownStyle = ComboBoxStyle.DropDownList;
			dataGridViewComboBoxExColumn.DisplayMember = "Description";
			dataGridViewComboBoxExColumn.ValueMember = "Name";
			dataGridViewComboBoxExColumn.DataSource = BaseForm.GetEnumModelList<DanWei>();
			this.dgvData.Rows[this.dgvData.Rows.Count - 1].Cells["C_DanWei"].Value = DanWei.kg.ToString();
			DataGridViewComboBoxExColumn dataGridViewComboBoxExColumn2 = (DataGridViewComboBoxExColumn)this.dgvData.Columns["C_Loadometer"];
			dataGridViewComboBoxExColumn2.DropDownStyle = ComboBoxStyle.DropDownList;
			dataGridViewComboBoxExColumn2.DisplayMember = "Name";
			dataGridViewComboBoxExColumn2.ValueMember = "Name";
			dataGridViewComboBoxExColumn2.DataSource = DalCfg_weighbridge.Instance.GetAllList();
			this._productList = DalT_product.Instance.GetListByState(1, Settings.Instance.ProductShowType);
			DataGridViewComboBoxExColumn dataGridViewComboBoxExColumn3 = (DataGridViewComboBoxExColumn)this.dgvData.Columns["C_Product"];
			dataGridViewComboBoxExColumn3.DropDownStyle = ComboBoxStyle.DropDownList;
			dataGridViewComboBoxExColumn3.DisplayMember = "InvName";
			dataGridViewComboBoxExColumn3.ValueMember = "InvCode";
			dataGridViewComboBoxExColumn3.DataSource = this._productList;
			List<AutocompleteItem> list = new List<AutocompleteItem>();
			this._truckList = DalT_truck.Instance.GetListNotBlackList();
			foreach (ModT_truck modT_truck in this._truckList)
			{
				list.Add(new MulticolumnAutocompleteItem(new string[]
				{
					modT_truck.Lisence + ((modT_truck.CoachNum == "") ? "" : ("-" + modT_truck.CoachNum)),
					modT_truck.ProductName
				}, modT_truck.Lisence, true, true));
			}
			this.autocompleteMenu.MaximumSize = new Size(300, 200);
			this.autocompleteMenu.MinFragmentLength = 1;
			this.autocompleteMenu.CaptureFocus = true;
			this.autocompleteMenu.SetAutocompleteItems(list);
			List<AutocompleteItem> list2 = new List<AutocompleteItem>();
			this._unitList = DalCfg_unit.Instance.GetList("State", true);
			foreach (ModCfg_unit modCfg_unit in this._unitList)
			{
				list2.Add(new MulticolumnAutocompleteItem(new string[]
				{
					modCfg_unit.Name,
					modCfg_unit.CurProductName
				}, modCfg_unit.Name, true, true));
			}
			this.autocompleteMenuUnit.MinFragmentLength = 1;
			this.autocompleteMenuUnit.CaptureFocus = true;
			this.autocompleteMenuUnit.SetAutocompleteItems(list2);
			List<AutocompleteItem> list3 = new List<AutocompleteItem>();
			this._tankList = DalT_tank.Instance.GetAllList();
			foreach (ModT_tank modT_tank in this._tankList)
			{
				list3.Add(new MulticolumnAutocompleteItem(new string[]
				{
					modT_tank.Name,
					modT_tank.ProductName
				}, modT_tank.Name, true, true));
			}
			this.autocompleteMenuTank.MinFragmentLength = 1;
			this.autocompleteMenuTank.CaptureFocus = true;
			this.autocompleteMenuTank.SetAutocompleteItems(list3);
			this.cmbClientpart.BindDataSouce(DalT_client.Instance.GetAllList(), "Name", "PinYinMa", "Id");
			this.cmbSettlepart.BindDataSouce(DalT_settlepart.Instance.GetAllList(), "Name", "PinYinMa", "Id");
			this._trucktypeList = DalT_trucktype.Instance.GetAllList();
			this.cmbTruckTypeName.BindDataSouce(this._trucktypeList, "Name", "PinYinMa", "Name");
			this.cmbProduct.BindDataSouce(this._productList, "InvName", "PinYinMa", "InvCode");
			this.cmbDanWei.BindDataSouce(BaseForm.GetEnumModelList<DanWei>(), "Description", "Name", "Value");
			this.cmbDanWei.SelectedIndex = 0;
			this.cmbBusinessType.BindDataSouce(BaseForm.GetEnumModelList<BusinessType>(), "Description", "Description", "Value");
			this.cmbAccountType.BindDataSouce(BaseForm.GetEnumModelList<AccountType>(), "Description", "Description", "Value");
			bool flag = DalCfg_setting.Instance.GetModel("Item", "AccountHandEnable").Value == "0";
			if (flag)
			{
				this.cmbAccountType.Items.Remove(ShowWords.ReplaceText(AccountType.Hand.ToString()));
			}
			this.cmbAccountType.SelectedValue = int.Parse(DalCfg_setting.Instance.GetModel("Item", "DefaultAccountType").Value);
			this.BindAutocompleteMenu();
			this.tInputValiFirstTime.Value = DateTime.Now;
			this.tInputValiSecondTime.Value = DateTime.Now.AddHours(1.0);
			return true;
		}

		// Token: 0x06000100 RID: 256 RVA: 0x0001E114 File Offset: 0x0001C314
		private void BindAutocompleteMenu()
		{
			List<AutocompleteItem> list = new List<AutocompleteItem>();
			List<ModT_contract> allList = DalT_contract.Instance.GetAllList();
			foreach (ModT_contract modT_contract in allList)
			{
				list.Add(new MulticolumnAutocompleteItem(new string[]
				{
					modT_contract.ContractNum,
					modT_contract.ProductName
				}, modT_contract.ContractNum, true, true));
			}
			base.BindAutocompleteMenu(this.txtContractNum, list);
		}

		// Token: 0x06000101 RID: 257 RVA: 0x0001E1AC File Offset: 0x0001C3AC
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
					base.Close();
				}
				else
				{
					this.txtContractNum.Text = this._mod.ContractNum;
					this.cmbBusinessType.SelectedValue = this._mod.BusinessType;
					this.cmbClientpart.Text = this._mod.ClientPart;
					this.cmbSettlepart.Text = this._mod.SettlePart;
					DateTime now = DateTime.Now;
					bool flag3 = DateTime.TryParse(this._mod.ValiFirstTime, out now);
					if (flag3)
					{
						this.tInputValiFirstTime.Value = now;
					}
					DateTime now2 = DateTime.Now;
					bool flag4 = DateTime.TryParse(this._mod.ValiSecondTime, out now2);
					if (flag4)
					{
						this.tInputValiSecondTime.Value = now2;
					}
					this.cmbTruckTypeName.Text = this._mod.TypeName;
					this.txtCardNum.Text = this._mod.CardNum;
					this.cmbAccountType.SelectedValue = this._mod.AccountType;
					this._list = DalT_ticket.Instance.GetList("BatchNum", this._mod.BatchNum);
					this.dgvData.Rows.Clear();
					int num = 0;
					int num2 = 0;
					using (List<ModT_ticket>.Enumerator enumerator = this._list.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							ModT_ticket mod = enumerator.Current;
							this.dgvData.Rows.Add();
							this.dgvData.Rows[num].Cells["C_Id"].Value = mod.Id;
							this.dgvData.Rows[num].Cells["C_DanHao"].Value = mod.DanHao;
							this.dgvData.Rows[num].Cells["C_CheNum"].Value = mod.Lisence;
							this.dgvData.Rows[num].Cells["C_CangNum"].Value = mod.CangNum;
							this.dgvData.Rows[num].Cells["C_Product"].Value = mod.InvCode;
							this.dgvData.Rows[num].Cells["C_UnitName"].Value = mod.UnitName;
							DataGridViewCell dataGridViewCell = this.dgvData.Rows[num].Cells["C_Tank"];
							ModT_tank modT_tank = this._tankList.Find((ModT_tank o) => o.Code == mod.TankCode);
							dataGridViewCell.Value = ((modT_tank != null) ? modT_tank.Name : null);
							this.dgvData.Rows[num].Cells["C_NetWeight"].Value = mod.NetWeight;
							this.dgvData.Rows[num].Cells["C_JiHuaLiang"].Value = mod.JiHuaLiang;
							bool flag5 = decimal.Parse(this.dgvData.Rows[num].Cells["C_JiHuaLiang"].EditedFormattedValue.ToString()) > decimal.Parse(this.dgvData.Rows[num].Cells["C_NetWeight"].EditedFormattedValue.ToString());
							if (flag5)
							{
								this.dgvData.Rows[num].Cells["C_JiHuaLiang"].Style.BackColor = Color.Red;
							}
							else
							{
								this.dgvData.Rows[num].Cells["C_JiHuaLiang"].Style.BackColor = Color.FromArgb(128, 255, 128);
							}
							this.dgvData.Rows[num].Cells["C_DanWei"].Value = mod.DanWei;
							this.dgvData.Rows[num].Cells["C_FirstWeight"].Value = mod.FirstWeight;
							this.dgvData.Rows[num].Cells["C_FirstTime"].Value = mod.FirstTime;
							this.dgvData.Rows[num].Cells["C_Loadometer"].Value = mod.Loader;
							this.dgvData.Rows[num].Cells["C_ShiJiLiang"].Value = mod.ShiJiLiang;
							this.dgvData.Rows[num].Cells["C_SinglePrice"].Value = mod.SinglePrice;
							this.dgvData.Rows[num].Cells["C_TotalPrice"].Value = mod.TotalPrice;
							for (int i = this._StaticColumnCount; i < this.dgvData.ColumnCount; i++)
							{
								this.dgvData.Rows[num].Cells[i].Value = base.GetValueMod<ModT_ticket>(mod, this.dgvData.Columns[i].DataPropertyName);
							}
							num++;
							bool flag6 = mod.Status > num2;
							if (flag6)
							{
								num2 = mod.Status;
							}
						}
					}
					this.dgvData.Columns["C_DanHao"].ReadOnly = true;
					this.dgvData.Columns["C_DanHao"].DefaultCellStyle.BackColor = Color.White;
					this.gPanelBatchSetup.Enabled = false;
					this.dgvData.AllowUserToDeleteRows = false;
					this.dgvData.AllowUserToAddRows = false;
					bool flag7 = num2 > 0;
					if (flag7)
					{
						this.btnSave.Enabled = false;
						this.gPanelContract.Enabled = false;
						this.gPanelOthers.Enabled = false;
						this.dgvData.ReadOnly = true;
					}
				}
			}
			else
			{
				bool flag8 = this._Act == BaseForm.FormActtion.Add;
				if (flag8)
				{
					this.txtContractNum.Text = "";
					this.btnCard_Click(this.btnCard, null);
					DateTime now3 = DateTime.Now;
					int maxIndex = DanHaoHelper.Instance().GetMaxIndex("LOC_", now3);
					this.txtContractNum.Text = "LOC_" + now3.ToString("yyyyMMdd") + (maxIndex + 1).ToString().PadLeft(4, '0');
				}
			}
		}

		// Token: 0x06000102 RID: 258 RVA: 0x0001E9F0 File Offset: 0x0001CBF0
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

		// Token: 0x06000103 RID: 259 RVA: 0x0001EA40 File Offset: 0x0001CC40
		private void btnSave_Click(object sender, EventArgs e)
		{
			this.txtCardNum.Focus();
			bool flag = !this.TextCheck();
			if (!flag)
			{
				bool flag2 = this._Act == BaseForm.FormActtion.Add;
				bool flag3;
				if (flag2)
				{
					flag3 = this.Add();
				}
				else
				{
					flag3 = this.Modify();
				}
				bool flag4 = flag3;
				if (flag4)
				{
					bool flag5 = int.Parse(DalCfg_setting.Instance.GetModel("Item", "SetCard").Value) > 0;
					if (flag5)
					{
						ICTicket.WriteCard(this.SetCardMod());
					}
					base.DialogResult = DialogResult.Yes;
				}
			}
		}

		// Token: 0x06000104 RID: 260 RVA: 0x0001EAD4 File Offset: 0x0001CCD4
		private bool Add()
		{
			List<string> list = new List<string>();
			Dictionary<string, object> dictionary = new Dictionary<string, object>();
			dictionary.Add("ContractNum", this.txtContractNum.Text);
			dictionary.Add("ClientPart", this.cmbClientpart.Text);
			dictionary.Add("ClientPartId", this.GetClientCode(this.cmbClientpart.Text));
			dictionary.Add("SettlePart", this.cmbSettlepart.Text);
			dictionary.Add("BusinessType", (int)this.cmbBusinessType.SelectedValue);
			bool flag = (int)this.cmbBusinessType.SelectedValue == 1;
			if (flag)
			{
				dictionary.Add("IsLab", DalCfg_setting.Instance.GetModel("Item", "LoadLabDefaultEnable").Value == "1");
			}
			else
			{
				dictionary.Add("IsLab", DalCfg_setting.Instance.GetModel("Item", "UnloadLabDefaultEnable").Value == "1");
			}
			dictionary.Add("AccountType", (int)this.cmbAccountType.SelectedValue);
			dictionary.Add("CardNum", this.txtCardNum.Text.Trim());
			bool flag2 = this.txtCardNum.Text.Trim().Length > 0;
			if (flag2)
			{
				dictionary.Add("IsCard", true);
				dictionary.Add("TakeCardTime", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
			}
			else
			{
				dictionary.Add("IsCard", false);
				dictionary.Add("TakeCardTime", "");
			}
			dictionary.Add("ValiFirstTime", this.tInputValiFirstTime.Value.ToString("yyyy-MM-dd HH:mm:ss"));
			dictionary.Add("ValiSecondTime", this.tInputValiSecondTime.Value.ToString("yyyy-MM-dd HH:mm:ss"));
			dictionary.Add("TypeName", this.cmbTruckTypeName.Text);
			dictionary.Add("ShiJiLiang", 0);
			dictionary.Add("XianQianLiang", 0);
			dictionary.Add("StartTime", DateTime.Now);
			dictionary.Add("EndTime", DateTime.Now);
			dictionary.Add("ZhiDanRen", GlobalKey.UserName);
			dictionary.Add("ZhiDanTime", DateTime.Now);
			dictionary.Add("JieSuanTime", DateTime.Now);
			dictionary.Add("Status", 0);
			dictionary.Add("State", 0);
			dictionary.Add("BdState", 0);
			dictionary.Add("OperateState", 1);
			dictionary.Add("IsQueue", false);
			dictionary.Add("IsDelete", false);
			dictionary.Add("DataReturn", 0);
			dictionary.Add("TicketType", 1);
			dictionary.Add("ImpurityPercent", 1);
			dictionary.Add("SpecsDanWei", "kg");
			object maxValue = DalT_ticket.Instance.GetMaxValue("BatchNum");
			dictionary.Add("BatchNum", ((maxValue == null) ? 0 : ((int)maxValue)) + 1);
			this._mod.BatchNum = ((maxValue == null) ? 0 : ((int)maxValue)) + 1;
			dictionary.Add("DanHao", null);
			dictionary.Add("Lisence", null);
			dictionary.Add("DriverID", null);
			dictionary.Add("SupercargoID", null);
			dictionary.Add("DriverName", null);
			dictionary.Add("SupercargoName", null);
			dictionary.Add("Carrier", null);
			dictionary.Add("ProductName", null);
			dictionary.Add("ProductCode", null);
			dictionary.Add("InvCode", null);
			dictionary.Add("TankCode", null);
			dictionary.Add("CangNum", null);
			dictionary.Add("UnitName", null);
			dictionary.Add("NetWeight", null);
			dictionary.Add("JiHuaLiang", null);
			dictionary.Add("DanWei", null);
			dictionary.Add("FirstWeight", null);
			dictionary.Add("FirstTime", null);
			dictionary.Add("Loader", null);
			dictionary.Add("SinglePrice", null);
			for (int i = this._StaticColumnCount; i < this.dgvData.ColumnCount; i++)
			{
				bool flag3 = !this.dgvData.Columns[i].ReadOnly;
				if (flag3)
				{
					dictionary.Add(this.dgvData.Columns[i].DataPropertyName, null);
				}
			}
			using (IEnumerator enumerator = ((IEnumerable)this.dgvData.Rows).GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					DataGridViewRow row = (DataGridViewRow)enumerator.Current;
					bool flag4 = row.Cells["C_CheNum"].EditedFormattedValue.ToString() != "";
					if (flag4)
					{
						ModT_truck model = DalT_truck.Instance.GetModel("Lisence", row.Cells["C_CheNum"].EditedFormattedValue.ToString().Split(new char[]
						{
							'-'
						})[0]);
						bool flag5 = model == null;
						if (flag5)
						{
							return false;
						}
						dictionary["Lisence"] = model.Lisence;
						dictionary["DriverID"] = model.DriverID;
						dictionary["SupercargoID"] = model.SupercargoID;
						Dictionary<string, object> dictionary2 = dictionary;
						string key = "DriverName";
						ModT_truckman model2 = DalT_truckman.Instance.GetModel("IDCard", model.DriverID);
						dictionary2[key] = ((model2 != null) ? model2.Name : null);
						Dictionary<string, object> dictionary3 = dictionary;
						string key2 = "SupercargoName";
						ModT_truckman model3 = DalT_truckman.Instance.GetModel("IDCard", model.SupercargoID);
						dictionary3[key2] = ((model3 != null) ? model3.Name : null);
						dictionary["Carrier"] = model.SubUnit;
					}
					ModT_product model4 = DalT_product.Instance.GetModel("InvCode", row.Cells["C_Product"].EditedFormattedValue.ToString());
					bool flag6 = model4 == null;
					if (!flag6)
					{
						dictionary["ProductName"] = model4.InvName;
						dictionary["ProductCode"] = model4.Code;
						dictionary["PositivePrecise"] = model4.PositivePrecise;
						dictionary["NagativePrecise"] = model4.NagativePrecise;
						dictionary["InvCode"] = row.Cells["C_Product"].EditedFormattedValue.ToString();
						list.Add(dictionary["InvCode"].ToString());
						ModT_tank modT_tank = this._tankList.Find((ModT_tank o) => o.Name == row.Cells["C_Tank"].EditedFormattedValue.ToString());
						dictionary["TankCode"] = ((modT_tank == null) ? 0 : modT_tank.Code);
						dictionary["CangNum"] = int.Parse(row.Cells["C_CangNum"].EditedFormattedValue.ToString());
						dictionary["UnitName"] = row.Cells["C_UnitName"].EditedFormattedValue.ToString();
						dictionary["NetWeight"] = decimal.Parse(row.Cells["C_NetWeight"].EditedFormattedValue.ToString());
						dictionary["JiHuaLiang"] = decimal.Parse(row.Cells["C_JiHuaLiang"].EditedFormattedValue.ToString());
						dictionary["DanWei"] = row.Cells["C_DanWei"].EditedFormattedValue.ToString();
						dictionary["FirstWeight"] = decimal.Parse(row.Cells["C_FirstWeight"].EditedFormattedValue.ToString());
						dictionary["FirstTime"] = row.Cells["C_FirstTime"].EditedFormattedValue.ToString();
						dictionary["Loader"] = row.Cells["C_Loadometer"].EditedFormattedValue.ToString();
						dictionary["SinglePrice"] = Convert.ToDecimal(row.Cells["C_SinglePrice"].EditedFormattedValue.ToString());
						for (int j = this._StaticColumnCount; j < this.dgvData.ColumnCount; j++)
						{
							bool flag7 = !this.dgvData.Columns[j].ReadOnly;
							if (flag7)
							{
								dictionary[this.dgvData.Columns[j].DataPropertyName] = row.Cells[j].EditedFormattedValue;
							}
						}
						dictionary["DanHao"] = row.Cells["C_DanHao"].EditedFormattedValue.ToString();
						bool flag8 = dictionary["DanHao"].ToString().Length < 1;
						if (flag8)
						{
							string empty = string.Empty;
							bool flag9 = !DalT_ticket.Instance.CreateDanHao(ref empty);
							if (flag9)
							{
								base.ShowToast(this, Messages.DanHaoCreatFalse, "", "");
								return false;
							}
							dictionary["DanHao"] = empty;
						}
						bool flag10 = base.IsExist("t_ticket", "DanHao", dictionary["DanHao"], SqlDbType.NVarChar);
						if (flag10)
						{
							base.ShowMsg(Messages.DanHaoHaved, "", "");
							return false;
						}
						bool flag11 = !this.IsTakeCardCheckTicketCount(list);
						if (flag11)
						{
							return false;
						}
						bool flag12 = !DalT_ticket.Instance.Add(dictionary);
						if (flag12)
						{
							this.OnOperateFail(dictionary, false);
							base.ShowToast(this, Messages.AddFalse, "", "");
							return false;
						}
						this.OnOperateSuccess(dictionary, true);
						Settings.Instance.Save();
					}
				}
			}
			return true;
		}

		// Token: 0x06000105 RID: 261 RVA: 0x0001F658 File Offset: 0x0001D858
		private bool Modify()
		{
			int i = 0;
			while (i < this._list.Count)
			{
				Dictionary<string, object> dictionary = new Dictionary<string, object>();
				dictionary.Add("ClientPart", this.cmbClientpart.Text);
				dictionary.Add("ClientPartId", this.GetClientCode(this.cmbClientpart.Text));
				dictionary.Add("SettlePart", this.cmbSettlepart.Text);
				dictionary.Add("BusinessType", (int)this.cmbBusinessType.SelectedValue);
				dictionary.Add("AccountType", (int)this.cmbAccountType.SelectedValue);
				dictionary.Add("CardNum", this.txtCardNum.Text.Trim());
				bool flag = this.txtCardNum.Text.Trim().Length > 0;
				if (flag)
				{
					dictionary.Add("IsCard", true);
					dictionary.Add("TakeCardTime", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
				}
				else
				{
					dictionary.Add("IsCard", false);
					dictionary.Add("TakeCardTime", "");
				}
				dictionary.Add("ValiFirstTime", this.tInputValiFirstTime.Value.ToString("yyyy-MM-dd HH:mm:ss"));
				dictionary.Add("ValiSecondTime", this.tInputValiSecondTime.Value.ToString("yyyy-MM-dd HH:mm:ss"));
				bool flag2 = this.dgvData.Rows[i].Cells["C_CheNum"].EditedFormattedValue.ToString() != "";
				if (flag2)
				{
					ModT_truck model = DalT_truck.Instance.GetModel("Lisence", this.dgvData.Rows[i].Cells["C_CheNum"].EditedFormattedValue.ToString().Split(new char[]
					{
						'-'
					})[0]);
					bool flag3 = model == null;
					if (flag3)
					{
						return false;
					}
					dictionary.Add("Lisence", model.Lisence);
					dictionary.Add("DriverID", model.DriverID);
					dictionary.Add("SupercargoID", model.SupercargoID);
					Dictionary<string, object> dictionary2 = dictionary;
					string key = "DriverName";
					ModT_truckman model2 = DalT_truckman.Instance.GetModel("IDCard", model.DriverID);
					dictionary2.Add(key, (model2 != null) ? model2.Name : null);
					Dictionary<string, object> dictionary3 = dictionary;
					string key2 = "SupercargoName";
					ModT_truckman model3 = DalT_truckman.Instance.GetModel("IDCard", model.SupercargoID);
					dictionary3.Add(key2, (model3 != null) ? model3.Name : null);
					dictionary.Add("Carrier", model.SubUnit);
				}
				ModT_product model4 = DalT_product.Instance.GetModel("InvCode", this.dgvData.Rows[i].Cells["C_Product"].EditedFormattedValue.ToString());
				bool flag4 = model4 == null;
				bool result;
				if (flag4)
				{
					result = false;
				}
				else
				{
					dictionary.Add("ProductName", model4.InvName);
					dictionary.Add("ProductCode", model4.Code);
					dictionary.Add("PositivePrecise", model4.PositivePrecise);
					dictionary.Add("NagativePrecise", model4.NagativePrecise);
					dictionary.Add("InvCode", this.dgvData.Rows[i].Cells["C_Product"].EditedFormattedValue.ToString());
					ModT_tank modT_tank = this._tankList.Find((ModT_tank o) => o.Name == this.dgvData.Rows[i].Cells["C_Tank"].EditedFormattedValue.ToString());
					dictionary.Add("TankCode", (modT_tank == null) ? 0 : modT_tank.Code);
					dictionary.Add("CangNum", int.Parse(this.dgvData.Rows[i].Cells["C_CangNum"].EditedFormattedValue.ToString()));
					dictionary.Add("UnitName", this.dgvData.Rows[i].Cells["C_UnitName"].EditedFormattedValue.ToString());
					dictionary.Add("NetWeight", decimal.Parse(this.dgvData.Rows[i].Cells["C_NetWeight"].EditedFormattedValue.ToString()));
					dictionary.Add("JiHuaLiang", decimal.Parse(this.dgvData.Rows[i].Cells["C_JiHuaLiang"].EditedFormattedValue.ToString()));
					dictionary.Add("DanWei", this.dgvData.Rows[i].Cells["C_DanWei"].EditedFormattedValue.ToString());
					dictionary.Add("FirstWeight", decimal.Parse(this.dgvData.Rows[i].Cells["C_FirstWeight"].EditedFormattedValue.ToString()));
					dictionary.Add("FirstTime", this.dgvData.Rows[i].Cells["C_FirstTime"].EditedFormattedValue.ToString());
					dictionary.Add("Loader", this.dgvData.Rows[i].Cells["C_Loadometer"].EditedFormattedValue.ToString());
					for (int j = this._StaticColumnCount; j < this.dgvData.ColumnCount; j++)
					{
						bool flag5 = !this.dgvData.Columns[j].ReadOnly;
						if (flag5)
						{
							dictionary.Add(this.dgvData.Columns[j].DataPropertyName, this.dgvData.Rows[i].Cells[j].EditedFormattedValue);
						}
					}
					bool flag6 = !DalT_ticket.Instance.Update(dictionary, this._list[i].Id);
					if (!flag6)
					{
						this.OnOperateSuccess(dictionary, this._list[i], true);
						int i2 = i;
						i = i2 + 1;
						continue;
					}
					this.OnOperateFail(dictionary, false);
					base.ShowToast(this, Messages.ModifyFalse, "", "");
					result = false;
				}
				return result;
			}
			return true;
		}

		// Token: 0x06000106 RID: 262 RVA: 0x0001FDA0 File Offset: 0x0001DFA0
		private int GetClientCode(string name)
		{
			ModT_client modelByName = DalT_client.Instance.GetModelByName(name);
			bool flag = modelByName == null;
			int result;
			if (flag)
			{
				result = 0;
			}
			else
			{
				try
				{
					result = Convert.ToInt32(modelByName.Code);
				}
				catch
				{
					result = 0;
				}
			}
			return result;
		}

		// Token: 0x06000107 RID: 263 RVA: 0x0001FDF0 File Offset: 0x0001DFF0
		public BaseCardMod SetCardMod()
		{
			BaseCardMod baseCardMod = new BaseCardMod();
			baseCardMod.Vision = "V1.0.0.0";
			baseCardMod.IsValid = 1;
			baseCardMod.SysType = 1;
			baseCardMod.TicketType = this._mod.BusinessType;
			baseCardMod.ProCount = 1;
			baseCardMod.Pro1 = "100.0%" + this._mod.ProductCode.ToString();
			baseCardMod.Pro2 = "0.0%0";
			baseCardMod.VaildTime = this._mod.ZhiDanTime.ToString("yyyy-MM-dd HH:mm:ss");
			baseCardMod.DanHao = this._mod.DanHao;
			baseCardMod.IDanHao = 0;
			baseCardMod.JiHuaLiang = (double)this._mod.JiHuaLiang;
			baseCardMod.DanWei = 0;
			ModCfg_unit model = DalCfg_unit.Instance.GetModel("UnitName", this._mod.UnitName);
			bool flag = model != null;
			if (flag)
			{
				baseCardMod.UnitCode = model.Code;
			}
			baseCardMod.Lisence = this._mod.Lisence;
			return baseCardMod;
		}

		// Token: 0x06000108 RID: 264 RVA: 0x0001FF10 File Offset: 0x0001E110
		private bool TextCheck()
		{
			bool flag = string.IsNullOrWhiteSpace(this.cmbBusinessType.Text);
			bool result;
			if (flag)
			{
				base.ShowToast(this, Messages.BusinessTypeNull, "", "");
				this.cmbBusinessType.Focus();
				result = false;
			}
			else
			{
				bool flag2 = string.IsNullOrWhiteSpace(this.cmbClientpart.Text.Trim());
				if (flag2)
				{
					base.ShowToast(this, Messages.ClientpartNull, "", "");
					this.cmbClientpart.Focus();
					result = false;
				}
				else
				{
					bool flag3 = string.IsNullOrWhiteSpace(this.cmbSettlepart.Text.Trim());
					if (flag3)
					{
						base.ShowToast(this, Messages.SettlepartNull, "", "");
						this.cmbSettlepart.Focus();
						result = false;
					}
					else
					{
						bool flag4 = true;
						bool flag5 = this.txtContractNum.Text.Trim().Length > 0 && !flag4;
						if (flag5)
						{
							base.ShowToast(this, Messages.ContractHavent, "", "");
							this.txtContractNum.Focus();
							result = false;
						}
						else
						{
							bool flag6 = DalT_client.Instance.IsExist("Name", this.cmbClientpart.Text.Trim(), SqlDbType.NVarChar, ref flag4) && !flag4;
							if (flag6)
							{
								bool flag7 = this.cmbClientpart.Text.Trim() != "";
								if (flag7)
								{
									ModT_client modT_client = new ModT_client();
									modT_client.Name = this.cmbClientpart.Text.Trim();
									modT_client.PinYinMa = modT_client.Name.GetFirstPinyin();
									DalT_client.Instance.AddNoReturn(modT_client);
								}
							}
							bool flag8 = DalT_settlepart.Instance.IsExist("Name", this.cmbSettlepart.Text.Trim(), SqlDbType.NVarChar, ref flag4) && !flag4;
							if (flag8)
							{
								bool flag9 = this.cmbSettlepart.Text.Trim() != "";
								if (flag9)
								{
									ModT_settlepart modT_settlepart = new ModT_settlepart();
									modT_settlepart.Name = this.cmbSettlepart.Text.Trim();
									modT_settlepart.PinYinMa = modT_settlepart.Name.GetFirstPinyin();
									DalT_settlepart.Instance.AddNoReturn(modT_settlepart);
								}
							}
							for (int i = 1; i < this.dgvData.Rows.Count; i++)
							{
								int num = 0;
								while (num + i < this.dgvData.Rows.Count)
								{
									bool flag10 = this.dgvData.Rows[num].Cells["C_CheNum"].EditedFormattedValue.ToString() != "" && this.dgvData.Rows[num].Cells["C_CangNum"].EditedFormattedValue.ToString() != "" && this.dgvData.Rows[num].Cells["C_CheNum"].EditedFormattedValue.ToString() == this.dgvData.Rows[num + i].Cells["C_CheNum"].EditedFormattedValue.ToString() && this.dgvData.Rows[num].Cells["C_CangNum"].EditedFormattedValue.ToString() == this.dgvData.Rows[num + i].Cells["C_CangNum"].EditedFormattedValue.ToString();
									if (flag10)
									{
										base.ShowToast(this, Messages.SameTicket, this.dgvData.Rows[num].Cells["C_CheNum"].EditedFormattedValue.ToString(), "");
										return false;
									}
									bool flag11 = i == 1 && decimal.Parse(this.dgvData.Rows[num].Cells["C_JiHuaLiang"].EditedFormattedValue.ToString()) > 0m && this.dgvData.Rows[num].Cells["C_Product"].EditedFormattedValue.ToString() == "";
									if (flag11)
									{
										base.ShowToast(this, Messages.ProductNull, "", "");
										return false;
									}
									num++;
								}
							}
							int length = this.txtCardNum.Text.Trim().Length;
							bool flag12 = length > 16 && !RegexHelper.CheckChinaIDCardNumberFormat(this.txtCardNum.Text.Trim());
							if (flag12)
							{
								base.ShowToast(this, Messages.IDFormat, "", "");
								this.txtCardNum.Focus();
								result = false;
							}
							else
							{
								bool flag13 = length > 0 && length <= 16 && ((length != 8 && length != 16) || !RegexHelper.IsNumAndEnCh1(this.txtCardNum.Text.Trim()));
								if (flag13)
								{
									base.ShowToast(this, Messages.ICFormat, "", "");
									this.txtCardNum.Focus();
									result = false;
								}
								else
								{
									bool flag14 = this.txtCardNum.Text.Length == 8;
									if (flag14)
									{
										ModT_iccard model = DalT_iccard.Instance.GetModel("CardNum", this.txtCardNum.Text.Trim());
										bool flag15 = model == null;
										if (flag15)
										{
											base.ShowToast(this, Messages.ICUnauthorized, "", "");
											this.txtCardNum.Focus();
											return false;
										}
										bool flag16 = !model.State;
										if (flag16)
										{
											base.ShowToast(this, Messages.ICDisenabled, "", "");
											this.txtCardNum.Focus();
											return false;
										}
									}
									length = this.txtCardNum.Text.Trim().Length;
									bool flag17 = length > 0 && length <= 16;
									if (flag17)
									{
										List<string> list = new List<string>();
										list.Add("CardNum = '" + this.txtCardNum.Text.Trim() + "'");
										bool flag18 = bool.Parse(DalCfg_setting.Instance.GetModel("Item", "ICPaidReuse").Value);
										if (flag18)
										{
											list.Add("State < '" + 1.ToString() + "'");
										}
										else
										{
											list.Add("Status < '" + 2.ToString() + "'");
										}
										List<ModT_ticket> list2 = DalT_ticket.Instance.GetListRequire(list, null, null);
										bool flag19 = this._Act == BaseForm.FormActtion.Modify;
										if (flag19)
										{
											list2 = list2.FindAll((ModT_ticket t) => t.BatchNum != this._mod.BatchNum);
										}
										bool flag20 = list2.Count > 0;
										if (flag20)
										{
											base.ShowToast(this, Messages.ICUsed, "", "");
											this.txtCardNum.Focus();
											return false;
										}
									}
									result = true;
								}
							}
						}
					}
				}
			}
			return result;
		}

		// Token: 0x06000109 RID: 265 RVA: 0x0002069C File Offset: 0x0001E89C
		private void btnPrint_Click(object sender, EventArgs e)
		{
			bool flag = this._mod.DanHao == null || this._mod.Id == 0;
			if (flag)
			{
				this.btnSave_Click(this.btnSave, null);
			}
			this._list = DalT_ticket.Instance.GetList("BatchNum", this._mod.BatchNum);
			bool flag2 = this._list.Count == 0;
			if (flag2)
			{
				base.ShowMsg(Messages.NoData, "", "");
			}
			else
			{
				frmPrintChoise frmPrintChoise = new frmPrintChoise(((ButtonItem)sender).Text, this._mod, this._list);
				bool flag3 = frmPrintChoise.ShowDialog() == DialogResult.Yes;
				if (flag3)
				{
					base.DialogResult = DialogResult.Yes;
				}
			}
		}

		// Token: 0x0600010A RID: 266 RVA: 0x00020760 File Offset: 0x0001E960
		private void frmReviseInfo_FormClosing(object sender, FormClosingEventArgs e)
		{
			base.DialogResult = DialogResult.Yes;
		}

		// Token: 0x0600010B RID: 267 RVA: 0x0002076C File Offset: 0x0001E96C
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
				this.cmbBusinessType.Enabled = false;
				this.cmbClientpart.Enabled = false;
				this.cmbSettlepart.Enabled = false;
				this._invcode = model.InvCode;
				this.cmbTruckTypeName.BindDataSouce(this._trucktypeList.FindAll((ModT_trucktype t) => t.InvCode == this._invcode), "Name", "PinYinMa", "Name");
				this.cmbTruckTypeName.Text = "";
				this.cmbProduct.BindDataSouce(this._productList.FindAll((ModT_product t) => t.InvCode == this._invcode), "InvName", "PinYinMa", "InvCode");
				this.cmbProduct.Text = "";
				this.dInputNetWeight.Value = 0.0;
				this.UpdateProduct(this._invcode);
				foreach (object obj in ((IEnumerable)this.dgvData.Rows))
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					dataGridViewRow.Cells["C_Product"].Value = model.InvCode;
					dataGridViewRow.Cells["C_DanWei"].Value = model.DanWei;
				}
				this.dgvData.Columns["C_Product"].ReadOnly = true;
				this.dgvData.Columns["C_Product"].DefaultCellStyle.BackColor = Color.White;
				this.dgvData.Columns["C_DanWei"].ReadOnly = true;
				this.dgvData.Columns["C_DanWei"].DefaultCellStyle.BackColor = Color.White;
			}
			bool flag2 = this.txtContractNum.Text == "";
			if (flag2)
			{
				this.cmbBusinessType.Enabled = true;
				this.cmbClientpart.Enabled = true;
				this.cmbSettlepart.Enabled = true;
				this.cmbTruckTypeName.BindDataSouce(this._trucktypeList, "Name", "PinYinMa", "Name");
				this.cmbProduct.BindDataSouce(this._productList, "InvName", "PinYinMa", "InvCode");
				this.txtProduct.Text = "";
				this.dgvData.Columns["C_Product"].ReadOnly = false;
				this.dgvData.Columns["C_Product"].DefaultCellStyle.BackColor = Color.FromArgb(128, 255, 128);
				this.dgvData.Columns["C_DanWei"].ReadOnly = false;
				this.dgvData.Columns["C_DanWei"].DefaultCellStyle.BackColor = Color.FromArgb(128, 255, 128);
			}
		}

		// Token: 0x0600010C RID: 268 RVA: 0x00020B10 File Offset: 0x0001ED10
		private void cmbTruckTypeName_TextChanged(object sender, EventArgs e)
		{
			ModT_trucktype modT_trucktype = this._trucktypeList.Find((ModT_trucktype t) => t.Name == this.cmbTruckTypeName.Text);
			bool flag = modT_trucktype != null;
			if (flag)
			{
				this.cmbProduct.SelectedValue = modT_trucktype.InvCode;
				this.cmbProduct.Enabled = false;
				this.dInputVol.Value = (double)modT_trucktype.Vol;
				this.dInputVol.Enabled = false;
				this.dInputNetWeight.Value = (double)modT_trucktype.NetWeight;
				this.dInputNetWeight.Enabled = false;
			}
			bool flag2 = this.cmbTruckTypeName.Text == "";
			if (flag2)
			{
				this.cmbProduct.Enabled = true;
				this.dInputVol.Enabled = true;
				this.dInputNetWeight.Enabled = true;
			}
		}

		// Token: 0x0600010D RID: 269 RVA: 0x00020BEC File Offset: 0x0001EDEC
		private void btnSure_Click(object sender, EventArgs e)
		{
			object selectedValue = this.cmbProduct.SelectedValue;
			this._invcode = ((selectedValue != null) ? selectedValue.ToString() : null);
			this.UpdateProduct(this._invcode);
			for (int i = this.dgvData.Rows.Count; i < this.iInputCount.Value; i++)
			{
				this.dgvData.Rows.Add();
			}
			foreach (object obj in ((IEnumerable)this.dgvData.Rows))
			{
				DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
				dataGridViewRow.Cells["C_Product"].Value = this.cmbProduct.SelectedValue;
				dataGridViewRow.Cells["C_DanWei"].Value = this.cmbDanWei.Text;
				bool flag = dataGridViewRow.Cells["C_DanWei"].Value.ToString() == DanWei.kg.ToString();
				if (flag)
				{
					dataGridViewRow.Cells["C_NetWeight"].Value = this.dInputNetWeight.Value;
				}
				bool flag2 = dataGridViewRow.Cells["C_DanWei"].Value.ToString() == DanWei.L.ToString();
				if (flag2)
				{
					dataGridViewRow.Cells["C_NetWeight"].Value = this.dInputVol.Value * 1000.0;
				}
				dataGridViewRow.Cells["C_JiHuaLiang"].Value = dataGridViewRow.Cells["C_NetWeight"].Value;
				dataGridViewRow.Cells["C_JiHuaLiang"].Style.BackColor = Color.FromArgb(128, 255, 128);
			}
			this.dgvData.Columns["C_Product"].ReadOnly = true;
			this.dgvData.Columns["C_Product"].DefaultCellStyle.BackColor = Color.White;
			this.dgvData.Columns["C_DanWei"].ReadOnly = true;
			this.dgvData.Columns["C_DanWei"].DefaultCellStyle.BackColor = Color.White;
		}

		// Token: 0x0600010E RID: 270 RVA: 0x00020EAC File Offset: 0x0001F0AC
		private void UpdateProduct(string invcode)
		{
			frmTicketEdit.<>c__DisplayClass29_0 CS$<>8__locals1 = new frmTicketEdit.<>c__DisplayClass29_0();
			CS$<>8__locals1.invcode = invcode;
			List<AutocompleteItem> list = new List<AutocompleteItem>();
			List<ModT_truck> list2 = this._truckList.FindAll((ModT_truck t) => t.InvCode == CS$<>8__locals1.invcode || t.InvCode == "" || t.InvCode == null);
			foreach (ModT_truck modT_truck in list2)
			{
				list.Add(new MulticolumnAutocompleteItem(new string[]
				{
					modT_truck.Lisence + ((modT_truck.CoachNum == "") ? "" : ("-" + modT_truck.CoachNum)),
					modT_truck.ProductName
				}, modT_truck.Lisence, true, true));
			}
			this.autocompleteMenu.SetAutocompleteItems(list);
			frmTicketEdit.<>c__DisplayClass29_0 CS$<>8__locals2 = CS$<>8__locals1;
			ModT_product model = DalT_product.Instance.GetModel("InvCode", CS$<>8__locals1.invcode);
			CS$<>8__locals2.productcode = ((model != null) ? model.Code.ToString() : null);
			List<AutocompleteItem> list3 = new List<AutocompleteItem>();
			List<ModCfg_unit> list4 = this._unitList.FindAll(delegate(ModCfg_unit t)
			{
				List<string> list5 = new List<string>();
				list5.AddRange(t.CurProductCodeList.Split(new char[]
				{
					','
				}));
				return list5.Contains(CS$<>8__locals1.productcode);
			});
			foreach (ModCfg_unit modCfg_unit in list4)
			{
				list3.Add(new MulticolumnAutocompleteItem(new string[]
				{
					modCfg_unit.Name,
					modCfg_unit.CurProductName
				}, modCfg_unit.Name, true, true));
			}
			this.autocompleteMenuUnit.SetAutocompleteItems(list3);
			this.UpdateMenuTank(CS$<>8__locals1.invcode);
		}

		// Token: 0x0600010F RID: 271 RVA: 0x00021068 File Offset: 0x0001F268
		private void UpdateMenuTank(string invcode)
		{
			bool flag = invcode == "";
			if (!flag)
			{
				List<AutocompleteItem> list = new List<AutocompleteItem>();
				List<ModT_tank> list2 = this._tankList.FindAll((ModT_tank t) => t.InvCode == invcode);
				foreach (ModT_tank modT_tank in list2)
				{
					list.Add(new MulticolumnAutocompleteItem(new string[]
					{
						modT_tank.Name,
						modT_tank.ProductName
					}, modT_tank.Name, true, true));
				}
				this.autocompleteMenuTank.SetAutocompleteItems(list);
			}
		}

		// Token: 0x06000110 RID: 272 RVA: 0x00021138 File Offset: 0x0001F338
		private void dgvData_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
		{
			base.ToolTipHide();
			this.editControl = e.Control;
			this.lastSelectCell = this.dgvData.SelectedCells[0];
			bool flag = this.dgvData.Columns[this.dgvData.SelectedCells[0].ColumnIndex].Name == "C_CheNum";
			if (flag)
			{
				this.autocompleteMenu.SetAutocompleteMenu(this.editControl, this.autocompleteMenu);
			}
			bool flag2 = this.dgvData.Columns[this.dgvData.SelectedCells[0].ColumnIndex].Name == "C_UnitName";
			if (flag2)
			{
				this.autocompleteMenuUnit.SetAutocompleteMenu(this.editControl, this.autocompleteMenuUnit);
			}
			bool flag3 = this.dgvData.Columns[this.dgvData.SelectedCells[0].ColumnIndex].Name == "C_Tank";
			if (flag3)
			{
				this.autocompleteMenuTank.SetAutocompleteMenu(this.editControl, this.autocompleteMenuTank);
			}
		}

		// Token: 0x06000111 RID: 273 RVA: 0x0002126C File Offset: 0x0001F46C
		private void dgvData_CellEndEdit(object sender, DataGridViewCellEventArgs e)
		{
			this.autocompleteMenu.TargetControlWrapper = null;
			this.autocompleteMenu.SetAutocompleteMenu(this.editControl, null);
			this.autocompleteMenuUnit.TargetControlWrapper = null;
			this.autocompleteMenuUnit.SetAutocompleteMenu(this.editControl, null);
			this.autocompleteMenuTank.TargetControlWrapper = null;
			this.autocompleteMenuTank.SetAutocompleteMenu(this.editControl, null);
			DataGridViewRow selectrow = this.dgvData.Rows[this.lastSelectCell.RowIndex];
			bool flag = this.dgvData.Columns[this.lastSelectCell.ColumnIndex].Name == "C_CheNum";
			if (flag)
			{
				bool flag2 = selectrow.Cells["C_CheNum"].Value != null;
				if (flag2)
				{
					ModT_truck modT_truck = this._truckList.Find((ModT_truck o) => o.Lisence == selectrow.Cells["C_CheNum"].Value.ToString().Split(new char[]
					{
						'-'
					})[0]);
					bool flag3 = modT_truck != null;
					if (flag3)
					{
						selectrow.Cells["C_CheNum"].Value = modT_truck.Lisence;
						bool flag4 = modT_truck.InvCode != null && modT_truck.InvCode != "";
						if (flag4)
						{
							selectrow.Cells["C_Product"].Value = modT_truck.InvCode;
						}
						bool flag5 = selectrow.Cells["C_DanWei"].Value.ToString() == DanWei.kg.ToString();
						if (flag5)
						{
							selectrow.Cells["C_NetWeight"].Value = modT_truck.NetWeight;
						}
						bool flag6 = selectrow.Cells["C_DanWei"].Value.ToString() == DanWei.L.ToString();
						if (flag6)
						{
							selectrow.Cells["C_NetWeight"].Value = modT_truck.Vol * 1000m;
						}
						bool flag7 = decimal.Parse(selectrow.Cells["C_JiHuaLiang"].EditedFormattedValue.ToString()) < 1m;
						if (flag7)
						{
							selectrow.Cells["C_JiHuaLiang"].Value = selectrow.Cells["C_NetWeight"].Value;
						}
						bool flag8 = decimal.Parse(selectrow.Cells["C_JiHuaLiang"].EditedFormattedValue.ToString()) > decimal.Parse(selectrow.Cells["C_NetWeight"].EditedFormattedValue.ToString());
						if (flag8)
						{
							selectrow.Cells["C_JiHuaLiang"].Style.BackColor = Color.Red;
						}
						else
						{
							selectrow.Cells["C_JiHuaLiang"].Style.BackColor = Color.FromArgb(128, 255, 128);
						}
					}
				}
			}
			bool flag9 = this.dgvData.Columns[this.lastSelectCell.ColumnIndex].Name == "C_DanWei";
			if (flag9)
			{
				bool flag10 = selectrow.Cells["C_CheNum"].Value != null;
				if (flag10)
				{
					ModT_truck modT_truck2 = this._truckList.Find((ModT_truck o) => o.Lisence == selectrow.Cells["C_CheNum"].Value.ToString().Split(new char[]
					{
						'-'
					})[0]);
					bool flag11 = modT_truck2 != null;
					if (flag11)
					{
						bool flag12 = selectrow.Cells["C_DanWei"].Value.ToString() == DanWei.kg.ToString();
						if (flag12)
						{
							selectrow.Cells["C_NetWeight"].Value = modT_truck2.NetWeight;
						}
						bool flag13 = selectrow.Cells["C_DanWei"].Value.ToString() == DanWei.L.ToString();
						if (flag13)
						{
							selectrow.Cells["C_NetWeight"].Value = modT_truck2.Vol * 1000m;
						}
						bool flag14 = decimal.Parse(selectrow.Cells["C_JiHuaLiang"].EditedFormattedValue.ToString()) < 1m;
						if (flag14)
						{
							selectrow.Cells["C_JiHuaLiang"].Value = selectrow.Cells["C_NetWeight"].Value;
						}
						bool flag15 = decimal.Parse(selectrow.Cells["C_JiHuaLiang"].EditedFormattedValue.ToString()) > decimal.Parse(selectrow.Cells["C_NetWeight"].EditedFormattedValue.ToString());
						if (flag15)
						{
							selectrow.Cells["C_JiHuaLiang"].Style.BackColor = Color.Red;
						}
						else
						{
							selectrow.Cells["C_JiHuaLiang"].Style.BackColor = Color.FromArgb(128, 255, 128);
						}
					}
				}
			}
			bool flag16 = this.dgvData.Columns[this.lastSelectCell.ColumnIndex].Name == "C_UnitName";
			if (flag16)
			{
				bool flag17 = selectrow.Cells["C_UnitName"].Value != null;
				if (flag17)
				{
					Predicate<ModCfg_unit> <>9__3;
					ModT_tank modT_tank = this._tankList.Find(delegate(ModT_tank t)
					{
						int code = t.Code;
						List<ModCfg_unit> unitList = this._unitList;
						Predicate<ModCfg_unit> match;
						if ((match = <>9__3) == null)
						{
							match = (<>9__3 = ((ModCfg_unit o) => o.Name == selectrow.Cells["C_UnitName"].Value.ToString()));
						}
						ModCfg_unit modCfg_unit = unitList.Find(match);
						int? num = (modCfg_unit != null) ? new int?(modCfg_unit.TankCode) : null;
						return code == num.GetValueOrDefault() & num != null;
					});
					bool flag18 = modT_tank != null;
					if (flag18)
					{
						selectrow.Cells["C_Tank"].Value = modT_tank.Name;
					}
				}
			}
			bool flag19 = this.dgvData.Columns[this.lastSelectCell.ColumnIndex].Name == "C_Product";
			if (flag19)
			{
				bool flag20 = selectrow.Cells["C_Product"].Value != null;
				if (flag20)
				{
					this.UpdateProduct(selectrow.Cells["C_Product"].Value.ToString());
				}
			}
		}

		// Token: 0x06000112 RID: 274 RVA: 0x0002197C File Offset: 0x0001FB7C
		private void dgvData_CellLeave(object sender, DataGridViewCellEventArgs e)
		{
			bool flag = this.dgvData.Columns[this.dgvData.SelectedCells[0].ColumnIndex].Name == "C_JiHuaLiang";
			if (flag)
			{
				bool flag2 = decimal.Parse(this.dgvData.Rows[this.dgvData.SelectedCells[0].RowIndex].Cells["C_JiHuaLiang"].EditedFormattedValue.ToString()) > decimal.Parse(this.dgvData.Rows[this.dgvData.SelectedCells[0].RowIndex].Cells["C_NetWeight"].EditedFormattedValue.ToString());
				if (flag2)
				{
					this.dgvData.Rows[this.dgvData.SelectedCells[0].RowIndex].Cells["C_JiHuaLiang"].Style.BackColor = Color.Red;
				}
				else
				{
					this.dgvData.Rows[this.dgvData.SelectedCells[0].RowIndex].Cells["C_JiHuaLiang"].Style.BackColor = Color.FromArgb(128, 255, 128);
				}
				base.ToolTipShow(this.editControl);
			}
		}

		// Token: 0x06000113 RID: 275 RVA: 0x00021B08 File Offset: 0x0001FD08
		private void dgvData_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
		{
			Rectangle bounds = new Rectangle(e.RowBounds.Location.X, e.RowBounds.Location.Y, this.dgvData.RowHeadersWidth - 4, e.RowBounds.Height);
			TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(), this.dgvData.RowHeadersDefaultCellStyle.Font, bounds, this.dgvData.RowHeadersDefaultCellStyle.ForeColor, TextFormatFlags.Right | TextFormatFlags.VerticalCenter);
		}

		// Token: 0x06000114 RID: 276 RVA: 0x00021BA4 File Offset: 0x0001FDA4
		private void dgvData_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
		{
			try
			{
				this.dgvData.Rows[this.dgvData.Rows.Count - 1].Cells["C_DanWei"].Value = this.dgvData.Rows[this.dgvData.Rows.Count - 2].Cells["C_DanWei"].EditedFormattedValue;
			}
			catch
			{
			}
		}

		// Token: 0x06000115 RID: 277 RVA: 0x00021C38 File Offset: 0x0001FE38
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
							diBangValue = DAL.MySQL.DalDiBangRecord.Instance.GetDiBangValue(model, dataGridViewRow.Cells["C_CheNum"].Value.ToString(), starttime, endtime, 1);
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
						dataGridViewRow.Cells["C_FirstTime"].Value = diBangValue.FirstTime;
					}
					else
					{
						base.ShowToast(this, Messages.NoWeighbridgeData, "", "");
					}
				}
			}
		}

		// Token: 0x06000116 RID: 278 RVA: 0x00012473 File Offset: 0x00010673
		private void btnItemC_Click(object sender, EventArgs e)
		{
			this.OpenForm(typeof(frmItemChoose), ((ButtonItem)sender).Text, new object[]
			{
				"t_ticket",
				base.Name
			});
		}

		// Token: 0x06000117 RID: 279 RVA: 0x00021EA0 File Offset: 0x000200A0
		private bool IsTakeCardCheckTicketCount(List<string> listInvCodes)
		{
			string text = "( ";
			foreach (string str in listInvCodes)
			{
				text = text + " InvCode='" + str + "'  or";
			}
			text = text.Remove(text.Length - 2);
			text += " )";
			List<ModT_product> listRequire = DalT_product.Instance.GetListRequire(new List<string>
			{
				text
			}, null, null);
			bool flag = listRequire.Count == 0;
			bool result;
			if (flag)
			{
				base.ShowMsg("物料未选择", "", "");
				result = false;
			}
			else
			{
				foreach (ModT_product modT_product in listRequire)
				{
					string formula = string.Concat(new string[]
					{
						"[InvCode] = '",
						modT_product.InvCode,
						"' and [TakeCardTime] like '",
						DateTime.Today.ToString("yyyy-MM-dd"),
						"%'"
					});
					int listCount = DalT_ticket.Instance.GetListCount(formula);
					bool flag2 = bool.Parse(modT_product.IsTicketPerDay.ToString());
					int num = int.Parse(modT_product.TicketPerDay.ToString());
					bool flag3 = flag2 && listCount >= num;
					if (flag3)
					{
						base.ShowMsg("物料编号:" + modT_product.InvCode + "超出每日限制", "", "");
						return false;
					}
				}
				result = true;
			}
			return result;
		}

		// Token: 0x040001E0 RID: 480
		private ModT_ticket _mod = new ModT_ticket();

		// Token: 0x040001E1 RID: 481
		private List<ModT_ticket> _list = new List<ModT_ticket>();

		// Token: 0x040001E2 RID: 482
		private List<ModT_truck> _truckList = new List<ModT_truck>();

		// Token: 0x040001E3 RID: 483
		private List<ModCfg_unit> _unitList = new List<ModCfg_unit>();

		// Token: 0x040001E4 RID: 484
		private List<ModT_tank> _tankList = new List<ModT_tank>();

		// Token: 0x040001E5 RID: 485
		private List<ModT_trucktype> _trucktypeList = new List<ModT_trucktype>();

		// Token: 0x040001E6 RID: 486
		private List<ModT_product> _productList = new List<ModT_product>();

		// Token: 0x040001E7 RID: 487
		private AutocompleteMenu autocompleteMenu = new AutocompleteMenu();

		// Token: 0x040001E8 RID: 488
		private AutocompleteMenu autocompleteMenuUnit = new AutocompleteMenu();

		// Token: 0x040001E9 RID: 489
		private AutocompleteMenu autocompleteMenuTank = new AutocompleteMenu();

		// Token: 0x040001EA RID: 490
		private string _invcode;

		// Token: 0x040001EB RID: 491
		private int _StaticColumnCount;

		// Token: 0x040001EC RID: 492
		private Control editControl;

		// Token: 0x040001ED RID: 493
		private DataGridViewCell lastSelectCell;
	}
}
