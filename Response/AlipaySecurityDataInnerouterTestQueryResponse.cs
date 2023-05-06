using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipaySecurityDataInnerouterTestQueryResponse.
    /// </summary>
    public class AlipaySecurityDataInnerouterTestQueryResponse : AopResponse
    {
        /// <summary>
        /// 123
        /// </summary>
        [XmlElement("one")]
        public string One { get; set; }
    }
}
