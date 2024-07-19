using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DAL.Base.SQSConfig;
using DAL.SQLServer.SQSConfig;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using Model.SQSConfig;
using SQSClient.Properties;

namespace SQSClient
{
	// Token: 0x0200001C RID: 28
	public partial class frmWeightDetails : BaseDialogForm
	{
		// Token: 0x06000161 RID: 353 RVA: 0x0002C520 File Offset: 0x0002A720
		public frmWeightDetails(int id)
		{
			this.InitializeComponent();
			this.SetText(this);
			this._Controls.Clear();
			this._Controls.Add(this.bar);
			this._Controls.Add(this.dgvData);
			base.SetGridUI(this.dgvData);
			this._CurrentId = id;
		}

		// Token: 0x06000162 RID: 354 RVA: 0x0002C59A File Offset: 0x0002A79A
		private void frmWeightDetails_Load(object sender, EventArgs e)
		{
			BaseDialogForm._operateArgs.Category = this.Text;
			base.InitBurron();
			this.InitControl();
			this.LoadData("");
		}

		// Token: 0x06000163 RID: 355 RVA: 0x00003040 File Offset: 0x00001240
		private void InitControl()
		{
		}

		// Token: 0x06000164 RID: 356 RVA: 0x0002C5C8 File Offset: 0x0002A7C8
		protected new void LoadData(string condition)
		{
			ModT_ticket model = this._Dal.GetModel(this._CurrentId);
			bool flag = model == null;
			if (!flag)
			{
				this.dgvData.Rows.Clear();
				string weightDetails = model.WeightDetails;
				string[] array = weightDetails.Split(new char[]
				{
					','
				});
				for (int i = 0; i < array.Length; i++)
				{
					string[] array2 = array[i].Replace("[", "").Replace("]", "").Split(new char[]
					{
						'&'
					});
					object[] array3 = new object[this.dgvData.ColumnCount];
					int num = 0;
					array3[num++] = num;
					for (int j = 0; j < array2.Length; j++)
					{
						array3[num++] = ((j < array2.Length) ? array2[j] : "");
					}
					this.dgvData.Rows.Add(array3);
				}
				bool flag2 = this.dgvData.Rows.Count > 0;
				if (flag2)
				{
					this.GetCurrentItem(0);
				}
			}
		}

		// Token: 0x06000165 RID: 357 RVA: 0x0002C710 File Offset: 0x0002A910
		private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			bool flag = e.RowIndex >= 0;
			if (flag)
			{
				this.GetCurrentItem(e.RowIndex);
			}
		}

		// Token: 0x06000166 RID: 358 RVA: 0x00003040 File Offset: 0x00001240
		private void dgvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
		}

		// Token: 0x06000167 RID: 359 RVA: 0x00003040 File Offset: 0x00001240
		private void GetCurrentItem(int rowindex)
		{
		}

		// Token: 0x06000168 RID: 360 RVA: 0x00020760 File Offset: 0x0001E960
		private void btnSure_Click(object sender, EventArgs e)
		{
			base.DialogResult = DialogResult.Yes;
		}

		// Token: 0x04000294 RID: 660
		private DAL.SQLServer.SQSConfig.DalT_ticket _Dal = DAL.Base.SQSConfig.DalT_ticket.Instance;
	}
}
