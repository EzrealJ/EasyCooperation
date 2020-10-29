using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Xml;
using EasyCooperation.Abstraction.Notifies.Models;
using EasyCooperation.Abstraction.Security;
using EasyCooperation.WeChat.ThirdPartyPlatforms.Enums;
using EasyCooperation.WeChat.ThirdPartyPlatforms.Notifies.Models;
using System.Linq;
using System.Security.Cryptography;
using System.IO;
using System.Net;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace EasyCooperation.WeChat.ThirdPartyPlatforms.Security
{
    public class ComponentAuthEventDecryptor : IDecryptor<ComponentNotifyModel, WeChatComponentDecryptorOption, ComponentNotifyModelDecrypted>
    {

        public ComponentNotifyModelDecrypted Decrypt(ComponentNotifyModel @in, WeChatComponentDecryptorOption decryptorOption)
        {
            ComponentNotifyModelDecrypted @out = null;
            int result = TryDecrypt(@in, ref @out, decryptorOption);
            if (((EnumWeChatBizMsgCryptResult)result) == EnumWeChatBizMsgCryptResult.WXBizMsgCrypt_OK)
            {
                return @out;
            }
            return null;
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

            if (decryptorOption.EncodingAESKey.Length != 43)
            {
                return (int)EnumWeChatBizMsgCryptResult.WXBizMsgCrypt_IllegalAesKey;
            }
            byte[] xmlAsBytes;
            try
            {
                xmlAsBytes = Convert.FromBase64String(@in.Encrypt);
            }
            catch (Exception)
            {

                return (int)EnumWeChatBizMsgCryptResult.WXBizMsgCrypt_DecodeBase64_Error;
            }
            byte[] key = Convert.FromBase64String(decryptorOption.EncodingAESKey + "=");
            Array.Copy(key, new byte[16], 16);
            RijndaelManaged rm = new RijndaelManaged
            {
                //秘钥的大小，以位为单位
                KeySize = 256,
                //支持的块大小
                BlockSize = 128,
                //填充模式
                Padding = PaddingMode.None,
                Mode = CipherMode.CBC,
                Key = key,
                IV = (new byte[16])
            };
            ICryptoTransform decrypt = rm.CreateDecryptor(rm.Key, rm.IV);
            byte[] decryptBuff = decrypt.TransformFinalBlock(xmlAsBytes, 0, xmlAsBytes.Length);
            decryptBuff = decode2(decryptBuff);
            int network = BitConverter.ToInt32(decryptBuff, 16);
            int length = IPAddress.NetworkToHostOrder(network);
            byte[] messageBytes = new byte[length];
            Array.Copy(decryptBuff, 16 + 4, messageBytes, 0, length);
            byte[] appidBytes = new byte[decryptBuff.Length - 16 - 4 - length];
            Array.Copy(decryptBuff, 16 + 4 + length, appidBytes, 0, appidBytes.Length);
            string appid = Encoding.UTF8.GetString(appidBytes);
            if (appid != @in.AppId)
            {
                return (int)EnumWeChatBizMsgCryptResult.WXBizMsgCrypt_ValidateAppid_Error;
            }
            string message = Encoding.UTF8.GetString(messageBytes);

            try
            {
                XDocument xml = XDocument.Parse(message);
                XElement bodyDoc = xml.Root;
                string infoType = bodyDoc.Element(nameof(@out.InfoType))?.Value;

                if (infoType == "component_verify_ticket")
                {
                    //声明序列化对象实例serializer
                    XmlSerializer serializer = new XmlSerializer(typeof(ComponentVerifyTicketNotifyModel));
                    //反序列化，并将反序列化结果值赋给变量i
                    @out = serializer.Deserialize(xml.CreateReader()) as ComponentVerifyTicketNotifyModel;

                }
            }
            catch (Exception)
            {
                return (int)EnumWeChatBizMsgCryptResult.WXBizMsgCrypt_ParseXml_Error;
            }
            return 0;
        }

        private static byte[] decode2(byte[] decrypted)
        {
            int pad = (int)decrypted[decrypted.Length - 1];
            if (pad < 1 || pad > 32)
            {
                pad = 0;
            }
            byte[] res = new byte[decrypted.Length - pad];
            Array.Copy(decrypted, 0, res, 0, decrypted.Length - pad);
            return res;
        }
    }
}
