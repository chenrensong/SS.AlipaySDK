using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayOpenPublicContentPublishResponse.
    /// </summary>
    public class AlipayOpenPublicContentPublishResponse : AopResponse
    {
        /// <summary>
        /// message_id 用于描述生成的消息id
        /// </summary>
        [XmlElement("message_id")]
        public string MessageId { get; set; }
    }
}
