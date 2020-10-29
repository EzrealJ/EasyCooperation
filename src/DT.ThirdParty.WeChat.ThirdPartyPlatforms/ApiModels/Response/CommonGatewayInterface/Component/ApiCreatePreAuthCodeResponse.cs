using System;
using EasyCooperation.WeChat.Common.ApiModels.Response;
using EasyCooperation.WeChat.ThirdPartyPlatforms.Enums;
using WebApiClient.DataAnnotations;

namespace EasyCooperation.WeChat.ThirdPartyPlatforms.ApiModels.Response.CommonGatewayInterface.Component
{
    public class ApiCreatePreAuthCodeResponse : WeChatJsonResponse
    {
        private int _expiresIn;

        /// <summary>
        /// 预授权码
        /// </summary>
        [AliasAs("pre_auth_code")]
        public string PreAuthCode { get; set; }
        /// <summary>
        /// 有效期，单位：秒
        /// </summary>
        [AliasAs("expires_in")]
        public virtual int ExpiresIn
        {
            get => _expiresIn; set
            {
                ExpiresTime = DateTime.Now.AddSeconds(value);
                _expiresIn = value;
            }
        }
        /// <summary>
        /// 过期时间
        /// <para>
        /// 通过<see cref="ExpiresIn"/>与本地时间计算得到,不完全准确,应考虑时间误差和网络耗时
        /// </para>
        /// </summary>
        [IgnoreSerialized]
        public virtual DateTime ExpiresTime { get; private set; }

        public virtual string CreateBindComponentAuthUrl(string componentAppid, EnumBindComponentAuthType bindComponentAuthType, string redirectUrl, EnumBindComponentAuthAccountType? bindComponentAuthAccountType = null, string targetAppId = null)
        {
            if (string.IsNullOrWhiteSpace(componentAppid))
            {
                throw new System.ArgumentException($"“{nameof(componentAppid)}”不能为 Null 或空白", nameof(componentAppid));
            }
            if (string.IsNullOrWhiteSpace(redirectUrl))
            {
                throw new System.ArgumentException($"“{nameof(redirectUrl)}”不能为 Null 或空白", nameof(redirectUrl));
            }
            if (bindComponentAuthAccountType != null && (!string.IsNullOrWhiteSpace(targetAppId)))
            {
                throw new System.ArgumentException($"不能同时指定{nameof(bindComponentAuthAccountType)}和{nameof(targetAppId)},详见https://developers.weixin.qq.com/doc/oplatform/Third-party_Platforms/Authorization_Process_Technical_Description.html");
            }
            string authUrl = string.Empty;
            if (bindComponentAuthType == EnumBindComponentAuthType.QRCode)
            {
                authUrl = $"https://mp.weixin.qq.com/cgi-bin/componentloginpage?component_appid={componentAppid}&pre_auth_code={PreAuthCode}&redirect_uri={redirectUrl}&auth_type={bindComponentAuthAccountType}&biz_appid={targetAppId}";
            }
            if (bindComponentAuthType == EnumBindComponentAuthType.MobileApp)
            {
                authUrl = $"https://mp.weixin.qq.com/safe/bindcomponent?action=bindcomponent&no_scan=1&component_appid={componentAppid}&pre_auth_code={PreAuthCode}&redirect_uri={redirectUrl}&auth_type={bindComponentAuthAccountType}&biz_appid=xxxx#wechat_redirect";
            }
            return authUrl;
        }
    }
}
