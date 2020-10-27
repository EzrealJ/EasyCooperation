using System;
using System.Collections.Generic;
using System.Text;
using EasyCooperation.Abstraction.Attributes;
using EasyCooperation.Abstraction.Enums;
using EasyCooperation.Abstraction.Exceptions;
using EasyCooperation.WeChat.Open.Notifies.Models;
using EasyCooperation.WeChat.Open.Options;
using EasyCooperation.WeChat.Open.Signature;

namespace EasyCooperation.WeChat.Open.Notifies
{
    public class ComponentAuthEventPublisher : IComponentAuthEventNotify
    {
        private readonly WeChatComponentOptions _componentOptions;
        private readonly WeChatTokenSignerProvider _tokenSignerProvider;

        public ComponentAuthEventPublisher(WeChatComponentOptions componentOptions, WeChatTokenSignerProvider tokenSignerProvider)
        {
            _componentOptions = componentOptions;
            _tokenSignerProvider = tokenSignerProvider;
        }

        public string AuthEventNotify(
            string msg_signature,
            string timestamp,
            string nonce,
            ComponentNotifyModel componentNotifyModel)
        {
            string signature = _tokenSignerProvider.SignWithToken(_componentOptions.Token, timestamp, nonce, componentNotifyModel.Encrypt);
            if(msg_signature!=signature)
            {
                throw new SignException("校验签名失败");
            }
        }
    }
}
