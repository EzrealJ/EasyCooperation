using System;
using System.Collections.Generic;
using System.Text;
using EasyCooperation.Abstraction.ApiModels.Response;
using WebApiClient.DataAnnotations;

namespace EasyCooperation.WeChat.ThirdPartyPlatform.ApiModels.Response.CommonGatewayInterface.Component
{
    public class ApiQueryAuthResponse : ApiAuthorizerTokenResponse
    {
        /// <summary>
        /// 授权方 appid
        /// </summary>
        [AliasAs("authorizer_appid")] public string AuthorizerAppId { get; set; }

        /// <summary>
        /// 授权给开发者的权限集列表
        /// </summary>
        [AliasAs("func_info")] public List<FuncInfo> FuncInfos { get; set; }

        public class FuncInfo
        {
            [AliasAs("funcscope_category")]
            public FuncScopeCategory FuncScopeCategory { get; set; }
        }

        public class FuncScopeCategory
        {
            public int Id { get; set; }
        }
    }
}
