using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayOpenLotteryCampModifyResponse.
    /// </summary>
    public class AlipayOpenLotteryCampModifyResponse : AopResponse
    {
        /// <summary>
        /// 抽奖活动ID
        /// </summary>
        [XmlElement("camp_id")]
        public string CampId { get; set; }
    }
}
