using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayCommerceTransportAdStocktaskQueryResponse.
    /// </summary>
    public class AlipayCommerceTransportAdStocktaskQueryResponse : AopResponse
    {
        /// <summary>
        /// 库存任务执行情况
        /// </summary>
        [XmlElement("stock_task")]
        public StockTask StockTask { get; set; }
    }
}
