using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayCommerceTransportAdPlanCreateResponse.
    /// </summary>
    public class AlipayCommerceTransportAdPlanCreateResponse : AopResponse
    {
        /// <summary>
        /// 调用API新增计划后，返回的计划ID和该计划下所属的单元ID列表
        /// </summary>
        [XmlElement("add_plan_group_result")]
        public AddPlanGroupResult AddPlanGroupResult { get; set; }
    }
}
