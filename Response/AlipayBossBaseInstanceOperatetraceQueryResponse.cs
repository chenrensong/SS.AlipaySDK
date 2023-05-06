using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayBossBaseInstanceOperatetraceQueryResponse.
    /// </summary>
    public class AlipayBossBaseInstanceOperatetraceQueryResponse : AopResponse
    {
        /// <summary>
        /// 操作记录
        /// </summary>
        [XmlElement("operate_traces")]
        public BPOpenApiTicketOperateTraces OperateTraces { get; set; }
    }
}
