using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Assistant;
using Base;
using DAL.Base.SQSConfig;
using DevComponents.DotNetBar;
using ICHandle;
using LTDesign;
using Model;
using Model.SQSConfig;
using Newtonsoft.Json;
using SQSClient.Properties;

namespace SQSClient
{
	// Token: 0x0200006F RID: 111
	public partial class frmMain : BaseDialogForm
	{
		// Token: 0x06000598 RID: 1432 RVA: 0x0008F554 File Offset: 0x0008D754
		public frmMain()
		{
			this.InitializeComponent();
			base.StartPosition = FormStartPosition.Manual;
			base.MinimizeBox = true;
			base.Height = Screen.PrimaryScreen.WorkingArea.Height;
			base.Width = Screen.PrimaryScreen.WorkingArea.Width;
			this.SetText(this);
			string language = ConfigSettings.Instance.Language;
			string text = language;
			if (text != null)
			{
				if (text == "ZH")
				{
					this.rmenuCommConfig.Width = 210;
					this.rmenuSystemSetup.Width = 148;
					this.rmenuBaseInfo.Width = 142;
					this.rmenuBusiness.Width = 321;
					this.rmenuQuery.Width = 148;
					this.rmenuLogout.Width = 62;
					this.itemChinese.Checked = true;
					goto IL_188;
				}
				if (text == "EN")
				{
					this.rmenuCommConfig.Width = 260;
					this.rmenuSystemSetup.Width = 161;
					this.rmenuBaseInfo.Width = 173;
					this.rmenuBusiness.Width = 282;
					this.rmenuQuery.Width = 240;
					this.rmenuLogout.Width = 62;
					this.itemEnglish.Checked = true;
					goto IL_188;
				}
			}
			this.itemChinese.Checked = true;
			IL_188:
			BaseDialogForm.OperateEventHandler += this.BaseDialogForm_OperateEventHandler;
		}

		// Token: 0x06000599 RID: 1433 RVA: 0x0008F6FC File Offset: 0x0008D8FC
		private void BaseDialogForm_OperateEventHandler(ModSys_operatelog operateArgs, object req, object resp)
		{
			this.SetBaseInfo(operateArgs);
			operateArgs.Req = JsonConvert.SerializeObject(req);
			bool flag = resp != null;
			if (flag)
			{
				operateArgs.Resp = JsonConvert.SerializeObject(resp);
			}
			int num = DalSys_operatelog.Instance.Add(operateArgs);
		}

		// Token: 0x0600059A RID: 1434 RVA: 0x0008F740 File Offset: 0x0008D940
		private void SetBaseInfo(ModSys_operatelog operateArgs)
		{
			operateArgs.UserName = GlobalKey.UserName;
			operateArgs.PCName = GlobalKey.PCName;
			operateArgs.MAC = GlobalKey.PhysicalMacAddr;
			operateArgs.EditDate = DateTime.Now;
		}

		// Token: 0x0600059B RID: 1435 RVA: 0x0008F774 File Offset: 0x0008D974
		protected override void WndProc(ref Message m)
		{
			bool flag = m.Msg != 163 && m.Msg != 3 && m.WParam != (IntPtr)61458;
			if (flag)
			{
				base.WndProc(ref m);
			}
			bool flag2 = m.Msg == 132 && m.Result == (IntPtr)2;
			if (flag2)
			{
				m.Result = (IntPtr)1;
			}
			bool flag3 = m.Msg == 163;
			if (flag3)
			{
				m.WParam = IntPtr.Zero;
			}
		}

		// Token: 0x0600059C RID: 1436 RVA: 0x0008F814 File Offset: 0x0008DA14
		private void frmMain_Load(object sender, EventArgs e)
		{
			this._canModify = true;
			this.Init();
			this.itemUnitMonitor_Click(this.itemUnitMonitor, null);
			ICTicket.SetCOM(Settings.Instance.PortName, Settings.Instance.BaudRate);
			BaseDialogForm._operateArgs.Category = ShowWords.ReplaceText("LoginUser");
			BaseDialogForm._operateArgs.OperateType = ShowWords.ReplaceText("Login");
			this.OnOperateSuccess(new ModSys_user
			{
				Id = GlobalKey.UserId,
				UserName = GlobalKey.UserName,
				Role = GlobalKey.Role,
				GroupId = GlobalKey.GroupId
			}, true);
		}

