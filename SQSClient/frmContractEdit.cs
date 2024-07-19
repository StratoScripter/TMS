using System;
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
using DevComponents.Editors.DateTimeAdv;
using Model;
using Model.SQSConfig;
using SQSClient.Properties;

namespace SQSClient
{
	// Token: 0x02000021 RID: 33
	public partial class frmContractEdit : BaseDialogForm
	{
		// Token: 0x0600018B RID: 395 RVA: 0x0002F590 File Offset: 0x0002D790
		public frmContractEdit(string text, BaseForm.FormActtion act, int id, string dir)
		{
			this.InitializeComponent();
			this.SetText(this);
			this.Text = text;
			this._Act = act;
			this._CurrentId = id;
			this._Direct = dir;
		}

		// Token: 0x0600018C RID: 396 RVA: 0x0002F5E4 File Offset: 0x0002D7E4
		private void frmContractEdit_Load(object sender, EventArgs e)
		{
			this.InitControl();
			this.LoadData();
		}

		// Token: 0x0600018D RID: 397 RVA: 0x0002F5F8 File Offset: 0x0002D7F8
		private void InitControl()
		{
			this.cmbPartyA.BindDataSouce(DalT_settlepart.Instance.GetAllList(), "Name", "PinYinMa", "Id");
			this.cmbPartyB.BindDataSouce(DalT_client.Instance.GetAllList(), "Name", "PinYinMa", "Id");
			this.cmbPlanType.BindDataSouce(BaseForm.GetEnumModelList<BusinessType>(), "Description", "Description", "Value");
			this.cmbProduct.BindDataSouce(DalT_product.Instance.GetListByState(1, 0), "InvName", "PinYinMa", "InvCode");
			this.cmbDanWei.BindDataSouce(BaseForm.GetEnumModelList<DanWei>(), "Description", "Name", "Value");
			this.cmbDanWei.SelectedIndex = 0;
			this.tInputLiableTime.Value = DateTime.Now;
		}

		// Token: 0x0600018E RID: 398 RVA: 0x0002F6D8 File Offset: 0x0002D8D8
		protected override void LoadData()
		{
			bool flag = BaseForm.FormActtion.Modify == this._Act;
			if (flag)
			{
				this._mod = DalT_contract.Instance.GetModel(this._CurrentId);
				bool flag2 = this._mod == null;
				if (flag2)
				{
					base.ShowMsg(Messages.ObjNonExist, "", "");
					base.Close();
				}
				else
				{
					this.txtContractNum.Text = this._mod.ContractNum;
					this.cmbPartyA.Text = this._mod.PartyA;
					this.cmbPartyB.Text = this._mod.PartyB;
					this.cmbPlanType.SelectedValue = this._mod.BusinessType;
					this.cmbProduct.SelectedValue = this._mod.InvCode;
					this.dInputPlanAmount.Value = (double)this._mod.PlanAmount;
					this.cmbDanWei.Text = this._mod.DanWei;
					this.tInputStartTime.Value = this._mod.StartTime;
					this.tInputEndTime.Value = this._mod.EndTime;
					this.txtLiablePerson.Text = this._mod.LiablePerson;
					this.tInputLiableTime.Value = this._mod.LiableTime;
					this.rtbRemark.Text = this._mod.Remark;
				}
			}
		}

		// Token: 0x0600018F RID: 399 RVA: 0x0002F860 File Offset: 0x0002DA60
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

