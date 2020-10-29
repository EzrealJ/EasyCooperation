using EasyCooperation.Abstraction.ApiModels.Request;
using WebApiClient.DataAnnotations;

namespace EasyCooperation.WeChat.ThirdPartyPlatforms.ApiModels.Request.CommonGatewayInterface.Component
{
    public class ApiCreatePreAuthCodeRequest:IRequestModel
    {
        /// <summary>
        /// 第三方平台 appid
        /// </summary>
        [AliasAs("component_appid")]
        public string ComponentAppId { get; set; }
    }
}
