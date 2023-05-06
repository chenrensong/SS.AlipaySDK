using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayCommerceAcommunicationEventSyncResponse.
    /// </summary>
    public class AlipayCommerceAcommunicationEventSyncResponse : AopResponse
    {
        /// <summary>
        /// 接收成功或失败
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }
    }
}
