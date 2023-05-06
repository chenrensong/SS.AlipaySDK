using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// HomeAwayInfo Data Structure.
    /// </summary>
    [Serializable]
    public class HomeAwayInfo : AopObject
    {
        /// <summary>
        /// 客队数据
        /// </summary>
        [XmlElement("away")]
        public long Away { get; set; }

        /// <summary>
        /// 主队数据
        /// </summary>
        [XmlElement("home")]
        public long Home { get; set; }
    }
}
