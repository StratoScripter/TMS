using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using AutocompleteMenuNS;
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
	// Token: 0x02000092 RID: 146
	public partial class frmTruckEdit : BaseDialogForm
	{
		// Token: 0x06000800 RID: 2048 RVA: 0x000C7614 File Offset: 0x000C5814
		public frmTruckEdit(string text, BaseForm.FormActtion act, int id, string dir)
		{
			this.InitializeComponent();
			this.SetText(this);
			this.Text = text;
			this._Act = act;
			this._CurrentId = id;
			this._Direct = dir;
		}

		// Token: 0x06000801 RID: 2049 RVA: 0x000C7668 File Offset: 0x000C5868
		private void frmTruckEdit_Load(object sender, EventArgs e)
		{
			this.InitControl();
			this.LoadData();
		}

		// Token: 0x06000802 RID: 2050 RVA: 0x000C767C File Offset: 0x000C587C
		private void InitControl()
		{
			this.cmbType.BindDataSouce(DalT_trucktype.Instance.GetAllList(), "Name", "PinYinMa", "Name");
			this.cmbProduct.BindDataSouce(DalT_product.Instance.GetListByState(1, 0), "InvName", "PinYinMa", "InvCode");
			this.cmbSpecialStepType.BindDataSouce(DalSrm_specialstepclass.Instance.GetListRequire("StepCode is null and LastStepCode is null", null, null), "ClassName", "ClassName", "Id");
			this.cmbCreditType.BindDataSouce(BaseForm.GetEnumModelList<TruckCreditType>(), "Description", "Description", "Value");
			this.cmbCreditType.SelectedIndex = 0;
			this.BindAutocompleteMenu1();
			this.BindAutocompleteMenu2();
			this.BindAutocompleteMenu3();
			this.BindAutocompleteMenu4();
			this.BindAutocompleteMenu5();
		}

		// Token: 0x06000803 RID: 2051 RVA: 0x000C7754 File Offset: 0x000C5954
		private void BindAutocompleteMenu1()
		{
			List<AutocompleteItem> list = new List<AutocompleteItem>();
			List<string> list2 = new List<string>();
			list2.Add("Role='1'");
			list2.Add("Enable='true'");
			List<ModT_truckman> listRequire = DalT_truckman.Instance.GetListRequire(list2, null, null);
			foreach (ModT_truckman modT_truckman in listRequire)
			{
				list.Add(new MulticolumnAutocompleteItem(new string[]
				{
					modT_truckman.Name,
					modT_truckman.IDCard
				}, modT_truckman.IDCard, true, true));
			}
			base.BindAutocompleteMenu(this.txtDriverID, list);
		}

		// Token: 0x06000804 RID: 2052 RVA: 0x000C7810 File Offset: 0x000C5A10
		private void BindAutocompleteMenu2()
		{
			List<AutocompleteItem> list = new List<AutocompleteItem>();
			List<string> list2 = new List<string>();
			list2.Add("Role='2'");
			list2.Add("Enable='true'");
			List<ModT_truckman> listRequire = DalT_truckman.Instance.GetListRequire(list2, null, null);
			foreach (ModT_truckman modT_truckman in listRequire)
			{
				list.Add(new MulticolumnAutocompleteItem(new string[]
				{
					modT_truckman.Name,
					modT_truckman.IDCard
				}, modT_truckman.IDCard, true, true));
			}
			base.BindAutocompleteMenu(this.txtSupercargoID, list);
		}

		// Token: 0x06000805 RID: 2053 RVA: 0x000C78CC File Offset: 0x000C5ACC
		private void BindAutocompleteMenu3()
		{
			List<AutocompleteItem> list = new List<AutocompleteItem>();
			List<ModT_client> allList = DalT_client.Instance.GetAllList();
			foreach (ModT_client modT_client in allList)
			{
				list.Add(new SubstringAutocompleteItem(modT_client.Name, false));
			}
			List<ModT_settlepart> allList2 = DalT_settlepart.Instance.GetAllList();
			foreach (ModT_settlepart modT_settlepart in allList2)
			{
				list.Add(new SubstringAutocompleteItem(modT_settlepart.Name, false));
			}
			base.BindAutocompleteMenu(this.txtSubUnit, list);
		}

		// Token: 0x06000806 RID: 2054 RVA: 0x000C79A8 File Offset: 0x000C5BA8
		private void BindAutocompleteMenu4()
		{
			List<AutocompleteItem> list = new List<AutocompleteItem>();
			List<ModT_truck> allList = DalT_truck.Instance.GetAllList();
			foreach (ModT_truck modT_truck in allList)
			{
				list.Add(new SubstringAutocompleteItem(modT_truck.Lisence, false));
			}
			base.BindAutocompleteMenu(this.txtLisence, list);
		}

		// Token: 0x06000807 RID: 2055 RVA: 0x000C7A28 File Offset: 0x000C5C28
		private void BindAutocompleteMenu5()
		{
			List<AutocompleteItem> list = new List<AutocompleteItem>();
			List<ModT_truckcoach> allList = DalT_truckcoach.Instance.GetAllList();
			foreach (ModT_truckcoach modT_truckcoach in allList)
			{
				list.Add(new SubstringAutocompleteItem(modT_truckcoach.CoachNum, false));
			}
			base.BindAutocompleteMenu(this.txtCoachNum, list);
		}

		// Token: 0x06000808 RID: 2056 RVA: 0x000C7AA8 File Offset: 0x000C5CA8
		protected override void LoadData()
		{
			this.tInputValidDate.Value = DateTime.Now;
			bool flag = BaseForm.FormActtion.Modify == this._Act;
			if (flag)
			{
				this._mod = DalT_truck.Instance.GetModel(this._CurrentId);
				bool flag2 = this._mod == null;
				if (flag2)
				{
					base.ShowMsg(Messages.ObjNonExist, "", "");
					base.Close();
				}
				else
				{
					this.txtLTransportCode.Text = this._mod.LTransportCode;
					this.txtCoachNum.Text = this._mod.CoachNum;
					this.txtCTransportCode.Text = this._mod.CTransportCode;
					this.cmbType.SelectedValue = this._mod.TypeName;
					this.cmbProduct.SelectedValue = this._mod.InvCode;
					this.dInputVol.Value = (double)this._mod.Vol;
					this.dInputNetWeight.Value = (double)this._mod.NetWeight;
					this.iInputCangShu.Value = this._mod.CangShu;
					this.tInputValidDate.Value = this._mod.ValidDate;
					this.txtLisence.Text = this._mod.Lisence;
					bool flag3 = this.txtLisence.Text.Length > 0;
					if (flag3)
					{
						this.txtLisence.Enabled = false;
					}
					this.dInputWeight.Value = (double)this._mod.Weight;
					this.dInputLoadWeight.Value = (double)this._mod.LoadWeight;
					this.txtDriverID.Text = this._mod.DriverID;
					this.txtSupercargoID.Text = this._mod.SupercargoID;
					this.txtSubUnit.Text = this._mod.SubUnit;
					this.rtbRemark.Text = this._mod.Remark;
					this.cmbCreditType.SelectedValue = this._mod.CreditType;
					this.cmbSpecialStepType.Text = this._mod.SpecialStepType;
				}
			}
		}

		// Token: 0x06000809 RID: 2057 RVA: 0x000C7D04 File Offset: 0x000C5F04
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

		// Token: 0x0600080A RID: 2058 RVA: 0x000C7D54 File Offset: 0x000C5F54
		private bool Add()
		{
			this._mod.Lisence = this.txtLisence.Text;
			this._mod.LTransportCode = this.txtLTransportCode.Text;
			this._mod.DriverID = this.txtDriverID.Text;
			this._mod.SupercargoID = this.txtSupercargoID.Text;
			this._mod.CoachNum = this.txtCoachNum.Text;
			this._mod.CTransportCode = this.txtCTransportCode.Text;
			this._mod.TypeName = this.cmbType.Text;
			this._mod.ProductName = this.cmbProduct.Text;
			ModT_truck mod = this._mod;
			object selectedValue = this.cmbProduct.SelectedValue;
			mod.InvCode = ((selectedValue != null) ? selectedValue.ToString() : null);
			this._mod.Vol = (decimal)this.dInputVol.Value;
			this._mod.NetWeight = (decimal)this.dInputNetWeight.Value;
			this._mod.CangShu = this.iInputCangShu.Value;
			this._mod.ValidDate = this.tInputValidDate.Value.Date;
			this._mod.Weight = (decimal)this.dInputWeight.Value;
			this._mod.LoadWeight = (decimal)this.dInputLoadWeight.Value;
			this._mod.SubUnit = this.txtSubUnit.Text.Trim();
			this._mod.Remark = this.rtbRemark.Text;
			this._mod.PinYinMa = this._mod.Lisence.GetFirstPinyin();
			this._mod.CreditType = (int)this.cmbCreditType.SelectedValue;
			this._mod.SpecialStepType = this.cmbSpecialStepType.Text;
			bool flag = base.IsExist("t_truck", "Lisence", this._mod.Lisence, SqlDbType.NVarChar);
			bool result;
			if (flag)
			{
				base.ShowMsg(Messages.TruckHaved, "", "");
				this.txtLisence.Focus();
				result = false;
			}
			else
			{
				int num = DalT_truck.Instance.Add(this._mod);
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

		// Token: 0x0600080B RID: 2059 RVA: 0x000C8014 File Offset: 0x000C6214
		private bool Modify()
		{
			ModT_truck oldValue = this._mod.Clone() as ModT_truck;
			this._mod.Lisence = this.txtLisence.Text;
			this._mod.LTransportCode = this.txtLTransportCode.Text;
			this._mod.DriverID = this.txtDriverID.Text;
			this._mod.SupercargoID = this.txtSupercargoID.Text;
			this._mod.CoachNum = this.txtCoachNum.Text;
			this._mod.CTransportCode = this.txtCTransportCode.Text;
			this._mod.TypeName = this.cmbType.Text;
			this._mod.ProductName = this.cmbProduct.Text;
			ModT_truck mod = this._mod;
			object selectedValue = this.cmbProduct.SelectedValue;
			mod.InvCode = ((selectedValue != null) ? selectedValue.ToString() : null);
			this._mod.Vol = Convert.ToDecimal(string.Format("{0:F2}", this.dInputVol.Value));
			this._mod.NetWeight = Convert.ToDecimal(string.Format("{0:F2}", this.dInputNetWeight.Value));
			this._mod.CangShu = this.iInputCangShu.Value;
			this._mod.ValidDate = this.tInputValidDate.Value.Date;
			this._mod.Weight = Convert.ToDecimal(string.Format("{0:F2}", this.dInputWeight.Value));
			this._mod.LoadWeight = Convert.ToDecimal(string.Format("{0:F2}", this.dInputLoadWeight.Value));
			this._mod.SubUnit = this.txtSubUnit.Text.Trim();
			this._mod.Remark = this.rtbRemark.Text;
			this._mod.PinYinMa = this._mod.Lisence.GetFirstPinyin();
			this._mod.CreditType = (int)this.cmbCreditType.SelectedValue;
			this._mod.SpecialStepType = this.cmbSpecialStepType.Text;
			bool flag = base.IsExistOutSelf("t_truck", "Lisence", this._mod.Lisence, SqlDbType.NVarChar, this._CurrentId);
			bool result;
			if (flag)
			{
				base.ShowMsg(Messages.TruckHaved, "", "");
				this.txtLisence.Focus();
				result = false;
			}
			else
			{
				bool flag2 = !DalT_truck.Instance.Update(this._mod);
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

		// Token: 0x0600080C RID: 2060 RVA: 0x000C8320 File Offset: 0x000C6520
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
				bool flag2 = this.txtCoachNum.Text.Trim() != "";
				if (flag2)
				{
					ModT_truckcoach modT_truckcoach = DalT_truckcoach.Instance.GetModel("CoachNum", this.txtCoachNum.Text.Trim());
					bool flag3 = modT_truckcoach == null;
					if (flag3)
					{
						bool flag4 = base.ShowChoise(Messages.CoachSaveSure, "", "");
						if (!flag4)
						{
							return false;
						}
						modT_truckcoach = new ModT_truckcoach();
						modT_truckcoach.CoachNum = this.txtCoachNum.Text.Trim();
						modT_truckcoach.PinYinMa = modT_truckcoach.CoachNum.GetFirstPinyin();
						modT_truckcoach.CTransportCode = this.txtCTransportCode.Text;
						modT_truckcoach.TypeName = this.cmbType.Text;
						modT_truckcoach.ProductName = this.cmbProduct.Text;
						ModT_truckcoach modT_truckcoach2 = modT_truckcoach;
						object selectedValue = this.cmbProduct.SelectedValue;
						modT_truckcoach2.InvCode = ((selectedValue != null) ? selectedValue.ToString() : null);
						modT_truckcoach.Vol = (decimal)this.dInputVol.Value;
						modT_truckcoach.NetWeight = (decimal)this.dInputNetWeight.Value;
						modT_truckcoach.CangShu = this.iInputCangShu.Value;
						modT_truckcoach.ValidDate = this.tInputValidDate.Value.Date;
						modT_truckcoach.IsBound = true;
						DalT_truckcoach.Instance.AddNoReturn(modT_truckcoach);
					}
					else
					{
						bool flag5 = base.ShowChoise(Messages.CoachUpdateSure, "", "");
						if (!flag5)
						{
							return false;
						}
						modT_truckcoach.CTransportCode = this.txtCTransportCode.Text;
						modT_truckcoach.TypeName = this.cmbType.Text;
						modT_truckcoach.ProductName = this.cmbProduct.Text;
						ModT_truckcoach modT_truckcoach3 = modT_truckcoach;
						object selectedValue2 = this.cmbProduct.SelectedValue;
						modT_truckcoach3.InvCode = ((selectedValue2 != null) ? selectedValue2.ToString() : null);
						modT_truckcoach.Vol = (decimal)this.dInputVol.Value;
						modT_truckcoach.NetWeight = (decimal)this.dInputNetWeight.Value;
						modT_truckcoach.CangShu = this.iInputCangShu.Value;
						modT_truckcoach.ValidDate = this.tInputValidDate.Value.Date;
						modT_truckcoach.IsBound = true;
						DalT_truckcoach.Instance.Update(modT_truckcoach);
					}
				}
				result = true;
			}
			return result;
		}

		// Token: 0x0600080D RID: 2061 RVA: 0x000C85CC File Offset: 0x000C67CC
		private void btnAddType_Click(object sender, EventArgs e)
		{
			BaseDialogForm baseDialogForm = base.CreateInstance<BaseDialogForm>(typeof(frmTruckTypeEdit), ((ButtonItem)sender).Text, BaseForm.FormActtion.Add, this._Direct);
			bool flag = baseDialogForm.ShowDialog() == DialogResult.Yes;
			if (flag)
			{
				List<ModT_trucktype> allList = DalT_trucktype.Instance.GetAllList();
				this.cmbType.BindDataSouce(allList, "Name", "PinYinMa", "Id");
			}
		}

		// Token: 0x0600080E RID: 2062 RVA: 0x000C8634 File Offset: 0x000C6834
		private void btnAddPeople_Click(object sender, EventArgs e)
		{
			BaseDialogForm baseDialogForm = base.CreateInstance<BaseDialogForm>(typeof(frmCheckIn), ((ButtonItem)sender).Text, BaseForm.FormActtion.Add, this._Direct);
			bool flag = baseDialogForm.ShowDialog() == DialogResult.Yes;
			if (flag)
			{
				this.BindAutocompleteMenu1();
				this.BindAutocompleteMenu2();
			}
		}

		// Token: 0x0600080F RID: 2063 RVA: 0x000C8684 File Offset: 0x000C6884
		private void cmbType_TextChanged(object sender, EventArgs e)
		{
			ModT_trucktype model = DalT_trucktype.Instance.GetModel("Name", this.cmbType.Text);
			bool flag = model != null;
			if (flag)
			{
				this.cmbProduct.Enabled = false;
				this.dInputVol.Enabled = false;
				this.dInputNetWeight.Enabled = false;
				this.cmbProduct.SelectedValue = model.InvCode;
				this.dInputVol.Value = (double)model.Vol;
				this.dInputFactor.Value = (double)model.Factor;
				this.dInputNetWeight.Value = (double)model.NetWeight;
			}
		}

		// Token: 0x06000810 RID: 2064 RVA: 0x000C873C File Offset: 0x000C693C
		private void txtDriverID_TextChanged(object sender, EventArgs e)
		{
			ModT_truckman model = DalT_truckman.Instance.GetModel("IDCard", this.txtDriverID.Text);
			bool flag = model != null;
			if (flag)
			{
				this.txtDName.Text = model.Name;
				this.chkDEnable.Checked = model.Enable;
				this.txtDSex.Text = model.Sex;
				this.dInputDWeight.Value = (double)model.Weight;
				this.txtDIDCard.Text = model.IDCard;
				this.txtDPhoneNum.Text = model.PhoneNum;
				this.txtDAddress.Text = model.Address;
				try
				{
					MemoryStream memoryStream = new MemoryStream();
					for (int i = 0; i < model.Photo.Length; i++)
					{
						memoryStream.WriteByte(model.Photo[i]);
					}
					this.rImageDPhoto.Image = Image.FromStream(memoryStream);
				}
				catch
				{
				}
			}
		}

		// Token: 0x06000811 RID: 2065 RVA: 0x000C8854 File Offset: 0x000C6A54
		private void txtSupercargoID_TextChanged(object sender, EventArgs e)
		{
			ModT_truckman model = DalT_truckman.Instance.GetModel("IDCard", this.txtSupercargoID.Text);
			bool flag = model != null;
			if (flag)
			{
				this.txtSName.Text = model.Name;
				this.chkSEnable.Checked = model.Enable;
				this.txtSSex.Text = model.Sex;
				this.dInputSWeight.Value = (double)model.Weight;
				this.txtSIDCard.Text = model.IDCard;
				this.txtSPhoneNum.Text = model.PhoneNum;
				this.txtSAddress.Text = model.Address;
				try
				{
					MemoryStream memoryStream = new MemoryStream();
					for (int i = 0; i < model.Photo.Length; i++)
					{
						memoryStream.WriteByte(model.Photo[i]);
					}
					this.rImageSPhoto.Image = Image.FromStream(memoryStream);
				}
				catch
				{
				}
			}
		}

		// Token: 0x06000812 RID: 2066 RVA: 0x000C896C File Offset: 0x000C6B6C
		private void dInputWeight_ValueChanged(object sender, EventArgs e)
		{
			base.ToolTipShow(this.dInputWeight);
		}

		// Token: 0x06000813 RID: 2067 RVA: 0x000C897C File Offset: 0x000C6B7C
		private void dInputNetWeight_ValueChanged(object sender, EventArgs e)
		{
			base.ToolTipShow(this.dInputNetWeight);
		}

		// Token: 0x06000814 RID: 2068 RVA: 0x000C898C File Offset: 0x000C6B8C
		private void dInputLoadWeight_ValueChanged(object sender, EventArgs e)
		{
			base.ToolTipShow(this.dInputLoadWeight);
		}

		// Token: 0x04000DD5 RID: 3541
		private ModT_truck _mod = new ModT_truck();
	}
}
