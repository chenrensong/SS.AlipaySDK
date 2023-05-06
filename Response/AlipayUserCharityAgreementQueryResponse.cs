using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayUserCharityAgreementQueryResponse.
    /// </summary>
    public class AlipayUserCharityAgreementQueryResponse : AopResponse
    {
        /// <summary>
        /// 协议是否有效
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
