using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayCommerceEcContractApplyUnsignResponse.
    /// </summary>
    public class AlipayCommerceEcContractApplyUnsignResponse : AopResponse
    {
        /// <summary>
        /// 解约链接
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
