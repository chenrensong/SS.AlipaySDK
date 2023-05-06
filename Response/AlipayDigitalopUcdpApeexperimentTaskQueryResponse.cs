using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayDigitalopUcdpApeexperimentTaskQueryResponse.
    /// </summary>
    public class AlipayDigitalopUcdpApeexperimentTaskQueryResponse : AopResponse
    {
        /// <summary>
        /// 任务状态，success（成功）、fail（失败）、processing（处理中）
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
