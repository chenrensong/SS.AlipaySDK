using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayMarketingCampaignUserVoucherReceiveResponse.
    /// </summary>
    public class AlipayMarketingCampaignUserVoucherReceiveResponse : AopResponse
    {
        /// <summary>
        /// 券id：领取成功时返回
        /// </summary>
        [XmlElement("voucher_id")]
        public string VoucherId { get; set; }
    }
}
