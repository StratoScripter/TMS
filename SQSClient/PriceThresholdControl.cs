using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Base;
using DevComponents.DotNetBar;
using DevComponents.Editors;
using SQSClient.Properties;

namespace SQSClient
{
	// Token: 0x0200009B RID: 155
	public class PriceThresholdControl : UserControl
	{
		// Token: 0x14000004 RID: 4
		// (add) Token: 0x060008B5 RID: 2229 RVA: 0x000D885C File Offset: 0x000D6A5C
		// (remove) Token: 0x060008B6 RID: 2230 RVA: 0x000D8894 File Offset: 0x000D6A94
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public event PriceThresholdControl.AddHandle AddEvent;

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x060008B7 RID: 2231 RVA: 0x000D88CC File Offset: 0x000D6ACC
		// (remove) Token: 0x060008B8 RID: 2232 RVA: 0x000D8904 File Offset: 0x000D6B04
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public event PriceThresholdControl.DeleteHandle DeleteEvent;

		// Token: 0x060008B9 RID: 2233 RVA: 0x000D893C File Offset: 0x000D6B3C
		public PriceThresholdControl()
		{
			this.InitializeComponent();
			this.lblUpperThreshold.Text = ShowWords.ReplaceText(this.lblUpperThreshold.Text);
			this.lblPrice.Text = ShowWords.ReplaceText(this.lblPrice.Text);
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060008BA RID: 2234 RVA: 0x000D8997 File Offset: 0x000D6B97
		// (set) Token: 0x060008BB RID: 2235 RVA: 0x000D89A9 File Offset: 0x000D6BA9
		public decimal UpperThresholdValue
		{
			get
			{
				return Convert.ToDecimal(this.dIntUpperThreshold.Value);
			}
			set
			{
				this.dIntUpperThreshold.Value = Convert.ToDouble(value);
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060008BC RID: 2236 RVA: 0x000D89BE File Offset: 0x000D6BBE
		// (set) Token: 0x060008BD RID: 2237 RVA: 0x000D89D0 File Offset: 0x000D6BD0
		public decimal PriceValue
		{
			get
			{
				return Convert.ToDecimal(this.dIntPrice.Value);
			}
			set
			{
				this.dIntPrice.Value = Convert.ToDouble(value);
			}
		}

		// Token: 0x060008BE RID: 2238 RVA: 0x00003040 File Offset: 0x00001240
		public void LoadData()
		{
		}

		// Token: 0x060008BF RID: 2239 RVA: 0x000D89E8 File Offset: 0x000D6BE8
		private void btnAdd_Click(object sender, EventArgs e)
		{
			bool flag = this.AddEvent != null;
			if (flag)
			{
				try
				{
					this.AddEvent(this, e);
				}
				catch
				{
					this.AddEvent = null;
				}
			}
		}

		// Token: 0x060008C0 RID: 2240 RVA: 0x000D8A34 File Offset: 0x000D6C34
		private void btnDelete_Click(object sender, EventArgs e)
		{
			bool flag = this.DeleteEvent != null;
			if (flag)
			{
				try
				{
					this.DeleteEvent(this, e);
				}
				catch
				{
					this.DeleteEvent = null;
				}
			}
		}

		// Token: 0x060008C1 RID: 2241 RVA: 0x00003040 File Offset: 0x00001240
		public void SaveValue()
		{
		}

		// Token: 0x060008C2 RID: 2242 RVA: 0x000D8A80 File Offset: 0x000D6C80
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060008C3 RID: 2243 RVA: 0x000D8AB8 File Offset: 0x000D6CB8
		private void InitializeComponent()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(PriceThresholdControl));
			this.lblUpperThreshold = new Label();
			this.lblPrice = new Label();
			this.btnDelete = new ButtonX();
			this.btnAddRd = new ButtonItem();
			this.dIntUpperThreshold = new DoubleInput();
			this.dIntPrice = new DoubleInput();
			((ISupportInitialize)this.dIntUpperThreshold).BeginInit();
			((ISupportInitialize)this.dIntPrice).BeginInit();
			base.SuspendLayout();
			this.lblUpperThreshold.AutoSize = true;
			this.lblUpperThreshold.Location = new Point(4, 5);
			this.lblUpperThreshold.Name = "lblUpperThreshold";
			this.lblUpperThreshold.Size = new Size(89, 12);
			this.lblUpperThreshold.TabIndex = 8;
			this.lblUpperThreshold.Text = "UpperThreshold";
			this.lblPrice.AutoSize = true;
			this.lblPrice.Location = new Point(184, 5);
			this.lblPrice.Name = "lblPrice";
			this.lblPrice.Size = new Size(47, 12);
			this.lblPrice.TabIndex = 9;
			this.lblPrice.Text = "PriceKg";
			this.btnDelete.AccessibleRole = AccessibleRole.PushButton;
			this.btnDelete.BackColor = Color.Transparent;
			this.btnDelete.ColorTable = eButtonColor.Orange;
			this.btnDelete.Image = (Image)componentResourceManager.GetObject("btnDelete.Image");
			this.btnDelete.Location = new Point(357, 1);
			this.btnDelete.Margin = new System.Windows.Forms.Padding(0);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new Size(23, 23);
			this.btnDelete.Style = eDotNetBarStyle.StyleManagerControlled;
			this.btnDelete.TabIndex = 4;
			this.btnDelete.Click += this.btnDelete_Click;
			this.btnAddRd.ButtonStyle = eButtonStyle.ImageAndText;
			this.btnAddRd.Image = Resources.add16;
			this.btnAddRd.Name = "btnAddRd";
			this.btnAddRd.Text = "Add";
			this.dIntUpperThreshold.BackgroundStyle.Class = "DateTimeInputBackground";
			this.dIntUpperThreshold.BackgroundStyle.CornerType = eCornerType.Square;
			this.dIntUpperThreshold.ButtonFreeText.Shortcut = eShortcut.F2;
			this.dIntUpperThreshold.Increment = 1.0;
			this.dIntUpperThreshold.Location = new Point(79, 1);
			this.dIntUpperThreshold.Margin = new System.Windows.Forms.Padding(0);
			this.dIntUpperThreshold.Name = "dIntUpperThreshold";
			this.dIntUpperThreshold.ShowUpDown = true;
			this.dIntUpperThreshold.Size = new Size(92, 21);
			this.dIntUpperThreshold.TabIndex = 10;
			this.dIntPrice.BackgroundStyle.Class = "DateTimeInputBackground";
			this.dIntPrice.BackgroundStyle.CornerType = eCornerType.Square;
			this.dIntPrice.ButtonFreeText.Shortcut = eShortcut.F2;
			this.dIntPrice.Increment = 1.0;
			this.dIntPrice.Location = new Point(260, 1);
			this.dIntPrice.Margin = new System.Windows.Forms.Padding(0);
			this.dIntPrice.Name = "dIntPrice";
			this.dIntPrice.ShowUpDown = true;
			this.dIntPrice.Size = new Size(92, 21);
			this.dIntPrice.TabIndex = 11;
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(194, 217, 247);
			base.Controls.Add(this.dIntPrice);
			base.Controls.Add(this.dIntUpperThreshold);
			base.Controls.Add(this.lblPrice);
			base.Controls.Add(this.lblUpperThreshold);
			base.Controls.Add(this.btnDelete);
			base.Name = "PriceThresholdControl";
			base.Size = new Size(388, 25);
			((ISupportInitialize)this.dIntUpperThreshold).EndInit();
			((ISupportInitialize)this.dIntPrice).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000F17 RID: 3863
		private IContainer components = null;

		// Token: 0x04000F18 RID: 3864
		private ButtonX btnDelete;

		// Token: 0x04000F19 RID: 3865
		private ButtonItem btnAddRd;

		// Token: 0x04000F1A RID: 3866
		private Label lblUpperThreshold;

		// Token: 0x04000F1B RID: 3867
		private Label lblPrice;

		// Token: 0x04000F1C RID: 3868
		private DoubleInput dIntUpperThreshold;

		// Token: 0x04000F1D RID: 3869
		private DoubleInput dIntPrice;

		// Token: 0x020000F2 RID: 242
		// (Invoke) Token: 0x06000A76 RID: 2678
		public delegate void AddHandle(object sender, EventArgs e);

		// Token: 0x020000F3 RID: 243
		// (Invoke) Token: 0x06000A7A RID: 2682
		public delegate void DeleteHandle(object sender, EventArgs e);
	}
}
