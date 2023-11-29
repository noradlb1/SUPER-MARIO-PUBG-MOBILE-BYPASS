using System;

namespace Anti_DebugNET.Utils.WinStructs
{
	// Token: 0x02000008 RID: 8
	[Flags]
	public enum ThreadAccess
	{
		// Token: 0x04000259 RID: 601
		TERMINATE = 1,
		// Token: 0x0400025A RID: 602
		SUSPEND_RESUME = 2,
		// Token: 0x0400025B RID: 603
		GET_CONTEXT = 8,
		// Token: 0x0400025C RID: 604
		SET_CONTEXT = 16,
		// Token: 0x0400025D RID: 605
		SET_INFORMATION = 32,
		// Token: 0x0400025E RID: 606
		QUERY_INFORMATION = 64,
		// Token: 0x0400025F RID: 607
		SET_THREAD_TOKEN = 128,
		// Token: 0x04000260 RID: 608
		IMPERSONATE = 256,
		// Token: 0x04000261 RID: 609
		DIRECT_IMPERSONATION = 512
	}
}
