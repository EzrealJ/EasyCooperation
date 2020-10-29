using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using EasyCooperation.Abstraction.HttpInterfaces;
using EasyCooperation.WeChat.OfficialAccount.ApiModels.Request;
using EasyCooperation.WeChat.OfficialAccount.ApiModels.Response;
using WebApiClient;
using WebApiClient.Attributes;
using WebApiClient.DataAnnotations;

namespace EasyCooperation.WeChat.OfficialAccount.HttpInterfaces
{
    /// <summary>
    /// Component
    /// </summary>
    [HttpHost("https://api.weixin.qq.com")]
    [TraceFilter(OutputTarget = OutputTarget.Console)]
    public interface IWebPageAuth : IHttpInterface
    {
        [HttpPost("/sns/oauth2/access_token")]
        ITask<AccessTokenResponse> AccessToken(
            [PathQuery] AccessTokenRequest accessTokenRequest,
            [Timeout] TimeSpan? timeout = null,
            CancellationToken cancellationToken = default);


        [HttpPost("/sns/oauth2/refresh_token")]
        ITask<AccessTokenResponse> RefreshToken(
            [PathQuery] RefreshTokenRequest refreshTokenRequest,
            [Timeout] TimeSpan? timeout = null,
            CancellationToken cancellationToken = default);

        [HttpPost("/sns/oauth2/userinfo")]
        ITask<UserInfoResponse> UserInfo(
            [PathQuery] UserInfoRequest userInfoRequest,
            [Timeout] TimeSpan? timeout = null,
            CancellationToken cancellationToken = default);
    }
}
