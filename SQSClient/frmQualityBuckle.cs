using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Base;
using DAL.Base.SQSConfig;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using DevComponents.DotNetBar.Layout;
using Model;
using Model.SQSConfig;
using SQSClient.Properties;

namespace SQSClient
{
	// Token: 0x02000011 RID: 17
	public partial class frmQualityBuckle : BaseDialogForm
	{
		// Token: 0x06000088 RID: 136 RVA: 0x0000E808 File Offset: 0x0000CA08
		public frmQualityBuckle(ModT_ticket selectMod)
		{
			this.InitializeComponent();
			this.SetText(this);
			this.mModTicket = DalT_ticket.Instance.GetModel(selectMod.Id);
			this._CurrentId = this.mModTicket.Id;
		}

		// Token: 0x06000089 RID: 137 RVA: 0x0000E898 File Offset: 0x0000CA98
		private void frmQualityBuckle_Load(object sender, EventArgs e)
		{
			this.txtDanHao.Text = this.mModTicket.DanHao;
			this.txtContractNum.Text = this.mModTicket.ContractNum;
			this.txtLisence.Text = this.mModTicket.Lisence;
			this.txtInvCode.Text = this.mModTicket.InvCode;
			this.txtProduct.Text = this.mModTicket.ProductName;
			this.txtOneWeighed.Text = this.mModTicket.FirstWeight.ToString("F2");
			this.txtTwoWeighed.Text = this.mModTicket.SecondWeight.ToString("F2");
			this.txtDifferWeight.Text = this.mModTicket.DifferWeight.ToString("F2");
			this.txtDeductWeight.Text = this.mModTicket.DeductWeight.ToString("F2");
			this.txtModifyOwner.Text = this.mModTicket.ClientPart;
			this.mImpurityDetails = this.mModTicket.ImpurityDetails;
			this.mDeductWeight = this.mModTicket.DeductWeight;
			bool flag = this.mModTicket.BdState == 0 && this.mModTicket.SecondWeight > 0m && this.mModTicket.DifferWeight > 0m;
			bool flag2 = this.mModTicket.BdState == 0 && this.mModTicket.FirstWeight == 0m;
			this.mIsEdit = (flag || flag2);
			bool flag3 = this.mIsEdit;
			if (flag3)
			{
				bool flag4 = !this.QualityBuckleValue(this.mModTicket.DifferWeight, this.mModTicket.Spare10, ref this.mDeductWeight, ref this.mImpurityDetails, ref this.mImpurityAmount);
				if (flag4)
				{
					this.rtxtImpurityDetails.Text = "Error";
					this.btnSure.Enabled = false;
					return;
				}
				this.rtxtImpurityDetails.Text = this.mImpurityDetails;
				this.txtImpurityAmount.Text = this.mImpurityAmount.ToString("F2");
			}
			else
			{
				this.rtxtImpurityDetails.Text = this.mModTicket.Remark;
				this.txtImpurityAmount.Text = this.mModTicket.ImpurityAmount.ToString("F2");
			}
			this.btnSure.Enabled = this.mIsEdit;
		}

		// Token: 0x0600008A RID: 138 RVA: 0x0000EB3C File Offset: 0x0000CD3C
		private bool QualityBuckleValue(decimal differWeight, string Spare10, ref decimal deductWeight, ref string impurityDetails, ref decimal impurityAmount)
		{
			bool flag = differWeight < 0.1m;
			if (flag)
			{
				deductWeight = 0m;
			}
			string[] array = Spare10.Split(new char[]
			{
				';'
			});
			List<decimal> list = new List<decimal>();
			bool flag2 = array.Length < 6;
			bool result;
			if (flag2)
			{
				result = false;
			}
			else
			{
				decimal num = 0m;
				for (int i = 0; i < array.Length; i++)
				{
					num = differWeight * Convert.ToDecimal(array[i]) / 100m;
					list.Add(num);
					impurityAmount += num;
				}
				impurityDetails = string.Format(impurityDetails, new object[]
				{
					list[0].ToString("F1") + "Kg",
					list[1].ToString("F1") + "Kg",
					list[2].ToString("F1") + "Kg",
					list[3].ToString("F1") + "Kg",
					list[4].ToString("F1") + "Kg",
					list[5].ToString("F1") + "Kg",
					deductWeight.ToString("F3") + "Kg"
				});
				result = true;
			}
			return result;
		}

