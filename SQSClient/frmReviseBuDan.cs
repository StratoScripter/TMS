using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Assistant;
using AutocompleteMenuNS;
using Base;
using DAL.Base.SQSConfig;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using DevComponents.DotNetBar.Layout;
using DevComponents.Editors;
using ICHandle;
using Model;
using Model.SQSConfig;
using SQSClient.Properties;

namespace SQSClient
{
	// Token: 0x02000013 RID: 19
	public partial class frmReviseBuDan : BaseDialogForm
	{
		// Token: 0x060000AA RID: 170 RVA: 0x0001485C File Offset: 0x00012A5C
		public frmReviseBuDan(string text, BaseForm.FormActtion act, int id, string dir)
		{
			this.InitializeComponent();
			base.Width = Screen.PrimaryScreen.Bounds.Width;
			this.SetText(this);
			this._Controls.Clear();
			this._Controls.Add(this.bar);
			this.Text = text;
			this._Act = act;
			this._CurrentId = id;
			this._Direct = dir;
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00014908 File Offset: 0x00012B08
		private void frmReviseBuDan_Load(object sender, EventArgs e)
		{
			base.InitBurron();
			this.InitControl();
			this._StaticColumnCount = this.dgvData.Columns.Count;
			base.CreateDgv(this.dgvData, "c_t_ticket_" + base.Name);
			this.LoadData();
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00014960 File Offset: 0x00012B60
		private bool InitControl()
		{
			this.dgvData.ShowCellToolTips = false;
			this._statusList = BaseForm.GetEnumModelList<TicketStatus>();
			DataGridViewComboBoxExColumn dataGridViewComboBoxExColumn = (DataGridViewComboBoxExColumn)this.dgvData.Columns["C_Status"];
			dataGridViewComboBoxExColumn.DisplayMember = "Description";
			dataGridViewComboBoxExColumn.ValueMember = "Value";
			dataGridViewComboBoxExColumn.DataSource = this._statusList;
			List<AutocompleteItem> list = new List<AutocompleteItem>();
			List<ModCfg_unit> list2 = DalCfg_unit.Instance.GetList("State", true);
			foreach (ModCfg_unit modCfg_unit in list2)
			{
				list.Add(new MulticolumnAutocompleteItem(new string[]
				{
					modCfg_unit.Name,
					modCfg_unit.CurProductName
				}, modCfg_unit.Name, true, true));
			}
			this.autocompleteMenuUnit.MinFragmentLength = 1;
			this.autocompleteMenuUnit.CaptureFocus = true;
			this.autocompleteMenuUnit.SetAutocompleteItems(list);
			this.cmbClientpart.BindDataSouce(DalT_client.Instance.GetAllList(), "Name", "PinYinMa", "Id");
			this.cmbSettlepart.BindDataSouce(DalT_settlepart.Instance.GetAllList(), "Name", "PinYinMa", "Id");
			this.cmbBusinessType.BindDataSouce(BaseForm.GetEnumModelList<BusinessType>(), "Description", "Description", "Value");
			return true;
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00014AE8 File Offset: 0x00012CE8
		protected override void LoadData()
		{
			bool flag = this._Act == BaseForm.FormActtion.Modify;
			if (flag)
			{
				this._mod = DalT_ticket.Instance.GetModel("Id", this._CurrentId);
				bool flag2 = this._mod == null;
				if (flag2)
				{
					base.ShowMsg(Messages.ObjNonExist, "", "");
					base.DialogResult = DialogResult.No;
				}
				else
				{
					this.txtContractNum.Text = this._mod.ContractNum;
					this.cmbBusinessType.SelectedValue = this._mod.BusinessType;
					this.cmbClientpart.Text = this._mod.ClientPart;
					this.cmbSettlepart.Text = this._mod.SettlePart;
					this.txtCardNum.Text = this._mod.CardNum;
					this._list = DalT_ticket.Instance.GetList("BatchNum", this._mod.BatchNum);
					this.dgvData.Rows.Clear();
					int num = 0;
					foreach (ModT_ticket modT_ticket in this._list)
					{
						this.dgvData.Rows.Add();
						this.dgvData.Rows[num].Cells["C_DanHao"].Value = modT_ticket.DanHao;
						this.dgvData.Rows[num].Cells["C_CheNum"].Value = modT_ticket.Lisence;
						this.dgvData.Rows[num].Cells["C_CangNum"].Value = modT_ticket.CangNum;
						this.dgvData.Rows[num].Cells["C_Product"].Value = modT_ticket.ProductName;
						this.dgvData.Rows[num].Cells["C_UnitName"].Value = modT_ticket.UnitName;
						this.dgvData.Rows[num].Cells["C_DanWei"].Value = modT_ticket.DanWei;
						this.dgvData.Rows[num].Cells["C_NetWeight"].Value = modT_ticket.NetWeight;
						this.dgvData.Rows[num].Cells["C_JiHuaLiang"].Value = modT_ticket.JiHuaLiang;
						this.dgvData.Rows[num].Cells["C_ShiJiLiang"].Value = modT_ticket.ShiJiLiang;
						this.dgvData.Rows[num].Cells["C_XianQianLiang"].Value = modT_ticket.XianQianLiang;
						this.dgvData.Rows[num].Cells["C_Status"].Value = modT_ticket.Status;
						for (int i = this._StaticColumnCount; i < this.dgvData.ColumnCount; i++)
						{
							this.dgvData.Rows[num].Cells[i].Value = base.GetValueMod<ModT_ticket>(modT_ticket, this.dgvData.Columns[i].DataPropertyName);
						}
						num++;
					}
					this.gPanelContract.Enabled = false;
					bool flag3 = this._mod.State >= 1;
					if (flag3)
					{
						this.btnSave.Enabled = false;
					}
				}
			}
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00014F20 File Offset: 0x00013120
		private void btnCard_Click(object sender, EventArgs e)
		{
			try
			{
				this.txtCardNum.Text = ICTicket.ReadCardNum();
			}
			catch
			{
				base.ShowToast(this, Messages.ReadCardFalse, "", "");
			}
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00014F70 File Offset: 0x00013170
		private void btnSave_Click(object sender, EventArgs e)
		{
			bool flag = base.ShowChoise(Messages.AdjustSure, "", "");
			if (flag)
			{
				this.txtCardNum.Focus();
				bool flag2 = !this.TextCheck();
				if (!flag2)
				{
					bool flag3 = !this.Save();
					if (!flag3)
					{
						base.DialogResult = DialogResult.Yes;
					}
				}
			}
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00014FD0 File Offset: 0x000131D0
		private bool Save()
		{
			bool flag = this._Act == BaseForm.FormActtion.Modify;
			if (flag)
			{
				int num = 0;
				foreach (ModT_ticket modT_ticket in this._list)
				{
					Dictionary<string, object> dictionary = new Dictionary<string, object>();
					dictionary.Add("CardNum", this.txtCardNum.Text.ToUpper());
					dictionary.Add("IsCard", true);
					for (int i = 0; i < this.dgvData.ColumnCount; i++)
					{
						bool flag2 = this.dgvData.Rows[num].Cells[i].ValueType.Name == "Double";
						if (flag2)
						{
							dictionary.Add(this.dgvData.Columns[i].DataPropertyName, decimal.Parse(this.dgvData.Rows[num].Cells[i].EditedFormattedValue.ToString()));
						}
						else
						{
							dictionary.Add(this.dgvData.Columns[i].DataPropertyName, this.dgvData.Rows[num].Cells[i].EditedFormattedValue);
						}
					}
					num++;
					bool flag3 = !DalT_ticket.Instance.Update(dictionary, modT_ticket.Id);
					if (flag3)
					{
						this.OnOperateFail(new
						{
							Ticket = modT_ticket,
							Dic = dictionary
						}, false);
						base.ShowToast(this, Messages.ModifyFalse, "", "");
						return false;
					}
					this.OnOperateSuccess(new
					{
						Ticket = modT_ticket,
						Dic = dictionary
					}, true);
				}
			}
			return true;
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x000151E4 File Offset: 0x000133E4
		private bool TextCheck()
		{
			bool flag = string.IsNullOrWhiteSpace(this.txtCardNum.Text.Trim());
			bool result;
			if (flag)
			{
				base.ShowToast(this, Messages.ICNull, "", "");
				this.txtCardNum.Focus();
				result = false;
			}
			else
			{
				int length = this.txtCardNum.Text.Trim().Length;
				bool flag2 = length > 16 && !RegexHelper.CheckChinaIDCardNumberFormat(this.txtCardNum.Text.Trim());
				if (flag2)
				{
					base.ShowToast(this, Messages.IDFormat, "", "");
					this.txtCardNum.Focus();
					result = false;
				}
				else
				{
					bool flag3 = (length > 0 && length <= 16 && length != 8 && length != 16) || !RegexHelper.IsNumAndEnCh1(this.txtCardNum.Text.Trim());
					if (flag3)
					{
						base.ShowToast(this, Messages.ICFormat, "", "");
						this.txtCardNum.Focus();
						result = false;
					}
					else
					{
						bool flag4 = this.txtCardNum.Text.Length == 8;
						if (flag4)
						{
							ModT_iccard model = DalT_iccard.Instance.GetModel("CardNum", this.txtCardNum.Text.Trim());
							bool flag5 = model == null;
							if (flag5)
							{
								base.ShowToast(this, Messages.ICUnauthorized, "", "");
								this.txtCardNum.Focus();
								return false;
							}
							bool flag6 = !model.State;
							if (flag6)
							{
								base.ShowToast(this, Messages.ICDisenabled, "", "");
								this.txtCardNum.Focus();
								return false;
							}
						}
						List<string> list = new List<string>();
						list.Add("CardNum = '" + this.txtCardNum.Text.Trim() + "'");
						bool flag7 = bool.Parse(DalCfg_setting.Instance.GetModel("Item", "ICPaidReuse").Value);
						if (flag7)
						{
							list.Add("State < '" + 1.ToString() + "'");
						}
						else
						{
							list.Add("Status < '" + 2.ToString() + "'");
						}
						List<ModT_ticket> list2 = DalT_ticket.Instance.GetListRequire(list, null, null).FindAll((ModT_ticket t) => t.BatchNum != this._mod.BatchNum);
						bool flag8 = list2.Count > 0;
						if (flag8)
						{
							base.ShowToast(this, Messages.ICUsed, "", "");
							this.txtCardNum.Focus();
							result = false;
						}
						else
						{
							bool flag9 = string.IsNullOrWhiteSpace(this.cmbClientpart.Text.Trim());
							if (flag9)
							{
								base.ShowToast(this, Messages.ClientpartNull, "", "");
								this.cmbClientpart.Focus();
								result = false;
							}
							else
							{
								result = true;
							}
						}
					}
				}
			}
			return result;
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x000154E8 File Offset: 0x000136E8
		private void txtContractNum_TextChanged(object sender, EventArgs e)
		{
			ModT_contract model = DalT_contract.Instance.GetModel("ContractNum", this.txtContractNum.Text);
			bool flag = model != null;
			if (flag)
			{
				this.cmbBusinessType.SelectedValue = model.BusinessType;
				this.cmbClientpart.Text = model.PartyB;
				this.cmbSettlepart.Text = model.PartyA;
				this.txtProduct.Text = model.ProductName;
			}
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00015568 File Offset: 0x00013768
		private void dgvData_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
		{
			base.ToolTipHide();
			this.editControl = e.Control;
			this.lastSelectCell = this.dgvData.SelectedCells[0];
			bool flag = this.dgvData.Columns[this.dgvData.SelectedCells[0].ColumnIndex].Name == "C_UnitName";
			if (flag)
			{
				this.autocompleteMenuUnit.SetAutocompleteMenu(this.editControl, this.autocompleteMenuUnit);
			}
			bool flag2 = this.dgvData.Columns[this.dgvData.SelectedCells[0].ColumnIndex].Name == "C_Status";
			if (flag2)
			{
				(e.Control as ComboBoxEx).SelectedIndexChanged += this.ComboBox_SelectedIndexChanged;
			}
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x0001564C File Offset: 0x0001384C
		private void dgvData_CellEndEdit(object sender, DataGridViewCellEventArgs e)
		{
			bool flag = this.dgvData.Columns[this.lastSelectCell.ColumnIndex].Name == "C_UnitName";
			if (flag)
			{
				this.autocompleteMenuUnit.TargetControlWrapper = null;
				this.autocompleteMenuUnit.SetAutocompleteMenu(this.editControl, null);
			}
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x000156AC File Offset: 0x000138AC
		private void dgvData_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
		{
			Rectangle bounds = new Rectangle(e.RowBounds.Location.X, e.RowBounds.Location.Y, this.dgvData.RowHeadersWidth - 4, e.RowBounds.Height);
			TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(), this.dgvData.RowHeadersDefaultCellStyle.Font, bounds, this.dgvData.RowHeadersDefaultCellStyle.ForeColor, TextFormatFlags.Right | TextFormatFlags.VerticalCenter);
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00015748 File Offset: 0x00013948
		private void dgvData_CellLeave(object sender, DataGridViewCellEventArgs e)
		{
			bool flag = this.dgvData.Columns[this.dgvData.SelectedCells[0].ColumnIndex].Name == "C_ShiJiLiang" || this.dgvData.Columns[this.dgvData.SelectedCells[0].ColumnIndex].Name == "C_XianQianLiang";
			if (flag)
			{
				base.ToolTipShow(this.editControl);
			}
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x000157D8 File Offset: 0x000139D8
		public void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			ComboBoxEx comboBoxEx = sender as ComboBoxEx;
			comboBoxEx.Leave += this.combox_Leave;
			this.lastSelectCell.Value = comboBoxEx.SelectedValue;
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x00015814 File Offset: 0x00013A14
		public void combox_Leave(object sender, EventArgs e)
		{
			ComboBoxEx comboBoxEx = sender as ComboBoxEx;
			comboBoxEx.SelectedIndexChanged -= this.ComboBox_SelectedIndexChanged;
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x00012473 File Offset: 0x00010673
		private void btnItemC_Click(object sender, EventArgs e)
		{
			this.OpenForm(typeof(frmItemChoose), ((ButtonItem)sender).Text, new object[]
			{
				"t_ticket",
				base.Name
			});
		}

		// Token: 0x04000155 RID: 341
		private ModT_ticket _mod = new ModT_ticket();

		// Token: 0x04000156 RID: 342
		private List<ModT_ticket> _list = new List<ModT_ticket>();

		// Token: 0x04000157 RID: 343
		private List<BaseForm.EnumModel> _statusList = new List<BaseForm.EnumModel>();

		// Token: 0x04000158 RID: 344
		private AutocompleteMenu autocompleteMenuUnit = new AutocompleteMenu();

		// Token: 0x04000159 RID: 345
		private int _StaticColumnCount;

		// Token: 0x0400015A RID: 346
		private Control editControl;

		// Token: 0x0400015B RID: 347
		private DataGridViewCell lastSelectCell;
	}
}
