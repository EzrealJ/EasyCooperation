using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using EasyCooperation.Abstraction.Notifies.Models;

namespace EasyCooperation.WeChat.ThirdPartyPlatforms.Notifies.Models
{
    [XmlRoot("xml")]
    public abstract class ComponentNotifyModelDecrypted : INotifyModelDecrypted
    {
        /// <summary>
        /// 通知类型
        /// </summary>
        public string InfoType { get; set; }
        /// <summary>
        /// 第三方平台 appid
        /// </summary>
        public string AppId { get; set; }
    }
}