		// Token: 0x0600059D RID: 1437 RVA: 0x0008F8C4 File Offset: 0x0008DAC4
		private void Init()
		{
			bool flag = GlobalKey.UserName != null;
			if (flag)
			{
				this.labLoginUser.Text = string.Concat(new string[]
				{
					ShowWords.ReplaceText("LoginUser"),
					":",
					GlobalKey.UserName,
					"   ",
					ShowWords.ReplaceText("GroupType"),
					":",
					GlobalKey.GroupName
				});
			}
			bool flag2 = GlobalKey.UserName == null;
			if (flag2)
			{
				this.sitemLogout.Enabled = false;
				this.InitControl(false, false);
			}
			else
			{
				this.sitemLogout.Enabled = true;
				bool flag3 = GlobalKey.GroupId > 0;
				if (flag3)
				{
					this.SetControl(false, true);
				}
				else
				{
					this.InitControl(true, true);
				}
			}
		}

		// Token: 0x0600059E RID: 1438 RVA: 0x0008F994 File Offset: 0x0008DB94
		private void InitControl(bool visible, bool enabled)
		{
			ModSys_menu model = DalSys_menu.Instance.GetModel("MenuName", "SQSClient");
			bool flag = model == null;
			if (!flag)
			{
				List<ModSys_menu> list = DalSys_menu.Instance.GetList("ParentId", model.Id);
				foreach (ModSys_menu modSys_menu in list)
				{
					RibbonBar ribbonBar = null;
					Control[] array = this.panelMenuMain.Controls.Find("rmenu" + modSys_menu.MenuName, false);
					bool flag2 = array.Length != 0;
					if (flag2)
					{
						ribbonBar = (RibbonBar)array[0];
					}
					BaseItem baseItem = null;
					bool flag3 = this.menuMain.Items.Contains("menu" + modSys_menu.MenuName);
					if (flag3)
					{
						baseItem = this.menuMain.Items["menu" + modSys_menu.MenuName];
					}
					bool flag4 = baseItem != null;
					if (flag4)
					{
						baseItem.Visible = (modSys_menu.State || visible);
						baseItem.Enabled = enabled;
					}
					bool flag5 = ribbonBar != null;
					if (flag5)
					{
						ribbonBar.Visible = (modSys_menu.State || visible);
						ribbonBar.Enabled = enabled;
					}
					this.InitControlState(visible, enabled, modSys_menu.Id, baseItem, ribbonBar);
				}
			}
		}

		// Token: 0x0600059F RID: 1439 RVA: 0x0008FB24 File Offset: 0x0008DD24
		private void InitControlState(bool visible, bool enabled, int id, BaseItem sitem, RibbonBar rbar)
		{
			List<ModSys_menu> list = DalSys_menu.Instance.GetList("ParentId", id);
			foreach (ModSys_menu modSys_menu in list)
			{
				BaseItem baseItem = null;
				bool flag = sitem != null && sitem.SubItems.Contains("item" + modSys_menu.MenuName);
				if (flag)
				{
					baseItem = sitem.SubItems["item" + modSys_menu.MenuName];
				}
				bool flag2 = baseItem != null;
				if (flag2)
				{
					baseItem.Visible = (modSys_menu.State || visible);
					baseItem.Enabled = enabled;
				}
				bool flag3 = rbar != null;
				if (flag3)
				{
					rbar.Items["sitem" + modSys_menu.MenuName].Visible = (modSys_menu.State || visible);
					rbar.Items["sitem" + modSys_menu.MenuName].Enabled = enabled;
				}
				this.InitControlState(visible, enabled, modSys_menu.Id, baseItem, null);
			}
		}

