using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// KbAdvertContentShortLink Data Structure.
    /// </summary>
    [Serializable]
    public class KbAdvertContentShortLink : AopObject
    {
        /// <summary>
        /// 链接地址
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
