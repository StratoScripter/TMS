using System;
using System.Drawing;
using QRCoder;

namespace SQSClient
{
	// Token: 0x02000038 RID: 56
	public static class QRCodeHelper
	{
		// Token: 0x0600028E RID: 654 RVA: 0x00044428 File Offset: 0x00042628
		public static Bitmap code(string msg, int version, int pixel, string icon_path, int icon_size, int icon_border, bool white_edge)
		{
			QRCodeGenerator qrcodeGenerator = new QRCodeGenerator();
			QRCodeData data = qrcodeGenerator.CreateQrCode(msg, QRCodeGenerator.ECCLevel.M, true, true, QRCodeGenerator.EciMode.Utf8, version);
			QRCode qrcode = new QRCode(data);
			Bitmap icon = new Bitmap(icon_path);
			return qrcode.GetGraphic(pixel, Color.Black, Color.White, icon, icon_size, icon_border, white_edge);
		}
	}
}
