using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AnttechBlockchainDefinFinanceOrderSubmitResponse.
    /// </summary>
    public class AnttechBlockchainDefinFinanceOrderSubmitResponse : AopResponse
    {
        /// <summary>
        /// 业务结果
        /// </summary>
        [XmlElement("biz_result")]
        public BizResult BizResult { get; set; }
    }
}
