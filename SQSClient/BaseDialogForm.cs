using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using Assistant;
using AutocompleteMenuNS;
using Base;
using DAL.Base;
using DAL.Base.SQSConfig;
using DAL.SQLServer.SQSConfig;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using DevComponents.Editors;
using InterHandle;
using Model;
using Model.SQSConfig;

namespace SQSClient
{
	// Token: 0x0200000B RID: 11
	public partial class BaseDialogForm : BaseForm
	{
		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000038 RID: 56 RVA: 0x00002A50 File Offset: 0x00000C50
		// (remove) Token: 0x06000039 RID: 57 RVA: 0x00002A84 File Offset: 0x00000C84
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public static event OperateDelegate OperateEventHandler;

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600003A RID: 58 RVA: 0x00002AB8 File Offset: 0x00000CB8
		// (set) Token: 0x0600003B RID: 59 RVA: 0x00002AD0 File Offset: 0x00000CD0
		public object Sender
		{
			get
			{
				return this._Sender;
			}
			set
			{
				this._Sender = value;
				this.Text = ((ButtonItem)this._Sender).Text;
				bool flag = this._ParentMenuId == 0;
				if (flag)
				{
					this._Mod = DAL.Base.SQSConfig.DalSys_authority.Instance.GetModel(new List<string>
					{
						"GroupId",
						"MenuName"
					}, new List<object>
					{
						GlobalKey.GroupId,
						((BaseItem)this._Sender).Name.Replace("sitem", "").Replace("item", "")
					});
				}
				else
				{
					this._Mod = DAL.Base.SQSConfig.DalSys_authority.Instance.GetModel(new List<string>
					{
						"GroupId",
						"MenuName",
						"ParentId"
					}, new List<object>
					{
						GlobalKey.GroupId,
						((BaseItem)this._Sender).Name.Replace("sitem", "").Replace("item", "").Replace("btn", ""),
						this._ParentMenuId
					});
				}
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600003C RID: 60 RVA: 0x00002C30 File Offset: 0x00000E30
		public string GetSelectIds
		{
			get
			{
				return this.mSelectIds;
			}
		}

		// Token: 0x17000016 RID: 22
		// (set) Token: 0x0600003D RID: 61 RVA: 0x00002C48 File Offset: 0x00000E48
		public string SetExtCondition
		{
			set
			{
				this._ExtCondition = value;
			}
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00002C54 File Offset: 0x00000E54
		public BaseDialogForm()
		{
			this.InitializeComponent();
			this.FormStyle();
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00002CB4 File Offset: 0x00000EB4
		protected void FormStyle()
		{
			base.MinimizeBox = false;
			base.MaximizeBox = false;
			base.SetStyle(ControlStyles.ResizeRedraw | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
			base.UpdateStyles();
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00002CDC File Offset: 0x00000EDC
		protected override void OnPaintBackground(PaintEventArgs e)
		{
			bool flag = base.WindowState != FormWindowState.Minimized || (base.ClientRectangle.Width > 0 && base.ClientRectangle.Height > 0);
			if (flag)
			{
				base.OnPaintBackground(e);
			}
			else
			{
				base.OnPaintBackground(e);
			}
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00002D38 File Offset: 0x00000F38
		protected void InitButton()
		{
			FileInfo[] source = null;
			try
			{
				SQLHandleSE sqlhandleSE = new SQLHandleSE();
				sqlhandleSE.SQLHelper.MyConnectionString = ConfigSettings.Instance.ConfigConn;
				bool flag = sqlhandleSE.SQLHelper.Connect();
				if (flag)
				{
					sqlhandleSE.TableName = "sys_dynamicbutton";
					sqlhandleSE.ForW = new List<string>
					{
						"ScreenName='" + base.Name + "'"
					};
					List<Dictionary<string, object>> list = sqlhandleSE.Activity();
					bool flag2 = list.Count > 0;
					if (flag2)
					{
						DirectoryInfo directoryInfo = new DirectoryInfo(Application.StartupPath + "\\Button");
						source = directoryInfo.GetFiles();
					}
					using (List<Dictionary<string, object>>.Enumerator enumerator = list.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							Dictionary<string, object> listson = enumerator.Current;
							FileInfo fileInfo = source.ToList<FileInfo>().Find((FileInfo d) => d.Name.Replace(d.Extension, "") == listson["ButtonName"].ToString());
							bool flag3 = fileInfo != null;
							if (flag3)
							{
								Assembly assembly = Assembly.LoadFrom(fileInfo.FullName);
								Type type = assembly.GetType(fileInfo.Name.Replace(fileInfo.Extension, ".") + "Form1");
								object obj = Activator.CreateInstance(type);
								SelfFroms selfFroms = new SelfFroms();
								BaseForm from = (BaseForm)obj;
								selfFroms.From1 = from;
								selfFroms.From1.Icon = base.Icon;
								selfFroms.From1.Text = listson["ButtonText"].ToString();
								selfFroms.Name = listson["ButtonName"].ToString();
								BaseDialogForm.listSelfFroms.Add(selfFroms);
								ButtonItem buttonItem = new ButtonItem();
								buttonItem.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far;
								buttonItem.Text = listson["ButtonText"].ToString();
								buttonItem.Name = listson["ButtonName"].ToString();
								buttonItem.Click += this.button_Click;
								((Bar)base.Controls.Find("bar", true)[0]).Items.Add(buttonItem);
							}
						}
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00002FD4 File Offset: 0x000011D4
		public void button_Click(object sender, EventArgs e)
		{
			BaseForm from = BaseDialogForm.listSelfFroms.Find((SelfFroms s) => s.Name == ((ButtonItem)sender).Name).From1;
			from._CurrentId = this._CurrentId;
			bool flag = from.ShowDialog() == DialogResult.OK;
			if (flag)
			{
				this.OnLoad(e);
			}
		}

		// Token: 0x06000043 RID: 67 RVA: 0x0000302E File Offset: 0x0000122E
		public override void SetText(OfficeForm frm)
		{
			this.InitButton();
			base.SetText(frm);
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00003040 File Offset: 0x00001240
		protected void InitAuthority()
		{
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00003044 File Offset: 0x00001244
		protected void InitBurron()
		{
			bool flag = this._Mod == null;
			if (flag)
			{
				bool flag2 = GlobalKey.UserId == 0 && GlobalKey.GroupId == 0;
				if (flag2)
				{
					this._canModify = true;
				}
			}
			else
			{
				List<string> list = new List<string>();
				list.Add("GroupId='" + this._Mod.GroupId.ToString() + "'");
				list.Add("ParentId='" + this._Mod.MenuId.ToString() + "'");
				List<ModSys_authority> listRequire = DAL.Base.SQSConfig.DalSys_authority.Instance.GetListRequire(list, null, null);
				foreach (ModSys_authority modSys_authority in listRequire)
				{
					foreach (Control control in this._Controls)
					{
						string fullName = control.GetType().FullName;
						string text = fullName;
						if (text != null)
						{
							if (!(text == "DevComponents.DotNetBar.Bar"))
							{
								if (!(text == "System.Windows.Forms.ContextMenuStrip"))
								{
									if (text == "DevComponents.DotNetBar.Controls.DataGridViewX")
									{
										bool flag3 = ((DataGridViewX)control).Columns.Contains("C_" + modSys_authority.MenuName);
										if (flag3)
										{
											((DataGridViewX)control).Columns["C_" + modSys_authority.MenuName].Visible = (modSys_authority.State && modSys_authority.Choosed > 0);
										}
										bool flag4 = modSys_authority.MenuName.Contains("Modify");
										if (flag4)
										{
											this._canModify = (modSys_authority.State && modSys_authority.Choosed > 0);
										}
									}
								}
								else
								{
									bool flag5 = ((ContextMenuStrip)control).Items.ContainsKey("tool" + modSys_authority.MenuName);
									if (flag5)
									{
										((ContextMenuStrip)control).Items["tool" + modSys_authority.MenuName].Visible = (modSys_authority.State && modSys_authority.Choosed > 0);
										((ContextMenuStrip)control).Items["tool" + modSys_authority.MenuName].Enabled = (modSys_authority.State && modSys_authority.Choosed > 0);
									}
								}
							}
							else
							{
								bool flag6 = ((Bar)control).Items.Contains("btn" + modSys_authority.MenuName);
								if (flag6)
								{
									((Bar)control).Items["btn" + modSys_authority.MenuName].Visible = (modSys_authority.State && modSys_authority.Choosed > 0);
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00003398 File Offset: 0x00001598
		public void CreateDgv(DataGridViewX dgvData, string CTableName)
		{
			List<ModItemC> allList = DalSQLBase.Instance.GetAllList(CTableName);
			foreach (ModItemC modItemC in allList)
			{
				bool flag = this.CheckColumn(dgvData, modItemC);
				if (!flag)
				{
					DataGridViewColumn dataGridViewColumn = new DataGridViewTextBoxColumn();
					bool flag2 = !modItemC.ReadOnly;
					if (flag2)
					{
						string dataType = modItemC.DataType;
						string text = dataType;
						if (text == null)
						{
							goto IL_1B9;
						}
						uint num = <PrivateImplementationDetails>.ComputeStringHash(text);
						if (num <= 1623908912U)
						{
							if (num <= 750634308U)
							{
								if (num != 520654156U)
								{
									if (num != 750634308U)
									{
										goto IL_1B9;
									}
									if (!(text == "tinyint"))
									{
										goto IL_1B9;
									}
									goto IL_1A9;
								}
								else
								{
									if (!(text == "decimal"))
									{
										goto IL_1B9;
									}
									goto IL_1B1;
								}
							}
							else if (num != 1539863742U)
							{
								if (num != 1623908912U)
								{
									goto IL_1B9;
								}
								if (!(text == "bit"))
								{
									goto IL_1B9;
								}
							}
							else if (!(text == "nvarchar"))
							{
								goto IL_1B9;
							}
						}
						else if (num <= 2515107422U)
						{
							if (num != 1761125480U)
							{
								if (num != 2515107422U)
								{
									goto IL_1B9;
								}
								if (!(text == "int"))
								{
									goto IL_1B9;
								}
								goto IL_1A9;
							}
							else
							{
								if (!(text == "numeric"))
								{
									goto IL_1B9;
								}
								goto IL_1A9;
							}
						}
						else if (num != 2797886853U)
						{
							if (num != 3437915536U)
							{
								if (num != 4163743794U)
								{
									goto IL_1B9;
								}
								if (!(text == "varchar"))
								{
									goto IL_1B9;
								}
							}
							else if (!(text == "datetime"))
							{
								goto IL_1B9;
							}
						}
						else
						{
							if (!(text == "float"))
							{
								goto IL_1B9;
							}
							goto IL_1B1;
						}
						dataGridViewColumn = new DataGridViewTextBoxColumn();
						goto IL_1C1;
						IL_1A9:
						dataGridViewColumn = new DataGridViewIntegerInputColumn();
						goto IL_1C1;
						IL_1B1:
						dataGridViewColumn = new DataGridViewDoubleInputColumn();
						IL_1C1:
						goto IL_1C2;
						IL_1B9:
						dataGridViewColumn = new DataGridViewTextBoxColumn();
					}
					IL_1C2:
					dataGridViewColumn.Name = "C_" + modItemC.ItemName;
					dataGridViewColumn.HeaderText = ShowWords.ReplaceText(modItemC.ItemName);
					dataGridViewColumn.DataPropertyName = modItemC.ItemName;
					dataGridViewColumn.DefaultCellStyle.BackColor = ItemHelpr.GetColorByString(modItemC.BackColor);
					dataGridViewColumn.ReadOnly = modItemC.ReadOnly;
					dgvData.Columns.Add(dataGridViewColumn);
				}
			}
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00003608 File Offset: 0x00001808
		private bool CheckColumn(DataGridViewX dgvData, ModItemC mod)
		{
			foreach (object obj in dgvData.Columns)
			{
				DataGridViewColumn dataGridViewColumn = (DataGridViewColumn)obj;
				bool flag = dataGridViewColumn.DataPropertyName == mod.ItemName;
				if (flag)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00003684 File Offset: 0x00001884
		public object GetValueMod<T>(T mod, string name)
		{
			object result = "";
			Type type = mod.GetType();
			foreach (PropertyInfo propertyInfo in type.GetProperties())
			{
				bool flag = name == propertyInfo.Name;
				if (flag)
				{
					result = propertyInfo.GetValue(mod, null);
					break;
				}
			}
			return result;
		}

		// Token: 0x06000049 RID: 73 RVA: 0x000036F0 File Offset: 0x000018F0
		public void SetValueMod<T>(T mod, string name, object value)
		{
			Type type = mod.GetType();
			foreach (PropertyInfo propertyInfo in type.GetProperties())
			{
				bool flag = name == propertyInfo.Name;
				if (flag)
				{
					string name2 = propertyInfo.PropertyType.Name;
					string text = name2;
					if (text != null)
					{
						if (text == "Boolean")
						{
							propertyInfo.SetValue(mod, bool.Parse((value.ToString() == "") ? "false" : value.ToString()), null);
							break;
						}
						if (text == "Decimal")
						{
							propertyInfo.SetValue(mod, decimal.Parse((value.ToString() == "") ? "0" : value.ToString()), null);
							break;
						}
						if (text == "int")
						{
							propertyInfo.SetValue(mod, int.Parse((value.ToString() == "") ? "0" : value.ToString()), null);
							break;
						}
					}
					propertyInfo.SetValue(mod, value, null);
					break;
				}
			}
		}

		// Token: 0x0600004A RID: 74 RVA: 0x0000384C File Offset: 0x00001A4C
		public void BindAutocompleteMenu(Control control, List<AutocompleteItem> items)
		{
			AutocompleteMenu autocompleteMenu = new AutocompleteMenu();
			autocompleteMenu.MaximumSize = new Size(300, 200);
			autocompleteMenu.MinFragmentLength = 1;
			autocompleteMenu.SetAutocompleteMenu(control, autocompleteMenu);
			autocompleteMenu.SetAutocompleteItems(items);
		}

		// Token: 0x0600004B RID: 75 RVA: 0x0000388F File Offset: 0x00001A8F
		protected void ToolTipHide()
		{
			this.toolTip.Hide(this);
		}

		// Token: 0x0600004C RID: 76 RVA: 0x000038A0 File Offset: 0x00001AA0
		protected void ToolTipShow(Control cell)
		{
			bool flag = cell == null;
			if (!flag)
			{
				double number;
				bool flag2 = !double.TryParse(cell.Text, out number);
				if (!flag2)
				{
					this.toolTip.OwnerDraw = true;
					this.toolTip.Show(this.ChangeNum(number), cell, 0, cell.Height, 5000);
				}
			}
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00003900 File Offset: 0x00001B00
		private void toolTip_Draw(object sender, DrawToolTipEventArgs e)
		{
			e.Graphics.FillRectangle(Brushes.AliceBlue, e.Bounds);
			e.Graphics.DrawRectangle(Pens.Chocolate, new Rectangle(0, 0, e.Bounds.Width - 1, e.Bounds.Height - 1));
			e.Graphics.DrawString(e.ToolTipText, e.Font, Brushes.Red, e.Bounds);
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00003985 File Offset: 0x00001B85
		protected void ToolTipShow(DoubleInput col)
		{
			this.toolTip.OwnerDraw = false;
			this.toolTip.Show(this.ChangeNum(col.Value), col, 0, col.Height, 5000);
		}

		// Token: 0x0600004F RID: 79 RVA: 0x000039BC File Offset: 0x00001BBC
		public string ChangeNum(double number)
		{
			int num = 3;
			string[] array = new string[]
			{
				"",
				" thousand",
				" million",
				" billion"
			};
			string language = ConfigSettings.Instance.Language;
			string text = language;
			if (text != null)
			{
				if (!(text == "ZH"))
				{
					if (text == "EN")
					{
						num = 3;
						array = new string[]
						{
							"",
							" thousand",
							" million",
							" billion"
						};
					}
				}
				else
				{
					num = 4;
					array = new string[]
					{
						"",
						" 万",
						" 亿"
					};
				}
			}
			string text2 = number.ToString();
			string text3 = Math.Floor(number).ToString();
			int num2 = (text3.Length - 1) / num;
			int num3 = 1;
			while (num3 <= num2 && num2 < array.Length)
			{
				text2 = text2.Insert(text3.Length - num * num3, array[num3]);
				num3++;
			}
			bool flag = text3.Length < num;
			if (flag)
			{
				text2 = null;
			}
			return text2;
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00003AEC File Offset: 0x00001CEC
		protected bool IsExist(string tabelename, string column, object value, SqlDbType type)
		{
			bool flag = true;
			bool flag2 = !GeneralOperation.Instance().IsExist(tabelename, column, value, type, ref flag);
			return !flag2 && flag;
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00003B20 File Offset: 0x00001D20
		protected bool IsExistOutSelf(string tabelename, string column, object value, SqlDbType type, int currentId)
		{
			bool flag = true;
			bool flag2 = !GeneralOperation.Instance().IsExistOutSelf(tabelename, column, value, type, currentId, ref flag);
			return !flag2 && flag;
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00003B58 File Offset: 0x00001D58
		public bool TimeCheck(DateTime strDate, DateTime endDate)
		{
			bool flag = strDate > endDate;
			bool result;
			if (flag)
			{
				base.ShowMsg("TimeReset", "", "");
				result = false;
			}
			else
			{
				result = true;
			}
			return result;
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00003B94 File Offset: 0x00001D94
		public void AddLog(string desc)
		{
			ModT_log modT_log = new ModT_log();
			modT_log.LogDesc = desc;
			modT_log.LogTime = DateTime.Now;
			modT_log.PC = GlobalKey.PCName;
			modT_log.User = GlobalKey.UserName;
			DAL.Base.SQSConfig.DalT_log.Instance.Add(modT_log);
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00003BE0 File Offset: 0x00001DE0
		private void BaseDialogForm_Load(object sender, EventArgs e)
		{
			BaseDialogForm._operateArgs.Object = base.GetType().Name;
			BaseDialogForm._operateArgs.OperateType = this.Text;
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00003C0A File Offset: 0x00001E0A
		protected virtual void OnOperateSuccess(ModSys_operatelog operateArgs, object req, object resp)
		{
			this.OnOperate(operateArgs, req, resp, 1);
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00003C18 File Offset: 0x00001E18
		protected virtual void OnOperateSuccess(object req, object resp)
		{
			this.OnOperate(req, resp, 1);
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00003C25 File Offset: 0x00001E25
		protected virtual void OnOperateSuccess(object newValue, object oldValue, object resp)
		{
			this.OnOperate(new
			{
				New = newValue,
				Old = oldValue
			}, resp, 1);
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00003C38 File Offset: 0x00001E38
		protected virtual void OnOperateFail(ModSys_operatelog operateArgs, object req, object resp)
		{
			this.OnOperate(operateArgs, req, resp, 0);
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00003C46 File Offset: 0x00001E46
		protected virtual void OnOperateFail(object req, object resp)
		{
			this.OnOperate(req, resp, 0);
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00003C53 File Offset: 0x00001E53
		protected virtual void OnOperateFail(object newValue, object oldValue, object resp)
		{
			this.OnOperate(new
			{
				New = newValue,
				Old = oldValue
			}, resp, 0);
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00003C66 File Offset: 0x00001E66
		protected virtual void OnOperateException(ModSys_operatelog operateArgs, object req, object resp, string errMsg)
		{
			operateArgs.ErrMsg = errMsg;
			this.OnOperate(operateArgs, req, resp, 0);
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00003C7D File Offset: 0x00001E7D
		protected virtual void OnOperateException(object req, object resp, string errMsg)
		{
			BaseDialogForm._operateArgs.ErrMsg = errMsg;
			this.OnOperate(req, resp, 0);
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00003C98 File Offset: 0x00001E98
		private void OnOperate(object req, object resp, int operateStatus)
		{
			BaseDialogForm._operateArgs.Method = new StackTrace().GetFrame(2).GetMethod().Name;
			BaseDialogForm._operateArgs.OperateStatus = operateStatus;
			OperateDelegate operateEventHandler = BaseDialogForm.OperateEventHandler;
			if (operateEventHandler != null)
			{
				operateEventHandler(BaseDialogForm._operateArgs, req, resp);
			}
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00003CEA File Offset: 0x00001EEA
		private void OnOperate(ModSys_operatelog operateArgs, object req, object resp, int operateStatus)
		{
			operateArgs.Method = new StackTrace().GetFrame(2).GetMethod().Name;
			operateArgs.OperateStatus = operateStatus;
			OperateDelegate operateEventHandler = BaseDialogForm.OperateEventHandler;
			if (operateEventHandler != null)
			{
				operateEventHandler(operateArgs, req, resp);
			}
		}

		// Token: 0x04000014 RID: 20
		public static ModSys_operatelog _operateArgs = new ModSys_operatelog();

		// Token: 0x04000016 RID: 22
		protected List<Control> _Controls = new List<Control>();

		// Token: 0x04000017 RID: 23
		public ModSys_authority _Mod = null;

		// Token: 0x04000018 RID: 24
		public int _ParentMenuId = 0;

		// Token: 0x04000019 RID: 25
		protected object _Sender = null;

		// Token: 0x0400001A RID: 26
		protected string mSelectIds = string.Empty;

		// Token: 0x0400001B RID: 27
		protected string _ExtCondition = string.Empty;

		// Token: 0x0400001C RID: 28
		public static List<SelfFroms> listSelfFroms = new List<SelfFroms>();
	}
}
