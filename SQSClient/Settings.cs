using System;
using System.Configuration;

namespace SQSClient
{
	// Token: 0x02000093 RID: 147
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x17000033 RID: 51
		// (get) Token: 0x06000817 RID: 2071 RVA: 0x000CC76F File Offset: 0x000CA96F
		// (set) Token: 0x06000818 RID: 2072 RVA: 0x000CC777 File Offset: 0x000CA977
		public string Oldvalue
		{
			get
			{
				return this.oldvalue;
			}
			set
			{
				this.oldvalue = value;
			}
		}

		// Token: 0x06000819 RID: 2073 RVA: 0x000CC780 File Offset: 0x000CA980
		public static string GetDescription(string name)
		{
			SettingsDescriptionAttribute settingsDescriptionAttribute = Settings.Instance.Properties[name].Attributes[typeof(SettingsDescriptionAttribute)] as SettingsDescriptionAttribute;
			bool flag = settingsDescriptionAttribute != null;
			string result;
			if (flag)
			{
				result = settingsDescriptionAttribute.Description;
			}
			else
			{
				result = string.Empty;
			}
			return result;
		}

		// Token: 0x04000E27 RID: 3623
		public static Settings Instance = (Settings)SettingsBase.Synchronized(new Settings());

		// Token: 0x04000E28 RID: 3624
		private string oldvalue;
	}
}