		// Token: 0x060005A0 RID: 1440 RVA: 0x0008FC64 File Offset: 0x0008DE64
		private void SetControl(bool visible, bool enabled)
		{
			ModSys_authority model = DalSys_authority.Instance.GetModel(new List<string>
			{
				"GroupId",
				"MenuName"
			}, new List<object>
			{
				GlobalKey.GroupId,
				"SQSClient"
			});
			bool flag = model == null;
			if (!flag)
			{
				List<ModSys_authority> authorityList = this.GetAuthorityList(model.MenuId);
				foreach (ModSys_authority modSys_authority in authorityList)
				{
					RibbonBar ribbonBar = null;
					Control[] array = this.panelMenuMain.Controls.Find("rmenu" + modSys_authority.MenuName, false);
					bool flag2 = array.Length != 0;
					if (flag2)
					{
						ribbonBar = (RibbonBar)array[0];
					}
					BaseItem baseItem = null;
					bool flag3 = this.menuMain.Items.Contains("menu" + modSys_authority.MenuName);
					if (flag3)
					{
						baseItem = this.menuMain.Items["menu" + modSys_authority.MenuName];
					}
					bool flag4 = baseItem != null;
					if (flag4)
					{
						baseItem.Visible = (modSys_authority.State || visible);
						baseItem.Enabled = (modSys_authority.Choosed > 0);
					}
					bool flag5 = ribbonBar != null;
					if (flag5)
					{
						ribbonBar.Visible = (modSys_authority.State || visible);
						ribbonBar.Enabled = (modSys_authority.Choosed > 0);
					}
					this.SetControlState(visible, enabled, modSys_authority.MenuId, baseItem, ribbonBar);
				}
			}
		}

		// Token: 0x060005A1 RID: 1441 RVA: 0x0008FE2C File Offset: 0x0008E02C
		private void SetControlState(bool visible, bool enabled, int menuid, BaseItem sitem, RibbonBar rbar)
		{
			List<ModSys_authority> authorityList = this.GetAuthorityList(menuid);
			foreach (ModSys_authority modSys_authority in authorityList)
			{
				BaseItem baseItem = null;
				bool flag = sitem != null && sitem.SubItems.Contains("item" + modSys_authority.MenuName);
				if (flag)
				{
					baseItem = sitem.SubItems["item" + modSys_authority.MenuName];
				}
				bool flag2 = baseItem != null;
				if (flag2)
				{
					baseItem.Visible = (modSys_authority.State || visible);
					baseItem.Enabled = (modSys_authority.Choosed > 0);
				}
				bool flag3 = rbar != null;
				if (flag3)
				{
					rbar.Items["sitem" + modSys_authority.MenuName].Visible = (modSys_authority.State || visible);
					rbar.Items["sitem" + modSys_authority.MenuName].Enabled = (modSys_authority.Choosed > 0);
				}
				this.SetControlState(visible, enabled, modSys_authority.MenuId, baseItem, null);
			}
		}

		// Token: 0x060005A2 RID: 1442 RVA: 0x0008FF7C File Offset: 0x0008E17C
		private List<ModSys_authority> GetAuthorityList(int menuid)
		{
			List<string> list = new List<string>();
			list.Add("GroupId='" + GlobalKey.GroupId.ToString() + "'");
			list.Add("ParentId='" + menuid.ToString() + "'");
			return DalSys_authority.Instance.GetListRequire(list, null, null);
		}

		// Token: 0x060005A3 RID: 1443 RVA: 0x0008FFE1 File Offset: 0x0008E1E1
		private void itemProduct_Click(object sender, EventArgs e)
		{
			this.ShowForm(sender, typeof(frmProduct));
		}

		// Token: 0x060005A4 RID: 1444 RVA: 0x0008FFF6 File Offset: 0x0008E1F6
		private void itemTank_Click(object sender, EventArgs e)
		{
			this.ShowForm(sender, typeof(frmTank));
		}

		// Token: 0x060005A5 RID: 1445 RVA: 0x0009000B File Offset: 0x0008E20B
		private void itemTruck_Click(object sender, EventArgs e)
		{
			this.ShowForm(sender, typeof(frmTruck));
		}

