using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayOpenMiniInneraccountCreateResponse.
    /// </summary>
    public class AlipayOpenMiniInneraccountCreateResponse : AopResponse
    {
        /// <summary>
        /// 虚拟PID
        /// </summary>
        [XmlElement("pid")]
        public string Pid { get; set; }
    }
}
