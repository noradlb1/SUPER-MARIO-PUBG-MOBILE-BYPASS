using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace numer
{
	// Token: 0x0200003D RID: 61
	internal static class DebuggerAcl2
	{
		// Token: 0x060001C9 RID: 457 RVA: 0x00010700 File Offset: 0x0000E900
		internal static string mazn()
		{
			string[] array = new string[]
			{
				"write****",
				"0x**",
				"0x*******",
				"0x7FFFFFFFFFFF",
				"WriteMemory",
				"Memory",
				"anogs",
				"libanogs",
				"0x",
				"0x00",
				"Offset",
				"mData",
				"DWORD",
				"BYTE",
				"MemFind",
				"ReadProcessMemory",
				"BaseAddress",
				"0x7F,",
				"libanogsheader",
				"getlibanogsheader",
				"write",
				"ue4",
				"writeBytes",
				"OpenProcess",
				"ReadMemoryEx",
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
			if (Debugger.IsAttached || Debugger.IsLogging())
			{
				result = "Debug";
			}
			for (int i = 0; i < array.Length; i++)
			{
				if (Clipboard.GetText(TextDataFormat.Text).ToLower().Contains(array[i]))
				{
					result = Clipboard.GetText(TextDataFormat.Text);
				}
			}
			return result;
		}
	}
}
