using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// KoubeiMarketingDataMallDiscountQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMarketingDataMallDiscountQueryModel : AopObject
    {
        /// <summary>
        /// 商圈id
        /// </summary>
        [XmlElement("mall_id")]
        public string MallId { get; set; }
    }
}
