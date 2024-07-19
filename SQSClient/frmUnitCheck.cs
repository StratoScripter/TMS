using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DAL.Base.SQSConfig;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using Model.SQSConfig;

namespace SQSClient
{
	// Token: 0x02000076 RID: 118
	public partial class frmUnitCheck : BaseDialogForm
	{
		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000667 RID: 1639 RVA: 0x0009E50C File Offset: 0x0009C70C
		public string IDStr
		{
			get
			{
				return this._IDStr;
			}
		}

		// Token: 0x06000668 RID: 1640 RVA: 0x0009E524 File Offset: 0x0009C724
		public frmUnitCheck()
		{
			this.InitializeComponent();
			this.SetText(this);
		}

		// Token: 0x06000669 RID: 1641 RVA: 0x0009E544 File Offset: 0x0009C744
		private void frmUnitChoosing_Load(object sender, EventArgs e)
		{
			base.SetGridUI(this.dgvUnit);
			this.dgvUnit.Columns[0].Width = 50;
			this.dgvUnit.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
			this.LoadData();
		}

		// Token: 0x0600066A RID: 1642 RVA: 0x0009E598 File Offset: 0x0009C798
		protected override void LoadData()
		{
			string[] source = Settings.Instance.MonitorIDs.Split(new char[]
			{
				','
			}, StringSplitOptions.RemoveEmptyEntries);
			this.dgvUnit.Rows.Clear();
			List<ModCfg_unit> allList = DalCfg_unit.Instance.GetAllList();
			foreach (ModCfg_unit modCfg_unit in allList)
			{
				string[] array = new string[this.dgvUnit.ColumnCount];
				int num = 0;
				bool flag = source.Contains(modCfg_unit.Id.ToString());
				if (flag)
				{
					array[num++] = true.ToString();
				}
				else
				{
					array[num++] = false.ToString();
				}
				array[num++] = modCfg_unit.Id.ToString();
				array[num++] = modCfg_unit.Name;
				array[num++] = modCfg_unit.DeviceName;
				array[num++] = modCfg_unit.LuHao.ToString();
				array[num++] = modCfg_unit.Remark;
				DataGridViewRowCollection rows = this.dgvUnit.Rows;
				object[] values = array;
				rows.Add(values);
			}
		}

		// Token: 0x0600066B RID: 1643 RVA: 0x0009E6FC File Offset: 0x0009C8FC
		private void tsbtnCheckAll_Click(object sender, EventArgs e)
		{
			foreach (object obj in ((IEnumerable)this.dgvUnit.Rows))
			{
				DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
				dataGridViewRow.Cells[0].Value = true;
			}
		}

		// Token: 0x0600066C RID: 1644 RVA: 0x0009E770 File Offset: 0x0009C970
		private void tsbtnCheckNone_Click(object sender, EventArgs e)
		{
			foreach (object obj in ((IEnumerable)this.dgvUnit.Rows))
			{
				DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
				dataGridViewRow.Cells[0].Value = false;
			}
		}

		// Token: 0x0600066D RID: 1645 RVA: 0x0009E7E4 File Offset: 0x0009C9E4
		private void tsbtnOther_Click(object sender, EventArgs e)
		{
			foreach (object obj in ((IEnumerable)this.dgvUnit.Rows))
			{
				DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
				dataGridViewRow.Cells[0].Value = !bool.Parse(dataGridViewRow.Cells[0].Value.ToString());
			}
		}

		// Token: 0x0600066E RID: 1646 RVA: 0x0009E878 File Offset: 0x0009CA78
		private void tsbtnSave_Click(object sender, EventArgs e)
		{
			this._IDStr = string.Empty;
			foreach (object obj in ((IEnumerable)this.dgvUnit.Rows))
			{
				DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
				bool flag = true.ToString().Equals(dataGridViewRow.Cells[0].Value.ToString());
				if (flag)
				{
					this._IDStr = this._IDStr + dataGridViewRow.Cells[1].Value.ToString() + ",";
				}
			}
			bool flag2 = this._IDStr.Length > 0;
			if (flag2)
			{
				this._IDStr = this._IDStr.Remove(this._IDStr.Length - 1);
			}
			bool flag3 = this._IDStr.Split(new char[]
			{
				','
			}).Length > 20;
			if (flag3)
			{
				base.ShowMsg("鹤位数量不能超过20个，请重新选择！", "", "");
			}
			else
			{
				Settings.Instance.MonitorIDs = this._IDStr;
				Settings.Instance.Save();
				base.DialogResult = DialogResult.Yes;
				base.Close();
			}
		}

		// Token: 0x0600066F RID: 1647 RVA: 0x0009E9D4 File Offset: 0x0009CBD4
		private void dgvUnit_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			bool flag = e.RowIndex >= 0;
			if (flag)
			{
				this.dgvUnit.Rows[e.RowIndex].Cells[0].Value = !bool.Parse(this.dgvUnit.Rows[e.RowIndex].Cells[0].Value.ToString());
				this.RowHighLight(e.RowIndex);
			}
		}

		// Token: 0x06000670 RID: 1648 RVA: 0x0009EA60 File Offset: 0x0009CC60
		private void dgvUnit_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			bool flag = e.RowIndex >= 0;
			if (flag)
			{
				bool flag2 = e.ColumnIndex == 0;
				if (flag2)
				{
					this.dgvUnit.Rows[e.RowIndex].Cells[0].Value = !bool.Parse(this.dgvUnit.Rows[e.RowIndex].Cells[0].Value.ToString());
					this.RowHighLight(e.RowIndex);
				}
			}
		}

		// Token: 0x06000671 RID: 1649 RVA: 0x0009EAFC File Offset: 0x0009CCFC
		private void RowHighLight(int rowindex)
		{
			bool flag = bool.Parse(this.dgvUnit.Rows[rowindex].Cells[0].Value.ToString());
			if (flag)
			{
				this.dgvUnit.Rows[rowindex].DefaultCellStyle.BackColor = Color.LightBlue;
			}
			else
			{
				this.dgvUnit.Rows[rowindex].DefaultCellStyle.BackColor = Color.White;
			}
		}

		// Token: 0x04000AE4 RID: 2788
		private string _IDStr;
	}
}
