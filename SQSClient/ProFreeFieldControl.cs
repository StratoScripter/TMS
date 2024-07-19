using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Base;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using Model.SQSConfig;
using SQSClient.Properties;

namespace SQSClient
{
	// Token: 0x0200009F RID: 159
	public class ProFreeFieldControl : UserControl
	{
		// Token: 0x14000009 RID: 9
		// (add) Token: 0x060008E3 RID: 2275 RVA: 0x000D9E18 File Offset: 0x000D8018
		// (remove) Token: 0x060008E4 RID: 2276 RVA: 0x000D9E50 File Offset: 0x000D8050
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public event ProFreeFieldControl.AddHandle AddEvent;

		// Token: 0x1400000A RID: 10
		// (add) Token: 0x060008E5 RID: 2277 RVA: 0x000D9E88 File Offset: 0x000D8088
		// (remove) Token: 0x060008E6 RID: 2278 RVA: 0x000D9EC0 File Offset: 0x000D80C0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public event ProFreeFieldControl.DeleteHandle DeleteEvent;

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x060008E7 RID: 2279 RVA: 0x000D9EF8 File Offset: 0x000D80F8
		// (set) Token: 0x060008E8 RID: 2280 RVA: 0x000D9F2A File Offset: 0x000D812A
		public ModCfg_free ModCfgfree
		{
			get
			{
				bool flag = this._ModCfgfree == null;
				if (flag)
				{
					this._ModCfgfree = new ModCfg_free();
				}
				return this._ModCfgfree;
			}
			set
			{
				this._ModCfgfree = value;
			}
		}

		// Token: 0x060008E9 RID: 2281 RVA: 0x000D9F34 File Offset: 0x000D8134
		public ProFreeFieldControl(ModCfg_free modCfgfree)
		{
			this.InitializeComponent();
			this.ModCfgfree = modCfgfree;
			this.LoadData();
			this.lblKeyword.Text = ShowWords.ReplaceText(this.lblKeyword.Text);
			this.lblFreeName.Text = this.ModCfgfree.FreeName;
			this.txtKeyField.Text = this.ModCfgfree.KeyField;
		}

		// Token: 0x060008EA RID: 2282 RVA: 0x00003040 File Offset: 0x00001240
		protected void LoadData()
		{
		}

		// Token: 0x060008EB RID: 2283 RVA: 0x000D9FB8 File Offset: 0x000D81B8
		public void CheckFreeSelected(string productFree)
		{
			productFree = "," + productFree + ",";
			this.cbxFree.Checked = (productFree.IndexOf("," + this.ModCfgfree.KeyField + ",") >= 0);
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060008EC RID: 2284 RVA: 0x000DA00C File Offset: 0x000D820C
		public bool GetChecked
		{
			get
			{
				return this.cbxFree.Checked;
			}
		}

		// Token: 0x060008ED RID: 2285 RVA: 0x000DA02C File Offset: 0x000D822C
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

		// Token: 0x060008EE RID: 2286 RVA: 0x000DA078 File Offset: 0x000D8278
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060008EF RID: 2287 RVA: 0x000DA0B0 File Offset: 0x000D82B0
		private void InitializeComponent()
		{
			this.btnAddRd = new ButtonItem();
			this.lblKeyword = new Label();
			this.cbxFree = new CheckBox();
			this.lblFreeName = new Label();
			this.txtKeyField = new TextBoxX();
			base.SuspendLayout();
			this.btnAddRd.ButtonStyle = eButtonStyle.ImageAndText;
			this.btnAddRd.Image = Resources.add16;
			this.btnAddRd.Name = "btnAddRd";
			this.btnAddRd.Text = "Add";
			this.lblKeyword.AutoSize = true;
			this.lblKeyword.Location = new Point(86, 7);
			this.lblKeyword.Name = "lblKeyword";
			this.lblKeyword.Size = new Size(47, 12);
			this.lblKeyword.TabIndex = 9;
			this.lblKeyword.Text = "Keyword";
			this.cbxFree.AutoSize = true;
			this.cbxFree.Location = new Point(7, 6);
			this.cbxFree.Name = "cbxFree";
			this.cbxFree.Size = new Size(15, 14);
			this.cbxFree.TabIndex = 10;
			this.cbxFree.UseVisualStyleBackColor = true;
			this.lblFreeName.AutoSize = true;
			this.lblFreeName.Location = new Point(24, 7);
			this.lblFreeName.Name = "lblFreeName";
			this.lblFreeName.Size = new Size(53, 12);
			this.lblFreeName.TabIndex = 11;
			this.lblFreeName.Text = "FreeName";
			this.txtKeyField.Border.Class = "TextBoxBorder";
			this.txtKeyField.Border.CornerType = eCornerType.Square;
			this.txtKeyField.Location = new Point(137, 3);
			this.txtKeyField.Margin = new System.Windows.Forms.Padding(0);
			this.txtKeyField.MaxLength = 20;
			this.txtKeyField.Name = "txtKeyField";
			this.txtKeyField.PreventEnterBeep = true;
			this.txtKeyField.ReadOnly = true;
			this.txtKeyField.Size = new Size(109, 21);
			this.txtKeyField.TabIndex = 12;
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(190, 218, 255);
			base.Controls.Add(this.txtKeyField);
			base.Controls.Add(this.lblFreeName);
			base.Controls.Add(this.cbxFree);
			base.Controls.Add(this.lblKeyword);
			base.Name = "ProFreeFieldControl";
			base.Size = new Size(255, 27);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000F31 RID: 3889
		private ModCfg_free _ModCfgfree = null;

		// Token: 0x04000F32 RID: 3890
		private IContainer components = null;

		// Token: 0x04000F33 RID: 3891
		private ButtonItem btnAddRd;

		// Token: 0x04000F34 RID: 3892
		private Label lblKeyword;

		// Token: 0x04000F35 RID: 3893
		private CheckBox cbxFree;

		// Token: 0x04000F36 RID: 3894
		private Label lblFreeName;

		// Token: 0x04000F37 RID: 3895
		private TextBoxX txtKeyField;

		// Token: 0x020000F7 RID: 247
		// (Invoke) Token: 0x06000A8A RID: 2698
		public delegate void AddHandle(object sender, EventArgs e);

		// Token: 0x020000F8 RID: 248
		// (Invoke) Token: 0x06000A8E RID: 2702
		public delegate void DeleteHandle(object sender, EventArgs e);
	}
}
