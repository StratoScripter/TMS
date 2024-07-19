namespace SQSClient
{
	// Token: 0x02000026 RID: 38
	public partial class frmPhotoAround : global::SQSClient.BaseDialogForm
	{
		// Token: 0x060001DF RID: 479 RVA: 0x00037FD4 File Offset: 0x000361D4
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x0003800C File Offset: 0x0003620C
		private void InitializeComponent()
		{
			this.pbxPreview = new global::System.Windows.Forms.PictureBox();
			this.panelEx1 = new global::DevComponents.DotNetBar.PanelEx();
			this.treeGroup = new global::DevComponents.AdvTree.AdvTree();
			this.node1 = new global::DevComponents.AdvTree.Node();
			this.nodeConnector1 = new global::DevComponents.AdvTree.NodeConnector();
			this.elementStyle1 = new global::DevComponents.DotNetBar.ElementStyle();
			this.txtDanHao = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			((global::System.ComponentModel.ISupportInitialize)this.pbxPreview).BeginInit();
			this.panelEx1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.treeGroup).BeginInit();
			base.SuspendLayout();
			this.pbxPreview.BackColor = global::System.Drawing.Color.Transparent;
			this.pbxPreview.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.pbxPreview.Location = new global::System.Drawing.Point(289, 0);
			this.pbxPreview.Name = "pbxPreview";
			this.pbxPreview.Size = new global::System.Drawing.Size(655, 576);
			this.pbxPreview.TabIndex = 1;
			this.pbxPreview.TabStop = false;
			this.panelEx1.CanvasColor = global::System.Drawing.SystemColors.Control;
			this.panelEx1.ColorSchemeStyle = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.panelEx1.Controls.Add(this.treeGroup);
			this.panelEx1.Controls.Add(this.txtDanHao);
			this.panelEx1.DisabledBackColor = global::System.Drawing.Color.Empty;
			this.panelEx1.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.panelEx1.Location = new global::System.Drawing.Point(0, 0);
			this.panelEx1.Name = "panelEx1";
			this.panelEx1.Size = new global::System.Drawing.Size(289, 576);
			this.panelEx1.Style.Alignment = global::System.Drawing.StringAlignment.Center;
			this.panelEx1.Style.BackColor1.ColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
			this.panelEx1.Style.BackColor2.ColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
			this.panelEx1.Style.Border = global::DevComponents.DotNetBar.eBorderType.SingleLine;
			this.panelEx1.Style.BorderColor.ColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
			this.panelEx1.Style.ForeColor.ColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelText;
			this.panelEx1.Style.GradientAngle = 90;
			this.panelEx1.TabIndex = 2;
			this.panelEx1.Text = "panelEx1";
			this.treeGroup.AccessibleRole = global::System.Windows.Forms.AccessibleRole.Outline;
			this.treeGroup.BackColor = global::System.Drawing.SystemColors.Window;
			this.treeGroup.BackgroundStyle.Class = "TreeBorderKey";
			this.treeGroup.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.treeGroup.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.treeGroup.Location = new global::System.Drawing.Point(0, 21);
			this.treeGroup.Name = "treeGroup";
			this.treeGroup.Nodes.AddRange(new global::DevComponents.AdvTree.Node[]
			{
				this.node1
			});
			this.treeGroup.NodesConnector = this.nodeConnector1;
			this.treeGroup.NodeStyle = this.elementStyle1;
			this.treeGroup.PathSeparator = ";";
			this.treeGroup.Size = new global::System.Drawing.Size(289, 555);
			this.treeGroup.Styles.Add(this.elementStyle1);
			this.treeGroup.TabIndex = 1;
			this.treeGroup.Text = "advTree1";
			this.treeGroup.NodeDoubleClick += new global::DevComponents.AdvTree.TreeNodeMouseEventHandler(this.treeGroup_NodeDoubleClick);
			this.node1.Expanded = true;
			this.node1.Name = "node1";
			this.node1.Text = "node1";
			this.nodeConnector1.LineColor = global::System.Drawing.SystemColors.ControlText;
			this.elementStyle1.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.elementStyle1.Name = "elementStyle1";
			this.elementStyle1.TextColor = global::System.Drawing.SystemColors.ControlText;
			this.txtDanHao.Border.Class = "TextBoxBorder";
			this.txtDanHao.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.txtDanHao.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.txtDanHao.Enabled = false;
			this.txtDanHao.Location = new global::System.Drawing.Point(0, 0);
			this.txtDanHao.Name = "txtDanHao";
			this.txtDanHao.PreventEnterBeep = true;
			this.txtDanHao.Size = new global::System.Drawing.Size(289, 21);
			this.txtDanHao.TabIndex = 0;
			base.ClientSize = new global::System.Drawing.Size(944, 576);
			base.Controls.Add(this.pbxPreview);
			base.Controls.Add(this.panelEx1);
			base.MaximizeBox = true;
			base.Name = "frmPhotoAround";
			this.Text = "frmPhotoAround";
			base.WindowState = global::System.Windows.Forms.FormWindowState.Maximized;
			base.Load += new global::System.EventHandler(this.frmPhotoAround_Load);
			((global::System.ComponentModel.ISupportInitialize)this.pbxPreview).EndInit();
			this.panelEx1.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.treeGroup).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000363 RID: 867
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000364 RID: 868
		private global::System.Windows.Forms.PictureBox pbxPreview;

		// Token: 0x04000365 RID: 869
		private global::DevComponents.DotNetBar.PanelEx panelEx1;

		// Token: 0x04000366 RID: 870
		private global::DevComponents.AdvTree.AdvTree treeGroup;

		// Token: 0x04000367 RID: 871
		private global::DevComponents.AdvTree.Node node1;

		// Token: 0x04000368 RID: 872
		private global::DevComponents.AdvTree.NodeConnector nodeConnector1;

		// Token: 0x04000369 RID: 873
		private global::DevComponents.DotNetBar.ElementStyle elementStyle1;

		// Token: 0x0400036A RID: 874
		private global::DevComponents.DotNetBar.Controls.TextBoxX txtDanHao;
	}
}
