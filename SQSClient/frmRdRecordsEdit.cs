using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Base;
using DAL.Base.SQSConfig;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using DevComponents.DotNetBar.Layout;
using DevComponents.Editors;
using Model;
using Model.SQSConfig;
using SQSClient.Properties;

namespace SQSClient
{
	// Token: 0x02000049 RID: 73
	public partial class frmRdRecordsEdit : BaseDialogForm
	{
		// Token: 0x06000363 RID: 867 RVA: 0x00055578 File Offset: 0x00053778
		public frmRdRecordsEdit(string text, BaseForm.FormActtion act, int id, string dir, int recordIndex)
		{
			this.InitializeComponent();
			this.SetText(this);
			this.Text = text;
			this._Act = act;
			this._CurrentId = id;
			this._Direct = dir;
			this.mRecordIndex = recordIndex;
		}

		// Token: 0x06000364 RID: 868 RVA: 0x000555DB File Offset: 0x000537DB
		private void frmRdRecordsEdit_Load(object sender, EventArgs e)
		{
			this.InitControl();
			this.LoadData();
		}

		// Token: 0x06000365 RID: 869 RVA: 0x000555EC File Offset: 0x000537EC
		private void InitControl()
		{
			List<ModT_product> listByState = DalT_product.Instance.GetListByState(1, 0);
			this.cmbProduct.BindDataSouce(listByState, "Name", "PinYinMa", "InvCode");
			BaseForm.EnumModel enumModel = new BaseForm.EnumModel();
			enumModel.Name = "All";
			enumModel.Description = ShowWords.ReplaceText("All");
			enumModel.Value = -1;
			List<BaseForm.EnumModel> list = new List<BaseForm.EnumModel>();
			list.Add(enumModel);
			list.AddRange(BaseForm.GetEnumModelList<RdRecordStatus>());
			BaseForm.BindDataSouce(this.cmbRdsStatus, list, "Description", "Value");
		}

		// Token: 0x06000366 RID: 870 RVA: 0x00055684 File Offset: 0x00053884
		private void InitBatchCode(string invCode)
		{
			List<ModCs_currstock> listByInvCode = DalCs_currstock.Instance.GetListByInvCode(invCode, true);
			this.cmbBatchCode.BindDataSouce(listByInvCode, "BatchNum", "BatchNum", "BatchNum");
		}

		// Token: 0x06000367 RID: 871 RVA: 0x000556BC File Offset: 0x000538BC
		private void cmbProduct_SelectedIndexChanged(object sender, EventArgs e)
		{
			string invCode = this.cmbProduct.SelectedValue.ToString();
			this.InitBatchCode(invCode);
			ModT_product modelByInvCode = DalT_product.Instance.GetModelByInvCode(invCode);
			bool flag = modelByInvCode != null;
			if (flag)
			{
				this.txtInvCode.Text = modelByInvCode.InvCode;
				this.txtInvName.Text = modelByInvCode.InvName;
			}
		}

		// Token: 0x06000368 RID: 872 RVA: 0x00055720 File Offset: 0x00053920
		protected override void LoadData()
		{
			this.iInputBillSort.Enabled = false;
			bool flag = BaseForm.FormActtion.Modify == this._Act;
			if (flag)
			{
				this._mod = DalCs_rdrecords.Instance.GetModel(this._CurrentId);
				bool flag2 = this._mod == null;
				if (flag2)
				{
					base.ShowMsg(Messages.ObjNonExist, "", "");
					base.Close();
				}
				else
				{
					ModT_product modT_product = DalT_product.Instance.GetModelByInvCode(this._mod.InvCode);
					bool flag3 = modT_product == null;
					if (flag3)
					{
						modT_product = new ModT_product();
					}
					this.iInputBillSort.Value = this._mod.BillSort;
					this.cmbProduct.Text = modT_product.Name;
					this.txtInvCode.Text = modT_product.InvCode;
					this.txtInvName.Text = modT_product.InvName;
					this.cmbBatchCode.Text = this._mod.BatchNum;
					this.txtExtBarCode.Text = this._mod.ExtBarCode;
					this.txtCurrStockVol.Text = DalCs_currstock.Instance.GetQuantityBySch(this._mod.InvCode, this._mod.BatchNum).ToString();
					this.nudQuantity.Value = this._mod.Quantity;
					this.cmbRdsStatus.SelectedValue = this._mod.RdsStatus;
					this.cmbRdsState.SelectedValue = this._mod.RdsState;
					this.txtPositionInfo.Text = this._mod.PositionInfo;
				}
			}
			else
			{
				bool flag4 = this._Act == BaseForm.FormActtion.Add;
				if (flag4)
				{
					this._mod = new ModCs_rdrecords();
					this._mod.RecordIndex = this.mRecordIndex;
					this.iInputBillSort.Value = DalCs_rdrecords.Instance.GetCountByRdIndex(this.mRecordIndex) + 1;
					this.InitControl();
				}
			}
		}

