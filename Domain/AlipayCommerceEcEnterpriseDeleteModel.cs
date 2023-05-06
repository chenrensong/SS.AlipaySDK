using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// AlipayCommerceEcEnterpriseDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcEnterpriseDeleteModel : AopObject
    {
        /// <summary>
        /// 企业id
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }
    }
}
