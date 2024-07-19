using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Assistant;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using DevComponents.DotNetBar.Layout;
using DevComponents.Editors.DateTimeAdv;
using InterHandle;
using Microsoft.CSharp.RuntimeBinder;
using Newtonsoft.Json;
using SQSClient.Properties;

namespace SQSClient
{
	// Token: 0x02000015 RID: 21
	public partial class frmSearchVehicle : BaseDialogForm
	{
		// Token: 0x060000C8 RID: 200 RVA: 0x00017C1C File Offset: 0x00015E1C
		public frmSearchVehicle(int id)
		{
			this.InitializeComponent();
			this.SetText(this);
			this._Controls.Clear();
			this._Controls.Add(this.bar);
			this._Controls.Add(this.flowLayoutPanel1);
			this._CurrentId = id;
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00017CC8 File Offset: 0x00015EC8
		private void frmSearchVehicle_Load(object sender, EventArgs e)
		{
			base.InitBurron();
			this.InitControl();
			this.LoadData("");
			BaseDialogForm._operateArgs.Category = this.Text;
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00017CF6 File Offset: 0x00015EF6
		private void InitControl()
		{
			this.rdoVehicle.Checked = true;
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00003040 File Offset: 0x00001240
		protected override void LoadData(string Name)
		{
		}

		// Token: 0x060000CC RID: 204 RVA: 0x00017D08 File Offset: 0x00015F08
		private void btnSearch_Click(object sender, EventArgs e)
		{
			foreach (Control control in this.list)
			{
				this.flowLayoutPanel1.Controls.Remove(control);
				control.Dispose();
			}
			this.list.RemoveRange(0, this.list.Count);
			bool @checked = this.rdoVehicle.Checked;
			if (@checked)
			{
				this.VehicleType = "Vehicle";
			}
			else
			{
				bool checked2 = this.rdoVehicleOut.Checked;
				if (checked2)
				{
					this.VehicleType = "VehicleOut";
				}
				else
				{
					bool checked3 = this.rdoVehicleSt.Checked;
					if (checked3)
					{
						this.VehicleType = "VehicleSt";
					}
				}
			}
			SOAPHandle soaphandle = new SOAPHandle();
			soaphandle.URL = "http://" + this.strip + ":3721/WeightWCFService/TicketManage/?wsdl";
			Dictionary<string, object> dictionary = new Dictionary<string, object>();
			dictionary.Add("Id", this._CurrentId);
			dictionary.Add("VehicleType", this.VehicleType);
			soaphandle.MethodName = "GetVehicle";
			soaphandle.Paras = dictionary;
			object obj = soaphandle.Activity();
			Dictionary<string, object> dictionary2 = obj.ChangeD();
			bool flag = dictionary2["Code"].ToString() != "1";
			if (flag)
			{
				base.ShowMsg(dictionary2["Info"].ToString(), "", "");
			}
			else
			{
				object arg = JsonConvert.DeserializeObject<object>(dictionary2["Info"].ToString());
				if (frmSearchVehicle.<>o__7.<>p__1 == null)
				{
					frmSearchVehicle.<>o__7.<>p__1 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(frmSearchVehicle), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				Func<CallSite, object, string, object> target = frmSearchVehicle.<>o__7.<>p__1.Target;
				CallSite <>p__ = frmSearchVehicle.<>o__7.<>p__1;
				if (frmSearchVehicle.<>o__7.<>p__0 == null)
				{
					frmSearchVehicle.<>o__7.<>p__0 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(frmSearchVehicle), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				object arg2 = target(<>p__, frmSearchVehicle.<>o__7.<>p__0.Target(frmSearchVehicle.<>o__7.<>p__0, arg, "Body"), "Terms");
				if (frmSearchVehicle.<>o__7.<>p__2 == null)
				{
					frmSearchVehicle.<>o__7.<>p__2 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(frmSearchVehicle), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				object arg3 = frmSearchVehicle.<>o__7.<>p__2.Target(frmSearchVehicle.<>o__7.<>p__2, arg, "Tail");
				BaseItem baseItem = this.lblVehicleResult;
				if (frmSearchVehicle.<>o__7.<>p__6 == null)
				{
					frmSearchVehicle.<>o__7.<>p__6 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(frmSearchVehicle), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				Func<CallSite, object, bool> target2 = frmSearchVehicle.<>o__7.<>p__6.Target;
				CallSite <>p__2 = frmSearchVehicle.<>o__7.<>p__6;
				if (frmSearchVehicle.<>o__7.<>p__5 == null)
				{
					frmSearchVehicle.<>o__7.<>p__5 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Equal, typeof(frmSearchVehicle), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				Func<CallSite, object, string, object> target3 = frmSearchVehicle.<>o__7.<>p__5.Target;
				CallSite <>p__3 = frmSearchVehicle.<>o__7.<>p__5;
				if (frmSearchVehicle.<>o__7.<>p__4 == null)
				{
					frmSearchVehicle.<>o__7.<>p__4 = CallSite<Func<CallSite, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ToString", null, typeof(frmSearchVehicle), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				Func<CallSite, object, object> target4 = frmSearchVehicle.<>o__7.<>p__4.Target;
				CallSite <>p__4 = frmSearchVehicle.<>o__7.<>p__4;
				if (frmSearchVehicle.<>o__7.<>p__3 == null)
				{
					frmSearchVehicle.<>o__7.<>p__3 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(frmSearchVehicle), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				baseItem.Text = (target2(<>p__2, target3(<>p__3, target4(<>p__4, frmSearchVehicle.<>o__7.<>p__3.Target(frmSearchVehicle.<>o__7.<>p__3, arg3, "Result")), "1")) ? "车检通过" : "车检未通过");
				BaseItem baseItem2 = this.lblVehicleMan;
				if (frmSearchVehicle.<>o__7.<>p__8 == null)
				{
					frmSearchVehicle.<>o__7.<>p__8 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(frmSearchVehicle)));
				}
				Func<CallSite, object, string> target5 = frmSearchVehicle.<>o__7.<>p__8.Target;
				CallSite <>p__5 = frmSearchVehicle.<>o__7.<>p__8;
				if (frmSearchVehicle.<>o__7.<>p__7 == null)
				{
					frmSearchVehicle.<>o__7.<>p__7 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(frmSearchVehicle), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				baseItem2.Text = target5(<>p__5, frmSearchVehicle.<>o__7.<>p__7.Target(frmSearchVehicle.<>o__7.<>p__7, arg3, "Man"));
				BaseItem baseItem3 = this.lblVehicleTime;
				if (frmSearchVehicle.<>o__7.<>p__10 == null)
				{
					frmSearchVehicle.<>o__7.<>p__10 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(frmSearchVehicle)));
				}
				Func<CallSite, object, string> target6 = frmSearchVehicle.<>o__7.<>p__10.Target;
				CallSite <>p__6 = frmSearchVehicle.<>o__7.<>p__10;
				if (frmSearchVehicle.<>o__7.<>p__9 == null)
				{
					frmSearchVehicle.<>o__7.<>p__9 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(frmSearchVehicle), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				baseItem3.Text = target6(<>p__6, frmSearchVehicle.<>o__7.<>p__9.Target(frmSearchVehicle.<>o__7.<>p__9, arg3, "Time"));
				if (frmSearchVehicle.<>o__7.<>p__32 == null)
				{
					frmSearchVehicle.<>o__7.<>p__32 = CallSite<Func<CallSite, object, IEnumerable>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(IEnumerable), typeof(frmSearchVehicle)));
				}
				foreach (object arg4 in frmSearchVehicle.<>o__7.<>p__32.Target(frmSearchVehicle.<>o__7.<>p__32, arg2))
				{
					if (frmSearchVehicle.<>o__7.<>p__12 == null)
					{
						frmSearchVehicle.<>o__7.<>p__12 = CallSite<Func<CallSite, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ToString", null, typeof(frmSearchVehicle), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					Func<CallSite, object, object> target7 = frmSearchVehicle.<>o__7.<>p__12.Target;
					CallSite <>p__7 = frmSearchVehicle.<>o__7.<>p__12;
					if (frmSearchVehicle.<>o__7.<>p__11 == null)
					{
						frmSearchVehicle.<>o__7.<>p__11 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(frmSearchVehicle), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
						}));
					}
					object obj2 = target7(<>p__7, frmSearchVehicle.<>o__7.<>p__11.Target(frmSearchVehicle.<>o__7.<>p__11, arg4, "Type"));
					object obj3 = obj2;
					string text = obj3 as string;
					if (text != null)
					{
						if (!(text == "Title"))
						{
							if (!(text == "Edit"))
							{
								if (text == "Container")
								{
									GroupPanel groupPanel = new GroupPanel();
									LayoutControl layoutControl = new LayoutControl();
									if (frmSearchVehicle.<>o__7.<>p__20 == null)
									{
										frmSearchVehicle.<>o__7.<>p__20 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(frmSearchVehicle), new CSharpArgumentInfo[]
										{
											CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
											CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
										}));
									}
									object arg5 = frmSearchVehicle.<>o__7.<>p__20.Target(frmSearchVehicle.<>o__7.<>p__20, arg4, "Value");
									int num = 2;
									if (frmSearchVehicle.<>o__7.<>p__25 == null)
									{
										frmSearchVehicle.<>o__7.<>p__25 = CallSite<Func<CallSite, object, IEnumerable>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(IEnumerable), typeof(frmSearchVehicle)));
									}
									foreach (object arg6 in frmSearchVehicle.<>o__7.<>p__25.Target(frmSearchVehicle.<>o__7.<>p__25, arg5))
									{
										LayoutControlItem layoutControlItem = new LayoutControlItem();
										TextBoxX textBoxX = new TextBoxX();
										layoutControlItem.Control = textBoxX;
										layoutControlItem.Height = 29;
										layoutControlItem.MinSize = new Size(120, 0);
										layoutControlItem.Name = "layoutControlItem1" + num.ToString();
										LayoutItemBase layoutItemBase = layoutControlItem;
										if (frmSearchVehicle.<>o__7.<>p__22 == null)
										{
											frmSearchVehicle.<>o__7.<>p__22 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(frmSearchVehicle)));
										}
										Func<CallSite, object, string> target8 = frmSearchVehicle.<>o__7.<>p__22.Target;
										CallSite <>p__8 = frmSearchVehicle.<>o__7.<>p__22;
										if (frmSearchVehicle.<>o__7.<>p__21 == null)
										{
											frmSearchVehicle.<>o__7.<>p__21 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(frmSearchVehicle), new CSharpArgumentInfo[]
											{
												CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
												CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
											}));
										}
										layoutItemBase.Text = target8(<>p__8, frmSearchVehicle.<>o__7.<>p__21.Target(frmSearchVehicle.<>o__7.<>p__21, arg6, "Label"));
										layoutControlItem.TextAlignment = eTextAlignment.Right;
										layoutControlItem.Width = 100;
										layoutControlItem.WidthType = eLayoutSizeType.Percent;
										textBoxX.Border.Class = "TextBoxBorder";
										textBoxX.Border.CornerType = eCornerType.Square;
										textBoxX.Location = new Point(92, 4);
										textBoxX.Margin = new System.Windows.Forms.Padding(0);
										textBoxX.Name = "txtTest" + num.ToString();
										Control control2 = textBoxX;
										if (frmSearchVehicle.<>o__7.<>p__24 == null)
										{
											frmSearchVehicle.<>o__7.<>p__24 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(frmSearchVehicle)));
										}
										Func<CallSite, object, string> target9 = frmSearchVehicle.<>o__7.<>p__24.Target;
										CallSite <>p__9 = frmSearchVehicle.<>o__7.<>p__24;
										if (frmSearchVehicle.<>o__7.<>p__23 == null)
										{
											frmSearchVehicle.<>o__7.<>p__23 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(frmSearchVehicle), new CSharpArgumentInfo[]
											{
												CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
												CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
											}));
										}
										control2.Text = target9(<>p__9, frmSearchVehicle.<>o__7.<>p__23.Target(frmSearchVehicle.<>o__7.<>p__23, arg6, "Value"));
										textBoxX.PreventEnterBeep = true;
										textBoxX.Size = new Size(300, 21);
										textBoxX.TabIndex = 0;
										layoutControl.RootGroup.Items.Add(layoutControlItem);
										layoutControl.Controls.Add(textBoxX);
										num++;
									}
									layoutControl.Size = new Size(this.flowLayoutPanel1.Width - 30, 146);
									layoutControl.TabIndex = 0;
									groupPanel.BackColor = Color.Transparent;
									groupPanel.CanvasColor = SystemColors.Control;
									groupPanel.ColorSchemeStyle = eDotNetBarStyle.Office2007;
									groupPanel.DisabledBackColor = Color.Empty;
									groupPanel.DrawTitleBox = false;
									groupPanel.Location = new Point(3, 3);
									Control control3 = groupPanel;
									if (frmSearchVehicle.<>o__7.<>p__28 == null)
									{
										frmSearchVehicle.<>o__7.<>p__28 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(frmSearchVehicle)));
									}
									Func<CallSite, object, string> target10 = frmSearchVehicle.<>o__7.<>p__28.Target;
									CallSite <>p__10 = frmSearchVehicle.<>o__7.<>p__28;
									if (frmSearchVehicle.<>o__7.<>p__27 == null)
									{
										frmSearchVehicle.<>o__7.<>p__27 = CallSite<Func<CallSite, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ToString", null, typeof(frmSearchVehicle), new CSharpArgumentInfo[]
										{
											CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
										}));
									}
									Func<CallSite, object, object> target11 = frmSearchVehicle.<>o__7.<>p__27.Target;
									CallSite <>p__11 = frmSearchVehicle.<>o__7.<>p__27;
									if (frmSearchVehicle.<>o__7.<>p__26 == null)
									{
										frmSearchVehicle.<>o__7.<>p__26 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(frmSearchVehicle), new CSharpArgumentInfo[]
										{
											CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
											CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
										}));
									}
									control3.Name = target10(<>p__10, target11(<>p__11, frmSearchVehicle.<>o__7.<>p__26.Target(frmSearchVehicle.<>o__7.<>p__26, arg4, "Label")));
									groupPanel.Width = this.flowLayoutPanel1.Width - 30;
									groupPanel.Height = 200;
									groupPanel.Style.BackColor = Color.Transparent;
									groupPanel.Style.BackColor2 = Color.Transparent;
									groupPanel.Style.BackColorGradientAngle = 90;
									groupPanel.Style.BorderBottom = eStyleBorderType.Solid;
									groupPanel.Style.BorderBottomWidth = 1;
									groupPanel.Style.BorderColorSchemePart = eColorSchemePart.PanelBorder;
									groupPanel.Style.BorderLeft = eStyleBorderType.Solid;
									groupPanel.Style.BorderLeftWidth = 1;
									groupPanel.Style.BorderRight = eStyleBorderType.Solid;
									groupPanel.Style.BorderRightWidth = 1;
									groupPanel.Style.BorderTop = eStyleBorderType.Solid;
									groupPanel.Style.BorderTopWidth = 1;
									groupPanel.Style.CornerDiameter = 4;
									groupPanel.Style.CornerType = eCornerType.Rounded;
									groupPanel.Style.TextAlignment = eStyleTextAlignment.Center;
									groupPanel.Style.TextColorSchemePart = eColorSchemePart.PanelText;
									groupPanel.Style.TextLineAlignment = eStyleTextAlignment.Near;
									groupPanel.StyleMouseDown.CornerType = eCornerType.Square;
									groupPanel.StyleMouseOver.CornerType = eCornerType.Square;
									groupPanel.TabIndex = 0;
									Control control4 = groupPanel;
									if (frmSearchVehicle.<>o__7.<>p__31 == null)
									{
										frmSearchVehicle.<>o__7.<>p__31 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(frmSearchVehicle)));
									}
									Func<CallSite, object, string> target12 = frmSearchVehicle.<>o__7.<>p__31.Target;
									CallSite <>p__12 = frmSearchVehicle.<>o__7.<>p__31;
									if (frmSearchVehicle.<>o__7.<>p__30 == null)
									{
										frmSearchVehicle.<>o__7.<>p__30 = CallSite<Func<CallSite, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ToString", null, typeof(frmSearchVehicle), new CSharpArgumentInfo[]
										{
											CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
										}));
									}
									Func<CallSite, object, object> target13 = frmSearchVehicle.<>o__7.<>p__30.Target;
									CallSite <>p__13 = frmSearchVehicle.<>o__7.<>p__30;
									if (frmSearchVehicle.<>o__7.<>p__29 == null)
									{
										frmSearchVehicle.<>o__7.<>p__29 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(frmSearchVehicle), new CSharpArgumentInfo[]
										{
											CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
											CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
										}));
									}
									control4.Text = target12(<>p__12, target13(<>p__13, frmSearchVehicle.<>o__7.<>p__29.Target(frmSearchVehicle.<>o__7.<>p__29, arg4, "Label")));
									groupPanel.Controls.Add(layoutControl);
									this.list.Add(groupPanel);
								}
							}
							else
							{
								LayoutControl layoutControl2 = new LayoutControl();
								LayoutControlItem layoutControlItem2 = new LayoutControlItem();
								TextBoxX textBoxX2 = new TextBoxX();
								layoutControl2.RootGroup.Items.AddRange(new LayoutItemBase[]
								{
									layoutControlItem2
								});
								layoutControl2.Controls.Add(textBoxX2);
								layoutControl2.Size = new Size(this.flowLayoutPanel1.Width - 30, 30);
								layoutControl2.TabIndex = 0;
								textBoxX2.Border.Class = "TextBoxBorder";
								textBoxX2.Border.CornerType = eCornerType.Square;
								textBoxX2.Location = new Point(92, 4);
								textBoxX2.Margin = new System.Windows.Forms.Padding(0);
								textBoxX2.Name = "txtContractNum";
								Control control5 = textBoxX2;
								if (frmSearchVehicle.<>o__7.<>p__17 == null)
								{
									frmSearchVehicle.<>o__7.<>p__17 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(frmSearchVehicle)));
								}
								Func<CallSite, object, string> target14 = frmSearchVehicle.<>o__7.<>p__17.Target;
								CallSite <>p__14 = frmSearchVehicle.<>o__7.<>p__17;
								if (frmSearchVehicle.<>o__7.<>p__16 == null)
								{
									frmSearchVehicle.<>o__7.<>p__16 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(frmSearchVehicle), new CSharpArgumentInfo[]
									{
										CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
										CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
									}));
								}
								control5.Text = target14(<>p__14, frmSearchVehicle.<>o__7.<>p__16.Target(frmSearchVehicle.<>o__7.<>p__16, arg4, "Value"));
								textBoxX2.PreventEnterBeep = true;
								textBoxX2.Size = new Size(300, 21);
								textBoxX2.TabIndex = 0;
								layoutControlItem2.Control = textBoxX2;
								layoutControlItem2.Height = 29;
								layoutControlItem2.MinSize = new Size(120, 0);
								layoutControlItem2.Name = "layoutControlItem11";
								LayoutItemBase layoutItemBase2 = layoutControlItem2;
								if (frmSearchVehicle.<>o__7.<>p__19 == null)
								{
									frmSearchVehicle.<>o__7.<>p__19 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(frmSearchVehicle)));
								}
								Func<CallSite, object, string> target15 = frmSearchVehicle.<>o__7.<>p__19.Target;
								CallSite <>p__15 = frmSearchVehicle.<>o__7.<>p__19;
								if (frmSearchVehicle.<>o__7.<>p__18 == null)
								{
									frmSearchVehicle.<>o__7.<>p__18 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(frmSearchVehicle), new CSharpArgumentInfo[]
									{
										CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
										CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
									}));
								}
								layoutItemBase2.Text = target15(<>p__15, frmSearchVehicle.<>o__7.<>p__18.Target(frmSearchVehicle.<>o__7.<>p__18, arg4, "Label"));
								layoutControlItem2.TextAlignment = eTextAlignment.Right;
								layoutControlItem2.Width = 100;
								layoutControlItem2.WidthType = eLayoutSizeType.Percent;
								this.list.Add(layoutControl2);
							}
						}
						else
						{
							Label label = new Label();
							label.Location = new Point(0, 323);
							label.Size = new Size(this.flowLayoutPanel1.Width - 30, 30);
							Control control6 = label;
							if (frmSearchVehicle.<>o__7.<>p__15 == null)
							{
								frmSearchVehicle.<>o__7.<>p__15 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(frmSearchVehicle)));
							}
							Func<CallSite, object, string> target16 = frmSearchVehicle.<>o__7.<>p__15.Target;
							CallSite <>p__16 = frmSearchVehicle.<>o__7.<>p__15;
							if (frmSearchVehicle.<>o__7.<>p__14 == null)
							{
								frmSearchVehicle.<>o__7.<>p__14 = CallSite<Func<CallSite, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ToString", null, typeof(frmSearchVehicle), new CSharpArgumentInfo[]
								{
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
								}));
							}
							Func<CallSite, object, object> target17 = frmSearchVehicle.<>o__7.<>p__14.Target;
							CallSite <>p__17 = frmSearchVehicle.<>o__7.<>p__14;
							if (frmSearchVehicle.<>o__7.<>p__13 == null)
							{
								frmSearchVehicle.<>o__7.<>p__13 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(frmSearchVehicle), new CSharpArgumentInfo[]
								{
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
								}));
							}
							control6.Text = target16(<>p__16, target17(<>p__17, frmSearchVehicle.<>o__7.<>p__13.Target(frmSearchVehicle.<>o__7.<>p__13, arg4, "Label")));
							label.BackColor = Color.FromArgb(194, 217, 247);
							label.TextAlign = ContentAlignment.MiddleCenter;
							this.list.Add(label);
						}
					}
				}
				Control[] array = new Control[this.list.Count];
				for (int i = 0; i < this.list.Count; i++)
				{
					array[i] = this.list[i];
				}
				this.flowLayoutPanel1.BackColor = Color.FromArgb(194, 217, 247);
				this.flowLayoutPanel1.Controls.AddRange(array);
			}
		}

		// Token: 0x04000189 RID: 393
		private string strip = ConfigSettings.Instance.ConfigConn.Split(new char[]
		{
			';'
		})[0].Split(new char[]
		{
			'='
		})[1];

		// Token: 0x0400018A RID: 394
		private string VehicleType = "";

		// Token: 0x0400018B RID: 395
		private List<Control> list = new List<Control>();
	}
}
