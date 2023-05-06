using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// AlipaySecurityProdHaiguanNolabelCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityProdHaiguanNolabelCreateModel : AopObject
    {
        /// <summary>
        /// 23
        /// </summary>
        [XmlElement("one")]
        public string One { get; set; }
    }
}
