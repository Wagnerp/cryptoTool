using System;
using System.IO;
using System.Security;
using System.Security.Cryptography;
using System.Runtime.InteropServices;
using System.Text;

namespace CryptoTool
{
    public static class FileEncryption
    {
        /*DES
        TripleDES
        RC2
        Rijndael
        RSA
        DSA
        */

        //  Call this function to remove the key from memory after use for security
        [System.Runtime.InteropServices.DllImport("KERNEL32.DLL", EntryPoint = "RtlZeroMemory")]
        public static extern bool ZeroMemory(IntPtr Destination, int Length);

        // Function to Generate a 64 bits Key.
        public static string AutoGenerateKey()
        {
            // Create an instance of Symetric Algorithm. Key and IV is generated automatically.
            DESCryptoServiceProvider desCrypto = (DESCryptoServiceProvider)DESCryptoServiceProvider.Create();

            // Use the Automatically generated key for Encryption. 
            return ASCIIEncoding.ASCII.GetString(desCrypto.Key);
        }

        public static void EncryptFile(string sInputFilename, string sOutputFilename, string secretKey)
        {
            // For additional security Pin the key.
            GCHandle gch = GCHandle.Alloc(secretKey, GCHandleType.Pinned);

            using (FileStream fsInput = new FileStream(sInputFilename,
                FileMode.Open,
                FileAccess.Read))
            {
                byte[] bytearrayinput = new byte[fsInput.Length - 1];
                fsInput.Read(bytearrayinput, 0, bytearrayinput.Length);


                using (FileStream fsEncrypted = new FileStream(sOutputFilename,
                                    FileMode.OpenOrCreate,
                                    FileAccess.Write))
                {

                    DESCryptoServiceProvider DES = new DESCryptoServiceProvider();

                    DES.Key = ASCIIEncoding.ASCII.GetBytes(secretKey);
                    DES.IV = ASCIIEncoding.ASCII.GetBytes(secretKey);

                    ICryptoTransform desencrypt = DES.CreateEncryptor();
                    using (CryptoStream cryptostream = new CryptoStream(fsEncrypted,
                                        desencrypt,
                                        CryptoStreamMode.Write))
                    {
                        cryptostream.Write(bytearrayinput, 0, bytearrayinput.Length);

                        cryptostream.Close();
                        fsInput.Close();
                    }
                }
            }

            // Remove the Key from memory. 
            ZeroMemory(gch.AddrOfPinnedObject(), secretKey.Length * 2);
            gch.Free();

            //// For additional security Pin the key.
            //GCHandle gch = GCHandle.Alloc(secretKey, GCHandleType.Pinned);

            //using(FileStream fsInput = new FileStream(sInputFilename,
            //    FileMode.Open,
            //    FileAccess.Read))
            //{

            //    using (FileStream fsEncrypted = new FileStream(sOutputFilename,
            //                    FileMode.OpenOrCreate,
            //                    FileAccess.Write))
            //    {

            //        DESCryptoServiceProvider DES = new DESCryptoServiceProvider();

            //        DES.Key = ASCIIEncoding.ASCII.GetBytes(secretKey);
            //        DES.IV = ASCIIEncoding.ASCII.GetBytes(secretKey);

            //        ICryptoTransform desencrypt = DES.CreateEncryptor();
            //        CryptoStream cryptostream = new CryptoStream(fsEncrypted,
            //                            desencrypt,
            //                            CryptoStreamMode.Write);

            //        byte[] bytearrayinput = new byte[fsInput.Length - 1];
            //        fsInput.Read(bytearrayinput, 0, bytearrayinput.Length);
            //        cryptostream.Write(bytearrayinput, 0, bytearrayinput.Length);

            //        cryptostream.Close();
            //        fsInput.Close();
            //    }
            //}
            //// Remove the Key from memory. 
            //ZeroMemory(gch.AddrOfPinnedObject(), secretKey.Length * 2);
            //gch.Free();
        }

        public static void DecryptFile(string sInputFilename, string sOutputFilename, string secretKey)
        {
            // For additional security Pin the key.
            GCHandle gch = GCHandle.Alloc(secretKey, GCHandleType.Pinned);

            DESCryptoServiceProvider DES = new DESCryptoServiceProvider();
            //A 64 bit key and IV is required for this provider.
            //Set secret key For DES algorithm.
            DES.Key = ASCIIEncoding.ASCII.GetBytes(secretKey);
            //Set initialization vector.
            DES.IV = ASCIIEncoding.ASCII.GetBytes(secretKey);

            //Create a file stream to read the encrypted file back.
            using (FileStream fsread = new FileStream(sInputFilename,
                                            FileMode.Open,
                                            FileAccess.Read))
            {
                //Create a DES decryptor from the DES instance.
                ICryptoTransform desdecrypt = DES.CreateDecryptor();
                //Create crypto stream set to read and do a 
                //DES decryption transform on incoming bytes.
                using (CryptoStream cryptostreamDecr = new CryptoStream(fsread,
                                                                desdecrypt,
                                                                CryptoStreamMode.Read))
                {
                    string encryptedData = "";
                    //Print the contents of the decrypted file.
                    using (StreamReader internalCryptoStreamReader = new StreamReader(cryptostreamDecr))
                    {
                        encryptedData = (internalCryptoStreamReader.ReadToEnd());
                        internalCryptoStreamReader.Close();
                    }

                    using (StreamWriter fsDecrypted = new StreamWriter(sOutputFilename))
                    {
                        fsDecrypted.Write(encryptedData);
                        fsDecrypted.Flush();
                        fsDecrypted.Close();
                    }
                }

                fsread.Close();
            }

            // Remove the Key from memory. 
            ZeroMemory(gch.AddrOfPinnedObject(), secretKey.Length * 2);
            gch.Free();


            //DESCryptoServiceProvider DES = new DESCryptoServiceProvider();
            ////A 64 bit key and IV is required for this provider.
            ////Set secret key For DES algorithm.
            //DES.Key = ASCIIEncoding.ASCII.GetBytes(secretKey);
            ////Set initialization vector.
            //DES.IV = ASCIIEncoding.ASCII.GetBytes(secretKey);

            ////Create a file stream to read the encrypted file back.
            //using (FileStream fsread = new FileStream(sInputFilename,
            //                               FileMode.Open,
            //                               FileAccess.Read))
            //{
            //    //Create a DES decryptor from the DES instance.
            //    ICryptoTransform desdecrypt = DES.CreateDecryptor();
            //    //Create crypto stream set to read and do a 
            //    //DES decryption transform on incoming bytes.
            //    using (CryptoStream cryptostreamDecr = new CryptoStream(fsread,
            //                                                 desdecrypt,
            //                                                 CryptoStreamMode.Read))
            //    {
            //        string encryptedData = "";
            //        //Print the contents of the decrypted file.
            //        using(StreamReader internalCryptoStreamReader = new StreamReader(cryptostreamDecr))
            //        {
            //            encryptedData = (internalCryptoStreamReader.ReadToEnd());
            //            internalCryptoStreamReader.Close();
            //        }

            //        using (StreamWriter fsDecrypted = new StreamWriter(sOutputFilename))
            //        {
            //            fsDecrypted.Write(encryptedData);
            //            fsDecrypted.Flush();
            //            fsDecrypted.Close();
            //        }
            //    }

            //    fsread.Close();
            //}
            
        }
    }
}
