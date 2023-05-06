using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayCommerceAntestAlipayversionQueryResponse.
    /// </summary>
    public class AlipayCommerceAntestAlipayversionQueryResponse : AopResponse
    {
        /// <summary>
        /// 支付宝版本
        /// </summary>
        [XmlArray("data")]
        [XmlArrayItem("string")]
        public List<string> Data { get; set; }
    }
}
