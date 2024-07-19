using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;

namespace SQSClient
{
	// Token: 0x02000043 RID: 67
	public class ATicketControl : UserControl
	{
		// Token: 0x17000021 RID: 33
		// (get) Token: 0x060002F7 RID: 759 RVA: 0x0004B1DB File Offset: 0x000493DB
		// (set) Token: 0x060002F8 RID: 760 RVA: 0x0004B1E8 File Offset: 0x000493E8
		public bool Checked
		{
			get
			{
				return this.chk.Checked;
			}
			set
			{
				this.chk.Checked = value;
			}
		}

		// Token: 0x060002F9 RID: 761 RVA: 0x0004B1F7 File Offset: 0x000493F7
		public ATicketControl()
		{
			this.InitializeComponent();
		}

		// Token: 0x060002FA RID: 762 RVA: 0x0004B210 File Offset: 0x00049410
		public ATicketControl(Dictionary<string, object> model)
		{
			this.InitializeComponent();
			this.Model = model;
			this.labDanHao.Text = model["DanHao"].ToString();
			this.labSettlePart.Text = model["SettlePart"].ToString();
			this.labClientPart.Text = model["ClientPart"].ToString();
			this.labLisence.Text = model["Lisence"].ToString();
			this.labCangNum.Text = model["CangNum"].ToString();
			this.labProductName.Text = model["ProductName"].ToString();
			this.labJiHuaLiang.Text = model["JiHuaLiang"].ToString();
			this.labBusinessType.Text = PublicClass.BusinessTypeArray[int.Parse(model["BusinessType"].ToString()) - 1];
			this.labStatus.Text = PublicClass.TicketStatusTypeArray[int.Parse(model["Status"].ToString())];
			this.labZhiDanTime.Text = model["ZhiDanTime"].ToString();
			this.CheCangNum = model["Lisence"].ToString() + model["CangNum"].ToString();
		}

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x060002FB RID: 763 RVA: 0x0004B398 File Offset: 0x00049598
		// (remove) Token: 0x060002FC RID: 764 RVA: 0x0004B3D0 File Offset: 0x000495D0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public event ATicketControl.TicketCheckedChangedHandle TicketCheckedChangedEvent;

		// Token: 0x060002FD RID: 765 RVA: 0x0004B408 File Offset: 0x00049608
		private void chk_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.TicketCheckedChangedEvent != null;
			if (flag)
			{
				try
				{
					this.TicketCheckedChangedEvent(this, e);
				}
				catch
				{
					this.TicketCheckedChangedEvent = null;
				}
			}
		}

