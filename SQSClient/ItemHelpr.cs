using System;
using System.Drawing;

namespace SQSClient
{
	// Token: 0x02000040 RID: 64
	public static class ItemHelpr
	{
		// Token: 0x060002E2 RID: 738 RVA: 0x0004AEA0 File Offset: 0x000490A0
		public static Color GetColorByString(string color)
		{
			Color result;
			try
			{
				string[] array = color.Split(new char[]
				{
					','
				});
				bool flag = array.Length >= 3;
				if (flag)
				{
					int red = int.Parse(array[0]);
					int green = int.Parse(array[1]);
					int blue = int.Parse(array[2]);
					result = Color.FromArgb(red, green, blue);
				}
				else
				{
					result = Color.White;
				}
			}
			catch
			{
				result = Color.White;
			}
			return result;
		}

		// Token: 0x060002E3 RID: 739 RVA: 0x0004AF20 File Offset: 0x00049120
		public static string GetStringByColor(Color color)
		{
			return string.Concat(new string[]
			{
				color.R.ToString(),
				",",
				color.G.ToString(),
				",",
				color.B.ToString()
			});
		}
	}
}
