using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// MybankMarketingCampaignPrizeListConsultResponse.
    /// </summary>
    public class MybankMarketingCampaignPrizeListConsultResponse : AopResponse
    {
        /// <summary>
        /// 可用的奖品列表
        /// </summary>
        [XmlArray("prize_list")]
        [XmlArrayItem("prize_model")]
        public List<PrizeModel> PrizeList { get; set; }
    }
}
