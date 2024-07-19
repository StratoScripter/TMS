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
	// Token: 0x02000090 RID: 144
	public partial class frmTankEdit : BaseDialogForm
	{
		// Token: 0x060007E1 RID: 2017 RVA: 0x000C4404 File Offset: 0x000C2604
		public frmTankEdit(string text, BaseForm.FormActtion act, int id, string dir)
		{
			this.InitializeComponent();
			this.SetText(this);
			this.Text = text;
			this._Act = act;
			this._CurrentId = id;
			this._Direct = dir;
		}

		// Token: 0x060007E2 RID: 2018 RVA: 0x000C4458 File Offset: 0x000C2658
		private void frmTankEdit_Load(object sender, EventArgs e)
		{
			this.InitControl();
			this.LoadData();
		}

		// Token: 0x060007E3 RID: 2019 RVA: 0x000C446C File Offset: 0x000C266C
		private void InitControl()
		{
			List<ModT_product> listByState = DalT_product.Instance.GetListByState(1, 0);
			this.cmbProduct.BindDataSouce(listByState, "InvName", "PinYinMa", "InvCode");
		}

		// Token: 0x060007E4 RID: 2020 RVA: 0x000C44A4 File Offset: 0x000C26A4
		protected override void LoadData()
		{
			bool flag = BaseForm.FormActtion.Modify == this._Act;
			if (flag)
			{
				this._mod = DalT_tank.Instance.GetModel(this._CurrentId);
				bool flag2 = this._mod == null;
				if (flag2)
				{
					base.ShowMsg(Messages.ObjNonExist, "", "");
					base.Close();
				}
				else
				{
					this.txtName.Text = this._mod.Name;
					this.iInputCode.Value = this._mod.Code;
					this.cmbProduct.SelectedValue = this._mod.InvCode;
					this.nudVol.Value = (double)this._mod.TotalVol;
					this.nudRealVol.Value = (double)this._mod.RealVol;
					this.cmbDanWei.Text = this._mod.DanWei;
					this.rtbRemark.Text = this._mod.Remark;
				}
			}
		}

		// Token: 0x060007E5 RID: 2021 RVA: 0x000C45BC File Offset: 0x000C27BC
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

		// Token: 0x060007E6 RID: 2022 RVA: 0x000C460C File Offset: 0x000C280C
		private bool Add()
		{
			this._mod.Name = this.txtName.Text.Trim();
			this._mod.Code = this.iInputCode.Value;
			this._mod.ProductName = this.cmbProduct.Text;
			this._mod.InvCode = this.cmbProduct.SelectedValue.ToString();
			this._mod.TotalVol = Convert.ToDecimal(string.Format("{0:F2}", this.nudVol.Value));
			this._mod.RealVol = Convert.ToDecimal(string.Format("{0:F2}", this.nudRealVol.Value));
			this._mod.DanWei = this.cmbDanWei.Text;
			this._mod.Remark = this.rtbRemark.Text.Trim();
			this._mod.PinYinMa = this._mod.Name.GetFirstPinyin();
			bool flag = base.IsExist("t_tank", "Name", this._mod.Name, SqlDbType.NVarChar);
			bool result;
			if (flag)
			{
				base.ShowMsg(Messages.TankHaved, "", "");
				this.txtName.Focus();
				result = false;
			}
			else
			{
				bool flag2 = base.IsExist("t_tank", "Code", this._mod.Code, SqlDbType.NVarChar);
				if (flag2)
				{
					base.ShowMsg(Messages.TankCodeHaved, "", "");
					this.iInputCode.Focus();
					result = false;
				}
				else
				{
					int num = DalT_tank.Instance.Add(this._mod);
					bool flag3 = num <= 0;
					if (flag3)
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
			}
			return result;
		}

		// Token: 0x060007E7 RID: 2023 RVA: 0x000C4824 File Offset: 0x000C2A24
		private bool Modify()
		{
			ModT_tank oldValue = this._mod.Clone() as ModT_tank;
			this._mod.Name = this.txtName.Text.Trim();
			this._mod.Code = this.iInputCode.Value;
			this._mod.ProductName = this.cmbProduct.Text;
			this._mod.InvCode = this.cmbProduct.SelectedValue.ToString();
			this._mod.TotalVol = (decimal)this.nudVol.Value;
			this._mod.RealVol = (decimal)this.nudRealVol.Value;
			this._mod.DanWei = this.cmbDanWei.Text;
			this._mod.Remark = this.rtbRemark.Text.Trim();
			this._mod.PinYinMa = this._mod.Name.GetFirstPinyin();
			bool flag = base.IsExistOutSelf("t_tank", "Name", this._mod.Name, SqlDbType.NVarChar, this._CurrentId);
			bool result;
			if (flag)
			{
				base.ShowMsg(Messages.TankHaved, "", "");
				this.txtName.Focus();
				result = false;
			}
			else
			{
				bool flag2 = base.IsExistOutSelf("t_tank", "Code", this._mod.Code, SqlDbType.NVarChar, this._CurrentId);
				if (flag2)
				{
					base.ShowMsg(Messages.TankCodeHaved, "", "");
					this.iInputCode.Focus();
					result = false;
				}
				else
				{
					bool flag3 = !DalT_tank.Instance.Update(this._mod);
					if (flag3)
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
				}
			}
			return result;
		}

		// Token: 0x060007E8 RID: 2024 RVA: 0x000C4A34 File Offset: 0x000C2C34
		private bool TextCheck()
		{
			bool flag = string.IsNullOrWhiteSpace(this.txtName.Text);
			bool result;
			if (flag)
			{
				base.ShowMsg(Messages.TankNull, "", "");
				this.txtName.Focus();
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

		// Token: 0x04000D8E RID: 3470
		private ModT_tank _mod = new ModT_tank();
	}
}
