using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayMerchantPayforprivilegeCardbinactivityQueryResponse.
    /// </summary>
    public class AlipayMerchantPayforprivilegeCardbinactivityQueryResponse : AopResponse
    {
        /// <summary>
        /// 查询到的卡bin活动信息
        /// </summary>
        [XmlElement("card_bin_info")]
        public CardBinActivityInfo CardBinInfo { get; set; }
    }
}
