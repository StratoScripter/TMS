using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
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
using LTDesign;
using Model;
using Model.SQSConfig;
using SQSClient.Properties;

namespace SQSClient
{
	// Token: 0x0200007A RID: 122
	public partial class frmReport : BaseDialogForm
	{
		// Token: 0x060006B5 RID: 1717 RVA: 0x000A42C4 File Offset: 0x000A24C4
		public frmReport()
		{
			this.InitializeComponent();
			this.SetText(this);
			this._Controls.Clear();
			this._Controls.Add(this.bar);
		}

		// Token: 0x060006B6 RID: 1718 RVA: 0x000A4318 File Offset: 0x000A2518
		private void frmReport_Load(object sender, EventArgs e)
		{
			base.InitBurron();
			this.InitControl();
			base.CreateDgv(this.dgvData, "c_t_ticket_" + base.Name);
		}

		// Token: 0x060006B7 RID: 1719 RVA: 0x000A4348 File Offset: 0x000A2548
		private void InitControl()
		{
			this.cmbUnit.BindDataSouce(DalCfg_unit.Instance.GetAllList(), "Name", "PinYinMa", "Id");
			this.cmbProduct.BindDataSouce(DalT_product.Instance.GetListByState(1, 0), "InvName", "PinYinMa", "InvCode");
			this.cmbClient.BindDataSouce(DalT_client.Instance.GetAllList(), "Name", "PinYinMa", "Id");
			List<AutocompleteItem> list = new List<AutocompleteItem>();
			List<ModT_truck> allList = DalT_truck.Instance.GetAllList();
			foreach (ModT_truck modT_truck in allList)
			{
				list.Add(new MulticolumnAutocompleteItem(new string[]
				{
					modT_truck.Lisence + ((modT_truck.CoachNum == "") ? "" : ("-" + modT_truck.CoachNum)),
					modT_truck.ProductName
				}, modT_truck.Lisence + ((modT_truck.CoachNum == "") ? "" : ("-" + modT_truck.CoachNum)), true, true));
			}
			AutocompleteMenu autocompleteMenu = new AutocompleteMenu();
			autocompleteMenu.MaximumSize = new Size(300, 200);
			autocompleteMenu.MinFragmentLength = 1;
			autocompleteMenu.SetAutocompleteItems(list);
			autocompleteMenu.SetAutocompleteMenu(this.txtCheNum, autocompleteMenu);
			BaseForm.EnumModel enumModel = new BaseForm.EnumModel();
			enumModel.Name = "All";
			enumModel.Description = ShowWords.ReplaceText("All");
			enumModel.Value = -1;
			List<BaseForm.EnumModel> list2 = new List<BaseForm.EnumModel>();
			list2.Add(enumModel);
			list2.AddRange(BaseForm.GetEnumModelList<AccountType>());
			BaseForm.BindDataSouce(this.cmbAccountType, list2, "Description", "Value");
			List<BaseForm.EnumModel> list3 = new List<BaseForm.EnumModel>();
			list3.Add(enumModel);
			list3.AddRange(BaseForm.GetEnumModelList<BusinessType>());
			BaseForm.BindDataSouce(this.cmbBusinessType, list3, "Description", "Value");
			AutocompleteMenu autocompleteMenu2 = new AutocompleteMenu();
			autocompleteMenu2.TargetControlWrapper = null;
			autocompleteMenu2.SetAutocompleteMenu(this.txtJieSuanRen, null);
			List<AutocompleteItem> list4 = new List<AutocompleteItem>();
			List<ModSys_user> list5 = DalSys_user.Instance.GetList("State", true);
			foreach (ModSys_user modSys_user in list5)
			{
				list4.Add(new SubstringAutocompleteItem(modSys_user.UserName, false));
			}
			autocompleteMenu2.MinFragmentLength = 1;
			autocompleteMenu2.SetAutocompleteMenu(this.txtJieSuanRen, autocompleteMenu2);
			autocompleteMenu2.SetAutocompleteItems(list4);
			this.txtJieSuanRen.Text = GlobalKey.UserName;
			this.dtpStartTime.Value = DateTimeAction.DayStartD(DateTime.Now);
			this.dtpEndTime.Value = DateTimeAction.DayEndD(DateTime.Now);
		}

