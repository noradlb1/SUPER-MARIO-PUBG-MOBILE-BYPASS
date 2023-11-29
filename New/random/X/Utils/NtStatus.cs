using System;

namespace X.Utils
{
	// Token: 0x0200004B RID: 75
	public enum NtStatus : uint
	{
		// Token: 0x040003ED RID: 1005
		Success,
		// Token: 0x040003EE RID: 1006
		Wait0 = 0U,
		// Token: 0x040003EF RID: 1007
		Wait1,
		// Token: 0x040003F0 RID: 1008
		Wait2,
		// Token: 0x040003F1 RID: 1009
		Wait3,
		// Token: 0x040003F2 RID: 1010
		Wait63 = 63U,
		// Token: 0x040003F3 RID: 1011
		Abandoned = 128U,
		// Token: 0x040003F4 RID: 1012
		AbandonedWait0 = 128U,
		// Token: 0x040003F5 RID: 1013
		AbandonedWait1,
		// Token: 0x040003F6 RID: 1014
		AbandonedWait2,
		// Token: 0x040003F7 RID: 1015
		AbandonedWait3,
		// Token: 0x040003F8 RID: 1016
		AbandonedWait63 = 191U,
		// Token: 0x040003F9 RID: 1017
		UserApc,
		// Token: 0x040003FA RID: 1018
		KernelApc = 256U,
		// Token: 0x040003FB RID: 1019
		Alerted,
		// Token: 0x040003FC RID: 1020
		Timeout,
		// Token: 0x040003FD RID: 1021
		Pending,
		// Token: 0x040003FE RID: 1022
		Reparse,
		// Token: 0x040003FF RID: 1023
		MoreEntries,
		// Token: 0x04000400 RID: 1024
		NotAllAssigned,
		// Token: 0x04000401 RID: 1025
		SomeNotMapped,
		// Token: 0x04000402 RID: 1026
		OpLockBreakInProgress,
		// Token: 0x04000403 RID: 1027
		VolumeMounted,
		// Token: 0x04000404 RID: 1028
		RxActCommitted,
		// Token: 0x04000405 RID: 1029
		NotifyCleanup,
		// Token: 0x04000406 RID: 1030
		NotifyEnumDir,
		// Token: 0x04000407 RID: 1031
		NoQuotasForAccount,
		// Token: 0x04000408 RID: 1032
		PrimaryTransportConnectFailed,
		// Token: 0x04000409 RID: 1033
		PageFaultTransition = 272U,
		// Token: 0x0400040A RID: 1034
		PageFaultDemandZero,
		// Token: 0x0400040B RID: 1035
		PageFaultCopyOnWrite,
		// Token: 0x0400040C RID: 1036
		PageFaultGuardPage,
		// Token: 0x0400040D RID: 1037
		PageFaultPagingFile,
		// Token: 0x0400040E RID: 1038
		CrashDump = 278U,
		// Token: 0x0400040F RID: 1039
		ReparseObject = 280U,
		// Token: 0x04000410 RID: 1040
		NothingToTerminate = 290U,
		// Token: 0x04000411 RID: 1041
		ProcessNotInJob,
		// Token: 0x04000412 RID: 1042
		ProcessInJob,
		// Token: 0x04000413 RID: 1043
		ProcessCloned = 297U,
		// Token: 0x04000414 RID: 1044
		FileLockedWithOnlyReaders,
		// Token: 0x04000415 RID: 1045
		FileLockedWithWriters,
		// Token: 0x04000416 RID: 1046
		Informational = 1073741824U,
		// Token: 0x04000417 RID: 1047
		ObjectNameExists = 1073741824U,
		// Token: 0x04000418 RID: 1048
		ThreadWasSuspended,
		// Token: 0x04000419 RID: 1049
		WorkingSetLimitRange,
		// Token: 0x0400041A RID: 1050
		ImageNotAtBase,
		// Token: 0x0400041B RID: 1051
		RegistryRecovered = 1073741833U,
		// Token: 0x0400041C RID: 1052
		Warning = 2147483648U,
		// Token: 0x0400041D RID: 1053
		GuardPageViolation,
		// Token: 0x0400041E RID: 1054
		DatatypeMisalignment,
		// Token: 0x0400041F RID: 1055
		Breakpoint,
		// Token: 0x04000420 RID: 1056
		SingleStep,
		// Token: 0x04000421 RID: 1057
		BufferOverflow,
		// Token: 0x04000422 RID: 1058
		NoMoreFiles,
		// Token: 0x04000423 RID: 1059
		HandlesClosed = 2147483658U,
		// Token: 0x04000424 RID: 1060
		PartialCopy = 2147483661U,
		// Token: 0x04000425 RID: 1061
		DeviceBusy = 2147483665U,
		// Token: 0x04000426 RID: 1062
		InvalidEaName = 2147483667U,
		// Token: 0x04000427 RID: 1063
		EaListInconsistent,
		// Token: 0x04000428 RID: 1064
		NoMoreEntries = 2147483674U,
		// Token: 0x04000429 RID: 1065
		LongJump = 2147483686U,
		// Token: 0x0400042A RID: 1066
		DllMightBeInsecure = 2147483691U,
		// Token: 0x0400042B RID: 1067
		Error = 3221225472U,
		// Token: 0x0400042C RID: 1068
		Unsuccessful,
		// Token: 0x0400042D RID: 1069
		NotImplemented,
		// Token: 0x0400042E RID: 1070
		InvalidInfoClass,
		// Token: 0x0400042F RID: 1071
		InfoLengthMismatch,
		// Token: 0x04000430 RID: 1072
		AccessViolation,
		// Token: 0x04000431 RID: 1073
		InPageError,
		// Token: 0x04000432 RID: 1074
		PagefileQuota,
		// Token: 0x04000433 RID: 1075
		InvalidHandle,
		// Token: 0x04000434 RID: 1076
		BadInitialStack,
		// Token: 0x04000435 RID: 1077
		BadInitialPc,
		// Token: 0x04000436 RID: 1078
		InvalidCid,
		// Token: 0x04000437 RID: 1079
		TimerNotCanceled,
		// Token: 0x04000438 RID: 1080
		InvalidParameter,
		// Token: 0x04000439 RID: 1081
		NoSuchDevice,
		// Token: 0x0400043A RID: 1082
		NoSuchFile,
		// Token: 0x0400043B RID: 1083
		InvalidDeviceRequest,
		// Token: 0x0400043C RID: 1084
		EndOfFile,
		// Token: 0x0400043D RID: 1085
		WrongVolume,
		// Token: 0x0400043E RID: 1086
		NoMediaInDevice,
		// Token: 0x0400043F RID: 1087
		NoMemory = 3221225495U,
		// Token: 0x04000440 RID: 1088
		NotMappedView = 3221225497U,
		// Token: 0x04000441 RID: 1089
		UnableToFreeVm,
		// Token: 0x04000442 RID: 1090
		UnableToDeleteSection,
		// Token: 0x04000443 RID: 1091
		IllegalInstruction = 3221225501U,
		// Token: 0x04000444 RID: 1092
		AlreadyCommitted = 3221225505U,
		// Token: 0x04000445 RID: 1093
		AccessDenied,
		// Token: 0x04000446 RID: 1094
		BufferTooSmall,
		// Token: 0x04000447 RID: 1095
		ObjectTypeMismatch,
		// Token: 0x04000448 RID: 1096
		NonContinuableException,
		// Token: 0x04000449 RID: 1097
		BadStack = 3221225512U,
		// Token: 0x0400044A RID: 1098
		NotLocked = 3221225514U,
		// Token: 0x0400044B RID: 1099
		NotCommitted = 3221225517U,
		// Token: 0x0400044C RID: 1100
		InvalidParameterMix = 3221225520U,
		// Token: 0x0400044D RID: 1101
		ObjectNameInvalid = 3221225523U,
		// Token: 0x0400044E RID: 1102
		ObjectNameNotFound,
		// Token: 0x0400044F RID: 1103
		ObjectNameCollision,
		// Token: 0x04000450 RID: 1104
		ObjectPathInvalid = 3221225529U,
		// Token: 0x04000451 RID: 1105
		ObjectPathNotFound,
		// Token: 0x04000452 RID: 1106
		ObjectPathSyntaxBad,
		// Token: 0x04000453 RID: 1107
		DataOverrun,
		// Token: 0x04000454 RID: 1108
		DataLate,
		// Token: 0x04000455 RID: 1109
		DataError,
		// Token: 0x04000456 RID: 1110
		CrcError,
		// Token: 0x04000457 RID: 1111
		SectionTooBig,
		// Token: 0x04000458 RID: 1112
		PortConnectionRefused,
		// Token: 0x04000459 RID: 1113
		InvalidPortHandle,
		// Token: 0x0400045A RID: 1114
		SharingViolation,
		// Token: 0x0400045B RID: 1115
		QuotaExceeded,
		// Token: 0x0400045C RID: 1116
		InvalidPageProtection,
		// Token: 0x0400045D RID: 1117
		MutantNotOwned,
		// Token: 0x0400045E RID: 1118
		SemaphoreLimitExceeded,
		// Token: 0x0400045F RID: 1119
		PortAlreadySet,
		// Token: 0x04000460 RID: 1120
		SectionNotImage,
		// Token: 0x04000461 RID: 1121
		SuspendCountExceeded,
		// Token: 0x04000462 RID: 1122
		ThreadIsTerminating,
		// Token: 0x04000463 RID: 1123
		BadWorkingSetLimit,
		// Token: 0x04000464 RID: 1124
		IncompatibleFileMap,
		// Token: 0x04000465 RID: 1125
		SectionProtection,
		// Token: 0x04000466 RID: 1126
		EasNotSupported,
		// Token: 0x04000467 RID: 1127
		EaTooLarge,
		// Token: 0x04000468 RID: 1128
		NonExistentEaEntry,
		// Token: 0x04000469 RID: 1129
		NoEasOnFile,
		// Token: 0x0400046A RID: 1130
		EaCorruptError,
		// Token: 0x0400046B RID: 1131
		FileLockConflict,
		// Token: 0x0400046C RID: 1132
		LockNotGranted,
		// Token: 0x0400046D RID: 1133
		DeletePending,
		// Token: 0x0400046E RID: 1134
		CtlFileNotSupported,
		// Token: 0x0400046F RID: 1135
		UnknownRevision,
		// Token: 0x04000470 RID: 1136
		RevisionMismatch,
		// Token: 0x04000471 RID: 1137
		InvalidOwner,
		// Token: 0x04000472 RID: 1138
		InvalidPrimaryGroup,
		// Token: 0x04000473 RID: 1139
		NoImpersonationToken,
		// Token: 0x04000474 RID: 1140
		CantDisableMandatory,
		// Token: 0x04000475 RID: 1141
		NoLogonServers,
		// Token: 0x04000476 RID: 1142
		NoSuchLogonSession,
		// Token: 0x04000477 RID: 1143
		NoSuchPrivilege,
		// Token: 0x04000478 RID: 1144
		PrivilegeNotHeld,
		// Token: 0x04000479 RID: 1145
		InvalidAccountName,
		// Token: 0x0400047A RID: 1146
		UserExists,
		// Token: 0x0400047B RID: 1147
		NoSuchUser,
		// Token: 0x0400047C RID: 1148
		GroupExists,
		// Token: 0x0400047D RID: 1149
		NoSuchGroup,
		// Token: 0x0400047E RID: 1150
		MemberInGroup,
		// Token: 0x0400047F RID: 1151
		MemberNotInGroup,
		// Token: 0x04000480 RID: 1152
		LastAdmin,
		// Token: 0x04000481 RID: 1153
		WrongPassword,
		// Token: 0x04000482 RID: 1154
		IllFormedPassword,
		// Token: 0x04000483 RID: 1155
		PasswordRestriction,
		// Token: 0x04000484 RID: 1156
		LogonFailure,
		// Token: 0x04000485 RID: 1157
		AccountRestriction,
		// Token: 0x04000486 RID: 1158
		InvalidLogonHours,
		// Token: 0x04000487 RID: 1159
		InvalidWorkstation,
		// Token: 0x04000488 RID: 1160
		PasswordExpired,
		// Token: 0x04000489 RID: 1161
		AccountDisabled,
		// Token: 0x0400048A RID: 1162
		NoneMapped,
		// Token: 0x0400048B RID: 1163
		TooManyLuidsRequested,
		// Token: 0x0400048C RID: 1164
		LuidsExhausted,
		// Token: 0x0400048D RID: 1165
		InvalidSubAuthority,
		// Token: 0x0400048E RID: 1166
		InvalidAcl,
		// Token: 0x0400048F RID: 1167
		InvalidSid,
		// Token: 0x04000490 RID: 1168
		InvalidSecurityDescr,
		// Token: 0x04000491 RID: 1169
		ProcedureNotFound,
		// Token: 0x04000492 RID: 1170
		InvalidImageFormat,
		// Token: 0x04000493 RID: 1171
		NoToken,
		// Token: 0x04000494 RID: 1172
		BadInheritanceAcl,
		// Token: 0x04000495 RID: 1173
		RangeNotLocked,
		// Token: 0x04000496 RID: 1174
		DiskFull,
		// Token: 0x04000497 RID: 1175
		ServerDisabled,
		// Token: 0x04000498 RID: 1176
		ServerNotDisabled,
		// Token: 0x04000499 RID: 1177
		TooManyGuidsRequested,
		// Token: 0x0400049A RID: 1178
		GuidsExhausted,
		// Token: 0x0400049B RID: 1179
		InvalidIdAuthority,
		// Token: 0x0400049C RID: 1180
		AgentsExhausted,
		// Token: 0x0400049D RID: 1181
		InvalidVolumeLabel,
		// Token: 0x0400049E RID: 1182
		SectionNotExtended,
		// Token: 0x0400049F RID: 1183
		NotMappedData,
		// Token: 0x040004A0 RID: 1184
		ResourceDataNotFound,
		// Token: 0x040004A1 RID: 1185
		ResourceTypeNotFound,
		// Token: 0x040004A2 RID: 1186
		ResourceNameNotFound,
		// Token: 0x040004A3 RID: 1187
		ArrayBoundsExceeded,
		// Token: 0x040004A4 RID: 1188
		FloatDenormalOperand,
		// Token: 0x040004A5 RID: 1189
		FloatDivideByZero,
		// Token: 0x040004A6 RID: 1190
		FloatInexactResult,
		// Token: 0x040004A7 RID: 1191
		FloatInvalidOperation,
		// Token: 0x040004A8 RID: 1192
		FloatOverflow,
		// Token: 0x040004A9 RID: 1193
		FloatStackCheck,
		// Token: 0x040004AA RID: 1194
		FloatUnderflow,
		// Token: 0x040004AB RID: 1195
		IntegerDivideByZero,
		// Token: 0x040004AC RID: 1196
		IntegerOverflow,
		// Token: 0x040004AD RID: 1197
		PrivilegedInstruction,
		// Token: 0x040004AE RID: 1198
		TooManyPagingFiles,
		// Token: 0x040004AF RID: 1199
		FileInvalid,
		// Token: 0x040004B0 RID: 1200
		InstanceNotAvailable = 3221225643U,
		// Token: 0x040004B1 RID: 1201
		PipeNotAvailable,
		// Token: 0x040004B2 RID: 1202
		InvalidPipeState,
		// Token: 0x040004B3 RID: 1203
		PipeBusy,
		// Token: 0x040004B4 RID: 1204
		IllegalFunction,
		// Token: 0x040004B5 RID: 1205
		PipeDisconnected,
		// Token: 0x040004B6 RID: 1206
		PipeClosing,
		// Token: 0x040004B7 RID: 1207
		PipeConnected,
		// Token: 0x040004B8 RID: 1208
		PipeListening,
		// Token: 0x040004B9 RID: 1209
		InvalidReadMode,
		// Token: 0x040004BA RID: 1210
		IoTimeout,
		// Token: 0x040004BB RID: 1211
		FileForcedClosed,
		// Token: 0x040004BC RID: 1212
		ProfilingNotStarted,
		// Token: 0x040004BD RID: 1213
		ProfilingNotStopped,
		// Token: 0x040004BE RID: 1214
		NotSameDevice = 3221225684U,
		// Token: 0x040004BF RID: 1215
		FileRenamed,
		// Token: 0x040004C0 RID: 1216
		CantWait = 3221225688U,
		// Token: 0x040004C1 RID: 1217
		PipeEmpty,
		// Token: 0x040004C2 RID: 1218
		CantTerminateSelf = 3221225691U,
		// Token: 0x040004C3 RID: 1219
		InternalError = 3221225701U,
		// Token: 0x040004C4 RID: 1220
		InvalidParameter1 = 3221225711U,
		// Token: 0x040004C5 RID: 1221
		InvalidParameter2,
		// Token: 0x040004C6 RID: 1222
		InvalidParameter3,
		// Token: 0x040004C7 RID: 1223
		InvalidParameter4,
		// Token: 0x040004C8 RID: 1224
		InvalidParameter5,
		// Token: 0x040004C9 RID: 1225
		InvalidParameter6,
		// Token: 0x040004CA RID: 1226
		InvalidParameter7,
		// Token: 0x040004CB RID: 1227
		InvalidParameter8,
		// Token: 0x040004CC RID: 1228
		InvalidParameter9,
		// Token: 0x040004CD RID: 1229
		InvalidParameter10,
		// Token: 0x040004CE RID: 1230
		InvalidParameter11,
		// Token: 0x040004CF RID: 1231
		InvalidParameter12,
		// Token: 0x040004D0 RID: 1232
		MappedFileSizeZero = 3221225758U,
		// Token: 0x040004D1 RID: 1233
		TooManyOpenedFiles,
		// Token: 0x040004D2 RID: 1234
		Cancelled,
		// Token: 0x040004D3 RID: 1235
		CannotDelete,
		// Token: 0x040004D4 RID: 1236
		InvalidComputerName,
		// Token: 0x040004D5 RID: 1237
		FileDeleted,
		// Token: 0x040004D6 RID: 1238
		SpecialAccount,
		// Token: 0x040004D7 RID: 1239
		SpecialGroup,
		// Token: 0x040004D8 RID: 1240
		SpecialUser,
		// Token: 0x040004D9 RID: 1241
		MembersPrimaryGroup,
		// Token: 0x040004DA RID: 1242
		FileClosed,
		// Token: 0x040004DB RID: 1243
		TooManyThreads,
		// Token: 0x040004DC RID: 1244
		ThreadNotInProcess,
		// Token: 0x040004DD RID: 1245
		TokenAlreadyInUse,
		// Token: 0x040004DE RID: 1246
		PagefileQuotaExceeded,
		// Token: 0x040004DF RID: 1247
		CommitmentLimit,
		// Token: 0x040004E0 RID: 1248
		InvalidImageLeFormat,
		// Token: 0x040004E1 RID: 1249
		InvalidImageNotMz,
		// Token: 0x040004E2 RID: 1250
		InvalidImageProtect,
		// Token: 0x040004E3 RID: 1251
		InvalidImageWin16,
		// Token: 0x040004E4 RID: 1252
		LogonServer,
		// Token: 0x040004E5 RID: 1253
		DifferenceAtDc,
		// Token: 0x040004E6 RID: 1254
		SynchronizationRequired,
		// Token: 0x040004E7 RID: 1255
		DllNotFound,
		// Token: 0x040004E8 RID: 1256
		IoPrivilegeFailed = 3221225783U,
		// Token: 0x040004E9 RID: 1257
		OrdinalNotFound,
		// Token: 0x040004EA RID: 1258
		EntryPointNotFound,
		// Token: 0x040004EB RID: 1259
		ControlCExit,
		// Token: 0x040004EC RID: 1260
		PortNotSet = 3221226323U,
		// Token: 0x040004ED RID: 1261
		DebuggerInactive,
		// Token: 0x040004EE RID: 1262
		CallbackBypass = 3221226755U,
		// Token: 0x040004EF RID: 1263
		PortClosed = 3221227264U,
		// Token: 0x040004F0 RID: 1264
		MessageLost,
		// Token: 0x040004F1 RID: 1265
		InvalidMessage,
		// Token: 0x040004F2 RID: 1266
		RequestCanceled,
		// Token: 0x040004F3 RID: 1267
		RecursiveDispatch,
		// Token: 0x040004F4 RID: 1268
		LpcReceiveBufferExpected,
		// Token: 0x040004F5 RID: 1269
		LpcInvalidConnectionUsage,
		// Token: 0x040004F6 RID: 1270
		LpcRequestsNotAllowed,
		// Token: 0x040004F7 RID: 1271
		ResourceInUse,
		// Token: 0x040004F8 RID: 1272
		ProcessIsProtected = 3221227282U,
		// Token: 0x040004F9 RID: 1273
		VolumeDirty = 3221227526U,
		// Token: 0x040004FA RID: 1274
		FileCheckedOut = 3221227777U,
		// Token: 0x040004FB RID: 1275
		CheckOutRequired,
		// Token: 0x040004FC RID: 1276
		BadFileType,
		// Token: 0x040004FD RID: 1277
		FileTooLarge,
		// Token: 0x040004FE RID: 1278
		FormsAuthRequired,
		// Token: 0x040004FF RID: 1279
		VirusInfected,
		// Token: 0x04000500 RID: 1280
		VirusDeleted,
		// Token: 0x04000501 RID: 1281
		TransactionalConflict = 3222863873U,
		// Token: 0x04000502 RID: 1282
		InvalidTransaction,
		// Token: 0x04000503 RID: 1283
		TransactionNotActive,
		// Token: 0x04000504 RID: 1284
		TmInitializationFailed,
		// Token: 0x04000505 RID: 1285
		RmNotActive,
		// Token: 0x04000506 RID: 1286
		RmMetadataCorrupt,
		// Token: 0x04000507 RID: 1287
		TransactionNotJoined,
		// Token: 0x04000508 RID: 1288
		DirectoryNotRm,
		// Token: 0x04000509 RID: 1289
		CouldNotResizeLog,
		// Token: 0x0400050A RID: 1290
		TransactionsUnsupportedRemote,
		// Token: 0x0400050B RID: 1291
		LogResizeInvalidSize,
		// Token: 0x0400050C RID: 1292
		RemoteFileVersionMismatch,
		// Token: 0x0400050D RID: 1293
		CrmProtocolAlreadyExists = 3222863887U,
		// Token: 0x0400050E RID: 1294
		TransactionPropagationFailed,
		// Token: 0x0400050F RID: 1295
		CrmProtocolNotFound,
		// Token: 0x04000510 RID: 1296
		TransactionSuperiorExists,
		// Token: 0x04000511 RID: 1297
		TransactionRequestNotValid,
		// Token: 0x04000512 RID: 1298
		TransactionNotRequested,
		// Token: 0x04000513 RID: 1299
		TransactionAlreadyAborted,
		// Token: 0x04000514 RID: 1300
		TransactionAlreadyCommitted,
		// Token: 0x04000515 RID: 1301
		TransactionInvalidMarshallBuffer,
		// Token: 0x04000516 RID: 1302
		CurrentTransactionNotValid,
		// Token: 0x04000517 RID: 1303
		LogGrowthFailed,
		// Token: 0x04000518 RID: 1304
		ObjectNoLongerExists = 3222863905U,
		// Token: 0x04000519 RID: 1305
		StreamMiniversionNotFound,
		// Token: 0x0400051A RID: 1306
		StreamMiniversionNotValid,
		// Token: 0x0400051B RID: 1307
		MiniversionInaccessibleFromSpecifiedTransaction,
		// Token: 0x0400051C RID: 1308
		CantOpenMiniversionWithModifyIntent,
		// Token: 0x0400051D RID: 1309
		CantCreateMoreStreamMiniversions,
		// Token: 0x0400051E RID: 1310
		HandleNoLongerValid = 3222863912U,
		// Token: 0x0400051F RID: 1311
		NoTxfMetadata,
		// Token: 0x04000520 RID: 1312
		LogCorruptionDetected = 3222863920U,
		// Token: 0x04000521 RID: 1313
		CantRecoverWithHandleOpen,
		// Token: 0x04000522 RID: 1314
		RmDisconnected,
		// Token: 0x04000523 RID: 1315
		EnlistmentNotSuperior,
		// Token: 0x04000524 RID: 1316
		RecoveryNotNeeded,
		// Token: 0x04000525 RID: 1317
		RmAlreadyStarted,
		// Token: 0x04000526 RID: 1318
		FileIdentityNotPersistent,
		// Token: 0x04000527 RID: 1319
		CantBreakTransactionalDependency,
		// Token: 0x04000528 RID: 1320
		CantCrossRmBoundary,
		// Token: 0x04000529 RID: 1321
		TxfDirNotEmpty,
		// Token: 0x0400052A RID: 1322
		IndoubtTransactionsExist,
		// Token: 0x0400052B RID: 1323
		TmVolatile,
		// Token: 0x0400052C RID: 1324
		RollbackTimerExpired,
		// Token: 0x0400052D RID: 1325
		TxfAttributeCorrupt,
		// Token: 0x0400052E RID: 1326
		EfsNotAllowedInTransaction,
		// Token: 0x0400052F RID: 1327
		TransactionalOpenNotAllowed,
		// Token: 0x04000530 RID: 1328
		TransactedMappingUnsupportedRemote,
		// Token: 0x04000531 RID: 1329
		TxfMetadataAlreadyPresent,
		// Token: 0x04000532 RID: 1330
		TransactionScopeCallbacksNotSet,
		// Token: 0x04000533 RID: 1331
		TransactionRequiredPromotion,
		// Token: 0x04000534 RID: 1332
		CannotExecuteFileInTransaction,
		// Token: 0x04000535 RID: 1333
		TransactionsNotFrozen,
		// Token: 0x04000536 RID: 1334
		MaximumNtStatus = 4294967295U
	}
}
