using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Base;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using DevComponents.DotNetBar.Layout;
using Model;
using SQSClient.Properties;

namespace SQSClient
{
	// Token: 0x02000082 RID: 130
	public partial class frmKeyCodeEdit : BaseDialogForm
	{
		// Token: 0x06000712 RID: 1810 RVA: 0x000B038E File Offset: 0x000AE58E
		public frmKeyCodeEdit(string text, BaseForm.FormActtion act, int id, string dir)
		{
			this.InitializeComponent();
			this.SetText(this);
			this.Text = text;
			this._Act = act;
			this._CurrentId = id;
			this._Direct = dir;
		}

		// Token: 0x06000713 RID: 1811 RVA: 0x000B03CC File Offset: 0x000AE5CC
		private void frmKeyCodeEdit_Load(object sender, EventArgs e)
		{
			this.InitControl();
			this.LoadData();
		}

		// Token: 0x06000714 RID: 1812 RVA: 0x00003040 File Offset: 0x00001240
		private void InitControl()
		{
		}

		// Token: 0x06000715 RID: 1813 RVA: 0x000B03E0 File Offset: 0x000AE5E0
		protected override void LoadData()
		{
			bool flag = BaseForm.FormActtion.Modify == this._Act;
			if (flag)
			{
				this.tbxKeyCode.ReadOnly = true;
				this.tbxRemark.ReadOnly = true;
				switch (this._CurrentId)
				{
				case 1:
					this.tbxKeyCode.Text = "PortName";
					this.tbxKeyValue.Text = Settings.Instance.PortName;
					this.tbxRemark.Text = ShowWords.ReplaceText("COMName");
					break;
				case 2:
					this.tbxKeyCode.Text = "BaudRate";
					this.tbxKeyValue.Text = Settings.Instance.BaudRate.ToString();
					this.tbxRemark.Text = ShowWords.ReplaceText("Baudrate");
					break;
				case 3:
					this.tbxKeyCode.Text = "LoadPrinter";
					this.tbxKeyValue.Text = Settings.Instance.LoadPrinter;
					this.tbxRemark.Text = ShowWords.ReplaceText("LoadPrinter");
					break;
				case 4:
					this.tbxKeyCode.Text = "UnloadPrinter";
					this.tbxKeyValue.Text = Settings.Instance.UnloadPrinter;
					this.tbxRemark.Text = ShowWords.ReplaceText("UnloadPrinter");
					break;
				case 5:
					this.tbxKeyCode.Text = "HisReportPrinter";
					this.tbxKeyValue.Text = Settings.Instance.HisReportPrinter;
					this.tbxRemark.Text = ShowWords.ReplaceText("HisReportPrinter");
					break;
				case 6:
					this.tbxKeyCode.Text = "AccountRemindEnable";
					this.tbxKeyValue.Text = Settings.Instance.AccountRemindEnable.ToString();
					this.tbxRemark.Text = ShowWords.ReplaceText("AccountRemindEnable");
					break;
				case 7:
					this.tbxKeyCode.Text = "AccountTimeOut";
					this.tbxKeyValue.Text = Settings.Instance.AccountTimeOut.ToString();
					this.tbxRemark.Text = ShowWords.ReplaceText("AccountTimeOut");
					break;
				case 8:
					this.tbxKeyCode.Text = "LocalTicketType";
					this.tbxKeyValue.Text = Settings.Instance.LocalTicketType.ToString();
					this.tbxRemark.Text = ShowWords.ReplaceText("LocalTicketType");
					break;
				case 9:
					this.tbxKeyCode.Text = "ProductShowType";
					this.tbxKeyValue.Text = Settings.Instance.ProductShowType.ToString();
					this.tbxRemark.Text = ShowWords.ReplaceText("ProductShowType");
					break;
				case 10:
					this.tbxKeyCode.Text = "BusinessControlType";
					this.tbxKeyValue.Text = Settings.Instance.BusinessControlType.ToString();
					this.tbxRemark.Text = ShowWords.ReplaceText("BusinessControlType");
					break;
				case 11:
					this.tbxKeyCode.Text = "ShowTicketMaxCount";
					this.tbxKeyValue.Text = Settings.Instance.ShowTicketMaxCount.ToString();
					this.tbxRemark.Text = ShowWords.ReplaceText("ShowTicketMaxCount");
					break;
				case 12:
					this.tbxKeyCode.Text = "BarcodePrintCount";
					this.tbxKeyValue.Text = Settings.Instance.BarcodePrintCount.ToString();
					this.tbxRemark.Text = ShowWords.ReplaceText("BarcodePrintCount");
					break;
				case 13:
					this.tbxKeyCode.Text = "LabStepControler";
					this.tbxKeyValue.Text = Settings.Instance.LabStepControler.ToString();
					this.tbxRemark.Text = ShowWords.ReplaceText("LabStepControler");
					break;
				case 14:
					this.tbxKeyCode.Text = "LabPrintCode";
					this.tbxKeyValue.Text = Settings.Instance.LabPrintCode.ToString();
					this.tbxRemark.Text = ShowWords.ReplaceText("LabPrintCode");
					break;
				case 15:
					this.tbxKeyCode.Text = "IsLabDynamicRefresh";
					this.tbxKeyValue.Text = Settings.Instance.IsLabDynamicRefresh.ToString();
					this.tbxRemark.Text = ShowWords.ReplaceText("IsLabDynamicRefresh");
					break;
				case 16:
					this.tbxKeyCode.Text = "IsDefaultProductSch";
					this.tbxKeyValue.Text = Settings.Instance.IsDefaultProductSch.ToString();
					this.tbxRemark.Text = ShowWords.ReplaceText("IsDefaultProductSch");
					break;
				case 17:
					this.tbxKeyCode.Text = "IsDefaultLicenseSch";
					this.tbxKeyValue.Text = Settings.Instance.IsDefaultLicenseSch.ToString();
					this.tbxRemark.Text = ShowWords.ReplaceText("IsDefaultLicenseSch");
					break;
				case 18:
					this.tbxKeyCode.Text = "JieSuanLiangDecimal";
					this.tbxKeyValue.Text = Settings.Instance.JieSuanLiangDecimal.ToString();
					this.tbxRemark.Text = ShowWords.ReplaceText("JieSuanLiangDecimal");
					break;
				case 19:
					this.tbxKeyCode.Text = "CompanyGroup";
					this.tbxKeyValue.Text = Settings.Instance.CompanyGroup.ToString();
					this.tbxRemark.Text = ShowWords.ReplaceText("CompanyGroup ");
					break;
				}
			}
		}

