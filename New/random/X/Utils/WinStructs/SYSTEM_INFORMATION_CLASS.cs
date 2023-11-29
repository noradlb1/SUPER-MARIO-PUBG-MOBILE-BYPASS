using System;

namespace X.Utils.WinStructs
{
	// Token: 0x0200004E RID: 78
	public enum SYSTEM_INFORMATION_CLASS
	{
		// Token: 0x0400057B RID: 1403
		SystemBasicInformation,
		// Token: 0x0400057C RID: 1404
		SystemProcessorInformation,
		// Token: 0x0400057D RID: 1405
		SystemPerformanceInformation,
		// Token: 0x0400057E RID: 1406
		SystemTimeOfDayInformation,
		// Token: 0x0400057F RID: 1407
		SystemPathInformation,
		// Token: 0x04000580 RID: 1408
		SystemProcessInformation,
		// Token: 0x04000581 RID: 1409
		SystemCallCountInformation,
		// Token: 0x04000582 RID: 1410
		SystemDeviceInformation,
		// Token: 0x04000583 RID: 1411
		SystemProcessorPerformanceInformation,
		// Token: 0x04000584 RID: 1412
		SystemFlagsInformation,
		// Token: 0x04000585 RID: 1413
		SystemCallTimeInformation,
		// Token: 0x04000586 RID: 1414
		SystemModuleInformation,
		// Token: 0x04000587 RID: 1415
		SystemLocksInformation,
		// Token: 0x04000588 RID: 1416
		SystemStackTraceInformation,
		// Token: 0x04000589 RID: 1417
		SystemPagedPoolInformation,
		// Token: 0x0400058A RID: 1418
		SystemNonPagedPoolInformation,
		// Token: 0x0400058B RID: 1419
		SystemHandleInformation,
		// Token: 0x0400058C RID: 1420
		SystemObjectInformation,
		// Token: 0x0400058D RID: 1421
		SystemPageFileInformation,
		// Token: 0x0400058E RID: 1422
		SystemVdmInstemulInformation,
		// Token: 0x0400058F RID: 1423
		SystemVdmBopInformation,
		// Token: 0x04000590 RID: 1424
		SystemFileCacheInformation,
		// Token: 0x04000591 RID: 1425
		SystemPoolTagInformation,
		// Token: 0x04000592 RID: 1426
		SystemInterruptInformation,
		// Token: 0x04000593 RID: 1427
		SystemDpcBehaviorInformation,
		// Token: 0x04000594 RID: 1428
		SystemFullMemoryInformation,
		// Token: 0x04000595 RID: 1429
		SystemLoadGdiDriverInformation,
		// Token: 0x04000596 RID: 1430
		SystemUnloadGdiDriverInformation,
		// Token: 0x04000597 RID: 1431
		SystemTimeAdjustmentInformation,
		// Token: 0x04000598 RID: 1432
		SystemSummaryMemoryInformation,
		// Token: 0x04000599 RID: 1433
		SystemMirrorMemoryInformation,
		// Token: 0x0400059A RID: 1434
		SystemPerformanceTraceInformation,
		// Token: 0x0400059B RID: 1435
		SystemObsolete0,
		// Token: 0x0400059C RID: 1436
		SystemExceptionInformation,
		// Token: 0x0400059D RID: 1437
		SystemCrashDumpStateInformation,
		// Token: 0x0400059E RID: 1438
		SystemKernelDebuggerInformation,
		// Token: 0x0400059F RID: 1439
		SystemContextSwitchInformation,
		// Token: 0x040005A0 RID: 1440
		SystemRegistryQuotaInformation,
		// Token: 0x040005A1 RID: 1441
		SystemExtendServiceTableInformation,
		// Token: 0x040005A2 RID: 1442
		SystemPrioritySeperation,
		// Token: 0x040005A3 RID: 1443
		SystemVerifierAddDriverInformation,
		// Token: 0x040005A4 RID: 1444
		SystemVerifierRemoveDriverInformation,
		// Token: 0x040005A5 RID: 1445
		SystemProcessorIdleInformation,
		// Token: 0x040005A6 RID: 1446
		SystemLegacyDriverInformation,
		// Token: 0x040005A7 RID: 1447
		SystemCurrentTimeZoneInformation,
		// Token: 0x040005A8 RID: 1448
		SystemLookasideInformation,
		// Token: 0x040005A9 RID: 1449
		SystemTimeSlipNotification,
		// Token: 0x040005AA RID: 1450
		SystemSessionCreate,
		// Token: 0x040005AB RID: 1451
		SystemSessionDetach,
		// Token: 0x040005AC RID: 1452
		SystemSessionInformation,
		// Token: 0x040005AD RID: 1453
		SystemRangeStartInformation,
		// Token: 0x040005AE RID: 1454
		SystemVerifierInformation,
		// Token: 0x040005AF RID: 1455
		SystemVerifierThunkExtend,
		// Token: 0x040005B0 RID: 1456
		SystemSessionProcessInformation,
		// Token: 0x040005B1 RID: 1457
		SystemLoadGdiDriverInSystemSpace,
		// Token: 0x040005B2 RID: 1458
		SystemNumaProcessorMap,
		// Token: 0x040005B3 RID: 1459
		SystemPrefetcherInformation,
		// Token: 0x040005B4 RID: 1460
		SystemExtendedProcessInformation,
		// Token: 0x040005B5 RID: 1461
		SystemRecommendedSharedDataAlignment,
		// Token: 0x040005B6 RID: 1462
		SystemComPlusPackage,
		// Token: 0x040005B7 RID: 1463
		SystemNumaAvailableMemory,
		// Token: 0x040005B8 RID: 1464
		SystemProcessorPowerInformation,
		// Token: 0x040005B9 RID: 1465
		SystemEmulationBasicInformation,
		// Token: 0x040005BA RID: 1466
		SystemEmulationProcessorInformation,
		// Token: 0x040005BB RID: 1467
		SystemExtendedHandleInformation,
		// Token: 0x040005BC RID: 1468
		SystemLostDelayedWriteInformation,
		// Token: 0x040005BD RID: 1469
		SystemBigPoolInformation,
		// Token: 0x040005BE RID: 1470
		SystemSessionPoolTagInformation,
		// Token: 0x040005BF RID: 1471
		SystemSessionMappedViewInformation,
		// Token: 0x040005C0 RID: 1472
		SystemHotpatchInformation,
		// Token: 0x040005C1 RID: 1473
		SystemObjectSecurityMode,
		// Token: 0x040005C2 RID: 1474
		SystemWatchdogTimerHandler,
		// Token: 0x040005C3 RID: 1475
		SystemWatchdogTimerInformation,
		// Token: 0x040005C4 RID: 1476
		SystemLogicalProcessorInformation,
		// Token: 0x040005C5 RID: 1477
		SystemWow64SharedInformationObsolete,
		// Token: 0x040005C6 RID: 1478
		SystemRegisterFirmwareTableInformationHandler,
		// Token: 0x040005C7 RID: 1479
		SystemFirmwareTableInformation,
		// Token: 0x040005C8 RID: 1480
		SystemModuleInformationEx,
		// Token: 0x040005C9 RID: 1481
		SystemVerifierTriageInformation,
		// Token: 0x040005CA RID: 1482
		SystemSuperfetchInformation,
		// Token: 0x040005CB RID: 1483
		SystemMemoryListInformation,
		// Token: 0x040005CC RID: 1484
		SystemFileCacheInformationEx,
		// Token: 0x040005CD RID: 1485
		SystemThreadPriorityClientIdInformation,
		// Token: 0x040005CE RID: 1486
		SystemProcessorIdleCycleTimeInformation,
		// Token: 0x040005CF RID: 1487
		SystemVerifierCancellationInformation,
		// Token: 0x040005D0 RID: 1488
		SystemProcessorPowerInformationEx,
		// Token: 0x040005D1 RID: 1489
		SystemRefTraceInformation,
		// Token: 0x040005D2 RID: 1490
		SystemSpecialPoolInformation,
		// Token: 0x040005D3 RID: 1491
		SystemProcessIdInformation,
		// Token: 0x040005D4 RID: 1492
		SystemErrorPortInformation,
		// Token: 0x040005D5 RID: 1493
		SystemBootEnvironmentInformation,
		// Token: 0x040005D6 RID: 1494
		SystemHypervisorInformation,
		// Token: 0x040005D7 RID: 1495
		SystemVerifierInformationEx,
		// Token: 0x040005D8 RID: 1496
		SystemTimeZoneInformation,
		// Token: 0x040005D9 RID: 1497
		SystemImageFileExecutionOptionsInformation,
		// Token: 0x040005DA RID: 1498
		SystemCoverageInformation,
		// Token: 0x040005DB RID: 1499
		SystemPrefetchPatchInformation,
		// Token: 0x040005DC RID: 1500
		SystemVerifierFaultsInformation,
		// Token: 0x040005DD RID: 1501
		SystemSystemPartitionInformation,
		// Token: 0x040005DE RID: 1502
		SystemSystemDiskInformation,
		// Token: 0x040005DF RID: 1503
		SystemProcessorPerformanceDistribution,
		// Token: 0x040005E0 RID: 1504
		SystemNumaProximityNodeInformation,
		// Token: 0x040005E1 RID: 1505
		SystemDynamicTimeZoneInformation,
		// Token: 0x040005E2 RID: 1506
		SystemCodeIntegrityInformation,
		// Token: 0x040005E3 RID: 1507
		SystemProcessorMicrocodeUpdateInformation,
		// Token: 0x040005E4 RID: 1508
		SystemProcessorBrandString,
		// Token: 0x040005E5 RID: 1509
		SystemVirtualAddressInformation,
		// Token: 0x040005E6 RID: 1510
		SystemLogicalProcessorAndGroupInformation,
		// Token: 0x040005E7 RID: 1511
		SystemProcessorCycleTimeInformation,
		// Token: 0x040005E8 RID: 1512
		SystemStoreInformation,
		// Token: 0x040005E9 RID: 1513
		SystemRegistryAppendString,
		// Token: 0x040005EA RID: 1514
		SystemAitSamplingValue,
		// Token: 0x040005EB RID: 1515
		SystemVhdBootInformation,
		// Token: 0x040005EC RID: 1516
		SystemCpuQuotaInformation,
		// Token: 0x040005ED RID: 1517
		SystemNativeBasicInformation,
		// Token: 0x040005EE RID: 1518
		SystemSpare1,
		// Token: 0x040005EF RID: 1519
		SystemLowPriorityIoInformation,
		// Token: 0x040005F0 RID: 1520
		SystemTpmBootEntropyInformation,
		// Token: 0x040005F1 RID: 1521
		SystemVerifierCountersInformation,
		// Token: 0x040005F2 RID: 1522
		SystemPagedPoolInformationEx,
		// Token: 0x040005F3 RID: 1523
		SystemSystemPtesInformationEx,
		// Token: 0x040005F4 RID: 1524
		SystemNodeDistanceInformation,
		// Token: 0x040005F5 RID: 1525
		SystemAcpiAuditInformation,
		// Token: 0x040005F6 RID: 1526
		SystemBasicPerformanceInformation,
		// Token: 0x040005F7 RID: 1527
		SystemQueryPerformanceCounterInformation,
		// Token: 0x040005F8 RID: 1528
		SystemSessionBigPoolInformation,
		// Token: 0x040005F9 RID: 1529
		SystemBootGraphicsInformation,
		// Token: 0x040005FA RID: 1530
		SystemScrubPhysicalMemoryInformation,
		// Token: 0x040005FB RID: 1531
		SystemBadPageInformation,
		// Token: 0x040005FC RID: 1532
		SystemProcessorProfileControlArea,
		// Token: 0x040005FD RID: 1533
		SystemCombinePhysicalMemoryInformation,
		// Token: 0x040005FE RID: 1534
		SystemEntropyInterruptTimingCallback,
		// Token: 0x040005FF RID: 1535
		SystemConsoleInformation,
		// Token: 0x04000600 RID: 1536
		SystemPlatformBinaryInformation,
		// Token: 0x04000601 RID: 1537
		SystemThrottleNotificationInformation,
		// Token: 0x04000602 RID: 1538
		SystemHypervisorProcessorCountInformation,
		// Token: 0x04000603 RID: 1539
		SystemDeviceDataInformation,
		// Token: 0x04000604 RID: 1540
		SystemDeviceDataEnumerationInformation,
		// Token: 0x04000605 RID: 1541
		SystemMemoryTopologyInformation,
		// Token: 0x04000606 RID: 1542
		SystemMemoryChannelInformation,
		// Token: 0x04000607 RID: 1543
		SystemBootLogoInformation,
		// Token: 0x04000608 RID: 1544
		SystemProcessorPerformanceInformationEx,
		// Token: 0x04000609 RID: 1545
		SystemSpare0,
		// Token: 0x0400060A RID: 1546
		SystemSecureBootPolicyInformation,
		// Token: 0x0400060B RID: 1547
		SystemPageFileInformationEx,
		// Token: 0x0400060C RID: 1548
		SystemSecureBootInformation,
		// Token: 0x0400060D RID: 1549
		SystemEntropyInterruptTimingRawInformation,
		// Token: 0x0400060E RID: 1550
		SystemPortableWorkspaceEfiLauncherInformation,
		// Token: 0x0400060F RID: 1551
		SystemFullProcessInformation,
		// Token: 0x04000610 RID: 1552
		SystemKernelDebuggerInformationEx,
		// Token: 0x04000611 RID: 1553
		SystemBootMetadataInformation,
		// Token: 0x04000612 RID: 1554
		SystemSoftRebootInformation,
		// Token: 0x04000613 RID: 1555
		SystemElamCertificateInformation,
		// Token: 0x04000614 RID: 1556
		SystemOfflineDumpConfigInformation,
		// Token: 0x04000615 RID: 1557
		SystemProcessorFeaturesInformation,
		// Token: 0x04000616 RID: 1558
		SystemRegistryReconciliationInformation,
		// Token: 0x04000617 RID: 1559
		SystemEdidInformation,
		// Token: 0x04000618 RID: 1560
		MaxSystemInfoClass
	}
}
