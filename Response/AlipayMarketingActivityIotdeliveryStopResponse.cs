using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayMarketingActivityIotdeliveryStopResponse.
    /// </summary>
    public class AlipayMarketingActivityIotdeliveryStopResponse : AopResponse
    {
        /// <summary>
        /// 投放计划id
        /// </summary>
        [XmlElement("delivery_id")]
        public string DeliveryId { get; set; }
    }
}
