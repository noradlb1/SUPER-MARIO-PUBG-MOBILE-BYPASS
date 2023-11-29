using System;

namespace numer
{
	// Token: 0x02000036 RID: 54
	public class Information
	{
		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000197 RID: 407 RVA: 0x00002A96 File Offset: 0x00000C96
		// (set) Token: 0x06000198 RID: 408 RVA: 0x00002A9E File Offset: 0x00000C9E
		public string Language
		{
			get
			{
				return this.language;
			}
			set
			{
				this.language = value;
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06000199 RID: 409 RVA: 0x00002AA7 File Offset: 0x00000CA7
		// (set) Token: 0x0600019A RID: 410 RVA: 0x00002AAF File Offset: 0x00000CAF
		public string GameV
		{
			get
			{
				return this.Game;
			}
			set
			{
				this.Game = value;
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x0600019B RID: 411 RVA: 0x00002AB8 File Offset: 0x00000CB8
		// (set) Token: 0x0600019C RID: 412 RVA: 0x00002AC0 File Offset: 0x00000CC0
		public bool AntiStream
		{
			get
			{
				return this.antiStream;
			}
			set
			{
				this.antiStream = value;
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x0600019D RID: 413 RVA: 0x00002AC9 File Offset: 0x00000CC9
		// (set) Token: 0x0600019E RID: 414 RVA: 0x00002AD1 File Offset: 0x00000CD1
		public bool HACKINTERNAL
		{
			get
			{
				return this.hackIntenal;
			}
			set
			{
				this.hackIntenal = value;
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x0600019F RID: 415 RVA: 0x00002ADA File Offset: 0x00000CDA
		// (set) Token: 0x060001A0 RID: 416 RVA: 0x00002AE2 File Offset: 0x00000CE2
		public bool IPAD
		{
			get
			{
				return this.ipad;
			}
			set
			{
				this.ipad = value;
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060001A1 RID: 417 RVA: 0x00002AEB File Offset: 0x00000CEB
		// (set) Token: 0x060001A2 RID: 418 RVA: 0x00002AF3 File Offset: 0x00000CF3
		public bool FPS
		{
			get
			{
				return this.fPS;
			}
			set
			{
				this.fPS = value;
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060001A3 RID: 419 RVA: 0x00002AFC File Offset: 0x00000CFC
		// (set) Token: 0x060001A4 RID: 420 RVA: 0x00002B04 File Offset: 0x00000D04
		public bool UHD
		{
			get
			{
				return this.uHD;
			}
			set
			{
				this.uHD = value;
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060001A5 RID: 421 RVA: 0x00002B0D File Offset: 0x00000D0D
		// (set) Token: 0x060001A6 RID: 422 RVA: 0x00002B15 File Offset: 0x00000D15
		public bool NIGHT
		{
			get
			{
				return this.nIGHT;
			}
			set
			{
				this.nIGHT = value;
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060001A7 RID: 423 RVA: 0x00002B1E File Offset: 0x00000D1E
		// (set) Token: 0x060001A8 RID: 424 RVA: 0x00002B26 File Offset: 0x00000D26
		public bool CROSS
		{
			get
			{
				return this.cROSS;
			}
			set
			{
				this.cROSS = value;
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060001A9 RID: 425 RVA: 0x00002B2F File Offset: 0x00000D2F
		// (set) Token: 0x060001AA RID: 426 RVA: 0x00002B37 File Offset: 0x00000D37
		public bool FixPing
		{
			get
			{
				return this.fixPing;
			}
			set
			{
				this.fixPing = value;
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060001AB RID: 427 RVA: 0x00002B40 File Offset: 0x00000D40
		// (set) Token: 0x060001AC RID: 428 RVA: 0x00002B48 File Offset: 0x00000D48
		public bool X_Effect
		{
			get
			{
				return this.x_Effect;
			}
			set
			{
				this.x_Effect = value;
			}
		}

		// Token: 0x040003A7 RID: 935
		private string language;

		// Token: 0x040003A8 RID: 936
		private string Game;

		// Token: 0x040003A9 RID: 937
		private bool antiStream;

		// Token: 0x040003AA RID: 938
		private bool ipad;

		// Token: 0x040003AB RID: 939
		private bool fPS;

		// Token: 0x040003AC RID: 940
		private bool uHD;

		// Token: 0x040003AD RID: 941
		private bool nIGHT;

		// Token: 0x040003AE RID: 942
		private bool cROSS;

		// Token: 0x040003AF RID: 943
		private bool fixPing;

		// Token: 0x040003B0 RID: 944
		private bool x_Effect;

		// Token: 0x040003B1 RID: 945
		private bool hackIntenal;
	}
}
