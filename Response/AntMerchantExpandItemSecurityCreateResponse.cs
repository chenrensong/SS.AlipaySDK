using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AntMerchantExpandItemSecurityCreateResponse.
    /// </summary>
    public class AntMerchantExpandItemSecurityCreateResponse : AopResponse
    {
        /// <summary>
        /// 商品ID
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }
    }
}
