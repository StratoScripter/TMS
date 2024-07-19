using System;
using System.Collections.Generic;
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
	// Token: 0x0200003D RID: 61
	public partial class frmOperatorEdit : BaseDialogForm
	{
		// Token: 0x060002CA RID: 714 RVA: 0x00048EC8 File Offset: 0x000470C8
		public frmOperatorEdit(string text, BaseForm.FormActtion act, int id)
		{
			this.InitializeComponent();
			this.SetText(this);
			this.Text = text;
			this._Act = act;
			this._CurrentId = id;
		}

		// Token: 0x060002CB RID: 715 RVA: 0x00048F2A File Offset: 0x0004712A
		private void frmOperatorEdit_Load(object sender, EventArgs e)
		{
			this.InitControl();
			this.LoadData();
		}

		// Token: 0x060002CC RID: 716 RVA: 0x00048F3C File Offset: 0x0004713C
		private void InitControl()
		{
			List<ModT_iccard> allList = DAL.Base.SQSConfig.DalT_iccard.Instance.GetAllList();
			this.cobICKard.BindDataSouce(allList, "CardNum", "CardNum", "Id");
		}

		// Token: 0x060002CD RID: 717 RVA: 0x00048F74 File Offset: 0x00047174
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
					this.tbxNum.Text = this._mod.OperatorNum;
					this.tbxNum.Enabled = false;
					this.tbxPwd.Text = this._mod.Password;
					this.tbxName.Text = this._mod.OperatorName;
					this.cobICKard.Text = this._mod.CardNum;
					this.rtbRemark.Text = this._mod.Remark;
					this.chkState.Checked = this._mod.State;
				}
			}
		}

		// Token: 0x060002CE RID: 718 RVA: 0x00049078 File Offset: 0x00047278
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

		// Token: 0x060002CF RID: 719 RVA: 0x000490C8 File Offset: 0x000472C8
		private bool Add()
		{
			this._mod.OperatorNum = this.tbxNum.Text.Trim();
			this._mod.Password = this.tbxPwd.Text.Trim();
			this._mod.OperatorName = this.tbxName.Text.Trim();
			this._mod.CardNum = this.cobICKard.Text.Trim();
			this._mod.Remark = this.rtbRemark.Text.Trim();
			this._mod.State = this.chkState.Checked;
			this._mod.PinYinMa = this._mod.OperatorName.GetFirstPinyin();
			bool flag = base.IsExist("t_operator", "OperatorName", this._mod.OperatorName, SqlDbType.NVarChar);
			bool result;
			if (flag)
			{
				base.ShowMsg(Messages.OperatorHaved, "", "");
				result = false;
			}
			else
			{
				bool flag2 = base.IsExist("t_operator", "OperatorNum", this._mod.OperatorNum, SqlDbType.NVarChar);
				if (flag2)
				{
					base.ShowMsg(Messages.OperatorNumHaved, "", "");
					result = false;
				}
				else
				{
					bool flag3 = !this._Dal.AddNoReturn(this._mod);
					if (flag3)
					{
						base.ShowMsg(Messages.AddFalse, "", "");
						result = false;
					}
					else
					{
						result = true;
					}
				}
			}
			return result;
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x00049248 File Offset: 0x00047448
		private bool Modify()
		{
			this._mod.OperatorNum = this.tbxNum.Text.Trim();
			this._mod.Password = this.tbxPwd.Text.Trim();
			this._mod.OperatorName = this.tbxName.Text.Trim();
			this._mod.CardNum = this.cobICKard.Text.Trim();
			this._mod.Remark = this.rtbRemark.Text.Trim();
			this._mod.State = this.chkState.Checked;
			this._mod.PinYinMa = this._mod.OperatorName.GetFirstPinyin();
			bool flag = !this._Dal.Update(this._mod);
			bool result;
			if (flag)
			{
				base.ShowMsg(Messages.ModifyFalse, "", "");
				result = false;
			}
			else
			{
				result = true;
			}
			return result;
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x00049350 File Offset: 0x00047550
		private bool TextCheck()
		{
			bool flag = string.IsNullOrWhiteSpace(this.tbxNum.Text) || this.tbxNum.Text.Length > 8 || !RegexHelper.IsNum(this.tbxNum.Text);
			bool result;
			if (flag)
			{
				base.ShowMsg(Messages.OperatorNumFormat, "", "");
				result = false;
			}
			else
			{
				bool flag2 = string.IsNullOrWhiteSpace(this.tbxPwd.Text) || this.tbxPwd.Text.Length > 8 || !RegexHelper.IsNum(this.tbxPwd.Text);
				if (flag2)
				{
					base.ShowMsg(Messages.OperatorPwdFormat, "", "");
					result = false;
				}
				else
				{
					bool flag3 = string.IsNullOrWhiteSpace(this.tbxName.Text) || this.tbxName.Text.Trim().Equals("无");
					if (flag3)
					{
						base.ShowMsg(Messages.OperatorNull, "", "");
						result = false;
					}
					else
					{
						string text = this.cobICKard.Text.Trim();
						bool flag4 = text != "";
						if (flag4)
						{
							bool flag5 = !base.IsExist("T_iccard", "CardNum", text, SqlDbType.NVarChar);
							if (flag5)
							{
								base.ShowMsg(Messages.ICHavent, "", "");
								return false;
							}
						}
						result = true;
					}
				}
			}
			return result;
		}

		// Token: 0x0400048E RID: 1166
		private ModT_operator _mod = new ModT_operator();

		// Token: 0x0400048F RID: 1167
		private DAL.SQLServer.SQSConfig.DalT_operator _Dal = DAL.Base.SQSConfig.DalT_operator.Instance;

		// Token: 0x04000490 RID: 1168
		private DAL.SQLServer.SQSConfig.DalT_iccard _Dal1 = DAL.Base.SQSConfig.DalT_iccard.Instance;
	}
}
