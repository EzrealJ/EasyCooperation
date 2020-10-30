using System;
using System.Collections.Generic;
using System.Text;

namespace EasyCooperation.Abstraction.Security
{
    /// <summary>
    /// 解密者
    /// </summary>
    public interface IDecryptor<TIn, IDecryptorOption, TOut>
        where IDecryptorOption:class
    {
        TOut Decrypt(TIn @in, IDecryptorOption decryptorOption = null);
        int TryDecrypt(TIn @in,ref TOut @out,IDecryptorOption decryptorOption = null);
    }
}
