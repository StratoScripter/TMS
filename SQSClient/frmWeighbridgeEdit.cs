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
	// Token: 0x0200005D RID: 93
	public partial class frmWeighbridgeEdit : BaseDialogForm
	{
		// Token: 0x06000471 RID: 1137 RVA: 0x00070490 File Offset: 0x0006E690
		public frmWeighbridgeEdit(string text, BaseForm.FormActtion act, int id, string dir)
		{
			this.InitializeComponent();
			this.SetText(this);
			this.Text = text;
			this._Act = act;
			this._CurrentId = id;
			this._Direct = dir;
		}

		// Token: 0x06000472 RID: 1138 RVA: 0x000704E4 File Offset: 0x0006E6E4
		private void frmWeighbridgeEdit_Load(object sender, EventArgs e)
		{
			this.InitControl();
			this.LoadData();
		}

		// Token: 0x06000473 RID: 1139 RVA: 0x000704F5 File Offset: 0x0006E6F5
		private void InitControl()
		{
			this.cmbModeType.BindDataSouce(BaseForm.GetEnumModelList<ModeType>(), "Name", "Name", "Value");
		}

		// Token: 0x06000474 RID: 1140 RVA: 0x00070518 File Offset: 0x0006E718
		protected override void LoadData()
		{
			bool flag = BaseForm.FormActtion.Modify == this._Act;
			if (flag)
			{
				this._mod = DalCfg_weighbridge.Instance.GetModel(this._CurrentId);
				bool flag2 = this._mod == null;
				if (flag2)
				{
					base.ShowMsg(Messages.ObjNonExist, "", "");
					base.Close();
				}
				else
				{
					this.txtName.Text = this._mod.Name;
					this.iInputCode.Value = this._mod.Code;
					this.cmbModeType.Text = this._mod.ModeType;
					this.txtDBConn.Text = this._mod.ConnString;
					this.txtTableName.Text = this._mod.TableName;
					this.txtTruckItem.Text = this._mod.TruckItem;
					this.txtFirstTimeItem.Text = this._mod.FirstTimeItem;
					this.txtSecondTimeItem.Text = this._mod.SecondTimeItem;
					this.txtFirstWeightItem.Text = this._mod.FirstWeightItem;
					this.txtSecondWeightItem.Text = this._mod.SecondWeightItem;
					this.chkEnable.Checked = this._mod.Enable;
					this.rtxtRemark.Text = this._mod.Remark;
				}
			}
		}

		// Token: 0x06000475 RID: 1141 RVA: 0x00070698 File Offset: 0x0006E898
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

		// Token: 0x06000476 RID: 1142 RVA: 0x000706E8 File Offset: 0x0006E8E8
		private bool Add()
		{
			this._mod.Name = this.txtName.Text.Trim();
			this._mod.Code = this.iInputCode.Value;
			this._mod.ModeType = this.cmbModeType.Text;
			this._mod.ConnString = this.txtDBConn.Text.Trim();
			this._mod.TableName = this.txtTableName.Text;
			this._mod.TruckItem = this.txtTruckItem.Text;
			this._mod.FirstTimeItem = this.txtFirstTimeItem.Text;
			this._mod.SecondTimeItem = this.txtSecondTimeItem.Text;
			this._mod.FirstWeightItem = this.txtFirstWeightItem.Text;
			this._mod.SecondWeightItem = this.txtSecondWeightItem.Text;
			this._mod.Time = DateTime.Now;
			this._mod.Enable = this.chkEnable.Checked;
			this._mod.Remark = this.rtxtRemark.Text.Trim();
			this._mod.PinYinMa = this._mod.Name.GetFirstPinyin();
			bool flag = base.IsExist("cfg_weighbridge", "Name", this._mod.Name, SqlDbType.NVarChar);
			bool result;
			if (flag)
			{
				base.ShowMsg(Messages.WeighbridgeHaved, "", "");
				this.txtName.Focus();
				result = false;
			}
			else
			{
				bool flag2 = base.IsExist("cfg_weighbridge", "Code", this._mod.Code, SqlDbType.NVarChar);
				if (flag2)
				{
					base.ShowMsg(Messages.WeighbridgeCodeHaved, "", "");
					this.iInputCode.Focus();
					result = false;
				}
				else
				{
					int num = DalCfg_weighbridge.Instance.Add(this._mod);
					bool flag3 = num <= 0;
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
			}
			return result;
		}

		// Token: 0x06000477 RID: 1143 RVA: 0x00070944 File Offset: 0x0006EB44
		private bool Modify()
		{
			ModCfg_weighbridge oldValue = this._mod.Clone() as ModCfg_weighbridge;
			this._mod.Name = this.txtName.Text.Trim();
			this._mod.Code = this.iInputCode.Value;
			this._mod.ModeType = this.cmbModeType.Text;
			this._mod.ConnString = this.txtDBConn.Text.Trim();
			this._mod.TableName = this.txtTableName.Text;
			this._mod.TruckItem = this.txtTruckItem.Text;
			this._mod.FirstTimeItem = this.txtFirstTimeItem.Text;
			this._mod.SecondTimeItem = this.txtSecondTimeItem.Text;
			this._mod.FirstWeightItem = this.txtFirstWeightItem.Text;
			this._mod.SecondWeightItem = this.txtSecondWeightItem.Text;
			this._mod.Enable = this.chkEnable.Checked;
			this._mod.Remark = this.rtxtRemark.Text.Trim();
			this._mod.PinYinMa = this._mod.Name.GetFirstPinyin();
			bool flag = base.IsExistOutSelf("cfg_weighbridge", "Name", this._mod.Name, SqlDbType.NVarChar, this._CurrentId);
			bool result;
			if (flag)
			{
				base.ShowMsg(Messages.WeighbridgeHaved, "", "");
				this.txtName.Focus();
				result = false;
			}
			else
			{
				bool flag2 = base.IsExistOutSelf("cfg_weighbridge", "Code", this._mod.Code, SqlDbType.NVarChar, this._CurrentId);
				if (flag2)
				{
					base.ShowMsg(Messages.WeighbridgeCodeHaved, "", "");
					this.iInputCode.Focus();
					result = false;
				}
				else
				{
					bool flag3 = !DalCfg_weighbridge.Instance.Update(this._mod);
					if (flag3)
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
			return result;
		}

		// Token: 0x06000478 RID: 1144 RVA: 0x00070BA8 File Offset: 0x0006EDA8
		private bool TextCheck()
		{
			bool flag = string.IsNullOrWhiteSpace(this.txtName.Text);
			bool result;
			if (flag)
			{
				base.ShowMsg(Messages.WeighbridgeNull, "", "");
				this.txtName.Focus();
				result = false;
			}
			else
			{
				result = true;
			}
			return result;
		}

		// Token: 0x06000479 RID: 1145 RVA: 0x00070BF8 File Offset: 0x0006EDF8
		private void cmbModeType_TextChanged(object sender, EventArgs e)
		{
			bool flag = this.cmbModeType.Text == ModeType.Access.ToString();
			if (flag)
			{
				this.txtDBConn.Text = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=toledo.mdb;Jet OLEDB:Database Password=MTCT_VHBU;";
			}
			else
			{
				bool flag2 = this.cmbModeType.Text == ModeType.SQL.ToString();
				if (flag2)
				{
					this.txtDBConn.Text = "Data Source=localhost;User ID=toledo;Password=supconauto;Initial Catalog=toledo;";
				}
				else
				{
					bool flag3 = this.cmbModeType.Text == ModeType.MySQL.ToString();
					if (flag3)
					{
						this.txtDBConn.Text = "Data Source=localhost;port=3307;User ID=toledo;Password=supconauto;Database=toledo;charset=utf8;";
					}
				}
			}
		}

		// Token: 0x040007B4 RID: 1972
		private ModCfg_weighbridge _mod = new ModCfg_weighbridge();
	}
}
