using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Base;
using DAL.Base.SQSConfig;
using DAL.SQLServer.SQSConfig;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using Model;
using Model.SQSConfig;
using SQSClient.Properties;

namespace SQSClient
{
	// Token: 0x02000066 RID: 102
	public partial class frmProductExtShow : BaseDialogForm
	{
		// Token: 0x06000510 RID: 1296 RVA: 0x00081B64 File Offset: 0x0007FD64
		public frmProductExtShow()
		{
			this.InitializeComponent();
			this.InitControls();
			this.dgvData.MultiSelect = true;
		}

		// Token: 0x06000511 RID: 1297 RVA: 0x00081C04 File Offset: 0x0007FE04
		public frmProductExtShow(string text, BaseForm.FormActtion act)
		{
			this.InitializeComponent();
			base.Width = Screen.PrimaryScreen.Bounds.Width;
			this.InitControls();
			this._Act = act;
			this.dgvData.MultiSelect = true;
		}

		// Token: 0x06000512 RID: 1298 RVA: 0x00081CC4 File Offset: 0x0007FEC4
		private void InitControls()
		{
			this.SetText(this);
			this._Controls.Clear();
			this._Controls.Add(this.bar);
			this._Controls.Add(this.dgvData);
			base.SetGridUI(this.dgvData);
		}

		// Token: 0x06000513 RID: 1299 RVA: 0x00081D18 File Offset: 0x0007FF18
		private void InitListData()
		{
			List<string> list = new List<string>();
			list.Add("InvCode like '" + this._InvSaleKeyCode + "%'");
			this.mListProductExt = DAL.Base.SQSConfig.DalT_productext.Instance.GetListRequire(list, null, null);
			this.mListInvModel = DAL.Base.SQSConfig.DalSrm_invmodel.Instance.GetAllList();
			this.mListWareHouse = DAL.Base.SQSConfig.DalT_warehouse.Instance.GetAllList();
			list.Clear();
			list.Add("InvCode like '" + this._InvSaleKeyCode + "%'");
			list.Add("State = 1");
			this.mListProduct = DAL.Base.SQSConfig.DalT_product.Instance.GetListRequire(list, null, null);
		}

		// Token: 0x06000514 RID: 1300 RVA: 0x00081DC0 File Offset: 0x0007FFC0
		private void frmProductExtShow_Load(object sender, EventArgs e)
		{
			BaseDialogForm._operateArgs.Category = this.Text;
			base.InitBurron();
			this._StaticColumnCount = this.dgvData.Columns.Count;
			base.CreateDgv(this.dgvData, "c_t_product_" + base.Name);
			this.InitListData();
			this.LoadData("");
		}

		// Token: 0x06000515 RID: 1301 RVA: 0x00081E2C File Offset: 0x0008002C
		private bool CheckMaxCount(string schInfo)
		{
			bool flag = this._Dal.GetCountByProState(schInfo, this._ProductState) > this.mCheckMaxCount;
			bool result;
			if (flag)
			{
				string queryMaxSure = Messages.QueryMaxSure;
				base.ShowMsg(string.Format(ShowWords.ReplaceText(queryMaxSure), this.mCheckMaxCount), "", "");
				result = false;
			}
			else
			{
				result = true;
			}
			return result;
		}

		// Token: 0x06000516 RID: 1302 RVA: 0x00003040 File Offset: 0x00001240
		private void InitControl()
		{
		}

		// Token: 0x06000517 RID: 1303 RVA: 0x00081E90 File Offset: 0x00080090
		protected override void LoadData(string proInfo)
		{
			this.dgvData.Rows.Clear();
			List<ModT_product> list = (from O in this.mListProduct
			orderby O.InvCode
			select O).ToList<ModT_product>();
			bool flag = proInfo.Trim().Length > 0;
			if (flag)
			{
				list = (from o in this.mListProduct
				where o.InvCode.IndexOf(proInfo) >= 0 || o.InvName.IndexOf(proInfo) >= 0
				select o).ToList<ModT_product>();
			}
			this.BindData(list);
		}

