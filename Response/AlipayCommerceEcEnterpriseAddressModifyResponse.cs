using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayCommerceEcEnterpriseAddressModifyResponse.
    /// </summary>
    public class AlipayCommerceEcEnterpriseAddressModifyResponse : AopResponse
    {
        /// <summary>
        /// 地址id
        /// </summary>
        [XmlElement("address_id")]
        public string AddressId { get; set; }
    }
}
