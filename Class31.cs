using System;
using System.Text;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace sheet_api_keygen
{
	// Token: 0x02000050 RID: 80
	[StandardModule]
	internal sealed class Class31
	{
		// Token: 0x060001BB RID: 443 RVA: 0x000030DF File Offset: 0x000012DF
		// Note: this type is marked as 'beforefieldinit'.
		static Class31()
		{
			Class31.smethod_1("abcdefghijklmnopqrstuvwxyz0123456789+/ABCDEFGHIJKLMNOPQRSTUVWXYZ");
		}

		// Token: 0x060001BC RID: 444 RVA: 0x000030EB File Offset: 0x000012EB
		private static string smethod_0()
		{
			return Class31.string_0;
		}

		// Token: 0x060001BD RID: 445 RVA: 0x000030F2 File Offset: 0x000012F2
		private static void smethod_1(string string_1)
		{
			Class31.string_0 = string_1;
		}

		// Token: 0x060001BE RID: 446 RVA: 0x0001241C File Offset: 0x0001061C
		private static string smethod_2(byte[] byte_0)
		{
			string text = string.Empty;
			long num = (long)Information.UBound(byte_0, 1);
			long num2 = num;
			checked
			{
				for (long num3 = 0L; num3 <= num2; num3 += 3L)
				{
					string text2;
					if (num3 + 2L > num)
					{
						long num4 = (long)Math.Round(unchecked((double)(byte_0[checked((int)num3)] & 252) / 4.0 + 1.0));
						text2 = Strings.Mid(Class31.smethod_0(), (int)num4, 1);
						long num5 = num % 3L;
						long num6 = num5;
						if (num6 <= 2L)
						{
							switch (unchecked((uint)num6))
							{
							case 0U:
								num4 = unchecked((long)(checked((byte_0[(int)num3] & 3) * 16 + 1)));
								text2 += Strings.Mid(Class31.smethod_0(), (int)num4, 1);
								text2 += "=";
								text2 += "=";
								break;
							case 1U:
								num4 = (long)Math.Round(unchecked((double)(checked((byte_0[(int)num3] & 3) * 16)) + (double)(byte_0[checked((int)(num3 + 1L))] & 240) / 16.0 + 1.0));
								text2 += Strings.Mid(Class31.smethod_0(), (int)num4, 1);
								num4 = unchecked((long)(checked((byte_0[(int)(num3 + 1L)] & 15) * 4 + 1)));
								text2 += Strings.Mid(Class31.smethod_0(), (int)num4, 1);
								text2 += "=";
								break;
							case 2U:
								text2 += Strings.Mid(Class31.smethod_0(), (int)num4, 1);
								num4 = (long)Math.Round(unchecked((double)(checked((byte_0[(int)(num3 + 1L)] & 15) * 4)) + (double)(byte_0[checked((int)(num3 + 2L))] & 192) / 64.0 + 1.0));
								text2 += Strings.Mid(Class31.smethod_0(), (int)num4, 1);
								num4 = unchecked((long)(checked((byte_0[(int)(num3 + 2L)] & 63) + 1)));
								text2 += Strings.Mid(Class31.smethod_0(), (int)num4, 1);
								break;
							}
						}
					}
					else
					{
						long num4 = (long)Math.Round(unchecked((double)(byte_0[checked((int)num3)] & 252) / 4.0 + 1.0));
						text2 = Strings.Mid(Class31.smethod_0(), (int)num4, 1);
						num4 = (long)Math.Round(unchecked((double)(checked((byte_0[(int)num3] & 3) * 16)) + (double)(byte_0[checked((int)(num3 + 1L))] & 240) / 16.0 + 1.0));
						text2 += Strings.Mid(Class31.smethod_0(), (int)num4, 1);
						num4 = (long)Math.Round(unchecked((double)(checked((byte_0[(int)(num3 + 1L)] & 15) * 4)) + (double)(byte_0[checked((int)(num3 + 2L))] & 192) / 64.0 + 1.0));
						text2 += Strings.Mid(Class31.smethod_0(), (int)num4, 1);
						num4 = unchecked((long)(checked((byte_0[(int)(num3 + 2L)] & 63) + 1)));
						text2 += Strings.Mid(Class31.smethod_0(), (int)num4, 1);
					}
					text += text2;
					text2 = string.Empty;
				}
				return text;
			}
		}

		// Token: 0x060001BF RID: 447 RVA: 0x00012758 File Offset: 0x00010958
		private static byte[] smethod_3(string string_1)
		{
			Class31.long_0 = 0L;
			long num = (long)Strings.Len(string_1);
			checked
			{
				byte[] array = new byte[(int)((long)Math.Round(unchecked((double)num / 4.0 * 3.0 - 1.0))) + 1];
				long num2 = num;
				for (long num3 = 1L; num3 <= num2; num3 += 4L)
				{
					array[(int)Math.Round(unchecked(Conversion.Int((double)(checked(num3 - 1L)) / 4.0) * 3.0 + 0.0))] = Conversions.ToByte(Operators.AddObject(Operators.MultiplyObject(Class31.smethod_4(Strings.Mid(string_1, (int)num3, 1)), 4), Conversion.Int(Operators.DivideObject(Class31.smethod_4(Strings.Mid(string_1, (int)(num3 + 1L), 1)), 16))));
					array[(int)Math.Round(unchecked(Conversion.Int((double)(checked(num3 - 1L)) / 4.0) * 3.0 + 1.0))] = Conversions.ToByte(Operators.AddObject(Operators.MultiplyObject(Operators.AndObject(Class31.smethod_4(Strings.Mid(string_1, (int)(num3 + 1L), 1)), 15), 16), Conversion.Int(Operators.DivideObject(Operators.AndObject(Class31.smethod_4(Strings.Mid(string_1, (int)(num3 + 2L), 1)), 60), 4))));
					array[(int)Math.Round(unchecked(Conversion.Int((double)(checked(num3 - 1L)) / 4.0) * 3.0 + 2.0))] = Conversions.ToByte(Operators.AddObject(Operators.MultiplyObject(Operators.AndObject(Class31.smethod_4(Strings.Mid(string_1, (int)(num3 + 2L), 1)), 3), 64), Class31.smethod_4(Strings.Mid(string_1, (int)(num3 + 3L), 1))));
				}
				if (Operators.CompareString(Strings.Right(string_1, 1), "=", false) == 0)
				{
					Class31.long_0 = 0L;
					if (Operators.CompareString(Strings.Right(string_1, 2), "==", false) == 0)
					{
						Class31.long_0 = 2L;
					}
					else
					{
						Class31.long_0 = 1L;
					}
				}
				return array;
			}
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x000129D4 File Offset: 0x00010BD4
		private static object smethod_4(string string_1)
		{
			object result;
			if (Operators.CompareString(string_1, "=", false) == 0)
			{
				result = 0;
			}
			else
			{
				result = checked(Strings.InStr(Class31.smethod_0(), string_1, CompareMethod.Binary) - 1);
			}
			return result;
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x000030FA File Offset: 0x000012FA
		internal static object smethod_5(string string_1)
		{
			return Class31.smethod_2(Encoding.Default.GetBytes(string_1));
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x00012A10 File Offset: 0x00010C10
		internal static object smethod_6(string string_1)
		{
			object result;
			try
			{
				result = Encoding.Default.GetString(Class31.smethod_3(string_1));
			}
			catch (Exception ex)
			{
				result = string.Empty;
			}
			return result;
		}

		// Token: 0x040000D0 RID: 208
		private static long long_0;

		// Token: 0x040000D1 RID: 209
		private static string string_0;
	}
}
