using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO.Ports;
using System.Windows.Forms;
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
	// Token: 0x0200005C RID: 92
	public partial class frmSerialEdit : BaseDialogForm
	{
		// Token: 0x06000468 RID: 1128 RVA: 0x0006F440 File Offset: 0x0006D640
		public frmSerialEdit(string text, BaseForm.FormActtion act, int index)
		{
			this.InitializeComponent();
			this.SetText(this);
			this.Text = text;
			this._Act = act;
			this._selectIndex = index;
		}

		// Token: 0x06000469 RID: 1129 RVA: 0x0006F49A File Offset: 0x0006D69A
		private void frmSerialEdit_Load(object sender, EventArgs e)
		{
			this.InitControl();
			this.LoadData();
		}

		// Token: 0x0600046A RID: 1130 RVA: 0x0006F4AC File Offset: 0x0006D6AC
		private void InitControl()
		{
			this.cmbPortName.Items.Clear();
			this._listportpara = DalCfg_portpara.Instance.GetAllList();
			for (int i = 0; i < this._listportpara.Count; i++)
			{
				this.cmbPortName.Items.Add(this._listportpara[i].PortName);
			}
			this.cmbBaudRate.Items.Clear();
			this.cmbBaudRate.Items.Add(1200);
			this.cmbBaudRate.Items.Add(2400);
			this.cmbBaudRate.Items.Add(4800);
			this.cmbBaudRate.Items.Add(9600);
			this.cmbBaudRate.Items.Add(14400);
			this.cmbBaudRate.Items.Add(19200);
			this.cmbBaudRate.Items.Add(38400);
			this.cmbBaudRate.Items.Add(56000);
			this.cmbBaudRate.Items.Add(57600);
			this.cmbBaudRate.Items.Add(115200);
			this.cmbBaudRate.Items.Add(128000);
			this.cmbBaudRate.Items.Add(256000);
			this.cmbDataBits.Items.Clear();
			this.cmbDataBits.Items.Add(5);
			this.cmbDataBits.Items.Add(6);
			this.cmbDataBits.Items.Add(7);
			this.cmbDataBits.Items.Add(8);
			this.cmbParity.Items.Clear();
			foreach (object obj in Enum.GetValues(typeof(Parity)))
			{
				Parity parity = (Parity)obj;
				this.cmbParity.Items.Add(parity);
			}
			this.cmbStopBits.Items.Clear();
			foreach (object obj2 in Enum.GetValues(typeof(StopBits)))
			{
				StopBits stopBits = (StopBits)obj2;
				this.cmbStopBits.Items.Add(stopBits);
			}
		}

		// Token: 0x0600046B RID: 1131 RVA: 0x0006F7D8 File Offset: 0x0006D9D8
		protected override void LoadData()
		{
			bool flag = BaseForm.FormActtion.Modify == this._Act;
			if (flag)
			{
				this.cmbPortName.SelectedIndex = this._selectIndex;
			}
		}

		// Token: 0x0600046C RID: 1132 RVA: 0x0006F808 File Offset: 0x0006DA08
		private void btnSave_Click(object sender, EventArgs e)
		{
			bool flag = this.Modify();
			if (flag)
			{
				base.DialogResult = DialogResult.Yes;
			}
		}

		// Token: 0x0600046D RID: 1133 RVA: 0x0006F82C File Offset: 0x0006DA2C
		private bool Modify()
		{
			this._mod.BaudRate = int.Parse(this.cmbBaudRate.Text);
			this._mod.DataBits = int.Parse(this.cmbDataBits.Text);
			this._mod.Parity = this.cmbParity.SelectedIndex;
			this._mod.StopBits = this.cmbStopBits.SelectedIndex;
			bool flag = !DalCfg_portpara.Instance.Update(this._mod);
			bool result;
			if (flag)
			{
				base.ShowMsg(Messages.ModifyFalse, "", "");
				result = false;
			}
			else
			{
				result = true;
			}
			return result;
		}

		// Token: 0x0600046E RID: 1134 RVA: 0x0006F8D8 File Offset: 0x0006DAD8
		private void cmbPortName_SelectedIndexChanged(object sender, EventArgs e)
		{
			this._mod = this._listportpara[this.cmbPortName.SelectedIndex];
			this.cmbBaudRate.Text = this._mod.BaudRate.ToString();
			this.cmbDataBits.Text = this._mod.DataBits.ToString();
			this.cmbParity.Text = ((Parity)this._mod.Parity).ToString();
			this.cmbStopBits.Text = ((StopBits)this._mod.StopBits).ToString();
		}

		// Token: 0x0400079F RID: 1951
		private List<ModCfg_portpara> _listportpara = null;

		// Token: 0x040007A0 RID: 1952
		private ModCfg_portpara _mod = new ModCfg_portpara();

		// Token: 0x040007A1 RID: 1953
		private int _selectIndex = 0;
	}
}
