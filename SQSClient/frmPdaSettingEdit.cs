using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Base;
using DAL.Base.SQSConfig;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using DevComponents.DotNetBar.Layout;
using Model;
using Model.SQSConfig;
using SQSClient.Properties;

namespace SQSClient
{
	// Token: 0x0200002E RID: 46
	public partial class frmPdaSettingEdit : BaseDialogForm
	{
		// Token: 0x06000237 RID: 567 RVA: 0x0003F948 File Offset: 0x0003DB48
		public frmPdaSettingEdit(string text, BaseForm.FormActtion act, int id, string dir)
		{
			this.InitializeComponent();
			this.SetText(this);
			this.Text = text;
			this._Act = act;
			this._CurrentId = id;
			this._Direct = dir;
		}

		// Token: 0x06000238 RID: 568 RVA: 0x0003F99C File Offset: 0x0003DB9C
		private void frmPdaSettingEdit_Load(object sender, EventArgs e)
		{
			this.InitControl();
			this.LoadData();
		}

		// Token: 0x06000239 RID: 569 RVA: 0x00003040 File Offset: 0x00001240
		private void InitControl()
		{
		}

		// Token: 0x0600023A RID: 570 RVA: 0x0003F9B0 File Offset: 0x0003DBB0
		protected override void LoadData()
		{
			bool flag = BaseForm.FormActtion.Modify == this._Act;
			if (flag)
			{
				this._mod = DalCfg_pdasetting.Instance.GetModel(this._CurrentId);
				bool flag2 = this._mod == null;
				if (flag2)
				{
					base.ShowMsg(Messages.ObjNonExist, "", "");
					base.Close();
				}
				else
				{
					this.tbxKeyCode.Text = this._mod.Type;
					this.tbxKeyName.Text = this._mod.Name;
					this.tbxKeyValue.Text = this._mod.Value.ToString();
					this.tbxRemark.Text = ShowWords.ReplaceText(this._mod.Remark);
				}
			}
		}

		// Token: 0x0600023B RID: 571 RVA: 0x0003FA84 File Offset: 0x0003DC84
		private void btnSave_Click(object sender, EventArgs e)
		{
			bool flag = !this.TextCheck();
			if (!flag)
			{
				bool flag2 = BaseForm.FormActtion.Modify == this._Act;
				bool flag3;
				if (flag2)
				{
					flag3 = this.Modify();
				}
				else
				{
					flag3 = this.Add();
				}
				bool flag4 = flag3;
				if (flag4)
				{
					base.DialogResult = DialogResult.Yes;
				}
			}
		}

		// Token: 0x0600023C RID: 572 RVA: 0x0003FAD4 File Offset: 0x0003DCD4
		private bool Modify()
		{
			ModCfg_pdasetting modCfg_pdasetting = new ModCfg_pdasetting();
			modCfg_pdasetting.Id = this._mod.Id;
			modCfg_pdasetting.Type = this._mod.Type;
			modCfg_pdasetting.Name = this._mod.Name;
			modCfg_pdasetting.Value = this._mod.Value;
			modCfg_pdasetting.Remark = this._mod.Remark;
			this._mod.Value = double.Parse(this.tbxKeyValue.Text.Trim());
			this._mod.Name = this.tbxKeyName.Text.Trim();
			this._mod.Type = this.tbxKeyCode.Text.Trim();
			this._mod.Remark = this.tbxRemark.Text.Trim();
			bool flag = !DalCfg_pdasetting.Instance.Update(this._mod);
			bool result;
			if (flag)
			{
				this.OnOperateFail(this._mod, false);
				base.ShowMsg(Messages.ModifyFalse, "", "");
				result = false;
			}
			else
			{
				this.OnOperateSuccess(new
				{
					New = this._mod,
					Old = modCfg_pdasetting
				}, true);
				result = true;
			}
			return result;
		}

		// Token: 0x0600023D RID: 573 RVA: 0x0003FC1C File Offset: 0x0003DE1C
		private bool Add()
		{
			ModCfg_pdasetting modCfg_pdasetting = new ModCfg_pdasetting();
			modCfg_pdasetting.Value = double.Parse(this.tbxKeyValue.Text.Trim());
			modCfg_pdasetting.Name = this.tbxKeyName.Text.Trim();
			modCfg_pdasetting.Type = this.tbxKeyCode.Text.Trim();
			modCfg_pdasetting.Remark = this.tbxRemark.Text.Trim();
			bool flag = !DalCfg_pdasetting.Instance.AddNoReturn(modCfg_pdasetting);
			bool result;
			if (flag)
			{
				base.ShowMsg(Messages.AddFalse, "", "");
				result = false;
			}
			else
			{
				result = true;
			}
			return result;
		}

		// Token: 0x0600023E RID: 574 RVA: 0x0003FCC4 File Offset: 0x0003DEC4
		private bool TextCheck()
		{
			bool flag = string.IsNullOrWhiteSpace(this.tbxKeyCode.Text);
			bool result;
			if (flag)
			{
				base.ShowMsg(Messages.KeyCodeNull, "", "");
				result = false;
			}
			else
			{
				double num;
				bool flag2 = !double.TryParse(this.tbxKeyValue.Text.Trim(), out num);
				if (flag2)
				{
					base.ShowMsg("ValueNumber", "", "");
					result = false;
				}
				else
				{
					result = true;
				}
			}
			return result;
		}

		// Token: 0x040003F5 RID: 1013
		private ModCfg_pdasetting _mod = new ModCfg_pdasetting();
	}
}
