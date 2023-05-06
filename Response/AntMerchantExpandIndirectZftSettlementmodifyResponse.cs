using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AntMerchantExpandIndirectZftSettlementmodifyResponse.
    /// </summary>
    public class AntMerchantExpandIndirectZftSettlementmodifyResponse : AopResponse
    {
        /// <summary>
        /// 申请单ID
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }
    }
}
