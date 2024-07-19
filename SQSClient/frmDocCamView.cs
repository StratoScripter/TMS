using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Base;
using DAL.Base.SQSConfig;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using DocumentCamera;
using InterHandle;
using Model;
using Model.SQSConfig;

namespace SQSClient
{
	// Token: 0x0200001E RID: 30
	public partial class frmDocCamView : BaseDialogForm
	{
		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600016D RID: 365 RVA: 0x0002D25E File Offset: 0x0002B45E
		// (set) Token: 0x0600016E RID: 366 RVA: 0x0002D266 File Offset: 0x0002B466
		public DocType DocType
		{
			get
			{
				return this.docType;
			}
			set
			{
				this.docType = value;
			}
		}

		// Token: 0x0600016F RID: 367 RVA: 0x0002D270 File Offset: 0x0002B470
		public frmDocCamView(string text, BaseForm.FormActtion act, int id)
		{
			this.InitializeComponent();
			this.SetText(this);
			this.Text = text;
			this._Act = act;
			this._CurrentId = id;
			this.SetText(this);
		}

		// Token: 0x06000170 RID: 368 RVA: 0x0002D2C4 File Offset: 0x0002B4C4
		private void frmDocCamView_Load(object sender, EventArgs e)
		{
			this.SOAPHandle.URL = ConfigurationManager.AppSettings["WebServiceUrl"];
			DocCameraManager.Instance.InitWithParas();
			DocCameraManager.Instance.Play(CamType.DocCamera, this.pbxPreview.Handle);
			this.SetReducePic();
		}

		// Token: 0x06000171 RID: 369 RVA: 0x0002D318 File Offset: 0x0002B518
		private void SetReducePic()
		{
			this._mod = DalT_ticket.Instance.GetModel(this._CurrentId);
			this.lblTicket.Text = this._mod.DanHao;
			this.localpath = Application.StartupPath + "\\LocalData\\" + this._mod.DanHao;
			bool flag = !Directory.Exists(this.localpath);
			if (flag)
			{
				Directory.CreateDirectory(this.localpath);
			}
			Dictionary<string, object> dictionary = new Dictionary<string, object>();
			switch (this.docType)
			{
			case DocType.LabSheet:
			{
				this.type = "L";
				this.filename = string.Concat(new string[]
				{
					this.type,
					this._mod.LabCount.ToString().PadLeft(2, '0'),
					"T",
					DateTime.Now.ToString("MMddHHmmss").Substring(1),
					".jpg"
				});
				bool flag2 = !this._mod.IsQPicture;
				if (flag2)
				{
					return;
				}
				dictionary.Add("path", this._mod.QualityPicturePath);
				break;
			}
			case DocType.Receipt:
			{
				this.type = "O";
				this.filename = this.type + DateTime.Now.ToString("MMddHHmmss") + ".jpg";
				bool flag3 = !this._mod.IsSOPicture;
				if (flag3)
				{
					return;
				}
				dictionary.Add("path", this._mod.StockOutPicturePath);
				break;
			}
			}
			try
			{
				this.SOAPHandle.MethodName = "GetFile";
				this.SOAPHandle.Paras = dictionary;
				object obj = this.SOAPHandle.Activity();
				Dictionary<string, object> dictionary2 = obj.ChangeD();
				bool flag4 = dictionary2["Code"].ToString() != "1";
				if (flag4)
				{
					base.ShowMsg(dictionary2["Info"].ToString(), "", "");
				}
				else
				{
					byte[] array = Convert.FromBase64String(dictionary2["Data"].ToString());
					MemoryStream memoryStream = new MemoryStream();
					for (int i = 0; i < array.Length; i++)
					{
						memoryStream.WriteByte(array[i]);
					}
					this.pbReduceImage.Image = Image.FromStream(memoryStream);
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000172 RID: 370 RVA: 0x0002D5B8 File Offset: 0x0002B7B8
		private void btnCapture_Click(object sender, EventArgs e)
		{
			DocCameraManager.Instance.SetCutType(CutType.cutoutblk);
			string text = this.localpath + "\\" + this.filename;
			bool flag = DocCameraManager.Instance.CapturePic(text);
			if (flag)
			{
				try
				{
					using (FileStream fileStream = new FileStream(text, FileMode.Open))
					{
						byte[] array = new byte[(int)fileStream.Length];
						int num = fileStream.Read(array, 0, array.Length);
						Dictionary<string, object> dictionary = new Dictionary<string, object>();
						dictionary.Add("filedata", Convert.ToBase64String(array));
						dictionary.Add("suffix", "jpg");
						dictionary.Add("type", this.type);
						dictionary.Add("key", this._mod.DanHao);
						bool @checked = this.chkPrintChoise.Checked;
						if (@checked)
						{
							dictionary.Add("print", true);
						}
						this.SOAPHandle.MethodName = "SetFile";
						this.SOAPHandle.Paras = dictionary;
						object obj = this.SOAPHandle.Activity();
					}
				}
				catch
				{
				}
				base.DialogResult = DialogResult.OK;
			}
			else
			{
				base.ShowToast(this, DocumentCamera.Messages.CaptureFailed, "", "");
			}
		}

		// Token: 0x06000173 RID: 371 RVA: 0x00003040 File Offset: 0x00001240
		private void frmDocCamView_FormClosing(object sender, FormClosingEventArgs e)
		{
		}

		// Token: 0x06000174 RID: 372 RVA: 0x0002D720 File Offset: 0x0002B920
		private void pbReduceImage_Click(object sender, EventArgs e)
		{
			PictureBox pictureBox = sender as PictureBox;
			bool flag = pictureBox.Image == null;
			if (!flag)
			{
				Form form = new Form();
				form.Size = new Size(800, 700);
				form.StartPosition = FormStartPosition.CenterScreen;
				PictureBox pictureBox2 = new PictureBox();
				pictureBox2.Dock = DockStyle.Fill;
				pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
				pictureBox2.Size = new Size(700, 500);
				form.Controls.Add(pictureBox2);
				pictureBox2.Image = this.pbReduceImage.Image;
				form.Show();
			}
		}

		// Token: 0x040002A0 RID: 672
		private ModT_ticket _mod;

		// Token: 0x040002A1 RID: 673
		private DocType docType;

		// Token: 0x040002A2 RID: 674
		private SOAPHandle SOAPHandle = new SOAPHandle();

		// Token: 0x040002A3 RID: 675
		private string localpath;

		// Token: 0x040002A4 RID: 676
		private string filename;

		// Token: 0x040002A5 RID: 677
		private string type;
	}
}
