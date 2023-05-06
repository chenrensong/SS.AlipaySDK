using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// XwbTestData Data Structure.
    /// </summary>
    [Serializable]
    public class XwbTestData : AopObject
    {
        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("s")]
        public string S { get; set; }
    }
}
