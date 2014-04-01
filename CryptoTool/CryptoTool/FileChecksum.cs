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
            string hash = "";
            using (FileStream fs = new FileStream(filePath, FileMode.Open))
            using (BufferedStream bs = new BufferedStream(fs))
            {
                switch (hashType)
                {
                    case "MD5":
                        hash = cryptoHash(new MD5CryptoServiceProvider(), bs);
                        break;
                    case "SHA1":
                        hash = cryptoHash(new SHA1CryptoServiceProvider(), bs);
                        break;
                    case "SHA256":
                        hash = cryptoHash(new SHA256CryptoServiceProvider(), bs);
                        break;
                    case "SHA384":
                        hash = cryptoHash(new SHA384CryptoServiceProvider(), bs);
                        break;
                    case "SHA512":
                        hash = cryptoHash(new SHA512CryptoServiceProvider(), bs);
                        break;
                }
                return hash;
            }

        }

        private static string cryptoHash(MD5CryptoServiceProvider cryptoProvider, BufferedStream bs)
        {
            using ((IDisposable)cryptoProvider)
            {
                return (BitConverter.ToString(cryptoProvider.ComputeHash(bs)));
            }
        }

        private static string cryptoHash(SHA1CryptoServiceProvider cryptoProvider, BufferedStream bs)
        {
            using ((IDisposable)cryptoProvider)
            {
                return (BitConverter.ToString(cryptoProvider.ComputeHash(bs)));
            }
        }

        private static string cryptoHash(SHA256CryptoServiceProvider cryptoProvider, BufferedStream bs)
        {
            using ((IDisposable)cryptoProvider)
            {
                return (BitConverter.ToString(cryptoProvider.ComputeHash(bs)));
            }
        }

        private static string cryptoHash(SHA384CryptoServiceProvider cryptoProvider, BufferedStream bs)
        {
            using ((IDisposable)cryptoProvider)
            {
                return (BitConverter.ToString(cryptoProvider.ComputeHash(bs)));
            }
        }

        private static string cryptoHash(SHA512CryptoServiceProvider cryptoProvider, BufferedStream bs)
        {
            using ((IDisposable)cryptoProvider)
            {
                return (BitConverter.ToString(cryptoProvider.ComputeHash(bs)));
            }
        }
    }
}
