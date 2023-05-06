using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// AlipaySecurityProdFacePayModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityProdFacePayModel : AopObject
    {
        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("a")]
        public string A { get; set; }
    }
}
