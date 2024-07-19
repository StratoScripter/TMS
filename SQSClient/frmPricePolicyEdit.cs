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
using DevComponents.DotNetBar.Layout;
using DevComponents.Editors;
using DevComponents.Editors.DateTimeAdv;
using Model;
using Model.SQSConfig;
using SQSClient.Properties;

namespace SQSClient
{
	// Token: 0x02000031 RID: 49
	public partial class frmPricePolicyEdit : BaseDialogForm
	{
		// Token: 0x06000248 RID: 584 RVA: 0x00040E10 File Offset: 0x0003F010
		public frmPricePolicyEdit(string text, BaseForm.FormActtion act, int id, string dir)
		{
			this.InitializeComponent();
			this.SetText(this);
			this.Text = text;
			this._Act = act;
			this._CurrentId = id;
			this._Direct = dir;
		}

		// Token: 0x06000249 RID: 585 RVA: 0x00040E81 File Offset: 0x0003F081
		private void frmPricePolicyEdit_Load(object sender, EventArgs e)
		{
			this.InitControl();
			this.LoadData();
		}

		// Token: 0x0600024A RID: 586 RVA: 0x00003040 File Offset: 0x00001240
		private void InitControl()
		{
		}

		// Token: 0x0600024B RID: 587 RVA: 0x00040E94 File Offset: 0x0003F094
		protected override void LoadData()
		{
			bool flag = BaseForm.FormActtion.Modify == this._Act;
			if (flag)
			{
				this._mod = this._Dal.GetModel(this._CurrentId);
				bool flag2 = this._mod == null;
				if (flag2)
				{
					base.ShowMsg(Messages.ObjNonExist, "", "");
					base.Close();
				}
				else
				{
					this.txtKeyCode.Text = this._mod.KeyCode;
					this.txtPriceType.Text = this._mod.Type;
					this.dtRunTime.Value = this._mod.RunTime;
					this.rtbRemark.Text = this._mod.Remark;
					this.InitPriceControl(this._mod.ThresholdPrice);
				}
			}
			else
			{
				this.txtKeyCode.Text = "CornPrice";
				this.txtPriceType.Text = ShowWords.ReplaceText("CornPrice");
				this.dtRunTime.Value = DateTime.Now;
				this.rtbRemark.Text = ShowWords.ReplaceText("MsgPriceExplain");
			}
		}

		// Token: 0x0600024C RID: 588 RVA: 0x00040FBC File Offset: 0x0003F1BC
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

