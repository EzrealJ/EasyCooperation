using System;
using System.Collections.Generic;
using System.Text;
using EasyCooperation.Abstraction.ApiModels.Request;
using WebApiClient.DataAnnotations;

namespace EasyCooperation.WeChat.OfficialAccount.ApiModels.Request
{
    public class AuthorizeRequest:IRequestModel
    {
        /// <summary>
        /// 公众号的 appid
        /// </summary>
        [AliasAs("appid")]
        public string Appid { get; set; }
        /// <summary>
        ///  重定向地址，需要 urlencode，这里填写的应是服务开发方的回调地址
        /// </summary>
        [AliasAs("redirect_uri")]
        public string RedirectUri { get; set; }
        /// <summary>
        /// 填 code
        /// </summary>
        [AliasAs("response_type")] public string ResponseType { get; set; }
        /// <summary>
        /// 授权作用域，拥有多个作用域用逗号（,）分隔
        /// <para>
        /// 应用授权作用域，snsapi_base （不弹出授权页面，直接跳转，只能获取用户openid），snsapi_userinfo （弹出授权页面，可通过openid拿到昵称、性别、所在地。并且， 即使在未关注的情况下，只要用户授权，也能获取其信息 ）
        /// </para>
        /// </summary>
        [AliasAs("scope")] public string Scope { get; set; }
        /// <summary>
        /// 重定向后会带上 state 参数，开发者可以填写a-zA-Z0-9的参数值，最多 128 字节
        /// </summary>
        [AliasAs("state")] public string State { get; set; }
    }
}
