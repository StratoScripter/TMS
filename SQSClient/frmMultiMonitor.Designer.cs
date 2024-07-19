namespace SQSClient
{
	// Token: 0x02000075 RID: 117
	public partial class frmMultiMonitor : global::SQSClient.BaseDialogForm
	{
		// Token: 0x06000665 RID: 1637 RVA: 0x0009E0EC File Offset: 0x0009C2EC
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000666 RID: 1638 RVA: 0x0009E124 File Offset: 0x0009C324
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::SQSClient.frmMultiMonitor));
			this.controlContainerItem1 = new global::DevComponents.DotNetBar.ControlContainerItem();
			this.bar = new global::DevComponents.DotNetBar.Bar();
			this.tsbtnUnitSplit = new global::DevComponents.DotNetBar.ButtonItem();
			this.btnConfigTool = new global::DevComponents.DotNetBar.ButtonItem();
			this.tabControl = new global::DevComponents.DotNetBar.TabControl();
			((global::System.ComponentModel.ISupportInitialize)this.bar).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.tabControl).BeginInit();
			base.SuspendLayout();
			this.controlContainerItem1.AllowItemResize = false;
			this.controlContainerItem1.MenuVisibility = global::DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
			this.controlContainerItem1.Name = "controlContainerItem1";
			this.bar.AntiAlias = true;
			this.bar.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.bar.Font = new global::System.Drawing.Font("微软雅黑", 9f);
			this.bar.IsMaximized = false;
			this.bar.Items.AddRange(new global::DevComponents.DotNetBar.BaseItem[]
			{
				this.tsbtnUnitSplit,
				this.btnConfigTool
			});
			this.bar.Location = new global::System.Drawing.Point(0, 0);
			this.bar.Name = "bar";
			this.bar.Size = new global::System.Drawing.Size(926, 27);
			this.bar.Stretch = true;
			this.bar.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.bar.TabIndex = 1;
			this.bar.TabStop = false;
			this.bar.Text = "bar1";
			this.tsbtnUnitSplit.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.tsbtnUnitSplit.Name = "tsbtnUnitSplit";
			this.tsbtnUnitSplit.Text = "UnitSplit";
			this.tsbtnUnitSplit.Visible = false;
			this.tsbtnUnitSplit.Click += new global::System.EventHandler(this.tsbtnUnitSplit_Click);
			this.btnConfigTool.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.btnConfigTool.Image = global::SQSClient.Properties.Resources.parasetting16;
			this.btnConfigTool.Name = "btnConfigTool";
			this.btnConfigTool.Text = "ConfigTool";
			this.btnConfigTool.Click += new global::System.EventHandler(this.btnConfigTool_Click);
			this.tabControl.BackColor = global::System.Drawing.Color.FromArgb(252, 252, 252);
			this.tabControl.CanReorderTabs = true;
			this.tabControl.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.tabControl.Location = new global::System.Drawing.Point(0, 27);
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedTabFont = new global::System.Drawing.Font("宋体", 9f, global::System.Drawing.FontStyle.Bold);
			this.tabControl.SelectedTabIndex = 0;
			this.tabControl.Size = new global::System.Drawing.Size(926, 460);
			this.tabControl.Style = global::DevComponents.DotNetBar.eTabStripStyle.Office2007Document;
			this.tabControl.TabAlignment = global::DevComponents.DotNetBar.eTabStripAlignment.Left;
			this.tabControl.TabIndex = 4;
			this.tabControl.TabLayoutType = global::DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox;
			this.tabControl.Text = "tabControl1";
			this.tabControl.SelectedTabChanged += new global::DevComponents.DotNetBar.TabStrip.SelectedTabChangedEventHandler(this.tabControl_SelectedTabChanged);
			base.ClientSize = new global::System.Drawing.Size(926, 487);
			base.Controls.Add(this.tabControl);
			base.Controls.Add(this.bar);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "frmMultiMonitor";
			this.Text = "UnitMonitor";
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.frmMultiMonitor_FormClosing);
			base.Load += new global::System.EventHandler(this.frmMultiMonitor_Load);
			((global::System.ComponentModel.ISupportInitialize)this.bar).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.tabControl).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000ADE RID: 2782
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000ADF RID: 2783
		private global::DevComponents.DotNetBar.Bar bar;

		// Token: 0x04000AE0 RID: 2784
		private global::DevComponents.DotNetBar.ButtonItem tsbtnUnitSplit;

		// Token: 0x04000AE1 RID: 2785
		private global::DevComponents.DotNetBar.ControlContainerItem controlContainerItem1;

		// Token: 0x04000AE2 RID: 2786
		private global::DevComponents.DotNetBar.ButtonItem btnConfigTool;

		// Token: 0x04000AE3 RID: 2787
		private global::DevComponents.DotNetBar.TabControl tabControl;
	}
}
