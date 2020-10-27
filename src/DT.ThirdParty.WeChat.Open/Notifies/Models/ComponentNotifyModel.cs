using System;
using System.Collections.Generic;
using System.Text;
using EasyCooperation.Abstraction.Notifies.Models;

namespace EasyCooperation.WeChat.Open.Notifies.Models
{
    public class ComponentNotifyModel:INotifyModel
    {
        public string AppId { get; set; }

        public string Encrypt { get; set; }
    }
}
