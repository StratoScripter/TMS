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
using Model;
using Model.SQSConfig;
using SQSClient.Properties;

namespace SQSClient
{
	// Token: 0x02000010 RID: 16
	public partial class frmLabTicketEdit : BaseDialogForm
	{
		// Token: 0x0600007E RID: 126 RVA: 0x0000D4E8 File Offset: 0x0000B6E8
		public frmLabTicketEdit(string text, BaseForm.FormActtion act, int id, string dir)
		{
			this.InitializeComponent();
			this.SetText(this);
			this.Text = text;
			this._Act = act;
			this._CurrentId = id;
			this._Direct = dir;
		}

		// Token: 0x0600007F RID: 127 RVA: 0x0000D543 File Offset: 0x0000B743
		private void frmLabTicketEdit_Load(object sender, EventArgs e)
		{
			this.InitControl();
			this.LoadData();
		}

		// Token: 0x06000080 RID: 128 RVA: 0x0000D554 File Offset: 0x0000B754
		private bool InitControl()
		{
			List<BaseForm.EnumModel> enumModelList = BaseForm.GetEnumModelList<CheckResult>();
			enumModelList.RemoveAt(0);
			return true;
		}

		// Token: 0x06000081 RID: 129 RVA: 0x0000D578 File Offset: 0x0000B778
		protected override void LoadData()
		{
			bool flag = BaseForm.FormActtion.Modify == this._Act;
			if (flag)
			{
				this._mod = DalT_ticket.Instance.GetModel(this._CurrentId);
				bool flag2 = this._mod == null;
				if (flag2)
				{
					base.ShowMsg(Messages.ObjNonExist, "", "");
					base.Close();
				}
				else
				{
					this.txtDanHao.Text = this._mod.DanHao;
					this.txtBusinessType.Text = ShowWords.ReplaceText(EnumHelper.GetDescription<BusinessType>((BusinessType)this._mod.BusinessType));
					this.txtProduct.Text = this._mod.ProductName;
					this.txtCheNum.Text = this._mod.Lisence;
					this.txtDifferWeight.Text = this._mod.DifferWeight.ToString();
					this.txtJieSuanLiang.Text = this._mod.JieSuanLiang.ToString();
					this.labDanWei.Text = this._mod.DanWei;
					this.rtxtRemark.Text = this._mod.Remark;
					this.mNextLabStatus = this._mod.LabStatus + 1;
					this.tbxNextLabStatus.Text = ShowWords.ReplaceText(EnumHelper.GetDescription<LabStatus>((LabStatus)this.mNextLabStatus));
				}
			}
		}

		// Token: 0x06000082 RID: 130 RVA: 0x0000D6E4 File Offset: 0x0000B8E4
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
					this.AddtTicketLab(this.mNextLabStatus);
					base.DialogResult = DialogResult.Yes;
				}
			}
		}

		// Token: 0x06000083 RID: 131 RVA: 0x0000D738 File Offset: 0x0000B938
		private bool Modify()
		{
			Dictionary<string, object> dictionary = new Dictionary<string, object>();
			dictionary.Add("LabStatus", this.mNextLabStatus);
			dictionary.Add("LabMan", GlobalKey.UserName);
			dictionary.Add("LabTime", DateTime.Now);
			Dictionary<string, object> dictionary2 = dictionary;
			string key = "LabCount";
			ModT_ticket mod = this._mod;
			int num = mod.LabCount + 1;
			mod.LabCount = num;
			dictionary2.Add(key, num);
			this.OnOperateSuccess(new
			{
				Ticket = this._mod,
				Dic = dictionary
			}, true);
			return DalT_ticket.Instance.Update(dictionary, this._mod.Id);
		}

		// Token: 0x06000084 RID: 132 RVA: 0x0000D7E8 File Offset: 0x0000B9E8
		private bool TextCheck()
		{
			return true;
		}

		// Token: 0x06000085 RID: 133 RVA: 0x0000D7FC File Offset: 0x0000B9FC
		private void AddtTicketLab(int labStatus)
		{
			bool flag = this._mod == null;
			if (!flag)
			{
				ModT_ticketlab modT_ticketlab = new ModT_ticketlab();
				modT_ticketlab.BillId = this._mod.Id;
				modT_ticketlab.BillType = 2;
				modT_ticketlab.LabStatus = labStatus;
				modT_ticketlab.CheckMan = GlobalKey.UserName;
				modT_ticketlab.LabTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
				modT_ticketlab.LabInfo = this.rtxtRemark.Text.Trim();
				modT_ticketlab.ModifyTime = DateTime.Now;
				modT_ticketlab.State = 1;
				DalT_ticketlab.Instance.AddNoReturn(modT_ticketlab);
			}
		}

		// Token: 0x040000CE RID: 206
		private ModT_ticket _mod = new ModT_ticket();

		// Token: 0x040000CF RID: 207
		public int mNextLabStatus = 0;
	}
}
