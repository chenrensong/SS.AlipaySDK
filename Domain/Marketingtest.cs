using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// Marketingtest Data Structure.
    /// </summary>
    [Serializable]
    public class Marketingtest : AopObject
    {
        /// <summary>
        /// 测试描述
        /// </summary>
        [XmlElement("test_21")]
        public string Test21 { get; set; }
    }
}
