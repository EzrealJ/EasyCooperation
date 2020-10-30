using System;
using System.Collections.Generic;
using System.Text;
using EasyCooperation.Abstraction.Attributes;
using EasyCooperation.Abstraction.Enums;
using EasyCooperation.Abstraction.Exceptions;
using EasyCooperation.Abstraction.Extensions.Notifies.Models;
using EasyCooperation.WeChat.ThirdPartyPlatform.Notifies.Models;
using EasyCooperation.WeChat.ThirdPartyPlatform.Options;
using EasyCooperation.WeChat.ThirdPartyPlatform.Security;
using EasyCooperation.WeChat.ThirdPartyPlatform.Signature;
using Microsoft.Extensions.Options;

namespace EasyCooperation.WeChat.ThirdPartyPlatform.Notifies
{
    public class ComponentAuthEventPublisher : IComponentAuthEventNotify
    {
        public WeChatComponentOptions WeChatComponentOptions { get; set; }
        private readonly WeChatTokenSignerProvider _tokenSignerProvider;
        private readonly ComponentAuthEventDecryptor _componentAuthEventDecryptor;

        public ComponentAuthEventPublisher( WeChatTokenSignerProvider tokenSignerProvider, ComponentAuthEventDecryptor componentAuthEventDecryptor)
        {
            _tokenSignerProvider = tokenSignerProvider;
            _componentAuthEventDecryptor = componentAuthEventDecryptor;
        }
        public virtual Func<ComponentVerifyTicketNotifyModel, string> ComponentVerifyTicketNotifyHandler { get; set; }

        public virtual string AuthEventNotify(
            string msg_signature,
            string timestamp,
            string nonce,
            ComponentNotifyModel componentNotifyModel)
        {
            if (string.IsNullOrEmpty(msg_signature))
            {
                throw new ArgumentException($"“{nameof(msg_signature)}”不能是 Null 或为空。", nameof(msg_signature));
            }

            if (string.IsNullOrEmpty(timestamp))
            {
                throw new ArgumentException($"“{nameof(timestamp)}”不能是 Null 或为空。", nameof(timestamp));
            }

            if (string.IsNullOrEmpty(nonce))
            {
                throw new ArgumentException($"“{nameof(nonce)}”不能是 Null 或为空。", nameof(nonce));
            }

            if (componentNotifyModel is null)
            {
                throw new ArgumentNullException(nameof(componentNotifyModel));
            }

            if (WeChatComponentOptions is null)
            {
                throw new ArgumentNullException(nameof(WeChatComponentOptions));
            }
            string signature = _tokenSignerProvider.SignWithToken(WeChatComponentOptions?.Token, timestamp, nonce, componentNotifyModel.Encrypt?.Trim());
            if (msg_signature != signature)
            {
                throw new SignException("校验签名失败");
            }
            ComponentNotifyModelDecrypted result = _componentAuthEventDecryptor.Decrypt(componentNotifyModel, new WeChatComponentDecryptorOption()
            {
                EncodingAESKey = WeChatComponentOptions?.EncodingAESKey
            });
            if (result is ComponentVerifyTicketNotifyModel)
            {
                return ComponentVerifyTicketNotifyHandler(result as ComponentVerifyTicketNotifyModel);
            }
            return null;
        }
    }
}
