using System;
using DAL.Base.SQSConfig;
using Model.SQSConfig;

namespace SQSClient
{
	// Token: 0x02000037 RID: 55
	public class DanHaoHelper
	{
		// Token: 0x06000287 RID: 647 RVA: 0x000441D4 File Offset: 0x000423D4
		public static DanHaoHelper Instance()
		{
			bool flag = DanHaoHelper.danHaoHelper == null;
			if (flag)
			{
				DanHaoHelper.danHaoHelper = new DanHaoHelper();
			}
			return DanHaoHelper.danHaoHelper;
		}

		// Token: 0x06000288 RID: 648 RVA: 0x00044204 File Offset: 0x00042404
		private bool CheckDanHao(string tblName, string fieldName, string date, ref int iDanHao, ref string danhao)
		{
			bool flag = true;
			while (flag)
			{
				iDanHao++;
				bool flag2 = iDanHao.ToString().Length > this.mDanHaoLength;
				if (flag2)
				{
					return false;
				}
				danhao = date + iDanHao.ToString().PadLeft(this.mDanHaoLength, '0');
				flag = DalT_danhaoindex.Instance.CheckDanHao(tblName, fieldName, danhao);
			}
			return true;
		}

		// Token: 0x06000289 RID: 649 RVA: 0x00044274 File Offset: 0x00042474
		private bool GetDanHaoByIndex(string tblName, string fieldName, string keyCode, ref string DanHao)
		{
			DateTime now = DateTime.Now;
			string date = keyCode + DateTime.Now.ToString("yyMMdd");
			ModT_danhaoindex modelMaxIndex = DalT_danhaoindex.Instance.GetModelMaxIndex(keyCode, now);
			int iDanHaoNum = 0;
			bool flag = modelMaxIndex != null;
			if (flag)
			{
				iDanHaoNum = modelMaxIndex.MaxIndex;
			}
			bool flag2 = !this.CheckDanHao(tblName, fieldName, date, ref iDanHaoNum, ref DanHao);
			bool result;
			if (flag2)
			{
				result = false;
			}
			else
			{
				this.UpdateDanhaoIndex(modelMaxIndex, keyCode, now, iDanHaoNum);
				result = true;
			}
			return result;
		}

		// Token: 0x0600028A RID: 650 RVA: 0x000442F4 File Offset: 0x000424F4
		private void UpdateDanhaoIndex(ModT_danhaoindex modDanhaoIndex, string keyCode, DateTime dtNow, int iDanHaoNum)
		{
			bool flag = modDanhaoIndex == null;
			if (flag)
			{
				modDanhaoIndex = new ModT_danhaoindex();
				modDanhaoIndex.Code = keyCode;
				modDanhaoIndex.DanHaoDate = dtNow;
				modDanhaoIndex.MaxIndex = iDanHaoNum;
				DalT_danhaoindex.Instance.AddNoReturn(modDanhaoIndex);
			}
			else
			{
				modDanhaoIndex.MaxIndex = iDanHaoNum;
				DalT_danhaoindex.Instance.Update(modDanhaoIndex);
			}
		}

		// Token: 0x0600028B RID: 651 RVA: 0x00044354 File Offset: 0x00042554
		public int GetMaxIndex(string keyCode, DateTime dtNow)
		{
			ModT_danhaoindex modelMaxIndex = DalT_danhaoindex.Instance.GetModelMaxIndex(keyCode, dtNow);
			int num = 0;
			bool flag = modelMaxIndex != null;
			if (flag)
			{
				num = modelMaxIndex.MaxIndex;
			}
			num++;
			this.UpdateDanhaoIndex(modelMaxIndex, keyCode, dtNow, num);
			return num;
		}

		// Token: 0x0600028C RID: 652 RVA: 0x00044398 File Offset: 0x00042598
		public string GetDanHao(int type)
		{
			string empty = string.Empty;
			bool flag = false;
			if (type != 1)
			{
				if (type == 4)
				{
					flag = this.GetDanHaoByIndex("t_unionlab", "UnionLabCode", "U", ref empty);
				}
			}
			else
			{
				flag = this.GetDanHaoByIndex("cs_rdrecord", "RdCode", "R", ref empty);
			}
			bool flag2 = !flag;
			string result;
			if (flag2)
			{
				result = "";
			}
			else
			{
				result = empty;
			}
			return result;
		}

		// Token: 0x0400044C RID: 1100
		private static DanHaoHelper danHaoHelper;

		// Token: 0x0400044D RID: 1101
		private readonly int mDanHaoLength = 4;

		// Token: 0x0400044E RID: 1102
		private readonly int mDanHaoAllLength = 14;
	}
}
