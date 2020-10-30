using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EasyCooperation.Abstraction.Security.Reversible
{
    public class DES
    {
        /// <summary>
        /// 密钥
        /// </summary>
        public string Key { get; set; }

        /// <summary>
        /// 向量
        /// </summary>
        public string Iv { get; set; }

        public DES(string key, string iv)
        {
            Key = key ?? throw new ArgumentNullException(nameof(key));
            Iv = iv ?? throw new ArgumentNullException(nameof(iv));
        }

        /// <summary>
        /// DES加密
        /// </summary>
        /// <param name="str">未加密字符串</param>
        /// <returns>加密字符串</returns>
        public string EncryptToBase64String(string str)
        {
            byte[] key_bytes = Encoding.UTF8.GetBytes(Key);
            byte[] iv_bytes = Encoding.UTF8.GetBytes(Iv);
            DESCryptoServiceProvider cryptoProvider = new DESCryptoServiceProvider();
            using (MemoryStream ms = new MemoryStream())
            {
                CryptoStream cst = new CryptoStream(ms, cryptoProvider.CreateEncryptor(key_bytes, iv_bytes), CryptoStreamMode.Write);
                StreamWriter sw = new StreamWriter(cst);
                sw.Write(str);
                sw.Flush();
                cst.FlushFinalBlock();
                sw.Flush();
                return Convert.ToBase64String(ms.GetBuffer(), 0, (int)ms.Length);
            }
        }

        /// <summary>
        /// DES解密
        /// </summary>
        /// <param name="desstr">加密的字符串</param>
        /// <returns>未加密的字符串</returns>
        public string DecryptFromBase64String(string desstr)
        {
            byte[] key_bytes = Encoding.UTF8.GetBytes(Key);
            byte[] iv_bytes = Encoding.UTF8.GetBytes(Iv);
            byte[] byEnc;
            try
            {
                byEnc = Convert.FromBase64String(desstr);
            }
            catch
            {
                return null;
            }

            DESCryptoServiceProvider cryptoProvider = new DESCryptoServiceProvider();
            using (MemoryStream ms = new MemoryStream(byEnc))
            {
                CryptoStream cst = new CryptoStream(ms, cryptoProvider.CreateDecryptor(key_bytes, iv_bytes), CryptoStreamMode.Read);
                StreamReader sr = new StreamReader(cst);
                return sr.ReadToEnd();
            }
        }
    }
}
