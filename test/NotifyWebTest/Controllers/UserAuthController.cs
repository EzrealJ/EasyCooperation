using System;
using System.Threading.Tasks;
using EasyCooperation.WeChat.OfficialAccount.ApiModels.Request;
using EasyCooperation.WeChat.OfficialAccount.Enums;
using EasyCooperation.WeChat.OfficialAccount.Helpers;
using EasyCooperation.WeChat.OfficialAccount.HttpInterfaces;
using EasyCooperation.WeChat.ThirdPartyPlatforms.ApiModels.Response.CommonGatewayInterface.Component;
using EasyCooperation.WeChat.ThirdPartyPlatforms.HttpInterface;
using EasyCooperation.WeChat.ThirdPartyPlatforms.Options;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;

namespace NotifyWebTest.Controllers
{
    public class UserAuthController : Controller
    {
        private readonly IMemoryCache _memoryCache;
        private readonly ILogger<UserAuthController> _logger;
        private readonly IOptionsSnapshot<WeChatComponentOptions> _optionsSnapshotOfWeChatComponentOptions;
        private readonly IComponent _component;
        private readonly IComponentWebPageAuth _componentWebPageAuth;
        private readonly IWebPageAuth _webPageAuth;

        public UserAuthController(
            IMemoryCache memoryCache,
            ILogger<UserAuthController> logger,
            IComponentWebPageAuth componentWebPageAuth,
            IWebPageAuth webPageAuth,
            IOptionsSnapshot<WeChatComponentOptions> optionsSnapshotOfWeChatComponentOptions,
            IComponent component)
        {
            this._memoryCache = memoryCache;
            this._logger = logger;
            this._optionsSnapshotOfWeChatComponentOptions = optionsSnapshotOfWeChatComponentOptions;
            this._component = component;
            this._componentWebPageAuth = componentWebPageAuth;
            this._webPageAuth = webPageAuth;
        }

        public ViewResult AuthView()
        {
            return View();
        }

        public IActionResult Auth(string appid)
        {
            if (!string.IsNullOrWhiteSpace(appid))
            {
                string redirectUrl = "http://dev.thirdparty.wechatmp.dt128.com/UserAuth/AuthRedirect";
                string authUrl = AuthHelper.GetAuthorizeUrl(appid, redirectUrl, "stateTest", EnumOAuthScope.snsapi_userinfo, "code", _optionsSnapshotOfWeChatComponentOptions.Value?.AppId);
                return Redirect(authUrl);
            }
            return RedirectToAction(nameof(AuthView));
        }

        public async Task<IActionResult> AuthRedirectAsync(string code, string state, string appid)
        {
            ViewBag.Code = code;
            ViewBag.State = state;
            ViewBag.AppId = appid;
            if (string.IsNullOrWhiteSpace(code))
            {
                return RedirectToAction(nameof(AuthView));
            }
            if (_memoryCache.TryGetValue(nameof(ApiAuthorizerTokenResponse), out ApiAuthorizerTokenResponse apiAuthorizerTokenResponse))
            {
                if (apiAuthorizerTokenResponse.ExpiresTime > DateTime.Now.AddSeconds(10))
                {
                    return RedirectToAction(nameof(AuthView), nameof(ComponentAuthController).Replace(nameof(Controller), string.Empty));
                }

                var accessTokenResponse = await _componentWebPageAuth.AccessToken(new AccessTokenRequest()
                {
                    AppId = appid,
                    Code = code

                }, new ComponentAccessRequest()
                {
                    ComponentAppId = _optionsSnapshotOfWeChatComponentOptions.Value?.AppId,
                    ComponentAccessToken = apiAuthorizerTokenResponse.AuthorizerAccessToken
                });

                var userInfoResponse = await _webPageAuth.UserInfo(new UserInfoRequest()
                {
                    AccessToken = accessTokenResponse.AccessToken,
                    OpenId = accessTokenResponse.OpenId,
                    Lang = "zh_CN"

                });
                ViewBag.UserInfo = JsonConvert.SerializeObject(userInfoResponse);



            }
            else
            {
                return RedirectToAction(nameof(AuthView), nameof(ComponentAuthController).Replace(nameof(Controller), string.Empty));
            }
            return View();
        }
    }
}
