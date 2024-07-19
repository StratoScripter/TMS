using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Assistant;
using AutocompleteMenuNS;
using Base;
using DAL.Base.SQSConfig;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using DevComponents.DotNetBar.Layout;
using DevComponents.Editors;
using DevComponents.Editors.DateTimeAdv;
using IDCardRead;
using Model;
using Model.SQSConfig;
using SQSClient.Properties;

namespace SQSClient
{
	// Token: 0x02000063 RID: 99
	public partial class frmCheckIn : BaseDialogForm
	{
		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060004BF RID: 1215 RVA: 0x00077414 File Offset: 0x00075614
		// (set) Token: 0x060004C0 RID: 1216 RVA: 0x0007742C File Offset: 0x0007562C
		public IDCard ModIDCard
		{
			get
			{
				return this._ModIDCard;
			}
			set
			{
				this._ModIDCard = value;
				this.layIdentity.Enabled = false;
				bool flag = this._ModIDCard.IdCardNo == null;
				if (flag)
				{
					this._Modman = null;
					this.rImagePhoto.Image = null;
					this.txtName.Text = "";
					this.txtSex.Text = "";
					this.txtNation.Text = "";
					this.tInputBirthday.Text = "";
					this.txtAddress.Text = "";
					this.txtIDCard.Text = "";
					this.txtValidterm.Text = "";
					this.rdoRoleDriver.Checked = (this.rdoRoleSupercargo.Checked = false);
				}
				else
				{
					this._Modman = DalT_truckman.Instance.GetModel("IDCard", this._ModIDCard.IdCardNo);
					bool flag2 = this._Modman == null;
					if (flag2)
					{
						this._Saved = false;
						this._Modman = new ModT_truckman();
						this._Modman.PinYinMa = "";
						this._Modman.IDCard = this._ModIDCard.IdCardNo;
						this._Modman.Sex = this._ModIDCard.Sex;
						this._Modman.Role = 1;
					}
					this._Modman.Name = this._ModIDCard.Name;
					this._Modman.Photo = this._ModIDCard.Photo;
					this._Modman.Nation = this._ModIDCard.Nation;
					this._Modman.Department = this._ModIDCard.Department;
					this._Modman.ValidtermOfStart = this._ModIDCard.ValidtermOfStart;
					this._Modman.ValidtermOfEnd = this._ModIDCard.ValidtermOfEnd;
					this._Modman.Address = this._ModIDCard.Address;
					MemoryStream memoryStream = new MemoryStream();
					for (int i = 0; i < this._ModIDCard.Photo.Length; i++)
					{
						memoryStream.WriteByte(this._ModIDCard.Photo[i]);
					}
					this.rImagePhoto.Image = Image.FromStream(memoryStream);
					this.txtName.Text = this._ModIDCard.Name;
					this.txtSex.Text = this._ModIDCard.Sex;
					this.txtNation.Text = this._ModIDCard.Nation;
					this.tInputBirthday.Text = this.GetShowTime(this._ModIDCard.Birthday);
					this.txtAddress.Text = this._ModIDCard.Address;
					this.txtIDCard.Text = this._ModIDCard.IdCardNo;
					this.txtValidterm.Text = this.GetShowTime(this._ModIDCard.ValidtermOfStart) + "-" + this.GetShowTime(this._ModIDCard.ValidtermOfEnd);
					this.rdoRoleDriver.Checked = (this._Modman.Role == 1);
					this.rdoRoleSupercargo.Checked = (this._Modman.Role == 2);
				}
			}
		}

		// Token: 0x060004C1 RID: 1217 RVA: 0x0007778C File Offset: 0x0007598C
		private string GetShowTime(string str)
		{
			string result;
			try
			{
				int num = 0;
				string text = str.Substring(num, 4);
				num += 4;
				string text2 = str.Substring(num, 2);
				num += 2;
				string text3 = str.Substring(num, 2);
				num += 2;
				result = string.Concat(new string[]
				{
					text,
					"/",
					text2,
					"/",
					text3
				});
			}
			catch
			{
				result = str;
			}
			return result;
		}

		// Token: 0x060004C2 RID: 1218 RVA: 0x00077808 File Offset: 0x00075A08
		private string GetSaveTime(string str)
		{
			string result;
			try
			{
				string[] array = str.Split(new char[]
				{
					'/'
				});
				result = array[0] + array[1].PadLeft(2, '0') + array[2].PadLeft(2, '0');
			}
			catch
			{
				result = str;
			}
			return result;
		}

		// Token: 0x060004C3 RID: 1219 RVA: 0x00077864 File Offset: 0x00075A64
		public frmCheckIn(string text, BaseForm.FormActtion act, int id, string dir)
		{
			this.InitializeComponent();
			this.SetText(this);
			this.Text = text;
			this._Act = act;
			this._CurrentId = id;
			this._Direct = dir;
		}

