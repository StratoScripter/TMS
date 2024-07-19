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
using DevComponents.Editors;
using Model;
using Model.SQSConfig;
using SQSClient.Properties;

namespace SQSClient
{
	// Token: 0x02000091 RID: 145
	public partial class frmTruck : BaseDialogForm
	{
		// Token: 0x060007EB RID: 2027 RVA: 0x000C58C4 File Offset: 0x000C3AC4
		public frmTruck()
		{
			this.InitializeComponent();
			this.SetText(this);
			this._Controls.Clear();
			this._Controls.Add(this.bar);
			this._Controls.Add(this.dgvData);
			base.SetGridUI(this.dgvData);
		}

		// Token: 0x060007EC RID: 2028 RVA: 0x000C5938 File Offset: 0x000C3B38
		private void frmTruck_Load(object sender, EventArgs e)
		{
			BaseDialogForm._operateArgs.Category = this.Text;
			base.InitBurron();
			this.InitControl();
			this._PageCount = this._Dal.GetListCount("1=1") / int.Parse(this.cmbPage.Text) + 1;
			this.labPageCounts.Text = this._PageCount.ToString();
			bool isDefaultLicenseSch = Settings.Instance.IsDefaultLicenseSch;
			if (isDefaultLicenseSch)
			{
				this.LoadData("");
			}
		}

		// Token: 0x060007ED RID: 2029 RVA: 0x00003040 File Offset: 0x00001240
		private void InitControl()
		{
		}

		// Token: 0x060007EE RID: 2030 RVA: 0x000C59C4 File Offset: 0x000C3BC4
		protected override void LoadData(string Name)
		{
			this.dgvData.Rows.Clear();
			List<ModT_truck> list = new List<ModT_truck>();
			List<string> list2 = new List<string>();
			list2.Add("Lisence");
			bool flag = Name == "";
			if (flag)
			{
				string formula = "1=1";
				list = this._Dal.GetListPages(int.Parse(this.cmbPage.Text), int.Parse(this.txtNowPage.Text) - 1, formula, list2);
			}
			else
			{
				string formula = "Lisence like '%" + Name + "%'";
				list = this._Dal.GetListPages(int.Parse(this.cmbPage.Text), int.Parse(this.txtNowPage.Text) - 1, formula, list2);
			}
			int num = 0;
			foreach (ModT_truck modT_truck in list)
			{
				bool flag2 = num > 500;
				if (flag2)
				{
					break;
				}
				num++;
				int num2 = 0;
				object[] array = new object[this.dgvData.ColumnCount];
				array[num2++] = modT_truck.Id.ToString();
				array[num2++] = modT_truck.Lisence;
				ModT_truckman model = DAL.Base.SQSConfig.DalT_truckman.Instance.GetModel("IDCard", modT_truck.DriverID);
				ModT_truckman model2 = DAL.Base.SQSConfig.DalT_truckman.Instance.GetModel("IDCard", modT_truck.SupercargoID);
				array[num2++] = ((model == null) ? null : model.Name);
				array[num2++] = ((model2 == null) ? null : model2.Name);
				array[num2++] = modT_truck.CoachNum;
				array[num2++] = modT_truck.TypeName;
				array[num2++] = modT_truck.Vol;
				ModT_trucktype model3 = DAL.Base.SQSConfig.DalT_trucktype.Instance.GetModel("Name", modT_truck.TypeName);
				bool flag3 = model3 != null;
				if (flag3)
				{
					array[num2++] = model3.Factor;
				}
				else
				{
					array[num2++] = "";
				}
				array[num2++] = modT_truck.NetWeight;
				array[num2++] = modT_truck.CangShu;
				array[num2++] = modT_truck.ValidDate.ToShortDateString();
				array[num2++] = modT_truck.Weight;
				array[num2++] = modT_truck.LoadWeight;
				array[num2++] = modT_truck.SubUnit;
				array[num2++] = modT_truck.Remark;
				this.dgvData.Rows.Add(array);
			}
			bool flag4 = this.dgvData.Rows.Count > 0;
			if (flag4)
			{
				this.GetCurrentItem(0);
			}
			else
			{
				this.btnModify.Enabled = false;
				this.btnDelete.Enabled = false;
			}
		}

		// Token: 0x060007EF RID: 2031 RVA: 0x000C5D04 File Offset: 0x000C3F04
		private void btnAdd_Click(object sender, EventArgs e)
		{
			this.OpenForm(typeof(frmTruckEdit), ((ButtonItem)sender).Text, BaseForm.FormActtion.Add, this._FrmName);
		}

		// Token: 0x060007F0 RID: 2032 RVA: 0x000C5D2A File Offset: 0x000C3F2A
		private void btnModify_Click(object sender, EventArgs e)
		{
			this.OpenForm(typeof(frmTruckEdit), ((ButtonItem)sender).Text, BaseForm.FormActtion.Modify, this._FrmName);
		}

