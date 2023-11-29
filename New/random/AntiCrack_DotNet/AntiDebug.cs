using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace AntiCrack_DotNet
{
	// Token: 0x02000041 RID: 65
	internal class AntiDebug
	{
		// Token: 0x060001D5 RID: 469
		[DllImport("kernel32.dll", SetLastError = true)]
		private static extern bool SetHandleInformation(IntPtr hObject, uint dwMask, uint dwFlags);

		// Token: 0x060001D6 RID: 470
		[DllImport("ntdll.dll", SetLastError = true)]
		private static extern bool NtClose(IntPtr Handle);

		// Token: 0x060001D7 RID: 471
		[DllImport("kernel32.dll", SetLastError = true)]
		private static extern IntPtr CreateMutexA(IntPtr lpMutexAttributes, bool bInitialOwner, string lpName);

		// Token: 0x060001D8 RID: 472
		[DllImport("kernel32.dll", SetLastError = true)]
		private static extern bool IsDebuggerPresent();

		// Token: 0x060001D9 RID: 473
		[DllImport("kernel32.dll", SetLastError = true)]
		private static extern bool CheckRemoteDebuggerPresent(IntPtr Handle, ref bool CheckBool);

		// Token: 0x060001DA RID: 474
		[DllImport("kernel32.dll", SetLastError = true)]
		private static extern IntPtr GetModuleHandle(string lib);

		// Token: 0x060001DB RID: 475
		[DllImport("kernel32.dll", SetLastError = true)]
		private static extern IntPtr GetProcAddress(IntPtr ModuleHandle, string Function);

		// Token: 0x060001DC RID: 476
		[DllImport("kernel32.dll", SetLastError = true)]
		private static extern bool WriteProcessMemory(SafeHandle ProcHandle, IntPtr BaseAddress, byte[] Buffer, uint size, int NumOfBytes);

		// Token: 0x060001DD RID: 477
		[DllImport("ntdll.dll", SetLastError = true)]
		private static extern uint NtSetInformationThread(IntPtr ThreadHandle, uint ThreadInformationClass, IntPtr ThreadInformation, int ThreadInformationLength);

		// Token: 0x060001DE RID: 478
		[DllImport("kernel32.dll", SetLastError = true)]
		private static extern IntPtr OpenThread(uint DesiredAccess, bool InheritHandle, int ThreadId);

		// Token: 0x060001DF RID: 479
		[DllImport("kernel32.dll", SetLastError = true)]
		private static extern uint GetTickCount();

		// Token: 0x060001E0 RID: 480
		[DllImport("kernel32.dll", SetLastError = true)]
		private static extern void OutputDebugStringA(string Text);

		// Token: 0x060001E1 RID: 481
		[DllImport("kernel32.dll", SetLastError = true)]
		private static extern IntPtr GetCurrentThread();

		// Token: 0x060001E2 RID: 482
		[DllImport("kernel32.dll", SetLastError = true)]
		private static extern bool GetThreadContext(IntPtr hThread, ref Structs.CONTEXT Context);

		// Token: 0x060001E3 RID: 483
		[DllImport("ntdll.dll", SetLastError = true)]
		private static extern uint NtQueryInformationProcess(SafeHandle hProcess, uint ProcessInfoClass, out uint ProcessInfo, uint nSize, uint ReturnLength);

		// Token: 0x060001E4 RID: 484
		[DllImport("ntdll.dll", SetLastError = true)]
		private static extern uint NtQueryInformationProcess(SafeHandle hProcess, uint ProcessInfoClass, out IntPtr ProcessInfo, uint nSize, uint ReturnLength);

		// Token: 0x060001E5 RID: 485
		[DllImport("ntdll.dll", SetLastError = true)]
		private static extern uint NtQueryInformationProcess(SafeHandle hProcess, uint ProcessInfoClass, ref Structs.PROCESS_BASIC_INFORMATION ProcessInfo, uint nSize, uint ReturnLength);

		// Token: 0x060001E6 RID: 486
		[DllImport("kernel32.dll", SetLastError = true)]
		private static extern int QueryFullProcessImageNameA(SafeHandle hProcess, uint Flags, byte[] lpExeName, int[] lpdwSize);

		// Token: 0x060001E7 RID: 487
		[DllImport("user32.dll", SetLastError = true)]
		private static extern IntPtr GetForegroundWindow();

		// Token: 0x060001E8 RID: 488
		[DllImport("user32.dll", SetLastError = true)]
		private static extern int GetWindowTextLengthA(IntPtr HWND);

		// Token: 0x060001E9 RID: 489
		[DllImport("user32.dll", SetLastError = true)]
		private static extern int GetWindowTextA(IntPtr HWND, StringBuilder WindowText, int nMaxCount);

		// Token: 0x060001EA RID: 490 RVA: 0x000109C8 File Offset: 0x0000EBC8
		public static bool NtCloseAntiDebug_InvalidHandle()
		{
			bool result;
			try
			{
				AntiDebug.NtClose((IntPtr)19075618L);
				result = false;
			}
			catch
			{
				result = true;
			}
			return result;
		}

		// Token: 0x060001EB RID: 491 RVA: 0x00010A04 File Offset: 0x0000EC04
		public static bool NtCloseAntiDebug_ProtectedHandle()
		{
			IntPtr intPtr = AntiDebug.CreateMutexA(IntPtr.Zero, false, new Random().Next(0, 9999999).ToString());
			AntiDebug.SetHandleInformation(intPtr, 2U, 2U);
			bool result;
			try
			{
				AntiDebug.NtClose(intPtr);
				result = false;
			}
			catch
			{
				result = true;
			}
			return result;
		}

		// Token: 0x060001EC RID: 492 RVA: 0x00002CD3 File Offset: 0x00000ED3
		public static bool DebuggerIsAttached()
		{
			return Debugger.IsAttached;
		}

		// Token: 0x060001ED RID: 493 RVA: 0x00002CDA File Offset: 0x00000EDA
		public static bool IsDebuggerPresentCheck()
		{
			return AntiDebug.IsDebuggerPresent();
		}

		// Token: 0x060001EE RID: 494 RVA: 0x00010A60 File Offset: 0x0000EC60
		public static bool NtQueryInformationProcessCheck_ProcessDebugFlags()
		{
			uint num = 0U;
			AntiDebug.NtQueryInformationProcess(Process.GetCurrentProcess().SafeHandle, 31U, out num, 4U, 0U);
			return num == 0U;
		}

		// Token: 0x060001EF RID: 495 RVA: 0x00010A8C File Offset: 0x0000EC8C
		public static bool NtQueryInformationProcessCheck_ProcessDebugPort()
		{
			uint result = 0U;
			uint nSize = 4U;
			if (Environment.Is64BitProcess)
			{
				nSize = 8U;
			}
			AntiDebug.NtQueryInformationProcess(Process.GetCurrentProcess().SafeHandle, 7U, out result, nSize, 0U);
			return result != 0U;
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x00010AC4 File Offset: 0x0000ECC4
		public static bool NtQueryInformationProcessCheck_ProcessDebugObjectHandle()
		{
			IntPtr zero = IntPtr.Zero;
			uint nSize = 4U;
			if (Environment.Is64BitProcess)
			{
				nSize = 8U;
			}
			AntiDebug.NtQueryInformationProcess(Process.GetCurrentProcess().SafeHandle, 30U, out zero, nSize, 0U);
			return zero != IntPtr.Zero;
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x00010B08 File Offset: 0x0000ED08
		public static string AntiDebugAttach()
		{
			IntPtr moduleHandle = AntiDebug.GetModuleHandle("ntdll.dll");
			IntPtr procAddress = AntiDebug.GetProcAddress(moduleHandle, "DbgUiRemoteBreakin");
			IntPtr procAddress2 = AntiDebug.GetProcAddress(moduleHandle, "DbgBreakPoint");
			byte[] buffer = new byte[]
			{
				204
			};
			byte[] buffer2 = new byte[]
			{
				195
			};
			if (AntiDebug.WriteProcessMemory(Process.GetCurrentProcess().SafeHandle, procAddress, buffer, 1U, 0) & AntiDebug.WriteProcessMemory(Process.GetCurrentProcess().SafeHandle, procAddress2, buffer2, 1U, 0))
			{
				return "Success";
			}
			return "Failed";
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x00010B88 File Offset: 0x0000ED88
		public static bool FindWindowAntiDebug()
		{
			foreach (Process process in Process.GetProcesses())
			{
				foreach (string value in new string[]
				{
					"x32dbg",
					"x64dbg",
					"windbg",
					"ollydbg",
					"dnspy",
					"immunity debugger",
					"hyperdbg",
					"cheat engine",
					"cheatengine",
					"ida"
				})
				{
					if (process.MainWindowTitle.ToLower().Contains(value))
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x00010C3C File Offset: 0x0000EE3C
		public static bool GetForegroundWindowAntiDebug()
		{
			string[] array = new string[]
			{
				"x32dbg",
				"x64dbg",
				"windbg",
				"ollydbg",
				"dnspy",
				"immunity debugger",
				"hyperdbg",
				"debug",
				"debugger",
				"cheat engine",
				"cheatengine",
				"ida"
			};
			IntPtr foregroundWindow = AntiDebug.GetForegroundWindow();
			int windowTextLengthA = AntiDebug.GetWindowTextLengthA(foregroundWindow);
			if (windowTextLengthA != 0)
			{
				StringBuilder stringBuilder = new StringBuilder(windowTextLengthA + 1);
				AntiDebug.GetWindowTextA(foregroundWindow, stringBuilder, windowTextLengthA + 1);
				foreach (string value in array)
				{
					if (stringBuilder.ToString().ToLower().Contains(value))
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x00010D10 File Offset: 0x0000EF10
		public static string HideThreadsAntiDebug()
		{
			string result;
			try
			{
				bool flag = false;
				foreach (object obj in Process.GetCurrentProcess().Threads)
				{
					ProcessThread processThread = (ProcessThread)obj;
					IntPtr intPtr = AntiDebug.OpenThread(32U, false, processThread.Id);
					if (intPtr != IntPtr.Zero)
					{
						bool flag2 = AntiDebug.NtSetInformationThread(intPtr, 17U, IntPtr.Zero, 0) != 0U;
						AntiDebug.NtClose(intPtr);
						if (flag2)
						{
							flag = true;
						}
					}
				}
				if (!flag)
				{
					result = "Success";
				}
				else
				{
					result = "Failed";
				}
			}
			catch
			{
				result = "Failed";
			}
			return result;
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x00010DD0 File Offset: 0x0000EFD0
		public static bool GetTickCountAntiDebug()
		{
			uint tickCount = AntiDebug.GetTickCount();
			return AntiDebug.GetTickCount() - tickCount > 16U;
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x00002CE6 File Offset: 0x00000EE6
		public static bool OutputDebugStringAntiDebug()
		{
			AntiDebug.OutputDebugStringA("just testing some stuff...");
			return Marshal.GetLastWin32Error() == 0;
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x00002CFC File Offset: 0x00000EFC
		public static void OllyDbgFormatStringExploit()
		{
			AntiDebug.OutputDebugStringA("%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s");
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x00010DF0 File Offset: 0x0000EFF0
		public static bool DebugBreakAntiDebug()
		{
			bool result;
			try
			{
				Debugger.Break();
				result = false;
			}
			catch
			{
				result = true;
			}
			return result;
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x00010E1C File Offset: 0x0000F01C
		public static bool HardwareRegistersBreakpointsDetection()
		{
			Structs.CONTEXT context = default(Structs.CONTEXT);
			context.ContextFlags = AntiDebug.CONTEXT_DEBUG_REGISTERS;
			return AntiDebug.GetThreadContext(AntiDebug.GetCurrentThread(), ref context) && (context.Dr1 != 0U || context.Dr2 != 0U || context.Dr3 != 0U || context.Dr4 != 0U || context.Dr5 != 0U || context.Dr6 != 0U || context.Dr7 != 0U);
		}

		// Token: 0x060001FA RID: 506 RVA: 0x00010E88 File Offset: 0x0000F088
		private static string CleanPath(string Path)
		{
			string text = null;
			foreach (char c in Path)
			{
				if (c != '\0')
				{
					text += c.ToString();
				}
			}
			return text;
		}

		// Token: 0x060001FB RID: 507 RVA: 0x00010EC4 File Offset: 0x0000F0C4
		public static bool ParentProcessAntiDebug()
		{
			try
			{
				Structs.PROCESS_BASIC_INFORMATION process_BASIC_INFORMATION = default(Structs.PROCESS_BASIC_INFORMATION);
				if (AntiDebug.NtQueryInformationProcess(Process.GetCurrentProcess().SafeHandle, 0U, ref process_BASIC_INFORMATION, (uint)Marshal.SizeOf(typeof(Structs.PROCESS_BASIC_INFORMATION)), 0U) == 0U)
				{
					int num = process_BASIC_INFORMATION.InheritedFromUniqueProcessId.ToInt32();
					if (num != 0)
					{
						byte[] array = new byte[256];
						int[] array2 = new int[256];
						array2[0] = 256;
						AntiDebug.QueryFullProcessImageNameA(Process.GetProcessById(num).SafeHandle, 0U, array, array2);
						string fileName = Path.GetFileName(AntiDebug.CleanPath(Encoding.UTF8.GetString(array)));
						foreach (string value in new string[]
						{
							"explorer.exe",
							"cmd.exe"
						})
						{
							if (fileName.Equals(value))
							{
								return false;
							}
						}
						return true;
					}
				}
			}
			catch
			{
			}
			return false;
		}

		// Token: 0x040003CA RID: 970
		private static long CONTEXT_DEBUG_REGISTERS = 65552L;
	}
}
