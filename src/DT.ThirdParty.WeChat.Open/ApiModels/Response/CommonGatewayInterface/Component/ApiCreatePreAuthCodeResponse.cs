using WebApiClient.DataAnnotations;

namespace EasyCooperation.WeChat.Open.ApiModels.Response.CommonGatewayInterface.Component
{
    public class ApiCreatePreAuthCodeResponse:WeChatJsonResponse
    {
        /// <summary>
        /// 预授权码
        /// </summary>
        [AliasAs("pre_auth_code")]
        public string PreAuthCode { get; set; }
        /// <summary>
        /// 有效期，单位：秒
        /// </summary>
        [AliasAs("expires_in")]
        public int ExpiresIn { get; set; }
    }
}
