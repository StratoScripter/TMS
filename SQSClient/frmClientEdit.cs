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
	// Token: 0x02000089 RID: 137
	public partial class frmClientEdit : BaseDialogForm
	{
		// Token: 0x06000772 RID: 1906 RVA: 0x000B8E70 File Offset: 0x000B7070
		public frmClientEdit(string text, BaseForm.FormActtion act, int id, string dir)
		{
			this.InitializeComponent();
			this.SetText(this);
			this.Text = text;
			this._Act = act;
			this._CurrentId = id;
			this._Direct = dir;
		}

		// Token: 0x06000773 RID: 1907 RVA: 0x000B8ECF File Offset: 0x000B70CF
		private void frmClientEdit_Load(object sender, EventArgs e)
		{
			this.InitControl();
			this.LoadData();
		}

		// Token: 0x06000774 RID: 1908 RVA: 0x00003040 File Offset: 0x00001240
		private void InitControl()
		{
		}

		// Token: 0x06000775 RID: 1909 RVA: 0x000B8EE0 File Offset: 0x000B70E0
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
					this.tbxClientCode.Text = this._mod.Code;
					this.tbxPerson.Text = this._mod.Person;
					this.tbxPhone.Text = this._mod.PhoneNum;
					this.rtbRemark.Text = this._mod.Remark;
				}
			}
		}

		// Token: 0x06000776 RID: 1910 RVA: 0x000B8FEC File Offset: 0x000B71EC
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

		// Token: 0x06000777 RID: 1911 RVA: 0x000B903C File Offset: 0x000B723C
		private bool Add()
		{
			this._mod.Name = this.tbxName.Text.Trim();
			this._mod.Licence = this.txtLicence.Text.Trim();
			this._mod.Address = this.tbxAddr.Text.Trim();
			this._mod.Person = this.tbxPerson.Text.Trim();
			this._mod.Code = this.tbxClientCode.Text.Trim();
			this._mod.PhoneNum = this.tbxPhone.Text.Trim();
			this._mod.Remark = this.rtbRemark.Text.Trim();
			this._mod.PinYinMa = this._mod.Name.GetFirstPinyin();
			bool flag = base.IsExist("t_client", "Name", this._mod.Name, SqlDbType.NVarChar);
			bool result;
			if (flag)
			{
				base.ShowMsg(Messages.ClientpartHaved, "", "");
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

		// Token: 0x06000778 RID: 1912 RVA: 0x000B91D8 File Offset: 0x000B73D8
		private bool Modify()
		{
			ModT_client oldValue = this._mod.Clone() as ModT_client;
			this._mod.Name = this.tbxName.Text.Trim();
			this._mod.Licence = this.txtLicence.Text.Trim();
			this._mod.Address = this.tbxAddr.Text.Trim();
			this._mod.Person = this.tbxPerson.Text.Trim();
			this._mod.Code = this.tbxClientCode.Text.Trim();
			this._mod.PhoneNum = this.tbxPhone.Text.Trim();
			this._mod.Remark = this.rtbRemark.Text.Trim();
			this._mod.PinYinMa = this._mod.Name.GetFirstPinyin();
			bool flag = base.IsExistOutSelf("t_client", "Name", this._mod.Name, SqlDbType.NVarChar, this._CurrentId);
			bool result;
			if (flag)
			{
				base.ShowMsg(Messages.ClientpartHaved, "", "");
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

		// Token: 0x06000779 RID: 1913 RVA: 0x000B9384 File Offset: 0x000B7584
		private bool TextCheck()
		{
			bool flag = string.IsNullOrWhiteSpace(this.tbxName.Text);
			bool result;
			if (flag)
			{
				base.ShowMsg(Messages.ClientpartNull, "", "");
				this.tbxName.Focus();
				result = false;
			}
			else
			{
				bool flag2 = !string.IsNullOrWhiteSpace(this.tbxPhone.Text.Trim()) && !RegexHelper.IsMobilePhone(this.tbxPhone.Text.Trim()) && !RegexHelper.IsPhone(this.tbxPhone.Text.Trim());
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

		// Token: 0x04000CB1 RID: 3249
		private ModT_client _mod = new ModT_client();

		// Token: 0x04000CB2 RID: 3250
		private DAL.SQLServer.SQSConfig.DalT_client _Dal = DAL.Base.SQSConfig.DalT_client.Instance;
	}
}
