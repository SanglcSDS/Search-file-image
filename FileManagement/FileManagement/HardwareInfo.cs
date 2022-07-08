using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Management;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Security.Principal;
using System.Text.RegularExpressions;

namespace FileManagement
{
   public class HardwareInfo
    {
		public static bool IsInvalid(string info)
		{
			try
			{
				int num = 0;
				if (!info.Contains(GetComputerSid()))
				{
					return false;
				}
				num++;
				if (info.Contains(GetHDDSerialNo()))
				{
					num++;
				}
				if (info.Contains(GetMACAddress()))
				{
					num++;
				}
				if (info.Contains(GetBoardProductId()))
				{
					num++;
				}
				if (num >= 3)
				{
					return true;
				}
			}
			catch
			{
			}
			return false;
		}

		public static string Info()
		{
			string text = string.Empty;
			try
			{
				text += GetComputerSid();
				text += GetHDDSerialNo();
				text += GetMACAddress();
				text += GetBoardProductId();
			}
			catch
			{
			}
			return text;
		}

		public static string GetComputerSid()
		{
			return new SecurityIdentifier((byte[])new DirectoryEntry($"WinNT://{Environment.MachineName},Computer").Children.Cast<DirectoryEntry>().First().InvokeGet("objectSID"), 0).AccountDomainSid.ToString();
		}

		public static string GetHDDSerialNo()
		{
			string text = "";
			try
			{
				ManagementClass managementClass = new ManagementClass("Win32_LogicalDisk");
				ManagementObjectCollection instances = managementClass.GetInstances();
				foreach (ManagementObject item in instances)
				{
					text += Convert.ToString(item["VolumeSerialNumber"]);
				}
			}
			catch
			{
			}
			return text;
		}

		public static string GetMACAddress()
		{
			string text = string.Empty;
			try
			{
				NetworkInterface[] allNetworkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
				NetworkInterface[] array = allNetworkInterfaces;
				foreach (NetworkInterface networkInterface in array)
				{
					if (text == string.Empty)
					{
						IPInterfaceProperties iPProperties = networkInterface.GetIPProperties();
						text = networkInterface.GetPhysicalAddress().ToString();
					}
				}
			}
			catch
			{
			}
			return text;
		}

		public static string GetBoardProductId()
		{
			try
			{
				ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_BaseBoard");
				foreach (ManagementObject item in managementObjectSearcher.Get())
				{
					try
					{
						return item.GetPropertyValue("Product").ToString();
					}
					catch
					{
					}
				}
			}
			catch
			{
			}
			return "Unknown";
		}

		private static string GetBIOSserNo()
		{
			try
			{
				ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_BIOS");
				foreach (ManagementObject item in managementObjectSearcher.Get())
				{
					try
					{
						return item.GetPropertyValue("SerialNumber").ToString();
					}
					catch
					{
					}
				}
			}
			catch
			{
			}
			return "Unknown";
		}

		private static string GetBIOScaption()
		{
			try
			{
				ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_BIOS");
				foreach (ManagementObject item in managementObjectSearcher.Get())
				{
					try
					{
						return item.GetPropertyValue("Caption").ToString();
					}
					catch
					{
					}
				}
			}
			catch
			{
			}
			return "Unknown";
		}

		public static string GetComPort(List<string> lsEPP)
		{
			try
			{
				ManagementClass managementClass = new ManagementClass("Win32_PnPEntity");
				ManagementObjectCollection instances = managementClass.GetInstances();
				foreach (ManagementObject item in instances)
				{
					foreach (string item2 in lsEPP)
					{
						if (item.GetPropertyValue("PNPDeviceID").ToString().Contains(item2))
						{
							Regex regex = new Regex(".*\\((?<COM>COM\\d+)\\)", RegexOptions.ExplicitCapture);
							MatchCollection matchCollection = regex.Matches(item.GetPropertyValue("Name").ToString());
							if (matchCollection.Count != 0)
							{
								return matchCollection[0].Groups["COM"].Value;
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				//	MainForm.WriteLogError(ex, MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name);
			}
			return string.Empty;
		}
	}
}
