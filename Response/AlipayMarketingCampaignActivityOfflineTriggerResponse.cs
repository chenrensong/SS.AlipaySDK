using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayMarketingCampaignActivityOfflineTriggerResponse.
    /// </summary>
    public class AlipayMarketingCampaignActivityOfflineTriggerResponse : AopResponse
    {
        /// <summary>
        /// 外部奖品ID
        /// </summary>
        [XmlElement("out_prize_id")]
        public string OutPrizeId { get; set; }
    }
}
