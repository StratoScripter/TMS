using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using Base;

namespace SQSClient
{
	// Token: 0x0200001F RID: 31
	public partial class frmAbout : BaseDialogForm
	{
		// Token: 0x06000177 RID: 375 RVA: 0x0002DC5F File Offset: 0x0002BE5F
		public frmAbout(string text, BaseForm.FormActtion act, int id)
		{
			this.InitializeComponent();
			this.SetText(this);
			this.Text = text;
			this._Act = act;
			this._CurrentId = id;
		}

		// Token: 0x06000178 RID: 376 RVA: 0x0002DC95 File Offset: 0x0002BE95
		private void frmAbout_Load(object sender, EventArgs e)
		{
			this.GetAssembly();
		}

		// Token: 0x06000179 RID: 377 RVA: 0x0002DCA0 File Offset: 0x0002BEA0
		public void GetAssembly()
		{
			Assembly executingAssembly = Assembly.GetExecutingAssembly();
			AssemblyDescriptionAttribute assemblyDescriptionAttribute = (AssemblyDescriptionAttribute)Attribute.GetCustomAttribute(executingAssembly, typeof(AssemblyDescriptionAttribute));
			AssemblyCopyrightAttribute assemblyCopyrightAttribute = (AssemblyCopyrightAttribute)Attribute.GetCustomAttribute(executingAssembly, typeof(AssemblyCopyrightAttribute));
			AssemblyCompanyAttribute assemblyCompanyAttribute = (AssemblyCompanyAttribute)Attribute.GetCustomAttribute(executingAssembly, typeof(AssemblyCompanyAttribute));
			AssemblyProductAttribute assemblyProductAttribute = (AssemblyProductAttribute)Attribute.GetCustomAttribute(executingAssembly, typeof(AssemblyProductAttribute));
			AssemblyFileVersionAttribute assemblyFileVersionAttribute = (AssemblyFileVersionAttribute)Attribute.GetCustomAttribute(executingAssembly, typeof(AssemblyFileVersionAttribute));
			Label label = this.labelProductName;
			label.Text = label.Text + ":" + assemblyProductAttribute.Product;
			Label label2 = this.labelVersion;
			label2.Text = label2.Text + ":" + assemblyFileVersionAttribute.Version;
			Label label3 = this.labelCopyright;
			label3.Text = label3.Text + ":" + assemblyCopyrightAttribute.Copyright;
			this.labelCompanyName.Text = ShowWords.ReplaceText(assemblyCompanyAttribute.Company);
			this.textBoxDescription.Text = ShowWords.ReplaceText(assemblyDescriptionAttribute.Description);
		}

		// Token: 0x0600017A RID: 378 RVA: 0x0002DDBA File Offset: 0x0002BFBA
		private void labelCompanyName_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("IEXPLORE.EXE", this.labelCompanyName.Tag.ToString());
		}
	}
}
