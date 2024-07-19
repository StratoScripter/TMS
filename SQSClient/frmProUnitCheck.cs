using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Base;
using DAL.Base.SQSConfig;
using DevComponents.DotNetBar;
using Model.SQSConfig;
using SQSClient.Properties;

namespace SQSClient
{
	// Token: 0x0200008E RID: 142
	public partial class frmProUnitCheck : BaseDialogForm
	{
		// Token: 0x060007C8 RID: 1992 RVA: 0x000C2AA4 File Offset: 0x000C0CA4
		public frmProUnitCheck(string text, BaseForm.FormActtion act, int id)
		{
			this.InitializeComponent();
			this.SetText(this);
			this.Text = text;
			this._Act = act;
			this._CurrentId = id;
		}

		// Token: 0x060007C9 RID: 1993 RVA: 0x000C2AFC File Offset: 0x000C0CFC
		private void frmProUnitCheck_Load(object sender, EventArgs e)
		{
			this._mod = DalT_product.Instance.GetModel(this._CurrentId);
			this.unitlist = DalCfg_unit.Instance.GetAllList();
			foreach (ModCfg_unit modCfg_unit in this.unitlist)
			{
				this.lbxUnit.Items.Add(modCfg_unit.Name);
				bool flag = modCfg_unit.CurProductName == this._mod.Name;
				if (flag)
				{
					this.lbxUnit.FindListBoxItem(modCfg_unit.Name).CheckState = CheckState.Checked;
				}
			}
		}

		// Token: 0x060007CA RID: 1994 RVA: 0x000C2BC0 File Offset: 0x000C0DC0
		private void btnSave_Click(object sender, EventArgs e)
		{
			string text = string.Empty;
			foreach (ListBoxItem listBoxItem in this.lbxUnit.CheckedItems)
			{
				text = text + "'" + listBoxItem.Text + "',";
			}
			bool flag = text.Length > 0;
			if (flag)
			{
				DalCfg_unit.Instance.ClearProduct(this._mod.Name);
				text = text.Substring(0, text.Length - 1);
				DalCfg_unit.Instance.UpdateProduct(this._mod.Name, this._mod.Code, text);
				text = text.Replace("'", "");
			}
			base.DialogResult = DialogResult.Yes;
		}

		// Token: 0x060007CB RID: 1995 RVA: 0x000C2CA4 File Offset: 0x000C0EA4
		private void btnAll_Click(object sender, EventArgs e)
		{
			foreach (object obj in this.lbxUnit.Items)
			{
				this.lbxUnit.FindListBoxItem(obj.ToString()).CheckState = CheckState.Checked;
			}
		}

		// Token: 0x060007CC RID: 1996 RVA: 0x000C2D0C File Offset: 0x000C0F0C
		private void btnOther_Click(object sender, EventArgs e)
		{
			foreach (object obj in this.lbxUnit.Items)
			{
				ListBoxItem listBoxItem = this.lbxUnit.FindListBoxItem(obj.ToString());
				listBoxItem.CheckState = (listBoxItem.CheckState + 1) % CheckState.Indeterminate;
			}
		}

		// Token: 0x060007CD RID: 1997 RVA: 0x000C2D80 File Offset: 0x000C0F80
		private void lbxUnit_ItemDoubleClick(object sender, MouseEventArgs e)
		{
			ListBoxItem listBoxItem = sender as ListBoxItem;
			bool flag = listBoxItem != null;
			if (flag)
			{
				listBoxItem.CheckState = (listBoxItem.CheckState + 1) % CheckState.Indeterminate;
			}
		}

		// Token: 0x04000D70 RID: 3440
		private ModT_product _mod = new ModT_product();

		// Token: 0x04000D71 RID: 3441
		private List<ModCfg_unit> unitlist = new List<ModCfg_unit>();
	}
}
