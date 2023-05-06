using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayInsSceneEcommerceClaimApplyResponse.
    /// </summary>
    public class AlipayInsSceneEcommerceClaimApplyResponse : AopResponse
    {
        /// <summary>
        /// 理赔单摘要
        /// </summary>
        [XmlElement("claim_digest")]
        public InsOpenClaimDigestDTO ClaimDigest { get; set; }
    }
}
