using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayBossOrderApplyResponse.
    /// </summary>
    public class AlipayBossOrderApplyResponse : AopResponse
    {
        /// <summary>
        /// 订单信息
        /// </summary>
        [XmlElement("order_info")]
        public string OrderInfo { get; set; }
    }
}
