using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using EasyCooperation.Abstraction.Notifies.Models;

namespace EasyCooperation.WeChat.ThirdPartyPlatform.Notifies.Models
{
    /// <summary>
    /// 验证票据推送通知模型
    /// </summary>
    [XmlRoot("xml")]
    public class ComponentVerifyTicketNotifyModel: ComponentNotifyModelDecrypted
    {
        /// <summary>
        /// 时间戳，单位：s
        /// </summary>
        public int CreateTime { get; set; }

        /// <summary>
        /// Ticket 内容
        /// </summary>
        public string ComponentVerifyTicket { get; set; }
    }
}
