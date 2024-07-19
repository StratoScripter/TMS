using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

namespace SQSClient
{
	// Token: 0x02000035 RID: 53
	public class BardCodeHooK
	{
		// Token: 0x14000002 RID: 2
		// (add) Token: 0x06000276 RID: 630 RVA: 0x00043E5C File Offset: 0x0004205C
		// (remove) Token: 0x06000277 RID: 631 RVA: 0x00043E94 File Offset: 0x00042094
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public event BardCodeHooK.ScanerDelegate ScanerEvent;

		// Token: 0x06000278 RID: 632
		[DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto)]
		private static extern int SetWindowsHookEx(int idHook, BardCodeHooK.HookProc lpfn, IntPtr hInstance, int threadId);

		// Token: 0x06000279 RID: 633
		[DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto)]
		private static extern bool UnhookWindowsHookEx(int idHook);

		// Token: 0x0600027A RID: 634
		[DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto)]
		private static extern int CallNextHookEx(int idHook, int nCode, int wParam, IntPtr lParam);

		// Token: 0x0600027B RID: 635
		[DllImport("user32")]
		private static extern int GetKeyNameText(int IParam, StringBuilder lpBuffer, int nSize);

		// Token: 0x0600027C RID: 636
		[DllImport("user32")]
		private static extern int GetKeyboardState(byte[] pbKeyState);

		// Token: 0x0600027D RID: 637
		[DllImport("user32")]
		private static extern bool ToAscii(int VirtualKey, int ScanCode, byte[] lpKeySate, ref uint lpChar, int uFlags);

		// Token: 0x0600027E RID: 638
		[DllImport("kernel32.dll")]
		public static extern IntPtr GetModuleHandle(string name);

		// Token: 0x06000280 RID: 640 RVA: 0x00043EE8 File Offset: 0x000420E8
		public bool Start()
		{
			bool flag = this.hKeyboardHook == 0;
			if (flag)
			{
				BardCodeHooK.hookproc = new BardCodeHooK.HookProc(this.KeyboardHookProc);
				IntPtr moduleHandle = BardCodeHooK.GetModuleHandle(Process.GetCurrentProcess().MainModule.ModuleName);
				this.hKeyboardHook = BardCodeHooK.SetWindowsHookEx(13, BardCodeHooK.hookproc, moduleHandle, 0);
			}
			return this.hKeyboardHook != 0;
		}

		// Token: 0x06000281 RID: 641 RVA: 0x00043F4C File Offset: 0x0004214C
		public bool Stop()
		{
			bool flag = this.hKeyboardHook != 0;
			bool result;
			if (flag)
			{
				bool flag2 = BardCodeHooK.UnhookWindowsHookEx(this.hKeyboardHook);
				this.hKeyboardHook = 0;
				result = flag2;
			}
			else
			{
				result = true;
			}
			return result;
		}

		// Token: 0x06000282 RID: 642 RVA: 0x00043F84 File Offset: 0x00042184
		private int KeyboardHookProc(int nCode, int wParam, IntPtr lParam)
		{
			BardCodeHooK.EventMsg eventMsg = (BardCodeHooK.EventMsg)Marshal.PtrToStructure(lParam, typeof(BardCodeHooK.EventMsg));
			this.codes.Add(eventMsg);
			bool flag = this.ScanerEvent != null && eventMsg.message == 13 && eventMsg.paramH > 0 && !string.IsNullOrEmpty(this.codes.Result);
			if (flag)
			{
				this.ScanerEvent(this.codes);
			}
			return BardCodeHooK.CallNextHookEx(this.hKeyboardHook, nCode, wParam, lParam);
		}

		// Token: 0x04000449 RID: 1097
		private int hKeyboardHook = 0;

		// Token: 0x0400044A RID: 1098
		private BardCodeHooK.ScanerCodes codes = new BardCodeHooK.ScanerCodes();

		// Token: 0x0400044B RID: 1099
		private static BardCodeHooK.HookProc hookproc;

		// Token: 0x020000C5 RID: 197
		// (Invoke) Token: 0x060009EA RID: 2538
		public delegate void ScanerDelegate(BardCodeHooK.ScanerCodes codes);

		// Token: 0x020000C6 RID: 198
		// (Invoke) Token: 0x060009EE RID: 2542
		private delegate int HookProc(int nCode, int wParam, IntPtr lParam);

		// Token: 0x020000C7 RID: 199
		public class ScanerCodes
		{
			// Token: 0x170000B5 RID: 181
			// (get) Token: 0x060009F1 RID: 2545 RVA: 0x000DF2E0 File Offset: 0x000DD4E0
			public BardCodeHooK.EventMsg Event
			{
				get
				{
					bool flag = this._keys.Count == 0;
					BardCodeHooK.EventMsg result;
					if (flag)
					{
						result = default(BardCodeHooK.EventMsg);
					}
					else
					{
						result = this._keys[this._keys.Count - 1][this._keys[this._keys.Count - 1].Count - 1];
					}
					return result;
				}
			}

			// Token: 0x170000B6 RID: 182
			// (get) Token: 0x060009F2 RID: 2546 RVA: 0x000DF350 File Offset: 0x000DD550
			public List<int> KeyDowns
			{
				get
				{
					return this._keydown;
				}
			}

			// Token: 0x170000B7 RID: 183
			// (get) Token: 0x060009F3 RID: 2547 RVA: 0x000DF368 File Offset: 0x000DD568
			public DateTime LastInput
			{
				get
				{
					return this._last;
				}
			}

			// Token: 0x170000B8 RID: 184
			// (get) Token: 0x060009F4 RID: 2548 RVA: 0x000DF380 File Offset: 0x000DD580
			public byte[] KeyboardState
			{
				get
				{
					return this._state;
				}
			}

			// Token: 0x170000B9 RID: 185
			// (get) Token: 0x060009F5 RID: 2549 RVA: 0x000DF398 File Offset: 0x000DD598
			public int KeyDownCount
			{
				get
				{
					return this._keydown.Count;
				}
			}

			// Token: 0x170000BA RID: 186
			// (get) Token: 0x060009F6 RID: 2550 RVA: 0x000DF3B8 File Offset: 0x000DD5B8
			public string Result
			{
				get
				{
					bool flag = this._result.Count > 0;
					string result;
					if (flag)
					{
						result = this._result[this._result.Count - 1].Trim();
					}
					else
					{
						result = null;
					}
					return result;
				}
			}

			// Token: 0x170000BB RID: 187
			// (get) Token: 0x060009F7 RID: 2551 RVA: 0x000DF400 File Offset: 0x000DD600
			public string CurrentKey
			{
				get
				{
					return this._key;
				}
			}

			// Token: 0x170000BC RID: 188
			// (get) Token: 0x060009F8 RID: 2552 RVA: 0x000DF418 File Offset: 0x000DD618
			public string CurrentChar
			{
				get
				{
					return this._cur;
				}
			}

			// Token: 0x170000BD RID: 189
			// (get) Token: 0x060009F9 RID: 2553 RVA: 0x000DF430 File Offset: 0x000DD630
			public bool isShift
			{
				get
				{
					return this._keydown.Contains(160);
				}
			}

			// Token: 0x060009FA RID: 2554 RVA: 0x000DF454 File Offset: 0x000DD654
			public void Add(BardCodeHooK.EventMsg msg)
			{
				bool flag = this._keys.Count == 0;
				if (flag)
				{
					this._keys.Add(new List<BardCodeHooK.EventMsg>());
					this._keys[0].Add(msg);
					this._result.Add(string.Empty);
				}
				else
				{
					bool flag2 = this._keydown.Count > 0;
					if (flag2)
					{
						this._keys[this._keys.Count - 1].Add(msg);
					}
					else
					{
						bool flag3 = (DateTime.Now - this._last).TotalMilliseconds < (double)this.ts;
						if (flag3)
						{
							this._keys[this._keys.Count - 1].Add(msg);
						}
						else
						{
							this._keys.Add(new List<BardCodeHooK.EventMsg>());
							this._keys[this._keys.Count - 1].Add(msg);
							this._result.Add(string.Empty);
						}
					}
				}
				this._last = DateTime.Now;
				bool flag4 = msg.paramH == 0 && !this._keydown.Contains(msg.message);
				if (flag4)
				{
					this._keydown.Add(msg.message);
				}
				bool flag5 = msg.paramH > 0 && this._keydown.Contains(msg.message);
				if (flag5)
				{
					this._keydown.Remove(msg.message);
				}
				int num = msg.message & 255;
				int num2 = msg.paramL & 255;
				StringBuilder stringBuilder = new StringBuilder(500);
				bool flag6 = BardCodeHooK.GetKeyNameText(num2 * 65536, stringBuilder, 255) > 0;
				if (flag6)
				{
					string text = stringBuilder.ToString();
					char[] array = new char[2];
					array[0] = ' ';
					this._key = text.Trim(array);
					BardCodeHooK.GetKeyboardState(this._state);
					bool flag7 = this._key.Length == 1 && msg.paramH == 0;
					if (flag7)
					{
						this._cur = this.ShiftChar(this._key, this.isShift, this._state).ToString();
						List<string> result = this._result;
						int index = this._result.Count - 1;
						result[index] += this._cur;
					}
					else
					{
						this._cur = string.Empty;
					}
				}
			}

			// Token: 0x060009FB RID: 2555 RVA: 0x000DF6F0 File Offset: 0x000DD8F0
			private char ShiftChar(string k, bool isShiftDown, byte[] state)
			{
				bool flag = state[20] == 1;
				bool flag2 = state[144] == 1;
				bool flag3 = state[145] == 1;
				bool flag4 = state[160] == 1;
				char c = (flag ? k.ToUpper() : k.ToLower()).ToCharArray()[0];
				if (isShiftDown)
				{
					bool flag5 = c >= 'a' && c <= 'z';
					if (flag5)
					{
						c -= ' ';
					}
					else
					{
						bool flag6 = c >= 'A' && c <= 'Z';
						if (flag6)
						{
							bool flag7 = c == 'Z';
							if (flag7)
							{
							}
							c += ' ';
						}
						else
						{
							string text = "`1234567890-=[];',./";
							string text2 = "~!@#$%^&*()_+{}:\"<>?";
							bool flag8 = text.IndexOf(c) >= 0;
							if (flag8)
							{
								return text2.ToCharArray()[text.IndexOf(c)];
							}
						}
					}
				}
				return c;
			}

			// Token: 0x04000FED RID: 4077
			private int ts = 100;

			// Token: 0x04000FEE RID: 4078
			private List<List<BardCodeHooK.EventMsg>> _keys = new List<List<BardCodeHooK.EventMsg>>();

			// Token: 0x04000FEF RID: 4079
			private List<int> _keydown = new List<int>();

			// Token: 0x04000FF0 RID: 4080
			private List<string> _result = new List<string>();

			// Token: 0x04000FF1 RID: 4081
			private DateTime _last = DateTime.Now;

			// Token: 0x04000FF2 RID: 4082
			private byte[] _state = new byte[256];

			// Token: 0x04000FF3 RID: 4083
			private string _key = string.Empty;

			// Token: 0x04000FF4 RID: 4084
			private string _cur = string.Empty;
		}

		// Token: 0x020000C8 RID: 200
		public struct EventMsg
		{
			// Token: 0x04000FF5 RID: 4085
			public int message;

			// Token: 0x04000FF6 RID: 4086
			public int paramL;

			// Token: 0x04000FF7 RID: 4087
			public int paramH;

			// Token: 0x04000FF8 RID: 4088
			public int Time;

			// Token: 0x04000FF9 RID: 4089
			public int hwnd;
		}
	}
}
