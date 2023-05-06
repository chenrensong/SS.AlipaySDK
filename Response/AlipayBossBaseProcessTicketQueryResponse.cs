using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayBossBaseProcessTicketQueryResponse.
    /// </summary>
    public class AlipayBossBaseProcessTicketQueryResponse : AopResponse
    {
        /// <summary>
        /// 工单详情
        /// </summary>
        [XmlElement("ticket")]
        public BPOpenApiTicket Ticket { get; set; }
    }
}
