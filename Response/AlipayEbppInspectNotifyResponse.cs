using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayEbppInspectNotifyResponse.
    /// </summary>
    public class AlipayEbppInspectNotifyResponse : AopResponse
    {
        /// <summary>
        /// 结果同步状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
