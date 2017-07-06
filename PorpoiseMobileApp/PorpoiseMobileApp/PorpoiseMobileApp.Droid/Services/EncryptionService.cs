using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using PorpoiseMobileApp.Services;
using System.Security.Cryptography;
using System.IO;

namespace PorpoiseMobileApp.Droid.Services
{
    public class EncryptionService : IEncryptionService
    {

        private static readonly byte[] salt = Encoding.ASCII.GetBytes("FSDjiovnx35r89kmndvxvSE341vnkSEdvxkA");
        private static readonly string encryptionPassword = "898fsAfnzjt812GScvxnSXB57ScbajQW45XDFddsdsc";

        #region IEncryptionService implementation

        public string Encrypt(string value)
        {
            var algorithm = GetAlgorithm();

            //Anything to process?
            if (string.IsNullOrEmpty(value))
            {
                return string.Empty;
            }

            byte[] encryptedBytes;
            using (ICryptoTransform encryptor = algorithm.CreateEncryptor(algorithm.Key, algorithm.IV))
            {
                byte[] bytesToEncrypt = Encoding.UTF8.GetBytes(value);
                encryptedBytes = InMemoryCrypt(bytesToEncrypt, encryptor);
            }
            return Convert.ToBase64String(encryptedBytes);
        }

        public string Decrypt(string value)
        {
            var algorithm = GetAlgorithm();

            //Anything to process?
            if (string.IsNullOrEmpty(value))
            {
                return string.Empty;
            }

            byte[] descryptedBytes;
            using (ICryptoTransform decryptor = algorithm.CreateDecryptor(algorithm.Key, algorithm.IV))
            {
                byte[] encryptedBytes = Convert.FromBase64String(value);
                descryptedBytes = InMemoryCrypt(encryptedBytes, decryptor);
            }
            return Encoding.UTF8.GetString(descryptedBytes);
        }

        /// <summary>
        /// Performs an in-memory encrypt/decrypt transformation on a byte array.
        /// </summary>
        /// <returns>The memory crypt.</returns>
        /// <param name="data">Data.</param>
        /// <param name="transform">Transform.</param>
        private static byte[] InMemoryCrypt(byte[] data, ICryptoTransform transform)
        {
            var memory = new MemoryStream();
            using (Stream stream = new CryptoStream(memory, transform, CryptoStreamMode.Write))
            {
                stream.Write(data, 0, data.Length);
            }
            return memory.ToArray();
        }


        /// <summary>
        /// Defines a RijndaelManaged algorithm and sets its key and Initialization Vector (IV)
        /// </summary>
        /// <returns>The algorithm.</returns>
        private static RijndaelManaged GetAlgorithm()
        {
            // Create an encryption key from the encryptionPassword and salt.
            var key = new Rfc2898DeriveBytes(encryptionPassword, salt);

            // Declare that we are going to use the Rijndael algorithm with the key that we've just got.
            var algorithm = new RijndaelManaged();
            int bytesForKey = algorithm.KeySize / 8;
            int bytesForIV = algorithm.BlockSize / 8;
            algorithm.Key = key.GetBytes(bytesForKey);
            algorithm.IV = key.GetBytes(bytesForIV);
            return algorithm;
        }

        #endregion



    }
}