using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayInsSceneQuoteDetailQueryResponse.
    /// </summary>
    public class AlipayInsSceneQuoteDetailQueryResponse : AopResponse
    {
        /// <summary>
        /// 报价详情
        /// </summary>
        [XmlElement("quote_detail")]
        public InsQuoteDTO QuoteDetail { get; set; }
    }
}
