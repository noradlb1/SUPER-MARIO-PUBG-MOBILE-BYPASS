using System;
using System.Runtime.InteropServices;

namespace Anti_DebugNET.Utils.WinStructs
{
	// Token: 0x02000009 RID: 9
	public struct SYSTEM_KERNEL_DEBUGGER_INFORMATION
	{
		// Token: 0x04000262 RID: 610
		[MarshalAs(UnmanagedType.U1)]
		public bool KernelDebuggerEnabled;

		// Token: 0x04000263 RID: 611
		[MarshalAs(UnmanagedType.U1)]
		public bool KernelDebuggerNotPresent;
	}
}
