using System;
using System.Configuration;

namespace SQSClient
{
	// Token: 0x02000093 RID: 147
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x17000034 RID: 52
		// (get) Token: 0x0600081A RID: 2074 RVA: 0x000CC7D4 File Offset: 0x000CA9D4
		// (set) Token: 0x0600081B RID: 2075 RVA: 0x000CC7F6 File Offset: 0x000CA9F6
		[UserScopedSetting]
		[DefaultSettingValue("")]
		public string MonitorIDs
		{
			get
			{
				return (string)this["MonitorIDs"];
			}
			set
			{
				this["MonitorIDs"] = value;
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x0600081C RID: 2076 RVA: 0x000CC808 File Offset: 0x000CAA08
		// (set) Token: 0x0600081D RID: 2077 RVA: 0x000CC82A File Offset: 0x000CAA2A
		[UserScopedSetting]
		[DefaultSettingValue("COM0")]
		[SettingsDescription("串口号")]
		public string PortName
		{
			get
			{
				return (string)this["PortName"];
			}
			set
			{
				this["PortName"] = value;
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x0600081E RID: 2078 RVA: 0x000CC83C File Offset: 0x000CAA3C
		// (set) Token: 0x0600081F RID: 2079 RVA: 0x000CC85E File Offset: 0x000CAA5E
		[UserScopedSetting]
		[DefaultSettingValue("115200")]
		[SettingsDescription("波特率")]
		public int BaudRate
		{
			get
			{
				return (int)this["BaudRate"];
			}
			set
			{
				this["BaudRate"] = value;
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x06000820 RID: 2080 RVA: 0x000CC874 File Offset: 0x000CAA74
		// (set) Token: 0x06000821 RID: 2081 RVA: 0x000CC896 File Offset: 0x000CAA96
		[UserScopedSetting]
		[DefaultSettingValue("120")]
		public int TimeOut
		{
			get
			{
				return (int)this["TimeOut"];
			}
			set
			{
				this["TimeOut"] = value;
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x06000822 RID: 2082 RVA: 0x000CC8AC File Offset: 0x000CAAAC
		// (set) Token: 0x06000823 RID: 2083 RVA: 0x000CC8CE File Offset: 0x000CAACE
		[UserScopedSetting]
		[DefaultSettingValue("")]
		[SettingsDescription("装车打印机")]
		public string LoadPrinter
		{
			get
			{
				return (string)this["LoadPrinter"];
			}
			set
			{
				this["LoadPrinter"] = value;
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x06000824 RID: 2084 RVA: 0x000CC8E0 File Offset: 0x000CAAE0
		// (set) Token: 0x06000825 RID: 2085 RVA: 0x000CC902 File Offset: 0x000CAB02
		[UserScopedSetting]
		[DefaultSettingValue("")]
		[SettingsDescription("卸车打印机")]
		public string UnloadPrinter
		{
			get
			{
				return (string)this["UnloadPrinter"];
			}
			set
			{
				this["UnloadPrinter"] = value;
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x06000826 RID: 2086 RVA: 0x000CC914 File Offset: 0x000CAB14
		// (set) Token: 0x06000827 RID: 2087 RVA: 0x000CC936 File Offset: 0x000CAB36
		[UserScopedSetting]
		[DefaultSettingValue("")]
		[SettingsDescription("历史数据打印机")]
		public string HisReportPrinter
		{
			get
			{
				return (string)this["HisReportPrinter"];
			}
			set
			{
				this["HisReportPrinter"] = value;
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000828 RID: 2088 RVA: 0x000CC948 File Offset: 0x000CAB48
		// (set) Token: 0x06000829 RID: 2089 RVA: 0x000CC96A File Offset: 0x000CAB6A
		[UserScopedSetting]
		[DefaultSettingValue("false")]
		[SettingsDescription("结算提醒开关")]
		public bool AccountRemindEnable
		{
			get
			{
				return (bool)this["AccountRemindEnable"];
			}
			set
			{
				this["AccountRemindEnable"] = value;
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x0600082A RID: 2090 RVA: 0x000CC980 File Offset: 0x000CAB80
		// (set) Token: 0x0600082B RID: 2091 RVA: 0x000CC9A2 File Offset: 0x000CABA2
		[UserScopedSetting]
		[DefaultSettingValue("10")]
		[SettingsDescription("结算提醒时间（分）")]
		public int AccountTimeOut
		{
			get
			{
				return (int)this["AccountTimeOut"];
			}
			set
			{
				this["AccountTimeOut"] = value;
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x0600082C RID: 2092 RVA: 0x000CC9B8 File Offset: 0x000CABB8
		// (set) Token: 0x0600082D RID: 2093 RVA: 0x000CC9DA File Offset: 0x000CABDA
		[UserScopedSetting]
		[DefaultSettingValue("0")]
		[SettingsDescription("记录模式")]
		public int LocalTicketType
		{
			get
			{
				return (int)this["LocalTicketType"];
			}
			set
			{
				this["LocalTicketType"] = value;
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x0600082E RID: 2094 RVA: 0x000CC9F0 File Offset: 0x000CABF0
		// (set) Token: 0x0600082F RID: 2095 RVA: 0x000CCA12 File Offset: 0x000CAC12
		[UserScopedSetting]
		[DefaultSettingValue("0")]
		[SettingsDescription("物料显示类型")]
		public int ProductShowType
		{
			get
			{
				return (int)this["ProductShowType"];
			}
			set
			{
				this["ProductShowType"] = value;
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x06000830 RID: 2096 RVA: 0x000CCA28 File Offset: 0x000CAC28
		// (set) Token: 0x06000831 RID: 2097 RVA: 0x000CCA4A File Offset: 0x000CAC4A
		[UserScopedSetting]
		[DefaultSettingValue("0")]
		[SettingsDescription("业务控制类型")]
		public int BusinessControlType
		{
			get
			{
				return (int)this["BusinessControlType"];
			}
			set
			{
				this["BusinessControlType"] = value;
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x06000832 RID: 2098 RVA: 0x000CCA60 File Offset: 0x000CAC60
		// (set) Token: 0x06000833 RID: 2099 RVA: 0x000CCA82 File Offset: 0x000CAC82
		[UserScopedSetting]
		[DefaultSettingValue("1000")]
		[SettingsDescription("订单最大显示记录数")]
		public int ShowTicketMaxCount
		{
			get
			{
				return (int)this["ShowTicketMaxCount"];
			}
			set
			{
				this["ShowTicketMaxCount"] = value;
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000834 RID: 2100 RVA: 0x000CCA98 File Offset: 0x000CAC98
		// (set) Token: 0x06000835 RID: 2101 RVA: 0x000CCABA File Offset: 0x000CACBA
		[UserScopedSetting]
		[DefaultSettingValue("2")]
		[SettingsDescription("条码打印次数")]
		public int BarcodePrintCount
		{
			get
			{
				return (int)this["BarcodePrintCount"];
			}
			set
			{
				this["BarcodePrintCount"] = value;
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000836 RID: 2102 RVA: 0x000CCAD0 File Offset: 0x000CACD0
		// (set) Token: 0x06000837 RID: 2103 RVA: 0x000CCAF2 File Offset: 0x000CACF2
		[UserScopedSetting]
		[DefaultSettingValue("1")]
		[SettingsDescription("质检流程管控")]
		public int LabStepControler
		{
			get
			{
				return (int)this["LabStepControler"];
			}
			set
			{
				this["LabStepControler"] = value;
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x06000838 RID: 2104 RVA: 0x000CCB08 File Offset: 0x000CAD08
		// (set) Token: 0x06000839 RID: 2105 RVA: 0x000CCB2A File Offset: 0x000CAD2A
		[UserScopedSetting]
		[DefaultSettingValue("LAB")]
		[SettingsDescription("质检打印编码")]
		public string LabPrintCode
		{
			get
			{
				return (string)this["LabPrintCode"];
			}
			set
			{
				this["LabPrintCode"] = value;
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x0600083A RID: 2106 RVA: 0x000CCB3C File Offset: 0x000CAD3C
		// (set) Token: 0x0600083B RID: 2107 RVA: 0x000CCB5E File Offset: 0x000CAD5E
		[UserScopedSetting]
		[DefaultSettingValue("false")]
		[SettingsDescription("质检报警声音")]
		public bool IsLabSpeech
		{
			get
			{
				return (bool)this["IsLabSpeech"];
			}
			set
			{
				this["IsLabSpeech"] = value;
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x0600083C RID: 2108 RVA: 0x000CCB74 File Offset: 0x000CAD74
		// (set) Token: 0x0600083D RID: 2109 RVA: 0x000CCB96 File Offset: 0x000CAD96
		[UserScopedSetting]
		[DefaultSettingValue("false")]
		[SettingsDescription("质检动态刷新")]
		public bool IsLabDynamicRefresh
		{
			get
			{
				return (bool)this["IsLabDynamicRefresh"];
			}
			set
			{
				this["IsLabDynamicRefresh"] = value;
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x0600083E RID: 2110 RVA: 0x000CCBAC File Offset: 0x000CADAC
		// (set) Token: 0x0600083F RID: 2111 RVA: 0x000CCBCE File Offset: 0x000CADCE
		[UserScopedSetting]
		[DefaultSettingValue("false")]
		[SettingsDescription("默认物料查询")]
		public bool IsDefaultProductSch
		{
			get
			{
				return (bool)this["IsDefaultProductSch"];
			}
			set
			{
				this["IsDefaultProductSch"] = value;
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000840 RID: 2112 RVA: 0x000CCBE4 File Offset: 0x000CADE4
		// (set) Token: 0x06000841 RID: 2113 RVA: 0x000CCC06 File Offset: 0x000CAE06
		[UserScopedSetting]
		[DefaultSettingValue("false")]
		[SettingsDescription("默认车牌查询")]
		public bool IsDefaultLicenseSch
		{
			get
			{
				return (bool)this["IsDefaultLicenseSch"];
			}
			set
			{
				this["IsDefaultLicenseSch"] = value;
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x06000842 RID: 2114 RVA: 0x000CCC1C File Offset: 0x000CAE1C
		// (set) Token: 0x06000843 RID: 2115 RVA: 0x000CCC3E File Offset: 0x000CAE3E
		[UserScopedSetting]
		[DefaultSettingValue("1")]
		[SettingsDescription("结算量小数位数")]
		public int JieSuanLiangDecimal
		{
			get
			{
				return (int)this["JieSuanLiangDecimal"];
			}
			set
			{
				this["JieSuanLiangDecimal"] = value;
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x06000844 RID: 2116 RVA: 0x000CCC54 File Offset: 0x000CAE54
		// (set) Token: 0x06000845 RID: 2117 RVA: 0x000CCC76 File Offset: 0x000CAE76
		[UserScopedSetting]
		[DefaultSettingValue("0")]
		[SettingsDescription("专属物料分组")]
		public int CompanyGroup
		{
			get
			{
				return (int)this["CompanyGroup"];
			}
			set
			{
				this["CompanyGroup"] = value;
			}
		}
	}
}
