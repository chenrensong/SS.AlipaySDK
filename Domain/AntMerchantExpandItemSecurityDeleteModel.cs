using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// AntMerchantExpandItemSecurityDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandItemSecurityDeleteModel : AopObject
    {
        /// <summary>
        /// 商品ID
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }
    }
}
