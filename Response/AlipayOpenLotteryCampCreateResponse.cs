using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayOpenLotteryCampCreateResponse.
    /// </summary>
    public class AlipayOpenLotteryCampCreateResponse : AopResponse
    {
        /// <summary>
        /// 返回新建的活动ID
        /// </summary>
        [XmlElement("camp_id")]
        public string CampId { get; set; }
    }
}
