using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayUserPeerpayprodAgreementQueryResponse.
    /// </summary>
    public class AlipayUserPeerpayprodAgreementQueryResponse : AopResponse
    {
        /// <summary>
        /// 亲情号协议的额度
        /// </summary>
        [XmlElement("quota")]
        public long Quota { get; set; }
    }
}
