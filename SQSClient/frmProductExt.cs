using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Assistant;
using Base;
using DAL.Base.SQSConfig;
using DAL.SQLServer.SQSConfig;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using DevComponents.DotNetBar.Layout;
using DevComponents.Editors;
using Model;
using Model.SQSConfig;
using SQSClient.Properties;

namespace SQSClient
{
	// Token: 0x02000065 RID: 101
	public partial class frmProductExt : BaseDialogForm
	{
		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060004DF RID: 1247 RVA: 0x0007DC48 File Offset: 0x0007BE48
		public int SelectGroupID
		{
			get
			{
				return this._SelectGroupID;
			}
		}

		// Token: 0x060004E0 RID: 1248 RVA: 0x0007DC60 File Offset: 0x0007BE60
		public frmProductExt()
		{
			this.InitializeComponent();
			this.SetText(this);
			this._Controls.Clear();
			this._Controls.Add(this.barGroup);
			this._Controls.Add(this.bar);
			this._Controls.Add(this.dgvData);
			base.SetGridUI(this.dgvData);
		}

		// Token: 0x060004E1 RID: 1249 RVA: 0x0007DD28 File Offset: 0x0007BF28
		public frmProductExt(string text, string invCode, BaseForm.FormActtion act)
		{
			this.InitializeComponent();
			this.mInvCode = invCode;
			this.SetText(this);
			this._Controls.Clear();
			this._Controls.Add(this.barGroup);
			this._Controls.Add(this.bar);
			this._Controls.Add(this.dgvData);
			base.SetGridUI(this.dgvData);
			this._Act = act;
			this.CheckAttribute();
		}

		// Token: 0x060004E2 RID: 1250 RVA: 0x0007DE04 File Offset: 0x0007C004
		private void frmUnit_Load(object sender, EventArgs e)
		{
			base.InitBurron();
			this.InitControl();
			this.LoadGroupData();
			this.LoadData();
			this.cmbProductFree.SelectedIndex = 0;
			ModT_product modelByInvCode = DAL.Base.SQSConfig.DalT_product.Instance.GetModelByInvCode(this.mInvCode);
			this.cmbQueue.SelectedValue = modelByInvCode.GroupIndex;
		}

		// Token: 0x060004E3 RID: 1251 RVA: 0x0007DE64 File Offset: 0x0007C064
		private void InitControl()
		{
			this.btnAdd.Shortcuts.Add(eShortcut.CtrlIns);
			this.btnModify.Shortcuts.Add(eShortcut.CtrlEnter);
			this.btnDelete.Shortcuts.Add(eShortcut.CtrlDel);
			this._ListProFree.Clear();
			this._ListProFree.AddRange(BaseForm.GetEnumModelList<ProductFreeEnum>());
			this.cmbProductFree.BindDataSouce(this._ListProFree, "Description", "Description", "Value");
			this.dgvData.MultiSelect = true;
			this.cmbQueue.BindDataSouce(DAL.Base.SQSConfig.DalT_warehouse.Instance.GetAllListOrderIndex(""), "Name", "PinYinMa", "QueueIndex");
			this.cmbQueue.SelectedIndex = 0;
		}

		// Token: 0x060004E4 RID: 1252 RVA: 0x0007DF38 File Offset: 0x0007C138
		private void CheckAttribute()
		{
			this.btnAdd.Visible = true;
			this.btnModify.Visible = true;
			this.btnDelete.Visible = true;
			this.Text = ShowWords.ReplaceText("ProductFree");
			this.btnFreeInit.Enabled = GlobalKey.UserName.Equals("admin");
		}

		// Token: 0x060004E5 RID: 1253 RVA: 0x0007DF9C File Offset: 0x0007C19C
		protected void LoadGroupData()
		{
			this._listProFreeControl.Clear();
			this.layoutControlFree.RootGroup.Items.Clear();
			this.layoutControlFree.Controls.Clear();
			this._layItemList.Clear();
			List<ModCfg_free> list = DAL.Base.SQSConfig.DalCfg_free.Instance.GetAllList();
			list = (from o in list
			orderby o.FreeIndex
			select o).ToList<ModCfg_free>();
			foreach (ModCfg_free value in list)
			{
				this.AddCfgFreeControl(value);
			}
			this.Refresh();
		}

