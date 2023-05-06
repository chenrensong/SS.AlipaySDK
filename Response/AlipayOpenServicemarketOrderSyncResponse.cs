using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayOpenServicemarketOrderSyncResponse.
    /// </summary>
    public class AlipayOpenServicemarketOrderSyncResponse : AopResponse
    {
        /// <summary>
        /// 服务市场订单号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }
    }
}
