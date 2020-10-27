using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace EasyCooperation.Abstraction.Exceptions
{
    public class SignException : Exception
    {
        public SignException()
        {
        }

        public SignException(string message) : base(message)
        {
        }

        public SignException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected SignException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
