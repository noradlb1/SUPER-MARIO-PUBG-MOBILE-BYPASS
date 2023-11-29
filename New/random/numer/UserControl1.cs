using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace numer
{
	// Token: 0x0200003E RID: 62
	public class UserControl1 : UserControl
	{
		// Token: 0x060001CA RID: 458 RVA: 0x00002C17 File Offset: 0x00000E17
		public UserControl1()
		{
			this.InitializeComponent();
		}

		// Token: 0x060001CB RID: 459 RVA: 0x00002C25 File Offset: 0x00000E25
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060001CC RID: 460 RVA: 0x00002C44 File Offset: 0x00000E44
		private void InitializeComponent()
		{
			this.components = new Container();
			base.AutoScaleMode = AutoScaleMode.Font;
		}

		// Token: 0x040003C6 RID: 966
		private IContainer components;
	}
}