		// Token: 0x060004E6 RID: 1254 RVA: 0x0007E06C File Offset: 0x0007C26C
		private void AddCfgFreeControl(ModCfg_free value)
		{
			ProFreeControl proFreeControl = new ProFreeControl(value);
			proFreeControl.Margin = new System.Windows.Forms.Padding(0);
			proFreeControl.Name = "CfgFree" + (this._layItemList.Count + 1).ToString();
			proFreeControl.Size = new Size(230, 23);
			LayoutControlItem layoutControlItem = new LayoutControlItem();
			layoutControlItem.Control = proFreeControl;
			layoutControlItem.Height = 38;
			layoutControlItem.Name = (this._layItemList.Count + 1).ToString();
			layoutControlItem.Text = ShowWords.ReplaceText("LayFreeCode") + " " + (this._layItemList.Count + 1).ToString();
			layoutControlItem.TextAlignment = DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			layoutControlItem.TextLineAlignment = eTextLineAlignment.Bottom;
			layoutControlItem.Width = 290;
			layoutControlItem.WidthType = eLayoutSizeType.Percent;
			this.layoutControlFree.RootGroup.Items.Add(layoutControlItem);
			this.layoutControlFree.Controls.Add(proFreeControl);
			this._layItemList.Add(layoutControlItem);
			this._listProFreeControl.Add(proFreeControl);
		}

		// Token: 0x060004E7 RID: 1255 RVA: 0x0007E194 File Offset: 0x0007C394
		protected override void LoadData()
		{
			List<ModT_productext> listByInvCode = DAL.Base.SQSConfig.DalT_productext.Instance.GetListByInvCode(this.mInvCode);
			this.dgvData.Rows.Clear();
			foreach (ModT_productext modT_productext in listByInvCode)
			{
				int num = 0;
				object[] array = new object[this.dgvData.ColumnCount];
				array[num++] = modT_productext.Id.ToString();
				array[num++] = modT_productext.InvCode;
				array[num++] = ShowWords.ReplaceText(EnumHelper.GetDescription<ProductFreeEnum>((ProductFreeEnum)modT_productext.ProExtType));
				array[num++] = modT_productext.FreeModel;
				int proExtType = modT_productext.ProExtType;
				int num2 = proExtType;
				if (num2 != 0)
				{
					if (num2 != 1)
					{
						array[num++] = "-";
						array[num++] = "-";
						array[num++] = "-";
					}
					else
					{
						array[num++] = "-";
						array[num++] = modT_productext.Free1Value;
						array[num++] = modT_productext.Free2Value;
					}
				}
				else
				{
					array[num++] = modT_productext.Free1Value;
					array[num++] = "-";
					array[num++] = "-";
				}
				array[num++] = modT_productext.ExtState;
				array[num++] = modT_productext.ProExtInfo;
				array[num++] = modT_productext.FreeSort;
				this.dgvData.Rows.Add(array);
			}
			bool flag = this.dgvData.Rows.Count > 0;
			if (flag)
			{
				this.GetCurrentItem(0);
			}
			else
			{
				this.btnModify.Enabled = false;
				this.btnDelete.Enabled = false;
			}
		}

		// Token: 0x060004E8 RID: 1256 RVA: 0x0007E3A4 File Offset: 0x0007C5A4
		private void buttonItem_Click(object sender, EventArgs e)
		{
			bool flag = this._SelectItem != null;
			if (flag)
			{
				this._SelectItem.ColorTable = eButtonColor.Orange;
			}
			this._SelectItem = (ButtonItem)sender;
			this._SelectItem.ColorTable = eButtonColor.OrangeWithBackground;
			this._SelectGroupID = int.Parse(this._SelectItem.Name);
			this.LoadData();
		}

		// Token: 0x060004E9 RID: 1257 RVA: 0x0007E404 File Offset: 0x0007C604
		private void btnAdd_Click(object sender, EventArgs e)
		{
			this.AddProductExt();
		}

		// Token: 0x060004EA RID: 1258 RVA: 0x0007E410 File Offset: 0x0007C610
		private void AddProductExt()
		{
			ModT_productext modT_productext = new ModT_productext();
			this.GetProductExt(modT_productext);
			modT_productext.CreateTime = (modT_productext.ModifyTime = DateTime.Now);
			modT_productext.Creater = (modT_productext.Modifier = GlobalKey.UserName);
			modT_productext.ExtState = 1;
			modT_productext.FreeIndexs = "";
			modT_productext.FreeSort = this._DalProExt.GetMaxFreeSort(this.mInvCode, this._ProExtType) + 1;
			bool flag = this._DalProExt.CheckFreeModelIsExist(modT_productext, 0);
			if (flag)
			{
				base.ShowMsg(ShowWords.ReplaceText("AddFreeModelExist"), "", "");
			}
			else
			{
				bool flag2 = this._DalProExt.AddNoReturn(modT_productext);
				if (flag2)
				{
					this.LoadData();
				}
			}
		}

		// Token: 0x060004EB RID: 1259 RVA: 0x0007E4D8 File Offset: 0x0007C6D8
		private void GetProductExt(ModT_productext modProExt)
		{
			modProExt.InvCode = this.mInvCode;
			modProExt.ProExtType = this._ProExtType;
			modProExt.ProExtInfo = this.txtProExtInfo.Text.Trim();
			string empty = string.Empty;
			string empty2 = string.Empty;
			this.GetFreeModel(ref empty, ref empty2);
			modProExt.FreeModel = empty;
			modProExt.FreeIndexs = empty2;
			modProExt.Free1Value = (decimal)this.dInputFree1Value.Value;
			modProExt.Free2Value = (decimal)this.dInputFree2Value.Value;
			modProExt.Free3Value = 0m;
		}