		// Token: 0x06000190 RID: 400 RVA: 0x0002F8B0 File Offset: 0x0002DAB0
		private bool Add()
		{
			this._mod.ContractNum = this.txtContractNum.Text;
			this._mod.PartyA = this.cmbPartyA.Text;
			this._mod.PartyB = this.cmbPartyB.Text;
			this._mod.BusinessType = (int)this.cmbPlanType.SelectedValue;
			this._mod.ProductName = this.cmbProduct.Text;
			this._mod.InvCode = this.cmbProduct.SelectedValue.ToString();
			this._mod.PlanAmount = (decimal)this.dInputPlanAmount.Value;
			this._mod.DanWei = this.cmbDanWei.Text;
			this._mod.StartTime = this.tInputStartTime.Value;
			this._mod.EndTime = this.tInputEndTime.Value;
			this._mod.LiablePerson = this.txtLiablePerson.Text;
			this._mod.LiableTime = this.tInputLiableTime.Value;
			this._mod.Remark = this.rtbRemark.Text;
			bool flag = base.IsExist("t_contract", "ContractNum", this._mod.ContractNum, SqlDbType.NVarChar);
			bool result;
			if (flag)
			{
				base.ShowMsg(Messages.ContractHaved, "", "");
				this.txtContractNum.Focus();
				result = false;
			}
			else
			{
				int num = DalT_contract.Instance.Add(this._mod);
				bool flag2 = num <= 0;
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

		// Token: 0x06000191 RID: 401 RVA: 0x0002FAA4 File Offset: 0x0002DCA4
		private bool Modify()
		{
			ModT_contract oldValue = this._mod.Clone() as ModT_contract;
			this._mod.ContractNum = this.txtContractNum.Text;
			this._mod.PartyA = this.cmbPartyA.Text;
			this._mod.PartyB = this.cmbPartyB.Text;
			this._mod.BusinessType = (int)this.cmbPlanType.SelectedValue;
			this._mod.ProductName = this.cmbProduct.Text;
			this._mod.InvCode = this.cmbProduct.SelectedValue.ToString();
			this._mod.PlanAmount = (decimal)this.dInputPlanAmount.Value;
			this._mod.DanWei = this.cmbDanWei.Text;
			this._mod.StartTime = this.tInputStartTime.Value;
			this._mod.EndTime = this.tInputEndTime.Value;
			this._mod.LiablePerson = this.txtLiablePerson.Text;
			this._mod.LiableTime = this.tInputLiableTime.Value;
			this._mod.Remark = this.rtbRemark.Text;
			bool flag = base.IsExistOutSelf("t_contract", "ContractNum", this._mod.ContractNum, SqlDbType.NVarChar, this._CurrentId);
			bool result;
			if (flag)
			{
				base.ShowMsg(Messages.ContractHaved, "", "");
				this.txtContractNum.Focus();
				result = false;
			}
			else
			{
				bool flag2 = !DalT_contract.Instance.Update(this._mod);
				if (flag2)
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
			return result;
		}

		// Token: 0x06000192 RID: 402 RVA: 0x0002FCAC File Offset: 0x0002DEAC
		private bool TextCheck()
		{
			bool flag = string.IsNullOrWhiteSpace(this.txtContractNum.Text);
			bool result;
			if (flag)
			{
				base.ShowMsg(Messages.ContractNull, "", "");
				this.txtContractNum.Focus();
				result = false;
			}
			else
			{
				bool flag2 = string.IsNullOrWhiteSpace(this.cmbPartyA.Text);
				if (flag2)
				{
					base.ShowMsg(Messages.PartyANull, "", "");
					this.cmbPartyA.Focus();
					result = false;
				}
				else
				{
					bool flag3 = string.IsNullOrWhiteSpace(this.cmbPartyB.Text);
					if (flag3)
					{
						base.ShowMsg(Messages.PartyBNull, "", "");
						this.cmbPartyB.Focus();
						result = false;
					}
					else
					{
						bool flag4 = string.IsNullOrWhiteSpace(this.cmbPlanType.Text);
						if (flag4)
						{
							base.ShowMsg(Messages.BusinessTypeNull, "", "");
							this.cmbPlanType.Focus();
							result = false;
						}
						else
						{
							bool flag5 = string.IsNullOrWhiteSpace(this.cmbProduct.Text);
							if (flag5)
							{
								base.ShowMsg(Messages.ProductNull, "", "");
								this.cmbProduct.Focus();
								result = false;
							}
							else
							{
								bool flag6 = this.tInputStartTime.Value < DateTime.Parse("1753/1/1 00:00:00");
								if (flag6)
								{
									base.ShowMsg(Messages.StartTimeRight, "", "");
									this.tInputStartTime.Focus();
									result = false;
								}
								else
								{
									bool flag7 = this.tInputEndTime.Value < DateTime.Parse("1753/1/1 00:00:00");
									if (flag7)
									{
										base.ShowMsg(Messages.EndTimeRight, "", "");
										this.tInputEndTime.Focus();
										result = false;
									}
									else
									{
										result = true;
									}
								}
							}
						}
					}
				}
			}
			return result;
		}

		// Token: 0x06000193 RID: 403 RVA: 0x0002FE87 File Offset: 0x0002E087
		private void dInputPlanAmount_ValueChanged(object sender, EventArgs e)
		{
			base.ToolTipShow(this.dInputPlanAmount);
		}

		// Token: 0x06000194 RID: 404 RVA: 0x0002FE97 File Offset: 0x0002E097
		private void tInputStartTime_ValueChanged(object sender, EventArgs e)
		{
			this.tInputEndTime.MinDate = this.tInputStartTime.Value;
		}

		// Token: 0x06000195 RID: 405 RVA: 0x0002FEB1 File Offset: 0x0002E0B1
		private void tInputEndTime_ValueChanged(object sender, EventArgs e)
		{
			this.tInputStartTime.MaxDate = this.tInputEndTime.Value;
		}

		// Token: 0x040002CE RID: 718
		private ModT_contract _mod = new ModT_contract();
	}
}
