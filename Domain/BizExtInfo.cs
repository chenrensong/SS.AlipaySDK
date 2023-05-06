using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// BizExtInfo Data Structure.
    /// </summary>
    [Serializable]
    public class BizExtInfo : AopObject
    {
        /// <summary>
        /// key-value
        /// </summary>
        [XmlElement("key")]
        public string Key { get; set; }
    }
}
