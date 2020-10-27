using System;
using System.Collections.Generic;
using System.Text;
using EasyCooperation.Abstraction.Notifies.Models;

namespace EasyCooperation.WeChat.Open.Notifies.Models
{
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