		// Token: 0x060005A6 RID: 1446 RVA: 0x00090020 File Offset: 0x0008E220
		private void itemICCard_Click(object sender, EventArgs e)
		{
			this.ShowForm(sender, typeof(frmICCard));
		}

		// Token: 0x060005A7 RID: 1447 RVA: 0x00090035 File Offset: 0x0008E235
		private void itemClientpart_Click(object sender, EventArgs e)
		{
			this.ShowForm(sender, typeof(frmClient));
		}

		// Token: 0x060005A8 RID: 1448 RVA: 0x0009004A File Offset: 0x0008E24A
		private void itemSettlepart_Click(object sender, EventArgs e)
		{
			this.ShowForm(sender, typeof(frmSettlepart));
		}

		// Token: 0x060005A9 RID: 1449 RVA: 0x0009005F File Offset: 0x0008E25F
		private void itemPermission_Click(object sender, EventArgs e)
		{
			this.ShowForm(sender, typeof(frmPermission));
		}

		// Token: 0x060005AA RID: 1450 RVA: 0x00090074 File Offset: 0x0008E274
		private void itemSystemPara_Click(object sender, EventArgs e)
		{
			this.ShowForm(sender, typeof(frmSystemPara));
		}

		// Token: 0x060005AB RID: 1451 RVA: 0x00090089 File Offset: 0x0008E289
		private void itemLocalPara_Click(object sender, EventArgs e)
		{
			this.ShowForm(sender, typeof(frmKeyCode));
		}

		// Token: 0x060005AC RID: 1452 RVA: 0x0009009E File Offset: 0x0008E29E
		private void itemDynamicButton_Click(object sender, EventArgs e)
		{
			this.ShowForm(sender, typeof(frmDynamicButton));
		}

		// Token: 0x060005AD RID: 1453 RVA: 0x000900B3 File Offset: 0x0008E2B3
		private void itemUnit_Click(object sender, EventArgs e)
		{
			this.ShowForm(sender, typeof(frmUnit));
		}

		// Token: 0x060005AE RID: 1454 RVA: 0x000900C8 File Offset: 0x0008E2C8
		private void itemServer_Click(object sender, EventArgs e)
		{
			this.ShowForm(sender, typeof(frmServer));
		}

		// Token: 0x060005AF RID: 1455 RVA: 0x000900DD File Offset: 0x0008E2DD
		private void itemController_Click(object sender, EventArgs e)
		{
			this.ShowForm(sender, typeof(frmDevice));
		}

		// Token: 0x060005B0 RID: 1456 RVA: 0x000900F2 File Offset: 0x0008E2F2
		private void itemCommPoints_Click(object sender, EventArgs e)
		{
			this.ShowForm(sender, typeof(frmDevItems));
		}

		// Token: 0x060005B1 RID: 1457 RVA: 0x00090107 File Offset: 0x0008E307
		private void itemLoadometer_Click(object sender, EventArgs e)
		{
			this.ShowForm(sender, typeof(frmWeighbridge));
		}

		// Token: 0x060005B2 RID: 1458 RVA: 0x0009011C File Offset: 0x0008E31C
		private void itemContract_Click(object sender, EventArgs e)
		{
			this.ShowForm(sender, typeof(frmContract));
		}

		// Token: 0x060005B3 RID: 1459 RVA: 0x00090131 File Offset: 0x0008E331
		private void itemUnitMonitor_Click(object sender, EventArgs e)
		{
			this.ShowForm(sender, typeof(frmMultiMonitor));
		}

		// Token: 0x060005B4 RID: 1460 RVA: 0x00090146 File Offset: 0x0008E346
		private void itemLoadingTouch_Click(object sender, EventArgs e)
		{
			this.ShowForm(sender, typeof(frmTicket));
		}

		// Token: 0x060005B5 RID: 1461 RVA: 0x0009015B File Offset: 0x0008E35B
		private void itemRdRecord_Click(object sender, EventArgs e)
		{
			this.ShowForm(sender, typeof(frmRdRecord));
		}

