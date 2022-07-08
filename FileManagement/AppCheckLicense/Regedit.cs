using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCheckLicense
{
	public class Regedit
	{
		public static string ReadKey(string subkey, string KeyName)
		{
			try
			{
				RegistryKey localMachine = Registry.CurrentUser;
				RegistryKey registryKey = localMachine.OpenSubKey(subkey);
				if (registryKey == null)
				{
					return null;
				}
				try
				{
					return (string)registryKey.GetValue(KeyName.ToUpper());
				}
				catch (Exception ex)
				{
					return null;
				}
			}
			catch (Exception ex2)
			{
			}
			return string.Empty;
		}

		public static bool WriteKey(string SubKey, string KeyName, object Value)
		{
			try
			{
				RegistryKey localMachine = Registry.CurrentUser;
				RegistryKey registryKey = localMachine.CreateSubKey(SubKey, RegistryKeyPermissionCheck.ReadWriteSubTree);
				registryKey.SetValue(KeyName.ToUpper(), Value);
				return true;
			}
			catch (Exception ex)
			{
				return false;
			}
		}

		public static string LoadReg(string subkey, string key, string defaultvalue)
		{
			string text = string.Empty;
			try
			{
				text = ReadKey(subkey, key);
				if (text == null)
				{
					text = defaultvalue;
					WriteKey(subkey, key, defaultvalue);
				}
			}
			catch (Exception ex)
			{
			}
			return text;
		}
	}
}
