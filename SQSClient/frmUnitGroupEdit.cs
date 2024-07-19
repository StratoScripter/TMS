using System;
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
using Model;
using Model.SQSConfig;
using SQSClient.Properties;

namespace SQSClient
{
	// Token: 0x0200005F RID: 95
	public partial class frmUnitGroupEdit : BaseDialogForm
	{
		// Token: 0x0600048A RID: 1162 RVA: 0x00072EA8 File Offset: 0x000710A8
		public frmUnitGroupEdit(string text, BaseForm.FormActtion act, int id, ModCfg_unitgroup parentmod, string dir)
		{
			this.InitializeComponent();
			this.SetText(this);
			this.Text = text;
			this._Act = act;
			this._CurrentId = id;
			this._ParentMod = parentmod;
			this._Direct = dir;
		}

		// Token: 0x0600048B RID: 1163 RVA: 0x00072F0F File Offset: 0x0007110F
		private void frmUnitGroupEdit_Load(object sender, EventArgs e)
		{
			this.InitControl();
			this.LoadData();
		}

		// Token: 0x0600048C RID: 1164 RVA: 0x00003040 File Offset: 0x00001240
		private void InitControl()
		{
		}

		// Token: 0x0600048D RID: 1165 RVA: 0x00072F20 File Offset: 0x00071120
		protected override void LoadData()
		{
			bool flag = BaseForm.FormActtion.Modify == this._Act;
			if (flag)
			{
				this._mod = DalCfg_unitgroup.Instance.GetModel(this._CurrentId);
				bool flag2 = this._mod == null;
				if (flag2)
				{
					base.ShowMsg(Messages.ObjNonExist, "", "");
					base.Close();
				}
				else
				{
					this.txtGroupName.Text = this._mod.Name;
					this.txtGroupName.Enabled = false;
					this.txtGroupCode.Text = this._mod.Code;
					this.iInputGroupIndex.Value = this._mod.GroupIndex;
					this.cmbSpecialFunction.SelectedIndex = this._mod.SpecialFunction;
					this.chkState.Checked = (this.cmbSpecialFunction.SelectedIndex > 0);
					this.rtxtRemark.Text = this._mod.Remark;
				}
			}
		}

		// Token: 0x0600048E RID: 1166 RVA: 0x00073024 File Offset: 0x00071224
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

		// Token: 0x0600048F RID: 1167 RVA: 0x00073074 File Offset: 0x00071274
		private bool Add()
		{
			this._mod.Name = this.txtGroupName.Text.Trim();
			this._mod.Code = this.txtGroupCode.Text.Trim();
			this._mod.GroupIndex = this.iInputGroupIndex.Value;
			this._mod.TreeLevel = 0;
			this._mod.ParentId = 0;
			bool flag = this._ParentMod != null;
			if (flag)
			{
				this._mod.TreeLevel = this._ParentMod.TreeLevel + 1;
				this._mod.ParentId = this._ParentMod.Id;
			}
			this._mod.SpecialFunction = this.cmbSpecialFunction.SelectedIndex;
			this._mod.Remark = this.rtxtRemark.Text.Trim();
			this._mod.PinYinMa = this._mod.Name.GetFirstPinyin();
			bool flag2 = base.IsExist("cfg_unitgroup", "Name", this._mod.Name, SqlDbType.NVarChar);
			bool result;
			if (flag2)
			{
				base.ShowMsg(Messages.GroupHaved, "", "");
				this.txtGroupName.Focus();
				result = false;
			}
			else
			{
				int num = DalCfg_unitgroup.Instance.Add(this._mod);
				bool flag3 = num < 1;
				if (flag3)
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

		// Token: 0x06000490 RID: 1168 RVA: 0x00073224 File Offset: 0x00071424
		private bool Modify()
		{
			ModCfg_unitgroup oldValue = this._mod.Clone() as ModCfg_unitgroup;
			this._mod.Name = this.txtGroupName.Text.Trim();
			this._mod.Code = this.txtGroupCode.Text.Trim();
			this._mod.GroupIndex = this.iInputGroupIndex.Value;
			this._mod.SpecialFunction = this.cmbSpecialFunction.SelectedIndex;
			this._mod.Remark = this.rtxtRemark.Text.Trim();
			this._mod.PinYinMa = this._mod.Name.GetFirstPinyin();
			bool flag = !DalCfg_unitgroup.Instance.Update(this._mod);
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

		// Token: 0x06000491 RID: 1169 RVA: 0x00073340 File Offset: 0x00071540
		private bool TextCheck()
		{
			bool flag = string.IsNullOrWhiteSpace(this.txtGroupName.Text);
			bool result;
			if (flag)
			{
				base.ShowMsg(Messages.GroupNull, "", "");
				result = false;
			}
			else
			{
				result = true;
			}
			return result;
		}

		// Token: 0x040007E6 RID: 2022
		private ModCfg_unitgroup _mod = new ModCfg_unitgroup();

		// Token: 0x040007E7 RID: 2023
		private ModCfg_unitgroup _ParentMod = new ModCfg_unitgroup();
	}
}
