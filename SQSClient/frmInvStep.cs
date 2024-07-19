using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Base;
using DAL.Base.SQSConfig;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using Model;
using Model.SQSConfig;
using SQSClient.Properties;

namespace SQSClient
{
	// Token: 0x02000058 RID: 88
	public partial class frmInvStep : BaseDialogForm
	{
		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000434 RID: 1076 RVA: 0x0006BCF4 File Offset: 0x00069EF4
		// (set) Token: 0x06000435 RID: 1077 RVA: 0x0006BD0C File Offset: 0x00069F0C
		public int SelectGroupID
		{
			get
			{
				return this._SelectGroupID;
			}
			set
			{
				this._SelectGroupID = value;
			}
		}

		// Token: 0x06000436 RID: 1078 RVA: 0x0006BD18 File Offset: 0x00069F18
		public frmInvStep()
		{
			this.InitializeComponent();
			this.SetText(this);
			this._Controls.Clear();
			this._Controls.Add(this.contextMenuGroup);
			this._Controls.Add(this.barGroup);
			this._Controls.Add(this.bar);
			this._Controls.Add(this.dgvData);
			base.SetGridUI(this.dgvData);
		}

		// Token: 0x06000437 RID: 1079 RVA: 0x0006BDB4 File Offset: 0x00069FB4
		public frmInvStep(string text, BaseForm.FormActtion act)
		{
			this.InitializeComponent();
			this.SetText(this);
			this._Controls.Clear();
			this._Controls.Add(this.contextMenuGroup);
			this._Controls.Add(this.barGroup);
			this._Controls.Add(this.bar);
			this._Controls.Add(this.dgvData);
			base.SetGridUI(this.dgvData);
			this._Act = act;
			this.CheckAttribute();
		}

		// Token: 0x06000438 RID: 1080 RVA: 0x0006BE5C File Offset: 0x0006A05C
		private void frmUnit_Load(object sender, EventArgs e)
		{
			BaseDialogForm._operateArgs.Category = this.Text;
			base.InitBurron();
			this.InitControl();
			this.LoadGroupData();
		}

		// Token: 0x06000439 RID: 1081 RVA: 0x0006BE88 File Offset: 0x0006A088
		private void InitControl()
		{
			this.btnAdd.Shortcuts.Add(eShortcut.CtrlIns);
			this.btnModify.Shortcuts.Add(eShortcut.CtrlEnter);
			this.btnDelete.Shortcuts.Add(eShortcut.CtrlDel);
		}

		// Token: 0x0600043A RID: 1082 RVA: 0x0006BED8 File Offset: 0x0006A0D8
		private void CheckAttribute()
		{
			bool flag = this._Act == BaseForm.FormActtion.Import;
			if (flag)
			{
				this.btnImport.Visible = true;
				this.btnAdd.Visible = false;
				this.btnModify.Visible = false;
				this.btnDelete.Visible = false;
				this.dgvData.MultiSelect = true;
				this.Text = ShowWords.ReplaceText("ImportBill");
			}
			else
			{
				this.btnImport.Visible = false;
				this.btnAdd.Visible = true;
				this.btnModify.Visible = true;
				this.btnDelete.Visible = true;
			}
		}

		// Token: 0x0600043B RID: 1083 RVA: 0x0006BF80 File Offset: 0x0006A180
		protected void LoadGroupData()
		{
			this.itemGroup.Items.Clear();
			List<ModSrm_invmodel> allList = DalSrm_invmodel.Instance.GetAllList();
			foreach (ModSrm_invmodel modSrm_invmodel in allList)
			{
				ButtonItem buttonItem = new ButtonItem();
				buttonItem.Name = modSrm_invmodel.Id.ToString();
				buttonItem.Text = modSrm_invmodel.ModelName;
				buttonItem.Click += this.buttonItem_Click;
				this.itemGroup.Items.Add(buttonItem);
			}
			this.Refresh();
		}

