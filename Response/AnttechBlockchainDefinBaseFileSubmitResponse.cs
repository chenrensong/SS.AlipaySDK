using System;
using System.Xml.Serialization;
using SS.AlipaySDKaySDK.Domain;

namespace SS.AlipaySDKaySDK.Response
{
    /// <summary>
    /// AnttechBlockchainDefinBaseFileSubmitResponse.
    /// </summary>
    public class AnttechBlockchainDefinBaseFileSubmitResponse : AopResponse
    {
        /// <summary>
        /// 业务结果
        /// </summary>
        [XmlElement("biz_result")]
        public BizResult BizResult { get; set; }
    }
}
