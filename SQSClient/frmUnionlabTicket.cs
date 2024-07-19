using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Assistant;
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
	// Token: 0x0200009A RID: 154
	public partial class frmUnionlabTicket : BaseDialogForm
	{
		// Token: 0x06000886 RID: 2182 RVA: 0x000D3E88 File Offset: 0x000D2088
		public frmUnionlabTicket()
		{
			this.InitializeComponent();
			this.SetText(this);
			this._Controls.Clear();
			this._Controls.Add(this.bar);
			this._Controls.Add(this.dgvUnionLabMain);
			this._Controls.Add(this.barDetail);
			this._Controls.Add(this.dgvData);
			this._Controls.Add(this.contextMenuStrip);
		}

		// Token: 0x06000887 RID: 2183 RVA: 0x000D3F70 File Offset: 0x000D2170
		private void frmUnionlabTicket_Load(object sender, EventArgs e)
		{
			base.InitBurron();
			this.InitControl();
			this._StaticColumnCount = this.dgvUnionLabMain.Columns.Count;
			base.CreateDgv(this.dgvUnionLabMain, "c_t_unionlab_" + base.Name);
			this.LoadMain(0);
			ModCfg_setting model = DalCfg_setting.Instance.GetModel("Item", "DumpDays");
			bool flag = model != null && model.Value != "0";
			if (flag)
			{
				string time = DateTime.Now.AddDays((double)(-(double)int.Parse(model.Value))).ToString("yyyy-MM-dd 00:00:00");
				DalT_ticket.Instance.UpdateData(time);
			}
		}

		// Token: 0x06000888 RID: 2184 RVA: 0x000D402C File Offset: 0x000D222C
		private void InitControl()
		{
			this.dtpDate.Value = DateTime.Now;
			BaseForm.EnumModel enumModel = new BaseForm.EnumModel();
			enumModel.Name = "All";
			enumModel.Description = ShowWords.ReplaceText("All");
			enumModel.Value = -1;
			List<BaseForm.EnumModel> list = new List<BaseForm.EnumModel>();
			list.Add(enumModel);
			list.AddRange(BaseForm.GetEnumModelList<LabStatus>());
			BaseForm.BindDataSouce(this.cmbUnionLabStatus, list, "Description", "Value");
			List<BaseForm.EnumModel> list2 = new List<BaseForm.EnumModel>();
			list2.Add(enumModel);
			list2.AddRange(BaseForm.GetEnumModelList<CheckResult>());
			BaseForm.BindDataSouce(this.cmbUnionLabResult, list2, "Description", "Value");
			List<BaseForm.EnumModel> list3 = new List<BaseForm.EnumModel>();
			list3.Add(enumModel);
			list3.AddRange(BaseForm.GetEnumModelList<RdBusType>());
			BaseForm.BindDataSouce(this.cmbBusinessType, list3, "Description", "Value");
			this.cmbWhName.BindDataSouce(DalCs_warehouse.Instance.GetAllList(), "WhName", "PinYinMa", "WhCode");
			this.cmbProduct.BindDataSouce(DalT_product.Instance.GetListByState(1, 0), "Name", "PinYinMa", "Id");
			this.MaxFWDifferSetting = DalCfg_setting.Instance.GetModel("Item", "MaxFWDiffer");
		}

		// Token: 0x06000889 RID: 2185 RVA: 0x000D4174 File Offset: 0x000D2374
		private void btnQuery_Click(object sender, EventArgs e)
		{
			this.LoadMain(this.mSelectRecordRowIndex);
		}

		// Token: 0x0600088A RID: 2186 RVA: 0x000D4184 File Offset: 0x000D2384
		private void LoadMain(int selectRowIndex)
		{
			this.dgvUnionLabMain.Rows.Clear();
			this.GetList();
			int num = 0;
			foreach (ModT_unionlab modT_unionlab in this.mUnionLabList)
			{
				object[] array = new object[this.dgvUnionLabMain.ColumnCount];
				int num2 = 0;
				array[num2++] = modT_unionlab.Id;
				array[num2++] = modT_unionlab.UnionLabIndex;
				array[num2++] = modT_unionlab.UnionLabCode;
				array[num2++] = modT_unionlab.UnionLabName;
				array[num2++] = ShowWords.ReplaceText(EnumHelper.GetDescription<RdBusType>((RdBusType)Convert.ToInt32(modT_unionlab.BusinessType)));
				array[num2++] = ShowWords.ReplaceText(EnumHelper.GetDescription<LabStatus>((LabStatus)Convert.ToInt32(modT_unionlab.UnionLabStatus)));
				array[num2++] = ShowWords.ReplaceText(EnumHelper.GetDescription<CheckResult>((CheckResult)Convert.ToInt32(modT_unionlab.UnionLabResult)));
				array[num2++] = modT_unionlab.UnionLabMan;
				array[num2++] = modT_unionlab.UnionLabTime.ToString("yyyy-MM-dd HH:mm:ss");
				array[num2++] = modT_unionlab.UnionLabCount;
				array[num2++] = modT_unionlab.Creater;
				array[num2++] = modT_unionlab.CreateTime.ToString("yyyy-MM-dd");
				array[num2++] = modT_unionlab.Modifier;
				array[num2++] = modT_unionlab.ModifyTime.ToString("yyyy-MM-dd");
				array[num2++] = ShowWords.ReplaceText(EnumHelper.GetDescription<UnionLabStatus>((UnionLabStatus)modT_unionlab.UnionStatus));
				for (int i = this._StaticColumnCount; i < this.dgvUnionLabMain.ColumnCount; i++)
				{
					array[i] = base.GetValueMod<ModT_unionlab>(modT_unionlab, this.dgvUnionLabMain.Columns[i].DataPropertyName);
				}
				this.dgvUnionLabMain.Rows.Add(array);
				num++;
			}
			bool flag = this.dgvUnionLabMain.Rows.Count > 0;
			if (flag)
			{
				this.mSelectRecordRowIndex = ((selectRowIndex > this.dgvUnionLabMain.Rows.Count - 1) ? 0 : selectRowIndex);
				this.dgvUnionLabMain.Rows[this.mSelectRecordRowIndex].Selected = true;
				this.GetCurrentMainItem(this.mSelectRecordRowIndex);
				this.SetMainBtnEnabled(true);
			}
			else
			{
				this.SetMainBtnEnabled(false);
			}
			this.gPanelToRdRecords.Text = ShowWords.ReplaceText("ToUnionLabs") + "(" + this.dgvUnionLabMain.RowCount.ToString() + ")";
			this.labCount.Text = ShowWords.ReplaceText("Orders") + " " + this.dgvUnionLabMain.RowCount.ToString();
		}

		// Token: 0x0600088B RID: 2187 RVA: 0x000D44AC File Offset: 0x000D26AC
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

		// Token: 0x0600088C RID: 2188 RVA: 0x000D4518 File Offset: 0x000D2718
		private void GetList()
		{
			List<string> list = new List<string>();
			bool flag = (int)this.cmbUnionLabStatus.SelectedValue > -1;
			if (flag)
			{
				List<string> list2 = list;
				string str = "UnionLabStatus=";
				object selectedValue = this.cmbUnionLabStatus.SelectedValue;
				list2.Add(str + ((selectedValue != null) ? selectedValue.ToString() : null));
			}
			bool flag2 = (int)this.cmbUnionLabResult.SelectedValue > -1;
			if (flag2)
			{
				List<string> list3 = list;
				string str2 = "UnionLabResult=";
				object selectedValue2 = this.cmbUnionLabResult.SelectedValue;
				list3.Add(str2 + ((selectedValue2 != null) ? selectedValue2.ToString() : null));
			}
			bool flag3 = (int)this.cmbBusinessType.SelectedValue > -1;
			if (flag3)
			{
				List<string> list4 = list;
				string str3 = "BusinessType=";
				object selectedValue3 = this.cmbBusinessType.SelectedValue;
				list4.Add(str3 + ((selectedValue3 != null) ? selectedValue3.ToString() : null));
			}
			bool flag4 = !string.IsNullOrWhiteSpace(this.txtUnionLabName.Text.Trim());
			if (flag4)
			{
				list.Add("UnionLabName like '" + this.txtUnionLabName.Text.Trim() + "'");
			}
			bool @checked = this.chkIsUseDate.Checked;
			if (@checked)
			{
				list.Add("CreateTime>='" + this.dtpDate.Value.ToString("yyyy-MM-dd 00:00:00") + "'");
				list.Add("CreateTime<='" + this.dtpDate.Value.AddDays(1.0).ToString("yyyy-MM-dd 00:00:00") + "'");
			}
			bool manageself = GlobalKey.Manageself;
			if (manageself)
			{
				list.Add("Creater='" + GlobalKey.UserName + "'");
			}
			this.mUnionLabList = DalT_unionlab.Instance.GetListRequire(list, new List<string>
			{
				"Id desc"
			}, null);
		}

		// Token: 0x0600088D RID: 2189 RVA: 0x0004EF3A File Offset: 0x0004D13A
		private void btnItemCRd_Click(object sender, EventArgs e)
		{
			this.OpenForm(typeof(frmItemChoose), ((ButtonItem)sender).Text, new object[]
			{
				"cs_rdrecord",
				base.Name
			});
		}

		// Token: 0x0600088E RID: 2190 RVA: 0x000D4704 File Offset: 0x000D2904
		private void dgvUnionLabMain_SelectionChanged(object sender, EventArgs e)
		{
			bool flag = this.dgvUnionLabMain.SelectedRows.Count > 0;
			if (flag)
			{
				this.GetCurrentMainItem(this.dgvUnionLabMain.SelectedRows[0].Index);
			}
		}

		// Token: 0x0600088F RID: 2191 RVA: 0x000D4748 File Offset: 0x000D2948
		private void dgvUnionLabMain_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			bool flag = e.RowIndex >= 0;
			if (flag)
			{
				this.GetCurrentMainItem(e.RowIndex);
			}
		}

		// Token: 0x06000890 RID: 2192 RVA: 0x000D4778 File Offset: 0x000D2978
		private void dgvUnionLabMain_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			bool flag = e.RowIndex >= 0;
			if (flag)
			{
				this.GetCurrentMainItem(e.RowIndex);
				this.OpenMainForm(this.Text, BaseForm.FormActtion.Modify, this._FrmName);
			}
		}

		// Token: 0x06000891 RID: 2193 RVA: 0x000D47BC File Offset: 0x000D29BC
		private void GetCurrentMainItem(int rowindex)
		{
			this.mCurrentUnionLabId = int.Parse(this.dgvUnionLabMain.Rows[rowindex].Cells[0].Value.ToString());
			this.mCurrentUnionLabIndex = int.Parse(this.dgvUnionLabMain.Rows[rowindex].Cells[1].Value.ToString());
			this.mSelectRecordRowIndex = rowindex;
			this.LoadDetail(this.mSelectIndex);
		}

		// Token: 0x06000892 RID: 2194 RVA: 0x000D4840 File Offset: 0x000D2A40
		protected void OpenMainForm(string text, BaseForm.FormActtion action, string d)
		{
			frmUnionlabEdit frmUnionlabEdit = new frmUnionlabEdit(text, action, this.mCurrentUnionLabId, d);
			bool flag = this._Mod != null;
			if (flag)
			{
				frmUnionlabEdit._ParentMenuId = this._Mod.MenuId;
			}
			this.isEditOpen = true;
			bool flag2 = frmUnionlabEdit.ShowDialog() == DialogResult.Yes;
			if (flag2)
			{
				this.LoadMain(this.mSelectRecordRowIndex);
			}
			this.isEditOpen = false;
		}

		// Token: 0x06000893 RID: 2195 RVA: 0x000D48A7 File Offset: 0x000D2AA7
		private void btnModifyRd_Click(object sender, EventArgs e)
		{
			this.OpenMainForm(this.Text, BaseForm.FormActtion.Modify, this._FrmName);
		}

		// Token: 0x06000894 RID: 2196 RVA: 0x000D48C0 File Offset: 0x000D2AC0
		private void btnDeleteRd_Click(object sender, EventArgs e)
		{
			bool flag = !base.ShowChoise(Messages.DeleteSure, "", "");
			if (!flag)
			{
				bool flag2 = DalT_ticket.Instance.GetCountByUnionLabIndex(this.mCurrentUnionLabIndex) > 0;
				if (flag2)
				{
					base.ShowMsg(ShowWords.ReplaceText(Messages.TicketLimitDelete), "", "");
				}
				else
				{
					ModT_unionlab model = DalT_unionlab.Instance.GetModel("UnionLabIndex", this.mCurrentUnionLabIndex);
					bool flag3 = DalT_unionlab.Instance.Delete("UnionLabIndex", this.mCurrentUnionLabIndex);
					if (flag3)
					{
						this.OnOperateSuccess(model, true);
						this.mSelectRecordRowIndex = 0;
						this.LoadMain(this.mSelectRecordRowIndex);
					}
					else
					{
						base.ShowMsg(ShowWords.ReplaceText(Messages.DeleteFalse), "", "");
					}
				}
			}
		}

		// Token: 0x06000895 RID: 2197 RVA: 0x000D49A3 File Offset: 0x000D2BA3
		private void btnAddRd_Click(object sender, EventArgs e)
		{
			this.OpenMainForm(this.Text, BaseForm.FormActtion.Add, this._FrmName);
		}

		// Token: 0x06000896 RID: 2198 RVA: 0x000D49BC File Offset: 0x000D2BBC
		private void btnSettleStockRd_Click(object sender, EventArgs e)
		{
			foreach (ModT_ticket modT_ticket in this._list)
			{
			}
		}

		// Token: 0x06000897 RID: 2199 RVA: 0x000D4A10 File Offset: 0x000D2C10
		private void LoadDetail(int selectRowIndex)
		{
			this.dgvData.Rows.Clear();
			List<string> list = new List<string>();
			list.Add("UnionLabIndex = " + this.mCurrentUnionLabIndex.ToString());
			List<ModT_ticket> listRequire = DalT_ticket.Instance.GetListRequire(list, new List<string>
			{
				"Id Desc"
			}, null);
			this.dgvData.Rows.Clear();
			foreach (ModT_ticket modT_ticket in listRequire)
			{
				object[] array = new object[this.dgvData.ColumnCount];
				int num = 0;
				array[num++] = modT_ticket.Id;
				array[num++] = modT_ticket.DanHao;
				array[num++] = modT_ticket.ContractNum;
				array[num++] = ShowWords.ReplaceText(EnumHelper.GetDescription<BusinessType>((BusinessType)modT_ticket.BusinessType));
				array[num++] = modT_ticket.ClientPart;
				array[num++] = modT_ticket.Lisence;
				array[num++] = modT_ticket.UnitName;
				array[num++] = modT_ticket.ProductName;
				array[num++] = modT_ticket.JiHuaLiang;
				array[num++] = modT_ticket.ShiJiLiang;
				array[num++] = modT_ticket.FirstWeight;
				array[num++] = modT_ticket.SecondWeight;
				array[num++] = modT_ticket.DifferWeight;
				array[num++] = modT_ticket.DanWei;
				array[num++] = ShowWords.ReplaceText(EnumHelper.GetDescription<TicketStatus>((TicketStatus)modT_ticket.Status));
				array[num++] = ShowWords.ReplaceText(((LabStatus)modT_ticket.LabStatus).ToString());
				array[num++] = ShowWords.ReplaceText(((CheckResult)modT_ticket.LabResult).ToString());
				array[num++] = modT_ticket.LabMan;
				array[num++] = modT_ticket.LabTime;
				array[num++] = modT_ticket.LabCount;
				array[num++] = ShowWords.ReplaceText(EnumHelper.GetDescription<TicketState>((TicketState)modT_ticket.State));
				array[num++] = modT_ticket.Remark;
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

		// Token: 0x06000898 RID: 2200 RVA: 0x000D4D3C File Offset: 0x000D2F3C
		private void SetDetailBtnEnabled(bool enabled)
		{
			this.btnRemoveBill.Enabled = enabled;
			this.btnPrint.Enabled = enabled;
		}

		// Token: 0x06000899 RID: 2201 RVA: 0x000D4D5C File Offset: 0x000D2F5C
		private void btnImportBill_Click(object sender, EventArgs e)
		{
			this.mSelectIndex = 0;
			string selectIds = this.OpenRelationForm((ButtonItem)sender, BaseForm.FormActtion.Import, this._FrmName, "UnionLabIndex = 0");
			bool flag = this.ImportTicketBySelectIds(selectIds);
			if (flag)
			{
				this.LoadDetail(this.mSelectIndex);
			}
			this.OnOperateSuccess(this.mSelectIds, true);
		}

		// Token: 0x0600089A RID: 2202 RVA: 0x000D4DB8 File Offset: 0x000D2FB8
		private void btnRemoveBill_Click(object sender, EventArgs e)
		{
			bool flag = !base.ShowChoise(Messages.RemoveSure, "", "");
			if (!flag)
			{
				this.mSelectIndex = 0;
				string text = this.OpenRelationForm((ButtonItem)sender, BaseForm.FormActtion.Remove, this._FrmName, "UnionLabIndex = " + this.mCurrentUnionLabIndex.ToString());
				bool flag2 = this.RemoveTicketBySelectIds(text);
				if (flag2)
				{
					this.LoadDetail(this.mSelectIndex);
				}
				this.OnOperateSuccess(text, true);
			}
		}

		// Token: 0x0600089B RID: 2203 RVA: 0x000D4E40 File Offset: 0x000D3040
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

		// Token: 0x0600089C RID: 2204 RVA: 0x000D4ECC File Offset: 0x000D30CC
		protected bool ImportTicketBySelectIds(string selectIds)
		{
			return DalT_ticket.Instance.UpdateUnionLabIndex(this.mCurrentUnionLabIndex, selectIds.Trim(new char[]
			{
				','
			}));
		}

		// Token: 0x0600089D RID: 2205 RVA: 0x000D4F00 File Offset: 0x000D3100
		protected bool RemoveTicketBySelectIds(string selectIds)
		{
			return DalT_ticket.Instance.UpdateUnionLabIndex(0, selectIds.Trim(new char[]
			{
				','
			}));
		}

		// Token: 0x0600089E RID: 2206 RVA: 0x00003040 File Offset: 0x00001240
		private void btnDelete_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600089F RID: 2207 RVA: 0x00003040 File Offset: 0x00001240
		private void btnPrint_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060008A0 RID: 2208 RVA: 0x0004FAD4 File Offset: 0x0004DCD4
		private void frmUnionlabTicket_FormClosing(object sender, FormClosingEventArgs e)
		{
			base.Dispose();
		}

		// Token: 0x060008A1 RID: 2209 RVA: 0x000D4F30 File Offset: 0x000D3130
		private void GetCurrentItem(int rowindex)
		{
			this._CurrentId = int.Parse(this.dgvData.Rows[rowindex].Cells[0].Value.ToString());
			this._CurrentItemName = this.dgvData.Rows[rowindex].Cells["C_DanHao"].Value.ToString();
		}

		// Token: 0x060008A2 RID: 2210 RVA: 0x000D4FA0 File Offset: 0x000D31A0
		private void dgvData_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			bool flag = e.RowIndex >= 0;
			if (flag)
			{
				this.GetCurrentItem(e.RowIndex);
				this.mSelectIndex = e.RowIndex;
			}
		}

		// Token: 0x060008A3 RID: 2211 RVA: 0x000D4FDC File Offset: 0x000D31DC
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

		// Token: 0x060008A4 RID: 2212 RVA: 0x000D5088 File Offset: 0x000D3288
		private void ResetMenuStrips()
		{
			foreach (object obj in this.contextMenuStrip.Items)
			{
				ToolStripMenuItem toolStripMenuItem = (ToolStripMenuItem)obj;
				toolStripMenuItem.Enabled = false;
			}
		}

		// Token: 0x060008A5 RID: 2213 RVA: 0x000D50EC File Offset: 0x000D32EC
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

		// Token: 0x060008A6 RID: 2214 RVA: 0x000D5144 File Offset: 0x000D3344
		private void toolCheckRequest_Click(object sender, EventArgs e)
		{
			this.LabStatusCheck(1);
		}

		// Token: 0x060008A7 RID: 2215 RVA: 0x000D5150 File Offset: 0x000D3350
		private void dgvData_SelectionChanged(object sender, EventArgs e)
		{
			bool flag = this.dgvData.SelectedRows.Count > 0;
			if (flag)
			{
				this._CurrentId = int.Parse(this.dgvData.SelectedRows[0].Cells[0].Value.ToString());
			}
		}

		// Token: 0x060008A8 RID: 2216 RVA: 0x000D51A8 File Offset: 0x000D33A8
		private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			bool flag = e.RowIndex >= 0;
			if (flag)
			{
				this.GetCurrentItem(e.RowIndex);
				this.mSelectIndex = e.RowIndex;
			}
		}

		// Token: 0x060008A9 RID: 2217 RVA: 0x00003040 File Offset: 0x00001240
		private void dgvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
		}

		// Token: 0x060008AA RID: 2218 RVA: 0x000D51E4 File Offset: 0x000D33E4
		private void LabStatusCheck(int labStatus)
		{
			BatchLabHelper batchLabHelper = new BatchLabHelper();
			ModT_unionlab model = DalT_unionlab.Instance.GetModel(this.mCurrentUnionLabId);
			string text = batchLabHelper.UpdateTicketLabStatus(labStatus, model);
			bool flag = text.Length > 0;
			if (flag)
			{
				base.ShowMsg(ShowWords.ReplaceText(text), "", "");
			}
			this.OnOperateSuccess(new
			{
				TicketDanHao = model.UnionLabCode,
				OldLabStatus = model.UnionLabStatus,
				NewLabStatus = labStatus
			}, true);
		}

		// Token: 0x060008AB RID: 2219 RVA: 0x000D5258 File Offset: 0x000D3458
		private void btnSampling_Click(object sender, EventArgs e)
		{
			bool flag = !base.ShowChoise(Messages.SamplingSure, "", "");
			if (!flag)
			{
				this.UpdateTicketLabStatus(2);
			}
		}

		// Token: 0x060008AC RID: 2220 RVA: 0x000D5290 File Offset: 0x000D3490
		private void btnAnalysis_Click(object sender, EventArgs e)
		{
			bool flag = !base.ShowChoise(Messages.AnalysisSure, "", "");
			if (!flag)
			{
				this.UpdateTicketLabStatus(3);
			}
		}

		// Token: 0x060008AD RID: 2221 RVA: 0x000D52C5 File Offset: 0x000D34C5
		private void btnLab_Click(object sender, EventArgs e)
		{
			this.OpenLabEditForm(((ButtonItem)sender).Text, BaseForm.FormActtion.Modify);
		}

		// Token: 0x060008AE RID: 2222 RVA: 0x000D52DC File Offset: 0x000D34DC
		private void btnConfirm_Click(object sender, EventArgs e)
		{
			bool flag = !base.ShowChoise(Messages.ConfirmSure, "", "");
			if (!flag)
			{
				this.UpdateTicketLabStatus(5);
			}
		}

		// Token: 0x060008AF RID: 2223 RVA: 0x000D5314 File Offset: 0x000D3514
		protected void OpenLabEditForm(string title, BaseForm.FormActtion action)
		{
			bool flag = this.mCurrentUnionLabId == 0;
			if (!flag)
			{
				frmUnionLabDealEdit frmUnionLabDealEdit = new frmUnionLabDealEdit(title, action, this.mCurrentUnionLabId, this._FrmName);
				bool flag2 = frmUnionLabDealEdit.ShowDialog() == DialogResult.Yes;
				if (flag2)
				{
					base.ShowMsg(Messages.SaveTrue, "", "");
				}
			}
		}

		// Token: 0x060008B0 RID: 2224 RVA: 0x000D536C File Offset: 0x000D356C
		private void UpdateTicketLabStatus(int labStatus)
		{
			bool flag = this.mCurrentUnionLabId == 0;
			if (!flag)
			{
				ModT_unionlab model = DalT_unionlab.Instance.GetModel(this.mCurrentUnionLabId);
				bool flag2 = labStatus - model.UnionLabStatus != 1;
				if (flag2)
				{
					base.ShowMsg(Messages.LabStatusWrong, "", "");
				}
				else
				{
					Dictionary<string, object> dictionary = new Dictionary<string, object>();
					dictionary.Add("UnionLabStatus", labStatus);
					bool flag3 = DalT_unionlab.Instance.Update(dictionary, this.mCurrentUnionLabId);
					if (flag3)
					{
						this.AddtTicketLab(labStatus);
						this.OnOperateSuccess(new
						{
							TicketDanHao = model.UnionLabCode,
							OldLabStatus = model.UnionLabStatus,
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

		// Token: 0x060008B1 RID: 2225 RVA: 0x000D5454 File Offset: 0x000D3654
		private void AddtTicketLab(int labStatus)
		{
			ModT_ticketlab modT_ticketlab = new ModT_ticketlab();
			modT_ticketlab.BillId = this.mCurrentUnionLabId;
			modT_ticketlab.BillType = 4;
			modT_ticketlab.LabStatus = labStatus;
			modT_ticketlab.CheckMan = GlobalKey.UserName;
			modT_ticketlab.LabTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
			modT_ticketlab.LabInfo = "";
			modT_ticketlab.ModifyTime = DateTime.Now;
			modT_ticketlab.State = 1;
			DalT_ticketlab.Instance.AddNoReturn(modT_ticketlab);
		}

		// Token: 0x04000EB2 RID: 3762
		private List<ModT_unionlab> mUnionLabList = new List<ModT_unionlab>();

		// Token: 0x04000EB3 RID: 3763
		private List<ModT_ticket> _list = null;

		// Token: 0x04000EB4 RID: 3764
		private ModT_ticket selectMod = new ModT_ticket();

		// Token: 0x04000EB5 RID: 3765
		private ModCfg_setting MaxFWDifferSetting;

		// Token: 0x04000EB6 RID: 3766
		private string cardNum = string.Empty;

		// Token: 0x04000EB7 RID: 3767
		private bool isEditOpen = false;

		// Token: 0x04000EB8 RID: 3768
		protected string danhao = "";

		// Token: 0x04000EB9 RID: 3769
		private int mSelectIndex = 0;

		// Token: 0x04000EBA RID: 3770
		private int _StaticColumnCount;

		// Token: 0x04000EBB RID: 3771
		public static object lockobj = new object();

		// Token: 0x04000EBC RID: 3772
		private int mCurrentUnionLabId = 0;

		// Token: 0x04000EBD RID: 3773
		private int mCurrentUnionLabIndex = 0;

		// Token: 0x04000EBE RID: 3774
		private int mSelectRecordRowIndex = 0;
	}
}
