using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayCommerceTransportPromotionRecommendQueryResponse.
    /// </summary>
    public class AlipayCommerceTransportPromotionRecommendQueryResponse : AopResponse
    {
        /// <summary>
        /// 使用优惠的门槛金额
        /// </summary>
        [XmlElement("from_amount")]
        public string FromAmount { get; set; }

        /// <summary>
        /// 优惠金额
        /// </summary>
        [XmlElement("reduction_amount")]
        public string ReductionAmount { get; set; }
    }
}
