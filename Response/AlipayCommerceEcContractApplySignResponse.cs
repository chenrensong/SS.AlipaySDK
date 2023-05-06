using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayCommerceEcContractApplySignResponse.
    /// </summary>
    public class AlipayCommerceEcContractApplySignResponse : AopResponse
    {
        /// <summary>
        /// 签约链接
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
