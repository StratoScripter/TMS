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
using DevComponents.Editors.DateTimeAdv;
using Model;
using Model.SQSConfig;
using SQSClient.Properties;

namespace SQSClient
{
	// Token: 0x0200008D RID: 141
	public partial class frmProductEdit : BaseDialogForm
	{
		// Token: 0x060007B7 RID: 1975 RVA: 0x000BEA70 File Offset: 0x000BCC70
		public frmProductEdit(string text, BaseForm.FormActtion act, int id, string dir)
		{
			this.InitializeComponent();
			this.SetText(this);
			this.Text = text;
			this._Act = act;
			this._CurrentId = id;
			this._Direct = dir;
		}

		// Token: 0x060007B8 RID: 1976 RVA: 0x000BEACF File Offset: 0x000BCCCF
		private void frmProductEdit_Load(object sender, EventArgs e)
		{
			this.InitControl();
			this.LoadData();
		}

		// Token: 0x060007B9 RID: 1977 RVA: 0x000BEAE0 File Offset: 0x000BCCE0
		private void InitControl()
		{
			List<BaseForm.EnumModel> list = new List<BaseForm.EnumModel>();
			list.AddRange(BaseForm.GetEnumModelList<ProductValid>());
			BaseForm.BindDataSouce(this.cmbValidCondition, list, "Description", "Value");
			List<BaseForm.EnumModel> list2 = new List<BaseForm.EnumModel>();
			list2.AddRange(BaseForm.GetEnumModelList<AccountType>());
			list2.RemoveAt(2);
			BaseForm.BindDataSouce(this.cmbPostType, list2, "Description", "Value");
			List<BaseForm.EnumModel> list3 = new List<BaseForm.EnumModel>();
			list3.AddRange(BaseForm.GetEnumModelList<EffectState>());
			BaseForm.BindDataSouce(this.cmbState, list3, "Description", "Value");
			BaseForm.BindDataSouce(this.cmbBusinessType, BaseForm.GetEnumModelList<TradeType>(), "Description", "Value");
			BaseForm.BindDataSouce(this.cmbPackType, BaseForm.GetEnumModelList<PackType>(), "Description", "Value");
			List<ModCfg_pdasetting> list4 = new List<ModCfg_pdasetting>();
			list4.Add(new ModCfg_pdasetting
			{
				Id = 0,
				Name = ShowWords.ReplaceText("All"),
				Value = 0.0,
				Remark = ShowWords.ReplaceText("All")
			});
			list4.AddRange(DalCfg_pdasetting.Instance.GetList("Type", "CompanyGroup"));
			this.cmbCompanyGroup.BindDataSouce(list4, "Name", "Name", "Value");
		}