		// Token: 0x0600043C RID: 1084 RVA: 0x0006C040 File Offset: 0x0006A240
		protected override void LoadData(string Name)
		{
			List<ModSrm_invstep> list = new List<ModSrm_invstep>();
			list = DalSrm_invstep.Instance.GetList("InvModelId", this._SelectGroupID);
			List<ModSrm_invmodel> allList = DalSrm_invmodel.Instance.GetAllList();
			List<ModSrm_step> allList2 = DalSrm_step.Instance.GetAllList();
			this.dgvData.Rows.Clear();
			using (List<ModSrm_invstep>.Enumerator enumerator = list.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					ModSrm_invstep mod = enumerator.Current;
					int num = 0;
					object[] array = new object[this.dgvData.ColumnCount];
					array[num++] = mod.Id.ToString();
					object[] array2 = array;
					int num2 = num++;
					ModSrm_invmodel modSrm_invmodel = allList.Find((ModSrm_invmodel l) => l.Id == mod.InvModelId);
					array2[num2] = ((modSrm_invmodel != null) ? modSrm_invmodel.ModelName : null);
					object[] array3 = array;
					int num3 = num++;
					ModSrm_step modSrm_step = allList2.Find((ModSrm_step l) => l.StepCode == mod.StepCode);
					array3[num3] = ((modSrm_step != null) ? modSrm_step.StepName : null);
					object[] array4 = array;
					int num4 = num++;
					ModSrm_step modSrm_step2 = allList2.Find((ModSrm_step l) => l.StepCode == mod.LastStep);
					array4[num4] = ((modSrm_step2 != null) ? modSrm_step2.StepName : null);
					array[num++] = mod.AllowCondition;
					array[num++] = mod.Creater;
					array[num++] = mod.CreateTime.ToString("yyyy-MM-dd HH:mm:ss");
					array[num++] = mod.Modifier;
					array[num++] = mod.ModifyTime.ToString("yyyy-MM-dd HH:mm:ss");
					array[num++] = mod.Enable;
					array[num++] = mod.InvStepDesc;
					this.dgvData.Rows.Add(array);
				}
			}
			bool flag = this.dgvData.Rows.Count > 0;
			if (flag)
			{
				this.GetCurrentItem(0);
			}
			else
			{
				this.btnModify.Enabled = false;
				this.btnDelete.Enabled = false;
			}
		}

		// Token: 0x0600043D RID: 1085 RVA: 0x0006C2B4 File Offset: 0x0006A4B4
		private void buttonItem_Click(object sender, EventArgs e)
		{
			bool flag = this._SelectItem != null;
			if (flag)
			{
				this._SelectItem.ColorTable = eButtonColor.Orange;
			}
			this._SelectItem = (ButtonItem)sender;
			this._SelectItem.ColorTable = eButtonColor.OrangeWithBackground;
			this._SelectGroupID = int.Parse(this._SelectItem.Name);
			this.toolModifyGroup.Enabled = true;
			this.LoadData("InvModelId");
		}

		// Token: 0x0600043E RID: 1086 RVA: 0x0006C326 File Offset: 0x0006A526
		private void btnAddGroup_Click(object sender, EventArgs e)
		{
			this.OpenGroupForm(((ButtonItem)sender).Text, BaseForm.FormActtion.Add);
		}

		// Token: 0x0600043F RID: 1087 RVA: 0x0006C33C File Offset: 0x0006A53C
		private void toolAddGroup_Click(object sender, EventArgs e)
		{
			this.OpenGroupForm(((ToolStripItem)sender).Text, BaseForm.FormActtion.Add);
		}

		// Token: 0x06000440 RID: 1088 RVA: 0x0006C352 File Offset: 0x0006A552
		private void toolModifyGroup_Click(object sender, EventArgs e)
		{
			this.OpenGroupForm(((ToolStripItem)sender).Text, BaseForm.FormActtion.Modify);
		}

