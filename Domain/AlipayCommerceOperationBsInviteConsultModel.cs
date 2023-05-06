using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// AlipayCommerceOperationBsInviteConsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceOperationBsInviteConsultModel : AopObject
    {
        /// <summary>
        /// 商户ID
        /// </summary>
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 联营计划ID
        /// </summary>
        [XmlElement("plan_id")]
        public string PlanId { get; set; }
    }
}
