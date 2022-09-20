using System;
using System.Globalization;
using System.Linq;
using System.Management;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace sheet_api_keygen
{
	// Token: 0x020000BE RID: 190
	internal sealed class Class111
	{
		// Token: 0x060004E2 RID: 1250 RVA: 0x00004B95 File Offset: 0x00002D95
		internal string method_0()
		{
			return this.string_0;
		}

		// Token: 0x060004E3 RID: 1251 RVA: 0x00004B9D File Offset: 0x00002D9D
		internal void method_1(string string_1)
		{
			this.string_0 = string_1;
		}

		// Token: 0x060004E4 RID: 1252 RVA: 0x00004BA6 File Offset: 0x00002DA6
		internal string method_2(object object_0)
		{
			return "KhenJX-" + this.method_13(Conversions.ToString(Operators.ConcatenateObject(object_0, this.method_4())));
		}

		// Token: 0x060004E5 RID: 1253 RVA: 0x00004BC9 File Offset: 0x00002DC9
		private string method_3()
		{
			return this.method_11(new string[]
			{
				"Win32_VideoController",
				"Name",
				"DeviceID",
				"DriverVersion"
			});
		}

		// Token: 0x060004E6 RID: 1254 RVA: 0x0002D51C File Offset: 0x0002B71C
		private string method_4()
		{
			ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_ComputerSystemProduct");
			string text = string.Empty;
			try
			{
				ManagementObjectCollection.ManagementObjectEnumerator enumerator = managementObjectSearcher.Get().GetEnumerator();
				if (enumerator.MoveNext())
				{
					text = ((ManagementObject)enumerator.Current)["UUID"].ToString();
				}
			}
			finally
			{
		
			}
			if (Operators.CompareString(text, "FFFFFFFF-FFFF-FFFF-FFFF-FFFFFFFFFFFF", false) == 0)
			{
				text = this.method_10();
			}
			return text;
		}

		// Token: 0x060004E7 RID: 1255 RVA: 0x00004BF7 File Offset: 0x00002DF7
		private string method_5()
		{
			return this.method_11(new string[]
			{
				"Win32_BaseBoard",
				"Name",
				"Manufacturer",
				"SerialNumber"
			});
		}

		// Token: 0x060004E8 RID: 1256 RVA: 0x00004C25 File Offset: 0x00002E25
		private string method_6()
		{
			return this.method_11(new string[]
			{
				"Win32_Processor",
				"Name",
				"Manufacturer",
				"ProcessorId"
			});
		}

		// Token: 0x060004E9 RID: 1257 RVA: 0x00004C53 File Offset: 0x00002E53
		private string method_7()
		{
			return this.method_11(new string[]
			{
				"Win32_DiskDrive",
				"Model",
				"SerialNumber"
			});
		}

		// Token: 0x060004EA RID: 1258 RVA: 0x00004C79 File Offset: 0x00002E79
		private string method_8()
		{
			return this.method_11(new string[]
			{
				"Win32_BIOS",
				"Name",
				"Manufacturer",
				"SerialNumber"
			});
		}

		// Token: 0x060004EB RID: 1259 RVA: 0x0002D5A4 File Offset: 0x0002B7A4
		private string method_9()
		{
			string result;
			try
			{
				string text = string.Empty;
				ManagementClass managementClass = new ManagementClass("Win32_NetworkAdapterConfiguration");
				try
				{
					ManagementObjectCollection instances = managementClass.GetInstances();
					try
					{
						foreach (ManagementBaseObject managementBaseObject in instances)
						{
							ManagementObject managementObject = (ManagementObject)managementBaseObject;
							if (Conversions.ToBoolean(managementObject["IPEnabled"]))
							{
								text = managementObject["Description"].ToString();
								text = text + "," + managementObject["MacAddress"].ToString();
								return text;
							}
							managementObject.Dispose();
						}
					}
					finally
					{

					}
				}
				finally
				{
					((IDisposable)managementClass).Dispose();
				}
				result = text;
			}
			catch (Exception ex)
			{
				result = string.Empty;
			}
			return result;
		}

		// Token: 0x060004EC RID: 1260 RVA: 0x0002D68C File Offset: 0x0002B88C
		public string method_10()
		{
			StringBuilder stringBuilder = new StringBuilder();
			string result;
			try
			{
				ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("SELECT DiskIndex FROM Win32_DiskPartition WHERE Bootable = TRUE");
				try
				{
					foreach (ManagementBaseObject managementBaseObject in managementObjectSearcher.Get())
					{
						int value = Convert.ToInt32(RuntimeHelpers.GetObjectValue(((ManagementObject)managementBaseObject).Properties["DiskIndex"].Value));
						ManagementObjectCollection managementObjectCollection = new ManagementObjectSearcher("SELECT Model,SerialNumber FROM Win32_DiskDrive WHERE Index = " + Conversions.ToString(value)).Get();
						try
						{
							foreach (ManagementBaseObject managementBaseObject2 in managementObjectCollection)
							{
								ManagementObject managementObject = (ManagementObject)managementBaseObject2;
								stringBuilder.Append(Conversions.ToString(managementObject.Properties["Model"].Value));
								stringBuilder.Append(',');
								stringBuilder.Append(Conversions.ToString(managementObject.Properties["SerialNumber"].Value));
							}
						}
						finally
						{
			
						}
					}
				}
				finally
				{
	
				}
				result = Strings.Mid(stringBuilder.ToString(), 2);
			}
			catch (Exception ex)
			{
				result = string.Empty;
			}
			return result;
		}

		// Token: 0x060004ED RID: 1261 RVA: 0x0002D804 File Offset: 0x0002BA04
		private string method_11(string[] string_1)
		{
			StringBuilder stringBuilder = new StringBuilder();
			string queryString = this.method_12(string_1);
			ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("root\\CIMV2", queryString);
			checked
			{
				try
				{
					using (ManagementObjectCollection managementObjectCollection = managementObjectSearcher.Get())
					{
						try
						{
							foreach (ManagementBaseObject managementBaseObject in managementObjectCollection)
							{
								ManagementObject managementObject = (ManagementObject)managementBaseObject;
								using (managementObject)
								{
									int num = string_1.Length - 1;
									for (int i = 1; i <= num; i++)
									{
										stringBuilder.Append(',');
										stringBuilder.Append(managementObject[string_1[i]].ToString().Trim());
									}
								}
								stringBuilder.Append(';');
							}
						}
						finally
						{
			
						}
					}
				}
				finally
				{
					((IDisposable)managementObjectSearcher).Dispose();
				}
				return Strings.Mid(stringBuilder.ToString(), 2);
			}
		}

		// Token: 0x060004EE RID: 1262 RVA: 0x0002D908 File Offset: 0x0002BB08
		private string method_12(string[] string_1)
		{
			StringBuilder stringBuilder = new StringBuilder();
			string arg = string.Empty;
			stringBuilder.Append("SELECT ");
			checked
			{
				int num = string_1.Length - 1;
				for (int i = 0; i <= num; i++)
				{
					if (i == 0)
					{
						arg = string_1[i];
					}
					else
					{
						stringBuilder.Append((i < string_1.Length - 1) ? string.Format("{0}, ", string_1[i]) : string.Format("{0} ", string_1[i]));
					}
				}
				stringBuilder.Append(string.Format("FROM {0}", arg));
				return stringBuilder.ToString();
			}
		}

		// Token: 0x060004EF RID: 1263 RVA: 0x0002D98C File Offset: 0x0002BB8C
		private string method_13(string string_1)
		{
			SHA1CryptoServiceProvider sha1CryptoServiceProvider = new SHA1CryptoServiceProvider();
			string result;
			try
			{
				byte[] byte_ = sha1CryptoServiceProvider.ComputeHash(Encoding.Default.GetBytes(string_1));
				result = this.method_14(byte_);
			}
			finally
			{
				((IDisposable)sha1CryptoServiceProvider).Dispose();
			}
			return result;
		}

		// Token: 0x060004F0 RID: 1264 RVA: 0x0002D9D4 File Offset: 0x0002BBD4
		private string method_14(byte[] byte_0)
		{
			StringBuilder stringBuilder = new StringBuilder();
			checked
			{
				int num = byte_0.Count<byte>() - 1;
				for (int i = 0; i <= num; i++)
				{
					byte b = byte_0[i];
					int num2 = (int)(b & 15);
					int num3 = (int)(unchecked((byte)((uint)b >> 4)) & 15);
					if (num3 > 9)
					{
						stringBuilder.Append(Strings.ChrW(num3 - 10 + 65).ToString(CultureInfo.InvariantCulture));
					}
					else
					{
						stringBuilder.Append(num3.ToString(CultureInfo.InvariantCulture));
					}
					if (num2 > 9)
					{
						stringBuilder.Append(Strings.ChrW(num2 - 10 + 65).ToString(CultureInfo.InvariantCulture));
					}
					else
					{
						stringBuilder.Append(num2.ToString(CultureInfo.InvariantCulture));
					}
					if (i + 1 != byte_0.Count<byte>() && (i + 1) % 2 == 0)
					{
						stringBuilder.Append('-');
					}
				}
				return stringBuilder.ToString();
			}
		}

		// Token: 0x0400019A RID: 410
		private string string_0;
	}
}
