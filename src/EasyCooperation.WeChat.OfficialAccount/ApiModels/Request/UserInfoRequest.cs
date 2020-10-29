using System;
using System.Collections.Generic;
using System.Text;
using EasyCooperation.Abstraction.ApiModels.Request;
using WebApiClient.DataAnnotations;

namespace EasyCooperation.WeChat.OfficialAccount.ApiModels.Request
{
    public class UserInfoRequest : IRequestModel
    {
        /// <summary>
        /// 接口调用凭证
        /// </summary>
        [AliasAs("access_token")]
        public string AccessToken { get; set; }
        /// <summary>
        /// 授权用户唯一标识
        /// </summary>
        [AliasAs("openid")] public string OpenId { get; set; }
        ///语言
        [AliasAs("lang")] public string Lang { get; set; }

    }
}
