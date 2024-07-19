using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Base;
using DAL.Base.SQSConfig;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using DevComponents.DotNetBar.Layout;
using DevComponents.Editors.DateTimeAdv;
using Model;
using Model.SQSConfig;
using SQSClient.Properties;

namespace SQSClient
{
	// Token: 0x02000048 RID: 72
	public partial class frmRdRecordEdit : BaseDialogForm
	{
		// Token: 0x06000358 RID: 856 RVA: 0x00052E90 File Offset: 0x00051090
		public frmRdRecordEdit(string text, BaseForm.FormActtion act, int id, string dir, string billVouchType)
		{
			this.InitializeComponent();
			this.SetText(this);
			this.Text = text;
			this._Act = act;
			this._CurrentId = id;
			this._Direct = dir;
			this._BillVouchType = billVouchType;
		}

		// Token: 0x06000359 RID: 857 RVA: 0x00052EF7 File Offset: 0x000510F7
		private void frmRdRecordEdit_Load(object sender, EventArgs e)
		{
			this.InitControl();
			this.LoadData();
		}

		// Token: 0x0600035A RID: 858 RVA: 0x00052F08 File Offset: 0x00051108
		private void InitControl()
		{
			this.tInputChkDate.Value = (this.tInputARVDate.Value = DateTime.Now);
			BaseForm.EnumModel enumModel = new BaseForm.EnumModel();
			enumModel.Name = "All";
			enumModel.Description = ShowWords.ReplaceText("All");
			enumModel.Value = -1;
			List<BaseForm.EnumModel> list = new List<BaseForm.EnumModel>();
			list.Add(enumModel);
			list.AddRange(BaseForm.GetEnumModelList<RdRecordStatus>());
			BaseForm.BindDataSouce(this.cmbRdStatus, list, "Description", "Value");
			List<BaseForm.EnumModel> list2 = new List<BaseForm.EnumModel>();
			list2.Add(enumModel);
			list2.AddRange(BaseForm.GetEnumModelList<RdRecordFlag>());
			BaseForm.BindDataSouce(this.cmbRdFlag, list2, "Description", "Value");
			List<BaseForm.EnumModel> list3 = new List<BaseForm.EnumModel>();
			list3.Add(enumModel);
			list3.AddRange(BaseForm.GetEnumModelList<RdBusType>());
			BaseForm.BindDataSouce(this.cmbBusType, list3, "Description", "Value");
			this.cmbWhName.BindDataSouce(DalCs_warehouse.Instance.GetAllList(), "WhName", "PinYinMa", "WhCode");
			this.cmbWhName.SelectedIndex = 0;
			this.txtVouchType.ReadOnly = true;
		}

		// Token: 0x0600035B RID: 859 RVA: 0x0005303C File Offset: 0x0005123C
		protected override void LoadData()
		{
			bool flag = BaseForm.FormActtion.Modify == this._Act;
			if (flag)
			{
				this._mod = DalCs_rdrecord.Instance.GetModel(this._CurrentId);
				bool flag2 = this._mod == null;
				if (flag2)
				{
					base.ShowMsg(Messages.ObjNonExist, "", "");
					base.Close();
				}
				else
				{
					this.txtRdCode.Text = this._mod.RdCode;
					this.txtVouchType.Text = this._mod.VouchType;
					this.cmbBusType.SelectedValue = Convert.ToInt32(this._mod.BusType);
					this.txtSource.Text = this._mod.Source;
					this.cmbRdFlag.SelectedValue = this._mod.RdFlag;
					this.cmbRdStatus.SelectedValue = this._mod.RdStatus;
					this.cmbWhName.SelectedValue = this._mod.WhCode;
					this.txtDepName.Text = this._mod.DepName;
					this.tInputChkDate.Value = this._mod.CreateDate;
					this.tInputARVDate.Value = this._mod.ARVDate;
					this.txtShipAddress.Text = this._mod.ShipAddress;
					this.txtRdPerson.Text = this._mod.RdPerson;
					this.txtMaker.Text = this._mod.Maker;
					this.txtHandler.Text = this._mod.Handler;
					this.txtAccounter.Text = this._mod.Accounter;
					this.rtbMemo.Text = this._mod.Memo;
				}
			}
			else
			{
				string danHao = DanHaoHelper.Instance().GetDanHao(1);
				bool flag3 = danHao.Length == 0;
				if (flag3)
				{
					base.ShowMsg(Messages.ObjNonExist, "", "");
					base.Close();
				}
				this.txtRdCode.Text = danHao;
				this.txtMaker.Text = GlobalKey.UserName;
				this.txtVouchType.Text = this._BillVouchType;
			}
		}

		// Token: 0x0600035C RID: 860 RVA: 0x00053298 File Offset: 0x00051498
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

		// Token: 0x0600035D RID: 861 RVA: 0x000532E8 File Offset: 0x000514E8
		private void BindControl()
		{
			this._mod.RdCode = this.txtRdCode.Text.Trim();
			this._mod.VouchType = this.txtVouchType.Text;
			this._mod.BusType = this.cmbBusType.SelectedValue.ToString();
			this._mod.Source = this.txtSource.Text;
			this._mod.RdFlag = Convert.ToInt32(this.cmbRdFlag.SelectedValue);
			this._mod.RdStatus = Convert.ToInt32(this.cmbRdStatus.SelectedValue);
			this._mod.WhCode = this.cmbWhName.SelectedValue.ToString();
			this._mod.DepName = this.txtDepName.Text.Trim();
			this._mod.CreateDate = DateTime.Now;
			this._mod.ARVDate = this.tInputARVDate.Value;
			this._mod.ChkDate = this.tInputChkDate.Value;
			this._mod.ShipAddress = this.txtShipAddress.Text.Trim();
			this._mod.RdPerson = this.txtRdPerson.Text;
			this._mod.Maker = this.txtMaker.Text;
			this._mod.Handler = this.txtHandler.Text;
			this._mod.Accounter = this.txtAccounter.Text;
			this._mod.Memo = this.rtbMemo.Text;
		}

		// Token: 0x0600035E RID: 862 RVA: 0x0005349C File Offset: 0x0005169C
		private bool Add()
		{
			this.BindControl();
			this._mod.RdIndex = DalCs_rdrecord.Instance.GetMaxRdIndex() + 1;
			bool flag = !DalCs_rdrecord.Instance.AddNoReturn(this._mod);
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

		// Token: 0x0600035F RID: 863 RVA: 0x00053528 File Offset: 0x00051728
		private bool Modify()
		{
			ModCs_rdrecord oldValue = this._mod.Clone() as ModCs_rdrecord;
			this.BindControl();
			bool flag = !DalCs_rdrecord.Instance.Update(this._mod);
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

		// Token: 0x06000360 RID: 864 RVA: 0x000535AC File Offset: 0x000517AC
		private bool TextCheck()
		{
			return true;
		}

		// Token: 0x0400055E RID: 1374
		private string _BillVouchType = string.Empty;

		// Token: 0x0400055F RID: 1375
		private ModCs_rdrecord _mod = new ModCs_rdrecord();
	}
}
