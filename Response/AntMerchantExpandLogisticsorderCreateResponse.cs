using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AntMerchantExpandLogisticsorderCreateResponse.
    /// </summary>
    public class AntMerchantExpandLogisticsorderCreateResponse : AopResponse
    {
        /// <summary>
        /// 物流单id
        /// </summary>
        [XmlElement("logistics_order_id")]
        public string LogisticsOrderId { get; set; }
    }
}
