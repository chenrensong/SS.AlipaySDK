using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// AlipayMarketingActivityOrdervoucherCodecountModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingActivityOrdervoucherCodecountModel : AopObject
    {
        /// <summary>
        /// 活动id
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 商户接入模式  枚举值 SELF_MODE 商户自接入模式 AGENCY_MODE 服务商代接入模式
        /// </summary>
        [XmlElement("merchant_access_mode")]
        public string MerchantAccessMode { get; set; }
    }
}
