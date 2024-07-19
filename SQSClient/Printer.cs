using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;

namespace SQSClient
{
	// Token: 0x02000041 RID: 65
	public class Printer
	{
		// Token: 0x060002E4 RID: 740 RVA: 0x0004AF84 File Offset: 0x00049184
		public void Print(string printername)
		{
			PrintDocument printDocument = new PrintDocument();
			printDocument.BeginPrint += this.docToPrint_BeginPrint;
			printDocument.EndPrint += this.docToPrint_EndPrint;
			printDocument.PrintPage += this.docToPrint_PrintPage;
			printDocument.DefaultPageSettings.Landscape = false;
			printDocument.PrinterSettings.PrinterName = printername;
			printDocument.Print();
		}

		// Token: 0x060002E5 RID: 741 RVA: 0x00003040 File Offset: 0x00001240
		private void docToPrint_BeginPrint(object sender, PrintEventArgs e)
		{
		}

		// Token: 0x060002E6 RID: 742 RVA: 0x00003040 File Offset: 0x00001240
		private void docToPrint_EndPrint(object sender, PrintEventArgs e)
		{
		}

		// Token: 0x060002E7 RID: 743 RVA: 0x0004AFF4 File Offset: 0x000491F4
		private void docToPrint_PrintPage(object sender, PrintPageEventArgs e)
		{
			e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
			Image image = this.List[this.printNum];
			bool flag = image == null;
			if (flag)
			{
				bool flag2 = this.printNum < this.List.Count - 1;
				if (flag2)
				{
					this.printNum++;
					e.HasMorePages = true;
				}
				else
				{
					e.HasMorePages = false;
				}
			}
			else
			{
				int x = e.MarginBounds.X;
				int y = e.MarginBounds.Y;
				int num = image.Width;
				int num2 = image.Height;
				bool flag3 = num / e.MarginBounds.Width > num2 / e.MarginBounds.Height;
				if (flag3)
				{
					num = e.MarginBounds.Width;
					num2 = image.Height * e.MarginBounds.Width / image.Width;
				}
				else
				{
					num2 = e.MarginBounds.Height;
					num = image.Width * e.MarginBounds.Height / image.Height;
				}
				bool flag4 = image.Height < 310;
				if (flag4)
				{
					e.Graphics.DrawImage(image, 0, 30, image.Width + 20, image.Height);
				}
				else
				{
					e.Graphics.DrawImage(image, 0, 0, image.Width + 20, image.Height);
				}
				bool flag5 = this.printNum < this.List.Count - 1;
				if (flag5)
				{
					this.printNum++;
					e.HasMorePages = true;
				}
				else
				{
					e.HasMorePages = false;
				}
			}
		}

		// Token: 0x040004B2 RID: 1202
		private int printNum = 0;

		// Token: 0x040004B3 RID: 1203
		public List<Image> List = new List<Image>();
	}
}
