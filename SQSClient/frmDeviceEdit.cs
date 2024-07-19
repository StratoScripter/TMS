using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Assistant;
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
	// Token: 0x02000080 RID: 128
	public partial class frmDeviceEdit : BaseDialogForm
	{
		// Token: 0x060006FA RID: 1786 RVA: 0x000AC330 File Offset: 0x000AA530
		public frmDeviceEdit(string text, BaseForm.FormActtion act, int id, string dir)
		{
			this.InitializeComponent();
			this.SetText(this);
			this.Text = text;
			this._Act = act;
			this._CurrentId = id;
			this._Direct = dir;
		}

		// Token: 0x060006FB RID: 1787 RVA: 0x000AC384 File Offset: 0x000AA584
		private void frmDeviceEdit_Load(object sender, EventArgs e)
		{
			this.InitControl();
			this.LoadData();
		}

		// Token: 0x060006FC RID: 1788 RVA: 0x000AC398 File Offset: 0x000AA598
		private void InitControl()
		{
			this.cmbProtocolType.Items.Clear();
			foreach (object obj in Enum.GetValues(typeof(ProtocolType)))
			{
				ProtocolType protocolType = (ProtocolType)obj;
				this.cmbProtocolType.Items.Add(protocolType);
			}
			this.cmbMediaType.Items.Clear();
			foreach (object obj2 in Enum.GetValues(typeof(MediaType)))
			{
				MediaType mediaType = (MediaType)obj2;
				this.cmbMediaType.Items.Add(mediaType);
			}
			this.cmbCOM.Items.Clear();
			List<ModCfg_portpara> allList = DalCfg_portpara.Instance.GetAllList();
			for (int i = 0; i < allList.Count; i++)
			{
				this.cmbCOM.Items.Add(allList[i].PortName);
			}
			List<ModCfg_pc> list = DalCfg_pc.Instance.GetList("PCType", 0);
			this.cmbPC.BindDataSouce(list, "Name", "PinYinMa", "Id");
		}

		// Token: 0x060006FD RID: 1789 RVA: 0x000AC52C File Offset: 0x000AA72C
		protected override void LoadData()
		{
			bool flag = BaseForm.FormActtion.Modify == this._Act;
			if (flag)
			{
				this._mod = DalCfg_device.Instance.GetModel(this._CurrentId);
				bool flag2 = this._mod == null;
				if (flag2)
				{
					base.ShowMsg(Messages.ObjNonExist, "", "");
					base.Close();
				}
				else
				{
					this.txtName.Text = this._mod.Name;
					this.txtName.Enabled = false;
					this.cmbProtocolType.Text = this._mod.ProtocolType;
					this.cmbMediaType.Text = this._mod.MediaType;
					this.cmbPC.SelectedValue = this._mod.PCId;
					this.nudDevIndex.Value = this._mod.Code;
					this.nudAddr.Value = this._mod.DevAddr;
					this.iInputWays.Value = this._mod.Ways;
					string[] array = this._mod.MediaPara.Split(new char[]
					{
						':'
					});
					bool flag3 = array.Length > 1;
					if (flag3)
					{
						this.chkINTC.Checked = true;
						this.txtIP.Text = array[0];
						this.txtServerPort.Text = array[1];
					}
					else
					{
						this.chkCOMC.Checked = true;
						this.cmbCOM.Text = array[0];
					}
					this.rtbRemark.Text = this._mod.Remark;
					this.chkState.Checked = this._mod.State;
				}
			}
			else
			{
				bool flag4 = this._Act == BaseForm.FormActtion.Add;
				if (flag4)
				{
					ModCfg_device modelByColumnDesc = DalCfg_device.Instance.GetModelByColumnDesc("Code");
					bool flag5 = modelByColumnDesc == null;
					if (flag5)
					{
						this.nudDevIndex.Value = 1;
					}
					else
					{
						this.nudDevIndex.Value = modelByColumnDesc.Code + 1;
					}
					this.txtName.Text = ShowWords.ReplaceText("DeviceName") + this.nudDevIndex.Value.ToString();
				}
			}
		}

		// Token: 0x060006FE RID: 1790 RVA: 0x000AC774 File Offset: 0x000AA974
		private void btnSave_Click(object sender, EventArgs e)
		{
			bool flag = !this.TextCheck();
			if (!flag)
			{
				bool flag2 = this._Act == BaseForm.FormActtion.Add;
				bool flag3;
				if (flag2)
				{
					flag3 = this.Add();
				}
				else
				{
					flag3 = this.Modify();
				}
				bool flag4 = flag3;
				if (flag4)
				{
					base.DialogResult = DialogResult.Yes;
				}
			}
		}

		// Token: 0x060006FF RID: 1791 RVA: 0x000AC7C4 File Offset: 0x000AA9C4
		private bool Add()
		{
			this._mod.Name = this.txtName.Text.Trim();
			this._mod.Code = this.nudDevIndex.Value;
			this._mod.DevAddr = this.nudAddr.Value;
			this._mod.Ways = this.iInputWays.Value;
			this._mod.PCId = (int)this.cmbPC.SelectedValue;
			this._mod.ProtocolType = this.cmbProtocolType.Text;
			bool @checked = this.chkCOMC.Checked;
			if (@checked)
			{
				this._mod.MediaPara = this.cmbCOM.Text;
			}
			else
			{
				this._mod.MediaPara = this.txtIP.Text + ":" + this.txtServerPort.Text;
			}
			this._mod.MediaType = this.cmbMediaType.Text;
			this._mod.DevType = "SQ-3000";
			this._mod.State = this.chkState.Checked;
			this._mod.Remark = this.rtbRemark.Text.Trim();
			this._mod.PinYinMa = this._mod.Name.GetFirstPinyin();
			this._mod.DeviceTime = DateTime.Now;
			bool flag = base.IsExist("cfg_device", "Name", this.txtName.Text.Trim(), SqlDbType.NVarChar);
			bool result;
			if (flag)
			{
				base.ShowMsg(Messages.DeviceHaved, "", "");
				this.txtName.Focus();
				result = false;
			}
			else
			{
				bool flag2 = base.IsExist("cfg_device", "Code", this._mod.Code, SqlDbType.Int);
				if (flag2)
				{
					base.ShowMsg(Messages.DeviceCodeHaved, "", "");
					this.nudDevIndex.Focus();
					result = false;
				}
				else
				{
					bool flag3 = false;
					bool flag4 = DalCfg_device.Instance.CheckExistDevAddr(this._mod, 0, ref flag3);
					if (flag4)
					{
						bool flag5 = flag3;
						if (flag5)
						{
							base.ShowMsg(Messages.DeviceAddrCheck, "", "");
							this.nudAddr.Focus();
							return false;
						}
					}
					int num = DalCfg_device.Instance.Add(this._mod);
					bool flag6 = num <= 0;
					if (flag6)
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
			}
			return result;
		}

		// Token: 0x06000700 RID: 1792 RVA: 0x000ACA9C File Offset: 0x000AAC9C
		private bool Modify()
		{
			ModCfg_device oldValue = this._mod.Clone() as ModCfg_device;
			this._mod.Name = this.txtName.Text.Trim();
			this._mod.PinYinMa = this._mod.Name.GetFirstPinyin();
			this._mod.PCId = (int)this.cmbPC.SelectedValue;
			this._mod.ProtocolType = this.cmbProtocolType.Text;
			string text = this.cmbProtocolType.Text;
			string text2 = text;
			if (text2 != null)
			{
				if (!(text2 == "RTU") && !(text2 == "TCP"))
				{
					if (text2 == "DBI" || text2 == "OPC")
					{
						this._mod.MediaType = "";
					}
				}
				else
				{
					this._mod.MediaType = this.cmbMediaType.Text;
				}
			}
			bool @checked = this.chkCOMC.Checked;
			if (@checked)
			{
				this._mod.MediaPara = this.cmbCOM.Text;
			}
			else
			{
				this._mod.MediaPara = this.txtIP.Text + ":" + this.txtServerPort.Text;
			}
			this._mod.Code = this.nudDevIndex.Value;
			this._mod.DevAddr = this.nudAddr.Value;
			this._mod.Ways = this.iInputWays.Value;
			this._mod.Remark = this.rtbRemark.Text.Trim();
			this._mod.DevType = "SQ-3000";
			this._mod.State = this.chkState.Checked;
			bool flag = base.IsExistOutSelf("cfg_device", "Name", this.txtName.Text.Trim(), SqlDbType.NVarChar, this._CurrentId);
			bool result;
			if (flag)
			{
				base.ShowMsg(Messages.DeviceHaved, "", "");
				this.txtName.Focus();
				result = false;
			}
			else
			{
				bool flag2 = base.IsExistOutSelf("cfg_device", "Code", this._mod.Code, SqlDbType.Int, this._CurrentId);
				if (flag2)
				{
					base.ShowMsg(Messages.DeviceCodeHaved, "", "");
					this.nudDevIndex.Focus();
					result = false;
				}
				else
				{
					bool flag3 = false;
					bool flag4 = DalCfg_device.Instance.CheckExistDevAddr(this._mod, this._CurrentId, ref flag3);
					if (flag4)
					{
						bool flag5 = flag3;
						if (flag5)
						{
							base.ShowMsg(Messages.DeviceAddrCheck, "", "");
							this.nudAddr.Focus();
							return false;
						}
					}
					bool flag6 = !DalCfg_device.Instance.Update(this._mod);
					if (flag6)
					{
						this.OnOperateFail(this._mod, false);
						base.ShowMsg(Messages.ModifyFalse, "", "");
						result = false;
					}
					else
					{
						bool flag7 = !this._mod.State;
						if (flag7)
						{
							DalCfg_unit.Instance.GetList("DeviceName", this._mod.Name).ForEach(delegate(ModCfg_unit u)
							{
								u.State = false;
								DalCfg_unit.Instance.Update(u);
							});
						}
						this.OnOperateSuccess(this._mod, oldValue, true);
						result = true;
					}
				}
			}
			return result;
		}

		// Token: 0x06000701 RID: 1793 RVA: 0x000ACE3C File Offset: 0x000AB03C
		private bool TextCheck()
		{
			bool flag = string.IsNullOrWhiteSpace(this.txtName.Text);
			bool result;
			if (flag)
			{
				base.ShowMsg(Messages.DeviceNull, "", "");
				this.txtName.Focus();
				result = false;
			}
			else
			{
				bool flag2 = string.IsNullOrWhiteSpace(this.cmbPC.Text);
				if (flag2)
				{
					base.ShowMsg(Messages.PCNull, "", "");
					this.cmbPC.Focus();
					result = false;
				}
				else
				{
					bool flag3 = string.IsNullOrWhiteSpace(this.cmbProtocolType.Text);
					if (flag3)
					{
						base.ShowMsg(Messages.CommModeNull, "", "");
						this.cmbProtocolType.Focus();
						result = false;
					}
					else
					{
						int value = this.nudAddr.Value;
						bool @checked = this.chkCOMC.Checked;
						if (@checked)
						{
							bool flag4 = string.IsNullOrEmpty(this.cmbMediaType.Text);
							if (flag4)
							{
								base.ShowMsg(Messages.CommProtocolNull, "", "");
								this.cmbMediaType.Focus();
								return false;
							}
							bool flag5 = string.IsNullOrEmpty(this.cmbCOM.Text);
							if (flag5)
							{
								base.ShowMsg(Messages.ComNull, "", "");
								this.cmbCOM.Focus();
								return false;
							}
						}
						else
						{
							bool flag6 = string.IsNullOrEmpty(this.txtIP.Text) || string.IsNullOrEmpty(this.txtServerPort.Text);
							if (flag6)
							{
								base.ShowMsg(Messages.CommParaNull, "", "");
								bool flag7 = string.IsNullOrEmpty(this.txtIP.Text);
								if (flag7)
								{
									this.txtIP.Focus();
								}
								else
								{
									this.txtServerPort.Focus();
								}
								return false;
							}
							bool flag8 = !RegexHelper.IsIPv4(this.txtIP.Text);
							if (flag8)
							{
								base.ShowMsg(Messages.IPFormat, "", "");
								this.txtIP.Focus();
								return false;
							}
						}
						result = true;
					}
				}
			}
			return result;
		}

		// Token: 0x06000702 RID: 1794 RVA: 0x000AD070 File Offset: 0x000AB270
		private void cmbProtocolType_TextChanged(object sender, EventArgs e)
		{
			string text = this.cmbProtocolType.Text;
			string text2 = text;
			if (text2 != null)
			{
				if (!(text2 == "RTU"))
				{
					if (!(text2 == "TCP"))
					{
						if (!(text2 == "DBI"))
						{
							if (text2 == "OPC")
							{
								this.layItemCOMC.Visible = false;
								this.layItemINTC.Visible = false;
								this.chkCOMC.Checked = false;
								this.layItemMediaType.Visible = false;
								this.layItemCOM.Visible = false;
								this.layItemPara.Visible = false;
								this.layItemIP.Visible = true;
								this.layItemServerPort.Visible = true;
							}
						}
						else
						{
							this.layItemCOMC.Visible = false;
							this.layItemINTC.Visible = false;
							this.chkCOMC.Checked = false;
							this.layItemMediaType.Visible = false;
							this.layItemCOM.Visible = false;
							this.layItemPara.Visible = false;
							this.layItemIP.Visible = true;
							this.layItemServerPort.Visible = true;
						}
					}
					else
					{
						this.layItemCOMC.Visible = true;
						this.layItemINTC.Visible = true;
						this.chkCOMC.Checked = true;
						this.layItemMediaType.Visible = true;
						this.layItemCOM.Visible = true;
						this.layItemPara.Visible = true;
					}
				}
				else
				{
					this.layItemCOMC.Visible = true;
					this.layItemINTC.Visible = true;
					this.chkCOMC.Checked = true;
					this.layItemMediaType.Visible = true;
					this.layItemCOM.Visible = true;
					this.layItemPara.Visible = true;
				}
			}
		}

		// Token: 0x06000703 RID: 1795 RVA: 0x000AD250 File Offset: 0x000AB450
		private void chkCOMC_CheckedChanged(object sender, EventArgs e)
		{
			this.layItemCOM.Visible = this.chkCOMC.Checked;
			this.layItemPara.Visible = this.chkCOMC.Checked;
			this.layItemIP.Visible = !this.chkCOMC.Checked;
			this.layItemServerPort.Visible = !this.chkCOMC.Checked;
		}

		// Token: 0x06000704 RID: 1796 RVA: 0x00003040 File Offset: 0x00001240
		private void chkINTC_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000705 RID: 1797 RVA: 0x000AD2C0 File Offset: 0x000AB4C0
		private void btnPara_Click(object sender, EventArgs e)
		{
			OfficeForm officeForm = (OfficeForm)Activator.CreateInstance(typeof(frmSerialEdit), new object[]
			{
				((ButtonX)sender).Text,
				BaseForm.FormActtion.Modify,
				this.cmbCOM.SelectedIndex
			});
			bool flag = officeForm != null;
			if (flag)
			{
				bool flag2 = officeForm.ShowDialog() == DialogResult.Yes;
				if (flag2)
				{
					this.LoadData("");
				}
			}
		}

		// Token: 0x04000BE7 RID: 3047
		private ModCfg_device _mod = new ModCfg_device();
	}
}
