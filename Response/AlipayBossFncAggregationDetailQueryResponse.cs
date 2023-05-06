using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayBossFncAggregationDetailQueryResponse.
    /// </summary>
    public class AlipayBossFncAggregationDetailQueryResponse : AopResponse
    {
        /// <summary>
        /// 已入账金额（含税）
        /// </summary>
        [XmlElement("result_data")]
        public MultiCurrencyMoneyOpenApi ResultData { get; set; }
    }
}
