using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// ConsultExtParams Data Structure.
    /// </summary>
    [Serializable]
    public class ConsultExtParams : AopObject
    {
        /// <summary>
        /// key-value
        /// </summary>
        [XmlElement("key")]
        public string Key { get; set; }
    }
}
