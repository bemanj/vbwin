
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Security.Cryptography;

//namespace Cipher
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            var readkey = Console.ReadLine();
//            var readPassword = Console.ReadLine();

//            Console.WriteLine(new Cryption.Cryption().EncryptString(Cryption.Cryption.CryptographyProvider.TriDES, readPassword, readkey));
//            Console.ReadKey();
//        }
//    }
//}

namespace Cryption
{
    public class Cryption
    {
        const PaddingMode defaultPadding = PaddingMode.PKCS7;
        const CipherMode defaultMode = CipherMode.ECB;
        const string defaultKey = "P@$sW0r6";

        private byte[] keyString;
        private byte[] valueEncryptString;
        private byte[] valueDecryptString;
        private byte[] IVString;

        private TripleDESCryptoServiceProvider crypterTriDES;
        private RijndaelManaged crypterRijndael;
        private DESCryptoServiceProvider crypterDES;
        private CryptographyProvider cryptionProvider;
        private CryptoStream EncryptionStream;
        private CryptoStream DecryptionStream;

        public Cryption()
        {
            crypterDES = new DESCryptoServiceProvider();
            crypterRijndael = new RijndaelManaged();
            crypterTriDES = new TripleDESCryptoServiceProvider();
        }

        #region File Encryption and Decryption

        public void EncryptFile(CryptographyProvider CryptionProvider, string FileToEncrypt, string EncryptedFileDestination)
        {
            try {
                cryptionProvider = CryptionProvider;
                doFileEncryption(FileToEncrypt, EncryptedFileDestination, defaultKey); }
            catch (Exception e) { 
                throw e; }
        }

        public void EncryptFile(CryptographyProvider CryptionProvider, string FileToEncrypt, string EncryptedFileDestination, string KeyToEncryption)
        {
            try {
                cryptionProvider = CryptionProvider;
                doFileEncryption(FileToEncrypt, EncryptedFileDestination, KeyToEncryption); }
            catch (Exception e) { 
                throw e; }
        }

