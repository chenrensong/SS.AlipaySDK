using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// MybankMarketingCampaignBkpromosceneorderOrderSyncResponse.
    /// </summary>
    public class MybankMarketingCampaignBkpromosceneorderOrderSyncResponse : AopResponse
    {
        /// <summary>
        /// 将请求参数中的request_id返回
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }
    }
}
