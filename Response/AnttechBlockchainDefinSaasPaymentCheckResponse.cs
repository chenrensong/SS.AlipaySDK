using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AnttechBlockchainDefinSaasPaymentCheckResponse.
    /// </summary>
    public class AnttechBlockchainDefinSaasPaymentCheckResponse : AopResponse
    {
        /// <summary>
        /// 检查是否通过。PASS(检查通过);NOT_PASS(检查不通过)
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }
    }
}
