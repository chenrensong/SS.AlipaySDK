using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayMarketingCrowdDataSyncResponse.
    /// </summary>
    public class AlipayMarketingCrowdDataSyncResponse : AopResponse
    {
        /// <summary>
        /// 人群记录ID
        /// </summary>
        [XmlElement("crowd_record_id")]
        public string CrowdRecordId { get; set; }
    }
}
