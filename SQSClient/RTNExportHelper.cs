using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using Model.SQSConfig;

namespace SQSClient
{
	// Token: 0x02000072 RID: 114
	public class RTNExportHelper
	{
		// Token: 0x0600062B RID: 1579 RVA: 0x00099AD8 File Offset: 0x00097CD8
		public bool ExportConfigFile(string strFilePath, List<ModCfg_device> listDevice, List<ModCfg_unit> listUnit, List<ModCfg_devitem> listDevItem)
		{
			this._ListDevice = listDevice;
			this._ListUnit = listUnit;
			this._ListDevItem = listDevItem;
			bool flag = !this.InitItemListInfo();
			bool result;
			if (flag)
			{
				result = false;
			}
			else
			{
				try
				{
					FileStream stream = new FileStream(strFilePath + "_his.csv", FileMode.Create, FileAccess.Write, FileShare.None);
					StreamWriter streamWriter = new StreamWriter(stream, Encoding.Default);
					streamWriter.WriteLine("点名称,参数名称,保存方式,参数");
					this.AddHisCsvItem(streamWriter);
					streamWriter.Close();
					FileStream stream2 = new FileStream(strFilePath + "_basic.csv", FileMode.Create, FileAccess.Write, FileShare.None);
					StreamWriter streamWriter2 = new StreamWriter(stream2, Encoding.Default);
					this.AddBasicCsvItem(streamWriter2, 0, (from x in this._ListItem
					where x.DataStyle.Equals("Floating")
					select x).ToList<ViewCfgItem>());
					this.AddBasicCsvItem(streamWriter2, 1, (from x in this._ListItem
					where x.DataStyle.Equals("Boolean")
					select x).ToList<ViewCfgItem>());
					streamWriter2.Close();
					FileStream stream3 = new FileStream(strFilePath + "_link.csv", FileMode.Create, FileAccess.Write, FileShare.None);
					StreamWriter streamWriter3 = new StreamWriter(stream3, Encoding.Default);
					streamWriter3.WriteLine("点名称,参数名称,链接方式,参数1,参数2,参数3");
					this.AddLinkCsvItem(streamWriter3);
					streamWriter3.Close();
					FileStream stream4 = new FileStream(strFilePath + "_ConditionTag.dat", FileMode.Create, FileAccess.Write, FileShare.None);
					StreamWriter streamWriter4 = new StreamWriter(stream4, Encoding.Default);
					streamWriter4.WriteLine("1");
					streamWriter4.WriteLine("0");
					streamWriter4.Close();
					FileStream stream5 = new FileStream(strFilePath + "_layer.dat", FileMode.Create, FileAccess.Write, FileShare.None);
					StreamWriter streamWriter5 = new StreamWriter(stream5, Encoding.Default);
					streamWriter5.WriteLine("<?xml version=\"1.0\" encoding=\"utf-8\"?>");
					streamWriter5.WriteLine("<DbManger>");
					int num = 1;
					foreach (string text in this._ListArea)
					{
						streamWriter5.WriteLine(string.Concat(new string[]
						{
							"<LAYER NodeID=\"",
							num.ToString(),
							"\" Name=\"",
							text,
							"\"/>"
						}));
					}
					streamWriter5.WriteLine("</DbManger>");
					streamWriter5.Close();
				}
				catch (Exception ex)
				{
					return false;
				}
				result = true;
			}
			return result;
		}

