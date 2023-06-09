using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// MiniAppBaseInfoQueryInfo Data Structure.
    /// </summary>
    [Serializable]
    public class MiniAppBaseInfoQueryInfo : AopObject
    {
        /// <summary>
        /// 小程序id
        /// </summary>
        [XmlElement("mini_app_id")]
        public string MiniAppId { get; set; }
    }
}
