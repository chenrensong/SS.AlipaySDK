using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayBusinessOrderCheckinOrderinfoSyncResponse.
    /// </summary>
    public class AlipayBusinessOrderCheckinOrderinfoSyncResponse : AopResponse
    {
        /// <summary>
        /// 行业侧入住单唯一标识
        /// </summary>
        [XmlElement("object_id")]
        public string ObjectId { get; set; }

        /// <summary>
        /// 订单状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
