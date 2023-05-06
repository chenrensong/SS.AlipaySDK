using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayOpenSearchBoxactivityApplyResponse.
    /// </summary>
    public class AlipayOpenSearchBoxactivityApplyResponse : AopResponse
    {
        /// <summary>
        /// 搜索直达活动ID
        /// </summary>
        [XmlElement("box_activity_id")]
        public string BoxActivityId { get; set; }
    }
}