		// Token: 0x060007BA RID: 1978 RVA: 0x000BEC2C File Offset: 0x000BCE2C
		protected override void LoadData()
		{
			bool flag = this._Act == BaseForm.FormActtion.Add;
			if (flag)
			{
				this.AddProductPart("");
				this.chkSingle.Checked = true;
				this.cmbCompanyGroup.SelectedIndex = 0;
			}
			bool flag2 = BaseForm.FormActtion.Modify == this._Act;
			if (flag2)
			{
				this._mod = DalT_product.Instance.GetModel(this._CurrentId);
				bool flag3 = this._mod == null;
				if (flag3)
				{
					base.ShowMsg(Messages.ObjNonExist, "", "");
					base.Close();
				}
				else
				{
					this.txtInvName.Text = this._mod.InvName;
					this.txtInvCode.Text = this._mod.InvCode;
					this.txtInvCode.Enabled = false;
					this.txtName.Text = this._mod.Name;
					this.dInputCode.Value = (double)this._mod.Code;
					this.rtbRemark.Text = this._mod.Remark;
					this.dInputSpecsAmount.Value = Convert.ToDouble(this._mod.SpecsAmount);
					this.dInputSpecsShell.Value = Convert.ToDouble(this._mod.SpecsShell);
					this.txtSpecsDescribe.Text = this._mod.SpecsDescribe;
					this.dInputPositivePrecise.Value = Convert.ToDouble(this._mod.PositivePrecise);
					this.dInputNagativePrecise.Value = Convert.ToDouble(this._mod.NagativePrecise);
					this.tInputEffectTime.Value = this._mod.EffectTime;
					bool flag4 = this.tInputEffectTime.Value.ToString("yyyy") == "0001";
					if (flag4)
					{
						this.tInputEffectTime.Value = DateTime.Now;
					}
					this.cmbState.SelectedValue = this._mod.State;
					this.cmbValidCondition.SelectedValue = this._mod.ValidCondition;
					this.cmbPostType.SelectedValue = this._mod.PostType;
					this.cmbPackType.SelectedValue = this._mod.PackType;
					this.txtLabCheckCondition.Text = this._mod.LabCheckCondition;
					this.cmbCompanyGroup.SelectedValue = this._mod.CompanyGroup;
					this.dInputTicketPerDay.Value = (double)this._mod.TicketPerDay;
					this.cbxTicketPerDay.Checked = this._mod.IsTicketPerDay;
					ProductType type = (ProductType)this._mod.Type;
					ProductType productType = type;
					if (productType != ProductType.Single)
					{
						if (productType == ProductType.Combin)
						{
							this.chkCombin.Checked = true;
							this.chkSingle.Enabled = false;
							string[] array = this._mod.Combin.Split(new char[]
							{
								','
							});
							for (int i = 0; i < array.Length; i++)
							{
								bool flag5 = array[i].Contains("%");
								if (flag5)
								{
									this.AddProductPart(array[i]);
								}
							}
						}
					}
					else
					{
						this.chkSingle.Checked = true;
						this.chkCombin.Enabled = false;
						this.dInputSunHao.Value = (double)this._mod.SunHao;
						this.dInputMidu.Value = (double)this._mod.Midu;
					}
				}
			}
		}

		// Token: 0x060007BB RID: 1979 RVA: 0x000BEFE8 File Offset: 0x000BD1E8
		private void chkSingle_CheckedChanged(object sender, EventArgs e)
		{
			this.layAdd.Visible = false;
			foreach (LayoutItemBase layoutItemBase in this._layProductList)
			{
				layoutItemBase.Visible = false;
			}
		}

		// Token: 0x060007BC RID: 1980 RVA: 0x000BF050 File Offset: 0x000BD250
		private void chkCombin_CheckedChanged(object sender, EventArgs e)
		{
			this.layAdd.Visible = true;
			foreach (LayoutItemBase layoutItemBase in this._layProductList)
			{
				layoutItemBase.Visible = true;
			}
		}

		// Token: 0x060007BD RID: 1981 RVA: 0x000BF0B8 File Offset: 0x000BD2B8
		private void btnAdd_Click(object sender, EventArgs e)
		{
			this.AddProductPart("");
		}

		// Token: 0x060007BE RID: 1982 RVA: 0x000BF0C8 File Offset: 0x000BD2C8
		private void AddProductPart(string value)
		{
			ProductPart productPart = new ProductPart();
			productPart.Margin = new System.Windows.Forms.Padding(0);
			productPart.Name = "productPart" + (this._layProductList.Count + 1).ToString();
			productPart.Size = new Size(230, 23);
			productPart.LoadData(DalT_product.Instance.GetListByState(1, 0));
			productPart.Value = value;
			productPart.DeleteEvent += this.productPart_DeleteEvent;
			LayoutControlItem layoutControlItem = new LayoutControlItem();
			layoutControlItem.Control = productPart;
			layoutControlItem.Height = 38;
			layoutControlItem.Name = "layProduct" + (this._layProductList.Count + 1).ToString();
			layoutControlItem.Text = ShowWords.ReplaceText("Product") + " " + (this._layProductList.Count + 1).ToString();
			layoutControlItem.TextAlignment = DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			layoutControlItem.TextLineAlignment = eTextLineAlignment.Bottom;
			layoutControlItem.Width = 290;
			layoutControlItem.WidthType = eLayoutSizeType.Percent;
			this.layoutControl1.RootGroup.Items.Add(layoutControlItem);
			this.layoutControl1.Controls.Add(productPart);
			this._layProductList.Add(layoutControlItem);
		}

