using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayCommerceAntestCaselistQueryResponse.
    /// </summary>
    public class AlipayCommerceAntestCaselistQueryResponse : AopResponse
    {
        /// <summary>
        /// 用例列表JSONString
        /// </summary>
        [XmlElement("data")]
        public string Data { get; set; }
    }
}
