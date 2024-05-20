// EncryptionService.cs

using System;
using System.Security.Cryptography;
using System.Text;

namespace EncryptionLibrary
{
    public class EncryptionService
    {
        public string Encrypt(string plainText)
        {
            using Aes aesAlg = Aes.Create();
            ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

            byte[] encryptedBytes;
            using (var memoryStream = new System.IO.MemoryStream())
            {
                using (var cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write))
                {
                    using (var streamWriter = new System.IO.StreamWriter(cryptoStream))
                    {
                        streamWriter.Write(plainText);
                    }
                }
                encryptedBytes = memoryStream.ToArray();
            }

            return Convert.ToBase64String(encryptedBytes);
        }
    }
}