		// Token: 0x0600062C RID: 1580 RVA: 0x00099D78 File Offset: 0x00097F78
		protected bool InitItemListInfo()
		{
			try
			{
				this._ListItem.Clear();
				this._ListUnitCode.Clear();
				this._ListArea.Clear();
				string text = string.Empty;
				string text2 = string.Empty;
				string empty = string.Empty;
				string empty2 = string.Empty;
				using (List<ModCfg_unit>.Enumerator enumerator = this._ListUnit.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						ModCfg_unit modUnit = enumerator.Current;
						text = modUnit.Code.ToString().PadLeft(3, '0');
						text2 = this.KEY_UNITCODE + text;
						ModCfg_device modCfg_device = null;
						try
						{
							modCfg_device = (from x in this._ListDevice
							where x.Name == modUnit.DeviceName
							select x).ToList<ModCfg_device>()[0];
						}
						catch
						{
							modCfg_device = null;
						}
						List<ModCfg_devitem> list = (from x in this._ListDevItem
						where x.LuHao == modUnit.LuHao
						select x).ToList<ModCfg_devitem>();
						foreach (ModCfg_devitem modCfg_devitem in list)
						{
							ViewCfgItem viewCfgItem = new ViewCfgItem();
							viewCfgItem.ItemCode = text + modCfg_devitem.ItemCode + "." + modCfg_devitem.Para;
							viewCfgItem.RTNItemName = text2 + "\\" + text + modCfg_devitem.ItemCode;
							viewCfgItem.ItemName = viewCfgItem.RTNItemName + "." + modCfg_devitem.Para;
							viewCfgItem.ItemType = "数字型";
							viewCfgItem.Remark = modCfg_devitem.ItemDesc;
							viewCfgItem.AppType = 2;
							viewCfgItem.DataStyle = modCfg_devitem.DataStyle;
							viewCfgItem.LinkAddr = modCfg_devitem.LinkAddr;
							viewCfgItem.ParaName = modCfg_devitem.Para;
							bool flag = modCfg_device != null;
							if (flag)
							{
								viewCfgItem.DevCode = modCfg_device.Code.ToString().PadLeft(3, '0');
							}
							else
							{
								viewCfgItem.DevCode = string.Empty;
							}
							this._ListItem.Add(viewCfgItem);
						}
						this._ListUnitCode.Add(text);
						this._ListArea.Add(text2);
					}
				}
			}
			catch
			{
				return false;
			}
			return true;
		}

		// Token: 0x0600062D RID: 1581 RVA: 0x0009A054 File Offset: 0x00098254
		protected string GetRTNItemName(string itemName)
		{
			itemName = itemName.Replace(".PV", "");
			itemName = itemName.Replace(".DESC", "");
			return itemName;
		}

		// Token: 0x0600062E RID: 1582 RVA: 0x0009A08C File Offset: 0x0009828C
		protected void AddHisCsvItem(StreamWriter w)
		{
			foreach (ViewCfgItem viewCfgItem in this._ListItem)
			{
				w.WriteLine(viewCfgItem.RTNItemName + ",DESC,3,1");
				w.WriteLine(viewCfgItem.RTNItemName + ",PV,3,1");
			}
		}

