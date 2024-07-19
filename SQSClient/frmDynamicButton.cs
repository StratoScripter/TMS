using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Base;
using DAL.Base.SQSConfig;
using DAL.SQLServer.SQSConfig;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using Model;
using Model.SQSConfig;
using SQSClient.Properties;

namespace SQSClient
{
	// Token: 0x0200002C RID: 44
	public partial class frmDynamicButton : BaseDialogForm
	{
		// Token: 0x06000220 RID: 544 RVA: 0x0003E738 File Offset: 0x0003C938
		public frmDynamicButton()
		{
			this.InitializeComponent();
			this.SetText(this);
			this._Controls.Clear();
			this._Controls.Add(this.bar);
			this._Controls.Add(this.dgvData);
			base.SetGridUI(this.dgvData);
		}

		// Token: 0x06000221 RID: 545 RVA: 0x0003E7AB File Offset: 0x0003C9AB
		private void frmKeyCode_Load(object sender, EventArgs e)
		{
			base.InitBurron();
			this.InitControl();
			this.LoadData("");
			BaseDialogForm._operateArgs.Category = this.Text;
		}

		// Token: 0x06000222 RID: 546 RVA: 0x00003040 File Offset: 0x00001240
		private void InitControl()
		{
		}

		// Token: 0x06000223 RID: 547 RVA: 0x0003E7DC File Offset: 0x0003C9DC
		protected override void LoadData(string Name)
		{
			this.dgvData.Rows.Clear();
			List<ModSys_dynamicbutton> list = new List<ModSys_dynamicbutton>();
			bool flag = Name == "";
			if (flag)
			{
				list = this._Dal.GetAllList();
			}
			else
			{
				list = this._Dal.GetAllList(Name);
			}
			foreach (ModSys_dynamicbutton modSys_dynamicbutton in list)
			{
				int num = 0;
				object[] array = new object[this.dgvData.ColumnCount];
				array[num++] = modSys_dynamicbutton.Id.ToString();
				array[num++] = modSys_dynamicbutton.ScreenName;
				array[num++] = modSys_dynamicbutton.ButtonName;
				array[num++] = modSys_dynamicbutton.ButtonText;
				array[num++] = modSys_dynamicbutton.ParentControl;
				this.dgvData.Rows.Add(array);
			}
			bool flag2 = this.dgvData.Rows.Count > 0;
			if (flag2)
			{
				this.GetCurrentItem(0);
			}
			else
			{
				this.btnModify.Enabled = false;
				this.btnDelete.Enabled = false;
			}
		}

		// Token: 0x06000224 RID: 548 RVA: 0x0003E938 File Offset: 0x0003CB38
		private void btnModify_Click(object sender, EventArgs e)
		{
			this.OpenForm(typeof(frmDynamicButtonEdit), ((ButtonItem)sender).Text, BaseForm.FormActtion.Modify, this._FrmName);
		}

		// Token: 0x06000225 RID: 549 RVA: 0x0003E960 File Offset: 0x0003CB60
		private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			bool flag = e.RowIndex >= 0;
			if (flag)
			{
				this.GetCurrentItem(e.RowIndex);
			}
		}

		// Token: 0x06000226 RID: 550 RVA: 0x0003E990 File Offset: 0x0003CB90
		private void dgvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			bool flag = e.RowIndex >= 0;
			if (flag)
			{
				this.OpenForm(typeof(frmDynamicButtonEdit), this.btnModify.Text, BaseForm.FormActtion.Modify, this._FrmName);
			}
		}

		// Token: 0x06000227 RID: 551 RVA: 0x0003E9D3 File Offset: 0x0003CBD3
		private void GetCurrentItem(int rowindex)
		{
			this._CurrentId = int.Parse(this.dgvData.Rows[rowindex].Cells[0].Value.ToString());
		}

		// Token: 0x06000228 RID: 552 RVA: 0x0003EA07 File Offset: 0x0003CC07
		private void btnAdd_Click(object sender, EventArgs e)
		{
			this.OpenForm(typeof(frmDynamicButtonEdit), ((ButtonItem)sender).Text, BaseForm.FormActtion.Add, this._FrmName);
		}

		// Token: 0x06000229 RID: 553 RVA: 0x0003EA30 File Offset: 0x0003CC30
		private void btnDelete_Click(object sender, EventArgs e)
		{
			BaseDialogForm._operateArgs.OperateType = ((ButtonItem)sender).Text;
			ModSys_dynamicbutton model = this._Dal.GetModel(this._CurrentId);
			bool flag = !base.ShowChoise(Messages.DeleteSure, "", "");
			if (!flag)
			{
				bool flag2 = !this._Dal.Delete(this._CurrentId);
				if (flag2)
				{
					this.OnOperateFail(model, false);
					base.ShowMsg(Messages.DeleteFalse, "", "");
				}
				else
				{
					this.OnOperateSuccess(model, true);
					this.LoadData("");
				}
			}
		}

		// Token: 0x040003DF RID: 991
		private DAL.SQLServer.SQSConfig.DalSys_dynamicbutton _Dal = DAL.Base.SQSConfig.DalSys_dynamicbutton.Instance;
	}
}
