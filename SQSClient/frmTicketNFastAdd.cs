using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
using ICHandle;
using Model;
using Model.SQSConfig;
using SQSClient.Properties;

namespace SQSClient
{
	// Token: 0x0200006C RID: 108
	public partial class frmTicketNFastAdd : BaseDialogForm
	{
		// Token: 0x06000572 RID: 1394 RVA: 0x00089FF4 File Offset: 0x000881F4
		public frmTicketNFastAdd(string text, BaseForm.FormActtion act, int id, string dir)
		{
			this.InitializeComponent();
			this.SetText(this);
			this.Text = text;
			this._Act = act;
			this._CurrentId = id;
			this._Direct = dir;
		}

		// Token: 0x06000573 RID: 1395 RVA: 0x0008A053 File Offset: 0x00088253
		private void frmTicketNFastAdd_Load(object sender, EventArgs e)
		{
			this.InitControl();
			this.LoadData();
		}

		// Token: 0x06000574 RID: 1396 RVA: 0x0008A064 File Offset: 0x00088264
		private void InitControl()
		{
			this.cmbBusinessType.BindDataSouce(BaseForm.GetEnumModelList<BusinessType>(), "Description", "Description", "Value");
			this.cmbAccountType.BindDataSouce(BaseForm.GetEnumModelList<AccountType>(), "Description", "Description", "Value");
			this.cmbClientpart.BindDataSouce(DalT_client.Instance.GetAllList(), "Name", "PinYinMa", "Id");
			this.cmbSettlepart.BindDataSouce(DalT_settlepart.Instance.GetAllList(), "Name", "PinYinMa", "Id");
			this.cmbCreditType.BindDataSouce(BaseForm.GetEnumModelList<TruckCreditType>(), "Description", "Description", "Value");
			this.cmbCreditType.SelectedIndex = 0;
			this.cmbProduct.BindDataSouce(DalT_product.Instance.GetListByState(1, 0), "InvName", "PinYinMa", "InvCode");
			try
			{
				this.cmbAccountType.SelectedValue = int.Parse(DalCfg_setting.Instance.GetModel("Item", "DefaultAccountType").Value);
			}
			catch
			{
				this.cmbAccountType.SelectedValue = "1";
			}
			this.cmbBusinessType.SelectedValue = 2;
			this.cmbProduct.SelectedValue = this.mDefInvCode;
			this.cmbSettlepart.SelectedIndex = 0;
			this.dInputJiHuaLiang.Value = 0.0;
		}

		// Token: 0x06000575 RID: 1397 RVA: 0x0008A1F0 File Offset: 0x000883F0
		protected override void LoadData()
		{
			this.tInputValidDate.Value = DateTime.Now;
			bool flag = BaseForm.FormActtion.Modify == this._Act;
			if (flag)
			{
				this._mod = DalT_ticket.Instance.GetModel(this._CurrentId);
				bool flag2 = this._mod == null;
				if (flag2)
				{
					base.ShowMsg(Messages.ObjNonExist, "", "");
					base.Close();
				}
				else
				{
					ModT_truck model = DalT_truck.Instance.GetModel("Lisence", this._mod.Lisence);
					bool flag3 = model != null;
					if (flag3)
					{
						this.txtLisence.Text = model.Lisence;
						this.txtLTransportCode.Text = model.LTransportCode;
						this.tInputValidDate.Value = model.ValidDate;
						this.cmbCreditType.SelectedValue = model.CreditType;
						this.rtbRemark.Text = model.Remark;
					}
					this.txtContractNum.Text = this._mod.ContractNum;
					this.cmbBusinessType.Text = this._mod.BusinessType.ToString();
					this.cmbClientpart.Text = this._mod.ClientPart;
					this.cmbSettlepart.Text = this._mod.SettlePart;
					this.txtCardNum.Text = this._mod.CardNum;
					this.cmbAccountType.Text = this._mod.AccountType.ToString();
					this.cmbProduct.Text = this._mod.ProductName;
					this.dInputJiHuaLiang.Value = Convert.ToDouble(this._mod.JiHuaLiang);
				}
			}
			else
			{
				DateTime now = DateTime.Now;
				int maxIndex = DanHaoHelper.Instance().GetMaxIndex("LOC_", now);
				this.txtContractNum.Text = "LOC_" + now.ToString("yyyyMMdd") + (maxIndex + 1).ToString().PadLeft(4, '0');
			}
		}

		// Token: 0x06000576 RID: 1398 RVA: 0x0008A414 File Offset: 0x00088614
		private void btnSave_Click(object sender, EventArgs e)
		{
			bool flag = !this.TextCheck();
			if (!flag)
			{
				bool flag2 = false;
				bool flag3 = this._Act == BaseForm.FormActtion.Add;
				if (flag3)
				{
					flag2 = this.Add();
				}
				bool flag4 = flag2;
				if (flag4)
				{
					base.DialogResult = DialogResult.Yes;
				}
			}
		}

