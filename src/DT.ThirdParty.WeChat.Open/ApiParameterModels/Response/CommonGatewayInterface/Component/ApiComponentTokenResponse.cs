using System;
using System.Collections.Generic;
using System.Text;
using WebApiClient.DataAnnotations;

namespace EasyCooperation.WeChat.Open.ApiParameterModels.Response.CommonGatewayInterface.Component
{
    /// <summary>
    /// <seealso href="https://developers.weixin.qq.com/doc/oplatform/Third-party_Platforms/api/component_access_token.html"/>
    /// </summary>
    public class ApiComponentTokenResponse:WeChatJsonResponse
    {
        /// <summary>
        /// 第三方平台 appid
        /// </summary>
        [AliasAs("component_access_token")]
        public string ComponentAccessToken { get; set; }
        /// <summary>
        /// 有效期，单位：秒
        /// </summary>
        [AliasAs("expires_in")]
        public uint ExpiresIn { get; set; }
    }
}