		// Token: 0x060002FE RID: 766 RVA: 0x0004B454 File Offset: 0x00049654
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060002FF RID: 767 RVA: 0x0004B48C File Offset: 0x0004968C
		private void InitializeComponent()
		{
			this.groupPanel2 = new GroupPanel();
			this.labZhiDanTime = new LabelX();
			this.labelX11 = new LabelX();
			this.labCangNum = new LabelX();
			this.labelX10 = new LabelX();
			this.labLisence = new LabelX();
			this.labelX9 = new LabelX();
			this.labJiHuaLiang = new LabelX();
			this.labelX1 = new LabelX();
			this.labClientPart = new LabelX();
			this.labStatus = new LabelX();
			this.labProductName = new LabelX();
			this.labSettlePart = new LabelX();
			this.labBusinessType = new LabelX();
			this.chk = new CheckBoxX();
			this.labelX8 = new LabelX();
			this.labelX7 = new LabelX();
			this.labelX6 = new LabelX();
			this.labelX5 = new LabelX();
			this.labelX4 = new LabelX();
			this.labelX2 = new LabelX();
			this.labDanHao = new LabelX();
			this.groupPanel2.SuspendLayout();
			base.SuspendLayout();
			this.groupPanel2.BackColor = Color.Transparent;
			this.groupPanel2.CanvasColor = SystemColors.Control;
			this.groupPanel2.ColorSchemeStyle = eDotNetBarStyle.Office2007;
			this.groupPanel2.Controls.Add(this.labZhiDanTime);
			this.groupPanel2.Controls.Add(this.labelX11);
			this.groupPanel2.Controls.Add(this.labCangNum);
			this.groupPanel2.Controls.Add(this.labelX10);
			this.groupPanel2.Controls.Add(this.labLisence);
			this.groupPanel2.Controls.Add(this.labelX9);
			this.groupPanel2.Controls.Add(this.labJiHuaLiang);
			this.groupPanel2.Controls.Add(this.labelX1);
			this.groupPanel2.Controls.Add(this.labClientPart);
			this.groupPanel2.Controls.Add(this.labStatus);
			this.groupPanel2.Controls.Add(this.labProductName);
			this.groupPanel2.Controls.Add(this.labSettlePart);
			this.groupPanel2.Controls.Add(this.labBusinessType);
			this.groupPanel2.Controls.Add(this.chk);
			this.groupPanel2.Controls.Add(this.labelX8);
			this.groupPanel2.Controls.Add(this.labelX7);
			this.groupPanel2.Controls.Add(this.labelX6);
			this.groupPanel2.Controls.Add(this.labelX5);
			this.groupPanel2.Controls.Add(this.labelX4);
			this.groupPanel2.Controls.Add(this.labelX2);
			this.groupPanel2.Controls.Add(this.labDanHao);
			this.groupPanel2.DisabledBackColor = Color.Empty;
			this.groupPanel2.Dock = DockStyle.Fill;
			this.groupPanel2.DrawTitleBox = false;
			this.groupPanel2.Font = new Font("宋体", 12f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.groupPanel2.Location = new Point(0, 0);
			this.groupPanel2.Name = "groupPanel2";
			this.groupPanel2.Size = new Size(900, 180);
			this.groupPanel2.Style.BackColor = SystemColors.Window;
			this.groupPanel2.Style.BackColor2 = SystemColors.Window;
			this.groupPanel2.Style.BackColorGradientAngle = 90;
			this.groupPanel2.Style.BorderBottom = eStyleBorderType.Solid;
			this.groupPanel2.Style.BorderBottomWidth = 2;
			this.groupPanel2.Style.BorderColor = SystemColors.ButtonFace;
			this.groupPanel2.Style.BorderColor2 = SystemColors.ButtonShadow;
			this.groupPanel2.Style.BorderLeft = eStyleBorderType.Solid;
			this.groupPanel2.Style.BorderLeftWidth = 2;
			this.groupPanel2.Style.BorderRight = eStyleBorderType.Solid;
			this.groupPanel2.Style.BorderRightWidth = 2;
			this.groupPanel2.Style.BorderTop = eStyleBorderType.Solid;
			this.groupPanel2.Style.BorderTopWidth = 2;
			this.groupPanel2.Style.CornerDiameter = 12;
			this.groupPanel2.Style.CornerType = eCornerType.Rounded;
			this.groupPanel2.Style.TextColor = Color.White;
			this.groupPanel2.Style.TextLineAlignment = eStyleTextAlignment.Near;
			this.groupPanel2.StyleMouseDown.CornerType = eCornerType.Square;
			this.groupPanel2.StyleMouseOver.CornerType = eCornerType.Square;
			this.groupPanel2.TabIndex = 36;
			this.labZhiDanTime.AutoSize = true;
			this.labZhiDanTime.BackgroundStyle.CornerType = eCornerType.Square;
			this.labZhiDanTime.Location = new Point(605, 93);
			this.labZhiDanTime.Name = "labZhiDanTime";
			this.labZhiDanTime.Size = new Size(74, 20);
			this.labZhiDanTime.TabIndex = 22;
			this.labZhiDanTime.Text = "labelX13";
			this.labelX11.BackgroundStyle.CornerType = eCornerType.Square;
			this.labelX11.Location = new Point(523, 92);
			this.labelX11.Name = "labelX11";
			this.labelX11.Size = new Size(75, 23);
			this.labelX11.TabIndex = 21;
			this.labelX11.Text = "制单时间";
			this.labCangNum.AutoSize = true;
			this.labCangNum.BackgroundStyle.CornerType = eCornerType.Square;
			this.labCangNum.Location = new Point(363, 53);
			this.labCangNum.Name = "labCangNum";
			this.labCangNum.Size = new Size(74, 20);
			this.labCangNum.TabIndex = 20;
			this.labCangNum.Text = "labelX11";
			this.labelX10.BackgroundStyle.CornerType = eCornerType.Square;
			this.labelX10.Location = new Point(280, 52);
			this.labelX10.Name = "labelX10";
			this.labelX10.Size = new Size(75, 23);
			this.labelX10.TabIndex = 19;
			this.labelX10.Text = "舱号";
			this.labLisence.AutoSize = true;
			this.labLisence.BackgroundStyle.CornerType = eCornerType.Square;
			this.labLisence.Location = new Point(360, 13);
			this.labLisence.Name = "labLisence";
			this.labLisence.Size = new Size(74, 20);
			this.labLisence.TabIndex = 18;
			this.labLisence.Text = "labelX10";
			this.labelX9.BackgroundStyle.CornerType = eCornerType.Square;
			this.labelX9.Location = new Point(280, 12);
			this.labelX9.Name = "labelX9";
			this.labelX9.Size = new Size(75, 23);
			this.labelX9.TabIndex = 17;
			this.labelX9.Text = "车号：";
			this.labJiHuaLiang.AutoSize = true;
			this.labJiHuaLiang.BackgroundStyle.CornerType = eCornerType.Square;
			this.labJiHuaLiang.Location = new Point(606, 54);
			this.labJiHuaLiang.Name = "labJiHuaLiang";
			this.labJiHuaLiang.Size = new Size(66, 20);
			this.labJiHuaLiang.TabIndex = 16;
			this.labJiHuaLiang.Text = "labelX9";
			this.labelX1.BackgroundStyle.CornerType = eCornerType.Square;
			this.labelX1.Location = new Point(523, 53);
			this.labelX1.Name = "labelX1";
			this.labelX1.Size = new Size(75, 23);
			this.labelX1.TabIndex = 15;
			this.labelX1.Text = "计划量：";
			this.labClientPart.AutoSize = true;
			this.labClientPart.BackgroundStyle.CornerType = eCornerType.Square;
			this.labClientPart.Location = new Point(606, 132);
			this.labClientPart.Name = "labClientPart";
			this.labClientPart.Size = new Size(74, 20);
			this.labClientPart.TabIndex = 14;
			this.labClientPart.Text = "labelX13";
			this.labStatus.AutoSize = true;
			this.labStatus.BackgroundStyle.CornerType = eCornerType.Square;
			this.labStatus.Location = new Point(360, 91);
			this.labStatus.Name = "labStatus";
			this.labStatus.Size = new Size(74, 20);
			this.labStatus.TabIndex = 13;
			this.labStatus.Text = "labelX12";
			this.labProductName.AutoSize = true;
			this.labProductName.BackgroundStyle.CornerType = eCornerType.Square;
			this.labProductName.Location = new Point(603, 14);
			this.labProductName.Name = "labProductName";
			this.labProductName.Size = new Size(74, 20);
			this.labProductName.TabIndex = 12;
			this.labProductName.Text = "labelX11";
			this.labSettlePart.AutoSize = true;
			this.labSettlePart.BackgroundStyle.CornerType = eCornerType.Square;
			this.labSettlePart.Location = new Point(105, 129);
			this.labSettlePart.Name = "labSettlePart";
			this.labSettlePart.Size = new Size(74, 20);
			this.labSettlePart.TabIndex = 11;
			this.labSettlePart.Text = "labelX10";
			this.labBusinessType.AutoSize = true;
			this.labBusinessType.BackgroundStyle.CornerType = eCornerType.Square;
			this.labBusinessType.Location = new Point(105, 90);
			this.labBusinessType.Name = "labBusinessType";
			this.labBusinessType.Size = new Size(66, 20);
			this.labBusinessType.TabIndex = 10;
			this.labBusinessType.Text = "labelX9";
			this.chk.AutoSize = true;
			this.chk.BackgroundStyle.CornerType = eCornerType.Square;
			this.chk.CheckSignSize = new Size(30, 30);
			this.chk.Location = new Point(792, 51);
			this.chk.Name = "chk";
			this.chk.Size = new Size(78, 32);
			this.chk.Style = eDotNetBarStyle.StyleManagerControlled;
			this.chk.TabIndex = 8;
			this.chk.Text = "选择";
			this.chk.CheckedChanged += this.chk_CheckedChanged;
			this.labelX8.BackgroundStyle.CornerType = eCornerType.Square;
			this.labelX8.Location = new Point(523, 131);
			this.labelX8.Name = "labelX8";
			this.labelX8.Size = new Size(75, 23);
			this.labelX8.TabIndex = 7;
			this.labelX8.Text = "收货单位";
			this.labelX7.BackgroundStyle.CornerType = eCornerType.Square;
			this.labelX7.Location = new Point(280, 90);
			this.labelX7.Name = "labelX7";
			this.labelX7.Size = new Size(75, 23);
			this.labelX7.TabIndex = 6;
			this.labelX7.Text = "订单状态";
			this.labelX6.BackgroundStyle.CornerType = eCornerType.Square;
			this.labelX6.Location = new Point(523, 13);
			this.labelX6.Name = "labelX6";
			this.labelX6.Size = new Size(75, 23);
			this.labelX6.TabIndex = 5;
			this.labelX6.Text = "物料";
			this.labelX5.BackgroundStyle.CornerType = eCornerType.Square;
			this.labelX5.Location = new Point(20, 128);
			this.labelX5.Name = "labelX5";
			this.labelX5.Size = new Size(88, 23);
			this.labelX5.TabIndex = 4;
			this.labelX5.Text = "发货单位：";
			this.labelX4.BackgroundStyle.CornerType = eCornerType.Square;
			this.labelX4.Location = new Point(20, 89);
			this.labelX4.Name = "labelX4";
			this.labelX4.Size = new Size(88, 23);
			this.labelX4.TabIndex = 3;
			this.labelX4.Text = "业务类别：";
			this.labelX2.BackgroundStyle.CornerType = eCornerType.Square;
			this.labelX2.Location = new Point(20, 12);
			this.labelX2.Name = "labelX2";
			this.labelX2.Size = new Size(75, 23);
			this.labelX2.TabIndex = 1;
			this.labelX2.Text = "单号：";
			this.labDanHao.AutoSize = true;
			this.labDanHao.BackgroundStyle.CornerType = eCornerType.Square;
			this.labDanHao.Location = new Point(105, 13);
			this.labDanHao.Name = "labDanHao";
			this.labDanHao.Size = new Size(99, 20);
			this.labDanHao.TabIndex = 0;
			this.labDanHao.Text = "10101010101";
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.Controls.Add(this.groupPanel2);
			base.Name = "ATicketControl";
			base.Size = new Size(900, 180);
			this.groupPanel2.ResumeLayout(false);
			this.groupPanel2.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x040004B4 RID: 1204
		public Dictionary<string, object> Model;

		// Token: 0x040004B5 RID: 1205
		public string CheCangNum;

		// Token: 0x040004B7 RID: 1207
		private IContainer components = null;

		// Token: 0x040004B8 RID: 1208
		private GroupPanel groupPanel2;

		// Token: 0x040004B9 RID: 1209
		private CheckBoxX chk;

		// Token: 0x040004BA RID: 1210
		private LabelX labelX8;

		// Token: 0x040004BB RID: 1211
		private LabelX labelX7;

		// Token: 0x040004BC RID: 1212
		private LabelX labelX6;

		// Token: 0x040004BD RID: 1213
		private LabelX labelX5;

		// Token: 0x040004BE RID: 1214
		private LabelX labelX4;

		// Token: 0x040004BF RID: 1215
		private LabelX labelX2;

		// Token: 0x040004C0 RID: 1216
		private LabelX labDanHao;

		// Token: 0x040004C1 RID: 1217
		private LabelX labClientPart;

		// Token: 0x040004C2 RID: 1218
		private LabelX labStatus;

		// Token: 0x040004C3 RID: 1219
		private LabelX labProductName;

		// Token: 0x040004C4 RID: 1220
		private LabelX labSettlePart;

		// Token: 0x040004C5 RID: 1221
		private LabelX labBusinessType;

		// Token: 0x040004C6 RID: 1222
		private LabelX labJiHuaLiang;

		// Token: 0x040004C7 RID: 1223
		private LabelX labelX1;

		// Token: 0x040004C8 RID: 1224
		private LabelX labLisence;

		// Token: 0x040004C9 RID: 1225
		private LabelX labelX9;

		// Token: 0x040004CA RID: 1226
		private LabelX labCangNum;

		// Token: 0x040004CB RID: 1227
		private LabelX labelX10;

		// Token: 0x040004CC RID: 1228
		private LabelX labZhiDanTime;

		// Token: 0x040004CD RID: 1229
		private LabelX labelX11;

		// Token: 0x020000CE RID: 206
		// (Invoke) Token: 0x06000A09 RID: 2569
		public delegate void TicketCheckedChangedHandle(object sender, EventArgs e);
	}
}
