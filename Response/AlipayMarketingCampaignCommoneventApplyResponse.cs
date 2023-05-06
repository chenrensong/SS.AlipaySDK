using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayMarketingCampaignCommoneventApplyResponse.
    /// </summary>
    public class AlipayMarketingCampaignCommoneventApplyResponse : AopResponse
    {
        /// <summary>
        /// 与event关联的返回结果
        /// </summary>
        [XmlElement("data")]
        public string Data { get; set; }
    }
}
