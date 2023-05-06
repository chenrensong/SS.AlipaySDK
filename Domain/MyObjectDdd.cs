using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// MyObjectDdd Data Structure.
    /// </summary>
    [Serializable]
    public class MyObjectDdd : AopObject
    {
        /// <summary>
        /// xx
        /// </summary>
        [XmlElement("item")]
        public string Item { get; set; }

        /// <summary>
        /// xxx
        /// </summary>
        [XmlElement("param")]
        public string Param { get; set; }
    }
}
