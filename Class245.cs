using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace sheet_api_keygen
{
	// Token: 0x0200014B RID: 331
	[StandardModule]
	internal sealed class Class245
	{
		// Token: 0x060007EE RID: 2030 RVA: 0x0004E280 File Offset: 0x0004C480
		internal static bool smethod_0()
		{
			if (!Class245.smethod_8())
			{
				double num = Conversion.Val(Class245.class61_1.method_0());
				if (num > 3.0)
				{
					Interaction.MsgBox("非常抱歉,您的VIP功能试用次数已达上限,如需继续使用请激活VIP!", MsgBoxStyle.OkOnly, null);
					Class245.smethod_5();
					return true;
				}
				Class245.class61_1.method_1((num + 1.0).ToString());
			}
			return false;
		}

		// Token: 0x060007EF RID: 2031 RVA: 0x0004E2E8 File Offset: 0x0004C4E8
		internal static void smethod_1()
		{
			string text = new Class111().method_2("KhenLaw");
			string text2 = Class245.class61_0.method_0();
			if (Operators.CompareString(text2, string.Empty, false) == 0)
			{
				text2 = string.Format("{0};{1};{2}", text, "免费版", Conversions.ToDate("2999-1-1"));
				Class245.class61_0.method_1(Conversions.ToString(Class152.smethod_5(text2)));
			}
			Class245.smethod_3(text2, text);
		}

		// Token: 0x060007F0 RID: 2032 RVA: 0x0004E35C File Offset: 0x0004C55C
		internal static void smethod_2(object object_0)
		{
			string string_ = new Class111().method_2("KhenLaw");
			Console.WriteLine(string_);
			Class245.smethod_3(Conversions.ToString(object_0), string_);
		}

		// Token: 0x060007F1 RID: 2033 RVA: 0x000064AE File Offset: 0x000046AE
		internal static void smethod_3(string string_0, string string_1)
		{
			Class245.class246_0 = new Class245.Class246(string_0, string_1);
		}

		// Token: 0x060007F2 RID: 2034 RVA: 0x000064BC File Offset: 0x000046BC
		internal static object smethod_4(string string_0)
		{
			return Class152.smethod_6(string_0);
		}

		// Token: 0x060007F3 RID: 2035 RVA: 0x000064C4 File Offset: 0x000046C4
		internal static void smethod_5()
		{
		}

		// Token: 0x060007F4 RID: 2036 RVA: 0x0004E388 File Offset: 0x0004C588
		internal static bool smethod_6()
		{
			return Operators.CompareString(Class245.class246_0.string_1, "免费", false) == 0;
		}

		// Token: 0x060007F5 RID: 2037 RVA: 0x0004E3B4 File Offset: 0x0004C5B4
		internal static bool smethod_7()
		{
			bool result;
			if (Operators.CompareString(Class245.class246_0.string_1, "VIP", false) == 0)
			{
				if (DateTime.Compare(Class245.class246_0.dateTime_0, Class245.smethod_9()) >= 0)
				{
					result = true;
				}
				else
				{
					Interaction.MsgBox("VI授权已过期,请重新激活!", MsgBoxStyle.OkOnly, null);
					result = false;
				}
			}
			else
			{
				Interaction.MsgBox("本功能需开通VIP才可使用!", MsgBoxStyle.OkOnly, null);
				result = false;
			}
			return result;
		}

		// Token: 0x060007F6 RID: 2038 RVA: 0x0004E414 File Offset: 0x0004C614
		internal static bool smethod_8()
		{
			return Operators.CompareString(Class245.class246_0.string_1, "VIP", false) == 0 && DateTime.Compare(Class245.class246_0.dateTime_0, Class245.smethod_9()) >= 0;
		}

		// Token: 0x060007F7 RID: 2039 RVA: 0x0004E45C File Offset: 0x0004C65C
		private static DateTime smethod_9()
		{
			string tempPath = Path.GetTempPath();
			DateTime dateTime = DateTime.MinValue;
			//FileInfo fileInfo = new DirectoryInfo(tempPath).GetFiles().OrderBy((Class245.Class247.func_0 == null) ? (Class245.Class247.func_0 = new Func<FileInfo, DateTime>(Class245.Class247.class247_0._Lambda$__14-0)) : Class245.Class247.func_0).Last<FileInfo>();
			//if (DateTime.Compare(fileInfo.CreationTime.Date, dateTime) > 0)
			//{
			//	dateTime = fileInfo.CreationTime.Date;
			//}
			if (DateTime.Compare(DateTime.Today, dateTime) > 0)
			{
				dateTime = DateTime.Today;
			}
			dateTime = DateTime.Today;
			return dateTime;
		}

		// Token: 0x060007F8 RID: 2040 RVA: 0x000064D1 File Offset: 0x000046D1
		public static void smethod_10()
		{
			if (Class245.smethod_7())
			{
				Interaction.MsgBox("尊贵的VIP,欢迎使用!", MsgBoxStyle.OkOnly, null);
			}
		}

		// Token: 0x060007F9 RID: 2041 RVA: 0x0000E59C File Offset: 0x0000C79C
		internal static string smethod_11(string string_0, string string_1, int int_0)
		{
			byte[] array = new MD5CryptoServiceProvider().ComputeHash(Encoding.Default.GetBytes(string_0));
			StringBuilder stringBuilder = new StringBuilder();
			foreach (byte b in array)
			{
				stringBuilder.Append(b.ToString("x2"));
			}
			string result;
			if (int_0 == 16)
			{
				result = stringBuilder.ToString().Substring(8, 16);
			}
			else if (int_0 == 32)
			{
				result = stringBuilder.ToString();
			}
			else
			{
				result = string.Empty;
			}
			return result;
		}

		// Token: 0x040004B1 RID: 1201
		internal static Class245.Class246 class246_0;

		// Token: 0x040004B2 RID: 1202
		internal static Class60.Class61 class61_0 = new Class60.Class61("VIP功能试用次数");

		// Token: 0x040004B3 RID: 1203
		internal static Class60.Class61 class61_1 = new Class60.Class61("VIP功能试用次数");

		// Token: 0x0200014C RID: 332
		internal sealed class Class246
		{
			// Token: 0x060007FA RID: 2042 RVA: 0x000064E7 File Offset: 0x000046E7
			public Class246()
			{
				this.bool_0 = false;
				this.string_0 = string.Empty;
				this.string_1 = "免费版";
				this.dateTime_0 = Conversions.ToDate("1990-1-1");
			}

			// Token: 0x060007FB RID: 2043 RVA: 0x0004E4EC File Offset: 0x0004C6EC
			public Class246(object object_0, object object_1)
			{
				this.bool_0 = false;
				this.string_0 = string.Empty;
				this.string_1 = "免费版";
				this.dateTime_0 = Conversions.ToDate("1990-1-1");
				try
				{
					string[] array = Strings.Split(Conversions.ToString(object_0), ";", -1, CompareMethod.Binary);
					this.string_0 = array[0];
					this.string_2 = Conversions.ToString(object_1);
					if (Operators.CompareString(this.string_2, this.string_0, false) != 0)
					{
						this.string_1 = "免费版";
						this.dateTime_0 = Conversions.ToDate("2999-1-1");
						this.bool_0 = false;
					}
					else
					{
						this.string_1 = array[1];
						this.dateTime_0 = Conversions.ToDate(array[2]);
						this.bool_0 = true;
						Class245.class61_0.method_1(Conversions.ToString(object_0));
					}
				}
				catch (Exception ex)
				{
					this.bool_0 = false;
					Class245.class61_0.method_1(string.Empty);
				}
			}

			// Token: 0x060007FC RID: 2044 RVA: 0x0004E5F0 File Offset: 0x0004C7F0
			public object method_0()
			{
				object result;
				if (DateTime.Compare(this.dateTime_0, Class245.smethod_9()) > 0)
				{
					result = true;
				}
				else
				{
					result = false;
				}
				return result;
			}

			// Token: 0x060007FD RID: 2045 RVA: 0x0004E624 File Offset: 0x0004C824
			public string method_1()
			{
				string arg = "解析失败";
				if (this.bool_0)
				{
					arg = "解析成功";
				}
				return string.Format("{0}!授权为:{1},到期时间为{2}", arg, this.string_1, this.dateTime_0.ToShortDateString());
			}

			// Token: 0x040004B4 RID: 1204
			internal bool bool_0;

			// Token: 0x040004B5 RID: 1205
			internal string string_0;

			// Token: 0x040004B6 RID: 1206
			internal string string_1;

			// Token: 0x040004B7 RID: 1207
			internal DateTime dateTime_0;

			// Token: 0x040004B8 RID: 1208
			private string string_2;
		}

		// Token: 0x0200014D RID: 333
		[Serializable]
		internal sealed class Class247
		{
			// Token: 0x06000800 RID: 2048 RVA: 0x0004E664 File Offset: 0x0004C864
			//internal DateTime _Lambda$__14-0(FileInfo fileInfo_0)
			//{
			//	return fileInfo_0.CreationTime.Date;
			//}

			// Token: 0x040004B9 RID: 1209
			public static readonly Class245.Class247 class247_0 = new Class245.Class247();

			// Token: 0x040004BA RID: 1210
			public static Func<FileInfo, DateTime> func_0;
		}
	}
}
