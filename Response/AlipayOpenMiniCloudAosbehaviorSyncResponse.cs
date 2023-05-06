using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayOpenMiniCloudAosbehaviorSyncResponse.
    /// </summary>
    public class AlipayOpenMiniCloudAosbehaviorSyncResponse : AopResponse
    {
        /// <summary>
        /// 请求的traceid，用于排查问题
        /// </summary>
        [XmlElement("trace_id")]
        public string TraceId { get; set; }
    }
}
