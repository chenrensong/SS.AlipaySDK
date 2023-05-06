using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayOpenMiniInneraccountPidQueryResponse.
    /// </summary>
    public class AlipayOpenMiniInneraccountPidQueryResponse : AopResponse
    {
        /// <summary>
        /// 虚拟PID
        /// </summary>
        [XmlElement("pid")]
        public string Pid { get; set; }
    }
}
