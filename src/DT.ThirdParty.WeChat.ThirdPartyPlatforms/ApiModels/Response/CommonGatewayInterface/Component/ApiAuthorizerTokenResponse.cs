using System;
using System.Collections.Generic;
using System.Text;
using EasyCooperation.Abstraction.ApiModels.Response;
using WebApiClient.DataAnnotations;

namespace EasyCooperation.WeChat.ThirdPartyPlatforms.ApiModels.Response.CommonGatewayInterface.Component
{
    /// <summary>
    /// 第三方获取授权方令牌的返回模型
    /// </summary>
    public class ApiAuthorizerTokenResponse : IResponseModel
    {
        private uint _expiresIn;

        /// <summary>
        /// 授权方令牌
        /// </summary>
        [AliasAs("authorizer_access_token")] public string AuthorizerAccessToken { get; set; }
        /// <summary>
        /// AuthorizerAccessToken的有效期 单位：秒
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
        /// <summary>
        /// 刷新令牌 刷新令牌主要用于第三方平台获取和刷新已授权用户的 AuthorizerAccessToken。一旦丢失，只能让用户重新授权，才能再次拿到新的刷新令牌。用户重新授权后，之前的刷新令牌会失效
        /// </summary>
        [AliasAs("authorizer_refresh_token")] public string AuthorizerRefreshToken { get; set; }

        /// <summary>
        /// 过期时间
        /// <para>
        /// 通过<see cref="ExpiresIn"/>与本地时间计算得到,不完全准确,应考虑时间误差和网络耗时
        /// </para>
        /// </summary>
        [IgnoreSerialized]
        public virtual DateTime ExpiresTime { get; private set; }
    }
}
