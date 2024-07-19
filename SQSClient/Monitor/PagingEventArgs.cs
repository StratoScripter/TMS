using System;

namespace SQSClient.Monitor
{
	// Token: 0x020000A7 RID: 167
	public class PagingEventArgs : EventArgs
	{
		// Token: 0x170000AA RID: 170
		// (get) Token: 0x06000986 RID: 2438 RVA: 0x000DE97B File Offset: 0x000DCB7B
		// (set) Token: 0x06000987 RID: 2439 RVA: 0x000DE983 File Offset: 0x000DCB83
		public int NumOfPage
		{
			get
			{
				return this._numOfPage;
			}
			set
			{
				this._numOfPage = value;
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x06000988 RID: 2440 RVA: 0x000DE98C File Offset: 0x000DCB8C
		// (set) Token: 0x06000989 RID: 2441 RVA: 0x000DE994 File Offset: 0x000DCB94
		public int CurrentPage
		{
			get
			{
				return this._currentPage;
			}
			set
			{
				this._currentPage = value;
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x0600098A RID: 2442 RVA: 0x000DE99D File Offset: 0x000DCB9D
		// (set) Token: 0x0600098B RID: 2443 RVA: 0x000DE9A5 File Offset: 0x000DCBA5
		public int TotalPage
		{
			get
			{
				return this._totalPage;
			}
			set
			{
				this._totalPage = value;
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x0600098C RID: 2444 RVA: 0x000DE9AE File Offset: 0x000DCBAE
		// (set) Token: 0x0600098D RID: 2445 RVA: 0x000DE9B6 File Offset: 0x000DCBB6
		public int Total
		{
			get
			{
				return this._total;
			}
			set
			{
				this._total = value;
			}
		}

		// Token: 0x04000F8E RID: 3982
		private int _numOfPage;

		// Token: 0x04000F8F RID: 3983
		private int _currentPage;

		// Token: 0x04000F90 RID: 3984
		private int _totalPage;

		// Token: 0x04000F91 RID: 3985
		private int _total;
	}
}
