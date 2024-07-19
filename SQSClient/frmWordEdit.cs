using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Assistant;
using Base;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using DevComponents.DotNetBar.Layout;
using Model;
using Model.General;
using SQSClient.Properties;

namespace SQSClient
{
	// Token: 0x02000034 RID: 52
	public partial class frmWordEdit : BaseDialogForm
	{
		// Token: 0x0600026D RID: 621 RVA: 0x00043834 File Offset: 0x00041A34
		public frmWordEdit(string text, BaseForm.FormActtion act, int id)
		{
			this.InitializeComponent();
			this.SetText(this);
			this.Text = text;
			this._Act = act;
			this._CurrentId = id;
		}

		// Token: 0x0600026E RID: 622 RVA: 0x00043880 File Offset: 0x00041A80
		private void frmWordEdit_Load(object sender, EventArgs e)
		{
			XMLHelper.ReadXMLFile<Words>(Application.StartupPath + "\\Dictionary.xml", ref this.listWords);
		}

		// Token: 0x0600026F RID: 623 RVA: 0x000438A0 File Offset: 0x00041AA0
		private void btnSure_Click(object sender, EventArgs e)
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

		// Token: 0x06000270 RID: 624 RVA: 0x000438F0 File Offset: 0x00041AF0
		private bool Add()
		{
			Word word = new Word();
			word.Key = this.txtKey.Text;
			this.listWords.words.Add(word);
			XMLHelper.WriteXMLFile<Words>(Application.StartupPath + "\\Dictionary.xml", this.listWords);
			return true;
		}

		// Token: 0x06000271 RID: 625 RVA: 0x00043948 File Offset: 0x00041B48
		private bool Modify()
		{
			return true;
		}

		// Token: 0x06000272 RID: 626 RVA: 0x0004395C File Offset: 0x00041B5C
		private bool TextCheck()
		{
			bool flag = string.IsNullOrWhiteSpace(this.txtKey.Text);
			bool result;
			if (flag)
			{
				base.ShowMsg(Messages.KeyNull, "", "");
				this.txtKey.Focus();
				result = false;
			}
			else
			{
				bool flag2 = this.listWords.words.Find((Word w) => w.Key == this.txtKey.Text) != null;
				if (flag2)
				{
					base.ShowMsg(Messages.KeyHaved, "", "");
					this.txtKey.Focus();
					result = false;
				}
				else
				{
					result = true;
				}
			}
			return result;
		}

		// Token: 0x04000441 RID: 1089
		private Words listWords = new Words();
	}
}
