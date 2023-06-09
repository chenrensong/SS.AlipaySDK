using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayTradeBatchRefundQueryResponse.
    /// </summary>
    public class AlipayTradeBatchRefundQueryResponse : AopResponse
    {
        /// <summary>
        /// 退款明细信息
        /// </summary>
        [XmlArray("result_details")]
        [XmlArrayItem("batch_refund_detail_result")]
        public List<BatchRefundDetailResult> ResultDetails { get; set; }
    }
}
