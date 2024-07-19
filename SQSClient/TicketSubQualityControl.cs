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
	// Token: 0x020000A3 RID: 163
	public class TicketSubQualityControl : UserControl
	{
		// Token: 0x1400000F RID: 15
		// (add) Token: 0x0600090E RID: 2318 RVA: 0x000DB8D0 File Offset: 0x000D9AD0
		// (remove) Token: 0x0600090F RID: 2319 RVA: 0x000DB908 File Offset: 0x000D9B08
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public event TicketSubQualityControl.AddHandle AddEvent;

		// Token: 0x14000010 RID: 16
		// (add) Token: 0x06000910 RID: 2320 RVA: 0x000DB940 File Offset: 0x000D9B40
		// (remove) Token: 0x06000911 RID: 2321 RVA: 0x000DB978 File Offset: 0x000D9B78
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public event TicketSubQualityControl.NumBatchHandle NumBatchEvent;

		// Token: 0x14000011 RID: 17
		// (add) Token: 0x06000912 RID: 2322 RVA: 0x000DB9B0 File Offset: 0x000D9BB0
		// (remove) Token: 0x06000913 RID: 2323 RVA: 0x000DB9E8 File Offset: 0x000D9BE8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public event TicketSubQualityControl.DeleteHandle DeleteEvent;

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000914 RID: 2324 RVA: 0x000DBA20 File Offset: 0x000D9C20
		// (set) Token: 0x06000915 RID: 2325 RVA: 0x000DBA52 File Offset: 0x000D9C52
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

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000916 RID: 2326 RVA: 0x000DBA5C File Offset: 0x000D9C5C
		// (set) Token: 0x06000917 RID: 2327 RVA: 0x000DBA74 File Offset: 0x000D9C74
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

		// Token: 0x06000918 RID: 2328 RVA: 0x000DBA80 File Offset: 0x000D9C80
		public TicketSubQualityControl()
		{
			this.InitializeComponent();
			this.lblDanHao.Text = ShowWords.ReplaceText(this.lblDanHao.Text);
			this.lblWeightDiff.Text = ShowWords.ReplaceText(this.lblWeightDiff.Text);
			this.lblWeightConv.Text = ShowWords.ReplaceText(this.lblWeightConv.Text);
			this.lblInitialValue.Text = ShowWords.ReplaceText(this.lblInitialValue.Text);
			this.lblConvRate.Text = ShowWords.ReplaceText(this.lblConvRate.Text);
			this.lblFinalValue.Text = ShowWords.ReplaceText(this.lblFinalValue.Text);
			this.dInputQuantityBatch.IsInputReadOnly = true;
			this.dInputNumBatch.IsInputReadOnly = true;
			this.dInputQuantityBatch.MouseWheel += this.Num_DiscountAmount_MouseWheel;
			this.dInputNumBatch.MouseWheel += this.Num_DiscountAmount_MouseWheel;
		}

		// Token: 0x06000919 RID: 2329 RVA: 0x000DBB9C File Offset: 0x000D9D9C
		public void LoadData()
		{
			this.tbxBatchCode.Text = this.TicketBatch.BatchCode;
			this.dInputQuantityBatch.Value = Convert.ToDouble(this.TicketBatch.QuantityBatch);
			this.dInputNumBatch.Value = Convert.ToDouble(this.TicketBatch.NumBatch);
			this.dInputConvRate.Value = Convert.ToDouble(this.TicketBatch.BatchLabResult) / 100.0;
			this.tbxInitialValue.Text = this.TicketBatch.Free1;
			this.tbxInitialTime.Text = this.TicketBatch.Free2;
			this.tbxFinalValue.Text = this.TicketBatch.Free3;
			this.tbxFinalTime.Text = this.TicketBatch.Free4;
			this.dInputQuantityBatch.IsInputReadOnly = true;
			this.dInputNumBatch.IsInputReadOnly = true;
			this.dInputQuantityBatch.Enabled = this.IsEdit;
			this.btnDelete.Enabled = this.IsEdit;
		}

		// Token: 0x0600091A RID: 2330 RVA: 0x000DBCBC File Offset: 0x000D9EBC
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

		// Token: 0x0600091B RID: 2331 RVA: 0x000DBD08 File Offset: 0x000D9F08
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

		// Token: 0x0600091C RID: 2332 RVA: 0x000DBD6C File Offset: 0x000D9F6C
		public ModT_ticketbatch SaveValue()
		{
			this.TicketBatch.NumBatch = Convert.ToDecimal(this.dInputNumBatch.Value);
			this.TicketBatch.BatchLabResult = Convert.ToInt32(this.dInputConvRate.Value * 100.0);
			DalT_ticketbatch.Instance.Update(this.TicketBatch);
			return this.TicketBatch;
		}

		// Token: 0x0600091D RID: 2333 RVA: 0x000DBDD8 File Offset: 0x000D9FD8
		public string GetWeightDetails()
		{
			string str = string.Empty;
			str = ShowWords.ReplaceText("WeightFront") + this.tbxInitialValue.Text + ";";
			str = str + ShowWords.ReplaceText("WeightAfter") + this.tbxFinalValue.Text + ";";
			return str + ShowWords.ReplaceText("WeightDiff") + this.dInputQuantityBatch.Value.ToString("F0") + ";";
		}

		// Token: 0x0600091E RID: 2334 RVA: 0x000DBE60 File Offset: 0x000DA060
		private void Num_DiscountAmount_MouseWheel(object sender, MouseEventArgs e)
		{
			HandledMouseEventArgs handledMouseEventArgs = e as HandledMouseEventArgs;
			bool flag = handledMouseEventArgs != null;
			if (flag)
			{
				handledMouseEventArgs.Handled = true;
			}
		}

		// Token: 0x0600091F RID: 2335 RVA: 0x000DBE88 File Offset: 0x000DA088
		private void dInputConvRate_ValueChanged(object sender, EventArgs e)
		{
			this.dInputNumBatch.Value = this.dInputQuantityBatch.Value * this.dInputConvRate.Value / 100.0;
			this.TicketBatch.NumBatch = Convert.ToDecimal(this.dInputNumBatch.Value);
			bool flag = this.NumBatchEvent != null;
			if (flag)
			{
				try
				{
					this.NumBatchEvent(this, e);
				}
				catch
				{
					this.NumBatchEvent = null;
				}
			}
		}

		// Token: 0x06000920 RID: 2336 RVA: 0x000DBF1C File Offset: 0x000DA11C
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000921 RID: 2337 RVA: 0x000DBF54 File Offset: 0x000DA154
		private void InitializeComponent()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(TicketSubQualityControl));
			this.dInputQuantityBatch = new DoubleInput();
			this.tbxBatchCode = new TextBox();
			this.lblDanHao = new Label();
			this.lblWeightDiff = new Label();
			this.lblWeightConv = new Label();
			this.btnDelete = new ButtonX();
			this.btnAddRd = new ButtonItem();
			this.dInputNumBatch = new DoubleInput();
			this.tbxInitialValue = new TextBox();
			this.lblInitialValue = new Label();
			this.tbxFinalValue = new TextBox();
			this.lblFinalValue = new Label();
			this.dInputConvRate = new DoubleInput();
			this.tbxInitialTime = new TextBox();
			this.tbxFinalTime = new TextBox();
			this.lblConvRate = new Label();
			((ISupportInitialize)this.dInputQuantityBatch).BeginInit();
			((ISupportInitialize)this.dInputNumBatch).BeginInit();
			((ISupportInitialize)this.dInputConvRate).BeginInit();
			base.SuspendLayout();
			this.dInputQuantityBatch.BackgroundStyle.Class = "DateTimeInputBackground";
			this.dInputQuantityBatch.BackgroundStyle.CornerType = eCornerType.Square;
			this.dInputQuantityBatch.ButtonFreeText.Shortcut = eShortcut.F2;
			this.dInputQuantityBatch.DisplayFormat = "0.0";
			this.dInputQuantityBatch.Increment = 1E-07;
			this.dInputQuantityBatch.InputHorizontalAlignment = eHorizontalAlignment.Left;
			this.dInputQuantityBatch.Location = new Point(239, 1);
			this.dInputQuantityBatch.MaxValue = 100000.0;
			this.dInputQuantityBatch.MinValue = 0.0;
			this.dInputQuantityBatch.Name = "dInputQuantityBatch";
			this.dInputQuantityBatch.ShowUpDown = true;
			this.dInputQuantityBatch.Size = new Size(100, 21);
			this.dInputQuantityBatch.TabIndex = 5;
			this.tbxBatchCode.Location = new Point(51, 1);
			this.tbxBatchCode.Name = "tbxBatchCode";
			this.tbxBatchCode.ReadOnly = true;
			this.tbxBatchCode.Size = new Size(117, 21);
			this.tbxBatchCode.TabIndex = 7;
			this.lblDanHao.AutoSize = true;
			this.lblDanHao.Location = new Point(4, 5);
			this.lblDanHao.Name = "lblDanHao";
			this.lblDanHao.Size = new Size(41, 12);
			this.lblDanHao.TabIndex = 8;
			this.lblDanHao.Text = "DanHao";
			this.lblWeightDiff.AutoSize = true;
			this.lblWeightDiff.Location = new Point(185, 5);
			this.lblWeightDiff.Name = "lblWeightDiff";
			this.lblWeightDiff.Size = new Size(65, 12);
			this.lblWeightDiff.TabIndex = 9;
			this.lblWeightDiff.Text = "WeightDiff";
			this.lblWeightConv.AutoSize = true;
			this.lblWeightConv.Location = new Point(360, 5);
			this.lblWeightConv.Name = "lblWeightConv";
			this.lblWeightConv.Size = new Size(65, 12);
			this.lblWeightConv.TabIndex = 12;
			this.lblWeightConv.Text = "WeightConv";
			this.btnDelete.AccessibleRole = AccessibleRole.PushButton;
			this.btnDelete.BackColor = Color.Transparent;
			this.btnDelete.ColorTable = eButtonColor.Orange;
			this.btnDelete.Image = (Image)componentResourceManager.GetObject("btnDelete.Image");
			this.btnDelete.Location = new Point(696, 14);
			this.btnDelete.Margin = new System.Windows.Forms.Padding(0);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new Size(36, 36);
			this.btnDelete.Style = eDotNetBarStyle.StyleManagerControlled;
			this.btnDelete.TabIndex = 4;
			this.btnDelete.Visible = false;
			this.btnDelete.Click += this.btnDelete_Click;
			this.btnAddRd.ButtonStyle = eButtonStyle.ImageAndText;
			this.btnAddRd.Image = Resources.add16;
			this.btnAddRd.Name = "btnAddRd";
			this.btnAddRd.Text = "Add";
			this.dInputNumBatch.BackgroundStyle.Class = "DateTimeInputBackground";
			this.dInputNumBatch.BackgroundStyle.CornerType = eCornerType.Square;
			this.dInputNumBatch.ButtonFreeText.Shortcut = eShortcut.F2;
			this.dInputNumBatch.DisplayFormat = "0.0";
			this.dInputNumBatch.Increment = 1E-07;
			this.dInputNumBatch.InputHorizontalAlignment = eHorizontalAlignment.Left;
			this.dInputNumBatch.Location = new Point(417, 1);
			this.dInputNumBatch.MaxValue = 100000.0;
			this.dInputNumBatch.MinValue = 0.0;
			this.dInputNumBatch.Name = "dInputNumBatch";
			this.dInputNumBatch.ShowUpDown = true;
			this.dInputNumBatch.Size = new Size(100, 21);
			this.dInputNumBatch.TabIndex = 14;
			this.tbxInitialValue.Location = new Point(68, 34);
			this.tbxInitialValue.Name = "tbxInitialValue";
			this.tbxInitialValue.ReadOnly = true;
			this.tbxInitialValue.Size = new Size(100, 21);
			this.tbxInitialValue.TabIndex = 15;
			this.lblInitialValue.AutoSize = true;
			this.lblInitialValue.Location = new Point(16, 38);
			this.lblInitialValue.Name = "lblInitialValue";
			this.lblInitialValue.Size = new Size(77, 12);
			this.lblInitialValue.TabIndex = 16;
			this.lblInitialValue.Text = "InitialValue";
			this.tbxFinalValue.Location = new Point(417, 34);
			this.tbxFinalValue.Name = "tbxFinalValue";
			this.tbxFinalValue.ReadOnly = true;
			this.tbxFinalValue.Size = new Size(100, 21);
			this.tbxFinalValue.TabIndex = 17;
			this.lblFinalValue.AutoSize = true;
			this.lblFinalValue.Location = new Point(360, 38);
			this.lblFinalValue.Name = "lblFinalValue";
			this.lblFinalValue.Size = new Size(65, 12);
			this.lblFinalValue.TabIndex = 18;
			this.lblFinalValue.Text = "FinalValue";
			this.dInputConvRate.BackgroundStyle.Class = "DateTimeInputBackground";
			this.dInputConvRate.BackgroundStyle.CornerType = eCornerType.Square;
			this.dInputConvRate.ButtonFreeText.Shortcut = eShortcut.F2;
			this.dInputConvRate.DisplayFormat = "0.0";
			this.dInputConvRate.Increment = 0.1;
			this.dInputConvRate.InputHorizontalAlignment = eHorizontalAlignment.Left;
			this.dInputConvRate.Location = new Point(593, 2);
			this.dInputConvRate.MaxValue = 100.0;
			this.dInputConvRate.MinValue = 0.0;
			this.dInputConvRate.Name = "dInputConvRate";
			this.dInputConvRate.ShowUpDown = true;
			this.dInputConvRate.Size = new Size(100, 21);
			this.dInputConvRate.TabIndex = 19;
			this.dInputConvRate.ValueChanged += this.dInputConvRate_ValueChanged;
			this.tbxInitialTime.Location = new Point(187, 34);
			this.tbxInitialTime.Name = "tbxInitialTime";
			this.tbxInitialTime.ReadOnly = true;
			this.tbxInitialTime.Size = new Size(152, 21);
			this.tbxInitialTime.TabIndex = 20;
			this.tbxFinalTime.Location = new Point(541, 34);
			this.tbxFinalTime.Name = "tbxFinalTime";
			this.tbxFinalTime.ReadOnly = true;
			this.tbxFinalTime.Size = new Size(152, 21);
			this.tbxFinalTime.TabIndex = 21;
			this.lblConvRate.AutoSize = true;
			this.lblConvRate.Location = new Point(539, 5);
			this.lblConvRate.Name = "lblConvRate";
			this.lblConvRate.Size = new Size(53, 12);
			this.lblConvRate.TabIndex = 22;
			this.lblConvRate.Text = "ConvRate";
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(194, 217, 247);
			base.Controls.Add(this.tbxFinalTime);
			base.Controls.Add(this.tbxInitialTime);
			base.Controls.Add(this.dInputConvRate);
			base.Controls.Add(this.tbxFinalValue);
			base.Controls.Add(this.lblFinalValue);
			base.Controls.Add(this.tbxInitialValue);
			base.Controls.Add(this.dInputNumBatch);
			base.Controls.Add(this.lblWeightConv);
			base.Controls.Add(this.lblDanHao);
			base.Controls.Add(this.tbxBatchCode);
			base.Controls.Add(this.dInputQuantityBatch);
			base.Controls.Add(this.btnDelete);
			base.Controls.Add(this.lblWeightDiff);
			base.Controls.Add(this.lblInitialValue);
			base.Controls.Add(this.lblConvRate);
			base.Name = "TicketSubQualityControl";
			base.Size = new Size(739, 63);
			((ISupportInitialize)this.dInputQuantityBatch).EndInit();
			((ISupportInitialize)this.dInputNumBatch).EndInit();
			((ISupportInitialize)this.dInputConvRate).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000F5A RID: 3930
		private ModT_ticketbatch _ModTicketBatch = null;

		// Token: 0x04000F5B RID: 3931
		private bool _IsEdit;

		// Token: 0x04000F5C RID: 3932
		private IContainer components = null;

		// Token: 0x04000F5D RID: 3933
		private ButtonX btnDelete;

		// Token: 0x04000F5E RID: 3934
		private DoubleInput dInputQuantityBatch;

		// Token: 0x04000F5F RID: 3935
		private ButtonItem btnAddRd;

		// Token: 0x04000F60 RID: 3936
		private TextBox tbxBatchCode;

		// Token: 0x04000F61 RID: 3937
		private Label lblDanHao;

		// Token: 0x04000F62 RID: 3938
		private Label lblWeightDiff;

		// Token: 0x04000F63 RID: 3939
		private Label lblWeightConv;

		// Token: 0x04000F64 RID: 3940
		private DoubleInput dInputNumBatch;

		// Token: 0x04000F65 RID: 3941
		private TextBox tbxInitialValue;

		// Token: 0x04000F66 RID: 3942
		private Label lblInitialValue;

		// Token: 0x04000F67 RID: 3943
		private TextBox tbxFinalValue;

		// Token: 0x04000F68 RID: 3944
		private Label lblFinalValue;

		// Token: 0x04000F69 RID: 3945
		private DoubleInput dInputConvRate;

		// Token: 0x04000F6A RID: 3946
		private TextBox tbxInitialTime;

		// Token: 0x04000F6B RID: 3947
		private TextBox tbxFinalTime;

		// Token: 0x04000F6C RID: 3948
		private Label lblConvRate;

		// Token: 0x020000FD RID: 253
		// (Invoke) Token: 0x06000AA2 RID: 2722
		public delegate void AddHandle(object sender, EventArgs e);

		// Token: 0x020000FE RID: 254
		// (Invoke) Token: 0x06000AA6 RID: 2726
		public delegate void NumBatchHandle(object sender, EventArgs e);

		// Token: 0x020000FF RID: 255
		// (Invoke) Token: 0x06000AAA RID: 2730
		public delegate void DeleteHandle(object sender, EventArgs e);
	}
}
