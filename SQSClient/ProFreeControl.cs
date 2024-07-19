using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Base;
using DAL.Base.SQSConfig;
using DevComponents.DotNetBar;
using Model.SQSConfig;
using SQSClient.Properties;

namespace SQSClient
{
	// Token: 0x0200009E RID: 158
	public class ProFreeControl : UserControl
	{
		// Token: 0x14000007 RID: 7
		// (add) Token: 0x060008D4 RID: 2260 RVA: 0x000D977C File Offset: 0x000D797C
		// (remove) Token: 0x060008D5 RID: 2261 RVA: 0x000D97B4 File Offset: 0x000D79B4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public event ProFreeControl.AddHandle AddEvent;

		// Token: 0x14000008 RID: 8
		// (add) Token: 0x060008D6 RID: 2262 RVA: 0x000D97EC File Offset: 0x000D79EC
		// (remove) Token: 0x060008D7 RID: 2263 RVA: 0x000D9824 File Offset: 0x000D7A24
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public event ProFreeControl.DeleteHandle DeleteEvent;

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x060008D8 RID: 2264 RVA: 0x000D985C File Offset: 0x000D7A5C
		// (set) Token: 0x060008D9 RID: 2265 RVA: 0x000D988E File Offset: 0x000D7A8E
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

		// Token: 0x060008DA RID: 2266 RVA: 0x000D9898 File Offset: 0x000D7A98
		public ProFreeControl(ModCfg_free modCfgfree)
		{
			this.InitializeComponent();
			this.ModCfgfree = modCfgfree;
			this.LoadData();
			this.lblFreeItem.Text = ShowWords.ReplaceText(this.lblFreeItem.Text);
			this.lblFreeName.Text = this.ModCfgfree.FreeName;
			this.cbxFree.Enabled = false;
		}

		// Token: 0x060008DB RID: 2267 RVA: 0x000D9914 File Offset: 0x000D7B14
		protected void LoadData()
		{
			this.cmbFreeInfo.Items.Clear();
			this.cmbFreeInfo.DisplayMember = "InfoName";
			this.cmbFreeInfo.SelectMember = "PinYinMa";
			this.cmbFreeInfo.ValueMember = "Id";
			this.cmbFreeInfo.DataSource = DalCfg_freeinfo.Instance.GetListByFreeIndex(this.ModCfgfree.FreeIndex);
			bool flag = this.cmbFreeInfo.Items.Count > 0;
			if (flag)
			{
				this.cmbFreeInfo.SelectedIndex = 0;
			}
		}

		// Token: 0x060008DC RID: 2268 RVA: 0x000D99B0 File Offset: 0x000D7BB0
		public void CheckFreeSelected(string productFree)
		{
			productFree = "," + productFree + ",";
			this.cbxFree.Checked = (productFree.IndexOf("," + this.ModCfgfree.KeyField + ",") >= 0);
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x060008DD RID: 2269 RVA: 0x000D9A04 File Offset: 0x000D7C04
		public bool GetChecked
		{
			get
			{
				return this.cbxFree.Checked;
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x060008DE RID: 2270 RVA: 0x000D9A24 File Offset: 0x000D7C24
		// (set) Token: 0x060008DF RID: 2271 RVA: 0x000D9A41 File Offset: 0x000D7C41
		public string FreeInfo
		{
			get
			{
				return this.cmbFreeInfo.Text;
			}
			set
			{
				this.cmbFreeInfo.Text = value;
			}
		}

		// Token: 0x060008E0 RID: 2272 RVA: 0x000D9A54 File Offset: 0x000D7C54
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

		// Token: 0x060008E1 RID: 2273 RVA: 0x000D9AA0 File Offset: 0x000D7CA0
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060008E2 RID: 2274 RVA: 0x000D9AD8 File Offset: 0x000D7CD8
		private void InitializeComponent()
		{
			this.btnAddRd = new ButtonItem();
			this.cmbFreeInfo = new AutoComboBox();
			this.lblFreeItem = new Label();
			this.cbxFree = new CheckBox();
			this.lblFreeName = new Label();
			base.SuspendLayout();
			this.btnAddRd.ButtonStyle = eButtonStyle.ImageAndText;
			this.btnAddRd.Image = Resources.add16;
			this.btnAddRd.Name = "btnAddRd";
			this.btnAddRd.Text = "Add";
			this.cmbFreeInfo.DataSource = null;
			this.cmbFreeInfo.DisplayMember = null;
			this.cmbFreeInfo.DrawMode = DrawMode.OwnerDrawFixed;
			this.cmbFreeInfo.FormattingEnabled = true;
			this.cmbFreeInfo.ItemHeight = 15;
			this.cmbFreeInfo.Location = new Point(136, 3);
			this.cmbFreeInfo.Margin = new System.Windows.Forms.Padding(0);
			this.cmbFreeInfo.MaxDropDownItems = 20;
			this.cmbFreeInfo.Name = "cmbFreeInfo";
			this.cmbFreeInfo.SelectMember = null;
			this.cmbFreeInfo.Size = new Size(147, 21);
			this.cmbFreeInfo.Style = eDotNetBarStyle.StyleManagerControlled;
			this.cmbFreeInfo.TabIndex = 2;
			this.cmbFreeInfo.ValueMember = null;
			this.lblFreeItem.AutoSize = true;
			this.lblFreeItem.Location = new Point(80, 7);
			this.lblFreeItem.Name = "lblFreeItem";
			this.lblFreeItem.Size = new Size(53, 12);
			this.lblFreeItem.TabIndex = 9;
			this.lblFreeItem.Text = "FreeItem";
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
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(190, 218, 255);
			base.Controls.Add(this.lblFreeName);
			base.Controls.Add(this.cbxFree);
			base.Controls.Add(this.lblFreeItem);
			base.Controls.Add(this.cmbFreeInfo);
			base.Name = "ProFreeControl";
			base.Size = new Size(294, 27);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000F28 RID: 3880
		private ModCfg_free _ModCfgfree = null;

		// Token: 0x04000F29 RID: 3881
		private IContainer components = null;

		// Token: 0x04000F2A RID: 3882
		private ButtonItem btnAddRd;

		// Token: 0x04000F2B RID: 3883
		private AutoComboBox cmbFreeInfo;

		// Token: 0x04000F2C RID: 3884
		private Label lblFreeItem;

		// Token: 0x04000F2D RID: 3885
		private CheckBox cbxFree;

		// Token: 0x04000F2E RID: 3886
		private Label lblFreeName;

		// Token: 0x020000F5 RID: 245
		// (Invoke) Token: 0x06000A82 RID: 2690
		public delegate void AddHandle(object sender, EventArgs e);

		// Token: 0x020000F6 RID: 246
		// (Invoke) Token: 0x06000A86 RID: 2694
		public delegate void DeleteHandle(object sender, EventArgs e);
	}
}
