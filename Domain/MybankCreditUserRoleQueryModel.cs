using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// MybankCreditUserRoleQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankCreditUserRoleQueryModel : AopObject
    {
        /// <summary>
        /// 站点会员信息
        /// </summary>
        [XmlElement("member")]
        public Member Member { get; set; }
    }
}
