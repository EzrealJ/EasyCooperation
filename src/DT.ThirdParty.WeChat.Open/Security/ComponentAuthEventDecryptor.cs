using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Xml;
using EasyCooperation.Abstraction.Notifies.Models;
using EasyCooperation.Abstraction.Security;
using EasyCooperation.WeChat.Open.Enums;
using EasyCooperation.WeChat.Open.Notifies.Models;
using System.Linq;
using System.Security.Cryptography;
using System.IO;
using System.Net;

namespace EasyCooperation.WeChat.Open.Security
{
    public class ComponentAuthEventDecryptor : IDecryptor<ComponentNotifyModel, WeChatComponentDecryptorOption, ComponentNotifyModelDecrypted>
    {
        private readonly string _appId;
        private readonly string _encodingAESKey;
        private readonly string _token;

        public ComponentAuthEventDecryptor(string appId, string encodingAESKey, string token)
        {
            if (string.IsNullOrEmpty(appId))
            {
                throw new ArgumentException($"“{nameof(appId)}”不能是 Null 或为空。", nameof(appId));
            }

            if (string.IsNullOrEmpty(encodingAESKey))
            {
                throw new ArgumentException($"“{nameof(encodingAESKey)}”不能是 Null 或为空。", nameof(encodingAESKey));
            }

            if (string.IsNullOrEmpty(token))
            {
                throw new ArgumentException($"“{nameof(token)}”不能是 Null 或为空。", nameof(token));
            }
            _appId = appId;
            _encodingAESKey = encodingAESKey;
            _token = token;
        }



        public ComponentNotifyModelDecrypted Decrypt(ComponentNotifyModel @in, WeChatComponentDecryptorOption decryptorOption)
        {

        }

        public int TryDecrypt(ComponentNotifyModel @in, ref ComponentNotifyModelDecrypted @out, WeChatComponentDecryptorOption decryptorOption)
        {
            if (@in is null)
            {
                throw new ArgumentNullException(nameof(@in));
            }

            if (decryptorOption is null)
            {
                throw new ArgumentNullException(nameof(decryptorOption));
            }

            if (_encodingAESKey.Length != 43)
            {
                return (int)EnumWeChatBizMsgCryptResult.WXBizMsgCrypt_IllegalAesKey;
            }
            byte[] xmlAsBytes = Convert.FromBase64String(@in.Encrypt);
            byte[] key = Convert.FromBase64String(decryptorOption.EncodingAESKey + "=");
            Array.Copy(key, new byte[16], 16);
            RijndaelManaged rm = new RijndaelManaged
            {
                //秘钥的大小，以位为单位
                KeySize = 256,
                //支持的块大小
                BlockSize = 128,
                //填充模式
                Padding = PaddingMode.PKCS7,
                Mode = CipherMode.CBC,
                Key = key,
                IV = (new byte[16])
            };
            ICryptoTransform decrypt = rm.CreateDecryptor(rm.Key, rm.IV);
            byte[] decryptBuff = decrypt.TransformFinalBlock(xmlAsBytes, 0, xmlAsBytes.Length);
            int network = BitConverter.ToInt32(decryptBuff, 16);
            int length = IPAddress.NetworkToHostOrder(network);
            byte[] messageBytes = new byte[length];
            Array.Copy(decryptBuff, 16 + 4, messageBytes, 0, length);
            byte[] appidBytes = new byte[decryptBuff.Length - 16 - 4 - length];
            Array.Copy(decryptBuff, decryptBuff.Length - 16 - 4 - length, appidBytes, 0, appidBytes.Length);
            string appid = Encoding.UTF8.GetString(appidBytes);
            string message= Encoding.UTF8.GetString(messageBytes);
            return message;


            EnumWeChatBizMsgCryptResult ret = 0;
            ret = VerifySignature(_token, decryptorParameter.Timestamp, decryptorParameter.Nonce, @in.Encrypt, decryptorParameter.Signature);
            if (ret != EnumWeChatBizMsgCryptResult.WXBizMsgCrypt_OK)
            {
                return ret;
            }
            //decrypt
            string cpid = "";
            try
            {
                @out = Cryptography.AES_decrypt(sEncryptMsg, m_sEncodingAESKey, ref cpid);
            }
            catch (FormatException)
            {
                return EnumWeChatBizMsgCryptResult.WXBizMsgCrypt_DecodeBase64_Error;
            }
            catch (Exception)
            {
                return EnumWeChatBizMsgCryptResult.WXBizMsgCrypt_DecryptAES_Error;
            }
            if (cpid != m_sAppID)
                return EnumWeChatBizMsgCryptResult.WXBizMsgCrypt_ValidateAppid_Error;
            return 0;
        }

        //Verify Signature
        private static EnumWeChatBizMsgCryptResult VerifySignature(string token, string timeStamp, string nonce, string msg, string signature)
        {
            string hash = "";
            EnumWeChatBizMsgCryptResult ret = 0;
            ret = TryGenarateSinature(token, timeStamp, nonce, msg, ref hash);
            if (ret != EnumWeChatBizMsgCryptResult.WXBizMsgCrypt_OK)
                return ret;
            if (hash == signature)
                return 0;
            else
            {
                return EnumWeChatBizMsgCryptResult.WXBizMsgCrypt_ValidateSignature_Error;
            }
        }

        public static EnumWeChatBizMsgCryptResult TryGenarateSinature(string token, string timeStamp, string nonce, string msg, ref string signature)
        {
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
                return EnumWeChatBizMsgCryptResult.WXBizMsgCrypt_ComputeSignature_Error;
            }
            signature = hash;
            return EnumWeChatBizMsgCryptResult.WXBizMsgCrypt_OK;
        }
    }
}
