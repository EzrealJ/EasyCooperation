using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc.Filters;
using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filter
{
    /// <summary>
    /// 记录Http请求日志的Filter
    /// </summary>

    public class HttpLogFilter : IAsyncActionFilter
    {
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {

            Stopwatch stopwatch = new Stopwatch();
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("-----------------------------------------------------------");
            stringBuilder.AppendLine("=================>Request Content Start:");
            stringBuilder.AppendLine($"A request occurred at {DateTime.Now:yyyy-MM-dd HH:mm:ss.ffff}");
            stringBuilder.AppendLine($"Host :{context.HttpContext.Request.Host}");
            stringBuilder.AppendLine($"ContentType :{context.HttpContext.Request.ContentType}");
            stringBuilder.AppendLine($"Url :{context.HttpContext.Request.Path}");
            stringBuilder.AppendLine($"Request.Headers:");
            context.HttpContext.Request.Headers.ToList().ForEach(header => stringBuilder.AppendLine($"{header.Key} :{header.Value}"));
            stringBuilder.AppendLine($"Request.Query:");
            context.HttpContext.Request.Query.ToList().ForEach(query => stringBuilder.AppendLine($"{query.Key} :{query.Value}"));
            stringBuilder.AppendLine("=================>Request Content End.");
            stringBuilder.AppendLine("-----------------------------------------------------------");



            long contentLen = context.HttpContext.Request.ContentLength == null ? 0 : context.HttpContext.Request.ContentLength.Value;
            if (contentLen > 0)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    await context.HttpContext.Request.Body.CopyToAsync(ms);
                    //设置当前流的位置为0
                    ms.Seek(0, SeekOrigin.Begin);
                    //这里ReadToEnd执行完毕后requestBodyStream流的位置会从0到最后位置(即request.ContentLength)
                    string requestBody = new StreamReader(ms, Encoding.UTF8).ReadToEnd();
                    //设置当前流的位置为0
                    ms.Seek(0, SeekOrigin.Begin);
                    stringBuilder.AppendLine("Body:" + requestBody);
                }

            }


            stopwatch.Start();
            ActionExecutedContext actionExecutedContext = await next();
            stopwatch.Stop();





            stringBuilder.AppendLine("=================>Response Content Start:");
            ObjectResult result = actionExecutedContext.Result as ObjectResult;
            if (result != null)
            {
                stringBuilder.AppendLine(JsonConvert.SerializeObject(result.Value, Formatting.Indented));
            }
            stringBuilder.AppendLine("=================>Response Content End.");
            stringBuilder.AppendLine($"It took {stopwatch.ElapsedMilliseconds}ms to respond to this request.");
            Console.WriteLine(stringBuilder.ToString());


        }
    }


}
