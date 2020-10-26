using EasyCooperation.Abstraction.ApiParameterModels.Request;
using WebApiClient.DataAnnotations;

namespace EasyCooperation.WeChat.Open.ApiParameterModels.Request.CommonGatewayInterface.Component
{
    public class ApiCreatePreAuthCodeRequest:IRequestModel
    {
        /// <summary>
        /// 第三方平台component_access_token，不是authorizer_access_token
        /// </summary>
        [AliasAs("component_access_token")]
        public string ComponentAccessToken { get; set; }
        /// <summary>
        /// 第三方平台 appid
        /// </summary>
        [AliasAs("component_appid")]
        public string ComponentAppId { get; set; }
    }
}
