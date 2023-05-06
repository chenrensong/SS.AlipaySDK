using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayDataMdaGreenagrealtimeQueryResponse.
    /// </summary>
    public class AlipayDataMdaGreenagrealtimeQueryResponse : AopResponse
    {
        /// <summary>
        /// 今日完成公益任务人数
        /// </summary>
        [XmlElement("completed")]
        public long Completed { get; set; }

        /// <summary>
        /// 今日公益林参与人数
        /// </summary>
        [XmlElement("dau")]
        public long Dau { get; set; }
    }
}
