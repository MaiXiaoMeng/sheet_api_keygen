using System;
using System.Text;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace sheet_api_keygen
{
	// Token: 0x020000D4 RID: 212
	[StandardModule]
	internal sealed class Class152
	{
		// Token: 0x06000580 RID: 1408 RVA: 0x000051ED File Offset: 0x000033ED
		// Note: this type is marked as 'beforefieldinit'.
		static Class152()
		{
			Class152.smethod_1("abcdefghijklmnopqrstuvwxyz0123456789+/ABCDEFGHIJKLMNOPQRSTUVWXYZ");
		}

		// Token: 0x06000581 RID: 1409 RVA: 0x000051F9 File Offset: 0x000033F9
		private static string smethod_0()
		{
			return Class152.string_0;
		}

		// Token: 0x06000582 RID: 1410 RVA: 0x00005200 File Offset: 0x00003400
		private static void smethod_1(string string_1)
		{
			Class152.string_0 = string_1;
		}

		// Token: 0x06000583 RID: 1411 RVA: 0x00032060 File Offset: 0x00030260
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
						text2 = Strings.Mid(Class152.smethod_0(), (int)num4, 1);
						long num5 = num % 3L;
						long num6 = num5;
						if (num6 <= 2L)
						{
							switch (unchecked((uint)num6))
							{
							case 0U:
								num4 = unchecked((long)(checked((byte_0[(int)num3] & 3) * 16 + 1)));
								text2 += Strings.Mid(Class152.smethod_0(), (int)num4, 1);
								text2 += "=";
								text2 += "=";
								break;
							case 1U:
								num4 = (long)Math.Round(unchecked((double)(checked((byte_0[(int)num3] & 3) * 16)) + (double)(byte_0[checked((int)(num3 + 1L))] & 240) / 16.0 + 1.0));
								text2 += Strings.Mid(Class152.smethod_0(), (int)num4, 1);
								num4 = unchecked((long)(checked((byte_0[(int)(num3 + 1L)] & 15) * 4 + 1)));
								text2 += Strings.Mid(Class152.smethod_0(), (int)num4, 1);
								text2 += "=";
								break;
							case 2U:
								text2 += Strings.Mid(Class152.smethod_0(), (int)num4, 1);
								num4 = (long)Math.Round(unchecked((double)(checked((byte_0[(int)(num3 + 1L)] & 15) * 4)) + (double)(byte_0[checked((int)(num3 + 2L))] & 192) / 64.0 + 1.0));
								text2 += Strings.Mid(Class152.smethod_0(), (int)num4, 1);
								num4 = unchecked((long)(checked((byte_0[(int)(num3 + 2L)] & 63) + 1)));
								text2 += Strings.Mid(Class152.smethod_0(), (int)num4, 1);
								break;
							}
						}
					}
					else
					{
						long num4 = (long)Math.Round(unchecked((double)(byte_0[checked((int)num3)] & 252) / 4.0 + 1.0));
						text2 = Strings.Mid(Class152.smethod_0(), (int)num4, 1);
						num4 = (long)Math.Round(unchecked((double)(checked((byte_0[(int)num3] & 3) * 16)) + (double)(byte_0[checked((int)(num3 + 1L))] & 240) / 16.0 + 1.0));
						text2 += Strings.Mid(Class152.smethod_0(), (int)num4, 1);
						num4 = (long)Math.Round(unchecked((double)(checked((byte_0[(int)(num3 + 1L)] & 15) * 4)) + (double)(byte_0[checked((int)(num3 + 2L))] & 192) / 64.0 + 1.0));
						text2 += Strings.Mid(Class152.smethod_0(), (int)num4, 1);
						num4 = unchecked((long)(checked((byte_0[(int)(num3 + 2L)] & 63) + 1)));
						text2 += Strings.Mid(Class152.smethod_0(), (int)num4, 1);
					}
					text += text2;
					text2 = string.Empty;
				}
				return text;
			}
		}

		// Token: 0x06000584 RID: 1412 RVA: 0x0003239C File Offset: 0x0003059C
		private static byte[] smethod_3(string string_1)
		{
			Class152.long_0 = 0L;
			long num = (long)Strings.Len(string_1);
			checked
			{
				byte[] array = new byte[(int)((long)Math.Round(unchecked((double)num / 4.0 * 3.0 - 1.0))) + 1];
				long num2 = num;
				for (long num3 = 1L; num3 <= num2; num3 += 4L)
				{
					array[(int)Math.Round(unchecked(Conversion.Int((double)(checked(num3 - 1L)) / 4.0) * 3.0 + 0.0))] = Conversions.ToByte(Operators.AddObject(Operators.MultiplyObject(Class152.smethod_4(Strings.Mid(string_1, (int)num3, 1)), 4), Conversion.Int(Operators.DivideObject(Class152.smethod_4(Strings.Mid(string_1, (int)(num3 + 1L), 1)), 16))));
					array[(int)Math.Round(unchecked(Conversion.Int((double)(checked(num3 - 1L)) / 4.0) * 3.0 + 1.0))] = Conversions.ToByte(Operators.AddObject(Operators.MultiplyObject(Operators.AndObject(Class152.smethod_4(Strings.Mid(string_1, (int)(num3 + 1L), 1)), 15), 16), Conversion.Int(Operators.DivideObject(Operators.AndObject(Class152.smethod_4(Strings.Mid(string_1, (int)(num3 + 2L), 1)), 60), 4))));
					array[(int)Math.Round(unchecked(Conversion.Int((double)(checked(num3 - 1L)) / 4.0) * 3.0 + 2.0))] = Conversions.ToByte(Operators.AddObject(Operators.MultiplyObject(Operators.AndObject(Class152.smethod_4(Strings.Mid(string_1, (int)(num3 + 2L), 1)), 3), 64), Class152.smethod_4(Strings.Mid(string_1, (int)(num3 + 3L), 1))));
				}
				if (Operators.CompareString(Strings.Right(string_1, 1), "=", false) == 0)
				{
					Class152.long_0 = 0L;
					if (Operators.CompareString(Strings.Right(string_1, 2), "==", false) == 0)
					{
						Class152.long_0 = 2L;
					}
					else
					{
						Class152.long_0 = 1L;
					}
				}
				return array;
			}
		}

		// Token: 0x06000585 RID: 1413 RVA: 0x00032618 File Offset: 0x00030818
		private static object smethod_4(string string_1)
		{
			object result;
			if (Operators.CompareString(string_1, "=", false) == 0)
			{
				result = 0;
			}
			else
			{
				result = checked(Strings.InStr(Class152.smethod_0(), string_1, CompareMethod.Binary) - 1);
			}
			return result;
		}

		// Token: 0x06000586 RID: 1414 RVA: 0x00005208 File Offset: 0x00003408
		internal static object smethod_5(string string_1)
		{
			return Class152.smethod_2(Encoding.Default.GetBytes(string_1));
		}

		// Token: 0x06000587 RID: 1415 RVA: 0x00032654 File Offset: 0x00030854
		internal static object smethod_6(string string_1)
		{
			object result;
			try
			{
				result = Encoding.Default.GetString(Class152.smethod_3(string_1));
			}
			catch (Exception ex)
			{
				result = string.Empty;
			}
			return result;
		}

		// Token: 0x040001DD RID: 477
		private static long long_0;

		// Token: 0x040001DE RID: 478
		private static string string_0;
	}
}
