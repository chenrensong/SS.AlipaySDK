using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// AlipayOpenSearchAppkeywordquotaQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenSearchAppkeywordquotaQueryModel : AopObject
    {
        /// <summary>
        /// 小程序id
        /// </summary>
        [XmlElement("target_appid")]
        public string TargetAppid { get; set; }
    }
}
