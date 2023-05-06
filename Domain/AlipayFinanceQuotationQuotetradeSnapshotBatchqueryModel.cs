using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// AlipayFinanceQuotationQuotetradeSnapshotBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFinanceQuotationQuotetradeSnapshotBatchqueryModel : AopObject
    {
        /// <summary>
        /// 股票唯一编码，symbol=code.market
        /// </summary>
        [XmlArray("symbols")]
        [XmlArrayItem("string")]
        public List<string> Symbols { get; set; }
    }
}
