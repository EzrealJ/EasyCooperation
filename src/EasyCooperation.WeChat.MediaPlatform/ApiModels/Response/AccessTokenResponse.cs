using System;
using EasyCooperation.WeChat.Common.ApiModels.Response;
using WebApiClient.DataAnnotations;

namespace EasyCooperation.WeChat.OfficialAccount.ApiModels.Response
{
    public class AccessTokenResponse : WeChatJsonResponse
    {

        /// <summary>
        /// 接口调用凭证
        /// </summary>
        [AliasAs("access_token")]
        public string AccessToken { get; set; }


        /// <summary>
        /// access_token接口调用凭证超时时间，单位（秒）
        /// </summary>
        [AliasAs("expires_in")]
        public virtual uint ExpiresIn
        {
            get => _expiresIn; set
            {
                ExpiresTime = DateTime.Now.AddSeconds(value);
                _expiresIn = value;
            }
        }
        private uint _expiresIn;
        /// <summary>
        /// 过期时间
        /// <para>
        /// 通过<see cref="ExpiresIn"/>与本地时间计算得到,不完全准确,应考虑时间误差和网络耗时
        /// </para>
        /// </summary>
        [IgnoreSerialized]
        public virtual DateTime ExpiresTime { get; private set; }


        /// <summary>
        /// 授权用户唯一标识
        /// </summary>
        [AliasAs("openid")] public string OpenId { get; set; }

 
        /// <summary>
        ///  用户刷新access_token
        /// </summary>
        [AliasAs("refresh_token")] public string RefreshToken { get; set; }
 
        /// <summary>
        /// 用户授权的作用域，使用逗号（,）分隔
        /// </summary>
        [AliasAs("scope")] public string Scope { get; set; }

 
        /// <summary>
        /// 只有在用户将公众号绑定到微信开放平台帐号后，才会出现该字段。详见：获取用户个人信息（UnionID机制）
        /// </summary>
        [AliasAs("unionid")] public string UnionId { get; set; }
    }
}