		// Token: 0x060004EC RID: 1260 RVA: 0x0007E578 File Offset: 0x0007C778
		private void btnModify_Click(object sender, EventArgs e)
		{
			this._ExtAct = BaseForm.FormActtion.Modify;
			ModT_productext model = this._DalProExt.GetModel(this._CurrentId);
			this.GetProductExt(model);
			model.ModifyTime = DateTime.Now;
			model.Modifier = GlobalKey.UserName;
			bool flag = this._DalProExt.CheckFreeModelIsExist(model, this._CurrentId);
			if (flag)
			{
				base.ShowMsg("ModifyFreeModelExist", "", "");
			}
			else
			{
				bool flag2 = this._DalProExt.Update(model);
				if (flag2)
				{
					this.LoadData();
				}
			}
		}

		// Token: 0x060004ED RID: 1261 RVA: 0x0007E608 File Offset: 0x0007C808
		private void btnDelete_Click(object sender, EventArgs e)
		{
			bool flag = !base.ShowChoise(Messages.DeleteSure, "", "");
			if (!flag)
			{
				this.ObtainSelectIds();
				bool flag2 = !DAL.Base.SQSConfig.DalT_productext.Instance.DeleteByIds(this.mSelectIds);
				if (flag2)
				{
					this.OnOperateFail(this.mSelectIds, 0);
					base.ShowMsg(Messages.DeleteFalse, "", "");
				}
				else
				{
					this.OnOperateSuccess(this.mSelectIds, true);
					this.LoadData();
				}
			}
		}

		// Token: 0x060004EE RID: 1262 RVA: 0x0007E69C File Offset: 0x0007C89C
		private void btnExport_Click(object sender, EventArgs e)
		{
			base.DataGridViewToExcel(this.dgvData);
		}

		// Token: 0x060004EF RID: 1263 RVA: 0x0007E6AC File Offset: 0x0007C8AC
		private void dgvUnit_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			bool flag = e.RowIndex >= 0;
			if (flag)
			{
				this.GetCurrentItem(e.RowIndex);
			}
		}

