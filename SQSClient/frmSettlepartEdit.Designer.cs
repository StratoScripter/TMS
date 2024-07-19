namespace SQSClient
{
	// Token: 0x02000097 RID: 151
	public partial class frmSettlepartEdit : global::SQSClient.BaseDialogForm
	{
		// Token: 0x0600086E RID: 2158 RVA: 0x000CF204 File Offset: 0x000CD404
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600086F RID: 2159 RVA: 0x000CF23C File Offset: 0x000CD43C
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::SQSClient.frmSettlepartEdit));
			this.menuBar = new global::DevComponents.DotNetBar.Bar();
			this.btnSave = new global::DevComponents.DotNetBar.ButtonItem();
			this.layoutControl1 = new global::DevComponents.DotNetBar.Layout.LayoutControl();
			this.tbxName = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.tbxAddr = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.tbxPerson = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.tbxPhone = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.rtbRemark = new global::DevComponents.DotNetBar.Controls.RichTextBoxEx();
			this.layoutControlItem1 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem2 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem3 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem4 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.layoutControlItem5 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			this.txtLicence = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.layoutControlItem6 = new global::DevComponents.DotNetBar.Layout.LayoutControlItem();
			((global::System.ComponentModel.ISupportInitialize)this.menuBar).BeginInit();
			this.layoutControl1.SuspendLayout();
			base.SuspendLayout();
			this.menuBar.AccessibleDescription = "DotNetBar Bar (menuBar)";
			this.menuBar.AccessibleName = "DotNetBar Bar";
			this.menuBar.AccessibleRole = global::System.Windows.Forms.AccessibleRole.MenuBar;
			this.menuBar.BackColor = global::System.Drawing.Color.Transparent;
			this.menuBar.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.menuBar.Font = new global::System.Drawing.Font("微软雅黑", 9f);
			this.menuBar.IsMaximized = false;
			this.menuBar.Items.AddRange(new global::DevComponents.DotNetBar.BaseItem[]
			{
				this.btnSave
			});
			this.menuBar.Location = new global::System.Drawing.Point(0, 0);
			this.menuBar.MenuBar = true;
			this.menuBar.Name = "menuBar";
			this.menuBar.Size = new global::System.Drawing.Size(354, 26);
			this.menuBar.Stretch = true;
			this.menuBar.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.menuBar.TabIndex = 19;
			this.menuBar.TabStop = false;
			this.menuBar.Text = "Main Menu";
			this.btnSave.ButtonStyle = global::DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.btnSave.Image = global::SQSClient.Properties.Resources.save16;
			this.btnSave.Name = "btnSave";
			this.btnSave.Text = "Save";
			this.btnSave.Click += new global::System.EventHandler(this.btnSave_Click);
			this.layoutControl1.Controls.Add(this.txtLicence);
			this.layoutControl1.Controls.Add(this.tbxName);
			this.layoutControl1.Controls.Add(this.tbxAddr);
			this.layoutControl1.Controls.Add(this.tbxPerson);
			this.layoutControl1.Controls.Add(this.tbxPhone);
			this.layoutControl1.Controls.Add(this.rtbRemark);
			this.layoutControl1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.layoutControl1.Location = new global::System.Drawing.Point(0, 26);
			this.layoutControl1.Name = "layoutControl1";
			this.layoutControl1.RootGroup.Items.AddRange(new global::DevComponents.DotNetBar.Layout.LayoutItemBase[]
			{
				this.layoutControlItem1,
				this.layoutControlItem6,
				this.layoutControlItem2,
				this.layoutControlItem3,
				this.layoutControlItem4,
				this.layoutControlItem5
			});
			this.layoutControl1.Size = new global::System.Drawing.Size(354, 286);
			this.layoutControl1.TabIndex = 20;
			this.tbxName.Border.Class = "TextBoxBorder";
			this.tbxName.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.tbxName.Location = new global::System.Drawing.Point(80, 4);
			this.tbxName.Margin = new global::System.Windows.Forms.Padding(0);
			this.tbxName.MaxLength = 20;
			this.tbxName.Name = "tbxName";
			this.tbxName.PreventEnterBeep = true;
			this.tbxName.Size = new global::System.Drawing.Size(270, 21);
			this.tbxName.TabIndex = 0;
			this.tbxAddr.Border.Class = "TextBoxBorder";
			this.tbxAddr.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.tbxAddr.Location = new global::System.Drawing.Point(80, 62);
			this.tbxAddr.Margin = new global::System.Windows.Forms.Padding(0);
			this.tbxAddr.MaxLength = 200;
			this.tbxAddr.Name = "tbxAddr";
			this.tbxAddr.PreventEnterBeep = true;
			this.tbxAddr.Size = new global::System.Drawing.Size(270, 21);
			this.tbxAddr.TabIndex = 2;
			this.tbxPerson.Border.Class = "TextBoxBorder";
			this.tbxPerson.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.tbxPerson.Location = new global::System.Drawing.Point(80, 91);
			this.tbxPerson.Margin = new global::System.Windows.Forms.Padding(0);
			this.tbxPerson.MaxLength = 20;
			this.tbxPerson.Name = "tbxPerson";
			this.tbxPerson.PreventEnterBeep = true;
			this.tbxPerson.Size = new global::System.Drawing.Size(270, 21);
			this.tbxPerson.TabIndex = 3;
			this.tbxPhone.Border.Class = "TextBoxBorder";
			this.tbxPhone.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.tbxPhone.Location = new global::System.Drawing.Point(80, 120);
			this.tbxPhone.Margin = new global::System.Windows.Forms.Padding(0);
			this.tbxPhone.MaxLength = 20;
			this.tbxPhone.Name = "tbxPhone";
			this.tbxPhone.PreventEnterBeep = true;
			this.tbxPhone.Size = new global::System.Drawing.Size(270, 21);
			this.tbxPhone.TabIndex = 4;
			this.rtbRemark.BackgroundStyle.Class = "RichTextBoxBorder";
			this.rtbRemark.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.rtbRemark.Location = new global::System.Drawing.Point(80, 149);
			this.rtbRemark.Margin = new global::System.Windows.Forms.Padding(0);
			this.rtbRemark.MaxLength = 200;
			this.rtbRemark.Name = "rtbRemark";
			this.rtbRemark.Rtf = "{\\rtf1\\ansi\\ansicpg936\\deff0\\deflang1033\\deflangfe2052{\\fonttbl{\\f0\\fnil\\fcharset134 \\'cb\\'ce\\'cc\\'e5;}}\r\n\\viewkind4\\uc1\\pard\\lang2052\\f0\\fs18\\par\r\n}\r\n";
			this.rtbRemark.Size = new global::System.Drawing.Size(270, 75);
			this.rtbRemark.TabIndex = 5;
			this.layoutControlItem1.Control = this.tbxName;
			this.layoutControlItem1.Height = 29;
			this.layoutControlItem1.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Text = "*Settlepart";
			this.layoutControlItem1.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem1.Width = 100;
			this.layoutControlItem1.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem2.Control = this.tbxAddr;
			this.layoutControlItem2.Height = 29;
			this.layoutControlItem2.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem2.Name = "layoutControlItem2";
			this.layoutControlItem2.Text = "Addr";
			this.layoutControlItem2.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem2.Width = 100;
			this.layoutControlItem2.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem3.Control = this.tbxPerson;
			this.layoutControlItem3.Height = 29;
			this.layoutControlItem3.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem3.Name = "layoutControlItem3";
			this.layoutControlItem3.Text = "Contact";
			this.layoutControlItem3.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem3.Width = 100;
			this.layoutControlItem3.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem4.Control = this.tbxPhone;
			this.layoutControlItem4.Height = 29;
			this.layoutControlItem4.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem4.Name = "layoutControlItem4";
			this.layoutControlItem4.Text = "PhoneNum";
			this.layoutControlItem4.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem4.Width = 100;
			this.layoutControlItem4.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.layoutControlItem5.Control = this.rtbRemark;
			this.layoutControlItem5.Height = 83;
			this.layoutControlItem5.MinSize = new global::System.Drawing.Size(64, 18);
			this.layoutControlItem5.Name = "layoutControlItem5";
			this.layoutControlItem5.Text = "Remark";
			this.layoutControlItem5.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem5.Width = 100;
			this.layoutControlItem5.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			this.txtLicence.Border.Class = "TextBoxBorder";
			this.txtLicence.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtLicence.Location = new global::System.Drawing.Point(80, 33);
			this.txtLicence.Margin = new global::System.Windows.Forms.Padding(0, 0, 0, 0);
			this.txtLicence.Name = "txtLicence";
			this.txtLicence.PreventEnterBeep = true;
			this.txtLicence.Size = new global::System.Drawing.Size(270, 21);
			this.txtLicence.TabIndex = 1;
			this.layoutControlItem6.Control = this.txtLicence;
			this.layoutControlItem6.Height = 29;
			this.layoutControlItem6.MinSize = new global::System.Drawing.Size(120, 0);
			this.layoutControlItem6.Name = "layoutControlItem6";
			this.layoutControlItem6.Text = "Licence";
			this.layoutControlItem6.TextAlignment = global::DevComponents.DotNetBar.Layout.eTextAlignment.Right;
			this.layoutControlItem6.Width = 100;
			this.layoutControlItem6.WidthType = global::DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
			base.ClientSize = new global::System.Drawing.Size(354, 312);
			base.Controls.Add(this.layoutControl1);
			base.Controls.Add(this.menuBar);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "frmSettlepartEdit";
			this.Text = "frmSettlepartEdit";
			base.Load += new global::System.EventHandler(this.frmSettlepartEdit_Load);
			((global::System.ComponentModel.ISupportInitialize)this.menuBar).EndInit();
			this.layoutControl1.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x04000E51 RID: 3665
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000E52 RID: 3666
		private global::DevComponents.DotNetBar.Bar menuBar;

		// Token: 0x04000E53 RID: 3667
		private global::DevComponents.DotNetBar.ButtonItem btnSave;

		// Token: 0x04000E54 RID: 3668
		private global::DevComponents.DotNetBar.Layout.LayoutControl layoutControl1;

		// Token: 0x04000E55 RID: 3669
		private global::DevComponents.DotNetBar.Controls.TextBoxX tbxName;

		// Token: 0x04000E56 RID: 3670
		private global::DevComponents.DotNetBar.Controls.TextBoxX tbxAddr;

		// Token: 0x04000E57 RID: 3671
		private global::DevComponents.DotNetBar.Controls.TextBoxX tbxPerson;

		// Token: 0x04000E58 RID: 3672
		private global::DevComponents.DotNetBar.Controls.TextBoxX tbxPhone;

		// Token: 0x04000E59 RID: 3673
		private global::DevComponents.DotNetBar.Controls.RichTextBoxEx rtbRemark;

		// Token: 0x04000E5A RID: 3674
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem1;

		// Token: 0x04000E5B RID: 3675
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem2;

		// Token: 0x04000E5C RID: 3676
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem3;

		// Token: 0x04000E5D RID: 3677
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem4;

		// Token: 0x04000E5E RID: 3678
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem5;

		// Token: 0x04000E5F RID: 3679
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtLicence;

		// Token: 0x04000E60 RID: 3680
		private global::DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem6;
	}
}