		// Token: 0x060005B6 RID: 1462 RVA: 0x00090170 File Offset: 0x0008E370
		private void itemLabBatch_Click(object sender, EventArgs e)
		{
			this.ShowForm(sender, typeof(frmTicketBatchLab));
		}

		// Token: 0x060005B7 RID: 1463 RVA: 0x00090185 File Offset: 0x0008E385
		private void itemCurrStock_Click(object sender, EventArgs e)
		{
			this.ShowForm(sender, typeof(frmCurrStock));
		}

		// Token: 0x060005B8 RID: 1464 RVA: 0x0009019A File Offset: 0x0008E39A
		private void itemSrmStep_Click(object sender, EventArgs e)
		{
			this.ShowForm(sender, typeof(frmStep));
		}

		// Token: 0x060005B9 RID: 1465 RVA: 0x000901AF File Offset: 0x0008E3AF
		private void itemSrmUnitStep_Click(object sender, EventArgs e)
		{
			this.ShowForm(sender, typeof(frmStepUnit));
		}

		// Token: 0x060005BA RID: 1466 RVA: 0x000901C4 File Offset: 0x0008E3C4
		private void itemSrmInvStep_Click(object sender, EventArgs e)
		{
			this.ShowForm(sender, typeof(frmInvStep));
		}

		// Token: 0x060005BB RID: 1467 RVA: 0x000901D9 File Offset: 0x0008E3D9
		private void itemSrmEquipClass_Click(object sender, EventArgs e)
		{
			this.ShowForm(sender, typeof(frmEquipClass));
		}

		// Token: 0x060005BC RID: 1468 RVA: 0x000901EE File Offset: 0x0008E3EE
		private void itemSrmEquip_Click(object sender, EventArgs e)
		{
			this.ShowForm(sender, typeof(frmSrmEquips));
		}

		// Token: 0x060005BD RID: 1469 RVA: 0x00090203 File Offset: 0x0008E403
		private void itemSrmFactory_Click(object sender, EventArgs e)
		{
			this.ShowForm(sender, typeof(frmSrmFactory));
		}

		// Token: 0x060005BE RID: 1470 RVA: 0x00090218 File Offset: 0x0008E418
		private void itemFormDesign_Click(object sender, EventArgs e)
		{
			bool flag = new frmDesign
			{
				Icon = base.Icon,
				Connectstring = ConfigSettings.Instance.ConfigConn,
				Language = ConfigSettings.Instance.Language
			}.ShowDialog() == DialogResult.OK;
			if (flag)
			{
			}
		}

		// Token: 0x060005BF RID: 1471 RVA: 0x0009026A File Offset: 0x0008E46A
		private void itemHistoricalData_Click(object sender, EventArgs e)
		{
			this.ShowForm(sender, typeof(frmReport));
		}

		// Token: 0x060005C0 RID: 1472 RVA: 0x0009027F File Offset: 0x0008E47F
		private void itemStatisticsReport_Click(object sender, EventArgs e)
		{
			this.ShowForm(sender, typeof(frmStatisticsReport));
		}

		// Token: 0x060005C1 RID: 1473 RVA: 0x00090294 File Offset: 0x0008E494
		private void itemLabRecord_Click(object sender, EventArgs e)
		{
			this.ShowForm(this.itemLabRecord, typeof(frmLab));
		}

		// Token: 0x060005C2 RID: 1474 RVA: 0x000902AE File Offset: 0x0008E4AE
		private void itemUnionLab_Click(object sender, EventArgs e)
		{
			this.ShowForm(sender, typeof(frmUnionlabTicket));
		}

		// Token: 0x060005C3 RID: 1475 RVA: 0x000902C3 File Offset: 0x0008E4C3
		private void itemLog_Click(object sender, EventArgs e)
		{
			this.ShowForm(sender, typeof(frmLogQuery));
		}

		// Token: 0x060005C4 RID: 1476 RVA: 0x000902D8 File Offset: 0x0008E4D8
		private void itemAlarm_Click(object sender, EventArgs e)
		{
			this.ShowForm(sender, typeof(frmAlarmQuery));
		}