		// Token: 0x060004F0 RID: 1264 RVA: 0x0007E6DC File Offset: 0x0007C8DC
		private void dgvUnit_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			bool flag = e.RowIndex >= 0;
			if (flag)
			{
			}
		}

		// Token: 0x060004F1 RID: 1265 RVA: 0x0007E6FC File Offset: 0x0007C8FC
		private void GetCurrentItem(int rowindex)
		{
			this._CurrentId = int.Parse(this.dgvData.Rows[rowindex].Cells[0].Value.ToString());
			this.ModifyLoad();
			this.btnModify.Enabled = true;
			this.btnDelete.Enabled = true;
		}

		// Token: 0x060004F2 RID: 1266 RVA: 0x0007E75C File Offset: 0x0007C95C
		private void ModifyLoad()
		{
			ModT_productext model = DAL.Base.SQSConfig.DalT_productext.Instance.GetModel(this._CurrentId);
			this.LoadProductExt(model);
		}

		// Token: 0x060004F3 RID: 1267 RVA: 0x0007E784 File Offset: 0x0007C984
		private void LoadProductExt(ModT_productext modProExt)
		{
			this.cmbProductFree.SelectedValue = modProExt.ProExtType;
			this.txtProExtInfo.Text = modProExt.ProExtInfo;
			this.dInputFree1Value.Value = (double)modProExt.Free1Value;
			this.dInputFree2Value.Value = (double)modProExt.Free2Value;
			this.UpdateProFreeControlValue(modProExt.FreeModel);
		}

		// Token: 0x060004F4 RID: 1268 RVA: 0x0007E7F8 File Offset: 0x0007C9F8
		private void btnModifyInvFree_Click(object sender, EventArgs e)
		{
			this._ProExtType = Convert.ToInt32(this.cmbProductFree.SelectedValue);
			frmProductFree frmProductFree = new frmProductFree(this.Text, BaseForm.FormActtion.Modify, this.mInvCode, "", this._ProExtType);
			bool flag = frmProductFree.ShowDialog() == DialogResult.Yes;
			if (flag)
			{
				this.CheckProFreeControl();
			}
		}

		// Token: 0x060004F5 RID: 1269 RVA: 0x0007E850 File Offset: 0x0007CA50
		private void CheckProFreeControl()
		{
			ModT_product modelByInvCode = DAL.Base.SQSConfig.DalT_product.Instance.GetModelByInvCode(this.mInvCode);
			this._ProExtType = Convert.ToInt32(this.cmbProductFree.SelectedValue);
			string productFree = string.Empty;
			int proExtType = this._ProExtType;
			int num = proExtType;
			if (num != 0)
			{
				if (num == 1)
				{
					this.lclFree1Value.Text = ShowWords.ReplaceText("AccuUpperLimit");
					this.lclFree2Value.Text = ShowWords.ReplaceText("AccuLowerLimit");
					this.lclFree2Value.Visible = true;
					productFree = modelByInvCode.AccuRangeFree;
				}
			}
			else
			{
				this.lclFree1Value.Text = ShowWords.ReplaceText("PackageWeight");
				this.lclFree2Value.Visible = false;
				productFree = modelByInvCode.PackWeightFree;
			}
			foreach (ProFreeControl proFreeControl in this._listProFreeControl)
			{
				proFreeControl.CheckFreeSelected(productFree);
			}
		}

		// Token: 0x060004F6 RID: 1270 RVA: 0x0007E960 File Offset: 0x0007CB60
		private void UpdateProFreeControlValue(string freeModel)
		{
			string[] array = freeModel.Split(new char[]
			{
				','
			});
			int num = 0;
			foreach (ProFreeControl proFreeControl in this._listProFreeControl)
			{
				bool getChecked = proFreeControl.GetChecked;
				if (getChecked)
				{
					bool flag = num >= array.Length;
					if (flag)
					{
						break;
					}
					proFreeControl.FreeInfo = array[num++];
				}
			}
		}

		// Token: 0x060004F7 RID: 1271 RVA: 0x0007E9F4 File Offset: 0x0007CBF4
		private void GetFreeModel(ref string freeModel, ref string freeIndexs)
		{
			foreach (ProFreeControl proFreeControl in this._listProFreeControl)
			{
				bool getChecked = proFreeControl.GetChecked;
				if (getChecked)
				{
					freeModel = freeModel + proFreeControl.FreeInfo + ",";
					freeIndexs = freeIndexs + proFreeControl.ModCfgfree.FreeIndex.ToString() + ",";
				}
			}
			freeModel = freeModel.Trim(new char[]
			{
				','
			});
			freeIndexs = freeIndexs.Trim(new char[]
			{
				','
			});
		}

		// Token: 0x060004F8 RID: 1272 RVA: 0x0007EAB0 File Offset: 0x0007CCB0
		private void cmbProductFree_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.CheckProFreeControl();
		}

		// Token: 0x060004F9 RID: 1273 RVA: 0x0007EABC File Offset: 0x0007CCBC
		private void btnBatchSetting_Click(object sender, EventArgs e)
		{
			bool flag = this.dgvData.SelectedRows.Count == 0;
			if (!flag)
			{
				this.ObtainSelectIds();
				List<ModT_productext> listByIds = this._DalProExt.GetListByIds(this.mSelectIds);
				frmProduct frmProduct = new frmProduct(ShowWords.ReplaceText("BatchSetting"), BaseForm.FormActtion.BatchSet);
				string ids = string.Empty;
				bool flag2 = frmProduct.ShowDialog() == DialogResult.Yes;
				if (flag2)
				{
					ids = frmProduct.GetSelectIds;
					List<ModT_product> list = DAL.Base.SQSConfig.DalT_product.Instance.GetListByIds(ids);
					list = (from o in list
					where !o.InvCode.Equals(this.mInvCode)
					select o).ToList<ModT_product>();
					this.ProductBatchSetting(listByIds, list);
				}
			}
		}

		// Token: 0x060004FA RID: 1274 RVA: 0x0007EB60 File Offset: 0x0007CD60
		protected void ObtainSelectIds()
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
		}

		// Token: 0x060004FB RID: 1275 RVA: 0x0007EC08 File Offset: 0x0007CE08
		protected void ProductBatchSetting(List<ModT_productext> listProExt, List<ModT_product> listProduct)
		{
			ModT_product modelByInvCode = DAL.Base.SQSConfig.DalT_product.Instance.GetModelByInvCode(this.mInvCode);
			List<ModT_productext> listFindProExt = new List<ModT_productext>();
			List<ModT_productext> list = new List<ModT_productext>();
			foreach (ModT_product modT_product in listProduct)
			{
				List<ModT_productext> listByInvCode = DAL.Base.SQSConfig.DalT_productext.Instance.GetListByInvCode(modT_product.InvCode);
				foreach (BaseForm.EnumModel enumModel in this._ListProFree)
				{
					int proExtType = (int)enumModel.Value;
					string freeField = string.Empty;
					string text = string.Empty;
					string text2 = string.Empty;
					int proExtType2 = proExtType;
					int num = proExtType2;
					if (num != 0)
					{
						if (num != 1)
						{
							freeField = "PackWeightFree";
							text = modelByInvCode.PackWeightFree;
							text2 = modT_product.PackWeightFree;
						}
						else
						{
							freeField = "AccuRangeFree";
							text = modelByInvCode.AccuRangeFree;
							text2 = modT_product.AccuRangeFree;
						}
					}
					else
					{
						freeField = "PackWeightFree";
						text = modelByInvCode.PackWeightFree;
						text2 = modT_product.PackWeightFree;
					}
					listFindProExt = (from o in listProExt
					where o.ProExtType == proExtType
					select o).ToList<ModT_productext>();
					list = (from o in listByInvCode
					where o.ProExtType == proExtType
					select o).ToList<ModT_productext>();
					bool flag = text.Length == 0;
					if (flag)
					{
						bool flag2 = list.Count > 0;
						if (flag2)
						{
							continue;
						}
						bool flag3 = text2.Length > 0;
						if (flag3)
						{
							continue;
						}
					}
					else
					{
						bool flag4 = !text.Equals(text2);
						if (flag4)
						{
							bool flag5 = list.Count > 0;
							if (flag5)
							{
								continue;
							}
							text2 = text;
							DAL.Base.SQSConfig.DalT_product.Instance.UpdateCfgFree(freeField, text2, modT_product.InvCode);
						}
					}
					this.CheckProExtTarget(modT_product, listFindProExt, list);
				}
			}
		}

		// Token: 0x060004FC RID: 1276 RVA: 0x0007EE3C File Offset: 0x0007D03C
		protected void CheckProExtTarget(ModT_product proTarget, List<ModT_productext> listFindProExt, List<ModT_productext> listFindProExtTarget)
		{
			List<ModT_productext> list = new List<ModT_productext>();
			using (List<ModT_productext>.Enumerator enumerator = listFindProExt.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					ModT_productext modProExt = enumerator.Current;
					bool flag = (from o in listFindProExtTarget
					where o.ProExtType == modProExt.ProExtType && o.FreeModel.Equals(modProExt.FreeModel)
					select o).ToList<ModT_productext>().Count == 0;
					if (flag)
					{
						list.Add(modProExt);
					}
				}
			}
			int num;
			if (listFindProExtTarget.Count != 0)
			{
				num = listFindProExtTarget.Max((ModT_productext o) => o.FreeSort);
			}
			else
			{
				num = 0;
			}
			int num2 = num + 1;
			foreach (ModT_productext modT_productext in list)
			{
				modT_productext.InvCode = proTarget.InvCode;
				modT_productext.CreateTime = (modT_productext.ModifyTime = DateTime.Now);
				modT_productext.Creater = (modT_productext.Modifier = GlobalKey.UserName);
				modT_productext.FreeSort = num2++;
				DAL.Base.SQSConfig.DalT_productext.Instance.AddNoReturn(modT_productext);
			}
		}

		// Token: 0x060004FD RID: 1277 RVA: 0x0007EF98 File Offset: 0x0007D198
		private void btnFreeInit_Click(object sender, EventArgs e)
		{
			bool flag = !base.ShowChoise("DangerShow", "", "");
			if (!flag)
			{
				List<ModCfg_free> allList = DAL.Base.SQSConfig.DalCfg_free.Instance.GetAllList();
				List<ModCfg_freeinfo> allList2 = DAL.Base.SQSConfig.DalCfg_freeinfo.Instance.GetAllList();
				this.CheckFreeInfo(allList, allList2);
				bool flag2 = !this.InitProduct();
				if (!flag2)
				{
					this.RunFreeInit();
					this.RunAccuRangeInit();
					this.ReferenceProduct();
					base.ShowMsg(ShowWords.ReplaceText("ExecutionFinish"), "", "");
				}
			}
		}

		// Token: 0x060004FE RID: 1278 RVA: 0x0007F024 File Offset: 0x0007D224
		private void CheckFreeInfo(List<ModCfg_free> listFree, List<ModCfg_freeinfo> listFreeInfo)
		{
			using (List<ModCfg_free>.Enumerator enumerator = listFree.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					ModCfg_free modFree = enumerator.Current;
					List<string> groupFieldList = DAL.Base.SQSConfig.DalCfg_freeinit.Instance.GetGroupFieldList(modFree.KeyField);
					using (List<string>.Enumerator enumerator2 = groupFieldList.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							string infoName = enumerator2.Current;
							bool flag = (from o in listFreeInfo
							where o.FreeIndex == modFree.FreeIndex && o.InfoName.Equals(infoName)
							select o).ToList<ModCfg_freeinfo>().Count == 0;
							if (flag)
							{
								this.AddFreeInfo(modFree.FreeIndex, infoName, GlobalKey.UserName);
							}
						}
					}
				}
			}
		}

		// Token: 0x060004FF RID: 1279 RVA: 0x0007F134 File Offset: 0x0007D334
		private void UpdateInvAllName()
		{
			List<ModCfg_freeinit> invNameListByGroup = DAL.Base.SQSConfig.DalCfg_freeinit.Instance.GetInvNameListByGroup();
			foreach (ModCfg_freeinit modCfg_freeinit in invNameListByGroup)
			{
				Dictionary<string, object> dictionary = new Dictionary<string, object>();
				List<string> list = new List<string>();
				dictionary.Add("InvName", modCfg_freeinit.InvName);
				list.Add("[InvCode]='" + modCfg_freeinit.InvCode + "'");
				DAL.Base.SQSConfig.DalT_product.Instance.Update(dictionary, list);
			}
		}

		// Token: 0x06000500 RID: 1280 RVA: 0x0007F1D8 File Offset: 0x0007D3D8
		private bool InitProduct()
		{
			List<ModCfg_freeinit> listByGroup = DAL.Base.SQSConfig.DalCfg_freeinit.Instance.GetListByGroup();
			using (List<ModCfg_freeinit>.Enumerator enumerator = listByGroup.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					ModCfg_freeinit freePro = enumerator.Current;
					bool flag = (from o in listByGroup
					where o.InvCode.Equals(freePro.InvCode)
					select o).ToList<ModCfg_freeinit>().Count > 1;
					if (flag)
					{
						base.ShowMsg(freePro.InvCode + " Error!", "", "");
						return false;
					}
				}
			}
			foreach (ModCfg_freeinit modCfg_freeinit in listByGroup)
			{
				DAL.Base.SQSConfig.DalT_productext.Instance.DeleteByInvCode(modCfg_freeinit.InvCode);
				DAL.Base.SQSConfig.DalT_product.Instance.UpdateCfgFree("PackWeightFree", modCfg_freeinit.FreeField, modCfg_freeinit.InvCode);
			}
			return true;
		}

		// Token: 0x06000501 RID: 1281 RVA: 0x0007F300 File Offset: 0x0007D500
		private bool ReferenceProduct()
		{
			List<ModCfg_freeinit> allList = DAL.Base.SQSConfig.DalCfg_freeinit.Instance.GetAllList();
			foreach (ModCfg_freeinit modCfg_freeinit in allList)
			{
				ModT_product modelByInvCode = DAL.Base.SQSConfig.DalT_product.Instance.GetModelByInvCode(modCfg_freeinit.InvCode);
				bool flag = modelByInvCode == null;
				if (!flag)
				{
					try
					{
						string[] array = modCfg_freeinit.Remark.Split(new char[]
						{
							','
						});
						modelByInvCode.Enable = true;
						modelByInvCode.State = 1;
						modelByInvCode.EffectTime = DateTime.Now;
						modelByInvCode.ValidCondition = this.GetValidCondition(array[0]);
						modelByInvCode.PostType = this.GetPostType(array[1]);
						modelByInvCode.InvModelId = Convert.ToInt32(array[2]);
						modelByInvCode.GroupIndex = 0;
						modelByInvCode.PackType = ((modCfg_freeinit.PackWeight > 0m) ? 1 : 0);
						ModT_product modelByInvCode2 = DAL.Base.SQSConfig.DalT_product.Instance.GetModelByInvCode(modCfg_freeinit.InvName);
						bool flag2 = modelByInvCode2 != null;
						if (flag2)
						{
							modelByInvCode.GroupIndex = modelByInvCode2.GroupIndex;
							modelByInvCode.BusinessType = modelByInvCode2.BusinessType;
							modelByInvCode.LabCheckCondition = modelByInvCode2.LabCheckCondition;
						}
						DAL.Base.SQSConfig.DalT_product.Instance.Update(modelByInvCode);
					}
					catch
					{
					}
				}
			}
			return true;
		}

		// Token: 0x06000502 RID: 1282 RVA: 0x0007F494 File Offset: 0x0007D694
		private int GetValidCondition(string productValidDesc)
		{
			int result = 0;
			List<BaseForm.EnumModel> enumModelList = BaseForm.GetEnumModelList<ProductValid>();
			foreach (BaseForm.EnumModel enumModel in enumModelList)
			{
				int num = (int)enumModel.Value;
				bool flag = ShowWords.ReplaceText(EnumHelper.GetDescription<ProductValid>((ProductValid)num)).Equals(productValidDesc);
				if (flag)
				{
					result = num;
					break;
				}
			}
			return result;
		}

		// Token: 0x06000503 RID: 1283 RVA: 0x0007F51C File Offset: 0x0007D71C
		private int GetPostType(string postTypeDesc)
		{
			int result = 0;
			List<BaseForm.EnumModel> enumModelList = BaseForm.GetEnumModelList<AccountType>();
			foreach (BaseForm.EnumModel enumModel in enumModelList)
			{
				int num = (int)enumModel.Value;
				bool flag = ShowWords.ReplaceText(EnumHelper.GetDescription<AccountType>((AccountType)num)).Equals(postTypeDesc);
				if (flag)
				{
					result = num;
					break;
				}
			}
			return result;
		}

		// Token: 0x06000504 RID: 1284 RVA: 0x0007F5A4 File Offset: 0x0007D7A4
		private void RunFreeInit()
		{
			int proExtType = 0;
			DataTable freeInitTbl = DAL.Base.SQSConfig.DalCfg_freeinit.Instance.GetFreeInitTbl(1);
			List<string> listColor = this.GetListColor();
			string text = "彩包";
			int id = 0;
			string invCode = string.Empty;
			string text2 = string.Empty;
			decimal packWeight = 0m;
			foreach (object obj in freeInitTbl.Rows)
			{
				DataRow dataRow = (DataRow)obj;
				string text3 = string.Empty;
				id = Convert.ToInt32(dataRow["Id"].ToString().Trim());
				invCode = dataRow["InvCode"].ToString().Trim();
				text2 = dataRow["FreeField"].ToString().Trim();
				packWeight = Convert.ToDecimal(dataRow["PackWeight"].ToString());
				bool flag = text2.Length > 0;
				if (flag)
				{
					string[] array = text2.Split(new char[]
					{
						','
					});
					for (int i = 0; i < array.Length; i++)
					{
						text3 = text3 + dataRow[array[i]].ToString() + ",";
					}
					text3 = text3.Trim(new char[]
					{
						','
					});
				}
				this.InitProductExt(proExtType, invCode, text3, packWeight, GlobalKey.UserName);
				bool flag2 = text3.IndexOf(text) > 0;
				if (flag2)
				{
					foreach (string newValue in listColor)
					{
						this.InitProductExt(proExtType, invCode, text3.Replace(text, newValue), packWeight, GlobalKey.UserName);
					}
				}
				DAL.Base.SQSConfig.DalCfg_freeinit.Instance.UpdateIsSuccessById(2, id);
			}
		}

		// Token: 0x06000505 RID: 1285 RVA: 0x0007F7C0 File Offset: 0x0007D9C0
		private void RunAccuRangeInit()
		{
			int proExtType = 1;
			string text = string.Empty;
			List<ModCfg_freeinit> accuRangeListByGroup = DAL.Base.SQSConfig.DalCfg_freeinit.Instance.GetAccuRangeListByGroup(2);
			foreach (ModCfg_freeinit modCfg_freeinit in accuRangeListByGroup)
			{
				text = modCfg_freeinit.ProductSpace.Trim();
				bool flag = text.Length > 0;
				if (flag)
				{
					DAL.Base.SQSConfig.DalT_product.Instance.UpdateCfgFree("AccuRangeFree", "ProductSpace", modCfg_freeinit.InvCode);
				}
				else
				{
					DAL.Base.SQSConfig.DalT_product.Instance.UpdateCfgFree("AccuRangeFree", "", modCfg_freeinit.InvCode);
				}
				this.InitProductExtAccuRange(proExtType, modCfg_freeinit.InvCode, text, modCfg_freeinit.UpperLimit, modCfg_freeinit.LowLimit, GlobalKey.UserName);
			}
		}

		// Token: 0x06000506 RID: 1286 RVA: 0x0007F8A4 File Offset: 0x0007DAA4
		private List<string> GetListColor()
		{
			return new List<string>
			{
				"黄彩包",
				"白彩包",
				"红彩包"
			};
		}

		// Token: 0x06000507 RID: 1287 RVA: 0x0007F8E4 File Offset: 0x0007DAE4
		public bool AddFreeInfo(int freeIndex, string infoName, string userName)
		{
			ModCfg_freeinfo modCfg_freeinfo = new ModCfg_freeinfo();
			modCfg_freeinfo.FreeIndex = freeIndex;
			modCfg_freeinfo.InfoName = infoName;
			modCfg_freeinfo.SortNum = DAL.Base.SQSConfig.DalCfg_freeinfo.Instance.GetSortNum(freeIndex) + 1;
			modCfg_freeinfo.KeyCode = "";
			modCfg_freeinfo.CreateTime = (modCfg_freeinfo.ModifyTime = DateTime.Now);
			ModCfg_freeinfo modCfg_freeinfo2 = modCfg_freeinfo;
			modCfg_freeinfo.Modifier = userName;
			modCfg_freeinfo2.Creater = userName;
			modCfg_freeinfo.PinYinMa = modCfg_freeinfo.InfoName.GetFirstPinyin();
			modCfg_freeinfo.InfoState = 1;
			return DAL.Base.SQSConfig.DalCfg_freeinfo.Instance.AddNoReturn(modCfg_freeinfo);
		}

		// Token: 0x06000508 RID: 1288 RVA: 0x0007F97C File Offset: 0x0007DB7C
		public bool InitProductExt(int proExtType, string invCode, string freeModel, decimal packWeight, string userName)
		{
			bool flag = false;
			ModT_productext modT_productext = new ModT_productext();
			modT_productext.InvCode = invCode;
			modT_productext.ProExtType = proExtType;
			modT_productext.ProExtInfo = "";
			modT_productext.FreeModel = freeModel;
			modT_productext.Free1Value = packWeight;
			ModT_productext modT_productext2 = modT_productext;
			ModT_productext modT_productext3 = modT_productext;
			decimal num = 0m;
			modT_productext3.Free3Value = num;
			modT_productext2.Free2Value = num;
			modT_productext.CreateTime = (modT_productext.ModifyTime = DateTime.Now);
			ModT_productext modT_productext4 = modT_productext;
			modT_productext.Modifier = userName;
			modT_productext4.Creater = userName;
			modT_productext.ExtState = 1;
			modT_productext.FreeIndexs = "";
			modT_productext.FreeSort = DAL.Base.SQSConfig.DalT_productext.Instance.GetMaxFreeSort(invCode, modT_productext.ProExtType) + 1;
			bool flag2 = DAL.Base.SQSConfig.DalT_productext.Instance.CheckIsExist(invCode, proExtType, freeModel, ref flag);
			if (flag2)
			{
				bool flag3 = !flag;
				if (flag3)
				{
					return DAL.Base.SQSConfig.DalT_productext.Instance.AddNoReturn(modT_productext);
				}
			}
			return true;
		}

		// Token: 0x06000509 RID: 1289 RVA: 0x0007FA68 File Offset: 0x0007DC68
		public bool InitProductExtAccuRange(int proExtType, string invCode, string freeModel, decimal upperLimit, decimal lowLimit, string userName)
		{
			bool flag = false;
			ModT_productext modT_productext = new ModT_productext();
			modT_productext.InvCode = invCode;
			modT_productext.ProExtType = proExtType;
			modT_productext.ProExtInfo = "";
			modT_productext.FreeModel = freeModel;
			modT_productext.Free1Value = upperLimit;
			modT_productext.Free2Value = lowLimit;
			modT_productext.Free3Value = 0m;
			modT_productext.CreateTime = (modT_productext.ModifyTime = DateTime.Now);
			ModT_productext modT_productext2 = modT_productext;
			modT_productext.Modifier = userName;
			modT_productext2.Creater = userName;
			modT_productext.ExtState = 1;
			modT_productext.FreeIndexs = "";
			modT_productext.FreeSort = DAL.Base.SQSConfig.DalT_productext.Instance.GetMaxFreeSort(invCode, modT_productext.ProExtType) + 1;
			bool flag2 = DAL.Base.SQSConfig.DalT_productext.Instance.CheckIsExist(invCode, proExtType, freeModel, ref flag);
			if (flag2)
			{
				bool flag3 = !flag;
				if (flag3)
				{
					return DAL.Base.SQSConfig.DalT_productext.Instance.AddNoReturn(modT_productext);
				}
			}
			return true;
		}

		// Token: 0x0600050A RID: 1290 RVA: 0x0007FB50 File Offset: 0x0007DD50
		private void dgvData_SelectionChanged(object sender, EventArgs e)
		{
			bool flag = this.dgvData.SelectedRows.Count > 0;
			if (flag)
			{
				this.GetCurrentItem(this.dgvData.SelectedRows[0].Index);
			}
		}

		// Token: 0x0600050B RID: 1291 RVA: 0x00003040 File Offset: 0x00001240
		private void lblEditStatus_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600050C RID: 1292 RVA: 0x0007FB94 File Offset: 0x0007DD94
		private void btnQueueSure_Click(object sender, EventArgs e)
		{
			int num = Convert.ToInt32(this.cmbQueue.SelectedValue);
			Dictionary<string, object> dictionary = new Dictionary<string, object>();
			List<string> list = new List<string>();
			dictionary.Add("GroupIndex", num);
			list.Add("[InvCode]='" + this.mInvCode + "'");
			DAL.Base.SQSConfig.DalT_product.Instance.Update(dictionary, list);
			base.ShowMsg(Messages.UpdateTrue, "", "");
		}

		// Token: 0x04000893 RID: 2195
		private int _SelectGroupID = 0;

		// Token: 0x04000894 RID: 2196
		private ButtonItem _SelectItem = null;

		// Token: 0x04000895 RID: 2197
		protected List<LayoutItemBase> _layItemList = new List<LayoutItemBase>();

		// Token: 0x04000896 RID: 2198
		protected List<ProFreeControl> _listProFreeControl = new List<ProFreeControl>();

		// Token: 0x04000897 RID: 2199
		protected List<BaseForm.EnumModel> _ListProFree = new List<BaseForm.EnumModel>();

		// Token: 0x04000898 RID: 2200
		protected BaseForm.FormActtion _ExtAct;

		// Token: 0x04000899 RID: 2201
		protected string mInvCode = string.Empty;

		// Token: 0x0400089A RID: 2202
		private int _ProExtType = 0;

		// Token: 0x0400089B RID: 2203
		private DAL.SQLServer.SQSConfig.DalT_productext _DalProExt = DAL.Base.SQSConfig.DalT_productext.Instance;
	}
}
