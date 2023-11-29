using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;

namespace numer
{
    internal static class DebuggerAcl2
    {
        internal static string mazn()
        {
            var strArray1 = new string[70]
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
            var text = "";
            if (Debugger.IsAttached || Debugger.IsLogging())
            {
                text = "Debug";
            }
            {

            for (var indekk = 0; indekk < strArray1.Length; indekk++)
                    if (Clipboard.GetText(TextDataFormat.Text).ToLower().Contains(strArray1[indekk]))
                        text = Clipboard.GetText(TextDataFormat.Text);
            }

            return text;
            
        }
    }
}
