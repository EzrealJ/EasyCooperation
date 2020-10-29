using System;
using System.Collections.Generic;
using System.Text;
using EasyCooperation.Abstraction.ApiModels.Response;
using WebApiClient.DataAnnotations;

namespace EasyCooperation.WeChat.Common.ApiModels.Response
{
    /// <summary>
    /// 微信Json返回结果
    /// </summary>
    public abstract class WeChatJsonResponse : IResponseModel
    {
        /// <summary>
        /// 原始JsonString
        /// </summary>
        [IgnoreSerialized]
        public string RawJsonString { get; set; }
        /// <summary>
        /// 错误码
        /// </summary>
        [AliasAs("errcode")]
        public int? ErrorCode { get; set; }
        /// <summary>
        /// 错误码对应枚举
        /// </summary>
        [IgnoreSerialized]
        public Enums.EnumGlobalReturnCode? EnumofError => (Enums.EnumGlobalReturnCode?)ErrorCode;
        /// <summary>
        /// 错误消息
        /// </summary>
        [AliasAs("errmsg")]
        public string ErrorMessage { get; set; }
    }
}