		// Token: 0x060006B8 RID: 1720 RVA: 0x000A4670 File Offset: 0x000A2870
		private void btnSearch_Click(object sender, EventArgs e)
		{
			bool flag = !base.TimeCheck(this.dtpStartTime.Value, this.dtpEndTime.Value);
			if (!flag)
			{
				List<string> list = new List<string>();
				list.Add("Status=2");
				bool flag2 = !string.IsNullOrWhiteSpace(this.cmbUnit.Text.Trim());
				if (flag2)
				{
					list.Add("UnitName='" + this.cmbUnit.Text.Trim() + "'");
				}
				bool flag3 = !string.IsNullOrWhiteSpace(this.cmbProduct.Text.Trim());
				if (flag3)
				{
					List<string> list2 = list;
					string str = "InvCode='";
					object selectedValue = this.cmbProduct.SelectedValue;
					list2.Add(str + ((selectedValue != null) ? selectedValue.ToString() : null) + "'");
				}
				bool flag4 = !string.IsNullOrWhiteSpace(this.cmbClient.Text.Trim());
				if (flag4)
				{
					list.Add("ClientPart='" + this.cmbClient.Text.Trim() + "'");
				}
				bool flag5 = !string.IsNullOrWhiteSpace(this.txtCheNum.Text.Trim());
				if (flag5)
				{
					list.Add("Lisence='" + this.txtCheNum.Text.Trim() + "'");
				}
				bool flag6 = !string.IsNullOrWhiteSpace(this.txtJieSuanRen.Text.Trim());
				if (flag6)
				{
					list.Add("JieSuanRen='" + this.txtJieSuanRen.Text.Trim() + "'");
				}
				bool flag7 = !string.IsNullOrWhiteSpace(this.dtpStartTime.Text);
				if (flag7)
				{
					list.Add("JieSuanTime>='" + this.dtpStartTime.Text + "'");
				}
				bool flag8 = !string.IsNullOrWhiteSpace(this.dtpEndTime.Text);
				if (flag8)
				{
					list.Add("JieSuanTime<='" + this.dtpEndTime.Text + "'");
				}
				int? num = (int?)this.cmbAccountType.SelectedValue;
				int num2 = 0;
				bool flag9 = num.GetValueOrDefault() >= num2 & num != null;
				if (flag9)
				{
					list.Add("AccountType='" + ((int?)this.cmbAccountType.SelectedValue).ToString() + "'");
				}
				bool flag10 = (int)this.cmbBusinessType.SelectedValue > -1;
				if (flag10)
				{
					list.Add("BusinessType='" + ((int)this.cmbBusinessType.SelectedValue).ToString() + "'");
				}
				bool manageself = GlobalKey.Manageself;
				if (manageself)
				{
					list.Add("ZhiDanRen='" + GlobalKey.UserName + "'");
				}
				bool flag11 = Settings.Instance.LocalTicketType > 0;
				if (flag11)
				{
					list.Add("TicketType=" + Settings.Instance.LocalTicketType.ToString());
				}
				List<ModT_ticket> listRequire = DalT_ticket.Instance.GetListRequire(list, new List<string>
				{
					"Id"
				}, null);
				this.list.Clear();
				foreach (ModT_ticket mod in listRequire)
				{
					this.list.Add(ChangeShowMod.DataChange(mod));
				}
				this.BoundData(this.list);
				bool flag12 = this.list.Count < 1;
				if (flag12)
				{
					base.ShowMsg(Messages.NoRecord, "", "");
				}
			}
		}

		// Token: 0x060006B9 RID: 1721 RVA: 0x000A4A60 File Offset: 0x000A2C60
		public void BoundData(List<ShowModT_ticket> list)
		{
			this.dgvData.DataSource = null;
			this.dgvData.AutoGenerateColumns = false;
			this.dgvData.DataSource = list;
		}

