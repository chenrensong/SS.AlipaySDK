using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayCommerceTransportAdPlanGetResponse.
    /// </summary>
    public class AlipayCommerceTransportAdPlanGetResponse : AopResponse
    {
        /// <summary>
        /// 计划详情
        /// </summary>
        [XmlElement("plan_result")]
        public AdPlan PlanResult { get; set; }
    }
}
