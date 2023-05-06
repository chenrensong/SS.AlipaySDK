using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// AlipaySecurityProdFacePayCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityProdFacePayCreateModel : AopObject
    {
        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("aaa")]
        public string Aaa { get; set; }

        /// <summary>
        /// 2
        /// </summary>
        [XmlElement("aaaaaaaaaaaaa")]
        public string Aaaaaaaaaaaaa { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("bbbbb")]
        public string Bbbbb { get; set; }
    }
}
