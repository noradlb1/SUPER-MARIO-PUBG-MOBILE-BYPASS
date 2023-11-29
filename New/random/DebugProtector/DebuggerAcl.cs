using System;
using System.Diagnostics;

namespace DebugProtector
{
	// Token: 0x02000053 RID: 83
	internal static class DebuggerAcl
	{
		// Token: 0x06000207 RID: 519 RVA: 0x00011300 File Offset: 0x0000F500
		internal static string Run()
		{
			string[] array = new string[]
			{
				"Process Hacker",
				"process hackeer",
				"unknowncheats",
				"x32dbg.exe",
				"codecracker",
				"x32dbg",
				"x64dbg",
				"ollydbg",
				"ida",
				"charles",
				"dnspy",
				"simpleassembly",
				"peek",
				"httpanalyzer",
				"httpdebug",
				"fiddler",
				"wireshark",
				"dbx",
				"mdbg",
				"gdb",
				"windbg",
				"dbgclr",
				"kdb",
				"kgdb",
				"mdb",
				"processhacker",
				"scylla_x86",
				"scylla_x64",
				"scylla",
				"idau64",
				"idau",
				"idaq",
				"idaq64",
				"idaw",
				"idaw64",
				"idag",
				"idag64",
				"ida64",
				"ida",
				"ImportREC",
				"IMMUNITYDEBUGGER",
				"MegaDumper",
				"CodeBrowser",
				"reshacker",
				"cheat engine"
			};
			string result = "";
			if (!Debugger.IsAttached && !Debugger.IsLogging())
			{
				foreach (Process process in Process.GetProcesses())
				{
					if (process != Process.GetCurrentProcess())
					{
						for (int j = 0; j < array.Length; j++)
						{
							if (process.ProcessName.ToLower().Contains(array[j]) || process.MainWindowTitle.ToLower().Contains(array[j]))
							{
								result = process.MainWindowTitle;
							}
						}
					}
				}
			}
			else
			{
				result = "Debug";
			}
			return result;
		}
	}
}