		// Token: 0x0600062F RID: 1583 RVA: 0x0009A10C File Offset: 0x0009830C
		protected void AddLinkCsvItem(StreamWriter w)
		{
			string empty = string.Empty;
			foreach (ViewCfgItem viewCfgItem in this._ListItem)
			{
				bool flag = viewCfgItem.DevCode.Length == 0;
				if (!flag)
				{
					string[] array = new string[]
					{
						"0",
						"0",
						"0",
						"0",
						"0",
						"0",
						"0",
						"0",
						"0",
						"0",
						"0",
						"0",
						"0",
						"0",
						"0",
						"0",
						"0",
						"0",
						"0",
						"0",
						"0",
						"0",
						"0",
						"0",
						"0",
						"0",
						"0",
						"0",
						"0",
						"0",
						"0",
						"0",
						"0",
						"0",
						"0",
						"0",
						"0",
						"0",
						"0",
						"0",
						"0",
						"0",
						"0",
						"0",
						"0",
						"0",
						"0",
						"0",
						"0",
						"0",
						"0",
						"0",
						"0",
						"0",
						"0",
						"0",
						"0",
						"0",
						"0",
						"0",
						"-15",
						"-40",
						"-1",
						"-1",
						"2",
						"1",
						"0",
						"4",
						"0",
						"1",
						"65537",
						"7"
					};
					array[69] = "0";
					bool flag2 = false;
					string dataStyle = viewCfgItem.DataStyle;
					string text = dataStyle;
					if (text != null)
					{
						if (!(text == "Floating"))
						{
							if (text == "Boolean")
							{
								bool flag3 = viewCfgItem.LinkAddr.IndexOf("DO") >= 0;
								if (flag3)
								{
									int num = int.Parse(viewCfgItem.LinkAddr.Replace("DO", "")) - 1;
									array[64] = "1";
									array[65] = num.ToString();
									array[67] = "2";
									array[71] = "2";
									flag2 = true;
								}
								else
								{
									bool flag4 = viewCfgItem.LinkAddr.IndexOf("Short") >= 0;
									if (flag4)
									{
										int num2 = (int)(double.Parse(viewCfgItem.LinkAddr.Substring(viewCfgItem.LinkAddr.IndexOf(':') + 1, viewCfgItem.LinkAddr.Length - viewCfgItem.LinkAddr.IndexOf(':') - 1)) - 1.0);
										int num3 = int.Parse(viewCfgItem.LinkAddr.Substring(viewCfgItem.LinkAddr.IndexOf('.') + 1, viewCfgItem.LinkAddr.Length - viewCfgItem.LinkAddr.IndexOf('.') - 1));
										array[64] = "2";
										array[65] = num2.ToString();
										array[66] = "1";
										array[67] = "2";
										array[71] = int.Parse(num3.ToString("x8") + "0002", NumberStyles.HexNumber).ToString();
										flag2 = true;
									}
									else
									{
										flag2 = false;
									}
								}
							}
						}
						else
						{
							bool flag5 = viewCfgItem.LinkAddr.IndexOf("Float") > 0;
							if (flag5)
							{
								int num4 = int.Parse(viewCfgItem.LinkAddr.Substring(viewCfgItem.LinkAddr.IndexOf(':') + 1, viewCfgItem.LinkAddr.Length - viewCfgItem.LinkAddr.IndexOf(':') - 1)) - 1;
								array[64] = "2";
								array[65] = num4.ToString();
								array[67] = "4";
								array[71] = "7";
								flag2 = true;
							}
							else
							{
								bool flag6 = viewCfgItem.LinkAddr.IndexOf("Short") > 0;
								if (flag6)
								{
									int num5 = int.Parse(viewCfgItem.LinkAddr.Substring(viewCfgItem.LinkAddr.IndexOf(':') + 1, viewCfgItem.LinkAddr.Length - viewCfgItem.LinkAddr.IndexOf(':') - 1)) - 1;
									array[64] = "2";
									array[65] = num5.ToString();
									array[67] = "2";
									array[71] = "2";
									flag2 = true;
								}
								else
								{
									bool flag7 = viewCfgItem.LinkAddr.IndexOf("Byte") > 0;
									if (flag7)
									{
										int num6 = int.Parse(viewCfgItem.LinkAddr.Substring(viewCfgItem.LinkAddr.IndexOf(':') + 1, viewCfgItem.LinkAddr.Length - viewCfgItem.LinkAddr.IndexOf(':') - 1)) - 1;
										array[64] = "2";
										array[65] = num6.ToString();
										array[66] = "0";
										array[67] = "2";
										bool flag8 = viewCfgItem.LinkAddr.IndexOf("/L:") > 0;
										if (flag8)
										{
											array[68] = "1";
										}
										else
										{
											bool flag9 = viewCfgItem.LinkAddr.IndexOf("/H:") > 0;
											if (flag9)
											{
												array[68] = "0";
											}
										}
										array[69] = "0";
										array[71] = "65537";
										flag2 = true;
									}
									else
									{
										flag2 = false;
									}
								}
							}
						}
					}
					IL_685:
					bool flag10 = flag2;
					if (flag10)
					{
						char[] array2 = viewCfgItem.LinkAddr.ToCharArray(0, viewCfgItem.LinkAddr.Length);
						for (int i = 0; i < viewCfgItem.LinkAddr.Length; i++)
						{
							array[i] = ((short)array2[i]).ToString();
						}
						string text2 = string.Empty;
						foreach (string text3 in array)
						{
							text2 = text2 + text3.ToString() + ",";
						}
						w.WriteLine(string.Concat(new string[]
						{
							viewCfgItem.RTNItemName,
							",",
							viewCfgItem.ParaName,
							",0,",
							this.KEY_DEVCODE,
							viewCfgItem.DevCode,
							",0,",
							viewCfgItem.LinkAddr,
							",",
							text2
						}));
					}
					continue;
					goto IL_685;
				}
			}
		}

