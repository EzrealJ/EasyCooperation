using System;
using System.Collections.Generic;
using System.Text;
using EasyCooperation.Abstraction.ApiModels.Request;
using WebApiClient.DataAnnotations;

namespace EasyCooperation.WeChat.ThirdPartyPlatform.ApiModels.Request.CommonGatewayInterface.Component
{
   public class ApiQueryAuthRequest:IRequestModel
    {
        /// <summary>
        /// 第三方平台 appid
        /// </summary>
        [AliasAs("component_appid")]
        public string ComponentAppId { get; set; }

        /// <summary>
        /// 授权码, 会在授权成功时返回给第三方平台，详见第三方平台授权流程说明
        /// <seealso href="https://developers.weixin.qq.com/doc/oplatform/Third-party_Platforms/Authorization_Process_Technical_Description.html"/>
        /// </summary>
        [AliasAs("authorization_code")]
        public string AuthorizationCode { get; set; }
    }
}
