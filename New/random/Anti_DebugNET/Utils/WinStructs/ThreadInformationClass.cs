using System;

namespace Anti_DebugNET.Utils.WinStructs
{
	// Token: 0x02000007 RID: 7
	public enum ThreadInformationClass
	{
		// Token: 0x04000231 RID: 561
		ThreadBasicInformation,
		// Token: 0x04000232 RID: 562
		ThreadTimes,
		// Token: 0x04000233 RID: 563
		ThreadPriority,
		// Token: 0x04000234 RID: 564
		ThreadBasePriority,
		// Token: 0x04000235 RID: 565
		ThreadAffinityMask,
		// Token: 0x04000236 RID: 566
		ThreadImpersonationToken,
		// Token: 0x04000237 RID: 567
		ThreadDescriptorTableEntry,
		// Token: 0x04000238 RID: 568
		ThreadEnableAlignmentFaultFixup,
		// Token: 0x04000239 RID: 569
		ThreadEventPair_Reusable,
		// Token: 0x0400023A RID: 570
		ThreadQuerySetWin32StartAddress,
		// Token: 0x0400023B RID: 571
		ThreadZeroTlsCell,
		// Token: 0x0400023C RID: 572
		ThreadPerformanceCount,
		// Token: 0x0400023D RID: 573
		ThreadAmILastThread,
		// Token: 0x0400023E RID: 574
		ThreadIdealProcessor,
		// Token: 0x0400023F RID: 575
		ThreadPriorityBoost,
		// Token: 0x04000240 RID: 576
		ThreadSetTlsArrayAddress,
		// Token: 0x04000241 RID: 577
		ThreadIsIoPending,
		// Token: 0x04000242 RID: 578
		ThreadHideFromDebugger,
		// Token: 0x04000243 RID: 579
		ThreadBreakOnTermination,
		// Token: 0x04000244 RID: 580
		ThreadSwitchLegacyState,
		// Token: 0x04000245 RID: 581
		ThreadIsTerminated,
		// Token: 0x04000246 RID: 582
		ThreadLastSystemCall,
		// Token: 0x04000247 RID: 583
		ThreadIoPriority,
		// Token: 0x04000248 RID: 584
		ThreadCycleTime,
		// Token: 0x04000249 RID: 585
		ThreadPagePriority,
		// Token: 0x0400024A RID: 586
		ThreadActualBasePriority,
		// Token: 0x0400024B RID: 587
		ThreadTebInformation,
		// Token: 0x0400024C RID: 588
		ThreadCSwitchMon,
		// Token: 0x0400024D RID: 589
		ThreadCSwitchPmu,
		// Token: 0x0400024E RID: 590
		ThreadWow64Context,
		// Token: 0x0400024F RID: 591
		ThreadGroupInformation,
		// Token: 0x04000250 RID: 592
		ThreadUmsInformation,
		// Token: 0x04000251 RID: 593
		ThreadCounterProfiling,
		// Token: 0x04000252 RID: 594
		ThreadIdealProcessorEx,
		// Token: 0x04000253 RID: 595
		ThreadCpuAccountingInformation,
		// Token: 0x04000254 RID: 596
		ThreadSuspendCount,
		// Token: 0x04000255 RID: 597
		ThreadDescription = 38,
		// Token: 0x04000256 RID: 598
		ThreadActualGroupAffinity = 41,
		// Token: 0x04000257 RID: 599
		ThreadDynamicCodePolicy
	}
}
