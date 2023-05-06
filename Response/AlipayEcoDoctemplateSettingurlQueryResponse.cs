using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayEcoDoctemplateSettingurlQueryResponse.
    /// </summary>
    public class AlipayEcoDoctemplateSettingurlQueryResponse : AopResponse
    {
        /// <summary>
        /// 模板设置地址
        /// </summary>
        [XmlElement("setting_url")]
        public string SettingUrl { get; set; }
    }
}
