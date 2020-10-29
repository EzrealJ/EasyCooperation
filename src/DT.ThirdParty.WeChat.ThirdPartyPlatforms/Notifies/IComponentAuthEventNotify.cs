﻿using System;
using System.Collections.Generic;
using System.Text;
using EasyCooperation.Abstraction.Attributes;
using EasyCooperation.Abstraction.Enums;
using EasyCooperation.Abstraction.Notifies;
using EasyCooperation.WeChat.ThirdPartyPlatforms.Notifies.Models;

namespace EasyCooperation.WeChat.ThirdPartyPlatforms.Notifies
{
    public interface IComponentAuthEventNotify : INotify
    {
        string AuthEventNotify(
            [NotifyFrom(EnumNotifyFrom.Query)] string msg_signature,
            [NotifyFrom(EnumNotifyFrom.Query)] string timestamp,
            [NotifyFrom(EnumNotifyFrom.Query)] string nonce,
            [NotifyFrom(EnumNotifyFrom.Body)] ComponentNotifyModel componentNotifyModel);
    }
}