		// Token: 0x0600024D RID: 589 RVA: 0x0004100C File Offset: 0x0003F20C
		private bool Add()
		{
			this._mod = new ModT_pricepolicy();
			this._mod.KeyCode = this.txtKeyCode.Text.Trim();
			this._mod.Type = this.txtPriceType.Text.Trim();
			this._mod.RunTime = this.dtRunTime.Value;
			this._mod.Remark = this.rtbRemark.Text.Trim();
			this.RefreshPriceValueList();
			string empty = string.Empty;
			string empty2 = string.Empty;
			this.GetThresholdPriceInfo(ref empty, ref empty2);
			this._mod.ThresholdPrice = empty;
			this._mod.ThresholdPriceInfo = empty2;
			this._mod.ThresholdUnit = "%";
			this._mod.PriceUnit = ShowWords.ReplaceText("YuanPerKg");
			int num = this._Dal.Add(this._mod);
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

		// Token: 0x0600024E RID: 590 RVA: 0x00041158 File Offset: 0x0003F358
		private bool Modify()
		{
			ModT_pricepolicy oldValue = this._mod.Clone() as ModT_pricepolicy;
			this._mod.KeyCode = this.txtKeyCode.Text.Trim();
			this._mod.Type = this.txtPriceType.Text.Trim();
			this._mod.RunTime = this.dtRunTime.Value;
			this._mod.Remark = this.rtbRemark.Text.Trim();
			this.RefreshPriceValueList();
			string empty = string.Empty;
			string empty2 = string.Empty;
			this.GetThresholdPriceInfo(ref empty, ref empty2);
			this._mod.ThresholdPrice = empty;
			this._mod.ThresholdPriceInfo = empty2;
			this._mod.ThresholdUnit = "%";
			this._mod.PriceUnit = ShowWords.ReplaceText("YuanPerKg");
			bool flag = !this._Dal.Update(this._mod);
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

		// Token: 0x0600024F RID: 591 RVA: 0x000412A4 File Offset: 0x0003F4A4
		private bool TextCheck()
		{
			bool flag = string.IsNullOrWhiteSpace(this.txtKeyCode.Text);
			bool result;
			if (flag)
			{
				base.ShowMsg("KeyCodeNull", "", "");
				this.txtKeyCode.Focus();
				result = false;
			}
			else
			{
				bool flag2 = string.IsNullOrWhiteSpace(this.txtPriceType.Text);
				if (flag2)
				{
					base.ShowMsg("PriceTypeNull", "", "");
					this.txtKeyCode.Focus();
					result = false;
				}
				else
				{
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06000250 RID: 592 RVA: 0x00041330 File Offset: 0x0003F530
		private void btnAdd_Click(object sender, EventArgs e)
		{
			ModPriceValue modPriceValue = new ModPriceValue(0m, 0m);
			this._ListPrice.Add(modPriceValue);
			this.AddPriceControl(modPriceValue);
		}

		// Token: 0x06000251 RID: 593 RVA: 0x00041364 File Offset: 0x0003F564
		private void AddPriceControl(ModPriceValue priceValue)
		{
			PriceThresholdControl priceThresholdControl = new PriceThresholdControl();
			priceThresholdControl.Margin = new System.Windows.Forms.Padding(0);
			priceThresholdControl.Name = "PriceControlPart" + (this._LayItemList.Count + 1).ToString();
			priceThresholdControl.Size = new Size(230, 28);
			priceThresholdControl.UpperThresholdValue = priceValue.UpperThreshold;
			priceThresholdControl.PriceValue = priceValue.Price;
			priceThresholdControl.DeleteEvent += this.priceThresholdPart_DeleteEvent;
			priceThresholdControl.LoadData();
			LayoutControlItem layoutControlItem = new LayoutControlItem();
			layoutControlItem.Control = priceThresholdControl;
			layoutControlItem.Height = 38;
			layoutControlItem.Name = "layPriceTh" + (this._LayItemList.Count + 1).ToString();
			layoutControlItem.Text = ShowWords.ReplaceText("PricePolicy") + " " + (this._LayItemList.Count + 1).ToString();
			layoutControlItem.TextAlignment = DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			layoutControlItem.TextLineAlignment = eTextLineAlignment.Bottom;
			layoutControlItem.Width = 290;
			layoutControlItem.WidthType = eLayoutSizeType.Percent;
			this.lytPriceControl.RootGroup.Items.Add(layoutControlItem);
			this.lytPriceControl.Controls.Add(priceThresholdControl);
			this._LayItemList.Add(layoutControlItem);
		}

		// Token: 0x06000252 RID: 594 RVA: 0x000414BC File Offset: 0x0003F6BC
		private void InitPriceControl(string thresholdPrice)
		{
			bool flag = thresholdPrice.Length == 0;
			if (!flag)
			{
				this._ListPrice.Clear();
				try
				{
					string[] array = thresholdPrice.Split(new char[]
					{
						';'
					});
					for (int i = 0; i < array.Length; i++)
					{
						string[] array2 = array[i].Split(new char[]
						{
							':'
						});
						this._ListPrice.Add(new ModPriceValue(Convert.ToDecimal(array2[0]), Convert.ToDecimal(array2[1])));
					}
				}
				catch
				{
				}
				this.InitPriceControl();
			}
		}

		// Token: 0x06000253 RID: 595 RVA: 0x00041564 File Offset: 0x0003F764
		private void InitPriceControl()
		{
			this.lytPriceControl.RootGroup.Items.Clear();
			this.lytPriceControl.Controls.Clear();
			this._LayItemList.Clear();
			foreach (ModPriceValue priceValue in this._ListPrice)
			{
				this.AddPriceControl(priceValue);
			}
		}

		// Token: 0x06000254 RID: 596 RVA: 0x000415F0 File Offset: 0x0003F7F0
		private void priceThresholdPart_DeleteEvent(object sender, EventArgs e)
		{
			bool flag = this._ListPrice.Count == 0;
			if (!flag)
			{
				this._ListPrice.RemoveAt(this._ListPrice.Count - 1);
				this.InitPriceControl();
			}
		}

		// Token: 0x06000255 RID: 597 RVA: 0x00041633 File Offset: 0x0003F833
		private void RefreshPriceValueList()
		{
			this._ListPrice.Clear();
			List<PriceThresholdControl> list = this.lytPriceControl.Controls.OfType<PriceThresholdControl>().ToList<PriceThresholdControl>();
			if (list != null)
			{
				list.ForEach(delegate(PriceThresholdControl c)
				{
					this._ListPrice.Add(new ModPriceValue(c.UpperThresholdValue, c.PriceValue));
				});
			}
		}

		// Token: 0x06000256 RID: 598 RVA: 0x00041670 File Offset: 0x0003F870
		private void GetThresholdPriceInfo(ref string thPrice, ref string thPriceInfo)
		{
			thPrice = string.Empty;
			thPriceInfo = string.Empty;
			foreach (ModPriceValue modPriceValue in this._ListPrice)
			{
				thPrice = string.Concat(new string[]
				{
					thPrice,
					modPriceValue.UpperThreshold.ToString(),
					":",
					modPriceValue.Price.ToString(),
					";"
				});
				thPriceInfo = thPriceInfo + string.Format(ShowWords.ReplaceText("ShowThresholdPriceInfo"), modPriceValue.UpperThreshold, modPriceValue.Price) + ";";
			}
			thPrice = thPrice.Trim(new char[]
			{
				';'
			});
			thPriceInfo = thPriceInfo.Trim(new char[]
			{
				';'
			});
		}

		// Token: 0x0400040C RID: 1036
		private ModT_pricepolicy _mod = null;

		// Token: 0x0400040D RID: 1037
		private DAL.SQLServer.SQSConfig.DalT_pricepolicy _Dal = DAL.Base.SQSConfig.DalT_pricepolicy.Instance;

		// Token: 0x0400040E RID: 1038
		protected List<LayoutItemBase> _LayItemList = new List<LayoutItemBase>();

		// Token: 0x0400040F RID: 1039
		protected List<ModPriceValue> _ListPrice = new List<ModPriceValue>();
	}
}
