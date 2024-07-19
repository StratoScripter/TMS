using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using Assistant;
using Base;
using DAL.Base.SQSConfig;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using DevComponents.Editors;
using DevComponents.Editors.DateTimeAdv;
using Model;
using Model.SQSConfig;
using SQSClient.Properties;

namespace SQSClient
{
	// Token: 0x0200008A RID: 138
	public partial class frmAlarmQuery : BaseDialogForm
	{
		// Token: 0x0600077C RID: 1916 RVA: 0x000BA0C4 File Offset: 0x000B82C4
		public frmAlarmQuery()
		{
			this.InitializeComponent();
			this.SetText(this);
			this._Controls.Clear();
			this._Controls.Add(this.bar);
			this._Controls.Add(this.dgvData);
			base.SetGridUI(this.dgvData);
		}

		// Token: 0x0600077D RID: 1917 RVA: 0x000BA12C File Offset: 0x000B832C
		private void frmAlarmQuery_Load(object sender, EventArgs e)
		{
			base.InitBurron();
			this.InitControl();
		}

		// Token: 0x0600077E RID: 1918 RVA: 0x000BA140 File Offset: 0x000B8340
		private void InitControl()
		{
			List<ModCfg_device> allList = DalCfg_device.Instance.GetAllList();
			this.cmbDevice.BindDataSouce(allList, "Name", "PinYinMa", "Id");
			bool flag = this.cmbDevice.Items.Count > 0;
			if (flag)
			{
				this.cmbDevice.SelectedIndex = 0;
			}
			this.dtpStartTime.Value = DateTimeAction.DayStartD(DateTime.Now);
			this.dtpEndTime.Value = DateTimeAction.DayEndD(DateTime.Now);
		}

		// Token: 0x0600077F RID: 1919 RVA: 0x000BA1C8 File Offset: 0x000B83C8
		private void btnSearch_Click(object sender, EventArgs e)
		{
			bool flag = !base.TimeCheck(this.dtpStartTime.Value, this.dtpEndTime.Value);
			if (!flag)
			{
				this.dgvData.AutoGenerateColumns = false;
				this.LoadData(this.dtpStartTime.Value, this.dtpEndTime.Value);
			}
		}

		// Token: 0x06000780 RID: 1920 RVA: 0x000BA226 File Offset: 0x000B8426
		private void btnExport_Click(object sender, EventArgs e)
		{
			base.ExportExcel(this.dgvData);
		}

		// Token: 0x06000781 RID: 1921 RVA: 0x000BA236 File Offset: 0x000B8436
		private void tsbtnClose_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000782 RID: 1922 RVA: 0x000BA240 File Offset: 0x000B8440
		private void LoadData(DateTime STime, DateTime EndTime)
		{
			bool flag = this.cmbDevice.SelectedValue == null;
			if (!flag)
			{
				this.dgvData.Rows.Clear();
				List<ModT_alarm> list = new List<ModT_alarm>();
				list = DalT_alarm.Instance.GetList((int)this.cmbDevice.SelectedValue, STime, EndTime);
				foreach (ModT_alarm modT_alarm in list)
				{
					int num = 0;
					object[] array = new object[this.dgvData.ColumnCount];
					array[num++] = modT_alarm.Id;
					array[num++] = modT_alarm.DId;
					array[num++] = modT_alarm.Device;
					array[num++] = modT_alarm.Unit;
					array[num++] = modT_alarm.AlarmDesc;
					array[num++] = modT_alarm.AlarmVal;
					array[num++] = modT_alarm.AlarmTime;
					this.dgvData.Rows.Add(array);
				}
				bool flag2 = this.dgvData.Rows.Count > 0;
				if (flag2)
				{
					this.GetCurrentItem(0);
				}
			}
		}

		// Token: 0x06000783 RID: 1923 RVA: 0x000BA3B0 File Offset: 0x000B85B0
		private void GetCurrentItem(int rowindex)
		{
			this._CurrentId = int.Parse(this.dgvData.Rows[rowindex].Cells[0].Value.ToString());
		}

		// Token: 0x06000784 RID: 1924 RVA: 0x000BA3E4 File Offset: 0x000B85E4
		private void btnPrint_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = PrinterSettings.InstalledPrinters.Count <= 0;
				if (flag)
				{
					base.ShowMsg(Messages.PrinterHavent, "", "");
					return;
				}
			}
			catch (Win32Exception ex)
			{
				base.ShowMsg(Messages.PrinterHavent, "", "");
				return;
			}
			bool flag2 = this.dgvData.Rows.Count > 0;
			if (flag2)
			{
				frmPrintView frmPrintView = new frmPrintView(this.dgvData, this.headerText, this.time);
				frmPrintView.Print();
			}
			else
			{
				base.ShowMsg(Messages.NoData, "", "");
			}
		}

		// Token: 0x04000CC5 RID: 3269
		private string headerText;

		// Token: 0x04000CC6 RID: 3270
		private string time;
	}
}