		// Token: 0x06000518 RID: 1304 RVA: 0x00081F2C File Offset: 0x0008012C
		private void BindData(List<ModT_product> list)
		{
			string empty = string.Empty;
			string empty2 = string.Empty;
			string empty3 = string.Empty;
			int num = 0;
			foreach (ModT_product modT_product in list)
			{
				int num2 = 0;
				object[] array = new object[this.dgvData.ColumnCount];
				array[num2++] = modT_product.Id.ToString();
				array[num2++] = modT_product.InvCode;
				array[num2++] = modT_product.InvName;
				array[num2++] = modT_product.Name;
				array[num2++] = modT_product.Code;
				array[num2++] = modT_product.InvCCode;
				array[num2++] = modT_product.SpecsDescribe;
				array[num2++] = modT_product.SunHao;
				array[num2++] = modT_product.Midu;
				array[num2++] = ShowWords.ReplaceText(((ProductType)modT_product.Type).ToString());
				array[num2++] = ShowWords.ReplaceText(((ProductValid)modT_product.ValidCondition).ToString());
				array[num2++] = ShowWords.ReplaceText(((AccountType)modT_product.PostType).ToString());
				this.GetLimitInfo(modT_product.InvCode, ref empty, ref empty2, ref empty3);
				array[num2++] = empty;
				array[num2++] = empty2;
				array[num2++] = empty3;
				array[num2++] = ShowWords.ReplaceText(((EffectState)modT_product.State).ToString());
				array[num2++] = this.ReplaceCombin(modT_product.Combin);
				array[num2++] = Resources.edit16;
				array[num2++] = modT_product.InvModelId;
				array[num2++] = this.GetInvModelName(modT_product.InvModelId);
				array[num2++] = this.GetQueueName(modT_product.GroupIndex);
				array[num2++] = modT_product.Remark;
				this.dgvData.Rows.Add(array);
				num++;
			}
			bool flag = this.dgvData.Rows.Count > 0;
			if (flag)
			{
				this.GetCurrentItem(0);
			}
		}

		// Token: 0x06000519 RID: 1305 RVA: 0x000821E8 File Offset: 0x000803E8
		private void GetLimitInfo(string invCode, ref string packWeight, ref string upperLimit, ref string lowLimit)
		{
			string text;
			lowLimit = (text = string.Empty);
			upperLimit = (text = text);
			packWeight = text;
			List<ModT_productext> list = (from o in this.mListProductExt
			where o.InvCode.Equals(invCode) && o.ProExtType == 0
			select o).ToList<ModT_productext>();
			foreach (ModT_productext modT_productext in list)
			{
				packWeight = packWeight + modT_productext.Free1Value.ToString("F3") + ",";
			}
			List<ModT_productext> list2 = (from o in this.mListProductExt
			where o.InvCode.Equals(invCode) && o.ProExtType == 1
			select o).ToList<ModT_productext>();
			foreach (ModT_productext modT_productext2 in list2)
			{
				upperLimit = upperLimit + modT_productext2.Free1Value.ToString("F3") + ",";
				lowLimit = lowLimit + modT_productext2.Free2Value.ToString("F3") + ",";
			}
			packWeight = packWeight.Trim(new char[]
			{
				','
			});
			upperLimit = upperLimit.Trim(new char[]
			{
				','
			});
			lowLimit = lowLimit.Trim(new char[]
			{
				','
			});
		}

		// Token: 0x0600051A RID: 1306 RVA: 0x00082374 File Offset: 0x00080574
		private string GetQueueName(int queueIndex)
		{
			string result = string.Empty;
			ModT_warehouse modT_warehouse = this.mListWareHouse.Find((ModT_warehouse o) => o.QueueIndex == queueIndex);
			bool flag = modT_warehouse != null;
			if (flag)
			{
				result = modT_warehouse.Name;
			}
			return result;
		}

