using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayMarketingCampaignPrizeSendQueryResponse.
    /// </summary>
    public class AlipayMarketingCampaignPrizeSendQueryResponse : AopResponse
    {
        /// <summary>
        /// 中奖信息列表
        /// </summary>
        [XmlArray("prize_detail_list")]
        [XmlArrayItem("prize_detail")]
        public List<PrizeDetail> PrizeDetailList { get; set; }
    }
}
