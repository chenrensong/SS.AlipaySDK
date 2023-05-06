using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayIserviceCcmAgentCreateResponse.
    /// </summary>
    public class AlipayIserviceCcmAgentCreateResponse : AopResponse
    {
        /// <summary>
        /// CCM客服id
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }
    }
}
