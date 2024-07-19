using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Base;
using DevComponents.DotNetBar;
using DevComponents.Editors;

namespace SQSClient.Monitor
{
	// Token: 0x020000A6 RID: 166
	public class Pagination : UserControl
	{
		// Token: 0x14000012 RID: 18
		// (add) Token: 0x06000979 RID: 2425 RVA: 0x000DE010 File Offset: 0x000DC210
		// (remove) Token: 0x0600097A RID: 2426 RVA: 0x000DE048 File Offset: 0x000DC248
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public event EventHandler<PagingEventArgs> PagingChangedEventHandler;

		// Token: 0x0600097B RID: 2427 RVA: 0x000DE07D File Offset: 0x000DC27D
		public Pagination()
		{
			this.InitializeComponent();
			this.InitText();
			this.cmbNumOfPage.SelectedIndex = 0;
		}

		// Token: 0x0600097C RID: 2428 RVA: 0x000DE0B8 File Offset: 0x000DC2B8
		private void InitText()
		{
			this.btnGoto.Text = ShowWords.ReplaceText(this.btnGoto.Text);
			this.labelItem1.Text = ShowWords.ReplaceText(this.labelItem1.Text);
			this.labelItem2.Text = ShowWords.ReplaceText(this.labelItem2.Text);
			this.labelItem5.Text = ShowWords.ReplaceText(this.labelItem5.Text);
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x0600097D RID: 2429 RVA: 0x000DE138 File Offset: 0x000DC338
		// (set) Token: 0x0600097E RID: 2430 RVA: 0x000DE150 File Offset: 0x000DC350
		public int Total
		{
			get
			{
				return this._total;
			}
			set
			{
				this._total = value;
				bool flag = this.Total % this._numOfPage > 0;
				if (flag)
				{
					this._totalPage = this.Total / this._numOfPage + 1;
				}
				else
				{
					this._totalPage = this.Total / this._numOfPage;
				}
				this.lblTotal.Text = this._total.ToString();
				this.lblTotalPage.Text = this._totalPage.ToString();
				this.txtCurrentPage.Text = this._currentPage.ToString();
				this.FireChangedEvent();
			}
		}

		// Token: 0x0600097F RID: 2431 RVA: 0x000DE1F4 File Offset: 0x000DC3F4
		private void btnPrevious_Click(object sender, EventArgs e)
		{
			bool flag = this._currentPage > 1;
			if (flag)
			{
				this._currentPage--;
				this.txtCurrentPage.Text = this._currentPage.ToString();
				this.FireChangedEvent();
			}
		}

		// Token: 0x06000980 RID: 2432 RVA: 0x000DE240 File Offset: 0x000DC440
		private void btnNext_Click(object sender, EventArgs e)
		{
			bool flag = this._currentPage < this._totalPage;
			if (flag)
			{
				this._currentPage++;
				this.txtCurrentPage.Text = this._currentPage.ToString();
				this.FireChangedEvent();
			}
		}

		// Token: 0x06000981 RID: 2433 RVA: 0x000DE290 File Offset: 0x000DC490
		private void btnGoto_Click(object sender, EventArgs e)
		{
			int num;
			bool flag = !int.TryParse(this.txtCurrentPage.Text.ToString(), out num);
			if (!flag)
			{
				bool flag2 = num > 0 && num <= this._totalPage;
				if (flag2)
				{
					this._currentPage = num;
					this.FireChangedEvent();
				}
			}
		}

		// Token: 0x06000982 RID: 2434 RVA: 0x000DE2E8 File Offset: 0x000DC4E8
		private void cmbNumOfPage_SelectedIndexChanged(object sender, EventArgs e)
		{
			int num = Convert.ToInt32(this.cmbNumOfPage.SelectedItem.ToString());
			this._numOfPage = num;
			bool flag = this.Total % num > 0;
			if (flag)
			{
				this._totalPage = this.Total / num + 1;
			}
			else
			{
				this._totalPage = this.Total / num;
			}
			this._currentPage = 1;
			this.txtCurrentPage.Text = this._currentPage.ToString();
			this.lblTotalPage.Text = this._totalPage.ToString();
			this.FireChangedEvent();
		}

		// Token: 0x06000983 RID: 2435 RVA: 0x000DE384 File Offset: 0x000DC584
		private void FireChangedEvent()
		{
			EventHandler<PagingEventArgs> pagingChangedEventHandler = this.PagingChangedEventHandler;
			if (pagingChangedEventHandler != null)
			{
				pagingChangedEventHandler(this, new PagingEventArgs
				{
					Total = this.Total,
					TotalPage = this._totalPage,
					CurrentPage = this._currentPage,
					NumOfPage = this._numOfPage
				});
			}
		}

		// Token: 0x06000984 RID: 2436 RVA: 0x000DE3E0 File Offset: 0x000DC5E0
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000985 RID: 2437 RVA: 0x000DE418 File Offset: 0x000DC618
		private void InitializeComponent()
		{
			this.bar = new Bar();
			this.labelItem1 = new LabelItem();
			this.lblTotal = new LabelItem();
			this.labelItem2 = new LabelItem();
			this.cmbNumOfPage = new ComboBoxItem();
			this.comboItem1 = new ComboItem();
			this.comboItem2 = new ComboItem();
			this.comboItem3 = new ComboItem();
			this.labelItem3 = new LabelItem();
			this.lblTotalPage = new LabelItem();
			this.labelItem5 = new LabelItem();
			this.btnPrevious = new ButtonItem();
			this.txtCurrentPage = new TextBoxItem();
			this.btnNext = new ButtonItem();
			this.btnGoto = new ButtonItem();
			this.controlContainerItem3 = new ControlContainerItem();
			((ISupportInitialize)this.bar).BeginInit();
			base.SuspendLayout();
			this.bar.AntiAlias = true;
			this.bar.Dock = DockStyle.Bottom;
			this.bar.Font = new Font("微软雅黑", 9f);
			this.bar.IsMaximized = false;
			this.bar.Items.AddRange(new BaseItem[]
			{
				this.labelItem1,
				this.lblTotal,
				this.labelItem2,
				this.cmbNumOfPage,
				this.labelItem3,
				this.lblTotalPage,
				this.labelItem5,
				this.btnPrevious,
				this.txtCurrentPage,
				this.btnNext,
				this.btnGoto
			});
			this.bar.Location = new Point(0, 3);
			this.bar.Name = "bar";
			this.bar.Size = new Size(970, 29);
			this.bar.Stretch = true;
			this.bar.Style = eDotNetBarStyle.StyleManagerControlled;
			this.bar.TabIndex = 1;
			this.bar.TabStop = false;
			this.labelItem1.Name = "labelItem1";
			this.labelItem1.Text = "Total";
			this.lblTotal.Name = "lblTotal";
			this.lblTotal.Text = "0";
			this.labelItem2.Name = "labelItem2";
			this.labelItem2.Text = "Perpage";
			this.cmbNumOfPage.DropDownHeight = 106;
			this.cmbNumOfPage.ItemHeight = 18;
			this.cmbNumOfPage.Items.AddRange(new object[]
			{
				this.comboItem1,
				this.comboItem2,
				this.comboItem3
			});
			this.cmbNumOfPage.Name = "cmbNumOfPage";
			this.cmbNumOfPage.SelectedIndexChanged += this.cmbNumOfPage_SelectedIndexChanged;
			this.comboItem1.Text = "30";
			this.comboItem1.Value = "30";
			this.comboItem2.Text = "50";
			this.comboItem2.Value = "50";
			this.comboItem3.Text = "100";
			this.comboItem3.Value = "100";
			this.labelItem3.Name = "labelItem3";
			this.labelItem3.Text = "，";
			this.lblTotalPage.Name = "lblTotalPage";
			this.lblTotalPage.Text = "0";
			this.labelItem5.Name = "labelItem5";
			this.labelItem5.Text = "Pages";
			this.btnPrevious.FontBold = true;
			this.btnPrevious.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far;
			this.btnPrevious.Name = "btnPrevious";
			this.btnPrevious.Text = "<=";
			this.btnPrevious.Click += this.btnPrevious_Click;
			this.txtCurrentPage.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far;
			this.txtCurrentPage.Name = "txtCurrentPage";
			this.txtCurrentPage.TextAlign = HorizontalAlignment.Center;
			this.txtCurrentPage.WatermarkColor = SystemColors.GrayText;
			this.btnNext.FontBold = true;
			this.btnNext.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far;
			this.btnNext.Name = "btnNext";
			this.btnNext.Text = "=>";
			this.btnNext.Click += this.btnNext_Click;
			this.btnGoto.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far;
			this.btnGoto.Name = "btnGoto";
			this.btnGoto.Text = "Goto";
			this.btnGoto.Click += this.btnGoto_Click;
			this.controlContainerItem3.AllowItemResize = false;
			this.controlContainerItem3.MenuVisibility = eMenuVisibility.VisibleAlways;
			this.controlContainerItem3.Name = "controlContainerItem3";
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.Controls.Add(this.bar);
			base.Name = "Pagination";
			base.Size = new Size(970, 32);
			((ISupportInitialize)this.bar).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000F78 RID: 3960
		private int _numOfPage = 30;

		// Token: 0x04000F79 RID: 3961
		private int _currentPage = 1;

		// Token: 0x04000F7A RID: 3962
		private int _totalPage;

		// Token: 0x04000F7B RID: 3963
		private int _total;

		// Token: 0x04000F7D RID: 3965
		private IContainer components = null;

		// Token: 0x04000F7E RID: 3966
		private Bar bar;

		// Token: 0x04000F7F RID: 3967
		private LabelItem labelItem1;

		// Token: 0x04000F80 RID: 3968
		private ControlContainerItem controlContainerItem3;

		// Token: 0x04000F81 RID: 3969
		private LabelItem lblTotal;

		// Token: 0x04000F82 RID: 3970
		private LabelItem labelItem2;

		// Token: 0x04000F83 RID: 3971
		private ComboBoxItem cmbNumOfPage;

		// Token: 0x04000F84 RID: 3972
		private ComboItem comboItem1;

		// Token: 0x04000F85 RID: 3973
		private ComboItem comboItem2;

		// Token: 0x04000F86 RID: 3974
		private ComboItem comboItem3;

		// Token: 0x04000F87 RID: 3975
		private LabelItem labelItem3;

		// Token: 0x04000F88 RID: 3976
		private LabelItem lblTotalPage;

		// Token: 0x04000F89 RID: 3977
		private LabelItem labelItem5;

		// Token: 0x04000F8A RID: 3978
		private ButtonItem btnPrevious;

		// Token: 0x04000F8B RID: 3979
		private TextBoxItem txtCurrentPage;

		// Token: 0x04000F8C RID: 3980
		private ButtonItem btnNext;

		// Token: 0x04000F8D RID: 3981
		private ButtonItem btnGoto;
	}
}
