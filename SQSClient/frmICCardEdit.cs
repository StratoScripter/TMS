using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Assistant;
using Base;
using DAL.Base.SQSConfig;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using DevComponents.DotNetBar.Layout;
using ICHandle;
using Model;
using Model.SQSConfig;
using SQSClient.Properties;

namespace SQSClient
{
	// Token: 0x02000074 RID: 116
	public partial class frmICCardEdit : BaseDialogForm
	{
		// Token: 0x06000644 RID: 1604 RVA: 0x0009BB20 File Offset: 0x00099D20
		public frmICCardEdit(string text, BaseForm.FormActtion act, int id, string dir)
		{
			this.InitializeComponent();
			this.SetText(this);
			this.Text = text;
			this._Act = act;
			this._CurrentId = id;
			this._Direct = dir;
		}

		// Token: 0x06000645 RID: 1605 RVA: 0x0009BB8B File Offset: 0x00099D8B
		private void frmICCardEdit_Load(object sender, EventArgs e)
		{
			this.InitControl();
			this.LoadData();
		}

		// Token: 0x06000646 RID: 1606 RVA: 0x00003040 File Offset: 0x00001240
		private void InitControl()
		{
		}

		// Token: 0x06000647 RID: 1607 RVA: 0x0009BB9C File Offset: 0x00099D9C
		protected override void LoadData()
		{
			bool flag = BaseForm.FormActtion.Modify == this._Act;
			if (flag)
			{
				this._mod = DalT_iccard.Instance.GetModel(this._CurrentId);
				bool flag2 = this._mod == null;
				if (flag2)
				{
					base.ShowMsg(Messages.ObjNonExist, "", "");
					base.Close();
				}
				else
				{
					this.tbxNum.Text = this._mod.CardNum;
					this.tbxNum.Enabled = false;
					this.btnRead.Enabled = false;
					this.chkState.Checked = this._mod.State;
					this.rtbRemark.Text = this._mod.Remark;
					this.txtSetBlockValue.Text = this._mod.BlockValue;
					this.cbxType.Checked = (this._mod.Type == 10);
				}
			}
			else
			{
				bool flag3 = this._Act == BaseForm.FormActtion.Add;
				if (flag3)
				{
					bool flag4 = !Settings.Instance.PortName.Trim().Equals("COM0");
					if (flag4)
					{
						int num = DalT_iccard.Instance.GetMaxCount();
						num++;
						this.txtSetBlockValue.Text = num.ToString();
					}
				}
			}
			bool flag5 = Settings.Instance.PortName.Trim().Equals("COM0");
			if (flag5)
			{
				this.txtICBlockValue.Enabled = false;
				this.txtSetBlockValue.Enabled = false;
				this.btnICBlockValue.Enabled = false;
				this.btnSetBlockValue.Enabled = false;
			}
		}

		// Token: 0x06000648 RID: 1608 RVA: 0x0009BD4C File Offset: 0x00099F4C
		private void btnRead_Click(object sender, EventArgs e)
		{
			try
			{
				this.tbxNum.Text = ICTicket.ReadCardNum();
			}
			catch
			{
				base.ShowMsg(Messages.ReadCardFalse, "", "");
			}
		}

		// Token: 0x06000649 RID: 1609 RVA: 0x0009BD9C File Offset: 0x00099F9C
		private void btnSave_Click(object sender, EventArgs e)
		{
			bool flag = !this.TextCheck();
			if (!flag)
			{
				bool flag2 = !Settings.Instance.PortName.Trim().Equals("COM0");
				if (flag2)
				{
					bool flag3 = !this.WriteBlockValue();
					if (flag3)
					{
						return;
					}
				}
				bool flag4 = this._Act == BaseForm.FormActtion.Add;
				bool flag5;
				if (flag4)
				{
					flag5 = this.Add();
				}
				else
				{
					flag5 = this.Modify();
				}
				bool flag6 = flag5;
				if (flag6)
				{
					base.DialogResult = DialogResult.Yes;
				}
			}
		}

