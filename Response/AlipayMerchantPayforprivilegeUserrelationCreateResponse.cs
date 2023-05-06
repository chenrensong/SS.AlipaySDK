using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayMerchantPayforprivilegeUserrelationCreateResponse.
    /// </summary>
    public class AlipayMerchantPayforprivilegeUserrelationCreateResponse : AopResponse
    {
        /// <summary>
        /// 充值业务用户与商户关系
        /// </summary>
        [XmlElement("member_info")]
        public PayForPrivilegeUserRelation MemberInfo { get; set; }
    }
}
