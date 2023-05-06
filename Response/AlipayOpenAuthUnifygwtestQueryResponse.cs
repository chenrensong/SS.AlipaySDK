using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayOpenAuthUnifygwtestQueryResponse.
    /// </summary>
    public class AlipayOpenAuthUnifygwtestQueryResponse : AopResponse
    {
        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("des")]
        public string Des { get; set; }
    }
}
