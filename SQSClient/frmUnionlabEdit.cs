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
using DevComponents.Editors;
using DevComponents.Editors.DateTimeAdv;
using Model;
using Model.SQSConfig;
using SQSClient.Properties;

namespace SQSClient
{
	// Token: 0x02000099 RID: 153
	public partial class frmUnionlabEdit : BaseDialogForm
	{
		// Token: 0x0600087B RID: 2171 RVA: 0x000D0D20 File Offset: 0x000CEF20
		public frmUnionlabEdit(string text, BaseForm.FormActtion act, int id, string dir)
		{
			this.InitializeComponent();
			this.SetText(this);
			this.Text = text;
			this._Act = act;
			this._CurrentId = id;
			this._Direct = dir;
		}

		// Token: 0x0600087C RID: 2172 RVA: 0x000D0D74 File Offset: 0x000CEF74
		private void frmUnionlabEdit_Load(object sender, EventArgs e)
		{
			this.InitControl();
			this.LoadData();
		}

		// Token: 0x0600087D RID: 2173 RVA: 0x000D0D88 File Offset: 0x000CEF88
		private void InitControl()
		{
			BaseForm.EnumModel enumModel = new BaseForm.EnumModel();
			enumModel.Name = "All";
			enumModel.Description = ShowWords.ReplaceText("All");
			enumModel.Value = -1;
			List<BaseForm.EnumModel> list = new List<BaseForm.EnumModel>();
			list.AddRange(BaseForm.GetEnumModelList<RdBusType>());
			BaseForm.BindDataSouce(this.cmbBusinessType, list, "Description", "Value");
			List<BaseForm.EnumModel> list2 = new List<BaseForm.EnumModel>();
			list2.AddRange(BaseForm.GetEnumModelList<LabStatus>());
			BaseForm.BindDataSouce(this.cmbLabStatus, list2, "Description", "Value");
			List<BaseForm.EnumModel> list3 = new List<BaseForm.EnumModel>();
			list3.AddRange(BaseForm.GetEnumModelList<CheckResult>());
			BaseForm.BindDataSouce(this.cmbLabResult, list3, "Description", "Value");
			List<BaseForm.EnumModel> list4 = new List<BaseForm.EnumModel>();
			list4.AddRange(BaseForm.GetEnumModelList<UnionLabStatus>());
			BaseForm.BindDataSouce(this.cmbUnionStatus, list4, "Description", "Value");
			this.iInputUnionLabIndex.Enabled = false;
		}

		// Token: 0x0600087E RID: 2174 RVA: 0x000D0E7C File Offset: 0x000CF07C
		protected override void LoadData()
		{
			bool flag = BaseForm.FormActtion.Modify == this._Act;
			if (flag)
			{
				this._mod = DalT_unionlab.Instance.GetModel(this._CurrentId);
				bool flag2 = this._mod == null;
				if (flag2)
				{
					base.ShowMsg(Messages.ObjNonExist, "", "");
					base.Close();
				}
				else
				{
					this.txtUnionLabCode.Text = this._mod.UnionLabCode;
					this.txtUnionLabName.Text = this._mod.UnionLabName;
					this.iInputUnionLabIndex.Value = this._mod.UnionLabIndex;
					this.cmbBusinessType.SelectedValue = Convert.ToInt32(this._mod.BusinessType);
					this.txtLabMan.Text = this._mod.UnionLabMan;
					this.cmbLabStatus.SelectedValue = this._mod.UnionLabStatus;
					this.cmbLabResult.SelectedValue = this._mod.UnionLabResult;
					this.cmbUnionStatus.SelectedValue = this._mod.UnionStatus;
					this.iInputLabCount.Value = this._mod.UnionLabCount;
					this.tInputUnionLabTime.Value = this._mod.UnionLabTime;
					this.tInputEffectiveTime.Value = this._mod.UnionEffectiveTime;
					this.nudWaterDeduct.Value = (double)this._mod.WaterDeduct;
					this.nudImpurityDeduct.Value = (double)this._mod.ImpurityDeduct;
					this.nudOtherDeduct.Value = (double)this._mod.OtherDeduct;
					this.txtDeductInfo.Text = this._mod.DeductInfo;
					this.txtUnionChemist1.Text = this._mod.UnionChemist1;
					this.txtUnionChemist2.Text = this._mod.UnionChemist2;
					this.txtReviewer.Text = this._mod.Reviewer;
					this.txtSampler.Text = this._mod.Sampler;
					this.rtbMemo.Text = this._mod.Memo;
				}
			}
			else
			{
				string danHao = DanHaoHelper.Instance().GetDanHao(4);
				bool flag3 = danHao.Length == 0;
				if (flag3)
				{
					base.ShowMsg(Messages.ObjNonExist, "", "");
					base.Close();
				}
				this.txtUnionLabCode.Text = danHao;
				this.iInputUnionLabIndex.Value = DalT_unionlab.Instance.GetMaxUnionLabIndex() + 1;
				this.tInputUnionLabTime.Value = (this.tInputEffectiveTime.Value = DateTime.Now);
				this.nudWaterDeduct.Value = (this.nudImpurityDeduct.Value = (this.nudOtherDeduct.Value = 100.0));
			}
		}

