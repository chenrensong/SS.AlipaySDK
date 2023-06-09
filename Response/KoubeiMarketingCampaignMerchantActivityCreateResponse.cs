using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// KoubeiMarketingCampaignMerchantActivityCreateResponse.
    /// </summary>
    public class KoubeiMarketingCampaignMerchantActivityCreateResponse : AopResponse
    {
        /// <summary>
        /// 创建成功之后返回活动详情信息，包含活动activity_id和活动当前状态activity_status等信息。
        /// </summary>
        [XmlElement("activity_detail_info")]
        public MActivityDetailInfo ActivityDetailInfo { get; set; }
    }
}
