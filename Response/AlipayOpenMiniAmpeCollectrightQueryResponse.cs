using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayOpenMiniAmpeCollectrightQueryResponse.
    /// </summary>
    public class AlipayOpenMiniAmpeCollectrightQueryResponse : AopResponse
    {
        /// <summary>
        /// true为有上报权限
        /// </summary>
        [XmlElement("can_collect")]
        public bool CanCollect { get; set; }
    }
}
