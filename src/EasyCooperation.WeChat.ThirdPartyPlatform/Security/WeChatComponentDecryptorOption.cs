using System;
using System.Collections.Generic;
using System.Text;
using EasyCooperation.Abstraction.Security;

namespace EasyCooperation.WeChat.ThirdPartyPlatform.Security
{
    public class WeChatComponentDecryptorOption : IDecryptorOption
    {
        public string EncodingAESKey { get; set; }
    }
}
