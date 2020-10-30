using System;
using System.Collections.Generic;
using System.Text;
using WebApiClient;
using WebApiClient.Attributes;

namespace EasyCooperation.Abstraction.HttpInterfaces
{

    [TraceFilter(OutputTarget = OutputTarget.Console)]
    public interface IHttpInterface : IHttpApi
    {
    }
}
