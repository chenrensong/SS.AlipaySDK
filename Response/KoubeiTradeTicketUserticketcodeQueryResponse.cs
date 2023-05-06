using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// KoubeiTradeTicketUserticketcodeQueryResponse.
    /// </summary>
    public class KoubeiTradeTicketUserticketcodeQueryResponse : AopResponse
    {
        /// <summary>
        /// 查询结果列表
        /// </summary>
        [XmlArray("values")]
        [XmlArrayItem("ticket_code_query_response")]
        public List<TicketCodeQueryResponse> Values { get; set; }
    }
}