		// Token: 0x060005C5 RID: 1477 RVA: 0x000902F0 File Offset: 0x0008E4F0
		private void itemManual_Click(object sender, EventArgs e)
		{
			string text = Application.StartupPath + "\\Help.pdf";
			bool flag = File.Exists(text);
			if (flag)
			{
				Process.Start(text);
			}
			else
			{
				base.ShowMsg(Messages.UsedFalse, "", "");
			}
		}

		// Token: 0x060005C6 RID: 1478 RVA: 0x0009033B File Offset: 0x0008E53B
		private void itemPasswordModify_Click(object sender, EventArgs e)
		{
			this.OpenForm(typeof(frmPassword), ((ButtonItem)sender).Text, BaseForm.FormActtion.Modify);
		}

		// Token: 0x060005C7 RID: 1479 RVA: 0x0009035B File Offset: 0x0008E55B
		private void itemAbout_Click(object sender, EventArgs e)
		{
			this.OpenForm(typeof(frmAbout), ((ButtonItem)sender).Text, BaseForm.FormActtion.Modify);
		}

		// Token: 0x060005C8 RID: 1480 RVA: 0x0009037B File Offset: 0x0008E57B
		private void sitemProduct_Click(object sender, EventArgs e)
		{
			this.ShowForm(this.itemProduct, typeof(frmProduct));
		}

		// Token: 0x060005C9 RID: 1481 RVA: 0x00090395 File Offset: 0x0008E595
		private void sitemTank_Click(object sender, EventArgs e)
		{
			this.ShowForm(this.itemTank, typeof(frmTank));
		}

		// Token: 0x060005CA RID: 1482 RVA: 0x000903AF File Offset: 0x0008E5AF
		private void sitemTruck_Click(object sender, EventArgs e)
		{
			this.ShowForm(this.itemTruck, typeof(frmTruck));
		}

		// Token: 0x060005CB RID: 1483 RVA: 0x000903C9 File Offset: 0x0008E5C9
		private void sitemICCard_Click(object sender, EventArgs e)
		{
			this.ShowForm(this.itemICCard, typeof(frmICCard));
		}

		// Token: 0x060005CC RID: 1484 RVA: 0x000903E3 File Offset: 0x0008E5E3
		private void sitemClientpart_Click(object sender, EventArgs e)
		{
			this.ShowForm(this.itemClientpart, typeof(frmClient));
		}

		// Token: 0x060005CD RID: 1485 RVA: 0x000903FD File Offset: 0x0008E5FD
		private void sitemSettlepart_Click(object sender, EventArgs e)
		{
			this.ShowForm(this.itemSettlepart, typeof(frmSettlepart));
		}

		// Token: 0x060005CE RID: 1486 RVA: 0x00090417 File Offset: 0x0008E617
		private void sitemPermission_Click(object sender, EventArgs e)
		{
			this.ShowForm(this.itemPermission, typeof(frmPermission));
		}

		// Token: 0x060005CF RID: 1487 RVA: 0x00090431 File Offset: 0x0008E631
		private void sitemSystemPara_Click(object sender, EventArgs e)
		{
			this.ShowForm(this.itemSystemPara, typeof(frmSystemPara));
		}

		// Token: 0x060005D0 RID: 1488 RVA: 0x0009044B File Offset: 0x0008E64B
		private void sitemLocalPara_Click(object sender, EventArgs e)
		{
			this.ShowForm(this.itemLocalPara, typeof(frmKeyCode));
		}

		// Token: 0x060005D1 RID: 1489 RVA: 0x00090465 File Offset: 0x0008E665
		private void sitemUnit_Click(object sender, EventArgs e)
		{
			this.ShowForm(this.itemUnit, typeof(frmUnit));
		}

		// Token: 0x060005D2 RID: 1490 RVA: 0x0009047F File Offset: 0x0008E67F
		private void sitemServer_Click(object sender, EventArgs e)
		{
			this.ShowForm(this.itemServer, typeof(frmServer));
		}

		// Token: 0x060005D3 RID: 1491 RVA: 0x00090499 File Offset: 0x0008E699
		private void sitemController_Click(object sender, EventArgs e)
		{
			this.ShowForm(this.itemController, typeof(frmDevice));
		}

