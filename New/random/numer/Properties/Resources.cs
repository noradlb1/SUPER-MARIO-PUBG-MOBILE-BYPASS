using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace numer.Properties
{
	// Token: 0x0200003F RID: 63
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
	[DebuggerNonUserCode]
	[CompilerGenerated]
	internal class Resources
	{
		// Token: 0x060001CD RID: 461 RVA: 0x00002060 File Offset: 0x00000260
		internal Resources()
		{
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060001CE RID: 462 RVA: 0x00002C58 File Offset: 0x00000E58
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				if (Resources.resourceMan == null)
				{
					Resources.resourceMan = new ResourceManager("numer.Properties.Resources", typeof(Resources).Assembly);
				}
				return Resources.resourceMan;
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060001CF RID: 463 RVA: 0x00002C84 File Offset: 0x00000E84
		// (set) Token: 0x060001D0 RID: 464 RVA: 0x00002C8B File Offset: 0x00000E8B
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return Resources.resourceCulture;
			}
			set
			{
				Resources.resourceCulture = value;
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060001D1 RID: 465 RVA: 0x00002C93 File Offset: 0x00000E93
		internal static byte[] sound
		{
			get
			{
				return (byte[])Resources.ResourceManager.GetObject("sound", Resources.resourceCulture);
			}
		}

		// Token: 0x040003C7 RID: 967
		private static ResourceManager resourceMan;

		// Token: 0x040003C8 RID: 968
		private static CultureInfo resourceCulture;
	}
}
