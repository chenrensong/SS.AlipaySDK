using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayMarketingCampaignSelfVoucherQueryResponse.
    /// </summary>
    public class AlipayMarketingCampaignSelfVoucherQueryResponse : AopResponse
    {
        /// <summary>
        /// 券列表
        /// </summary>
        [XmlElement("voucher_item")]
        public VoucherItem VoucherItem { get; set; }
    }
}
