using System;
using System.Collections.Generic;
using System.Text;
using EasyCooperation.Abstraction.Notifies.Models;

namespace EasyCooperation.WeChat.Open.Notifies.Models
{
    /// <summary>
    /// 验证票据推送通知模型
    /// </summary>
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
