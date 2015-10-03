using System;
using System.IO;
using System.Security.Cryptography;
using Crc32C;

namespace EduFormManager.Utilities
{
    public class FileUtility
    {
        private static DESCryptoServiceProvider _des = new DESCryptoServiceProvider();
        private static byte[] _key = GetKeyFromFile("./key");
        public static byte[] GetKeyFromFile(string path)
        {
            byte[] key = null;
            if (File.Exists(path))
            {
                key = File.ReadAllBytes(path);
                _des.Key = key;
                _des.IV = key;
            }
            else
            {
                key = _des.Key;
                File.WriteAllBytes(path, key);
            }
            return key;
        }

        public static void EncryptFile(string inputPath, string outputPath, byte[] key = null)
        {
            if (key != null)
            {
                _des.Key = key;
                _des.IV = key;
            }
            else
            {
                _des.Key = _key;
                _des.IV = _key;
            }
        
            using (FileStream ifs = File.OpenRead(inputPath))
            using (FileStream ofs = File.OpenWrite(outputPath))
            {
                ICryptoTransform desEncrypt = _des.CreateEncryptor();
                using (CryptoStream cs = new CryptoStream(ofs, desEncrypt, CryptoStreamMode.Write))
                {
                    byte[] input = new byte[ifs.Length - 1];
                    ifs.Read(input, 0, input.Length);
                    cs.Write(input, 0, input.Length);
                }
            }
        }

        public static void DecryptFile(string inputPath, string outputPath, byte[] key = null)
        {
            if (key != null)
            {
                _des.Key = key;
                _des.IV = key;
            }
            else
            {
                _des.Key = _key;
                _des.IV = _key;
            }

            using (FileStream ifs = new FileStream(inputPath, FileMode.Open, FileAccess.Read))
            {
                ICryptoTransform desdecrypt = _des.CreateDecryptor();
                using(CryptoStream cs = new CryptoStream(ifs, desdecrypt, CryptoStreamMode.Read))
                using (StreamWriter sw = new StreamWriter(outputPath))
                {
                    
                    sw.Write(new StreamReader(cs).ReadToEnd());
                }
            }
        }

        public static string GetDecryptedPath(string path)
        {
            string pathDecrypted = Path.GetTempFileName();
            DecryptFile(path, pathDecrypted);
            return pathDecrypted;
        }

        public static string GetCRC32AsHexString(string path)
        {
            if (!File.Exists(path))
            { 
                throw new FileNotFoundException();
            }
            byte[] array = File.ReadAllBytes(path);
            uint crc = Crc32CAlgorithm.Compute(array);
            return crc.ToString("X");
            
        }

        public static string GetCRC32AsHexString(byte[] data)
        {
            return data != null ? Crc32CAlgorithm.Compute(data).ToString("X") : String.Empty;
        }
    }
}
