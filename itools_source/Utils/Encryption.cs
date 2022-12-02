using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace itools_source.Utils
{
    public class Encryption
    {
        private static log4net.ILog _log = log4net.LogManager.GetLogger(typeof(Encryption).Name);
        private readonly static byte[] _byKey = Encoding.UTF8.GetBytes("MZygpewJsCdr4a1y");
        private readonly static byte[] _byIV = Encoding.UTF8.GetBytes("MZygpewJsCpRrfOr");

        public static string StrEncrypt(string _strText)
        {
            try
            {
                //byte[] _byIV = new byte[16];
                byte[] _byArray;

                using (Aes _aes = Aes.Create())
                {
                    _aes.Key = _byKey;
                    _aes.IV = _byIV;

                    ICryptoTransform _encryptor = _aes.CreateEncryptor(_aes.Key, _aes.IV);
                    using (MemoryStream _ms = new MemoryStream())
                    {
                        using (CryptoStream _cryptoStream = new CryptoStream(_ms, _encryptor, CryptoStreamMode.Write))
                        {
                            using (StreamWriter _streamWriter = new StreamWriter(_cryptoStream))
                            {
                                _streamWriter.Write(_strText);
                            }
                            _byArray = _ms.ToArray();
                        }
                    }
                }
                return Convert.ToBase64String(_byArray);
            }
            catch (Exception e)
            {
                _log.Error(_strText);
                _log.Error(e.Message);
            }
            return null;
        }

        public static string StrDecrypt(string _strText)
        {
            try
            {
                //byte[] _byIV = new byte[16];
                byte[] _byBuffer = Convert.FromBase64String(_strText);

                using (Aes _aes = Aes.Create())
                {
                    _aes.Key = _byKey;
                    _aes.IV = _byIV;
                    ICryptoTransform _decryptor = _aes.CreateDecryptor(_aes.Key, _aes.IV);
                    using (MemoryStream _ms = new MemoryStream(_byBuffer))
                    {
                        using (CryptoStream _cryptoStream = new CryptoStream(_ms, _decryptor, CryptoStreamMode.Read))
                        {
                            using (StreamReader _sr = new StreamReader(_cryptoStream))
                            {
                                return _sr.ReadToEnd();
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                _log.Error(_strText);
                _log.Error(e.Message);
            }
            return null;
        }

        public static string CreateMD5(string strInput)
        {
            if (string.IsNullOrEmpty(strInput))
            {
                throw new ArgumentNullException("Input CreateMD5");
            }

            strInput = strInput + "@Vinam@123";
            // Use input string to calculate MD5 hash
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(strInput);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Convert the byte array to hexadecimal string
                StringBuilder strHex = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    strHex.Append(hashBytes[i].ToString("X2"));
                }
                return strHex.ToString();
            }
        }
    }
}
