using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayMerchantPayforprivilegeUserrelationQueryResponse.
    /// </summary>
    public class AlipayMerchantPayforprivilegeUserrelationQueryResponse : AopResponse
    {
        /// <summary>
        /// 充值业务用户与商户的关系
        /// </summary>
        [XmlElement("member_info")]
        public PayForPrivilegeUserRelation MemberInfo { get; set; }
    }
}
