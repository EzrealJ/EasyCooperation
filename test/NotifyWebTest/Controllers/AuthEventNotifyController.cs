using EasyCooperation.WeChat.ThirdPartyPlatform.Notifies;
using EasyCooperation.WeChat.ThirdPartyPlatform.Notifies.Models;
using EasyCooperation.WeChat.ThirdPartyPlatform.Options;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;

namespace NotifyWebTest.Controllers
{
    public class AuthEventNotifyController : ControllerBase, IComponentAuthEventNotify
    {
        private readonly ComponentAuthEventPublisher _componentAuthEventPublisher;
        private readonly ILogger<AuthEventNotifyController> _logger;
        private readonly IMemoryCache _memoryCache;

        public AuthEventNotifyController(ComponentAuthEventPublisher componentAuthEventPublisher, IOptionsSnapshot<WeChatComponentOptions> optionsSnapshotOfWeChatComponentOptions, ILogger<AuthEventNotifyController> logger, IMemoryCache memoryCache)
        {
            _componentAuthEventPublisher = componentAuthEventPublisher;
            _componentAuthEventPublisher.WeChatComponentOptions = optionsSnapshotOfWeChatComponentOptions.Value;
            _logger = logger;
            _memoryCache = memoryCache;
            _componentAuthEventPublisher.ComponentVerifyTicketNotifyHandler = HandleComponentVerifyTicketNotify;
        }
        [HttpPost(nameof(AuthEventNotify))]
        public string AuthEventNotify(
            [FromQuery] string msg_signature,
            [FromQuery] string timestamp,
            [FromQuery] string nonce,
            [FromBody] ComponentNotifyModel componentNotifyModel)
        {
            _logger.LogInformation($"{nameof(msg_signature)} is {msg_signature}");
            _logger.LogInformation($"{nameof(timestamp)} is {timestamp}");
            _logger.LogInformation($"{nameof(nonce)} is {nonce}");
            _logger.LogInformation(JsonConvert.SerializeObject(componentNotifyModel));
            return _componentAuthEventPublisher.AuthEventNotify(msg_signature, timestamp, nonce, componentNotifyModel);
        }

        private string HandleComponentVerifyTicketNotify(ComponentVerifyTicketNotifyModel componentVerifyTicketNotifyModel)
        {
            string message = JsonConvert.SerializeObject(componentVerifyTicketNotifyModel);
            _logger.LogInformation(message);
            System.IO.File.WriteAllText("./componentVerifyTicket.txt", message);
            _memoryCache.Set(nameof(ComponentVerifyTicketNotifyModel), componentVerifyTicketNotifyModel);
            return "success";
        }
    }
}
