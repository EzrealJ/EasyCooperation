using System;
using System.Collections.Generic;
using System.Text;

namespace EasyCooperation.Abstraction.Enums
{
    [Flags]
    public enum EnumNotifyFrom
    {
        Query = 0b1,
        Header = 0b10,
        Route=0b100,
        Body = 0b1000,
        Form = 0b10000,
    }
}
