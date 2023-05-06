using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayMarketingQipanCrowdwithtagCreateResponse.
    /// </summary>
    public class AlipayMarketingQipanCrowdwithtagCreateResponse : AopResponse
    {
        /// <summary>
        /// 人群id
        /// </summary>
        [XmlElement("crowd_id")]
        public string CrowdId { get; set; }
    }
}
