using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Anti_DebugNET.AntiDebug
{
	// Token: 0x0200000A RID: 10
	internal class DebugProtect1
	{
		// Token: 0x06000007 RID: 7
		[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool CheckRemoteDebuggerPresent(IntPtr hProcess, [MarshalAs(UnmanagedType.Bool)] ref bool isDebuggerPresent);

		// Token: 0x06000008 RID: 8
		[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool IsDebuggerPresent();

		// Token: 0x06000009 RID: 9 RVA: 0x00003144 File Offset: 0x00001344
		public static int PerformChecks()
		{
			if (DebugProtect1.CheckDebuggerManagedPresent() == 1)
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("CheckDebuggerManagedPresent: HIT");
				return 1;
			}
			if (DebugProtect1.CheckDebuggerUnmanagedPresent() == 1)
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("CheckDebuggerUnmanagedPresent: HIT");
				return 1;
			}
			if (DebugProtect1.CheckRemoteDebugger() == 1)
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("CheckRemoteDebugger: HIT");
				return 1;
			}
			return 0;
		}

		// Token: 0x0600000A RID: 10 RVA: 0x0000207E File Offset: 0x0000027E
		private static int CheckDebuggerManagedPresent()
		{
			if (Debugger.IsAttached)
			{
				return 1;
			}
			return 0;
		}

		// Token: 0x0600000B RID: 11 RVA: 0x0000208A File Offset: 0x0000028A
		private static int CheckDebuggerUnmanagedPresent()
		{
			if (DebugProtect1.IsDebuggerPresent())
			{
				return 1;
			}
			return 0;
		}

		// Token: 0x0600000C RID: 12 RVA: 0x000031A4 File Offset: 0x000013A4
		private static int CheckRemoteDebugger()
		{
			bool flag = false;
			if (DebugProtect1.CheckRemoteDebuggerPresent(Process.GetCurrentProcess().Handle, ref flag) && flag)
			{
				return 1;
			}
			return 0;
		}
	}
}
