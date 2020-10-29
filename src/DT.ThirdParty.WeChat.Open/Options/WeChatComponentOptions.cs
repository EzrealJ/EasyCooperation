using System;
using System.Collections.Generic;
using System.Text;

namespace EasyCooperation.WeChat.ThirdPartyPlatforms.Options
{
    public class WeChatComponentOptions
    {
        public const string WeChatComponent = "WeChatComponent";
        public string AppId { get; set; }
        public string AppSecret { get; set; }
        public string EncodingAESKey { get; set; }
        public string Token { get; set; }
    }
}
