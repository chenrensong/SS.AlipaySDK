using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayEbppOrderItemQueryResponse.
    /// </summary>
    public class AlipayEbppOrderItemQueryResponse : AopResponse
    {
        /// <summary>
        /// 订单项
        /// </summary>
        [XmlElement("item")]
        public EbppOrderItem Item { get; set; }
    }
}
