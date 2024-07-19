using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Assistant;
using Base;
using DAL.Base.SQSConfig;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using DevComponents.DotNetBar.Layout;
using Model;
using Model.SQSConfig;

namespace SQSClient
{
	// Token: 0x02000077 RID: 119
	public class UnitProfile : UserControl
	{
		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000674 RID: 1652 RVA: 0x0009F1CC File Offset: 0x0009D3CC
		public bool State
		{
			get
			{
				return this._State;
			}
		}

		// Token: 0x06000675 RID: 1653 RVA: 0x0009F1E4 File Offset: 0x0009D3E4
		public UnitProfile()
		{
			this.InitializeComponent();
			this.SetText(base.Controls);
			this.bmp = new Bitmap(this.picPercent.Width, this.picPercent.Height);
			this.g = Graphics.FromImage(this.bmp);
			this.r.X = 0;
			this.r.Width = this.picPercent.Width;
		}

		// Token: 0x06000676 RID: 1654 RVA: 0x0009F2A4 File Offset: 0x0009D4A4
		protected virtual void SetText(Control.ControlCollection controls)
		{
			foreach (object obj in controls)
			{
				Control control = (Control)obj;
				string fullName = control.GetType().FullName;
				string text = fullName;
				if (text != null)
				{
					if (!(text == "System.Windows.Forms.ContextMenuStrip"))
					{
						if (text == "DevComponents.DotNetBar.Layout.LayoutControl")
						{
							foreach (object obj2 in ((LayoutControl)control).RootGroup.Items)
							{
								LayoutControlItem layoutControlItem = (LayoutControlItem)obj2;
								layoutControlItem.Text = ShowWords.ReplaceText(layoutControlItem.Text);
							}
						}
					}
					else
					{
						foreach (object obj3 in ((ContextMenuStrip)control).Items)
						{
							BaseItem baseItem = (BaseItem)obj3;
							baseItem.Text = ShowWords.ReplaceText(baseItem.Text);
						}
					}
				}
				IL_10D:
				bool hasChildren = control.HasChildren;
				if (hasChildren)
				{
					this.SetText(control.Controls);
				}
				control.Text = ShowWords.ReplaceText(control.Text);
				continue;
				goto IL_10D;
			}
		}

		// Token: 0x06000677 RID: 1655 RVA: 0x0009F45C File Offset: 0x0009D65C
		protected override void OnPaint(PaintEventArgs pe)
		{
			base.OnPaint(pe);
		}

		// Token: 0x06000678 RID: 1656 RVA: 0x0009F467 File Offset: 0x0009D667
		public void SetBackColor(Color color)
		{
			this.BackColor = color;
		}

		// Token: 0x06000679 RID: 1657 RVA: 0x0009F472 File Offset: 0x0009D672
		protected void SetCommState(bool state)
		{
			this._State = state;
			this.SetForeColor(state ? Color.Black : Color.Red);
		}

		// Token: 0x0600067A RID: 1658 RVA: 0x0009F492 File Offset: 0x0009D692
		protected void SetForeColor(Color color)
		{
			this.lblUnit.ForeColor = color;
			this.lblProduct.ForeColor = color;
			this.lblPercent.ForeColor = color;
		}

		// Token: 0x0600067B RID: 1659 RVA: 0x0009F4BC File Offset: 0x0009D6BC
		public void SetValue(ModCfg_unit model)
		{
			try
			{
				this._Id = model.Id;
				ModCfg_unit model2 = DalCfg_unit.Instance.GetModel(model.Id);
				this.lblUnit.Text = model2.Name;
				this._LuHao = model2.LuHao;
				this.lblProduct.Text = model.ProductName;
				this.tbxTiDanHao.Text = model.DanHao;
				this.tbxCardNum.Text = model.CardNum;
				this.tbxYingFaLiang.Text = model.JiHuaLiang.ToString();
				this.labDanWei1.Text = model.DanWei;
				this.labDanWei2.Text = model.DanWei;
				this.tbxShiFaLiang.Text = model.ShiJiLiang.ToString();
				this.tbxMiDu.Text = model.MiDu.ToString();
				this.tbxWenDu.Text = model.WenDu.ToString();
				this.txtFluxV.Text = model.Flow.ToString();
				this.labFlow.Text = model.DanWei + "/s";
				bool flag = model.DanWei == DanWei.bbl.ToString();
				if (flag)
				{
					this.labFlow.Text = model.SpecsDanWei + "/s";
				}
				this.tbxLisence.Text = model.Lisence;
				this.labCangNum.Text = ShowWords.ReplaceText("Cang") + model.CangNum.ToString();
				this.labHeWeiCount.Text = ShowWords.ReplaceText("Queue") + DalT_ticket.Instance.GetCountByUnit(this.lblUnit.Text, 0).ToString();
			}
			catch
			{
			}
		}

		// Token: 0x0600067C RID: 1660 RVA: 0x0009F6D8 File Offset: 0x0009D8D8
		protected void SetPercent(int va)
		{
			bool flag = va < 0;
			if (flag)
			{
				va = 0;
			}
			this.lblPercent.Text = va.ToString() + "%";
			this.g.Clear(Color.Transparent);
			this.r.Y = this.picPercent.Height * (100 - va) / 100;
			this.r.Height = this.picPercent.Height * va / 100;
			this.solidBrush.Color = this.colorShow;
			this.g.FillRectangle(this.solidBrush, this.r);
			this.g.Flush();
			this.picPercent.Image = this.bmp;
			this.Refresh();
		}

