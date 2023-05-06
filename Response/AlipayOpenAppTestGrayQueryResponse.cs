using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayOpenAppTestGrayQueryResponse.
    /// </summary>
    public class AlipayOpenAppTestGrayQueryResponse : AopResponse
    {
        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("res")]
        public string Res { get; set; }
    }
}
