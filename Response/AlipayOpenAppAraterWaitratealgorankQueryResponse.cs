using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayOpenAppAraterWaitratealgorankQueryResponse.
    /// </summary>
    public class AlipayOpenAppAraterWaitratealgorankQueryResponse : AopResponse
    {
        /// <summary>
        /// 待评价列表打分结果
        /// </summary>
        [XmlArray("wait_rate_rank_items")]
        [XmlArrayItem("wait_rate_algo_item")]
        public List<WaitRateAlgoItem> WaitRateRankItems { get; set; }
    }
}
