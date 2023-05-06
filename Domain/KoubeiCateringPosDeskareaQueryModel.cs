using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// KoubeiCateringPosDeskareaQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringPosDeskareaQueryModel : AopObject
    {
        /// <summary>
        /// 门店ID
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }
    }
}
