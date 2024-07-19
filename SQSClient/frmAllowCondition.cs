using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Base;
using DAL.Base;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Layout;
using DevComponents.Editors;
using Model;
using Model.SQSConfig;
using SQSClient.Properties;

namespace SQSClient
{
	// Token: 0x02000027 RID: 39
	public partial class frmAllowCondition : BaseDialogForm
	{
		// Token: 0x060001E1 RID: 481 RVA: 0x0003854C File Offset: 0x0003674C
		public frmAllowCondition(string text)
		{
			this.InitializeComponent();
			this.SetText(this);
			frmAllowCondition.condition = text;
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x000385CC File Offset: 0x000367CC
		private void frmAllowCondition_Load(object sender, EventArgs e)
		{
			List<ModItemC> allCoumn = DalSQLBase.Instance.GetAllCoumn("t_ticket");
			int num = 0;
			foreach (ModItemC modItemC in allCoumn)
			{
				this.itemlist[num] = modItemC.ItemName;
				this.itemlisttranslate[num] = ShowWords.ReplaceText(modItemC.ItemName);
				num++;
			}
			num = 0;
			this.itemtimelist = new string[]
			{
				"StartTime",
				"EndTime",
				"FirstTime",
				"SecondTime",
				"VoiceTime",
				"ValiFirstTime",
				"ValiSecondTime",
				"ZhiDanTime",
				"JieSuanTime",
				"EnterTime",
				"LeaveTime",
				"TakeCardTime",
				"VehicleTime",
				"VehicleTimeOut",
				"VehicleTimeSt"
			};
			foreach (string text in this.itemtimelist)
			{
				this.itemtimelisttranslate[num] = ShowWords.ReplaceText(text);
				num++;
			}
			this.conditionitem.Clear();
			bool flag = string.IsNullOrEmpty(frmAllowCondition.condition);
			if (flag)
			{
				this.iItemCount.Value = 0;
			}
			else
			{
				string[] array2 = frmAllowCondition.condition.Split(new char[]
				{
					'&'
				});
				foreach (string item in array2)
				{
					this.conditionitem.Add(item);
				}
				this.iItemCount.Value = this.conditionitem.Count;
			}
			this.OriginItemCount = this.iItemCount.Value;
			this.CreatControls(this.iItemCount.Value);
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x000387C4 File Offset: 0x000369C4
		private void CreatControls(int iItemCount)
		{
			this.panel1.Controls.Clear();
			Label label = new Label();
			label.AutoSize = true;
			label.Location = new Point(88, 10);
			label.Name = "label2";
			label.Size = new Size(29, 12);
			label.Text = "Type";
			Label label2 = new Label();
			label2.AutoSize = true;
			label2.Location = new Point(208, 10);
			label2.Name = "label3";
			label2.Size = new Size(29, 12);
			label2.Text = "Item";
			Label label3 = new Label();
			label3.AutoSize = true;
			label3.Location = new Point(302, 10);
			label3.Name = "label4";
			label3.Size = new Size(77, 12);
			label3.Text = "OperatorType";
			Label label4 = new Label();
			label4.AutoSize = true;
			label4.Location = new Point(425, 10);
			label4.Name = "label5";
			label4.Size = new Size(35, 12);
			label4.Text = "Value";
			this.panel1.Controls.Add(label);
			this.panel1.Controls.Add(label2);
			this.panel1.Controls.Add(label3);
			this.panel1.Controls.Add(label4);
			for (int i = 1; i < iItemCount + 1; i++)
			{
				Label label5 = new Label();
				label5.AutoSize = true;
				label5.Location = new Point(10, 10 + 30 * i);
				label5.Name = "lbl" + i.ToString();
				label5.Size = new Size(40, 12);
				label5.Text = i.ToString();
				this.panel1.Controls.Add(label5);
				ComboBox comboBox = new ComboBox();
				comboBox.FormattingEnabled = true;
				comboBox.Location = new Point(310, 10 + 30 * i);
				comboBox.Name = "cbxOperatorType" + i.ToString();
				comboBox.Size = new Size(60, 20);
				comboBox.Items.AddRange(new object[]
				{
					"=",
					">",
					"<",
					">=",
					"<="
				});
				this.panel1.Controls.Add(comboBox);
				ComboBox comboBox2 = new ComboBox();
				comboBox2.FormattingEnabled = true;
				comboBox2.Location = new Point(180, 10 + 30 * i);
				comboBox2.Name = "cbxItem" + i.ToString();
				comboBox2.Size = new Size(100, 20);
				this.panel1.Controls.Add(comboBox2);
				ComboBox comboBox3 = new ComboBox();
				comboBox3.FormattingEnabled = true;
				comboBox3.Location = new Point(70, 10 + 30 * i);
				comboBox3.Name = "cbxType" + i.ToString();
				comboBox3.Size = new Size(80, 20);
				comboBox3.DataSource = Enum.GetValues(typeof(frmAllowCondition.Type));
				comboBox3.SelectedValueChanged += this.cbx_SelectedValueChanged;
				this.panel1.Controls.Add(comboBox3);
				TextBox textBox = new TextBox();
				textBox.Location = new Point(400, 10 + 30 * i);
				textBox.Name = "tbx" + i.ToString();
				textBox.Size = new Size(100, 21);
				this.panel1.Controls.Add(textBox);
			}
			this.ControlDataInit(iItemCount);
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x00038BE0 File Offset: 0x00036DE0
		private void ControlDataInit(int itemcount)
		{
			int num = 1;
			foreach (string text in this.conditionitem)
			{
				bool flag = num == itemcount + 1;
				if (flag)
				{
					break;
				}
				string operatorType = this.GetOperatorType(text);
				string[] array = text.Split(new string[]
				{
					operatorType
				}, StringSplitOptions.RemoveEmptyEntries);
				string[] array2 = array[0].Split(new char[]
				{
					'.'
				});
				this.panel1.Controls["cbxType" + num.ToString()].Text = ((ComboBox)this.panel1.Controls["cbxType" + num.ToString()]).Items[int.Parse(array2[0])].ToString();
				this.panel1.Controls["cbxItem" + num.ToString()].Text = ShowWords.ReplaceText(array2[2]);
				bool flag2 = array2[0] == "0";
				if (flag2)
				{
					string[] array3 = new string[200];
					Array.Copy(this.itemlisttranslate, array3, array3.Length);
					((ComboBox)this.panel1.Controls["cbxItem" + num.ToString()]).DataSource = array3;
				}
				else
				{
					bool flag3 = array2[0] == "1";
					if (flag3)
					{
						string[] array4 = new string[20];
						Array.Copy(this.itemtimelisttranslate, array4, array4.Length);
						((ComboBox)this.panel1.Controls["cbxItem" + num.ToString()]).DataSource = array4;
					}
				}
				this.panel1.Controls["cbxOperatorType" + num.ToString()].Text = operatorType;
				this.panel1.Controls["tbx" + num.ToString()].Text = array[1];
				num++;
			}
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x00038E38 File Offset: 0x00037038
		private string GetOperatorType(string expression)
		{
			string text = null;
			bool flag = expression.Contains(">=");
			string result;
			if (flag)
			{
				text = ">=";
				result = text;
			}
			else
			{
				bool flag2 = expression.Contains("<=");
				if (flag2)
				{
					text = "<=";
					result = text;
				}
				else
				{
					bool flag3 = expression.Contains(">");
					if (flag3)
					{
						text = ">";
						result = text;
					}
					else
					{
						bool flag4 = expression.Contains("<");
						if (flag4)
						{
							text = "<";
							result = text;
						}
						else
						{
							bool flag5 = expression.Contains("=");
							if (flag5)
							{
								text = "=";
								result = text;
							}
							else
							{
								result = text;
							}
						}
					}
				}
			}
			return result;
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x00038ED8 File Offset: 0x000370D8
		private void cbx_SelectedValueChanged(object sender, EventArgs e)
		{
			string str = ((ComboBox)sender).Name.Replace("cbxType", "");
			bool flag = ((ComboBox)sender).SelectedItem.ToString() == "Standard";
			if (flag)
			{
				string[] array = new string[200];
				Array.Copy(this.itemlisttranslate, array, array.Length);
				((ComboBox)this.panel1.Controls["cbxItem" + str]).DataSource = array;
			}
			else
			{
				bool flag2 = ((ComboBox)sender).SelectedItem.ToString() == "Time";
				if (flag2)
				{
					string[] array2 = new string[20];
					Array.Copy(this.itemtimelisttranslate, array2, array2.Length);
					((ComboBox)this.panel1.Controls["cbxItem" + str]).DataSource = array2;
				}
			}
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x00038FC8 File Offset: 0x000371C8
		private void btnConfirm_Click(object sender, EventArgs e)
		{
			bool flag = this.iItemCount.Value < this.OriginItemCount;
			if (flag)
			{
				DialogResult dialogResult = MessageBox.Show("Less than before !", "Confirm", MessageBoxButtons.OKCancel);
				bool flag2 = dialogResult == DialogResult.OK;
				if (flag2)
				{
					this.CreatControls(this.iItemCount.Value);
					return;
				}
				bool flag3 = dialogResult == DialogResult.Cancel;
				if (flag3)
				{
					this.iItemCount.Value = this.OriginItemCount;
					return;
				}
			}
			this.CreatControls(this.iItemCount.Value);
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x0003904C File Offset: 0x0003724C
		private void menuSave_Click(object sender, EventArgs e)
		{
			bool flag = !this.ItemEmptyCheck();
			if (flag)
			{
				base.ShowMsg(Messages.ParaNull, "", "");
			}
			else
			{
				string[] array = new string[this.iItemCount.Value];
				for (int i = 1; i < this.iItemCount.Value + 1; i++)
				{
					int num = (this.panel1.Controls["cbxType" + i.ToString()].Text == "Standard") ? 0 : 1;
					string text = "t_ticket";
					bool flag2 = num == 1 && Array.IndexOf<string>(this.itemtimelisttranslate, this.panel1.Controls["cbxItem" + i.ToString()].Text) == 4;
					if (flag2)
					{
						text = "t_quequeLM";
					}
					string text2 = null;
					bool flag3 = num == 0;
					if (flag3)
					{
						text2 = this.itemlist[Array.IndexOf<string>(this.itemlisttranslate, this.panel1.Controls["cbxItem" + i.ToString()].Text)];
					}
					bool flag4 = num == 1;
					if (flag4)
					{
						text2 = this.itemtimelist[Array.IndexOf<string>(this.itemtimelisttranslate, this.panel1.Controls["cbxItem" + i.ToString()].Text)];
					}
					string text3 = this.panel1.Controls["cbxOperatorType" + i.ToString()].Text;
					string text4 = this.panel1.Controls["tbx" + i.ToString()].Text.Trim();
					array[i - 1] = string.Format("{0}.{1}.{2}{3}{4}", new object[]
					{
						num,
						text,
						text2,
						text3,
						text4
					});
				}
				frmAllowCondition.condition = string.Join("&", array);
				base.ShowMsg(Messages.SaveTrue, "", "");
			}
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x00039280 File Offset: 0x00037480
		private bool ItemEmptyCheck()
		{
			foreach (object obj in this.panel1.Controls)
			{
				bool flag = obj.GetType() == typeof(ComboBox);
				if (flag)
				{
					bool flag2 = string.IsNullOrEmpty(((ComboBox)obj).Text.Trim());
					if (flag2)
					{
						return false;
					}
				}
				bool flag3 = obj.GetType() == typeof(TextBox);
				if (flag3)
				{
					bool flag4 = string.IsNullOrEmpty(((TextBox)obj).Text.Trim());
					if (flag4)
					{
						return false;
					}
				}
			}
			return true;
		}

		// Token: 0x0400036B RID: 875
		public static string condition = "";

		// Token: 0x0400036C RID: 876
		private int OriginItemCount = 0;

		// Token: 0x0400036D RID: 877
		private List<string> conditionitem = new List<string>();

		// Token: 0x0400036E RID: 878
		private string[] itemlist = new string[200];

		// Token: 0x0400036F RID: 879
		private string[] itemlisttranslate = new string[200];

		// Token: 0x04000370 RID: 880
		private string[] itemtimelist = new string[20];

		// Token: 0x04000371 RID: 881
		private string[] itemtimelisttranslate = new string[20];

		// Token: 0x020000C2 RID: 194
		private enum Type
		{
			// Token: 0x04000FE8 RID: 4072
			Standard,
			// Token: 0x04000FE9 RID: 4073
			Time
		}
	}
}
