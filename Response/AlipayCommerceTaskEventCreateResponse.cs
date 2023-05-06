using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayCommerceTaskEventCreateResponse.
    /// </summary>
    public class AlipayCommerceTaskEventCreateResponse : AopResponse
    {
        /// <summary>
        /// 模版id
        /// </summary>
        [XmlElement("event_id")]
        public string EventId { get; set; }
    }
}
