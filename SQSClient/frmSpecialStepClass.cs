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
	// Token: 0x02000029 RID: 41
	public partial class frmSpecialStepClass : BaseDialogForm
	{
		// Token: 0x17000018 RID: 24
		// (get) Token: 0x060001F7 RID: 503 RVA: 0x0003AC1C File Offset: 0x00038E1C
		// (set) Token: 0x060001F8 RID: 504 RVA: 0x0003AC34 File Offset: 0x00038E34
		public int SelectClassID
		{
			get
			{
				return this._SelectClassID;
			}
			set
			{
				this._SelectClassID = value;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x060001F9 RID: 505 RVA: 0x0003AC40 File Offset: 0x00038E40
		// (set) Token: 0x060001FA RID: 506 RVA: 0x0003AC58 File Offset: 0x00038E58
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

		// Token: 0x060001FB RID: 507 RVA: 0x0003AC64 File Offset: 0x00038E64
		public frmSpecialStepClass()
		{
			this.InitializeComponent();
			this.SetText(this);
			this._Controls.Clear();
			this._Controls.Add(this.barGroup);
			this._Controls.Add(this.bar);
			this._Controls.Add(this.dgvData);
			base.SetGridUI(this.dgvData);
		}

		// Token: 0x060001FC RID: 508 RVA: 0x0003AD2C File Offset: 0x00038F2C
		public frmSpecialStepClass(string text, BaseForm.FormActtion act)
		{
			this.InitializeComponent();
			this.SetText(this);
			this._Controls.Clear();
			this._Controls.Add(this.barGroup);
			this._Controls.Add(this.bar);
			this._Controls.Add(this.dgvData);
			base.SetGridUI(this.dgvData);
			this._Act = act;
			this.CheckAttribute();
		}

		// Token: 0x060001FD RID: 509 RVA: 0x0003AE01 File Offset: 0x00039001
		private void frmUnit_Load(object sender, EventArgs e)
		{
			BaseDialogForm._operateArgs.Category = this.Text;
			base.InitBurron();
			this.InitControl();
			this.LoadGroupData();
		}

		// Token: 0x060001FE RID: 510 RVA: 0x0003AE2A File Offset: 0x0003902A
		private void InitControl()
		{
			this.btnAdd.Shortcuts.Add(eShortcut.CtrlIns);
			this.btnDelete.Shortcuts.Add(eShortcut.CtrlDel);
		}

		// Token: 0x060001FF RID: 511 RVA: 0x0003AE5C File Offset: 0x0003905C
		private void CheckAttribute()
		{
			bool flag = this._Act == BaseForm.FormActtion.Import;
			if (flag)
			{
				this.btnImport.Visible = true;
				this.btnAdd.Visible = false;
				this.btnDelete.Visible = false;
				this.dgvData.MultiSelect = true;
				this.Text = ShowWords.ReplaceText("ImportBill");
			}
			else
			{
				this.btnImport.Visible = false;
				this.btnAdd.Visible = true;
				this.btnDelete.Visible = true;
			}
		}

		// Token: 0x06000200 RID: 512 RVA: 0x0003AEEC File Offset: 0x000390EC
		protected void LoadGroupData()
		{
			this.itemClass.Items.Clear();
			List<ModSrm_specialstepclass> listRequire = DAL.Base.SQSConfig.DalSrm_specialstepclass.Instance.GetListRequire("StepCode is Null and LastStepCode is Null", null, null);
			foreach (ModSrm_specialstepclass modSrm_specialstepclass in listRequire)
			{
				ButtonItem buttonItem = new ButtonItem();
				buttonItem.Name = modSrm_specialstepclass.Id.ToString();
				buttonItem.Text = modSrm_specialstepclass.ClassName;
				buttonItem.Click += this.buttonItem2_Click;
				this.itemClass.Items.Add(buttonItem);
			}
			this.itemGroup.Items.Clear();
			List<ModSrm_invmodel> allList = DAL.Base.SQSConfig.DalSrm_invmodel.Instance.GetAllList();
			foreach (ModSrm_invmodel modSrm_invmodel in allList)
			{
				ButtonItem buttonItem2 = new ButtonItem();
				buttonItem2.Name = modSrm_invmodel.Id.ToString();
				buttonItem2.Text = modSrm_invmodel.ModelName;
				buttonItem2.Click += this.buttonItem_Click;
				this.itemGroup.Items.Add(buttonItem2);
			}
			this.Refresh();
		}

		// Token: 0x06000201 RID: 513 RVA: 0x0003B064 File Offset: 0x00039264
		protected override void LoadData(string Name)
		{
			List<ModSrm_invstep> list = new List<ModSrm_invstep>();
			list = DAL.Base.SQSConfig.DalSrm_invstep.Instance.GetList("InvModelId", this._SelectGroupID);
			List<ModSrm_invmodel> allList = DAL.Base.SQSConfig.DalSrm_invmodel.Instance.GetAllList();
			this.dgvData.Rows.Clear();
			using (List<ModSrm_invstep>.Enumerator enumerator = list.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					ModSrm_invstep mod = enumerator.Current;
					int num = 0;
					object[] array = new object[this.dgvData.ColumnCount];
					array[num++] = mod.Id.ToString();
					bool flag = this._SrmSpecialstepclass.GetModelRequire(string.Concat(new string[]
					{
						"ClassName ='",
						this._SelectClassName,
						"' and InvStepId ='",
						mod.Id.ToString(),
						"'"
					})) == null;
					if (flag)
					{
						array[num++] = false;
					}
					else
					{
						array[num++] = this._SrmSpecialstepclass.GetModelRequire(string.Concat(new string[]
						{
							"ClassName ='",
							this._SelectClassName,
							"' and InvStepId ='",
							mod.Id.ToString(),
							"'"
						})).Enable;
					}
					object[] array2 = array;
					int num2 = num++;
					ModSrm_invmodel modSrm_invmodel = allList.Find((ModSrm_invmodel l) => l.Id == mod.InvModelId);
					array2[num2] = ((modSrm_invmodel != null) ? modSrm_invmodel.ModelName : null);
					object[] array3 = array;
					int num3 = num++;
					ModSrm_step modSrm_step = this.steplist.Find((ModSrm_step l) => l.StepCode == mod.StepCode);
					array3[num3] = ((modSrm_step != null) ? modSrm_step.StepName : null);
					object[] array4 = array;
					int num4 = num++;
					ModSrm_step modSrm_step2 = this.steplist.Find((ModSrm_step l) => l.StepCode == mod.LastStep);
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
			bool flag2 = this.dgvData.Rows.Count > 0;
			if (flag2)
			{
				this.GetCurrentItem(0);
			}
			else
			{
				this.btnDelete.Enabled = false;
			}
		}

		// Token: 0x06000202 RID: 514 RVA: 0x0003B38C File Offset: 0x0003958C
		private void buttonItem_Click(object sender, EventArgs e)
		{
			bool flag = this._SelectClassID == 0;
			if (flag)
			{
				base.ShowMsg("Select Class First !", "", "");
			}
			else
			{
				bool flag2 = this._SelectItem != null;
				if (flag2)
				{
					this._SelectItem.ColorTable = eButtonColor.Orange;
				}
				this._SelectItem = (ButtonItem)sender;
				this._SelectItem.ColorTable = eButtonColor.OrangeWithBackground;
				this._SelectGroupID = int.Parse(this._SelectItem.Name);
				this.LoadData("InvModelId");
			}
		}

		// Token: 0x06000203 RID: 515 RVA: 0x0003B418 File Offset: 0x00039618
		private void buttonItem2_Click(object sender, EventArgs e)
		{
			bool flag = this._SelectItem2 != null;
			if (flag)
			{
				this._SelectItem2.ColorTable = eButtonColor.Orange;
			}
			this._SelectItem2 = (ButtonItem)sender;
			this._SelectItem2.ColorTable = eButtonColor.OrangeWithBackground;
			this._SelectClassID = int.Parse(this._SelectItem2.Name);
			this._SelectClassName = this._SelectItem2.Text;
			bool flag2 = this._SelectGroupID != 0;
			if (flag2)
			{
				this.LoadData("InvModelId");
			}
		}

		// Token: 0x06000204 RID: 516 RVA: 0x0003B4A0 File Offset: 0x000396A0
		private void dgvUnit_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			bool flag = e.RowIndex >= 0;
			if (flag)
			{
				this.GetCurrentItem(e.RowIndex);
			}
		}

		// Token: 0x06000205 RID: 517 RVA: 0x0003B4D0 File Offset: 0x000396D0
		private void GetCurrentItem(int rowindex)
		{
			this._CurrentId = int.Parse(this.dgvData.Rows[rowindex].Cells[0].Value.ToString());
			this.btnDelete.Enabled = true;
		}

		// Token: 0x06000206 RID: 518 RVA: 0x0003B51C File Offset: 0x0003971C
		private void btnLisenceSearch_Click(object sender, EventArgs e)
		{
			this.LoadLisenceData(this.txtLisenceNo.Text.Trim());
		}

		// Token: 0x06000207 RID: 519 RVA: 0x0003B538 File Offset: 0x00039738
		protected void LoadLisenceData(string Name)
		{
			this.itemLisenceCheck.Items.Clear();
			List<ModT_truck> list = new List<ModT_truck>();
			List<string> list2 = new List<string>();
			list2.Add("Lisence");
			bool flag = Name == "";
			if (flag)
			{
				string formula = "1=1 and SpecialStepType = '" + this._SelectClassName + "'";
				list = this._Dal.GetListPages(50, 0, formula, list2);
			}
			else
			{
				string formula = "Lisence like '%" + Name + "%'";
				list = this._Dal.GetListPages(50, 0, formula, list2);
			}
			foreach (ModT_truck modT_truck in list)
			{
				CheckBoxItem checkBoxItem = new CheckBoxItem();
				checkBoxItem.Name = modT_truck.Id.ToString();
				checkBoxItem.Text = modT_truck.Lisence;
				bool flag2 = modT_truck.SpecialStepType == this._SelectClassName;
				if (flag2)
				{
					checkBoxItem.Checked = true;
				}
				else
				{
					checkBoxItem.Checked = false;
				}
				this.itemLisenceCheck.Items.Add(checkBoxItem);
			}
			this.Refresh();
		}

		// Token: 0x06000208 RID: 520 RVA: 0x0003B688 File Offset: 0x00039888
		private void btnLisenceClassBound_Click(object sender, EventArgs e)
		{
			foreach (object obj in this.itemLisenceCheck.Items)
			{
				CheckBoxItem checkBoxItem = (CheckBoxItem)obj;
				bool @checked = checkBoxItem.Checked;
				if (@checked)
				{
					DAL.Base.SQSConfig.DalT_truck.Instance.Update(new Dictionary<string, object>
					{
						{
							"SpecialStepType",
							this._SelectClassName
						}
					}, int.Parse(checkBoxItem.Name));
				}
				else
				{
					DAL.Base.SQSConfig.DalT_truck.Instance.Update(new Dictionary<string, object>
					{
						{
							"SpecialStepType",
							""
						}
					}, int.Parse(checkBoxItem.Name));
				}
			}
			base.ShowMsg("Bound Success", "", "");
		}

		// Token: 0x06000209 RID: 521 RVA: 0x0003B764 File Offset: 0x00039964
		protected void OpenGroupForm2(string title, BaseForm.FormActtion action)
		{
			frmSpecialClassEdit frmSpecialClassEdit = new frmSpecialClassEdit(title, action, this._SelectClassID, this._FrmName);
			bool flag = frmSpecialClassEdit.ShowDialog() == DialogResult.Yes;
			if (flag)
			{
				this.LoadGroupData();
			}
		}

		// Token: 0x0600020A RID: 522 RVA: 0x0003B79C File Offset: 0x0003999C
		private void btnAddSpecailStepClass_Click(object sender, EventArgs e)
		{
			this.OpenGroupForm2(((ButtonItem)sender).Text, BaseForm.FormActtion.Add);
		}

		// Token: 0x0600020B RID: 523 RVA: 0x0003B7B2 File Offset: 0x000399B2
		private void btnModifySpecialStepClass_Click(object sender, EventArgs e)
		{
			this.OpenGroupForm2(((ButtonItem)sender).Text, BaseForm.FormActtion.Modify);
		}

		// Token: 0x0600020C RID: 524 RVA: 0x0003B7C8 File Offset: 0x000399C8
		private void btnDeleteSpecialStepClass_Click(object sender, EventArgs e)
		{
			string selectClassName = this._SelectClassName;
			int listCount = DAL.Base.SQSConfig.DalT_truck.Instance.GetListCount("SpecialStepType='" + selectClassName + "'");
			bool flag = listCount != 0;
			if (flag)
			{
				base.ShowMsg(ShowWords.ReplaceText(Messages.DeleteFalse), "", "");
			}
			else
			{
				DAL.Base.SQSConfig.DalSrm_specialstepclass.Instance.DeleteRequire("ClassName ='" + selectClassName + "'");
			}
			this.LoadGroupData();
		}

		// Token: 0x0600020D RID: 525 RVA: 0x0003B848 File Offset: 0x00039A48
		private void dgvData_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
		{
			bool flag = e.RowIndex >= 0;
			if (flag)
			{
				this.dgvData.Rows[e.RowIndex].Selected = true;
				bool flag2 = e.ColumnIndex == 1;
				if (flag2)
				{
					DAL.Base.SQSConfig.DalSrm_specialstepclass srmSpecialstepclass = this._SrmSpecialstepclass;
					string str = "InvStepId ='";
					object value = this.dgvData.Rows[e.RowIndex].Cells[0].Value;
					ModSrm_specialstepclass modelRequire = srmSpecialstepclass.GetModelRequire(str + ((value != null) ? value.ToString() : null) + "'");
					bool flag3 = modelRequire == null;
					if (flag3)
					{
						ModSrm_specialstepclass modSrm_specialstepclass = new ModSrm_specialstepclass();
						modSrm_specialstepclass.ClassName = this._SelectClassName;
						modSrm_specialstepclass.InvModelId = this._SelectGroupID;
						modSrm_specialstepclass.InvStepId = int.Parse(this.dgvData.Rows[e.RowIndex].Cells[0].Value.ToString());
						ModSrm_specialstepclass modSrm_specialstepclass2 = modSrm_specialstepclass;
						ModSrm_step modSrm_step = this.steplist.Find((ModSrm_step l) => l.StepName == this.dgvData.Rows[e.RowIndex].Cells[3].Value.ToString());
						modSrm_specialstepclass2.StepCode = ((modSrm_step != null) ? modSrm_step.StepCode : null);
						bool flag4 = !string.IsNullOrEmpty(this.dgvData.Rows[e.RowIndex].Cells[4].Value.ToString());
						if (flag4)
						{
							ModSrm_specialstepclass modSrm_specialstepclass3 = modSrm_specialstepclass;
							ModSrm_step modSrm_step2 = this.steplist.Find((ModSrm_step l) => l.StepName == this.dgvData.Rows[e.RowIndex].Cells[4].Value.ToString());
							modSrm_specialstepclass3.LastStepCode = ((modSrm_step2 != null) ? modSrm_step2.StepCode : null);
						}
						else
						{
							modSrm_specialstepclass.LastStepCode = "";
						}
						modSrm_specialstepclass.CreateTime = DateTime.Now;
						modSrm_specialstepclass.ModifyTime = DateTime.Now;
						modSrm_specialstepclass.Enable = false;
						this._SrmSpecialstepclass.Add(modSrm_specialstepclass);
					}
					this.dgvData.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = !(bool)this.dgvData.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
					DAL.Base.SQSConfig.DalSrm_specialstepclass.Instance.Update(new List<string>
					{
						"Enable",
						"ModifyTime"
					}, new List<object>
					{
						(bool)this.dgvData.Rows[e.RowIndex].Cells[e.ColumnIndex].Value,
						DateTime.Now
					}, new List<string>
					{
						"InvStepId ='" + int.Parse(this.dgvData.Rows[e.RowIndex].Cells[0].Value.ToString()).ToString() + "'"
					});
				}
			}
		}

		// Token: 0x0400039A RID: 922
		private int _SelectGroupID = 0;

		// Token: 0x0400039B RID: 923
		private int _SelectClassID = 0;

		// Token: 0x0400039C RID: 924
		private string _SelectClassName = "";

		// Token: 0x0400039D RID: 925
		private ButtonItem _SelectItem = null;

		// Token: 0x0400039E RID: 926
		private ButtonItem _SelectItem2 = null;

		// Token: 0x0400039F RID: 927
		private List<ModSrm_step> steplist = DAL.Base.SQSConfig.DalSrm_step.Instance.GetAllList();

		// Token: 0x040003A0 RID: 928
		private DAL.SQLServer.SQSConfig.DalT_truck _Dal = DAL.Base.SQSConfig.DalT_truck.Instance;

		// Token: 0x040003A1 RID: 929
		private DAL.SQLServer.SQSConfig.DalSrm_specialstepclass _SrmSpecialstepclass = DAL.Base.SQSConfig.DalSrm_specialstepclass.Instance;
	}
}
