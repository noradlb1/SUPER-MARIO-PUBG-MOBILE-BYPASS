using System;
using System.Runtime.InteropServices;

namespace X.Utils.WinStructs
{
	// Token: 0x02000051 RID: 81
	public struct SYSTEM_KERNEL_DEBUGGER_INFORMATION
	{
		// Token: 0x0400064B RID: 1611
		[MarshalAs(UnmanagedType.U1)]
		public bool KernelDebuggerEnabled;

		// Token: 0x0400064C RID: 1612
		[MarshalAs(UnmanagedType.U1)]
		public bool KernelDebuggerNotPresent;
	}
}
