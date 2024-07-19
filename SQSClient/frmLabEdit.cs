using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Assistant;
using Base;
using DAL.Base.SQSConfig;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using DevComponents.DotNetBar.Layout;
using InterHandle;
using Model;
using Model.SQSConfig;
using SQSClient.Properties;

namespace SQSClient
{
	// Token: 0x02000025 RID: 37
	public partial class frmLabEdit : BaseDialogForm
	{
		// Token: 0x060001CE RID: 462 RVA: 0x00036624 File Offset: 0x00034824
		public frmLabEdit(string text, BaseForm.FormActtion act, int id, string dir)
		{
			this.InitializeComponent();
			this.SetText(this);
			this.Text = text;
			this._Act = act;
			this._CurrentId = id;
			this._Direct = dir;
		}

		// Token: 0x060001CF RID: 463 RVA: 0x00036683 File Offset: 0x00034883
		private void frmLabEdit_Load(object sender, EventArgs e)
		{
			this.InitControl();
			this.LoadData();
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x00036694 File Offset: 0x00034894
		private bool InitControl()
		{
			List<BaseForm.EnumModel> enumModelList = BaseForm.GetEnumModelList<CheckResult>();
			enumModelList.RemoveAt(0);
			BaseForm.BindDataSouce(this.cmbLabResult, enumModelList, "Description", "Value");
			return true;
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x000366CC File Offset: 0x000348CC
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
					this.cmbLabResult.SelectedValue = this._mod.LabResult;
				}
			}
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x00036824 File Offset: 0x00034A24
		private void btnSave_Click(object sender, EventArgs e)
		{
			bool flag = !this.TextCheck();
			if (!flag)
			{
				bool flag2 = !this.StateCheck();
				if (!flag2)
				{
					bool flag3 = false;
					bool flag4 = BaseForm.FormActtion.Modify == this._Act;
					if (flag4)
					{
						flag3 = this.Modify();
					}
					bool flag5 = flag3;
					if (flag5)
					{
						int labStatus = 4;
						this.AddtTicketLab(labStatus);
						base.DialogResult = DialogResult.Yes;
					}
				}
			}
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x00036888 File Offset: 0x00034A88
		private bool Modify()
		{
			Dictionary<string, object> dictionary = new Dictionary<string, object>();
			dictionary.Add("LabResult", (this.cmbLabResult.SelectedValue == null) ? 0 : ((int)this.cmbLabResult.SelectedValue));
			dictionary.Add("LabMan", GlobalKey.UserName);
			dictionary.Add("LabTime", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
			Dictionary<string, object> dictionary2 = dictionary;
			string key = "LabCount";
			ModT_ticket mod = this._mod;
			int num = mod.LabCount + 1;
			mod.LabCount = num;
			dictionary2.Add(key, num);
			dictionary.Add("LabStatus", 4);
			dictionary.Add("Remark", this.rtxtRemark.Text.Trim());
			this.OnOperateSuccess(new
			{
				Ticket = this._mod,
				Dic = dictionary
			}, true);
			return DalT_ticket.Instance.Update(dictionary, this._mod.Id);
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x00036988 File Offset: 0x00034B88
		private bool TextCheck()
		{
			return true;
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x0003699C File Offset: 0x00034B9C
		private bool StateCheck()
		{
			bool flag = Convert.ToInt32(Settings.Instance.LabStepControler) == 1;
			bool result;
			if (flag)
			{
				bool flag2 = this._mod.LabStatus >= 2;
				if (flag2)
				{
					result = true;
				}
				else
				{
					base.ShowMsg(Messages.LabStatusWrong, "", "");
					result = false;
				}
			}
			else
			{
				result = true;
			}
			return result;
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x000369FC File Offset: 0x00034BFC
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

		// Token: 0x060001D7 RID: 471 RVA: 0x00036A50 File Offset: 0x00034C50
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
				modT_ticketlab.LabInfo = "";
				modT_ticketlab.ModifyTime = DateTime.Now;
				modT_ticketlab.State = 1;
				DalT_ticketlab.Instance.AddNoReturn(modT_ticketlab);
			}
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x00036AE8 File Offset: 0x00034CE8
		private void btnUpload_Click(object sender, EventArgs e)
		{
			this.SOAPHandle.URL = ConfigurationManager.AppSettings["WebServiceUrl"];
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.CheckFileExists = true;
			openFileDialog.InitialDirectory = Application.StartupPath;
			openFileDialog.DefaultExt = ".doc";
			openFileDialog.Filter = "File|*.doc|AllFile|*.*";
			bool flag = DialogResult.OK == openFileDialog.ShowDialog();
			if (flag)
			{
				using (FileStream fileStream = new FileStream(openFileDialog.FileName, FileMode.Open))
				{
					byte[] array = new byte[(int)fileStream.Length];
					int num = fileStream.Read(array, 0, array.Length);
					Dictionary<string, object> dictionary = new Dictionary<string, object>();
					dictionary.Add("filedata", Convert.ToBase64String(array));
					dictionary.Add("suffix", openFileDialog.SafeFileName.Split(new char[]
					{
						'.'
					})[1]);
					dictionary.Add("type", "L");
					dictionary.Add("key", this._mod.DanHao);
					dictionary.Add("print", true);
					this.SOAPHandle.MethodName = "SetFile";
					this.SOAPHandle.Paras = dictionary;
					object obj = this.SOAPHandle.Activity();
					Dictionary<string, object> dictionary2 = obj.ChangeD();
					bool flag2 = dictionary2["Code"].ToString() != "1";
					if (flag2)
					{
						base.ShowMsg(dictionary2["Info"].ToString(), "", "");
					}
				}
			}
		}

		// Token: 0x04000345 RID: 837
		private ModT_ticket _mod = new ModT_ticket();

		// Token: 0x04000346 RID: 838
		private SOAPHandle SOAPHandle = new SOAPHandle();
	}
}
