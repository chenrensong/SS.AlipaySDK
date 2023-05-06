using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayBossFncGfsettleprodApsummarybillQueryResponse.
    /// </summary>
    public class AlipayBossFncGfsettleprodApsummarybillQueryResponse : AopResponse
    {
        /// <summary>
        /// 结果
        /// </summary>
        [XmlElement("result_set")]
        public ApSummaryBillPageDTO ResultSet { get; set; }
    }
}
