using System;
using System.Collections.Generic;
using System.Text;
using EasyCooperation.Abstraction.ApiModels.Request;
using WebApiClient.DataAnnotations;

namespace EasyCooperation.WeChat.OfficialAccount.ApiModels.Request
{
    public class ComponentAccessRequest:IRequestModel
    {
        /// <summary>
        /// 第三方平台 appid
        /// </summary>
        [AliasAs("component_appid"),IgnoreWhenNull]
        public string ComponentAppId { get; set; }

        /// <summary>
        /// 第三方平台 appsecret
        /// </summary>
        [AliasAs("component_appsecret"),IgnoreWhenNull]
        public string ComponentAppSecret { get; set; }
    }
}
