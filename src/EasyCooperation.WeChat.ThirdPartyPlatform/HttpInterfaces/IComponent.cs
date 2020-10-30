using System;
using System.Threading;
using EasyCooperation.Abstraction.HttpInterfaces;
using EasyCooperation.WeChat.Common.Attributes;
using EasyCooperation.WeChat.ThirdPartyPlatform.ApiModels.Request.CommonGatewayInterface.Component;
using EasyCooperation.WeChat.ThirdPartyPlatform.ApiModels.Response.CommonGatewayInterface.Component;
using WebApiClient;
using WebApiClient.Attributes;
using WebApiClient.DataAnnotations;

namespace EasyCooperation.WeChat.ThirdPartyPlatform.HttpInterface
{
    /// <summary>
    /// Component
    /// </summary>
    [HttpHost("https://api.weixin.qq.com")]
    [TraceFilter(OutputTarget = OutputTarget.Console)]
    public interface IComponent : IHttpInterface
    {
        ///  <summary>
        ///  令牌
        ///  <seealso href="https://developers.weixin.qq.com/doc/oplatform/Third-party_Platforms/api/component_access_token.html"/>
        ///  <para>
        ///  令牌（component_access_token）是第三方平台接口的调用凭据。令牌的获取是有限制的，每个令牌的有效期为 2 小时，请自行做好令牌的管理，在令牌快过期时（比如1小时50分），重新调用接口获取。
        ///  </para>
        ///  <para>
        /// 如未特殊说明，令牌一般作为被调用接口的 GET 参数 component_access_token 的值使用
        ///  </para>
        ///  </summary>
        ///  <param name="apiComponentTokenRequest"></param>
        ///  <param name="timeout"></param>
        ///  <param name="cancellationToken"></param>
        ///  <returns></returns>
        [HttpPost("/cgi-bin/component/api_component_token")]
        [WeChatJsonReturn]
        ITask<ApiComponentTokenResponse> ApiComponentToken(
            [JsonContent] ApiComponentTokenRequest apiComponentTokenRequest,
            [Timeout] TimeSpan? timeout = null,
            CancellationToken cancellationToken = default);


        /// <summary>
        /// 预授权码
        /// <seealso href="https://developers.weixin.qq.com/doc/oplatform/Third-party_Platforms/api/pre_auth_code.html"/>
        /// <para>
        ///预授权码（pre_auth_code）是第三方平台方实现授权托管的必备信息，每个预授权码有效期为 10 分钟。需要先获取令牌才能调用。使用过程中如遇到问题，可在开放平台服务商专区发帖交流。
        /// </para>
        /// </summary>
        /// <param name="componentAccessToken"></param>
        /// <param name="apiCreatePreAuthCodeRequest"></param>
        /// <param name="timeout"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [HttpPost("/cgi-bin/component/api_create_preauthcode")]
        [WeChatJsonReturn]
        ITask<ApiCreatePreAuthCodeResponse> ApiCreatePreAuthCode(
            [PathQuery,AliasAs("component_access_token")]
            string componentAccessToken,
            [JsonContent] ApiCreatePreAuthCodeRequest apiCreatePreAuthCodeRequest,
            [Timeout] TimeSpan? timeout = null,
            CancellationToken cancellationToken = default);


        [HttpPost("/cgi-bin/component/api_query_auth")]
        [WeChatJsonReturn]
        ITask<ApiQueryAuthResponse> ApiQueryAuth(
            [PathQuery, AliasAs("component_access_token")] string componentAccessToken,
            [JsonContent] ApiQueryAuthRequest apiQueryAuthRequest,
            [Timeout] TimeSpan? timeout = null,
            CancellationToken cancellationToken = default);

        [HttpPost("/cgi-bin/component/api_authorizer_token")]
        [WeChatJsonReturn]
        ITask<ApiAuthorizerTokenResponse> ApiAuthorizerToken(
            [PathQuery, AliasAs("component_access_token")] string componentAccessToken,
            [JsonContent] ApiAuthorizerTokenRequest apiAuthorizerTokenRequest,
            [Timeout] TimeSpan? timeout = null,
            CancellationToken cancellationToken = default);
    }
}
