using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayDataDataserviceAdPlanQueryResponse.
    /// </summary>
    public class AlipayDataDataserviceAdPlanQueryResponse : AopResponse
    {
        /// <summary>
        /// 计划详情
        /// </summary>
        [XmlElement("plan_detail")]
        public OuterPlan PlanDetail { get; set; }
    }
}
