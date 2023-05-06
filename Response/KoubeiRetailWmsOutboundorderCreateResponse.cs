using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// KoubeiRetailWmsOutboundorderCreateResponse.
    /// </summary>
    public class KoubeiRetailWmsOutboundorderCreateResponse : AopResponse
    {
        /// <summary>
        /// 出库通知单号
        /// </summary>
        [XmlElement("outbound_order_id")]
        public string OutboundOrderId { get; set; }
    }
}
