using System;
using System.Windows.Forms;
using Assistant;
using Base;
using Model.General;

namespace SQSClient
{
	// Token: 0x02000095 RID: 149
	internal static class Program
	{
		// Token: 0x06000857 RID: 2135 RVA: 0x000CDDF4 File Offset: 0x000CBFF4
		[STAThread]
		private static void Main()
		{
			try
			{
				Words words = new Words();
				XMLHelper.ReadXMLFile<Words>(Application.StartupPath + "\\Dictionary.xml", ref words);
				string language = ConfigSettings.Instance.Language;
				string text = language;
				if (text != null)
				{
					if (!(text == "ZH"))
					{
						if (text == "EN")
						{
							foreach (Word word in words.words)
							{
								bool flag = ShowWords.WordsDic.ContainsKey(word.Key);
								if (!flag)
								{
									ShowWords.WordsDic.Add(word.Key, word.EN);
								}
							}
						}
					}
					else
					{
						foreach (Word word2 in words.words)
						{
							bool flag2 = ShowWords.WordsDic.ContainsKey(word2.Key);
							if (!flag2)
							{
								ShowWords.WordsDic.Add(word2.Key, word2.ZH);
							}
						}
					}
				}
			}
			catch
			{
			}
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new frmLogin());
		}
	}
}