		// Token: 0x06000630 RID: 1584 RVA: 0x0009A8D8 File Offset: 0x00098AD8
		protected void AddBasicCsvItem(StreamWriter w, int StyleId, List<ViewCfgItem> listItem)
		{
			int num = 0;
			int count = listItem.Count;
			bool flag = count == 0;
			if (!flag)
			{
				this.AddBasicCsvHead(count, w, StyleId);
				bool flag2 = count > 0;
				if (flag2)
				{
					w.WriteLine("区域,点数量");
					w.WriteLine(num.ToString() + "," + count.ToString());
					foreach (ViewCfgItem item in listItem)
					{
						this.AddBasicCsvItem(item, w, StyleId);
					}
				}
			}
		}

		// Token: 0x06000631 RID: 1585 RVA: 0x0009A990 File Offset: 0x00098B90
		protected void AddBasicCsvHead(int iItemCount, StreamWriter w, int StyleId)
		{
			switch (StyleId)
			{
			case 0:
				w.WriteLine("点类型,点数量,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,");
				w.WriteLine("0," + iItemCount.ToString() + ",,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,");
				w.WriteLine("0,1,2,4,49,15,13,10,12,11,17,79,19,18,34,51,60,52,53,54,55,56,57,61,62,63,64,65,66,70,91,75,69,36,37,38,39,46,47,48,40,41,42,43,44,45,71,72,73,6,7,");
				w.WriteLine("NAME,KIND,DESC,UNIT,FORMAT,LASTPV,PV,EU,EULO,EUHI,PVRAW,SCALEFL,PVRAWLO,PVRAWHI,STATIS,ALMENAB,DEADBAND,LL,LO,HI,HH,RATE,DEV,LLPR,LOPR,HIPR,HHPR,RATEPR,DEVPR,RATECYC,SP,SQRTFL,ALARMDELAY,LINEFL,LINETBL,ROCFL,ROC,L3,L4,L5,L3PR,L4PR,L5PR,H3PR,H4PR,H5PR,H3,H4,H5,GROUP,INDEX,");
				break;
			case 1:
				w.WriteLine("点类型,点数量");
				w.WriteLine("1," + iItemCount.ToString());
				w.WriteLine("0,1,2,4,13,27,28,51,26,35,6,7,");
				w.WriteLine("NAME,KIND,DESC,UNIT,PV,OFFMES,ONMES,ALMENAB,NORMALVAL,ALARMPR,GROUP,INDEX,");
				break;
			case 2:
				w.WriteLine("点类型,点数量");
				w.WriteLine("2," + iItemCount.ToString());
				w.WriteLine("0,1,2,4,49,15,13,10,12,11,17,79,19,18,82,83,77,78,75,7,");
				w.WriteLine("NAME,KIND,DESC,UNIT,FORMAT,LASTPV,PV,EU,EULO,EUHI,PVRAW,SCALEFL,PVRAWLO,PVRAWHI,TOTAL,TIMEBASE,FILTERFL,FILTER,SQRTFL,INDEX,");
				break;
			case 3:
				w.WriteLine("点类型,点数量");
				w.WriteLine("3," + iItemCount.ToString());
				w.WriteLine("0,1,2,3,4,13,49,34,15,14,17,21,10,12,11,79,18,19,30,90,52,53,54,55,56,57,61,62,63,64,65,66,70,51,60,67,97,91,29,92,95,93,94,99,100,101,98,104,105,107,108,109,110,102,103,106,96,75,46,47,48,40,41,42,43,44,45,71,72,73,6,69,7,");
				w.WriteLine("NAME,KIND,DESC,STAT,UNIT,PV,FORMAT,STATIS,LASTPV,PVP,PVRAW,PVSTAT,EU,EULO,EUHI,SCALEFL,PVRAWHI,PVRAWLO,MODE,DIRECTION,LL,LO,HI,HH,RATE,DEV,LLPR,LOPR,HIPR,HHPR,RATEPR,DEVPR,RATECYC,ALMENAB,DEADBAND,BADPVPR,CYCLE,SP,OP,V0,P,I,D,UMAX,UMIN,UDMAX,FORMULA,TFILTERFL,TFILTER,LAG,TLAG,TLAGINER,KLAG,COMPEN,REDUCE,QUICK,BETA,SQRTFL,L3,L4,L5,L3PR,L4PR,L5PR,H3PR,H4PR,H5PR,H3,H4,H5,GROUP,ALARMDELAY,INDEX,");
				break;
			case 4:
				w.WriteLine("点类型,点数量");
				w.WriteLine("4," + iItemCount.ToString());
				w.WriteLine("0,1,2,4,86,87,13,88,7,");
				w.WriteLine("NAME,KIND,DESC,UNIT,P1,P2,PV,OPCODE,INDEX,");
				break;
			case 5:
				w.WriteLine("点类型,点数量");
				w.WriteLine("5," + iItemCount.ToString());
				w.WriteLine("0,1,2,4,11,12,13,15,24,49,7,");
				w.WriteLine("NAME,KIND,DESC,UNIT,EUHI,EULO,PV,LASTPV,OUT,FORMAT,INDEX,");
				break;
			}
		}