		// Token: 0x06000441 RID: 1089 RVA: 0x0006C368 File Offset: 0x0006A568
		private void toolDeleteGroup_Click(object sender, EventArgs e)
		{
			BaseDialogForm._operateArgs.OperateType = ((ToolStripItem)sender).Text;
			bool flag = !base.ShowChoise(Messages.DeleteSure, "", "");
			if (!flag)
			{
				ModCfg_unitgroup model = DalCfg_unitgroup.Instance.GetModel(this._SelectGroupID);
				bool flag2 = !DalCfg_unitgroup.Instance.Delete(this._SelectGroupID);
				if (flag2)
				{
					this.OnOperateFail(model, false);
					base.ShowMsg(ShowWords.ReplaceText(Messages.DeleteFalse), "", "");
				}
				else
				{
					this.OnOperateSuccess(model, true);
					this.LoadGroupData();
				}
			}
		}

		// Token: 0x06000442 RID: 1090 RVA: 0x0006C417 File Offset: 0x0006A617
		private void toolAddUnit_Click(object sender, EventArgs e)
		{
			this.OpenForm(typeof(frmInvStepEdit), ((ToolStripItem)sender).Text, BaseForm.FormActtion.Add, this._FrmName);
		}

		// Token: 0x06000443 RID: 1091 RVA: 0x0006C43D File Offset: 0x0006A63D
		private void btnAdd_Click(object sender, EventArgs e)
		{
			this.OpenForm(typeof(frmInvStepEdit), ((ButtonItem)sender).Text, BaseForm.FormActtion.Add, this._FrmName);
		}

		// Token: 0x06000444 RID: 1092 RVA: 0x0006C463 File Offset: 0x0006A663
		private void btnModify_Click(object sender, EventArgs e)
		{
			this.OpenForm(typeof(frmInvStepEdit), ((ButtonItem)sender).Text, BaseForm.FormActtion.Modify, this._FrmName);
		}

		// Token: 0x06000445 RID: 1093 RVA: 0x0006C48C File Offset: 0x0006A68C
		private void btnDelete_Click(object sender, EventArgs e)
		{
			BaseDialogForm._operateArgs.OperateType = ((ButtonItem)sender).Text;
			bool flag = !base.ShowChoise(Messages.DeleteSure, "", "");
			if (!flag)
			{
				ModSrm_invstep model = DalSrm_invstep.Instance.GetModel(this._CurrentId);
				bool flag2 = !DalSrm_invstep.Instance.Delete(this._CurrentId);
				if (flag2)
				{
					this.OnOperateFail(model, false);
					base.ShowMsg(ShowWords.ReplaceText(Messages.DeleteFalse), "", "");
				}
				else
				{
					this.OnOperateSuccess(model, true);
					this.LoadData("");
				}
			}
		}

		// Token: 0x06000446 RID: 1094 RVA: 0x0006C540 File Offset: 0x0006A740
		private void btnExport_Click(object sender, EventArgs e)
		{
			base.DataGridViewToExcel(this.dgvData);
		}

