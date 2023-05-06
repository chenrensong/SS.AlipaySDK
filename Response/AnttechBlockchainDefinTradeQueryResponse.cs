using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AnttechBlockchainDefinTradeQueryResponse.
    /// </summary>
    public class AnttechBlockchainDefinTradeQueryResponse : AopResponse
    {
        /// <summary>
        /// biz_result
        /// </summary>
        [XmlElement("biz_result")]
        public BizResult BizResult { get; set; }
    }
}
