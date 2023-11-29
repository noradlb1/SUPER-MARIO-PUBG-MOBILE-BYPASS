using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace BYPASS
{
	// Token: 0x02000054 RID: 84
	public class cf4b7fa8f8c1aa3a
	{
		// Token: 0x06000208 RID: 520
		[DllImport("C:\\Windows\\Temp\\d3d9.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern int safeexit();

		// Token: 0x06000209 RID: 521
		[DllImport("C:\\Windows\\Temp\\d3d9.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern int guest1();

		// Token: 0x0600020A RID: 522
		[DllImport("C:\\Windows\\Temp\\d3d9.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern int check11();

		// Token: 0x0600020B RID: 523
		[DllImport("C:\\Windows\\Temp\\d3d9.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern int cheat();

		// Token: 0x0600020C RID: 524
		[DllImport("C:\\Windows\\Temp\\d3d9.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern int khaledmallll();

		// Token: 0x0600020D RID: 525
		[DllImport("C:\\Windows\\Temp\\d3d9.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern int batri();

		// Token: 0x0600020E RID: 526
		[DllImport("C:\\Windows\\Temp\\d3d9.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern int PatchGameloopAntiCheat();

		// Token: 0x0600020F RID: 527
		[DllImport("C:\\Windows\\Temp\\d3d9.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern int check();

		// Token: 0x06000210 RID: 528
		[DllImport("C:\\Windows\\Temp\\d3d9.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern int HWID();

		// Token: 0x06000211 RID: 529
		[DllImport("C:\\Windows\\Temp\\d3d9.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern int test(bool ipad, bool fps, bool uhd, bool night, bool SSS, bool ping, bool xx, int chack = 0);

		// Token: 0x06000212 RID: 530
		[DllImport("C:\\Windows\\Temp\\d3d9.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern int kr(bool ipad, bool fps, bool uhd, bool night, bool SSS, bool ping, bool xx, int chack = 0);

		// Token: 0x06000213 RID: 531
		[DllImport("C:\\Windows\\Temp\\d3d9.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern int emu12();

		// Token: 0x06000214 RID: 532
		[DllImport("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

		// Token: 0x06000215 RID: 533
		[DllImport("user32.dll")]
		public static extern bool ReleaseCapture();

		// Token: 0x06000216 RID: 534
		[DllImport("kernel32", SetLastError = true)]
		private static extern bool FreeLibrary(IntPtr hModule);

		// Token: 0x06000217 RID: 535 RVA: 0x00011528 File Offset: 0x0000F728
		public static void UnloadModule(string moduleName)
		{
			foreach (object obj in Process.GetCurrentProcess().Modules)
			{
				ProcessModule processModule = (ProcessModule)obj;
				if (processModule.ModuleName == moduleName)
				{
					cf4b7fa8f8c1aa3a.FreeLibrary(processModule.BaseAddress);
				}
			}
		}

		// Token: 0x06000218 RID: 536 RVA: 0x000063F8 File Offset: 0x000045F8
		public void dos(string command)
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				FileName = "cmd.exe",
				Arguments = " /C " + command,
				WindowStyle = ProcessWindowStyle.Hidden,
				UseShellExecute = false,
				CreateNoWindow = true,
				RedirectStandardError = false,
				RedirectStandardOutput = false
			};
			process.Start();
			process.WaitForExit(5000);
		}

		// Token: 0x06000219 RID: 537
		[DllImport("Gdi32.dll")]
		private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

		// Token: 0x0600021A RID: 538
		[DllImport("user32.dll")]
		public static extern uint SetWindowDisplayAffinity(IntPtr hwnd, uint dwAffinity);

		// Token: 0x04000652 RID: 1618
		public const string version = "";

		// Token: 0x04000653 RID: 1619
		public const string khaled477 = "";

		// Token: 0x04000654 RID: 1620
		public const string lib = "https://hydroelectric-conso.000webhostapp.com/libmohmed.so";

		// Token: 0x04000655 RID: 1621
		public const string libanti = "https://hydroelectric-conso.000webhostapp.com/antiban.so";

		// Token: 0x04000656 RID: 1622
		public const string cf4b7fa8f8c1aa3a2 = "https://hydroelectric-conso.000webhostapp.com/d3d9.dll";

		// Token: 0x04000657 RID: 1623
		public const string cf4b7fa8f8c1aa3a2kha = "";

		// Token: 0x04000658 RID: 1624
		public const string Project5 = "C:\\Windows\\Temp\\d3d9.dll";

		// Token: 0x04000659 RID: 1625
		public const string Proje1 = "C:\\Windows\\Temp\\hax.exe";

		// Token: 0x0400065A RID: 1626
		public const string lib1 = "C:\\Windows\\Temp\\1.data";

		// Token: 0x0400065B RID: 1627
		public const string lib12 = "C:\\Windows\\Temp\\2.data";

		// Token: 0x0400065C RID: 1628
		public const int WM_NCLBUTTONDOWN = 161;

		// Token: 0x0400065D RID: 1629
		public const int HT_CAPTION = 2;

		// Token: 0x02000055 RID: 85
		public class NativeMethods
		{
			// Token: 0x0600021C RID: 540
			[DllImport("user32.dll")]
			[return: MarshalAs(UnmanagedType.Bool)]
			public static extern bool BlockInput([MarshalAs(UnmanagedType.Bool)] bool fBlockIt);
		}
	}
}
