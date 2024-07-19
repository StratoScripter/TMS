using System;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Assistant;
using Base;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using Model.General;
using SQSClient.Properties;

namespace SQSClient
{
	// Token: 0x02000023 RID: 35
	public partial class frmDictionaryEdit : BaseDialogForm
	{
		// Token: 0x060001A3 RID: 419 RVA: 0x00031DDC File Offset: 0x0002FFDC
		public frmDictionaryEdit(string text, BaseForm.FormActtion act, int id)
		{
			this.InitializeComponent();
			this.SetText(this);
			this.Text = text;
			this._Act = act;
			this._CurrentId = id;
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x00031E36 File Offset: 0x00030036
		private void frmDictionaryEdit_Load(object sender, EventArgs e)
		{
			this.InitControl();
			this.LoadData("");
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x00031E4C File Offset: 0x0003004C
		private void InitControl()
		{
			this.dgvData.Columns.Clear();
			FieldInfo[] fields = typeof(Word).GetFields();
			for (int i = 0; i < fields.Length; i++)
			{
				DataGridViewColumn dataGridViewColumn = new DataGridViewTextBoxColumn();
				dataGridViewColumn.Name = "C_" + fields[i].Name;
				dataGridViewColumn.HeaderText = ShowWords.ReplaceText(fields[i].Name);
				dataGridViewColumn.DataPropertyName = fields[i].Name;
				bool flag = fields[i].Name == "Key";
				if (flag)
				{
					dataGridViewColumn.ReadOnly = true;
					dataGridViewColumn.DefaultCellStyle.BackColor = Color.Lavender;
				}
				this.dgvData.Columns.Add(dataGridViewColumn);
			}
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x00031F1C File Offset: 0x0003011C
		protected override void LoadData(string Name)
		{
			XMLHelper.ReadXMLFile<Words>(Application.StartupPath + "\\Dictionary.xml", ref this.listWords);
			bool flag = BaseForm.FormActtion.Modify == this._Act;
			if (flag)
			{
				int num = -1;
				this.dgvData.Rows.Clear();
				foreach (Word word in this.listWords.words)
				{
					this.dgvData.Rows.Add();
					num++;
					foreach (FieldInfo fieldInfo in word.GetType().GetFields())
					{
						this.dgvData.Rows[num].Cells["C_" + fieldInfo.Name].Value = fieldInfo.GetValue(word);
					}
				}
				this.dgvData.ClearSelection();
			}
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x00032040 File Offset: 0x00030240
		private void btnSave_Click(object sender, EventArgs e)
		{
			this.txtSearch.Focus();
			bool flag = !this.TextCheck();
			if (flag)
			{
				this.res = false;
			}
			else
			{
				bool flag2 = this._Act == BaseForm.FormActtion.Add;
				if (flag2)
				{
					this.res = this.Add();
				}
				else
				{
					this.res = this.Modify();
				}
				bool flag3 = this.res;
				if (flag3)
				{
					base.DialogResult = DialogResult.Yes;
				}
			}
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x000320B0 File Offset: 0x000302B0
		private bool Add()
		{
			return true;
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x000320C4 File Offset: 0x000302C4
		private bool Modify()
		{
			XMLHelper.WriteXMLFile<Words>(Application.StartupPath + "\\Dictionary.xml", this.listWords);
			return true;
		}

		// Token: 0x060001AA RID: 426 RVA: 0x000320F4 File Offset: 0x000302F4
		private bool TextCheck()
		{
			return true;
		}

		// Token: 0x060001AB RID: 427 RVA: 0x00032107 File Offset: 0x00030307
		private void frmDictionaryEdit_FormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = !this.res;
			this.res = true;
		}

		// Token: 0x060001AC RID: 428 RVA: 0x00032124 File Offset: 0x00030324
		private void txtSearch_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			if (flag)
			{
				Regex regex = new Regex(this.txtSearch.Text);
				while (this.i < this.dgvData.Rows.Count)
				{
					for (int i = 0; i < this.dgvData.Columns.Count; i++)
					{
						Regex regex2 = regex;
						object value = this.dgvData.Rows[this.i].Cells[i].Value;
						Match match = regex2.Match(((value != null) ? value.ToString() : null) ?? "");
						bool success = match.Success;
						if (success)
						{
							this.dgvData.CurrentCell = this.dgvData[i, this.i];
							this.i++;
							return;
						}
					}
					this.i++;
				}
				bool flag2 = this.i >= this.dgvData.Rows.Count;
				if (flag2)
				{
					this.i = 0;
				}
			}
		}

		// Token: 0x060001AD RID: 429 RVA: 0x0003225C File Offset: 0x0003045C
		private void dgvData_CellEndEdit(object sender, DataGridViewCellEventArgs e)
		{
			Word word = this.listWords.words.Find((Word l) => l.Key == this.dgvData[0, e.RowIndex].Value.ToString());
			foreach (FieldInfo fieldInfo in word.GetType().GetFields())
			{
				bool flag = fieldInfo.Name == this.dgvData.Columns[e.ColumnIndex].DataPropertyName;
				if (flag)
				{
					fieldInfo.SetValue(word, this.dgvData[e.ColumnIndex, e.RowIndex].Value);
					break;
				}
			}
		}

		// Token: 0x060001AE RID: 430 RVA: 0x00032321 File Offset: 0x00030521
		private void btnAdd_Click(object sender, EventArgs e)
		{
			this.OpenForm(typeof(frmWordEdit), ((ButtonItem)sender).Text, BaseForm.FormActtion.Add);
		}

		// Token: 0x040002F2 RID: 754
		private Words listWords = new Words();

		// Token: 0x040002F3 RID: 755
		private bool res = true;

		// Token: 0x040002F4 RID: 756
		private int i = 0;
	}
}