		// Token: 0x0600087F RID: 2175 RVA: 0x000D119C File Offset: 0x000CF39C
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

		// Token: 0x06000880 RID: 2176 RVA: 0x000D11EC File Offset: 0x000CF3EC
		private void BindControl()
		{
			this._mod.UnionLabCode = this.txtUnionLabCode.Text.Trim();
			this._mod.UnionLabName = this.txtUnionLabName.Text.Trim();
			this._mod.UnionLabIndex = this.iInputUnionLabIndex.Value;
			this._mod.BusinessType = Convert.ToInt32(this.cmbBusinessType.SelectedValue);
			this._mod.UnionLabMan = this.txtLabMan.Text.Trim();
			this._mod.UnionLabStatus = Convert.ToInt32(this.cmbLabStatus.SelectedValue);
			this._mod.UnionLabResult = Convert.ToInt32(this.cmbLabResult.SelectedValue);
			this._mod.UnionStatus = Convert.ToInt32(this.cmbUnionStatus.SelectedValue);
			this._mod.UnionLabCount = this.iInputLabCount.Value;
			this._mod.UnionLabTime = this.tInputUnionLabTime.Value;
			this._mod.UnionEffectiveTime = this.tInputEffectiveTime.Value;
			this._mod.WaterDeduct = (decimal)this.nudWaterDeduct.Value;
			this._mod.ImpurityDeduct = (decimal)this.nudImpurityDeduct.Value;
			this._mod.OtherDeduct = (decimal)this.nudOtherDeduct.Value;
			this._mod.DeductInfo = this.txtDeductInfo.Text.Trim();
			this._mod.UnionChemist1 = this.txtUnionChemist1.Text.Trim();
			this._mod.UnionChemist2 = this.txtUnionChemist2.Text.Trim();
			this._mod.Reviewer = this.txtReviewer.Text.Trim();
			this._mod.Sampler = this.txtSampler.Text.Trim();
			this._mod.Memo = this.rtbMemo.Text.Trim();
		}

		// Token: 0x06000881 RID: 2177 RVA: 0x000D1418 File Offset: 0x000CF618
		private bool Add()
		{
			this.BindControl();
			this._mod.CreateTime = (this._mod.ModifyTime = DateTime.Now);
			this._mod.Creater = (this._mod.Modifier = GlobalKey.UserName);
			bool flag = !DalT_unionlab.Instance.AddNoReturn(this._mod);
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

		// Token: 0x06000882 RID: 2178 RVA: 0x000D14CC File Offset: 0x000CF6CC
		private bool Modify()
		{
			ModT_unionlab oldValue = this._mod.Clone() as ModT_unionlab;
			this.BindControl();
			this._mod.ModifyTime = DateTime.Now;
			this._mod.Modifier = GlobalKey.UserName;
			bool flag = !DalT_unionlab.Instance.Update(this._mod);
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

		// Token: 0x06000883 RID: 2179 RVA: 0x000D1574 File Offset: 0x000CF774
		private bool TextCheck()
		{
			return true;
		}

		// Token: 0x04000E75 RID: 3701
		private ModT_unionlab _mod = new ModT_unionlab();
	}
}