		// Token: 0x060007F1 RID: 2033 RVA: 0x000C5D50 File Offset: 0x000C3F50
		private void btnDelete_Click(object sender, EventArgs e)
		{
			BaseDialogForm._operateArgs.OperateType = ((ButtonItem)sender).Text;
			ModT_truck model = this._Dal.GetModel(this._CurrentId);
			bool flag = !base.ShowChoise(Messages.DeleteSure, "", "");
			if (!flag)
			{
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

		// Token: 0x060007F2 RID: 2034 RVA: 0x000C5E04 File Offset: 0x000C4004
		private void btnSearch_Click(object sender, EventArgs e)
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

		// Token: 0x060007F3 RID: 2035 RVA: 0x000C5E60 File Offset: 0x000C4060
		private void PageFresh()
		{
			string text = this.txtName.Text.Trim();
			bool flag = text == "";
			if (flag)
			{
				string formula = "1=1";
				this._PageCount = this._Dal.GetListCount(formula) / int.Parse(this.cmbPage.Text) + 1;
				this.labPageCounts.Text = this._PageCount.ToString();
			}
			else
			{
				string formula = "Lisence like '%" + text + "%'";
				this._PageCount = this._Dal.GetListCount(formula) / int.Parse(this.cmbPage.Text) + 1;
				this.labPageCounts.Text = this._PageCount.ToString();
			}
		}

		// Token: 0x060007F4 RID: 2036 RVA: 0x000C5F2C File Offset: 0x000C412C
		private void txtName_KeyPress(object sender, KeyPressEventArgs e)
		{
			bool flag = e.KeyChar == '\r';
			if (flag)
			{
				this.LoadData(this.txtName.Text.Trim());
			}
		}

		// Token: 0x060007F5 RID: 2037 RVA: 0x000C5F64 File Offset: 0x000C4164
		private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			bool flag = e.RowIndex >= 0;
			if (flag)
			{
				this.GetCurrentItem(e.RowIndex);
			}
		}

		// Token: 0x060007F6 RID: 2038 RVA: 0x000C5F94 File Offset: 0x000C4194
		private void dgvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			bool flag = e.RowIndex >= 0;
			if (flag)
			{
				this.OpenForm(typeof(frmTruckEdit), this.btnModify.Text, BaseForm.FormActtion.Modify, this._FrmName);
			}
		}

		// Token: 0x060007F7 RID: 2039 RVA: 0x000C5FD8 File Offset: 0x000C41D8
		private void GetCurrentItem(int rowindex)
		{
			this._CurrentId = int.Parse(this.dgvData.Rows[rowindex].Cells[0].Value.ToString());
			this._CurrentItemName = this.dgvData.Rows[rowindex].Cells["C_Lisence"].Value.ToString();
			this.btnModify.Enabled = true;
			this.btnDelete.Enabled = true;
		}

		// Token: 0x060007F8 RID: 2040 RVA: 0x000C6064 File Offset: 0x000C4264
		private void btnReduce_Click(object sender, EventArgs e)
		{
			List<ModT_truck> allList = DAL.Base.SQSConfig.DalT_truck.Instance.GetAllList();
			List<ModT_truck> listAll = DAL.Base.SQSConfig.DalT_truck.Instance.GetAllList();
			string lisences = string.Empty;
			(from g in allList
			group g by g.Lisence).ToList<IGrouping<string, ModT_truck>>().ForEach(delegate(IGrouping<string, ModT_truck> t)
			{
				List<ModT_truck> list = (from o in listAll
				where o.Lisence.Equals(t.Key)
				select o).ToList<ModT_truck>();
				bool flag = list.Count > 1;
				if (flag)
				{
					for (int i = 0; i < list.Count - 1; i++)
					{
						lisences = lisences + list[i].Lisence + ",";
						DAL.Base.SQSConfig.DalT_truck.Instance.Delete(list[i].Id);
					}
				}
			});
			lisences = lisences.Trim(new char[]
			{
				','
			});
		}

		// Token: 0x060007F9 RID: 2041 RVA: 0x000C60F8 File Offset: 0x000C42F8
		private void txtNowPageChanged(object sender, EventArgs e)
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

		// Token: 0x060007FA RID: 2042 RVA: 0x000C61A8 File Offset: 0x000C43A8
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

		// Token: 0x060007FB RID: 2043 RVA: 0x000C6204 File Offset: 0x000C4404
		private void btn_pageup_Click(object sender, EventArgs e)
		{
			this.txtNowPage.Text = (int.Parse(this.txtNowPage.Text) - 1).ToString();
		}

		// Token: 0x060007FC RID: 2044 RVA: 0x000C6238 File Offset: 0x000C4438
		private void btn_pagedown_Click(object sender, EventArgs e)
		{
			this.txtNowPage.Text = (int.Parse(this.txtNowPage.Text) + 1).ToString();
		}

		// Token: 0x060007FD RID: 2045 RVA: 0x000C626C File Offset: 0x000C446C
		private void btnSpecialStepClass_Click(object sender, EventArgs e)
		{
			frmSpecialStepClass frmSpecialStepClass = new frmSpecialStepClass();
			frmSpecialStepClass.ShowDialog();
		}

		// Token: 0x04000DA1 RID: 3489
		private DAL.SQLServer.SQSConfig.DalT_truck _Dal = DAL.Base.SQSConfig.DalT_truck.Instance;

		// Token: 0x04000DA2 RID: 3490
		private int _PageCount;
	}
}
