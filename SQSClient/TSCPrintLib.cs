using System;
using System.Runtime.InteropServices;

namespace SQSClient
{
	// Token: 0x02000042 RID: 66
	public class TSCPrintLib
	{
		// Token: 0x060002E9 RID: 745
		[DllImport("TSCLIB.dll")]
		public static extern int about();

		// Token: 0x060002EA RID: 746
		[DllImport("TSCLIB.dll")]
		public static extern int openport(string printername);

		// Token: 0x060002EB RID: 747
		[DllImport("TSCLIB.dll")]
		public static extern int barcode(string x, string y, string type, string height, string readable, string rotation, string narrow, string wide, string code);

		// Token: 0x060002EC RID: 748
		[DllImport("TSCLIB.dll")]
		public static extern int clearbuffer();

		// Token: 0x060002ED RID: 749
		[DllImport("TSCLIB.dll")]
		public static extern int closeport();

		// Token: 0x060002EE RID: 750
		[DllImport("TSCLIB.dll")]
		public static extern int downloadpcx(string filename, string image_name);

		// Token: 0x060002EF RID: 751
		[DllImport("TSCLIB.dll")]
		public static extern int formfeed();

		// Token: 0x060002F0 RID: 752
		[DllImport("TSCLIB.dll")]
		public static extern int nobackfeed();

		// Token: 0x060002F1 RID: 753
		[DllImport("TSCLIB.dll")]
		public static extern int printerfont(string x, string y, string fonttype, string rotation, string xmul, string ymul, string text);

		// Token: 0x060002F2 RID: 754
		[DllImport("TSCLIB.dll")]
		public static extern int printlabel(string set, string copy);

		// Token: 0x060002F3 RID: 755
		[DllImport("TSCLIB.dll")]
		public static extern int sendcommand(string printercommand);

		// Token: 0x060002F4 RID: 756
		[DllImport("TSCLIB.dll")]
		public static extern int setup(string width, string height, string speed, string density, string sensor, string vertical, string offset);

		// Token: 0x060002F5 RID: 757
		[DllImport("TSCLIB.dll")]
		public static extern int windowsfont(int x, int y, int fontheight, int rotation, int fontstyle, int fontunderline, string szFaceName, string content);
	}
}
