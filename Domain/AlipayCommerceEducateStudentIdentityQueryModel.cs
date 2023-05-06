using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// AlipayCommerceEducateStudentIdentityQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEducateStudentIdentityQueryModel : AopObject
    {
        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
