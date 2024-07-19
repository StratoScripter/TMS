using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Base;
using DAL.Base;
using DevComponents.DotNetBar;
using Model.SQSConfig;
using SQSClient.Properties;

namespace SQSClient
{
	// Token: 0x0200003F RID: 63
	public partial class frmItemChoose : BaseDialogForm
	{
		// Token: 0x060002D4 RID: 724 RVA: 0x0004A0D0 File Offset: 0x000482D0
		public frmItemChoose(string text, string tableName, string sonName)
		{
			this.InitializeComponent();
			this.SetText(this);
			this.Text = text;
			this._tableName = tableName;
			this._ctableName = "c_" + tableName + "_" + sonName;
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x0004A128 File Offset: 0x00048328
		private void frmItemChoise_Load(object sender, EventArgs e)
		{
			this.LoadData();
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x0004A134 File Offset: 0x00048334
		protected override void LoadData()
		{
			this.listall = DalSQLBase.Instance.GetAllCoumn(this._tableName);
			DalSQLBase.Instance.CreateDataTable(this._ctableName, typeof(ModItemC));
			this.listselect = DalSQLBase.Instance.GetAllList(this._ctableName);
			foreach (ModItemC modItemC in this.listselect)
			{
				ListBoxItem listBoxItem = new ListBoxItem();
				listBoxItem.Name = modItemC.ItemName;
				listBoxItem.Text = string.Concat(new string[]
				{
					ShowWords.ReplaceText(modItemC.ItemName),
					" ",
					modItemC.DataType,
					"(",
					modItemC.MaxLength,
					",",
					modItemC.Ratio,
					")"
				});
				listBoxItem.Tag = (modItemC.BackColor ?? "255,255,255");
				listBoxItem.Image = this.GetBitmap(ItemHelpr.GetColorByString(listBoxItem.Tag.ToString()), modItemC.ReadOnly ? RWFlag.R.ToString() : RWFlag.W.ToString());
				listBoxItem.CheckState = CheckState.Checked;
				this.lbxMenu.Items.Add(listBoxItem);
			}
			using (List<ModItemC>.Enumerator enumerator2 = this.listall.GetEnumerator())
			{
				while (enumerator2.MoveNext())
				{
					ModItemC mod = enumerator2.Current;
					bool flag = this.listselect.FindIndex((ModItemC c) => c.ItemName == mod.ItemName) < 0;
					if (flag)
					{
						ListBoxItem listBoxItem2 = new ListBoxItem();
						listBoxItem2.Name = mod.ItemName;
						listBoxItem2.Text = string.Concat(new string[]
						{
							ShowWords.ReplaceText(mod.ItemName),
							" ",
							mod.DataType,
							"(",
							mod.MaxLength,
							",",
							mod.Ratio,
							")"
						});
						listBoxItem2.Tag = (mod.BackColor ?? "255,255,255");
						listBoxItem2.Image = this.GetBitmap(ItemHelpr.GetColorByString(listBoxItem2.Tag.ToString()), RWFlag.R.ToString());
						listBoxItem2.CheckState = CheckState.Unchecked;
						this.lbxMenu.Items.Add(listBoxItem2);
					}
				}
			}
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x0004A43C File Offset: 0x0004863C
		private void lbxMenu_ItemCheck(object sender, ListBoxAdvItemCheckEventArgs e)
		{
			bool flag = e.Item != null;
			if (flag)
			{
				this.lbxMenu.Items.Remove(e.Item);
				this.lbxMenu.Items.Insert(this.lbxMenu.CheckedItems.Count, e.Item);
			}
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x0004A498 File Offset: 0x00048698
		private void lbxMenu_ItemDoubleClick(object sender, MouseEventArgs e)
		{
			ListBoxItem listBoxItem = sender as ListBoxItem;
			bool flag = listBoxItem != null && e.Button == MouseButtons.Left;
			if (flag)
			{
				listBoxItem.CheckState = (listBoxItem.CheckState + 1) % CheckState.Indeterminate;
			}
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x0004A4D8 File Offset: 0x000486D8
		private void lbxMenu_MouseDown(object sender, MouseEventArgs e)
		{
			this.toolReadOnly.Visible = false;
			this.toolwritable.Visible = false;
			this.toolbackColor.Visible = false;
			this.selectitem = (sender as ListBoxItem);
			bool flag = this.selectitem != null;
			if (flag)
			{
				this.selectitem.IsSelected = true;
				this.toolReadOnly.Checked = (this.selectitem.Image.Tag.ToString() == RWFlag.R.ToString());
				this.toolwritable.Checked = !this.toolReadOnly.Checked;
				this.toolReadOnly.Visible = true;
				this.toolwritable.Visible = true;
				this.toolbackColor.Visible = true;
			}
		}

		// Token: 0x060002DA RID: 730 RVA: 0x0004A5B0 File Offset: 0x000487B0
		private void btnSave_Click(object sender, EventArgs e)
		{
			DalSQLBase.Instance.Clear(this._ctableName);
			foreach (ListBoxItem listBoxItem in this.lbxMenu.CheckedItems)
			{
				ModItemC mod = new ModItemC();
				mod.ItemName = listBoxItem.Name;
				mod.ReadOnly = (listBoxItem.Image.Tag.ToString() == RWFlag.R.ToString());
				ModItemC modItemC = this.listall.Find((ModItemC l) => l.ItemName == mod.ItemName);
				mod.DataType = modItemC.DataType;
				mod.MaxLength = modItemC.MaxLength;
				mod.Ratio = modItemC.Ratio;
				mod.AllowNull = modItemC.AllowNull;
				mod.BackColor = listBoxItem.Tag.ToString();
				DalSQLBase.Instance.AddNoReturn(this._ctableName, mod);
			}
			base.DialogResult = DialogResult.Yes;
		}

		// Token: 0x060002DB RID: 731 RVA: 0x0004A708 File Offset: 0x00048908
		private void toolReadOnly_Click(object sender, EventArgs e)
		{
			this.toolwritable.Checked = false;
			this.toolReadOnly.Checked = true;
			this.selectitem.Image = this.GetBitmap(ItemHelpr.GetColorByString(this.selectitem.Tag.ToString()), RWFlag.R.ToString());
			this.Refresh();
		}

		// Token: 0x060002DC RID: 732 RVA: 0x0004A770 File Offset: 0x00048970
		private void toolwritable_Click(object sender, EventArgs e)
		{
			this.toolReadOnly.Checked = false;
			this.toolwritable.Checked = true;
			this.selectitem.Image = this.GetBitmap(ItemHelpr.GetColorByString(this.selectitem.Tag.ToString()), RWFlag.W.ToString());
			this.Refresh();
		}

		// Token: 0x060002DD RID: 733 RVA: 0x0004A7D8 File Offset: 0x000489D8
		private void toolbackColor_Click(object sender, EventArgs e)
		{
			ColorDialog colorDialog = new ColorDialog();
			bool flag = colorDialog.ShowDialog() == DialogResult.OK;
			if (flag)
			{
				this.selectitem.Tag = ItemHelpr.GetStringByColor(colorDialog.Color);
				this.selectitem.Image = this.GetBitmap(colorDialog.Color, this.selectitem.Image.Tag.ToString());
			}
		}

		// Token: 0x060002DE RID: 734 RVA: 0x0004A840 File Offset: 0x00048A40
		private Bitmap GetBitmap(Color backcolor, string word)
		{
			return this.CreatImage(16, 16, backcolor, word, new Font("Arial ", 9f, FontStyle.Bold));
		}

		// Token: 0x060002DF RID: 735 RVA: 0x0004A870 File Offset: 0x00048A70
		public Bitmap CreatImage(int width, int height, Color backcolor, string word, Font brushfont)
		{
			Bitmap bitmap = new Bitmap(width, height);
			bitmap.Tag = word;
			Graphics graphics = Graphics.FromImage(bitmap);
			graphics.SmoothingMode = SmoothingMode.HighQuality;
			graphics.Clear(backcolor);
			Color color = Color.Black;
			double num = (double)backcolor.R * 0.299 + (double)backcolor.G * 0.587 + (double)backcolor.B * 0.114;
			bool flag = num < 100.0;
			if (flag)
			{
				color = Color.White;
			}
			Brush brush = new SolidBrush(color);
			graphics.DrawString(word, brushfont, brush, 0f, 0f);
			return bitmap;
		}

		// Token: 0x040004A5 RID: 1189
		private string _tableName;

		// Token: 0x040004A6 RID: 1190
		private string _ctableName;

		// Token: 0x040004A7 RID: 1191
		private List<ModItemC> listall;

		// Token: 0x040004A8 RID: 1192
		private List<ModItemC> listselect;

		// Token: 0x040004A9 RID: 1193
		private ListBoxItem selectitem = null;
	}
}
