﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EasyCooperation.WeChat.Open.Enums
{
   public enum EnumWeChatBizMsgCryptResult
    {
        WXBizMsgCrypt_OK = 0,
        WXBizMsgCrypt_ValidateSignature_Error = -40001,
        WXBizMsgCrypt_ParseXml_Error = -40002,
        WXBizMsgCrypt_ComputeSignature_Error = -40003,
        WXBizMsgCrypt_IllegalAesKey = -40004,
        WXBizMsgCrypt_ValidateAppid_Error = -40005,
        WXBizMsgCrypt_EncryptAES_Error = -40006,
        WXBizMsgCrypt_DecryptAES_Error = -40007,
        WXBizMsgCrypt_IllegalBuffer = -40008,
        WXBizMsgCrypt_EncodeBase64_Error = -40009,
        WXBizMsgCrypt_DecodeBase64_Error = -40010
    }
}
