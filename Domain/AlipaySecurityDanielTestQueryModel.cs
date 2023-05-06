using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// AlipaySecurityDanielTestQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityDanielTestQueryModel : AopObject
    {
        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("input_query")]
        public string InputQuery { get; set; }
    }
}
