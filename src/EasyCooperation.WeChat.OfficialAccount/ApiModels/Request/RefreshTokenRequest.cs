using System;
using System.Collections.Generic;
using System.Text;
using EasyCooperation.Abstraction.ApiModels.Request;
using WebApiClient.DataAnnotations;

namespace EasyCooperation.WeChat.OfficialAccount.ApiModels.Request
{
   public class RefreshTokenRequest : IRequestModel
    {
        /// <summary>
        /// 公众号的 appid
        /// </summary>
        [AliasAs("appid")]public string AppId { get; set; }
        /// <summary>
        /// 用户授权Code
        /// </summary>
        [AliasAs("code")]public string Code { get; set; }


        [AliasAs("grant_type")]public string GrantType { get; set; } = "refresh_token";
    }
}
