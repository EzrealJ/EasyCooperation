using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace EasyCooperation.Abstraction.Security.Irreversible
{
    public class SHA1
    {
        public static byte[] SHA1HashEncrypt(string input, string encoding = "UTF-8")
        {
           return SHA1HashEncrypt(input, Encoding.GetEncoding(encoding));
        }
        public static byte[] SHA1HashEncrypt(string input, Encoding encoding)
        {
            using (SHA1CryptoServiceProvider sha1 = new SHA1CryptoServiceProvider())
            {
                return sha1.ComputeHash(encoding.GetBytes(input));
            }
        }

        public static string SHA1HashEncryptBase64(string input, string encoding = "UTF-8")
        {
            return Convert.ToBase64String(SHA1HashEncrypt(input, encoding));
        }
        public static string SHA1HashEncryptBase64(string input, Encoding encoding)
        {
            return Convert.ToBase64String(SHA1HashEncrypt(input, encoding));
        }
        public static string SHA1HashEncryptHex(string input, Encoding encoding)
        {
            IEnumerable<string> stringEnumerable = SHA1HashEncrypt(input, encoding)?.Select(b => Convert.ToString(b, 16).PadLeft(2, '0'));
            return string.Join(string.Empty, stringEnumerable);
        }
        public static string SHA1HashEncryptHex(string input, string encoding = "UTF-8")
        {
            IEnumerable<string> stringEnumerable = SHA1HashEncrypt(input, encoding)?.Select(b => Convert.ToString(b, 16).PadLeft(2, '0'));
            return string.Join(string.Empty, stringEnumerable);
        }

        public static byte[] SHA1HashEncrypt(Stream stream)
        {
            SHA1CryptoServiceProvider sha1 = new SHA1CryptoServiceProvider();
            return sha1.ComputeHash(stream);
        }
        public static string SHA1HashEncryptBase64(Stream stream)
        {

            return Convert.ToBase64String(SHA1HashEncrypt(stream));
        }

        public static string SHA1HashEncryptHex(Stream stream)
        {
            IEnumerable<string> stringEnumerable = SHA1HashEncrypt(stream)?.Select(b => Convert.ToString(b, 16).PadLeft(2, '0'));
            return string.Join(string.Empty, stringEnumerable);
        }
    }
}
