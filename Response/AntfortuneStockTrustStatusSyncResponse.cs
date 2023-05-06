using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AntfortuneStockTrustStatusSyncResponse.
    /// </summary>
    public class AntfortuneStockTrustStatusSyncResponse : AopResponse
    {
        /// <summary>
        /// traceId，用来唯一定位某次调用，方便问题排查
        /// </summary>
        [XmlElement("trace_id")]
        public string TraceId { get; set; }
    }
}
