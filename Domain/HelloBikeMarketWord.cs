using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// HelloBikeMarketWord Data Structure.
    /// </summary>
    [Serializable]
    public class HelloBikeMarketWord : AopObject
    {
        /// <summary>
        /// 关键字
        /// </summary>
        [XmlElement("words")]
        public string Words { get; set; }

        /// <summary>
        /// 关键字类型
        /// </summary>
        [XmlElement("words_type")]
        public string WordsType { get; set; }
    }
}
