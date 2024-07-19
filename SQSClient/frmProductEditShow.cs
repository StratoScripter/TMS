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
	// Token: 0x02000064 RID: 100
	public partial class frmProductEditShow : BaseDialogForm
	{
		// Token: 0x060004CE RID: 1230 RVA: 0x0007A1D8 File Offset: 0x000783D8
		public frmProductEditShow(string text, BaseForm.FormActtion act, int id, string dir)
		{
			this.InitializeComponent();
			this.SetText(this);
			this.Text = text;
			this._Act = act;
			this._CurrentId = id;
			this._Direct = dir;
		}

		// Token: 0x060004CF RID: 1231 RVA: 0x0007A237 File Offset: 0x00078437
		private void frmProductEditShow_Load(object sender, EventArgs e)
		{
			this.InitControl();
			this.LoadData();
		}

		// Token: 0x060004D0 RID: 1232 RVA: 0x0007A248 File Offset: 0x00078448
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
			this.cmbQueue.BindDataSouce(DalT_warehouse.Instance.GetAllListOrderIndex(""), "Name", "PinYinMa", "QueueIndex");
			this.cmbQueue.SelectedIndex = 0;
		}

		// Token: 0x060004D1 RID: 1233 RVA: 0x0007A348 File Offset: 0x00078548
		protected override void LoadData()
		{
			bool flag = this._Act == BaseForm.FormActtion.Add;
			if (flag)
			{
				this.AddProductPart("");
				this.chkSingle.Checked = true;
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
					this.txtInvCode.ReadOnly = true;
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
					this.cmbQueue.SelectedValue = this._mod.GroupIndex;
					this.cmbPackType.SelectedValue = this._mod.PackType;
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

		// Token: 0x060004D2 RID: 1234 RVA: 0x0007A6B0 File Offset: 0x000788B0
		private void chkSingle_CheckedChanged(object sender, EventArgs e)
		{
			this.layAdd.Visible = false;
			foreach (LayoutItemBase layoutItemBase in this._layProductList)
			{
				layoutItemBase.Visible = false;
			}
		}

		// Token: 0x060004D3 RID: 1235 RVA: 0x0007A718 File Offset: 0x00078918
		private void chkCombin_CheckedChanged(object sender, EventArgs e)
		{
			this.layAdd.Visible = true;
			foreach (LayoutItemBase layoutItemBase in this._layProductList)
			{
				layoutItemBase.Visible = true;
			}
		}

		// Token: 0x060004D4 RID: 1236 RVA: 0x0007A780 File Offset: 0x00078980
		private void btnAdd_Click(object sender, EventArgs e)
		{
			this.AddProductPart("");
		}

		// Token: 0x060004D5 RID: 1237 RVA: 0x0007A790 File Offset: 0x00078990
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

		// Token: 0x060004D6 RID: 1238 RVA: 0x0007A8E0 File Offset: 0x00078AE0
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

		// Token: 0x060004D7 RID: 1239 RVA: 0x0007A94C File Offset: 0x00078B4C
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

		// Token: 0x060004D8 RID: 1240 RVA: 0x0007A9CC File Offset: 0x00078BCC
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

		// Token: 0x060004D9 RID: 1241 RVA: 0x0007AA1C File Offset: 0x00078C1C
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

		// Token: 0x060004DA RID: 1242 RVA: 0x0007AC3C File Offset: 0x00078E3C
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
			this._mod.GroupIndex = Convert.ToInt32(this.cmbQueue.SelectedValue);
			this._mod.PackType = Convert.ToInt32(this.cmbPackType.SelectedValue);
			this._mod.ModifyTime = DateTime.Now;
			this._mod.EffectTime = this.tInputEffectTime.Value;
		}

		// Token: 0x060004DB RID: 1243 RVA: 0x0007AE5C File Offset: 0x0007905C
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

		// Token: 0x060004DC RID: 1244 RVA: 0x0007B018 File Offset: 0x00079218
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

		// Token: 0x04000857 RID: 2135
		private ModT_product _mod = new ModT_product();

		// Token: 0x04000858 RID: 2136
		protected List<LayoutItemBase> _layProductList = new List<LayoutItemBase>();
	}
}
