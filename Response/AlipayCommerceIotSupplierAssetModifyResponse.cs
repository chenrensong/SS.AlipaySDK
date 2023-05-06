using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayCommerceIotSupplierAssetModifyResponse.
    /// </summary>
    public class AlipayCommerceIotSupplierAssetModifyResponse : AopResponse
    {
        /// <summary>
        /// 记录id
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }
    }
}
