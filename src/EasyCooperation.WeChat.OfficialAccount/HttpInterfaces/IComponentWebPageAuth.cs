using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using EasyCooperation.Abstraction.HttpInterfaces;
using EasyCooperation.WeChat.OfficialAccount.ApiModels.Request;
using EasyCooperation.WeChat.OfficialAccount.ApiModels.Response;
using WebApiClient;
using WebApiClient.Attributes;

namespace EasyCooperation.WeChat.OfficialAccount.HttpInterfaces
{
    public interface IComponentWebPageAuth : IHttpInterface
    {
        [HttpPost("/sns/oauth2/component/access_token")]
        ITask<AccessTokenResponse> AccessToken(
            [PathQuery] AccessTokenRequest accessTokenRequest,
            [PathQuery] ComponentAccessRequest componentAccessRequest = null,
            [Timeout] TimeSpan? timeout = null,
            CancellationToken cancellationToken = default);

        [HttpPost("/sns/oauth2/component/refresh_token")]
        ITask<AccessTokenResponse> RefreshToken(
        [PathQuery] RefreshTokenRequest refreshTokenRequest,
        [PathQuery] ComponentAccessRequest componentAccessRequest = null,
        [Timeout] TimeSpan? timeout = null,
        CancellationToken cancellationToken = default);


    }
}
