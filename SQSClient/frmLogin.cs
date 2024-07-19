using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Assistant;
using AutocompleteMenuNS;
using Base;
using DAL.Base.SQSConfig;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using DevComponents.DotNetBar.Layout;
using Model;
using Model.SQSConfig;
using SQSClient.Properties;

namespace SQSClient
{
	// Token: 0x02000094 RID: 148
	public partial class frmLogin : BaseDialogForm
	{
		// Token: 0x06000848 RID: 2120
		[DllImport("user32.dll")]
		private static extern bool AnimateWindow(IntPtr handle, int ms, int flags);

		// Token: 0x06000849 RID: 2121 RVA: 0x000CCCAC File Offset: 0x000CAEAC
		public frmLogin()
		{
			this.InitializeComponent();
			this.SetText(this);
			string language = ConfigSettings.Instance.Language;
			string text = language;
			if (text != null)
			{
				if (text == "ZH")
				{
					this.pictureBox1.Image = Resources.Name1;
					return;
				}
				if (text == "EN")
				{
					this.pictureBox1.Image = Resources.Name1_EN;
					return;
				}
			}
			this.pictureBox1.Image = Resources.Name1;
		}

		// Token: 0x0600084A RID: 2122 RVA: 0x000CCD47 File Offset: 0x000CAF47
		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);
			frmLogin.AnimateWindow(base.Handle, 1000, 655360);
			this.txtPwd.Focus();
			this.txtUser.Focus();
		}

		// Token: 0x0600084B RID: 2123 RVA: 0x000CCD80 File Offset: 0x000CAF80
		protected override void OnFormClosing(FormClosingEventArgs e)
		{
			base.OnFormClosing(e);
			frmLogin.AnimateWindow(base.Handle, 1000, 589824);
		}

		// Token: 0x0600084C RID: 2124 RVA: 0x000CCDA1 File Offset: 0x000CAFA1
		private void frmLogin_Load(object sender, EventArgs e)
		{
			this.InitControl();
		}

		// Token: 0x0600084D RID: 2125 RVA: 0x000CCDAB File Offset: 0x000CAFAB
		private void InitControl()
		{
			this.BindAutocompleteMenu();
		}

		// Token: 0x0600084E RID: 2126 RVA: 0x000CCDB8 File Offset: 0x000CAFB8
		private void BindAutocompleteMenu()
		{
			this.autocompleteMenu.TargetControlWrapper = null;
			this.autocompleteMenu.SetAutocompleteMenu(this.txtUser, null);
			List<AutocompleteItem> list = new List<AutocompleteItem>();
			List<ModSys_user> list2 = DalSys_user.Instance.GetList("State", true);
			foreach (ModSys_user modSys_user in list2)
			{
				list.Add(new SubstringAutocompleteItem(modSys_user.UserName, false));
			}
			this.autocompleteMenu.MinFragmentLength = 1;
			this.autocompleteMenu.SetAutocompleteMenu(this.txtUser, this.autocompleteMenu);
			this.autocompleteMenu.SetAutocompleteItems(list);
		}

		// Token: 0x0600084F RID: 2127 RVA: 0x00003040 File Offset: 0x00001240
		private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
		{
		}

		// Token: 0x06000850 RID: 2128 RVA: 0x000CCE88 File Offset: 0x000CB088
		private void btnLogin_Click(object sender, EventArgs e)
		{
			bool flag = this.UserCheck();
			if (flag)
			{
				GlobalKey.UserName = this.txtUser.Text;
				GlobalKey.PhysicalMacAddr = PCInfo.GetMacAddressByNetworkInformation();
				GlobalKey.ScreenWidth = Screen.PrimaryScreen.Bounds.Width;
				GlobalKey.ScreenHeight = Screen.PrimaryScreen.Bounds.Height;
				base.Hide();
				frmMain frmMain = new frmMain();
				bool flag2 = DialogResult.Yes == frmMain.ShowDialog();
				if (flag2)
				{
					this.InitControl();
					this.txtPwd.Text = string.Empty;
					base.Show();
				}
				else
				{
					base.Close();
				}
			}
		}

		// Token: 0x06000851 RID: 2129 RVA: 0x000CCF38 File Offset: 0x000CB138
		private bool UserCheck()
		{
			bool flag = string.IsNullOrWhiteSpace(this.txtUser.Text) || string.IsNullOrWhiteSpace(this.txtPwd.Text);
			bool result;
			if (flag)
			{
				base.ShowMsg(Messages.UserOrPwdNull, "", "");
				this.txtUser.Focus();
				result = false;
			}
			else
			{
				bool flag2 = this.txtUser.Text.Equals(KeyCode.User_Admin) && CodeHelper.GetMD5(this.txtPwd.Text).Equals(KeyCode.User_Pwd);
				if (flag2)
				{
					GlobalKey.UserId = 0;
					GlobalKey.GroupId = 0;
					GlobalKey.Department = 0;
					GlobalKey.Role = 0;
					GlobalKey.Manageself = false;
					GlobalKey.GroupName = ShowWords.ReplaceText("Engineer");
					result = true;
				}
				else
				{
					ModSys_user model = DalSys_user.Instance.GetModel("UserName", this.txtUser.Text);
					bool flag3 = model == null;
					if (flag3)
					{
						base.ShowMsg(Messages.UserHavent, "", "");
						result = false;
					}
					else
					{
						bool flag4 = !CodeHelper.GetMD5(this.txtPwd.Text).Equals(model.Password);
						if (flag4)
						{
							base.ShowMsg(Messages.PwdError, "", "");
							result = false;
						}
						else
						{
							bool flag5 = !model.State;
							if (flag5)
							{
								base.ShowMsg(Messages.UserHavent, "", "");
								result = false;
							}
							else
							{
								GlobalKey.UserId = model.Id;
								GlobalKey.GroupId = model.GroupId;
								GlobalKey.Role = model.Role;
								GlobalKey.Manageself = model.Manageself;
								ModSys_group model2 = DalSys_group.Instance.GetModel(model.GroupId);
								GlobalKey.GroupName = model2.GroupName;
								GlobalKey.Department = model2.Department;
								result = true;
							}
						}
					}
				}
			}
			return result;
		}

		// Token: 0x06000852 RID: 2130 RVA: 0x000CD120 File Offset: 0x000CB320
		private void btnQuit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		// Token: 0x06000853 RID: 2131 RVA: 0x000CD12C File Offset: 0x000CB32C
		private void pnlLogin_Paint(object sender, PaintEventArgs e)
		{
			Graphics graphics = e.Graphics;
			Color color = Color.FromArgb(255, 255, 255);
			Color color2 = Color.FromArgb(65, 91, 168);
			LinearGradientBrush brush = new LinearGradientBrush(this.pnlLogin.ClientRectangle, color, color2, LinearGradientMode.ForwardDiagonal);
			graphics.FillRectangle(brush, this.pnlLogin.ClientRectangle);
		}

		// Token: 0x06000854 RID: 2132 RVA: 0x000CD18C File Offset: 0x000CB38C
		private void txtPwd_KeyPress(object sender, KeyPressEventArgs e)
		{
			bool flag = e.KeyChar == '\r';
			if (flag)
			{
				this.btnLogin_Click(null, null);
			}
		}

		// Token: 0x04000E29 RID: 3625
		private AutocompleteMenu autocompleteMenu = new AutocompleteMenu();
	}
}
