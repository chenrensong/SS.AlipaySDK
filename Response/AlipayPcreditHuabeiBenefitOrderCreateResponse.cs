using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayPcreditHuabeiBenefitOrderCreateResponse.
    /// </summary>
    public class AlipayPcreditHuabeiBenefitOrderCreateResponse : AopResponse
    {
        /// <summary>
        /// 权益订单id
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }
    }
}
