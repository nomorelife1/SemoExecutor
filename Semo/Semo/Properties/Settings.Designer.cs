using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Semo_Beta.Properties
{
	// Token: 0x0200000A RID: 10
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.10.0.0")]
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600006B RID: 107 RVA: 0x000059B0 File Offset: 0x00003BB0
		public static Settings Default
		{
			get
			{
				return Settings.defaultInstance;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600006C RID: 108 RVA: 0x000059C8 File Offset: 0x00003BC8
		// (set) Token: 0x0600006D RID: 109 RVA: 0x000059EA File Offset: 0x00003BEA
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool CheckBox1State
		{
			get
			{
				return (bool)this["CheckBox1State"];
			}
			set
			{
				this["CheckBox1State"] = value;
			}
		}

		// Token: 0x04000034 RID: 52
		private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());
	}
}
