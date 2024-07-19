using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using DevComponents.DotNetBar.Layout;
using Model.SQSConfig;
using Newtonsoft.Json;

namespace SQSClient.Monitor
{
	// Token: 0x020000A5 RID: 165
	public partial class frmLogDetail : BaseDialogForm
	{
		// Token: 0x06000974 RID: 2420 RVA: 0x000DD915 File Offset: 0x000DBB15
		public frmLogDetail(string text, ModSys_operatelog modSys_Operatelog)
		{
			this.InitializeComponent();
			this.SetText(this);
			this.Text = text;
			this._modSys_Operatelog = modSys_Operatelog;
		}

		// Token: 0x06000975 RID: 2421 RVA: 0x000DD944 File Offset: 0x000DBB44
		private void frmLogDetail_Load(object sender, EventArgs e)
		{
			string text = this.ConvertJsonString(this._modSys_Operatelog.Req);
			string resp = this.ConvertJsonString(this._modSys_Operatelog.Resp);
			this._modSys_Operatelog.Req = text;
			this._modSys_Operatelog.Resp = resp;
			this.tbxRemark.Text = text;
			this.tbxClassName.Text = this._modSys_Operatelog.Object;
			this.tbxMethod.Text = this._modSys_Operatelog.Method;
		}

		// Token: 0x06000976 RID: 2422 RVA: 0x000DD9CC File Offset: 0x000DBBCC
		private string ConvertJsonString(string str)
		{
			JsonSerializer jsonSerializer = new JsonSerializer();
			TextReader reader = new StringReader(str);
			JsonTextReader reader2 = new JsonTextReader(reader);
			object obj = jsonSerializer.Deserialize(reader2);
			bool flag = obj != null;
			string result;
			if (flag)
			{
				StringWriter stringWriter = new StringWriter();
				JsonTextWriter jsonWriter = new JsonTextWriter(stringWriter)
				{
					Formatting = Formatting.Indented,
					Indentation = 4,
					IndentChar = ' '
				};
				jsonSerializer.Serialize(jsonWriter, obj);
				result = stringWriter.ToString();
			}
			else
			{
				result = str;
			}
			return result;
		}

		// Token: 0x04000F6F RID: 3951
		private ModSys_operatelog _modSys_Operatelog;
	}
}
