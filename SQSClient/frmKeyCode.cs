using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Base;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using SQSClient.Properties;

namespace SQSClient
{
	// Token: 0x02000085 RID: 133
	public partial class frmKeyCode : BaseDialogForm
	{
		// Token: 0x06000733 RID: 1843 RVA: 0x000B3244 File Offset: 0x000B1444
		public frmKeyCode()
		{
			this.InitializeComponent();
			this.SetText(this);
			this._Controls.Clear();
			this._Controls.Add(this.bar);
			this._Controls.Add(this.dgvData);
			base.SetGridUI(this.dgvData);
		}

		// Token: 0x06000734 RID: 1844 RVA: 0x000B32AC File Offset: 0x000B14AC
		private void frmKeyCode_Load(object sender, EventArgs e)
		{
			base.InitBurron();
			this.InitControl();
			this.LoadData("");
			BaseDialogForm._operateArgs.Category = this.Text;
		}

		// Token: 0x06000735 RID: 1845 RVA: 0x00003040 File Offset: 0x00001240
		private void InitControl()
		{
		}

		// Token: 0x06000736 RID: 1846 RVA: 0x000B32DC File Offset: 0x000B14DC
		protected override void LoadData(string Name)
		{
			this.dgvData.Rows.Clear();
			int num = 0;
			string[] array = new string[this.dgvData.ColumnCount];
			array[num++] = "1";
			array[num++] = "PortName";
			array[num++] = Settings.Instance.PortName;
			array[num++] = ShowWords.ReplaceText("COMName");
			DataGridViewRowCollection rows = this.dgvData.Rows;
			object[] values = array;
			rows.Add(values);
			num = 0;
			array = new string[this.dgvData.ColumnCount];
			array[num++] = "2";
			array[num++] = "BaudRate";
			array[num++] = Settings.Instance.BaudRate.ToString();
			array[num++] = ShowWords.ReplaceText("Baudrate");
			DataGridViewRowCollection rows2 = this.dgvData.Rows;
			values = array;
			rows2.Add(values);
			num = 0;
			array = new string[this.dgvData.ColumnCount];
			array[num++] = "3";
			array[num++] = "LoadPrinter";
			array[num++] = Settings.Instance.LoadPrinter;
			array[num++] = ShowWords.ReplaceText("LoadPrinter");
			DataGridViewRowCollection rows3 = this.dgvData.Rows;
			values = array;
			rows3.Add(values);
			num = 0;
			array = new string[this.dgvData.ColumnCount];
			array[num++] = "4";
			array[num++] = "UnloadPrinter";
			array[num++] = Settings.Instance.UnloadPrinter;
			array[num++] = ShowWords.ReplaceText("UnloadPrinter");
			DataGridViewRowCollection rows4 = this.dgvData.Rows;
			values = array;
			rows4.Add(values);
			num = 0;
			array = new string[this.dgvData.ColumnCount];
			array[num++] = "5";
			array[num++] = "HisReportPrinter";
			array[num++] = Settings.Instance.HisReportPrinter;
			array[num++] = ShowWords.ReplaceText("HisReportPrinter");
			DataGridViewRowCollection rows5 = this.dgvData.Rows;
			values = array;
			rows5.Add(values);
			num = 0;
			array = new string[this.dgvData.ColumnCount];
			array[num++] = "6";
			array[num++] = "AccountRemindEnable";
			array[num++] = Settings.Instance.AccountRemindEnable.ToString();
			array[num++] = ShowWords.ReplaceText("AccountRemindEnable");
			DataGridViewRowCollection rows6 = this.dgvData.Rows;
			values = array;
			rows6.Add(values);
			num = 0;
			array = new string[this.dgvData.ColumnCount];
			array[num++] = "7";
			array[num++] = "AccountTimeOut";
			array[num++] = Settings.Instance.AccountTimeOut.ToString();
			array[num++] = ShowWords.ReplaceText("AccountTimeOut");
			DataGridViewRowCollection rows7 = this.dgvData.Rows;
			values = array;
			rows7.Add(values);
			num = 0;
			array = new string[this.dgvData.ColumnCount];
			array[num++] = "8";
			array[num++] = "LocalTicketType";
			array[num++] = Settings.Instance.LocalTicketType.ToString();
			array[num++] = ShowWords.ReplaceText("LocalTicketType");
			DataGridViewRowCollection rows8 = this.dgvData.Rows;
			values = array;
			rows8.Add(values);
			num = 0;
			array = new string[this.dgvData.ColumnCount];
			array[num++] = "9";
			array[num++] = "ProductShowType";
			array[num++] = Settings.Instance.ProductShowType.ToString();
			array[num++] = ShowWords.ReplaceText("ProductShowType");
			DataGridViewRowCollection rows9 = this.dgvData.Rows;
			values = array;
			rows9.Add(values);
			num = 0;
			array = new string[this.dgvData.ColumnCount];
			array[num++] = "10";
			array[num++] = "BusinessControlType";
			array[num++] = Settings.Instance.BusinessControlType.ToString();
			array[num++] = ShowWords.ReplaceText("BusinessControlType");
			DataGridViewRowCollection rows10 = this.dgvData.Rows;
			values = array;
			rows10.Add(values);
			num = 0;
			array = new string[this.dgvData.ColumnCount];
			array[num++] = "11";
			array[num++] = "ShowTicketMaxCount";
			array[num++] = Settings.Instance.ShowTicketMaxCount.ToString();
			array[num++] = ShowWords.ReplaceText("ShowTicketMaxCount");
			DataGridViewRowCollection rows11 = this.dgvData.Rows;
			values = array;
			rows11.Add(values);
			num = 0;
			array = new string[this.dgvData.ColumnCount];
			array[num++] = "12";
			array[num++] = "BarcodePrintCount";
			array[num++] = Settings.Instance.BarcodePrintCount.ToString();
			array[num++] = ShowWords.ReplaceText("BarcodePrintCount");
			DataGridViewRowCollection rows12 = this.dgvData.Rows;
			values = array;
			rows12.Add(values);
			num = 0;
			array = new string[this.dgvData.ColumnCount];
			array[num++] = "13";
			array[num++] = "LabStepControler";
			array[num++] = Settings.Instance.LabStepControler.ToString();
			array[num++] = ShowWords.ReplaceText("LabStepControler");
			DataGridViewRowCollection rows13 = this.dgvData.Rows;
			values = array;
			rows13.Add(values);
			num = 0;
			array = new string[this.dgvData.ColumnCount];
			array[num++] = "14";
			array[num++] = "LabPrintCode";
			array[num++] = Settings.Instance.LabPrintCode.ToString();
			array[num++] = ShowWords.ReplaceText("LabPrintCode");
			DataGridViewRowCollection rows14 = this.dgvData.Rows;
			values = array;
			rows14.Add(values);
			num = 0;
			array = new string[this.dgvData.ColumnCount];
			array[num++] = "15";
			array[num++] = "IsLabDynamicRefresh";
			array[num++] = Settings.Instance.IsLabDynamicRefresh.ToString();
			array[num++] = ShowWords.ReplaceText("IsLabDynamicRefresh");
			DataGridViewRowCollection rows15 = this.dgvData.Rows;
			values = array;
			rows15.Add(values);
			num = 0;
			array = new string[this.dgvData.ColumnCount];
			array[num++] = "16";
			array[num++] = "IsDefaultProductSch";
			array[num++] = Settings.Instance.IsDefaultProductSch.ToString();
			array[num++] = ShowWords.ReplaceText("IsDefaultProductSch");
			DataGridViewRowCollection rows16 = this.dgvData.Rows;
			values = array;
			rows16.Add(values);
			num = 0;
			array = new string[this.dgvData.ColumnCount];
			array[num++] = "17";
			array[num++] = "IsDefaultLicenseSch";
			array[num++] = Settings.Instance.IsDefaultLicenseSch.ToString();
			array[num++] = ShowWords.ReplaceText("IsDefaultLicenseSch");
			DataGridViewRowCollection rows17 = this.dgvData.Rows;
			values = array;
			rows17.Add(values);
			num = 0;
			array = new string[this.dgvData.ColumnCount];
			array[num++] = "18";
			array[num++] = "JieSuanLiangDecimal";
			array[num++] = Settings.Instance.JieSuanLiangDecimal.ToString();
			array[num++] = ShowWords.ReplaceText("JieSuanLiangDecimal");
			DataGridViewRowCollection rows18 = this.dgvData.Rows;
			values = array;
			rows18.Add(values);
			num = 0;
			array = new string[this.dgvData.ColumnCount];
			array[num++] = "19";
			array[num++] = "CompanyGroup";
			array[num++] = Settings.Instance.CompanyGroup.ToString();
			array[num++] = ShowWords.ReplaceText("CompanyGroup");
			DataGridViewRowCollection rows19 = this.dgvData.Rows;
			values = array;
			rows19.Add(values);
			bool flag = this.dgvData.Rows.Count > 0;
			if (flag)
			{
				this.GetCurrentItem(0);
			}
		}

