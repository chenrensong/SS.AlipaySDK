using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// Gavintest Data Structure.
    /// </summary>
    [Serializable]
    public class Gavintest : AopObject
    {
        /// <summary>
        /// 测试
        /// </summary>
        [XmlElement("newid")]
        public long Newid { get; set; }
    }
}
