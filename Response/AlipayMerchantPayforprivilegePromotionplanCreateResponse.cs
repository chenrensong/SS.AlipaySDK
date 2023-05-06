using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayMerchantPayforprivilegePromotionplanCreateResponse.
    /// </summary>
    public class AlipayMerchantPayforprivilegePromotionplanCreateResponse : AopResponse
    {
        /// <summary>
        /// 充值方案，当前接口创建的充值方案
        /// </summary>
        [XmlElement("promotion_plan")]
        public PayForPrivilegePromotionPlanInfo PromotionPlan { get; set; }
    }
}