		// Token: 0x06000447 RID: 1095 RVA: 0x0006C550 File Offset: 0x0006A750
		private void dgvUnit_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			bool flag = e.RowIndex >= 0;
			if (flag)
			{
				this.GetCurrentItem(e.RowIndex);
			}
		}

		// Token: 0x06000448 RID: 1096 RVA: 0x0006C580 File Offset: 0x0006A780
		private void dgvUnit_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			bool flag = e.RowIndex >= 0;
			if (flag)
			{
				this.OpenForm(typeof(frmInvStepEdit), this.btnModify.Text, BaseForm.FormActtion.Modify, this._FrmName);
			}
		}

		// Token: 0x06000449 RID: 1097 RVA: 0x0006C5C4 File Offset: 0x0006A7C4
		private void GetCurrentItem(int rowindex)
		{
			this._CurrentId = int.Parse(this.dgvData.Rows[rowindex].Cells[0].Value.ToString());
			this.btnModify.Enabled = true;
			this.btnDelete.Enabled = true;
		}

		// Token: 0x0600044A RID: 1098 RVA: 0x0006C620 File Offset: 0x0006A820
		protected void OpenGroupForm(string title, BaseForm.FormActtion action)
		{
			frmInvModelEdit frmInvModelEdit = new frmInvModelEdit(title, action, this._SelectGroupID, this._FrmName);
			bool flag = frmInvModelEdit.ShowDialog() == DialogResult.Yes;
			if (flag)
			{
				this.LoadGroupData();
			}
		}

		// Token: 0x0600044B RID: 1099 RVA: 0x0006C658 File Offset: 0x0006A858
		private void btnImport_Click(object sender, EventArgs e)
		{
			bool flag = this._SelectGroupID == 0;
			if (flag)
			{
				base.ShowMsg(ShowWords.ReplaceText(Messages.NotSelected), "", "");
			}
			else
			{
				base.DialogResult = DialogResult.Yes;
			}
		}

		// Token: 0x0600044C RID: 1100 RVA: 0x0006C69C File Offset: 0x0006A89C
		private void btnRefer_Click(object sender, EventArgs e)
		{
			frmInvModelN frmInvModelN = new frmInvModelN(this._SelectGroupID);
			bool flag = frmInvModelN.ShowDialog() == DialogResult.Yes;
			if (flag)
			{
				List<ModSrm_invstep> listStepOld = new List<ModSrm_invstep>();
				listStepOld = DalSrm_invstep.Instance.GetList("InvModelId", this._SelectGroupID);
				int mSelectInvModelId = frmInvModelN.mSelectInvModelId;
				bool flag2 = this.ReferInvModel(mSelectInvModelId);
				if (flag2)
				{
					this.RemoveInvModel(listStepOld);
				}
				this.LoadData("");
			}
		}

		// Token: 0x0600044D RID: 1101 RVA: 0x0006C710 File Offset: 0x0006A910
		private bool ReferInvModel(int selectInvModelId)
		{
			List<ModSrm_invstep> list = new List<ModSrm_invstep>();
			list = DalSrm_invstep.Instance.GetList("InvModelId", selectInvModelId);
			string text = string.Empty;
			foreach (ModSrm_invstep modSrm_invstep in list)
			{
				modSrm_invstep.InvModelId = this._SelectGroupID;
				int num = DalSrm_invstep.Instance.Add(modSrm_invstep);
				bool flag = num == 0;
				if (flag)
				{
					bool flag2 = text.Length > 0;
					if (flag2)
					{
						List<string> list2 = new List<string>();
						list2.Add("Id in (" + text.Trim(new char[]
						{
							','
						}) + ")");
						DalSrm_invstep.Instance.DeleteRequire(list2);
					}
					return false;
				}
				text = text + num.ToString() + ",";
			}
			return true;
		}

		// Token: 0x0600044E RID: 1102 RVA: 0x0006C81C File Offset: 0x0006AA1C
		private bool RemoveInvModel(List<ModSrm_invstep> listStepOld)
		{
			string text = string.Empty;
			foreach (ModSrm_invstep modSrm_invstep in listStepOld)
			{
				text = text + modSrm_invstep.Id.ToString() + ",";
			}
			bool flag = text.Length > 0;
			if (flag)
			{
				List<string> list = new List<string>();
				list.Add("Id in (" + text.Trim(new char[]
				{
					','
				}) + ")");
				DalSrm_invstep.Instance.DeleteRequire(list);
			}
			return true;
		}

		// Token: 0x04000765 RID: 1893
		private int _SelectGroupID = 0;

		// Token: 0x04000766 RID: 1894
		private ButtonItem _SelectItem = null;
	}
}