		// Token: 0x0600064A RID: 1610 RVA: 0x0009BE24 File Offset: 0x0009A024
		private bool Add()
		{
			this._mod.CardNum = this.tbxNum.Text.Trim();
			this._mod.Remark = this.rtbRemark.Text.Trim();
			this._mod.State = this.chkState.Checked;
			this._mod.Type = (this.cbxType.Checked ? 10 : 0);
			bool flag = !string.IsNullOrEmpty(this.txtSetBlockValue.Text) && !Settings.Instance.PortName.Trim().Equals("COM0");
			if (flag)
			{
				bool flag2 = this.txtSetBlockValue.Text.Length > 10;
				if (flag2)
				{
					base.ShowMsg("写扇区值长度不可超过10", "", "");
					return false;
				}
				this._mod.BlockValue = this.txtSetBlockValue.Text.Trim(new char[]
				{
					' '
				});
				bool flag3 = base.IsExist("t_iccard", "BlockValue", this._mod.BlockValue, SqlDbType.NVarChar);
				if (flag3)
				{
					base.ShowMsg("已存在相同扇区值的卡！", "", "");
					this.txtSetBlockValue.Focus();
					return false;
				}
			}
			bool flag4 = base.IsExist("t_iccard", "CardNum", this._mod.CardNum, SqlDbType.NVarChar);
			bool result;
			if (flag4)
			{
				base.ShowMsg(Messages.ICHaved, "", "");
				this.tbxNum.Focus();
				result = false;
			}
			else
			{
				int num = DalT_iccard.Instance.Add(this._mod);
				bool flag5 = num <= 0;
				if (flag5)
				{
					this.OnOperateFail(this._mod, false);
					base.ShowMsg(Messages.AddFalse, "", "");
					result = false;
				}
				else
				{
					this.OnOperateSuccess(this._mod, true);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600064B RID: 1611 RVA: 0x0009C034 File Offset: 0x0009A234
		private bool Modify()
		{
			ModT_iccard oldValue = this._mod.Clone() as ModT_iccard;
			this._mod.Remark = this.rtbRemark.Text.Trim();
			this._mod.State = this.chkState.Checked;
			this._mod.Type = (this.cbxType.Checked ? 10 : 0);
			bool flag = !string.IsNullOrEmpty(this.txtSetBlockValue.Text) && !Settings.Instance.PortName.Trim().Equals("COM0");
			if (flag)
			{
				bool flag2 = this.txtSetBlockValue.Text.Length > 10;
				if (flag2)
				{
					base.ShowMsg("写扇区值长度不可超过10", "", "");
					return false;
				}
				this._mod.BlockValue = this.txtSetBlockValue.Text.Trim(new char[]
				{
					' '
				});
				bool flag3 = base.IsExist("t_iccard", "BlockValue", this._mod.BlockValue, SqlDbType.NVarChar);
				if (flag3)
				{
					base.ShowMsg("已存在相同扇区值的卡！", "", "");
					this.txtSetBlockValue.Focus();
					return false;
				}
			}
			bool flag4 = !DalT_iccard.Instance.Update(this._mod);
			bool result;
			if (flag4)
			{
				this.OnOperateFail(this._mod, false);
				base.ShowMsg(Messages.ModifyFalse, "", "");
				result = false;
			}
			else
			{
				this.OnOperateSuccess(this._mod, oldValue, true);
				result = true;
			}
			return result;
		}

		// Token: 0x0600064C RID: 1612 RVA: 0x0009C1E8 File Offset: 0x0009A3E8
		private void btnInit_Click(object sender, EventArgs e)
		{
			bool flag = ICTicket.WriteCard(this.SetCardMod());
			if (flag)
			{
				base.ShowMsg(Messages.InitTrue, "", "");
			}
			else
			{
				base.ShowMsg(Messages.InitFalse, "", "");
			}
		}

		// Token: 0x0600064D RID: 1613 RVA: 0x0009C238 File Offset: 0x0009A438
		public BaseCardMod SetCardMod()
		{
			return new BaseCardMod
			{
				IsValid = 1,
				SysType = 1,
				JiHuaLiang = 0.01,
				VaildTime = "9999-01-01 00:00:00",
				Lisence = ""
			};
		}

		// Token: 0x0600064E RID: 1614 RVA: 0x0009C28C File Offset: 0x0009A48C
		private bool TextCheck()
		{
			bool flag = string.IsNullOrWhiteSpace(this.tbxNum.Text.Trim());
			bool result;
			if (flag)
			{
				base.ShowMsg(Messages.ICNull, "", "");
				this.tbxNum.Focus();
				result = false;
			}
			else
			{
				bool flag2 = this.tbxNum.Text.Length != 8 || !RegexHelper.IsNumAndEnCh1(this.tbxNum.Text.Trim());
				if (flag2)
				{
					base.ShowMsg(Messages.ICFormat, "", "");
					this.tbxNum.Focus();
					result = false;
				}
				else
				{
					bool flag3 = this.txtSetBlockValue.Text.Trim().Length > 0;
					if (flag3)
					{
						try
						{
							int num = Convert.ToInt32(this.txtSetBlockValue.Text.Trim());
							bool flag4 = !num.ToString().Equals(this.txtSetBlockValue.Text.Trim());
							if (flag4)
							{
								base.ShowMsg("BlockValueInteger", "", "");
								this.txtSetBlockValue.Text = num.ToString();
								this.txtSetBlockValue.Focus();
								return false;
							}
						}
						catch
						{
							base.ShowMsg("BlockValueInteger", "", "");
							this.txtSetBlockValue.Focus();
							return false;
						}
					}
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600064F RID: 1615 RVA: 0x00003040 File Offset: 0x00001240
		private void btnReadIDNum_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000650 RID: 1616 RVA: 0x0009C414 File Offset: 0x0009A614
		private void btnICBlockValue_Click(object sender, EventArgs e)
		{
			this.ReadBlockValue();
		}

		// Token: 0x06000651 RID: 1617 RVA: 0x0009C420 File Offset: 0x0009A620
		private void ReadBlockValue()
		{
			bool flag = !Settings.Instance.PortName.Trim().Equals("COM0");
			if (flag)
			{
				string icnum = ICTicket.ReadCardNum();
				bool flag2 = ICTicket.PwdCheck(this.mPwd, 96, icnum, 4);
				if (flag2)
				{
					byte[] bytes = ICTicket.ReadBlock(4);
					try
					{
						this.txtICBlockValue.Text = this.ByteToHexString(bytes, 5);
					}
					catch
					{
						this.txtICBlockValue.Text = "Error";
					}
				}
			}
			else
			{
				MessageBox.Show("串口无效");
			}
		}

		// Token: 0x06000652 RID: 1618 RVA: 0x0009C4C0 File Offset: 0x0009A6C0
		public string ByteToHexString(byte[] bytes, int length)
		{
			string text = "";
			bool flag = bytes != null;
			if (flag)
			{
				for (int i = 0; i < length; i++)
				{
					text = text + bytes[i].ToString("X2") + " ";
				}
			}
			bool flag2 = text.Length > 0 && text.Substring(text.Length - 1, 1) == " ";
			if (flag2)
			{
				text = text.Substring(0, text.Length - 1);
			}
			return text;
		}

		// Token: 0x06000653 RID: 1619 RVA: 0x0009C554 File Offset: 0x0009A754
		private void btnSetBlockValue_Click(object sender, EventArgs e)
		{
			bool flag = !Settings.Instance.PortName.Trim().Equals("COM0");
			if (flag)
			{
				this.WriteBlockValue();
			}
			else
			{
				MessageBox.Show("串口无效");
			}
		}

		// Token: 0x06000654 RID: 1620 RVA: 0x0009C59C File Offset: 0x0009A79C
		private bool WriteBlockValue()
		{
			bool flag = !this.BlockValueCheck();
			bool result;
			if (flag)
			{
				result = false;
			}
			else
			{
				string icnum = ICTicket.ReadCardNum();
				bool flag2 = !ICTicket.PwdCheck(this.mPwd, 96, icnum, 4);
				if (flag2)
				{
					result = false;
				}
				else
				{
					byte[] blockdata = frmICCardEdit.StrToHexByte(this.ResetString(this.txtSetBlockValue.Text.Trim()));
					bool flag3 = !ICTicket.SetBlock(4, blockdata);
					if (flag3)
					{
						MessageBox.Show("下发失败！");
						result = false;
					}
					else
					{
						result = true;
					}
				}
			}
			return result;
		}

		// Token: 0x06000655 RID: 1621 RVA: 0x0009C620 File Offset: 0x0009A820
		private bool BlockValueCheck()
		{
			string pattern = "^\\d+$";
			Regex regex = new Regex(pattern);
			bool flag = !regex.IsMatch(this.txtSetBlockValue.Text);
			bool result;
			if (flag)
			{
				MessageBox.Show("设定的扇区值只能为数字！");
				result = false;
			}
			else
			{
				bool flag2 = this.txtSetBlockValue.Text.Length > 10;
				if (flag2)
				{
					MessageBox.Show("设置的扇区值长度限定为10！");
					result = false;
				}
				else
				{
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06000656 RID: 1622 RVA: 0x0009C694 File Offset: 0x0009A894
		public static byte[] StrToHexByte(string hexString)
		{
			hexString = hexString.Replace(" ", "");
			bool flag = hexString.Length % 2 != 0;
			if (flag)
			{
				hexString += " ";
			}
			byte[] array = new byte[hexString.Length / 2];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = Convert.ToByte(hexString.Substring(i * 2, 2), 16);
			}
			return array;
		}

		// Token: 0x06000657 RID: 1623 RVA: 0x0009C70C File Offset: 0x0009A90C
		private string ResetString(string blockValue)
		{
			string text = "0000000000";
			bool flag = blockValue.Length < 10;
			if (flag)
			{
				blockValue = text.Substring(0, 10 - blockValue.Length) + blockValue + "000000436F6F6479CDFD77";
			}
			return blockValue;
		}

		// Token: 0x04000ABB RID: 2747
		private byte[] mPwd = new byte[]
		{
			byte.MaxValue,
			byte.MaxValue,
			byte.MaxValue,
			byte.MaxValue,
			byte.MaxValue,
			byte.MaxValue
		};

		// Token: 0x04000ABC RID: 2748
		private ModT_iccard _mod = new ModT_iccard();
	}
}
