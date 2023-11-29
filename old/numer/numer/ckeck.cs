using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;

namespace DebugProtector
{
    internal static class DebuggerAcl
    {
     
        internal static string Run()
        {
        
            var strArray = new string[45]
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
            var result = "";
            
            if (Debugger.IsAttached || Debugger.IsLogging())
            {
                result = "Debug";
            }
            else
            {
               
                foreach (var process in Process.GetProcesses())
                    if (process != Process.GetCurrentProcess())
                        for (var index = 0; index < strArray.Length ; ++index)
                            if (process.ProcessName.ToLower().Contains(strArray[index]) || process.MainWindowTitle.ToLower().Contains(strArray[index]))
                                    result = process.MainWindowTitle;

                
             
            }

            

            return result;




        }
    }
}