using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Base;
using DAL.Base.SQSConfig;
using DevComponents.DotNetBar;
using DevComponents.Editors;
using Model.SQSConfig;
using SQSClient.Properties;

namespace SQSClient
{
	// Token: 0x020000A1 RID: 161
	public class TicketBatchControl : UserControl
	{
		// Token: 0x1400000B RID: 11
		// (add) Token: 0x060008F1 RID: 2289 RVA: 0x000DA458 File Offset: 0x000D8658
		// (remove) Token: 0x060008F2 RID: 2290 RVA: 0x000DA490 File Offset: 0x000D8690
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public event TicketBatchControl.AddHandle AddEvent;

		// Token: 0x1400000C RID: 12
		// (add) Token: 0x060008F3 RID: 2291 RVA: 0x000DA4C8 File Offset: 0x000D86C8
		// (remove) Token: 0x060008F4 RID: 2292 RVA: 0x000DA500 File Offset: 0x000D8700
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public event TicketBatchControl.DeleteHandle DeleteEvent;

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x060008F5 RID: 2293 RVA: 0x000DA538 File Offset: 0x000D8738
		// (set) Token: 0x060008F6 RID: 2294 RVA: 0x000DA56A File Offset: 0x000D876A
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

		// Token: 0x060008F7 RID: 2295 RVA: 0x000DA574 File Offset: 0x000D8774
		public TicketBatchControl()
		{
			this.InitializeComponent();
			this.lblBatchCode.Text = ShowWords.ReplaceText(this.lblBatchCode.Text);
			this.lblQuantityBatch.Text = ShowWords.ReplaceText(this.lblQuantityBatch.Text);
			this.lblExtBatchCode.Text = ShowWords.ReplaceText(this.lblExtBatchCode.Text);
		}

		// Token: 0x060008F8 RID: 2296 RVA: 0x000DA5F4 File Offset: 0x000D87F4
		public void LoadData()
		{
			this.tbxBatchCode.Text = this.TicketBatch.BatchCode;
			this.dInputQuantityBatch.Value = Convert.ToDouble(this.TicketBatch.QuantityBatch);
			this.tbxExtBatchCode.Text = this.TicketBatch.ExtBatchCode;
		}

		// Token: 0x060008F9 RID: 2297 RVA: 0x000DA64C File Offset: 0x000D884C
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

		// Token: 0x060008FA RID: 2298 RVA: 0x000DA698 File Offset: 0x000D8898
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

		// Token: 0x060008FB RID: 2299 RVA: 0x000DA6FC File Offset: 0x000D88FC
		public void SaveValue()
		{
			this.TicketBatch.BatchCode = this.tbxBatchCode.Text.Trim();
			this.TicketBatch.QuantityBatch = Convert.ToDecimal(this.dInputQuantityBatch.Value);
			this.TicketBatch.ExtBatchCode = this.tbxExtBatchCode.Text.Trim();
			DalT_ticketbatch.Instance.Update(this.TicketBatch);
		}

		// Token: 0x060008FC RID: 2300 RVA: 0x000DA770 File Offset: 0x000D8970
		private void btnBatchCode_Click(object sender, EventArgs e)
		{
			frmQRCodeShow frmQRCodeShow = new frmQRCodeShow(this.tbxBatchCode.Text.Trim());
			bool flag = frmQRCodeShow.ShowDialog() == DialogResult.Yes;
			if (flag)
			{
			}
		}

