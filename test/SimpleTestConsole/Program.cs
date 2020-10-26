using System;
using EasyCooperation.WeChat.Open.HttpInterface.CommonGatewayInterface;
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
            var result = await component.ApiComponentToken(new EasyCooperation.WeChat.Open.ApiParameterModels.Request.CommonGatewayInterface.Component.ApiComponentTokenRequest()
            {
                ComponentAppId = "wx4b0e613f3c243c4b",
                ComponentAppSecret = "",
                ComponentVerifyTicket = "",
            }) ;
            Console.WriteLine(result.ComponentAccessToken);
        }
    }
}
