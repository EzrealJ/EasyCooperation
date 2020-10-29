using System;
using System.Collections.Generic;
using System.Text;
using EasyCooperation.WeChat.OfficialAccount.ApiModels.Request;
using EasyCooperation.WeChat.OfficialAccount.Enums;

namespace EasyCooperation.WeChat.OfficialAccount.Helpers
{
    public static class AuthHelper
    {
        public static string GetAuthorizeUrl(string appId, string redirectUrl, string state, EnumOAuthScope scope, string responseType = "code", string componentAppId = "", bool addConnectRedirect = true)
        {
            StringBuilder redirectUrlBuilder = new StringBuilder("https://");
            redirectUrlBuilder.Append($"open.weixin.qq.com/connect/oauth2/authorize?appid={appId}&redirect_uri={redirectUrl}&response_type={responseType}&scope={scope}&state={state}&connect_redirect=1");

            if (string.IsNullOrWhiteSpace(componentAppId))
            {
                redirectUrlBuilder.Append($"&component_appid={componentAppId}");
            }
            redirectUrlBuilder.Append("#wechat_redirect");
            return redirectUrlBuilder.ToString();
        }
    }
}
