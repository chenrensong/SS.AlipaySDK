using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipaySocialBaseChatSendResponse.
    /// </summary>
    public class AlipaySocialBaseChatSendResponse : AopResponse
    {
        /// <summary>
        /// msg_index:msgid+sessionId
        /// </summary>
        [XmlElement("msg_index")]
        public string MsgIndex { get; set; }
    }
}
