using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using EasyCooperation.Abstraction.Notifies.Models;

namespace EasyCooperation.WeChat.ThirdPartyPlatform.Notifies.Models
{
    [XmlRoot("xml")]
    public class ComponentNotifyModel:INotifyModel
    {
       
        public string AppId { get; set; }
      
        public string Encrypt { get; set; }
    }
}
