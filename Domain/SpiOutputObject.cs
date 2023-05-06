using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// SpiOutputObject Data Structure.
    /// </summary>
    [Serializable]
    public class SpiOutputObject : AopObject
    {
        /// <summary>
        /// test
        /// </summary>
        [XmlElement("age")]
        public string Age { get; set; }
    }
}
