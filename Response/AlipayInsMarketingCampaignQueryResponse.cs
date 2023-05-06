using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayInsMarketingCampaignQueryResponse.
    /// </summary>
    public class AlipayInsMarketingCampaignQueryResponse : AopResponse
    {
        /// <summary>
        /// 保险营销活动信息
        /// </summary>
        [XmlElement("mkt_campaign")]
        public InsMktCampaignDTO MktCampaign { get; set; }
    }
}