		// Token: 0x06000577 RID: 1399 RVA: 0x0008A45C File Offset: 0x0008865C
		private bool Add()
		{
			this._mod.Lisence = this.txtLisence.Text.Trim();
			this._mod.ContractNum = this.txtContractNum.Text.Trim();
			this._mod.BusinessType = (int)this.cmbBusinessType.SelectedValue;
			bool flag = this._mod.BusinessType == 1;
			if (flag)
			{
				this._mod.IsLab = (DalCfg_setting.Instance.GetModel("Item", "LoadLabDefaultEnable").Value == "1");
			}
			else
			{
				this._mod.IsLab = (DalCfg_setting.Instance.GetModel("Item", "UnloadLabDefaultEnable").Value == "1");
			}
			this._mod.CardNum = this.txtCardNum.Text;
			this._mod.AccountType = (int)this.cmbAccountType.SelectedValue;
			this._mod.ProductName = this.cmbProduct.Text;
			ModT_ticket mod = this._mod;
			object selectedValue = this.cmbProduct.SelectedValue;
			mod.InvCode = ((selectedValue != null) ? selectedValue.ToString() : null);
			ModT_product modelByInvCode = DalT_product.Instance.GetModelByInvCode(this._mod.InvCode);
			bool flag2 = modelByInvCode != null;
			if (flag2)
			{
				this._mod.ProductCode = modelByInvCode.Code;
			}
			this._mod.JiHuaLiang = Convert.ToDecimal(this.dInputJiHuaLiang.Value);
			string empty = string.Empty;
			bool flag3 = !DalT_ticket.Instance.CreateDanHao(ref empty);
			bool result;
			if (flag3)
			{
				base.ShowToast(this, Messages.DanHaoCreatFalse, "", "");
				result = false;
			}
			else
			{
				this._mod.TruckSafeName = (this.rdoCornCart.Checked ? ShowWords.ReplaceText("CornCart") : ShowWords.ReplaceText("CornTrolley"));
				object maxValue = DalT_ticket.Instance.GetMaxValue("BatchNum");
				this._mod.BatchNum = ((maxValue == null) ? 0 : ((int)maxValue)) + 1;
				this._mod.DanHao = empty;
				this._mod.DanWei = "kg";
				this._mod.ShiJiLiang = 0m;
				this._mod.XianQianLiang = 0m;
				this._mod.StartTime = DateTime.Now;
				this._mod.EndTime = DateTime.Now;
				this._mod.ValiFirstTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
				this._mod.ValiSecondTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
				this._mod.ZhiDanRen = GlobalKey.UserName;
				this._mod.ZhiDanTime = DateTime.Now;
				this._mod.JieSuanTime = DateTime.Now;
				this._mod.Status = 0;
				this._mod.State = 0;
				this._mod.BdState = 0;
				this._mod.OperateState = 1;
				this._mod.IsQueue = false;
				this._mod.IsDelete = false;
				this._mod.DataReturn = 0;
				this._mod.CardNum = this.txtCardNum.Text.Trim();
				this._mod.TicketType = 1;
				this._mod.CangNum = 1;
				int num = DalT_ticket.Instance.Add(this._mod);
				bool flag4 = num == 0;
				if (flag4)
				{
					this.OnOperateFail(this._mod, false);
					base.ShowToast(this, Messages.AddFalse, "", "");
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

		// Token: 0x06000578 RID: 1400 RVA: 0x0008A854 File Offset: 0x00088A54
		private bool TextCheck()
		{
			bool flag = string.IsNullOrWhiteSpace(this.txtLisence.Text.Trim());
			bool result;
			if (flag)
			{
				base.ShowMsg(Messages.TruckNull, "", "");
				result = false;
			}
			else
			{
				bool flag2 = !LisenceHelper.LisenceCheck(this.txtLisence.Text.Trim());
				if (flag2)
				{
					base.ShowMsg(Messages.TruckError, "", "");
					result = false;
				}
				else
				{
					bool flag3 = string.IsNullOrWhiteSpace(this.cmbProduct.Text);
					if (flag3)
					{
						base.ShowMsg(Messages.ProductNull, "", "");
						this.cmbProduct.Focus();
						result = false;
					}
					else
					{
						bool flag4 = string.IsNullOrWhiteSpace(this.cmbClientpart.Text.Trim());
						if (flag4)
						{
							base.ShowToast(this, Messages.ClientpartNull, "", "");
							this.cmbClientpart.Focus();
							result = false;
						}
						else
						{
							bool flag5 = string.IsNullOrWhiteSpace(this.cmbSettlepart.Text.Trim());
							if (flag5)
							{
								base.ShowToast(this, Messages.SettlepartNull, "", "");
								this.cmbSettlepart.Focus();
								result = false;
							}
							else
							{
								bool flag6 = true;
								bool flag7 = this.txtContractNum.Text.Trim().Length > 0 && !flag6;
								if (flag7)
								{
									base.ShowToast(this, Messages.ContractHavent, "", "");
									this.txtContractNum.Focus();
									result = false;
								}
								else
								{
									bool flag8 = DalT_truck.Instance.IsExist("Lisence", this.txtLisence.Text.Trim(), SqlDbType.NVarChar, ref flag6) && !flag6;
									if (flag8)
									{
										bool flag9 = this.txtLisence.Text.Trim() != "";
										if (flag9)
										{
											ModT_truck modT_truck = new ModT_truck();
											modT_truck.Lisence = this.txtLisence.Text.Trim();
											modT_truck.LTransportCode = this.txtLTransportCode.Text.Trim();
											modT_truck.ValidDate = this.tInputValidDate.Value;
											modT_truck.CreditType = (int)this.cmbCreditType.SelectedValue;
											modT_truck.Remark = this.rtbRemark.Text.Trim();
											modT_truck.CangShu = 1;
											modT_truck.PinYinMa = modT_truck.Lisence.GetFirstPinyin();
											DalT_truck.Instance.AddNoReturn(modT_truck);
										}
									}
									bool flag10 = DalT_client.Instance.IsExist("Name", this.cmbClientpart.Text.Trim(), SqlDbType.NVarChar, ref flag6) && !flag6;
									if (flag10)
									{
										bool flag11 = this.cmbClientpart.Text.Trim() != "";
										if (flag11)
										{
											ModT_client modT_client = new ModT_client();
											modT_client.Name = this.cmbClientpart.Text.Trim();
											modT_client.PinYinMa = modT_client.Name.GetFirstPinyin();
											DalT_client.Instance.AddNoReturn(modT_client);
											this._mod.ClientPart = modT_client.Name;
										}
									}
									else
									{
										this._mod.ClientPart = this.cmbClientpart.Text.Trim();
									}
									bool flag12 = DalT_settlepart.Instance.IsExist("Name", this.cmbSettlepart.Text.Trim(), SqlDbType.NVarChar, ref flag6) && !flag6;
									if (flag12)
									{
										bool flag13 = this.cmbSettlepart.Text.Trim() != "";
										if (flag13)
										{
											ModT_settlepart modT_settlepart = new ModT_settlepart();
											modT_settlepart.Name = this.cmbSettlepart.Text.Trim();
											modT_settlepart.PinYinMa = modT_settlepart.Name.GetFirstPinyin();
											DalT_settlepart.Instance.AddNoReturn(modT_settlepart);
											this._mod.SettlePart = modT_settlepart.Name;
										}
									}
									else
									{
										this._mod.SettlePart = this.cmbSettlepart.Text.Trim();
									}
									bool flag14 = this.txtCardNum.Text.Trim().Length > 0 && (this.txtCardNum.Text.Trim().Length != 8 || !RegexHelper.IsNumAndEnCh1(this.txtCardNum.Text.Trim()));
									if (flag14)
									{
										base.ShowToast(this, Messages.ICFormat, "", "");
										this.txtCardNum.Focus();
										result = false;
									}
									else
									{
										bool flag15 = this.txtCardNum.Text.Trim().Length > 0;
										if (flag15)
										{
											ModT_iccard model = DalT_iccard.Instance.GetModel("CardNum", this.txtCardNum.Text.Trim());
											bool flag16 = model == null;
											if (flag16)
											{
												base.ShowToast(this, Messages.ICUnauthorized, "", "");
												this.txtCardNum.Focus();
												return false;
											}
											bool flag17 = !model.State;
											if (flag17)
											{
												base.ShowToast(this, Messages.ICDisenabled, "", "");
												this.txtCardNum.Focus();
												return false;
											}
											List<string> list = new List<string>();
											list.Add("CardNum = '" + this.txtCardNum.Text.Trim() + "'");
											bool flag18 = bool.Parse(DalCfg_setting.Instance.GetModel("Item", "ICPaidReuse").Value);
											if (flag18)
											{
												list.Add("State < '" + 1.ToString() + "'");
											}
											else
											{
												list.Add("Status < '" + 2.ToString() + "'");
											}
											List<ModT_ticket> list2 = DalT_ticket.Instance.GetListRequire(list, null, null);
											bool flag19 = this._Act == BaseForm.FormActtion.Modify;
											if (flag19)
											{
												list2 = list2.FindAll((ModT_ticket t) => t.BatchNum != this._mod.BatchNum);
											}
											bool flag20 = list2.Count > 0;
											if (flag20)
											{
												base.ShowToast(this, Messages.ICUsed, "", "");
												this.txtCardNum.Focus();
												return false;
											}
											this._mod.IsCard = true;
											this._mod.TakeCardTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
										}
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

		// Token: 0x06000579 RID: 1401 RVA: 0x0008AEF0 File Offset: 0x000890F0
		private void dInputJiHuaLiang_ValueChanged(object sender, EventArgs e)
		{
			base.ToolTipShow(this.dInputJiHuaLiang);
		}

		// Token: 0x0600057A RID: 1402 RVA: 0x0008AF00 File Offset: 0x00089100
		private void btnCard_Click(object sender, EventArgs e)
		{
			try
			{
				this.txtCardNum.Text = ICTicket.ReadCardNum();
			}
			catch
			{
				base.ShowToast(this, Messages.ReadCardFalse, "", "");
			}
		}

		// Token: 0x04000986 RID: 2438
		private readonly string mDefInvCode = "0407019002";

		// Token: 0x04000987 RID: 2439
		private ModT_ticket _mod = new ModT_ticket();
	}
}
