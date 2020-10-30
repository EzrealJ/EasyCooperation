using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace EasyCooperation.Abstraction.Security.Irreversible
{
    public class MD5
    {
        public static byte[] MD5HashEncrypt(string input, string encoding = "UTF-8")
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            return md5.ComputeHash(Encoding.GetEncoding(encoding).GetBytes(input));
        }

        public static string MD5HashEncryptBase64(string input, string encoding = "UTF-8")
        {
            return Convert.ToBase64String(MD5HashEncrypt(input, encoding));
        }
        public static string MD5HashEncryptHex(string input, string encoding = "UTF-8")
        {
            IEnumerable<string> stringEnumerable = MD5HashEncrypt(input, encoding)?.Select(b => Convert.ToString(b, 16).PadLeft(2, '0'));
            return string.Join(string.Empty, stringEnumerable);
        }

        public static byte[] MD5HashEncrypt(Stream stream)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            return md5.ComputeHash(stream);
        }
        public static string MD5HashEncryptBase64(Stream stream)
        {

            return Convert.ToBase64String(MD5HashEncrypt(stream));
        }

        public static string MD5HashEncryptHex(Stream stream)
        {
            IEnumerable<string> stringEnumerable = MD5HashEncrypt(stream)?.Select(b => Convert.ToString(b, 16).PadLeft(2, '0'));
            return string.Join(string.Empty, stringEnumerable);
        }


    }
}