		// Token: 0x060008FD RID: 2301 RVA: 0x000DA7A4 File Offset: 0x000D89A4
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060008FE RID: 2302 RVA: 0x000DA7DC File Offset: 0x000D89DC
		private void InitializeComponent()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(TicketBatchControl));
			this.dInputQuantityBatch = new DoubleInput();
			this.tbxBatchCode = new TextBox();
			this.lblBatchCode = new Label();
			this.lblQuantityBatch = new Label();
			this.tbxExtBatchCode = new TextBox();
			this.lblExtBatchCode = new Label();
			this.btnBatchCode = new ButtonX();
			this.btnDelete = new ButtonX();
			this.btnAddRd = new ButtonItem();
			((ISupportInitialize)this.dInputQuantityBatch).BeginInit();
			base.SuspendLayout();
			this.dInputQuantityBatch.BackgroundStyle.Class = "DateTimeInputBackground";
			this.dInputQuantityBatch.BackgroundStyle.CornerType = eCornerType.Square;
			this.dInputQuantityBatch.ButtonFreeText.Shortcut = eShortcut.F2;
			this.dInputQuantityBatch.DisplayFormat = "0.0";
			this.dInputQuantityBatch.Increment = 1.0;
			this.dInputQuantityBatch.InputHorizontalAlignment = eHorizontalAlignment.Left;
			this.dInputQuantityBatch.Location = new Point(273, 1);
			this.dInputQuantityBatch.MaxValue = 100000.0;
			this.dInputQuantityBatch.MinValue = 0.0;
			this.dInputQuantityBatch.Name = "dInputQuantityBatch";
			this.dInputQuantityBatch.ShowUpDown = true;
			this.dInputQuantityBatch.Size = new Size(89, 21);
			this.dInputQuantityBatch.TabIndex = 5;
			this.tbxBatchCode.Location = new Point(68, 1);
			this.tbxBatchCode.Name = "tbxBatchCode";
			this.tbxBatchCode.Size = new Size(112, 21);
			this.tbxBatchCode.TabIndex = 7;
			this.lblBatchCode.AutoSize = true;
			this.lblBatchCode.Location = new Point(4, 5);
			this.lblBatchCode.Name = "lblBatchCode";
			this.lblBatchCode.Size = new Size(59, 12);
			this.lblBatchCode.TabIndex = 8;
			this.lblBatchCode.Text = "BatchCode";
			this.lblQuantityBatch.AutoSize = true;
			this.lblQuantityBatch.Location = new Point(209, 5);
			this.lblQuantityBatch.Name = "lblQuantityBatch";
			this.lblQuantityBatch.Size = new Size(83, 12);
			this.lblQuantityBatch.TabIndex = 9;
			this.lblQuantityBatch.Text = "QuantityBatch";
			this.tbxExtBatchCode.Location = new Point(439, 1);
			this.tbxExtBatchCode.Name = "tbxExtBatchCode";
			this.tbxExtBatchCode.Size = new Size(112, 21);
			this.tbxExtBatchCode.TabIndex = 11;
			this.lblExtBatchCode.AutoSize = true;
			this.lblExtBatchCode.Location = new Point(368, 5);
			this.lblExtBatchCode.Name = "lblExtBatchCode";
			this.lblExtBatchCode.Size = new Size(77, 12);
			this.lblExtBatchCode.TabIndex = 12;
			this.lblExtBatchCode.Text = "ExtBatchCode";
			this.btnBatchCode.AccessibleRole = AccessibleRole.PushButton;
			this.btnBatchCode.BackColor = Color.Transparent;
			this.btnBatchCode.ColorTable = eButtonColor.Orange;
			this.btnBatchCode.Image = Resources.hisdata16;
			this.btnBatchCode.Location = new Point(184, 0);
			this.btnBatchCode.Margin = new System.Windows.Forms.Padding(0);
			this.btnBatchCode.Name = "btnBatchCode";
			this.btnBatchCode.Size = new Size(23, 23);
			this.btnBatchCode.Style = eDotNetBarStyle.StyleManagerControlled;
			this.btnBatchCode.TabIndex = 13;
			this.btnBatchCode.Click += this.btnBatchCode_Click;
			this.btnDelete.AccessibleRole = AccessibleRole.PushButton;
			this.btnDelete.BackColor = Color.Transparent;
			this.btnDelete.ColorTable = eButtonColor.Orange;
			this.btnDelete.Image = (Image)componentResourceManager.GetObject("btnDelete.Image");
			this.btnDelete.Location = new Point(552, 0);
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
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(194, 217, 247);
			base.Controls.Add(this.btnBatchCode);
			base.Controls.Add(this.lblExtBatchCode);
			base.Controls.Add(this.tbxExtBatchCode);
			base.Controls.Add(this.lblQuantityBatch);
			base.Controls.Add(this.lblBatchCode);
			base.Controls.Add(this.tbxBatchCode);
			base.Controls.Add(this.dInputQuantityBatch);
			base.Controls.Add(this.btnDelete);
			base.Name = "TicketBatchControl";
			base.Size = new Size(583, 23);
			((ISupportInitialize)this.dInputQuantityBatch).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000F3D RID: 3901
		private ModT_ticketbatch _ModTicketBatch = null;

		// Token: 0x04000F3E RID: 3902
		private IContainer components = null;

		// Token: 0x04000F3F RID: 3903
		private ButtonX btnDelete;

		// Token: 0x04000F40 RID: 3904
		private DoubleInput dInputQuantityBatch;

		// Token: 0x04000F41 RID: 3905
		private ButtonItem btnAddRd;

		// Token: 0x04000F42 RID: 3906
		private TextBox tbxBatchCode;

		// Token: 0x04000F43 RID: 3907
		private Label lblBatchCode;

		// Token: 0x04000F44 RID: 3908
		private Label lblQuantityBatch;

		// Token: 0x04000F45 RID: 3909
		private TextBox tbxExtBatchCode;

		// Token: 0x04000F46 RID: 3910
		private Label lblExtBatchCode;

		// Token: 0x04000F47 RID: 3911
		private ButtonX btnBatchCode;

		// Token: 0x020000F9 RID: 249
		// (Invoke) Token: 0x06000A92 RID: 2706
		public delegate void AddHandle(object sender, EventArgs e);

		// Token: 0x020000FA RID: 250
		// (Invoke) Token: 0x06000A96 RID: 2710
		public delegate void DeleteHandle(object sender, EventArgs e);
	}
}
