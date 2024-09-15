using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;

using System.Threading.Tasks;

namespace AccessKeyDemo
{
    public class EncryptionHelper
    {
        private static readonly byte[] Key = Encoding.UTF8.GetBytes("your-32-char-long-encryption-key");
        private static readonly byte[] IV = Encoding.UTF8.GetBytes("your-16-char-IV!");

        public static string Encrypt(UserClaim claim)
        {
            string plainText = JsonSerializer.Serialize(claim);

            using (var aes = Aes.Create())
            {
                aes.Key = Key;
                aes.IV = IV;

                using (var encryptor = aes.CreateEncryptor(aes.Key, aes.IV))
                {
                    using (var ms = new MemoryStream())
                    {
                        using (var cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                        {
                            using (var sw = new StreamWriter(cs))
                            {
                                sw.Write(plainText);
                            }
                        }
                        return Convert.ToBase64String(ms.ToArray());
                    }
                }
            }
        }

        public static UserClaim Decrypt(string cipherText)
        {
            using (var aes = Aes.Create())
            {
                aes.Key = Key;
                aes.IV = IV;

                using (var decryptor = aes.CreateDecryptor(aes.Key, aes.IV))
                {
                    using (var ms = new MemoryStream(Convert.FromBase64String(cipherText)))
                    {
                        using (var cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
                        {
                            using (var sr = new StreamReader(cs))
                            {
                                string decryptedText = sr.ReadToEnd();
                                return JsonSerializer.Deserialize<UserClaim>(decryptedText);
                            }
                        }
                    }
                }
            }

        }
    }
}
