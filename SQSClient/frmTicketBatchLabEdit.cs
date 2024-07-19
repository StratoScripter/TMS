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
using Model;
using Model.SQSConfig;
using SQSClient.Properties;

namespace SQSClient
{
	// Token: 0x0200006A RID: 106
	public partial class frmTicketBatchLabEdit : BaseDialogForm
	{
		// Token: 0x06000557 RID: 1367 RVA: 0x00088088 File Offset: 0x00086288
		public frmTicketBatchLabEdit(string text, BaseForm.FormActtion act, int id, string dir)
		{
			this.InitializeComponent();
			this.SetText(this);
			this.Text = text;
			this._Act = act;
			this._CurrentId = id;
			this._Direct = dir;
		}

		// Token: 0x06000558 RID: 1368 RVA: 0x000880DC File Offset: 0x000862DC
		private void frmTicketBatchLabEdit_Load(object sender, EventArgs e)
		{
			this.InitControl();
			this.LoadData();
		}

		// Token: 0x06000559 RID: 1369 RVA: 0x000880F0 File Offset: 0x000862F0
		private bool InitControl()
		{
			BaseForm.BindDataSouce(this.cmbBatchLabResult, BaseForm.GetEnumModelList<CheckResult>(), "Description", "Value");
			return true;
		}

		// Token: 0x0600055A RID: 1370 RVA: 0x00088120 File Offset: 0x00086320
		protected override void LoadData()
		{
			bool flag = BaseForm.FormActtion.Modify == this._Act;
			if (flag)
			{
				this._mod = DalT_ticketbatch.Instance.GetViewById(this._CurrentId);
				bool flag2 = this._mod == null;
				if (flag2)
				{
					base.ShowMsg(Messages.ObjNonExist, "", "");
					base.Close();
				}
				else
				{
					this.txtDanHao.Text = this._mod.DanHao;
					this.txtBatchCode.Text = this._mod.BatchCode;
					this.txtProduct.Text = this._mod.ProductName;
					this.rtxtRemark.Text = this._mod.Remark;
					this.cmbBatchLabResult.SelectedValue = this._mod.BatchLabResult;
				}
			}
		}

		// Token: 0x0600055B RID: 1371 RVA: 0x00088200 File Offset: 0x00086400
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

		// Token: 0x0600055C RID: 1372 RVA: 0x00088254 File Offset: 0x00086454
		private bool Modify()
		{
			Dictionary<string, object> dictionary = new Dictionary<string, object>();
			dictionary.Add("BatchLabResult", (int)this.cmbBatchLabResult.SelectedValue);
			dictionary.Add("BatchLabMan", GlobalKey.UserName);
			dictionary.Add("BatchLabTime", DateTime.Now);
			Dictionary<string, object> dictionary2 = dictionary;
			string key = "BatchLabCount";
			ViewT_ticketbatch mod = this._mod;
			int num = mod.BatchLabCount + 1;
			mod.BatchLabCount = num;
			dictionary2.Add(key, num);
			dictionary.Add("BatchLabStatus", 4);
			this.OnOperateSuccess(this._mod, true);
			return DalT_ticketbatch.Instance.Update(dictionary, this._mod.Id);
		}

		// Token: 0x0600055D RID: 1373 RVA: 0x00088318 File Offset: 0x00086518
		private bool TextCheck()
		{
			return true;
		}

		// Token: 0x0600055E RID: 1374 RVA: 0x0008832C File Offset: 0x0008652C
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

		// Token: 0x0600055F RID: 1375 RVA: 0x00088380 File Offset: 0x00086580
		private void AddtTicketLab(int labStatus)
		{
			bool flag = this._mod == null;
			if (!flag)
			{
				ModT_ticketlab modT_ticketlab = new ModT_ticketlab();
				modT_ticketlab.BillId = this._mod.Id;
				modT_ticketlab.BillType = 3;
				modT_ticketlab.LabStatus = labStatus;
				modT_ticketlab.CheckMan = GlobalKey.UserName;
				modT_ticketlab.LabTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
				modT_ticketlab.LabInfo = "";
				modT_ticketlab.ModifyTime = DateTime.Now;
				modT_ticketlab.State = 1;
				DalT_ticketlab.Instance.AddNoReturn(modT_ticketlab);
			}
		}

		// Token: 0x04000963 RID: 2403
		private ViewT_ticketbatch _mod = new ViewT_ticketbatch();
	}
}
