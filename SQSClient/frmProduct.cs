using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
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
	// Token: 0x0200008C RID: 140
	public partial class frmProduct : BaseDialogForm
	{
		// Token: 0x17000032 RID: 50
		// (get) Token: 0x06000793 RID: 1939 RVA: 0x000BC7C4 File Offset: 0x000BA9C4
		public new string GetSelectIds
		{
			get
			{
				return this.mSelectIds;
			}
		}

		// Token: 0x06000794 RID: 1940 RVA: 0x000BC7DC File Offset: 0x000BA9DC
		public frmProduct()
		{
			this.InitializeComponent();
			this.SetText(this);
			this._Controls.Clear();
			this._Controls.Add(this.bar);
			this._Controls.Add(this.dgvData);
			base.SetGridUI(this.dgvData);
			this.dgvData.MultiSelect = true;
		}

		// Token: 0x06000795 RID: 1941 RVA: 0x000BC880 File Offset: 0x000BAA80
		public frmProduct(string text, BaseForm.FormActtion act)
		{
			this.InitializeComponent();
			base.Width = Screen.PrimaryScreen.Bounds.Width;
			this.SetText(this);
			this._Controls.Clear();
			this._Controls.Add(this.bar);
			this._Controls.Add(this.dgvData);
			base.SetGridUI(this.dgvData);
			this._Act = act;
			this.dgvData.MultiSelect = true;
		}

		// Token: 0x06000796 RID: 1942 RVA: 0x000BC944 File Offset: 0x000BAB44
		private void frmProduct_Load(object sender, EventArgs e)
		{
			BaseDialogForm._operateArgs.Category = this.Text;
			base.InitBurron();
			this._StaticColumnCount = this.dgvData.Columns.Count;
			base.CreateDgv(this.dgvData, "c_t_product_" + base.Name);
			this.CheckAttribute();
			this.InitControl();
			string formula = "Enable = 1";
			this._PageCount = this._Dal.GetListCount(formula) / int.Parse(this.cmbPage.Text) + 1;
			this.labPageCounts.Text = this._PageCount.ToString();
			bool flag = this._Act != BaseForm.FormActtion.Import && Settings.Instance.IsDefaultProductSch;
			if (flag)
			{
				this.LoadData("");
			}
		}

		// Token: 0x06000797 RID: 1943 RVA: 0x000BCA18 File Offset: 0x000BAC18
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

		// Token: 0x06000798 RID: 1944 RVA: 0x000BCA7C File Offset: 0x000BAC7C
		private void CheckAttribute()
		{
			bool flag = this._Act == BaseForm.FormActtion.Import;
			if (flag)
			{
				this.SetBtnVisible(true);
				this.dgvData.MultiSelect = true;
				this.Text = ShowWords.ReplaceText("ImportBill");
				this._ProductState = 0;
			}
			else
			{
				bool flag2 = this._Act == BaseForm.FormActtion.BatchSet;
				if (flag2)
				{
					this.SetBtnVisible(true);
					this.dgvData.MultiSelect = true;
					this.Text = ShowWords.ReplaceText("ImportInvFree");
					this._ProductState = 1;
				}
				else
				{
					this.SetBtnVisible(false);
					this._ProductState = 1;
				}
			}
		}

		// Token: 0x06000799 RID: 1945 RVA: 0x000BCB18 File Offset: 0x000BAD18
		private void SetBtnVisible(bool visible)
		{
			this.btnImport.Visible = visible;
			this.btnImportProduct.Visible = !visible;
			this.btnImportInvModel.Visible = !visible;
			this.btnAdd.Visible = !visible;
			this.btnModify.Visible = !visible;
			this.btnDelete.Visible = !visible;
		}

		// Token: 0x0600079A RID: 1946 RVA: 0x00003040 File Offset: 0x00001240
		private void InitControl()
		{
		}

		// Token: 0x0600079B RID: 1947 RVA: 0x000BCB84 File Offset: 0x000BAD84
		protected override void LoadData(string proInfo)
		{
			this.dgvData.Rows.Clear();
			int num = 0;
			List<ViewT_product> list = new List<ViewT_product>();
			list = this._Dal.GetListViewByPage(proInfo, this._ProductState, int.Parse(this.cmbPage.Text), int.Parse(this.txtNowPage.Text) - 1, "");
			foreach (ViewT_product viewT_product in list)
			{
				int num2 = 0;
				object[] array = new object[this.dgvData.ColumnCount];
				array[num2++] = viewT_product.Id.ToString();
				array[num2++] = viewT_product.InvCode;
				array[num2++] = viewT_product.InvName;
				array[num2++] = viewT_product.Name;
				array[num2++] = viewT_product.Code;
				array[num2++] = viewT_product.InvCCode;
				array[num2++] = viewT_product.SpecsDescribe;
				array[num2++] = viewT_product.SunHao;
				array[num2++] = viewT_product.Midu;
				array[num2++] = ShowWords.ReplaceText(((ProductType)viewT_product.Type).ToString());
				array[num2++] = ShowWords.ReplaceText(((ProductValid)viewT_product.ValidCondition).ToString());
				array[num2++] = ShowWords.ReplaceText(((AccountType)viewT_product.PostType).ToString());
				array[num2++] = ShowWords.ReplaceText(((EffectState)viewT_product.State).ToString());
				array[num2++] = this.ReplaceCombin(viewT_product.Combin);
				array[num2++] = Resources.edit16;
				array[num2++] = viewT_product.InvModelName;
				array[num2++] = viewT_product.Remark;
				for (int i = this._StaticColumnCount; i < this.dgvData.ColumnCount; i++)
				{
					array[i] = base.GetValueMod<ViewT_product>(viewT_product, this.dgvData.Columns[i].DataPropertyName);
				}
				this.dgvData.Rows.Add(array);
				num++;
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

		// Token: 0x0600079C RID: 1948 RVA: 0x000BCE6C File Offset: 0x000BB06C
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

		// Token: 0x0600079D RID: 1949 RVA: 0x000BCF2E File Offset: 0x000BB12E
		private void btnAdd_Click(object sender, EventArgs e)
		{
			this.OpenForm(typeof(frmProductEdit), ((ButtonItem)sender).Text, BaseForm.FormActtion.Add, this._FrmName);
		}

		// Token: 0x0600079E RID: 1950 RVA: 0x000BCF54 File Offset: 0x000BB154
		private void btnModify_Click(object sender, EventArgs e)
		{
			this.OpenForm(typeof(frmProductEdit), ((ButtonItem)sender).Text, BaseForm.FormActtion.Modify, this._FrmName);
		}

		// Token: 0x0600079F RID: 1951 RVA: 0x000BCF7C File Offset: 0x000BB17C
		private void btnDelete_Click(object sender, EventArgs e)
		{
			BaseDialogForm._operateArgs.OperateType = ((ButtonItem)sender).Text;
			bool flag = !base.ShowChoise(Messages.DeleteSure, "", "");
			if (!flag)
			{
				ModT_product model = this._Dal.GetModel(this._CurrentId);
				bool flag2 = !this._Dal.Delete(this._CurrentId);
				if (flag2)
				{
					this.OnOperateFail(model, false);
					base.ShowMsg(Messages.DeleteFalse, "", "");
				}
				else
				{
					this.OnOperateSuccess(model, true);
					this.LoadData("");
				}
			}
		}

		// Token: 0x060007A0 RID: 1952 RVA: 0x000BD030 File Offset: 0x000BB230
		private void btnSearch_Click(object sender, EventArgs e)
		{
			this.PageFresh();
			bool flag = this._Act == BaseForm.FormActtion.Import;
			if (flag)
			{
				bool flag2 = !this.CheckMaxCount(this.txtName.Text.Trim());
				if (flag2)
				{
					return;
				}
			}
			bool flag3 = this.txtNowPage.Text == "1";
			if (flag3)
			{
				this.LoadData(this.txtName.Text.Trim());
			}
			else
			{
				this.txtNowPage.Text = "1";
			}
		}

		// Token: 0x060007A1 RID: 1953 RVA: 0x000BD0BC File Offset: 0x000BB2BC
		private void PageFresh()
		{
			string text = this.txtName.Text.Trim();
			bool flag = text == "";
			if (flag)
			{
				string formula = "1=1 and Enable = 1";
				this._PageCount = this._Dal.GetListCount(formula) / int.Parse(this.cmbPage.Text) + 1;
				this.labPageCounts.Text = this._PageCount.ToString();
			}
			else
			{
				string formula = string.Concat(new string[]
				{
					"(Name like '%",
					text,
					"%'or InvCode like '%",
					text,
					"%') and Enable = 1"
				});
				this._PageCount = this._Dal.GetListCount(formula) / int.Parse(this.cmbPage.Text) + 1;
				this.labPageCounts.Text = this._PageCount.ToString();
			}
		}

		// Token: 0x060007A2 RID: 1954 RVA: 0x000BD1A0 File Offset: 0x000BB3A0
		private void txtName_KeyPress(object sender, KeyPressEventArgs e)
		{
			bool flag = e.KeyChar == '\r';
			if (flag)
			{
				this.LoadData(this.txtName.Text.Trim());
			}
		}

		// Token: 0x060007A3 RID: 1955 RVA: 0x000BD1D8 File Offset: 0x000BB3D8
		private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			bool flag = e.RowIndex >= 0;
			if (flag)
			{
				this.GetCurrentItem(e.RowIndex);
			}
		}

		// Token: 0x060007A4 RID: 1956 RVA: 0x000BD208 File Offset: 0x000BB408
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

		// Token: 0x060007A5 RID: 1957 RVA: 0x000BD2A4 File Offset: 0x000BB4A4
		private void dgvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			bool flag = e.RowIndex >= 0;
			if (flag)
			{
				this.OpenForm(typeof(frmProductEdit), this.btnModify.Text, BaseForm.FormActtion.Modify, this._FrmName, this.txtName.Text.Trim());
			}
		}

		// Token: 0x060007A6 RID: 1958 RVA: 0x000BD2F8 File Offset: 0x000BB4F8
		private void GetCurrentItem(int rowindex)
		{
			this.selectrow = this.dgvData.Rows[rowindex];
			this._CurrentId = int.Parse(this.dgvData.Rows[rowindex].Cells[0].Value.ToString());
			this._CurrentItemName = this.dgvData.Rows[rowindex].Cells["C_ProName"].Value.ToString();
			this.mCurrentInvCode = this.dgvData.Rows[rowindex].Cells["C_InvCode"].Value.ToString();
			this.btnModify.Enabled = true;
			this.btnDelete.Enabled = true;
		}

		// Token: 0x060007A7 RID: 1959 RVA: 0x000BD3C8 File Offset: 0x000BB5C8
		private void btnImportProduct_Click(object sender, EventArgs e)
		{
			frmProduct frmProduct = new frmProduct(this.Text, BaseForm.FormActtion.Import);
			bool flag = frmProduct.ShowDialog() == DialogResult.Yes;
			if (flag)
			{
				DAL.Base.SQSConfig.DalT_product.Instance.UpdateStateByIds(1, frmProduct.GetSelectIds);
				this.LoadData(this.txtName.Text.Trim());
			}
		}

		// Token: 0x060007A8 RID: 1960 RVA: 0x00082716 File Offset: 0x00080916
		private void btnItemC_Click(object sender, EventArgs e)
		{
			this.OpenForm(typeof(frmItemChoose), ((ButtonItem)sender).Text, new object[]
			{
				"t_product",
				base.Name
			});
		}

		// Token: 0x060007A9 RID: 1961 RVA: 0x000BD41B File Offset: 0x000BB61B
		private void btnImport_Click(object sender, EventArgs e)
		{
			this.ObtainSelectIds();
			base.DialogResult = DialogResult.Yes;
		}

		// Token: 0x060007AA RID: 1962 RVA: 0x000BD430 File Offset: 0x000BB630
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

		// Token: 0x060007AB RID: 1963 RVA: 0x00003040 File Offset: 0x00001240
		protected void OpenForm(ButtonItem sender, BaseForm.FormActtion action, string d)
		{
		}

		// Token: 0x060007AC RID: 1964 RVA: 0x000BD4D8 File Offset: 0x000BB6D8
		private void btnImportInvModel_Click(object sender, EventArgs e)
		{
			frmInvStep frmInvStep = new frmInvStep(this.Text, BaseForm.FormActtion.Import);
			bool flag = frmInvStep.ShowDialog() == DialogResult.Yes;
			if (flag)
			{
				int selectGroupID = frmInvStep.SelectGroupID;
				bool flag2 = this.UpdateInvModelId(selectGroupID);
				if (flag2)
				{
					this.LoadData(this.txtName.Text.Trim());
				}
			}
		}

		// Token: 0x060007AD RID: 1965 RVA: 0x000BD530 File Offset: 0x000BB730
		private void btnImportInvFree_Click(object sender, EventArgs e)
		{
			bool flag = this.dgvData.SelectedRows.Count != 1;
			if (flag)
			{
				base.ShowMsg("OneLineRecord", "", "");
			}
			else
			{
				frmProductExt frmProductExt = new frmProductExt(this.Text, this.mCurrentInvCode, BaseForm.FormActtion.Import);
				bool flag2 = frmProductExt.ShowDialog() == DialogResult.Yes;
				if (flag2)
				{
				}
			}
		}

		// Token: 0x060007AE RID: 1966 RVA: 0x000BD594 File Offset: 0x000BB794
		private bool UpdateInvModelId(int invModelId)
		{
			this.ObtainSelectIds();
			return DAL.Base.SQSConfig.DalT_product.Instance.UpdateInvModelByIds(invModelId, this.mSelectIds);
		}

		// Token: 0x060007AF RID: 1967 RVA: 0x000BD5C0 File Offset: 0x000BB7C0
		private void dgvData_SelectionChanged(object sender, EventArgs e)
		{
			bool flag = this.dgvData.SelectedRows.Count > 0;
			if (flag)
			{
				this.GetCurrentItem(this.dgvData.SelectedRows[0].Index);
			}
		}

		// Token: 0x060007B0 RID: 1968 RVA: 0x000BD604 File Offset: 0x000BB804
		private void btnProductExtShow_Click(object sender, EventArgs e)
		{
			frmProductExtShow frmProductExtShow = new frmProductExtShow(this.Text, BaseForm.FormActtion.Import);
			bool flag = frmProductExtShow.ShowDialog() == DialogResult.Yes;
			if (flag)
			{
			}
		}

		// Token: 0x060007B1 RID: 1969 RVA: 0x000BD630 File Offset: 0x000BB830
		private void btn_pageup_Click(object sender, EventArgs e)
		{
			this.txtNowPage.Text = (int.Parse(this.txtNowPage.Text) - 1).ToString();
		}

		// Token: 0x060007B2 RID: 1970 RVA: 0x000BD664 File Offset: 0x000BB864
		private void btn_pagedown_Click(object sender, EventArgs e)
		{
			this.txtNowPage.Text = (int.Parse(this.txtNowPage.Text) + 1).ToString();
		}

		// Token: 0x060007B3 RID: 1971 RVA: 0x000BD698 File Offset: 0x000BB898
		private void cmbPage_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.PageFresh();
			bool flag = this.txtNowPage.Text == "1";
			if (flag)
			{
				this.LoadData(this.txtName.Text.Trim());
			}
			else
			{
				this.txtNowPage.Text = "1";
			}
		}

		// Token: 0x060007B4 RID: 1972 RVA: 0x000BD6F4 File Offset: 0x000BB8F4
		private void txtNowPage_TextChanged(object sender, EventArgs e)
		{
			int num = 0;
			try
			{
				num = int.Parse(this.txtNowPage.Text);
			}
			catch (Exception)
			{
				this.txtNowPage.Text = "1";
				MessageBox.Show("请正确输入页码");
			}
			bool flag = num < 1;
			if (flag)
			{
				this.txtNowPage.Text = "1";
			}
			else
			{
				bool flag2 = num > this._PageCount;
				if (flag2)
				{
					this.txtNowPage.Text = this._PageCount.ToString();
				}
			}
			this.LoadData(this.txtName.Text.Trim());
		}

		// Token: 0x04000CFA RID: 3322
		private int _StaticColumnCount;

		// Token: 0x04000CFB RID: 3323
		private bool isEditOpen = false;

		// Token: 0x04000CFC RID: 3324
		private int _PageCount;

		// Token: 0x04000CFD RID: 3325
		private DAL.SQLServer.SQSConfig.DalT_product _Dal = DAL.Base.SQSConfig.DalT_product.Instance;

		// Token: 0x04000CFE RID: 3326
		private DataGridViewRow selectrow;

		// Token: 0x04000CFF RID: 3327
		private int _ProductState = 0;

		// Token: 0x04000D00 RID: 3328
		private string mCurrentInvCode = string.Empty;

		// Token: 0x04000D01 RID: 3329
		private readonly int mCheckMaxCount = 1000;
	}
}
