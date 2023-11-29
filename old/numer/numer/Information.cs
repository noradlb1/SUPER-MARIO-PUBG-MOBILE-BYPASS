using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numer
{
    public class Information
    {
        private string language;
        private string Game;
        private bool antiStream;
        private bool ipad;
        private bool fPS;
        private bool uHD;
        private bool nIGHT;
        private bool cROSS;
        private bool fixPing;
        private bool x_Effect;
        private bool hackIntenal;


        public string Language
        {
            get { return language; }
            set { language = value; }
        }
        public string GameV
        {
            get { return Game; }
            set { Game = value; }
        }

        public bool AntiStream
        {
            get { return antiStream; }
            set { antiStream = value; }
        }
        public bool HACKINTERNAL
        {
            get { return hackIntenal; }
            set { hackIntenal = value; }
        }

        public bool IPAD
        {
            get { return ipad; }
            set { ipad = value; }
        }


        public bool FPS
        {
            get { return fPS; }
            set { fPS = value; }
        }

        public bool UHD
        {
            get { return uHD; }
            set { uHD = value; }
        }

        public bool NIGHT
        {
            get { return nIGHT; }
            set { nIGHT = value; }
        }

        public bool CROSS
        {
            get { return cROSS; }
            set { cROSS = value; }
        }

        public bool FixPing
        {
            get { return fixPing; }
            set { fixPing = value; }
        }

        public bool X_Effect
        {
            get { return x_Effect; }
            set { x_Effect = value; }
        }

    }
}