        public void DecryptFile(CryptographyProvider CryptionProvider, string FileToEncrypt, string EncryptedFileDestination)
        {
            try
            {
                cryptionProvider = CryptionProvider;
                doFileDecryption(FileToEncrypt, EncryptedFileDestination, defaultKey);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void DecryptFile(CryptographyProvider CryptionProvider, string FileToEncrypt, string EncryptedFileDestination, string KeyToEncryption)
        {
            try
            {
                cryptionProvider = CryptionProvider;
                doFileDecryption(FileToEncrypt, EncryptedFileDestination, KeyToEncryption);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        #endregion

        #region String Encryption and Decryption

        public string EncryptString(CryptographyProvider CryptionProvider, string StringToEncrypt)
        {
            try {
                cryptionProvider = CryptionProvider;
                return doEncryptString(StringToEncrypt, defaultKey, defaultPadding, defaultMode);
            }
            catch (Exception e) {
                throw e; }
        }

        public string EncryptString(CryptographyProvider CryptionProvider, string StringToEncrypt, string KeyToEncryption)
        {
            try {
                cryptionProvider = CryptionProvider;
                return doEncryptString(StringToEncrypt, KeyToEncryption, defaultPadding, defaultMode);
            }
            catch (Exception e) { 
                throw e; }
        }

        public string EncryptString(CryptographyProvider CryptionProvider, string StringToEncrypt, string KeyToEncryption, PaddingMode Padding, CipherMode Mode)
        {
            try
            {
                cryptionProvider = CryptionProvider;
                return doEncryptString(StringToEncrypt, KeyToEncryption, Padding, Mode);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public string DecryptString(CryptographyProvider CryptionProvider, string StringToDecrypt)
        {
            try
            {
                cryptionProvider = CryptionProvider;
                return doDecryptString(StringToDecrypt, defaultKey, defaultPadding, defaultMode);
            }
            catch (Exception e)
            {
                throw e;
            }
        }    

        public string DecryptString(CryptographyProvider CryptionProvider, string StringToDecrypt, string KeyToEncryption)
        {
            try
            {
                cryptionProvider = CryptionProvider;
                return doDecryptString(StringToDecrypt, KeyToEncryption, defaultPadding, defaultMode);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public string DecryptString(CryptographyProvider CryptionProvider, string StringToDecrypt, string KeyToEncryption, PaddingMode Padding, CipherMode Mode)
        {
            try
            {
                cryptionProvider = CryptionProvider;
                return doDecryptString(StringToDecrypt, KeyToEncryption, Padding, Mode);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        #endregion

        public enum CryptographyProvider
        {
            TriDES = 0,
            DES = 1,
            Rijndael = 2
        }

        private ICryptoTransform doEncryptTransform()
        {
            switch (cryptionProvider)
            {
                case CryptographyProvider.TriDES:
                    return crypterTriDES.CreateEncryptor();
                case CryptographyProvider.Rijndael:
                    return crypterRijndael.CreateEncryptor();
                case CryptographyProvider.DES:
                    return crypterDES.CreateEncryptor();
                default:
                    return null;
            }
        }

        private ICryptoTransform doDecryptTransform()
        {
            switch (cryptionProvider)
            {
                case CryptographyProvider.TriDES:
                    return crypterTriDES.CreateDecryptor();
                case CryptographyProvider.Rijndael:
                    return crypterRijndael.CreateDecryptor();
                case CryptographyProvider.DES:
                    return crypterDES.CreateDecryptor();
                default: return null;
            }
        }

        private void doSetEncryptionStream(string fileDestination)
        {
            switch (cryptionProvider) {
                case CryptographyProvider.TriDES:
                    EncryptionStream = new CryptoStream(new FileStream(fileDestination, FileMode.Create),
                                                        crypterTriDES.CreateEncryptor(keyString, IVString),
                                                        CryptoStreamMode.Write);
                    break;
                case CryptographyProvider.Rijndael:
                    EncryptionStream = new CryptoStream(new FileStream(fileDestination, 
                                                                       FileMode.Create),
                                                        crypterRijndael.CreateEncryptor(keyString, 
                                                                                        IVString),
                                                        CryptoStreamMode.Write);
                    break;
                case CryptographyProvider.DES:
                    EncryptionStream = new CryptoStream(new FileStream(fileDestination, 
                                                                       FileMode.Create),
                                                        crypterDES.CreateEncryptor(keyString, 
                                                                                   IVString),
                                                        CryptoStreamMode.Write);
                    break;
                default:
                    break; }
        }

        private void doSetDecryptionStream(string FileToDecrypt)
        {
            switch (cryptionProvider)
            {
                case CryptographyProvider.TriDES:
                    DecryptionStream = new CryptoStream(new FileStream(FileToDecrypt, 
                                                                       FileMode.Open),
                                                        crypterTriDES.CreateDecryptor(keyString, 
                                                                                      IVString),
                                                        CryptoStreamMode.Read);
                    break;
                case CryptographyProvider.Rijndael:
                    DecryptionStream = new CryptoStream(new FileStream(FileToDecrypt,
                                                                       FileMode.Open),
                                                        crypterRijndael.CreateDecryptor(keyString,
                                                                                        IVString),
                                                        CryptoStreamMode.Read);
                    break;
                case CryptographyProvider.DES:
                    DecryptionStream = new CryptoStream(new FileStream(FileToDecrypt,
                                                                       FileMode.Open),
                                                        crypterDES.CreateDecryptor(keyString,
                                                                                   IVString),
                                                        CryptoStreamMode.Read);
                    break;
                default:
                    break;
            }
        }

        private void doFileEncryption(string FileToEncrypt)
        {
            int data;
            FileStream fileToEncrypt = new FileStream(FileToEncrypt, FileMode.Open);
            while ((data = fileToEncrypt.ReadByte()) != -1) {
                EncryptionStream.WriteByte((byte)data); }
            fileToEncrypt.Close();
            EncryptionStream.Close();
        }

        private void doFileDecryption(string fileDestination)
        {
            int data;
            FileStream decryptedFile = new FileStream(fileDestination, FileMode.Create);
            while ((data = DecryptionStream.ReadByte()) != -1)
            {
                decryptedFile.WriteByte((byte)data);
            }
            decryptedFile.Close();
            DecryptionStream.Close();
        }

        private string decryptedResult(byte[] cTransform)
        {
            return UTF8Encoding.UTF8.GetString(cTransform);
        }

        private string encryptedResult(byte[] cTransform)
        {
            return Convert.ToBase64String(cTransform);
        }

        private void doComputeEncryptionHash(string ValueString, string KeyString)
        {
            switch (cryptionProvider) {
                case CryptographyProvider.DES:
                    keyString = UTF8Encoding.UTF8.GetBytes(KeyString);
                    valueEncryptString = UTF8Encoding.UTF8.GetBytes(ValueString);
                    break;
                case CryptographyProvider.TriDES:
                    keyString = MD5.Create().ComputeHash(UTF8Encoding.UTF8.GetBytes(KeyString));
                    valueEncryptString = UTF8Encoding.UTF8.GetBytes(ValueString);
                    break;
                case CryptographyProvider.Rijndael:
                    keyString = SHA256.Create().ComputeHash(UTF8Encoding.UTF8.GetBytes(KeyString));
                    valueEncryptString = UTF8Encoding.UTF8.GetBytes(ValueString);
                    break;
                default:
                    break; }
        }

        private void doComputeEncryptionHash(string KeyString)
        {
            switch (cryptionProvider)
            {
                case CryptographyProvider.DES:
                    keyString = UTF8Encoding.UTF8.GetBytes(defaultKey);
                    IVString = UTF8Encoding.UTF8.GetBytes(defaultKey);
                    break;
                case CryptographyProvider.TriDES:
                    keyString = MD5.Create().ComputeHash(UTF8Encoding.UTF8.GetBytes(KeyString));
                    IVString = MD5.Create().ComputeHash(UTF8Encoding.UTF8.GetBytes(KeyString));
                    break;
                case CryptographyProvider.Rijndael:
                    keyString = SHA256.Create().ComputeHash(UTF8Encoding.UTF8.GetBytes(KeyString));
                    IVString = MD5.Create().ComputeHash(UTF8Encoding.UTF8.GetBytes(KeyString));
                    break;
                default:
                    break;
            }
        }

        private void doComputeDecryptionHash(string ValueString, string KeyString)
        {
            switch (cryptionProvider)
            {
                case CryptographyProvider.DES:
                    if (keyString.Length <= 8)
                    {
                        keyString = UTF8Encoding.UTF8.GetBytes(KeyString);
                        IVString = UTF8Encoding.UTF8.GetBytes(KeyString);
                        valueDecryptString = Convert.FromBase64String(ValueString);
                        break;
                    }
                    else { throw new Exception("Only accept 64bit algorithm."); }
                case CryptographyProvider.TriDES:
                    keyString = MD5.Create().ComputeHash(UTF8Encoding.UTF8.GetBytes(KeyString));
                    IVString = MD5.Create().ComputeHash(UTF8Encoding.UTF8.GetBytes(KeyString));
                    valueDecryptString = Convert.FromBase64String(ValueString);
                    break;
                case CryptographyProvider.Rijndael:
                    keyString = SHA256.Create().ComputeHash(UTF8Encoding.UTF8.GetBytes(KeyString));
                    IVString = MD5.Create().ComputeHash(UTF8Encoding.UTF8.GetBytes(KeyString));
                    valueDecryptString = Convert.FromBase64String(ValueString);
                    break;
                default:
                    break;
            }
        }

        private void doComputeDecryptionHash(string KeyString)
        {
            switch (cryptionProvider)
            {
                case CryptographyProvider.DES:
                    keyString = UTF8Encoding.UTF8.GetBytes(defaultKey);
                    IVString = UTF8Encoding.UTF8.GetBytes(defaultKey);
                    break;
                case CryptographyProvider.TriDES:
                    keyString = MD5.Create().ComputeHash(UTF8Encoding.UTF8.GetBytes(KeyString));
                    IVString = MD5.Create().ComputeHash(UTF8Encoding.UTF8.GetBytes(KeyString));
                    break;
                case CryptographyProvider.Rijndael:
                    keyString = SHA256.Create().ComputeHash(UTF8Encoding.UTF8.GetBytes(KeyString));
                    IVString = MD5.Create().ComputeHash(UTF8Encoding.UTF8.GetBytes(KeyString));
                    break;
                default:
                    break;
            }
        }

        private void doKeyPaddingCipher(byte[] key, PaddingMode padding, CipherMode cipher)
        {
            switch (cryptionProvider)
            {
                case CryptographyProvider.TriDES:
                    crypterTriDES.Key = key;
                    crypterTriDES.Mode = cipher;
                    crypterTriDES.Padding = padding;
                    break;
                case CryptographyProvider.DES:
                    crypterDES.Key = key;
                    crypterDES.Mode = cipher;
                    crypterDES.Padding = padding;
                    break;
                case CryptographyProvider.Rijndael:
                    crypterRijndael.Key = key;
                    crypterRijndael.Mode = cipher;
                    crypterRijndael.Padding = padding;
                    break;
            }
        }

        #region File Encryption and Decryption

        private void doFileEncryption(string FileToEncrypt, string EncryptedFileDestination, string KeyToEncryption)
        {
            doComputeEncryptionHash(KeyToEncryption);
            doSetEncryptionStream(EncryptedFileDestination);
            doFileEncryption(FileToEncrypt);
        }

        private void doFileDecryption(string FileToDecrypt, string DecryptedFileDestination, string KeyToDecryption)
        {
            doComputeDecryptionHash(KeyToDecryption);
            doSetDecryptionStream(FileToDecrypt);
            doFileDecryption(DecryptedFileDestination);
        }

        #endregion

        #region String Encryption and Decryption

        #region String Decryption

        private string doDecryptString(string StringToDecrypt, string KeyToDecryption, PaddingMode Padding, CipherMode Mode)
        {
            doComputeDecryptionHash(StringToDecrypt, KeyToDecryption);
            doKeyPaddingCipher(keyString, Padding, Mode);
            return decryptedResult(doDecryptTransform().TransformFinalBlock(valueDecryptString, 0, valueDecryptString.Length));
        }

        

        #endregion

        #region String Encryption

        private string doEncryptString(string StringToEncrypt, string KeyToEncryption, PaddingMode Padding, CipherMode Mode)
        {
            doComputeEncryptionHash(StringToEncrypt, KeyToEncryption);
            doKeyPaddingCipher(keyString, Padding, Mode);
            return encryptedResult(doEncryptTransform().TransformFinalBlock(valueEncryptString, 0, valueEncryptString.Length));
        }

        #endregion

        #endregion
    }
}