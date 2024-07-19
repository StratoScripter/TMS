using System;

namespace SQSClient
{
	// Token: 0x02000032 RID: 50
	public class ModPriceValue
	{
		// Token: 0x0600025A RID: 602 RVA: 0x00042927 File Offset: 0x00040B27
		public ModPriceValue(decimal upperThreshold, decimal price)
		{
			this.UpperThreshold = upperThreshold;
			this.Price = price;
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600025B RID: 603 RVA: 0x00042941 File Offset: 0x00040B41
		// (set) Token: 0x0600025C RID: 604 RVA: 0x00042949 File Offset: 0x00040B49
		public decimal UpperThreshold { get; set; }

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600025D RID: 605 RVA: 0x00042952 File Offset: 0x00040B52
		// (set) Token: 0x0600025E RID: 606 RVA: 0x0004295A File Offset: 0x00040B5A
		public decimal Price { get; set; }
	}
}