		// Token: 0x06000369 RID: 873 RVA: 0x00055928 File Offset: 0x00053B28
		private void ReadControl()
		{
			this._mod.InvCode = this.cmbProduct.SelectedValue.ToString();
			this._mod.BatchNum = this.cmbBatchCode.Text;
			this._mod.ExtBarCode = this.txtExtBarCode.Text;
			this._mod.Quantity = this.nudQuantity.Value;
			this._mod.RdsStatus = Convert.ToInt32(this.cmbRdsStatus.SelectedValue.ToString());
			this._mod.RdsState = 0;
			this._mod.PositionInfo = this.txtPositionInfo.Text.Trim();
		}

		// Token: 0x0600036A RID: 874 RVA: 0x000559E4 File Offset: 0x00053BE4
		private void btnSave_Click(object sender, EventArgs e)
		{
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
					base.DialogResult = DialogResult.Yes;
				}
			}
		}

		// Token: 0x0600036B RID: 875 RVA: 0x00055A34 File Offset: 0x00053C34
		private bool Add()
		{
			this.ReadControl();
			this._mod.BillSort = this.iInputBillSort.Value;
			this._mod.CreateDate = (this._mod.SDate = (this._mod.VDate = (this._mod.MadeDate = (this._mod.CheckDate = DateTime.Now))));
			int num = DalCs_rdrecords.Instance.Add(this._mod);
			bool flag = num <= 0;
			bool result;
			if (flag)
			{
				this.OnOperateFail(this._mod, false);
				base.ShowMsg(Messages.AddFalse, "", "");
				result = false;
			}
			else
			{
				this.OnOperateSuccess(this._mod, true);
				result = true;
			}
			return result;
		}

		// Token: 0x0600036C RID: 876 RVA: 0x00055B18 File Offset: 0x00053D18
		private bool Modify()
		{
			ModCs_rdrecords oldValue = this._mod.Clone() as ModCs_rdrecords;
			this.ReadControl();
			bool flag = !DalCs_rdrecords.Instance.Update(this._mod);
			bool result;
			if (flag)
			{
				this.OnOperateFail(this._mod, false);
				base.ShowMsg(Messages.ModifyFalse, "", "");
				result = false;
			}
			else
			{
				this.OnOperateSuccess(this._mod, oldValue, true);
				result = true;
			}
			return result;
		}

		// Token: 0x0600036D RID: 877 RVA: 0x00055B9C File Offset: 0x00053D9C
		private bool TextCheck()
		{
			bool flag = string.IsNullOrWhiteSpace(this.cmbProduct.Text);
			bool result;
			if (flag)
			{
				base.ShowMsg(Messages.ProductNull, "", "");
				this.cmbProduct.Focus();
				result = false;
			}
			else
			{
				string text = this.cmbProduct.Text;
				bool flag2 = text != "";
				if (flag2)
				{
					bool flag3 = true;
					DalT_product.Instance.IsExist("Name", text, SqlDbType.NVarChar, ref flag3);
					bool flag4 = !flag3;
					if (flag4)
					{
						base.ShowMsg(Messages.ProductHavent, "", "");
						return false;
					}
				}
				result = true;
			}
			return result;
		}

		// Token: 0x0600036E RID: 878 RVA: 0x00055C48 File Offset: 0x00053E48
		private void cmbBatchCode_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.txtCurrStockVol.Text = DalCs_currstock.Instance.GetQuantityBySch(this.cmbProduct.SelectedValue.ToString(), this.cmbBatchCode.Text).ToString();
		}

		// Token: 0x0400058E RID: 1422
		private int mRecordIndex = 0;

		// Token: 0x0400058F RID: 1423
		private ModCs_rdrecords _mod = new ModCs_rdrecords();
	}
}
