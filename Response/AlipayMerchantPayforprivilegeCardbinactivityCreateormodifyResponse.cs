using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayMerchantPayforprivilegeCardbinactivityCreateormodifyResponse.
    /// </summary>
    public class AlipayMerchantPayforprivilegeCardbinactivityCreateormodifyResponse : AopResponse
    {
        /// <summary>
        /// 新增/修改的结果
        /// </summary>
        [XmlElement("card_bin_info")]
        public CardBinActivityInfo CardBinInfo { get; set; }
    }
}
