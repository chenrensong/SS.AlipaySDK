using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayOpenPublicCrowdInnerQueryResponse.
    /// </summary>
    public class AlipayOpenPublicCrowdInnerQueryResponse : AopResponse
    {
        /// <summary>
        /// 人群摘要信息
        /// </summary>
        [XmlElement("crowd_summary")]
        public CrowdSummary CrowdSummary { get; set; }
    }
}
