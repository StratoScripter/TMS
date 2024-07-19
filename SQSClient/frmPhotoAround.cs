using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using DevComponents.AdvTree;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using InterHandle;

namespace SQSClient
{
	// Token: 0x02000026 RID: 38
	public partial class frmPhotoAround : BaseDialogForm
	{
		// Token: 0x060001DB RID: 475 RVA: 0x00037CD1 File Offset: 0x00035ED1
		public frmPhotoAround(string danhao)
		{
			this.InitializeComponent();
			this.txtDanHao.Text = danhao;
		}

		// Token: 0x060001DC RID: 476 RVA: 0x00037D0C File Offset: 0x00035F0C
		private void frmPhotoAround_Load(object sender, EventArgs e)
		{
			this.sOAPHandle.URL = ConfigurationManager.AppSettings["PhotoServiceUrl"];
			this.LoadData();
		}

		// Token: 0x060001DD RID: 477 RVA: 0x00037D34 File Offset: 0x00035F34
		protected override void LoadData()
		{
			Dictionary<string, object> dictionary = new Dictionary<string, object>();
			dictionary.Add("danhao", this.txtDanHao.Text);
			dictionary.Add("nodes", this.node);
			dictionary.Add("types", "");
			this.sOAPHandle.MethodName = "SearchPhoto";
			this.sOAPHandle.Paras = dictionary;
			object obj = this.sOAPHandle.Activity();
			Dictionary<string, object> dictionary2 = obj.ChangeD();
			bool flag = dictionary2["Code"].ToString() != "1";
			if (flag)
			{
				base.ShowMsg(dictionary2["Info"].ToString(), "", "");
			}
			else
			{
				List<object> list = dictionary2["Data"].ChangeD().First().ChangeDs();
				this.treeGroup.Nodes.Clear();
				foreach (object obj2 in list)
				{
					Node node = new Node();
					node.DragDropEnabled = false;
					node.Text = obj2.ToString();
					this.treeGroup.Nodes.Add(node);
				}
				this.treeGroup.ExpandAll();
			}
		}

		// Token: 0x060001DE RID: 478 RVA: 0x00037EA4 File Offset: 0x000360A4
		private void treeGroup_NodeDoubleClick(object sender, TreeNodeMouseEventArgs e)
		{
			Dictionary<string, object> dictionary = new Dictionary<string, object>();
			dictionary.Add("danhao", this.txtDanHao.Text);
			dictionary.Add("nodes", this.node);
			dictionary.Add("path", e.Node.Text);
			this.sOAPHandle.MethodName = "GetFile";
			this.sOAPHandle.Paras = dictionary;
			object obj = this.sOAPHandle.Activity();
			Dictionary<string, object> dictionary2 = obj.ChangeD();
			bool flag = dictionary2 == null;
			if (!flag)
			{
				bool flag2 = dictionary2["Code"].ToString() != "1";
				if (flag2)
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
					this.pbxPreview.Image = Image.FromStream(memoryStream);
				}
			}
		}

		// Token: 0x04000361 RID: 865
		private string node = "PhotoAround";

		// Token: 0x04000362 RID: 866
		private SOAPHandle sOAPHandle = new SOAPHandle();
	}
}
