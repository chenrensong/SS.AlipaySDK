using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayInsScenePremiumPaySyncResponse.
    /// </summary>
    public class AlipayInsScenePremiumPaySyncResponse : AopResponse
    {
        /// <summary>
        /// 保单摘要
        /// </summary>
        [XmlElement("policy_digest")]
        public InsOpenPolicyDigestDTO PolicyDigest { get; set; }
    }
}