		// Token: 0x060004C4 RID: 1220 RVA: 0x000778D8 File Offset: 0x00075AD8
		private void frmCheckIn_Load(object sender, EventArgs e)
		{
			this._IDCard.Init();
			this.BindAutocompleteMenu1();
		}

		// Token: 0x060004C5 RID: 1221 RVA: 0x000778F0 File Offset: 0x00075AF0
		private void BindAutocompleteMenu1()
		{
			List<AutocompleteItem> list = new List<AutocompleteItem>();
			List<ModT_truckman> allList = DalT_truckman.Instance.GetAllList();
			foreach (ModT_truckman modT_truckman in allList)
			{
				list.Add(new MulticolumnAutocompleteItem(new string[]
				{
					modT_truckman.Name,
					modT_truckman.IDCard
				}, modT_truckman.IDCard, true, true));
			}
			base.BindAutocompleteMenu(this.txtIDCard, list);
		}

		// Token: 0x060004C6 RID: 1222 RVA: 0x00077988 File Offset: 0x00075B88
		private void btnSave_Click(object sender, EventArgs e)
		{
			bool flag = !this.TextCheck();
			if (!flag)
			{
				bool flag2 = this._Modman == null;
				if (flag2)
				{
					this._Modman = DalT_truckman.Instance.GetModel("IDCard", this.txtIDCard.Text.Trim());
					bool flag3 = this._Modman == null;
					if (flag3)
					{
						this._Saved = false;
						this._Modman = new ModT_truckman();
						this._Modman.IDCard = this.txtIDCard.Text.Trim();
					}
				}
				this._Modman.Name = this.txtName.Text.Trim();
				this._Modman.PinYinMa = "";
				this._Modman.Sex = this.txtSex.Text.Trim();
				string[] array = this.txtValidterm.Text.Split(new char[]
				{
					'-'
				});
				this._Modman.ValidtermOfStart = this.GetSaveTime(array[0]);
				this._Modman.ValidtermOfEnd = this.GetSaveTime(array[1]);
				bool @checked = this.rdoRoleDriver.Checked;
				if (@checked)
				{
					this._Modman.Role = 1;
				}
				else
				{
					this._Modman.Role = 2;
				}
				this._Modman.Weight = (decimal)this.dInputWeight.Value;
				this._Modman.DriverCode = this.txtDriverCode.Text;
				this._Modman.QualifyCode = this.txtQualifyCode.Text;
				this._Modman.PhoneNum = this.txtPhoneNum.Text;
				this._Modman.WeChat = this.txtWeChat.Text;
				this._Modman.EmailAddr = this.txtEmailAddr.Text;
				this._Modman.Examine = true;
				this._Modman.Enable = this.chkEnable.Checked;
				this._Modman.Used = false;
				bool saved = this._Saved;
				if (saved)
				{
					DalT_truckman.Instance.Update(this._Modman);
				}
				else
				{
					DalT_truckman.Instance.AddNoReturn(this._Modman);
				}
				base.ShowMsg(Messages.SaveTrue, "", "");
				this.OnOperateSuccess(this._Modman, true);
				base.DialogResult = DialogResult.Yes;
			}
		}

		// Token: 0x060004C7 RID: 1223 RVA: 0x00077C00 File Offset: 0x00075E00
		private bool TextCheck()
		{
			bool flag = string.IsNullOrWhiteSpace(this.txtName.Text.Trim());
			bool result;
			if (flag)
			{
				base.ShowMsg(Messages.NameNull, "", "");
				this.txtName.Focus();
				result = false;
			}
			else
			{
				bool flag2 = string.IsNullOrWhiteSpace(this.txtSex.Text.Trim());
				if (flag2)
				{
					base.ShowMsg(Messages.SexNull, "", "");
					this.txtSex.Focus();
					result = false;
				}
				else
				{
					bool flag3 = string.IsNullOrWhiteSpace(this.txtIDCard.Text.Trim());
					if (flag3)
					{
						base.ShowMsg(Messages.IDNull, "", "");
						this.txtIDCard.Focus();
						result = false;
					}
					else
					{
						bool flag4 = RegexHelper.IsID(this.txtIDCard.Text.Trim());
						if (flag4)
						{
							base.ShowMsg(Messages.IDFormat, "", "");
							this.txtIDCard.Focus();
							result = false;
						}
						else
						{
							bool flag5 = !this.CheckValidterm(this.txtValidterm.Text);
							if (flag5)
							{
								base.ShowMsg(Messages.ValidtermFormat, "", "");
								this.txtValidterm.Focus();
								result = false;
							}
							else
							{
								bool flag6 = !string.IsNullOrWhiteSpace(this.txtPhoneNum.Text.Trim()) && RegexHelper.IsPhone(this.txtPhoneNum.Text.Trim());
								if (flag6)
								{
									base.ShowMsg(Messages.PhoneNumFormat, "", "");
									this.txtPhoneNum.Focus();
									result = false;
								}
								else
								{
									bool flag7 = !string.IsNullOrWhiteSpace(this.txtEmailAddr.Text.Trim()) && !RegexHelper.IsEmail(this.txtEmailAddr.Text.Trim());
									if (flag7)
									{
										base.ShowMsg(Messages.EmailFormat, "", "");
										this.txtEmailAddr.Focus();
										result = false;
									}
									else
									{
										result = true;
									}
								}
							}
						}
					}
				}
			}
			return result;
		}

