using System;

namespace X.Utils.WinStructs
{
	// Token: 0x0200004F RID: 79
	public enum ThreadInformationClass
	{
		// Token: 0x0400061A RID: 1562
		ThreadBasicInformation,
		// Token: 0x0400061B RID: 1563
		ThreadTimes,
		// Token: 0x0400061C RID: 1564
		ThreadPriority,
		// Token: 0x0400061D RID: 1565
		ThreadBasePriority,
		// Token: 0x0400061E RID: 1566
		ThreadAffinityMask,
		// Token: 0x0400061F RID: 1567
		ThreadImpersonationToken,
		// Token: 0x04000620 RID: 1568
		ThreadDescriptorTableEntry,
		// Token: 0x04000621 RID: 1569
		ThreadEnableAlignmentFaultFixup,
		// Token: 0x04000622 RID: 1570
		ThreadEventPair_Reusable,
		// Token: 0x04000623 RID: 1571
		ThreadQuerySetWin32StartAddress,
		// Token: 0x04000624 RID: 1572
		ThreadZeroTlsCell,
		// Token: 0x04000625 RID: 1573
		ThreadPerformanceCount,
		// Token: 0x04000626 RID: 1574
		ThreadAmILastThread,
		// Token: 0x04000627 RID: 1575
		ThreadIdealProcessor,
		// Token: 0x04000628 RID: 1576
		ThreadPriorityBoost,
		// Token: 0x04000629 RID: 1577
		ThreadSetTlsArrayAddress,
		// Token: 0x0400062A RID: 1578
		ThreadIsIoPending,
		// Token: 0x0400062B RID: 1579
		ThreadHideFromDebugger,
		// Token: 0x0400062C RID: 1580
		ThreadBreakOnTermination,
		// Token: 0x0400062D RID: 1581
		ThreadSwitchLegacyState,
		// Token: 0x0400062E RID: 1582
		ThreadIsTerminated,
		// Token: 0x0400062F RID: 1583
		ThreadLastSystemCall,
		// Token: 0x04000630 RID: 1584
		ThreadIoPriority,
		// Token: 0x04000631 RID: 1585
		ThreadCycleTime,
		// Token: 0x04000632 RID: 1586
		ThreadPagePriority,
		// Token: 0x04000633 RID: 1587
		ThreadActualBasePriority,
		// Token: 0x04000634 RID: 1588
		ThreadTebInformation,
		// Token: 0x04000635 RID: 1589
		ThreadCSwitchMon,
		// Token: 0x04000636 RID: 1590
		ThreadCSwitchPmu,
		// Token: 0x04000637 RID: 1591
		ThreadWow64Context,
		// Token: 0x04000638 RID: 1592
		ThreadGroupInformation,
		// Token: 0x04000639 RID: 1593
		ThreadUmsInformation,
		// Token: 0x0400063A RID: 1594
		ThreadCounterProfiling,
		// Token: 0x0400063B RID: 1595
		ThreadIdealProcessorEx,
		// Token: 0x0400063C RID: 1596
		ThreadCpuAccountingInformation,
		// Token: 0x0400063D RID: 1597
		ThreadSuspendCount,
		// Token: 0x0400063E RID: 1598
		ThreadDescription = 38,
		// Token: 0x0400063F RID: 1599
		ThreadActualGroupAffinity = 41,
		// Token: 0x04000640 RID: 1600
		ThreadDynamicCodePolicy
	}
}
