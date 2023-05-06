using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayInsSceneEcommercePreOrderResponse.
    /// </summary>
    public class AlipayInsSceneEcommercePreOrderResponse : AopResponse
    {
        /// <summary>
        /// 预下单ID
        /// </summary>
        [XmlElement("pre_order_id")]
        public string PreOrderId { get; set; }
    }
}