		// Token: 0x0600008B RID: 139 RVA: 0x0000ECEC File Offset: 0x0000CEEC
		private void btnSure_Click(object sender, EventArgs e)
		{
			bool flag = !base.ShowChoise("QualityBuckleSure", "", "");
			if (!flag)
			{
				Dictionary<string, object> dic = new Dictionary<string, object>
				{
					{
						"BdState",
						1
					},
					{
						"ImpurityAmount",
						this.mImpurityAmount
					},
					{
						"Remark",
						this.mImpurityDetails
					},
					{
						"ImpurityPercent",
						1
					},
					{
						"DeductWeight",
						this.mDeductWeight
					}
				};
				bool flag2 = !DalT_ticket.Instance.Update(dic, this.mModTicket.Id);
				if (flag2)
				{
					base.ShowMsg(Messages.UpdateFalse, "", "");
				}
				else
				{
					base.DialogResult = DialogResult.Yes;
					base.Close();
				}
			}
		}

		// Token: 0x0600008C RID: 140 RVA: 0x0000EDCC File Offset: 0x0000CFCC
		private void btnPhotoAround_Click(object sender, EventArgs e)
		{
			frmPhotoAround frmPhotoAround = new frmPhotoAround(this.mModTicket.DanHao);
			frmPhotoAround.ShowDialog();
		}

		// Token: 0x0600008D RID: 141 RVA: 0x0000EDF2 File Offset: 0x0000CFF2
		private void rtxtImpurityDetails_DoubleClick(object sender, EventArgs e)
		{
			base.ShowToast(this, this.mModTicket.ImpurityDetails, "", "");
		}

		// Token: 0x0600008E RID: 142 RVA: 0x0000EE14 File Offset: 0x0000D014
		private void btnSettle_Click(object sender, EventArgs e)
		{
			bool flag = !this.SpecialDealWith();
			if (!flag)
			{
				BaseDialogForm baseDialogForm = base.CreateInstance<BaseDialogForm>(typeof(frmReviseAccount), ((ButtonItem)sender).Text, BaseForm.FormActtion.Modify, this._FrmName);
				baseDialogForm.Sender = sender;
				bool flag2 = baseDialogForm.ShowDialog() == DialogResult.Yes;
				if (flag2)
				{
					base.DialogResult = DialogResult.Yes;
					base.Close();
				}
			}
		}

		// Token: 0x0600008F RID: 143 RVA: 0x0000EE7C File Offset: 0x0000D07C
		private bool SpecialDealWith()
		{
			bool flag = this.mModTicket.InvCode.Equals(this.mCornInvCode) && this.mModTicket.BdState == 0;
			bool result;
			if (flag)
			{
				base.ShowMsg("CornCheckMsg", "", "");
				result = false;
			}
			else
			{
				result = true;
			}
			return result;
		}

		// Token: 0x06000090 RID: 144 RVA: 0x0000EED8 File Offset: 0x0000D0D8
		private void btnStatusFinish_Click(object sender, EventArgs e)
		{
			bool flag = !base.ShowChoise("StatusFinishSure", "", "");
			if (!flag)
			{
				Dictionary<string, object> dic = new Dictionary<string, object>
				{
					{
						"Status",
						2
					},
					{
						"BdState",
						1
					}
				};
				bool flag2 = !DalT_ticket.Instance.Update(dic, this.mModTicket.Id);
				if (flag2)
				{
					base.ShowMsg(Messages.UpdateFalse, "", "");
				}
				else
				{
					base.DialogResult = DialogResult.Yes;
					base.Close();
				}
			}
		}

		// Token: 0x06000091 RID: 145 RVA: 0x0000EF74 File Offset: 0x0000D174
		private void btnModifyOwner_Click(object sender, EventArgs e)
		{
			frmPasswordSure frmPasswordSure = new frmPasswordSure(this.Text);
			bool flag = frmPasswordSure.ShowDialog() == DialogResult.No;
			if (flag)
			{
				base.ShowToast(this, "PasswordCheckFailed", "", "");
			}
			else
			{
				string value = this.txtModifyOwner.Text.Trim();
				Dictionary<string, object> dic = new Dictionary<string, object>
				{
					{
						"ClientPart",
						value
					}
				};
				bool flag2 = !DalT_ticket.Instance.Update(dic, this.mModTicket.Id);
				if (flag2)
				{
					base.ShowMsg(Messages.UpdateFalse, "", "");
				}
				else
				{
					base.DialogResult = DialogResult.Yes;
					base.Close();
				}
			}
		}

		// Token: 0x040000E8 RID: 232
		private ModT_ticket mModTicket = null;

		// Token: 0x040000E9 RID: 233
		private decimal mImpurityAmount = 0m;

		// Token: 0x040000EA RID: 234
		private decimal mDeductWeight = 0m;

		// Token: 0x040000EB RID: 235
		private string mImpurityDetails = string.Empty;

		// Token: 0x040000EC RID: 236
		private bool mIsEdit = true;

		// Token: 0x040000ED RID: 237
		private string mCornInvCode = "0407019002";
	}
}
