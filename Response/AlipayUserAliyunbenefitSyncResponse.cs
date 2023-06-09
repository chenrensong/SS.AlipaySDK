using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayUserAliyunbenefitSyncResponse.
    /// </summary>
    public class AlipayUserAliyunbenefitSyncResponse : AopResponse
    {
        /// <summary>
        /// 权益Id
        /// </summary>
        [XmlElement("benefit_id")]
        public string BenefitId { get; set; }
    }
}
