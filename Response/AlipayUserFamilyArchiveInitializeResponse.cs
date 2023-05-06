using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayUserFamilyArchiveInitializeResponse.
    /// </summary>
    public class AlipayUserFamilyArchiveInitializeResponse : AopResponse
    {
        /// <summary>
        /// 家人信息档案(选人授权)组件唤起地址
        /// </summary>
        [XmlElement("archive_plugin_url")]
        public string ArchivePluginUrl { get; set; }
    }
}
