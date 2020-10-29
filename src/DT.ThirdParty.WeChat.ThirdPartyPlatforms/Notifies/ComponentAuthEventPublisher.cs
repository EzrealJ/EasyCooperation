using System;
using System.Collections.Generic;
using System.Text;
using EasyCooperation.Abstraction.Attributes;
using EasyCooperation.Abstraction.Enums;
using EasyCooperation.Abstraction.Exceptions;
using EasyCooperation.Abstraction.Extensions.Notifies.Models;
using EasyCooperation.WeChat.ThirdPartyPlatforms.Notifies.Models;
using EasyCooperation.WeChat.ThirdPartyPlatforms.Options;
using EasyCooperation.WeChat.ThirdPartyPlatforms.Security;
using EasyCooperation.WeChat.ThirdPartyPlatforms.Signature;
using Microsoft.Extensions.Options;

namespace EasyCooperation.WeChat.ThirdPartyPlatforms.Notifies
{
    public class ComponentAuthEventPublisher : IComponentAuthEventNotify
    {
        private readonly IOptionsSnapshot<WeChatComponentOptions> _optionsSnapshotOfWeChatComponentOptions;
        private readonly WeChatTokenSignerProvider _tokenSignerProvider;
        private readonly ComponentAuthEventDecryptor _componentAuthEventDecryptor;

        public ComponentAuthEventPublisher(IOptionsSnapshot<WeChatComponentOptions> optionsSnapshotOfWeChatComponentOptions, WeChatTokenSignerProvider tokenSignerProvider, ComponentAuthEventDecryptor componentAuthEventDecryptor)
        {
            _optionsSnapshotOfWeChatComponentOptions = optionsSnapshotOfWeChatComponentOptions;
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
            string signature = _tokenSignerProvider.SignWithToken(_optionsSnapshotOfWeChatComponentOptions.Value.Token, timestamp, nonce, componentNotifyModel.Encrypt?.Trim());
            if (msg_signature != signature)
            {
                throw new SignException("校验签名失败");
            }
            ComponentNotifyModelDecrypted result = _componentAuthEventDecryptor.Decrypt(componentNotifyModel, new WeChatComponentDecryptorOption()
            {
                EncodingAESKey = _optionsSnapshotOfWeChatComponentOptions.Value.EncodingAESKey
            });
            if (result is ComponentVerifyTicketNotifyModel)
            {
                return ComponentVerifyTicketNotifyHandler(result as ComponentVerifyTicketNotifyModel);
            }
            return null;
        }
    }
}
