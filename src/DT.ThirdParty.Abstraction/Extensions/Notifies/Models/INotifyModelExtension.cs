using System;
using System.Collections.Generic;
using System.Text;
using EasyCooperation.Abstraction.Notifies.Models;
using EasyCooperation.Abstraction.Security;

namespace EasyCooperation.Abstraction.Extensions.Notifies.Models
{
    public static class INotifyModelExtension
    {
        public static INotifyModelDecrypted Decrypt(this INotifyModel notifyModel, IDecryptor<INotifyModel,  INotifyModelDecrypted> decryptor)
        {
            return decryptor.Decrypt(notifyModel);
        }
    }
}
