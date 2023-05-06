using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayMarketingCampaignPrizepoolPrizeCreateResponse.
    /// </summary>
    public class AlipayMarketingCampaignPrizepoolPrizeCreateResponse : AopResponse
    {
        /// <summary>
        /// 奖品id
        /// </summary>
        [XmlElement("prize_id")]
        public string PrizeId { get; set; }
    }
}
