using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// AlipayBossBaseProcessInstanceQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossBaseProcessInstanceQueryModel : AopObject
    {
        /// <summary>
        /// 流程全局唯一ID
        /// </summary>
        [XmlElement("puid")]
        public string Puid { get; set; }
    }
}
