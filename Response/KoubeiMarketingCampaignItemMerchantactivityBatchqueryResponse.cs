using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// KoubeiMarketingCampaignItemMerchantactivityBatchqueryResponse.
    /// </summary>
    public class KoubeiMarketingCampaignItemMerchantactivityBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 活动信息
        /// </summary>
        [XmlArray("activities")]
        [XmlArrayItem("merchant_online_activity_open_model")]
        public List<MerchantOnlineActivityOpenModel> Activities { get; set; }
    }
}
