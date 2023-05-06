using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// CheckDetails Data Structure.
    /// </summary>
    [Serializable]
    public class CheckDetails : AopObject
    {
        /// <summary>
        /// 替换旧SN的新SN
        /// </summary>
        [XmlElement("new_value")]
        public string NewValue { get; set; }

        /// <summary>
        /// SN
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