		// Token: 0x060005D4 RID: 1492 RVA: 0x000904B3 File Offset: 0x0008E6B3
		private void sitemCommPoints_Click(object sender, EventArgs e)
		{
			this.ShowForm(this.itemCommPoints, typeof(frmDevItems));
		}

		// Token: 0x060005D5 RID: 1493 RVA: 0x000904CD File Offset: 0x0008E6CD
		private void sitemLoadometer_Click(object sender, EventArgs e)
		{
			this.ShowForm(this.itemLoadometer, typeof(frmWeighbridge));
		}

		// Token: 0x060005D6 RID: 1494 RVA: 0x000904E7 File Offset: 0x0008E6E7
		private void sitemContract_Click(object sender, EventArgs e)
		{
			this.ShowForm(this.itemContract, typeof(frmContract));
		}

		// Token: 0x060005D7 RID: 1495 RVA: 0x00090501 File Offset: 0x0008E701
		private void sitemUnitMonitor_Click(object sender, EventArgs e)
		{
			this.ShowForm(this.itemUnitMonitor, typeof(frmMultiMonitor));
		}

		// Token: 0x060005D8 RID: 1496 RVA: 0x0009051B File Offset: 0x0008E71B
		private void sitemLoadingTouch_Click(object sender, EventArgs e)
		{
			this.ShowForm(this.itemLoadingTouch, typeof(frmTicket));
		}

		// Token: 0x060005D9 RID: 1497 RVA: 0x00090294 File Offset: 0x0008E494
		private void sitemLabRecord_Click(object sender, EventArgs e)
		{
			this.ShowForm(this.itemLabRecord, typeof(frmLab));
		}

		// Token: 0x060005DA RID: 1498 RVA: 0x00003040 File Offset: 0x00001240
		private void sitemUnionLab_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060005DB RID: 1499 RVA: 0x00003040 File Offset: 0x00001240
		private void sitemRdRecord_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060005DC RID: 1500 RVA: 0x00003040 File Offset: 0x00001240
		private void itemRdRecordTicket_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060005DD RID: 1501 RVA: 0x00003040 File Offset: 0x00001240
		private void btnLabBatch_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060005DE RID: 1502 RVA: 0x00090538 File Offset: 0x0008E738
		private void sitemFormDesign_Click(object sender, EventArgs e)
		{
			bool flag = new frmDesign
			{
				Icon = base.Icon,
				Connectstring = ConfigSettings.Instance.ConfigConn,
				Language = ConfigSettings.Instance.Language
			}.ShowDialog() == DialogResult.OK;
			if (flag)
			{
			}
		}

		// Token: 0x060005DF RID: 1503 RVA: 0x0009058A File Offset: 0x0008E78A
		private void sitemHistoricalData_Click(object sender, EventArgs e)
		{
			this.ShowForm(this.itemHistoricalData, typeof(frmReport));
		}

		// Token: 0x060005E0 RID: 1504 RVA: 0x000905A4 File Offset: 0x0008E7A4
		private void sitemStatisticsReport_Click(object sender, EventArgs e)
		{
			this.ShowForm(this.itemStatisticsReport, typeof(frmStatisticsReport));
		}

		// Token: 0x060005E1 RID: 1505 RVA: 0x000905BE File Offset: 0x0008E7BE
		private void sitemLog_Click(object sender, EventArgs e)
		{
			this.ShowForm(this.itemLog, typeof(frmLogQuery));
		}

		// Token: 0x060005E2 RID: 1506 RVA: 0x000905D8 File Offset: 0x0008E7D8
		private void sitemAlarm_Click(object sender, EventArgs e)
		{
			this.ShowForm(this.itemHistoricalAlarm, typeof(frmAlarmQuery));
		}

