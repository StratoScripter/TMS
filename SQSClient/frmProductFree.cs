using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Assistant;
using Base;
using DAL.Base.SQSConfig;
using DAL.SQLServer.SQSConfig;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using DevComponents.DotNetBar.Layout;
using Model;
using Model.SQSConfig;
using SQSClient.Properties;

namespace SQSClient
{
	// Token: 0x02000067 RID: 103
	public partial class frmProductFree : BaseDialogForm
	{
		// Token: 0x0600052D RID: 1325 RVA: 0x000836AC File Offset: 0x000818AC
		public frmProductFree(string text, BaseForm.FormActtion act, string invCode, string dir, int proExtType)
		{
			this.InitializeComponent();
			this.SetText(this);
			this.Text = text;
			this._Act = act;
			this._InvCode = invCode;
			this._Direct = dir;
			this._ProExtType = proExtType;
		}

		// Token: 0x0600052E RID: 1326 RVA: 0x00083751 File Offset: 0x00081951
		private void frmProductFree_Load(object sender, EventArgs e)
		{
			this.InitControl();
			this.LoadData();
			this.CheckControl();
		}

		// Token: 0x0600052F RID: 1327 RVA: 0x00083769 File Offset: 0x00081969
		private void InitControl()
		{
			this.txtInvCode.ReadOnly = true;
			this.txtInvName.ReadOnly = true;
			this.txtProExtInfo.ReadOnly = true;
			this.LoadGroupData();
		}

		// Token: 0x06000530 RID: 1328 RVA: 0x0008379C File Offset: 0x0008199C
		protected override void LoadData()
		{
			this._mod = this._Dal.GetModelByInvCode(this._InvCode);
			bool flag = this._mod == null;
			if (!flag)
			{
				int proExtType = this._ProExtType;
				int num = proExtType;
				if (num != 0)
				{
					if (num != 1)
					{
						this._ProExtType = 0;
						this._ProFreeType = this._mod.PackWeightFree;
						this._ProFreeField = "PackWeightFree";
					}
					else
					{
						this._ProFreeType = this._mod.AccuRangeFree;
						this._ProFreeField = "AccuRangeFree";
					}
				}
				else
				{
					this._ProFreeType = this._mod.PackWeightFree;
					this._ProFreeField = "PackWeightFree";
				}
			}
		}

		// Token: 0x06000531 RID: 1329 RVA: 0x00083848 File Offset: 0x00081A48
		private void CheckControl()
		{
			this.txtInvCode.Text = this._mod.InvCode;
			this.txtInvName.Text = this._mod.InvName;
			this.txtProExtInfo.Text = ShowWords.ReplaceText(EnumHelper.GetDescription<ProductFreeEnum>((ProductFreeEnum)this._ProExtType));
			foreach (ProFreeFieldControl proFreeFieldControl in this._listProFreeControl)
			{
				proFreeFieldControl.CheckFreeSelected(this._ProFreeType);
			}
		}

		// Token: 0x06000532 RID: 1330 RVA: 0x000838F0 File Offset: 0x00081AF0
		private void btnSave_Click(object sender, EventArgs e)
		{
			bool flag = !this.TextCheck();
			if (!flag)
			{
				this.Modify();
				base.DialogResult = DialogResult.Yes;
			}
		}

		// Token: 0x06000533 RID: 1331 RVA: 0x00083920 File Offset: 0x00081B20
		private bool Add()
		{
			return true;
		}