		// Token: 0x0600067D RID: 1661 RVA: 0x0009F7AC File Offset: 0x0009D9AC
		public void SetRealData()
		{
			try
			{
				ModCfg_unit model = DalCfg_unit.Instance.GetModel(this._Id);
				this.tbxTiDanHao.Text = model.DanHao;
				this.tbxCardNum.Text = model.CardNum;
				this.labDanWei1.Text = model.DanWei;
				this.labDanWei2.Text = model.DanWei;
				this.tbxYingFaLiang.Text = model.JiHuaLiang.ToString();
				this.tbxShiFaLiang.Text = model.ShiJiLiang.ToString();
				this.tbxGuZhang.Text = this.AnalyGuZhang(model.GuZhang);
				this.tbxRunState.Text = ShowWords.ReplaceText(EnumHelper.GetDescription<RunState>((RunState)model.RunState));
				this.tbxMiDu.Text = model.MiDu.ToString();
				this.tbxWenDu.Text = model.WenDu.ToString();
				this.txtFluxV.Text = model.Flow.ToString();
				this.labFlow.Text = model.DanWei + "/s";
				bool flag = model.DanWei == DanWei.bbl.ToString();
				if (flag)
				{
					this.labFlow.Text = model.SpecsDanWei + "/s";
				}
				this.tbxLisence.Text = model.Lisence;
				this.labCangNum.Text = ShowWords.ReplaceText("Cang") + model.CangNum.ToString();
				this.labHeWeiCount.Text = ShowWords.ReplaceText("Queue") + DalT_ticket.Instance.GetCountByUnit(this.lblUnit.Text, 0).ToString();
				bool flag2 = model.RunState == 0;
				if (flag2)
				{
					this.colorShow = Color.Silver;
				}
				else
				{
					this.colorShow = Color.LimeGreen;
				}
				TimeSpan ts = new TimeSpan(model.CommTime.Ticks);
				TimeSpan timeSpan = new TimeSpan(DateTime.Now.Ticks);
				int num = Convert.ToInt32(timeSpan.Subtract(ts).Duration().TotalSeconds);
				bool flag3 = num > Settings.Instance.TimeOut;
				if (flag3)
				{
					this.colorShow = Color.Red;
					this._State = false;
					this.SetForeColor(this.colorShow);
				}
				else
				{
					this._State = true;
					this.SetForeColor(this.colorShow);
				}
				string value = "0";
				bool flag4 = model.JiHuaLiang > 0m;
				if (flag4)
				{
					value = (model.ShiJiLiang / model.JiHuaLiang * 100m).ToString("0.00");
				}
				this.SetPercent((int)Convert.ToDouble(value));
			}
			catch
			{
			}
		}

		// Token: 0x0600067E RID: 1662 RVA: 0x0009FAE8 File Offset: 0x0009DCE8
		private string AnalyGuZhang(string guzhang)
		{
			string text = string.Empty;
			string[] array = guzhang.Split(new char[]
			{
				','
			});
			bool flag = array.Length < 4;
			string result;
			if (flag)
			{
				result = text;
			}
			else
			{
				bool flag2 = array[0] == "1";
				if (flag2)
				{
					text += ShowWords.ReplaceText("StaticAlarm");
				}
				bool flag3 = array[1] == "1";
				if (flag3)
				{
					bool flag4 = text.Length > 0;
					if (flag4)
					{
						text += ",";
					}
					text += ShowWords.ReplaceText("OverflowAlarm");
				}
				bool flag5 = array[2] == "1";
				if (flag5)
				{
					bool flag6 = text.Length > 0;
					if (flag6)
					{
						text += ",";
					}
					text += ShowWords.ReplaceText("ValveUnclosed");
				}
				bool flag7 = array[3] == "1";
				if (flag7)
				{
				}
				bool flag8 = text.Length == 0;
				if (flag8)
				{
					text += ShowWords.ReplaceText("NoException");
				}
				result = text;
			}
			return result;
		}

		// Token: 0x0600067F RID: 1663 RVA: 0x0009FC08 File Offset: 0x0009DE08
		private void UnitProfile_Load(object sender, EventArgs e)
		{
			foreach (object obj in base.Controls)
			{
				Control control = (Control)obj;
				bool flag = control is TextBox;
				if (flag)
				{
					((TextBox)control).ReadOnly = true;
				}
			}
		}

		// Token: 0x06000680 RID: 1664 RVA: 0x00003040 File Offset: 0x00001240
		private void timer1_Tick(object sender, EventArgs e)
		{
		}

