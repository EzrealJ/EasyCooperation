using System.Threading.Tasks;
using EasyCooperation.WeChat.ThirdPartyPlatforms.ApiModels.Request.CommonGatewayInterface.Component;
using EasyCooperation.WeChat.ThirdPartyPlatforms.ApiModels.Response.CommonGatewayInterface.Component;
using EasyCooperation.WeChat.ThirdPartyPlatforms.Enums;
using EasyCooperation.WeChat.ThirdPartyPlatforms.HttpInterface;
using EasyCooperation.WeChat.ThirdPartyPlatforms.Notifies.Models;
using EasyCooperation.WeChat.ThirdPartyPlatforms.Options;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace NotifyWebTest.Controllers
{
    public class ComponentAuthController : Controller
    {
        private readonly IMemoryCache _memoryCache;
        private readonly ILogger<ComponentAuthController> _logger;
        private readonly IOptionsSnapshot<WeChatComponentOptions> _optionsSnapshotOfWeChatComponentOptions;
        private readonly IComponent _component;

        public ComponentAuthController(
            IMemoryCache memoryCache,
            ILogger<ComponentAuthController> logger,
            IOptionsSnapshot<WeChatComponentOptions> optionsSnapshotOfWeChatComponentOptions,
            IComponent component)
        {
            _memoryCache = memoryCache;
            _logger = logger;
            _optionsSnapshotOfWeChatComponentOptions = optionsSnapshotOfWeChatComponentOptions;
            _component = component;
        }

        public ViewResult AuthView()
        {
            return View();
        }

        public async Task<ActionResult> AuthAsync()
        {
            if (_memoryCache.TryGetValue(nameof(ComponentVerifyTicketNotifyModel), out ComponentVerifyTicketNotifyModel componentVerifyTicketNotifyModel))
            {
                if (!_memoryCache.TryGetValue(nameof(ApiComponentTokenResponse), out ApiComponentTokenResponse apiComponentTokenResponse))
                {
                    apiComponentTokenResponse = await _component.ApiComponentToken(new ApiComponentTokenRequest()
                    {
                        ComponentAppId = _optionsSnapshotOfWeChatComponentOptions.Value?.AppId,
                        ComponentAppSecret = _optionsSnapshotOfWeChatComponentOptions.Value?.AppSecret,
                        ComponentVerifyTicket = componentVerifyTicketNotifyModel.ComponentVerifyTicket
                    });
                    _memoryCache.Set(nameof(ApiComponentTokenResponse), apiComponentTokenResponse);
                }
                ApiCreatePreAuthCodeResponse result = await _component.ApiCreatePreAuthCode(apiComponentTokenResponse.ComponentAccessToken, new ApiCreatePreAuthCodeRequest()
                {
                    ComponentAppId = _optionsSnapshotOfWeChatComponentOptions.Value?.AppId
                });
                string redirectUrl = "http://dev.thirdparty.wechatmp.dt128.com/ComponentAuth/AuthRedirect";
                string authUrl = result.CreateBindComponentAuthUrl(_optionsSnapshotOfWeChatComponentOptions.Value?.AppId, EnumBindComponentAuthType.QRCode, redirectUrl);
                return Redirect(authUrl);
            }
            return RedirectToAction(nameof(AuthView));
        }

        public async Task<ViewResult> AuthRedirectAsync(string auth_code, int expires_in)
        {
            ViewBag.AuthCode = auth_code;
            ViewBag.ExpiresIn = expires_in;
            if (_memoryCache.TryGetValue(nameof(ComponentVerifyTicketNotifyModel), out ComponentVerifyTicketNotifyModel componentVerifyTicketNotifyModel))
            {
                if (!_memoryCache.TryGetValue(nameof(ApiComponentTokenResponse), out ApiComponentTokenResponse apiComponentTokenResponse))
                {
                    apiComponentTokenResponse = await _component.ApiComponentToken(new ApiComponentTokenRequest()
                    {
                        ComponentAppId = _optionsSnapshotOfWeChatComponentOptions.Value?.AppId,
                        ComponentAppSecret = _optionsSnapshotOfWeChatComponentOptions.Value?.AppSecret,
                        ComponentVerifyTicket = componentVerifyTicketNotifyModel.ComponentVerifyTicket
                    });
                    _memoryCache.Set(nameof(ApiComponentTokenResponse), apiComponentTokenResponse);
                }

                ApiQueryAuthResponse apiQueryAuthResponse = await _component.ApiQueryAuth(apiComponentTokenResponse.ComponentAccessToken, new ApiQueryAuthRequest()
                {
                    AuthorizationCode = auth_code,
                    ComponentAppId = _optionsSnapshotOfWeChatComponentOptions.Value?.AppId
                });
                _memoryCache.Set(nameof(ApiAuthorizerTokenResponse), apiQueryAuthResponse as ApiAuthorizerTokenResponse);

            }
            return View();
        }
    }
}
