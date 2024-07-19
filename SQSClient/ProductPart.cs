using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Base;
using DevComponents.DotNetBar;
using DevComponents.Editors;
using Model.SQSConfig;

namespace SQSClient
{
	// Token: 0x0200009C RID: 156
	public class ProductPart : UserControl
	{
		// Token: 0x14000006 RID: 6
		// (add) Token: 0x060008C4 RID: 2244 RVA: 0x000D8F58 File Offset: 0x000D7158
		// (remove) Token: 0x060008C5 RID: 2245 RVA: 0x000D8F90 File Offset: 0x000D7190
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public event ProductPart.DeleteHandle DeleteEvent;

		// Token: 0x060008C6 RID: 2246 RVA: 0x000D8FC5 File Offset: 0x000D71C5
		public ProductPart()
		{
			this.InitializeComponent();
		}

		// Token: 0x060008C7 RID: 2247 RVA: 0x000D8FE0 File Offset: 0x000D71E0
		public void LoadData(List<ModT_product> listpro)
		{
			this.cmbProduct.DisplayMember = "Name";
			this.cmbProduct.SelectMember = "PinYinMa";
			this.cmbProduct.ValueMember = "Code";
			this.cmbProduct.DataSource = listpro;
			bool flag = this.cmbProduct.Items.Count > 0;
			if (flag)
			{
				this.cmbProduct.SelectedIndex = 0;
			}
			this.dInputPercent.Value = 0.0;
		}

		// Token: 0x060008C8 RID: 2248 RVA: 0x000D906C File Offset: 0x000D726C
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

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060008C9 RID: 2249 RVA: 0x000D90B8 File Offset: 0x000D72B8
		// (set) Token: 0x060008CA RID: 2250 RVA: 0x000D9100 File Offset: 0x000D7300
		public string Value
		{
			get
			{
				string str = this.dInputPercent.Value.ToString();
				string str2 = "%";
				object selectedValue = this.cmbProduct.SelectedValue;
				return str + str2 + ((selectedValue != null) ? selectedValue.ToString() : null);
			}
			set
			{
				bool flag = value.Contains('%');
				if (flag)
				{
					string[] array = value.Split(new char[]
					{
						'%'
					});
					this.dInputPercent.Value = double.Parse(array[0]);
					this.cmbProduct.SelectedValue = array[1];
				}
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060008CB RID: 2251 RVA: 0x000D9154 File Offset: 0x000D7354
		// (set) Token: 0x060008CC RID: 2252 RVA: 0x000D9174 File Offset: 0x000D7374
		public string Product
		{
			get
			{
				return this.cmbProduct.Text;
			}
			set
			{
				bool flag = value != null;
				if (flag)
				{
					this.cmbProduct.Text = value;
				}
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060008CD RID: 2253 RVA: 0x000D919C File Offset: 0x000D739C
		// (set) Token: 0x060008CE RID: 2254 RVA: 0x000D91B9 File Offset: 0x000D73B9
		public double Percent
		{
			get
			{
				return this.dInputPercent.Value;
			}
			set
			{
				this.dInputPercent.Value = value;
			}
		}

		// Token: 0x060008CF RID: 2255 RVA: 0x000D91CC File Offset: 0x000D73CC
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060008D0 RID: 2256 RVA: 0x000D9204 File Offset: 0x000D7404
		private void InitializeComponent()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(ProductPart));
			this.labelX1 = new LabelX();
			this.btnDelete = new ButtonX();
			this.dInputPercent = new DoubleInput();
			this.cmbProduct = new AutoComboBox();
			((ISupportInitialize)this.dInputPercent).BeginInit();
			base.SuspendLayout();
			this.labelX1.BackColor = Color.Transparent;
			this.labelX1.BackgroundStyle.CornerType = eCornerType.Square;
			this.labelX1.Location = new Point(192, 0);
			this.labelX1.Margin = new System.Windows.Forms.Padding(0);
			this.labelX1.Name = "labelX1";
			this.labelX1.Size = new Size(8, 23);
			this.labelX1.TabIndex = 3;
			this.labelX1.Text = "%";
			this.btnDelete.AccessibleRole = AccessibleRole.PushButton;
			this.btnDelete.BackColor = Color.Transparent;
			this.btnDelete.ColorTable = eButtonColor.Orange;
			this.btnDelete.Image = (Image)componentResourceManager.GetObject("btnDelete.Image");
			this.btnDelete.Location = new Point(200, 0);
			this.btnDelete.Margin = new System.Windows.Forms.Padding(0);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new Size(23, 23);
			this.btnDelete.Style = eDotNetBarStyle.StyleManagerControlled;
			this.btnDelete.TabIndex = 4;
			this.btnDelete.Click += this.btnDelete_Click;
			this.dInputPercent.BackgroundStyle.Class = "DateTimeInputBackground";
			this.dInputPercent.BackgroundStyle.CornerType = eCornerType.Square;
			this.dInputPercent.ButtonFreeText.Shortcut = eShortcut.F2;
			this.dInputPercent.DisplayFormat = "0.0";
			this.dInputPercent.Increment = 1.0;
			this.dInputPercent.InputHorizontalAlignment = eHorizontalAlignment.Left;
			this.dInputPercent.Location = new Point(140, 1);
			this.dInputPercent.MaxValue = 100.0;
			this.dInputPercent.MinValue = 0.0;
			this.dInputPercent.Name = "dInputPercent";
			this.dInputPercent.ShowUpDown = true;
			this.dInputPercent.Size = new Size(50, 21);
			this.dInputPercent.TabIndex = 5;
			this.cmbProduct.DataSource = null;
			this.cmbProduct.DisplayMember = null;
			this.cmbProduct.DrawMode = DrawMode.OwnerDrawFixed;
			this.cmbProduct.FormattingEnabled = true;
			this.cmbProduct.ItemHeight = 15;
			this.cmbProduct.Location = new Point(0, 1);
			this.cmbProduct.Margin = new System.Windows.Forms.Padding(0);
			this.cmbProduct.MaxDropDownItems = 20;
			this.cmbProduct.Name = "cmbProduct";
			this.cmbProduct.SelectMember = null;
			this.cmbProduct.Size = new Size(141, 21);
			this.cmbProduct.Style = eDotNetBarStyle.StyleManagerControlled;
			this.cmbProduct.TabIndex = 1;
			this.cmbProduct.ValueMember = null;
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(194, 217, 247);
			base.Controls.Add(this.dInputPercent);
			base.Controls.Add(this.btnDelete);
			base.Controls.Add(this.labelX1);
			base.Controls.Add(this.cmbProduct);
			base.Name = "ProductPart";
			base.Size = new Size(230, 23);
			((ISupportInitialize)this.dInputPercent).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000F1F RID: 3871
		private IContainer components = null;

		// Token: 0x04000F20 RID: 3872
		private AutoComboBox cmbProduct;

		// Token: 0x04000F21 RID: 3873
		private LabelX labelX1;

		// Token: 0x04000F22 RID: 3874
		private ButtonX btnDelete;

		// Token: 0x04000F23 RID: 3875
		private DoubleInput dInputPercent;

		// Token: 0x020000F4 RID: 244
		// (Invoke) Token: 0x06000A7E RID: 2686
		public delegate void DeleteHandle(object sender, EventArgs e);
	}
}
