using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using DevComponents.Editors;

namespace SQSClient
{
	// Token: 0x02000078 RID: 120
	public partial class frmPrintView : OfficeForm
	{
		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000683 RID: 1667 RVA: 0x000A1A48 File Offset: 0x0009FC48
		// (set) Token: 0x06000684 RID: 1668 RVA: 0x000A1A60 File Offset: 0x0009FC60
		public PrintDocument Document
		{
			get
			{
				return this.mDocument;
			}
			set
			{
				this.mDocument = value;
				this.printPreviewControl.Document = this.mDocument;
				this.printPreviewControl.Document.PrintController = new StandardPrintController();
				this.printPreviewControl.StartPageChanged += this.printPreviewControl_StartPageChanged;
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000685 RID: 1669 RVA: 0x000A1AB8 File Offset: 0x0009FCB8
		// (set) Token: 0x06000686 RID: 1670 RVA: 0x000A1AE8 File Offset: 0x0009FCE8
		public PageSetupDialog PageSetupDialog
		{
			get
			{
				bool flag = this.mPageSetupDialog == null;
				if (flag)
				{
					this.mPageSetupDialog = new PageSetupDialog();
				}
				return this.mPageSetupDialog;
			}
			set
			{
				this.mPageSetupDialog = value;
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000687 RID: 1671 RVA: 0x000A1AF4 File Offset: 0x0009FCF4
		// (set) Token: 0x06000688 RID: 1672 RVA: 0x000A1B24 File Offset: 0x0009FD24
		public PrintDialog PrintDialog
		{
			get
			{
				bool flag = this.mPrintDialog == null;
				if (flag)
				{
					this.mPrintDialog = new PrintDialog();
				}
				return this.mPrintDialog;
			}
			set
			{
				this.mPrintDialog = value;
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000689 RID: 1673 RVA: 0x000A1B30 File Offset: 0x0009FD30
		// (set) Token: 0x0600068A RID: 1674 RVA: 0x000A1B48 File Offset: 0x0009FD48
		public bool ShowPrinterSettingsButton
		{
			get
			{
				return this.mShowPrinterSettingsButton;
			}
			set
			{
				this.mShowPrinterSettingsButton = value;
				this.tsBtnPrinterSettings.Visible = value;
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x0600068B RID: 1675 RVA: 0x000A1B60 File Offset: 0x0009FD60
		// (set) Token: 0x0600068C RID: 1676 RVA: 0x000A1B78 File Offset: 0x0009FD78
		public bool ShowPageSettingsButton
		{
			get
			{
				return this.mShowPageSettingsButton;
			}
			set
			{
				this.mShowPageSettingsButton = value;
				this.tsBtnPageSettings.Visible = value;
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x0600068D RID: 1677 RVA: 0x000A1B90 File Offset: 0x0009FD90
		// (set) Token: 0x0600068E RID: 1678 RVA: 0x000A1BA8 File Offset: 0x0009FDA8
		public bool ShowPrinterSettingsBeforePrint
		{
			get
			{
				return this.mShowPrinterSettingsBeforePrint;
			}
			set
			{
				this.mShowPrinterSettingsBeforePrint = value;
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x0600068F RID: 1679 RVA: 0x000A1BB4 File Offset: 0x0009FDB4
		public PrintPreviewControl PrintPreviewControl
		{
			get
			{
				return this.printPreviewControl;
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000690 RID: 1680 RVA: 0x000A1BCC File Offset: 0x0009FDCC
		// (set) Token: 0x06000691 RID: 1681 RVA: 0x000A1BE9 File Offset: 0x0009FDE9
		public bool UseAntiAlias
		{
			get
			{
				return this.printPreviewControl.UseAntiAlias;
			}
			set
			{
				this.printPreviewControl.UseAntiAlias = value;
			}
		}

		// Token: 0x06000692 RID: 1682 RVA: 0x000A1BFC File Offset: 0x0009FDFC
		public frmPrintView()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000693 RID: 1683 RVA: 0x000A1C94 File Offset: 0x0009FE94
		public frmPrintView(DataGridView gv, string HeaderText, string time)
		{
			this.InitializeComponent();
			this.InitCtrl();
			this._gv = gv;
			this._headerText = HeaderText;
			this._time = time;
			this._printFont = this._gv.Font;
			this.mDocument = new PrintDocument();
			this.SwitchPrintDocumentHandlers(this.mDocument, true);
			this.GetWidth();
			bool flag = this.RowWidth > 600f;
			if (flag)
			{
				this.mDocument.DefaultPageSettings.Landscape = true;
			}
			else
			{
				this.mDocument.DefaultPageSettings.Landscape = false;
			}
			this.mPageSetupDialog = new PageSetupDialog();
			this.mPageSetupDialog.Document = this.mDocument;
			this.Document = this.mDocument;
		}

		// Token: 0x06000694 RID: 1684 RVA: 0x000A1DE0 File Offset: 0x0009FFE0
		private void InitCtrl()
		{
			this.ShowPrinterSettingsButton = false;
			this.ShowPageSettingsButton = false;
			this.ShowPrinterSettingsBeforePrint = true;
			this.PrintPreviewControl.Zoom = 1.0;
			base.WindowState = FormWindowState.Maximized;
			base.FormBorderStyle = FormBorderStyle.FixedSingle;
			this.Text = "打印预览";
			this.pages1.Text = "一页";
			this.pages2.Text = "二页";
			this.pages4.Text = "四页";
			this.pages6.Text = "六页";
			this.pages8.Text = "八页";
			this.tsBtnPrint.Tooltip = "打印";
			this.tsBtnPrinterSettings.Tooltip = "打印设置";
			this.tsDDownPages.Tooltip = "页面显示";
			this.tsBtnZoom.Tooltip = "缩放还原";
			this.tsBtnPrev.Tooltip = "前一页";
			this.tsBtnNext.Tooltip = "后一页";
			this.tsComboZoom.SelectedIndex = 5;
		}

		// Token: 0x06000695 RID: 1685 RVA: 0x000A1F00 File Offset: 0x000A0100
		private void SwitchPrintDocumentHandlers(PrintDocument Document, bool Attach)
		{
			bool flag = Document == null;
			if (!flag)
			{
				if (Attach)
				{
					this.mDocument.BeginPrint += this.mDocument_BeginPrint;
					this.mDocument.PrintPage += this.mDocument_PrintPage;
					this.mDocument.EndPrint += this.mDocument_EndPrint;
				}
				else
				{
					this.mDocument.BeginPrint -= this.mDocument_BeginPrint;
					this.mDocument.PrintPage -= this.mDocument_PrintPage;
					this.mDocument.EndPrint -= this.mDocument_EndPrint;
				}
			}
		}

		// Token: 0x06000696 RID: 1686 RVA: 0x00003040 File Offset: 0x00001240
		private void EnhancedPrintPreviewDialog_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x06000697 RID: 1687 RVA: 0x000A1FB8 File Offset: 0x000A01B8
		public void Print()
		{
			try
			{
				base.Visible = false;
				base.ShowDialog();
			}
			catch (Exception ex)
			{
				throw new Exception("printer error." + ex.Message);
			}
		}

		// Token: 0x06000698 RID: 1688 RVA: 0x000A2004 File Offset: 0x000A0204
		private void mDocument_BeginPrint(object sender, PrintEventArgs e)
		{
			this.mTotalPages = 0;
			this._currentPageIndex = 0;
			this._lastPageRowIndex = 0;
			this._prinRowCount = 1;
		}

		// Token: 0x06000699 RID: 1689 RVA: 0x000A2023 File Offset: 0x000A0223
		private void mDocument_EndPrint(object sender, PrintEventArgs e)
		{
			this.tsLblTotalPages.Text = " / " + this.mTotalPages.ToString();
		}

		// Token: 0x0600069A RID: 1690 RVA: 0x000A2048 File Offset: 0x000A0248
		private void mDocument_PrintPage(object sender, PrintPageEventArgs e)
		{
			this.mTotalPages++;
			this._printY = (float)e.MarginBounds.Top;
			this.ColWidth = e.Graphics.MeasureString("a", this._printFont).Width + 0.6f;
			this.ColHeight = e.Graphics.MeasureString("a", this._printFont).Height;
			bool flag = !this._colWidthFinished;
			if (flag)
			{
				this.AdjustWidth(e, this.RowWidth);
				this._colWidthFinished = true;
			}
			this._currentPageIndex++;
			bool flag2 = this._currentPageIndex == 1;
			if (flag2)
			{
				this._printY = this.DataGridViewPrinter_OnPrintHeader(e);
				this._printY += this.ColHeight;
			}
			bool flag3 = this._gv.Rows.Count > 0;
			if (flag3)
			{
				this.printGridView(e);
			}
			this.DataGridViewPrinter_OnPrintFooter(e);
			bool cancel = e.Cancel;
			if (cancel)
			{
				this._currentPageIndex = 0;
				this._lastPageRowIndex = 0;
				this._colCountPrint = 0;
				this._colWidthFinished = false;
				this._prinRowCount = 1;
			}
		}

		// Token: 0x0600069B RID: 1691 RVA: 0x000A2184 File Offset: 0x000A0384
		public void AddDesc(ColWith mod)
		{
			ColWith colWith = this.colWiths.Find((ColWith c) => c.Id.Equals(mod.Id));
			bool flag = colWith != null;
			if (flag)
			{
				bool flag2 = colWith.Width < mod.Width;
				if (!flag2)
				{
					return;
				}
				this.colWiths.Remove(colWith);
			}
			int num = this.colWiths.FindIndex((ColWith c) => c.Width < mod.Width);
			bool flag3 = num < 0;
			if (flag3)
			{
				this.colWiths.Add(mod);
			}
			else
			{
				this.colWiths.Insert(num, mod);
			}
		}

		// Token: 0x0600069C RID: 1692 RVA: 0x000A2238 File Offset: 0x000A0438
		public float GetWidth()
		{
			Graphics graphics = base.CreateGraphics();
			this._colCountPrint = 0;
			this._colWidthList.Clear();
			for (int i = 0; i < this._gv.Columns.Count; i++)
			{
				bool visible = this._gv.Columns[i].Visible;
				if (visible)
				{
					this._colCountPrint++;
					string headerText = this._gv.Columns[i].HeaderText;
					float num = this.ColWidth;
					bool flag = headerText != "";
					if (flag)
					{
						num = graphics.MeasureString(headerText, this._printFont).Width + 0.385f * (float)headerText.ToString().Length;
					}
					this._colWidthList.Add(i, num);
					this.AddDesc(new ColWith
					{
						Id = i,
						Width = num
					});
				}
			}
			DataGridViewRow dataGridViewRow = this._gv.Rows[0];
			for (int j = 0; j < this._gv.Columns.Count; j++)
			{
				bool visible2 = this._gv.Columns[j].Visible;
				if (visible2)
				{
					float num = this.ColWidth;
					object value = dataGridViewRow.Cells[j].Value;
					bool flag2 = value != null;
					if (flag2)
					{
						num = graphics.MeasureString(value.ToString(), this._printFont).Width + 0.385f * (float)value.ToString().Length;
					}
					bool flag3 = this._colWidthList.ContainsKey(j);
					if (flag3)
					{
						bool flag4 = num > this._colWidthList[j];
						if (flag4)
						{
							this._colWidthList[j] = num;
							this.AddDesc(new ColWith
							{
								Id = j,
								Width = num
							});
						}
					}
					this.RowWidth += this._colWidthList[j];
				}
			}
			return this.RowWidth;
		}

		// Token: 0x0600069D RID: 1693 RVA: 0x000A2480 File Offset: 0x000A0680
		private void AdjustWidth(PrintPageEventArgs e, float rowWidth)
		{
			float num = (float)e.MarginBounds.Width - rowWidth;
			bool flag = num < 0f;
			if (flag)
			{
				this._printX = (float)e.MarginBounds.Left + num / 2f;
				bool flag2 = this._printX < 50f;
				if (flag2)
				{
					this._printX = 50f;
					num += ((float)e.MarginBounds.Left - this._printX) * 2f;
					foreach (ColWith colWith in this.colWiths)
					{
						bool visible = this._gv.Columns[colWith.Id].Visible;
						if (visible)
						{
							bool flag3 = this._colWidthList.ContainsKey(colWith.Id);
							if (flag3)
							{
								float num2 = (colWith.Width + this.ColWidth) / 2f;
								bool flag4 = num + num2 >= 0f;
								if (flag4)
								{
									num2 = -num;
								}
								Dictionary<int, float> colWidthList = this._colWidthList;
								int key = colWith.Id;
								colWidthList[key] -= num2;
								num += num2;
								bool flag5 = num >= 0f;
								if (flag5)
								{
									break;
								}
							}
						}
					}
				}
			}
			else
			{
				float num3 = num / (float)this._colCountPrint;
				for (int i = 0; i < this._gv.Columns.Count; i++)
				{
					bool visible2 = this._gv.Columns[i].Visible;
					if (visible2)
					{
						bool flag6 = this._colWidthList.ContainsKey(i);
						if (flag6)
						{
							Dictionary<int, float> colWidthList = this._colWidthList;
							int key = i;
							colWidthList[key] += num3;
						}
					}
				}
				this._printX = (float)e.MarginBounds.Left;
			}
		}

		// Token: 0x0600069E RID: 1694 RVA: 0x000A26B0 File Offset: 0x000A08B0
		private float DataGridViewPrinter_OnPrintHeader(PrintPageEventArgs e)
		{
			Font font = new Font(this._printFont.FontFamily, this._printFont.Size + 2f, FontStyle.Bold);
			string headerText = this._headerText;
			float num = (float)e.MarginBounds.Top;
			e.Graphics.DrawString(headerText, font, Brushes.Black, (float)e.MarginBounds.Left + ((float)e.MarginBounds.Width - e.Graphics.MeasureString(headerText, font).Width) * 0.5f, num);
			Font font2 = new Font("Arial", 9f);
			string time = this._time;
			float height = e.Graphics.MeasureString(time, font2).Height;
			float num2 = (float)(e.MarginBounds.Width / 2);
			int num3 = 3;
			num += height * (float)num3;
			e.Graphics.DrawString(time, font2, Brushes.Black, (float)e.MarginBounds.Right - e.Graphics.MeasureString(time, font2).Width, num);
			return num;
		}

		// Token: 0x0600069F RID: 1695 RVA: 0x000A27E0 File Offset: 0x000A09E0
		private float DataGridViewPrinter_OnPrintFooter(PrintPageEventArgs e)
		{
			Font printFont = this._printFont;
			string text = this._currentPageIndex.ToString();
			float num = (float)e.MarginBounds.Bottom + e.Graphics.MeasureString(text, printFont).Height;
			e.Graphics.DrawString(text, printFont, Brushes.Black, (float)e.MarginBounds.Left + ((float)e.MarginBounds.Width - e.Graphics.MeasureString(text, printFont).Width) * 0.5f, num);
			return num;
		}

		// Token: 0x060006A0 RID: 1696 RVA: 0x000A2880 File Offset: 0x000A0A80
		private float printer_OnPrintHeader(PrintPageEventArgs e)
		{
			Font font = new Font("Arial", 9f);
			string text = "a";
			float height = e.Graphics.MeasureString(text, font).Height;
			float num = (float)e.MarginBounds.Top - height;
			e.Graphics.DrawString(text, font, Brushes.Black, (float)e.MarginBounds.Right - e.Graphics.MeasureString(text, font).Width, num);
			return num;
		}

		// Token: 0x060006A1 RID: 1697 RVA: 0x000A2910 File Offset: 0x000A0B10
		private void printGridView(PrintPageEventArgs e)
		{
			bool flag = this._printY + this.ColHeight >= (float)e.MarginBounds.Bottom;
			if (flag)
			{
				e.HasMorePages = true;
			}
			else
			{
				Font printFont = this._printFont;
				Font printFont2 = this._printFont;
				float printX = this._printX;
				float printY = this._printY;
				this.PrintHeader(e, printFont, printX, ref printY);
				this.PrintBody(e, printFont2, printX, ref printY);
			}
		}

		// Token: 0x060006A2 RID: 1698 RVA: 0x000A2988 File Offset: 0x000A0B88
		private void PrintHeader(PrintPageEventArgs e, Font printFont, float X, ref float Y)
		{
			int num = 1;
			float num2 = this.ColHeight;
			foreach (object obj in this._gv.Columns)
			{
				DataGridViewColumn dataGridViewColumn = (DataGridViewColumn)obj;
				bool flag = !dataGridViewColumn.Visible;
				if (!flag)
				{
					string text = dataGridViewColumn.HeaderText;
					float width = e.Graphics.MeasureString(text, printFont).Width;
					bool flag2 = width > this._colWidthList[dataGridViewColumn.Index];
					if (flag2)
					{
						float num3 = Y;
						int num4 = 0;
						int num5 = (int)Math.Floor((double)(this._colWidthList[dataGridViewColumn.Index] / this.ColWidth));
						bool flag3 = num5 == 0;
						if (flag3)
						{
							num5 = 1;
						}
						while (text.Length > 0)
						{
							num4++;
							string text2 = text.Substring(0, (num5 > text.Length) ? text.Length : num5);
							bool flag4 = e.Graphics.MeasureString(text2, printFont).Width > this._colWidthList[dataGridViewColumn.Index];
							if (flag4)
							{
								text2 = text.Substring(0, ((num5 > text.Length) ? text.Length : num5) - 1);
							}
							e.Graphics.DrawString(text2, printFont, Brushes.Black, X, num3);
							text = text.Substring(text2.Length);
							num3 += this.ColHeight;
						}
						bool flag5 = num4 > num;
						if (flag5)
						{
							num = num4;
						}
					}
					else
					{
						e.Graphics.DrawString(text, printFont, Brushes.Black, X, Y);
					}
					X += this._colWidthList[dataGridViewColumn.Index];
				}
			}
			num2 = this.ColHeight * (float)num;
			X = this._printX;
			foreach (object obj2 in this._gv.Columns)
			{
				DataGridViewColumn dataGridViewColumn2 = (DataGridViewColumn)obj2;
				bool flag6 = !dataGridViewColumn2.Visible;
				if (!flag6)
				{
					e.Graphics.DrawRectangle(new Pen(Brushes.Black), X, Y - 2f, this._colWidthList[dataGridViewColumn2.Index], num2);
					X += this._colWidthList[dataGridViewColumn2.Index];
				}
			}
			Y += num2;
		}

		// Token: 0x060006A3 RID: 1699 RVA: 0x000A2C64 File Offset: 0x000A0E64
		private void PrintBody(PrintPageEventArgs e, Font printFont, float X, ref float Y)
		{
			for (int i = this._lastPageRowIndex; i < this._gv.Rows.Count; i++)
			{
				float num = this.ColHeight;
				int num2 = 1;
				foreach (object obj in this._gv.Columns)
				{
					DataGridViewColumn dataGridViewColumn = (DataGridViewColumn)obj;
					bool flag = !dataGridViewColumn.Visible;
					if (!flag)
					{
						DataGridViewRow dataGridViewRow = this._gv.Rows[i];
						bool isNewRow = dataGridViewRow.IsNewRow;
						if (!isNewRow)
						{
							bool flag2 = dataGridViewColumn is DataGridViewCheckBoxColumn;
							string text;
							if (flag2)
							{
								text = "";
							}
							else
							{
								text = ((dataGridViewRow.Cells[dataGridViewColumn.Index].Value == null) ? "" : dataGridViewRow.Cells[dataGridViewColumn.Index].Value.ToString());
							}
							float width = e.Graphics.MeasureString(text, printFont).Width;
							bool flag3 = width > this._colWidthList[dataGridViewColumn.Index];
							if (flag3)
							{
								float num3 = Y;
								int num4 = 0;
								int num5 = (int)Math.Floor((double)(this._colWidthList[dataGridViewColumn.Index] / this.ColWidth));
								while (text.Length > 0)
								{
									num4++;
									string text2 = text.Substring(0, (num5 > text.Length) ? text.Length : num5);
									bool flag4 = e.Graphics.MeasureString(text2, printFont).Width > this._colWidthList[dataGridViewColumn.Index];
									if (flag4)
									{
										text2 = text.Substring(0, ((num5 > text.Length) ? text.Length : num5) - 1);
									}
									bool flag5 = Y + this.ColHeight > (float)e.MarginBounds.Bottom;
									if (flag5)
									{
										e.HasMorePages = true;
										this._lastPageRowIndex = i;
										return;
									}
									e.Graphics.DrawString(text2, printFont, Brushes.Black, X, num3);
									text = text.Substring(text2.Length);
									num3 += this.ColHeight;
								}
								bool flag6 = num4 > num2;
								if (flag6)
								{
									num2 = num4;
								}
								X += this._colWidthList[dataGridViewColumn.Index];
							}
							else
							{
								bool flag7 = Y + this.ColHeight > (float)e.MarginBounds.Bottom;
								if (flag7)
								{
									e.HasMorePages = true;
									this._lastPageRowIndex = i;
									return;
								}
								e.Graphics.DrawString(text, printFont, Brushes.Black, X, Y);
								X += this._colWidthList[dataGridViewColumn.Index];
							}
						}
					}
				}
				num = this.ColHeight * (float)num2;
				X = this._printX;
				foreach (object obj2 in this._gv.Columns)
				{
					DataGridViewColumn dataGridViewColumn2 = (DataGridViewColumn)obj2;
					bool flag8 = !dataGridViewColumn2.Visible;
					if (!flag8)
					{
						e.Graphics.DrawRectangle(new Pen(Brushes.Black), X, Y - 2f, this._colWidthList[dataGridViewColumn2.Index], num);
						X += this._colWidthList[dataGridViewColumn2.Index];
					}
				}
				X = this._printX;
				Y += num;
				this._prinRowCount++;
			}
		}

		// Token: 0x060006A4 RID: 1700 RVA: 0x000A3074 File Offset: 0x000A1274
		private void tsTxtCurrentPage_TextChanged(object sender, EventArgs e)
		{
			int num;
			bool flag = int.TryParse(this.tsTxtCurrentPage.Text, out num);
			if (flag)
			{
				try
				{
					num--;
					bool flag2 = num < 0;
					if (flag2)
					{
						num = 0;
					}
					bool flag3 = num > this.mTotalPages - 1;
					if (flag3)
					{
						num = this.mTotalPages - this.mVisibilePages;
					}
					this.printPreviewControl.StartPage = num;
				}
				catch
				{
				}
			}
		}

		// Token: 0x060006A5 RID: 1701 RVA: 0x000A30EC File Offset: 0x000A12EC
		private void NumOfPages_Click(object sender, EventArgs e)
		{
			ButtonItem buttonItem = (ButtonItem)sender;
			this.tsDDownPages.Image = buttonItem.Image;
			this.mVisibilePages = int.Parse((string)buttonItem.Tag);
			switch (this.mVisibilePages)
			{
			case 1:
				this.printPreviewControl.Rows = 1;
				this.printPreviewControl.Columns = 1;
				break;
			case 2:
				this.printPreviewControl.Rows = 1;
				this.printPreviewControl.Columns = 2;
				break;
			case 4:
				this.printPreviewControl.Rows = 2;
				this.printPreviewControl.Columns = 2;
				break;
			case 6:
				this.printPreviewControl.Rows = 2;
				this.printPreviewControl.Columns = 3;
				break;
			case 8:
				this.printPreviewControl.Rows = 2;
				this.printPreviewControl.Columns = 4;
				break;
			}
			this.tsBtnZoom_Click(null, null);
		}

		// Token: 0x060006A6 RID: 1702 RVA: 0x000A31F4 File Offset: 0x000A13F4
		private void Navigate_Click(object sender, EventArgs e)
		{
			ButtonItem buttonItem = (ButtonItem)sender;
			int num = this.printPreviewControl.StartPage;
			try
			{
				bool flag = buttonItem.Name == "tsBtnNext";
				if (flag)
				{
					num += this.mVisibilePages;
				}
				else
				{
					num -= this.mVisibilePages;
				}
				bool flag2 = num < 0;
				if (flag2)
				{
					num = 0;
				}
				bool flag3 = num > this.mTotalPages - 1;
				if (flag3)
				{
					num = this.mTotalPages - this.mVisibilePages;
				}
				this.printPreviewControl.StartPage = num;
			}
			catch
			{
			}
		}

		// Token: 0x060006A7 RID: 1703 RVA: 0x000A3290 File Offset: 0x000A1490
		private void printPreviewControl_StartPageChanged(object sender, EventArgs e)
		{
			int num = this.printPreviewControl.StartPage + 1;
			this.tsTxtCurrentPage.Text = num.ToString();
		}

		// Token: 0x060006A8 RID: 1704 RVA: 0x000A32C0 File Offset: 0x000A14C0
		private void tsComboZoom_Leave(object sender, EventArgs e)
		{
			bool flag = this.tsComboZoom.SelectedIndex == 0;
			if (flag)
			{
				this.printPreviewControl.AutoZoom = true;
			}
			else
			{
				string s = this.tsComboZoom.Text.Replace("%", "");
				double num;
				bool flag2 = double.TryParse(s, out num);
				if (flag2)
				{
					try
					{
						this.printPreviewControl.Zoom = num / 100.0;
					}
					catch
					{
					}
					num = this.printPreviewControl.Zoom * 100.0;
					this.tsComboZoom.Text = num.ToString() + "%";
				}
			}
		}

		// Token: 0x060006A9 RID: 1705 RVA: 0x000A337C File Offset: 0x000A157C
		private void tsBtnZoom_Click(object sender, EventArgs e)
		{
			this.tsComboZoom.SelectedIndex = 0;
			this.tsComboZoom_Leave(null, null);
		}

		// Token: 0x060006AA RID: 1706 RVA: 0x000A3398 File Offset: 0x000A1598
		private void tsComboZoom_KeyPress(object sender, KeyPressEventArgs e)
		{
			bool flag = e.KeyChar == '\r';
			if (flag)
			{
				this.tsComboZoom_Leave(null, null);
			}
		}

		// Token: 0x060006AB RID: 1707 RVA: 0x000A33C0 File Offset: 0x000A15C0
		private void tsBtnPrint_Click(object sender, EventArgs e)
		{
			try
			{
				this.mPrintDialog = new PrintDialog();
				this.mPrintDialog.Document = this.mDocument;
				this.mPrintDialog.AllowSomePages = false;
				this.mPrintDialog.AllowSelection = false;
				this.mPrintDialog.PrinterSettings.FromPage = 1;
				this.mPrintDialog.PrinterSettings.ToPage = this.mTotalPages;
				bool flag = this.mShowPrinterSettingsBeforePrint;
				if (flag)
				{
					bool flag2 = this.mPrintDialog.ShowDialog() == DialogResult.OK;
					if (flag2)
					{
						try
						{
							bool flag3 = this.mPrintDialog.PrinterSettings.FromPage > this.mTotalPages;
							if (flag3)
							{
								this.mPrintDialog.PrinterSettings.FromPage = 1;
							}
							for (int i = 0; i < (int)this.mPrintDialog.PrinterSettings.Copies; i++)
							{
								this.mDocument.Print();
							}
						}
						catch
						{
						}
						base.Dispose();
						base.Close();
					}
				}
				else
				{
					try
					{
						for (int j = 0; j < (int)this.mPrintDialog.PrinterSettings.Copies; j++)
						{
							this.mDocument.Print();
						}
					}
					catch
					{
					}
					base.Dispose();
					base.Close();
				}
			}
			catch
			{
				MessageBox.Show("Print Fail");
			}
		}

		// Token: 0x060006AC RID: 1708 RVA: 0x000A3578 File Offset: 0x000A1778
		private void tsBtnPageSettings_Click(object sender, EventArgs e)
		{
			this.mPageSetupDialog.Document = this.mDocument;
			bool flag = this.mPageSetupDialog.ShowDialog() == DialogResult.OK;
			if (flag)
			{
				this.printPreviewControl.Invalidate();
			}
		}

		// Token: 0x060006AD RID: 1709 RVA: 0x000A35B8 File Offset: 0x000A17B8
		private void tsBtnPrinterSettings_Click(object sender, EventArgs e)
		{
			this.mPrintDialog = new PrintDialog();
			this.mPrintDialog.Document = this.mDocument;
			this.mPrintDialog.AllowSomePages = false;
			this.mPrintDialog.AllowSelection = false;
			this.mPrintDialog.ShowDialog();
		}

		// Token: 0x04000B2B RID: 2859
		public float RowWidth = 0f;

		// Token: 0x04000B2C RID: 2860
		private int mVisibilePages = 1;

		// Token: 0x04000B2D RID: 2861
		private int mTotalPages = 0;

		// Token: 0x04000B2E RID: 2862
		private DataGridView _gv;

		// Token: 0x04000B2F RID: 2863
		private string _headerText;

		// Token: 0x04000B30 RID: 2864
		private string _time;

		// Token: 0x04000B31 RID: 2865
		private Font _printFont;

		// Token: 0x04000B32 RID: 2866
		private float _printX;

		// Token: 0x04000B33 RID: 2867
		private float _printY;

		// Token: 0x04000B34 RID: 2868
		private float ColWidth;

		// Token: 0x04000B35 RID: 2869
		private float ColHeight;

		// Token: 0x04000B36 RID: 2870
		private int _currentPageIndex = 0;

		// Token: 0x04000B37 RID: 2871
		private int _prinRowCount = 1;

		// Token: 0x04000B38 RID: 2872
		private int _lastPageRowIndex = 0;

		// Token: 0x04000B39 RID: 2873
		private int _colCountPrint = 0;

		// Token: 0x04000B3A RID: 2874
		private Dictionary<int, float> _colWidthList = new Dictionary<int, float>();

		// Token: 0x04000B3B RID: 2875
		private bool _colWidthFinished = false;

		// Token: 0x04000B3C RID: 2876
		private int FromPage = 0;

		// Token: 0x04000B3D RID: 2877
		private int ToPage = 0;

		// Token: 0x04000B3E RID: 2878
		private PrintDocument mDocument;

		// Token: 0x04000B3F RID: 2879
		private PageSetupDialog mPageSetupDialog;

		// Token: 0x04000B40 RID: 2880
		private PrintDialog mPrintDialog;

		// Token: 0x04000B41 RID: 2881
		private bool mShowPrinterSettingsButton = false;

		// Token: 0x04000B42 RID: 2882
		private bool mShowPageSettingsButton = true;

		// Token: 0x04000B43 RID: 2883
		private bool mShowPrinterSettingsBeforePrint = true;

		// Token: 0x04000B44 RID: 2884
		private List<ColWith> colWiths = new List<ColWith>();
	}
}