		// Token: 0x06000534 RID: 1332 RVA: 0x00083934 File Offset: 0x00081B34
		private bool Modify()
		{
			string text = string.Empty;
			foreach (ProFreeFieldControl proFreeFieldControl in this._listProFreeControl)
			{
				bool getChecked = proFreeFieldControl.GetChecked;
				if (getChecked)
				{
					text = text + proFreeFieldControl.ModCfgfree.KeyField + ",";
				}
			}
			text = text.Trim(new char[]
			{
				','
			});
			bool flag = !this._ProFreeType.Equals(text);
			bool result;
			if (flag)
			{
				List<ModT_productext> listByInvCodeAndProExtType = DAL.Base.SQSConfig.DalT_productext.Instance.GetListByInvCodeAndProExtType(this._InvCode, this._ProExtType);
				bool flag2 = listByInvCodeAndProExtType.Count > 0;
				if (flag2)
				{
					base.ShowMsg("ModifyFreeModelError", "", "");
					result = true;
				}
				else
				{
					result = this._Dal.UpdateCfgFree(this._ProFreeField, text, this._InvCode);
				}
			}
			else
			{
				result = true;
			}
			return result;
		}

		// Token: 0x06000535 RID: 1333 RVA: 0x00083A40 File Offset: 0x00081C40
		private bool TextCheck()
		{
			return true;
		}

		// Token: 0x06000536 RID: 1334 RVA: 0x00083A54 File Offset: 0x00081C54
		protected void LoadGroupData()
		{
			this._listProFreeControl.Clear();
			this.layoutControlFree.RootGroup.Items.Clear();
			this.layoutControlFree.Controls.Clear();
			this._layItemList.Clear();
			List<ModCfg_free> list = DAL.Base.SQSConfig.DalCfg_free.Instance.GetAllList();
			list = (from o in list
			orderby o.FreeIndex
			select o).ToList<ModCfg_free>();
			foreach (ModCfg_free value in list)
			{
				this.AddCfgFreeControl(value);
			}
			this.Refresh();
		}

		// Token: 0x06000537 RID: 1335 RVA: 0x00083B24 File Offset: 0x00081D24
		private void AddCfgFreeControl(ModCfg_free value)
		{
			ProFreeFieldControl proFreeFieldControl = new ProFreeFieldControl(value);
			proFreeFieldControl.Margin = new System.Windows.Forms.Padding(0);
			proFreeFieldControl.Name = "CfgFree" + (this._layItemList.Count + 1).ToString();
			proFreeFieldControl.Size = new Size(230, 23);
			LayoutControlItem layoutControlItem = new LayoutControlItem();
			layoutControlItem.Control = proFreeFieldControl;
			layoutControlItem.Height = 38;
			layoutControlItem.Name = (this._layItemList.Count + 1).ToString();
			layoutControlItem.Text = ShowWords.ReplaceText("LayFreeCode") + " " + (this._layItemList.Count + 1).ToString();
			layoutControlItem.TextAlignment = eTextAlignment.Right;
			layoutControlItem.TextLineAlignment = eTextLineAlignment.Bottom;
			layoutControlItem.Width = 290;
			layoutControlItem.WidthType = eLayoutSizeType.Percent;
			this.layoutControlFree.RootGroup.Items.Add(layoutControlItem);
			this.layoutControlFree.Controls.Add(proFreeFieldControl);
			this._layItemList.Add(layoutControlItem);
			this._listProFreeControl.Add(proFreeFieldControl);
		}

		// Token: 0x040008F6 RID: 2294
		private int _ProExtType = 0;

		// Token: 0x040008F7 RID: 2295
		private string _ProFreeType = string.Empty;

		// Token: 0x040008F8 RID: 2296
		private string _ProFreeField = string.Empty;

		// Token: 0x040008F9 RID: 2297
		private string _InvCode = string.Empty;

		// Token: 0x040008FA RID: 2298
		private ModT_product _mod = new ModT_product();

		// Token: 0x040008FB RID: 2299
		private DAL.SQLServer.SQSConfig.DalT_product _Dal = DAL.Base.SQSConfig.DalT_product.Instance;

		// Token: 0x040008FC RID: 2300
		protected List<LayoutItemBase> _layItemList = new List<LayoutItemBase>();

		// Token: 0x040008FD RID: 2301
		protected List<ProFreeFieldControl> _listProFreeControl = new List<ProFreeFieldControl>();
	}
}
