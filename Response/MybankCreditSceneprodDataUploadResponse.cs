using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// MybankCreditSceneprodDataUploadResponse.
    /// </summary>
    public class MybankCreditSceneprodDataUploadResponse : AopResponse
    {
        /// <summary>
        /// 网商traceId，便于查询日志内容
        /// </summary>
        [XmlElement("trace_id")]
        public string TraceId { get; set; }
    }
}
