using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.Editors;

namespace SQSClient
{
	// Token: 0x02000068 RID: 104
	public partial class frmQRCodeShow : BaseDialogForm
	{
		// Token: 0x0600053A RID: 1338 RVA: 0x000845E0 File Offset: 0x000827E0
		public frmQRCodeShow(string batchCode)
		{
			this.InitializeComponent();
			this.mBatchCode = batchCode;
			this.tbxContextParse.Text = this.mBatchCode;
			this.dInputVersion.Value = 5.0;
			this.dInputPixel.Value = 6.0;
			this.dInputSize.Value = 20.0;
			this.dInputBorder.Value = 5.0;
		}

		// Token: 0x0600053B RID: 1339 RVA: 0x000846A6 File Offset: 0x000828A6
		private void btnQRCode_Click(object sender, EventArgs e)
		{
			this.picMatrix.Image = this.ProduceQRcode();
		}

		// Token: 0x0600053C RID: 1340 RVA: 0x000846BC File Offset: 0x000828BC
		private Bitmap ProduceQRcode()
		{
			int version = Convert.ToInt32(this.dInputVersion.Value);
			int pixel = Convert.ToInt32(this.dInputPixel.Value);
			int icon_size = Convert.ToInt32(this.dInputSize.Value);
			int icon_border = Convert.ToInt32(this.dInputBorder.Value);
			string text = this.tbxContextParse.Text;
			bool white_edge = true;
			return QRCodeHelper.code(text, version, pixel, "E:/logo.jpg", icon_size, icon_border, white_edge);
		}

		// Token: 0x0600053D RID: 1341 RVA: 0x0008473A File Offset: 0x0008293A
		private void btnDrawBit_Click(object sender, EventArgs e)
		{
			this.mDrawBitmap = this.DrawBit();
			this.picDrawBit.Image = this.mDrawBitmap;
		}

		// Token: 0x0600053E RID: 1342 RVA: 0x0008475C File Offset: 0x0008295C
		private void btnPrint_Click(object sender, EventArgs e)
		{
			bool flag = this.picMatrix.Image == null;
			if (flag)
			{
				MessageBox.Show("请选择二维码图片");
			}
			else
			{
				PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
				PrintDocument printDocument = new PrintDocument();
				try
				{
				}
				catch
				{
					MessageBox.Show("请输入正确的数字");
				}
				Margins margins = new Margins(this.left, this.left + this.width, this.top, this.top + this.height);
				printDocument.DefaultPageSettings.Margins = margins;
				printDocument.PrintPage += this.PrintPageEvent;
				printPreviewDialog.Document = printDocument;
				printPreviewDialog.ShowDialog();
				try
				{
					printDocument.Print();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, "打印出错", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					printDocument.PrintController.OnEndPrint(printDocument, new PrintEventArgs());
				}
			}
		}

		// Token: 0x0600053F RID: 1343 RVA: 0x0008485C File Offset: 0x00082A5C
		private void btnZebraPrint_Click(object sender, EventArgs e)
		{
			this.SendBitmap(this.mDrawBitmap);
		}

		// Token: 0x06000540 RID: 1344 RVA: 0x0008486C File Offset: 0x00082A6C
		private void PrintPageEvent(object sender, PrintPageEventArgs e)
		{
			Image image = this.ProduceQRcode();
			Rectangle destRect = new Rectangle(this.left, this.top, this.width, this.height);
			e.Graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel);
		}

		// Token: 0x06000541 RID: 1345 RVA: 0x000848C0 File Offset: 0x00082AC0
		public Bitmap DrawBit()
		{
			int num = 700;
			int num2 = 800;
			Bitmap bitmap = new Bitmap(num, num2);
			Graphics graphics = Graphics.FromImage(bitmap);
			Brush brush = new SolidBrush(Color.Black);
			graphics.SmoothingMode = SmoothingMode.AntiAlias;
			graphics.Clear(Color.FromArgb(255, 255, 255));
			Font font = new Font("宋体", 32f, FontStyle.Bold);
			StringFormat stringFormat = new StringFormat();
			stringFormat.Alignment = StringAlignment.Center;
			int num3 = 35;
			int num4 = 70;
			graphics.DrawString("品名：", font, brush, 50f, (float)num3);
			graphics.DrawString("规格：100*100", font, brush, 50f, (float)(num3 + num4));
			graphics.DrawString("等级：优秀", font, brush, 50f, (float)(num3 + num4 * 2));
			graphics.DrawString("检验员：", font, brush, 50f, (float)(num3 + num4 * 3));
			graphics.DrawString("批号：mBatchCode", font, brush, 50f, (float)(num3 + num4 * 4));
			graphics.DrawString("有限公司", font, brush, 50f, (float)(num3 + num4 * 5));
			graphics.DrawImage(this.ProduceQRcode(), 400, num3);
			this.picDrawBit.Image = bitmap;
			return bitmap;
		}

		// Token: 0x06000542 RID: 1346 RVA: 0x00084A14 File Offset: 0x00082C14
		public void SendBitmap(Bitmap bitmap)
		{
			int num = 64800;
			int num2 = 90;
			string text = ZebraHelper.BitmapToHex(bitmap, out num, out num2);
			string str = string.Concat(new string[]
			{
				"~DGR:ZLOGO.GRF,",
				num.ToString(),
				",",
				num2.ToString(),
				",",
				text
			});
			string text2 = "^XA^FO0,0^XGR:ZLOGO.GRF,1,1^FS";
			text2 += "^XZ";
			this.tbxDrawBit.Text = str + text2;
		}

		// Token: 0x0400090C RID: 2316
		private string mBatchCode = string.Empty;

		// Token: 0x0400090D RID: 2317
		private int left = 0;

		// Token: 0x0400090E RID: 2318
		private int top = 0;

		// Token: 0x0400090F RID: 2319
		private int width = 150;

		// Token: 0x04000910 RID: 2320
		private int height = 150;

		// Token: 0x04000911 RID: 2321
		private Bitmap mDrawBitmap = null;
	}
}
