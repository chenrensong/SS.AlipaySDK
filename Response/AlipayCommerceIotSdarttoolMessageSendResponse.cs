using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayCommerceIotSdarttoolMessageSendResponse.
    /// </summary>
    public class AlipayCommerceIotSdarttoolMessageSendResponse : AopResponse
    {
        /// <summary>
        /// 消息ID
        /// </summary>
        [XmlElement("message_no")]
        public string MessageNo { get; set; }
    }
}
