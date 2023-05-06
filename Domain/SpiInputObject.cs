using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// SpiInputObject Data Structure.
    /// </summary>
    [Serializable]
    public class SpiInputObject : AopObject
    {
        /// <summary>
        /// test
        /// </summary>
        [XmlElement("age")]
        public string Age { get; set; }
    }
}
