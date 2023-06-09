using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// KoubeiMarketingCampaignMerchantActivityBatchqueryResponse.
    /// </summary>
    public class KoubeiMarketingCampaignMerchantActivityBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 活动详细信息
        /// </summary>
        [XmlArray("activity_detail_info_list")]
        [XmlArrayItem("m_activity_detail_info")]
        public List<MActivityDetailInfo> ActivityDetailInfoList { get; set; }
    }
}
