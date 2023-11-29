using System;

namespace X.Utils.WinStructs
{
	// Token: 0x02000050 RID: 80
	[Flags]
	public enum ThreadAccess
	{
		// Token: 0x04000642 RID: 1602
		TERMINATE = 1,
		// Token: 0x04000643 RID: 1603
		SUSPEND_RESUME = 2,
		// Token: 0x04000644 RID: 1604
		GET_CONTEXT = 8,
		// Token: 0x04000645 RID: 1605
		SET_CONTEXT = 16,
		// Token: 0x04000646 RID: 1606
		SET_INFORMATION = 32,
		// Token: 0x04000647 RID: 1607
		QUERY_INFORMATION = 64,
		// Token: 0x04000648 RID: 1608
		SET_THREAD_TOKEN = 128,
		// Token: 0x04000649 RID: 1609
		IMPERSONATE = 256,
		// Token: 0x0400064A RID: 1610
		DIRECT_IMPERSONATION = 512
	}
}
