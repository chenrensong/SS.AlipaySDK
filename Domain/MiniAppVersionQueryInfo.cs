using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// MiniAppVersionQueryInfo Data Structure.
    /// </summary>
    [Serializable]
    public class MiniAppVersionQueryInfo : AopObject
    {
        /// <summary>
        /// 小程序版本号
        /// </summary>
        [XmlElement("app_version")]
        public string AppVersion { get; set; }
    }
}