		// Token: 0x0600051B RID: 1307 RVA: 0x000823C8 File Offset: 0x000805C8
		private string GetInvModelName(int invModelId)
		{
			string result = string.Empty;
			ModSrm_invmodel modSrm_invmodel = this.mListInvModel.Find((ModSrm_invmodel o) => o.Id == invModelId);
			bool flag = modSrm_invmodel != null;
			if (flag)
			{
				result = modSrm_invmodel.ModelName;
			}
			return result;
		}

		// Token: 0x0600051C RID: 1308 RVA: 0x0008241C File Offset: 0x0008061C
		private string ReplaceCombin(string str)
		{
			string text = str;
			string[] array = str.Split(new char[]
			{
				','
			});
			for (int i = 0; i < array.Length; i++)
			{
				bool flag = array[i].Contains("%");
				if (flag)
				{
					ModT_product model = DAL.Base.SQSConfig.DalT_product.Instance.GetModel("Code", array[i].Split(new char[]
					{
						'%'
					})[1]);
					bool flag2 = model != null;
					if (flag2)
					{
						text = text.Replace("%" + array[i].Split(new char[]
						{
							'%'
						})[1], "%" + model.Name);
					}
				}
			}
			return text;
		}

		// Token: 0x0600051D RID: 1309 RVA: 0x000824E0 File Offset: 0x000806E0
		private void btnSearch_Click(object sender, EventArgs e)
		{
			string key = this.txtName.Text.Trim();
			this.LoadData(key);
		}

		// Token: 0x0600051E RID: 1310 RVA: 0x00082508 File Offset: 0x00080708
		private void txtName_KeyPress(object sender, KeyPressEventArgs e)
		{
			bool flag = e.KeyChar == '\r';
			if (flag)
			{
				this.LoadData(this.txtName.Text.Trim());
			}
		}

		// Token: 0x0600051F RID: 1311 RVA: 0x00082540 File Offset: 0x00080740
		private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			bool flag = e.RowIndex >= 0;
			if (flag)
			{
				this.GetCurrentItem(e.RowIndex);
			}
		}

