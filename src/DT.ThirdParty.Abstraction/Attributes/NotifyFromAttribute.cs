using System;
using System.Collections.Generic;
using System.Text;
using EasyCooperation.Abstraction.Enums;

namespace EasyCooperation.Abstraction.Attributes
{
    /// <summary>
    /// 标识通知参数来源
    /// <para>
    /// 此特性未对任何框架进行适配，只用于标记,在不同框架则应自行适配或以不同实现来代替
    /// </para>
    /// <para>例如在ASP.NET Core中，NotifyFrom(EnumNotifyFrom.Query)应对应替换为 FromRouteAttribute</para>
    /// </summary>
    public class NotifyFromAttribute : Attribute
    {
        public NotifyFromAttribute(EnumNotifyFrom notifyFrom)
        {
            NotifyFrom = notifyFrom;
        }

        public EnumNotifyFrom NotifyFrom { get; set; }
    }
}
