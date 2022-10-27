using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace itools_source.Utils
{
    public class Encryption
    {
        private readonly static byte[] _byKey = new byte[32];

        public static string StrEncrypt(string _StrText)
        {
            byte[] _byIV = new byte[16];
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
                            _streamWriter.Write(_StrText);
                        }
                        _byArray = _ms.ToArray();
                    }
                }
            }
            return Convert.ToBase64String(_byArray);
        }

        public static string strDecrypt(string _strText)
        {
            byte[] _byIV = new byte[16];
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
    }
}
