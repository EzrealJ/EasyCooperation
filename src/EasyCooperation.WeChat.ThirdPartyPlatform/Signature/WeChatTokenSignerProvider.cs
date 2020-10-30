using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EasyCooperation.Abstraction.Exceptions;
using EasyCooperation.Abstraction.Signature;

namespace EasyCooperation.WeChat.ThirdPartyPlatform.Signature
{
    public class WeChatTokenSignerProvider : ISignerProvider
    {
        public bool TrySignWithToken(string token, string timeStamp, string nonce, string msg, ref string signature)
        {
            try
            {
                signature = SignWithToken(token, timeStamp, nonce, msg);
            }
            catch (Exception)
            {

                return false;
            }
            return true;
        }

        public string SignWithToken(string token, string timeStamp, string nonce, string msg)
        {
            string signature;
            List<string> list = new List<string>();
            list.Add(token);
            list.Add(timeStamp);
            list.Add(nonce);
            list.Add(msg);
            list.Sort();
            string raw = list.Aggregate(new StringBuilder(), (current, t) => current.Append(t))?.ToString();
            string hash = string.Empty;
            try
            {
                hash = Abstraction.Security.Irreversible.SHA1.SHA1HashEncryptHex(raw, Encoding.ASCII)?.ToLower();
            }
            catch (Exception)
            {
                throw new SignException("签名计算错误");
            }
            signature = hash;
            return signature;
        }
    }
}
