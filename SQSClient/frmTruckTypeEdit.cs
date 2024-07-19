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
	// Token: 0x0200006D RID: 109
	public partial class frmTruckTypeEdit : BaseDialogForm
	{
		// Token: 0x0600057E RID: 1406 RVA: 0x0008D5E0 File Offset: 0x0008B7E0
		public frmTruckTypeEdit(string text, BaseForm.FormActtion act, int id, string dir)
		{
			this.InitializeComponent();
			this.SetText(this);
			this.Text = text;
			this._Act = act;
			this._CurrentId = id;
			this._Direct = dir;
		}

		// Token: 0x0600057F RID: 1407 RVA: 0x0008D634 File Offset: 0x0008B834
		private void frmTruckTypeEdit_Load(object sender, EventArgs e)
		{
			this.InitControl();
			this.LoadData();
		}

		// Token: 0x06000580 RID: 1408 RVA: 0x0008D645 File Offset: 0x0008B845
		private void InitControl()
		{
			this.productlist = DalT_product.Instance.GetListByState(1, 0);
			this.cmbProduct.BindDataSouce(this.productlist, "InvName", "PinYinMa", "InvCode");
		}

		// Token: 0x06000581 RID: 1409 RVA: 0x0008D67C File Offset: 0x0008B87C
		protected override void LoadData()
		{
			bool flag = BaseForm.FormActtion.Modify == this._Act;
			if (flag)
			{
				this._mod = DalT_trucktype.Instance.GetModel(this._CurrentId);
				bool flag2 = this._mod == null;
				if (flag2)
				{
					base.ShowMsg(Messages.ObjNonExist, "", "");
					base.Close();
				}
				else
				{
					this.txtName.Text = this._mod.Name;
					this.txtName.Enabled = false;
					this.cmbProduct.SelectedValue = this._mod.InvCode;
					this.dInputVol.Value = (double)this._mod.Vol;
					this.dInputFactor.Value = (double)this._mod.Factor;
					this.dInputNetWeight.Value = (double)this._mod.NetWeight;
					this.rtbRemark.Text = this._mod.Remark;
				}
			}
		}

		// Token: 0x06000582 RID: 1410 RVA: 0x0008D790 File Offset: 0x0008B990
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

		// Token: 0x06000583 RID: 1411 RVA: 0x0008D7E0 File Offset: 0x0008B9E0
		private bool Add()
		{
			this._mod.Name = this.txtName.Text.Trim();
			this._mod.ProductName = this.cmbProduct.Text;
			this._mod.InvCode = this.cmbProduct.SelectedValue.ToString();
			this._mod.Vol = (decimal)this.dInputVol.Value;
			this._mod.Factor = (decimal)this.dInputFactor.Value;
			this._mod.NetWeight = (decimal)this.dInputNetWeight.Value;
			this._mod.Remark = this.rtbRemark.Text.Trim();
			this._mod.PinYinMa = "";
			bool flag = base.IsExist("t_trucktype", "Name", this._mod.Name, SqlDbType.NVarChar);
			bool result;
			if (flag)
			{
				base.ShowMsg(Messages.CoachTypeHaved, "", "");
				result = false;
			}
			else
			{
				int num = DalT_trucktype.Instance.Add(this._mod);
				bool flag2 = num < 1;
				if (flag2)
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
			}
			return result;
		}

		// Token: 0x06000584 RID: 1412 RVA: 0x0008D95C File Offset: 0x0008BB5C
		private bool Modify()
		{
			ModT_trucktype oldValue = this._mod.Clone() as ModT_trucktype;
			this._mod.Name = this.txtName.Text.Trim();
			this._mod.ProductName = this.cmbProduct.Text;
			this._mod.InvCode = this.cmbProduct.SelectedValue.ToString();
			this._mod.Vol = (decimal)this.dInputVol.Value;
			this._mod.Factor = (decimal)this.dInputFactor.Value;
			this._mod.NetWeight = (decimal)this.dInputNetWeight.Value;
			this._mod.Remark = this.rtbRemark.Text.Trim();
			this._mod.PinYinMa = "";
			bool flag = !DalT_trucktype.Instance.Update(this._mod);
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

		// Token: 0x06000585 RID: 1413 RVA: 0x0008DAAC File Offset: 0x0008BCAC
		private bool TextCheck()
		{
			bool flag = string.IsNullOrWhiteSpace(this.txtName.Text);
			bool result;
			if (flag)
			{
				base.ShowMsg(Messages.CoachTypeNull, "", "");
				result = false;
			}
			else
			{
				bool flag2 = string.IsNullOrWhiteSpace(this.cmbProduct.Text);
				if (flag2)
				{
					base.ShowMsg(Messages.ProductNull, "", "");
					this.cmbProduct.Focus();
					result = false;
				}
				else
				{
					string text = this.cmbProduct.Text;
					bool flag3 = text != "";
					if (flag3)
					{
						bool flag4 = true;
						DalT_product.Instance.IsExist("InvName", text, SqlDbType.NVarChar, ref flag4);
						bool flag5 = !flag4;
						if (flag5)
						{
							base.ShowMsg(Messages.ProductHavent, "", "");
							return false;
						}
					}
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06000586 RID: 1414 RVA: 0x0008DB8C File Offset: 0x0008BD8C
		private void cmbProduct_TextChanged(object sender, EventArgs e)
		{
			ModT_product modT_product = this.productlist.Find((ModT_product p) => p.InvName == this.cmbProduct.Text);
			bool flag = modT_product != null;
			if (flag)
			{
				this.dInputMidu.Value = (double)modT_product.Midu;
			}
		}

		// Token: 0x06000587 RID: 1415 RVA: 0x0008DBD4 File Offset: 0x0008BDD4
		private void dInputVol_ValueChanged(object sender, EventArgs e)
		{
			this.dInputNetWeight.Value = this.dInputMidu.Value * this.dInputVol.Value * this.dInputFactor.Value;
		}

		// Token: 0x06000588 RID: 1416 RVA: 0x0008DBD4 File Offset: 0x0008BDD4
		private void dInputFactor_ValueChanged(object sender, EventArgs e)
		{
			this.dInputNetWeight.Value = this.dInputMidu.Value * this.dInputVol.Value * this.dInputFactor.Value;
		}

		// Token: 0x040009BA RID: 2490
		private ModT_trucktype _mod = new ModT_trucktype();

		// Token: 0x040009BB RID: 2491
		private List<ModT_product> productlist;
	}
}
