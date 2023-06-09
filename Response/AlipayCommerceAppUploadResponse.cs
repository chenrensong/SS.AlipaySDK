using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayCommerceAppUploadResponse.
    /// </summary>
    public class AlipayCommerceAppUploadResponse : AopResponse
    {
        /// <summary>
        /// 业务处理结果码
        /// </summary>
        [XmlElement("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// 业务处理结果描述
        /// </summary>
        [XmlElement("biz_msg")]
        public string BizMsg { get; set; }

        /// <summary>
        /// 返回主体
        /// </summary>
        [XmlElement("data")]
        public CommerceAppUploadResponseData Data { get; set; }
    }
}
