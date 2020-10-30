using System;
using System.Collections.Generic;
using System.Text;
using EasyCooperation.Abstraction.ApiModels.Request;
using WebApiClient.DataAnnotations;

namespace EasyCooperation.WeChat.ThirdPartyPlatform.ApiModels.Request.CommonGatewayInterface.Component
{
    /// <summary>
    /// 第三方获取授权方令牌的请求模型
    /// </summary>
    public class ApiAuthorizerTokenRequest : IRequestModel
    {
        /// <summary>
        /// 第三方平台 appid
        /// </summary>
        [AliasAs("component_appid")]public string ComponentAppId { get; set; }
        /// <summary>
        /// 授权方 appid
        /// </summary>
        [AliasAs("authorizer_appid")] public string AuthorizerAppId { get; set; }
        /// <summary>
        /// 刷新令牌，获取/刷新授权信息时得到
        /// </summary>
        [AliasAs("authorizer_refresh_token")] public string AuthorizerRefreshToken { get; set; }
    }
}
