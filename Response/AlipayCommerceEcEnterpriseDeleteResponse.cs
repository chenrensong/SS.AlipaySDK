using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayCommerceEcEnterpriseDeleteResponse.
    /// </summary>
    public class AlipayCommerceEcEnterpriseDeleteResponse : AopResponse
    {
        /// <summary>
        /// 企业ID
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }
    }
}