		// Token: 0x06000520 RID: 1312 RVA: 0x00082570 File Offset: 0x00080770
		private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			bool flag = ((DataGridViewX)sender).CurrentCell != null && ((DataGridViewX)sender).CurrentCell.OwningColumn.Name == "C_HeWeiConfig";
			if (flag)
			{
				bool flag2 = this.selectrow.Cells["C_Code"].Value.ToString() != "0";
				if (flag2)
				{
					this.OpenForm(typeof(frmProUnitCheck), ((DataGridViewX)sender).CurrentCell.OwningColumn.HeaderText, BaseForm.FormActtion.Modify);
				}
			}
		}

		// Token: 0x06000521 RID: 1313 RVA: 0x0008260C File Offset: 0x0008080C
		private void dgvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			bool flag = e.RowIndex >= 0;
			if (flag)
			{
				this.OpenFormShow(typeof(frmProductEditShow), this.btnModify.Text, BaseForm.FormActtion.Modify, this._FrmName, this.txtName.Text.Trim());
			}
		}

		// Token: 0x06000522 RID: 1314 RVA: 0x00082660 File Offset: 0x00080860
		private void GetCurrentItem(int rowindex)
		{
			this.selectrow = this.dgvData.Rows[rowindex];
			this._CurrentId = int.Parse(this.dgvData.Rows[rowindex].Cells[0].Value.ToString());
			this._CurrentItemName = this.dgvData.Rows[rowindex].Cells["C_ProName"].Value.ToString();
			this.mCurrentInvCode = this.dgvData.Rows[rowindex].Cells["C_InvCode"].Value.ToString();
		}

		// Token: 0x06000523 RID: 1315 RVA: 0x00082716 File Offset: 0x00080916
		private void btnItemC_Click(object sender, EventArgs e)
		{
			this.OpenForm(typeof(frmItemChoose), ((ButtonItem)sender).Text, new object[]
			{
				"t_product",
				base.Name
			});
		}

		// Token: 0x06000524 RID: 1316 RVA: 0x0008274C File Offset: 0x0008094C
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

		// Token: 0x06000525 RID: 1317 RVA: 0x00003040 File Offset: 0x00001240
		protected void OpenForm(ButtonItem sender, BaseForm.FormActtion action, string d)
		{
		}

		// Token: 0x06000526 RID: 1318 RVA: 0x000827F4 File Offset: 0x000809F4
		private void dgvData_SelectionChanged(object sender, EventArgs e)
		{
			bool flag = this.dgvData.SelectedRows.Count > 0;
			if (flag)
			{
				this.GetCurrentItem(this.dgvData.SelectedRows[0].Index);
			}
		}

		// Token: 0x06000527 RID: 1319 RVA: 0x00082838 File Offset: 0x00080A38
		private void btnExport_Click(object sender, EventArgs e)
		{
			base.DataGridViewToExcel(this.dgvData);
		}

		// Token: 0x06000528 RID: 1320 RVA: 0x00082848 File Offset: 0x00080A48
		private void cbxIsNCC_Click(object sender, EventArgs e)
		{
			bool @checked = this.cbxIsNCC.Checked;
			if (@checked)
			{
				this._InvSaleKeyCode = "NC";
			}
			else
			{
				this._InvSaleKeyCode = "0";
			}
			this.InitListData();
			this.LoadData("");
		}

		// Token: 0x06000529 RID: 1321 RVA: 0x00082894 File Offset: 0x00080A94
		private void btnModify_Click(object sender, EventArgs e)
		{
			this.OpenFormShow(typeof(frmProductEditShow), ((ButtonItem)sender).Text, BaseForm.FormActtion.Modify, this._FrmName, this.txtName.Text.Trim());
		}

		// Token: 0x0600052A RID: 1322 RVA: 0x000828CC File Offset: 0x00080ACC
		protected void OpenFormShow(Type type, string title, BaseForm.FormActtion action, string dir, string condition)
		{
			OfficeForm officeForm = base.CreateInstance<OfficeForm>(type, title, action, dir);
			bool flag = officeForm != null;
			if (flag)
			{
				bool flag2 = officeForm.ShowDialog() == DialogResult.Yes;
				if (flag2)
				{
					this.InitListData();
					this.LoadData(condition);
				}
			}
		}

		// Token: 0x040008C8 RID: 2248
		private int _StaticColumnCount;

		// Token: 0x040008C9 RID: 2249
		private bool isEditOpen = false;

		// Token: 0x040008CA RID: 2250
		private DAL.SQLServer.SQSConfig.DalT_product _Dal = DAL.Base.SQSConfig.DalT_product.Instance;

		// Token: 0x040008CB RID: 2251
		private DataGridViewRow selectrow;

		// Token: 0x040008CC RID: 2252
		private int _ProductState = 0;

		// Token: 0x040008CD RID: 2253
		private string mCurrentInvCode = string.Empty;

		// Token: 0x040008CE RID: 2254
		private readonly int mCheckMaxCount = 1000;

		// Token: 0x040008CF RID: 2255
		private string _InvSaleKeyCode = "0";

		// Token: 0x040008D0 RID: 2256
		private List<ModT_productext> mListProductExt = new List<ModT_productext>();

		// Token: 0x040008D1 RID: 2257
		private List<ModSrm_invmodel> mListInvModel = new List<ModSrm_invmodel>();

		// Token: 0x040008D2 RID: 2258
		private List<ModT_warehouse> mListWareHouse = new List<ModT_warehouse>();

		// Token: 0x040008D3 RID: 2259
		private List<ModT_product> mListProduct = new List<ModT_product>();
	}
}
