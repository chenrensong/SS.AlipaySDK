using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayOpenAppMsgDingSendResponse.
    /// </summary>
    public class AlipayOpenAppMsgDingSendResponse : AopResponse
    {
        /// <summary>
        /// 企业消息的id
        /// </summary>
        [XmlElement("msg_id")]
        public string MsgId { get; set; }
    }
}
