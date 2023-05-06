using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayMarketingActivityIotdeliveryQueryResponse.
    /// </summary>
    public class AlipayMarketingActivityIotdeliveryQueryResponse : AopResponse
    {
        /// <summary>
        /// 投放计划内容。当查不到对应投放计划内容时不返回
        /// </summary>
        [XmlElement("plan_detail")]
        public IoTDeliveryPlan PlanDetail { get; set; }
    }
}
