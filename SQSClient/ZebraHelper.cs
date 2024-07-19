using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;

namespace SQSClient
{
	// Token: 0x0200003A RID: 58
	public class ZebraHelper
	{
		// Token: 0x06000292 RID: 658 RVA: 0x0004478A File Offset: 0x0004298A
		static ZebraHelper()
		{
			ZebraHelper.InitCompressCode();
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000293 RID: 659 RVA: 0x000447A7 File Offset: 0x000429A7
		// (set) Token: 0x06000294 RID: 660 RVA: 0x000447AE File Offset: 0x000429AE
		public static byte[] GraphBuffer { get; set; }

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000295 RID: 661 RVA: 0x000447B6 File Offset: 0x000429B6
		// (set) Token: 0x06000296 RID: 662 RVA: 0x000447BD File Offset: 0x000429BD
		private static int GraphWidth { get; set; }

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000297 RID: 663 RVA: 0x000447C5 File Offset: 0x000429C5
		// (set) Token: 0x06000298 RID: 664 RVA: 0x000447CC File Offset: 0x000429CC
		private static int GraphHeight { get; set; }

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000299 RID: 665 RVA: 0x000447D4 File Offset: 0x000429D4
		private static int RowSize
		{
			get
			{
				return ZebraHelper.GraphWidth + 31 >> 5 << 2;
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x0600029A RID: 666 RVA: 0x000447F4 File Offset: 0x000429F4
		private static int RowRealBytesCount
		{
			get
			{
				bool flag = ZebraHelper.GraphWidth % 8 > 0;
				int result;
				if (flag)
				{
					result = ZebraHelper.GraphWidth / 8 + 1;
				}
				else
				{
					result = ZebraHelper.GraphWidth / 8;
				}
				return result;
			}
		}

		// Token: 0x0600029B RID: 667 RVA: 0x0004482C File Offset: 0x00042A2C
		public static string BmpToZpl(byte[] bitmap, out int totalBytes, out int rowBytes)
		{
			string result;
			try
			{
				ZebraHelper.GraphBuffer = bitmap;
				byte[] bitmapData = ZebraHelper.getBitmapData();
				string text = BitConverter.ToString(bitmapData).Replace("-", string.Empty);
				string text2 = ZebraHelper.CompressLZ77(text);
				totalBytes = ZebraHelper.GraphHeight * ZebraHelper.RowRealBytesCount;
				rowBytes = ZebraHelper.RowRealBytesCount;
				result = text2;
			}
			catch (Exception ex)
			{
				throw ex;
			}
			return result;
		}

		// Token: 0x0600029C RID: 668 RVA: 0x00044894 File Offset: 0x00042A94
		public static string BmpToZpl(Image bitmap, out int totalBytes, out int rowBytes)
		{
			string result;
			using (MemoryStream memoryStream = new MemoryStream())
			{
				bitmap.Save(memoryStream, ImageFormat.Bmp);
				result = ZebraHelper.BmpToZpl(memoryStream.ToArray(), out totalBytes, out rowBytes);
			}
			return result;
		}

		// Token: 0x0600029D RID: 669 RVA: 0x000448E4 File Offset: 0x00042AE4
		public static string BitmapToHex(Image sourceBmp, out int totalBytes, out int rowBytes)
		{
			Bitmap bitmap = ZebraHelper.ConvertToGrayscale(sourceBmp as Bitmap);
			Rectangle rect = new Rectangle(0, 0, bitmap.Width, bitmap.Height);
			BitmapData bitmapData = bitmap.LockBits(rect, ImageLockMode.ReadWrite, bitmap.PixelFormat);
			IntPtr scan = bitmapData.Scan0;
			int num = (int)Math.Ceiling((double)bitmap.Width / 8.0);
			int num2 = Math.Abs(bitmapData.Stride);
			int num3 = num2 * bitmap.Height;
			byte[] array = new byte[num3];
			Marshal.Copy(scan, array, 0, num3);
			byte b = byte.MaxValue;
			int num4 = 8 - bitmap.Width % 8;
			num4 %= 8;
			b = (byte)(b << (int)((byte)num4));
			for (int i = 0; i < bitmap.Height; i++)
			{
				for (int j = 0; j < num2; j++)
				{
					bool flag = j < num - 1;
					if (flag)
					{
						byte[] array2 = array;
						int num5 = i * num2 + j;
						array2[num5] ^= byte.MaxValue;
					}
					else
					{
						bool flag2 = j == num - 1;
						if (flag2)
						{
							byte[] array3 = array;
							int num6 = i * num2 + j;
							array3[num6] ^= b;
						}
						else
						{
							byte[] array4 = array;
							int num7 = i * num2 + j;
							array4[num7] ^= 0;
						}
					}
				}
			}
			string text = BitConverter.ToString(array);
			text = ZebraHelper.CompressLZ77(text.Replace("-", string.Empty));
			totalBytes = num3;
			rowBytes = num2;
			return text;
		}

		// Token: 0x0600029E RID: 670 RVA: 0x00044A6C File Offset: 0x00042C6C
		private static Bitmap ConvertToGrayscale(Bitmap pimage)
		{
			Bitmap bitmap = null;
			bool flag = pimage.PixelFormat != PixelFormat.Format32bppArgb;
			if (flag)
			{
				bitmap = new Bitmap(pimage.Width, pimage.Height, PixelFormat.Format32bppArgb);
				bitmap.SetResolution(pimage.HorizontalResolution, pimage.VerticalResolution);
				using (Graphics graphics = Graphics.FromImage(bitmap))
				{
					graphics.DrawImageUnscaled(pimage, 0, 0);
				}
			}
			else
			{
				bitmap = pimage;
			}
			BitmapData bitmapData = bitmap.LockBits(new Rectangle(0, 0, bitmap.Width, bitmap.Height), ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
			int num = bitmapData.Stride * bitmapData.Height;
			byte[] array = new byte[num];
			Marshal.Copy(bitmapData.Scan0, array, 0, num);
			bitmap.UnlockBits(bitmapData);
			Bitmap bitmap2 = new Bitmap(bitmap.Width, bitmap.Height, PixelFormat.Format1bppIndexed);
			BitmapData bitmapData2 = bitmap2.LockBits(new Rectangle(0, 0, bitmap2.Width, bitmap2.Height), ImageLockMode.WriteOnly, PixelFormat.Format1bppIndexed);
			num = bitmapData2.Stride * bitmapData2.Height;
			byte[] array2 = new byte[num];
			int height = bitmap.Height;
			int width = bitmap.Width;
			int num2 = 500;
			for (int i = 0; i < height; i++)
			{
				int num3 = i * bitmapData.Stride;
				int num4 = i * bitmapData2.Stride;
				byte b = 0;
				int num5 = 128;
				for (int j = 0; j < width; j++)
				{
					int num6 = (int)(array[num3 + 1] + array[num3 + 2] + array[num3 + 3]);
					bool flag2 = num6 > num2;
					if (flag2)
					{
						b += (byte)num5;
					}
					bool flag3 = num5 == 1;
					if (flag3)
					{
						array2[num4] = b;
						num4++;
						b = 0;
						num5 = 128;
					}
					else
					{
						num5 >>= 1;
					}
					num3 += 4;
				}
				bool flag4 = num5 != 128;
				if (flag4)
				{
					array2[num4] = b;
				}
			}
			Marshal.Copy(array2, 0, bitmapData2.Scan0, num);
			bitmap2.UnlockBits(bitmapData2);
			bool flag5 = bitmap != pimage;
			if (flag5)
			{
				bitmap.Dispose();
			}
			return bitmap2;
		}

		// Token: 0x0600029F RID: 671 RVA: 0x00044CD0 File Offset: 0x00042ED0
		private static byte[] getBitmapData()
		{
			MemoryStream memoryStream = new MemoryStream();
			MemoryStream memoryStream2 = new MemoryStream();
			Bitmap bitmap = null;
			Bitmap bitmap2 = null;
			byte[] array = null;
			try
			{
				memoryStream = new MemoryStream(ZebraHelper.GraphBuffer);
				bitmap = (Image.FromStream(memoryStream) as Bitmap);
				byte[] array2 = memoryStream.ToArray();
				ZebraHelper.GraphWidth = bitmap.Width;
				ZebraHelper.GraphHeight = bitmap.Height;
				bitmap2 = ZebraHelper.ConvertToGrayscale(bitmap);
				bitmap2.Save(memoryStream2, ImageFormat.Bmp);
				byte[] array3 = memoryStream2.ToArray();
				array = array3;
				int num = BitConverter.ToInt32(array3, 10);
				array = new byte[ZebraHelper.GraphHeight * ZebraHelper.RowRealBytesCount];
				for (int i = 0; i < ZebraHelper.GraphHeight; i++)
				{
					int sourceIndex = num + (ZebraHelper.GraphHeight - 1 - i) * ZebraHelper.RowSize;
					int destinationIndex = i * ZebraHelper.RowRealBytesCount;
					Array.Copy(array3, sourceIndex, array, destinationIndex, ZebraHelper.RowRealBytesCount);
				}
				for (int j = 0; j < array.Length; j++)
				{
					byte[] array4 = array;
					int num2 = j;
					array4[num2] ^= byte.MaxValue;
				}
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message, ex);
			}
			finally
			{
				bool flag = memoryStream != null;
				if (flag)
				{
					memoryStream.Dispose();
					memoryStream = null;
				}
				bool flag2 = memoryStream2 != null;
				if (flag2)
				{
					memoryStream2.Dispose();
					memoryStream2 = null;
				}
				bool flag3 = bitmap != null;
				if (flag3)
				{
					bitmap.Dispose();
					bitmap = null;
				}
				bool flag4 = bitmap2 != null;
				if (flag4)
				{
					bitmap2.Dispose();
					bitmap2 = null;
				}
			}
			return array;
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x00044E94 File Offset: 0x00043094
		private static string CompressLZ77(string text)
		{
			string text2 = string.Empty;
			char[] array = text.ToCharArray();
			int num = 1;
			for (int i = 1; i < text.Length; i++)
			{
				bool flag = array[i - 1] == array[i];
				if (flag)
				{
					num++;
				}
				else
				{
					text2 = text2 + ZebraHelper.convertNumber(num) + array[i - 1].ToString();
					num = 1;
				}
				bool flag2 = i == text.Length - 1;
				if (flag2)
				{
					text2 = text2 + ZebraHelper.convertNumber(num) + array[i].ToString();
				}
			}
			return text2;
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x00044F34 File Offset: 0x00043134
		private static string DecompressLZ77(string text)
		{
			string text2 = string.Empty;
			char[] array = text.ToCharArray();
			int num = 0;
			for (int i = 0; i < array.Length; i++)
			{
				bool flag = ZebraHelper.isHexChar(array[i]);
				if (flag)
				{
					text2 += new string(array[i], (num == 0) ? 1 : num);
					num = 0;
				}
				else
				{
					int compressValue = ZebraHelper.GetCompressValue(array[i]);
					num += compressValue;
				}
			}
			return text2;
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x00044FAC File Offset: 0x000431AC
		private static int GetCompressValue(char c)
		{
			int result = 0;
			for (int i = 0; i < ZebraHelper.compressDictionary.Count; i++)
			{
				bool flag = c == ZebraHelper.compressDictionary[i].Key;
				if (flag)
				{
					result = ZebraHelper.compressDictionary[i].Value;
				}
			}
			return result;
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x00045010 File Offset: 0x00043210
		private static bool isHexChar(char c)
		{
			return (c > '/' && c < ':') || (c > '@' && c < 'G') || (c > '`' && c < 'g');
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x00045048 File Offset: 0x00043248
		private static string convertNumber(int count)
		{
			string text = string.Empty;
			bool flag = count > 1;
			if (flag)
			{
				while (count > 0)
				{
					for (int i = ZebraHelper.compressDictionary.Count - 1; i >= 0; i--)
					{
						bool flag2 = count >= ZebraHelper.compressDictionary[i].Value;
						if (flag2)
						{
							text += ZebraHelper.compressDictionary[i].Key.ToString();
							count -= ZebraHelper.compressDictionary[i].Value;
							break;
						}
					}
				}
			}
			return text;
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x00045104 File Offset: 0x00043304
		private static void InitCompressCode()
		{
			for (int i = 0; i < 19; i++)
			{
				ZebraHelper.compressDictionary.Add(new KeyValuePair<char, int>(Convert.ToChar(71 + i), i + 1));
			}
			for (int j = 0; j < 20; j++)
			{
				ZebraHelper.compressDictionary.Add(new KeyValuePair<char, int>(Convert.ToChar(103 + j), (j + 1) * 20));
			}
		}

		// Token: 0x0400044F RID: 1103
		private static object SyncRoot = new object();

		// Token: 0x04000450 RID: 1104
		private static List<KeyValuePair<char, int>> compressDictionary = new List<KeyValuePair<char, int>>();
	}
}
