using System;
using System.Text;
using System.Security.Cryptography;
using System.IO;

namespace Tool_Windows
{
    class Crypto
    {
        public static string AesCrypt(string raw)
        {
            byte[] key = Encoding.UTF8.GetBytes("e0ae85810810611db4941bc65f4bb1a8");
            byte[] iv = Encoding.UTF8.GetBytes("e0ae85810810611db4941bc65f4bb1a8");

            try
            {
                // Create Aes that generates a new key and initialization vector (IV).    
                // Same key must be used in encryption and decryption    
                using (AesManaged aes = new AesManaged())
                {
                    // Encrypt string    
                    byte[] encrypted = EncryptByte(raw, aes.Key, aes.IV);
                    // Decrypt the bytes to a string.    
                    string decrypted = DecryptByte(encrypted, aes.Key, aes.IV);
                    // Print decrypted string. It should be same as raw data    
                    string hasil = $"Encrypted data: {System.Text.Encoding.UTF8.GetString(encrypted)}\nDecrypted data: {decrypted}";
                    return hasil;
                }
            }
            catch (Exception exp)
            {
                return exp.Message;
            }
        }

        public static byte[] EncryptByte(string plainText, byte[] Key, byte[] IV)
        {
            byte[] encrypted;
            // Create a new AesManaged.    
            using (AesManaged aes = new AesManaged())
            {
                // Create encryptor    
                ICryptoTransform encryptor = aes.CreateEncryptor(Key, IV);
                // Create MemoryStream    
                using (MemoryStream ms = new MemoryStream())
                {
                    // Create crypto stream using the CryptoStream class. This class is the key to encryption    
                    // and encrypts and decrypts data from any given stream. In this case, we will pass a memory stream    
                    // to encrypt    
                    using (CryptoStream cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                    {
                        // Create StreamWriter and write data to a stream    
                        using (StreamWriter sw = new StreamWriter(cs))
                            sw.Write(plainText);
                        encrypted = ms.ToArray();
                    }
                }
            }
            // Return encrypted data    
            return encrypted;
        }

        public static string DecryptByte(byte[] cipherText, byte[] Key, byte[] IV)
        {
            string plaintext = null;
            // Create AesManaged    
            using (AesManaged aes = new AesManaged())
            {
                // Create a decryptor    
                ICryptoTransform decryptor = aes.CreateDecryptor(Key, IV);
                // Create the streams used for decryption.    
                using (MemoryStream ms = new MemoryStream(cipherText))
                {
                    // Create crypto stream    
                    using (CryptoStream cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
                    {
                        // Read crypto stream    
                        using (StreamReader reader = new StreamReader(cs))
                            plaintext = reader.ReadToEnd();
                    }
                }
            }
            return plaintext;
        }

        public static string Encrypt(string text)
        {

            return text;
        }
    }
}
