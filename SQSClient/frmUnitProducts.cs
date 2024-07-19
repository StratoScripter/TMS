using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Base;
using DAL.Base.SQSConfig;
using DevComponents.DotNetBar;
using Model;
using Model.SQSConfig;
using SQSClient.Properties;

namespace SQSClient
{
	// Token: 0x02000059 RID: 89
	public partial class frmUnitProducts : BaseDialogForm
	{
		// Token: 0x06000451 RID: 1105 RVA: 0x0006DE34 File Offset: 0x0006C034
		public frmUnitProducts(string text, BaseForm.FormActtion act, int id)
		{
			this.InitializeComponent();
			this.SetText(this);
			this.Text = text;
			this._Act = act;
			this._CurrentId = id;
		}

		// Token: 0x06000452 RID: 1106 RVA: 0x0006DE8C File Offset: 0x0006C08C
		private void frmUnitProducts_Load(object sender, EventArgs e)
		{
			this._mod = DalCfg_unit.Instance.GetModel(this._CurrentId);
			List<string> list = new List<string>();
			list.AddRange(this._mod.CurProductCodeList.Split(new char[]
			{
				','
			}));
			List<string> list2 = new List<string>();
			list2.Add("State=1");
			list2.Add("Code>0");
			this.productlist = DalT_product.Instance.GetListRequire(list2, null, null);
			foreach (ModT_product modT_product in this.productlist)
			{
				modT_product.InvName = modT_product.InvName + "_" + modT_product.InvCode;
				this.lbxProducts.Items.Add(modT_product.InvName);
				bool flag = list.Contains(modT_product.Code.ToString());
				if (flag)
				{
					this.lbxProducts.FindListBoxItem(modT_product.InvName).CheckState = CheckState.Checked;
				}
			}
		}

		// Token: 0x06000453 RID: 1107 RVA: 0x0006DFB8 File Offset: 0x0006C1B8
		private void btnSave_Click(object sender, EventArgs e)
		{
			bool flag = this.lbxProducts.CheckedItems.Count > 5;
			if (flag)
			{
				base.ShowMsg(Messages.ProductsCountLimit, "", "");
			}
			else
			{
				string text = "";
				using (List<ListBoxItem>.Enumerator enumerator = this.lbxProducts.CheckedItems.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						ListBoxItem item = enumerator.Current;
						ModT_product modT_product = this.productlist.Find((ModT_product u) => u.InvName == item.Text);
						text = text + modT_product.Code.ToString() + ",";
					}
				}
				Dictionary<string, object> dictionary = new Dictionary<string, object>();
				dictionary.Add("CurProductCodeList", text);
				DalCfg_unit.Instance.Update(dictionary, this._mod.Id);
				base.DialogResult = DialogResult.Yes;
			}
		}

		// Token: 0x06000454 RID: 1108 RVA: 0x0006E0BC File Offset: 0x0006C2BC
		private void lbxUnit_ItemDoubleClick(object sender, MouseEventArgs e)
		{
			ListBoxItem listBoxItem = sender as ListBoxItem;
			bool flag = listBoxItem != null;
			if (flag)
			{
				listBoxItem.CheckState = (listBoxItem.CheckState + 1) % CheckState.Indeterminate;
			}
		}

		// Token: 0x04000788 RID: 1928
		private ModCfg_unit _mod = new ModCfg_unit();

		// Token: 0x04000789 RID: 1929
		private List<ModT_product> productlist = new List<ModT_product>();
	}
}
