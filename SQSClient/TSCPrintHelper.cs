using System;
using System.Collections.Generic;
using DAL.Base.SQSConfig;
using Model.SQSConfig;

namespace SQSClient
{
	// Token: 0x02000039 RID: 57
	public class TSCPrintHelper
	{
		// Token: 0x0600028F RID: 655 RVA: 0x0004447C File Offset: 0x0004267C
		public static void RunTCSPrint(List<ModT_ticket> list, int printCount)
		{
			TSCPrintLib.openport("TSC TTP-244 Pro");
			TSCPrintLib.setup("50", "30", "4", "8", "0", "3", "0");
			DateTime now = DateTime.Now;
			foreach (ModT_ticket modT_ticket in list)
			{
				TSCPrintLib.clearbuffer();
				bool flag = modT_ticket.SampleCode.Length == 0;
				if (flag)
				{
					int maxIndex = DanHaoHelper.Instance().GetMaxIndex(Settings.Instance.LabPrintCode, now);
					string sampleCode = Settings.Instance.LabPrintCode + now.ToString("yyyyMMdd") + maxIndex.ToString().PadLeft(3, '0');
					modT_ticket.SampleCode = sampleCode;
					Dictionary<string, object> dictionary = new Dictionary<string, object>();
					dictionary.Add("SampleCode", modT_ticket.SampleCode);
					DalT_ticket.Instance.Update(dictionary, modT_ticket.Id);
				}
				TSCPrintLib.barcode("20", "20", "128", "80", "0", "0", "2", "2", modT_ticket.SampleCode);
				TSCPrintLib.windowsfont(30, 110, 24, 0, 0, 0, "ARIAL", "单号：" + modT_ticket.DanHao);
				TSCPrintLib.windowsfont(20, 150, 24, 0, 0, 0, "宋体", modT_ticket.ClientPart);
				TSCPrintLib.windowsfont(20, 200, 24, 0, 0, 0, "宋体", modT_ticket.Lisence + "  " + modT_ticket.ProductName);
				TSCPrintLib.printlabel("1", printCount.ToString());
			}
			TSCPrintLib.closeport();
		}

		// Token: 0x06000290 RID: 656 RVA: 0x00044664 File Offset: 0x00042864
		public static void CommBarPrint(int printNum)
		{
			DateTime now = DateTime.Now;
			TSCPrintLib.openport("TSC TTP-244 Pro");
			TSCPrintLib.setup("50", "30", "4", "8", "0", "3", "0");
			for (int i = 0; i < printNum; i++)
			{
				int maxIndex = DanHaoHelper.Instance().GetMaxIndex("LAB", now);
				string code = "LAB" + now.ToString("yyyyMMdd") + maxIndex.ToString().PadLeft(3, '0');
				TSCPrintLib.clearbuffer();
				TSCPrintLib.barcode("20", "20", "128", "80", "1", "0", "2", "2", code);
				TSCPrintLib.windowsfont(30, 150, 32, 0, 0, 0, "ARIAL", "时间：" + DateTime.Now.ToString("yyyy-MM-dd"));
				TSCPrintLib.printlabel("1", Settings.Instance.BarcodePrintCount.ToString());
			}
			TSCPrintLib.closeport();
		}
	}
}