		// Token: 0x06000737 RID: 1847 RVA: 0x000B3ACA File Offset: 0x000B1CCA
		private void btnModify_Click(object sender, EventArgs e)
		{
			this.OpenForm(typeof(frmKeyCodeEdit), ((ButtonItem)sender).Text, BaseForm.FormActtion.Modify, this._FrmName);
		}

		// Token: 0x06000738 RID: 1848 RVA: 0x000B3AF0 File Offset: 0x000B1CF0
		private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			bool flag = e.RowIndex >= 0;
			if (flag)
			{
				this.GetCurrentItem(e.RowIndex);
			}
		}

		// Token: 0x06000739 RID: 1849 RVA: 0x000B3B20 File Offset: 0x000B1D20
		private void dgvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			bool flag = e.RowIndex >= 0;
			if (flag)
			{
				this.OpenForm(typeof(frmKeyCodeEdit), this.btnModify.Text, BaseForm.FormActtion.Modify, this._FrmName);
			}
		}

		// Token: 0x0600073A RID: 1850 RVA: 0x000B3B63 File Offset: 0x000B1D63
		private void GetCurrentItem(int rowindex)
		{
			this._CurrentId = int.Parse(this.dgvData.Rows[rowindex].Cells[0].Value.ToString());
		}
	}
}