		// Token: 0x06000681 RID: 1665 RVA: 0x0009FC7C File Offset: 0x0009DE7C
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000682 RID: 1666 RVA: 0x0009FCB4 File Offset: 0x0009DEB4
		private void InitializeComponent()
		{
			this.components = new Container();
			BorderPattern borderPattern = new BorderPattern();
			this.timer1 = new Timer(this.components);
			this.pnlUnit = new PanelEx();
			this.lblProduct = new Label();
			this.lblUnit = new Label();
			this.pnlDetail = new PanelEx();
			this.lcMain = new LayoutControl();
			this.labHeWeiCount = new LabelX();
			this.labFlow = new LabelX();
			this.labelX2 = new LabelX();
			this.labelX1 = new LabelX();
			this.tbxCardNum = new TextBoxX();
			this.labDanWei2 = new LabelX();
			this.labDanWei1 = new LabelX();
			this.tbxRunState = new TextBoxX();
			this.tbxGuZhang = new TextBoxX();
			this.tbxShiFaLiang = new TextBoxX();
			this.tbxYingFaLiang = new TextBoxX();
			this.tbxTiDanHao = new TextBoxX();
			this.tbxMiDu = new TextBoxX();
			this.tbxWenDu = new TextBoxX();
			this.txtFluxV = new TextBoxX();
			this.tbxLisence = new TextBoxX();
			this.labCangNum = new LabelX();
			this.lciTiDanHao = new LayoutControlItem();
			this.layoutControlItem5 = new LayoutControlItem();
			this.layoutControlItem14 = new LayoutControlItem();
			this.layoutControlItem12 = new LayoutControlItem();
			this.layoutControlItem13 = new LayoutControlItem();
			this.layJiHuaLiang = new LayoutControlItem();
			this.layoutControlItem1 = new LayoutControlItem();
			this.layShiJiLiang = new LayoutControlItem();
			this.layoutControlItem3 = new LayoutControlItem();
			this.layoutControlItem6 = new LayoutControlItem();
			this.layoutControlItem9 = new LayoutControlItem();
			this.layoutControlItem2 = new LayoutControlItem();
			this.layoutControlItem7 = new LayoutControlItem();
			this.layoutControlItem4 = new LayoutControlItem();
			this.layoutControlItem8 = new LayoutControlItem();
			this.lciRunState = new LayoutControlItem();
			this.lciGuZhang = new LayoutControlItem();
			this.lblPercent = new LabelX();
			this.picPercent = new ReflectionImage();
			this.layoutControlItem10 = new LayoutControlItem();
			this.layoutControlItem11 = new LayoutControlItem();
			this.pnlUnit.SuspendLayout();
			this.pnlDetail.SuspendLayout();
			this.lcMain.SuspendLayout();
			base.SuspendLayout();
			this.timer1.Interval = 500;
			this.timer1.Tick += this.timer1_Tick;
			this.pnlUnit.CanvasColor = SystemColors.Control;
			this.pnlUnit.ColorSchemeStyle = eDotNetBarStyle.StyleManagerControlled;
			this.pnlUnit.Controls.Add(this.lblProduct);
			this.pnlUnit.Controls.Add(this.lblUnit);
			this.pnlUnit.DisabledBackColor = Color.Empty;
			this.pnlUnit.Dock = DockStyle.Top;
			this.pnlUnit.Location = new Point(0, 0);
			this.pnlUnit.Name = "pnlUnit";
			this.pnlUnit.Size = new Size(285, 58);
			this.pnlUnit.Style.Alignment = StringAlignment.Center;
			this.pnlUnit.Style.BackColor1.ColorSchemePart = eColorSchemePart.PanelBackground;
			this.pnlUnit.Style.BackColor2.ColorSchemePart = eColorSchemePart.PanelBackground2;
			this.pnlUnit.Style.Border = eBorderType.SingleLine;
			this.pnlUnit.Style.BorderColor.ColorSchemePart = eColorSchemePart.PanelBorder;
			this.pnlUnit.Style.ForeColor.ColorSchemePart = eColorSchemePart.PanelText;
			this.pnlUnit.Style.GradientAngle = 90;
			this.pnlUnit.TabIndex = 1;
			this.lblProduct.AutoEllipsis = true;
			this.lblProduct.Dock = DockStyle.Right;
			this.lblProduct.Font = new Font("宋体", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 134);
			this.lblProduct.Location = new Point(102, 0);
			this.lblProduct.Name = "lblProduct";
			this.lblProduct.Size = new Size(183, 58);
			this.lblProduct.TabIndex = 2;
			this.lblProduct.Text = "Product";
			this.lblProduct.TextAlign = ContentAlignment.MiddleRight;
			this.lblUnit.AutoEllipsis = true;
			this.lblUnit.Dock = DockStyle.Left;
			this.lblUnit.Font = new Font("宋体", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 134);
			this.lblUnit.Location = new Point(0, 0);
			this.lblUnit.Name = "lblUnit";
			this.lblUnit.Size = new Size(109, 58);
			this.lblUnit.TabIndex = 1;
			this.lblUnit.Text = "Unit";
			this.lblUnit.TextAlign = ContentAlignment.MiddleLeft;
			this.pnlDetail.CanvasColor = SystemColors.Control;
			this.pnlDetail.ColorSchemeStyle = eDotNetBarStyle.StyleManagerControlled;
			this.pnlDetail.Controls.Add(this.lcMain);
			this.pnlDetail.Controls.Add(this.lblPercent);
			this.pnlDetail.Controls.Add(this.picPercent);
			this.pnlDetail.DisabledBackColor = Color.Empty;
			this.pnlDetail.Dock = DockStyle.Fill;
			this.pnlDetail.Location = new Point(0, 58);
			this.pnlDetail.Name = "pnlDetail";
			this.pnlDetail.Size = new Size(285, 290);
			this.pnlDetail.Style.Alignment = StringAlignment.Center;
			this.pnlDetail.Style.BackColor1.Color = Color.FromArgb(194, 217, 247);
			this.pnlDetail.Style.BackColor2.Color = Color.FromArgb(194, 217, 247);
			this.pnlDetail.Style.Border = eBorderType.SingleLine;
			this.pnlDetail.Style.BorderColor.ColorSchemePart = eColorSchemePart.PanelBorder;
			this.pnlDetail.Style.ForeColor.ColorSchemePart = eColorSchemePart.PanelText;
			this.pnlDetail.Style.GradientAngle = 90;
			this.pnlDetail.TabIndex = 9;
			this.lcMain.Controls.Add(this.labHeWeiCount);
			this.lcMain.Controls.Add(this.labFlow);
			this.lcMain.Controls.Add(this.labelX2);
			this.lcMain.Controls.Add(this.labelX1);
			this.lcMain.Controls.Add(this.tbxCardNum);
			this.lcMain.Controls.Add(this.labDanWei2);
			this.lcMain.Controls.Add(this.labDanWei1);
			this.lcMain.Controls.Add(this.tbxRunState);
			this.lcMain.Controls.Add(this.tbxGuZhang);
			this.lcMain.Controls.Add(this.tbxShiFaLiang);
			this.lcMain.Controls.Add(this.tbxYingFaLiang);
			this.lcMain.Controls.Add(this.tbxTiDanHao);
			this.lcMain.Controls.Add(this.tbxMiDu);
			this.lcMain.Controls.Add(this.tbxWenDu);
			this.lcMain.Controls.Add(this.txtFluxV);
			this.lcMain.Controls.Add(this.tbxLisence);
			this.lcMain.Controls.Add(this.labCangNum);
			this.lcMain.Dock = DockStyle.Right;
			this.lcMain.FocusStyle.BorderColors = new BorderColors(Color.Empty, Color.Empty, SystemColors.HotTrack, Color.Empty);
			borderPattern.Right = LinePattern.Solid;
			this.lcMain.FocusStyle.BorderPattern = borderPattern;
			this.lcMain.FocusStyle.BorderThickness = new Thickness(0.0, 0.0, 1.0, 0.0);
			this.lcMain.Location = new Point(58, 0);
			this.lcMain.Name = "lcMain";
			this.lcMain.RootGroup.Items.AddRange(new LayoutItemBase[]
			{
				this.lciTiDanHao,
				this.layoutControlItem5,
				this.layoutControlItem14,
				this.layoutControlItem12,
				this.layoutControlItem13,
				this.layJiHuaLiang,
				this.layoutControlItem1,
				this.layShiJiLiang,
				this.layoutControlItem3,
				this.layoutControlItem6,
				this.layoutControlItem9,
				this.layoutControlItem2,
				this.layoutControlItem7,
				this.layoutControlItem4,
				this.layoutControlItem8,
				this.lciRunState,
				this.lciGuZhang
			});
			this.lcMain.Size = new Size(227, 290);
			this.lcMain.TabIndex = 14;
			this.labHeWeiCount.BackgroundStyle.CornerType = eCornerType.Square;
			this.labHeWeiCount.Location = new Point(174, 33);
			this.labHeWeiCount.Margin = new System.Windows.Forms.Padding(0);
			this.labHeWeiCount.Name = "labHeWeiCount";
			this.labHeWeiCount.Size = new Size(49, 21);
			this.labHeWeiCount.TabIndex = 2;
			this.labFlow.BackgroundStyle.CornerType = eCornerType.Square;
			this.labFlow.Location = new Point(174, 149);
			this.labFlow.Margin = new System.Windows.Forms.Padding(0);
			this.labFlow.Name = "labFlow";
			this.labFlow.Size = new Size(49, 21);
			this.labFlow.TabIndex = 10;
			this.labFlow.Text = "kg/s";
			this.labelX2.BackgroundStyle.CornerType = eCornerType.Square;
			this.labelX2.Location = new Point(174, 207);
			this.labelX2.Margin = new System.Windows.Forms.Padding(0);
			this.labelX2.Name = "labelX2";
			this.labelX2.Size = new Size(49, 21);
			this.labelX2.TabIndex = 14;
			this.labelX2.Text = "℃";
			this.labelX1.BackgroundStyle.CornerType = eCornerType.Square;
			this.labelX1.Location = new Point(174, 178);
			this.labelX1.Margin = new System.Windows.Forms.Padding(0);
			this.labelX1.Name = "labelX1";
			this.labelX1.Size = new Size(49, 21);
			this.labelX1.TabIndex = 12;
			this.labelX1.Text = "kg/m³";
			this.tbxCardNum.Border.Class = "TextBoxBorder";
			this.tbxCardNum.Border.CornerType = eCornerType.Square;
			this.tbxCardNum.Enabled = false;
			this.tbxCardNum.Location = new Point(73, 33);
			this.tbxCardNum.Margin = new System.Windows.Forms.Padding(0);
			this.tbxCardNum.Name = "tbxCardNum";
			this.tbxCardNum.PreventEnterBeep = true;
			this.tbxCardNum.Size = new Size(93, 21);
			this.tbxCardNum.TabIndex = 1;
			this.labDanWei2.BackgroundStyle.CornerType = eCornerType.Square;
			this.labDanWei2.Location = new Point(174, 120);
			this.labDanWei2.Margin = new System.Windows.Forms.Padding(0);
			this.labDanWei2.Name = "labDanWei2";
			this.labDanWei2.Size = new Size(49, 21);
			this.labDanWei2.TabIndex = 8;
			this.labDanWei2.Text = "kg";
			this.labDanWei1.BackgroundStyle.CornerType = eCornerType.Square;
			this.labDanWei1.Location = new Point(174, 91);
			this.labDanWei1.Margin = new System.Windows.Forms.Padding(0);
			this.labDanWei1.Name = "labDanWei1";
			this.labDanWei1.Size = new Size(49, 21);
			this.labDanWei1.TabIndex = 6;
			this.labDanWei1.Text = "kg";
			this.tbxRunState.Border.Class = "TextBoxBorder";
			this.tbxRunState.Border.CornerType = eCornerType.Square;
			this.tbxRunState.Enabled = false;
			this.tbxRunState.Location = new Point(73, 236);
			this.tbxRunState.Margin = new System.Windows.Forms.Padding(0);
			this.tbxRunState.Name = "tbxRunState";
			this.tbxRunState.PreventEnterBeep = true;
			this.tbxRunState.Size = new Size(150, 21);
			this.tbxRunState.TabIndex = 15;
			this.tbxGuZhang.Border.Class = "TextBoxBorder";
			this.tbxGuZhang.Border.CornerType = eCornerType.Square;
			this.tbxGuZhang.Enabled = false;
			this.tbxGuZhang.Location = new Point(73, 265);
			this.tbxGuZhang.Margin = new System.Windows.Forms.Padding(0);
			this.tbxGuZhang.Name = "tbxGuZhang";
			this.tbxGuZhang.PreventEnterBeep = true;
			this.tbxGuZhang.Size = new Size(150, 21);
			this.tbxGuZhang.TabIndex = 16;
			this.tbxShiFaLiang.Border.Class = "TextBoxBorder";
			this.tbxShiFaLiang.Border.CornerType = eCornerType.Square;
			this.tbxShiFaLiang.Enabled = false;
			this.tbxShiFaLiang.Location = new Point(73, 120);
			this.tbxShiFaLiang.Margin = new System.Windows.Forms.Padding(0);
			this.tbxShiFaLiang.Name = "tbxShiFaLiang";
			this.tbxShiFaLiang.PreventEnterBeep = true;
			this.tbxShiFaLiang.Size = new Size(93, 21);
			this.tbxShiFaLiang.TabIndex = 7;
			this.tbxYingFaLiang.Border.Class = "TextBoxBorder";
			this.tbxYingFaLiang.Border.CornerType = eCornerType.Square;
			this.tbxYingFaLiang.Enabled = false;
			this.tbxYingFaLiang.Location = new Point(73, 91);
			this.tbxYingFaLiang.Margin = new System.Windows.Forms.Padding(0);
			this.tbxYingFaLiang.Name = "tbxYingFaLiang";
			this.tbxYingFaLiang.PreventEnterBeep = true;
			this.tbxYingFaLiang.Size = new Size(93, 21);
			this.tbxYingFaLiang.TabIndex = 5;
			this.tbxTiDanHao.Border.Class = "TextBoxBorder";
			this.tbxTiDanHao.Border.CornerType = eCornerType.Square;
			this.tbxTiDanHao.Enabled = false;
			this.tbxTiDanHao.Location = new Point(73, 4);
			this.tbxTiDanHao.Margin = new System.Windows.Forms.Padding(0);
			this.tbxTiDanHao.Name = "tbxTiDanHao";
			this.tbxTiDanHao.PreventEnterBeep = true;
			this.tbxTiDanHao.Size = new Size(150, 21);
			this.tbxTiDanHao.TabIndex = 0;
			this.tbxMiDu.Border.Class = "TextBoxBorder";
			this.tbxMiDu.Border.CornerType = eCornerType.Square;
			this.tbxMiDu.Enabled = false;
			this.tbxMiDu.Location = new Point(73, 178);
			this.tbxMiDu.Margin = new System.Windows.Forms.Padding(0);
			this.tbxMiDu.Name = "tbxMiDu";
			this.tbxMiDu.PreventEnterBeep = true;
			this.tbxMiDu.Size = new Size(93, 21);
			this.tbxMiDu.TabIndex = 11;
			this.tbxWenDu.Border.Class = "TextBoxBorder";
			this.tbxWenDu.Border.CornerType = eCornerType.Square;
			this.tbxWenDu.Enabled = false;
			this.tbxWenDu.Location = new Point(73, 207);
			this.tbxWenDu.Margin = new System.Windows.Forms.Padding(0);
			this.tbxWenDu.Name = "tbxWenDu";
			this.tbxWenDu.PreventEnterBeep = true;
			this.tbxWenDu.Size = new Size(93, 21);
			this.tbxWenDu.TabIndex = 13;
			this.txtFluxV.Border.Class = "TextBoxBorder";
			this.txtFluxV.Border.CornerType = eCornerType.Square;
			this.txtFluxV.Enabled = false;
			this.txtFluxV.Location = new Point(73, 149);
			this.txtFluxV.Margin = new System.Windows.Forms.Padding(0);
			this.txtFluxV.Name = "txtFluxV";
			this.txtFluxV.PreventEnterBeep = true;
			this.txtFluxV.Size = new Size(93, 21);
			this.txtFluxV.TabIndex = 9;
			this.tbxLisence.Border.Class = "TextBoxBorder";
			this.tbxLisence.Border.CornerType = eCornerType.Square;
			this.tbxLisence.Enabled = false;
			this.tbxLisence.Location = new Point(73, 62);
			this.tbxLisence.Margin = new System.Windows.Forms.Padding(0);
			this.tbxLisence.Name = "tbxLisence";
			this.tbxLisence.PreventEnterBeep = true;
			this.tbxLisence.Size = new Size(93, 21);
			this.tbxLisence.TabIndex = 3;
			this.labCangNum.BackgroundStyle.CornerType = eCornerType.Square;
			this.labCangNum.Location = new Point(174, 62);
			this.labCangNum.Margin = new System.Windows.Forms.Padding(0);
			this.labCangNum.Name = "labCangNum";
			this.labCangNum.Size = new Size(49, 21);
			this.labCangNum.TabIndex = 4;
			this.lciTiDanHao.Control = this.tbxTiDanHao;
			this.lciTiDanHao.Height = 29;
			this.lciTiDanHao.MinSize = new Size(120, 0);
			this.lciTiDanHao.Name = "lciTiDanHao";
			this.lciTiDanHao.Text = "DanHao";
			this.lciTiDanHao.Width = 100;
			this.lciTiDanHao.WidthType = eLayoutSizeType.Percent;
			this.layoutControlItem5.Control = this.tbxCardNum;
			this.layoutControlItem5.Height = 29;
			this.layoutControlItem5.MinSize = new Size(120, 0);
			this.layoutControlItem5.Name = "layoutControlItem5";
			this.layoutControlItem5.Text = "IC";
			this.layoutControlItem5.Width = 75;
			this.layoutControlItem5.WidthType = eLayoutSizeType.Percent;
			this.layoutControlItem14.Control = this.labHeWeiCount;
			this.layoutControlItem14.Height = 29;
			this.layoutControlItem14.MinSize = new Size(20, 18);
			this.layoutControlItem14.Name = "layoutControlItem14";
			this.layoutControlItem14.Width = 25;
			this.layoutControlItem14.WidthType = eLayoutSizeType.Percent;
			this.layoutControlItem12.Control = this.tbxLisence;
			this.layoutControlItem12.Height = 29;
			this.layoutControlItem12.MinSize = new Size(120, 0);
			this.layoutControlItem12.Name = "layoutControlItem12";
			this.layoutControlItem12.Text = "CheNum";
			this.layoutControlItem12.Width = 75;
			this.layoutControlItem12.WidthType = eLayoutSizeType.Percent;
			this.layoutControlItem13.Control = this.labCangNum;
			this.layoutControlItem13.Height = 29;
			this.layoutControlItem13.MinSize = new Size(20, 18);
			this.layoutControlItem13.Name = "layoutControlItem13";
			this.layoutControlItem13.Width = 25;
			this.layoutControlItem13.WidthType = eLayoutSizeType.Percent;
			this.layJiHuaLiang.Control = this.tbxYingFaLiang;
			this.layJiHuaLiang.Height = 29;
			this.layJiHuaLiang.MinSize = new Size(120, 0);
			this.layJiHuaLiang.Name = "layJiHuaLiang";
			this.layJiHuaLiang.Text = "JiHuaLiang";
			this.layJiHuaLiang.Width = 75;
			this.layJiHuaLiang.WidthType = eLayoutSizeType.Percent;
			this.layoutControlItem1.Control = this.labDanWei1;
			this.layoutControlItem1.Height = 29;
			this.layoutControlItem1.MinSize = new Size(20, 18);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Width = 25;
			this.layoutControlItem1.WidthType = eLayoutSizeType.Percent;
			this.layShiJiLiang.Control = this.tbxShiFaLiang;
			this.layShiJiLiang.Height = 29;
			this.layShiJiLiang.MinSize = new Size(120, 0);
			this.layShiJiLiang.Name = "layShiJiLiang";
			this.layShiJiLiang.Text = "ShiJiLiang";
			this.layShiJiLiang.Width = 75;
			this.layShiJiLiang.WidthType = eLayoutSizeType.Percent;
			this.layoutControlItem3.Control = this.labDanWei2;
			this.layoutControlItem3.Height = 29;
			this.layoutControlItem3.MinSize = new Size(20, 18);
			this.layoutControlItem3.Name = "layoutControlItem3";
			this.layoutControlItem3.Width = 25;
			this.layoutControlItem3.WidthType = eLayoutSizeType.Percent;
			this.layoutControlItem6.Control = this.txtFluxV;
			this.layoutControlItem6.Height = 29;
			this.layoutControlItem6.MinSize = new Size(120, 0);
			this.layoutControlItem6.Name = "layoutControlItem6";
			this.layoutControlItem6.Text = "Flow";
			this.layoutControlItem6.Width = 75;
			this.layoutControlItem6.WidthType = eLayoutSizeType.Percent;
			this.layoutControlItem9.Control = this.labFlow;
			this.layoutControlItem9.Height = 29;
			this.layoutControlItem9.MinSize = new Size(20, 18);
			this.layoutControlItem9.Name = "layoutControlItem9";
			this.layoutControlItem9.Width = 25;
			this.layoutControlItem9.WidthType = eLayoutSizeType.Percent;
			this.layoutControlItem2.Control = this.tbxMiDu;
			this.layoutControlItem2.Height = 29;
			this.layoutControlItem2.MinSize = new Size(120, 0);
			this.layoutControlItem2.Name = "layoutControlItem2";
			this.layoutControlItem2.Text = "MiDu";
			this.layoutControlItem2.Width = 75;
			this.layoutControlItem2.WidthType = eLayoutSizeType.Percent;
			this.layoutControlItem7.Control = this.labelX1;
			this.layoutControlItem7.Height = 29;
			this.layoutControlItem7.MinSize = new Size(20, 18);
			this.layoutControlItem7.Name = "layoutControlItem7";
			this.layoutControlItem7.Width = 25;
			this.layoutControlItem7.WidthType = eLayoutSizeType.Percent;
			this.layoutControlItem4.Control = this.tbxWenDu;
			this.layoutControlItem4.Height = 29;
			this.layoutControlItem4.MinSize = new Size(120, 0);
			this.layoutControlItem4.Name = "layoutControlItem4";
			this.layoutControlItem4.Text = "WenDu";
			this.layoutControlItem4.Width = 75;
			this.layoutControlItem4.WidthType = eLayoutSizeType.Percent;
			this.layoutControlItem8.Control = this.labelX2;
			this.layoutControlItem8.Height = 29;
			this.layoutControlItem8.MinSize = new Size(20, 18);
			this.layoutControlItem8.Name = "layoutControlItem8";
			this.layoutControlItem8.Width = 25;
			this.layoutControlItem8.WidthType = eLayoutSizeType.Percent;
			this.lciRunState.Control = this.tbxRunState;
			this.lciRunState.Height = 29;
			this.lciRunState.MinSize = new Size(120, 0);
			this.lciRunState.Name = "lciRunState";
			this.lciRunState.Text = "Status";
			this.lciRunState.Width = 100;
			this.lciRunState.WidthType = eLayoutSizeType.Percent;
			this.lciGuZhang.Control = this.tbxGuZhang;
			this.lciGuZhang.Height = 29;
			this.lciGuZhang.MinSize = new Size(120, 0);
			this.lciGuZhang.Name = "lciGuZhang";
			this.lciGuZhang.Text = "Alarm";
			this.lciGuZhang.Width = 100;
			this.lciGuZhang.WidthType = eLayoutSizeType.Percent;
			this.lblPercent.BackgroundStyle.CornerType = eCornerType.Square;
			this.lblPercent.Font = new Font("宋体", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 134);
			this.lblPercent.Location = new Point(3, 262);
			this.lblPercent.Margin = new System.Windows.Forms.Padding(0);
			this.lblPercent.Name = "lblPercent";
			this.lblPercent.Size = new Size(52, 28);
			this.lblPercent.TabIndex = 7;
			this.lblPercent.Text = "100%";
			this.lblPercent.TextAlignment = StringAlignment.Center;
			this.picPercent.BackgroundStyle.BorderBottom = eStyleBorderType.Solid;
			this.picPercent.BackgroundStyle.BorderBottomWidth = 1;
			this.picPercent.BackgroundStyle.BorderColor = Color.Black;
			this.picPercent.BackgroundStyle.BorderLeft = eStyleBorderType.Solid;
			this.picPercent.BackgroundStyle.BorderLeftWidth = 1;
			this.picPercent.BackgroundStyle.BorderRight = eStyleBorderType.Solid;
			this.picPercent.BackgroundStyle.BorderRightWidth = 1;
			this.picPercent.BackgroundStyle.BorderTop = eStyleBorderType.Solid;
			this.picPercent.BackgroundStyle.BorderTopWidth = 1;
			this.picPercent.BackgroundStyle.CornerType = eCornerType.Square;
			this.picPercent.BackgroundStyle.TextAlignment = eStyleTextAlignment.Center;
			this.picPercent.Location = new Point(3, 4);
			this.picPercent.Margin = new System.Windows.Forms.Padding(0);
			this.picPercent.Name = "picPercent";
			this.picPercent.Size = new Size(52, 256);
			this.picPercent.TabIndex = 6;
			this.layoutControlItem10.Control = this.tbxLisence;
			this.layoutControlItem10.Height = 29;
			this.layoutControlItem10.MinSize = new Size(120, 0);
			this.layoutControlItem10.Name = "layoutControlItem10";
			this.layoutControlItem10.Text = "流  速：";
			this.layoutControlItem10.Width = 75;
			this.layoutControlItem10.WidthType = eLayoutSizeType.Percent;
			this.layoutControlItem11.Control = this.labCangNum;
			this.layoutControlItem11.Height = 29;
			this.layoutControlItem11.MinSize = new Size(20, 18);
			this.layoutControlItem11.Name = "layoutControlItem11";
			this.layoutControlItem11.Width = 25;
			this.layoutControlItem11.WidthType = eLayoutSizeType.Percent;
			this.BackColor = SystemColors.Control;
			base.Controls.Add(this.pnlDetail);
			base.Controls.Add(this.pnlUnit);
			base.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
			base.Name = "UnitProfile";
			base.Size = new Size(285, 348);
			base.Load += this.UnitProfile_Load;
			this.pnlUnit.ResumeLayout(false);
			this.pnlDetail.ResumeLayout(false);
			this.lcMain.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x04000AF2 RID: 2802
		private int _Id;

		// Token: 0x04000AF3 RID: 2803
		private int _LuHao;

		// Token: 0x04000AF4 RID: 2804
		private int _DevId;

		// Token: 0x04000AF5 RID: 2805
		private int _TimeOut = 0;

		// Token: 0x04000AF6 RID: 2806
		private int _SendId;

		// Token: 0x04000AF7 RID: 2807
		private string _FrameType = "SupportFrame";

		// Token: 0x04000AF8 RID: 2808
		public bool _State;

		// Token: 0x04000AF9 RID: 2809
		private Color colorShow = Color.Red;

		// Token: 0x04000AFA RID: 2810
		private Bitmap bmp;

		// Token: 0x04000AFB RID: 2811
		private Graphics g;

		// Token: 0x04000AFC RID: 2812
		private Rectangle r = default(Rectangle);

		// Token: 0x04000AFD RID: 2813
		private SolidBrush solidBrush = new SolidBrush(Color.Red);

		// Token: 0x04000AFE RID: 2814
		private IContainer components = null;

		// Token: 0x04000AFF RID: 2815
		private Timer timer1;

		// Token: 0x04000B00 RID: 2816
		private PanelEx pnlUnit;

		// Token: 0x04000B01 RID: 2817
		private PanelEx pnlDetail;

		// Token: 0x04000B02 RID: 2818
		private LabelX lblPercent;

		// Token: 0x04000B03 RID: 2819
		private ReflectionImage picPercent;

		// Token: 0x04000B04 RID: 2820
		private Label lblProduct;

		// Token: 0x04000B05 RID: 2821
		private Label lblUnit;

		// Token: 0x04000B06 RID: 2822
		private LayoutControl lcMain;

		// Token: 0x04000B07 RID: 2823
		private TextBoxX tbxRunState;

		// Token: 0x04000B08 RID: 2824
		private TextBoxX tbxGuZhang;

		// Token: 0x04000B09 RID: 2825
		private TextBoxX tbxShiFaLiang;

		// Token: 0x04000B0A RID: 2826
		private TextBoxX tbxYingFaLiang;

		// Token: 0x04000B0B RID: 2827
		private TextBoxX tbxTiDanHao;

		// Token: 0x04000B0C RID: 2828
		private TextBoxX tbxMiDu;

		// Token: 0x04000B0D RID: 2829
		private TextBoxX tbxWenDu;

		// Token: 0x04000B0E RID: 2830
		private TextBoxX txtFluxV;

		// Token: 0x04000B0F RID: 2831
		private LayoutControlItem lciTiDanHao;

		// Token: 0x04000B10 RID: 2832
		private LayoutControlItem layJiHuaLiang;

		// Token: 0x04000B11 RID: 2833
		private LayoutControlItem layShiJiLiang;

		// Token: 0x04000B12 RID: 2834
		private LayoutControlItem layoutControlItem2;

		// Token: 0x04000B13 RID: 2835
		private LayoutControlItem layoutControlItem4;

		// Token: 0x04000B14 RID: 2836
		private LayoutControlItem layoutControlItem6;

		// Token: 0x04000B15 RID: 2837
		private LayoutControlItem lciRunState;

		// Token: 0x04000B16 RID: 2838
		private LayoutControlItem lciGuZhang;

		// Token: 0x04000B17 RID: 2839
		private LabelX labDanWei2;

		// Token: 0x04000B18 RID: 2840
		private LabelX labDanWei1;

		// Token: 0x04000B19 RID: 2841
		private LayoutControlItem layoutControlItem1;

		// Token: 0x04000B1A RID: 2842
		private LayoutControlItem layoutControlItem3;

		// Token: 0x04000B1B RID: 2843
		private TextBoxX tbxCardNum;

		// Token: 0x04000B1C RID: 2844
		private LayoutControlItem layoutControlItem5;

		// Token: 0x04000B1D RID: 2845
		private LabelX labelX1;

		// Token: 0x04000B1E RID: 2846
		private LayoutControlItem layoutControlItem7;

		// Token: 0x04000B1F RID: 2847
		private LabelX labelX2;

		// Token: 0x04000B20 RID: 2848
		private LayoutControlItem layoutControlItem8;

		// Token: 0x04000B21 RID: 2849
		private LabelX labFlow;

		// Token: 0x04000B22 RID: 2850
		private LayoutControlItem layoutControlItem9;

		// Token: 0x04000B23 RID: 2851
		private TextBoxX tbxLisence;

		// Token: 0x04000B24 RID: 2852
		private LabelX labCangNum;

		// Token: 0x04000B25 RID: 2853
		private LayoutControlItem layoutControlItem12;

		// Token: 0x04000B26 RID: 2854
		private LayoutControlItem layoutControlItem13;

		// Token: 0x04000B27 RID: 2855
		private LayoutControlItem layoutControlItem10;

		// Token: 0x04000B28 RID: 2856
		private LayoutControlItem layoutControlItem11;

		// Token: 0x04000B29 RID: 2857
		private LabelX labHeWeiCount;

		// Token: 0x04000B2A RID: 2858
		private LayoutControlItem layoutControlItem14;
	}
}