		// Token: 0x06000716 RID: 1814 RVA: 0x000B09D8 File Offset: 0x000AEBD8
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
					base.DialogResult = DialogResult.Yes;
				}
			}
		}

		// Token: 0x06000717 RID: 1815 RVA: 0x000B0A20 File Offset: 0x000AEC20
		private bool Modify()
		{
			bool result;
			try
			{
				this.old = Settings.Instance[this.tbxKeyCode.Text.Trim()].ToString();
				string text = this.tbxKeyCode.Text.Trim();
				string text2 = text;
				if (text2 != null)
				{
					uint num = <PrivateImplementationDetails>.ComputeStringHash(text2);
					if (num <= 1446152922U)
					{
						if (num <= 930769709U)
						{
							if (num <= 695956055U)
							{
								if (num != 113110643U)
								{
									if (num == 695956055U)
									{
										if (text2 == "AccountTimeOut")
										{
											Settings.Instance.AccountTimeOut = Convert.ToInt32(this.tbxKeyValue.Text.Trim());
										}
									}
								}
								else if (text2 == "LoadPrinter")
								{
									Settings.Instance.LoadPrinter = this.tbxKeyValue.Text.Trim();
								}
							}
							else if (num != 715925199U)
							{
								if (num == 930769709U)
								{
									if (text2 == "ProductShowType")
									{
										Settings.Instance.ProductShowType = Convert.ToInt32(this.tbxKeyValue.Text.Trim());
									}
								}
							}
							else if (text2 == "CompanyGroup")
							{
								Settings.Instance.CompanyGroup = Convert.ToInt32(this.tbxKeyValue.Text.Trim());
							}
						}
						else if (num <= 1006268436U)
						{
							if (num != 978556936U)
							{
								if (num == 1006268436U)
								{
									if (text2 == "JieSuanLiangDecimal")
									{
										Settings.Instance.JieSuanLiangDecimal = Convert.ToInt32(this.tbxKeyValue.Text.Trim());
									}
								}
							}
							else if (text2 == "LabStepControler")
							{
								Settings.Instance.LabStepControler = Convert.ToInt32(this.tbxKeyValue.Text.Trim());
							}
						}
						else if (num != 1007442772U)
						{
							if (num != 1348268033U)
							{
								if (num == 1446152922U)
								{
									if (text2 == "LabPrintCode")
									{
										Settings.Instance.LabPrintCode = this.tbxKeyValue.Text.Trim();
									}
								}
							}
							else if (text2 == "IsDefaultProductSch")
							{
								Settings.Instance.IsDefaultProductSch = bool.Parse(this.tbxKeyValue.Text.Trim());
							}
						}
						else if (text2 == "IsLabDynamicRefresh")
						{
							Settings.Instance.IsLabDynamicRefresh = bool.Parse(this.tbxKeyValue.Text.Trim());
						}
					}
					else if (num <= 2574140150U)
					{
						if (num <= 2070782164U)
						{
							if (num != 1690369359U)
							{
								if (num == 2070782164U)
								{
									if (text2 == "LocalTicketType")
									{
										Settings.Instance.LocalTicketType = Convert.ToInt32(this.tbxKeyValue.Text.Trim());
									}
								}
							}
							else if (text2 == "BaudRate")
							{
								Settings.Instance.BaudRate = Convert.ToInt32(this.tbxKeyValue.Text.Trim());
							}
						}
						else if (num != 2077121349U)
						{
							if (num != 2251630213U)
							{
								if (num == 2574140150U)
								{
									if (text2 == "UnloadPrinter")
									{
										Settings.Instance.UnloadPrinter = this.tbxKeyValue.Text.Trim();
									}
								}
							}
							else if (text2 == "IsDefaultLicenseSch")
							{
								Settings.Instance.IsDefaultLicenseSch = bool.Parse(this.tbxKeyValue.Text.Trim());
							}
						}
						else if (text2 == "PortName")
						{
							Settings.Instance.PortName = this.tbxKeyValue.Text.Trim();
						}
					}
					else if (num <= 3478446639U)
					{
						if (num != 2648484869U)
						{
							if (num == 3478446639U)
							{
								if (text2 == "HisReportPrinter")
								{
									Settings.Instance.HisReportPrinter = this.tbxKeyValue.Text.Trim();
								}
							}
						}
						else if (text2 == "ShowTicketMaxCount")
						{
							Settings.Instance.ShowTicketMaxCount = Convert.ToInt32(this.tbxKeyValue.Text.Trim());
						}
					}
					else if (num != 3513229594U)
					{
						if (num != 3901898388U)
						{
							if (num == 4158050477U)
							{
								if (text2 == "BarcodePrintCount")
								{
									Settings.Instance.BarcodePrintCount = Convert.ToInt32(this.tbxKeyValue.Text.Trim());
								}
							}
						}
						else if (text2 == "BusinessControlType")
						{
							Settings.Instance.BusinessControlType = Convert.ToInt32(this.tbxKeyValue.Text.Trim());
						}
					}
					else if (text2 == "AccountRemindEnable")
					{
						Settings.Instance.AccountRemindEnable = bool.Parse(this.tbxKeyValue.Text.Trim());
					}
				}
				Settings.Instance.Save();
				this.OnOperateSuccess(new
				{
					Name = this.tbxKeyCode.Text.Trim(),
					OldValue = this.old,
					NewValue = this.tbxKeyValue.Text
				}, true);
				result = true;
			}
			catch (Exception ex)
			{
				this.OnOperateException(new
				{
					Name = this.tbxKeyCode.Text.Trim(),
					OldValue = this.old,
					NewValue = this.tbxKeyValue.Text
				}, false, ex.Message);
				base.ShowMsg(Messages.KeyCodeFormat, "", "");
				result = false;
			}
			return result;
		}

		// Token: 0x06000718 RID: 1816 RVA: 0x000B109C File Offset: 0x000AF29C
		private bool TextCheck()
		{
			bool flag = string.IsNullOrWhiteSpace(this.tbxKeyCode.Text);
			bool result;
			if (flag)
			{
				base.ShowMsg(Messages.KeyCodeNull, "", "");
				result = false;
			}
			else
			{
				result = true;
			}
			return result;
		}

		// Token: 0x04000C25 RID: 3109
		private string old;
	}
}
