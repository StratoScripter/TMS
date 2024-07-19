using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Assistant;
using Base;
using DAL.Base.SQSConfig;
using DevComponents.DotNetBar;
using DevComponents.Editors;
using Model;
using Model.SQSConfig;
using SQSClient.Properties;

namespace SQSClient
{
	// Token: 0x020000A2 RID: 162
	public class TicketHouseControl : UserControl
	{
		// Token: 0x1400000D RID: 13
		// (add) Token: 0x060008FF RID: 2303 RVA: 0x000DADF4 File Offset: 0x000D8FF4
		// (remove) Token: 0x06000900 RID: 2304 RVA: 0x000DAE2C File Offset: 0x000D902C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public event TicketHouseControl.AddHandle AddEvent;

		// Token: 0x1400000E RID: 14
		// (add) Token: 0x06000901 RID: 2305 RVA: 0x000DAE64 File Offset: 0x000D9064
		// (remove) Token: 0x06000902 RID: 2306 RVA: 0x000DAE9C File Offset: 0x000D909C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public event TicketHouseControl.DeleteHandle DeleteEvent;

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000903 RID: 2307 RVA: 0x000DAED4 File Offset: 0x000D90D4
		// (set) Token: 0x06000904 RID: 2308 RVA: 0x000DAF06 File Offset: 0x000D9106
		public ModT_ticketbatch TicketBatch
		{
			get
			{
				bool flag = this._ModTicketBatch == null;
				if (flag)
				{
					this._ModTicketBatch = new ModT_ticketbatch();
				}
				return this._ModTicketBatch;
			}
			set
			{
				this._ModTicketBatch = value;
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x06000905 RID: 2309 RVA: 0x000DAF10 File Offset: 0x000D9110
		// (set) Token: 0x06000906 RID: 2310 RVA: 0x000DAF28 File Offset: 0x000D9128
		public bool IsEdit
		{
			get
			{
				return this._IsEdit;
			}
			set
			{
				this._IsEdit = value;
			}
		}

		// Token: 0x06000907 RID: 2311 RVA: 0x000DAF34 File Offset: 0x000D9134
		public TicketHouseControl()
		{
			this.InitializeComponent();
			this.lblDanHaoHouse.Text = ShowWords.ReplaceText(this.lblDanHaoHouse.Text);
			this.lblJiHuaLiang.Text = ShowWords.ReplaceText(this.lblJiHuaLiang.Text);
			this.lblShiZhuangLiang.Text = ShowWords.ReplaceText(this.lblShiZhuangLiang.Text);
			this.lblStatus.Text = ShowWords.ReplaceText(this.lblStatus.Text);
		}

		// Token: 0x06000908 RID: 2312 RVA: 0x000DAFD0 File Offset: 0x000D91D0
		public void LoadData()
		{
			this.tbxBatchCode.Text = this.TicketBatch.BatchCode;
			this.dInputQuantityBatch.Value = Convert.ToDouble(this.TicketBatch.QuantityBatch);
			this.dInputNumBatch.Value = Convert.ToDouble(this.TicketBatch.NumBatch);
			this.tbxBatchStatus.Text = ShowWords.ReplaceText(EnumHelper.GetDescription<TicketStatus>((TicketStatus)this.TicketBatch.BatchStatus));
			this.dInputQuantityBatch.Enabled = this.IsEdit;
			this.btnDelete.Enabled = this.IsEdit;
		}

		// Token: 0x06000909 RID: 2313 RVA: 0x000DB074 File Offset: 0x000D9274
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

		// Token: 0x0600090A RID: 2314 RVA: 0x000DB0C0 File Offset: 0x000D92C0
		private void btnDelete_Click(object sender, EventArgs e)
		{
			DalT_ticketbatch.Instance.Delete(this.TicketBatch.Id);
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

		// Token: 0x0600090B RID: 2315 RVA: 0x000DB124 File Offset: 0x000D9324
		public ModT_ticketbatch SaveValue()
		{
			this.TicketBatch.BatchCode = this.tbxBatchCode.Text.Trim();
			this.TicketBatch.QuantityBatch = Convert.ToDecimal(this.dInputQuantityBatch.Value);
			DalT_ticketbatch.Instance.Update(this.TicketBatch);
			return this.TicketBatch;
		}

		// Token: 0x0600090C RID: 2316 RVA: 0x000DB188 File Offset: 0x000D9388
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600090D RID: 2317 RVA: 0x000DB1C0 File Offset: 0x000D93C0
		private void InitializeComponent()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(TicketHouseControl));
			this.dInputQuantityBatch = new DoubleInput();
			this.tbxBatchCode = new TextBox();
			this.lblDanHaoHouse = new Label();
			this.lblJiHuaLiang = new Label();
			this.lblShiZhuangLiang = new Label();
			this.btnDelete = new ButtonX();
			this.btnAddRd = new ButtonItem();
			this.dInputNumBatch = new DoubleInput();
			this.tbxBatchStatus = new TextBox();
			this.lblStatus = new Label();
			((ISupportInitialize)this.dInputQuantityBatch).BeginInit();
			((ISupportInitialize)this.dInputNumBatch).BeginInit();
			base.SuspendLayout();
			this.dInputQuantityBatch.BackgroundStyle.Class = "DateTimeInputBackground";
			this.dInputQuantityBatch.BackgroundStyle.CornerType = eCornerType.Square;
			this.dInputQuantityBatch.ButtonFreeText.Shortcut = eShortcut.F2;
			this.dInputQuantityBatch.DisplayFormat = "0.0";
			this.dInputQuantityBatch.Increment = 1.0;
			this.dInputQuantityBatch.InputHorizontalAlignment = eHorizontalAlignment.Left;
			this.dInputQuantityBatch.Location = new Point(239, 1);
			this.dInputQuantityBatch.MaxValue = 100000.0;
			this.dInputQuantityBatch.MinValue = 0.0;
			this.dInputQuantityBatch.Name = "dInputQuantityBatch";
			this.dInputQuantityBatch.ShowUpDown = true;
			this.dInputQuantityBatch.Size = new Size(89, 21);
			this.dInputQuantityBatch.TabIndex = 5;
			this.tbxBatchCode.Location = new Point(68, 1);
			this.tbxBatchCode.Name = "tbxBatchCode";
			this.tbxBatchCode.ReadOnly = true;
			this.tbxBatchCode.Size = new Size(112, 21);
			this.tbxBatchCode.TabIndex = 7;
			this.lblDanHaoHouse.AutoSize = true;
			this.lblDanHaoHouse.Location = new Point(4, 5);
			this.lblDanHaoHouse.Name = "lblDanHaoHouse";
			this.lblDanHaoHouse.Size = new Size(71, 12);
			this.lblDanHaoHouse.TabIndex = 8;
			this.lblDanHaoHouse.Text = "DanHaoHouse";
			this.lblJiHuaLiang.AutoSize = true;
			this.lblJiHuaLiang.Location = new Point(185, 5);
			this.lblJiHuaLiang.Name = "lblJiHuaLiang";
			this.lblJiHuaLiang.Size = new Size(65, 12);
			this.lblJiHuaLiang.TabIndex = 9;
			this.lblJiHuaLiang.Text = "JiHuaLiang";
			this.lblShiZhuangLiang.AutoSize = true;
			this.lblShiZhuangLiang.Location = new Point(336, 5);
			this.lblShiZhuangLiang.Name = "lblShiZhuangLiang";
			this.lblShiZhuangLiang.Size = new Size(89, 12);
			this.lblShiZhuangLiang.TabIndex = 12;
			this.lblShiZhuangLiang.Text = "ShiZhuangLiang";
			this.btnDelete.AccessibleRole = AccessibleRole.PushButton;
			this.btnDelete.BackColor = Color.Transparent;
			this.btnDelete.ColorTable = eButtonColor.Orange;
			this.btnDelete.Image = (Image)componentResourceManager.GetObject("btnDelete.Image");
			this.btnDelete.Location = new Point(605, 0);
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
			this.dInputNumBatch.BackgroundStyle.Class = "DateTimeInputBackground";
			this.dInputNumBatch.BackgroundStyle.CornerType = eCornerType.Square;
			this.dInputNumBatch.ButtonFreeText.Shortcut = eShortcut.F2;
			this.dInputNumBatch.DisplayFormat = "0.0";
			this.dInputNumBatch.Enabled = false;
			this.dInputNumBatch.Increment = 1.0;
			this.dInputNumBatch.InputHorizontalAlignment = eHorizontalAlignment.Left;
			this.dInputNumBatch.Location = new Point(386, 1);
			this.dInputNumBatch.MaxValue = 100000.0;
			this.dInputNumBatch.MinValue = 0.0;
			this.dInputNumBatch.Name = "dInputNumBatch";
			this.dInputNumBatch.ShowUpDown = true;
			this.dInputNumBatch.Size = new Size(89, 21);
			this.dInputNumBatch.TabIndex = 14;
			this.tbxBatchStatus.Location = new Point(519, 1);
			this.tbxBatchStatus.Name = "tbxBatchStatus";
			this.tbxBatchStatus.ReadOnly = true;
			this.tbxBatchStatus.Size = new Size(80, 21);
			this.tbxBatchStatus.TabIndex = 15;
			this.lblStatus.AutoSize = true;
			this.lblStatus.Location = new Point(478, 6);
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new Size(41, 12);
			this.lblStatus.TabIndex = 16;
			this.lblStatus.Text = "Status";
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(194, 217, 247);
			base.Controls.Add(this.lblStatus);
			base.Controls.Add(this.tbxBatchStatus);
			base.Controls.Add(this.dInputNumBatch);
			base.Controls.Add(this.lblShiZhuangLiang);
			base.Controls.Add(this.lblDanHaoHouse);
			base.Controls.Add(this.tbxBatchCode);
			base.Controls.Add(this.dInputQuantityBatch);
			base.Controls.Add(this.btnDelete);
			base.Controls.Add(this.lblJiHuaLiang);
			base.Name = "TicketHouseControl";
			base.Size = new Size(633, 25);
			((ISupportInitialize)this.dInputQuantityBatch).EndInit();
			((ISupportInitialize)this.dInputNumBatch).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000F4A RID: 3914
		private ModT_ticketbatch _ModTicketBatch = null;

		// Token: 0x04000F4B RID: 3915
		private bool _IsEdit;

		// Token: 0x04000F4C RID: 3916
		private IContainer components = null;

		// Token: 0x04000F4D RID: 3917
		private ButtonX btnDelete;

		// Token: 0x04000F4E RID: 3918
		private DoubleInput dInputQuantityBatch;

		// Token: 0x04000F4F RID: 3919
		private ButtonItem btnAddRd;

		// Token: 0x04000F50 RID: 3920
		private TextBox tbxBatchCode;

		// Token: 0x04000F51 RID: 3921
		private Label lblDanHaoHouse;

		// Token: 0x04000F52 RID: 3922
		private Label lblJiHuaLiang;

		// Token: 0x04000F53 RID: 3923
		private Label lblShiZhuangLiang;

		// Token: 0x04000F54 RID: 3924
		private DoubleInput dInputNumBatch;

		// Token: 0x04000F55 RID: 3925
		private TextBox tbxBatchStatus;

		// Token: 0x04000F56 RID: 3926
		private Label lblStatus;

		// Token: 0x020000FB RID: 251
		// (Invoke) Token: 0x06000A9A RID: 2714
		public delegate void AddHandle(object sender, EventArgs e);

		// Token: 0x020000FC RID: 252
		// (Invoke) Token: 0x06000A9E RID: 2718
		public delegate void DeleteHandle(object sender, EventArgs e);
	}
}
