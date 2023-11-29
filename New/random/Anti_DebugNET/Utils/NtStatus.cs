using System;

namespace Anti_DebugNET.Utils
{
	// Token: 0x02000003 RID: 3
	public enum NtStatus : uint
	{
		// Token: 0x04000004 RID: 4
		Success,
		// Token: 0x04000005 RID: 5
		Wait0 = 0U,
		// Token: 0x04000006 RID: 6
		Wait1,
		// Token: 0x04000007 RID: 7
		Wait2,
		// Token: 0x04000008 RID: 8
		Wait3,
		// Token: 0x04000009 RID: 9
		Wait63 = 63U,
		// Token: 0x0400000A RID: 10
		Abandoned = 128U,
		// Token: 0x0400000B RID: 11
		AbandonedWait0 = 128U,
		// Token: 0x0400000C RID: 12
		AbandonedWait1,
		// Token: 0x0400000D RID: 13
		AbandonedWait2,
		// Token: 0x0400000E RID: 14
		AbandonedWait3,
		// Token: 0x0400000F RID: 15
		AbandonedWait63 = 191U,
		// Token: 0x04000010 RID: 16
		UserApc,
		// Token: 0x04000011 RID: 17
		KernelApc = 256U,
		// Token: 0x04000012 RID: 18
		Alerted,
		// Token: 0x04000013 RID: 19
		Timeout,
		// Token: 0x04000014 RID: 20
		Pending,
		// Token: 0x04000015 RID: 21
		Reparse,
		// Token: 0x04000016 RID: 22
		MoreEntries,
		// Token: 0x04000017 RID: 23
		NotAllAssigned,
		// Token: 0x04000018 RID: 24
		SomeNotMapped,
		// Token: 0x04000019 RID: 25
		OpLockBreakInProgress,
		// Token: 0x0400001A RID: 26
		VolumeMounted,
		// Token: 0x0400001B RID: 27
		RxActCommitted,
		// Token: 0x0400001C RID: 28
		NotifyCleanup,
		// Token: 0x0400001D RID: 29
		NotifyEnumDir,
		// Token: 0x0400001E RID: 30
		NoQuotasForAccount,
		// Token: 0x0400001F RID: 31
		PrimaryTransportConnectFailed,
		// Token: 0x04000020 RID: 32
		PageFaultTransition = 272U,
		// Token: 0x04000021 RID: 33
		PageFaultDemandZero,
		// Token: 0x04000022 RID: 34
		PageFaultCopyOnWrite,
		// Token: 0x04000023 RID: 35
		PageFaultGuardPage,
		// Token: 0x04000024 RID: 36
		PageFaultPagingFile,
		// Token: 0x04000025 RID: 37
		CrashDump = 278U,
		// Token: 0x04000026 RID: 38
		ReparseObject = 280U,
		// Token: 0x04000027 RID: 39
		NothingToTerminate = 290U,
		// Token: 0x04000028 RID: 40
		ProcessNotInJob,
		// Token: 0x04000029 RID: 41
		ProcessInJob,
		// Token: 0x0400002A RID: 42
		ProcessCloned = 297U,
		// Token: 0x0400002B RID: 43
		FileLockedWithOnlyReaders,
		// Token: 0x0400002C RID: 44
		FileLockedWithWriters,
		// Token: 0x0400002D RID: 45
		Informational = 1073741824U,
		// Token: 0x0400002E RID: 46
		ObjectNameExists = 1073741824U,
		// Token: 0x0400002F RID: 47
		ThreadWasSuspended,
		// Token: 0x04000030 RID: 48
		WorkingSetLimitRange,
		// Token: 0x04000031 RID: 49
		ImageNotAtBase,
		// Token: 0x04000032 RID: 50
		RegistryRecovered = 1073741833U,
		// Token: 0x04000033 RID: 51
		Warning = 2147483648U,
		// Token: 0x04000034 RID: 52
		GuardPageViolation,
		// Token: 0x04000035 RID: 53
		DatatypeMisalignment,
		// Token: 0x04000036 RID: 54
		Breakpoint,
		// Token: 0x04000037 RID: 55
		SingleStep,
		// Token: 0x04000038 RID: 56
		BufferOverflow,
		// Token: 0x04000039 RID: 57
		NoMoreFiles,
		// Token: 0x0400003A RID: 58
		HandlesClosed = 2147483658U,
		// Token: 0x0400003B RID: 59
		PartialCopy = 2147483661U,
		// Token: 0x0400003C RID: 60
		DeviceBusy = 2147483665U,
		// Token: 0x0400003D RID: 61
		InvalidEaName = 2147483667U,
		// Token: 0x0400003E RID: 62
		EaListInconsistent,
		// Token: 0x0400003F RID: 63
		NoMoreEntries = 2147483674U,
		// Token: 0x04000040 RID: 64
		LongJump = 2147483686U,
		// Token: 0x04000041 RID: 65
		DllMightBeInsecure = 2147483691U,
		// Token: 0x04000042 RID: 66
		Error = 3221225472U,
		// Token: 0x04000043 RID: 67
		Unsuccessful,
		// Token: 0x04000044 RID: 68
		NotImplemented,
		// Token: 0x04000045 RID: 69
		InvalidInfoClass,
		// Token: 0x04000046 RID: 70
		InfoLengthMismatch,
		// Token: 0x04000047 RID: 71
		AccessViolation,
		// Token: 0x04000048 RID: 72
		InPageError,
		// Token: 0x04000049 RID: 73
		PagefileQuota,
		// Token: 0x0400004A RID: 74
		InvalidHandle,
		// Token: 0x0400004B RID: 75
		BadInitialStack,
		// Token: 0x0400004C RID: 76
		BadInitialPc,
		// Token: 0x0400004D RID: 77
		InvalidCid,
		// Token: 0x0400004E RID: 78
		TimerNotCanceled,
		// Token: 0x0400004F RID: 79
		InvalidParameter,
		// Token: 0x04000050 RID: 80
		NoSuchDevice,
		// Token: 0x04000051 RID: 81
		NoSuchFile,
		// Token: 0x04000052 RID: 82
		InvalidDeviceRequest,
		// Token: 0x04000053 RID: 83
		EndOfFile,
		// Token: 0x04000054 RID: 84
		WrongVolume,
		// Token: 0x04000055 RID: 85
		NoMediaInDevice,
		// Token: 0x04000056 RID: 86
		NoMemory = 3221225495U,
		// Token: 0x04000057 RID: 87
		NotMappedView = 3221225497U,
		// Token: 0x04000058 RID: 88
		UnableToFreeVm,
		// Token: 0x04000059 RID: 89
		UnableToDeleteSection,
		// Token: 0x0400005A RID: 90
		IllegalInstruction = 3221225501U,
		// Token: 0x0400005B RID: 91
		AlreadyCommitted = 3221225505U,
		// Token: 0x0400005C RID: 92
		AccessDenied,
		// Token: 0x0400005D RID: 93
		BufferTooSmall,
		// Token: 0x0400005E RID: 94
		ObjectTypeMismatch,
		// Token: 0x0400005F RID: 95
		NonContinuableException,
		// Token: 0x04000060 RID: 96
		BadStack = 3221225512U,
		// Token: 0x04000061 RID: 97
		NotLocked = 3221225514U,
		// Token: 0x04000062 RID: 98
		NotCommitted = 3221225517U,
		// Token: 0x04000063 RID: 99
		InvalidParameterMix = 3221225520U,
		// Token: 0x04000064 RID: 100
		ObjectNameInvalid = 3221225523U,
		// Token: 0x04000065 RID: 101
		ObjectNameNotFound,
		// Token: 0x04000066 RID: 102
		ObjectNameCollision,
		// Token: 0x04000067 RID: 103
		ObjectPathInvalid = 3221225529U,
		// Token: 0x04000068 RID: 104
		ObjectPathNotFound,
		// Token: 0x04000069 RID: 105
		ObjectPathSyntaxBad,
		// Token: 0x0400006A RID: 106
		DataOverrun,
		// Token: 0x0400006B RID: 107
		DataLate,
		// Token: 0x0400006C RID: 108
		DataError,
		// Token: 0x0400006D RID: 109
		CrcError,
		// Token: 0x0400006E RID: 110
		SectionTooBig,
		// Token: 0x0400006F RID: 111
		PortConnectionRefused,
		// Token: 0x04000070 RID: 112
		InvalidPortHandle,
		// Token: 0x04000071 RID: 113
		SharingViolation,
		// Token: 0x04000072 RID: 114
		QuotaExceeded,
		// Token: 0x04000073 RID: 115
		InvalidPageProtection,
		// Token: 0x04000074 RID: 116
		MutantNotOwned,
		// Token: 0x04000075 RID: 117
		SemaphoreLimitExceeded,
		// Token: 0x04000076 RID: 118
		PortAlreadySet,
		// Token: 0x04000077 RID: 119
		SectionNotImage,
		// Token: 0x04000078 RID: 120
		SuspendCountExceeded,
		// Token: 0x04000079 RID: 121
		ThreadIsTerminating,
		// Token: 0x0400007A RID: 122
		BadWorkingSetLimit,
		// Token: 0x0400007B RID: 123
		IncompatibleFileMap,
		// Token: 0x0400007C RID: 124
		SectionProtection,
		// Token: 0x0400007D RID: 125
		EasNotSupported,
		// Token: 0x0400007E RID: 126
		EaTooLarge,
		// Token: 0x0400007F RID: 127
		NonExistentEaEntry,
		// Token: 0x04000080 RID: 128
		NoEasOnFile,
		// Token: 0x04000081 RID: 129
		EaCorruptError,
		// Token: 0x04000082 RID: 130
		FileLockConflict,
		// Token: 0x04000083 RID: 131
		LockNotGranted,
		// Token: 0x04000084 RID: 132
		DeletePending,
		// Token: 0x04000085 RID: 133
		CtlFileNotSupported,
		// Token: 0x04000086 RID: 134
		UnknownRevision,
		// Token: 0x04000087 RID: 135
		RevisionMismatch,
		// Token: 0x04000088 RID: 136
		InvalidOwner,
		// Token: 0x04000089 RID: 137
		InvalidPrimaryGroup,
		// Token: 0x0400008A RID: 138
		NoImpersonationToken,
		// Token: 0x0400008B RID: 139
		CantDisableMandatory,
		// Token: 0x0400008C RID: 140
		NoLogonServers,
		// Token: 0x0400008D RID: 141
		NoSuchLogonSession,
		// Token: 0x0400008E RID: 142
		NoSuchPrivilege,
		// Token: 0x0400008F RID: 143
		PrivilegeNotHeld,
		// Token: 0x04000090 RID: 144
		InvalidAccountName,
		// Token: 0x04000091 RID: 145
		UserExists,
		// Token: 0x04000092 RID: 146
		NoSuchUser,
		// Token: 0x04000093 RID: 147
		GroupExists,
		// Token: 0x04000094 RID: 148
		NoSuchGroup,
		// Token: 0x04000095 RID: 149
		MemberInGroup,
		// Token: 0x04000096 RID: 150
		MemberNotInGroup,
		// Token: 0x04000097 RID: 151
		LastAdmin,
		// Token: 0x04000098 RID: 152
		WrongPassword,
		// Token: 0x04000099 RID: 153
		IllFormedPassword,
		// Token: 0x0400009A RID: 154
		PasswordRestriction,
		// Token: 0x0400009B RID: 155
		LogonFailure,
		// Token: 0x0400009C RID: 156
		AccountRestriction,
		// Token: 0x0400009D RID: 157
		InvalidLogonHours,
		// Token: 0x0400009E RID: 158
		InvalidWorkstation,
		// Token: 0x0400009F RID: 159
		PasswordExpired,
		// Token: 0x040000A0 RID: 160
		AccountDisabled,
		// Token: 0x040000A1 RID: 161
		NoneMapped,
		// Token: 0x040000A2 RID: 162
		TooManyLuidsRequested,
		// Token: 0x040000A3 RID: 163
		LuidsExhausted,
		// Token: 0x040000A4 RID: 164
		InvalidSubAuthority,
		// Token: 0x040000A5 RID: 165
		InvalidAcl,
		// Token: 0x040000A6 RID: 166
		InvalidSid,
		// Token: 0x040000A7 RID: 167
		InvalidSecurityDescr,
		// Token: 0x040000A8 RID: 168
		ProcedureNotFound,
		// Token: 0x040000A9 RID: 169
		InvalidImageFormat,
		// Token: 0x040000AA RID: 170
		NoToken,
		// Token: 0x040000AB RID: 171
		BadInheritanceAcl,
		// Token: 0x040000AC RID: 172
		RangeNotLocked,
		// Token: 0x040000AD RID: 173
		DiskFull,
		// Token: 0x040000AE RID: 174
		ServerDisabled,
		// Token: 0x040000AF RID: 175
		ServerNotDisabled,
		// Token: 0x040000B0 RID: 176
		TooManyGuidsRequested,
		// Token: 0x040000B1 RID: 177
		GuidsExhausted,
		// Token: 0x040000B2 RID: 178
		InvalidIdAuthority,
		// Token: 0x040000B3 RID: 179
		AgentsExhausted,
		// Token: 0x040000B4 RID: 180
		InvalidVolumeLabel,
		// Token: 0x040000B5 RID: 181
		SectionNotExtended,
		// Token: 0x040000B6 RID: 182
		NotMappedData,
		// Token: 0x040000B7 RID: 183
		ResourceDataNotFound,
		// Token: 0x040000B8 RID: 184
		ResourceTypeNotFound,
		// Token: 0x040000B9 RID: 185
		ResourceNameNotFound,
		// Token: 0x040000BA RID: 186
		ArrayBoundsExceeded,
		// Token: 0x040000BB RID: 187
		FloatDenormalOperand,
		// Token: 0x040000BC RID: 188
		FloatDivideByZero,
		// Token: 0x040000BD RID: 189
		FloatInexactResult,
		// Token: 0x040000BE RID: 190
		FloatInvalidOperation,
		// Token: 0x040000BF RID: 191
		FloatOverflow,
		// Token: 0x040000C0 RID: 192
		FloatStackCheck,
		// Token: 0x040000C1 RID: 193
		FloatUnderflow,
		// Token: 0x040000C2 RID: 194
		IntegerDivideByZero,
		// Token: 0x040000C3 RID: 195
		IntegerOverflow,
		// Token: 0x040000C4 RID: 196
		PrivilegedInstruction,
		// Token: 0x040000C5 RID: 197
		TooManyPagingFiles,
		// Token: 0x040000C6 RID: 198
		FileInvalid,
		// Token: 0x040000C7 RID: 199
		InstanceNotAvailable = 3221225643U,
		// Token: 0x040000C8 RID: 200
		PipeNotAvailable,
		// Token: 0x040000C9 RID: 201
		InvalidPipeState,
		// Token: 0x040000CA RID: 202
		PipeBusy,
		// Token: 0x040000CB RID: 203
		IllegalFunction,
		// Token: 0x040000CC RID: 204
		PipeDisconnected,
		// Token: 0x040000CD RID: 205
		PipeClosing,
		// Token: 0x040000CE RID: 206
		PipeConnected,
		// Token: 0x040000CF RID: 207
		PipeListening,
		// Token: 0x040000D0 RID: 208
		InvalidReadMode,
		// Token: 0x040000D1 RID: 209
		IoTimeout,
		// Token: 0x040000D2 RID: 210
		FileForcedClosed,
		// Token: 0x040000D3 RID: 211
		ProfilingNotStarted,
		// Token: 0x040000D4 RID: 212
		ProfilingNotStopped,
		// Token: 0x040000D5 RID: 213
		NotSameDevice = 3221225684U,
		// Token: 0x040000D6 RID: 214
		FileRenamed,
		// Token: 0x040000D7 RID: 215
		CantWait = 3221225688U,
		// Token: 0x040000D8 RID: 216
		PipeEmpty,
		// Token: 0x040000D9 RID: 217
		CantTerminateSelf = 3221225691U,
		// Token: 0x040000DA RID: 218
		InternalError = 3221225701U,
		// Token: 0x040000DB RID: 219
		InvalidParameter1 = 3221225711U,
		// Token: 0x040000DC RID: 220
		InvalidParameter2,
		// Token: 0x040000DD RID: 221
		InvalidParameter3,
		// Token: 0x040000DE RID: 222
		InvalidParameter4,
		// Token: 0x040000DF RID: 223
		InvalidParameter5,
		// Token: 0x040000E0 RID: 224
		InvalidParameter6,
		// Token: 0x040000E1 RID: 225
		InvalidParameter7,
		// Token: 0x040000E2 RID: 226
		InvalidParameter8,
		// Token: 0x040000E3 RID: 227
		InvalidParameter9,
		// Token: 0x040000E4 RID: 228
		InvalidParameter10,
		// Token: 0x040000E5 RID: 229
		InvalidParameter11,
		// Token: 0x040000E6 RID: 230
		InvalidParameter12,
		// Token: 0x040000E7 RID: 231
		MappedFileSizeZero = 3221225758U,
		// Token: 0x040000E8 RID: 232
		TooManyOpenedFiles,
		// Token: 0x040000E9 RID: 233
		Cancelled,
		// Token: 0x040000EA RID: 234
		CannotDelete,
		// Token: 0x040000EB RID: 235
		InvalidComputerName,
		// Token: 0x040000EC RID: 236
		FileDeleted,
		// Token: 0x040000ED RID: 237
		SpecialAccount,
		// Token: 0x040000EE RID: 238
		SpecialGroup,
		// Token: 0x040000EF RID: 239
		SpecialUser,
		// Token: 0x040000F0 RID: 240
		MembersPrimaryGroup,
		// Token: 0x040000F1 RID: 241
		FileClosed,
		// Token: 0x040000F2 RID: 242
		TooManyThreads,
		// Token: 0x040000F3 RID: 243
		ThreadNotInProcess,
		// Token: 0x040000F4 RID: 244
		TokenAlreadyInUse,
		// Token: 0x040000F5 RID: 245
		PagefileQuotaExceeded,
		// Token: 0x040000F6 RID: 246
		CommitmentLimit,
		// Token: 0x040000F7 RID: 247
		InvalidImageLeFormat,
		// Token: 0x040000F8 RID: 248
		InvalidImageNotMz,
		// Token: 0x040000F9 RID: 249
		InvalidImageProtect,
		// Token: 0x040000FA RID: 250
		InvalidImageWin16,
		// Token: 0x040000FB RID: 251
		LogonServer,
		// Token: 0x040000FC RID: 252
		DifferenceAtDc,
		// Token: 0x040000FD RID: 253
		SynchronizationRequired,
		// Token: 0x040000FE RID: 254
		DllNotFound,
		// Token: 0x040000FF RID: 255
		IoPrivilegeFailed = 3221225783U,
		// Token: 0x04000100 RID: 256
		OrdinalNotFound,
		// Token: 0x04000101 RID: 257
		EntryPointNotFound,
		// Token: 0x04000102 RID: 258
		ControlCExit,
		// Token: 0x04000103 RID: 259
		PortNotSet = 3221226323U,
		// Token: 0x04000104 RID: 260
		DebuggerInactive,
		// Token: 0x04000105 RID: 261
		CallbackBypass = 3221226755U,
		// Token: 0x04000106 RID: 262
		PortClosed = 3221227264U,
		// Token: 0x04000107 RID: 263
		MessageLost,
		// Token: 0x04000108 RID: 264
		InvalidMessage,
		// Token: 0x04000109 RID: 265
		RequestCanceled,
		// Token: 0x0400010A RID: 266
		RecursiveDispatch,
		// Token: 0x0400010B RID: 267
		LpcReceiveBufferExpected,
		// Token: 0x0400010C RID: 268
		LpcInvalidConnectionUsage,
		// Token: 0x0400010D RID: 269
		LpcRequestsNotAllowed,
		// Token: 0x0400010E RID: 270
		ResourceInUse,
		// Token: 0x0400010F RID: 271
		ProcessIsProtected = 3221227282U,
		// Token: 0x04000110 RID: 272
		VolumeDirty = 3221227526U,
		// Token: 0x04000111 RID: 273
		FileCheckedOut = 3221227777U,
		// Token: 0x04000112 RID: 274
		CheckOutRequired,
		// Token: 0x04000113 RID: 275
		BadFileType,
		// Token: 0x04000114 RID: 276
		FileTooLarge,
		// Token: 0x04000115 RID: 277
		FormsAuthRequired,
		// Token: 0x04000116 RID: 278
		VirusInfected,
		// Token: 0x04000117 RID: 279
		VirusDeleted,
		// Token: 0x04000118 RID: 280
		TransactionalConflict = 3222863873U,
		// Token: 0x04000119 RID: 281
		InvalidTransaction,
		// Token: 0x0400011A RID: 282
		TransactionNotActive,
		// Token: 0x0400011B RID: 283
		TmInitializationFailed,
		// Token: 0x0400011C RID: 284
		RmNotActive,
		// Token: 0x0400011D RID: 285
		RmMetadataCorrupt,
		// Token: 0x0400011E RID: 286
		TransactionNotJoined,
		// Token: 0x0400011F RID: 287
		DirectoryNotRm,
		// Token: 0x04000120 RID: 288
		CouldNotResizeLog,
		// Token: 0x04000121 RID: 289
		TransactionsUnsupportedRemote,
		// Token: 0x04000122 RID: 290
		LogResizeInvalidSize,
		// Token: 0x04000123 RID: 291
		RemoteFileVersionMismatch,
		// Token: 0x04000124 RID: 292
		CrmProtocolAlreadyExists = 3222863887U,
		// Token: 0x04000125 RID: 293
		TransactionPropagationFailed,
		// Token: 0x04000126 RID: 294
		CrmProtocolNotFound,
		// Token: 0x04000127 RID: 295
		TransactionSuperiorExists,
		// Token: 0x04000128 RID: 296
		TransactionRequestNotValid,
		// Token: 0x04000129 RID: 297
		TransactionNotRequested,
		// Token: 0x0400012A RID: 298
		TransactionAlreadyAborted,
		// Token: 0x0400012B RID: 299
		TransactionAlreadyCommitted,
		// Token: 0x0400012C RID: 300
		TransactionInvalidMarshallBuffer,
		// Token: 0x0400012D RID: 301
		CurrentTransactionNotValid,
		// Token: 0x0400012E RID: 302
		LogGrowthFailed,
		// Token: 0x0400012F RID: 303
		ObjectNoLongerExists = 3222863905U,
		// Token: 0x04000130 RID: 304
		StreamMiniversionNotFound,
		// Token: 0x04000131 RID: 305
		StreamMiniversionNotValid,
		// Token: 0x04000132 RID: 306
		MiniversionInaccessibleFromSpecifiedTransaction,
		// Token: 0x04000133 RID: 307
		CantOpenMiniversionWithModifyIntent,
		// Token: 0x04000134 RID: 308
		CantCreateMoreStreamMiniversions,
		// Token: 0x04000135 RID: 309
		HandleNoLongerValid = 3222863912U,
		// Token: 0x04000136 RID: 310
		NoTxfMetadata,
		// Token: 0x04000137 RID: 311
		LogCorruptionDetected = 3222863920U,
		// Token: 0x04000138 RID: 312
		CantRecoverWithHandleOpen,
		// Token: 0x04000139 RID: 313
		RmDisconnected,
		// Token: 0x0400013A RID: 314
		EnlistmentNotSuperior,
		// Token: 0x0400013B RID: 315
		RecoveryNotNeeded,
		// Token: 0x0400013C RID: 316
		RmAlreadyStarted,
		// Token: 0x0400013D RID: 317
		FileIdentityNotPersistent,
		// Token: 0x0400013E RID: 318
		CantBreakTransactionalDependency,
		// Token: 0x0400013F RID: 319
		CantCrossRmBoundary,
		// Token: 0x04000140 RID: 320
		TxfDirNotEmpty,
		// Token: 0x04000141 RID: 321
		IndoubtTransactionsExist,
		// Token: 0x04000142 RID: 322
		TmVolatile,
		// Token: 0x04000143 RID: 323
		RollbackTimerExpired,
		// Token: 0x04000144 RID: 324
		TxfAttributeCorrupt,
		// Token: 0x04000145 RID: 325
		EfsNotAllowedInTransaction,
		// Token: 0x04000146 RID: 326
		TransactionalOpenNotAllowed,
		// Token: 0x04000147 RID: 327
		TransactedMappingUnsupportedRemote,
		// Token: 0x04000148 RID: 328
		TxfMetadataAlreadyPresent,
		// Token: 0x04000149 RID: 329
		TransactionScopeCallbacksNotSet,
		// Token: 0x0400014A RID: 330
		TransactionRequiredPromotion,
		// Token: 0x0400014B RID: 331
		CannotExecuteFileInTransaction,
		// Token: 0x0400014C RID: 332
		TransactionsNotFrozen,
		// Token: 0x0400014D RID: 333
		MaximumNtStatus = 4294967295U
	}
}
