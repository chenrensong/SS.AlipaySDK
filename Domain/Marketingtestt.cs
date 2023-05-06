using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// Marketingtestt Data Structure.
    /// </summary>
    [Serializable]
    public class Marketingtestt : AopObject
    {
        /// <summary>
        /// sasa
        /// </summary>
        [XmlElement("test_22")]
        public Marketingtest Test22 { get; set; }
    }
}
