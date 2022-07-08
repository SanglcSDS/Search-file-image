using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FileManagement
{
	public class ManagedAes
	{
		public static string Encrypt(string clearText, string EncryptionKey)
		{
			byte[] bytes = Encoding.Unicode.GetBytes(clearText);
			using (Aes aes = Aes.Create())
			{
				Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(EncryptionKey, new byte[13]
				{
				73, 118, 97, 110, 32, 77, 101, 100, 118, 101,
				100, 101, 118
				});
				aes.Key = rfc2898DeriveBytes.GetBytes(32);
				aes.IV = rfc2898DeriveBytes.GetBytes(16);
				using (MemoryStream ms = new MemoryStream())
				{
					using (CryptoStream cryptoStream = new CryptoStream(ms, aes.CreateEncryptor(), CryptoStreamMode.Write))
					{
						cryptoStream.Write(bytes, 0, bytes.Length);
						cryptoStream.Close();
					}
					clearText = Convert.ToBase64String(ms.ToArray());
				}

			}
			return clearText;
		}

		public static string Decrypt(string cipherText, string EncryptionKey)
		{
			byte[] array = Convert.FromBase64String(cipherText);
			using (Aes aes = Aes.Create())
			{
				Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(EncryptionKey, new byte[13]
				{
				73, 118, 97, 110, 32, 77, 101, 100, 118, 101,
				100, 101, 118
				});
				aes.Key = rfc2898DeriveBytes.GetBytes(32);
				aes.IV = rfc2898DeriveBytes.GetBytes(16);
				using (MemoryStream ms = new MemoryStream())
				{
					using (CryptoStream cryptoStream = new CryptoStream(ms, aes.CreateDecryptor(), CryptoStreamMode.Write))
					{
						cryptoStream.Write(array, 0, array.Length);
						cryptoStream.Close();
					}
					cipherText = Encoding.Unicode.GetString(ms.ToArray());
				}

			}
			return cipherText;
		}
	}
}
