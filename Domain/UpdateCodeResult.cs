using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// UpdateCodeResult Data Structure.
    /// </summary>
    [Serializable]
    public class UpdateCodeResult : AopObject
    {
        /// <summary>
        /// biz_id，唯一，业务id，用于业务请求的幂等标志
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 码值，对应码平台的token，https://qr.alipay.com/${token} 中的token
        /// </summary>
        [XmlElement("code_token")]
        public string CodeToken { get; set; }

        /// <summary>
        /// context_data，发码的上下文信息，比如子业务code，场景code等。此值为一个Map<string, string>类型的json串字符，传入规则如下： {"key1":"val2","key2":"val2"}。必填业务字段：SUB_BIZ_TYPE，SCENE等，具体咨询对接技术人员
        /// </summary>
        [XmlElement("context_data")]
        public string ContextData { get; set; }

        /// <summary>
        /// 错误码
        /// </summary>
        [XmlElement("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 错误描述
        /// </summary>
        [XmlElement("error_message")]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }
    }
}
