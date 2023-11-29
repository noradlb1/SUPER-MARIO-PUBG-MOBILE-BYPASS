using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace numer.Properties
{
	// Token: 0x02000040 RID: 64
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.5.0.0")]
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060001D2 RID: 466 RVA: 0x00002CAE File Offset: 0x00000EAE
		public static Settings Default
		{
			get
			{
				return Settings.defaultInstance;
			}
		}

		// Token: 0x040003C9 RID: 969
		private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());
	}
}
