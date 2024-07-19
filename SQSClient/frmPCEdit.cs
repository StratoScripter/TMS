using System;
using System.ComponentModel;
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
	// Token: 0x02000084 RID: 132
	public partial class frmPCEdit : BaseDialogForm
	{
		// Token: 0x06000729 RID: 1833 RVA: 0x000B2500 File Offset: 0x000B0700
		public frmPCEdit(string text, BaseForm.FormActtion act, int id, string dir)
		{
			this.InitializeComponent();
			this.SetText(this);
			this.Text = text;
			this._Act = act;
			this._CurrentId = id;
			this._Direct = dir;
		}

		// Token: 0x0600072A RID: 1834 RVA: 0x000B255F File Offset: 0x000B075F
		private void frmPCEdit_Load(object sender, EventArgs e)
		{
			this.InitControl();
			this.LoadData();
		}

		// Token: 0x0600072B RID: 1835 RVA: 0x000B2570 File Offset: 0x000B0770
		private void InitControl()
		{
			this.cmbType.Items.Clear();
			BaseForm.BindDataSouce(this.cmbType, BaseForm.GetEnumModelList<PCType>(), "Description", "Value");
			this.cmbType.SelectedIndex = 0;
		}

		// Token: 0x0600072C RID: 1836 RVA: 0x000B25AC File Offset: 0x000B07AC
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
					this.tbxIP.Text = this._mod.IPAddr;
					this.cmbType.SelectedValue = this._mod.PCType;
					this.rtbRemark.Text = this._mod.Remark;
				}
			}
		}

		// Token: 0x0600072D RID: 1837 RVA: 0x000B2674 File Offset: 0x000B0874
		private bool Add()
		{
			this._mod.Name = this.tbxName.Text.Trim();
			this._mod.IPAddr = this.tbxIP.Text.Trim();
			this._mod.PCType = (int)this.cmbType.SelectedValue;
			this._mod.Remark = this.rtbRemark.Text.Trim();
			this._mod.PinYinMa = this._mod.Name.GetFirstPinyin();
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

		// Token: 0x0600072E RID: 1838 RVA: 0x000B2774 File Offset: 0x000B0974
		private bool Modify()
		{
			ModCfg_pc oldValue = this._mod.Clone() as ModCfg_pc;
			this._mod.Name = this.tbxName.Text.Trim();
			this._mod.IPAddr = this.tbxIP.Text.Trim();
			this._mod.PCType = (int)this.cmbType.SelectedValue;
			this._mod.Remark = this.rtbRemark.Text.Trim();
			this._mod.PinYinMa = this._mod.Name.GetFirstPinyin();
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

		// Token: 0x0600072F RID: 1839 RVA: 0x000B2880 File Offset: 0x000B0A80
		private bool TextCheck()
		{
			bool flag = string.IsNullOrWhiteSpace(this.tbxName.Text);
			bool result;
			if (flag)
			{
				base.ShowMsg(Messages.PCNull, "", "");
				this.tbxName.Focus();
				result = false;
			}
			else
			{
				bool flag2 = string.IsNullOrWhiteSpace(this.tbxIP.Text);
				if (flag2)
				{
					base.ShowMsg(Messages.IPNull, "", "");
					this.tbxIP.Focus();
					result = false;
				}
				else
				{
					bool flag3 = !RegexHelper.IsIPv4(this.tbxIP.Text.Trim());
					if (flag3)
					{
						base.ShowMsg(Messages.IPFormat, "", "");
						this.tbxIP.Focus();
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

		// Token: 0x06000730 RID: 1840 RVA: 0x000B2954 File Offset: 0x000B0B54
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

		// Token: 0x04000C41 RID: 3137
		private ModCfg_pc _mod = new ModCfg_pc();

		// Token: 0x04000C42 RID: 3138
		private DAL.SQLServer.SQSConfig.DalCfg_pc _Dal = DAL.Base.SQSConfig.DalCfg_pc.Instance;
	}
}
