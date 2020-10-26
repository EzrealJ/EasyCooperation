using System;
using System.Collections.Generic;
using System.Text;
using WebApiClient;
using WebApiClient.Attributes;

namespace EasyCooperation.Abstraction.HttpInterface
{
    [TraceFilter(OutputTarget = OutputTarget.Console)]
    public interface IHttpInterface : IHttpApi
    {
    }
}
