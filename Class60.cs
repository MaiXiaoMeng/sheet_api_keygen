using System;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

namespace sheet_api_keygen
{
	// Token: 0x02000071 RID: 113
	[StandardModule]
	internal sealed class Class60
	{
		// Token: 0x06000263 RID: 611 RVA: 0x00003B84 File Offset: 0x00001D84
		internal static string smethod_0()
		{
			if (Operators.CompareString(Class60.string_0, string.Empty, false) == 0)
			{
				Class60.string_0 = Class245.smethod_11(new Class111().method_2("KhenLaw"), "880VSTO", 16);
			}
			return Class60.string_0;
		}

		// Token: 0x06000264 RID: 612 RVA: 0x00014EB0 File Offset: 0x000130B0
		internal static string smethod_1(string string_1)
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software", true);
			RegistryKey registryKey2 = registryKey.OpenSubKey(Class60.smethod_0(), true);
			if (registryKey2 == null)
			{
				registryKey.CreateSubKey(Class60.smethod_0());
				registryKey2 = registryKey.OpenSubKey(Class60.smethod_0(), true);
			}
			string text;
			try
			{
				text = registryKey2.GetValue(string_1).ToString();
			}
			catch (Exception ex)
			{
				text = "null";
				registryKey2.SetValue(string_1, text.ToString(), RegistryValueKind.String);
			}
			if (Operators.CompareString(text, "null", false) == 0)
			{
				text = string.Empty;
			}
			return text;
		}

		// Token: 0x06000265 RID: 613 RVA: 0x00014F50 File Offset: 0x00013150
		internal static void smethod_2(string string_1, string string_2)
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software", true);
			RegistryKey registryKey2 = registryKey.OpenSubKey(Class60.smethod_0(), true);
			if (registryKey2 == null)
			{
				registryKey.CreateSubKey(Class60.smethod_0());
				registryKey2 = registryKey.OpenSubKey(Class60.smethod_0(), true);
			}
			registryKey2.SetValue(string_1, string_2.ToString(), RegistryValueKind.String);
		}

		// Token: 0x040000ED RID: 237
		private static string string_0;

		// Token: 0x02000072 RID: 114
		internal sealed class Class61
		{
			// Token: 0x06000266 RID: 614 RVA: 0x00003BBD File Offset: 0x00001DBD
			public Class61(object object_1)
			{
				this.object_0 = RuntimeHelpers.GetObjectValue(object_1);
			}

			// Token: 0x06000267 RID: 615 RVA: 0x00003BD1 File Offset: 0x00001DD1
			internal string method_0()
			{
				return Conversions.ToString(Class152.smethod_6(Class60.smethod_1(Class245.smethod_11(Conversions.ToString(this.object_0), "880VSTO", 16))));
			}

			// Token: 0x06000268 RID: 616 RVA: 0x00003BF9 File Offset: 0x00001DF9
			internal void method_1(string string_0)
			{
				Class60.smethod_2(Class245.smethod_11(Conversions.ToString(this.object_0), "880VSTO", 16), Conversions.ToString(Class152.smethod_5(string_0)));
			}

			// Token: 0x040000EE RID: 238
			internal object object_0;
		}
	}
}
