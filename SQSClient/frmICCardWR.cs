using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Assistant;
using Base;
using DAL.Base.SQSConfig;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using DevComponents.Editors;
using DevComponents.Editors.DateTimeAdv;
using ICHandle;
using Model.SQSConfig;

namespace SQSClient
{
	// Token: 0x0200003B RID: 59
	public partial class frmICCardWR : BaseDialogForm
	{
		// Token: 0x060002A7 RID: 679 RVA: 0x00045174 File Offset: 0x00043374
		public frmICCardWR(string text, BaseForm.FormActtion act, int id)
		{
			this.InitializeComponent();
			this.datLifeDate.MinDate = DateTime.Now;
			this.rdoAll.Checked = true;
			this.Text = text;
			this._Act = act;
			this._CurrentId = id;
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x00045211 File Offset: 0x00043411
		private void frmICCard_Load(object sender, EventArgs e)
		{
			this.InitControl();
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x0004521C File Offset: 0x0004341C
		private void InitControl()
		{
			List<ModT_product> listByState = DalT_product.Instance.GetListByState(1, 0);
			this.cmbProduct1.BindDataSouce(listByState, "Name", "PinYinMa", "Code");
			this.cmbProduct2.BindDataSouce(listByState, "Name", "PinYinMa", "Code");
			this.cmbProduct3.BindDataSouce(listByState, "Name", "PinYinMa", "Code");
			this.cmbProduct4.BindDataSouce(listByState, "Name", "PinYinMa", "Code");
			this.cmbProduct5.BindDataSouce(listByState, "Name", "PinYinMa", "Code");
			this._listgroup = DalCfg_unitgroup.Instance.GetAllList();
			List<ModCfg_unitgroup> list = (from o in this._listgroup
			where o.ParentId == 0
			select o).ToList<ModCfg_unitgroup>();
			foreach (ModCfg_unitgroup modCfg_unitgroup in list)
			{
				ListViewGroup group = new ListViewGroup(modCfg_unitgroup.Name, HorizontalAlignment.Left);
				this.listViewEx.Groups.Add(group);
				List<string> names = this.GetNames(modCfg_unitgroup);
				List<ModCfg_unit> list2 = (from o in DalCfg_unit.Instance.GetList("State", true)
				where names.Contains(o.GroupName)
				select o).ToList<ModCfg_unit>();
				foreach (ModCfg_unit modCfg_unit in list2)
				{
					ListViewItem listViewItem = new ListViewItem(modCfg_unit.Name + " ");
					listViewItem.Tag = modCfg_unit.UnitIndex;
					listViewItem.Group = group;
					this.listViewEx.Items.Add(listViewItem);
				}
			}
		}

		// Token: 0x060002AA RID: 682 RVA: 0x00045434 File Offset: 0x00043634
		private List<string> GetNames(ModCfg_unitgroup modgroup)
		{
			List<string> list = new List<string>();
			list.Add(modgroup.Name);
			List<ModCfg_unitgroup> list2 = (from o in this._listgroup
			where o.ParentId == modgroup.Id
			select o).ToList<ModCfg_unitgroup>();
			foreach (ModCfg_unitgroup modCfg_unitgroup in list2)
			{
				list.Add(modCfg_unitgroup.Name);
				list.AddRange(this.GetNames(modCfg_unitgroup));
			}
			return list;
		}

		// Token: 0x060002AB RID: 683 RVA: 0x000454E8 File Offset: 0x000436E8
		private void btnReadCard_Click(object sender, EventArgs e)
		{
			this.btnReadCard.Enabled = false;
			this.btnWriteCard.Enabled = false;
			this.txtCardNum.Text = "";
			this.txtUser.Text = "";
			this.intUseCount.ValueObject = 0;
			this.datLifeDate.ValueObject = "";
			try
			{
				string text = ICTicket.ReadCardNum();
				this.txtCardNum.Text = text;
				bool flag = ICTicket.PwdCheck(this.mPwd, 96, text, 4);
				if (flag)
				{
					byte[] bytes = ICTicket.ReadBlock(4);
					this.txtUser.Text = Encoding.UTF8.GetString(bytes);
				}
				bool flag2 = ICTicket.PwdCheck(this.mPwd, 96, text, 5);
				if (flag2)
				{
					byte[] array = ICTicket.ReadBlock(5);
					this.chkUseCount.Checked = this.GetAbleFromByte(array[6]);
					this.intUseCount.Value = (int)BitConverter.ToUInt32(array, 7);
					this.chkLifeDate.Checked = this.GetAbleFromByte(array[11]);
					int num = (int)BitConverter.ToUInt16(array, 12);
					int num2 = (int)array[14];
					int num3 = (int)array[15];
					DateTime value = new DateTime((int)BitConverter.ToUInt16(array, 12), (int)array[15], (int)array[14]);
					this.datLifeDate.Value = value;
				}
				bool flag3 = ICTicket.PwdCheck(this.mPwd, 96, text, 6);
				if (flag3)
				{
					byte[] array2 = ICTicket.ReadBlock(6);
					this.chkAll = this.GetAbleFromByte(array2[0]);
					this.chkunitscount = (int)array2[1];
					int num4 = this.chkunitscount;
					bool flag4 = num4 > 14;
					if (flag4)
					{
						num4 = 14;
					}
					this.chkunits.Clear();
					this.chkunits.AddRange(array2.SubArry(2, num4));
					this.chkunitscount -= num4;
				}
				bool flag5 = !this.chkAll && this.chkunitscount > 0;
				if (flag5)
				{
					bool flag6 = ICTicket.PwdCheck(this.mPwd, 96, text, 8);
					if (flag6)
					{
						byte[] data = ICTicket.ReadBlock(8);
						int num5 = this.chkunitscount;
						bool flag7 = num5 > 16;
						if (flag7)
						{
							num5 = 16;
						}
						this.chkunits.AddRange(data.SubArry(0, num5));
						this.chkunitscount -= num5;
					}
					bool flag8 = ICTicket.PwdCheck(this.mPwd, 96, text, 9);
					if (flag8)
					{
						byte[] data2 = ICTicket.ReadBlock(9);
						int num6 = this.chkunitscount;
						bool flag9 = num6 > 16;
						if (flag9)
						{
							num6 = 16;
						}
						this.chkunits.AddRange(data2.SubArry(0, num6));
						this.chkunitscount -= num6;
					}
					bool flag10 = ICTicket.PwdCheck(this.mPwd, 96, text, 10);
					if (flag10)
					{
						byte[] data3 = ICTicket.ReadBlock(10);
						int num7 = this.chkunitscount;
						bool flag11 = num7 > 14;
						if (flag11)
						{
							num7 = 14;
						}
						this.chkunits.AddRange(data3.SubArry(0, num7));
						this.chkunitscount -= num7;
					}
				}
				bool flag12 = !this.chkAll;
				if (flag12)
				{
					this.rdoPart.Checked = true;
					this.MakeListView();
				}
				else
				{
					this.rdoAll.Checked = true;
				}
				this.products.Clear();
				for (byte b = 16; b <= 25; b += 1)
				{
					bool flag13 = ICTicket.PwdCheck(this.mPwd, 96, text, b);
					if (flag13)
					{
						byte[] array3 = ICTicket.ReadBlock(b);
						this.products.AddRange(array3.SubArry(0, array3.Length));
					}
					bool flag14 = (b - 2) % 4 == 0;
					if (flag14)
					{
						b += 1;
					}
				}
				this.SetProductsBytes();
			}
			catch
			{
				MessageBox.Show("读卡失败！");
			}
			this.btnReadCard.Enabled = true;
			this.btnWriteCard.Enabled = true;
		}

		// Token: 0x060002AC RID: 684 RVA: 0x000458FC File Offset: 0x00043AFC
		private void btnWriteCard_Click(object sender, EventArgs e)
		{
			bool flag = !this.chkUseCount.Checked && !this.chkLifeDate.Checked;
			if (flag)
			{
				MessageBox.Show("请选择有效方式！");
			}
			else
			{
				bool flag2 = this.chkUseCount.Checked && this.intUseCount.Value == 0;
				if (flag2)
				{
					MessageBox.Show("请输入有效次数！");
				}
				else
				{
					bool flag3 = this.chkLifeDate.Checked && this.datLifeDate.Value.Date < DateTime.Now.Date;
					if (flag3)
					{
						MessageBox.Show("请输入正确有效期！");
					}
					else
					{
						this.CheckListView();
						bool flag4 = !this.chkAll && this.chkunits.Count == 0;
						if (flag4)
						{
							MessageBox.Show("请选择有效鹤位！");
						}
						else
						{
							this.btnReadCard.Enabled = false;
							this.btnWriteCard.Enabled = false;
							try
							{
								string icnum = ICTicket.ReadCardNum();
								bool flag5 = ICTicket.PwdCheck(this.mPwd, 96, icnum, 4);
								if (flag5)
								{
									List<byte> list = new List<byte>();
									list.AddRange(Encoding.UTF8.GetBytes(this.txtUser.Text.Trim()));
									this.PadRight(list, 16);
									byte[] blockdata = list.ToArray();
									ICTicket.SetBlock(4, blockdata);
								}
								bool flag6 = ICTicket.PwdCheck(this.mPwd, 96, icnum, 5);
								if (flag6)
								{
									List<byte> list2 = new List<byte>();
									list2.AddRange(Encoding.UTF8.GetBytes("SUPCON"));
									list2.Add(this.GetByteFromAble(this.chkUseCount.Checked));
									list2.AddRange(BitConverter.GetBytes(Convert.ToUInt32(this.intUseCount.Value)));
									list2.Add(this.GetByteFromAble(this.chkLifeDate.Checked));
									list2.AddRange(BitConverter.GetBytes(Convert.ToUInt16(this.datLifeDate.Value.Year)));
									list2.Add(Convert.ToByte(this.datLifeDate.Value.Day));
									list2.Add(Convert.ToByte(this.datLifeDate.Value.Month));
									byte[] blockdata2 = list2.ToArray();
									ICTicket.SetBlock(5, blockdata2);
								}
								bool flag7 = ICTicket.PwdCheck(this.mPwd, 96, icnum, 6);
								if (flag7)
								{
									List<byte> list3 = new List<byte>();
									list3.Add(this.GetByteFromAble(this.chkAll));
									int value = this.chkunits.Count;
									bool flag8 = this.chkunits.Count > 60;
									if (flag8)
									{
										value = 60;
									}
									list3.Add(Convert.ToByte(value));
									this.PadRight(this.chkunits, 14);
									list3.AddRange(this.chkunits.Sub(0, 14));
									byte[] blockdata3 = list3.ToArray();
									ICTicket.SetBlock(6, blockdata3);
								}
								bool flag9 = !this.chkAll && this.chkunits.Count > 0;
								if (flag9)
								{
									bool flag10 = ICTicket.PwdCheck(this.mPwd, 96, icnum, 8);
									if (flag10)
									{
										List<byte> list4 = new List<byte>();
										this.PadRight(this.chkunits, 16);
										list4.AddRange(this.chkunits.Sub(0, 16));
										byte[] blockdata4 = list4.ToArray();
										ICTicket.SetBlock(8, blockdata4);
									}
									bool flag11 = ICTicket.PwdCheck(this.mPwd, 96, icnum, 9);
									if (flag11)
									{
										List<byte> list5 = new List<byte>();
										this.PadRight(this.chkunits, 16);
										list5.AddRange(this.chkunits.Sub(0, 16));
										byte[] blockdata5 = list5.ToArray();
										ICTicket.SetBlock(9, blockdata5);
									}
									bool flag12 = ICTicket.PwdCheck(this.mPwd, 96, icnum, 10);
									if (flag12)
									{
										List<byte> list6 = new List<byte>();
										this.PadRight(this.chkunits, 14);
										list6.AddRange(this.chkunits.Sub(0, 14));
										this.PadRight(list6, 16);
										byte[] blockdata6 = list6.ToArray();
										ICTicket.SetBlock(10, blockdata6);
									}
								}
								this.GetProductsBytes();
								byte b = 16;
								while (this.products.Count >= 16)
								{
									bool flag13 = ICTicket.PwdCheck(this.mPwd, 96, icnum, b);
									if (flag13)
									{
										ICTicket.SetBlock(b, this.products.Sub(0, 16).ToArray());
									}
									bool flag14 = (b - 2) % 4 == 0;
									if (flag14)
									{
										b += 1;
									}
									b += 1;
								}
								MessageBox.Show("写卡成功！");
							}
							catch
							{
								MessageBox.Show("写卡失败！");
							}
							this.btnReadCard.Enabled = true;
							this.btnWriteCard.Enabled = true;
						}
					}
				}
			}
		}

		// Token: 0x060002AD RID: 685 RVA: 0x00045E18 File Offset: 0x00044018
		private void CheckListView()
		{
			this.chkunits.Clear();
			bool @checked = this.rdoAll.Checked;
			if (@checked)
			{
				this.chkAll = true;
			}
			else
			{
				this.chkAll = false;
				foreach (object obj in this.listViewEx.Items)
				{
					ListViewItem listViewItem = (ListViewItem)obj;
					bool checked2 = listViewItem.Checked;
					if (checked2)
					{
						this.chkunits.Add(Convert.ToByte(listViewItem.Tag));
					}
				}
			}
		}

		// Token: 0x060002AE RID: 686 RVA: 0x00045ECC File Offset: 0x000440CC
		private void MakeListView()
		{
			bool flag = this.chkunits.Count == 0;
			if (!flag)
			{
				int num = 0;
				foreach (object obj in this.listViewEx.Items)
				{
					ListViewItem listViewItem = (ListViewItem)obj;
					bool flag2 = Convert.ToByte(listViewItem.Tag) == this.chkunits[num];
					if (flag2)
					{
						listViewItem.Checked = true;
						bool flag3 = num < this.chkunits.Count - 1;
						if (flag3)
						{
							num++;
						}
					}
					else
					{
						listViewItem.Checked = false;
					}
				}
			}
		}

		// Token: 0x060002AF RID: 687 RVA: 0x00045F98 File Offset: 0x00044198
		private void GetProductsBytes()
		{
			this.products.Clear();
			this.products.AddRange(Encoding.UTF8.GetBytes("SUPCON"));
			this.products.Add(170);
			this.products.Add(170);
			for (int i = 1; i <= 5; i++)
			{
				List<byte> list = new List<byte>();
				AutoComboBox autoComboBox = (AutoComboBox)this.groupProduct.Controls.Find("cmbProduct" + i.ToString(), true)[0];
				bool flag = autoComboBox.SelectedIndex > -1;
				if (flag)
				{
					list.Add(Convert.ToByte(autoComboBox.SelectedValue));
					list.AddRange(Encoding.UTF8.GetBytes(autoComboBox.Text));
					this.PadRight(list, 24);
				}
				else
				{
					this.PadRight(list, 24);
				}
				this.products.AddRange(list);
			}
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x0004609C File Offset: 0x0004429C
		private void SetProductsBytes()
		{
			bool flag = Encoding.UTF8.GetString(this.products.Sub(0, 6).ToArray()) == "SUPCON" && this.products[0] == 170 && this.products[1] == 170;
			if (flag)
			{
				this.products.Sub(0, 2);
				int num = 1;
				while (this.products.Count >= 24 && num <= 5)
				{
					List<byte> list = this.products.Sub(0, 24);
					bool flag2 = list[0] > 0;
					if (flag2)
					{
						AutoComboBox autoComboBox = (AutoComboBox)this.groupProduct.Controls.Find("cmbProduct" + num.ToString(), true)[0];
						autoComboBox.SelectedValue = ((int)list[0]).ToString();
					}
					num++;
				}
			}
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x000461A0 File Offset: 0x000443A0
		public void PadRight(List<byte> list, int count)
		{
			bool flag = count <= list.Count;
			if (!flag)
			{
				for (int i = list.Count; i < count; i++)
				{
					list.Add(0);
				}
			}
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x000461E0 File Offset: 0x000443E0
		private byte GetByteFromAble(bool able)
		{
			byte result;
			if (able)
			{
				result = 170;
			}
			else
			{
				result = 85;
			}
			return result;
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x0004620C File Offset: 0x0004440C
		private bool GetAbleFromByte(byte inbyte)
		{
			return inbyte != 85 && inbyte == 170;
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x00046240 File Offset: 0x00044440
		private void chkUseCount_CheckedChanged(object sender, EventArgs e)
		{
			this.intUseCount.Enabled = this.chkUseCount.Checked;
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x0004625A File Offset: 0x0004445A
		private void chkLifeDate_CheckedChanged(object sender, EventArgs e)
		{
			this.datLifeDate.Enabled = this.chkLifeDate.Checked;
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x00046274 File Offset: 0x00044474
		private void btnAll_Click(object sender, EventArgs e)
		{
			foreach (object obj in this.listViewEx.Items)
			{
				ListViewItem listViewItem = (ListViewItem)obj;
				listViewItem.Checked = true;
			}
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x000462D8 File Offset: 0x000444D8
		private void btnNoAll_Click(object sender, EventArgs e)
		{
			foreach (object obj in this.listViewEx.Items)
			{
				ListViewItem listViewItem = (ListViewItem)obj;
				listViewItem.Checked = false;
			}
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x0004633C File Offset: 0x0004453C
		private void rdoAll_CheckedChanged(object sender, EventArgs e)
		{
			this.groupUnits.Enabled = !this.rdoAll.Checked;
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x00003040 File Offset: 0x00001240
		private void rdoPart_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x04000454 RID: 1108
		private List<ModCfg_unitgroup> _listgroup = new List<ModCfg_unitgroup>();

		// Token: 0x04000455 RID: 1109
		private byte[] mPwd = new byte[]
		{
			byte.MaxValue,
			byte.MaxValue,
			byte.MaxValue,
			byte.MaxValue,
			byte.MaxValue,
			byte.MaxValue
		};

		// Token: 0x04000456 RID: 1110
		private List<byte> chkunits = new List<byte>();

		// Token: 0x04000457 RID: 1111
		private int chkunitscount = 0;

		// Token: 0x04000458 RID: 1112
		private bool chkAll = false;

		// Token: 0x04000459 RID: 1113
		private List<byte> products = new List<byte>();
	}
}
