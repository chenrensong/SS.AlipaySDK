using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayOpenAppTestGraySendResponse.
    /// </summary>
    public class AlipayOpenAppTestGraySendResponse : AopResponse
    {
        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }
    }
}
