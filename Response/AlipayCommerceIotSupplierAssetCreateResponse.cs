using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayCommerceIotSupplierAssetCreateResponse.
    /// </summary>
    public class AlipayCommerceIotSupplierAssetCreateResponse : AopResponse
    {
        /// <summary>
        /// 记录id
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }
    }
}
