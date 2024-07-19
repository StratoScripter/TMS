using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace SQSClient
{
	// Token: 0x0200009D RID: 157
	public class UnitLabel : UserControl
	{
		// Token: 0x060008D1 RID: 2257 RVA: 0x000D9630 File Offset: 0x000D7830
		public UnitLabel()
		{
			this.InitializeComponent();
		}

		// Token: 0x060008D2 RID: 2258 RVA: 0x000D9648 File Offset: 0x000D7848
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060008D3 RID: 2259 RVA: 0x000D9680 File Offset: 0x000D7880
		private void InitializeComponent()
		{
			this.unitProfile = new UnitProfile();
			base.SuspendLayout();
			this.unitProfile.BackColor = SystemColors.Control;
			this.unitProfile.Location = new Point(0, 0);
			this.unitProfile.Margin = new Padding(8, 4, 8, 4);
			this.unitProfile.Name = "unitProfile";
			this.unitProfile.Size = new Size(283, 353);
			this.unitProfile.TabIndex = 0;
			base.AutoScaleDimensions = new SizeF(6f, 14f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.Controls.Add(this.unitProfile);
			base.Margin = new Padding(4);
			base.Name = "UnitLabel";
			base.Size = new Size(283, 353);
			base.ResumeLayout(false);
		}

		// Token: 0x04000F24 RID: 3876
		private IContainer components = null;

		// Token: 0x04000F25 RID: 3877
		public UnitProfile unitProfile;
	}
}
