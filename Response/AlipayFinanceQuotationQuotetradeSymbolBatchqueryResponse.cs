using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayFinanceQuotationQuotetradeSymbolBatchqueryResponse.
    /// </summary>
    public class AlipayFinanceQuotationQuotetradeSymbolBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 码表
        /// </summary>
        [XmlArray("data")]
        [XmlArrayItem("symbol_d_t_o")]
        public List<SymbolDTO> Data { get; set; }
    }
}
