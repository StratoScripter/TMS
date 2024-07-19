using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
	// Token: 0x02000097 RID: 151
	public partial class frmSettlepartEdit : BaseDialogForm
	{
		// Token: 0x06000866 RID: 2150 RVA: 0x000CEC9C File Offset: 0x000CCE9C
		public frmSettlepartEdit(string text, BaseForm.FormActtion act, int id, string dir)
		{
			this.InitializeComponent();
			this.SetText(this);
			this.Text = text;
			this._Act = act;
			this._CurrentId = id;
			this._Direct = dir;
		}

		// Token: 0x06000867 RID: 2151 RVA: 0x000CECFB File Offset: 0x000CCEFB
		private void frmSettlepartEdit_Load(object sender, EventArgs e)
		{
			this.InitControl();
			this.LoadData();
		}

		// Token: 0x06000868 RID: 2152 RVA: 0x00003040 File Offset: 0x00001240
		private void InitControl()
		{
		}

		// Token: 0x06000869 RID: 2153 RVA: 0x000CED0C File Offset: 0x000CCF0C
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
					this.tbxName.Text = this._mod.Name;
					this.txtLicence.Text = this._mod.Licence;
					this.tbxAddr.Text = this._mod.Address;
					this.tbxPerson.Text = this._mod.Person;
					this.tbxPhone.Text = this._mod.PhoneNum;
					this.rtbRemark.Text = this._mod.Remark;
				}
			}
		}

		// Token: 0x0600086A RID: 2154 RVA: 0x000CEE00 File Offset: 0x000CD000
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

		// Token: 0x0600086B RID: 2155 RVA: 0x000CEE50 File Offset: 0x000CD050
		private bool Add()
		{
			this._mod.Name = this.tbxName.Text.Trim();
			this._mod.Licence = this.txtLicence.Text.Trim();
			this._mod.Address = this.tbxAddr.Text.Trim();
			this._mod.Person = this.tbxPerson.Text.Trim();
			this._mod.PhoneNum = this.tbxPhone.Text.Trim();
			this._mod.Remark = this.rtbRemark.Text.Trim();
			this._mod.PinYinMa = this._mod.Name.GetFirstPinyin();
			bool flag = base.IsExist("t_settlepart", "Name", this._mod.Name, SqlDbType.NVarChar);
			bool result;
			if (flag)
			{
				base.ShowMsg(Messages.SettlepartHaved, "", "");
				this.tbxName.Focus();
				result = false;
			}
			else
			{
				int num = this._Dal.Add(this._mod);
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

		// Token: 0x0600086C RID: 2156 RVA: 0x000CEFD0 File Offset: 0x000CD1D0
		private bool Modify()
		{
			ModT_settlepart oldValue = this._mod.Clone() as ModT_settlepart;
			this._mod.Name = this.tbxName.Text.Trim();
			this._mod.Licence = this.txtLicence.Text.Trim();
			this._mod.Address = this.tbxAddr.Text.Trim();
			this._mod.Person = this.tbxPerson.Text.Trim();
			this._mod.PhoneNum = this.tbxPhone.Text.Trim();
			this._mod.Remark = this.rtbRemark.Text.Trim();
			bool flag = base.IsExistOutSelf("t_settlepart", "Name", this._mod.Name, SqlDbType.NVarChar, this._CurrentId);
			bool result;
			if (flag)
			{
				base.ShowMsg(Messages.SettlepartHaved, "", "");
				this.tbxName.Focus();
				result = false;
			}
			else
			{
				bool flag2 = !this._Dal.Update(this._mod);
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

		// Token: 0x0600086D RID: 2157 RVA: 0x000CF144 File Offset: 0x000CD344
		private bool TextCheck()
		{
			bool flag = string.IsNullOrWhiteSpace(this.tbxName.Text);
			bool result;
			if (flag)
			{
				base.ShowMsg(Messages.SettlepartNull, "", "");
				this.tbxName.Focus();
				result = false;
			}
			else
			{
				bool flag2 = !string.IsNullOrWhiteSpace(this.tbxPhone.Text) && !RegexHelper.IsMobilePhone(this.tbxPhone.Text.Trim()) && !RegexHelper.IsPhone(this.tbxPhone.Text.Trim());
				if (flag2)
				{
					base.ShowMsg(Messages.PhoneNumFormat, "", "");
					this.tbxPhone.Focus();
					result = false;
				}
				else
				{
					result = true;
				}
			}
			return result;
		}

		// Token: 0x04000E4F RID: 3663
		private ModT_settlepart _mod = new ModT_settlepart();

		// Token: 0x04000E50 RID: 3664
		private DAL.SQLServer.SQSConfig.DalT_settlepart _Dal = DAL.Base.SQSConfig.DalT_settlepart.Instance;
	}
}
