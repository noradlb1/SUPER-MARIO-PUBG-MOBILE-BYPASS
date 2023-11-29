using System;
using System.Runtime.InteropServices;

namespace AntiCrack_DotNet
{
	// Token: 0x02000042 RID: 66
	internal class Structs
	{
		// Token: 0x02000043 RID: 67
		public struct CONTEXT
		{
			// Token: 0x040003CB RID: 971
			public uint P1Home;

			// Token: 0x040003CC RID: 972
			public uint P2Home;

			// Token: 0x040003CD RID: 973
			public uint P3Home;

			// Token: 0x040003CE RID: 974
			public uint P4Home;

			// Token: 0x040003CF RID: 975
			public uint P5Home;

			// Token: 0x040003D0 RID: 976
			public uint P6Home;

			// Token: 0x040003D1 RID: 977
			public long ContextFlags;

			// Token: 0x040003D2 RID: 978
			public uint Dr0;

			// Token: 0x040003D3 RID: 979
			public uint Dr1;

			// Token: 0x040003D4 RID: 980
			public uint Dr2;

			// Token: 0x040003D5 RID: 981
			public uint Dr3;

			// Token: 0x040003D6 RID: 982
			public uint Dr4;

			// Token: 0x040003D7 RID: 983
			public uint Dr5;

			// Token: 0x040003D8 RID: 984
			public uint Dr6;

			// Token: 0x040003D9 RID: 985
			public uint Dr7;
		}

		// Token: 0x02000044 RID: 68
		public struct PROCESS_MITIGATION_BINARY_SIGNATURE_POLICY
		{
			// Token: 0x040003DA RID: 986
			public uint MicrosoftSignedOnly;
		}

		// Token: 0x02000045 RID: 69
		[StructLayout(LayoutKind.Explicit)]
		public struct SYSTEM_CODEINTEGRITY_INFORMATION
		{
			// Token: 0x040003DB RID: 987
			[FieldOffset(0)]
			public ulong Length;

			// Token: 0x040003DC RID: 988
			[FieldOffset(4)]
			public uint CodeIntegrityOptions;
		}

		// Token: 0x02000046 RID: 70
		public struct PROCESS_BASIC_INFORMATION
		{
			// Token: 0x040003DD RID: 989
			internal IntPtr Reserved1;

			// Token: 0x040003DE RID: 990
			internal IntPtr PebBaseAddress;

			// Token: 0x040003DF RID: 991
			internal IntPtr Reserved2_0;

			// Token: 0x040003E0 RID: 992
			internal IntPtr Reserved2_1;

			// Token: 0x040003E1 RID: 993
			internal IntPtr UniqueProcessId;

			// Token: 0x040003E2 RID: 994
			internal IntPtr InheritedFromUniqueProcessId;
		}

		// Token: 0x02000047 RID: 71
		public struct SYSTEM_KERNEL_DEBUGGER_INFORMATION
		{
			// Token: 0x040003E3 RID: 995
			[MarshalAs(UnmanagedType.U1)]
			public bool KernelDebuggerEnabled;

			// Token: 0x040003E4 RID: 996
			[MarshalAs(UnmanagedType.U1)]
			public bool KernelDebuggerNotPresent;
		}

		// Token: 0x02000048 RID: 72
		public struct UNICODE_STRING
		{
			// Token: 0x040003E5 RID: 997
			public ushort Length;

			// Token: 0x040003E6 RID: 998
			public ushort MaximumLength;

			// Token: 0x040003E7 RID: 999
			public IntPtr Buffer;
		}

		// Token: 0x02000049 RID: 73
		public struct ANSI_STRING
		{
			// Token: 0x040003E8 RID: 1000
			public short Length;

			// Token: 0x040003E9 RID: 1001
			public short MaximumLength;

			// Token: 0x040003EA RID: 1002
			public string Buffer;
		}
	}
}
