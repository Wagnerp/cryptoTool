using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Security.Cryptography;

namespace CryptoTool
{
    public static class FileChecksum
    {
        public static string computeChecksum(string hashType, string filePath)
        {
            using (FileStream fs = new FileStream(filePath, FileMode.Open))
            using (BufferedStream bs = new BufferedStream(fs))
            {
                HashAlgorithm hashAlg = findHashAlgorithm(hashType);

                using ((IDisposable)hashAlg)
                {
                    return (BitConverter.ToString(hashAlg.ComputeHash(bs)));
                }
            }
        }

        private static HashAlgorithm findHashAlgorithm(string hashType)
        {
            HashAlgorithm ha;

            switch (hashType)
            {
                case "MD5":
                    ha = new MD5CryptoServiceProvider();
                    break;
                case "SHA1":
                    ha = new SHA1CryptoServiceProvider();
                    break;
                case "SHA256":
                    ha = new SHA256CryptoServiceProvider();
                    break;
                case "SHA384":
                    ha = new SHA384CryptoServiceProvider();
                    break;
                case "SHA512":
                    ha = new SHA512CryptoServiceProvider();
                    break;
                default:
                    ha = new MD5CryptoServiceProvider();
                    break;
            }  
            return ha;
        }
    }
}
