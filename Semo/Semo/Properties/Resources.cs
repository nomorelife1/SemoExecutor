using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Semo_Beta.Properties
{
	// Token: 0x02000009 RID: 9
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
	[DebuggerNonUserCode]
	[CompilerGenerated]
	internal class Resources
	{
		// Token: 0x06000063 RID: 99 RVA: 0x0000587C File Offset: 0x00003A7C
		internal Resources()
		{
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000064 RID: 100 RVA: 0x00005888 File Offset: 0x00003A88
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				bool flag = Resources.resourceMan == null;
				if (flag)
				{
					ResourceManager temp = new ResourceManager("Semo_Beta.Properties.Resources", typeof(Resources).Assembly);
					Resources.resourceMan = temp;
				}
				return Resources.resourceMan;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000065 RID: 101 RVA: 0x000058D0 File Offset: 0x00003AD0
		// (set) Token: 0x06000066 RID: 102 RVA: 0x000058E7 File Offset: 0x00003AE7
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

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000067 RID: 103 RVA: 0x000058F0 File Offset: 0x00003AF0
		internal static Bitmap _286_2863985_worker_clear_button_icon_hd_png_download
		{
			get
			{
				object obj = Resources.ResourceManager.GetObject("286-2863985_worker-clear-button-icon-hd-png-download", Resources.resourceCulture);
				return (Bitmap)obj;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000068 RID: 104 RVA: 0x00005920 File Offset: 0x00003B20
		internal static Bitmap delete_512
		{
			get
			{
				object obj = Resources.ResourceManager.GetObject("delete-512", Resources.resourceCulture);
				return (Bitmap)obj;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000069 RID: 105 RVA: 0x00005950 File Offset: 0x00003B50
		internal static Bitmap Eraser_icon
		{
			get
			{
				object obj = Resources.ResourceManager.GetObject("Eraser-icon", Resources.resourceCulture);
				return (Bitmap)obj;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600006A RID: 106 RVA: 0x00005980 File Offset: 0x00003B80
		internal static Bitmap Play_512
		{
			get
			{
				object obj = Resources.ResourceManager.GetObject("Play-512", Resources.resourceCulture);
				return (Bitmap)obj;
			}
		}

		// Token: 0x04000032 RID: 50
		private static ResourceManager resourceMan;

		// Token: 0x04000033 RID: 51
		private static CultureInfo resourceCulture;
	}
}
