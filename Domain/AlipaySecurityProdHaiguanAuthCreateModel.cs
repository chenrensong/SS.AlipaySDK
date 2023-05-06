using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// AlipaySecurityProdHaiguanAuthCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityProdHaiguanAuthCreateModel : AopObject
    {
        /// <summary>
        /// 12
        /// </summary>
        [XmlElement("one")]
        public string One { get; set; }
    }
}
