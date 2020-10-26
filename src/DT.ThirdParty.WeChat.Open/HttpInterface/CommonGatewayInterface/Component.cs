using System;
using System.Threading;
using EasyCooperation.Abstraction.HttpInterface;
using EasyCooperation.WeChat.Open.ApiParameterModels.Request.CommonGatewayInterface.Component;
using EasyCooperation.WeChat.Open.ApiParameterModels.Response.CommonGatewayInterface.Component;
using EasyCooperation.WeChat.Open.Attributes;
using WebApiClient;
using WebApiClient.Attributes;

namespace EasyCooperation.WeChat.Open.HttpInterface.CommonGatewayInterface
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


        // ReSharper disable once StringLiteralTypo
        [HttpPost("/cgi-bin/component/api_create_preauthcode")]
        [WeChatJsonReturn]
        ITask<ApiCreatePreAuthCodeResponse> ApiCreatePreAuthCode(
            [JsonContent] ApiCreatePreAuthCodeRequest componentAccessTokenRequest,
            [Timeout] TimeSpan? timeout = null,
            CancellationToken cancellationToken = default);
    }
}
