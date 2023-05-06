using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// KoubeiServindustryReservationPayshopIdentifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiServindustryReservationPayshopIdentifyModel : AopObject
    {
        /// <summary>
        /// 店铺id
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }
    }
}
