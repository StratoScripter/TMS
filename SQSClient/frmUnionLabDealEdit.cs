using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Assistant;
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
	// Token: 0x02000098 RID: 152
	public partial class frmUnionLabDealEdit : BaseDialogForm
	{
		// Token: 0x06000870 RID: 2160 RVA: 0x000CFD28 File Offset: 0x000CDF28
		public frmUnionLabDealEdit(string text, BaseForm.FormActtion act, int id, string dir)
		{
			this.InitializeComponent();
			this.SetText(this);
			this.Text = text;
			this._Act = act;
			this._CurrentId = id;
			this._Direct = dir;
		}

		// Token: 0x06000871 RID: 2161 RVA: 0x000CFD7C File Offset: 0x000CDF7C
		private void frmUnionLabDealEdit_Load(object sender, EventArgs e)
		{
			this.InitControl();
			this.LoadData();
		}

		// Token: 0x06000872 RID: 2162 RVA: 0x000CFD90 File Offset: 0x000CDF90
		private bool InitControl()
		{
			BaseForm.BindDataSouce(this.cmbUnionLabResult, BaseForm.GetEnumModelList<CheckResult>(), "Description", "Value");
			return true;
		}

		// Token: 0x06000873 RID: 2163 RVA: 0x000CFDC0 File Offset: 0x000CDFC0
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
					this.txtBusinessType.Text = ShowWords.ReplaceText(EnumHelper.GetDescription<BusinessType>((BusinessType)this._mod.BusinessType));
					this.iInputUnionLabIndex.Value = this._mod.UnionLabIndex;
					this.rtxtMemo.Text = this._mod.Memo;
					this.cmbUnionLabResult.SelectedValue = this._mod.UnionLabResult;
				}
			}
		}

		// Token: 0x06000874 RID: 2164 RVA: 0x000CFEC4 File Offset: 0x000CE0C4
		private void btnSave_Click(object sender, EventArgs e)
		{
			bool flag = !this.TextCheck();
			if (!flag)
			{
				bool flag2 = false;
				bool flag3 = BaseForm.FormActtion.Modify == this._Act;
				if (flag3)
				{
					flag2 = this.Modify();
				}
				bool flag4 = flag2;
				if (flag4)
				{
					int labStatus = 4;
					this.AddtTicketLab(labStatus);
					base.DialogResult = DialogResult.Yes;
				}
			}
		}

		// Token: 0x06000875 RID: 2165 RVA: 0x000CFF18 File Offset: 0x000CE118
		private bool Modify()
		{
			Dictionary<string, object> dictionary = new Dictionary<string, object>();
			dictionary.Add("UnionLabResult", (int)this.cmbUnionLabResult.SelectedValue);
			dictionary.Add("UnionLabMan", GlobalKey.UserName);
			dictionary.Add("UnionLabTime", DateTime.Now);
			Dictionary<string, object> dictionary2 = dictionary;
			string key = "UnionLabCount";
			ModT_unionlab mod = this._mod;
			int num = mod.UnionLabCount + 1;
			mod.UnionLabCount = num;
			dictionary2.Add(key, num);
			dictionary.Add("UnionLabStatus", 4);
			return DalT_unionlab.Instance.Update(dictionary, this._mod.Id);
		}

		// Token: 0x06000876 RID: 2166 RVA: 0x000CFFC8 File Offset: 0x000CE1C8
		private bool TextCheck()
		{
			return true;
		}

		// Token: 0x06000877 RID: 2167 RVA: 0x000CFFDC File Offset: 0x000CE1DC
		private void btnCapture_Click(object sender, EventArgs e)
		{
			bool flag = new frmDocCamView(((ButtonItem)sender).Text, BaseForm.FormActtion.Add, this._CurrentId)
			{
				DocType = DocType.LabSheet
			}.ShowDialog() == DialogResult.OK;
			if (flag)
			{
				base.ShowMsg(Messages.SaveTrue, "", "");
			}
		}

		// Token: 0x06000878 RID: 2168 RVA: 0x000D0030 File Offset: 0x000CE230
		private void AddtTicketLab(int labStatus)
		{
			bool flag = this._mod == null;
			if (!flag)
			{
				ModT_ticketlab modT_ticketlab = new ModT_ticketlab();
				modT_ticketlab.BillId = this._mod.Id;
				modT_ticketlab.BillType = 4;
				modT_ticketlab.LabStatus = labStatus;
				modT_ticketlab.CheckMan = GlobalKey.UserName;
				modT_ticketlab.LabTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
				modT_ticketlab.LabInfo = "";
				modT_ticketlab.ModifyTime = DateTime.Now;
				modT_ticketlab.State = 1;
				DalT_ticketlab.Instance.AddNoReturn(modT_ticketlab);
			}
		}

		// Token: 0x04000E61 RID: 3681
		private ModT_unionlab _mod = new ModT_unionlab();
	}
}
