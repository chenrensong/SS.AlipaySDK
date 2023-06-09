using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayEbppInvoiceUserTradeQueryResponse.
    /// </summary>
    public class AlipayEbppInvoiceUserTradeQueryResponse : AopResponse
    {
        /// <summary>
        /// 发票管家发票交易信息
        /// </summary>
        [XmlElement("trade_info")]
        public InvoiceTradeInfo TradeInfo { get; set; }
    }
}
