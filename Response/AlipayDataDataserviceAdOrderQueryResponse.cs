using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayDataDataserviceAdOrderQueryResponse.
    /// </summary>
    public class AlipayDataDataserviceAdOrderQueryResponse : AopResponse
    {
        /// <summary>
        /// 订单详情
        /// </summary>
        [XmlElement("order_detail")]
        public OpenOrderDetail OrderDetail { get; set; }
    }
}
