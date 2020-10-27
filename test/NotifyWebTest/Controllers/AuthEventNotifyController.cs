using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EasyCooperation.Abstraction.Attributes;
using EasyCooperation.Abstraction.Enums;
using EasyCooperation.WeChat.Open.Notifies;
using EasyCooperation.WeChat.Open.Notifies.Models;
using Microsoft.AspNetCore.Mvc;

namespace NotifyWebTest.Controllers
{
    public class AuthEventNotifyController : ControllerBase, IComponentAuthEventNotify
    {
        public string AuthEventNotify(
            [FromQuery] string msg_signature,
            [FromQuery] string timestamp,
            [FromQuery] string nonce,
            [FromBody] ComponentNotifyModel componentNotifyModel)
        {
            throw new NotImplementedException();
        }
    }
}
