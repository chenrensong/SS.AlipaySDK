using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayOpenAppXwbtstabcQueryResponse.
    /// </summary>
    public class AlipayOpenAppXwbtstabcQueryResponse : AopResponse
    {
        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("xwbbbdd")]
        public string Xwbbbdd { get; set; }
    }
}
