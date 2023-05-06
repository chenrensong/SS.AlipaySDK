using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayBossBaseProcessInstanceCreateResponse.
    /// </summary>
    public class AlipayBossBaseProcessInstanceCreateResponse : AopResponse
    {
        /// <summary>
        /// 创建的实例
        /// </summary>
        [XmlElement("instance")]
        public BPOpenApiInstance Instance { get; set; }
    }
}
