namespace SQSClient
{
	// Token: 0x0200006F RID: 111
	public partial class frmMain : global::SQSClient.BaseDialogForm
	{
		// Token: 0x060005EB RID: 1515 RVA: 0x000908C8 File Offset: 0x0008EAC8
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060005EC RID: 1516 RVA: 0x00090900 File Offset: 0x0008EB00
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::SQSClient.frmMain));
			this.panelMain = new global::DevComponents.DotNetBar.PanelEx();
			this.panelEx1 = new global::DevComponents.DotNetBar.PanelEx();
			this.labelX1 = new global::DevComponents.DotNetBar.LabelX();
			this.labLoginUser = new global::DevComponents.DotNetBar.LabelX();
			this.panelMenuMain = new global::DevComponents.DotNetBar.PanelEx();
			this.ribbonBar6 = new global::DevComponents.DotNetBar.RibbonBar();
			this.rmenuQuery = new global::DevComponents.DotNetBar.RibbonBar();
			this.sitemHistoricalData = new global::DevComponents.DotNetBar.ButtonItem();
			this.sitemStatisticsReport = new global::DevComponents.DotNetBar.ButtonItem();
			this.sitemLog = new global::DevComponents.DotNetBar.ButtonItem();
			this.sitemHistoricalAlarm = new global::DevComponents.DotNetBar.ButtonItem();
			this.rmenuBusiness = new global::DevComponents.DotNetBar.RibbonBar();
			this.sitemUnitMonitor = new global::DevComponents.DotNetBar.ButtonItem();
			this.sitemContract = new global::DevComponents.DotNetBar.ButtonItem();
			this.sitemLoadingTouch = new global::DevComponents.DotNetBar.ButtonItem();
			this.sitemLabRecord = new global::DevComponents.DotNetBar.ButtonItem();
			this.sitemFormDesign = new global::DevComponents.DotNetBar.ButtonItem();
			this.rmenuBaseInfo = new global::DevComponents.DotNetBar.RibbonBar();
			this.sitemTruck = new global::DevComponents.DotNetBar.ButtonItem();
			this.sitemICCard = new global::DevComponents.DotNetBar.ButtonItem();
			this.sitemClientpart = new global::DevComponents.DotNetBar.ButtonItem();
			this.sitemSettlepart = new global::DevComponents.DotNetBar.ButtonItem();
			this.rmenuSystemSetup = new global::DevComponents.DotNetBar.RibbonBar();
			this.sitemPermission = new global::DevComponents.DotNetBar.ButtonItem();
			this.sitemSystemPara = new global::DevComponents.DotNetBar.ButtonItem();
			this.sitemLocalPara = new global::DevComponents.DotNetBar.ButtonItem();
			this.buttonItem20 = new global::DevComponents.DotNetBar.ButtonItem();
			this.rmenuCommConfig = new global::DevComponents.DotNetBar.RibbonBar();
			this.sitemProduct = new global::DevComponents.DotNetBar.ButtonItem();
			this.sitemServer = new global::DevComponents.DotNetBar.ButtonItem();
			this.sitemController = new global::DevComponents.DotNetBar.ButtonItem();
			this.sitemUnit = new global::DevComponents.DotNetBar.ButtonItem();
			this.sitemTank = new global::DevComponents.DotNetBar.ButtonItem();
			this.sitemLoadometer = new global::DevComponents.DotNetBar.ButtonItem();
			this.sitemCommPoints = new global::DevComponents.DotNetBar.ButtonItem();
			this.rmenuLogout = new global::DevComponents.DotNetBar.RibbonBar();
			this.sitemLogout = new global::DevComponents.DotNetBar.ButtonItem();
			this.menuMain = new global::DevComponents.DotNetBar.Bar();
			this.menuCommConfig = new global::DevComponents.DotNetBar.ButtonItem();
			this.itemProduct = new global::DevComponents.DotNetBar.ButtonItem();
			this.itemServer = new global::DevComponents.DotNetBar.ButtonItem();
			this.itemController = new global::DevComponents.DotNetBar.ButtonItem();
			this.itemUnit = new global::DevComponents.DotNetBar.ButtonItem();
			this.itemTank = new global::DevComponents.DotNetBar.ButtonItem();
			this.itemLoadometer = new global::DevComponents.DotNetBar.ButtonItem();
			this.itemCommPoints = new global::DevComponents.DotNetBar.ButtonItem();
			this.menuProcessControl = new global::DevComponents.DotNetBar.ButtonItem();
			this.itemSrmStep = new global::DevComponents.DotNetBar.ButtonItem();
			this.itemSrmInvStep = new global::DevComponents.DotNetBar.ButtonItem();
			this.menuSystemSetup = new global::DevComponents.DotNetBar.ButtonItem();
			this.itemPermission = new global::DevComponents.DotNetBar.ButtonItem();
			this.itemSystemPara = new global::DevComponents.DotNetBar.ButtonItem();
			this.itemLocalPara = new global::DevComponents.DotNetBar.ButtonItem();
			this.itemDynamicButton = new global::DevComponents.DotNetBar.ButtonItem();
			this.menuBaseInfo = new global::DevComponents.DotNetBar.ButtonItem();
			this.itemTruck = new global::DevComponents.DotNetBar.ButtonItem();
			this.itemICCard = new global::DevComponents.DotNetBar.ButtonItem();
			this.itemClientpart = new global::DevComponents.DotNetBar.ButtonItem();
			this.itemSettlepart = new global::DevComponents.DotNetBar.ButtonItem();
			this.menuBusiness = new global::DevComponents.DotNetBar.ButtonItem();
			this.itemUnitMonitor = new global::DevComponents.DotNetBar.ButtonItem();
			this.itemContract = new global::DevComponents.DotNetBar.ButtonItem();
			this.itemLoadingTouch = new global::DevComponents.DotNetBar.ButtonItem();
			this.itemLabRecord = new global::DevComponents.DotNetBar.ButtonItem();
			this.itemFormDesign = new global::DevComponents.DotNetBar.ButtonItem();
			this.menuQuery = new global::DevComponents.DotNetBar.ButtonItem();
			this.itemHistoricalData = new global::DevComponents.DotNetBar.ButtonItem();
			this.itemStatisticsReport = new global::DevComponents.DotNetBar.ButtonItem();
			this.itemLog = new global::DevComponents.DotNetBar.ButtonItem();
			this.itemHistoricalAlarm = new global::DevComponents.DotNetBar.ButtonItem();
			this.menuHelp = new global::DevComponents.DotNetBar.ButtonItem();
			this.itemManual = new global::DevComponents.DotNetBar.ButtonItem();
			this.itemPasswordModify = new global::DevComponents.DotNetBar.ButtonItem();
			this.itemAbout = new global::DevComponents.DotNetBar.ButtonItem();
			this.menuLanguage = new global::DevComponents.DotNetBar.ButtonItem();
			this.itemChinese = new global::DevComponents.DotNetBar.ButtonItem();
			this.itemEnglish = new global::DevComponents.DotNetBar.ButtonItem();
			this.menuDBConn = new global::DevComponents.DotNetBar.ButtonItem();
			this.menuDictionary = new global::DevComponents.DotNetBar.ButtonItem();
			this.panelEx1.SuspendLayout();
			this.panelMenuMain.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.menuMain).BeginInit();
			base.SuspendLayout();
			this.panelMain.CanvasColor = global::System.Drawing.SystemColors.Control;
			this.panelMain.ColorSchemeStyle = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.panelMain.DisabledBackColor = global::System.Drawing.Color.Empty;
			this.panelMain.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.panelMain.Location = new global::System.Drawing.Point(0, 126);
			this.panelMain.Name = "panelMain";
			this.panelMain.Size = new global::System.Drawing.Size(1268, 420);
			this.panelMain.Style.Alignment = global::System.Drawing.StringAlignment.Center;
			this.panelMain.Style.BackColor1.ColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
			this.panelMain.Style.BackColor2.ColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
			this.panelMain.Style.Border = global::DevComponents.DotNetBar.eBorderType.SingleLine;
			this.panelMain.Style.BorderColor.ColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
			this.panelMain.Style.ForeColor.ColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelText;
			this.panelMain.Style.GradientAngle = 90;
			this.panelMain.TabIndex = 75;
			this.panelMain.Text = "panelEx2";
			this.panelEx1.CanvasColor = global::System.Drawing.SystemColors.Control;
			this.panelEx1.ColorSchemeStyle = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.panelEx1.Controls.Add(this.labelX1);
			this.panelEx1.Controls.Add(this.labLoginUser);
			this.panelEx1.DisabledBackColor = global::System.Drawing.Color.Empty;
			this.panelEx1.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.panelEx1.Location = new global::System.Drawing.Point(0, 546);
			this.panelEx1.Name = "panelEx1";
			this.panelEx1.Size = new global::System.Drawing.Size(1268, 24);
			this.panelEx1.Style.Alignment = global::System.Drawing.StringAlignment.Center;
			this.panelEx1.Style.BackColor1.Color = global::System.Drawing.Color.DarkBlue;
			this.panelEx1.Style.BackColor2.Color = global::System.Drawing.Color.DarkBlue;
			this.panelEx1.Style.Border = global::DevComponents.DotNetBar.eBorderType.SingleLine;
			this.panelEx1.Style.BorderColor.ColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
			this.panelEx1.Style.ForeColor.ColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelText;
			this.panelEx1.Style.GradientAngle = 90;
			this.panelEx1.TabIndex = 64;
			this.labelX1.AutoSize = true;
			this.labelX1.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.labelX1.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.labelX1.Font = new global::System.Drawing.Font("宋体", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 134);
			this.labelX1.ForeColor = global::System.Drawing.Color.White;
			this.labelX1.Location = new global::System.Drawing.Point(983, 0);
			this.labelX1.Name = "labelX1";
			this.labelX1.Size = new global::System.Drawing.Size(285, 16);
			this.labelX1.TabIndex = 3;
			this.labelX1.Text = "ZHEJIANG SUPCON AUTOMATIC INSTRIMENT Co., LTD";
			this.labelX1.TextAlignment = global::System.Drawing.StringAlignment.Far;
			this.labelX1.TextLineAlignment = global::System.Drawing.StringAlignment.Far;
			this.labLoginUser.AutoSize = true;
			this.labLoginUser.BackColor = global::System.Drawing.Color.Transparent;
			this.labLoginUser.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.labLoginUser.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.labLoginUser.ForeColor = global::System.Drawing.Color.White;
			this.labLoginUser.Location = new global::System.Drawing.Point(0, 0);
			this.labLoginUser.Name = "labLoginUser";
			this.labLoginUser.Size = new global::System.Drawing.Size(87, 16);
			this.labLoginUser.TabIndex = 2;
			this.labLoginUser.Text = "SystemMessage";
			this.labLoginUser.TextLineAlignment = global::System.Drawing.StringAlignment.Far;
			this.panelMenuMain.CanvasColor = global::System.Drawing.SystemColors.Control;
			this.panelMenuMain.ColorSchemeStyle = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.panelMenuMain.Controls.Add(this.ribbonBar6);
			this.panelMenuMain.Controls.Add(this.rmenuQuery);
			this.panelMenuMain.Controls.Add(this.rmenuBusiness);
			this.panelMenuMain.Controls.Add(this.rmenuBaseInfo);
			this.panelMenuMain.Controls.Add(this.rmenuSystemSetup);
			this.panelMenuMain.Controls.Add(this.rmenuCommConfig);
			this.panelMenuMain.Controls.Add(this.rmenuLogout);
			this.panelMenuMain.DisabledBackColor = global::System.Drawing.Color.Empty;
			this.panelMenuMain.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.panelMenuMain.Location = new global::System.Drawing.Point(0, 26);
			this.panelMenuMain.Name = "panelMenuMain";
			this.panelMenuMain.Size = new global::System.Drawing.Size(1268, 100);
			this.panelMenuMain.Style.Alignment = global::System.Drawing.StringAlignment.Center;
			this.panelMenuMain.Style.BackColor1.ColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
			this.panelMenuMain.Style.BackColor2.ColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
			this.panelMenuMain.Style.Border = global::DevComponents.DotNetBar.eBorderType.SingleLine;
			this.panelMenuMain.Style.BorderColor.ColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
			this.panelMenuMain.Style.ForeColor.ColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelText;
			this.panelMenuMain.Style.GradientAngle = 90;
			this.panelMenuMain.TabIndex = 35;
			this.panelMenuMain.Text = "panelEx1";
			this.ribbonBar6.AutoOverflowEnabled = true;
			this.ribbonBar6.BackgroundMouseOverStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.ribbonBar6.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.ribbonBar6.ContainerControlProcessDialogKey = true;
			this.ribbonBar6.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.ribbonBar6.DragDropSupport = true;
			this.ribbonBar6.Location = new global::System.Drawing.Point(838, 0);
			this.ribbonBar6.Name = "ribbonBar6";
			this.ribbonBar6.Size = new global::System.Drawing.Size(367, 100);
			this.ribbonBar6.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.Metro;
			this.ribbonBar6.TabIndex = 24;
			this.ribbonBar6.TitleStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.ribbonBar6.TitleStyleMouseOver.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.ribbonBar6.VerticalItemAlignment = global::DevComponents.DotNetBar.eVerticalItemsAlignment.Middle;
			this.rmenuQuery.AutoOverflowEnabled = true;
			this.rmenuQuery.BackgroundMouseOverStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.rmenuQuery.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.rmenuQuery.ContainerControlProcessDialogKey = true;
			this.rmenuQuery.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.rmenuQuery.DragDropSupport = true;
			this.rmenuQuery.Items.AddRange(new global::DevComponents.DotNetBar.BaseItem[]
			{
				this.sitemHistoricalData,
				this.sitemStatisticsReport,
				this.sitemLog,
				this.sitemHistoricalAlarm
			});
			this.rmenuQuery.Location = new global::System.Drawing.Point(734, 0);
			this.rmenuQuery.Name = "rmenuQuery";
			this.rmenuQuery.Size = new global::System.Drawing.Size(104, 100);
			this.rmenuQuery.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.Metro;
			this.rmenuQuery.TabIndex = 23;
			this.rmenuQuery.Text = "Query";
			this.rmenuQuery.TitleStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.rmenuQuery.TitleStyleMouseOver.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.rmenuQuery.VerticalItemAlignment = global::DevComponents.DotNetBar.eVerticalItemsAlignment.Middle;
			this.sitemHistoricalData.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.sitemHistoricalData.Image = global::SQSClient.Properties.Resources.hisdata48;
			this.sitemHistoricalData.ImagePosition = global::DevComponents.DotNetBar.eImagePosition.Top;
			this.sitemHistoricalData.Name = "sitemHistoricalData";
			this.sitemHistoricalData.SubItemsExpandWidth = 14;
			this.sitemHistoricalData.Text = "HistoricalData";
			this.sitemHistoricalData.Click += new global::System.EventHandler(this.sitemHistoricalData_Click);
			this.sitemStatisticsReport.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.sitemStatisticsReport.Image = global::SQSClient.Properties.Resources.stcreport48;
			this.sitemStatisticsReport.ImagePosition = global::DevComponents.DotNetBar.eImagePosition.Top;
			this.sitemStatisticsReport.Name = "sitemStatisticsReport";
			this.sitemStatisticsReport.SubItemsExpandWidth = 14;
			this.sitemStatisticsReport.Text = "StatisticsReport";
			this.sitemStatisticsReport.Click += new global::System.EventHandler(this.sitemStatisticsReport_Click);
			this.sitemLog.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.sitemLog.Image = global::SQSClient.Properties.Resources.operatelog48;
			this.sitemLog.ImagePosition = global::DevComponents.DotNetBar.eImagePosition.Top;
			this.sitemLog.Name = "sitemLog";
			this.sitemLog.SubItemsExpandWidth = 14;
			this.sitemLog.Text = "Log";
			this.sitemLog.Click += new global::System.EventHandler(this.sitemLog_Click);
			this.sitemHistoricalAlarm.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.sitemHistoricalAlarm.Image = global::SQSClient.Properties.Resources.alarmdata48;
			this.sitemHistoricalAlarm.ImagePosition = global::DevComponents.DotNetBar.eImagePosition.Top;
			this.sitemHistoricalAlarm.Name = "sitemHistoricalAlarm";
			this.sitemHistoricalAlarm.SubItemsExpandWidth = 14;
			this.sitemHistoricalAlarm.Text = "HistoricalAlarm";
			this.sitemHistoricalAlarm.Click += new global::System.EventHandler(this.sitemAlarm_Click);
			this.rmenuBusiness.AutoOverflowEnabled = true;
			this.rmenuBusiness.BackgroundMouseOverStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.rmenuBusiness.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.rmenuBusiness.ContainerControlProcessDialogKey = true;
			this.rmenuBusiness.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.rmenuBusiness.DragDropSupport = true;
			this.rmenuBusiness.Items.AddRange(new global::DevComponents.DotNetBar.BaseItem[]
			{
				this.sitemUnitMonitor,
				this.sitemContract,
				this.sitemLoadingTouch,
				this.sitemLabRecord,
				this.sitemFormDesign
			});
			this.rmenuBusiness.Location = new global::System.Drawing.Point(270, 0);
			this.rmenuBusiness.Name = "rmenuBusiness";
			this.rmenuBusiness.Size = new global::System.Drawing.Size(464, 100);
			this.rmenuBusiness.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.Metro;
			this.rmenuBusiness.TabIndex = 22;
			this.rmenuBusiness.Text = "Business";
			this.rmenuBusiness.TitleStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.rmenuBusiness.TitleStyleMouseOver.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.rmenuBusiness.VerticalItemAlignment = global::DevComponents.DotNetBar.eVerticalItemsAlignment.Middle;
			this.sitemUnitMonitor.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.sitemUnitMonitor.Image = global::SQSClient.Properties.Resources.unitmonitor48;
			this.sitemUnitMonitor.ImagePosition = global::DevComponents.DotNetBar.eImagePosition.Top;
			this.sitemUnitMonitor.Name = "sitemUnitMonitor";
			this.sitemUnitMonitor.SubItemsExpandWidth = 14;
			this.sitemUnitMonitor.Text = "UnitMonitor";
			this.sitemUnitMonitor.Click += new global::System.EventHandler(this.sitemUnitMonitor_Click);
			this.sitemContract.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.sitemContract.Image = global::SQSClient.Properties.Resources.contract48;
			this.sitemContract.ImagePosition = global::DevComponents.DotNetBar.eImagePosition.Top;
			this.sitemContract.Name = "sitemContract";
			this.sitemContract.SubItemsExpandWidth = 14;
			this.sitemContract.Text = "Contract";
			this.sitemContract.Click += new global::System.EventHandler(this.sitemContract_Click);
			this.sitemLoadingTouch.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.sitemLoadingTouch.Image = global::SQSClient.Properties.Resources.loadingtouch48;
			this.sitemLoadingTouch.ImagePosition = global::DevComponents.DotNetBar.eImagePosition.Top;
			this.sitemLoadingTouch.Name = "sitemLoadingTouch";
			this.sitemLoadingTouch.SubItemsExpandWidth = 14;
			this.sitemLoadingTouch.Text = "LoadingTouch";
			this.sitemLoadingTouch.Click += new global::System.EventHandler(this.sitemLoadingTouch_Click);
			this.sitemLabRecord.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.sitemLabRecord.Image = global::SQSClient.Properties.Resources.lab48;
			this.sitemLabRecord.ImagePosition = global::DevComponents.DotNetBar.eImagePosition.Top;
			this.sitemLabRecord.Name = "sitemLabRecord";
			this.sitemLabRecord.SubItemsExpandWidth = 14;
			this.sitemLabRecord.Text = "LabRecord";
			this.sitemLabRecord.Click += new global::System.EventHandler(this.sitemLabRecord_Click);
			this.sitemFormDesign.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.sitemFormDesign.Image = global::SQSClient.Properties.Resources.formdesign48;
			this.sitemFormDesign.ImagePosition = global::DevComponents.DotNetBar.eImagePosition.Top;
			this.sitemFormDesign.Name = "sitemFormDesign";
			this.sitemFormDesign.SubItemsExpandWidth = 14;
			this.sitemFormDesign.Text = "FormDesign";
			this.sitemFormDesign.Click += new global::System.EventHandler(this.sitemFormDesign_Click);
			this.rmenuBaseInfo.AutoOverflowEnabled = true;
			this.rmenuBaseInfo.BackgroundMouseOverStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.rmenuBaseInfo.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.rmenuBaseInfo.ContainerControlProcessDialogKey = true;
			this.rmenuBaseInfo.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.rmenuBaseInfo.DragDropSupport = true;
			this.rmenuBaseInfo.Items.AddRange(new global::DevComponents.DotNetBar.BaseItem[]
			{
				this.sitemTruck,
				this.sitemICCard,
				this.sitemClientpart,
				this.sitemSettlepart
			});
			this.rmenuBaseInfo.Location = new global::System.Drawing.Point(207, 0);
			this.rmenuBaseInfo.Name = "rmenuBaseInfo";
			this.rmenuBaseInfo.Size = new global::System.Drawing.Size(63, 100);
			this.rmenuBaseInfo.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.Metro;
			this.rmenuBaseInfo.TabIndex = 21;
			this.rmenuBaseInfo.Text = "BaseInfo";
			this.rmenuBaseInfo.TitleStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.rmenuBaseInfo.TitleStyleMouseOver.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.rmenuBaseInfo.VerticalItemAlignment = global::DevComponents.DotNetBar.eVerticalItemsAlignment.Middle;
			this.sitemTruck.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.sitemTruck.Image = global::SQSClient.Properties.Resources.truck48;
			this.sitemTruck.ImagePosition = global::DevComponents.DotNetBar.eImagePosition.Top;
			this.sitemTruck.Name = "sitemTruck";
			this.sitemTruck.SubItemsExpandWidth = 14;
			this.sitemTruck.Text = "Truck";
			this.sitemTruck.Click += new global::System.EventHandler(this.sitemTruck_Click);
			this.sitemICCard.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.sitemICCard.Image = global::SQSClient.Properties.Resources.iccard48;
			this.sitemICCard.ImagePosition = global::DevComponents.DotNetBar.eImagePosition.Top;
			this.sitemICCard.Name = "sitemICCard";
			this.sitemICCard.SubItemsExpandWidth = 14;
			this.sitemICCard.Text = "ICCard";
			this.sitemICCard.Click += new global::System.EventHandler(this.sitemICCard_Click);
			this.sitemClientpart.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.sitemClientpart.Image = global::SQSClient.Properties.Resources.clientpart48;
			this.sitemClientpart.ImagePosition = global::DevComponents.DotNetBar.eImagePosition.Top;
			this.sitemClientpart.Name = "sitemClientpart";
			this.sitemClientpart.SubItemsExpandWidth = 14;
			this.sitemClientpart.Text = "Clientpart";
			this.sitemClientpart.Click += new global::System.EventHandler(this.sitemClientpart_Click);
			this.sitemSettlepart.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.sitemSettlepart.Image = global::SQSClient.Properties.Resources.settlepart48;
			this.sitemSettlepart.ImagePosition = global::DevComponents.DotNetBar.eImagePosition.Top;
			this.sitemSettlepart.Name = "sitemSettlepart";
			this.sitemSettlepart.SubItemsExpandWidth = 14;
			this.sitemSettlepart.Text = "Settlepart";
			this.sitemSettlepart.Click += new global::System.EventHandler(this.sitemSettlepart_Click);
			this.rmenuSystemSetup.AutoOverflowEnabled = true;
			this.rmenuSystemSetup.BackgroundMouseOverStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.rmenuSystemSetup.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.rmenuSystemSetup.ContainerControlProcessDialogKey = true;
			this.rmenuSystemSetup.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.rmenuSystemSetup.DragDropSupport = true;
			this.rmenuSystemSetup.Items.AddRange(new global::DevComponents.DotNetBar.BaseItem[]
			{
				this.sitemPermission,
				this.sitemSystemPara,
				this.sitemLocalPara,
				this.buttonItem20
			});
			this.rmenuSystemSetup.Location = new global::System.Drawing.Point(114, 0);
			this.rmenuSystemSetup.Name = "rmenuSystemSetup";
			this.rmenuSystemSetup.Size = new global::System.Drawing.Size(93, 100);
			this.rmenuSystemSetup.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.Metro;
			this.rmenuSystemSetup.TabIndex = 20;
			this.rmenuSystemSetup.Text = "SystemSetup";
			this.rmenuSystemSetup.TitleStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.rmenuSystemSetup.TitleStyleMouseOver.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.rmenuSystemSetup.VerticalItemAlignment = global::DevComponents.DotNetBar.eVerticalItemsAlignment.Middle;
			this.sitemPermission.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.sitemPermission.Image = global::SQSClient.Properties.Resources.permission48;
			this.sitemPermission.ImagePosition = global::DevComponents.DotNetBar.eImagePosition.Top;
			this.sitemPermission.Name = "sitemPermission";
			this.sitemPermission.SubItemsExpandWidth = 14;
			this.sitemPermission.Text = "Permission";
			this.sitemPermission.Click += new global::System.EventHandler(this.sitemPermission_Click);
			this.sitemSystemPara.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.sitemSystemPara.Image = global::SQSClient.Properties.Resources.systempara48;
			this.sitemSystemPara.ImagePosition = global::DevComponents.DotNetBar.eImagePosition.Top;
			this.sitemSystemPara.Name = "sitemSystemPara";
			this.sitemSystemPara.SubItemsExpandWidth = 14;
			this.sitemSystemPara.Text = "SystemPara";
			this.sitemSystemPara.Click += new global::System.EventHandler(this.sitemSystemPara_Click);
			this.sitemLocalPara.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.sitemLocalPara.Image = global::SQSClient.Properties.Resources.localpara48;
			this.sitemLocalPara.ImagePosition = global::DevComponents.DotNetBar.eImagePosition.Top;
			this.sitemLocalPara.Name = "sitemLocalPara";
			this.sitemLocalPara.SubItemsExpandWidth = 14;
			this.sitemLocalPara.Text = "LocalPara";
			this.sitemLocalPara.Click += new global::System.EventHandler(this.sitemLocalPara_Click);
			this.buttonItem20.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.buttonItem20.Enabled = false;
			this.buttonItem20.ImagePosition = global::DevComponents.DotNetBar.eImagePosition.Top;
			this.buttonItem20.Name = "buttonItem20";
			this.buttonItem20.SubItemsExpandWidth = 14;
			this.buttonItem20.Text = " ";
			this.rmenuCommConfig.AutoOverflowEnabled = true;
			this.rmenuCommConfig.BackgroundMouseOverStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.rmenuCommConfig.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.rmenuCommConfig.ContainerControlProcessDialogKey = true;
			this.rmenuCommConfig.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.rmenuCommConfig.DragDropSupport = true;
			this.rmenuCommConfig.Items.AddRange(new global::DevComponents.DotNetBar.BaseItem[]
			{
				this.sitemProduct,
				this.sitemServer,
				this.sitemController,
				this.sitemUnit,
				this.sitemTank,
				this.sitemLoadometer,
				this.sitemCommPoints
			});
			this.rmenuCommConfig.Location = new global::System.Drawing.Point(0, 0);
			this.rmenuCommConfig.Name = "rmenuCommConfig";
			this.rmenuCommConfig.Size = new global::System.Drawing.Size(114, 100);
			this.rmenuCommConfig.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.Metro;
			this.rmenuCommConfig.TabIndex = 16;
			this.rmenuCommConfig.Text = "CommConfig";
			this.rmenuCommConfig.TitleStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.rmenuCommConfig.TitleStyleMouseOver.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.rmenuCommConfig.VerticalItemAlignment = global::DevComponents.DotNetBar.eVerticalItemsAlignment.Middle;
			this.sitemProduct.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.sitemProduct.Image = global::SQSClient.Properties.Resources.product48;
			this.sitemProduct.ImagePosition = global::DevComponents.DotNetBar.eImagePosition.Top;
			this.sitemProduct.Name = "sitemProduct";
			this.sitemProduct.SubItemsExpandWidth = 14;
			this.sitemProduct.Text = "Product";
			this.sitemProduct.Click += new global::System.EventHandler(this.sitemProduct_Click);
			this.sitemServer.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.sitemServer.Image = global::SQSClient.Properties.Resources.server48;
			this.sitemServer.ImagePosition = global::DevComponents.DotNetBar.eImagePosition.Top;
			this.sitemServer.Name = "sitemServer";
			this.sitemServer.SubItemsExpandWidth = 14;
			this.sitemServer.Text = "Server";
			this.sitemServer.Click += new global::System.EventHandler(this.sitemServer_Click);
			this.sitemController.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.sitemController.Image = global::SQSClient.Properties.Resources.controller48;
			this.sitemController.ImagePosition = global::DevComponents.DotNetBar.eImagePosition.Top;
			this.sitemController.Name = "sitemController";
			this.sitemController.SubItemsExpandWidth = 14;
			this.sitemController.Text = "Controller";
			this.sitemController.Click += new global::System.EventHandler(this.sitemController_Click);
			this.sitemUnit.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.sitemUnit.Image = global::SQSClient.Properties.Resources.unit48;
			this.sitemUnit.ImagePosition = global::DevComponents.DotNetBar.eImagePosition.Top;
			this.sitemUnit.Name = "sitemUnit";
			this.sitemUnit.SubItemsExpandWidth = 14;
			this.sitemUnit.Text = "Unit";
			this.sitemUnit.Click += new global::System.EventHandler(this.sitemUnit_Click);
			this.sitemTank.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.sitemTank.Image = global::SQSClient.Properties.Resources.tank48;
			this.sitemTank.ImagePosition = global::DevComponents.DotNetBar.eImagePosition.Top;
			this.sitemTank.Name = "sitemTank";
			this.sitemTank.SubItemsExpandWidth = 14;
			this.sitemTank.Text = "Tank";
			this.sitemTank.Click += new global::System.EventHandler(this.sitemTank_Click);
			this.sitemLoadometer.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.sitemLoadometer.Image = global::SQSClient.Properties.Resources.loadometer48;
			this.sitemLoadometer.ImagePosition = global::DevComponents.DotNetBar.eImagePosition.Top;
			this.sitemLoadometer.Name = "sitemLoadometer";
			this.sitemLoadometer.SubItemsExpandWidth = 14;
			this.sitemLoadometer.Text = "Loadometer";
			this.sitemLoadometer.Click += new global::System.EventHandler(this.sitemLoadometer_Click);
			this.sitemCommPoints.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.sitemCommPoints.Image = global::SQSClient.Properties.Resources.commpoints48;
			this.sitemCommPoints.ImagePosition = global::DevComponents.DotNetBar.eImagePosition.Top;
			this.sitemCommPoints.Name = "sitemCommPoints";
			this.sitemCommPoints.SubItemsExpandWidth = 14;
			this.sitemCommPoints.Text = "CommPoints";
			this.sitemCommPoints.Click += new global::System.EventHandler(this.sitemCommPoints_Click);
			this.rmenuLogout.AutoOverflowEnabled = true;
			this.rmenuLogout.BackgroundMouseOverStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.rmenuLogout.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.rmenuLogout.ContainerControlProcessDialogKey = true;
			this.rmenuLogout.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.rmenuLogout.DragDropSupport = true;
			this.rmenuLogout.Items.AddRange(new global::DevComponents.DotNetBar.BaseItem[]
			{
				this.sitemLogout
			});
			this.rmenuLogout.Location = new global::System.Drawing.Point(1205, 0);
			this.rmenuLogout.Name = "rmenuLogout";
			this.rmenuLogout.Size = new global::System.Drawing.Size(63, 100);
			this.rmenuLogout.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.Metro;
			this.rmenuLogout.TabIndex = 10;
			this.rmenuLogout.TitleStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.rmenuLogout.TitleStyleMouseOver.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.rmenuLogout.VerticalItemAlignment = global::DevComponents.DotNetBar.eVerticalItemsAlignment.Middle;
			this.sitemLogout.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.sitemLogout.Image = global::SQSClient.Properties.Resources.logout48;
			this.sitemLogout.ImagePosition = global::DevComponents.DotNetBar.eImagePosition.Top;
			this.sitemLogout.Name = "sitemLogout";
			this.sitemLogout.SubItemsExpandWidth = 14;
			this.sitemLogout.Text = "Logout";
			this.sitemLogout.Click += new global::System.EventHandler(this.sitemLogout_Click);
			this.menuMain.AccessibleDescription = "DotNetBar Bar (menuMain)";
			this.menuMain.AccessibleName = "DotNetBar Bar";
			this.menuMain.AccessibleRole = global::System.Windows.Forms.AccessibleRole.MenuBar;
			this.menuMain.AntiAlias = true;
			this.menuMain.BarType = global::DevComponents.DotNetBar.eBarType.MenuBar;
			this.menuMain.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.menuMain.Font = new global::System.Drawing.Font("微软雅黑", 9f);
			this.menuMain.IsMaximized = false;
			this.menuMain.Items.AddRange(new global::DevComponents.DotNetBar.BaseItem[]
			{
				this.menuCommConfig,
				this.menuProcessControl,
				this.menuSystemSetup,
				this.menuBaseInfo,
				this.menuBusiness,
				this.menuQuery,
				this.menuHelp,
				this.menuLanguage,
				this.menuDBConn,
				this.menuDictionary
			});
			this.menuMain.Location = new global::System.Drawing.Point(0, 0);
			this.menuMain.MenuBar = true;
			this.menuMain.Name = "menuMain";
			this.menuMain.Size = new global::System.Drawing.Size(1268, 26);
			this.menuMain.Stretch = true;
			this.menuMain.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.Windows7;
			this.menuMain.TabIndex = 18;
			this.menuMain.TabStop = false;
			this.menuMain.Text = "bar1";
			this.menuCommConfig.Name = "menuCommConfig";
			this.menuCommConfig.SubItems.AddRange(new global::DevComponents.DotNetBar.BaseItem[]
			{
				this.itemProduct,
				this.itemServer,
				this.itemController,
				this.itemUnit,
				this.itemTank,
				this.itemLoadometer,
				this.itemCommPoints
			});
			this.menuCommConfig.Text = "CommConfig(&C)";
			this.itemProduct.Image = global::SQSClient.Properties.Resources.product16;
			this.itemProduct.Name = "itemProduct";
			this.itemProduct.Text = "Product";
			this.itemProduct.Click += new global::System.EventHandler(this.itemProduct_Click);
			this.itemServer.Image = global::SQSClient.Properties.Resources.server16;
			this.itemServer.Name = "itemServer";
			this.itemServer.Text = "Server";
			this.itemServer.Click += new global::System.EventHandler(this.itemServer_Click);
			this.itemController.Image = global::SQSClient.Properties.Resources.controller16;
			this.itemController.Name = "itemController";
			this.itemController.Text = "Controller";
			this.itemController.Click += new global::System.EventHandler(this.itemController_Click);
			this.itemUnit.Image = global::SQSClient.Properties.Resources.unit16;
			this.itemUnit.Name = "itemUnit";
			this.itemUnit.Text = "Unit";
			this.itemUnit.Click += new global::System.EventHandler(this.itemUnit_Click);
			this.itemTank.Image = global::SQSClient.Properties.Resources.tank16;
			this.itemTank.Name = "itemTank";
			this.itemTank.Text = "Tank";
			this.itemTank.Click += new global::System.EventHandler(this.itemTank_Click);
			this.itemLoadometer.Image = global::SQSClient.Properties.Resources.loadometer16;
			this.itemLoadometer.Name = "itemLoadometer";
			this.itemLoadometer.Text = "Loadometer";
			this.itemLoadometer.Click += new global::System.EventHandler(this.itemLoadometer_Click);
			this.itemCommPoints.Image = global::SQSClient.Properties.Resources.commpoints16;
			this.itemCommPoints.Name = "itemCommPoints";
			this.itemCommPoints.Text = "CommPoints";
			this.itemCommPoints.Click += new global::System.EventHandler(this.itemCommPoints_Click);
			this.menuProcessControl.Name = "menuProcessControl";
			this.menuProcessControl.SubItems.AddRange(new global::DevComponents.DotNetBar.BaseItem[]
			{
				this.itemSrmStep,
				this.itemSrmInvStep
			});
			this.menuProcessControl.Text = "ProcessControl(&P)";
			this.itemSrmStep.Image = global::SQSClient.Properties.Resources.localpara16;
			this.itemSrmStep.Name = "itemSrmStep";
			this.itemSrmStep.Text = "SrmStep";
			this.itemSrmStep.Click += new global::System.EventHandler(this.itemSrmStep_Click);
			this.itemSrmInvStep.Image = global::SQSClient.Properties.Resources.localpara16;
			this.itemSrmInvStep.Name = "itemSrmInvStep";
			this.itemSrmInvStep.Text = "SrmInvStep";
			this.itemSrmInvStep.Click += new global::System.EventHandler(this.itemSrmInvStep_Click);
			this.menuSystemSetup.Name = "menuSystemSetup";
			this.menuSystemSetup.SubItems.AddRange(new global::DevComponents.DotNetBar.BaseItem[]
			{
				this.itemPermission,
				this.itemSystemPara,
				this.itemLocalPara,
				this.itemDynamicButton
			});
			this.menuSystemSetup.Text = "SystemSetup(&S)";
			this.itemPermission.Image = global::SQSClient.Properties.Resources.permission16;
			this.itemPermission.Name = "itemPermission";
			this.itemPermission.Text = "Permission";
			this.itemPermission.Click += new global::System.EventHandler(this.itemPermission_Click);
			this.itemSystemPara.Image = global::SQSClient.Properties.Resources.systempara16;
			this.itemSystemPara.Name = "itemSystemPara";
			this.itemSystemPara.Text = "SystemPara";
			this.itemSystemPara.Click += new global::System.EventHandler(this.itemSystemPara_Click);
			this.itemLocalPara.Image = global::SQSClient.Properties.Resources.localpara16;
			this.itemLocalPara.Name = "itemLocalPara";
			this.itemLocalPara.Text = "LocalPara";
			this.itemLocalPara.Click += new global::System.EventHandler(this.itemLocalPara_Click);
			this.itemDynamicButton.Image = global::SQSClient.Properties.Resources.localpara16;
			this.itemDynamicButton.Name = "itemDynamicButton";
			this.itemDynamicButton.Text = "DynamicButton";
			this.itemDynamicButton.Click += new global::System.EventHandler(this.itemDynamicButton_Click);
			this.menuBaseInfo.Name = "menuBaseInfo";
			this.menuBaseInfo.SubItems.AddRange(new global::DevComponents.DotNetBar.BaseItem[]
			{
				this.itemTruck,
				this.itemICCard,
				this.itemClientpart,
				this.itemSettlepart
			});
			this.menuBaseInfo.Text = "BaseInfo(&I)";
			this.itemTruck.Image = global::SQSClient.Properties.Resources.truck16;
			this.itemTruck.Name = "itemTruck";
			this.itemTruck.Text = "Truck";
			this.itemTruck.Click += new global::System.EventHandler(this.itemTruck_Click);
			this.itemICCard.Image = global::SQSClient.Properties.Resources.iccard16;
			this.itemICCard.Name = "itemICCard";
			this.itemICCard.Text = "ICCard";
			this.itemICCard.Click += new global::System.EventHandler(this.itemICCard_Click);
			this.itemClientpart.Image = global::SQSClient.Properties.Resources.clientpart16;
			this.itemClientpart.Name = "itemClientpart";
			this.itemClientpart.Text = "Clientpart";
			this.itemClientpart.Click += new global::System.EventHandler(this.itemClientpart_Click);
			this.itemSettlepart.Image = global::SQSClient.Properties.Resources.settlepart16;
			this.itemSettlepart.Name = "itemSettlepart";
			this.itemSettlepart.Text = "Settlepart";
			this.itemSettlepart.Click += new global::System.EventHandler(this.itemSettlepart_Click);
			this.menuBusiness.Name = "menuBusiness";
			this.menuBusiness.SubItems.AddRange(new global::DevComponents.DotNetBar.BaseItem[]
			{
				this.itemUnitMonitor,
				this.itemContract,
				this.itemLoadingTouch,
				this.itemLabRecord,
				this.itemFormDesign
			});
			this.menuBusiness.Text = "Business(&B)";
			this.itemUnitMonitor.Image = global::SQSClient.Properties.Resources.unitmonitor16;
			this.itemUnitMonitor.Name = "itemUnitMonitor";
			this.itemUnitMonitor.Text = "UnitMonitor";
			this.itemUnitMonitor.Click += new global::System.EventHandler(this.itemUnitMonitor_Click);
			this.itemContract.Image = global::SQSClient.Properties.Resources.contract16;
			this.itemContract.Name = "itemContract";
			this.itemContract.Text = "Contract";
			this.itemContract.Click += new global::System.EventHandler(this.itemContract_Click);
			this.itemLoadingTouch.Image = global::SQSClient.Properties.Resources.loadingtouch16;
			this.itemLoadingTouch.Name = "itemLoadingTouch";
			this.itemLoadingTouch.Text = "LoadingTouch";
			this.itemLoadingTouch.Click += new global::System.EventHandler(this.itemLoadingTouch_Click);
			this.itemLabRecord.Image = global::SQSClient.Properties.Resources.contract16;
			this.itemLabRecord.Name = "itemLabRecord";
			this.itemLabRecord.Text = "LabRecord";
			this.itemLabRecord.Click += new global::System.EventHandler(this.itemLabRecord_Click);
			this.itemFormDesign.Image = global::SQSClient.Properties.Resources.formdesign16;
			this.itemFormDesign.Name = "itemFormDesign";
			this.itemFormDesign.Text = "FormDesign";
			this.itemFormDesign.Click += new global::System.EventHandler(this.itemFormDesign_Click);
			this.menuQuery.Name = "menuQuery";
			this.menuQuery.SubItems.AddRange(new global::DevComponents.DotNetBar.BaseItem[]
			{
				this.itemHistoricalData,
				this.itemStatisticsReport,
				this.itemLog,
				this.itemHistoricalAlarm
			});
			this.menuQuery.Text = "Query(&R)";
			this.itemHistoricalData.Image = global::SQSClient.Properties.Resources.hisdata16;
			this.itemHistoricalData.Name = "itemHistoricalData";
			this.itemHistoricalData.Text = "HistoricalData";
			this.itemHistoricalData.Click += new global::System.EventHandler(this.itemHistoricalData_Click);
			this.itemStatisticsReport.Image = global::SQSClient.Properties.Resources.stcreport16;
			this.itemStatisticsReport.Name = "itemStatisticsReport";
			this.itemStatisticsReport.Text = "StatisticsReport";
			this.itemStatisticsReport.Click += new global::System.EventHandler(this.itemStatisticsReport_Click);
			this.itemLog.Image = global::SQSClient.Properties.Resources.operatelog16;
			this.itemLog.Name = "itemLog";
			this.itemLog.Text = "Log";
			this.itemLog.Click += new global::System.EventHandler(this.itemLog_Click);
			this.itemHistoricalAlarm.Image = global::SQSClient.Properties.Resources.alarmdata16;
			this.itemHistoricalAlarm.Name = "itemHistoricalAlarm";
			this.itemHistoricalAlarm.Text = "HistoricalAlarm";
			this.itemHistoricalAlarm.Click += new global::System.EventHandler(this.itemAlarm_Click);
			this.menuHelp.Name = "menuHelp";
			this.menuHelp.SubItems.AddRange(new global::DevComponents.DotNetBar.BaseItem[]
			{
				this.itemManual,
				this.itemPasswordModify,
				this.itemAbout
			});
			this.menuHelp.Text = "Help(&H)";
			this.itemManual.Image = global::SQSClient.Properties.Resources.manual16;
			this.itemManual.Name = "itemManual";
			this.itemManual.Text = "Manual";
			this.itemManual.Click += new global::System.EventHandler(this.itemManual_Click);
			this.itemPasswordModify.Image = global::SQSClient.Properties.Resources.passwordmodify16;
			this.itemPasswordModify.Name = "itemPasswordModify";
			this.itemPasswordModify.Text = "PasswordModify";
			this.itemPasswordModify.Click += new global::System.EventHandler(this.itemPasswordModify_Click);
			this.itemAbout.Image = global::SQSClient.Properties.Resources.about16;
			this.itemAbout.Name = "itemAbout";
			this.itemAbout.Text = "About";
			this.itemAbout.Click += new global::System.EventHandler(this.itemAbout_Click);
			this.menuLanguage.ItemAlignment = global::DevComponents.DotNetBar.eItemAlignment.Far;
			this.menuLanguage.Name = "menuLanguage";
			this.menuLanguage.SubItems.AddRange(new global::DevComponents.DotNetBar.BaseItem[]
			{
				this.itemChinese,
				this.itemEnglish
			});
			this.menuLanguage.Text = "Language";
			this.itemChinese.Name = "itemChinese";
			this.itemChinese.Text = "Chinese";
			this.itemChinese.Click += new global::System.EventHandler(this.itemChinese_Click);
			this.itemEnglish.Name = "itemEnglish";
			this.itemEnglish.Text = "English";
			this.itemEnglish.Click += new global::System.EventHandler(this.itemEnglish_Click);
			this.menuDBConn.Name = "menuDBConn";
			this.menuDBConn.Text = "DBConn";
			this.menuDBConn.Click += new global::System.EventHandler(this.menuDBConn_Click);
			this.menuDictionary.Name = "menuDictionary";
			this.menuDictionary.Text = "Dictionary";
			this.menuDictionary.Click += new global::System.EventHandler(this.menuDictionary_Click);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.None;
			this.AutoSize = true;
			base.ClientSize = new global::System.Drawing.Size(1268, 570);
			base.Controls.Add(this.panelMain);
			base.Controls.Add(this.panelEx1);
			base.Controls.Add(this.panelMenuMain);
			base.Controls.Add(this.menuMain);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "frmMain";
			this.Text = "Inscan SQS Client";
			base.Load += new global::System.EventHandler(this.frmMain_Load);
			this.panelEx1.ResumeLayout(false);
			this.panelEx1.PerformLayout();
			this.panelMenuMain.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.menuMain).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x040009DE RID: 2526
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x040009DF RID: 2527
		private global::DevComponents.DotNetBar.Bar menuMain;

		// Token: 0x040009E0 RID: 2528
		private global::DevComponents.DotNetBar.ButtonItem menuSystemSetup;

		// Token: 0x040009E1 RID: 2529
		private global::DevComponents.DotNetBar.ButtonItem itemProduct;

		// Token: 0x040009E2 RID: 2530
		private global::DevComponents.DotNetBar.ButtonItem itemTank;

		// Token: 0x040009E3 RID: 2531
		private global::DevComponents.DotNetBar.ButtonItem itemUnit;

		// Token: 0x040009E4 RID: 2532
		private global::DevComponents.DotNetBar.ButtonItem itemClientpart;

		// Token: 0x040009E5 RID: 2533
		private global::DevComponents.DotNetBar.ButtonItem itemTruck;

		// Token: 0x040009E6 RID: 2534
		private global::DevComponents.DotNetBar.ButtonItem itemICCard;

		// Token: 0x040009E7 RID: 2535
		private global::DevComponents.DotNetBar.ButtonItem itemServer;

		// Token: 0x040009E8 RID: 2536
		private global::DevComponents.DotNetBar.ButtonItem itemSystemPara;

		// Token: 0x040009E9 RID: 2537
		private global::DevComponents.DotNetBar.ButtonItem menuBusiness;

		// Token: 0x040009EA RID: 2538
		private global::DevComponents.DotNetBar.ButtonItem itemLoadingTouch;

		// Token: 0x040009EB RID: 2539
		private global::DevComponents.DotNetBar.ButtonItem menuQuery;

		// Token: 0x040009EC RID: 2540
		private global::DevComponents.DotNetBar.ButtonItem itemLog;

		// Token: 0x040009ED RID: 2541
		private global::DevComponents.DotNetBar.ButtonItem itemHistoricalAlarm;

		// Token: 0x040009EE RID: 2542
		private global::DevComponents.DotNetBar.ButtonItem menuHelp;

		// Token: 0x040009EF RID: 2543
		private global::DevComponents.DotNetBar.ButtonItem itemManual;

		// Token: 0x040009F0 RID: 2544
		private global::DevComponents.DotNetBar.ButtonItem itemUnitMonitor;

		// Token: 0x040009F1 RID: 2545
		private global::DevComponents.DotNetBar.ButtonItem itemHistoricalData;

		// Token: 0x040009F2 RID: 2546
		private global::DevComponents.DotNetBar.ButtonItem itemStatisticsReport;

		// Token: 0x040009F3 RID: 2547
		private global::DevComponents.DotNetBar.ButtonItem itemPasswordModify;

		// Token: 0x040009F4 RID: 2548
		private global::DevComponents.DotNetBar.ButtonItem itemFormDesign;

		// Token: 0x040009F5 RID: 2549
		private global::DevComponents.DotNetBar.ButtonItem menuBaseInfo;

		// Token: 0x040009F6 RID: 2550
		private global::DevComponents.DotNetBar.ButtonItem itemSettlepart;

		// Token: 0x040009F7 RID: 2551
		private global::DevComponents.DotNetBar.ButtonItem itemAbout;

		// Token: 0x040009F8 RID: 2552
		private global::DevComponents.DotNetBar.ButtonItem itemCommPoints;

		// Token: 0x040009F9 RID: 2553
		private global::DevComponents.DotNetBar.PanelEx panelMenuMain;

		// Token: 0x040009FA RID: 2554
		private global::DevComponents.DotNetBar.RibbonBar rmenuLogout;

		// Token: 0x040009FB RID: 2555
		private global::DevComponents.DotNetBar.ButtonItem sitemLogout;

		// Token: 0x040009FC RID: 2556
		private global::DevComponents.DotNetBar.ButtonItem itemLocalPara;

		// Token: 0x040009FD RID: 2557
		private global::DevComponents.DotNetBar.ButtonItem itemDynamicButton;

		// Token: 0x040009FE RID: 2558
		private global::DevComponents.DotNetBar.ButtonItem menuCommConfig;

		// Token: 0x040009FF RID: 2559
		private global::DevComponents.DotNetBar.ButtonItem itemLoadometer;

		// Token: 0x04000A00 RID: 2560
		private global::DevComponents.DotNetBar.ButtonItem itemPermission;

		// Token: 0x04000A01 RID: 2561
		private global::DevComponents.DotNetBar.ButtonItem itemController;

		// Token: 0x04000A02 RID: 2562
		private global::DevComponents.DotNetBar.PanelEx panelEx1;

		// Token: 0x04000A03 RID: 2563
		private global::DevComponents.DotNetBar.LabelX labelX1;

		// Token: 0x04000A04 RID: 2564
		private global::DevComponents.DotNetBar.LabelX labLoginUser;

		// Token: 0x04000A05 RID: 2565
		private global::DevComponents.DotNetBar.PanelEx panelMain;

		// Token: 0x04000A06 RID: 2566
		private global::DevComponents.DotNetBar.RibbonBar rmenuCommConfig;

		// Token: 0x04000A07 RID: 2567
		private global::DevComponents.DotNetBar.ButtonItem sitemServer;

		// Token: 0x04000A08 RID: 2568
		private global::DevComponents.DotNetBar.ButtonItem sitemController;

		// Token: 0x04000A09 RID: 2569
		private global::DevComponents.DotNetBar.ButtonItem sitemCommPoints;

		// Token: 0x04000A0A RID: 2570
		private global::DevComponents.DotNetBar.ButtonItem sitemUnit;

		// Token: 0x04000A0B RID: 2571
		private global::DevComponents.DotNetBar.ButtonItem sitemLoadometer;

		// Token: 0x04000A0C RID: 2572
		private global::DevComponents.DotNetBar.ButtonItem itemContract;

		// Token: 0x04000A0D RID: 2573
		private global::DevComponents.DotNetBar.ButtonItem sitemProduct;

		// Token: 0x04000A0E RID: 2574
		private global::DevComponents.DotNetBar.ButtonItem sitemTank;

		// Token: 0x04000A0F RID: 2575
		private global::DevComponents.DotNetBar.RibbonBar ribbonBar6;

		// Token: 0x04000A10 RID: 2576
		private global::DevComponents.DotNetBar.RibbonBar rmenuQuery;

		// Token: 0x04000A11 RID: 2577
		private global::DevComponents.DotNetBar.ButtonItem sitemHistoricalData;

		// Token: 0x04000A12 RID: 2578
		private global::DevComponents.DotNetBar.ButtonItem sitemStatisticsReport;

		// Token: 0x04000A13 RID: 2579
		private global::DevComponents.DotNetBar.ButtonItem sitemLog;

		// Token: 0x04000A14 RID: 2580
		private global::DevComponents.DotNetBar.ButtonItem sitemHistoricalAlarm;

		// Token: 0x04000A15 RID: 2581
		private global::DevComponents.DotNetBar.RibbonBar rmenuBusiness;

		// Token: 0x04000A16 RID: 2582
		private global::DevComponents.DotNetBar.ButtonItem sitemUnitMonitor;

		// Token: 0x04000A17 RID: 2583
		private global::DevComponents.DotNetBar.ButtonItem sitemContract;

		// Token: 0x04000A18 RID: 2584
		private global::DevComponents.DotNetBar.ButtonItem sitemLoadingTouch;

		// Token: 0x04000A19 RID: 2585
		private global::DevComponents.DotNetBar.ButtonItem sitemFormDesign;

		// Token: 0x04000A1A RID: 2586
		private global::DevComponents.DotNetBar.RibbonBar rmenuBaseInfo;

		// Token: 0x04000A1B RID: 2587
		private global::DevComponents.DotNetBar.ButtonItem sitemTruck;

		// Token: 0x04000A1C RID: 2588
		private global::DevComponents.DotNetBar.ButtonItem sitemICCard;

		// Token: 0x04000A1D RID: 2589
		private global::DevComponents.DotNetBar.ButtonItem sitemClientpart;

		// Token: 0x04000A1E RID: 2590
		private global::DevComponents.DotNetBar.ButtonItem sitemSettlepart;

		// Token: 0x04000A1F RID: 2591
		private global::DevComponents.DotNetBar.RibbonBar rmenuSystemSetup;

		// Token: 0x04000A20 RID: 2592
		private global::DevComponents.DotNetBar.ButtonItem sitemPermission;

		// Token: 0x04000A21 RID: 2593
		private global::DevComponents.DotNetBar.ButtonItem sitemSystemPara;

		// Token: 0x04000A22 RID: 2594
		private global::DevComponents.DotNetBar.ButtonItem sitemLocalPara;

		// Token: 0x04000A23 RID: 2595
		private global::DevComponents.DotNetBar.ButtonItem buttonItem20;

		// Token: 0x04000A24 RID: 2596
		private global::DevComponents.DotNetBar.ButtonItem menuLanguage;

		// Token: 0x04000A25 RID: 2597
		private global::DevComponents.DotNetBar.ButtonItem menuDBConn;

		// Token: 0x04000A26 RID: 2598
		private global::DevComponents.DotNetBar.ButtonItem itemChinese;

		// Token: 0x04000A27 RID: 2599
		private global::DevComponents.DotNetBar.ButtonItem itemEnglish;

		// Token: 0x04000A28 RID: 2600
		private global::DevComponents.DotNetBar.ButtonItem menuDictionary;

		// Token: 0x04000A29 RID: 2601
		private global::DevComponents.DotNetBar.ButtonItem sitemLabRecord;

		// Token: 0x04000A2A RID: 2602
		private global::DevComponents.DotNetBar.ButtonItem itemSrmStep;

		// Token: 0x04000A2B RID: 2603
		private global::DevComponents.DotNetBar.ButtonItem itemSrmInvStep;

		// Token: 0x04000A2C RID: 2604
		private global::DevComponents.DotNetBar.ButtonItem menuProcessControl;

		// Token: 0x04000A2D RID: 2605
		private global::DevComponents.DotNetBar.ButtonItem itemLabRecord;
	}
}