		// Token: 0x060004C8 RID: 1224 RVA: 0x00077E20 File Offset: 0x00076020
		private bool CheckValidterm(string str)
		{
			bool flag = !str.Contains("-");
			bool result;
			if (flag)
			{
				result = false;
			}
			else
			{
				string[] array = this.txtValidterm.Text.Split(new char[]
				{
					'-'
				});
				string[] array2 = array[0].Split(new char[]
				{
					'/'
				});
				string[] array3 = array[1].Split(new char[]
				{
					'/'
				});
				bool flag2 = array2.Length != 3 || (array3.Length != 3 && !(array3[0] == "长期"));
				result = !flag2;
			}
			return result;
		}

		// Token: 0x060004C9 RID: 1225 RVA: 0x00077EBF File Offset: 0x000760BF
		private void frmCheckIn_FormClosing(object sender, FormClosingEventArgs e)
		{
			this._IDCard.Close();
		}

		// Token: 0x060004CA RID: 1226 RVA: 0x00077ED0 File Offset: 0x000760D0
		private void btnRead_Click(object sender, EventArgs e)
		{
			bool flag = this._IDCard.FillData();
			if (flag)
			{
				this._IsRead = true;
				this.ModIDCard = this._IDCard.IDC;
			}
		}

		// Token: 0x060004CB RID: 1227 RVA: 0x00077F08 File Offset: 0x00076108
		private void txtIDCard_TextChanged(object sender, EventArgs e)
		{
			bool flag = !this._IsRead;
			if (flag)
			{
				this._Modman = DalT_truckman.Instance.GetModel("IDCard", this.txtIDCard.Text.Trim());
				bool flag2 = this._Modman != null;
				if (flag2)
				{
					this.txtIDCard.Enabled = false;
					this.txtName.Text = this._Modman.Name;
					this.txtSex.Text = this._Modman.Sex;
					this.txtSex.Enabled = false;
					this.txtNation.Text = this._Modman.Nation;
					this.tInputBirthday.Enabled = false;
					this.txtAddress.Text = this._Modman.Address;
					this.txtIDCard.Text = this._Modman.IDCard;
					this.txtValidterm.Text = this.GetShowTime(this._Modman.ValidtermOfStart) + "-" + this.GetShowTime(this._Modman.ValidtermOfEnd);
					this.rdoRoleDriver.Checked = (this._Modman.Role == 1);
					this.rdoRoleSupercargo.Checked = (this._Modman.Role == 2);
					this.chkEnable.Checked = this._Modman.Enable;
					this.dInputWeight.Value = (double)this._Modman.Weight;
					this.txtDriverCode.Text = this._Modman.DriverCode;
					this.txtQualifyCode.Text = this._Modman.QualifyCode;
					this.txtPhoneNum.Text = this._Modman.PhoneNum;
					this.txtWeChat.Text = this._Modman.WeChat;
					this.txtEmailAddr.Text = this._Modman.EmailAddr;
					try
					{
						MemoryStream memoryStream = new MemoryStream();
						for (int i = 0; i < this._Modman.Photo.Length; i++)
						{
							memoryStream.WriteByte(this._Modman.Photo[i]);
						}
						this.rImagePhoto.Image = Image.FromStream(memoryStream);
					}
					catch
					{
					}
				}
			}
		}

		// Token: 0x04000829 RID: 2089
		private CVRActive _IDCard = new CVRActive();

		// Token: 0x0400082A RID: 2090
		private bool _IsRead = false;

		// Token: 0x0400082B RID: 2091
		private ModT_truckman _Modman = null;

		// Token: 0x0400082C RID: 2092
		private bool _Saved = true;

		// Token: 0x0400082D RID: 2093
		private IDCard _ModIDCard = new IDCard();
	}
}
