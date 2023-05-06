using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// KoubeiQualityTestShieldResultSyncResponse.
    /// </summary>
    public class KoubeiQualityTestShieldResultSyncResponse : AopResponse
    {
        /// <summary>
        /// 扩展信息
        /// </summary>
        [XmlElement("ext_infos")]
        public string ExtInfos { get; set; }
    }
}
