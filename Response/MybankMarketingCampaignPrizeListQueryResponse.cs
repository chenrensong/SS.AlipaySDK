using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// MybankMarketingCampaignPrizeListQueryResponse.
    /// </summary>
    public class MybankMarketingCampaignPrizeListQueryResponse : AopResponse
    {
        /// <summary>
        /// 奖品列表
        /// </summary>
        [XmlArray("prize_list")]
        [XmlArrayItem("prize_model")]
        public List<PrizeModel> PrizeList { get; set; }

        /// <summary>
        /// 奖品总个数
        /// </summary>
        [XmlElement("total_size")]
        public long TotalSize { get; set; }
    }
}
