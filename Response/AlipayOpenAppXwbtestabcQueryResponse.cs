using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayOpenAppXwbtestabcQueryResponse.
    /// </summary>
    public class AlipayOpenAppXwbtestabcQueryResponse : AopResponse
    {
        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("xw")]
        public string Xw { get; set; }
    }
}
