using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// MybankCreditUserRoleCreateResponse.
    /// </summary>
    public class MybankCreditUserRoleCreateResponse : AopResponse
    {
        /// <summary>
        /// 参与者
        /// </summary>
        [XmlElement("ip_id")]
        public string IpId { get; set; }

        /// <summary>
        /// 参与者会员角色号
        /// </summary>
        [XmlElement("ip_role_id")]
        public string IpRoleId { get; set; }
    }
}
