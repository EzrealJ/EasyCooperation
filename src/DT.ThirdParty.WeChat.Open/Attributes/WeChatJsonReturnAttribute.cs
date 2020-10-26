using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using EasyCooperation.WeChat.Open.ApiParameterModels.Response;
using WebApiClient.Attributes;
using WebApiClient.Contexts;

namespace EasyCooperation.WeChat.Open.Attributes
{
    public class WeChatJsonReturnAttribute : ApiReturnAttribute
    {
        public static string JsonMediaType => "application/json";
        protected override void ConfigureAccept(HttpHeaderValueCollection<MediaTypeWithQualityHeaderValue> accept)
        {
            accept.Add(new MediaTypeWithQualityHeaderValue(JsonMediaType));
        }

        protected override async Task<object> GetTaskResult(ApiActionContext context)
        {
            HttpResponseMessage response = context.ResponseMessage;
            string resultString = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            resultString = resultString?.TrimStart()?.TrimEnd();
            object result = null;
            Type dataType = context.ApiActionDescriptor.Return.DataType.Type;
            result = context.HttpApiConfig.JsonFormatter.Deserialize(resultString, dataType);
            if (typeof(WeChatJsonResponse).IsAssignableFrom(dataType))
            {
                if (result == null)
                {
                    result = Activator.CreateInstance(dataType);
                }
                (result as WeChatJsonResponse).RawJsonString = resultString;

            }

            return result;
        }
    }
}
