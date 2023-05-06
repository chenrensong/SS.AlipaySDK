using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayDigitalopUcdpApedataSyncResponse.
    /// </summary>
    public class AlipayDigitalopUcdpApedataSyncResponse : AopResponse
    {
        /// <summary>
        /// 请求链路标识，用于排查问题
        /// </summary>
        [XmlElement("trace_id")]
        public string TraceId { get; set; }
    }
}
