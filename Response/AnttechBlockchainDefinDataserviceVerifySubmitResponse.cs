using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AnttechBlockchainDefinDataserviceVerifySubmitResponse.
    /// </summary>
    public class AnttechBlockchainDefinDataserviceVerifySubmitResponse : AopResponse
    {
        /// <summary>
        /// 业务结果
        /// </summary>
        [XmlElement("biz_result")]
        public string BizResult { get; set; }
    }
}
