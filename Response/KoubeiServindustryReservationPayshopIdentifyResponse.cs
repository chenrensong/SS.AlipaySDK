using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// KoubeiServindustryReservationPayshopIdentifyResponse.
    /// </summary>
    public class KoubeiServindustryReservationPayshopIdentifyResponse : AopResponse
    {
        /// <summary>
        /// 是否付费店铺
        /// </summary>
        [XmlElement("pay_shop")]
        public bool PayShop { get; set; }
    }
}