		// Token: 0x06000632 RID: 1586 RVA: 0x0009AB4C File Offset: 0x00098D4C
		protected void AddBasicCsvItem(ViewCfgItem item, StreamWriter w, int StyleId)
		{
			string rtnitemName = item.RTNItemName;
			switch (StyleId)
			{
			case 0:
				w.WriteLine(rtnitemName + ",0," + item.Remark + ",1,0,0.000,0.000,,0.000,100.000,0.000,0,0.000,4095.000,0,0,0.000,8.000,10.000,92.000,94.000,20.000,20.000,0,0,0,0,0,0,1,0.000,0,0,0,,0,0.000,6.000,4.000,2.000,0,0,0,0,0,0,96.000,98.000,100.000,0,7,");
				break;
			case 1:
				w.WriteLine(rtnitemName + ",1," + item.Remark + ",1,0.000,关闭,打开,0,0,0,0,2,");
				break;
			case 2:
				w.WriteLine(rtnitemName + ",2," + item.Remark + ",1,0,0.000,0.000,,0.000,100.000,0.000,0,0.000,4095.000,0.000,3600,0,0.100,0,3,");
				break;
			case 3:
				w.WriteLine(rtnitemName + ",3," + item.Remark + ",0,1,0.000,0,0,0.000,0.000,0.000,0,,0.000,100.000,0,4095.000,0.000,0,0,8.000,10.000,92.000,94.000,20.000,20.000,0,0,0,0,0,0,1,0,0.000,0,1000.000,0.000,0.000,0.000,1.200,1.000,1.000,100.000,0.000,1.000,0,0,0.100,0,0.100,0.100,0.100,0,0,0,0.500,0,6.000,4.000,2.000,0,0,0,0,0,0,96.000,98.000,100.000,0,0,4,");
				break;
			case 4:
				w.WriteLine(rtnitemName + ",4," + item.Remark + ",1,0.000,0.000,0.000,0,5,");
				break;
			case 5:
				w.WriteLine(rtnitemName + ",5," + item.Remark + ",1,100.000,0.000,0.000,0.000,0.000,0,6,");
				break;
			}
		}

		// Token: 0x04000A9F RID: 2719
		private readonly string KEY_DEVCODE = "M";

		// Token: 0x04000AA0 RID: 2720
		private readonly string KEY_UNITCODE = "D";

		// Token: 0x04000AA1 RID: 2721
		private List<ModCfg_device> _ListDevice = new List<ModCfg_device>();

		// Token: 0x04000AA2 RID: 2722
		private List<ModCfg_unit> _ListUnit = new List<ModCfg_unit>();

		// Token: 0x04000AA3 RID: 2723
		public List<ViewCfgItem> _ListItem = new List<ViewCfgItem>();

		// Token: 0x04000AA4 RID: 2724
		private List<string> _ListArea = new List<string>();

		// Token: 0x04000AA5 RID: 2725
		public List<string> _ListUnitCode = new List<string>();

		// Token: 0x04000AA6 RID: 2726
		private List<ModCfg_devitem> _ListDevItem = new List<ModCfg_devitem>();
	}
}
