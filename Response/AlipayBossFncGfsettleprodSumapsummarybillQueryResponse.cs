using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayBossFncGfsettleprodSumapsummarybillQueryResponse.
    /// </summary>
    public class AlipayBossFncGfsettleprodSumapsummarybillQueryResponse : AopResponse
    {
        /// <summary>
        /// 统计金额
        /// </summary>
        [XmlElement("result_set")]
        public ApSumSummaryBillAmountDTO ResultSet { get; set; }
    }
}
