using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Base;
using Model.SQSConfig;
using SQSClient.AssistTool;

namespace SQSClient
{
	// Token: 0x02000030 RID: 48
	public partial class frmOrgChart : BaseDialogForm
	{
		// Token: 0x06000241 RID: 577 RVA: 0x00040638 File Offset: 0x0003E838
		public frmOrgChart(string ticketNo)
		{
			this.InitializeComponent();
		}

		// Token: 0x06000242 RID: 578 RVA: 0x0004065C File Offset: 0x0003E85C
		public frmOrgChart(ModT_ticket ticketMod)
		{
			this.InitializeComponent();
			this._gph = base.CreateGraphics();
			try
			{
				this._curTicketMod = ticketMod;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, ShowWords.ReplaceText("Reminder"), MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		// Token: 0x06000243 RID: 579 RVA: 0x000406D0 File Offset: 0x0003E8D0
		private void AddDrawLine(Point start, Point end)
		{
			Line item = default(Line);
			item.start = start;
			item.end = end;
			this._lines.Add(item);
		}

		// Token: 0x06000244 RID: 580 RVA: 0x00040704 File Offset: 0x0003E904
		private void FormOrgChart_Load(object sender, EventArgs e)
		{
			string text = null;
			TicketProcess ticketProcess = new TicketProcess();
			Button button = new Button();
			bool flag = this._curTicketMod.StepProcess == "end";
			if (flag)
			{
				button.Text = ShowWords.ReplaceText("Ending");
				button.AutoSize = true;
				button.Location = new Point(this.label_now.Location.X, 80);
				base.Controls.Add(button);
			}
			else
			{
				button.Text = ticketProcess.GetProcessNameByCode(this._curTicketMod.StepProcess, ref text);
				button.AutoSize = true;
				button.Location = new Point(this.label_now.Location.X, 80);
				bool flag2 = text != null;
				if (flag2)
				{
					MessageBox.Show(text, ShowWords.ReplaceText("Reminder"), MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
				else
				{
					base.Controls.Add(button);
				}
				bool flag3 = this._curTicketMod.LastStep.Length > 0;
				if (flag3)
				{
					Button button2 = new Button
					{
						Text = ticketProcess.GetProcessNameByCode(this._curTicketMod.LastStep, ref text),
						AutoSize = true,
						Location = new Point(this.label_pre.Location.X, 80)
					};
					bool flag4 = text != null;
					if (flag4)
					{
						MessageBox.Show(text, ShowWords.ReplaceText("Reminder"), MessageBoxButtons.OK, MessageBoxIcon.Hand);
					}
					else
					{
						base.Controls.Add(button2);
					}
					Point start = new Point(button2.Location.X + button2.Size.Width, button2.Location.Y + button2.Size.Height / 2);
					Point end = new Point(button.Location.X, button.Location.Y + button.Size.Height / 2);
					this.AddDrawLine(start, end);
				}
				List<string> nextProcessByTicketModel = ticketProcess.GetNextProcessByTicketModel(this._curTicketMod, ref text);
				bool flag5 = text != null;
				if (flag5)
				{
					MessageBox.Show(text, ShowWords.ReplaceText("Reminder"), MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
				else
				{
					int num = 0;
					foreach (string text2 in nextProcessByTicketModel)
					{
						bool flag6 = text != null;
						if (flag6)
						{
							MessageBox.Show(text, ShowWords.ReplaceText("Reminder"), MessageBoxButtons.OK, MessageBoxIcon.Hand);
						}
						Button button3 = new Button
						{
							Text = text2,
							AutoSize = true,
							Location = new Point(this.label_next.Location.X, 80 + num * 50)
						};
						base.Controls.Add(button3);
						Point start2 = new Point(button.Location.X + button.Size.Width, button.Location.Y + button.Size.Height / 2);
						Point end2 = new Point(button3.Location.X, button3.Location.Y + button3.Size.Height / 2);
						this.AddDrawLine(start2, end2);
						num++;
					}
				}
			}
		}

		// Token: 0x06000245 RID: 581 RVA: 0x00040AB4 File Offset: 0x0003ECB4
		private void FormOrgChart_Paint(object sender, PaintEventArgs e)
		{
			foreach (Line line in this._lines)
			{
				AdjustableArrowCap customEndCap = new AdjustableArrowCap(6f, 3f);
				Pen pen = new Pen(Color.Gray, 2f)
				{
					CustomEndCap = customEndCap
				};
				this._gph.DrawLine(pen, line.start, line.end);
			}
		}

		// Token: 0x04000405 RID: 1029
		private ModT_ticket _curTicketMod;

		// Token: 0x04000406 RID: 1030
		private Graphics _gph;

		// Token: 0x04000407 RID: 1031
		private List<Line> _lines = new List<Line>();
	}
}
