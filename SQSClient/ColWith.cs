using System;

namespace SQSClient
{
	// Token: 0x02000079 RID: 121
	public class ColWith
	{
		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060006B0 RID: 1712 RVA: 0x000A429F File Offset: 0x000A249F
		// (set) Token: 0x060006B1 RID: 1713 RVA: 0x000A42A7 File Offset: 0x000A24A7
		public int Id
		{
			get
			{
				return this.id;
			}
			set
			{
				this.id = value;
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060006B2 RID: 1714 RVA: 0x000A42B0 File Offset: 0x000A24B0
		// (set) Token: 0x060006B3 RID: 1715 RVA: 0x000A42B8 File Offset: 0x000A24B8
		public float Width
		{
			get
			{
				return this.width;
			}
			set
			{
				this.width = value;
			}
		}

		// Token: 0x04000B67 RID: 2919
		private int id;

		// Token: 0x04000B68 RID: 2920
		private float width;
	}
}
