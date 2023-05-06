using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayCommerceTransportAdStocktaskresultQueryResponse.
    /// </summary>
    public class AlipayCommerceTransportAdStocktaskresultQueryResponse : AopResponse
    {
        /// <summary>
        /// 库存查询结果
        /// </summary>
        [XmlElement("stock_task_result")]
        public StockTaskResult StockTaskResult { get; set; }
    }
}
