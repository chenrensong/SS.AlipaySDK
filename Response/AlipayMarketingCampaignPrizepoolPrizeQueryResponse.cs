using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayMarketingCampaignPrizepoolPrizeQueryResponse.
    /// </summary>
    public class AlipayMarketingCampaignPrizepoolPrizeQueryResponse : AopResponse
    {
        /// <summary>
        /// 指定奖品id的详细配置
        /// </summary>
        [XmlElement("prize_config")]
        public PrizeConfig PrizeConfig { get; set; }
    }
}