		// Token: 0x060007BF RID: 1983 RVA: 0x000BF218 File Offset: 0x000BD418
		private void productPart_DeleteEvent(object sender, EventArgs e)
		{
			bool flag = this._layProductList.Count > 0;
			if (flag)
			{
				LayoutItemBase layoutItemBase = this.FindLayItem((ProductPart)sender);
				this.layoutControl1.RootGroup.Items.Remove(layoutItemBase);
				this.layoutControl1.Controls.Remove((ProductPart)sender);
				this._layProductList.Remove(layoutItemBase);
			}
		}

		// Token: 0x060007C0 RID: 1984 RVA: 0x000BF284 File Offset: 0x000BD484
		private LayoutItemBase FindLayItem(Control col)
		{
			LayoutItemBase result = null;
			foreach (object obj in this.layoutControl1.RootGroup.Items)
			{
				LayoutControlItem layoutControlItem = (LayoutControlItem)obj;
				bool flag = layoutControlItem.Control == col;
				if (flag)
				{
					result = layoutControlItem;
					break;
				}
			}
			return result;
		}

		// Token: 0x060007C1 RID: 1985 RVA: 0x000BF304 File Offset: 0x000BD504
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

		// Token: 0x060007C2 RID: 1986 RVA: 0x000BF354 File Offset: 0x000BD554
		private bool Add()
		{
			this._mod.InvCode = this.txtInvCode.Text.Trim();
			this.ReadContral();
			this._mod.EffectTime = DateTime.Now;
			this._mod.Type = (this.chkSingle.Checked ? 0 : 1);
			bool flag = this._mod.Type == 0;
			if (flag)
			{
				this._mod.Midu = (decimal)this.dInputMidu.Value;
			}
			else
			{
				foreach (LayoutItemBase layoutItemBase in this._layProductList)
				{
					LayoutControlItem layoutControlItem = (LayoutControlItem)layoutItemBase;
					ModT_product mod = this._mod;
					mod.Combin = mod.Combin + ((ProductPart)layoutControlItem.Control).Value + ",";
				}
			}
			bool flag2 = base.IsExist("t_product", "InvCode", this._mod.InvCode, SqlDbType.NVarChar);
			bool result;
			if (flag2)
			{
				base.ShowMsg(Messages.InvCodeHaved, "", "");
				this.txtName.Focus();
				result = false;
			}
			else
			{
				bool flag3 = this._mod.Code > 0;
				if (flag3)
				{
					bool flag4 = base.IsExist("t_product", "Code", this._mod.Code, SqlDbType.Int);
					if (flag4)
					{
						base.ShowMsg(Messages.ProductCodeHaved, "", "");
						this.dInputCode.Focus();
						return false;
					}
				}
				int num = DalT_product.Instance.Add(this._mod);
				bool flag5 = num < 1;
				if (flag5)
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

		// Token: 0x060007C3 RID: 1987 RVA: 0x000BF574 File Offset: 0x000BD774
		private void ReadContral()
		{
			this._mod.InvName = this.txtInvName.Text.Trim();
			this._mod.Name = this.txtName.Text.Trim();
			this._mod.Code = (int)this.dInputCode.Value;
			this._mod.Enable = true;
			this._mod.SunHao = Convert.ToDecimal(string.Format("{0:F4}", this.dInputSunHao.Value));
			this._mod.Remark = this.rtbRemark.Text.Trim();
			this._mod.PinYinMa = this._mod.Name.GetFirstPinyin();
			this._mod.SpecsAmount = Convert.ToDecimal(this.dInputSpecsAmount.Value);
			this._mod.SpecsShell = Convert.ToDecimal(this.dInputSpecsShell.Value);
			this._mod.SpecsDanWei = "kg";
			this._mod.SpecsDescribe = this.txtSpecsDescribe.Text.Trim();
			this._mod.PositivePrecise = Convert.ToDecimal(this.dInputPositivePrecise.Value);
			this._mod.NagativePrecise = Convert.ToDecimal(this.dInputNagativePrecise.Value);
			this._mod.State = Convert.ToInt32(this.cmbState.SelectedValue);
			this._mod.ValidCondition = Convert.ToInt32(this.cmbValidCondition.SelectedValue);
			this._mod.PostType = Convert.ToInt32(this.cmbPostType.SelectedValue);
			this._mod.PackType = Convert.ToInt32(this.cmbPackType.SelectedValue);
			this._mod.ModifyTime = DateTime.Now;
			this._mod.EffectTime = this.tInputEffectTime.Value;
			this._mod.LabCheckCondition = this.txtLabCheckCondition.Text;
			this._mod.CompanyGroup = Convert.ToInt32(this.cmbCompanyGroup.SelectedValue);
			this._mod.TicketPerDay = Convert.ToInt32(this.dInputTicketPerDay.Value);
			this._mod.IsTicketPerDay = this.cbxTicketPerDay.Checked;
		}

		// Token: 0x060007C4 RID: 1988 RVA: 0x000BF7E0 File Offset: 0x000BD9E0
		private bool Modify()
		{
			ModT_product oldValue = this._mod.Clone() as ModT_product;
			this.ReadContral();
			bool flag = this._mod.Type == 0;
			if (flag)
			{
				this._mod.Midu = Convert.ToDecimal(string.Format("{0:F2}", this.dInputMidu.Value));
			}
			else
			{
				this._mod.Combin = "";
				foreach (LayoutItemBase layoutItemBase in this._layProductList)
				{
					LayoutControlItem layoutControlItem = (LayoutControlItem)layoutItemBase;
					ModT_product mod = this._mod;
					mod.Combin = mod.Combin + ((ProductPart)layoutControlItem.Control).Value + ",";
				}
			}
			bool flag2 = this._mod.Code > 0;
			if (flag2)
			{
				bool flag3 = base.IsExistOutSelf("t_product", "Code", this._mod.Code, SqlDbType.Int, this._CurrentId);
				if (flag3)
				{
					base.ShowMsg(Messages.ProductCodeHaved, "", "");
					this.dInputCode.Focus();
					return false;
				}
			}
			bool flag4 = !DalT_product.Instance.Update(this._mod);
			bool result;
			if (flag4)
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

		// Token: 0x060007C5 RID: 1989 RVA: 0x000BF99C File Offset: 0x000BDB9C
		private bool TextCheck()
		{
			bool flag = string.IsNullOrWhiteSpace(this.txtInvName.Text);
			bool result;
			if (flag)
			{
				base.ShowMsg(Messages.ProductNull, "", "");
				this.txtInvName.Focus();
				result = false;
			}
			else
			{
				bool flag2 = string.IsNullOrWhiteSpace(this.txtName.Text);
				if (flag2)
				{
					base.ShowMsg(Messages.ProductNull, "", "");
					this.txtName.Focus();
					result = false;
				}
				else
				{
					result = true;
				}
			}
			return result;
		}

		// Token: 0x04000D2D RID: 3373
		private ModT_product _mod = new ModT_product();

		// Token: 0x04000D2E RID: 3374
		protected List<LayoutItemBase> _layProductList = new List<LayoutItemBase>();
	}
}
