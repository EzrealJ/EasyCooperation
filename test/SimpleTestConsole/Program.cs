using System;
using EasyCooperation.WeChat.ThirdPartyPlatforms.ApiModels.Request.CommonGatewayInterface.Component;
using EasyCooperation.WeChat.ThirdPartyPlatforms.HttpInterface;
using WebApiClient;
// ReSharper disable SuggestVarOrType_SimpleTypes

namespace SimpleTestConsole
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class Program
    {
        public static async System.Threading.Tasks.Task Main(string[] args)
        {
            HttpApi.Register<IComponent>();
            var component = HttpApi.Resolve<IComponent>();
            var result = await component.ApiComponentToken(new ApiComponentTokenRequest()
            {
            }) ;
            Console.WriteLine(result.ComponentAccessToken);
        }
    }
}