		// Token: 0x060006BA RID: 1722 RVA: 0x000A4A8C File Offset: 0x000A2C8C
		private void UpdateView(List<ModT_ticket> list)
		{
			this.dgvData.Rows.Clear();
			decimal d = 0m;
			decimal d2 = 0m;
			decimal d3 = 0m;
			decimal d4 = 0m;
			decimal d5 = 0m;
			decimal d6 = 0m;
			decimal d7 = 0m;
			foreach (ModT_ticket modT_ticket in list)
			{
				object[] array = new object[this.dgvData.ColumnCount];
				int num = 0;
				array[num++] = modT_ticket.Id.ToString();
				array[num++] = modT_ticket.UnitName;
				array[num++] = modT_ticket.DanHao;
				array[num++] = modT_ticket.ClientPart;
				array[num++] = modT_ticket.Lisence;
				array[num++] = modT_ticket.CangNum.ToString();
				array[num++] = modT_ticket.CardNum;
				array[num++] = modT_ticket.ProductName;
				array[num++] = modT_ticket.JiHuaLiang;
				array[num++] = modT_ticket.ShiJiLiang;
				array[num++] = modT_ticket.FirstWeight;
				array[num++] = modT_ticket.SecondWeight;
				array[num++] = modT_ticket.DifferWeight;
				array[num++] = modT_ticket.FWDiffer;
				array[num++] = modT_ticket.JieSuanLiang;
				array[num++] = modT_ticket.DanWei;
				array[num++] = modT_ticket.ZhiDanRen;
				array[num++] = modT_ticket.JieSuanRen;
				array[num++] = modT_ticket.ZhiDanTime.ToString("yyyy-MM-dd HH:mm:ss");
				array[num++] = modT_ticket.StartTime.ToString("yyyy-MM-dd HH:mm:ss");
				bool flag = modT_ticket.Status == 2;
				if (flag)
				{
					array[num++] = modT_ticket.EndTime.ToString("yyyy-MM-dd HH:mm:ss");
				}
				else
				{
					array[num++] = "";
				}
				array[num++] = modT_ticket.FirstTime;
				array[num++] = modT_ticket.SecondTime;
				bool flag2 = modT_ticket.State >= 1;
				if (flag2)
				{
					array[num++] = modT_ticket.JieSuanTime.ToString("yyyy-MM-dd HH:mm:ss");
				}
				else
				{
					array[num++] = "";
				}
				array[num++] = modT_ticket.QianFengHao;
				this.dgvData.Rows.Add(array);
				d += modT_ticket.JiHuaLiang;
				d2 += modT_ticket.ShiJiLiang;
				d3 += modT_ticket.FirstWeight;
				d4 += modT_ticket.SecondWeight;
				d5 += modT_ticket.DifferWeight;
				d6 += modT_ticket.FWDiffer;
				d7 += modT_ticket.JieSuanLiang;
			}
			int num2 = 0;
			string[] array2 = new string[this.dgvData.ColumnCount];
			num2++;
			array2[num2++] = ShowWords.ReplaceText("Summary");
			num2 += 6;
			array2[num2++] = d.ToString();
			array2[num2++] = d2.ToString();
			array2[num2++] = d3.ToString();
			array2[num2++] = d4.ToString();
			array2[num2++] = d5.ToString();
			array2[num2++] = d6.ToString();
			array2[num2++] = d7.ToString();
			DataGridViewRowCollection rows = this.dgvData.Rows;
			object[] values = array2;
			rows.Add(values);
		}

		// Token: 0x060006BB RID: 1723 RVA: 0x000A4EEC File Offset: 0x000A30EC
		private void btnExport_Click(object sender, EventArgs e)
		{
			base.ExportExcel(this.dgvData);
		}

		// Token: 0x060006BC RID: 1724 RVA: 0x000A4EFC File Offset: 0x000A30FC
		private void cmbAccountType_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.dgvData.DataSource = null;
		}

		// Token: 0x060006BD RID: 1725 RVA: 0x000A4F0C File Offset: 0x000A310C
		private void btnPrint_Click(object sender, EventArgs e)
		{
			string value = DalCfg_setting.Instance.GetModel("Item", "HisReportFile").Value;
			MyPrint myPrint = new MyPrint(value, Settings.Instance.HisReportPrinter);
			myPrint.ClearDataSource();
			List<Dictionary<string, object>> list = new List<Dictionary<string, object>>();
			for (int i = 0; i < this.list.Count; i++)
			{
				list.Add(ModelHelper.ReturnDic<ShowModT_ticket>(this.list[i], ""));
			}
			bool flag = list.Count == 0;
			if (flag)
			{
				base.ShowMsg(Messages.NoData, "", "");
			}
			myPrint.AddDataSource("t_ticket", list);
			myPrint.ClearCustomDataSource();
			myPrint.AddCustomDataSource(new List<object>
			{
				this.list.Count,
				this.cmbAccountType.Text,
				this.cmbBusinessType.Text,
				this.dtpStartTime.Text,
				this.dtpEndTime.Text,
				this.cmbUnit.Text,
				this.cmbProduct.Text,
				this.cmbClient.Text,
				this.txtCheNum.Text,
				this.txtJieSuanRen.Text
			});
			bool flag2 = new frmPrintShow(myPrint)
			{
				Icon = base.Icon,
				Text = ShowWords.ReplaceText("Preview")
			}.ShowDialog() == DialogResult.Yes;
			if (flag2)
			{
				myPrint.Close();
			}
		}

		// Token: 0x060006BE RID: 1726 RVA: 0x00012473 File Offset: 0x00010673
		private void btnItemC_Click(object sender, EventArgs e)
		{
			this.OpenForm(typeof(frmItemChoose), ((ButtonItem)sender).Text, new object[]
			{
				"t_ticket",
				base.Name
			});
		}

		// Token: 0x060006BF RID: 1727 RVA: 0x00003040 File Offset: 0x00001240
		private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
		}

		// Token: 0x04000B69 RID: 2921
		private List<ShowModT_ticket> list = new List<ShowModT_ticket>();
	}
}
