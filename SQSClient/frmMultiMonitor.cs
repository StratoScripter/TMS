using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Assistant;
using ConfigTool;
using DAL.Base.SQSConfig;
using DevComponents.DotNetBar;
using Model;
using Model.SQSConfig;
using SQSClient.Properties;

namespace SQSClient
{
	// Token: 0x02000075 RID: 117
	public partial class frmMultiMonitor : BaseDialogForm
	{
		// Token: 0x0600065A RID: 1626 RVA: 0x0009DB40 File Offset: 0x0009BD40
		public frmMultiMonitor()
		{
			this.InitializeComponent();
			this.SetText(this);
			this._Controls.Clear();
			this._Controls.Add(this.bar);
		}

		// Token: 0x0600065B RID: 1627 RVA: 0x0009DB9F File Offset: 0x0009BD9F
		private void frmMultiMonitor_Load(object sender, EventArgs e)
		{
			base.InitBurron();
			this.InitControl();
			this.LoadUnitData();
		}

		// Token: 0x0600065C RID: 1628 RVA: 0x0009DBB8 File Offset: 0x0009BDB8
		private void InitControl()
		{
			this._Timer = new Timer();
			this._Timer.Interval = 2000;
			this._Timer.Tick += this._Timer_Tick;
			this._listgroup.Clear();
			this._listunit.Clear();
			this._listgroup = DalCfg_unitgroup.Instance.GetAllList();
			this._listunit = DalCfg_unit.Instance.GetList("State", true);
		}

		// Token: 0x0600065D RID: 1629 RVA: 0x0009DC40 File Offset: 0x0009BE40
		private void LoadUnitData()
		{
			List<ModCfg_unitgroup> list = (from o in this._listgroup
			where o.ParentId == 0
			select o).ToList<ModCfg_unitgroup>();
			foreach (ModCfg_unitgroup modCfg_unitgroup in list)
			{
				List<string> names = this.GetNames(modCfg_unitgroup);
				TabControlPanel tabControlPanel = new TabControlPanel();
				TabItem tabItem = new TabItem();
				tabControlPanel.Name = "tabControlPanel";
				tabControlPanel.Dock = DockStyle.Fill;
				tabControlPanel.TabItem = tabItem;
				tabItem.Name = "tabItem";
				tabItem.Text = modCfg_unitgroup.Name;
				tabItem.AttachedControl = tabControlPanel;
				FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel();
				flowLayoutPanel.Dock = DockStyle.Fill;
				flowLayoutPanel.AutoScroll = true;
				List<ModCfg_unit> list2 = (from o in this._listunit
				where names.Contains(o.GroupName)
				select o).ToList<ModCfg_unit>();
				foreach (ModCfg_unit value in list2)
				{
					UnitLabel unitLabel = new UnitLabel();
					unitLabel.unitProfile.SetValue(value);
					flowLayoutPanel.Controls.Add(unitLabel);
					Application.DoEvents();
				}
				tabControlPanel.Controls.Add(flowLayoutPanel);
				this.tabControl.Controls.Add(tabControlPanel);
				this.tabControl.Tabs.Add(tabItem);
			}
			this.Refresh();
			this._Timer_Tick(null, null);
			this._Timer.Start();
		}

		// Token: 0x0600065E RID: 1630 RVA: 0x0009DE30 File Offset: 0x0009C030
		private List<string> GetNames(ModCfg_unitgroup modgroup)
		{
			List<string> list = new List<string>();
			list.Add(modgroup.Name);
			List<ModCfg_unitgroup> list2 = (from o in this._listgroup
			where o.ParentId == modgroup.Id
			select o).ToList<ModCfg_unitgroup>();
			foreach (ModCfg_unitgroup modCfg_unitgroup in list2)
			{
				list.Add(modCfg_unitgroup.Name);
				list.AddRange(this.GetNames(modCfg_unitgroup));
			}
			return list;
		}

		// Token: 0x0600065F RID: 1631 RVA: 0x0009DEE4 File Offset: 0x0009C0E4
		private void _Timer_Tick(object sender, EventArgs e)
		{
			bool flag = this.tabControl.SelectedPanel == null;
			if (!flag)
			{
				foreach (object obj in this.tabControl.SelectedPanel.Controls[0].Controls)
				{
					Control control = (Control)obj;
					bool flag2 = control is UnitLabel;
					if (flag2)
					{
						((UnitLabel)control).unitProfile.SetRealData();
					}
					Application.DoEvents();
				}
			}
		}

		// Token: 0x06000660 RID: 1632 RVA: 0x0009DF90 File Offset: 0x0009C190
		private void tsbtnUnitSplit_Click(object sender, EventArgs e)
		{
			BaseDialogForm baseDialogForm = base.CreateInstance<BaseDialogForm>(typeof(frmUnitCheck));
			bool flag = baseDialogForm.ShowDialog() == DialogResult.Yes;
			if (flag)
			{
				this.LoadUnitData();
			}
		}

		// Token: 0x06000661 RID: 1633 RVA: 0x0009DFC8 File Offset: 0x0009C1C8
		private void frmMultiMonitor_FormClosing(object sender, FormClosingEventArgs e)
		{
			bool flag = this._Timer != null;
			if (flag)
			{
				this._Timer.Stop();
				this._Timer.Dispose();
			}
			base.Dispose();
		}

		// Token: 0x06000662 RID: 1634 RVA: 0x0009E004 File Offset: 0x0009C204
		private void btnConfigTool_Click(object sender, EventArgs e)
		{
			bool flag = !this.IsExistControler();
			if (!flag)
			{
				SetLanguage setLanguage = new SetLanguage();
				setLanguage.Language = ConfigSettings.Instance.Language;
				bool flag2 = new frmParaSettings(this._FrmName)
				{
					Icon = base.Icon,
					Text = ((ButtonItem)sender).Text
				}.ShowDialog() == DialogResult.OK;
				if (flag2)
				{
				}
			}
		}

		// Token: 0x06000663 RID: 1635 RVA: 0x0009E074 File Offset: 0x0009C274
		private bool IsExistControler()
		{
			List<ModCfg_device> allList = DalCfg_device.Instance.GetAllList();
			bool flag = allList != null;
			bool result;
			if (flag)
			{
				bool flag2 = allList.Count == 0;
				if (flag2)
				{
					base.ShowMsg(Messages.DeviceNone, "", "");
					result = false;
				}
				else
				{
					result = true;
				}
			}
			else
			{
				base.ShowMsg(Messages.DeviceNone, "", "");
				result = false;
			}
			return result;
		}

		// Token: 0x06000664 RID: 1636 RVA: 0x0009E0DF File Offset: 0x0009C2DF
		private void tabControl_SelectedTabChanged(object sender, TabStripTabChangedEventArgs e)
		{
			this._Timer_Tick(null, null);
		}

		// Token: 0x04000ADB RID: 2779
		private Timer _Timer;

		// Token: 0x04000ADC RID: 2780
		private List<ModCfg_unitgroup> _listgroup = new List<ModCfg_unitgroup>();

		// Token: 0x04000ADD RID: 2781
		private List<ModCfg_unit> _listunit = new List<ModCfg_unit>();
	}
}
