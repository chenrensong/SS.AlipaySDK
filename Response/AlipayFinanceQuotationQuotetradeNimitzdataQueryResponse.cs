using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayFinanceQuotationQuotetradeNimitzdataQueryResponse.
    /// </summary>
    public class AlipayFinanceQuotationQuotetradeNimitzdataQueryResponse : AopResponse
    {
        /// <summary>
        /// Nimitz数据返回结果，Json结构
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }
    }
}
