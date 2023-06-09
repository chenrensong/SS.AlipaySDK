using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayCommerceTransportAdStocktaskBatchqueryResponse.
    /// </summary>
    public class AlipayCommerceTransportAdStocktaskBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 库存查询任务
        /// </summary>
        [XmlArray("stock_task")]
        [XmlArrayItem("stock_task")]
        public List<StockTask> StockTask { get; set; }
    }
}
