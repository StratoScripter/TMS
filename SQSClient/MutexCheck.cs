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
	// Token: 0x0200005A RID: 90
	public partial class MutexCheck : BaseDialogForm
	{
		// Token: 0x06000457 RID: 1111 RVA: 0x0006E44C File Offset: 0x0006C64C
		public MutexCheck(string text, BaseForm.FormActtion act, int id)
		{
			this.InitializeComponent();
			this.SetText(this);
			this.Text = text;
			this._Act = act;
			this._CurrentId = id;
		}

		// Token: 0x06000458 RID: 1112 RVA: 0x0006E4A4 File Offset: 0x0006C6A4
		private void MutexCheck_Load(object sender, EventArgs e)
		{
			this._mod = DalCfg_unit.Instance.GetModel(this._CurrentId);
			this.unitlist = DalCfg_unit.Instance.GetAllList();
			foreach (ModCfg_unit modCfg_unit in this.unitlist)
			{
				bool flag = modCfg_unit.Name == this._mod.Name;
				if (!flag)
				{
					this.lbxUnit.Items.Add(modCfg_unit.Name);
					bool flag2 = modCfg_unit.MutexNum == this._mod.MutexNum;
					if (flag2)
					{
						this.lbxUnit.FindListBoxItem(modCfg_unit.Name).CheckState = CheckState.Checked;
					}
				}
			}
		}

		// Token: 0x06000459 RID: 1113 RVA: 0x0006E580 File Offset: 0x0006C780
		private void btnSave_Click(object sender, EventArgs e)
		{
			this._mod.MutexNum = this._mod.Code;
			DalCfg_unit.Instance.Update(this._mod);
			using (List<ListBoxItem>.Enumerator enumerator = this.lbxUnit.CheckedItems.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					ListBoxItem item = enumerator.Current;
					ModCfg_unit modCfg_unit = this.unitlist.Find((ModCfg_unit u) => u.Name == item.Text);
					modCfg_unit.MutexNum = this._mod.MutexNum;
					DalCfg_unit.Instance.Update(modCfg_unit);
				}
			}
			base.DialogResult = DialogResult.Yes;
		}

		// Token: 0x0600045A RID: 1114 RVA: 0x0006E648 File Offset: 0x0006C848
		private void btnAll_Click(object sender, EventArgs e)
		{
			foreach (object obj in this.lbxUnit.Items)
			{
				this.lbxUnit.FindListBoxItem(obj.ToString()).CheckState = CheckState.Checked;
			}
		}

		// Token: 0x0600045B RID: 1115 RVA: 0x0006E6B0 File Offset: 0x0006C8B0
		private void btnOther_Click(object sender, EventArgs e)
		{
			foreach (object obj in this.lbxUnit.Items)
			{
				ListBoxItem listBoxItem = this.lbxUnit.FindListBoxItem(obj.ToString());
				listBoxItem.CheckState = (listBoxItem.CheckState + 1) % CheckState.Indeterminate;
			}
		}

		// Token: 0x0600045C RID: 1116 RVA: 0x0006E724 File Offset: 0x0006C924
		private void lbxUnit_ItemDoubleClick(object sender, MouseEventArgs e)
		{
			ListBoxItem listBoxItem = sender as ListBoxItem;
			bool flag = listBoxItem != null;
			if (flag)
			{
				listBoxItem.CheckState = (listBoxItem.CheckState + 1) % CheckState.Indeterminate;
			}
		}

		// Token: 0x0400078E RID: 1934
		private ModCfg_unit _mod = new ModCfg_unit();

		// Token: 0x0400078F RID: 1935
		private List<ModCfg_unit> unitlist = new List<ModCfg_unit>();
	}
}
