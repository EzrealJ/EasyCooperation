using System;
using System.Collections.Generic;
using System.Text;
using EasyCooperation.WeChat.Common.ApiModels.Response;
using WebApiClient.DataAnnotations;

namespace EasyCooperation.WeChat.ThirdPartyPlatforms.ApiModels.Response.CommonGatewayInterface.Component
{
    /// <summary>
    /// <seealso href="https://developers.weixin.qq.com/doc/oplatform/Third-party_Platforms/api/component_access_token.html"/>
    /// </summary>
    public class ApiComponentTokenResponse : WeChatJsonResponse
    {


        /// <summary>
        /// 第三方平台 第三方平台 access_token
        /// </summary>
        [AliasAs("component_access_token")]
        public string ComponentAccessToken { get; set; }
        /// <summary>
        /// 有效期，单位：秒
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
    }
}