		// Token: 0x060005E3 RID: 1507 RVA: 0x000905F4 File Offset: 0x0008E7F4
		private void ShowForm(object sender, Type type)
		{
			BaseDialogForm baseDialogForm = base.CreateInstance<BaseDialogForm>(type);
			bool flag = baseDialogForm != null;
			if (flag)
			{
				base.Enabled = false;
				bool flag2 = this._selectForm != null;
				if (flag2)
				{
					this._selectForm.Close();
				}
				this.panelMain.Controls.Clear();
				baseDialogForm.FormBorderStyle = FormBorderStyle.None;
				baseDialogForm.TopLevel = false;
				baseDialogForm.WindowState = FormWindowState.Maximized;
				baseDialogForm.Sender = sender;
				this._selectForm = baseDialogForm;
				this.panelMain.Controls.Add(baseDialogForm);
				baseDialogForm.Show();
				this.Text = ShowWords.ReplaceText("Inscan SQS Client") + " - " + ((ButtonItem)sender).Text;
				base.Enabled = true;
			}
		}

		// Token: 0x060005E4 RID: 1508 RVA: 0x000906BC File Offset: 0x0008E8BC
		private void sitemLogout_Click(object sender, EventArgs e)
		{
			bool flag = base.ShowChoise(Messages.LogoutSure, "", "");
			if (flag)
			{
				base.DialogResult = DialogResult.Yes;
				base.Close();
				BaseDialogForm._operateArgs.Category = ShowWords.ReplaceText("LoginUser");
				BaseDialogForm._operateArgs.OperateType = ShowWords.ReplaceText("Logout");
				this.OnOperateSuccess(new ModSys_user
				{
					Id = GlobalKey.UserId,
					UserName = GlobalKey.UserName,
					Role = GlobalKey.Role,
					GroupId = GlobalKey.GroupId
				}, true);
				BaseDialogForm.OperateEventHandler -= this.BaseDialogForm_OperateEventHandler;
			}
		}

		// Token: 0x060005E5 RID: 1509 RVA: 0x00090775 File Offset: 0x0008E975
		private void menuDBConn_Click(object sender, EventArgs e)
		{
			this.OpenForm(typeof(frmDBConfig), ((ButtonItem)sender).Text, BaseForm.FormActtion.Modify);
		}

		// Token: 0x060005E6 RID: 1510 RVA: 0x00090795 File Offset: 0x0008E995
		private void menuDictionary_Click(object sender, EventArgs e)
		{
			this.OpenForm(typeof(frmDictionaryEdit), ((ButtonItem)sender).Text, BaseForm.FormActtion.Modify);
		}

		// Token: 0x060005E7 RID: 1511 RVA: 0x000907B8 File Offset: 0x0008E9B8
		private void itemChinese_Click(object sender, EventArgs e)
		{
			bool flag = !this.itemChinese.Checked;
			if (flag)
			{
				bool flag2 = base.ShowChoise(Messages.Restart, "", "");
				if (flag2)
				{
					this.itemEnglish.Checked = false;
					this.itemChinese.Checked = true;
					ConfigSettings.Instance.Language = "ZH";
					ConfigSettings.Instance.Save();
				}
			}
		}

		// Token: 0x060005E8 RID: 1512 RVA: 0x0009082C File Offset: 0x0008EA2C
		private void itemEnglish_Click(object sender, EventArgs e)
		{
			bool flag = !this.itemEnglish.Checked;
			if (flag)
			{
				bool flag2 = base.ShowChoise(Messages.Restart, "", "");
				if (flag2)
				{
					this.itemChinese.Checked = false;
					this.itemEnglish.Checked = true;
					ConfigSettings.Instance.Language = "EN";
					ConfigSettings.Instance.Save();
				}
			}
		}

		// Token: 0x060005E9 RID: 1513 RVA: 0x0009089E File Offset: 0x0008EA9E
		private void btnPricePolicy_Click(object sender, EventArgs e)
		{
			this.ShowForm(sender, typeof(frmPricePolicy));
		}

		// Token: 0x060005EA RID: 1514 RVA: 0x000908B3 File Offset: 0x0008EAB3
		private void itemPdaSetting_Click(object sender, EventArgs e)
		{
			this.ShowForm(sender, typeof(frmPdaSetting));
		}

		// Token: 0x040009DD RID: 2525
		private BaseDialogForm _selectForm;
	}
}
