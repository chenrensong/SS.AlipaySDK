using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// KoubeiCateringEleOrderSyncResponse.
    /// </summary>
    public class KoubeiCateringEleOrderSyncResponse : AopResponse
    {
        /// <summary>
        /// 原始的订单id编号
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }
    }
}
