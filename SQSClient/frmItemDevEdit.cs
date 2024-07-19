using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Base;
using DAL.Base.SQSConfig;
using DAL.SQLServer.SQSConfig;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using DevComponents.DotNetBar.Layout;
using DevComponents.Editors;
using Model;
using Model.SQSConfig;
using SQSClient.Properties;

namespace SQSClient
{
	// Token: 0x02000081 RID: 129
	public partial class frmItemDevEdit : BaseDialogForm
	{
		// Token: 0x06000708 RID: 1800 RVA: 0x000AED80 File Offset: 0x000ACF80
		public frmItemDevEdit(string text, BaseForm.FormActtion act, int id, string dir)
		{
			this.InitializeComponent();
			this.SetText(this);
			this.Text = text;
			this._Act = act;
			this._CurrentId = id;
			this._Direct = dir;
		}

		// Token: 0x06000709 RID: 1801 RVA: 0x000AEDDF File Offset: 0x000ACFDF
		private void frmItemDevEdit_Load(object sender, EventArgs e)
		{
			this.InitControl();
			this.LoadData();
		}

		// Token: 0x0600070A RID: 1802 RVA: 0x000AEDF0 File Offset: 0x000ACFF0
		private void InitControl()
		{
			this.btnSave.Shortcuts.Add(eShortcut.CtrlEnter);
			this.cmbDataStyle.Items.Clear();
			this.cmbDataStyle.Items.Add("Floating");
			this.cmbDataStyle.Items.Add("Boolean");
			this.cmbDataStyle.Items.Add("Int");
			this.cmbDataStyle.Items.Add("String");
			this.cmbWriteR.Items.Clear();
			this.cmbWriteR.Items.Add("Read");
			this.cmbWriteR.Items.Add("Write");
			this.cmbWriteR.Items.Add("Read-Write");
		}

		// Token: 0x0600070B RID: 1803 RVA: 0x000AEED0 File Offset: 0x000AD0D0
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
					this.txtItemCode.Text = this._mod.ItemCode;
					this.txtPara.Text = this._mod.Para;
					this.txtItemDesc.Text = this._mod.ItemDesc;
					this.iInputLuHao.Value = this._mod.LuHao;
					this.cmbDataStyle.Text = this._mod.DataStyle;
					this.cmbWriteR.Text = this._mod.WriteR;
					this.txtLinkAddr.Text = this._mod.LinkAddr;
					this.rtxtRemark.Text = this._mod.Remark;
					this.txtItemDesc.Enabled = false;
					this.txtPara.Enabled = false;
					this.iInputLuHao.Enabled = false;
					this.cmbDataStyle.Enabled = false;
					this.cmbWriteR.Enabled = false;
					this.rtxtRemark.Enabled = false;
				}
			}
			else
			{
				bool flag3 = this._Act == BaseForm.FormActtion.Add;
				if (flag3)
				{
					this.txtPara.Text = "PV";
				}
			}
		}

		// Token: 0x0600070C RID: 1804 RVA: 0x000AF064 File Offset: 0x000AD264
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

		// Token: 0x0600070D RID: 1805 RVA: 0x000AF0B4 File Offset: 0x000AD2B4
		private bool Add()
		{
			this._mod.ItemCode = this.txtItemCode.Text.Trim();
			this._mod.Para = this.txtPara.Text.Trim();
			this._mod.LuHao = this.iInputLuHao.Value;
			this._mod.DataStyle = this.cmbDataStyle.Text;
			this._mod.WriteR = this.cmbWriteR.Text;
			this._mod.LinkAddr = this.txtLinkAddr.Text;
			this._mod.ItemDesc = this.txtItemDesc.Text;
			this._mod.Remark = this.rtxtRemark.Text.Trim();
			bool flag = true;
			bool flag2 = this._Dal.IsExist(this._mod.ItemCode, this._mod.Para, this._mod.LuHao, 0, ref flag);
			bool result;
			if (flag2)
			{
				bool flag3 = flag;
				if (flag3)
				{
					base.ShowMsg(Messages.ItemHaved, "", "");
					result = false;
				}
				else
				{
					int num = this._Dal.Add(this._mod);
					bool flag4 = num <= 0;
					if (flag4)
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
			}
			else
			{
				base.ShowMsg(Messages.AddFalse, "", "");
				result = false;
			}
			return result;
		}

		// Token: 0x0600070E RID: 1806 RVA: 0x000AF26C File Offset: 0x000AD46C
		private bool Modify()
		{
			ModCfg_devitem oldValue = this._mod.Clone() as ModCfg_devitem;
			this._mod.ItemCode = this.txtItemCode.Text.Trim();
			this._mod.Para = this.txtPara.Text.Trim();
			this._mod.LinkAddr = this.txtLinkAddr.Text;
			bool flag = true;
			bool flag2 = this._Dal.IsExist(this._mod.ItemCode, this._mod.Para, this._mod.LuHao, this._CurrentId, ref flag);
			bool result;
			if (flag2)
			{
				bool flag3 = flag;
				if (flag3)
				{
					base.ShowMsg(Messages.ItemHaved, "", "");
					result = false;
				}
				else
				{
					bool flag4 = !this._Dal.Update(this._mod);
					if (flag4)
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
			}
			else
			{
				base.ShowMsg(Messages.ModifyFalse, "", "");
				result = false;
			}
			return result;
		}

		// Token: 0x0600070F RID: 1807 RVA: 0x000AF3BC File Offset: 0x000AD5BC
		private bool TextCheck()
		{
			bool flag = string.IsNullOrWhiteSpace(this.txtItemCode.Text);
			bool result;
			if (flag)
			{
				base.ShowMsg(Messages.CodeNull, "", "");
				result = false;
			}
			else
			{
				bool flag2 = string.IsNullOrWhiteSpace(this.txtPara.Text);
				if (flag2)
				{
					base.ShowMsg(Messages.ParaNull, "", "");
					result = false;
				}
				else
				{
					bool flag3 = string.IsNullOrWhiteSpace(this.cmbDataStyle.Text);
					if (flag3)
					{
						base.ShowMsg(Messages.PointTypeNull, "", "");
						result = false;
					}
					else
					{
						bool flag4 = string.IsNullOrWhiteSpace(this.cmbWriteR.Text);
						if (flag4)
						{
							base.ShowMsg(Messages.RWNull, "", "");
							result = false;
						}
						else
						{
							result = true;
						}
					}
				}
			}
			return result;
		}

		// Token: 0x04000C0B RID: 3083
		private ModCfg_devitem _mod = new ModCfg_devitem();

		// Token: 0x04000C0C RID: 3084
		protected DAL.SQLServer.SQSConfig.DalCfg_devitem _Dal = DAL.Base.SQSConfig.DalCfg_devitem.Instance;
	}
}
