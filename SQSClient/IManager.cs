using System;
using InterHandle;

namespace SQSClient
{
	// Token: 0x02000045 RID: 69
	public class IManager
	{
		// Token: 0x040004DC RID: 1244
		public static string AddressCode;

		// Token: 0x040004DD RID: 1245
		public static string TakeCardCode = "";

		// Token: 0x040004DE RID: 1246
		public static string SettleCode = "";

		// Token: 0x040004DF RID: 1247
		public static SOAPHandle SOAPHandle = new SOAPHandle();

		// Token: 0x040004E0 RID: 1248
		public static SOAPHandle SOAPHandleTakeCard = new SOAPHandle();

		// Token: 0x040004E1 RID: 1249
		public static SOAPHandle SOAPHandleCheckReturn = new SOAPHandle();
	}
}
