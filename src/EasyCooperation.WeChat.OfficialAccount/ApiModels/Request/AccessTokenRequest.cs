using System;
using System.Collections.Generic;
using System.Text;
using EasyCooperation.Abstraction.ApiModels.Request;
using WebApiClient.DataAnnotations;

namespace EasyCooperation.WeChat.OfficialAccount.ApiModels.Request
{
   public class AccessTokenRequest:IRequestModel
    {
        /// <summary>
        /// 公众号的 appid
        /// </summary>
        [AliasAs("appid")]public string AppId { get; set; }
        /// <summary>
        /// 用户授权Code
        /// </summary>
        [AliasAs("code")]public string Code { get; set; }
        /// <summary>
        /// 公众号的appsecret
        /// <para>
        /// 当第三方平台代调用时不传此参数，改为传递component_appid和component_access_token 详见
        /// <seealso href="https://developers.weixin.qq.com/doc/oplatform/Third-party_Platforms/Official_Accounts/official_account_website_authorization.html"/>
        /// </para>
        /// </summary>
        [AliasAs("secret")]
        public string Secret { get; set; }

        [AliasAs("grant_type")]public string GrantType { get; set; } = "authorization_code";
    }
}
