using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipaySecurityProdCtidVerifyResponse.
    /// </summary>
    public class AlipaySecurityProdCtidVerifyResponse : AopResponse
    {
        /// <summary>
        /// 结果码
        /// </summary>
        [XmlElement("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 结果码描述
        /// </summary>
        [XmlElement("result_desc")]
        public string ResultDesc { get; set; }
    }
}
