using EasyCooperation.Abstraction.ApiModels.Request;
using WebApiClient.DataAnnotations;

namespace EasyCooperation.WeChat.ThirdPartyPlatform.ApiModels.Request.CommonGatewayInterface.Component
{
    /// <summary>
    /// <seealso href="https://developers.weixin.qq.com/doc/oplatform/Third-party_Platforms/api/component_access_token.html"/>
    /// </summary>
    public class ApiComponentTokenRequest:IRequestModel
    {
        /// <summary>
        /// 第三方平台 appid
        /// </summary>
        [AliasAs("component_appid")]
        public string ComponentAppId { get; set; }
        /// <summary>
        /// 第三方平台 appsecret
        /// </summary>
        [AliasAs("component_appsecret")]
        public string ComponentAppSecret { get; set; }
        /// <summary>
        /// 微信后台推送的 ticket
        /// </summary>
        [AliasAs("component_verify_ticket")]
        public string ComponentVerifyTicket { get; set; }
    }
}
