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
        private readonly static byte[] _StrKey = new byte[32];

        public static string _strEncrypt(string _StrText)
        {
            byte[] _ByIV = new byte[16];
            byte[] _ByArray;

            using (Aes _aes = Aes.Create())
            {
                _aes.Key = _StrKey;
                _aes.IV = _ByIV;
                
                ICryptoTransform _encryptor = _aes.CreateEncryptor(_aes.Key, _aes.IV);
                using (MemoryStream _ms = new MemoryStream())
                {
                    using (CryptoStream _cryptoStream = new CryptoStream(_ms, _encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter _streamWriter = new StreamWriter(_cryptoStream))
                        {
                            _streamWriter.Write(_StrText);
                        }
                        _ByArray = _ms.ToArray();
                    }
                }
            }
            return Convert.ToBase64String(_ByArray);
        }

        public static string strDecrypt(string _StrText)
        {
            byte[] _ByIV = new byte[16];
            byte[] _ByBuffer = Convert.FromBase64String(_StrText);

            using (Aes _aes = Aes.Create())
            {
                _aes.Key = _StrKey;
                _aes.IV = _ByIV;
                ICryptoTransform _decryptor = _aes.CreateDecryptor(_aes.Key, _aes.IV);
                using (MemoryStream _ms = new MemoryStream(_ByBuffer))
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
