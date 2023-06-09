using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayOpenMiniIndividualBusinessCertifyResponse.
    /// </summary>
    public class AlipayOpenMiniIndividualBusinessCertifyResponse : AopResponse
    {
        /// <summary>
        /// 个体工商户认证结果，true代表认证成功，false代表认证失败
        /// </summary>
        [XmlElement("certify_result")]
        public bool CertifyResult { get; set; }
    }
}
