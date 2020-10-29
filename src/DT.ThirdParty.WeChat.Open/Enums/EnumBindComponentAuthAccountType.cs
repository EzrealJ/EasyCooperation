using System;
using System.Collections.Generic;
using System.Text;

namespace EasyCooperation.WeChat.ThirdPartyPlatforms.Enums
{
    /// <summary>
    /// 用户授权给第三方平台的帐号类型
    /// </summary>
    [Flags]
    public enum EnumBindComponentAuthAccountType
    {
        /// <summary>
        /// 公众号
        /// </summary>
        OfficialAccount = 0b1,
        /// <summary>
        /// 小程序
        /// </summary>
        Applet = 0b10,
        /// <summary>
        /// 公众号和小程序都展示
        /// </summary>
        Both = 0b11
    }
}
